Imports System.Data
Imports System.Data.SqlClient
Imports System.Text

Public Class classInventoryPeriod
    Public Function GetLastInventoryPeriodEndDate() As Date
        Dim conn As New SqlConnection((New classConnection).connection)
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "P_INVENTORY_PERIOD_PKG_get_latest_inventory_closed_date"
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        conn.Close()  'Sitthana 20190325
        Return dt.Rows(0)("last_period_end_date")
    End Function

End Class
