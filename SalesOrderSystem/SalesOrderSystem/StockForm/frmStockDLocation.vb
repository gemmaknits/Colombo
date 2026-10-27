Public Class frmStockDLocation
    Dim clsconn As New classConnection
    Dim clsconfig As New clsConfig
    Dim clsuser As New classUserInfo

    Dim DbStockDLocation As New classStockDLocation

    Dim StrDesign_No As String
    Dim StrLot As String
    Dim StrCol As String
    Dim StrDfNo As String
    Public Property Userinfo() As classUserInfo
        Get
            Userinfo = clsuser
        End Get
        Set(ByVal Newvalue As classUserInfo)
            clsuser = Newvalue
        End Set
    End Property
    Private Sub frmStockDLocation_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        InitializeMyContextMenu()
        Call GenCombo()
    End Sub
    Private Sub GenCombo()
        Dim objdb As New classMaster

        Call GetComboWarehouseinGrid()
        Call GetcomboSubInventoryinGrid(Int64mtl_warehouse_id:=0)
        Call GetCombomtl_locationInGrid(Int64mtl_warehouse_id:=0, Int64mtl_subinventory_id:=0)

    End Sub


    Private Sub GetComboWarehouseinGrid()
        Dim objdb As New classMaster
        mtl_warehouse_id.DataSource = objdb.Combomtlwarehouse(clsuser.UserID)
        mtl_warehouse_id.DisplayMember = "warehouse_name"
        mtl_warehouse_id.ValueMember = "mtl_warehouse_id"
        'SetdefaultWarehouse()
    End Sub
    Private Sub GetcomboSubInventoryinGrid(ByVal Int64mtl_warehouse_id As Int64)
        Dim objdb As New classMaster
        mtl_subinventory_id.DataSource = objdb.ComboMtlsubinventory(Int64mtl_warehouse_id)
        mtl_subinventory_id.DisplayMember = "subinventory_name"
        mtl_subinventory_id.ValueMember = "mtl_subinventory_id"
        'Setdefaultsubinventory(0)
    End Sub

    Private Sub GetCombomtl_locationInGrid(ByVal Int64mtl_warehouse_id As Int64, ByVal Int64mtl_subinventory_id As Int64)
        Dim objdb As New classMaster
        mtl_locations_id.DataSource = objdb.Combomtllocations(strUSerID:=clsuser.UserID _
                             , INt64mtl_warehouse_id:=Int64mtl_warehouse_id _
                             , Int64mtl_subinventory_id:=Int64mtl_subinventory_id)
        mtl_locations_id.DisplayMember = "location_name"
        mtl_locations_id.ValueMember = "mtl_locations_id"
    End Sub

    'Private Sub SetdefaultWarehouse()
    '    Dim clsMaster As New classMaster
    '    Dim dt As DataTable = clsMaster.GetdefaultWarehouse(clsUser.UserID)
    '    If dt.Rows.Count > 0 Then
    '        'mtl_warehouse_id = dt.Rows(0)("mtl_warehouse_id")
    '    End If
    'End Sub

    Private Sub Setdefaultsubinventory(ByVal Int64mtl_warehouse_id As Int64)
        'Dim dt As DataTable = grdStockD.DataSource
        'Dim dt As DataTable = clsMaster.GetdefaultSubinventory(Int64mtl_warehouse_id, Strsubinventory_code:="DYED", strUSerID:=clsuser.UserID)
        Dim clsMaster As New classMaster

        'Dim dgvccSubInven As New DataGridViewComboBoxCell
        Dim dtSubInven As New DataTable

        Dim i As Integer = 0
        For i = 0 To grdStockD.Rows.Count - 1
            Dim dgvccSubInven As New DataGridViewComboBoxCell
            'dgvccSubInven.Clone()
            dgvccSubInven = grdStockD.Rows(i).Cells("mtl_subinventory_id")
            dgvccSubInven.DataSource = clsMaster.GetdefaultSubinventory(grdStockD.Rows(i).Cells("mtl_warehouse_id").Value, Strsubinventory_code:="DYED", strUSerID:=clsuser.UserID)
            dgvccSubInven.DisplayMember = "subinventory_name"
            dgvccSubInven.ValueMember = "mtl_subinventory_id"
            Dim expression As String
            expression = "subinventory_name like '%STOCK DYED%'"
            Dim foundRows() As DataRow
            foundRows = dtSubInven.Select(expression)
            dgvccSubInven.Value = foundRows(0)("mtl_subinventory_id")

        Next




        'Dim dt As DataTable = clsMaster.GetdefaultSubinventory(Int64mtl_warehouse_id, Strsubinventory_code:="DYED", strUSerID:=clsuser.UserID)
        'If dt.Rows.Count > 0 Then
        'mtl_warehouse_id.SelectedValue = dt.Rows(0)("mtl_subinventory_id")
        'End If
    End Sub

    Private Sub txtSeach_GotFocus(sender As Object, e As System.EventArgs) Handles txtSeach.GotFocus
        If txtSeach.Text <> "" Then
            txtSeach.Text = ""
        End If
    End Sub

    Private Sub txtSeach_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles txtSeach.KeyDown

        If e.KeyCode = Keys.Enter Then
            Call Checkopt()
            GetStockDItem(StrDesign_No, StrLot, StrCol, StrDfNo)

        End If
    End Sub
    Public Sub Checkopt()
        If optDesignNo.Checked Then
            StrDesign_No = txtSeach.Text.Trim
            StrLot = ""
            StrCol = ""
            StrDfNo = ""
        ElseIf optLotNo.Checked Then
            StrLot = txtSeach.Text.Trim
            StrDesign_No = ""
            StrCol = ""
            StrDfNo = ""
        ElseIf optCol.Checked Then
            StrCol = txtSeach.Text.Trim
            StrDesign_No = ""
            StrLot = ""
            StrDfNo = ""

        ElseIf optDFNo.Checked Then
            StrDfNo = txtSeach.Text.Trim
            StrDesign_No = ""
            StrLot = ""
            StrCol = ""

        End If

    End Sub

    Private Function GetStockDItem(ByRef StrDesign_No As String, ByRef Strlot As String, ByRef StrCol As String, ByRef StrDfNo As String) As Boolean
        Dim dt As DataTable = DbStockDLocation.GetStockDLocation(StrDesign_No, Strlot, StrCol, StrDfNo)
        If dt.Rows.Count > 0 Then
            Call GenCombo()
            Call BinddataStockD(dt)

        End If

    End Function
    Private Sub BinddataStockD(ByRef dt As DataTable)


        grdStockD.AutoGenerateColumns = False
        grdStockD.DataSource = dt
    End Sub




    Private Sub txtSeach_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtSeach.TextChanged

    End Sub

    Private Sub btnSave_Click(sender As System.Object, e As System.EventArgs) Handles btnSave.Click
        If grdStockD.Focus Then grdStockD.Focus() 'Add By Neung 20151211
        'grdStockD_CellEndEdit(sender, grdStockD.DataSource)

        'Try
        If MsgBox("จะทำการบันทึกใช่หรือไม่", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            If UpdateStockD() Then

                'MsgBox("บันทึกสำเร็จ", MsgBoxStyle.OkOnly)
                Call Checkopt()
                GetStockDItem(StrDesign_No, StrLot, StrCol, StrDfNo)
                Exit Sub
            End If
        End If
        'Catch ex As Exception
        ' MsgBox("มีข้อผิดพลาดขณะบันทึกข้อมูลครับ")
        'End Try
    End Sub
    Private Function UpdateStockD() As Boolean

        '-------- Strat Fix Error Use ----------------------------------------
        If Not grdStockD.DataSource Is Nothing Then
            If grdStockD.Rows.Count > 0 And grdStockD.Focused Then
                If grdStockD.CurrentCell.IsInEditMode Then
                    Dim cell As DataGridViewCell = grdStockD.CurrentCell
                    grdStockD.EndEdit(DataGridViewDataErrorContexts.Commit)
                    grdStockD.CurrentCell = grdStockD.Rows(0).Cells(0)
                    grdStockD.CurrentCell = cell
                End If
            End If
        End If

        Dim config As New clsConfig
        config.ChangeCulture()
        Dim objdb As New classStockDLocation
        Dim msgerr As String = ""


        Dim dt As DataTable = grdStockD.DataSource

        Dim dv_dtc_add As New DataView(dt, "", "", DataViewRowState.Added)
        Dim dv_dtc_upd As New DataView(dt, "", "", DataViewRowState.ModifiedCurrent)
        Dim dv_dtc_del As New DataView(dt, "", "", DataViewRowState.Deleted)

        If objdb.UpdateStockD(dt, msgerr, clsuser.UserID) Then
            MessageBox.Show("บันทึกสำเร็จ", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Call Checkopt()
            Call GetStockDItem(StrDesign_No, StrLot, StrCol, StrDfNo)
            UpdateStockD = True

        Else
            MessageBox.Show(msgerr, "System Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
            UpdateStockD = False

        End If



    End Function

    Private Function IsDataChange() As Boolean 'Add By Neung 20151208 (Not Finish)
        Dim config As New clsConfig
        Dim result As Boolean = False
        Dim dt As DataTable = grdStockD.DataSource

        Dim dv As New DataView(dt, "", "", DataViewRowState.OriginalRows)
        'Dim i As Integer = CheckDelRow(dt)

        'If i < dt.Rows.Count Then




        'End If

    End Function
    Private Sub btnExit_Click(sender As System.Object, e As System.EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub optLotNo_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles optLotNo.CheckedChanged
        If optLotNo.Checked = True Then
            Checkopt()
            txtSeach.Text = "Please Enter Lot No."
        End If
    End Sub

    Private Sub optDesignNo_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles optDesignNo.CheckedChanged
        If optDesignNo.Checked = True Then
            Checkopt()
            txtSeach.Text = "Please Enter Design No."
        End If
    End Sub

    Private Sub optCol_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles optCol.CheckedChanged
        If optCol.Checked = True Then
            Checkopt()
            txtSeach.Text = "Please Enter Color No."
        End If
    End Sub

    Private Sub optDFNo_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles optDFNo.CheckedChanged
        If optDFNo.Checked = True Then
            Checkopt()
            txtSeach.Text = "Please Enter D/F No."
        End If
    End Sub

    Private Sub grdStockD_CellBeginEdit(sender As Object, e As System.Windows.Forms.DataGridViewCellCancelEventArgs) Handles grdStockD.CellBeginEdit
        Dim objdb As New classMaster
        Dim dgvccSubInven As New DataGridViewComboBoxCell
        Dim dtSubInven As New DataTable
        If grdStockD.Columns(e.ColumnIndex).Name = "mtl_subinventory_id" Then
            If Not IsDBNull(grdStockD.Rows(e.RowIndex).Cells("mtl_warehouse_id").Value) Then
                dtSubInven = objdb.ComboMtlsubinventory(grdStockD.Rows(e.RowIndex).Cells("mtl_warehouse_id").Value)
                dgvccSubInven = grdStockD.Rows(e.RowIndex).Cells("mtl_subinventory_id")
                Try
                    dgvccSubInven.DataSource = dtSubInven
                    dgvccSubInven.DisplayMember = "subinventory_name"
                    dgvccSubInven.ValueMember = "mtl_subinventory_id"
                    Dim expression As String
                    expression = "subinventory_name like '%STOCK DYED%'"
                    Dim foundRows() As DataRow
                    foundRows = dtSubInven.Select(expression)
                    dgvccSubInven.Value = foundRows(0)("mtl_subinventory_id")
                Catch ex As Exception
                    Dim expression As String
                    expression = "subinventory_name like '%STOCK DYED%'"
                    Dim foundRows() As DataRow
                    foundRows = dtSubInven.Select(expression)
                    'dgvccSubInven.Value = foundRows(0)(0)
                    dgvccSubInven.Value = DBNull.Value
                End Try
            End If
        End If
    End Sub

    Private Sub grdStockD_CellEndEdit(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles grdStockD.CellEndEdit


    End Sub
    Private Sub grdStockD_CellValueChanged(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles grdStockD.CellValueChanged
        'CheckEditRows() 'Disible By Neung 13/11/2015

        '------------------------------------------------------------End Funtion -------------------------------------------------
    End Sub
    Private Sub CheckEditRows()

        Dim dtc As New DataTable
        dtc = grdStockD.DataSource
        Dim dv_dtc_add As New DataView(dtc, "", "", DataViewRowState.Added)
        Dim dv_dtc_upd As New DataView(dtc, "", "", DataViewRowState.ModifiedCurrent)
        Dim dv_dtc_del As New DataView(dtc, "", "", DataViewRowState.Deleted)

        For i = 0 To dtc.Rows.Count - 1

            If dtc.Rows(i).RowState <> DataRowState.Deleted Then

                'dblGrossAmt = dblGrossAmt + Math.Round(config.IsNull(dtc.Rows(i)("qty"), 0) * config.IsNull(dtc.Rows(i)("uprice"), 0), 2)
                'dblOldAmt = Math.Round(config.IsNull(dtc.Rows(i)("oldamt"), 0), 2)
            End If
        Next

    End Sub

    Private Sub InitializeMyContextMenu()
        ' Create the contextMenu and the MenuItem to add.
        Dim contextMenu1 As New ContextMenu()
        Dim menuItem1 As New MenuItem("C&ut")
        Dim menuItem2 As New MenuItem("&Copy")
        Dim menuItem3 As New MenuItem("&Paste")

        ' Use the MenuItems property to call the Add method
        ' to add the MenuItem to the MainMenu menu item collection. 
        contextMenu1.MenuItems.Add(menuItem1)
        contextMenu1.MenuItems.Add(menuItem2)
        contextMenu1.MenuItems.Add(menuItem3)

        ' Assign mainMenu1 to the rich text box.
        grdStockD.ContextMenu = contextMenu1
    End Sub

    Private Sub grdStockD_CellContentClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles grdStockD.CellContentClick
        If grdStockD.CurrentCell.IsInEditMode Then grdStockD.EndEdit()
    End Sub

    Private Sub grdStockD_CellValidating(sender As Object, e As System.Windows.Forms.DataGridViewCellValidatingEventArgs) Handles grdStockD.CellValidating
        '----------------------------- Funtion Set Default Value mtl_subinventory_id --------------------------------------------------------- 

    End Sub

    Private Sub grdStockD_CellValidated(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles grdStockD.CellValidated
        '----------------------------- Funtion Set Default Value mtl_subinventory_id --------------------------------------------------------- 
        Dim objdb As New classMaster
        Dim dgvccSubInven As New DataGridViewComboBoxCell
        Dim dtSubInven As New DataTable
        If grdStockD.Columns(e.ColumnIndex).Name = "mtl_warehouse_id" Then
            If Not IsDBNull(grdStockD.Rows(e.RowIndex).Cells("mtl_warehouse_id").Value) Then
                dtSubInven = objdb.ComboMtlsubinventory(grdStockD.Rows(e.RowIndex).Cells("mtl_warehouse_id").Value)
                dgvccSubInven = grdStockD.Rows(e.RowIndex).Cells("mtl_subinventory_id")
                Try
                    dgvccSubInven.DataSource = dtSubInven
                    dgvccSubInven.DisplayMember = "subinventory_name"
                    dgvccSubInven.ValueMember = "mtl_subinventory_id"
                    Dim expression As String
                    expression = "subinventory_name like '%STOCK DYED%'"
                    Dim foundRows() As DataRow
                    foundRows = dtSubInven.Select(expression)
                    dgvccSubInven.Value = foundRows(0)("mtl_subinventory_id")
                Catch ex As Exception
                    Dim expression As String
                    expression = "subinventory_name like '%STOCK DYED%'"
                    Dim foundRows() As DataRow
                    foundRows = dtSubInven.Select(expression)
                    'dgvccSubInven.Value = foundRows(0)(0)
                    dgvccSubInven.Value = DBNull.Value
                End Try
            End If
        End If

        Dim dgvcc As New DataGridViewComboBoxCell
        Dim dt3 As New DataTable
        If grdStockD.Columns(e.ColumnIndex).Name = "mtl_warehouse_id" Or grdStockD.Columns(e.ColumnIndex).Name = "mtl_subinventory_id" Then
            If Not IsDBNull(grdStockD.Rows(e.RowIndex).Cells("mtl_warehouse_id").Value) And Not IsDBNull(grdStockD.Rows(e.RowIndex).Cells("mtl_subinventory_id").Value) Then
                dt3 = objdb.Combomtllocations(clsuser.UserID, grdStockD.Rows(e.RowIndex).Cells("mtl_warehouse_id").Value, grdStockD.Rows(e.RowIndex).Cells("mtl_subinventory_id").Value)
                dgvcc = grdStockD.Rows(e.RowIndex).Cells("mtl_locations_id")
                Try
                    dgvcc.DataSource = dt3
                    dgvcc.DisplayMember = "location_name"
                    dgvcc.ValueMember = "mtl_locations_id"
                    'dgvcc.Value = dt3.Rows(0)("mtl_locations_id") 'Fix Error
                    'dgvcc.Value = grdYarnIN.Rows(e.RowIndex).Cells("mtl_locations_id").Value
                    dgvcc.Value = DBNull.Value 'K Suresh Need Default Value = Null
                Catch ex As Exception
                    dgvcc.DataSource = dt3
                    dgvcc.DisplayMember = "location_name"
                    dgvcc.ValueMember = "mtl_locations_id"
                    dgvcc.Value = DBNull.Value
                End Try
            End If
        End If
        '------------------------------------------------------------End Funtion -------------------------------------------------


    End Sub

    Private Sub grdStockD_CellMouseLeave(sender As Object, e As DataGridViewCellEventArgs) Handles grdStockD.CellMouseLeave
        If Not e.RowIndex >= 0 Then Exit Sub
        If grdStockD.CurrentCell.IsInEditMode Then grdStockD.EndEdit()
    End Sub
End Class