Public Class frmmtl_locations
    Dim clsUser As New classUserInfo
    Dim dt As New DataTable
    Dim Int64mtl_warehouse_id As Nullable(Of Int64)
    Dim Int64mtl_subinventory_id As Nullable(Of Int64)

    Public Property UserInfo() As classUserInfo
        Get
            UserInfo = clsUser
        End Get
        Set(ByVal NewValue As classUserInfo)
            clsUser = NewValue
        End Set
    End Property

    Public Property dtLocations As DataTable
        Get
            dtLocations = dt
        End Get
        Set(ByVal Newvalue As DataTable)
            dt = dtLocations
        End Set
    End Property

    Public Property p_mtl_warehouse_id As Nullable(Of Int64)
        Get
            p_mtl_warehouse_id = Int64mtl_warehouse_id
        End Get
        Set(ByVal NewValue As Nullable(Of Int64))
            Int64mtl_warehouse_id = NewValue
        End Set
    End Property

    Public Property p_mtl_subinventory_id As Nullable(Of Int64)
        Get
            p_mtl_subinventory_id = Int64mtl_subinventory_id
        End Get
        Set(ByVal NewValue As Nullable(Of Int64))
            Int64mtl_subinventory_id = NewValue
        End Set
    End Property


    Private Sub frmmtl_locations_FormClosing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Dim dt As New DataTable
        Dim clsmaster As New classMaster

        dt = clsmaster.Combomtllocations(strUSerID:=clsUser.UserID)

    End Sub

    Private Sub frmLocations_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Call InitControl()

        Me.StartPosition = FormStartPosition.CenterScreen

    End Sub
    Private Sub InitControl()
        Call Gencbomtl_warehouse()
        Call GenCboSubInventory()

        Call cboInGrid()
        Call LoadData()
        txtlocation_name.Text = ""
        'BtnApply.Enabled = False

    End Sub



    Private Sub cboInGrid()
        Dim objdb As New classMaster

        Me.mtl_warehouse.DataSource = objdb.Combomtlwarehouse(clsUser.UserID)
        Me.mtl_warehouse.DisplayMember = "warehouse_code"
        Me.mtl_warehouse.ValueMember = "mtl_warehouse_id"

        Me.mtl_subinventory.DataSource = objdb.ComboMtlsubinventory(0)
        Me.mtl_subinventory.DisplayMember = "subinventory_code"
        Me.mtl_subinventory.ValueMember = "mtl_subinventory_id"

    End Sub
    Private Sub Gencbomtl_warehouse()
        Dim objdb As New classMaster

        cbomtl_warehouse.DataSource = objdb.Combomtlwarehouse(clsUser.UserID)
        cbomtl_warehouse.DisplayMember = "warehouse_code"
        cbomtl_warehouse.ValueMember = "mtl_warehouse_id"
        If (New clsConfig).IsNull(p_mtl_warehouse_id, 0) > 0 Then cbomtl_warehouse.SelectedValue = p_mtl_warehouse_id
        'If (New clsConfig).IsNull(p_mtl_warehouse_id, 0) = 0 Then cbomtl_warehouse.SelectedIndex = -1

    End Sub

    Private Sub GenCboSubInventory()
        cboNewmtl_subinventory.DataSource = (New classMaster).ComboMtlsubinventory(cbomtl_warehouse.SelectedValue)
        cboNewmtl_subinventory.DisplayMember = "subinventory_code"
        cboNewmtl_subinventory.ValueMember = "mtl_subinventory_id"
        If (New clsConfig).IsNull(p_mtl_subinventory_id, 0) > 0 Then cboNewmtl_subinventory.SelectedValue = p_mtl_subinventory_id
        'If (New clsConfig).IsNull(p_mtl_subinventory_id, 0) = 0 Then cboNewmtl_subinventory.SelectedIndex = -1

    End Sub

    Private Sub LoadData()
        Dim objDB As New classMaster
        Dim dt As New DataTable

        dt = objDB.Getmtl_locations(Int64mtl_warehouse_id:=cbomtl_warehouse.SelectedValue, _
                                    Int64mtl_subinventory_id:=cboNewmtl_subinventory.SelectedValue)

        Bindgrdmtl_Locations(mtl_Locations:=dt)
    End Sub

    Private Sub BindData()

        'Dim dr As New DataRow
        Dim dtmtl_locations As New DataTable

        dtmtl_locations.Columns.Add("mtl_locations_id")
        dtmtl_locations.Columns.Add("location_name")
        dtmtl_locations.Columns.Add("mtl_warehouse_id")



    End Sub

    Private Sub Bindgrdmtl_Locations(ByVal mtl_Locations As DataTable)
        grdmtl_Locations.AutoGenerateColumns = False
        grdmtl_Locations.DataSource = mtl_Locations
    End Sub

    Private Sub BtnApply_Click(sender As System.Object, e As System.EventArgs) Handles BtnApply.Click
        grdmtl_Locations.AutoGenerateColumns = False

        Dim dtmtl_Locations As DataTable = grdmtl_Locations.DataSource

        Dim dr As DataRow

        Dim msg As String = ""
        Dim i As Integer = 0
        Dim j As Integer = 0

        If txtlocation_name.Text.Trim = "" Then
            MessageBox.Show("ไม่ได้ใส่ Location name", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Exit Sub
        End If

        If CheckDuplicate(dtmtl_Locations, Me.txtlocation_name.Text.Trim) Then
            MessageBox.Show("ข้อมูลซ้ำกัน", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Exit Sub
        End If

        dr = dtmtl_Locations.NewRow
        For j = 0 To dtmtl_Locations.Columns.Count - 1
            dr("location_name") = txtlocation_name.Text.Trim
            dr("mtl_warehouse_id") = cbomtl_warehouse.SelectedValue
            dr("mtl_subinventory_id") = cboNewmtl_subinventory.SelectedValue
        Next
        'dtmtl_Locations.Rows.Add(dr)
        dtmtl_Locations.Rows.InsertAt(dr, 0)

        txtlocation_name.Text = ""
    End Sub

    Private Function CheckDuplicate(ByVal dt As DataTable, ByVal location_name As String) As Boolean
        If dt.Rows.Count > 0 Then
            Dim i As Integer = 0
            For i = 0 To dt.Rows.Count - 1
                If dt.Rows(i).RowState <> DataRowState.Deleted Then
                    If dt.Rows(i)("location_name").ToString.Trim = location_name.Trim Then
                        Return True

                    End If
                End If
            Next
        End If
        Return False
    End Function

    Private Sub btnSave_Click(sender As System.Object, e As System.EventArgs) Handles btnSave.Click

        BFSave()

    End Sub

    Private Sub BFSave()
        If Save() Then
            InitControl()
        End If

    End Sub

    Private Function Save() As Boolean
        Dim clsUpdate As New classMasterUpdate
        Dim Mtl_locations As New classMasterUpdate.Mtl_locations

        Dim dtmtl_Locations As New DataTable

        p_mtl_warehouse_id = cbomtl_warehouse.SelectedValue
        p_mtl_subinventory_id = cboNewmtl_subinventory.SelectedValue

        dtmtl_Locations = grdmtl_Locations.DataSource

        Dim dv_add As New DataView(grdmtl_Locations.DataSource, "", "", DataViewRowState.Added)
        Dim dv_upd As New DataView(grdmtl_Locations.DataSource, "", "", DataViewRowState.ModifiedCurrent)
        Dim dv_del As New DataView(grdmtl_Locations.DataSource, "", "", DataViewRowState.Deleted)

        'Sitthana 20220624 Changed Windows.Forms.DialogResult To DialogResult
        Dim result As DialogResult ' Windows.Forms.DialogResult
        result = MessageBox.Show("คุณต้องการจะบันทึก ?", "System Message", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button3)
        If result <> DialogResult.Yes Then Exit Function
        Me.Cursor = Cursors.WaitCursor


        If clsUpdate.SaveMtl_locations(dv_add:=dv_add, dv_upd:=dv_upd, dv_del:=dv_del, Mtl_locations:=Mtl_locations) Then
            MessageBox.Show("บันทึกสำเร็จ", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
            Me.Cursor = Cursors.Default
            Return True
        Else
            Me.Cursor = Cursors.Default
            MessageBox.Show("ไม่สามารถทำการบันทึกได้", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
            Return False
        End If

        Me.Cursor = Cursors.Arrow

    End Function

    Private Sub cbomtl_warehouse_DropDownClosed(sender As Object, e As System.EventArgs) Handles cbomtl_warehouse.DropDownClosed
        ' Call com
        Call GenCboSubInventory()
        Call LoadData()
    End Sub

    Private Sub cbomtl_warehouse_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cbomtl_warehouse.SelectedIndexChanged

    End Sub

    Private Sub btnSearch_Click(sender As System.Object, e As System.EventArgs)

    End Sub

    Private Sub cboNewmtl_subinventory_DropDownClosed(sender As Object, e As System.EventArgs) Handles cboNewmtl_subinventory.DropDownClosed
        LoadData()
    End Sub

    Private Sub cboNewmtl_subinventory_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cboNewmtl_subinventory.SelectedIndexChanged

    End Sub


    Private Sub grdmtl_Locations_CellContentClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles grdmtl_Locations.CellContentClick

    End Sub

    Private Sub grdmtl_Locations_CurrentCellDirtyStateChanged(sender As Object, e As System.EventArgs) Handles grdmtl_Locations.CurrentCellDirtyStateChanged
        If grdmtl_Locations.IsCurrentCellDirty Then
            grdmtl_Locations.CommitEdit(DataGridViewDataErrorContexts.Commit)
        End If
    End Sub

    Private Sub txtlocation_name_Invalidated(sender As Object, e As System.Windows.Forms.InvalidateEventArgs) Handles txtlocation_name.Invalidated

    End Sub

    Private Sub txtlocation_name_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles txtlocation_name.KeyDown
        If e.KeyCode = Keys.Enter Then

            Call BtnApply_Click(sender:=sender, e:=e)
            'grdmtl_Locations.AutoGenerateColumns = False

            'Dim dtmtl_Locations As DataTable = grdmtl_Locations.DataSource

            'Dim dr As DataRow

            'Dim msg As String = ""
            'Dim i As Integer = 0
            'Dim j As Integer = 0

            'If txtlocation_name.Text.Trim = "" Then
            '    MessageBox.Show("ไม่ได้ใส่ Location name", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            '    Exit Sub
            'End If

            'If CheckDuplicate(dtmtl_Locations, Me.txtlocation_name.Text.Trim) Then
            '    MessageBox.Show("ข้อมูลซ้ำกัน", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            '    Exit Sub
            'End If

            'dr = dtmtl_Locations.NewRow
            'For j = 0 To dtmtl_Locations.Columns.Count - 1
            '    dr("location_name") = txtlocation_name.Text.Trim
            '    dr("mtl_warehouse_id") = cbomtl_warehouse.SelectedValue
            '    dr("mtl_subinventory_id") = cboNewmtl_subinventory.SelectedValue
            'Next
            'dtmtl_Locations.Rows.Add(dr)

            'txtlocation_name.Text = ""
        End If
    End Sub

    Private Sub txtlocation_name_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtlocation_name.TextChanged

    End Sub

    Private Sub txtlocation_name_Validated(sender As Object, e As System.EventArgs) Handles txtlocation_name.Validated
        If txtlocation_name.Text.Length > 0 Then
            BtnApply.Enabled = True
        End If
    End Sub
End Class