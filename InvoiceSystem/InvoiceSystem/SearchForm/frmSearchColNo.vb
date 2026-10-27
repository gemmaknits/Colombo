Public Class frmSearchColNo
    Dim Clsuser As New classUserInfo
    Dim strColNo As String = ""

    Public Property pColNo() As String
        Get
            pColNo = strColNo
        End Get
        Set(ByVal NewValue As String)
            strColNo = NewValue
        End Set
    End Property

    Private Sub frmSearchColNo_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Call genCbo()
        Call GenCombo()
        Call GenGrid()
    End Sub

    Private Sub GenGrid()
        Dim config As New clsConfig
        Dim objDB As New classStockDINPurchase
        Dim objdb2 As New classMaster
        Dim dt As New DataTable
        dt = objDB.GetColno(txtColNo.Text.Trim.ToUpper, config.IsNull(cboCustomer.SelectedValue, "").ToString.Trim, Clsuser.UserID)
        'dt = objdb2.GetColor()
        If dt.Rows.Count > 0 Then
            strColNo = dt.Rows(0)("col")

            'grdCol.AutoGenerateColumns = False
            'grdCol.DataSource = dt
        End If
        grdCol.AutoGenerateColumns = False
        grdCol.DataSource = dt
    End Sub
    Private Sub genCbo()
        Dim ObjDb As New classMaster
        Dim dt As New DataTable

        dt = ObjDb.GetCustomer()

        cboCustomer.DataSource = dt
        cboCustomer.DisplayMember = "name"
        cboCustomer.ValueMember = "custcd"

    End Sub

    Private Sub GenCombo()
        Dim objDB As New classMaster

        Me.colCustcd.DataSource = objDB.GetCustomer
        Me.colCustcd.DisplayMember = "name"
        Me.colCustcd.ValueMember = "custcd"
    End Sub


    Private Sub grdCol_DoubleClick(sender As Object, e As System.EventArgs) Handles grdCol.DoubleClick
        If grdCol.Rows.Count > 0 Then strColNo = grdCol.CurrentRow.Cells("col").Value
        Me.Hide()
    End Sub

    Private Sub cboCustomer_DropDownClosed(sender As Object, e As System.EventArgs) Handles cboCustomer.DropDownClosed
        GenGrid()
    End Sub

    Private Sub cboCustomer_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cboCustomer.SelectedIndexChanged

    End Sub

    Private Sub grdCol_CellContentClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles grdCol.CellContentClick

    End Sub

    Private Sub txtColNo_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles txtColNo.KeyDown
        If e.KeyCode = Keys.Enter Then
            GenGrid()
        End If
    End Sub

    Private Sub txtColNo_LostFocus(sender As Object, e As System.EventArgs) Handles txtColNo.LostFocus
        GenGrid()
    End Sub

    Private Sub txtColNo_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtColNo.TextChanged

    End Sub

    Private Sub btnRefresh_Click(sender As System.Object, e As System.EventArgs) Handles btnRefresh.Click
        Call GenGrid()
    End Sub
End Class