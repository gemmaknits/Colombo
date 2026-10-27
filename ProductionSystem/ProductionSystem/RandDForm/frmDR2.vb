'Imports WMPLib
'Imports AxWMPLib
Imports ProductionSystem.Controls
Imports System.Data.SqlClient
Imports System.Net.Mail
Imports System.Text

Public Class frmDR2

    Dim clsConn As New classConnection
    Dim config As New clsConfig
       Dim clsuser As new classUserInfo
    Dim dtmedia As DataTable
    Dim dsmedia As DataSet

    Private dtSoitm As New DataTable
    Private drvSoitm As DataRowView
    Private bsSoitm As New BindingSource

    Dim blnCancel As Boolean
    Dim DesignNo As String


    Dim id As Long

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
            'If Obj.Tag = "str" Then Obj.Text = ""
            'If Obj.Tag = "int" Then Obj.Text = "0.00"
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
        optKI.Checked = True
        txtDRNo.Focus()
        id = 0
    End Sub

    Private Sub GenCombo()
        Dim clsmaster As New classMaster
        Dim objDB As New classRandD
        Dim dtNewPDR As New DataTable
        Dim dtPdrNo As New DataTable
        dtNewPDR = objDB.comboPDRNEW(clsUser.UserID)

        Me.cboDRAppRej.DataSource = clsmaster.ComboLookUp("PDR_APP_REJ")
        Me.cboDRAppRej.DisplayMember = "lookup_value".Trim
        Me.cboDRAppRej.ValueMember = "lookup_value_id"
        Me.cboDRAppRej.SelectedIndex = -1
        Dim dtDRAPPREJ As DataTable = Me.cboDRAppRej.DataSource
        Dim dr As DataRow
        Dim StringCollection As New AutoCompleteStringCollection
        dr = dtDRAPPREJ.NewRow
        dtDRAPPREJ.Rows.Add(dr)
        Dim dataView As New DataView(dtDRAPPREJ)
        dataView.Sort = " lookup_value ASC"
        Me.cboDRAppRej.DataSource = dataView.ToTable()

        Me.cboPDR.DataSource = objDB.comboPDR(clsUser.UserID)
        ' Me.cboPDR.DataSource = dtNewPDR
        Me.cboPDR.DisplayMember = "pdr_no"
        Me.cboPDR.ValueMember = "id"
        Me.cboPDR.SelectedIndex = -1

        dtPdrNo = objDB.comboPDRNEW(clsUser.UserID)
        Me.cboPDR_NEW_develop_req.DataSource = dtPdrNo
        ' Me.cboPDR_NEW_develop_req.DataSource = dtNewPDR.Copy
        Me.cboPDR_NEW_develop_req.DisplayMember = "pdr_no"
        Me.cboPDR_NEW_develop_req.ValueMember = "pdr_new_develop_req_id"
        Me.cboPDR_NEW_develop_req.SelectedIndex = -1

        cboPDR_NEW_develop_req.AutoCompleteMode = AutoCompleteMode.SuggestAppend
        cboPDR_NEW_develop_req.AutoCompleteSource = AutoCompleteSource.CustomSource
        For Each r As DataRow In dtPdrNo.Rows
            StringCollection.Add(r("pdr_no"))
        Next
        cboPDR_NEW_develop_req.AutoCompleteCustomSource = StringCollection

        Me.cboMachine.DataSource = objDB.comboMachineGauge(clsUser.UserID)
        Me.cboMachine.DisplayMember = "gauge"
        Me.cboMachine.ValueMember = "gauge"
        Me.cboMachine.SelectedIndex = 0

        Dim dt As DataTable = objDB.comboYarnCode(clsUser.UserID)
        Dim ds As New DataSet
        ds.Tables.Add(dt)

        Me.cboYarn1Code.DataSource = dt
        Me.cboYarn1Code.DisplayMember = "itcd2"
        Me.cboYarn1Code.ValueMember = "itcd"
        Me.cboYarn1Code.SelectedIndex = 0
        cboYarn1Code.AutoCompleteMode = AutoCompleteMode.SuggestAppend 'Sitthana 21/05/2018
        cboYarn1Code.AutoCompleteSource = AutoCompleteSource.ListItems 'Sitthana 21/05/2018


        Me.cboYarn2Code.DataSource = ds.Tables(0).Copy()
        Me.cboYarn2Code.DisplayMember = "itcd2"
        Me.cboYarn2Code.ValueMember = "itcd"
        Me.cboYarn2Code.SelectedIndex = 0
        cboYarn2Code.AutoCompleteMode = AutoCompleteMode.SuggestAppend 'Sitthana 21/05/2018
        cboYarn2Code.AutoCompleteSource = AutoCompleteSource.ListItems 'Sitthana 21/05/2018

        Me.cboYarn3Code.DataSource = ds.Tables(0).Copy()
        Me.cboYarn3Code.DisplayMember = "itcd2"
        Me.cboYarn3Code.ValueMember = "itcd"
        Me.cboYarn3Code.SelectedIndex = 0
        cboYarn3Code.AutoCompleteMode = AutoCompleteMode.SuggestAppend 'Sitthana 21/05/2018
        cboYarn3Code.AutoCompleteSource = AutoCompleteSource.ListItems 'Sitthana 21/05/2018

        Me.cboYarn4Code.DataSource = ds.Tables(0).Copy()
        Me.cboYarn4Code.DisplayMember = "itcd2"
        Me.cboYarn4Code.ValueMember = "itcd"
        Me.cboYarn4Code.SelectedIndex = 0
        cboYarn4Code.AutoCompleteMode = AutoCompleteMode.SuggestAppend 'Sitthana 21/05/2018
        cboYarn4Code.AutoCompleteSource = AutoCompleteSource.ListItems 'Sitthana 21/05/2018

        Me.cboYarn5Code.DataSource = ds.Tables(0).Copy()
        Me.cboYarn5Code.DisplayMember = "itcd2"
        Me.cboYarn5Code.ValueMember = "itcd"
        Me.cboYarn5Code.SelectedIndex = 0
        cboYarn5Code.AutoCompleteMode = AutoCompleteMode.SuggestAppend 'Sitthana 21/05/2018
        cboYarn5Code.AutoCompleteSource = AutoCompleteSource.ListItems 'Sitthana 21/05/2018

        Me.cboYarn6Code.DataSource = ds.Tables(0).Copy()
        Me.cboYarn6Code.DisplayMember = "itcd2"
        Me.cboYarn6Code.ValueMember = "itcd"
        Me.cboYarn6Code.SelectedIndex = 0
        cboYarn6Code.AutoCompleteMode = AutoCompleteMode.SuggestAppend 'Sitthana 21/05/2018
        cboYarn6Code.AutoCompleteSource = AutoCompleteSource.ListItems 'Sitthana 21/05/2018

        Me.cboYarn7Code.DataSource = ds.Tables(0).Copy()
        Me.cboYarn7Code.DisplayMember = "itcd2"
        Me.cboYarn7Code.ValueMember = "itcd"
        Me.cboYarn7Code.SelectedIndex = 0
        cboYarn7Code.AutoCompleteMode = AutoCompleteMode.SuggestAppend 'Sitthana 21/05/2018
        cboYarn7Code.AutoCompleteSource = AutoCompleteSource.ListItems 'Sitthana 21/05/2018
    End Sub

    Private Sub GenComboDocNo()
        Dim objDB As New classRandD

        Me.cboDocNo.ComboBox.DataSource = objDB.comboDR(clsUser.UserID)
        Me.cboDocNo.ComboBox.DisplayMember = "dr_no"
        Me.cboDocNo.ComboBox.ValueMember = "id"
        Me.cboDocNo.ComboBox.SelectedIndex = -1
    End Sub

    Private Function comboBomCode(designNo As String) As DataTable
        Dim conn As New SqlConnection((New classConnection).connection)
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "p_development_requirement_combo_bom"
        comm.Parameters.AddWithValue("@design_no", designNo)
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        Return dt
    End Function
    Private Sub gencboMultiBomCode(ByVal StrdesignNo As String)
        'Create By : Sitthana 20/01/2018  wait ask k.suresh to move to class
        Dim dt As DataTable

        'Dim DesignNo As String = txtDesignNo.Text.Trim

        dt = comboBomCode(StrdesignNo)
        Dim dv As New DataView
        dv = dt.AsDataView
        Me.cboMultiBomCode.DataSource = dv
        Me.cboMultiBomCode.MultiColumn = True
        Me.cboMultiBomCode.ValueMember = "bom_header_id" 'id_yarnchange
        Me.cboMultiBomCode.DisplayMember = "bom_code"
        Me.cboMultiBomCode.SelectedIndex = -1
    End Sub

    Private Sub BindData(ByVal dt As DataTable)
        Dim clsconfig As New clsConfig

        id = Val(dt.Rows(0)("id"))

        txtDRNo.Text = dt.Rows(0)("dr_no").ToString()
        Call getSoitm(dt.Rows(0)("dr_no").ToString())

        dtpDRDate.Value = CDate(dt.Rows(0)("dr_date"))

        'If clsconfig.IsNull(dt.Rows(0)("pdr_new_develop_req_id"), 0) = 0 Then
        '    cboPDR.SelectedValue = dt.Rows(0)("pdr_id").ToString() '
        '    cboPDR_NEW_develop_req.SelectedValue = DBNull.Value
        'Else
        '    cboPDR_NEW_develop_req.SelectedValue = dt.Rows(0)("pdr_new_develop_req_id")
        '    cboPDR.SelectedValue = DBNull.Value
        'End If

        cboPDR.SelectedValue = dt.Rows(0)("pdr_id").ToString()
        cboPDR_NEW_develop_req.SelectedValue = dt.Rows(0)("pdr_new_develop_req_id") 'Add New

        txtDFNo.Text = dt.Rows(0)("dfno").ToString()
        txtNewDesignNo.Text = dt.Rows(0)("new_design_no").ToString()

        If dt.Rows(0)("knitting_type").ToString().Equals("KI") Then optKI.Checked = True
        If dt.Rows(0)("knitting_type").ToString().Equals("KO") Then optKO.Checked = True
        If dt.Rows(0)("knitting_type").ToString().Equals("KP") Then optKP.Checked = True

        cboYarn1Code.SelectedValue = dt.Rows(0)("itcd1").ToString()
        txtYarn1Percent.Text = dt.Rows(0)("ynperc1").ToString()
        txtYarn1Spools.Text = dt.Rows(0)("spools1").ToString()
        txtYarn1Remark.Text = dt.Rows(0)("itcd1_remark").ToString()

        cboYarn2Code.SelectedValue = dt.Rows(0)("itcd2").ToString()
        txtYarn2Percent.Text = dt.Rows(0)("ynperc2").ToString()
        txtYarn2Spools.Text = dt.Rows(0)("spools2").ToString()
        txtYarn2Remark.Text = dt.Rows(0)("itcd2_remark").ToString()

        cboYarn3Code.SelectedValue = dt.Rows(0)("itcd3").ToString()
        txtYarn3Percent.Text = dt.Rows(0)("ynperc3").ToString()
        txtYarn3Spools.Text = dt.Rows(0)("spools3").ToString()
        txtYarn3Remark.Text = dt.Rows(0)("itcd3_remark").ToString()

        cboYarn4Code.SelectedValue = dt.Rows(0)("itcd4").ToString()
        txtYarn4Percent.Text = dt.Rows(0)("ynperc4").ToString()
        txtYarn4Spools.Text = dt.Rows(0)("spools4").ToString()
        txtYarn4Remark.Text = dt.Rows(0)("itcd4_remark").ToString()

        cboYarn5Code.SelectedValue = dt.Rows(0)("itcd5").ToString()
        txtYarn5Percent.Text = dt.Rows(0)("ynperc5").ToString()
        txtYarn5Spools.Text = dt.Rows(0)("spools5").ToString()
        txtYarn5Remark.Text = dt.Rows(0)("itcd5_remark").ToString()

        cboYarn6Code.SelectedValue = dt.Rows(0)("itcd6").ToString()
        txtYarn6Percent.Text = dt.Rows(0)("ynperc6").ToString()
        txtYarn6Spools.Text = dt.Rows(0)("spools6").ToString()
        txtYarn6Remark.Text = dt.Rows(0)("itcd6_remark").ToString()

        cboYarn7Code.SelectedValue = dt.Rows(0)("itcd7").ToString
        txtYarn7Percent.Text = (New clsConfig).IsNull(dt.Rows(0)("ynperc7"), "0.00").ToString()
        txtYarn7Spools.Text = (New clsConfig).IsNull(dt.Rows(0)("spools7"), "0").ToString()
        txtYarn7Remark.Text = dt.Rows(0)("itcd7_remark").ToString()

        txtRolls.Text = dt.Rows(0)("rolls").ToString()
        txtKgsPerRoll.Text = dt.Rows(0)("kgs_per_roll").ToString()
        txtRepeatPerRoll.Text = dt.Rows(0)("repeat_per_roll").ToString() 'Sitthana 16/11/2018
        cboMachine.SelectedValue = dt.Rows(0)("mcno").ToString()
        txtKnittingRemark.Text = dt.Rows(0)("knitting_remark").ToString()

        txtWeight.Text = dt.Rows(0)("weight_sqm").ToString()
        txtWeightMax.Text = dt.Rows(0)("weight_sqm_max").ToString() 'Sitthana 19/05/2018
        txtWidth.Text = dt.Rows(0)("width").ToString() 'Sitthana 19/05/2018
        txtWidthMax.Text = dt.Rows(0)("width_Max").ToString()
        txtCourse.Text = dt.Rows(0)("course").ToString()
        txtWale.Text = dt.Rows(0)("wale").ToString()
        txtDyeingRemark.Text = dt.Rows(0)("dyeing_remark").ToString()

        txtImage.Text = dt.Rows(0)("imagefile").ToString()

        dtpsubmit_date.Value = CDate(dt.Rows(0)("submit_date"))
        dtpqa_report_date.Value = CDate(dt.Rows(0)("qa_report_date"))
        dtpspec_master_date.Value = CDate(dt.Rows(0)("spec_master_date"))
        'If AxWindowsMediaPlayer1.playState = WMPPlayState.wmppsPlaying Then

        'End If
        cboDRAppRej.SelectedValue = dt.Rows(0)("dr_app_rej_id")
        txtDR_APP_REJ_COMMENT.Text = dt.Rows(0)("dr_app_rej_comment").ToString
        ChkdrClosed.Checked = IIf(dt.Rows(0)("dr_closed") = "Y", True, False)
        Chkpdr_closed.Checked = IIf(dt.Rows(0)("pdr_closed") = "Y", True, False)

        chkAddToCollection.Checked = IIf(dt.Rows(0)("add_to_collection") = "1", True, False) 'Sitthana 25/05/2018
    End Sub


    Private Sub LoadData(ByVal new_id As Long)
        Dim objDB As New classRandD
        Dim dt As DataTable = objDB.DRNEWSelect(new_id, clsUser.UserID)
        If dt.Rows.Count > 0 Then
            Call BindData(dt)
            getCboBomCode()
            cboMultiBomCode.SelectedValue = dt.Rows(0)("bomno") 'Sitthana 21/05/2018
            CalTotalShoes() 'Sitthana 04/06/2018
        End If
    End Sub

    Private Function SaveData() As Boolean
        Dim obj As New DR
        Dim objDB As New classRandD
        Dim errmsg As String = ""
        Dim clsConfig As New clsConfig

        dgvSoitm.EndEdit()
        bsSoitm.EndEdit()

        obj.id = id
        obj.dr_no = txtDRNo.Text.Trim
        obj.dr_date = dtpDRDate.Value.ToString("yyyyMMdd")

        obj.pdr_id = cboPDR.SelectedValue
        obj.pdr_new_develop_req_id = cboPDR_NEW_develop_req.SelectedValue

        obj.dfno = txtDFNo.Text
        obj.new_design_no = txtNewDesignNo.Text

        obj.knitting_type = IIf(optKO.Checked, "KO", IIf(optKP.Checked, "KP", "KI"))

        obj.itcd1 = cboYarn1Code.SelectedValue
        obj.ynperc1 = Val(txtYarn1Percent.Text)
        obj.spools1 = Val(txtYarn1Spools.Text)
        obj.itcd1_remark = txtYarn1Remark.Text

        obj.itcd2 = cboYarn2Code.SelectedValue
        obj.ynperc2 = Val(txtYarn2Percent.Text)
        obj.spools2 = Val(txtYarn2Spools.Text)
        obj.itcd2_remark = txtYarn2Remark.Text

        obj.itcd3 = cboYarn3Code.SelectedValue
        obj.ynperc3 = Val(txtYarn3Percent.Text)
        obj.spools3 = Val(txtYarn3Spools.Text)
        obj.itcd3_remark = txtYarn3Remark.Text

        obj.itcd4 = cboYarn4Code.SelectedValue
        obj.ynperc4 = Val(txtYarn4Percent.Text)
        obj.spools4 = Val(txtYarn4Spools.Text)
        obj.itcd4_remark = txtYarn4Remark.Text

        obj.itcd5 = cboYarn5Code.SelectedValue
        obj.ynperc5 = Val(txtYarn5Percent.Text)
        obj.spools5 = Val(txtYarn5Spools.Text)
        obj.itcd5_remark = txtYarn5Remark.Text

        obj.itcd6 = cboYarn6Code.SelectedValue
        obj.ynperc6 = Val(txtYarn6Percent.Text)
        obj.spools6 = Val(txtYarn6Spools.Text)
        obj.itcd6_remark = txtYarn6Remark.Text

        obj.itcd7 = cboYarn7Code.SelectedValue
        obj.ynperc7 = Val(txtYarn7Percent.Text)
        obj.spools7 = Val(txtYarn7Spools.Text)
        obj.itcd7_remark = txtYarn7Remark.Text

        obj.rolls = Val(txtRolls.Text)
        obj.kgs_per_roll = Val(txtKgsPerRoll.Text)
        obj.RepeatPerRoll = Val(txtRepeatPerRoll.Text) 'Sitthana 16/11/2018
        obj.mcno = cboMachine.SelectedValue
        obj.knitting_remark = txtKnittingRemark.Text

        obj.weight_sqm = Val(txtWeight.Text)
        obj.weight_sqm_Max = Val(txtWeightMax.Text) 'Sitthana 19/05/2018
        obj.width = Val(txtWidth.Text)
        obj.width_Max = Val(txtWidthMax.Text) 'Sitthana 19/05/2018
        obj.course = Val(txtCourse.Text)
        obj.wale = Val(txtWale.Text)
        obj.dyeing_remark = txtDyeingRemark.Text

        obj.active = True
        obj.remark = txtKnittingRemark.Text 'Sitthana 16/11/2018
        obj.create_by = clsUser.UserID
        obj.create_date = Today.ToString("yyyyMMdd")
        obj.create_time = Now.ToString("HH: mm:ss")
        obj.modify_by = clsUser.UserID
        obj.modify_date = Today.ToString("yyyyMMdd")
        obj.modify_time = Now.ToString("HH:mm:ss")

        obj.imagefile = txtImage.Text.Trim

        obj.submit_date = dtpsubmit_date.Value.ToString("yyyyMMdd")
        obj.spec_master_date = dtpspec_master_date.Value.ToString("yyyyMMdd")
        obj.qa_report_date = dtpqa_report_date.Value.ToString("yyyyMMdd")

        obj.dr_app_rej_id = (New clsConfig).IsNull(cboDRAppRej.SelectedValue, Nothing)
        obj.dr_app_rej_comment = txtDR_APP_REJ_COMMENT.Text.Trim
        obj.dr_closed = IIf(ChkdrClosed.Checked, "Y", "N")
        obj.pdr_closed = IIf(Chkpdr_closed.Checked, "Y", "N")
        obj.dr_ynchgcd = cboMultiBomCode.SelectedValue 'Sitthana 21/05/2018
        obj.add_to_collection = IIf(chkAddToCollection.Checked, "1", "0")  'Sitthana 25/05/2018

        If objDB.DRNEWUpdate(drvSoitm, dtSoitm, obj, clsUser.UserID, errmsg) Then
            Call GenComboDocNo()
            Call GenCombo()
            Call LoadData(obj.id) 'Errmsg
            cboDocNo.Text = obj.id

            MessageBox.Show("Save Completed", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            MessageBox.Show(errmsg, "System Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Function

    Private Sub frmDR2_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        Call GenCombo()
        Call GenComboDocNo()
        'Call InitControl()

    End Sub

    Private Sub frmDR2_FormClosing(sender As System.Object, e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        If MessageBox.Show("Would you Like to exit ?", "System Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.No Then
            e.Cancel = True
        End If
    End Sub

    Private Sub btnNew_Click(sender As System.Object, e As System.EventArgs) Handles btnNew.Click
        ''Call btnSave_Click(sender, e)  'Comment By Sitthana 2180110
        Call InitControl()
    End Sub

    Private Sub btnSave_Click(sender As System.Object, e As System.EventArgs) Handles btnSave.Click
        Dim result As DialogResult 'Windows.Forms.DialogResult
        result = MessageBox.Show("Would you Like to Save?", "System Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button3)
        If result <> DialogResult.Yes Then Exit Sub

        If Not CheckData() Then Exit Sub

        Call SaveData()

    End Sub

    Private Function CheckData() As Boolean

        If ChkdrClosed.Checked Then
            If (New clsConfig).IsNull(cboDRAppRej.SelectedValue, 0) = 0 Then
                MessageBox.Show("APP/REJ Status Should Be Enter", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return False
            End If
        End If

        'If txtDRNo.Text.Trim = "" Then
        '    MessageBox.Show("DR NO Is Emply", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
        '    Return False
        'Else
        '    Return True
        'End If  'Gen Auto DRNo. 'Comment By Sitthana 20180110
        'If txtFabricType.Text.Trim = "" Then
        '    Dim strMessage As String = "Fabric Type Is Emply" & vbCr & "Please fix it first in Program Design Master"
        '    If MessageBox.Show(strMessage, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning) = vbOK Then
        '        Return False
        '    End If
        'Else
        '    Return True
        'End If 'Comment By Sitthana 31/01/2018   txtFabricType.Text.Trim = ""  Set Default -> DR else -> DRS
        Return True
    End Function

    Private Sub btnPrint_Click(sender As System.Object, e As System.EventArgs) Handles btnPrint.Click
        Const rptFileName = "rptDR2.rpt"
        'If clsuser.ReportPath = "" Then clsuser.ReportPath = clsConfig.ReportPath
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
        rpt.SetParameterValue("@id", id)
        rpt.SetParameterValue("@logempcd", clsUser.UserID)

        frm.Title = "Development Requirement"
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

    Private Sub cboDocNo_DropDownClosed(sender As System.Object, e As System.EventArgs) Handles cboDocNo.DropDownClosed
        Dim new_id As Long = config.IsNull(cboDocNo.ComboBox.SelectedValue, 0)
        If new_id > 0 Then
            Call LoadData(new_id)
        End If
    End Sub

    Private Sub cboDocNo_Click(sender As System.Object, e As System.EventArgs) Handles cboDocNo.Click

    End Sub

    Private Sub btnplay_Click(sender As System.Object, e As System.EventArgs) Handles btnplay.Click
        'AxWindowsMediaPlayer1.fullScreen = True
        Dim OpenFileDialog As New OpenFileDialog

        OpenFileDialog.FileName = txtImage.Text.Trim

        'If AxWindowsMediaPlayer1.playState = WMPLib.WMPPlayState.wmppsPlaying Then

        'End If
        'AxWindowsMediaPlayer1.fullScreen = True

    End Sub
    Public Property fullScreen As System.Boolean

    Private Sub btnSearch_Click(sender As System.Object, e As System.EventArgs) Handles btnSearch.Click
        Dim frm As New frmSearchDR
        frm.ShowDialog(Me)
        Call btnNew_Click(sender, e)

        id = (frm.pid)
        cboDocNo.SelectedItem = (frm.pid)
        txtDRNo.Text = (frm.Pdr_no)
        Call getSoitm(frm.Pdr_no)
        Me.Cursor = Cursors.WaitCursor
        If Not blnCancel Then LoadData(frm.pid)

        Me.Cursor = Cursors.Default
        frm.Dispose()
    End Sub

    Private Sub txtDRNo_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtDRNo.TextChanged

    End Sub

    Private Sub btnImagePath_Click(sender As System.Object, e As System.EventArgs) Handles btnImagePath.Click
        If txtDRNo.Text = "" Then
            MessageBox.Show("โปรด เลือก DR No. ", "System Message!", MessageBoxButtons.OK, MessageBoxIcon.Stop, MessageBoxDefaultButton.Button1)
            Exit Sub

        End If

        Dim OpenFileDialog As New OpenFileDialog


        Dim replace As String = txtNewDesignNo.Text.Replace("/", "-")
        Dim strFileName As String = replace
        Dim strFileType As String = ".AVI"
        Dim strFilePath As String = "C:"


        OpenFileDialog.InitialDirectory = "C:"
        OpenFileDialog.Filter = "Video Files (*.AVI;*.MPG;*.MP4)|*.AVI;*.MPG;*.MP4|All files (*.*)|*.*"
        OpenFileDialog.Multiselect = False

        If OpenFileDialog.ShowDialog() = DialogResult.OK Then
            txtImage.Text = OpenFileDialog.FileName
        End If

        'txtImage.Text = strFilePath & strFileName & strFileType
    End Sub

    Private Sub btnUpload_Click(sender As System.Object, e As System.EventArgs) Handles btnUpload.Click

        Dim OpenFileDialog As New OpenFileDialog
        Dim NewDesignNoreplace As String = txtNewDesignNo.Text.Replace("/", "-")
        Dim strFileName As String = NewDesignNoreplace
        Dim strFileType As String = ".AVI"
        Dim strFilePath As String = "\\172.16.3.4\media\VIDEO\MACHINE\"

        OpenFileDialog.FileName = txtImage.Text.Trim

        Try
            If OpenFileDialog.FileName <> "" Then 'Add By Neung
                My.Computer.FileSystem.CopyFile(
                OpenFileDialog.FileName,
               strFilePath & strFileName & strFileType,
               Microsoft.VisualBasic.FileIO.UIOption.AllDialogs,
                Microsoft.VisualBasic.FileIO.UICancelOption.ThrowException)
            End If

            txtImage.Text = strFilePath & strFileName & strFileType
            MessageBox.Show("Upload สำเร็จ", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)

        Catch ex As Exception

            MessageBox.Show("Upload ไม่สำเร็จ", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)

        End Try

    End Sub

    Private Function getDescriptionOneKey(StoredProcedureName As String, ParameterName As String, Parametervalue As String, ReturnFieldName As String)
        Dim description As String = ""

        Dim conn As New SqlConnection((New classConnection).connection)
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = StoredProcedureName
        comm.Parameters.AddWithValue(ParameterName, Parametervalue)
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)

        If Not IsDBNull(dt) Then
            If dt.Rows.Count > 0 Then
                description = dt.Rows(0).Item(ReturnFieldName).ToString.Trim
            End If
        End If

        Return description
    End Function
    Private Function getTotalPairsOfShoe(DesignNO As String, KgPerRoll As Double, TotalRoll As Double)
        Dim TotalPairs As Integer = 0

        Dim description As String = ""

        Dim conn As New SqlConnection((New classConnection).connection)
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure

        comm.CommandText = "p_designs_get_TotalPair"
        comm.Parameters.AddWithValue("@design_no", DesignNO)
        comm.Parameters.AddWithValue("@KgPerRoll", KgPerRoll)
        comm.Parameters.AddWithValue("@TotalRoll", TotalRoll)
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)

        'If Not IsDBNull(dt) Then
        '    If dt.Rows.Count > 0 Then
        '        TotalPairs = dt.Rows(0).Item(TotalPairs).ToString.Trim
        '    End If
        'End If

        Return dt
    End Function
    Private Sub getCboBomCode()
        Dim positionNo As Integer = InStr(txtNewDesignNo.Text.Trim, "/")

        'Sittana comment 20190116
        'If positionNo = 0 Then
        '    DesignNo = txtNewDesignNo.Text.Trim.ToUpper
        'Else
        '    DesignNo = Mid(txtNewDesignNo.Text.Trim, 1, positionNo - 1).ToUpper
        'End If

        'txtDesignNo.Text = txtNewDesignNo.Text.Trim 'Eschler Not Use

        txtFabricType.Text = getDescriptionOneKey("p_development_requirement_get_fabric_by_dm", "@Design_no", DesignNo, "fabrictype_name")
        If txtFabricType.Text.Trim.ToUpper = "SHOE" Or txtFabricType.Text.Trim.ToUpper = "BRA" Then
            grpPairOfShoe.Visible = True
        Else
            grpPairOfShoe.Visible = False
        End If

        Call gencboMultiBomCode(txtDesignNo.Text.Trim) 'Sitthana 30/01/2018
    End Sub
    Private Sub txtNewDesignNo_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles txtNewDesignNo.KeyDown
        If e.KeyCode = Keys.Enter Then
            Call getCboBomCode()
            If cboMultiBomCode.Items.Count = 1 Then
                cboMultiBomCode.SelectedIndex = 0
                cboMultiBomCode_SelectionChangeCommitted(Nothing, Nothing)
                Call GetBom(txtDesignNo.Text, cboMultiBomCode.Text) 'Edit By Neung .selectvalue to .text
            End If
            Call getDesignNo() 'Sitthana 20190116
        End If
    End Sub
    Private Sub getDesignNo()
        'Sitthana 20190116
        Dim objMaster As New classMaster
        Dim dtDesignMaster As New DataTable

        dtDesignMaster = (New classDesignNew).getDesignMasterRecord("", txtNewDesignNo.Text.ToString)
        If dtDesignMaster.Rows.Count > 0 Then
            txtDesignNo.Text = dtDesignMaster.Rows(0).Item("dm_parent_design").ToString.Trim
            txtFabricType.Text = dtDesignMaster.Rows(0).Item("fabric_type").ToString.Trim
            cboMachine.SelectedValue = dtDesignMaster.Rows(0).Item("ds_machine_group_id")
            txtWeightMax.Text = dtDesignMaster.Rows(0).Item("ds_gmpersqm")
            txtWidthMax.Text = dtDesignMaster.Rows(0).Item("ds_usewth")
        Else
            txtDesignNo.Text = ""
            txtFabricType.Text = ""
            cboMachine.SelectedIndex = -1
            txtWeightMax.Text = "0"
            txtWidthMax.Text = ""
        End If

    End Sub
    Private Sub cboMultiBomCode_SelectionChangeCommitted(sender As Object, e As EventArgs)
        '  If cboMultiBomCode.SelectedIndex >= 0 Then
        '  Call GetBom(cboMultiBomCode.Text) 'Edit By Neung .selectvalue to .text
        '  End If
    End Sub

    Private Sub GetBom(ByVal StrDesignNo As String, ByVal StrBomCode As String)
        Dim objdb As New classProduction

        Dim dt As New DataTable
        'dt = objdb.YarnChangeSelectBOM(id_yarnchange:=0, StrDesignNo:=txtNewDesignNo.Text.Trim, Strynchgcd:=Strynchgcd, Strbom_usage_code:=Nothing, logempcd:=clsUser.UserID)
        dt = objdb.DevelopmentRequirementSelectBOM(StrDesignNo:=StrDesignNo, Strynchgcd:=StrBomCode)

        'If dt.Rows.Count > 0 Then
        Call BindDataBOM(dt)
        'End If
    End Sub
    Private Sub BindDataBOM(ByVal dt As DataTable)

        Dim i As Integer = 0

        cboYarn1Code.SelectedIndex = 0
        txtYarn1Percent.Text = ""
        cboYarn2Code.SelectedIndex = 0
        txtYarn2Percent.Text = ""
        cboYarn3Code.SelectedIndex = 0
        txtYarn3Percent.Text = ""
        cboYarn4Code.SelectedIndex = 0
        txtYarn4Percent.Text = ""
        cboYarn5Code.SelectedIndex = 0
        txtYarn5Percent.Text = ""
        cboYarn6Code.SelectedIndex = 0
        txtYarn6Percent.Text = ""
        cboYarn7Code.SelectedIndex = 0
        txtYarn7Percent.Text = ""

        If dt.Rows.Count > 0 Then
            For i = 0 To dt.Rows.Count - 1
                If i = 0 Then
                    cboYarn1Code.SelectedValue = dt.Rows(0)("itcd").ToString()
                    txtYarn1Percent.Text = dt.Rows(0)("ynperc").ToString()
                    'txtYarn1Spools.Text = dt.Rows(0)("spools").ToString()
                    'txtYarn1Remark.Text = dt.Rows(0)("itcd_remark").ToString()

                ElseIf i = 1 Then
                    cboYarn2Code.SelectedValue = dt.Rows(1)("itcd").ToString()
                    txtYarn2Percent.Text = dt.Rows(1)("ynperc").ToString()
                    'txtYarn2Spools.Text = dt.Rows(1)("spools").ToString()
                    'txtYarn2Remark.Text = dt.Rows(1)("itcd_remark").ToString()

                ElseIf i = 2 Then
                    cboYarn3Code.SelectedValue = dt.Rows(2)("itcd").ToString()
                    txtYarn3Percent.Text = dt.Rows(2)("ynperc").ToString()
                    'txtYarn3Spools.Text = dt.Rows(2)("spools").ToString()
                    'txtYarn3Remark.Text = dt.Rows(2)("itcd_remark").ToString()
                ElseIf i = 3 Then

                    cboYarn4Code.SelectedValue = dt.Rows(3)("itcd").ToString()
                    txtYarn4Percent.Text = dt.Rows(3)("ynperc").ToString()
                    'txtYarn4Spools.Text = dt.Rows(3)("spools").ToString()
                    'txtYarn4Remark.Text = dt.Rows(3)("itcd_remark").ToString()

                ElseIf i = 4 Then
                    cboYarn5Code.SelectedValue = dt.Rows(4)("itcd").ToString()
                    txtYarn5Percent.Text = dt.Rows(4)("ynperc").ToString()
                    'txtYarn5Spools.Text = dt.Rows(4)("spools").ToString()
                    'txtYarn5Remark.Text = dt.Rows(4)("itcd_remark").ToString()
                ElseIf i = 5 Then
                    cboYarn6Code.SelectedValue = dt.Rows(5)("itcd").ToString()
                    txtYarn6Percent.Text = dt.Rows(5)("ynperc").ToString()
                    'txtYarn6Spools.Text = dt.Rows(0)("spools").ToString()
                    'txtYarn6Remark.Text = dt.Rows(0)("itcd_remark").ToString()
                ElseIf i = 6 Then
                    cboYarn7Code.SelectedValue = dt.Rows(6)("itcd").ToString()
                    txtYarn7Percent.Text = dt.Rows(6)("ynperc").ToString()
                    'txtYarn6Spools.Text = dt.Rows(0)("spools").ToString()
                    'txtYarn6Remark.Text = dt.Rows(0)("itcd_remark").ToString()
                End If
            Next
        Else
            If dt.Rows.Count = 0 Then
                cboYarn1Code.SelectedIndex = 0
                txtYarn1Percent.Text = ""
                cboYarn2Code.SelectedIndex = 0
                txtYarn2Percent.Text = ""
                cboYarn3Code.SelectedIndex = 0
                txtYarn3Percent.Text = ""
                cboYarn4Code.SelectedIndex = 0
                txtYarn4Percent.Text = ""
                cboYarn5Code.SelectedIndex = 0
                txtYarn5Percent.Text = ""
                cboYarn6Code.SelectedIndex = 0
                txtYarn6Percent.Text = ""
                cboYarn7Code.SelectedIndex = 0
                txtYarn7Percent.Text = ""
            End If
        End If
    End Sub

    Private Sub txtRolls_Leave(sender As Object, e As EventArgs) Handles txtRolls.Leave
        'Sitthana 04/06/2018
        CalTotalShoes()
    End Sub

    Private Sub txtRolls_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtRolls.KeyPress
        'Sitthana 04/06/2018
        If e.KeyChar = vbCr Then
            CalTotalShoes()
        End If
    End Sub
    Private Sub txtKgsPerRoll_Leave(sender As Object, e As EventArgs) Handles txtKgsPerRoll.Leave
        'Sitthana 04/06/2018
        CalTotalShoes()
    End Sub
    Private Sub txtKgsPerRoll_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtKgsPerRoll.KeyPress
        'Sitthana 04/06/2018
        If e.KeyChar = vbCr Then
            CalTotalShoes()
        End If
    End Sub
    Private Sub CalTotalShoes()
        'Sitthana 04/06/2018
        Dim dt As New DataTable

        Dim totalPairOfShoe As Integer = 0
        Dim KgPerRoll As Double = 0
        Dim TotalRolls As Integer = 0

        If txtKgsPerRoll.Text.Trim = "" Then
            KgPerRoll = 0
        Else
            KgPerRoll = Convert.ToDouble(txtKgsPerRoll.Text)
        End If
        If txtRolls.Text.Trim = "" Then
            TotalRolls = 0
        Else
            TotalRolls = Convert.ToDouble(txtRolls.Text)
        End If

        If KgPerRoll = 0 Or TotalRolls = 0 Then
            txtMtsPerRoll.Text = 0
            txtTotalPair.Text = 0
        Else
            dt = getTotalPairsOfShoe(txtNewDesignNo.Text, KgPerRoll, TotalRolls)
            If IsNothing(dt) Then
                txtMtsPerRoll.Text = 0
                TxtPairs_Per_Meter.Text = 0
                txtTotalPair.Text = 0
            Else
                If dt.Rows.Count > 0 Then
                    txtMtsPerRoll.Text = dt.Rows(0).Item("mtkg").ToString
                    TxtPairs_Per_Meter.Text = dt.Rows(0).Item("pairs_per_meter").ToString
                    txtTotalPair.Text = dt.Rows(0).Item("TotalPairs").ToString
                Else
                    txtMtsPerRoll.Text = 0
                    TxtPairs_Per_Meter.Text = 0
                    txtTotalPair.Text = 0
                End If

            End If
        End If
    End Sub

    Private Sub cboPDR_NEW_develop_req_DropDownClosed(sender As Object, e As EventArgs) Handles cboPDR_NEW_develop_req.DropDownClosed
        Dim objdb As New classProduction
        Dim dt As DataTable
        'txtRepeatPerRoll.Text = objdb.getRepeatPerRowFromPDR(cboPDR_NEW_develop_req.SelectedValue)
        dt = objdb.getPDRDetail(cboPDR_NEW_develop_req.SelectedValue)
        If dt.Rows.Count > 0 Then
            txtRepeatPerRoll.Text = dt.Rows(0)("repeat_per_roll")
            txtKnittingRemark.Text = dt.Rows(0)("remark")
            txtDyeingRemark.Text = dt.Rows(0)("dye_remark")
        Else
            txtRepeatPerRoll.Text = ""
            txtKnittingRemark.Text = ""
            txtDyeingRemark.Text = ""
        End If

    End Sub

    Private Sub cboMultiBomCode_DropDownCloseOnClick(sender As Object, args As MouseClickCancelEventArgs) Handles cboMultiBomCode.DropDownCloseOnClick
        Call GetBom(txtDesignNo.Text, (New clsConfig).IsNull(Me.cboMultiBomCode.ListBox.Grid.Model(Me.cboMultiBomCode.SelectedIndex + 1, 2).CellValue, String.Empty))
    End Sub

    Private Sub cboMultiBomCode_KeyDown(sender As Object, e As KeyEventArgs) Handles cboMultiBomCode.KeyDown
        If e.KeyCode = Keys.Enter Then
            Call GetBom(txtDesignNo.Text, cboMultiBomCode.Text)
        End If
    End Sub

    Private Sub txtDesignNo_KeyDown(sender As Object, e As KeyEventArgs) Handles txtDesignNo.KeyDown
        If e.KeyCode = Keys.Enter Then
            Call gencboMultiBomCode(txtDesignNo.Text.Trim) 'Sitthana 30/01/2018
        End If
    End Sub

    Private Sub getSoitm(ByVal StrSono As String) '17/10/2025 John
        Dim objdb As New classProduction
        dtSoitm = objdb.DevelopmentRequirementSelectSoitm(StrSono:=StrSono)
        bsSoitm.DataSource = dtSoitm
        dgvSoitm.AutoGenerateColumns = False
        dgvSoitm.DataSource = bsSoitm

        If bsSoitm.Current IsNot Nothing Then
            drvSoitm = CType(bsSoitm.Current, DataRowView)
        Else
            drvSoitm = Nothing
        End If
    End Sub

    Private Function GetCurrentUserMailInfo() As DataTable
        Dim conn As New SqlConnection((New classConnection).connection)
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.Text
        comm.CommandText = "SELECT TOP 1 email, SMTPServer FROM emp WHERE empcd = @empcd"
        comm.Parameters.AddWithValue("@empcd", clsUser.UserID)

        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        conn.Close()
        Return dt
    End Function

    Private Function GetCurrentSoitmRow() As DataRowView
        If dgvSoitm.CurrentRow Is Nothing Then Return Nothing
        Return TryCast(dgvSoitm.CurrentRow.DataBoundItem, DataRowView)
    End Function

    Private Function GetFieldText(ByVal row As DataRowView, ByVal fieldName As String) As String
        If row Is Nothing OrElse Not row.DataView.Table.Columns.Contains(fieldName) Then Return ""
        Return (New clsConfig).IsNull(row.Item(fieldName), "").ToString.Trim
    End Function

    Private Function GetFieldDateText(ByVal row As DataRowView, ByVal fieldName As String) As String
        If row Is Nothing OrElse Not row.DataView.Table.Columns.Contains(fieldName) Then Return ""
        If IsDBNull(row.Item(fieldName)) OrElse row.Item(fieldName) Is Nothing Then Return ""
        Return Convert.ToDateTime(row.Item(fieldName)).ToString("dd/MM/yyyy")
    End Function

    Private Sub AddMailAddresses(ByVal addresses As String, ByVal mailAddresses As MailAddressCollection)
        For Each address As String In addresses.Split(New Char() {";"c, ","c}, StringSplitOptions.RemoveEmptyEntries)
            If address.Trim <> "" Then mailAddresses.Add(address.Trim)
        Next
    End Sub

    Private Function BuildRejectJobMailBody(ByVal row As DataRowView) As String
        Dim body As New StringBuilder

        body.AppendLine("Development Requirement Reject Job")
        body.AppendLine()
        body.AppendLine("DR No.: " & txtDRNo.Text.Trim)
        body.AppendLine("S/O No.: " & GetFieldText(row, "sono"))
        body.AppendLine("Slno: " & GetFieldText(row, "slno"))
        body.AppendLine("Design No.: " & GetFieldText(row, "design_no"))
        body.AppendLine("Color: " & GetFieldText(row, "col"))
        body.AppendLine("Approved Job No.: " & GetFieldText(row, "approved_jobno"))
        body.AppendLine("Reject Job No.: " & GetFieldText(row, "reject_jobno"))
        body.AppendLine("Reject Job Date: " & GetFieldDateText(row, "reject_job_date"))
        body.AppendLine("Reject Job Reason: " & GetFieldText(row, "reject_job_reason"))
        body.AppendLine()
        body.AppendLine("Send By: " & clsUser.UserID)

        Return body.ToString
    End Function

    Private Sub btnSendMail_Click(sender As Object, e As EventArgs) Handles btnSendMail.Click
        dgvSoitm.EndEdit()
        bsSoitm.EndEdit()

        Dim row As DataRowView = GetCurrentSoitmRow()
        If row Is Nothing Then
            MessageBox.Show("Please select S/O item first.", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Dim mailInfo As DataTable = GetCurrentUserMailInfo()
        Dim fromEmail As String = "noreply@gemmaknits.com"
        Dim smtpServer As String = "mail.gemmaknits.com"

        If mailInfo.Rows.Count > 0 Then
            fromEmail = (New clsConfig).IsNull(mailInfo.Rows(0)("email"), fromEmail).ToString.Trim
            smtpServer = (New clsConfig).IsNull(mailInfo.Rows(0)("SMTPServer"), smtpServer).ToString.Trim
        End If

        If fromEmail = "" Then fromEmail = "noreply@gemmaknits.com"
        If smtpServer = "" Then smtpServer = "mail.gemmaknits.com"

        Dim toEmail As String = InputBox("Send reject job mail to:", "Send Mail")
        If toEmail.Trim = "" Then Exit Sub

        Try
            Dim eMail As New MailMessage()
            eMail.From = New MailAddress(fromEmail)
            AddMailAddresses(toEmail, eMail.To)
            eMail.Subject = "Reject Job: " & GetFieldText(row, "reject_jobno") & " / DR " & txtDRNo.Text.Trim
            eMail.IsBodyHtml = False
            eMail.Body = BuildRejectJobMailBody(row)

            Dim smtp As New SmtpClient
            smtp.Host = smtpServer
            smtp.Port = 25
            smtp.EnableSsl = False
            smtp.Send(eMail)

            MessageBox.Show("Send mail completed", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "System Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub tsDrNo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tsDrNo.KeyPress '21/10/2025 John
        If e.KeyChar = vbCr Then
            Dim frm As New frmSearchDR
            frm.pDrNo = tsDrNo.Text
            frm.ShowDialog(Me)
            Call btnNew_Click(sender, e)

            id = (frm.pid)
            cboDocNo.SelectedItem = (frm.pid)
            tsDrNo.Text = (frm.Pdr_no)
            txtDRNo.Text = (frm.Pdr_no)
            Call getSoitm(frm.Pdr_no)
            Me.Cursor = Cursors.WaitCursor

            If Not blnCancel Then LoadData(frm.pid)

            Me.Cursor = Cursors.Default
            frm.Dispose()
        End If
    End Sub
End Class
