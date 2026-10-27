Public Class tbl_job_det
	Public jobno As String = ""
	Public id_jobdet As Integer = 0
	Public supquoteno As String = ""
	Public outno As String = ""
	Public itcd As String = ""
	Public itdesc As String = ""
	Public qty As Double = 0
	Public uom As String = ""
	Public price As Double = 0
	Public curr As String = ""
	Public exrt As Double = 0
	Public discper As Double = 0
	Public discamt As Double = 0
	Public lineamt As Double = 0
	Public delidt As String = ""
    Public remark As String = ""
    Public closed As Integer = 0
    Public sono As String = ""
    Public sonoid As String = ""
    Public suppitcd As String = ""

    Public freight_per_unit As Nullable(Of Double)
    Public item_unit_price As Nullable(Of Double)
    Public effective_date As Nullable(Of DateTime)
    Public rcv_warehouse_id As Nullable(Of Int64)
    Public rcv_subinventory_id As Nullable(Of Int64)

    Public POLineTypesID As Nullable(Of Int64)
End Class
