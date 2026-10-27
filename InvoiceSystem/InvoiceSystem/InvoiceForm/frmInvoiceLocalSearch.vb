Public Class frmInvoiceLocalSearch
	Dim lngInvID As Long = 0
    Dim oConfig As New clsConfig
    Dim oInvoiceLocalSearch As New classInvoiceLocalSearch
    Public Property pInvID() As Long
		Get
			pInvID = lngInvID
		End Get
		Set(ByVal NewValue As Long)
			lngInvID = NewValue
		End Set
	End Property

	Private Sub GenCombo()
        'Dim objDB As New classMaster
        Dim dt As DataTable
        dt = oInvoiceLocalSearch.selectCustomerList()
        Me.cboCustomer.DataSource = dt
		Me.cboCustomer.DisplayMember = "name"
		Me.cboCustomer.ValueMember = "custcd"
	End Sub

	Private Sub GenGrid()
		Dim objDB As New classInvoice
		Dim dt As New DataTable
        dt = oInvoiceLocalSearch.selectInvLocalRecord(0, txtInvNo.Text.Trim.ToUpper, dtpDateFr.Value.ToString("yyyyMMdd"), dtpDateTo.Value.ToString("yyyyMMdd"), oConfig.IsNull(cboCustomer.SelectedValue, "").ToString.Trim.ToUpper)
        If dt.Rows.Count > 0 Then
			lngInvID = dt.Rows(0)("invid")
		End If
		grdInv.AutoGenerateColumns = False
		grdInv.DataSource = dt
	End Sub

	Private Sub FormInvoiceLocalSearch_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
		dtpDateFr.Value = DateAdd(DateInterval.Month, -1, Now)
		dtpDateTo.Value = Now
		Call GenCombo()
		Call GenGrid()
	End Sub

	Private Sub FormInvoiceLocalSearch_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
		e.Cancel = True
		Me.Hide()
	End Sub

	Private Sub grdInv_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles grdInv.DoubleClick
		If grdInv.Rows.Count > 0 Then lngInvID = grdInv.CurrentRow.Cells("invid").Value
		Me.Hide()
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
		Me.Hide()
	End Sub
End Class