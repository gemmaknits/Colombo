Imports System.Data
Imports System.Data.SqlClient
Imports System.Text
Public Class classEndingGreigeInventory
    Public Structure Greige_Header

        'Greige
        Dim h01_suppcd As String
        Dim h02_source As String
        Dim h03_source_refno As String
        Dim h04_tran_no As String
        Dim h05_tran_dt As Date
        Dim h06_design_no As String
        Dim h07_supdes_no As String
        Dim h08_kono As String
        Dim h09_pieces As Double
        Dim h10_nob As Double
        Dim h11_Gwth As String
        Dim h12_Gwth_actual As String
        Dim h13_roll_no As String
        Dim h14_roll_no_g As String
        Dim h15_roll_no_n As Decimal
        Dim h16_racks As Double
        Dim h17_kg As Double
        Dim h18_mts As Double
        Dim h19_yds As Double
        Dim h20_kg_qc As Double
        Dim h21_mts_qc As Double
        Dim h22_yds_qc As Double
        Dim h23_grade As String
        Dim h24_rem_qc As String
        Dim h25_loc As String
        Dim h26_outreqno As String
        Dim h27_outreqdt As Nullable(Of Date)
        Dim h28_outreqtyp As String
        Dim h29_outno As String
        Dim h30_outdt As Nullable(Of Date)
        Dim h31_lot As String
        Dim h32_yr As String
        Dim h33_sh As String
        Dim h34_dfno As String
        Dim h35_col As String
        Dim h36_dhcod As String
        Dim h37_sono As String
        Dim h38_sonoid As String
        Dim h39_roll_no_o As String
        Dim h40_pn As Double
        Dim h41_ydkg_g As Double
        Dim h42_cost As Decimal
        Dim h43_fload As Boolean
        Dim h44_rate As Decimal
        Dim h45_sel As Boolean
        Dim h46_cost_g As Double
        Dim h47_cliped As Boolean
        Dim h48_unit As String
        Dim h49_g_cost As Double
        Dim h50_tran_no1 As String
        Dim h51_tran_not As String
        Dim h52_cancel As Boolean
        Dim h53_doctyp As String
        Dim h54_preseted As Boolean
        Dim h55_qcalertcd As String
        Dim h56_ProdFinishDate As Date
        Dim h57_ProdFinishTime As String
        Dim h58_mcno As String
        Dim h59_adjust_loss_kg As Double
        Dim h60_qc_loss_kg As Double
        Dim h61_dyed_loss_kg As Double
        Dim h62_grade_bdt As String
        Dim h63_grade_adt As String
        Dim h64_dyeing_pass As Boolean
        Dim h65_dyeing_fail As Boolean
        Dim h66_shift As String
        Dim h67_id_greige_do As Int64
        Dim h68_id_greige As Int64
        Dim h69_lab_loss_kg As Double
        Dim h70_defect_loss_kg As Double
        Dim h71_purno As String
        Dim h72_tran_type As String
        Dim h73_roll_no_f As String
        Dim h74_job_line_id As String
        Dim h75_fabric_cost As Double
        Dim h76_process_cost As Double
        Dim h77_process_loss_perc As Double
        Dim h78_other_cost As Double
        Dim h79_cost_per_unit As Double
        Dim h80_sub_location As String
        Dim h81_greige_status As Byte
        Dim h82_bar_weight As Double

        Dim msgerr As String
        'strolls_d
    End Structure

    Public Function EndingGreigeInventorySave(ByVal dtc As DataTable, ByRef Greige_header As Greige_Header, ByRef clsuser As classUserInfo)
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

        comm.CommandText = "p_ending_greige_inventory_update_tmp"
        j = 0
        For j = 0 To dtc.Rows.Count - 1
            With dtc.Rows
                comm.Parameters.Clear()
                comm.Parameters.AddWithValue("@roll_no", config.IsNull(.Item(j)("roll_no"), "").trim)
                comm.Parameters.AddWithValue("@rem_qc", .Item(j)("rem_qc"))
                comm.Parameters.AddWithValue("@logempcd", clsuser.UserID)
            End With

            Dim dac_upd = New SqlDataAdapter(comm)
            Dim dtc_upd = New DataTable
            Try
                dac_upd.Fill(dtc_upd)
            Catch ex As Exception
                Greige_header.msgerr = ex.Message
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
End Class

