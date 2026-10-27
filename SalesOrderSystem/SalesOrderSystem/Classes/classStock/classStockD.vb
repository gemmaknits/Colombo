Imports System.Data
Imports System.Data.SqlClient
Imports System.Text
Public Class classStockD

    Private connStr As New classConnection

    Public Structure Strolls_DHeader

        'strolls_d
        Dim h01_dinno As String
        Dim h02_dindt As Date
        Dim h03_doctyp As String
        Dim h04_dhcod As String
        Dim h05_dhdono As String
        Dim h06_dhdodt As String
        Dim h07_dfno As String
        Dim h08_dono As String
        Dim h09_dodt As Date
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
        Dim idname As String
        'strolls_d
    End Structure
    'Conversion Project
    Public Function ValidateOutNoByPackno(ByVal Strpackno As String, ByVal logempcd As String) As DataTable
        Dim conn As New SqlConnection((New classConnection).connection)
        Dim comm As New SqlCommand("", conn)

        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "p_packing_list_d_validate_d_out"
        comm.Parameters.AddWithValue("@packno", Strpackno)
        comm.Parameters.AddWithValue("@logempcd", logempcd)
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        conn.Close()  'Sitthana 20190325
        Return dt
    End Function
    'Conversion Project
    Public Function GetStockDLocation(ByRef StrDesignNo As String, ByRef Strlot As String, ByRef Strcol As String, ByRef StrDfno As String) As DataTable
        Dim config As New clsConfig
        Dim conn As New SqlConnection((New classConnection).connection)
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "p_stock_d_location_select"
        comm.Parameters.AddWithValue("@Design_no", config.IsNull(StrDesignNo, ""))
        comm.Parameters.AddWithValue("@lot", config.IsNull(Strlot, ""))
        comm.Parameters.AddWithValue("@col", config.IsNull(Strcol, ""))
        comm.Parameters.AddWithValue("@dfno", config.IsNull(StrDfno, ""))

        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        conn.Close()  'Sitthana 20190325
        Return dt
    End Function
    Public Function GetDINNo() As DataTable
        Dim conn As New SqlConnection((New classConnection).connection)
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "p_combo_din_no"
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        conn.Close()  'Sitthana 20190325
        Return dt
    End Function
    'Conversion Project
    Public Function GetDINmanualNo() As DataTable
        Dim conn As New SqlConnection((New classConnection).connection)
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "p_strolls_d_in_manual_combo_din_no"
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        conn.Close()  'Sitthana 20190325
        Return dt
    End Function
    'Conversion Project
    Public Function GetDINPurchaseNo() As DataTable
        Dim conn As New SqlConnection((New classConnection).connection)
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "p_strolls_d_in_purchase_combo_din_no"
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        conn.Close()  'Sitthana 20190325
        Return dt
    End Function
    'Conversion Project
    Public Function GetDINReturnNo() As DataTable
        Dim conn As New SqlConnection((New classConnection).connection)
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "p_strolls_d_in_return_combo_din_no"
        'comm.Parameters.AddWithValue("@dinno", strDinNo)
        'comm.Parameters.AddWithValue("@logempcd", strEmpCode)
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        conn.Close()  'Sitthana 20190325
        Return dt
    End Function
    Public Function GetDINNoByDate(Optional ByVal strDONO As String = "", Optional ByVal strStockType As String = "A", Optional ByVal strDinNo As String = "", Optional ByVal strDateFr As String = "", Optional ByVal strDateTo As String = "", Optional ByVal strCustCD As String = "") As DataTable
        Dim conn As New SqlConnection((New classConnection).connection)
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "p_strolls_d_select"
        comm.Parameters.AddWithValue("@dono", strDONO)
        comm.Parameters.AddWithValue("@doctyp", strStockType.Trim)
        comm.Parameters.AddWithValue("@dinno", strDinNo)
        comm.Parameters.AddWithValue("@datefr", strDateFr)
        comm.Parameters.AddWithValue("@dateto", strDateTo)
        comm.Parameters.AddWithValue("@custcd", strCustCD)
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        conn.Close()  'Sitthana 20190325
        Return dt
    End Function
    'Conversion Project
    Public Function GetDIN(ByVal strbillNo As String, ByVal strlotno As String, ByVal strdfno As String, ByVal strEmpCode As String) As DataTable
        Dim conn As New SqlConnection((New classConnection).connection)
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "p_strolls_d_in_manual_select"
        comm.Parameters.AddWithValue("@dinno", strbillNo)
        comm.Parameters.AddWithValue("@logempcd", strEmpCode)
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        conn.Close()  'Sitthana 20190325
        Return dt
    End Function
    'Conversion Project
    Public Function GetDINPurchase(ByVal strdinno As String, Optional ByVal strlotno As String = "", Optional ByVal strdfno As String = "", Optional ByVal strEmpCode As String = "") As DataTable
        Dim conn As New SqlConnection((New classConnection).connection)
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "p_strolls_d_in_purchase_select"
        comm.Parameters.AddWithValue("@dinno", strdinno)
        comm.Parameters.AddWithValue("@logempcd", strEmpCode)
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        conn.Close()  'Sitthana 20190325
        Return dt
    End Function

    Public Function GetSOPurchase(Optional ByVal strSoNo As String = "", Optional ByVal strDateFr As String = "", Optional ByVal strDateTo As String = "", Optional ByVal strCustCD As String = "") As DataTable
        Dim conn As New SqlConnection((New classConnection).connection)
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "p_strolls_d_in_so_select"
        comm.Parameters.AddWithValue("@sono", strSoNo)
        comm.Parameters.AddWithValue("@sodtfr", strDateFr)
        comm.Parameters.AddWithValue("@sodtto", strDateTo)
        comm.Parameters.AddWithValue("@custcd", strCustCD)
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        conn.Close()  'Sitthana 20190325
        Return dt
    End Function
    'Conversion Project
    Public Function GetDINManual(ByVal strdinNo As String, ByVal strEmpCode As String) As DataTable
        Dim conn As New SqlConnection((New classConnection).connection)
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "p_strolls_d_in_manual_select"
        comm.Parameters.AddWithValue("@dinno", strdinNo)
        comm.Parameters.AddWithValue("@logempcd", strEmpCode)
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        conn.Close()  'Sitthana 20190325
        Return dt
    End Function
    'Conversion Project
    Public Function GetDINReturn(ByVal strdinNo As String, ByVal strEmpCode As String) As DataTable
        Dim conn As New SqlConnection((New classConnection).connection)
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "p_strolls_d_in_return_select"
        comm.Parameters.AddWithValue("@dinno", strdinNo)
        comm.Parameters.AddWithValue("@logempcd", strEmpCode)
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        conn.Close()  'Sitthana 20190325
        Return dt
    End Function
    'Conversion Project
    Public Function GetDForder(ByVal strdfNo As String, ByVal strEmpCode As String) As DataTable
        'Dim conn As New SqlConnection(connStr.ConnectionString()) 'Sitthana 26/01/2018
        Dim conn As New SqlConnection((New classConnection).connection)
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "p_strolls_d_in_manual_dforder_select"
        comm.Parameters.AddWithValue("@dfno", strdfNo)
        comm.Parameters.AddWithValue("@logempcd", strEmpCode)
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        Dim ds As New DataSet
        'da.Fill(dt)
        da.Fill(ds, "v_strolls_d")
        conn.Close()  'Sitthana 20190325
        'Return ds
        Return ds.Tables("v_strolls_d")

        'Return dt
    End Function
    'Conversion Project
    Public Function GetStrollsD(ByVal strdfNo As String, ByVal strEmpCode As String) As DataTable
        Dim conn As New SqlConnection((New classConnection).connection)
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "p_strolls_d_in_manual_dforder_select"
        comm.Parameters.AddWithValue("@dfno", strdfNo)
        comm.Parameters.AddWithValue("@logempcd", strEmpCode)
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        conn.Close()  'Sitthana 20190325
        Return dt

    End Function
    'Conversion Project
    Public Function GetDForder_Items(ByVal strDFNo As String, ByVal strEmpCode As String, ByRef StrError As String) As DataTable
        Dim conn As New SqlConnection((New classConnection).connection)
        conn.Open()
        Dim tran As SqlTransaction = conn.BeginTransaction
        Dim comm As New SqlCommand("", conn)
        comm.Transaction = tran

        comm.CommandTimeout = 600
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "p_strolls_d_in_manual_dforder_select"
        comm.Parameters.AddWithValue("@dfno", strDFNo)
        comm.Parameters.AddWithValue("@logempcd", strEmpCode)
        'Dim da As New SqlDataAdapter(comm)
        'Dim dt As New DataTable
        'da.Fill(dt)
        'Return dt

        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        Try
            da.Fill(dt)
        Catch ex As Exception
            Strerror = ex.Message
            tran.Rollback()
            comm.Connection.Close()
            Return dt
        End Try
        tran.Commit()
        comm.Connection.Close()
        Return dt
    End Function
    'Conversion Project
    Public Function GetDOut_Return(ByVal strOutNo As String, ByVal strEmpCode As String) As DataTable
        Dim conn As New SqlConnection((New classConnection).connection)
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "p_strolls_d_in_return_select_dout"
        comm.Parameters.AddWithValue("@outno", strOutNo)
        comm.Parameters.AddWithValue("@logempcd", strEmpCode)
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        conn.Close()  'Sitthana 20190325
        Return dt
    End Function
    Public Function GetRollNoD(ByVal strRollNoD As String, ByVal strEmpCode As String) As DataTable
        Dim conn As New SqlConnection((New classConnection).connection)
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "p_roll_no_d_select"
        comm.Parameters.AddWithValue("@roll_no_d", strRollNoD)
        comm.Parameters.AddWithValue("@logempcd", strEmpCode)
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        conn.Close()  'Sitthana 20190325
        Return dt
    End Function
    Public Function GetCol(Optional ByVal strColNo As String = "", Optional ByVal strCustCD As String = "", Optional ByVal StrEmpCD As String = "") As DataTable

        Dim conn As New SqlConnection((New classConnection).connection)
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "p_dforder_select"
        comm.Parameters.AddWithValue("@col", strColNo)
        comm.Parameters.AddWithValue("@custcd", strCustCD)
        comm.Parameters.AddWithValue("@empcd", StrEmpCD)
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        conn.Close()
        Return dt
    End Function
    'Conversion Project
    Public Function GetColItem(Optional ByVal strColNo As String = "", Optional ByVal strCustNo As String = "", Optional ByVal StrEmpCD As String = "") As DataTable

        Dim conn As New SqlConnection((New classConnection).connection)
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "p_strolls_d_in_purchase_col_select"
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
    Public Function GetColno(Optional ByVal strColno As String = "", Optional ByVal StrCustCD As String = "", Optional ByVal strEmpCd As String = "") As DataTable
        Dim conn As New SqlConnection((New classConnection).connection)
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "p_strolls_d_in_purchase_col_select_search"
        comm.Parameters.AddWithValue("@col", strColno)
        comm.Parameters.AddWithValue("@custcd", StrCustCD)
        comm.Parameters.AddWithValue("@empcd", strEmpCd)
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
        comm.CommandText = "p_strolls_d_in_purchase_sono_select"
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
        comm.CommandText = "p_strolls_d_in_purchase_sonoid_select"
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
    Public Function GetSupplier(Optional ByVal strdhcod As String = "") As DataTable
        Dim conn As New SqlConnection((New classConnection).connection)
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "p_strolls_d_in_purchase_suppliers_select"
        comm.Parameters.AddWithValue("@dhcod", strdhcod.Trim)
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        conn.Close()  'Sitthana 20190325
        Return dt
    End Function
    'Conversion Project
    Public Function ValidateCol(ByVal strcol As String, ByVal logempcd As String) As DataTable
        Dim conn As New SqlConnection((New classConnection).connection)
        Dim comm As New SqlCommand("", conn)

        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "p_strolls_d_in_purchase_validate_col"
        comm.Parameters.AddWithValue("@col", strcol)
        comm.Parameters.AddWithValue("@logempcd", logempcd)
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        conn.Close()  'Sitthana 20190325
        Return dt
    End Function

    'Conversion Project
    Public Function Dinsave(ByVal Din_header As Strolls_DHeader, ByRef msgerr As String, ByVal dfc As DataTable, ByVal DV_DTC_ADD As DataView, ByVal DV_DTC_UPD As DataView, ByVal DV_DTC_DEL As DataView, ByRef UserID As String, ByRef DINno As String) As Boolean
        Dim config As New clsConfig
        Dim conn As New SqlConnection((New classConnection).connection)
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
        comm.CommandText = "p_strolls_d_in_manual_gen_doc"
        With Din_header
            comm.Parameters.Clear()
            comm.Parameters.AddWithValue("@dinno", Din_header.h01_dinno)
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

        Try
            Din_header.h01_dinno = dt.Rows(0)("dinno").ToString.Trim
        Catch ex As Exception
            msgerr = ex.Message
            tran.Rollback()
            conn.Close()  'Sitthana 20190325
            Return False

        End Try

        'END Gen PLD No----------
        'Start Add Cartons----------

        comm.CommandText = "p_strolls_d_in_manual_insert"
        j = 0
        For j = 0 To DV_DTC_ADD.Count - 1
            With DV_DTC_ADD
                comm.Parameters.Clear()
                comm.Parameters.AddWithValue("@dinno", Din_header.h01_dinno)
                comm.Parameters.AddWithValue("@dindt", Din_header.h02_dindt)
                comm.Parameters.AddWithValue("@doctyp", Din_header.h03_doctyp)
                comm.Parameters.AddWithValue("@dhcod", Din_header.h04_dhcod)
                comm.Parameters.AddWithValue("@dhdono", Din_header.h05_dhdono)
                comm.Parameters.AddWithValue("@dhdodt", Din_header.h06_dhdodt)
                comm.Parameters.AddWithValue("@dfno", Din_header.h07_dfno)
                comm.Parameters.AddWithValue("@dono", Din_header.h08_dono)
                comm.Parameters.AddWithValue("@dodt", Din_header.h09_dodt)
                comm.Parameters.AddWithValue("@design_no", config.IsNull(.Item(j)("design_no"), "").Trim)
                comm.Parameters.AddWithValue("@Gwth", config.IsNull(.Item(j)("gwth"), "").Trim)
                comm.Parameters.AddWithValue("@fwth", config.IsNull(.Item(j)("fwth"), "").Trim)
                comm.Parameters.AddWithValue("@lot", Din_header.h13_lot.Trim)
                comm.Parameters.AddWithValue("@yr", "")
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
                comm.Parameters.AddWithValue("@status", "")
                comm.Parameters.AddWithValue("@outreqno", "")
                comm.Parameters.AddWithValue("@outreqdt", "")
                comm.Parameters.AddWithValue("@mts_g", 0)
                comm.Parameters.AddWithValue("@yds_g", 0)
                comm.Parameters.AddWithValue("@allowmt", "")
                comm.Parameters.AddWithValue("@sonoid", config.IsNull(.Item(j)("sonoid"), "").trim)
                comm.Parameters.AddWithValue("@lotbatno", Din_header.h34_lotbatno)
                comm.Parameters.AddWithValue("@sel", 0)
                comm.Parameters.AddWithValue("@loc", "")
                comm.Parameters.AddWithValue("@cost", 0.0)
                comm.Parameters.AddWithValue("@batch", Din_header.h38_batch)
                comm.Parameters.AddWithValue("@custcolor", config.IsNull(.Item(j)("custcolor"), "").trim)
                comm.Parameters.AddWithValue("@fload", "")
                comm.Parameters.AddWithValue("@dinno1", "")
                comm.Parameters.AddWithValue("@dinnot", "")
                comm.Parameters.AddWithValue("@cost_d", "")
                comm.Parameters.AddWithValue("@unit", Din_header.h45_unit)
                comm.Parameters.AddWithValue("@roll_no_o", config.IsNull(.Item(j)("roll_no_o"), "").trim)
                comm.Parameters.AddWithValue("@roll_no_p", "")
                comm.Parameters.AddWithValue("@roll_no_f", config.IsNull(.Item(j)("roll_no_f"), "").trim)
                comm.Parameters.AddWithValue("@rem_qc", config.IsNull(.Item(j)("rem_qc"), "").trim)
                comm.Parameters.AddWithValue("@job_line_id", "")
                comm.Parameters.AddWithValue("@fabric_cost", 0.0)
                comm.Parameters.AddWithValue("@process_cost", 0.0)
                comm.Parameters.AddWithValue("@process_loss_perc", 0.0)
                comm.Parameters.AddWithValue("@other_cost", 0.0)
                comm.Parameters.AddWithValue("@cost_per_unit", 0.0)
                comm.Parameters.AddWithValue("@gross_mts", config.IsNull(.Item(j)("gross_mts"), 0.0)) 'Sitthana 20210118
                comm.Parameters.AddWithValue("@gross_wt_kg", config.IsNull(.Item(j)("gross_wt_kg"), 0.0)) 'Sitthana 20210118
                comm.Parameters.AddWithValue("@logempcd", UserID.Trim)
                ' comm.Parameters.AddWithValue("@idname", config.IsNull(.Item(j)("idname"), ""))
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

        comm.CommandText = "p_strolls_d_in_manual_update"
        j = 0
        For j = 0 To DV_DTC_UPD.Count - 1
            With DV_DTC_UPD
                comm.Parameters.Clear()
                comm.Parameters.AddWithValue("@dinno", config.IsNull(.Item(j)("dinno"), "").Trim)
                comm.Parameters.AddWithValue("@dindt", config.IsNull(.Item(j)("dindt"), ""))
                comm.Parameters.AddWithValue("@doctyp", config.IsNull(.Item(j)("doctyp"), ""))
                comm.Parameters.AddWithValue("@dhcod", config.IsNull(.Item(j)("dhcod"), ""))
                comm.Parameters.AddWithValue("@dhdono", config.IsNull(.Item(j)("dhdono"), ""))
                comm.Parameters.AddWithValue("@dhdodt", config.IsNull(.Item(j)("dhdodt"), ""))
                comm.Parameters.AddWithValue("@dfno", config.IsNull(.Item(j)("dfno"), "").Trim)
                comm.Parameters.AddWithValue("@dono", config.IsNull(.Item(j)("dono"), "").Trim)
                comm.Parameters.AddWithValue("@dodt", config.IsNull(.Item(j)("dodt"), ""))
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
                comm.Parameters.AddWithValue("@outreqdt", config.IsNull(.Item(j)("outreqdt"), ""))
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
                comm.Parameters.AddWithValue("@gross_mts", config.IsNull(.Item(j)("gross_mts"), 0.0)) 'Sitthana 20210118
                comm.Parameters.AddWithValue("@gross_wt_kg", config.IsNull(.Item(j)("gross_wt_kg"), 0.0)) 'Sitthana 20210118
                comm.Parameters.AddWithValue("@logempcd", UserID.Trim)
                '  comm.Parameters.AddWithValue("@checknew", CheckNEW)
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

        comm.CommandText = "p_strolls_d_in_manual_delete"
        j = 0
        For j = 0 To DV_DTC_DEL.Count - 1
            With DV_DTC_DEL
                comm.Parameters.Clear()
                comm.Parameters.AddWithValue("@dinno", config.IsNull(.Item(j)("dinno"), "").Trim)
                comm.Parameters.AddWithValue("@dindt", config.IsNull(.Item(j)("dindt"), ""))
                comm.Parameters.AddWithValue("@doctyp", config.IsNull(.Item(j)("doctyp"), ""))
                comm.Parameters.AddWithValue("@dhcod", config.IsNull(.Item(j)("dhcod"), ""))
                comm.Parameters.AddWithValue("@dhdono", config.IsNull(.Item(j)("dhdono"), ""))
                comm.Parameters.AddWithValue("@dhdodt", config.IsNull(.Item(j)("dhdodt"), ""))
                comm.Parameters.AddWithValue("@dfno", config.IsNull(.Item(j)("dfno"), "").Trim)
                comm.Parameters.AddWithValue("@dono", config.IsNull(.Item(j)("dono"), "").Trim)
                comm.Parameters.AddWithValue("@dodt", config.IsNull(.Item(j)("dodt"), ""))
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
                comm.Parameters.AddWithValue("@outreqdt", config.IsNull(.Item(j)("outreqdt"), ""))
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
        Dim doctyp As String = "DIN_M"
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
    Public Function DinPurchaseSave(ByVal Din_header As Strolls_DHeader, ByRef msgerr As String, ByVal dfc As DataTable, ByVal DV_DTC_ADD As DataView, ByVal DV_DTC_UPD As DataView, ByVal DV_DTC_DEL As DataView, ByRef UserID As String, ByRef DINno As String) As Boolean
        Dim config As New clsConfig
        Dim conn As New SqlConnection((New classConnection).connection)
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
        comm.CommandText = "p_strolls_d_in_purchase_gen_doc"
        With Din_header
            comm.Parameters.Clear()
            comm.Parameters.AddWithValue("@dinno", Din_header.h01_dinno)
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
        Din_header.h01_dinno = dt.Rows(0)("dinno").ToString.Trim

        'END Gen PLD No----------
        'Start Add Cartons----------

        comm.CommandText = "p_strolls_d_in_purchase_insert"
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
                comm.Parameters.AddWithValue("@dono", Din_header.h08_dono)
                comm.Parameters.AddWithValue("@dodt", Din_header.h09_dodt)
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
                comm.Parameters.AddWithValue("@typ", config.IsNull(.Item(j)("typ"), "").trim)
                comm.Parameters.AddWithValue("@status", config.IsNull(.Item(j)("status"), "").trim)
                comm.Parameters.AddWithValue("@outreqno", config.IsNull(.Item(j)("outreqno"), "").trim)
                comm.Parameters.AddWithValue("@outreqdt", config.IsNull(.Item(j)("outreqdt"), "").Trim)
                comm.Parameters.AddWithValue("@mts_g", config.IsNull(.Item(j)("mts_g"), "").Trim)
                comm.Parameters.AddWithValue("@yds_g", config.IsNull(.Item(j)("yds_g"), "").Trim)
                comm.Parameters.AddWithValue("@allowmt", config.IsNull(.Item(j)("allowmt"), "").Trim)
                comm.Parameters.AddWithValue("@sonoid", config.IsNull(.Item(j)("sonoid"), "").trim)
                comm.Parameters.AddWithValue("@lotbatno", config.IsNull(.Item(j)("lot"), "").Trim)
                comm.Parameters.AddWithValue("@sel", config.IsNull(.Item(j)("sel"), "").Trim)
                comm.Parameters.AddWithValue("@loc", config.IsNull(.Item(j)("loc"), "").Trim)
                comm.Parameters.AddWithValue("@cost", config.IsNull(.Item(j)("cost"), "").Trim)
                comm.Parameters.AddWithValue("@batch", config.IsNull(.Item(j)("lot"), "").Trim)
                comm.Parameters.AddWithValue("@custcolor", config.IsNull(.Item(j)("custcolor"), "").trim)
                comm.Parameters.AddWithValue("@fload", config.IsNull(.Item(j)("fload"), "").trim)
                comm.Parameters.AddWithValue("@dinno1", config.IsNull(.Item(j)("dinno1"), "").trim)
                comm.Parameters.AddWithValue("@dinnot", config.IsNull(.Item(j)("dinnot"), "").trim)
                comm.Parameters.AddWithValue("@cost_d", config.IsNull(.Item(j)("cost_d"), "").trim)
                comm.Parameters.AddWithValue("@unit", Din_header.h45_unit)
                comm.Parameters.AddWithValue("@roll_no_o", config.IsNull(.Item(j)("roll_no_o"), "").trim)
                comm.Parameters.AddWithValue("@roll_no_p", config.IsNull(.Item(j)("roll_no_p"), "").trim)
                comm.Parameters.AddWithValue("@roll_no_f", config.IsNull(.Item(j)("roll_no_f"), "").trim)
                comm.Parameters.AddWithValue("@rem_qc", config.IsNull(.Item(j)("rem_qc"), "").trim)
                comm.Parameters.AddWithValue("@job_line_id", config.IsNull(.Item(j)("job_line_id"), 0))
                comm.Parameters.AddWithValue("@fabric_cost", config.IsNull(.Item(j)("fabric_cost"), 0))
                comm.Parameters.AddWithValue("@process_cost", config.IsNull(.Item(j)("process_cost"), 0))
                comm.Parameters.AddWithValue("@process_loss_perc", config.IsNull(.Item(j)("process_loss_perc"), 0))
                comm.Parameters.AddWithValue("@other_cost", config.IsNull(.Item(j)("other_cost"), 0))
                comm.Parameters.AddWithValue("@cost_per_unit", config.IsNull(.Item(j)("cost_per_unit"), 0))
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

        comm.CommandText = "p_strolls_d_in_purchase_update"
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
                comm.Parameters.AddWithValue("@dodt", config.IsNull(.Item(j)("dodt"), ""))
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
                comm.Parameters.AddWithValue("@outreqdt", config.IsNull(.Item(j)("outreqdt"), ""))
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
                comm.Parameters.AddWithValue("@logempcd", UserID.Trim)
                '  comm.Parameters.AddWithValue("@checknew", CheckNEW)
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

        comm.CommandText = "p_strolls_d_in_purchase_delete"
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
                comm.Parameters.AddWithValue("@dodt", config.IsNull(.Item(j)("dodt"), ""))
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
                comm.Parameters.AddWithValue("@outreqdt", config.IsNull(.Item(j)("outreqdt"), ""))
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
    Public Function DINPurchaseCancel(ByVal Din_header As Strolls_DHeader, ByRef msgerr As String, ByVal dtp As DataTable, ByRef USERID As String) As Boolean
        Dim config As New clsConfig
        Dim conn As New SqlConnection((New classConnection).connection)
        conn.Open()
        Dim tran As SqlTransaction = conn.BeginTransaction
        Dim comm As New SqlCommand("", conn)
        Dim i As Integer = 0
        Dim j As Integer = 0
        Dim strLotNo As String = ""
        comm.Transaction = tran
        comm.CommandType = CommandType.StoredProcedure

        'Start  Add PLD bin-----------
        comm.CommandText = "p_strolls_d_in_purchase_insert_bin"
        i = 0
        For i = 0 To dtp.Rows.Count - 1
            With dtp.Rows
                comm.Parameters.Clear()
                comm.Parameters.AddWithValue("@dinno", config.IsNull(.Item(j)("dinno"), "").Trim)
                comm.Parameters.AddWithValue("@dindt", config.IsNull(.Item(j)("dindt"), ""))
                comm.Parameters.AddWithValue("@doctyp", config.IsNull(.Item(j)("doctyp"), ""))
                comm.Parameters.AddWithValue("@dhcod", config.IsNull(.Item(j)("dhcod"), ""))
                comm.Parameters.AddWithValue("@dhdono", config.IsNull(.Item(j)("dhdono"), ""))
                comm.Parameters.AddWithValue("@dhdodt", config.IsNull(.Item(j)("dhdodt"), ""))
                comm.Parameters.AddWithValue("@dfno", config.IsNull(.Item(j)("dfno"), "").Trim)
                comm.Parameters.AddWithValue("@dono", config.IsNull(.Item(j)("dono"), "").Trim)
                comm.Parameters.AddWithValue("@dodt", config.IsNull(.Item(j)("dodt"), ""))
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
                comm.Parameters.AddWithValue("@outreqdt", config.IsNull(.Item(j)("outreqdt"), ""))
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
                comm.Parameters.AddWithValue("@cost_d", config.IsNull(.Item(j)("cost_d"), ""))
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
                comm.Parameters.AddWithValue("@logempcd", USERID.Trim)
            End With

            Dim dap_add As New SqlDataAdapter(comm)
            Dim dtp_add As New DataTable
            Try
                dap_add.Fill(dtp_add)
            Catch ex As Exception
                msgerr = ex.Message
                tran.Rollback()
                conn.Close()  'Sitthana 20190325
                Return False

            End Try

        Next
        'End  Add PLD bin-----------

        'Start Delete PD ----------

        i = 0
        comm.CommandText = "p_strolls_d_in_purchase_cancel"

        For i = 0 To dtp.Rows.Count - 1
            With dtp.Rows
                comm.Parameters.Clear()
                comm.Parameters.AddWithValue("@dinno", config.IsNull(.Item(j)("dinno"), "").Trim)
                comm.Parameters.AddWithValue("@dindt", config.IsNull(.Item(j)("dindt"), ""))
                comm.Parameters.AddWithValue("@doctyp", config.IsNull(.Item(j)("doctyp"), ""))
                comm.Parameters.AddWithValue("@dhcod", config.IsNull(.Item(j)("dhcod"), ""))
                comm.Parameters.AddWithValue("@dhdono", config.IsNull(.Item(j)("dhdono"), ""))
                comm.Parameters.AddWithValue("@dhdodt", config.IsNull(.Item(j)("dhdodt"), ""))
                comm.Parameters.AddWithValue("@dfno", config.IsNull(.Item(j)("dfno"), "").Trim)
                comm.Parameters.AddWithValue("@dono", config.IsNull(.Item(j)("dono"), "").Trim)
                comm.Parameters.AddWithValue("@dodt", config.IsNull(.Item(j)("dodt"), ""))
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
                comm.Parameters.AddWithValue("@outreqdt", config.IsNull(.Item(j)("outreqdt"), ""))
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
                comm.Parameters.AddWithValue("@cost_d", config.IsNull(.Item(j)("cost_d"), ""))
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
                comm.Parameters.AddWithValue("@logempcd", USERID.Trim)
            End With
            Dim dap_upd = New SqlDataAdapter(comm)
            Dim dtp_upd = New DataTable
            Try
                dap_upd.Fill(dtp_upd)
            Catch ex As Exception
                msgerr = ex.Message
                tran.Rollback()
                conn.Close()  'Sitthana 20190325
                Return False
            End Try


        Next

        'Start Insert Action----------
        comm.CommandText = "sp_insert_ACTION"
        j = 0
        Dim Action As String = "CANCEL"
        Dim doctyp As String = "DIN"
        With Din_header
            comm.Parameters.Clear()
            comm.Parameters.AddWithValue("@empcd", USERID.Trim)
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
        'Strat Insert Action----------

        tran.Commit()
        comm.Connection.Close()
        Return True
    End Function
    'Conversion Project
    Public Function DINcancel(ByVal Din_header As Strolls_DHeader, ByRef msgerr As String, ByVal dtp As DataTable, ByRef USERID As String) As Boolean
        Dim config As New clsConfig
        Dim conn As New SqlConnection((New classConnection).connection)
        conn.Open()
        Dim tran As SqlTransaction = conn.BeginTransaction
        Dim comm As New SqlCommand("", conn)
        Dim i As Integer = 0
        Dim j As Integer = 0
        Dim strLotNo As String = ""
        comm.Transaction = tran
        comm.CommandType = CommandType.StoredProcedure

        'Start  Add PLD bin-----------
        comm.CommandText = "p_strolls_d_in_manual_insert_bin"
        j = 0
        For j = 0 To dtp.Rows.Count - 1
            With dtp.Rows
                comm.Parameters.Clear()
                comm.Parameters.AddWithValue("@dinno", config.IsNull(.Item(j)("dinno"), "").Trim)
                comm.Parameters.AddWithValue("@dindt", config.IsNull(.Item(j)("dindt"), ""))
                comm.Parameters.AddWithValue("@doctyp", config.IsNull(.Item(j)("doctyp"), ""))
                comm.Parameters.AddWithValue("@dhcod", config.IsNull(.Item(j)("dhcod"), ""))
                comm.Parameters.AddWithValue("@dhdono", config.IsNull(.Item(j)("dhdono"), ""))
                comm.Parameters.AddWithValue("@dhdodt", config.IsNull(.Item(j)("dhdodt"), ""))
                comm.Parameters.AddWithValue("@dfno", config.IsNull(.Item(j)("dfno"), "").Trim)
                comm.Parameters.AddWithValue("@dono", config.IsNull(.Item(j)("dono"), "").Trim)
                comm.Parameters.AddWithValue("@dodt", config.IsNull(.Item(j)("dodt"), ""))
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
                comm.Parameters.AddWithValue("@outreqdt", config.IsNull(.Item(j)("outreqdt"), ""))
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
                comm.Parameters.AddWithValue("@cost_d", config.IsNull(.Item(j)("cost_d"), ""))
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
                comm.Parameters.AddWithValue("@other_cost", config.IsNull(.Item(j)("other_cost"), 0.0))
                comm.Parameters.AddWithValue("@cost_per_unit", config.IsNull(.Item(j)("cost_per_unit"), 0.0))
                comm.Parameters.AddWithValue("@logempcd", USERID.Trim)
            End With

            Dim dap_add As New SqlDataAdapter(comm)
            Dim dtp_add As New DataTable
            Try
                dap_add.Fill(dtp_add)
            Catch ex As Exception
                msgerr = ex.Message
                tran.Rollback()
                conn.Close()  'Sitthana 20190325
                Return False

            End Try

        Next
        'End  Add PLD bin-----------

        'Start Delete PD ----------

        j = 0
        comm.CommandText = "p_strolls_d_in_manual_cancel"

        For j = 0 To dtp.Rows.Count - 1
            With dtp.Rows
                comm.Parameters.Clear()
                comm.Parameters.AddWithValue("@dinno", config.IsNull(.Item(j)("dinno"), "").Trim)
                comm.Parameters.AddWithValue("@dindt", config.IsNull(.Item(j)("dindt"), ""))
                comm.Parameters.AddWithValue("@doctyp", config.IsNull(.Item(j)("doctyp"), ""))
                comm.Parameters.AddWithValue("@dhcod", config.IsNull(.Item(j)("dhcod"), ""))
                comm.Parameters.AddWithValue("@dhdono", config.IsNull(.Item(j)("dhdono"), ""))
                comm.Parameters.AddWithValue("@dhdodt", config.IsNull(.Item(j)("dhdodt"), ""))
                comm.Parameters.AddWithValue("@dfno", config.IsNull(.Item(j)("dfno"), "").Trim)
                comm.Parameters.AddWithValue("@dono", config.IsNull(.Item(j)("dono"), "").Trim)
                comm.Parameters.AddWithValue("@dodt", config.IsNull(.Item(j)("dodt"), ""))
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
                comm.Parameters.AddWithValue("@outreqdt", config.IsNull(.Item(j)("outreqdt"), ""))
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
                comm.Parameters.AddWithValue("@cost_d", config.IsNull(.Item(j)("cost_d"), ""))
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
                comm.Parameters.AddWithValue("@logempcd", USERID.Trim)
            End With
            Dim dap_upd = New SqlDataAdapter(comm)
            Dim dtp_upd = New DataTable
            Try
                dap_upd.Fill(dtp_upd)
            Catch ex As Exception
                msgerr = ex.Message
                tran.Rollback()
                conn.Close()  'Sitthana 20190325
                Return False
            End Try


        Next

        'Start Insert Action----------
        comm.CommandText = "sp_insert_ACTION"
        j = 0
        Dim Action As String = "CANCEL"
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
        'Strat Insert Action----------

        tran.Commit()
        conn.Close()  'Sitthana 20190325
        Return True
    End Function
    'Conversion Project
    Public Function RollNoDUpdate(ByVal DT As DataTable, ByRef msgerr As String, ByRef UserID As String, ByRef RollNoD As String) As Boolean
        Dim config As New clsConfig
        Dim conn As New SqlConnection((New classConnection).connection)
        conn.Open()
        Dim tran As SqlTransaction = conn.BeginTransaction
        Dim comm As New SqlCommand("", conn)
        Dim i As Integer = 0
        Dim j As Integer = 0
        Dim strLotNo As String = ""
        Dim Action As String = ""
        'Dim strROllNoD As String = ""
        comm.Transaction = tran
        comm.CommandType = CommandType.StoredProcedure

        'Start Gen DIN No----------
        comm.CommandText = "p_strolls_d_in_manual_remark_update"
        i = 0
        For i = 0 To DT.Rows.Count - 1
            With DT.Rows
                comm.Parameters.Clear()
                comm.Parameters.AddWithValue("@dinno", config.IsNull(.Item(j)("dinno"), "").Trim)
                comm.Parameters.AddWithValue("@dindt", config.IsNull(.Item(j)("dindt"), ""))
                comm.Parameters.AddWithValue("@doctyp", config.IsNull(.Item(j)("doctyp"), ""))
                comm.Parameters.AddWithValue("@dhcod", config.IsNull(.Item(j)("dhcod"), ""))
                comm.Parameters.AddWithValue("@dhdono", config.IsNull(.Item(j)("dhdono"), ""))
                comm.Parameters.AddWithValue("@dhdodt", config.IsNull(.Item(j)("dhdodt"), ""))
                comm.Parameters.AddWithValue("@dfno", config.IsNull(.Item(j)("dfno"), "").Trim)
                comm.Parameters.AddWithValue("@dono", config.IsNull(.Item(j)("dono"), "").Trim)
                comm.Parameters.AddWithValue("@dodt", config.IsNull(.Item(j)("dodt"), ""))
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
                comm.Parameters.AddWithValue("@outreqdt", config.IsNull(.Item(j)("outreqdt"), ""))
                comm.Parameters.AddWithValue("@mts_g", config.IsNull(.Item(j)("mts_g"), ""))
                comm.Parameters.AddWithValue("@yds_g", config.IsNull(.Item(j)("yds_g"), ""))
                comm.Parameters.AddWithValue("@allowmt", config.IsNull(.Item(j)("allowmt"), ""))
                comm.Parameters.AddWithValue("@sonoid", config.IsNull(.Item(j)("sonoid"), "").trim)
                comm.Parameters.AddWithValue("@lotbatno", config.IsNull(.Item(j)("lot"), "").Trim)
                comm.Parameters.AddWithValue("@sel", config.IsNull(.Item(j)("sel"), ""))
                comm.Parameters.AddWithValue("@loc", config.IsNull(.Item(j)("loc"), ""))
                comm.Parameters.AddWithValue("@cost", config.IsNull(.Item(j)("dhcod"), 0.0))
                comm.Parameters.AddWithValue("@batch", config.IsNull(.Item(j)("batch"), "").Trim)
                comm.Parameters.AddWithValue("@custcolor", config.IsNull(.Item(j)("custcolor"), "").trim)
                comm.Parameters.AddWithValue("@fload", config.IsNull(.Item(j)("fload"), ""))
                comm.Parameters.AddWithValue("@dinno1", config.IsNull(.Item(j)("dinno1"), ""))
                comm.Parameters.AddWithValue("@dinnot", config.IsNull(.Item(j)("dinnot"), ""))
                comm.Parameters.AddWithValue("@cost_d", config.IsNull(.Item(j)("cost_d"), ""))
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
                comm.Parameters.AddWithValue("@logempcd", UserID.Trim)
            End With

            Dim dap_add As New SqlDataAdapter(comm)
            Dim dtp_add As New DataTable
            Try
                dap_add.Fill(dtp_add)
            Catch ex As Exception
                msgerr = ex.Message
                tran.Rollback()
                conn.Close()  'Sitthana 20190325
                Return False

            End Try
            RollNoD = dtp_add.Rows(0)("dinno").ToString.Trim
            'tran.Commit()
        Next

        'Start Insert Action----------
        If Action = "" Then Action = "CHANGE"
        comm.CommandText = "sp_insert_ACTION"
        j = 0
        Dim doctyp As String = "DIN"
        With DT.Rows
            comm.Parameters.Clear()
            comm.Parameters.AddWithValue("@empcd", UserID.Trim)
            comm.Parameters.AddWithValue("@docno", config.IsNull(.Item(0)("dinno"), "").Trim)
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
        ' strROllNoD = dtp_add.Rows(0)("dinno").ToString.Trim
        tran.Commit()
        conn.Close()  'Sitthana 20190325
        Return True
    End Function
    'Conversion Project
    Public Function UpdateStockD(ByVal dv_dtc_upd As DataView, ByRef msgerr As String, ByRef UserID As String) As Boolean
        Dim config As New clsConfig
        Dim conn As New SqlConnection((New classConnection).connection)
        conn.Open()
        Dim tran As SqlTransaction = conn.BeginTransaction
        Dim comm As New SqlCommand("", conn)
        Dim i As Integer = 0
        Dim j As Integer = 0
        Dim strLotNo As String = ""
        Dim Action As String = ""
        'Dim strROllNoD As String = ""
        comm.Transaction = tran
        comm.CommandType = CommandType.StoredProcedure

        'Start Gen DIN No----------
        comm.CommandText = "p_stock_d_location_update"
        i = 0
        For i = 0 To dv_dtc_upd.Count - 1
            With dv_dtc_upd
                comm.Parameters.Clear()
                comm.Parameters.AddWithValue("@dinno", config.IsNull(.Item(j)("dinno"), "").Trim)
                comm.Parameters.AddWithValue("@dindt", config.IsNull(.Item(j)("dindt"), ""))
                comm.Parameters.AddWithValue("@doctyp", config.IsNull(.Item(j)("doctyp"), ""))
                comm.Parameters.AddWithValue("@dhcod", config.IsNull(.Item(j)("dhcod"), ""))
                comm.Parameters.AddWithValue("@dhdono", config.IsNull(.Item(j)("dhdono"), ""))
                comm.Parameters.AddWithValue("@dhdodt", config.IsNull(.Item(j)("dhdodt"), ""))
                comm.Parameters.AddWithValue("@dfno", config.IsNull(.Item(j)("dfno"), "").Trim)
                comm.Parameters.AddWithValue("@dono", config.IsNull(.Item(j)("dono"), "").Trim)
                comm.Parameters.AddWithValue("@dodt", config.IsNull(.Item(j)("dodt"), ""))
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
                comm.Parameters.AddWithValue("@outreqdt", config.IsNull(.Item(j)("outreqdt"), ""))
                comm.Parameters.AddWithValue("@mts_g", config.IsNull(.Item(j)("mts_g"), 0))
                comm.Parameters.AddWithValue("@yds_g", config.IsNull(.Item(j)("yds_g"), 0))
                comm.Parameters.AddWithValue("@allowmt", config.IsNull(.Item(j)("allowmt"), 0))
                comm.Parameters.AddWithValue("@sonoid", config.IsNull(.Item(j)("sonoid"), "").trim)
                comm.Parameters.AddWithValue("@lotbatno", config.IsNull(.Item(j)("lot"), "").Trim)
                comm.Parameters.AddWithValue("@sel", config.IsNull(.Item(j)("sel"), 0))
                comm.Parameters.AddWithValue("@loc", config.IsNull(.Item(j)("loc"), ""))
                comm.Parameters.AddWithValue("@cost", config.IsNull(.Item(j)("cost"), 0.0))
                comm.Parameters.AddWithValue("@batch", config.IsNull(.Item(j)("batch"), "").Trim)
                comm.Parameters.AddWithValue("@custcolor", config.IsNull(.Item(j)("custcolor"), "").trim)
                comm.Parameters.AddWithValue("@fload", config.IsNull(.Item(j)("fload"), 0))
                comm.Parameters.AddWithValue("@dinno1", config.IsNull(.Item(j)("dinno1"), ""))
                comm.Parameters.AddWithValue("@dinnot", config.IsNull(.Item(j)("dinnot"), ""))
                comm.Parameters.AddWithValue("@cost_d", config.IsNull(.Item(j)("cost_d"), 0.0))
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
                comm.Parameters.AddWithValue("@logempcd", UserID.Trim)
            End With

            Dim dap_add As New SqlDataAdapter(comm)
            Dim dtp_add As New DataTable
            Try
                dap_add.Fill(dtp_add)
            Catch ex As Exception
                msgerr = ex.Message
                tran.Rollback()
                conn.Close()  'Sitthana 20190325
                Return False

            End Try
            ' RollNoD = dtp_add.Rows(0)("dinno").ToString.Trim
            'tran.Commit()
        Next

        'Start Insert Action----------
        If Action = "" Then Action = "CHANGE"
        comm.CommandText = "sp_insert_ACTION"
        j = 0
        Dim doctyp As String = "DINLOC"
        With dv_dtc_upd
            comm.Parameters.Clear()
            comm.Parameters.AddWithValue("@empcd", UserID.Trim)
            comm.Parameters.AddWithValue("@docno", config.IsNull(.Item(0)("dinno"), "").Trim)
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
        ' strROllNoD = dtp_add.Rows(0)("dinno").ToString.Trim
        tran.Commit()
        conn.Close()  'Sitthana 20190325
        Return True
    End Function
    'Conversion Project
    Public Function DReturnSave(ByVal Din_header As Strolls_DHeader, ByRef msgerr As String, ByVal dfc As DataTable, ByVal DV_DTC_ADD As DataView, ByVal DV_DTC_UPD As DataView, ByVal DV_DTC_DEL As DataView, ByRef UserID As String, ByRef DINno As String) As Boolean
        Dim config As New clsConfig
        Dim conn As New SqlConnection((New classConnection).connection)
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
        comm.CommandText = "p_strolls_d_in_manual_gen_doc"
        With Din_header
            comm.Parameters.Clear()
            comm.Parameters.AddWithValue("@dinno", Din_header.h01_dinno)
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
        Din_header.h01_dinno = dt.Rows(0)("dinno").ToString.Trim

        'END Gen PLD No----------
        'Start Add Cartons----------

        comm.CommandText = "p_strolls_d_in_return_insert"
        j = 0
        For j = 0 To DV_DTC_ADD.Count - 1
            With DV_DTC_ADD
                comm.Parameters.Clear()
                comm.Parameters.AddWithValue("@dinno", Din_header.h01_dinno)
                comm.Parameters.AddWithValue("@dindt", Din_header.h02_dindt)
                comm.Parameters.AddWithValue("@doctyp", Din_header.h03_doctyp)
                comm.Parameters.AddWithValue("@dhcod", Din_header.h04_dhcod)
                comm.Parameters.AddWithValue("@dhdono", "")
                comm.Parameters.AddWithValue("@dhdodt", "")
                comm.Parameters.AddWithValue("@dfno", Din_header.h07_dfno)
                comm.Parameters.AddWithValue("@dono", "")
                comm.Parameters.AddWithValue("@dodt", "")
                comm.Parameters.AddWithValue("@design_no", config.IsNull(.Item(j)("design_no"), "").Trim)
                comm.Parameters.AddWithValue("@Gwth", "")
                comm.Parameters.AddWithValue("@fwth", config.IsNull(.Item(j)("fwth"), 0))
                comm.Parameters.AddWithValue("@lot", "")
                comm.Parameters.AddWithValue("@yr", "")
                comm.Parameters.AddWithValue("@sh", "")
                comm.Parameters.AddWithValue("@col", config.IsNull(.Item(j)("col"), "").trim)
                comm.Parameters.AddWithValue("@Gr", config.IsNull(.Item(j)("gr"), "").trim)
                comm.Parameters.AddWithValue("@mtkg", 0)
                comm.Parameters.AddWithValue("@roll_no_d", config.IsNull(.Item(j)("roll_no_d"), "").trim)
                comm.Parameters.AddWithValue("@roll_no_g", "")
                comm.Parameters.AddWithValue("@kg", config.IsNull(.Item(j)("kg"), 0))
                comm.Parameters.AddWithValue("@mts", config.IsNull(.Item(j)("mts"), 0))
                comm.Parameters.AddWithValue("@yds", config.IsNull(.Item(j)("yds"), 0))
                comm.Parameters.AddWithValue("@sono", config.IsNull(.Item(j)("sono"), ""))
                comm.Parameters.AddWithValue("@nob", "")
                comm.Parameters.AddWithValue("@typ", "")
                comm.Parameters.AddWithValue("@status", "")
                comm.Parameters.AddWithValue("@outreqno", "")
                comm.Parameters.AddWithValue("@outreqdt", "")
                comm.Parameters.AddWithValue("@mts_g", 0)
                comm.Parameters.AddWithValue("@yds_g", 0)
                comm.Parameters.AddWithValue("@allowmt", "")
                comm.Parameters.AddWithValue("@sonoid", "")
                comm.Parameters.AddWithValue("@lotbatno", "")
                comm.Parameters.AddWithValue("@sel", 0)
                comm.Parameters.AddWithValue("@loc", "")
                comm.Parameters.AddWithValue("@cost", 0.0)
                comm.Parameters.AddWithValue("@batch", "")
                comm.Parameters.AddWithValue("@custcolor", config.IsNull(.Item(j)("custcolor"), "").trim)
                comm.Parameters.AddWithValue("@fload", "")
                comm.Parameters.AddWithValue("@dinno1", "")
                comm.Parameters.AddWithValue("@dinnot", "")
                comm.Parameters.AddWithValue("@cost_d", "")
                comm.Parameters.AddWithValue("@unit", "")
                comm.Parameters.AddWithValue("@roll_no_o", "")
                comm.Parameters.AddWithValue("@roll_no_p", "")
                comm.Parameters.AddWithValue("@roll_no_f", "")
                comm.Parameters.AddWithValue("@rem_qc", "")
                comm.Parameters.AddWithValue("@job_line_id", "")
                comm.Parameters.AddWithValue("@fabric_cost", 0.0)
                comm.Parameters.AddWithValue("@process_cost", 0.0)
                comm.Parameters.AddWithValue("@process_loss_perc", 0.0)
                comm.Parameters.AddWithValue("@other_cost", 0.0)
                comm.Parameters.AddWithValue("@cost_per_unit", 0.0)
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

        comm.CommandText = "p_strolls_d_in_return_update"
        j = 0
        For j = 0 To DV_DTC_UPD.Count - 1
            With DV_DTC_UPD
                comm.Parameters.Clear()
                comm.Parameters.AddWithValue("@dinno", config.IsNull(.Item(j)("dinno"), "").Trim)
                comm.Parameters.AddWithValue("@dindt", config.IsNull(.Item(j)("dindt"), ""))
                comm.Parameters.AddWithValue("@doctyp", config.IsNull(.Item(j)("doctyp"), ""))
                comm.Parameters.AddWithValue("@dhcod", config.IsNull(.Item(j)("dhcod"), ""))
                comm.Parameters.AddWithValue("@dhdono", config.IsNull(.Item(j)("dhdono"), ""))
                comm.Parameters.AddWithValue("@dhdodt", config.IsNull(.Item(j)("dhdodt"), ""))
                comm.Parameters.AddWithValue("@dfno", config.IsNull(.Item(j)("dfno"), "").Trim)
                comm.Parameters.AddWithValue("@dono", config.IsNull(.Item(j)("dono"), "").Trim)
                comm.Parameters.AddWithValue("@dodt", config.IsNull(.Item(j)("dodt"), ""))
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
                comm.Parameters.AddWithValue("@outreqdt", config.IsNull(.Item(j)("outreqdt"), ""))
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
                comm.Parameters.AddWithValue("@logempcd", UserID.Trim)
                '  comm.Parameters.AddWithValue("@checknew", CheckNEW)
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

        comm.CommandText = "p_strolls_d_in_return_delete"
        j = 0
        For j = 0 To DV_DTC_DEL.Count - 1
            With DV_DTC_DEL
                comm.Parameters.Clear()
                comm.Parameters.AddWithValue("@dinno", config.IsNull(.Item(j)("dinno"), "").Trim)
                comm.Parameters.AddWithValue("@dindt", config.IsNull(.Item(j)("dindt"), ""))
                comm.Parameters.AddWithValue("@doctyp", config.IsNull(.Item(j)("doctyp"), ""))
                comm.Parameters.AddWithValue("@dhcod", config.IsNull(.Item(j)("dhcod"), ""))
                comm.Parameters.AddWithValue("@dhdono", config.IsNull(.Item(j)("dhdono"), ""))
                comm.Parameters.AddWithValue("@dhdodt", config.IsNull(.Item(j)("dhdodt"), ""))
                comm.Parameters.AddWithValue("@dfno", config.IsNull(.Item(j)("dfno"), "").Trim)
                comm.Parameters.AddWithValue("@dono", config.IsNull(.Item(j)("dono"), "").Trim)
                comm.Parameters.AddWithValue("@dodt", config.IsNull(.Item(j)("dodt"), ""))
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
                comm.Parameters.AddWithValue("@outreqdt", config.IsNull(.Item(j)("outreqdt"), ""))
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
End Class
