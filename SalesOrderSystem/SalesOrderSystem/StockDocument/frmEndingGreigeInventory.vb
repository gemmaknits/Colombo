Imports System.Data.SqlClient

Public Class frmEndingGreigeInventory
    Private strUserID As String = ""
    Dim clsUser As New classUserInfo
    Dim config As clsConfig

    Public Property UserInfo() As classUserInfo
        Get
            UserInfo = clsUser
        End Get
        Set(ByVal NewValue As classUserInfo)
            clsUser = NewValue
        End Set
    End Property

    Private Function GetData(ByVal rollNo As String) As DataTable
        Dim clsconfig As New clsConfig
        Dim message As String = String.Empty
        'Dim conn As SqlConnection = New classConnection().getSQLConnection()
        Dim conn As New SqlConnection((New classConnection).connection)
        conn.Open()

        Dim tran As SqlTransaction = conn.BeginTransaction
        Dim comm As New SqlCommand("", conn)  '= New SqlCommand("exec p_ending_greige_inventory_update '" & rollNo & "'", conn)
        comm.Transaction = tran
        comm.CommandType = CommandType.StoredProcedure

        comm.CommandText = "p_ending_greige_inventory_update"
        comm.Parameters.Clear()
        comm.Parameters.AddWithValue("@barcode", rollNo)
        comm.Parameters.AddWithValue("@mtl_warehouse_id", clsconfig.IsNull(cbomtl_warehouse.SelectedValue, DBNull.Value))
        comm.Parameters.AddWithValue("@mtl_subinventory_id", clsconfig.IsNull(cbomtl_subinventory.SelectedValue, DBNull.Value))
        comm.Parameters.AddWithValue("@mtl_locations_id", clsconfig.IsNull(cbomtl_location.SelectedValue, DBNull.Value))
        comm.Parameters.AddWithValue("@rem_qc", txtRemark.Text.Trim)
        comm.Parameters.AddWithValue("@logempcd", clsUser.UserID)
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable

        Try
            da.Fill(dt)
        Catch ex As Exception
            message = ex.Message
            tran.Rollback()
            conn.Close()
            MessageBox.Show(message, "System Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return GetData("")
        End Try

        tran.Commit()
        conn.Close()
        Return dt
    End Function

    Private Sub frmEndingGreigeInventory_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized

        Call InitControl()

    End Sub
    Private Sub InitControl()

        Call Gencombo()

        Dim dt As DataTable
        grdData.AutoGenerateColumns = False
        dt = GetData("")
        grdData.DataSource = dt ' GetData("")
        If Not dt Is Nothing Then
            If dt.Rows.Count > 0 Then

                cbomtl_warehouse.SelectedValue = dt.Rows(0)("mtl_warehouse_id")
                Call GetComboNewSubInventory(Int64mtl_warehouse_id:=dt.Rows(0)("mtl_warehouse_id"))
                cbomtl_subinventory.SelectedValue = dt.Rows(0)("mtl_subinventory_id")
                Call GetComboLocation(Int64mtl_warehouse_id:=dt.Rows(0)("mtl_warehouse_id"), Int64mtl_subinventory_id:=dt.Rows(0)("mtl_subinventory_id"))

            End If
        End If

        ErrorProvider1.Clear()

        txtBarcode.Focus()

    End Sub
    Private Sub Gencombo()
        Dim objdb As New classMaster


        cbomtl_warehouse.DataSource = objdb.Combomtlwarehouse(clsUser.UserID)
        cbomtl_warehouse.DisplayMember = "warehouse_code"
        cbomtl_warehouse.ValueMember = "mtl_warehouse_id"
        'SetDefaultWarehouse(cbomtl_warehouse.DataSource)

        cbomtl_subinventory.DataSource = objdb.ComboMtlsubinventory(INt64mtl_warehouse_id:=(New clsConfig).IsNull(cbomtl_warehouse.SelectedValue, Nothing))
        cbomtl_subinventory.DisplayMember = "subinventory_code"
        cbomtl_subinventory.ValueMember = "mtl_subinventory_id"
        'SetDefaultSubInventory(cbomtl_subinventory.DataSource)

        cbomtl_location.DataSource = objdb.Combomtllocations(strUSerID:=clsUser.UserID, _
                                                             INt64mtl_warehouse_id:=(New clsConfig).IsNull(cbomtl_warehouse.SelectedValue, Nothing) _
                                                             , Int64mtl_subinventory_id:=(New clsConfig).IsNull(cbomtl_subinventory.SelectedValue, Nothing))
        cbomtl_location.DisplayMember = "location_name"
        cbomtl_location.ValueMember = "mtl_locations_id"
        'SetDefaultLocation(cbomtl_location.DataSource)

        mtl_warehouse.DataSource = objdb.Combomtlwarehouse(clsUser.UserID)
        mtl_warehouse.DisplayMember = "warehouse_code"
        mtl_warehouse.ValueMember = "mtl_warehouse_id"

        mtl_subinventory.DataSource = objdb.ComboMtlsubinventory(INt64mtl_warehouse_id:=0)
        mtl_subinventory.DisplayMember = "subinventory_code"
        mtl_subinventory.ValueMember = "mtl_subinventory_id"

        mtl_locations.DataSource = objdb.Combomtllocations(strUSerID:=clsUser.UserID, INt64mtl_warehouse_id:=0, Int64mtl_subinventory_id:=0)
        mtl_locations.ValueMember = "mtl_locations_id"
        mtl_locations.DisplayMember = "location_name"
        'mtl_warehouse_id.SelectedIndex = -1
    End Sub



    Private Function GenCBOCombomtllocations(ByRef cbomtlloc As DataGridViewComboBoxColumn) As DataGridViewComboBoxColumn
        Dim objdb As New classMaster

        '=============================
        cbomtlloc.DataSource = objdb.Combomtllocations(clsUser.UserID)
        cbomtlloc.ValueMember = "mtl_locations_id"
        cbomtlloc.DisplayMember = "location_name"

        Return cbomtlloc

    End Function

    Private Sub frmEndingGreigeInventory_Activated(sender As System.Object, e As System.EventArgs) Handles MyBase.Activated
        Call InitControl()
        'txtBarcode.Focus()
    End Sub

    Private Sub btnNew_Click(sender As System.Object, e As System.EventArgs) Handles btnNew.Click
        If MessageBox.Show("Would you like to clear all data ?", "System Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then grdData.DataSource = GetData("NEW")
        Call InitControl()
        txtBarcode.Focus()
    End Sub

    Private Sub btnSave_Click(sender As System.Object, e As System.EventArgs) Handles btnSave.Click

        If Not CheckData() Then Exit Sub

        Dim clsconfig As New clsConfig
        Dim StrLoc As String = Trim(New clsConfig().IsNull(cbomtl_location.Text, ""))


        If StrLoc.Trim.Length > 0 Then
            If MessageBox.Show("Would you like to Update Location ?", "System Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then

                'grdData.DataSource = GetData("LOCATION " & StrLoc.Trim)
                Call SaveData()
                ErrorProvider1.Clear()
                Call InitControl()
            End If
        End If

        txtBarcode.Focus()
    End Sub

    Private Function CheckData() As Boolean

        For Each row As DataGridViewRow In grdData.Rows
            If IsDBNull((row.Cells("mtl_locations").Value)) Then
                MessageBox.Show("คุณยังไม่ไดเลือก locations")
                ErrorProvider1.SetError(grdData, "คุณยังไม่ไดเลือก locations")
                CheckData = False
                Exit Function
            End If
        Next
        'If (New clsConfig).IsNull(cbomtl_warehouse.SelectedValue, 0) = 0 Then
        '    MessageBox.Show("คุณยังไม่ไดเลือก WareHouse")
        '    ErrorProvider1.SetError(cbomtl_warehouse, "คุณยังไม่ไดเลือก WareHouse")
        '    Return False
        '    Exit Function
        'End If

        'If (New clsConfig).IsNull(cbomtl_subinventory.SelectedValue, 0) = 0 Then
        '    ErrorProvider1.SetError(cbomtl_subinventory, "คุณยังไม่ไดเลือก SubInventory")
        '    MessageBox.Show("คุณยังไม่ไดเลือก SubInventory")
        '    Return False
        '    Exit Function
        'End If

        'If (New clsConfig).IsNull(cbomtl_location.SelectedValue, 0) = 0 Then
        '    ErrorProvider1.SetError(cbomtl_location, "คุณยังไม่ไดเลือก Location ")
        '    MessageBox.Show("คุณยังไม่ไดเลือก Location ")
        '    Return False
        '    Exit Function
        'End If

        Return True
    End Function

    Private Function SaveData() As Boolean

        If grdData.Rows.Count > 0 Then
            For i = 0 To grdData.Rows.Count - 1
                grdData.Rows(i).Cells("loc").Value = grdData.Rows(i).Cells("mtl_locations").FormattedValue.ToString()
            Next
        End If

        Dim dtc As DataTable = grdData.DataSource
        Dim objdb As New classEndingGreigeInventory
        Dim Message As String = ""

        If objdb.EndingGreigeInventorySave(dtc:=dtc, Message:=Message) Then
            MessageBox.Show("Save Completed", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
        Else
            MessageBox.Show(Message, "System Message", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
        End If


    End Function
    Private Function Updatetmp() As Boolean

        Dim objdb As New classEndingGreigeInventory
        Dim dtc As DataTable = grdData.DataSource 'Add By Neung
        Dim dv_dtc_add As New DataView(dtc, "", "", DataViewRowState.Added) 'Add By Neung
        Dim dv_dtc_upd As New DataView(dtc, "", "", DataViewRowState.ModifiedCurrent) 'Add By Neung
        Dim dv_dtc_del As New DataView(dtc, "", "", DataViewRowState.Deleted) 'Add By Neung
        Dim Greige_header As New classEndingGreigeInventory.Greige_Header 'Add By Neung

        If objdb.EndingGreigeInventorySaveTmp(dtc, Greige_header, clsUser) Then 'Add By Neung
            Updatetmp = True

        Else
            Updatetmp = False

        End If 'Add By Neung
    End Function

    Private Sub btnPrint_Click(sender As System.Object, e As System.EventArgs) Handles btnPrint.Click
        Dim clsConn As New classConnection
        Dim clsConfig As New clsConfig
        Dim rptFileName As String = "rptEndingGreigeInventory.rpt"
        Dim frm As New frmReport

        If Not clsConfig.CheckReport(clsUser.ReportPath, rptFileName) Then Exit Sub
        Dim rpt As New CrystalDecisions.CrystalReports.Engine.ReportDocument
        Me.Cursor = Cursors.WaitCursor

        rpt.Load(clsUser.ReportPath & rptFileName)
        rpt.DataSourceConnections.Item(0).SetConnection(clsConn.servername, clsConn.database, False)
        rpt.DataSourceConnections.Item(0).SetLogon(clsConn.Userid, clsConn.Password)
        rpt.VerifyDatabase()
        rpt.SetParameterValue("@logempcd", clsUser.UserID)
        'rpt.SetParameterValue("@docno", txtDocNo.Text)

        'rpt.PrintOptions.PaperSize = CrystalDecisions.Shared.PaperSize.PaperA4
        'rpt.PrintOptions.PaperOrientation = CrystalDecisions.Shared.PaperOrientation.Portrait
        'rpt.PrintOptions.PaperSource = CrystalDecisions.Shared.PaperSource.Auto

        'frm.CRViewer.DisplayGroupTree = False
        frm.CRViewer.ReportSource = rpt
        frm.MdiParent = Me.ParentForm
        frm.Title = "Ending Greige Inventory"
        frm.Show()
        Me.Cursor = Cursors.Default
        txtBarcode.Focus()
    End Sub

    Private Sub btnMinimized_Click(sender As System.Object, e As System.EventArgs) Handles btnMinimized.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub btnExit_Click(sender As System.Object, e As System.EventArgs) Handles btnExit.Click
        If MessageBox.Show("Would you like to exit ?", "System Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then Me.Close()
    End Sub

    Private Sub txtBarcode_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles txtBarcode.KeyDown
        If e.KeyCode = Keys.Enter Then
            Dim barcode As String = txtBarcode.Text.Trim
            txtBarcode.Text = ""
            txtBarcode.ReadOnly = True

            If barcode.Length = 0 Then GoTo ExitSub

            'Dim dt As DataTable = GetData(barcode)
            Dim dt As New DataTable
            dt = GetData(barcode)
            'grdData.DataSource = GetData(barcode)
            grdData.DataSource = dt
            If Not dt Is Nothing Then
                If dt.Rows.Count > 0 Then
                    cbomtl_warehouse.SelectedValue = dt.Rows(0)("mtl_warehouse_id")
                    Call GetComboNewSubInventory(Int64mtl_warehouse_id:=dt.Rows(0)("mtl_warehouse_id"))
                    cbomtl_subinventory.SelectedValue = dt.Rows(0)("mtl_subinventory_id")
                    Call GetComboLocation(Int64mtl_warehouse_id:=dt.Rows(0)("mtl_warehouse_id"), Int64mtl_subinventory_id:=dt.Rows(0)("mtl_subinventory_id"))
                End If
            End If
            'If dt.Rows.Count > 1 Then grdData.FirstDisplayedScrollingRowIndex = dt.Rows.Count - 1

ExitSub:
            txtBarcode.ReadOnly = False
            txtBarcode.Focus()
        End If
    End Sub

    Private Sub grdData_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles grdData.KeyDown
        If e.KeyCode = Keys.Delete Then
            Dim dt As DataTable = grdData.DataSource
            If dt.Rows.Count > 0 Then
                If Val(grdData.CurrentRow.Cells("id").Value) > 0 Then
                    If MessageBox.Show("Would you like to remove item number " & grdData.CurrentRow.Cells("row_number").Value.ToString() & " ?", "System Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                        grdData.DataSource = GetData("DELETE " & grdData.CurrentRow.Cells("id").Value.ToString())
                    End If
                End If
            End If
        End If

        txtBarcode.Focus()
    End Sub

    Private Sub txtBarcode_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtBarcode.TextChanged

    End Sub

    Private Sub grdData_CellContentClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles grdData.CellContentClick

    End Sub

    Private Sub btnLocations_Click(sender As System.Object, e As System.EventArgs)
        Dim frm2 As New frmmtl_locations
        frm2.UserInfo = clsUser
        frm2.p_mtl_warehouse_id = cbomtl_warehouse.SelectedValue
        frm2.p_mtl_subinventory_id = cbomtl_subinventory.SelectedValue ' = YARN STOCK
        frm2.ShowDialog()

        If frm2.dtLocations.Rows.Count > 0 Then
            cbomtl_location.DataSource = frm2.dtLocations
        End If

        GenCboLocation()
        'cbomtl_location.SelectedValue=1

    End Sub

    Private Sub cbomtl_warehouse_DropDownClosed(sender As Object, e As System.EventArgs) Handles cbomtl_warehouse.DropDownClosed
        Call GetComboNewSubInventory(Int64mtl_warehouse_id:=(New clsConfig).IsNull(cbomtl_warehouse.SelectedValue, Nothing))

        Call GetComboLocation(Int64mtl_warehouse_id:=(New clsConfig).IsNull(cbomtl_warehouse.SelectedValue, Nothing), _
                              Int64mtl_subinventory_id:=(New clsConfig).IsNull(cbomtl_subinventory.SelectedValue, Nothing))

        'GenCboLocation()
    End Sub
    Private Sub GetComboLocation(Optional ByVal Int64mtl_warehouse_id As Nullable(Of Int64) = Nothing, Optional ByVal Int64mtl_subinventory_id As Nullable(Of Int64) = Nothing)
        Dim objdb As New classMaster
        cbomtl_location.DataSource = objdb.Combomtllocations(strUSerID:=clsUser.UserID, INt64mtl_warehouse_id:=Int64mtl_warehouse_id, Int64mtl_subinventory_id:=Int64mtl_subinventory_id)
        cbomtl_location.DisplayMember = "location_name"
        cbomtl_location.ValueMember = "mtl_locations_id"
        'Dim clsconfig As New clsConfig
        'If clsconfig.IsNull(cbomtl_location.SelectedValue, 0) = 0 Then SetDefaultLocation(cbomtl_location.DataSource)
        'SetDefaultLocation(cbomtl_location.DataSource)
    End Sub

    Private Sub GetComboNewSubInventory(Optional ByVal Int64mtl_warehouse_id As Nullable(Of Int64) = Nothing)
        Dim objdb As New classMaster

        cbomtl_subinventory.DataSource = objdb.ComboMtlsubinventory(Int64mtl_warehouse_id)
        cbomtl_subinventory.DisplayMember = "subinventory_code"
        cbomtl_subinventory.ValueMember = "mtl_subinventory_id"
        'Dim clsconfig As New clsConfig
        'If clsconfig.IsNull(cbomtl_subinventory.SelectedValue, 0) = 0 Then SetDefaultSubInventory(cbomtl_subinventory.DataSource)

    End Sub

    Private Sub SetDefaultWarehouse(ByVal dt As DataTable)
        Dim expression As String
        expression = "warehouse_code like '%ESH%'"
        Dim foundRows() As DataRow
        foundRows = dt.Select(expression)

        cbomtl_warehouse.SelectedValue = foundRows(0)(0)

    End Sub

    Private Sub SetDefaultSubInventory(ByVal dt As DataTable)
        Dim expression As String
        expression = "subinventory_code like '%GREIGE%'"
        Dim foundRows() As DataRow
        foundRows = dt.Select(expression)

        cbomtl_subinventory.SelectedValue = foundRows(0)("mtl_subinventory_id")

    End Sub

    Private Sub SetDefaultLocation(ByVal dt As DataTable)
        Dim expression As String
        expression = "location_name like '%N/A%'"
        Dim foundRows() As DataRow
        foundRows = dt.Select(expression)
        If foundRows.Length > 0 Then cbomtl_location.SelectedValue = foundRows(0)(0)
        'cbomtl_location.SelectedValue = foundRows(0)(0)

    End Sub
    Private Sub GenCboLocation()
        Dim objDB As New classMaster
        Dim dt As New DataTable
        cbomtl_location.SelectedIndex = -1
        dt = objDB.Getmtl_locations(cbomtl_warehouse.SelectedValue, cbomtl_subinventory.SelectedValue)

        Bindgrdmtl_Locations(mtl_Locations:=dt)
    End Sub

    Private Sub Bindgrdmtl_Locations(ByVal mtl_Locations As DataTable)

        cbomtl_location.DataSource = Nothing
        cbomtl_location.DataSource = mtl_Locations
        cbomtl_location.ValueMember = "mtl_locations_id"
        cbomtl_location.DisplayMember = "location_name"

    End Sub
    Private Sub cbomtl_warehouse_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cbomtl_warehouse.SelectedIndexChanged

    End Sub

    Private Sub cbomtl_subinventory_DropDownClosed(sender As Object, e As System.EventArgs) Handles cbomtl_subinventory.DropDownClosed
        Call GetComboLocation(Int64mtl_warehouse_id:=(New clsConfig).IsNull(cbomtl_warehouse.SelectedValue, Nothing), _
                              Int64mtl_subinventory_id:=(New clsConfig).IsNull(cbomtl_subinventory.SelectedValue, Nothing))
    End Sub

    Private Sub cbomtl_subinventory_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cbomtl_subinventory.SelectedIndexChanged

    End Sub

    Private Sub grdData_CellBeginEdit(sender As Object, e As DataGridViewCellCancelEventArgs) Handles grdData.CellBeginEdit
        Dim objdb As New classMaster
        Dim dgvccSubInven As New DataGridViewComboBoxCell
        Dim dtSubInven As New DataTable


        Dim dgvcc As New DataGridViewComboBoxCell
        Dim dt3 As New DataTable
        If grdData.Columns(e.ColumnIndex).Name = "mtl_locations" Then
            If Not IsDBNull(grdData.Rows(e.RowIndex).Cells("mtl_warehouse").Value) And Not IsDBNull(grdData.Rows(e.RowIndex).Cells("mtl_subinventory").Value) Then
                dt3 = objdb.Combomtllocations(clsUser.UserID, grdData.Rows(e.RowIndex).Cells("mtl_warehouse").Value, grdData.Rows(e.RowIndex).Cells("mtl_subinventory").Value)
                dgvcc = grdData.Rows(e.RowIndex).Cells("mtl_locations")
                Try
                    dgvcc.DataSource = dt3
                    dgvcc.DisplayMember = "location_name"
                    dgvcc.ValueMember = "mtl_locations_id"
                    dgvcc.Value = dt3.Rows(0)("mtl_locations_id") 'Fix Error
                Catch ex As Exception
                    dgvcc.DataSource = dt3
                    dgvcc.DisplayMember = "location_name"
                    dgvcc.ValueMember = "mtl_locations_id"
                    dgvcc.Value = DBNull.Value
                End Try
            End If
        End If
    End Sub

    Private Sub btnDel_Click(sender As Object, e As EventArgs) Handles btnDel.Click
        Call DeleteRow(grdData.CurrentRow.Index)
        txtBarcode.Focus()
    End Sub

    Private Sub DeleteRow(RowNo As Integer)
        With grdData
            grdData.DataSource = GetData("DELETE " & grdData.Rows(RowNo).Cells("id").Value.ToString)
        End With
    End Sub

    Private Sub BtnApplyLocAll_Click(sender As System.Object, e As System.EventArgs) Handles BtnApplyLocAll.Click
        For i = 0 To grdData.Rows.Count - 1
            ApplyLocations(i)
        Next
    End Sub

    Private Sub ApplyLocations(RowNo As Integer)
        With grdData
            If Not CheckDupicateSubinventory(RowNo) Then GoTo LastLine 'ไม่แก้ไข Subinventory ที่ต่างกัน
            grdData.Rows(RowNo).Cells("mtl_locations").Value = cbomtl_location.SelectedValue
            grdData.Rows(RowNo).Cells("loc").Value = cbomtl_location.Text 'grdData.Rows(RowNo).Cells("mtl_locations").FormattedValue.ToString()
LastLine:
        End With

    End Sub

    Private Sub BtnApplyLocCurrent_Click(sender As System.Object, e As System.EventArgs) Handles BtnApplyLocCurrent.Click
        ApplyLocations(grdData.CurrentRow.Index)
    End Sub

    Private Function CheckDupicateSubinventory(ByVal RowNo As Integer) As Boolean
        If grdData.Rows(RowNo).Cells("mtl_warehouse").Value = cbomtl_warehouse.SelectedValue And grdData.Rows(RowNo).Cells("mtl_subinventory").Value = cbomtl_subinventory.SelectedValue Then
            Return True
        End If
        'If grdData.Rows(RowNo).Cells("mtl_subinventory").Value = cbomtl_subinventory.SelectedValue Then
        '    Return True
        'End If

        Return False
    End Function

    Private Sub grdData_CellClick(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles grdData.CellClick
        Dim rowno As Integer
        rowno = grdData.CurrentRow.Index
        Me.cbomtl_warehouse.SelectedValue = grdData.Item("mtl_warehouse", rowno).Value
        Call GetComboNewSubInventory(Int64mtl_warehouse_id:=grdData.Item("mtl_warehouse", rowno).Value)
        Me.cbomtl_subinventory.SelectedValue = grdData.Item("mtl_subinventory", rowno).Value
        Call GetComboLocation(Int64mtl_warehouse_id:=grdData.Item("mtl_warehouse", rowno).Value, Int64mtl_subinventory_id:=grdData.Item("mtl_subinventory", rowno).Value)
        Me.cbomtl_location.SelectedValue = grdData.Item("mtl_locations", rowno).Value

    End Sub

    Private Sub btnApplyCurRow_Click(sender As Object, e As EventArgs) Handles btnApplyCurRow.Click
        ApplyRow(grdData.CurrentRow.Index)
    End Sub

    Private Sub ApplyRow(RowNo As Integer)
        With grdData
            grdData.Rows(RowNo).Cells("rem_qc").Value = txtRemark.Text.Trim
        End With
    End Sub

    Private Sub btnApplyAll_Click(sender As Object, e As EventArgs) Handles btnApplyAll.Click
        For i = 0 To grdData.Rows.Count - 1
            ApplyRow(i)
        Next
    End Sub
End Class