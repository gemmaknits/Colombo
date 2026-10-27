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
        Call GenCombo()
        Call GenComboDINNo()

        txtGINNo.Text = ""
        dtpGINDate.Value = Today
        txtDFNo.Text = ""
        txtLotNo.Text = ""
        txtBillNo.Text = ""
        txtRemark.Text = ""

        btnEntryDefectRoll.Enabled = False

        Call BindGrid(grdData, (New classStock).GetDIN("", clsUser.UserID, ""))
        txtBillNo.Select()
    End Sub

    Private Sub GenCombo()

        cbomtl_warehouse.DataSource = (New classMaster).Combomtlwarehouse(clsUser.UserID)
        cbomtl_warehouse.DisplayMember = "warehouse_code"
        cbomtl_warehouse.ValueMember = "mtl_warehouse_id"
        cbomtl_warehouse.SelectedIndex = -1

        cbomtl_subinventory.DataSource = Nothing
        cbomtl_subinventory.SelectedIndex = -1

        cbomtl_location.DataSource = Nothing
        cbomtl_location.SelectedIndex = -1

        Me.cboDyedHouse.DataSource = (New classMaster).GetDyedHouse
        Me.cboDyedHouse.DisplayMember = "name"
        Me.cboDyedHouse.ValueMember = "suppcd2"
        Me.cboDyedHouse.SelectedIndex = -1
        'GetComboNewSubInventory(Int64mtl_warehouse_id:=cbomtl_warehouse.SelectedValue)
        'GetComboLocation(Int64mtl_warehouse_id:=cbomtl_warehouse.SelectedValue, Int64mtl_subinventory_id:=cbomtl_subinventory.SelectedValue, Int64mtl_locations_id:=cbomtl_location.SelectedValue)
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
        ' txtLotNo.Text = dt.Rows(0)("job_line_id")
        txtLotNo.Text = (New clsConfig).IsNull(dt.Rows(0)("lot"), "")
        txtBillNo.Text = dt.Rows(0)("source_refno")
        txtRemark.Text = dt.Rows(0)("rem_qc")

        cbomtl_warehouse.SelectedValue = dt.Rows(0)("mtl_warehouse_id")
        GetComboNewSubInventory(Int64mtl_warehouse_id:=cbomtl_warehouse.SelectedValue)
        cbomtl_subinventory.SelectedValue = dt.Rows(0)("mtl_subinventory_id")
        GetComboLocation(Int64mtl_warehouse_id:=cbomtl_warehouse.SelectedValue, Int64mtl_subinventory_id:=cbomtl_subinventory.SelectedValue, Int64mtl_locations_id:=cbomtl_location.SelectedValue)
        cbomtl_location.SelectedValue = dt.Rows(0)("mtl_locations_id")

        cboDyedHouse.SelectedValue = dt.Rows(0)("dhcod")
    End Sub

    Private Sub BindGrid(ByRef grd As DataGridView, ByVal dt As DataTable)
        grd.AutoGenerateColumns = False
        grd.DataSource = dt
    End Sub

    Private Sub LoadData(ByVal bill_no As String)
        Dim objDB As New classStock
        Dim dt As New DataTable
        Dim Strerror As String = ""

        dt = objDB.GetGINPDF(bill_no, clsUser.UserID, Strerror)
        If Strerror.Length > 0 Then
            MessageBox.Show(Strerror, "SyStem Message", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
        End If
        Call InitControl()
        If dt.Rows.Count > 0 Then Call BindData(dt)
        Call BindGrid(grdData, dt)
    End Sub

    Private Sub SaveData(ByVal bill_no As String)
        Dim objDB As New classStock
        Dim dt As New DataTable
        Dim StrMessage As String = ""
        'dt = objDB.SaveGINPFD(bill_no, clsUser.UserID, StrMessage)
        dt = objDB.SaveGINPFD(strBillNo:=bill_no, strEmpCode:=clsUser.UserID,
                              StrLoc:=cbomtl_location.Text,
                              Int64mtl_warehouse_id:=cbomtl_warehouse.SelectedValue,
                              Int64mtl_locations_id:=cbomtl_location.SelectedValue,
                              Int64mtl_subinventory_id:=cbomtl_subinventory.SelectedValue,
                              StrMessage:=StrMessage)

        If StrMessage.Trim.Length > 0 Then MessageBox.Show(StrMessage, "System Message", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)

        'Call InitControl()
        GenComboDINNo()
        LoadData(bill_no)
        cboDocNo.Text = txtGINNo.Text
        'If dt.Rows.Count > 0 Then Call BindData(dt)
        'Call BindGrid(grdData, dt)
    End Sub

    Private Sub frmStockGIN_PFD_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        Me.WindowState = FormWindowState.Maximized

        'Call GenComboDINNo()

        Call InitControl()
    End Sub

    Private Sub btnNew_Click(sender As System.Object, e As System.EventArgs) Handles btnNew.Click
        Call InitControl()
    End Sub

    Private Sub btnSave_Click(sender As System.Object, e As System.EventArgs) Handles btnSave.Click
        If txtBillNo.Text.Trim.Length = 0 Then Exit Sub
        If MessageBox.Show("Would you like to save ?", "System Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then Call SaveData(txtBillNo.Text.Trim)
        If txtGINNo.Text.Trim <> "" Then
            btnEntryDefectRoll.Enabled = True
        End If
    End Sub

    Private Sub btnPrint_Click(sender As System.Object, e As System.EventArgs)
        'print
        If txtGINNo.Text = "" Then Exit Sub
        Const rptFileName = "rptGIN.rpt"
        If clsUser.ReportPath = "" Then clsUser.ReportPath = clsUser.ReportPath
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
        'Sitthana 20220624 Changed Windows.Forms.DialogResult To DialogResult
        Dim result As DialogResult ' Windows.Forms.DialogResult
        result = MessageBox.Show("Would you like to cancel document no. " & txtGINNo.Text & " ?", "System Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button3)
        If result <> DialogResult.Yes Then Exit Sub

        If Not CheckDataCancel() Then Exit Sub

        Dim message As String = ""

        If (New classStock).CancelGIN(strGINNo:=txtGINNo.Text, Dtptran_dt:=dtpGINDate.Value, strEmpCode:=clsUser.UserID, Strmessage:=message) Then
            MessageBox.Show("cancel is completed", "System Message!", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Call btnNew_Click(sender, e)
        Else
            MessageBox.Show(message, "System Message!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
        'If txtGINNo.Text.Trim.Length = 0 Then Exit Sub
        'If MessageBox.Show("Would you like to cancel document no. " & txtGINNo.Text & " ?", "System Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
        '    Call (New classStock).CancelGIN(txtGINNo.Text, dtpGINDate.Value, clsUser.UserID)
        '    btnNew_Click(sender, e)
        'End If
    End Sub

    Private Function CheckDataCancel() As Boolean
        If txtGINNo.Text.Trim.Length = 0 Then
            MessageBox.Show("คุณยังไม่ได้เลือก D IN No.", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return False
            Exit Function
        End If

        Return True
    End Function

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

    Private Sub cbomtl_warehouse_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbomtl_warehouse.SelectedIndexChanged

    End Sub

    Private Sub cbomtl_warehouse_SelectedValueChanged(sender As Object, e As EventArgs) Handles cbomtl_warehouse.SelectedValueChanged

    End Sub

    Private Sub GetComboNewSubInventory(Optional ByVal Int64mtl_warehouse_id As Nullable(Of Int64) = Nothing)
        Dim objdb As New classMaster

        cbomtl_subinventory.DataSource = objdb.ComboMtlsubinventory(Int64mtl_warehouse_id)
        cbomtl_subinventory.DisplayMember = "subinventory_code"
        cbomtl_subinventory.ValueMember = "mtl_subinventory_id"

        'Setdefaultsubinventory(dt:=cbomtl_subinventory.DataSource)

    End Sub

    Private Sub GetComboLocation(Optional ByVal Int64mtl_warehouse_id As Nullable(Of Int64) = Nothing,
                                 Optional ByVal Int64mtl_subinventory_id As Nullable(Of Int64) = Nothing,
                                 Optional ByVal Int64mtl_locations_id As Nullable(Of Int64) = Nothing)
        Dim objdb As New classMaster
        cbomtl_location.DataSource = objdb.Combomtllocations(strUSerID:=clsUser.UserID, INt64mtl_warehouse_id:=Int64mtl_warehouse_id, Int64mtl_subinventory_id:=Int64mtl_subinventory_id)
        cbomtl_location.DisplayMember = "location_name"
        cbomtl_location.ValueMember = "mtl_locations_id"


    End Sub
    Private Sub SetDefaultLocation(ByVal dt As DataTable)
        Dim expression As String
        expression = "location_name like '%N/A%'"
        Dim foundRows() As DataRow
        foundRows = dt.Select(expression)

        cbomtl_location.SelectedValue = foundRows(0)(0)

    End Sub

    Private Sub Setdefaultsubinventory(ByVal dt As DataTable)

        Dim expression As String
        expression = "subinventory_code like '%PFD%'"
        Dim foundRows() As DataRow
        foundRows = dt.Select(expression)

        cbomtl_subinventory.SelectedValue = foundRows(0)(0)


    End Sub

    Private Sub cbomtl_subinventory_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbomtl_subinventory.SelectedIndexChanged

    End Sub

    Private Sub cbomtl_subinventory_SelectedValueChanged(sender As Object, e As EventArgs) Handles cbomtl_subinventory.SelectedValueChanged

    End Sub

    Private Sub cbomtl_subinventory_DropDownClosed(sender As Object, e As EventArgs) Handles cbomtl_subinventory.DropDownClosed
        Call GetComboLocation(Int64mtl_warehouse_id:=(New clsConfig).IsNull(cbomtl_warehouse.SelectedValue, Nothing),
                              Int64mtl_subinventory_id:=(New clsConfig).IsNull(cbomtl_subinventory.SelectedValue, Nothing))
        Call SetDefaultLocation(cbomtl_location.DataSource)
    End Sub

    Private Sub cbomtl_warehouse_DropDownClosed(sender As Object, e As EventArgs) Handles cbomtl_warehouse.DropDownClosed
        Call GetComboNewSubInventory(Int64mtl_warehouse_id:=(New clsConfig).IsNull(cbomtl_warehouse.SelectedValue, Nothing))
        Call Setdefaultsubinventory(cbomtl_subinventory.DataSource)
        Call GetComboLocation(Int64mtl_warehouse_id:=(New clsConfig).IsNull(cbomtl_warehouse.SelectedValue, Nothing),
                              Int64mtl_subinventory_id:=(New clsConfig).IsNull(cbomtl_subinventory.SelectedValue, Nothing))
        Call SetDefaultLocation(cbomtl_location.DataSource)
    End Sub

    Private Sub txtBillNo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtBillNo.KeyPress

    End Sub

    Private Sub btnEntryDefectRoll_Click(sender As Object, e As EventArgs) Handles btnEntryDefectRoll.Click
        If txtGINNo.Text.Trim = "" Then
            MessageBox.Show("ให้คุณเลือก เลขที่ G-In ก่อนครับ", "ข้อความเตือน", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
        Else
            Dim ObjfrmStockDefectRollGIN_PFD As New frmStockGIN_PFD_DefectRoll
            ObjfrmStockDefectRollGIN_PFD.TranNo = txtGINNo.Text.Trim
            ObjfrmStockDefectRollGIN_PFD.TranDt = dtpGINDate.Text.Trim
            ObjfrmStockDefectRollGIN_PFD.ShowDialog()
        End If
    End Sub

    Private Sub txtLotNo_KeyDown(sender As Object, e As KeyEventArgs) Handles txtLotNo.KeyDown
        If txtLotNo.Text.Trim.Length = 0 Then Exit Sub
        If e.KeyCode = Keys.Enter Then
            txtLotNo.Enabled = False
            Call LoadData(txtLotNo.Text.Trim)
            txtLotNo.Enabled = True
        End If
    End Sub

    Private Sub BtnPrintBarcode_Click(sender As Object, e As EventArgs) Handles BtnPrintBarcode.Click
        Dim clsconn As New classConnection
        Dim clsConfig As New clsConfig
        Dim rptFileName = "rptGreigeBarcode.rpt"
        If clsUser.ReportPath = "" Then clsUser.ReportPath = clsUser.ReportPath
        'clsUser.ReportPath = "C:\Users\DELL\Desktop\GemmaKnits\"
        If Not clsConfig.CheckReport(clsUser.ReportPath, rptFileName) Then Exit Sub
        Dim frm As New frmReport
        Dim rpt As New CrystalDecisions.CrystalReports.Engine.ReportDocument
        Dim stype As String = ""
        Dim ord As String = ""
        Me.Cursor = Cursors.WaitCursor

        rpt.Load(clsUser.ReportPath & rptFileName)
        rpt.DataSourceConnections.Item(0).SetConnection(clsconn.servername, clsconn.database, False)
        rpt.DataSourceConnections.Item(0).SetLogon(clsconn.Userid, clsconn.Password)
        rpt.VerifyDatabase()
        rpt.SetParameterValue("@roll_no", txtGINNo.Text)
        rpt.SetParameterValue("@loc", "")
        rpt.SetParameterValue("@logempcd", UserInfo.UserID)

        'rpt.PrintOptions.PaperSize = CrystalDecisions.Shared.PaperSize.PaperLetter
        'rpt.PrintOptions.PaperOrientation = CrystalDecisions.Shared.PaperOrientation.Portrait
        'rpt.PrintOptions.PaperSource = CrystalDecisions.Shared.PaperSource.Auto

        frm.Title = "Greige Barcode"
        frm.CRViewer.ReportSource = rpt
        frm.MdiParent = Me.ParentForm
        frm.Show()
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub BtnCopy_Click(sender As Object, e As EventArgs) Handles BtnCopy.Click
        MessageBox.Show("ถ้าต้องการ Copy ม้วน ให้ใช้โปรแกรม GIN PFD Manual" & vbCrLf & "IF YOU NEED TO COPY ROLL , SHOULD BE USE GIN PFD MANUAL", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub tsbGInDocument_Click(sender As Object, e As EventArgs) Handles tsbGInDocument.Click
        'print
        If txtGINNo.Text = "" Then Exit Sub
        Const rptFileName = "rptGIN.rpt"
        If clsUser.ReportPath = "" Then clsUser.ReportPath = clsUser.ReportPath
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

    Private Sub tsbGInTag_Click(sender As Object, e As EventArgs) Handles tsbGInTag.Click
        Dim clsConfig As New clsConfig
        Dim rptFileName As String = "rptGreigeBarcode.rpt"
        Dim objdb As New classStockGIN_KOManual
        'Dim dt As DataTable = objdb.Validate_RollNo_WareHouse(StrRollno:=txtGINNo.Text.Trim, StrEmpcd:=clsUser.UserID)

        'If dt.Rows.Count > 0 Then
        '    If dt.Rows(0)("mtl_warehouse_id").ToString.Trim = "7" Then
        '        rptFileName = "rptGreigeBarcodeEschler.rpt"
        '    Else
        '        rptFileName = "rptGreigeBarcode.rpt"
        '    End If

        'End If

        If clsUser.ReportPath = "" Then clsUser.ReportPath = clsUser.ReportPath
        'clsUser.ReportPath = "C:\Users\DELL\Desktop\GemmaKnits\"
        If Not clsConfig.CheckReport(clsUser.ReportPath, rptFileName) Then Exit Sub
        Dim frm As New frmReport
        Dim rpt As New CrystalDecisions.CrystalReports.Engine.ReportDocument
        Dim stype As String = ""
        Dim ord As String = ""
        Me.Cursor = Cursors.WaitCursor

        rpt.Load(clsUser.ReportPath & rptFileName)
        rpt.DataSourceConnections.Item(0).SetConnection(clsConn.servername, clsConn.database, False)
        rpt.DataSourceConnections.Item(0).SetLogon(clsConn.Userid, clsConn.Password)
        rpt.VerifyDatabase()
        rpt.SetParameterValue("@roll_no", txtGINNo.Text)
        rpt.SetParameterValue("@loc", "")
        rpt.SetParameterValue("@logempcd", UserInfo.UserID)

        'rpt.PrintOptions.PaperSize = CrystalDecisions.Shared.PaperSize.PaperLetter
        'rpt.PrintOptions.PaperOrientation = CrystalDecisions.Shared.PaperOrientation.Portrait
        'rpt.PrintOptions.PaperSource = CrystalDecisions.Shared.PaperSource.Auto

        frm.Title = "Greige Barcode"
        frm.CRViewer.ReportSource = rpt
        frm.MdiParent = Me.ParentForm
        frm.Show()
        Me.Cursor = Cursors.Default
    End Sub
End Class