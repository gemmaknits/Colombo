Public Class frmRequestCOnhand
	Dim clsConfig As New clsConfig
	Dim clsConn As New classConnection
	Dim clsUser As New classUserInfo

	Public Property UserInfo() As classUserInfo
		Get
			UserInfo = clsUser
		End Get
		Set(ByVal NewValue As classUserInfo)
			clsUser = NewValue
		End Set
	End Property

	Private Sub GenCombo()
		Dim objDB As New classRequest
		Me.cboDesignNo.ComboBox.DataSource = objDB.GetReqCOnhandDesign
		Me.cboDesignNo.ComboBox.DisplayMember = "design_no"
		Me.cboDesignNo.ComboBox.ValueMember = "design_no"
	End Sub

	Private Sub LoadData(ByVal DesignNo As String)
		Dim objDB As New classRequest
		Dim dt As New DataTable
		dt = objDB.GetReqCOnhand(DesignNo)
		grdReqDOnhand.AutoGenerateColumns = False
		grdReqDOnhand.DataSource = dt
	End Sub

	Private Sub frmRequestDOnhand_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
		Call GenCombo()
		Call LoadData("")
	End Sub

	Private Sub cboDesignNo_DropDownClosed(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboDesignNo.DropDownClosed
		Dim DesignNo As String
		DesignNo = clsConfig.IsNull(cboDesignNo.ComboBox.SelectedValue, "")
		If DesignNo.Trim.Length > 0 Then Call LoadData(DesignNo)
	End Sub

	Private Sub btnRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRefresh.Click
		Call frmRequestDOnhand_Load(sender, e)
	End Sub

	Private Sub btnMinimized_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMinimized.Click
		Me.WindowState = FormWindowState.Minimized
	End Sub

	Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
		Me.Close()
	End Sub
End Class