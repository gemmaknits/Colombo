Public Class frmSupplier
    Dim clsConfig As New clsConfig
    Dim clsConn As New classConnection
    Dim clsUser As New classUserInfo

    Dim strSuppCD As String = ""
    Dim blnCancel As Boolean = False

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

    Private Sub InitControl()
        Dim obj As Control
        For Each obj In Me.Controls
            Call SetControlValue(obj)
        Next
        Call EnabledControl(True)
        strSuppCD = ""
        'Call LoadData("")
        txtSuppCD.Focus()
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

        Me.cboPayType.DataSource = objDB.GetPaymode()
        Me.cboPayType.DisplayMember = "paymodecd"
        Me.cboPayType.ValueMember = "paymodecd"

        Me.cboCountry.DataSource = objDB.GetCountry()
        Me.cboCountry.DisplayMember = "name2"
        Me.cboCountry.ValueMember = "ctry2"
    End Sub

    Private Sub GenComboSuppcd()
        Dim objDB As New classMaster
        Me.cboSuppCD.ComboBox.DataSource = objDB.GetSupplier()
        Me.cboSuppCD.ComboBox.DisplayMember = "name"
        Me.cboSuppCD.ComboBox.ValueMember = "suppcd"
        Me.cboSuppCD.ComboBox.SelectedIndex = 0
    End Sub

    Private Sub BindData(ByVal dt As DataTable)
        strSuppCD = dt.Rows(0)("suppcd").ToString.Trim
        txtSuppCD.Text = dt.Rows(0)("suppcd").ToString.Trim
        txtENName.Text = dt.Rows(0)("name").ToString.Trim
        txtENAddr1.Text = dt.Rows(0)("addr1").ToString.Trim
        txtENAddr2.Text = dt.Rows(0)("addr2").ToString.Trim
        txtENAddr3.Text = dt.Rows(0)("addr3").ToString.Trim
        txtTHName.Text = dt.Rows(0)("namet").ToString.Trim
        txtTHAddr1.Text = dt.Rows(0)("addr1t").ToString.Trim
        txtTHAddr2.Text = dt.Rows(0)("addr2t").ToString.Trim
        txtTHAddr3.Text = dt.Rows(0)("addr3t").ToString.Trim
        cboCountry.SelectedValue = dt.Rows(0)("ctry").ToString.Trim
        txtEMail.Text = dt.Rows(0)("email").ToString.Trim
        txtTel.Text = dt.Rows(0)("tel").ToString.Trim
        txtFax.Text = dt.Rows(0)("fax").ToString.Trim
        txtCredit.Text = dt.Rows(0)("crdays").ToString.Trim
        txtContact.Text = dt.Rows(0)("contact").ToString.Trim
        txtPaymentTerms.Text = dt.Rows(0)("crterms").ToString.Trim
        cboPayType.SelectedValue = dt.Rows(0)("paymodecd").ToString.Trim
        chkInternal.Checked = CBool(dt.Rows(0)("internal"))
    End Sub

    Private Function IsDataChange() As Boolean
        Dim clsMaster As New classMaster
        Dim dt As DataTable = clsMaster.GetSupplier(strSuppCD)
        Dim result As Boolean = False
        Dim i As Integer = 0
        Dim j As Integer = 0

        If txtENAddr1.Text <> dt.Rows(0)("addr1").ToString.Trim Then result = True
        If txtENAddr2.Text <> dt.Rows(0)("addr2").ToString.Trim Then result = True
        If txtENAddr3.Text <> dt.Rows(0)("addr3").ToString.Trim Then result = True
        If txtTHName.Text <> dt.Rows(0)("namet").ToString.Trim Then result = True
        If txtTHAddr1.Text <> dt.Rows(0)("addr1t").ToString.Trim Then result = True
        If txtTHAddr2.Text <> dt.Rows(0)("addr2t").ToString.Trim Then result = True
        If txtTHAddr3.Text <> dt.Rows(0)("addr3t").ToString.Trim Then result = True
        If clsConfig.IsNull(cboCountry.SelectedValue, "").ToString.Trim <> dt.Rows(0)("ctry").ToString.Trim Then result = True
        If txtEMail.Text <> dt.Rows(0)("email").ToString.Trim Then result = True
        If txtTel.Text <> dt.Rows(0)("tel").ToString.Trim Then result = True
        If txtFax.Text <> dt.Rows(0)("fax").ToString.Trim Then result = True
        If txtCredit.Text <> dt.Rows(0)("crdays").ToString.Trim Then result = True
        If txtContact.Text <> dt.Rows(0)("contact").ToString.Trim Then result = True
        If txtPaymentTerms.Text <> dt.Rows(0)("crterms").ToString.Trim Then result = True
        If clsConfig.IsNull(cboPayType.SelectedValue, "").ToString.Trim <> dt.Rows(0)("paymodecd").ToString.Trim Then result = True
        If chkInternal.Checked <> CBool(dt.Rows(0)("internal")) Then result = True
        IsDataChange = result
    End Function

    Private Function CheckData() As Boolean
        Dim config As New clsConfig
        If txtENName.Text.Trim.Length = 0 Then
            MessageBox.Show("Please fill the supplier name (Eng) !!", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            CheckData = False
            Exit Function
        End If
        If txtTHName.Text.Trim.Length = 0 Then
            MessageBox.Show("Please fill the supplier name (Thai) !!", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            CheckData = False
            Exit Function
        End If
        If config.IsNull(cboCountry.SelectedValue, "").ToString.Trim = "" Then
            MessageBox.Show("Please choose country !!", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            CheckData = False
            Exit Function
        End If
        CheckData = True
    End Function

    Private Sub LoadData(ByVal suppcd As String)
        Dim objDB As New classMaster
        Dim dt As New DataTable
        dt = objDB.GetSupplier(suppcd)
        If dt.Rows.Count > 0 Then Call BindData(dt)
    End Sub

    Private Function SaveData() As Boolean
        Dim clsMaster As New classMasterUpdate
        Dim header As New classMasterUpdate.Supplier
        Dim msgerr As String = ""
        Dim suppcd As String = ""
        header.h01_suppcd = strSuppCD
        header.h02_name = txtENName.Text.Trim
        header.h03_namet = txtTHName.Text.Trim
        header.h04_addr1 = txtENAddr1.Text.Trim
        header.h05_addr2 = txtENAddr2.Text.Trim
        header.h06_addr3 = txtENAddr3.Text.Trim
        header.h07_addr1t = txtTHAddr1.Text.Trim
        header.h08_addr2t = txtTHAddr2.Text.Trim
        header.h09_addr3t = txtTHAddr3.Text.Trim
        header.h10_city = ""
        header.h11_ctry = clsConfig.IsNull(cboCountry.SelectedValue, "").ToString.Trim
        header.h12_tel = txtTel.Text.Trim
        header.h13_fax = txtFax.Text.Trim
        header.h14_email = txtEMail.Text.Trim
        header.h15_contact = txtContact.Text.Trim
        header.h16_dyer = 0
        header.h17_scalloper = 0
        header.h18_greige = 0
        header.h19_altcode = ""
        header.h20_abbrev = ""
        header.h21_abbrev2 = ""
        header.h22_crdays = Val(txtCredit.Text.Trim)
        header.h23_crterms = txtPaymentTerms.Text.Trim
        header.h24_paymodecd = clsConfig.IsNull(cboPayType.SelectedValue, "").ToString.Trim
        header.h25_internal = chkInternal.Checked
        header.h26_log_empcd = clsUser.UserID

        If clsMaster.SupplierSave(header, msgerr, suppcd) Then
            strSuppCD = suppcd
            SaveData = True
        Else
            MessageBox.Show(msgerr, "System Message", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
            SaveData = False
        End If
    End Function

    Private Sub frmSupplier_Load(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Call GenCombo()
        Call GenComboSuppcd()
        Call InitControl()
    End Sub

    Private Sub frmSupplier_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs)
        If IsDataChange() Then Call btnSave_Click(sender, e)
        e.Cancel = blnCancel
    End Sub

    Private Sub btnNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If IsDataChange() Then Call btnSave_Click(sender, e)
        If Not blnCancel Then Call InitControl()
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        blnCancel = False
        'Sitthana 20220624 Changed Windows.Forms.DialogResult To DialogResult
        Dim result As DialogResult ' Windows.Forms.DialogResult
        result = MessageBox.Show("Would you like to save ?", "System Message", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button3)
        If result = DialogResult.Cancel Then blnCancel = True
        If result <> DialogResult.Yes Then Exit Sub
        If Not CheckData() Then Exit Sub
        Me.Cursor = Cursors.WaitCursor
        If SaveData() Then
            LoadData(strSuppCD)
            Call GenComboSuppcd()
        End If
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub btnPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Const rptFileName = "rptMasterSupplier.rpt"
        If clsUser.ReportPath = "" Then clsUser.ReportPath = clsUser.ReportPath
        If Not clsConfig.CheckReport(clsUser.ReportPath, rptFileName) Then Exit Sub
        Dim frm As New frmReport
        Dim rpt As New CrystalDecisions.CrystalReports.Engine.ReportDocument
        Me.Cursor = Cursors.WaitCursor

        rpt.Load(clsUser.ReportPath & rptFileName)
        rpt.PrintOptions.PaperSize = CrystalDecisions.Shared.PaperSize.PaperA4
        rpt.DataSourceConnections.Item(0).SetConnection(clsConn.servername, clsConn.database, False)
        rpt.DataSourceConnections.Item(0).SetLogon(clsConn.Userid, clsConn.Password)
        rpt.VerifyDatabase()

        frm.Title = "Customer Master"
        frm.CRViewer.ReportSource = rpt
        frm.MdiParent = Me.ParentForm
        frm.Show()
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub btnMinimized_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub

    Private Sub cbosuppcd_DropDownClosed(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbosuppcd.DropDownClosed
        Dim suppcd As String
        suppcd = clsConfig.IsNull(cbosuppcd.ComboBox.SelectedValue, "")
        If suppcd.Trim.Length > 0 Then
            Call btnNew_Click(sender, e)
            If Not blnCancel Then LoadData(suppcd)
        End If
    End Sub

    Private Sub txtsuppcd_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtsuppcd.KeyPress
        Dim suppcd As String = ""
        If Asc(e.KeyChar) = 13 Then
            suppcd = txtsuppcd.Text.Trim.ToUpper
            Call btnNew_Click(sender, e)
            If Not blnCancel Then LoadData(suppcd)
        End If
    End Sub

    Private Sub btnPrint_Click_1(sender As System.Object, e As System.EventArgs) Handles btnPrint.Click

    End Sub

    Private Sub frmSupplier_Load_1(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Call GenCombo()
        Call GenComboSuppcd()
        Call InitControl()
    End Sub

    Private Sub btnPrint_Click_2(sender As System.Object, e As System.EventArgs) Handles btnPrint.Click
        Call btnPrint_Click(sender, e)
    End Sub

    Private Sub btnSave_Click_1(sender As System.Object, e As System.EventArgs) Handles btnSave.Click
        btnSave_Click(sender, e)
    End Sub
End Class