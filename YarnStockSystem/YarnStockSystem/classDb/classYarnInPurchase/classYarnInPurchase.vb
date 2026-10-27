Imports System.Data
Imports System.Data.SqlClient
Imports System.Text
Public Class classYarnInPurchase
    Dim dt As DataTable
    Dim oConn As New classConnection
    Dim oConfig As New clsConfig

    Public Function selectJobDetRecord(ByVal jobno As String) As DataTable
        Dim conn As New SqlConnection((New classConnection).Connection)
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "P_YARN_IN_PURCHASE_FORM_PKG_select_job_det_record"
        comm.Parameters.Clear()
        comm.Parameters.AddWithValue("@jobno", jobno)
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable

        da.Fill(dt)
        conn.Close()  'Sitthana 20190325
        Return dt
    End Function

    Public Function selectQtyMisMatchReasonLookUpList() As DataTable
        Dim conn As New SqlConnection((New classConnection).Connection)
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "P_YARN_IN_PURCHASE_FORM_PKG_select_qty_mismatch_reason_lookup_list"
        comm.Parameters.Clear()
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        conn.Close()
        Return dt
    End Function

    Public Function selectYarnInDetRecord(ByVal Param_YarninCode As String, ByRef Msgerr As String) As DataTable
        Dim conn As New SqlConnection((New classConnection).Connection)
        Dim comm As New SqlCommand("", conn)
        comm.CommandTimeout = 600
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "P_YARN_IN_PURCHASE_FORM_PKG_select_yarn_in_det_record"
        comm.Parameters.Clear()
        comm.Parameters.AddWithValue("@docno", Param_YarninCode.Trim)
        Dim da As New SqlDataAdapter(comm)
        Dim ds As New DataSet
        Dim dt As New DataTable
        Try
            da.Fill(dt)
            ' da.Fill(ds, "TblDataYarnIn")
        Catch ex As Exception
            conn.Close()  'Sitthana 20190325
            Msgerr = ex.Message
        End Try

        conn.Close()  'Sitthana 20190325
        '  Return ds.Tables("TblDataYarnIn")
        Return dt
    End Function
    Public Function updateYarnInPurchase(ByVal dtYarnInDet As DataTable, ByVal loginEmpcd As String, ByRef docno As String) As Boolean
        Dim deletedDetRecs As New DataView(dtYarnInDet, "", "", DataViewRowState.Deleted)
        Dim modifiedDetRecs As New DataView(dtYarnInDet, "", "", DataViewRowState.ModifiedCurrent)
        Dim addedDetRecs As New DataView(dtYarnInDet, "", "", DataViewRowState.Added)


        Dim conn As New SqlConnection(oConn.Connection())
        conn.Open()

        Dim comm As New SqlCommand("", conn)
        Dim tran As SqlTransaction = conn.BeginTransaction
        comm.Transaction = tran
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "P_YARN_IN_PURCHASE_FORM_PKG_update_yarn_in_record"
        comm.Parameters.Clear()
        comm.Parameters.AddWithValue("@docno", oConfig.IsNull(dtYarnInDet.Rows(0)("docno"), ""))
        comm.Parameters.AddWithValue("@docdt", oConfig.IsNull(dtYarnInDet.Rows(0)("docdt2"), "19000101"))
        comm.Parameters.AddWithValue("@purno", oConfig.IsNull(dtYarnInDet.Rows(0)("purno"), ""))
        comm.Parameters.AddWithValue("@sinvno", oConfig.IsNull(dtYarnInDet.Rows(0)("sinvno"), ""))
        comm.Parameters.AddWithValue("@sinvdt", oConfig.IsNull(dtYarnInDet.Rows(0)("sinvdt"), ""))
        comm.Parameters.AddWithValue("@suppcd", oConfig.IsNull(dtYarnInDet.Rows(0)("suppcd"), ""))
        comm.Parameters.AddWithValue("@lotno_sup", oConfig.IsNull(dtYarnInDet.Rows(0)("lotno_sup"), ""))
        comm.Parameters.AddWithValue("@srefno", oConfig.IsNull(dtYarnInDet.Rows(0)("srefno"), ""))
        comm.Parameters.AddWithValue("@tran_type", oConfig.IsNull(dtYarnInDet.Rows(0)("tran_type"), ""))
        comm.Parameters.AddWithValue("@remark", oConfig.IsNull(dtYarnInDet.Rows(0)("remark"), ""))
        comm.Parameters.AddWithValue("@itcd", oConfig.IsNull(dtYarnInDet.Rows(0)("itcd"), "")) 'Add By Neung For Gen Lot No Our
        comm.Parameters.AddWithValue("@p_qty_mismatch_reason_id", oConfig.IsNull(dtYarnInDet.Rows(0)("qty_mismatch_reason_id"), DBNull.Value))
        comm.Parameters.AddWithValue("@log_empcd", loginEmpcd.Trim)

        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable

        Try
            da.Fill(dt)
            docno = dt.Rows(0)("docno").ToString
            'MessageBox.Show(docno)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "System Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
            tran.Rollback()
            conn.Close()  'Sitthana 20190325
            Return False
        End Try

        REM delete old record ------------------------------

        Dim i As Integer = 0

        If deletedDetRecs.Count > 0 Then
            For i = 0 To deletedDetRecs.Count - 1
                comm.Parameters.Clear()
                comm.CommandText = "P_YARN_IN_PURCHASE_FORM_PKG_delete_yarn_in_det_record"
                comm.Parameters.Clear()
                comm.Parameters.AddWithValue("@docno", oConfig.IsNull(dtYarnInDet.Rows(0)("docno"), ""))
                comm.Parameters.AddWithValue("@boxno", deletedDetRecs.Item(i)("boxno").ToString.Trim)
                comm.Parameters.AddWithValue("@log_empcd", loginEmpcd.Trim)
                da = New SqlDataAdapter(comm)
                dt = New DataTable

                Try
                    da.Fill(dtYarnInDet)
                Catch ex As Exception
                    MessageBox.Show(ex.Message, "System Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    tran.Rollback()
                    conn.Close()  'Sitthana 20190325
                    Return False
                End Try
            Next
        End If

        REM update old record ------------------------------

        i = 0

        If modifiedDetRecs.Count > 0 Then
            For i = 0 To modifiedDetRecs.Count - 1
                comm.Parameters.Clear()
                comm.CommandText = "P_YARN_IN_PURCHASE_FORM_PKG_update_yarn_in_det_record"

                With modifiedDetRecs
                    comm.Parameters.Clear()
                    comm.Parameters.AddWithValue("@docno", docno)
                    comm.Parameters.AddWithValue("@itcd", oConfig.IsNull(.Item(i)("itcd"), "").Trim)
                    comm.Parameters.AddWithValue("@boxno_s", oConfig.IsNull(.Item(i)("boxno_s"), "").Trim)
                    comm.Parameters.AddWithValue("@boxno", oConfig.IsNull(.Item(i)("boxno"), "").Trim)
                    comm.Parameters.AddWithValue("@spools", oConfig.IsNull(.Item(i)("spools"), 0).ToString)
                    comm.Parameters.AddWithValue("@grade", oConfig.IsNull(.Item(i)("grade"), "").Trim)
                    comm.Parameters.AddWithValue("@grade_our", oConfig.IsNull(.Item(i)("grade_our"), "").Trim)
                    comm.Parameters.AddWithValue("@kg_gr", oConfig.IsNull(.Item(i)("kg_gr"), 0).ToString)
                    comm.Parameters.AddWithValue("@cart_tearwt", oConfig.IsNull(.Item(i)("cart_tearwt"), 0).ToString)
                    comm.Parameters.AddWithValue("@spool_tearwt", oConfig.IsNull(.Item(i)("spool_tearwt"), 0).ToString)
                    comm.Parameters.AddWithValue("@kg_nt", oConfig.IsNull(.Item(i)("kg_nt"), 0).ToString)
                    comm.Parameters.AddWithValue("@actual_cone_weight", oConfig.IsValidDouble(.Item(i)("kg_nt")) / oConfig.IsValidDouble(.Item(i)("spools")))
                    comm.Parameters.AddWithValue("@location", oConfig.IsNull(.Item(i)("loc"), ""))
                    comm.Parameters.AddWithValue("@mtl_warehouse_id", oConfig.IsNull(.Item(i)("mtl_warehouse_id"), DBNull.Value))
                    comm.Parameters.AddWithValue("@mtl_subinventory_id", oConfig.IsNull(.Item(i)("mtl_subinventory_id"), DBNull.Value))
                    comm.Parameters.AddWithValue("@mtl_locations_id", oConfig.IsNull(.Item(i)("mtl_locations_id"), DBNull.Value))
                    comm.Parameters.AddWithValue("@id_jobdet", oConfig.IsNull(.Item(i)("id_jobdet"), 0).ToString)
                    comm.Parameters.AddWithValue("@job_line_id", oConfig.IsNull(.Item(i)("job_line_id"), DBNull.Value))
                    comm.Parameters.AddWithValue("@box_remark", oConfig.IsNull(.Item(i)("box_remark"), 0).ToString)
                    comm.Parameters.AddWithValue("@login_empcd", loginEmpcd.Trim)
                    ' comm.Parameters.AddWithValue("@pLotOriginDate", oConfig.IsNull(.Item(i)("lot_origin_date"), "19000101")) 'Sitthana 20240924
                    ' comm.Parameters.AddWithValue("@pLotExpiryDate", oConfig.IsNull(.Item(i)("lot_expiry_date"), "19000101")) 'Sitthana 20240924
                End With
                da = New SqlDataAdapter(comm)
                dt = New DataTable

                Try
                    da.Fill(dtYarnInDet)
                Catch ex As Exception
                    MessageBox.Show(ex.Message, "System Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    tran.Rollback()
                    conn.Close()  'Sitthana 20190325
                    Return False
                End Try
            Next
        End If

        REM insert new record ------------------------------

        i = 0

        If addedDetRecs.Count > 0 Then
            For i = 0 To addedDetRecs.Count - 1
                comm.Parameters.Clear()
                comm.CommandText = "P_YARN_IN_PURCHASE_FORM_PKG_update_yarn_in_det_record"

                With addedDetRecs
                    comm.Parameters.Clear()
                    comm.Parameters.AddWithValue("@docno", docno)
                    comm.Parameters.AddWithValue("@itcd", oConfig.IsNull(.Item(i)("itcd"), "").Trim)
                    comm.Parameters.AddWithValue("@boxno_s", oConfig.IsNull(.Item(i)("boxno_s"), "").Trim)
                    comm.Parameters.AddWithValue("@boxno", oConfig.IsNull(.Item(i)("boxno"), "").Trim)
                    comm.Parameters.AddWithValue("@spools", oConfig.IsNull(.Item(i)("spools"), 0).ToString)
                    comm.Parameters.AddWithValue("@grade", oConfig.IsNull(.Item(i)("grade"), "").Trim)
                    comm.Parameters.AddWithValue("@grade_our", oConfig.IsNull(.Item(i)("grade_our"), "").Trim)
                    comm.Parameters.AddWithValue("@kg_gr", oConfig.IsNull(.Item(i)("kg_gr"), 0).ToString)
                    comm.Parameters.AddWithValue("@cart_tearwt", oConfig.IsNull(.Item(i)("cart_tearwt"), 0).ToString)
                    comm.Parameters.AddWithValue("@spool_tearwt", oConfig.IsNull(.Item(i)("spool_tearwt"), 0).ToString)
                    comm.Parameters.AddWithValue("@kg_nt", oConfig.IsNull(.Item(i)("kg_nt"), 0).ToString)
                    comm.Parameters.AddWithValue("@actual_cone_weight", oConfig.IsValidDouble(.Item(i)("kg_nt")) / oConfig.IsValidDouble(.Item(i)("spools")))
                    comm.Parameters.AddWithValue("@location", oConfig.IsNull(.Item(i)("loc"), "").ToString)
                    comm.Parameters.AddWithValue("@mtl_locations_id", oConfig.IsNull(.Item(i)("mtl_locations_id"), DBNull.Value))
                    comm.Parameters.AddWithValue("@mtl_subinventory_id", oConfig.IsNull(.Item(i)("mtl_subinventory_id"), DBNull.Value))
                    comm.Parameters.AddWithValue("@mtl_warehouse_id", oConfig.IsNull(.Item(i)("mtl_warehouse_id"), DBNull.Value))
                    comm.Parameters.AddWithValue("@id_jobdet", oConfig.IsNull(.Item(i)("id_jobdet"), 0).ToString)
                    comm.Parameters.AddWithValue("@job_line_id", oConfig.IsNull(.Item(i)("job_line_id"), DBNull.Value))
                    comm.Parameters.AddWithValue("@box_remark", oConfig.IsNull(.Item(i)("box_remark"), 0).ToString)
                    comm.Parameters.AddWithValue("@login_empcd", loginEmpcd.Trim)
                    '  comm.Parameters.AddWithValue("@pLotOriginDate", oConfig.IsNull(.Item(i)("lot_origin_date"), "19000101")) 'Sitthana 20240924
                    ' comm.Parameters.AddWithValue("@pLotExpiryDate", oConfig.IsNull(.Item(i)("lot_expiry_date"), "19000101")) 'Sitthana 20240924 '@p_qty_mismatch_reason_id
                    'Sitthana 20240924 '@p_qty_mismatch_reason_id
                End With
                da = New SqlDataAdapter(comm)
                dt = New DataTable

                Try
                    da.Fill(dtYarnInDet)
                Catch ex As Exception
                    MessageBox.Show(ex.Message, "System Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    tran.Rollback()
                    conn.Close()  'Sitthana 20190325
                    Return False
                End Try
            Next
        End If

        comm.Transaction = tran
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "P_YARN_IN_PURCHASE_FORM_PKG_send_email_alert"
        comm.Parameters.Clear()
        comm.Parameters.AddWithValue("@p_docno", docno)
        comm.Parameters.AddWithValue("@p_logempcd", loginEmpcd.Trim)
        da = New SqlDataAdapter(comm)
        dt = New DataTable

        Try
            da.Fill(dtYarnInDet)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "System Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
            tran.Rollback()
            conn.Close()  'Sitthana 20190325
            Return False
        End Try

        tran.Commit()
        conn.Close()  'Sitthana 20190325
        Return True
    End Function
    Public Function selectMtlwarehouseList() As DataTable
        Dim conn As New SqlConnection((New classConnection).Connection)
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "P_YARN_IN_PURCHASE_FORM_PKG_select_mtl_warehouse_list"
        comm.Parameters.Clear()
        ' comm.Parameters.AddWithValue("@logempcd", strUSerID)
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        conn.Close()  'Sitthana 20190325
        Return dt

    End Function

    Public Function ComboMtlsubinventory(Optional ByVal INt64mtl_warehouse_id As Nullable(Of Int64) = Nothing) As DataTable
        Dim conn As New SqlConnection((New classConnection).Connection)
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "p_yarn_in_return_pkg_combo_mtl_subinventory"
        comm.Parameters.Clear()
        comm.Parameters.AddWithValue("@mtl_warehouse_id", INt64mtl_warehouse_id)
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        conn.Close()  'Sitthana 20190325
        Return dt

    End Function

    Public Function Combomtllocations(Optional ByVal strUSerID As String = "", Optional ByVal INt64mtl_warehouse_id As Int64 = Nothing, Optional ByVal Int64mtl_subinventory_id As Int64 = Nothing) As DataTable
        Dim classconection As New classConnection
        Dim conn As New SqlConnection(classconection.Connection)
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "p_yarn_in_return_pkg_combo_mtl_locations"
        comm.Parameters.Clear()
        comm.Parameters.AddWithValue("@mtl_warehouse_id", INt64mtl_warehouse_id)
        comm.Parameters.AddWithValue("@mtl_subinventory_id", Int64mtl_subinventory_id)
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        conn.Close()  'Sitthana 20190325
        Return dt

    End Function
End Class

