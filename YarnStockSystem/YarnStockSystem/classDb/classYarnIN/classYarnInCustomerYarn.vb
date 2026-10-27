Imports System.Text
Imports System.Data.SqlClient
Imports System.Data
Public Class classYarnInCustomerYarn
    Public Function GetYarnIn(ByVal pdocno As String) As DataTable
        Dim conn As New SqlConnection((New classConnection).Connection)
        Dim comm As New SqlCommand("", conn)
        comm.CommandTimeout = 600
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "P_YARN_IN_CUSTOMER_YARN_PKG_select_yarn_in"
        comm.Parameters.AddWithValue("@docno", pdocno.Trim)

        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        Try
            da.Fill(dt)
        Catch ex As Exception
            conn.Close()
            'Msgerr = ex.Message
        End Try

        conn.Close()
        Return dt
    End Function

    Public Function GetYarnInDet(ByVal pdocno As String) As DataTable
        Dim conn As New SqlConnection((New classConnection).Connection)
        Dim comm As New SqlCommand("", conn)
        comm.CommandTimeout = 600
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "P_YARN_IN_CUSTOMER_YARN_PKG_select_yarn_in_det"
        comm.Parameters.AddWithValue("@docno", pdocno.Trim)

        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        Try
            da.Fill(dt)
        Catch ex As Exception
            conn.Close()
            '  Msgerr = ex.Message
        End Try


        conn.Close()
        Return dt
    End Function

    Public Function getJob(ByVal jobno As String) As DataTable
        Dim conn As New SqlConnection((New classConnection).Connection)
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "P_YARN_IN_CUSTOMER_YARN_PKG_select_job"
        comm.Parameters.AddWithValue("@jobno", jobno)
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        conn.Close()  'Sitthana 20190325
        Return dt
    End Function

    Public Function getJobDet(ByVal jobno As String) As DataTable
        Dim conn As New SqlConnection((New classConnection).Connection)
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "P_YARN_IN_CUSTOMER_YARN_PKG_select_job_det"
        comm.Parameters.AddWithValue("@jobno", jobno)
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        conn.Close()  'Sitthana 20190325
        Return dt
    End Function

    Public Function getJobFree(ByVal jobno As String, ByVal itnaturecd As String) As DataTable
        Dim conn As New SqlConnection((New classConnection).Connection)
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "P_YARN_IN_CUSTOMER_YARN_PKG_select_items"
        comm.Parameters.AddWithValue("@jobno", jobno)
        comm.Parameters.AddWithValue("@itnaturecd", itnaturecd)
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        conn.Close()  'Sitthana 20190325
        Return dt
    End Function

    Public Function SaveData(ByVal dtYarnIn As DataTable, ByVal loginEmpcd As String, ByRef docno As String) As Boolean
        Dim deletedDetRecs As New DataView(dtYarnIn, "", "", DataViewRowState.Deleted)
        Dim modifiedDetRecs As New DataView(dtYarnIn, "", "", DataViewRowState.ModifiedCurrent)
        Dim addedDetRecs As New DataView(dtYarnIn, "", "", DataViewRowState.Added)

        Dim clsConfig As New clsConfig
        Dim conn As New SqlConnection((New classConnection).Connection)
        conn.Open()

        Dim comm As New SqlCommand("", conn)
        Dim tran As SqlTransaction = conn.BeginTransaction
        comm.Transaction = tran
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "P_YARN_IN_CUSTOMER_YARN_PKG_update_yarn_in"

        comm.Parameters.AddWithValue("@docno", clsConfig.IsNull(dtYarnIn.Rows(0)("docno"), ""))
        comm.Parameters.AddWithValue("@docdt", clsConfig.IsNull(dtYarnIn.Rows(0)("docdt2"), "19000101"))
        comm.Parameters.AddWithValue("@purno", clsConfig.IsNull(dtYarnIn.Rows(0)("purno"), ""))
        comm.Parameters.AddWithValue("@sinvno", clsConfig.IsNull(dtYarnIn.Rows(0)("sinvno"), ""))
        comm.Parameters.AddWithValue("@sinvdt", clsConfig.IsNull(dtYarnIn.Rows(0)("sinvdt"), ""))
        comm.Parameters.AddWithValue("@suppcd", clsConfig.IsNull(dtYarnIn.Rows(0)("suppcd"), ""))
        comm.Parameters.AddWithValue("@lotno_sup", clsConfig.IsNull(dtYarnIn.Rows(0)("lotno_sup"), ""))
        comm.Parameters.AddWithValue("@srefno", clsConfig.IsNull(dtYarnIn.Rows(0)("srefno"), ""))
        comm.Parameters.AddWithValue("@tran_type", clsConfig.IsNull(dtYarnIn.Rows(0)("tran_type"), ""))
        comm.Parameters.AddWithValue("@remark", clsConfig.IsNull(dtYarnIn.Rows(0)("remark"), ""))
        comm.Parameters.AddWithValue("@itcd", clsConfig.IsNull(dtYarnIn.Rows(0)("itcd"), "")) 'Add By Neung For Gen Lot No Our
        comm.Parameters.AddWithValue("@log_empcd", loginEmpcd.Trim)

        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        Try
            da.Fill(dt)
            docno = dt.Rows(0)("docno").ToString
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
                comm.CommandText = "P_YARN_IN_CUSTOMER_YARN_PKG_delete_yarn_in_det"

                comm.Parameters.AddWithValue("@docno", clsConfig.IsNull(dtYarnIn.Rows(0)("docno"), ""))
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
        REM test
        i = 0

        If modifiedDetRecs.Count > 0 Then
            For i = 0 To modifiedDetRecs.Count - 1
                comm.Parameters.Clear()
                comm.CommandText = "P_YARN_IN_CUSTOMER_YARN_PKG_update_yarn_in_det"

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
                comm.Parameters.Clear()
                comm.CommandText = "P_YARN_IN_CUSTOMER_YARN_PKG_update_yarn_in_det"

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
                    comm.Parameters.AddWithValue("@login_empcd", loginEmpcd.Trim)
                End With

                da = New SqlDataAdapter(comm)
                dt = New DataTable
                Try
                    da.Fill(dt)
                Catch ex As Exception
                    MessageBox.Show(ex.Message, "System Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    tran.Rollback()
                    conn.Close()
                    Return False
                End Try
            Next
        End If

        tran.Commit()
        conn.Close()
        Return True
    End Function

End Class

