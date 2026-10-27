Imports System.Data
Imports System.Data.SqlClient
Imports System.Text

Public Structure mtlreservations

    Dim StrreservationsNumber As String
    Dim DataReservationsDate As Date
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
Public Class classWOReservation
    'Public Structure mtlreservations
    '    Dim mtl_reservations_id As Nullable(Of Int64)
    '    Dim mtl_warehouse_id As Nullable(Of Int64)
    '    Dim item_id As Nullable(Of Int64)
    '    Dim demand_source_type_id As Nullable(Of Int64)
    '    Dim demand_source_header_id As Nullable(Of Int64)
    '    Dim demand_source_line_id As Nullable(Of Int64)
    '    Dim reserve_qty As Nullable(Of Decimal)
    '    Dim reserve_qty2 As Nullable(Of Decimal)
    '    Dim reserve_uom_id As Nullable(Of Int64)
    '    Dim reserve_uom_id2 As Nullable(Of Int64)
    '    Dim uom_id As Nullable(Of Int64)
    '    Dim uom_id2 As Nullable(Of Int64)
    '    Dim base_qty As Nullable(Of Decimal)
    '    Dim supply_source_type_id As Nullable(Of Int64)
    '    Dim supply_source_header_id As Nullable(Of Int64)
    '    Dim supply_source_line_id As Nullable(Of Int64)
    '    Dim mtl_subinventory_id As Nullable(Of Int64)
    '    Dim mtl_locations_id As Nullable(Of Int64)
    '    Dim creation_date As Nullable(Of DateTime)
    '    Dim created_by As String
    '    Dim last_modified_date As Nullable(Of DateTime)
    '    Dim last_modified_by As String
    '    Dim expected_release_date As Nullable(Of DateTime)

    'End Structure

    Public Function GetWoItems(Optional ByVal StrWoNo As String = Nothing) As DataTable
        Dim conn As New SqlConnection((New classConnection).connection)
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "P_WO_RESERVATIONS_PKG_get_wo_items"
        comm.Parameters.AddWithValue("@wono", StrWoNo)

        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        conn.Close()  'Sitthana 20190325
        Return dt
    End Function
    Public Function GetWOReservations(Optional ByVal StrReservationsNumber As String = Nothing) As DataTable

        Dim conn As New SqlConnection((New classConnection).connection)
        Dim comm As New SqlCommand("", conn)

        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "P_WO_RESERVATIONS_PKG_get_mtl_reservations"
        comm.Parameters.AddWithValue("@reservations_number", StrReservationsNumber)
        'comm.Parameters.AddWithValue("@supply_source_item_code", StrsupplySourceItemCode)
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        conn.Close()  'Sitthana 20190325
        Return dt
    End Function

    Public Function GetWOProdLot(Optional ByVal StrWoNo As String = Nothing,
                                      Optional ByVal StrDemandSourceItemCode As String = Nothing,
                                    Optional ByVal StrDemandSourceHeaderCode As String = Nothing,
                                    Optional ByVal StrDemandSourceLineID As Nullable(Of Int64) = Nothing) As DataTable

        Dim conn As New SqlConnection((New classConnection).connection)
        Dim comm As New SqlCommand("", conn)

        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "P_WO_RESERVATIONS_PKG_get_mfg_production_lots"
        comm.Parameters.AddWithValue("@supply_source_header_code", StrWoNo)
        comm.Parameters.AddWithValue("@demand_source_item_code", StrDemandSourceItemCode)
        comm.Parameters.AddWithValue("@demand_source_header_code", StrDemandSourceHeaderCode)
        comm.Parameters.AddWithValue("@demand_source_line_id", StrDemandSourceLineID)
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        conn.Close()  'Sitthana 20190325
        Return dt
    End Function

    Public Function GetKOProdLine(Optional ByVal StrKoNo As String = Nothing) As DataTable

        Dim conn As New SqlConnection((New classConnection).connection)
        Dim comm As New SqlCommand("", conn)

        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "P_WO_RESERVATIONS_PKG_get_ko_mfg_production_order_lines"
        comm.Parameters.AddWithValue("@kono", StrKoNo)

        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        conn.Close()  'Sitthana 20190325
        Return dt
    End Function

    Public Function WOReservationsSave(ByRef Mtlreservations As mtlreservations, ByVal DV_ADD As DataView, ByVal DV_UPD As DataView, ByVal DV_DEL As DataView, ByRef msgerr As String, ByVal Userinfo As classUserInfo) As Boolean
        Dim config As New clsConfig
        Dim conn As New SqlConnection((New classConnection).connection)
        conn.Open()
        Dim tran As SqlTransaction = conn.BeginTransaction
        Dim comm As New SqlCommand("", conn)
        Dim i As Integer = 0
        comm.Transaction = tran
        comm.CommandType = CommandType.StoredProcedure
        i = 0
        comm.CommandText = "P_WO_RESERVATIONS_PKG_update_mtl_reservations"
        For i = 0 To DV_ADD.Count - 1
            With DV_ADD
                comm.Parameters.Clear()
                comm.Parameters.AddWithValue("@reservations_number", Mtlreservations.StrreservationsNumber)
                comm.Parameters.AddWithValue("@reservations_date", Mtlreservations.DataReservationsDate)
                comm.Parameters.AddWithValue("@mtl_reservations_id", config.IsNull(.Item(i)("mtl_reservations_id"), DBNull.Value))
                comm.Parameters.AddWithValue("@demand_source_type_id", config.IsNull(.Item(i)("demand_source_type_id"), DBNull.Value))
                comm.Parameters.AddWithValue("@demand_source_header_id", config.IsNull(.Item(i)("demand_source_header_id"), DBNull.Value))
                comm.Parameters.AddWithValue("@demand_source_line_id", config.IsNull(.Item(i)("demand_source_line_id"), DBNull.Value))
                comm.Parameters.AddWithValue("@demand_source_lot_number", config.IsNull(.Item(i)("demand_source_lot_number"), DBNull.Value))
                comm.Parameters.AddWithValue("@demand_source_item_id", config.IsNull(.Item(i)("demand_source_item_id"), DBNull.Value))
                comm.Parameters.AddWithValue("@reserve_qty", config.IsNull(.Item(i)("reserve_qty"), DBNull.Value))
                comm.Parameters.AddWithValue("@reserve_uom_id", config.IsNull(.Item(i)("reserve_uom_id"), DBNull.Value))
                comm.Parameters.AddWithValue("@supply_source_type_id", config.IsNull(.Item(i)("supply_source_type_id"), DBNull.Value))
                comm.Parameters.AddWithValue("@supply_source_header_id", config.IsNull(.Item(i)("supply_source_header_id"), DBNull.Value))
                comm.Parameters.AddWithValue("@supply_source_line_id", config.IsNull(.Item(i)("supply_source_line_id"), DBNull.Value))
                comm.Parameters.AddWithValue("@supply_source_lot_number", config.IsNull(.Item(i)("supply_source_lot_number"), DBNull.Value))
                comm.Parameters.AddWithValue("@supply_source_item_id", config.IsNull(.Item(i)("supply_source_item_id"), DBNull.Value))
                comm.Parameters.AddWithValue("@mtl_warehouse_id", config.IsNull(.Item(i)("mtl_warehouse_id"), DBNull.Value))
                comm.Parameters.AddWithValue("@mtl_subinventory_id", config.IsNull(.Item(i)("mtl_subinventory_id"), DBNull.Value))
                comm.Parameters.AddWithValue("@mtl_locations_id", config.IsNull(.Item(i)("mtl_locations_id"), DBNull.Value))
                comm.Parameters.AddWithValue("@p_machine_bar", config.IsNull(.Item(i)("machine_bar"), DBNull.Value))

                comm.Parameters.AddWithValue("@created_by", Userinfo.UserID)

                comm.Parameters.AddWithValue("@last_modified_by", Userinfo.UserID)
            End With
            Dim da = New SqlDataAdapter(comm)
            Dim dt = New DataTable
            Try
                da.Fill(dt)
            Catch ex As Exception
                msgerr = ex.Message
                tran.Rollback()
                conn.Close()
                Return False
            End Try

            Mtlreservations.StrreservationsNumber = dt.Rows(0)("reservations_number").ToString
            Mtlreservations.DataReservationsDate = dt.Rows(0)("reservations_date").ToString
        Next

        i = 0
        comm.CommandText = "P_WO_RESERVATIONS_PKG_update_mtl_reservations"
        For i = 0 To DV_UPD.Count - 1
            With DV_UPD
                comm.Parameters.Clear()
                comm.Parameters.AddWithValue("@reservations_number", Mtlreservations.StrreservationsNumber)
                comm.Parameters.AddWithValue("@reservations_date", Mtlreservations.DataReservationsDate)
                comm.Parameters.AddWithValue("@mtl_reservations_id", config.IsNull(.Item(i)("mtl_reservations_id"), DBNull.Value))
                comm.Parameters.AddWithValue("@demand_source_type_id", config.IsNull(.Item(i)("demand_source_type_id"), DBNull.Value))
                comm.Parameters.AddWithValue("@demand_source_header_id", config.IsNull(.Item(i)("demand_source_header_id"), DBNull.Value))
                comm.Parameters.AddWithValue("@demand_source_line_id", config.IsNull(.Item(i)("demand_source_line_id"), DBNull.Value))
                comm.Parameters.AddWithValue("@demand_source_lot_number", config.IsNull(.Item(i)("demand_source_lot_number"), DBNull.Value))
                comm.Parameters.AddWithValue("@demand_source_item_id", config.IsNull(.Item(i)("demand_source_item_id"), DBNull.Value))
                comm.Parameters.AddWithValue("@reserve_qty", config.IsNull(.Item(i)("reserve_qty"), DBNull.Value))
                comm.Parameters.AddWithValue("@reserve_uom_id", config.IsNull(.Item(i)("reserve_uom_id"), DBNull.Value))
                comm.Parameters.AddWithValue("@supply_source_type_id", config.IsNull(.Item(i)("supply_source_type_id"), DBNull.Value))
                comm.Parameters.AddWithValue("@supply_source_header_id", config.IsNull(.Item(i)("supply_source_header_id"), DBNull.Value))
                comm.Parameters.AddWithValue("@supply_source_line_id", config.IsNull(.Item(i)("supply_source_line_id"), DBNull.Value))
                comm.Parameters.AddWithValue("@supply_source_lot_number", config.IsNull(.Item(i)("supply_source_lot_number"), DBNull.Value))
                comm.Parameters.AddWithValue("@supply_source_item_id", config.IsNull(.Item(i)("supply_source_item_id"), DBNull.Value))
                comm.Parameters.AddWithValue("@mtl_warehouse_id", config.IsNull(.Item(i)("mtl_warehouse_id"), DBNull.Value))
                comm.Parameters.AddWithValue("@mtl_subinventory_id", config.IsNull(.Item(i)("mtl_subinventory_id"), DBNull.Value))
                comm.Parameters.AddWithValue("@mtl_locations_id", config.IsNull(.Item(i)("mtl_locations_id"), DBNull.Value))
                comm.Parameters.AddWithValue("@p_machine_bar", config.IsNull(.Item(i)("machine_bar"), DBNull.Value))

                comm.Parameters.AddWithValue("@created_by", Userinfo.UserID)

                comm.Parameters.AddWithValue("@last_modified_by", Userinfo.UserID)
            End With
            ' Dim sql As String = config.BuildSQL(comm)
            Dim da = New SqlDataAdapter(comm)
            Dim dt = New DataTable
            Try
                da.Fill(dt)
            Catch ex As Exception
                msgerr = ex.Message
                tran.Rollback()
                conn.Close()
                Return False
            End Try

            Mtlreservations.StrreservationsNumber = dt.Rows(0)("reservations_number").ToString
            Mtlreservations.DataReservationsDate = dt.Rows(0)("reservations_date").ToString
        Next

        i = 0
        comm.CommandText = "P_WO_RESERVATIONS_PKG_delete_mtl_reservations"
        For i = 0 To DV_DEL.Count - 1
            With DV_DEL
                comm.Parameters.Clear()
                comm.Parameters.AddWithValue("@mtl_reservations_id", config.IsNull(.Item(i)("mtl_reservations_id"), DBNull.Value))
            End With

            Dim da = New SqlDataAdapter(comm)
            Dim dt = New DataTable
            Try
                da.Fill(dt)
            Catch ex As Exception
                msgerr = ex.Message
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
