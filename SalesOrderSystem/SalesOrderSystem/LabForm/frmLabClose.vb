Public Class frmLabClose
	Dim clsConfig As New clsConfig
	Dim clsConn As New classConnection
	Dim clsUser As New classUserInfo
	Dim blnCancel As Boolean = False
	Dim lngLabDetID As Long = 0
	Dim dtSource As New DataTable

	Public Property UserInfo() As classUserInfo
		Get
			UserInfo = clsUser
		End Get
		Set(ByVal NewValue As classUserInfo)
			clsUser = NewValue
		End Set
	End Property

	Public Property LabDetID() As Long
		Get
			LabDetID = lngLabDetID
		End Get
		Set(ByVal NewValue As long)
			lngLabDetID = NewValue
		End Set
	End Property

	Public Property DT() As DataTable
		Get
			DT = dtSource
		End Get
		Set(ByVal NewValue As DataTable)
			dtSource = NewValue
		End Set
	End Property

	Private Sub LoadData()
		Dim objDB As New classLab
		DT = objDB.LabResultLoad(lngLabDetID)
		If DT.Rows.Count > 0 Then
			dtpReceiveDate.Value = CDate(clsConfig.IsNull(DT.Rows(0)("labrcdt2"), "01/01/1900"))
			dtpCommentDate.Value = CDate(clsConfig.IsNull(DT.Rows(0)("custreplydt2"), "01/01/1900"))
			txtComment.Text = clsConfig.IsNull(DT.Rows(0)("custcomment"), "")
			txtShade.Text = clsConfig.IsNull(DT.Rows(0)("shadeapproved"), "")
			chkApprove.Checked = CBool(clsConfig.IsNull(DT.Rows(0)("labok"), False))
			chkReject.Checked = CBool(clsConfig.IsNull(DT.Rows(0)("labnotok"), False))
			chkClosed.Checked = CBool(clsConfig.IsNull(DT.Rows(0)("labclosed"), False))
		End If
	End Sub

	Private Function SaveData() As Boolean
		Dim config As New clsConfig
		Dim clsLab As New classLab
		Dim msgerr As String = ""
		Dim dr As DataRow
		If DT.Rows.Count = 0 Then
			dr = DT.NewRow
			DT.Rows.Add(dr)
		End If

		With DT.Rows(0)
			.Item("id_labdet") = lngLabDetID
			.Item("labrcdt2") = dtpReceiveDate.Value.ToString("dd/MM/yyyy")
			.Item("custreplydt2") = dtpCommentDate.Value.ToString("dd/MM/yyyy")
			.Item("custcomment") = txtComment.Text.Trim
			.Item("shadeapproved") = txtShade.Text.Trim
			.Item("labok") = IIf(chkApprove.Checked, 1, 0)
			.Item("labnotok") = IIf(chkReject.Checked, 1, 0)
			.Item("labclosed") = IIf(chkClosed.Checked, 1, 0)
		End With

		If clsLab.LabClose(DT, msgerr, clsUser.UserID) Then
			SaveData = True
		Else
			MessageBox.Show(msgerr, "System Message", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
			SaveData = False
		End If
	End Function

	Private Sub frmLabClose_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
		Call LoadData()
	End Sub

	Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        If MessageBox.Show("Would you like to save ?", "System Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = DialogResult.No Then Exit Sub
        If SaveData() Then Me.Close()
	End Sub

	Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
		Me.Close()
	End Sub
End Class