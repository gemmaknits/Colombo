Public Class frmDesign
    Dim clsConfig As New clsConfig
    Dim clsConn As New classConnection
    Dim clsUser As New classUserInfo

    Dim strDesignNo As String = ""
    Dim blnCancel As Boolean = False
    Dim strImagePath As String = ""
    Dim strImageFilename As String = ""

    Dim _AllowEdit As Boolean = True
    Dim _AllowPrint As Boolean = True
    Dim _AllowNew As Boolean = True

    Public Property UserInfo() As classUserInfo
        Get
            UserInfo = clsUser
        End Get
        Set(ByVal NewValue As classUserInfo)
            clsUser = NewValue
        End Set
    End Property

    Public Property AllowEdit()
        Get
            Return _AllowEdit
        End Get
        Set(ByVal value)
            _AllowEdit = value
        End Set
    End Property

    Public Property AllowPrint()
        Get
            Return _AllowPrint
        End Get
        Set(ByVal value)
            _AllowPrint = value
        End Set
    End Property

    Public Property AllowNew()
        Get
            Return _AllowNew
        End Get
        Set(ByVal value)
            _AllowNew = value
        End Set
    End Property

    Private Sub SetControlValue(ByVal Obj As Control)
        If TypeOf Obj Is TextBox Then
            Obj.Text = Obj.Tag
        End If
        If TypeOf Obj Is DateTimePicker Then
            Dim dtp As DateTimePicker = Obj
            dtp.Value = Now
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

    Private Sub SetErrorProvider()
        ErrorProvider1.Clear()
    End Sub

    Private Sub InitControl()
        Dim obj As Control
        For Each obj In Me.Controls
            Call SetControlValue(obj)
        Next

        Call SetErrorProvider()

        Call EnabledControl(True)
        strDesignNo = ""
        strImagePath = ""
        strImageFilename = ""
        Call LoadData("")
        txtDesignNo.Focus()
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

    Private Sub GenCombo()
        Dim objDB As New classMaster

        Me.cboDesignGroup.DataSource = objDB.GetDesignGroup()
        Me.cboDesignGroup.DisplayMember = "itgroupdesc"
        Me.cboDesignGroup.ValueMember = "itgroupcd"
        Me.cboDesignGroup.SelectedIndex = 0

        Me.cboDesignSubGroup.DataSource = objDB.GetDesignSubGroup()
        Me.cboDesignSubGroup.DisplayMember = "itsubdesc"
        Me.cboDesignSubGroup.ValueMember = "itsubcd"
        Me.cboDesignSubGroup.SelectedIndex = 0

        Me.cboDesignType.DataSource = objDB.GetDesignType()
        Me.cboDesignType.DisplayMember = "ittypedesc"
        Me.cboDesignType.ValueMember = "ittypecd"
        Me.cboDesignType.SelectedIndex = 0

        Me.cboFinishing.DataSource = objDB.GetFinishingGroup()
        Me.cboFinishing.DisplayMember = "fin_desc2"
        Me.cboFinishing.ValueMember = "fin_id"
        Me.cboFinishing.SelectedIndex = 0

        Me.cboCompositionGroup.DataSource = objDB.GetCompositionGroup()
        Me.cboCompositionGroup.DisplayMember = "compo_desc"
        Me.cboCompositionGroup.ValueMember = "id"
        Me.cboCompositionGroup.SelectedIndex = 0

        Me.cbomtl_inventory_types.DataSource = objDB.GetCombomtl_inventory_types()
        Me.cbomtl_inventory_types.DisplayMember = "inventory_type_code"
        Me.cbomtl_inventory_types.ValueMember = "mtl_inventory_types_id"
        Me.cbomtl_inventory_types.SelectedIndex = 0
        'Me.ComboItemsGroup1.populateData((New classConnection).getSQLConnection, "", "FABRIC")
        'Me.ComboItemsType1.populateData((New classConnection).getSQLConnection, "", "FABRIC")
        'Me.ComboItemsSub1.populateData((New classConnection).getSQLConnection, "", "FABRIC")
    End Sub

    Private Sub GenCombodesign_no()
        Dim objDB As New classMaster
        Me.cboDesignNo.ComboBox.DataSource = objDB.GetDesign()
        Me.cboDesignNo.ComboBox.DisplayMember = "design_no"
        Me.cboDesignNo.ComboBox.ValueMember = "design_no"
        Me.cboDesignNo.ComboBox.SelectedIndex = 0

        Me.cboParentDesign.DataSource = objDB.GetDesign()
        Me.cboParentDesign.DisplayMember = "design_no"
        Me.cboParentDesign.ValueMember = "design_no"
        Me.cboParentDesign.SelectedIndex = 0
    End Sub

    Private Sub BindData(ByVal dt As DataTable)
        strDesignNo = dt.Rows(0)("design_no").ToString.Trim
        txtDesignNo.Text = dt.Rows(0)("design_no").ToString.Trim
        txtCustDesignNo.Text = dt.Rows(0)("cust_design_no").ToString.Trim
        txtSuppDesignNo.Text = dt.Rows(0)("supdes_no").ToString.Trim
        cboDesignGroup.SelectedValue = dt.Rows(0)("itgroupcd").ToString.Trim
        cboDesignSubGroup.SelectedValue = dt.Rows(0)("itsubcd").ToString.Trim
        cboDesignType.SelectedValue = dt.Rows(0)("ittypecd").ToString.Trim
        txtRptWthD.Text = dt.Rows(0)("rptwth_d").ToString.Trim
        txtRptLenD.Text = dt.Rows(0)("rptlen_d").ToString.Trim
        txtRptWthS.Text = dt.Rows(0)("rptwth_s").ToString.Trim
        txtRptLenS.Text = dt.Rows(0)("rptlen_s").ToString.Trim
        txtDescription.Text = dt.Rows(0)("desdesc").ToString.Trim
        txtRemark.Text = dt.Rows(0)("rem").ToString.Trim
        txtComposition.Text = dt.Rows(0)("compo").ToString.Trim
        txtAllover.Text = dt.Rows(0)("ab").ToString.Trim
        chkElastic.Checked = CBool(dt.Rows(0)("elastic"))
        txtRefDesNo.Text = dt.Rows(0)("refdesno").ToString.Trim
        txtImagePath.Text = dt.Rows(0)("imagepath").ToString.Trim & dt.Rows(0)("imagefilename").ToString.Trim
        strImagePath = dt.Rows(0)("imagepath").ToString.Trim
        strImageFilename = dt.Rows(0)("imagefilename").ToString.Trim
        txtFinPriceMts.Text = dt.Rows(0)("fin_price_mts").ToString.Trim
        cboFinishing.SelectedValue = dt.Rows(0)("fin_id")
        chkInternal.Checked = CBool(dt.Rows(0)("internal"))
        cboParentDesign.SelectedValue = dt.Rows(0)("parent_design").ToString.Trim
        cboCompositionGroup.SelectedValue = Val(dt.Rows(0)("composition_group_id"))

        txtdesign_gauge.Text = dt.Rows(0)("design_gauge").ToString.Trim
        txtmain_yarn_count.Text = dt.Rows(0)("main_yarn_count").ToString.Trim
        txtmain_yarn_count_code.Text = dt.Rows(0)("main_yarn_count_code").ToString.Trim
        txtdesign_family.Text = dt.Rows(0)("design_family").ToString.Trim
        cbomtl_inventory_types.SelectedValue = dt.Rows(0)("mtl_inventory_types_id")

        cboDesignNo.Text = dt.Rows(0)("design_no").ToString.Trim
    End Sub

    Private Sub BindGrid(ByVal dt As DataTable)
        grdDesign.AutoGenerateColumns = False
        grdDesign.DataSource = dt
    End Sub

    Private Function IsDataChange() As Boolean
        Dim clsMaster As New classMaster
        Dim dt As DataTable = clsMaster.GetDesign2(strDesignNo)
        Dim result As Boolean = False
        Dim i As Integer = 0
        Dim j As Integer = 0

        If strDesignNo.Trim.Length = 0 Then
            If txtCustDesignNo.Text <> "" Then result = True
            If clsConfig.IsNull(cboDesignGroup.SelectedValue, "") <> "" Then result = True
            If clsConfig.IsNull(cboDesignSubGroup.SelectedValue, "") <> "" Then result = True
            If clsConfig.IsNull(cboDesignType.SelectedValue, "") <> "" Then result = True
            If txtRptWthD.Text <> "" Then result = True
            If txtRptLenD.Text <> "" Then result = True
            If txtRptWthS.Text <> "" Then result = True
            If txtRptLenS.Text <> "" Then result = True
            If txtDescription.Text <> "" Then result = True
            If txtRemark.Text <> "" Then result = True
            If txtComposition.Text <> "" Then result = True
            If txtAllover.Text <> "" Then result = True
            If chkElastic.Checked <> False Then result = True
        ElseIf dt.Rows.Count > 0 Then
            If txtCustDesignNo.Text <> dt.Rows(0)("cust_design_no").ToString.Trim Then result = True
            If clsConfig.IsNull(cboDesignGroup.SelectedValue, "") <> dt.Rows(0)("itgroupcd").ToString.Trim Then result = True
            If clsConfig.IsNull(cboDesignSubGroup.SelectedValue, "") <> dt.Rows(0)("itsubcd").ToString.Trim Then result = True
            If clsConfig.IsNull(cboDesignType.SelectedValue, "") <> dt.Rows(0)("ittypecd").ToString.Trim Then result = True
            If txtRptWthD.Text <> dt.Rows(0)("rptwth_d").ToString.Trim Then result = True
            If txtRptLenD.Text <> dt.Rows(0)("rptlen_d").ToString.Trim Then result = True
            If txtRptWthS.Text <> dt.Rows(0)("rptwth_s").ToString.Trim Then result = True
            If txtRptLenS.Text <> dt.Rows(0)("rptlen_s").ToString.Trim Then result = True
            If txtDescription.Text <> dt.Rows(0)("desdesc").ToString.Trim Then result = True
            If txtRemark.Text <> dt.Rows(0)("rem").ToString.Trim Then result = True
            If txtComposition.Text <> dt.Rows(0)("compo").ToString.Trim Then result = True
            If txtAllover.Text <> dt.Rows(0)("ab").ToString.Trim Then result = True
            If chkElastic.Checked <> CBool(dt.Rows(0)("elastic")) Then result = True

            Dim delRecs As New DataView(dt, "", "", DataViewRowState.Deleted)
            If delRecs.Count > 0 Then result = True

            Dim updRecs As New DataView(dt, "", "", DataViewRowState.ModifiedCurrent)
            If updRecs.Count > 0 Then result = True

            Dim addRecs As New DataView(dt, "", "", DataViewRowState.Added)
            If addRecs.Count > 0 Then result = True
        End If

        IsDataChange = result
    End Function

    Private Function CheckData() As Boolean
        If IIf(strDesignNo.Trim.Length = 0, txtDesignNo.Text.Trim.ToUpper, strDesignNo).ToString.Trim.Length = 0 Then
            MessageBox.Show("Please fill Design No. !!", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            CheckData = False
            Exit Function
        End If

        'Auto Gen Design Family
        If txtdesign_family.Text.Trim.Length = 0 Then
            MessageBox.Show("ถ้าคุณไม่ได้ใส่ Design Family ระบบจะ Gen ให้อัตโนมัติ! ", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            'CheckData = False
            'Exit Function
        End If

        If cbomtl_inventory_types.SelectedValue Is Nothing Then
            MessageBox.Show("Please Select Inventory Types !!", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            ErrorProvider1.SetError(Me.cbomtl_inventory_types, "Please Select Inventory Types !!")
            CheckData = False
            Exit Function
        End If

        CheckData = True
    End Function

    Private Sub LoadData(ByVal design_no As String)
        Dim objDB As New classMaster
        Dim dt As New DataTable
        dt = objDB.GetDesign2(design_no)
        Call BindGrid(dt) 'Designs
        If dt.Rows.Count > 0 Then Call BindData(dt) 'DM
    End Sub

    Private Function SaveData() As Boolean
        If AllowEdit Or AllowNew Then
            Dim clsMaster As New classMasterUpdate
            Dim header As New classMasterUpdate.DM
            Dim msgerr As String = ""
            Dim design_no As String = ""
            Dim dt As DataTable = grdDesign.DataSource
            Dim dv_add As New DataView(dt, "", "", DataViewRowState.Added)
            Dim dv_upd As New DataView(dt, "", "", DataViewRowState.ModifiedCurrent)
            Dim dv_del As New DataView(dt, "", "", DataViewRowState.Deleted)
            header.h01_StartDt = ""
            header.h02_Design_no = IIf(strDesignNo.Trim.Length = 0, txtDesignNo.Text.Trim.ToUpper, strDesignNo)
            header.h03_Elastic = chkElastic.Checked
            header.h04_Type = ""
            header.h05_AB = txtAllover.Text.Trim
            header.h06_Bar = ""
            header.h07_Fine = ""
            header.h08_Bwth = 0
            header.h09_Needle = ""
            header.h10_rptwth_d = Val(txtRptWthD.Text)
            header.h11_rptlen_d = Val(txtRptLenD.Text)
            header.h12_rptwth_s = Val(txtRptWthS.Text)
            header.h13_rptlen_s = Val(txtRptLenS.Text)
            header.h14_mtkg = 0
            header.h15_compo = txtComposition.Text.Trim
            header.h16_rem = txtRemark.Text.Trim
            header.h17_supdes_no = txtSuppDesignNo.Text.Trim 'supdes_no on DM
            header.h18_width = 0
            header.h19_cust_design_no = txtCustDesignNo.Text.Trim
            header.h20_desdesc = txtDescription.Text.Trim
            header.h21_refdesno = txtRefDesNo.Text
            header.h22_tstamp = Now
            header.h23_ittypecd = clsConfig.IsNull(cboDesignType.SelectedValue, "").ToString.Trim
            header.h24_itgroupcd = clsConfig.IsNull(cboDesignGroup.SelectedValue, "").ToString.Trim
            header.h25_log_empcd = clsUser.UserID
            header.h26_itsubcd = clsConfig.IsNull(cboDesignSubGroup.SelectedValue, "")
            header.h27_imagepath = txtImagePath.Text.Trim
            header.h28_fin_price_mts = Val(txtFinPriceMts.Text)
            header.h29_fin_id = clsConfig.IsNull(cboFinishing.SelectedValue, 0)
            header.h30_internal = chkInternal.Checked
            header.h31_parent_design = clsConfig.IsNull(cboParentDesign.SelectedValue, "").ToString.Trim
            header.h32_composition_group_id = CInt(clsConfig.IsNull(cboCompositionGroup.SelectedValue, 0).ToString())
            header.h33_itcatcd = Nothing
            header.h34_design_gauge = txtdesign_gauge.Text
            header.h35_main_yarn_count = Val(txtmain_yarn_count.Text)
            header.h36_main_yarn_count_code = txtmain_yarn_count_code.Text
            'header.h37_item_disabled
            'header.h38_dm_remark
            header.h39_design_family = txtdesign_family.Text
            header.h40_mtl_inventory_types_id = cbomtl_inventory_types.SelectedValue

            If clsMaster.DesignSave(header, dt, dv_add, dv_upd, dv_del, msgerr, design_no) Then
                strDesignNo = design_no
                SaveData = True
            Else
                MessageBox.Show(msgerr, "System Message", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
                SaveData = False
            End If
        Else
            MessageBox.Show("Permission denied", "Security message", MessageBoxButtons.OK, MessageBoxIcon.Stop)
        End If
    End Function

    'Private Function GetImage(ByVal strImagePath As String, ByRef dt As DataTable) As Boolean
    '	Try
    '		'here i have define a simple datatable inwhich image will recide 
    '       DataTable dt = new DataTable(); 
    '		'object of data row 
    '       DataRow drow; 
    '		'add the column in table to store the image of Byte array type 
    '       dt.Columns.Add("Image", System.Type.GetType("System.Byte[]")); 
    '       drow = dt.NewRow; 
    '		'define the filestream object to read the image 
    '		Dim fs As System.IO.FileStream
    '		'define te binary reader to read the bytes of image 
    '       BinaryReader br; 
    '		'check the existance of image 
    '       if (File.Exists(AppDomain.CurrentDomain.BaseDirectory + "10157.Jpg")) { 
    '			'open image in file stream 
    '           fs = new FileStream(AppDomain.CurrentDomain.BaseDirectory + "10157.Jpg", FileMode.Open); 
    '       } 
    '       else { 
    '			'if phot does not exist show the nophoto.jpg file 
    '           fs = new FileStream(AppDomain.CurrentDomain.BaseDirectory + "NoPhoto.jpg", FileMode.Open); 
    '       } 
    '			'initialise the binary reader from file streamobject 
    '       br = new BinaryReader(fs); 
    '			'define the byte array of filelength 
    '       byte[] imgbyte = new byte[fs.Length + 1]; 
    '			'read the bytes from the binary reader 
    '       imgbyte = br.ReadBytes(Convert.ToInt32((fs.Length))); 
    '       drow(0) = imgbyte; 
    '			'add the image in bytearray 
    '       dt.Rows.Add(drow); 
    '			'add row into the datatable 
    '       br.Close(); 
    '			'close the binary reader 
    '       fs.Close(); 
    '			'close the file stream 
    '       CrystalReport1 rptobj = new CrystalReport1(); 
    '			'object of crystal report 
    '       rptobj.SetDataSource(dt); 
    '			'set the datasource of crystalreport object 
    '       CrystalReportViewer1.ReportSource = rptobj; 
    '			'set the report source 

    '   catch ex as Exception
    '		'error handling 
    '		Interaction.MsgBox("Missing 10157.jpg or nophoto.jpg in application folder")

    '	End Try
    '	Return bPic
    'End Function

    Private Sub frmDesign_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call GenCombo()
        Call GenCombodesign_no()
        Call InitControl()
        Call hideColumns()
        btnSave.Enabled = AllowEdit
        btnNew.Enabled = AllowNew
        btnPrint.Enabled = AllowPrint
    End Sub

    Private Sub frmDesign_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If IsDataChange() Then Call btnSave_Click(sender, e)
        e.Cancel = blnCancel
    End Sub

    Private Sub btnNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNew.Click
        If IsDataChange() Then Call btnSave_Click(sender, e)
        If Not blnCancel Then Call InitControl()
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        'fix bug user

        If grdDesign.Focus Then txtDesignNo.Focus() 'Fix Bug User
        grdDesign.EndEdit(DataGridViewDataErrorContexts.Commit) 'Fix Bug User
        grdDesign.CurrentCell = grdDesign.Rows(0).Cells(0) 'Fix Bug User

        Call AutoUpdateGrid()

        If grdDesign.Rows.Count = 0 Then
            MessageBox.Show("ยังไม่ได้ใส่ ข้อมูลใน Grid ครับ โปรดเช็คอีกครั้งนึง", "System Message!", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If

        txtDesignNo.Focus()
        blnCancel = False
        Dim result As System.Windows.Forms.DialogResult
        result = MessageBox.Show("Would you like to save ?", "System Message", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button3)
        If result = System.Windows.Forms.DialogResult.Cancel Then blnCancel = True
        If result <> System.Windows.Forms.DialogResult.Yes Then Exit Sub

        If Not CheckData() Then Exit Sub

        Me.Cursor = Cursors.WaitCursor

        If SaveData() Then
            LoadData(strDesignNo)
            Call GenCombodesign_no()
        End If
        Me.Cursor = Cursors.Default
    End Sub

    Private Function AutoUpdateGrid() As Boolean
        Dim dt As DataTable = grdDesign.DataSource
        Dim config As New clsConfig

        If dt.Rows.Count > 0 Then
            For i = 0 To dt.Rows.Count - 1
                If dt.Rows(i).RowState <> DataRowState.Deleted Then
                    dt.Rows(i)("design_no") = txtDesignNo.Text.Trim
                End If
            Next
            Return True
        Else
            Return False
        End If

    End Function


    Private Sub btnPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrint.Click
        Dim frm As New frmReport
        Dim rpt As New CrystalDecisions.CrystalReports.Engine.ReportDocument
        Dim rptFileName As String
        If strDesignNo = "" Then
            rptFileName = "rptMasterDesign.rpt"
            'If clsuser.ReportPath = "" Then clsuser.ReportPath = clsConfig.ReportPath
            If Not clsConfig.CheckReport(clsUser.ReportPath, rptFileName) Then Exit Sub
            Me.Cursor = Cursors.WaitCursor

            rpt.Load(clsUser.ReportPath & rptFileName)
            rpt.PrintOptions.PaperSize = CrystalDecisions.Shared.PaperSize.PaperA4
            rpt.DataSourceConnections.Item(0).SetConnection(clsConn.servername, clsConn.database, False)
            rpt.DataSourceConnections.Item(0).SetLogon(clsConn.Userid, clsConn.Password)
            rpt.VerifyDatabase()
            rpt.SetParameterValue("@design_no", strDesignNo)
        Else
            rptFileName = "rptMasterDesign.rpt"
            'If clsuser.ReportPath = "" Then clsuser.ReportPath = clsConfig.ReportPath
            If Not clsConfig.CheckReport(clsUser.ReportPath, rptFileName) Then Exit Sub
            Me.Cursor = Cursors.WaitCursor

            rpt.Load(clsUser.ReportPath & rptFileName)
            rpt.PrintOptions.PaperSize = CrystalDecisions.Shared.PaperSize.PaperA4
            rpt.DataSourceConnections.Item(0).SetConnection(clsConn.servername, clsConn.database, False)
            rpt.DataSourceConnections.Item(0).SetLogon(clsConn.Userid, clsConn.Password)
            rpt.VerifyDatabase()
            rpt.SetParameterValue("@design_no", strDesignNo)
            'GetImage(rpt.Database.Tables(0))
        End If

        frm.Title = "Design Master"
        frm.CRViewer.ReportSource = rpt
        frm.MdiParent = Me.ParentForm
        frm.Show()
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub btnMinimized_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMinimized.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub cbodesign_no_DropDownClosed(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboDesignNo.DropDownClosed
        Dim design_no As String
        design_no = clsConfig.IsNull(cboDesignNo.ComboBox.SelectedValue, "")
        If design_no.Trim.Length > 0 Then
            Call btnNew_Click(sender, e)
            If Not blnCancel Then LoadData(design_no)
        End If
    End Sub

    Private Sub txtdesign_no_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtDesignNo.KeyPress
        Dim design_no As String = ""
        If Asc(e.KeyChar) = 13 Then
            If Validate_Design_no() Then
                design_no = txtDesignNo.Text.Trim.ToUpper
                Call btnNew_Click(sender, e)
                If Not blnCancel Then LoadData(design_no)

            End If
        End If
    End Sub

    Private Function Validate_Design_no() As Boolean
        Dim objDB As New classProduction
        Dim dt As DataTable = objDB.ValidateDesignNo(txtDesignNo.Text.Trim, clsUser.UserID)

        If dt.Rows.Count = 0 Then
            Return False
        ElseIf dt.Rows.Count > 0 Then
            Return True
        End If
    End Function

    Private Sub grdDesign_CellFormatting(sender As Object, e As System.Windows.Forms.DataGridViewCellFormattingEventArgs) Handles grdDesign.CellFormatting


    End Sub

    Private Sub grdDesign_CellValueChanged(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles grdDesign.CellValueChanged
        Dim dt As DataTable = grdDesign.DataSource
        If Not grdDesign.DataSource Is Nothing Then
            If e.RowIndex >= 0 And e.RowIndex < dt.Rows.Count Then
                'If grdDesign.Columns(e.ColumnIndex).Name = "Gwth" Then dt.Rows(e.RowIndex)("Gwth_n") = Math.Round(Val(grdDesign.Rows(e.RowIndex).Cells("Gwth").Value / 2.5), 2)
                If grdDesign.Columns(e.ColumnIndex).Name = "mtkg_g" Then dt.Rows(e.RowIndex)("ydkg_g") = Math.Round(Val(grdDesign.Rows(e.RowIndex).Cells("mtkg_g").Value / 0.9144), 2)
                If grdDesign.Columns(e.ColumnIndex).Name = "mtkg" Then dt.Rows(e.RowIndex)("ydkg") = Math.Round(Val(grdDesign.Rows(e.RowIndex).Cells("mtkg").Value / 0.9144), 2)
                'If grdDesign.Columns(e.ColumnIndex).Name = "Gwth_n" Then dt.Rows(e.RowIndex)("Gwth") = Math.Round(Val(grdDesign.Rows(e.RowIndex).Cells("Gwth_n").Value * 2.5), 2)
                If grdDesign.Columns(e.ColumnIndex).Name = "ydkg_g" Then dt.Rows(e.RowIndex)("mtkg_g") = Math.Round(Val(grdDesign.Rows(e.RowIndex).Cells("ydkg_g").Value * 0.9144), 2)
                If grdDesign.Columns(e.ColumnIndex).Name = "ydkg" Then dt.Rows(e.RowIndex)("mtkg") = Math.Round(Val(grdDesign.Rows(e.RowIndex).Cells("ydkg").Value * 0.9144), 2)
            End If
        End If
    End Sub

    Private Sub hideColumns()
        Dim classCn As New classConnection
        If UCase(classCn.database) = "GEMMASOFT" Then
            Nob.Visible = False
            'bar.Visible = False
            'actual_bar.Visible = False

            'supdes_no.Visible = False
            'clip.Visible = False
            'sketch.Visible = False
            'fine.Visible = False
            'needle.Visible = False
        End If
    End Sub

    Private Sub btnViewImage_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnViewImage.Click
        If Len(strImagePath & strImageFilename) > 0 Then
            Dim frm As New frmDesignImage
            frm.StrImageFile = strImageFilename
            frm.StrImagePath = strImagePath
            frm.ShowDialog()
        End If
    End Sub

    Private Sub btnImagePath_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImagePath.Click
        If txtDesignNo.Text.Trim.Length = 0 Then Exit Sub

        Dim dlg As New OpenFileDialog

        Dim split As String() = (txtDesignNo.Text + "/").Split("/")
        Dim strFileName As String = split(0) & ".jpg"
        Dim strFilePath As String = "\\172.16.3.4\Setup\Image\Designs\"
        Dim strOldFilePath As String = "C:\"



        If strImagePath.Length = 0 Then
            'Dim split As String() = (txtDesignNo.Text + "/").Split("/")
            'Dim strFileName As String = split(0) & ".jpg"
            'Dim strFilePath As String = "\\172.16.3.4\Setup\Image\Designs"

            If Not FileIO.FileSystem.DirectoryExists(strFilePath) Then
                strImagePath = ""
            Else
                strImagePath = strFilePath
                If FileIO.FileSystem.FileExists(strFilePath & strFileName) Then
                    strImageFilename = strFileName
                End If
            End If

        End If

        dlg.InitialDirectory = strOldFilePath 'strImagePath
        dlg.Filter = "Images (*.BMP;*.JPG;*.GIF)|*.BMP;*.JPG;*.GIF|All files (*.*)|*.*"
        dlg.Multiselect = False
        If dlg.ShowDialog() = System.Windows.Forms.DialogResult.OK Then

            'Dim test As String = strImageFilename.Substring(strImageFilename.Length - 4, 4)
            txtImagePath.Text = dlg.FileName
        End If

        If dlg.FileName <> "" Then 'Add By Neung
            My.Computer.FileSystem.CopyFile(
            dlg.FileName,
           strFilePath & strFileName,
           Microsoft.VisualBasic.FileIO.UIOption.AllDialogs,
            Microsoft.VisualBasic.FileIO.UICancelOption.ThrowException)
        End If

        txtImagePath.Text = strImagePath & strFileName
    End Sub

    Private Sub txtDesignNo_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtDesignNo.TextChanged

        If grdDesign.Rows.Count > 0 Then
            grdDesign.Rows(0).Cells("Design_no").Value = txtDesignNo.Text
        Else
            AddGrid()
        End If

    End Sub

    Private Sub AddGrid()
        Dim newRow As DataRow
        Dim dtD As DataTable = grdDesign.DataSource
        newRow = dtD.NewRow

        newRow.Item("design_no") = txtDesignNo.Text

        'Dim row As String() = New String() {txtDesignNo.Text}
        dtD.Rows.Add(newRow)

        'row = New String() {"2", "Product 2", "2000"}
        'DataGridView1.Rows.Add(row)
        'row = New String() {"3", "Product 3", "3000"}
        'DataGridView1.Rows.Add(row)
        'row = New String() {"4", "Product 4", "4000"}
        'DataGridView1.Rows.Add(row)
    End Sub

    Private Sub cboDesignNo_Click(sender As System.Object, e As System.EventArgs) Handles cboDesignNo.Click

    End Sub
End Class