Imports System.Data.SqlClient

Public Structure PDR
    Dim id As Long
    Dim book_no As String
    Dim pdr_no As String
    Dim pdr_date As String
    Dim dr_no As String
    Dim design_no As String
    Dim custcd As String
    Dim empcd As String
    Dim expected_price As Double
    Dim uom As String
    Dim expected_date As String
    Dim final_product_id As Integer
    Dim development_type_id As Integer
    Dim development_type_remark As String
    Dim fabric_type_id As Integer
    Dim fabric_structure2_id As Integer
    Dim fabric_appearance_id As Integer
    Dim fabric_appearance_remark As String
    Dim standard_aatcc As Boolean
    Dim standard_astm As Boolean
    Dim standard_iso As Boolean
    Dim standard_jis As Boolean
    Dim standard_customer As String
    Dim composition1_percent As Double
    Dim composition2_percent As Double
    Dim composition3_percent As Double
    Dim composition4_percent As Double
    Dim composition5_percent As Double
    Dim composition6_percent As Double
    Dim composition1_name As String
    Dim composition2_name As String
    Dim composition3_name As String
    Dim composition4_name As String
    Dim composition5_name As String
    Dim composition6_name As String
    Dim weight_sqm As Double
    Dim weight_sqm_tolerance As Double
    Dim weight_sqm_remark As String
    Dim width As Double
    Dim width_tolerance As Double
    Dim width_remark As String
    Dim elongation As Double
    Dim elongation_l As Double
    Dim elongation_w As Double
    Dim elongation_tolerance As Double
    Dim elongation_remark As String
    Dim modulus As Double
    Dim modulus_l As Double
    Dim modulus_w As Double
    Dim modulus_tolerance As Double
    Dim modulus_remark As String
    Dim stretch_l As Double
    Dim stretch_w As Double
    Dim stretch_tolerance As Double
    Dim stretch_remark As String
    Dim shrinkage_l As Double
    Dim shrinkage_w As Double
    Dim shrinkage_tolerance As Double
    Dim shrinkage_remark As String
    Dim pilling_wash As Integer
    Dim pilling_l As Double
    Dim pilling_w As Double
    Dim pilling_tolerance As Double
    Dim pilling_remark As String
    Dim snagging_wash As Integer
    Dim snagging_l As Double
    Dim snagging_w As Double
    Dim snagging_tolerance As Double
    Dim snagging_remark As String
    Dim color_code As String
    Dim color_name As String
    Dim dye_finishing_formula_id As Integer
    Dim dye_remark As String
    Dim hanger As Integer
    Dim yardage As Double
    Dim require_tag As Boolean
    Dim machine_dense As String
    Dim yarn_available As Boolean
    Dim yarn_available_date As String
    Dim knitting_appointment As String
    Dim offer_price As Double
    Dim negotiation_success As Boolean
    Dim is_consideration As Boolean
    Dim approve As Boolean
    Dim reject As Boolean
    Dim expected_finished_date As String
    Dim spec_master_date As String
    Dim qa_report_date As String
    Dim active As Boolean
    Dim remark As String
    Dim create_by As String
    Dim create_date As String
    Dim create_time As String
    Dim modify_by As String
    Dim modify_date As String
    Dim modify_time As String
End Structure

