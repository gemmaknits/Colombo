Public Class frmViewImage
       Dim clsuser As new classUserInfo
    Dim Strfile_location As String
    Dim StrFile_Type As String = ""

    Public Property Pfile_location() As String
        Get
            Pfile_location = Strfile_location
        End Get
        Set(ByVal NewValue As String)
            Strfile_location = NewValue
        End Set
    End Property

    Public Property PFile_type As String
        Get
            PFile_type = StrFile_Type
        End Get
        Set(ByVal newvalue As String)
            StrFile_Type = newvalue
        End Set
    End Property


    Public Property UserInfo() As classUserInfo
        Get
            UserInfo = clsuser
        End Get
        Set(ByVal NewValue As classUserInfo)
            clsuser = NewValue
        End Set
    End Property

    Private Sub frmPhoto_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
        If StrFile_Type = ".JPG" Or StrFile_Type = ".GIF" Or StrFile_Type = ".PNG" Then
            AxWindowsMediaPlayer1.Visible = False
            PictureBox1.Visible = True
            PictureBox1.Image = Image.FromFile(Strfile_location)
        ElseIf StrFile_Type = ".AVI" Or StrFile_Type = ".MPG" Or StrFile_Type = ".MP4" Then
            PictureBox1.Visible = False
            AxWindowsMediaPlayer1.Visible = True
            AxWindowsMediaPlayer1.URL = Strfile_location
        End If

    End Sub
End Class