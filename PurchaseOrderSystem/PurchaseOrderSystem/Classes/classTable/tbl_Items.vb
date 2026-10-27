Public Class tbl_Items
    Public item_id As Nullable(Of Int64)
    Public itcd As String = ""
    Public itdesc As String = ""
    Public itdesc2 As String = ""
    Public itdesc3 As String = ""
    Public itdesc_spec As String = ""
    Public itdesct As String = ""
    Public itdesct2 As String = ""
    Public itdesct3 As String = ""
    Public itnaturecd As String = ""
    Public ittypecd As String = ""
    Public itcatcd As String = ""
    Public itsubcatcd As String = ""
    Public itgroupcd As String = ""
    Public itsubcd As String = ""
    Public itsubcd2 As String = ""
    Public itsubcd3 As String = ""
    Public mrpcode As String = ""
    Public dinear As String = ""
    Public filament As String = ""
    Public twists As String = ""
    Public col As String = ""
    Public dimension As String = ""
    Public suppcd As String = ""
    Public tstamp As DateTime = Today()
    Public reorder_qty As Single = 0
    Public reorder_unit As String = ""
    Public uom2_id As Nullable(Of Int64)
    Public reorder_unit2 As String = "" 'saharat

    Public itdesc_supp As String = ""
    Public uprice_std As Single = 0
    Public maximum_qty As Single = 0
    Public warped_ends As Nullable(Of Decimal)
    Public beams_per_set As Nullable(Of Decimal)
    Public beam_length As Nullable(Of Decimal)
    Public lead_time As Nullable(Of Byte)
    Public safety_stock As Nullable(Of Byte)


End Class
