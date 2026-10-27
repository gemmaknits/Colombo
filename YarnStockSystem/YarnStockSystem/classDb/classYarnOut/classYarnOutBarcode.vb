Imports System.Data
Imports System.Data.SqlClient
Imports System.Text
Public Class classYarnOutBarcode

    Public Structure Yarn_out
        Dim outno As String
        Dim outdt As Nullable(Of DateTime)
        Dim tran_type As String
        Dim refdocno As String 'Jobno
        Dim suppcd As String 'suppcd
        Dim kono As String
        Dim [rem] As String
        Dim cancel As Nullable(Of Boolean)
        Dim tstamp As Nullable(Of DateTime)
        Dim present_status As String
        Dim locked As Nullable(Of Boolean)
        Dim packno As String
        Dim packdt As Nullable(Of Date)
        Dim cartno As Nullable(Of Integer)
        Dim Message As String
    End Structure

    Public Function CancelYOut(outno As String, loginempcd As String) As Boolean
        Dim conn As New SqlConnection((New classConnection).Connection)
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "p_yarn_out_Cancel"
        comm.Parameters.AddWithValue("@outno", outno)
        comm.Parameters.AddWithValue("@log_empcd", loginempcd)
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        conn.Close()  'Sitthana 20190325
        Return True
    End Function

    Public Function GetComboYOut() As DataTable
        Dim conn As New SqlConnection((New classConnection).Connection)
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "p_combo_yarn_out_no"
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        conn.Close()  'Sitthana 20190325
        Return dt
    End Function


    Public Function GetYOutByJob(ByVal strJobNo As String, ByVal strOutno As String, ByVal strlogempcd As String) As DataTable
        Dim conn As New SqlConnection((New classConnection).Connection)
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "p_yarn_out_barcode_select"
        comm.Parameters.AddWithValue("@jobno", strJobNo)
        comm.Parameters.AddWithValue("@outno", strOutno)
        comm.Parameters.AddWithValue("@logempcd", strlogempcd)
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        conn.Close()  'Sitthana 20190325
        Return dt
    End Function
    Public Function InsertYarnOut(ByRef paramtbl_yarn_out As tbl_Yarn_out, ByRef Youtno As String, ByRef msgerr As String, ByVal loginEmpcd As String) As Boolean
        Dim conn As New SqlConnection((New classConnection).Connection)
        conn.Open()

        Dim comm As New SqlCommand("", conn)
        Dim tran As SqlTransaction = conn.BeginTransaction
        comm.Transaction = tran
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "p_yarn_out_insert "
        With paramtbl_yarn_out
            comm.Parameters.AddWithValue("@outdt", .outdt.Trim)
            comm.Parameters.AddWithValue("@tran_type", .tran_type.Trim)
            comm.Parameters.AddWithValue("@refdocno", .refdocno.Trim)
            comm.Parameters.AddWithValue("@suppcd", .suppcd.Trim)
            comm.Parameters.AddWithValue("@kono", .kono.Trim)
            comm.Parameters.AddWithValue("@rem", .remm.Trim)
            comm.Parameters.AddWithValue("@log_empcd", loginEmpcd.Trim)
        End With
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable

        Try
            da.Fill(dt)
        Catch ex As Exception
            msgerr = ex.Message
            tran.Rollback()
            conn.Close()  'Sitthana 20190325
            Return False
        End Try

        Dim docno As String = dt.Rows(0)("outno").ToString.Trim
        Dim i As Integer = 0
        Dim tbl_Yarn_out_det As New tbl_Yarn_out_det
        Youtno = docno

        Try
            For Each tbl_Yarn_out_det In paramtbl_yarn_out.tbl_Yarn_out_det
                comm = New SqlCommand("", conn)
                comm.CommandType = CommandType.StoredProcedure
                comm.Transaction = tran
                comm.CommandText = "p_yarn_out_det_insert"
                With tbl_Yarn_out_det
                    comm.Parameters.AddWithValue("@outno", docno.Trim)
                    comm.Parameters.AddWithValue("@itcd", .itcd.Trim)
                    comm.Parameters.AddWithValue("@grade", .grade.Trim)
                    comm.Parameters.AddWithValue("@boxno", .boxno.Trim)
                    comm.Parameters.AddWithValue("@id_job_det_yarn", .id_job_det_yarn.ToString)
                    comm.Parameters.AddWithValue("@gb", .gb.ToString)
                End With
                da = New SqlDataAdapter(comm)
                dt = New DataTable
                da.Fill(dt)
                paramtbl_yarn_out.tbl_Yarn_out_det(i).id_yarn_out_det = dt.Rows(0)("id_yarn_out_det")
                i += 1
            Next
        Catch ex As Exception
            conn.Close()  'Sitthana 20190325
            msgerr = ex.Message
            tran.Rollback()
            Return False
        End Try
        tran.Commit()
        conn.Close()  'Sitthana 20190325
        Return True
    End Function

    Public Function SaveYOut(ByRef Yarn_out As Yarn_out, ByVal dt As DataTable, ByVal strRackNo As String, ByVal clsuser As classUserInfo) As Boolean
        If dt Is Nothing Or dt.Rows.Count = 0 Then Return False

        Dim config As New clsConfig
        Dim conn As New SqlConnection((New classConnection).Connection)
        conn.Open()
        Dim tran As SqlTransaction = conn.BeginTransaction
        Dim comm As New SqlCommand("", conn)
        Dim da As New SqlDataAdapter(comm)
        Dim i As Integer = 0
        Dim outno As String = ""

        comm.Transaction = tran
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "p_yarn_out_barcode_update"
        'Add Detail----------

        For Each dr As DataRow In dt.Rows
            comm.Parameters.Clear()
            comm.Parameters.AddWithValue("@id_yarn_out_det", dr("id_yarn_out_det"))
            comm.Parameters.AddWithValue("@outno", Yarn_out.outno)
            comm.Parameters.AddWithValue("@itcd", dr("itcd"))
            comm.Parameters.AddWithValue("@grade", dr("grade"))
            comm.Parameters.AddWithValue("@boxno_s", dr("boxno_s"))
            comm.Parameters.AddWithValue("@boxno", dr("boxno"))
            comm.Parameters.AddWithValue("@lotno_sup", dr("lotno_sup"))
            comm.Parameters.AddWithValue("@lotno_our", dr("lotno_our"))
            comm.Parameters.AddWithValue("@spools", dr("spools"))
            comm.Parameters.AddWithValue("@kg_gr", dr("kg_gr"))
            comm.Parameters.AddWithValue("@cart_tearwt", dr("cart_tearwt"))
            comm.Parameters.AddWithValue("@spool_tearwt", dr("spool_tearwt"))
            comm.Parameters.AddWithValue("@kg_nt", dr("kg_nt"))
            comm.Parameters.AddWithValue("@actual_cone_weight", dr("actual_cone_weight"))
            comm.Parameters.AddWithValue("@id_job_det_yarn", dr("id_job_det_yarn"))
            comm.Parameters.AddWithValue("@gb", dr("gb"))
            comm.Parameters.AddWithValue("@outdt", dr("outdt"))
            comm.Parameters.AddWithValue("@tran_type", dr("tran_type"))
            comm.Parameters.AddWithValue("@refdocno", dr("refdocno"))
            comm.Parameters.AddWithValue("@suppcd", dr("suppcd"))
            comm.Parameters.AddWithValue("@kono", dr("kono"))
            comm.Parameters.AddWithValue("@rem", Yarn_out.[rem])
            comm.Parameters.AddWithValue("@tstamp", dr("tstamp"))
            comm.Parameters.AddWithValue("@present_status", dr("present_status"))
            comm.Parameters.AddWithValue("@locked", dr("locked"))
            comm.Parameters.AddWithValue("@sono", dr("sono"))
            comm.Parameters.AddWithValue("@sonoid", dr("sonoid"))
            comm.Parameters.AddWithValue("@packno", Yarn_out.packno)
            comm.Parameters.AddWithValue("@packdt", Yarn_out.packdt)
            comm.Parameters.AddWithValue("@cartno", Yarn_out.cartno)
            comm.Parameters.AddWithValue("@mfg_production_order_line_id", dr("mfg_production_order_line_id"))
            comm.Parameters.AddWithValue("@logempcd", clsuser.UserID)

            da = New SqlDataAdapter(comm)
            dt = New DataTable
            Try
                da.Fill(dt)
            Catch ex As Exception
                Yarn_out.Message = ex.Message
                tran.Rollback()
                conn.Close()  'Sitthana 20190325
                Return False
                'Throw ex.Message
            End Try
            Yarn_out.outno = dt.Rows(0)("outno").ToString().Trim()
            Yarn_out.packno = dt.Rows(0)("packno")
            Yarn_out.packdt = dt.Rows(0)("packdt")
            Yarn_out.cartno = dt.Rows(0)("cartno")
            'outno = dt.Rows(0)("outno").ToString().Trim()
        Next

        tran.Commit()
        conn.Close()  'Sitthana 20190325
        Return True
    End Function
End Class

