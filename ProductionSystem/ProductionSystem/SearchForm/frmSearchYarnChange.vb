

Public Class frmSearchItems
    Dim strid_yarnchange As String = ""

    Public Property pid_yarnchange() As String
        Get
            pid_yarnchange = strid_yarnchange
        End Get
        Set(ByVal NewValue As String)
            strid_yarnchange = NewValue
        End Set
    End Property

    Private Sub GenGrid()
        Dim objDB As New classSearchYarnChange
        Dim dt As New DataTable
        dt = objDB.SearchYarnChange(txtDesign_no.Text)
        If dt.Rows.Count > 0 Then
            strid_yarnchange = dt.Rows(0)("id_yarnchange")
        End If
        grddata.AutoGenerateColumns = False
        grddata.DataSource = dt
    End Sub

    Private Sub txtDesign_no_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles txtDesign_no.KeyDown
        Dim objDB As New classSearchYarnChange
        Dim dt As New DataTable
        If e.KeyCode.Equals(Keys.Enter) Then
            GenGrid()
        End If
    End Sub


    Private Sub btnRefresh2_Click(sender As System.Object, e As System.EventArgs) Handles btnRefresh2.Click
        GenGrid()
    End Sub

    Private Sub grddata_CellContentClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles grddata.CellContentClick

    End Sub

    Private Sub grddata_CellDoubleClick(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles grddata.CellDoubleClick
        If grddata.Rows.Count > 0 Then strid_yarnchange = grddata.CurrentRow.Cells("id_yarnchange").Value
        Me.Hide()
    End Sub

    Private Sub frmSearchYarnChange_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        GenGrid()
    End Sub

    Private Sub grddata_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles grddata.CellClick
        With grddata
            If .Rows.Count > 0 Then
                Dim objDB As New classProduction
                Dim dt As DataTable = objDB.YarnChangeSelectNew(.Rows(.CurrentRow.Index).Cells("id_yarnchange").Value, "")
                DataGridView1.DataSource = Nothing
                If dt.Rows.Count > 0 Then
                    DataGridView1.AutoGenerateColumns = False
                    DataGridView1.DataSource = dt
                End If
            End If
        End With
    End Sub
End Class