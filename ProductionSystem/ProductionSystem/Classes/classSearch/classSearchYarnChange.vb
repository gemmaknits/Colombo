Imports System.Data
Imports System.Data.SqlClient
Imports System.Text

Public Class classSearchYarnChange

    Public Function SearchYarnChange(Optional ByVal StrDesign_no As String = "") As DataTable
        Dim conn As New SqlConnection((New classConnection).connection)
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "p_search_yarnchange_select"
        comm.Parameters.AddWithValue("@Design_no", StrDesign_no)

        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        conn.Close()  'Sitthana 20190325
        Return dt
    End Function

End Class
