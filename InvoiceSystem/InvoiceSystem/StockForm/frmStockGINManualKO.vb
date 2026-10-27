Public Class frmStockGINManualKO
    Dim clsUser As New classUserInfo
    Dim clsConfig As New clsConfig
    Dim DbStockG As New classStockG

    Dim blnCancel As Boolean = False
    Dim strKONo As String

    Public Property pKono() As String
        Get
            pKono = strKONo
        End Get
        Set(ByVal NewValue As String)
            strKONo = NewValue
        End Set
    End Property

    Public Property UserInfo() As classUserInfo
        Get
            UserInfo = clsUser
        End Get
        Set(ByVal NewValue As classUserInfo)
            clsUser = NewValue
        End Set
    End Property
    Private Sub frmStockGINManualKO_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnSearchOutNo_Click(sender As System.Object, e As System.EventArgs) Handles btnSearchOutNo.Click
        Dim frm As New frmSearchKO
        frm.ShowDialog(Me)
        txtkono.Text = frm.pKono
        Me.Cursor = Cursors.WaitCursor
        'If Not blnCancel Then getPO(txtPONo.Text)
        Me.Cursor = Cursors.Default
        frm.Dispose()

        If txtkono.Text <> "" Then 'Go to frmStockGIN_KOManual
            Dim frm2 As New frmStockGIN_KOManual
            frm2.pKono = txtkono.Text
            frm2.UserInfo = clsUser
            frm2.Show()
            Me.Hide()
        End If
    End Sub

    Private Sub txtkono_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles txtkono.KeyDown
        If e.KeyCode = Keys.Enter Then
            Dim frm As New frmStockGIN_KOManual
            frm.pKono = txtkono.Text
            frm.UserInfo = clsUser
            frm.Show()
            Me.Hide()
        End If
    End Sub

End Class