Public Structure DR
    Dim id As Long
    Dim dr_no As String
    Dim dr_date As String
    Dim pdr_id As Long
    Dim dfno As String
    Dim new_design_no As String

    Dim knitting_type As String

    Dim itcd1 As String
    Dim ynperc1 As Single
    Dim spools1 As UInteger
    Dim itcd1_remark As String

    Dim itcd2 As String
    Dim ynperc2 As Single
    Dim spools2 As UInteger
    Dim itcd2_remark As String

    Dim itcd3 As String
    Dim ynperc3 As Single
    Dim spools3 As UInteger
    Dim itcd3_remark As String

    Dim itcd4 As String
    Dim ynperc4 As Single
    Dim spools4 As UInteger
    Dim itcd4_remark As String

    Dim itcd5 As String
    Dim ynperc5 As Single
    Dim spools5 As UInteger
    Dim itcd5_remark As String

    Dim itcd6 As String
    Dim ynperc6 As Single
    Dim spools6 As UInteger
    Dim itcd6_remark As String

    Dim itcd7 As String
    Dim ynperc7 As Single
    Dim spools7 As UInteger
    Dim itcd7_remark As String

    Dim rolls As UInteger
    Dim kgs_per_roll As Single
    Dim mcno As String
    Dim knitting_remark As String

    Dim weight_sqm As Single
    Dim width As Single
    Dim course As UInteger
    Dim wale As UInteger
    Dim dyeing_remark As String

    Dim active As Boolean
    Dim remark As String
    Dim create_by As String
    Dim create_date As String
    Dim create_time As String
    Dim modify_by As String
    Dim modify_date As String
    Dim modify_time As String

    Dim weight_sqm_Max As Single 'Sitthana 19/05/2018
    Dim width_Max As Single 'Sitthana 19/05/2018
    Dim imagefile As String
    Dim submit_date As String
    Dim spec_master_date As String
    Dim RepeatPerRoll As Single 'Sitthana 16/11/2018
    Dim qa_report_date As String
    Dim pdr_new_develop_req_id As Nullable(Of Long)
    Dim pdr_closed As String
    Dim dr_app_rej_id As Nullable(Of Int64)
    Dim dr_app_rej_comment As String
    Dim dr_closed As String

    Dim dr_ynchgcd As String 'Sitthana 21/05/2018
    Dim add_to_collection As String 'Sitthana 25/05/2018
End Structure

