Public Class frmCuttingIN
    Dim oCuttingIN As New classCuttingIN
    Dim oConfig As New clsConfig

    Dim dtCuttingIN As New DataTable
    Dim bsCuttingIN As New BindingSource
    Dim drvCuttingIN As DataRowView

    Dim dtDyedOut As New DataTable
    Dim bsDyedOut As New BindingSource
    Dim drvDyedOut As DataRowView

    Dim _UserEvents As String 'Add or Edit or Copy or Add_Chid
    Dim _UserAction As String 'Ok or Exit
    Dim clsuser As New classUserInfo
    Dim _DinNo As String

    'Detail
    'Dim dtCuttingIN_D As New DataTable
    'Dim bsCuttingIN_D As New BindingSource
    Dim currentRollNoD As String = ""
    Dim currentOutNo As String = ""
    Dim currentSoNo As String = ""
    Dim currentSoNoId As String = ""
    'Private _mtlSvc As MtlLookupService
    Private _suppress As Boolean = False

    Dim oConn As New ClassConnection
    Private Const COL_WAREHOUSE As String = "colCuttingINMtlWarehouse"
    Private Const COL_SUBINV As String = "colCuttingINMtlSubInventory"
    Private Const COL_LOCATION As String = "colCuttingINMtlLocation"
    Private Const COL_MTS As String = "colCuttingINMts"
    Private Const COL_YDS As String = "colCuttingINYds"
    Private Const MTS_TO_YDS As Double = 1.09361
    Private _summaryEventsInitialized As Boolean = False

    Public Sub InitMtlCascading()
        ' _mtlSvc = New MtlLookupService(My.Settings.ConnStr)

        AddHandler dgvCuttingIN.CurrentCellDirtyStateChanged, AddressOf dgvCuttingIn_CurrentCellDirtyStateChanged
        AddHandler dgvCuttingIN.CellValueChanged, AddressOf dgvCuttingIn_CellValueChanged

        If Not _summaryEventsInitialized Then
            AddHandler dgvCuttingIN.RowsAdded, AddressOf dgvCuttingIN_RowsAdded
            AddHandler dgvCuttingIN.RowsRemoved, AddressOf dgvCuttingIN_RowsRemoved
            _summaryEventsInitialized = True
        End If
    End Sub


    Public Property pUserEvents As String
        Get
            pUserEvents = _UserEvents
        End Get
        Set(ByVal Newvalue As String)
            _UserEvents = Newvalue
        End Set
    End Property
    Public Property pUserAction As String
        Get
            pUserAction = _UserAction
        End Get
        Set(ByVal Newvalue As String)
            _UserAction = Newvalue
        End Set
    End Property
    Public Property Userinfo() As classUserInfo
        Get
            Userinfo = clsuser
        End Get
        Set(ByVal newvalue As classUserInfo)
            clsuser = newvalue
        End Set
    End Property
    Private Sub bsCuttingIN_BindingComplete(ByVal sender As Object, ByVal e As BindingCompleteEventArgs)

        ' Check if the data source has been updated, and that no error has occurred.
        If e.BindingCompleteContext = BindingCompleteContext.DataSourceUpdate _
            AndAlso e.Exception Is Nothing Then

            ' If not, end the current edit.
            e.Binding.BindingManagerBase.EndCurrentEdit()
        End If
    End Sub
    Private Sub setDefaultValuesFordtCuttingINRecord()
        For Each dc As DataColumn In dtCuttingIN.Columns
            Select Case dc.ColumnName
                Case "dinno"
                    ' EDIT mode: ม้วนใหม่รับ CIN No. จาก document เดิม
                    If pUserEvents = "EDIT" AndAlso dtCuttingIN.Rows.Count > 0 Then
                        dc.DefaultValue = oConfig.IsNull(dtCuttingIN.Rows(0)("dinno"), "")
                    End If
                Case "dindt"
                    ' EDIT mode: ม้วนใหม่รับ CIN Date จาก document เดิม (ไม่ใช้ Now)
                    If pUserEvents = "EDIT" AndAlso dtCuttingIN.Rows.Count > 0 Then
                        dc.DefaultValue = dtCuttingIN.Rows(0)("dindt")
                    Else
                        dc.DefaultValue = Now
                    End If
                Case "mtl_warehouse_id"
                    dc.DefaultValue = Userinfo.MtlWareHouseID
                Case "warehouse_code"
                    dc.DefaultValue = "COLOMBO"
                Case "mtl_subinventory_id"
                    dc.DefaultValue = oCuttingIN.selectdefaultSubInventoryId(Userinfo.MtlWareHouseID) '61
                Case "subinventory_code"
                    dc.DefaultValue = "STKC"
                Case "mtl_location_id"
                    dc.DefaultValue = oCuttingIN.selectdefaultLocationId(Userinfo.MtlWareHouseID) '61
                Case "location_name"
                    dc.DefaultValue = "N/A"
                Case "doctyp"
                    dc.DefaultValue = "C"
            End Select
        Next
    End Sub

    Private Sub clearDataBindings()
        Dim obj As Control
        For Each obj In Me.Controls
            clearControlBindings(obj)
        Next
    End Sub

    Private Sub clearControlBindings(ByVal obj As Control)
        obj.DataBindings.Clear()
        If TypeOf obj Is TabControl Or TypeOf obj Is TabPage Or TypeOf obj Is GroupBox Then
            Dim obj2 As Control
            For Each obj2 In obj.Controls
                clearControlBindings(obj2)
            Next
        End If
    End Sub
    Private Sub initDataBindingCuttingIN(ByVal CINo As String)
        AddHandler bsCuttingIN.BindingComplete, AddressOf bsCuttingIN_BindingComplete
        'drvItemsList = CType(bsItemsList.Current, DataRowView)

        dtCuttingIN.Clear()
        'dtItemsRecord = oItems.selectItemsRecord(IsNull(_ItemId, 0), _AppSessionID, _AppUserID, _AppConn)
        Select Case pUserEvents.ToString.Trim
            Case "ADD"
                dtCuttingIN = oCuttingIN.selectCuttingINRecord(CINo)
                setDefaultValuesFordtCuttingINRecord()
                'Dim drNew As DataRow = dtCuttingIN.NewRow()
                ' drNew("dinno") = ""
                ' drNew("dindt") = Now
              '  dtCuttingIN.Rows.Add(drNew)
            Case "EDIT"
                dtCuttingIN = oCuttingIN.selectCuttingINRecord(CINo)
                setDefaultValuesFordtCuttingINRecord()
        End Select

        'setDefaultValuesForDtItems()
        ' validatedUserEvents()

        bsCuttingIN.DataSource = dtCuttingIN.DefaultView
        bsCuttingIN.MoveFirst()

        drvCuttingIN = CType(bsCuttingIN.Current, DataRowView)
        '_ItemId = IsNull(drvItemsRecord("item_id"), Nothing)

        clearDataBindings()

        'ITEM HEADER
        txtCInNo.DataBindings.Add("text", bsCuttingIN, "dinno", True, DataSourceUpdateMode.OnPropertyChanged)
        dtpCinDate.DataBindings.Add("text", bsCuttingIN, "dindt", True, DataSourceUpdateMode.OnPropertyChanged)

        If Not drvCuttingIN Is Nothing Then
            Dim OutNo As String = oConfig.IsNull(drvCuttingIN.Row("dfno"), "")
            If OutNo.ToString.Length > 0 Then initDataBindingDyedOut(OutNo)
        End If

        dgvCuttingIN.AutoGenerateColumns = False
        dgvCuttingIN.DataSource = bsCuttingIN
        SumCuttingIN()

    End Sub
    Private Sub GenCombo()

        colCuttingINMtlSubInventory.DataSource = oCuttingIN.selectMtlSubInventoryList(Userinfo.MtlWareHouseID)
        colCuttingINMtlSubInventory.DisplayMember = "subinventory_code"
        colCuttingINMtlSubInventory.ValueMember = "mtl_subinventory_id"

        colCuttingINMtlLocation.DataSource = oCuttingIN.selectMtlLocationList(61)
        colCuttingINMtlLocation.DisplayMember = "location_name"
        colCuttingINMtlLocation.ValueMember = "mtl_locations_id"
    End Sub

    Private Sub dgvCuttingIn_CurrentCellDirtyStateChanged(sender As Object, e As EventArgs)
        If dgvCuttingIN.IsCurrentCellDirty Then
            Dim colName = dgvCuttingIN.Columns(dgvCuttingIN.CurrentCell.ColumnIndex).Name
            If colName = COL_WAREHOUSE OrElse colName = COL_SUBINV OrElse colName = COL_LOCATION OrElse colName = COL_MTS Then
                dgvCuttingIN.CommitEdit(DataGridViewDataErrorContexts.Commit)
            End If
        End If
    End Sub

    Private Sub dgvCuttingIn_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs)
        If _suppress Then Return
        If e.RowIndex < 0 Then Return
        If e.ColumnIndex < 0 Then Return

        Dim colName As String = dgvCuttingIN.Columns(e.ColumnIndex).Name

        If colName = COL_WAREHOUSE Then
            HandleWarehouseChanged(e.RowIndex)

        ElseIf colName = COL_SUBINV Then
            HandleSubInvChanged(e.RowIndex)

        ElseIf colName = COL_MTS Then
            HandleMtsChanged(e.RowIndex)

        End If

        If colName = "colCuttingINKg" OrElse colName = COL_MTS OrElse colName = COL_YDS Then
            SumCuttingIN()
        End If
    End Sub
    Private Sub HandleWarehouseChanged(rowIndex As Integer)
        Dim whObj = dgvCuttingIN.Rows(rowIndex).Cells(COL_WAREHOUSE).Value
        Dim warehouseId As Integer = If(IsDBNull(whObj) OrElse whObj Is Nothing, 0, CInt(whObj))

        _suppress = True

        ' reset subinv + location values
        dgvCuttingIN.Rows(rowIndex).Cells(COL_SUBINV).Value = DBNull.Value
        dgvCuttingIN.Rows(rowIndex).Cells(COL_LOCATION).Value = DBNull.Value

        ' bind new subinventory datasource for this row
        BindSubInventoryForRow(rowIndex, Userinfo.MtlWareHouseID)

        ' clear location datasource for this row (optional)
        BindLocationForRow(rowIndex, 0)

        _suppress = False
    End Sub
    Private Sub HandleSubInvChanged(rowIndex As Integer)
        Dim subObj = dgvCuttingIN.Rows(rowIndex).Cells(COL_SUBINV).Value
        Dim subInvId As Integer = If(IsDBNull(subObj) OrElse subObj Is Nothing, 0, CInt(subObj))

        _suppress = True

        dgvCuttingIN.Rows(rowIndex).Cells(COL_LOCATION).Value = DBNull.Value
        BindLocationForRow(rowIndex, subInvId)

        _suppress = False
    End Sub
    Private Sub HandleMtsChanged(rowIndex As Integer)
        Dim mtsObj = dgvCuttingIN.Rows(rowIndex).Cells(COL_MTS).Value
        If IsDBNull(mtsObj) OrElse mtsObj Is Nothing Then Exit Sub
        Dim mtsVal As Double
        If Not Double.TryParse(mtsObj.ToString, mtsVal) Then Exit Sub
        dgvCuttingIN.Rows(rowIndex).Cells(COL_YDS).Value = Math.Round(mtsVal * MTS_TO_YDS, 2)
    End Sub

    Private Sub BindSubInventoryForRow(rowIndex As Integer, warehouseId As Integer)

        Dim cell = TryCast(dgvCuttingIN.Rows(rowIndex).Cells(COL_SUBINV), DataGridViewComboBoxCell)
        If cell Is Nothing Then Exit Sub

        Dim dt As DataTable
        If warehouseId <= 0 Then
            dt = New DataTable
            dt.Columns.Add("mtl_subinventory_id", GetType(Integer))
            dt.Columns.Add("subinventory_code", GetType(String))
        Else
            dt = oCuttingIN.selectMtlSubInventoryList(warehouseId)
        End If

        cell.DisplayMember = "subinventory_code"
        cell.ValueMember = "mtl_subinventory_id"
        cell.DataSource = dt
    End Sub
    Private Sub BindLocationForRow(rowIndex As Integer, subInvId As Integer)

        Dim cell = TryCast(dgvCuttingIN.Rows(rowIndex).Cells(COL_LOCATION), DataGridViewComboBoxCell)
        If cell Is Nothing Then Exit Sub

        Dim dt As DataTable
        If subInvId <= 0 Then
            dt = New DataTable
            dt.Columns.Add("mtl_locations_id", GetType(Integer))
            dt.Columns.Add("location_name", GetType(String))
        Else
            dt = oCuttingIN.selectMtlLocationList(subInvId)
        End If

        cell.DisplayMember = "location_name"
        cell.ValueMember = "mtl_locations_id"
        cell.DataSource = dt
    End Sub

    Private Sub frmCuttingIN_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized

        GenCombo()
        pUserEvents = "ADD"

        InitControl()
        initDataBindingCuttingIN("")
        InitMtlCascading()
    End Sub

    Private Sub btnSearchPLS_Click(sender As Object, e As EventArgs) Handles btnSearchCIN.Click

    End Sub

    Private Sub txtCInNo_KeyDown(sender As Object, e As KeyEventArgs) Handles txtCInNo.KeyDown
        If e.KeyCode = Keys.Enter Then
            Dim pCinNo As String = txtCInNo.Text.Trim
            pUserEvents = "EDIT"
            initDataBindingCuttingIN(pCinNo)
        End If
    End Sub
    Private Sub RebindMtlCombosForVisibleRows()
        For Each row As DataGridViewRow In dgvCuttingIN.Rows
            If row.IsNewRow Then Continue For

            Dim whObj = row.Cells(COL_WAREHOUSE).Value
            Dim whId As Integer = If(whObj Is Nothing OrElse IsDBNull(whObj), 0, CInt(whObj))
            BindSubInventoryForRow(row.Index, Userinfo.MtlWareHouseID)

            Dim subObj = row.Cells(COL_SUBINV).Value
            Dim subId As Integer = If(subObj Is Nothing OrElse IsDBNull(subObj), 0, CInt(subObj))
            BindLocationForRow(row.Index, subId)
        Next
    End Sub

    Private Sub dgvDout_SelectionChanged(sender As Object, e As EventArgs) Handles dgvDout.SelectionChanged
        If dgvDout.CurrentRow Is Nothing Then Exit Sub

        currentRollNoD = Convert.ToString(dgvDout.CurrentRow.Cells("colRollNoD").Value).Trim()
        currentOutNo = txtOutNo.Text.Trim
        If currentRollNoD = "" Then Exit Sub

        ' โหลด Cutting IN detail ตาม roll_no_d (แนะนำให้ทำ SP แยก)
        ' ถ้ายังไม่มี ให้สร้าง method: selectCuttingINDetailByRollNoD(rollNoD)
        'dtCuttingIN = oCuttingIN.selectCuttingINRecord(currentRollNoD)

        'bsCuttingIN.DataSource = dtCuttingIN
        'dgvCuttingIN.AutoGenerateColumns = False
        'dgvCuttingIN.DataSource = bsCuttingIN

        ' กันเครื่องหมาย ' ในข้อมูล (เช่น O'Neil)
        Dim rollEsc As String = currentRollNoD.Replace("'", "''")
        bsCuttingIN.EndEdit()
        ' กรองตาม roll_no_p (roll no parent) ให้โชว์เฉพาะของ roll นี้
        bsCuttingIN.Filter = "roll_no_p = '" & rollEsc & "'"
        bsCuttingIN.ResetBindings(False)
        dgvCuttingIN.Refresh()

        RebindMtlCombosForVisibleRows()
        SumCuttingIN()

        ' ใส่ค่า default ให้แถวใหม่
        RemoveHandler dgvCuttingIN.DefaultValuesNeeded, AddressOf dgvCuttingIN_DefaultValuesNeeded
        AddHandler dgvCuttingIN.DefaultValuesNeeded, AddressOf dgvCuttingIN_DefaultValuesNeeded
    End Sub
    Private Sub InitControl()
        Dim obj As Control
        For Each obj In Me.Controls
            Call SetControlValue(obj)
        Next
        Call EnabledControl(True)
        Call SetErrorProvider()

        ' txtOutno.Enabled = False
        ' dtpOutDt.Enabled = False
    End Sub
    Private Sub SetControlValue(ByVal Obj As Control)
        If TypeOf Obj Is TextBox Then
            Obj.Text = Obj.Tag

        End If
        If TypeOf Obj Is DateTimePicker Then
            Dim dtp As DateTimePicker = Obj
            dtp.Value = Now
            dtp.Checked = False
        End If
        If TypeOf Obj Is ComboBox Then
            Dim cbo As ComboBox = Obj
            cbo.SelectedIndex = -1
        End If
        If TypeOf Obj Is CheckBox Then
            Dim chk As CheckBox = Obj
            chk.Checked = False
            If chk.Name = "chkAutoCalculate" Then chk.Checked = True

        End If
        If TypeOf Obj Is TabControl Or TypeOf Obj Is TabPage Or TypeOf Obj Is GroupBox Then
            Dim obj2 As Control
            For Each obj2 In Obj.Controls
                Call SetControlValue(obj2)
            Next
        End If
    End Sub

    Private Sub EnabledControl(ByVal blnEnabled As Boolean)
        Dim obj As Control
        For Each obj In Me.Controls
            Call SetControlEnabled(obj, blnEnabled)
        Next

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


    Private Sub SetErrorProvider()
        ErrorProvider1.Clear()
    End Sub

    Private Sub initDataBindingDyedOut(ByVal OutNo As String)

        dtDyedOut = oCuttingIN.selectDyedOutRecord(OutNo)
        bsDyedOut.DataSource = dtDyedOut

        dgvDout.AutoGenerateColumns = False
        dgvDout.DataSource = bsDyedOut
        bsDyedOut.MoveFirst()

        ' ผูก event ครั้งเดียว (กันซ้ำ)
        txtOutNo.DataBindings.Clear()
        txtOutNo.DataBindings.Add("text", bsDyedOut, "outno", True, DataSourceUpdateMode.OnPropertyChanged)
        txtOutReqNo.DataBindings.Clear()
        txtOutReqNo.DataBindings.Add("text", bsDyedOut, "outreqno", True, DataSourceUpdateMode.OnPropertyChanged)

        RemoveHandler dgvDout.SelectionChanged, AddressOf dgvDout_SelectionChanged
        AddHandler dgvDout.SelectionChanged, AddressOf dgvDout_SelectionChanged

        ' เลือกแถวแรกแล้ว trigger
        If dgvDout.Rows.Count > 0 Then
            dgvDout.Rows(0).Selected = True
            dgvDout_SelectionChanged(Nothing, EventArgs.Empty)
        End If
    End Sub
    Private Sub txtOutNo_KeyDown(sender As Object, e As KeyEventArgs) Handles txtOutNo.KeyDown
        If e.KeyCode = Keys.Enter Then
            Dim pOutNo As String = txtOutNo.Text.Trim
            initDataBindingDyedOut(pOutNo)

        End If
    End Sub

    Private Sub dgvCuttingIN_DefaultValuesNeeded(sender As Object, e As DataGridViewRowEventArgs) Handles dgvCuttingIN.DefaultValuesNeeded
        If String.IsNullOrWhiteSpace(currentRollNoD) Then Exit Sub

        ' roll_no_p = Parent Roll (ม้วนต้นทางจาก Dyed Out)
        e.Row.Cells("colRollNoP").Value = currentRollNoD 'roll_no_p = Roll Parent
        e.Row.Cells("colCuttingINDfNo").Value = currentOutNo 'dfno = Out No.
        e.Row.Cells("colCuttingINSoNo").Value = currentSoNo 'S/O No
        e.Row.Cells("colCuttingINSoNoId").Value = currentSoNoId 'S/O No

        ' ถ้าคุณมีคอลัมน์ roll_no_d ในตาราง detail ด้วย แนะนำใส่ด้วย (กันสับสน/ค้นหาง่าย)
        If dgvCuttingIN.Columns.Contains("colRollNoD") Then
            e.Row.Cells("colRollNoD").Value = currentRollNoD
        End If
    End Sub

    Private Sub dgvCuttingIN_RowsAdded(sender As Object, e As DataGridViewRowsAddedEventArgs)
        SumCuttingIN()
    End Sub

    Private Sub dgvCuttingIN_RowsRemoved(sender As Object, e As DataGridViewRowsRemovedEventArgs)
        SumCuttingIN()
    End Sub

    Private Sub SumCuttingIN()
        Dim totalRolls As Integer = 0
        Dim totalKg As Decimal = 0D
        Dim totalMts As Decimal = 0D
        Dim totalYds As Decimal = 0D

        For Each row As DataGridViewRow In dgvCuttingIN.Rows
            If row.IsNewRow OrElse Not row.Visible Then Continue For

            totalRolls += 1
            totalKg += GetDecimalValue(row.Cells("colCuttingINKg").Value)
            totalMts += GetDecimalValue(row.Cells(COL_MTS).Value)
            totalYds += GetDecimalValue(row.Cells(COL_YDS).Value)
        Next

        txtTotalRolls.Text = totalRolls.ToString("#,##0")
        txtTotalKg.Text = totalKg.ToString("#,##0.00")
        txtTotalMts.Text = totalMts.ToString("#,##0.00")
        txtTotalYds.Text = totalYds.ToString("#,##0.00")
    End Sub

    Private Function GetDecimalValue(value As Object) As Decimal
        If value Is Nothing OrElse value Is DBNull.Value Then Return 0D

        Dim result As Decimal
        If Decimal.TryParse(value.ToString(), result) Then Return result

        Return 0D
    End Function

    Private Function SaveCuttingIN() As Boolean

        bsCuttingIN.EndEdit()
        Dim dt As DataTable
        If TypeOf bsCuttingIN.DataSource Is DataView Then
            dt = DirectCast(bsCuttingIN.DataSource, DataView).Table
        Else
            dt = DirectCast(bsCuttingIN.DataSource, DataTable)
        End If

        Dim dv_add As New DataView(dt, "", "", DataViewRowState.Added)
        Dim dv_upd As New DataView(dt, "", "", DataViewRowState.ModifiedCurrent)
        Dim dv_del As New DataView(dt, "", "", DataViewRowState.Deleted)
        Dim msgerr As String = "'"

        Dim Cuttingheader As New classCuttingIN.CINHeader

        Cuttingheader.dinno = txtCInNo.Text.Trim
        Cuttingheader.dindt = dtpCinDate.Value
        Cuttingheader.doctyp = "C"

        If (New classCuttingIN).SaveCuttingIN(StrollsDHeader:=Cuttingheader, DV_ADD:=dv_add, DV_UPD:=dv_upd, DV_DEL:=dv_del, Userinfo:=Userinfo, msgerr:=msgerr) Then
            _DinNo = Cuttingheader.dinno
            dtCuttingIN = oCuttingIN.selectCuttingINRecord(_DinNo)
            bsCuttingIN.DataSource = dtCuttingIN.DefaultView
            dgvCuttingIN.DataSource = bsCuttingIN
            SumCuttingIN()
            MessageBox.Show("บันทึกสำเร็จ", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
            pUserEvents = "EDIT"
            SaveCuttingIN = True
        Else
            MessageBox.Show(msgerr, "System Message", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
            SaveCuttingIN = False
        End If

    End Function

    Private Function CheckData() As Boolean
        Dim result As Boolean = True


        Return True
    End Function

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim result As DialogResult ' Windows.Forms.DialogResult
        result = MessageBox.Show("Would you like to Save Hanger in?", "System Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button3)
        If result <> DialogResult.Yes Then Exit Sub

        If Not CheckData() Then Exit Sub

        Call SaveCuttingIN()
    End Sub

    Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click
        Me.WindowState = FormWindowState.Maximized

        GenCombo()
        pUserEvents = "ADD"

        InitControl()
        initDataBindingCuttingIN("")
        initDataBindingDyedOut("")
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub tsbCINDocument_Click(sender As Object, e As EventArgs) Handles tsbCINDocument.Click
        Dim CinNo As String = txtCInNo.Text
        Dim clsConfig As New clsConfig
        Dim rptFileName = "rptCIN.rpt"
        If clsuser.ReportPath = "" Then clsuser.ReportPath = clsuser.ReportPath
        'clsUser.ReportPath = "C:\Users\DELL\Desktop\GemmaKnits\"
        If Not clsConfig.CheckReport(clsuser.ReportPath, rptFileName) Then Exit Sub
        Dim frm As New frmReport
        Dim rpt As New CrystalDecisions.CrystalReports.Engine.ReportDocument
        Dim stype As String = ""
        Dim ord As String = ""
        Me.Cursor = Cursors.WaitCursor

        rpt.Load(clsuser.ReportPath & rptFileName)
        rpt.DataSourceConnections.Item(0).SetConnection(oConn.servername, oConn.database, False)
        rpt.DataSourceConnections.Item(0).SetLogon(oConn.Userid, oConn.Password)
        rpt.VerifyDatabase()
        rpt.SetParameterValue("@dinnofr", CinNo)
        rpt.SetParameterValue("@dinnoto", CinNo)
        'rpt.PrintOptions.PaperSize = CrystalDecisions.Shared.PaperSize.PaperA4
        'rpt.PrintOptions.PaperOrientation = CrystalDecisions.Shared.PaperOrientation.Portrait
        'rpt.PrintOptions.PaperSource = CrystalDecisions.Shared.PaperSource.Auto

        frm.Title = "CIN Document"
        frm.CRViewer.ReportSource = rpt
        frm.MdiParent = Me.ParentForm
        frm.Show()
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub tsbCINTag_Click(sender As Object, e As EventArgs) Handles tsbCINTag.Click
        Dim CinNo As String = txtCInNo.Text
        Dim clsConfig As New clsConfig
        Dim rptFileName = "rptStockCBarcode.rpt"
        If clsuser.ReportPath = "" Then clsuser.ReportPath = clsuser.ReportPath
        'clsUser.ReportPath = "C:\Users\DELL\Desktop\GemmaKnits\"
        If Not clsConfig.CheckReport(clsuser.ReportPath, rptFileName) Then Exit Sub
        Dim frm As New frmReport
        Dim rpt As New CrystalDecisions.CrystalReports.Engine.ReportDocument
        Dim stype As String = ""
        Dim ord As String = ""
        Me.Cursor = Cursors.WaitCursor

        rpt.Load(clsuser.ReportPath & rptFileName)
        rpt.DataSourceConnections.Item(0).SetConnection(oConn.servername, oConn.database, False)
        rpt.DataSourceConnections.Item(0).SetLogon(oConn.Userid, oConn.Password)
        rpt.VerifyDatabase()
        'With grdData
        ' If .Rows.Count > 0 Then
        rpt.SetParameterValue("@roll_no", CinNo) '.Rows(.CurrentRow.Index).Cells("roll_no_d").Value)
        rpt.SetParameterValue("@loc", "") '.Rows(.CurrentRow.Index).Cells("loc").Value)
        rpt.SetParameterValue("@logempcd", Userinfo.UserID)
        '   Else
        '    MessageBox.Show("ไม่มีข้อมูลใน grid", "Mistake (ข้อผิดพลาด)", MessageBoxButtons.OK, MessageBoxIcon.Information)
        'Exit Sub
        'End If
        'End With

        'rpt.PrintOptions.PaperSize = CrystalDecisions.Shared.PaperSize.PaperLetter
        'rpt.PrintOptions.PaperOrientation = CrystalDecisions.Shared.PaperOrientation.Portrait
        'rpt.PrintOptions.PaperSource = CrystalDecisions.Shared.PaperSource.Auto

        frm.Title = "CIN Barcode"
        frm.CRViewer.ReportSource = rpt
        frm.MdiParent = Me.ParentForm
        frm.Show()
        Me.Cursor = Cursors.Default
    End Sub
End Class
