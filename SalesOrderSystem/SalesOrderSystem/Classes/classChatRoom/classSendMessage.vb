Imports System.Data
Imports System.Data.SqlClient
Imports System.Net
Imports System.Net.Sockets
Imports System.Text
Imports MSWinsockLib

Public Class classSendMessage
	Private pLocalUser As String = ""
	Private pLocalIP As String = ""
	Private pLocalPort As Integer = 0
	Private pRemoteUser As String = pLocalUser
	Private pRemoteIP As String = pLocalIP
	Private pRemotePort As Integer = pLocalPort
	Private WithEvents WinsockClient As New MSWinsockLib.Winsock
	Private pMessage As String = ""

	Public Property LocalUser() As String
		Get
			LocalUser = pLocalUser
		End Get
		Set(ByVal NewValue As String)
			pLocalUser = NewValue
		End Set
	End Property


	Public Property LocalIP() As String
		Get
			LocalIP = pLocalIP
		End Get
		Set(ByVal NewValue As String)
			pLocalIP = NewValue
		End Set
	End Property

	Public Property LocalPort() As Integer
		Get
			LocalPort = pLocalPort
		End Get
		Set(ByVal NewValue As Integer)
			pLocalPort = NewValue
		End Set
	End Property

	Public Property RemoteUser() As String
		Get
			RemoteUser = pRemoteUser
		End Get
		Set(ByVal NewValue As String)
			pRemoteUser = NewValue
		End Set
	End Property

	Public Property RemoteIP() As String
		Get
			RemoteIP = pRemoteIP
		End Get
		Set(ByVal NewValue As String)
			pRemoteIP = NewValue
		End Set
	End Property

	Public Property RemotePort() As Integer
		Get
			RemotePort = pRemotePort
		End Get
		Set(ByVal NewValue As Integer)
			pRemotePort = NewValue
		End Set
	End Property

	Public Function BuildMessage(ByVal strUser As String, ByVal strMessage As String) As String
		BuildMessage = strUser & " : " & Trim(strMessage)
	End Function

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
	End Sub

	Public Function SendMessage(ByVal strMessage As String) As Boolean
		Dim i As Integer = 0
		If WinsockClient.State <> MSWinsockLib.StateConstants.sckClosed Then WinsockClient.Close()
		pMessage = strMessage
		WinsockClient.Connect(pRemoteIP, pRemotePort)
	End Function
End Class