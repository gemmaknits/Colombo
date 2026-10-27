Imports System.Data
Imports System.Data.SqlClient
Imports System.Text
Public Class classStockDINPurchase
    'Conversion Project
    Private connStr As New classConnection

    Public Structure Strolls_DHeader

        'strolls_d
        Dim h01_dinno As String
        Dim h02_dindt As Nullable(Of Date)
        Dim h03_doctyp As String
        Dim h04_dhcod As String
        Dim h05_dhdono As String
        Dim h06_dhdodt As String
        Dim h07_dfno As String
        Dim h08_dono As String
        Dim h09_dodt As Nullable(Of Date)
        Dim h10_design_no As String
        Dim h11_Gwth As String
        Dim h12_fwth As String
        Dim h13_lot As String
        Dim h14_yr As String
        Dim h15_sh As String
        Dim h16_col As String
        Dim h17_Gr As String
        Dim h18_mtkg As Double
        Dim h19_roll_no_d As String
        Dim h20_roll_no_g As String
        Dim h21_kg As Double
        Dim h22_mts As Double
        Dim h23_yds As Double
        Dim h24_sono As String
        Dim h25_nob As Double
        Dim h26_typ As String
        Dim h27_status As String
        Dim h28_outreqno As String
        Dim h29_outreqdt As Date
        Dim h30_mts_g As Double
        Dim h31_yds_g As Double
        Dim h32_allowmt As Double
        Dim h33_sonoid As String
        Dim h34_lotbatno As String
        Dim h35_sel As Boolean
        Dim h36_loc As String 'Same h01_cartno
        Dim h37_cost As Double 'Same h02_packno
        Dim h38_batch As String
        Dim h39_custcolor As String
        Dim h40_fload As Boolean
        Dim h41_cancel As Boolean
        Dim h42_dinno1 As String
        Dim h43_dinnot As String
        Dim h44_cost_d As Double
        Dim h45_unit As String
        Dim h46_roll_no_o As String
        Dim h47_roll_no_p As String
        Dim h48_roll_no_f As String
        Dim h49_rem_qc As String
        Dim h50_job_line_id As String
        Dim h51_fabric_cost As Double
        Dim h52_process_cost As Double
        Dim h53_process_loss_perc As Double
        Dim h54_other_cost As Double
        Dim h55_cost_per_unit As Double
        Dim h56_mtl_warehouse_id As Nullable(Of Int64)
        Dim h57_mtl_subinventory_id As Nullable(Of Int64)
        Dim h58_mtl_locations_id As Nullable(Of Int64)
        Dim h59_purno As String
        Dim h60_suppcd As String
        Dim h61_sinvno As String
        Dim h62_sinvdt As Nullable(Of DateTime)
        Dim h63_lotno_sup As String
        Dim h64_srefno As String
        Dim h65_
        'strolls_d
    End Structure
    'Conversion Project
    Public Function GetDINPurchaseNo(ByVal pStockType As String) As DataTable
        Dim conn As New SqlConnection((New ClassConnection).connection)
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "p_din_purchase_combo_din_no"
        comm.Parameters.Clear()
        comm.Parameters.AddWithValue("@stock_type", pStockType)
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        conn.Close()  'Sitthana 20190325
        Return dt
    End Function
    'Conversion Project
    Public Function GetSupplier(Optional ByVal strdhcod As String = "") As DataTable
        Dim conn As New SqlConnection((New classConnection).connection)
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "p_din_purchase_suppliers_select"
        comm.Parameters.Clear()
        comm.Parameters.AddWithValue("@dhcod", strdhcod.Trim)
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        conn.Close()  'Sitthana 20190325
        Return dt
    End Function
    'Conversion Project
    Public Function GetSoNo(Optional ByVal strSoNo As String = "", Optional ByVal StrCustCD As String = "", Optional ByVal strEmpCd As String = "") As DataTable
        Dim conn As New SqlConnection((New classConnection).connection)
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "p_din_purchase_sono_select"
        comm.Parameters.Clear()
        comm.Parameters.AddWithValue("@sono", strSoNo)
        comm.Parameters.AddWithValue("@custcd", StrCustCD)
        comm.Parameters.AddWithValue("@empcd", strEmpCd)
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        conn.Close()  'Sitthana 20190325
        Return dt

    End Function
    'Conversion Project
    Public Function GetSoNoId(Optional ByVal strSoNo As String = "", Optional ByVal StrCustCD As String = "", Optional ByVal strEmpCd As String = "") As DataTable
        Dim conn As New SqlConnection((New classConnection).connection)
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "p_din_purchase_sonoid_select"
        comm.Parameters.Clear()
        comm.Parameters.AddWithValue("@sono", strSoNo)
        comm.Parameters.AddWithValue("@custcd", StrCustCD)
        comm.Parameters.AddWithValue("@empcd", strEmpCd)
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        conn.Close()  'Sitthana 20190325
        Return dt

    End Function
    'Conversion Project
    Public Function GetColItem(Optional ByVal strColNo As String = "", Optional ByVal strCustNo As String = "", Optional ByVal StrEmpCD As String = "") As DataTable

        Dim conn As New SqlConnection((New classConnection).connection)
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "p_din_purchase_select_col"
        comm.Parameters.Clear()
        comm.Parameters.AddWithValue("@col", strColNo)
        comm.Parameters.AddWithValue("@custcd", strCustNo)
        comm.Parameters.AddWithValue("@empcd", StrEmpCD)
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        conn.Close()
        Return dt
    End Function

    'Conversion Project
    Public Function GetDINPurchase(ByVal strdinno As String, Optional ByVal strlotno As String = "", Optional ByVal strdfno As String = "", Optional ByVal strEmpCode As String = "") As DataTable
        Dim conn As New SqlConnection((New classConnection).connection)
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "p_din_purchase_select"
        comm.Parameters.Clear()
        comm.Parameters.AddWithValue("@dinno", strdinno)
        comm.Parameters.AddWithValue("@logempcd", strEmpCode)
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        conn.Close()  'Sitthana 20190325
        Return dt
    End Function

    'Conversion Project
    Public Function GetColno(Optional ByVal strColno As String = "", Optional ByVal StrCustCD As String = "", Optional ByVal strEmpCd As String = "") As DataTable
        Dim conn As New SqlConnection((New classConnection).connection)
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "p_din_purchase_select_col_search"
        comm.Parameters.Clear()
        comm.Parameters.AddWithValue("@col", strColno)
        comm.Parameters.AddWithValue("@custcd", StrCustCD)
        comm.Parameters.AddWithValue("@empcd", strEmpCd)
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        conn.Close()  'Sitthana 20190325
        Return dt

    End Function

    Public Function ValidateCol(ByVal strcol As String, ByVal logempcd As String) As DataTable
        Dim conn As New SqlConnection((New classConnection).connection)
        Dim comm As New SqlCommand("", conn)

        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "p_din_purchase_validate_col"
        comm.Parameters.Clear()
        comm.Parameters.AddWithValue("@col", strcol)
        comm.Parameters.AddWithValue("@logempcd", logempcd)
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        conn.Close()  'Sitthana 20190325
        Return dt
    End Function

    'Conversion Project
    Public Function DinPurchaseSave(ByVal Din_header As classStockDINPurchase.Strolls_DHeader, ByRef msgerr As String, ByVal dfc As DataTable, ByVal DV_DTC_ADD As DataView, ByVal DV_DTC_UPD As DataView, ByVal DV_DTC_DEL As DataView, ByRef UserID As String, ByRef DINno As String, ByVal pStockType As String) As Boolean
        Dim config As New clsConfig
        Dim conn As New SqlConnection((New ClassConnection).connection)
        conn.Open()
        Dim tran As SqlTransaction = conn.BeginTransaction
        Dim comm As New SqlCommand("", conn)
        Dim i As Integer = 0
        Dim j As Integer = 0
        Dim strLotNo As String = ""
        Dim Action As String = ""
        comm.Transaction = tran
        comm.CommandType = CommandType.StoredProcedure

        'Start Gen DIN No----------
        comm.CommandText = "p_din_purchase_gen_doc"
        With Din_header
            comm.Parameters.Clear()
            comm.Parameters.AddWithValue("@dinno", Din_header.h01_dinno)
            comm.Parameters.AddWithValue("@empcd", UserID.Trim)
            comm.Parameters.AddWithValue("@checknew", "")
            comm.Parameters.AddWithValue("@stock_type", pStockType) 'Neung 20260519
        End With
        Dim da_gendoc As New SqlDataAdapter(comm)
        Dim dt_gendoc As New DataTable
        Try
            da_gendoc.Fill(dt_gendoc)
        Catch ex As Exception
            msgerr = ex.Message
            tran.Rollback()
            conn.Close()  'Sitthana 20190325
            Return False

        End Try
        Din_header.h01_dinno = dt_gendoc.Rows(0)("dinno").ToString.Trim

        'END Gen PLD No----------
        'Start Add Cartons----------

        comm.CommandText = "p_din_purchase_insert"
        j = 0
        For j = 0 To DV_DTC_ADD.Count - 1
            With DV_DTC_ADD
                comm.Parameters.Clear()
                comm.Parameters.AddWithValue("@dinno", Din_header.h01_dinno)
                comm.Parameters.AddWithValue("@dindt", Din_header.h02_dindt)
                comm.Parameters.AddWithValue("@doctyp", Din_header.h03_doctyp)
                comm.Parameters.AddWithValue("@dhcod", config.IsNull(.Item(j)("dhcod"), "").Trim)
                comm.Parameters.AddWithValue("@dhdono", config.IsNull(.Item(j)("dhdono"), "").Trim)
                comm.Parameters.AddWithValue("@dhdodt", config.IsNull(.Item(j)("dhdodt"), "").Trim)
                comm.Parameters.AddWithValue("@dfno", config.IsNull(.Item(j)("dfno"), "").Trim)
                comm.Parameters.AddWithValue("@dono", config.IsNull(.Item(j)("dono"), "").Trim)
                comm.Parameters.AddWithValue("@dodt", .Item(j)("dodt"))
                comm.Parameters.AddWithValue("@design_no", config.IsNull(.Item(j)("design_no"), "").Trim)
                comm.Parameters.AddWithValue("@Gwth", config.IsNull(.Item(j)("gwth"), "").Trim)
                comm.Parameters.AddWithValue("@fwth", config.IsNull(.Item(j)("fwth"), "").Trim)
                comm.Parameters.AddWithValue("@lot", config.IsNull(.Item(j)("lot"), "").Trim)
                comm.Parameters.AddWithValue("@yr", config.IsNull(.Item(j)("yr"), "").Trim)
                comm.Parameters.AddWithValue("@sh", config.IsNull(.Item(j)("sh"), "").Trim)
                comm.Parameters.AddWithValue("@col", config.IsNull(.Item(j)("col"), "").trim)
                comm.Parameters.AddWithValue("@Gr", config.IsNull(.Item(j)("gr"), "").trim)
                comm.Parameters.AddWithValue("@mtkg", config.IsNull(.Item(j)("mtkg"), 0))
                comm.Parameters.AddWithValue("@roll_no_d", config.IsNull(.Item(j)("roll_no_d"), "").trim)
                comm.Parameters.AddWithValue("@roll_no_g", config.IsNull(.Item(j)("roll_no_g"), "").trim)
                comm.Parameters.AddWithValue("@kg", config.IsNull(.Item(j)("kg"), 0))
                comm.Parameters.AddWithValue("@mts", config.IsNull(.Item(j)("mts"), 0))
                comm.Parameters.AddWithValue("@yds", config.IsNull(.Item(j)("yds"), 0))
                comm.Parameters.AddWithValue("@sono", config.IsNull(.Item(j)("sono"), "").trim)
                comm.Parameters.AddWithValue("@nob", config.IsNull(.Item(j)("nob"), "").trim)
                comm.Parameters.AddWithValue("@typ", config.IsNull(.Item(j)("typ"), ""))
                comm.Parameters.AddWithValue("@status", config.IsNull(.Item(j)("status"), "").trim)
                comm.Parameters.AddWithValue("@outreqno", config.IsNull(.Item(j)("outreqno"), "").trim)
                comm.Parameters.AddWithValue("@outreqdt", .Item(j)("outreqdt"))
                comm.Parameters.AddWithValue("@mts_g", config.IsNull(.Item(j)("mts_g"), ""))
                comm.Parameters.AddWithValue("@yds_g", config.IsNull(.Item(j)("yds_g"), ""))
                comm.Parameters.AddWithValue("@allowmt", config.IsNull(.Item(j)("allowmt"), ""))
                comm.Parameters.AddWithValue("@sonoid", config.IsNull(.Item(j)("sonoid"), ""))
                comm.Parameters.AddWithValue("@lotbatno", config.IsNull(.Item(j)("lotbatno"), ""))
                comm.Parameters.AddWithValue("@sel", config.IsNull(.Item(j)("sel"), ""))
                comm.Parameters.AddWithValue("@loc", config.IsNull(.Item(j)("loc"), ""))
                comm.Parameters.AddWithValue("@cost", config.IsNull(.Item(j)("cost"), ""))
                comm.Parameters.AddWithValue("@batch", config.IsNull(.Item(j)("batch"), ""))
                comm.Parameters.AddWithValue("@custcolor", config.IsNull(.Item(j)("custcolor"), ""))
                comm.Parameters.AddWithValue("@fload", config.IsNull(.Item(j)("fload"), ""))
                comm.Parameters.AddWithValue("@dinno1", config.IsNull(.Item(j)("dinno1"), .Item(j)("roll_no_o")))
                comm.Parameters.AddWithValue("@dinnot", config.IsNull(.Item(j)("dinnot"), ""))
                comm.Parameters.AddWithValue("@cost_d", config.IsNull(.Item(j)("cost_d"), ""))
                comm.Parameters.AddWithValue("@unit", Din_header.h45_unit)
                comm.Parameters.AddWithValue("@roll_no_o", config.IsNull(.Item(j)("roll_no_o"), ""))
                comm.Parameters.AddWithValue("@roll_no_p", config.IsNull(.Item(j)("roll_no_p"), ""))
                comm.Parameters.AddWithValue("@roll_no_f", config.IsNull(.Item(j)("roll_no_f"), ""))
                comm.Parameters.AddWithValue("@rem_qc", config.IsNull(.Item(j)("rem_qc"), ""))
                comm.Parameters.AddWithValue("@job_line_id", config.IsNull(.Item(j)("job_line_id"), 0))
                comm.Parameters.AddWithValue("@fabric_cost", config.IsNull(.Item(j)("fabric_cost"), 0))
                comm.Parameters.AddWithValue("@process_cost", config.IsNull(.Item(j)("process_cost"), 0))
                comm.Parameters.AddWithValue("@process_loss_perc", config.IsNull(.Item(j)("process_loss_perc"), 0))
                comm.Parameters.AddWithValue("@other_cost", config.IsNull(.Item(j)("other_cost"), 0))
                comm.Parameters.AddWithValue("@cost_per_unit", config.IsNull(.Item(j)("cost_per_unit"), 0))
                comm.Parameters.AddWithValue("@mtl_warehouse_id", .Item(j)("mtl_warehouse_id"))
                comm.Parameters.AddWithValue("@mtl_subinventory_id", .Item(j)("mtl_subinventory_id"))
                comm.Parameters.AddWithValue("@mtl_locations_id", .Item(j)("mtl_locations_id"))
                comm.Parameters.AddWithValue("@id_jobdet", config.IsNull(.Item(j)("id_jobdet"), DBNull.Value))
                comm.Parameters.AddWithValue("@sinvno", config.IsNull(Din_header.h61_sinvno, DBNull.Value))
                comm.Parameters.AddWithValue("@sinvdt", config.IsNull(Din_header.h62_sinvdt, DBNull.Value))
                comm.Parameters.AddWithValue("@lotno_sup", config.IsNull(Din_header.h63_lotno_sup, DBNull.Value))
                comm.Parameters.AddWithValue("@srefno", config.IsNull(Din_header.h64_srefno, DBNull.Value))
                comm.Parameters.AddWithValue("@suppcd", config.IsNull(Din_header.h60_suppcd, DBNull.Value))
                comm.Parameters.AddWithValue("@purno", config.IsNull(Din_header.h59_purno, DBNull.Value))
                comm.Parameters.AddWithValue("@stock_type", config.IsNull(pStockType, DBNull.Value)) 'Neung 20260519
                comm.Parameters.AddWithValue("@logempcd", UserID.Trim)
                '  comm.Parameters.AddWithValue("@checknew", CheckNEW)
            End With
            'Dim sql As String = config.BuildSQL(comm)
            Dim dac_int = New SqlDataAdapter(comm)
            Dim dtc_int = New DataTable
            Try
                dac_int.Fill(dtc_int)
            Catch ex As Exception
                msgerr = ex.Message
                tran.Rollback()
                conn.Close()  'Sitthana 20190325
                Return False
            End Try
            Action = "ADD"

        Next
        'End Add Cartons----------

        'Start update Cartons----------

        comm.CommandText = "p_din_purchase_update"
        j = 0
        For j = 0 To DV_DTC_UPD.Count - 1
            With DV_DTC_UPD
                comm.Parameters.Clear()
                comm.Parameters.AddWithValue("@dinno", config.IsNull(.Item(j)("dinno"), "").Trim)
                comm.Parameters.AddWithValue("@dindt", config.IsNull(.Item(j)("dindt"), ""))
                comm.Parameters.AddWithValue("@doctyp", config.IsNull(.Item(j)("doctyp"), ""))
                comm.Parameters.AddWithValue("@dhcod", config.IsNull(.Item(j)("dhcod"), "").ToString.Trim)
                comm.Parameters.AddWithValue("@dhdono", config.IsNull(.Item(j)("dhdono"), ""))
                comm.Parameters.AddWithValue("@dhdodt", config.IsNull(.Item(j)("dhdodt"), ""))
                comm.Parameters.AddWithValue("@dfno", config.IsNull(.Item(j)("dfno"), "").Trim)
                comm.Parameters.AddWithValue("@dono", config.IsNull(.Item(j)("dono"), "").Trim)
                comm.Parameters.AddWithValue("@dodt", .Item(j)("dodt"))
                comm.Parameters.AddWithValue("@design_no", config.IsNull(.Item(j)("design_no"), "").Trim)
                comm.Parameters.AddWithValue("@Gwth", config.IsNull(.Item(j)("gwth"), ""))
                comm.Parameters.AddWithValue("@fwth", config.IsNull(.Item(j)("fwth"), ""))
                comm.Parameters.AddWithValue("@lot", config.IsNull(.Item(j)("lot"), "").Trim)
                comm.Parameters.AddWithValue("@yr", config.IsNull(.Item(j)("yr"), ""))
                comm.Parameters.AddWithValue("@sh", config.IsNull(.Item(j)("sh"), "").Trim)
                comm.Parameters.AddWithValue("@col", config.IsNull(.Item(j)("col"), "").trim)
                comm.Parameters.AddWithValue("@Gr", config.IsNull(.Item(j)("gr"), "").trim)
                comm.Parameters.AddWithValue("@mtkg", config.IsNull(.Item(j)("mtkg"), 0))
                comm.Parameters.AddWithValue("@roll_no_d", config.IsNull(.Item(j)("roll_no_d"), "").trim)
                comm.Parameters.AddWithValue("@roll_no_g", config.IsNull(.Item(j)("roll_no_g"), "").trim)
                comm.Parameters.AddWithValue("@kg", config.IsNull(.Item(j)("kg"), 0))
                comm.Parameters.AddWithValue("@mts", config.IsNull(.Item(j)("mts"), 0))
                comm.Parameters.AddWithValue("@yds", config.IsNull(.Item(j)("yds"), 0))
                comm.Parameters.AddWithValue("@sono", config.IsNull(.Item(j)("sono"), "").trim)
                'comm.Parameters.AddWithValue("@custcd", dv_upd(i)("sono").ToString.Trim)
                comm.Parameters.AddWithValue("@nob", config.IsNull(.Item(j)("nob"), "").trim)
                comm.Parameters.AddWithValue("@typ", config.IsNull(.Item(j)("typ"), "").trim)
                comm.Parameters.AddWithValue("@status", config.IsNull(.Item(j)("status"), ""))
                comm.Parameters.AddWithValue("@outreqno", config.IsNull(.Item(j)("outreqno"), ""))
                comm.Parameters.AddWithValue("@outreqdt", .Item(j)("outreqdt"))
                comm.Parameters.AddWithValue("@mts_g", config.IsNull(.Item(j)("mts_g"), ""))
                comm.Parameters.AddWithValue("@yds_g", config.IsNull(.Item(j)("yds_g"), ""))
                comm.Parameters.AddWithValue("@allowmt", config.IsNull(.Item(j)("allowmt"), ""))
                comm.Parameters.AddWithValue("@sonoid", config.IsNull(.Item(j)("sonoid"), "").trim)
                comm.Parameters.AddWithValue("@lotbatno", config.IsNull(.Item(j)("lot"), "").Trim)
                comm.Parameters.AddWithValue("@sel", config.IsNull(.Item(j)("sel"), ""))
                comm.Parameters.AddWithValue("@loc", config.IsNull(.Item(j)("loc"), ""))
                comm.Parameters.AddWithValue("@cost", config.IsNull(.Item(j)("cost"), 0.0))
                comm.Parameters.AddWithValue("@batch", config.IsNull(.Item(j)("batch"), "").Trim)
                comm.Parameters.AddWithValue("@custcolor", config.IsNull(.Item(j)("custcolor"), "").trim)
                comm.Parameters.AddWithValue("@fload", config.IsNull(.Item(j)("fload"), ""))
                comm.Parameters.AddWithValue("@dinno1", config.IsNull(.Item(j)("dinno1"), ""))
                comm.Parameters.AddWithValue("@dinnot", config.IsNull(.Item(j)("dinnot"), ""))
                comm.Parameters.AddWithValue("@cost_d", config.IsNull(.Item(j)("cost_d"), 0))
                comm.Parameters.AddWithValue("@unit", config.IsNull(.Item(j)("unit"), "").trim)
                comm.Parameters.AddWithValue("@roll_no_o", config.IsNull(.Item(j)("roll_no_o"), "").trim)
                comm.Parameters.AddWithValue("@roll_no_p", config.IsNull(.Item(j)("roll_no_p"), ""))
                comm.Parameters.AddWithValue("@roll_no_f", config.IsNull(.Item(j)("roll_no_f"), ""))
                comm.Parameters.AddWithValue("@rem_qc", config.IsNull(.Item(j)("rem_qc"), "").trim)
                comm.Parameters.AddWithValue("@job_line_id", config.IsNull(.Item(j)("job_line_id"), ""))
                comm.Parameters.AddWithValue("@fabric_cost", config.IsNull(.Item(j)("fabric_cost"), 0.0))
                comm.Parameters.AddWithValue("@process_cost", config.IsNull(.Item(j)("process_cost"), 0.0))
                comm.Parameters.AddWithValue("@process_loss_perc", config.IsNull(.Item(j)("process_loss_perc"), 0.0))
                comm.Parameters.AddWithValue("@other_cost", config.IsNull(.Item(j)("other_cost"), 0.0))
                comm.Parameters.AddWithValue("@cost_per_unit", config.IsNull(.Item(j)("cost_per_unit"), 0.0))
                comm.Parameters.AddWithValue("@mtl_warehouse_id", .Item(j)("mtl_warehouse_id"))
                comm.Parameters.AddWithValue("@mtl_subinventory_id", .Item(j)("mtl_subinventory_id"))
                comm.Parameters.AddWithValue("@mtl_locations_id", .Item(j)("mtl_locations_id"))

                comm.Parameters.AddWithValue("@id_jobdet", config.IsNull(.Item(j)("id_jobdet"), DBNull.Value))
                comm.Parameters.AddWithValue("@sinvno", config.IsNull(Din_header.h61_sinvno, DBNull.Value))
                comm.Parameters.AddWithValue("@sinvdt", config.IsNull(Din_header.h62_sinvdt, DBNull.Value))
                comm.Parameters.AddWithValue("@lotno_sup", config.IsNull(Din_header.h63_lotno_sup, DBNull.Value))
                comm.Parameters.AddWithValue("@srefno", config.IsNull(Din_header.h64_srefno, DBNull.Value))
                comm.Parameters.AddWithValue("@suppcd", config.IsNull(Din_header.h60_suppcd, DBNull.Value))
                comm.Parameters.AddWithValue("@purno", config.IsNull(Din_header.h59_purno, DBNull.Value))
                comm.Parameters.AddWithValue("@logempcd", UserID.Trim)
            End With
            'Dim sql As String = config.BuildSQL(comm)
            Dim dac_upd = New SqlDataAdapter(comm)
            Dim dtc_upd = New DataTable
            Try
                dac_upd.Fill(dtc_upd)
            Catch ex As Exception
                msgerr = ex.Message
                tran.Rollback()
                conn.Close()  'Sitthana 20190325
                Return False
            End Try
            Action = "CHANGE"
        Next
        'End update Cartons----------

        'Start delete Cartons----------

        comm.CommandText = "p_din_purchase_delete"
        j = 0
        For j = 0 To DV_DTC_DEL.Count - 1
            With DV_DTC_DEL
                comm.Parameters.Clear()
                comm.Parameters.AddWithValue("@dinno", config.IsNull(.Item(j)("dinno"), "").Trim)
                comm.Parameters.AddWithValue("@dindt", config.IsNull(.Item(j)("dindt"), ""))
                comm.Parameters.AddWithValue("@doctyp", config.IsNull(.Item(j)("doctyp"), "").Trim)
                comm.Parameters.AddWithValue("@dhcod", config.IsNull(.Item(j)("dhcod"), "").trim)
                comm.Parameters.AddWithValue("@dhdono", config.IsNull(.Item(j)("dhdono"), ""))
                comm.Parameters.AddWithValue("@dhdodt", config.IsNull(.Item(j)("dhdodt"), ""))
                comm.Parameters.AddWithValue("@dfno", config.IsNull(.Item(j)("dfno"), "").Trim)
                comm.Parameters.AddWithValue("@dono", config.IsNull(.Item(j)("dono"), "").Trim)
                comm.Parameters.AddWithValue("@dodt", .Item(j)("dodt"))
                comm.Parameters.AddWithValue("@design_no", config.IsNull(.Item(j)("design_no"), "").Trim)
                comm.Parameters.AddWithValue("@Gwth", config.IsNull(.Item(j)("gwth"), ""))
                comm.Parameters.AddWithValue("@fwth", config.IsNull(.Item(j)("fwth"), ""))
                comm.Parameters.AddWithValue("@lot", config.IsNull(.Item(j)("lot"), "").Trim)
                comm.Parameters.AddWithValue("@yr", config.IsNull(.Item(j)("yr"), ""))
                comm.Parameters.AddWithValue("@sh", config.IsNull(.Item(j)("sh"), "").Trim)
                comm.Parameters.AddWithValue("@col", config.IsNull(.Item(j)("col"), "").trim)
                comm.Parameters.AddWithValue("@Gr", config.IsNull(.Item(j)("gr"), "").trim)
                comm.Parameters.AddWithValue("@mtkg", config.IsNull(.Item(j)("mtkg"), 0))
                comm.Parameters.AddWithValue("@roll_no_d", config.IsNull(.Item(j)("roll_no_d"), "").trim)
                comm.Parameters.AddWithValue("@roll_no_g", config.IsNull(.Item(j)("roll_no_g"), "").trim)
                comm.Parameters.AddWithValue("@kg", config.IsNull(.Item(j)("kg"), 0))
                comm.Parameters.AddWithValue("@mts", config.IsNull(.Item(j)("mts"), 0))
                comm.Parameters.AddWithValue("@yds", config.IsNull(.Item(j)("yds"), 0))
                comm.Parameters.AddWithValue("@sono", config.IsNull(.Item(j)("sono"), "").trim)
                comm.Parameters.AddWithValue("@nob", config.IsNull(.Item(j)("nob"), "").trim)
                comm.Parameters.AddWithValue("@typ", config.IsNull(.Item(j)("typ"), "").trim)
                comm.Parameters.AddWithValue("@status", config.IsNull(.Item(j)("status"), ""))
                comm.Parameters.AddWithValue("@outreqno", config.IsNull(.Item(j)("outreqno"), ""))
                comm.Parameters.AddWithValue("@outreqdt", .Item(j)("outreqdt"))
                comm.Parameters.AddWithValue("@mts_g", config.IsNull(.Item(j)("mts_g"), ""))
                comm.Parameters.AddWithValue("@yds_g", config.IsNull(.Item(j)("yds_g"), ""))
                comm.Parameters.AddWithValue("@allowmt", config.IsNull(.Item(j)("allowmt"), ""))
                comm.Parameters.AddWithValue("@sonoid", config.IsNull(.Item(j)("sonoid"), "").trim)
                comm.Parameters.AddWithValue("@lotbatno", config.IsNull(.Item(j)("lot"), "").Trim)
                comm.Parameters.AddWithValue("@sel", config.IsNull(.Item(j)("sel"), ""))
                comm.Parameters.AddWithValue("@loc", config.IsNull(.Item(j)("loc"), ""))
                comm.Parameters.AddWithValue("@cost", config.IsNull(.Item(j)("cost"), 0.0))
                comm.Parameters.AddWithValue("@batch", config.IsNull(.Item(j)("batch"), "").Trim)
                comm.Parameters.AddWithValue("@custcolor", config.IsNull(.Item(j)("custcolor"), "").trim)
                comm.Parameters.AddWithValue("@fload", config.IsNull(.Item(j)("fload"), ""))
                comm.Parameters.AddWithValue("@dinno1", config.IsNull(.Item(j)("dinno1"), ""))
                comm.Parameters.AddWithValue("@dinnot", config.IsNull(.Item(j)("dinnot"), ""))
                comm.Parameters.AddWithValue("@cost_d", config.IsNull(.Item(j)("cost_d"), 0))
                comm.Parameters.AddWithValue("@unit", config.IsNull(.Item(j)("unit"), "").trim)
                comm.Parameters.AddWithValue("@roll_no_o", config.IsNull(.Item(j)("roll_no_o"), "").trim)
                comm.Parameters.AddWithValue("@roll_no_p", config.IsNull(.Item(j)("roll_no_p"), ""))
                comm.Parameters.AddWithValue("@roll_no_f", config.IsNull(.Item(j)("roll_no_f"), ""))
                comm.Parameters.AddWithValue("@rem_qc", config.IsNull(.Item(j)("rem_qc"), "").trim)
                comm.Parameters.AddWithValue("@job_line_id", config.IsNull(.Item(j)("job_line_id"), ""))
                comm.Parameters.AddWithValue("@fabric_cost", config.IsNull(.Item(j)("fabric_cost"), 0.0))
                comm.Parameters.AddWithValue("@process_cost", config.IsNull(.Item(j)("process_cost"), 0.0))
                comm.Parameters.AddWithValue("@process_loss_perc", config.IsNull(.Item(j)("process_loss_perc"), 0.0))
                comm.Parameters.AddWithValue("@other_cost", config.IsNull(.Item(j)("other_cost"), 0.0))
                comm.Parameters.AddWithValue("@cost_per_unit", config.IsNull(.Item(j)("cost_per_unit"), 0.0))
                comm.Parameters.AddWithValue("@mtl_warehouse_id", .Item(j)("mtl_warehouse_id"))
                comm.Parameters.AddWithValue("@mtl_subinventory_id", .Item(j)("mtl_subinventory_id"))
                comm.Parameters.AddWithValue("@mtl_locations_id", .Item(j)("mtl_locations_id"))
                comm.Parameters.AddWithValue("@logempcd", UserID.Trim)
                '  comm.Parameters.AddWithValue("@checknew", CheckNEW)
            End With
            'Dim sql As String = config.BuildSQL(comm)
            Dim dac_del = New SqlDataAdapter(comm)
            Dim dtc_del = New DataTable
            Try
                dac_del.Fill(dtc_del)
            Catch ex As Exception
                msgerr = ex.Message
                tran.Rollback()
                conn.Close()  'Sitthana 20190325
                Return False
            End Try

            Action = "CHANGE"
        Next
        'End delete Cartons----------
        'Start Insert Action----------
        If Action = "" Then Action = "CHANGE"
        comm.CommandText = "sp_insert_ACTION"
        j = 0
        Dim doctyp As String = "DIN"
        With Din_header
            comm.Parameters.Clear()
            comm.Parameters.AddWithValue("@empcd", UserID.Trim)
            comm.Parameters.AddWithValue("@docno", Din_header.h01_dinno)
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
        DINno = Din_header.h01_dinno
        tran.Commit()
        conn.Close()  'Sitthana 20190325
        Return True
    End Function
    'Conversion Project
End Class

