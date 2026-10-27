Public Class frmRequestSearch
	Dim clsConfig As New clsConfig
	Dim strReqNo As String = ""
	Dim strStockType As String = ""

	Public Property pReqNo() As String
		Get
			pReqNo = strReqNo
		End Get
		Set(ByVal NewValue As String)
			strReqNo = NewValue
		End Set
	End Property

	Public Property pStockType() As String
		Get
			pStockType = strStockType
		End Get
		Set(ByVal NewValue As String)
			strStockType = NewValue
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
		Dim objDB As New classRequest
		Dim dt As New DataTable
		dt = objDB.GetReqNo(strStockType, txtReqNo.Text.Trim.ToUpper, dtpDateFr.Value.ToString("yyyyMMdd"), dtpDateTo.Value.ToString("yyyyMMdd"), clsConfig.IsNull(cboCustomer.SelectedValue, "").ToString.Trim.ToUpper)
		If dt.Rows.Count > 0 Then
			strReqNo = dt.Rows(0)("outreqno")
		End If
		grdReq.AutoGenerateColumns = False
		grdReq.DataSource = dt
	End Sub

	Private Sub frmRequestSearch_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
		dtpDateFr.Value = DateAdd(DateInterval.Month, -1, Now)
		dtpDateTo.Value = Now
		Call GenCombo()
		Call GenGrid()
	End Sub

	Private Sub frmRequestSearch_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
		e.Cancel = True
		Me.Hide()
	End Sub

	Private Sub grdInv_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles grdReq.DoubleClick
		If grdReq.Rows.Count > 0 Then strReqNo = grdReq.CurrentRow.Cells("outreqno").Value
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
		Me.Close()
	End Sub
End Class