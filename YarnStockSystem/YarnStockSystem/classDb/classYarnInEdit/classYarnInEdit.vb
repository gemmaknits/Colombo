Imports System.Data
Imports System.Data.SqlClient
Imports System.Text
Public Class classYarnInEdit
    Public Function ValitateDocNoAlreadyKOClosed(ByVal StrDocno As String) As Boolean
        Dim conn As New SqlConnection((New classConnection).Connection)
        Dim comm As New SqlCommand("", conn)
        conn.Open()
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "P_YARN_IN_EDIT_PKG_validate_docno_already_closed"
        comm.Parameters.AddWithValue("@docno", StrDocno)

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
