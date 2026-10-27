Public Class frmmtl_locations
    Dim clsUser As New classUserInfo
    Dim dt As New DataTable

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

    Private Sub frmmtl_locations_FormClosing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Dim dt As New DataTable
        Dim clsmaster As New classMaster

        dt = clsmaster.Combomtllocations(clsUser.UserID)

    End Sub

    Private Sub frmLocations_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        InitControl()
    End Sub
    Private Sub InitControl()
        cbo()
        cboInGrid()
        LoadData()
    End Sub


    Private Sub cboInGrid()
        Dim objdb As New classMaster

        Me.mtl_warehouse.DataSource = objdb.Combomtlwarehouse(clsUser.UserID)
        Me.mtl_warehouse.DisplayMember = "warehouse_name"
        Me.mtl_warehouse.ValueMember = "mtl_warehouse_id"

    End Sub
    Private Sub cbo()
        Dim objdb As New classMaster

        'Dim combobox As New ComboBox
        ' combobox = cbomtl_warehouse

        cbomtl_warehouse.DataSource = objdb.Combomtlwarehouse(clsUser.UserID)

        cbomtl_warehouse.DisplayMember = "warehouse_name"
        cbomtl_warehouse.ValueMember = "mtl_warehouse_id"
        cbomtl_warehouse.SelectedIndex = -1

        'cbomtl_warehouse.DataSource = objdb.Combomtlwarehouse(clsUser.UserID)
        'cbomtl_warehouse.DisplayMember = "warehouse_name"
        'cbomtl_warehouse.ValueMember = "mtl_warehouse_id"
        'cbomtl_warehouse.SelectedIndex = -1

    End Sub

    Private Sub LoadData()
        Dim objDB As New classMaster
        Dim dt As New DataTable

        dt = objDB.Getmtl_locations(cbomtl_warehouse.SelectedValue)

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

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        grdmtl_Locations.AutoGenerateColumns = False

        Dim dt2 As DataTable = grdmtl_Locations.DataSource

        Dim dr As DataRow

        Dim msg As String = ""
        Dim i As Integer = 0
        Dim j As Integer = 0

        'If CheckDuplicate(Me.cbodefect_code.SelectedValue.ToString, Me.txtdefect_details.Text, dt2) Then
        'MessageBox.Show("ข้อมูลซ้ำกัน", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Stop)
        ' Exit Sub
        ' End If

        dr = dt2.NewRow
        For j = 0 To dt2.Columns.Count - 1
            dr("location_name") = txtlocation_name.Text.Trim
            dr("mtl_warehouse_id") = cbomtl_warehouse.SelectedValue
        Next
        dt2.Rows.Add(dr)
    End Sub

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

        dtmtl_Locations = grdmtl_Locations.DataSource

        Dim dv_add As New DataView(grdmtl_Locations.DataSource, "", "", DataViewRowState.Added)
        Dim dv_upd As New DataView(grdmtl_Locations.DataSource, "", "", DataViewRowState.ModifiedCurrent)
        Dim dv_del As New DataView(grdmtl_Locations.DataSource, "", "", DataViewRowState.Deleted)

        Dim result As System.Windows.Forms.DialogResult
        result = MessageBox.Show("คุณต้องการจะบันทึก ?", "System Message", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button3)
        If result <> System.Windows.Forms.DialogResult.Yes Then Exit Function
        Me.Cursor = Cursors.WaitCursor


        If clsUpdate.SaveMtl_locations(dv_add:=dv_add, dv_upd:=dv_upd, dv_del:=dv_del, Mtl_locations:=Mtl_locations) Then
            MessageBox.Show("บันทึกสำเร็จ", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
            Return True
        Else
            MessageBox.Show("ไม่สามารถทำการบันทึกได้", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
            Return False
        End If


    End Function

    Private Sub cbomtl_warehouse_DropDownClosed(sender As Object, e As System.EventArgs) Handles cbomtl_warehouse.DropDownClosed
        LoadData()
    End Sub

    Private Sub cbomtl_warehouse_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cbomtl_warehouse.SelectedIndexChanged

    End Sub
End Class