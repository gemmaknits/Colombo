Imports System.Data
Imports System.Data.SqlClient
Imports System.Text
Public Class classStockGreigeLoss
    Public Function getGreige(ByVal pSystemLotNumber As String) As DataTable
        Dim conn As New SqlConnection((New classConnection).connection)
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "P_MFG_GREIGE_LOSS_PKG_get_greige"
        comm.Parameters.AddWithValue("@system_lot_number", pSystemLotNumber)
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        Try
            da.Fill(dt)
        Catch ex As Exception
            conn.Close()  'Sitthana 20190325
            MessageBox.Show(ex.Message)
        End Try

        conn.Close()  'Sitthana 20190325
        Return dt
    End Function

    Public Function getGreigeLog(ByVal pLogId As String) As DataTable
        Dim conn As New SqlConnection((New classConnection).connection)
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "P_MFG_GREIGE_LOSS_PKG_select_greige_log"
        comm.Parameters.AddWithValue("@log_id", pLogId)
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        conn.Close()  'Sitthana 20190325
        Return dt
    End Function

    Public Function getGreigeLogDet(ByVal pLogId As String) As DataTable
        Dim conn As New SqlConnection((New classConnection).connection)
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "P_MFG_GREIGE_LOSS_PKG_select_greige_log_det"
        comm.Parameters.AddWithValue("@log_id", pLogId)
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        conn.Close()  'Sitthana 20190325
        Return dt
    End Function

    Public Function SaveData(ByRef drvGreigeLog As DataRowView, ByVal dtGreigeLogDet As DataTable, ByVal Userinfo As classUserInfo, ByRef msgerr As String) As Boolean
        Dim config As New clsConfig
        Dim conn As New SqlConnection((New classConnection).connection)
        conn.Open()
        Dim tran As SqlTransaction = conn.BeginTransaction
        Dim comm As New SqlCommand("", conn)
        Dim i As Integer = 0
        Dim strLotNo As String = ""
        comm.Transaction = tran
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "P_MFG_GREIGE_LOSS_PKG_update_greige_log"

        With drvGreigeLog.Row
            comm.Parameters.Clear()
            comm.Parameters.AddWithValue("@log_id", (New clsConfig).IsNull(.Item("log_id"), DBNull.Value))
            comm.Parameters.AddWithValue("@logempcd", Userinfo.UserID)
        End With
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        Try
            da.Fill(dt)
        Catch ex As Exception
            msgerr = ex.Message
            tran.Rollback()
            conn.Close()
            Return False
        End Try

        drvGreigeLog.Row("log_id") = dt.Rows(0)("log_id").ToString.Trim

        comm.CommandText = "P_MFG_GREIGE_LOSS_PKG_update_greige_log_det"

        For Each dr As DataRow In dtGreigeLogDet.Rows
            If dr.RowState <> DataRowState.Deleted Then
                comm.Parameters.Clear()
                comm.Parameters.AddWithValue("@log_det_id", dr("log_det_id"))
                comm.Parameters.AddWithValue("@log_id", (New clsConfig).IsNull(drvGreigeLog.Row("log_id"), DBNull.Value))
                comm.Parameters.AddWithValue("@system_lot_number", dr("system_lot_number"))
                comm.Parameters.AddWithValue("@adjust_loss_kg", dr("adjust_loss_kg"))
                comm.Parameters.AddWithValue("@qc_loss_kg", dr("qc_loss_kg"))
                comm.Parameters.AddWithValue("@dyed_loss_kg", dr("dyed_loss_kg"))
                comm.Parameters.AddWithValue("@lab_loss_kg", dr("lab_loss_kg"))
                comm.Parameters.AddWithValue("@defect_loss_kg", dr("defect_loss_kg"))
                comm.Parameters.AddWithValue("@logempcd", Userinfo.UserID)
                da = New SqlDataAdapter(comm)
                dt = New DataTable
                Try
                    da.Fill(dt)
                Catch ex As Exception
                    msgerr = ex.Message
                    tran.Rollback()
                    conn.Close()
                    Return False
                End Try
            End If
        Next

        tran.Commit()
        conn.Close()
        Return True
    End Function
End Class
