Public Class frmSearchDR
    Dim strid As String = ""
    Dim strdr_no As String = ""
    Dim strTxtDrNo As String = ""

    Public Property pid() As String
        Get
            pid = strid
        End Get
        Set(ByVal NewValue As String)
            strid = NewValue
        End Set
    End Property

    Public Property Pdr_no() As String
        Get
            Pdr_no = strdr_no
        End Get
        Set(ByVal Newvalue As String)
            strdr_no = Newvalue
        End Set

    End Property

    Public Property pDrNo() As String
        Get
            pDrNo = strTxtDrNo
        End Get
        Set(ByVal Newvalue As String)
            strTxtDrNo = Newvalue
        End Set

    End Property


    Private Sub GenGrid()
        Dim objDB As New classSearchDR
        Dim dt As New DataTable
        If pDrNo IsNot Nothing Then
            txtDrNo.Text = pDrNo
        End If
        dt = objDB.SearchDR(txtDesign_no.Text, txtDrNo.Text)

        'If dt.Rows.Count > 0 Then
        'strid = dt.Rows(0)("id")
        'End If

        grddata.AutoGenerateColumns = False
        grddata.DataSource = dt

        If dt.Rows.Count = 1 Then
            Me.BeginInvoke(Sub()
                               grddata.ClearSelection()
                               grddata.Rows(0).Selected = True

                               Dim firstVisibleCol As DataGridViewColumn = Nothing
                               For Each col As DataGridViewColumn In grddata.Columns
                                   If col.Visible Then
                                       firstVisibleCol = col
                                       Exit For
                                   End If
                               Next
                               If firstVisibleCol IsNot Nothing Then
                                   grddata.CurrentCell = grddata.Rows(0).Cells(firstVisibleCol.Index)
                               End If
                               Call grddata_CellDoubleClick(grddata, New DataGridViewCellEventArgs(0, 0))
                           End Sub)
        End If
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
        If grddata.Rows.Count > 0 Then strid = grddata.CurrentRow.Cells("id").Value
        If grddata.Rows.Count > 0 Then strdr_no = grddata.CurrentRow.Cells("dr_no").Value
        Me.Hide()
    End Sub

    Private Sub frmSearchDR_Leave(sender As Object, e As System.EventArgs) Handles Me.FormClosed
        strid = 0

    End Sub

    Private Sub frmSearchYarnChange_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Call GenGrid()
    End Sub

    Private Sub txtDrNo_KeyDown(sender As Object, e As KeyEventArgs) Handles txtDrNo.KeyDown
        If e.KeyCode.Equals(Keys.Enter) Then
            pDrNo = txtDrNo.Text
            GenGrid()
        End If
    End Sub
End Class