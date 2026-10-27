Public Class frmYarnTransfer
    Dim clsConfig As New clsConfig
    Dim clsConn As New classConnection
    Dim clsUser As New classUserInfo
    Dim blnCancel As Boolean = False

    Dim strLogNo As String = ""

    Dim _AllowEdit As Boolean = True
    Dim _AllowPrint As Boolean = True
    Dim _AllowNew As Boolean = True
    Dim LastBarcode As String = ""

    Public Property UserInfo() As classUserInfo
        Get
            UserInfo = clsUser
        End Get
        Set(ByVal NewValue As classUserInfo)
            clsUser = NewValue
        End Set
    End Property

    Public Property AllowEdit()
        Get
            Return _AllowEdit
        End Get
        Set(ByVal value)
            _AllowEdit = value
        End Set
    End Property

    Public Property AllowPrint()
        Get
            Return _AllowPrint
        End Get
        Set(ByVal value)
            _AllowPrint = value
        End Set
    End Property

    Public Property AllowNew()
        Get
            Return _AllowNew
        End Get
        Set(ByVal value)
            _AllowNew = value
        End Set
    End Property

    Private Property DocNo() As String
        Get
            DocNo = strLogNo
        End Get
        Set(ByVal NewValue As String)
            strLogNo = NewValue
        End Set
    End Property

    Private Sub SetControlValue(ByVal Obj As Control)
        If TypeOf Obj Is TextBox Then
            Obj.Text = Obj.Tag
        End If
        If TypeOf Obj Is DateTimePicker Then
            Dim dtp As DateTimePicker = Obj
            dtp.Value = Now
        End If
        If TypeOf Obj Is ComboBox Then
            Dim cbo As ComboBox = Obj
            cbo.SelectedIndex = -1
        End If
        If TypeOf Obj Is CheckBox Then
            Dim chk As CheckBox = Obj
            chk.Checked = False
        End If
        If TypeOf Obj Is TabControl Or TypeOf Obj Is TabPage Or TypeOf Obj Is GroupBox Then
            Dim obj2 As Control
            For Each obj2 In Obj.Controls
                Call SetControlValue(obj2)
            Next
        End If
    End Sub

    Private Sub InitControl()

        Call GenCombo()
        Call GenComboDocNo()

        Dim obj As Control
        For Each obj In Me.Controls
            Call SetControlValue(obj)
        Next
        Call EnabledControl(True)

        rbtTransferLocations.Checked = True
        txtGradeTo.Enabled = False
        txtGradeOurTo.Enabled = False

        Call LoadDataLog("")

        grdYarnIN.AutoGenerateColumns = False
        grdYarnIN.DataSource = (New classStockTransferY).GetYarnInDet("")

        btnSave.Enabled = AllowEdit
        txtBarcode.Focus()

    End Sub

    Private Sub SetControlEnabled(ByVal Obj As Control, ByVal blnEnabled As Boolean)
        If TypeOf Obj Is TextBox Then Obj.Enabled = blnEnabled
        If TypeOf Obj Is DateTimePicker Then Obj.Enabled = blnEnabled
        If TypeOf Obj Is ComboBox Then Obj.Enabled = blnEnabled
        If TypeOf Obj Is CheckBox Then Obj.Enabled = blnEnabled
        If TypeOf Obj Is DataGridView Then
            Dim grd As DataGridView = Obj
            grd.ReadOnly = Not blnEnabled
        End If
        If TypeOf Obj Is TabControl Or TypeOf Obj Is TabPage Or TypeOf Obj Is GroupBox Then
            Dim obj2 As Control
            For Each obj2 In Obj.Controls
                Call SetControlEnabled(obj2, blnEnabled)
            Next
        End If
    End Sub

    Private Sub EnabledControl(ByVal blnEnabled As Boolean)
        Dim obj As Control
        For Each obj In Me.Controls
            Call SetControlEnabled(obj, blnEnabled)
        Next

        cbomtl_Location.Enabled = False
    End Sub
    Private Sub GenComboWarehouse(ByVal ComboWarehouse As ComboBox)

        ComboWarehouse.DataSource = (New classMaster).Combomtlwarehouse(clsUser.UserID)
        ComboWarehouse.DisplayMember = "warehouse_code"
        ComboWarehouse.ValueMember = "mtl_warehouse_id"
    End Sub
    Private Sub GenComboSubvinventory(ByVal ComboWarehouse As ComboBox, ByVal ComboSubvinventory As ComboBox)
        ComboSubvinventory.DataSource = (New classMaster).GetComboMtlsubinventory(INt64mtl_warehouse_id:=(New clsConfig).IsNull(ComboWarehouse.SelectedValue, Nothing))
        ComboSubvinventory.DisplayMember = "subinventory_code"
        ComboSubvinventory.ValueMember = "mtl_subinventory_id"
    End Sub
    Private Sub GenComboLocations()

        cbomtl_Location.DataSource = (New classMaster).Combomtllocations(strUSerID:=clsUser.UserID,
                                          INt64mtl_warehouse_id:=(New clsConfig).IsNull(cbomtl_warehouse.SelectedValue, Nothing),
                                          Int64mtl_subinventory_id:=(New clsConfig).IsNull(cbomtl_subinventory.SelectedValue, Nothing))
        cbomtl_Location.DisplayMember = "location_name"
        cbomtl_Location.ValueMember = "mtl_locations_id"
    End Sub
    Private Sub GenCombo()
        Dim objdb As New classMaster

        Call GenComboWarehouse(ComboWarehouse:=cbomtl_warehouse)
        Call GenComboSubvinventory(ComboWarehouse:=cbomtl_warehouse, ComboSubvinventory:=cbomtl_subinventory)
        Call GenComboLocations()

        frmtl_warehouse_id_to.DataSource = objdb.Combomtlwarehouse(clsUser.UserID)
        frmtl_warehouse_id_to.DisplayMember = "warehouse_code"
        frmtl_warehouse_id_to.ValueMember = "mtl_warehouse_id"

        frmtl_subinventory_id_to.DataSource = objdb.GetComboMtlsubinventory(INt64mtl_warehouse_id:=0)
        frmtl_subinventory_id_to.DisplayMember = "subinventory_code"
        frmtl_subinventory_id_to.ValueMember = "mtl_subinventory_id"

        frmtl_locations_id_to.DataSource = objdb.Combomtllocations(strUSerID:=clsUser.UserID, INt64mtl_warehouse_id:=0, Int64mtl_subinventory_id:=0)
        frmtl_locations_id_to.DisplayMember = "location_name"
        frmtl_locations_id_to.ValueMember = "mtl_locations_id"

        trmtl_warehouse_id_to.DataSource = objdb.Combomtlwarehouse(clsUser.UserID)
        trmtl_warehouse_id_to.DisplayMember = "warehouse_code"
        trmtl_warehouse_id_to.ValueMember = "mtl_warehouse_id"

        trmtl_subinventory_id_to.DataSource = objdb.GetComboMtlsubinventory(INt64mtl_warehouse_id:=0)
        trmtl_subinventory_id_to.DisplayMember = "subinventory_code"
        trmtl_subinventory_id_to.ValueMember = "mtl_subinventory_id"

        trmtl_locations_id_to.DataSource = objdb.Combomtllocations(strUSerID:=clsUser.UserID, INt64mtl_warehouse_id:=0, Int64mtl_subinventory_id:=0)
        trmtl_locations_id_to.DisplayMember = "location_name"
        trmtl_locations_id_to.ValueMember = "mtl_locations_id"

    End Sub


    Private Sub GenComboDocNo()
        Dim objDB As New classYarnLocation
        Me.cboLogNo.ComboBox.DataSource = objDB.getYarnLocationLogNo()
        Me.cboLogNo.ComboBox.DisplayMember = "logno"
        Me.cboLogNo.ComboBox.ValueMember = "logno"
        Me.cboLogNo.ComboBox.SelectedIndex = -1
    End Sub

    Private Sub BindGrid(ByVal dt As DataTable)
        grdYarnIN.AutoGenerateColumns = False
        grdYarnIN.DataSource = dt
    End Sub

    Private Function IsDataChange(ByVal dt As DataTable) As Boolean
        'Dim dt As DataTable = (New GetDataYarn).getYarnLocationLog(strDocNo)
        Dim result As Boolean = False

        Dim delRecs As New DataView(dt, "", "", DataViewRowState.Deleted)
        If delRecs.Count > 0 Then result = True

        Dim updRecs As New DataView(dt, "", "", DataViewRowState.ModifiedCurrent)
        If updRecs.Count > 0 Then result = True

        Dim addRecs As New DataView(dt, "", "", DataViewRowState.Added)
        If addRecs.Count > 0 Then result = True

        IsDataChange = result
    End Function

    Private Sub LoadDataItem(ByVal strITCD As String)
        Dim dt As DataTable = (New classYarnLocation).getYarnIN(strITCD)
        grdYarnIN.AutoGenerateColumns = False
        grdYarnIN.DataSource = dt
    End Sub

    Private Sub LoadDataLocation(ByVal Int64mtl_locations_id As Nullable(Of Int64), ByVal StrLoc As String)
        Dim dt As DataTable = (New classYarnLocation).getYarnINByLocation(Int64mtl_locations_id, StrLoc)
        grdYarnIN.AutoGenerateColumns = False
        grdYarnIN.DataSource = dt
    End Sub

    Private Function LoadDataYarnIn(ByVal StrBoxno As String) As DataTable

        Dim dtByBoxno As DataTable = (New classStockTransferY).GetYarnInDet(StrBoxno)

        Return dtByBoxno

    End Function
    Private Sub BinddatagrdYarnIN(ByVal dtByBoxno As DataTable)

        grdYarnIN.AutoGenerateColumns = False

        Dim dt1 As DataTable = dtByBoxno
        Dim dtYarnIn As DataTable = grdYarnIN.DataSource

        Dim dr As DataRow

        Dim msg As String = ""
        Dim i As Integer = 0
        Dim j As Integer = 0
        For i = 0 To dtByBoxno.Rows.Count - 1

            dr = dtYarnIn.NewRow

            If CheckDuplicate(dtByBoxno.Rows(i)("boxno").ToString, dtYarnIn) Then
                MessageBox.Show("ยิงกล่องซ้ำที่มีอยู่ครับ", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                Exit Sub
            End If

            'For Each dr As dr in dtYarnIn.
            For j = 0 To dtYarnIn.Columns.Count - 1
                dr(j) = dt1.Rows(i)(j)
                dr("row_number") = grdYarnIN.Rows.Count + 1
            Next
            dtYarnIn.Rows.Add(dr)
        Next

        Call CompareTwoGrids()

    End Sub


    Private Sub CompareTwoGrids()
        Dim i As Integer
        Dim j As Integer

        For i = 0 To Me.grdTransfer.Rows.Count - 1
            j = 0
            Do While Me.grdYarnIN.Rows.Count - 1 >= 0 And j <= Me.grdYarnIN.Rows.Count - 1
                If Me.grdYarnIN.Rows(j).Cells("boxno").Value.ToString.Trim = Me.grdTransfer.Rows(i).Cells("tr_boxno").Value.ToString.Trim Then
                    Dim dgvRow As New DataGridViewRow
                    dgvRow = Me.grdYarnIN.Rows(j)
                    Me.grdYarnIN.Rows(j).Cells("spools").Value = Me.grdYarnIN.Rows(j).Cells("spools").Value - Me.grdTransfer.Rows(i).Cells("tr_spools").Value
                    Me.grdYarnIN.Rows(j).Cells("kg_nt").Value = Me.grdYarnIN.Rows(j).Cells("kg_nt").Value - Me.grdTransfer.Rows(i).Cells("tr_kg_nt").Value
                    If Me.grdYarnIN.Rows(j).Cells("spools").Value <= 0 Then
                        Me.grdYarnIN.Rows.Remove(dgvRow)
                    End If
                    j = j + 1
                Else
                    j = j + 1
                End If
            Loop
        Next
    End Sub

    Private Sub LoadDataLog(ByVal strLogNoLoad As String)
        Dim dt As DataTable = (New classStockTransferY).getYarnLocationLog(strLogNoLoad)

        grdTransfer.AutoGenerateColumns = False
        grdTransfer.DataSource = dt

        If dt.Rows.Count > 0 Then
            cboLogNo.Text = dt.Rows(0)("logno").ToString()
            strLogNo = strLogNoLoad
            txtLogNo.Text = strLogNo
            dtpLogDate.Value = dt.Rows(0)("docdt2")
            txtLocationRemarks.Text = dt.Rows(0)("location_remarks").ToString 'Sitthana 20190907

            If (New clsConfig).IsNull(dt.Rows(0)("transfer_type"), "LOCATIONS") = "LOCATIONS" Then
                rbtTransferLocations.Checked = True
                cbomtl_warehouse.SelectedValue = dt.Rows(0)("mtl_warehouse_id_to")
                cbomtl_warehouse.Enabled = False
                Call GenComboSubvinventory(ComboWarehouse:=cbomtl_warehouse, ComboSubvinventory:=cbomtl_subinventory)
                cbomtl_subinventory.SelectedValue = dt.Rows(0)("mtl_subinventory_id_to")
                cbomtl_subinventory.Enabled = False
                Call GenComboLocations()
                cbomtl_Location.SelectedValue = dt.Rows(0)("mtl_locations_id_to")
                cbomtl_Location.Enabled = False
            ElseIf dt.Rows(0)("transfer_type") = "GRADE" Then
                rbtTransfferGrade.Checked = True
                txtGradeTo.Text = dt.Rows(0)("mtl_warehouse_id_to")
                txtGradeTo.Enabled = False
            End If
            rbtTransferLocations.Enabled = False
            rbtTransfferGrade.Enabled = False


            dtpActualMoveDate.Value = CDate(dt.Rows(0)("actual_move_date2").ToString())
            dtpReceiveDate.Value = CDate(dt.Rows(0)("receive_date2").ToString())

            cbomtl_Location.Enabled = False
        Else
            strLogNo = ""
            txtLogNo.Text = strLogNo
            dtpLogDate.Value = Now
            txtLocationRemarks.Text = "" 'Sitthana 20190907
            'cbomtl_Location.Text = ""
            cbomtl_warehouse.SelectedValue = DBNull.Value
            cbomtl_warehouse.Enabled = True
            cbomtl_subinventory.SelectedValue = DBNull.Value
            cbomtl_subinventory.Enabled = True
            cbomtl_Location.SelectedValue = DBNull.Value
            cbomtl_Location.Enabled = True
            txtGradeTo.Text = String.Empty
            'txtGradeTo.Enabled = True
        End If
    End Sub

    Private Sub LoadDataYarn(ByVal StrBoxno As String)
        'Dim dt As DataTable = (New classYarnLocation).getYarnLocationLog(strLogNoLoad)
        'Dim dtfr As DataTable = (New GetDataYarn).getYarnLocationLog(strLogNoLoad)
        Dim dtByBoxno As DataTable = (New classYarnLocation).GetYarnInByBoxno(StrBoxno)

        grdYarnIN.AutoGenerateColumns = False
        grdYarnIN.DataSource = dtByBoxno



        'If dt.Rows.Count > 0 Then
        '    strDocNo = strLogNoLoad
        '    txtLogNo.Text = strDocNo
        '    txtLogDate.Text = dt.Rows(0)("docdt2").ToString()

        '    cbomtl_warehouse.SelectedValue = dt.Rows(0)("mtl_warehouse_id_to")
        '    cbomtl_warehouse.Enabled = False
        '    cbomtl_Location.SelectedValue = dt.Rows(0)("mtl_locations_id_to")
        '    cbomtl_Location.Enabled = False
        '    dtpActualMoveDate.Value = CDate(dt.Rows(0)("actual_move_date2").ToString())
        '    dtpReceiveDate.Value = CDate(dt.Rows(0)("receive_date2").ToString())
        '    cbomtl_warehouse.Enabled = False
        '    cbomtl_Location.Enabled = False
        'Else
        '    strDocNo = ""
        '    txtLogNo.Text = strDocNo
        '    txtLogDate.Text = ""
        '    'cbomtl_Location.Text = ""
        '    cbomtl_warehouse.SelectedValue = DBNull.Value
        '    cbomtl_warehouse.Enabled = True
        '    cbomtl_Location.SelectedValue = DBNull.Value
        '    cbomtl_warehouse.Enabled = True
        '    cbomtl_Location.Enabled = True
        'End If
    End Sub
    Private Function SaveData() As Boolean
        If AllowEdit Or AllowNew Then
            Dim clsYarn As New classYarnLocation
            Dim header As New classMasterUpdate.DM
            Dim msgerr As String = ""
            Dim dtTransferY As DataTable = grdTransfer.DataSource
            Dim yarn_location_log As New classStockTransferY.yarn_location_log
            yarn_location_log.logno = txtLogNo.Text.Trim
            yarn_location_log.logdate = dtpLogDate.Value.ToString("yyyyMMdd")
            yarn_location_log.logtime = dtpLogDate.Value.ToString("hh:mm")
            yarn_location_log.actual_move_date = dtpActualMoveDate.Value.ToString("yyyyMMdd")
            yarn_location_log.receive_date = dtpReceiveDate.Value.ToString("yyyyMMdd")
            yarn_location_log.mtl_warehouse_id_to = (New clsConfig).IsNull(cbomtl_warehouse.SelectedValue, Nothing)
            yarn_location_log.mtl_subinventory_id_to = (New clsConfig).IsNull(cbomtl_subinventory.SelectedValue, Nothing)
            yarn_location_log.mtl_locations_id_to = (New clsConfig).IsNull(cbomtl_Location.SelectedValue, Nothing)


            If (New classStockTransferY).YarnLocationBarcodeSave(yarn_location_log:=yarn_location_log,
                                                                 dtYarnLocationLog:=dtTransferY,
                                                                 log_empcd:=clsUser.UserID,
                                                                 msgerr:=msgerr) Then
                MessageBox.Show("Data has been saved.", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Call GenComboDocNo()
                Call LoadDataLog(yarn_location_log.logno)
                Call LoadDataYarn("")
                SaveData = True
            Else
                MessageBox.Show(msgerr, "System Message", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
                SaveData = False
            End If
        Else
            MessageBox.Show("Permission denied", "Security message", MessageBoxButtons.OK, MessageBoxIcon.Stop)
        End If
    End Function

    Private Function CheckGridYarnIN() As Boolean
        If grdYarnIN.DataSource Is Nothing Then Return False
        If grdYarnIN.Rows.Count = 0 Then Return False
        Dim i As Integer = 0
        For i = 0 To grdYarnIN.Rows.Count - 1
            If CBool(grdYarnIN.Rows(i).Cells("chkSelect").Value) Then Return True
        Next
        Return False
    End Function

    Private Sub AddRollNo()
        If grdYarnIN.Rows.Count > 0 Then
            Dim config As New clsConfig
            Dim dt As DataTable = grdYarnIN.DataSource
            Dim dt2 As DataTable = grdTransfer.DataSource
            Dim dr As DataRow
            Dim msg As String = ""
            Dim i As Integer = 0
            Dim j As Integer = 0
            For i = 0 To dt.Rows.Count - 1
                If CBool(dt.Rows(i)("chkSelect")) And Not CheckDuplicate(dt.Rows(i)("boxno").ToString, dt2) Then 'เช็ค ติ๊ก และ เหมือนกันไหม
                    'If Not CheckDuplicate(dt.Rows(i)("boxno").ToString, dt2) Then
                    dr = dt2.NewRow
                    For j = 0 To dt2.Columns.Count - 1
                        dr(dt2.Columns(j).ColumnName.Trim) = dt.Rows(i)(dt2.Columns(j).ColumnName.Trim)

                        If dt2.Columns(j).ColumnName.Trim = "row_number" Then
                            dr(dt2.Columns(j).ColumnName.Trim) = grdTransfer.Rows.Count + 1
                        End If
                        If rbtTransferLocations.Checked Then
                            If dt2.Columns(j).ColumnName = "mtl_warehouse_id_to" Then
                                dr(dt2.Columns(j).ColumnName.Trim) = cbomtl_warehouse.SelectedValue
                            End If
                            If dt2.Columns(j).ColumnName = "mtl_subinventory_id_to" Then
                                dr(dt2.Columns(j).ColumnName.Trim) = cbomtl_subinventory.SelectedValue
                            End If
                            If dt2.Columns(j).ColumnName = "mtl_locations_id_to" Then
                                dr(dt2.Columns(j).ColumnName.Trim) = cbomtl_Location.SelectedValue
                            End If
                            If dt2.Columns(j).ColumnName.Trim = "location_to" Then
                                dr(dt2.Columns(j).ColumnName.Trim) = cbomtl_Location.Text.Trim
                            End If
                        ElseIf rbtTransfferGrade.Checked Then
                            If dt2.Columns(j).ColumnName = "grade_to" And txtGradeTo.Text.Trim.Length > 0 Then
                                dr(dt2.Columns(j).ColumnName.Trim) = txtGradeTo.Text
                            End If
                            If dt2.Columns(j).ColumnName = "grade_our_to" And txtGradeOurTo.Text.Trim.Length > 0 Then
                                dr(dt2.Columns(j).ColumnName.Trim) = txtGradeOurTo.Text
                            End If
                        End If

                    Next
                    dt2.Rows.Add(dr)
                    'End If
                End If
            Next

            cbomtl_warehouse.Enabled = False
            cbomtl_subinventory.Enabled = False
            cbomtl_Location.Enabled = False

            txtBarcode.Focus()
        End If
    End Sub

    Private Function CheckGridTransfer() As Boolean
        If grdTransfer.DataSource Is Nothing Then Return False
        If grdTransfer.Rows.Count = 0 Then Return False
        Dim i As Integer = 0
        For i = 0 To grdTransfer.Rows.Count - 1
            If CBool(grdTransfer.Rows(i).Cells("tr_chkSelect").Value) Then Return True
        Next
        Return False
    End Function

    Private Sub DeleteRollNo()
        If grdTransfer.Rows.Count > 0 Then
            Dim i As Integer = 0
            Dim dt As DataTable = grdTransfer.DataSource
            Do While i < dt.Rows.Count
                If dt.Rows.Count = 0 Then Exit Do
                For i = 0 To dt.Rows.Count - 1
                    If Not dt.Rows(i).RowState = DataRowState.Deleted Then
                        If CBool(dt.Rows(i)("chkSelect")) Then
                            dt.Rows(i).Delete()
                            Exit For
                        End If
                    End If
                Next
            Loop
            If dt.Rows.Count = 0 Then cbomtl_Location.Enabled = True And cbomtl_warehouse.Enabled = True
        End If
    End Sub

    Private Sub formYarnLocation_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized

        Call InitControl()

    End Sub

    Private Sub btnNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNew.Click
        Call InitControl()
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Me.Validate()

        blnCancel = False
        'Sitthana 20220624 Changed Windows.Forms.DialogResult To DialogResult
        Dim result As DialogResult ' Windows.Forms.DialogResult
        result = MessageBox.Show("Would you like to save ?", "System Message", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button3)

        If result = DialogResult.Cancel Then blnCancel = True
        If result <> DialogResult.Yes Then Exit Sub
        If Not Checkdata() Then Exit Sub

        Me.Cursor = Cursors.WaitCursor
        If SaveData() Then
            ' Call GenComboDocNo()
            ' Call LoadDataLog(strDocNo)
            ' Call LoadDataYarn("")
        End If
        Me.Cursor = Cursors.Default

    End Sub
    Private Function Checkdata() As Boolean
        If grdTransfer.Rows.Count = 0 Then
            MessageBox.Show("คุณต้องเลือกรายการก่อนครับ ถึงจะบันทึกได้", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End If

        Return True
    End Function

    Private Sub btnMinimized_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMinimized.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub btnPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrint.Click
        If strLogNo.Length = 0 Then Exit Sub
        'Const rptFileName = "rptYarnTransfer.rpt"
        Const rptFileName = "rptYarnLocationLog.rpt"
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
        'rpt.Subreports(0).Database.Tables(0).ApplyLogOnInfo(logonInfo)
        rpt.DataSourceConnections.Item(0).SetConnection(clsConn.servername, clsConn.database, False)
        rpt.DataSourceConnections.Item(0).SetLogon(clsConn.Userid, clsConn.Password)
        rpt.VerifyDatabase()
        rpt.SetParameterValue("@lognofr", strLogNo)
        rpt.SetParameterValue("@lognoto", strLogNo)

        'rpt.PrintOptions.PaperSize = CrystalDecisions.Shared.PaperSize.PaperLetter
        'rpt.PrintOptions.PaperOrientation = CrystalDecisions.Shared.PaperOrientation.Portrait
        'rpt.PrintOptions.PaperSource = CrystalDecisions.Shared.PaperSource.Auto

        frm.Title = "Yarn Location Movement"
        'frm.CRViewer.DisplayGroupTree = False
        frm.CRViewer.ReportSource = rpt
        frm.MdiParent = Me.ParentForm
        frm.Show()
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub cboDocNo_DropDownClosed(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboLogNo.DropDownClosed
        strLogNo = clsConfig.IsNull(cboLogNo.ComboBox.SelectedValue, "")
        If strLogNo.Length > 0 Then
            Call LoadDataLog(strLogNo)
            grdYarnIN.AutoGenerateColumns = False
            grdYarnIN.DataSource = (New classStockTransferY).GetYarnInDet("")
        End If
    End Sub

    Private Sub grdYarnIN_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles grdYarnIN.KeyDown
        Dim i As Integer = 0
        If e.KeyCode = Keys.Enter Then
            If grdYarnIN.Columns(grdYarnIN.SelectedCells(i).ColumnIndex).Name = "chkSelect" Then
                For i = 0 To grdYarnIN.SelectedCells.Count - 1
                    grdYarnIN.SelectedCells(i).Value = Not CBool(grdYarnIN.SelectedCells(i).Value)
                Next
            End If
        End If
    End Sub

    Private Sub grdTransfer_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles grdTransfer.KeyDown
        Dim i As Integer = 0
        If e.KeyCode = Keys.Enter Then
            If grdTransfer.Columns(grdTransfer.SelectedCells(i).ColumnIndex).Name = "tr_chkSelect" Then
                For i = 0 To grdTransfer.SelectedCells.Count - 1
                    grdTransfer.SelectedCells(i).Value = Not CBool(grdTransfer.SelectedCells(i).Value)
                Next
            End If
        End If
    End Sub

    Private Sub txtLogNo_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtLogNo.KeyDown
        If e.KeyCode = Keys.Enter Then
            Call LoadDataLog(txtLogNo.Text)
            grdYarnIN.AutoGenerateColumns = False
            grdYarnIN.DataSource = (New classStockTransferY).GetYarnInDet("")
        End If
    End Sub

    'Private Sub btnLoad_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    '    Dim strLoc As String = clsConfig.IsNull(cbomtl_Locationfr.Text, "")
    '    If strLoc.Length > 0 Then
    '        LoadDataLocation(cbomtl_Locationfr.SelectedValue, cbomtl_Locationfr.Text)
    '    End If



    '    txtBarcode.Focus()
    'End Sub

    Private Sub btnSelect_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click

        If Not CheckGridYarnIN() Then Exit Sub

        'Sitthana 20220624 Changed Windows.Forms.DialogResult To DialogResult
        Dim result As DialogResult ' Windows.Forms.DialogResult
        result = MessageBox.Show("Would you like to add selected Roll No. from on top grid to Below grid ?" & vbCrLf & "คุณต้องการเพิ่มกล่องที่เลือกไว้ในด้านบนเพื่อนำไปใส่ในเอกสารด้านล่างใช่หรือไม่ ?", "System Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) '= Windows.Forms.DialogResult.No

        'If result = Windows.Forms.DialogResult.Cancel Then blnCancel = True
        If result <> DialogResult.Yes Then Exit Sub

        If Not CheckDataYarnIn() Then Exit Sub

        Call AddRollNo()
        Call CompareTwoGrids()
    End Sub
    Private Function CheckDataYarnIn() As Boolean

        If rbtTransferLocations.Checked Then
            If cbomtl_warehouse.Text.Trim.Length = 0 Then
                MessageBox.Show("Please fill the new Warehouse to transfer." & vbCrLf & "คุณยังไม่ได้ใส่ Warehouse ที่จะทำการย้ายไป", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
                cbomtl_warehouse.Focus()
                Return False
            End If
            If cbomtl_subinventory.Text.Trim.Length = 0 Then
                MessageBox.Show("Please fill the new SubInventory to transfer." & vbCrLf & "คุณยังไม่ได้ใส่ SubInventory ที่จะทำการย้ายไป", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
                cbomtl_subinventory.Focus()
                Return False
            End If
            If cbomtl_Location.Text.Trim.Length = 0 Then
                MessageBox.Show("Please fill the new Locations to transfer." & vbCrLf & "คุณยังไม่ได้ใส่ Location ที่จะทำการย้ายไป", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
                cbomtl_Location.Focus()
                Return False
            End If

        ElseIf rbtTransfferGrade.Checked Then
            If txtGradeTo.Text.Trim.Length = 0 And txtGradeOurTo.Text.Trim.Length = 0 Then
                MessageBox.Show("Please fill the Grade to transfer or Grade Our to transfer ." & vbCrLf & "คุณยังไม่ได้ใส่ Grade หรือ Grade Our ที่จะทำการย้ายไป", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
                txtGradeTo.Select()
                Return False
            End If
        End If

        Return True
    End Function

    Private Sub btnDeselect_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDel.Click
        If Not CheckGridTransfer() Then Exit Sub
        If MessageBox.Show("Would you like to delete selected Roll No. in right grid ?" & vbCrLf & "คุณต้องการลบกล่องที่เลือกไว้ในเอกสารในด้านขวาออกใช่หรือไม่ ?", "System Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = DialogResult.No Then Exit Sub
        If grdTransfer.CurrentRow.Index >= 0 Then Call DeleteRollNo()

        Call LoadDataYarnIn(LastBarcode)
    End Sub

    Private Sub cboDocNo_Click(sender As System.Object, e As System.EventArgs) Handles cboLogNo.Click

    End Sub

    Private Sub cbomtl_warehouse_DropDownClosed(sender As Object, e As System.EventArgs) Handles cbomtl_warehouse.DropDownClosed
        GenComboSubvinventory(ComboWarehouse:=cbomtl_warehouse, ComboSubvinventory:=cbomtl_subinventory)
        GenComboLocations()
        'Gencbomtl_Location()
    End Sub

    Private Sub cbomtl_warehouse_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cbomtl_warehouse.SelectedIndexChanged

    End Sub

    'Private Sub btnLocations_Click(sender As System.Object, e As System.EventArgs)

    '    Dim frm2 As New frmLocations
    '    frm2.p_mtl_warehouse_id = 1
    '    frm2.p_mtl_subinventory_id = 1
    '    frm2.UserInfo = clsUser
    '    'frm2.MdiParent = Me.ParentForm
    '    frm2.ShowDialog()
    'End Sub

    Private Sub txtBarcode_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles txtBarcode.KeyDown
        If e.KeyCode.Equals(Keys.Enter) Then
            If txtBarcode.Text = "NEW" Then
                Call btnNew_Click(sender, e)
                Exit Sub
            End If

            LastBarcode = txtBarcode.Text.Trim

            Call BinddatagrdYarnIN((New classStockTransferY).GetYarnInDet(txtBarcode.Text.Trim))

            Call FindBoxNoYarnIn(txtBarcode.Text)
            Call FindBoxNoTr(txtBarcode.Text)
            txtBarcode.Text = ""
            txtBarcode.Focus()
        End If
    End Sub

    Private Function CheckDuplicate(ByVal boxno As String, ByVal dt As DataTable) As Boolean
        If dt.Rows.Count > 0 Then
            Dim i As Integer = 0
            For i = 0 To dt.Rows.Count - 1
                If dt.Rows(i).RowState <> DataRowState.Deleted Then
                    If dt.Rows(i)("boxno").ToString.Trim = boxno.Trim Then
                        Return True
                    End If
                End If
            Next
        End If
        Return False
    End Function
    Private Function FindBoxNoYarnIn(strBoxNo As String)
        Dim dt As DataTable = grdYarnIN.DataSource

        For Each dr As DataRow In dt.Rows
            If strBoxNo.Equals(dr("boxno").ToString().Trim) Then
                dr("chkSelect") = 1
                'Call CalculateTotal()
                Return True
            End If
        Next

        Return False
    End Function

    Private Function FindBoxNoTr(strBoxNo As String)
        Dim dt As DataTable = grdTransfer.DataSource

        For Each dr As DataRow In dt.Rows
            If strBoxNo.Equals(dr("boxno").ToString().Trim) Then
                dr("chkSelect") = 1
                'Call CalculateTotal()
                Return True
            End If
        Next

        Return False
    End Function
    Private Sub txtBarcode_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtBarcode.TextChanged

    End Sub

    Private Sub cboItemCode_SelectedIndexChanged(sender As System.Object, e As System.EventArgs)

    End Sub

    Private Sub cbomtl_subinventory_DropDownClosed(sender As Object, e As System.EventArgs) Handles cbomtl_subinventory.DropDownClosed
        Call GenComboLocations()
    End Sub

    Private Sub CalculateSumAndCount(ByVal grd As DataGridView)

        Dim Sum As Decimal
        Dim Count As Int64 = 0
        For Each dgvc As DataGridViewCell In grd.SelectedCells
            If VarType(dgvc.Value) = VariantType.Decimal Or VarType(dgvc.Value) = VariantType.Integer Or VarType(dgvc.Value) = VariantType.Double Then
                Sum = Sum + dgvc.Value
            End If
            Count = Count + 1
        Next

        lblSum.Text = Sum
        lblCount.Text = Count
    End Sub

    Private Sub grdTransfer_CellMouseUp(sender As Object, e As DataGridViewCellMouseEventArgs) Handles grdTransfer.CellMouseUp
        Call CalculateSumAndCount(grd:=grdTransfer)
    End Sub

    Private Sub grdYarnIN_CellMouseUp(sender As Object, e As DataGridViewCellMouseEventArgs) Handles grdYarnIN.CellMouseUp
        Call CalculateSumAndCount(grd:=grdYarnIN)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnYOut.Click

    End Sub

    Private Sub txtGradeTo_TextChanged(sender As Object, e As EventArgs) Handles txtGradeTo.TextChanged

    End Sub

    Private Sub btnMoveDown_Click(sender As Object, e As EventArgs) Handles btnExpandGridBalance.Click
        If grdTransfer.Height > 200 Then
            grdYarnIN.Height = grdYarnIN.Height + 100
            'lbBalanceStock.Top = grdYarnIN.Bottom + 5
            lbTransfer.Top = grdYarnIN.Bottom + 5
            btnExpandGridTransfer.Top = grdYarnIN.Bottom + 5
            'btnExpandGridBalance.Top = grdYarnIN.Bottom + 5
            btnAdd.Top = grdYarnIN.Bottom + 5
            btnDel.Top = grdYarnIN.Bottom + 5
            'btnDelAll.Top = grdYarnIN.Bottom + 5
            'txtSelectRolls.Top = grdYarnIN.Bottom + 5
            'lblStockRoll.Top = grdYarnIN.Bottom + 5
            'txtSelectKgs.Top = grdYarnIN.Bottom + 5
            'lblStockKgs.Top = grdYarnIN.Bottom + 5
            'txtSelectMts.Top = grdYarnIN.Bottom + 5
            'lblStockMts.Top = grdYarnIN.Bottom + 5
            'txtSelectYds.Top = grdYarnIN.Bottom + 5
            'lblStockYds.Top = grdYarnIN.Bottom + 5
            grdTransfer.Top = btnExpandGridTransfer.Bottom + 5
            grdTransfer.Height = grdTransfer.Height - 100
        End If
    End Sub

    Private Sub btnMoveUp_Click(sender As Object, e As EventArgs) Handles btnExpandGridTransfer.Click
        If grdYarnIN.Height > 200 Then
            grdYarnIN.Height = grdYarnIN.Height - 100
            'lbBalanceStock.Top = grdYarnIN.Bottom + 5
            lbTransfer.Top = grdYarnIN.Bottom + 5
            btnExpandGridTransfer.Top = grdYarnIN.Bottom + 5
            'btnExpandGridBalance.Top = grdYarnIN.Bottom + 5
            btnAdd.Top = grdYarnIN.Bottom + 5
            btnDel.Top = grdYarnIN.Bottom + 5
            'btnDelAll.Top = grdYarnIN.Bottom + 5
            'txtSelectRolls.Top = grdYarnIN.Bottom + 5
            'lblStockRoll.Top = grdYarnIN.Bottom + 5
            'txtSelectKgs.Top = grdYarnIN.Bottom + 5
            'lblStockKgs.Top = grdYarnIN.Bottom + 5
            'txtSelectMts.Top = grdYarnIN.Bottom + 5
            'lblStockMts.Top = grdYarnIN.Bottom + 5
            'txtSelectYds.Top = grdYarnIN.Bottom + 5
            'lblStockYds.Top = grdYarnIN.Bottom + 5
            grdTransfer.Top = btnExpandGridTransfer.Bottom
            grdTransfer.Height = grdTransfer.Height + 100
        End If
    End Sub

    Private Sub rbtTransferLocations_CheckedChanged(sender As Object, e As EventArgs) Handles rbtTransferLocations.CheckedChanged
        If rbtTransferLocations.Checked Then
            txtGradeTo.Enabled = False
            txtGradeOurTo.Enabled = False
            cbomtl_warehouse.Enabled = True
            cbomtl_subinventory.Enabled = True
            cbomtl_Location.Enabled = True
        End If
    End Sub

    Private Sub rbtTransfferGrade_CheckedChanged(sender As Object, e As EventArgs) Handles rbtTransfferGrade.CheckedChanged
        If rbtTransfferGrade.Checked Then
            txtGradeTo.Enabled = True
            txtGradeOurTo.Enabled = True
            cbomtl_warehouse.Enabled = False
            cbomtl_subinventory.Enabled = False
            cbomtl_Location.Enabled = False
        End If
    End Sub
End Class