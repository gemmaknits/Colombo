Imports System.Data
Imports System.Data.SqlClient
Imports System.Text

Public Class classYarnIn
    Dim dt As DataTable

    Public Function GetLocationByYarnInDet() As DataTable
        Dim conn As New SqlConnection((New classConnection).Connection)
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "p_yarn_in_job_return_select_location"
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        conn.Close()  'Sitthana 20190325
        Return dt
    End Function

    Public Function getYarnOut(ByVal Stroutno As String) As DataSet
        Dim conn As New SqlConnection((New classConnection).Connection)
        Dim comm As New SqlCommand("", conn)
        comm.CommandTimeout = 600
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "p_yarn_in_return_select_yarn_out"
        comm.Parameters.AddWithValue("@outno", Stroutno)
        Dim da As New SqlDataAdapter(comm)
        Dim ds As New DataSet
        da.Fill(ds, "v_YarnInReturn")
        comm.Connection.Close()
        Return ds
    End Function



    Public Function GetDataGradeOUR() As DataTable
        Dim conn As New SqlConnection((New classConnection).Connection)
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "p_yarn_in_return_select_combo_grade_our"
        'comm.Parameters.AddWithValue("@suppcd", suppcd.Trim)
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        conn.Close()  'Sitthana 20190325
        Return dt
    End Function

End Class

