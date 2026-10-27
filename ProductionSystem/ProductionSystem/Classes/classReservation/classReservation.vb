Imports System.Data
Imports System.Data.SqlClient
Imports System.Text

Public Class classReservation
    Public Structure mtl_reservations
        Dim mtl_reservations_id As Nullable(Of Int64)
        Dim mtl_warehouse_id As Nullable(Of Int64)
        Dim item_id As Nullable(Of Int64)
        Dim demand_source_type_id As Nullable(Of Int64)
        Dim demand_source_header_id As Nullable(Of Int64)
        Dim demand_source_line_id As Nullable(Of Int64)
        Dim reserve_qty As Nullable(Of Decimal)
        Dim reserve_qty2 As Nullable(Of Decimal)
        Dim reserve_uom_id As Nullable(Of Int64)
        Dim reserve_uom_id2 As Nullable(Of Int64)
        Dim uom_id As Nullable(Of Int64)
        Dim uom_id2 As Nullable(Of Int64)
        Dim base_qty As Nullable(Of Decimal)
        Dim supply_source_type_id As Nullable(Of Int64)
        Dim supply_source_header_id As Nullable(Of Int64)
        Dim supply_source_line_id As Nullable(Of Int64)
        Dim mtl_subinventory_id As Nullable(Of Int64)
        Dim mtl_locations_id As Nullable(Of Int64)
        Dim creation_date As Nullable(Of DateTime)
        Dim created_by As String
        Dim last_modified_date As Nullable(Of DateTime)
        Dim last_modified_by As String
        Dim expected_release_date As Nullable(Of DateTime)

    End Structure
    Public Function Getmtl_reservations(Optional ByVal Int64mtl_reservations_id As Nullable(Of Decimal) = Nothing _
        , Optional ByVal Int64demand_source_type_id As Nullable(Of Decimal) = Nothing _
        , Optional ByVal Int64demand_source_header_id As Nullable(Of Decimal) = Nothing _
        , Optional ByVal Int64supply_source_type_id As Nullable(Of Decimal) = Nothing _
        , Optional ByVal Int64supply_source_header_id As Nullable(Of Decimal) = Nothing _
        ) As DataTable

        Dim conn As New SqlConnection((New classConnection).connection)
        Dim comm As New SqlCommand("", conn)

        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "p_mtl_reservations_select"
        comm.Parameters.AddWithValue("@mtl_reservations_id", Int64mtl_reservations_id)
        comm.Parameters.AddWithValue("@demand_source_type_id", Int64demand_source_type_id)
        comm.Parameters.AddWithValue("@demand_source_header_id", Int64demand_source_header_id)
        comm.Parameters.AddWithValue("@supply_source_type_id", Int64supply_source_type_id)
        comm.Parameters.AddWithValue("@supply_source_header_id", Int64supply_source_header_id)

        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable

        'Try
        da.Fill(dt)
        conn.Close()  'Sitthana 20190325
        'Catch ex As Exception

        'End Try


        Return dt
        'Dim conn As New SqlConnection((New classConnection).connection)
        'Dim comm As New SqlCommand("", conn)


    End Function

    Public Function SavaData(ByVal dv_add As DataView, ByVal dv_upd As DataView, ByVal dv_del As DataView, ByVal clsuser As classUserInfo) As Boolean
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

        comm.CommandText = "p_mtl_reservations_insert" 'In Process 
        i = 0
        For i = 0 To dv_add.Count - 1
            With dv_add
                comm.Parameters.Clear()
                comm.Parameters.AddWithValue("@mtl_reservations_id", .Item(i)("mtl_reservations_id"))
                comm.Parameters.AddWithValue("@mtl_warehouse_id", .Item(i)("mtl_warehouse_id"))
                comm.Parameters.AddWithValue("@demand_source_type_id", .Item(i)("demand_source_type_id"))
                comm.Parameters.AddWithValue("@demand_source_header_id", .Item(i)("demand_source_header_id"))
                comm.Parameters.AddWithValue("@demand_source_line_id", .Item(i)("demand_source_line_id"))
                comm.Parameters.AddWithValue("@demand_source_lot_number", .Item(i)("demand_source_lot_number"))
                comm.Parameters.AddWithValue("@demand_source_item_id", .Item(i)("demand_source_item_id"))
                comm.Parameters.AddWithValue("@reserve_qty", .Item(i)("reserve_qty"))
                comm.Parameters.AddWithValue("@reserve_qty2", .Item(i)("reserve_qty2"))
                comm.Parameters.AddWithValue("@reserve_uom_id", .Item(i)("reserve_uom_id"))
                comm.Parameters.AddWithValue("@reserve_uom_id2", .Item(i)("reserve_uom_id2"))
                comm.Parameters.AddWithValue("@uom_id", .Item(i)("uom_id"))
                comm.Parameters.AddWithValue("@uom_id2", .Item(i)("uom_id2"))
                comm.Parameters.AddWithValue("@base_qty", .Item(i)("base_qty"))
                comm.Parameters.AddWithValue("@supply_source_type_id", .Item(i)("supply_source_type_id"))
                comm.Parameters.AddWithValue("@supply_source_header_id", .Item(i)("supply_source_header_id"))
                comm.Parameters.AddWithValue("@supply_source_line_id", .Item(i)("supply_source_line_id"))
                comm.Parameters.AddWithValue("@supply_source_lot_number", .Item(i)("supply_source_lot_number"))
                comm.Parameters.AddWithValue("@supply_source_item_id", .Item(i)("supply_source_item_id"))
                comm.Parameters.AddWithValue("@mtl_subinventory_id", .Item(i)("mtl_subinventory_id"))
                comm.Parameters.AddWithValue("@mtl_locations_id", .Item(i)("mtl_locations_id"))
                comm.Parameters.AddWithValue("@creation_date", .Item(i)("creation_date"))
                comm.Parameters.AddWithValue("@created_by", .Item(i)("created_by"))
                comm.Parameters.AddWithValue("@last_modified_date", .Item(i)("last_modified_date"))
                comm.Parameters.AddWithValue("@last_modified_by", .Item(i)("last_modified_by"))
                comm.Parameters.AddWithValue("@expected_release_date", .Item(i)("expected_release_date"))

            End With
            Dim dac_int = New SqlDataAdapter(comm)
            Dim dtc_int = New DataTable
            Try
                dac_int.Fill(dtc_int)
            Catch ex As Exception
                'mfg_production_lots.message = ex.Message
                tran.Rollback()
                conn.Close()
                Return False
            End Try
        Next


        comm.CommandText = "p_mtl_reservations_update" 'In Process 
        i = 0
        For i = 0 To dv_upd.Count - 1
            With dv_upd
                comm.Parameters.Clear()
                comm.Parameters.AddWithValue("@mtl_reservations_id", .Item(i)("mtl_reservations_id"))
                comm.Parameters.AddWithValue("@mtl_warehouse_id", .Item(i)("mtl_warehouse_id"))
                comm.Parameters.AddWithValue("@demand_source_type_id", .Item(i)("demand_source_type_id"))
                comm.Parameters.AddWithValue("@demand_source_header_id", .Item(i)("demand_source_header_id"))
                comm.Parameters.AddWithValue("@demand_source_line_id", .Item(i)("demand_source_line_id"))
                comm.Parameters.AddWithValue("@demand_source_lot_number", .Item(i)("demand_source_lot_number"))
                comm.Parameters.AddWithValue("@demand_source_item_id", .Item(i)("demand_source_item_id"))
                comm.Parameters.AddWithValue("@reserve_qty", .Item(i)("reserve_qty"))
                comm.Parameters.AddWithValue("@reserve_qty2", .Item(i)("reserve_qty2"))
                comm.Parameters.AddWithValue("@reserve_uom_id", .Item(i)("reserve_uom_id"))
                comm.Parameters.AddWithValue("@reserve_uom_id2", .Item(i)("reserve_uom_id2"))
                comm.Parameters.AddWithValue("@uom_id", .Item(i)("uom_id"))
                comm.Parameters.AddWithValue("@uom_id2", .Item(i)("uom_id2"))
                comm.Parameters.AddWithValue("@base_qty", .Item(i)("base_qty"))
                comm.Parameters.AddWithValue("@supply_source_type_id", .Item(i)("supply_source_type_id"))
                comm.Parameters.AddWithValue("@supply_source_header_id", .Item(i)("supply_source_header_id"))
                comm.Parameters.AddWithValue("@supply_source_line_id", .Item(i)("supply_source_line_id"))
                comm.Parameters.AddWithValue("@supply_source_lot_number", .Item(i)("supply_source_lot_number"))
                comm.Parameters.AddWithValue("@supply_source_item_id", .Item(i)("supply_source_item_id"))
                comm.Parameters.AddWithValue("@mtl_subinventory_id", .Item(i)("mtl_subinventory_id"))
                comm.Parameters.AddWithValue("@mtl_locations_id", .Item(i)("mtl_locations_id"))
                comm.Parameters.AddWithValue("@creation_date", .Item(i)("creation_date"))
                comm.Parameters.AddWithValue("@created_by", .Item(i)("created_by"))
                comm.Parameters.AddWithValue("@last_modified_date", .Item(i)("last_modified_date"))
                comm.Parameters.AddWithValue("@last_modified_by", .Item(i)("last_modified_by"))
                comm.Parameters.AddWithValue("@expected_release_date", .Item(i)("expected_release_date"))

            End With

            Dim dac_upd = New SqlDataAdapter(comm)
            Dim dtc_upd = New DataTable
            Try
                dac_upd.Fill(dtc_upd)
            Catch ex As Exception
                'mfg_production_lots.message = ex.Message
                tran.Rollback()
                conn.Close()
                Return False
            End Try
        Next

        comm.CommandText = "p_mtl_reservations_delete" 'In Process 
        i = 0
        For i = 0 To dv_del.Count - 1
            With dv_del
                comm.Parameters.Clear()
                comm.Parameters.AddWithValue("@mtl_reservations_id", .Item(i)("mtl_reservations_id"))
                comm.Parameters.AddWithValue("@mtl_warehouse_id", .Item(i)("mtl_warehouse_id"))
                comm.Parameters.AddWithValue("@demand_source_type_id", .Item(i)("demand_source_type_id"))
                comm.Parameters.AddWithValue("@demand_source_header_id", .Item(i)("demand_source_header_id"))
                comm.Parameters.AddWithValue("@demand_source_line_id", .Item(i)("demand_source_line_id"))
                comm.Parameters.AddWithValue("@demand_source_lot_number", .Item(i)("demand_source_lot_number"))
                comm.Parameters.AddWithValue("@demand_source_item_id", .Item(i)("demand_source_item_id"))
                comm.Parameters.AddWithValue("@reserve_qty", .Item(i)("reserve_qty"))
                comm.Parameters.AddWithValue("@reserve_qty2", .Item(i)("reserve_qty2"))
                comm.Parameters.AddWithValue("@reserve_uom_id", .Item(i)("reserve_uom_id"))
                comm.Parameters.AddWithValue("@reserve_uom_id2", .Item(i)("reserve_uom_id2"))
                comm.Parameters.AddWithValue("@uom_id", .Item(i)("uom_id"))
                comm.Parameters.AddWithValue("@uom_id2", .Item(i)("uom_id2"))
                comm.Parameters.AddWithValue("@base_qty", .Item(i)("base_qty"))
                comm.Parameters.AddWithValue("@supply_source_type_id", .Item(i)("supply_source_type_id"))
                comm.Parameters.AddWithValue("@supply_source_header_id", .Item(i)("supply_source_header_id"))
                comm.Parameters.AddWithValue("@supply_source_line_id", .Item(i)("supply_source_line_id"))
                comm.Parameters.AddWithValue("@supply_source_lot_number", .Item(i)("supply_source_lot_number"))
                comm.Parameters.AddWithValue("@supply_source_item_id", .Item(i)("supply_source_item_id"))
                comm.Parameters.AddWithValue("@mtl_subinventory_id", .Item(i)("mtl_subinventory_id"))
                comm.Parameters.AddWithValue("@mtl_locations_id", .Item(i)("mtl_locations_id"))
                comm.Parameters.AddWithValue("@creation_date", .Item(i)("creation_date"))
                comm.Parameters.AddWithValue("@created_by", .Item(i)("created_by"))
                comm.Parameters.AddWithValue("@last_modified_date", .Item(i)("last_modified_date"))
                comm.Parameters.AddWithValue("@last_modified_by", .Item(i)("last_modified_by"))
                comm.Parameters.AddWithValue("@expected_release_date", .Item(i)("expected_release_date"))
            End With

            Dim dac_del = New SqlDataAdapter(comm)
            Dim dtc_del = New DataTable
            Try
                dac_del.Fill(dtc_del)
            Catch ex As Exception
                'mfg_production_lots.message = ex.Message
                tran.Rollback()
                conn.Close()
                Return False
            End Try
        Next



        tran.Commit()
        conn.Close()
        Return True
    End Function
End Class
