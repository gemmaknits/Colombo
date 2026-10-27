Imports System.Data
Imports System.Data.SqlClient

Public Class Mould
    'Public ID As Long = 0
    'Public Code As String = ""
    'Public NameEn As String = ""
    'Public NameTh As String = ""
    'Public Active As Boolean = True
    'Public Remark As String = ""
    'Public CreatedBy As String = ""
    'Public CreatedDate As String = ""
    'Public CreatedTime As String = ""
    'Public Color As String = ""

    Public Function GetList() As DataTable
        Dim conn As New SqlConnection((New classConnection).connection)
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "p_mas_mould_select"
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        Try
            da.Fill(dt)
        Catch ex As Exception
            Throw ex
        Finally
            comm.Dispose()
            conn.Close()
            conn.Dispose()
        End Try
        Return dt
    End Function

    Public Sub SaveList(dt As DataTable, user As classUserInfo)
        Dim clsConfig As New clsConfig()

        Dim conn As New SqlConnection((New classConnection).connection)
        conn.Open()
        Dim tran As SqlTransaction = conn.BeginTransaction()
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "p_mas_mould_update"
        comm.Transaction = tran

        Try
            For Each dr As DataRow In dt.Rows
                If Not dr("id").ToString().Equals("0") Then
                    comm.Parameters.Clear()
                    comm.Parameters.AddWithValue("@id", clsConfig.IsNull(dr("id"), 0))
                    comm.Parameters.AddWithValue("@code", clsConfig.IsNull(dr("code"), ""))
                    comm.Parameters.AddWithValue("@name_en", clsConfig.IsNull(dr("name_en"), ""))
                    comm.Parameters.AddWithValue("@name_th", clsConfig.IsNull(dr("name_th"), ""))
                    comm.Parameters.AddWithValue("@active", clsConfig.IsNull(dr("active"), True))
                    comm.Parameters.AddWithValue("@remark", clsConfig.IsNull(dr("remark"), ""))
                    comm.Parameters.AddWithValue("@created_by", user.UserID)
                    comm.Parameters.AddWithValue("@created_date", "")
                    comm.Parameters.AddWithValue("@created_time", "")
                    comm.Parameters.AddWithValue("@color", clsConfig.IsNull(dr("color"), ""))
                    comm.ExecuteNonQuery()
                End If
            Next
            tran.Commit()
        Catch ex As Exception
            Throw ex
        Finally
            comm.Dispose()
            tran.Dispose()
            conn.Close()
            conn.Dispose()
        End Try
    End Sub
End Class
