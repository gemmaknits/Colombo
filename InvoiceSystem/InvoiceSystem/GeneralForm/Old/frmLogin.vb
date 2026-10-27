Imports System
Imports System.Text

Imports System.Data.SqlClient

Public Class frmLogin
	Dim clsUser As New classUserInfo

	Public Property UserInfo() As classUserInfo
		Get
			UserInfo = clsUser
		End Get
		Set(ByVal NewValue As classUserInfo)
			clsUser = NewValue
		End Set
	End Property

	Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
		checkUser()
	End Sub

	Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
		Me.Close()
	End Sub

	Private Sub TextBox2_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox2.KeyPress
		If e.KeyChar = Chr(13) Then
			checkUser()
		End If
	End Sub

	Private Sub TextBox2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox2.TextChanged

	End Sub
	Private Sub checkUser()
		Dim cn As New SqlConnection
		Dim classConn As New classConnection
		Dim da As New SqlDataAdapter("select top 0 * from emp", classConn.connection)
		Dim ds As New DataSet
		Dim strSql As New StringBuilder
		cn.ConnectionString = classConn.connection
		strSql.Append("select * from emp where empname='")
		strSql.Append(Me.TextBox1.Text.ToString.Trim)
		strSql.Append("'")
		strSql.Append(" and password='")
		strSql.Append(Me.TextBox2.Text.Trim)
		strSql.Append("'")

		da.SelectCommand.CommandText = strSql.ToString
		da.Fill(ds, "tableEmp")
		If ds.Tables("tableEmp").Rows.Count = 0 Then
			MsgBox("Incorrect username or password, please verify..", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Access denied")
			Exit Sub
		Else
			clsUser.UserID = ds.Tables("tableEmp").Rows(0)("empcd").ToString.Trim.ToUpper
			clsUser.UserName = ds.Tables("tableEmp").Rows(0)("empname").ToString.Trim.ToUpper
			clsUser.ReportPath = GetReportPath()
		End If
		Dim formMain As New frmMainmenu
		formMain.UserInfo = clsUser
		formMain.Show()
		formMain.loginEmpcd = ds.Tables("tableEmp").Rows(0).Item("empcd")
		Me.Hide()
	End Sub

	Private Function GetReportPath() As String
		Dim conn As New SqlConnection((New classConnection).connection)
		Dim da As New SqlDataAdapter("select * from company", conn)
		Dim dt As New DataTable
		da.Fill(dt)
		GetReportPath = dt.Rows(0)("report_path").ToString.Trim.ToUpper
	End Function
End Class