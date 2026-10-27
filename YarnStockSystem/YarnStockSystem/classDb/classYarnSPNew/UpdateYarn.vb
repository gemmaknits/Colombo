Imports System.Text
Imports System.Data.SqlClient
Imports System.Data

Public Class UpdateYarn
	Private connStr As New classConnection

	Public Function UpdateYarnIn(ByVal Param_YarnIn As tbl_Yarn_in, ByVal dt_Yarn_in_det As DataTable, ByRef Msgerr As String, ByVal da As SqlDataAdapter, ByVal loginEmpcd As String) As Boolean
		Dim deletedDetRecs As New DataView(dt_Yarn_in_det, "", "", DataViewRowState.Deleted)
		Dim modifiedDetRecs As New DataView(dt_Yarn_in_det, "", "", DataViewRowState.ModifiedCurrent)
        Dim addedDetRecs As New DataView(dt_Yarn_in_det, "", "", DataViewRowState.Added)
        ''Begin Add By Sitthana 18/10/2018
        'Dim MtlWarehouseId As Integer = 0
        'Dim MtlSubinventoryId As Integer = 0
        'Dim MtlLocationsId As Integer = 0
        'If dt_Yarn_in_det.Rows.Count > 0 Then
        '    MtlWarehouseId = dt_Yarn_in_det.Rows(0)("mtl_warehouse_id")
        '    MtlSubinventoryId = dt_Yarn_in_det.Rows(0)("mtl_subinventory_id")
        '    MtlLocationsId = dt_Yarn_in_det.Rows(0)("mtl_locations_id")
        'End If
        ''End Add By Sitthana 18/10/2018

        Dim conn As New SqlConnection(connStr.Connection())
        conn.Open()

        Dim comm As New SqlCommand("", conn)
        Dim tran As SqlTransaction = conn.BeginTransaction
        comm.Transaction = tran
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "p_yarn_in_update"
        With Param_YarnIn
            comm.Parameters.AddWithValue("@docdt", CDate(.docdt))
            comm.Parameters.AddWithValue("@docno", .docno.Trim)
            comm.Parameters.AddWithValue("@purno", .purno.Trim)
            comm.Parameters.AddWithValue("@sinvno", .sinvno.Trim)
            comm.Parameters.AddWithValue("@sinvdt", .sinvdt)
            comm.Parameters.AddWithValue("@suppcd", .suppcd.Trim)
            comm.Parameters.AddWithValue("@lotno_sup", .lotno_sup.Trim)
            comm.Parameters.AddWithValue("@srefno", .srefno.Trim)
            comm.Parameters.AddWithValue("@outno", .outno.Trim)
            comm.Parameters.AddWithValue("@remark", .remark.Trim)
            comm.Parameters.AddWithValue("@log_empcd", loginEmpcd.Trim)
        End With
        Dim da2 As New SqlDataAdapter(comm)
        Dim dt As New DataTable

        Try
            da2.Fill(dt)

        Catch ex As Exception
            Msgerr = ex.Message
            tran.Rollback()
            conn.Close()  'Sitthana 20190325
            Return False
        End Try

        REM delete old record ------------------------------

        Dim i As Integer = 0

        If deletedDetRecs.Count > 0 Then
            For i = 0 To deletedDetRecs.Count - 1
                comm.Parameters.Clear()
                comm.CommandText = "p_yarn_in_det_delete"
                'comm.Transaction = tran
                comm.Parameters.AddWithValue("@docno", Param_YarnIn.docno.Trim)
                comm.Parameters.AddWithValue("@boxno", deletedDetRecs.Item(i)("boxno").ToString.Trim)
                comm.Parameters.AddWithValue("@log_empcd", loginEmpcd)
                da2 = New SqlDataAdapter(comm)
                dt = New DataTable

                Try
                    da2.Fill(dt)
                Catch ex As Exception
                    Msgerr = ex.Message
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
                comm.CommandText = "p_yarn_in_det_update"
                '			comm.Transaction = tran
                With modifiedDetRecs
                    comm.Parameters.AddWithValue("@docno", .Item(i)("docno").Trim)
                    comm.Parameters.AddWithValue("@itcd", .Item(i)("itcd").Trim)
                    comm.Parameters.AddWithValue("@boxno_s", .Item(i)("boxno_s").Trim)
                    comm.Parameters.AddWithValue("@boxno", .Item(i)("boxno").Trim)
                    comm.Parameters.AddWithValue("@spools", .Item(i)("spools").ToString)
                    comm.Parameters.AddWithValue("@grade", .Item(i)("grade").Trim)
                    comm.Parameters.AddWithValue("@kg_gr", .Item(i)("kg_gr").ToString)
                    comm.Parameters.AddWithValue("@cart_tearwt", .Item(i)("cart_tearwt").ToString)
                    comm.Parameters.AddWithValue("@spool_tearwt", .Item(i)("spool_tearwt").ToString)
                    comm.Parameters.AddWithValue("@kg_nt", .Item(i)("kg_nt").ToString)
                    comm.Parameters.AddWithValue("@actual_cone_weight", .Item(i)("actual_cone_weight").ToString)

                    comm.Parameters.AddWithValue("@id_jobdet", .Item(i)("id_jobdet").ToString)
                    'comm.Parameters.AddWithValue("@lotno_our", .Item(i)("lotno_our").ToString)
                    'comm.Parameters.AddWithValue("@log_empcd", loginEmpcd.Trim)
                End With
                da2 = New SqlDataAdapter(comm)
                dt = New DataTable

                Try
                    da2.Fill(dt)
                Catch ex As Exception
                    Msgerr = ex.Message
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
                comm.CommandText = "p_yarn_in_det_insert"
                'comm.Transaction = tran
                With addedDetRecs
                    comm.Parameters.AddWithValue("@docno", .Item(i)("docno").Trim)
                    comm.Parameters.AddWithValue("@itcd", .Item(i)("itcd").Trim)
                    comm.Parameters.AddWithValue("@boxno_s", .Item(i)("boxno_s").Trim)
                    comm.Parameters.AddWithValue("@boxno", .Item(i)("boxno").Trim)
                    comm.Parameters.AddWithValue("@spools", Val(.Item(i)("spools").ToString))
                    comm.Parameters.AddWithValue("@grade", .Item(i)("grade").Trim)
                    comm.Parameters.AddWithValue("@kg_gr", Val(.Item(i)("kg_gr").ToString))
                    comm.Parameters.AddWithValue("@cart_tearwt", Val(.Item(i)("cart_tearwt").ToString))
                    comm.Parameters.AddWithValue("@spool_tearwt", Val(.Item(i)("spool_tearwt").ToString))
                    comm.Parameters.AddWithValue("@kg_nt", Val(.Item(i)("kg_nt").ToString))
                    comm.Parameters.AddWithValue("@actual_cone_weight", .Item(i)("actual_cone_weight").ToString)
                    comm.Parameters.AddWithValue("@id_jobdet", Val(.Item(i)("id_jobdet").ToString))
                    comm.Parameters.AddWithValue("@log_empcd", loginEmpcd)
                    ''Begin Insert by Sitthana 18/10/2018
                    'comm.Parameters.AddWithValue("@mtl_warehouse_id", MtlWarehouseId)
                    'comm.Parameters.AddWithValue("@mtl_subinventory_id", MtlSubinventoryId)
                    'comm.Parameters.AddWithValue("@mtl_locations_id", MtlLocationsId)
                    ''End Insert by Sitthana 18/10/2018
                End With
                da2 = New SqlDataAdapter(comm)
                dt = New DataTable

                Try
                    da2.Fill(dt)
                Catch ex As Exception
                    Msgerr = ex.Message
                    tran.Rollback()
                    conn.Close()  'Sitthana 20190325
                    Return False
                End Try
            Next
        End If

        '=========================== Log Yarn In By Neung =====================
        With Param_YarnIn
            comm.CommandText = "log_yarn_in"
            comm.Parameters.Clear()
            comm.Parameters.AddWithValue("@empcd", loginEmpcd)
            comm.Parameters.AddWithValue("@docno", .docno)
            comm.Parameters.AddWithValue("@action", "NEW")
        End With
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

    Public Function UpdateYarnOut(ByVal param_tbl_yarn_out As tbl_Yarn_out, ByVal dt_yarn_out_det As DataTable, ByRef msgerr As String, ByVal loginEmpcd As String, ByVal refDocnoChanged As Boolean) As Boolean
        Dim deletedDetRecs As New DataView(dt_yarn_out_det, "", "", DataViewRowState.Deleted)
        Dim modifiedDetRecs As New DataView(dt_yarn_out_det, "", "", DataViewRowState.ModifiedCurrent)
        Dim addedDetRecs As New DataView(dt_yarn_out_det, "", "", DataViewRowState.Added)

        '======== This Funtions Disible By Neung =================================================
        'If deletedDetRecs.Count = 0 And modifiedDetRecs.Count = 0 And addedDetRecs.Count = 0 Then
        'msgerr = "No changes were found to update"
        'Return False
        'End If
        '=========================================================================================

        Dim conn As New SqlConnection(connStr.Connection())
        conn.Open()

        Dim comm As New SqlCommand("", conn)
        Dim tran As SqlTransaction = conn.BeginTransaction
        comm.Transaction = tran
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "p_yarn_out_update"
        With param_tbl_yarn_out
            comm.Parameters.Clear()
            comm.Parameters.AddWithValue("@outno", .outno.Trim)
            comm.Parameters.AddWithValue("@outdt", CDate(.outdt))
            'comm.Parameters.AddWithValue("@outdt", .outdt.ToString("yyyyMMdd"))
            comm.Parameters.AddWithValue("@tran_type", .tran_type.Trim)
            comm.Parameters.AddWithValue("@refdocno", .refdocno.Trim)
            comm.Parameters.AddWithValue("@suppcd", .suppcd.Trim)
            comm.Parameters.AddWithValue("@kono", .kono.Trim)
            comm.Parameters.AddWithValue("@rem", .remm.Trim)
            'comm.Parameters.AddWithValue("@log_empcd", .empcd.Trim) 'Disible By neung Dones know bug
        End With
        comm.Parameters.AddWithValue("@log_empcd", loginEmpcd)

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

        REM delete old record ------------------------------

        Dim i As Integer = 0

        If deletedDetRecs.Count > 0 Then
            For i = 0 To deletedDetRecs.Count - 1
                comm.Transaction = tran
                comm.CommandText = "p_yarn_out_det_delete"
                comm.Parameters.Clear()

                comm.Parameters.AddWithValue("@id_yarn_out_det", deletedDetRecs.Item(i)("id_yarn_out_det").ToString)
                comm.Parameters.AddWithValue("@outno", param_tbl_yarn_out.outno.Trim)
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
        End If

        REM update old record ------------------------------

        i = 0

        If modifiedDetRecs.Count > 0 Then
            For i = 0 To modifiedDetRecs.Count - 1
                comm.CommandType = CommandType.StoredProcedure
                comm.Transaction = tran
                comm.CommandText = "p_yarn_out_det_update"
                comm.Parameters.Clear()
                With modifiedDetRecs
                    comm.Parameters.AddWithValue("@outno", param_tbl_yarn_out.outno.Trim)
                    comm.Parameters.AddWithValue("@id_yarn_out_det", .Item(i)("id_yarn_out_det").ToString)
                    comm.Parameters.AddWithValue("@itcd", .Item(i)("itcd").Trim)
                    comm.Parameters.AddWithValue("@grade", .Item(i)("grade").Trim)
                    comm.Parameters.AddWithValue("@boxno", .Item(i)("boxno").Trim)
                    comm.Parameters.AddWithValue("@gb", .Item(i)("gb").Trim)
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
        End If

        REM insert new record ------------------------------

        i = 0

        If addedDetRecs.Count > 0 Then
            For i = 0 To addedDetRecs.Count - 1
                comm.CommandType = CommandType.StoredProcedure
                comm.Transaction = tran
                comm.CommandText = "p_yarn_out_det_insert"
                comm.Parameters.Clear()
                With addedDetRecs
                    comm.Parameters.AddWithValue("@outno", param_tbl_yarn_out.outno.Trim)
                    comm.Parameters.AddWithValue("@itcd", .Item(i)("itcd").Trim)
                    comm.Parameters.AddWithValue("@grade", .Item(i)("grade").Trim)
                    comm.Parameters.AddWithValue("@boxno", .Item(i)("boxno").Trim)
                    'comm.Parameters.AddWithValue("@id_job_det_yarn", ("id_job_det_yarn").ToString)
                    comm.Parameters.AddWithValue("@id_job_det_yarn", 0)

                    comm.Parameters.AddWithValue("@gb", .Item(i)("gb").Trim)
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
        End If
        tran.Commit()
        conn.Close()  'Sitthana 20190325
        Return True
    End Function

    Public Function cancelYarnin(ByVal Docno As String, ByVal loginEmpcd As String, ByRef Msgerr As String)
        Dim conn As New SqlConnection(connStr.Connection())
        conn.Open()

        Dim comm As New SqlCommand("", conn)
        Dim tran As SqlTransaction = conn.BeginTransaction
        comm.Transaction = tran
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "p_yarn_in_cancel"
        comm.Parameters.AddWithValue("@docno", Docno.Trim)
        comm.Parameters.AddWithValue("@log_empcd", loginEmpcd.Trim)
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        Try
            da.Fill(dt)
        Catch ex As Exception
            Msgerr = ex.Message
            tran.Rollback()
            conn.Close()  'Sitthana 20190325
            Return False
        End Try
        tran.Commit()
        conn.Close()  'Sitthana 20190325
        Return True
    End Function

    Public Function updateKoYarn(ByVal dv_dtc_add As DataView, ByVal dv_dtc_upd As DataView, ByVal dv_dtc_del As DataView, ByRef msgErr As String, ByVal USERID As String) As Boolean
        Dim conn As New SqlConnection(connStr.Connection())
        conn.Open()
        Dim config As New clsConfig
        Dim comm As New SqlCommand("", conn)
        Dim tran As SqlTransaction = conn.BeginTransaction
        comm.Transaction = tran
        comm.CommandType = CommandType.StoredProcedure



        Dim i As Integer
        comm.CommandText = "p_ko_yarn_update"
        For i = 0 To dv_dtc_add.Count - 1
            With dv_dtc_add
                comm.Parameters.Clear()
                comm.Parameters.AddWithValue("@kono", config.IsNull(.Item(i)("kono"), "").trim)
                comm.Parameters.AddWithValue("@itcd", config.IsNull(.Item(i)("itcd"), "").trim)
                comm.Parameters.AddWithValue("@total_scrap_qty", config.IsNull(.Item(i)("total_scrap_qty"), 0))
                comm.Parameters.AddWithValue("@logempcd", USERID)
                comm.Parameters.AddWithValue("@scrap_date", .Item(i)("scrap_date"))
                comm.Parameters.AddWithValue("@ko_yarn_id", .Item(i)("ko_yarn_id"))
                'comm.Parameters.AddWithValue("@kono", dv_dtc_add.Rows(i).Item("kono"))
                'comm.Parameters.AddWithValue("@itcd", dv_dtc_add.Rows(i).Item("itcd"))
                'comm.Parameters.AddWithValue("@total_scrap_qty", dv_dtc_add.Rows(i).Item("total_scrap_qty"))
            End With
            Dim da As New SqlDataAdapter(comm)
            Dim dt As New DataTable
            Try
                da.Fill(dt)
            Catch ex As Exception
                msgErr = ex.Message
                tran.Rollback()
                conn.Close()  'Sitthana 20190325
                Exit Function
                updateKoYarn = False
            End Try
        Next
        comm.CommandText = "p_ko_yarn_update"
        For i = 0 To dv_dtc_upd.Count - 1
            With dv_dtc_upd
                comm.Parameters.Clear()
                comm.Parameters.AddWithValue("@kono", config.IsNull(.Item(i)("kono"), "").trim)
                comm.Parameters.AddWithValue("@itcd", config.IsNull(.Item(i)("itcd"), "").trim)
                comm.Parameters.AddWithValue("@total_scrap_qty", config.IsNull(.Item(i)("total_scrap_qty"), 0))
                comm.Parameters.AddWithValue("@logempcd", USERID)
                comm.Parameters.AddWithValue("@scrap_date", .Item(i)("scrap_date"))
                comm.Parameters.AddWithValue("@ko_yarn_id", .Item(i)("ko_yarn_id"))
            End With
            Dim da As New SqlDataAdapter(comm)
            Dim dt As New DataTable
            Try
                da.Fill(dt)
            Catch ex As Exception
                msgErr = ex.Message
                tran.Rollback()
                conn.Close()  'Sitthana 20190325
                Exit Function
                updateKoYarn = False
            End Try
        Next
        comm.CommandText = "p_ko_yarn_delete"
        For i = 0 To dv_dtc_del.Count - 1
            With dv_dtc_del
                comm.Parameters.Clear()
                comm.Parameters.AddWithValue("@kono", config.IsNull(.Item(i)("kono"), "").trim)
                comm.Parameters.AddWithValue("@itcd", config.IsNull(.Item(i)("itcd"), "").trim)
                comm.Parameters.AddWithValue("@total_scrap_qty", config.IsNull(.Item(i)("total_scrap_qty"), 0))
                comm.Parameters.AddWithValue("@logempcd", USERID)
                comm.Parameters.AddWithValue("@scrap_date", .Item(i)("scrap_date"))
                comm.Parameters.AddWithValue("@ko_yarn_id", .Item(i)("ko_yarn_id"))
            End With
            Dim da As New SqlDataAdapter(comm)
            Dim dt As New DataTable
            Try
                da.Fill(dt)
            Catch ex As Exception
                msgErr = ex.Message
                tran.Rollback()
                conn.Close()  'Sitthana 20190325
                Exit Function
                updateKoYarn = False
            End Try
        Next
        tran.Commit()
        conn.Close()  'Sitthana 20190325
        msgErr = "Scrap data saved successfully.."
        updateKoYarn = True
    End Function

    Public Function CloseJob(ByVal dt As DataTable, ByRef msgerr As String) As Boolean
        Dim conn As New SqlConnection((New classConnection).Connection)
        Dim comm As New SqlCommand("", conn)
        conn.Open()
        Dim tran As SqlTransaction = conn.BeginTransaction
        Dim i As Integer = 0
        comm.Transaction = tran
        comm.CommandType = Data.CommandType.StoredProcedure
        comm.CommandText = "p_po_closing_update"
        For i = 0 To dt.Rows.Count - 1
            Try
                comm.Parameters.Clear()
                comm.Parameters.AddWithValue("@id_jobdet", dt.Rows(i)("id_jobdet"))
                comm.Parameters.AddWithValue("@closed", CBool(dt.Rows(i)("closed")))
                comm.ExecuteNonQuery()
            Catch ex As Exception
                msgerr = ex.Message
                tran.Rollback()
                conn.Close()  'Sitthana 20190325
                Return False
            End Try
        Next

        tran.Commit()
        conn.Close()  'Sitthana 20190325
        comm.Dispose()
        If conn.State = ConnectionState.Open Then conn.Close()
        conn.Dispose()
        Return True
    End Function

    Public Function UpdateYarnIN2(ByVal dtYIN As DataTable, ByVal loginEmpcd As String, ByRef docno As String) As Boolean

        Dim deletedDetRecs As New DataView(dtYIN, "", "", DataViewRowState.Deleted)
        Dim modifiedDetRecs As New DataView(dtYIN, "", "", DataViewRowState.ModifiedCurrent)
        Dim addedDetRecs As New DataView(dtYIN, "", "", DataViewRowState.Added)

        Dim clsConfig As New clsConfig
        Dim conn As New SqlConnection(connStr.Connection())
        conn.Open()

        Dim comm As New SqlCommand("", conn)
        Dim tran As SqlTransaction = conn.BeginTransaction
        comm.Transaction = tran
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "p_yarn_in_update3"

        comm.Parameters.AddWithValue("@docno", clsConfig.IsNull(dtYIN.Rows(0)("docno"), ""))
        comm.Parameters.AddWithValue("@docdt", clsConfig.IsNull(dtYIN.Rows(0)("docdt2"), "19000101"))
        comm.Parameters.AddWithValue("@purno", clsConfig.IsNull(dtYIN.Rows(0)("purno"), ""))
        comm.Parameters.AddWithValue("@sinvno", clsConfig.IsNull(dtYIN.Rows(0)("sinvno"), ""))
        comm.Parameters.AddWithValue("@sinvdt", clsConfig.IsNull(dtYIN.Rows(0)("sinvdt"), ""))
        comm.Parameters.AddWithValue("@suppcd", clsConfig.IsNull(dtYIN.Rows(0)("suppcd"), ""))
        comm.Parameters.AddWithValue("@lotno_sup", clsConfig.IsNull(dtYIN.Rows(0)("lotno_sup"), ""))
        comm.Parameters.AddWithValue("@srefno", clsConfig.IsNull(dtYIN.Rows(0)("srefno"), ""))
        comm.Parameters.AddWithValue("@tran_type", clsConfig.IsNull(dtYIN.Rows(0)("tran_type"), ""))
        comm.Parameters.AddWithValue("@remark", clsConfig.IsNull(dtYIN.Rows(0)("remark"), ""))
        comm.Parameters.AddWithValue("@itcd", clsConfig.IsNull(dtYIN.Rows(0)("itcd"), ""))
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
                comm.CommandText = "p_yarn_in_det_delete"

                comm.Parameters.AddWithValue("@docno", clsConfig.IsNull(dt.Rows(0)("docno"), ""))
                comm.Parameters.AddWithValue("@boxno", deletedDetRecs.Item(i)("boxno").ToString.Trim)
                comm.Parameters.AddWithValue("@log_empcd", loginEmpcd.Trim)
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
            Next
        End If

        REM update old record ------------------------------

        i = 0

        If modifiedDetRecs.Count > 0 Then
            For i = 0 To modifiedDetRecs.Count - 1
                comm.CommandText = "p_yarn_in_det_update3"

                With modifiedDetRecs
                    comm.Parameters.Clear()
                    comm.Parameters.AddWithValue("@docno", docno)
                    comm.Parameters.AddWithValue("@itcd", clsConfig.IsNull(.Item(i)("itcd"), "").Trim)
                    comm.Parameters.AddWithValue("@boxno_s", clsConfig.IsNull(.Item(i)("boxno_s"), "").Trim)
                    comm.Parameters.AddWithValue("@boxno", clsConfig.IsNull(.Item(i)("boxno"), "").Trim)
                    comm.Parameters.AddWithValue("@spools", clsConfig.IsNull(.Item(i)("spools"), 0).ToString)
                    comm.Parameters.AddWithValue("@grade", clsConfig.IsNull(.Item(i)("grade"), "").Trim)
                    comm.Parameters.AddWithValue("@kg_gr", clsConfig.IsNull(.Item(i)("kg_gr"), 0).ToString)
                    comm.Parameters.AddWithValue("@cart_tearwt", clsConfig.IsNull(.Item(i)("cart_tearwt"), 0).ToString)
                    comm.Parameters.AddWithValue("@spool_tearwt", clsConfig.IsNull(.Item(i)("spool_tearwt"), 0).ToString)
                    comm.Parameters.AddWithValue("@kg_nt", clsConfig.IsNull(.Item(i)("kg_nt"), 0).ToString)
                    comm.Parameters.AddWithValue("@actual_cone_weight", clsConfig.IsNull(.Item(i)("actual_cone_weight"), 0).ToString)
                    comm.Parameters.AddWithValue("@location", clsConfig.IsNull(.Item(i)("loc"), 0).ToString)
                    comm.Parameters.AddWithValue("@id_jobdet", clsConfig.IsNull(.Item(i)("id_jobdet"), 0).ToString)
                    comm.Parameters.AddWithValue("@box_remark", clsConfig.IsNull(.Item(i)("box_remark"), "").ToString)
                    comm.Parameters.AddWithValue("@mtl_warehouse_id", .Item(i)("mtl_warehouse_id"))
                    comm.Parameters.AddWithValue("@mtl_subinventory_id", .Item(i)("mtl_subinventory_id"))
                    comm.Parameters.AddWithValue("@mtl_locations_id", .Item(i)("mtl_locations_id"))
                    comm.Parameters.AddWithValue("@login_empcd", loginEmpcd.Trim)
                End With
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
            Next
        End If

        REM insert new record ------------------------------

        i = 0

        If addedDetRecs.Count > 0 Then
            For i = 0 To addedDetRecs.Count - 1
                comm.CommandText = "p_yarn_in_det_update3"

                With addedDetRecs
                    comm.Parameters.Clear()
                    comm.Parameters.AddWithValue("@docno", docno)
                    comm.Parameters.AddWithValue("@itcd", clsConfig.IsNull(.Item(i)("itcd"), "").Trim)
                    comm.Parameters.AddWithValue("@boxno_s", clsConfig.IsNull(.Item(i)("boxno_s"), "").Trim)
                    comm.Parameters.AddWithValue("@boxno", clsConfig.IsNull(.Item(i)("boxno"), "").Trim)
                    comm.Parameters.AddWithValue("@spools", clsConfig.IsNull(.Item(i)("spools"), 0).ToString)
                    comm.Parameters.AddWithValue("@grade", clsConfig.IsNull(.Item(i)("grade"), "").Trim)
                    comm.Parameters.AddWithValue("@kg_gr", clsConfig.IsNull(.Item(i)("kg_gr"), 0).ToString)
                    comm.Parameters.AddWithValue("@cart_tearwt", clsConfig.IsNull(.Item(i)("cart_tearwt"), 0).ToString)
                    comm.Parameters.AddWithValue("@spool_tearwt", clsConfig.IsNull(.Item(i)("spool_tearwt"), 0).ToString)
                    comm.Parameters.AddWithValue("@kg_nt", clsConfig.IsNull(.Item(i)("kg_nt"), 0).ToString)
                    comm.Parameters.AddWithValue("@actual_cone_weight", clsConfig.IsNull(.Item(i)("actual_cone_weight"), 0).ToString)
                    comm.Parameters.AddWithValue("@location", clsConfig.IsNull(.Item(i)("loc"), "").ToString)
                    comm.Parameters.AddWithValue("@id_jobdet", clsConfig.IsNull(.Item(i)("id_jobdet"), 0).ToString)
                    comm.Parameters.AddWithValue("@box_remark", clsConfig.IsNull(.Item(i)("box_remark"), "").ToString)
                    comm.Parameters.AddWithValue("@mtl_warehouse_id", .Item(i)("mtl_warehouse_id"))
                    comm.Parameters.AddWithValue("@mtl_subinventory_id", .Item(i)("mtl_subinventory_id"))
                    comm.Parameters.AddWithValue("@mtl_locations_id", .Item(i)("mtl_locations_id"))
                    comm.Parameters.AddWithValue("@login_empcd", loginEmpcd.Trim)
                End With
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

    Public Function YarnLocationSave(ByVal dv_add As DataView, ByVal dv_del As DataView, ByRef msgerr As String, ByVal log_empcd As String, ByRef strLogNo As String) As Boolean
        Dim conn As New SqlConnection((New classConnection).Connection)
        Dim comm As New SqlCommand("", conn)
        conn.Open()
        Dim tran As SqlTransaction = conn.BeginTransaction
        Dim i As Integer = 0
        comm.Transaction = tran
        comm.CommandType = Data.CommandType.StoredProcedure
        comm.CommandText = "p_yarn_location_log_update"
        'Dim strLogNo As String = ""
        Dim da As New SqlDataAdapter()
        Dim dt2 As New DataTable
        For i = 0 To dv_add.Count - 1
            comm.Parameters.Clear()
            comm.Parameters.AddWithValue("@logno", strLogNo)
            comm.Parameters.AddWithValue("@boxno", dv_add(i)("boxno"))
            comm.Parameters.AddWithValue("@location", dv_add(i)("loc"))
            comm.Parameters.AddWithValue("@log_empcd", log_empcd)
            da = New SqlDataAdapter(comm)
            Try
                da.Fill(dt2)
            Catch ex As Exception
                msgerr = ex.Message
                tran.Rollback()
                conn.Close()  'Sitthana 20190325
                Return False
            End Try
            strLogNo = dt2.Rows(0)("logno").ToString()
        Next

        comm.CommandText = "p_yarn_location_log_del"
        For i = 0 To dv_del.Count - 1
            comm.Parameters.Clear()
            comm.Parameters.AddWithValue("@p_yarn_location_log_delete", dv_del(i)("id_yarn_location"))
            Try
                comm.ExecuteNonQuery()
            Catch ex As Exception
                msgerr = ex.Message
                tran.Rollback()
                conn.Close()  'Sitthana 20190325
                Return False
            End Try
        Next

        tran.Commit()
        comm.Dispose()
        If conn.State = ConnectionState.Open Then conn.Close()
        conn.Dispose()
        Return True
    End Function

    Public Function YarnLocationSaveHeader(ByRef strLogNo As String, ByVal strLocationTo As String, ByVal strActualMoveDate As String, ByVal strReceiveDate As String) As Boolean
        Dim conn As New SqlConnection((New classConnection).Connection)
        Dim comm As New SqlCommand("", conn)
        conn.Open()
        Dim tran As SqlTransaction = conn.BeginTransaction
        Dim i As Integer = 0
        comm.Transaction = tran
        comm.CommandType = Data.CommandType.StoredProcedure
        comm.CommandText = "p_yarn_location_log_header_update"
        comm.Parameters.AddWithValue("@logno", strLogNo)
        comm.Parameters.AddWithValue("@location_to", strLocationTo)
        comm.Parameters.AddWithValue("@actual_move_date", strActualMoveDate)
        comm.Parameters.AddWithValue("@receive_date", strReceiveDate)

        Try
            Call comm.ExecuteNonQuery()
        Catch ex As Exception
            tran.Rollback()
            conn.Close()  'Sitthana 20190325
            Return False
        End Try

        tran.Commit()
        conn.Close()  'Sitthana 20190325
        comm.Dispose()
        If conn.State = ConnectionState.Open Then conn.Close()
        conn.Dispose()
        Return True
    End Function
End Class
