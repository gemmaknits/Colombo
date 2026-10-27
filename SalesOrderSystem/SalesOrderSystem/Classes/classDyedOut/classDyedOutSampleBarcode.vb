Imports System.Data
Imports System.Data.SqlClient
Imports System.Text
Public Class classDyedOutSampleBarcode

    Public Function GetGridDoutNewByBarcode(Optional ByVal Int64IDStrollsDO As Nullable(Of Int64) = Nothing) As DataTable
        Dim conn As New SqlConnection((New classConnection).connection)
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "P_SAMPLE_STOCK_OUT_BARCODE_PKG_get_dout_new_by_barcode"
        comm.Parameters.AddWithValue("@id_strolls_d_o", Int64IDStrollsDO)
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
        comm.CommandText = "P_SAMPLE_STOCK_OUT_BARCODE_PKG_get_dout_new_by_outno"
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

    Public Function MakeSampleOut(ByRef StrollsDO As StrollsDO, ByVal DV_ADD As DataView, ByVal DV_UPD As DataView, ByVal DV_DEL As DataView, ByRef msgerr As String, ByVal Userinfo As classUserInfo) As Boolean
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
        comm.CommandText = "P_SAMPLE_STOCK_OUT_BARCODE_PKG_update"

        For i = 0 To DV_ADD.Count - 1
            With DV_ADD
                comm.Parameters.Clear()
                comm.Parameters.AddWithValue("@outno", StrollsDO.StrOutno)
                comm.Parameters.AddWithValue("@outdt", StrollsDO.DateOutdt)
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

            StrollsDO.StrOutno = dt.Rows(0)("outno").ToString
            StrollsDO.DateOutdt = (New clsConfig).IsNull(dt.Rows(0)("outdt"), CDate("01/01/1900"))
            'StrollsDO.Strpackno = dt.Rows(0)("packno").ToString
            'StrollsDO.Datepackdt = (New clsConfig).IsNull(dt.Rows(0)("packdt"), CDate("01/01/1900"))
            'StrollsDO.Int32Cartno = dt.Rows(0)("cartno")
        Next

        tran.Commit()
        conn.Close()  'Sitthana 20190325
        Return True
    End Function

End Class
