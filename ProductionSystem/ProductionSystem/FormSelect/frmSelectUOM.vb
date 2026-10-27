Public Class frmSelectUOM
    Dim UOMID As String
    Dim UOM As String
    Dim blnOk As Boolean = False
    Public Property pUOMID As String
        Get
            pUOMID = UOMID
        End Get
        Set(ByVal newvalue As String)
            UOMID = newvalue
        End Set
    End Property
    Public Property pUOM As String
        Get
            pUOM = UOM
        End Get
        Set(ByVal newvalue As String)
            UOM = newvalue
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

    Private Sub frmSelectUOM_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call GenGrid()
    End Sub

    Private Sub GenGrid()
        Dim objDB As New classSelectUOM
        Dim dt As New DataTable
        dt = objDB.SearchItems(txtFilter.Text)

        grddata.AutoGenerateColumns = False
        grddata.DataSource = dt
    End Sub

    Private Sub txtFilter_KeyDown(sender As Object, e As KeyEventArgs) Handles txtFilter.KeyDown
        If e.KeyCode = Keys.Enter Then
            Call GenGrid()
        End If
    End Sub

    Private Sub grddata_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles grddata.CellDoubleClick
        Call Getdata()
        'If grddata.Rows.Count > 0 Then
        '    UOMID = grddata.CurrentRow.Cells("colUOMId").Value
        '    UOM = grddata.CurrentRow.Cells("colUOM").Value
        'End If
        'Me.Hide()
    End Sub

    Private Sub Getdata()
        If grddata.Rows.Count > 0 Then
            UOMID = grddata.CurrentRow.Cells("colUOMId").Value
            UOM = grddata.CurrentRow.Cells("colUOM").Value
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