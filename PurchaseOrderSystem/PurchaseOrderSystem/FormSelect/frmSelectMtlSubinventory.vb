Public Class frmSelectMtlSubinventory
    Dim Mtlsubinventoryid As String
    Dim Subinventorycode As String
    Dim mtlwarehouseid As String
    Dim blnOk As Boolean = False


    Public Property pmtlsubinventoryid As String
        Get
            pmtlsubinventoryid = Mtlsubinventoryid
        End Get
        Set(ByVal newvalue As String)
            Mtlsubinventoryid = newvalue
        End Set
    End Property
    Public Property pSubinventorycode As String
        Get
            pSubinventorycode = Subinventorycode
        End Get
        Set(ByVal newvalue As String)
            Subinventorycode = newvalue
        End Set
    End Property

    Public Property pMtlwarehouseid As String
        Get
            pMtlwarehouseid = mtlwarehouseid
        End Get
        Set(ByVal newvalue As String)
            mtlwarehouseid = newvalue
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

    Private Sub frmSelectMtlSubinventory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToParent()

        Call GenGrid()
    End Sub

    Private Sub GenGrid()
        Dim objDB As New classSelectMtlSubInventory
        Dim dt As New DataTable
        dt = objDB.SearchSubInventory(pMtlwarehouseid, txtFilter.Text)

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
        '    Mtlsubinventoryid = grddata.CurrentRow.Cells("colMtlsubinventoryid").Value
        '    Subinventorycode = grddata.CurrentRow.Cells("colSubinventorycode").Value
        'End If
        'Me.Hide()
    End Sub

    Private Sub Getdata()
        If grddata.Rows.Count > 0 Then
            Mtlsubinventoryid = grddata.CurrentRow.Cells("colMtlsubinventoryid").Value
            Subinventorycode = grddata.CurrentRow.Cells("colSubinventorycode").Value
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