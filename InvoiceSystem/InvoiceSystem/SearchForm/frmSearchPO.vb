Public Class frmSearchPO
    Dim clsuser As New classUserInfo
    Dim strPONo As String

    Public Property pPono() As String
        Get
            pPONo = strPONo
        End Get
        Set(ByVal NewValue As String)
            strPONo = NewValue
        End Set
    End Property

    Private Sub genCbo()
        Dim objdb As New classMaster

        Me.cboSup.DataSource = objdb.GetSupplier
        Me.cboSup.DisplayMember = "name"
        Me.cboSup.ValueMember = "suppcd"
        Me.cboSup.SelectedValue = -1

    End Sub
    Private Sub GenCboInGrid()
        Dim objdb As New classMaster
        grd_cbosup.DataSource = objdb.GetSupplier
        grd_cbosup.DisplayMember = "name"
        grd_cbosup.ValueMember = "suppcd"
    End Sub

    Private Sub GenGrid()
        Dim objDB As New classSeachPO
        Dim dt As New DataTable
        Dim clsConfig As New clsConfig
        'strPONo = txtPONo.Text.Trim.ToUpper
        dt = objDB.GetGINPOManualSearchPO(strPONo, dtpDateFr.Value.ToString("yyyyMMdd"), dtpDateTo.Value.ToString("yyyyMMdd"), clsConfig.IsNull(cboSup.SelectedValue, "").ToString.Trim.ToUpper)
        If dt.Rows.Count > 0 Then
            strPONo = dt.Rows(0)("jobno")
        End If
        grdData.AutoGenerateColumns = False
        grdData.DataSource = dt
    End Sub

    Private Sub frmSearchPO_FormClosed(sender As Object, e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        strPONo = ""
    End Sub

    Private Sub frmSearchPO_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        dtpDateFr.Value = DateAdd(DateInterval.Month, -1, Now)
        dtpDateTo.Value = Now
        Call genCbo()
        Call GenCBOINGrid()
        Call GenGrid()

    End Sub

    Private Sub grdData_CellContentClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles grdData.CellContentClick

    End Sub

    Private Sub grdData_CellDoubleClick(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles grdData.CellDoubleClick
        If grdData.Rows.Count > 0 Then strPONo = grdData.CurrentRow.Cells("jobno").Value
        Me.Hide()
    End Sub

    Private Sub btnSearch_Click(sender As System.Object, e As System.EventArgs) Handles btnSearch.Click
        Call GenGrid()
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles btnOK.Click
        If grdData.Rows.Count > 0 Then strPONo = strPONo = grdData.CurrentRow.Cells("jobno").Value 'Convert.ToString(Me.grdData.SelectedRows)
    End Sub

    Private Sub btnExit_Click(sender As System.Object, e As System.EventArgs) Handles btnExit.Click
        strPONo = ""
        Me.Close()
    End Sub

    Private Sub txtPONO_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtPONO.KeyPress
        If Keys.KeyCode = Keys.Enter Then
            Call GenGrid()
        End If
    End Sub

End Class