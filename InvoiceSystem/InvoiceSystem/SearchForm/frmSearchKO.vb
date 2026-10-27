Public Class frmSearchKO
    Dim clsuser As New classUserInfo
    Dim strKONo As String

    Public Property pKono() As String
        Get
            pKono = strKONo
        End Get
        Set(ByVal NewValue As String)
            strKONo = NewValue
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
        Dim objDB As New classStockGIN_KOManual
        Dim dt As New DataTable
        Dim clsConfig As New clsConfig
        'strKONo = txtKONo.Text.Trim.ToUpper
        dt = objDB.GetGINKOManualSearchKO(strKONo, dtpDateFr.Value.ToString("yyyyMMdd"), dtpDateTo.Value.ToString("yyyyMMdd"), clsConfig.IsNull(cboSup.SelectedValue, "").ToString.Trim.ToUpper)
        If dt.Rows.Count > 0 Then
            strKONo = dt.Rows(0)("kono")
        End If
        grdData.AutoGenerateColumns = False
        grdData.DataSource = dt
    End Sub

    Private Sub frmSearchKO_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        dtpDateFr.Value = DateAdd(DateInterval.Month, -1, Now)
        dtpDateTo.Value = Now
        Call genCbo()
        Call GenCboInGrid()
        Call GenGrid()

    End Sub


    Private Sub grdData_DoubleClick(sender As Object, e As System.EventArgs) Handles grdData.DoubleClick
        If grdData.Rows.Count > 0 Then strKONo = grdData.CurrentRow.Cells("kono").Value
        Me.Hide()
    End Sub
End Class