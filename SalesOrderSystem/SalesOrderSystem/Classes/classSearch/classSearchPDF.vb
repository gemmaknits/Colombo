Imports System.Data
Imports System.Data.SqlClient
Imports System.Text
Public Class classSearchPDF
    Public Function SearchPDF(Optional ByVal StrSoNoID As String = "") As DataTable
        Dim conn As New SqlConnection((New classConnection).connection)
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "p_poc_pdf_select"
        comm.Parameters.AddWithValue("@p_sonoid", StrSoNoID)
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        conn.Close()  'Sitthana 20190325
        Return dt

    End Function
End Class
