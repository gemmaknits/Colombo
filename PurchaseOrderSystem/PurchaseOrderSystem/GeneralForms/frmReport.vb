Imports CrystalDecisions.Shared
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Windows.Forms

Public Class frmReport
    Public Property Title() As String
        Get
            Title = Me.Text
        End Get
        Set(ByVal NewValue As String)
            Me.Text = NewValue
        End Set
    End Property

    Private Sub frmReport_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.WindowState = FormWindowState.Maximized
    End Sub
End Class
