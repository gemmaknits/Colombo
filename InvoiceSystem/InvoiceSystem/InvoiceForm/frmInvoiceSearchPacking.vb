Public Class frmInvoiceSearchPacking
	Dim strPackNoCartNo As String = ""
	Dim strStockType As String = "G"

	Public Property pStockType() As String
		Get
			pStockType = strStockType
		End Get
		Set(ByVal NewValue As String)
			strStockType = NewValue
		End Set
	End Property

	Public Property pPackNoCartNo() As String
		Get
			pPackNoCartNo = strPackNoCartNo
		End Get
		Set(ByVal NewValue As String)
			strPackNoCartNo = NewValue
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
		Dim config As New clsConfig
		Dim objDB As New classInvoice
		Dim dt As New DataTable
		If cboCustomer.SelectedIndex < 0 Then
			dt = objDB.GetPackNo(strStockType, txtPackNo.Text.Trim.ToUpper, dtpDateFr.Value.ToString("yyyyMMdd"), dtpDateTo.Value.ToString("yyyyMMdd"), "", txtSoNo.Text.Trim.ToUpper)
		Else
			dt = objDB.GetPackNo(strStockType, txtPackNo.Text.Trim.ToUpper, dtpDateFr.Value.ToString("yyyyMMdd"), dtpDateTo.Value.ToString("yyyyMMdd"), cboCustomer.SelectedValue.ToString.Trim.ToUpper, txtSoNo.Text.Trim.ToUpper)
		End If
		If dt.Rows.Count > 0 Then
			strPackNoCartNo = dt.Rows(0)("packno_cartno")
		End If
		grdInv.AutoGenerateColumns = False
		grdInv.DataSource = dt
	End Sub

	Private Sub FormInvoiceLocalSearchPacking_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
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
		If grdInv.Rows.Count > 0 Then strPackNoCartNo = grdInv.CurrentRow.Cells("packno_cartno").Value
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

	Private Sub optStockG_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles optStockG.CheckedChanged
		strStockType = "G"
	End Sub

	Private Sub optStockD_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles optStockD.CheckedChanged
		strStockType = "D"
	End Sub

	Private Sub optStockC_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles optStockC.CheckedChanged
		strStockType = "C"
	End Sub
End Class