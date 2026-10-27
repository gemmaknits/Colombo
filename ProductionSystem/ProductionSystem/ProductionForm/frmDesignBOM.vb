Public Class frmDesignBOM
    Dim config As New clsConfig
    Dim clsConn As New classConnection
    Dim clsUser As New classUserInfo
    Dim id_yarnchange As Integer = 0
    Dim Design_no As String
    Dim strBomNo As String = ""
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

        Call GenComboDesignBOM()
        Call GenCombo()

        Dim obj As Control
        For Each obj In Me.Controls
            Call SetControlValue(obj)
        Next

        Call EnabledControl(True)
        id_yarnchange = 0
        dtpBOMDate.Value = Now
        Call LoadData(0)
        Me.cboBOMUsage.SelectedValue = "PROD"
        cboBOMUsage.Enabled = False

        ErrorProvider1.Clear()

        txtDesignNo.Focus()


    End Sub

    Private Sub GenCombo()
        Dim objDB As New classMaster

        Me.cboBOMUsage.DataSource = objDB.comboBOMUsage(clsUser.UserID)
        Me.cboBOMUsage.DisplayMember = "bom_usage_name"
        Me.cboBOMUsage.ValueMember = "bom_usage_code"
        Me.cboBOMUsage.SelectedIndex = 0
        Me.cboBOMUsage.SelectedValue = "PROD"

        Me.itcd.DataSource = objDB.comboYarn(clsUser.UserID)
        Me.itcd.DisplayMember = "itcd2"
        Me.itcd.ValueMember = "itcd"

        'Me.itdesc.DataSource = objDB.comboYarn(clsUser.UserID)
        'Me.itdesc.DisplayMember = "itdesc"
        'Me.itdesc.ValueMember = "itdesc"

        Me.suppcd.DataSource = objDB.comboSupplier(clsUser.UserID)
        Me.suppcd.DisplayMember = "name"
        Me.suppcd.ValueMember = "suppcd"

        Me.cbodesign_ver.DataSource = objDB.comboDesign(clsUser.UserID)
        Me.cbodesign_ver.DisplayMember = "design_no"
        Me.cbodesign_ver.ValueMember = "design_no"
        'Me.cbodesign_ver.AutoCompleteCustomSource = True
        Me.cbodesign_ver.SelectedIndex = -1
    End Sub

    Private Sub GenComboDesignBOM()
        Dim objDB As New classMaster

        Me.cboDesignBOM.ComboBox.DataSource = objDB.comboYarnChange(clsUser.UserID)
        Me.cboDesignBOM.ComboBox.DisplayMember = "design_bom"
        Me.cboDesignBOM.ComboBox.ValueMember = "id_yarnchange"
        'Me.cboDesignBOM.ComboBox.SelectedIndex = 0

       
    End Sub

    Private Sub BindData(ByVal dt As DataTable)
        id_yarnchange = Val(dt.Rows(0)("id_yarnchange"))
        txtDesignNo.Text = dt.Rows(0)("design_no")
        dtpBOMDate.Value = dt.Rows(0)("ynchgdt2")
        txtBOMCode.Text = dt.Rows(0)("ynchgcd")
        txtRemark.Text = dt.Rows(0)("remarke")
        cboBOMUsage.SelectedValue = dt.Rows(0)("bom_usage_code")
        txtTotalWithRound.Text = CDbl(dt.Rows(0)("sum_perc"))
        chkApproved.Checked = CBool(dt.Rows(0)("bom_approved"))
        chkEnabled.Checked = CBool(dt.Rows(0)("bom_active"))

        cbodesign_ver.SelectedValue = dt.Rows(0)("design_ver")
        txtBom_remarks.Text = (New clsConfig).IsNull(dt.Rows(0)("bom_remarks"), "")
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
        Call SumgrdData()
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
        'objBOM.bom_remarks = ""
        objBOM.bom_remarks = RTrim(cbodesign_ver.SelectedValue.ToString) + ""
        objBOM.design_ver = cbodesign_ver.SelectedValue

        If objDB.YarnChangeUpdate(objBOM, grdData.DataSource, clsUser.UserID, errmsg) Then
            ErrorProvider1.Clear()
            Call GenComboDesignBOM()
            'Call InitControl()
            'Dim strDesignBOM As String = config.IsNull(objBOM.id_yarnchange, "")

            'If strDesignBOM.Length > 0 Then Call LoadData(strDesignBOM)
            Call LoadData(objBOM.id_yarnchange)
            'End If
            MessageBox.Show("Save Completed", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            MessageBox.Show(errmsg, "System Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Function

    Private Function CancelData() As Boolean



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



        If objDB.YarnChangeCancel(objBOM, grdData.DataSource, clsUser.UserID, errmsg) Then
            'Call GenComboDesignBOM()
            Call InitControl()
            Call GenComboDesignBOM()
            ' Dim strDesignBOM As String = config.IsNull(objBOM.id_yarnchange, "")

            'If strDesignBOM.Length > 0 Then
            'Call LoadData(strDesignBOM)
            'End If
            MessageBox.Show("Cancel Completed", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
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
    Private Sub SumgrdData()
        Dim config As New clsConfig
        Dim i As Integer = 0
        Dim total1 As Double = 0
        
        For i = 0 To grdData.Rows.Count - 1
            total1 = total1 + config.IsNull(grdData.Rows(i).Cells("ynperc").Value, 0)
        Next
        txtTotalNotRound.Text = FormatNumber(total1, 0, TriState.False, TriState.False, TriState.True)

    End Sub

    Private Sub frmDesignBOM_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Call InitControl()
       

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

        Dim clsconfig As New clsConfig

        For Each obj In Me.Controls
            Call FixControlDataError(obj)
        Next

        If Not CheckData() Then Exit Sub

        If cbodesign_ver.SelectedValue = Nothing Then
            If txtDesignNo.Text.Substring(1, 2) = "20" Then
                MessageBox.Show("If You are not select Design Ver , Program is Genareate Automatic", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
                cbodesign_ver.SelectedValue = txtDesignNo.Text.Trim
            End If
            
        End If

        If MessageBox.Show("Would you like to save ?", "System Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = System.Windows.Forms.DialogResult.Yes Then
            Call SaveData()
        End If
    End Sub

    Private Sub FixControlDataError(ByVal obj As Control)

        If TypeOf obj Is DataGridView Then
            Dim DGV As DataGridView = obj
            If Not DGV.DataSource Is Nothing Then
                If DGV.Rows.Count > 0 And grdData.Focused Then
                    If DGV.CurrentCell.IsInEditMode Then
                        Dim cell As DataGridViewCell = DGV.CurrentCell
                        DGV.EndEdit(DataGridViewDataErrorContexts.Commit)
                        DGV.CurrentCell = grdData.Rows(0).Cells(0)
                        DGV.CurrentCell = cell
                    End If
                End If
            End If
        End If


    End Sub

    Private Function CheckData() As Boolean

        Dim clsconfig As New clsConfig

        If txtDesignNo.Text = "" Then
            MessageBox.Show("Please check PROD. Item Before Saving", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ErrorProvider1.SetError(txtDesignNo, "Please check PROD. Item Before Saving")
            CheckData = False
            Exit Function
        End If

        If Not Validate_Design_no() Then
            MessageBox.Show("PROD. Item : " & Design_no & "............   Item Not Valid!!")
            ErrorProvider1.SetError(txtDesignNo, "PROD. Item : " & txtDesignNo.Text.Trim & "............   Item Not Valid!!")
            CheckData = False
            Exit Function
        End If

        If clsconfig.IsNull(txtTotalNotRound.Text, 0) <> 100 Then
            MessageBox.Show("Please check Percent Before Saving", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ErrorProvider1.SetError(txtTotalNotRound, "Please check Percent Before Saving")
            CheckData = False
            Exit Function
        End If

        'Check Data In Grid
        For i = 0 To grdData.Rows.Count - 2
            If (New clsConfig).IsNull(grdData.Rows(i).Cells("ynperc").Value(), 0) = 0 Then
                MessageBox.Show("Please check Item Percent In Grid Before Saving should be not zero", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
                ErrorProvider1.SetError(grdData, "Please check Item Percent In Grid Before Saving should be not zero")
                CheckData = False
                Exit Function
            End If
        Next

        CheckData = True

    End Function

    Private Sub btnPrint_Click(sender As System.Object, e As System.EventArgs) Handles btnPrint.Click

        'Const rptFileName = "rptYarnChange.rpt"
        ''If clsuser.ReportPath = "" Then clsuser.ReportPath = clsConfig.ReportPath
        'If Not config.CheckReport(clsUser.ReportPath, rptFileName) Then Exit Sub
        'Dim frm As New frmReport
        'Dim rpt As New CrystalDecisions.CrystalReports.Engine.ReportDocument
        'Dim stype As String = ""
        'Dim ord As String = ""
        'Me.Cursor = Cursors.WaitCursor

        'rpt.Load(clsUser.ReportPath & rptFileName)
        'rpt.DataSourceConnections.Item(0).SetConnection(clsConn.servername, clsConn.database, False)
        'rpt.DataSourceConnections.Item(0).SetLogon(clsConn.Userid, clsConn.Password)
        'rpt.VerifyDatabase()
        'rpt.SetParameterValue("@id_yarnchange", id_yarnchange)
        'rpt.SetParameterValue("@design_no", "")
        'rpt.SetParameterValue("@ynchgcd", "")

        'frm.Title = "Design BOM"
        'frm.CRViewer.ReportSource = rpt
        'frm.MdiParent = Me.ParentForm
        'frm.Show()
        'Me.Cursor = Cursors.Default



        '------------------
        Dim frm As New frmReport
        Dim rpt As New CrystalDecisions.CrystalReports.Engine.ReportDocument
        Dim rptFileName As String

        If id_yarnchange = 0 Then

            rptFileName = "rptMasterBom.rpt"
            'If clsuser.ReportPath = "" Then clsuser.ReportPath = clsConfig.ReportPath
            If Not config.CheckReport(clsUser.ReportPath, rptFileName) Then Exit Sub
            rpt.Load(clsUser.ReportPath & rptFileName)
            rpt.DataSourceConnections.Item(0).SetConnection(clsConn.servername, clsConn.database, False)
            rpt.DataSourceConnections.Item(0).SetLogon(clsConn.Userid, clsConn.Password)
            rpt.VerifyDatabase()
            rpt.SetParameterValue("@id_yarnchange", id_yarnchange)
            rpt.SetParameterValue("@design_no", "")
            rpt.SetParameterValue("@ynchgcd", "")
        Else
            rptFileName = "rptYarnChange.rpt"
            'If clsuser.ReportPath = "" Then clsuser.ReportPath = clsConfig.ReportPath
            If Not config.CheckReport(clsUser.ReportPath, rptFileName) Then Exit Sub
            rpt.Load(clsUser.ReportPath & rptFileName)
            rpt.DataSourceConnections.Item(0).SetConnection(clsConn.servername, clsConn.database, False)
            rpt.DataSourceConnections.Item(0).SetLogon(clsConn.Userid, clsConn.Password)
            rpt.VerifyDatabase()
            rpt.SetParameterValue("@id_yarnchange", id_yarnchange)
            rpt.SetParameterValue("@design_no", "")
            rpt.SetParameterValue("@ynchgcd", "")
        End If

        frm.Title = "Design Bom"
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

    Private Sub grdData_CellClick(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles grdData.CellClick
        Call SumgrdData()
    End Sub

    Private Sub grdData_CellEndEdit(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles grdData.CellEndEdit

        If grdData.Columns(e.ColumnIndex).Name.Equals("ynperc") Then
            'Call SumgrdData()
        End If
        Call SumgrdData()
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
        Call SumgrdData()
    End Sub

    Private Sub ToolStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles ToolStrip1.ItemClicked

    End Sub


    'Private Sub btnsearch_Click(sender As Object, e As EventArgs)
    '    MessageBox.Show("Under Construction")
    'End Sub

   
    Private Sub txtDesignNo_LostFocus(sender As Object, e As EventArgs) Handles txtDesignNo.LostFocus
        Design_no = txtDesignNo.Text
        If Design_no = "" Then Exit Sub
        'If Not Validate_Design_no() Then
        'MessageBox.Show("PROD. Item : " & Design_no & "............   Item Not Valid!!")
        'txtDesignNo.Focus()
        'txtDesignNo.Text = ""
        'Exit Sub

        ' End If

    End Sub

    Private Function Validate_Design_no() As Boolean
        Dim objDB As New classProduction
        Dim dt As DataTable = objDB.ValidateDesignNo(txtDesignNo.Text.Trim, clsUser.UserID)

        If dt.Rows.Count = 0 Then
            Return False
        End If
        Return True
    End Function
   

    Private Sub txtDesignNo_Validated(sender As Object, e As System.EventArgs) Handles txtDesignNo.Validated
        Validate_Design_no()
    End Sub
    'EDIT BY NEUNG 16/01/2015
    'Private Sub getItdesc()
    '    Dim objGetITdesc As New classProduction
    '    Dim dt As DataTable
    '    ' Dim txtkono As String = ""
    '    Dim txtitcd As String = itcd.DataSource
    '    'Validate_kono()
    '    dt = objGetITdesc.getitdesc1("itcd", "logempcd")
    '    If dt.Rows.Count > 0 Then
    '        grdData.Columns(e.ColumnIndex).Name.Equals("itcd") = dt.Rows(0)("itcd")

    '        'Else
    '        ' MsgBox("Prod no. is not found", MsgBoxStyle.OkOnly, "Search")

    '    End If
    'End Sub
    'EDIT BY NEUNG 16/01/2015

    Private Sub cboDesignBOM_Click(sender As System.Object, e As System.EventArgs) Handles cboDesignBOM.Click

    End Sub

    Private Sub grdData_CellContentClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles grdData.CellContentClick

    End Sub

    Private Sub grdData_CellStyleContentChanged(sender As Object, e As System.Windows.Forms.DataGridViewCellStyleContentChangedEventArgs) Handles grdData.CellStyleContentChanged

    End Sub

    Private Sub txtDesignNo_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtDesignNo.TextChanged

    End Sub

    Private Sub txtDesignNo_QueryContinueDrag(sender As Object, e As System.Windows.Forms.QueryContinueDragEventArgs) Handles txtDesignNo.QueryContinueDrag

    End Sub

    Private Sub BtnCancel_Click(sender As System.Object, e As System.EventArgs) Handles BtnCancel.Click

        If MessageBox.Show("Would you like to Cancel ?", "System Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = System.Windows.Forms.DialogResult.Yes Then
            Call CancelData()
        End If



    End Sub

    Private Sub btnSearch_Click(sender As System.Object, e As System.EventArgs) Handles btnSearch.Click
        Dim frm As New frmSearchItems
        frm.ShowDialog(Me)
        Call btnNew_Click(sender, e)

        txtDesignNo.Text = (frm.pid_yarnchange)
        Me.Cursor = Cursors.WaitCursor
        If Not blnCancel Then LoadData(frm.pid_yarnchange)

        Me.Cursor = Cursors.Default
        frm.Dispose()
    End Sub

    Private Sub BtnDeleteStep_Click(sender As Object, e As EventArgs) Handles BtnDeleteStep.Click
        Call GetDeleteStep()
    End Sub

    Private Sub GetDeleteStep()
        If grdData.Rows.Count > 0 Then
            Dim i As Integer = 0
            Dim dt As DataTable = grdData.DataSource
            Do While i < dt.Rows.Count
                If dt.Rows.Count = 0 Then Exit Do
                For i = 0 To dt.Rows.Count - 1
                    If Not dt.Rows(i).RowState = DataRowState.Deleted Then
                        If CBool(dt.Rows(i)("chkSelect")) Then
                            dt.Rows(i).Delete()
                            Exit For
                        End If
                    End If
                Next
            Loop

        End If
    End Sub

    Private Sub cbodesign_ver_DropDownClosed(sender As Object, e As EventArgs) Handles cbodesign_ver.DropDownClosed


    End Sub

    Private Sub cbodesign_ver_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbodesign_ver.SelectedIndexChanged
        txtBom_remarks.Text = cbodesign_ver.Text.Trim
    End Sub
End Class