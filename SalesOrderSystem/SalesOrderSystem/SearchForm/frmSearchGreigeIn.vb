Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.Text

Public Class frmSearchGreigeIn
    'Writen By      : Sitthana Boonlom
    'Writen Date    : 21/02/2024

#Region "Properties"
    Public _TranNo As String

    Public Property TranNo As String
        Get
            TranNo = _TranNo
        End Get
        Set(ByVal NewValue As String)
            _TranNo = NewValue
        End Set
    End Property
#End Region

    Private clsStock As New classStock

    Private dt As New DataTable
    Private bsSearchTable As New BindingSource


    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        _TranNo = ""
        Me.Close()
    End Sub

    Private Sub frmSearchGreigeIn_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        initComboBox()

        Dim FirstDay As New Date(Year(Today), Month(Today), 1, 12, 0, 0)
        dtpDateFrom.Value = FirstDay
    End Sub

    Private Sub initComboBox()
        With cmbTranType
            .DataSource = clsStock.getGInTranType
            .DisplayMember = "tran_type"
            .ValueMember = "tran_type"
            .SelectedValue = "KNITTING"
        End With
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        grdData.DataSource = Nothing
        dt = clsStock.getRollsOfGin(cmbTranType.SelectedValue, Format(dtpDateFrom.Value, "yyyyMMdd"), Format(dtpDateTo.Value, "yyyyMMdd"))
        With grdData
            grdData.AutoGenerateColumns = False
            bsSearchTable.DataSource = dt
            grdData.DataSource = bsSearchTable
            bsSearchTable.MoveFirst()
        End With
    End Sub

    Private Sub txtWordFilter_TextChanged(sender As Object, e As EventArgs) Handles txtWordFilter.TextChanged
        Dim FilterExp As New StringBuilder
        Dim SearchString As String
        SearchString = txtWordFilter.Text.Trim
        FilterExp.Append(" tran_no LIKE '*" & SearchString & "*'")
        FilterExp.Append(" or design_no LIKE '*" & SearchString & "*'")
        FilterExp.Append(" or kono LIKE '*" & SearchString & "*'")
        FilterExp.Append(" or roll_no LIKE '*" & SearchString & "*'")
        FilterExp.Append(" or kono LIKE '*" & SearchString & "*'")

        If SearchString <> "" Then
            bsSearchTable.Filter = FilterExp.ToString
        Else
            bsSearchTable.Filter = ""
        End If
    End Sub

    Private Sub btnOk_Click(sender As Object, e As EventArgs) Handles btnOk.Click
        With grdData
            If .Rows.Count > 0 Then
                _TranNo = .Rows(.CurrentRow.Index).Cells("tran_no").Value.ToString
                Me.Close()
            End If
        End With
    End Sub
End Class