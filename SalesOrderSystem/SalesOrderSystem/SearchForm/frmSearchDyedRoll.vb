Imports System.Data.SqlClient
Imports System.Text

Public Class frmSearchDyedRoll
    'Writen By      : Sitthana Boonlom
    'Writen Date    : 20240206

#Region "Property"
    Private clsUser As classUserInfo
    Private _Roll_No As String

    Public Property UserInfo() As classUserInfo
        Get
            UserInfo = clsUser
        End Get
        Set(ByVal NewValue As classUserInfo)
            clsUser = NewValue
        End Set
    End Property

    Public Property Roll_No As String
        Get
            Roll_No = _Roll_No
        End Get
        Set(ByVal Newvalue As String)
            _Roll_No = Newvalue
        End Set
    End Property

#End Region


    Private bsSearchTable As BindingSource

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub frmSearchDyedRoll_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        getData()
    End Sub

    Private Sub getData()
        Dim clsDINManual As New classDINManual
        Dim dt As New DataTable

        dt = clsDINManual.GetDINRollNo
        grdData.DataSource = Nothing
        If Not dt Is Nothing Then
            bsSearchTable = New BindingSource
            bsSearchTable.DataSource = dt
            grdData.AutoGenerateColumns = False
            grdData.DataSource = bsSearchTable
            bsSearchTable.MoveFirst()
        End If
    End Sub

    Private Sub txtWordFilter_TextChanged(sender As Object, e As EventArgs) Handles txtWordFilter.TextChanged
        Dim FilterExp As New StringBuilder
        Dim SearchString As String
        SearchString = txtWordFilter.Text.Trim
        FilterExp.Append(" roll_no_d LIKE '*" & SearchString & "*'")
        FilterExp.Append(" or dinno LIKE '*" & SearchString & "*'")
        FilterExp.Append(" or design_no LIKE '*" & SearchString & "*'")
        FilterExp.Append(" or lot LIKE '*" & SearchString & "*'")

        If SearchString <> "" Then
            bsSearchTable.Filter = FilterExp.ToString
        Else
            bsSearchTable.Filter = ""
        End If
    End Sub


    Private Sub btnOk_Click(sender As Object, e As EventArgs) Handles btnOk.Click
        ReturnValue()
    End Sub

    Private Sub grdData_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles grdData.CellDoubleClick
        ReturnValue()
    End Sub

    Private Sub ReturnValue()
        With grdData
            If .Rows.Count > 0 Then
                _Roll_No = .Rows(.CurrentRow.Index).Cells("roll_no_d").Value
            Else
                _Roll_No = ""
            End If
        End With
        Me.Close()
    End Sub
End Class