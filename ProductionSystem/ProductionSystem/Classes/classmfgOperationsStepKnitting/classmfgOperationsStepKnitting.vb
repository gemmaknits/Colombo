Imports System.Data
Imports System.Data.SqlClient
Imports System.Text
Public Structure MfgProdcutionsLots
    Dim StrProductionOrderNo As String
End Structure
Public Class classmfgOperationsStepKnitting

    Public Function Combomtlwarehouse() As DataTable
        Dim conn As New SqlConnection((New classConnection).connection)
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "p_mfg_operations_step_knitting_pkg_combo_mtl_warehouse"
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        conn.Close()  'Sitthana 20190325
        Return dt

    End Function

    Public Function ComboMtlsubinventory(Optional ByVal INt64mtl_warehouse_id As Nullable(Of Int64) = Nothing) As DataTable
        Dim conn As New SqlConnection((New classConnection).connection)
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "p_mfg_operations_step_knitting_pkg_combo_mtl_subinventory"
        comm.Parameters.AddWithValue("@mtl_warehouse_id", INt64mtl_warehouse_id)
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        conn.Close()  'Sitthana 20190325
        Return dt

    End Function

    Public Function Combomtllocations(Optional ByVal strUSerID As String = "", Optional ByVal INt64mtl_warehouse_id As Int64 = Nothing, Optional ByVal Int64mtl_subinventory_id As Int64 = Nothing) As DataTable
        Dim classconection As New classConnection
        Dim conn As New SqlConnection(classconection.connection)
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "p_mfg_operations_step_knitting_pkg_combo_mtl_locations"
        comm.Parameters.AddWithValue("@mtl_warehouse_id", INt64mtl_warehouse_id)
        comm.Parameters.AddWithValue("@mtl_subinventory_id", Int64mtl_subinventory_id)
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        conn.Close()  'Sitthana 20190325
        Return dt

    End Function

    Public Function GetMfgOperationStepKnitting(Optional ByVal IntMfgProductionLotsID As Nullable(Of Integer) = Nothing,
                                               Optional ByVal StrSystemLotNumber As String = Nothing,
                                               Optional ByVal IntmfgProductionStepsID As Nullable(Of Integer) = Nothing,
                                               Optional ByVal StrProductionOrderNo As String = Nothing,
                                               Optional ByVal Strlogempcd As String = Nothing) As DataTable
        Dim conn As New SqlConnection((New classConnection).connection)
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "p_mfg_operations_step_knitting_pkg_get_roll_details"
        comm.Parameters.AddWithValue("@mfg_production_lots_id", IntMfgProductionLotsID)  'Add @ By Sitthana 20180110'
        comm.Parameters.AddWithValue("@system_lot_number", StrSystemLotNumber)
        comm.Parameters.AddWithValue("@mfg_production_steps_id", IntmfgProductionStepsID)
        comm.Parameters.AddWithValue("@production_order_no", StrProductionOrderNo)
        comm.Parameters.AddWithValue("@logempcd", Strlogempcd)
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        'comm.Connection.Close()
        Try
            da.Fill(dt)
            conn.Close()  'Sitthana 20190325
        Catch ex As Exception
            conn.Close()  'Sitthana 20190325
            'ex.Message
        End Try

        Return dt
    End Function

    Public Function GetDefectRoll(Optional ByVal strrollNo As String = "", Optional ByVal strEmpCD As String = "") As DataTable
        Dim conn As New SqlConnection((New classConnection).connection)
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "p_mfg_operations_step_knitting_pkg_get_defect_roll"
        comm.Parameters.Clear()
        comm.Parameters.AddWithValue("@roll_no", strrollNo)
        comm.Parameters.AddWithValue("@logempcd", strEmpCD)
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        conn.Close()  'Sitthana 20190325
        Return (dt)

    End Function

    Public Function GetDefectRollNEW(Optional ByVal strrollNo As String = "", Optional ByVal strEmpCD As String = "") As DataTable '29/09/2025 John
        Dim conn As New SqlConnection((New classConnection).connection)
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "[dbo].[p_mfg_operations_step_knitting_pkg_get_defect_roll_NEW]"
        comm.Parameters.Clear()
        comm.Parameters.AddWithValue("@roll_no", strrollNo)
        comm.Parameters.AddWithValue("@logempcd", strEmpCD)
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        conn.Close()  'Sitthana 20190325
        Return (dt)

    End Function

End Class
