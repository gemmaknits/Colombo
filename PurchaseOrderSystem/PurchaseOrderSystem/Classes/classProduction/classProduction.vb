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
End Structure

Public Class classProduction
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

    Public Function comboItemCode() As DataTable
        Dim conn As New SqlConnection((New classConnection).connection)
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "p_combo_itcd_from_po_unclosed"
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
    Public Function comboSupplierfrompo() As DataTable
        Dim conn As New SqlConnection((New classConnection).connection)
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "p_combo_supplier_from_po_unclosed"
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

    Public Function KOSchedulePlanUpdate(ByVal koSchedulePlan As KOSchedulePlan) As Boolean
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
        End With

        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        conn.Close()  'Sitthana 20190325

        If dt.Rows.Count > 0 Then
            Return True
        Else
            Return False
        End If
    End Function
    Public Function ValidateItems(ByVal design_no As String, ByVal logempcd As String) As Boolean
        Dim conn As New SqlConnection((New classConnection).connection)
        Dim comm As New SqlCommand("", conn)

        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "p_yarnchange_validate_item"
        comm.Parameters.AddWithValue("@itcd", design_no)
        comm.Parameters.AddWithValue("@logempcd", logempcd)
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        Dim Result As Boolean = True
        da.Fill(dt)
        conn.Close()  'Sitthana 20190325
        If dt.Rows.Count > 0 Then
            Result = True
        Else
            Result = False
        End If

        Return Result
    End Function
End Class
