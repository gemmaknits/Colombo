Public Class frmPOClose
	Dim clsConfig As New clsConfig
	Dim clsConn As New classConnection
    Dim blnCancel As Boolean
    Dim clsUser As New classUserInfo

    Public Property UserInfo() As classUserInfo
        Get
            UserInfo = clsUser
        End Get
        Set(ByVal NewValue As classUserInfo)
            clsUser = NewValue
        End Set
    End Property

	Private Sub GenComboPONo()
		Dim objDB As New classPurchase
		cboPONo.ComboBox.DataSource = objDB.GetPOUnclose
		cboPONo.ComboBox.DisplayMember = "jobno"
		cboPONo.ComboBox.ValueMember = "jobno"
		cboPONo.ComboBox.SelectedIndex = 0
	End Sub

	Private Sub BindGrid(ByVal dt As DataTable)
		grdPurchaseOrder.AutoGenerateColumns = False
		grdPurchaseOrder.DataSource = dt
	End Sub

	Private Function IsDataChange() As Boolean
		Dim config As New clsConfig
		Dim result As Boolean = False
		Dim dt As New DataTable
		dt = grdPurchaseOrder.DataSource
		Dim dv As New DataView(dt, "", "", DataViewRowState.OriginalRows)
		If dt Is Nothing Or dv.Count = 0 Then
			If grdPurchaseOrder.Rows.Count > 1 Then result = True
		Else
			Dim delRecs As New DataView(dt, "", "", DataViewRowState.Deleted)
			If delRecs.Count > 0 Then result = True

			Dim updRecs As New DataView(dt, "", "", DataViewRowState.ModifiedCurrent)
			If updRecs.Count > 0 Then result = True

			Dim addRecs As New DataView(dt, "", "", DataViewRowState.Added)
			If addRecs.Count > 0 Then result = True
		End If

		IsDataChange = result
	End Function

	Private Sub LoadData(ByVal PONo As String)
		Dim objDB As New classPurchase
		Dim dt As New DataTable
		dt = objDB.GetPOUncloseDetail(PONo)
		Call BindGrid(dt)
	End Sub

	Private Function SaveData() As Boolean
		Dim config As New clsConfig
		Dim clsPO As New classPurchase
		Dim msgerr As String = ""
		Dim dt As DataTable = grdPurchaseOrder.DataSource

		If clsPO.ClosePO(dt, msgerr) Then
			SaveData = True
		Else
			MessageBox.Show(msgerr, "System Message", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
			SaveData = False
		End If
	End Function

	Private Sub frmSalesOrderClose_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
		Call GenComboPONo()
	End Sub

	Private Sub frmSalesOrderClose_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
		If IsDataChange() Then Call btnSave_Click(sender, e)
		e.Cancel = blnCancel
	End Sub

	Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
		Dim frm As New formSearchPO
		frm.ShowDialog(Me)
		Me.Cursor = Cursors.WaitCursor
        If frm.puserAction = "OK" Then
            If Not blnCancel Then cboPONo.ComboBox.SelectedValue = frm.pSelectedPO
        End If
        Me.Cursor = Cursors.Default
		frm.Dispose()
	End Sub

	Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
		If Not grdPurchaseOrder.EndEdit() Then Exit Sub
		blnCancel = False
        'Sitthana 20220624 Changed Windows.Forms.DialogResult To DialogResult
        Dim result As DialogResult ' Windows.Forms.DialogResult
        result = MessageBox.Show("Would you like to save ?", "System Message", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button3)
        If result = DialogResult.Cancel Then blnCancel = True
        If result <> DialogResult.Yes Then Exit Sub
        Me.Cursor = Cursors.WaitCursor
		If SaveData() Then LoadData(cboPONo.ComboBox.SelectedValue.ToString.Trim)
		Me.Cursor = Cursors.Default
	End Sub

	Private Sub cboPONo_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboPONo.SelectedIndexChanged
		If Not IsDBNull(cboPONo.ComboBox.SelectedValue.ToString) Then Call LoadData(cboPONo.ComboBox.SelectedValue.ToString.Trim)
	End Sub

	Private Sub grdSalesOrder_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles grdPurchaseOrder.KeyDown
		Dim i As Integer = 0
		If e.KeyCode = Keys.Enter Then
			If grdPurchaseOrder.Columns(grdPurchaseOrder.SelectedCells(i).ColumnIndex).Name = "closed" Then
				For i = 0 To grdPurchaseOrder.SelectedCells.Count - 1
					grdPurchaseOrder.SelectedCells(i).Value = Not CBool(grdPurchaseOrder.SelectedCells(i).Value)
				Next
			End If
		End If
	End Sub
End Class