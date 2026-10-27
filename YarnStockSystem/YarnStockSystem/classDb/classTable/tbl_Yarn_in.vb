Public Class tbl_Yarn_in
    Public docdt As Nullable(Of Date)
    Public docno As String = ""
	Public jobno As String = ""
	Public purno As String = ""
	Public sinvno As String = ""
    Public sinvdt As String = String.Empty
    'Public sinvdt As Nullable(Of Date)
    Public suppcd As String = ""
	Public lotno_sup As String = ""
	Public lotno_our As String = ""
	Public srefno As String = ""
	Public totkg As Double = 0
	Public curr As String = ""
	Public exrt As Double = 0
	Public vat As Double = 0
	Public vatamt As Double = 0
	Public taxper As Double = 0
	Public taxamt As Double = 0
	Public freight As Double = 0
	Public insurance As Double = 0
	Public otheramt As Double = 0
	Public other_text As String = 0
	Public discamt As Double = 0
	Public totamt As Double = 0
	Public tstamp As String = ""
	Public tran_type As String = ""
	Public docapp As Integer = 0
	Public cancel As Integer = 0
	Public outno As String = ""
	Public remark As String = ""
    Public tbl_Yarn_in_det() As tbl_Yarn_in_det
    'Public old_yarn_in_det As DataTable = New DataTable("old_yarn_in_det")
    'Public new_yarn_in_det As DataTable = New DataTable("new_yarn_in_det")
End Class
