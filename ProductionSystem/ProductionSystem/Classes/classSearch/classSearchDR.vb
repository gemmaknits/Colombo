Imports System.Data
Imports System.Data.SqlClient
Imports System.Text
Public Class classSearchDR

    Public Function SearchDR(Optional ByVal StrDesign_no As String = "", Optional ByVal pDrNo As String = "") As DataTable
        Dim conn As New SqlConnection((New classConnection).connection)
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "p_search_dr_select"
        comm.Parameters.AddWithValue("@Design_no", StrDesign_no)
        comm.Parameters.AddWithValue("@p_dr_no", pDrNo)

        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        comm.Connection.Close()
        Return dt
    End Function
End Class
