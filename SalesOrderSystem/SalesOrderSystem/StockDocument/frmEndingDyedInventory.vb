Imports System.Data.SqlClient

Public Class frmEndingDyedInventory
    Private strUserID As String = ""
    Dim clsUser As New classUserInfo

    Public Property UserInfo() As classUserInfo
        Get
            UserInfo = clsUser
        End Get
        Set(ByVal NewValue As classUserInfo)
            clsUser = NewValue
        End Set
    End Property

    'Private Function GetData(ByVal rollNo As String) As DataTable
    '    Dim conn As SqlConnection = New classConnection().getSQLConnection()
    '    Dim comm As SqlCommand = New SqlCommand("exec p_ending_dyed_inventory_update '" & rollNo & "'", conn)
    '    Dim da As New SqlDataAdapter(comm)
    '    Dim dt As New DataTable

    '    Try
    '        da.Fill(dt)
    '    Catch ex As Exception
    '        MessageBox.Show(ex.Message, "System Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '        Return GetData("")
    '    End Try

    '    Return dt
    'End Function

    Private Function GetData(ByVal rollNo As String) As DataTable
        'grdData.DataSource = GetData("NEW")
        'GetData("DELETE " & grdData.CurrentRow.Cells("id").Value.ToString())
        ' grdData.DataSource = GetData("LOCATION " & cbomtl_Location.Text & " DYETEST " & IIf(optNone.Checked, "N", IIf(optPassed.Checked, "P", "F")) & " REMARK " & txtRemark.Text.Trim)

        'Dim conn As SqlConnection = New classConnection().getSQLConnection()
        'Dim comm As SqlCommand = New SqlCommand("exec p_ending_yarn_inventory_update '" & rollNo & "'", conn)
        'Dim da As New SqlDataAdapter(comm)
        'Dim dt As New DataTable

        'Try
        '    da.Fill(dt)
        'Catch ex As Exception
        '    MessageBox.Show(ex.Message, "System Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
        '    Return GetData("")
        'End Try

        'Return dt
        Dim clsConfig As New clsConfig
        Dim conn As SqlConnection = New classConnection().getSQLConnection()
        conn.Open()
        Dim comm As New SqlCommand("", conn)
        Dim tran As SqlTransaction = conn.BeginTransaction
        comm.Transaction = tran
        comm.CommandType = CommandType.StoredProcedure

        comm.CommandText = "p_ending_dyed_inventory_update"

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

    Private Sub frmEndingDyedInventory_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
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

        cbomtl_Location.DataSource = objdb.Combomtllocations(strUSerID:=clsUser.UserID, _
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

    Private Sub frmEndingDyedInventory_Activated(sender As System.Object, e As System.EventArgs) Handles MyBase.Activated
        txtBarcode.Focus()
    End Sub

    Private Sub btnNew_Click(sender As System.Object, e As System.EventArgs) Handles btnNew.Click
        If MessageBox.Show("Would you like to clear all data ?", "System Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then grdData.DataSource = GetData("NEW")
        txtBarcode.Focus()
    End Sub

    Private Sub btnSave_Click(sender As System.Object, e As System.EventArgs) Handles btnSave.Click

        If Not CheckData() Then Exit Sub

        Dim clsconfig As New clsConfig
        Dim StrLoc As String = Trim(New clsConfig().IsNull(cbomtl_Location.Text, ""))


        If StrLoc.Trim.Length > 0 Then
            If MessageBox.Show("Would you like to Update Location ?", "System Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then

                'grdData.DataSource = GetData(rollNo:="LOCATION " & StrLoc.Trim)
                Call SaveData()
                ErrorProvider1.Clear()
                Call InitControl()
            End If
        End If

        txtBarcode.Focus()

        'If MessageBox.Show("Would you like to Update Location ?", "System Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then grdData.DataSource = GetData("LOCATION " & cbomtl_Location.Text)
        'txtBarcode.Focus()
    End Sub

    Private Function SaveData() As Boolean

        If grdData.Rows.Count > 0 Then
            For i = 0 To grdData.Rows.Count - 1
                grdData.Rows(i).Cells("loc").Value = grdData.Rows(i).Cells("mtl_locations").FormattedValue.ToString()
            Next

        End If

        Dim dtc As DataTable = grdData.DataSource
        Dim objdb As New ClassEndingDyedInventory
        Dim Message As String = ""

        If objdb.EndingDyedInventorySave(dtc:=dtc, Message:=Message) Then
            MessageBox.Show("Save Completed", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
        Else
            MessageBox.Show(Message, "System Message", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
        End If


    End Function

    Private Function CheckData() As Boolean

        For Each row As DataGridViewRow In grdData.Rows
            If IsDBNull((row.Cells("mtl_locations").Value)) Then
                MessageBox.Show("คุณยังไม่ไดเลือก locations")
                ErrorProvider1.SetError(grdData, "คุณยังไม่ไดเลือก locations")
                CheckData = False
                Exit Function
            End If
        Next
        'Dim clsconfig As New clsConfig
        'If clsConfig.IsNull(cbomtl_warehouse.SelectedValue, 0) = 0 Then
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

        'If clsConfig.IsNull(cbomtl_Location.SelectedValue, 0) = 0 Then
        '    MessageBox.Show("คุณยังไม่ไดเลือก Location")
        '    ErrorProvider1.SetError(cbomtl_Location, "คุณยังไม่ได้เลือก Locations")
        '    CheckData = False
        '    Exit Function
        'End If

        CheckData = True
    End Function


    Private Sub btnPrint_Click(sender As System.Object, e As System.EventArgs) Handles btnPrint.Click
        Dim clsConn As New classConnection
        Dim clsConfig As New clsConfig
        Dim rptFileName As String = "rptEndingDyedInventory.rpt"
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
        frm.Title = "Ending Dyed Inventory"
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
                    Call GetComboNewSubInventory(Int64mtl_warehouse_id:=(New clsConfig).IsNull(dt.Rows(0)("mtl_warehouse_id"), Nothing))
                    cbomtl_subinventory.SelectedValue = dt.Rows(0)("mtl_subinventory_id")
                    Call GetComboLocation(Int64mtl_warehouse_id:=(New clsConfig).IsNull(dt.Rows(0)("mtl_warehouse_id"), Nothing), _
                                          Int64mtl_subinventory_id:=(New clsConfig).IsNull(dt.Rows(0)("mtl_subinventory_id"), Nothing))

                End If
            End If

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
                    If MessageBox.Show("Would you like to remove item number " & grdData.CurrentRow.Cells("id").Value.ToString() & " ?", "System Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                        grdData.DataSource = GetData("DELETE " & grdData.CurrentRow.Cells("id").Value.ToString())
                    End If
                End If
            End If
        End If

        txtBarcode.Focus()
    End Sub

    Private Sub txtBarcode_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtBarcode.TextChanged

    End Sub

    Private Sub cbomtl_warehouse_DropDownClosed(sender As Object, e As EventArgs) Handles cbomtl_warehouse.DropDownClosed
        Call GetComboNewSubInventory(Int64mtl_warehouse_id:=(New clsConfig).IsNull(cbomtl_warehouse.SelectedValue, Nothing))

        Call GetComboLocation(Int64mtl_warehouse_id:=(New clsConfig).IsNull(cbomtl_warehouse.SelectedValue, Nothing), _
                         Int64mtl_subinventory_id:=(New clsConfig).IsNull(cbomtl_subinventory.SelectedValue, Nothing))
    End Sub


    Private Sub GetComboNewSubInventory(Optional ByVal Int64mtl_warehouse_id As Nullable(Of Int64) = Nothing)
        Dim objdb As New classMaster

        cbomtl_subinventory.DataSource = objdb.ComboMtlsubinventory(Int64mtl_warehouse_id)
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
        'Dim clsconfig As New clsConfig
        'If clsconfig.IsNull(cbomtl_location.SelectedValue, 0) = 0 Then SetDefaultLocation(cbomtl_location.DataSource)
        'SetDefaultLocation(cbomtl_location.DataSource)
    End Sub

    Private Sub cbomtl_warehouse_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbomtl_warehouse.SelectedIndexChanged

    End Sub

    Private Sub cbomtl_subinventory_DropDownClosed(sender As Object, e As EventArgs) Handles cbomtl_subinventory.DropDownClosed
        Call GetComboLocation(Int64mtl_warehouse_id:=(New clsConfig).IsNull(cbomtl_warehouse.SelectedValue, Nothing), _
                              Int64mtl_subinventory_id:=(New clsConfig).IsNull(cbomtl_subinventory.SelectedValue, Nothing))

    End Sub

    Private Sub cbomtl_subinventory_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbomtl_subinventory.SelectedIndexChanged

    End Sub

    Private Sub btnDel_Click(sender As Object, e As EventArgs) Handles btnDel.Click
        Call DeleteRow(grdData.CurrentRow.Index)
    End Sub

    Private Sub DeleteRow(RowNo As Integer)
        With grdData
            grdData.DataSource = GetData("DELETE " & grdData.Rows(RowNo).Cells("id").Value.ToString)
        End With
    End Sub

    Private Sub grdData_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles grdData.CellContentClick

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
End Class