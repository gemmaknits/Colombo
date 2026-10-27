Imports System.Data
Imports System.Data.SqlClient
Imports System.Text

Public Class frmYarnInPurchase
        Dim oYarnInPurchase As New classYarnInPurchase
    ' Public loginEmpcd As String
    Dim clsYarn As New GetDataYarn
    Dim clsMaster As New classMaster
    Dim oConfig As New clsConfig
    Dim jobID As Long = 0
    Dim jobQty As Single = 0
    Dim jobWareHouseID As Int64 = 0
    Dim jobSubInventoryID As Int64 = 0
    Dim netKg As Single = 0
    Dim docno As String = ""
    Dim stritcd As String
    Dim clsUser As New classUserInfo
    Dim dtYarnIn As New DataTable

    Dim bsJob As New BindingSource
    Dim bsYarnIn As New BindingSource
    Dim bsYarnInText As New BindingSource

    Dim dtMtlWarehouse As New DataTable
    Dim bsMtlWarehouse As New BindingSource
    Dim dtMtlSubInventory As New DataTable
    Dim bsMtlSubInventory As New BindingSource
    Dim dtmtlLocations As New DataTable
    Dim bsMtlLocations As New BindingSource

    Public Property UserInfo() As classUserInfo
        Get
            UserInfo = clsUser
        End Get
        Set(ByVal NewValue As classUserInfo)
            clsUser = NewValue
        End Set
    End Property



    Private Sub GenCombo()
        Dim dt As DataTable = clsYarn.GetSupplier()
        cboSupplier.DataSource = dt
        cboSupplier.DisplayMember = "name"
        cboSupplier.ValueMember = "suppcd"
        cboSupplier.SelectedIndex = 0

        dt = clsYarn.getItems()
        cboITCD.DataSource = dt
        cboITCD.DisplayMember = "itcd_desc"
        cboITCD.ValueMember = "itcd"


        dtMtlWarehouse = (New classYarnInPurchase).selectMtlwarehouseList()
        bsMtlWarehouse.DataSource = dtMtlWarehouse
        cbomtlWarehouse.DataSource = bsMtlWarehouse.DataSource
        cbomtlWarehouse.DisplayMember = "warehouse_code"
        cbomtlWarehouse.ValueMember = "mtl_warehouse_id"

        dtMtlSubInventory = (New classYarnInPurchase).ComboMtlsubinventory(0)
        bsMtlSubInventory.DataSource = dtMtlSubInventory
        cbomtlSubinventory.DataSource = bsMtlSubInventory.DataSource
        cbomtlSubinventory.DisplayMember = "subinventory_code"
        cbomtlSubinventory.ValueMember = "mtl_subinventory_id"

        dtmtlLocations = (New classYarnInPurchase).Combomtllocations(INt64mtl_warehouse_id:=0, Int64mtl_subinventory_id:=0)
        bsMtlLocations.DataSource = dtmtlLocations
        cbomtlLocations.DataSource = bsMtlLocations.DataSource
        cbomtlLocations.DisplayMember = "location_name"
        cbomtlLocations.ValueMember = "mtl_locations_id"
    End Sub

    Private Sub LoadDataJOB(ByVal jobno As String)
        Dim dt As DataTable '= clsYarn.getJob(jobno) 'Neung 20251022
        dt = oYarnInPurchase.selectJobDetRecord(jobno) 'Neung 20251022
        '========================== Include in Stroprocedue By Neung =====================
        ' If txtPONo.Text = ("FREE SAMPLE") Or txtPONo.Text = ("FREE OF CHARGE") Or txtPONo.Text = ("ADJUST") Then
        'grdYarnIN.Columns(1).ReadOnly = False
        'dt = clsYarn.getJobFree(jobno)
        'Else
        'dt = clsYarn.getJob(jobno)
        ' End If
        '========================================================================

        If dt.Rows.Count > 0 Then
            bsJob.DataSource = dt
            dgvPO.AutoGenerateColumns = False
            dgvPO.DataSource = bsJob.DataSource


            jobID = oConfig.IsNull(dt.Rows(0).Item("id_jobdet"), 0)
            cboSupplier.SelectedValue = dt.Rows(0).Item("suppcd")
        End If
    End Sub

    Private Sub LoadDataYarn(ByVal docno As String)

        ' dtYarnIn = clsYarn.GetData_YarnIn9(docno, "")
        dtYarnIn = oYarnInPurchase.selectYarnInDetRecord(docno, "")

        ' If dt.Rows.Count > 0 Then
        If Not bsYarnIn Is Nothing Then
            ' bsYarnIn.Clear()
        End If


        'Dim obj As Control
        'For Each obj In Me.Controls
        '    ClearDataBindings(obj)
        'Next

        'bsYarnIn.DataSource = dtYarnIn
        'bsYarnInText.DataSource = dt.Copy

        'bsYarnIn.MoveFirst()

        dgvYarnIN.AutoGenerateColumns = False
        dgvYarnIN.DataSource = dtYarnIn 'bsYarnIn.DataSource

        'Me.docno = docno

        ' Call SetDataBindings()
        'Call SetDataBindings()
        'txtDocNo.DataBindings.Clear()
        ' txtDocNo.DataBindings.Add("Text", bsYarnIn, "docno")
        txtDocNo.Text = docno.Trim.ToUpper
        'Call LoadDataJOB(clsConfig.IsNull(dt.Rows(0)("purno"), ""))
        Call SumGrid(dtYarnIn)
        Call BindDataText(dtYarnIn)
        'End If
    End Sub

    Private Sub ClearDataBindings(ByVal obj As Control)

        If TypeOf obj Is TextBox Then
            Dim textbox As TextBox = obj
            If Not textbox.DataBindings Is Nothing Then textbox.DataBindings.Clear()
        End If

        'obj.DataBindings.Clear()
        If TypeOf obj Is DateTimePicker Then
            Dim DateTimePicker As DateTimePicker = obj
            If Not DateTimePicker Is Nothing Then DateTimePicker.DataBindings.Clear()
        End If

        If TypeOf obj Is ComboBox Then
            Dim ComboBox As ComboBox = obj
            If Not ComboBox.DataBindings Is Nothing Then ComboBox.DataBindings.Clear()
        End If

        If TypeOf obj Is CheckBox Then
            Dim checkbox As CheckBox = obj
            checkbox.DataBindings.Clear()
        End If

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
            If Obj.Name = "cboPackAfterBulkApp" Then
                cbo.SelectedValue = 0
            ElseIf Obj.Name = "cboMtl_warehouse" Then
                cbo.SelectedIndex = -1
            ElseIf Obj.Name = "cbofulfilment_type" Then
                cbo.SelectedIndex = -1
            Else
                cbo.SelectedValue = " "
            End If
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

    Private Sub SetDataBindings()


        If Not txtDocNo.DataBindings Is Nothing Then txtDocNo.DataBindings.Clear()
        If Not dtpDocDate.DataBindings Is Nothing Then dtpDocDate.DataBindings.Clear()
        If Not txtPONo.DataBindings Is Nothing Then txtPONo.DataBindings.Clear()
        If Not cboSupplier.DataBindings Is Nothing Then cboSupplier.DataBindings.Clear()
        If Not txtSuppInvNo.DataBindings Is Nothing Then txtSuppInvNo.DataBindings.Clear()
        If Not dtpSinvdt.DataBindings Is Nothing Then dtpSinvdt.DataBindings.Clear()
        If Not txtSuppLot.DataBindings Is Nothing Then txtSuppLot.DataBindings.Clear()

        txtDocNo.DataBindings.Add("Text", bsYarnIn.DataSource, "docno")
        dtpDocDate.DataBindings.Add("Value", bsYarnIn.DataSource, "docdt2")
        txtPONo.DataBindings.Add("Text", bsYarnIn.DataSource, "purno")
        cboSupplier.DataBindings.Add("SelectedValue", bsYarnIn.DataSource, "suppcd")
        txtSuppInvNo.DataBindings.Add("Text", bsYarnIn.DataSource, "sinvno")
        dtpSinvdt.DataBindings.Add("Value", bsYarnIn.DataSource, "sinvdt")
        txtSuppLot.DataBindings.Add("Text", bsYarnIn.DataSource, "lotno_sup")

        'txtSuppRefNo.Text = clsConfig.IsNull(dt.Rows(0)("srefno"), "")
        'txtRemark.Text = clsConfig.IsNull(dt.Rows(0)("remark"), "")
    End Sub



    Private Sub BindDataText(ByVal dt As DataTable)
        If dt.Rows.Count > 0 Then
            dtpDocDate.Value = CDate(dt.Rows(0)("docdt2"))
            txtPONo.Text = oConfig.IsNull(dt.Rows(0)("purno"), "")
            cboSupplier.SelectedValue = dt.Rows(0)("suppcd")
            txtSuppInvNo.Text = oConfig.IsNull(dt.Rows(0)("sinvno"), "")
            ' txtSuppInvDate.Text = clsConfig.IsNull(dt.Rows(0)("sinvdt"), "23/07/2015")
            dtpSinvdt.Value = oConfig.IsNull(dt.Rows(0)("sinvdt"), Now)
            txtSuppLot.Text = oConfig.IsNull(dt.Rows(0)("lotno_sup"), "")
            txtSuppRefNo.Text = oConfig.IsNull(dt.Rows(0)("srefno"), "")
            txtRemark.Text = oConfig.IsNull(dt.Rows(0)("remark"), "")
            cbomtlWarehouse.SelectedValue = dt.Rows(0)("mtl_warehouse_id")
            cbomtlSubinventory.SelectedValue = dt.Rows(0)("mtl_subinventory_id")
            cbomtlLocations.SelectedValue = dt.Rows(0)("mtl_locations_id")
        Else
            dtpDocDate.Value = CDate(Now)
            txtPONo.Text = ""
            cboSupplier.SelectedIndex = -1
            txtSuppInvNo.Text = ""
            ' txtSuppInvDate.Text = clsConfig.IsNull(dt.Rows(0)("sinvdt"), "23/07/2015")
            dtpSinvdt.Value = CDate(Now)
            txtSuppLot.Text = ""
            txtSuppRefNo.Text = ""
            txtRemark.Text = ""



        End If

    End Sub

    Private Sub SumGrid(ByVal dt As DataTable)
        Dim spools As Single = 0
        Dim kg_gr As Single = 0
        Dim kg_nt As Single = 0
        If Not dt Is Nothing Then
            If Not IsDBNull(dt) And dt.Rows.Count > 0 Then
                For i As Integer = 0 To dt.Rows.Count - 1
                    spools += Val(oConfig.IsNull(dt.Rows(i).Item("spools"), 0))
                    kg_gr += Val(oConfig.IsNull(dt.Rows(i).Item("kg_gr"), 0))
                    kg_nt += Val(oConfig.IsNull(dt.Rows(i).Item("kg_nt"), 0))

                Next
                txtTotalBoxes.Text = FormatNumber(dt.Rows.Count, 0, TriState.False, TriState.False, TriState.False)
                txtTotalTubes.Text = FormatNumber(spools, 0, TriState.False, TriState.False, TriState.False)
                txtTotalGrossWeight.Text = FormatNumber(kg_gr, 2, TriState.False, TriState.False, TriState.False)
                txtTotalNetWeight.Text = FormatNumber(kg_nt, 2, TriState.False, TriState.False, TriState.False)
                netKg = kg_nt
            End If
        End If
    End Sub
    Private Function CheckActualConeWeight() As Boolean

        Dim dt As DataTable = dgvYarnIN.DataSource
        If dt.Rows.Count > 0 Then
            For i = 0 To dt.Rows.Count - 1
                If oConfig.IsNull(dt.Rows(i)("actual_cone_weight"), 0) = 0 Then

                    Return False
                    Exit Function
                End If
            Next

        End If
        Return True

    End Function

    Private Sub SaveDataYarn()

        'For i = 0 To grdYarnIN.Rows.Count - 1
        '    If clsConfig.IsNull(Me.grdYarnIN.Rows(i).Cells("mtl_warehouse_id").Value, 0) = 0 Then
        '        MessageBox.Show("ต้องมี WareHouse ", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)

        '    End If

        '    If Me.grdYarnIN.Rows(i).Cells("cboITCD").Value.ToString.Substring(0, 3) = "YRA" And _
        '        clsConfig.IsNull(Me.grdYarnIN.Rows(i).Cells("mtl_subinventory_id").Value, 0) = 0 Then
        '        MessageBox.Show("ต้องมี Subinventory  ", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
        '    End If
        'Next


        If txtDocNo.Text.Trim.Length > 0 Then
            Exit Sub
        End If
        'Fix User Not End Edit
        dgvYarnIN.EndEdit(DataGridViewDataErrorContexts.Commit)
        dgvYarnIN.CurrentCell = dgvYarnIN.Rows(0).Cells(0)

        If Not CheckActualConeWeight() Then MessageBox.Show("ถ้าไม่ได้ใส่ Actual Cone Weight โปรแกรมจะดึงข้อมูลจาก Net weight หารด้วย Spool ", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Information)

        For Each row As DataGridViewRow In dgvYarnIN.Rows
            row.Cells("loc").Value = row.Cells("mtl_locations_id").FormattedValue.ToString
        Next

        'For i = 0 To grdYarnIN.Rows.Count - 1
        '    grdYarnIN.Rows(i).Cells("loc").Value = grdYarnIN.Rows(i).Cells("mtl_locations_id").FormattedValue.ToString
        'Next

        Dim dt As DataTable = dgvYarnIN.DataSource
        If dt.Rows.Count > 0 Then
            For i = 0 To dt.Rows.Count - 1
                If dt.Rows(i).RowState <> DataRowState.Deleted Then
                    If oConfig.IsNull(dt.Rows(i)("docdt2"), "") <> dtpDocDate.Value.ToString("dd/MM/yyyy") Then dt.Rows(i)("docdt2") = dtpDocDate.Value.ToString("dd/MM/yyyy")
                    If oConfig.IsNull(dt.Rows(i)("purno"), "") <> txtPONo.Text Then dt.Rows(i)("purno") = txtPONo.Text
                    If oConfig.IsNull(dt.Rows(i)("suppcd"), "") <> cboSupplier.SelectedValue Then dt.Rows(i)("suppcd") = cboSupplier.SelectedValue
                    If oConfig.IsNull(dt.Rows(i)("sinvno"), "") <> txtSuppInvNo.Text Then dt.Rows(i)("sinvno") = txtSuppInvNo.Text
                    If oConfig.IsNull(dt.Rows(i)("sinvdt"), "") <> dtpSinvdt.Value.ToString("dd/MM/yyyy") Then dt.Rows(i)("sinvdt") = dtpSinvdt.Value.ToString("dd/MM/yyyy")
                    If oConfig.IsNull(dt.Rows(i)("lotno_sup"), "") <> txtSuppLot.Text Then dt.Rows(i)("lotno_sup") = txtSuppLot.Text
                    If oConfig.IsNull(dt.Rows(i)("srefno"), "") <> txtSuppRefNo.Text Then dt.Rows(i)("srefno") = txtSuppRefNo.Text
                    If oConfig.IsNull(dt.Rows(i)("remark"), "").ToString.Trim <> txtRemark.Text.Trim Then dt.Rows(i)("remark") = txtRemark.Text.Trim
                    If oConfig.IsNull(dt.Rows(i)("tran_type"), "") <> "PURCHASE" Then dt.Rows(i)("tran_type") = "PURCHASE"
                    If oConfig.IsNull(dt.Rows(i)("mtl_warehouse_id"), "0") <> cbomtlWarehouse.SelectedValue Then dt.Rows(i)("mtl_warehouse_id") = cbomtlWarehouse.SelectedValue
                    If oConfig.IsNull(dt.Rows(i)("mtl_subinventory_id"), "0") <> cbomtlSubinventory.SelectedValue Then dt.Rows(i)("mtl_subinventory_id") = cbomtlSubinventory.SelectedValue
                    If oConfig.IsNull(dt.Rows(i)("mtl_locations_id"), "0") <> cbomtlLocations.SelectedValue Then dt.Rows(i)("mtl_locations_id") = cbomtlLocations.SelectedValue
                    If oConfig.IsNull(dt.Rows(i)("loc"), "") <> cbomtlLocations.Text Then dt.Rows(i)("loc") = cbomtlLocations.Text
                End If
                'tblYarnin.tbl_Yarn_in_det(tran_no).mtl_warehouse_id = cbomtlWarehouse.SelectedValue 'DgYarn.Rows(i).Cells("mtl_warehouse_id").Value
                'tblYarnin.tbl_Yarn_in_det(tran_no).mtl_subinventory_id = cbomtlSubinventory.SelectedValue 'DgYarn.Rows(i).Cells("mtl_subinventory_id").Value
                ' tblYarnin.tbl_Yarn_in_det(tran_no).mtl_locations_id = cbomtlLocations.SelectedValue


            Next


            'If Not txtPONo.Text.Substring(0, 4).ToUpper().Equals("FREE") And netKg > (jobQty * 1.5) Then
            '    If (docno.Length = 0) Then
            '        MessageBox.Show("จำนวนรับเข้ามากกว่าจำนวนใน P/O ที่เลือก (" + jobQty.ToString("#,###.##") + ")", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            '        Exit Sub
            '    Else
            '        If MessageBox.Show("จำนวนรับเข้ามากกว่าจำนวนใน P/O ที่เลือก (" + jobQty.ToString("#,###.##") + ")" + vbCrLf + "ต้องการบันทึกหรือไม่ ?", "System Message", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = Windows.Forms.DialogResult.No Then
            '            Exit Sub
            '        End If
            '    End If
            'End If

            'If MessageBox.Show("Would you like to save ?", "System Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            If (New classYarnInPurchase).updateYarnInPurchase(dt, clsUser.UserID, docno) Then
                ErrorProvider1.Clear()
                Call LoadDataYarn(docno)
            End If

            'Call (New UpdateYarn).UpdateYarnIN2(dt, loginEmpcd, docno)
            'Call LoadDataYarn(docno)
            'Else
            '   Exit Sub
            'End If
        End If
    End Sub

    Private Sub formYarnIN_2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized

        Call InitControl()

    End Sub

    Private Sub InitControl()

        Call GetAllComboINGrid()
        Call GenCombo()

        docno = ""
        txtPONo.Text = ""
        dtpDocDate.Value = Now
        cboSupplier.SelectedIndex = -1
        txtSuppInvNo.Text = ""
        txtSuppLot.Text = ""
        dtpSinvdt.Value = Now
        'txtSuppInvDate.Text = ""
        txtSuppRefNo.Text = ""
        txtRemark.Text = ""

        txtTotalBoxes.Text = ""
        txtTotalTubes.Text = ""
        txtTotalGrossWeight.Text = ""
        txtTotalNetWeight.Text = ""
        Call LoadDataYarn("")


    End Sub


    Private Sub btnNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNew.Click
        Call InitControl()

    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click

        Dim result As DialogResult
        result = MessageBox.Show("Would you like to save ?", "System Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button3)
        If result <> DialogResult.Yes Then Exit Sub

        If Not CheckData() Then Exit Sub

        Call SaveDataYarn()

    End Sub

    Private Function checkQtyMisMatch() As Boolean

        Dim result As Boolean = True

        Dim dtJobDet As New DataTable
        Dim dtYarnInDet As New DataTable
        dtJobDet = dgvPO.DataSource
        dtYarnInDet = dgvYarnIN.DataSource

        For Each jobRow As DataRow In dtJobDet.Rows
            Dim idJobDet As Integer = CInt(jobRow("id_jobdet"))
            Dim JobLineId As String = oConfig.IsNull(jobRow("job_line_id"), "")
            Dim jobQty As Decimal = CDec(oConfig.IsNull(jobRow("qty"), 0))
            Dim jobQty2 As Decimal = CDec(oConfig.IsNull(jobRow("qty2"), 0))
            Dim validateQtyConeYn As String = CStr(oConfig.IsNull(jobRow("validate_qty_cone_yn"), "N"))

            ' เลือกแถวจาก yarn_in_det ที่ตรงกับ job_line_id
            Dim rows = dtYarnInDet.Select("id_jobdet = " & idJobDet)

            ' รวม qty ของ yarn_in_det
            Dim totalYarnQty As Decimal = 0
            Dim totalYarnQty2 As Decimal = 0
            For Each yarnRow As DataRow In dtYarnInDet.Select("id_jobdet = " & idJobDet)
                totalYarnQty += CDec(yarnRow("kg_nt"))
                totalYarnQty2 += CDec(yarnRow("spools"))
            Next

            ' เปรียบเทียบ
            If validateQtyConeYn = "Y" Then
                If jobQty <= totalYarnQty Or jobQty2 <= totalYarnQty2 Then
                    If jobQty = totalYarnQty And jobQty2 = totalYarnQty2 Then
                        Console.WriteLine("Job line " & JobLineId & " qty match.")
                        ' MessageBox.Show("Job line " & JobLineId & " qty match.")
                        result = True
                    Else
                        Console.WriteLine("Job line " & JobLineId & " qty mismatch! JobQty=" & jobQty & ", YarnQty=" & totalYarnQty)
                        ' MessageBox.Show("Job line " & JobLineId & " qty mismatch! JobQty=" & jobQty & ", YarnQty=" & totalYarnQty)
                        result = False
                    End If
                End If
            End If

        Next

        Return result
    End Function

    Private Function CheckData() As Boolean
        Dim Result As Boolean = True
        'Dim clsconfig As New clsConfig
        If oConfig.IsNull(cbomtlWarehouse.SelectedValue, 0) = 0 Then
            MessageBox.Show("คุณยังไม่ไดเลือก WareHouse", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
            ErrorProvider1.SetError(cbomtlWarehouse, "คุณยังไม่ไดเลือก WareHouse")
            Result = False
            ' Exit Function
        End If

        If Val(cbomtlSubinventory.SelectedValue) = 0 Then
            MessageBox.Show("คุณยังไม่ได้เลือก Subinventory", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
            ErrorProvider1.SetError(cbomtlSubinventory, "คุณยังไม่ได้เลือก Subinventory")
            Result = False
            '  Exit Function
        End If

        If oConfig.IsNull(cbomtlLocations.SelectedValue, 0) = 0 Then
            MessageBox.Show("คุณยังไม่ไดเลือก Location", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
            ErrorProvider1.SetError(cbomtlLocations, "คุณยังไม่ได้เลือก Locations")
            Result = False
            ' Exit Function
        End If

        If Not checkQtyMisMatch() Then
            If oConfig.IsNull(cboQtyMismatchReason.SelectedValue, 0) = 0 Then
                ErrorProvider1.SetError(cboQtyMismatchReason, "คุณต้องเลือก เหตุผล")
                Result = False
            End If
            'Exit Function
        End If

        Dim dt As DataTable = dgvYarnIN.DataSource
        For Each dr As DataRow In dt.Rows
            If dr.RowState <> DataRowState.Deleted Then
                If (New clsConfig).IsNull(dr("spools"), 0) = 0 Then
                    MessageBox.Show("คุณยังไม่ได้ใส่จำนวน Tube /Spools", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
                    ErrorProvider1.SetError(dgvYarnIN, "คุณยังไม่ได้ใส่จำนวน Tube /Spools")
                    Result = False
                End If

                If (New clsConfig).IsNull(dr("kg_nt"), 0) = 0 Then
                    MessageBox.Show("คุณยังไม่ได้ใส่จำนวน Net weight{Kg}", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
                    ErrorProvider1.SetError(dgvYarnIN, "คุณยังไม่ได้ใส่จำนวน Net weight{Kg}")
                    Result = False
                End If

            End If

        Next


        Return Result
    End Function

    Private Sub btnPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrint.Click


        Dim clsConn As New classConnection
        Dim rptFileName As String = "rptYarnIn.rpt"
        Dim frm As New frmReport

        If Not oConfig.CheckReport(clsuser.reportpath, rptFileName) Then Exit Sub
        Dim rpt As New CrystalDecisions.CrystalReports.Engine.ReportDocument
        Dim stype As String = ""
        Dim ord As String = ""
        Me.Cursor = Cursors.WaitCursor

        rpt.Load(clsuser.reportpath & rptFileName)
        rpt.DataSourceConnections.Item(0).SetConnection(clsConn.ServerName, clsConn.Database, False)
        rpt.DataSourceConnections.Item(0).SetLogon(clsConn.UserName, clsConn.Password)
        rpt.VerifyDatabase()
        rpt.SetParameterValue("@docno", txtDocNo.Text)

        rpt.PrintOptions.PaperSize = CrystalDecisions.Shared.PaperSize.PaperLetter
        'rpt.PrintOptions.PaperSize = CrystalDecisions.Shared.PaperSize.PaperA4
        'rpt.PrintOptions.PaperOrientation = CrystalDecisions.Shared.PaperOrientation.Portrait
        'rpt.PrintOptions.PaperSource = CrystalDecisions.Shared.PaperSource.Auto

        'frm.CRViewer.DisplayGroupTree = False
        frm.CRViewer.ReportSource = rpt
        frm.MdiParent = Me.ParentForm
        frm.Title = "Yarn In"
        frm.Show()
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub btnPrintBarcode_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrintBarcode.Click
        docno = txtDocNo.Text.Trim
        If docno.Length = 0 Then Exit Sub
        Dim frm As New formPrintBarcode
        ' frm.MdiParent = Me
        frm.UserInfo = clsUser
        frm.loginEmpcd = clsUser.UserID
        frm.Show()

        frm.txtYarn_in_no.Text = docno

        frm.btnFindByYarnInClick()
        frm.SelectAll(sender, e)
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub txtPONo_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtPONo.KeyDown
        If e.KeyCode = Keys.Enter Then LoadDataJOB(txtPONo.Text.Trim)
    End Sub

    Private Sub grdYarnIN_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvYarnIN.CellClick
        If dgvPO.Rows.Count > 0 Then
            dgvYarnIN.CurrentRow.Cells("id_jobdet").Value = dgvPO.CurrentRow.Cells("colID").Value
            dgvYarnIN.CurrentRow.Cells("cboitcd").Value = dgvPO.CurrentRow.Cells("itcd").Value

        End If
    End Sub

    Private Sub grdYarnIN_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvYarnIN.CellDoubleClick

        If dgvPO.Rows.Count > 0 Then
            dgvYarnIN.CurrentRow.Cells("id_jobdet").Value = dgvPO.CurrentRow.Cells("colID").Value
            dgvYarnIN.CurrentRow.Cells("cboitcd").Value = dgvPO.CurrentRow.Cells("itcd").Value

        End If
    End Sub

    Private Sub grdYarnIN_DefaultValuesNeeded(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewRowEventArgs) Handles dgvYarnIN.DefaultValuesNeeded

        '----------------- Inculde Default Warehouse And Inculde Subinventory 
        Dim objdb As New classMaster
        Dim dgvccrcv_warehouse_id As New DataGridViewComboBoxCell
        Dim dgvccSubInven As New DataGridViewComboBoxCell

        dgvccrcv_warehouse_id = e.Row.Cells("rcv_warehouse_id")
        dgvccSubInven = e.Row.Cells("rcv_subinventory_id")
        dgvccrcv_warehouse_id.Value = objdb.GetdefaultWarehouse(strUSerID:=clsUser.UserID)
        dgvccSubInven.DataSource = objdb.GetCombomtl_subinventory(e.Row.Cells("rcv_warehouse_id").Value)
        dgvccSubInven.Value = DBNull.Value

    End Sub

    Private Sub grdYarnIN_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles dgvYarnIN.KeyDown
        If e.KeyCode = Keys.Enter Then GetCopyBox()
    End Sub
    Private Function GetCopyBox() As Boolean

        Dim dtc As DataTable = dgvYarnIN.DataSource


        Dim newRow As DataRow
        If dgvYarnIN.Rows.Count > 0 Then


            newRow = dtc.NewRow

            newRow.Item("itcd") = dgvYarnIN.CurrentRow.Cells("cboITCD").Value
            newRow.Item("grade") = dgvYarnIN.CurrentRow.Cells("grade").Value
            'newRow.Item("grade_our") = grdYarnIN.CurrentRow.Cells("cbograde_our").Value
            'newRow.Item("boxno_s") = grdYarnIN.CurrentRow.Cells("boxno_s").Value 'User No Need
            newRow.Item("spools") = dgvYarnIN.CurrentRow.Cells("spools").Value
            newRow.Item("kg_gr") = dgvYarnIN.CurrentRow.Cells("kg_gr").Value
            newRow.Item("kg_nt") = dgvYarnIN.CurrentRow.Cells("kg_nt").Value
            newRow.Item("cart_tearwt") = dgvYarnIN.CurrentRow.Cells("cart_tearwt").Value
            newRow.Item("boxno") = dgvYarnIN.CurrentRow.Cells("boxno").Value
            newRow.Item("loc") = dgvYarnIN.CurrentRow.Cells("loc").Value
            newRow.Item("actual_cone_weight") = dgvYarnIN.CurrentRow.Cells("actual_cone_weight").Value
            newRow.Item("job_line_id") = dgvYarnIN.CurrentRow.Cells("colJobLineId2").Value
            newRow.Item("id_jobdet") = dgvYarnIN.CurrentRow.Cells("id_jobdet").Value
            newRow.Item("box_remark") = dgvYarnIN.CurrentRow.Cells("box_remark").Value

            newRow.Item("mtl_warehouse_id") = dgvYarnIN.CurrentRow.Cells("mtl_warehouse_id").Value
            'Call GetcomboSubInventoryinGrid(Int64mtl_warehouse_id:=grdYarnIN.CurrentRow.Cells("mtl_warehouse_id").Value)
            newRow.Item("mtl_subinventory_id") = dgvYarnIN.CurrentRow.Cells("mtl_subinventory_id").Value 'clsGetDatYarn.GetdefaultmtlsubinventoryByItcd(strItcd, clsUser.UserID) '11 'Set Defaulf Again
            'Call GetCombomtl_locationInGrid(Int64mtl_warehouse_id:=(New clsConfig).IsNull(grdYarnIN.CurrentRow.Cells("mtl_warehouse_id").Value, Nothing), _
            'Int64mtl_subinventory_id:=(New clsConfig).IsNull(grdYarnIN.CurrentRow.Cells("mtl_subinventory_id").Value, Nothing))
            newRow.Item("mtl_locations_id") = dgvYarnIN.CurrentRow.Cells("mtl_locations_id").Value


            dtc.Rows.Add(newRow)

            Return True
        End If

        Return False

    End Function

    Private Sub grdYarnIN_RowEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvYarnIN.RowEnter


        'If e.RowIndex = 0 And docno = "" Then
        '    If grdPO.Rows.Count > 0 And Val(grdYarnIN.Rows(0).Cells("id_jobdet").Value) = 0 Then
        '        grdYarnIN.CurrentRow.Cells("id_jobdet").Value = grdPO.CurrentRow.Cells("colID").Value
        '        grdYarnIN.CurrentRow.Cells("cboitcd").Value = grdPO.CurrentRow.Cells("itcd").Value
        '        'grdYarnIN.Rows(0).Cells("id_jobdet").Value = grdPO.CurrentRow.Cells("colID").Value
        '        'grdYarnIN.Rows(0).Cells("cboitcd").Value = grdPO.CurrentRow.Cells("itcd").Value
        '    End If
        '    'If Val(grdYarnIN.Rows(0).Cells("id_jobdet").Value) = 0 Then
        '    'grdYarnIN.Rows(0).Cells("id_jobdet").Value = jobID
        '    'grdYarnIN.Rows(0).Cells("cboitcd").Value = grdPO.CurrentRow.Cells("itcd").Value
        '    'End If
        'End If
    End Sub

    Private Sub grdYarnIN_RowLeave(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvYarnIN.RowLeave
        If Not dgvYarnIN.DataSource Is Nothing Then
            If dgvYarnIN.Rows.Count > 1 Then
                If dgvYarnIN.CurrentCell.IsInEditMode Then
                    Dim cell As DataGridViewCell = dgvYarnIN.CurrentCell
                    If dgvYarnIN.EndEdit(DataGridViewDataErrorContexts.Commit) Then
                        dgvYarnIN.CurrentCell = dgvYarnIN.Rows(0).Cells(0)
                        dgvYarnIN.CurrentCell = cell
                    Else
                        dgvYarnIN.CancelEdit()
                    End If
                End If
            End If
        End If
        Call SumGrid(dgvYarnIN.DataSource)
    End Sub

    Private Sub grdPO_CellContentDoubleClick(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvPO.CellContentDoubleClick
        Call AddNewBox()
    End Sub

    Private Sub grdPO_RowEnter(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvPO.RowEnter
        'If (e.RowIndex >= 0) Then
        '    Dim dt As DataTable = grdYarnIN.DataSource
        '    dt.Columns("id_jobdet").DefaultValue = grdPO.Rows(e.RowIndex).Cells("colID").Value
        'End If

        If dgvPO.Rows.Count > 0 And (e.RowIndex >= 0) Then
            jobID = dgvPO.Rows(e.RowIndex).Cells("colID").Value
            jobQty = dgvPO.Rows(e.RowIndex).Cells("qty").Value
            'Stritcd = grdPO.Rows(e.RowIndex).Cells("itcd").Value
        End If

    End Sub

    Private Sub grdPO_CellEnter(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvPO.CellEnter
        If dgvPO.Rows.Count > 0 Then
            jobID = dgvPO.Rows(e.RowIndex).Cells("colID").Value
            jobQty = dgvPO.Rows(e.RowIndex).Cells("qty").Value

            'stritcd = grdPO.Rows(e.RowIndex).Cells("itcd").Value
        End If

    End Sub


    Private Sub btnAdd_Click(sender As System.Object, e As System.EventArgs) Handles btnAdd.Click
        Call AddNewBox()
    End Sub
    Private Function AddNewBox() As Boolean

        If dgvPO.Rows.Count = 0 Then
            Return False
            Exit Function
        End If

        If dgvPO.CurrentRow.Cells("colID").Value Is DBNull.Value Then
            Return False
            Exit Function
        End If


        Dim dtc As New DataTable
        dtc = dgvYarnIN.DataSource


        Dim newRow As DataRow
        Dim Int32id_jobdet As Nullable(Of Int32)
        Dim _JobLineId As String
        Dim strItcd As String

        Int32id_jobdet = oConfig.IsNull(dgvPO.CurrentRow.Cells("colID").Value, Nothing)
        _JobLineId = oConfig.IsNull(dgvPO.CurrentRow.Cells("colJobLineId").Value, String.Empty)
        strItcd = oConfig.IsNull(dgvPO.CurrentRow.Cells("itcd").Value, String.Empty)

        'grdPO.CurrentRow.Cells("colID").Value
        Dim clsGetDatYarn As New GetDataYarn
        newRow = dtc.NewRow

        If dgvPO.Rows.Count > 0 Then
            newRow.Item("id_jobdet") = oConfig.IsNull(Int32id_jobdet, DBNull.Value)
            newRow.Item("job_line_id") = oConfig.IsNull(_JobLineId, DBNull.Value)
            newRow.Item("itcd") = oConfig.IsNull(strItcd, DBNull.Value)

            'newRow.Item("mtl_warehouse_id") = grdPO.CurrentRow.Cells("rcv_warehouse_id").Value 'clsGetDatYarn.GetdefaultWarehouse(clsUser.UserID) '4 Set Defaulf Again
            'Call GetcomboSubInventoryinGrid(Int64mtl_warehouse_id:=grdPO.CurrentRow.Cells("rcv_warehouse_id").Value)
            'newRow.Item("mtl_subinventory_id") = grdPO.CurrentRow.Cells("rcv_subinventory_id").Value 'clsGetDatYarn.GetdefaultmtlsubinventoryByItcd(strItcd, clsUser.UserID) '11 'Set Defaulf Again
            'Call GetCombomtl_locationInGrid(Int64mtl_warehouse_id:=(New clsConfig).IsNull(grdPO.CurrentRow.Cells("rcv_warehouse_id").Value, Nothing),
            'Int64mtl_subinventory_id:=(New clsConfig).IsNull(grdPO.CurrentRow.Cells("rcv_subinventory_id").Value, Nothing))
            'newRow.Item("mtl_locations_id") = grdPO.CurrentRow.Cells("rcv_subinventory_id").Value 'DBNull.Value ' (New clsConfig).IsNull(clsGetDatYarn.Getdefaultmtl_locations_id(newRow.Item("mtl_warehouse_id"), _

            Me.cbomtlWarehouse.SelectedValue = dgvPO.CurrentRow.Cells("rcv_warehouse_id").Value
            bsMtlSubInventory.Filter = "mtl_warehouse_id = '" & (New clsConfig).IsNull(cbomtlWarehouse.SelectedValue, 0) & "'"
            Me.cbomtlSubinventory.SelectedValue = dgvPO.CurrentRow.Cells("rcv_subinventory_id").Value
            bsMtlLocations.Filter = "mtl_warehouse_id = '" & (New clsConfig).IsNull(cbomtlWarehouse.SelectedValue, 0) & "' and mtl_subinventory_id = '" & (New clsConfig).IsNull(cbomtlSubinventory.SelectedValue, 0) & "'"
            Me.cbomtlLocations.SelectedValue = dgvPO.CurrentRow.Cells("rcv_locations_id").Value
        End If


        dtc.Rows.Add(newRow)

        'Call grdYarnIN_CellEndEdit(sender, newRow)

        SumGrid(dgvYarnIN.DataSource)


    End Function

    Private Sub btnDel_Click(sender As System.Object, e As System.EventArgs) Handles btnDel.Click
        Dim result As DialogResult
        result = MessageBox.Show("Would You Like To Delete New Box ?", "System Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button3)
        If result = DialogResult.No Then Exit Sub
        RemoveNewBox()
    End Sub
    Private Sub RemoveNewBox()

        For Each row As DataGridViewRow In dgvYarnIN.SelectedRows
            dgvYarnIN.Rows.Remove(row)
        Next
    End Sub

    Private Sub grdYarnIN_CurrentCellDirtyStateChanged(sender As Object, e As System.EventArgs) Handles dgvYarnIN.CurrentCellDirtyStateChanged

        If dgvYarnIN.IsCurrentCellDirty Then
            dgvYarnIN.CommitEdit(DataGridViewDataErrorContexts.Commit)
        End If

    End Sub

    Private Sub txtDocNo_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles txtDocNo.KeyDown
        If e.KeyCode = Keys.Enter Then
            LoadDataYarn(txtDocNo.Text.Trim)
        End If
    End Sub

    Private Sub GetAllComboINGrid()
        Dim clsGetDatYarn As New GetDataYarn

        Call GetComboWarehouseinGrid()
        Call GetcomboSubInventoryinGrid(Int64mtl_warehouse_id:=0)
        Call GetCombomtl_locationInGrid(Int64mtl_warehouse_id:=0, Int64mtl_subinventory_id:=0)

        rcv_warehouse_id.DataSource = (New classMaster).GetCombomtl_warehouse(UserInfo:=clsUser)
        rcv_warehouse_id.DisplayMember = "warehouse_code"
        rcv_warehouse_id.ValueMember = "mtl_warehouse_id"

        rcv_subinventory_id.DataSource = (New classMaster).GetCombomtl_subinventory(Int64mtl_warehouse_id:=0)
        rcv_subinventory_id.DisplayMember = "subinventory_code"
        rcv_subinventory_id.ValueMember = "mtl_subinventory_id"

        rcv_locations_id.DataSource = (New classMaster).GetCombomtl_location(Int64mtl_warehouse_id:=0, Int64mtl_subinventory_id:=0)
        rcv_locations_id.DisplayMember = "location_name"
        rcv_locations_id.ValueMember = "mtl_locations_id"

        ' newRow.Item("mtl_warehouse_id") = clsGetDatYarn.GetDefaultWareHouse(clsUser.UserID) '4 Set Defaulf Again
        '  newRow.Item("mtl_subinventory_id") = clsGetDatYarn.GetdefaultmtlsubinventoryByItcd(stritcd, clsUser.UserID) '11 'Set Defaulf Again
        '  newRow.Item("mtl_locations_id") = clsGetDatYarn.Getdefaultmtl_locations_id(newRow.Item("mtl_warehouse_id"), newRow.Item("mtl_subinventory_id"), clsUser.UserID) '12            '12 'Set Defaulf Again

    End Sub

    Private Sub GetComboWarehouseinGrid()
        Dim objdb As New classMaster
        mtl_warehouse_id.DataSource = objdb.Combomtlwarehouse(clsUser.UserID)
        mtl_warehouse_id.DisplayMember = "warehouse_code"
        mtl_warehouse_id.ValueMember = "mtl_warehouse_id"
    End Sub

    Private Sub GetcomboSubInventoryinGrid(ByVal Int64mtl_warehouse_id As Nullable(Of Int64))
        Dim objdb As New classMaster
        mtl_subinventory_id.DataSource = objdb.GetCombomtl_subinventory(Int64mtl_warehouse_id)
        mtl_subinventory_id.DisplayMember = "subinventory_code"
        mtl_subinventory_id.ValueMember = "mtl_subinventory_id"
    End Sub

    Private Sub GetCombomtl_locationInGrid(Optional ByVal Int64mtl_warehouse_id As Nullable(Of Int64) = Nothing, Optional ByVal Int64mtl_subinventory_id As Nullable(Of Int64) = Nothing)
        Dim objdb As New classMaster
        mtl_locations_id.DataSource = objdb.Combomtllocations(strUSerID:=clsUser.UserID, INt64mtl_warehouse_id:=Int64mtl_warehouse_id, Int64mtl_subinventory_id:=Int64mtl_subinventory_id)
        mtl_locations_id.DisplayMember = "location_name"
        mtl_locations_id.ValueMember = "mtl_locations_id"
    End Sub


    Private Sub grdPO_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvPO.CellContentClick

    End Sub

    Private Sub grdYarnIN_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvYarnIN.CellContentClick

    End Sub

    Private Sub grdYarnIN_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles dgvYarnIN.CellEndEdit

        Dim objdb As New classMaster


        Dim dgvccSubInven As New DataGridViewComboBoxCell
        Dim dtSubInven As New DataTable
        If dgvYarnIN.Columns(e.ColumnIndex).Name = "mtl_warehouse_id" Then
            If Not IsDBNull(dgvYarnIN.Rows(e.RowIndex).Cells("mtl_warehouse_id").Value) Then
                dtSubInven = objdb.GetCombomtl_subinventory(dgvYarnIN.Rows(e.RowIndex).Cells("mtl_warehouse_id").Value)
                dgvccSubInven = dgvYarnIN.Rows(e.RowIndex).Cells("mtl_subinventory_id")

                Try
                    dgvccSubInven.DataSource = dtSubInven
                    dgvccSubInven.DisplayMember = "subinventory_code"
                    dgvccSubInven.ValueMember = "mtl_subinventory_id"
                    dgvccSubInven.Value = dtSubInven.Rows(0)("mtl_subinventory_id") 'Fix Error

                    'Dim expression As String
                    'expression = "subinventory_name like '%YARN STOCK%'"
                    'Dim foundRows() As DataRow
                    'foundRows = dtSubInven.Select(expression)
                    'dgvccSubInven.Value = foundRows(0)("mtl_subinventory_id")
                Catch ex As Exception

                    'SetDefault
                    'Dim expression As String
                    'expression = "subinventory_name like '%YARN STOCK%'"
                    'Dim foundRows() As DataRow
                    'foundRows = dtSubInven.Select(expression)
                    dgvccSubInven.Value = DBNull.Value

                End Try
            End If
        End If

        Dim dgvcc As New DataGridViewComboBoxCell
        Dim dt3 As New DataTable
        If dgvYarnIN.Columns(e.ColumnIndex).Name = "mtl_warehouse_id" Or dgvYarnIN.Columns(e.ColumnIndex).Name = "mtl_subinventory_id" Then
            If Not IsDBNull(dgvYarnIN.Rows(e.RowIndex).Cells("mtl_warehouse_id").Value) And Not IsDBNull(dgvYarnIN.Rows(e.RowIndex).Cells("mtl_subinventory_id").Value) Then
                dt3 = objdb.Combomtllocations(clsUser.UserID, dgvYarnIN.Rows(e.RowIndex).Cells("mtl_warehouse_id").Value, dgvYarnIN.Rows(e.RowIndex).Cells("mtl_subinventory_id").Value)
                dgvcc = dgvYarnIN.Rows(e.RowIndex).Cells("mtl_locations_id")
                Try
                    dgvcc.DataSource = dt3
                    dgvcc.DisplayMember = "location_name"
                    dgvcc.ValueMember = "mtl_locations_id"
                    dgvcc.Value = dt3.Rows(0)("mtl_locations_id") 'Fix Error
                Catch ex As Exception
                    dgvcc.DataSource = dt3
                    dgvcc.DisplayMember = "location_name"
                    dgvcc.ValueMember = "mtl_locations_id"
                    dgvcc.Value = DBNull.Value
                End Try
            End If
        End If
    End Sub

    Private Sub cbomtlWarehouse_DropDownClosed(sender As Object, e As EventArgs) Handles cbomtlWarehouse.DropDownClosed
        bsMtlSubInventory.Filter = "mtl_warehouse_id = '" & (New clsConfig).IsNull(cbomtlWarehouse.SelectedValue, 0) & "'"
        bsMtlLocations.Filter = "mtl_warehouse_id = '" & (New clsConfig).IsNull(cbomtlWarehouse.SelectedValue, 0) & "' and mtl_subinventory_id = '" & (New clsConfig).IsNull(cbomtlSubinventory.SelectedValue, 0) & "'"

    End Sub

    Private Sub cbomtlSubinventory_DropDownClosed(sender As Object, e As EventArgs) Handles cbomtlSubinventory.DropDownClosed
        bsMtlLocations.Filter = "mtl_warehouse_id = '" & (New clsConfig).IsNull(cbomtlWarehouse.SelectedValue, 0) & "' and mtl_subinventory_id = '" & (New clsConfig).IsNull(cbomtlSubinventory.SelectedValue, 0) & "'"

    End Sub

    Private Sub txtItmFind_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtItmFind.KeyPress
        ' Sitthana 18/08/2018
        If e.KeyChar = vbCr Then
            With dgvPO
                If .Rows.Count > 0 Then
                    Dim SearchWithinThis As String = ""

                    For i As Integer = .CurrentRow.Index + 1 To .Rows.Count - 1
                        SearchWithinThis = .Rows(i).Cells("itcd").Value.ToString.ToUpper
                        If SearchWithinThis.IndexOf(txtItmFind.Text.ToUpper) <> -1 Then
                            .CurrentCell = .Rows(i).Cells("itcd")
                            Exit For
                        End If
                    Next
                    If .CurrentRow.Index = 0 Then
                        SearchWithinThis = .Rows(.CurrentRow.Index).Cells("itcd").Value.ToString.ToUpper
                        If SearchWithinThis.IndexOf(txtItmFind.Text.ToUpper) = -1 Then
                            MessageBox.Show("ไม่พบข้อมูล Item Code ที่คุณต้องการหา", "รายงานผลการค้นหาข้อมูล", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        End If
                    End If
                End If
            End With
        End If
    End Sub
    Private Function GetCopyStep(ByVal n As Integer) As Boolean
        Dim objdb As New classMaster
        Dim dtc As DataTable = dgvYarnIN.DataSource


        Dim newRow As DataRow
        If dgvYarnIN.Rows.Count > 0 Then
            For i = 1 To n

                newRow = dtc.NewRow

                newRow.Item("itcd") = dgvYarnIN.CurrentRow.Cells("cboITCD").Value
                newRow.Item("grade") = dgvYarnIN.CurrentRow.Cells("grade").Value
                ' newRow.Item("grade_our") = dgvYarnIN.CurrentRow.Cells("cbograde_our").Value
                newRow.Item("boxno_s") = dgvYarnIN.CurrentRow.Cells("boxno_s").Value
                newRow.Item("spools") = dgvYarnIN.CurrentRow.Cells("spools").Value
                newRow.Item("kg_gr") = dgvYarnIN.CurrentRow.Cells("kg_gr").Value
                newRow.Item("kg_nt") = dgvYarnIN.CurrentRow.Cells("kg_nt").Value
                newRow.Item("cart_tearwt") = dgvYarnIN.CurrentRow.Cells("cart_tearwt").Value
                newRow.Item("actual_cone_weight") = dgvYarnIN.CurrentRow.Cells("actual_cone_weight").Value 'actual_cone_weight
                newRow.Item("boxno") = dgvYarnIN.CurrentRow.Cells("boxno").Value
                newRow.Item("loc") = dgvYarnIN.CurrentRow.Cells("loc").Value
                newRow.Item("mtl_warehouse_id") = oConfig.IsNull(dgvYarnIN.CurrentRow.Cells("mtl_warehouse_id").Value, DBNull.Value)
                newRow.Item("mtl_subinventory_id") = oConfig.IsNull(dgvYarnIN.CurrentRow.Cells("mtl_subinventory_id").Value, DBNull.Value)
                newRow.Item("mtl_locations_id") = oConfig.IsNull(dgvYarnIN.CurrentRow.Cells("mtl_locations_id").Value, DBNull.Value)
                ' newRow.Item("loc_sub") = dgvYarnIN.CurrentRow.Cells("loc_sub").Value
                newRow.Item("id_jobdet") = dgvYarnIN.CurrentRow.Cells("id_jobdet").Value
                newRow.Item("job_line_id") = dgvYarnIN.CurrentRow.Cells("colJobLineId2").Value
                newRow.Item("box_remark") = dgvYarnIN.CurrentRow.Cells("box_remark").Value

                dtc.Rows.Add(newRow)


            Next
            Return True
        End If

        Return False

    End Function
    Private Sub btnCopy_Click(sender As Object, e As EventArgs) Handles btnCopy.Click
        Dim userMsg As String
        userMsg = Microsoft.VisualBasic.InputBox("How many Boxes do you need to copy?" & vbCrLf & "ต้องการ Copy เพิ่มกี่กล่อง?",
                                                 "System Message", "1", 500, 700)

        If IsNumeric(userMsg) Then
            Call GetCopyStep(userMsg)
        End If
    End Sub


End Class
