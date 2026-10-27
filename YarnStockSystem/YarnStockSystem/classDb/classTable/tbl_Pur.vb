Public Class tbl_Pur
	Public purno As String = ""
	Public purdt As DateTime = Today()
	Public suppcd As String = ""
	Public reqno As String = ""
	Public purtype As String = ""
	Public remm As String = ""
	Public import As Boolean = False
	Public curr As String = ""
	Public exrt As Integer = 0
	Public vat As Integer = 0
	Public vatamt As Integer = 0
	Public taxper As Integer = 0
	Public taxamt As Integer = 0
	Public freight As Integer = 0
	Public insurance As Integer = 0
	Public shipping As Integer = 0
	Public handling As Integer = 0
	Public miscamt As Integer = 0
	Public misc_desc As String = ""
	Public discamt As Integer = 0
	Public totamt As Integer = 0
End Class
