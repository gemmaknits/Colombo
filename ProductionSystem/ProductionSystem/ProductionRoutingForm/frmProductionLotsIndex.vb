Public Class frmProductionLotsIndex
    Dim clsUser As New classUserInfo
    Dim mfg_production_lots As mfg_production_lots

    Public Property Title() As String
        Get
            Title = Me.Text
        End Get
        Set(ByVal NewValue As String)
            Me.Text = NewValue
        End Set
    End Property

    Public Property p_mfg_production_lots() As mfg_production_lots
        Get
            p_mfg_production_lots = Me.mfg_production_lots
        End Get
        Set(ByVal NewValue As mfg_production_lots)
            mfg_production_lots = NewValue
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
    Private Sub frmProductionLotsIndex_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub txtroll_no_GotFocus(sender As Object, e As System.EventArgs) Handles txtroll_no.GotFocus
        txtroll_no.SelectAll()
    End Sub

    Private Sub txtroll_no_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles txtroll_no.KeyDown

        mfg_production_lots.system_lot_number = txtroll_no.Text.Trim

        If e.KeyCode = Keys.Enter Then
            If Validate_RollNo(txtroll_no.Text.Trim) Then

                Dim frm As New frmOperationKnitting
                frm.Title = Me.Title
                frm.p_mfg_production_lots = Me.mfg_production_lots
                frm.UserInfo = clsUser
                frm.MdiParent = Me.ParentForm
                frm.Show()
            End If
        End If
    End Sub

    Private Function Validate_RollNo(Optional ByVal StrRollNo As String = "") As Boolean
        Dim objdb As New classProductionLots
        Dim dt As DataTable = objdb.Validate_RollNo(StrRollNo, clsUser.UserID)

        If dt.Rows.Count = 0 Then
            MessageBox.Show("Roll No .: " & StrRollNo & "............   is Not Correct!!", "SyStem Messsage", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return False
        Else
            Return True
        End If


    End Function

    Private Sub txtroll_no_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtroll_no.TextChanged

    End Sub
End Class