Public Class frmYarnLocation
    Dim clsConfig As New clsConfig
    Dim clsConn As New classConnection
    Dim clsUser As New classUserInfo

    Dim strDocNo As String = ""

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
            DocNo = strDocNo
        End Get
        Set(ByVal NewValue As String)
            strDocNo = NewValue
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
        Call LoadDataLog("")
        Call LoadDataYarn("")

        btnSave.Enabled = AllowEdit
        txtBarcode.Focus()
        'Call LoadDataItem("")
        'txtBarcode.Focus()
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
        ComboSubvinventory.DataSource = (New classMaster).ComboMtlsubinventory(INt64mtl_warehouse_id:=(New clsConfig).IsNull(ComboWarehouse.SelectedValue, Nothing))
        ComboSubvinventory.DisplayMember = "subinventory_code"
        ComboSubvinventory.ValueMember = "mtl_subinventory_id"
    End Sub
    Private Sub GenComboLocations()

        cbomtl_Location.DataSource = (New classMaster).Combomtllocations(strUSerID:=clsUser.UserID, _
                                          INt64mtl_warehouse_id:=(New clsConfig).IsNull(cbomtl_warehouse.SelectedValue, Nothing), _
                                          Int64mtl_subinventory_id:=(New clsConfig).IsNull(cbomtl_subinventory.SelectedValue, Nothing))
        cbomtl_Location.DisplayMember = "location_name"
        cbomtl_Location.ValueMember = "mtl_locations_id"
    End Sub
    Private Sub GenCombo()
        Dim objdb As New classMaster

        Call GenComboWarehouse(ComboWarehouse:=cbomtl_warehouse)
        Call GenComboSubvinventory(ComboWarehouse:=cbomtl_warehouse, ComboSubvinventory:=cbomtl_subinventory)
        Call GenComboLocations()


        frmtl_warehouse.DataSource = objdb.Combomtlwarehouse(clsUser.UserID)
        frmtl_warehouse.DisplayMember = "warehouse_code"
        frmtl_warehouse.ValueMember = "mtl_warehouse_id"

        frmtl_subinventory_id.DataSource = objdb.ComboMtlsubinventory(INt64mtl_warehouse_id:=0)
        frmtl_subinventory_id.DisplayMember = "subinventory_code"
        frmtl_subinventory_id.ValueMember = "mtl_subinventory_id"

        frmtl_locations.DataSource = objdb.Combomtllocations(strUSerID:=clsUser.UserID, INt64mtl_warehouse_id:=0, Int64mtl_subinventory_id:=0)
        frmtl_locations.DisplayMember = "location_name"
        frmtl_locations.ValueMember = "mtl_locations_id"

        trmtl_warehouse.DataSource = objdb.Combomtlwarehouse(clsUser.UserID)
        trmtl_warehouse.DisplayMember = "warehouse_code"
        trmtl_warehouse.ValueMember = "mtl_warehouse_id"

        trmtl_subinventory_id.DataSource = objdb.ComboMtlsubinventory(INt64mtl_warehouse_id:=0)
        trmtl_subinventory_id.DisplayMember = "subinventory_code"
        trmtl_subinventory_id.ValueMember = "mtl_subinventory_id"

        trmtl_locations.DataSource = objdb.Combomtllocations(strUSerID:=clsUser.UserID, INt64mtl_warehouse_id:=0, Int64mtl_subinventory_id:=0)
        trmtl_locations.DisplayMember = "location_name"
        trmtl_locations.ValueMember = "mtl_locations_id"

    End Sub


    Private Sub GenComboDocNo()
        Dim objDB As New classYarnLocation
        Me.cboDocNo.ComboBox.DataSource = objDB.getYarnLocationLogNo()
        Me.cboDocNo.ComboBox.DisplayMember = "logno"
        Me.cboDocNo.ComboBox.ValueMember = "logno"
        Me.cboDocNo.ComboBox.SelectedIndex = -1
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

    Private Sub LoadDataYarnIn(ByVal StrBoxno As String)
        Dim classYarnLocation2 As New classYarnLocation

        Dim dtByBoxno As DataTable = classYarnLocation2.GetYarnLocationByBoxno(StrBoxno)


        BinddatagrdYarnIN(dtByBoxno)

    End Sub
    Private Sub BinddatagrdYarnIN(ByVal dtByBoxno As DataTable)

        'Dim dtYarnIN As DataTable = grdYarnIN.DataSource
        grdYarnIN.AutoGenerateColumns = False

        If dtByBoxno.Rows.Count > 0 Then
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

                For j = 0 To dtYarnIn.Columns.Count - 1 'J = Columns
                    ' dr("chkSelect") = dt1.Rows(i)("chkSelect")
                    'dr("boxno") = dt1.Rows(i)("boxno")
                    'dr("docno") = dt1.Rows(i)("docno")
                    ' dr("docdt") = dt1.Rows(i)("docdt")
                    'dr("docdt2") = dt1.Rows(i)("docdt2")
                    'dr("jobno") = dt1.Rows(i)("jobno")
                    dr(j) = dt1.Rows(i)(j)
                    'dr("boxno") = dt1.Rows(i)("boxno")
                    'dr("docno") = dt1.Rows(i)("docno")
                    'dr("docdt") = dt1.Rows(i)("docdt")
                    'dr("docdt2") = dt1.Rows(i)("docdt2")
                    'dr("jobno") = dt1.Rows(i)("jobno")

                Next
                dtYarnIn.Rows.Add(dr)

            Next

        End If

        Call CompareTwoGrids()

    End Sub


    Private Sub LoadDataLog(ByVal strLogNoLoad As String)
        Dim dt As DataTable = (New classYarnLocation).getYarnLocationLog(strLogNoLoad)

        grdTransfer.AutoGenerateColumns = False
        grdTransfer.DataSource = dt

        'grdYarnIN.AutoGenerateColumns = False
        'grdYarnIN.DataSource = dtfr

        If dt.Rows.Count > 0 Then
            cboDocNo.Text = dt.Rows(0)("docno").ToString()
            strDocNo = strLogNoLoad
            txtLogNo.Text = strDocNo
            dtpLogDate.Value = dt.Rows(0)("docdt2")
            'dtpLogDate.Text = dt.Rows(0)("docdt2").ToString()
            'cbomtl_Location.Text = dt.Rows(0)("loc").ToString()

            cbomtl_warehouse.SelectedValue = dt.Rows(0)("mtl_warehouse_id_to")
            cbomtl_warehouse.Enabled = False
            Call GenComboSubvinventory(ComboWarehouse:=cbomtl_warehouse, ComboSubvinventory:=cbomtl_subinventory)
            cbomtl_subinventory.SelectedValue = dt.Rows(0)("mtl_subinventory_id_to")
            cbomtl_subinventory.Enabled = False
            Call GenComboLocations()
            cbomtl_Location.SelectedValue = dt.Rows(0)("mtl_locations_id_to")
            cbomtl_Location.Enabled = False
            dtpActualMoveDate.Value = CDate(dt.Rows(0)("actual_move_date2").ToString())
            dtpReceiveDate.Value = CDate(dt.Rows(0)("receive_date2").ToString())

            cbomtl_Location.Enabled = False
            btnSave.Enabled = False
        Else
            strDocNo = ""
            txtLogNo.Text = strDocNo
            dtpLogDate.Value = Now
            'cbomtl_Location.Text = ""
            cbomtl_warehouse.SelectedValue = DBNull.Value
            cbomtl_warehouse.Enabled = True
            cbomtl_subinventory.SelectedValue = DBNull.Value
            cbomtl_subinventory.Enabled = True
            cbomtl_Location.SelectedValue = DBNull.Value
            cbomtl_Location.Enabled = True
            btnSave.Enabled = True
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
            Dim dt As DataTable = grdTransfer.DataSource

            strDocNo = txtLogNo.Text.Trim

            If strDocNo.Length > 0 Then
                If dt.Rows.Count > 0 Then
                    If dt.Rows(0)("actual_move_date").ToString() <> dtpActualMoveDate.Value.ToString("yyyyMMdd") Or _
                    dt.Rows(0)("receive_date").ToString() <> dtpReceiveDate.Value.ToString("yyyyMMdd") Or _
                    dt.Rows(0)("loc").ToString() <> cbomtl_Location.Text Then
                        Call clsYarn.YarnLocationSaveHeader(strDocNo, _
                                                            cbomtl_Location.Text, _
                                                            dtpActualMoveDate.Value.ToString("yyyyMMdd"), _
                                                            dtpReceiveDate.Value.ToString("yyyyMMdd"), _
                                                            cbomtl_warehouse.SelectedValue, _
                                                            cbomtl_subinventory.SelectedValue, _
                                                            cbomtl_Location.SelectedValue, _
                                                            cbomtl_warehouse.SelectedValue, _
                                                            cbomtl_subinventory.SelectedValue, _
                                                            cbomtl_Location.SelectedValue)
                    End If
                End If
            End If

            Dim add As New DataView(dt, "", "", DataViewRowState.Added)
            Dim del As New DataView(dt, "", "", DataViewRowState.Deleted)


            If clsYarn.YarnLocationBarcodeSave(add, del, msgerr, clsUser.UserID, strDocNo) Then
                MessageBox.Show("Data has been saved.", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
                SaveData = True
                'Call InitControl()
                'Call GenComboDocNo()
                Call LoadDataLog(strDocNo)
                Call LoadDataYarn("")
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

                        If dt2.Columns(j).ColumnName.Trim = "loc" Then
                            dr(dt2.Columns(j).ColumnName.Trim) = cbomtl_Location.Text.Trim
                        End If
                        If dt2.Columns(j).ColumnName = "mtl_warehouse_id" Then
                            dr(dt2.Columns(j).ColumnName.Trim) = cbomtl_warehouse.SelectedValue
                        End If
                        If dt2.Columns(j).ColumnName = "mtl_subinventory_id" Then
                            dr(dt2.Columns(j).ColumnName.Trim) = cbomtl_subinventory.SelectedValue
                        End If
                        If dt2.Columns(j).ColumnName = "mtl_locations_id" Then
                            dr(dt2.Columns(j).ColumnName.Trim) = cbomtl_Location.SelectedValue
                        End If

                        If dt2.Columns(j).ColumnName = "mtl_warehouse_id_to" Then
                            dr(dt2.Columns(j).ColumnName.Trim) = cbomtl_warehouse.SelectedValue
                        End If
                        'If dt2.Columns(j).ColumnName = "trmtl_subinventory_id" Then
                        '    dr(dt2.Columns(j).ColumnName.Trim) = cbomtl_subinventory.SelectedValue
                        'End If

                        If dt2.Columns(j).ColumnName = "mtl_subinventory_id_to" Then
                            dr(dt2.Columns(j).ColumnName.Trim) = cbomtl_subinventory.SelectedValue
                        End If
                        If dt2.Columns(j).ColumnName = "mtl_locations_id_to" Then
                            dr(dt2.Columns(j).ColumnName.Trim) = cbomtl_Location.SelectedValue
                        End If

                    Next
                    dt2.Rows.Add(dr)
                    'End If
                End If
            Next

            Call CompareTwoGrids()

            cbomtl_warehouse.Enabled = False
            cbomtl_subinventory.Enabled = False
            cbomtl_Location.Enabled = False

            txtBarcode.Focus()
        End If
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

        Call InitControl()

    End Sub

    Private Sub btnNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNew.Click
        Call InitControl()
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        If MessageBox.Show("Would you like to save ?", "System Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = DialogResult.Yes Then
            Call SaveData()
        End If
    End Sub

    Private Sub btnMinimized_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMinimized.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub btnPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrint.Click
        If strDocNo.Length = 0 Then Exit Sub
        Const rptFileName = "rptYarnTransfer.rpt"
        'Const rptFileName = "rptYarnLocationLog.rpt"
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
        rpt.SetParameterValue("@lognofr", strDocNo)
        rpt.SetParameterValue("@lognoto", strDocNo)

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

    Private Sub cboDocNo_DropDownClosed(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboDocNo.DropDownClosed
        strDocNo = clsConfig.IsNull(cboDocNo.ComboBox.SelectedValue, "")
        If strDocNo.Length > 0 Then LoadDataLog(strDocNo)
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
        If e.KeyCode = Keys.Enter Then Call LoadDataLog(txtLogNo.Text)
    End Sub

    'Private Sub btnLoad_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    '    Dim strLoc As String = clsConfig.IsNull(cbomtl_Locationfr.Text, "")
    '    If strLoc.Length > 0 Then
    '        LoadDataLocation(cbomtl_Locationfr.SelectedValue, cbomtl_Locationfr.Text)
    '    End If



    '    txtBarcode.Focus()
    'End Sub

    Private Sub btnSelect_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSelect.Click
        If Not CheckGridYarnIN() Then Exit Sub
        If MessageBox.Show("Would you like to add selected Roll No. from left grid to right grid ?" & vbCrLf & "คุณต้องการเพิ่มกล่องที่เลือกไว้ด้านซ้ายเพื่อนำไปใส่ในเอกสารด้านขวาใช่หรือไม่ ?", "System Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = DialogResult.No Then Exit Sub
        If cbomtl_warehouse.Text.Trim.Length = 0 Then
            MessageBox.Show("Please fill the new Warehouse to transfer." & vbCrLf & "คุณยังไม่ได้ใส่ Warehouse ที่จะทำการย้ายไป", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            cbomtl_warehouse.Focus()
            Exit Sub
        End If

        If cbomtl_subinventory.Text.Trim.Length = 0 Then
            MessageBox.Show("Please fill the new SubInventory to transfer." & vbCrLf & "คุณยังไม่ได้ใส่ SubInventory ที่จะทำการย้ายไป", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            cbomtl_subinventory.Focus()
            Exit Sub
        End If

        If cbomtl_Location.Text.Trim.Length = 0 Then
            MessageBox.Show("Please fill the new Locations to transfer." & vbCrLf & "คุณยังไม่ได้ใส่ Location ที่จะทำการย้ายไป", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            cbomtl_Location.Focus()
            Exit Sub
        End If

        Call AddRollNo()

    End Sub

    Private Sub btnDeselect_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDeselect.Click
        If Not CheckGridTransfer() Then Exit Sub
        If MessageBox.Show("Would you like to delete selected Roll No. in right grid ?" & vbCrLf & "คุณต้องการลบกล่องที่เลือกไว้ในเอกสารในด้านขวาออกใช่หรือไม่ ?", "System Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = DialogResult.No Then Exit Sub
        If grdTransfer.CurrentRow.Index >= 0 Then Call DeleteRollNo()

        LoadDataYarnIn(LastBarcode)

    End Sub

    Private Sub cboDocNo_Click(sender As System.Object, e As System.EventArgs) Handles cboDocNo.Click

    End Sub

    Private Sub cbomtl_warehouse_DropDownClosed(sender As Object, e As System.EventArgs) Handles cbomtl_warehouse.DropDownClosed
        GenComboSubvinventory(ComboWarehouse:=cbomtl_warehouse, ComboSubvinventory:=cbomtl_subinventory)
        GenComboLocations()
        'Gencbomtl_Location()
    End Sub

    Private Sub cbomtl_warehouse_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cbomtl_warehouse.SelectedIndexChanged

    End Sub

    Private Sub btnLocations_Click(sender As System.Object, e As System.EventArgs) Handles btnLocations.Click

        Dim frm2 As New frmmtl_locations
        frm2.p_mtl_warehouse_id = 1
        frm2.p_mtl_subinventory_id = 1
        frm2.UserInfo = clsUser
        'frm2.MdiParent = Me.ParentForm
        frm2.ShowDialog()
    End Sub

    Private Sub txtBarcode_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles txtBarcode.KeyDown
        If e.KeyCode.Equals(Keys.Enter) Then

            If txtBarcode.Text = "NEW" Then
                Call btnNew_Click(sender, e)
                Exit Sub
            End If

            LastBarcode = txtBarcode.Text.Trim

            LoadDataYarnIn(LastBarcode)

            Call FindBoxNoYarnIn(LastBarcode)
            Call FindBoxNoTr(LastBarcode)
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
End Class