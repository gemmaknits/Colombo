Imports System.IO
Imports System.Drawing.Image
Public Class frmDesignImage
    Public StrImageFile As String
    Public StrImagePath As String

    Public Property pImageFile() As String
        Get
            pImageFile = StrImageFile
        End Get
        Set(ByVal NewValue As String)
            StrImageFile = NewValue
        End Set
    End Property

    Public Property pImagePath() As String
        Get
            pImagePath = StrImagePath
        End Get
        Set(ByVal NewValue As String)
            StrImagePath = NewValue
        End Set
    End Property


    Private Sub frmDesignImage_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        PictureBox1.ImageLocation = StrImagePath & StrImageFile
    End Sub

End Class