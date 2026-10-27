Imports System.Data
Imports System.Data.SqlClient
Imports System.Text

Public Class classDyedOutFromStock

    Public Function GetDesignNo(Optional ByRef strSoNo As String = "", Optional ByRef strDesignNo As String = "") As DataTable
        Dim conn As New SqlConnection((New classConnection).connection)
        Dim comm As New SqlCommand("", conn)
        comm.CommandTimeout = 600
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "p_dyed_out_from_stock_select_design_no"
        comm.Parameters.AddWithValue("@sono", strSoNo.Trim)
        comm.Parameters.AddWithValue("@design_no", strDesignNo.Trim)
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        conn.Close()
        Return dt
    End Function

    Public Function GetStrolls_d_o(Optional ByVal StrOutno As String = "") As DataTable
        Dim conn As New SqlConnection((New classConnection).connection)
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "p_dyed_out_from_stock_select_strolls_d_o"
        comm.Parameters.AddWithValue("@outno", StrOutno)
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        conn.Close()  'Sitthana 20190325
        Return dt
    End Function

    Public Function GetCboOutno(Optional ByVal StrOutno As String = "", Optional ByRef StrID_Strolls_d_o As Nullable(Of Int64) = 0) As DataTable
        Dim conn As New SqlConnection((New classConnection).connection)
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = "p_dyed_out_from_stock_select_outno"
        comm.Parameters.AddWithValue("@outno", StrOutno)
        comm.Parameters.AddWithValue("@id_strolls_d_o", StrID_Strolls_d_o)
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        conn.Close()  'Sitthana 20190325
        Return dt


    End Function


    Public Function GetSODesignGrid(Optional ByVal strSoNo As String = "", Optional ByVal strDesignNo As String = "") As DataTable
        Dim conn As New SqlConnection((New classConnection).connection)
        Dim comm As New SqlCommand("", conn)
        comm.CommandTimeout = 60 * 60 * 30
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "p_so_designs_grid2"
        comm.Parameters.AddWithValue("@sono", strSoNo.Trim)
        comm.Parameters.AddWithValue("@design_no", strDesignNo.Trim)
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        conn.Close()  'Sitthana 20190325
        Return dt
    End Function

End Class
