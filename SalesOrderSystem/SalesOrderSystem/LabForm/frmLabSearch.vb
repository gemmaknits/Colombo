Public Class frmLabSearch
	Dim strLabNo As String = ""

	Public Property pLabNo() As String
		Get
			pLabNo = strLabNo
		End Get
		Set(ByVal NewValue As String)
			strLabNo = NewValue
		End Set
	End Property

	Private Sub GenCombo()
		Dim objDB As New classMaster
		Dim dt As DataTable
		dt = objDB.GetDyedHouse
		Me.cboDyedHouse.DataSource = dt
		Me.cboDyedHouse.DisplayMember = "name"
		Me.cboDyedHouse.ValueMember = "suppcd"
	End Sub

	Private Sub GenGrid()
		Dim config As New clsConfig
		Dim objDB As New classLab
		Dim dt As New DataTable
		dt = objDB.GetLabNo(txtLabNo.Text.Trim.ToUpper, dtpDateFr.Value.ToString("yyyyMMdd"), dtpDateTo.Value.ToString("yyyyMMdd"), config.IsNull(cboDyedHouse.SelectedValue, "").ToString.Trim.ToUpper)
		If dt.Rows.Count > 0 Then
			strLabNo = dt.Rows(0)("labno")
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
		If grdInv.Rows.Count > 0 Then strLabNo = grdInv.CurrentRow.Cells("labno").Value
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