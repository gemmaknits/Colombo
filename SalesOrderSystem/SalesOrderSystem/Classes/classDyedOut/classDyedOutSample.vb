Imports System.Data
Imports System.Data.SqlClient
Imports System.Text


Public Structure StrollsDO
    Dim StrOutno As String
    Dim DateOutdt As Nullable(Of Date)
    Dim Strpackno As String
    Dim Datepackdt As Nullable(Of Date)
    Dim Int32Cartno As Int32
    Dim Int64CustomerID As Int64

    Dim StrDoctyp As String

    Dim StrEmpcd As String
    Dim strRemark As String
    Dim Strmsgerr As String
End Structure

Public Class classDyedOutSample

    Public Function ValidateOutNo(Optional ByVal StrOutno As String = Nothing) As Boolean
        Dim conn As New SqlConnection((New classConnection).connection)
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "p_mfg_dout_sample_pkg_validate_outno"
        comm.Parameters.AddWithValue("@outno", StrOutno)
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        comm.Connection.Close()
        Try
            da.Fill(dt)
        Catch ex As Exception
            conn.Close()  'Sitthana 20190325
            MessageBox.Show(ex.Message, ex.GetType().ToString())
        End Try

        If dt.Rows.Count > 0 Then
            Return False
        End If
        conn.Close()  'Sitthana 20190325
        Return True

    End Function

    Public Function GetComBoCustomer(Optional ByVal logempcd As String = "") As DataTable
        Dim conn As New SqlConnection((New classConnection).connection)
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "p_mfg_dout_sample_pkg_get_combo_customers"

        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        conn.Close()  'Sitthana 20190325
        Return dt
    End Function

    Public Function GetSampleStock(Optional ByVal StrDesignNo As String = Nothing, _
                                           Optional ByVal StrRefdesno As String = Nothing, _
                                           Optional ByVal StrLot As String = Nothing, _
                                           Optional ByVal StrCol As String = Nothing) As DataTable
        Dim conn As New SqlConnection((New classConnection).connection)
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "P_SAMPLE_STOCK_OUT_PKG_get_stock_sample"
        comm.Parameters.AddWithValue("@design_no", StrDesignNo)
        comm.Parameters.AddWithValue("@refdesno", StrRefdesno)
        comm.Parameters.AddWithValue("@lot", StrLot)
        comm.Parameters.AddWithValue("@col", StrCol)

        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        comm.Connection.Close()
        Try
            da.Fill(dt)
        Catch ex As Exception
            conn.Close()  'Sitthana 20190325
            MessageBox.Show(ex.Message, ex.GetType().ToString())
        End Try
        conn.Close()  'Sitthana 20190325
        Return dt

    End Function

    Public Function GetGridDoutNewByOutno(Optional ByVal StrOutno As String = Nothing, Optional ByVal StrPackno As String = Nothing) As DataTable
        Dim conn As New SqlConnection((New classConnection).connection)
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "p_mfg_dout_sample_pkg_get_grid_dout_new_by_outno"
        comm.Parameters.AddWithValue("@outno", StrOutno)
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        comm.Connection.Close()
        Try
            da.Fill(dt)
        Catch ex As Exception
            conn.Close()  'Sitthana 20190325
            MessageBox.Show(ex.Message, ex.GetType().ToString())
        End Try
        conn.Close()  'Sitthana 20190325
        Return dt

    End Function

    Public Function GetGridDoutNewByPackno(Optional ByVal StrPackno As String = Nothing) As DataTable
        Dim conn As New SqlConnection((New classConnection).connection)
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "P_SAMPLE_STOCK_OUT_PKG_get_strolls_d_o_by_packno"
        comm.Parameters.AddWithValue("@packno", StrPackno)
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        comm.Connection.Close()
        Try
            da.Fill(dt)
        Catch ex As Exception
            conn.Close()  'Sitthana 20190325
            MessageBox.Show(ex.Message, ex.GetType().ToString())
        End Try
        conn.Close()  'Sitthana 20190325
        Return dt

    End Function

    Public Function ProductionDOutSavePackNo(ByRef StrollsDO As StrollsDO, ByVal DV_ADD As DataView, ByVal DV_UPD As DataView, ByVal DV_DEL As DataView, ByRef msgerr As String, ByVal Userinfo As classUserInfo) As Boolean
        Dim config As New clsConfig
        Dim conn As New SqlConnection((New classConnection).connection)
        conn.Open()
        Dim tran As SqlTransaction = conn.BeginTransaction
        Dim comm As New SqlCommand("", conn)
        Dim i As Integer = 0
        comm.Transaction = tran
        comm.CommandType = CommandType.StoredProcedure

        i = 0
        comm.CommandText = "P_SAMPLE_STOCK_OUT_PKG_update"

        For i = 0 To DV_ADD.Count - 1
            With DV_ADD
                comm.Parameters.Clear()
                comm.Parameters.AddWithValue("@outno", config.IsNull(.Item(i)("outno"), StrollsDO.StrOutno).Trim)
                comm.Parameters.AddWithValue("@outdt", config.IsNull(.Item(i)("outdt"), StrollsDO.DateOutdt))
                comm.Parameters.AddWithValue("@packno", StrollsDO.Strpackno)
                comm.Parameters.AddWithValue("@packdt", StrollsDO.Datepackdt)
                comm.Parameters.AddWithValue("@design_no", config.IsNull(.Item(i)("design_no"), "").Trim)
                'comm.Parameters.AddWithValue("@subcod", config.IsNull(.Item(i)("subcod"), "").Trim)
                comm.Parameters.AddWithValue("@lot", config.IsNull(.Item(i)("lot"), "").Trim)
                'comm.Parameters.AddWithValue("@yr", config.IsNull(.Item(i)("yr"), "").Trim)
                'comm.Parameters.AddWithValue("@sh", config.IsNull(.Item(i)("sh"), "").Trim)
                comm.Parameters.AddWithValue("@col", config.IsNull(.Item(i)("col"), "").Trim)
                comm.Parameters.AddWithValue("@gr", config.IsNull(.Item(i)("gr"), "").Trim)
                comm.Parameters.AddWithValue("@sonoid", config.IsNull(.Item(i)("sonoid"), "").Trim)
                comm.Parameters.AddWithValue("@roll_no_d", config.IsNull(.Item(i)("roll_no_d"), "").Trim)
                comm.Parameters.AddWithValue("@roll_no_o", config.IsNull(.Item(i)("roll_no_o"), "").Trim)
                comm.Parameters.AddWithValue("@kg", config.IsNull(.Item(i)("request_kg"), 0).ToString)
                comm.Parameters.AddWithValue("@mts", config.IsNull(.Item(i)("request_mts"), 0).ToString)
                comm.Parameters.AddWithValue("@yds", config.IsNull(.Item(i)("request_yds"), 0).ToString)
                comm.Parameters.AddWithValue("@gwth", config.IsNull(.Item(i)("gwth"), "").Trim)
                'comm.Parameters.AddWithValue("@n_yds", config.IsNull(.Item(i)("n_yds"), 0).ToString)
                'comm.Parameters.AddWithValue("@pack", config.IsNull(.Item(i)("pack"), 0).ToString.Trim)
                comm.Parameters.AddWithValue("@batch", config.IsNull(.Item(i)("batch"), "").Trim)
                'comm.Parameters.AddWithValue("@uom", config.IsNull(.Item(i)("uom"), "").Trim)
                comm.Parameters.AddWithValue("@custcolor", config.IsNull(.Item(i)("custcolor"), "").Trim)
                comm.Parameters.AddWithValue("@id_strolls_d_o", .Item(i)("id_strolls_d_o")) '
                'comm.Parameters.AddWithValue("@mfg_production_order_lines_id", StrollsDO.Int64MfgProDuctionOrderLineID)
                'comm.Parameters.AddWithValue("@production_order_id", StrollsDO.Int64ProductionOrderID)
                comm.Parameters.AddWithValue("@dinno", config.IsNull(.Item(i)("dinno"), "").Trim)
                comm.Parameters.AddWithValue("@empcd", StrollsDO.StrEmpcd)
                comm.Parameters.AddWithValue("@doctyp", StrollsDO.StrDoctyp)
                comm.Parameters.AddWithValue("@customer_id", StrollsDO.Int64CustomerID)
                comm.Parameters.AddWithValue("@remark", StrollsDO.strRemark)
                comm.Parameters.AddWithValue("@logempcd", Userinfo.UserID)
            End With
            ' Dim sql As String = config.BuildSQL(comm)
            Dim da = New SqlDataAdapter(comm)
            Dim dt = New DataTable
            Try
                da.Fill(dt)
            Catch ex As Exception
                msgerr = ex.Message
                tran.Rollback()
                conn.Close() 'Sitthana 20190325
                Return False
            End Try

            StrollsDO.StrOutno = dt.Rows(0)("outno").ToString
            StrollsDO.DateOutdt = (New clsConfig).IsNull(dt.Rows(0)("outdt"), CDate("01/01/1900"))
            StrollsDO.Strpackno = dt.Rows(0)("packno").ToString
            StrollsDO.Datepackdt = (New clsConfig).IsNull(dt.Rows(0)("packdt"), CDate("01/01/1900"))
            'StrollsDO.Int32Cartno = dt.Rows(0)("cartno")
        Next

        i = 0
        comm.CommandText = "P_SAMPLE_STOCK_OUT_PKG_delete"
        For i = 0 To DV_DEL.Count - 1
            With DV_DEL
                comm.Parameters.Clear()
                comm.Parameters.AddWithValue("@id_strolls_d_o", .Item(i)("id_strolls_d_o"))
                comm.Parameters.AddWithValue("@outno", .Item(i)("outno"))
                comm.Parameters.AddWithValue("@outdt", .Item(i)("outdt"))
                comm.Parameters.AddWithValue("@roll_no_d", .Item(i)("roll_no_d"))

                comm.Parameters.AddWithValue("@logempcd", Userinfo.UserID)
            End With
            Dim da = New SqlDataAdapter(comm)
            Dim dt = New DataTable
            Try
                da.Fill(dt)
            Catch ex As Exception
                msgerr = ex.Message
                tran.Rollback()
                conn.Close() 'Sitthana 20190325
                Return False
            End Try
        Next

        tran.Commit()
        conn.Close()  'Sitthana 20190325
        Return True
    End Function

    Public Function ProductionDOutSaveOutNo(ByRef StrollsDO As StrollsDO, ByRef msgerr As String, ByVal Userinfo As classUserInfo) As Boolean
        Dim config As New clsConfig
        Dim conn As New SqlConnection((New classConnection).connection)
        conn.Open()
        Dim tran As SqlTransaction = conn.BeginTransaction
        Dim comm As New SqlCommand("", conn)
        Dim i As Integer = 0
        comm.Transaction = tran
        comm.CommandType = CommandType.StoredProcedure
        'Add Detail----------

        i = 0
        comm.CommandText = "P_SAMPLE_STOCK_OUT_PKG_update_outno"


        With StrollsDO
            comm.Parameters.Clear()
            comm.Parameters.AddWithValue("@outno", StrollsDO.StrOutno)
            comm.Parameters.AddWithValue("@outdt", StrollsDO.DateOutdt)
            comm.Parameters.AddWithValue("@packno", StrollsDO.Strpackno)
            comm.Parameters.AddWithValue("@packdt", StrollsDO.Datepackdt)
            comm.Parameters.AddWithValue("@cartno", StrollsDO.Int32Cartno)
            comm.Parameters.AddWithValue("@logempcd", Userinfo.UserID)
            'End If
        End With
        Dim da = New SqlDataAdapter(comm)
        Dim dt = New DataTable
        Try
            da.Fill(dt)
        Catch ex As Exception
            msgerr = ex.Message
            tran.Rollback()
            conn.Close() 'Sitthana 20190325
            Return False
        End Try

        StrollsDO.StrOutno = dt.Rows(0)("outno").ToString
        StrollsDO.DateOutdt = (New clsConfig).IsNull(dt.Rows(0)("outdt"), CDate("01/01/1900"))
        StrollsDO.Strpackno = dt.Rows(0)("packno").ToString
        StrollsDO.Datepackdt = (New clsConfig).IsNull(dt.Rows(0)("packdt"), CDate("01/01/1900"))


        tran.Commit()
        conn.Close()  'Sitthana 20190325
        Return True
    End Function

    Public Function CANCELPLS(ByRef DOUTHeader As StrollsDO, ByRef clsUSER As classUserInfo) As Boolean
        Dim config As New clsConfig

        Dim conn As New SqlConnection((New classConnection).connection)
        conn.Open()
        Dim tran As SqlTransaction = conn.BeginTransaction
        Dim comm As New SqlCommand("", conn)
        Dim i As Integer = 0
        Dim j As Integer = 0
        Dim strLotNo As String = ""
        Dim Action As String = ""
        comm.Transaction = tran
        comm.CommandType = CommandType.StoredProcedure

        comm.CommandText = "P_SAMPLE_STOCK_OUT_PKG_cancel_pls"
        j = 0
        With DOUTHeader
            comm.Parameters.Clear()
            comm.Parameters.AddWithValue("@packno", DOUTHeader.Strpackno)
            comm.Parameters.AddWithValue("@packdt", DOUTHeader.Datepackdt)
            comm.Parameters.AddWithValue("@logempcd", clsUSER.UserID)
        End With
        Dim da_sp = New SqlDataAdapter(comm)
        Dim dt_sp = New DataTable
        Try
            da_sp.Fill(dt_sp)
        Catch ex As Exception
            DOUTHeader.Strmsgerr = ex.Message
            tran.Rollback()
            conn.Close() 'Sitthana 20190325
            Return False
        End Try


        'End Insert Action----------

        tran.Commit()
        conn.Close()  'Sitthana 20190325
        Return True
    End Function

End Class
