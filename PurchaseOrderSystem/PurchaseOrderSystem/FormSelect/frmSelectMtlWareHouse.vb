Public Class frmSelectMtlWareHouse
    Dim mtlwarehouseid As String
    Dim warehousecode As String
    Dim blnOk As Boolean = False

    Public Property pMtlwarehouseid As String
        Get
            pMtlwarehouseid = mtlwarehouseid
        End Get
        Set(ByVal newvalue As String)
            mtlwarehouseid = newvalue
        End Set
    End Property
    Public Property pWarehouseCode As String
        Get
            pWarehouseCode = warehousecode
        End Get
        Set(ByVal newvalue As String)
            warehousecode = newvalue
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
    Private Sub frmSelectMtlWareHouse_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToParent()

        Call GenGrid()
    End Sub

    Private Sub GenGrid()
        Dim objDB As New classSelectMtlWareHouse
        Dim dt As New DataTable
        dt = objDB.SearchWarehouse(txtFilter.Text)

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
            mtlwarehouseid = grddata.CurrentRow.Cells("colmtlwarehouseid").Value
            warehousecode = grddata.CurrentRow.Cells("colwarehousecode").Value
            pblnOk = True
        End If

        Me.Hide()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        pblnOk = False
        Me.Close()
    End Sub
End Class