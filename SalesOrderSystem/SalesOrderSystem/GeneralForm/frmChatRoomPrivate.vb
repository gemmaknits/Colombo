Imports System.Text
Imports System.Data
Imports System.Data.SqlClient

Public Class frmChatRoomPrivate
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

	Public Sub StartChatRoom()
		clsChatroom.StartServer(clsUser.UserName, clsUser.IPAddress, 8001)
	End Sub

	Private Sub GenCombo()
		cboOnlineUser.DataSource = clsChatroom.GetOnlineUser
		cboOnlineUser.DisplayMember = "username"
		cboOnlineUser.ValueMember = "ip_address"
		cboOnlineUser.SelectedIndex = 0
	End Sub

	Private Sub GenGrid()
		Dim da As New SqlDataAdapter("select '" & clsUser.UserName & "' as username,'" & clsUser.IPAddress & "' as ip_address, 0 as flag", (New classConnection).connection)
		Dim dt As New DataTable
		da.Fill(dt)
		grdOnlineUser.AutoGenerateColumns = False
		grdOnlineUser.DataSource = dt
	End Sub

	Private Sub VerifyGrid()
		Dim dt As DataTable = cboOnlineUser.DataSource
		Dim dt2 As DataTable = grdOnlineUser.DataSource
		Dim i, j As Integer
		For i = 0 To dt2.Rows.Count - 1
			If dt2.Rows(i).RowState <> DataRowState.Deleted Then
				dt2.Rows(i)("flag") = 0
				For j = 0 To dt.Rows.Count - 1
					If dt2.Rows(i)("username") = dt.Rows(j)("username") Then dt2.Rows(i)("flag") = 1
				Next
			End If
		Next
	End Sub

	Private Sub frmChatRoomPrivate_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
		Call GenCombo()
		Call GenGrid()
	End Sub

	Private Sub frmChatRoomPrivate_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
		clsChatroom.StopServer()
	End Sub

	Private Sub clsChatroom_RaiseMessage(ByVal sender As classChatRoom, ByVal strMessage As String) Handles clsChatroom.RaiseMessage
		Me.Parent.Focus()
		Me.WindowState = FormWindowState.Normal
		Me.Focus()
		Select Case strMessage.Substring(0, strMessage.IndexOf(":") + 1).ToUpper()
			Case "&ERROR:"
				strMessage = clsConfig.IsNull(cboOnlineUser.Text, "") & " is offline."
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

	Private Sub btnLoad_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLoad.Click
		Dim strIP As String = ""
		strIP = clsConfig.IsNull(cboOnlineUser.SelectedValue, "")
		Call GenCombo()
		cboOnlineUser.SelectedValue = strIP
		If cboOnlineUser.SelectedIndex < 0 Then
			cboOnlineUser.SelectedIndex = 0
			MessageBox.Show("คู่สนทนาที่ท่านเลือกได้ออกจากระบบส่วนตัวไปแล้ว", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Hand, MessageBoxDefaultButton.Button1)
			Exit Sub
		End If
		If clsConfig.IsNull(cboOnlineUser.Text, "") = clsUser.UserName Then Exit Sub
		Dim dt As DataTable = grdOnlineUser.DataSource
		Dim i As Integer = 0
		For i = 0 To dt.Rows.Count - 1
			If dt.Rows(i)("username").ToString = clsConfig.IsNull(cboOnlineUser.Text, "") Then Exit Sub
		Next
		Dim dr As DataRow = dt.NewRow
		dr("username") = clsConfig.IsNull(cboOnlineUser.Text, "")
		dr("ip_address") = clsConfig.IsNull(cboOnlineUser.SelectedValue, "")
		dr("flag") = 1
		dt.Rows.Add(dr)
	End Sub

	Private Sub btnSend_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSend.Click
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
		Call VerifyGrid()
		cboOnlineUser.SelectedValue = strIP
		If clsConfig.IsNull(cboOnlineUser.SelectedValue, "") = "" Or cboOnlineUser.SelectedIndex < 0 Then cboOnlineUser.SelectedIndex = 0

		Dim dt As DataTable = grdOnlineUser.DataSource
		Dim i As Integer = 0
		Dim clsSend() As classSendMessage
		ReDim clsSend(dt.Rows.Count)

		If dt.Rows.Count > 0 Then
			For i = 0 To dt.Rows.Count - 1
				If dt.Rows(i)("flag") = 1 Then
					If clsConfig.IsNull(dt.Rows(i)("username"), "") <> "" And clsConfig.IsNull(dt.Rows(i)("username"), "") <> clsUser.UserName Then
						If clsConfig.IsNull(dt.Rows(i)("ip_address"), "") <> "" Then
							clsSend(i) = New classSendMessage
							clsSend(i).LocalUser = clsChatroom.LocalUser
							clsSend(i).LocalIP = clsChatroom.LocalIP
							clsSend(i).LocalPort = 8001
							clsSend(i).RemoteUser = dt.Rows(i)("username")
							clsSend(i).RemoteIP = dt.Rows(i)("ip_address")
							clsSend(i).RemotePort = 8001
							clsSend(i).SendMessage(txtSendMessage.Text.Trim)
						End If
					End If
				End If
			Next
		End If
		Me.Message = clsUser.UserName & " : " & txtSendMessage.Text.Trim
		strOldMessage = txtSendMessage.Text
		txtSendMessage.Text = ""
	End Sub

	Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
		txtShowMessage.Text = ""
		txtSendMessage.Text = ""
	End Sub

	Private Sub txtSendMessage_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtSendMessage.KeyDown
		If e.KeyCode = Keys.Enter And e.Control = True Then
			Call btnSend_Click(sender, e)
			e.SuppressKeyPress = True
		End If
		If e.KeyCode = Keys.C And e.Control = True Then Call btnClear_Click(sender, e)
		If e.KeyCode = Keys.Down Then txtSendMessage.Text = strOldMessage
	End Sub

	Private Sub grdOnlineUser_UserDeletingRow(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewRowCancelEventArgs) Handles grdOnlineUser.UserDeletingRow
		If e.Row.Index = 0 Then e.Cancel = True
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