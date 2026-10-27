Imports System.Data
Imports System.Data.SqlClient
Imports System.Text
Public Class classYarnMaster
    Private oConn As New classConnection
    Private oConfig As New clsConfig
    Public Function selectUomList() As DataTable
        Dim conn As New SqlConnection(oConn.connection)
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "P_YARN_MASTER_FORM_PKG_select_uom_list"
        comm.Parameters.Clear()
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        conn.Close()
        Return dt
    End Function

    Public Overloads Function selectItemsRecord(ByVal itcd As String) As DataTable
        Dim conn As New SqlConnection(oConn.connection())
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "P_YARN_MASTER_FORM_PKG_select_items_record"
        comm.Parameters.Clear()
        comm.Parameters.AddWithValue("@itcd", itcd.Trim)
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        conn.Close()
        Return dt
    End Function

    Public Function updateItemsRecord(ByRef pitcd As String, ByVal Param_tbl_items As tbl_Items, ByVal commandType As String, ByRef msgerr As String, Optional ByVal loginempcd As String = "") As Boolean
        Dim conn As New SqlConnection(oConn.connection())
        Dim comm As New SqlCommand("", conn)
        conn.Open()
        Dim tran As SqlTransaction = conn.BeginTransaction
        comm.Transaction = tran
        comm.CommandType = Data.CommandType.StoredProcedure
        Select Case commandType
            Case "NEW"
                With Param_tbl_items
                    comm.CommandText = "P_YARN_MASTER_FORM_PKG_update_items_record"
                    comm.Parameters.Clear()
                    comm.Parameters.AddWithValue("@itcd", .itcd.Trim)
                    comm.Parameters.AddWithValue("@itdesc", .itdesc.Trim)
                    comm.Parameters.AddWithValue("@itdesc2", .itdesc2.Trim)
                    comm.Parameters.AddWithValue("@itdesc3", .itdesc3.Trim)
                    comm.Parameters.AddWithValue("@itdesc_spec", .itdesc_spec.Trim)
                    comm.Parameters.AddWithValue("@itdesct", .itdesct.Trim)
                    comm.Parameters.AddWithValue("@itdesct2", .itdesct2.Trim)
                    comm.Parameters.AddWithValue("@itdesct3", .itdesct3)
                    comm.Parameters.AddWithValue("@itnaturecd", .itnaturecd.Trim)
                    comm.Parameters.AddWithValue("@ittypecd", (New clsConfig).IsNull(.ittypecd, "").Trim)
                    comm.Parameters.AddWithValue("@itcatcd", .itcatcd.Trim)
                    comm.Parameters.AddWithValue("@itsubcatcd", .itsubcatcd.Trim)
                    comm.Parameters.AddWithValue("@itgroupcd", .itgroupcd.Trim)
                    comm.Parameters.AddWithValue("@itsubcd", .itsubcd.Trim)
                    comm.Parameters.AddWithValue("@itsubcd2", .itsubcd2.Trim)
                    comm.Parameters.AddWithValue("@itsubcd3", .itsubcd3.Trim)
                    comm.Parameters.AddWithValue("@mrpcode", .mrpcode.Trim)
                    comm.Parameters.AddWithValue("@dinear", .dinear.Trim)
                    comm.Parameters.AddWithValue("@filament", .filament.Trim)
                    comm.Parameters.AddWithValue("@twists", .twists.Trim)
                    comm.Parameters.AddWithValue("@col", oConfig.IsNull(.col, DBNull.Value))
                    comm.Parameters.AddWithValue("@dimension", .dimension.Trim)
                    comm.Parameters.AddWithValue("@suppcd", .suppcd.Trim)
                    comm.Parameters.AddWithValue("@reorder_qty", .reorder_qty)
                    comm.Parameters.AddWithValue("@reorder_unit", .reorder_unit.Trim)
                    comm.Parameters.AddWithValue("@uom2_id", .uom2_id)
                    comm.Parameters.AddWithValue("@reorder_unit2", .reorder_unit2.Trim)   'saharat
                    comm.Parameters.AddWithValue("@itdesc_supp", .itdesc_supp.Trim)
                    comm.Parameters.AddWithValue("@maximum_qty", .maximum_qty)
                    comm.Parameters.AddWithValue("@beam_length", .beam_length)
                    comm.Parameters.AddWithValue("@warped_ends", .warped_ends)
                    comm.Parameters.AddWithValue("@beams_per_set", .beams_per_set)
                    comm.Parameters.AddWithValue("@lead_time", .lead_time)
                    comm.Parameters.AddWithValue("@safety_stock", .safety_stock)
                End With
            Case "EDIT"
                With Param_tbl_items
                    comm.CommandText = "P_YARN_MASTER_FORM_PKG_update_items_record"
                    comm.Parameters.Clear()
                    comm.Parameters.AddWithValue("@itcd", .itcd.Trim)
                    comm.Parameters.AddWithValue("@itdesc", .itdesc.Trim)
                    comm.Parameters.AddWithValue("@itdesc2", .itdesc2.Trim)
                    comm.Parameters.AddWithValue("@itdesc3", .itdesc3.Trim)
                    comm.Parameters.AddWithValue("@itdesc_spec", .itdesc_spec.Trim)
                    comm.Parameters.AddWithValue("@itdesct", .itdesct.Trim)
                    comm.Parameters.AddWithValue("@itdesct2", .itdesct2.Trim)
                    comm.Parameters.AddWithValue("@itdesct3", .itdesct3)
                    comm.Parameters.AddWithValue("@itnaturecd", .itnaturecd.Trim)
                    comm.Parameters.AddWithValue("@ittypecd", .ittypecd.Trim)
                    comm.Parameters.AddWithValue("@itcatcd", .itcatcd.Trim)
                    comm.Parameters.AddWithValue("@itsubcatcd", .itsubcatcd.Trim)
                    comm.Parameters.AddWithValue("@itgroupcd", .itgroupcd.Trim)
                    comm.Parameters.AddWithValue("@itsubcd", .itsubcd.Trim)
                    comm.Parameters.AddWithValue("@itsubcd2", .itsubcd2.Trim)
                    comm.Parameters.AddWithValue("@itsubcd3", .itsubcd3.Trim)
                    comm.Parameters.AddWithValue("@mrpcode", .mrpcode.Trim)
                    comm.Parameters.AddWithValue("@dinear", .dinear.Trim)
                    comm.Parameters.AddWithValue("@filament", .filament.Trim)
                    comm.Parameters.AddWithValue("@twists", .twists.Trim)
                    comm.Parameters.AddWithValue("@col", .col.Trim)
                    comm.Parameters.AddWithValue("@dimension", .dimension.Trim)
                    comm.Parameters.AddWithValue("@suppcd", .suppcd.Trim)
                    comm.Parameters.AddWithValue("@reorder_qty", .reorder_qty)
                    comm.Parameters.AddWithValue("@reorder_unit", .reorder_unit.Trim)
                    comm.Parameters.AddWithValue("@uom2_id", .uom2_id)
                    comm.Parameters.AddWithValue("@reorder_unit2", .reorder_unit2.Trim)
                    comm.Parameters.AddWithValue("@itdesc_supp", .itdesc_supp.Trim)
                    comm.Parameters.AddWithValue("@maximum_qty", .maximum_qty)
                    comm.Parameters.AddWithValue("@beam_length", .beam_length)
                    comm.Parameters.AddWithValue("@warped_ends", .warped_ends)
                    comm.Parameters.AddWithValue("@beams_per_set", .beams_per_set)
                    comm.Parameters.AddWithValue("@lead_time", .lead_time)
                    comm.Parameters.AddWithValue("@safety_stock", .safety_stock)
                End With
            Case "DEL"
                With Param_tbl_items
                    comm.CommandText = "P_YARN_MASTER_FORM_PKG_disable_items_record"
                    comm.Parameters.Clear()
                    comm.Parameters.AddWithValue("@itcd", .itcd.Trim)
                    comm.Parameters.AddWithValue("@log_empcd", loginempcd.Trim)
                End With
        End Select


        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        Try
            da.Fill(dt)
            pitcd = oConfig.IsNull(dt.Rows(0)("itcd").ToString, "").Trim
            ' comm.ExecuteNonQuery()
        Catch ex As Exception
            msgerr = ex.Message
            tran.Rollback()
            conn.Close()  'Sitthana 20190325
            Return False
        End Try

        tran.Commit()
        comm.Connection.Close()
        comm.Dispose()
        If conn.State = ConnectionState.Open Then conn.Close()
        conn.Dispose()
        Return True
    End Function
End Class
