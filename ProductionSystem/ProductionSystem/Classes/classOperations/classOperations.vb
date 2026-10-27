Imports System.Data
Imports System.Data.SqlClient
Imports System.Text
Public Class classOperations
    Public Structure mfg_operationsHeader
        Dim mfg_operations_id As Nullable(Of Long)
        Dim operation_name As String
        Dim operation_status As String
        Dim created_by As String
        Dim creation_date As Nullable(Of DateTime)
        Dim last_modified_by As String
        Dim last_modified_date As Nullable(Of DateTime)
        Dim message As String

    End Structure

    Public Function Getoperations(Optional ByVal Intmfg_operations_id As Nullable(Of Integer) = Nothing) As DataTable
        Dim conn As New SqlConnection((New classConnection).connection)
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "p_operations_select_mfg_operations"
        comm.Parameters.AddWithValue("@mfg_operations_id", Intmfg_operations_id)
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        comm.Connection.Close()
        Try
            da.Fill(dt)
            conn.Close()  'Sitthana 20190325
        Catch ex As Exception
            conn.Close()  'Sitthana 20190325

        End Try

        Return dt
    End Function

    Public Function SaveOperationsMaster(ByRef mfg_operationsHeader As mfg_operationsHeader, ByRef dtphoto As DataTable, ByVal dtv_add As DataView, ByVal dtv_upd As DataView, ByVal dtv_del As DataView, ByRef clsuser As classUserInfo)
        Dim config As New clsConfig
        Dim conn As New SqlConnection((New classConnection).connection)
        conn.Open()
        Dim tran As SqlTransaction = conn.BeginTransaction
        Dim comm As New SqlCommand("", conn)
        Dim i As Integer = 0
        Dim strLotNo As String = ""
        comm.Transaction = tran
        comm.CommandType = CommandType.StoredProcedure
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable

        comm.CommandText = "p_operations_insert_mfg_operations"
        For i = 0 To dtv_add.Count - 1
            With dtv_add
                comm.Parameters.Clear()
                comm.Parameters.AddWithValue("@mfg_operations_id", config.IsNull(.Item(i)("mfg_operations_id"), Nothing))
                comm.Parameters.AddWithValue("@operation_code", .Item(i)("operation_code"))
                comm.Parameters.AddWithValue("@operation_name", .Item(i)("operation_name"))
                comm.Parameters.AddWithValue("@operation_status", .Item(i)("operation_status"))
                comm.Parameters.AddWithValue("@created_by", clsuser.UserID) '.Item(i)("created_by"))
                comm.Parameters.AddWithValue("@creation_date", DateTime.Now) '.Item(i)("creation_date"))
                comm.Parameters.AddWithValue("@last_modified_by", .Item(i)("last_modified_by"))
                comm.Parameters.AddWithValue("@last_modified_date", .Item(i)("last_modified_date"))
            End With

            da = New SqlDataAdapter(comm)
            dt = New DataTable
            Try
                da.Fill(dt)
            Catch ex As Exception
                mfg_operationsHeader.Message = ex.Message
                tran.Rollback()
                conn.Close()  'Sitthana 20190325
                Return False
            End Try
        Next

        comm.CommandText = "p_operations_update_mfg_operations"
        For i = 0 To dtv_upd.Count - 1
            With dtv_upd
                comm.Parameters.Clear()
                comm.Parameters.AddWithValue("@mfg_operations_id", .Item(i)("mfg_operations_id"))
                comm.Parameters.AddWithValue("@operation_code", .Item(i)("operation_code"))
                comm.Parameters.AddWithValue("@operation_name", .Item(i)("operation_name"))
                comm.Parameters.AddWithValue("@operation_status", .Item(i)("operation_status"))
                comm.Parameters.AddWithValue("@created_by", .Item(i)("created_by"))
                comm.Parameters.AddWithValue("@creation_date", .Item(i)("creation_date"))
                comm.Parameters.AddWithValue("@last_modified_by", clsuser.UserID) '.Item(i)("last_modified_by"))
                comm.Parameters.AddWithValue("@last_modified_date", DateTime.Now) '.Item(i)("last_modified_date"))
            End With
            da = New SqlDataAdapter(comm)
            dt = New DataTable
            Try
                da.Fill(dt)
            Catch ex As Exception
                mfg_operationsHeader.message = ex.Message
                tran.Rollback()
                conn.Close()  'Sitthana 20190325
                Return False
            End Try
        Next
        ' End If
        comm.CommandText = "p_operations_delete_mfg_operations"
        For i = 0 To dtv_del.Count - 1
            With dtv_del
                comm.Parameters.Clear()
                comm.Parameters.AddWithValue("@mfg_operations_id", .Item(i)("mfg_operations_id"))
                comm.Parameters.AddWithValue("@operation_code", .Item(i)("operation_code"))
                comm.Parameters.AddWithValue("@operation_name", .Item(i)("operation_name"))
                comm.Parameters.AddWithValue("@operation_status", .Item(i)("operation_status"))
                comm.Parameters.AddWithValue("@created_by", .Item(i)("created_by"))
                comm.Parameters.AddWithValue("@creation_date", .Item(i)("creation_date"))
                comm.Parameters.AddWithValue("@last_modified_by", .Item(i)("last_modified_by"))
                comm.Parameters.AddWithValue("@last_modified_date", .Item(i)("last_modified_date"))
            End With
            da = New SqlDataAdapter(comm)
            dt = New DataTable
            Try
                da.Fill(dt)
            Catch ex As Exception
                mfg_operationsHeader.message = ex.Message
                tran.Rollback()
                conn.Close()  'Sitthana 20190325
                Return False
            End Try
        Next

        tran.Commit()
        comm.Connection.Close()
        Return True

    End Function

End Class

