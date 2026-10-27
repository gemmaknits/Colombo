Imports System.Data
Imports System.Data.SqlClient
Imports System.Text
Imports System.Globalization
Public Class classSaleOrderEnterCustPoUnique
    Public Function GetCustPoUnique() As DataTable
        Dim conn As New SqlConnection((New classConnection).connection)
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "P_SO_PKG_get_custpo_unique"
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        conn.Close()  'Sitthana 20190325
        Return dt
    End Function

    Public Function ValidateCustPoUnique(ByVal StrSono As String, ByVal StrCustPoUnique As String) As Boolean
        Dim conn As New SqlConnection((New classConnection).connection)
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "P_SO_PKG_validate_custpo_unique"
        comm.Parameters.AddWithValue("@sono", StrSono)
        comm.Parameters.AddWithValue("@custpo_unique", StrCustPoUnique)
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        Dim Result As Boolean = True
        da.Fill(dt)
        conn.Close()
        Result = dt.Rows(0)("result")

        Return Result

    End Function

    Public Function GetSONoExist(ByVal StrSono As String, ByVal StrCustPoUnique As String) As String
        Dim conn As New SqlConnection((New classConnection).connection)
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "P_SO_PKG_get_sono_exists_by_custpo_unique"
        comm.Parameters.AddWithValue("@sono", StrSono)
        comm.Parameters.AddWithValue("@custpo_unique", StrCustPoUnique)
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        Dim Result As String
        da.Fill(dt)
        conn.Close()
        Result = dt.Rows(0)("sono_exist")

        Return Result

    End Function
End Class

