Imports System.Data
Imports System.Data.SqlClient
Imports System.Text
Public Class classStockGIN_KOManual
    Public Structure Greige_Header

        'Greige
        Dim h01_suppcd As String
        Dim h02_source As String
        Dim h03_source_refno As String
        Dim h04_tran_no As String
        Dim h05_tran_dt As Date
        Dim h06_design_no As String
        Dim h07_supdes_no As String
        Dim h08_kono As String
        Dim h09_pieces As Double
        Dim h10_nob As Double
        Dim h11_Gwth As String
        Dim h12_Gwth_actual As String
        Dim h13_roll_no As String
        Dim h14_roll_no_g As String
        Dim h15_roll_no_n As Decimal
        Dim h16_racks As Double
        Dim h17_kg As Double
        Dim h18_mts As Double
        Dim h19_yds As Double
        Dim h20_kg_qc As Double
        Dim h21_mts_qc As Double
        Dim h22_yds_qc As Double
        Dim h23_grade As String
        Dim h24_rem_qc As String
        Dim h25_loc As String
        Dim h26_outreqno As String
        Dim h27_outreqdt As Nullable(Of Date)
        Dim h28_outreqtyp As String
        Dim h29_outno As String
        Dim h30_outdt As Nullable(Of Date)
        Dim h31_lot As String
        Dim h32_yr As String
        Dim h33_sh As String
        Dim h34_dfno As String
        Dim h35_col As String
        Dim h36_dhcod As String
        Dim h37_sono As String
        Dim h38_sonoid As String
        Dim h39_roll_no_o As String
        Dim h40_pn As Double
        Dim h41_ydkg_g As Double
        Dim h42_cost As Decimal
        Dim h43_fload As Boolean
        Dim h44_rate As Decimal
        Dim h45_sel As Boolean
        Dim h46_cost_g As Double
        Dim h47_cliped As Boolean
        Dim h48_unit As String
        Dim h49_g_cost As Double
        Dim h50_tran_no1 As String
        Dim h51_tran_not As String
        Dim h52_cancel As Boolean
        Dim h53_doctyp As String
        Dim h54_preseted As Boolean
        Dim h55_qcalertcd As String
        Dim h56_ProdFinishDate As Date
        Dim h57_ProdFinishTime As String
        Dim h58_mcno As String
        Dim h59_adjust_loss_kg As Double
        Dim h60_qc_loss_kg As Double
        Dim h61_dyed_loss_kg As Double
        Dim h62_grade_bdt As String
        Dim h63_grade_adt As String
        Dim h64_dyeing_pass As Boolean
        Dim h65_dyeing_fail As Boolean
        Dim h66_shift As String
        Dim h67_id_greige_do As Int64
        Dim h68_id_greige As Int64
        Dim h69_lab_loss_kg As Double
        Dim h70_defect_loss_kg As Double
        Dim h71_purno As String
        Dim h72_tran_type As String
        Dim h73_roll_no_f As String
        Dim h74_job_line_id As String
        Dim h75_fabric_cost As Double
        Dim h76_process_cost As Double
        Dim h77_process_loss_perc As Double
        Dim h78_other_cost As Double
        Dim h79_cost_per_unit As Double
        Dim h80_sub_location As String
        Dim h81_greige_status As Byte
        Dim h82_bar_weight As Double
        Dim h83_mtl_warehouse_id As Nullable(Of Int64)
        Dim h84_mtl_subinventory_id As Nullable(Of Int64)
        Dim h85_mtl_locations_id As Nullable(Of Int64)
        Dim h86_counter_per_roll As Nullable(Of Decimal)
        Dim h87_rpm As Nullable(Of Decimal)
        Dim h88_pcv_item_id As Nullable(Of Int64)

        Dim message As String
    End Structure

    Public Structure Defect_roll_Header
        Dim h01_id_defect_roll As Int64
        Dim h02_roll_no As String
        Dim h03_defect_code As String
        Dim h04_defect_details As String
        Dim h05_stock_code As String

    End Structure

    Public Function Validate_KoNo(Optional ByVal Strkono As String = "", Optional ByVal StrEmpcd As String = "") As DataTable
        Dim conn As New SqlConnection((New classConnection).connection)
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure

        comm.CommandText = "p_greige_in_ko_manual_select_ko_validate"

        comm.Parameters.AddWithValue("@kono", Strkono)
        comm.Parameters.AddWithValue("@logempcd", StrEmpcd)
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        conn.Close()  'Sitthana 20190325
        Return (dt)
    End Function

    Public Function Validate_RollNo(Optional ByVal StrRollno As String = "", Optional ByVal StrEmpcd As String = "") As DataTable
        Dim conn As New SqlConnection((New classConnection).connection)
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure

        comm.CommandText = "p_greige_in_ko_manual_select_roll_no_validate"

        comm.Parameters.AddWithValue("@Roll_no", StrRollno)
        comm.Parameters.AddWithValue("@logempcd", StrEmpcd)
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        conn.Close()  'Sitthana 20190325
        Return (dt)
    End Function
    'Conversion Project
    Public Function GetGINKOManualSearchKO(Optional ByVal strkono As String = "", Optional ByVal strDateFr As String = "", Optional ByVal strDateTo As String = "", Optional ByVal strsuppcd As String = "") As DataTable
        Dim conn As New SqlConnection((New classConnection).connection)
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure

        comm.CommandText = "p_greige_in_ko_manual_select_ko_search"

        comm.Parameters.AddWithValue("@kono", strkono)
        comm.Parameters.AddWithValue("@datefr", strDateFr)
        comm.Parameters.AddWithValue("@dateto", strDateTo)
        comm.Parameters.AddWithValue("@suppcd", strsuppcd)
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        conn.Close()  'Sitthana 20190325
        Return dt
    End Function
    'Conversion Project
    Public Function GetGINKOBYKO(Optional ByVal strKONO As String = "", Optional ByVal strEmpCD As String = "") As DataTable
        Dim conn As New SqlConnection((New classConnection).connection)
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "p_greige_in_ko_manual_select_ko"

        comm.Parameters.AddWithValue("@kono", strKONO)
        comm.Parameters.AddWithValue("@logempcd", strEmpCD)
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        conn.Close()  'Sitthana 20190325
        Return dt

    End Function

    Public Function GetSupplier(Optional ByVal suppcd As String = "") As DataTable
        Dim conn As New SqlConnection((New classConnection).connection)
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "p_greige_in_ko_manual_select_suppliers"
        comm.Parameters.AddWithValue("@suppcd", suppcd.Trim)
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        conn.Close()  'Sitthana 20190325
        Return dt
    End Function

    Public Function GetDefect_Code(Optional ByVal StrDefect_code As String = "", Optional ByVal StrEmpCd As String = "") As DataTable
        Dim conn As New SqlConnection((New classConnection).connection)
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "p_greige_in_ko_manual_select_cbo_defect_code"
        comm.Parameters.AddWithValue("@Defect_code", StrDefect_code)
        comm.Parameters.AddWithValue("@logempcd", StrEmpCd)
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        conn.Close()  'Sitthana 20190325
        Return dt
    End Function



    Public Function GetDefect_Name(Optional ByVal StrDefect_code As String = "", Optional ByVal StrEmpCD As String = "") As String
        Dim conn As New SqlConnection((New classConnection).connection)
        Dim comm As New SqlCommand("", conn)
        Dim defect_name As String
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "p_greige_in_ko_manual_select_cbo_defect_code_get_defect_name"
        comm.Parameters.AddWithValue("@defect_code", StrDefect_code)
        comm.Parameters.AddWithValue("@logempcd", StrEmpCD)
        comm.Connection = conn
        conn.Open()
        defect_name = comm.ExecuteScalar
        conn.Close()  'Sitthana 20190325
        Return defect_name
    End Function

    Public Function GetGINKOBYTran_No(Optional ByVal strTranNo As String = "", Optional ByVal strEmpCD As String = "") As DataTable
        Dim conn As New SqlConnection((New classConnection).connection)
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "p_greige_in_ko_manual_select_tran_no"
        comm.Parameters.AddWithValue("@Tran_no", strTranNo)
        comm.Parameters.AddWithValue("@logempcd", strEmpCD)
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        conn.Close()  'Sitthana 20190325
        Return (dt)
    End Function
    Public Function GetGINKOBYRollNo(Optional ByVal strRollNo As String = "", Optional ByVal strEmpCD As String = "") As DataTable
        Dim conn As New SqlConnection((New classConnection).connection)
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "p_greige_in_ko_manual_select_roll_no"
        comm.Parameters.AddWithValue("@roll_no", strRollNo)
        comm.Parameters.AddWithValue("@logempcd", strEmpCD)
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        conn.Close()  'Sitthana 20190325
        Return (dt)
    End Function
    Public Function GetDefectRoll(Optional ByVal strrollNo As String = "", Optional ByVal strEmpCD As String = "") As DataTable
        Dim conn As New SqlConnection((New classConnection).connection)
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "p_greige_in_ko_manual_select_defect_roll"
        comm.Parameters.AddWithValue("@roll_no", strrollNo)
        comm.Parameters.AddWithValue("@logempcd", strEmpCD)
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        conn.Close()  'Sitthana 20190325
        Return (dt)

    End Function
    Public Function GetCBOGINKOmanualNo(Optional ByVal StrTran_no As String = "", Optional ByVal strEmpcd As String = "") As DataTable
        Dim conn As New SqlConnection((New classConnection).connection)
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "p_greige_in_ko_manual_select_cbo_gin"
        comm.Parameters.AddWithValue("@tran_no", StrTran_no)
        comm.Parameters.AddWithValue("@logempcd", strEmpcd)
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        conn.Close()  'Sitthana 20190325
        Return dt
    End Function

    Public Function GetCBOGINKOmanualRollNo(Optional ByVal StrRoll_no As String = "", Optional ByVal strEmpcd As String = "") As DataTable
        Dim conn As New SqlConnection((New classConnection).connection)
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "p_greige_in_ko_manual_select_cbo_roll_no"
        comm.Parameters.AddWithValue("@Roll_no", StrRoll_no)
        comm.Parameters.AddWithValue("@logempcd", strEmpcd)
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        conn.Close()  'Sitthana 20190325
        Return dt
    End Function

    Public Function GetGINKOBYKODS(Optional ByVal strKONO As String = "", Optional ByVal strEmpCD As String = "") As DataSet
        Dim conn As New SqlConnection((New classConnection).connection)
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "p_greige_in_ko_manual_select_ko"

        comm.Parameters.AddWithValue("@kono", strKONO)
        comm.Parameters.AddWithValue("@logempcd", strEmpCD)
        Dim da As New SqlDataAdapter(comm)
        Dim ds As New DataSet
        da.Fill(ds, "v_grige_in_ko")
        conn.Close()  'Sitthana 20190325
        Return ds
    End Function

    'Public Function GetDEFECTROLL(Optional ByVal StrRollNo As String = "", Optional ByVal strEmpCD As String = "") As DataTable
    '    Dim conn As New SqlConnection((New classConnection).connection)
    '    Dim comm As New SqlCommand("", conn)
    '    comm.CommandType = CommandType.StoredProcedure
    '    comm.CommandText = "p_greige_in_ko_manual_select_defect_roll"
    '    comm.Parameters.AddWithValue("@roll_no", StrRollNo)
    '    comm.Parameters.AddWithValue("@logempcd", strEmpCD)
    '    Dim da As New SqlDataAdapter(comm)
    '    Dim dt As New DataTable
    '    da.Fill(dt)
    '    Return dt
    'End Function
    'Conversion Project
    Public Function GIN_KOManualCancel(ByVal Gin_header As Greige_Header, ByRef Msgerr As String, ByVal dtc As DataTable, ByVal UserID As String, ByVal tran_no As String) As Boolean
        Dim config As New clsConfig
        Dim conn As New SqlConnection((New classConnection).connection)
        conn.Open()
        Dim tran As SqlTransaction = conn.BeginTransaction
        Dim comm As New SqlCommand("", conn)
        Dim i As Integer = 0
        Dim j As Integer = 0
        Dim strLotno As String = ""
        Dim Action As String = ""
        comm.Transaction = tran
        comm.CommandType = CommandType.StoredProcedure

        'Start  Add PLD bin-----------
        comm.CommandText = "p_greige_in_ko_manual_insert_bin"
        With Gin_header
            comm.Parameters.Clear()
            comm.Parameters.AddWithValue("@suppcd", Gin_header.h01_suppcd)
            comm.Parameters.AddWithValue("@source", Gin_header.h02_source)
            comm.Parameters.AddWithValue("@source_refno", Gin_header.h03_source_refno)
            comm.Parameters.AddWithValue("@tran_no", Gin_header.h04_tran_no)    'Tran_No = GIN NO
            comm.Parameters.AddWithValue("@tran_dt", Gin_header.h05_tran_dt)         'Tran_Dt = GIN Date
            comm.Parameters.AddWithValue("@design_no", Gin_header.h06_design_no)
            comm.Parameters.AddWithValue("@supdes_no", Gin_header.h07_supdes_no)
            comm.Parameters.AddWithValue("@kono", Gin_header.h08_kono)
            comm.Parameters.AddWithValue("@pieces", Gin_header.h09_pieces)
            comm.Parameters.AddWithValue("@nob", Gin_header.h10_nob)
            comm.Parameters.AddWithValue("@Gwth", Gin_header.h11_Gwth)
            comm.Parameters.AddWithValue("@Gwth_actual", Gin_header.h12_Gwth_actual)
            comm.Parameters.AddWithValue("@roll_no", Gin_header.h13_roll_no)
            comm.Parameters.AddWithValue("@roll_no_g", Gin_header.h14_roll_no_g)
            comm.Parameters.AddWithValue("@roll_no_n", Gin_header.h15_roll_no_n)
            comm.Parameters.AddWithValue("@racks", Gin_header.h16_racks)
            comm.Parameters.AddWithValue("@kg", Gin_header.h17_kg)
            comm.Parameters.AddWithValue("@mts", Gin_header.h18_mts)
            comm.Parameters.AddWithValue("@yds", Gin_header.h19_yds)
            comm.Parameters.AddWithValue("@kg_qc", Gin_header.h20_kg_qc)
            comm.Parameters.AddWithValue("@mts_qc", Gin_header.h21_mts_qc)
            comm.Parameters.AddWithValue("@yds_qc", Gin_header.h22_yds_qc)
            comm.Parameters.AddWithValue("@grade", Gin_header.h23_grade)
            comm.Parameters.AddWithValue("@rem_qc", Gin_header.h24_rem_qc)
            comm.Parameters.AddWithValue("@loc", Gin_header.h25_loc)           'Loc = ESC
            comm.Parameters.AddWithValue("@outreqno", Gin_header.h26_outreqno)
            comm.Parameters.AddWithValue("@outreqdt", Gin_header.h27_outreqdt)
            comm.Parameters.AddWithValue("@outreqtyp", Gin_header.h28_outreqtyp)
            comm.Parameters.AddWithValue("@outno", Gin_header.h29_outno)
            comm.Parameters.AddWithValue("@outdt", Gin_header.h30_outdt)
            comm.Parameters.AddWithValue("@lot", Gin_header.h31_lot)
            comm.Parameters.AddWithValue("@yr", Gin_header.h32_yr)
            comm.Parameters.AddWithValue("@sh", Gin_header.h33_sh)
            comm.Parameters.AddWithValue("@dfno", Gin_header.h34_dfno)
            comm.Parameters.AddWithValue("@col", Gin_header.h35_col)
            comm.Parameters.AddWithValue("@dhcod", Gin_header.h36_dhcod)
            comm.Parameters.AddWithValue("@sono", Gin_header.h37_sono)
            comm.Parameters.AddWithValue("@sonoid", Gin_header.h38_sonoid)
            comm.Parameters.AddWithValue("@roll_no_o", Gin_header.h39_roll_no_o)
            comm.Parameters.AddWithValue("@pn", Gin_header.h40_pn)
            comm.Parameters.AddWithValue("@ydkg_g", Gin_header.h41_ydkg_g)
            comm.Parameters.AddWithValue("@cost", Gin_header.h42_cost)
            comm.Parameters.AddWithValue("@fload", Gin_header.h43_fload)
            comm.Parameters.AddWithValue("@rate", Gin_header.h44_rate)
            comm.Parameters.AddWithValue("@sel", Gin_header.h45_sel)
            comm.Parameters.AddWithValue("@cost_g", Gin_header.h46_cost_g)
            comm.Parameters.AddWithValue("@cliped", Gin_header.h47_cliped)
            comm.Parameters.AddWithValue("@unit", Gin_header.h48_unit)
            comm.Parameters.AddWithValue("@g_cost", Gin_header.h49_g_cost)
            comm.Parameters.AddWithValue("@tran_no1", Gin_header.h50_tran_no1)
            comm.Parameters.AddWithValue("@tran_not", Gin_header.h51_tran_not)
            comm.Parameters.AddWithValue("@cancel", Gin_header.h52_cancel)
            comm.Parameters.AddWithValue("@doctyp", Gin_header.h53_doctyp)
            comm.Parameters.AddWithValue("@preseted", Gin_header.h54_preseted)                'Preseted = 0
            comm.Parameters.AddWithValue("@qcalertcd", Gin_header.h55_qcalertcd)
            comm.Parameters.AddWithValue("@ProdFinishDate", Gin_header.h56_ProdFinishDate)
            comm.Parameters.AddWithValue("@ProdFinishTime", Gin_header.h57_ProdFinishTime)
            comm.Parameters.AddWithValue("@mcno", Gin_header.h58_mcno)
            comm.Parameters.AddWithValue("@adjust_loss_kg", Gin_header.h59_adjust_loss_kg)
            comm.Parameters.AddWithValue("@qc_loss_kg", Gin_header.h60_qc_loss_kg)
            comm.Parameters.AddWithValue("@dyed_loss_kg", Gin_header.h61_dyed_loss_kg)
            comm.Parameters.AddWithValue("@grade_bdt", Gin_header.h62_grade_bdt)
            comm.Parameters.AddWithValue("@grade_adt", Gin_header.h63_grade_adt)
            comm.Parameters.AddWithValue("@dyeing_pass", Gin_header.h64_dyeing_pass)
            comm.Parameters.AddWithValue("@dyeing_fail", Gin_header.h65_dyeing_fail)
            comm.Parameters.AddWithValue("@shift", Gin_header.h66_shift)
            comm.Parameters.AddWithValue("@id_greige_do", Gin_header.h67_id_greige_do)
            comm.Parameters.AddWithValue("@id_greige", Gin_header.h68_id_greige)
            comm.Parameters.AddWithValue("@lab_loss_kg", Gin_header.h69_lab_loss_kg)
            comm.Parameters.AddWithValue("@defect_loss_kg", Gin_header.h70_defect_loss_kg)
            comm.Parameters.AddWithValue("@purno", Gin_header.h71_purno)
            comm.Parameters.AddWithValue("@tran_type", Gin_header.h72_tran_type)            'Tran_Type = KNITTING
            comm.Parameters.AddWithValue("@roll_no_f", Gin_header.h73_roll_no_f)
            comm.Parameters.AddWithValue("@job_line_id", Gin_header.h74_job_line_id)
            comm.Parameters.AddWithValue("@fabric_cost", Gin_header.h75_fabric_cost)
            comm.Parameters.AddWithValue("@process_cost", Gin_header.h76_process_cost)
            comm.Parameters.AddWithValue("@process_loss_perc", Gin_header.h77_process_loss_perc)
            comm.Parameters.AddWithValue("@other_cost", Gin_header.h78_other_cost)
            comm.Parameters.AddWithValue("@cost_per_unit", Gin_header.h79_cost_per_unit)
            comm.Parameters.AddWithValue("@sub_location", Gin_header.h80_sub_location)          'sub_location = ESC
            comm.Parameters.AddWithValue("@greige_status", Gin_header.h81_greige_status)
            comm.Parameters.AddWithValue("@bar_weight", Gin_header.h82_bar_weight)
            comm.Parameters.AddWithValue("@logempcd", UserID.Trim)
        End With

        Dim dap_add As New SqlDataAdapter(comm)
        Dim dtp_add As New DataTable
        Try
            dap_add.Fill(dtp_add)
        Catch ex As Exception
            Msgerr = ex.Message
            tran.Rollback()
            conn.Close()  'Sitthana 20190325
            Return False

        End Try
        'Gin_header.h04_tran_no = dfc.Rows(0)("tran_no").ToString.Trim

        'End  Add PLG bin-----------

        comm.CommandText = "p_greige_in_ko_manual_delete"
        With Gin_header
            comm.Parameters.Clear()
            comm.Parameters.AddWithValue("@suppcd", Gin_header.h01_suppcd)
            comm.Parameters.AddWithValue("@source", Gin_header.h02_source)
            comm.Parameters.AddWithValue("@source_refno", Gin_header.h03_source_refno)
            comm.Parameters.AddWithValue("@tran_no", Gin_header.h04_tran_no)    'Tran_No = GIN NO
            comm.Parameters.AddWithValue("@tran_dt", Gin_header.h05_tran_dt)         'Tran_Dt = GIN Date
            comm.Parameters.AddWithValue("@design_no", Gin_header.h06_design_no)
            comm.Parameters.AddWithValue("@supdes_no", Gin_header.h07_supdes_no)
            comm.Parameters.AddWithValue("@kono", Gin_header.h08_kono)
            comm.Parameters.AddWithValue("@pieces", Gin_header.h09_pieces)
            comm.Parameters.AddWithValue("@nob", Gin_header.h10_nob)
            comm.Parameters.AddWithValue("@Gwth", Gin_header.h11_Gwth)
            comm.Parameters.AddWithValue("@Gwth_actual", Gin_header.h12_Gwth_actual)
            comm.Parameters.AddWithValue("@roll_no", Gin_header.h13_roll_no)
            comm.Parameters.AddWithValue("@roll_no_g", Gin_header.h14_roll_no_g)
            comm.Parameters.AddWithValue("@roll_no_n", Gin_header.h15_roll_no_n)
            comm.Parameters.AddWithValue("@racks", Gin_header.h16_racks)
            comm.Parameters.AddWithValue("@kg", Gin_header.h17_kg)
            comm.Parameters.AddWithValue("@mts", Gin_header.h18_mts)
            comm.Parameters.AddWithValue("@yds", Gin_header.h19_yds)
            comm.Parameters.AddWithValue("@kg_qc", Gin_header.h20_kg_qc)
            comm.Parameters.AddWithValue("@mts_qc", Gin_header.h21_mts_qc)
            comm.Parameters.AddWithValue("@yds_qc", Gin_header.h22_yds_qc)
            comm.Parameters.AddWithValue("@grade", Gin_header.h23_grade)
            comm.Parameters.AddWithValue("@rem_qc", Gin_header.h24_rem_qc)
            comm.Parameters.AddWithValue("@loc", Gin_header.h25_loc)           'Loc = ESC
            comm.Parameters.AddWithValue("@outreqno", Gin_header.h26_outreqno)
            comm.Parameters.AddWithValue("@outreqdt", Gin_header.h27_outreqdt)
            comm.Parameters.AddWithValue("@outreqtyp", Gin_header.h28_outreqtyp)
            comm.Parameters.AddWithValue("@outno", Gin_header.h29_outno)
            comm.Parameters.AddWithValue("@outdt", Gin_header.h30_outdt)
            comm.Parameters.AddWithValue("@lot", Gin_header.h31_lot)
            comm.Parameters.AddWithValue("@yr", Gin_header.h32_yr)
            comm.Parameters.AddWithValue("@sh", Gin_header.h33_sh)
            comm.Parameters.AddWithValue("@dfno", Gin_header.h34_dfno)
            comm.Parameters.AddWithValue("@col", Gin_header.h35_col)
            comm.Parameters.AddWithValue("@dhcod", Gin_header.h36_dhcod)
            comm.Parameters.AddWithValue("@sono", Gin_header.h37_sono)
            comm.Parameters.AddWithValue("@sonoid", Gin_header.h38_sonoid)
            comm.Parameters.AddWithValue("@roll_no_o", Gin_header.h39_roll_no_o)
            comm.Parameters.AddWithValue("@pn", Gin_header.h40_pn)
            comm.Parameters.AddWithValue("@ydkg_g", Gin_header.h41_ydkg_g)
            comm.Parameters.AddWithValue("@cost", Gin_header.h42_cost)
            comm.Parameters.AddWithValue("@fload", Gin_header.h43_fload)
            comm.Parameters.AddWithValue("@rate", Gin_header.h44_rate)
            comm.Parameters.AddWithValue("@sel", Gin_header.h45_sel)
            comm.Parameters.AddWithValue("@cost_g", Gin_header.h46_cost_g)
            comm.Parameters.AddWithValue("@cliped", Gin_header.h47_cliped)
            comm.Parameters.AddWithValue("@unit", Gin_header.h48_unit)
            comm.Parameters.AddWithValue("@g_cost", Gin_header.h49_g_cost)
            comm.Parameters.AddWithValue("@tran_no1", Gin_header.h50_tran_no1)
            comm.Parameters.AddWithValue("@tran_not", Gin_header.h51_tran_not)
            comm.Parameters.AddWithValue("@cancel", Gin_header.h52_cancel)
            comm.Parameters.AddWithValue("@doctyp", Gin_header.h53_doctyp)
            comm.Parameters.AddWithValue("@preseted", Gin_header.h54_preseted)                'Preseted = 0
            comm.Parameters.AddWithValue("@qcalertcd", Gin_header.h55_qcalertcd)
            comm.Parameters.AddWithValue("@ProdFinishDate", Gin_header.h56_ProdFinishDate)
            comm.Parameters.AddWithValue("@ProdFinishTime", Gin_header.h57_ProdFinishTime)
            comm.Parameters.AddWithValue("@mcno", Gin_header.h58_mcno)
            comm.Parameters.AddWithValue("@adjust_loss_kg", Gin_header.h59_adjust_loss_kg)
            comm.Parameters.AddWithValue("@qc_loss_kg", Gin_header.h60_qc_loss_kg)
            comm.Parameters.AddWithValue("@dyed_loss_kg", Gin_header.h61_dyed_loss_kg)
            comm.Parameters.AddWithValue("@grade_bdt", Gin_header.h62_grade_bdt)
            comm.Parameters.AddWithValue("@grade_adt", Gin_header.h63_grade_adt)
            comm.Parameters.AddWithValue("@dyeing_pass", Gin_header.h64_dyeing_pass)
            comm.Parameters.AddWithValue("@dyeing_fail", Gin_header.h65_dyeing_fail)
            comm.Parameters.AddWithValue("@shift", Gin_header.h66_shift)
            comm.Parameters.AddWithValue("@id_greige_do", Gin_header.h67_id_greige_do)
            comm.Parameters.AddWithValue("@id_greige", Gin_header.h68_id_greige)
            comm.Parameters.AddWithValue("@lab_loss_kg", Gin_header.h69_lab_loss_kg)
            comm.Parameters.AddWithValue("@defect_loss_kg", Gin_header.h70_defect_loss_kg)
            comm.Parameters.AddWithValue("@purno", Gin_header.h71_purno)
            comm.Parameters.AddWithValue("@tran_type", Gin_header.h72_tran_type)            'Tran_Type = KNITTING
            comm.Parameters.AddWithValue("@roll_no_f", Gin_header.h73_roll_no_f)
            comm.Parameters.AddWithValue("@job_line_id", Gin_header.h74_job_line_id)
            comm.Parameters.AddWithValue("@fabric_cost", Gin_header.h75_fabric_cost)
            comm.Parameters.AddWithValue("@process_cost", Gin_header.h76_process_cost)
            comm.Parameters.AddWithValue("@process_loss_perc", Gin_header.h77_process_loss_perc)
            comm.Parameters.AddWithValue("@other_cost", Gin_header.h78_other_cost)
            comm.Parameters.AddWithValue("@cost_per_unit", Gin_header.h79_cost_per_unit)
            comm.Parameters.AddWithValue("@sub_location", Gin_header.h80_sub_location)          'sub_location = ESC
            comm.Parameters.AddWithValue("@greige_status", Gin_header.h81_greige_status)
            comm.Parameters.AddWithValue("@bar_weight", Gin_header.h82_bar_weight)
            comm.Parameters.AddWithValue("@logempcd", UserID.Trim)

        End With
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        Try
            da.Fill(dt)
        Catch ex As Exception
            Msgerr = ex.Message
            tran.Rollback()
            conn.Close()  'Sitthana 20190325
            Return False
        End Try

        If Action = "" Then Action = "CANCEL"
        comm.CommandText = "sp_insert_ACTION"
        j = 0
        Dim doctyp As String = "GIN"
        With Gin_header
            comm.Parameters.Clear()
            comm.Parameters.AddWithValue("@empcd", UserID.Trim)
            comm.Parameters.AddWithValue("@docno", Gin_header.h04_tran_no)
            comm.Parameters.AddWithValue("@workdt", Now)
            comm.Parameters.AddWithValue("@doctyp", doctyp)
            comm.Parameters.AddWithValue("@worktyp", Action)

        End With
        'Dim sql As String = config.BuildSQL(comm)
        Dim da_sp = New SqlDataAdapter(comm)
        Dim dt_sp = New DataTable
        Try
            da_sp.Fill(dt_sp)
        Catch ex As Exception
            Msgerr = ex.Message
            tran.Rollback()
            conn.Close()  'Sitthana 20190325
            Return False
        End Try


        'End Insert Action----------
        tran_no = Gin_header.h04_tran_no
        'Roll_no = Gin_header.h13_roll_no
        tran.Commit()
        conn.Close()  'Sitthana 20190325
        Return True

    End Function
    Public Function GIN_KOManualsave(ByVal Gin_header As Greige_Header, ByVal Defect_Roll_Header As Defect_roll_Header, ByRef msgerr As String, ByVal dfc As DataTable, ByVal DV_DTC_ADD As DataView, ByVal DV_DTC_UPD As DataView, ByVal DV_DTC_DEL As DataView, ByRef UserID As String, ByRef Tran_no As String, ByRef Roll_no As String) As Boolean
        Dim config As New clsConfig
        Dim conn As New SqlConnection((New classConnection).connection)
        conn.Open()
        Dim tran As SqlTransaction = conn.BeginTransaction
        Dim comm As New SqlCommand("", conn)
        Dim i As Integer = 0
        Dim j As Integer = 0
        Dim strLotNo As String = ""
        Dim strRoll_no_o As String = ""
        Dim Action As String = ""
        comm.Transaction = tran
        comm.CommandType = CommandType.StoredProcedure

        'Start Gen GIN No----------
        comm.CommandText = "p_greige_in_ko_manual_gen_doc"
        With Gin_header
            comm.Parameters.Clear()
            comm.Parameters.AddWithValue("@tran_no", Gin_header.h04_tran_no)
            comm.Parameters.AddWithValue("@tran_dt", Gin_header.h05_tran_dt) 'Tran_Dt = GIN Date
            comm.Parameters.AddWithValue("@kono", Gin_header.h08_kono)
            comm.Parameters.AddWithValue("@tran_type", Gin_header.h72_tran_type)            'Tran_Type = KNITTING
            comm.Parameters.AddWithValue("@empcd", UserID.Trim)
            comm.Parameters.AddWithValue("@checknew", "")
        End With
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        Try
            da.Fill(dt)
        Catch ex As Exception
            msgerr = ex.Message
            tran.Rollback()
            conn.Close()  'Sitthana 20190325
            Return False

        End Try
        Gin_header.h04_tran_no = dt.Rows(0)("tran_no").ToString.Trim

        'END Gen GIN No----------

        'START Insert GIN KO Manual---
        comm.CommandText = "p_greige_in_ko_manual_insert"
        With Gin_header
            comm.Parameters.Clear()
            comm.Parameters.AddWithValue("@suppcd", Gin_header.h01_suppcd)
            comm.Parameters.AddWithValue("@source", Gin_header.h02_source)
            comm.Parameters.AddWithValue("@source_refno", Gin_header.h03_source_refno)
            comm.Parameters.AddWithValue("@tran_no", Gin_header.h04_tran_no)    'Tran_No = GIN NO
            comm.Parameters.AddWithValue("@tran_dt", Gin_header.h05_tran_dt)         'Tran_Dt = GIN Date
            comm.Parameters.AddWithValue("@design_no", Gin_header.h06_design_no)
            comm.Parameters.AddWithValue("@supdes_no", Gin_header.h07_supdes_no)
            comm.Parameters.AddWithValue("@kono", Gin_header.h08_kono)
            comm.Parameters.AddWithValue("@pieces", Gin_header.h09_pieces)
            comm.Parameters.AddWithValue("@nob", Gin_header.h10_nob)
            comm.Parameters.AddWithValue("@Gwth", Gin_header.h11_Gwth)
            comm.Parameters.AddWithValue("@Gwth_actual", Gin_header.h12_Gwth_actual)
            comm.Parameters.AddWithValue("@roll_no", Gin_header.h13_roll_no)
            comm.Parameters.AddWithValue("@roll_no_g", Gin_header.h14_roll_no_g)
            comm.Parameters.AddWithValue("@roll_no_n", Gin_header.h15_roll_no_n)
            comm.Parameters.AddWithValue("@racks", Gin_header.h16_racks)
            comm.Parameters.AddWithValue("@kg", Gin_header.h17_kg)
            comm.Parameters.AddWithValue("@mts", Gin_header.h18_mts)
            comm.Parameters.AddWithValue("@yds", Gin_header.h19_yds)
            comm.Parameters.AddWithValue("@kg_qc", Gin_header.h20_kg_qc)
            comm.Parameters.AddWithValue("@mts_qc", Gin_header.h21_mts_qc)
            comm.Parameters.AddWithValue("@yds_qc", Gin_header.h22_yds_qc)
            comm.Parameters.AddWithValue("@grade", Gin_header.h23_grade)
            comm.Parameters.AddWithValue("@rem_qc", Gin_header.h24_rem_qc)
            comm.Parameters.AddWithValue("@loc", Gin_header.h25_loc)           'Loc = ESC
            comm.Parameters.AddWithValue("@outreqno", Gin_header.h26_outreqno)
            comm.Parameters.AddWithValue("@outreqdt", Gin_header.h27_outreqdt)
            comm.Parameters.AddWithValue("@outreqtyp", Gin_header.h28_outreqtyp)
            comm.Parameters.AddWithValue("@outno", Gin_header.h29_outno)
            comm.Parameters.AddWithValue("@outdt", Gin_header.h30_outdt)
            comm.Parameters.AddWithValue("@lot", Gin_header.h31_lot)
            comm.Parameters.AddWithValue("@yr", Gin_header.h32_yr)
            comm.Parameters.AddWithValue("@sh", Gin_header.h33_sh)
            comm.Parameters.AddWithValue("@dfno", Gin_header.h34_dfno)
            comm.Parameters.AddWithValue("@col", Gin_header.h35_col)
            comm.Parameters.AddWithValue("@dhcod", Gin_header.h36_dhcod)
            comm.Parameters.AddWithValue("@sono", Gin_header.h37_sono)
            comm.Parameters.AddWithValue("@sonoid", Gin_header.h38_sonoid)
            comm.Parameters.AddWithValue("@roll_no_o", Gin_header.h39_roll_no_o)
            comm.Parameters.AddWithValue("@pn", Gin_header.h40_pn)
            comm.Parameters.AddWithValue("@ydkg_g", Gin_header.h41_ydkg_g)
            comm.Parameters.AddWithValue("@cost", Gin_header.h42_cost)
            comm.Parameters.AddWithValue("@fload", Gin_header.h43_fload)
            comm.Parameters.AddWithValue("@rate", Gin_header.h44_rate)
            comm.Parameters.AddWithValue("@sel", Gin_header.h45_sel)
            comm.Parameters.AddWithValue("@cost_g", Gin_header.h46_cost_g)
            comm.Parameters.AddWithValue("@cliped", Gin_header.h47_cliped)
            comm.Parameters.AddWithValue("@unit", Gin_header.h48_unit)
            comm.Parameters.AddWithValue("@g_cost", Gin_header.h49_g_cost)
            comm.Parameters.AddWithValue("@tran_no1", Gin_header.h50_tran_no1)
            comm.Parameters.AddWithValue("@tran_not", Gin_header.h51_tran_not)
            comm.Parameters.AddWithValue("@cancel", Gin_header.h52_cancel)
            comm.Parameters.AddWithValue("@doctyp", Gin_header.h53_doctyp)
            comm.Parameters.AddWithValue("@preseted", Gin_header.h54_preseted)                'Preseted = 0
            comm.Parameters.AddWithValue("@qcalertcd", Gin_header.h55_qcalertcd)
            comm.Parameters.AddWithValue("@ProdFinishDate", Gin_header.h56_ProdFinishDate)
            comm.Parameters.AddWithValue("@ProdFinishTime", Gin_header.h57_ProdFinishTime)
            comm.Parameters.AddWithValue("@mcno", Gin_header.h58_mcno)
            comm.Parameters.AddWithValue("@adjust_loss_kg", Gin_header.h59_adjust_loss_kg)
            comm.Parameters.AddWithValue("@qc_loss_kg", Gin_header.h60_qc_loss_kg)
            comm.Parameters.AddWithValue("@dyed_loss_kg", Gin_header.h61_dyed_loss_kg)
            comm.Parameters.AddWithValue("@grade_bdt", Gin_header.h62_grade_bdt)
            comm.Parameters.AddWithValue("@grade_adt", Gin_header.h63_grade_adt)
            comm.Parameters.AddWithValue("@dyeing_pass", Gin_header.h64_dyeing_pass)
            comm.Parameters.AddWithValue("@dyeing_fail", Gin_header.h65_dyeing_fail)
            comm.Parameters.AddWithValue("@shift", Gin_header.h66_shift)
            comm.Parameters.AddWithValue("@id_greige_do", Gin_header.h67_id_greige_do)
            comm.Parameters.AddWithValue("@id_greige", Gin_header.h68_id_greige)
            comm.Parameters.AddWithValue("@lab_loss_kg", Gin_header.h69_lab_loss_kg)
            comm.Parameters.AddWithValue("@defect_loss_kg", Gin_header.h70_defect_loss_kg)
            comm.Parameters.AddWithValue("@purno", Gin_header.h71_purno)
            comm.Parameters.AddWithValue("@tran_type", Gin_header.h72_tran_type)            'Tran_Type = KNITTING
            comm.Parameters.AddWithValue("@roll_no_f", Gin_header.h73_roll_no_f)
            comm.Parameters.AddWithValue("@job_line_id", Gin_header.h74_job_line_id)
            comm.Parameters.AddWithValue("@fabric_cost", Gin_header.h75_fabric_cost)
            comm.Parameters.AddWithValue("@process_cost", Gin_header.h76_process_cost)
            comm.Parameters.AddWithValue("@process_loss_perc", Gin_header.h77_process_loss_perc)
            comm.Parameters.AddWithValue("@other_cost", Gin_header.h78_other_cost)
            comm.Parameters.AddWithValue("@cost_per_unit", Gin_header.h79_cost_per_unit)
            comm.Parameters.AddWithValue("@sub_location", Gin_header.h80_sub_location)          'sub_location = ESC
            comm.Parameters.AddWithValue("@greige_status", Gin_header.h81_greige_status)
            comm.Parameters.AddWithValue("@bar_weight", Gin_header.h82_bar_weight)
            comm.Parameters.AddWithValue("@mtl_warehouse_id", Gin_header.h83_mtl_warehouse_id)
            comm.Parameters.AddWithValue("@mtl_locations_id", Gin_header.h85_mtl_locations_id)
            comm.Parameters.AddWithValue("@pcv_item_id", Gin_header.h88_pcv_item_id)
            comm.Parameters.AddWithValue("@logempcd", UserID.Trim)


        End With
        Dim dai As New SqlDataAdapter(comm)
        Dim dti As New DataTable
        Try
            dai.Fill(dti)
        Catch ex As Exception
            msgerr = ex.Message
            tran.Rollback()
            conn.Close()  'Sitthana 20190325
            Return False

        End Try

        'GET DATA FROM INSERT GIN
        Gin_header.h05_tran_dt = dti.Rows(0)("tran_dt").ToString.Trim   'GET DATA FROM INSERT GIN
        Gin_header.h13_roll_no = dti.Rows(0)("roll_no").ToString.Trim   'GET DATA FROM INSERT GIN
        Gin_header.h14_roll_no_g = dti.Rows(0)("roll_no_g").ToString.Trim   'GET DATA FROM INSERT GIN
        Gin_header.h15_roll_no_n = dti.Rows(0)("roll_no_n").ToString.Trim   'GET DATA FROM INSERT GIN
        Gin_header.h39_roll_no_o = dti.Rows(0)("roll_no_o").ToString.Trim   'GET DATA FROM INSERT GIN
        Gin_header.h56_ProdFinishDate = dti.Rows(0)("ProdFinishDate").ToString.Trim  'GET DATA FROM INSERT GIN
        Gin_header.h73_roll_no_f = dti.Rows(0)("roll_no_f").ToString.Trim    'GET DATA FROM INSERT GIN

        'END Insert GIN KO Manual

        'START Insert GIN KO Manual---

        comm.CommandText = "p_greige_in_ko_manual_update"
        With Gin_header
            comm.Parameters.Clear()
            comm.Parameters.AddWithValue("@suppcd", Gin_header.h01_suppcd)
            comm.Parameters.AddWithValue("@source", Gin_header.h02_source)
            comm.Parameters.AddWithValue("@source_refno", Gin_header.h03_source_refno)
            comm.Parameters.AddWithValue("@tran_no", Gin_header.h04_tran_no)    'Tran_No = GIN NO
            comm.Parameters.AddWithValue("@tran_dt", Gin_header.h05_tran_dt)         'Tran_Dt = GIN Date
            comm.Parameters.AddWithValue("@design_no", Gin_header.h06_design_no)
            comm.Parameters.AddWithValue("@supdes_no", Gin_header.h07_supdes_no)
            comm.Parameters.AddWithValue("@kono", Gin_header.h08_kono)
            comm.Parameters.AddWithValue("@pieces", Gin_header.h09_pieces)
            comm.Parameters.AddWithValue("@nob", Gin_header.h10_nob)
            comm.Parameters.AddWithValue("@Gwth", Gin_header.h11_Gwth)
            comm.Parameters.AddWithValue("@Gwth_actual", Gin_header.h12_Gwth_actual)
            comm.Parameters.AddWithValue("@roll_no", Gin_header.h13_roll_no)
            comm.Parameters.AddWithValue("@roll_no_g", Gin_header.h14_roll_no_g)
            comm.Parameters.AddWithValue("@roll_no_n", Gin_header.h15_roll_no_n)
            comm.Parameters.AddWithValue("@racks", Gin_header.h16_racks)
            comm.Parameters.AddWithValue("@kg", Gin_header.h17_kg)
            comm.Parameters.AddWithValue("@mts", Gin_header.h18_mts)
            comm.Parameters.AddWithValue("@yds", Gin_header.h19_yds)
            comm.Parameters.AddWithValue("@kg_qc", Gin_header.h20_kg_qc)
            comm.Parameters.AddWithValue("@mts_qc", Gin_header.h21_mts_qc)
            comm.Parameters.AddWithValue("@yds_qc", Gin_header.h22_yds_qc)
            comm.Parameters.AddWithValue("@grade", Gin_header.h23_grade)
            comm.Parameters.AddWithValue("@rem_qc", Gin_header.h24_rem_qc)
            comm.Parameters.AddWithValue("@loc", Gin_header.h25_loc)           'Loc = NEW
            comm.Parameters.AddWithValue("@outreqno", Gin_header.h26_outreqno)
            comm.Parameters.AddWithValue("@outreqdt", Gin_header.h27_outreqdt)
            comm.Parameters.AddWithValue("@outreqtyp", Gin_header.h28_outreqtyp)
            comm.Parameters.AddWithValue("@outno", Gin_header.h29_outno)
            comm.Parameters.AddWithValue("@outdt", Gin_header.h30_outdt)
            comm.Parameters.AddWithValue("@lot", Gin_header.h31_lot)
            comm.Parameters.AddWithValue("@yr", Gin_header.h32_yr)
            comm.Parameters.AddWithValue("@sh", Gin_header.h33_sh)
            comm.Parameters.AddWithValue("@dfno", Gin_header.h34_dfno)
            comm.Parameters.AddWithValue("@col", Gin_header.h35_col)
            comm.Parameters.AddWithValue("@dhcod", Gin_header.h36_dhcod)
            comm.Parameters.AddWithValue("@sono", Gin_header.h37_sono)
            comm.Parameters.AddWithValue("@sonoid", Gin_header.h38_sonoid)
            comm.Parameters.AddWithValue("@roll_no_o", Gin_header.h39_roll_no_o)
            comm.Parameters.AddWithValue("@pn", Gin_header.h40_pn)
            comm.Parameters.AddWithValue("@ydkg_g", Gin_header.h41_ydkg_g)
            comm.Parameters.AddWithValue("@cost", Gin_header.h42_cost)
            comm.Parameters.AddWithValue("@fload", Gin_header.h43_fload)
            comm.Parameters.AddWithValue("@rate", Gin_header.h44_rate)
            comm.Parameters.AddWithValue("@sel", Gin_header.h45_sel)
            comm.Parameters.AddWithValue("@cost_g", Gin_header.h46_cost_g)
            comm.Parameters.AddWithValue("@cliped", Gin_header.h47_cliped)
            comm.Parameters.AddWithValue("@unit", Gin_header.h48_unit)
            comm.Parameters.AddWithValue("@g_cost", Gin_header.h49_g_cost)
            comm.Parameters.AddWithValue("@tran_no1", Gin_header.h50_tran_no1)
            comm.Parameters.AddWithValue("@tran_not", Gin_header.h51_tran_not)
            comm.Parameters.AddWithValue("@cancel", Gin_header.h52_cancel)
            comm.Parameters.AddWithValue("@doctyp", Gin_header.h53_doctyp)
            comm.Parameters.AddWithValue("@preseted", Gin_header.h54_preseted)                'Preseted = 1
            comm.Parameters.AddWithValue("@qcalertcd", Gin_header.h55_qcalertcd)
            comm.Parameters.AddWithValue("@ProdFinishDate", Gin_header.h56_ProdFinishDate)
            comm.Parameters.AddWithValue("@ProdFinishTime", Gin_header.h57_ProdFinishTime)
            comm.Parameters.AddWithValue("@mcno", Gin_header.h58_mcno)
            comm.Parameters.AddWithValue("@adjust_loss_kg", Gin_header.h59_adjust_loss_kg)
            comm.Parameters.AddWithValue("@qc_loss_kg", Gin_header.h60_qc_loss_kg)
            comm.Parameters.AddWithValue("@dyed_loss_kg", Gin_header.h61_dyed_loss_kg)
            comm.Parameters.AddWithValue("@grade_bdt", Gin_header.h62_grade_bdt)
            comm.Parameters.AddWithValue("@grade_adt", Gin_header.h63_grade_adt)
            comm.Parameters.AddWithValue("@dyeing_pass", Gin_header.h64_dyeing_pass)
            comm.Parameters.AddWithValue("@dyeing_fail", Gin_header.h65_dyeing_fail)
            comm.Parameters.AddWithValue("@shift", Gin_header.h66_shift)
            comm.Parameters.AddWithValue("@id_greige_do", Gin_header.h67_id_greige_do)
            comm.Parameters.AddWithValue("@id_greige", Gin_header.h68_id_greige)
            comm.Parameters.AddWithValue("@lab_loss_kg", Gin_header.h69_lab_loss_kg)
            comm.Parameters.AddWithValue("@defect_loss_kg", Gin_header.h70_defect_loss_kg)
            comm.Parameters.AddWithValue("@purno", Gin_header.h71_purno)
            comm.Parameters.AddWithValue("@tran_type", Gin_header.h72_tran_type)            'Tran_Type = KNITTING
            comm.Parameters.AddWithValue("@roll_no_f", Gin_header.h73_roll_no_f)
            comm.Parameters.AddWithValue("@job_line_id", Gin_header.h74_job_line_id)
            comm.Parameters.AddWithValue("@fabric_cost", Gin_header.h75_fabric_cost)
            comm.Parameters.AddWithValue("@process_cost", Gin_header.h76_process_cost)
            comm.Parameters.AddWithValue("@process_loss_perc", Gin_header.h77_process_loss_perc)
            comm.Parameters.AddWithValue("@other_cost", Gin_header.h78_other_cost)
            comm.Parameters.AddWithValue("@cost_per_unit", Gin_header.h79_cost_per_unit)
            comm.Parameters.AddWithValue("@sub_location", Gin_header.h80_sub_location)
            comm.Parameters.AddWithValue("@greige_status", Gin_header.h81_greige_status)
            comm.Parameters.AddWithValue("@bar_weight", Gin_header.h82_bar_weight)
            comm.Parameters.AddWithValue("@mtl_warehouse_id", Gin_header.h83_mtl_warehouse_id)
            comm.Parameters.AddWithValue("@mtl_locations_id", Gin_header.h85_mtl_locations_id)
            comm.Parameters.AddWithValue("@pcv_item_id", Gin_header.h88_pcv_item_id)

            comm.Parameters.AddWithValue("@logempcd", UserID.Trim)
        End With
        Dim dau = New SqlDataAdapter(comm)
        Dim dtu = New DataTable
        Try
            dau.Fill(dtu)
        Catch ex As Exception
            msgerr = ex.Message
            tran.Rollback()
            conn.Close()  'Sitthana 20190325
            Return False
        End Try
        Action = "CHANGE"

        'END Insert GIN KO Manual---

        'START Insert Defect Roll
        comm.CommandText = "p_greige_in_ko_manual_insert_defect_roll"
        For i = 0 To DV_DTC_ADD.Count - 1
            With DV_DTC_ADD
                comm.Parameters.Clear()
                comm.Parameters.AddWithValue("@id_defect_roll", config.IsNull(.Item(i)("id_defect_roll"), 0))
                comm.Parameters.AddWithValue("@roll_no", Gin_header.h13_roll_no)
                comm.Parameters.AddWithValue("@defect_code", config.IsNull(.Item(i)("defect_code"), ""))
                comm.Parameters.AddWithValue("@defect_details", config.IsNull(.Item(i)("defect_details"), ""))
                comm.Parameters.AddWithValue("@stock_code", Defect_Roll_Header.h05_stock_code)

            End With
            Dim DA_DV_DTC_ADD = New SqlDataAdapter(comm)
            Dim DT_DV_DTC_ADD = New DataTable
            Try
                DA_DV_DTC_ADD.Fill(DT_DV_DTC_ADD)
            Catch ex As Exception
                msgerr = ex.Message
                tran.Rollback()
                conn.Close()  'Sitthana 20190325
                Return False
            End Try
            'Action = "ADD"

        Next

        'END INsert Defect Roll

        'START Update Defect Roll
        comm.CommandText = "p_greige_in_ko_manual_update_defect_roll"
        For i = 0 To DV_DTC_UPD.Count - 1
            With DV_DTC_UPD
                comm.Parameters.Clear()
                comm.Parameters.AddWithValue("@id_defect_roll", config.IsNull(.Item(i)("id_defect_roll"), 0))
                comm.Parameters.AddWithValue("@roll_no", Gin_header.h13_roll_no)
                comm.Parameters.AddWithValue("@defect_code", config.IsNull(.Item(i)("defect_code"), ""))
                comm.Parameters.AddWithValue("@defect_details", config.IsNull(.Item(i)("defect_details"), ""))
                comm.Parameters.AddWithValue("@stock_code", config.IsNull(.Item(i)("stock_code"), ""))

            End With
            Dim DA_DV_DTC_UPD = New SqlDataAdapter(comm)
            Dim DT_DV_DTC_UPD = New DataTable
            Try
                DA_DV_DTC_UPD.Fill(DT_DV_DTC_UPD)
            Catch ex As Exception
                msgerr = ex.Message
                tran.Rollback()
                conn.Close()  'Sitthana 20190325
                Return False
            End Try
            'Action = "ADD"

        Next
        'END Update Defect Roll

        'START Delete Defect Roll
        comm.CommandText = "p_greige_in_ko_manual_delete_defect_roll"
        For i = 0 To DV_DTC_DEL.Count - 1
            With DV_DTC_DEL
                comm.Parameters.Clear()
                comm.Parameters.AddWithValue("@id_defect_roll", config.IsNull(.Item(i)("id_defect_roll"), 0))
                comm.Parameters.AddWithValue("@roll_no", Gin_header.h13_roll_no)
                comm.Parameters.AddWithValue("@defect_code", config.IsNull(.Item(i)("defect_code"), ""))
                comm.Parameters.AddWithValue("@defect_details", config.IsNull(.Item(i)("defect_details"), ""))
                comm.Parameters.AddWithValue("@stock_code", config.IsNull(.Item(i)("stock_code"), ""))

            End With
            Dim DA_DV_DTC_DEL = New SqlDataAdapter(comm)
            Dim DT_DV_DTC_DEL = New DataTable
            Try
                DA_DV_DTC_DEL.Fill(DT_DV_DTC_DEL)
            Catch ex As Exception
                msgerr = ex.Message
                tran.Rollback()
                Return False
            End Try
            'Action = "ADD"

        Next
        'END Delete Defect Roll

        'Start Insert Action----------
        If Action = "" Then Action = "CHANGE"
        comm.CommandText = "sp_insert_ACTION"
        j = 0
        Dim doctyp As String = "GIN"
        With Gin_header
            comm.Parameters.Clear()
            comm.Parameters.AddWithValue("@empcd", UserID.Trim)
            comm.Parameters.AddWithValue("@docno", Gin_header.h04_tran_no)
            comm.Parameters.AddWithValue("@workdt", Now)
            comm.Parameters.AddWithValue("@doctyp", doctyp)
            comm.Parameters.AddWithValue("@worktyp", Action)

        End With
        'Dim sql As String = config.BuildSQL(comm)
        Dim da_sp = New SqlDataAdapter(comm)
        Dim dt_sp = New DataTable
        Try
            da_sp.Fill(dt_sp)
        Catch ex As Exception
            msgerr = ex.Message
            tran.Rollback()
            conn.Close()  'Sitthana 20190325
            Return False
        End Try


        'End Insert Action----------
        Tran_no = Gin_header.h04_tran_no
        Roll_no = Gin_header.h13_roll_no
        tran.Commit()
        conn.Close()  'Sitthana 20190325
        Return True
    End Function
End Class

