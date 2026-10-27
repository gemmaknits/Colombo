Public Class frmTransferYarn
    Dim config As New clsConfig
    Dim clsConn As New classConnection
    Dim clsUser As New classUserInfo
    Dim kono As String = ""

    Public Property UserInfo() As classUserInfo
        Get
            UserInfo = clsUser
        End Get
        Set(ByVal NewValue As classUserInfo)
            clsUser = NewValue
        End Set
    End Property

    Private Sub btnTransfer_Click(sender As Object, e As EventArgs) Handles btnTransfer.Click
        If MessageBox.Show("Would you like to transfer yarn ?", "System Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = System.Windows.Forms.DialogResult.No Then Exit Sub

        Try
            Dim objDB As New classProduction
            Dim ds As DataSet = objDB.TransferYarn(txtKONoFr.Text, txtKONoTo.Text, UserInfo.UserID)
            Dim dt As DataTable = ds.Tables(ds.Tables.Count - 1)
            If dt.Rows.Count > 0 Then
                Dim strDocNo As String = ""
                For i As Integer = 0 To dt.Rows.Count - 1
                    If strDocNo.Length > 0 Then strDocNo = strDocNo + vbCrLf
                    strDocNo = strDocNo + dt.Rows(i)("docno")
                Next
                MessageBox.Show(strDocNo, "System Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("Unknown Error", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "System Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub txtKONoFr_KeyDown(sender As Object, e As KeyEventArgs) Handles txtKONoFr.KeyDown
        If e.KeyCode = Keys.Enter Then txtKONoTo.Focus()
    End Sub

    Private Sub txtKONoTo_KeyDown(sender As Object, e As KeyEventArgs) Handles txtKONoTo.KeyDown
        If e.KeyCode = Keys.Enter Then btnTransfer.Focus()
    End Sub
End Class