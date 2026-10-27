Imports System.Drawing
Imports System.Data.SqlClient
Imports System.Data
Imports System.Math

Public Class frmReportPLG

    Private Sub frmReportPLG_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        Me.RvPLG.RefreshReport()

    End Sub
    Private Sub Getdata()

        Dim objdb As New classPackingListG
        Dim dt As New DataTable
        Dim ds As New DataSet





    End Sub
End Class