Imports System.Data
Imports System.Data.SqlClient
Imports System.Text


Public Class classHangerINBarcode

    Public Structure StrollsDHeader

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
        'strolls_d
    End Structure

    Public Function GetDout(Optional ByVal Int64IDStrollsDO As Nullable(Of Int64) = Nothing, Optional ByVal StrOutno As String = Nothing) As DataTable
        Dim conn As New SqlConnection((New classConnection).connection)
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "P_HANGER_STOCK_IN_PKG_get_dyed_out"
        comm.Parameters.AddWithValue("@id_strolls_d_o", Int64IDStrollsDO)
        comm.Parameters.AddWithValue("@outno", StrOutno)
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        comm.Connection.Close()
        Try
            da.Fill(dt)
        Catch ex As Exception
            conn.Close()  'Sitthana 20190325
            MessageBox.Show(ex.Message, ex.GetType().ToString())
        End Try
        conn.Close()  'Sitthana 20190325
        Return dt

    End Function

    'Public Function GetDoutByOutNo(Optional ByVal Int64IDStrollsDO As Nullable(Of Int64) = Nothing) As DataTable
    '    Dim conn As New SqlConnection((New classConnection).connection)
    '    Dim comm As New SqlCommand("", conn)
    '    comm.CommandType = CommandType.StoredProcedure
    '    comm.CommandText = "P_HANGER_STOCK_IN_PKG_get_dyed_out"
    '    comm.Parameters.AddWithValue("@id_strolls_d_o", Int64IDStrollsDO)
    '    Dim da As New SqlDataAdapter(comm)
    '    Dim dt As New DataTable
    '    comm.Connection.Close()
    '    Try
    '        da.Fill(dt)
    '    Catch ex As Exception
    '        MessageBox.Show(ex.Message, ex.GetType().ToString())
    '    End Try
    '    Return dt

    'End Function

    Public Function GetGridHangerINByDINNO(Optional ByVal StrDINNo As String = Nothing) As DataTable
        Dim conn As New SqlConnection((New classConnection).connection)
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "P_HANGER_STOCK_IN_PKG_get_grid_hanger_in"
        comm.Parameters.AddWithValue("@dinno", StrDINNo)
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        comm.Connection.Close()
        Try
            da.Fill(dt)
        Catch ex As Exception
            conn.Close()  'Sitthana 20190325
            MessageBox.Show(ex.Message, ex.GetType().ToString())
        End Try
        conn.Close()  'Sitthana 20190325
        Return dt

    End Function

    Public Function MakeCancel(Optional ByVal StrDINNo As String = Nothing) As DataTable
        Dim conn As New SqlConnection((New classConnection).connection)
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "P_HANGER_STOCK_IN_PKG_cancel"
        comm.Parameters.AddWithValue("@dinno", StrDINNo)
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        comm.Connection.Close()
        Try
            da.Fill(dt)
        Catch ex As Exception
            conn.Close()  'Sitthana 20190325
            MessageBox.Show(ex.Message, ex.GetType().ToString())
        End Try
        conn.Close()  'Sitthana 20190325
        Return dt

    End Function

    Public Function MakeHangerIN(ByRef StrollsDHeader As StrollsDHeader, ByVal DV_ADD As DataView, ByVal DV_UPD As DataView, ByVal DV_DEL As DataView, ByRef msgerr As String, ByVal Userinfo As classUserInfo) As Boolean
        Dim config As New clsConfig
        Dim conn As New SqlConnection((New classConnection).connection)
        conn.Open()
        Dim tran As SqlTransaction = conn.BeginTransaction
        Dim comm As New SqlCommand("", conn)
        Dim i As Integer = 0
        comm.Transaction = tran
        comm.CommandType = CommandType.StoredProcedure
        'Add Detail----------

        i = 0
        comm.CommandText = "P_HANGER_STOCK_IN_PKG_update"

        For i = 0 To DV_ADD.Count - 1
            With DV_ADD
                comm.Parameters.Clear()
                comm.Parameters.AddWithValue("@dinno", StrollsDHeader.h01_dinno)
                comm.Parameters.AddWithValue("@dindt", StrollsDHeader.h02_dindt)
                comm.Parameters.AddWithValue("@doctyp", StrollsDHeader.h03_doctyp)
                comm.Parameters.AddWithValue("@roll_no_d", config.IsNull(.Item(i)("roll_no_d"), "").Trim)
                comm.Parameters.AddWithValue("@roll_no_o", config.IsNull(.Item(i)("roll_no_o"), "").Trim)
                comm.Parameters.AddWithValue("@design_no", config.IsNull(.Item(i)("design_no"), "").Trim)
                comm.Parameters.AddWithValue("@sono", config.IsNull(.Item(i)("sono"), "").Trim)
                comm.Parameters.AddWithValue("@sonoid", config.IsNull(.Item(i)("sonoid"), "").Trim)
                comm.Parameters.AddWithValue("@fwth", config.IsNull(.Item(i)("fwth"), "").Trim)
                comm.Parameters.AddWithValue("@Gwth", config.IsNull(.Item(i)("Gwth"), "").Trim)
                comm.Parameters.AddWithValue("@lot", config.IsNull(.Item(i)("lot"), "").Trim)
                comm.Parameters.AddWithValue("@kg", config.IsNull(.Item(i)("kg"), 0))
                comm.Parameters.AddWithValue("@col", config.IsNull(.Item(i)("col"), ""))
                comm.Parameters.AddWithValue("@custcolor", config.IsNull(.Item(i)("custcolor"), ""))
                comm.Parameters.AddWithValue("@mtl_warehouse_id", .Item(i)("mtl_warehouse_id"))
                comm.Parameters.AddWithValue("@mtl_subinventory_id", .Item(i)("mtl_subinventory_id"))
                comm.Parameters.AddWithValue("@mtl_locations_id", .Item(i)("mtl_locations_id"))
                comm.Parameters.AddWithValue("@rem_qc", .Item(i)("rem_qc"))
                comm.Parameters.AddWithValue("@logempcd", Userinfo.UserID)
            End With
            Dim da = New SqlDataAdapter(comm)
            Dim dt = New DataTable
            Try
                da.Fill(dt)
            Catch ex As Exception
                msgerr = ex.Message
                tran.Rollback()
                conn.Close()  'Sitthana 20190325
                Return False
            End Try

            StrollsDHeader.h01_dinno = dt.Rows(0)("dinno").ToString
            StrollsDHeader.h02_dindt = dt.Rows(0)("dindt").ToString

        Next


        comm.CommandText = "P_HANGER_STOCK_IN_PKG_update"
        For i = 0 To DV_UPD.Count - 1
            With DV_UPD
                comm.Parameters.Clear()
                comm.Parameters.AddWithValue("@dinno", StrollsDHeader.h01_dinno)
                comm.Parameters.AddWithValue("@dindt", StrollsDHeader.h02_dindt)
                comm.Parameters.AddWithValue("@doctyp", StrollsDHeader.h03_doctyp)
                comm.Parameters.AddWithValue("@roll_no_d", config.IsNull(.Item(i)("roll_no_d"), "").Trim)
                comm.Parameters.AddWithValue("@roll_no_o", config.IsNull(.Item(i)("roll_no_o"), "").Trim)
                comm.Parameters.AddWithValue("@design_no", config.IsNull(.Item(i)("design_no"), "").Trim)
                comm.Parameters.AddWithValue("@sono", config.IsNull(.Item(i)("sono"), "").Trim)
                comm.Parameters.AddWithValue("@sonoid", config.IsNull(.Item(i)("sonoid"), "").Trim)
                comm.Parameters.AddWithValue("@fwth", config.IsNull(.Item(i)("fwth"), "").Trim)
                comm.Parameters.AddWithValue("@Gwth", config.IsNull(.Item(i)("Gwth"), "").Trim)
                comm.Parameters.AddWithValue("@lot", config.IsNull(.Item(i)("lot"), "").Trim)
                comm.Parameters.AddWithValue("@kg", config.IsNull(.Item(i)("kg"), 0))
                comm.Parameters.AddWithValue("@col", config.IsNull(.Item(i)("col"), ""))
                comm.Parameters.AddWithValue("@custcolor", config.IsNull(.Item(i)("custcolor"), ""))
                comm.Parameters.AddWithValue("@mtl_warehouse_id", .Item(i)("mtl_warehouse_id"))
                comm.Parameters.AddWithValue("@mtl_subinventory_id", .Item(i)("mtl_subinventory_id"))
                comm.Parameters.AddWithValue("@mtl_locations_id", .Item(i)("mtl_locations_id"))
                comm.Parameters.AddWithValue("@rem_qc", .Item(i)("rem_qc"))
                comm.Parameters.AddWithValue("@logempcd", Userinfo.UserID)
            End With
            Dim da = New SqlDataAdapter(comm)
            Dim dt = New DataTable
            Try
                da.Fill(dt)
            Catch ex As Exception
                msgerr = ex.Message
                tran.Rollback()
                conn.Close()  'Sitthana 20190325
                Return False
            End Try

            StrollsDHeader.h01_dinno = dt.Rows(0)("dinno").ToString
            StrollsDHeader.h02_dindt = dt.Rows(0)("dindt").ToString

        Next

        comm.CommandText = "P_HANGER_STOCK_IN_PKG_delete"
        For i = 0 To DV_DEL.Count - 1
            With DV_DEL
                comm.Parameters.Clear()
                comm.Parameters.AddWithValue("@dinno", StrollsDHeader.h01_dinno)
                comm.Parameters.AddWithValue("@dindt", StrollsDHeader.h02_dindt)
                comm.Parameters.AddWithValue("@roll_no_d", config.IsNull(.Item(i)("roll_no_d"), "").Trim)

                comm.Parameters.AddWithValue("@logempcd", Userinfo.UserID)
            End With
            Dim da = New SqlDataAdapter(comm)
            Dim dt = New DataTable
            Try
                da.Fill(dt)
            Catch ex As Exception
                msgerr = ex.Message
                tran.Rollback()
                conn.Close()  'Sitthana 20190325
                Return False
            End Try

            StrollsDHeader.h01_dinno = dt.Rows(0)("dinno").ToString
            StrollsDHeader.h02_dindt = dt.Rows(0)("dindt").ToString

        Next

        tran.Commit()
        conn.Close()  'Sitthana 20190325
        Return True
    End Function

End Class
