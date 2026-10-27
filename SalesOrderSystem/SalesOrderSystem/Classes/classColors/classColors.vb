Imports System.Data
Imports System.Data.SqlClient
Imports System.Text
Public Class classColors
    Public Function GetColor() As DataTable
        Dim conn As New SqlConnection((New ClassConnection).connection)
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "P_COLORS_FORM_PKG_select_colors_list"
        comm.Parameters.Clear()
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        conn.Close()  'Sitthana 20190325
        Return dt
    End Function

    Public Function ColorSave(ByVal dv_add As DataView, ByVal dv_upd As DataView, ByRef msgerr As String) As Boolean
        Dim config As New clsConfig
        Dim conn As New SqlConnection((New ClassConnection).connection)
        conn.Open()
        Dim tran As SqlTransaction = conn.BeginTransaction
        Dim comm As New SqlCommand("", conn)
        Dim i As Integer = 0
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable

        comm.Transaction = tran
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "P_COLORS_FORM_PKG_update_colors_record"

        For i = 0 To dv_add.Count - 1
            If dv_add(i)("col").ToString.Trim.Length > 0 Then
                comm.Parameters.Clear()
                comm.Parameters.AddWithValue("@col", dv_add(i)("col").ToString.Trim)
                comm.Parameters.AddWithValue("@colname", dv_add(i)("colname").ToString.Trim)
                comm.Parameters.AddWithValue("@base_col", dv_add(i)("base_col").ToString.Trim)
                comm.Parameters.AddWithValue("@custcd", dv_add(i)("custcd").ToString.Trim)
                comm.Parameters.AddWithValue("@labdipno", dv_add(i)("labdipno").ToString.Trim)
                comm.Parameters.AddWithValue("@cust_ref", dv_add(i)("cust_ref").ToString.Trim)
                comm.Parameters.AddWithValue("@labsubdt", dv_add(i)("labsubdt").ToString.Trim)
                comm.Parameters.AddWithValue("@labappdt", dv_add(i)("labappdt").ToString.Trim)
                comm.Parameters.AddWithValue("@labappshade", dv_add(i)("labappshade").ToString.Trim)

                Try
                    da.Fill(dt)
                Catch ex As Exception
                    msgerr = ex.Message
                    tran.Rollback()
                    conn.Close()  'Sitthana 20190325
                    Return False
                End Try
            End If
        Next

        For i = 0 To dv_upd.Count - 1
            If dv_upd(i)("col").ToString.Trim.Length > 0 Then
                comm.Parameters.Clear()
                comm.Parameters.AddWithValue("@col", dv_upd(i)("col").ToString.Trim)
                comm.Parameters.AddWithValue("@colname", dv_upd(i)("colname").ToString.Trim)
                comm.Parameters.AddWithValue("@base_col", dv_upd(i)("base_col").ToString.Trim)
                comm.Parameters.AddWithValue("@custcd", dv_upd(i)("custcd").ToString.Trim)
                comm.Parameters.AddWithValue("@labdipno", dv_upd(i)("labdipno").ToString.Trim)
                comm.Parameters.AddWithValue("@cust_ref", dv_upd(i)("cust_ref").ToString.Trim)
                If config.IsNull(dv_upd(i)("labsubdt"), "") = "" Then
                    comm.Parameters.AddWithValue("@labsubdt", "")
                Else
                    comm.Parameters.AddWithValue("@labsubdt", CDate(dv_upd(i)("labsubdt")).ToString("yyyyMMdd"))
                End If
                If config.IsNull(dv_upd(i)("labappdt"), "") = "" Then
                    comm.Parameters.AddWithValue("@labappdt", "")
                Else
                    comm.Parameters.AddWithValue("@labappdt", CDate(dv_upd(i)("labappdt")).ToString("yyyyMMdd"))
                End If

                comm.Parameters.AddWithValue("@labappshade", dv_upd(i)("labappshade").ToString.Trim)
                Try
                    da.Fill(dt)
                Catch ex As Exception
                    msgerr = ex.Message
                    tran.Rollback()
                    conn.Close()  'Sitthana 20190325
                    Return False
                End Try
            End If
        Next

        tran.Commit()
        conn.Close()  'Sitthana 20190325
        Return True
    End Function
End Class
