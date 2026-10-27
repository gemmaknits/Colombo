Public Class tbl_Yarn_in_det
	Public docno As String = ""
	Public itcd As String = ""
	Public boxno_s As String = ""
	Public boxno As String = ""
	Public boxno_o As String = ""
	Public lotno_sup As String = ""
	Public lotno_our As String = ""
	Public spools As Double = 0
	Public grade As String = ""
	Public kg_gr As Double = 0
	Public cart_tearwt As Double = 0
	Public spool_tearwt As Double = 0
    Public kg_nt As Double = 0
    Public actual_cone_weight As Nullable(Of Decimal) = Nothing
	Public price As Double = 0
	Public Used As Integer = 0
    Public tstamp As String = ""
    Public location As String = ""
    Public id_jobdet As Integer = 0
    Public box_remark As String = ""
    Public grade_our As String = ""
    Public mtl_warehouse_id As Nullable(Of Int64)
    Public mtl_subinventory_id As Nullable(Of Int64)
    Public mtl_locations_id As Nullable(Of Int64)
    Public mfg_production_order_line_id As Nullable(Of Int64)
    Public id_yarn_out_det As Nullable(Of Int32)
End Class
