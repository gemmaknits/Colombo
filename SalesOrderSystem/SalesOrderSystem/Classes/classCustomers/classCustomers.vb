Imports System.Data
Imports System.Data.SqlClient
Imports System.Text
Public Class classCustomers

    Public Structure Customer

        Dim h01_custcd As String
        Dim h02_name As String
        Dim h03_namet As String
        Dim h04_addr1 As String
        Dim h05_addr2 As String
        Dim h06_addr3 As String
        Dim h07_addr1t As String
        Dim h08_addr2t As String
        Dim h09_addr3t As String
        Dim h10_city As String
        Dim h11_ctry As String
        Dim h12_tel As String
        Dim h13_fax As String
        Dim h14_email As String
        Dim h15_contact As String
        Dim h16_credit As Integer
        Dim h17_payterms As String
        Dim h18_agcd As String
        Dim h19_Custgroup As String
        Dim h20_active As Integer
        Dim h21_crdays As Integer
        Dim h22_log_empcd As String
        Dim h23_name2 As String
        Dim h24_vatregno As String
        Dim h25_parent_customer_id As Nullable(Of Int64)
        Dim h26_customer_id As Nullable(Of Int64)
    End Structure

    Public Function GetparentCustomerID(Optional ByVal StrCustcd As String = Nothing, Optional ByVal strEmpcd As String = "") As Nullable(Of Int64)
        Dim conn As New SqlConnection((New classConnection).connection)
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "P_CUSTOMERS_PKG_get_parent_customer_id"
        comm.Parameters.AddWithValue("@custcd", StrCustcd)
        comm.Parameters.AddWithValue("@logempcd", strEmpcd)
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        conn.Close()  'Sitthana 20190325
        If dt.Rows.Count > 0 Then
            Return dt.Rows(0)("parent_customer_id")
        Else
            Return Nothing
        End If

    End Function

    Public Function GetCustomers(Optional ByVal Int64ParentCustomerID As Nullable(Of Int64) = Nothing, Optional ByVal strEmpcd As String = "") As DataTable
        Dim conn As New SqlConnection((New classConnection).connection)
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "P_CUSTOMERS_PKG_select_customers"
        comm.Parameters.AddWithValue("@parent_customer_id", Int64ParentCustomerID)
        comm.Parameters.AddWithValue("@logempcd", strEmpcd)
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        conn.Close()  'Sitthana 20190325
        Return dt
    End Function

    Public Function GetCustomersSite(Optional ByVal Int64CustomerID As Nullable(Of Int64) = Nothing, Optional ByVal strEmpcd As String = "") As DataTable
        Dim conn As New SqlConnection((New classConnection).connection)
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "P_CUSTOMERS_PKG_select_customers_site"
        comm.Parameters.AddWithValue("@customer_id", Int64CustomerID)
        comm.Parameters.AddWithValue("@logempcd", strEmpcd)
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        conn.Close()  'Sitthana 20190325
        Return dt
    End Function

    Public Function GetCustomerID(Optional ByVal StrCustcd As String = Nothing, Optional ByVal strEmpcd As String = "") As Nullable(Of Int64)
        Dim conn As New SqlConnection((New classConnection).connection)
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "P_CUSTOMERS_PKG_get_customer_id"
        comm.Parameters.AddWithValue("@custcd", StrCustcd)
        comm.Parameters.AddWithValue("@logempcd", strEmpcd)
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        conn.Close()  'Sitthana 20190325
        If dt.Rows.Count > 0 Then
            Return dt.Rows(0)("customer_id")
        Else
            Return Nothing
        End If

    End Function

    Public Function SaveData(ByRef dtCustomer As DataTable, ByRef Cust As Customer, ByRef Strmsgerr As String, ByRef StrLogEmpcd As String) As Boolean
        Dim config As New clsConfig
        Dim conn As New SqlConnection((New classConnection).connection)
        conn.Open()
        Dim tran As SqlTransaction = conn.BeginTransaction
        Dim comm As New SqlCommand("", conn)
        Dim i As Integer = 0
        Dim strLotNo As String = ""
        comm.Transaction = tran
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "P_CUSTOMERS_PKG_update_customers"
        With Cust
            For Each dr As DataRow In dtCustomer.Rows
                If dr.RowState <> DataRowState.Deleted Then
                    comm.Parameters.Clear()
                    comm.Parameters.AddWithValue("@custcd", dr("custcd"))
                    comm.Parameters.AddWithValue("@name", dr("name"))
                    comm.Parameters.AddWithValue("@namet", dr("namet"))
                    comm.Parameters.AddWithValue("@addr1", dr("addr1"))
                    comm.Parameters.AddWithValue("@addr2", dr("addr2"))
                    comm.Parameters.AddWithValue("@addr3", dr("addr3"))
                    comm.Parameters.AddWithValue("@addr1t", dr("addr1t"))
                    comm.Parameters.AddWithValue("@addr2t", dr("addr2t"))
                    comm.Parameters.AddWithValue("@addr3t", dr("addr3t"))
                    comm.Parameters.AddWithValue("@city", dr("city"))
                    comm.Parameters.AddWithValue("@ctry", dr("ctry"))
                    comm.Parameters.AddWithValue("@tel", dr("tel"))
                    comm.Parameters.AddWithValue("@fax", dr("fax"))
                    comm.Parameters.AddWithValue("@email", dr("email"))
                    comm.Parameters.AddWithValue("@contact", dr("contact"))
                    comm.Parameters.AddWithValue("@credit", dr("credit"))
                    comm.Parameters.AddWithValue("@payterms", dr("payterms"))
                    comm.Parameters.AddWithValue("@agcd", dr("agcd"))
                    comm.Parameters.AddWithValue("@Custgroup", dr("Custgroup"))
                    comm.Parameters.AddWithValue("@active", dr("active"))
                    comm.Parameters.AddWithValue("@crdays", dr("crdays"))
                    comm.Parameters.AddWithValue("@name2", dr("name2"))
                    comm.Parameters.AddWithValue("@district", dr("district"))
                    comm.Parameters.AddWithValue("@group_name", dr("group_name"))
                    comm.Parameters.AddWithValue("@main_product", dr("main_product"))
                    comm.Parameters.AddWithValue("@vatregno", dr("vatregno"))
                    comm.Parameters.AddWithValue("@id_banks", dr("id_banks"))
                    comm.Parameters.AddWithValue("@customer_id", dr("customer_id"))
                    comm.Parameters.AddWithValue("@parent_customer_id", .h25_parent_customer_id)
                    comm.Parameters.AddWithValue("@ship_to_flag", dr("ship_to_flag"))
                    comm.Parameters.AddWithValue("@bill_to_flag", dr("bill_to_flag"))
                    comm.Parameters.AddWithValue("@parent_customer_flag", dr("parent_customer_flag"))

                    comm.Parameters.AddWithValue("@log_empcd", StrLogEmpcd)
                    '     Next
                    ' End With


                    Dim da As New SqlDataAdapter(comm)
                    Dim dt As New DataTable
                    Try
                        da.Fill(dt)
                    Catch ex As Exception
                        Strmsgerr = ex.Message
                        tran.Rollback()
                        conn.Close()  'Sitthana 20190325
                        Return False
                    End Try

                    Cust.h01_custcd = dt.Rows(0)("custcd").ToString.Trim
                    Cust.h25_parent_customer_id = dt.Rows(0)("parent_customer_id")
                    Cust.h26_customer_id = dt.Rows(0)("customer_id")

                End If
            Next
        End With

        comm.CommandText = "P_CUSTOMERS_PKG_disabled_customer_site"
        With Cust
            For Each dr As DataRow In dtCustomer.Rows
                If dr.RowState = DataRowState.Deleted Then
                    comm.Parameters.Clear()
                    comm.Parameters.AddWithValue("@customer_id", dr("customer_id"))

                    comm.Parameters.AddWithValue("@log_empcd", StrLogEmpcd)
                    Dim da As New SqlDataAdapter(comm)
                    Dim dt As New DataTable
                    Try
                        da.Fill(dt)
                    Catch ex As Exception
                        Strmsgerr = ex.Message
                        tran.Rollback()
                        conn.Close()  'Sitthana 20190325
                        Return False
                    End Try
                End If
            Next
        End With

        tran.Commit()
        conn.Close()  'Sitthana 20190325
        Return True
    End Function
End Class

