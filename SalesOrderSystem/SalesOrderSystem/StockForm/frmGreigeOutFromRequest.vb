Public Class frmGreigeOutFromRequest
    Dim config As New clsConfig
    Dim clsUser As New classUserInfo
    Dim dbStockG As New ClassGOUTFromREQ

    Dim blnCancel As Boolean = False

    Public Property UserInfo() As classUserInfo
        Get
            UserInfo = clsUser
        End Get
        Set(ByVal NewValue As classUserInfo)
            clsUser = NewValue
        End Set
    End Property

    Private Sub InitControl()
        txtReqNo.Text = ""
        txtOutNo.Text = ""
        grdData.DataSource = Nothing

        txtOutNo.Enabled = True
        txtReqNo.Enabled = True

        Call CalculateTotal()
        txtReqNo.Focus()
    End Sub

    Private Sub DisableControl()
        txtOutNo.Enabled = False
        txtReqNo.Enabled = False
        txtReqNo.Focus()
    End Sub

    Private Sub BindData(ByVal dt As DataTable)
        txtOutNo.Text = dt.Rows(0)("outno").ToString()
        txtReqNo.Text = dt.Rows(0)("outreqno").ToString()

        grdData.AutoGenerateColumns = False
        grdData.DataSource = dt
    End Sub

    Private Sub GenCombo()
        Dim dt As DataTable = dbStockG.GetComboGOut()
        cboDocNo.ComboBox.DataSource = dt
        cboDocNo.ComboBox.DisplayMember = "outno"
        cboDocNo.ComboBox.ValueMember = "outno"
        cboDocNo.ComboBox.SelectedIndex = -1
    End Sub

    Private Sub CalculateTotal()
        Dim dt As DataTable = grdData.DataSource

        Dim selectedRolls As Single = 0
        Dim selectedKgs As Single = 0
        Dim selectedMts As Single = 0
        Dim selectedYds As Single = 0

        If Not dt Is Nothing Then
            For Each dr As DataRow In dt.Rows
                selectedRolls += 1
                selectedKgs += dr("outkg_g")
                selectedMts += dr("outmt_g")
                selectedYds += dr("outyd_g")
            Next
        End If

        txtSelectedRolls.Text = selectedRolls.ToString
        txtSelectedKgs.Text = selectedKgs.ToString
        txtSelectedMts.Text = selectedMts.ToString
        txtSelectedYds.Text = selectedYds.ToString
    End Sub

    Private Function GetGOutByRequest(ByVal strReqNo As String) As Boolean
        Dim StrOutno As String = ""

        If Not Validate_ReqNoIsCancel(strReqNo) Then
            MessageBox.Show("Req. No : " & strReqNo & "............   Req No. is Already Cancel!!")
            Exit Function

        End If

        If Not Validate_ReqNoIsPack(strReqNo, StrOutno) Then
            MessageBox.Show("Req. No : " & strReqNo & "............   is Already Out!! For " & StrOutno)
            Exit Function

        End If

        Dim StrMessage As String = ""
        Dim dt As DataTable = dbStockG.GetGOutByRequest(strReqNo, clsUser.UserID, StrMessage)
        If dt.Rows.Count > 0 Then
            Call BindData(dt)
            Return True
        End If

        MessageBox.Show(StrMessage, "System Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Return False
    End Function

    Private Function Validate_ReqNoIsCancel(ReqNo) As Boolean
        Dim objDB As New ClassGOUTFromREQ
        Dim dt As DataTable = objDB.ValidateReqNoIsCancel(ReqNo, clsUser.UserID)

        If dt.Rows.Count = 0 Then
            Return False
        End If
        Return True
    End Function
    Private Function Validate_ReqNoIsPack(Optional ByRef ReqNo As String = "", Optional ByRef StrOutno As String = "") As Boolean
        Dim objDB As New ClassGOUTFromREQ
        Dim dt As DataTable = objDB.ValidateReqNoIsOut(ReqNo, clsUser.UserID)

        If dt.Rows.Count > 0 Then
            StrOutno = (dt.Rows(0)("outno").ToString)
            Return False
        End If
        Return True
    End Function

    Private Sub frmGreigeOutFromRequest_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized

        Call GenCombo()
        Call InitControl()
    End Sub

    Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click
        Call InitControl()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If MessageBox.Show("Would you like to save ?", "System Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = DialogResult.Yes Then
            Dim dt As DataTable = grdData.DataSource

            Try
                If dbStockG.SaveGOut(dt, "", clsUser.UserID) Then
                    Call GenCombo()
                    Call InitControl()
                    cboDocNo.ComboBox.SelectedIndex = 0
                    Call cboDocNo_DropDownClosed(sender, e)

                    MessageBox.Show("Save Completed.", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    MessageBox.Show("Data cannot be saved.", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message, "System Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        'MessageBox.Show("Access Denied.", "System Messaage", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        If txtOutNo.Text.Trim.Length = 0 Then Exit Sub
        Const rptFileName = "rptGOUT.rpt"
        Dim clsConfig As New clsConfig
        Dim clsConn As New ClassConnection
        If clsUser.ReportPath = "" Then clsUser.ReportPath = clsUser.ReportPath
        If Not clsConfig.CheckReport(clsUser.ReportPath, rptFileName) Then Exit Sub
        Dim frm As New frmReport
        Dim rpt As New CrystalDecisions.CrystalReports.Engine.ReportDocument
        Dim logonInfo As New CrystalDecisions.Shared.TableLogOnInfo
        Me.Cursor = Cursors.WaitCursor
        logonInfo.ConnectionInfo.ServerName = clsConn.servername
        logonInfo.ConnectionInfo.DatabaseName = clsConn.database
        logonInfo.ConnectionInfo.IntegratedSecurity = False
        logonInfo.ConnectionInfo.UserID = clsConn.Userid
        logonInfo.ConnectionInfo.Password = clsConn.Password

        rpt.Load(clsUser.ReportPath & rptFileName)
        rpt.DataSourceConnections.Item(0).SetConnection(clsConn.servername, clsConn.database, False)
        rpt.DataSourceConnections.Item(0).SetLogon(clsConn.Userid, clsConn.Password)
        rpt.VerifyDatabase()
        rpt.SetParameterValue("@outnofr", txtOutNo.Text.Trim)
        rpt.SetParameterValue("@outnoto", txtOutNo.Text.Trim)
        rpt.SetParameterValue("@outdtfr", "")
        rpt.SetParameterValue("@outdtto", "")

        'rpt.PrintOptions.PaperSize = CrystalDecisions.Shared.PaperSize.PaperA4
        'rpt.PrintOptions.PaperOrientation = CrystalDecisions.Shared.PaperOrientation.Portrait
        'rpt.PrintOptions.PaperSource = CrystalDecisions.Shared.PaperSource.Auto

        frm.Title = "Greige Out"
        frm.CRViewer.ReportSource = rpt
        frm.MdiParent = Me.ParentForm
        frm.Show()
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        If txtOutNo.Text.Trim.Length = 0 Then Exit Sub

        If MessageBox.Show("Would you like to cancel G-Out No." + txtOutNo.Text.Trim + " ?", "System Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            If (New classStockG).CancelGOut(txtOutNo.Text.Trim, clsUser.UserID) Then
                MessageBox.Show(txtOutNo.Text.Trim + " is already cancelled.", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub cboDocNo_DropDownClosed(sender As Object, e As EventArgs) Handles cboDocNo.DropDownClosed
        Dim strOutNo As String = Trim(New clsConfig().IsNull(cboDocNo.ComboBox.SelectedValue, ""))

        If strOutNo.Length > 0 Then
            Call GetGOutByOutNo(strOutNo)
            Call DisableControl()
            Call CalculateTotal()
        End If
    End Sub

    Private Function GetGOutByOutNo(ByVal strReqNo As String) As Boolean
        Dim dt As DataTable = dbStockG.GetGOutByOutNo(strReqNo, clsUser.UserID)
        If dt.Rows.Count > 0 Then
            Call BindData(dt)
            Return True
        End If
        Return False
    End Function

    Private Sub txtRGNo_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles txtReqNo.KeyDown

        If e.KeyCode.Equals(Keys.Enter) Then
            Call GetGOutByRequest(txtReqNo.Text)
            'Call DisableControl()
            Call CalculateTotal()
        End If

        'Dim strOutNo As String = Trim(New clsConfig().IsNull(cboDocNo.ComboBox.SelectedValue, ""))

        'If strOutNo.Length > 0 Then
        '    Call GetGOutByRequest(strOutNo)
        '    Call DisableControl()
        '    Call CalculateTotal()
        'End If
    End Sub


    Private Sub cboDocNo_Click(sender As System.Object, e As System.EventArgs) Handles cboDocNo.Click

    End Sub

    Private Sub btnSearchREQG_Click(sender As System.Object, e As System.EventArgs) Handles btnSearchREQG.Click
        Dim frm As New frmSearchREQG
        frm.pStockType = "G"
        frm.pOutReqTyp = "D"  'Fix It Later Neung 2015/10/15
        frm.ShowDialog(Me)
        'Call btnNew_Click(sender, e)
        txtReqNo.Text = (frm.pReqNo)
        Me.Cursor = Cursors.WaitCursor
        If Not blnCancel Then
            Call GetGOutByRequest(txtReqNo.Text)
            Call CalculateTotal()

        End If

        Me.Cursor = Cursors.Default
        frm.Dispose()
    End Sub

    Private Sub txtReqNo_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtReqNo.TextChanged

    End Sub
End Class