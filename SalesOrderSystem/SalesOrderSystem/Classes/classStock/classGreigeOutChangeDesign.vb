Imports System.Data
Imports System.Data.SqlClient
Public Class classGreigeOutChangeDesign
    Public Function getGreigetoChangeDesignNo(ByVal pTranNo As String, ByRef pErrMessage As String) As DataTable
        Dim conn As New SqlConnection((New classConnection).connection)
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure

        comm.CommandText = "P_GREIGE_OUT_CHANGE_DESIGN_PKG_get_greige"
        comm.Parameters.AddWithValue("@tran_no", pTranNo)
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        Try
            da.Fill(dt)
            conn.Close()
        Catch ex As Exception
            pErrMessage = ex.Message
            conn.Close()
        End Try

        Return dt
    End Function
    Public Function ValidateDesignNew(ByVal pDesignNo As String, ByRef pErrMessage As String) As DataTable
        Dim conn As New SqlConnection((New classConnection).connection)
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure

        comm.CommandText = "P_GREIGE_OUT_CHANGE_DESIGN_PKG_validate_design_no"
        comm.Parameters.AddWithValue("@design_no", pDesignNo)
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        Try
            da.Fill(dt)
            conn.Close()
        Catch ex As Exception
            pErrMessage = ex.Message
            conn.Close()
        End Try

        Return dt
    End Function

    Public Function getData(ByVal pOutNo As String) As DataTable
        Dim conn As New SqlConnection((New classConnection).connection)
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure

        comm.CommandText = "P_GREIGE_OUT_CHANGE_DESIGN_PKG_select"
        comm.Parameters.AddWithValue("@outno", pOutNo)
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        Try
            da.Fill(dt)
            conn.Close()
        Catch ex As Exception
            ' pMessage = ex.Message
            conn.Close()
        End Try

        Return dt
    End Function

    Public Function getDataGreige(ByVal pTranNo As String) As DataTable
        Dim conn As New SqlConnection((New classConnection).connection)
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure

        comm.CommandText = "P_GREIGE_OUT_CHANGE_DESIGN_PKG_select_greige"
        comm.Parameters.AddWithValue("@tran_no", pTranNo)
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        ' Try
        da.Fill(dt)
            conn.Close()
        ' Catch ex As Exception
        ' pMessage = ex.Message
        'conn.Close()
        'End Try

        Return dt
    End Function

    Public Function CancelGOut(Optional ByVal pOutno As String = "",
                               Optional ByVal pTranno As String = "",
                               Optional ByVal plogempcd As String = "",
                               Optional ByRef pMessage As String = "") As Boolean
        Dim conn As New SqlConnection((New classConnection).connection)
        Dim comm As New SqlCommand("", conn)
        comm.Connection.Open()
        Dim tran As SqlTransaction = conn.BeginTransaction
        comm.Transaction = tran

        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "p_greige_in_cancel"
        comm.Parameters.Clear()
        comm.Parameters.AddWithValue("@tran_no", pTranno)
        comm.Parameters.AddWithValue("@logempcd", plogempcd)
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        Try
            da.Fill(dt)
        Catch ex As Exception
            pMessage = ex.Message
            tran.Rollback()
            conn.Close()
            Return False
        End Try

        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "p_greige_do_delete"
        comm.Parameters.Clear()
        comm.Parameters.AddWithValue("@outno", pOutno)
        comm.Parameters.AddWithValue("@loginempcd", plogempcd)
        da = New SqlDataAdapter(comm)
        dt = New DataTable
        Try
            da.Fill(dt)
        Catch ex As Exception
            pMessage = ex.Message
            tran.Rollback()
            conn.Close()
            Return False
        End Try

        tran.Commit()
        conn.Close()
        Return True
    End Function

    Public Function SaveGreigeChangeDesign(ByRef OldTranNo As String,
                                           ByRef NewTranNo As String,
                                           ByRef NewDesignNo As String,
                                       ByRef NewOutno As String,
                                           ByVal Outdt As Date,
                                           ByRef Packno As String,
                                           ByVal dtGreigeDo As DataTable,
                                           ByVal dtGreige As DataTable,
                                           ByRef logempcd As String,
                                           ByRef Message As String) As Boolean
        Dim config As New clsConfig
        Dim conn As New SqlConnection((New classConnection).connection)
        conn.Open()
        Dim tran As SqlTransaction = conn.BeginTransaction
        Dim comm As New SqlCommand("", conn)
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        comm.Transaction = tran
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "P_GREIGE_OUT_CHANGE_DESIGN_PKG_update_greige_do"
        For Each dr As DataRow In dtGreigeDo.Rows
            If dr.RowState <> DataRowState.Deleted Then
                comm.Parameters.Clear()
                comm.Parameters.AddWithValue("@tran_no", OldTranNo)
                comm.Parameters.AddWithValue("@outno", NewOutno)
                comm.Parameters.AddWithValue("@outdt", Outdt)
                comm.Parameters.AddWithValue("@packno", Packno)
                comm.Parameters.AddWithValue("@roll_no_g", dr("roll_no_g"))
                comm.Parameters.AddWithValue("@roll_no_o", dr("roll_no_o"))
                comm.Parameters.AddWithValue("@design_no", dr("design_no"))
                comm.Parameters.AddWithValue("@kg", dr("kg"))
                comm.Parameters.AddWithValue("@mts", dr("mts"))
                comm.Parameters.AddWithValue("@yds", dr("yds"))
                comm.Parameters.AddWithValue("@logempcd", logempcd)

                da = New SqlDataAdapter(comm)
                dt = New DataTable
                Try
                    da.Fill(dt)
                    NewOutno = dt.Rows(0)("outno").ToString().Trim()
                    Packno = dt.Rows(0)("packno").ToString().Trim()
                Catch ex As Exception
                    tran.Rollback()
                    Message = ex.Message
                    Return False
                End Try
            End If
        Next

        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "P_GREIGE_OUT_CHANGE_DESIGN_PKG_update_greige"
        For Each dr As DataRow In dtGreige.Rows
            If dr.RowState <> DataRowState.Deleted Then
                comm.Parameters.Clear()
                comm.Parameters.AddWithValue("@outno", NewOutno) 'Out No From Greige Out
                comm.Parameters.AddWithValue("@tran_no", NewTranNo)
                comm.Parameters.AddWithValue("@tran_dt", Outdt)
                comm.Parameters.AddWithValue("@roll_no", dr("roll_no"))
                comm.Parameters.AddWithValue("@roll_no_g", dr("roll_no_g"))
                comm.Parameters.AddWithValue("@roll_no_o", dr("roll_no_o"))
                comm.Parameters.AddWithValue("@design_no", dr("design_no"))
                comm.Parameters.AddWithValue("@kg_qc", dr("kg_qc"))
                comm.Parameters.AddWithValue("@bar_weight", dr("bar_weight"))
                comm.Parameters.AddWithValue("@mts_qc", dr("mts_qc"))
                comm.Parameters.AddWithValue("@yds_qc", dr("yds_qc"))
                comm.Parameters.AddWithValue("@logempcd", logempcd)

                da = New SqlDataAdapter(comm)
                dt = New DataTable
                Try
                    da.Fill(dt)
                    NewTranNo = dt.Rows(0)("tran_no").ToString().Trim()
                Catch ex As Exception
                    tran.Rollback()
                    Message = ex.Message
                    Return False
                End Try
            End If
        Next



        tran.Commit()
        conn.Close()
        Return True

    End Function

End Class
