
Public Class frmStockGIN_KOManual
    Dim clsUser As New classUserInfo
    Dim clsConfig As New clsConfig
    Dim clsConn As New classConnection

    Dim DbStockG As New classStockGIN_KOManual

    Dim dt As New DataTable
    Dim ds As New DataSet
    Dim blnCancel As Boolean = False

    Dim strKONo As String

    Public Property UserInfo() As classUserInfo
        Get
            UserInfo = clsUser
        End Get
        Set(ByVal NewValue As classUserInfo)
            clsUser = NewValue
        End Set
    End Property

    Public Property pKono() As String
        Get
            pKono = strKONo
        End Get
        Set(ByVal NewValue As String)
            strKONo = NewValue
        End Set
    End Property

    Private Sub frmStockGINManual_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
       
        'Call GenGrid()
        Call InitControl()
        'txtkono.Text = frm2.pKono
        Call GenCbo()
        Call GenCboInGrid()

        If pKono <> "" Then
            txtkono.Text = pKono
            If Not blnCancel Then getKO(pKono)
        End If

    End Sub
    Private Sub GenCbo()
        'Dim objDB As New classStockD
        Dim objDB As New classStockGIN_KOManual
        cboGINNo.ComboBox.DataSource = objDB.GetCBOGINKOmanualRollNo()
        cboGINNo.ComboBox.DisplayMember = "roll_no"
        cboGINNo.ComboBox.ValueMember = "roll_no"
        cboGINNo.ComboBox.SelectedIndex = -1
    End Sub
    Private Sub GenCboInGrid()
        Dim objdb As New classStockGIN_KOManual
        Me.defect_code.DataSource = objdb.GetDefect_Code
        Me.defect_code.DisplayMember = "defect_code"
        Me.defect_code.ValueMember = "defect_code"

        'Me.Defect_name.DataSource = Me.defect_code.DataSource
        'Me.Defect_name.DisplayMember = "defect_name"
        'Me.Defect_name.ValueMember = "defect_code"

    End Sub

    Private Sub btnSearchOutNo_Click(sender As System.Object, e As System.EventArgs) Handles btnSearchOutNo.Click
        Dim frm As New frmSearchKO
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
        'Dim dt As DataTable = dbStockG.GetGINKOBYKO(StrKONO, clsUser.UserID)
        dt = dbStockG.GetGINKOBYKO(StrKONO, clsUser.UserID)

        ds = dbStockG.GetGINKOBYKODS(StrKONO, clsUser.UserID)

        If dt.Rows.Count > 0 Then
            Call BinddataByKO(dt)
            Call BinddataDefect()
            Return True
        Else
            Return False
        End If
    End Function
    Private Function getGIN(ByVal StrTran_no As String) As Boolean
        Dim dbStockG As New classStockGIN_KOManual
        dt = dbStockG.GetGINKOBYRollNo(StrTran_no, clsUser.UserID)
        If dt.Rows.Count > 0 Then
            Call Binddata(dt)
            Call BindDataDefect()
            Return True
        Else
            Return False
        End If
    End Function

    Private Function GetDefectRoll(ByVal StrRollNo As String) As Boolean
        Dim dbStockG As New classStockGIN_KOManual
        Dim objdb As DataTable = dbStockG.GetDefectRoll(StrRollNo, clsUser.UserID)
        grdDefect.AutoGenerateColumns = False
        grdDefect.DataSource = objdb
  
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
        dtptran_dt.Value = clsConfig.IsNull(dt.Rows(0)("tran_dt"), Now)
        txtroll_no.Text = dt.Rows(0)("roll_no").ToString.Trim
        txtroll_no_o.Text = dt.Rows(0)("roll_no_o").ToString.Trim
        txtmts.Text = dt.Rows(0)("mts")
        txtkg.Text = dt.Rows(0)("kg")
        txtbar_weight.Text = clsConfig.IsNull(dt.Rows(0)("bar_weight"), 0)
        txtgwth.Text = clsConfig.IsNull(dt.Rows(0)("gwth"), 0)
        txtlot.Text = dt.Rows(0)("lot").ToString.Trim
        txtgrade_bdt.Text = dt.Rows(0)("grade_bdt").ToString.Trim
        txtgrade_adt.Text = dt.Rows(0)("grade_adt").ToString.Trim
        chkcliped.Checked = clsConfig.IsNull((dt.Rows(0)("cliped")), 0)
        txtloc.Text = dt.Rows(0)("loc").ToString.Trim
        txtsub_location.Text = dt.Rows(0)("sub_location").ToString.Trim
        txtshift.Text = dt.Rows(0)("shift").ToString.Trim
        dtpProdFinishDate.Value = clsConfig.IsNull(dt.Rows(0)("ProdFinishDate"), Now)
        'txtProdFinishTime.Text = Format(dt.Rows(0)("ProdFinishTime").ToString.Trim, "DDMMYYY")
        txtProdFinishTime.Text = Format(dt.Rows(0)("ProdFinishTime"), "HH:mm")
        chkdyeing_pass.Checked = clsConfig.IsValidBoolean(dt.Rows(0)("dyeing_pass"))
        txtadjust_loss_kg.Text = dt.Rows(0)("adjust_loss_kg")
        txtqc_loss_kg.Text = dt.Rows(0)("qc_loss_kg")
        txtdyed_loss_kg.Text = dt.Rows(0)("dyed_loss_kg")
        txtlab_loss_kg.Text = dt.Rows(0)("lab_loss_kg")
        txtdefect_loss_kg.Text = dt.Rows(0)("defect_loss_kg")
        txtrem_qc.Text = dt.Rows(0)("rem_qc").ToString.Trim

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
        dtptran_dt.Value = clsConfig.IsNull(dt.Rows(0)("tran_dt"), Now)
        txtroll_no.Text = dt.Rows(0)("roll_no").ToString.Trim
        txtroll_no_o.Text = dt.Rows(0)("roll_no_o").ToString.Trim
        txtmts.Text = clsConfig.IsNull(dt.Rows(0)("mts"), 0)
        txtkg.Text = clsConfig.IsNull(dt.Rows(0)("kg"), 0)
        txtbar_weight.Text = clsConfig.IsNull(dt.Rows(0)("bar_weight"), 0)
        txtgwth.Text = clsConfig.IsNull(dt.Rows(0)("gwth"), 0)
        txtlot.Text = dt.Rows(0)("lot").ToString.Trim
        txtgrade_bdt.Text = dt.Rows(0)("grade_bdt").ToString.Trim
        txtgrade_adt.Text = dt.Rows(0)("grade_adt").ToString.Trim
        chkcliped.Checked = clsConfig.IsNull((dt.Rows(0)("cliped")), 0)
        txtloc.Text = dt.Rows(0)("loc").ToString.Trim
        txtsub_location.Text = dt.Rows(0)("sub_location").ToString.Trim
        txtshift.Text = dt.Rows(0)("shift").ToString.Trim
        dtpProdFinishDate.Value = clsConfig.IsNull(dt.Rows(0)("ProdFinishDate"), Now)
        'txtProdFinishTime.Text = Format(dt.Rows(0)("ProdFinishTime").ToString.Trim, "DDMMYYY")
        txtProdFinishTime.Text = dt.Rows(0)("ProdFinishTime").ToString.Trim
        chkdyeing_pass.Checked = clsConfig.IsNull(dt.Rows(0)("dyeing_pass"), False)
        txtadjust_loss_kg.Text = dt.Rows(0)("adjust_loss_kg")
        txtqc_loss_kg.Text = dt.Rows(0)("qc_loss_kg")
        txtdyed_loss_kg.Text = dt.Rows(0)("dyed_loss_kg")
        txtlab_loss_kg.Text = dt.Rows(0)("lab_loss_kg")
        txtdefect_loss_kg.Text = dt.Rows(0)("defect_loss_kg")
        txtrem_qc.Text = dt.Rows(0)("rem_qc").ToString.Trim

    End Sub
    Private Sub BindDataDefect()
        Dim dbStockG As New classStockGIN_KOManual
        Dim objdb As DataTable = dbStockG.GetDefectRoll(txtroll_no.Text, clsUser.UserID)


    End Sub

    Private Sub btnNew_Click(sender As System.Object, e As System.EventArgs) Handles btnNew.Click
        InitControl()
        getGIN("")
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
        txtloc.Text = ""
        txtsub_location.Text = ""
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

        CleargrdDefect()
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
    Private Sub Savedata()
        Try
            If SaveGINKOManual() Then
                Call GenCbo()
                getGIN(txtroll_no.Text.Trim)

            End If
        Catch ex As Exception

        End Try


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

        Greige_Header.h01_suppcd = "GK"
        Greige_Header.h02_source = Nothing
        Greige_Header.h03_source_refno = Nothing
        Greige_Header.h04_tran_no = txttran_no.Text
        Greige_Header.h05_tran_dt = dtptran_dt.Value
        Greige_Header.h06_design_no = txtdesign_no.Text
        Greige_Header.h07_supdes_no = Nothing
        Greige_Header.h08_kono = txtkono.Text
        Greige_Header.h09_pieces = Nothing
        Greige_Header.h10_nob = Nothing
        Greige_Header.h11_Gwth = txtgwth.Text
        Greige_Header.h12_Gwth_actual = Nothing
        Greige_Header.h13_roll_no = txtroll_no.Text
        Greige_Header.h14_roll_no_g = txtroll_no.Text
        Greige_Header.h15_roll_no_n = Nothing
        Greige_Header.h16_racks = Nothing
        Greige_Header.h17_kg = config.IsValidDouble(txtkg.Text.Trim)
        Greige_Header.h18_mts = config.IsValidDouble(txtmts.Text.Trim)
        Greige_Header.h19_yds = config.IsValidDouble(txtmts.Text.Trim) * 0.9144
        Greige_Header.h20_kg_qc = config.IsValidDouble(txtkg.Text.Trim)
        Greige_Header.h21_mts_qc = config.IsValidDouble(txtmts.Text.Trim)
        Greige_Header.h22_yds_qc = config.IsValidDouble(txtmts.Text.Trim) * 0.9144
        Greige_Header.h23_grade = config.IsValidDouble(txtgrade_bdt.Text)
        Greige_Header.h24_rem_qc = txtrem_qc.Text.Trim
        Greige_Header.h25_loc = "NEW"
        Greige_Header.h26_outreqno = Nothing
        Greige_Header.h27_outreqdt = someDateAndTime
        Greige_Header.h28_outreqtyp = Nothing
        Greige_Header.h29_outno = Nothing
        Greige_Header.h30_outdt = someDateAndTime
        Greige_Header.h31_lot = txtlot.Text.Trim
        Greige_Header.h32_yr = Nothing
        Greige_Header.h33_sh = Nothing
        Greige_Header.h34_dfno = Nothing
        Greige_Header.h35_col = "GREIGE"
        Greige_Header.h36_dhcod = Nothing
        Greige_Header.h37_sono = Nothing
        Greige_Header.h38_sonoid = Nothing
        Greige_Header.h39_roll_no_o = config.IsNull(txtroll_no_o.Text.Trim, "")
        Greige_Header.h40_pn = Nothing
        Greige_Header.h41_ydkg_g = Nothing
        Greige_Header.h42_cost = Nothing
        Greige_Header.h43_fload = Nothing
        Greige_Header.h44_rate = Nothing
        Greige_Header.h45_sel = Nothing
        Greige_Header.h46_cost_g = Nothing
        Greige_Header.h47_cliped = chkcliped.Checked
        Greige_Header.h48_unit = Nothing
        Greige_Header.h49_g_cost = Nothing
        Greige_Header.h50_tran_no1 = config.IsNull(txttran_no.Text.Trim, "")
        Greige_Header.h51_tran_not = config.IsNull(txttran_no.Text, "")
        Greige_Header.h52_cancel = False
        Greige_Header.h53_doctyp = Nothing
        Greige_Header.h54_preseted = False
        Greige_Header.h55_qcalertcd = Nothing
        Greige_Header.h56_ProdFinishDate = config.IsValidDate(dtpProdFinishDate.Value)
        Greige_Header.h57_ProdFinishTime = (txtProdFinishTime.Text)   ' Try to check again
        Greige_Header.h58_mcno = config.IsNull(txtmcno.Text, "")
        Greige_Header.h59_adjust_loss_kg = Nothing
        Greige_Header.h60_qc_loss_kg = Nothing
        Greige_Header.h61_dyed_loss_kg = Nothing
        Greige_Header.h62_grade_bdt = txtgrade_bdt.Text.Trim
        Greige_Header.h63_grade_adt = txtgrade_adt.Text.Trim
        Greige_Header.h64_dyeing_pass = chkdyeing_pass.Checked
        Greige_Header.h65_dyeing_fail = False
        Greige_Header.h66_shift = txtshift.Text.Trim
        Greige_Header.h67_id_greige_do = Nothing
        Greige_Header.h68_id_greige = Nothing
        Greige_Header.h69_lab_loss_kg = 0
        Greige_Header.h70_defect_loss_kg = 0
        Greige_Header.h71_purno = Nothing
        Greige_Header.h72_tran_type = "KNITTING"
        Greige_Header.h73_roll_no_f = txtroll_no.Text.Trim
        Greige_Header.h74_job_line_id = ""
        Greige_Header.h75_fabric_cost = 0
        Greige_Header.h76_process_cost = 0
        Greige_Header.h77_process_loss_perc = 0
        Greige_Header.h78_other_cost = 0
        Greige_Header.h79_cost_per_unit = 0
        Greige_Header.h80_sub_location = 0
        Greige_Header.h81_greige_status = 0
        Greige_Header.h82_bar_weight = 0

        Defect_Roll_Header.h01_id_defect_roll = 0
        Defect_Roll_Header.h02_roll_no = txtroll_no.Text
        Defect_Roll_Header.h03_defect_code = Nothing
        Defect_Roll_Header.h04_defect_details = Nothing
        Defect_Roll_Header.h05_stock_code = "G"

        Dim dtc As DataTable = grdDefect.DataSource

        Dim dv_dtc_add As New DataView(dtc, "", "", DataViewRowState.Added)
        Dim dv_dtc_upd As New DataView(dtc, "", "", DataViewRowState.ModifiedCurrent)
        Dim dv_dtc_del As New DataView(dtc, "", "", DataViewRowState.Deleted)

        'Dim dt2 As DataTable = dt
        'Dim dv2_dtc_add As New DataView(dt, "", "", DataViewRowState.Added)
        'Dim dv2_dtc_upd As New DataView(dt, "", "", DataViewRowState.ModifiedCurrent)
        'Dim dv2_dtc_del As New DataView(dt, "", "", DataViewRowState.Deleted)
        'Dim dts As DataTable = ds.Tables("v_strolls_d")
        'Dim dv_dts_add As New DataView(dts, "", "", DataViewRowState.Added)
        'Dim dv_dts_upd As New DataView(dts, "", "", DataViewRowState.ModifiedCurrent)
        'Dim dv_dts_del As New DataView(dts, "", "", DataViewRowState.Deleted)

        blnCancel = False
        Dim result As DialogResult
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
            SaveGINKOManual = False
        End If

    End Function

    Private Sub cboGINNo_Click(sender As System.Object, e As System.EventArgs) Handles cboGINNo.Click

    End Sub

    Private Sub cboGINNo_DropDownClosed(sender As Object, e As System.EventArgs) Handles cboGINNo.DropDownClosed
        Dim objDB As New classStockGIN_KOManual
        If clsConfig.IsNull(cboGINNo.SelectedItem, "").ToString.Length = 0 Then
            'Call BindGrid(grdData, (New classStockG).GetGINPOmanual(clsConfig.IsNull(cboGINNo.ComboBox.SelectedValue, "")))
            If getGIN(clsConfig.IsNull(cboGINNo.ComboBox.SelectedValue, "")) Then
                GetDefectRoll(txtroll_no.Text.Trim)
            End If

        End If
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
        rpt.SetParameterValue("@loc", txtloc.Text)
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
End Class