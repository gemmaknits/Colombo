Imports System.Data
Imports System.Data.SqlClient
Imports System.Net
Imports System.Net.Sockets
Imports System.Text
Imports MSWinsockLib

Public Class classChatRoom
	Public Event RaiseMessage(ByVal sender As classChatRoom, ByVal strMessage As String)
	Private pLocalUser As String = My.Computer.Name
	Private pLocalIP As String = Net.Dns.GetHostAddresses(My.Computer.Name)(0).ToString
	Private pLocalPort As Integer = 8000
	Private pRemoteUser As String = pLocalUser
	Private pRemoteIP As String = pLocalIP
	Private pRemotePort As Integer = pLocalPort
	Private pFilename As String = "c:\test.txt"
	Private WithEvents WinsockListen As New MSWinsockLib.Winsock
	Private WithEvents WinsockServer As New MSWinsockLib.Winsock
	Private WithEvents WinsockClient As New MSWinsockLib.Winsock
	Private intRequestID As Integer = 0
	Private pMessage As String = ""
	Private intLoopCount As Integer = 0

	Public Property LocalUser() As String
		Get
			LocalUser = pLocalUser
		End Get
		Set(ByVal NewValue As String)
			pLocalUser = NewValue
		End Set
	End Property


	Public ReadOnly Property LocalIP() As String
		Get
			LocalIP = pLocalIP
		End Get
	End Property

	Public ReadOnly Property LocalPort() As Integer
		Get
			LocalPort = pLocalPort
		End Get
	End Property

	Public ReadOnly Property RemoteUser() As String
		Get
			RemoteUser = pRemoteUser
		End Get
	End Property

	Public ReadOnly Property RemoteIP() As String
		Get
			RemoteIP = pRemoteIP
		End Get
	End Property

	Public ReadOnly Property RemotePort() As Integer
		Get
			RemotePort = pRemotePort
		End Get
	End Property

	Public ReadOnly Property Filename() As String
		Get
			Filename = pFilename
		End Get
	End Property

	Public Function GetOnlineUser() As DataTable
		Dim conn As New SqlConnection((New classConnection).connection)
		Dim comm As New SqlCommand("", conn)
		comm.CommandType = CommandType.StoredProcedure
		comm.CommandText = "p_user_online"
		Dim da As New SqlDataAdapter(comm)
		Dim dt As New DataTable
		da.Fill(dt)
		Return dt
	End Function

	'Private Sub PostMessage(ByVal strMessage As String)
	'	Dim f As System.IO.File
	'	Dim writer As System.IO.StreamWriter
	'	If f.Exists(pFilename) Then f.Delete(pFilename)
	'	writer = f.CreateText(pFilename)
	'	writer.Write(strMessage)
	'	writer.Close()
	'End Sub

	'Private Function GetMessage() As String
	'	Dim f As System.IO.File
	'	Dim fs As System.IO.FileStream = f.OpenRead(pFilename)
	'	Dim b(1024) As Byte
	'	Dim temp As New UTF8Encoding(True)
	'	Dim info As String = ""
	'	Do While fs.Read(b, 0, b.Length) > 0
	'		info = info & temp.GetString(b)
	'	Loop
	'	fs.Close()
	'	Return info
	'End Function

	Public Function BuildMessage(ByVal strUser As String, ByVal strMessage As String) As String
		BuildMessage = strUser & " : " & Trim(strMessage)
	End Function

	Private Sub WinsockListen_ConnectionRequest(ByVal requestID As Integer) Handles WinsockListen.ConnectionRequest
		intRequestID = requestID
		WinsockServer.Accept(intRequestID)
	End Sub

	Private Sub WinsockListen_Error(ByVal Number As Short, ByRef Description As String, ByVal Scode As Integer, ByVal Source As String, ByVal HelpFile As String, ByVal HelpContext As Integer, ByRef CancelDisplay As Boolean) Handles WinsockListen.Error
		RaiseEvent RaiseMessage(Me, "&Error:" & Description)
	End Sub

	Private Sub WinsockServer_DataArrival(ByVal bytesTotal As Integer) Handles WinsockServer.DataArrival
		Dim strMessage As String = ""
		WinsockServer.GetData(strMessage, vbString)
		WinsockServer.Close()
		RaiseEvent RaiseMessage(Me, strMessage)
	End Sub

	Private Sub WinsockServer_Error(ByVal Number As Short, ByRef Description As String, ByVal Scode As Integer, ByVal Source As String, ByVal HelpFile As String, ByVal HelpContext As Integer, ByRef CancelDisplay As Boolean) Handles WinsockServer.Error
		RaiseEvent RaiseMessage(Me, "&Error:" & Description)
	End Sub

	Private Sub WinsockClient_Connect() Handles WinsockClient.Connect
		Dim strMessage As String = pMessage
		Dim strCommand As String = ""
		If Left(pMessage, 1) = "&" Then
			strCommand = strMessage.Substring(0, strMessage.IndexOf(":") + 1).ToUpper()
			strMessage = BuildMessage(pLocalUser, strMessage.Substring(strMessage.IndexOf(":") + 1))
			strMessage = strCommand & strMessage
		Else
			strMessage = BuildMessage(pLocalUser, strMessage)
		End If
		Call WinsockClient.SendData(strMessage)
	End Sub

	Private Sub WinsockClient_SendComplete() Handles WinsockClient.SendComplete
		WinsockClient.Close()
		RaiseEvent RaiseMessage(Me, BuildMessage(pLocalUser, IIf(Left(pMessage, 1) = "&", pMessage.Substring(pMessage.IndexOf(":") + 1), pMessage)))
	End Sub

	Private Sub WinsockClient_Error(ByVal Number As Short, ByRef Description As String, ByVal Scode As Integer, ByVal Source As String, ByVal HelpFile As String, ByVal HelpContext As Integer, ByRef CancelDisplay As Boolean) Handles WinsockClient.Error
		RaiseEvent RaiseMessage(Me, "&Error:" & Description)
	End Sub

	Public Function StartServer(ByVal strLocalUser As String, ByVal strLocalIP As String, ByVal intLocalPort As Integer) As Boolean
		On Error GoTo ErrExit
		If strLocalUser <> "" Then pLocalUser = strLocalUser
		If strLocalIP <> "" Then pLocalIP = strLocalIP
		If intLocalPort <> 0 Then pLocalPort = intLocalPort
		WinsockListen.Protocol = ProtocolConstants.sckTCPProtocol
		WinsockListen.LocalPort = pLocalPort
		WinsockListen.Listen()
		RaiseEvent RaiseMessage(Me, BuildMessage(pLocalUser, "I'm online."))
		Return True
