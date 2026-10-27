Public Class frmSalesOrderSearch
    Dim strSoNo As String = ""
    Dim clsuser As New classUserInfo
    Dim blnOk As Boolean = False
    Public Property UserInfo() As classUserInfo
        Get
            UserInfo = clsUser
        End Get
        Set(ByVal NewValue As classUserInfo)
            clsUser = NewValue
        End Set
    End Property
    Public Property pSoNo() As String
        Get
            pSoNo = strSoNo
        End Get
        Set(ByVal NewValue As String)
            strSoNo = NewValue
        End Set
    End Property
    Public Property pblnOk As Boolean
        Get
            pblnOk = blnOk
        End Get
        Set(ByVal NewValue As Boolean)
            blnOk = NewValue
        End Set
    End Property

    Private Sub GenCombo()
		Dim objDB As New classMaster
		Dim dt As DataTable
		dt = objDB.GetCustomer
		Me.cboCustomer.DataSource = dt
		Me.cboCustomer.DisplayMember = "name"
		Me.cboCustomer.ValueMember = "custcd"
	End Sub

	Private Sub GenGrid()
		Dim objDB As New classSalesOrder
        Dim dt As New DataTable
        dt = objDB.SOSearch(txtSoNo.Text.Trim.ToUpper, dtpDateFr.Value.ToString("yyyyMMdd"), dtpDateTo.Value.ToString("yyyyMMdd"), (New clsConfig).IsNull(cboCustomer.SelectedValue, "").ToString.Trim, (New clsConfig).IsNull(UserInfo.UserID, ""))

        grdData.AutoGenerateColumns = False
        grdData.DataSource = dt
    End Sub

    Private Sub FormInvoiceLocalSearch_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        dtpDateFr.Value = DateAdd(DateInterval.Month, -1, Now)
        dtpDateTo.Value = Now
        Call GenCombo()
        Call GenGrid()
    End Sub

    Private Sub FormInvoiceLocalSearch_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        ' e.Cancel = True
        'Me.Hide()
    End Sub

    Private Sub grdInv_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles grdData.DoubleClick
        Call Getdata()
        'If grdInv.Rows.Count > 0 Then strSoNo = grdInv.CurrentRow.Cells("sono").Value
        'Me.Hide()
    End Sub

    Private Sub btnRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRefresh.Click
        Call GenGrid()
    End Sub

    Private Sub btnRefresh2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRefresh2.Click
        Call GenGrid()
    End Sub

    Private Sub btnMinimized_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMinimized.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        blnOk = False
        Me.Close()
    End Sub

    Private Sub txtSoNo_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles txtSoNo.KeyDown
        If e.KeyCode = Keys.Enter Then
            Call GenGrid()
        End If
    End Sub
    Private Sub Getdata()
        If grdData.Rows.Count > 0 Then
            strSoNo = grdData.CurrentRow.Cells("sono").Value
            blnOk = True
        End If
        Me.Hide()
    End Sub

End Class