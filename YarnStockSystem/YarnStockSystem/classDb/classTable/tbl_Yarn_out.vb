Public Class tbl_Yarn_out
	Public outno As String = ""
    Public outdt As String = ""
    Public packno As String = ""
    Public packdt As Nullable(Of Date)
    Public tran_type As String = ""
	Public refdocno As String = ""
	Public kono As String = ""
	Public suppcd As String = ""
	Public remm As String = ""
    Public cancel As Boolean = False
    Public empcd As String = ""
    Public tbl_Yarn_out_det() As tbl_Yarn_out_det
End Class
