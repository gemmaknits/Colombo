Public Class frmSearchDFOrderPreset

    Dim strDFNo As String = ""

    Public Property pDFNo() As String
        Get
            pDFNo = strDFNo
        End Get
        Set(ByVal NewValue As String)
            strDFNo = NewValue
        End Set
    End Property

    Private Sub GenCombo()
        Dim objDB As New classMaster

        Me.cboCustomer.DataSource = objDB.GetCustomer
        Me.cboCustomer.DisplayMember = "name"
        Me.cboCustomer.ValueMember = "custcd"
        Me.cboCustomer.SelectedValue = ""

        Me.cboDesignNo.DataSource = objDB.GetDesign
        Me.cboDesignNo.DisplayMember = "design_no"
        Me.cboDesignNo.ValueMember = "design_no"
        Me.cboDesignNo.SelectedValue = ""

        Me.cboDyedHouse.DataSource = objDB.GetDyedHouse
        Me.cboDyedHouse.DisplayMember = "name"
        Me.cboDyedHouse.ValueMember = "suppcd2"
        Me.cboDyedHouse.SelectedValue = ""

        Me.cboSoNo.DataSource = objDB.GetSoNo
        Me.cboSoNo.DisplayMember = "sono2"
        Me.cboSoNo.ValueMember = "sono2"
        Me.cboSoNo.SelectedValue = ""

        Me.cboEmpCD.DataSource = objDB.GetEmp
        Me.cboEmpCD.DisplayMember = "empname"
        Me.cboEmpCD.ValueMember = "empcd2"
        Me.cboEmpCD.SelectedValue = ""
    End Sub

    Private Sub GenGrid()
        Dim config As New clsConfig
        Dim objDB As New classDFOrder
        Dim dt As New DataTable
        dt = objDB.DFPRESETLoad(txtDFNo.Text.Trim.ToUpper, dtpDateFr.Value.ToString("yyyyMMdd"), dtpDateTo.Value.ToString("yyyyMMdd"), config.IsNull(cboSoNo.SelectedValue, "").ToString.Trim, config.IsNull(cboCustomer.SelectedValue, "").ToString.Trim, config.IsNull(cboDyedHouse.SelectedValue, "").ToString.Trim, config.IsNull(cboDesignNo.SelectedValue, "").ToString.Trim, config.IsNull(cboEmpCD.SelectedValue, "").ToString.Trim)
        If dt.Rows.Count > 0 Then
            strDFNo = dt.Rows(0)("dfno")
        End If
        grdDF.AutoGenerateColumns = False
        grdDF.DataSource = dt
    End Sub

    Private Sub frmDyingOrderSearch_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        dtpDateFr.Value = DateAdd(DateInterval.Month, -1, Now)
        dtpDateTo.Value = Now
        Call GenCombo()
        Call GenGrid()
    End Sub

    Private Sub frmDyingOrderSearch_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        e.Cancel = True
        Me.Hide()
    End Sub

    Private Sub grdInv_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles grdDF.DoubleClick
        If grdDF.Rows.Count > 0 Then strDFNo = grdDF.CurrentRow.Cells("DFNo").Value
        Me.Hide()
    End Sub

    Private Sub btnRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRefresh.Click
        Call GenGrid()
    End Sub

    Private Sub btnRefresh2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRefresh2.Click
        Call GenGrid()
    End Sub

    Private Sub btnMinimized_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMinimized.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Me.Hide()
    End Sub

    Private Sub dtpDateFr_ValueChanged(sender As System.Object, e As System.EventArgs) Handles dtpDateFr.ValueChanged

    End Sub

    Private Sub grdDF_CellContentClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles grdDF.CellContentClick

    End Sub

    Private Sub cboCustomer_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cboCustomer.SelectedIndexChanged

    End Sub

End Class