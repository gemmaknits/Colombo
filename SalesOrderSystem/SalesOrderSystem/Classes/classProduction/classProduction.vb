Imports System.Data
Imports System.Data.SqlClient
Imports System.Text

Public Structure KOSchedulePlan
    Dim id As Long
    Dim code As String
    Dim name_en As String
    Dim name_th As String
    Dim active As Boolean
    Dim remark As String
    Dim create_by As String
    Dim create_date As String
    Dim create_time As String
    Dim mcno As String
    Dim gwth As String
    Dim id_yarnchange As Integer
    Dim kgs As Single
    Dim kstartdt As String
    Dim kstarttime As String
    Dim kenddt As String
    Dim kendtime As String
    Dim adjustment As String
    Dim roll_kgs_std As Single
    Dim df_batch_kgs As Single
    Dim daily_capacity As Single
    Dim loss_percent As Single
    Dim approved As Boolean
End Structure

Public Class classProduction
    Dim config As clsConfig = New clsConfig

    Public Function comboKO() As DataTable
        Dim conn As New SqlConnection((New classConnection).connection)
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "p_combo_ko_unclosed"
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        conn.Close()  'Sitthana 20190325
        Return dt
    End Function

    Public Function comboSO() As DataTable
        Dim conn As New SqlConnection((New classConnection).connection)
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "p_combo_so_from_ko_unclosed"
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        conn.Close()  'Sitthana 20190325
        Return dt
    End Function

    Public Function comboDesignNo() As DataTable
        Dim conn As New SqlConnection((New classConnection).connection)
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "p_combo_design_from_ko_unclosed"
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        conn.Close()  'Sitthana 20190325
        Return dt
    End Function

    Public Function comboMachine() As DataTable
        Dim conn As New SqlConnection((New classConnection).connection)
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "p_combo_machine_from_ko_unclosed"
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        conn.Close()  'Sitthana 20190325
        Return dt
    End Function

    Public Function comboYarnCode() As DataTable
        Dim conn As New SqlConnection((New classConnection).connection)
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "p_combo_itcd_from_ko_unclosed"
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        conn.Close()  'Sitthana 20190325
        Return dt
    End Function

    Public Function comboSupplier() As DataTable
        Dim conn As New SqlConnection((New classConnection).connection)
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "p_combo_supplier_from_ko_unclosed"
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        conn.Close()  'Sitthana 20190325
        Return dt
    End Function

    Public Function comboYarnChangeCode(ByVal strDesignNo As String) As DataTable
        Dim conn As New SqlConnection((New classConnection).connection)
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "p_combo_ynchgcd_from_ko"
        comm.Parameters.AddWithValue("@design_no", strDesignNo)
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        conn.Close()  'Sitthana 20190325
        Return dt
    End Function

    Public Function KOSchedulePlanSelect(ByVal strKONo As String) As DataTable
        Dim conn As New SqlConnection((New classConnection).connection)
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "p_ko_schedule_plan_select"
        comm.Parameters.AddWithValue("@code", strKONo)
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        conn.Close()  'Sitthana 20190325
        Return dt
    End Function

    Public Function KOSchedulePlanDetSelect(ByVal strKONo As String) As DataTable
        Dim conn As New SqlConnection((New classConnection).connection)
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "p_ko_schedule_plan_det_select"
        comm.Parameters.AddWithValue("@code", strKONo)
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        conn.Close()  'Sitthana 20190325
        Return dt
    End Function

    Public Function KOSchedulePlanHistory(ByVal strKONo As String) As DataTable
        Dim conn As New SqlConnection((New classConnection).connection)
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "p_ko_schedule_plan_hist"
        comm.Parameters.AddWithValue("@code", strKONo)
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        conn.Close()  'Sitthana 20190325
        Return dt
    End Function

    Public Function KOSchedulePlanUpdate(ByVal koSchedulePlan As KOSchedulePlan, ByVal det As DataTable) As Boolean
        Dim conn As New SqlConnection((New classConnection).connection)
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "p_ko_schedule_plan_update"

        With koSchedulePlan
            comm.Parameters.AddWithValue("@id", .id.ToString)
            comm.Parameters.AddWithValue("@code", .code.Trim)
            comm.Parameters.AddWithValue("@name_en", .name_en.Trim)
            comm.Parameters.AddWithValue("@name_th", .name_th.Trim)
            comm.Parameters.AddWithValue("@active", IIf(.active, "1", "0"))
            comm.Parameters.AddWithValue("@remark", .remark.Trim)
            comm.Parameters.AddWithValue("@create_by", .create_by.Trim)
            comm.Parameters.AddWithValue("@create_date", .create_date.Trim)
            comm.Parameters.AddWithValue("@create_time", .create_time.Trim)
            comm.Parameters.AddWithValue("@mcno", .mcno.Trim)
            comm.Parameters.AddWithValue("@gwth", .gwth.Trim)
            comm.Parameters.AddWithValue("@id_yarnchange", .id_yarnchange.ToString)
            comm.Parameters.AddWithValue("@kgs", .kgs.ToString)
            comm.Parameters.AddWithValue("@kstartdt", .kstartdt.Trim)
            comm.Parameters.AddWithValue("@kstarttime", .kstarttime.Trim)
            comm.Parameters.AddWithValue("@kenddt", .kenddt.Trim)
            comm.Parameters.AddWithValue("@kendtime", .kendtime.Trim)
            comm.Parameters.AddWithValue("@adjustment", .adjustment.Trim)
            comm.Parameters.AddWithValue("@roll_kgs_std", .roll_kgs_std)
            comm.Parameters.AddWithValue("@df_batch_kgs", .df_batch_kgs)
            comm.Parameters.AddWithValue("@daily_capacity", .daily_capacity)
            comm.Parameters.AddWithValue("@loss_percent", .loss_percent)
            comm.Parameters.AddWithValue("@approved", .approved)
        End With

        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        conn.Close()  'Sitthana 20190325

        If dt.Rows.Count <= 0 Then
            Return False
        End If

        For Each dr As DataRow In det.Rows
            If Not KOSchedulePlanDetUpdate(
                config.IsNull(dr("id"), 0), _
                koSchedulePlan.code.Trim, _
                dr("name_en").ToString(), _
                dr("name_th").ToString(), _
                True, _
                dr("remark").ToString(), _
                koSchedulePlan.create_by, _
                "", _
                "", _
                CDate(dr("due_date")).ToString("yyyyMMdd"), _
                Val(dr("kg")), _
                dr("color").ToString(), _
                dr("custcolor").ToString()) Then Return False
        Next

        Return True
    End Function

    Public Function KOSchedulePlanDetUpdate(ByVal id As Integer, ByVal code As String, ByVal name_en As String, _
                                            ByVal name_th As String, ByVal active As Boolean, ByVal remark As String, _
                                            ByVal create_by As String, ByVal create_date As String, ByVal create_time As String, _
                                            ByVal due_date As String, ByVal kg As Double, ByVal color As String, ByVal custcolor As String) As Boolean
        Dim conn As New SqlConnection((New classConnection).connection)
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "p_ko_schedule_plan_det_update"


        comm.Parameters.AddWithValue("@id", id)
        comm.Parameters.AddWithValue("@code", code)
        comm.Parameters.AddWithValue("@name_en", name_en)
        comm.Parameters.AddWithValue("@name_th", name_th)
        comm.Parameters.AddWithValue("@active", IIf(active, 1, 0))
        comm.Parameters.AddWithValue("@remark", remark)
        comm.Parameters.AddWithValue("@create_by", create_by)
        comm.Parameters.AddWithValue("@create_date", create_date)
        comm.Parameters.AddWithValue("@create_time", create_time)
        comm.Parameters.AddWithValue("@due_date", due_date)
        comm.Parameters.AddWithValue("@kg", kg)
        comm.Parameters.AddWithValue("@color", color)
        comm.Parameters.AddWithValue("@custcolor", custcolor)

        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da = New SqlDataAdapter(comm)
        dt = New DataTable
        da.Fill(dt)
        conn.Close()  'Sitthana 20190325

        If dt.Rows.Count <= 0 Then
            Return False
        End If


        Return True
    End Function

    Public Function MachineCapacitySelect(ByVal strMCNo As String, strDesignGroup As String) As DataTable
        Dim conn As New SqlConnection((New classConnection).connection)
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "p_machine_capacity_select"
        comm.Parameters.AddWithValue("@machine_code", strMCNo)
        comm.Parameters.AddWithValue("@design_group", strDesignGroup)
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        conn.Close()  'Sitthana 20190325
        Return dt
    End Function


    Public Function MachineCapacityUpdate(ByVal dt As DataTable) As Boolean
        Dim conn As New SqlConnection((New classConnection).connection)

        For Each dr As DataRow In dt.Rows
            If IsNumeric(dr("id")) And IsNumeric(dr("monthly_capacity")) Then
                Dim comm As New SqlCommand("", conn)
                comm.CommandType = CommandType.StoredProcedure
                comm.CommandText = "p_machine_capacity_update"
                comm.Parameters.AddWithValue("@id", dr("id"))
                comm.Parameters.AddWithValue("@monthly_capacity", dr("monthly_capacity"))
                comm.Parameters.AddWithValue("@remark", (New clsConfig()).IsNull(dr("remark"), ""))

                Dim da As New SqlDataAdapter(comm)
                Dim dt2 As New DataTable
                da.Fill(dt2)
                conn.Close()  'Sitthana 20190325

                If dt2.Rows.Count = 0 Then Return False
            Else
                conn.Close()  'Sitthana 20190325
                Return False
            End If
        Next
        conn.Close()  'Sitthana 20190325

        Return True
    End Function
End Class
