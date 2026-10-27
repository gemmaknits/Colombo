Imports System.Data
Imports System.Data.SqlClient
Imports System.Text
Public Class classOperationWarp
    Public Structure YarnIn
        Dim docno As String
        Dim docdt As Nullable(Of Date)

    End Structure

    Public Function GetComboOperator() As DataTable
        Dim conn As New SqlConnection((New classConnection).connection)
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "P_OPERATION_WARPING_PKG_combo_operator"
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        conn.Close()  'Sitthana 20190325
        Return dt
    End Function
    Public Function GetProductionLots(Optional ByVal pSystemLotNumber As String = Nothing) As DataTable
        Dim conn As New SqlConnection((New classConnection).connection)
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "P_OPERATION_WARPING_PKG_select"
        comm.Parameters.Clear()
        comm.Parameters.AddWithValue("@system_lot_number", pSystemLotNumber)
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        comm.Connection.Close()
        Try
            da.Fill(dt)
            conn.Close()  'Sitthana 20190325
        Catch ex As Exception
            conn.Close()  'Sitthana 20190325
        End Try
        Return dt
    End Function

    Public Function SavaData(ByRef YarnIn As classOperationWarp.YarnIn, ByVal dtYarnInDet As DataTable, ByRef message As String, ByVal logempcd As String) As Boolean
        Dim config As New clsConfig
        Dim classConnection As New classConnection

        Dim conn As New SqlConnection(classConnection.connection)
        conn.Open()
        Dim tran As SqlTransaction = conn.BeginTransaction
        Dim comm As New SqlCommand("", conn)
        Dim i As Integer = 0
        Dim j As Integer = 0

        comm.Transaction = tran
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "P_OPERATION_WARPING_PKG_update_yarn_in_det"
        For i = 0 To dtYarnInDet.Rows.Count - 1
            With dtYarnInDet.Rows

                comm.Parameters.Clear()
                comm.Parameters.AddWithValue("@docdt", YarnIn.docdt)
                comm.Parameters.AddWithValue("@docno", YarnIn.docno)
                comm.Parameters.AddWithValue("@itcd", .Item(i)("inventory_item_code"))
                comm.Parameters.AddWithValue("@purno", .Item(i)("production_order_no"))
                comm.Parameters.AddWithValue("@boxno", .Item(i)("system_lot_number"))
                comm.Parameters.AddWithValue("@boxno_s", .Item(i)("system_lot_number"))
                comm.Parameters.AddWithValue("@boxno_f", .Item(i)("system_lot_number"))
                comm.Parameters.AddWithValue("@boxno_o", .Item(i)("system_lot_number"))
                comm.Parameters.AddWithValue("@boxno_p", .Item(i)("system_lot_number"))
                comm.Parameters.AddWithValue("@lotno_sup", .Item(i)("lotno_sup"))
                comm.Parameters.AddWithValue("@lotno_our", .Item(i)("lotno_our"))
                comm.Parameters.AddWithValue("@kg_nt", .Item(i)("beam_total_weight"))
                comm.Parameters.AddWithValue("@kg_gr", .Item(i)("kg_gr"))
                comm.Parameters.AddWithValue("@spools", .Item(i)("beams_per_set"))
                comm.Parameters.AddWithValue("@cart_tearwt", 0)
                comm.Parameters.AddWithValue("@spool_tearwt", 0)
                comm.Parameters.AddWithValue("@actual_cone_weight", .Item(i)("actual_cone_weight"))
                comm.Parameters.AddWithValue("@mtl_warehouse_id", .Item(i)("mtl_warehouse_id"))
                comm.Parameters.AddWithValue("@mtl_subinventory_id", .Item(i)("mtl_subinventory_id"))
                comm.Parameters.AddWithValue("@mtl_locations_id", .Item(i)("mtl_locations_id"))
                comm.Parameters.AddWithValue("@box_remark", .Item(i)("box_remark"))
                comm.Parameters.AddWithValue("@logempcd", logempcd)

                Dim da = New SqlDataAdapter(comm)
                Dim dt = New DataTable
                Try
                    da.Fill(dt)
                Catch ex As Exception
                    message = ex.Message
                    tran.Rollback()
                    conn.Close()
                    Return False
                End Try

                Try
                    YarnIn.docno = dt.Rows(0)("docno")
                    YarnIn.docdt = dt.Rows(0)("docdt")
                Catch ex As Exception
                    message = ex.Message
                    tran.Rollback()
                    conn.Close()  'Sitthana 20190325
                    Return False
                End Try
            End With
        Next

        tran.Commit()
        conn.Close()
        Return True

    End Function
End Class
