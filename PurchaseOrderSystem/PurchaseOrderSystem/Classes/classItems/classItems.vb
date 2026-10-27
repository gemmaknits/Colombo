Imports System.Data
Imports System.Data.SqlClient
Imports System.Text


Public Class classItems

    Private connStr As New classConnection

    Public Function GetDataItemNature() As DataTable
        Dim conn As New SqlConnection(connStr.connection())
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "p_items_nature_select"
        comm.Parameters.AddWithValue("@itnaturecd", "")
        Dim da As New SqlDataAdapter(comm)
        Dim ds As New DataSet
        da.Fill(ds, "itemnature")
        conn.Close()  'Sitthana 20190325
        Return ds.Tables("itemnature")
    End Function

    Public Function GetDataCurrency() As DataSet
        Dim conn As New SqlConnection(connStr.connection())
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "p_currency_select"
        Dim da As New SqlDataAdapter(comm)
        Dim ds As New DataSet
        conn.Close()  'Sitthana 20190325
        da.Fill(ds, "tblCurrencyResult")
        Return ds
    End Function

    Public Function GetDeptList() As DataTable
        Dim conn As New SqlConnection(connStr.connection())
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "p_dept_select"
        Dim da As New SqlDataAdapter(comm)
        Dim ds As New DataSet
        da.Fill(ds, "dept")
        conn.Close()  'Sitthana 20190325
        Return ds.Tables("dept")
    End Function

    Public Function GetEmpList() As DataTable
        Dim conn As New SqlConnection(connStr.connection())
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "p_emp_select"
        Dim da As New SqlDataAdapter(comm)
        Dim ds As New DataSet
        da.Fill(ds, "emp")
        conn.Close()  'Sitthana 20190325
        Return ds.Tables("emp")
    End Function

    Public Overloads Function GetDataItemcode(ByVal itcd As String, ByVal ItNatureCd As String) As DataTable
        Dim conn As New SqlConnection(connStr.connection())
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "p_items_select3"
        comm.Parameters.AddWithValue("@itcd", itcd.Trim)
        comm.Parameters.AddWithValue("@itnaturecd", ItNatureCd.Trim)
        Dim da As New SqlDataAdapter(comm)
        Dim ds As New DataSet
        da.Fill(ds, "items")
        conn.Close()  'Sitthana 20190325
        Return ds.Tables("items")
    End Function

    Public Function GetDataUnit() As DataTable
        Dim conn As New SqlConnection(connStr.connection())
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "p_uom_select"
        Dim da As New SqlDataAdapter(comm)
        Dim ds As New DataSet
        da.Fill(ds, "uom")
        conn.Close()  'Sitthana 20190325
        Return ds.Tables("uom")
    End Function

End Class
