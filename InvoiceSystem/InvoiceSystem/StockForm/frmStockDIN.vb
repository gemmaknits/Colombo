Public Class frmStockDIN
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
        txtDINNo.Text = ""
        dtpDINDate.Value = Today
        txtDFNo.Text = ""
        txtLotNo.Text = ""
        txtBillNo.Text = ""
        txtRemark.Text = ""

        Call BindGrid(grdData, (New classStock).GetDIN("", clsUser.UserID, ""))
    End Sub

    Private Sub GenComboDINNo()
        Dim objDB As New classStock
        cboDocNo.ComboBox.DataSource = objDB.GetDINNo()
        cboDocNo.ComboBox.DisplayMember = "dinno"
        cboDocNo.ComboBox.ValueMember = "dono"
    End Sub

    Private Sub BindData(ByVal dt As DataTable)
        txtDINNo.Text = dt.Rows(0)("dinno")
        dtpDINDate.Value = CDate(dt.Rows(0)("dindt"))
        txtDFNo.Text = dt.Rows(0)("dfno")
        txtLotNo.Text = dt.Rows(0)("lot")
        txtBillNo.Text = dt.Rows(0)("dono")
        txtRemark.Text = dt.Rows(0)("rem_qc")
    End Sub

    Private Sub BindGrid(ByRef grd As DataGridView, ByVal dt As DataTable)
        grd.AutoGenerateColumns = False
        grd.DataSource = dt

        SumGrdData()
    End Sub

    Private Sub LoadData(ByVal bill_no As String)
        Dim objDB As New classStock
        Dim dt As New DataTable
        Dim StrError As String = ""

        dt = objDB.GetDIN(bill_no, clsUser.UserID, StrError)
        If StrError.Length > 0 Then
            MessageBox.Show(StrError, "SyStem Message", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
        End If
        'Call InitControl() '?

        If dt.Rows.Count > 0 Then Call BindData(dt)
        Call BindGrid(grdData, dt)
    End Sub

    Private Sub SaveData(ByVal bill_no As String)
        Dim objDB As New classStock
        Dim dt As New DataTable
        dt = objDB.SaveDIN(bill_no, clsUser.UserID)
        Call InitControl()
        If dt.Rows.Count > 0 Then Call BindData(dt)
        Call BindGrid(grdData, dt)
    End Sub

    Private Sub frmStockDIN_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
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
        If txtBillNo.Text = "" Then Exit Sub
        Const rptFileName = "rptDIN.rpt"
        'Const rptFileName = "rptStockDIN.rpt"
        
        If Not clsConfig.CheckReport(clsUser.ReportPath, rptFileName) Then Exit Sub
        Dim frm As New frmReport
        Dim rpt As New CrystalDecisions.CrystalReports.Engine.ReportDocument
        Me.Cursor = Cursors.WaitCursor

        rpt.Load(clsUser.ReportPath & rptFileName)
        rpt.DataSourceConnections.Item(0).SetConnection(clsConn.servername, clsConn.database, False)
        rpt.DataSourceConnections.Item(0).SetLogon(clsConn.Userid, clsConn.Password)

        rpt.VerifyDatabase()
        'rpt.SetParameterValue("@bill_no", txtBillNo.Text)
        rpt.SetParameterValue("@dinno", txtDINNo.Text)
        'rpt.SetParameterValue("@logempcd", clsUser.UserID)

        'rpt.PrintOptions.PaperSize = CrystalDecisions.Shared.PaperSize.PaperLetter
        'rpt.PrintOptions.PaperOrientation = CrystalDecisions.Shared.PaperOrientation.Portrait
        'rpt.PrintOptions.PaperSource = CrystalDecisions.Shared.PaperSource.Auto

        frm.Title = "Stock Dyed In"
        frm.CRViewer.ReportSource = rpt
        frm.MdiParent = Me.ParentForm
        frm.Show()
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub btnCancel_Click(sender As System.Object, e As System.EventArgs) Handles btnCancel.Click
        If txtDINNo.Text.Trim.Length = 0 Then Exit Sub
        If MessageBox.Show("Would you like to cancel document no. " & txtDINNo.Text & " ?", "System Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            Call (New classStock).CancelDIN(txtDINNo.Text, clsUser.UserID)
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

    Private Sub txtBillNo_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtBillNo.TextChanged

    End Sub

    Private Sub cboDocNo_Click(sender As System.Object, e As System.EventArgs) Handles cboDocNo.Click

    End Sub
    Private Sub SumGrdData()

        Dim config As New clsConfig
        Dim i As Integer = 0
        Dim j As Integer = 0
        Dim dblKgs As Double = 0
        Dim dblMts As Double = 0
        Dim dblYds As Double = 0

        Dim netwt As Double = 0.0
        Dim anetwt As Double = 0.0
        Dim CartMts As Double = 0.0
        Dim CartYds As Double = 0.0
        Dim totalroll As Double = 0

        For i = 0 To grdData.Rows.Count - 1
            dblKgs = dblKgs + config.IsNull(grdData.Rows(i).Cells("kg").Value, 0)
            dblMts = dblMts + config.IsNull(grdData.Rows(i).Cells("mts").Value, 0)
            dblYds = dblYds + config.IsNull(grdData.Rows(i).Cells("yds").Value, 0)
        Next

        txtTotalRolls.Text = FormatNumber(grdData.Rows.Count, 0, TriState.False, TriState.False, TriState.True)
        txtTotalKgs.Text = FormatNumber(dblKgs, 2, TriState.False, TriState.False, TriState.True)
        txtTotalMts.Text = FormatNumber(dblMts, 2, TriState.False, TriState.False, TriState.True)
        txtTotalYds.Text = FormatNumber(dblYds, 2, TriState.False, TriState.False, TriState.True)

    End Sub

    Private Sub grdData_CellContentClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles grdData.CellContentClick

    End Sub
End Class