Imports System.Data
Imports System.Data.SqlClient
Imports System.Text
Public Class classJobOrderBarcode


    Public Function GetDefaultSuppcd() As String

        Dim conn As New SqlConnection((New classConnection).Connection)
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "P_JOB_ORDER_YARN_BARCODE_PKG_select_default_suppcd"
        conn.Open()
        comm.Parameters.Clear()
        Dim obj = comm.ExecuteScalar()

        If obj IsNot Nothing AndAlso Not IsDBNull(obj) Then
            Return obj.ToString()
        End If

        Return ""
    End Function
End Class
