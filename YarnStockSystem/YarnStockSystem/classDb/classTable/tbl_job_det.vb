Public Class tbl_job_det
	Public jobno As String = ""
    Public id_jobdet As Nullable(Of Int32) = 0
    Public outno As String = ""
	Public itcd As String = ""
	Public itdesc As String = ""
    Public qty As Nullable(Of Decimal) = 0.00 'double to decimal
    Public uom As String = ""
	Public price As Double = 0
	Public curr As String = ""
	Public exrt As Double = 0
	Public discper As Double = 0
	Public discamt As Double = 0
	Public lineamt As Double = 0
	Public remark As String = ""
    Public closed As Integer = 0

	Public supquoteno As String = ""
    Public delidt As Date = "01/01/1900"
    Public sono As String = ""
    Public sonoid As String = ""
    Public mfg_production_order_line_id As Nullable(Of Int64)
End Class
