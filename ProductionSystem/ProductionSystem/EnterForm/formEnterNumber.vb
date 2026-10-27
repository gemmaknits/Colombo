Public Class formEnterNumber
    Dim StrInt As String

    Public Property pInt As String
        Get
            pInt = StrInt
        End Get
        Set(ByVal Newvalue As String)
            StrInt = Newvalue
        End Set
    End Property
    Private Sub formEnterInt_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.StartPosition = FormStartPosition.CenterScreen
        txtResult.Focus()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub btnOk_Click(sender As Object, e As EventArgs) Handles btnOk.Click
        If txtResult.Text.Trim.Length > 0 Then
            pInt = txtResult.Text.Trim
        End If

        Me.Close()
    End Sub

    Private Sub txtResult_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtResult.KeyPress
        If Not Char.IsNumber(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) AndAlso Not (Asc(e.KeyChar) = Asc(".")) Then e.Handled = True

    End Sub

    Private Sub txtResult_KeyDown(sender As Object, e As KeyEventArgs) Handles txtResult.KeyDown
        If e.KeyCode = Keys.Enter Then
            Call btnOk_Click(sender, e)
        End If
    End Sub
End Class