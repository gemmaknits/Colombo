
Public Class frmStockGIN_KOManual
    Dim clsUser As New classUserInfo
    Dim oConfig As New clsConfig
    Dim clsConn As New classConnection

    Dim oStockGINKOManual As New classStockGIN_KOManual

    Dim dt As New DataTable
    Dim ds As New DataSet
    Dim blnCancel As Boolean = False
    Dim strKONO As String
    Dim strRollNo As String
    Dim strUserID As String
    Private _ToolTip As New ToolTip()

    Public Property UserInfo() As classUserInfo
        Get
            UserInfo = clsUser
        End Get
        Set(ByVal NewValue As classUserInfo)
            clsUser = NewValue
        End Set
    End Property

    Public Property pUserID As String
        Get
            pUserID = strUserID
        End Get
        Set(ByVal Newvalue As String)
            strUserID = Newvalue
        End Set
    End Property

    Public Property pKono() As String
        Get
            pKono = strKONO
        End Get
        Set(ByVal NewValue As String)
            strKONO = NewValue
        End Set
    End Property

    Public Property pRollno() As String
        Get
            pRollno = strRollNo
        End Get
        Set(ByVal NewValue As String)
            strRollNo = NewValue
        End Set
    End Property

    Private Sub frmStockGIN_KOManual_FormClosing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Me.WindowState = FormWindowState.Normal
    End Sub

    Private Sub frmStockGINManual_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
        Select Case classConnection.database
            Case "ColomboDB", "ColomboDBTest"
                chkEsc.Text = "CLA"
            Case Else
                chkEsc.Text = "ESH"
        End Select
        'Call GenGrid()
        Call InitControl()
        'txtkono.Text = frm2.pKono
        Call GenCbo()
        Call GenCboInGrid()




        If pKono <> "" Then
            txtkono.Text = pKono
            If Not blnCancel Then getKO(pKono)
            Call GetGINDefectRoll("")
            Call CheckVerifyUser()
        ElseIf pRollno <> "" Then
            txtroll_no.Text = pRollno
            If Not blnCancel Then getGIN(pRollno)
            Call GetGINDefectRoll(pRollno)
            Call CheckVerifyUser()
        End If


    End Sub

    Private Sub CheckVerifyUser()
        'Dim clsuser As New 
        If clsUser.UserID = "TA" Or clsUser.UserID = "TON" Or clsUser.UserID = "CHET" Or clsUser.UserID = "SARUN" Or clsUser.UserID = "NUI" And pRollno <> "" Then
            btnCancel.Visible = True
            txtroll_no_o.ReadOnly = False
        Else
            btnCancel.Visible = False
            txtroll_no_o.ReadOnly = True
        End If

    End Sub

    Private Function Validate_RollNoOUT(Optional ByVal StrRollNo As String = "") As Boolean
        Dim objdb As New classStockGIN_KOManual
        Dim dt As DataTable = objdb.Validate_RollNo(StrRollNo, clsUser.UserID)

        If dt.Rows.Count = 0 Then
            MessageBox.Show("Roll No .: " & StrRollNo & "............   is Not Correct!!", "SyStem Messsage", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return False
        Else
            Return True
        End If


    End Function
    Private Sub GenCbo()
        Dim objdb As New classMaster

        cbomtl_warehouse.DataSource = objdb.Combomtlwarehouse(clsUser.UserID)
        cbomtl_warehouse.DisplayMember = "warehouse_code"
        cbomtl_warehouse.ValueMember = "mtl_warehouse_id"
        If oConfig.IsNull(cbomtl_warehouse.SelectedValue, 0) = 0 Then SetDefaultWarehouse(cbomtl_warehouse.DataSource, cbomtl_warehouse)

        cbomtl_subinventory.DataSource = objdb.GetCombomtl_subinventory(cbomtl_warehouse.SelectedValue)
        cbomtl_subinventory.DisplayMember = "subinventory_code"
        cbomtl_subinventory.ValueMember = "mtl_subinventory_id"
        If oConfig.IsNull(cbomtl_subinventory.SelectedValue, 0) = 0 Then SetDefaultSubInventory(cbomtl_subinventory.DataSource, cbomtl_subinventory)

        cbomtl_location.DataSource = objdb.Combomtllocations(strUSerID:=clsUser.UserID, pMtlWarehouseId:=cbomtl_warehouse.SelectedValue, Int64mtl_subinventory_id:=2)
        cbomtl_location.DisplayMember = "location_name"
        cbomtl_location.ValueMember = "mtl_locations_id"
        If oConfig.IsNull(cbomtl_location.SelectedValue, 0) = 0 Then SetDefaultLocation(cbomtl_location.DataSource, cbomtl_location)

        Dim objdb2 As New classStockGIN_KOManual
        Me.cbodefect_code.DataSource = objdb2.GetComboDefectCode
        Me.cbodefect_code.DisplayMember = "defect_code_name"
        Me.cbodefect_code.ValueMember = "defect_code"
        Me.cbodefect_code.SelectedIndex = -1

        cbopcv_item_id.DataSource = objdb.ComboItem("PACKING")
        cbopcv_item_id.DisplayMember = "itcd"
        cbopcv_item_id.ValueMember = "item_id"
        cbopcv_item_id.SelectedIndex = -1

        'CboTran_type.DataSource 

        'Dim objDB As New classStockGIN_KOManual
        'cboGINNo.ComboBox.DataSource = objDB.GetCBOGINKOmanualRollNo()
        'cboGINNo.ComboBox.DisplayMember = "roll_no"
        'cboGINNo.ComboBox.ValueMember = "roll_no"
        'cboGINNo.ComboBox.SelectedIndex = -1


    End Sub
    Private Sub GenCboInGrid()
        Dim objdb As New classStockGIN_KOManual
        Me.defect_code.DataSource = objdb.GetComboDefectCode
        Me.defect_code.DisplayMember = "defect_code"
        Me.defect_code.ValueMember = "defect_code"

        'Me.Defect_name.DataSource = Me.defect_code.DataSource
        'Me.Defect_name.DisplayMember = "defect_name"
        'Me.Defect_name.ValueMember = "defect_code"

    End Sub

    Private Sub btnSearchOutNo_Click(sender As System.Object, e As System.EventArgs) Handles btnSearchOutNo.Click
        Dim frm As New frmSearchKOForGreigeINManual
        frm.ShowDialog(Me)
        txtkono.Text = frm.pKono
        Me.Cursor = Cursors.WaitCursor

        Call InitControl()
        If Not blnCancel Then getKO(frm.pKono)
        Me.Cursor = Cursors.Default
        frm.Dispose()
    End Sub
    Private Function getKO(ByVal StrKONO As String) As Boolean
        Dim dbStockG As New classStockGIN_KOManual

        dt = dbStockG.GetGINKOBYKO(StrKONO, clsUser.UserID)

        If dt.Rows.Count > 0 Then
            Call Binddata(dt)

            txtmts.Focus()
            Return True
        Else

            Return False
        End If
    End Function
    Private Function getGIN(ByVal StrTran_no As String) As Boolean
        Dim dbStockG As New classStockGIN_KOManual
        Dim dtdefect As New DataTable
        dt = dbStockG.GetGINKOBYRollNo(StrTran_no, clsUser.UserID)

        If dt.Rows.Count > 0 Then
            Call Binddata(dt)

            Return True
        Else
            Return False
        End If
    End Function

    Private Function GetGINDefectRoll(ByVal StrRollNo As String) As Boolean
        Dim dbStockG As New classStockGIN_KOManual
        Dim objdb As DataTable = dbStockG.GetDefectRoll(StrRollNo, clsUser.UserID)

        BindDataDefect(objdb)

    End Function



    Private Sub BinddataByKO(ByVal dt As DataTable)
        'txtdesign_no.Text = dt.Rows(0)("Design_no").ToString.Trim
        'txtkono.Text = dt.Rows(0)("kono").ToString.Trim

        'txtmcno.Text = dt.Rows(0)("mcno").ToString.Trim
        'txtynchgcd.Text = dt.Rows(0)("ynchgcd").ToString.Trim

        txtkono.Text = dt.Rows(0)("kono").ToString.Trim
        txtmcno.Text = dt.Rows(0)("mcno").ToString.Trim
        txtdesign_no.Text = dt.Rows(0)("Design_no").ToString.Trim
        txtynchgcd.Text = dt.Rows(0)("ynchgcd").ToString.Trim
        txttran_no.Text = dt.Rows(0)("tran_no").ToString.Trim
        dtptran_dt.Value = oConfig.IsNull(dt.Rows(0)("tran_dt"), Now)
        txtroll_no.Text = dt.Rows(0)("roll_no").ToString.Trim
        txtroll_no_o.Text = dt.Rows(0)("roll_no_o").ToString.Trim
        txtmts.Text = dt.Rows(0)("mts")
        txtkg.Text = dt.Rows(0)("kg")
        txtbar_weight.Text = oConfig.IsNull(dt.Rows(0)("bar_weight"), 0)
        txtgwth.Text = oConfig.IsNull(dt.Rows(0)("gwth"), 0)
        txtlot.Text = dt.Rows(0)("lot").ToString.Trim
        txtgrade_bdt.Text = dt.Rows(0)("grade_bdt").ToString.Trim
        txtgrade_adt.Text = dt.Rows(0)("grade_adt").ToString.Trim
        chkcliped.Checked = oConfig.IsNull((dt.Rows(0)("cliped")), 0)
        cbomtl_location.Text = dt.Rows(0)("loc").ToString.Trim
        'txtsub_location.Text = dt.Rows(0)("sub_location").ToString.Trim
        txtshift.Text = dt.Rows(0)("shift").ToString.Trim
        dtpProdFinishDate.Value = oConfig.IsNull(dt.Rows(0)("ProdFinishDate"), Now)
        'txtProdFinishTime.Text = Format(dt.Rows(0)("ProdFinishTime").ToString.Trim, "DDMMYYY")
        txtProdFinishTime.Text = Format(dt.Rows(0)("ProdFinishTime"), "HH:mm")
        chkdyeing_pass.Checked = oConfig.IsValidBoolean(dt.Rows(0)("dyeing_pass"))
        txtadjust_loss_kg.Text = dt.Rows(0)("adjust_loss_kg")
        txtqc_loss_kg.Text = dt.Rows(0)("qc_loss_kg")
        txtdyed_loss_kg.Text = dt.Rows(0)("dyed_loss_kg")
        txtlab_loss_kg.Text = dt.Rows(0)("lab_loss_kg")
        txtdefect_loss_kg.Text = dt.Rows(0)("defect_loss_kg")
        txtrem_qc.Text = dt.Rows(0)("rem_qc").ToString.Trim

        cbomtl_warehouse.SelectedValue = dt.Rows(0)("mtl_warehouse_id")
        cbomtl_subinventory.SelectedValue = dt.Rows(0)("mtl_subinventory_id")
        cbomtl_location.SelectedValue = dt.Rows(0)("mtl_locations_id")

        cbopcv_item_id.SelectedValue = dt.Rows(0)("pcv_item_id")
    End Sub
    Private Sub Binddata(ByVal dt As DataTable)
        'txtdesign_no.Text = dt.Rows(0)("Design_no").ToString.Trim
        'txtkono.Text = dt.Rows(0)("kono").ToString.Trim

        'txtmcno.Text = dt.Rows(0)("mcno").ToString.Trim
        'txtynchgcd.Text = dt.Rows(0)("ynchgcd").ToString.Trim

        txtkono.Text = dt.Rows(0)("kono").ToString.Trim
        txtmcno.Text = dt.Rows(0)("mcno").ToString.Trim
        txtdesign_no.Text = dt.Rows(0)("Design_no").ToString.Trim
        txtynchgcd.Text = dt.Rows(0)("ynchgcd").ToString.Trim
        txttran_no.Text = dt.Rows(0)("tran_no").ToString.Trim
        dtptran_dt.Value = oConfig.IsNull(dt.Rows(0)("tran_dt"), Now)
        txtroll_no.Text = dt.Rows(0)("roll_no").ToString.Trim
        txtroll_no_o.Text = dt.Rows(0)("roll_no_o").ToString.Trim
        txtmts.Text = oConfig.IsNull(dt.Rows(0)("mts"), 0)
        txtkg.Text = oConfig.IsNull(dt.Rows(0)("kg"), 0)
        txtbar_weight.Text = oConfig.IsNull(dt.Rows(0)("bar_weight"), 0)
        txtgwth.Text = oConfig.IsNull(dt.Rows(0)("gwth"), 0)
        txtlot.Text = dt.Rows(0)("lot").ToString.Trim
        txtgrade_bdt.Text = dt.Rows(0)("grade_bdt").ToString.Trim
        txtgrade_adt.Text = dt.Rows(0)("grade_adt").ToString.Trim
        txtlot_grade.Text = dt.Rows(0)("grade").ToString.Trim
        chkcliped.Checked = oConfig.IsNull((dt.Rows(0)("cliped")), 0)
        'cbomtl_location.Text = dt.Rows(0)("loc").ToString.Trim
        'txtsub_location.Text = dt.Rows(0)("sub_location").ToString.Trim
        txtshift.Text = dt.Rows(0)("shift").ToString.Trim
        dtpProdFinishDate.Value = oConfig.IsNull(dt.Rows(0)("ProdFinishDate"), Now)
        'txtProdFinishTime.Text = Format(dt.Rows(0)("ProdFinishTime").ToString.Trim, "DDMMYYY")
        txtProdFinishTime.Text = dt.Rows(0)("ProdFinishTime").ToString.Trim
        chkdyeing_pass.Checked = oConfig.IsNull(dt.Rows(0)("dyeing_pass"), False)
        txtadjust_loss_kg.Text = dt.Rows(0)("adjust_loss_kg")
        txtqc_loss_kg.Text = dt.Rows(0)("qc_loss_kg")
        txtdyed_loss_kg.Text = dt.Rows(0)("dyed_loss_kg")
        txtlab_loss_kg.Text = dt.Rows(0)("lab_loss_kg")
        txtdefect_loss_kg.Text = dt.Rows(0)("defect_loss_kg")
        txtrem_qc.Text = dt.Rows(0)("rem_qc").ToString.Trim

        cbomtl_warehouse.SelectedValue = dt.Rows(0)("mtl_warehouse_id")
        Call GetComboSubInventory(Int64mtl_warehouse_id:=cbomtl_warehouse.SelectedValue,
                                     Int64mtl_subinventory_id:=cbomtl_subinventory.SelectedValue)
        cbomtl_subinventory.SelectedValue = dt.Rows(0)("mtl_subinventory_id")
        Call GetComboLocation(Int64mtl_warehouse_id:=cbomtl_warehouse.SelectedValue,
                              Int64mtl_subinventory_id:=cbomtl_subinventory.SelectedValue)
        cbomtl_location.SelectedValue = dt.Rows(0)("mtl_locations_id")

        cbopcv_item_id.SelectedValue = dt.Rows(0)("pcv_item_id")
    End Sub

    Private Sub BindDataDefect(ByVal dtdefect As DataTable)

        grdDefect.AutoGenerateColumns = False
        grdDefect.DataSource = dtdefect
    End Sub

    Private Sub btnNew_Click(sender As System.Object, e As System.EventArgs)
        Call InitControl()
        Call getGIN("")
    End Sub

    Private Sub InitControl()
        txtkono.Text = ""
        txtmcno.Text = ""
        txtdesign_no.Text = ""
        txtynchgcd.Text = ""
        txttran_no.Text = ""
        dtptran_dt.Value = Now
        txtroll_no.Text = ""
        txtroll_no_o.Text = ""
        txtmts.Text = ""
        txtkg.Text = ""
        txtbar_weight.Text = ""
        txtgwth.Text = ""
        txtlot.Text = ""
        txtgrade_bdt.Text = ""
        txtgrade_adt.Text = ""
        chkcliped.Checked = False
        cbomtl_location.Text = ""
        'txtsub_location.Text = ""
        txtshift.Text = ""
        dtpProdFinishDate.Value = Today
        txtProdFinishTime.Text = ""
        chkdyeing_pass.Checked = False
        txtadjust_loss_kg.Text = ""
        txtqc_loss_kg.Text = ""
        txtdyed_loss_kg.Text = ""
        txtlab_loss_kg.Text = ""
        txtdefect_loss_kg.Text = ""
        txtrem_qc.Text = ""

        Call CleargrdDefect()

    End Sub
    Private Sub CleargrdDefect()
        Dim objdb As New classStockGIN_KOManual
        grdDefect.AutoGenerateColumns = False
        grdDefect.DataSource = objdb.GetDefectRoll("", "")
    End Sub
    Private Sub GetgrdDefect()
        Dim objdb As New classStockGIN_KOManual
        grdDefect.AutoGenerateColumns = False
        grdDefect.DataSource = objdb.GetDefectRoll("", "")
    End Sub

    Private Sub btnSave_Click(sender As System.Object, e As System.EventArgs) Handles btnSave.Click
        Call Savedata()
    End Sub

    Private Function CheckData() As Boolean
        If oConfig.IsNull(cbomtl_warehouse.SelectedValue, 0) = 0 Then
            MessageBox.Show("ยังไมได้เลือก WareHouse.", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            ErrorProvider1.SetError(cbomtl_warehouse, "ยังไมได้เลือก WareHouse.")
            CheckData = False
            Exit Function
        End If

        If oConfig.IsNull(cbomtl_subinventory.SelectedValue, 0) = 0 Then
            MessageBox.Show("ยังไมได้เลือก Subinventory", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            ErrorProvider1.SetError(cbomtl_subinventory, "ยังไมได้เลือก Subinventory.")
            CheckData = False
            Exit Function
        End If

        If oConfig.IsNull(cbomtl_location.SelectedValue, 0) = 0 Then
            MessageBox.Show("ยังไมได้เลือก Locations", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            ErrorProvider1.SetError(cbomtl_location, "ยังไมได้เลือก Locations.")
            CheckData = False
            Exit Function
        End If


        'If (New classInventoryPeriod).GetLastInventoryPeriodEndDate() > dtptran_dt.Value Then
        '    MessageBox.Show("ไม่สามารถทำเอกสารได้เนื่องจาก INVENTORY PERIOD CLOSED ไปแล้ว วันที่ " & (New classInventoryPeriod).GetLastInventoryPeriodEndDate().ToString, "System Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
        '    CheckData = False
        '    Exit Function
        'End If


        Return True
    End Function
    Private Sub Savedata()

        If Not CheckData() Then Exit Sub

        If SaveGINKOManual() Then
            getGIN(txtroll_no.Text.Trim)
            GetGINDefectRoll(txtroll_no.Text.Trim)
        End If

    End Sub
    Private Function SaveGINKOManual(Optional ByVal strGINNO As String = "") As Boolean
        Dim config As New clsConfig
        config.ChangeCulture()
        Dim objDB As New classStockGIN_KOManual
        Dim Greige_Header As New classStockGIN_KOManual.Greige_Header
        Dim Defect_Roll_Header As New classStockGIN_KOManual.Defect_roll_Header

        Dim msgerr As String = ""
        Dim Tran_no As String = strGINNO
        Dim Roll_no As String = txtroll_no.Text.Trim
        Dim someDateAndTime As Date = #1/1/1900 1:12:00 PM#

        'Start Make date to nothing
        Dim DOB As Nullable(Of Date) = Date.Now
        Dim datestring As String = DOB.Value.ToString("d")
        DOB = Nothing
        'End Make date to nothing

        Greige_Header.h01_suppcd = config.IsNull(dt.Rows(0)("suppcd"), "GK")
        Greige_Header.h02_source = config.IsNull(dt.Rows(0)("source"), Nothing)
        Greige_Header.h03_source_refno = config.IsNull(dt.Rows(0)("source_refno"), Nothing)
        Greige_Header.h04_tran_no = txttran_no.Text
        Greige_Header.h05_tran_dt = dtptran_dt.Value
        Greige_Header.h06_design_no = txtdesign_no.Text
        Greige_Header.h07_supdes_no = config.IsNull(dt.Rows(0)("supdes_no"), Nothing)
        Greige_Header.h08_kono = txtkono.Text
        Greige_Header.h09_pieces = config.IsNull(dt.Rows(0)("pieces"), Nothing)
        Greige_Header.h10_nob = config.IsNull(dt.Rows(0)("nob"), Nothing)
        Greige_Header.h11_Gwth = txtgwth.Text
        Greige_Header.h12_Gwth_actual = config.IsNull(dt.Rows(0)("Gwth_actual"), Nothing)
        Greige_Header.h13_roll_no = txtroll_no.Text
        Greige_Header.h14_roll_no_g = config.IsNull(dt.Rows(0)("roll_no_g"), Nothing)
        Greige_Header.h15_roll_no_n = config.IsNull(dt.Rows(0)("roll_no_n"), Nothing)
        Greige_Header.h16_racks = config.IsNull(dt.Rows(0)("racks"), Nothing)
        Greige_Header.h17_kg = config.IsValidDouble(txtkg.Text.Trim)
        Greige_Header.h18_mts = config.IsValidDouble(txtmts.Text.Trim)
        Greige_Header.h19_yds = config.IsValidDouble(txtmts.Text.Trim) / 0.9144
        Greige_Header.h20_kg_qc = config.IsValidDouble(txtkg.Text.Trim) - config.IsValidDouble(txtbar_weight.Text.Trim)
        Greige_Header.h21_mts_qc = config.IsValidDouble(txtmts.Text.Trim)
        Greige_Header.h22_yds_qc = config.IsValidDouble(txtmts.Text.Trim) / 0.9144
        Greige_Header.h23_grade = config.IsNull(txtgrade_bdt.Text.Trim, "") & config.IsNull(txtgrade_bdt.Text.Trim, "")
        Greige_Header.h24_rem_qc = txtrem_qc.Text.Trim
        Greige_Header.h25_loc = oConfig.IsNull(cbomtl_location.Text.Trim, "")
        Greige_Header.h26_outreqno = config.IsNull(dt.Rows(0)("outreqno"), Nothing)
        Greige_Header.h27_outreqdt = config.IsNull(dt.Rows(0)("outreqdt"), Nothing)
        Greige_Header.h28_outreqtyp = config.IsNull(dt.Rows(0)("outreqtyp"), Nothing)
        Greige_Header.h29_outno = config.IsNull(dt.Rows(0)("outno"), Nothing)
        Greige_Header.h30_outdt = config.IsNull(dt.Rows(0)("outdt"), Nothing)
        Greige_Header.h31_lot = txtlot.Text.Trim
        Greige_Header.h32_yr = config.IsNull(dt.Rows(0)("yr"), Nothing)
        Greige_Header.h33_sh = config.IsNull(dt.Rows(0)("sh"), Nothing)
        Greige_Header.h34_dfno = config.IsNull(dt.Rows(0)("dfno"), Nothing)
        Greige_Header.h35_col = config.IsNull(dt.Rows(0)("col"), Nothing)
        Greige_Header.h36_dhcod = config.IsNull(dt.Rows(0)("dhcod"), Nothing)
        Greige_Header.h37_sono = config.IsNull(dt.Rows(0)("sono"), Nothing)
        Greige_Header.h38_sonoid = config.IsNull(dt.Rows(0)("sonoid"), Nothing)
        'Greige_Header.h39_roll_no_o = IIf(txtroll_no_o.Text.Trim = "", IIf(chkEsc.Checked, "N", IIf(chkGMK.Checked, "GMK", txtroll_no_o.Text.Trim)), txtroll_no_o.Text.Trim)
        Greige_Header.h39_roll_no_o = IIf(txtroll_no_o.Text.Trim = "", IIf(chkEsc.Checked, "N", IIf(chkGMK.Checked, "GMK", txtroll_no_o.Text.Trim)), txtroll_no_o.Text.Trim)
        Greige_Header.h40_pn = config.IsNull(dt.Rows(0)("pn"), Nothing)
        Greige_Header.h41_ydkg_g = config.IsNull(dt.Rows(0)("ydkg_g"), Nothing)
        Greige_Header.h42_cost = config.IsNull(dt.Rows(0)("cost"), Nothing)
        Greige_Header.h43_fload = config.IsNull(dt.Rows(0)("fload"), Nothing)
        Greige_Header.h44_rate = config.IsNull(dt.Rows(0)("rate"), Nothing)
        Greige_Header.h45_sel = config.IsNull(dt.Rows(0)("sel"), Nothing)
        Greige_Header.h46_cost_g = config.IsNull(dt.Rows(0)("cost_g"), Nothing)
        Greige_Header.h47_cliped = chkcliped.Checked
        Greige_Header.h48_unit = config.IsNull(dt.Rows(0)("unit"), Nothing)
        Greige_Header.h49_g_cost = config.IsNull(dt.Rows(0)("g_cost"), Nothing)
        Greige_Header.h50_tran_no1 = config.IsNull(txttran_no.Text.Trim, "")
        Greige_Header.h51_tran_not = config.IsNull(txttran_no.Text, "")
        Greige_Header.h52_cancel = config.IsNull(dt.Rows(0)("cancel"), Nothing)
        Greige_Header.h53_doctyp = config.IsNull(dt.Rows(0)("doctyp"), Nothing)
        Greige_Header.h54_preseted = config.IsNull(dt.Rows(0)("preseted"), Nothing)
        Greige_Header.h55_qcalertcd = config.IsNull(dt.Rows(0)("qcalertcd"), Nothing)
        Greige_Header.h56_ProdFinishDate = config.IsValidDate(dtpProdFinishDate.Value)
        Greige_Header.h57_ProdFinishTime = (txtProdFinishTime.Text)   ' Try to check again
        Greige_Header.h58_mcno = config.IsNull(txtmcno.Text, "")
        Greige_Header.h59_adjust_loss_kg = txtadjust_loss_kg.Text.Trim
        Greige_Header.h60_qc_loss_kg = txtqc_loss_kg.Text.Trim
        Greige_Header.h61_dyed_loss_kg = txtdyed_loss_kg.Text.Trim
        Greige_Header.h62_grade_bdt = txtgrade_bdt.Text.Trim
        Greige_Header.h63_grade_adt = txtgrade_adt.Text.Trim
        Greige_Header.h64_dyeing_pass = chkdyeing_pass.Checked
        Greige_Header.h65_dyeing_fail = config.IsNull(dt.Rows(0)("dyeing_fail"), Nothing)
        Greige_Header.h66_shift = txtshift.Text.Trim
        Greige_Header.h67_id_greige_do = config.IsNull(dt.Rows(0)("id_greige_do"), Nothing)
        Greige_Header.h68_id_greige = config.IsNull(dt.Rows(0)("id_greige"), Nothing)
        Greige_Header.h69_lab_loss_kg = txtlab_loss_kg.Text.Trim
        Greige_Header.h70_defect_loss_kg = txtdefect_loss_kg.Text.Trim
        Greige_Header.h71_purno = config.IsNull(dt.Rows(0)("purno"), Nothing)
        Greige_Header.h72_tran_type = config.IsNull(dt.Rows(0)("tran_type"), "KNITTING")
        Greige_Header.h73_roll_no_f = txtroll_no.Text.Trim
        Greige_Header.h74_job_line_id = config.IsNull(dt.Rows(0)("job_line_id"), 0)
        Greige_Header.h75_fabric_cost = config.IsNull(dt.Rows(0)("fabric_cost"), 0)
        Greige_Header.h76_process_cost = config.IsNull(dt.Rows(0)("process_cost"), 0)
        Greige_Header.h77_process_loss_perc = config.IsNull(dt.Rows(0)("process_loss_perc"), 0)
        Greige_Header.h78_other_cost = config.IsNull(dt.Rows(0)("other_cost"), 0)
        Greige_Header.h79_cost_per_unit = config.IsNull(dt.Rows(0)("cost_per_unit"), 0)
        'Greige_Header.h80_sub_location = txtsub_location.Text.Trim
        Greige_Header.h80_sub_location = ""
        Greige_Header.h81_greige_status = config.IsNull(dt.Rows(0)("greige_status"), 0)
        Greige_Header.h82_bar_weight = txtbar_weight.Text.Trim
        Greige_Header.h83_mtl_warehouse_id = config.IsNull(cbomtl_warehouse.SelectedValue, Nothing)
        Greige_Header.h84_mtl_subinventory_id = config.IsNull(cbomtl_subinventory.SelectedValue, Nothing)
        Greige_Header.h85_mtl_locations_id = config.IsNull(cbomtl_location.SelectedValue, Nothing)
        Greige_Header.h88_pcv_item_id = config.IsNull(cbopcv_item_id.SelectedValue, Nothing)

        Defect_Roll_Header.h01_id_defect_roll = 0
        Defect_Roll_Header.h02_roll_no = txtroll_no.Text
        Defect_Roll_Header.h03_defect_code = Nothing
        Defect_Roll_Header.h04_defect_details = Nothing
        Defect_Roll_Header.h05_stock_code = "G"

        Dim dtc As DataTable = grdDefect.DataSource

        Dim dv_dtc_add As New DataView(dtc, "", "", DataViewRowState.Added)
        Dim dv_dtc_upd As New DataView(dtc, "", "", DataViewRowState.ModifiedCurrent)
        Dim dv_dtc_del As New DataView(dtc, "", "", DataViewRowState.Deleted)

        blnCancel = False
        Dim result As DialogResult 'Windows.Forms.DialogResult
        result = MessageBox.Show("Would you like to save ?", "System Message", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button3)
        If result = DialogResult.Cancel Then blnCancel = True
        If result <> DialogResult.Yes Then Exit Function

        If objDB.GIN_KOManualsave(Greige_Header, Defect_Roll_Header, msgerr, dtc, dv_dtc_add, dv_dtc_upd, dv_dtc_del, clsUser.UserID, Tran_no, Roll_no) Then
            strGINNO = Tran_no
            txttran_no.Text = strGINNO.Trim
            txtroll_no.Text = Roll_no
            MessageBox.Show("Save is Complete! : บันทึกสำเร็จ! ", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
            SaveGINKOManual = True
        Else

            MessageBox.Show(msgerr, "System Message", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
            '====== Auto Update Scarp===== Disible By Neung User Cannot Update IF in Inventory Period time
            'MessageBox.Show("Program Auto Update GIN Scarp", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
            'Call objDB.GIN_KOManualScarp(Greige_Header, Defect_Roll_Header, msgerr, dtc, dv_dtc_add, dv_dtc_upd, dv_dtc_del, clsUser.UserID, Tran_no, Roll_no)
            '=============================
            SaveGINKOManual = False

        End If

    End Function

    Private Function SaveGINKOManualScarp(Optional ByVal strGINNO As String = "") As Boolean
        Dim config As New clsConfig
        config.ChangeCulture()
        Dim objDB As New classStockGIN_KOManual
        Dim Greige_Header As New classStockGIN_KOManual.Greige_Header
        Dim Defect_Roll_Header As New classStockGIN_KOManual.Defect_roll_Header

        Dim msgerr As String = ""
        Dim Tran_no As String = strGINNO
        Dim Roll_no As String = txtroll_no.Text.Trim
        Dim someDateAndTime As Date = #1/1/1900 1:12:00 PM#

        'Start Make date to nothing
        Dim DOB As Nullable(Of Date) = Date.Now
        Dim datestring As String = DOB.Value.ToString("d")
        DOB = Nothing
        'End Make date to nothing

        Greige_Header.h01_suppcd = config.IsNull(dt.Rows(0)("suppcd"), "GK")
        Greige_Header.h02_source = config.IsNull(dt.Rows(0)("source"), Nothing)
        Greige_Header.h03_source_refno = config.IsNull(dt.Rows(0)("source_refno"), Nothing)
        Greige_Header.h04_tran_no = txttran_no.Text
        Greige_Header.h05_tran_dt = dtptran_dt.Value
        Greige_Header.h06_design_no = txtdesign_no.Text
        Greige_Header.h07_supdes_no = config.IsNull(dt.Rows(0)("supdes_no"), Nothing)
        Greige_Header.h08_kono = txtkono.Text
        Greige_Header.h09_pieces = config.IsNull(dt.Rows(0)("pieces"), Nothing)
        Greige_Header.h10_nob = config.IsNull(dt.Rows(0)("nob"), Nothing)
        Greige_Header.h11_Gwth = txtgwth.Text
        Greige_Header.h12_Gwth_actual = config.IsNull(dt.Rows(0)("Gwth_actual"), Nothing)
        Greige_Header.h13_roll_no = txtroll_no.Text
        Greige_Header.h14_roll_no_g = config.IsNull(dt.Rows(0)("roll_no_g"), Nothing)
        Greige_Header.h15_roll_no_n = config.IsNull(dt.Rows(0)("roll_no_n"), Nothing)
        Greige_Header.h16_racks = config.IsNull(dt.Rows(0)("racks"), Nothing)
        Greige_Header.h17_kg = config.IsValidDouble(txtkg.Text.Trim)
        Greige_Header.h18_mts = config.IsValidDouble(txtmts.Text.Trim)
        Greige_Header.h19_yds = config.IsValidDouble(txtmts.Text.Trim) / 0.9144
        Greige_Header.h20_kg_qc = config.IsValidDouble(txtkg.Text.Trim) - config.IsValidDouble(txtbar_weight.Text.Trim)
        Greige_Header.h21_mts_qc = config.IsValidDouble(txtmts.Text.Trim)
        Greige_Header.h22_yds_qc = config.IsValidDouble(txtmts.Text.Trim) / 0.9144
        Greige_Header.h23_grade = config.IsNull(txtgrade_bdt.Text.Trim, "") & config.IsNull(txtgrade_bdt.Text.Trim, "")
        Greige_Header.h24_rem_qc = txtrem_qc.Text.Trim
        Greige_Header.h25_loc = oConfig.IsNull(cbomtl_location.Text.Trim, "")
        Greige_Header.h26_outreqno = config.IsNull(dt.Rows(0)("outreqno"), Nothing)
        Greige_Header.h27_outreqdt = config.IsNull(dt.Rows(0)("outreqdt"), Nothing)
        Greige_Header.h28_outreqtyp = config.IsNull(dt.Rows(0)("outreqtyp"), Nothing)
        Greige_Header.h29_outno = config.IsNull(dt.Rows(0)("outno"), Nothing)
        Greige_Header.h30_outdt = config.IsNull(dt.Rows(0)("outdt"), Nothing)
        Greige_Header.h31_lot = txtlot.Text.Trim
        Greige_Header.h32_yr = config.IsNull(dt.Rows(0)("yr"), Nothing)
        Greige_Header.h33_sh = config.IsNull(dt.Rows(0)("sh"), Nothing)
        Greige_Header.h34_dfno = config.IsNull(dt.Rows(0)("dfno"), Nothing)
        Greige_Header.h35_col = config.IsNull(dt.Rows(0)("col"), Nothing)
        Greige_Header.h36_dhcod = config.IsNull(dt.Rows(0)("dhcod"), Nothing)
        Greige_Header.h37_sono = config.IsNull(dt.Rows(0)("sono"), Nothing)
        Greige_Header.h38_sonoid = config.IsNull(dt.Rows(0)("sonoid"), Nothing)
        Greige_Header.h39_roll_no_o = IIf(txtroll_no_o.Text.Trim = "", IIf(chkEsc.Checked, "N", IIf(chkGMK.Checked, "GMK", txtroll_no_o.Text.Trim)), txtroll_no_o.Text.Trim)
        Greige_Header.h40_pn = config.IsNull(dt.Rows(0)("pn"), Nothing)
        Greige_Header.h41_ydkg_g = config.IsNull(dt.Rows(0)("ydkg_g"), Nothing)
        Greige_Header.h42_cost = config.IsNull(dt.Rows(0)("cost"), Nothing)
        Greige_Header.h43_fload = config.IsNull(dt.Rows(0)("fload"), Nothing)
        Greige_Header.h44_rate = config.IsNull(dt.Rows(0)("rate"), Nothing)
        Greige_Header.h45_sel = config.IsNull(dt.Rows(0)("sel"), Nothing)
        Greige_Header.h46_cost_g = config.IsNull(dt.Rows(0)("cost_g"), Nothing)
        Greige_Header.h47_cliped = chkcliped.Checked
        Greige_Header.h48_unit = config.IsNull(dt.Rows(0)("unit"), Nothing)
        Greige_Header.h49_g_cost = config.IsNull(dt.Rows(0)("g_cost"), Nothing)
        Greige_Header.h50_tran_no1 = config.IsNull(txttran_no.Text.Trim, "")
        Greige_Header.h51_tran_not = config.IsNull(txttran_no.Text, "")
        Greige_Header.h52_cancel = config.IsNull(dt.Rows(0)("cancel"), Nothing)
        Greige_Header.h53_doctyp = config.IsNull(dt.Rows(0)("doctyp"), Nothing)
        Greige_Header.h54_preseted = config.IsNull(dt.Rows(0)("preseted"), Nothing)
        Greige_Header.h55_qcalertcd = config.IsNull(dt.Rows(0)("qcalertcd"), Nothing)
        Greige_Header.h56_ProdFinishDate = config.IsValidDate(dtpProdFinishDate.Value)
        Greige_Header.h57_ProdFinishTime = (txtProdFinishTime.Text)   ' Try to check again
        Greige_Header.h58_mcno = config.IsNull(txtmcno.Text, "")
        Greige_Header.h59_adjust_loss_kg = txtadjust_loss_kg.Text.Trim
        Greige_Header.h60_qc_loss_kg = txtqc_loss_kg.Text.Trim
        Greige_Header.h61_dyed_loss_kg = txtdyed_loss_kg.Text.Trim
        Greige_Header.h62_grade_bdt = txtgrade_bdt.Text.Trim
        Greige_Header.h63_grade_adt = txtgrade_adt.Text.Trim
        Greige_Header.h64_dyeing_pass = chkdyeing_pass.Checked
        Greige_Header.h65_dyeing_fail = config.IsNull(dt.Rows(0)("dyeing_fail"), Nothing)
        Greige_Header.h66_shift = txtshift.Text.Trim
        Greige_Header.h67_id_greige_do = config.IsNull(dt.Rows(0)("id_greige_do"), Nothing)
        Greige_Header.h68_id_greige = config.IsNull(dt.Rows(0)("id_greige"), Nothing)
        Greige_Header.h69_lab_loss_kg = txtlab_loss_kg.Text.Trim
        Greige_Header.h70_defect_loss_kg = txtdefect_loss_kg.Text.Trim
        Greige_Header.h71_purno = config.IsNull(dt.Rows(0)("purno"), Nothing)
        Greige_Header.h72_tran_type = config.IsNull(dt.Rows(0)("tran_type"), "KNITTING")
        Greige_Header.h73_roll_no_f = txtroll_no.Text.Trim
        Greige_Header.h74_job_line_id = config.IsNull(dt.Rows(0)("job_line_id"), 0)
        Greige_Header.h75_fabric_cost = config.IsNull(dt.Rows(0)("fabric_cost"), 0)
        Greige_Header.h76_process_cost = config.IsNull(dt.Rows(0)("process_cost"), 0)
        Greige_Header.h77_process_loss_perc = config.IsNull(dt.Rows(0)("process_loss_perc"), 0)
        Greige_Header.h78_other_cost = config.IsNull(dt.Rows(0)("other_cost"), 0)
        Greige_Header.h79_cost_per_unit = config.IsNull(dt.Rows(0)("cost_per_unit"), 0)
        'Greige_Header.h80_sub_location = txtsub_location.Text.Trim
        Greige_Header.h80_sub_location = ""
        Greige_Header.h81_greige_status = config.IsNull(dt.Rows(0)("greige_status"), 0)
        Greige_Header.h82_bar_weight = txtbar_weight.Text.Trim
        Greige_Header.h83_mtl_warehouse_id = config.IsNull(cbomtl_warehouse.SelectedValue, Nothing)
        Greige_Header.h84_mtl_subinventory_id = config.IsNull(cbomtl_subinventory.SelectedValue, Nothing)
        Greige_Header.h85_mtl_locations_id = config.IsNull(cbomtl_location.SelectedValue, Nothing)
        Greige_Header.h88_pcv_item_id = config.IsNull(cbopcv_item_id.SelectedValue, Nothing)

        Defect_Roll_Header.h01_id_defect_roll = 0
        Defect_Roll_Header.h02_roll_no = txtroll_no.Text
        Defect_Roll_Header.h03_defect_code = Nothing
        Defect_Roll_Header.h04_defect_details = Nothing
        Defect_Roll_Header.h05_stock_code = "G"

        Dim dtc As DataTable = grdDefect.DataSource

        Dim dv_dtc_add As New DataView(dtc, "", "", DataViewRowState.Added)
        Dim dv_dtc_upd As New DataView(dtc, "", "", DataViewRowState.ModifiedCurrent)
        Dim dv_dtc_del As New DataView(dtc, "", "", DataViewRowState.Deleted)

        blnCancel = False
        Dim result As DialogResult 'Windows.Forms.DialogResult
        result = MessageBox.Show("Would you like to save ?", "System Message", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button3)
        If result = DialogResult.Cancel Then blnCancel = True
        If result <> DialogResult.Yes Then Exit Function

        If objDB.GIN_KOManualScarp(Greige_Header, Defect_Roll_Header, msgerr, dtc, dv_dtc_add, dv_dtc_upd, dv_dtc_del, clsUser.UserID, Tran_no, Roll_no) Then
            strGINNO = Tran_no
            txttran_no.Text = strGINNO.Trim
            txtroll_no.Text = Roll_no
            MessageBox.Show("Save is Complete! : บันทึก Scarp สำเร็จ! ", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
            SaveGINKOManualScarp = True
        Else
            MessageBox.Show(msgerr, "System Message", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
            SaveGINKOManualScarp = False
        End If

    End Function


    Private Sub cboGINNo_Click(sender As System.Object, e As System.EventArgs)

    End Sub

    Private Sub cboGINNo_DropDownClosed(sender As Object, e As System.EventArgs)
        'Dim objDB As New classStockGIN_KOManual
        'If clsConfig.IsNull(cboGINNo.SelectedItem, "").ToString.Length = 0 Then
        '    'Call BindGrid(grdData, (New classStockG).GetGINPOmanual(clsConfig.IsNull(cboGINNo.ComboBox.SelectedValue, "")))
        '    If getGIN(clsConfig.IsNull(cboGINNo.ComboBox.SelectedValue, "")) Then
        '        GetDefectRoll(txtroll_no.Text.Trim)
        '    End If

        'End If
    End Sub


    Private Sub grdDefect_CellValueChanged(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles grdDefect.CellValueChanged
        Dim objdb As New classStockGIN_KOManual
        Dim StrDefect_Code As String

        If e.RowIndex < 0 Or e.ColumnIndex < 0 Then Exit Sub

        If grdDefect.Columns(e.ColumnIndex).Name = "defect_code" Then
            StrDefect_Code = grdDefect.Rows(e.RowIndex).Cells("defect_code").Value
            grdDefect.Rows(e.RowIndex).Cells("defect_name").Value = objdb.GetDefect_Name(StrDefect_Code)

            ' get so no. and show in grid
        End If
    End Sub

    Private Sub btnPrint_Click(sender As System.Object, e As System.EventArgs) Handles btnPrint.Click
        Dim clsConfig As New clsConfig
        Dim rptFileName = "rptGreigeBarcode.rpt"
        'If clsuser.ReportPath = "" Then clsuser.ReportPath = clsConfig.ReportPath
        'clsUser.ReportPath = "C:\Users\DELL\Desktop\GemmaKnits\"
        If Not clsConfig.CheckReport(clsUser.ReportPath, rptFileName) Then Exit Sub
        Dim frm As New frmReport
        Dim rpt As New CrystalDecisions.CrystalReports.Engine.ReportDocument
        Dim stype As String = ""
        Dim ord As String = ""
        Me.Cursor = Cursors.WaitCursor

        rpt.Load(clsUser.ReportPath & rptFileName)
        rpt.DataSourceConnections.Item(0).SetConnection(clsConn.servername, clsConn.database, False)
        rpt.DataSourceConnections.Item(0).SetLogon(clsConn.Userid, clsConn.Password)
        rpt.VerifyDatabase()
        rpt.SetParameterValue("@roll_no", txtroll_no.Text)
        rpt.SetParameterValue("@loc", clsConfig.IsNull(cbomtl_location.Text, ""))
        rpt.SetParameterValue("@logempcd", UserInfo.UserID)

        'rpt.PrintOptions.PaperSize = CrystalDecisions.Shared.PaperSize.PaperLetter
        'rpt.PrintOptions.PaperOrientation = CrystalDecisions.Shared.PaperOrientation.Portrait
        'rpt.PrintOptions.PaperSource = CrystalDecisions.Shared.PaperSource.Auto

        frm.Title = "Greige Barcode"
        frm.CRViewer.ReportSource = rpt
        frm.MdiParent = Me.ParentForm
        frm.Show()
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub btnExit_Click(sender As System.Object, e As System.EventArgs) Handles btnExit.Click
        If MessageBox.Show("Would you like to exit ?", "System Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then Me.Close()
    End Sub

    Private Sub btnCancel_Click(sender As System.Object, e As System.EventArgs) Handles btnCancel.Click
        Call Canceldata()
    End Sub
    Private Sub Canceldata()

        If CancelGIN() Then
            'GenCbo()
            'InitControl()
            Me.Close()
        Else
            Exit Sub
        End If

    End Sub
    Public Function CancelGIN(Optional ByVal strGINNO As String = "") As Boolean
        Dim config As New clsConfig
        config.ChangeCulture()
        'Dim objDB As New classStockG
        Dim Greige_Header As New classStockGIN_KOManual.Greige_Header
        Dim Objdb As New classStockGIN_KOManual
        Dim msgerr As String = ""
        Dim Tran_no As String = strGINNO
        Dim Roll_no As String = strRollNo

        Greige_Header.h01_suppcd = config.IsNull(dt.Rows(0)("suppcd"), "GK")
        Greige_Header.h02_source = config.IsNull(dt.Rows(0)("source"), Nothing)
        Greige_Header.h03_source_refno = config.IsNull(dt.Rows(0)("source_refno"), Nothing)
        Greige_Header.h04_tran_no = txttran_no.Text
        Greige_Header.h05_tran_dt = dtptran_dt.Value
        Greige_Header.h06_design_no = txtdesign_no.Text
        Greige_Header.h07_supdes_no = config.IsNull(dt.Rows(0)("supdes_no"), Nothing)
        Greige_Header.h08_kono = txtkono.Text
        Greige_Header.h09_pieces = config.IsNull(dt.Rows(0)("pieces"), Nothing)
        Greige_Header.h10_nob = config.IsNull(dt.Rows(0)("nob"), Nothing)
        Greige_Header.h11_Gwth = txtgwth.Text
        Greige_Header.h12_Gwth_actual = config.IsNull(dt.Rows(0)("Gwth_actual"), Nothing)
        Greige_Header.h13_roll_no = txtroll_no.Text
        Greige_Header.h14_roll_no_g = config.IsNull(dt.Rows(0)("roll_no_g"), Nothing)
        Greige_Header.h15_roll_no_n = config.IsNull(dt.Rows(0)("roll_no_n"), Nothing)
        Greige_Header.h16_racks = config.IsNull(dt.Rows(0)("racks"), Nothing)
        Greige_Header.h17_kg = config.IsValidDouble(txtkg.Text.Trim)
        Greige_Header.h18_mts = config.IsValidDouble(txtmts.Text.Trim)
        Greige_Header.h19_yds = config.IsValidDouble(txtmts.Text.Trim) * 0.9144
        Greige_Header.h20_kg_qc = config.IsValidDouble(txtkg.Text.Trim)
        Greige_Header.h21_mts_qc = config.IsValidDouble(txtmts.Text.Trim)
        Greige_Header.h22_yds_qc = config.IsValidDouble(txtmts.Text.Trim) * 0.9144
        Greige_Header.h23_grade = config.IsValidDouble(txtgrade_bdt.Text)
        Greige_Header.h24_rem_qc = txtrem_qc.Text.Trim
        Greige_Header.h25_loc = config.IsNull(cbomtl_location.Text.Trim, "")
        Greige_Header.h26_outreqno = config.IsNull(dt.Rows(0)("outreqno"), Nothing)
        Greige_Header.h27_outreqdt = config.IsNull(dt.Rows(0)("outreqdt"), Nothing)
        Greige_Header.h28_outreqtyp = config.IsNull(dt.Rows(0)("outreqtyp"), Nothing)
        Greige_Header.h29_outno = config.IsNull(dt.Rows(0)("outno"), Nothing)
        Greige_Header.h30_outdt = config.IsNull(dt.Rows(0)("outdt"), Nothing)
        Greige_Header.h31_lot = txtlot.Text.Trim
        Greige_Header.h32_yr = config.IsNull(dt.Rows(0)("yr"), Nothing)
        Greige_Header.h33_sh = config.IsNull(dt.Rows(0)("sh"), Nothing)
        Greige_Header.h34_dfno = config.IsNull(dt.Rows(0)("dfno"), Nothing)
        Greige_Header.h35_col = config.IsNull(dt.Rows(0)("col"), Nothing)
        Greige_Header.h36_dhcod = config.IsNull(dt.Rows(0)("dhcod"), Nothing)
        Greige_Header.h37_sono = config.IsNull(dt.Rows(0)("sono"), Nothing)
        Greige_Header.h38_sonoid = config.IsNull(dt.Rows(0)("sonoid"), Nothing)
        Greige_Header.h39_roll_no_o = config.IsNull(txtroll_no_o.Text.Trim, "")
        Greige_Header.h40_pn = config.IsNull(dt.Rows(0)("pn"), Nothing)
        Greige_Header.h41_ydkg_g = config.IsNull(dt.Rows(0)("ydkg_g"), Nothing)
        Greige_Header.h42_cost = config.IsNull(dt.Rows(0)("cost"), Nothing)
        Greige_Header.h43_fload = config.IsNull(dt.Rows(0)("fload"), Nothing)
        Greige_Header.h44_rate = config.IsNull(dt.Rows(0)("rate"), Nothing)
        Greige_Header.h45_sel = config.IsNull(dt.Rows(0)("sel"), Nothing)
        Greige_Header.h46_cost_g = config.IsNull(dt.Rows(0)("cost_g"), Nothing)
        Greige_Header.h47_cliped = chkcliped.Checked
        Greige_Header.h48_unit = config.IsNull(dt.Rows(0)("unit"), Nothing)
        Greige_Header.h49_g_cost = config.IsNull(dt.Rows(0)("g_cost"), Nothing)
        Greige_Header.h50_tran_no1 = config.IsNull(txttran_no.Text.Trim, "")
        Greige_Header.h51_tran_not = config.IsNull(txttran_no.Text, "")
        Greige_Header.h52_cancel = config.IsNull(dt.Rows(0)("cancel"), Nothing)
        Greige_Header.h53_doctyp = config.IsNull(dt.Rows(0)("doctyp"), Nothing)
        Greige_Header.h54_preseted = config.IsNull(dt.Rows(0)("preseted"), Nothing)
        Greige_Header.h55_qcalertcd = config.IsNull(dt.Rows(0)("qcalertcd"), Nothing)
        Greige_Header.h56_ProdFinishDate = config.IsValidDate(dtpProdFinishDate.Value)
        Greige_Header.h57_ProdFinishTime = (txtProdFinishTime.Text)   ' Try to check again
        Greige_Header.h58_mcno = config.IsNull(txtmcno.Text, "")
        Greige_Header.h59_adjust_loss_kg = txtadjust_loss_kg.Text.Trim
        Greige_Header.h60_qc_loss_kg = txtqc_loss_kg.Text.Trim
        Greige_Header.h61_dyed_loss_kg = txtdyed_loss_kg.Text.Trim
        Greige_Header.h62_grade_bdt = txtgrade_bdt.Text.Trim
        Greige_Header.h63_grade_adt = txtgrade_adt.Text.Trim
        Greige_Header.h64_dyeing_pass = chkdyeing_pass.Checked
        Greige_Header.h65_dyeing_fail = config.IsNull(dt.Rows(0)("dyeing_fail"), Nothing)
        Greige_Header.h66_shift = txtshift.Text.Trim
        Greige_Header.h67_id_greige_do = config.IsNull(dt.Rows(0)("id_greige_do"), Nothing)
        Greige_Header.h68_id_greige = config.IsNull(dt.Rows(0)("id_greige"), Nothing)
        Greige_Header.h69_lab_loss_kg = txtlab_loss_kg.Text.Trim
        Greige_Header.h70_defect_loss_kg = txtdefect_loss_kg.Text.Trim
        Greige_Header.h71_purno = config.IsNull(dt.Rows(0)("purno"), Nothing)
        Greige_Header.h72_tran_type = config.IsNull(dt.Rows(0)("tran_type"), "KNITTING")
        Greige_Header.h73_roll_no_f = txtroll_no.Text.Trim
        Greige_Header.h74_job_line_id = config.IsNull(dt.Rows(0)("job_line_id"), 0)
        Greige_Header.h75_fabric_cost = config.IsNull(dt.Rows(0)("fabric_cost"), 0)
        Greige_Header.h76_process_cost = config.IsNull(dt.Rows(0)("process_cost"), 0)
        Greige_Header.h77_process_loss_perc = config.IsNull(dt.Rows(0)("process_loss_perc"), 0)
        Greige_Header.h78_other_cost = config.IsNull(dt.Rows(0)("other_cost"), 0)
        Greige_Header.h79_cost_per_unit = config.IsNull(dt.Rows(0)("cost_per_unit"), 0)
        'Greige_Header.h80_sub_location = txtsub_location.Text.Trim
        Greige_Header.h81_greige_status = config.IsNull(dt.Rows(0)("greige_status"), 0)
        Greige_Header.h82_bar_weight = txtbar_weight.Text.Trim
        Greige_Header.h83_mtl_warehouse_id = config.IsNull(cbomtl_warehouse.SelectedValue, Nothing)
        Greige_Header.h85_mtl_locations_id = config.IsNull(cbomtl_location.SelectedValue, Nothing)


        Dim dtc As DataTable = grdDefect.DataSource

        Dim dv_dtc_add As New DataView(dtc, "", "", DataViewRowState.Added)
        Dim dv_dtc_upd As New DataView(dtc, "", "", DataViewRowState.ModifiedCurrent)
        Dim dv_dtc_del As New DataView(dtc, "", "", DataViewRowState.Deleted)

        'Dim dts As DataTable = ds.Tables("v_strolls_d")
        'Dim dv_dts_add As New DataView(dts, "", "", DataViewRowState.Added)
        'Dim dv_dts_upd As New DataView(dts, "", "", DataViewRowState.ModifiedCurrent)
        'Dim dv_dts_del As New DataView(dts, "", "", DataViewRowState.Deleted)

        blnCancel = False
        Dim result As DialogResult 'Windows.Forms.DialogResult
        result = MessageBox.Show("Would you like to cancel roll no. " & txtroll_no.Text & " ?", "System Message", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button3)
        If result = DialogResult.Cancel Then blnCancel = True
        If result <> DialogResult.Yes Then Exit Function

        If Objdb.GIN_KOManualCancel(Greige_Header, msgerr, dtc, clsUser.UserID, Tran_no) Then
            strRollNo = Greige_Header.h13_roll_no
            'txtGinno.Text = strGINNO.Trim
            MessageBox.Show("Cancel is Complete! : ยกเลิกสำเร็จ! ", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
            CancelGIN = True
        Else
            MessageBox.Show(msgerr, "System Message", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
            CancelGIN = False
        End If

    End Function

    Private Sub txtmts_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtmts.KeyPress
        '97 - 122 = Ascii codes for simple letters
        '65 - 90  = Ascii codes for capital letters
        '48 - 57  = Ascii codes for numbers
        'If Asc(e.KeyChar) <> 8 Then
        '    If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
        '        e.Handled = True
        '    End If
        'End If
        'If e.KeyChar <> ControlChars.Back Then
        '    e.Handled = Not (Char.IsDigit(e.KeyChar) Or e.KeyChar = ".")
        'End If
        Call OnlyNumber(sender, e)
    End Sub

    Private Sub txtkg_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtkg.KeyPress
        Call OnlyNumber(sender, e)
    End Sub

    Private Sub OnlyNumber(sender As Object, e As System.Windows.Forms.KeyPressEventArgs)
        If e.KeyChar <> ControlChars.Back Then
            e.Handled = Not (Char.IsDigit(e.KeyChar) Or e.KeyChar = ".")
        End If
    End Sub

    Private Sub txtbar_weight_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtbar_weight.KeyPress
        Call OnlyNumber(sender, e)
    End Sub

    Private Sub txtgwth_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtgwth.KeyPress
        Call OnlyNumber(sender, e)
    End Sub

    Private Sub txtadjust_loss_kg_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtadjust_loss_kg.KeyPress
        Call OnlyNumber(sender, e)
    End Sub

    Private Sub txtqc_loss_kg_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtqc_loss_kg.KeyPress
        Call OnlyNumber(sender, e)
    End Sub

    Private Sub txtdyed_loss_kg_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtdyed_loss_kg.KeyPress
        Call OnlyNumber(sender, e)
    End Sub

    Private Sub txtlab_loss_kg_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtlab_loss_kg.KeyPress
        Call OnlyNumber(sender, e)
    End Sub

    Private Sub txtdefect_loss_kg_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtdefect_loss_kg.KeyPress
        Call OnlyNumber(sender, e)
    End Sub

    Private Sub btnApply_Click(sender As System.Object, e As System.EventArgs) Handles btnApply.Click
        ApplyData()
    End Sub
    Private Sub ApplyData()
        Dim config As New clsConfig
        If cbodefect_code.SelectedIndex = -1 Then
            MessageBox.Show("System Message!", "ต้องเลือก Defect Code ก่อน", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1)
            Exit Sub
        End If
        If txtdefect_details.Text.Trim.Length = 0 Then
            MessageBox.Show("System Message!", "ต้องใส่จำนวน Defect ", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1)
            Exit Sub
        End If


        'If cboproperty.SelectedIndex = -1 Then Exit Sub

        grdDefect.AutoGenerateColumns = False

        Dim dt2 As DataTable = grdDefect.DataSource

        Dim dr As DataRow

        Dim msg As String = ""
        Dim i As Integer = 0
        Dim j As Integer = 0

        If CheckDuplicate(Me.cbodefect_code.SelectedValue.ToString, Me.txtdefect_details.Text, dt2) Then
            MessageBox.Show("ข้อมูลซ้ำกัน", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Exit Sub
        End If

        dr = dt2.NewRow



        For j = 0 To dt2.Columns.Count - 1
            dr("defect_code") = Me.cbodefect_code.SelectedValue
            dr("defect_details") = Me.txtdefect_details.Text

        Next
        dt2.Rows.Add(dr)

    End Sub

    Private Function CheckDuplicate(ByVal defect_code As String, ByVal defect_details As String, ByVal dt As DataTable) As Boolean
        If dt.Rows.Count > 0 Then
            Dim i As Integer = 0
            For i = 0 To dt.Rows.Count - 1
                If dt.Rows(i).RowState <> DataRowState.Deleted Then
                    If dt.Rows(i)("defect_code").ToString.Trim = defect_code.Trim And dt.Rows(i)("defect_details").ToString.Trim = defect_details.Trim Then
                        Return True
                    End If
                End If
            Next
        End If
        Return False
    End Function

    Private Sub txtroll_no_o_MouseHover(sender As Object, e As System.EventArgs) Handles txtroll_no_o.MouseHover
        _ToolTip.Show("fill down 'n' For Auto Gen Factory Roll No. , fill down ", txtroll_no_o)
    End Sub

    Private Sub txtroll_no_o_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtroll_no_o.TextChanged

    End Sub

    Private Sub cbomtl_warehouse_DropDownClosed(sender As Object, e As EventArgs) Handles cbomtl_warehouse.DropDownClosed
        GetComboSubInventory(Int64mtl_warehouse_id:=cbomtl_warehouse.SelectedValue, Int64mtl_subinventory_id:=(New clsConfig).IsNull(cbomtl_subinventory.SelectedValue, 0))
        GetComboLocation(Int64mtl_warehouse_id:=cbomtl_warehouse.SelectedValue, Int64mtl_subinventory_id:=(New clsConfig).IsNull(cbomtl_subinventory.SelectedValue, 0))
    End Sub
    Private Sub GetComboSubInventory(ByVal Int64mtl_warehouse_id As Int64, ByVal Int64mtl_subinventory_id As Int64)
        Dim objdb As New classMaster

        cbomtl_subinventory.DataSource = objdb.GetCombomtl_subinventory(cbomtl_warehouse.SelectedValue)
        cbomtl_subinventory.DisplayMember = "subinventory_code"
        cbomtl_subinventory.ValueMember = "mtl_subinventory_id"
        'cbomtl_subinventory.Text = ""
        Call SetDefaultSubInventory(cbomtl_subinventory.DataSource, cbomtl_subinventory)

    End Sub

    Private Sub GetComboLocation(ByVal Int64mtl_warehouse_id As Int64, ByVal Int64mtl_subinventory_id As Int64)
        Dim objdb As New classMaster
        cbomtl_location.DataSource = objdb.Combomtllocations(strUSerID:=clsUser.UserID, pMtlWarehouseId:=Int64mtl_warehouse_id, Int64mtl_subinventory_id:=Int64mtl_subinventory_id)
        cbomtl_location.DisplayMember = "location_name"
        cbomtl_location.ValueMember = "mtl_locations_id"
        ' cbomtl_location.Text = ""

        Call SetDefaultLocation(cbomtl_location.DataSource, cbomtl_location)


    End Sub
    Private Sub SetDefaultWarehouse(ByVal dt As DataTable, ByVal combobox As ComboBox)
        Dim mtlWarehouseId As Int64 = (New classMaster).GetdefaultWarehouse(strUSerID:=clsUser.UserID) 'ESH,COLOMBO

        'Dim expression As String
        'expression = "warehouse_name like '%ESH%'"
        'Dim foundRows() As DataRow
        'foundRows = dt.Select(expression)

        combobox.SelectedValue = mtlWarehouseId

    End Sub
    'Private Sub SetDefaultWarehouse(ByVal dt As DataTable)
    '    Dim expression As String
    '    expression = "warehouse_code like '%ESH%'"
    '    Dim foundRows() As DataRow
    '    foundRows = dt.Select(expression)
    '    If foundRows.Length > 0 Then cbomtl_warehouse.SelectedValue = foundRows(0)(0)

    'End Sub
    Private Sub SetDefaultSubInventory(ByVal dt As DataTable, ByVal combobox As ComboBox)

        Dim pMtlwarehouseid As Nullable(Of Int64) = oConfig.IsNull(cbomtl_warehouse.SelectedValue, Nothing)
        Dim _MtlSubInventoryId As Int64 = oStockGINKOManual.getDefaultSubInventoryId(pMtlwarehouseid)
        ' Dim Int64warehouse_id As Int64 = (New classMaster).GetdefaultWarehouse(strUSerID:=clsUser.UserID) 'GREIGE
        combobox.SelectedValue = _MtlSubInventoryId

    End Sub

    'Private Sub SetDefaultSubInventory(ByVal dt As DataTable)
    '    Dim expression As String
    '    expression = "subinventory_code like '%GREIGE%'"
    '    Dim foundRows() As DataRow
    '    foundRows = dt.Select(expression)
    '    If foundRows.Length > 0 Then cbomtl_subinventory.SelectedValue = foundRows(0)(0)

    'End Sub
    Private Sub SetDefaultLocation(ByVal dt As DataTable, ByVal combobox As ComboBox)

        Dim pMtlSubInventoryId As Nullable(Of Int64) = oConfig.IsNull(cbomtl_subinventory.SelectedValue, Nothing)
        Dim _MtlLocationsID As Nullable(Of Int64) = oStockGINKOManual.getDefaultLocationId(pMtlSubInventoryId)
        ' Dim Int64warehouse_id As Int64 = (New classMaster).GetdefaultWarehouse(strUSerID:=clsUser.UserID) 'GREIGE
        If oConfig.IsNull(_MtlLocationsID, 0) > 0 Then
            combobox.SelectedValue = _MtlLocationsID
        End If

    End Sub
    'Private Sub SetDefaultLocation(ByVal dt As DataTable)
    '    Dim expression As String
    '    expression = "location_name like '%N/A%'"
    '    Dim foundRows() As DataRow
    '    foundRows = dt.Select(expression)
    '    If foundRows.Length > 0 Then cbomtl_location.SelectedValue = foundRows(0)(0)

    'End Sub

    Private Sub cbomtl_warehouse_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbomtl_warehouse.SelectedIndexChanged

    End Sub

    Private Sub cbopcv_item_id_DropDownClosed(sender As Object, e As EventArgs) Handles cbopcv_item_id.DropDownClosed

        If txtbar_weight.Text = 0 Then

        End If

    End Sub

    Private Sub cbopcv_item_id_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbopcv_item_id.SelectedIndexChanged

    End Sub

    Private Sub cbomtl_subinventory_DropDownClosed(sender As Object, e As EventArgs) Handles cbomtl_subinventory.DropDownClosed
        Call GetComboLocation(Int64mtl_warehouse_id:=cbomtl_warehouse.SelectedValue, _
                         Int64mtl_subinventory_id:=cbomtl_subinventory.SelectedValue)
    End Sub

    Private Sub txtdefect_details_TextChanged(sender As Object, e As EventArgs) Handles txtdefect_details.TextChanged

    End Sub
    Private Sub lblQty_Click(sender As Object, e As EventArgs) Handles lblQty.Click

    End Sub
    Private Sub cbodefect_code_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbodefect_code.SelectedIndexChanged

    End Sub
    Private Sub lblDefect_code_Click(sender As Object, e As EventArgs) Handles lblDefect_code.Click

    End Sub

    Private Sub txtgrade_bdt_TextChanged(sender As Object, e As EventArgs) Handles txtgrade_bdt.TextChanged
        Call GenLot_Grade()
    End Sub

    Private Sub GenLot_Grade()
        txtlot_grade.Text = Trim(txtgrade_bdt.Text) + Trim(txtgrade_adt.Text)
    End Sub

    Private Sub txtgrade_adt_TextChanged(sender As Object, e As EventArgs) Handles txtgrade_adt.TextChanged
        Call GenLot_Grade()
    End Sub

    Private Sub btnSaveScarp_Click(sender As Object, e As EventArgs)

        If Not CheckData() Then Exit Sub

        If SaveGINKOManualScarp() Then
            getGIN(txtroll_no.Text.Trim)
            GetGINDefectRoll(txtroll_no.Text.Trim)
        End If
    End Sub
End Class