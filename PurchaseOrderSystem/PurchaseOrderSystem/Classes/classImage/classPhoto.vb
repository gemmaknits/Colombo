Imports System.Data
Imports System.Data.SqlClient
Imports System.Text
Public Class classPhoto
    Public Structure PhotoHeader
        Dim doc_attachments_id As Nullable(Of Long)
        Dim source_doc_type As String
        Dim source_doc_number As String
        Dim file_description As String
        Dim file_location As String
        Dim file_type As String
        'Dim image As String

        Dim Message As String

    End Structure

    Public Function Getsource_doc_type(Optional ByVal Strsource_doc_type_code As String = "") As DataTable
        Dim conn As New SqlConnection((New classConnection).connection)
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "p_photo_select_source_doc_type"
        comm.Parameters.AddWithValue("@source_doc_type_code", Strsource_doc_type_code)

        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        comm.Connection.Close()
        Return dt
    End Function

    Public Function GetPhoto(Optional ByVal pSourceDocNumber As String = "") As DataTable
        Dim conn As New SqlConnection((New classConnection).connection)
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "p_photo_select_doc_attachments"
        comm.Parameters.AddWithValue("@source_doc_number", pSourceDocNumber)
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        comm.Connection.Close()
        Try
            da.Fill(dt)
        Catch ex As Exception
            conn.Close()  'Sitthana 20190325
            MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        conn.Close()  'Sitthana 20190325
        Return dt
    End Function
    Public Function getDocAttachment(pSourceDocType As String, Optional ByVal pSourceDocNumber As String = "") As DataTable
        Dim conn As New SqlConnection((New classConnection).connection)
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "P_DOC_ATTACH_PKG_select_doc_attachments"
        comm.Parameters.AddWithValue("@p_source_doc_type", pSourceDocType)
        comm.Parameters.AddWithValue("@p_source_doc_number", pSourceDocNumber)
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        comm.Connection.Close()
        Try
            da.Fill(dt)
        Catch ex As Exception
            conn.Close()  'Sitthana 20190325
            MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        conn.Close()  'Sitthana 20190325
        Return dt
    End Function
    Public Function SaveFile(ByRef PhotoHeader As PhotoHeader, ByRef clsuser As classUserInfo)
        Dim config As New clsConfig
        Dim conn As New SqlConnection((New classConnection).connection)
        conn.Open()
        Dim tran As SqlTransaction = conn.BeginTransaction
        Dim comm As New SqlCommand("", conn)

        comm.Transaction = tran
        comm.CommandType = CommandType.StoredProcedure
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable

        If PhotoHeader.doc_attachments_id > 0 Then
            comm.CommandText = "p_photo_update_doc_attachments"
        Else
            comm.CommandText = "p_photo_insert_doc_attachments"
        End If
        With PhotoHeader
            comm.Parameters.Clear()
            comm.Parameters.AddWithValue("@doc_attachments_id", .doc_attachments_id)
            comm.Parameters.AddWithValue("@source_doc_type", .source_doc_type)
            comm.Parameters.AddWithValue("@source_doc_number ", .source_doc_number)
            comm.Parameters.AddWithValue("@file_description", .file_description)
            comm.Parameters.AddWithValue("@file_location", .file_location)
            comm.Parameters.AddWithValue("@file_type", .file_type)
        End With

        da = New SqlDataAdapter(comm)
        dt = New DataTable
        Try
            da.Fill(dt)
        Catch ex As Exception
            PhotoHeader.Message = ex.Message
            tran.Rollback()
            conn.Close()  'Sitthana 20190325
            Return False
        End Try

        tran.Commit()
        comm.Connection.Close()
        Return True
    End Function
    Public Function SavePhoto(ByRef PhotoHeader As PhotoHeader, ByRef dtphoto As DataTable, ByVal dtv_add As DataView, ByVal dtv_upd As DataView, ByVal dtv_del As DataView, ByRef clsuser As classUserInfo)
        Dim config As New clsConfig
        Dim conn As New SqlConnection((New classConnection).connection)
        conn.Open()
        Dim tran As SqlTransaction = conn.BeginTransaction
        Dim comm As New SqlCommand("", conn)
        Dim i As Integer = 0
        Dim strLotNo As String = ""
        comm.Transaction = tran
        comm.CommandType = CommandType.StoredProcedure
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable

        comm.CommandText = "p_photo_insert_doc_attachments"
        For i = 0 To dtv_add.Count - 1
            With dtv_add
                comm.Parameters.Clear()
                comm.Parameters.AddWithValue("@doc_attachments_id", .Item(i)("doc_attachments_id"))
                comm.Parameters.AddWithValue("@source_doc_type", .Item(i)("source_doc_type"))
                comm.Parameters.AddWithValue("@source_doc_number ", .Item(i)("source_doc_number"))
                comm.Parameters.AddWithValue("@file_description", .Item(i)("file_description"))
                comm.Parameters.AddWithValue("@file_location", .Item(i)("file_location"))
                comm.Parameters.AddWithValue("@file_type", .Item(i)("file_type").ToString.ToUpper)
            End With

            da = New SqlDataAdapter(comm)
            dt = New DataTable
            Try
                da.Fill(dt)
            Catch ex As Exception
                PhotoHeader.Message = ex.Message
                tran.Rollback()
                conn.Close()  'Sitthana 20190325
                Return False
            End Try
        Next

        comm.CommandText = "p_photo_update_doc_attachments"
        For i = 0 To dtv_upd.Count - 1
            With dtv_upd
                comm.Parameters.Clear()
                comm.Parameters.AddWithValue("@doc_attachments_id", .Item(i)("doc_attachments_id"))
                comm.Parameters.AddWithValue("@source_doc_type", .Item(i)("source_doc_type"))
                comm.Parameters.AddWithValue("@source_doc_number ", .Item(i)("source_doc_number"))
                comm.Parameters.AddWithValue("@file_description", .Item(i)("file_description"))
                comm.Parameters.AddWithValue("@file_location", .Item(i)("file_location"))
                comm.Parameters.AddWithValue("@file_type", .Item(i)("file_type"))
            End With
            da = New SqlDataAdapter(comm)
            dt = New DataTable
            Try
                da.Fill(dt)
            Catch ex As Exception
                PhotoHeader.Message = ex.Message
                tran.Rollback()
                conn.Close()  'Sitthana 20190325
                Return False
            End Try
        Next
        ' End If
        comm.CommandText = "p_photo_delete_doc_attachments"
        For i = 0 To dtv_del.Count - 1
            With dtv_del
                comm.Parameters.Clear()
                comm.Parameters.AddWithValue("@doc_attachments_id", .Item(i)("doc_attachments_id"))
                comm.Parameters.AddWithValue("@source_doc_type", .Item(i)("source_doc_type"))
                comm.Parameters.AddWithValue("@source_doc_number ", .Item(i)("source_doc_number"))
                comm.Parameters.AddWithValue("@file_description", .Item(i)("file_description"))
                comm.Parameters.AddWithValue("@file_location", .Item(i)("file_location"))
                comm.Parameters.AddWithValue("@file_type", .Item(i)("file_type"))
            End With
            da = New SqlDataAdapter(comm)
            dt = New DataTable
            Try
                da.Fill(dt)
            Catch ex As Exception
                PhotoHeader.Message = ex.Message
                tran.Rollback()
                conn.Close()  'Sitthana 20190325
                Return False
            End Try
        Next

        tran.Commit()
        comm.Connection.Close()
        Return True

    End Function
End Class
