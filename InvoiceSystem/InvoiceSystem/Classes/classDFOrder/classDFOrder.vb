Imports System.Data
Imports System.Data.SqlClient
Imports System.Text

Public Class classDFOrder

    Public Function DFLoad(Optional ByVal strDFNo As String = "", _
       Optional ByVal strDateFr As String = "", _
       Optional ByVal strDateTo As String = "", _
       Optional ByVal strSoNo As String = "", _
       Optional ByVal strCustCD As String = "", _
       Optional ByVal strDHCod As String = "", _
       Optional ByVal strDesignNo As String = "", _
       Optional ByVal strEmpCD As String = "") As DataTable

        Dim conn As New SqlConnection((New classConnection).connection)
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "p_dforder_select"
        comm.Parameters.AddWithValue("@dfno", strDFNo)
        comm.Parameters.AddWithValue("@datefr", strDateFr)
        comm.Parameters.AddWithValue("@dateto", strDateTo)
        comm.Parameters.AddWithValue("@sono", strSoNo)
        comm.Parameters.AddWithValue("@custcd", strCustCD)
        comm.Parameters.AddWithValue("@dhcod", strDHCod)
        comm.Parameters.AddWithValue("@design_no", strDesignNo)
        comm.Parameters.AddWithValue("@empcd", strEmpCD)
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        conn.Close()
        Return dt
    End Function

    Public Function DFPRESETLoad(Optional ByVal strDFNo As String = "", _
       Optional ByVal strDateFr As String = "", _
       Optional ByVal strDateTo As String = "", _
       Optional ByVal strSoNo As String = "", _
       Optional ByVal strCustCD As String = "", _
       Optional ByVal strDHCod As String = "", _
       Optional ByVal strDesignNo As String = "", _
       Optional ByVal strEmpCD As String = "") As DataTable

        Dim conn As New SqlConnection((New classConnection).connection)
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "p_dforder_preset_select"
        comm.Parameters.AddWithValue("@dfno", strDFNo)
        comm.Parameters.AddWithValue("@datefr", strDateFr)
        comm.Parameters.AddWithValue("@dateto", strDateTo)
        comm.Parameters.AddWithValue("@sono", strSoNo)
        comm.Parameters.AddWithValue("@custcd", strCustCD)
        comm.Parameters.AddWithValue("@dhcod", strDHCod)
        comm.Parameters.AddWithValue("@design_no", strDesignNo)
        comm.Parameters.AddWithValue("@empcd", strEmpCD)
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        conn.Close()
        Return dt
    End Function
End Class
