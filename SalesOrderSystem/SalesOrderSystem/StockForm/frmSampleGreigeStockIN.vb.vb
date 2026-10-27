Public Class frmSampleGreigeStockIN
    Dim clsconn As New classConnection
    Dim clsconfig As New clsConfig
    Dim clsuser As New classUserInfo

    Dim dtStockD As New DataTable
    Dim bsStockD As New BindingSource

    Dim dtDoutNew As New DataTable
    Dim bsDoutNew As New BindingSource

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
        Set(ByVal Newvalue As classUserInfo)
            clsuser = Newvalue
        End Set
    End Property

    Private Sub frmSampleStockINFromGregieOut_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
        Call InitControl()
        Call GenCombo()
        Call InitDataBinding()
        Call LoadGrdDoutStock()

        'Call Loaddata()
        'Call BindDINReturn(grdStockD, (New classStockDINReturn).GetDINReturn("0", clsuser.UserID))
        ' Call BindDINReturn(grdStockD, (New classStockDINReturn).GetDINReturn("0", clsuser.UserID))
    End Sub
    Private Sub Loaddata()


    End Sub
    Private Sub InitControl()
        Dim obj As Control
        For Each obj In Me.Controls
            Call SetControlValue(obj)
        Next
        Call EnabledControl(True)
        Call SetErrorProvider()
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

    Private Sub grdStockD_CellContentClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles grdStockD.CellContentClick
        If grdStockD.CurrentCell.IsInEditMode Then grdStockD.EndEdit()
    End Sub

    Private Sub GenCombo()

        'cboDinNo.ComboBox.DataSource = (New classStockDINReturn).GetComboDINNO()
        'cboDinNo.ComboBox.DisplayMember = "dinno"
        'cboDinNo.ComboBox.ValueMember = "dinno"
        'cboDinNo.ComboBox.SelectedIndex = -1

        dtMtlWarehouse = (New classMaster).Combomtlwarehouse()
        bsMtlWarehouse.DataSource = dtMtlWarehouse
        cbomtlWarehouse.DataSource = bsMtlWarehouse.DataSource
        cbomtlWarehouse.DisplayMember = "warehouse_code"
        cbomtlWarehouse.ValueMember = "mtl_warehouse_id"

        dtMtlSubInventory = (New classMaster).ComboMtlsubinventory(INt64mtl_warehouse_id:=(New clsConfig).IsNull(cbomtlWarehouse.SelectedValue, Nothing))
        bsMtlSubInventory.DataSource = dtMtlSubInventory
        cbomtlSubinventory.DataSource = bsMtlSubInventory.DataSource
        cbomtlSubinventory.DisplayMember = "subinventory_code"
        cbomtlSubinventory.ValueMember = "mtl_subinventory_id"

        dtmtlLocations = (New classMaster).Combomtllocations(INt64mtl_warehouse_id:=(New clsConfig).IsNull(cbomtlWarehouse.SelectedValue, Nothing), Int64mtl_subinventory_id:=(New clsConfig).IsNull(cbomtlSubinventory.SelectedValue, Nothing))
        bsMtlLocations.DataSource = dtmtlLocations
        cbomtlLocations.DataSource = bsMtlLocations.DataSource
        cbomtlLocations.DisplayMember = "location_name"
        cbomtlLocations.ValueMember = "mtl_locations_id"

        CboDocType.DataSource = (New classMaster).GetDocType
        CboDocType.DisplayMember = "name"
        CboDocType.ValueMember = "doctyp"
        CboDocType.SelectedValue = "M"
        CboDocType.Enabled = False


    End Sub

    Private Sub InitDataBinding()

        'dtDoutNew = (New classSampleStockINFromGreigeOut).GetGridDoutNewByOutno(StrOutno:=txtOutNo.Text.Trim)

        'bsDoutNew.DataSource = dtDoutNew

        Call BindingData() '
    End Sub

    Private Sub BindingData()
        Call ClearDataBindings()

        'txtaddr1.DataBindings.Add("text", bsCboCustomer, "addr1")
        'txtOutno.DataBindings.Add("text", bsDoutNew, "outno")
        'dtpOutDt.DataBindings.Add("Value", bsDoutNew, "outdt")
        'cboCustomer.DataBindings.Add("SelectedValue", bsDoutNew, "customer_id")

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

    Private Sub LoadGrdDoutStock()

        Dim dt As DataTable = (New classSampleGreigeStockIN).GetDINReturn(strdinNo:=txtDinno.Text.Trim, strEmpCode:=clsuser.UserID)
        Call BindGrdDoutStock(dt)

    End Sub

    Private Sub BindGrdDoutStock(ByVal dt As DataTable)
        dtStockD = dt
        bsStockD.DataSource = dtStockD

        If dt.Rows.Count > 0 Then 'Add By Neung 20190308
            cbomtlWarehouse.SelectedValue = dtStockD.Rows(0)("mtl_warehouse_id")
            cbomtlWarehouse_DropDownClosed(Nothing, Nothing)
            cbomtlSubinventory.SelectedValue = dtStockD.Rows(0)("mtl_subinventory_id")
            cbomtlSubinventory_DropDownClosed(Nothing, Nothing)
            cbomtlLocations.SelectedValue = dtStockD.Rows(0)("mtl_locations_id")
        End If 'Add By Neung 20190308

        grdStockD.AutoGenerateColumns = False
        grdStockD.DataSource = bsStockD.DataSource

    End Sub

    Private Sub txtOutNo_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles txtOutNo.KeyDown
        If e.KeyCode = Keys.Enter Then
            dtDoutNew = (New classSampleGreigeStockIN).GetDOutReturn(strOutNo:=txtOutNo.Text.Trim, strEmpCode:=Userinfo.UserID)
            bsDoutNew.DataSource = dtDoutNew
            bsDoutNew.MoveFirst()

            Call AddRollNo()

            txtOutNo.Focus()
        End If
    End Sub

    Private Sub txtOutNo_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtOutNo.TextChanged

    End Sub

    Private Sub btnSearchOutNo_Click(sender As System.Object, e As System.EventArgs) Handles btnSearchOutNo.Click
        Dim frm As New frmSearchDOUT
        frm.ShowDialog(Me)
        txtOutNo.Text = (frm.pOutno.ToUpper.Trim.ToUpper)

        Me.Cursor = Cursors.WaitCursor
        If txtOutNo.Text.Trim.Length > 0 Then
            dtDoutNew = (New classSampleGreigeStockIN).GetDOutReturn(strOutNo:=txtOutNo.Text.Trim, strEmpCode:=Userinfo.UserID)
            bsDoutNew.DataSource = dtDoutNew
            bsDoutNew.MoveFirst()

            Call AddRollNo()

            txtOutNo.Focus()
        End If
        Call AddRollNo()
        'If Getoutno(txtOutNo.Text) Then

        'End If

        Me.Cursor = Cursors.Default
        frm.Dispose()
    End Sub

    Private Function Getoutno(ByRef Stroutno As String) As Boolean
        ' Dim dt As DataTable = (New classStockDINReturn).GetDOutReturn(Stroutno, clsuser.UserID)
        'If dt.Rows.Count > 0 Then
        'Call BindDataDoutReturn(dt)
        'Call SumGrid()
        'End If

    End Function

    Private Sub AddRollNo()
        If dtDoutNew.Rows.Count > 0 Then
            Dim config As New clsConfig
            Dim dr As DataRow
            Dim msg As String = ""
            Dim i As Integer = 0
            Dim j As Integer = 0
            For i = 0 To dtDoutNew.Rows.Count - 1
                'If Not CheckDuplicate(dtHangerINBarcodeNew.Rows(i)("id_strolls_d_o").ToString.Trim, dtHangerINNew.Copy()) Then

                dr = dtStockD.NewRow

                For j = 0 To dtDoutNew.Columns.Count - 1
                    dr(dtDoutNew.Columns(j).ColumnName.Trim) = dtDoutNew.Rows(i)(dtDoutNew.Columns(j).ColumnName.Trim)
                Next

                dtStockD.Rows.Add(dr)
                'End If
            Next
        End If
        ' Call SumGrid()
    End Sub

    Private Sub btnSave_Click(sender As System.Object, e As System.EventArgs) Handles btnSave.Click

        'Sitthana 20220624 Changed Windows.Forms.DialogResult To DialogResult
        Dim result As DialogResult ' Windows.Forms.DialogResult
        result = MessageBox.Show("Would you like to save ?", "System Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button3)
        If result <> DialogResult.Yes Then Exit Sub

        If Not CheckData() Then Exit Sub

        Call SaveSampleGIN()
    End Sub

    Private Function CheckData() As Boolean

        ' Dim dt As DataTable = grdStockD.DataSource

        '============= Check Slect row > 1 =============================
        Dim i As Integer = 0
        For Each row As DataGridViewRow In grdStockD.Rows
            Dim chk As DataGridViewCheckBoxCell = row.Cells("selected")
            If row.Cells("selected").Value = True Then
                i = i + 1
            End If
        Next
        If i = 0 Then
            MsgBox("Must be select one roll or more then")
            Return False
        End If

        '===============================================================

        '--============= Check Combo Box ============================
        If clsconfig.IsNull(cbomtlWarehouse.SelectedValue, 0) = 0 Then
            MsgBox("WareHouse is incorrect, please select")
            Return False
        End If
        If clsconfig.IsNull(cbomtlSubinventory.SelectedValue, 0) = 0 Then
            MsgBox("SubInventory is incorrect, please select")
            Return False
        End If
        If clsconfig.IsNull(cbomtlLocations.SelectedValue, 0) = 0 Then
            MsgBox("SubInventory is incorrect, please select")
            Return False
        End If


        Return True
    End Function

    Private Function SaveSampleGIN() As Boolean
        Dim config As New clsConfig



        clsconfig.ChangeCulture()
        Dim objdb As New classSampleGreigeStockIN
        Dim msgerr As String = ""
        Dim DINNo As String = Me.txtDinno.Text.Trim
        Dim DINheader As New classSampleGreigeStockIN.DINHeader

        DINheader.h01_dinno = Me.txtDinno.Text.Trim
        DINheader.h02_dindt = Me.dtpDINDate.Value
        DINheader.h03_doctyp = CboDocType.SelectedValue
        DINheader.h04_dhcod = "GK"
        'Din_header.h05_dhdono = Me.txtBillNo.Text.Trim
        'Din_header.h06_dhdodt = Me.dtpdodt.Value
        DINheader.h07_dfno = txtOutNo.Text.Trim
        'Din_header.h08_dono = ""
        'If txtBillNo.Text.Trim = "" Then Din_header.h09_dodt = ""
        'If txtBillNo.Text.Trim <> "" Then Din_header.h09_dodt = dtpdodt.Value
        'Din_header.h09_dodt = ""
        'Din_header.h10_design_no = ds.Tables("v_strolls_d").Rows(0).Item("design_no").ToString.Trim
        'Din_header.h13_lot = ""
        'Din_header.h14_yr = ""
        'Din_header.h15_sh = ""
        'Din_header.h16_col = ""
        'Din_header.h17_Gr = ""
        'Din_header.h18_mtkg = 0
        'Din_header.h19_roll_no_d
        'Din_header.h34_lotbatno = ""
        'Din_header.h36_loc = ""
        'Din_header.h38_batch = ""
        'Din_header.h45_unit = ""

        For Each row As DataGridViewRow In grdStockD.Rows
            Dim chk As DataGridViewCheckBoxCell = row.Cells("selected")
            If row.Cells("selected").Value = True Then
                row.Cells("mtl_warehouse_id").Value = cbomtlWarehouse.SelectedValue
                row.Cells("mtl_subinventory_id").Value = cbomtlSubinventory.SelectedValue
                row.Cells("mtl_locations_id").Value = cbomtlLocations.SelectedValue
            End If
        Next

        Dim dtc As DataTable = grdStockD.DataSource

        Dim dv_dtc_add As New DataView(dtc, "", "", DataViewRowState.Added)
        Dim dv_dtc_upd As New DataView(dtc, "", "", DataViewRowState.ModifiedCurrent)
        Dim dv_dtc_del As New DataView(dtc, "", "", DataViewRowState.Deleted)

        If (New classSampleGreigeStockIN).SampleGreigeINSave(DINheader, msgerr, dtc, dv_dtc_add, dv_dtc_upd, dv_dtc_del, clsuser.UserID, DINNo) Then
            txtDinno.Text = DINNo
            MessageBox.Show("บันทึกสำเร็จ", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
            Call LoadGrdDoutStock()
            SaveSampleGIN = True
        Else
            MessageBox.Show(msgerr, "System Message", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
            SaveSampleGIN = False
        End If

    End Function

    Private Sub btnNew_Click(sender As System.Object, e As System.EventArgs) Handles btnNew.Click
        Me.WindowState = FormWindowState.Maximized
        Call InitControl()
        Call GenCombo()
        Call InitDataBinding()
        Call LoadGrdDoutStock()

    End Sub

    Private Sub btnPrint_Click(sender As System.Object, e As System.EventArgs) Handles btnPrint.Click
        Dim clsConfig As New clsConfig
        Dim rptFileName = "rptSIN.rpt"
        If clsuser.ReportPath = "" Then clsuser.ReportPath = clsuser.ReportPath
        'clsUser.ReportPath = "C:\Users\DELL\Desktop\GemmaKnits\"
        If Not clsConfig.CheckReport(clsuser.ReportPath, rptFileName) Then Exit Sub
        Dim frm As New frmReport
        Dim rpt As New CrystalDecisions.CrystalReports.Engine.ReportDocument
        Dim stype As String = ""
        Dim ord As String = ""
        Me.Cursor = Cursors.WaitCursor

        rpt.Load(clsuser.ReportPath & rptFileName)
        rpt.DataSourceConnections.Item(0).SetConnection(clsconn.servername, clsconn.database, False)
        rpt.DataSourceConnections.Item(0).SetLogon(clsconn.Userid, clsconn.Password)
        rpt.VerifyDatabase()
        rpt.SetParameterValue("@dinnofr", txtDinno.Text.Trim)
        rpt.SetParameterValue("@dinnoto", txtDinno.Text.Trim)
        'rpt.PrintOptions.PaperSize = CrystalDecisions.Shared.PaperSize.PaperA4
        'rpt.PrintOptions.PaperOrientation = CrystalDecisions.Shared.PaperOrientation.Portrait
        'rpt.PrintOptions.PaperSource = CrystalDecisions.Shared.PaperSource.Auto

        frm.Title = "DIN Document"
        frm.CRViewer.ReportSource = rpt
        frm.MdiParent = Me.ParentForm
        frm.Show()
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub cbomtlWarehouse_DropDownClosed(sender As Object, e As System.EventArgs) Handles cbomtlWarehouse.DropDownClosed
        dtMtlSubInventory = (New classMaster).ComboMtlsubinventory(INt64mtl_warehouse_id:=(New clsConfig).IsNull(cbomtlWarehouse.SelectedValue, Nothing))
        bsMtlSubInventory.DataSource = dtMtlSubInventory
        cbomtlSubinventory.DataSource = bsMtlSubInventory.DataSource
        cbomtlSubinventory.DisplayMember = "subinventory_code"
        cbomtlSubinventory.ValueMember = "mtl_subinventory_id"
        bsMtlSubInventory.Filter = "mtl_warehouse_id = '" & (New clsConfig).IsNull(cbomtlWarehouse.SelectedValue, 0) & "' and sample_subinventory = 'Y'"
        dtmtlLocations = (New classMaster).Combomtllocations(INt64mtl_warehouse_id:=(New clsConfig).IsNull(cbomtlWarehouse.SelectedValue, Nothing), Int64mtl_subinventory_id:=(New clsConfig).IsNull(cbomtlSubinventory.SelectedValue, Nothing))
        bsMtlLocations.DataSource = dtmtlLocations
        cbomtlLocations.DataSource = bsMtlLocations.DataSource
        cbomtlLocations.DisplayMember = "location_name"
        cbomtlLocations.ValueMember = "mtl_locations_id"
        bsMtlLocations.Filter = "mtl_warehouse_id = '" & (New clsConfig).IsNull(cbomtlWarehouse.SelectedValue, 0) & "' and mtl_subinventory_id = '" & (New clsConfig).IsNull(cbomtlSubinventory.SelectedValue, 0) & "'"

    End Sub

    Private Sub cbomtlWarehouse_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cbomtlWarehouse.SelectedIndexChanged

    End Sub

    Private Sub cbomtlSubinventory_DropDownClosed(sender As Object, e As System.EventArgs) Handles cbomtlSubinventory.DropDownClosed
        dtmtlLocations = (New classMaster).Combomtllocations(INt64mtl_warehouse_id:=(New clsConfig).IsNull(cbomtlWarehouse.SelectedValue, Nothing), Int64mtl_subinventory_id:=(New clsConfig).IsNull(cbomtlSubinventory.SelectedValue, Nothing))
        bsMtlLocations.DataSource = dtmtlLocations
        cbomtlLocations.DataSource = bsMtlLocations.DataSource
        cbomtlLocations.DisplayMember = "location_name"
        cbomtlLocations.ValueMember = "mtl_locations_id"
        bsMtlLocations.Filter = "mtl_warehouse_id = '" & (New clsConfig).IsNull(cbomtlWarehouse.SelectedValue, 0) & "' and mtl_subinventory_id = '" & (New clsConfig).IsNull(cbomtlSubinventory.SelectedValue, 0) & "'"

    End Sub

    Private Sub cbomtlSubinventory_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cbomtlSubinventory.SelectedIndexChanged

    End Sub

    Private Sub txtDinno_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtDinno.TextChanged

    End Sub

    Private Sub txtDinno_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles txtDinno.KeyDown

    End Sub

    Private Sub BtnPrintBarcode_Click(sender As Object, e As EventArgs) Handles BtnPrintBarcode.Click

        If txtDinno.Text.Trim.Length = 0 Then
            MessageBox.Show("คุณยังไมได้ทำ DIN", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
            Exit Sub
        End If

        Dim clsConfig As New clsConfig
        Dim rptFileName = "rptStockDBarcode.rpt"
        If clsuser.ReportPath = "" Then clsuser.ReportPath = clsuser.ReportPath
        If Not clsConfig.CheckReport(clsuser.ReportPath, rptFileName) Then Exit Sub
        Dim frm As New frmReport
        Dim rpt As New CrystalDecisions.CrystalReports.Engine.ReportDocument
        Dim stype As String = ""
        Dim ord As String = ""
        Me.Cursor = Cursors.WaitCursor

        rpt.Load(clsuser.ReportPath & rptFileName)
        rpt.DataSourceConnections.Item(0).SetConnection(clsconn.servername, clsconn.database, False)
        rpt.DataSourceConnections.Item(0).SetLogon(clsconn.Userid, clsconn.Password)
        rpt.VerifyDatabase()
        rpt.SetParameterValue("@roll_no", txtDinno.Text)
        rpt.SetParameterValue("@loc", "")
        rpt.SetParameterValue("@logempcd", Userinfo.UserID)

        'rpt.PrintOptions.PaperSize = CrystalDecisions.Shared.PaperSize.PaperLetter
        'rpt.PrintOptions.PaperOrientation = CrystalDecisions.Shared.PaperOrientation.Portrait
        'rpt.PrintOptions.PaperSource = CrystalDecisions.Shared.PaperSource.Auto

        frm.Title = "Greige Barcode"
        frm.CRViewer.ReportSource = rpt
        frm.MdiParent = Me.ParentForm
        frm.Show()
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub btnSearchDinNo_Click(sender As Object, e As EventArgs) Handles btnSearchDinNo.Click
        Dim dlginNoSearch As New DlgGetMasterCode("DinNo")
        dlginNoSearch.pDinNo = txtDinno.Text.Trim
        dlginNoSearch.ShowDialog(Me)
        txtDinno.Text = dlginNoSearch.pDinNo
        If txtDinno.Text.Trim <> "" Then
            Call LoadGrdDoutStock()
            'btnSave.Enabled = False
        End If
    End Sub
End Class