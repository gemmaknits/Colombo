Public Class frmDyingOrderChange
	Dim clsConfig As New clsConfig
	Dim clsConn As New classConnection
	Dim clsUser As New classUserInfo
	Dim strDFNo As String = ""

	Public Property UserInfo() As classUserInfo
		Get
			UserInfo = clsUser
		End Get
		Set(ByVal NewValue As classUserInfo)
			clsUser = NewValue
		End Set
	End Property

	Private Sub GenComboDF()
		Dim objDB As New classDFOrder
		cboDFNo.ComboBox.DataSource = objDB.DFComboLoad()
		cboDFNo.ComboBox.DisplayMember = "dfno"
		cboDFNo.ComboBox.ValueMember = "dfno"
		If strDFNo.Trim.Length > 0 Then
			cboDFNo.ComboBox.SelectedValue = strDFNo.Trim
		Else
			cboDFNo.SelectedIndex = 0
		End If
	End Sub

	Private Sub GenComboSO(ByVal DFNo As String)
		Dim objDB As New classDFOrder
		Me.cboSoNo.DataSource = objDB.GetSODF(DFNo)
		Me.cboSoNo.DisplayMember = "sono"
		Me.cboSoNo.ValueMember = "sono"
	End Sub

	Private Sub GenComboSONOID(ByVal DFNo As String, ByVal SONo As String)
		Dim objDB As New classDFOrder
		sonoid.DataSource = objDB.GetSODFColor(DFNo, SONo)
		sonoid.DisplayMember = "so_col"
		sonoid.ValueMember = "sonoid"
	End Sub

	Private Sub LoadData(ByVal DFNo As String)
		Dim objDB As New classDFOrder
		Dim dt As New DataTable
		dt = objDB.DFDetLoad2(DFNo)
		grdDF.AutoGenerateColumns = False
		grdDF.DataSource = dt
		If dt.Rows.Count > 0 Then
			strDFNo = DFNo
			Call GenComboSO(strDFNo)
			If clsConfig.IsNull(dt.Rows(0)("sono"), "") = "" Then
				cboSoNo.SelectedIndex = 0
			Else
				cboSoNo.SelectedValue = clsConfig.IsNull(dt.Rows(0)("sono"), "")
			End If
			Call GenComboSONOID(DFNo, clsConfig.IsNull(cboSoNo.SelectedValue, ""))
		Else
			Call GenComboSONOID(DFNo, "")
		End If
	End Sub

	Private Function CheckSONO(ByVal dt As DataTable) As Boolean
		Dim result As Boolean = True
		Dim sono As String = dt.Rows(0)("sonoid").ToString.Substring(0, 10)
		Dim i As Integer = 0
		For i = 0 To dt.Rows.Count - 1
			If dt.Rows(0)("sonoid").ToString.Substring(0, 10) <> sono Then
				result = False
				Exit For
			End If
		Next
		Return result
	End Function

	Private Sub cboDFNo_DropDownClosed(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboDFNo.DropDownClosed
		If clsConfig.IsNull(cboDFNo.ComboBox.SelectedValue, "").Trim.Length > 0 Then LoadData(clsConfig.IsNull(cboDFNo.ComboBox.SelectedValue, ""))
	End Sub

	Private Sub cboDFNo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cboDFNo.KeyPress
		If Asc(e.KeyChar) = 13 Then
			cboDFNo.ComboBox.SelectedValue = cboDFNo.Text.Trim.ToUpper
			Call cboDFNo_DropDownClosed(sender, e)
		End If
	End Sub

	Private Sub cboSONo_DropDownClosed(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboSoNo.DropDownClosed
		If clsConfig.IsNull(cboSoNo.SelectedValue, "").Trim.Length > 0 Then Call GenComboSONOID(strDFNo, cboSoNo.SelectedValue)
	End Sub

	Private Sub frmDyingOrderChange_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
		grdDF.DataSource = Nothing
		Call GenComboDF()
		Call GenComboSO(strDFNo)
	End Sub

	Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
		If grdDF.DataSource Is Nothing Then Exit Sub
        grdDF.EndEdit()
        Dim dt As DataTable = grdDF.DataSource
		If dt.Rows.Count = 0 Then Exit Sub
		If Not CheckSONO(dt) Then Exit Sub
		Dim clsDF As New classDFOrder
        Dim msgerr As String = ""

        Dim dv_upd As New DataView(dt, "", "", DataViewRowState.CurrentRows)
		If Not clsDF.SaveDFChange(dv_upd, msgerr) Then
			MessageBox.Show(msgerr, "System Message", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
		Else
			MessageBox.Show("Save Completed", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
			Call cboDFNo_DropDownClosed(sender, e)
		End If
	End Sub

	Private Sub btnMinimized_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMinimized.Click
		Me.WindowState = FormWindowState.Minimized
	End Sub

	Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
		Me.Close()
	End Sub

    Private Sub cboDFNo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboDFNo.Click

    End Sub

    Private Sub grdDF_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles grdDF.CellContentClick

    End Sub
End Class