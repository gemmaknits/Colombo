Public Class frmKnittingOrder
    Dim config As New clsConfig
    Dim clsConn As New classConnection
    Dim clsUser As New classUserInfo
    Dim kono As String = ""
    Dim StrOldbom As String = "" 'For Check New BOM
    Dim StrOldDesignNo As String = "" 'For Check New Design
    Dim SingleOldQty As Single ' For Check New Qty
    Dim ko As New KO

    Public Property UserInfo() As classUserInfo
        Get
            UserInfo = clsUser
        End Get
        Set(ByVal NewValue As classUserInfo)
            clsUser = NewValue
        End Set
    End Property

    Private Sub SetControlValue(ByVal Obj As Control)
        If TypeOf Obj Is TextBox Then
            Obj.Text = Obj.Tag
        End If
        If TypeOf Obj Is DateTimePicker Then
            Dim dtp As DateTimePicker = Obj
            dtp.Value = "01/01/1900"
            dtp.Value = Now
            'dtp.Value = Now Edit by Neung 23/12/2014
        End If
        If TypeOf Obj Is ComboBox Then
            Dim cbo As ComboBox = Obj
            cbo.SelectedIndex = -1
        End If
        If TypeOf Obj Is CheckBox Then
            Dim chk As CheckBox = Obj
            chk.Checked = False
        End If
        If TypeOf Obj Is TabControl Or TypeOf Obj Is TabPage Or TypeOf Obj Is GroupBox Then
            Dim obj2 As Control
            For Each obj2 In Obj.Controls
                Call SetControlValue(obj2)
            Next
        End If
    End Sub

    Private Sub SetControlEnabled(ByVal Obj As Control, ByVal blnEnabled As Boolean)
        If TypeOf Obj Is TextBox Then Obj.Enabled = blnEnabled
        If TypeOf Obj Is DateTimePicker Then Obj.Enabled = blnEnabled
        If TypeOf Obj Is ComboBox Then Obj.Enabled = blnEnabled
        If TypeOf Obj Is CheckBox Then Obj.Enabled = blnEnabled
        If TypeOf Obj Is DataGridView Then
            Dim grd As DataGridView = Obj
            grd.ReadOnly = Not blnEnabled
        End If
        If TypeOf Obj Is TabControl Or TypeOf Obj Is TabPage Or TypeOf Obj Is GroupBox Then
            Dim obj2 As Control
            For Each obj2 In Obj.Controls
                Call SetControlEnabled(obj2, blnEnabled)
            Next
        End If
    End Sub

    Private Sub EnabledControl(ByVal blnEnabled As Boolean)
        Dim obj As Control
        For Each obj In Me.Controls
            Call SetControlEnabled(obj, blnEnabled)
        Next
    End Sub

    Private Sub InitControl()
        Dim obj As Control
        For Each obj In Me.Controls
            Call SetControlValue(obj)
        Next
        Call EnabledControl(True)
        ko.kono = ""
        ko.production_order_id = 0
        kono = ""
        dtpKODate.Value = Now
        dtpCancelled.Value = "01/01/1900"
        dtpClosed.Value = "01/01/1900"
        dtpDelivered.Value = "01/01/1900"

        grdData.DataSource = Nothing
        grdmfg_production_order_lines.DataSource = Nothing

        Call LoadGridProd(ko)

        txtPRODNo.Focus()

        Call GenComboKONo()
        Call GenCombo()
        Call GenComboDesignBOM("")

    End Sub

    Private Sub GenCombo()
        Dim objDB As New classMaster

        Me.cboSupplier.DataSource = objDB.comboSupplier(clsUser.UserID)
        Me.cboSupplier.DisplayMember = "name"
        Me.cboSupplier.ValueMember = "suppcd"
        Me.cboSupplier.SelectedIndex = -1

        Me.cboSONo.DataSource = objDB.comboSODR(clsUser.UserID)
        Me.cboSONo.DisplayMember = "so_cust"
        Me.cboSONo.ValueMember = "sono"
        Me.cboSONo.SelectedIndex = 0

        Me.cboCustomer.DataSource = objDB.comboCustomer(clsUser.UserID)
        Me.cboCustomer.DisplayMember = "name"
        Me.cboCustomer.ValueMember = "custcd"
        Me.cboCustomer.SelectedIndex = 0

        Me.cboDesignNo.DataSource = objDB.comboGreigeDesign(clsUser.UserID)
        Me.cboDesignNo.DisplayMember = "itcd2"
        Me.cboDesignNo.ValueMember = "itcd"
        Me.cboDesignNo.SelectedIndex = 0
        StrOldDesignNo = config.IsNull(cboDesignNo.SelectedValue, "")

        Me.cboMachineNo.DataSource = objDB.comboMachine(clsUser.UserID)
        Me.cboMachineNo.DisplayMember = "mcdesc"
        Me.cboMachineNo.ValueMember = "mcno"
        Me.cboMachineNo.SelectedIndex = 0

        Call GetComboWarehouseinGrid()
        Call GetcomboSubInventoryinGrid(Int64mtl_warehouse_id:=0)


        Me.item_id.DataSource = objDB.ComboItems(StrUserId:=clsUser.UserID)
        Me.item_id.DisplayMember = "itcd"
        Me.item_id.ValueMember = "item_id"

        Me.uom_id.DataSource = objDB.GetUOM()
        Me.uom_id.DisplayMember = "uom"
        Me.uom_id.ValueMember = "uom_id"

    End Sub

    Private Sub GetComboWarehouseinGrid()
        Dim objdb As New classMaster
        mtl_warehouse_id.DataSource = objdb.Combomtlwarehouse(clsUser.UserID)
        mtl_warehouse_id.DisplayMember = "warehouse_code"
        mtl_warehouse_id.ValueMember = "mtl_warehouse_id"
        'SetdefaultWarehouse()
    End Sub
    Private Sub GetcomboSubInventoryinGrid(ByVal Int64mtl_warehouse_id As Int64)
        Dim objdb As New classMaster
        source_subinventory_id.DataSource = objdb.GetCombomtl_subinventory(Int64mtl_warehouse_id)
        source_subinventory_id.DisplayMember = "subinventory_code"
        source_subinventory_id.ValueMember = "mtl_subinventory_id"
        'Setdefaultsubinventory(0)
    End Sub

    Private Sub GenComboKONo()
        Dim objDB As New classMaster

        Me.cboKoNo.ComboBox.DataSource = objDB.comboKOStatus  'Sitthana 06/02/2018
        Me.cboKoNo.ComboBox.DisplayMember = "konowithstat"    'Sitthana 06/02/2018
        Me.cboKoNo.ComboBox.ValueMember = "production_order_id"
        Me.cboKoNo.ComboBox.SelectedIndex = 0
    End Sub

    Private Sub GenComboDesignBOM(strDesignNo As String)
        Dim objDB As New classMaster

        If Not cboBOM.DataSource Is Nothing Then StrOldbom = config.IsNull(cboBOM.SelectedValue, "")

        Me.cboBOM.DataSource = objDB.comboDesignBOM(strDesignNo, clsUser.UserID)
        Me.cboBOM.DisplayMember = "ynchgcd"
        Me.cboBOM.ValueMember = "ynchgcd"

        cboBOM.SelectedValue = StrOldbom
        'Me.cboBOM.SelectedIndex = -1
        'StrOldbom = config.IsNull(cboBOM.SelectedValue, "")

    End Sub

    Private Sub GenStandardRollKgs(strDesignNo As String)
        Dim objdb As New classMaster
        Dim dt As New DataTable
        dt = objdb.GetDesign(design_no:=strDesignNo)
        If dt.Rows.Count > 0 Then
            Me.txtStandardRollKgs.Text = dt.Rows(0)("kg_per_roll")
        End If
        ' Me.txtStandardRollKgs.Text = objdb.GetDesign(design_no:=strDesignNo)
    End Sub

    Private Sub BindData(ByVal dt As DataTable)
        kono = dt.Rows(0)("kono").ToString

        If kono.Substring(0, 2).Equals("KI") Then
            optKI.Checked = True
        ElseIf kono.Substring(0, 2).Equals("KO") Then
            optKO.Checked = True
        ElseIf kono.Substring(0, 2).Equals("KP") Then
            optKP.Checked = True
        ElseIf kono.Substring(0, 2).Equals("KC") Then
            optKC.Checked = True
        ElseIf kono.Substring(0, 2).Equals("WO") Then
            optWO.Checked = True
        ElseIf kono.Substring(0, 2).Equals("KS") Then
            optKS.Checked = True
        Else
            optKI.Checked = True
        End If

        cboSupplier.SelectedValue = dt.Rows(0)("suppcd").ToString
        txtPRODNo.Text = dt.Rows(0)("kono").ToString
        dtpKODate.Value = dt.Rows(0)("kodt").ToString
        cboMachineNo.SelectedValue = dt.Rows(0)("mcno").ToString
        txtNeedle.Text = dt.Rows(0)("needle").ToString
        cboDesignNo.SelectedValue = dt.Rows(0)("design_no").ToString

        'Call GenComboDesignBOM(dt.Rows(0)("design_no").ToString)

        txtGwth.Text = dt.Rows(0)("gwth").ToString
        txtNob.Text = dt.Rows(0)("nob").ToString
        txtRemark.Text = dt.Rows(0)("remark").ToString
        txtRolls.Text = dt.Rows(0)("nop").ToString
        txtSketch.Text = dt.Rows(0)("sketch").ToString
        txtSetOut.Text = dt.Rows(0)("setout").ToString
        txtRepeatWth.Text = dt.Rows(0)("repwth").ToString
        txtRepeatLen.Text = dt.Rows(0)("replen").ToString
        txtWidth.Text = dt.Rows(0)("width").ToString
        chkElastic.Checked = dt.Rows(0)("elastic").ToString
        chkRigid.Checked = dt.Rows(0)("rigid").ToString
        chkRayon.Checked = dt.Rows(0)("ray").ToString
        chkCationicPoly.Checked = dt.Rows(0)("cat").ToString
        chkCrossDye.Checked = dt.Rows(0)("crossdye").ToString
        cboSONo.SelectedValue = dt.Rows(0)("sono").ToString
        cboCustomer.SelectedValue = dt.Rows(0)("custcd").ToString
        dtpStartDate.Value = dt.Rows(0)("kstartdt").ToString
        dtpEndDate.Value = dt.Rows(0)("kenddt").ToString
        cboBOM.SelectedValue = dt.Rows(0)("ynchgcd").ToString

        'Call LoadGridData(kono, dt.Rows(0)("design_no").ToString, dt.Rows(0)("ynchgcd").ToString)

        chkClosed.Checked = dt.Rows(0)("koclosed").ToString
        dtpClosed.Value = dt.Rows(0)("koclosedt").ToString
        chkCancelled.Checked = dt.Rows(0)("cancel").ToString
        dtpCancelled.Value = dt.Rows(0)("canceldt").ToString
        txtClosedRemark.Text = dt.Rows(0)("rem_closed").ToString
        txtCancelledRemark.Text = dt.Rows(0)("rem_cancel").ToString
        chkDelivered.Checked = dt.Rows(0)("koclosed_final").ToString
        dtpDelivered.Value = dt.Rows(0)("koclosed_final_date").ToString
        txtDeliveredRemark.Text = dt.Rows(0)("rem_closed_final").ToString
        txtSetupDays.Text = dt.Rows(0)("adjustment").ToString
        txtStandardRollKgs.Text = dt.Rows(0)("roll_kgs_std").ToString
        txtDFBatchSize.Text = dt.Rows(0)("df_batch_kgs").ToString
        txtDailyCapacity.Text = dt.Rows(0)("daily_capacity_kg").ToString
        txtQty.Text = dt.Rows(0)("qty").ToString
        txtsteam_instruction.Text = dt.Rows(0)("steam_instruction").ToString
        txtknit_loss_perc.Text = dt.Rows(0)("knit_loss_perc").ToString
        txtdyeding_loss_perc.Text = dt.Rows(0)("dyeding_loss_perc").ToString

        txtDesign_cross.Text = dt.Rows(0)("Design_cross").ToString
        txtproduction_order_no_cross.Text = dt.Rows(0)("production_order_no_cross").ToString
        txtTotal_Production_lot.Text = dt.Rows(0)("total_production_lots").ToString

        ko.production_order_id = dt.Rows(0)("production_order_id")
    End Sub

    Private Sub BindGrid(ByVal dt As DataTable)

        grdData.AutoGenerateColumns = False
        grdData.DataSource = dt
    End Sub
    Private Sub BindGridProd(ByVal dt As DataTable)
        grdmfg_production_order_lines.AutoGenerateColumns = False
        grdmfg_production_order_lines.DataSource = dt
    End Sub

    Private Sub LoadData(ByVal ko As KO)
        Dim objDB As New classProduction

        'Dim dt As DataTable = objDB.ProductionSelect(ko, clsUser)
        Dim dt As DataTable = objDB.KOSelect2(ko, clsUser)
        If dt.Rows.Count > 0 Then
            Call GenComboDesignBOM(dt.Rows(0)("design_no").ToString)
            Call BindData(dt)
            Call LoadGridData(kono, dt.Rows(0)("design_no").ToString, dt.Rows(0)("ynchgcd").ToString, dt.Rows(0)("qty"))
            Call LoadGridProd(ko)
        Else
            Call InitControl()
        End If


    End Sub

    Private Sub LoadGridProd(ByVal Ko As KO)
        Dim objDB As New classProduction
        Dim dt As DataTable = objDB.ProductionSelect(Ko, clsUser)

        Call BindGridProd(dt)

        StrOldDesignNo = config.IsNull(cboDesignNo.SelectedValue, "")
        StrOldbom = config.IsNull(cboBOM.SelectedValue, "")
        SingleOldQty = Val(txtQty.Text)
    End Sub

    Private Sub LoadGridData(ByVal strKONo As String, ByVal strDesignNo As String, ByVal strBOM As String, ByVal SingleQty As Single)
        Dim objDB As New classProduction
        Dim dt As DataTable = objDB.KOBOMSelect(strKONo, strDesignNo, strBOM, SingleQty, clsUser.UserID)
        Call BindGrid(dt)
    End Sub

    Private Function SaveData() As Boolean

      
        'If grdData.Focus Then txtDINNo.Focus() 'Fix Bug User
        'If grdmfg_production_order_lines.Rows.Count > 0 Then
        '    grdmfg_production_order_lines.EndEdit(DataGridViewDataErrorContexts.Commit) 'Fix Bug User
        '    grdmfg_production_order_lines.CurrentCell = grdmfg_production_order_lines.Rows(0).Cells("item_id") 'Fix Bug User
        'End If

        Dim objKO As New KO
        Dim objDB As New classProduction
        Dim errmsg As String = ""
        Dim dtc As New DataTable
        dtc = grdmfg_production_order_lines.DataSource
        'dtc = grdmfg_production_order_lines.DataSource
        Dim dv_dtc_add As New DataView(dtc, "", "", DataViewRowState.Added)
        Dim dv_dtc_upd As New DataView(dtc, "", "", DataViewRowState.ModifiedCurrent)
        Dim dv_dtc_del As New DataView(dtc, "", "", DataViewRowState.Deleted)

        objKO.ko_type = IIf(optKI.Checked, 1, IIf(optKO.Checked, 2, IIf(optKP.Checked, 3, IIf(optKC.Checked, 4, IIf(optWO.Checked, 5, IIf(optKS.Checked, 6, 1))))))
        objKO.suppcd = cboSupplier.SelectedValue
        objKO.kono = txtPRODNo.Text.Trim

        objKO.kodt = dtpKODate.Value.ToString("dd/MM/yyyy")
        objKO.mcno = cboMachineNo.SelectedValue
        objKO.needle = txtNeedle.Text
        objKO.design_no = cboDesignNo.SelectedValue
        objKO.gwth = txtGwth.Text
        objKO.nob = txtNob.Text
        objKO.remark = txtRemark.Text
        objKO.nop = Val(txtRolls.Text)
        objKO.sketch = txtSketch.Text
        objKO.setout = txtSetOut.Text
        objKO.repwth = txtRepeatWth.Text
        objKO.replen = txtRepeatLen.Text
        objKO.width = txtWidth.Text
        objKO.elastic = chkElastic.Checked
        objKO.rigid = chkRigid.Checked
        objKO.ray = chkRayon.Checked
        objKO.cat = chkCationicPoly.Checked
        objKO.crossdye = chkCrossDye.Checked
        objKO.sono = config.IsNull(cboSONo.SelectedValue, cboSONo.SelectedText)
        objKO.custcd = cboCustomer.SelectedValue
        objKO.kstartdt = dtpStartDate.Value.ToString("yyyyMMdd")
        objKO.kenddt = dtpEndDate.Value.ToString("yyyyMMdd")
        objKO.ynchgcd = cboBOM.SelectedValue
        objKO.koclosed = chkClosed.Checked
        objKO.koclosedt = dtpClosed.Value.ToString("yyyyMMdd")
        objKO.cancel = chkCancelled.Checked
        objKO.canceldt = dtpCancelled.Value.ToString("yyyyMMdd")
        objKO.rem_closed = txtClosedRemark.Text
        objKO.rem_cancel = txtCancelledRemark.Text
        objKO.koclosed_final = chkDelivered.Checked
        objKO.koclosed_final_date = dtpDelivered.Value.ToString("yyyyMMdd")
        objKO.rem_closed_final = txtDeliveredRemark.Text
        objKO.adjustment = txtSetupDays.Text
        objKO.roll_kgs_std = Val(txtStandardRollKgs.Text)
        objKO.df_batch_kgs = Val(txtDFBatchSize.Text)
        objKO.daily_capacity_kg = Val(txtDailyCapacity.Text)
        objKO.qty = Val(txtQty.Text)
        objKO.steam_instruction = txtsteam_instruction.Text
        objKO.knit_loss_perc = Val(txtknit_loss_perc.Text.Trim)
        objKO.dyeding_loss_perc = Val(txtdyeding_loss_perc.Text.Trim)

        objKO.design_cross = txtDesign_cross.Text.Trim
        objKO.production_order_no_cross = txtproduction_order_no_cross.Text.Trim.ToUpper
        objKO.total_production_lots = CInt(txtTotal_Production_lot.Text.Trim)

        IIf(txtPRODNo.Text.Trim = "", 0, objKO.production_order_id = objDB.KOSelectID(txtPRODNo.Text.Trim, clsUser.UserID))

        If objDB.KOUpdate(objKO:=objKO, DTC:=dtc, DV_DTC_ADD:=dv_dtc_add, DV_DTC_UPD:=dv_dtc_upd, DV_DTC_DEL:=dv_dtc_del, logempcd:=clsUser.UserID, errmsg:=errmsg) Then
            'Call GenComboKONo()
            txtPRODNo.Text = objKO.kono

            If txtPRODNo.Text.Length > 0 Or objKO.kono.Length > 0 Then
                'Call InitControl()
                Call LoadData(ko:=objKO)
            Else
                Call InitControl()
            End If

            MessageBox.Show("Save Completed" & vbCrLf & errmsg, "System Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            MessageBox.Show(errmsg, "System Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Function

    Private Sub frmKnittingOrder_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Application.EnableVisualStyles()

        Call InitControl()
    End Sub

    Private Sub frmKnittingOrder_FormClosing(sender As System.Object, e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        If MessageBox.Show("Would you like to exit ?", "System Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = System.Windows.Forms.DialogResult.No Then
            e.Cancel = True
        End If
    End Sub

    Private Sub btnNew_Click(sender As System.Object, e As System.EventArgs) Handles btnNew.Click
        Call InitControl()
    End Sub

    Private Sub btnSave_Click(sender As System.Object, e As System.EventArgs) Handles btnSave.Click

        Dim clsconfig As New clsConfig
        If Not grdmfg_production_order_lines.DataSource Is Nothing Then
            If grdmfg_production_order_lines.Rows.Count > 0 Then
                If grdmfg_production_order_lines.CurrentCell.IsInEditMode Then
                    Dim cell As DataGridViewCell = grdmfg_production_order_lines.CurrentCell
                    grdmfg_production_order_lines.EndEdit(DataGridViewDataErrorContexts.Commit)
                    grdmfg_production_order_lines.CurrentCell = grdmfg_production_order_lines.Rows(0).Cells("item_id")
                    grdmfg_production_order_lines.CurrentCell = cell
                End If
            End If
        End If

        If Not CheckData() Then Exit Sub

        If MessageBox.Show("Would you like to save ?", "System Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = System.Windows.Forms.DialogResult.Yes Then
            Call SaveData()
        End If
    End Sub

    Private Function CheckData() As Boolean
        'check ถ้าไม่มี Production Order line ไม่ให้บันทึก
        If grdmfg_production_order_lines.Rows.Count = 0 Then
            MessageBox.Show("ต้องมี Production Order Lines", "System Message!", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
            CheckData = False
            Exit Function
        End If

        'Check Line_type = -1 and ไม่ได้ใส่ Subinventory ไม่ให้บันทึก
        If grdmfg_production_order_lines.Rows.Count > 0 Then
            For i = 0 To grdmfg_production_order_lines.Rows.Count - 1
                If (New clsConfig).IsNull(grdmfg_production_order_lines.Rows(i).Cells("line_type").Value, 0) = -1 Then
                    If (New clsConfig).IsNull(grdmfg_production_order_lines.Rows(i).Cells("source_subinventory_id").Value, 0) = 0 Then
                        MessageBox.Show("ต้องมี Subinventorys", "System Message!", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
                        CheckData = False
                        Exit Function
                    End If
                End If
            Next
        End If

        'If (New clsConfig).IsNull(cboBOM.SelectedValue, "").ToString.Trim = "" Then
        '    MessageBox.Show("Please choose BOM!!", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
        '    CheckData = False
        '    Exit Function
        'End If

        CheckData = True
    End Function

    Private Sub btnPrint_Click(sender As System.Object, e As System.EventArgs) Handles btnPrint.Click
        Dim rptFileName As String = "rptKO.rpt"
        If optWO.Checked Then
            rptFileName = "rptWO.rpt"
        End If

        'If clsuser.ReportPath = "" Then clsuser.ReportPath = clsConfig.ReportPath
        Dim objKO As New KO
        objKO.ko_type = IIf(optKI.Checked, 1, IIf(optKO.Checked, 2, IIf(optKP.Checked, 3, IIf(optKC.Checked, 4, IIf(optWO.Checked, 5, IIf(optKS.Checked, 6, 1))))))

        If Not config.CheckReport(clsUser.ReportPath, rptFileName) Then Exit Sub
        Dim frm As New frmReport
        Dim rpt As New CrystalDecisions.CrystalReports.Engine.ReportDocument
        Dim stype As String = ""
        Dim ord As String = ""
        Me.Cursor = Cursors.WaitCursor

        rpt.Load(clsUser.ReportPath & rptFileName)
        rpt.DataSourceConnections.Item(0).SetConnection(clsConn.servername, clsConn.database, False)
        rpt.DataSourceConnections.Item(0).SetLogon(clsConn.Userid, clsConn.Password)
        rpt.VerifyDatabase()
        rpt.SetParameterValue("@kono", kono)
        'Add by Neung 03/02/2015
        rpt.SetParameterValue("@ko_type", objKO.ko_type)
        rpt.SetParameterValue("@logempcd", clsUser.UserID)

        frm.Title = "Knitting Order"
        frm.CRViewer.ReportSource = rpt
        frm.MdiParent = Me.ParentForm
        frm.Show()
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub btnMinimized_Click(sender As System.Object, e As System.EventArgs) Handles btnMinimized.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub btnExit_Click(sender As System.Object, e As System.EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub cboKoNo_DropDownClosed(sender As System.Object, e As System.EventArgs) Handles cboKoNo.DropDownClosed
        'Dim ko As New KO
        'Begin Sitthana 06/02/2018
        Dim KoNO As String = "" 'config.IsNull(cboKoNo.ComboBox.SelectedText, "")
        Dim numstr As Integer = 0

        KoNO = config.IsNull(cboKoNo.ComboBox.Text, "")
        numstr = InStr(KoNO, "(")
        If numstr > 0 Then
            ko.kono = Mid(KoNO, 1, numstr - 1).Trim
        Else
            ko.kono = KoNO.Trim
        End If
        'End  Sitthana 06/02/2018

        'ko.kono = config.IsNull(cboKoNo.ComboBox.SelectedText, "") 'Sitthana 06/02/2018
        ko.production_order_id = config.IsNull(cboKoNo.ComboBox.SelectedValue, Nothing)
        'If ko.kono.Length > 0 Then
        Call LoadData(ko)
        ' End If

    End Sub

    Private Sub txtKONo_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles txtPRODNo.KeyDown
        If e.KeyCode = Keys.Enter Then
            ko.kono = txtPRODNo.Text.Trim
            cboKoNo.Text = txtPRODNo.Text.Trim
            Call LoadData(ko:=ko)

        End If
       
    End Sub

    Private Sub cboDesignNo_DropDownClosed(sender As System.Object, e As System.EventArgs) Handles cboDesignNo.DropDownClosed

        Dim design_no As String
        design_no = config.IsNull(cboDesignNo.SelectedValue, "")
        If design_no = "" Then Exit Sub
        If Not Validate_Design_no(design_no) Then
            MessageBox.Show("BOM No. : " & design_no & "..Didn't Create...,Please Create It ")
            Exit Sub

        End If


        Dim strDesignNo As String = config.IsNull(cboDesignNo.SelectedValue, "")
        ' If Not strDesignNo.Equals(StrOldDesignNo) Then
        Call GenComboDesignBOM(strDesignNo)
        Call GenStandardRollKgs(strDesignNo)
        ' Else
        'Call GenComboDesignBOM(strDesignNo)
        'Call GenStandardRollKgs(strDesignNo)
        'End If

        Dim strBOM As String = config.IsNull(cboBOM.SelectedValue, "")
        Dim SingleQty As Single = Val(txtQty.Text)

        GenProductionOrderLine(StrKono:=txtPRODNo.Text.Trim, _
                        StrDesignNo:=config.IsNull(cboDesignNo.SelectedValue, ""), _
                          StrBOM:=config.IsNull(cboBOM.SelectedValue, ""), _
                          SingleQty:=Val(txtQty.Text.Trim))


    End Sub


    Private Sub cboBOM_DropDownClosed(sender As System.Object, e As System.EventArgs) Handles cboBOM.DropDownClosed
        Dim strDesignNo As String = config.IsNull(cboDesignNo.SelectedValue, "")
        Dim strBOM As String = config.IsNull(cboBOM.SelectedValue, "")
        Dim SingleQty As Single = Val(txtQty.Text)

        'Dim KO As New KO
        'KO.kono = ""

        Call GenProductionOrderLine(StrKono:=(New clsConfig).IsNull(txtPRODNo.Text.Trim, ""), _
                          StrDesignNo:=config.IsNull(cboDesignNo.SelectedValue, ""), _
                          StrBOM:=config.IsNull(cboBOM.SelectedValue, ""), _
                          SingleQty:=Val(txtQty.Text.Trim))

    End Sub

    Private Sub GenProductionOrderLine(ByVal StrKono As String, ByVal StrDesignNo As String, ByVal StrBOM As String, ByVal SingleQty As Single)

        'If SingleQty = 0 Then Exit Sub
        'If Not StrBOM.Equals(StrOldbom) Or Not StrDesignNo.Equals(StrOldDesignNo) Or Not SingleQty.Equals(SingleOldQty) Then
        Call LoadGridData(strKONo:=kono, strDesignNo:=StrDesignNo, strBOM:=StrBOM, SingleQty:=SingleQty)

        Dim dt As DataTable = grdmfg_production_order_lines.DataSource

        If Not dt Is Nothing Then dt.Rows.Clear()

        Call GetDataProLine(StrKono:=StrKono, _
                            strDesignNo:=StrDesignNo, _
                            strBOM:=StrBOM, _
                            SingleQty:=SingleQty)


        'End If
    End Sub



    Private Function Validate_Design_no(design_no) As Boolean
        Dim objDB As New classProduction
        Dim dt As DataTable = objDB.Validateyarnchange(design_no, clsUser.UserID)

        If dt.Rows.Count = 0 Then
            Return False
        End If
        Return True
    End Function

    Private Sub cboBOM_DropDown(sender As Object, e As EventArgs) Handles cboBOM.DropDown

    End Sub


    Private Sub GetDataProLine(ByVal StrKono As String, ByVal strDesignNo As String, ByVal strBOM As String, ByVal SingleQty As Single)
        Dim objdb As New classProduction
        Dim dt As New DataTable

        dt = objdb.GetKOProLineSelect(strKONo:=StrKono, strDesignNo:=strDesignNo, strBOM:=strBOM, SingleQty:=SingleQty, logempcd:=clsUser.UserID)

        Call BindGridProd(dt)

        StrOldDesignNo = config.IsNull(cboDesignNo.SelectedValue, "")
        StrOldbom = config.IsNull(cboBOM.SelectedValue, "")
        SingleOldQty = Val(txtQty.Text)

        'BindGridProdNew(dt:=dt)

    
    End Sub

    Private Sub BindGridProdNew(ByVal dt As DataTable)
        Dim dt1 As DataTable = dt
        Dim dtProLine As DataTable = grdmfg_production_order_lines.DataSource
        Dim dr As DataRow
        For i = 0 To dt1.Rows.Count - 1
            dr = dtProLine.NewRow

            For j = 0 To dtProLine.Columns.Count - 1
                'dr("mfg_production_order_lines_id") = dt1.Rows(i)("mfg_production_order_lines_id")
                'dr("item_id") = dt1.Rows(i)("item_id")
                'dr("mtl_warehouse_id") = dt1.Rows(i)("mtl_warehouse_id")
                'dr("source_subinventory_id") = dt1.Rows(i)("source_subinventory_id")
                'dr("line_type") = dt1.Rows(i)("line_type")
                'dr("plan_qty") = dt1.Rows(i)("plan_qty")
                'dr("actual_qty") = dt1.Rows(i)("actual_qty")
                'dr("uom_id") = dt1.Rows(i)("uom_id")
                'dr("creation_date") = dt1.Rows(i)("creation_date")
                'dr("created_by") = dt1.Rows(i)("created_by")
                'dr("last_modified_date") = dt1.Rows(i)("last_modified_date")
                'dr("last_modified_by") = dt1.Rows(i)("last_modified_by")
                'dr("last_modified_by") = dt1.Rows(i)("last_modified_by")

                dr(dtProLine.Columns(j).ColumnName.Trim) = dt1.Rows(i)(dtProLine.Columns(j).ColumnName.Trim)
            Next
            dtProLine.Rows.Add(dr)

        Next
    End Sub

    Private Sub btnRouting_Click(sender As System.Object, e As System.EventArgs) Handles btnRouting.Click
        Dim KO As New KO
        Dim objdb As New classProduction

        KO.ko_type = IIf(optKI.Checked, 1, IIf(optKO.Checked, 2, IIf(optKP.Checked, 3, IIf(optKC.Checked, 4, IIf(optWO.Checked, 5, IIf(optKS.Checked, 6, 1))))))
        KO.production_order_id = objdb.KOSelectID(txtPRODNo.Text.Trim, clsUser.UserID)
        KO.kono = txtPRODNo.Text
        KO.design_no = cboDesignNo.SelectedValue.ToString
        KO.qty = txtQty.Text
        KO.ynchgcd = cboBOM.Text
        KO.daily_capacity_kg = txtDailyCapacity.Text
        KO.roll_kgs_std = txtStandardRollKgs.Text
        KO.kstartdt = dtpStartDate.Value.ToString
        KO.kenddt = dtpEndDate.Value.ToString


        'Dim Strlookup_value_short_code As String
        ' Strlookup_value_short_code = (New classMaster).Getlookup_value_short_code(Int64lookup_value_id:=cboKoType.SelectedValue)
        'If Strlookup_value_short_code.Trim = "WO" Then
        'rptFileName = "rptWO.rpt"
       ' End If

        If Validate_KoNo(txtPRODNo.Text.Trim) Then 'Go to frmProductionRouting

            If optKI.Checked Then
                Dim frmProRouting As New frmProductionRoutingKnitting
                frmProRouting.KOdata = KO
                frmProRouting.UserInfo = clsUser
                frmProRouting.MdiParent = Me.ParentForm
                frmProRouting.Show()
            ElseIf optWO.Checked Then
                Dim frmProRouting As New frmProductionRoutingWarping
                frmProRouting.KOdata = KO
                frmProRouting.UserInfo = clsUser
                frmProRouting.MdiParent = Me.ParentForm
                frmProRouting.Show()
            End If


        End If
    End Sub

    Private Function Validate_KoNo(Optional ByVal StrKono As String = "") As Boolean
        Dim objdb As New classProductionRouting
        Dim dt As DataTable = objdb.Validate_KoNo(StrKono, clsUser.UserID)
        If dt.Rows.Count = 0 Then
            MessageBox.Show("KO No .: " & StrKono & "............   is Not Correct!!", "SyStem Messsage", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return False
        Else
            Return True
        End If
    End Function



    Private Sub cboSONo_DropDownClosed(sender As Object, e As EventArgs) Handles cboSONo.DropDownClosed
        Call LoadDataCustcdFromSO()

    End Sub
    Private Sub LoadDataCustcdFromSO()
        Dim objdb As New classSalesOrder
        Dim dt As DataTable = objdb.SODetLoad(cboSONo.SelectedValue)
        'Call BindGrid(dt)
        If dt.Rows.Count > 0 Then cboCustomer.SelectedValue = dt.Rows(0)("custcd")


    End Sub

    Private Sub cboSONo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboSONo.SelectedIndexChanged

    End Sub

    Private Sub btnGenQty_Click(sender As Object, e As EventArgs) Handles btnGenQty.Click
        Dim objdb As New classProduction
        Dim int_set_qty As Nullable(Of Integer)
        If optWO.Checked Then

            Dim result As System.Windows.Forms.DialogResult
            result = MessageBox.Show("Would You Like To Gens Qty ?", "System Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button3)
            If result = System.Windows.Forms.DialogResult.No Then Exit Sub
            'Dim frm As New frmGenWarpSet
            'frm.ShowDialog(Me)
            'frm.Text = "No. Of Set"
            'frm.txtQty.Text = "Enter Qty"

            'Me.Cursor = Cursors.WaitCursor
            'int_set_qty = frm.p_set_per_lot
            'Me.Cursor = Cursors.Default
            int_set_qty = CInt(txtTotal_Production_lot.Text.Trim)
            Dim dt As DataTable = objdb.GetKgOnBeam(cboSONo.SelectedValue, txtPRODNo.Text, cboDesignNo.SelectedValue, int_set_qty)
            If dt.Rows.Count > 0 Then
                txtQty.Text = dt.Rows(0)("sum_woqty") + ((dt.Rows(0)("sum_woqty") / 100) * CInt(txtknit_loss_perc.Text))
                txtStandardRollKgs.Text = CInt(dt.Rows(0)("kg_on_beam"))

            End If
        End If

    End Sub


    Private Sub btnGenKenddt_Click(sender As Object, e As EventArgs) Handles btnGenKenddt.Click
        Dim clsconfig As New clsConfig
        Dim objdb As New classProduction

        '----------------------------------------
        If dtpStartDate.Checked = False Then
            MessageBox.Show("Please Select Start Date Before Process", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Exit Sub
        End If
        '-------------------------------------------

        If dtpStartDate.Value.ToString("yyyyMMdd") = "19000101" Then
            MessageBox.Show("Start Date = " + dtpStartDate.Value.ToString("dd-MM-yyyy") + " , Please Check", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
            dtpEndDate.Value = DateTime.Parse("1900-01-01")
            Exit Sub

        End If
        If CSng(IIf(txtDailyCapacity.Text.Trim.Length = 0, "0", txtDailyCapacity.Text.Trim)) = 0 Then
            MessageBox.Show("Daily Capacity = " + txtDailyCapacity.Text.ToString + ", Please Check", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        If CSng(IIf(txtQty.Text.Trim.Length = 0, "0", txtQty.Text.Trim)) = 0 Then
            MessageBox.Show("QTY KGS. = " + txtQty.Text.ToString + ", Please Check", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If


        dtpEndDate.Value = objdb.Getkenddt(txtPRODNo.Text, dtpStartDate.Value.ToString("yyyyMMdd"), dtpEndDate.Value.ToString("yyyyMMdd"), txtDailyCapacity.Text, txtSetupDays.Text, txtQty.Text)

    End Sub

    Private Sub optWO_CheckedChanged(sender As Object, e As EventArgs) Handles optWO.CheckedChanged

    End Sub

    Private Sub grdmfg_production_order_lines_CellBeginEdit(sender As Object, e As DataGridViewCellCancelEventArgs) Handles grdmfg_production_order_lines.CellBeginEdit
        Dim objdb As New classMaster
        Dim dgvccSubInven As New DataGridViewComboBoxCell
        Dim dtSubInven As New DataTable
        If grdmfg_production_order_lines.Columns(e.ColumnIndex).Name = "source_subinventory_id" Then
            If Not IsDBNull(grdmfg_production_order_lines.Rows(e.RowIndex).Cells("mtl_warehouse_id").Value) Then
                dtSubInven = objdb.GetCombomtl_subinventory(grdmfg_production_order_lines.Rows(e.RowIndex).Cells("mtl_warehouse_id").Value)
                dgvccSubInven = grdmfg_production_order_lines.Rows(e.RowIndex).Cells("source_subinventory_id")
                Try
                    dgvccSubInven.DataSource = dtSubInven
                    dgvccSubInven.DisplayMember = "subinventory_code"
                    dgvccSubInven.ValueMember = "mtl_subinventory_id"
                Catch ex As Exception
                    dgvccSubInven.Value = DBNull.Value
                End Try
            End If
        End If
    End Sub

    Private Sub grdmfg_production_order_lines_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles grdmfg_production_order_lines.CellContentClick

    End Sub

    Private Sub grdmfg_production_order_lines_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles grdmfg_production_order_lines.CellEndEdit
        Dim objdb As New classMaster
        Dim dgvccSubInven As New DataGridViewComboBoxCell
        Dim dtSubInven As New DataTable
        If grdmfg_production_order_lines.Columns(e.ColumnIndex).Name = "mtl_warehouse_id" Then
            If Not IsDBNull(grdmfg_production_order_lines.Rows(e.RowIndex).Cells("mtl_warehouse_id").Value) Then
                dtSubInven = objdb.GetCombomtl_subinventory(grdmfg_production_order_lines.Rows(e.RowIndex).Cells("mtl_warehouse_id").Value)
                dgvccSubInven = grdmfg_production_order_lines.Rows(e.RowIndex).Cells("source_subinventory_id")
                Try
                    dgvccSubInven.DataSource = dtSubInven
                    dgvccSubInven.DisplayMember = "subinventory_code"
                    dgvccSubInven.ValueMember = "mtl_subinventory_id"
                    'Dim expression As String
                    'expression = "subinventory_name like '%YARN STOCK%'"
                    'Dim foundRows() As DataRow
                    'foundRows = dtSubInven.Select(expression)
                    'dgvccSubInven.Value = foundRows(0)("mtl_subinventory_id")
                Catch ex As Exception
                    'Dim expression As String
                    'expression = "subinventory_name like '%YARN STOCK%'"
                    'Dim foundRows() As DataRow
                    'foundRows = dtSubInven.Select(expression)
                    'dgvccSubInven.Value = foundRows(0)(0)
                    dgvccSubInven.Value = DBNull.Value
                End Try
            End If
        End If
    End Sub

    Private Sub txtPRODNo_TextChanged(sender As Object, e As EventArgs) Handles txtPRODNo.TextChanged

    End Sub

    Private Sub cboKoNo_Click(sender As Object, e As EventArgs) Handles cboKoNo.Click

    End Sub

    Private Sub ToolStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles ToolStrip1.ItemClicked

    End Sub

    Private Sub cboBOM_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboBOM.SelectedIndexChanged

    End Sub

    Private Sub grdmfg_production_order_lines_CellValidated(sender As Object, e As DataGridViewCellEventArgs) Handles grdmfg_production_order_lines.CellValidated

    End Sub

    Private Sub grdmfg_production_order_lines_CellValidating(sender As Object, e As DataGridViewCellValidatingEventArgs) Handles grdmfg_production_order_lines.CellValidating

    End Sub

    Private Sub grdmfg_production_order_lines_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs) Handles grdmfg_production_order_lines.CellValueChanged

    End Sub

    Private Sub grdmfg_production_order_lines_ColumnDefaultCellStyleChanged(sender As Object, e As DataGridViewColumnEventArgs) Handles grdmfg_production_order_lines.ColumnDefaultCellStyleChanged

    End Sub

    Private Sub grdmfg_production_order_lines_CurrentCellDirtyStateChanged(sender As Object, e As EventArgs) Handles grdmfg_production_order_lines.CurrentCellDirtyStateChanged

        'If grdmfg_production_order_lines.IsCurrentCellDirty Then

        '    grdmfg_production_order_lines.CommitEdit(DataGridViewDataErrorContexts.Commit)
        'End If

    End Sub

    Private Sub grdmfg_production_order_lines_LostFocus(sender As Object, e As EventArgs) Handles grdmfg_production_order_lines.LostFocus

    End Sub

    Private Sub cboDesignNo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboDesignNo.SelectedIndexChanged

    End Sub

    Private Sub cboBOM_SelectedValueChanged(sender As Object, e As EventArgs) Handles cboBOM.SelectedValueChanged
        'Call GenProductionOrderLine(StrKono:=(New clsConfig).IsNull(txtPRODNo.Text.Trim, ""), _
        '                    StrDesignNo:=(New clsConfig).IsNull(cboDesignNo.SelectedValue, ""), _
        '                    StrBOM:=(New clsConfig).IsNull(cboBOM.SelectedValue, ""),
        '                  SingleQty:=Val(txtQty.Text.Trim))
    End Sub

    Private Sub txtQty_KeyDown(sender As Object, e As KeyEventArgs) Handles txtQty.KeyDown
        If e.KeyCode = Keys.Enter Then
            Call GenProductionOrderLine(StrKono:=(New clsConfig).IsNull(txtPRODNo.Text.Trim, ""), _
                                StrDesignNo:=(New clsConfig).IsNull(cboDesignNo.SelectedValue, ""), _
                                StrBOM:=(New clsConfig).IsNull(cboBOM.SelectedValue, ""),
                              SingleQty:=Val(txtQty.Text.Trim))
        End If
    End Sub

    Private Sub txtQty_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtQty.KeyPress
        'If Asc(e.KeyChar) <> 8 Then
        '    If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Or e.KeyChar = "13" Then
        '        e.Handled = True
        '    End If
        'End If
    End Sub

    Private Sub txtQty_LostFocus(sender As Object, e As EventArgs) Handles txtQty.LostFocus
        'Call GenProductionLots(StrDesignNo:=(New clsConfig).IsNull(cboDesignNo.SelectedValue,"") , _
        '                       StrBOM:=(New clsConfig).IsNull(cboBOM.SelectedValue,"") ,
        '                      SingleQty:=Val(txtQty.Text.Trim)))
        'Call cboBOM_DropDownClosed(sender:=sender, e:=e)
    End Sub

    Private Sub txtQty_TextChanged(sender As Object, e As EventArgs) Handles txtQty.TextChanged
        Call GenProductionOrderLine(StrKono:=(New clsConfig).IsNull(txtPRODNo.Text.Trim, ""), _
                               StrDesignNo:=(New clsConfig).IsNull(cboDesignNo.SelectedValue, ""), _
                               StrBOM:=(New clsConfig).IsNull(cboBOM.SelectedValue, ""), _
                               SingleQty:=Val(txtQty.Text.Trim))
    End Sub

    Private Sub cboDesignNo_SelectedValueChanged(sender As Object, e As EventArgs) Handles cboDesignNo.SelectedValueChanged
        Call GenProductionOrderLine(StrKono:=(New clsConfig).IsNull(txtPRODNo.Text.Trim, ""), _
                               StrDesignNo:=(New clsConfig).IsNull(cboDesignNo.SelectedValue, ""), _
                               StrBOM:=(New clsConfig).IsNull(cboBOM.SelectedValue, ""), _
                               SingleQty:=Val(txtQty.Text.Trim))
    End Sub
End Class