Public Class frmPricelist
    Dim clsuser As New classUserInfo


    Public Property Userinfo() As classUserInfo 'Add By Neung 20151208
        Get
            Userinfo = clsuser
        End Get
        Set(ByVal newvalue As classUserInfo)
            clsuser = newvalue
        End Set
    End Property

    Private Sub frmPricelist_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class