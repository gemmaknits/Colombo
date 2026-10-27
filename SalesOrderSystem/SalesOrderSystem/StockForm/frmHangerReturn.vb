Public Class frmHangerReturnBarcode
    Dim clsuser As New classUserInfo
    Dim blnCancel As Boolean

    Public dtCboCustomer As New DataTable
    Public bsCboCustomer As New BindingSource
    Public dtcboDocType As New DataTable
    Public bscboDocType As New BindingSource
    Public dtcboEmp As New DataTable
    Public bscboEmp As New BindingSource

    Dim dtHangerReturnBarcodeNew As New DataTable
    Dim bsHangerReturnBarcodeNew As New BindingSource
    Dim dtHangerReturnBarcodeNewItem As New DataTable
    Dim bsHangerReturnBarcodeNewItem As New BindingSource

    Dim drvHangerReturnBarcodeNew As DataRowView

    Dim dtMtlWarehouse As New DataTable
    Dim bsMtlWarehouse As New BindingSource
    Dim dtMtlSubInventory As New DataTable
    Dim bsMtlSubInventory As New BindingSource
    Dim dtmtlLocations As New DataTable
    Dim bsMtlLocations As New BindingSource

    Public Property Userinfo() As classUserInfo
        Get
            Userinfo = clsuser
        End Get
        Set(ByVal newvalue As classUserInfo)
            clsuser = newvalue
        End Set
    End Property
    Private Sub frmHangerReturn_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized

        Call InitControl()

        Call GenComBo()

        Call InitDataBinding()
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

    Private Sub GenComBo()

        dtCboCustomer = (New classDyedOutSample).GetComBoCustomer()
        bsCboCustomer.DataSource = dtCboCustomer
        cboCustomer.DataSource = bsCboCustomer
        cboCustomer.DisplayMember = "name"
        cboCustomer.ValueMember = "customer_id"

        dtcboDocType = (New classMaster).GetDocType
        bscboDocType.DataSource = dtcboDocType
        cboDocType.DataSource = bscboDocType
        cboDocType.DisplayMember = "name"
        cboDocType.ValueMember = "doctyp"
        cboDocType.SelectedValue = "K"

        dtcboEmp = (New classMaster).comboEmployee(strUserID:=Userinfo.UserID)
        bscboEmp.DataSource = dtcboEmp
        cboempcd.DataSource = bscboEmp
        cboempcd.DisplayMember = "empname2"
        cboempcd.ValueMember = "empcd"

        dtMtlWarehouse = (New classMaster).Combomtlwarehouse()
        bsMtlWarehouse.DataSource = dtMtlWarehouse
        cbomtlWarehouse.DataSource = bsMtlWarehouse.DataSource
        cbomtlWarehouse.DisplayMember = "warehouse_code"
        cbomtlWarehouse.ValueMember = "mtl_warehouse_id"

        grdHangerINMtlWareHouse.DataSource = (New classMaster).Combomtlwarehouse()
        grdHangerINMtlWareHouse.DisplayMember = "warehouse_code"
        grdHangerINMtlWareHouse.ValueMember = "mtl_warehouse_id"

        dtMtlSubInventory = (New classMaster).GetComboMtlsubinventory(INt64mtl_warehouse_id:=0)
        bsMtlSubInventory.DataSource = dtMtlSubInventory
        cbomtlSubinventory.DataSource = bsMtlSubInventory.DataSource
        cbomtlSubinventory.DisplayMember = "subinventory_code"
        cbomtlSubinventory.ValueMember = "mtl_subinventory_id"

        grdHangerINMtlSubinventory.DataSource = (New classMaster).GetComboMtlsubinventory(INt64mtl_warehouse_id:=0)
        grdHangerINMtlSubinventory.DisplayMember = "subinventory_code"
        grdHangerINMtlSubinventory.ValueMember = "mtl_subinventory_id"

        dtmtlLocations = (New classMaster).Combomtllocations(INt64mtl_warehouse_id:=0, Int64mtl_subinventory_id:=0)
        bsMtlLocations.DataSource = dtmtlLocations
        cbomtlLocation.DataSource = bsMtlLocations.DataSource
        cbomtlLocation.DisplayMember = "location_name"
        cbomtlLocation.ValueMember = "mtl_locations_id"

        grdHangerINMtlLocations.DataSource = (New classMaster).Combomtllocations(INt64mtl_warehouse_id:=0, Int64mtl_subinventory_id:=0)
        grdHangerINMtlLocations.DisplayMember = "location_name"
        grdHangerINMtlLocations.ValueMember = "mtl_locations_id"
    End Sub

    Private Sub InitDataBinding()
        dtHangerReturnBarcodeNew = (New classHangerReturnBarcode).GetHangerByDINNO(StrDINNO:=txtDocNo.Text.Trim)
        bsHangerReturnBarcodeNew.DataSource = dtHangerReturnBarcodeNew
        bsHangerReturnBarcodeNew.MoveFirst()

        grdHangerIN.AutoGenerateColumns = False
        grdHangerIN.DataSource = dtHangerReturnBarcodeNew

        drvHangerReturnBarcodeNew = (CType(bsHangerReturnBarcodeNew.Current, DataRowView))

        Call BindingData() '
    End Sub

    Private Sub BindingData()
        Call ClearDataBindings()

        txtDocNo.DataBindings.Add("text", bsHangerReturnBarcodeNew, "dinno")
        dtpDindt.DataBindings.Add("text", bsHangerReturnBarcodeNew, "dindt")
        cboCustomer.DataBindings.Add("selectedvalue", bsHangerReturnBarcodeNew, "customer_id")
        txtaddr1.DataBindings.Add("text", bsCboCustomer, "addr1")
        cboDocType.DataBindings.Add("selectedvalue", bsHangerReturnBarcodeNew, "doctyp")

    End Sub

    Public Sub ClearDataBindings()
        Dim obj As Control
        For Each obj In Me.Controls
            Call ClearControlBindings(obj)
        Next
    End Sub

    Private Sub ClearControlBindings(ByVal obj As Control)
        obj.DataBindings.Clear()
        If TypeOf obj Is TabControl Or TypeOf obj Is TabPage Or TypeOf obj Is GroupBox Then
            Dim obj2 As Control
            For Each obj2 In obj.Controls
                Call ClearControlBindings(obj2)
            Next
        End If

    End Sub

    Private Sub btnSave_Click(sender As System.Object, e As System.EventArgs) Handles btnSave.Click
        'Sitthana 20220624 Changed Windows.Forms.DialogResult To DialogResult
        Dim result As DialogResult ' Windows.Forms.DialogResult
        result = MessageBox.Show("Would you like to Save Hanger in?", "System Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button3)
        If result <> DialogResult.Yes Then Exit Sub

        If Not CheckData() Then Exit Sub

        Call SaveHangerIN()
    End Sub

    Private Function CheckData() As Boolean

        '============= Check Slect row > 1 =============================
        Dim i As Integer = 0 'num select row
        For Each row As DataGridViewRow In grdHangerIN.Rows
            Dim chk As DataGridViewCheckBoxCell = row.Cells("grdHangerINSel")
            If row.Cells("grdHangerINSel").Value = True Then
                i = i + 1
            End If
        Next
        If i = 0 Then
            MsgBox("Must be select one roll or more then")
            Return False
        End If
        '===============================================================

        '--============= Check Data In Grid ============================
        For Each row As DataGridViewRow In grdHangerIN.Rows
            Dim chk As DataGridViewCheckBoxCell = row.Cells("grdHangerINSel")
            If row.Cells("grdHangerINSel").Value = True Then
                If (New clsConfig).IsNull(row.Cells("grdHangerINMtlWareHouse").Value, 0) = 0 Then
                    MessageBox.Show("ยังไมได้เลือก W/H ", "Syatem Message", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
                    Return False
                End If
                If (New clsConfig).IsNull(row.Cells("grdHangerINMtlSubinventory").Value, 0) = 0 Then
                    MessageBox.Show("ยังไมได้เลือก Sub ", "Syatem Message", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
                    Return False
                End If

                If (New clsConfig).IsNull(row.Cells("grdHangerINMtlLocations").Value, 0) = 0 Then
                    MessageBox.Show("ยังไมได้เลือก Loc ", "Syatem Message", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
                    Return False
                End If

                If (New clsConfig).IsNull(row.Cells("grdHangerINKg").Value, 0) = 0 Then
                    MessageBox.Show("ยังไมได้ใส่่ QTY ", "Syatem Message", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
                    Return False
                End If
            End If
        Next

        If (New clsConfig).IsNull(cboCustomer.SelectedValue, 0) = 0 Then
            MessageBox.Show("ยังไม่ได้เลือก Customer ", "Syatem Message", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
            Return False
        End If

        If (New clsConfig).IsNull(cboempcd.SelectedValue, "").ToString.Trim = "" Then
            MessageBox.Show("ยังไม่ได้เลือก Requested By ", "Syatem Message", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
            Return False
        End If

        Return True
    End Function

    Private Function SaveHangerIN() As Boolean

        bsHangerReturnBarcodeNew.EndEdit()
        Dim dt As DataTable = bsHangerReturnBarcodeNew.DataSource
        Dim dv_add As New DataView(dt, "", "", DataViewRowState.Added)
        Dim dv_upd As New DataView(dt, "", "", DataViewRowState.ModifiedCurrent)
        Dim dv_del As New DataView(dt, "", "", DataViewRowState.Deleted)
        Dim msgerr As String = "'"

        Dim Hinheader As New classHangerReturnBarcode.StrollsDHeader

        Hinheader.h01_dinno = txtDocNo.Text.Trim
        Hinheader.h02_dindt = dtpDindt.Value
        Hinheader.h03_doctyp = cboDocType.SelectedValue
        Hinheader.h04_dhcod = "RET"
        Hinheader.h56_customer_id = cboCustomer.SelectedValue
        Hinheader.h57_empcd = cboempcd.SelectedValue
        Hinheader.h07_dfno = "" ' dtHangerINNew.Rows(0)("outno")

        If (New classHangerReturnBarcode).MakeHangerIN(StrollsDHeader:=Hinheader, DV_ADD:=dv_add, DV_UPD:=dv_upd, DV_DEL:=dv_del, Userinfo:=Userinfo, msgerr:=msgerr) Then
            txtDocNo.Text = Hinheader.h01_dinno
            dtHangerReturnBarcodeNew = (New classHangerReturnBarcode).GetHangerByDINNO(StrDINNO:=txtDocNo.Text.Trim)
            bsHangerReturnBarcodeNew.DataSource = dtHangerReturnBarcodeNew
            grdHangerIN.DataSource = bsHangerReturnBarcodeNew
            MessageBox.Show("บันทึกสำเร็จ", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
            SaveHangerIN = True
        Else
            MessageBox.Show(msgerr, "System Message", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
            SaveHangerIN = False
        End If

    End Function

    Private Sub btnPrintHangerOut_Click(sender As System.Object, e As System.EventArgs)

    End Sub

    Private Sub txtRollNoD_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles txtRollNoD.KeyDown
        If e.KeyCode = Keys.Enter Then
            dtHangerReturnBarcodeNewItem = (New classHangerReturnBarcode).GetHanger(StrRollNoD:=txtRollNoD.Text.Trim)
            bsHangerReturnBarcodeNewItem.DataSource = dtHangerReturnBarcodeNewItem
            bsHangerReturnBarcodeNewItem.MoveFirst()

            Call AddRollNo()

            txtRollNoD.Text = ""
            txtRollNoD.Focus()
        End If
       
    End Sub

    Private Sub AddRollNo()
        If dtHangerReturnBarcodeNewItem.Rows.Count > 0 Then
            Dim config As New clsConfig
            Dim dr As DataRow
            Dim msg As String = ""
            Dim i As Integer = 0
            Dim j As Integer = 0
            For i = 0 To dtHangerReturnBarcodeNewItem.Rows.Count - 1
                'If Not CheckDuplicate(dtHangerINBarcodeNew.Rows(i)("id_strolls_d_o").ToString.Trim, dtHangerINNew.Copy()) Then

                dr = dtHangerReturnBarcodeNew.NewRow

                For j = 0 To dtHangerReturnBarcodeNewItem.Columns.Count - 1
                    dr(dtHangerReturnBarcodeNewItem.Columns(j).ColumnName.Trim) = dtHangerReturnBarcodeNewItem.Rows(i)(dtHangerReturnBarcodeNewItem.Columns(j).ColumnName.Trim)
                Next

                'dtHangerReturnBarcodeNew.ImportRow(dr)
                dtHangerReturnBarcodeNew.Rows.Add(dr)
                'End If
            Next
        End If
        ' Call SumGrid()
    End Sub

    Private Sub txtOutno_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles txtDocNo.KeyDown
        If e.KeyCode = Keys.Enter Then
            Call InitDataBinding()
        End If
    End Sub

    Private Sub btnNew_Click(sender As System.Object, e As System.EventArgs) Handles btnNew.Click
        Me.WindowState = FormWindowState.Maximized

        Call InitControl()

        Call GenComBo()

        Call InitDataBinding()
    End Sub

    Private Sub btnSearchCustomers_Click(sender As System.Object, e As System.EventArgs) Handles btnSearchCustomers.Click
        Dim frm As New frmSearchCustomers
        frm.ShowDialog(Me)
        Me.Cursor = Cursors.WaitCursor

        cboCustomer.SelectedValue = frm.pCustomerID

        Me.Cursor = Cursors.Default
        frm.Dispose()
    End Sub

    Private Sub ToolStripMenuItem1_Click(sender As System.Object, e As System.EventArgs) Handles BtnPrintDocument.Click

        If txtDocNo.Text.Length = 0 Then Exit Sub

        Const rptFileName = "rptHIN.rpt"

        If clsuser.ReportPath = "" Then clsuser.ReportPath = clsuser.ReportPath
        If Not (New clsConfig).CheckReport(clsuser.ReportPath, rptFileName) Then Exit Sub
        Dim frm As New frmReport
        Dim rpt As New CrystalDecisions.CrystalReports.Engine.ReportDocument
        Me.Cursor = Cursors.WaitCursor
        rpt.Load(clsuser.ReportPath & rptFileName)
        rpt.DataSourceConnections.Item(0).SetConnection((New ClassConnection).servername, (New ClassConnection).database, False)
        rpt.DataSourceConnections.Item(0).SetLogon((New ClassConnection).Userid, (New ClassConnection).Password)
        rpt.VerifyDatabase()
        rpt.SetParameterValue("@docno", txtDocNo.Text.Trim)


        frm.Title = "Hanger IN"
        frm.CRViewer.ReportSource = rpt
        frm.MdiParent = Me.ParentForm
        frm.Show()
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub btnSelectAll_Click(sender As System.Object, e As System.EventArgs) Handles btnSelectAll.Click
        Call selectAllItems()
    End Sub

    Private Sub selectAllItems()
        Dim i As Integer
        If Me.grdHangerIN.Rows.Count = 0 Then Exit Sub
        Try
            For i = 0 To Me.grdHangerIN.Rows.Count - 1
                If Me.grdHangerIN.Rows(i).Cells("grdHangerINSel").Value = False Then Me.grdHangerIN.Rows(i).Cells("grdHangerINSel").Value = True
            Next
        Catch ex As Exception

        End Try
    End Sub

    Private Sub cbomtlWarehouse_SelectedValueChanged(sender As System.Object, e As System.EventArgs) Handles cbomtlWarehouse.SelectedValueChanged
        bsMtlSubInventory.Filter = "mtl_warehouse_id = '" & (New clsConfig).IsNull(cbomtlWarehouse.SelectedValue, 0) & "' and hanger_subinventory = 'Y'"
        bsMtlLocations.Filter = "mtl_warehouse_id = '" & (New clsConfig).IsNull(cbomtlWarehouse.SelectedValue, 0) & "' and mtl_subinventory_id = '" & (New clsConfig).IsNull(cbomtlSubinventory.SelectedValue, 0) & "'"

    End Sub

    Private Sub cbomtlSubinventory_SelectedValueChanged(sender As System.Object, e As System.EventArgs) Handles cbomtlSubinventory.SelectedValueChanged
        bsMtlLocations.Filter = "mtl_warehouse_id = '" & (New clsConfig).IsNull(cbomtlWarehouse.SelectedValue, 0) & "' and mtl_subinventory_id = '" & (New clsConfig).IsNull(cbomtlSubinventory.SelectedValue, 0) & "'"

    End Sub

    Private Sub btnApplyCurRow_Click(sender As System.Object, e As System.EventArgs) Handles btnApplyCurRow.Click
        Call ApplyRow(grdHangerIN.CurrentRow.Index)
    End Sub

    Private Sub ApplyRow(RowNo As Integer)
        With grdHangerIN
            grdHangerIN.Rows(RowNo).Cells("grdHangerINMtlWareHouse").Value() = cbomtlWarehouse.SelectedValue

            Dim dgvcc As New DataGridViewComboBoxCell
            dgvcc = grdHangerIN.Rows(RowNo).Cells("grdHangerINMtlSubinventory")
            dgvcc.DataSource = cbomtlSubinventory.DataSource
            grdHangerIN.Rows(RowNo).Cells("grdHangerINMtlSubinventory").Value() = cbomtlSubinventory.SelectedValue

            Dim dgvcc2 As New DataGridViewComboBoxCell
            dgvcc = grdHangerIN.Rows(RowNo).Cells("grdHangerINMtlLocations")
            dgvcc.DataSource = cbomtlLocation.DataSource
            If IsDBNull(cbomtlLocation.DataSource) Then
                grdHangerIN.Rows(RowNo).Cells("grdHangerINMtlLocations").Value = -1
            Else
                grdHangerIN.Rows(RowNo).Cells("grdHangerINMtlLocations").Value() = cbomtlLocation.SelectedValue
            End If
        End With
    End Sub

    Private Sub ToolStripMenuItem2_Click(sender As System.Object, e As System.EventArgs) Handles BtnPrintTagMini.Click
        Call PrintTagMini()
    End Sub

    Private Sub PrintTagMini()
        Dim clsConfig As New clsConfig
        Dim rptFileName = "rptHangerLotNumber.rpt"
        If clsuser.ReportPath = "" Then clsuser.ReportPath = clsuser.ReportPath
        'clsUser.ReportPath = "C:\Users\DELL\Desktop\GemmaKnits\"
        If Not clsConfig.CheckReport(clsuser.ReportPath, rptFileName) Then Exit Sub
        Dim frm As New frmReport
        Dim rpt As New CrystalDecisions.CrystalReports.Engine.ReportDocument
        Dim stype As String = ""
        Dim ord As String = ""
        Me.Cursor = Cursors.WaitCursor

        rpt.Load(clsuser.ReportPath & rptFileName)
        rpt.DataSourceConnections.Item(0).SetConnection((New ClassConnection).servername, (New ClassConnection).database, False)
        rpt.DataSourceConnections.Item(0).SetLogon((New ClassConnection).Userid, (New ClassConnection).Password)
        rpt.VerifyDatabase()
        rpt.SetParameterValue("@dinno", txtDocNo.Text.Trim)

        rpt.PrintOptions.PaperSize = CrystalDecisions.Shared.PaperSize.DefaultPaperSize
        rpt.PrintOptions.PaperOrientation = CrystalDecisions.Shared.PaperOrientation.DefaultPaperOrientation
        rpt.PrintOptions.PaperSource = CrystalDecisions.Shared.PaperSource.Auto

        frm.Title = "All Barcode"
        frm.CRViewer.ReportSource = rpt
        frm.MdiParent = Me.ParentForm
        frm.Show()
        Me.Cursor = Cursors.Default
    End Sub
    Private Sub PrintTagFair()
        Dim StrollsDList As String = ""

        For i = 0 To Me.grdHangerIN.Rows.Count - 1
            If Me.grdHangerIN.Rows(i).Cells("grdHangerINSel").Value = True Then
                StrollsDList = StrollsDList & Me.grdHangerIN.Rows(i).Cells("grdHangerINRollNoD").Value.ToString.Trim & ","
            End If
        Next

        Dim clsConfig As New clsConfig
        Dim rptFileName = "rptHangerLotNumberFairNew.rpt"
        If clsuser.ReportPath = "" Then clsuser.ReportPath = clsuser.ReportPath
        'clsUser.ReportPath = "C:\Users\DELL\Desktop\GemmaKnits\"
        If Not clsConfig.CheckReport(clsuser.ReportPath, rptFileName) Then Exit Sub
        Dim frm As New frmReport
        Dim rpt As New CrystalDecisions.CrystalReports.Engine.ReportDocument
        Dim stype As String = ""
        Dim ord As String = ""
        Me.Cursor = Cursors.WaitCursor

        rpt.Load(clsuser.ReportPath & rptFileName)
        rpt.DataSourceConnections.Item(0).SetConnection((New classConnection).servername, (New classConnection).database, False)
        rpt.DataSourceConnections.Item(0).SetLogon((New classConnection).Userid, (New classConnection).Password)
        rpt.VerifyDatabase()
        rpt.SetParameterValue("@roll_no_d_list", StrollsDList)

        rpt.PrintOptions.PaperSize = CrystalDecisions.Shared.PaperSize.DefaultPaperSize
        rpt.PrintOptions.PaperOrientation = CrystalDecisions.Shared.PaperOrientation.DefaultPaperOrientation
        rpt.PrintOptions.PaperSource = CrystalDecisions.Shared.PaperSource.Auto

        frm.Title = "All Barcode"
        frm.CRViewer.ReportSource = rpt
        frm.MdiParent = Me.ParentForm
        frm.Show()
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub BtnPrintTagFair_Click(sender As System.Object, e As System.EventArgs) Handles BtnPrintTagFair.Click
        Call PrintTagFair()
    End Sub

    Private Sub Label7_Click(sender As System.Object, e As System.EventArgs) Handles Label7.Click

    End Sub
End Class