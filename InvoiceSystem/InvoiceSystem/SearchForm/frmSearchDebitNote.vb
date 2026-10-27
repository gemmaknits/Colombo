Imports System.Data.SqlClient
Imports System.Text

Public Class frmSearchDebitNote
    'Writen By      : Sitthana Boonlom
    'Writen Date    : 20231211

#Region "Property"
    Private _conn As System.Data.SqlClient.SqlConnection
    Private _logempcd As String = ""
    Private _DBNoteNo As String = ""

    Public Property conn As System.Data.SqlClient.SqlConnection
        Get
            conn = _conn
        End Get
        Set(ByVal Newvalue As System.Data.SqlClient.SqlConnection)
            _conn = Newvalue
        End Set
    End Property

    Public Property logempcd As String
        Get
            logempcd = _logempcd
        End Get
        Set(ByVal Newvalue As String)
            _logempcd = Newvalue
        End Set
    End Property

    Public Property DBNoteNo As String
        Get
            DBNoteNo = _DBNoteNo
        End Get
        Set(ByVal Newvalue As String)
            _DBNoteNo = Newvalue
        End Set
    End Property
#End Region

    Private cls As New clsConfig

    Private dt As New DataTable


    Dim strDbnote_No As String

    'Public Property Pdbnote_no As String


    'End Property
    Private Sub frmSearchDebitNote_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        getData()
    End Sub

    Private Sub getData()

    End Sub

    Private Sub btnRefresh2_Click(sender As Object, e As EventArgs) Handles btnRefresh2.Click

    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub
End Class