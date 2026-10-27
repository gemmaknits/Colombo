Public Class frmGreigeInEditQcRemark
#Region "Properties"
    Private clsUser As New classUserInfo

    Public Property UserInfo() As classUserInfo
        Get
            UserInfo = clsUser
        End Get
        Set(ByVal NewValue As classUserInfo)
            clsUser = NewValue
        End Set
    End Property
#End Region


    Private clsConfig As New clsConfig
    Private clsConn As New classConnection
    Private clsStock As New classStock

    Private dt As New DataTable

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub frmGreigeInEditQcRemark_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnGetGinNo_Click(sender As Object, e As EventArgs) Handles btnGetGinNo.Click
        Dim frm As New frmSearchGreigeIn
        frm.ShowDialog()
        frm.Close()
        frm.Dispose()

        If frm.TranNo <> "" Then
            txtGINNo.Text = frm.TranNo
            If txtGINNo.Text.Trim <> "" Then
                LoadData()
            End If
        End If
    End Sub

    Private Sub LoadData()
        dt = clsStock.getGInByTranNo(txtGINNo.Text.Trim)

        If dt IsNot Nothing Then
            txtTranType.Text = dt.Rows(0)("tran_type")
            txtDesignNo.Text = dt.Rows(0)("design_no")
            txtKoNo.Text = dt.Rows(0)("kono")

            With dgvData
                .AutoGenerateColumns = False
                .DataSource = dt
            End With
        End If

    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If txtGINNo.Text.Trim <> "" Then
            With dgvData
                If .RowCount > 0 Then
                    .EndEdit()
                    If MessageBox.Show("Would you like to save ?", "System Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                        Call SaveData(txtGINNo.Text.Trim)
                    End If
                End If
            End With
        End If
    End Sub

    Private Function SaveData(pTranNo As String) As Boolean
        Dim Result As Boolean = False
        Dim msgerr As String = ""
        Dim dtr As DataTable = dgvData.DataSource
        Dim dv_dtc_upd As New DataView(dtr, "", "", DataViewRowState.ModifiedCurrent)



        If clsStock.GInSaveQcRemark(msgerr, dtr, dv_dtc_upd, clsUser.UserID, txtGINNo.Text.Trim) Then
            Call LoadData()
            MessageBox.Show("Save is Complete! : บันทึกสำเร็จ! ", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
            Result = True
        Else
            Result = False
            MessageBox.Show(msgerr, "System Message", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
        End If

        Return Result
    End Function

End Class