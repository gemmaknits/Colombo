

Public Class frmProductionRoutingWarping

       Dim clsuser As new classUserInfo
    Dim clsProductionRouting As classProductionRouting
    Dim KO As KO
    Dim mfg_production_lots As mfg_production_lots
    Dim clsConn As New classConnection
    Dim MfgProductionOrderLines As MfgProductionOrderLines
    ' Dim dtmfg_production_steps As DataTable


    Public Property KOdata As KO
        Get
            KOdata = KO
        End Get
        Set(ByVal NewValue As KO)
            KO = NewValue
        End Set

    End Property

    Public Property MfgProductionOrderLinesData As MfgProductionOrderLines
        Get
            MfgProductionOrderLinesData = MfgProductionOrderLines
        End Get
        Set(ByVal Newvalue As MfgProductionOrderLines)
            MfgProductionOrderLines = Newvalue
        End Set
    End Property
    Public Property UserInfo() As classUserInfo
        Get
            UserInfo = clsuser
        End Get
        Set(ByVal NewValue As classUserInfo)
            clsuser = NewValue
        End Set
    End Property

    Public Property ProductionRouting() As classProductionRouting
        Get
            ProductionRouting = clsProductionRouting
        End Get
        Set(ByVal NewValue As classProductionRouting)
            clsProductionRouting = NewValue
        End Set
    End Property

    Private Property IntStep_number As String

    Private Sub frmProductionRouting_FormClosing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Me.WindowState = FormWindowState.Normal
    End Sub

    Private Sub frmProductionRouting_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized

        Call InitControl()

        Call CheckBtnGenlots()

        txtProdNo.Text = KO.kono
        txtDesign_no.Text = KO.design_no
        txtqty.Text = KO.qty
        txtBOM.Text = KO.ynchgcd

        lblCancelled.Visible = KO.cancel
        lblKOClosed.Visible = KO.koclosed
        lblKOClosedFinal.Visible = KO.koclosed_final
        If lblCancelled.Visible Or lblKOClosed.Visible Or lblKOClosedFinal.Visible Then EnabledControl(False)

        mfg_production_lots.mfg_production_steps_id = Nothing

        Call LoadDataRouting(Intmfg_production_steps_id:=Nothing, Strproduction_order_no:=KO.kono)
        Call LoadDataLots(Intmfg_production_steps_id:=mfg_production_lots.mfg_production_steps_id, Strproduction_order_no:=KO.kono)
        Call CheckLots(grdDataLots.DataSource)

    End Sub

    Private Sub EnabledControl(ByVal blnEnabled As Boolean)
        Dim obj As Control
        For Each obj In Me.Controls
            Call SetControlEnabled(obj, blnEnabled)
        Next

        btnSave.Enabled = blnEnabled
        btnViewRolls.Enabled = blnEnabled
        btnNewStep.Enabled = blnEnabled
        btnCopyStep.Enabled = blnEnabled
        BtnDeleteStep.Enabled = blnEnabled
        BtnUPStep.Enabled = blnEnabled
        BtnDownStep.Enabled = blnEnabled
        btnnewroll.Enabled = blnEnabled
        btnCopyRoll.Enabled = blnEnabled
        btnDelRoll.Enabled = blnEnabled
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

    Private Function Validate_KoNo(Optional ByVal StrKono As String = "") As Boolean
        Dim objdb As New classProductionLots
        Dim dt As DataTable = objdb.GetProductionLots(Nothing, StrKono)
        If dt.Rows.Count = 0 Then
            'MessageBox.Show("KO No .: " & StrKono & "............   is Not Correct!!", "SyStem Messsage", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return False
        Else
            Return True
        End If
    End Function
    Private Sub EnablePage(Optional ByVal TabPage As TabPage = Nothing, Optional ByVal enable As Boolean = Nothing) 'Check This
        Dim tabsInTabStrip As Integer = TabControl1.TabCount

        If (enable) = True And tabsInTabStrip < 2 Then
            TabControl1.TabPages.Add(TabPage) 'Check this
            'TabControl1.TabPages.Add(page)
            'hiddenPages.Remove(page);
            'TabPage.Show()

            'TabPage.Hide()
        ElseIf (enable) = False Then 'And tabsInTabStrip < 2 Then
            'TabPage.Hide()
            TabControl1.TabPages.Remove(TabPage)
        End If

    End Sub
    Private Function CheckBtnGenlots() As Boolean

    End Function

    Private Function CheckLots(Optional ByVal dt As DataTable = Nothing) As Boolean

        If dt.Rows.Count > 0 Then
            'If Validate_KoNo(KO.kono) Then
            EnablePage(TPlots, True)
            'TabControl1.TabPages.Add(TPlots)
        Else
            EnablePage(TPlots, False)
            'TabControl1.TabPages.Remove(TPlots)
        End If

    End Function

    'Private Sub AddColumnsGrid()
    ' Sitthana Comment 20181219 Because Not use In Program
    '    'Dim step_number As New DataGridViewColumn

    '    Dim colstep_number As New DataGridViewTextBoxColumn
    '    Dim colstep_name As New DataGridViewTextBoxColumn
    '    Dim colplan_start_date As New DataGridViewCalendarColumn
    '    Dim colplan_end_date As New DataGridViewCalendarColumn
    '    Dim colactual_start_date As New DataGridViewCalendarColumn
    '    Dim colactual_end_date As New DataGridViewCalendarColumn
    '    Dim colcbomcno As New DataGridViewComboBoxColumn
    '    Dim coloperator As New DataGridViewTextBoxColumn
    '    Dim colwork_shift As New DataGridViewTextBoxColumn
    '    'Dim colstep_status As New DataGridViewTextBoxColumn
    '    Dim colcbostep_status As New DataGridViewComboBoxColumn
    '    Dim colstep_remarks As New DataGridViewTextBoxColumn


    '    colstep_number.HeaderText = "STEP NO"
    '    colstep_number.DataPropertyName = "step_number"
    '    colstep_number.Name = "step_number"
    '    colstep_number.ReadOnly = True

    '    colstep_name.HeaderText = "STEP NAME"
    '    colstep_name.DataPropertyName = "step_name"
    '    colstep_name.Name = "step_name"
    '    colstep_name.ReadOnly = True

    '    colplan_start_date.HeaderText = "PLAN START"
    '    colplan_start_date.DataPropertyName = "plan_start_date"
    '    colplan_start_date.Name = "plan_start_date"

    '    colplan_end_date.HeaderText = "PLAN END"
    '    colplan_end_date.DataPropertyName = "plan_end_date"
    '    colplan_end_date.Name = "plan_end_date"

    '    colactual_start_date.HeaderText = "ACTUAL START"
    '    colactual_start_date.DataPropertyName = "actual_start_date"
    '    colactual_start_date.Name = "actual_start_date"

    '    colactual_end_date.HeaderText = "ACTUAL END"
    '    colactual_end_date.DataPropertyName = "actual_end_date"
    '    colactual_end_date.Name = "actual_end_date"

    '    colcbomcno.HeaderText = "M/C NO."
    '    colcbomcno.DataPropertyName = "mcno"
    '    colcbomcno.Name = "cbomcno"
    '    colcbomcno.DisplayStyle = DataGridViewComboBoxDisplayStyle.ComboBox
    '    GenCBOcbomcno(colcbomcno)
    '    'colcbomcno.DataGridView = objdb.comboMachine(clsuser.UserID)
    '    'colcbomcno.ValueMember = "mcno"
    '    'colcbomcno.DisplayMember = "mcno"

    '    coloperator.HeaderText = "OPERATOR"
    '    coloperator.DataPropertyName = "operator"
    '    coloperator.Name = "cbooperator"
    '    coloperator.ReadOnly = True


    '    colwork_shift.HeaderText = "SHIFT"
    '    colwork_shift.DataPropertyName = "work_shift"
    '    colwork_shift.Name = "work_shift"

    '    colcbostep_status.HeaderText = "STATUS"
    '    colcbostep_status.DataPropertyName = "step_status"
    '    colcbostep_status.Name = "cbostep_status"
    '    colcbostep_status.DisplayStyle = DataGridViewComboBoxDisplayStyle.ComboBox
    '    GenCboStepStatus(colcbostep_status)

    '    'actual_start_date
    '    'plan_end_date

    '    Me.grdDataRouting.Columns.Add(colstep_number)
    '    Me.grdDataRouting.Columns.Add(colstep_name)
    '    Me.grdDataRouting.Columns.Add(colcbostep_status)
    '    Me.grdDataRouting.Columns.Add(colplan_start_date)
    '    Me.grdDataRouting.Columns.Add(colplan_end_date)
    '    Me.grdDataRouting.Columns.Add(colactual_start_date)
    '    Me.grdDataRouting.Columns.Add(colactual_end_date)
    '    Me.grdDataRouting.Columns.Add(colcbomcno)
    '    Me.grdDataRouting.Columns.Add(coloperator)
    '    Me.grdDataRouting.Columns.Add(colwork_shift)


    '    'Me.grdData.RowCount = 5
    '    Dim row As DataGridViewRow
    '    For Each row In Me.grdDataRouting.Rows
    '        row.Cells(0).Value = DateTime.Now

    '    Next row
    'End Sub

    Private Sub InitControl()
        Dim obj As Control
        For Each obj In Me.Controls
            Call SetControlValue(obj)
        Next
        Call EnabledControl(True)

        Call GenCBOcbomcno(cbomcno)
        Call GenCboStepStatus(cbostep_status)
        Call GenCbooperations(operation_id)
        Call GenCboWarpBeam(cboBeamItem)
        Call LoadDataRouting(0, 0)
        Call LoadDataLots(0, 0)

        txtProdNo.Text = ""
        txtDesign_no.Text = ""
        txtqty.Text = ""
        txtBOM.Text = ""

    End Sub

    Private Sub SetControlValue(ByVal Obj As Control)
        If TypeOf Obj Is TextBox Then
            If Obj.Tag = "str" Then Obj.Text = ""
            If Obj.Tag = "int" Then Obj.Text = "0.00"
        End If
        If TypeOf Obj Is DateTimePicker Then
            Dim dtp As DateTimePicker = Obj
            dtp.Value = Now
        End If
        If TypeOf Obj Is ComboBox Then
            Dim cbo As ComboBox = Obj
            cbo.SelectedValue = ""
        End If
        If TypeOf Obj Is TabControl Or TypeOf Obj Is TabPage Or TypeOf Obj Is GroupBox Then
            Dim obj2 As Control
            For Each obj2 In Obj.Controls
                Call SetControlValue(obj2)
            Next
        End If
    End Sub


    Private Sub CleargrdData(Optional ByVal Intmfg_routing_header_id As Nullable(Of Integer) = Nothing, Optional ByVal Intmfg_routing_lines_id As Nullable(Of Integer) = Nothing, Optional ByVal Strrouting_code As String = Nothing)
        Dim objdb As New classProductionRouting

        grdDataRouting.AutoGenerateColumns = False
        grdDataRouting.DataSource = objdb.GetRoutingMaster(Intmfg_routing_header_id, Intmfg_routing_lines_id, Strrouting_code)

    End Sub

    Private Sub GenCbooperations(ByRef cbooperations As DataGridViewComboBoxColumn)
        Dim objdb As New classOperations

        cbooperations.DataSource = objdb.Getoperations(Nothing)
        cbooperations.ValueMember = "mfg_operations_id"
        cbooperations.DisplayMember = "operation_name"


    End Sub



    Private Function GenCBOcbomcno(ByRef cbomcno As DataGridViewComboBoxColumn) As DataGridViewComboBoxColumn
        Dim objdb As New classMaster

        '=============================
        cbomcno.DataSource = objdb.comboMachine(clsuser.UserID)
        cbomcno.ValueMember = "mcno"
        cbomcno.DisplayMember = "mcno"

        Return cbomcno

    End Function
    Private Sub GenCboStepStatus(ByRef cbostatus As DataGridViewComboBoxColumn)
        Dim objdb As New classMaster

        cbostatus.DataSource = objdb.comboStatus(clsuser.UserID)
        cbostatus.ValueMember = "status_name"
        cbostatus.DisplayMember = "status_name"

    End Sub
    Private Function GenCboWarpBeam(ByRef cboBeamItem As DataGridViewComboBoxColumn) As DataGridViewComboBoxColumn
        'Sitthan 20181219 'wait
        Dim objdb As New classMaster

        cboBeamItem.DataSource = objdb.comboBeamItem(clsuser.UserID)
        cboBeamItem.ValueMember = "beam_item_id"
        cboBeamItem.DisplayMember = "beamitdesc"
        Return cboBeamItem
    End Function
    Private Sub LoadDataRouting(ByVal Intmfg_production_steps_id As Nullable(Of Integer), ByVal Strproduction_order_no As String)
        Dim objdb As New classProductionRouting
        Dim dt As New DataTable

        dt = objdb.GetProductionRounting(Intmfg_production_steps_id, Strproduction_order_no)

        grdDataRouting.AutoGenerateColumns = False
        grdDataRouting.DataSource = dt

        If dt.Rows.Count > 0 Then
            txtrouting_code.Text = dt.Rows("0")("routing_code").ToString.Trim
            'grdData.AutoGenerateColumns = False
            'grdData.DataSource = dt
        End If

        Call SumgrdDataLots()

    End Sub
    Private Sub LoadDataLots(ByVal Intmfg_production_steps_id As Nullable(Of Integer), ByVal Strproduction_order_no As String)
        Dim objdb As New classProductionLots
        Dim dt As New DataTable

        dt = objdb.GetProductionLotsWarp(Nothing, Intmfg_production_steps_id, Strproduction_order_no)

        grdDataLots.AutoGenerateColumns = False
        grdDataLots.DataSource = dt

        'If dt.Rows.Count > 0 Then

        'End If

        Call SumgrdDataLots()

    End Sub
    Private Sub btnSearchRouting_Code_Click(sender As System.Object, e As System.EventArgs) Handles btnSearchRouting_Code.Click
        Dim frm As New frmSearchMFGRouting
        frm.ShowDialog(Me)
        txtrouting_code.Text = (frm.Prouting_code.Trim.ToUpper)
        Me.Cursor = Cursors.WaitCursor

        If txtrouting_code.Text <> "" Then
            GetRouting()
        End If
        Me.Cursor = Cursors.Default
        frm.Dispose()
    End Sub
    Private Sub GetRouting()
        Dim dt As DataTable
        Dim objdb As New classProductionRouting
        '=================Get Routing ==================
        dt = objdb.GetRoutingMaster(Nothing, Nothing, txtrouting_code.Text.Trim)

        'grdData.DataSource = dt

        BindRouting(dt)
        '================================================

    End Sub

    Private Function BindRouting(ByVal dt As DataTable) As Boolean

        'txtDesign_no.Text = dt.Rows(0)("routing_id").ToString
        'grdData.Rows.Clear()
        '======================Delete row======================'
        Dim TTLrows As Int16 = (Me.grdDataRouting.RowCount - 1)
        'Dim CheckVal As String
        With Me.grdDataRouting
            For Xx = TTLrows To 0 Step -1
                .Rows.Remove(.Rows(Xx))
                'CheckVal = .Rows(Xx).Cells(0).Value
                'If CheckVal.Contains("-") Then
                '.Rows.Remove(.Rows(Xx))
                'End If
            Next
        End With
        '======================================================'

        grdDataRouting.AutoGenerateColumns = False
        Dim config As New clsConfig

        If dt.Rows.Count > 0 Then
            Dim dt1 As DataTable = dt ' dtdb is a database
            Dim dt2 As DataTable = grdDataRouting.DataSource 'dtgrid is a grd
            dt2 = grdDataRouting.DataSource

            Dim i As Integer
            Dim j As Integer
            Dim dr As DataRow

            For i = 0 To dt1.Rows.Count - 1
                dr = dt2.NewRow

                'If dt1.Rows(i)("routing_id").ToString <> dt2.Rows(i)("routing_id").ToString Then


                'dt1.Rows(i)("mfg_production_steps_id") = dt1.Rows(i)("mfg_production_steps_id")
                'dr("routing_id") = dt1.Rows(i)("routing_id")

                For j = 0 To dt2.Columns.Count - 1
                    dr("step_name") = dt1.Rows(i)("step_name")
                    dr("mfg_production_steps_id") = dt1.Rows(i)("mfg_production_steps_id")
                    dr("routing_id") = dt1.Rows(i)("routing_id")
                    dr("operation_id") = dt1.Rows(i)("operation_id")
                    dr("plan_start_date") = dt1.Rows(i)("plan_start_date")
                    dr("plan_end_date") = dt1.Rows(i)("plan_end_date")
                    dr("actual_start_date") = dt1.Rows(i)("actual_start_date")
                    dr("actual_end_date") = dt1.Rows(i)("actual_end_date")
                    dr("step_status") = dt1.Rows(i)("step_status")
                    dr("created_by") = dt1.Rows(i)("created_by")
                    dr("creation_date") = dt1.Rows(i)("creation_date")
                    dr("last_modified_by") = dt1.Rows(i)("last_modified_by")
                    dr("last_modified_date") = dt1.Rows(i)("last_modified_date")
                    dr("production_order_no") = dt1.Rows(i)("production_order_no")
                    dr("mcno") = dt1.Rows(i)("mcno")
                    dr("work_shift") = dt1.Rows(i)("work_shift")
                    dr("step_number") = dt1.Rows(i)("step_number")
                    dr("step_remarks") = dt1.Rows(i)("step_remarks")
                Next
                dt2.Rows.Add(dr)

                'End If
            Next
        End If

    End Function

    Private Sub btnNew_Click(sender As System.Object, e As System.EventArgs)
        Call InitControl()
    End Sub

    Private Sub btnSave_Click(sender As System.Object, e As System.EventArgs) Handles btnSave.Click

        'If grdDataRouting.Focus Then
        '    txtrouting_code.Focus()
        '    grdDataRouting.EndEdit() 'Add By Neung 20151211 Fix Bug User
        'End If

        If grdDataRouting.Rows.Count = 0 Then
            If MessageBox.Show("ยังไม่ได้ใส่ข้อมูล Routing", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Stop) Then
                Exit Sub
            End If
        End If

        If SaveDataRouting() And SaveDataLots() Then

            MessageBox.Show("บันทึกสำเร็จ", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
        Else

        End If

        CheckLots(grdDataLots.DataSource)

    End Sub

    Public Function SaveDataRouting() As Boolean

        If Not grdDataRouting.DataSource Is Nothing Then
            If grdDataRouting.Rows.Count > 0 Then
                If grdDataRouting.CurrentCell.IsInEditMode Then
                    Dim cell As DataGridViewCell = grdDataRouting.CurrentCell
                    grdDataRouting.EndEdit(DataGridViewDataErrorContexts.Commit)
                    grdDataRouting.CurrentCell = grdDataRouting.Rows(0).Cells("step_number")
                    grdDataRouting.CurrentCell = cell
                End If
            End If
        End If

        Dim config As New clsConfig
        Dim mfg_production_steps As New mfg_production_steps
        Dim classProductionRouting As New classProductionRouting

        mfg_production_steps.mfg_production_steps_id = Nothing
        mfg_production_steps.routing_id = Nothing
        mfg_production_steps.operation_id = Nothing
        mfg_production_steps.plan_start_date = Nothing
        mfg_production_steps.plan_end_date = Nothing
        mfg_production_steps.plan_step_qty = txtqty.Text.Trim
        mfg_production_steps.actual_start_date = Nothing
        mfg_production_steps.actual_end_date = Nothing
        mfg_production_steps.step_status = Nothing
        mfg_production_steps.created_by = clsuser.UserID
        mfg_production_steps.creation_date = Now
        mfg_production_steps.last_modified_by = clsuser.UserID
        mfg_production_steps.last_modified_date = Now
        mfg_production_steps.production_order_no = txtProdNo.Text.Trim
        mfg_production_steps.mcno = Nothing
        mfg_production_steps.work_shift = Nothing
        mfg_production_steps.step_number = Nothing
        mfg_production_steps.step_remarks = Nothing

        Dim dv_add As New DataView(grdDataRouting.DataSource, "", "", DataViewRowState.Added)
        Dim dv_upd As New DataView(grdDataRouting.DataSource, "", "", DataViewRowState.ModifiedCurrent)
        Dim dv_del As New DataView(grdDataRouting.DataSource, "", "", DataViewRowState.Deleted)

        Dim result As DialogResult 'Windows.Forms.DialogResult
        result = MessageBox.Show("Would You Like To save ?", "System Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button3)
        If result = DialogResult.No Then Exit Function

        If classProductionRouting.SavaData(mfg_production_steps, dv_add, dv_upd, dv_del, clsuser) Then

            LoadDataRouting(Intmfg_production_steps_id:=mfg_production_steps.mfg_production_steps_id, Strproduction_order_no:=mfg_production_steps.production_order_no)
            Return True
        Else
            MessageBox.Show(mfg_production_steps.message, "System Message", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
            Return False
        End If

    End Function
    Public Function GenDataLots() As Boolean
        Dim PSetPerLot As Nullable(Of Integer)
        Dim classProductionLots As New classProductionLots

        mfg_production_lots.mfg_production_lots_id = Nothing
        mfg_production_lots.system_lot_number = String.Empty
        mfg_production_lots.custom_lot_number = Nothing
        mfg_production_lots.inventory_item_code = txtDesign_no.Text.Trim
        mfg_production_lots.lot_delivered_to_inventory = Nothing
        mfg_production_lots.production_order_no = KO.kono
        mfg_production_lots.primary_quantity = Nothing
        mfg_production_lots.secondary_quantity = Nothing
        mfg_production_lots.created_by = Nothing
        mfg_production_lots.creation_date = Nothing
        mfg_production_lots.last_modified_by = Nothing
        mfg_production_lots.last_modified_date = Nothing
        mfg_production_lots.mfg_production_steps_id = Nothing
        mfg_production_lots.mfg_production_steps_id = grdDataRouting.CurrentRow.Cells("mfg_production_steps_id").Value
        mfg_production_lots.lot_grade = Nothing
        mfg_production_lots.qc_remarks = Nothing

        mfg_production_lots.message = Nothing


        'mfg_production_lots.mfg_production_steps_id = grdDataRouting.CurrentRow.Cells("mfg_production_steps_id").Value

        Dim dv_add As New DataView(grdDataLots.DataSource, "", "", DataViewRowState.Added)
        Dim dv_upd As New DataView(grdDataLots.DataSource, "", "", DataViewRowState.ModifiedCurrent)
        Dim dv_del As New DataView(grdDataLots.DataSource, "", "", DataViewRowState.Deleted)
        Dim dt As DataTable = grdDataLots.DataSource
        Dim clsconfig As New clsConfig
        Dim result As DialogResult
        result = MessageBox.Show("Would You Like To Gens Lots ?", "System Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button3)
        If result = DialogResult.No Then Exit Function

        'Dim frm As New frmGenWarpSet
        'frm.Text = "No. Of Set"
        'frm.txtQty.Text = "1"
        'frm.ShowDialog(Me)
        'Me.Cursor = Cursors.WaitCursor
        'int_set_per_lot = frm.p_set_per_lot
        'Me.Cursor = Cursors.Default

        Dim message, title As String
        Dim defaultValue As String

        'Dim ObjSetPerLot As Object
        message = "Plase Enter No. of Set"
        title = "System Message"
        defaultValue = 0
        'Dim Valid As Boolean
        ' Dim Data As String

        'End While
        ' ObjSetPerLot = InputBox(message, title, defaultValue)
        PSetPerLot = InputBox(message, title, defaultValue)
        'If ObjSetPerLot Is 0 Then ObjSetPerLot = defaultValue
        'PSetPerLot = DirectCast(ObjSetPerLot, Integer)
        'PSetPerLot = Integer.TryParse(InputBox(message, title, defaultValue), 0)
        'If TypeOf ObjSetPerLot Is Integer Then
        '    PSetPerLot = DirectCast(ObjSetPerLot, Integer)
        'Else
        '    PSetPerLot = 0
        'End If
        If PSetPerLot = 0 Then Return False

        dt = classProductionLots.GenDataLots(mfg_production_lots:=mfg_production_lots, grdDataLots:=grdDataLots.DataSource, set_per_lot:=clsconfig.IsNull(PSetPerLot, 0), dv_add:=dv_add, dv_upd:=dv_upd, dv_del:=dv_del, clsuser:=clsuser) 'Then

        If dt.Rows.Count > 0 Then
            Call BindDataLots(dt)
            Call SaveDataLots()
        Else
            MessageBox.Show(mfg_production_lots.message, "System Message", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
        End If

        CheckLots(grdDataLots.DataSource)

    End Function

    Private Sub BindDataLots(ByVal dt As DataTable)
        Dim config As New clsConfig

        Dim k As Integer = 0

        grdDataLots.AutoGenerateColumns = False

        If dt.Rows.Count > 0 Then
            Dim dt1 As DataTable = dt
            Dim dt2 As DataTable = grdDataLots.DataSource

            Dim dr As DataRow

            Dim msg As String = ""
            Dim i As Integer = 0
            Dim j As Integer = 0
            For i = 0 To dt.Rows.Count - 1



                dr = dt2.NewRow

                For j = 0 To dt2.Columns.Count - 1

                    'dr("mfg_production_lots_id") = dt1.Rows(i)("mfg_production_lots_id") 'Disible By Neung 2016/04/06
                    dr("system_lot_number") = dt1.Rows(i)("system_lot_number")
                    dr("custom_lot_number") = dt1.Rows(i)("custom_lot_number")
                    dr("inventory_item_code") = dt1.Rows(i)("inventory_item_code")
                    dr("lot_delivered_to_inventory") = dt1.Rows(i)("lot_delivered_to_inventory")
                    dr("production_order_no") = dt1.Rows(i)("production_order_no")
                    dr("primary_quantity") = dt1.Rows(i)("primary_quantity")
                    dr("secondary_quantity") = dt1.Rows(i)("secondary_quantity")
                    dr("created_by") = dt1.Rows(i)("created_by")
                    dr("creation_date") = dt1.Rows(i)("creation_date")
                    dr("last_modified_by") = dt1.Rows(i)("last_modified_by")
                    dr("last_modified_date") = dt1.Rows(i)("last_modified_date")
                    dr("mfg_production_steps_id") = dt1.Rows(i)("mfg_production_steps_id")
                    dr("lot_grade") = dt1.Rows(i)("lot_grade")
                    dr("qc_remarks") = dt1.Rows(i)("qc_remarks")

                    dr("mtl_warehouse_id") = dt1.Rows(i)("mtl_warehouse_id")
                    dr("mtl_subinventory_id") = dt1.Rows(i)("mtl_subinventory_id")
                    dr("mtl_locations_id") = dt1.Rows(i)("mtl_locations_id")
                    dr("steam_condition") = dt1.Rows(i)("steam_condition")
                    dr("steam_date") = dt1.Rows(i)("steam_date")
                    dr("steam_time") = dt1.Rows(i)("steam_time")
                    dr("operator_lot_number") = dt1.Rows(i)("operator_lot_number")

                    '================== Warp ====================
                    dr("beam_length") = dt1.Rows(i)("beam_length")
                    dr("weight_before_warp") = dt1.Rows(i)("weight_before_warp")
                    'dr("beam_item_id") = dt1.Rows(i)("beam_item_id") 'Sitthana 20181219
                Next
                dt2.Rows.Add(dr)

            Next

        End If


    End Sub


    Public Function SaveDataLots() As Boolean

        If Not grdDataLots.DataSource Is Nothing Then
            If grdDataLots.Rows.Count > 0 Then
                If grdDataLots.CurrentCell.IsInEditMode Then
                    Dim cell As DataGridViewCell = grdDataLots.CurrentCell
                    txtrouting_code.Focus()  'Sitthana 20181219 -- because need to change grd to end edit
                    grdDataLots.EndEdit(DataGridViewDataErrorContexts.Commit)

                    'grdDataLots.CurrentCell = grdDataLots.Rows(0).Cells(1) 'Sitthana comment 20181219
                    'grdDataLots.CurrentCell = cell 'Sitthana comment 20181219
                End If
            End If
        End If



        Dim classProductionLots As New classProductionLots
        Dim Defect_Roll_Header As New Defect_roll_Header
        Dim clsconfig As New clsConfig


        mfg_production_lots.mfg_production_lots_id = Nothing
        mfg_production_lots.system_lot_number = String.Empty
        mfg_production_lots.custom_lot_number = Nothing
        mfg_production_lots.inventory_item_code = KO.design_no
        mfg_production_lots.lot_delivered_to_inventory = Nothing
        mfg_production_lots.production_order_id = KO.production_order_id
        mfg_production_lots.production_order_no = KO.kono
        mfg_production_lots.primary_quantity = Nothing
        mfg_production_lots.secondary_quantity = Nothing
        mfg_production_lots.created_by = clsuser.UserID
        mfg_production_lots.creation_date = Now
        mfg_production_lots.last_modified_by = clsuser.UserID
        mfg_production_lots.last_modified_date = Now
        mfg_production_lots.mfg_production_steps_id = Nothing
        'mfg_production_lots.mfg_production_steps_id = clsconfig.IsNull(grdDataRouting.CurrentRow.Cells("mfg_production_steps_id").Value, Nothing)
        mfg_production_lots.lot_grade = Nothing
        mfg_production_lots.qc_remarks = Nothing

        mfg_production_lots.message = Nothing

        Dim dtproduction_lots As DataTable = grdDataLots.DataSource
        For i = 0 To dtproduction_lots.Rows.Count - 1
            With dtproduction_lots.Rows
                ' 'Has Bugs Deleted Rows
                'If dtproduction_lots.Rows(i)("inventory_item_code").ToString.Trim <> mfg_production_lots.inventory_item_code.Trim Then
                'dtproduction_lots.Rows(i)("inventory_item_code") = mfg_production_lots.inventory_item_code.Trim
                'End If

            End With
        Next
        'mfg_production_lots.mfg_production_steps_id = grdDataRouting.CurrentRow.Cells("mfg_production_steps_id").Value

        Dim dv_add As New DataView(dtproduction_lots, "", "", DataViewRowState.Added)
        Dim dv_upd As New DataView(dtproduction_lots, "", "", DataViewRowState.ModifiedCurrent)
        Dim dv_del As New DataView(dtproduction_lots, "", "", DataViewRowState.Deleted)

        Dim dv_yarn_in_add As New DataView
        Dim dv_yarn_in_upd As New DataView
        Dim dv_yarn_in_del As New DataView
        'Dim dtDefect As DataTable = grdDefect.DataSource

        Dim dv_dtDefect_add As New DataView '(grdDefect.DataSource, "", "", DataViewRowState.Added)
        Dim dv_dtDefect_upd As New DataView '(grdDefect.DataSource, "", "", DataViewRowState.ModifiedCurrent)
        Dim dv_dtDefect_del As New DataView '(grdDefect.DataSource, "", "", DataViewRowState.Deleted)

        'Dim result As Windows.Forms.DialogResult
        'result = MessageBox.Show("Would You Like To Save Lots ?", "System Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button3)
        'If result = Windows.Forms.DialogResult.No Then Exit Function

        If classProductionLots.SavaData(mfg_production_lots:=mfg_production_lots, Defect_Roll_Header:=Defect_Roll_Header, dv_add:=dv_add, dv_upd:=dv_upd, dv_del:=dv_del, dv_yarn_in_add:=dv_yarn_in_add, dv_yarn_in_upd:=dv_yarn_in_upd, dv_yarn_in_del:=dv_yarn_in_del, dv_dtDefect_add:=dv_dtDefect_add, dv_dtDefect_upd:=dv_dtDefect_upd, dv_dtDefect_del:=dv_dtDefect_del, clsuser:=clsuser) Then
            'MessageBox.Show("บันทึกสำเร็จ", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
            LoadDataLots(Intmfg_production_steps_id:=mfg_production_lots.mfg_production_steps_id, Strproduction_order_no:=mfg_production_lots.production_order_no)
            LoadDataRouting(Intmfg_production_steps_id:=Nothing, Strproduction_order_no:=txtProdNo.Text.Trim)
            Return True
        Else
            MessageBox.Show(mfg_production_lots.message, "System Message", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
            Return False
        End If
    End Function


    Private Sub grdDataRouting_CellContentClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles grdDataRouting.CellContentClick

    End Sub

    Private Sub grdDataRouting_CellDoubleClick(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles grdDataRouting.CellDoubleClick
        Dim clsconfig As New clsConfig

        If e.RowIndex >= 0 AndAlso e.ColumnIndex >= 0 Then
            Dim selectedRow = grdDataRouting.Rows(e.RowIndex)

            mfg_production_lots.mfg_production_steps_id = clsconfig.IsNull(grdDataRouting.Rows(e.RowIndex).Cells("mfg_production_steps_id").Value, Nothing)

        End If
    End Sub

    Private Sub BtnGenLots_Click(sender As System.Object, e As System.EventArgs) Handles BtnGenLots.Click
        'Dim dtgv As New DataGridView
        'dtgv = grdDataRouting.DataSource
        Dim clsConfig As New clsConfig




        Dim dt As New DataTable

        If grdDataRouting.Rows.Count = 0 Then Exit Sub
        'TabControl1.TabPages.Add(TPlots)
        If clsConfig.IsNull(grdDataRouting.CurrentRow.Cells("mfg_production_steps_id").Value, 0) = 0 Then
            Exit Sub
        End If
        If Not CheckKO() Then Exit Sub

        'If grdDataRouting.CurrentRow.ToString >= 0 AndAlso grdDataRouting.CurrentRow.ToString >= 0 Then
        'Dim selectedRow = grdDataRouting.Rows(d.RowIndex)
        If grdDataLots.Rows.Count > 0 Then
            SaveDataLots()
        Else
            GenDataLots()
        End If

        'If GenDataLots() Then

        'Else

        'End If

        'grdDataRouting.Rows(d.RowIndex).Cells("mfg_production_steps_id").Value
        'End If

    End Sub

    Private Function CheckKO() As Boolean
        Dim clsconfig As New clsConfig


        If clsconfig.IsNull(KO.daily_capacity_kg, 0) = 0 Then
            MessageBox.Show("Daily Capacity Kg is Zero Please Check", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
            Return False
        End If

        If clsconfig.IsNull(KO.roll_kgs_std, 0) = 0 Then
            MessageBox.Show("Rolls Kgs Std. is Zero Please Check", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
            Return False
        End If

        Return True

    End Function

    Private Sub btnDirectPrint_Click(sender As System.Object, e As System.EventArgs) Handles btnDirectPrint.Click
        PreviewPrint()
    End Sub

    Private Function PreviewPrint() As Boolean
        Dim clsConfig As New clsConfig
        Dim rptFileName = "rptLotsBarcode.rpt"
        Dim clsConn As New classConnection
        'If clsuser.ReportPath = "" Then clsuser.ReportPath = clsConfig.ReportPath
        'clsUser.ReportPath = "C:\Users\DELL\Desktop\GemmaKnits\"
        If Not clsConfig.CheckReport(clsuser.ReportPath, rptFileName) Then Exit Function
        Dim frm As New frmReport
        Dim rpt As New CrystalDecisions.CrystalReports.Engine.ReportDocument
        Dim stype As String = ""
        Dim ord As String = ""
        Me.Cursor = Cursors.WaitCursor

        rpt.Load(clsuser.ReportPath & rptFileName)
        rpt.DataSourceConnections.Item(0).SetConnection(clsConn.servername, clsConn.database, False)
        rpt.DataSourceConnections.Item(0).SetLogon(clsConn.Userid, clsConn.Password)
        rpt.VerifyDatabase()
        rpt.SetParameterValue("@production_order_no", txtProdNo.Text)
        'rpt.SetParameterValue("@loc", txtloc.Text)
        rpt.SetParameterValue("@logempcd", UserInfo.UserID)

        'rpt.PrintOptions.PaperSize = CrystalDecisions.Shared.PaperSize.PaperLetter
        'rpt.PrintOptions.PaperOrientation = CrystalDecisions.Shared.PaperOrientation.Portrait
        'rpt.PrintOptions.PaperSource = CrystalDecisions.Shared.PaperSource.Auto

        frm.Title = "Greige Barcode"
        frm.CRViewer.ReportSource = rpt
        frm.MdiParent = Me.ParentForm
        frm.Show()
        Me.Cursor = Cursors.Default

        PreviewPrint = True
    End Function

    Private Sub txtrouting_code_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles txtrouting_code.KeyDown
        If e.KeyCode = Keys.Enter Then

            If Validate_routing_code(txtrouting_code.Text) Then
                GetRouting()
            Else
                GetRouting()
            End If

        End If
    End Sub

    Private Function Validate_routing_code(Optional ByVal Strrouting_code As String = "") As Boolean
        Dim objdb As New classProductionRouting
        Dim dt As DataTable = objdb.GetRoutingMaster(Nothing, Nothing, Strrouting_code)

        If dt.Rows.Count = 0 Then
            MessageBox.Show("Routing Code No .: " & Strrouting_code & "............   is Not Correct!!", "SyStem Messsage", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return False
        Else
            Return True
        End If


    End Function


    Private Sub txtrouting_code_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtrouting_code.TextChanged

    End Sub

    Private Sub btnCopyStep_Click(sender As System.Object, e As System.EventArgs) Handles btnCopyStep.Click
        Dim result As DialogResult
        result = MessageBox.Show("Would You Like To Copy Steps ?", "System Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button3)
        If result = DialogResult.No Then Exit Sub
        Call GetCopyStep()
    End Sub

    Private Function GetCopyStep() As Boolean

        Dim dtc As DataTable = grdDataRouting.DataSource
        Dim StrStep_number As String '= grdDataRouting.CurrentRow.Cells("step_number").Value
        Dim Stroperation_id As Integer
        'AutoGenStepNo(grdDataRouting.CurrentRow.Cells("step_number").Value)

        Dim newRow As DataRow
        If grdDataRouting.Rows.Count > 0 Then

            StrStep_number = grdDataRouting.CurrentRow.Cells("step_number").Value
            Stroperation_id = grdDataRouting.CurrentRow.Cells("operation_id").Value

            AutoGenStepNo(StrStep_number, Stroperation_id)

            newRow = dtc.NewRow

            newRow.Item("mfg_production_steps_id") = grdDataRouting.CurrentRow.Cells("mfg_production_steps_id").Value
            newRow.Item("routing_id") = grdDataRouting.CurrentRow.Cells("routing_id").Value
            newRow.Item("operation_id") = grdDataRouting.CurrentRow.Cells("operation_id").Value
            'newRow.Item("step_number") = grdDataRouting.CurrentRow.Cells("step_number").Value + 1
            newRow.Item("step_number") = StrStep_number
            newRow.Item("step_name") = grdDataRouting.CurrentRow.Cells("step_name").Value
            newRow.Item("plan_start_date") = grdDataRouting.CurrentRow.Cells("plan_start_date").Value
            newRow.Item("plan_end_date") = grdDataRouting.CurrentRow.Cells("plan_end_date").Value
            newRow.Item("plan_step_qty") = grdDataRouting.CurrentRow.Cells("plan_step_qty").Value
            'newRow.Item("actual_start_date") = grdDataRouting.CurrentRow.Cells("actual_start_date").Value
            'newRow.Item("actual_end_date") = grdDataRouting.CurrentRow.Cells("actual_end_date").Value
            'newRow.Item("actual_step_qty") = grdDataRouting.CurrentRow.Cells("actual_step_qty").Value
            newRow.Item("mcno") = grdDataRouting.CurrentRow.Cells("cbomcno").Value
            newRow.Item("operator") = grdDataRouting.CurrentRow.Cells("cbooperator").Value
            newRow.Item("work_shift") = grdDataRouting.CurrentRow.Cells("work_shift").Value
            'newRow.Item("step_status") = grdDataRouting.CurrentRow.Cells("cbostep_status").Value
            'newRow.Item("cbostep_status") = grdDataRouting.CurrentRow.Cells("cbostep_status").Value
            newRow.Item("step_remarks") = grdDataRouting.CurrentRow.Cells("step_remarks").Value

            dtc.Rows.Add(newRow)

            Return True
        End If

        Return False

    End Function
    Private Structure cell
        Dim rowIndex As Integer
        Dim columnIndex As Integer
    End Structure
    Private Sub AutoGenStepNo(ByRef Intstep_number As String, ByVal Intoperation_id As Integer)
        'Dim dtc As DataTable = grdDataRouting.DataSource
        'Dim step_number As Integer = 0
        ' grdDataRouting.CurrentRow.Cells("step_number")
        'Intstep_number = grdDataRouting.CurrentRow.Cells("step_number").Value

        Dim Max As Integer = 0

        For Each rws As DataGridViewRow In grdDataRouting.Rows
            If Max < rws.Cells("step_number").Value And rws.Cells("operation_id").Value = Intoperation_id Then
                Max = rws.Cells("step_number").Value
            End If

        Next

        Intstep_number = Max.ToString + 1

        '    For i = 0 To grdDataRouting.Rows.Count - 1
        '        If grdDataRouting.Rows(i).Cells("step_number").Value.ToString.Trim = Intstep_number.Trim And grdDataRouting.Rows(i).Cells("step_number").Value = Intoperation_id Then
        '            Intstep_number = Intstep_number + 1

        ''If grdDataRouting.Rows(i).Cells("step_number").Value = Intstep_number Then
        ''Intstep_number = Intstep_number + 1
        ''End If

        '        End If

        '    Next


    End Sub
    Private Sub moveNext()

        Dim curRecIdx As Integer = grdDataRouting.CurrentRow.Index()

        'ข้างบนคือ เราใช้คำสั้ง get ค่า Indexของ Row(record) ปัจจุบัน ของ Datagridview

        Dim nextRecIdx As Integer



        'ด้านล่างตรวจว่า Recordปัจจุบันนั้น คือ Record สุดท้ายหรือไม่

        If curRecIdx < grdDataRouting.Rows.Count() - 1 Then

            'ถ้าไม่ใช่ให้ทำดังนี้ (ไม่ใช่ก็ไม่ต้องทำอะไร ก็มิมีแถวให้เลื่อนต่อแล้วนิ จะเลื่อนไปทำไม)

            nextRecIdx = curRecIdx + 1

            'คำสั่งข้างบนคือการ เพิ่มค่า Row Index อีก 1 ก็จะได้ค่าของ Row Index ของ Record ถัดไปครับ



            grdDataRouting.CurrentCell = grdDataRouting.Item(0, nextRecIdx)

            'ตรงคือ เราสั่งให้โปรแกรม Select Cell (field) Column ที่ 1 (เลขIndex คือ 0) และแถวถัดไป



        End If

    End Sub
    Private Sub moveLastRec()

        Dim RecCount As Integer = grdDataRouting.Rows.Count() - 1

        'Record Index จะนับเริ่มจาก 0 พอเรา Count Record แล้วต้องทอนเลขลงมา 1 ครับ

        'คือ ถ้ามีdata 4 Record คำสั่ง count จะนับจำนวนRecord ได้ 4

        'แล้วจะเลื่อนไปที่Record 4(สุดท้าย)  ถ้านับหา Index ก็คือ เริ่มจาก 0,1,2 และ 3 

        'จะได้ Index เป็น 3 ครับ



        grdDataRouting.CurrentCell = grdDataRouting.Item(0, RecCount)

        'ตรงคือ เราสั่งให้โปรแกรม Select Cell (field) Column ที่ 1 (เลขIndex คือ 0)

        'และ Row สุดท้าย ตาม ตัวอย่างคือ 4 (เลขIndex คือ 3)

    End Sub
    Private Sub down()
        Dim currentRowIndex As Integer = grdDataRouting.CurrentRow.Index


        If currentRowIndex < grdDataRouting.Rows.Count Then
            Dim tempValue As String = grdDataRouting.Rows(currentRowIndex - 1).Cells(0).Value
            grdDataRouting.Rows(currentRowIndex + 1).Cells(0).Value = grdDataRouting.Rows(currentRowIndex).Cells(0).Value
            grdDataRouting.Rows(currentRowIndex).Cells(0).Value = tempValue

        End If


    End Sub


    Private Sub BtnDeleteStep_Click(sender As System.Object, e As System.EventArgs) Handles BtnDeleteStep.Click
        Dim result As DialogResult
        result = MessageBox.Show("Would You Like To Delete Steps ?", "System Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button3)
        If result = DialogResult.No Then Exit Sub
        GetDeleteStep()
    End Sub
    Private Sub GetDeleteStep()

        For Each row As DataGridViewRow In grdDataRouting.SelectedRows
            grdDataRouting.Rows.Remove(row)
        Next
    End Sub

    Private Sub BtnUP_Click(sender As System.Object, e As System.EventArgs) Handles BtnUPStep.Click
        swapRows(mode.up)
    End Sub



    Private Sub swapRows(ByVal range As mode)
        'Dim DataGridView As DataGridView = grdDataRouting
        Dim iSelectedRow As Integer = -1
        For iTmp As Integer = 0 To grdDataRouting.Rows.Count - 1
            If grdDataRouting.Rows(iTmp).Selected Then
                iSelectedRow = iTmp
                Exit For
            End If
        Next

        If iSelectedRow <> -1 Then
            'Dim sTmp(4) As String
            Dim sTmp(grdDataRouting.Columns.Count) As String
            For iTmp As Integer = 0 To grdDataRouting.Columns.Count - 1
                sTmp(iTmp) = grdDataRouting.Rows(iSelectedRow).Cells(iTmp).Value.ToString
            Next

            Dim iNewRow As Integer
            If range = mode.down Then
                iNewRow = iSelectedRow + 1
            ElseIf range = mode.up Then
                iNewRow = iSelectedRow - 1
            End If

            If range = mode.up Or range = mode.down Then
                For iTmp As Integer = 0 To grdDataRouting.Columns.Count - 1
                    grdDataRouting.Rows(iSelectedRow).Cells(iTmp).Value = grdDataRouting.Rows(iNewRow).Cells(iTmp).Value
                    grdDataRouting.Rows(iNewRow).Cells(iTmp).Value = sTmp(iTmp)
                Next
                toSelect(iNewRow)
            ElseIf range = mode.top Or range = mode.bottom Then
                reshuffleRows(sTmp, iSelectedRow, range)
            End If
        End If
    End Sub


    Private Sub toSelect(ByVal iNewRow As Integer)
        ' Dim DataGridView As DataGridView = grdDataRouting
        grdDataRouting.Rows(iNewRow).Selected = True
    End Sub

    Enum mode
        top = 0
        up = 1
        down = 2
        bottom = 3
    End Enum

    Private Sub reshuffleRows(ByVal sTmp() As String, ByVal iSelectedRow As Integer, ByVal Range As mode)
        'Dim DataGridView As DataGridView = grdDataRouting


        If Range = mode.top Then
            Dim iFirstRow As Integer = 0
            If iSelectedRow > iFirstRow Then
                For iTmp As Integer = iSelectedRow To 1 Step -1
                    For iCol As Integer = 0 To grdDataRouting.Columns.Count - 1
                        grdDataRouting.Rows(iTmp).Cells(iCol).Value = grdDataRouting.Rows(iTmp - 1).Cells(iCol).Value
                    Next
                Next
                For iCol As Integer = 0 To grdDataRouting.Columns.Count - 1
                    grdDataRouting.Rows(iFirstRow).Cells(iCol).Value = sTmp(iCol).ToString
                Next
                toSelect(iFirstRow)
            End If
        Else
            Dim iLastRow As Integer = grdDataRouting.Rows.Count - 1
            If iSelectedRow < iLastRow Then
                For iTmp As Integer = iSelectedRow To iLastRow - 1
                    For iCol As Integer = 0 To grdDataRouting.Columns.Count - 1
                        grdDataRouting.Rows(iTmp).Cells(iCol).Value = grdDataRouting.Rows(iTmp + 1).Cells(iCol).Value
                    Next
                Next
                For iCol As Integer = 0 To grdDataRouting.Columns.Count - 1
                    grdDataRouting.Rows(iLastRow).Cells(iCol).Value = sTmp(iCol).ToString
                Next
                toSelect(iLastRow)
            End If
        End If
    End Sub

    Private Sub btnPrintSticker_Click(sender As System.Object, e As System.EventArgs) Handles btnPrintSticker.Click
        PrintSystemLotNumber()
    End Sub

    Private Sub BtnPrintList_Click(sender As System.Object, e As System.EventArgs) Handles BtnPrintList.Click
        PrintList()
    End Sub

    Private Sub PrintSystemLotNumber()
        Dim clsConfig As New clsConfig
        Dim rptFileName = "rptSystemLotNumberBeam.rpt"  'rptSystemLotNumberBeam2Lbl.rpt
        'If clsuser.ReportPath = "" Then clsuser.ReportPath = clsConfig.ReportPath
        'clsUser.ReportPath = "C:\Users\DELL\Desktop\GemmaKnits\"
        If Not clsConfig.CheckReport(clsuser.ReportPath, rptFileName) Then Exit Sub
        Dim frm As New frmReport
        Dim rpt As New CrystalDecisions.CrystalReports.Engine.ReportDocument
        Dim stype As String = ""
        Dim ord As String = ""
        Me.Cursor = Cursors.WaitCursor

        rpt.Load(clsuser.ReportPath & rptFileName)
        rpt.DataSourceConnections.Item(0).SetConnection(clsConn.servername, clsConn.database, False)
        rpt.DataSourceConnections.Item(0).SetLogon(clsConn.Userid, clsConn.Password)
        rpt.VerifyDatabase()
        rpt.SetParameterValue("@system_lot_number", clsConfig.IsNull(grdDataLots.CurrentRow.Cells("system_lot_number").Value, ""))
        rpt.SetParameterValue("@production_order_no", "")
        rpt.SetParameterValue("@mfg_production_steps_id", 0)
        rpt.SetParameterValue("@lotno_our", clsConfig.IsNull(grdDataLots.CurrentRow.Cells("lotno_our").Value, ""))
        rpt.SetParameterValue("@logempcd", UserInfo.UserID)

        frm.Title = "Barcode"
        frm.CRViewer.ReportSource = rpt
        frm.MdiParent = Me.ParentForm
        frm.Show()
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub PrintList()
        Dim clsConfig As New clsConfig
        Dim rptFileName = "rptSystemLotNumberBeam.rpt"
        'If clsuser.ReportPath = "" Then clsuser.ReportPath = clsConfig.ReportPath
        'clsUser.ReportPath = "C:\Users\DELL\Desktop\GemmaKnits\"
        If Not clsConfig.CheckReport(clsuser.ReportPath, rptFileName) Then Exit Sub
        Dim frm As New frmReport
        Dim rpt As New CrystalDecisions.CrystalReports.Engine.ReportDocument
        Dim stype As String = ""
        Dim ord As String = ""
        Me.Cursor = Cursors.WaitCursor

        rpt.Load(clsuser.ReportPath & rptFileName)
        rpt.DataSourceConnections.Item(0).SetConnection(clsConn.servername, clsConn.database, False)
        rpt.DataSourceConnections.Item(0).SetLogon(clsConn.Userid, clsConn.Password)
        rpt.VerifyDatabase()
        rpt.SetParameterValue("@system_lot_number", "")
        rpt.SetParameterValue("@production_order_no", txtProdNo.Text.Trim)
        rpt.SetParameterValue("@mfg_production_steps_id", Nothing)
        rpt.SetParameterValue("@logempcd", UserInfo.UserID)
        rpt.SetParameterValue("@lotno_our", "")

        frm.Title = "All Barcode"
        frm.CRViewer.ReportSource = rpt
        frm.MdiParent = Me.ParentForm
        frm.Show()
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub btnViewRolls_Click(sender As System.Object, e As System.EventArgs) Handles btnViewRolls.Click

        Dim clsConfig As New clsConfig
        Dim dt As New DataTable

        If grdDataRouting.Rows.Count = 0 Then
            MessageBox.Show("ไม่พอข้อมูล Routing", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Stop, MessageBoxDefaultButton.Button1)
            Exit Sub
        End If
        If clsConfig.IsNull(grdDataRouting.CurrentRow.Cells("mfg_production_steps_id").Value, 0) = 0 Then
            MessageBox.Show("ไม่พบข้อมูล Routing ต้องทำการบันทึก Production Routing ก่อนครับ", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button3)

            Exit Sub
        End If
        If Not CheckKO() Then Exit Sub

        'Dim frm As New frmGenWarpSet
        'frm.ShowDialog(Me)

        If Not GenDataLots() Then Exit Sub

        If grdDataLots.Rows.Count > 0 Then TabControl1.SelectedTab = TPlots

        'If grdDataLots.Rows.Count > 0 Then
        '    SaveDataLots()
        '    TabControl1.SelectedTab = TPlots
        'Else
        '    If Not GenDataLots() Then Exit Sub
        '    Call SaveDataLots()
        '    TabControl1.SelectedTab = TPlots
        'End If


    End Sub

    Private Function Validate_mfg_production_steps_id(Optional ByVal Intmfg_production_steps_id As Nullable(Of Int32) = Nothing) As Boolean
        Dim objdb As New classProductionRouting
        Dim dt As DataTable = objdb.Validate_mfg_production_steps_id(Intmfg_production_steps_id, clsuser.UserID)
        If dt.Rows.Count = 0 Then
            MessageBox.Show("KO No .: " & Intmfg_production_steps_id.ToString & "............   is Not Correct!!", "SyStem Messsage", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return False
        Else
            Return True
        End If
    End Function

    Private Sub btnScanRolls_Click(sender As System.Object, e As System.EventArgs) Handles btnScanRolls.Click
        If grdDataRouting.Rows.Count = 0 Then
            MessageBox.Show("ไม่พอข้อมูล Routing", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Stop, MessageBoxDefaultButton.Button1)
            Exit Sub
        End If

        If grdDataLots.Rows.Count = 0 Then
            MessageBox.Show("ไม่พอข้อมูล ม้วน", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Stop, MessageBoxDefaultButton.Button1)
            Exit Sub
        End If

        mfg_production_lots.mfg_production_steps_id = grdDataRouting.CurrentRow.Cells("mfg_production_steps_id").Value
        mfg_production_lots.production_order_no = txtProdNo.Text

        Dim frm As New frmProductionLotsIndex
        frm.Title = grdDataRouting.CurrentRow.Cells("step_name").Value.ToString
        frm.p_mfg_production_lots = mfg_production_lots
        frm.UserInfo = clsuser
        frm.MdiParent = Me.ParentForm
        'Me.Close()
        frm.Show()

    End Sub

    Private Sub BtnDown_Click(sender As System.Object, e As System.EventArgs) Handles BtnDownStep.Click
        swapRows(mode.down)
    End Sub

    Private Sub btnSearch_Click(sender As System.Object, e As System.EventArgs) Handles btnSearch.Click

    End Sub

    Private Sub btnNewStep_Click(sender As System.Object, e As System.EventArgs) Handles btnNewStep.Click
        GetNewStep()



        'grdDataRouting.Rows.Insert(rowPosition, New String() {value1, value2, value3})

        'grdDataRouting.Rows.Add("five", "six", "seven", "eight")
        'NewRow(grdDataRouting)
    End Sub

    Private Sub NewRow(ByVal dataGridview As DataGridView)
        'Dim datagridview As DataGridView

        Dim row1() As String = {"", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", ""}
        'Dim row2() As String = _
        '    {"Key Lime Pie", "Dessert", "lime juice, evaporated milk", "****"}
        ' Dim row3() As String = {"Orange-Salsa Pork Chops", "Main Dish", _
        '    "pork chops, salsa, orange juice", "****"}
        ' Dim row4() As String = {"Black Bean and Rice Salad", "Salad", _
        '      "black beans, brown rice", "****"}
        ' Dim row5() As String = _
        '     {"Chocolate Cheesecake", "Dessert", "cream cheese", "***"}
        ' Dim row6() As String = _
        '     {"Black Bean Dip", "Appetizer", "black beans, sour cream", "***"}

        dataGridview.Rows.Add("five", "six", "seven", "eight")

        'Dim rows() As Object = {row1}

        ' Dim rowArray As String()
        'For Each rowArray In rows
        'dataGridview.Rows.Add(rowArray)
        'Next rowArray
    End Sub

    Private Function GetNewStep() As Boolean

        Dim dtc As DataTable = grdDataRouting.DataSource

        Dim newRow As DataRow
        'If grdDataRouting.Rows.Count > 0 Then

        newRow = dtc.NewRow

        'newRow.Item("mfg_production_steps_id") = Nothing
        'newRow.Item("routing_id") = Nothing
        'newRow.Item("operation_id") = Nothing
        'newRow.Item("step_number") = Nothing
        'newRow.Item("step_name") = Nothing
        'newRow.Item("plan_start_date") = Nothing
        'newRow.Item("plan_end_date") = Nothing
        'newRow.Item("plan_step_qty") = Nothing
        'newRow.Item("actual_start_date") = Nothing
        'newRow.Item("actual_end_date") = Nothing
        'newRow.Item("actual_step_qty") = Nothing
        'newRow.Item("mcno") = Nothing
        'newRow.Item("operator") = Nothing
        'newRow.Item("work_shift") = Nothing
        'newRow.Item("step_status") = Nothing
        'newRow.Item("step_remarks") = Nothing

        dtc.Rows.Add(newRow)

        'Return True
        'End If

        'Return False

    End Function

    Private Sub btnExit_Click(sender As System.Object, e As System.EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnMinimized_Click(sender As System.Object, e As System.EventArgs) Handles btnMinimized.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub SumgrdDataLots()

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
        'Sitthana 12/07/2018 For YIN
        Dim YINSumRolls As Byte = 0
        Dim YinSumBeamTotalWeight As Double = 0

        For i = 0 To grdDataLots.Rows.Count - 1
            dblKgs = dblKgs + config.IsNull(grdDataLots.Rows(i).Cells("primary_quantity").Value, 0)
            dblMts = dblMts + config.IsNull(grdDataLots.Rows(i).Cells("secondary_quantity").Value, 0)
            If grdDataLots.Rows(i).Cells("docno").Value.ToString.Trim <> "" Then
                YINSumRolls += 1
                YinSumBeamTotalWeight += config.IsNull(grdDataLots.Rows(i).Cells("beam_total_weight").Value, 0)
            End If 'Sitthana 12/07/2018 For YIN
        Next

        txtSumRolls.Text = FormatNumber(grdDataLots.Rows.Count, 0, TriState.False, TriState.False, TriState.True)
        txtSumprimary_Quantity.Text = FormatNumber(dblKgs, 2, TriState.False, TriState.False, TriState.True)
        txtSumSecondary_Quantity.Text = FormatNumber(dblMts, 2, TriState.False, TriState.False, TriState.True)

        'Sitthana 12/07/2018 For YIN
        txtYINSumRolls.Text = YINSumRolls
        txtSumBeamTotalWeight.Text = YinSumBeamTotalWeight
    End Sub



    Private Sub grdDataLots_CellContentClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles grdDataLots.CellContentClick

    End Sub

    Private Sub grdDataLots_CellEndEdit(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles grdDataLots.CellEndEdit
        Dim clsconfig As New clsConfig
        If grdDataLots.Columns(e.ColumnIndex).Name = "bobbin_weight_before" Or grdDataLots.Columns(e.ColumnIndex).Name = "bobbin_weight_after" Then
            If clsconfig.IsNull(grdDataLots.Rows(e.RowIndex).Cells("bobbin_weight_before").Value, 0) > 0 And clsconfig.IsNull(grdDataLots.Rows(e.RowIndex).Cells("bobbin_weight_after").Value, 0) > 0 Then
                grdDataLots.Rows(e.RowIndex).Cells("bobbin_tear_weight").Value = grdDataLots.Rows(e.RowIndex).Cells("bobbin_weight_before").Value - grdDataLots.Rows(e.RowIndex).Cells("bobbin_weight_after").Value
                grdDataLots.Rows(e.RowIndex).Cells("beam_tear_weight").Value = (grdDataLots.Rows(e.RowIndex).Cells("bobbin_tear_weight").Value * grdDataLots.Rows(e.RowIndex).Cells("warped_ends").Value) / grdDataLots.Rows(e.RowIndex).Cells("beams_per_set").Value
                grdDataLots.Rows(e.RowIndex).Cells("beam_total_weight").Value = (grdDataLots.Rows(e.RowIndex).Cells("bobbin_tear_weight").Value * grdDataLots.Rows(e.RowIndex).Cells("warped_ends").Value)
            End If

        End If

        Call SumgrdDataLots()
    End Sub

    Private Sub grdDataLots_CellValueChanged(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles grdDataLots.CellValueChanged
        Call SumgrdDataLots()
    End Sub

    Private Sub grdDataLots_CurrentCellDirtyStateChanged(sender As Object, e As System.EventArgs) Handles grdDataLots.CurrentCellDirtyStateChanged
        'If grdDataLots.IsCurrentCellDirty Then
        'grdDataLots.CommitEdit(DataGridViewDataErrorContexts.Commit)
        'End If
    End Sub

    Private Sub grdDataLots_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles grdDataLots.KeyDown
        If e.KeyCode = Keys.Delete Then

            Call SumgrdDataLots()
        End If
    End Sub

    Private Sub btnnewlot_Click(sender As System.Object, e As System.EventArgs) Handles btnnewroll.Click
        GetNewLot()
    End Sub

    Private Function GetNewLot() As Boolean

        Dim dtc As DataTable = grdDataLots.DataSource

        Dim newRow As DataRow
        'If grdDataRouting.Rows.Count > 0 Then

        newRow = dtc.NewRow

        'newRow.Item("mfg_production_steps_id") = Nothing
        'newRow.Item("routing_id") = Nothing
        'newRow.Item("operation_id") = Nothing
        'newRow.Item("step_number") = Nothing
        'newRow.Item("step_name") = Nothing
        'newRow.Item("plan_start_date") = Nothing
        'newRow.Item("plan_end_date") = Nothing
        'newRow.Item("plan_step_qty") = Nothing
        'newRow.Item("actual_start_date") = Nothing
        'newRow.Item("actual_end_date") = Nothing
        'newRow.Item("actual_step_qty") = Nothing
        'newRow.Item("mcno") = Nothing
        'newRow.Item("operator") = Nothing
        'newRow.Item("work_shift") = Nothing
        'newRow.Item("step_status") = Nothing
        'newRow.Item("step_remarks") = Nothing
        newRow.Item("inventory_item_code") = KOdata.design_no
        'newRow.Item("lot_delivered_to_inventory") = KOdata
        newRow.Item("production_order_no") = KOdata.kono
        newRow.Item("mfg_production_order_lines_id") = MfgProductionOrderLinesData.MfgProductionOrderLinesId
        dtc.Rows.Add(newRow)

        'Return True
        'End If

        'Return False

    End Function

    Private Sub btnCopylot_Click(sender As System.Object, e As System.EventArgs) Handles btnCopyRoll.Click
        GetCopyLot()
    End Sub

    Private Function GetCopyLot() As Boolean

        Dim dtc As DataTable = grdDataLots.DataSource

        Dim newRow As DataRow
        If grdDataLots.Rows.Count > 0 Then

            newRow = dtc.NewRow

            'newRow.Item("system_lot_number") = grdDataLots.CurrentRow.Cells("system_lot_number").Value
            'newRow.Item("custom_lot_number") = grdDataLots.CurrentRow.Cells("custom_lot_number").Value
            newRow.Item("inventory_item_code") = grdDataLots.CurrentRow.Cells("inventory_item_code").Value
            newRow.Item("lot_delivered_to_inventory") = grdDataLots.CurrentRow.Cells("lot_delivered_to_inventory").Value
            newRow.Item("production_order_no") = grdDataLots.CurrentRow.Cells("production_order_no").Value
            newRow.Item("primary_quantity") = grdDataLots.CurrentRow.Cells("primary_quantity").Value
            newRow.Item("secondary_quantity") = grdDataLots.CurrentRow.Cells("secondary_quantity").Value
            'newRow.Item("created_by") = grdDataLots.CurrentRow.Cells("created_by").Value
            'newRow.Item("creation_date") = grdDataLots.CurrentRow.Cells("creation_date").Value
            'newRow.Item("last_modified_by") = grdDataLots.CurrentRow.Cells("last_modified_by").Value
            'newRow.Item("last_modified_date") = grdDataLots.CurrentRow.Cells("last_modified_date").Value
            'newRow.Item("mfg_production_steps_id") = grdDataLots.CurrentRow.Cells("mfg_production_steps_id").Value
            newRow.Item("lot_grade") = grdDataLots.CurrentRow.Cells("lot_grade").Value
            newRow.Item("qc_remarks") = grdDataLots.CurrentRow.Cells("qc_remarks").Value
            'newRow.Item("mtl_warehouse_id") = grdDataLots.CurrentRow.Cells("mtl_warehouse_id").Value
            'newRow.Item("mtl_locations_id") = grdDataLots.CurrentRow.Cells("mtl_locations_id").Value
            'newRow.Item("steam_condition") = grdDataLots.CurrentRow.Cells("steam_condition").Value
            'newRow.Item("steam_date") = grdDataLots.CurrentRow.Cells("steam_date").Value
            'newRow.Item("steam_time") = grdDataLots.CurrentRow.Cells("steam_time").Value
            'newRow.Item("operator_lot_number") = grdDataLots.CurrentRow.Cells("operator_lot_number").Value

            dtc.Rows.Add(newRow)

            Return True
        End If

        Return False

    End Function

    Private Sub btnDelLot_Click(sender As System.Object, e As System.EventArgs) Handles btnDelRoll.Click
        Dim result As DialogResult
        result = MessageBox.Show("Would You Like To Delete Lot ?", "System Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button3)
        If result = DialogResult.No Then Exit Sub
        GetDeleteLot()
    End Sub

    Private Sub GetDeleteLot()

        For Each row As DataGridViewRow In grdDataLots.SelectedRows
            grdDataLots.Rows.Remove(row)
        Next
    End Sub

    'Private Sub InitializeMyContextMenu()
    '    ' Create the contextMenu and the MenuItem to add.
    '    Dim contextMenu1 As New ContextMenu()
    '    Dim menuItem1 As New MenuItem("&Cut")
    '    Dim menuItem2 As New MenuItem("&Copy")
    '    Dim menuItem3 As New MenuItem("&Paste")

    '    ' Use the MenuItems property to call the Add method
    '    ' to add the MenuItem to the MainMenu menu item collection. 
    '    contextMenu1.MenuItems.Add(menuItem1)
    '    contextMenu1.MenuItems.Add(menuItem2)
    '    contextMenu1.MenuItems.Add(menuItem3)

    '    ' Assign mainMenu1 to the rich text box.
    '    grdDataLots.ContextMenu = contextMenu1
    'End Sub

    Private Sub btnPrint_Click(sender As System.Object, e As System.EventArgs) Handles btnPrint.Click
        Const rptFileName = "rptWO.rpt"
        'If clsuser.ReportPath = "" Then clsuser.ReportPath = clsConfig.ReportPath
        Dim ko_type As String = "" ' IIf(optKI.Checked, 1, IIf(optKO.Checked, 2, IIf(optKP.Checked, 3, IIf(optKC.Checked, 4, 5))))
        ko_type = KOdata.ko_type
        Dim config As New clsConfig
        If Not config.CheckReport(clsuser.ReportPath, rptFileName) Then Exit Sub
        Dim frm As New frmReport
        Dim rpt As New CrystalDecisions.CrystalReports.Engine.ReportDocument
        Dim stype As String = ""
        Dim ord As String = ""
        Me.Cursor = Cursors.WaitCursor

        rpt.Load(clsuser.ReportPath & rptFileName)
        rpt.DataSourceConnections.Item(0).SetConnection(clsConn.servername, clsConn.database, False)
        rpt.DataSourceConnections.Item(0).SetLogon(clsConn.Userid, clsConn.Password)
        rpt.VerifyDatabase()
        rpt.SetParameterValue("@kono", txtProdNo.Text.Trim)
        'Add by Neung 03/02/2015
        rpt.SetParameterValue("@ko_type", ko_type)
        rpt.SetParameterValue("@logempcd", clsuser.UserID)

        frm.Title = "Production Lots Reports"
        frm.CRViewer.ReportSource = rpt
        frm.MdiParent = Me.ParentForm
        frm.Show()
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub btnProductionLotProtocolWarp_Click(sender As System.Object, e As System.EventArgs) Handles btnProtocolWarp.Click
        Const rptFileName = "rptProtocolWarp.rpt"
        'If clsuser.ReportPath = "" Then clsuser.ReportPath = clsConfig.ReportPath
        Dim ko_type As String = "" ' IIf(optKI.Checked, 1, IIf(optKO.Checked, 2, IIf(optKP.Checked, 3, IIf(optKC.Checked, 4, 5))))
        Dim config As New clsConfig
        If Not config.CheckReport(clsuser.ReportPath, rptFileName) Then Exit Sub
        Dim frm As New frmReport
        Dim rpt As New CrystalDecisions.CrystalReports.Engine.ReportDocument
        Dim stype As String = ""
        Dim ord As String = ""
        Me.Cursor = Cursors.WaitCursor

        rpt.Load(clsuser.ReportPath & rptFileName)
        rpt.DataSourceConnections.Item(0).SetConnection(clsConn.servername, clsConn.database, False)
        rpt.DataSourceConnections.Item(0).SetLogon(clsConn.Userid, clsConn.Password)
        rpt.VerifyDatabase()
        rpt.SetParameterValue("@kono", txtProdNo.Text.Trim)
        'Add by Neung 03/02/2015
        rpt.SetParameterValue("@ko_type", ko_type)
        rpt.SetParameterValue("@logempcd", clsuser.UserID)

        frm.Title = "Production Lots Reports"
        frm.CRViewer.ReportSource = rpt
        frm.MdiParent = Me.ParentForm
        frm.Show()
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub btnWO_Click(sender As System.Object, e As System.EventArgs) Handles btnWO.Click
        Const rptFileName = "rptProductionRoutingForWarp.rpt"
        'If clsuser.ReportPath = "" Then clsuser.ReportPath = clsConfig.ReportPath
        Dim ko_type As String = "" ' IIf(optKI.Checked, 1, IIf(optKO.Checked, 2, IIf(optKP.Checked, 3, IIf(optKC.Checked, 4, 5))))
        Dim config As New clsConfig
        If Not config.CheckReport(clsuser.ReportPath, rptFileName) Then Exit Sub
        Dim frm As New frmReport
        Dim rpt As New CrystalDecisions.CrystalReports.Engine.ReportDocument
        Dim stype As String = ""
        Dim ord As String = ""
        Me.Cursor = Cursors.WaitCursor

        rpt.Load(clsuser.ReportPath & rptFileName)
        rpt.DataSourceConnections.Item(0).SetConnection(clsConn.servername, clsConn.database, False)
        rpt.DataSourceConnections.Item(0).SetLogon(clsConn.Userid, clsConn.Password)
        rpt.VerifyDatabase()
        rpt.SetParameterValue("@kono", txtProdNo.Text.Trim)
        'Add by Neung 03/02/2015
        rpt.SetParameterValue("@ko_type", ko_type)
        rpt.SetParameterValue("@logempcd", clsuser.UserID)

        frm.Title = "Production Lots Reports"
        frm.CRViewer.ReportSource = rpt
        frm.MdiParent = Me.ParentForm
        frm.Show()
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub BtnPrintQCUI_Click(sender As System.Object, e As System.EventArgs) Handles BtnPrintQCUI.Click
        Const rptFileName = "rptQCUILDR.rpt"
        'If clsuser.ReportPath = "" Then clsuser.ReportPath = clsConfig.ReportPath
        Dim ko_type As String = "" ' IIf(optKI.Checked, 1, IIf(optKO.Checked, 2, IIf(optKP.Checked, 3, IIf(optKC.Checked, 4, 5))))
        Dim config As New clsConfig
        If Not config.CheckReport(clsuser.ReportPath, rptFileName) Then Exit Sub
        Dim frm As New frmReport
        Dim rpt As New CrystalDecisions.CrystalReports.Engine.ReportDocument
        Dim stype As String = ""
        Dim ord As String = ""
        Me.Cursor = Cursors.WaitCursor

        rpt.Load(clsuser.ReportPath & rptFileName)
        rpt.DataSourceConnections.Item(0).SetConnection(clsConn.servername, clsConn.database, False)
        rpt.DataSourceConnections.Item(0).SetLogon(clsConn.Userid, clsConn.Password)
        rpt.VerifyDatabase()
        rpt.SetParameterValue("@kono", txtProdNo.Text.Trim)
        'Add by Neung 03/02/2015
        rpt.SetParameterValue("@ko_type", ko_type)
        rpt.SetParameterValue("@logempcd", clsuser.UserID)

        frm.Title = "Production Lots Reports"
        frm.CRViewer.ReportSource = rpt
        frm.MdiParent = Me.ParentForm
        frm.Show()
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub btnPrintQCTension_Click(sender As System.Object, e As System.EventArgs) Handles btnPrintQCTension.Click
        Const rptFileName = "rptQCTension.rpt"
        'If clsuser.ReportPath = "" Then clsuser.ReportPath = clsConfig.ReportPath
        Dim ko_type As String = "" ' IIf(optKI.Checked, 1, IIf(optKO.Checked, 2, IIf(optKP.Checked, 3, IIf(optKC.Checked, 4, 5))))
        ko_type = KOdata.ko_type
        Dim config As New clsConfig
        If Not config.CheckReport(clsuser.ReportPath, rptFileName) Then Exit Sub
        Dim frm As New frmReport
        Dim rpt As New CrystalDecisions.CrystalReports.Engine.ReportDocument
        Dim stype As String = ""
        Dim ord As String = ""
        Me.Cursor = Cursors.WaitCursor

        rpt.Load(clsuser.ReportPath & rptFileName)
        rpt.DataSourceConnections.Item(0).SetConnection(clsConn.servername, clsConn.database, False)
        rpt.DataSourceConnections.Item(0).SetLogon(clsConn.Userid, clsConn.Password)
        rpt.VerifyDatabase()
        rpt.SetParameterValue("@kono", txtProdNo.Text.Trim)
        'Add by Neung 03/02/2015
        rpt.SetParameterValue("@ko_type", ko_type)
        rpt.SetParameterValue("@logempcd", clsuser.UserID)

        frm.Title = "Production Lots Reports"
        frm.CRViewer.ReportSource = rpt
        frm.MdiParent = Me.ParentForm
        frm.Show()
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub TPlots_Click(sender As System.Object, e As System.EventArgs) Handles TPlots.Click

    End Sub

    Private Sub grdDataLots_CellClick(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles grdDataLots.CellClick
        If e.RowIndex < 0 OrElse Not e.ColumnIndex = grdDataLots.Columns("reservation").Index Then Return

        Dim mtl_reservations As New classReservation.mtl_reservations
        mtl_reservations.demand_source_type_id = CInt(3)

        mtl_reservations.supply_source_type_id = CInt(3)
        mtl_reservations.supply_source_header_id = KO.production_order_id
        mtl_reservations.supply_source_line_id = CInt(grdDataLots("mfg_production_lots_id", e.RowIndex).Value)
        mtl_reservations.item_id = CInt(grdDataLots("item_id", e.RowIndex).Value)

        Dim frm As New frmReservation
        frm.p_mtl_reservations = mtl_reservations
        frm.UserInfo = clsuser
        frm.ShowDialog(Me)
        Me.Cursor = Cursors.WaitCursor

        Me.Cursor = Cursors.Default
        frm.Dispose()

    End Sub

    Private Sub grdDataRouting_CurrentCellDirtyStateChanged(sender As Object, e As EventArgs) Handles grdDataRouting.CurrentCellDirtyStateChanged
        'If grdDataRouting.IsCurrentCellDirty Then
        'grdDataRouting.CommitEdit(DataGridViewDataErrorContexts.Commit)
        'End If
    End Sub

    Private Sub btnYarnIn_Click(sender As Object, e As EventArgs) Handles btnYarnIn.Click

        Dim system_lot_number As String = grdDataLots.CurrentRow.Cells("system_lot_number").Value
        If system_lot_number.Length <= 0 Then Exit Sub

        Dim frm As New frmOperationWarp
        frm.pSystemLotNumber = system_lot_number
        frm.UserInfo = clsuser
        'frm.MdiParent = Me
        frm.ShowDialog()

        'Sitthana 20200312
        mfg_production_lots.mfg_production_steps_id = Nothing

        Call LoadDataRouting(Intmfg_production_steps_id:=Nothing, Strproduction_order_no:=KO.kono)
        Call LoadDataLots(Intmfg_production_steps_id:=mfg_production_lots.mfg_production_steps_id, Strproduction_order_no:=KO.kono)
        Call CheckLots(grdDataLots.DataSource)
    End Sub
End Class