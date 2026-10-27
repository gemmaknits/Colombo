Public Class frmSelectMfgProductionSteps
    Dim MfgProductionStepsId As String 'Nullable(Of Int64) 'string
    Dim OperationCode As String
    Dim ProductionOrderNo As String
    Dim blnOk As Boolean = False

    Public Property pMfgProductionStepsId As String 'Nullable(Of Int64) 'String
        Get
            pMfgProductionStepsId = MfgProductionStepsId
        End Get
        Set(ByVal newvalue As String) 'Nullable(Of Int64)) 'String)
            MfgProductionStepsId = newvalue
        End Set
    End Property
    Public Property pOperationCode As String
        Get
            pOperationCode = OperationCode
        End Get
        Set(ByVal newvalue As String)
            OperationCode = newvalue
        End Set
    End Property

    Public Property pProductionOrderNo As String
        Get
            pProductionOrderNo = ProductionOrderNo
        End Get
        Set(ByVal newvalue As String)
            ProductionOrderNo = newvalue
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

    Private Sub frmSelectMfgProductionSteps_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Me.StartPosition = FormStartPosition.CenterScreen
        Call GenGrid()
    End Sub

    Private Sub GenGrid()
        Dim objDB As New classSelectMfgProductionSteps
        Dim dt As New DataTable
        dt = objDB.SearchProductionSteps(pProductionOrderNo, txtFilter.Text)

        grddata.AutoGenerateColumns = False
        grddata.DataSource = dt
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        Call GenGrid()
    End Sub

    Private Sub txtFilter_KeyDown(sender As Object, e As KeyEventArgs) Handles txtFilter.KeyDown
        If e.KeyCode = Keys.Enter Then
            Call GenGrid()
        End If
    End Sub

    Private Sub grddata_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles grddata.CellDoubleClick
        Call Getdata()
        'If grddata.Rows.Count > 0 Then
        '    MfgProductionStepsId = grddata.CurrentRow.Cells("colMfgPoductionStepsId").Value
        '    OperationCode = grddata.CurrentRow.Cells("colOperationCode").Value
        'End If
        'Me.Hide()
    End Sub

    Private Sub Getdata()
        If grddata.Rows.Count > 0 Then
            MfgProductionStepsId = grddata.CurrentRow.Cells("colMfgPoductionStepsId").Value
            OperationCode = grddata.CurrentRow.Cells("colOperationCode").Value
            pblnOk = True
        End If
        Me.Hide()
    End Sub

    Private Sub btnOk_Click(sender As Object, e As EventArgs) Handles btnOk.Click
        Call Getdata()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        pblnOk = False
        Me.Close()
    End Sub
End Class