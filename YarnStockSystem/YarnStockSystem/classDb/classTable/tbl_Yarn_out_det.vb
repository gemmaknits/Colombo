Public Class tbl_Yarn_out_det
	Public id_yarn_out_det As Integer = 0
	Public outno As String = ""
	Public outdt As String = ""
	Public itcd As String = ""
	Public grade As String = ""
	Public boxno_s As String = ""
	Public boxno As String = ""
	Public lotno_sup As String = ""
    Public lotno_our As String = ""
    Public spools As Double = 0
	Public kg_gr As Double = 0
	Public cart_tearwt As Double = 0
	Public spool_tearwt As Double = 0
    Public kg_nt As Double = 0
    Public actual_cone_weight As Nullable(Of Decimal)
    Public id_job_det_yarn As Integer = 0
    Public gb As String = ""
    Public mfg_production_order_line_id As Nullable(Of Int64)
End Class
