Public Class frmDyedOutSampleSearchPLS
    Dim drData As DataRow

    Public Property pdrData As DataRow
        Get
            pdrData = drData
        End Get
        Set(ByVal Newvalue As DataRow)
            drData = Newvalue
        End Set
    End Property

    Private Sub frmDyedOutSampleSearchPLS_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Me.StartPosition = FormStartPosition.CenterScreen

        Call GenGrid()
    End Sub

    Private Sub GenGrid()

        grddata.AutoGenerateColumns = False
        grddata.DataSource = (New classDyedOutSampleSearchPLS).SearchPLS(txtFilter.Text)
    End Sub

    Private Sub btnRefresh_Click(sender As System.Object, e As System.EventArgs) Handles btnRefresh.Click
        Call GenGrid()
    End Sub

    Private Sub txtFilter_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles txtFilter.KeyDown
        If e.KeyCode = Keys.Enter Then
            Call GenGrid()
        End If
    End Sub

    Private Sub grddata_CellDoubleClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles grddata.CellDoubleClick
        If e.RowIndex >= 0 Then
            If grddata.Rows.Count > 0 Then
                drData = (CType(grddata.Rows(e.RowIndex).DataBoundItem, DataRowView)).Row
                Me.Close()
            End If

        End If
       
    End Sub
End Class