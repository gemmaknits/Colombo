Public Class frmYarnOutBarcode

    Dim config As New clsConfig
    Dim clsUser As New classUserInfo
    Dim dbStockY As New classYarnOutBarcode

    Public Property UserInfo() As classUserInfo
        Get
            UserInfo = clsUser
        End Get
        Set(ByVal NewValue As classUserInfo)
            clsUser = NewValue
        End Set
    End Property

    Private Enum SelectedRollNo
        NoSelection = 0
        PartialSelection = 1
        SelectAll = 2
    End Enum

    Private Sub InitControl()
        Dim obj As Control
        For Each obj In Me.Controls
            Call SetControlValue(obj)
        Next
        Call EnabledControl(True)

        Call GenCombo()

        lblCancelled.Visible = False

        txtRackNo.Text = ""
        txtJobno.Text = ""
        txtBoxNo.Text = ""
        txtOutNo.Text = ""
        grdData.DataSource = Nothing

        txtOutNo.Enabled = True
        txtJobno.Enabled = True
        txtBoxNo.Enabled = True
        txtRemark.Text = ""
        Call CalculateTotal()
        'txtRackNo.Focus()
        txtJobno.Focus()
    End Sub


    Private Sub SetControlValue(ByVal Obj As Control)
        If TypeOf Obj Is TextBox Then
            If Obj.Tag = "str" Then Obj.Text = ""
            If Obj.Tag = "int" Then Obj.Text = "0.00"
        End If
        If TypeOf Obj Is DateTimePicker Then
            Dim dtp As DateTimePicker = Obj
            dtp.Value = Now
        End If
        If TypeOf Obj Is ComboBox Then
            Dim cbo As ComboBox = Obj
            cbo.SelectedValue = ""
        End If
        If TypeOf Obj Is TabControl Or TypeOf Obj Is TabPage Or TypeOf Obj Is GroupBox Then
            Dim obj2 As Control
            For Each obj2 In Obj.Controls
                Call SetControlValue(obj2)
            Next
        End If
    End Sub
    Private Sub DisableControl()
        txtOutNo.Enabled = False
        txtJobno.Enabled = False
        txtBoxNo.Focus()
    End Sub

    Private Sub BindData(ByVal dt As DataTable)
        Dim clsconfig As New clsConfig

        txtOutNo.Text = dt.Rows(0)("outno").ToString()
        If txtOutNo.Text.Trim.Length > 0 Then cboDocNo.Text = dt.Rows(0)("outno").ToString.Trim()
        txtJobno.Text = dt.Rows(0)("refdocno").ToString() 'Jobno
        txtRemark.Text = dt.Rows(0)("rem")

        grdData.AutoGenerateColumns = False
        grdData.DataSource = dt

        If clsconfig.IsNull(dt.Rows(0)("cancel").ToString, False) = True Then
            lblCancelled.Visible = True
            Call EnabledControl(False)
        End If


        'If dt.Rows(0)("cancel_by").ToString.Trim.Length > 0 Then
        'lblCancelled.Visible = True
        'Call EnabledControl(False)
        'End If
    End Sub
    Private Sub EnabledControl(ByVal blnEnabled As Boolean)
        Dim obj As Control
        For Each obj In Me.Controls
            Call SetControlEnabled(obj, blnEnabled)
        Next
        'cboCustomer.Enabled = False
        'cboAgent.Enabled = False
        'cboReceiver.Enabled = False
        btnSave.Enabled = blnEnabled
        btnCancel.Enabled = blnEnabled
    End Sub

    Private Sub SetControlEnabled(ByVal Obj As Control, ByVal blnEnabled As Boolean)
        If TypeOf Obj Is TextBox Then Obj.Enabled = blnEnabled
        If TypeOf Obj Is DateTimePicker Then Obj.Enabled = blnEnabled
        If TypeOf Obj Is ComboBox Then Obj.Enabled = blnEnabled
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

    Private Sub GenCombo()
        Dim dt As DataTable = dbStockY.GetComboYOut()
        cboDocNo.ComboBox.DataSource = dt
        cboDocNo.ComboBox.DisplayMember = "outno"
        cboDocNo.ComboBox.ValueMember = "outno"
        cboDocNo.ComboBox.SelectedIndex = -1

        Dim tblItems As New tbl_Items
        Dim getDatayarn As New GetDataYarn
        Dim ds As New DataSet
        tblItems.itcd = ""
        ds = getDatayarn.GetDataItem(tblItems)
        If Not IsNothing(ds) Then
            Me.itcd.DataSource = ds.Tables(0)
            Me.itcd.DisplayMember = "itdesc4"
            Me.itcd.ValueMember = "Itcd"

        End If
    End Sub
    Private Sub insertcomboitemcode()
        Dim tblItems As New tbl_Items
        Dim getDatayarn As New GetDataYarn
        Dim ds As New DataSet
        tblItems.itcd = ""
        ds = getDatayarn.GetDataItem(tblItems)
        If Not IsNothing(ds) Then
            Me.itcd.DataSource = ds.Tables(0)
            Me.itcd.DisplayMember = "itdesc"
            Me.itcd.ValueMember = "Itcd"

        End If
    End Sub

    Private Function GetYOutByJOB(ByVal strJobNo As String, ByVal strOutno As String) As Boolean
        Dim dt As DataTable = dbStockY.GetYOutByJob(strJobNo:=strJobNo, strOutno:=strOutno, strlogempcd:=clsUser.UserID)
        If dt.Rows.Count > 0 Then
            Call BindData(dt)
            Return True
        End If
        Return False
    End Function

    Private Function FindBoxNo(strBoxNo As String)
        Dim dt As DataTable = grdData.DataSource

        For Each dr As DataRow In dt.Rows
            If strBoxNo.Equals(dr("boxno").ToString().Trim) Or strBoxNo.Equals(dr("boxno").ToString().Trim) Then
                dr("selected") = 1
                Call CalculateTotal()
                Return True
            End If
        Next

        Return False
    End Function

    Private Function FindMissingBoxNo() As SelectedRollNo
        Dim dt As DataTable = grdData.DataSource
        Dim strRollNo As String = ""
        Dim found As Integer = 0

        For Each dr As DataRow In dt.Rows
            If dr("selected") = 0 Then
                strRollNo = dr("boxno").ToString()
            Else
                found += 1
            End If
        Next

        If found = 0 Then Return SelectedRollNo.NoSelection
        If strRollNo.Length > 0 Then Return SelectedRollNo.PartialSelection
        Return SelectedRollNo.SelectAll
    End Function

    Private Sub CalculateTotal()
        Dim dt As DataTable = grdData.DataSource

        Dim unselectedRolls As Integer = 0
        Dim unselectedkg_nt As Single = 0
        Dim unselectedkg_gr As Single = 0
        Dim unselectedspools As Single = 0

        Dim selectedRolls As Single = 0
        Dim selectedkg_nt As Single = 0
        Dim selectedkg_gr As Single = 0
        Dim selectedspools As Single = 0

        If Not dt Is Nothing Then
            For Each dr As DataRow In dt.Rows
                If dr("selected") = 0 Then
                    unselectedRolls += 1
                    unselectedkg_nt += dr("kg_nt")
                    unselectedkg_gr += dr("kg_gr")
                    unselectedspools += dr("spools")
                Else
                    selectedRolls += 1
                    selectedkg_nt += dr("kg_nt")
                    selectedkg_gr += dr("kg_gr")
                    selectedspools += dr("spools")
                End If
            Next
        End If

        txtUnselectedBoxs.Text = unselectedRolls.ToString
        txtUnselectedkg_nt.Text = unselectedkg_nt.ToString
        txtUnselectedkg_gr.Text = unselectedkg_gr.ToString
        txtUnselectedSpools.Text = unselectedspools.ToString

        txtSelectedBoxs.Text = selectedRolls.ToString
        txtSelectedkg_nt.Text = selectedkg_nt.ToString
        txtSelectedkg_gr.Text = selectedkg_gr.ToString
        txtSelectedSpools.Text = selectedspools.ToString
    End Sub

    Private Sub frmGreigeOut_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
        Call InitControl()
    End Sub

    Private Sub btnNew_Click(sender As System.Object, e As System.EventArgs) Handles btnNew.Click
        Call InitControl()
    End Sub

    Private Sub btnSave_Click(sender As System.Object, e As System.EventArgs) Handles btnSave.Click

        If Not CheckData() Then Exit Sub

        If MessageBox.Show("Would you like to save ?", "System Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = DialogResult.Yes Then
            Dim findResult As SelectedRollNo = FindMissingBoxNo()

            If findResult <> SelectedRollNo.SelectAll Then
                MessageBox.Show("คุณเลือกด้ายไม่ครบ !!", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            End If

            Dim clsconfig As New clsConfig
            Dim dt As DataTable = grdData.DataSource
            Dim yarn_out As New classYarnOutBarcode.Yarn_out


            yarn_out.outno = txtOutNo.Text.Trim 'clsconfig.IsNull(dt.Rows(0)("outno"), "")
            yarn_out.outdt = clsconfig.IsNull(dt.Rows(0)("outdt"), Nothing)
            yarn_out.tran_type = clsconfig.IsNull(dt.Rows(0)("tran_type"), Nothing)
            yarn_out.refdocno = clsconfig.IsNull(dt.Rows(0)("refdocno"), Nothing)
            yarn_out.suppcd = clsconfig.IsNull(dt.Rows(0)("suppcd"), Nothing)
            yarn_out.kono = clsconfig.IsNull(dt.Rows(0)("kono"), Nothing)
            yarn_out.[rem] = clsconfig.IsNull(txtRemark.Text.Trim, Nothing)
            yarn_out.cancel = clsconfig.IsNull(dt.Rows(0)("cancel"), Nothing)
            yarn_out.tstamp = clsconfig.IsNull(dt.Rows(0)("tstamp"), Nothing)
            yarn_out.present_status = clsconfig.IsNull(dt.Rows(0)("present_status"), Nothing)
            yarn_out.locked = clsconfig.IsNull(dt.Rows(0)("locked"), Nothing)

            yarn_out.packno = clsconfig.IsNull(dt.Rows(0)("packno"), Nothing)
            yarn_out.packdt = clsconfig.IsNull(dt.Rows(0)("packdt"), Nothing)
            yarn_out.cartno = clsconfig.IsNull(dt.Rows(0)("cartno"), Nothing)
            'Try
            If dbStockY.SaveYOut(yarn_out, dt, txtRackNo.Text, clsUser) Then
                Call GenCombo()
                Call InitControl()

                txtOutNo.Text = yarn_out.outno.Trim
                Call GetYOutByJOB(strJobNo:="", strOutno:=txtOutNo.Text.Trim)
                Call DisableControl()
                Call CalculateTotal()
                'End If

                MessageBox.Show("Save Completed.", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else

                MessageBox.Show(yarn_out.Message, "System Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
            'Catch ex As Exception
            'MessageBox.Show(ex.Message, "System Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
            'End Try
        End If
    End Sub

    Public Function CheckData() As Boolean

        If Not (New classYarnOut).ValidateJobno(StrJobno:=txtJobno.Text.Trim) Then
            MessageBox.Show("JobNo :" & txtJobno.Text.Trim & "InCorrect", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.ErrorProvider1.SetError(Me.txtJobno, "JobNo :" & txtJobno.Text.Trim & "InCorrect")
            Return False
        Else
            Me.ErrorProvider1.Clear()
            'Return True  'Sitthana 06/03/2018
        End If


        Return True  'Sitthana 06/03/2018
    End Function

    Private Sub btnPrint_Click(sender As System.Object, e As System.EventArgs) Handles btnPrint.Click
        'MessageBox.Show("Access Denied.", "System Messaage", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        If txtOutNo.Text.Trim.Length = 0 Then Exit Sub
        Dim dt As DataTable = grdData.DataSource
        Dim rptFileName As String
        rptFileName = "RptYarnOut.rpt"
        'Hard Code
        If dt.Rows(0)("tran_type").ToString.Trim = "WARPING" Then
            rptFileName = "RptYarnOut.rpt"
        ElseIf dt.Rows(0)("tran_type").ToString.Trim = "KNITTING" Then
            rptFileName = "RptYarnOutKnitting.rpt"
        End If

        'Const rptFileName = "RptYarnOut.rpt"
        Dim clsConfig As New clsConfig
        Dim clsConn As New classConnection
        If clsUser.ReportPath = "" Then clsUser.ReportPath = clsuser.reportpath
        If Not clsConfig.CheckReport(clsUser.ReportPath, rptFileName) Then Exit Sub
        Dim frm As New frmReport
        Dim rpt As New CrystalDecisions.CrystalReports.Engine.ReportDocument
        Dim logonInfo As New CrystalDecisions.Shared.TableLogOnInfo
        Me.Cursor = Cursors.WaitCursor
        logonInfo.ConnectionInfo.ServerName = clsConn.ServerName
        logonInfo.ConnectionInfo.DatabaseName = clsConn.Database
        logonInfo.ConnectionInfo.IntegratedSecurity = False
        logonInfo.ConnectionInfo.UserID = clsConn.UserName
        logonInfo.ConnectionInfo.Password = clsConn.Password

        rpt.Load(clsUser.ReportPath & rptFileName)
        rpt.DataSourceConnections.Item(0).SetConnection(clsConn.ServerName, clsConn.Database, False)
        rpt.DataSourceConnections.Item(0).SetLogon(clsConn.UserName, clsConn.Password)
        rpt.VerifyDatabase() '
        rpt.SetParameterValue("@outno", txtOutNo.Text.Trim)
        'rpt.SetParameterValue("@outnofr", txtOutNo.Text.Trim)
        'rpt.SetParameterValue("@outnoto", txtOutNo.Text.Trim)
        'rpt.SetParameterValue("@outdtfr", "")
        'rpt.SetParameterValue("@outdtto", "")

        'rpt.PrintOptions.PaperSize = CrystalDecisions.Shared.PaperSize.PaperA4
        'rpt.PrintOptions.PaperOrientation = CrystalDecisions.Shared.PaperOrientation.Portrait
        'rpt.PrintOptions.PaperSource = CrystalDecisions.Shared.PaperSource.Auto

        frm.Title = "Greige Out"
        frm.CRViewer.ReportSource = rpt
        frm.MdiParent = Me.ParentForm
        frm.Show()
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub btnCancel_Click(sender As System.Object, e As System.EventArgs) Handles btnCancel.Click
        If txtOutNo.Text.Trim.Length = 0 Then Exit Sub

        If MessageBox.Show("Would you like to cancel G-Out No." + txtOutNo.Text.Trim + " ?", "System Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            If dbStockY.CancelYOut(txtOutNo.Text.Trim, clsUser.UserID) Then
                MessageBox.Show(txtOutNo.Text.Trim + " is already cancelled.", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Call InitControl()
            End If
        End If
    End Sub

    Private Sub btnExit_Click(sender As System.Object, e As System.EventArgs) Handles btnExit.Click
        If MessageBox.Show("Would you like to exit ?", "System Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then Me.Close()
    End Sub

    Private Sub cboDocNo_DropDownClosed(sender As System.Object, e As System.EventArgs) Handles cboDocNo.DropDownClosed
        Dim clsconfig As New clsConfig
        Dim strOutNo As String = Trim(New clsConfig().IsNull(cboDocNo.ComboBox.SelectedValue, ""))

        If strOutNo.Length > 0 Then
            Call GetYOutByJOB(strJobNo:="", strOutno:=strOutNo)
            Call DisableControl()
            Call CalculateTotal()
        End If
    End Sub

    Private Sub txtDFNo_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles txtJobno.KeyDown
        ' txtJobno.Text.Trim.Length = 0 

        If e.KeyCode.Equals(Keys.Enter) Then
            If GetYOutByJOB(strJobNo:=txtJobno.Text.Trim, strOutno:="") Then
                Call DisableControl()
                Call CalculateTotal()
            Else
                Call InitControl()
            End If
        End If
    End Sub

    Private Function CheckDataJob() As Boolean

        If Not Validate_JobNoAlreadyUse() Then
            Return False
        End If

        If (New classYarnOut).ValitateJobNoAlreadyKOClosed(StrJobno:=txtJobno.Text.Trim) Then
            MessageBox.Show("ไม่สามารถ Yarn Out ได้ เนื่องจาก Production Order ถูก Closed ไปแล้ว", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button3)
            Return False
        End If

        Return True
    End Function

    Private Function Validate_JobNoAlreadyUse(Optional ByVal StrJobno As String = "") As Boolean
        Dim objdb As New classYarnOut
        Dim dt As DataTable = objdb.ValidateJobNoAlreadyOut(StrJobno, StrEmpcd:=clsUser.UserID)

        If dt.Rows.Count > 0 Then
            MessageBox.Show("Job No .: " & StrJobno & "............   is Already Out!! For Outno : " & dt.Rows(0)("outno").ToString, "SyStem Messsage", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return False
        Else
            Return True
        End If


    End Function

    Private Sub txtRollNo_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles txtBoxNo.KeyDown
        If e.KeyCode.Equals(Keys.Enter) Then
            If txtBoxNo.Text = "NEW" Then
                Call btnNew_Click(sender, e)
                Exit Sub
            End If

            If txtOutNo.Text.Trim.Length = 0 Then Call FindBoxNo(txtBoxNo.Text)

            txtBoxNo.Text = ""
            txtBoxNo.Focus()
        End If
    End Sub

    Private Sub txtRackNo_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles txtRackNo.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtJobno.Focus()
        End If
    End Sub

    Private Sub txtOutNo_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles txtOutNo.KeyDown
        If e.KeyCode = Keys.Enter Then
            Dim clsconfig As New clsConfig
            Dim strOutNo As String = Trim(New clsConfig().IsNull(txtOutNo.Text.Trim, ""))

            If strOutNo.Length > 0 Then
                Call GetYOutByJOB(strJobNo:="", strOutno:=strOutNo)
                Call DisableControl()
                Call CalculateTotal()
            End If
        End If
    End Sub

    Private Sub txtOutNo_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtOutNo.TextChanged

    End Sub

    Private Sub cboDocNo_Click(sender As System.Object, e As System.EventArgs) Handles cboDocNo.Click

    End Sub

    Private Sub txtJobno_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtJobno.TextChanged

    End Sub

    Private Sub txtRollNo_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtBoxNo.TextChanged

    End Sub

    Private Sub ToolStrip1_ItemClicked(sender As System.Object, e As System.Windows.Forms.ToolStripItemClickedEventArgs) Handles ToolStrip1.ItemClicked

    End Sub
End Class