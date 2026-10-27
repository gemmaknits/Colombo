Public Class frmSelectProductionOrderLinesHeader
    Dim _MfgProductionOrderLineId As Nullable(Of Int64)
    Dim _KoNo As String
    Dim blnOk As Boolean = False

    Public Property pMfgProductionOrderLineId As Nullable(Of Int64)
        Get
            pMfgProductionOrderLineId = _MfgProductionOrderLineId
        End Get
        Set(ByVal newvalue As Nullable(Of Int64))
            _MfgProductionOrderLineId = newvalue
        End Set
    End Property
    Public Property pKoNo As String
        Get
            pKoNo = _KoNo
        End Get
        Set(ByVal newvalue As String)
            _KoNo = newvalue
        End Set
    End Property

    Public Property pblnOk As Boolean
        Get
            pblnOk = blnOk
        End Get
        Set(ByVal NewValue As Boolean)
            blnOk = NewValue
        End Set
    End Property

    Private Sub frmSelectProductionOrderLines_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToParent()

        Call GenGrid()
    End Sub

    Private Sub GenGrid()
        Dim objDB As New classSelectProductionOrderLines
        Dim dt As New DataTable
        dt = objDB.SearchProductionOrderLines(txtFilter.Text)

        grddata.AutoGenerateColumns = False
        grddata.DataSource = dt
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
        Call Getdata()

    End Sub

    Private Sub btnOk_Click(sender As Object, e As EventArgs) Handles btnOk.Click
        Call Getdata()

    End Sub

    Private Sub Getdata()
        If grddata.Rows.Count > 0 Then
            _MfgProductionOrderLineId = (New clsConfig).IsNull(grddata.CurrentRow.Cells("colMfgProductionOrderLineId").Value, Nothing)
            _KoNo = (New clsConfig).IsNull(grddata.CurrentRow.Cells("colkono").Value, String.Empty)
            pblnOk = True
        End If

        Me.Hide()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        pblnOk = False
        Me.Close()
    End Sub

    Private Sub txtFilter_TextChanged(sender As Object, e As EventArgs) Handles txtFilter.TextChanged
        Call GenGrid()
    End Sub
End Class