Public Class frmHangerINBarcode
    Dim clsuser As New classUserInfo
    Dim blnCancel As Boolean

    Dim dtHangerINBarcodeNew As New DataTable
    Dim bsHangerINBarcodeNew As New BindingSource
    Dim dtHangerINNew As New DataTable
    Dim bsHangerINNew As New BindingSource

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


    Private Sub frmHangerIN_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized

        Call InitControl()

        Call InitDataBinding()

        Call GenCombo()

        Call LoadGrdDOutNewByOutno("N/A")

    End Sub

    Private Sub LoadGrdDOutNewByOutno(ByVal StrOutno As String)

        Dim dt As DataTable = (New classHangerINBarcode).GetGridHangerINByDINNO(StrDINNo:=StrOutno)
        If dt.Rows.Count > 0 Then BindtxtDoutNew(dt)
        Call BindGrdDoutNew(dt)

    End Sub

    Private Sub BindtxtDoutNew(ByVal dt As DataTable)
        dtHangerINNew = dt

        bsHangerINNew.DataSource = dtHangerINNew

    End Sub

    Private Sub BindGrdDoutNew(ByVal dt As DataTable)
        dtHangerINNew = dt

        bsHangerINNew.DataSource = dtHangerINNew

        grdHangerIN.AutoGenerateColumns = False
        grdHangerIN.DataSource = bsHangerINNew.DataSource

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

    Private Sub GenCombo()

        dtMtlWarehouse = (New classMaster).Combomtlwarehouse()
        bsMtlWarehouse.DataSource = dtMtlWarehouse
        cbomtlWarehouse.DataSource = bsMtlWarehouse.DataSource
        cbomtlWarehouse.DisplayMember = "warehouse_code"
        cbomtlWarehouse.ValueMember = "mtl_warehouse_id"

        grdHangerINMtlWareHouse.DataSource = dtMtlWarehouse.Copy
        grdHangerINMtlWareHouse.DisplayMember = "warehouse_code"
        grdHangerINMtlWareHouse.ValueMember = "mtl_warehouse_id"

        dtMtlSubInventory = (New classMaster).GetComboMtlsubinventory(INt64mtl_warehouse_id:=0)
        bsMtlSubInventory.DataSource = dtMtlSubInventory
        cbomtlSubinventory.DataSource = bsMtlSubInventory.DataSource
        cbomtlSubinventory.DisplayMember = "subinventory_code"
        cbomtlSubinventory.ValueMember = "mtl_subinventory_id"

        grdHangerINMtlSubinventory.DataSource = dtMtlSubInventory.Copy
        grdHangerINMtlSubinventory.DisplayMember = "subinventory_code"
        grdHangerINMtlSubinventory.ValueMember = "mtl_subinventory_id"

        dtmtlLocations = (New classMaster).Combomtllocations(INt64mtl_warehouse_id:=0, Int64mtl_subinventory_id:=0)
        bsMtlLocations.DataSource = dtmtlLocations
        cbomtlLocation.DataSource = bsMtlLocations.DataSource
        cbomtlLocation.DisplayMember = "location_name"
        cbomtlLocation.ValueMember = "mtl_locations_id"

        grdHangerINMtlLocations.DataSource = dtmtlLocations.Copy
        grdHangerINMtlLocations.DisplayMember = "location_name"
        grdHangerINMtlLocations.ValueMember = "mtl_locations_id"

        cboDoctype.DataSource = (New classMaster).GetDocType
        cboDoctype.DisplayMember = "name"
        cboDoctype.ValueMember = "doctyp"
        cboDoctype.SelectedValue = "0"
        cboDoctype.Enabled = False


    End Sub

    Private Sub InitDataBinding()

        dtHangerINBarcodeNew = (New classHangerINBarcode).GetDout(Int64IDStrollsDO:=Val(txtIDStrollsDO.Text.Trim))
        bsHangerINBarcodeNew.DataSource = dtHangerINBarcodeNew

        dtHangerINNew = (New classHangerINBarcode).GetGridHangerINByDINNO(txtDocNo.Text.Trim)
        bsHangerINNew.DataSource = dtHangerINNew

        Call BindingData() '
    End Sub

    Private Sub BindingData()
        Call ClearDataBindings()


        'txtIDStrollsDO.DataBindings.Add("text", bsHangerINBarcodeNew, "id_strolls_d_o")


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


    Private Sub txtDesignNo_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles txtIDStrollsDO.KeyDown
        If e.KeyCode = Keys.Enter Then
            dtHangerINBarcodeNew = (New classHangerINBarcode).GetDout(Int64IDStrollsDO:=Val(txtIDStrollsDO.Text.Trim))
            bsHangerINBarcodeNew.DataSource = dtHangerINBarcodeNew
            bsHangerINBarcodeNew.MoveFirst()

            Call AddRollNo()

            txtIDStrollsDO.Focus()
        End If
    End Sub

    Private Sub AddRollNo()
        If dtHangerINBarcodeNew.Rows.Count > 0 Then
            Dim config As New clsConfig
            Dim dr As DataRow
            Dim msg As String = ""
            Dim i As Integer = 0
            Dim j As Integer = 0
            For i = 0 To dtHangerINBarcodeNew.Rows.Count - 1
                'If Not CheckDuplicate(dtHangerINBarcodeNew.Rows(i)("id_strolls_d_o").ToString.Trim, dtHangerINNew.Copy()) Then

                dr = dtHangerINNew.NewRow

                For j = 0 To dtHangerINBarcodeNew.Columns.Count - 1
                    dr(dtHangerINBarcodeNew.Columns(j).ColumnName.Trim) = dtHangerINBarcodeNew.Rows(i)(dtHangerINBarcodeNew.Columns(j).ColumnName.Trim)
                Next

                dtHangerINNew.Rows.Add(dr)
                'End If
            Next
        End If
        ' Call SumGrid()
    End Sub

    Private Function CheckDuplicate(ByVal strRollNo As String, ByVal dt As DataTable) As Boolean
        If dt.Rows.Count > 0 Then
            Dim i As Integer = 0
            For i = 0 To dt.Rows.Count - 1
                If dt.Rows(i).RowState <> DataRowState.Deleted Then
                    If dt.Rows(i)("id_strolls_d_o").ToString.Trim = strRollNo Then Return True
                End If
            Next
        End If
        Return False
    End Function

    Private Sub txtDesignNo_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtIDStrollsDO.TextChanged

    End Sub

    Private Sub cbomtlWarehouse_DropDownClosed(sender As Object, e As System.EventArgs) Handles cbomtlWarehouse.DropDownClosed
        bsMtlSubInventory.Filter = "mtl_warehouse_id = '" & (New clsConfig).IsNull(cbomtlWarehouse.SelectedValue, 0) & "' and hanger_subinventory = 'Y'"
        bsMtlLocations.Filter = "mtl_warehouse_id = '" & (New clsConfig).IsNull(cbomtlWarehouse.SelectedValue, 0) & "' and mtl_subinventory_id = '" & (New clsConfig).IsNull(cbomtlSubinventory.SelectedValue, 0) & "'"


    End Sub

    Private Sub cbomtlWarehouse_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles cbomtlWarehouse.KeyDown

    End Sub

    Private Sub cbomtlWarehouse_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cbomtlWarehouse.SelectedIndexChanged

    End Sub

    Private Sub BtnMakeHangerIN_Click(sender As System.Object, e As System.EventArgs)
        'Sitthana 20220624 Changed Windows.Forms.DialogResult To DialogResult
        Dim result As DialogResult ' Windows.Forms.DialogResult
        result = MessageBox.Show("Would you like to make Hanger in?", "System Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button3)
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





        Return True
    End Function

    Private Function SaveHangerIN() As Boolean

        bsHangerINNew.EndEdit()
        Dim dt As DataTable = bsHangerINNew.DataSource
        Dim dv_add As New DataView(dt, "", "", DataViewRowState.Added)
        Dim dv_upd As New DataView(dt, "", "", DataViewRowState.ModifiedCurrent)
        Dim dv_del As New DataView(dt, "", "", DataViewRowState.Deleted)
        Dim msgerr As String = "'"

        Dim Hinheader As New classHangerINBarcode.StrollsDHeader

        Hinheader.h01_dinno = txtDocNo.Text.Trim
        Hinheader.h02_dindt = dtpDindt.Value
        Hinheader.h03_doctyp = cboDoctype.SelectedValue
        Hinheader.h07_dfno = "" ' dtHangerINNew.Rows(0)("outno")

        If (New classHangerINBarcode).MakeHangerIN(StrollsDHeader:=Hinheader, DV_ADD:=dv_add, DV_UPD:=dv_upd, DV_DEL:=dv_del, Userinfo:=Userinfo, msgerr:=msgerr) Then
            txtDocNo.Text = Hinheader.h01_dinno
            dtHangerINNew = (New classHangerINBarcode).GetGridHangerINByDINNO(txtDocNo.Text.Trim)
            bsHangerINNew.DataSource = dtHangerINNew
            grdHangerIN.DataSource = bsHangerINNew
            MessageBox.Show("บันทึกสำเร็จ", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
            SaveHangerIN = True
        Else
            MessageBox.Show(msgerr, "System Message", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
            SaveHangerIN = False
        End If

    End Function

    Private Sub grdHangerIN_CellEndEdit(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles grdHangerIN.CellEndEdit
        If e.RowIndex < 0 Or e.ColumnIndex < 0 Then Exit Sub
        If grdHangerIN.Columns(e.ColumnIndex).Name = "grdHangerINKg" Then
            If (New clsConfig).IsNull(grdHangerIN.CurrentRow.Cells("grdHangerINKg").Value, 0) > 0 Then
                grdHangerIN.CurrentRow.Cells("grdHangerINSel").Value = True
            End If
        End If

    End Sub


    Private Sub grdDoutNew_CellMouseLeave(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles grdHangerIN.CellMouseLeave
        If e.RowIndex >= 0 Then
            If grdHangerIN.CurrentCell.IsInEditMode Then grdHangerIN.EndEdit()
        End If

    End Sub

    Private Sub btnSave_Click(sender As System.Object, e As System.EventArgs)

    End Sub

    Private Sub txtOutNo_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles txtOutNo.KeyDown
        If e.KeyCode = Keys.Enter Then
            dtHangerINBarcodeNew = (New classHangerINBarcode).GetDout(Int64IDStrollsDO:=0, StrOutno:=txtOutNo.Text)
            bsHangerINBarcodeNew.DataSource = dtHangerINBarcodeNew
            bsHangerINBarcodeNew.MoveFirst()

            Call AddRollNo()

            txtOutNo.Focus()
        End If
    End Sub

    Private Sub txtOutNo_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtOutNo.TextChanged

    End Sub

    Private Sub cbomtlSubinventory_DropDownClosed(sender As Object, e As System.EventArgs) Handles cbomtlSubinventory.DropDownClosed
        bsMtlLocations.Filter = "mtl_warehouse_id = '" & (New clsConfig).IsNull(cbomtlWarehouse.SelectedValue, 0) & "' and mtl_subinventory_id = '" & (New clsConfig).IsNull(cbomtlSubinventory.SelectedValue, 0) & "'"

    End Sub

    Private Sub cbomtlSubinventory_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cbomtlSubinventory.SelectedIndexChanged

    End Sub

    Private Sub grdHangerIN_CellContentClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles grdHangerIN.CellContentClick

    End Sub

    Private Sub btnNew_Click(sender As System.Object, e As System.EventArgs) Handles btnNew.Click
        Me.WindowState = FormWindowState.Maximized

        Call InitControl()

        Call InitDataBinding()

        Call GenCombo()

        Call LoadGrdDOutNewByOutno("N/A")
    End Sub

    Private Sub btnExit_Click(sender As System.Object, e As System.EventArgs) Handles btnExit.Click
        Me.Close()
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

    Private Sub btnApplyAll_Click(sender As System.Object, e As System.EventArgs) Handles btnApplyAll.Click
        Dim dt3 As New DataTable
        For i = 0 To grdHangerIN.Rows.Count - 1
            ApplyRow(i)
        Next
    End Sub

    Private Sub txtDINNO_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles txtDocNo.KeyDown
        If e.KeyCode = Keys.Enter Then
            dtHangerINNew = (New classHangerINBarcode).GetGridHangerINByDINNO(txtDocNo.Text.Trim)
            bsHangerINNew.DataSource = dtHangerINNew
            grdHangerIN.DataSource = bsHangerINNew
        End If
    End Sub

    Private Sub txtDINNO_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtDocNo.TextChanged

    End Sub

    Private Sub btnCancel_Click(sender As System.Object, e As System.EventArgs) Handles btnCancel.Click

        'Dim result As Windows.Forms.DialogResult
        'result = MessageBox.Show("Would you like to cancel document?", "System Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button3)
        'If result <> Windows.Forms.DialogResult.Yes Then Exit Sub

        'If Not CheckData() Then Exit Sub


    End Sub

    Private Sub btnPrintTag_Click(sender As System.Object, e As System.EventArgs) Handles btnPrintTagMini.Click
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

        'rpt.PrintOptions.PaperSize = CrystalDecisions.Shared.PaperSize.DefaultPaperSize
        'rpt.PrintOptions.PaperOrientation = CrystalDecisions.Shared.PaperOrientation.DefaultPaperOrientation
        'rpt.PrintOptions.PaperSource = CrystalDecisions.Shared.PaperSource.Auto

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
        rpt.DataSourceConnections.Item(0).SetConnection((New ClassConnection).servername, (New ClassConnection).database, False)
        rpt.DataSourceConnections.Item(0).SetLogon((New ClassConnection).Userid, (New ClassConnection).Password)
        rpt.VerifyDatabase()
        rpt.SetParameterValue("@roll_no_d_list", StrollsDList)

        'rpt.PrintOptions.PaperSize = CrystalDecisions.Shared.PaperSize.DefaultPaperSize
        'rpt.PrintOptions.PaperOrientation = CrystalDecisions.Shared.PaperOrientation.DefaultPaperOrientation
        'rpt.PrintOptions.PaperSource = CrystalDecisions.Shared.PaperSource.Auto

        frm.Title = "All Barcode"
        frm.CRViewer.ReportSource = rpt
        frm.MdiParent = Me.ParentForm
        frm.Show()
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub btnSave_Click_1(sender As System.Object, e As System.EventArgs) Handles btnSave.Click
        'Sitthana 20220624 Changed Windows.Forms.DialogResult To DialogResult
        Dim result As DialogResult ' Windows.Forms.DialogResult
        result = MessageBox.Show("Would you like to Save Hanger in?", "System Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button3)
        If result <> DialogResult.Yes Then Exit Sub

        If Not CheckData() Then Exit Sub

        Call SaveHangerIN()
    End Sub

    Private Sub btnPrintDocument_Click(sender As System.Object, e As System.EventArgs) Handles btnPrintDocument.Click

        If txtDocNo.Text.Length = 0 Then Exit Sub

        Const rptFileName = "rptHIN.rpt"

        If clsuser.ReportPath = "" Then clsuser.ReportPath = clsuser.ReportPath
        If Not (New clsConfig).CheckReport(clsuser.ReportPath, rptFileName) Then Exit Sub
        Dim frm As New frmReport
        Dim rpt As New CrystalDecisions.CrystalReports.Engine.ReportDocument
        Me.Cursor = Cursors.WaitCursor
        rpt.Load(clsuser.ReportPath & rptFileName)
        rpt.DataSourceConnections.Item(0).SetConnection((New classConnection).servername, (New classConnection).database, False)
        rpt.DataSourceConnections.Item(0).SetLogon((New classConnection).Userid, (New classConnection).Password)
        rpt.VerifyDatabase()
        rpt.SetParameterValue("@docno", txtDocNo.Text.Trim)


        frm.Title = "Hanger IN"
        frm.CRViewer.ReportSource = rpt
        frm.MdiParent = Me.ParentForm
        frm.Show()
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub ToolStripButton1_Click(sender As System.Object, e As System.EventArgs) Handles btnPrintTagBig.Click
        Call PrintTagFair()
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
    Private Sub clearAllItems()
        Dim i As Integer
        If Me.grdHangerIN.Rows.Count = 0 Then Exit Sub
        Try
            For i = 0 To Me.grdHangerIN.Rows.Count - 1
                If Me.grdHangerIN.Rows(i).Cells("grdHangerINSel").Value = True Then Me.grdHangerIN.Rows(i).Cells("grdHangerINSel").Value = False
            Next
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnClear_Click(sender As System.Object, e As System.EventArgs) Handles btnClear.Click
        Call clearAllItems()
    End Sub
End Class