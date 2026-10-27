Public Class frmGenWarpSet
    Dim Int_set_per_lot As Nullable(Of Integer)

    Public Property p_set_per_lot As Nullable(Of Integer)
        Get
            p_set_per_lot = Int_set_per_lot
        End Get
        Set(ByVal NewValue As Nullable(Of Integer))
            Int_set_per_lot = NewValue
        End Set
    End Property

    Private Sub frmGenWarpSet_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub BtnGenLots_Click(sender As System.Object, e As System.EventArgs) Handles BtnGenLots.Click
        Int_set_per_lot = txtQty.Text
        Me.Hide()
    End Sub

    Private Sub txtQty_KeyDown(sender As Object, e As KeyEventArgs) Handles txtQty.KeyDown
        If e.KeyCode = Keys.Enter Then
            Int_set_per_lot = CInt(txtQty.Text)
            Me.Hide()
        End If
    End Sub

    Private Sub txtQty_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtQty.TextChanged
        txtQty.SelectAll()
    End Sub
End Class