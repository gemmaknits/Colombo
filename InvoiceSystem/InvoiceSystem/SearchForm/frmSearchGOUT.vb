Public Class frmSearchGOUT
    Dim clsConfig As New clsConfig
    Dim strOutNo As String = ""

    Public Property pOutno As String
        Get
            pOutno = strOutNo.ToUpper
        End Get
        Set(ByVal NewValue As String)
            strOutNo = NewValue
        End Set
    End Property
    Private Sub GenCombo()
        Dim objDB As New classMaster
        Dim dt As DataTable
        dt = objDB.GetCustomer
        Me.cboCustomer.DataSource = dt
        Me.cboCustomer.DisplayMember = "name"
        Me.cboCustomer.ValueMember = "custcd"
    End Sub

    Private Sub GenGrid()
        Dim objDB As New classPackingListG
        Dim dt As New DataTable
        strOutNo = txtOutNo.Text.Trim.ToUpper
        dt = objDB.GetOutno(strOutNo, dtpDateFr.Value.ToString("yyyyMMdd"), dtpDateTo.Value.ToString("yyyyMMdd"), clsConfig.IsNull(cbocustomer.SelectedValue, "").ToString.Trim.ToUpper)
        If dt.Rows.Count > 0 Then
            strOutNo = dt.Rows(0)("outno")
        End If
        grdDOUT.AutoGenerateColumns = False
        grdDOUT.DataSource = dt
    End Sub




    Private Sub cbocustomer_DropDownClosed(sender As Object, e As System.EventArgs) Handles cbocustomer.DropDownClosed
        GenGrid()
    End Sub

    Private Sub cbocustomer_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cbocustomer.SelectedIndexChanged

    End Sub

    Private Sub dtpDateFr_LostFocus(sender As Object, e As System.EventArgs) Handles dtpDateFr.LostFocus
        GenGrid()
    End Sub

    Private Sub dtpDateFr_ValueChanged(sender As System.Object, e As System.EventArgs) Handles dtpDateFr.ValueChanged

    End Sub

    Private Sub dtpDateTo_LostFocus(sender As Object, e As System.EventArgs) Handles dtpDateTo.LostFocus
        GenGrid()
    End Sub

    Private Sub dtpDateTo_ValueChanged(sender As System.Object, e As System.EventArgs) Handles dtpDateTo.ValueChanged

    End Sub

    Private Sub grdDOUT_CellContentClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles grdDOUT.CellContentClick
        ' If grdPackinglistG.Rows.Count > 0 Then strPackNo = grdPackinglistG.CurrentRow.Cells("grdPackinglistG_packno").Value
        ' Me.Hide()
        ' End
    End Sub

    Private Sub grdDOUT_CellDoubleClick(sender As Object, e As System.EventArgs) Handles grdDOUT.CellDoubleClick
        If grdDOUT.Rows.Count > 0 Then strOutNo = grdDOUT.CurrentRow.Cells("outno").Value
        Me.Hide()

    End Sub

    Private Sub btnRefresh_Click(sender As System.Object, e As System.EventArgs) Handles btnRefresh.Click
        GenGrid()
    End Sub



    Private Sub frmSearchDOUT_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        dtpDateFr.Value = DateAdd(DateInterval.Month, -1, Now)
        dtpDateTo.Value = Now
        GenCombo()
        GenGrid()
    End Sub
End Class