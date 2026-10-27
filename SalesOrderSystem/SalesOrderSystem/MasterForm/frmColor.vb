Public Class frmColor
	Dim clsConfig As New clsConfig
	Dim clsConn As New classConnection
	Dim clsUser As New classUserInfo

	Dim strAgCD As String = ""
	Dim blnCancel As Boolean = False
    Dim oColors As New classColors
    Public Property UserInfo() As classUserInfo
		Get
			UserInfo = clsUser
		End Get
		Set(ByVal NewValue As classUserInfo)
			clsUser = NewValue
		End Set
	End Property

	Private Function IsDataChange() As Boolean
		Dim result As Boolean = False
		Dim dt As DataTable = grdColor.DataSource

		Dim dv_add As New DataView(dt, "", "", DataViewRowState.Added)
		If dv_add.Count > 0 Then result = True

		Dim dv_upd As New DataView(dt, "", "", DataViewRowState.ModifiedCurrent)
		If dv_upd.Count > 0 Then result = True

		IsDataChange = result
	End Function

	Private Sub LoadData()
        ' Dim objDB As New classMaster
        Dim dt As DataTable
		grdColor.AutoGenerateColumns = False
        dt = oColors.GetColor()
        'Comment By Sitthana 20190307
        'For i As Integer = 0 To dt.Rows.Count - 1
        '    If dt.Rows(i)("labsubdt") = "01/01/1900" Then
        '        dt.Rows(i)("labsubdt") = ""
        '    End If
        '    If dt.Rows(i)("labappdt") = "01/01/1900" Then
        '        dt.Rows(i)("labappdt") = ""
        '    End If
        'Next
        grdColor.DataSource = dt
    End Sub

	Private Function SaveData() As Boolean
		Dim master As New classMasterUpdate
		Dim msgerr As String = ""
		Dim dt As DataTable = grdColor.DataSource

        Dim labsubdt As String = ""
        Dim labappdt As String = ""

        For i As Integer = 0 To dt.Rows.Count - 1
            labsubdt = dt.Rows(i)("labsubdt").ToString.Trim
            If labsubdt <> "" And (Not IsDate(labsubdt) Or labsubdt.Length < 10) Then
                MsgBox("Wrong date entered for lab sub date", MsgBoxStyle.Critical, "Date error")
                Exit Function
            Else
                If labsubdt <> "" Then
                    labsubdt = labsubdt.Substring(6, 4) + labsubdt.Substring(3, 2) + labsubdt.Substring(0, 2)
                End If
            End If

            labappdt = dt.Rows(i)("labappdt").ToString.Trim
            If labappdt <> "" And (Not IsDate(labappdt) Or labappdt.Length < 10) Then
                MsgBox("Wrong date entered for lab app date", MsgBoxStyle.Critical, "Date error")
                Exit Function
            Else
                If labappdt <> "" Then
                    labappdt = labappdt.Substring(6, 4) + labappdt.Substring(3, 2) + labappdt.Substring(0, 2)
                End If
            End If
        Next

        Dim dv_add As New DataView(dt, "", "", DataViewRowState.Added)
        Dim dv_upd As New DataView(dt, "", "", DataViewRowState.ModifiedCurrent)

        If Not oColors.ColorSave(dv_add, dv_upd, msgerr) Then
            MessageBox.Show(msgerr, "System Message", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
            SaveData = False
        Else
            SaveData = True
		End If
	End Function

	Private Sub frmColor_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        GenCombo()
        LoadData()

	End Sub

	Private Sub frmColor_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
		If IsDataChange() Then Call btnSave_Click(sender, e)
		e.Cancel = blnCancel
	End Sub

	Private Sub btnNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNew.Click
		Dim strCol As String = InputBox("จะใส่สีใหม่ให้ดูสีเก่าก่อนว่ามีหรือไม่" & vbCrLf & "ถ้าไม่มีก็ใส่รหัสสีลงช่องข้างล่างเลย" & vbCrLf & "รหัสสีมีได้สูงสุด 10 ตัวเท่านั้น" & vbCrLf & "( ให้ใช้เครื่องหมาย + แทน / )", "System Message", "").Trim.ToUpper
		If strCol.Trim.Length = 0 Then Exit Sub
		Dim dt As DataTable = grdColor.DataSource
		Dim i As Integer = 0
		For i = 0 To dt.Rows.Count - 1
			If dt.Rows(i)("col").ToString.Trim.ToUpper = strCol Then
				MessageBox.Show("รหัสสี " & strCol.Trim & " มีอยู่แล้วในระบบ", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
				Exit Sub
			End If
		Next

		Dim dr As DataRow = dt.NewRow()
		dr("col") = strCol
		dr("colname") = strCol
		dr("base_col") = ""
		dt.Rows.Add(dr)
	End Sub

	Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
		Dim strCol As String = InputBox("What color would you like to find ?" & vbCrLf & "คุณต้องการหาสีอะไร ?", "System Message", "").Trim.ToUpper
		If strCol.Trim.Length = 0 Then Exit Sub
		Dim i As Integer = 0
		For i = 0 To grdColor.Rows.Count - 1
			If grdColor.Rows(i).Cells("col").Value.ToString.Trim.ToUpper = strCol Then
				grdColor.CurrentCell = grdColor(0, i)
				Exit Sub
			End If
			If grdColor.Rows(i).Cells("colname").Value.ToString.Trim.ToUpper = strCol Then
				grdColor.CurrentCell = grdColor(1, i)
				Exit Sub
			End If
		Next
	End Sub

	Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
		blnCancel = False
        'Sitthana 20220624 Changed Windows.Forms.DialogResult To DialogResult
        Dim result As DialogResult ' Windows.Forms.DialogResult
        result = MessageBox.Show("Would you like to save ?", "System Message", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button3)
        If result = DialogResult.Cancel Then blnCancel = True
        If result <> DialogResult.Yes Then Exit Sub
        Me.Cursor = Cursors.WaitCursor
        grdColor.EndEdit()
		If SaveData() Then
			LoadData()
		End If
		Me.Cursor = Cursors.Default
	End Sub

	Private Sub btnPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrint.Click
		Const rptFileName = "rptMasterColor.rpt"
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

		frm.Title = "Color Master"
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

    Private Sub GenCombo()
        Dim objDB As New classMaster

        Me.colCustcd.DataSource = objDB.GetCustomer
        Me.colCustcd.DisplayMember = "name"
        Me.colCustcd.ValueMember = "new_custcd"
    End Sub

End Class