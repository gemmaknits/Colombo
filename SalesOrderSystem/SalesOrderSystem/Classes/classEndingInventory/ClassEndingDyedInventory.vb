Imports System.Data
Imports System.Data.SqlClient
Imports System.Text
Public Class ClassEndingDyedInventory
    Public Function EndingDyedInventorySave(ByRef dtc As DataTable, ByRef Message As String) As Boolean
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

        comm.CommandText = "p_ending_dyed_inventory_update_strolls_d"
        j = 0
        For j = 0 To dtc.Rows.Count - 1
            With dtc.Rows
                'MsgBox(.Item(j)("box_remark").ToString) --Sitthana 18/07/2018
                comm.Parameters.Clear()
                comm.Parameters.AddWithValue("@id", config.IsNull(.Item(j)("id"), 0))
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
