Public Class frmSearchDOUT

    Dim clsConfig As New clsConfig
    Dim strPackNo As String = ""
    Dim strOutNo As String = ""
    Dim strDoctype As String = ""
    Dim strStockType As String = ""

    Public Property pPackno As String
        Get
            pPackno = strPackNo.ToUpper
        End Get
        Set(ByVal NewValue As String)
            strPackNo = NewValue
        End Set
    End Property

    Public Property pStockType As String
        Get
            pStockType = strStockType.ToUpper
        End Get
        Set(ByVal NewValue As String)
            strStockType = NewValue
        End Set
    End Property

    Public Property pOutno As String
        Get
            pOutno = strOutNo.ToUpper
        End Get
        Set(ByVal NewValue As String)
            strOutNo = NewValue
        End Set
    End Property

    Public Property pDoctype As String
        Get
            pDoctype = strDoctype.ToUpper
        End Get
        Set(ByVal NewValue As String)
            strDoctype = NewValue
        End Set
    End Property
    Private Sub GenCombo()
        Dim objDB As New classMaster
        Dim dt As DataTable
        dt = objDB.GetCustomer
        Me.cboCustomer.DataSource = dt
        Me.cboCustomer.DisplayMember = "name"
        Me.cbocustomer.ValueMember = "custcd"

        Me.CboDoctype.DataSource = objDB.GetDocType
        Me.CboDoctype.DisplayMember = "name"
        Me.CboDoctype.ValueMember = "doctyp"
        Me.CboDoctype.SelectedIndex = -1
    End Sub
    Private Sub GenGrid()
        Dim objDB As New classSearchDOUT
        Dim dt As New DataTable
        strOutNo = txtOutNo.Text.Trim.ToUpper
        dt = objDB.SearchOUTno(strOutNo, dtpDateFr.Value.ToString("yyyyMMdd"), dtpDateTo.Value.ToString("yyyyMMdd"), clsConfig.IsNull(cbocustomer.SelectedValue, "").ToString.Trim.ToUpper, clsConfig.IsNull(CboDoctype.SelectedValue, strDoctype))
        If dt.Rows.Count > 0 Then
            'strPackNo = dt.Rows(0)("packno")
            strOutNo = dt.Rows(0)("outno")
        End If
        grdData.AutoGenerateColumns = False
        grdData.DataSource = dt
    End Sub

    Private Sub frmSearchPackingListD_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        dtpDateFr.Value = DateAdd(DateInterval.Month, -1, Now)
        dtpDateTo.Value = Now
        GenCombo()
        GenGrid()
    End Sub

    Private Sub btnRefresh2_Click(sender As System.Object, e As System.EventArgs) Handles btnRefresh2.Click
        GenGrid()
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

    Private Sub grdPackinglistD_CellContentClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles grdData.CellContentClick
        ' If grdPackinglistG.Rows.Count > 0 Then strPackNo = grdPackinglistG.CurrentRow.Cells("grdPackinglistG_packno").Value
        ' Me.Hide()
        ' End
    End Sub

    Private Sub grdPackinglistD_CellDoubleClick(sender As Object, e As System.EventArgs) Handles grdData.CellDoubleClick
        If grdData.Rows.Count > 0 Then strPackNo = grdData.CurrentRow.Cells("outno").Value
        Me.Hide()

    End Sub

    Private Sub btnRefresh_Click(sender As System.Object, e As System.EventArgs) Handles btnRefresh.Click
        GenGrid()
    End Sub
End Class