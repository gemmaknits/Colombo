Public Class frmChangePassword
	Dim clsConfig As New clsConfig
	Dim clsUser As New classUserInfo
	Dim pPassword As String

	Public Property UserInfo() As classUserInfo
		Get
			UserInfo = clsUser
		End Get
		Set(ByVal NewValue As classUserInfo)
			clsUser = NewValue
		End Set
	End Property

	Public ReadOnly Property Password() As String
		Get
			Password = pPassword
		End Get
	End Property

	Private Sub frmChangePassword_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
		txtOldPassword.Focus()
	End Sub

	Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
		If txtOldPassword.Text <> clsUser.Password Then
			MessageBox.Show("ใส่ Password ผิด !!!", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
			txtOldPassword.Focus()
		ElseIf txtNewPassword.Text <> txtConfirmPassword.Text Then
			MessageBox.Show("ยืนยัน Password ไม่ตรงกัน", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
			txtConfirmPassword.Focus()
		Else
			clsConfig.ChangePassword(clsUser.UserName, txtNewPassword.Text)
			pPassword = txtNewPassword.Text
			Me.Hide()
		End If
	End Sub

	Private Sub btnMinimized_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMinimized.Click
		Me.WindowState = FormWindowState.Minimized
	End Sub
End Class