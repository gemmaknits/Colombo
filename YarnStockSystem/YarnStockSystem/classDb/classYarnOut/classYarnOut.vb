Imports System.Data
Imports System.Data.SqlClient
Imports System.Text

Public Class classYarnOut
    Public Function ValidateJobNoAlreadyOut(Optional ByVal StrRefdocno As String = "", Optional ByVal StrEmpcd As String = "") As DataTable
        Dim conn As New SqlConnection((New classConnection).Connection)
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure

        comm.CommandText = "p_yarn_out_select_jobno_validate"

        comm.Parameters.AddWithValue("@refdocno", StrRefdocno)
        comm.Parameters.AddWithValue("@logempcd", StrEmpcd)
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        conn.Close()  'Sitthana 20190325
        Return (dt)
    End Function

    Public Function ValidateJobno(ByVal StrJobno As String) As Boolean
        'Sitthana 03/03/2018  Copy From Gemmaknits
        Dim conn As New SqlConnection((New classConnection).Connection())
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "p_yarn_out_pkg_validate_jobno"
        comm.Parameters.AddWithValue("@jobno", StrJobno.Trim)
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable

        Try
            da.Fill(dt)
            conn.Close()  'Sitthana 20190325
        Catch ex As Exception
            conn.Close()  'Sitthana 20190325

        End Try

        If dt.Rows.Count > 0 Then Return True Else Return False

    End Function

    Public Function ValidateOutno(ByVal StrOutno As String) As Boolean

        Dim conn As New SqlConnection((New classConnection).Connection())
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "p_yarn_out_pkg_validate_outno"
        comm.Parameters.AddWithValue("@outno", StrOutno.Trim)
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable

        Try
            da.Fill(dt)
            conn.Close()  'Sitthana 20190325
        Catch ex As Exception
            conn.Close()  'Sitthana 20190325

        End Try

        If dt.Rows.Count > 0 Then Return False Else Return True

    End Function

    Public Function ValitateJobNoAlreadyKOClosed(ByVal StrJobno As String) As Boolean
        Dim conn As New SqlConnection((New classConnection).Connection)
        Dim comm As New SqlCommand("", conn)
        conn.Open()
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "P_YARN_OUT_PKG_validate_jobno_already_closed"
        comm.Parameters.AddWithValue("@jobno", StrJobno)

        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        conn.Close()  'Sitthana 20190325

        If dt.Rows.Count > 0 Then
            Return dt.Rows(0)("koclosed")
        Else
            Return False
        End If

    End Function

End Class
