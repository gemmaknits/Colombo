Imports System.Data
Imports System.Data.SqlClient
Imports System.Text

Public Class classRequest
    Public Structure ReqHeader
        Dim h01_outreqno As String
        Dim h02_outreqdt As String
        Dim h03_outreqtyp As String
        Dim h04_post As String
        Dim h05_type As String
        Dim h06_qtypack As Double
        Dim h07_uom As String
        Dim h08_size1 As Boolean
        Dim h09_size2 As Boolean
        Dim h10_Mtype1 As Boolean
        Dim h11_Mtype2 As Boolean
        Dim h12_logo1 As Boolean
        Dim h13_logo2 As Boolean
        Dim h14_remark As String
        Dim h15_cuscd As String
        Dim h16_sono As String
        Dim h17_verno As String
        Dim h18_release_date As String
        Dim h19_empcd As String
        Dim h20_stock_type As String
        Dim h21_cancel_status As Boolean
    End Structure

    Public Function GetReqDOnhandDesign() As DataTable
        Dim conn As New SqlConnection((New classConnection).connection)
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "p_req_d_onhand_design"
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        conn.Close()  'Sitthana 20190325
        Return dt
    End Function

    Public Function GetReqDOnhand(Optional ByVal strDesignNo As String = "") As DataTable
        Dim conn As New SqlConnection((New classConnection).connection)
        Dim comm As New SqlCommand("", conn)
        comm.CommandTimeout = 60 * 60 * 30
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "p_req_d_onhand"
        comm.Parameters.AddWithValue("@design_no", strDesignNo.Trim)
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        conn.Close()  'Sitthana 20190325
        Return dt
    End Function

    Public Function GetReqCOnhandDesign() As DataTable
        Dim conn As New SqlConnection((New classConnection).connection)
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "p_req_c_onhand_design"
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        conn.Close()  'Sitthana 20190325
        Return dt
    End Function

    Public Function GetReqCOnhand(Optional ByVal strDesignNo As String = "") As DataTable
        Dim conn As New SqlConnection((New classConnection).connection)
        Dim comm As New SqlCommand("", conn)
        comm.CommandTimeout = 60 * 60 * 30
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "p_req_c_onhand"
        comm.Parameters.AddWithValue("@design_no", strDesignNo.Trim)
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        conn.Close()  'Sitthana 20190325
        Return dt
    End Function

    Public Function GetReqGOnhandDesign() As DataTable
        Dim conn As New SqlConnection((New classConnection).connection)
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "p_req_g_onhand_design"
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        conn.Close()  'Sitthana 20190325
        Return dt
    End Function

    Public Function GetReqGOnhand(Optional ByVal strDesignNo As String = "") As DataTable
        Dim conn As New SqlConnection((New classConnection).connection)
        Dim comm As New SqlCommand("", conn)
        comm.CommandTimeout = 60 * 60 * 30
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "p_req_g_onhand"
        comm.Parameters.AddWithValue("@design_no", strDesignNo.Trim)
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        conn.Close()  'Sitthana 20190325
        Return dt
    End Function

    Public Function GetReqSOnhandDesign() As DataTable
        Dim conn As New SqlConnection((New classConnection).connection)
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "p_req_s_onhand_design"
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        conn.Close()  'Sitthana 20190325
        Return dt
    End Function

    Public Function GetReqSOnhand(Optional ByVal strDesignNo As String = "") As DataTable
        Dim conn As New SqlConnection((New classConnection).connection)
        Dim comm As New SqlCommand("", conn)
        comm.CommandTimeout = 60 * 60 * 30
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "p_req_s_onhand"
        comm.Parameters.AddWithValue("@design_no", strDesignNo.Trim)
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        conn.Close()  'Sitthana 20190325
        Return dt
    End Function

    Public Function ReqDGetSODesignGrid(Optional ByVal strSoNo As String = "", Optional ByVal strDesignNo As String = "") As DataTable
        Dim conn As New SqlConnection((New classConnection).connection)
        Dim comm As New SqlCommand("", conn)
        comm.CommandTimeout = 60 * 60 * 30
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "P_REQ_D_PKG_get_so_designs"
        comm.Parameters.Clear()
        comm.Parameters.AddWithValue("@sono", strSoNo.Trim)
        comm.Parameters.AddWithValue("@design_no", strDesignNo.Trim)
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        conn.Close()  'Sitthana 20190325
        Return dt
    End Function

    Public Function ReqGGetSODesignGrid(Optional ByVal strSoNo As String = "", Optional ByVal strDesignNo As String = "") As DataTable
        Dim conn As New SqlConnection((New classConnection).connection)
        Dim comm As New SqlCommand("", conn)
        comm.CommandTimeout = 60 * 60 * 30
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "P_REQ_G_PKG_get_so_designs"
        comm.Parameters.AddWithValue("@sono", strSoNo.Trim)
        comm.Parameters.AddWithValue("@design_no", strDesignNo.Trim)
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        conn.Close()  'Sitthana 20190325
        Return dt
    End Function

    Public Function GetSODesignGrid2(Optional ByVal strSoNo As String = "", Optional ByVal strDesignNo As String = "") As DataTable
        Dim conn As New SqlConnection((New classConnection).connection)
        Dim comm As New SqlCommand("", conn)
        comm.CommandTimeout = 60 * 60 * 30
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "p_so_designs_grid3"
        comm.Parameters.AddWithValue("@sono", strSoNo.Trim)
        comm.Parameters.AddWithValue("@design_no", strDesignNo.Trim)
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        conn.Close()  'Sitthana 20190325
        Return dt
    End Function

    Public Function GetSODesignGrid3(Optional ByVal strSoNo As String = "", Optional ByVal strDesignNo As String = "") As DataTable
        Dim conn As New SqlConnection((New classConnection).connection)
        Dim comm As New SqlCommand("", conn)
        comm.CommandTimeout = 60 * 60 * 30
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "p_so_designs_grid4"
        comm.Parameters.AddWithValue("@sono", strSoNo.Trim)
        comm.Parameters.AddWithValue("@design_no", strDesignNo.Trim)
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        conn.Close()  'Sitthana 20190325
        Return dt
    End Function

    Public Function GetSODesignGrid4(Optional ByVal strSoNo As String = "", Optional ByVal strDesignNo As String = "") As DataTable
        Dim conn As New SqlConnection((New classConnection).connection)
        Dim comm As New SqlCommand("", conn)
        comm.CommandTimeout = 60 * 60 * 30
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "p_so_designs_grid5"
        comm.Parameters.Clear()
        comm.Parameters.AddWithValue("@sono", strSoNo.Trim)
        comm.Parameters.AddWithValue("@design_no", strDesignNo.Trim)
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        conn.Close()  'Sitthana 20190325
        Return dt
    End Function

    Public Function GetSORollNoGrid(Optional ByVal strDFNo As String = "", Optional ByVal strSoNoID As String = "", Optional ByVal strDesignNo As String = "", Optional ByVal strGwth As String = "", Optional ByVal strCol As String = "", Optional ByVal strGr As String = "", Optional ByVal pStockType As String = "D") As DataTable
        Dim conn As New SqlConnection((New ClassConnection).connection)
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "P_REQ_D_PKG_get_stk"
        comm.Parameters.Clear()
        comm.Parameters.AddWithValue("@outreqno", strDFNo.Trim)
        comm.Parameters.AddWithValue("@sonoid", strSoNoID.Trim)
        comm.Parameters.AddWithValue("@design_no", strDesignNo.Trim)
        comm.Parameters.AddWithValue("@gwth", strGwth.Trim)
        comm.Parameters.AddWithValue("@col", strCol.Trim)
        comm.Parameters.AddWithValue("@gr", strGr.Trim)
        comm.Parameters.AddWithValue("@stock_type", pStockType.Trim)
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        conn.Close()  'Sitthana 20190325
        Return dt
    End Function

    Public Function GetSORollNoGrid2(Optional ByVal strDFNo As String = "", Optional ByVal strSoNoID As String = "", Optional ByVal strDesignNo As String = "", Optional ByVal strGwth As String = "", Optional ByVal strCol As String = "", Optional ByVal strGr As String = "") As DataTable
        Dim conn As New SqlConnection((New classConnection).connection)
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "p_req_det_dc_c_onhand3"
        comm.Parameters.AddWithValue("@outreqno", strDFNo.Trim)
        comm.Parameters.AddWithValue("@sonoid", strSoNoID.Trim)
        comm.Parameters.AddWithValue("@design_no", strDesignNo.Trim)
        comm.Parameters.AddWithValue("@gwth", strGwth.Trim)
        comm.Parameters.AddWithValue("@col", strCol.Trim)
        comm.Parameters.AddWithValue("@gr", strGr.Trim)
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        conn.Close()  'Sitthana 20190325
        Return dt
    End Function

    Public Function ReqGGetSTK(Optional ByVal strDFNo As String = "", Optional ByVal strSoNoID As String = "", Optional ByVal strDesignNo As String = "", Optional ByVal strGwth As String = "", Optional ByVal strCol As String = "", Optional ByVal strGr As String = "") As DataTable
        Dim conn As New SqlConnection((New classConnection).connection)
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "P_REQ_G_PKG_get_stk"
        comm.Parameters.AddWithValue("@outreqno", strDFNo.Trim)
        comm.Parameters.AddWithValue("@sonoid", strSoNoID.Trim)
        comm.Parameters.AddWithValue("@design_no", strDesignNo.Trim)
        comm.Parameters.AddWithValue("@gwth", strGwth.Trim)
        comm.Parameters.AddWithValue("@col", strCol.Trim)
        comm.Parameters.AddWithValue("@gr", strGr.Trim)
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        conn.Close()  'Sitthana 20190325
        Return dt
    End Function

    Public Function GetSORollNoGrid4(Optional ByVal strDFNo As String = "", Optional ByVal strSoNoID As String = "", Optional ByVal strDesignNo As String = "", Optional ByVal strGwth As String = "", Optional ByVal strCol As String = "", Optional ByVal strGr As String = "") As DataTable
        Dim conn As New SqlConnection((New classConnection).connection)
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "p_req_det_dc_s_onhand3"
        comm.Parameters.AddWithValue("@outreqno", strDFNo.Trim)
        comm.Parameters.AddWithValue("@sonoid", strSoNoID.Trim)
        comm.Parameters.AddWithValue("@design_no", strDesignNo.Trim)
        comm.Parameters.AddWithValue("@gwth", strGwth.Trim)
        comm.Parameters.AddWithValue("@col", strCol.Trim)
        comm.Parameters.AddWithValue("@gr", strGr.Trim)
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        conn.Close()  'Sitthana 20190325
        Return dt
    End Function

    Public Function GetRollNoG(Optional ByVal strReqNo As String = "", Optional ByVal strSoNoID As String = "", Optional ByVal strBarcode As String = "") As DataTable
        Dim conn As New SqlConnection((New classConnection).connection)
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "p_req_det_dc_g_onhand4"
        comm.Parameters.AddWithValue("@outreqno", strReqNo.Trim)
        comm.Parameters.AddWithValue("@sonoid", strSoNoID.Trim)
        comm.Parameters.AddWithValue("@barcode", strBarcode.Trim)
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        conn.Close()  'Sitthana 20190325
        Return dt
    End Function

    Public Function GetRollNoD(Optional ByVal strReqNo As String = "", Optional ByVal strSoNoID As String = "", Optional ByVal strBarcode As String = "") As DataTable
        Dim conn As New SqlConnection((New classConnection).connection)
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "p_req_det_dc_d_onhand4"
        comm.Parameters.AddWithValue("@outreqno", strReqNo.Trim)
        comm.Parameters.AddWithValue("@sonoid", strSoNoID.Trim)
        comm.Parameters.AddWithValue("@barcode", strBarcode.Trim)
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        conn.Close()  'Sitthana 20190325
        Return dt
    End Function

    Public Function GetReqNo(Optional ByVal strStockType As String = "A", Optional ByVal strReqNo As String = "", Optional ByVal strDateFr As String = "", Optional ByVal strDateTo As String = "", Optional ByVal strCustCD As String = "") As DataTable
        Dim conn As New SqlConnection((New classConnection).connection)
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "p_req_select5"
        comm.Parameters.AddWithValue("@stock_type", strStockType.Trim)
        comm.Parameters.AddWithValue("@outreqno", strReqNo)
        comm.Parameters.AddWithValue("@datefr", strDateFr)
        comm.Parameters.AddWithValue("@dateto", strDateTo)
        comm.Parameters.AddWithValue("@custcd", strCustCD)
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        conn.Close()  'Sitthana 20190325
        Return dt
    End Function

    Public Function CheckDocType(ByVal strDocType As String) As String
        Dim conn As New SqlConnection((New classConnection).connection)
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "p_check_doctype"
        comm.Parameters.AddWithValue("@doctyp", strDocType.Trim)
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        conn.Close()  'Sitthana 20190325
        Return dt.Rows(0)(0).ToString
    End Function

    Public Function ReqDetDCLoad(ByVal strReqNo As String) As DataTable
        Dim conn As New SqlConnection((New classConnection).connection)
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure
        'comm.CommandText = "p_req_det_dc_select3"
        comm.CommandText = "P_REQ_D_PKG_get_req_det_dc"
        comm.Parameters.AddWithValue("@outreqno", strReqNo)
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        conn.Close()  'Sitthana 20190325
        Return dt
    End Function

    Public Function getPackNoByReqNo(ByVal strReqNo As String) As DataTable
        Dim conn As New SqlConnection((New classConnection).connection)
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure
        'comm.CommandText = "p_req_det_dc_select3"
        comm.CommandText = "p_packing_list_d_get_packno"
        comm.Parameters.Clear()
        comm.Parameters.AddWithValue("@pOutReqNo", strReqNo)
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        conn.Close()
        Return dt
    End Function

    Public Function getPackNoByGReqNo(ByVal strReqNo As String) As DataTable
        Dim conn As New SqlConnection((New classConnection).connection)
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure
        'comm.CommandText = "p_req_det_dc_select3"
        comm.CommandText = "p_packing_list_g_get_packno"
        comm.Parameters.Clear()
        comm.Parameters.AddWithValue("@pOutReqNo", strReqNo)
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        conn.Close()
        Return dt
    End Function

    Public Function ReqDCSave(ByVal REQH As ReqHeader, ByVal REQD_ADD As DataView, ByVal REQD_UPD As DataView, ByVal REQD_DEL As DataView, ByRef msgerr As String, ByRef reqno As String) As Boolean
        Dim config As New clsConfig
        Dim conn As New SqlConnection((New classConnection).connection)
        conn.Open()
        Dim tran As SqlTransaction = conn.BeginTransaction
        Dim comm As New SqlCommand("", conn)
        Dim i As Integer = 0
        comm.Transaction = tran
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "p_req_d_update2"
        With REQH
            comm.Parameters.Clear()
            comm.Parameters.AddWithValue("@outreqno", .h01_outreqno.Trim)
            comm.Parameters.AddWithValue("@outreqdt", .h02_outreqdt)
            comm.Parameters.AddWithValue("@outreqtyp", .h03_outreqtyp.Trim)
            comm.Parameters.AddWithValue("@post", .h04_post.Trim)
            comm.Parameters.AddWithValue("@type", .h05_type.Trim)
            comm.Parameters.AddWithValue("@qtypack", .h06_qtypack)
            comm.Parameters.AddWithValue("@uom", .h07_uom.Trim)
            comm.Parameters.AddWithValue("@size1", IIf(.h08_size1, 1, 0))
            comm.Parameters.AddWithValue("@size2", IIf(.h09_size2, 1, 0))
            comm.Parameters.AddWithValue("@Mtype1", IIf(.h10_Mtype1, 1, 0))
            comm.Parameters.AddWithValue("@Mtype2", IIf(.h11_Mtype2, 1, 0))
            comm.Parameters.AddWithValue("@logo1", IIf(.h12_logo1, 1, 0))
            comm.Parameters.AddWithValue("@logo2", IIf(.h13_logo2, 1, 0))
            comm.Parameters.AddWithValue("@remark", .h14_remark.Trim)
            comm.Parameters.AddWithValue("@cuscd", .h15_cuscd.Trim)
            comm.Parameters.AddWithValue("@sono", .h16_sono.Trim)
            comm.Parameters.AddWithValue("@verno", .h17_verno.Trim)
            comm.Parameters.AddWithValue("@release_date", .h18_release_date.Trim)
            comm.Parameters.AddWithValue("@empcd", .h19_empcd.Trim)
            comm.Parameters.AddWithValue("@stock_type", .h20_stock_type.Trim)
        End With

        'Dim xxx As String = config.BuildSQL(comm)
        'xxx = xxx

        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        Try
            da.Fill(dt)
        Catch ex As Exception
            msgerr = ex.Message
            tran.Rollback()
            conn.Close()  'Sitthana 20190325
            Return False
        End Try
        reqno = dt.Rows(0)("outreqno").ToString

        'Add Detail----------

        i = 0
        comm.CommandText = "p_req_det_dc_update2"

        For i = 0 To REQD_ADD.Count - 1
            With REQD_ADD
                comm.Parameters.Clear()
                comm.Parameters.AddWithValue("@outreqno", reqno)
                comm.Parameters.AddWithValue("@design_no", config.IsNull(.Item(i)("design_no"), "").Trim)
                comm.Parameters.AddWithValue("@subcod", config.IsNull(.Item(i)("subcod"), "").Trim)
                comm.Parameters.AddWithValue("@lot", config.IsNull(.Item(i)("lot"), "").Trim)
                comm.Parameters.AddWithValue("@yr", config.IsNull(.Item(i)("yr"), "").Trim)
                comm.Parameters.AddWithValue("@sh", config.IsNull(.Item(i)("sh"), "").Trim)
                comm.Parameters.AddWithValue("@col", config.IsNull(.Item(i)("col"), "").Trim)
                comm.Parameters.AddWithValue("@gr", config.IsNull(.Item(i)("gr"), "").Trim)
                comm.Parameters.AddWithValue("@sonoid", config.IsNull(.Item(i)("sonoid"), "").Trim)
                comm.Parameters.AddWithValue("@roll_no", config.IsNull(.Item(i)("roll_no"), "").Trim)
                comm.Parameters.AddWithValue("@kg", config.IsNull(.Item(i)("k"), 0).ToString)
                comm.Parameters.AddWithValue("@mts", config.IsNull(.Item(i)("m"), 0).ToString)
                comm.Parameters.AddWithValue("@yds", config.IsNull(.Item(i)("y"), 0).ToString)
                comm.Parameters.AddWithValue("@gwth", config.IsNull(.Item(i)("gwth"), "").Trim)
                comm.Parameters.AddWithValue("@n_yds", config.IsNull(.Item(i)("n_yds"), 0).ToString)
                comm.Parameters.AddWithValue("@pack", config.IsNull(.Item(i)("pack"), 0).ToString.Trim)
                comm.Parameters.AddWithValue("@batch", config.IsNull(.Item(i)("batch"), "").Trim)
                comm.Parameters.AddWithValue("@uom", config.IsNull(.Item(i)("uom"), "").Trim)
                comm.Parameters.AddWithValue("@custcolor", config.IsNull(.Item(i)("custcolor"), "").Trim)
                comm.Parameters.AddWithValue("@id_req_det_dc", 0)
                comm.Parameters.AddWithValue("@stock_type", REQH.h20_stock_type)
            End With
            Dim sql As String = config.BuildSQL(comm)
            da = New SqlDataAdapter(comm)
            dt = New DataTable
            Try
                da.Fill(dt)
            Catch ex As Exception
                msgerr = ex.Message
                tran.Rollback()
                conn.Close()  'Sitthana 20190325
                Return False
            End Try
        Next

        'Update Detail----------

        i = 0
        comm.CommandText = "p_req_det_dc_update2"

        For i = 0 To REQD_UPD.Count - 1
            With REQD_UPD
                comm.Parameters.Clear()
                comm.Parameters.AddWithValue("@outreqno", reqno)
                comm.Parameters.AddWithValue("@design_no", config.IsNull(.Item(i)("design_no"), "").Trim)
                comm.Parameters.AddWithValue("@subcod", config.IsNull(.Item(i)("subcod"), "").Trim)
                comm.Parameters.AddWithValue("@lot", config.IsNull(.Item(i)("lot"), "").Trim)
                comm.Parameters.AddWithValue("@yr", config.IsNull(.Item(i)("yr"), "").Trim)
                comm.Parameters.AddWithValue("@sh", config.IsNull(.Item(i)("sh"), "").Trim)
                comm.Parameters.AddWithValue("@col", config.IsNull(.Item(i)("col"), "").Trim)
                comm.Parameters.AddWithValue("@gr", config.IsNull(.Item(i)("gr"), "").Trim)
                comm.Parameters.AddWithValue("@sonoid", config.IsNull(.Item(i)("sonoid"), "").Trim)
                comm.Parameters.AddWithValue("@roll_no", config.IsNull(.Item(i)("roll_no"), "").Trim)
                comm.Parameters.AddWithValue("@kg", config.IsNull(.Item(i)("k"), 0).ToString)
                comm.Parameters.AddWithValue("@mts", config.IsNull(.Item(i)("m"), 0).ToString)
                comm.Parameters.AddWithValue("@yds", config.IsNull(.Item(i)("y"), 0).ToString)
                comm.Parameters.AddWithValue("@gwth", config.IsNull(.Item(i)("gwth"), "").Trim)
                comm.Parameters.AddWithValue("@n_yds", config.IsNull(.Item(i)("n_yds"), 0).ToString)
                comm.Parameters.AddWithValue("@pack", config.IsNull(.Item(i)("pack"), "").ToString.Trim)
                comm.Parameters.AddWithValue("@batch", config.IsNull(.Item(i)("batch"), "").Trim)
                comm.Parameters.AddWithValue("@uom", config.IsNull(.Item(i)("uom"), "").Trim)
                comm.Parameters.AddWithValue("@custcolor", config.IsNull(.Item(i)("custcolor"), "").Trim)
                comm.Parameters.AddWithValue("@id_req_det_dc", config.IsNull(.Item(i)("id_req_det"), 0))
                comm.Parameters.AddWithValue("@stock_type", REQH.h20_stock_type)
            End With
            da = New SqlDataAdapter(comm)
            dt = New DataTable
            Try
                da.Fill(dt)
            Catch ex As Exception
                msgerr = ex.Message
                tran.Rollback()
                conn.Close()  'Sitthana 20190325
                Return False
            End Try
        Next

        'Delete Detail----------

        i = 0
        comm.CommandText = "p_req_det_dc_delete2"

        For i = 0 To REQD_DEL.Count - 1
            With REQD_DEL(i)
                comm.Parameters.Clear()
                comm.Parameters.AddWithValue("@id_req_det_dc", config.IsNull(.Item("id_req_det"), "").ToString.Trim)
                comm.Parameters.AddWithValue("@log_empcd", REQH.h19_empcd)
            End With
            da = New SqlDataAdapter(comm)
            dt = New DataTable
            Try
                da.Fill(dt)
            Catch ex As Exception
                msgerr = ex.Message
                tran.Rollback()
                conn.Close()  'Sitthana 20190325
                Return False
            End Try
        Next

        tran.Commit()
        conn.Close()  'Sitthana 20190325
        Return True
    End Function

    Public Function ReqDetGLoad(ByVal strReqNo As String) As DataTable
        Dim conn As New SqlConnection((New classConnection).connection)
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "P_REQ_G_PKG_get_req_det_g"
        comm.Parameters.AddWithValue("@outreqno", strReqNo)
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        conn.Close()  'Sitthana 20190325
        Return dt
    End Function

    Public Function ReqGSave(ByVal REQH As ReqHeader, ByVal REQG_ADD As DataView, ByVal REQG_UPD As DataView, ByVal REQG_DEL As DataView, ByRef msgerr As String, ByRef reqno As String) As Boolean
        Dim config As New clsConfig
        Dim conn As New SqlConnection((New classConnection).connection)
        conn.Open()
        Dim tran As SqlTransaction = conn.BeginTransaction
        Dim comm As New SqlCommand("", conn)
        Dim i As Integer = 0
        comm.Transaction = tran
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "p_req_g_update2"
        With REQH
            comm.Parameters.AddWithValue("@outreqno", .h01_outreqno.Trim)
            comm.Parameters.AddWithValue("@outreqdt", .h02_outreqdt)
            comm.Parameters.AddWithValue("@outreqtyp", .h03_outreqtyp.Trim)
            comm.Parameters.AddWithValue("@post", .h04_post.Trim)
            comm.Parameters.AddWithValue("@type", .h05_type.Trim)
            comm.Parameters.AddWithValue("@qtypack", .h06_qtypack)
            comm.Parameters.AddWithValue("@uom", .h07_uom.Trim)
            comm.Parameters.AddWithValue("@size1", IIf(.h08_size1, 1, 0))
            comm.Parameters.AddWithValue("@size2", IIf(.h09_size2, 1, 0))
            comm.Parameters.AddWithValue("@Mtype1", IIf(.h10_Mtype1, 1, 0))
            comm.Parameters.AddWithValue("@Mtype2", IIf(.h11_Mtype2, 1, 0))
            comm.Parameters.AddWithValue("@logo1", IIf(.h12_logo1, 1, 0))
            comm.Parameters.AddWithValue("@logo2", IIf(.h13_logo2, 1, 0))
            comm.Parameters.AddWithValue("@remark", .h14_remark.Trim)
            comm.Parameters.AddWithValue("@cuscd", .h15_cuscd.Trim)
            comm.Parameters.AddWithValue("@sono", .h16_sono.Trim)
            comm.Parameters.AddWithValue("@verno", .h17_verno.Trim)
            comm.Parameters.AddWithValue("@release_date", .h18_release_date.Trim)
            comm.Parameters.AddWithValue("@empcd", .h19_empcd.Trim)
            comm.Parameters.AddWithValue("@stock_type", .h20_stock_type.Trim)
        End With

        'Dim xxx As String = config.BuildSQL(comm)
        'xxx = xxx

        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        Try
            da.Fill(dt)
        Catch ex As Exception
            msgerr = ex.Message
            tran.Rollback()
            conn.Close()  'Sitthana 20190325
            Return False
        End Try
        reqno = dt.Rows(0)("outreqno").ToString

        'Add Detail----------

        i = 0
        comm.CommandText = "p_req_det_g_update2"

        For i = 0 To REQG_ADD.Count - 1
            With REQG_ADD
                comm.Parameters.Clear()
                comm.Parameters.AddWithValue("@outreqno", reqno)
                comm.Parameters.AddWithValue("@design_no", config.IsNull(.Item(i)("design_no"), "").Trim)
                comm.Parameters.AddWithValue("@gwth", config.IsNull(.Item(i)("gwth"), "").Trim)
                comm.Parameters.AddWithValue("@roll_no", config.IsNull(.Item(i)("roll_no"), "").Trim)
                comm.Parameters.AddWithValue("@sonoid", config.IsNull(.Item(i)("sonoid"), "").Trim)
                comm.Parameters.AddWithValue("@kg", config.IsNull(.Item(i)("k"), 0).ToString)
                comm.Parameters.AddWithValue("@yds", config.IsNull(.Item(i)("y"), 0).ToString)
                comm.Parameters.AddWithValue("@mts", config.IsNull(.Item(i)("m"), 0).ToString)
                comm.Parameters.AddWithValue("@id_req_det_g", 0)
                comm.Parameters.AddWithValue("@log_empcd", REQH.h19_empcd)
            End With
            Dim sql As String = config.BuildSQL(comm)
            da = New SqlDataAdapter(comm)
            dt = New DataTable
            Try
                da.Fill(dt)
            Catch ex As Exception
                msgerr = ex.Message
                tran.Rollback()
                conn.Close()  'Sitthana 20190325
                Return False
            End Try
        Next

        'Update Detail----------

        i = 0
        comm.CommandText = "p_req_det_g_update2"

        For i = 0 To REQG_UPD.Count - 1
            With REQG_UPD
                comm.Parameters.Clear()
                comm.Parameters.AddWithValue("@outreqno", reqno)
                comm.Parameters.AddWithValue("@design_no", config.IsNull(.Item(i)("design_no"), "").Trim)
                comm.Parameters.AddWithValue("@gwth", config.IsNull(.Item(i)("gwth"), "").Trim)
                comm.Parameters.AddWithValue("@roll_no", config.IsNull(.Item(i)("roll_no"), "").Trim)
                comm.Parameters.AddWithValue("@sonoid", config.IsNull(.Item(i)("sonoid"), "").Trim)
                comm.Parameters.AddWithValue("@kg", config.IsNull(.Item(i)("k"), 0).ToString)
                comm.Parameters.AddWithValue("@yds", config.IsNull(.Item(i)("y"), 0).ToString)
                comm.Parameters.AddWithValue("@mts", config.IsNull(.Item(i)("m"), 0).ToString)
                comm.Parameters.AddWithValue("@id_req_det_g", config.IsNull(.Item(i)("id_req_det"), 0))
                comm.Parameters.AddWithValue("@log_empcd", REQH.h19_empcd)
            End With
            da = New SqlDataAdapter(comm)
            dt = New DataTable
            Try
                da.Fill(dt)
            Catch ex As Exception
                msgerr = ex.Message
                tran.Rollback()
                conn.Close()  'Sitthana 20190325
                Return False
            End Try
        Next

        'Delete Detail----------

        i = 0
        comm.CommandText = "p_req_det_g_delete2"

        For i = 0 To REQG_DEL.Count - 1
            With REQG_DEL(i)
                comm.Parameters.Clear()
                comm.Parameters.AddWithValue("@id_req_det_g", config.IsNull(.Item("id_req_det"), "").ToString.Trim)
                comm.Parameters.AddWithValue("@log_empcd", REQH.h19_empcd)
            End With
            da = New SqlDataAdapter(comm)
            dt = New DataTable
            Try
                da.Fill(dt)
            Catch ex As Exception
                msgerr = ex.Message
                tran.Rollback()
                conn.Close()  'Sitthana 20190325
                Return False
            End Try
        Next

        tran.Commit()
        conn.Close()  'Sitthana 20190325
        Return True
    End Function

    Public Function ReqCancel(ByVal strReqNo As String, ByVal strEmpCD As String) As Boolean
        Dim strOutNo As String = GetOutNo(strReqNo)
        If strOutNo <> "" Then
            MessageBox.Show("This document is already made OUT Document No. " & strOutNo & vbCrLf & "Can't cancel", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
            Return False
        End If
        Dim conn As New SqlConnection((New classConnection).connection)
        conn.Open()
        Dim tran As SqlTransaction = conn.BeginTransaction
        Dim comm As New SqlCommand("", conn)
        comm.Transaction = tran
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "p_req_cancel"
        comm.Parameters.AddWithValue("@outreqno", strReqNo)
        comm.Parameters.AddWithValue("@log_empcd", strEmpCD)
        If comm.ExecuteNonQuery() = -1 Then
            tran.Commit()
            conn.Close()  'Sitthana 20190325
            Return True
        Else
            tran.Rollback()
            conn.Close()  'Sitthana 20190325
            Return False
        End If
    End Function

    Private Function GetOutNo(ByVal strReqNo As String) As String
        Dim conn As New SqlConnection((New classConnection).connection)
        conn.Open()
        Dim tran As SqlTransaction = conn.BeginTransaction
        Dim comm As New SqlCommand("", conn)
        comm.Transaction = tran
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "p_req_check_gout"
        comm.Parameters.AddWithValue("@outreqno", strReqNo)
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        conn.Close()  'Sitthana 20190325
        Return dt.Rows(0)(0)
    End Function
End Class
