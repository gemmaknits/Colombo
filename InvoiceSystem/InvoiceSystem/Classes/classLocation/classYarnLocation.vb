Imports System.Data
Imports System.Data.SqlClient
Imports System.Text

Public Class classYarnLocation
    Public Function getYarnLocationLog(ByVal logno As String) As DataTable
        Dim conn As New SqlConnection((New ClassConnection).connection)
        Dim comm As New SqlCommand("", conn)
        comm.CommandTimeout = 600
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "p_yarn_location_log_select"
        comm.Parameters.AddWithValue("@logno", logno)
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        conn.Close()  'Sitthana 20190325
        Return dt
    End Function


    Public Function getYarnIN(ByVal itcd As String) As DataTable
        Dim conn As New SqlConnection((New ClassConnection).connection)
        Dim comm As New SqlCommand("", conn)
        comm.CommandTimeout = 600
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "p_yarn_in_select6"
        comm.Parameters.AddWithValue("@itcd", itcd)
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        conn.Close()  'Sitthana 20190325
        Return dt
    End Function

    Public Function getYarnINByLocation(ByVal Int64mtl_locations_id As Nullable(Of Int64), ByVal StrLoc As String) As DataTable
        Dim conn As New SqlConnection((New ClassConnection).connection)
        Dim comm As New SqlCommand("", conn)
        comm.CommandTimeout = 600
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "p_yarn_in_select_location"
        comm.Parameters.AddWithValue("@mtl_locations_id", Int64mtl_locations_id)
        comm.Parameters.AddWithValue("@loc", StrLoc)
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        conn.Close()  'Sitthana 20190325
        Return dt
    End Function

    Public Function GetYarnInByBoxno(ByVal StrBoxno As String) As DataTable
        Dim conn As New SqlConnection((New ClassConnection).connection)
        Dim comm As New SqlCommand("", conn)
        'comm.CommandTimeout = 600
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "p_yarn_in_select_boxno"
        comm.Parameters.AddWithValue("@boxno", StrBoxno)
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        conn.Close()  'Sitthana 20190325
        Return dt
    End Function

    Public Function GetYarnLocationByBoxno(ByVal StrBoxno As String) As DataTable
        Dim conn As New SqlConnection((New ClassConnection).connection)
        Dim comm As New SqlCommand("", conn)
        'comm.CommandTimeout = 600
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "p_yarn_location_log_select_yarn_in_det"
        comm.Parameters.AddWithValue("@boxno", StrBoxno)
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        conn.Close()  'Sitthana 20190325
        Return dt
    End Function

    Public Function GetYarnInByBoxno2(ByVal strREQGNo As String) As DataTable
        Dim conn As New SqlConnection((New ClassConnection).connection)
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "p_yarn_in_select_boxno"
        comm.Parameters.AddWithValue("@boxno", strREQGNo)
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        conn.Close()  'Sitthana 20190325
        Return dt
    End Function


    Public Function getItems() As DataTable
        Dim conn As New SqlConnection((New ClassConnection).connection)
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "p_items_select"
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        conn.Close()  'Sitthana 20190325
        Return dt
    End Function

    Public Function getYarnLocationLogNo() As DataTable
        Dim conn As New SqlConnection((New ClassConnection).connection)
        Dim comm As New SqlCommand("", conn)
        comm.CommandTimeout = 600
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "p_yarn_location_log_select2"
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        conn.Close()  'Sitthana 20190325
        Return dt
    End Function

    Public Function YarnLocationSaveHeader(ByRef strLogNo As String,
                                            ByVal strLocationTo As String,
                                            ByVal strActualMoveDate As String,
                                            ByVal strReceiveDate As String,
                                            ByVal Int64mtl_warehouse_id_fr As Nullable(Of Int64),
                                            ByVal Int64mtl_subinventory_id_fr As Nullable(Of Int64),
                                            ByVal Int64mtl_locations_id_fr As Nullable(Of Int64),
                                            ByVal Int64mtl_warehouse_id_to As Nullable(Of Int64),
                                            ByVal Int64mtl_subinventory_id_to As Nullable(Of Int64),
                                            ByVal Int64mtl_locations_id_to As Nullable(Of Int64)) As Boolean
        Dim conn As New SqlConnection((New ClassConnection).connection)
        Dim comm As New SqlCommand("", conn)
        conn.Open()
        Dim tran As SqlTransaction = conn.BeginTransaction
        Dim i As Integer = 0
        comm.Transaction = tran
        comm.CommandType = Data.CommandType.StoredProcedure
        comm.CommandText = "p_yarn_location_log_header_update"
        comm.Parameters.AddWithValue("@logno", strLogNo)
        comm.Parameters.AddWithValue("@location_to", strLocationTo)
        comm.Parameters.AddWithValue("@actual_move_date", strActualMoveDate)
        comm.Parameters.AddWithValue("@receive_date", strReceiveDate)
        comm.Parameters.AddWithValue("@mtl_warehouse_id", Int64mtl_warehouse_id_fr)
        comm.Parameters.AddWithValue("@mtl_subinventory_id_fr", Int64mtl_subinventory_id_fr)
        comm.Parameters.AddWithValue("@mtl_locations_id", Int64mtl_locations_id_fr)
        comm.Parameters.AddWithValue("@mtl_warehouse_id_to", Int64mtl_warehouse_id_to)
        comm.Parameters.AddWithValue("@mtl_subinventory_id_to", Int64mtl_subinventory_id_to)
        comm.Parameters.AddWithValue("@mtl_locations_id_to", Int64mtl_locations_id_to)
        Try
            Call comm.ExecuteNonQuery()
        Catch ex As Exception
            tran.Rollback()
            conn.Close()  'Sitthana 20190325
            Return False
        End Try

        tran.Commit()
        conn.Close()  'Sitthana 20190325
        comm.Dispose()
        If conn.State = ConnectionState.Open Then conn.Close()
        conn.Dispose()
        Return True
    End Function

    Public Function GetYarnInBalance(ByVal StrBoxno As String) As DataTable
        Dim conn As New SqlConnection((New ClassConnection).connection)
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "p_yarn_location_select_boxno"
        comm.Parameters.AddWithValue("@boxno", StrBoxno)

        Dim dt As New DataTable
        Dim da As New SqlDataAdapter(comm)
        da.Fill(dt)
        Try
            da.Fill(dt)
            conn.Close()  'Sitthana 20190325
        Catch ex As Exception
            conn.Close()  'Sitthana 20190325


        End Try

        Return dt

    End Function

    Public Function YarnLocationSave(ByVal dv_add As DataView, ByVal dv_del As DataView, ByRef msgerr As String, ByVal log_empcd As String, ByRef strLogNo As String) As Boolean
        Dim conn As New SqlConnection((New ClassConnection).connection)
        Dim comm As New SqlCommand("", conn)
        conn.Open()
        Dim tran As SqlTransaction = conn.BeginTransaction
        Dim i As Integer = 0
        comm.Transaction = tran
        comm.CommandType = Data.CommandType.StoredProcedure
        comm.CommandText = "p_yarn_location_log_update"
        'Dim strLogNo As String = ""
        Dim da As New SqlDataAdapter()
        Dim dt2 As New DataTable
        For i = 0 To dv_add.Count - 1
            comm.Parameters.Clear()
            comm.Parameters.AddWithValue("@logno", strLogNo)
            comm.Parameters.AddWithValue("@boxno", dv_add(i)("boxno"))
            comm.Parameters.AddWithValue("@location", dv_add(i)("loc"))
            comm.Parameters.AddWithValue("@mtl_warehouse_id", dv_add(i)("mtl_warehouse_id"))
            comm.Parameters.AddWithValue("@mtl_locations_id", dv_add(i)("mtl_locations_id"))
            comm.Parameters.AddWithValue("@mtl_warehouse_id_to", dv_add(i)("mtl_warehouse_id_to"))
            comm.Parameters.AddWithValue("@mtl_locations_id_to", dv_add(i)("mtl_locations_id_to"))
            comm.Parameters.AddWithValue("@log_empcd", log_empcd)
            da = New SqlDataAdapter(comm)
            Try
                da.Fill(dt2)
            Catch ex As Exception
                msgerr = ex.Message
                tran.Rollback()
                conn.Close()  'Sitthana 20190325
                Return False
            End Try
            strLogNo = dt2.Rows(0)("logno").ToString()
        Next

        comm.CommandText = "p_yarn_location_log_del"
        For i = 0 To dv_del.Count - 1
            comm.Parameters.Clear()
            comm.Parameters.AddWithValue("@p_yarn_location_log_delete", dv_del(i)("id_yarn_location"))
            Try
                comm.ExecuteNonQuery()
            Catch ex As Exception
                msgerr = ex.Message
                tran.Rollback()
                conn.Close()  'Sitthana 20190325
                Return False
            End Try
        Next

        tran.Commit()
        comm.Dispose()
        If conn.State = ConnectionState.Open Then conn.Close()
        conn.Dispose()
        Return True
    End Function

    Public Function YarnLocationBarcodeSave(ByVal dv_add As DataView, ByVal dv_del As DataView, ByRef msgerr As String, ByVal log_empcd As String, ByRef strLogNo As String) As Boolean
        Dim conn As New SqlConnection((New ClassConnection).connection)
        Dim comm As New SqlCommand("", conn)
        conn.Open()
        Dim tran As SqlTransaction = conn.BeginTransaction
        Dim i As Integer = 0
        comm.Transaction = tran
        comm.CommandType = Data.CommandType.StoredProcedure
        comm.CommandText = "p_yarn_in_location_barcode_insert"
        'Dim strLogNo As String = ""
        Dim da As New SqlDataAdapter()
        Dim dt2 As New DataTable
        For i = 0 To dv_add.Count - 1
            comm.Parameters.Clear()
            comm.Parameters.AddWithValue("@logno", strLogNo)
            comm.Parameters.AddWithValue("@boxno", dv_add(i)("boxno"))
            comm.Parameters.AddWithValue("@location", dv_add(i)("loc"))
            comm.Parameters.AddWithValue("@mtl_warehouse_id", dv_add(i)("mtl_warehouse_id"))
            comm.Parameters.AddWithValue("@mtl_subinventory_id", dv_add(i)("mtl_subinventory_id"))
            comm.Parameters.AddWithValue("@mtl_locations_id", dv_add(i)("mtl_locations_id"))
            comm.Parameters.AddWithValue("@mtl_warehouse_id_to", dv_add(i)("mtl_warehouse_id_to"))
            comm.Parameters.AddWithValue("@mtl_subinventory_id_to", dv_add(i)("mtl_subinventory_id_to"))
            comm.Parameters.AddWithValue("@mtl_locations_id_to", dv_add(i)("mtl_locations_id_to"))
            comm.Parameters.AddWithValue("@log_empcd", log_empcd)
            da = New SqlDataAdapter(comm)
            Try
                da.Fill(dt2)
            Catch ex As Exception
                msgerr = ex.Message
                tran.Rollback()
                conn.Close()  'Sitthana 20190325
                Return False
            End Try
            strLogNo = dt2.Rows(0)("logno").ToString()
        Next

        comm.CommandText = "p_yarn_in_location_barcode_delete"
        For i = 0 To dv_del.Count - 1
            comm.Parameters.Clear()
            comm.Parameters.AddWithValue("@p_yarn_location_log_delete", dv_del(i)("id_yarn_location"))
            Try
                comm.ExecuteNonQuery()
            Catch ex As Exception
                msgerr = ex.Message
                tran.Rollback()
                conn.Close()  'Sitthana 20190325
                Return False
            End Try
        Next

        tran.Commit()
        comm.Dispose()
        If conn.State = ConnectionState.Open Then conn.Close()
        conn.Dispose()
        Return True
    End Function
End Class
