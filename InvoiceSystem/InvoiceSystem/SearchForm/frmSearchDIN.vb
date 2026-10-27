Public Class frmSearchDIN
    Dim strDINNO As String
    Dim strStockType As String = ""
    Dim strOutReqtyp As String = ""
    Dim clsConfig As New clsConfig

    Public Property pDINNO As String
        Get
            pDINNO = strDINNO
        End Get
        Set(ByVal NewValue As String)
            strDINNO = NewValue
        End Set
    End Property

    Public Property pStockType() As String
        Get
            pStockType = strStockType
        End Get
        Set(ByVal NewValue As String)
            strStockType = NewValue
        End Set
    End Property

    Public Property pOutReqTyp() As String
        Get
            pOutReqTyp = strOutReqTyp
        End Get
        Set(ByVal NewValue As String)
            strOutReqTyp = NewValue
        End Set
    End Property


    Private Sub frmSearchDINNO_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        dtpDateFr.Value = DateAdd(DateInterval.Month, -1, Now)
        dtpDateTo.Value = Now
        Call GenCombo()
        Call GenGrid()
    End Sub

    Private Sub GenGrid()
        Dim objDB As New classSearchDIN
        Dim dt As New DataTable
        dt = objDB.SearchDINNo(strStockType, txtDINNo.Text.Trim.ToUpper, dtpDateFr.Value.ToString("yyyyMMdd"), dtpDateTo.Value.ToString("yyyyMMdd"), clsConfig.IsNull(cboCustomer.SelectedValue, "").ToString.Trim.ToUpper, clsConfig.IsNull(CboDoc_type.SelectedValue, strOutReqtyp), txtDono.Text)
        If dt.Rows.Count > 0 Then
            strDINNO = dt.Rows(0)("dinno")
        End If
        grdData.AutoGenerateColumns = False
        grdData.DataSource = dt
    End Sub

    Private Sub GenCombo()
        Dim objDB As New classMaster
        Dim dt As DataTable
        dt = objDB.GetCustomer
        Me.cboCustomer.DataSource = dt
        Me.cboCustomer.DisplayMember = "name"
        Me.cboCustomer.ValueMember = "custcd"

        Me.CboDoc_type.DataSource = objDB.GetDocType
        Me.CboDoc_type.DisplayMember = "name"
        Me.CboDoc_type.ValueMember = "doctyp"
        Me.CboDoc_type.SelectedIndex = -1

    End Sub

    Private Sub CboDoc_type_DropDownClosed(sender As Object, e As System.EventArgs) Handles CboDoc_type.DropDownClosed
        Call GenGrid()
    End Sub

    Private Sub btnRefresh2_Click(sender As System.Object, e As System.EventArgs) Handles btnRefresh2.Click
        Call GenGrid()
    End Sub

    Private Sub btnExit_Click(sender As System.Object, e As System.EventArgs) Handles btnExit.Click
        strDINNO = ""
        Me.Close()
    End Sub

    Private Sub txtDINNo_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles txtDINNo.KeyDown
        If e.KeyCode = Keys.Enter Then
            Call GenGrid()
        End If
    End Sub

    Private Sub txtDINNo_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtDINNo.TextChanged

    End Sub

    Private Sub cboCustomer_DropDownClosed(sender As Object, e As System.EventArgs) Handles cboCustomer.DropDownClosed
        Call GenGrid()
    End Sub

    Private Sub cboCustomer_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cboCustomer.SelectedIndexChanged

    End Sub

    Private Sub grdData_CellContentClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles grdData.CellContentClick

    End Sub

    Private Sub grdData_CellDoubleClick(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles grdData.CellDoubleClick
        If grdData.Rows.Count > 0 Then strDINNO = grdData.CurrentRow.Cells("dinno").Value
        Me.Hide()
    End Sub

    Private Sub btnRefresh_Click(sender As System.Object, e As System.EventArgs) Handles btnRefresh.Click
        Call GenGrid()
    End Sub

    Private Sub txtDono_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles txtDono.KeyDown
        If e.KeyCode = Keys.Enter Then
            Call GenGrid()
        End If
    End Sub

    Private Sub txtDono_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtDono.TextChanged

    End Sub
End Class