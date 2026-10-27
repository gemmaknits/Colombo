Imports System.Data
Imports System.Data.SqlClient
Imports System.Text
Public Class classLookup
    Public Structure Lookup_value

        Dim lookup_value_id As Nullable(Of Int64)
        Dim lookup_type_id As Nullable(Of Int64) 'Lookup_id in Lookup_type table
        Dim lookup_value_code As String
        Dim lookup_value As String
        Dim lookup_value_short_code As String
        Dim parent_lookup_value_id As Nullable(Of Int64)
        Dim active As Nullable(Of Boolean)
        Dim message As String


    End Structure

    Public Function Getlookup_id(ByVal lookup_type As String, ByVal lookup_value As String) As Integer
        Dim conn As New SqlConnection
        Dim classConnection As New classConnection
        conn.ConnectionString = classConnection.connection
        Dim comm As New SqlCommand '("", conn)
        comm.Connection = conn
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "p_lookup_select_lookup_id"
        comm.Parameters.AddWithValue("@p_lookup_type", lookup_type)
        comm.Parameters.AddWithValue("@p_lookup_value", lookup_value)
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        conn.Close()
        Dim LookupValueId As Integer = 0
        If dt.Rows.Count > 0 Then
            LookupValueId = dt.Rows(0)("lookup_value_id")
        End If
        Return LookupValueId
    End Function
    Public Function Getlookup_value(ByVal int64lookup_id As Nullable(Of Int64)) As DataTable
        Dim conn As New SqlConnection
        Dim classConnection As New classConnection
        conn.ConnectionString = classConnection.connection
        Dim comm As New SqlCommand '("", conn)
        comm.Connection = conn
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "p_lookup_select_lookup_value"
        comm.Parameters.AddWithValue("@lookup_type_id", int64lookup_id)
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        conn.Close()
        Return dt
    End Function

    Public Function Savedata(ByRef lookUp_value As Lookup_value, ByRef dv_insert As DataView, ByRef dv_update As DataView, ByRef dv_delete As DataView, ByVal clsuser As classUserInfo) As Boolean
        Dim config As New clsConfig
        Dim classConnection As New classConnection

        Dim conn As New SqlConnection(classConnection.connection)
        conn.Open()
        Dim tran As SqlTransaction = conn.BeginTransaction
        Dim comm As New SqlCommand("", conn)
        Dim i As Integer = 0
        Dim j As Integer = 0

        comm.Transaction = tran
        comm.CommandType = CommandType.StoredProcedure

        comm.CommandText = "p_lookup_insert_lookup_value"
        For i = 0 To dv_insert.Count - 1
            With dv_insert
                comm.Parameters.Clear()
                comm.Parameters.AddWithValue("@lookup_value_id", .Item(i)("lookup_value_id"))
                comm.Parameters.AddWithValue("@lookup_id", lookUp_value.lookup_type_id)
                comm.Parameters.AddWithValue("@lookup_value_code", .Item(i)("lookup_value_code"))
                comm.Parameters.AddWithValue("@lookup_value", .Item(i)("lookup_value"))
                comm.Parameters.AddWithValue("@lookup_value_short_code", .Item(i)("lookup_value_short_code"))
                comm.Parameters.AddWithValue("@parent_lookup_value_id", .Item(i)("parent_lookup_value_id"))
                comm.Parameters.AddWithValue("@active", .Item(i)("active"))
            End With


            Dim darl_int = New SqlDataAdapter(comm)
            Dim dtrl_int = New DataTable
            Try
                darl_int.Fill(dtrl_int)
            Catch ex As Exception
                lookUp_value.message = ex.Message
                tran.Rollback()
                conn.Close()
                Return False
                Exit Function
            End Try

        Next

        comm.CommandText = "p_lookup_update_lookup_value"
        For i = 0 To dv_update.Count - 1
            With dv_update
                comm.Parameters.Clear()
                comm.Parameters.AddWithValue("@lookup_value_id", .Item(i)("lookup_value_id"))
                comm.Parameters.AddWithValue("@lookup_id", lookUp_value.lookup_type_id)
                comm.Parameters.AddWithValue("@lookup_value_code", .Item(i)("lookup_value_code"))
                comm.Parameters.AddWithValue("@lookup_value", .Item(i)("lookup_value"))
                comm.Parameters.AddWithValue("@lookup_value_short_code", .Item(i)("lookup_value_short_code"))
                comm.Parameters.AddWithValue("@parent_lookup_value_id", .Item(i)("parent_lookup_value_id"))
                comm.Parameters.AddWithValue("@active", .Item(i)("active"))
            End With


            Dim da_upd = New SqlDataAdapter(comm)
            Dim dt_upd = New DataTable
            Try
                da_upd.Fill(dt_upd)
            Catch ex As Exception
                lookUp_value.message = ex.Message
                tran.Rollback()
                conn.Close()
                Return False
                Exit Function
            End Try

        Next

        tran.Commit()
        conn.Close()
        Return True

    End Function

End Class
