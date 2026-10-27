Public Class tbl_job_det_yarn
	Public id_job_det_yarn As Integer = 0
	Public id_job_det As Integer = 0
	Public lotno_sup As String = ""
	Public lotno_our As String = ""
	Public itcd As String = ""
	Public boxno As String = ""
	Public spools As Double = 0
	Public kg_gr As Double = 0
    Public kg_nt As Double = 0
    Public actual_cone_weight As Nullable(Of Decimal)
    Public tstamp As DateTime = Today()
    Public gb As String = String.Empty
    Public sono As String = ""
    Public sonoid As String = ""
    Public mfg_production_order_line_id As Nullable(Of Int64)

End Class
