Imports System.Data
Imports System.Data.SqlClient
Imports System.Text

Public Class classStock
    Public Function GetGINNoPFD() As DataTable
        Dim conn As New SqlConnection((New classConnection).connection)
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "p_combo_gin_no_pfd"
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        conn.Close()  'Sitthana 20190325
        Return dt
    End Function

    Public Function GetDINNo() As DataTable
        Dim conn As New SqlConnection((New classConnection).connection)
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "p_combo_din_no"
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        conn.Close()  'Sitthana 20190325
        Return dt
    End Function

    Public Function GetGINPDF(ByVal strBillNo As String, ByVal strEmpCode As String) As DataTable
        Dim conn As New SqlConnection((New classConnection).connection)
        conn.Open()
        Dim tran As SqlTransaction = conn.BeginTransaction
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure
        comm.Transaction = tran

        comm.CommandText = "p_greige_select_by_gamma"
        comm.Parameters.AddWithValue("@bill_no", strBillNo)
        comm.Parameters.AddWithValue("@logempcd", strEmpCode)
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        Try
            da.Fill(dt)
        Catch ex As Exception
            'msgerr = ex.Message
            tran.Rollback()
            conn.Close()
            Return dt
        End Try
        tran.Commit()
        conn.Close()
        Return dt
    End Function

    Public Function GetDIN(ByVal strBillNo As String, ByVal strEmpCode As String, ByRef Strerror As String) As DataTable
        Dim conn As New SqlConnection((New classConnection).connection)
        conn.Open()
        Dim tran As SqlTransaction = conn.BeginTransaction
        Dim comm As New SqlCommand("", conn)
        comm.Transaction = tran

        comm.CommandTimeout = 600

        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "p_strolls_d_select_by_gamma"
        comm.Parameters.AddWithValue("@bill_no", strBillNo)
        comm.Parameters.AddWithValue("@logempcd", strEmpCode)

        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        Try
            da.Fill(dt)
        Catch ex As Exception
            Strerror = ex.Message
            tran.Rollback()
            comm.Connection.Close()
            Return dt
        End Try
        tran.Commit()
        comm.Connection.Close()
        Return dt
        'Dim conn As New SqlConnection((New classConnection).connection)
        'Dim comm As New SqlCommand("", conn)
        'comm.CommandType = CommandType.StoredProcedure
        'comm.CommandText = "p_strolls_d_select_by_gamma"
        'comm.Parameters.AddWithValue("@bill_no", strBillNo)
        'comm.Parameters.AddWithValue("@logempcd", strEmpCode)
        'Dim da As New SqlDataAdapter(comm)
        'Dim dt As New DataTable
        'da.Fill(dt)
        'Return dt
    End Function

    Public Function SaveGINPFD(ByVal strBillNo As String, ByVal strEmpCode As String) As DataTable
        Dim conn As New SqlConnection((New classConnection).connection)
        conn.Open()
        Dim tran As SqlTransaction = conn.BeginTransaction
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure
        comm.Transaction = tran

        comm.CommandText = "p_greige_update_by_gamma"
        comm.Parameters.AddWithValue("@bill_no", strBillNo)
        comm.Parameters.AddWithValue("@logempcd", strEmpCode)
        comm.CommandTimeout = 360
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        Try
            da.Fill(dt)
        Catch ex As Exception
            'msgerr = ex.Message
            tran.Rollback()
            conn.Close()
            Return dt
        End Try
        tran.Commit()
        conn.Close()
        Return dt
    End Function

    Public Function SaveDIN(ByVal strBillNo As String, ByVal strEmpCode As String) As DataTable
        Dim conn As New SqlConnection((New classConnection).connection)
        conn.Open()
        Dim tran As SqlTransaction = conn.BeginTransaction
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure
        comm.Transaction = tran

        comm.CommandText = "p_strolls_d_update_by_gamma"
        comm.Parameters.AddWithValue("@bill_no", strBillNo)
        comm.Parameters.AddWithValue("@logempcd", strEmpCode)
        comm.CommandTimeout = 360
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        Try
            da.Fill(dt)
        Catch ex As Exception
            'msgerr = ex.Message
            tran.Rollback()
            conn.Close()
            Return dt
        End Try

        tran.Commit()
        conn.Close()
        Return dt
    End Function

    Public Function CancelDIN(ByVal strDINNo As String, ByVal strEmpCode As String) As Boolean
        Dim conn As New SqlConnection((New classConnection).connection)
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "p_strolls_d_cancel"
        comm.Parameters.AddWithValue("@dinno", strDINNo)
        comm.Parameters.AddWithValue("@logempcd", strEmpCode)
        comm.Connection.Open()
        comm.ExecuteNonQuery()
        comm.Connection.Close()
        Return True
    End Function


    Public Function CancelGIN(ByVal strtranno As String, ByVal strEmpCode As String) As Boolean
        Dim conn As New SqlConnection((New classConnection).connection)
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "p_greige_cancel"
        comm.Parameters.AddWithValue("@tran_no", strtranno)
        comm.Parameters.AddWithValue("@logempcd", strEmpCode)
        comm.Connection.Open()
        comm.ExecuteNonQuery()
        comm.Connection.Close()
        Return True
    End Function
End Class
