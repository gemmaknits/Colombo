Public Class frmStockGIN_KOManualIndex
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


    Private Sub btnSearchOutNo_Click(sender As System.Object, e As System.EventArgs) Handles btnSearchOutNo.Click
        Dim frm As New frmSearchKO
        frm.ShowDialog(Me)
        txtkono.Text = frm.pKono.Trim
        Me.Cursor = Cursors.WaitCursor
        'If Not blnCancel Then getPO(txtPONo.Text)
        Me.Cursor = Cursors.Default
        frm.Dispose()

        If Validate_KoNo(txtkono.Text.Trim) Then 'Go to frmStockGIN_KOManual
            Dim frm2 As New frmStockGIN_KOManual
            frm2.pKono = txtkono.Text
            frm2.UserInfo = clsUser
            frm2.MdiParent = Me.ParentForm
            frm2.Show()
            'Me.Hide()
        End If
    End Sub

    Private Sub txtkono_GotFocus(sender As Object, e As System.EventArgs) Handles txtkono.GotFocus
        txtroll_no.Text = ""
    End Sub

    Private Sub txtkono_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles txtkono.KeyDown
        If e.KeyCode = Keys.Enter Then
            If Validate_KoNo(txtkono.Text.Trim) Then
                Dim frm2 As New frmStockGIN_KOManual
                frm2.pKono = txtkono.Text
                frm2.UserInfo = clsUser
                'frm2.MdiParent = Me
                frm2.Show()
                'Me.Hide()
            End If
        End If
    End Sub

    Private Sub txtroll_no_GotFocus(sender As Object, e As System.EventArgs) Handles txtroll_no.GotFocus
        txtkono.Text = ""
    End Sub
    Private Sub txtroll_no_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles txtroll_no.KeyDown
        If e.KeyCode = Keys.Enter Then
            If Validate_RollNo(txtroll_no.Text.Trim) Then
                Dim frm2 As New frmStockGIN_KOManual
                frm2.pRollno = txtroll_no.Text.Trim
                frm2.pUserID = clsUser.UserID
                frm2.UserInfo = clsUser
                'frm2.MdiParent = Me
                frm2.Show()
                'Me.Hide()
            End If
        End If
    End Sub
    Private Function Validate_RollNo(Optional ByVal StrRollNo As String = "") As Boolean
        Dim objdb As New classStockGIN_KOManual
        Dim dt As DataTable = objdb.Validate_RollNo(StrRollNo, clsUser.UserID)

        If dt.Rows.Count = 0 Then
            MessageBox.Show("Roll No .: " & StrRollNo & "............   is Not Correct!!", "SyStem Messsage", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return False
        Else
            Return True
        End If


    End Function
    Private Function Validate_KoNo(Optional ByVal StrKono As String = "") As Boolean
        Dim objdb As New classStockGIN_KOManual
        Dim dt As DataTable = objdb.Validate_KoNo(StrKono, clsUser.UserID)

        If dt.Rows.Count = 0 Then
            MessageBox.Show("KO No .: " & StrKono & "............   is Not Correct!!", "SyStem Messsage", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return False
        Else
            Return True
        End If


    End Function

    Private Sub frmStockGIN_KOManualIndex_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        ' Me.WindowState = FormWindowState.Maximized 
        Me.WindowState = FormWindowState.Normal 'Esdit By Neung Request By Uer Ton(end) 20151201 
    End Sub

    Private Sub txtkono_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtkono.TextChanged

    End Sub

    Private Sub txtroll_no_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtroll_no.TextChanged

    End Sub
End Class