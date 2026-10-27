Imports System.Data
Imports System.Data.SqlClient
Imports System.Text
Public Class classSearchYarnCodeFromBalance
    Public Function GetYarnCodeFromKo(Optional ByVal pitnaturecd As String = "", Optional ByVal pKono As String = "" _
                                    , Optional ByVal pItCd As String = "", Optional ByVal StrFilter As String = "") As DataTable
        Dim conn As New SqlConnection((New classConnection).Connection)
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "P_SEARCH_YARN_CODE_FROM_BALANCE_PKG_select"
        comm.Parameters.Clear()
        comm.Parameters.AddWithValue("@itnaturecd", pitnaturecd)
        comm.Parameters.AddWithValue("@kono", pKono)
        comm.Parameters.AddWithValue("@p_itcd", pItCd) 'Sitthana 20200131
        comm.Parameters.AddWithValue("@filter", StrFilter)
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        comm.Connection.Close()
        Return dt
    End Function
End Class
