Imports System.Data
Imports System.Data.SqlClient
Public Class ClassGOUTFromREQ

    Public Function ValidateReqNoIsCancel(ByVal outreqno As String, ByVal logempcd As String) As DataTable
        Dim conn As New SqlConnection((New classConnection).connection)
        Dim comm As New SqlCommand("", conn)

        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "p_greige_out_from_req_select_outreqno_validate_cancel"
        comm.Parameters.AddWithValue("@outreqno", outreqno)
        comm.Parameters.AddWithValue("@logempcd", logempcd)
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        conn.Close()  'Sitthana 20190325
        Return dt
    End Function

    Public Function ValidateReqNoIsOut(ByVal outreqno As String, ByVal logempcd As String) As DataTable
        Dim conn As New SqlConnection((New classConnection).connection)
        Dim comm As New SqlCommand("", conn)

        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "p_greige_out_from_req_select_outreqno_validate_outno"
        comm.Parameters.AddWithValue("@outreqno", outreqno)
        comm.Parameters.AddWithValue("@logempcd", logempcd)
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        conn.Close()  'Sitthana 20190325
        Return dt
    End Function

    Public Function GetGOutByRequest(ByVal strReqNo As String, ByVal strEmpCD As String, ByRef StrMessage As String) As DataTable
        Dim conn As New SqlConnection((New classConnection).connection)
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure

        'comm.CommandText = "p_greige_out_from_req_select"
        comm.CommandText = "p_greige_out_from_req_select_req_det_g"
        comm.Parameters.AddWithValue("@outreqno", strReqNo)
        comm.Parameters.AddWithValue("@logempcd", strEmpCD)
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        Try
            da.Fill(dt)
            conn.Close()  'Sitthana 20190325
        Catch ex As Exception
            StrMessage = ex.Message
            conn.Close()
        End Try

        Return dt
    End Function

    Public Function GetGOutByOutNo(ByVal strOutNo As String, ByVal strEmpCD As String) As DataTable
        Dim conn As New SqlConnection((New classConnection).connection)
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "p_greige_out_from_req_select_greige_do"
        comm.Parameters.AddWithValue("@outno", strOutNo)
        comm.Parameters.AddWithValue("@logempcd", strEmpCD)
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        conn.Close()  'Sitthana 20190325
        Return dt
    End Function

    Public Function GetComboGOut() As DataTable
        Dim conn As New SqlConnection((New classConnection).connection)
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "p_greige_out_from_req_select_cbo_gout_no"
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        conn.Close()  'Sitthana 20190325
        Return dt
    End Function

    Public Function SaveGOut(ByVal dt As DataTable, ByVal strRackNo As String, ByVal logempcd As String) As Boolean
        If dt Is Nothing Or dt.Rows.Count = 0 Then Return False

        Dim config As New clsConfig
        Dim conn As New SqlConnection((New classConnection).connection)
        conn.Open()
        Dim tran As SqlTransaction = conn.BeginTransaction
        Dim comm As New SqlCommand("", conn)
        Dim da As New SqlDataAdapter(comm)
        Dim i As Integer = 0
        Dim outno As String = ""


        outno = dt.Rows(0)("outno").ToString().Trim()

        comm.Transaction = tran
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "p_greige_do_update2"

        'Add Detail----------

        For Each dr As DataRow In dt.Rows
            comm.Parameters.Clear()
            comm.Parameters.AddWithValue("@design_no", dr("design_no").Trim)
            comm.Parameters.AddWithValue("@nob", dr("nob").ToString)
            comm.Parameters.AddWithValue("@Gwth", dr("Gwth").Trim)
            comm.Parameters.AddWithValue("@roll_no_g", dr("roll_no_g").Trim)
            comm.Parameters.AddWithValue("@outkg_g", dr("outkg_g"))
            comm.Parameters.AddWithValue("@outmt_g", dr("outmt_g"))
            comm.Parameters.AddWithValue("@outyd_g", dr("outyd_g"))
            comm.Parameters.AddWithValue("@grade", dr("grade").ToString.Trim)
            comm.Parameters.AddWithValue("@loc", dr("loc").ToString.Trim)
            comm.Parameters.AddWithValue("@outreqno", dr("outreqno").Trim)
            comm.Parameters.AddWithValue("@outreqdt", dr("outreqdt").ToString.Trim)
            comm.Parameters.AddWithValue("@outreqtyp", dr("outreqtyp").ToString.Trim)
            comm.Parameters.AddWithValue("@outno", outno.ToString.Trim)
            comm.Parameters.AddWithValue("@outdt", dr("outdt").ToString.Trim)
            comm.Parameters.AddWithValue("@sh", dr("sh").ToString.Trim)
            comm.Parameters.AddWithValue("@dfno", dr("dfno").ToString.Trim)
            comm.Parameters.AddWithValue("@col", dr("col").ToString.Trim)
            comm.Parameters.AddWithValue("@sono", dr("sono").ToString.Trim)
            comm.Parameters.AddWithValue("@sonoid", dr("sonoid").ToString.Trim)
            comm.Parameters.AddWithValue("@roll_no_o", dr("roll_no_o").ToString.Trim)
            comm.Parameters.AddWithValue("@startat", dr("startat").ToString.Trim)
            comm.Parameters.AddWithValue("@flagL", dr("flagL").Trim)
            comm.Parameters.AddWithValue("@cost", dr("cost"))
            comm.Parameters.AddWithValue("@fload", dr("fload").ToString)
            comm.Parameters.AddWithValue("@rate", dr("rate"))
            comm.Parameters.AddWithValue("@cost_g", dr("cost_g"))
            comm.Parameters.AddWithValue("@outno1", dr("outno1").Trim)
            comm.Parameters.AddWithValue("@outnot", dr("outnot").Trim)
            comm.Parameters.AddWithValue("@packno", dr("packno").Trim)
            comm.Parameters.AddWithValue("@cartno", dr("cartno").ToString)
            comm.Parameters.AddWithValue("@packdt", dr("packdt").Trim)
            comm.Parameters.AddWithValue("@pono", dr("pono").Trim)
            comm.Parameters.AddWithValue("@invno", dr("invno").Trim)
            comm.Parameters.AddWithValue("@cancel", dr("cancel").ToString)
            comm.Parameters.AddWithValue("@cliped", dr("cliped").ToString)
            comm.Parameters.AddWithValue("@preseted", dr("preseted").ToString)
            comm.Parameters.AddWithValue("@id_greige_do", dr("id_greige_do"))
            comm.Parameters.AddWithValue("@rack_no", strRackNo)
            comm.Parameters.AddWithValue("@log_empcd", logempcd)

            'Dim xxx As String = config.BuildSQL(comm)
            'Debug.Print(xxx)

            da = New SqlDataAdapter(comm)
            dt = New DataTable
            Try
                da.Fill(dt)
            Catch ex As Exception
                tran.Rollback()
                conn.Close()  'Sitthana 20190325
                Throw ex
            End Try

            outno = dt.Rows(0)("outno").ToString().Trim()
        Next

        tran.Commit()
        conn.Close()  'Sitthana 20190325
        Return True
    End Function
End Class
