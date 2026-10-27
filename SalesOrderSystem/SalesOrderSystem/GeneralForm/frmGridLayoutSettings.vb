Imports System.Data
Imports System.Data.DataSetExtensions
Imports System.Linq

Public Class frmGridLayoutSettings '22/10/2025 John
    Dim clsConfig As New clsConfig
    Dim clsConn As New classConnection
    Public clsUser As New classUserInfo
    Public clsMaster As New classMaster
    Public oGridLayoutSettings As New classGridLayoutSettings

    Public Property sourceGrid As DataGridView
    Public pGridName As String

    Public dtGridLayoutSettings As New DataTable
    Private bsGridLayoutSettings As New BindingSource
    Private drvGridLayoutSettings As DataRowView

    Public autoSave As String = "N"

    Public Property UserInfo() As classUserInfo
        Get
            Return clsUser
        End Get
        Set(ByVal NewValue As classUserInfo)
            clsUser = NewValue
        End Set
    End Property

    Private Sub frmGridLayoutSettings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
        lblGridName.Text = pGridName
        InitDataBinding_GetGridLayoutSettings()
    End Sub

    Private Sub InitDataBinding_GetGridLayoutSettings()
        dtGridLayoutSettings = oGridLayoutSettings.selectGridLayoutSettings(clsUser.UserID, "grdSalesOrder")
        bsGridLayoutSettings.DataSource = dtGridLayoutSettings

        If dtGridLayoutSettings.Columns.Count = 0 Then
            dtGridLayoutSettings.Columns.Add("user_grid_setting_id", GetType(Object))
            dtGridLayoutSettings.Columns.Add("col_data_property", GetType(String))
            dtGridLayoutSettings.Columns.Add("column_name", GetType(String))
            dtGridLayoutSettings.Columns.Add("col_visible", GetType(Boolean))
        End If

        For Each row As DataRow In dtGridLayoutSettings.Rows
            If row.IsNull("col_visible") Then
                row("col_visible") = False
            Else
                Dim val = row("col_visible")
                If TypeOf val Is Boolean Then
                    row("col_visible") = CBool(val)
                Else
                    row("col_visible") = (val.ToString().ToUpper() = "Y") OrElse (val.ToString().ToUpper() = "TRUE")
                End If
            End If
        Next

        For Each col As DataGridViewColumn In sourceGrid.Columns
            Dim exists = dtGridLayoutSettings.AsEnumerable().Any(Function(r) r("column_name").ToString() = col.HeaderText)
            If Not exists AndAlso col.Visible Then
                Dim newRow As DataRow = dtGridLayoutSettings.NewRow()
                newRow("user_grid_setting_id") = DBNull.Value
                newRow("col_data_property") = col.DataPropertyName
                newRow("column_name") = col.HeaderText
                newRow("col_visible") = col.Visible
                dtGridLayoutSettings.Rows.Add(newRow)
            End If
        Next

        dgvGridLayoutSettings.AutoGenerateColumns = False
        dgvGridLayoutSettings.DataSource = dtGridLayoutSettings
        drvGridLayoutSettings = If(dtGridLayoutSettings.Rows.Count > 0, CType(bsGridLayoutSettings.Current, DataRowView), Nothing)
    End Sub

    Private Sub btnApply_Click(sender As Object, e As EventArgs) Handles btnApply.Click
        For Each row As DataRow In dtGridLayoutSettings.Rows
            Dim colName As String = row("column_name").ToString()
            Dim colVisible As Boolean = False

            If Not row.IsNull("col_visible") Then
                Dim val = row("col_visible")
                If TypeOf val Is Boolean Then
                    colVisible = CBool(val)
                Else
                    colVisible = (val.ToString().ToUpper() = "Y") OrElse (val.ToString().ToUpper() = "TRUE")
                End If
            End If

            For Each col As DataGridViewColumn In sourceGrid.Columns
                If col.HeaderText = colName Then
                    col.Visible = colVisible
                    Exit For
                End If
            Next
        Next

        Me.DialogResult = DialogResult.OK
        Me.Close()
    End Sub
End Class
