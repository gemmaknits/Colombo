Public Class frmGreigeOut
    Dim config As New clsConfig
    Dim clsUser As New classUserInfo
    Dim dbStockG As New classStockG

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
        Call GenCombo()
        txtRackNo.Text = ""
        txtDFNo.Text = ""
        txtRollNo.Text = ""
        txtOutNo.Text = ""
        grdData.DataSource = Nothing

        txtOutNo.Enabled = True
        txtDFNo.Enabled = True
        txtRollNo.Enabled = False

        Call CalculateTotal()
        txtRackNo.Focus()
    End Sub

    Private Sub DisableControl()
        txtOutNo.Enabled = False
        txtDFNo.Enabled = False
        txtRollNo.Enabled = True
        txtRollNo.Focus()
    End Sub

    Private Sub BindData(ByVal dt As DataTable)
        txtOutNo.Text = dt.Rows(0)("outno").ToString()
        txtDFNo.Text = dt.Rows(0)("dfno").ToString()

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

    Private Function GetGOutByDF(ByVal strOutno As String, ByVal strDFNo As String) As Boolean
        Dim StrMessage As String = ""
        Dim dt As DataTable = dbStockG.GetGOutByDF(strOutno, strDFNo, clsUser.UserID, StrMessage)
        If dt.Rows.Count > 0 Then
            Call BindData(dt)
            Return True
        Else
            MessageBox.Show(StrMessage, "System Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End If

    End Function

    Private Function GetGOutByOutNo(ByVal strOutno As String, ByVal strDFNo As String) As Boolean
        Dim dt As DataTable = dbStockG.GetGOutByOutNo(strOutno, clsUser.UserID)
        If dt.Rows.Count > 0 Then
            Call BindData(dt)
            Return True
        End If
        Return False
    End Function

    Private Function FindRollNo(strRollNo As String)
        Dim dt As DataTable = grdData.DataSource

        For Each dr As DataRow In dt.Rows
            If strRollNo.Equals(dr("roll_no_g").ToString().Trim) Or strRollNo.Equals(dr("roll_no_o").ToString().Trim) Then
                dr("selected") = 1
                Call CalculateTotal()
                Return True
            End If
        Next

        Return False
    End Function

    Private Function FindMissingRollNo() As SelectedRollNo
        Dim dt As DataTable = grdData.DataSource
        Dim strRollNo As String = ""
        Dim found As Integer = 0

        For Each dr As DataRow In dt.Rows
            If dr("selected") = 0 Then
                strRollNo = dr("roll_no_g").ToString()
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
        Dim unselectedKgs As Single = 0
        Dim unselectedMts As Single = 0
        Dim unselectedYds As Single = 0

        Dim selectedRolls As Single = 0
        Dim selectedKgs As Single = 0
        Dim selectedMts As Single = 0
        Dim selectedYds As Single = 0

        If Not dt Is Nothing Then
            For Each dr As DataRow In dt.Rows
                If dr("selected") = 0 Then
                    unselectedRolls += 1
                    unselectedKgs += dr("outkg_g")
                    unselectedMts += dr("outmt_g")
                    unselectedYds += dr("outyd_g")
                Else
                    selectedRolls += 1
                    selectedKgs += dr("outkg_g")
                    selectedMts += dr("outmt_g")
                    selectedYds += dr("outyd_g")
                End If
            Next
        End If

        txtUnselectedRolls.Text = unselectedRolls.ToString
        txtUnselectedKgs.Text = unselectedKgs.ToString
        txtUnselectedMts.Text = unselectedMts.ToString
        txtUnselectedYds.Text = unselectedYds.ToString

        txtSelectedRolls.Text = selectedRolls.ToString
        txtSelectedKgs.Text = selectedKgs.ToString
        txtSelectedMts.Text = selectedMts.ToString
        txtSelectedYds.Text = selectedYds.ToString
    End Sub

    Private Sub frmGreigeOut_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
        Call InitControl()
    End Sub

    Private Sub btnNew_Click(sender As System.Object, e As System.EventArgs) Handles btnNew.Click
        Call InitControl()
    End Sub

    Private Sub btnSave_Click(sender As System.Object, e As System.EventArgs) Handles btnSave.Click


        If MessageBox.Show("Would you like to save ?", "System Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = DialogResult.Yes Then
            Dim findResult As SelectedRollNo = FindMissingRollNo()

            'If findResult = SelectedRollNo.NoSelection Then
            '    MessageBox.Show("You need to select at least 1 roll.", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
            '    Exit Sub
            'End If

            'If findResult = SelectedRollNo.PartialSelection Then
            '    If MessageBox.Show("Would you like to make partial shipment?", "System Message", MessageBoxButtons.YesNo, MessageBoxIcon.Error) = Windows.Forms.DialogResult.No Then Exit Sub
            'End If

            If findResult <> SelectedRollNo.SelectAll Then
                MessageBox.Show("คุณเลือกผ้าไม่ครบ !!", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            End If

            Dim dt As DataTable = grdData.DataSource

            Try
                If dbStockG.SaveGOut(dt, txtRackNo.Text, clsUser.UserID) Then
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



    Private Sub btnPrint_Click(sender As System.Object, e As System.EventArgs) Handles btnPrint.Click
        'MessageBox.Show("Access Denied.", "System Messaage", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        If txtOutNo.Text.Trim.Length = 0 Then Exit Sub
        Const rptFileName = "rptGOUT.rpt"
        Dim clsConfig As New clsConfig
        Dim clsConn As New classConnection
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

    Private Sub btnCancel_Click(sender As System.Object, e As System.EventArgs) Handles btnCancel.Click
        If txtOutNo.Text.Trim.Length = 0 Then Exit Sub

        If MessageBox.Show("Would you like to cancel G-Out No." + txtOutNo.Text.Trim + " ?", "System Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            Dim ErrorMessage As String = ""
            If dbStockG.CancelGOut(txtOutNo.Text.Trim, clsUser.UserID, ErrorMessage) Then
                MessageBox.Show(txtOutNo.Text.Trim + " is already cancelled.", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show(ErrorMessage, "System Message", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
            End If
        End If

    End Sub

    Private Sub btnExit_Click(sender As System.Object, e As System.EventArgs) Handles btnExit.Click
        If MessageBox.Show("Would you like to exit ?", "System Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then Me.Close()
    End Sub

    Private Sub cboDocNo_DropDownClosed(sender As System.Object, e As System.EventArgs) Handles cboDocNo.DropDownClosed
        Dim strOutNo As String = Trim(New clsConfig().IsNull(cboDocNo.ComboBox.SelectedValue, ""))
        'Dim strDFNo As String = 
        If strOutNo.Length > 0 Then
            'Call GetGOutByOutNo(strOutno:=strOutNo, strDFNo:=String.Empty)
            Call GetGOutByDF(strOutno:=strOutNo, strDFNo:=String.Empty)
            Call DisableControl()
            Call CalculateTotal()
        End If
    End Sub

    Private Sub txtDFNo_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles txtDFNo.KeyDown
        If e.KeyCode.Equals(Keys.Enter) Then
            If GetGOutByDF(strOutno:=String.Empty, strDFNo:=txtDFNo.Text) Then
                Call DisableControl()
                Call CalculateTotal()
            Else
                Call InitControl()
            End If
        End If
    End Sub

    Private Sub txtRollNo_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles txtRollNo.KeyDown
        If e.KeyCode.Equals(Keys.Enter) Then
            If txtRollNo.Text = "NEW" Then
                Call btnNew_Click(sender, e)
                Exit Sub
            End If

            If txtOutNo.Text.Trim.Length = 0 Then Call FindRollNo(txtRollNo.Text.ToUpper)

            txtRollNo.Text = ""
            txtRollNo.Focus()
        End If
    End Sub

    Private Sub txtRackNo_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles txtRackNo.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtDFNo.Focus()
        End If
    End Sub

    Private Sub txtDFNo_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtDFNo.TextChanged

    End Sub

    Private Sub txtOutNo_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles txtOutNo.KeyDown

    End Sub

    Private Sub txtOutNo_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtOutNo.TextChanged

    End Sub

    Private Sub cboDocNo_Click(sender As System.Object, e As System.EventArgs) Handles cboDocNo.Click

    End Sub

    Private Sub txtRollNo_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtRollNo.TextChanged

    End Sub
End Class