Public Class classRandD
    Public Function comboPDR(ByVal logempcd As String) As DataTable
        Dim conn As New SqlConnection((New classConnection).connection)
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "p_combo_master_pdr"
        comm.Parameters.AddWithValue("@logempcd", logempcd)
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        conn.Close()
        Return dt
    End Function

    Public Function comboDR(ByVal logempcd As String) As DataTable
        Dim conn As New SqlConnection((New classConnection).connection)
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "p_combo_master_dr"
        comm.Parameters.AddWithValue("@logempcd", logempcd)
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        conn.Close()
        Return dt
    End Function

    Public Function comboCustomer(ByVal logempcd As String) As DataTable
        Dim conn As New SqlConnection((New classConnection).connection)
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "p_combo_master_customer"
        comm.Parameters.AddWithValue("@logempcd", logempcd)
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        conn.Close()
        Return dt
    End Function

    Public Function comboUOM(ByVal logempcd As String) As DataTable
        Dim conn As New SqlConnection((New classConnection).connection)
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "p_combo_master_uom"
        comm.Parameters.AddWithValue("@logempcd", logempcd)
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        conn.Close()
        Return dt
    End Function

    Public Function comboFinalProduct(ByVal logempcd As String) As DataTable
        Dim conn As New SqlConnection((New classConnection).connection)
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "p_combo_master_final_product"
        comm.Parameters.AddWithValue("@logempcd", logempcd)
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        conn.Close()
        Return dt
    End Function

    Public Function comboDevelopmentType(ByVal logempcd As String) As DataTable
        Dim conn As New SqlConnection((New classConnection).connection)
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "p_combo_master_development_type"
        comm.Parameters.AddWithValue("@logempcd", logempcd)
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        conn.Close()
        Return dt
    End Function

    Public Function comboFabricType(ByVal logempcd As String) As DataTable
        Dim conn As New SqlConnection((New classConnection).connection)
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "p_combo_master_fabric_type"
        comm.Parameters.AddWithValue("@logempcd", logempcd)
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        conn.Close()
        Return dt
    End Function

    Public Function comboFabricStructure2(ByVal logempcd As String) As DataTable
        Dim conn As New SqlConnection((New classConnection).connection)
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "p_combo_master_fabric_structure2"
        comm.Parameters.AddWithValue("@logempcd", logempcd)
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        conn.Close()
        Return dt
    End Function

    Public Function comboFabricAppearance(ByVal logempcd As String) As DataTable
        Dim conn As New SqlConnection((New classConnection).connection)
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "p_combo_master_fabric_appearance"
        comm.Parameters.AddWithValue("@logempcd", logempcd)
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        conn.Close()
        Return dt
    End Function

    Public Function comboFinishing(ByVal logempcd As String) As DataTable
        Dim conn As New SqlConnection((New classConnection).connection)
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "p_combo_master_finishing"
        comm.Parameters.AddWithValue("@logempcd", logempcd)
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        conn.Close()
        Return dt
    End Function

    Public Function comboEmployee(ByVal logempcd As String) As DataTable
        Dim conn As New SqlConnection((New classConnection).connection)
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "p_combo_master_employee"
        comm.Parameters.AddWithValue("@logempcd", logempcd)
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        conn.Close()
        Return dt
    End Function

    Public Function comboMachine(ByVal logempcd As String) As DataTable
        Dim conn As New SqlConnection((New classConnection).connection)
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "p_combo_master_machine"
        comm.Parameters.AddWithValue("@logempcd", logempcd)
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        conn.Close()
        Return dt
    End Function

    Public Function comboMachineGauge(ByVal logempcd As String) As DataTable
        Dim conn As New SqlConnection((New classConnection).connection)
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "p_combo_master_machines_gauge"
        comm.Parameters.AddWithValue("@logempcd", logempcd)
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        conn.Close()
        Return dt
    End Function

    Public Function comboYarnCode(ByVal logempcd As String) As DataTable
        Dim conn As New SqlConnection((New classConnection).connection)
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "p_combo_master_yarn"
        comm.Parameters.AddWithValue("@logempcd", logempcd)
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        conn.Close()
        Return dt
    End Function
    Public Function comboPDRNEW(ByVal logempcd As String) As DataTable
        Dim conn As New SqlConnection((New classConnection).connection)
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "p_combo_master_pdr_new"
        comm.Parameters.AddWithValue("@logempcd", logempcd)
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        conn.Close()
        Return dt
    End Function
    Public Function PDRSelect(ByVal id As Long, ByVal logempcd As String) As DataTable
        Dim conn As New SqlConnection((New classConnection).connection)
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "p_pre_develop_requirement_select"
        comm.Parameters.AddWithValue("@id", id)
        comm.Parameters.AddWithValue("@logempcd", logempcd)
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        conn.Close()
        Return dt
    End Function

    Public Function PDRUpdate(ByVal obj As PDR, ByVal logempcd As String, ByRef errmsg As String) As Boolean
        Dim conn As New SqlConnection((New classConnection).connection)
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "p_pre_develop_requirement_update"
        With obj
            comm.Parameters.AddWithValue("@id", .id)
            comm.Parameters.AddWithValue("@book_no", .book_no.Trim)
            comm.Parameters.AddWithValue("@pdr_no", .pdr_no.Trim)
            comm.Parameters.AddWithValue("@pdr_date", .pdr_date.Trim)
            comm.Parameters.AddWithValue("@dr_no", .dr_no.Trim)
            comm.Parameters.AddWithValue("@design_no", .design_no.Trim)
            comm.Parameters.AddWithValue("@custcd", .custcd.Trim)
            comm.Parameters.AddWithValue("@empcd", .empcd.Trim)
            comm.Parameters.AddWithValue("@expected_price", .expected_price.ToString)
            comm.Parameters.AddWithValue("@uom", .uom.Trim)
            comm.Parameters.AddWithValue("@expected_date", .expected_date)
            comm.Parameters.AddWithValue("@final_product_id", .final_product_id)
            comm.Parameters.AddWithValue("@development_type_id", .development_type_id)
            comm.Parameters.AddWithValue("@development_type_remark", .development_type_remark.Trim)
            comm.Parameters.AddWithValue("@fabric_type_id", .fabric_type_id)
            comm.Parameters.AddWithValue("@fabric_structure2_id", .fabric_structure2_id)
            comm.Parameters.AddWithValue("@fabric_appearance_id", .fabric_appearance_id)
            comm.Parameters.AddWithValue("@fabric_appearance_remark", .fabric_appearance_remark.Trim)
            comm.Parameters.AddWithValue("@standard_aatcc", .standard_aatcc.ToString)
            comm.Parameters.AddWithValue("@standard_astm", .standard_astm.ToString)
            comm.Parameters.AddWithValue("@standard_iso", .standard_iso.ToString)
            comm.Parameters.AddWithValue("@standard_jis", .standard_jis.ToString)
            comm.Parameters.AddWithValue("@standard_customer", .standard_customer.Trim)
            comm.Parameters.AddWithValue("@composition1_percent", .composition1_percent.ToString)
            comm.Parameters.AddWithValue("@composition2_percent", .composition2_percent.ToString)
            comm.Parameters.AddWithValue("@composition3_percent", .composition3_percent.ToString)
            comm.Parameters.AddWithValue("@composition4_percent", .composition4_percent.ToString)
            comm.Parameters.AddWithValue("@composition5_percent", .composition5_percent.ToString)
            comm.Parameters.AddWithValue("@composition6_percent", .composition6_percent.ToString)
            comm.Parameters.AddWithValue("@composition1_name", .composition1_name.Trim)
            comm.Parameters.AddWithValue("@composition2_name", .composition2_name.Trim)
            comm.Parameters.AddWithValue("@composition3_name", .composition3_name.Trim)
            comm.Parameters.AddWithValue("@composition4_name", .composition4_name.Trim)
            comm.Parameters.AddWithValue("@composition5_name", .composition5_name.Trim)
            comm.Parameters.AddWithValue("@composition6_name", .composition6_name.Trim)
            comm.Parameters.AddWithValue("@weight_sqm", .weight_sqm.ToString)
            comm.Parameters.AddWithValue("@weight_sqm_tolerance", .weight_sqm_tolerance.ToString)
            comm.Parameters.AddWithValue("@weight_sqm_remark", .weight_sqm_remark.Trim)
            comm.Parameters.AddWithValue("@width", .width.ToString)
            comm.Parameters.AddWithValue("@width_tolerance", .width_tolerance.ToString)
            comm.Parameters.AddWithValue("@width_remark", .width_remark.Trim)
            comm.Parameters.AddWithValue("@elongation", .elongation.ToString)
            comm.Parameters.AddWithValue("@elongation_l", .elongation_l.ToString)
            comm.Parameters.AddWithValue("@elongation_w", .elongation_w.ToString)
            comm.Parameters.AddWithValue("@elongation_tolerance", .elongation_tolerance.ToString)
            comm.Parameters.AddWithValue("@elongation_remark", .elongation_remark.Trim)
            comm.Parameters.AddWithValue("@modulus", .modulus.ToString)
            comm.Parameters.AddWithValue("@modulus_l", .modulus_l.ToString)
            comm.Parameters.AddWithValue("@modulus_w", .modulus_w.ToString)
            comm.Parameters.AddWithValue("@modulus_tolerance", .modulus_tolerance.ToString)
            comm.Parameters.AddWithValue("@modulus_remark", .modulus_remark.Trim)
            comm.Parameters.AddWithValue("@stretch_l", .stretch_l.ToString)
            comm.Parameters.AddWithValue("@stretch_w", .stretch_w.ToString)
            comm.Parameters.AddWithValue("@stretch_tolerance", .stretch_tolerance.ToString)
            comm.Parameters.AddWithValue("@stretch_remark", .stretch_remark.Trim)
            comm.Parameters.AddWithValue("@shrinkage_l", .shrinkage_l.ToString)
            comm.Parameters.AddWithValue("@shrinkage_w", .shrinkage_w.ToString)
            comm.Parameters.AddWithValue("@shrinkage_tolerance", .shrinkage_tolerance.ToString)
            comm.Parameters.AddWithValue("@shrinkage_remark", .shrinkage_remark.Trim)
            comm.Parameters.AddWithValue("@pilling_wash", .pilling_wash)
            comm.Parameters.AddWithValue("@pilling_l", .pilling_l.ToString)
            comm.Parameters.AddWithValue("@pilling_w", .pilling_w.ToString)
            comm.Parameters.AddWithValue("@pilling_tolerance", .pilling_tolerance.ToString)
            comm.Parameters.AddWithValue("@pilling_remark", .pilling_remark.Trim)
            comm.Parameters.AddWithValue("@snagging_wash", .snagging_wash)
            comm.Parameters.AddWithValue("@snagging_l", .snagging_l.ToString)
            comm.Parameters.AddWithValue("@snagging_w", .snagging_w.ToString)
            comm.Parameters.AddWithValue("@snagging_tolerance", .snagging_tolerance.ToString)
            comm.Parameters.AddWithValue("@snagging_remark", .snagging_remark.Trim)
            comm.Parameters.AddWithValue("@color_code", .color_code.Trim)
            comm.Parameters.AddWithValue("@color_name", .color_name.Trim)
            comm.Parameters.AddWithValue("@dye_finishing_formula_id", .dye_finishing_formula_id.ToString)
            comm.Parameters.AddWithValue("@dye_remark", .dye_remark.Trim)
            comm.Parameters.AddWithValue("@hanger", .hanger.ToString)
            comm.Parameters.AddWithValue("@yardage", .yardage.ToString)
            comm.Parameters.AddWithValue("@require_tag", .require_tag.ToString)
            comm.Parameters.AddWithValue("@machine_dense", .machine_dense.Trim)
            comm.Parameters.AddWithValue("@yarn_available", .yarn_available.ToString)
            comm.Parameters.AddWithValue("@yarn_available_date", .yarn_available_date.Trim)
            comm.Parameters.AddWithValue("@knitting_appointment", .knitting_appointment.Trim)
            comm.Parameters.AddWithValue("@offer_price", .offer_price.ToString)
            comm.Parameters.AddWithValue("@negotiation_success", .negotiation_success.ToString)
            comm.Parameters.AddWithValue("@is_consideration", .is_consideration.ToString)
            comm.Parameters.AddWithValue("@approve", .approve.ToString)
            comm.Parameters.AddWithValue("@reject", .reject.ToString)
            comm.Parameters.AddWithValue("@expected_finished_date", .expected_finished_date.Trim)
            comm.Parameters.AddWithValue("@spec_master_date", .spec_master_date.Trim)
            comm.Parameters.AddWithValue("@qa_report_date", .qa_report_date.Trim)
            comm.Parameters.AddWithValue("@active", .active.ToString)
            comm.Parameters.AddWithValue("@remark", .remark.Trim)
            comm.Parameters.AddWithValue("@create_by", .create_by.Trim)
            comm.Parameters.AddWithValue("@create_date", .create_date.Trim)
            comm.Parameters.AddWithValue("@create_time", .create_time.Trim)
            comm.Parameters.AddWithValue("@modify_by", .modify_by)
            comm.Parameters.AddWithValue("@modify_date", .modify_date.Trim)
            comm.Parameters.AddWithValue("@modify_time", .modify_time.Trim)
        End With
        comm.Parameters.AddWithValue("@logempcd", logempcd)
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        Try
            da.Fill(dt)
            errmsg = dt.Rows(0)("id").ToString()
            conn.Close()
        Catch ex As Exception
            errmsg = ex.Message
            conn.Close()
            Return False
        End Try
        Return True
    End Function

    Public Function DRSelect(ByVal id As Long, ByVal logempcd As String) As DataTable
        Dim conn As New SqlConnection((New classConnection).connection)
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "p_development_requirement_select"
        comm.Parameters.AddWithValue("@id", id)
        comm.Parameters.AddWithValue("@logempcd", logempcd)
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        conn.Close()
        Return dt
    End Function

    Public Function DRUpdate(ByVal obj As DR, ByVal logempcd As String, ByRef errmsg As String) As Boolean
        Dim config As New clsConfig
        Dim conn As New SqlConnection((New classConnection).connection)
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "p_development_requirement_update"
        With obj
            comm.Parameters.AddWithValue("@id", .id)
            comm.Parameters.AddWithValue("@dr_no", .dr_no.Trim)
            comm.Parameters.AddWithValue("@dr_date", .dr_date.Trim)
            comm.Parameters.AddWithValue("@pdr_id", .pdr_id.ToString)
            comm.Parameters.AddWithValue("@dfno", .dfno.Trim)
            comm.Parameters.AddWithValue("@new_design_no", .new_design_no.Trim)

            comm.Parameters.AddWithValue("@knitting_type", .knitting_type.Trim)

            comm.Parameters.AddWithValue("@itcd1", .itcd1.Trim)
            comm.Parameters.AddWithValue("@ynperc1", .ynperc1.ToString)
            comm.Parameters.AddWithValue("@spools1", .spools1.ToString)
            comm.Parameters.AddWithValue("@itcd1_remark", .itcd1_remark.Trim)

            comm.Parameters.AddWithValue("@itcd2", config.IsNull(.itcd2, "").ToString.Trim)
            comm.Parameters.AddWithValue("@ynperc2", .ynperc2.ToString)
            comm.Parameters.AddWithValue("@spools2", .spools2.ToString)
            comm.Parameters.AddWithValue("@itcd2_remark", .itcd2_remark.Trim)

            comm.Parameters.AddWithValue("@itcd3", config.IsNull(.itcd3, "").ToString.Trim)
            comm.Parameters.AddWithValue("@ynperc3", .ynperc3.ToString)
            comm.Parameters.AddWithValue("@spools3", .spools3.ToString)
            comm.Parameters.AddWithValue("@itcd3_remark", .itcd3_remark.Trim)

            comm.Parameters.AddWithValue("@itcd4", config.IsNull(.itcd4, "").ToString.Trim)
            comm.Parameters.AddWithValue("@ynperc4", .ynperc4.ToString)
            comm.Parameters.AddWithValue("@spools4", .spools4.ToString)
            comm.Parameters.AddWithValue("@itcd4_remark", .itcd4_remark.Trim)

            comm.Parameters.AddWithValue("@itcd5", config.IsNull(.itcd5, "").ToString.Trim)
            comm.Parameters.AddWithValue("@ynperc5", .ynperc5.ToString)
            comm.Parameters.AddWithValue("@spools5", .spools5.ToString)
            comm.Parameters.AddWithValue("@itcd5_remark", .itcd5_remark.Trim)

            comm.Parameters.AddWithValue("@itcd6", config.IsNull(.itcd6, "").ToString.Trim)
            comm.Parameters.AddWithValue("@ynperc6", .ynperc6.ToString)
            comm.Parameters.AddWithValue("@spools6", .spools6.ToString)
            comm.Parameters.AddWithValue("@itcd6_remark", .itcd6_remark.Trim)

            comm.Parameters.AddWithValue("@rolls", .rolls.ToString)
            comm.Parameters.AddWithValue("@kgs_per_roll", .kgs_per_roll.ToString)
            comm.Parameters.AddWithValue("@mcno", .mcno.Trim)
            comm.Parameters.AddWithValue("@knitting_remark", .knitting_remark.Trim)

            comm.Parameters.AddWithValue("@weight_sqm", .weight_sqm.ToString)
            comm.Parameters.AddWithValue("@width", .width.ToString)
            comm.Parameters.AddWithValue("@course", .course.ToString)
            comm.Parameters.AddWithValue("@wale", .wale.ToString)
            comm.Parameters.AddWithValue("@dyeing_remark", .dyeing_remark.Trim)

            comm.Parameters.AddWithValue("@active", .active.ToString)
            comm.Parameters.AddWithValue("@remark", .remark.Trim)
            comm.Parameters.AddWithValue("@create_by", .create_by.Trim)
            comm.Parameters.AddWithValue("@create_date", .create_date.Trim)
            comm.Parameters.AddWithValue("@create_time", .create_time.Trim)
            comm.Parameters.AddWithValue("@modify_by", .modify_by)
            comm.Parameters.AddWithValue("@modify_date", .modify_date.Trim)
            comm.Parameters.AddWithValue("@modify_time", .modify_time.Trim)
        End With
        comm.Parameters.AddWithValue("@logempcd", logempcd)
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        Try
            da.Fill(dt)
            errmsg = dt.Rows(0)("id").ToString()
            conn.Close()
        Catch ex As Exception
            errmsg = ex.Message
            conn.Close()
            Return False
        End Try
        Return True
    End Function
    Public Function DRNEWSelect(ByVal id As Long, ByVal logempcd As String) As DataTable
        Dim conn As New SqlConnection((New classConnection).connection)
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "p_development_requirement_new_select"
        comm.Parameters.AddWithValue("@id", id)
        comm.Parameters.AddWithValue("@logempcd", logempcd)
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        conn.Close()
        Return dt
    End Function
    Public Function DRNEWUpdate(ByRef drvSoitm As DataRowView, dtSoitm As DataTable, ByRef obj As DR, ByVal logempcd As String, ByRef errmsg As String) As Boolean
        Dim config As New clsConfig
        Dim conn As New SqlConnection((New classConnection).connection)
        conn.Open()

        Dim tran As SqlTransaction = conn.BeginTransaction

        Dim comm As New SqlCommand("", conn)
        'comm.Connection.Open()

        comm.CommandType = CommandType.StoredProcedure
        comm.Transaction = tran
        comm.CommandText = "p_development_requirement_new_update"

        With obj
            comm.Parameters.AddWithValue("@id", obj.id)
            comm.Parameters.AddWithValue("@dr_no", obj.dr_no.Trim)
            comm.Parameters.AddWithValue("@dr_date", .dr_date.Trim)
            comm.Parameters.AddWithValue("@pdr_id", .pdr_id.ToString)
            comm.Parameters.AddWithValue("@pdr_new_develop_req_id", .pdr_new_develop_req_id.ToString)

            comm.Parameters.AddWithValue("@dfno", .dfno.Trim)
            comm.Parameters.AddWithValue("@new_design_no", .new_design_no.Trim)

            comm.Parameters.AddWithValue("@knitting_type", .knitting_type.Trim)

            comm.Parameters.AddWithValue("@itcd1", (New clsConfig).IsNull(.itcd1, "").ToString.Trim)
            comm.Parameters.AddWithValue("@ynperc1", .ynperc1.ToString)
            comm.Parameters.AddWithValue("@spools1", .spools1.ToString)
            comm.Parameters.AddWithValue("@itcd1_remark", .itcd1_remark.Trim)

            comm.Parameters.AddWithValue("@itcd2", config.IsNull(.itcd2, "").ToString.Trim)
            comm.Parameters.AddWithValue("@ynperc2", .ynperc2.ToString)
            comm.Parameters.AddWithValue("@spools2", .spools2.ToString)
            comm.Parameters.AddWithValue("@itcd2_remark", .itcd2_remark.Trim)

            comm.Parameters.AddWithValue("@itcd3", config.IsNull(.itcd3, "").ToString.Trim)
            comm.Parameters.AddWithValue("@ynperc3", .ynperc3.ToString)
            comm.Parameters.AddWithValue("@spools3", .spools3.ToString)
            comm.Parameters.AddWithValue("@itcd3_remark", .itcd3_remark.Trim)

            comm.Parameters.AddWithValue("@itcd4", config.IsNull(.itcd4, "").ToString.Trim)
            comm.Parameters.AddWithValue("@ynperc4", .ynperc4.ToString)
            comm.Parameters.AddWithValue("@spools4", .spools4.ToString)
            comm.Parameters.AddWithValue("@itcd4_remark", .itcd4_remark.Trim)

            comm.Parameters.AddWithValue("@itcd5", config.IsNull(.itcd5, "").ToString.Trim)
            comm.Parameters.AddWithValue("@ynperc5", .ynperc5.ToString)
            comm.Parameters.AddWithValue("@spools5", .spools5.ToString)
            comm.Parameters.AddWithValue("@itcd5_remark", .itcd5_remark.Trim)

            comm.Parameters.AddWithValue("@itcd6", config.IsNull(.itcd6, "").ToString.Trim)
            comm.Parameters.AddWithValue("@ynperc6", .ynperc6.ToString)
            comm.Parameters.AddWithValue("@spools6", .spools6.ToString)
            comm.Parameters.AddWithValue("@itcd6_remark", .itcd6_remark.Trim)

            comm.Parameters.AddWithValue("@itcd7", config.IsNull(.itcd7, "").ToString.Trim)
            comm.Parameters.AddWithValue("@ynperc7", .ynperc7.ToString)
            comm.Parameters.AddWithValue("@spools7", .spools7.ToString)
            comm.Parameters.AddWithValue("@itcd7_remark", .itcd7_remark.Trim)

            comm.Parameters.AddWithValue("@rolls", .rolls.ToString)
            comm.Parameters.AddWithValue("@kgs_per_roll", .kgs_per_roll.ToString)
            comm.Parameters.AddWithValue("@p_repeat_per_roll", .RepeatPerRoll.ToString) 'Sitthana 16/11/2018
            comm.Parameters.AddWithValue("@mcno", .mcno)
            comm.Parameters.AddWithValue("@knitting_remark", .knitting_remark.Trim)

            comm.Parameters.AddWithValue("@weight_sqm", .weight_sqm.ToString)
            comm.Parameters.AddWithValue("@weight_sqm_Max", .weight_sqm_Max.ToString) 'Sitthana 19/05/2018
            comm.Parameters.AddWithValue("@width", .width.ToString)
            comm.Parameters.AddWithValue("@width_Max", .width_Max.ToString)  'Sitthana 19/05/2018
            comm.Parameters.AddWithValue("@course", .course.ToString)
            comm.Parameters.AddWithValue("@wale", .wale.ToString)
            comm.Parameters.AddWithValue("@dyeing_remark", .dyeing_remark.Trim)

            comm.Parameters.AddWithValue("@active", .active.ToString)
            comm.Parameters.AddWithValue("@remark", .remark.Trim)
            comm.Parameters.AddWithValue("@create_by", .create_by.Trim)
            comm.Parameters.AddWithValue("@create_date", .create_date.Trim)
            comm.Parameters.AddWithValue("@create_time", .create_time.Trim)
            comm.Parameters.AddWithValue("@modify_by", .modify_by)
            comm.Parameters.AddWithValue("@modify_date", .modify_date.Trim)
            comm.Parameters.AddWithValue("@modify_time", .modify_time.Trim)

            comm.Parameters.AddWithValue("@imagefile", .imagefile)

            comm.Parameters.AddWithValue("@submit_date", .submit_date)
            comm.Parameters.AddWithValue("@spec_master_date", .spec_master_date)
            comm.Parameters.AddWithValue("@qa_report_date", .qa_report_date)

            comm.Parameters.AddWithValue("@dr_app_rej_id", .dr_app_rej_id)
            comm.Parameters.AddWithValue("@dr_app_rej_comment", .dr_app_rej_comment)
            comm.Parameters.AddWithValue("@dr_closed", .dr_closed)
            comm.Parameters.AddWithValue("@pdr_closed", .pdr_closed)
            comm.Parameters.AddWithValue("@dr_ynchgcd", .dr_ynchgcd)
            comm.Parameters.AddWithValue("@p_add_to_collection", .add_to_collection)
        End With
        comm.Parameters.AddWithValue("@logempcd", logempcd)
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        Try
            da.Fill(dt)
            obj.id = dt.Rows(0)("id").ToString()
        Catch ex As Exception
            errmsg = ex.Message
            tran.Rollback()
            conn.Close()  'Sitthana 20190325
            'comm.Transaction.Rollback()
            'comm.Connection.BeginTransaction.Rollback()
            conn.Close()
            Return False
        End Try

        '--- Update Soitm ---- John
        Dim dvSoitm As New DataView(dtSoitm, "", "", DataViewRowState.Added Or DataViewRowState.ModifiedCurrent)

        For Each drvUpd As DataRowView In dvSoitm
            comm.CommandText = "[dbo].[p_development_requirement_update_soitm]"
            With drvUpd
                comm.Parameters.Clear()
                comm.Parameters.AddWithValue("@p_so_line_id", .Item("so_line_id"))
                comm.Parameters.AddWithValue("@p_approved_jobno", config.IsNull(.Item("approved_jobno"), DBNull.Value))
                comm.Parameters.AddWithValue("@p_reject_jobno", config.IsNull(.Item("reject_jobno"), DBNull.Value))
                comm.Parameters.AddWithValue("@p_reject_job_date", config.IsNull(.Item("reject_job_date"), DBNull.Value))
                comm.Parameters.AddWithValue("@p_reject_job_reason", config.IsNull(.Item("reject_job_reason"), DBNull.Value))

                Dim da2 As New SqlDataAdapter(comm)
                Dim dt2 As New DataTable
                Try
                    da2.Fill(dt2)
                Catch ex As Exception
                    errmsg = ex.Message
                    tran.Rollback()
                    conn.Close()
                    Return False
                End Try
            End With
        Next

        tran.Commit()
        'comm.Transaction.Commit()
        'comm.Connection.BeginTransaction.Commit()
        conn.Close()
        conn.Close()  'Sitthana 20190325
        'comm.Connection.Close()

        Return True
    End Function
End Class
