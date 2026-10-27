Public Class frmStockGIN_PFD
    Dim clsConfig As New clsConfig
    Dim clsConn As New classConnection
    Dim clsUser As New classUserInfo
    Dim blnLocked As Boolean = False

    Public Property UserInfo() As classUserInfo
        Get
            UserInfo = clsUser
        End Get
        Set(ByVal NewValue As classUserInfo)
            clsUser = NewValue
        End Set
    End Property

    Private Sub InitControl()
        txtGINNo.Text = ""
        dtpGINDate.Value = Today
        txtDFNo.Text = ""
        txtLotNo.Text = ""
        txtBillNo.Text = ""
        txtRemark.Text = ""

        Call BindGrid(grdData, (New classStock).GetDIN("", clsUser.UserID, ""))
    End Sub

    Private Sub GenComboDINNo()
        Dim objDB As New classStock
        cboDocNo.ComboBox.DataSource = objDB.GetGINNoPFD()
        cboDocNo.ComboBox.DisplayMember = "tran_no"
        cboDocNo.ComboBox.ValueMember = "source_refno"
    End Sub

    Private Sub BindData(ByVal dt As DataTable)
        txtGINNo.Text = dt.Rows(0)("tran_no")
        dtpGINDate.Value = CDate(dt.Rows(0)("tran_dt"))
        txtDFNo.Text = dt.Rows(0)("dfno")
        txtLotNo.Text = dt.Rows(0)("job_line_id")
        'txtLotNo.Text = dt.Rows(0)("lot")
        txtBillNo.Text = dt.Rows(0)("source_refno")
        txtRemark.Text = dt.Rows(0)("rem_qc")
    End Sub

    Private Sub BindGrid(ByRef grd As DataGridView, ByVal dt As DataTable)
        grd.AutoGenerateColumns = False
        grd.DataSource = dt
    End Sub

    Private Sub LoadData(ByVal bill_no As String)
        Dim objDB As New classStock
        Dim dt As New DataTable
        dt = objDB.GetGINPDF(bill_no, clsUser.UserID)
        Call InitControl()
        If dt.Rows.Count > 0 Then Call BindData(dt)
        Call BindGrid(grdData, dt)
    End Sub

    Private Sub SaveData(ByVal bill_no As String)
        Dim objDB As New classStock
        Dim dt As New DataTable
        dt = objDB.SaveGINPFD(bill_no, clsUser.UserID)
        'Call InitControl()
        GenComboDINNo()
        LoadData(bill_no)
        cboDocNo.Text = txtGINNo.Text
        'If dt.Rows.Count > 0 Then Call BindData(dt)
        'Call BindGrid(grdData, dt)
    End Sub

    Private Sub frmStockGIN_PFD_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Call GenComboDINNo()
        Call btnNew_Click(sender, e)
    End Sub

    Private Sub btnNew_Click(sender As System.Object, e As System.EventArgs) Handles btnNew.Click
        Call InitControl()
    End Sub

    Private Sub btnSave_Click(sender As System.Object, e As System.EventArgs) Handles btnSave.Click
        If txtBillNo.Text.Trim.Length = 0 Then Exit Sub
        If MessageBox.Show("Would you like to save ?", "System Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then Call SaveData(txtBillNo.Text.Trim)
    End Sub

    Private Sub btnPrint_Click(sender As System.Object, e As System.EventArgs) Handles btnPrint.Click
        'print
        If txtGINNo.Text = "" Then Exit Sub
        Const rptFileName = "rptGIN.rpt"
        
        If Not clsConfig.CheckReport(clsUser.ReportPath, rptFileName) Then Exit Sub
        Dim frm As New frmReport
        Dim rpt As New CrystalDecisions.CrystalReports.Engine.ReportDocument
        Me.Cursor = Cursors.WaitCursor

        rpt.Load(clsUser.ReportPath & rptFileName)
        rpt.DataSourceConnections.Item(0).SetConnection(clsConn.servername, clsConn.database, False)
        rpt.DataSourceConnections.Item(0).SetLogon(clsConn.Userid, clsConn.Password)

        rpt.VerifyDatabase()
        rpt.SetParameterValue("@trannofr", txtGINNo.Text)
        rpt.SetParameterValue("@trannoto", txtGINNo.Text)

        'rpt.PrintOptions.PaperSize = CrystalDecisions.Shared.PaperSize.PaperLetter
        'rpt.PrintOptions.PaperOrientation = CrystalDecisions.Shared.PaperOrientation.Portrait
        'rpt.PrintOptions.PaperSource = CrystalDecisions.Shared.PaperSource.Auto

        frm.Title = "Greige In"
        frm.CRViewer.ReportSource = rpt
        frm.MdiParent = Me.ParentForm
        frm.Show()
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub btnCancel_Click(sender As System.Object, e As System.EventArgs) Handles btnCancel.Click
        If txtGINNo.Text.Trim.Length = 0 Then Exit Sub
        If MessageBox.Show("Would you like to cancel document no. " & txtGINNo.Text & " ?", "System Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            Call (New classStock).CancelGIN(txtGINNo.Text, clsUser.UserID)
            btnNew_Click(sender, e)
        End If
    End Sub

    Private Sub btnExit_Click(sender As System.Object, e As System.EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub txtBillNo_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles txtBillNo.KeyDown
        If txtBillNo.Text.Trim.Length = 0 Then Exit Sub
        If e.KeyCode = Keys.Enter Then
            txtBillNo.Enabled = False
            Call LoadData(txtBillNo.Text.Trim)
            txtBillNo.Enabled = True
        End If
    End Sub

    Private Sub cboDocNo_DropDownClosed(sender As System.Object, e As System.EventArgs) Handles cboDocNo.DropDownClosed
        If clsConfig.IsNull(cboDocNo.ComboBox.SelectedValue, "").ToString.Length = 0 Then Exit Sub
        Call LoadData(clsConfig.IsNull(cboDocNo.ComboBox.SelectedValue, ""))
    End Sub

    Private Sub frmStockGIN_PFD_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If MessageBox.Show("Would you like to close ?", "System Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.No Then
            e.Cancel = True
        End If
    End Sub

    Private Sub txtBillNo_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtBillNo.TextChanged

    End Sub

    Private Sub cboDocNo_Click(sender As System.Object, e As System.EventArgs) Handles cboDocNo.Click

    End Sub
End Class