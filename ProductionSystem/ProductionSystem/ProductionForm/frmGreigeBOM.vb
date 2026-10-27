Public Class frmGreigeBOM
    Dim config As New clsConfig
    Dim clsConn As New classConnection
    Dim clsUser As New classUserInfo
    Dim id_yarnchange As Integer = 0

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
        id_yarnchange = 0
        dtpBOMDate.Value = Now
        Call LoadData(0)
        txtDesignNo.Focus()
    End Sub

    Private Sub GenCombo()
        Dim objDB As New classMaster

        Me.cboBOMUsage.DataSource = objDB.comboBOMUsage(clsUser.UserID)
        Me.cboBOMUsage.DisplayMember = "bom_usage_name"
        Me.cboBOMUsage.ValueMember = "bom_usage_code"
        Me.cboBOMUsage.SelectedIndex = 0

        Me.itcd.DataSource = objDB.comboYarn(clsUser.UserID)
        Me.itcd.DisplayMember = "itcd2"
        Me.itcd.ValueMember = "itcd"

        Me.suppcd.DataSource = objDB.comboSupplier(clsUser.UserID)
        Me.suppcd.DisplayMember = "name"
        Me.suppcd.ValueMember = "suppcd"
    End Sub

    Private Sub GenComboDesignBOM()
        Dim objDB As New classMaster

        Me.cboDesignBOM.ComboBox.DataSource = objDB.comboYarnChange(clsUser.UserID)
        Me.cboDesignBOM.ComboBox.DisplayMember = "design_bom"
        Me.cboDesignBOM.ComboBox.ValueMember = "id_yarnchange"
        Me.cboDesignBOM.ComboBox.SelectedIndex = 0
    End Sub

    Private Sub BindData(ByVal dt As DataTable)
        id_yarnchange = Val(dt.Rows(0)("id_yarnchange"))
        txtDesignNo.Text = dt.Rows(0)("design_no")
        dtpBOMDate.Value = dt.Rows(0)("ynchgdt2")
        txtBOMCode.Text = dt.Rows(0)("ynchgcd")
        txtRemark.Text = dt.Rows(0)("remarke")
        cboBOMUsage.SelectedValue = dt.Rows(0)("bom_usage_code")
        txtTotalWithRound.Text = CDbl(dt.Rows(0)("sum_perc"))
    End Sub

    Private Sub BindGrid(ByVal dt As DataTable)
        grdData.AutoGenerateColumns = False
        grdData.DataSource = dt
    End Sub

    Private Sub LoadData(ByVal id_yarnchange As Integer)
        Dim objDB As New classProduction
        Dim dt As DataTable = objDB.YarnChangeSelect(id_yarnchange, clsUser.UserID)
        If dt.Rows.Count > 0 Then
            Call BindData(dt)
        End If
        Call BindGrid(dt)
        txtTotalNotRound.Text = CalTotalYarn()
    End Sub

    Private Sub CopyData(ByVal id_yarnchange As Integer, ByVal bom_usage_code As String)
        Dim objDB As New classProduction
        Dim dt As DataTable = objDB.YarnChangeCopy(id_yarnchange, bom_usage_code, clsUser.UserID)
        If dt.Rows.Count > 0 Then
            Call LoadData(dt.Rows(0)("id_yarnchange"))
        End If
    End Sub

    Private Function SaveData() As Boolean
        Dim objBOM As New YarnChange
        Dim objDB As New classProduction
        Dim errmsg As String = ""


        objBOM.design_no = txtDesignNo.Text
        objBOM.ynchgdt = dtpBOMDate.Value.ToString("yyyyMMdd")
        objBOM.ynchgcd = txtBOMCode.Text
        objBOM.remarke = txtRemark.Text
        objBOM.id_yarnchange = id_yarnchange
        objBOM.bom_usage_code = cboBOMUsage.SelectedValue
        objBOM.required_qty = 0
        objBOM.uom = "KGS"
        objBOM.bom_active = chkEnabled.Checked
        objBOM.bom_approved = chkApproved.Checked
        objBOM.bom_remarks = ""

        If objDB.YarnChangeUpdate(objBOM, grdData.DataSource, clsUser.UserID, errmsg) Then
            Call GenComboDesignBOM()
            Call InitControl()
            MessageBox.Show("Save Completed", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            MessageBox.Show(errmsg, "System Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Function

    Public Function DeleteData(ByVal id_yarnchangedet As Integer) As Boolean
        Dim objDB As New classProduction
        Dim dt As DataTable
        Try
            dt = objDB.YarnChangeDetDelete(id_yarnchangedet, clsUser.UserID)
            txtTotalNotRound.Text = CalTotalYarn()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "System Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
        Return True
    End Function

    Public Function CalTotalYarn() As Double
        Dim dt As DataTable = grdData.DataSource
        Dim total As Double
        For i As Integer = 0 To dt.Rows.Count - 1
            total += Val(config.IsNull(dt.Rows(i)("ynperc"), 0))
        Next
        Return total
    End Function

    Private Sub frmDesignBOM_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Call InitControl()
        Call GenComboDesignBOM()
        Call GenCombo()
    End Sub

    Private Sub frmDesignBOM_FormClosing(sender As System.Object, e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        If MessageBox.Show("Would you like to exit ?", "System Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = System.Windows.Forms.DialogResult.No Then
            e.Cancel = True
        End If
    End Sub

    Private Sub btnNew_Click(sender As System.Object, e As System.EventArgs) Handles btnNew.Click
        Call InitControl()
    End Sub

    Private Sub btnCopy_Click(sender As System.Object, e As System.EventArgs) Handles btnCopy.Click
        If id_yarnchange > 0 Then
            If MessageBox.Show("Would you like to copy ?", "System Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = System.Windows.Forms.DialogResult.Yes Then
                Dim bom_usage_code As String = config.IsNull(cboBOMUsage.SelectedValue, "01")
                Call CopyData(id_yarnchange, bom_usage_code)
            End If
        End If
    End Sub

    Private Sub btnSave_Click(sender As System.Object, e As System.EventArgs) Handles btnSave.Click
        If MessageBox.Show("Would you like to save ?", "System Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = System.Windows.Forms.DialogResult.Yes Then
            Call SaveData()
        End If
    End Sub

    Private Sub btnPrint_Click(sender As System.Object, e As System.EventArgs) Handles btnPrint.Click
        Const rptFileName = "rptYarnChange.rpt"
        clsUser.ReportPath = ""
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
        rpt.SetParameterValue("@id_yarnchange", id_yarnchange)
        rpt.SetParameterValue("@design_no", "")
        rpt.SetParameterValue("@ynchgcd", "")

        frm.Title = "Design BOM"
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

    Private Sub cboDesignBOM_DropDownClosed(sender As System.Object, e As System.EventArgs) Handles cboDesignBOM.DropDownClosed
        Dim strDesignBOM As String = config.IsNull(cboDesignBOM.ComboBox.SelectedValue, "")
        If strDesignBOM.Length > 0 Then
            Call LoadData(strDesignBOM)
        End If
    End Sub

    Private Sub grdData_CellEndEdit(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles grdData.CellEndEdit
        If grdData.Columns(e.ColumnIndex).Name.Equals("ynperc") Then
            txtTotalNotRound.Text = CalTotalYarn()
        End If
    End Sub

    Private Sub grdData_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles grdData.KeyDown
        If e.KeyCode = Keys.Delete Then
            If grdData.Rows.Count > 2 Then
                If MessageBox.Show("Would you like to delete yarn code " & Chr(34) & grdData.CurrentRow.Cells("itcd").Value & Chr(34) & " ?", "System Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = System.Windows.Forms.DialogResult.Yes Then
                    'MessageBox.Show(grdData.CurrentRow.Cells("id_yarnchangedet").Value)
                    Call DeleteData(grdData.CurrentRow.Cells("id_yarnchangedet").Value)
                    'grdData.Rows.RemoveAt(grdData.CurrentRow.Index)
                    Dim strDesignBOM As String = config.IsNull(cboDesignBOM.ComboBox.SelectedValue, "")
                    Call LoadData(strDesignBOM)
                End If
            Else
                MessageBox.Show("Last Row Deletion is not allowed." & vbCrLf & "ไม่อนุญาตให้ลบบรรทัดสุดท้าย !!!", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            End If
        End If
    End Sub
End Class