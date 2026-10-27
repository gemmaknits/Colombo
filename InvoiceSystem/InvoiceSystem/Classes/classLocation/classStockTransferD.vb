Imports System.Data
Imports System.Data.SqlClient
Imports System.Text

Public Class classStockTransferD
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

    Public Function GetRollLocationD(ByVal trn_id As Long, ByVal trn_no As String, ByVal roll_no_d As String, ByVal lot As String) As DataTable
        Dim conn As New SqlConnection((New classConnection).connection)
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "p_dyed_location_by_roll"
        comm.Parameters.AddWithValue("@trn_id", trn_id)
        comm.Parameters.AddWithValue("@trn_no", trn_no)
        comm.Parameters.AddWithValue("@roll_no_d", roll_no_d)
        comm.Parameters.AddWithValue("@lot", lot)
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        conn.Close()  'Sitthana 20190325
        Return dt
    End Function

    Public Function GetTransferDyedByBarcode(ByVal Strroll_no_d As String, ByVal Strdinno As String, ByVal Strdono As String, ByVal Strlot As String, ByVal StrUSerID As String) As DataTable
        Dim conn As New SqlConnection((New classConnection).connection)
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "p_dyed_transfer_select_barcode"
        comm.Parameters.AddWithValue("@roll_no_d", Strroll_no_d)
        comm.Parameters.AddWithValue("@dinno", Strdinno)
        comm.Parameters.AddWithValue("@dono", Strdono)
        comm.Parameters.AddWithValue("@lot", Strlot)
        comm.Parameters.AddWithValue("@empcd", StrUSerID)
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
        comm.CommandText = "p_greige_transfer_select_barcode"
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

    Public Function GetTransferNoD() As DataTable
        Dim conn As New SqlConnection((New classConnection).connection)
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "p_dyed_transfer_select"
        comm.Parameters.AddWithValue("@trn_no", "")
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
        comm.CommandText = "p_greige_transfer_select"
        comm.Parameters.AddWithValue("@trn_no", "")
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        conn.Close()  'Sitthana 20190325
        Return dt
    End Function

    Public Function GetTransferDetD(ByVal trn_no As String) As DataTable
        Dim conn As New SqlConnection((New classConnection).connection)
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "p_dyed_transfer_det_select"
        comm.Parameters.AddWithValue("@trn_no", trn_no)
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        conn.Close()  'Sitthana 20190325
        Return dt
    End Function

    Public Function GetTransferDetG(ByVal trn_no As String) As DataTable
        Dim conn As New SqlConnection((New classConnection).connection)
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "p_greige_transfer_det_select"
        comm.Parameters.AddWithValue("@trn_no", trn_no)
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        conn.Close()  'Sitthana 20190325
        Return dt
    End Function

    Public Function TrnSave(ByRef TrnH As TrnHeader, ByVal TrnD_ADD As DataView, ByVal TrnD_UPD As DataView, ByVal TrnD_DEL As DataView, ByRef msgerr As String) As Boolean
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
        comm.CommandText = "p_dyed_transfer_update"

        comm.Parameters.Clear()
        comm.Parameters.AddWithValue("@trn_id", TrnH.h01_trn_id)
        comm.Parameters.AddWithValue("@new_location", TrnH.h05_new_location)
        comm.Parameters.AddWithValue("@new_sub_location", config.IsNull(TrnH.h06_new_sub_location, ""))
        comm.Parameters.AddWithValue("@loginempcd", TrnH.h07_login_empcd)
        comm.Parameters.AddWithValue("@mtl_warehouse_id", TrnH.h08_mtl_warehouse_id)
        comm.Parameters.AddWithValue("@mtl_subinventory_id", TrnH.h09_mtl_subinventory_id)
        comm.Parameters.AddWithValue("@mtl_locations_id", TrnH.h10_mtl_locations_id)

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
        'TrnH.h08_mtl_warehouse_id = dt.Rows(0)("mtl_warehouse_id")
        'TrnH.h09_mtl_locations_id = dt.Rows(0)("mtl_locations_id")
        'TrnH.h10_mtl_subinventory_id = dt.Rows(0)("mtl_subinventory_id")

        'Add Detail----------

        comm.CommandText = "p_dyed_transfer_det_update"

        For i = 0 To TrnD_ADD.Count - 1
            With TrnD_ADD
                comm.Parameters.Clear()
                comm.Parameters.AddWithValue("@det_id", 0)
                comm.Parameters.AddWithValue("@trn_id", TrnH.h01_trn_id)
                comm.Parameters.AddWithValue("@roll_no_d", config.IsNull(.Item(i)("roll_no_d"), ""))
                comm.Parameters.AddWithValue("@location", TrnH.h05_new_location)
                comm.Parameters.AddWithValue("@sub_location", config.IsNull(.Item(i)("sub_location"), ""))
                'comm.Parameters.AddWithValue("@status", config.IsNull(.Item(i)("status"), 0))
                'comm.Parameters.AddWithValue("@new_status", config.IsNull(.Item(i)("new_status"), 0))
                comm.Parameters.AddWithValue("@mtl_warehouse_id", .Item(i)("mtl_warehouse_id"))
                comm.Parameters.AddWithValue("@mtl_subinventory_id", .Item(i)("mtl_subinventory_id"))
                comm.Parameters.AddWithValue("@mtl_locations_id", .Item(i)("mtl_locations_id"))
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
        comm.CommandText = "p_dyed_transfer_det_update"

        For i = 0 To TrnD_UPD.Count - 1
            With TrnD_UPD
                comm.Parameters.Clear()
                comm.Parameters.AddWithValue("@det_id", config.IsNull(.Item(i)("det_id"), 0))
                comm.Parameters.AddWithValue("@trn_id", TrnH.h01_trn_id)
                comm.Parameters.AddWithValue("@roll_no_g", config.IsNull(.Item(i)("roll_no_g"), ""))
                comm.Parameters.AddWithValue("@location", TrnH.h05_new_location)
                comm.Parameters.AddWithValue("@sub_location", config.IsNull(.Item(i)("sub_location"), ""))
                'comm.Parameters.AddWithValue("@status", config.IsNull(.Item(i)("status"), 0))
                ' comm.Parameters.AddWithValue("@new_status", config.IsNull(.Item(i)("new_status"), 0))
                comm.Parameters.AddWithValue("@mtl_warehouse_id", .Item(i)("mtl_warehouse_id"))
                comm.Parameters.AddWithValue("@mtl_subinventory_id", .Item(i)("mtl_subinventory_id"))
                comm.Parameters.AddWithValue("@mtl_locations_id", .Item(i)("mtl_locations_id"))

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
        comm.CommandText = "p_dyed_transfer_det_delete"

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
        comm.CommandText = "p_greige_transfer_update"

        comm.Parameters.Clear()
        comm.Parameters.AddWithValue("@trn_id", TrnH.h01_trn_id)
        comm.Parameters.AddWithValue("@new_location", config.IsNull(TrnH.h05_new_location, ""))
        comm.Parameters.AddWithValue("@new_sub_location", config.IsNull(TrnH.h06_new_sub_location, ""))
        comm.Parameters.AddWithValue("@loginempcd", TrnH.h07_login_empcd)
        'comm.Parameters.AddWithValue("@mtl_warehouse_id", TrnH.h08_mtl_warehouse_id)
        'comm.Parameters.AddWithValue("@mtl_locations_id", TrnH.h09_mtl_locations_id)
        'comm.Parameters.AddWithValue("@mtl_subinventory_id", TrnH.h10_mtl_subinventory_id)

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
        'TrnH.h08_mtl_warehouse_id = dt.Rows(0)("mtl_warehouse_id")
        'TrnH.h09_mtl_locations_id = dt.Rows(0)("mtl_locations_id")
        'TrnH.h10_mtl_subinventory_id = dt.Rows(0)("mtl_subinventory_id")

        'Add Detail----------

        comm.CommandText = "p_greige_transfer_det_update"

        For i = 0 To TrnD_ADD.Count - 1
            With TrnD_ADD
                comm.Parameters.Clear()
                comm.Parameters.AddWithValue("@det_id", 0)
                comm.Parameters.AddWithValue("@trn_id", TrnH.h01_trn_id)
                comm.Parameters.AddWithValue("@roll_no_g", config.IsNull(.Item(i)("roll_no_g"), ""))
                comm.Parameters.AddWithValue("@location", config.IsNull(TrnH.h05_new_location, ""))
                comm.Parameters.AddWithValue("@sub_location", config.IsNull(.Item(i)("sub_location"), ""))
                comm.Parameters.AddWithValue("@status", config.IsNull(.Item(i)("status"), 0))
                comm.Parameters.AddWithValue("@new_status", config.IsNull(.Item(i)("new_status"), 0))
                comm.Parameters.AddWithValue("@mtl_warehouse_id", .Item(i)("mtl_warehouse_id"))
                comm.Parameters.AddWithValue("@mtl_locations_id", .Item(i)("mtl_locations_id"))
                comm.Parameters.AddWithValue("@mtl_subinventory_id", .Item(i)("mtl_subinventory_id"))
                comm.Parameters.AddWithValue("@old_mtl_warehouse_id", .Item(i)("mtl_warehouse_id"))
                comm.Parameters.AddWithValue("@old_mtl_locations_id", .Item(i)("mtl_locations_id"))
                comm.Parameters.AddWithValue("@old_mtl_subinventory_id", .Item(i)("mtl_subinventory_id"))
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
        comm.CommandText = "p_greige_transfer_det_update"

        For i = 0 To TrnD_UPD.Count - 1
            With TrnD_UPD
                comm.Parameters.Clear()
                comm.Parameters.AddWithValue("@det_id", config.IsNull(.Item(i)("det_id"), 0))
                comm.Parameters.AddWithValue("@trn_id", TrnH.h01_trn_id)
                comm.Parameters.AddWithValue("@roll_no_g", config.IsNull(.Item(i)("roll_no_g"), ""))
                comm.Parameters.AddWithValue("@location", TrnH.h05_new_location)
                comm.Parameters.AddWithValue("@sub_location", config.IsNull(.Item(i)("sub_location"), ""))
                comm.Parameters.AddWithValue("@status", config.IsNull(.Item(i)("status"), 0))
                comm.Parameters.AddWithValue("@new_status", config.IsNull(.Item(i)("new_status"), 0))
                comm.Parameters.AddWithValue("@mtl_warehouse_id", .Item(i)("mtl_warehouse_id"))
                comm.Parameters.AddWithValue("@mtl_locations_id", .Item(i)("mtl_locations_id"))
                comm.Parameters.AddWithValue("@mtl_subinventory_id", .Item(i)("mtl_subinventory_id"))
                comm.Parameters.AddWithValue("@old_mtl_warehouse_id", .Item(i)("mtl_warehouse_id"))
                comm.Parameters.AddWithValue("@old_mtl_locations_id", .Item(i)("mtl_locations_id"))
                comm.Parameters.AddWithValue("@old_mtl_subinventory_id", .Item(i)("mtl_subinventory_id"))

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
        comm.CommandText = "p_greige_transfer_det_delete"

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

    Public Function TrnDelete(ByVal trn_id As Long, ByVal loginempcd As String)
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
        comm.CommandText = "p_dyed_transfer_delete"

        comm.Parameters.Clear()
        comm.Parameters.AddWithValue("@trn_id", trn_id)
        comm.Parameters.AddWithValue("@loginempcd", loginempcd)

        Dim xxx As String = config.BuildSQL(comm)
        Debug.Print(xxx)

        da = New SqlDataAdapter(comm)
        dt = New DataTable
        Try
            da.Fill(dt)
            conn.Close()  'Sitthana 20190325
        Catch ex As Exception
            tran.Rollback()
            conn.Close()  'Sitthana 20190325
            Return False
        End Try
        Return True
    End Function

    Public Function GetRollDetails(strRollNo As String) As DataTable
        Dim conn As New SqlConnection((New classConnection).connection)
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "p_dyed_roll_no"
        comm.Parameters.AddWithValue("@trn_no", "")
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        conn.Close()  'Sitthana 20190325
        Return dt
    End Function
End Class


