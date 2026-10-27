Imports System.Data
Imports System.Data.SqlClient
Imports System.Text
Public Class classStockTransferG
    Public Structure TrnHeader
        Dim h01_trn_id As Long
        Dim h02_trn_no As String
        Dim h03_trn_date As String
        Dim h04_trn_time As String
        Dim h05_new_location As String
        Dim h06_new_sub_location As String
        Dim h07_login_empcd As String
        Dim h08_mtl_warehouse_id As Nullable(Of Int64)
        Dim h09_mtl_subinventory_id As Nullable(Of Int64)
        Dim h10_mtl_locations_id As Nullable(Of Int64)

    End Structure

    Public Function GetTransferDetG(ByVal trn_no As String) As DataTable
        Dim conn As New SqlConnection((New classConnection).connection)
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "P_GREIGE_TRANSFER_PKG_select_greige_transfer_det"
        comm.Parameters.AddWithValue("@trn_no", trn_no)
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        conn.Close()  'Sitthana 20190325
        Return dt
    End Function

    Public Function GetTransferGregieByBarcode(ByVal Strroll_no As String, ByVal Strtran_no As String _
                                             , ByVal Strsource_refno As String, ByVal Strlot As String _
                                             , ByVal StrUSerID As String) As DataTable
        Dim conn As New SqlConnection((New classConnection).connection)
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "P_GREIGE_TRANSFER_PKG_get_greige"
        comm.Parameters.AddWithValue("@roll_no", Strroll_no)
        comm.Parameters.AddWithValue("@tran_no", Strtran_no)
        comm.Parameters.AddWithValue("@source_refno", Strsource_refno)
        comm.Parameters.AddWithValue("@lot", Strlot)
        comm.Parameters.AddWithValue("@empcd", StrUSerID)
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        conn.Close()  'Sitthana 20190325
        Return dt
    End Function

    Public Function GetTransferNoG() As DataTable
        Dim conn As New SqlConnection((New classConnection).connection)
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "P_GREIGE_TRANSFER_PKG_get_trn_no"
        comm.Parameters.AddWithValue("@trn_no", "")
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        conn.Close()  'Sitthana 20190325
        Return dt
    End Function


    Public Function TrnGSave(ByRef TrnH As TrnHeader, ByVal TrnD_ADD As DataView, ByVal TrnD_UPD As DataView, ByVal TrnD_DEL As DataView, ByRef msgerr As String) As Boolean
        Dim config As New clsConfig
        Dim conn As New SqlConnection((New classConnection).connection)
        conn.Open()
        Dim tran As SqlTransaction = conn.BeginTransaction
        Dim comm As New SqlCommand("", conn)
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        Dim i As Integer = 0

        comm.Transaction = tran
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "P_GREIGE_TRANSFER_PKG_update_greige_transfer"

        comm.Parameters.Clear()
        comm.Parameters.AddWithValue("@trn_id", TrnH.h01_trn_id)
        comm.Parameters.AddWithValue("@new_location", TrnH.h05_new_location)
        comm.Parameters.AddWithValue("@new_sub_location", config.IsNull(TrnH.h06_new_sub_location, ""))
        comm.Parameters.AddWithValue("@loginempcd", TrnH.h07_login_empcd)


        Dim xxx As String = config.BuildSQL(comm)
        Debug.Print(xxx)

        da = New SqlDataAdapter(comm)
        dt = New DataTable
        Try
            da.Fill(dt)
        Catch ex As Exception
            msgerr = ex.Message
            tran.Rollback()
            conn.Close()  'Sitthana 20190325
            Return False
        End Try
        TrnH.h01_trn_id = dt.Rows(0)("trn_id")
        TrnH.h02_trn_no = dt.Rows(0)("trn_no")

        'Add Detail----------

        comm.CommandText = "P_GREIGE_TRANSFER_PKG_update_greige_transfer_det"

        For i = 0 To TrnD_ADD.Count - 1
            With TrnD_ADD
                comm.Parameters.Clear()
                comm.Parameters.AddWithValue("@det_id", 0)
                comm.Parameters.AddWithValue("@trn_id", TrnH.h01_trn_id)
                comm.Parameters.AddWithValue("@roll_no_g", config.IsNull(.Item(i)("roll_no_g"), ""))
                comm.Parameters.AddWithValue("@sub_location", config.IsNull(.Item(i)("sub_location"), ""))
                comm.Parameters.AddWithValue("@status", config.IsNull(.Item(i)("status"), 0))
                comm.Parameters.AddWithValue("@new_status", config.IsNull(.Item(i)("new_status"), 0))
                comm.Parameters.AddWithValue("@mtl_warehouse_id_from", .Item(i)("mtl_warehouse_id_from"))
                comm.Parameters.AddWithValue("@mtl_subinventory_id_from", .Item(i)("mtl_subinventory_id_from"))
                comm.Parameters.AddWithValue("@mtl_locations_id_from", .Item(i)("mtl_locations_id_from"))
                comm.Parameters.AddWithValue("@mtl_warehouse_id_to", .Item(i)("mtl_warehouse_id_to"))
                comm.Parameters.AddWithValue("@mtl_subinventory_id_to", .Item(i)("mtl_subinventory_id_to"))
                comm.Parameters.AddWithValue("@mtl_locations_id_to", .Item(i)("mtl_locations_id_to"))
                comm.Parameters.AddWithValue("@loc_from", .Item(i)("loc_from"))
                comm.Parameters.AddWithValue("@loc_to", .Item(i)("loc_to"))
                comm.Parameters.AddWithValue("@grade_from", .Item(i)("grade_from"))
                comm.Parameters.AddWithValue("@grade_to", .Item(i)("grade_to"))
                comm.Parameters.AddWithValue("@grade_bdt_from", .Item(i)("grade_bdt_from"))
                comm.Parameters.AddWithValue("@grade_bdt_to", .Item(i)("grade_bdt_to"))
                comm.Parameters.AddWithValue("@grade_adt_from", .Item(i)("grade_adt_from"))
                comm.Parameters.AddWithValue("@grade_adt_to", .Item(i)("grade_adt_to"))
                comm.Parameters.AddWithValue("@loginempcd", TrnH.h07_login_empcd)

            End With

            da = New SqlDataAdapter(comm)
            dt = New DataTable
            Try
                da.Fill(dt)
            Catch ex As Exception
                msgerr = ex.Message
                tran.Rollback()
                conn.Close()  'Sitthana 20190325
                Return False
            End Try
        Next

        'Update Detail----------

        i = 0
        comm.CommandText = "P_GREIGE_TRANSFER_PKG_update_greige_transfer_det"

        For i = 0 To TrnD_UPD.Count - 1
            With TrnD_UPD
                comm.Parameters.Clear()
                comm.Parameters.AddWithValue("@det_id", 0)
                comm.Parameters.AddWithValue("@trn_id", TrnH.h01_trn_id)
                comm.Parameters.AddWithValue("@roll_no_g", config.IsNull(.Item(i)("roll_no_g"), ""))
                comm.Parameters.AddWithValue("@sub_location", config.IsNull(.Item(i)("sub_location"), ""))
                comm.Parameters.AddWithValue("@status", config.IsNull(.Item(i)("status"), 0))
                comm.Parameters.AddWithValue("@new_status", config.IsNull(.Item(i)("new_status"), 0))
                comm.Parameters.AddWithValue("@mtl_warehouse_id_from", .Item(i)("mtl_warehouse_id_from"))
                comm.Parameters.AddWithValue("@mtl_subinventory_id_from", .Item(i)("mtl_subinventory_id_from"))
                comm.Parameters.AddWithValue("@mtl_locations_id_from", .Item(i)("mtl_locations_id_from"))
                comm.Parameters.AddWithValue("@mtl_warehouse_id_to", .Item(i)("mtl_warehouse_id_to"))
                comm.Parameters.AddWithValue("@mtl_subinventory_id_to", .Item(i)("mtl_subinventory_id_to"))
                comm.Parameters.AddWithValue("@mtl_locations_id_to", .Item(i)("mtl_locations_id_to"))
                comm.Parameters.AddWithValue("@loc_from", .Item(i)("loc_from"))
                comm.Parameters.AddWithValue("@loc_to", .Item(i)("loc_to"))
                comm.Parameters.AddWithValue("@grade_from", .Item(i)("grade_from"))
                comm.Parameters.AddWithValue("@grade_to", .Item(i)("grade_to"))
                comm.Parameters.AddWithValue("@grade_bdt_from", .Item(i)("grade_bdt_from"))
                comm.Parameters.AddWithValue("@grade_bdt_to", .Item(i)("grade_bdt_to"))
                comm.Parameters.AddWithValue("@grade_adt_from", .Item(i)("grade_adt_from"))
                comm.Parameters.AddWithValue("@grade_adt_to", .Item(i)("grade_adt_to"))
                comm.Parameters.AddWithValue("@loginempcd", TrnH.h07_login_empcd)

            End With

            Dim sql As String = config.BuildSQL(comm)
            Debug.Print(sql)

            da = New SqlDataAdapter(comm)
            dt = New DataTable
            Try
                da.Fill(dt)
            Catch ex As Exception
                msgerr = ex.Message
                tran.Rollback()
                conn.Close()  'Sitthana 20190325
                Return False
            End Try
        Next

        'Delete Detail----------

        i = 0
        comm.CommandText = "P_GREIGE_TRANSFER_PKG_delete_greige_transfer_det"

        For i = 0 To TrnD_DEL.Count - 1
            With TrnD_DEL(i)
                comm.Parameters.Clear()
                comm.Parameters.AddWithValue("@det_id", config.IsNull(.Item("det_id"), 0))
                comm.Parameters.AddWithValue("@log_empcd", TrnH.h07_login_empcd)
            End With
            da = New SqlDataAdapter(comm)
            dt = New DataTable
            Try
                da.Fill(dt)
            Catch ex As Exception
                msgerr = ex.Message
                tran.Rollback()
                conn.Close()  'Sitthana 20190325
                Return False
            End Try
        Next

        tran.Commit()
        conn.Close()  'Sitthana 20190325
        Return True
    End Function

End Class
