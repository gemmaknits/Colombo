Imports System.Data
Imports System.Data.SqlClient
Imports System.Text
Public Class classSuppliers
    Private clsConnection As New classConnection

    Public Function selectSuppliersRecord(ByVal pSuppcd As String) As DataTable
        Dim conn As New SqlConnection(clsConnection.connection)
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "P_SUPPLIERS_FORM_PKG_select_suppliers_record"
        comm.Parameters.Clear()
        comm.Parameters.AddWithValue("@p_suppcd", pSuppcd)
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        conn.Close()
        Return dt
    End Function

    Public Function updateSuppliersRecord(ByVal pType As String, ByRef drvSuppliers As DataRowView, ByRef msgerr As String, ByVal pLoginEmpcd As String) As Boolean
        Dim conn As New SqlConnection(clsConnection.connection())
        Dim comm As New SqlCommand("", conn)
        conn.Open()
        Dim tran As SqlTransaction = conn.BeginTransaction
        comm.Transaction = tran
        comm.CommandType = Data.CommandType.StoredProcedure
        comm.CommandText = "P_SUPPLIERS_FORM_PKG_update_suppliers_record"
        'INS 'UPD
        'If pType = "ADD" Then
        '    comm.CommandText = "p_suppliers_insert"
        'Else
        '    comm.CommandText = "p_suppliers_update"
        'End If
        With drvSuppliers
            Dim suppcdValue As Object = .Item("suppcd")
            If suppcdValue Is DBNull.Value OrElse suppcdValue.ToString.Trim = "" Then
                comm.Parameters.Add("@p_suppcd", SqlDbType.Char, 10).Value = DBNull.Value
            Else
                comm.Parameters.Add("@p_suppcd", SqlDbType.Char, 10).Value = suppcdValue.ToString.Trim
            End If
            comm.Parameters.AddWithValue("@p_name", .Item("name"))
            comm.Parameters.AddWithValue("@p_namet", .Item("namet"))
            comm.Parameters.AddWithValue("@p_addr1", .Item("addr1"))
            comm.Parameters.AddWithValue("@p_addr2", .Item("addr2"))
            comm.Parameters.AddWithValue("@p_addr3", .Item("addr3"))
            comm.Parameters.AddWithValue("@p_addr1t", .Item("addr1t"))
            comm.Parameters.AddWithValue("@p_addr2t", .Item("addr2t"))
            comm.Parameters.AddWithValue("@p_addr3t", .Item("addr3t"))
            comm.Parameters.AddWithValue("@p_city", .Item("city"))
            comm.Parameters.AddWithValue("@p_ctry", .Item("ctry"))
            comm.Parameters.AddWithValue("@p_tel", .Item("tel"))
            comm.Parameters.AddWithValue("@p_fax", .Item("fax"))
            comm.Parameters.AddWithValue("@p_email", .Item("email"))
            comm.Parameters.AddWithValue("@p_email_cc", .Item("email_cc"))
            comm.Parameters.AddWithValue("@p_contact", .Item("contact"))
            comm.Parameters.AddWithValue("@p_dyer", .Item("dyer"))
            comm.Parameters.AddWithValue("@p_scalloper", 0)
            comm.Parameters.AddWithValue("@p_greige", 0)
            comm.Parameters.AddWithValue("@p_altcode", 0)
            comm.Parameters.AddWithValue("@p_abbrev", .Item("abbrev"))
            comm.Parameters.AddWithValue("@p_abbrev2", .Item("abbrev2"))
            comm.Parameters.AddWithValue("@p_crdays", .Item("crdays"))
            comm.Parameters.AddWithValue("@p_crterms", .Item("crterms"))
            comm.Parameters.AddWithValue("@p_paymodecd", .Item("paymodecd"))
            comm.Parameters.AddWithValue("@p_internal", .Item("internal"))
            comm.Parameters.AddWithValue("@p_vatregno", .Item("vatregno"))

            comm.Parameters.AddWithValue("@p_logempcd", pLoginEmpcd)
        End With
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        Try
            da.Fill(dt)
            drvSuppliers.Row("suppcd") = dt.Rows(0)("suppcd").ToString.Trim
        Catch ex As Exception
            msgerr = ex.Message
            tran.Rollback()
            conn.Close()
            Return False
        End Try

        tran.Commit()
        conn.Close()
        Return True
    End Function
End Class

