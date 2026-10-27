Imports System.Data.SqlClient

Public Class ClassMasterSearchDialog
    Dim clsConnection As New classConnection

    'Customer
    Public Function searchCustomer(pUserName As String, cnn As SqlConnection)
        Dim frm As New Classes.formSearchCustomer
        Dim drv As DataRowView
        Dim SearchResult As New Classes.SearchFormResult

        ' pass nothing to use default connection string inside the class or pass your connection object if need to use different from default.

        'frm.setConnectionString()
        frm.setConnectionString((New classConnection).getSQLConnection)
        frm.logempcd = pUserName

        frm.deptcd = ""
        frm.customerName = ""

        SearchResult = frm.ShowCustomers
        frm.Close()
        frm.Dispose()

        If SearchResult.ButtonClicked = "OK" Then
            drv = SearchResult.ResultRowView
        Else
            drv = Nothing
        End If

        Return drv
    End Function

    'Items
    Public Function searchDesign(pUserName As String, cnn As SqlConnection)
        Dim frm As New Classes.FrmSearchDesign
        Dim drv As DataRowView
        Dim SearchResult As New Classes.SearchFormResult

        ' pass nothing to use default connection string inside the class or pass your connection object if need to use different from default.

        'frm.setConnectionString()
        frm.setConnectionString((New classConnection).getSQLConnection)
        frm.logempcd = pUserName
        frm.DesignNo = ""

        SearchResult = frm.ShowFrm
        frm.Close()
        frm.Dispose()

        If SearchResult.ButtonClicked = "OK" Then
            drv = SearchResult.ResultRowView
        Else
            drv = Nothing
        End If

        Return drv
    End Function
End Class
