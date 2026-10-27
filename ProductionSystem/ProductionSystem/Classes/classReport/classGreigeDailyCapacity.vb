Imports System.Data
Imports System.Data.SqlClient
Imports System.Text

Public Class classGreigeDailyCapacity

    Public Function GetCboGreigeDesignNo(Optional ByVal StrEmpCd As String = "") As DataTable
        Dim conn As New SqlConnection((New classConnection).connection)
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "p_greige_daily_capacity_select_design_no"


        Dim dt As New DataTable

        conn.Close()  'Sitthana 20190325
        Return (dt)
    End Function


End Class
