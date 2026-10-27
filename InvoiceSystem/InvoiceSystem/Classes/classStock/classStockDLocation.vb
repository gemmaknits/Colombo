Imports System.Data
Imports System.Data.SqlClient
Imports System.Text


Public Class classStockDLocation

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
        'strolls_d
    End Structure

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
        j = 0
        For j = 0 To dv_dtc_upd.Count - 1
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
End Class
