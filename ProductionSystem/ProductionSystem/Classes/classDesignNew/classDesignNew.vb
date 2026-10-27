Imports System.Data
Imports System.Data.SqlClient
Imports System.Text

'=====================================================================
' classDesignNew : data work of frmDesignNew (created 16/10/2026)
' The two functions below were moved here from classMaster and classMasterUpdate on 16/10/2026, the code is unchanged:
'   getDesignMasterRecord : read one Design Master record      (was classMaster.getDesignMasterRecord)
'   DesignMasterNewSave   : save one Design Master record      (was classMasterUpdate.DesignMasterNewSave)
' Send to GMK / sync to GMK (merged here from classDesignSyncToGMK on 16/10/2026): see the section below. Screen work (messages, confirmation window) stays in the form.
'=====================================================================
Public Class classDesignNew
    Public Function getDesignMasterRecord(Optional ByVal ItemID As String = "", Optional ByVal DesignNo As String = "") As DataTable
        Dim conn As New SqlConnection((New classConnection).connection)
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "p_design_master_new_pkg_select_master_record"
        comm.Parameters.AddWithValue("@p_item_id", ItemID)
        comm.Parameters.AddWithValue("@p_design_no", DesignNo)
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        conn.Close()  'Sitthana 20190325
        Return dt
    End Function

    'New Procedure in Gemmaknits   -- Sitthana 13/03/2018
    Public Function DesignMasterNewSave(ByVal drvDesignMaster As DataRowView, ByVal LoginEmpCD As String) As DataTable
        Dim config As New clsConfig
        Dim conn As New SqlConnection((New classConnection).connection)
        conn.Open()
        Dim tran As SqlTransaction = conn.BeginTransaction
        Dim comm As New SqlCommand("", conn)
        Dim i As Integer = 0
        Dim strLotNo As String = ""
        comm.Transaction = tran
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "p_design_master_new_pkg_update_master_record"

        comm.Parameters.AddWithValue("@p_dm_item_id", drvDesignMaster("dm_item_id"))
        comm.Parameters.AddWithValue("@p_dm_Design_no", drvDesignMaster("dm_design_no"))
        comm.Parameters.AddWithValue("@p_dm_compo", drvDesignMaster("dm_compo"))
        comm.Parameters.AddWithValue("@p_dm_compo_for_tag", drvDesignMaster("dm_compo_for_tag")) 'Add by Neung 20200302
        comm.Parameters.AddWithValue("@p_dm_rem", drvDesignMaster("dm_rem"))
        comm.Parameters.AddWithValue("@p_dm_supdes_no", drvDesignMaster("dm_supdes_no"))
        comm.Parameters.AddWithValue("@p_dm_cust_design_no", drvDesignMaster("dm_cust_design_no"))
        comm.Parameters.AddWithValue("@p_dm_refdesno", drvDesignMaster("dm_refdesno"))
        comm.Parameters.AddWithValue("@p_log_empcd", LoginEmpCD)
        comm.Parameters.AddWithValue("@p_dm_fin_id", drvDesignMaster("dm_fin_id"))
        comm.Parameters.AddWithValue("@p_dm_parent_design", drvDesignMaster("dm_parent_design"))
        comm.Parameters.AddWithValue("@p_dm_design_family", config.IsNull(drvDesignMaster("dm_design_family"), String.Empty))
        comm.Parameters.AddWithValue("@p_dm_mtl_inventory_types_id", drvDesignMaster("dm_mtl_inventory_types_id"))

        comm.Parameters.AddWithValue("@p_ds_fwth", drvDesignMaster("ds_fwth"))
        comm.Parameters.AddWithValue("@p_ds_nob", drvDesignMaster("ds_nob"))
        comm.Parameters.AddWithValue("@p_ds_usewth", drvDesignMaster("ds_usewth"))
        comm.Parameters.AddWithValue("@p_ds_mtkg", drvDesignMaster("ds_mtkg"))
        comm.Parameters.AddWithValue("@p_ds_Needle", drvDesignMaster("ds_needle"))
        comm.Parameters.AddWithValue("@p_ds_gmpersqm", drvDesignMaster("ds_gmpersqm"))
        comm.Parameters.AddWithValue("@p_ds_cpi", drvDesignMaster("ds_cpi"))
        comm.Parameters.AddWithValue("@p_ds_wpi", drvDesignMaster("ds_wpi"))
        comm.Parameters.AddWithValue("@p_ds_kg_per_roll", drvDesignMaster("ds_kg_per_roll"))
        comm.Parameters.AddWithValue("@p_ds_mts_per_roll", drvDesignMaster("ds_mts_per_roll"))
        comm.Parameters.AddWithValue("@p_ds_kg_per_day", drvDesignMaster("ds_kg_per_day"))
        comm.Parameters.AddWithValue("@p_ds_kg_per_meter", drvDesignMaster("ds_kg_per_meter"))
        comm.Parameters.AddWithValue("@p_ds_meters_per_day", drvDesignMaster("ds_meters_per_day"))
        comm.Parameters.AddWithValue("@p_ds_hours_per_day", drvDesignMaster("ds_hours_per_day"))
        comm.Parameters.AddWithValue("@p_ds_counter_per_roll", drvDesignMaster("ds_counter_per_roll"))
        comm.Parameters.AddWithValue("@p_ds_rpm", drvDesignMaster("ds_rpm"))
        comm.Parameters.AddWithValue("@p_ds_elongation", drvDesignMaster("ds_elongation"))
        comm.Parameters.AddWithValue("@p_ds_modulus", drvDesignMaster("ds_modulus"))
        comm.Parameters.AddWithValue("@p_ds_mtkg_edge", drvDesignMaster("ds_mtkg_edge"))
        comm.Parameters.AddWithValue("@p_ds_mtkg_useable", drvDesignMaster("ds_mtkg_useable"))
        comm.Parameters.AddWithValue("@p_ds_machine_group_id", drvDesignMaster("ds_machine_group_id"))
        comm.Parameters.AddWithValue("@p_ds_edge_cut_wth", drvDesignMaster("ds_edge_cut_wth"))

        comm.Parameters.AddWithValue("@p_ds_elasticity_length", drvDesignMaster("ds_elasticity_length"))
        comm.Parameters.AddWithValue("@p_ds_elasticity_width", drvDesignMaster("ds_elasticity_width"))
        comm.Parameters.AddWithValue("@p_ds_modulus_length", drvDesignMaster("ds_modulus_length"))
        comm.Parameters.AddWithValue("@p_ds_modulus_width", drvDesignMaster("ds_modulus_width"))
        comm.Parameters.AddWithValue("@p_ds_brust", drvDesignMaster("ds_brust"))
        comm.Parameters.AddWithValue("@p_ds_shrinkage_centigrade", drvDesignMaster("ds_shrinkage_centigrade"))
        comm.Parameters.AddWithValue("@p_ds_shrinkage_length", drvDesignMaster("ds_shrinkage_length"))
        comm.Parameters.AddWithValue("@p_ds_shrinkage_width", drvDesignMaster("ds_shrinkage_width"))
        comm.Parameters.AddWithValue("@p_ds_pairs_per_meter", drvDesignMaster("ds_pairs_per_meter"))
        comm.Parameters.AddWithValue("@p_ds_shoe_size", drvDesignMaster("ds_shoe_size"))
        comm.Parameters.AddWithValue("@p_ds_shoe_style", drvDesignMaster("ds_shoe_style"))
        comm.Parameters.AddWithValue("@p_ds_shoe_length_cm", drvDesignMaster("ds_shoe_length_cm"))
        comm.Parameters.AddWithValue("@p_ds_shoe_width_cm", drvDesignMaster("ds_shoe_width_cm"))

        comm.Parameters.AddWithValue("@p_ds_pallet_pattern_no", drvDesignMaster("ds_pallet_pattern_no"))
        comm.Parameters.AddWithValue("@p_ds_product_pattern_no", drvDesignMaster("ds_product_pattern_no"))
        comm.Parameters.AddWithValue("@p_ds_sh_grams_per_row", drvDesignMaster("ds_sh_grams_per_row"))
        comm.Parameters.AddWithValue("@p_ds_sh_length_cm_per_repeat", drvDesignMaster("ds_sh_length_cm_per_repeat"))
        comm.Parameters.AddWithValue("@p_ds_sh_length_cm_mark_to_mark", drvDesignMaster("ds_sh_length_cm_mark_to_mark"))
        comm.Parameters.AddWithValue("@p_ds_sh_width_cm_mark_to_mark", drvDesignMaster("ds_sh_width_cm_mark_to_mark"))
        comm.Parameters.AddWithValue("@p_ds_sh_needle_width_cm", drvDesignMaster("ds_sh_needle_width_cm"))
        comm.Parameters.AddWithValue("@p_ds_sh_pattern_area", drvDesignMaster("ds_sh_pattern_area"))

        comm.Parameters.AddWithValue("@p_ds_sh_grams_of_lasercut_pc", drvDesignMaster("ds_sh_grams_of_lasercut_pc"))
        comm.Parameters.AddWithValue("@p_ds_sh_grams_of_lasercut_pair", drvDesignMaster("ds_sh_grams_of_lasercut_pair"))

        comm.Parameters.AddWithValue("@p_ds_sh_pcs_fabric_needle_width", drvDesignMaster("ds_sh_pcs_fabric_needle_width"))
        comm.Parameters.AddWithValue("@p_ds_sh_pcs_fabric_edge_to_edge", drvDesignMaster("ds_sh_pcs_fabric_edge_to_edge"))

        comm.Parameters.AddWithValue("@p_ds_sh_rows_per_meter", drvDesignMaster("ds_sh_rows_per_meter"))
        comm.Parameters.AddWithValue("@p_ds_sh_pairs_per_repeat_of_fabric_width", drvDesignMaster("ds_sh_pairs_per_repeat_of_fabric_width"))

        comm.Parameters.AddWithValue("@p_ds_sh_fabric_grams_with_pattern", drvDesignMaster("ds_sh_fabric_grams_with_pattern"))
        comm.Parameters.AddWithValue("@p_ds_sh_fabric_grams_without_pattern", drvDesignMaster("ds_sh_fabric_grams_without_pattern"))

        comm.Parameters.AddWithValue("@p_ds_foremb", drvDesignMaster("ds_foremb")) 'Sitthana 23/03/2018
        comm.Parameters.AddWithValue("@p_ds_tensile_strength", drvDesignMaster("ds_tensile_strength"))
        comm.Parameters.AddWithValue("@p_ds_piling", drvDesignMaster("ds_piling"))
        comm.Parameters.AddWithValue("@p_ds_snagging", drvDesignMaster("ds_snagging"))
        comm.Parameters.AddWithValue("@p_ds_sh_repeat_per_day", drvDesignMaster("ds_sh_repeat_per_day"))
        comm.Parameters.AddWithValue("@p_ds_shoe_gender_id", drvDesignMaster("ds_shoe_gender_id"))
        comm.Parameters.AddWithValue("@p_ds_sh_minutes_per_repeat", drvDesignMaster("ds_sh_minutes_per_repeat"))
        comm.Parameters.AddWithValue("@p_ds_sh_pairs_per_day", drvDesignMaster("ds_sh_pairs_per_day"))
        comm.Parameters.AddWithValue("@p_ds_shoe_country_id", drvDesignMaster("ds_shoe_country_id"))
        comm.Parameters.AddWithValue("@p_dm_fabric_type_id", drvDesignMaster("dm_fabric_type_id"))

        '------------------------ Sitthana 15/03/2018
        comm.Parameters.AddWithValue("@p_ds_fwth_min", drvDesignMaster("ds_Fwth_min"))
        comm.Parameters.AddWithValue("@p_ds_fwth_max", drvDesignMaster("ds_Fwth_max"))
        comm.Parameters.AddWithValue("@p_ds_edge_min", drvDesignMaster("ds_Edge_min"))
        comm.Parameters.AddWithValue("@p_ds_edge_max", drvDesignMaster("ds_Edge_max"))
        comm.Parameters.AddWithValue("@p_ds_usewth_min", drvDesignMaster("ds_Usewth_min"))
        comm.Parameters.AddWithValue("@p_ds_usewth_max", drvDesignMaster("ds_Usewth_max"))
        comm.Parameters.AddWithValue("@p_ds_cpi_remark", drvDesignMaster("ds_cpi_remark"))
        comm.Parameters.AddWithValue("@p_ds_wpi_remark", drvDesignMaster("ds_wpi_remark"))
        comm.Parameters.AddWithValue("@p_ds_gmpersqm_min", drvDesignMaster("ds_gmpersqm_min"))
        comm.Parameters.AddWithValue("@p_ds_gmpersqm_max", drvDesignMaster("ds_gmpersqm_max"))
        comm.Parameters.AddWithValue("@p_ds_shrinkage_length_min", drvDesignMaster("ds_shrinkage_length_min"))
        comm.Parameters.AddWithValue("@p_ds_shrinkage_length_max", drvDesignMaster("ds_shrinkage_length_max"))
        comm.Parameters.AddWithValue("@p_ds_shrinkage_width_min", drvDesignMaster("ds_shrinkage_width_min"))
        comm.Parameters.AddWithValue("@p_ds_shrinkage_width_max", drvDesignMaster("ds_shrinkage_width_max"))
        comm.Parameters.AddWithValue("@p_ds_elongation_length_min", drvDesignMaster("ds_elongation_length_min"))
        comm.Parameters.AddWithValue("@p_ds_elongation_length_max", drvDesignMaster("ds_elongation_length_max"))
        comm.Parameters.AddWithValue("@p_ds_elongation_width_min", drvDesignMaster("ds_elongation_width_min"))
        comm.Parameters.AddWithValue("@p_ds_elongation_width_max", drvDesignMaster("ds_elongation_width_max"))
        comm.Parameters.AddWithValue("@p_ds_modulus_length_min", drvDesignMaster("ds_modulus_length_min"))
        comm.Parameters.AddWithValue("@p_ds_modulus_length_max", drvDesignMaster("ds_modulus_length_max"))
        comm.Parameters.AddWithValue("@p_ds_modulus_width_min", drvDesignMaster("ds_modulus_width_min"))
        comm.Parameters.AddWithValue("@p_ds_modulus_width_max", drvDesignMaster("ds_modulus_width_max"))
        ''--------------------------------------------
        '------------------------ Sitthana 25/04/2018
        comm.Parameters.AddWithValue("@p_ds_thickness", drvDesignMaster("ds_thickness"))
        comm.Parameters.AddWithValue("@p_ds_thickness_tolerance", drvDesignMaster("ds_thickness_tolerance"))
        comm.Parameters.AddWithValue("@p_ds_thickness_tolerance_sign", drvDesignMaster("ds_thickness_tolerance_sign"))

        '----- Sitthana 21/05/2018
        comm.Parameters.AddWithValue("@p_ds_tongue_weight", drvDesignMaster("ds_tongue_weight"))
        comm.Parameters.AddWithValue("@p_ds_tongue_width", drvDesignMaster("ds_tongue_width"))
        comm.Parameters.AddWithValue("@p_ds_tongue_length", drvDesignMaster("ds_tongue_length"))
        comm.Parameters.AddWithValue("@p_ds_tongue_center_Mark_Length", drvDesignMaster("ds_tongue_center_Mark_Length"))
        ''comm.Parameters.AddWithValue("@p_ds_tongue_center_Mark_Length", drvDesignMaster("ds_tongue_center_Mark_Length"))--------------------------------------------
        comm.Parameters.AddWithValue("@p_ds_design_gauge", drvDesignMaster("dm_design_gauge")) 'Sitthana 20181203
        comm.Parameters.AddWithValue("@p_dm_spec_status", drvDesignMaster("dm_spec_status"))
        comm.Parameters.AddWithValue("@p_dm_spec_version", drvDesignMaster("dm_spec_version"))
        comm.Parameters.AddWithValue("@p_dm_spec_approved_date", drvDesignMaster("dm_spec_approved_date"))
        comm.Parameters.AddWithValue("@p_dm_spec_approved_by", drvDesignMaster("dm_spec_approved_by"))

        '----- Sitthana 12/12/2023
        comm.Parameters.AddWithValue("@p_stitch_note_suk90", drvDesignMaster("stitch_note_suk90"))
        comm.Parameters.AddWithValue("@p_stitch_note_tr005", drvDesignMaster("stitch_note_tr005"))
        comm.Parameters.AddWithValue("@p_stitch_note_1str", drvDesignMaster("stitch_note_1str"))
        comm.Parameters.AddWithValue("@p_stitch_note_2str", drvDesignMaster("stitch_note_2str"))


        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        Try
            da.Fill(dt)
        Catch ex As Exception
            tran.Rollback()
            conn.Close()  'Sitthana 20190325
            Throw ex
        End Try
        tran.Commit()
        conn.Close()  'Sitthana 20190325
        Return dt
    End Function

    'End Procedure in Gemmaknits   -- Sitthana 13/03/2018


    '--------------------------------------------------------------------
    ' SYNC TO GMK (merged here from classDesignSyncToGMK on 16/10/2026)
    '--------------------------------------------------------------------
    '=====================================================================
    ' Sync Design Master : Eschler -> GMK (one-way)
    ' Created : 16/10/2026
    '
    ' Flow (called from frmDesignNew after Eschler saved successfully):
    '   1. Find the same Design No. in GMK (p_design_master_new_pkg_select_master_record)
    '   2. Map the values that are different between the two companies
    '   3. Call the GMK procedure p_design_master_new_pkg_update_master_record in one transaction
    '   4. If GMK fails  -> Eschler data is kept and the user gets a message (InsertOnly: saving the design again tries again)
    '      If a value could not be mapped -> the user gets a message listing the values that were not sent
    '
    ' Mapping rules (agreed with the user 16/10/2026):
    '   - Machine group      : never sent (GMK keeps its own value, new design = NULL)
    '   - Finishing group    : matched by fin_code, not by fin_id
    '                          codes 15, 16, 41, 22-M and codes that GMK does not have are not sent
    '                          (GMK keeps its own value, new design = 0) and the user is warned
    '   - Fabric type        : ids that GMK does not have (e.g. INNER) are not sent (GMK keeps its own value, new design = NULL)
    '   - Spec status/version/approval : not sent (GMK decides by itself)
    '   - Roll handling / width type / repeat free length : GMK only fields, never sent from Eschler
    ' Mode (returned by the procedure P_DESIGN_MASTER_NEW_PKG_sync_get_mode in the Eschler database, no app.config needed):
    '   Off             : sync disabled (also used when the mode cannot be read)
    '   InsertOnly      : phase 1, only designs that do not exist in GMK are created; existing GMK designs are never changed
    '   InsertAndUpdate : phase 2, existing GMK designs are updated too (mapping rules above apply)
    ' The GMK database follows the Eschler database: *Test -> gemmasoftTest, otherwise Gemmasoft
    '=====================================================================


    Public Class SyncResult
        Public DesignNo As String = ""
        Public Success As Boolean = False
        Public IsNewInGmk As Boolean = False
        Public Skipped As Boolean = False   'InsertOnly mode and the design already exists in GMK: nothing was sent
        Public GmkItemId As Long = 0
        Public Message As String = ""
        Public Warnings As New List(Of String)
    End Class

    Private Const SpSave As String = "p_design_master_new_pkg_update_master_record"

    'Finishing codes that exist in both companies but have different meanings
    Private Shared ReadOnly AmbiguousFinCodes As String() = New String() {"15", "16", "41", "22-M"}
    'Fields owned by GMK only: never taken from Eschler (update = keep GMK value, insert = SP default)
    Private Shared ReadOnly GmkOwnedParams As String() = New String() {"ds_machine_group_id", "ds_width_type", "ds_rpt_free_length_cm", "roll_handling_id"}
    'Spec status is decided at GMK, so it is not sent
    Private Shared ReadOnly NotSentParams As String() = New String() {"dm_spec_status", "dm_spec_version", "dm_spec_approved_date", "dm_spec_approved_by"}

    'GMK server (same style as the other connection classes in this project)
    Private Const GmkServer As String = "172.16.3.4"
    Private Const GmkUserId As String = "sa"
    Private Const GmkPassword As String = "sql@min"

    Private Const ModeOff As String = "off"
    Private Const ModeInsertOnly As String = "insertonly"
    Private Const ModeInsertAndUpdate As String = "insertandupdate"

    'The sync mode is returned by the procedure P_DESIGN_MASTER_NEW_PKG_sync_get_mode in the Eschler database
    '(change it with ALTER PROCEDURE, it applies to every computer at once):
    '  Off             = sync is disabled
    '  InsertOnly      = phase 1, only designs that do not exist in GMK yet are created, designs already in GMK are never touched
    '  InsertAndUpdate = phase 2, designs that exist in GMK are updated too
    'If the procedure cannot be read, or returns an unknown value, the safe mode Off is used.
    Private Function GetSyncMode() As String
        Try
            Using c As New SqlConnection((New classConnection).connection)
                c.Open()
                Using cmd As New SqlCommand("P_DESIGN_MASTER_NEW_PKG_sync_get_mode", c)
                    cmd.CommandType = CommandType.StoredProcedure
                    Dim o As Object = cmd.ExecuteScalar()
                    If o IsNot Nothing AndAlso Not IsDBNull(o) Then
                        Dim m As String = o.ToString().Trim().ToLower()
                        If m = ModeInsertOnly OrElse m = ModeInsertAndUpdate Then Return m
                    End If
                End Using
            End Using
        Catch
        End Try
        Return ModeOff
    End Function

    Public Function IsEnabled() As Boolean
        Return GetSyncMode() <> ModeOff
    End Function

    'The GMK database follows the Eschler database: *Test -> gemmasoftTest, otherwise Gemmasoft
    Private Function GmkConnectionString() As String
        Dim db As String = "Gemmasoft"
        If classConnection.database.Trim().ToLower().EndsWith("test") Then db = "gemmasoftTest"
        Return "Data Source=" & GmkServer & ";Initial Catalog=" & db & ";User ID=" & GmkUserId & ";pwd=" & GmkPassword & ";Connect Timeout=15"
    End Function

    '------------------------------------------------------------------
    ' Called after Eschler save. Returns a message for the user, or "" when everything is fine.
    '------------------------------------------------------------------
    Public Function SyncAfterSave(ByVal row As DataRow, ByVal userId As String) As String
        Dim res As SyncResult = SyncDesign(row, userId, False)   'mode Off is handled inside (nothing is sent)

        If Not res.Success Then
            'Eschler is already saved. In InsertOnly mode the design is still missing in GMK, so saving it again in Eschler will try again.
            Return "บันทึกข้อมูลที่ Eschler สำเร็จแล้ว แต่ส่งข้อมูลไป GMK ไม่สำเร็จ" & vbCrLf & _
                   "ลองกดบันทึกอีกครั้งภายหลัง หรือแจ้งผู้ดูแลระบบ" & vbCrLf & vbCrLf & res.Message
        End If

        If res.Warnings.Count > 0 Then
            Return "ส่งข้อมูลไป GMK แล้ว แต่มีค่าที่ไม่ได้ส่ง/ต้องให้ผู้ดูแลตรวจสอบ:" & vbCrLf & String.Join(vbCrLf, res.Warnings.ToArray())
        End If
        Return ""
    End Function

    '------------------------------------------------------------------
    ' Send one design to GMK. dryRun = True runs everything but rolls the GMK transaction back (for testing).
    '------------------------------------------------------------------
    ' forceUpdate = True is used by the "Send to GMK" button: a design that already exists in GMK is updated even in InsertOnly mode
    ' (the user asked for it and has seen the differences). Mode Off still sends nothing.
    Public Function SyncDesign(ByVal row As DataRow, ByVal userId As String, Optional ByVal dryRun As Boolean = False, Optional ByVal forceUpdate As Boolean = False) As SyncResult
        Dim res As New SyncResult
        Try
            Dim designNo As String = row("dm_design_no").ToString().Trim()
            res.DesignNo = designNo
            If designNo = "" Then Throw New Exception("Design No. is empty")

            Dim mode As String = GetSyncMode()
            If mode = ModeOff Then
                'sync is disabled: nothing is sent and the user is not bothered
                res.Skipped = True
                res.Success = True
                Return res
            End If

            Using conn As New SqlConnection(GmkConnectionString())
                conn.Open()
                Dim tran As SqlTransaction = conn.BeginTransaction()
                Try
                    Dim existing As DataRow = GetGmkRecord(conn, tran, designNo)
                    res.IsNewInGmk = (existing Is Nothing)

                    If existing IsNot Nothing AndAlso mode = ModeInsertOnly AndAlso Not forceUpdate Then
                        'Phase 1: the design already exists in GMK, leave GMK data as it is
                        tran.Rollback()
                        res.Skipped = True
                        res.Success = True
                        Return res
                    End If

                    Dim comm As SqlCommand = BuildSaveCommand(conn, tran, row, existing, designNo, userId, res)
                    Dim dt As New DataTable
                    Dim da As New SqlDataAdapter(comm)
                    da.Fill(dt)
                    If dt.Rows.Count > 0 Then res.GmkItemId = CLng(dt.Rows(0)("dm_item_id"))

                    If dryRun Then
                        tran.Rollback()
                    Else
                        tran.Commit()
                    End If
                    res.Success = True
                Catch
                    Try
                        tran.Rollback()
                    Catch
                    End Try
                    Throw
                End Try
            End Using
        Catch ex As Exception
            res.Success = False
            res.Message = ex.Message
        End Try
        Return res
    End Function

    '------------------------------------------------------------------
    ' "Send to GMK" button
    '------------------------------------------------------------------
    Public Class DiffItem
        Public Field As String = ""
        Public GmkValue As String = ""
        Public EschlerValue As String = ""
    End Class

    Public Class DiffResult
        Public Disabled As Boolean = False        'mode Off: the sync is switched off
        Public ExistsInGmk As Boolean = False
        Public ErrorMessage As String = ""
        Public Items As New List(Of DiffItem)
        Public Warnings As New List(Of String)
    End Class

    'Send the design to GMK because the user pressed the button (create if missing, otherwise update).
    Public Function SendToGMK(ByVal row As DataRow, ByVal userId As String) As SyncResult
        Return SyncDesign(row, userId, False, True)
    End Function

    'Preview only: list the values that would be changed in GMK. Nothing is written (the GMK transaction is always rolled back).
    Public Function GetDifferences(ByVal row As DataRow, ByVal userId As String) As DiffResult
        Dim d As New DiffResult
        Try
            If GetSyncMode() = ModeOff Then
                d.Disabled = True
                Return d
            End If

            Dim designNo As String = row("dm_design_no").ToString().Trim()
            Using conn As New SqlConnection(GmkConnectionString())
                conn.Open()
                Dim tran As SqlTransaction = conn.BeginTransaction()
                Try
                    Dim existing As DataRow = GetGmkRecord(conn, tran, designNo)
                    d.ExistsInGmk = (existing IsNot Nothing)

                    If existing IsNot Nothing Then
                        Dim res As New SyncResult
                        Dim comm As SqlCommand = BuildSaveCommand(conn, tran, row, existing, designNo, userId, res)
                        d.Warnings.AddRange(res.Warnings)

                        For Each p As SqlParameter In comm.Parameters
                            If p.Direction = ParameterDirection.ReturnValue Then Continue For
                            Dim key As String = p.ParameterName.Substring(1)
                            If key.ToLower().StartsWith("p_") Then key = key.Substring(2)
                            Dim lkey As String = key.ToLower()
                            If lkey = "dm_item_id" OrElse lkey = "dm_design_no" OrElse lkey = "log_empcd" Then Continue For

                            Dim col As String = key
                            If lkey = "ds_design_gauge" Then col = "dm_design_gauge"
                            If Not existing.Table.Columns.Contains(col) Then Continue For

                            Dim gmkText As String = ValueText(existing(col))
                            Dim eschText As String = ValueText(p.Value)
                            If SameValue(gmkText, eschText) Then Continue For

                            Dim item As New DiffItem
                            item.Field = FieldLabel(col)
                            If lkey = "dm_fin_id" Then
                                item.GmkValue = FinishingText(conn, tran, existing(col))
                                item.EschlerValue = FinishingText(conn, tran, p.Value)
                            ElseIf lkey = "dm_fabric_type_id" Then
                                item.GmkValue = FabricTypeText(conn, tran, existing(col))
                                item.EschlerValue = FabricTypeText(conn, tran, p.Value)
                            Else
                                item.GmkValue = gmkText
                                item.EschlerValue = eschText
                            End If
                            d.Items.Add(item)
                        Next
                    End If
                Finally
                    Try
                        tran.Rollback()
                    Catch
                    End Try
                End Try
            End Using
        Catch ex As Exception
            d.ErrorMessage = ex.Message
        End Try
        Return d
    End Function

    Private Function ValueText(ByVal o As Object) As String
        If o Is Nothing OrElse IsDBNull(o) Then Return ""
        If TypeOf o Is DateTime Then Return CDate(o).ToString("yyyy-MM-dd HH:mm")
        Return Convert.ToString(o, Globalization.CultureInfo.InvariantCulture).Trim()
    End Function

    'Same text, or the same number written differently (e.g. 1.50 and 1.5), or empty and zero (GMK shows an empty number as 0)
    Private Function SameValue(ByVal a As String, ByVal b As String) As Boolean
        If a = b Then Return True
        If a = "" Then a = "0"
        If b = "" Then b = "0"
        Dim x As Decimal, y As Decimal
        If Decimal.TryParse(a, Globalization.NumberStyles.Any, Globalization.CultureInfo.InvariantCulture, x) AndAlso _
           Decimal.TryParse(b, Globalization.NumberStyles.Any, Globalization.CultureInfo.InvariantCulture, y) Then
            Return x = y
        End If
        Return False
    End Function

    'Finishing/fabric values are GMK ids at this point: show the code/name instead of the id
    Private Function FinishingText(ByVal conn As SqlConnection, ByVal tran As SqlTransaction, ByVal id As Object) As String
        If id Is Nothing OrElse IsDBNull(id) OrElse CLng(id) = 0 Then Return "-"
        Dim cmd As New SqlCommand("SELECT RTRIM(fin_code) + ' ' + RTRIM(ISNULL(fin_desc, '')) FROM finishing_group WHERE fin_id = @id", conn, tran)
        cmd.Parameters.AddWithValue("@id", CLng(id))
        Dim o As Object = cmd.ExecuteScalar()
        If o Is Nothing OrElse IsDBNull(o) Then Return id.ToString()
        Return o.ToString().Trim()
    End Function

    Private Function FabricTypeText(ByVal conn As SqlConnection, ByVal tran As SqlTransaction, ByVal id As Object) As String
        If id Is Nothing OrElse IsDBNull(id) OrElse CLng(id) = 0 Then Return "-"
        Dim cmd As New SqlCommand("SELECT RTRIM(lookup_value) FROM lookup_values WHERE lookup_value_id = @id", conn, tran)
        cmd.Parameters.AddWithValue("@id", CLng(id))
        Dim o As Object = cmd.ExecuteScalar()
        If o Is Nothing OrElse IsDBNull(o) Then Return id.ToString()
        Return o.ToString().Trim()
    End Function

    'Readable names for the common fields, the column name is shown for the others
    Private Function FieldLabel(ByVal col As String) As String
        Select Case col.ToLower()
            Case "dm_compo" : Return "Composition"
            Case "dm_compo_for_tag" : Return "Composition for tag"
            Case "dm_rem" : Return "Remark"
            Case "dm_supdes_no" : Return "Supplier design no."
            Case "dm_cust_design_no" : Return "Customer design no."
            Case "dm_refdesno" : Return "Article name"
            Case "dm_fin_id" : Return "Finishing"
            Case "dm_parent_design" : Return "Knitting design"
            Case "dm_design_family" : Return "Design family"
            Case "dm_mtl_inventory_types_id" : Return "Inventory type"
            Case "dm_fabric_type_id" : Return "Fabric type"
            Case "dm_design_gauge" : Return "Design gauge"
            Case "ds_fwth" : Return "Width - full"
            Case "ds_usewth" : Return "Width - useable"
            Case "ds_edge_cut_wth" : Return "Edge cut width"
            Case "ds_nob" : Return "No. of bands"
            Case "ds_gmpersqm" : Return "Gm/Sq.m"
            Case "ds_kg_per_roll" : Return "Kg/Roll"
            Case "ds_mts_per_roll" : Return "Mts/Roll"
            Case "ds_mtkg" : Return "m/kg (full width)"
            Case "ds_mtkg_edge" : Return "m/kg (edge cut)"
            Case "ds_mtkg_useable" : Return "m/kg (useable width)"
            Case "ds_kg_per_meter" : Return "Kg/Meter"
            Case "ds_kg_per_day" : Return "Kg/Day"
            Case "ds_meters_per_day" : Return "Meters/Day"
            Case "ds_hours_per_day" : Return "Hours/Day"
            Case "ds_counter_per_roll" : Return "Counter per roll"
            Case "ds_needle" : Return "Needles"
            Case "ds_rpm" : Return "RPM"
            Case "ds_cpi" : Return "CPI"
            Case "ds_wpi" : Return "WPI"
            Case "ds_cpi_remark" : Return "CPI remark"
            Case "ds_wpi_remark" : Return "WPI remark"
            Case "ds_elongation" : Return "Elongation"
            Case "ds_modulus" : Return "Modulus"
            Case "ds_shrinkage_centigrade" : Return "Shrinkage (degC)"
            Case "ds_thickness" : Return "Thickness"
            Case "ds_thickness_tolerance" : Return "Thickness tolerance"
            Case "ds_piling" : Return "Piling"
            Case "ds_snagging" : Return "Snagging"
            Case "ds_brust" : Return "Bursting"
            Case "ds_foremb" : Return "For embroideries"
            Case Else : Return col
        End Select
    End Function

    'Find the design in GMK by Design No. (not by item_id, ids are different in the two databases)
    Private Function GetGmkRecord(ByVal conn As SqlConnection, ByVal tran As SqlTransaction, ByVal designNo As String) As DataRow
        Dim comm As New SqlCommand("p_design_master_new_pkg_select_master_record", conn, tran)
        comm.CommandType = CommandType.StoredProcedure
        comm.Parameters.AddWithValue("@p_item_id", DBNull.Value)
        comm.Parameters.AddWithValue("@p_design_no", designNo)
        Dim dt As New DataTable
        Dim da As New SqlDataAdapter(comm)
        da.Fill(dt)
        For Each r As DataRow In dt.Rows
            If r("dm_design_no").ToString().Trim().ToUpper() = designNo.ToUpper() Then Return r
        Next
        Return Nothing
    End Function

    'Build the GMK save command: read the parameter list from the GMK procedure itself, then fill each one
    Private Function BuildSaveCommand(ByVal conn As SqlConnection, ByVal tran As SqlTransaction, ByVal row As DataRow, _
                                      ByVal existing As DataRow, ByVal designNo As String, ByVal userId As String, _
                                      ByVal res As SyncResult) As SqlCommand
        Dim comm As New SqlCommand(SpSave, conn, tran)
        comm.CommandType = CommandType.StoredProcedure
        SqlCommandBuilder.DeriveParameters(comm)

        Dim isNew As Boolean = (existing Is Nothing)
        Dim remove As New List(Of SqlParameter)

        For Each p As SqlParameter In comm.Parameters
            If p.Direction = ParameterDirection.ReturnValue Then Continue For

            Dim key As String = p.ParameterName.Substring(1)            'remove @
            If key.ToLower().StartsWith("p_") Then key = key.Substring(2) 'remove p_
            Dim lkey As String = key.ToLower()

            If lkey = "dm_item_id" Then
                'GMK item_id is different from Eschler item_id: use the one found by Design No., or -1 = create new
                If isNew Then p.Value = -1L Else p.Value = CLng(existing("dm_item_id"))

            ElseIf lkey = "dm_design_no" Then
                p.Value = designNo

            ElseIf lkey = "log_empcd" Then
                p.Value = userId

            ElseIf lkey = "dm_fin_id" Then
                p.Value = MapFinishing(conn, tran, row("dm_fin_id"), existing, res)

            ElseIf lkey = "dm_fabric_type_id" Then
                p.Value = MapFabricType(conn, tran, row("dm_fabric_type_id"), existing, res)

            ElseIf Array.IndexOf(NotSentParams, lkey) >= 0 Then
                remove.Add(p)

            ElseIf Array.IndexOf(GmkOwnedParams, lkey) >= 0 Then
                If isNew AndAlso lkey = "ds_machine_group_id" Then
                    'this GMK parameter has no default value, so a new design gets NULL (Eschler machine groups do not exist in GMK)
                    p.Value = DBNull.Value
                ElseIf isNew OrElse Not existing.Table.Columns.Contains(key) Then
                    remove.Add(p)
                Else
                    p.Value = existing(key)
                End If

            Else
                Dim srcCol As String = key
                If lkey = "ds_design_gauge" Then srcCol = "dm_design_gauge" 'parameter name differs from column name
                If row.Table.Columns.Contains(srcCol) Then
                    p.Value = row(srcCol)
                ElseIf Not isNew AndAlso existing.Table.Columns.Contains(srcCol) Then
                    p.Value = existing(srcCol)
                Else
                    remove.Add(p)
                End If
            End If
        Next

        'Parameters that are not sent use the default value defined in the procedure
        For Each p As SqlParameter In remove
            comm.Parameters.Remove(p)
        Next
        Return comm
    End Function

    '------------------------------------------------------------------
    ' Finishing group : match by fin_code. Value that cannot be matched is not sent.
    '------------------------------------------------------------------
    Private Function MapFinishing(ByVal conn As SqlConnection, ByVal tran As SqlTransaction, ByVal eschlerFinId As Object, _
                                  ByVal existing As DataRow, ByVal res As SyncResult) As Object
        If IsDBNull(eschlerFinId) OrElse CInt(eschlerFinId) = 0 Then Return 0

        Dim code As String = GetEschlerFinCode(CInt(eschlerFinId))
        Dim reason As String = ""
        If code = "" Then
            reason = "ไม่พบรหัส Finishing (id " & eschlerFinId.ToString() & ") ใน Eschler"
        ElseIf Array.IndexOf(AmbiguousFinCodes, code.ToUpper()) >= 0 Then
            reason = "Finishing รหัส " & code & " มีความหมายต่างกันระหว่าง Eschler กับ GMK"
        Else
            Dim cmd As New SqlCommand("SELECT TOP 1 fin_id FROM finishing_group WHERE RTRIM(fin_code) = @code", conn, tran)
            cmd.Parameters.AddWithValue("@code", code)
            Dim o As Object = cmd.ExecuteScalar()
            If o IsNot Nothing AndAlso Not IsDBNull(o) Then Return CInt(o)
            reason = "ไม่มี Finishing รหัส " & code & " ใน GMK"
        End If

        'Not matched: keep the GMK value on update, use 0 on insert
        If existing IsNot Nothing Then
            res.Warnings.Add(reason & " (คงค่าเดิมของ GMK ไว้)")
            Return existing("dm_fin_id")
        End If
        res.Warnings.Add(reason & " (ส่งค่า 0)")
        Return 0
    End Function

    Private Function GetEschlerFinCode(ByVal finId As Integer) As String
        Using c As New SqlConnection((New classConnection).connection)
            c.Open()
            Using cmd As New SqlCommand("SELECT RTRIM(fin_code) FROM finishing_group WHERE fin_id = @id", c)
                cmd.Parameters.AddWithValue("@id", finId)
                Dim o As Object = cmd.ExecuteScalar()
                If o Is Nothing OrElse IsDBNull(o) Then Return ""
                Return o.ToString().Trim()
            End Using
        End Using
    End Function

    '------------------------------------------------------------------
    ' Fabric type : the id must exist in GMK lookup (FABRIC_TYPE), otherwise it is not sent
    '------------------------------------------------------------------
    Private Function MapFabricType(ByVal conn As SqlConnection, ByVal tran As SqlTransaction, ByVal eschlerId As Object, _
                                   ByVal existing As DataRow, ByVal res As SyncResult) As Object
        If IsDBNull(eschlerId) OrElse CLng(eschlerId) = 0 Then
            If existing IsNot Nothing Then Return existing("dm_fabric_type_id")
            Return DBNull.Value
        End If

        Dim cmd As New SqlCommand("SELECT COUNT(*) FROM lookup_values lv INNER JOIN lookup_type lt ON lt.lookup_id = lv.lookup_id " & _
                                  "WHERE lt.lookup_type = 'FABRIC_TYPE' AND lv.lookup_value_id = @id", conn, tran)
        cmd.Parameters.AddWithValue("@id", CLng(eschlerId))
        If CInt(cmd.ExecuteScalar()) > 0 Then Return CLng(eschlerId)

        If existing IsNot Nothing Then
            res.Warnings.Add("Fabric Type (id " & eschlerId.ToString() & ") ไม่มีใน GMK (คงค่าเดิมของ GMK ไว้)")
            Return existing("dm_fabric_type_id")
        End If
        res.Warnings.Add("Fabric Type (id " & eschlerId.ToString() & ") ไม่มีใน GMK (ส่งค่า NULL)")
        Return DBNull.Value
    End Function

End Class
