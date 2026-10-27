Imports System.Text
Imports System.Data
Imports System.Data.SqlClient

Public Class frmChatRoom
	Public TrayIcon As NotifyIcon
	Private WithEvents clsChatroom As New classChatRoom
	Dim clsConfig As New clsConfig
	Dim clsUser As New classUserInfo
	Dim pMessage As String = ""
	Dim strOldMessage As String = ""
	Dim intMessageWindowStyle As Integer = 1

	Public Property UserInfo() As classUserInfo
		Get
			UserInfo = clsUser
		End Get
		Set(ByVal NewValue As classUserInfo)
			clsUser = NewValue
			clsChatroom.LocalUser = clsUser.UserName
		End Set
	End Property

	Public Property Message() As String
		Get
			Message = pMessage
		End Get
		Set(ByVal NewValue As String)
			pMessage = NewValue
			txtShowMessage.Text = txtShowMessage.Text & vbCrLf & pMessage
			txtShowMessage.Select(txtShowMessage.Text.Length, 0)
			txtShowMessage.ScrollToCaret()
		End Set
	End Property

	Public Function StartChatRoom() As Boolean
		Return clsChatroom.StartServer(clsUser.UserName, clsUser.IPAddress, 0)
	End Function

	Private Sub GenCombo()
		cboOnlineUser.DataSource = clsChatroom.GetOnlineUser
		cboOnlineUser.DisplayMember = "username"
		cboOnlineUser.ValueMember = "ip_address"
		cboOnlineUser.SelectedIndex = 0
	End Sub

	Private Sub frmChatRoom_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
		Call GenCombo()
	End Sub

	Private Sub frmChatRoom_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
		If Me.ParentForm.Tag = "CLOSE" Or Me.MdiParent.Tag = "CLOSE" Then
			clsChatroom.StopServer()
		Else
			e.Cancel = True
			Me.WindowState = FormWindowState.Minimized
		End If
	End Sub

	Private Sub clsChatroom_RaiseMessage(ByVal sender As classChatRoom, ByVal strMessage As String) Handles clsChatroom.RaiseMessage
		Me.Parent.Focus()
		Me.WindowState = FormWindowState.Normal
		Me.Focus()
		Select Case strMessage.Substring(0, strMessage.IndexOf(":") + 1).ToUpper()
			Case "&ERROR:"
				strMessage = clsConfig.IsNull(cboOnlineUser.Text, "") & " is offline."
			Case "&ALERT:"
				strMessage = strMessage.Substring(strMessage.IndexOf(":") + 1)
				MessageBox.Show(strMessage.Substring(strMessage.IndexOf(":") + 1), "System Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
				txtSendMessage.Focus()
			Case "&ABX:" 'Ask Before eXit
				If MessageBox.Show("Do you want to exit application ?" & vbCrLf & "คุณต้องการออกจากโปรแกรม SalesOrderSystem หรือไม่ ?", "System Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then
					Me.MdiParent.Close()
					Exit Sub
				Else
					Exit Sub
				End If
			Case "&END:"
				Me.MdiParent.Close()
			Case Else
				If strMessage.Substring(0, 1) = "&" And InStr(":", strMessage) > 0 Then strMessage = strMessage.Substring(strMessage.IndexOf(":") + 1)
		End Select
		Me.Message = strMessage
		If Me.MdiParent.Tag = "HIDE" Then
			'TrayIcon.BalloonTipIcon = ToolTipIcon.Info
			'TrayIcon.BalloonTipTitle = "New Message"
			'TrayIcon.BalloonTipText = strMessage
			'TrayIcon.ShowBalloonTip(1)
			clsChatroom.ShowMessageWindow("New Message", strMessage, intMessageWindowStyle, clsUser.ImagePath)
		End If
	End Sub

	Private Sub btnSend_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSend.Click
		Select Case txtSendMessage.Text.Trim.ToUpper
			Case "&CLEAR:"
				Call btnClear_Click(sender, e)
				Exit Sub
			Case "&EXIT:"
				If MessageBox.Show("Do you want to exit application ?" & vbCrLf & "คุณต้องการออกจากโปรแกรม SalesOrderSystem หรือไม่ ?", "System Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then
					Me.MdiParent.Close()
					Exit Sub
				Else
					Exit Sub
				End If
			Case Else
				'a
		End Select
		Dim strIP As String = clsConfig.IsNull(cboOnlineUser.SelectedValue, "")
		If strIP <> "" Then Call clsChatroom.SendMessage(clsConfig.IsNull(cboOnlineUser.Text, ""), clsConfig.IsNull(cboOnlineUser.SelectedValue, ""), 0, Trim(txtSendMessage.Text))
		Call GenCombo()
		cboOnlineUser.SelectedValue = strIP
		If clsConfig.IsNull(cboOnlineUser.SelectedValue, "") = "" Or cboOnlineUser.SelectedIndex < 0 Then cboOnlineUser.SelectedIndex = 0
		strOldMessage = txtSendMessage.Text
		txtSendMessage.Text = ""
	End Sub

	Private Sub btnSendAll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSendAll.Click
		Select Case txtSendMessage.Text.Trim.ToUpper
			Case "&CLEAR:"
				Call btnClear_Click(sender, e)
				Exit Sub
			Case "&EXIT:"
				If MessageBox.Show("Do you want to exit application ?" & vbCrLf & "คุณต้องการออกจากโปรแกรม SalesOrderSystem หรือไม่ ?", "System Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then
					Me.MdiParent.Close()
				Else
					Exit Sub
				End If
			Case Else
				'a
		End Select

		Dim strIP As String = clsConfig.IsNull(cboOnlineUser.SelectedValue, "")
		Call GenCombo()
		cboOnlineUser.SelectedValue = strIP
		If clsConfig.IsNull(cboOnlineUser.SelectedValue, "") = "" Or cboOnlineUser.SelectedIndex < 0 Then cboOnlineUser.SelectedIndex = 0

		Dim dt As DataTable = cboOnlineUser.DataSource
		Dim i As Integer = 0
		Dim clsSend() As classSendMessage
		ReDim clsSend(dt.Rows.Count)

		If dt.Rows.Count > 0 Then
			For i = 0 To dt.Rows.Count - 1
				If clsConfig.IsNull(dt.Rows(i)("username"), "") <> "" And clsConfig.IsNull(dt.Rows(i)("username"), "") <> clsUser.UserName Then
					If clsConfig.IsNull(dt.Rows(i)("ip_address"), "") <> "" Then
						clsSend(i) = New classSendMessage
						clsSend(i).LocalUser = clsChatroom.LocalUser
						clsSend(i).LocalIP = clsChatroom.LocalIP
						clsSend(i).LocalPort = clsChatroom.LocalPort
						clsSend(i).RemoteUser = dt.Rows(i)("username")
						clsSend(i).RemoteIP = dt.Rows(i)("ip_address")
						clsSend(i).RemotePort = clsChatroom.RemotePort
						clsSend(i).SendMessage(txtSendMessage.Text.Trim)
					End If
				End If
			Next
		End If
		Me.Message = clsUser.UserName & " : " & txtSendMessage.Text.Trim
		strOldMessage = txtSendMessage.Text
		txtSendMessage.Text = ""
	End Sub

	Private Sub btnAlert_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAlert.Click
		Dim strIP As String = clsConfig.IsNull(cboOnlineUser.SelectedValue, "")
		If strIP <> "" Then Call clsChatroom.SendMessage(clsConfig.IsNull(cboOnlineUser.Text, ""), clsConfig.IsNull(cboOnlineUser.SelectedValue, ""), 0, "&ALERT:" & Trim(txtSendMessage.Text))
		Call GenCombo()
		cboOnlineUser.SelectedValue = strIP
		If clsConfig.IsNull(cboOnlineUser.SelectedValue, "") = "" Or cboOnlineUser.SelectedIndex < 0 Then cboOnlineUser.SelectedIndex = 0
		strOldMessage = txtSendMessage.Text
		txtSendMessage.Text = ""
	End Sub

	Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
		txtShowMessage.Text = ""
		txtSendMessage.Text = ""
	End Sub

	Private Sub txtSendMessage_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtSendMessage.KeyDown
		If e.KeyCode = Keys.Enter And e.Control = False And e.Shift = False Then Call btnSend_Click(sender, e)
		If e.KeyCode = Keys.Enter And e.Shift = True Then Call btnSendAll_Click(sender, e)
		If e.KeyCode = Keys.Enter And e.Control = True Then Call btnAlert_Click(sender, e)
		If e.KeyCode = Keys.C And e.Control = True Then Call btnClear_Click(sender, e)
		If e.KeyCode = Keys.Down Then txtSendMessage.Text = strOldMessage
	End Sub

	Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click
		Dim obj As Form
		For Each obj In Me.MdiParent.MdiChildren
			If obj.Name = "frmChatRoomPrivate" Then
				MessageBox.Show("Private Chat Room เปิดอยู่แล้ว", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
				Exit Sub
			End If
		Next

		Dim frm As New frmChatRoomPrivate
		frm.MdiParent = Me.MdiParent
		frm.UserInfo = clsUser
		frm.TrayIcon = TrayIcon
		frm.StartChatRoom()
		frm.Show()
	End Sub

	Private Sub PictureBox1_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox1.MouseEnter
		ToolTip1.IsBalloon = True
		ToolTip1.ToolTipIcon = ToolTipIcon.Info
		ToolTip1.ToolTipTitle = "Tips :"
		ToolTip1.SetToolTip(PictureBox1, "Click Here For Private Chat Room")
	End Sub

	Private Sub btnChangeWindowStyle_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnChangeWindowStyle.Click
		If btnChangeWindowStyle.Text = "1" Then
			btnChangeWindowStyle.Text = "2"
		ElseIf btnChangeWindowStyle.Text = "2" Then
			btnChangeWindowStyle.Text = "3"
		Else
			btnChangeWindowStyle.Text = "1"
		End If
		intMessageWindowStyle = Val(btnChangeWindowStyle.Text)
	End Sub
End Class