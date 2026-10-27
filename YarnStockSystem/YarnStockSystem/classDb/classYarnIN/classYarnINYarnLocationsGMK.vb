Imports System.Data
Imports System.Data.SqlClient
Imports System.Text
Public Class classYarnINYarnLocationsGMK
    Public Structure YarnIn
        Dim Docno As String
        Dim Docdt As DateTime
        Dim Trantype As String
        Dim Purno As String
        Dim sinvno As String
        Dim sinvdt As Nullable(Of Date) 'String
        Dim suppcd As String
        Dim lotnoSup As String
        Dim lotnoOur As String
        Dim srefno As String
        Dim Remark As String

    End Structure
    Public Function GetYarnIn(ByRef pDocno As String) As DataTable
        Dim conn As New SqlConnection((New classConnection).Connection)
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "P_YARN_IN_YARN_LOCATIONS_GMK_PKG_select"
        comm.Parameters.AddWithValue("@docno", pDocno)
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        conn.Close()  'Sitthana 20190325
        Return dt
    End Function

    Public Function GetYarnLocationsGMK(ByRef pLogNo As String, ByRef Strmsgerr As String) As DataTable
        Dim conn As New SqlConnection((New classConnection).Connection)
        conn.Open()
        Dim tran As SqlTransaction = conn.BeginTransaction
        Dim comm As New SqlCommand("", conn)
        comm.CommandTimeout = 600
        comm.CommandType = CommandType.StoredProcedure
        comm.Transaction = tran
        comm.CommandText = "P_YARN_IN_YARN_LOCATIONS_GMK_PKG_select_yarn_locations_log_gmk"
        comm.Parameters.AddWithValue("@logno", pLogNo)
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        Try
            da.Fill(dt)
        Catch ex As Exception
            Strmsgerr = ex.Message
            tran.Rollback()
            conn.Close()
            Return dt
        End Try

        tran.Commit()
        conn.Close()  'Sitthana 20190325
        Return dt
    End Function

    Public Function GetDocNoByLogNo(ByVal pLogNo As String, ByVal StrUserID As String) As String
        Dim conn As New SqlConnection((New classConnection).Connection)
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "P_YARN_IN_YARN_LOCATIONS_GMK_PKG_get_docno_by_logno"
        comm.Parameters.AddWithValue("@logno", pLogNo)
        'comm.Parameters.AddWithValue("@logempcd", StrUserID)
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        Dim StrDocno As String = ""

        da.Fill(dt)
        conn.Close()  'Sitthana 20190325
        If dt.Rows.Count > 0 Then
            StrDocno = dt.Rows(0)("docno").ToString.Trim
        End If

        Return StrDocno.Trim

    End Function

    Public Function YarnINSave(ByRef objYarnIn As YarnIn, ByRef DtYarnInDet As DataTable,
                               ByRef Msgerr As String, ByRef LogEmpcd As String) As Boolean
        Dim deletedDetRecs As New DataView(DtYarnInDet, "", "", DataViewRowState.Deleted)
        Dim modifiedDetRecs As New DataView(DtYarnInDet, "", "", DataViewRowState.ModifiedCurrent)
        Dim addedDetRecs As New DataView(DtYarnInDet, "", "", DataViewRowState.Added)

        Dim clsConfig As New clsConfig
        Dim conn As New SqlConnection((New classConnection).Connection)
        conn.Open()
        Dim tran As SqlTransaction = conn.BeginTransaction
        Dim comm As New SqlCommand("", conn)
        Dim i As Integer = 0
        Dim strLotNo As String = ""
        comm.Transaction = tran
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "P_YARN_IN_YARN_LOCATIONS_GMK_PKG_update_yarn_in"
        With objYarnIn
            comm.Parameters.AddWithValue("@docno", .Docno)
            comm.Parameters.AddWithValue("@docdt", .Docdt)
            comm.Parameters.AddWithValue("@purno", .Purno)
            comm.Parameters.AddWithValue("@sinvno", .sinvno)
            comm.Parameters.AddWithValue("@sinvdt", .sinvdt)
            comm.Parameters.AddWithValue("@suppcd", .suppcd)
            comm.Parameters.AddWithValue("@lotno_sup", .lotnoSup)
            comm.Parameters.AddWithValue("@lotno_our", .lotnoOur)
            comm.Parameters.AddWithValue("@srefno", .srefno)
            comm.Parameters.AddWithValue("@tran_type", .Trantype)
            comm.Parameters.AddWithValue("@remark", "")
            comm.Parameters.AddWithValue("@log_empcd", LogEmpcd.Trim)
        End With
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
        objYarnIn.Docno = dt.Rows(0)("docno").ToString.Trim

        For Each dr As DataRow In DtYarnInDet.Rows
            If dr.RowState = DataRowState.Deleted Then
                comm.Parameters.Clear()
                comm.CommandText = "P_YARN_IN_YARN_LOCATIONS_GMK_PKG_delete_yarn_in_det"

                comm.Parameters.AddWithValue("@docno", clsConfig.IsNull(dr("docno"), ""))
                comm.Parameters.AddWithValue("@boxno", dr("boxno").ToString.Trim)
                comm.Parameters.AddWithValue("@log_empcd", LogEmpcd.Trim)
                da = New SqlDataAdapter(comm)
                dt = New DataTable

                Try
                    da.Fill(dt)
                Catch ex As Exception
                    Msgerr = ex.Message
                    tran.Rollback()
                    conn.Close()  'Sitthana 20190325
                    Return False
                End Try
            End If
        Next


        For Each dr As DataRow In DtYarnInDet.Rows
            If dr.RowState <> DataRowState.Deleted Then
                comm.Parameters.Clear()
                comm.CommandText = "P_YARN_IN_YARN_LOCATIONS_GMK_PKG_update_yarn_in_det"

                With modifiedDetRecs
                    comm.Parameters.AddWithValue("@docno", objYarnIn.Docno)
                    comm.Parameters.AddWithValue("@itcd", clsConfig.IsNull(dr("itcd"), "").Trim)
                    comm.Parameters.AddWithValue("@boxno_s", clsConfig.IsNull(dr("boxno_s"), "").Trim)
                    comm.Parameters.AddWithValue("@boxno", clsConfig.IsNull(dr("boxno"), "").Trim)
                    comm.Parameters.AddWithValue("@spools", clsConfig.IsNull(dr("spools"), 0).ToString)
                    comm.Parameters.AddWithValue("@grade", clsConfig.IsNull(dr("grade"), "").Trim)
                    comm.Parameters.AddWithValue("@grade_our", clsConfig.IsNull(dr("grade_our"), "").Trim)
                    comm.Parameters.AddWithValue("@kg_gr", clsConfig.IsNull(dr("kg_gr"), 0).ToString)
                    comm.Parameters.AddWithValue("@cart_tearwt", clsConfig.IsNull(dr("cart_tearwt"), 0).ToString)
                    comm.Parameters.AddWithValue("@spool_tearwt", clsConfig.IsNull(dr("spool_tearwt"), 0).ToString)
                    comm.Parameters.AddWithValue("@kg_nt", clsConfig.IsNull(dr("kg_nt"), 0).ToString)
                    comm.Parameters.AddWithValue("@actual_cone_weight", clsConfig.IsValidDouble(dr("kg_nt")) / clsConfig.IsValidDouble(dr("spools")))
                    comm.Parameters.AddWithValue("@location", "N/A")
                    comm.Parameters.AddWithValue("@mtl_warehouse_id", clsConfig.IsNull(dr("mtl_warehouse_id"), DBNull.Value))
                    comm.Parameters.AddWithValue("@mtl_subinventory_id", clsConfig.IsNull(dr("mtl_subinventory_id"), DBNull.Value))
                    comm.Parameters.AddWithValue("@mtl_locations_id", clsConfig.IsNull(dr("mtl_locations_id"), DBNull.Value))
                    comm.Parameters.AddWithValue("@id_jobdet", DBNull.Value)
                    comm.Parameters.AddWithValue("@box_remark", clsConfig.IsNull(dr("box_remark"), 0).ToString)
                    comm.Parameters.AddWithValue("@interface_yarn_logid", dr("interface_yarn_logid"))
                    comm.Parameters.AddWithValue("@interface_yarn_logno", dr("interface_yarn_logno"))
                    comm.Parameters.AddWithValue("@lotno_sup", dr("lotno_sup"))
                    comm.Parameters.AddWithValue("@lotno_our", dr("lotno_our"))
                    comm.Parameters.AddWithValue("@login_empcd", LogEmpcd.Trim)
                End With
                da = New SqlDataAdapter(comm)
                dt = New DataTable

                Try
                    da.Fill(dt)
                Catch ex As Exception
                    Msgerr = ex.Message
                    tran.Rollback()
                    conn.Close()  'Sitthana 20190325
                    Return False
                End Try
            End If
        Next

        '=========================== Log Yarn In By Neung =====================
        With objYarnIn
            comm.CommandText = "log_yarn_in"
            comm.Parameters.Clear()
            comm.Parameters.AddWithValue("@empcd", LogEmpcd)
            comm.Parameters.AddWithValue("@docno", .Docno)
            comm.Parameters.AddWithValue("@action", "NEW")
            da = New SqlDataAdapter(comm)
            dt = New DataTable
        End With
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
