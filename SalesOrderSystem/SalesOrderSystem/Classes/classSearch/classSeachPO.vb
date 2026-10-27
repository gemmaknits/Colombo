Imports System.Data
Imports System.Data.SqlClient
Imports System.Text
Public Class classSeachPO

    'Conversion Project
    Public Function GetGINPOManualSearchPO(Optional ByVal strPOno As String = "", Optional ByVal strDateFr As String = "", Optional ByVal strDateTo As String = "", Optional ByVal strsuppcd As String = "") As DataTable
        Dim conn As New SqlConnection((New classConnection).connection)
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure

        comm.CommandText = "p_greige_in_po_manual_select_po_search"

        comm.Parameters.AddWithValue("@jobno", strPOno)
        comm.Parameters.AddWithValue("@datefr", strDateFr)
        comm.Parameters.AddWithValue("@dateto", strDateTo)
        comm.Parameters.AddWithValue("@suppcd", strsuppcd)
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        conn.Close()  'Sitthana 20190325
        Return dt
    End Function
End Class
