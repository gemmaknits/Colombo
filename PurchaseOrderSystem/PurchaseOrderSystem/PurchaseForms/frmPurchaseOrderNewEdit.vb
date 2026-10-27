Imports System.Data
Imports System.Data.SqlClient
Imports System.Text
Imports System.Windows.Forms
Imports PurchaseOrderSystem.Controls


Public Class frmPurchaseOrderNewEdit
    Dim _AppConn As SqlConnection = (New classConnection).getSQLConnection

    ' Public loginEmpcd
    Private clsConnection As New classConnection
    Private oConfig As New clsConfig
    Private clsMaster As New classMaster
    Private oPO As New classPurchaseNewEdit 'Neung 20250915

    Public selectitdesc As String = ""
    Public selectitcd As String = ""
    Dim ds As New DataSet
    Private dts As DataTable
    Private dt As DataTable
    Private dtWarehouse As DataTable
    Dim dtJob As New DataTable
    Dim bsJob As New BindingSource
    Dim drvJob As DataRowView

    Dim dtJobDet As New DataTable
    Dim bsJobDet As New BindingSource
    Dim drvJobDet As DataRowView

    Dim blnCancel As Boolean = False
    Dim dtPaymentTerm As DataTable

    Dim Qty As Decimal = 0
    Dim UnitPrice As Decimal = 0
    Dim Discper As Decimal = 0
    Dim Discamt As Decimal = 0
    Dim VatAmt As Decimal = 0
    Dim sumDiscAmt As Decimal = 0
    Dim sumGrossAmt As Decimal = 0
    Dim clsUser As New classUserInfo

    Private m_import As Boolean = False


    Dim scAutoComplete As New AutoCompleteStringCollection
    Dim ItcdAutoComplete As New AutoCompleteStringCollection
    Dim crTermAutoComplete As New AutoCompleteStringCollection
    Private DefaultSourcePath As String = "" 'Sitthana 20210708
    Private _Jobno As String = ""
    Public Property pJobno As String
        Get
            pJobno = _Jobno
        End Get
        Set(ByVal Newvalue As String)
            _Jobno = Newvalue
        End Set
    End Property

    Dim clsPurchase As New classPurchase

    Public Property UserInfo() As classUserInfo
        Get
            UserInfo = clsUser
        End Get
        Set(ByVal NewValue As classUserInfo)
            clsUser = NewValue
        End Set
    End Property

    Private Sub Model_QueryCellInfo(ByVal sender As Object, ByVal e As PurchaseOrderSystem.Controls.GridQueryCellInfoEventArgs)
        'To specify the row and colum index.
        If e.RowIndex = 0 AndAlso e.ColIndex = 1 Then
            'To specify the font
            e.Style.Font = New PurchaseOrderSystem.Controls.GridFontInfo(New Font("Segoe UI", 12, FontStyle.Bold, GraphicsUnit.Pixel))
            'To specify the text
            e.Style.Text = "PO Line Type Description"
            'To specify the text color.
            'e.Style.TextColor = Color.Red
        ElseIf e.RowIndex = 0 AndAlso e.ColIndex = 2 Then
            e.Style.Font = New PurchaseOrderSystem.Controls.GridFontInfo(New Font("Segoe UI", 12, FontStyle.Bold, GraphicsUnit.Pixel))
            'To specify the text
            e.Style.Text = "Outside Process"
            'To specify the text color.
            'e.Style.TextColor = Color.Red

        End If


    End Sub
    Private Sub dtJobDet_SetDefaultValuesNeeded()

        For Each dc As DataColumn In dtJobDet.Columns
            If dc.ColumnName = "rcv_warehouse_id" Then
                dc.DefaultValue = clsUser.MtlWareHouseID
            ElseIf dc.ColumnName = "warehouse_code" Then
                dc.DefaultValue = (New classPurchaseNewEdit).GetMtlWareHouseCode(clsUser.MtlWareHouseID)
            ElseIf dc.ColumnName = "qty" Then
                dc.DefaultValue = 0.00
            ElseIf dc.ColumnName = "item_unit_price" Then
                dc.DefaultValue = 0.00
            ElseIf dc.ColumnName = "freight_per_unit" Then
                dc.DefaultValue = 0.00
            ElseIf dc.ColumnName = "price" Then
                dc.DefaultValue = 0.00
            ElseIf dc.ColumnName = "discper" Then
                dc.DefaultValue = 0.00
            ElseIf dc.ColumnName = "discamt" Then
                dc.DefaultValue = 0.00
            ElseIf dc.ColumnName = "lineamt" Then
                dc.DefaultValue = 0.00
            ElseIf dc.ColumnName = "gross_lineamt" Then
                dc.DefaultValue = 0.00
            ElseIf dc.ColumnName = "delidt" Then
                dc.DefaultValue = DBNull.Value
            ElseIf dc.ColumnName = "effective_date" Then
                dc.DefaultValue = DBNull.Value
            End If
        Next

    End Sub
    Private Sub formPurchaseOrderCreate_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized

        Call InitControl()
        Call getItcdAutocomplete()
        Call getCreditTremAutocomplete()
        Call InitDataBindingJob(_Jobno:=pJobno)
        Call InitDataBindingJobDet(_Jobno:=pJobno)


    End Sub

    Private Sub InitDataBindingJobDet(ByVal _Jobno As String)
        dtJobDet = (New classPurchaseNewEdit).GetJobDet(_jobno:=_Jobno)
        Call dtJobDet_SetDefaultValuesNeeded()
        bsJobDet.DataSource = dtJobDet
        bsJobDet.MoveFirst()
        dgvJobDet.AutoGenerateColumns = False
        dgvJobDet.DataSource = bsJobDet

    End Sub
    Private Sub InitDataBindingJob(ByVal _Jobno As String)

        dtJob = (New classPurchaseNewEdit).GetJob(_jobno:=_Jobno)
        If dtJob.Rows.Count = 0 Then
            Dim drNew As DataRow = dtJob.NewRow
            drNew("jobdt") = Now
            drNew("rcv_warehouse_id") = clsUser.MtlWareHouseID
            drNew("import") = False
            drNew("present_status") = "UN-APP"
            drNew("deliaddr") = (New classPurchaseNewEdit).GetDefaultDeliaddr(clsUser.UserID) '"����ѷ ���鹷� ��Ŵ� �����ῤ����� �ӡѴ " + vbCrLf + "1/92 ������ 2  �Ӻŷ�ҷ���  ��������ͧ��ط��Ҥ�  �ѧ��Ѵ��ط��Ҥ�  74000" '(New classPurchase).GetDeliaddr((New clsConfig).IsNull(clsUser.MtlWarehouseID, 1)) '"1 / 92 Moo.2 ,Rama II ,Road, Thasai, Muang, Samutsakorn. 74000"
            drNew("curr") = "THB"
            drNew("exrt") = 1

            drNew("gross_amt") = 0 'txtGrossLineamount
            drNew("line_discamt") = 0 'txtGrossLineDiscount
            drNew("net_lineamt") = 0 'txtNetLineAmount
            drNew("discper") = 0 'txtDisper
            drNew("discamt") = 0 'txtDiscountamount
            drNew("net_amt") = 0 'txtNetOrderAmount
            drNew("vat") = 0 'txtVat
            drNew("vatamt") = 0 'txtVatAmount
            drNew("totamt") = 0 'txtTotalAmount
            drNew("priceinclvat") = False 'Saharat 20221115
            dtJob.Rows.Add(drNew)
        End If
        bsJob.DataSource = dtJob
        bsJob.MoveFirst()
        drvJob = CType(bsJob.Current, DataRowView)

        Call BinddataJob()

    End Sub

    Private Sub BinddataJob()
        Call ClearDataBindings()

        txtPurNo.DataBindings.Add("text", bsJob, "jobno")
        DateYIN.DataBindings.Add("text", bsJob, "jobdt")

        comboItemNature.DataBindings.Add("selectedvalue", bsJob, "itnaturecd")
        txtdeliveryday.DataBindings.Add("text", bsJob, "delidays") 'Add Neung 20230519
        dtpaDeliveryDate.DataBindings.Add("BindableValue", bsJob, "delidt") 'Edit Neung 20230519 'Exp. Delivery dt:
        txtpackcd.DataBindings.Add("text", bsJob, "splins")
        txtremark.DataBindings.Add("text", bsJob, "rem")
        txtrate.DataBindings.Add("text", bsJob, "exrt")

        cboPaymentTerm.DataBindings.Add("selectedvalue", bsJob, "ap_payment_term_id") 'Sitthana 20210111 Changed Text to id
        txtPayModeCd.DataBindings.Add("text", bsJob, "paymodecd")
        'cboShipvia.DataBindings.Add("text", bsJob, "shipvia")
        cboShipvia.DataBindings.Add("selectedvalue", bsJob, "ship_via_id") 'Sitthana 20210111 Changed Text to id
        'cboIncoTerms.DataBindings.Add("text", bsJob, "shipterms")
        cboIncoTerms.DataBindings.Add("selectedvalue", bsJob, "inco_term_id") 'Sitthana 20210111 Changed Text to id
        textSupQuoteno.DataBindings.Add("text", bsJob, "supquoteno")
        txtCrterm.DataBindings.Add("text", bsJob, "crterm") 'Add By Neung 20220531
        ' Call getCreditTremAutocomplete()
        txtCrdays.DataBindings.Add("text", bsJob, "crdays") 'Sitthana 20210111 Changed to text Box
        textReqno.DataBindings.Add("text", bsJob, "reqno")
        comboEmp.DataBindings.Add("selectedvalue", bsJob, "empcd")
        cboDept.DataBindings.Add("selectedvalue", bsJob, "deptcd")
        cboSupplier.DataBindings.Add("selectedvalue", bsJob, "suppcd")
        cboCurrency.DataBindings.Add("selectedvalue", bsJob, "curr")
        txtBenefit.DataBindings.Add("text", bsJob, "benefit")
        txtPeriod.DataBindings.Add("text", bsJob, "approve_period")
        txtVehicleName.DataBindings.Add("text", bsJob, "vehicle_name")
        txtPortName.DataBindings.Add("text", bsJob, "port_name")
        txtAgencyName.DataBindings.Add("text", bsJob, "agency_name")
        txtBenefitAmount.DataBindings.Add("text", bsJob, "benefit_amount")
        txtPackingNo.DataBindings.Add("text", bsJob, "packing_no")
        txtInvoiceNo.DataBindings.Add("text", bsJob, "invoice_no")
        txtBLNo.DataBindings.Add("text", bsJob, "bl_no")
        txtPackingRemark.DataBindings.Add("text", bsJob, "packing_remark")

        dtpaDeparture.DataBindings.Add("BindableValue", bsJob, "estimate_departure")
        dtpaArrival.DataBindings.Add("BindableValue", bsJob, "estimate_arrival")
        txtBenefitKgs.DataBindings.Add("text", bsJob, "benefit_kgs")
        txtLCNo.DataBindings.Add("text", bsJob, "lc_no")
        dtpaLCDate.DataBindings.Add("BindableValue", bsJob, "lc_date")
        txtQuotationNo.DataBindings.Add("text", bsJob, "quotation_no")
        dtpaQuotationDate.DataBindings.Add("BindableValue", bsJob, "quotation_date")
        dtpaPacking_date.DataBindings.Add("BindableValue", bsJob, "packing_date")
        dtpaInvoice_date.DataBindings.Add("BindableValue", bsJob, "invoice_date")
        dtpaBL_date.DataBindings.Add("BindableValue", bsJob, "bl_date")
        txtAWB_no.DataBindings.Add("text", bsJob, "awb_no")
        dtpaAWB_date.DataBindings.Add("BindableValue", bsJob, "awb_date")
        dtpaAWB_Received_date.DataBindings.Add("BindableValue", bsJob, "awb_received_date")
        mcboPoLineType.DataBindings.Add("selectedvalue", bsJob, "po_line_types_id")
        txtPresentStatus.DataBindings.Add("text", bsJob, "present_status")
        txtFreight.DataBindings.Add("text", bsJob, "Freight") 'Sitthana 20210108
        checkImport.DataBindings.Add("Checked", bsJob, "import")

        txtGrossLineamount.DataBindings.Add("text", bsJob, "gross_amt")
        txtGrossLineDiscount.DataBindings.Add("text", bsJob, "line_discamt")
        txtNetLineAmount.DataBindings.Add("text", bsJob, "net_lineamt")

        txtDisper.DataBindings.Add("text", bsJob, "discper")
        txtDiscountamount.DataBindings.Add("text", bsJob, "discamt")

        txtNetOrderAmount.DataBindings.Add("text", bsJob, "net_amt")

        txtVat.DataBindings.Add("text", bsJob, "vat")
        txtVatAmount.DataBindings.Add("text", bsJob, "vatamt")

        txtTotalAmount.DataBindings.Add("text", bsJob, "totamt")

        cbPriceIncudingVat.DataBindings.Add("Checked", bsJob, "priceinclvat") 'saharat 20221115
        chkValidateQtyCone.DataBindings.Add("Checked", bsJob, "validate_qty_cone_yn", True, DataSourceUpdateMode.OnPropertyChanged)  'Neung 20250915
        AddHandler chkValidateQtyCone.DataBindings("Checked").Format, Sub(s, e)
                                                                          If e.Value IsNot Nothing AndAlso e.Value.ToString() = "Y" Then
                                                                              e.Value = True
                                                                          Else
                                                                              e.Value = False
                                                                          End If
                                                                      End Sub

        AddHandler chkValidateQtyCone.DataBindings("Checked").Parse, Sub(s, e)
                                                                         If CBool(e.Value) Then
                                                                             e.Value = "Y"
                                                                         Else
                                                                             e.Value = "N"
                                                                         End If
                                                                     End Sub
        txtEmailTo.DataBindings.Add("text", bsJob, "email_to") 'Neung 20250915
        txtEmailCC.DataBindings.Add("text", bsJob, "email_cc") 'Neung 20250915
        txtDeliAddr.DataBindings.Add("text", bsJob, "deliaddr") 'Neung 20260121
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

    Private Sub InitControl()
        Dim obj As Control
        For Each obj In Me.Controls
            Call SetControlValue(obj)
        Next
        Call EnabledControl(True)

        Call SetErrorProvider()

        ' -- Set Default 
        TabControl1.SelectedTab = TabPage1
        ' ----------------------   Supplier --------------------
        Call GetDataComboSupplier()
        Call GetDataComboDept()
        Call GetDataComboEmp()
        Call GetDataComboItemNature()
        ' ----------------------   Items    --------------------
        'Call GetDataComcoInDgridItems()
        Call GetDataComboInDgridUnit()
        Call GetDataComboCurrency()
        ' ----------------------   WareHouse & SubInventory 
        Call GetComboWarehouseID()
        '---------------------------
        Call GetDataMultiComboPOLineType()

        dtPaymentTerm = clsMaster.getAPPaymentTerm("N")
        With cboPaymentTerm
            .DataSource = dtPaymentTerm
            .DisplayMember = "term_name"
            .ValueMember = "ap_payment_term_id"
        End With

        dt = clsMaster.getLookupValueByValueType("SHIP_VIA", "N")
        With cboShipvia
            .DataSource = dt
            .DisplayMember = "lookup_value_code"
            .ValueMember = "lookup_value_id"
        End With

        dt = clsMaster.getLookupValueByValueType("SHIP_FWDER", "N")
        With cboForwarder
            .DataSource = dt
            .DisplayMember = "lookup_value_code"
            .ValueMember = "lookup_value_id"
        End With

        dt = clsMaster.getLookupValueByValueType("INCO_TERMS", "N")
        With cboIncoTerms
            .DataSource = dt
            .DisplayMember = "lookup_value_code"
            .ValueMember = "lookup_value_id"
        End With

        Me.colUom.DataSource = oPO.selectUomList 'Neung 20250915
        Me.colUom.DisplayMember = "uom"
        Me.colUom.ValueMember = "uom_id"

        Me.colUom2.DataSource = oPO.selectUomList 'Neung 20250915
        Me.colUom2.DisplayMember = "uom"
        Me.colUom2.ValueMember = "uom_id"

        'Me.mcboPoLineType.SelectedIndex = -1
        Me.comboEmp.SelectedValue = ""
        Me.cboDept.SelectedValue = ""
        'Me.cbCredit.SelectedValue = ""
        Me.txtCrdays.Text = "" 'Sitthana 20210111
        Me.cboCurrency.SelectedValue = ""
        Me.cboSupplier.SelectedIndex = -1

        dtpaPacking_date.Value = DateTimePicker.MinimumDateTime


    End Sub

    Private Sub EnabledControl(ByVal blnEnabled As Boolean)
        Dim obj As Control
        For Each obj In Me.Controls
            Call SetControlEnabled(obj, blnEnabled)
        Next

        txtPresentStatus.Enabled = False
        ' comboItemNature.Enabled = False

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
        If TypeOf Obj Is NullableDateTimePicker Then
            Dim dtp As NullableDateTimePicker = Obj
            dtp.BindableValue = DBNull.Value
            dtp.IsNullDate = True
        End If
        If TypeOf Obj Is ComboBox Then
            Dim cbo As ComboBox = Obj
            'cbo.SelectedIndex = -1
            cbo.Text = ""
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

        If TypeOf Obj Is MultiColumnComboBox Then
            Dim mcbo As MultiColumnComboBox = Obj
            'mcbo.SelectedValue = DBNull.Value
        End If

        'If TypeOf Obj Is DateTimePicker Then
        '    Dim dtp As DateTimePicker = Obj
        '    If dtp.Name = "coldelidt" Then
        '        dtp.CustomFormat = " "  'An empty SPACE
        '        dtp.Format = DateTimePickerFormat.Custom
        '        dtp.Value = "01/01/1900"
        '    ElseIf dtp.Name = "colEffectiveDate" Then
        '        dtp.CustomFormat = " "  'An empty SPACE
        '        dtp.Format = DateTimePickerFormat.Custom
        '        dtp.Value = CDate(Now)
        '    Else
        '        dtp.CustomFormat = " "  'An empty SPACE
        '        dtp.Format = DateTimePickerFormat.Custom
        '    End If

        'End If

    End Sub
    Private Sub SetErrorProvider()

    End Sub


    Private Sub SetControlEnabled(ByVal Obj As Control, ByVal blnEnabled As Boolean)
        If TypeOf Obj Is TextBox Then CType(Obj, TextBox).Enabled = blnEnabled
        If TypeOf Obj Is DateTimePicker Then Obj.Enabled = blnEnabled
        If TypeOf Obj Is ComboBox Then Obj.Enabled = blnEnabled
        If TypeOf Obj Is CheckBox Then Obj.Enabled = blnEnabled
        If TypeOf Obj Is RadioButton Then Obj.Enabled = blnEnabled

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

    Public Function SetDatetimepicker(ByVal Datetimepicker As DateTimePicker) As Boolean

        If Datetimepicker.Value = Nothing Then
            Datetimepicker.CustomFormat = " "  'An empty SPACE
            Datetimepicker.Format = DateTimePickerFormat.Custom
        End If

    End Function

    Private Sub GetDataComboCurrency()
        Dim GetdataItems As New GetDataYarn
        Dim ds As DataSet
        ds = GetdataItems.GetDataCurrency
        Me.cboCurrency.DataSource = ds.Tables(0)
        Me.cboCurrency.DisplayMember = "currname"
        Me.cboCurrency.ValueMember = "curr"
        Me.cboCurrency.SelectedValue = "THB"
    End Sub
    Private Sub GetComboWarehouseID()
        'Dim objdb As New classMaster
        'dtWarehouse = objdb.Combomtlwarehouse(clsUser.UserID)
        'cboWareHouseId.DataSource = dtWarehouse
        'cboWareHouseId.DisplayMember = "warehouse_code"
        'cboWareHouseId.ValueMember = "mtl_warehouse_id"
    End Sub
    'Private Sub GetComboWarehouseinGrid()
    '    Dim objdb As New classMaster
    '    rcv_warehouse_id.DataSource = objdb.Combomtlwarehouse(clsUser.UserID)
    '    rcv_warehouse_id.DisplayMember = "warehouse_code"
    '    rcv_warehouse_id.ValueMember = "mtl_warehouse_id"
    'End Sub
    'Private Sub GetcomboSubInventoryinGrid(ByVal Int64mtl_warehouse_id As Int64)
    '    Dim objdb As New classMaster
    '    rcv_subinventory_id.DataSource = objdb.GetCombomtl_subinventory(Int64mtl_warehouse_id)
    '    rcv_subinventory_id.DisplayMember = "subinventory_code"
    '    rcv_subinventory_id.ValueMember = "mtl_subinventory_id"
    'End Sub
    Private Sub GetDataMultiComboPOLineType()
        Dim GetdataItems As New GetDataYarn
        Dim dt As DataTable
        dt = GetdataItems.GetDataPOLineType


        Me.mcboPoLineType.DataSource = dt
        Me.mcboPoLineType.DisplayMember = "po_line_type_desc"
        Me.mcboPoLineType.ValueMember = "po_line_types_id"
        Me.mcboPoLineType.Text = ""
        Me.mcboPoLineType.ListBox.Grid.Model.Cols.Hidden(3) = True

        AddHandler TryCast(mcboPoLineType.ListControl, GridListBox).Grid.Model.QueryCellInfo, AddressOf Model_QueryCellInfo

    End Sub

    Private Sub GetDataComboInDgridUnit()
        Dim GetdataItems As New GetDataYarn
        Dim dt As DataTable
        dt = GetdataItems.GetDataUnit
        Me.colUom.DataSource = dt
        Me.colUom.DisplayMember = "uom"
        Me.colUom.ValueMember = "uom_id" 'Neung 20251010
    End Sub

    Private Sub GetDataComboItemNature()
        Dim getDatayarn As New GetDataYarn
        Dim dt As DataTable
        dt = getDatayarn.GetDataItemNature()
        Me.comboItemNature.DataSource = dt
        Me.comboItemNature.DisplayMember = "itnaturedesc"
        Me.comboItemNature.ValueMember = "itnaturecd"
        ' Me.comboItemNature.SelectedIndex = 0
    End Sub

    'Private Sub GetDataComcoInDgridItems()
    ' Dim GetdataItems As New GetDataYarn
    ' Dim dt As DataTable
    'dt = GetdataItems.GetDataItem
    ' dt = GetdataItems.GetDataItemcode("", comboItemNature.SelectedValue.ToString.Trim.ToUpper)
    ' Me.cboitcd.DataSource = dt
    ' Me.cboitcd.DisplayMember = "itcd_and_desc"
    'Me.cboitcd.ValueMember = "itcd"

    ' End Sub

    ' ----------------------   Supplier --------------------
    Private Sub GetDataComboSupplier()
        Dim GetdataComboSupp As New GetDataYarn
        Dim dt As DataTable
        dt = GetdataComboSupp.GetData_Suppliers()
        Me.cboSupplier.DataSource = dt
        Me.cboSupplier.DisplayMember = "name"
        Me.cboSupplier.ValueMember = "suppcd"

    End Sub
    Private Sub GetDataComboEmp()
        Dim getDatayarn As New GetDataYarn
        Dim dt As DataTable
        ' dt = getDatayarn.GetEmpList() 'Comment By Sitthana 24/03/2018

        dt = getDatayarn.GetEmpComboList 'Sitthana 24/03/2018
        Me.comboEmp.DataSource = dt
        Me.comboEmp.DisplayMember = "empname"
        Me.comboEmp.ValueMember = "empcd"
    End Sub

    Private Sub GetDataComboDept()
        Dim getDatayarn As New GetDataYarn
        Dim dt As DataTable
        dt = getDatayarn.GetDeptList()
        cboDept.DataSource = dt
        cboDept.DisplayMember = "deptname"
        cboDept.ValueMember = "deptcd"
    End Sub
    Private Sub AssignSupplierData()
        Dim GetdataAddr As New GetDataYarn
        Dim Obj_Supp As New tbl_Suppliers
        Dim msgerr As String = ""
        Dim Address As String

        If Me.CbSupplier.SelectedIndex = -1 Then
            MessageBox.Show("กรุณาเลือก Supplier ก่อนนะครับ", "ข้อผิดพลาด", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Exit Sub
        End If

        Obj_Supp = GetdataAddr.GetDataAddress(Me.CbSupplier.SelectedValue, msgerr)
        Address = Obj_Supp.addr1 & " " & Obj_Supp.addr2 & " " & Obj_Supp.addr3 & " " & Obj_Supp.addr1t & " " & Obj_Supp.addr2t & " " & Obj_Supp.addr3t & ", " & Obj_Supp.city & " " & Obj_Supp.ctry & " " & Obj_Supp.tel & " " & Obj_Supp.fax & " " & Obj_Supp.email & " " & Obj_Supp.contact
        Me.txtAddress.Text = Address
        'Me.txtcredit.Text = Obj_Supp.crdays
        m_import = Obj_Supp.import
        Me.checkImport.CheckState = m_import
    End Sub
    Private Sub CbSupplier_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboSupplier.SelectedIndexChanged
        'AssignSupplierData()
    End Sub


    Private Function CheckData() As Boolean
        Dim result As Boolean = True
        Dim MessageError As String = ""

        drvJob = CType(bsJob.Current, DataRowView)
        If (New clsConfig).IsNull(drvJob.Row("curr"), "").ToString.Trim <> "THB" And oConfig.IsNull(drvJob.Row("exrt"), 0) = 1 Then
            MessageError &= "ถ้าสกุลเงินเป็นสกุลเงินต่างประเทศ อัตราแลกเปลี่ยนต้องไม่เท่ากับ 1" & vbCrLf
            'MessageBox.Show("ถ้าสกุลเงินเป็นสกุลเงินต่างประเทศ อัตราแลกเปลี่ยนต้องไม่เท่ากับ 1" & vbCrLf &
            '               "If Currency equals foreigner then exchange rate not equals one", "System Meassge", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
            eptxtrate.SetError(Me.txtrate, "ถ้าสกุลเงินเป็นสกุลเงินต่างประเทศ อัตราแลกเปลี่ยนต้องไม่เท่ากับ 1" & vbCrLf & "If Currency equals foreigner then exchange rate not equals one")
            result = False
        Else
            eptxtrate.Clear()
        End If

        If oConfig.IsNull(drvJob.Row("suppcd"), "") = "" Then
            MessageError &= "ยังไม่ได้เลือก supplier" & vbCrLf
            'MessageBox.Show("��ͧ�� supplier", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
            Me.epcboSupplier.SetError(Me.cboSupplier, "Select a valid supplier")
            Me.TabControl1.SelectedTab = TabPage1
            result = False
        Else
            epcboSupplier.Clear()
        End If

        If oConfig.IsNull(drvJob.Row("empcd"), "") = "" Then
            MessageError &= "ยังไม่ได้เลือก Person Request" & vbCrLf
            'MessageBox.Show("��ͧ�� Person Request", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
            epcomboEmp.SetError(Me.comboEmp, "Select person who made the request..")
            result = False
        Else
            epcomboEmp.Clear()
        End If

        If oConfig.IsNull(drvJob.Row("curr"), "") = "" Then 'As String
            MessageError &= "ยังไม่ได้เลือก currency" & vbCrLf
            'MessageBox.Show("��ͧ�� currency", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
            epcboCurrency.SetError(Me.cboCurrency, "Select currency..")
            result = False
        Else
            epcboCurrency.Clear()
        End If

        If oConfig.IsNull(drvJob.Row("deptcd"), "") = "" Then
            MessageError &= "ยังไม่ได้เลือก Department" & vbCrLf
            ' MessageBox.Show("��ͧ�� Dept", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
            epcboDept.SetError(Me.cboDept, "Select Dept..")
            result = False
        Else
            epcboDept.Clear()
        End If

        If (New clsConfig).IsNull(drvJob.Row("ap_payment_term_id"), 0) = 0 Then
            MessageError &= "ยังไม่ได้เลือก Payment Term" & vbCrLf
            'MessageBox.Show("��ͧ�� Payment Term", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
            epcboPaymentTerm.SetError(Me.cboPaymentTerm, "Select Payment Term")
            result = False
        Else
            epcboPaymentTerm.Clear()
        End If

        If oConfig.IsNull(drvJob.Row("po_line_types_id"), 0) = 0 Then
            MessageError &= "ยังไม่ได้เลือก Line Type" & vbCrLf
            'MessageBox.Show("��ͧ�� Line Type", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
            epmcboPoLineType.SetError(Me.mcboPoLineType, "Select Line Type")
            result = False
        Else
            epmcboPoLineType.Clear()
        End If

        For Each dr As DataRow In dtJobDet.Rows
            If dr.RowState <> DataRowState.Deleted Then

                If Not (New classPurchaseNewEdit).ValidateItcd(StrItcd:=oConfig.IsNull(dr("itcd"), "")) Then
                    MessageError &= "แถวที่ " & (dtJobDet.Rows.IndexOf(dr) + 1).ToString.Trim & " " & "Item No ไม่ถูกต้อง" & vbCrLf
                    ' MessageBox.Show("��辺 Item Master ��к�", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
                    result = False
                End If

                If oConfig.IsNull(dr("uom_id"), 0) = 0 Then
                    MessageError &= "แถวที่ " & (dtJobDet.Rows.IndexOf(dr) + 1).ToString.Trim & " " & " ต้องระบุ UOM" & vbCrLf

                    'MessageBox.Show("��ͧ�� UOM", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
                    result = False
                End If

                If oConfig.IsNull(dr("rcv_warehouse_id"), 0) = 0 Then
                    MessageError &= "แถวที่ " & (dtJobDet.Rows.IndexOf(dr) + 1).ToString.Trim & " " & " ต้องระบุ W/H" & vbCrLf

                    ' MessageBox.Show("��ͧ�� W/H", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
                    result = False
                End If

                'If clsConfig.IsNull(dr("rcv_subinventory_id"), 0) = 0 Then
                'MessageBox.Show("��ͧ�� Sub Inventory", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
                'result = False
                'End If

                'If clsConfig.IsNull(dr("price"), 0) = 0 Then
                '    MessageBox.Show("��ͧ�� Price �ҡ���� 0", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
                '    result = False
                'End If

                If oConfig.IsNull(dr("qty"), 0) = 0 Then
                    MessageError &= "แถวที่ " & (dtJobDet.Rows.IndexOf(dr) + 1).ToString.Trim & " " & "ต้องระบุ Qty มากกว่า 0" & vbCrLf

                    ' MessageBox.Show("��ͧ�� Qty �ҡ���� 0", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
                    result = False
                End If
            End If
        Next

        If result = False Then
            MessageBox.Show(MessageError, "System Message", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
        End If

        Return result
    End Function
    Private Function Validate_Items(Optional ByVal StrItcd As String = "") As Boolean
        Dim objdb As New classMaster
        Dim dt As DataTable = objdb.Validate_Items(StrItcd)

        If dt.Rows.Count > 0 Then
            Return True
        Else
            Return False
        End If


    End Function



    Private Sub txtdeliveryday_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtdeliveryday.TextChanged
        Dim d As Integer
        If IsNumeric(Me.txtdeliveryday.Text.Trim) = True Then
            d = CDec(Me.txtdeliveryday.Text.Trim)
        Else
            d = 0
        End If
        Me.dtpaDeliveryDate.BindableValue = Me.DateYIN.Value.AddDays(d)

    End Sub

    Private Sub txtShipvia_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send("{tab}")
        End If
    End Sub

    Private Sub txtcredit_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCrdays.TextChanged
        Dim d As Integer
        If IsNumeric(Me.txtCrdays.Text.Trim) = True Then
            d = CDec(Me.txtCrdays.Text.Trim)
        Else
            d = 0
        End If
        Me.dtpaPayDate.BindableValue = Now().AddDays(d)

    End Sub

    Private Sub BtnYarnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub

    Private Sub calc_final_totals() 'NO USE 
        Dim m_CurrExchangeRate As Decimal = 0
        Dim m_GrossLineAmt As Decimal = 0
        Dim m_GrossLineDisc As Decimal = 0
        Dim m_NetLineAmt As Decimal = 0
        Dim m_OrderDiscPer As Decimal = 0
        Dim m_OrderDiscAmt As Decimal = Val(IIf(IsNumeric(txtDiscountamount.Text.Replace(",", "")), txtDiscountamount.Text.Replace(",", ""), 0))
        Dim m_NetOrderAmt As Decimal = 0
        Dim m_VATPer As Decimal = 0
        Dim m_VATAmt As Decimal = Val(IIf(IsNumeric(txtVatAmount.Text.Replace(",", "")), txtVatAmount.Text.Replace(",", ""), 0))
        Dim m_NetOrderAmtAfterVAT As Decimal = 0

        'Call sumLineTotals()

        m_CurrExchangeRate = Val(IIf(IsNumeric(txtrate.Text), txtrate.Text, 0))
        m_CurrExchangeRate = IIf(m_CurrExchangeRate <= 0, 1, m_CurrExchangeRate)
        m_GrossLineAmt = sumGrossAmt * m_CurrExchangeRate
        m_GrossLineDisc = sumDiscAmt * m_CurrExchangeRate

        m_NetLineAmt = m_GrossLineAmt - m_GrossLineDisc
        m_OrderDiscPer = Val(IIf(IsNumeric(txtDisper.Text), txtDisper.Text, 0))
        If m_OrderDiscPer = 0 Then
            If m_OrderDiscAmt = 0 Then
                m_OrderDiscPer = 0
            Else
                m_OrderDiscPer = Math.Round(((oConfig).NullIF(m_OrderDiscAmt, DBNull.Value) / m_NetLineAmt) * 100, 2)
            End If
        End If
        m_OrderDiscAmt = m_NetLineAmt * m_OrderDiscPer * 0.01
        m_NetOrderAmt = m_NetLineAmt - m_OrderDiscAmt
        m_VATPer = Val(IIf(IsNumeric(txtVat.Text), txtVat.Text, 0))
        If m_VATPer = 0 Then
            If m_VATAmt = 0 Then
                m_VATPer = 0
            Else
                m_VATPer = Math.Round((m_VATAmt / (oConfig).NullIF(m_NetOrderAmt, DBNull.Value)) * 100, 2)
            End If
        End If
        m_VATAmt = m_NetOrderAmt * m_VATPer * 0.01
        m_NetOrderAmtAfterVAT = m_NetOrderAmt + m_VATAmt

        txtrate.Text = FormatNumber((New clsConfig).IsNull(m_CurrExchangeRate, 0), 2, TriState.False, TriState.False, TriState.True)
        txtGrossLineamount.Text = FormatNumber((New clsConfig).IsNull(m_GrossLineAmt, 0), 2, TriState.False, TriState.False, TriState.True)
        txtGrossLineDiscount.Text = FormatNumber((New clsConfig).IsNull(m_GrossLineDisc, 0), 2, TriState.False, TriState.False, TriState.True)
        txtNetLineAmount.Text = FormatNumber((New clsConfig).IsNull(m_NetLineAmt, 0), 2, TriState.False, TriState.False, TriState.True)
        txtDisper.Text = FormatNumber((New clsConfig).IsNull(m_OrderDiscPer, 0), 2, TriState.False, TriState.False, TriState.True)
        txtDiscountamount.Text = FormatNumber((New clsConfig).IsNull(m_OrderDiscAmt, 0), 2, TriState.False, TriState.False, TriState.True)
        txtNetOrderAmount.Text = FormatNumber((New clsConfig).IsNull(m_NetOrderAmt, 0), 2, TriState.False, TriState.False, TriState.True)
        txtVat.Text = FormatNumber((New clsConfig).IsNull(m_VATPer, 0), 2, TriState.False, TriState.False, TriState.True)
        txtVatAmount.Text = FormatNumber((New clsConfig).IsNull(m_VATAmt, 0), 2, TriState.False, TriState.False, TriState.True)
        txtTotalAmount.Text = FormatNumber((New clsConfig).IsNull(m_NetOrderAmtAfterVAT, 0), 2, TriState.False, TriState.False, TriState.True)


    End Sub

    Private Sub sumLineTotals()
        Qty = 0
        UnitPrice = 0
        Discper = 0
        sumDiscAmt = 0
        sumGrossAmt = 0

        Dim i As Integer

        For i = 0 To Me.dgvJobDet.Rows.Count - 2
            Me.dgvJobDet.Rows(i).Cells("colitem_unit_price").Value = oConfig.IsNull(Me.dgvJobDet.Rows(i).Cells("colitem_unit_price").Value, 0)
            Me.dgvJobDet.Rows(i).Cells("colfreight_per_unit").Value = oConfig.IsNull(Me.dgvJobDet.Rows(i).Cells("colfreight_per_unit").Value, 0) '
            Me.dgvJobDet.Rows(i).Cells("colprice").Value = Convert.ToDecimal(Me.dgvJobDet.Rows(i).Cells("colitem_unit_price").Value) + Me.dgvJobDet.Rows(i).Cells("colfreight_per_unit").Value

            Qty = (New clsConfig).IsNull(Me.dgvJobDet.Rows(i).Cells("colQty").Value, 0)
            UnitPrice = (New clsConfig).IsNull(Me.dgvJobDet.Rows(i).Cells("colPrice").Value, 0)
            Discper = (New clsConfig).IsNull(dgvJobDet.Rows(i).Cells("colDiscper").Value, 0)
            Discamt = (New clsConfig).IsNull(Me.dgvJobDet.Rows(i).Cells("colDiscamt").Value, 0)

            If Discper > 0 Then
                Discamt = ((Qty * UnitPrice) * Discper) / 100
            Else
                If Discamt > 0 Then
                    Discper = (Discamt * 100) / (Qty * UnitPrice)
                    dgvJobDet.Rows(i).Cells("colDiscper").Value = Discper
                End If 'Sitthana 20240605
            End If

            Me.dgvJobDet.Rows(i).Cells("colDiscamt").Value = Discamt

            Me.dgvJobDet.Rows(i).Cells("colLineamt").Value = (Qty * UnitPrice) - ((Qty * UnitPrice) * Discper) / 100
            sumDiscAmt = sumDiscAmt + Me.dgvJobDet.Rows(i).Cells("colDiscAmt").Value
            sumGrossAmt = sumGrossAmt + (Qty * UnitPrice)
        Next

        Me.txtDiscountamount.Text = String.Format("{0:#,###0.00}", sumDiscAmt)  ' sumDiscAmt
        Me.txtGrossLineamount.Text = String.Format("{0:#,###0.00}", sumGrossAmt) 'sumGrossAmt
        Dim grossamount As Double
        Dim vat As Double
        vat = Val(Me.txtVat.Text)
        grossamount = sumGrossAmt
        txtVatAmount.Text = String.Format("{0:#,###0.00}", (grossamount * vat) / 100) '(grossamount * vat) / 100
        Dim discountamount As Double
        Dim taxamount As Double
        VatAmt = (grossamount * vat) / 100
        discountamount = sumDiscAmt
        Dim Argtotalamount As Double
        Argtotalamount = grossamount - (VatAmt + taxamount + txtVatAmount.Text + discountamount)
        Me.txtTotalAmount.Text = String.Format("{0:#,###0.00}", (New clsConfig).IsNull(Argtotalamount, 0))

    End Sub

    Private Sub BtnYarnPrintDoc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim str As String
        str = ""
        ds.Clear()
        If Me.txtPurNo.Text.Trim = "" Then
            Exit Sub
        End If
        str = "select * from v_pur where jobno = '" & Me.txtPurNo.Text.Trim & "'"
        Dim myda As New SqlDataAdapter(str.ToString, clsConnection.connection)
        myda.Fill(ds, "Tblprint")
        If ds.Tables("Tblprint").Rows.Count > 0 Then
            If Not PrintReport(ds) Then
                'Dim frmreport As New FormRptPurchaseOrderCreate
                'Dim obj As New RptPurchaseOrderCreate
                'obj.SetDataSource(ds.Tables("Tblprint"))
                'frmreport.CrystalReportViewer1.ReportSource = obj
                'frmreport.ShowDialog()
            End If
        End If
    End Sub

    Private Function PrintReport(ByVal ds As DataSet) As Boolean
        Dim clsConn As New classConnection()
        ''Const rptFileName = "RptPurchaseOrderCreate.rpt"
        Dim rptFileName = "RptPurchaseOrderV2.rpt"
        If Not oConfig.CheckReport(clsUser.ReportPath, rptFileName) Then Return False
        Dim frm As New frmReport
        Dim rpt As New CrystalDecisions.CrystalReports.Engine.ReportDocument
        Me.Cursor = Cursors.WaitCursor

        rpt.Load(clsUser.ReportPath & rptFileName)
        rpt.DataSourceConnections.Item(0).SetConnection(clsConn.servername, clsConn.database, False)
        rpt.DataSourceConnections.Item(0).SetLogon(clsConn.Userid, clsConn.Password)
        'rpt.SetDataSource(ds.Tables("Tblprint"))
        rpt.SetParameterValue("@jobno", txtPurNo.Text.Trim) 'Sitthana 20210113

        rpt.PrintOptions.PaperSize = CrystalDecisions.Shared.PaperSize.PaperA4
        rpt.PrintOptions.PaperOrientation = CrystalDecisions.Shared.PaperOrientation.Portrait
        rpt.PrintOptions.PaperSource = CrystalDecisions.Shared.PaperSource.Auto

        frm.Title = "Purchase Order"
        frm.CRViewer.ReportSource = rpt
        frm.MdiParent = Me.ParentForm
        frm.Show()
        Me.Cursor = Cursors.Default
        Return True
    End Function
    Private Sub comboItemNature_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles comboItemNature.SelectedIndexChanged
        'Call GetItemCode()
        'GetDataComcoInDgridItems()
    End Sub

    Private Sub cboCurrency_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboCurrency.SelectedIndexChanged
        'If Not IsDBNull(cboCurrency.DataSource) And cboCurrency.ValueMember = "curr" Then
        '    If Not (New clsConfig).IsNull(cboCurrency.SelectedValue, "") = "" And Not (New clsConfig).IsNull(cboCurrency.SelectedValue, "") = "THB" Then
        '        txtrate.Text = (New classPurchaseNewEdit).GetExchageRate(cboCurrency.SelectedValue())
        '    ElseIf (New clsConfig).IsNull(cboCurrency.SelectedValue, "") = "THB" Then
        '        txtrate.Text = "1"
        '    End If
        'End If
    End Sub

    Private Sub DtpPacking_date_ValueChanged(sender As System.Object, e As System.EventArgs)
        ' DtpPacking_date.CustomFormat = "dd/MM/yyyy"

    End Sub

    Private Sub dtpLCDate_ValueChanged(sender As System.Object, e As System.EventArgs)
        ' dtpLCDate.CustomFormat = "dd/MM/yyyy"
    End Sub

    Private Sub dtpQuotationDate_ValueChanged(sender As System.Object, e As System.EventArgs)
        ' dtpQuotationDate.CustomFormat = "dd/MM/yyyy"
    End Sub

    Private Sub DtpInvoice_date_ValueChanged(sender As System.Object, e As System.EventArgs)
        ' DtpInvoice_date.CustomFormat = "dd/MM/yyyy"
    End Sub

    Private Sub DtpBL_date_ValueChanged(sender As System.Object, e As System.EventArgs)
        ' DtpBL_date.CustomFormat = "dd/MM/yyyy"
    End Sub

    Private Sub DtpAWB_date_ValueChanged(sender As System.Object, e As System.EventArgs)
        ' DtpAWB_date.CustomFormat = "dd/MM/yyyy"
    End Sub

    Private Sub DtpAWB_Received_date_ValueChanged(sender As System.Object, e As System.EventArgs)
        ' DtpAWB_Received_date.CustomFormat = "dd/MM/yyyy"
    End Sub

    Private Sub dtpDeparture_ValueChanged(sender As System.Object, e As System.EventArgs)
        ' dtpDeparture.CustomFormat = "dd/MM/yyyy"
    End Sub

    Private Sub dtpArrival_ValueChanged(sender As System.Object, e As System.EventArgs)
        ' dtpArrival.CustomFormat = "dd/MM/yyyy"
    End Sub

    Private Sub btnSuppSearch_Click(sender As Object, e As EventArgs) Handles btnSuppSearch.Click
        Dim f As New Classes.formSearchSupplier
        Dim drv As DataRowView
        Dim SearchResult As New Classes.SearchFormResult
        ' pass nothing to use default connection string inside the class or pass your connection object if need to use different from default.
        f.setConnectionString(clsConnection.getSQLConnection)
        SearchResult = f.ShowSuppliers()
        f.Close()
        f.Dispose()
        drv = SearchResult.ResultRowView
        If SearchResult.ButtonClicked = "OK" Then
            drv = SearchResult.ResultRowView
            cboSupplier.SelectedValue = drv.Item("suppcd")
        End If
    End Sub
    Private Function LovSoitm(ByVal pFilterText As String, ByRef errorMessage As String) As Boolean
        'Dim result As Boolean '= (textBox.Text = text)
        Dim frmLov As New frmListOfValues("SOITM")
        frmLov.AppConnection = _AppConn
        frmLov.AppUserId = UserInfo.UserID
        frmLov.AppSessionID = 0 'UserInfo.UserSessionID
        ' frmLov.pAppUserWarehouse = UserInfo.WarehouseCode
        frmLov.pFilterText = oConfig.IsNull(pFilterText, "")
        Me.Cursor = Cursors.WaitCursor
        frmLov.ShowFrm()
        Me.Cursor = Cursors.Default
        Select Case frmLov.pUserAction
            Case "OK", "NONE"
                drvJobDet = CType(bsJobDet.Current, DataRowView)
                drvJobDet.Row.BeginEdit()
                drvJobDet.Row("sono") = oConfig.IsNull(frmLov.pdrvSearchTable.Row("sono"), DBNull.Value)
                drvJobDet.Row("sonoid") = oConfig.IsNull(frmLov.pdrvSearchTable.Row("sonoid"), DBNull.Value)
                'drvJobDet.Row("itcd") = oConfig.IsNull(frmLov.pdrvSearchTable.Row("itcd"), DBNull.Value)
                'drvJobDet.Row("itdesc") = oConfig.IsNull(frmLov.pdrvSearchTable.Row("itdesc"), DBNull.Value)
                'drvJobDet.Row("qty") = oConfig.IsNull(frmLov.pdrvSearchTable.Row("qty"), DBNull.Value)
                'drvJobDet.Row("uom") = oConfig.IsNull(frmLov.pdrvSearchTable.Row("uom"), DBNull.Value)
                drvJobDet.Row.EndEdit()
                bsJobDet.EndEdit()
                dgvJobDet.RefreshEdit()
                Return True
            Case Else
                errorMessage = "S/O Line No. is missing"
                Return False
        End Select

        '  errorMessage = "Items No. is missing"
        '   Return False
    End Function

    Private Sub dgvJobDet_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvJobDet.CellDoubleClick
        Dim currentColIndex As Integer = dgvJobDet.CurrentCell.ColumnIndex
        Dim currentColName As String = dgvJobDet.Columns(currentColIndex).Name
        Dim dgr As DataGridViewRow = dgvJobDet.CurrentRow
        Dim errorMsg As String = ""

        Select Case dgvJobDet.Columns(e.ColumnIndex).Name
            Case "colItcd"
                Dim frm As New frmSelectItems
                frm.ShowDialog(Me)
                If frm.pblnOk = True Then
                    dgr.Cells("colItemId").Value = (New clsConfig).IsNull(frm.pItemID, DBNull.Value)
                    dgr.Cells("colItcd").Value = (New clsConfig).IsNull(frm.pItcd, "").ToString.Trim
                    dgr.Cells("colItdesc").Value = (New clsConfig).IsNull(frm.pItdescSupp, "").ToString.Trim
                    dgr.Cells("colUom").Value = frm.pUomID 'Neung 20251010
                    bsJobDet.EndEdit()
                End If
            Case "supquoteno", "colMfgProductionOrderLineId"
                Dim frmSelectProductionOrderLines As New frmSelectProductionOrderLinesHeader
                frmSelectProductionOrderLines.ShowDialog(Me)
                If frmSelectProductionOrderLines.pblnOk = True Then
                    dgr.Cells("supquoteno").Value = frmSelectProductionOrderLines.pKoNo
                    dgr.Cells("colMfgProductionOrderLineId").Value = frmSelectProductionOrderLines.pMfgProductionOrderLineId
                    bsJobDet.EndEdit()
                End If '
            Case "rcv_warehouse_id", "colWareHouseCode"
                Dim frmSelectMtlWareHouse As New frmSelectMtlWareHouse
                frmSelectMtlWareHouse.ShowDialog(Me)
                If frmSelectMtlWareHouse.pblnOk = True Then
                    dgr.Cells("rcv_warehouse_id").Value = frmSelectMtlWareHouse.pMtlwarehouseid
                    dgr.Cells("colWareHouseCode").Value = frmSelectMtlWareHouse.pWarehouseCode
                    dgr.Cells("rcv_subinventory_id").Value = DBNull.Value
                    dgr.Cells("colSourceSubInventoryCode").Value = DBNull.Value
                    bsJobDet.EndEdit()
                End If
            Case "rcv_subinventory_id", "colSourceSubInventoryCode"
                If Not dgr.Cells("rcv_warehouse_id").Value Is DBNull.Value Then
                    Dim frmSelectMtlSubinventory As New frmSelectMtlSubinventory
                    frmSelectMtlSubinventory.pMtlwarehouseid = dgr.Cells("rcv_warehouse_id").Value
                    frmSelectMtlSubinventory.ShowDialog(Me)
                    If frmSelectMtlSubinventory.pblnOk = True Then
                        dgr.Cells("rcv_subinventory_id").Value = frmSelectMtlSubinventory.pmtlsubinventoryid
                        dgr.Cells("colSourceSubInventoryCode").Value = frmSelectMtlSubinventory.pSubinventorycode
                        bsJobDet.EndEdit()
                    End If
                End If
            Case "colSoNo", "colSoNoId"
                If Not LovSoitm("%", errorMsg) Then
                    dgvJobDet.Rows(e.RowIndex).ErrorText = errorMsg
                Else
                    dgvJobDet.Rows(e.RowIndex).ErrorText = ""
                End If
        End Select

        'If currentColName = "colSono" Then
        '    Dim frm As New frmSelectSO
        '    'frm.pSoNo = dgr.Cells("colSono").Value
        '    frm.ShowDialog(Me)
        '    If frm.pblnOk = True Then
        '        dgr.Cells("colSono").Value = frm.pSoNo

        '        If Not (New clsConfig).IsNull(dgr.Cells("colsonoid").Value, "") = "" Then
        '            dgr.Cells("colsonoid").Value = ""
        '        End If
        '        bsJobDet.EndEdit()
        '    End If
        'End If

        'If currentColName = "colSoNoId" Then
        '    If Not dgr.Cells("colSoNo").Value Is DBNull.Value Then
        '        Dim frm As New frmSelectSOItm
        '        frm.pSoNo = dgr.Cells("colSoNo").Value
        '        frm.ShowDialog(Me)
        '        If frm.pblnOk = True Then
        '            dgr.Cells("colSono").Value = frm.pSoNo
        '            dgr.Cells("colSoNoId").Value = frm.pSoNoID
        '            '======= items
        '            If (New clsConfig).IsNull(dgr.Cells("colItcd").Value, "") = "" Then
        '                dgr.Cells("colItcd").Value = frm.pDesignNo
        '            Else
        '                If (New clsConfig).IsNull(dgr.Cells("colItcd").Value, "") <> frm.pDesignNo Then
        '                    Dim result As System.Windows.Forms.DialogResult
        '                    result = MessageBox.Show("Item Code Is incorrect." & vbCrLf & "Would you Like To change Item Code ?", "System Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)
        '                    If result = DialogResult.Yes Then dgr.Cells("colItcd").Value = frm.pDesignNo
        '                End If
        '            End If
        '            '====== Descpition 
        '            If (New clsConfig).IsNull(dgr.Cells("colItdesc").Value, "") = "" Then
        '                dgr.Cells("colItdesc").Value = Trim(frm.pDesignNo) + "-" + Trim(frm.pCol)
        '            End If
        '            '====== Qty
        '            If (New clsConfig).IsNull(dgr.Cells("colqty").Value, 0) = 0 Then
        '                dgr.Cells("colqty").Value = frm.pQty
        '            Else
        '                If (New clsConfig).IsNull(dgr.Cells("colQty").Value, 0) <> (New clsConfig).IsNull(frm.pQty, 0) Then
        '                    Dim result As System.Windows.Forms.DialogResult
        '                    result = MessageBox.Show("Qty Is incorrect." & vbCrLf & "Would you Like To change Qty ?", "System Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)
        '                    If result = DialogResult.Yes Then dgr.Cells("colQty").Value = frm.pQty
        '                End If
        '            End If
        '            '====== Uom
        '            If (New clsConfig).IsNull(dgr.Cells("colUom").Value, 0) = 0 Then
        '                dgr.Cells("colUom").Value = frm.pUomID
        '            Else
        '                If (New clsConfig).IsNull(dgr.Cells("colUom").Value, 0) <> frm.pUomID Then
        '                    Dim result As System.Windows.Forms.DialogResult
        '                    result = MessageBox.Show("UOM Is incorrect." & vbCrLf & "Would you Like To change UOM ?", "System Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)
        '                    If result = DialogResult.Yes Then dgr.Cells("colUom").Value = frm.pUomID
        '                End If
        '            End If
        '            bsJobDet.EndEdit()
        '        End If
        '    End If
        'End If


    End Sub

    Private Sub TabPage2_Click(sender As Object, e As EventArgs) Handles TabPage2.Click

    End Sub

    Private Sub btnGetSoItmData_Click(sender As Object, e As EventArgs) Handles btnGetSoItmData.Click

        Dim f As New Classes.frmSearchSoNo
        Dim drv As DataRowView
        Dim SearchResult As New Classes.SearchFormResult
        ' pass nothing to use default connection string inside the class or pass your connection object if need to use different from default.
        f.setConnectionString(clsConnection.getSQLConnection)
        f.logempcd = clsUser.UserName
        SearchResult = f.ShowFrm
        f.Close()
        f.Dispose()
        If SearchResult.ButtonClicked = "OK" Then
            drv = SearchResult.ResultRowView
            Call GetSoItmData(drv.Item("sono"))

        End If

        Me.Validate()
    End Sub

    Private Sub GetSoItmData(ByVal _SoNo As String)

        Dim dtSoitm As New DataTable
        dtSoitm = (New classPurchaseNewEdit).GetPoItemFromSoitm(_sono:=_SoNo)

        For Each dr As DataRow In dtSoitm.Rows
            dtJobDet.ImportRow(dr) 'Table ko
            cboCurrency.SelectedValue = dr("curr")
            txtrate.Text = dr("exrt")
        Next dr

        For Each dr As DataRow In dtJobDet.Rows
            If dr.RowState <> DataRowState.Deleted Then
                dr("item_unit_price") = 0
                dr("freight_per_unit") = 0
            End If
        Next
        Me.Validate()

    End Sub

    Private Sub btnNew_Click(sender As Object, e As EventArgs)

        Call InitControl()
        Call InitDataBindingJob(_Jobno:="")
        Call InitDataBindingJobDet(_Jobno:="")

    End Sub

    Private Sub txtPurNo_KeyDown(sender As Object, e As KeyEventArgs) Handles txtPurNo.KeyDown
        If e.KeyCode = Keys.Enter Then
            Dim pJobno As String = txtPurNo.Text.Trim
            Call InitDataBindingJob(_Jobno:=pJobno)
            Call InitDataBindingJobDet(_Jobno:=pJobno)
        End If
    End Sub

    Private Sub tsbNew_Click(sender As Object, e As EventArgs) Handles tsbNew.Click
        Me.Validate()
        Call btnNew_Click(sender:=sender, e:=e)
    End Sub

    Private Function SaveData() As Boolean
        Dim msgerr As String = ""
        drvJob = CType(bsJob.Current, DataRowView)
        'dtJobDet = bsJobDet.DataSource

        If (New classPurchaseNewEdit).SavePurchaseOrder(drvJob, dtJobDet, msgerr, clsUser.UserID) Then
            txtPurNo.Text = drvJob.Row("jobno")
            MessageBox.Show("บันทึกสำเร็จ " & txtPurNo.Text.Trim, "System Message", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)

            SaveData = True
        Else
            MessageBox.Show(msgerr, "System Message", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
            SaveData = False
        End If

    End Function

    Private Sub btnSave_Click(sender As Object, e As EventArgs)
        Me.Validate()

        blnCancel = False
        Dim result As System.Windows.Forms.DialogResult
        result = MessageBox.Show("Would you Like To save ?" & vbCrLf &
        IIf(IIf(txtPurNo.Text.Trim.Length = 0, txtPurNo.Text.Trim, txtPurNo.Text.Trim).ToString.Trim.Length = 0, "** ระบบจะออก P/O No. ให้อัตโนมัติ **", "P/O No. = '" & IIf(txtPurNo.Text.Trim.Length = 0, txtPurNo.Text.Trim, txtPurNo.Text.Trim) & "'"),
        "System Message", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button3)

        If result = System.Windows.Forms.DialogResult.Cancel Then blnCancel = True
        If result <> System.Windows.Forms.DialogResult.Yes Then Exit Sub

        If Not CheckData() Then Exit Sub
        Me.Cursor = Cursors.WaitCursor
        If SaveData() Then
            Call InitDataBindingJob(txtPurNo.Text.Trim)
            Call InitDataBindingJobDet(txtPurNo.Text.Trim)
        End If
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub tsbSave_Click(sender As Object, e As EventArgs) Handles tsbSave.Click
        Me.Validate()
        bsJob.EndEdit()

        blnCancel = False
        Dim result As System.Windows.Forms.DialogResult
        result = MessageBox.Show("Would you like to save ?" & vbCrLf &
        IIf(IIf(txtPurNo.Text.Trim.Length = 0, txtPurNo.Text.Trim, txtPurNo.Text.Trim).ToString.Trim.Length = 0, "** ระบบจะออก P/O No. ให้อัตโนมัติ **", "P/O No. = '" & IIf(txtPurNo.Text.Trim.Length = 0, txtPurNo.Text.Trim, txtPurNo.Text.Trim) & "'"),
        "System Message", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button3)

        If result = System.Windows.Forms.DialogResult.Cancel Then blnCancel = True
        If result <> System.Windows.Forms.DialogResult.Yes Then Exit Sub

        If Not CheckData() Then Exit Sub
        Me.Cursor = Cursors.WaitCursor
        If SaveData() Then
            Call InitDataBindingJob(txtPurNo.Text.Trim)
            Call InitDataBindingJobDet(txtPurNo.Text.Trim)
        End If
        Me.Cursor = Cursors.Default

    End Sub

    Private Sub tsbMinimized_Click(sender As Object, e As EventArgs) Handles tsbMinimized.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub


    Private Sub cboPaymentTerm_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cboPaymentTerm.SelectionChangeCommitted
        If dtPaymentTerm.Rows.Count > 0 Then
            'Add By Neung 20230531
            Dim selectedDataRowView As DataRowView = TryCast(cboPaymentTerm.SelectedItem, DataRowView)
            If selectedDataRowView IsNot Nothing Then
                Dim currentDataRow As DataRow = selectedDataRowView.Row
                ' Use the currentDataRow as needed
                txtPayModeCd.Text = currentDataRow("paymodecd")
                'txtCrterm.Text = currentDataRow("crterm")
                txtCrterm.Text = currentDataRow("term_name") 'Sitthana 20240618
                txtCrdays.Text = currentDataRow("credit_days")
            End If

            'txtPayModeCd.Text = dtPaymentTerm.Rows(cboPaymentTerm.SelectedIndex)("paymodecd")
            'txtCrterm.Text = dtPaymentTerm.Rows(cboPaymentTerm.SelectedIndex)("crterm")
            'txtCrdays.Text = dtPaymentTerm.Rows(cboPaymentTerm.SelectedIndex)("credit_days")
        End If
    End Sub

    Private Sub btnGetBOMLine_Click(sender As Object, e As EventArgs) Handles btnGetBOMLine.Click
        Dim f As New Classes.frmSearchSoNo
        Dim drv As DataRowView
        Dim SearchResult As New Classes.SearchFormResult
        ' pass nothing to use default connection string inside the class or pass your connection object if need to use different from default.
        f.setConnectionString(clsConnection.getSQLConnection)
        f.logempcd = clsUser.UserName
        SearchResult = f.ShowFrm
        f.Close()
        f.Dispose()
        If SearchResult.ButtonClicked = "OK" Then
            drv = SearchResult.ResultRowView
            ' Call GetSoItmData(drv.Item("sono"))
        End If

        Me.Validate()
    End Sub

    Private Sub tsbPrintPO_Click(sender As Object, e As EventArgs) Handles tsbPrintPO.Click
        'Dim str As String
        'str = ""
        'ds.Clear()
        'If Me.txtPurNo.Text.Trim = "" Then
        '    Exit Sub
        'End If
        'str = "select * from v_pur where jobno = '" & Me.txtPurNo.Text.Trim & "'"
        'Dim myda As New SqlDataAdapter(str.ToString, clsConnection.connection)
        'myda.Fill(ds, "Tblprint")
        'If ds.Tables("Tblprint").Rows.Count > 0 Then
        '    If Not PrintReport(ds) Then
        '        'Dim frmreport As New FormRptPurchaseOrderCreate
        '        'Dim obj As New RptPurchaseOrderCreate
        '        'obj.SetDataSource(ds.Tables("Tblprint"))
        '        'frmreport.CrystalReportViewer1.ReportSource = obj
        '        'frmreport.ShowDialog()
        '    End If
        'End If
    End Sub

    Private Sub tsbExit_Click(sender As Object, e As EventArgs) Handles tsbExit.Click
        Me.Close()
    End Sub

    Private Sub buttonSearchPO_Click(sender As Object, e As EventArgs) Handles buttonSearchPO.Click

        Dim frm As New formSearchPO
        frm.ShowDialog()
        If frm.puserAction = "OK" Then
            Me.txtPurNo.Text = frm.pSelectedPO
            Call InitDataBindingJob(Me.txtPurNo.Text)
            Call InitDataBindingJobDet(Me.txtPurNo.Text)
        End If
    End Sub



    Private Function ApproveData() As Boolean
        Dim msgerr As String = ""
        Dim pRemApp As String = ""
        drvJob = CType(bsJob.Current, DataRowView)
        'dtJobDet = bsJobDet.DataSource
        pRemApp = InputBox("enter remark to approve", "System Message", "")

        If (New classPurchaseNewEdit).ApprovePurchaseOrder(drvJob.Row("jobno"), pRemApp, msgerr, clsUser.UserID) Then
            txtPurNo.Text = drvJob.Row("jobno")
            MessageBox.Show("Approve สำเร็จ " & txtPurNo.Text.Trim, "System Message", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)

            ApproveData = True
        Else
            MessageBox.Show(msgerr, "System Message", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
            ApproveData = False
        End If

    End Function

    Private Sub btnApprove_Click(sender As Object, e As EventArgs) Handles btnApprove.Click
        Me.Validate()

        blnCancel = False
        Dim result As System.Windows.Forms.DialogResult
        result = MessageBox.Show("Would you Like To Approve ?", "System Message", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button3)
        If result = System.Windows.Forms.DialogResult.Cancel Then blnCancel = True
        If result <> System.Windows.Forms.DialogResult.Yes Then Exit Sub

        If Not CheckData() Then Exit Sub

        Call ApproveData()

    End Sub

    Private Function CancelData() As Boolean
        Dim msgerr As String = ""
        Dim pRemCancel As String = ""
        drvJob = CType(bsJob.Current, DataRowView)
        'dtJobDet = bsJobDet.DataSource
        pRemCancel = InputBox("enter remark to cancel", "System Message", "")

        If (New classPurchaseNewEdit).CancelPurchaseOrder(drvJob.Row("jobno"), pRemCancel, msgerr, clsUser.UserID) Then
            txtPurNo.Text = drvJob.Row("jobno")
            MessageBox.Show("Cancel สำเร็จ " & txtPurNo.Text.Trim, "System Message", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)

            CancelData = True
        Else
            MessageBox.Show(msgerr, "System Message", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
            CancelData = False
        End If

    End Function

    Private Function CheckDataCancel() As Boolean
        Dim result As Boolean = True

        drvJob = CType(bsJob.Current, DataRowView)

        If txtPresentStatus.Text = "CANCELLED" Then
            MessageBox.Show("P/O นี้สถานะถูกยกเลิกแล้ว ไม่สามารถยกเลิกอีก" & vbCrLf &
                            "This P/O is already cancelled", "System Meassge", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
            'epPresentStatus.SetError(Me.txtPresentStatus, "P/O ��ʶҹ�¡��ԡ����� �������ö ¡��ԡ���ա" & vbCrLf & "If Currency equals foreigner then exchange rate not equals one")
            result = False
        Else
            'epPresentStatus.Clear()
        End If

        Return result
    End Function
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Validate()

        blnCancel = False
        Dim result As System.Windows.Forms.DialogResult
        result = MessageBox.Show("Would you Like To save ?", "System Message", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button3)
        If result = System.Windows.Forms.DialogResult.Cancel Then blnCancel = True
        If result <> System.Windows.Forms.DialogResult.Yes Then Exit Sub

        If Not CheckDataCancel() Then Exit Sub

        Call CancelData()
    End Sub

    Private Sub cboSupplier_SelectedValueChanged(sender As Object, e As EventArgs) Handles cboSupplier.SelectedValueChanged
        Dim GetdataAddr As New GetDataYarn
        Dim Obj_Supp As New tbl_Suppliers
        Dim msgerr As String = ""
        Dim Address As String
        'If Not Me.CbSupplier.SelectedValue Is Nothing Then
        Obj_Supp = GetdataAddr.GetDataAddress(Me.cboSupplier.SelectedValue, msgerr)
        Address = Obj_Supp.addr1 & " " & Obj_Supp.addr2 & " " & Obj_Supp.addr3 & " " & Obj_Supp.addr1t & " " & Obj_Supp.addr2t & " " & Obj_Supp.addr3t & ", " & Obj_Supp.city & " " & Obj_Supp.ctry & " " & Obj_Supp.tel & " " & Obj_Supp.fax & " " & Obj_Supp.email & " " & Obj_Supp.contact
        Me.txtAddress.Text = Address
        Me.txtCrdays.Text = Obj_Supp.crdays
        m_import = Obj_Supp.import
        'Me.checkImport.CheckState = m_import
        Me.checkImport.Checked = m_import
        Me.txtEmailTo.Text = Obj_Supp.email
        Me.txtEmailCC.Text = Obj_Supp.email_cc
        'drvJob.Row("import") = m_import

    End Sub

    Private Function CloseData() As Boolean
        Dim msgerr As String = ""
        Dim pRemApp As String = ""
        drvJob = CType(bsJob.Current, DataRowView)
        'dtJobDet = bsJobDet.DataSource
        pRemApp = InputBox("enter remark to approve", "System Message", "")

        If (New classPurchaseNewEdit).ClosePurchaseOrder(drvJob.Row("jobno"), pRemApp, msgerr, clsUser.UserID) Then
            txtPurNo.Text = drvJob.Row("jobno")
            MessageBox.Show("Close สำเร็จ " & txtPurNo.Text.Trim, "System Message", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
            CloseData = True
        Else
            MessageBox.Show(msgerr, "System Message", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
            CloseData = False
        End If

    End Function

    Private Sub btnClosed_Click(sender As Object, e As EventArgs) Handles btnClosed.Click
        Me.Validate()

        blnCancel = False
        Dim result As System.Windows.Forms.DialogResult
        result = MessageBox.Show("Would you Like To Approve ?", "System Message", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button3)
        If result = System.Windows.Forms.DialogResult.Cancel Then blnCancel = True
        If result <> System.Windows.Forms.DialogResult.Yes Then Exit Sub

        If Not CheckData() Then Exit Sub

        Call CloseData()
    End Sub

    Private Sub ApplyDelidt()
        Dim dt As DataTable = dtJobDet 'DgYarn.DataSource
        For Each dr As DataRow In dt.Rows
            If dr.RowState <> DataRowState.Deleted Then
                dr("delidt") = dtpDelidt.Value.ToString("dd/MM/yyyy") '(New clsConfig).IsNull(dtpDelidt.Value.Date, DBNull.Value)
            End If
        Next
        dgvJobDet.Refresh()

    End Sub

    Private Sub btnApplyDelidt_Click(sender As Object, e As EventArgs) Handles btnApplyDelidt.Click
        Call ApplyDelidt()
    End Sub

    Private Sub getCreditTremAutocomplete()
        Dim dtcrtermAutocomplete As New DataTable
        dtcrtermAutocomplete = (New classPurchaseNewEdit).GetCrTermAutocomplete()
        crTermAutoComplete.Clear()
        'For Each dr As DataRow In dtItcdAutocomplete.Rows
        ' ItcdAutoComplete.Add(dr("itcd"))
        ' Next
        For i = 0 To dtcrtermAutocomplete.Rows.Count - 1
            crTermAutoComplete.Add(dtcrtermAutocomplete.Rows(i)("crterm"))
        Next

        With txtCrterm
            .AutoCompleteCustomSource = crTermAutoComplete
            .AutoCompleteMode = AutoCompleteMode.SuggestAppend
            .AutoCompleteSource = AutoCompleteSource.CustomSource
        End With


    End Sub

    Private Sub getItcdAutocomplete()
        Dim dtItcdAutocomplete As New DataTable
        dtItcdAutocomplete = (New classPurchaseNewEdit).GetItcdAutocomplete()
        ItcdAutoComplete.Clear()
        'For Each dr As DataRow In dtItcdAutocomplete.Rows
        ' ItcdAutoComplete.Add(dr("itcd"))
        ' Next
        For i = 0 To dtItcdAutocomplete.Rows.Count - 1
            ItcdAutoComplete.Add(dtItcdAutocomplete.Rows(i)("itcd"))
        Next


    End Sub


    Private Sub CalculateLineTotalAmount()

        txtGrossLineamount.Text = Format((New clsConfig).IsNull(dtJobDet.Compute("SUM(gross_lineamt)", ""), 0), "N2").ToString
        txtGrossLineDiscount.Text = Format((New clsConfig).IsNull(dtJobDet.Compute("SUM(discamt)", ""), 0), "N2").ToString
        txtNetLineAmount.Text = Format(Convert.ToDecimal(txtGrossLineamount.Text) - Convert.ToDecimal(txtGrossLineDiscount.Text), "N2").ToString
        'txtDiscountamount.Text = Format((New clsConfig).IsNull(Convert.ToDecimal(txtDiscountamount.Text), "N2").ToString

        txtNetOrderAmount.Text = Format(Convert.ToDecimal(txtNetLineAmount.Text) - Convert.ToDecimal(txtDiscountamount.Text), "N2").ToString
        txtTotalAmount.Text = Format(Convert.ToDecimal(txtNetOrderAmount.Text) + Convert.ToDecimal(txtVatAmount.Text), "N2").ToString

    End Sub

    Private Sub dgvJobDet_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles dgvJobDet.CellEndEdit
        'If Not dgvJobDet.Rows.Count > 0 Or dgvJobDet.DataSource Is Nothing Then Exit Sub
        'Dim currentColIndex As Integer = dgvJobDet.CurrentCell.ColumnIndex
        'Dim currentColName As String = dgvJobDet.Columns(currentColIndex).Name
        'Dim dgr As DataGridViewRow = dgvJobDet.CurrentRow
        'Dim clsconfig As New clsConfig
        'If e.RowIndex >= 0 And currentColName = "colItcd" Then
        '    Dim dtGetDatavItem As New DataTable
        '    dtGetDatavItem = (New classPurchaseNewEdit).GetDataVItem(dgr.Cells("colItcd").Value)
        '    Dim expression As String = "[itcd] = '" + dgvJobDet.Rows(e.RowIndex).Cells("colItcd").Value() + "'"
        '    Dim foundRows() As DataRow = dtGetDatavItem.Select(expression)
        '    If foundRows.Length > 0 Then
        '        dgr.Cells("colItemId").Value = foundRows(0)("item_id")
        '        dgr.Cells("colItdesc").Value = foundRows(0)("itdesc")
        '        dgr.Cells("colUom").Value = foundRows(0)("uom")
        '        bsJobDet.EndEdit()
        '        dgvJobDet.Refresh()
        '    End If
        'ElseIf e.RowIndex >= 0 And currentColName = "colQty" Then '(dgvArBwBillLine.Columns(e.ColumnIndex).GetType() Is GetType(DataGridViewCheckBoxColumn)) Then
        '    dgr.Cells("colGrossLineamt").Value = clsconfig.IsNull(dgr.Cells("colPrice").Value, 0) * clsconfig.IsNull(dgr.Cells("colQty").Value, 0)
        '    dgr.Cells("colLineamt").Value = (clsconfig.IsNull(dgr.Cells("colQty").Value, 0) * clsconfig.IsNull(dgr.Cells("colPrice").Value, 0)) - clsconfig.IsNull(dgr.Cells("colDiscamt").Value, 0)
        '    bsJobDet.EndEdit()
        '    dgvJobDet.Refresh()
        '    Call CalculateLineTotal()
        'ElseIf e.RowIndex >= 0 And currentColName = "colItemUnitPrice" Then
        '    dgr.Cells("colPrice").Value = clsconfig.IsNull(dgr.Cells("colItemUnitPrice").Value, 0) + clsconfig.IsNull(dgr.Cells("colFreightPerUnit").Value, 0)
        '    dgr.Cells("colGrossLineamt").Value = clsconfig.IsNull(dgr.Cells("colPrice").Value, 0) * clsconfig.IsNull(dgr.Cells("colQty").Value, 0)
        '    dgr.Cells("colLineamt").Value = (clsconfig.IsNull(dgr.Cells("colQty").Value, 0) * clsconfig.IsNull(dgr.Cells("colPrice").Value, 0)) - clsconfig.IsNull(dgr.Cells("colDiscamt").Value, 0)
        '    bsJobDet.EndEdit()
        '    dgvJobDet.Refresh()
        '    Call CalculateLineTotal()
        'ElseIf e.RowIndex >= 0 And currentColName = "colFreightPerUnit" Then
        '    dgr.Cells("colPrice").Value = clsconfig.IsNull(dgr.Cells("colItemUnitPrice").Value, 0) + clsconfig.IsNull(dgr.Cells("colFreightPerUnit").Value, 0)
        '    dgr.Cells("colGrossLineamt").Value = clsconfig.IsNull(dgr.Cells("colPrice").Value, 0) * clsconfig.IsNull(dgr.Cells("colQty").Value, 0)
        '    dgr.Cells("colLineamt").Value = (clsconfig.IsNull(dgr.Cells("colQty").Value, 0) * clsconfig.IsNull(dgr.Cells("colPrice").Value, 0)) - clsconfig.IsNull(dgr.Cells("colDiscamt").Value, 0)
        '    bsJobDet.EndEdit()
        '    dgvJobDet.Refresh()
        '    Call CalculateLineTotal()
        'ElseIf e.RowIndex >= 0 And currentColName = "colDiscper" Then
        '    dgr.Cells("colDiscamt").Value = ((clsconfig.IsNull(dgr.Cells("colQty").Value, 0) * clsconfig.IsNull(dgr.Cells("colPrice").Value, 0)) * clsconfig.IsNull(dgr.Cells("colDiscper").Value, 0)) / 100
        '    dgr.Cells("colGrossLineamt").Value = clsconfig.IsNull(dgr.Cells("colPrice").Value, 0) * clsconfig.IsNull(dgr.Cells("colQty").Value, 0)
        '    dgr.Cells("colLineamt").Value = ((clsconfig.IsNull(dgr.Cells("colQty").Value, 0) * clsconfig.IsNull(dgr.Cells("colPrice").Value, 0)) - ((clsconfig.IsNull(dgr.Cells("colQty").Value, 0) * clsconfig.IsNull(dgr.Cells("colPrice").Value, 0)) * clsconfig.IsNull(dgr.Cells("colDiscper").Value, 0)) / 100) ' (Qty * UnitPrice) - ((Qty * UnitPrice) * Disc) / 100
        '    bsJobDet.EndEdit()
        '    dgvJobDet.Refresh()
        '    Call CalculateLineTotal()
        'ElseIf e.RowIndex >= 0 And currentColName = "colDiscamt" Then
        '    dgr.Cells("colDiscper").Value = 0
        '    dgr.Cells("colGrossLineamt").Value = clsconfig.IsNull(dgr.Cells("colPrice").Value, 0) * clsconfig.IsNull(dgr.Cells("colQty").Value, 0)
        '    dgr.Cells("colLineamt").Value = (clsconfig.IsNull(dgr.Cells("colQty").Value, 0) * clsconfig.IsNull(dgr.Cells("colPrice").Value, 0)) - clsconfig.IsNull(dgr.Cells("colDiscamt").Value, 0)
        '    bsJobDet.EndEdit()
        '    dgvJobDet.Refresh()
        '    Call CalculateLineTotal()
        'End If
    End Sub

    Private Sub txtVat_KeyDown(sender As Object, e As KeyEventArgs) Handles txtVat.KeyDown
        If e.KeyCode = Keys.Enter Then
            ValidateVatPerc()
        End If
    End Sub

    Private Sub txtDisper_KeyDown(sender As Object, e As KeyEventArgs) Handles txtDisper.KeyDown
        If e.KeyCode = Keys.Enter Then
            ValidateDisPer()
            ValidateVatPerc() 'Sitthana 20240618
        End If
    End Sub

    'Private Sub dgvJobDet_DefaultValuesNeeded(sender As Object, e As DataGridViewRowEventArgs) Handles dgvJobDet.DefaultValuesNeeded
    '    e.Row.Cells("rcv_warehouse_id").Value = clsUser.MtlWareHouseID
    '    e.Row.Cells("colWareHouseCode").Value = (New classPurchaseNewEdit).GetMtlWareHouseCode(clsUser.MtlWareHouseID)
    '    e.Row.Cells("colQty").Value = 0.00
    '    e.Row.Cells("colItemUnitPrice").Value = 0.00
    '    e.Row.Cells("colFreightPerUnit").Value = 0.00
    '    e.Row.Cells("colPrice").Value = 0.00
    '    e.Row.Cells("colDiscper").Value = 0.00
    '    e.Row.Cells("colDiscamt").Value = 0.00
    '    e.Row.Cells("colLineamt").Value = 0.00
    'End Sub

    Private Sub dgvJobDet_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs) Handles dgvJobDet.CellValueChanged
        'Dim currentColIndex As Integer = dgvJobDet.CurrentCell.ColumnIndex
        Dim currentColName As String = dgvJobDet.Columns(e.ColumnIndex).Name
        Dim dgr As DataGridViewRow = dgvJobDet.CurrentRow
        If currentColName = "colItcd" Then
            Dim dtGetDatavItem As New DataTable
            dtGetDatavItem = (New classPurchaseNewEdit).GetDataVItem((New clsConfig).IsNull(dgr.Cells("colItcd").Value, ""))
            Dim expression As String = "[itcd] = '" + dgvJobDet.Rows(e.RowIndex).Cells("colItcd").Value() + "'"
            Dim foundRows() As DataRow = dtGetDatavItem.Select(expression)
            If foundRows.Length > 0 Then
                dgr.Cells("colItemId").Value = foundRows(0)("item_id")
                dgr.Cells("colItdesc").Value = foundRows(0)("itdesc")
                dgr.Cells("colUom").Value = foundRows(0)("uom_id")
            End If
        ElseIf currentColName = "colQty" Then
            'Dim dgr As DataGridViewRow = dgvJobDet.CurrentRow
            dgr.Cells("colGrossLineamt").Value = oConfig.IsNull(dgr.Cells("colPrice").Value, 0) * oConfig.IsNull(dgr.Cells("colQty").Value, 0)
            dgr.Cells("colLineamt").Value = (oConfig.IsNull(dgr.Cells("colQty").Value, 0) * oConfig.IsNull(dgr.Cells("colPrice").Value, 0)) - oConfig.IsNull(dgr.Cells("colDiscamt").Value, 0)
            Call CalculateLineTotalAmount()
        ElseIf currentColName = "colItemUnitPrice" Or currentColName = "colFreightPerUnit" Then
            ' Dim dgr As DataGridViewRow = dgvJobDet.CurrentRow
            dgr.Cells("colPrice").Value = oConfig.IsNull(dgr.Cells("colItemUnitPrice").Value, 0) + oConfig.IsNull(dgr.Cells("colFreightPerUnit").Value, 0)
            dgr.Cells("colGrossLineamt").Value = oConfig.IsNull(dgr.Cells("colPrice").Value, 0) * oConfig.IsNull(dgr.Cells("colQty").Value, 0)
            dgr.Cells("colLineamt").Value = (oConfig.IsNull(dgr.Cells("colQty").Value, 0) * oConfig.IsNull(dgr.Cells("colPrice").Value, 0)) - oConfig.IsNull(dgr.Cells("colDiscamt").Value, 0)
            Call CalculateLineTotalAmount()
        ElseIf currentColName = "colDiscper" Then
            'Dim dgr As DataGridViewRow = dgvJobDet.CurrentRow
            dgr.Cells("colDiscamt").Value = ((oConfig.IsNull(dgr.Cells("colQty").Value, 0) * oConfig.IsNull(dgr.Cells("colPrice").Value, 0)) * oConfig.IsNull(dgr.Cells("colDiscper").Value, 0)) / 100
            dgr.Cells("colGrossLineamt").Value = oConfig.IsNull(dgr.Cells("colPrice").Value, 0) * oConfig.IsNull(dgr.Cells("colQty").Value, 0)
            dgr.Cells("colLineamt").Value = ((oConfig.IsNull(dgr.Cells("colQty").Value, 0) * oConfig.IsNull(dgr.Cells("colPrice").Value, 0)) - ((oConfig.IsNull(dgr.Cells("colQty").Value, 0) * oConfig.IsNull(dgr.Cells("colPrice").Value, 0)) * oConfig.IsNull(dgr.Cells("colDiscper").Value, 0)) / 100) ' (Qty * UnitPrice) - ((Qty * UnitPrice) * Disc) / 100
            Call CalculateLineTotalAmount()
        ElseIf currentColName = "colDiscamt" Then
            ' Dim dgr As DataGridViewRow = dgvJobDet.CurrentRow
            'dgr.Cells("colDiscper").Value = 0
            dgr.Cells("colGrossLineamt").Value = oConfig.IsNull(dgr.Cells("colPrice").Value, 0) * oConfig.IsNull(dgr.Cells("colQty").Value, 0)
            dgr.Cells("colLineamt").Value = (oConfig.IsNull(dgr.Cells("colQty").Value, 0) * oConfig.IsNull(dgr.Cells("colPrice").Value, 0)) - oConfig.IsNull(dgr.Cells("colDiscamt").Value, 0)
            Call CalculateLineTotalAmount()
        End If
    End Sub

    Private Sub ENToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ENToolStripMenuItem.Click
        Dim frm As New frmReport
        Dim rpt As New CrystalDecisions.CrystalReports.Engine.ReportDocument
        Dim rptFileName As String
        Dim jobno As String = ""
        Dim docno As String = txtPurNo.Text.Trim

        If docno = "" Then

            rptFileName = "RptPurchaseOrderCreate.rpt"
            If Not oConfig.CheckReport(clsUser.ReportPath, rptFileName) Then Exit Sub
            rpt.Load(clsUser.ReportPath & rptFileName)
            rpt.DataSourceConnections.Item(0).SetConnection(clsConnection.servername, clsConnection.database, False)
            rpt.DataSourceConnections.Item(0).SetLogon(clsConnection.Userid, clsConnection.Password)
            rpt.VerifyDatabase()
            rpt.SetParameterValue("@jobno", docno)

        Else
            rptFileName = "RptPurchaseOrderCreate.rpt"
            If Not oConfig.CheckReport(clsUser.ReportPath, rptFileName) Then Exit Sub
            rpt.Load(clsUser.ReportPath & rptFileName)
            rpt.DataSourceConnections.Item(0).SetConnection(clsConnection.servername, clsConnection.database, False)
            rpt.DataSourceConnections.Item(0).SetLogon(clsConnection.Userid, clsConnection.Password)
            rpt.VerifyDatabase()
            rpt.SetParameterValue("@jobno", docno)

        End If

        frm.Title = "PurchaseOrder"
        frm.CRViewer.ReportSource = rpt
        frm.MdiParent = Me.ParentForm
        frm.Show()
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub A4ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles A4ToolStripMenuItem.Click
        Dim frm As New frmReport
        Dim rpt As New CrystalDecisions.CrystalReports.Engine.ReportDocument
        Dim rptFileName As String
        Dim jobno As String = ""
        Dim docno As String = txtPurNo.Text.Trim

        If docno = "" Then

            rptFileName = "RptPurchaseOrderCreateTH.rpt"
            ' If clsUser.ReportPath = "" Then clsUser.ReportPath = clsConfig.ReportPath
            If Not oConfig.CheckReport(clsUser.ReportPath, rptFileName) Then Exit Sub
            rpt.Load(clsUser.ReportPath & rptFileName)
            rpt.DataSourceConnections.Item(0).SetConnection(clsConnection.servername, clsConnection.database, False)
            rpt.DataSourceConnections.Item(0).SetLogon(clsConnection.Userid, clsConnection.Password)
            rpt.VerifyDatabase()
            rpt.SetParameterValue("@jobno", docno)

        Else
            rptFileName = "RptPurchaseOrderCreateTH.rpt"
            ' If clsUser.ReportPath = "" Then clsUser.ReportPath = clsConfig.ReportPath
            If Not oConfig.CheckReport(clsUser.ReportPath, rptFileName) Then Exit Sub
            rpt.Load(clsUser.ReportPath & rptFileName)
            rpt.DataSourceConnections.Item(0).SetConnection(clsConnection.servername, clsConnection.database, False)
            rpt.DataSourceConnections.Item(0).SetLogon(clsConnection.Userid, clsConnection.Password)
            rpt.VerifyDatabase()
            rpt.SetParameterValue("@jobno", docno)

        End If

        frm.Title = "PurchaseOrder"
        frm.CRViewer.ReportSource = rpt
        frm.MdiParent = Me.ParentForm
        frm.Show()
        Me.Cursor = Cursors.Default
    End Sub
    Private Sub ValidateDisPer()
        Dim clsconfig As New clsConfig
        Dim m_NetLineAmt As Decimal = txtNetLineAmount.Text
        Dim m_OrderDiscPer As Decimal = txtDisper.Text
        Dim m_OrderDiscAmt As Decimal = txtDiscountamount.Text
        Dim m_VATAmt As Decimal = txtVatAmount.Text
        Dim m_NetOrderAmt As Decimal = txtNetOrderAmount.Text
        Dim m_NetOrderAmtAfterVAT As Decimal = txtTotalAmount.Text

        m_OrderDiscAmt = m_NetLineAmt * m_OrderDiscPer * 0.01
        m_NetOrderAmt = m_NetLineAmt - m_OrderDiscAmt 'txtNetLineAmount + txtDiscountamount
        m_NetOrderAmtAfterVAT = m_NetOrderAmt + m_VATAmt

        txtDiscountamount.Text = Format(m_OrderDiscAmt, "N2").ToString
        txtNetOrderAmount.Text = Format(m_NetOrderAmt, "N2").ToString
        txtVatAmount.Text = Format(m_VATAmt, "N2").ToString
        txtTotalAmount.Text = Format(m_NetOrderAmtAfterVAT, "N2").ToString
    End Sub

    Private Sub txtDisper_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtDisper.Validating
        ValidateDisPer()
        ValidateVatPerc() 'Sitthana 20240618
    End Sub
    Private Sub ValidateVatPerc()
        Dim clsconfig As New clsConfig
        Dim m_VATPer As Decimal = txtVat.Text
        Dim m_VATAmt As Decimal = txtVatAmount.Text
        Dim m_NetOrderAmt As Decimal = txtNetOrderAmount.Text
        Dim m_NetOrderAmtAfterVAT As Decimal = txtTotalAmount.Text

        m_VATAmt = m_NetOrderAmt * m_VATPer * 0.01
        m_NetOrderAmtAfterVAT = m_NetOrderAmt + m_VATAmt

        txtVatAmount.Text = Format(m_VATAmt, "N2").ToString
        txtTotalAmount.Text = Format(m_NetOrderAmtAfterVAT, "N2").ToString
    End Sub
    Private Sub txtVat_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtVat.Validating
        ValidateVatPerc()
    End Sub

    Private Sub cboCurrency_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cboCurrency.SelectionChangeCommitted
        If Not IsDBNull(cboCurrency.DataSource) And cboCurrency.ValueMember = "curr" Then
            If Not (New clsConfig).IsNull(cboCurrency.SelectedValue, "") = "" And Not (New clsConfig).IsNull(cboCurrency.SelectedValue, "") = "THB" Then
                txtrate.Text = (New classPurchaseNewEdit).GetExchageRate(cboCurrency.SelectedValue())
            ElseIf (New clsConfig).IsNull(cboCurrency.SelectedValue, "") = "THB" Then
                txtrate.Text = "1"
            End If
        End If
    End Sub

    Private Function ValidateSO(dgvc As DataGridViewCell, errorMessage As String) As Boolean
        'Dim result As Boolean '= (textBox.Text = text)
        Dim frmLov As New frmListOfValues("SO")
        frmLov.AppConnection = _AppConn
        frmLov.AppUserId = UserInfo.UserID
        frmLov.AppSessionID = 0 'UserInfo.UserSessionID
        ' frmLov.pAppUserWarehouse = UserInfo.WarehouseCode
        frmLov.pFilterText = oConfig.IsNull(dgvc.EditedFormattedValue, "")
        Me.Cursor = Cursors.WaitCursor
        frmLov.ShowFrm()
        Me.Cursor = Cursors.Default
        Select Case frmLov.pUserAction
            Case "OK", "NONE"
                drvJobDet = CType(bsJobDet.Current, DataRowView)
                drvJobDet.Row.BeginEdit()
                drvJobDet.Row("sono") = oConfig.IsNull(frmLov.pdrvSearchTable.Row("sono"), DBNull.Value)
                drvJobDet.Row.EndEdit()
                bsJobDet.EndEdit()
                dgvJobDet.RefreshEdit()
                Return True
            Case Else
                errorMessage = "S/O No. is missing"
                Return False
        End Select

        '  errorMessage = "Items No. is missing"
        '   Return False
    End Function

    Private Function ValidateSOITM(ByVal pFilterText As String, ByRef errorMessage As String) As Boolean
        'Dim result As Boolean '= (textBox.Text = text)
        Dim frmLov As New frmListOfValues("SOITM")
        frmLov.AppConnection = _AppConn
        frmLov.AppUserId = UserInfo.UserID
        frmLov.AppSessionID = 0 'UserInfo.UserSessionID
        ' frmLov.pAppUserWarehouse = UserInfo.WarehouseCode
        frmLov.pFilterText = oConfig.IsNull(pFilterText, "")
        Me.Cursor = Cursors.WaitCursor
        frmLov.ShowFrm()
        Me.Cursor = Cursors.Default
        Select Case frmLov.pUserAction
            Case "OK", "NONE"
                drvJobDet = CType(bsJobDet.Current, DataRowView)
                drvJobDet.Row.BeginEdit()
                drvJobDet.Row("sono") = oConfig.IsNull(frmLov.pdrvSearchTable.Row("sono"), DBNull.Value)
                drvJobDet.Row("sonoid") = oConfig.IsNull(frmLov.pdrvSearchTable.Row("sonoid"), DBNull.Value)
                ' 'drvJobDet.Row("itcd") = oConfig.IsNull(frmLov.pdrvSearchTable.Row("itcd"), DBNull.Value)
                ' drvJobDet.Row("itdesc") = oConfig.IsNull(frmLov.pdrvSearchTable.Row("itdesc"), DBNull.Value)
                ' drvJobDet.Row("qty") = oConfig.IsNull(frmLov.pdrvSearchTable.Row("qty"), DBNull.Value)
                ' drvJobDet.Row("uom") = oConfig.IsNull(frmLov.pdrvSearchTable.Row("uom"), DBNull.Value)
                drvJobDet.Row.EndEdit()
                bsJobDet.EndEdit()
                dgvJobDet.RefreshEdit()
                Return True
            Case Else
                errorMessage = "S/O Line No. is missing"
                Return False
        End Select

        '  errorMessage = "Items No. is missing"
        '   Return False
    End Function

    Private Sub dgvJobDet_CellValidating(sender As Object, e As DataGridViewCellValidatingEventArgs) Handles dgvJobDet.CellValidating
        Me.dgvJobDet.Rows(e.RowIndex).ErrorText = ""
        If dgvJobDet.Rows(e.RowIndex).IsNewRow Then Return
        drvJob = CType(bsJob.Current, DataRowView)
        drvJobDet = CType(bsJobDet.Current, DataRowView)
        Dim errorMsg As String = ""
        Dim ColumnName = dgvJobDet.Columns(e.ColumnIndex).Name
        Select Case ColumnName
            Case "colSoNo", "colSoNoId"
                If dgvJobDet.Rows(e.RowIndex).Cells(e.ColumnIndex).IsInEditMode Then
                    If dgvJobDet.Rows(e.RowIndex).Cells(e.ColumnIndex).EditedFormattedValue.ToString.Trim.Length > 0 Then
                        If Not ValidateSOITM(dgvJobDet.Rows(e.RowIndex).Cells(e.ColumnIndex).EditedFormattedValue, errorMsg) Then
                            ' Cancel the event and select the text to be corrected by the user.
                            e.Cancel = True
                            ' Set the ErrorProvider error with the text to display. 
                            dgvJobDet.Rows(e.RowIndex).ErrorText = errorMsg
                        Else

                        End If
                    ElseIf dgvJobDet.Rows(e.RowIndex).Cells(e.ColumnIndex).EditedFormattedValue.ToString.Trim.Length = 0 AndAlso dgvJobDet.Rows(e.RowIndex).Cells(e.ColumnIndex).Value.ToString <> dgvJobDet.Rows(e.RowIndex).Cells(e.ColumnIndex).EditedFormattedValue.ToString Then
                        If dgvJobDet.Rows(e.RowIndex).Cells(e.ColumnIndex).Value.ToString <> dgvJobDet.Rows(e.RowIndex).Cells(e.ColumnIndex).EditedFormattedValue.ToString Then
                            drvJobDet.Row.BeginEdit()
                            drvJobDet.Row("sono") = DBNull.Value
                            drvJobDet.Row("sonoid") = DBNull.Value
                            '  drvJobDet.Row("itcd") = DBNull.Value
                            '  drvJobDet.Row("itdesc") = DBNull.Value
                            '  drvJobDet.Row("qty") = DBNull.Value
                            '  drvJobDet.Row("uom") = DBNull.Value
                            drvJobDet.Row.EndEdit()
                            bsJobDet.EndEdit()
                            dgvJobDet.RefreshEdit()
                        End If
                    End If
                End If
                'Case "colSoNoId"
                '    If dgvJobDet.Rows(e.RowIndex).Cells(e.ColumnIndex).IsInEditMode Then
                '        If dgvJobDet.Rows(e.RowIndex).Cells(e.ColumnIndex).EditedFormattedValue.ToString.Trim.Length > 0 Then
                '            If Not ValidateSOITM(dgvJobDet.Rows(e.RowIndex).Cells(e.ColumnIndex).EditedFormattedValue, errorMsg) Then
                '                ' Cancel the event and select the text to be corrected by the user.
                '                e.Cancel = True
                '                ' Set the ErrorProvider error with the text to display. 
                '                dgvJobDet.Rows(e.RowIndex).ErrorText = errorMsg
                '            Else

                '            End If
                '        ElseIf dgvJobDet.Rows(e.RowIndex).Cells(e.ColumnIndex).EditedFormattedValue.ToString.Trim.Length = 0 AndAlso dgvJobDet.Rows(e.RowIndex).Cells(e.ColumnIndex).Value.ToString <> dgvJobDet.Rows(e.RowIndex).Cells(e.ColumnIndex).EditedFormattedValue.ToString Then
                '            If dgvJobDet.Rows(e.RowIndex).Cells(e.ColumnIndex).Value.ToString <> dgvJobDet.Rows(e.RowIndex).Cells(e.ColumnIndex).EditedFormattedValue.ToString Then
                '                drvJobDet.Row.BeginEdit()
                '                drvJobDet.Row("sono") = DBNull.Value
                '                drvJobDet.Row("sonoid") = DBNull.Value
                '                drvJobDet.Row("itcd") = DBNull.Value
                '                drvJobDet.Row("itdesc") = DBNull.Value
                '                drvJobDet.Row("qty") = DBNull.Value
                '                drvJobDet.Row("uom") = DBNull.Value
                '                drvJobDet.Row.EndEdit()
                '                bsJobDet.EndEdit()
                '                dgvJobDet.RefreshEdit()
                '            End If
                '        End If
                '    End If
        End Select
    End Sub
End Class