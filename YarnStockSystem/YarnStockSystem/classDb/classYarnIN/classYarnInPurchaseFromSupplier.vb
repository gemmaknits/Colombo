Imports System.Data
Imports System.Data.SqlClient
Imports System.Text
Public Class classYarnInPurchaseFromSupplier
    Public Structure YarnINHeader

        'Greige
        Dim h01DocNo As String
        Dim h02DocDt2 As String
        Dim pPurNo As String
        Dim pSinvNo As String
        Dim psinvdt As String
        Dim pSuppCd As String
        'comm.Parameters.AddWithValue("@docno", clsConfig.IsNull(dt.Rows(0)("docno"), ""))
        'comm.Parameters.AddWithValue("@docdt", clsConfig.IsNull(dt.Rows(0)("docdt2"), "19000101"))
        'comm.Parameters.AddWithValue("@purno", clsConfig.IsNull(dt.Rows(0)("purno"), ""))
        'comm.Parameters.AddWithValue("@sinvno", clsConfig.IsNull(dt.Rows(0)("sinvno"), ""))
        'comm.Parameters.AddWithValue("@sinvdt", clsConfig.IsNull(dt.Rows(0)("sinvdt"), ""))
        'comm.Parameters.AddWithValue("@suppcd", clsConfig.IsNull(dt.Rows(0)("suppcd"), ""))
        'comm.Parameters.AddWithValue("@lotno_sup", clsConfig.IsNull(dt.Rows(0)("lotno_sup"), ""))
        'comm.Parameters.AddWithValue("@lotno_our", clsConfig.IsNull(dt.Rows(0)("lotno_our"), ""))
        'comm.Parameters.AddWithValue("@srefno", clsConfig.IsNull(dt.Rows(0)("srefno"), ""))
        'comm.Parameters.AddWithValue("@tran_type", clsConfig.IsNull(dt.Rows(0)("tran_type"), ""))
        'comm.Parameters.AddWithValue("@remark", clsConfig.IsNull(dt.Rows(0)("remark"), ""))
        'comm.Parameters.AddWithValue("@log_empcd", loginEmpcd.Trim)
    End Structure

    Public Function GetDataYarnOutFromSupplier(Optional ByVal StrOutNo As String = "") As DataTable
        Dim conn As New SqlConnection((New classConnection).Connection)
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "P_YARN_IN_PURCHASE_FROM_SUPPLIER_PKG_get_yarn_out_by_outno"
        comm.Parameters.AddWithValue("@outno", StrOutNo)
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        comm.Connection.Close()
        Try
            da.Fill(dt)
            conn.Close()  'Sitthana 20190325
        Catch ex As Exception
            conn.Close()  'Sitthana 20190325
            MessageBox.Show(ex.Message, ex.GetType().ToString())
        End Try
        Return dt

    End Function

    Public Function GetDataYarnIn(ByVal Param_YarninCode As String, ByRef Msgerr As String) As DataTable
        Dim conn As New SqlConnection((New classConnection).Connection())
        Dim comm As New SqlCommand("", conn)
        comm.CommandTimeout = 600
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "P_YARN_IN_PURCHASE_FROM_SUPPLIER_PKG_get_yarn_in_by_docno"
        comm.Parameters.AddWithValue("@docno", Param_YarninCode.Trim)
        Dim da As New SqlDataAdapter(comm)
        Dim ds As New DataSet

        Try
            da.Fill(ds, "TblDataYarnIn")
            conn.Close()  'Sitthana 20190325
        Catch ex As Exception
            conn.Close()  'Sitthana 20190325
            Msgerr = ex.Message
        End Try

        Return ds.Tables("TblDataYarnIn")
    End Function

    Public Function UpdateYarnIN2(ByVal dtYarn As DataTable, ByVal loginEmpcd As String, ByRef docno As String, ByRef StrMessage As String) As Boolean
        Dim deletedDetRecs As New DataView(dtYarn, "", "", DataViewRowState.Deleted)
        Dim modifiedDetRecs As New DataView(dtYarn, "", "", DataViewRowState.ModifiedCurrent)
        Dim addedDetRecs As New DataView(dtYarn, "", "", DataViewRowState.Added)

        Dim clsConfig As New clsConfig
        Dim conn As New SqlConnection((New classConnection).Connection())
        conn.Open()

        Dim comm As New SqlCommand("", conn)
        Dim tran As SqlTransaction = conn.BeginTransaction
        comm.Transaction = tran
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "P_YARN_IN_PURCHASE_FROM_SUPPLIER_PKG_update_yarn_in"

        comm.Parameters.AddWithValue("@docno", clsConfig.IsNull(dtYarn.Rows(0)("docno"), ""))
        comm.Parameters.AddWithValue("@docdt", clsConfig.IsNull(dtYarn.Rows(0)("docdt2"), "19000101"))
        comm.Parameters.AddWithValue("@purno", clsConfig.IsNull(dtYarn.Rows(0)("purno"), ""))
        comm.Parameters.AddWithValue("@sinvno", clsConfig.IsNull(dtYarn.Rows(0)("sinvno"), ""))
        comm.Parameters.AddWithValue("@sinvdt", clsConfig.IsNull(dtYarn.Rows(0)("sinvdt"), ""))
        comm.Parameters.AddWithValue("@suppcd", clsConfig.IsNull(dtYarn.Rows(0)("suppcd"), ""))
        comm.Parameters.AddWithValue("@lotno_sup", clsConfig.IsNull(dtYarn.Rows(0)("lotno_sup"), ""))
        comm.Parameters.AddWithValue("@lotno_our", clsConfig.IsNull(dtYarn.Rows(0)("lotno_our"), ""))
        comm.Parameters.AddWithValue("@srefno", clsConfig.IsNull(dtYarn.Rows(0)("srefno"), ""))
        comm.Parameters.AddWithValue("@tran_type", clsConfig.IsNull(dtYarn.Rows(0)("tran_type"), ""))
        comm.Parameters.AddWithValue("@remark", clsConfig.IsNull(dtYarn.Rows(0)("remark"), ""))
        comm.Parameters.AddWithValue("@log_empcd", loginEmpcd.Trim)

        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable

        Try
            da.Fill(dt)
            docno = dt.Rows(0)("docno").ToString
            'MessageBox.Show(docno)
        Catch ex As Exception
            StrMessage = ex.Message
            tran.Rollback()
            conn.Close()  'Sitthana 20190325
            Return False
        End Try

        REM delete old record ------------------------------

        Dim i As Integer = 0

        If deletedDetRecs.Count > 0 Then
            For i = 0 To deletedDetRecs.Count - 1
                comm.Parameters.Clear()
                comm.CommandText = "P_YARN_IN_PURCHASE_FROM_SUPPLIER_PKG_delete_yarn_in_det"

                comm.Parameters.AddWithValue("@docno", docno)
                comm.Parameters.AddWithValue("@boxno", deletedDetRecs.Item(i)("boxno").ToString.Trim)
                comm.Parameters.AddWithValue("@log_empcd", loginEmpcd.Trim)
                da = New SqlDataAdapter(comm)
                dt = New DataTable

                Try
                    da.Fill(dt)
                Catch ex As Exception
                    StrMessage = ex.Message
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
                comm.CommandText = "P_YARN_IN_PURCHASE_FROM_SUPPLIER_PKG_update_yarn_in_det"

                With modifiedDetRecs
                    comm.Parameters.AddWithValue("@docno", docno)
                    comm.Parameters.AddWithValue("@itcd", clsConfig.IsNull(.Item(i)("itcd"), "").Trim)
                    comm.Parameters.AddWithValue("@boxno_s", clsConfig.IsNull(.Item(i)("boxno_s"), "").Trim)
                    comm.Parameters.AddWithValue("@boxno", clsConfig.IsNull(.Item(i)("boxno"), "").Trim)
                    comm.Parameters.AddWithValue("@spools", clsConfig.IsNull(.Item(i)("spools"), 0).ToString)
                    comm.Parameters.AddWithValue("@grade", clsConfig.IsNull(.Item(i)("grade"), "").Trim)
                    comm.Parameters.AddWithValue("@grade_our", clsConfig.IsNull(.Item(i)("grade_our"), "").Trim)
                    comm.Parameters.AddWithValue("@kg_gr", clsConfig.IsNull(.Item(i)("kg_gr"), 0).ToString)
                    comm.Parameters.AddWithValue("@cart_tearwt", clsConfig.IsNull(.Item(i)("cart_tearwt"), 0).ToString)
                    comm.Parameters.AddWithValue("@spool_tearwt", clsConfig.IsNull(.Item(i)("spool_tearwt"), 0).ToString)
                    comm.Parameters.AddWithValue("@kg_nt", clsConfig.IsNull(.Item(i)("kg_nt"), 0).ToString)
                    comm.Parameters.AddWithValue("@actual_cone_weight", clsConfig.IsValidDouble(.Item(i)("kg_nt")) / clsConfig.IsValidDouble(.Item(i)("spools")))
                    comm.Parameters.AddWithValue("@location", clsConfig.IsNull(.Item(i)("loc"), ""))
                    comm.Parameters.AddWithValue("@mtl_warehouse_id", clsConfig.IsNull(.Item(i)("mtl_warehouse_id"), DBNull.Value))
                    comm.Parameters.AddWithValue("@mtl_subinventory_id", clsConfig.IsNull(.Item(i)("mtl_subinventory_id"), DBNull.Value))
                    comm.Parameters.AddWithValue("@mtl_locations_id", clsConfig.IsNull(.Item(i)("mtl_locations_id"), DBNull.Value))
                    comm.Parameters.AddWithValue("@id_jobdet", clsConfig.IsNull(.Item(i)("id_jobdet"), 0).ToString)
                    comm.Parameters.AddWithValue("@box_remark", clsConfig.IsNull(.Item(i)("box_remark"), 0).ToString)
                    comm.Parameters.AddWithValue("@interface_yarn_out_det_id", .Item(i)("interface_yarn_out_det_id"))
                    comm.Parameters.AddWithValue("@interface_yarn_outno", .Item(i)("interface_yarn_outno"))
                    comm.Parameters.AddWithValue("@lotno_sup", .Item(i)("lotno_sup"))
                    comm.Parameters.AddWithValue("@lotno_our", .Item(i)("lotno_our"))
                    comm.Parameters.AddWithValue("@login_empcd", loginEmpcd.Trim)
                End With
                da = New SqlDataAdapter(comm)
                dt = New DataTable

                Try
                    da.Fill(dt)
                Catch ex As Exception
                    StrMessage = ex.Message
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
                comm.CommandText = "P_YARN_IN_PURCHASE_FROM_SUPPLIER_PKG_update_yarn_in_det"

                With addedDetRecs
                    comm.Parameters.AddWithValue("@docno", docno)
                    comm.Parameters.AddWithValue("@itcd", clsConfig.IsNull(.Item(i)("itcd"), "").Trim)
                    comm.Parameters.AddWithValue("@boxno_s", clsConfig.IsNull(.Item(i)("boxno_s"), "").Trim)
                    comm.Parameters.AddWithValue("@boxno", clsConfig.IsNull(.Item(i)("boxno"), "").Trim)
                    comm.Parameters.AddWithValue("@spools", clsConfig.IsNull(.Item(i)("spools"), 0).ToString)
                    comm.Parameters.AddWithValue("@grade", clsConfig.IsNull(.Item(i)("grade"), "").Trim)
                    comm.Parameters.AddWithValue("@grade_our", clsConfig.IsNull(.Item(i)("grade_our"), "").Trim)
                    comm.Parameters.AddWithValue("@kg_gr", clsConfig.IsNull(.Item(i)("kg_gr"), 0).ToString)
                    comm.Parameters.AddWithValue("@cart_tearwt", clsConfig.IsNull(.Item(i)("cart_tearwt"), 0).ToString)
                    comm.Parameters.AddWithValue("@spool_tearwt", clsConfig.IsNull(.Item(i)("spool_tearwt"), 0).ToString)
                    comm.Parameters.AddWithValue("@kg_nt", clsConfig.IsNull(.Item(i)("kg_nt"), 0).ToString)
                    comm.Parameters.AddWithValue("@actual_cone_weight", clsConfig.IsValidDouble(.Item(i)("kg_nt")) / clsConfig.IsValidDouble(.Item(i)("spools")))
                    comm.Parameters.AddWithValue("@location", clsConfig.IsNull(.Item(i)("loc"), "").ToString)
                    comm.Parameters.AddWithValue("@mtl_locations_id", clsConfig.IsNull(.Item(i)("mtl_locations_id"), DBNull.Value))
                    comm.Parameters.AddWithValue("@mtl_subinventory_id", clsConfig.IsNull(.Item(i)("mtl_subinventory_id"), DBNull.Value))
                    comm.Parameters.AddWithValue("@mtl_warehouse_id", clsConfig.IsNull(.Item(i)("mtl_warehouse_id"), DBNull.Value))
                    comm.Parameters.AddWithValue("@id_jobdet", clsConfig.IsNull(.Item(i)("id_jobdet"), 0).ToString)
                    comm.Parameters.AddWithValue("@box_remark", clsConfig.IsNull(.Item(i)("box_remark"), 0).ToString)
                    comm.Parameters.AddWithValue("@interface_yarn_out_det_id", .Item(i)("interface_yarn_out_det_id"))
                    comm.Parameters.AddWithValue("@interface_yarn_outno", .Item(i)("interface_yarn_outno"))
                    comm.Parameters.AddWithValue("@lotno_sup", .Item(i)("lotno_sup"))
                    comm.Parameters.AddWithValue("@lotno_our", .Item(i)("lotno_our"))
                    comm.Parameters.AddWithValue("@login_empcd", loginEmpcd.Trim)
                End With
                da = New SqlDataAdapter(comm)
                dt = New DataTable

                Try
                    da.Fill(dt)
                Catch ex As Exception
                    StrMessage = ex.Message
                    tran.Rollback()
                    conn.Close()  'Sitthana 20190325
                    Return False
                End Try
            Next
        End If

        '=========================== Log Yarn In By Neung =====================
        comm.CommandText = "log_yarn_in"
        comm.Parameters.Clear()
        comm.Parameters.AddWithValue("@empcd", loginEmpcd)
        comm.Parameters.AddWithValue("@docno", docno)
        comm.Parameters.AddWithValue("@action", "NEW")
        da = New SqlDataAdapter(comm)
        dt = New DataTable
        Try
            da.Fill(dt)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "System Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
            tran.Rollback()
            conn.Close()  'Sitthana 20190325
            Return False
        End Try
        '=========================================================================

        tran.Commit()
        conn.Close()  'Sitthana 20190325
        Return True
    End Function

End Class
