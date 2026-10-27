Imports System.Data
Imports System.Data.SqlClient

Public Class frmDesignBOMNew
    Dim oConfig As New clsConfig
    Dim clsConn As New classConnection
    Dim clsUser As New classUserInfo
    Dim id_yarnchange As Nullable(Of Int32) = 0
    Dim Design_no As String
    Dim strBomNo As String = ""
    Dim blnCancel As Boolean = False
    Dim scAutoComplete As New AutoCompleteStringCollection
    Dim _BomHeaderID As Nullable(Of Int32) = 0

    Dim dmUomID As Nullable(Of Int64) = Nothing
    Dim dmUom2ID As Nullable(Of Int64) = Nothing
    Dim itemsUOMID As Nullable(Of Int64) = Nothing
    Dim itemsUOM2ID As Nullable(Of Int64) = Nothing

    Public Property UserInfo() As classUserInfo
        Get
            UserInfo = clsUser
        End Get
        Set(ByVal NewValue As classUserInfo)
            clsUser = NewValue
        End Set
    End Property

    Public Property BOMHeaderID() As Nullable(Of Int32)
        Get
            BOMHeaderID = _BomHeaderID
        End Get
        Set(ByVal NewValue As Nullable(Of Int32))
            _BomHeaderID = NewValue
            id_yarnchange = NewValue
        End Set
    End Property

    Private Sub SetControlValue(ByVal Obj As Control)
        If TypeOf Obj Is TextBox Then
            Obj.Text = Obj.Tag
        End If
        If TypeOf Obj Is DateTimePicker Then
            Dim dtp As DateTimePicker = Obj
            dtp.Value = "01/01/1900"
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
    End Sub

    Private Sub InitControl()

        'Call GetItemsAutoComplete() 'Disible By Neung Has Lone time
        Call GenComboDesignBOM()
        Call GenCombo()
        Call populateColorCombo()
        Call GenComboInGrid()

        Dim obj As Control
        For Each obj In Me.Controls
            Call SetControlValue(obj)
        Next
        'ToDO:   Current Hear 
        Call EnabledControl(True)
        ErrorProvider1.Clear()

        id_yarnchange = 0
        dtpBOMDate.Value = Now
        Call LoadData(_BomHeaderID)

        If txtRequiredQty.Text.Trim = "" Then
            txtRequiredQty.Text = "1"
        End If
        cboBOMUsage.SelectedValue = "PROD" 'Sitthana 04/05/2018 -> Set Default to Production
        cboBOMUsage.Enabled = False 'Sitthana 15/05/2018 -> Don't Changed
        txtDesignNo.Focus()
    End Sub

    Private Sub GenComboDesignBOM()
        Dim objDB As New classMaster

        Me.cboDesignBOM.ComboBox.DataSource = objDB.comboYarnChange(clsUser.UserID)
        Me.cboDesignBOM.ComboBox.DisplayMember = "design_bom"
        Me.cboDesignBOM.ComboBox.ValueMember = "id_yarnchange"
        'Me.cboDesignBOM.ComboBox.SelectedIndex = 0
    End Sub

    Private Sub GenCombo()
        Dim objDB As New classMaster

        Me.cbodesign_ver.DataSource = objDB.combov_items_des_mc(clsUser.UserID)
        Me.cbodesign_ver.DisplayMember = "design_no"
        Me.cbodesign_ver.ValueMember = "design_no"
        'Me.cbodesign_ver.AutoCompleteCustomSource = True
        Me.cbodesign_ver.SelectedIndex = -1

        'Sitthana 16/01/2018
        Me.cboBomUOM.DataSource = objDB.GetBOMUOM()
        Me.cboBomUOM.DisplayMember = "uom2"
        Me.cboBomUOM.ValueMember = "uom_id"
        'Me.cboBomUOM.AutoCompleteCustomSource = True
        Me.cboBomUOM.SelectedIndex = -1

        Me.cboBOMUsage.DataSource = objDB.comboBOMUsage(clsUser.UserID)
        Me.cboBOMUsage.DisplayMember = "bom_usage_name"
        Me.cboBOMUsage.ValueMember = "bom_usage_code"
        Me.cboBOMUsage.SelectedIndex = 0

        'Me.itdesc.DataSource = objDB.comboYarn(clsUser.UserID)
        'Me.itdesc.DisplayMember = "itdesc"
        'Me.itdesc.ValueMember = "itdesc"

        'Me.txtDesignNo.DataSource = objDB.comboDesign(clsUser.UserID)
        ' Me.txtDesignNo.DisplayMember = "design_no"
        ' Me.txtDesignNo.ValueMember = "design_no"
        'Me.cbodesign_ver.AutoCompleteCustomSource = True
        ' Me.txtDesignNo.SelectedIndex = -1

        'getDforderItems()

    End Sub

    Private Sub populateColorCombo()
        Dim objDB As New classMaster
        'populateColorCombo()
        Me.cboColor.DataSource = objDB.GetBOMColorWay()
        Me.cboColor.DisplayMember = "col2"
        Me.cboColor.ValueMember = "id"
    End Sub
    Private Sub GenComboInGrid()
        Dim objDB As New classMaster

        Me.itcd.DataSource = objDB.comboYarn(clsUser.UserID)
        Me.itcd.DisplayMember = "itcd2"
        Me.itcd.ValueMember = "itcd"

        'Sitthana 16/01/2018 - Begin
        Me.colUom.DataSource = objDB.GetBOMUOM
        Me.colUom.DisplayMember = "uom2"
        Me.colUom.ValueMember = "uom_id"
        'Sitthana 16/01/2018 - End

        Me.suppcd.DataSource = objDB.comboSupplier(clsUser.UserID)
        Me.suppcd.DisplayMember = "name"
        Me.suppcd.ValueMember = "suppcd"
    End Sub

    Private Sub BindData(ByVal dt As DataTable)
        id_yarnchange = Val(dt.Rows(0)("id_yarnchange"))
        txtDesignNo.Text = dt.Rows(0)("design_no")
        dtpBOMDate.Value = dt.Rows(0)("ynchgdt2")
        txtBOMCode.Text = dt.Rows(0)("ynchgcd")
        txtRemark.Text = dt.Rows(0)("remarke")
        txtRequiredQty.Text = dt.Rows(0)("required_qty") 'Append By Sitthana 16/01/2018
        cboBomUOM.SelectedValue = dt.Rows(0)("rq_bom_uom_id") 'Append By Sitthana 16/01/2018
        cboColor.SelectedValue = dt.Rows(0)("color_id")      'Append By Sitthana 23/12/2017
        cboBOMUsage.SelectedValue = dt.Rows(0)("bom_usage_code")
        txtTotalWithRound.Text = CDbl(dt.Rows(0)("sum_perc"))
        chkApproved.Checked = CBool(dt.Rows(0)("bom_approved"))
        chkEnabled.Checked = CBool(dt.Rows(0)("bom_active"))

        cbodesign_ver.SelectedValue = dt.Rows(0)("design_ver")
        txtBom_remarks.Text = (New clsConfig).IsNull(dt.Rows(0)("bom_remarks"), "")

    End Sub

    Private Sub BindGrid(ByVal dt As DataTable)
        grdData.AutoGenerateColumns = False
        grdData.DataSource = dt
    End Sub

    Private Sub getUOMToVar(ByVal itcd As String)
        'Create By : Sitthana 17/01/2018
        Dim objDB As New classProduction
        Dim dt As DataTable = objDB.getBomFormItemUom(itcd)
        dmUomID = -1
        dmUom2ID = -1
        itemsUOMID = -1
        itemsUOM2ID = -1
        If dt.Rows.Count > 0 Then
            For i As Integer = 0 To dt.Rows.Count - 1
                Select Case dt.Rows(i).Item("tbl")
                    Case "DM"
                        dmUomID = dt.Rows(i).Item("uom_id")
                        dmUom2ID = oConfig.IsNull(dt.Rows(i).Item("uom2_id"), Nothing)
                    Case "ITEMS"
                        itemsUOMID = dt.Rows(i).Item("uom_id")
                        itemsUOM2ID = oConfig.IsNull(dt.Rows(i).Item("uom2_id"), Nothing)
                End Select
            Next
        End If
    End Sub

    Private Sub LoadData(Optional ByVal id_yarnchange As Nullable(Of Int32) = Nothing)
        Dim objDB As New classProduction
        'Dim dt As DataTable = objDB.YarnChangeSelect(id_yarnchange, clsUser.UserID) 'Comment By Sitthana 22/12/2017
        Dim dt As DataTable = objDB.YarnChangeSelectNew(id_yarnchange, clsUser.UserID)  'Append By Sitthana 22/12/2017

        If dt.Rows.Count > 0 Then
            Call BindData(dt)
        End If
        Call BindGrid(dt)
        Call SumgrdData()
    End Sub

    Private Sub CopyData(ByVal id_yarnchange As Nullable(Of Int32), ByVal bom_usage_code As String)
        Dim objDB As New classProduction
        'Dim dt As DataTable = objDB.YarnChangeCopy(id_yarnchange, bom_usage_code, clsUser.UserID)
        Dim dt As DataTable = objDB.YarnChangeCopyNew(id_yarnchange, bom_usage_code, clsUser.UserID)
        If dt.Rows.Count > 0 Then
            Call LoadData(dt.Rows(0)("id_yarnchange"))
        End If
    End Sub

    Private Function SaveData() As Boolean

        Dim clsconfig As New clsConfig
        Dim dtYarnChange As DataTable = grdData.DataSource
        Dim dv_add As New DataView(grdData.DataSource, "", "", DataViewRowState.Added)
        Dim dv_upd As New DataView(grdData.DataSource, "", "", DataViewRowState.ModifiedCurrent)
        Dim dv_del As New DataView(grdData.DataSource, "", "", DataViewRowState.Deleted)


        Dim objBOM As New YarnChange
        Dim objDB As New classProduction
        Dim errmsg As String = ""


        objBOM.design_no = txtDesignNo.Text
        objBOM.ynchgdt = dtpBOMDate.Value.ToString("yyyyMMdd")
        objBOM.ynchgcd = txtBOMCode.Text
        objBOM.remarke = txtRemark.Text
        objBOM.id_yarnchange = id_yarnchange
        objBOM.bom_usage_code = cboBOMUsage.SelectedValue
        objBOM.required_qty = IIf(txtRequiredQty.Text = "", 0, txtRequiredQty.Text)
        'Sitthana 16/01/2018
        If cboBomUOM.Text.Trim = "" Then
            objBOM.uom = "KGS"
            objBOM.bom_uom_id = 1
        Else
            objBOM.uom = cboBomUOM.Text.Trim
            objBOM.bom_uom_id = cboBomUOM.SelectedValue
        End If

        objBOM.bom_active = chkEnabled.Checked
        objBOM.bom_approved = chkApproved.Checked
        objBOM.bom_remarks = RTrim(cbodesign_ver.SelectedValue.ToString) + ""
        objBOM.design_ver = cbodesign_ver.SelectedValue
        objBOM.color_id = cboColor.SelectedValue   'Append By Sitthana 22/12/2017

        'If objDB.YarnChangeUpdate(obj:=objBOM, dt:=grdData.DataSource, dv_del:=dv_del, logempcd:=clsUser.UserID, errmsg:=errmsg) Then 'Comment By Sitthana 22/12/2017
        If objDB.YarnChangeUpdateNew(obj:=objBOM, dt:=grdData.DataSource, dv_del:=dv_del, logempcd:=clsUser.UserID, errmsg:=errmsg) Then  'Append By Sitthana 22/12/2017
            Call GenComboDesignBOM()
            Call LoadData(objBOM.id_yarnchange)
            'Call InitControl()
            MessageBox.Show("Save Completed", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            MessageBox.Show(errmsg, "System Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Function

    Public Function DeleteData(ByVal id_yarnchangedet As Integer) As Boolean
        Dim objDB As New classProduction
        Dim dt As DataTable
        Try
            'dt = objDB.YarnChangeDetDelete(id_yarnchangedet, clsUser.UserID)   'Comment By Sitthana 22/12/2017
            dt = objDB.YarnChangeDetDeleteNew(id_yarnchangedet, clsUser.UserID)    'Append By Sitthana 22/12/2017
            txtTotalNotRound.Text = CalTotalYarn()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "System Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
        Return True
    End Function

    Public Function CalTotalYarn() As Double
        Dim dt As DataTable = grdData.DataSource
        Dim total As Double

        For i As Integer = 0 To dt.Rows.Count - 1
            total += Val(oConfig.IsNull(dt.Rows(i)("ynperc"), 0))
        Next
        Return total
    End Function
    Private Sub SumgrdData()
        Dim config As New clsConfig
        Dim i As Integer = 0
        Dim total1 As Double = 0

        For i = 0 To grdData.Rows.Count - 1
            total1 = total1 + config.IsNull(grdData.Rows(i).Cells("ynperc").Value, 0)
        Next
        txtTotalNotRound.Text = FormatNumber(total1, 0, TriState.False, TriState.False, TriState.True)

    End Sub

    Private Sub frmDesignBOM_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Call InitControl()
        'TODO: BOM FORM: Change procedures for select, delete, update,copy and validate_item in classProduction to new one
        'TODO: BOM FORM: Pass new parameter color id during
        'TODO: BOM FORM: set color_id as selected value to Color way dropdown

    End Sub

    Private Sub frmDesignBOM_FormClosing(sender As System.Object, e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        'If MessageBox.Show("Would you like to exit ?", "System Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = System.Windows.Forms.DialogResult.No Then
        '   e.Cancel = True
        '  End If
    End Sub

    Private Sub btnNew_Click(sender As System.Object, e As System.EventArgs) Handles btnNew.Click
        _BomHeaderID = 0
        Call InitControl()
    End Sub

    Private Sub btnCopy_Click(sender As System.Object, e As System.EventArgs) Handles btnCopy.Click
        If id_yarnchange > 0 Then
            If MessageBox.Show("Would you like to copy ?", "System Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = System.Windows.Forms.DialogResult.Yes Then
                Dim bom_usage_code As String = oConfig.IsNull(cboBOMUsage.SelectedValue, "01")
                id_yarnchange = 0
                _BomHeaderID = 0
                txtBOMCode.Text = ""
                cboColor.SelectedValue = 0
                'Call CopyData(id_yarnchange, bom_usage_code)
            End If
        End If
    End Sub

    Private Sub btnSave_Click(sender As System.Object, e As System.EventArgs) Handles btnSave.Click
        'Fix Error User
        Dim clsConfig As New clsConfig

        For Each obj In Me.Controls
            Call FixControlDataError(obj)
        Next

        If Not CheckData() Then Exit Sub

        If cbodesign_ver.SelectedValue = Nothing Then
            MessageBox.Show("If You are not select Design Ver , Program is Genareate Automatic", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
            cbodesign_ver.SelectedValue = txtDesignNo.Text
        End If

        If grdData.Focus Then txtDesignNo.Focus() ' Add By Neung 20151112


        If MessageBox.Show("Would you like to save ?", "System Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = System.Windows.Forms.DialogResult.Yes Then
            Call SaveData()
        End If
    End Sub

    Private Sub FixControlDataError(ByVal obj As Control)

        If TypeOf obj Is DataGridView Then
            Dim DGV As DataGridView = obj
            If Not DGV.DataSource Is Nothing Then
                If DGV.Rows.Count > 0 And grdData.Focused Then
                    If DGV.CurrentCell.IsInEditMode Then
                        Dim cell As DataGridViewCell = DGV.CurrentCell
                        DGV.EndEdit(DataGridViewDataErrorContexts.Commit)
                        DGV.CurrentCell = grdData.Rows(0).Cells(0)
                        DGV.CurrentCell = cell
                    End If
                End If
            End If
        End If

    End Sub

    Private Function CheckData() As Boolean

        Dim clsconfig As New clsConfig
        If txtDesignNo.Text = "" Then
            MessageBox.Show("Please check PROD. Item Before Saving", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ErrorProvider1.SetError(txtDesignNo, "Please check PROD. Item Before Saving")
            Return False
        End If

        If Not Validate_Design_no() Then
            MessageBox.Show("PROD. Item : " & Design_no & "............   Item Not Valid!!")
            ErrorProvider1.SetError(txtDesignNo, "PROD. Item : " & txtDesignNo.Text.Trim & "............   Item Not Valid!!")
            Return False
        End If

        If clsconfig.IsNull(txtTotalNotRound.Text, 0) <> 100 Then
            MessageBox.Show("Please check Percent Before Saving", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ErrorProvider1.SetError(txtTotalNotRound, "Please check Percent Before Saving")
            Return False
        End If

        'Check Data In Grid
        For i = 0 To grdData.Rows.Count - 2
            If (New clsConfig).IsNull(grdData.Rows(i).Cells("ynperc").Value(), 0) = 0 Then
                MessageBox.Show("Please check Item Percent In Grid Before Saving should be not zero", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
                ErrorProvider1.SetError(grdData, "Please check Item Percent In Grid Before Saving should be not zero")
                Return False
            End If
            'Sitthana 20200817 check Item in line must different Bom Item
            If grdData.Rows(grdData.CurrentRow.Index).Cells("itcd").Value.ToString.Trim = txtDesignNo.Text.Trim Then
                MessageBox.Show("Item in line must different Bom Item", "Warning", MessageBoxButtons.OK)
                ErrorProvider1.SetError(grdData, "Item in line must different Bom Item")
                Return False
            End If
        Next

        'Check Total Percent
        Dim totalreserveqty As Decimal = 0.00
        For Each row As DataGridViewRow In grdData.Rows
            totalreserveqty = totalreserveqty + (New clsConfig).IsNull(row.Cells("ynperc").Value, 0.00)
        Next
        If totalreserveqty <> 100.0 Then
            MessageBox.Show("Sum of Bom Percent should be 100 % ", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ErrorProvider1.SetError(grdData, "Sum of Bom Percent should be 100 % ")
            Return False
        End If

        Return True
    End Function

    Private Function Validate_Design_no() As Boolean
        Dim objDB As New classProduction
        'Dim dt As DataTable = objDB.ValidateDesignNo(txtDesignNo.Text.Trim, clsUser.UserID)   'Comment By Sitthana 22/12/2017
        Dim dt As DataTable = objDB.ValidateDesignNoNew(txtDesignNo.Text.Trim, clsUser.UserID) 'Append By Sitthana 22/12/2017

        If dt.Rows.Count = 0 Then
            Return False
        End If
        Return True
    End Function

    Private Sub btnPrint_Click(sender As System.Object, e As System.EventArgs) Handles btnPrint.Click

        'Const rptFileName = "rptYarnChange.rpt"
        ''If clsuser.ReportPath = "" Then clsuser.ReportPath = clsConfig.ReportPath
        'If Not config.CheckReport(clsUser.ReportPath, rptFileName) Then Exit Sub
        'Dim frm As New frmReport
        'Dim rpt As New CrystalDecisions.CrystalReports.Engine.ReportDocument
        'Dim stype As String = ""
        'Dim ord As String = ""
        'Me.Cursor = Cursors.WaitCursor

        'rpt.Load(clsUser.ReportPath & rptFileName)
        'rpt.DataSourceConnections.Item(0).SetConnection(clsConn.servername, clsConn.database, False)
        'rpt.DataSourceConnections.Item(0).SetLogon(clsConn.Userid, clsConn.Password)
        'rpt.VerifyDatabase()
        'rpt.SetParameterValue("@id_yarnchange", id_yarnchange)
        'rpt.SetParameterValue("@design_no", "")
        'rpt.SetParameterValue("@ynchgcd", "")

        'frm.Title = "Design BOM"
        'frm.CRViewer.ReportSource = rpt
        'frm.MdiParent = Me.ParentForm
        'frm.Show()
        'Me.Cursor = Cursors.Default



        '------------------
        Dim frm As New frmReport
        Dim rpt As New CrystalDecisions.CrystalReports.Engine.ReportDocument
        Dim rptFileName As String

        If id_yarnchange = 0 Then

            rptFileName = "rptMasterBom.rpt"
            'If clsuser.ReportPath = "" Then clsuser.ReportPath = clsConfig.ReportPath
            If Not oConfig.CheckReport(clsUser.ReportPath, rptFileName) Then Exit Sub
            rpt.Load(clsUser.ReportPath & rptFileName)
            rpt.DataSourceConnections.Item(0).SetConnection(clsConn.servername, clsConn.database, False)
            rpt.DataSourceConnections.Item(0).SetLogon(clsConn.Userid, clsConn.Password)
            rpt.VerifyDatabase()
            rpt.SetParameterValue("@id_yarnchange", id_yarnchange)
            rpt.SetParameterValue("@design_no", "")
            rpt.SetParameterValue("@ynchgcd", "")
        Else
            rptFileName = "rptYarnChange.rpt"
            'If clsuser.ReportPath = "" Then clsuser.ReportPath = clsConfig.ReportPath
            If Not oConfig.CheckReport(clsUser.ReportPath, rptFileName) Then Exit Sub
            rpt.Load(clsUser.ReportPath & rptFileName)
            rpt.DataSourceConnections.Item(0).SetConnection(clsConn.servername, clsConn.database, False)
            rpt.DataSourceConnections.Item(0).SetLogon(clsConn.Userid, clsConn.Password)
            rpt.VerifyDatabase()
            rpt.SetParameterValue("@id_yarnchange", id_yarnchange)
            rpt.SetParameterValue("@design_no", "")
            rpt.SetParameterValue("@ynchgcd", "")
        End If

        frm.Title = "Design Bom"
        frm.CRViewer.ReportSource = rpt
        frm.MdiParent = Me.ParentForm
        frm.Show()
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub btnMinimized_Click(sender As System.Object, e As System.EventArgs) Handles btnMinimized.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub btnExit_Click(sender As System.Object, e As System.EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub cboDesignBOM_DropDownClosed(sender As System.Object, e As System.EventArgs) Handles cboDesignBOM.DropDownClosed
        Dim strDesignBOM As String = oConfig.IsNull(cboDesignBOM.ComboBox.SelectedValue, "")

        If strDesignBOM.Length > 0 Then
            Call LoadData(strDesignBOM)
        End If
    End Sub

    'Private Sub grdData_CellClick(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles grdData.CellClick
    'Call SumgrdData()
    ' End Sub

    Private Sub grdData_CellEndEdit(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles grdData.CellEndEdit
        'Try
        With grdData
            Select Case .Columns(e.ColumnIndex).Name'.Columns(e.ColumnIndex).Name.ToString

                Case "itcd" '2
                    'Case 2 Add By Sitthana 22/09/2018 For set supp relate itcd
                    Dim objDB As New classProduction
                    Dim dtsuppcd As DataTable

                    With grdData
                        dtsuppcd = objDB.getSuppcd(.Rows(.CurrentRow.Index).Cells("itcd").Value)

                        If dtsuppcd.Rows.Count = 0 Then
                            .Rows(.CurrentRow.Index).Cells("suppcd").Value = ""
                        Else
                            .Rows(.CurrentRow.Index).Cells("suppcd").Value = dtsuppcd.Rows(0)("suppcd")
                        End If

                        getUOMToVar(oConfig.IsNull(.Rows(e.RowIndex).Cells("itcd").Value, ""))
                        If itemsUOMID <> -1 Then
                            .Rows(e.RowIndex).Cells("colUom").Value = itemsUOMID
                        End If

                        .Rows(e.RowIndex).Cells("itdesc").Value = (New classMaster).getItdesc(.Rows(.CurrentRow.Index).Cells("itcd").Value)

                    End With

                Case "ynperc" '3
                    calColReqdQty(e.RowIndex) 'Sitthana 17/01/2018
            End Select
        End With


        'If grdData.Columns(e.ColumnIndex).Name.Equals("ynperc") Then
        '    'Call SumgrdData()
        '    calColReqdQty(e.RowIndex) 'Sitthana 17/01/2018
        'End If
        Call SumgrdData()
        '  Catch ex As Exception
        '
        ' End Try
    End Sub

    Private Sub grdData_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles grdData.KeyDown
        Try
            If e.KeyCode = Keys.Delete Then
                If grdData.Rows.Count > 2 Then
                    If MessageBox.Show("Would you like to delete yarn code " & Chr(34) & grdData.CurrentRow.Cells("itcd").Value & Chr(34) & " ?", "System Message" _
                                      , MessageBoxButtons.YesNo, MessageBoxIcon.Question
                                       ) = System.Windows.Forms.DialogResult.Yes Then
                        'MessageBox.Show(grdData.CurrentRow.Cells("id_yarnchangedet").Value)
                        Call DeleteData(grdData.CurrentRow.Cells("id_yarnchangedet").Value)
                        'grdData.Rows.RemoveAt(grdData.CurrentRow.Index)
                        Dim strDesignBOM As String = oConfig.IsNull(cboDesignBOM.ComboBox.SelectedValue, "")
                        Call LoadData(strDesignBOM)
                    End If
                Else
                    MessageBox.Show("Last Row Deletion is not allowed." & vbCrLf & "ไม่อนุญาตให้ลบบรรทัดสุดท้าย !!!", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                End If
            End If
            Call SumgrdData()
        Catch ex As Exception

        End Try
    End Sub

    Private Function Validate_Design_no(ByVal StrDesign_no As String) As Boolean
        Dim objDB As New classProduction
        Dim dt As DataTable = objDB.ValidateDesignNo(StrDesign_no, clsUser.UserID)

        If dt.Rows.Count = 0 Then
            Return False
        End If
        Return True
    End Function


    Private Sub txtDesignNo_Validated(sender As Object, e As System.EventArgs)
        'Validate_Design_no()
    End Sub
    'EDIT BY NEUNG 16/01/2015
    'Private Sub getItdesc()
    '    Dim objGetITdesc As New classProduction
    '    Dim dt As DataTable
    '    ' Dim txtkono As String = ""
    '    Dim txtitcd As String = itcd.DataSource
    '    'Validate_kono()
    '    dt = objGetITdesc.getitdesc1("itcd", "logempcd")
    '    If dt.Rows.Count > 0 Then
    '        grdData.Columns(e.ColumnIndex).Name.Equals("itcd") = dt.Rows(0)("itcd")

    '        'Else
    '        ' MsgBox("Prod no. is not found", MsgBoxStyle.OkOnly, "Search")

    '    End If
    'End Sub
    'EDIT BY NEUNG 16/01/2015

    Private Sub BtnCancel_Click(sender As System.Object, e As System.EventArgs) Handles BtnCancel.Click

        If MessageBox.Show("Would you like to Cancel ?", "System Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = System.Windows.Forms.DialogResult.Yes Then
            Call CancelData()
        End If
    End Sub
    Private Function CancelData() As Boolean
        Dim objBOM As New YarnChange
        Dim objDB As New classProduction
        Dim errmsg As String = ""

        objBOM.design_no = txtDesignNo.Text
        objBOM.ynchgdt = dtpBOMDate.Value.ToString("yyyyMMdd")
        objBOM.ynchgcd = txtBOMCode.Text
        objBOM.remarke = txtRemark.Text
        objBOM.id_yarnchange = id_yarnchange
        objBOM.bom_usage_code = cboBOMUsage.SelectedValue
        objBOM.required_qty = 0
        objBOM.uom = ""
        objBOM.bom_active = chkEnabled.Checked
        objBOM.bom_approved = chkApproved.Checked
        objBOM.bom_remarks = ""
        objBOM.bom_uom_id = cboBomUOM.SelectedValue    'Sitthana 17/01/2018


        'If objDB.YarnChangeCancel(objBOM, grdData.DataSource, clsUser.UserID, errmsg) Then     'Comment By Sitthana 22/12/2017
        If objDB.YarnChangeCancelNew(objBOM, grdData.DataSource, clsUser.UserID, errmsg) Then   'Append By Sitthana 22/12/2017
            'Call GenComboDesignBOM()
            Call InitControl()
            Call GenComboDesignBOM()
            Call populateColorCombo()
            MessageBox.Show("Cancel Completed", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            MessageBox.Show(errmsg, "System Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Function

    Private Sub btnSearch_Click(sender As System.Object, e As System.EventArgs) Handles btnSearch.Click
        Dim frm As New frmSearchItems
        frm.ShowDialog(Me)
        Call btnNew_Click(sender, e)

        txtDesignNo.Text = (frm.pid_yarnchange)
        Me.Cursor = Cursors.WaitCursor
        If Not blnCancel Then LoadData(frm.pid_yarnchange)

        Me.Cursor = Cursors.Default
        frm.Dispose()
    End Sub

    Private Sub grdData_CellValidated(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles grdData.CellValidated

    End Sub

    Private Sub grdData_CellValueChanged(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles grdData.CellValueChanged
        'Dim objdb As New classMaster


        'If e.RowIndex < 0 Or e.ColumnIndex < 0 Then Exit Sub

        'If grdData.Columns(e.ColumnIndex).Name = "itcd" Then

        '    grdData.Rows(e.RowIndex).Cells("itdesc").Value = objdb.getItdesc 'In ProCess

        'End If
    End Sub

    Private Sub cbodesign_ver_DropDownClosed(sender As Object, e As System.EventArgs) Handles cbodesign_ver.DropDownClosed
        Dim clsconfig As New clsConfig
        If cbodesign_ver.Text.Length > 0 Then
            txtRemark.Text = cbodesign_ver.Text.ToString.Trim
        End If

        'If Not Validate_Design_no(clsconfig.IsNull(cbodesign_ver.SelectedValue, "")) Then
        '    MessageBox.Show("PROD. Item Ver: " & clsconfig.IsNull(cbodesign_ver.SelectedValue, "").ToString.Trim & "............   Item Not Valid!!")
        '    cbodesign_ver.SelectedIndex = -1
        '    Exit Sub
        'Else
        '    'txtRemark.Text = cbodesign_ver.SelectedValue.ToString
        'End If
    End Sub

    Private Sub cbodesign_ver_LostFocus(sender As Object, e As System.EventArgs) Handles cbodesign_ver.LostFocus
        'If Not Validate_Design_no(cbodesign_ver.Text.Trim) Then
        '    MessageBox.Show("PROD. Item Ver: " & cbodesign_ver.Text.Trim & "............   Item Not Valid!!")
        '    cbodesign_ver.Text = ""
        '    Exit Sub
        'Else
        '    'txtRemark.Text = cbodesign_ver.SelectedValue.ToString
        'End If
    End Sub

    Private Sub cbodesign_ver_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cbodesign_ver.SelectedIndexChanged
        txtBom_remarks.Text = cbodesign_ver.Text.Trim
    End Sub

    Private Sub txtDesignNo_DropDown(sender As Object, e As System.EventArgs)

    End Sub

    Private Sub txtDesignNo_DropDownClosed(sender As Object, e As System.EventArgs)

    End Sub

    Private Sub txtDesignNo_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles txtDesignNo.KeyDown
        If e.KeyCode = Keys.Enter Then
            'cbodesign_ver.SelectedValue = txtDesignNo.Text
            getUOMToVar(txtDesignNo.Text.Trim)  'Sitthana 17/01/2018
            cboBomUOM.SelectedValue = dmUomID         'Sitthana 17/01/2018
        End If
    End Sub

    Private Sub txtDesignNo_LostFocus(sender As Object, e As System.EventArgs)

        'Dim clsconfig As New clsConfig
        'If txtDesignNo.Text.Length > 0 Then

        '    If Not Validate_Design_no(clsconfig.IsNull(txtDesignNo.SelectedValue, "")) Then
        '        MessageBox.Show("PROD. Item: " & clsconfig.IsNull(txtDesignNo.SelectedValue, "").ToString.Trim & "............   Item Not Valid!!")
        '        txtDesignNo.Text = ""
        '        Exit Sub
        '    Else
        '        'txtRemark.Text = cbodesign_ver.SelectedValue.ToString
        '    End If

        '    'cbodesign_ver.SelectedValue = txtDesignNo.Text
        'End If
    End Sub

    Private Sub cbodesign_ver_SelectedValueChanged(sender As Object, e As System.EventArgs) Handles cbodesign_ver.SelectedValueChanged
        'txtRemark.Text = cbodesign_ver.SelectedValue.ToString
    End Sub

    Private Sub BtnDeleteStep_Click(sender As System.Object, e As System.EventArgs) Handles BtnDeleteStep.Click
        GetDeleteStep()
    End Sub

    Private Sub GetDeleteStep()
        If grdData.Rows.Count > 0 Then
            Dim i As Integer = 0
            Dim dt As DataTable = grdData.DataSource
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

        End If
    End Sub

    Private Sub GetItemsAutoComplete()
        Dim connStr As New classConnection
        Dim conn As New SqlConnection(connStr.connection())
        Dim comm As New SqlCommand("", conn)
        Dim da As New SqlDataAdapter(comm)
        'Dim ds As New DataSet
        Dim cmd As New SqlCommand("select itcd from v_items_des_mc order by itcd desc", conn)
        Dim dr As SqlDataReader
        conn.Open()
        dr = cmd.ExecuteReader
        Do While dr.Read
            scAutoComplete.Add(dr.GetString(0))
        Loop
        conn.Close()
        txtDesignNo.AutoCompleteMode = AutoCompleteMode.Suggest
        txtDesignNo.AutoCompleteSource = AutoCompleteSource.CustomSource
        txtDesignNo.AutoCompleteCustomSource = scAutoComplete
    End Sub

    Private Sub txtRequiredQty_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtRequiredQty.KeyPress
        'Insert new sub by Sitthana 17/01/2018
        If e.KeyChar = vbCr Then
            If grdData.Rows.Count > 0 Then
                For i As Integer = 0 To grdData.Rows.Count - 1
                    calColReqdQty(i)
                Next
            End If
        End If
    End Sub
    Private Sub calColReqdQty(rowid As Integer)
        'Insert new sub by Sitthana 17/01/2018
        Dim ynperc As Double = 0
        Dim RequiredQty As Integer = 0

        If txtRequiredQty.Text.Trim = "" Then
            RequiredQty = 1
            txtRequiredQty.Text = "1"
            cboBomUOM.SelectedValue = 5
        Else
            RequiredQty = Convert.ToSingle(txtRequiredQty.Text)
        End If

        With grdData
            ynperc = oConfig.IsNull(.Rows(rowid).Cells("ynperc").Value, 0)
            .Rows(rowid).Cells("ColReqdQty").Value = Convert.ToSingle((ynperc / 100) * RequiredQty)
        End With
    End Sub

    ' Private Sub grdData_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles grdData.CellContentClick
    ' If grdData.CurrentCell.IsInEditMode Then grdData.EndEdit()
    ' End Sub

    Private Sub BtnBomVer_Click(sender As Object, e As EventArgs) Handles BtnBomVer.Click

        If Not grdData.Rows.Count > 0 Then Exit Sub
        If (grdData.CurrentRow.Cells(0).ToString) = "" Then Exit Sub 'Sitthana 24/05/2018
        If cboColor.SelectedIndex = -1 Then Exit Sub

        '=================== Auto Gen When 1 row =====================
        Dim dtdata As DataTable
        dtdata = (New ClassSearchBomVersion).SearchBomVersion(StrItcd:=grdData.CurrentRow.Cells("itcd").Value, Int64ColId:=cboColor.SelectedValue)
        If dtdata.Rows.Count = 1 Then
            MessageBox.Show("ตรวจพบ Color Way เดียว ระบบ จะเลือกให้ อัตโนมัติ", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
            grdData.CurrentRow.Cells("bomversionid").Value = dtdata.Rows("0")("id_yarnchange")
            Exit Sub
        End If
        '================== End =====================================

        '=================== Go to Seach Form =======================
        Dim frm As New frmSearchBomVersion
        frm.PItcd = grdData.CurrentRow.Cells("itcd").Value
        frm.PColID = cboColor.SelectedValue
        frm.ShowDialog(Me)

        If (New clsConfig).IsNull(frm.Pbomversionid, 0) > 0 Then grdData.CurrentRow.Cells("bomversionid").Value = frm.Pbomversionid

        Me.Cursor = Cursors.WaitCursor

        Me.Cursor = Cursors.Default
        frm.Dispose()
    End Sub

    Private Sub grdData_DataError(sender As Object, e As DataGridViewDataErrorEventArgs) Handles grdData.DataError
        'MessageBox.Show("Error happened " & e.Context.ToString())

        If (e.Context = DataGridViewDataErrorContexts.Commit) Then
            MessageBox.Show("Commit error")
        End If
        If (e.Context = DataGridViewDataErrorContexts.CurrentCellChange) Then
            MessageBox.Show("Cell change")
        End If
        If (e.Context = DataGridViewDataErrorContexts.Parsing) Then
            MessageBox.Show("parsing error")
        End If
        If (e.Context = DataGridViewDataErrorContexts.LeaveControl) Then
            MessageBox.Show("leave control error")
        End If

        If (TypeOf (e.Exception) Is ConstraintException) Then
            Dim view As DataGridView = CType(sender, DataGridView)
            view.Rows(e.RowIndex).ErrorText = "an error"
            view.Rows(e.RowIndex).Cells(e.ColumnIndex).ErrorText = "an error"

            e.ThrowException = False
        End If
    End Sub
End Class