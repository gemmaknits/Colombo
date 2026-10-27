Imports System.Data
Imports System.Data.SqlClient
Public Class classCreditNoteARExport

    Public Function GetDocNo(
  ByVal lngDocID As Long,
  ByVal strDocNo As String,
  Optional ByVal strDateFr As String = "",
  Optional ByVal strDateTo As String = "",
  Optional ByVal strInvNo As String = "") As DataTable
        Dim conn As New SqlConnection((New classConnection).connection)
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "p_crnote_ar_export_select"
        comm.Parameters.AddWithValue("@id_crnote", lngDocID)
        comm.Parameters.AddWithValue("@crnote_no", strDocNo)
        comm.Parameters.AddWithValue("@datefr", strDateFr)
        comm.Parameters.AddWithValue("@dateto", strDateTo)
        comm.Parameters.AddWithValue("@invno", strInvNo)
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        conn.Close()  'Sitthana 20190325
        Return dt
    End Function

    Public Function getComboFreight(ByVal StrInvno As String)
        Dim conn As New SqlConnection((New classConnection).connection)
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "p_crnote_ar_export_select_inv_export_freight"
        comm.Parameters.AddWithValue("@invno", StrInvno)
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        conn.Close()  'Sitthana 20190325
        Return dt
    End Function

    Public Function GetInvNo() As DataTable
        Dim conn As New SqlConnection((New classConnection).connection)
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "p_crnote_ar_export_select_invno"
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        conn.Close()  'Sitthana 20190325
        Return dt
    End Function
End Class
