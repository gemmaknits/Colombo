Imports System.Data
Imports System.Data.SqlClient
Imports System.Text
Imports PurchaseOrderSystem.Controls
Public Class formPurchaseOrderEdit3
    Dim _AppConn As SqlConnection = (New classConnection).getSQLConnection

    Dim oConfig As New clsConfig
    Dim clsConn As New classConnection
    Dim clsMaster As New classMaster

    Public loginEmpcd As String = ""
    Private Clsconfig As New clsConfig
    Public selectitdesc As String
    Public selectitcd As String

    Private connStr As New classConnection
    Private m_import As Integer
    Dim ds As New DataSet
    Private dts As New DataTable
    Private dt As New DataTable

    Dim Qty As Double
    Dim UnitPrice As Double
    Dim DiscPerc As Double
    Dim Discamt As Double
    Dim Lineamt As Double
    Dim VatAmt As Double
    Dim sumDiscAmt As Double
    Dim sumGrossAmt As Double
    Dim dsTable1 As DataTable
    Dim dst2 As DataTable
    Dim clsUser As New classUserInfo

    Dim blnCancel As Boolean = False

    Dim dtJob As New DataTable
    Dim bsJob As New BindingSource
    Dim drvJob As DataRowView

    Dim dtJobDet As New DataTable
    Dim bsJobDet As New BindingSource
    Dim drvJobDet As DataRowView

    Dim ItcdAutoComplete As New AutoCompleteStringCollection
    Dim soAutoComplete As New AutoCompleteStringCollection
    Dim soLineIdAutoComplete As New AutoCompleteStringCollection

    Public Property UserInfo() As classUserInfo
        Get
            UserInfo = clsUser
        End Get
        Set(ByVal NewValue As classUserInfo)
            clsUser = NewValue
        End Set
    End Property

    Dim enableEdit As Boolean = True

    Private Sub formPurchaseOrderEdit_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.F4 Then
            loadSearchPO()
        End If
    End Sub

    Private Sub formPurchaseOrderEdit_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Me.KeyPress
        If e.KeyChar = (System.Windows.Forms.Keys.F4.ToString) Then
            loadSearchPO()
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

    Private Sub InitDataBindingJobDet(ByVal _Jobno As String)
        dtJobDet = (New classPurchaseNewEdit).GetJobDet(_jobno:=_Jobno)
        Call dtJobDet_SetDefaultValuesNeeded()
        bsJobDet.DataSource = dtJobDet
        bsJobDet.MoveFirst()
        dgvJobDet.AutoGenerateColumns = False
        dgvJobDet.DataSource = bsJobDet

    End Sub
    Private Sub GetItcd()

        Dim conn As New SqlConnection(connStr.connection())
        Dim comm As New SqlCommand("", conn)
        Dim da As New SqlDataAdapter(comm)
        'Dim ds As New DataSet

        Dim cmd As New SqlCommand("select distinct itcd,itdesc,itdesc2,itdesc3,itdesc_spec from v_items_des_mc", conn)
        Dim dr As SqlDataReader

        conn.Open()
        dr = cmd.ExecuteReader
        Do While dr.Read
            ItcdAutoComplete.Add(dr.GetString(0))
        Loop
        conn.Close()
    End Sub
    Private Sub GetSoNo()

        Dim conn As New SqlConnection(connStr.connection())
        Dim comm As New SqlCommand("", conn)
        Dim da As New SqlDataAdapter(comm)
        'Dim ds As New DataSet

        Dim cmd As New SqlCommand("select distinct rtrim(sono) from so", conn)
        Dim dr As SqlDataReader

        conn.Open()
        dr = cmd.ExecuteReader
        Do While dr.Read
            soAutoComplete.Add(dr.GetString(0))
        Loop
        conn.Close()
    End Sub
    Private Sub GetSoNoId()

        Dim conn As New SqlConnection(connStr.connection())
        Dim comm As New SqlCommand("", conn)
        Dim da As New SqlDataAdapter(comm)
        'Dim ds As New DataSet

        Dim cmd As New SqlCommand("select distinct rtrim(sonoid) from soitm", conn)
        Dim dr As SqlDataReader

        conn.Open()
        dr = cmd.ExecuteReader
        Do While dr.Read
            soLineIdAutoComplete.Add(dr.GetString(0))
        Loop
        conn.Close()
    End Sub
    Private Sub formPurchaseOrderCreate_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call InitControl()

        InitDataBindingJobDet("")
    End Sub


    Private Sub InitControl()

        ' ----------------------   Supplier --------------------
        GetDataComboSupplier()
        GetDataComboDept()
        GetDataComboEmp()
        GetDataComboItemNature()
        ' ----------------------   Items    --------------------
        GetDataComcoInDgridItems()
        GetDataComboInDgridUnit()
        GetDataComboCurrency()
        ' ----------------------   WareHouse & SubInventory ----
        GetComboWarehouseinGrid()
        GetcomboSubInventoryinGrid(4)

        GetDataMultiComboPOLineType()
        'Fix Error 
        TabControl1.SelectedTab = TabPage2
        'ds.Clear()


        'ds.Clear()

        Me.comboEmp.SelectedValue = ""
        Me.comboDept.SelectedValue = ""
        Me.cbCredit.SelectedValue = ""
        Me.cboCurrency.SelectedValue = ""
        Me.CbSupplier.SelectedValue = ""

        Call EnabledControl(enableEdit)

        txtPurno.Text = ""

        Call Me.showPOData()

        GetItcd()
        GetSoNo()
        GetSoNoId()

    End Sub
    Private Sub Model_QueryCellInfo(ByVal sender As Object, ByVal e As PurchaseOrderSystem.Controls.GridQueryCellInfoEventArgs)
        'To specify the row and colum index.
        If e.RowIndex = 0 AndAlso e.ColIndex = 1 Then
            'To specify the font
            e.Style.Font = New PurchaseOrderSystem.Controls.GridFontInfo(New Font("Segoe UI", 12, FontStyle.Bold, GraphicsUnit.Pixel))
            'To specify the text
            e.Style.Text = "PO Line Type Description"
            'To specify the text color.

        ElseIf e.RowIndex = 0 AndAlso e.ColIndex = 2 Then
            e.Style.Font = New PurchaseOrderSystem.Controls.GridFontInfo(New Font("Segoe UI", 12, FontStyle.Bold, GraphicsUnit.Pixel))
            e.Style.Text = "Outside Process"
        End If


    End Sub
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

    Private Sub GetComboWarehouseinGrid()
        Dim objdb As New classMaster
        rcv_warehouse_id.DataSource = objdb.Combomtlwarehouse(clsUser.UserID)
        rcv_warehouse_id.DisplayMember = "warehouse_name"
        rcv_warehouse_id.ValueMember = "mtl_warehouse_id"

    End Sub
    Private Sub GetcomboSubInventoryinGrid(ByVal Int64mtl_warehouse_id As Int64)
        Dim objdb As New classMaster
        rcv_subinventory_id.DataSource = objdb.GetCombomtl_subinventory(Int64mtl_warehouse_id)
        rcv_subinventory_id.DisplayMember = "subinventory_name"
        rcv_subinventory_id.ValueMember = "mtl_subinventory_id"

    End Sub

    Private Sub GetDataComboCurrency()
        Dim GetdataItems As New GetDataYarn
        Dim ds As DataSet
        ds = GetdataItems.GetDataCurrency
        Me.cboCurrency.DataSource = ds.Tables(0)
        Me.cboCurrency.DisplayMember = "currname"
        Me.cboCurrency.ValueMember = "curr"
    End Sub

    Private Sub GetDataComboInDgridUnit()
        Dim GetdataItems As New GetDataYarn
        Dim dt As New DataTable
        dt = GetdataItems.GetDataUnit
        Me.coluom.DataSource = dt
        Me.coluom.DisplayMember = "uom_name"
        Me.coluom.ValueMember = "uom"
    End Sub

    Private Sub GetDataComcoInDgridItems()
        Dim GetdataItems As New GetDataYarn
        Dim dt As New DataTable
        dt = GetdataItems.GetDataItemcode("", comboItemNature.SelectedValue.ToString.Trim.ToUpper)
        'dt = GetdataItems.GetDataItem


    End Sub

    ' ----------------------   Supplier --------------------
    Private Sub GetDataComboSupplier()
        Dim GetdataComboSupp As New GetDataYarn
        Dim dt As DataTable
        dt = GetdataComboSupp.GetData_Suppliers
        Me.CbSupplier.DataSource = dt
        Me.CbSupplier.DisplayMember = "name"
        Me.CbSupplier.ValueMember = "suppcd"
    End Sub
    Private Sub GetDataComboEmp()
        Dim getDatayarn As New GetDataYarn
        Dim dt As DataTable
        dt = getDatayarn.GetEmpList()
        Me.comboEmp.DataSource = dt
        Me.comboEmp.DisplayMember = "empname"
        Me.comboEmp.ValueMember = "empcd"
    End Sub

    Private Sub GetDataComboDept()
        Dim getDatayarn As New GetDataYarn
        Dim dt As DataTable
        dt = getDatayarn.GetDeptList()
        Me.comboDept.DataSource = dt
        Me.comboDept.DisplayMember = "deptname"
        Me.comboDept.ValueMember = "deptcd"
    End Sub

    Private Sub GetDataComboItemNature()
        Dim getDatayarn As New GetDataYarn
        Dim dt As DataTable
        dt = getDatayarn.GetDataItemNature()
        Me.comboItemNature.DataSource = dt
        Me.comboItemNature.DisplayMember = "itnaturedesc"
        Me.comboItemNature.ValueMember = "itnaturecd"
        Me.comboItemNature.SelectedIndex = 0
    End Sub

    Private Sub CbSupplier_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CbSupplier.SelectedIndexChanged
        'GetDataComboSupplier()
        Dim GetdataAddr As New GetDataYarn
        Dim Obj_Supp As New tbl_Suppliers
        Dim msgerr As String = ""
        Dim Address As String
        If Not Me.CbSupplier.SelectedValue Is Nothing Then
            Obj_Supp = GetdataAddr.GetDataAddress(Me.CbSupplier.SelectedValue, msgerr)
            Address = Obj_Supp.addr1 & " " & Obj_Supp.addr2 & " " & Obj_Supp.addr3 & " " & Obj_Supp.addr1t & " " & Obj_Supp.addr2t & " " & Obj_Supp.addr3t & ", " & Obj_Supp.city & " " & Obj_Supp.ctry & " " & Obj_Supp.tel & " " & Obj_Supp.fax & " " & Obj_Supp.email & " " & Obj_Supp.contact
            m_import = Obj_Supp.import
            Me.checkImport.CheckState = m_import

            Me.txtAddress.Text = Address
            'Me.txtcredit.Text = Obj_Supp.crdays
        End If
    End Sub


    Private Sub BtnYarnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnYarnSave.Click
        Dim m_Msgerr As String = ""  'Sittana 20190705
        Dim ErrRunno As Integer = 0  'Sittana 20190705

        Call calc_final_totals()

        If Not CheckData() Then Exit Sub 'Add By Neung 20190701
        'If Not Validate_PO() Then Exit Sub

        Dim Obj_tbl_job As New tbl_job
        Dim Isvalid As Boolean
        Dim classPurchase As New classPurchase
        Dim msgerr As String = ""
        Dim purno As String = ""
        Dim m_HeaderHasErrors As Boolean = False
        Dim m_GridHasErrors As Boolean = False

        Dim m_errmess As New StringBuilder

        errorSupplier.SetError(Me.CbSupplier, "")
        errorEmp.SetError(Me.comboEmp, "")
        errorCurrency.SetError(Me.cboCurrency, "")
        errorItemGrid.SetError(Me.dgvJobDet, "")
        Me.errorSaved.Clear()

        '------------  job ---- -----------------------
        ErrRunno = 0  'Sittana 20190705
        m_Msgerr = ""  'Sittana 20190705

        If cboCurrency.SelectedValue <> "THB" And oConfig.IsValidDouble(Me.txtrate.Text.Trim) = "1" Then
            errorCurrency.SetError(Me.txtrate, "���ʡ���Թ��ʡ���Թ��ҧ����� �÷�Թ��ͧ�������ҡѺ 1..")
            ' MessageBox.Show("���ʡ���Թ��ʡ���Թ��ҧ����� �÷�Թ��ͧ�������ҡѺ 1", "System Meassge", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
            ErrRunno += 1
            m_Msgerr &= vbCr & ErrRunno.ToString & "���ʡ���Թ��ʡ���Թ��ҧ����� �÷�Թ��ͧ�������ҡѺ 1.."
            m_HeaderHasErrors = True
        End If

        If Me.CbSupplier.SelectedValue = "" Then
            Me.errorSupplier.SetError(Me.CbSupplier, "Select a valid supplier")
            ErrRunno += 1
            m_Msgerr &= vbCr & ErrRunno.ToString & ") Select a valid supplier"
            m_HeaderHasErrors = True
        End If

        Obj_tbl_job.suppcd = Me.CbSupplier.SelectedValue
        Obj_tbl_job.jobno = Me.txtPurno.Text
        Obj_tbl_job.jobdt = Me.DateYIN.Value.ToString("yyyy/MM/dd")

        Obj_tbl_job.supquoteno = Me.textSupQuoteno.Text
        Obj_tbl_job.reqno = Me.textReqno.Text

        Dim SDate As Date
        Dim LDate As Date
        SDate = Today.Date
        LDate = Me.DtPayDate.Value
        Obj_tbl_job.delidays = Val(DateDiff(DateInterval.Day, SDate, LDate)) 'Me.DtPayDate.Value
        Obj_tbl_job.delidt = Me.DtDileveryDate.Value.ToString("yyyy/MM/dd") 'As DateTime

        Obj_tbl_job.crterm = Me.cbCredit.Text
        Obj_tbl_job.crdays = Val(Me.txtcredit.Text.Trim)

        If Me.comboEmp.SelectedValue = "" Then
            errorEmp.SetError(Me.comboEmp, "Select person who made the request..")
            'Sittana 20190705
            ErrRunno += 1
            m_Msgerr &= vbCr & ErrRunno.ToString & ") Select person who made the request.."
            m_HeaderHasErrors = True
        End If
        If Me.cboCurrency.SelectedValue = "" Then 'As String
            errorCurrency.SetError(Me.cboCurrency, "Select currency..")
            m_HeaderHasErrors = True
        End If


        If Clsconfig.IsNull(Me.mcboPoLineType.SelectedValue, 0) = 0 Then
            ErrormcboPoLineType.SetError(Me.mcboPoLineType, "Select Line Type")
            'Sittana 20190705
            ErrRunno += 1
            m_Msgerr &= vbCr & ErrRunno.ToString & ") Select Line Type"
            m_HeaderHasErrors = True
        End If

        Obj_tbl_job.Empcd = Me.comboEmp.SelectedValue
        Obj_tbl_job.Deptcd = Me.comboDept.SelectedValue
        Obj_tbl_job.jobtype = "PURCHASE"
        Obj_tbl_job.splins = Me.txtpackcd.Text.Trim 'As String
        Obj_tbl_job.remark = Me.txtremark.Text.Trim 'As String
        Obj_tbl_job.import = m_import 'As Boolean
        Obj_tbl_job.curr = Me.cboCurrency.SelectedValue 'As String
        Obj_tbl_job.exrt = (Me.txtrate.Text) 'As Double

        Obj_tbl_job.gross_amt = Me.txtGrossamount.Text '���������� Line
        Obj_tbl_job.line_discamt = Me.txtGrossLineDiscount.Text '�����ǹŴ� Line
        Obj_tbl_job.net_lineamt = Me.txtNetLineAmount.Text '����ط��� Line

        Obj_tbl_job.discper = (Me.txtDiscper.Text) 'As Double ��������ǹŴ����
        Obj_tbl_job.discamt = (Me.txtDiscountamount.Text) 'As Double ��ǹŴ����
        Obj_tbl_job.vat = Me.txtVatPer.Text 'As Double ����������
        Obj_tbl_job.vatamt = Me.txtVatAmount.Text  'As Double �����ط��
        'Obj_tbl_job.total_discamt = (Me.txtNetOrderAmount.Text) 'total_discamt ?
        Obj_tbl_job.taxamt = 0  'As Double '�������
        Obj_tbl_job.netamt = txtNetOrderAmount.Text '����ط�� 
        Obj_tbl_job.totamt = txtTotalAmount.Text '����ط��

        'Me.txtNetOrderAmount.Text = ds.Tables("v_pur").Rows(0).Item("totamt")
        ' Me.txtVatAmount.Text = ds.Tables("v_pur").Rows(0).Item("vatamt")
        ' Me.txtTotalAmount.Text = ds.Tables("v_pur").Rows(0).Item("net_amt")


        Obj_tbl_job.shipvia = (Me.txtShipvia.Text) 'As Double

        'Obj_tbl_job.net(Me.txtTotalAmount.Text) 'As Double

        Obj_tbl_job.deliaddr = Me.textDeliAddr.Text
        Obj_tbl_job.shipterms = Me.textShipterms.Text
        Obj_tbl_job.remark = Me.txtremark.Text
        Obj_tbl_job.cancel_status = 0 'As Boolean

        Obj_tbl_job.benefit = txtBenefit.Text.Trim
        Obj_tbl_job.approved_period = txtPeriod.Text.Trim
        Obj_tbl_job.vehicle_name = txtVehicleName.Text.Trim
        Obj_tbl_job.port_name = txtPortName.Text.Trim
        Obj_tbl_job.agency_name = txtAgencyName.Text.Trim
        Obj_tbl_job.benefit_amount = CDbl(txtBenefitAmount.Text)

        Obj_tbl_job.payment_term = txtPaymentTerm.Text.Trim
        Obj_tbl_job.lc_no = txtLCNo.Text.Trim
        Obj_tbl_job.lc_date = dtpLCDate.Value.ToString("yyyyMMdd")
        Obj_tbl_job.quotation_no = txtQuotationNo.Text.Trim
        Obj_tbl_job.quotation_date = dtpQuotationDate.Value.ToString("yyyyMMdd")

        Obj_tbl_job.packing_no = txtPackingNo.Text.Trim
        Obj_tbl_job.invoice_no = txtInvoiceNo.Text.Trim
        Obj_tbl_job.bl_no = txtBLNo.Text.Trim
        Obj_tbl_job.packing_remark = txtPackingRemark.Text.Trim
        Obj_tbl_job.estimate_departure = dtpDeparture.Value.ToString("yyyyMMdd")
        Obj_tbl_job.estimate_arrival = dtpArrival.Value.ToString("yyyyMMdd")
        Obj_tbl_job.benefit_kgs = CDbl(txtBenefitKgs.Text)
        Obj_tbl_job.sell_back_to_vendor = chksell_back_to_vendor.Checked

        '-------------- job_det -------------------------------

        Dim i As Integer
        Dim Lineamt As Integer
        For i = 0 To Me.dgvJobDet.Rows.Count - 2
            Qty = Me.dgvJobDet.Rows(i).Cells("colQty").Value
            UnitPrice = Me.dgvJobDet.Rows(i).Cells("colPrice").Value
            DiscPerc = dgvJobDet.Rows(i).Cells("colDiscper").Value
            Lineamt = Me.dgvJobDet.Rows(i).Cells("colLineamt").Value
            m_errmess.Append("Please check ")

            If Me.dgvJobDet.Rows(i).Cells("colItcd").Value.ToString = "" Then
                errorSaved.SetError(Me.dgvJobDet, "Item code")
                m_errmess.Append("Item code")
                'Sittana 20190705
                ErrRunno += 1
                m_Msgerr &= vbCr & ErrRunno.ToString & ") Row " & (i + 1).ToString & " Item code ��ͧ���������ҧ"
                m_GridHasErrors = True
            End If
            If Me.dgvJobDet.Rows(i).Cells("colUom").Value.ToString = "" Then
                errorSaved.SetError(Me.dgvJobDet, "Unit")
                m_errmess.Append(",Unit")
                'Sittana 20190705
                ErrRunno += 1
                m_Msgerr &= vbCr & ErrRunno.ToString & ") Row " & (i + 1).ToString & "Unit ��ͧ���������ҧ"
                m_GridHasErrors = True
            End If
            If Me.dgvJobDet.Rows(i).Cells("colPrice").Value.ToString = "" Then
                errorSaved.SetError(Me.dgvJobDet, "Price")
                m_errmess.Append(",Price")
                ErrRunno += 1
                m_Msgerr &= vbCr & ErrRunno.ToString & ") Row " & (i + 1).ToString & " Price ��ͧ���������ҧ"
                m_GridHasErrors = True
            End If
            If Me.dgvJobDet.Rows(i).Cells("colQty").Value.ToString = "" Then
                errorSaved.SetError(Me.dgvJobDet, "Unit")
                m_errmess.Append(",Qty")
                'Sittana 20190705
                ErrRunno += 1
                m_Msgerr &= vbCr & ErrRunno.ToString & ") Row " & (i + 1).ToString & " Qty ��ͧ���������ҧ"
                m_GridHasErrors = True
            End If

            If Clsconfig.IsNull(Me.dgvJobDet.Rows(i).Cells("rcv_warehouse_id").Value, 0) = 0 Then
                errorSaved.SetError(Me.dgvJobDet, "WareHouse")
                m_errmess.Append("�س���ê������� WareHouse")
                'Begin Sittana 20190705
                ErrRunno += 1
                m_Msgerr &= vbCr & ErrRunno.ToString & ") Row " & (i + 1).ToString & " �س��ͧ���͡ WareHouse � Data Grid ���¤�Ѻ"
                m_GridHasErrors = True
            End If

            If Me.dgvJobDet.Rows(i).Cells("colItcd").Value.ToString.Substring(0, 3) = "YRA" And
                Clsconfig.IsNull(Me.dgvJobDet.Rows(i).Cells("rcv_subinventory_id").Value, 0) = 0 Then
                errorSaved.SetError(Me.dgvJobDet, "SubInventory")
                m_errmess.Append("�س���ê������� SubInventory �ء���駷���ա�ë��� Bobbin YRA")
                'Sittana 20190705
                ErrRunno += 1
                m_Msgerr &= vbCr & ErrRunno.ToString & ") Row " & (i + 1).ToString & " ����� SubInventory �ء���駷���ա�ë��� Bobbin YRA"
                'End Edit
                m_GridHasErrors = True
            End If


            If m_GridHasErrors Then
                errorItemGrid.SetError(Me.dgvJobDet, m_errmess.ToString)
            End If

            ReDim Preserve Obj_tbl_job.tbl_job_det(i)
            Obj_tbl_job.tbl_job_det(i) = New tbl_job_det

            Obj_tbl_job.tbl_job_det(i).supquoteno = Clsconfig.IsNull(Me.dgvJobDet.Rows(i).Cells("supquoteno").Value, "").ToString
            If Not IsDBNull(Me.dgvJobDet.Rows(i).Cells("colIdJobdet").Value) Then  ' New records do not have id
                Obj_tbl_job.tbl_job_det(i).id_jobdet = Me.dgvJobDet.Rows(i).Cells("colIdJobdet").Value
            End If

            Obj_tbl_job.tbl_job_det(i).itcd = Me.dgvJobDet.Rows(i).Cells("colItcd").Value.ToString
            Obj_tbl_job.tbl_job_det(i).itdesc = Me.dgvJobDet.Rows(i).Cells("colMoreDesc").Value.ToString
            Obj_tbl_job.tbl_job_det(i).qty = Me.dgvJobDet.Rows(i).Cells("colQty").Value.ToString
            Obj_tbl_job.tbl_job_det(i).uom = Me.dgvJobDet.Rows(i).Cells("colUom").Value '.ToString
            Obj_tbl_job.tbl_job_det(i).price = Me.dgvJobDet.Rows(i).Cells("colprice").Value.ToString
            Obj_tbl_job.tbl_job_det(i).curr = Obj_tbl_job.curr    'As String
            Obj_tbl_job.tbl_job_det(i).exrt = Obj_tbl_job.exrt  'As Double
            Obj_tbl_job.tbl_job_det(i).discper = (Me.dgvJobDet.Rows(i).Cells("coldiscper").Value.ToString) 'As Double
            Obj_tbl_job.tbl_job_det(i).discamt = (Me.dgvJobDet.Rows(i).Cells("coldiscamt").Value.ToString)   'As Double
            Obj_tbl_job.tbl_job_det(i).lineamt = Lineamt

            Me.DateYIN.Value = ds.Tables("v_pur").Rows(0).Item("jobdt").ToString.Trim

            Obj_tbl_job.tbl_job_det(i).delidt = Clsconfig.IsNull(Me.dgvJobDet.Rows(i).Cells("delidt").Value, "19000101")

            Obj_tbl_job.tbl_job_det(i).closed = 0 ' As bit
            'Obj_tbl_job.tbl_job_det(i).remark = oConfig.IsNull(Me.dgvJobDet.Rows(i).Cells("colRem").ValueType, "").ToString.Trim
            If Not IsDBNull(Me.dgvJobDet.Rows(i).Cells("colSono").Value) Then
                Obj_tbl_job.tbl_job_det(i).sono = Me.dgvJobDet.Rows(i).Cells("colSono").Value
            Else
                Obj_tbl_job.tbl_job_det(i).sono = " "
            End If
            If Not IsDBNull(Me.dgvJobDet.Rows(i).Cells("colSuppitcd").Value) Then
                Obj_tbl_job.tbl_job_det(i).suppitcd = Me.dgvJobDet.Rows(i).Cells("colSuppitcd").Value
            Else
                Obj_tbl_job.tbl_job_det(i).suppitcd = " "
            End If
            Obj_tbl_job.tbl_job_det(i).sonoid = oConfig.IsNull(Me.dgvJobDet.Rows(i).Cells("colSoNoId").Value, Nothing)
            Obj_tbl_job.tbl_job_det(i).rcv_warehouse_id = Clsconfig.IsNull(Me.dgvJobDet.Rows(i).Cells("rcv_warehouse_id").Value, Nothing)
            Obj_tbl_job.tbl_job_det(i).rcv_subinventory_id = Clsconfig.IsNull(Me.dgvJobDet.Rows(i).Cells("rcv_subinventory_id").Value, Nothing)
            Obj_tbl_job.tbl_job_det(i).POLineTypesID = (Clsconfig).IsNull(mcboPoLineType.SelectedValue, Nothing)
            Obj_tbl_job.tbl_job_det(i).remark = oConfig.IsNull(Me.dgvJobDet.Rows(i).Cells("colRem").Value, Nothing)

        Next

        If m_GridHasErrors Or m_HeaderHasErrors Then
            'Sittana 20190705
            If m_Msgerr.Trim <> "" Then
                MessageBox.Show("�ѹ�֡������������ " & vbCr & m_Msgerr, "��ͼԴ��Ҵ", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
            'MsgBox("Some required values are missing, please check..", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Data incomplete") 'Sittana 20190705
            Exit Sub
        End If
        '------------------ Delete records ---------------------
        Dim deletedRecs As New DataView(dtJobDet, "", "", DataViewRowState.Deleted)
        ' Dim deletedRecs As New DataView(dst2, "", "", DataViewRowState.Deleted)
        'Dim deletedRec As DataRowView
        'Dim m_Boxno As String
        'Dim strDelete As String

        'For Each deletedRec In deletedRecs
        '	m_Boxno = deletedRec("Boxno")
        '	strDelete = "Delete Yarn_in_det where boxno = '" & m_Boxno & "'"
        '	comm.CommandText = strDelete.ToString
        '	comm.ExecuteNonQuery()
        'Next
        '----------------

        Isvalid = classPurchase.updatePurchaseOrder(Obj_tbl_job, deletedRecs, msgerr, Me.loginEmpcd)

        If Isvalid = True Then
            '			MsgBox("P/O updated successfully", MsgBoxStyle.Information)
            errorSaved.SetError(Me.txtPurno, "Last update successful")
            '-- refresh the PO data from database
            Me.showPOData()
        Else
            MsgBox(msgerr)
        End If
    End Sub

    Private Function CheckData() As Boolean
        Dim result As Boolean = True
        ' If clsConfig.IsNull(Me.mcboPoLineType.SelectedValue, 0) = 0 Then
        'MessageBox.Show("Select Line Type", "System Meassge", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
        ' Me.errorSupplier.SetError(Me.mcboPoLineType, "Select Line Type")
        'result = False
        ' End If

        If cboCurrency.SelectedValue <> "THB" And Clsconfig.IsValidDouble(Me.txtrate.Text.Trim) = "1" Then
            MessageBox.Show("���ʡ���Թ��ʡ���Թ��ҧ����� �÷�Թ��ͧ�������ҡѺ 1", "System Meassge", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
            errorCurrency.SetError(Me.txtrate, "���ʡ���Թ��ʡ���Թ��ҧ����� �÷�Թ��ͧ�������ҡѺ 1..")
            result = False
        End If


        Return result
    End Function


    Private Sub DgYarn_DefaultValuesNeeded(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewRowEventArgs) Handles dgvJobDet.DefaultValuesNeeded
        If dgvJobDet.Rows.Count - 1 > 0 Then
            e.Row.Cells("colQty").Value = 0
            e.Row.Cells("colPrice").Value = 0
            e.Row.Cells("colDiscper").Value = 0
            e.Row.Cells("colDiscamt").Value = 0
            e.Row.Cells("collineamt").Value = 0
            e.Row.Cells("colMoredesc").Value = " "
            e.Row.Cells("colRem").Value = " "
            e.Row.Cells("colSono").Value = " "
            e.Row.Cells("colSuppitcd").Value = " "

            '----------------- Inculde Default Warehouse And Inculde Subinventory 
            Dim objdb As New classMaster
            Dim dgvccrcv_warehouse_id As New DataGridViewComboBoxCell
            Dim dtrcv_warehouse_id As New DataTable
            Dim dgvccSubInven As New DataGridViewComboBoxCell

            dgvccrcv_warehouse_id = e.Row.Cells("rcv_warehouse_id")
            dgvccrcv_warehouse_id.DataSource = objdb.Combomtlwarehouse(strUSerID:=clsUser.UserID)
            dgvccrcv_warehouse_id.Value = objdb.GetdefaultWarehouse(strUSerID:=clsUser.UserID)

            dgvccSubInven = e.Row.Cells("rcv_subinventory_id")
            dgvccSubInven.DataSource = objdb.GetCombomtl_subinventory(dgvccrcv_warehouse_id.Value)
            dgvccSubInven.Value = DBNull.Value
        End If

    End Sub

    Private Sub txtdeliveryday_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtdeliveryday.TextChanged
        Dim aa As Integer
        Try
            aa = txtdeliveryday.Text
            Me.DtDileveryDate.Value = Me.DateYIN.Value.AddDays(aa)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub txtShipvia_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtShipvia.KeyDown
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send("{tab}")
        End If
    End Sub

    Private Sub txtcredit_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtcredit.TextChanged
        Dim d As Integer
        If IsNumeric(Me.txtcredit.Text.Trim) = True Then
            d = CDec(Me.txtcredit.Text.Trim)
        Else
            d = 0
        End If
        Try
            Me.DtPayDate.Value = Now().AddDays(d)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub BtnYarnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnYarnExit.Click
        Me.Close()
    End Sub

    Private Function chkErrbutUse(ByVal strmsg As String) As Boolean

    End Function

    Private Function chkErrbutUse2(ByVal strmsg As String) As Boolean

    End Function

    Private Sub calc_final_totals_percent()
        Dim m_CurrExchangeRate As Double = 0
        Dim m_GrossLineAmt As Double = 0
        Dim m_GrossLineDisc As Double = 0
        Dim m_NetLineAmt As Double = 0
        Dim m_OrderDiscPer As Double = 0
        Dim m_OrderDiscAmt As Double = Val(IIf(IsNumeric(txtDiscountamount.Text.Replace(",", "")), txtDiscountamount.Text.Replace(",", ""), 0))
        Dim m_NetOrderAmt As Double = 0
        Dim m_VATPer As Double = 0
        Dim m_VATAmt As Double = Val(IIf(IsNumeric(txtVatAmount.Text.Replace(",", "")), txtVatAmount.Text.Replace(",", ""), 0))
        Dim m_NetOrderAmtAfterVAT As Double = 0

        Call sumLineTotals_dispercent()

        m_CurrExchangeRate = Val(IIf(IsNumeric(txtrate.Text), txtrate.Text, 0))
        m_CurrExchangeRate = IIf(m_CurrExchangeRate <= 0, 1, m_CurrExchangeRate)
        m_GrossLineAmt = sumGrossAmt '* m_CurrExchangeRate
        m_GrossLineDisc = sumDiscAmt '* m_CurrExchangeRate
        m_NetLineAmt = m_GrossLineAmt - m_GrossLineDisc
        m_OrderDiscPer = Val(IIf(IsNumeric(txtDiscper.Text), txtDiscper.Text, 0))

        'Edit By Neung 08/06/2015
        If m_OrderDiscPer = 0 Then
            If m_NetLineAmt = 0 Then
                m_OrderDiscPer = 0
            Else
                m_OrderDiscPer = Math.Round((m_OrderDiscAmt / m_NetLineAmt) * 100, 2, MidpointRounding.AwayFromZero)
            End If
        Else
            m_OrderDiscAmt = m_NetLineAmt * m_OrderDiscPer * 0.01
        End If

        'm_OrderDiscPer = Math.Round((m_OrderDiscAmt / m_NetLineAmt) * 100, 2)
        If Clsconfig.IsNull(txtDiscountamount.Text, 0) = 0 Then

        End If
        ' m_OrderDiscAmt = Val(txtDiscountamount.Text)

        m_NetOrderAmt = m_NetLineAmt - m_OrderDiscAmt
        m_VATPer = Val(IIf(IsNumeric(txtVatPer.Text), txtVatPer.Text, 0))
        If m_VATPer = 0 Then
            m_VATPer = Math.Round((m_VATAmt / m_NetOrderAmt) * 100, 4, MidpointRounding.AwayFromZero) 'Show 4 digit Sitthana 20190601
        Else
            m_VATAmt = m_NetOrderAmt * m_VATPer * 0.01
        End If
        m_NetOrderAmtAfterVAT = m_NetOrderAmt + m_VATAmt

        txtrate.Text = FormatNumber(m_CurrExchangeRate, 2, TriState.False, TriState.False, TriState.True)
        txtGrossamount.Text = FormatNumber(m_GrossLineAmt, 2, TriState.False, TriState.False, TriState.True)
        txtGrossLineDiscount.Text = FormatNumber(m_GrossLineDisc, 2, TriState.False, TriState.False, TriState.True)
        txtNetLineAmount.Text = FormatNumber(m_NetLineAmt, 2, TriState.False, TriState.False, TriState.True)
        txtDiscper.Text = FormatNumber(m_OrderDiscPer, 2, TriState.False, TriState.False, TriState.True)
        txtDiscountamount.Text = FormatNumber(m_OrderDiscAmt, 2, TriState.False, TriState.False, TriState.True)
        txtNetOrderAmount.Text = FormatNumber(m_NetOrderAmt, 2, TriState.False, TriState.False, TriState.True)
        txtVatPer.Text = FormatNumber(m_VATPer, 4, TriState.False, TriState.False, TriState.True) 'Show 4 digit Sitthana 20190601
        txtVatAmount.Text = FormatNumber(m_VATAmt, 2, TriState.False, TriState.False, TriState.True)
        txtTotalAmount.Text = FormatNumber(m_NetOrderAmtAfterVAT, 2, TriState.False, TriState.False, TriState.True)

        '' Define variables to hold totals
        'Dim m_grossAmt As Double
        'Dim m_lineDiscAmt As Double

        'Dim m_finalDiscAmt As Double
        'Dim m_vatper As Double
        'Dim m_vatamt As Double
        'Dim m_taxamt As Double

        'Dim m_finalDiscPer As Double
        'Dim m_AfterLineDisc As Double
        'Dim m_AfterAllDisc As Double
        'Dim m_AfterVat As Double
        'Dim m_netTotalAmt As Double

        'sumLineTotals()

        ''check for null & initialise the values in the textbox
        'If txtDisper.Text = "" Then
        '	txtDisper.Text = 0
        'End If
        'If txtVat.Text = "" Then
        '	txtVat.Text = 0
        'End If

        ''final discount % & vat
        'm_finalDiscPer = txtDisper.Text
        'm_vatper = txtVat.Text

        ''gross amount arrived by Qty*price from line items
        'm_grossAmt = sumGrossAmt

        ''disc amount arrived by qty*price*discper/100 from line items
        'm_lineDiscAmt = sumDiscAmt

        ''(A) amount arrived after deducting line discount from gross amount
        'm_AfterLineDisc = m_grossAmt - m_lineDiscAmt

        ''(B) amount arrived after deducting final discount from above amount (A)
        'm_finalDiscAmt = m_AfterLineDisc * m_finalDiscPer / 100
        'm_AfterAllDisc = m_AfterLineDisc - m_finalDiscAmt

        ''(C)amount arrived after adding vat amount from above (B)
        'm_vatamt = m_AfterAllDisc * m_vatper / 100
        'm_AfterVat = m_AfterAllDisc + m_vatamt

        ''(D)amount arrived after adding vat (C) is the net amount
        'm_netTotalAmt = m_AfterVat

        ''put the arrived totals in the respective textboxes.
        'Me.txtGrossamount.Text = String.Format("{0:#,###0.00}", m_grossAmt)
        'Me.txtDiscountamount.Text = String.Format("{0:#,###0.00}", m_lineDiscAmt + m_finalDiscAmt)
        'Me.txtVatAmount.Text = String.Format("{0:#,###0.00}", m_vatamt)
        'Me.txtDiscountamount.Text = String.Format("{0:#,###0.00}", m_lineDiscAmt + m_finalDiscAmt)
        'Me.txtTotalAmount.Text = String.Format("{0:#,###0.00}", m_AfterVat)
    End Sub

    Private Sub calc_final_totals()
        Dim m_CurrExchangeRate As Double = 1
        Dim m_GrossLineAmt As Double = 0
        Dim m_GrossLineDisc As Double = 0
        Dim m_NetLineAmt As Double = 0
        Dim m_OrderDiscPer As Double = 0
        Dim m_OrderDiscAmt As Double = Val(IIf(IsNumeric(txtDiscountamount.Text.Replace(",", "")), txtDiscountamount.Text.Replace(",", ""), 0))
        Dim m_NetOrderAmt As Double = 0
        Dim m_VATPer As Double = Val(IIf(IsNumeric(txtVatPer.Text.Replace(",", "")), txtVatPer.Text.Replace(",", ""), 0))
        Dim m_VATAmt As Double = Val(IIf(IsNumeric(txtVatAmount.Text.Replace(",", "")), txtVatAmount.Text.Replace(",", ""), 0))
        Dim m_NetOrderAmtAfterVAT As Double = 0

        Call sumLineTotals()

        m_CurrExchangeRate = Val(IIf(IsNumeric(txtrate.Text), txtrate.Text, 0))
        m_CurrExchangeRate = IIf(m_CurrExchangeRate <= 0, 1, m_CurrExchangeRate)

        m_GrossLineAmt = sumGrossAmt '* m_CurrExchangeRate
        m_GrossLineDisc = sumDiscAmt '* m_CurrExchangeRate
        m_NetLineAmt = m_GrossLineAmt - m_GrossLineDisc
        m_OrderDiscPer = Val(IIf(IsNumeric(txtDiscper.Text), txtDiscper.Text, 0))

        'Edit By Neung 08/06/2015
        'If m_OrderDiscPer = 0 Then
        '    If m_NetLineAmt = 0 Then
        '        m_OrderDiscPer = 0
        '    Else
        '        m_OrderDiscPer = Math.Round((m_OrderDiscAmt / m_NetLineAmt) * 100, 2)
        '    End If
        'Else
        '    m_OrderDiscAmt = m_NetLineAmt * m_OrderDiscPer * 0.01
        'End If

        ' m_OrderDiscPer = Math.Round((m_OrderDiscAmt / m_NetLineAmt) * 100, 18)
        If m_NetLineAmt = 0 Then
            m_OrderDiscPer = 0
        Else
            m_OrderDiscPer = Math.Round((m_OrderDiscAmt / m_NetLineAmt) * 100, 2)
        End If
        '  m_OrderDiscPer = Math.Round((m_OrderDiscAmt / m_NetLineAmt) * 100, 2)
        'm_OrderDiscAmt = Val(txtDiscountamount.Text)

        m_NetOrderAmt = m_NetLineAmt - m_OrderDiscAmt

        m_VATPer = Val(IIf(IsNumeric(txtVatPer.Text), txtVatPer.Text, 0))

        If m_VATPer = 0 Then
            If m_NetOrderAmt = 0 Then
                m_VATPer = 0
            Else
                m_VATPer = Math.Round((m_VATAmt / m_NetOrderAmt) * 100, 2)
            End If
        Else
            m_VATAmt = m_NetOrderAmt * m_VATPer * 0.01
        End If

        'If m_VATPer = 0 Then
        '    m_VATPer = Math.Round((m_VATAmt / m_NetOrderAmt) * 100, 2)
        'ElseIf m_VATPer > 0 Then
        '    m_VATAmt = m_NetOrderAmt * m_VATPer * 0.01
        'End If

        m_NetOrderAmtAfterVAT = m_NetOrderAmt + m_VATAmt

        txtrate.Text = FormatNumber(m_CurrExchangeRate, 2, TriState.False, TriState.False, TriState.True)
        txtGrossamount.Text = FormatNumber(m_GrossLineAmt, 2, TriState.False, TriState.False, TriState.True)
        txtGrossLineDiscount.Text = FormatNumber(m_GrossLineDisc, 2, TriState.False, TriState.False, TriState.True)
        txtNetLineAmount.Text = FormatNumber(m_NetLineAmt, 2, TriState.False, TriState.False, TriState.True)
        txtDiscper.Text = FormatNumber(m_OrderDiscPer, 2, TriState.False, TriState.False, TriState.True)
        txtDiscountamount.Text = FormatNumber(m_OrderDiscAmt, 2, TriState.False, TriState.False, TriState.True)
        txtNetOrderAmount.Text = FormatNumber(m_NetOrderAmt, 2, TriState.False, TriState.False, TriState.True)
        txtVatPer.Text = FormatNumber(m_VATPer, 2, TriState.False, TriState.False, TriState.True)
        txtVatAmount.Text = FormatNumber(m_VATAmt, 2, TriState.False, TriState.False, TriState.True)
        txtTotalAmount.Text = FormatNumber(m_NetOrderAmtAfterVAT, 2, TriState.False, TriState.False, TriState.True)

    End Sub

    Private Sub txtPurno_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtPurno.KeyDown
        errorSaved.SetError(Me.txtPurno, "")
        If e.KeyCode = Keys.F4 Then
            loadSearchPO()
            Exit Sub
        End If
        If e.KeyCode = Keys.Enter Then
            ' If Validate_PO() Then
            showPOData()
            'End If
        End If

    End Sub
    Private Function Validate_PO() As Boolean
        Dim objdb As New classPurchaseEdit
        Dim dt As DataTable = objdb.Validate_PO(txtPurno.Text.Trim, clsUser.UserID)

        If dt.Rows.Count > 0 Then
            MessageBox.Show("PO No .: " & txtPurno.Text.Trim & "............   is Already Yarn In!! & No.: " & Trim(dt.Rows(0)("docno").ToString), "SyStem Messsage", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return False
        Else
            Return True
        End If

    End Function
    Private Function chkErrbutUseClearTable(ByVal strmsg As String) As Boolean
        Try
            ds.Tables("v_pur").Clear()
            chkErrbutUseClearTable = True
        Catch ex As Exception
            chkErrbutUseClearTable = False
            Exit Function
        End Try
    End Function

    Private Function chkErrbutUseClearTableDet(ByVal strmsg As String) As Boolean
        Try
            ds.Tables("v_purdet").Clear()
            chkErrbutUseClearTableDet = True
        Catch ex As Exception
            chkErrbutUseClearTableDet = False
            Exit Function
        End Try
    End Function

    Private Function chkErrbutUseHavedataIntable(ByVal strmsg As String) As Boolean
        Dim strtempA As String = ""
        Try
            strtempA = ds.Tables("v_pur").Rows(0).Item("itcd").ToString
            chkErrbutUseHavedataIntable = True
        Catch ex As Exception
            chkErrbutUseHavedataIntable = False
            Exit Function
        End Try
    End Function

    Private Sub BtnYarnPrintDoc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnPrintEN.Click
        Dim frm As New frmReport
        Dim rpt As New CrystalDecisions.CrystalReports.Engine.ReportDocument
        Dim rptFileName As String
        Dim jobno As String = ""
        Dim docno As String = txtPurno.Text.Trim

        If docno = "" Then

            rptFileName = "RptPurchaseOrderCreate.rpt"
            If Not oConfig.CheckReport(clsUser.ReportPath, rptFileName) Then Exit Sub
            rpt.Load(clsUser.ReportPath & rptFileName)
            rpt.DataSourceConnections.Item(0).SetConnection(clsConn.servername, clsConn.database, False)
            rpt.DataSourceConnections.Item(0).SetLogon(clsConn.Userid, clsConn.Password)
            rpt.VerifyDatabase()
            rpt.SetParameterValue("@jobno", docno)

        Else
            rptFileName = "RptPurchaseOrderCreate.rpt"
            If Not oConfig.CheckReport(clsUser.ReportPath, rptFileName) Then Exit Sub
            rpt.Load(clsUser.ReportPath & rptFileName)
            rpt.DataSourceConnections.Item(0).SetConnection(clsConn.servername, clsConn.database, False)
            rpt.DataSourceConnections.Item(0).SetLogon(clsConn.Userid, clsConn.Password)
            rpt.VerifyDatabase()
            rpt.SetParameterValue("@jobno", docno)

        End If

        frm.Title = "PurchaseOrder"
        frm.CRViewer.ReportSource = rpt
        frm.MdiParent = Me.ParentForm
        frm.Show()
        Me.Cursor = Cursors.Default

        'Dim str As String
        'str = ""
        'ds.Clear()
        'If Me.txtPurno.Text.Trim = "" Then
        '    Exit Sub
        'End If
        ''str = "select * from v_pur where jobno = '" & Me.txtPurno.Text.Trim & "'"
        'Dim myda As New SqlDataAdapter(str.ToString, connStr.connection)
        'myda.Fill(ds, "Tblprint")
        'If ds.Tables("Tblprint").Rows.Count > 0 Then

        '    If Not PrintReport(ds) Then

        '    End If
        'End If
    End Sub

    Private Function PrintReport(ByVal ds As DataSet) As Boolean
        Dim str As String
        str = ""
        ds.Clear()
        If Me.txtPurno.Text.Trim = "" Then
            Exit Function
        End If
        str = "select * from v_pur where jobno = '" & Me.txtPurno.Text.Trim & "'"
        Dim myda As New SqlDataAdapter(str.ToString, connStr.connection)
        myda.Fill(ds, "Tblprint")
        If ds.Tables("Tblprint").Rows.Count > 0 Then
            If Not PrintReport(ds) Then

            End If
        End If



        Dim clsConn As New classConnection()
        Const rptFileName = "RptPurchaseOrderCreate.rpt"
        If Not Clsconfig.CheckReport(clsUser.ReportPath, rptFileName) Then Return False
        Dim frm As New frmReport
        Dim rpt As New CrystalDecisions.CrystalReports.Engine.ReportDocument
        Me.Cursor = Cursors.WaitCursor

        rpt.Load(clsUser.ReportPath & rptFileName)
        rpt.DataSourceConnections.Item(0).SetConnection(clsConn.servername, clsConn.database, False)
        rpt.DataSourceConnections.Item(0).SetLogon(clsConn.Userid, clsConn.Password)
        rpt.SetDataSource(ds.Tables("Tblprint"))

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
    Private Sub sumLineTotals_dispercent()
        Qty = 0
        UnitPrice = 0
        DiscPerc = 0
        Lineamt = 0
        sumDiscAmt = 0
        sumGrossAmt = 0

        Try
            Dim i As Integer

            For i = 0 To Me.dgvJobDet.Rows.Count - 2
                Me.dgvJobDet.Rows(i).Cells("colQty").Value = Clsconfig.IsNull(Me.dgvJobDet.Rows(i).Cells("colQty").Value, 0)
                Me.dgvJobDet.Rows(i).Cells("colPrice").Value = Clsconfig.IsNull(Me.dgvJobDet.Rows(i).Cells("colPrice").Value, 0)
                Me.dgvJobDet.Rows(i).Cells("colDiscper").Value = Clsconfig.IsNull(Me.dgvJobDet.Rows(i).Cells("colDiscper").Value, 0)
                Me.dgvJobDet.Rows(i).Cells("colDiscamt").Value = Clsconfig.IsNull(Me.dgvJobDet.Rows(i).Cells("colDiscamt").Value, 0)

                Qty = Me.dgvJobDet.Rows(i).Cells("colQty").Value
                UnitPrice = Me.dgvJobDet.Rows(i).Cells("colPrice").Value
                DiscPerc = dgvJobDet.Rows(i).Cells("colDiscper").Value
                Discamt = Me.dgvJobDet.Rows(i).Cells("colDiscamt").Value
                Lineamt = Me.dgvJobDet.Rows(i).Cells("colLineamt").Value

                If DiscPerc > 0 Then
                    Discamt = ((Qty * UnitPrice) * DiscPerc) / 100
                Else
                    If Discamt > 0 Then
                        DiscPerc = (Discamt * 100) / (Qty * UnitPrice)
                        dgvJobDet.Rows(i).Cells("colDiscper").Value = DiscPerc
                    End If 'Sitthana 20240605
                End If

                Me.dgvJobDet.Rows(i).Cells("colDiscamt").Value = Discamt
                Me.dgvJobDet.Rows(i).Cells("colLineamt").Value = (Qty * UnitPrice) - Discamt '((Qty * UnitPrice) * DiscPer) / 100
                'Me.dgvJobDet.Rows(i).Cells("colLineamt").Value = (Qty * UnitPrice) - ((Qty * UnitPrice) * DiscPer) / 100
                sumDiscAmt = sumDiscAmt + Me.dgvJobDet.Rows(i).Cells("colDiscAmt").Value
                sumGrossAmt = sumGrossAmt + (Qty * UnitPrice)
            Next

            'Edit By Neung 08/06/2015
            Me.txtDiscountamount.Text = String.Format("{0:#,###0.00}", sumDiscAmt)  ' sumDiscAmt
            'Me.txtDiscountamount.Text = String.Format("{0:#,###0.00}", Me.txtDiscountamount.Text)  ' sumDiscAmt

            Me.txtGrossamount.Text = String.Format("{0:#,###0.00}", sumGrossAmt) 'sumGrossAmt
            Dim grossamount As Double
            Dim vat As Double
            vat = Val(Me.txtVatPer.Text)
            'grossamount = Me.txtGrossamount.Text
            grossamount = sumGrossAmt
            txtVatAmount.Text = String.Format("{0:#,###0.00}", (grossamount * vat) / 100) '(grossamount * vat) / 100

            Dim discountamount As Double
            Dim taxamount As Double
            'VatAmt = Me.txtVatAmount.Text
            VatAmt = (grossamount * vat) / 100
            'discountamount = Me.txtDiscountamount.Text
            discountamount = sumDiscAmt
            Dim Argtotalamount As Double
            Argtotalamount = grossamount - (VatAmt + taxamount + txtVatAmount.Text + discountamount)
            Me.txtTotalAmount.Text = String.Format("{0:#,###0.00}", Argtotalamount)

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub sumLineTotals()
        Qty = 0
        UnitPrice = 0
        DiscPerc = 0
        sumDiscAmt = 0
        sumGrossAmt = 0

        Try
            Dim i As Integer

            For i = 0 To Me.dgvJobDet.Rows.Count - 2
                'If Me.DgYarn.Rows(i).Cells("colQty").Value = Nothing Then
                '	Me.DgYarn.Rows(i).Cells("colqty").Value = 0
                'End If

                'If Me.DgYarn.Rows(i).Cells("colPrice").Value = Nothing Then
                '	Me.DgYarn.Rows(i).Cells("colPrice").Value = 0
                'End If

                'If Me.DgYarn.Rows(i).Cells("colDiscper").Value = Nothing Then
                '	Me.DgYarn.Rows(i).Cells("colDiscper").Value = 0
                'End If

                'If Me.DgYarn.Rows(i).Cells("colDiscamt").Value = Nothing Then
                '	Me.DgYarn.Rows(i).Cells("coldiscamt").Value = 0
                'End If
                Me.dgvJobDet.Rows(i).Cells("colQty").Value = Clsconfig.IsNull(Me.dgvJobDet.Rows(i).Cells("colQty").Value, 0)
                Me.dgvJobDet.Rows(i).Cells("colPrice").Value = Clsconfig.IsNull(Me.dgvJobDet.Rows(i).Cells("colPrice").Value, 0)
                Me.dgvJobDet.Rows(i).Cells("colDiscper").Value = Clsconfig.IsNull(Me.dgvJobDet.Rows(i).Cells("colDiscper").Value, 0)
                Me.dgvJobDet.Rows(i).Cells("colDiscamt").Value = Clsconfig.IsNull(Me.dgvJobDet.Rows(i).Cells("colDiscamt").Value, 0)

                Qty = Me.dgvJobDet.Rows(i).Cells("colQty").Value
                UnitPrice = Me.dgvJobDet.Rows(i).Cells("colPrice").Value
                DiscPerc = dgvJobDet.Rows(i).Cells("colDiscper").Value
                Discamt = Me.dgvJobDet.Rows(i).Cells("colDiscamt").Value

                '����� Discount Amount ���ӹǳ % ��Ѻ
                If DiscPerc > 0 Then
                    Discamt = ((Qty * UnitPrice) * DiscPerc) / 100
                Else
                    If Discamt > 0 Then
                        DiscPerc = (Discamt * 100) / (Qty * UnitPrice)
                        dgvJobDet.Rows(i).Cells("colDiscper").Value = DiscPerc
                    End If 'Sitthana 20240605
                End If

                ' dgvJobDet.Rows(i).Cells("colDiscper").Value = DiscPerc
                Me.dgvJobDet.Rows(i).Cells("colDiscamt").Value = Discamt

                Me.dgvJobDet.Rows(i).Cells("colLineamt").Value = (Qty * UnitPrice) - Discamt ' ((Qty * UnitPrice) * DiscPerc) / 100

                sumDiscAmt = sumDiscAmt + Me.dgvJobDet.Rows(i).Cells("colDiscAmt").Value
                sumGrossAmt = sumGrossAmt + (Qty * UnitPrice)
            Next

            'Edit By Neung 08/06/2015
            ' Me.txtDiscountamount.Text = String.Format("{0:#,###0.00}", sumDiscAmt)  ' sumDiscAmt
            Me.txtDiscountamount.Text = String.Format("{0:#,###0.00}", Me.txtDiscountamount.Text)  ' sumDiscAmt

            Me.txtGrossamount.Text = String.Format("{0:#,###0.00}", sumGrossAmt) 'sumGrossAmt
            Dim grossamount As Double
            Dim vat As Double
            vat = Val(Me.txtVatPer.Text)
            'grossamount = Me.txtGrossamount.Text
            grossamount = sumGrossAmt
            txtVatAmount.Text = String.Format("{0:#,###0.00}", (grossamount * vat) / 100) '(grossamount * vat) / 100

            Dim discountamount As Double
            Dim taxamount As Double
            'VatAmt = Me.txtVatAmount.Text
            VatAmt = (grossamount * vat) / 100
            'discountamount = Me.txtDiscountamount.Text
            discountamount = sumDiscAmt
            Dim Argtotalamount As Double
            Argtotalamount = grossamount - (VatAmt + taxamount + txtVatAmount.Text + discountamount)
            Me.txtTotalAmount.Text = String.Format("{0:#,###0.00}", Argtotalamount)

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub buttonSearchPO_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles buttonSearchPO.Click
        Call loadSearchPO()
    End Sub

    Private Sub showPOData()
        TabControl1.SelectedTab = TabPage2

        Dim dsset As New DataSet
        Dim strsqlpo As String
        Dim strsqlpodet As String
        Dim strmsg As String = ""

        strsqlpo = "exec p_po_select '" & Me.txtPurno.Text.Trim & "'"
        Dim da As New SqlDataAdapter(strsqlpo.ToString, connStr.connection)

        strsqlpodet = "exec p_po_det_select '" & Me.txtPurno.Text.Trim & "'"
        Dim daDet As New SqlDataAdapter(strsqlpodet.ToString, connStr.connection)

        If ds.Tables.Count > 0 Then
            If chkErrbutUseClearTable(strmsg) = True Then
                ds.Tables("v_pur").Clear()
            End If

            If chkErrbutUseClearTableDet(strmsg) = True Then
                ds.Tables("v_purdet").Clear()
            End If
        End If

        da.Fill(ds, "v_pur")
        daDet.Fill(ds, "v_purdet")

        '==================================================================================
        If ds.Tables("v_pur").Rows.Count > 0 Then


            'comboItemNature.SelectedValue = ds.Tables("v_pur").Rows(0).Item("itnaturecd")
            ' Me.DtDileveryDate.text = ds.Tables("v_pur").Rows(0).Item("delidt") 'Neung 

            If Not IsDBNull(ds.Tables("v_pur").Rows(0).Item("delidt")) Then 'Neung 20260508
                Me.DtDileveryDate.Value = ds.Tables("v_pur").Rows(0).Item("delidt")
                Me.DtDileveryDate.Checked = True
            Else
                Me.DtDileveryDate.Checked = False

            End If

            Me.txtpackcd.Text = ds.Tables("v_pur").Rows(0).Item("splins")
            Me.txtremark.Text = ds.Tables("v_pur").Rows(0).Item("splins")
            Me.txtrate.Text = Clsconfig.IsNull(ds.Tables("v_pur").Rows(0).Item("exrt"), "")
            Me.txtVatPer.Text = ds.Tables("v_pur").Rows(0).Item("vat")

            Me.txtGrossamount.Text = ds.Tables("v_pur").Rows(0).Item("gross_amt") 'New '���
            Me.txtGrossLineDiscount.Text = ds.Tables("v_pur").Rows(0).Item("line_discamt") 'New
            Me.txtNetLineAmount.Text = ds.Tables("v_pur").Rows(0).Item("net_lineamt") 'New ���������
            Me.txtDiscper.Text = ds.Tables("v_pur").Rows(0).Item("discper")
            Me.txtDiscountamount.Text = ds.Tables("v_pur").Rows(0).Item("discamt")
            Me.txtNetOrderAmount.Text = ds.Tables("v_pur").Rows(0).Item("net_amt") '��ѧ�ѡ��ǹŴ'
            'Me.txtNetOrderAmount.Text = ds.Tables("v_pur").Rows(0).Item("totamt")
            Me.txtVatAmount.Text = ds.Tables("v_pur").Rows(0).Item("vatamt")
            Me.txtTotalAmount.Text = ds.Tables("v_pur").Rows(0).Item("totamt")

            Me.txtShipvia.Text = ds.Tables("v_pur").Rows(0).Item("shipvia")
            Me.textShipterms.Text = ds.Tables("v_pur").Rows(0).Item("shipterms")
            Me.textSupQuoteno.Text = ds.Tables("v_pur").Rows(0).Item("supquoteno").ToString.Trim
            Me.txtcredit.Text = ds.Tables("v_pur").Rows(0).Item("crdays")
            Me.cbCredit.Text = ds.Tables("v_pur").Rows(0).Item("crterm").ToString
            Me.textReqno.Text = ds.Tables("v_pur").Rows(0).Item("reqno").ToString
            Me.txtremark.Text = ds.Tables("v_pur").Rows(0).Item("rem").ToString
            Me.txtpackcd.Text = ds.Tables("v_pur").Rows(0).Item("splins").ToString
            Me.comboEmp.SelectedValue = ds.Tables("v_pur").Rows(0).Item("Empcd").ToString
            Me.comboDept.SelectedValue = ds.Tables("v_pur").Rows(0).Item("deptcd").ToString
            Me.CbSupplier.SelectedValue = ds.Tables("v_pur").Rows(0).Item("suppcd").ToString
            Me.cboCurrency.SelectedValue = ds.Tables("v_pur").Rows(0).Item("curr").ToString.Trim
            Me.DateYIN.Value = ds.Tables("v_pur").Rows(0).Item("jobdt").ToString.Trim

            txtBenefit.Text = ds.Tables("v_pur").Rows(0).Item("benefit").ToString.Trim
            txtPeriod.Text = ds.Tables("v_pur").Rows(0).Item("approve_period").ToString.Trim
            txtVehicleName.Text = ds.Tables("v_pur").Rows(0).Item("vehicle_name").ToString.Trim
            txtPortName.Text = ds.Tables("v_pur").Rows(0).Item("port_name").ToString.Trim
            txtAgencyName.Text = ds.Tables("v_pur").Rows(0).Item("agency_name").ToString.Trim
            txtBenefitAmount.Text = ds.Tables("v_pur").Rows(0).Item("benefit_amount").ToString.Trim

            txtPackingNo.Text = ds.Tables("v_pur").Rows(0).Item("packing_no").ToString
            txtInvoiceNo.Text = ds.Tables("v_pur").Rows(0).Item("invoice_no").ToString
            txtBLNo.Text = ds.Tables("v_pur").Rows(0).Item("bl_no").ToString
            txtPackingRemark.Text = ds.Tables("v_pur").Rows(0).Item("packing_remark").ToString
            dtpDeparture.Value = Clsconfig.ConvertFormatDateTostring(ds.Tables("v_pur").Rows(0).Item("estimate_departure").ToString)
            dtpArrival.Value = Clsconfig.ConvertFormatDateTostring(ds.Tables("v_pur").Rows(0).Item("estimate_arrival").ToString)
            txtBenefitKgs.Text = ds.Tables("v_pur").Rows(0).Item("benefit_kgs").ToString.Trim
            chksell_back_to_vendor.Checked = (New clsConfig).IsNull(ds.Tables("v_pur").Rows(0).Item("sell_back_to_vendor"), False)

            mcboPoLineType.SelectedValue = ds.Tables("v_pur").Rows(0).Item("po_line_types_id")

            If ds.Tables("v_pur").Rows(0).Item("present_status").ToString.Trim = "CANCELLED" Then
                blnCancel = False
                enableEdit = False
            Else
                blnCancel = True
                enableEdit = True
            End If
            Me.textPresentStatus.Text = ds.Tables("v_pur").Rows(0).Item("present_status").ToString

            If cboCurrency.Text.Trim = "THB" Then
                lblExechageDate.Text = ""
            Else
                lblExechageDate.Text = "( " & Format(DateYIN.Value, "dd/MM/yyyy") & " )"
            End If 'Sitthana 20201001
        Else

            'MsgBox("data not found kap pom !", MsgBoxStyle.Critical, "��سҵ�Ǩ�ͺ�����Ţ PO no :")

        End If

        'Detail
        'Neung 20260409
        InitDataBindingJobDet(Me.txtPurno.Text.Trim)
        'dst2 = ds.Tables("v_purdet")
        'Me.dgvJobDet.AutoGenerateColumns = False
        'Me.dgvJobDet.DataSource = dst2


        Call enableDisableEdit()

    End Sub

    Private Sub loadSearchPO()
        Dim formSearchPO As New formSearchPO
        formSearchPO.ShowDialog()

        If formSearchPO.puserAction = "OK" Then
            Me.txtPurno.Text = formSearchPO.pSelectedPO
            Call showPOData()
        End If

    End Sub

    Private Sub enableDisableEdit()
        'Me.BtnYarnSave.Enabled = enableEdit
        If blnCancel = False Then
            Call EnabledControl(False)
        ElseIf blnCancel = True Then
            Call EnabledControl(True)
        End If

        txtGrossamount.Enabled = False
        'txtrate.Enabled = False 'User Need To Edit Rate On Tranfer Date
        txtGrossLineDiscount.Enabled = False
        txtNetLineAmount.Enabled = False
        txtNetOrderAmount.Enabled = False
        txtTotalAmount.Enabled = False
        buttonSearchPO.Enabled = True
        txtPurno.Enabled = True
        comboItemNature.Enabled = False

    End Sub

    Private Sub EnabledControl(ByVal blnEnabled As Boolean)
        Dim obj As Control
        For Each obj In Me.Controls
            Call SetControlEnabled(obj, blnEnabled)
        Next

        comboItemNature.Enabled = False

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

    Private Sub DgYarn_CellEndEdit(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvJobDet.CellEndEdit

        '----------------- Inculde Subinventory 
        Dim objdb As New classMaster
        Dim dgvccSubInven As New DataGridViewComboBoxCell
        Dim dtSubInven As New DataTable

        If dgvJobDet.Columns(e.ColumnIndex).Name = "rcv_warehouse_id" Then
            If Not IsDBNull(dgvJobDet.Rows(e.RowIndex).Cells("rcv_warehouse_id").Value) Then
                dtSubInven = objdb.GetCombomtl_subinventory(dgvJobDet.Rows(e.RowIndex).Cells("rcv_warehouse_id").Value)
                dgvccSubInven = dgvJobDet.Rows(e.RowIndex).Cells("rcv_subinventory_id")

                Try
                    dgvccSubInven.DataSource = dtSubInven
                    dgvccSubInven.DisplayMember = "subinventory_code"
                    dgvccSubInven.ValueMember = "mtl_subinventory_id"
                    Dim expression As String
                    expression = "subinventory_code = 'YARNS'"

                    Dim foundRows() As DataRow
                    foundRows = dtSubInven.Select(expression)
                    dgvccSubInven.Value = DBNull.Value

                Catch ex As Exception
                    dgvccSubInven.Value = DBNull.Value
                End Try
            End If
        End If
        '------------------ End
        If dgvJobDet.Columns(e.ColumnIndex).Name = "colqty" _
            Or dgvJobDet.Columns(e.ColumnIndex).Name = "coldiscper" _
            Or dgvJobDet.Columns(e.ColumnIndex).Name = "coldiscamt" Then
            Call calc_final_totals()
        End If
    End Sub

    Private Sub txtrate_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtrate.LostFocus
        calc_final_totals()
        Call txtDiscper.Focus()
    End Sub

    Private Sub txtDisper_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles txtDiscper.KeyDown
        Dim clsconfig As New clsConfig
        If e.KeyCode = Keys.Enter Then
            txtDiscountamount.Text = "0"
            If clsconfig.IsNull(txtDiscountamount.Text, 0) = 0 Then
                calc_final_totals_percent()
            End If
        End If
        'If e.KeyCode = Keys.Enter Then
        'txtDiscountamount.Text = ""
        'calc_final_totals_percent()
        'End If
    End Sub

    Private Sub txtDisper_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtDiscper.LostFocus
        txtDiscountamount.Text = ""
        Dim clsconfig As New clsConfig
        If clsconfig.IsNull(txtDiscountamount.Text, 0) = 0 Then
            calc_final_totals_percent()
        End If
        'txtDiscountamount.Text = ""
        'calc_final_totals_percent()
    End Sub

    Private Sub txtDiscountamount_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles txtDiscountamount.KeyDown
        Dim clsconfig As New clsConfig
        If e.KeyCode = Keys.Enter Then
            txtDiscper.Text = "0"
            If clsconfig.IsNull(txtDiscper.Text, "") = "0" Then
                calc_final_totals_percent()
            End If
        End If
    End Sub

    Private Sub txtDiscountamount_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtDiscountamount.LostFocus
        Dim clsconfig As New clsConfig
        If clsconfig.IsNull(txtDiscper.Text, 0) = 0 Then
            calc_final_totals_percent()
        End If
    End Sub

    Private Sub txtVat_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles txtVatPer.KeyDown
        Dim clsconfig As New clsConfig
        If e.KeyCode = Keys.Enter Then
            txtVatAmount.Text = "0"
            If clsconfig.IsNull(txtVatAmount.Text, 0) = "0" Then
                calc_final_totals_percent()
            End If
        End If
    End Sub

    Private Sub txtVat_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtVatPer.LostFocus
        Dim clsconfig As New clsConfig
        If clsconfig.IsNull(txtVatAmount.Text, 0) = 0 Then
            calc_final_totals_percent()
        End If
    End Sub

    Private Sub txtVatAmount_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles txtVatAmount.KeyDown
        Dim clsconfig As New clsConfig
        If e.KeyCode = Keys.Enter Then
            txtVatPer.Text = "0"
            If clsconfig.IsNull(txtVatPer.Text, "0") = 0 Then
                calc_final_totals_percent()
            End If
        End If

    End Sub

    Private Sub txtVatAmount_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtVatAmount.LostFocus
        Dim clsconfig As New clsConfig
        If clsconfig.IsNull(txtVatPer.Text, 0) = 0 Then
            calc_final_totals_percent()
        End If
    End Sub

    Private Sub DgYarn_CellValidated(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvJobDet.CellValidated


        If dgvJobDet.Columns(e.ColumnIndex).Name = "colqty" _
            Or dgvJobDet.Columns(e.ColumnIndex).Name = "coldiscper" _
            Or dgvJobDet.Columns(e.ColumnIndex).Name = "coldiscamt" Then
            Call calc_final_totals()
        End If

    End Sub




    Private Sub btnPrintTH_Click(sender As System.Object, e As System.EventArgs) Handles btnPrintTH.Click
        Dim frm As New frmReport
        Dim rpt As New CrystalDecisions.CrystalReports.Engine.ReportDocument
        Dim rptFileName As String
        Dim jobno As String = ""
        Dim docno As String = txtPurno.Text.Trim

        If docno = "" Then

            rptFileName = "RptPurchaseOrderCreateTH.rpt"
            If Not oConfig.CheckReport(clsUser.ReportPath, rptFileName) Then Exit Sub
            rpt.Load(clsUser.ReportPath & rptFileName)
            rpt.DataSourceConnections.Item(0).SetConnection(clsConn.servername, clsConn.database, False)
            rpt.DataSourceConnections.Item(0).SetLogon(clsConn.Userid, clsConn.Password)
            rpt.VerifyDatabase()
            rpt.SetParameterValue("@jobno", docno)

        Else
            rptFileName = "RptPurchaseOrderCreateTH.rpt"
            If Not oConfig.CheckReport(clsUser.ReportPath, rptFileName) Then Exit Sub
            rpt.Load(clsUser.ReportPath & rptFileName)
            rpt.DataSourceConnections.Item(0).SetConnection(clsConn.servername, clsConn.database, False)
            rpt.DataSourceConnections.Item(0).SetLogon(clsConn.Userid, clsConn.Password)
            rpt.VerifyDatabase()
            rpt.SetParameterValue("@jobno", docno)

        End If

        frm.Title = "PurchaseOrder"
        frm.CRViewer.ReportSource = rpt
        frm.MdiParent = Me.ParentForm
        frm.Show()
        Me.Cursor = Cursors.Default
    End Sub
    Private Sub comboItemNature_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles comboItemNature.SelectedIndexChanged
        'GetDataComcoInDgridItems()
        Dim objdb As New GetDataYarn


        Dim dgvcc As New DataGridViewComboBoxCell
        Dim dgvccold As New DataGridViewComboBoxCell
        For i = 0 To dgvJobDet.Rows.Count - 2
            dgvcc = dgvJobDet.Rows(i).Cells("colItcd")
            'dgvccold.Value = dgvcc.Value.copy

            Dim dt As New DataTable
            dt = objdb.GetDataItemcode("", comboItemNature.SelectedValue.ToString.Trim.ToUpper)

            If dt.Rows.Count > 0 Then
                Try
                    dgvcc.Value = dt.Rows(0)("itcd")

                    dgvcc.DataSource = dt
                    dgvcc.DisplayMember = "itdesc"
                    dgvcc.ValueMember = "itcd"
                    'dgvcc.Value = dt.Rows(0)("itcd")

                Catch ex As Exception

                End Try


            Else
                dgvcc.Value = Nothing
            End If
        Next
    End Sub


    Private Sub cboCurrency_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboCurrency.SelectedIndexChanged
        If Not IsDBNull(cboCurrency.DataSource) And cboCurrency.ValueMember = "curr" Then
            If cboCurrency.SelectedValue = "THB" Then
                txtrate.Text = FormatNumber("1.00", 4)
                lblExechageDate.Text = ""
            Else
                Dim dt As New DataTable

                lblExechageDate.Text = "( " & DateYIN.Text.Trim & " )"
                dt = clsMaster.getExchangeRateByDateCurr(Format(DateYIN.Value, "yyyyMMdd"), cboCurrency.Text.Trim)
                If dt.Rows.Count > 0 Then
                    txtrate.Text = dt.Rows(0)("exchange_rate")
                Else
                    txtrate.Text = ""
                    lblExechageDate.Text = ""
                End If 'Sitthana 20201001
            End If
        End If
    End Sub
    Private Function ValidateSOITM(dgvc As DataGridViewCell, errorMessage As String) As Boolean
        'Dim result As Boolean '= (textBox.Text = text)
        Dim frmLov As New frmListOfValues("SOITM")
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
                drvJobDet.Row("sonoid") = oConfig.IsNull(frmLov.pdrvSearchTable.Row("sonoid"), DBNull.Value)
                'drvJobDet.Row("itcd") = oConfig.IsNull(frmLov.pdrvSearchTable.Row("itcd"), DBNull.Value)
                '  drvJobDet.Row("itdesc") = oConfig.IsNull(frmLov.pdrvSearchTable.Row("itdesc"), DBNull.Value)
                '  drvJobDet.Row("qty") = oConfig.IsNull(frmLov.pdrvSearchTable.Row("qty"), DBNull.Value)
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
                        If Not ValidateSOITM(dgvJobDet.Rows(e.RowIndex).Cells(e.ColumnIndex), errorMsg) Then
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
                            'drvJobDet.Row("itcd") = DBNull.Value
                            ' drvJobDet.Row("itdesc") = DBNull.Value
                            ' drvJobDet.Row("qty") = DBNull.Value
                            ' drvJobDet.Row("uom") = DBNull.Value
                            drvJobDet.Row.EndEdit()
                            bsJobDet.EndEdit()
                            dgvJobDet.RefreshEdit()
                        End If
                    End If
                End If
                'Case "colSoNoId"
                '    If dgvJobDet.Rows(e.RowIndex).Cells(e.ColumnIndex).IsInEditMode Then
                '        If dgvJobDet.Rows(e.RowIndex).Cells(e.ColumnIndex).EditedFormattedValue.ToString.Trim.Length > 0 Then
                '            If Not ValidateSOITM(dgvJobDet.Rows(e.RowIndex).Cells(e.ColumnIndex), errorMsg) Then
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
                '                ''  drvJobDet.Row("itcd") = DBNull.Value
                '                '  drvJobDet.Row("itdesc") = DBNull.Value
                '                '  drvJobDet.Row("qty") = DBNull.Value
                '                ' drvJobDet.Row("uom") = DBNull.Value
                '                drvJobDet.Row.EndEdit()
                '                bsJobDet.EndEdit()
                '                dgvJobDet.RefreshEdit()
                '            End If
                '        End If
                '    End If
        End Select
    End Sub

    Private Sub dgvJobDet_EditingControlShowing(sender As Object, e As DataGridViewEditingControlShowingEventArgs) Handles dgvJobDet.EditingControlShowing
        Dim colName As String = dgvJobDet.CurrentCell.OwningColumn.Name
        Dim text As TextBox = TryCast(e.Control, TextBox)

        If text Is Nothing Then Exit Sub

        Select Case colName
            Case "colItcd"
                text.AutoCompleteMode = AutoCompleteMode.Suggest
                text.AutoCompleteSource = AutoCompleteSource.CustomSource
                text.AutoCompleteCustomSource = ItcdAutoComplete

            Case "colSoNo"
                text.AutoCompleteMode = AutoCompleteMode.Suggest
                text.AutoCompleteSource = AutoCompleteSource.CustomSource
                text.AutoCompleteCustomSource = soAutoComplete

            Case "colSoNoId"
                text.AutoCompleteMode = AutoCompleteMode.Suggest
                text.AutoCompleteSource = AutoCompleteSource.CustomSource
                text.AutoCompleteCustomSource = soLineIdAutoComplete

            Case Else
                text.AutoCompleteCustomSource = Nothing
                text.AutoCompleteSource = AutoCompleteSource.None
                text.AutoCompleteMode = AutoCompleteMode.None
        End Select
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
                ' drvJobDet.Row("itdesc") = oConfig.IsNull(frmLov.pdrvSearchTable.Row("itdesc"), DBNull.Value)
                'drvJobDet.Row("qty") = oConfig.IsNull(frmLov.pdrvSearchTable.Row("qty"), DBNull.Value)
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
    Private Function LovSoitmForPoLine(ByVal pFilterText As String, ByVal pItcd As String, ByRef errorMessage As String) As Boolean
        'Dim result As Boolean '= (textBox.Text = text)
        Dim frmLov As New frmListOfValues("SOITM")
        frmLov.AppConnection = _AppConn
        frmLov.AppUserId = UserInfo.UserID
        frmLov.AppSessionID = 0 'UserInfo.UserSessionID
        ' frmLov.pAppUserWarehouse = UserInfo.WarehouseCode
        frmLov.pItemCode = pItcd
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
                drvJobDet.Row("itcd") = oConfig.IsNull(frmLov.pdrvSearchTable.Row("itcd"), DBNull.Value)
                drvJobDet.Row("itdesc") = oConfig.IsNull(frmLov.pdrvSearchTable.Row("itdesc"), DBNull.Value)
                drvJobDet.Row("qty") = oConfig.IsNull(frmLov.pdrvSearchTable.Row("qty"), DBNull.Value)
                drvJobDet.Row("uom") = oConfig.IsNull(frmLov.pdrvSearchTable.Row("uom"), DBNull.Value)
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
                Dim pItcd As String = oConfig.IsNull(dgr.Cells("colItcd").Value, "")
                If Not LovSoitm("%", errorMsg) Then
                    dgvJobDet.Rows(e.RowIndex).ErrorText = errorMsg
                Else
                    dgvJobDet.Rows(e.RowIndex).ErrorText = ""
                End If
        End Select
    End Sub
End Class