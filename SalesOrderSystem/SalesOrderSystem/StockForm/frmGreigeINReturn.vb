Public Class frmGreigeINReturn
    Dim config As New clsConfig
    Dim clsUser As New classUserInfo
    Dim dbStockG As New classStockG
    Dim clsConn As New classConnection
    Public Property UserInfo() As classUserInfo
        Get
            UserInfo = clsUser
        End Get
        Set(ByVal NewValue As classUserInfo)
            clsUser = NewValue
        End Set
    End Property
    Private Enum SelectedRollNo
        NoSelection = 0
        PartialSelection = 1
        SelectAll = 2
    End Enum
    Private Sub InitControl()

        Call GenCombo()
        txtOutNo.Text = ""
        txtSourceRefNo.Text = ""
        'txtLocation.Text = ""
        txtGinno.Text = ""
        grdData.DataSource = Nothing
        grdData.ReadOnly = False

        btnSave.Enabled = True
        'btncopy2.Enabled = True
        txtOutNo.ReadOnly = False
        txtSourceRefNo.ReadOnly = False
        'txtLocation.ReadOnly = False


        txtUnselectedRolls.Text = "0"
        txtUnselectedKgs.Text = "0"
        txtUnselectedMts.Text = "0"
        txtUnselectedYds.Text = "0"

        txtSelectedRolls.Text = "0"
        txtSelectedKgs.Text = "0"
        txtSelectedMts.Text = "0"
        txtSelectedYds.Text = "0"

        txtOutNo.Focus()
    End Sub

    Private Sub DisableControl()
        'btnSave.Enabled = False
        'btncopy2.Enabled = True
        'grdData.ReadOnly = True
        txtOutNo.ReadOnly = True
        txtSourceRefNo.ReadOnly = True
        'txtLocation.ReadOnly = True
        grdData.Focus()
    End Sub

    Private Sub BindData(ByVal dt As DataTable)
        txtOutNo.Text = dt.Rows(0)("outno").ToString()
        txtGinno.Text = dt.Rows(0)("tran_no").ToString()
        dtpGINDate.Value = CDate(dt.Rows(0)("tran_dt").ToString)
        txtSourceRefNo.Text = dt.Rows(0)("source_refno").ToString()
        'txtLocation.Text = dt.Rows(0)("loc").ToString()
        cbomtl_warehouse.SelectedValue = dt.Rows(0)("mtl_warehouse_id")
        GetComboNewSubInventory(Int64mtl_warehouse_id:=cbomtl_warehouse.SelectedValue)
        cbomtl_subinventory.SelectedValue = dt.Rows(0)("mtl_subinventory_id")
        GetComboNewLocation(Int64mtl_warehouse_id:=cbomtl_warehouse.SelectedValue, Int64mtl_subinventory_id:=cbomtl_subinventory.SelectedValue)
        cbomtl_locations.SelectedValue = dt.Rows(0)("mtl_locations_id")
        grdData.AutoGenerateColumns = False
        grdData.DataSource = dt
    End Sub

    Private Sub GenCombo()
        Dim dt As DataTable = dbStockG.GetComboGINReturn(clsUser.UserID)
        cboDocNo.ComboBox.DataSource = dt
        cboDocNo.ComboBox.DisplayMember = "tran_no"
        cboDocNo.ComboBox.ValueMember = "tran_no"
        cboDocNo.ComboBox.SelectedIndex = -1

        GetComboNewWarehouse()
        'GetComboNewSubInventory(Int64mtl_warehouse_id:=(New clsConfig).IsNull(cboNewmtl_warehouse.SelectedValue, 0))
        ' GetComboNewLocation(Int64mtl_warehouse_id:=cboNewmtl_warehouse.SelectedValue, Int64mtl_subinventory_id:=cboNewmtl_subinventory.SelectedValue)

    End Sub


    Private Sub GetComboNewWarehouse()
        Dim objdb As New classMaster

        cbomtl_warehouse.DataSource = objdb.Combomtlwarehouse(clsUser.UserID)
        cbomtl_warehouse.DisplayMember = "warehouse_code"
        cbomtl_warehouse.ValueMember = "mtl_warehouse_id"
        cbomtl_warehouse.SelectedIndex = -1
        'cboNewmtl_warehouse.SelectedValue = objdb.GetdefaultWarehouse(clsUser.UserID)
        'SetdefaultWarehouse()

    End Sub

    Private Sub GetComboNewSubInventory(Optional ByVal Int64mtl_warehouse_id As Nullable(Of Int64) = Nothing)
        Dim objdb As New classMaster

        cbomtl_subinventory.DataSource = objdb.ComboMtlsubinventory(Int64mtl_warehouse_id)
        cbomtl_subinventory.DisplayMember = "subinventory_code"
        cbomtl_subinventory.ValueMember = "mtl_subinventory_id"
        cbomtl_subinventory.SelectedIndex = -1
        'cboNewmtl_subinventory.SelectedValue = objdb.GetdefaultSubinventory(Int64mtl_warehouse_id:=cboNewmtl_warehouse.SelectedValue, _
        '                                                                   Strsubinventory_code:="GREIGE", strUSerID:=clsUser.UserID)
        'Try
        '    cboNewmtl_subinventory.SelectedValue = Setdefaultsubinventory(dt:=cboNewmtl_subinventory.DataSource)
        'Catch ex As Exception

        'End Try
        ' cboNewmtl_subinventory.SelectedValue = Setdefaultsubinventory(dt:=cboNewmtl_subinventory.DataSource)
        'Setdefaultsubinventory(dt:=cboNewmtl_subinventory.DataSource)

    End Sub

    Private Sub GetComboNewLocation(Optional ByVal Int64mtl_warehouse_id As Nullable(Of Int64) = Nothing, Optional ByVal Int64mtl_subinventory_id As Nullable(Of Int64) = Nothing)
        Dim objdb As New classMaster
        cbomtl_locations.DataSource = objdb.Combomtllocations(strUSerID:=clsUser.UserID, INt64mtl_warehouse_id:=Int64mtl_warehouse_id, Int64mtl_subinventory_id:=Int64mtl_subinventory_id)
        cbomtl_locations.DisplayMember = "location_name"
        cbomtl_locations.ValueMember = "mtl_locations_id"
        'cboNewmtl_locations.SelectedIndex = -1
        'If cboNewmtl_locations.SelectedValue = Int64mtl_locations_id Then
        '    cboNewmtl_locations.SelectedValue = Int64mtl_locations_id
        'Else
        '    'SetDefaultLocation(cboNewmtl_locations.DataSource)
        'End If

    End Sub

    Private Function Setdefaultsubinventory(ByVal dt As DataTable) As Nullable(Of Int64)

        Dim expression As String
        expression = "subinventory_code like '%GREIGE%'"
        Dim foundRows() As DataRow
        foundRows = dt.Select(expression)
        If Not foundRows.Length <= 0 Then
            Return foundRows(0)(0)
        End If
        'If foundRows.GetUpperBound(0) > 0 Then
        'cboNewmtl_subinventory.SelectedValue = foundRows(0)(0)
        'Return foundRows(0)(0)
        'Else
        'Return Nothing
        'End If


        'cboNewmtl_subinventory.SelectedValue = foundRows(0)(0)

    End Function

    Private Function GetGOutByNo(ByVal strOutNo As String) As Boolean
        Dim dt As DataTable = dbStockG.GetGOutByOutNo(strOutNo, clsUser.UserID)
        If dt.Rows.Count > 0 Then
            Call BindData(dt)
            Return True
        End If
        Return False
    End Function

    Private Function GetGINByNo(ByVal strTranNo As String) As Boolean
        Dim dt As DataTable = dbStockG.GetGINByNo(strTranNo, clsUser.UserID)
        If dt.Rows.Count > 0 Then
            Call BindData(dt)
            Return True
        End If
        Return False
    End Function

    Private Sub CalculateTotal()
        Dim dt As DataTable = grdData.DataSource

        Dim unselectedRolls As Integer = 0
        Dim unselectedKgs As Single = 0
        Dim unselectedMts As Single = 0
        Dim unselectedYds As Single = 0

        Dim selectedRolls As Single = 0
        Dim selectedKgs As Single = 0
        Dim selectedMts As Single = 0
        Dim selectedYds As Single = 0

        If Not dt Is Nothing Then
            For Each dr As DataRow In dt.Rows
                If dr("selected") = 0 Then
                    unselectedRolls += 1
                    unselectedKgs += dr("outkg_g")
                    unselectedMts += dr("outmt_g")
                    unselectedYds += dr("outyd_g")
                Else
                    selectedRolls += 1
                    selectedKgs += dr("outkg_g")
                    selectedMts += dr("outmt_g")
                    selectedYds += dr("outyd_g")
                End If
            Next
        End If

        txtUnselectedRolls.Text = unselectedRolls.ToString
        txtUnselectedKgs.Text = unselectedKgs.ToString
        txtUnselectedMts.Text = unselectedMts.ToString
        txtUnselectedYds.Text = unselectedYds.ToString

        txtSelectedRolls.Text = selectedRolls.ToString
        txtSelectedKgs.Text = selectedKgs.ToString
        txtSelectedMts.Text = selectedMts.ToString
        txtSelectedYds.Text = selectedYds.ToString
    End Sub

    Private Sub frmGreigeINReturn_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        Call InitControl()
    End Sub

    Private Sub btnNew_Click(sender As System.Object, e As System.EventArgs) Handles btnNew.Click
        Call InitControl()
    End Sub

    Private Sub btnSave_Click(sender As System.Object, e As System.EventArgs) Handles btnSave.Click
        'grdData.CurrentCell = grdData.Rows(0).Cells("roll_no_g") 'Fix Bug User
        grdData.EndEdit()
        grdData.Refresh()
        'Sitthana 20220624 Changed Windows.Forms.DialogResult To DialogResult
        Dim result As DialogResult ' Windows.Forms.DialogResult
        result = MessageBox.Show("Would you like to Save ?", "System Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button3)
        If result <> DialogResult.Yes Then Exit Sub
        'If MessageBox.Show("Would you like to save ?", "System Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then

        If Not CheckData() Then Exit Sub

        Call SaveData()

    End Sub

    Private Function CheckData() As Boolean

        If (New clsConfig).IsNull(cbomtl_warehouse.SelectedValue, 0) = 0 Then
            MessageBox.Show("คุณยังไม่ไดเลือก WareHouse")
            ErrorProvider1.SetError(cbomtl_warehouse, "คุณยังไม่ไดเลือก WareHouse")
            CheckData = False
            Exit Function
        Else
            ErrorProvider1.Clear()
        End If

        If (New clsConfig).IsNull(cbomtl_subinventory.SelectedValue, 0) = 0 Then
            MessageBox.Show("คุณยังไม่ได้เลือก Subinventory")
            ErrorProvider1.SetError(cbomtl_subinventory, "คุณยังไม่ได้เลือก Subinventory")
            CheckData = False
            Exit Function
        Else
            ErrorProvider1.Clear()
        End If

        If (New clsConfig).IsNull(cbomtl_locations.SelectedValue, 0) = 0 Then
            MessageBox.Show("คุณยังไม่ไดเลือก Location")
            ErrorProvider1.SetError(cbomtl_locations, "คุณยังไม่ได้เลือก Locations")
            CheckData = False
            Exit Function
        Else
            ErrorProvider1.Clear()
        End If

        Dim findResult As SelectedRollNo = FindMissingRollNo()
        If findResult = SelectedRollNo.NoSelection Then
            MessageBox.Show("คุณยังไม่ได้เลือกผ้า !!", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return False
            Exit Function
        End If

        CheckData = True
    End Function

    Private Function FindMissingRollNo() As SelectedRollNo
        Dim dt As DataTable = grdData.DataSource
        Dim strRollNo As String = ""
        Dim found As Integer = 0

        For Each dr As DataRow In dt.Rows
            If dr("selected") = 0 Then
                strRollNo = dr("roll_no_g").ToString()
            Else
                found += 1
            End If
        Next

        If found = 0 Then Return SelectedRollNo.NoSelection
        If strRollNo.Length > 0 Then Return SelectedRollNo.PartialSelection
        Return SelectedRollNo.SelectAll
    End Function

    Private Function SaveData() As Boolean
        Dim msger As String = ""
        Dim dt As DataTable = grdData.DataSource
        Dim Greige_Header As New classStockG.Greige_Header
        Greige_Header.h04_tran_no = txtGinno.Text.Trim
        Greige_Header.h03_source_refno = txtSourceRefNo.Text
        Greige_Header.h29_outno = txtOutNo.Text.Trim
        Greige_Header.h25_loc = cbomtl_locations.Text.Trim
        Greige_Header.h83_mtl_warehouse_id = cbomtl_warehouse.SelectedValue
        Greige_Header.h86_mtl_subinventory_id = cbomtl_subinventory.SelectedValue
        Greige_Header.h84_mtl_locations_id = cbomtl_locations.SelectedValue

        '  Try
        If dbStockG.SaveGINReturn(dt:=dt, Greige_Header:=Greige_Header,
                                         logempcd:=clsUser.UserID, msger:=msger) Then
            Call GenCombo()
            Call InitControl()

            If Greige_Header.h04_tran_no.Length > 0 Then
                Call GetGINByNo(Greige_Header.h04_tran_no)
                Call DisableControl()
                Call CalculateTotal()
            End If

            MessageBox.Show("Save Completed.", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            MessageBox.Show(msger, "System Message", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End If
    End Function

    Private Sub btnPrint_Click(sender As System.Object, e As System.EventArgs)
        If txtOutNo.Text.Trim.Length = 0 Then Exit Sub
        Const rptFileName = "rptGIN.rpt"
        Dim clsConfig As New clsConfig
        Dim clsConn As New classConnection
        If clsUser.ReportPath = "" Then clsUser.ReportPath = clsUser.ReportPath
        If Not clsConfig.CheckReport(clsUser.ReportPath, rptFileName) Then Exit Sub
        Dim frm As New frmReport
        Dim rpt As New CrystalDecisions.CrystalReports.Engine.ReportDocument
        Dim logonInfo As New CrystalDecisions.Shared.TableLogOnInfo
        Me.Cursor = Cursors.WaitCursor
        logonInfo.ConnectionInfo.ServerName = clsConn.servername
        logonInfo.ConnectionInfo.DatabaseName = clsConn.database
        logonInfo.ConnectionInfo.IntegratedSecurity = False
        logonInfo.ConnectionInfo.UserID = clsConn.Userid
        logonInfo.ConnectionInfo.Password = clsConn.Password

        rpt.Load(clsUser.ReportPath & rptFileName)
        rpt.DataSourceConnections.Item(0).SetConnection(clsConn.servername, clsConn.database, False)
        rpt.DataSourceConnections.Item(0).SetLogon(clsConn.Userid, clsConn.Password)
        rpt.VerifyDatabase()
        rpt.SetParameterValue("@trannofr", txtGinno.Text.Trim)
        rpt.SetParameterValue("@trannoto", txtGinno.Text.Trim)

        'rpt.PrintOptions.PaperSize = CrystalDecisions.Shared.PaperSize.PaperA4
        'rpt.PrintOptions.PaperOrientation = CrystalDecisions.Shared.PaperOrientation.Portrait
        'rpt.PrintOptions.PaperSource = CrystalDecisions.Shared.PaperSource.Auto

        frm.Title = "Greige IN Return"
        frm.CRViewer.ReportSource = rpt
        frm.MdiParent = Me.ParentForm
        frm.Show()
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub btnCancel_Click(sender As System.Object, e As System.EventArgs) Handles btnCancel.Click
        'Sitthana 20220624 Changed Windows.Forms.DialogResult To DialogResult
        Dim result As DialogResult ' Windows.Forms.DialogResult
        result = MessageBox.Show("Would you like to cancel document no. " & txtGinno.Text & " ?", "System Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button3)
        If result <> DialogResult.Yes Then Exit Sub

        If Not CheckDataCancel() Then Exit Sub

        Dim message As String = ""

        If (New classStock).CancelGIN(strGINNo:=txtGinno.Text, Dtptran_dt:=dtpGINDate.Value, strEmpCode:=clsUser.UserID, Strmessage:=message) Then
            MessageBox.Show("cancel is completed", "System Message!", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Call btnNew_Click(sender, e)
        Else
            MessageBox.Show(message, "System Message!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
        'If txtTranNo.Text.Trim.Length = 0 Then Exit Sub

        'If MessageBox.Show("Would you like to cancel G-IN No." + txtTranNo.Text.Trim + " ?", "System Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
        '    If dbStockG.CancelGIN(txtTranNo.Text.Trim, clsUser.UserID) Then
        '        MessageBox.Show(txtTranNo.Text.Trim + " is already cancelled.", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
        '        Call GenCombo()
        '        Call InitControl()
        '    End If
        'End If
    End Sub

    Private Function CheckDataCancel() As Boolean
        If txtGinno.Text.Trim.Length = 0 Then
            MessageBox.Show("คุณยังไม่ได้เลือก D IN No.", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return False
            Exit Function
        End If

        Return True
    End Function

    Private Sub btnExit_Click(sender As System.Object, e As System.EventArgs) Handles btnExit.Click
        If MessageBox.Show("Would you like to exit ?", "System Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then Me.Close()
    End Sub

    Private Sub cboDocNo_DropDownClosed(sender As System.Object, e As System.EventArgs) Handles cboDocNo.DropDownClosed
        Dim strTranNo As String = Trim(New clsConfig().IsNull(cboDocNo.ComboBox.SelectedValue, ""))

        If strTranNo.Length > 0 Then
            Call GetGINByNo(strTranNo)
            Call DisableControl()
            Call CalculateTotal()
        End If
    End Sub

    Private Sub txtOutNo_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles txtOutNo.KeyDown
        If e.KeyCode.Equals(Keys.Enter) Then
            If txtOutNo.Text = "NEW" Then
                Call btnNew_Click(sender, e)
                Exit Sub
            End If

            If txtOutNo.Text.Trim.Length > 0 Then
                Call GetGOutByNo(txtOutNo.Text)
                Call CalculateTotal()
            End If
            txtOutNo.Focus()
            'txtSourceRefNo.Focus()
        End If
    End Sub

    Private Sub txtSourceRefNo_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles txtSourceRefNo.KeyDown
        If e.KeyCode = Keys.Enter Then

            ' txtLocation.Focus()
        End If
    End Sub

    Private Sub grdData_CellValueChanged(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles grdData.CellValueChanged
        Call CalculateTotal()
    End Sub

    Private Sub txtOutNo_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtOutNo.TextChanged

    End Sub

    Private Sub grdData_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles grdData.CellContentClick

    End Sub

    Private Sub grdData_CurrentCellDirtyStateChanged(sender As Object, e As EventArgs) Handles grdData.CurrentCellDirtyStateChanged
        If grdData.IsCurrentCellDirty Then
            grdData.CommitEdit(DataGridViewDataErrorContexts.Commit)
        End If
    End Sub

    Private Sub btncopy_Click(sender As Object, e As EventArgs)
        ' GetcopyRollNo()
    End Sub

    Private Function GetcopyRollNo() As Boolean
        Dim dtc As DataTable = grdData.DataSource
        Dim newrow As DataRow
        If grdData.Rows.Count > 0 Then

            newrow = dtc.NewRow

            newrow.Item("id_greige_do") = grdData.CurrentRow.Cells("id_greige_do").Value
            newrow.Item("roll_no_g") = grdData.CurrentRow.Cells("roll_no_g").Value
            newrow.Item("roll_no_o") = grdData.CurrentRow.Cells("roll_no_o").Value
            newrow.Item("loc") = grdData.CurrentRow.Cells("loc").Value
            newrow.Item("design_no") = grdData.CurrentRow.Cells("design_no").Value
            newrow.Item("grade") = grdData.CurrentRow.Cells("grade").Value
            newrow.Item("outkg_g") = grdData.CurrentRow.Cells("outkg_g").Value
            newrow.Item("outmt_g") = grdData.CurrentRow.Cells("outmt_g").Value
            newrow.Item("outyd_g") = grdData.CurrentRow.Cells("outyd_g").Value

            newrow.Item("selected") = grdData.CurrentRow.Cells("selected").Value

            dtc.Rows.Add(newrow)

            Return True


        End If

        Return False

    End Function

    Private Sub cboDocNo_Click(sender As Object, e As EventArgs) Handles cboDocNo.Click

    End Sub

    Private Sub cboNewmtl_warehouse_DropDownClosed(sender As Object, e As EventArgs) Handles cbomtl_warehouse.DropDownClosed
        GetComboNewSubInventory(Int64mtl_warehouse_id:=cbomtl_warehouse.SelectedValue)
        GetComboNewLocation(Int64mtl_warehouse_id:=cbomtl_warehouse.SelectedValue _
                           , Int64mtl_subinventory_id:=cbomtl_subinventory.SelectedValue)
    End Sub

    Private Sub cboNewmtl_warehouse_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbomtl_warehouse.SelectedIndexChanged

    End Sub

    Private Sub cboNewmtl_subinventory_DropDownClosed(sender As Object, e As EventArgs) Handles cbomtl_subinventory.DropDownClosed
        GetComboNewLocation(cbomtl_warehouse.SelectedValue, cbomtl_subinventory.SelectedValue)
    End Sub

    Private Sub cboNewmtl_subinventory_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbomtl_subinventory.SelectedIndexChanged

    End Sub

    Private Sub BtnCopy_Click_1(sender As Object, e As EventArgs) Handles BtnCopy.Click
        Call GetcopyRollNo()
    End Sub

    Private Sub cboNewmtl_warehouse_SelectedValueChanged(sender As Object, e As EventArgs) Handles cbomtl_warehouse.SelectedValueChanged

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
        rpt.SetParameterValue("@roll_no", txtGinno.Text)
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
    Private Sub tsbGInDocument_Click(sender As Object, e As EventArgs) Handles tsbGInDocument.Click
        'print
        If txtGinno.Text = "" Then Exit Sub
        Const rptFileName = "rptGIN.rpt"
        If clsUser.ReportPath = "" Then clsUser.ReportPath = clsUser.ReportPath
        If Not (New clsConfig).CheckReport(clsUser.ReportPath, rptFileName) Then Exit Sub
        Dim frm As New frmReport
        Dim rpt As New CrystalDecisions.CrystalReports.Engine.ReportDocument
        Me.Cursor = Cursors.WaitCursor

        rpt.Load(clsUser.ReportPath & rptFileName)
        rpt.DataSourceConnections.Item(0).SetConnection(clsConn.servername, clsConn.database, False)
        rpt.DataSourceConnections.Item(0).SetLogon(clsConn.Userid, clsConn.Password)

        rpt.VerifyDatabase()
        rpt.SetParameterValue("@trannofr", txtGinno.Text)
        rpt.SetParameterValue("@trannoto", txtGinno.Text)

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
        rpt.SetParameterValue("@roll_no", txtGinno.Text)
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