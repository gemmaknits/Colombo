Public Class frmInvoiceExportSearch
	Dim lngInvID As Long = 0
    Dim StrInvNo As String

	Public Property pInvID() As Long
		Get
			pInvID = lngInvID
		End Get
		Set(ByVal NewValue As Long)
			lngInvID = NewValue
		End Set
    End Property

    Public Property pInvNo() As String
        Get
            pInvNo = StrInvNo

        End Get
        Set(ByVal NewValue As String)
            StrInvNo = Newvalue
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
        Dim objDB As New classInvoiceExportSearch
		Dim dt As New DataTable
        dt = objDB.InvExpSearchLoad(0, txtInvNo.Text.Trim.ToUpper, dtpDateFr.Value.ToString("yyyyMMdd"), dtpDateTo.Value.ToString("yyyyMMdd"), cboCustomer.SelectedValue.ToString.Trim.ToUpper, txtDesign_no.Text.Trim)
		If dt.Rows.Count > 0 Then
            lngInvID = dt.Rows(0)("invid")
            StrInvNo = dt.Rows(0)("invno")
		End If
		grdInv.AutoGenerateColumns = False
		grdInv.DataSource = dt
	End Sub

	Private Sub FormInvoiceExportSearch_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'dtpDateFr.Value = DateAdd(DateInterval.Month, -1, Now)
		dtpDateTo.Value = Now
		Call GenCombo()
		Call GenGrid()
	End Sub

	Private Sub FormInvoiceExportSearch_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
		e.Cancel = True
		Me.Hide()
	End Sub

	Private Sub grdInv_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles grdInv.DoubleClick
        If grdInv.Rows.Count > 0 Then
            lngInvID = grdInv.CurrentRow.Cells("invid").Value
            StrInvNo = grdInv.CurrentRow.Cells("invno").Value
        End If


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

    Private Sub txtDesign_no_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles txtDesign_no.KeyDown
        If e.KeyCode = Keys.Enter Then
            GenGrid()
        End If
    End Sub

    Private Sub txtDesign_no_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtDesign_no.TextChanged

    End Sub

    Private Sub cboCustomer_DropDownClosed(sender As Object, e As System.EventArgs) Handles cboCustomer.DropDownClosed
        GenGrid()
    End Sub

    Private Sub cboCustomer_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cboCustomer.SelectedIndexChanged

    End Sub
End Class