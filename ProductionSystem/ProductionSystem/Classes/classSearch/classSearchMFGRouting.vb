Imports System.Data
Imports System.Data.SqlClient
Imports System.Text
Public Class classSearchMFGRouting
    Dim mfg_routing_header_id As Nullable(Of Long)
    Dim routing_code As String
    Dim routing_name As String
    Dim routing_status As String
    Dim created_by As String
    Dim creation_date As Nullable(Of DateTime)
    Dim last_modified_by As String
    Dim last_modified_date As Nullable(Of DateTime)
    Dim message As String


    Public Function SearchMFGRouting(Optional ByVal Strrouting_code As String = "") As DataTable
        Dim conn As New SqlConnection((New classConnection).connection)
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "p_search_mfg_routing_select"
        comm.Parameters.AddWithValue("@routing_code", Strrouting_code)

        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        comm.Connection.Close()
        Return dt
    End Function
End Class

