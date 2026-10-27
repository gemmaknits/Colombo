Imports System.Data.SqlClient

Public Class frmEndingYarnInventory
    Dim clsUser As New classUserInfo
    Dim clsconfig As New clsConfig
    Public Property UserInfo() As classUserInfo
        Get
            UserInfo = clsUser
        End Get
        Set(ByVal NewValue As classUserInfo)
            clsUser = NewValue
        End Set
    End Property

    Private Function GetData(ByVal rollNo As String) As DataTable
        
        Dim clsConfig As New clsConfig
        Dim conn As SqlConnection = New classConnection().getSQLConnection()
        conn.Open()
        Dim comm As New SqlCommand("", conn)
        Dim tran As SqlTransaction = conn.BeginTransaction
        comm.Transaction = tran
        comm.CommandType = CommandType.StoredProcedure

        comm.CommandText = "p_ending_yarn_inventory_update"

        comm.Parameters.AddWithValue("@barcode", rollNo.Trim)
        comm.Parameters.AddWithValue("@mtl_warehouse_id", clsConfig.IsNull(cbomtl_warehouse.SelectedValue, DBNull.Value))
        comm.Parameters.AddWithValue("@mtl_subinventory_id", clsConfig.IsNull(cbomtl_subinventory.SelectedValue, DBNull.Value))
        comm.Parameters.AddWithValue("@mtl_locations_id", clsConfig.IsNull(cbomtl_Location.SelectedValue, DBNull.Value))
        comm.Parameters.AddWithValue("@logempcd", clsUser.UserID)

        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable


        Try
            da.Fill(dt)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "System Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
            tran.Rollback()
            conn.Close()
            Return GetData("")
        End Try


        tran.Commit()
        conn.Close()
        Return dt
    End Function


    Private Function SaveData() As Boolean

        If grdData.Rows.Count > 0 Then
            For i = 0 To grdData.Rows.Count - 1
                grdData.Rows(i).Cells("dye_test_result").Value = IIf(optNone.Checked, "N", IIf(optPassed.Checked, "P", "F"))
                grdData.Rows(i).Cells("box_remark").Value = txtRemark.Text.Trim
                grdData.Rows(i).Cells("loc").Value = grdData.Rows(i).Cells("mtl_locations").FormattedValue.ToString()
            Next

        End If

        Dim dtc As DataTable = grdData.DataSource
        Dim objdb As New classEndingYarnInventory
        Dim Message As String = ""

        If objdb.EndingYarnInventorySave(dtc:=dtc, Message:=Message) Then
            MessageBox.Show("", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
        Else
            MessageBox.Show(Message, "System Message", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
        End If


    End Function

    Private Sub frmEndingYarnInventory_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Call InitControl()

        'grdData.AutoGenerateColumns = False
        'grdData.DataSource = GetData("")

        'txtBarcode.Focus()
    End Sub

  

    Private Sub GenCombo()
        Dim clsmaster As New classMaster
        Dim objdb As New classMaster

        Dim dtmtlwarehouse As New DataTable

        cbomtl_warehouse.DataSource = clsmaster.Combomtlwarehouse(clsUser.UserID)
        cbomtl_warehouse.DisplayMember = "warehouse_code"
        cbomtl_warehouse.ValueMember = "mtl_warehouse_id"
        cbomtl_warehouse.SelectedIndex = -1

        'cbomtl_subinventory.DataSource = clsmaster.GetCombomtl_subinventory(0)
        'cbomtl_subinventory.DisplayMember = "subinventory_code"
        'cbomtl_subinventory.ValueMember = "mtl_subinventory_id"
        'cbomtl_subinventory.SelectedIndex = -1

        'cbomtl_Location.DataSource = clsmaster.Combomtllocations(clsUser.UserID)
        'cbomtl_Location.DisplayMember = "location_name"
        'cbomtl_Location.ValueMember = "mtl_locations_id"
        'cbomtl_Location.SelectedIndex = -1

        mtl_warehouse.DataSource = objdb.Combomtlwarehouse(clsUser.UserID)
        mtl_warehouse.DisplayMember = "warehouse_code"
        mtl_warehouse.ValueMember = "mtl_warehouse_id"

        mtl_subinventory.DataSource = objdb.GetCombomtl_subinventory("0")
        mtl_subinventory.DisplayMember = "subinventory_code"
        mtl_subinventory.ValueMember = "mtl_subinventory_id"

        mtl_locations.DataSource = objdb.Combomtllocations(strUSerID:=clsUser.UserID, INt64mtl_warehouse_id:="0", Int64mtl_subinventory_id:="0")
        mtl_locations.DisplayMember = "location_name"
        mtl_locations.ValueMember = "mtl_locations_id"

    End Sub

    Private Sub btnNew_Click(sender As System.Object, e As System.EventArgs) Handles btnNew.Click

        If MessageBox.Show("Would you like to clear all data ?", "System Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then grdData.DataSource = GetData("NEW")
        Call InitControl()
        txtBarcode.Focus()
    End Sub

    Private Sub InitControl()

        'Me.FormBorderStyle = FormBorderStyle.None
        Me.WindowState = FormWindowState.Maximized

        Call GenCombo()

        ErrorProvider1.Clear()

        Dim datagridview1 As DataGridView = grdData
        'datagridview1.DataSource = GetData("")

        'For Each row As DataGridViewRow In datagridview1

        'Next

        grdData.AutoGenerateColumns = False
        grdData.DataSource = GetData("")
        'GenLocation()

        ErrorProvider1.Clear()
        'GenCombo()
        txtBarcode.Focus()
    End Sub

    Private Sub GenLocation()
        Dim objdb As New classMaster
        Dim dgvccSubInven As New DataGridViewComboBoxCell
        Dim dtSubInven As New DataTable
        Dim dgvcc As New DataGridViewComboBoxCell
        Dim dt3 As New DataTable

        For Each row As DataGridViewRow In grdData.Rows
            If Not IsDBNull(row.Cells("mtl_warehouse").Value) And Not IsDBNull(row.Cells("mtl_subinventory").Value) Then
                dt3 = objdb.Combomtllocations(clsUser.UserID, row.Cells("mtl_warehouse").Value, row.Cells("mtl_subinventory").Value)
                dgvcc = row.Cells("mtl_locations")
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



        Next
    End Sub
    Private Sub btnSave_Click(sender As System.Object, e As System.EventArgs) Handles btnSave.Click

        If Not CheckData() Then Exit Sub

        If MessageBox.Show("Would you like to Update Location and Dye Test Result ?", "System Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            'Call Updatetmp() 'Add By Neung 
            'grdData.DataSource = GetData("LOCATION " & cbomtl_Location.Text & " DYETEST " & IIf(optNone.Checked, "N", IIf(optPassed.Checked, "P", "F")) & " REMARK " & txtRemark.Text.Trim)
            'grdData.DataSource = SaveData()
            Call SaveData()
            ErrorProvider1.Clear()
            Call InitControl()
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

            'Dim tb As TextBox = TryCast(row.FindControl("yourtextboxid"), TextBox)
            ' Dim str As String = row.Cells(yourcellindex)
        Next

        'For i = 0 To grdData.Rows.Count - 1
        '    If IsDBNull(grdData.Rows(i).Cells("mtl_locations").Value) Then
        '        MessageBox.Show("คุณยังไม่ไดเลือก locations")
        '        ErrorProvider1.SetError(grdData, "คุณยังไม่ไดเลือก locations")
        '        CheckData = False
        '        Exit Function
        '    End If
        'Next

        'If clsconfig.IsNull(cbomtl_warehouse.SelectedValue, 0) = 0 Then
        '    MessageBox.Show("คุณยังไม่ไดเลือก WareHouse")
        '    ErrorProvider1.SetError(cbomtl_warehouse, "คุณยังไม่ไดเลือก WareHouse")
        '    CheckData = False
        '    Exit Function
        'End If

        'If Val(cbomtl_subinventory.SelectedValue) = 0 Then
        '    MessageBox.Show("คุณยังไม่ได้เลือก Subinventory")
        '    ErrorProvider1.SetError(cbomtl_subinventory, "คุณยังไม่ได้เลือก Subinventory")
        '    CheckData = False
        '    Exit Function
        'End If

        'If clsconfig.IsNull(cbomtl_Location.SelectedValue, 0) = 0 Then
        '    MessageBox.Show("คุณยังไม่ไดเลือก Location")
        '    ErrorProvider1.SetError(cbomtl_Location, "คุณยังไม่ได้เลือก Locations")
        '    CheckData = False
        '    Exit Function
        'End If

        CheckData = True
    End Function
    Private Function Updatetmp() As Boolean

        Dim objdb As New classEndingYarnInventory
        Dim dtc As DataTable = grdData.DataSource 'Add By Neung
        Dim dv_dtc_add As New DataView(dtc, "", "", DataViewRowState.Added) 'Add By Neung
        Dim dv_dtc_upd As New DataView(dtc, "", "", DataViewRowState.ModifiedCurrent) 'Add By Neung
        Dim dv_dtc_del As New DataView(dtc, "", "", DataViewRowState.Deleted) 'Add By Neung
        Dim Yarn_Header As New classEndingYarnInventory.Yarn_Header 'Add By Neung
        Yarn_Header.dye_test = ""


        If objdb.EndingYarnInventoryDel(dtc, dv_dtc_add, dv_dtc_upd, dv_dtc_del, Yarn_Header) Then 'Add By Neung
            Updatetmp = True

        Else
            Updatetmp = False

        End If 'Add By Neung
    End Function


    Private Sub btnPrint_Click(sender As System.Object, e As System.EventArgs) Handles btnPrint.Click
        Dim clsConn As New classConnection
        Dim clsConfig As New clsConfig
        Dim rptFileName As String = "rptEndingYarnInventory.rpt"
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
        frm.Title = "Ending Yarn Inventory"
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

    Private Sub grdData_CellEndEdit(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles grdData.CellEndEdit
        'For Each row As DataGridViewRow In grdData.Rows

        '    If IsDBNull((row.Cells("mtl_locations").Value)) Then
        '        row.Cells("mtl_locations").Value = DBNull.Value
        '        Exit Sub
        '    End If

        '    'Dim tb As TextBox = TryCast(row.FindControl("yourtextboxid"), TextBox)
        '    ' Dim str As String = row.Cells(yourcellindex)
        'Next
        ' For Each DataGridViewRow In grdData.Rows
        'If IsDBNull(DataGridViewRow.row.Cells("mtl_warehouse").Value) Then
        'Next


        ' Updatetmp()
        'grdData.DataSource = GetData("")
    End Sub


    Private Sub grdData_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles grdData.KeyDown
        'If grdData.Focus Then grdData.EndEdit()

        'If e.KeyCode = Keys.Delete Then




        '    Dim dt As DataTable = grdData.DataSource 'Add By Neung
        '    Dim dv_dtc_add As New DataView(dt, "", "", DataViewRowState.Added) 'Add By Neung
        '    Dim dv_dtc_upd As New DataView(dt, "", "", DataViewRowState.ModifiedCurrent) 'Add By Neung
        '    Dim dv_dtc_del As New DataView(dt, "", "", DataViewRowState.Deleted) 'Add By Neung

        '    If dv_dtc_del.Count > 0 Then

        '        With dv_dtc_del
        '            For i = 0 To dv_dtc_del.Count - 1
        '                grdData.DataSource = GetData("DELETE " & dv_dtc_del.Item(i)("id").Value.ToString())
        '            Next
        '        End With

        '    End If
        'End If

        'txtBarcode.Focus()
    End Sub

    Private Sub grdData_CellContentClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles grdData.CellContentClick

    End Sub

    Private Sub grdData_CellLeave(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles grdData.CellLeave
        'Updatetmp()
    End Sub

    Private Sub txtBarcode_TextChanged(sender As Object, e As EventArgs) Handles txtBarcode.TextChanged

    End Sub

    Private Sub btnDel_Click(sender As Object, e As EventArgs) Handles btnDel.Click
        Dim dt As DataTable = grdData.DataSource
        If dt.Rows.Count > 0 Then
            If Val(grdData.CurrentRow.Cells("id").Value) > 0 Then
                If MessageBox.Show("Would you like to remove item number " & grdData.CurrentRow.Cells("id").Value.ToString() & " ?", "System Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                    grdData.DataSource = GetData("DELETE " & grdData.CurrentRow.Cells("id").Value.ToString())
                End If
            End If
        End If
        txtBarcode.Focus()
    End Sub

    Private Sub cbomtl_subinventory_DropDownClosed(sender As Object, e As EventArgs) Handles cbomtl_subinventory.DropDownClosed
        Call GetComboLocation(Int64mtl_warehouse_id:=(New clsConfig).IsNull(cbomtl_warehouse.SelectedValue, 0), Int64mtl_subinventory_id:=(New clsConfig).IsNull(cbomtl_subinventory.SelectedValue, 0))

    End Sub

    Private Sub GetComboNewSubInventory(Optional ByVal Int64mtl_warehouse_id As Nullable(Of Int64) = Nothing)
        Dim objdb As New classMaster

        cbomtl_subinventory.DataSource = objdb.GetCombomtl_subinventory(Int64mtl_warehouse_id)
        cbomtl_subinventory.DisplayMember = "subinventory_code"
        cbomtl_subinventory.ValueMember = "mtl_subinventory_id"
        'Dim clsconfig As New clsConfig
        'If clsconfig.IsNull(cbomtl_subinventory.SelectedValue, 0) = 0 Then SetDefaultSubInventory(cbomtl_subinventory.DataSource)

    End Sub

    Private Sub GetComboLocation(Optional ByVal Int64mtl_warehouse_id As Nullable(Of Int64) = Nothing, Optional ByVal Int64mtl_subinventory_id As Nullable(Of Int64) = Nothing)
        Dim objdb As New classMaster
        cbomtl_Location.DataSource = objdb.Combomtllocations(strUSerID:=clsUser.UserID, INt64mtl_warehouse_id:=Int64mtl_warehouse_id, Int64mtl_subinventory_id:=Int64mtl_subinventory_id)
        cbomtl_Location.DisplayMember = "location_name"
        cbomtl_Location.ValueMember = "mtl_locations_id"
        Dim clsconfig As New clsConfig
        'If clsconfig.IsNull(cbomtl_location.SelectedValue, 0) = 0 Then SetDefaultLocation(cbomtl_location.DataSource)
        'SetDefaultLocation(cbomtl_location.DataSource)
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
        expression = "subinventory_code like '%Y%'"
        Dim foundRows() As DataRow
        foundRows = dt.Select(expression)

        cbomtl_subinventory.SelectedValue = foundRows(0)("mtl_subinventory_id")

    End Sub
    Private Sub SetDefaultLocation(ByVal dt As DataTable)
        Dim expression As String
        expression = "location_name like '%N/A%'"
        Dim foundRows() As DataRow
        foundRows = dt.Select(expression)

        cbomtl_Location.SelectedValue = foundRows(0)(0)

    End Sub

    Private Sub cbomtl_warehouse_DropDownClosed(sender As Object, e As EventArgs) Handles cbomtl_warehouse.DropDownClosed
        GetComboNewSubInventory(Int64mtl_warehouse_id:=(New clsConfig).IsNull(cbomtl_warehouse.SelectedValue, Nothing))

        GetComboLocation(Int64mtl_warehouse_id:=(New clsConfig).IsNull(cbomtl_warehouse.SelectedValue, Nothing), _
                         Int64mtl_subinventory_id:=(New clsConfig).IsNull(cbomtl_subinventory.SelectedValue, Nothing))

    End Sub

    Private Sub cbomtl_warehouse_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbomtl_warehouse.SelectedIndexChanged

    End Sub

    Private Sub cbomtl_subinventory_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbomtl_subinventory.SelectedIndexChanged

    End Sub

    Private Sub grdData_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs) Handles grdData.CellValueChanged
        'Dim objdb As New classMaster
        'Dim dgvccSubInven As New DataGridViewComboBoxCell
        'Dim dtSubInven As New DataTable
        'Dim dgvcc As New DataGridViewComboBoxCell
        'Dim dt3 As New DataTable

        'For Each row As DataGridViewRow In grdData.Rows
        '    If Not IsDBNull(row.Cells("mtl_warehouse").Value) And Not IsDBNull(row.Cells("mtl_subinventory").Value) Then
        '        dt3 = objdb.Combomtllocations(clsUser.UserID, row.Cells("mtl_warehouse").Value, row.Cells("mtl_subinventory").Value)
        '        dgvcc = row.Cells("mtl_locations")
        '        Try
        '            dgvcc.DataSource = dt3
        '            dgvcc.DisplayMember = "location_name"
        '            dgvcc.ValueMember = "mtl_locations_id"
        '            dgvcc.Value = dt3.Rows(0)("mtl_locations_id") 'Fix Error
        '        Catch ex As Exception
        '            dgvcc.DataSource = dt3
        '            dgvcc.DisplayMember = "location_name"
        '            dgvcc.ValueMember = "mtl_locations_id"
        '            dgvcc.Value = DBNull.Value
        '        End Try
        '    End If


        '    'If IsDBNull((row.Cells("mtl_locations").Value)) Then

        '    '    row.Cells("mtl_locations").Value = DBNull.Value
        '    '    Exit Sub
        '    'End If


        'Next

       


       
        'If grdData.Columns(e.ColumnIndex).Name = "mtl_locations" Then
        '    If Not IsDBNull(grdData.Rows(e.RowIndex).Cells("mtl_warehouse").Value) And Not IsDBNull(grdData.Rows(e.RowIndex).Cells("mtl_subinventory").Value) Then
        '        dt3 = objdb.Combomtllocations(clsUser.UserID, grdData.Rows(e.RowIndex).Cells("mtl_warehouse").Value, grdData.Rows(e.RowIndex).Cells("mtl_subinventory").Value)
        '        dgvcc = grdData.Rows(e.RowIndex).Cells("mtl_locations")
        '        Try
        '            dgvcc.DataSource = dt3
        '            dgvcc.DisplayMember = "location_name"
        '            dgvcc.ValueMember = "mtl_locations_id"
        '            dgvcc.Value = dt3.Rows(0)("mtl_locations_id") 'Fix Error
        '        Catch ex As Exception
        '            dgvcc.DataSource = dt3
        '            dgvcc.DisplayMember = "location_name"
        '            dgvcc.ValueMember = "mtl_locations_id"
        '            dgvcc.Value = DBNull.Value
        '        End Try
        '    End If
        'End If
    End Sub
End Class