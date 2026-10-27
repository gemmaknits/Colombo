Public Class frmReservation
       Dim clsuser As new classUserInfo
    Dim DTReservation As DataTable
    Dim mtl_reservations As classReservation.mtl_reservations

    Public Property UserInfo() As classUserInfo
        Get
            UserInfo = clsuser
        End Get
        Set(ByVal NewValue As classUserInfo)
            clsuser = NewValue
        End Set
    End Property

    Public Property p_mtl_reservations As classReservation.mtl_reservations
        Get
            p_mtl_reservations = mtl_reservations
        End Get
        Set(ByVal Newvalue As classReservation.mtl_reservations)
            mtl_reservations = Newvalue
        End Set
    End Property


    Private Sub frmReservation_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Call InitControl()
        Call GenCombo()
        Call GenComboInGrid()
        Call LoadData()
    End Sub
    Private Sub InitControl()

        grdDatamtl_reservations.AutoGenerateColumns = False
        grdDatamtl_reservations.DataSource = Nothing

    End Sub
    Private Sub GenComboInGrid()
        Dim objdb As New classMaster
        Dim clsConfig As New clsConfig
        Dim data As New DataGridViewComboBoxCell

        demand_source_type_id.DataSource = objdb.combomtl_txn_source_type(StrUSerID:=clsuser.UserID)
        demand_source_type_id.DisplayMember = "txn_source_type_name"
        demand_source_type_id.ValueMember = "mtl_txn_source_type_id"


        demand_source_header_id.DataSource = objdb.comboKO(strUserID:=clsuser.UserID) 'Change Again
        demand_source_header_id.DisplayMember = "kono"
        demand_source_header_id.ValueMember = "production_order_id"

        demand_source_line_id.DataSource = objdb.combosupply_source_line_id(Int64supply_source_line_id:=clsConfig.IsNull(cbodemand_source_header_id.SelectedValue, 0), StrUserId:=clsuser.UserID)
        demand_source_line_id.DisplayMember = "system_lot_number"
        demand_source_line_id.ValueMember = "mfg_production_lots_id"

        'Dim dgvcc As New DataGridViewComboBoxCell
        'For i = 0 To grdDatamtl_reservations.Rows.Count - 1
        '    dgvcc = grdDatamtl_reservations.Rows(i).Cells("demand_source_line_id")
        '    dgvcc.DataSource = objdb.combosupply_source_line_id(Int64supply_source_line_id:=clsConfig.IsNull(grdDatamtl_reservations.Rows(i).Cells("demand_source_header_id"), 0), StrUserId:=clsuser.UserID)
        '    dgvcc.DisplayMember = "system_lot_number"
        '    dgvcc.ValueMember = "mfg_production_lots_id"
        'Next

        supply_source_type_id.DataSource = objdb.combomtl_txn_source_type(StrUSerID:=clsuser.UserID)
        supply_source_type_id.DisplayMember = "txn_source_type_name"
        supply_source_type_id.ValueMember = "mtl_txn_source_type_id"

        supply_source_header_id.DataSource = objdb.comboKO(strUserID:=clsuser.UserID) 'Change Again
        supply_source_header_id.DisplayMember = "kono"
        supply_source_header_id.ValueMember = "producton_order_id"

        supply_source_line_id.DataSource = objdb.combosupply_source_line_id(Int64supply_source_line_id:=0, StrUserId:=clsuser.UserID) 'Change Again
        supply_source_line_id.DisplayMember = "system_lot_number"
        supply_source_line_id.ValueMember = "supply_source_line_id"

    End Sub
    Private Sub GenCombo()
        Dim objdb As New classMaster
        Dim clsConfig As New clsConfig

        cbodemand_source_type_id.DataSource = objdb.combomtl_txn_source_type(StrUSerID:=clsuser.UserID)
        cbodemand_source_type_id.DisplayMember = "txn_source_type_name"
        cbodemand_source_type_id.ValueMember = "mtl_txn_source_type_id"
        cbodemand_source_type_id.SelectedValue = clsConfig.IsNull(mtl_reservations.demand_source_type_id, 0)

        cbodemand_source_header_id.DataSource = objdb.comboKO(strUserID:=clsuser.UserID) 'Change Again
        cbodemand_source_header_id.DisplayMember = "kono"
        cbodemand_source_header_id.ValueMember = "producton_order_id"

        cbodemand_source_line_id.DataSource = objdb.combosupply_source_line_id(Int64supply_source_line_id:=clsConfig.IsNull(cbodemand_source_header_id.SelectedValue, 0), StrUserId:=clsuser.UserID)
        cbodemand_source_line_id.DisplayMember = "system_lot_number"
        cbodemand_source_line_id.ValueMember = "mfg_production_lots_id"

        cbosupply_source_type_id.DataSource = objdb.combomtl_txn_source_type(StrUSerID:=clsuser.UserID)
        cbosupply_source_type_id.DisplayMember = "txn_source_type_name"
        cbosupply_source_type_id.ValueMember = "mtl_txn_source_type_id"
        cbosupply_source_type_id.SelectedValue = clsConfig.IsNull(mtl_reservations.supply_source_type_id, 0)

        cbosupply_source_header_id.DataSource = objdb.comboKO(strUserID:=clsuser.UserID) 'Change Again
        cbosupply_source_header_id.DisplayMember = "kono"
        cbosupply_source_header_id.ValueMember = "producton_order_id"
        cbosupply_source_header_id.SelectedValue = clsConfig.IsNull(mtl_reservations.supply_source_header_id, 0)

        cbosupply_source_line_id.DataSource = objdb.combosupply_source_line_id(Int64supply_source_line_id:=clsConfig.IsNull(cbosupply_source_header_id.SelectedValue, 0), StrUserId:=clsuser.UserID) 'Change Again
        cbosupply_source_line_id.DisplayMember = "system_lot_number"
        cbosupply_source_line_id.ValueMember = "supply_source_line_id"
        cbosupply_source_line_id.SelectedValue = clsConfig.IsNull(mtl_reservations.supply_source_line_id, 0)

        cbosupply_source_lot_number.DataSource = objdb.combosupply_source_line_id(Int64supply_source_line_id:=clsConfig.IsNull(cbosupply_source_header_id.SelectedValue, 0), StrUserId:=clsuser.UserID)
        cbosupply_source_lot_number.DisplayMember = "system_lot_number"
        cbosupply_source_lot_number.ValueMember = "system_lot_number"


    End Sub
    Private Sub LoadData()
        Dim dtmtl_reservations As New DataTable
        Dim clsReservation As New classReservation

        dtmtl_reservations = _
            clsReservation.Getmtl_reservations _
            (Int64mtl_reservations_id:=mtl_reservations.mtl_reservations_id _
             , Int64demand_source_type_id:=mtl_reservations.demand_source_header_id _
             , Int64demand_source_header_id:=mtl_reservations.demand_source_header_id _
             , Int64supply_source_type_id:=mtl_reservations.supply_source_type_id _
             , Int64supply_source_header_id:=mtl_reservations.supply_source_header_id)

        'dtmtl_reservations = clsReservation.
        BindDataText(dtmtl_reservations)
        BindDataGrid(dtmtl_reservations)

    End Sub

    Private Sub BindDataText(ByVal Dt As DataTable)
        If Dt.Rows.Count > 0 Then

        Else

        End If

    End Sub
    Private Sub BindDataGrid(ByVal dt As DataTable)

        grdDatamtl_reservations.AutoGenerateColumns = False
        grdDatamtl_reservations.DataSource = dt
    End Sub

    Private Sub cbodemand_source_header_id_DropDownClosed(sender As Object, e As System.EventArgs) Handles cbodemand_source_header_id.DropDownClosed
        Dim objdb As New classMaster
        Dim clsconfig As New clsConfig

        cbodemand_source_line_id.DataSource = objdb.combosupply_source_line_id(Int64supply_source_line_id:=clsConfig.IsNull(cbodemand_source_header_id.SelectedValue, 0), StrUserId:=clsuser.UserID)
        cbodemand_source_line_id.DisplayMember = "system_lot_number"
        cbodemand_source_line_id.ValueMember = "mfg_production_lots_id"

        demand_source_line_id.DataSource = objdb.combosupply_source_line_id(Int64supply_source_line_id:=clsconfig.IsNull(cbodemand_source_header_id.SelectedValue, 0), StrUserId:=clsuser.UserID)
        demand_source_line_id.DisplayMember = "system_lot_number"
        demand_source_line_id.ValueMember = "mfg_production_lots_id"
    End Sub

    Private Sub cbosupply_source_header_id_DropDownClosed(sender As Object, e As System.EventArgs) Handles cbosupply_source_header_id.DropDownClosed
        Dim objdb As New classMaster
        Dim clsconfig As New clsConfig

        cbosupply_source_line_id.DataSource = objdb.combosupply_source_line_id(Int64supply_source_line_id:=clsconfig.IsNull(cbodemand_source_header_id.SelectedValue, 0), StrUserId:=clsuser.UserID)
        cbosupply_source_line_id.DisplayMember = "system_lot_number"
        cbosupply_source_line_id.ValueMember = "mfg_production_lots_id"

        'supply_source_line_id.DataSource = objdb.combosupply_source_line_id(Int64supply_source_line_id:=clsconfig.IsNull(cbodemand_source_header_id.SelectedValue, 0), StrUserId:=clsuser.UserID)
        'supply_source_line_id.DisplayMember = "system_lot_number"
        'supply_source_line_id.ValueMember = "mfg_production_lots_id"

    End Sub


    Private Sub cbosupply_source_header_id_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cbosupply_source_header_id.SelectedIndexChanged

    End Sub

    Private Sub btnAddReser_Click(sender As System.Object, e As System.EventArgs) Handles btnAddReser.Click
        BindDataAdd()
    End Sub
    Private Sub BindDataAdd()
        Dim objdb As New classMaster
        Dim clsconfig As New clsConfig
        'If cbodemand_source_header_id.SelectedIndex = -1 Then Exit Sub
        'If cbosupply_source_header_id.SelectedIndex = -1 Then Exit Sub

        grdDatamtl_reservations.AutoGenerateColumns = False
        Dim dtAdd As DataTable = grdDatamtl_reservations.DataSource

        Dim dr As DataRow

        Dim msg As String = ""
        Dim i As Integer = 0
        Dim j As Integer = 0

        'If CheckDuplicate(Me.cbodemand_source_header_id.SelectedValue, Me.cbodemand_source_header_id.SelectedValue, DtNew) Then
        'MessageBox.Show("ข้อมูลซ้ำกัน", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Stop)
        ' Exit Sub
        ' End If

        dr = dtAdd.NewRow

        dr("mtl_reservations_id") = DBNull.Value
        dr("mtl_warehouse_id") = DBNull.Value
        dr("mtl_locations_id") = DBNull.Value

        dr("demand_source_type_id") = clsconfig.IsNull(Me.cbodemand_source_type_id.SelectedValue, DBNull.Value)
        dr("demand_source_header_id") = clsconfig.IsNull(Me.cbodemand_source_header_id.SelectedValue, DBNull.Value)
        dr("demand_source_line_id") = clsconfig.IsNull(Me.cbodemand_source_line_id.SelectedValue, DBNull.Value)
        dr("demand_source_item_id") = DBNull.Value
        dr("demand_source_lot_number") = DBNull.Value

        dr("supply_source_type_id") = clsconfig.IsNull(Me.cbosupply_source_type_id.SelectedValue, DBNull.Value)
        dr("supply_source_header_id") = clsconfig.IsNull(Me.cbosupply_source_header_id.SelectedValue, DBNull.Value)
        dr("supply_source_line_id") = DBNull.Value 'clsconfig.IsNull(Me.cbosupply_source_line_id.SelectedValue, DBNull.Value)
        dr("supply_source_item_id") = DBNull.Value
        dr("supply_source_lot_number") = DBNull.Value

        dr("mtl_subinventory_id") = DBNull.Value

        dr("creation_date") = CDate(Now())
        dr("created_by") = clsuser.UserID
        dr("last_modified_date") = DBNull.Value
        dr("last_modified_by") = DBNull.Value
        dr("expected_release_date") = DBNull.Value
        dtAdd.Rows.Add(dr)
    End Sub

    Private Sub btnSave_Click(sender As System.Object, e As System.EventArgs) Handles btnSave.Click
        Call Save()
    End Sub
    Private Function Save() As Boolean
        Dim objdb As New classReservation



        Dim dv_add As New DataView(grdDatamtl_reservations.DataSource, "", "", DataViewRowState.Added)
        Dim dv_upd As New DataView(grdDatamtl_reservations.DataSource, "", "", DataViewRowState.ModifiedCurrent)
        Dim dv_del As New DataView(grdDatamtl_reservations.DataSource, "", "", DataViewRowState.Deleted)


        Me.Hide()
        If objdb.SavaData(dv_add:=dv_add, dv_upd:=dv_upd, dv_del:=dv_del, clsuser:=clsuser) Then
            LoadData()
            Return True
        Else
            Return False
        End If
    End Function


    Private Sub grdDatamtl_reservations_CurrentCellDirtyStateChanged(sender As Object, e As System.EventArgs) Handles grdDatamtl_reservations.CurrentCellDirtyStateChanged
        If grdDatamtl_reservations.IsCurrentCellDirty Then
            grdDatamtl_reservations.CommitEdit(DataGridViewDataErrorContexts.Commit)
        End If
    End Sub
End Class