ErrExit:
		Return False
	End Function

	Public Sub StopServer()
		WinsockServer.Close()
		WinsockListen.Close()
	End Sub

	Public Function SendMessage(ByVal strRemoteUser As String, ByVal strRemoteIP As String, ByVal intRemotePort As Integer, ByVal strMessage As String) As Boolean
		Dim i As Integer = 0
		If strRemoteUser <> "" Then pRemoteUser = strRemoteUser
		If strRemoteIP <> "" Then pRemoteIP = strRemoteIP
		If intRemotePort <> 0 Then pRemotePort = intRemotePort
		If WinsockClient.State <> MSWinsockLib.StateConstants.sckClosed Then WinsockClient.Close()
		pMessage = strMessage
		WinsockClient.Connect(pRemoteIP, pRemotePort)
	End Function

	Public Sub ShowMessageWindow(ByVal strTitle As String, _
		ByVal strMessage As String, _
		Optional ByVal intStyle As Integer = 1, _
		Optional ByVal strImgPath As String = "\\calista-server\Program\Images\", _
		Optional ByVal blnCloseButtonClickEnabled As Boolean = True, _
		Optional ByVal blnTitleClickEnabled As Boolean = False, _
		Optional ByVal blnTextClickEnabled As Boolean = True, _
		Optional ByVal blnDrawTextFocusRect As Boolean = True, _
		Optional ByVal blnKeepVisibleOnMouseOver As Boolean = True, _
		Optional ByVal blnReShowOnMouseOver As Boolean = True, _
		Optional ByVal intOpenDelay As Integer = 500, _
		Optional ByVal intShowDelay As Integer = 3000, _
		Optional ByVal intHideDelay As Integer = 500)

		Dim taskbarNotifier1 As New TaskBarNotifier
		Dim img As Bitmap
		Dim img2 As Bitmap

		If intStyle = 2 Then
			img = New Bitmap(strImgPath & "skin2.bmp")
			img2 = New Bitmap(strImgPath & "close2.bmp")
			taskbarNotifier1.SetBackgroundBitmap(img, Color.FromArgb(255, 0, 255))
			taskbarNotifier1.SetCloseBitmap(img2, Color.FromArgb(255, 0, 255), New Point(300, 74))
			taskbarNotifier1.TitleRectangle = New Rectangle(123, 80, 176, 16)
			taskbarNotifier1.TextRectangle = New Rectangle(116, 97, 197, 22)
		ElseIf intStyle = 3 Then
			img = New Bitmap(strImgPath & "skin3.bmp")
			img2 = New Bitmap(strImgPath & "close.bmp")
			taskbarNotifier1.SetBackgroundBitmap(img, Color.FromArgb(255, 0, 255))
			taskbarNotifier1.SetCloseBitmap(img2, Color.FromArgb(255, 0, 255), New Point(280, 57))
			taskbarNotifier1.TitleRectangle = New Rectangle(150, 57, 125, 28)
			taskbarNotifier1.TextRectangle = New Rectangle(75, 92, 215, 55)
			taskbarNotifier1.NormalTitleColor = Color.Black
			taskbarNotifier1.HoverTitleColor = Color.Black
			taskbarNotifier1.NormalContentColor = Color.Yellow
			taskbarNotifier1.HoverContentColor = Color.White
		Else
			img = New Bitmap(strImgPath & "skin.bmp")
			img2 = New Bitmap(strImgPath & "close.bmp")
			taskbarNotifier1.SetBackgroundBitmap(img, Color.FromArgb(255, 0, 255))
			taskbarNotifier1.SetCloseBitmap(img2, Color.FromArgb(255, 0, 255), New Point(127, 8))
			taskbarNotifier1.TitleRectangle = New Rectangle(40, 9, 70, 25)
			taskbarNotifier1.TextRectangle = New Rectangle(8, 41, 133, 68)
		End If


		With taskbarNotifier1
			.CloseButtonClickEnabled = blnCloseButtonClickEnabled
			.TitleClickEnabled = blnTitleClickEnabled
			.TextClickEnabled = blnTextClickEnabled
			.DrawTextFocusRect = blnDrawTextFocusRect
			.KeepVisibleOnMouseOver = blnKeepVisibleOnMouseOver
			.ReShowOnMouseOver = blnReShowOnMouseOver
			.Show(strTitle, _
			   strMessage, _
			   Integer.Parse(intOpenDelay), _
			   Integer.Parse(intShowDelay), _
			   Integer.Parse(intHideDelay))
		End With
	End Sub
End Class
