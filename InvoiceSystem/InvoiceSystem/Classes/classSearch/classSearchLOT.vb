Imports System.Data
Imports System.Data.SqlClient
Imports System.Text

Public Class classSearchLOT

    Public Function SearchLOTNO(Optional ByVal strStockType As String = "A", Optional ByVal StrLot As String = "", Optional ByVal strDateFr As String = "", Optional ByVal strDateTo As String = "", Optional ByVal strCustCD As String = "", Optional ByVal strDoctyp As String = "") As DataTable
        Dim conn As New SqlConnection((New classConnection).connection)
        Dim comm As New SqlCommand("", conn)

        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "p_search_lot_select_lot_search"
        'comm.Parameters.AddWithValue("@stock_type", strStockType.Trim)
        comm.Parameters.AddWithValue("@lot", StrLot)
        comm.Parameters.AddWithValue("@datefr", strDateFr)
        comm.Parameters.AddWithValue("@dateto", strDateTo)
        comm.Parameters.AddWithValue("@custcd", strCustCD)
        comm.Parameters.AddWithValue("@doctyp", strDoctyp)
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        conn.Close()  'Sitthana 20190325
        Return dt
    End Function
End Class
