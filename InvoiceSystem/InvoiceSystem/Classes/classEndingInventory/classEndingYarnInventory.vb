Imports System.Data
Imports System.Data.SqlClient
Imports System.Text
Public Class classEndingYarnInventory
    Public Structure Yarn_Header
        Dim dye_test As String
        Dim remark As String
        Dim msgerr As String
    End Structure

    Public Function EndingYarnInventoryDel(ByVal dtc As DataTable, ByVal dv_dtc_add As DataView, dv_dtc_upd As DataView, dv_dtc_del As DataView, ByRef Yarns_header As Yarn_Header)
        Dim config As New clsConfig
        Dim conn As New SqlConnection((New classConnection).connection)
        conn.Open()
        Dim tran As SqlTransaction = conn.BeginTransaction
        Dim comm As New SqlCommand("", conn)
        Dim i As Integer = 0
        Dim j As Integer = 0
        Dim strLotNo As String = ""
        Dim Action As String = ""
        comm.Transaction = tran
        comm.CommandType = CommandType.StoredProcedure

        'Start update Greige----------

        comm.CommandText = "p_ending_yarn_inventory_delete_tmp"
        j = 0
        For j = 0 To dv_dtc_del.Count - 1
            With dv_dtc_del
                comm.Parameters.Clear()
                comm.Parameters.AddWithValue("@id", config.IsNull(.Item(j)("id"), 0))
                'comm.Parameters.AddWithValue("@dyed", config.IsNull(.Item(j)("id"), 0))
                'comm.Parameters.AddWithValue("@rem_qc", .Item(j)("rem_qc"))

            End With

            Dim dac_upd = New SqlDataAdapter(comm)
            Dim dtc_upd = New DataTable
            Try
                dac_upd.Fill(dtc_upd)
            Catch ex As Exception
                Yarns_header.msgerr = ex.Message
                tran.Rollback()
                conn.Close()  'Sitthana 20190325
                Return False
            End Try
            Action = "CHANGE"
        Next
        'End update Greige----------

        tran.Commit()
        conn.Close()  'Sitthana 20190325
        Return True
    End Function

    Public Function EndingYarnInventorySave(ByRef dtc As DataTable, ByRef Message As String) As Boolean
        Dim config As New clsConfig
        Dim conn As New SqlConnection((New classConnection).connection)
        conn.Open()
        Dim tran As SqlTransaction = conn.BeginTransaction
        Dim comm As New SqlCommand("", conn)
        Dim i As Integer = 0
        Dim j As Integer = 0
        Dim strLotNo As String = ""
        Dim Action As String = ""
        comm.Transaction = tran
        comm.CommandType = CommandType.StoredProcedure

        comm.CommandText = "p_ending_yarn_inventory_update_yarn_in_det"
        j = 0
        For j = 0 To dtc.Rows.Count - 1
            With dtc.Rows
                comm.Parameters.Clear()
                comm.Parameters.AddWithValue("@id", config.IsNull(.Item(j)("id"), 0))
                comm.Parameters.AddWithValue("@dye_test_result", .Item(j)("dye_test_result"))
                comm.Parameters.AddWithValue("@box_remark", .Item(j)("box_remark"))
                comm.Parameters.AddWithValue("@loc", .Item(j)("loc"))
                comm.Parameters.AddWithValue("@mtl_locations_id", .Item(j)("mtl_locations_id"))
                comm.Parameters.AddWithValue("@logempcd", .Item(j)("logempcd"))
            End With
            Dim dac_upd = New SqlDataAdapter(comm)
            Dim dtc_upd = New DataTable
            Try
                dac_upd.Fill(dtc_upd)

            Catch ex As Exception
                Message = ex.Message
                tran.Rollback()
                conn.Close()  'Sitthana 20190325
                Return False
            End Try
            Action = "CHANGE"
        Next


        tran.Commit()
        conn.Close()  'Sitthana 20190325
        Return True
    End Function
End Class
