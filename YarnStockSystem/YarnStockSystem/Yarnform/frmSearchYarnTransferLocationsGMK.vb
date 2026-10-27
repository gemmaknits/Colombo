Imports System.Text

Public Class frmSearchYarnTransferLocationsGMK
    Dim ObjLogNo As String
    Public Property pLogNo As String
        Get
            pLogNo = ObjLogNo
        End Get
        Set(ByVal newvalue As String)
            ObjLogNo = newvalue
        End Set
    End Property


    Private bsSearchTable As New BindingSource 'Sitthana 20190822

    Private Sub frmSearchYLGMK_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call GenGrid()
    End Sub

    Private Sub GenGrid()
        Dim objDB As New classSearchYarnLocationsGMK
        Dim dt As New DataTable
        dt = objDB.GetYarnLocationsGMK(txtFilter.Text)

        grddata.AutoGenerateColumns = False
        bsSearchTable.DataSource = dt 'Sitthana 20190822
        grddata.DataSource = bsSearchTable 'Sitthana 20190822
        'grddata.DataSource = dt
    End Sub

    Private Sub txtFilter_KeyDown(sender As Object, e As KeyEventArgs) Handles txtFilter.KeyDown
        If e.KeyCode = Keys.Enter Then
            Call GenGrid()
        End If
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        Call GenGrid()
    End Sub

    Private Sub grddata_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles grddata.CellDoubleClick
        If grddata.Rows.Count > 0 Then
            ObjLogNo = grddata.CurrentRow.Cells("Collogno").Value
        End If
        Me.Hide()
    End Sub
    Private Sub txtWordFilter_TextChanged(sender As Object, e As EventArgs) Handles txtWordFilter.TextChanged
        'Sitthana 20190822
        Dim FilterExp As New StringBuilder
        Dim SearchString As String
        SearchString = txtWordFilter.Text.Trim
        FilterExp.Append(" itcd LIKE '*" & SearchString & "*'")
        FilterExp.Append(" OR logno LIKE '*" & SearchString & "*'")

        If SearchString <> "" Then
            bsSearchTable.Filter = FilterExp.ToString
        Else
            bsSearchTable.Filter = ""
        End If
    End Sub
End Class