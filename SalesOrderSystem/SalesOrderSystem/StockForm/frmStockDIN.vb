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
        Call GenCombo()
        Call GenComboDINNo()
        txtDINNo.Text = ""
        dtpDINDate.Value = Today
        txtDFNo.Text = ""
        txtLotNo.Text = ""
        txtBillNo.Text = ""
        txtRemark.Text = ""

        Call BindGrid(grdData, (New classStock).GetDIN("", clsUser.UserID, ""))
        txtBillNo.Select()
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
        cboDyedHouse.SelectedValue = dt.Rows(0)("dhcod")
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
        Dim dt As DataTable = grdData.DataSource

        Dim Din_header As New classStock.Strolls_DHeader

        If clsConfig.IsNull(cboNewmtl_warehouse.SelectedValue, 0) = 0 Then
            MessageBox.Show("ต้องเลือก WareHouse")
            Exit Sub
        End If

        If clsConfig.IsNull(cboNewmtl_subinventory.SelectedValue, 0) = 0 Then
            MessageBox.Show("ต้องเลือก Sub Inventory")
            Exit Sub
        End If

        Din_header.h56_mtl_warehouse_id = (New clsConfig).IsNull(cboNewmtl_warehouse.SelectedValue, Nothing)
        Din_header.h58_mtl_subinventory_id = (New clsConfig).IsNull(cboNewmtl_subinventory.SelectedValue, Nothing)
        Din_header.h57_mtl_locations_id = (New clsConfig).IsNull(cboNewmtl_locations.SelectedValue, Nothing)


        Dim StrMessage As String = ""
        dt = objDB.SaveDIN(dt, bill_no, clsUser.UserID, StrLoc:=cboNewmtl_locations.Text,
                           Strolls_DHeader:=Din_header, StrMessage:=StrMessage)

        If StrMessage.Trim.Length > 0 Then MessageBox.Show(StrMessage, "System Message", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)

        Call GenComboDINNo()
        Call LoadData(txtBillNo.Text.Trim)

        cboDocNo.Text = txtDINNo.Text 'Add By Neung 20151202
    End Sub
    'Private Sub SaveData(ByVal bill_no As String)
    '    Dim objDB As New classStock
    '    Dim dt As New DataTable
    '    dt = objDB.SaveDIN(bill_no, clsUser.UserID)
    '    Call InitControl()
    '    If dt.Rows.Count > 0 Then Call BindData(dt)
    '    Call BindGrid(grdData, dt)
    'End Sub

    Private Sub frmStockDIN_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized

        'Call GenCombo()

        Call InitControl()
        'Call btnNew_Click(sender, e)
    End Sub

    Private Sub btnNew_Click(sender As System.Object, e As System.EventArgs) Handles btnNew.Click

        Me.WindowState = FormWindowState.Maximized

        'Call GenCombo()

        Call InitControl()

    End Sub

    Private Sub GenCombo()
        cboNewmtl_warehouse.DataSource = (New classMaster).Combomtlwarehouse(clsUser.UserID)
        cboNewmtl_warehouse.DisplayMember = "warehouse_code"
        cboNewmtl_warehouse.ValueMember = "mtl_warehouse_id"
        cboNewmtl_warehouse.SelectedValue = (New classMaster).GetdefaultWarehouse(strUSerID:=clsUser.UserID)

        cboNewmtl_subinventory.DataSource = (New classMaster).ComboMtlsubinventory(cboNewmtl_warehouse.SelectedValue)
        cboNewmtl_subinventory.DisplayMember = "subinventory_code"
        cboNewmtl_subinventory.ValueMember = "mtl_subinventory_id"
        cboNewmtl_subinventory.SelectedValue = (New classMaster).GetdefaultSubinventory(Int64mtl_warehouse_id:=(New clsConfig).IsNull(cboNewmtl_warehouse.SelectedValue, Nothing),
                                                                            Strsubinventory_code:="DYED",
                                                                            strUSerID:=clsUser.UserID)

        cboNewmtl_locations.DataSource = (New classMaster).Combomtllocations(strUSerID:=clsUser.UserID,
                           INt64mtl_warehouse_id:=(New clsConfig).IsNull(cboNewmtl_warehouse.SelectedValue, Nothing),
                           Int64mtl_subinventory_id:=(New clsConfig).IsNull(cboNewmtl_subinventory.SelectedValue, Nothing))
        cboNewmtl_locations.DisplayMember = "location_name"
        cboNewmtl_locations.ValueMember = "mtl_locations_id"
        'cboNewmtl_locations.SelectedValue = (New classMaster).GetdefaultLocations
        'If Not cboNewmtl_locations.DataSource Is Nothing Then SetDefaultLocation(cboNewmtl_locations.DataSource)

        Me.cboDyedHouse.DataSource = (New classMaster).GetDyedHouse
        Me.cboDyedHouse.DisplayMember = "name"
        Me.cboDyedHouse.ValueMember = "suppcd2"
        Me.cboDyedHouse.SelectedIndex = -1

    End Sub

    Private Sub btnSave_Click(sender As System.Object, e As System.EventArgs) Handles btnSave.Click
        Me.Validate()

        If txtBillNo.Text.Trim.Length = 0 Then Exit Sub

        'Sitthana 20220624 Changed Windows.Forms.DialogResult To DialogResult
        Dim result As DialogResult ' Windows.Forms.DialogResult
        result = MessageBox.Show("Would you like to save ?", "System Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button3)
        If result <> DialogResult.Yes Then Exit Sub

        Call SaveData(txtBillNo.Text.Trim)
        'If txtBillNo.Text.Trim.Length = 0 Then Exit Sub
        ' If MessageBox.Show("Would you like to save ?", "System Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then Call SaveData(txtBillNo.Text.Trim)
    End Sub

    Private Sub btnPrint_Click(sender As System.Object, e As System.EventArgs)
        'print
        If txtBillNo.Text = "" Then Exit Sub
        Const rptFileName = "rptDIN.rpt"
        'Const rptFileName = "rptStockDIN.rpt"
        If clsUser.ReportPath = "" Then clsUser.ReportPath = clsUser.ReportPath
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
        'Sitthana 20220624 Changed Windows.Forms.DialogResult To DialogResult
        Dim result As DialogResult ' Windows.Forms.DialogResult
        result = MessageBox.Show("Would you like to cancel document no. " & txtDINNo.Text & " ?", "System Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button3)
        If result <> DialogResult.Yes Then Exit Sub

        If Not CheckDataCancel() Then Exit Sub

        Dim message As String = ""
        If (New classStock).CancelDIN(txtDINNo.Text, clsUser.UserID, message) Then
            MessageBox.Show("ยกเลิกสำเร็จ", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
            btnNew_Click(sender, e)
        Else
            MessageBox.Show(message, "System Message", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
        End If
    End Sub
    Private Function CheckDataCancel() As Boolean
        If txtDINNo.Text.Trim.Length = 0 Then
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

    Private Sub cboNewmtl_subinventory_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboNewmtl_subinventory.SelectedIndexChanged

    End Sub

    Private Sub cboNewmtl_warehouse_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboNewmtl_warehouse.SelectedIndexChanged

    End Sub

    Private Sub cboNewmtl_warehouse_SelectedValueChanged(sender As Object, e As EventArgs) Handles cboNewmtl_warehouse.SelectedValueChanged
        cboNewmtl_subinventory.DataSource = (New classMaster).ComboMtlsubinventory((New clsConfig).IsNull(cboNewmtl_warehouse.SelectedValue, Nothing))
        cboNewmtl_subinventory.DisplayMember = "subinventory_code"
        cboNewmtl_subinventory.ValueMember = "mtl_subinventory_id"
        cboNewmtl_subinventory.SelectedValue = (New classMaster).GetdefaultSubinventory(Int64mtl_warehouse_id:=(New clsConfig).IsNull(cboNewmtl_warehouse.SelectedValue, Nothing),
                                                                            Strsubinventory_code:="DYED",
                                                                            strUSerID:=clsUser.UserID)

        cboNewmtl_locations.DataSource = (New classMaster).Combomtllocations(strUSerID:=clsUser.UserID,
                          INt64mtl_warehouse_id:=(New clsConfig).IsNull(cboNewmtl_warehouse.SelectedValue, Nothing),
                          Int64mtl_subinventory_id:=(New clsConfig).IsNull(cboNewmtl_subinventory.SelectedValue, Nothing))
        cboNewmtl_locations.DisplayMember = "location_name"
        cboNewmtl_locations.ValueMember = "mtl_locations_id"
    End Sub

    Private Sub cboNewmtl_subinventory_SelectedValueChanged(sender As Object, e As EventArgs) Handles cboNewmtl_subinventory.SelectedValueChanged
        cboNewmtl_locations.DataSource = (New classMaster).Combomtllocations(strUSerID:=clsUser.UserID,
                          INt64mtl_warehouse_id:=(New clsConfig).IsNull(cboNewmtl_warehouse.SelectedValue, Nothing),
                          Int64mtl_subinventory_id:=(New clsConfig).IsNull(cboNewmtl_subinventory.SelectedValue, Nothing))
        cboNewmtl_locations.DisplayMember = "location_name"
        cboNewmtl_locations.ValueMember = "mtl_locations_id"
    End Sub

    Private Sub txtLotNo_KeyDown(sender As Object, e As KeyEventArgs) Handles txtLotNo.KeyDown
        If txtLotNo.Text.Trim.Length = 0 Then Exit Sub
        If e.KeyCode = Keys.Enter Then
            txtLotNo.Enabled = False
            Call LoadData(txtLotNo.Text.Trim)
            txtLotNo.Enabled = True
        End If
    End Sub

    Private Sub tsbDInTag_Click(sender As Object, e As EventArgs) Handles tsbDInTag.Click
        Dim clsConfig As New clsConfig
        Dim rptFileName = "rptStockDBarcode.rpt"
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
        'With grdData
        ' If .Rows.Count > 0 Then
        rpt.SetParameterValue("@roll_no", txtDINNo.Text.Trim) '.Rows(.CurrentRow.Index).Cells("roll_no_d").Value)
        rpt.SetParameterValue("@loc", "") '.Rows(.CurrentRow.Index).Cells("loc").Value)
        rpt.SetParameterValue("@logempcd", UserInfo.UserID)
        '   Else
        '    MessageBox.Show("ไม่มีข้อมูลใน grid", "Mistake (ข้อผิดพลาด)", MessageBoxButtons.OK, MessageBoxIcon.Information)
        'Exit Sub
        'End If
        'End With

        'rpt.PrintOptions.PaperSize = CrystalDecisions.Shared.PaperSize.PaperLetter
        'rpt.PrintOptions.PaperOrientation = CrystalDecisions.Shared.PaperOrientation.Portrait
        'rpt.PrintOptions.PaperSource = CrystalDecisions.Shared.PaperSource.Auto

        frm.Title = "DIN Barcode"
        frm.CRViewer.ReportSource = rpt
        frm.MdiParent = Me.ParentForm
        frm.Show()
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub tsbDInDocument_Click(sender As Object, e As EventArgs) Handles tsbDInDocument.Click
        Dim clsConfig As New clsConfig
        Dim rptFileName = "rptDIN.rpt"
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
        rpt.SetParameterValue("@dinnofr", txtDINNo.Text.Trim)
        rpt.SetParameterValue("@dinnoto", txtDINNo.Text.Trim)
        'rpt.PrintOptions.PaperSize = CrystalDecisions.Shared.PaperSize.PaperA4
        'rpt.PrintOptions.PaperOrientation = CrystalDecisions.Shared.PaperOrientation.Portrait
        'rpt.PrintOptions.PaperSource = CrystalDecisions.Shared.PaperSource.Auto

        frm.Title = "DIN Document"
        frm.CRViewer.ReportSource = rpt
        frm.MdiParent = Me.ParentForm
        frm.Show()
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub tsbHInDocument_Click(sender As Object, e As EventArgs) Handles tsbMInDocument.Click
        Dim clsConfig As New clsConfig
        Dim rptFileName = "rptMin.rpt"
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
        rpt.SetParameterValue("@dinno", txtDINNo.Text)

        'rpt.PrintOptions.PaperSize = CrystalDecisions.Shared.PaperSize.PaperA4
        'rpt.PrintOptions.PaperOrientation = CrystalDecisions.Shared.PaperOrientation.Portrait
        'rpt.PrintOptions.PaperSource = CrystalDecisions.Shared.PaperSource.Auto

        frm.Title = "MIN Document"
        frm.CRViewer.ReportSource = rpt
        frm.MdiParent = Me.ParentForm
        frm.Show()
        Me.Cursor = Cursors.Default
    End Sub

End Class