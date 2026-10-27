Imports System.Data
Imports System.Data.SqlClient
Imports System.Text
Public Class classSelectSo
    Public Function SearchSo(Optional ByVal _filter As String = "") As DataTable
        Dim conn As New SqlConnection((New classConnection).connection)
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "P_SELECT_SO_PKG_select"
        comm.Parameters.AddWithValue("@filter", _filter)
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        comm.Connection.Close()
        Return dt
    End Function
End Class
