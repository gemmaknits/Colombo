Imports System.Data
Imports System.Data.SqlClient
Imports System.Text
Public Class classSelectMfgProductionSteps
    Public Function SearchProductionSteps(Optional ByVal pProductionOrderNo As String = "", Optional ByVal StrFilter As String = "") As DataTable
        Dim conn As New SqlConnection((New classConnection).connection)
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "P_SELECT_MFG_PRODUCTION_STEPS_PKG_select"
        comm.Parameters.AddWithValue("@production_order_no", pProductionOrderNo)
        comm.Parameters.AddWithValue("@filter", StrFilter)

        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        comm.Connection.Close()
        Return dt
    End Function
End Class
