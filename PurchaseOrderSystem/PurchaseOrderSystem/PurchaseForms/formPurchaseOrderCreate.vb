Imports System.Data
Imports System.Data.SqlClient
Imports System.Text
Imports System.Windows.Forms
Imports PurchaseOrderSystem.Controls

Public Class formPurchaseOrderCreate
    Dim _AppConn As SqlConnection = (New classConnection).getSQLConnection

    Dim oConfig As New clsConfig
    Dim clsConn As New classConnection
    Dim clsMaster As New classMaster
    Public loginEmpcd
    Public selectitdesc As String = ""
    Public selectitcd As String = ""
    Private connStr As New classConnection
    Dim ds As New DataSet
    Private dts As DataTable
    Private dt As DataTable
    Dim Qty As Double = 0
    Dim UnitPrice As Double = 0
    Dim DiscPerc As Double = 0
    Dim Discamt As Double = 0
    Dim VatAmt As Double = 0
    Dim sumGrossLineDiscAmt As Double = 0
    Dim sumGrossAmt As Double = 0
    Private m_import As Integer = 0
    Dim clsUser As New classUserInfo
    Dim ItcdAutoComplete As New AutoCompleteStringCollection
    Dim soAutoComplete As New AutoCompleteStringCollection
    Dim soLineIdAutoComplete As New AutoCompleteStringCollection

    Dim dtJob As New DataTable
    Dim bsJob As New BindingSource
    Dim drvJob As DataRowView

    Dim dtJobDet As New DataTable
    Dim bsJobDet As New BindingSource
    Dim drvJobDet As DataRowView


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

        ElseIf e.RowIndex = 0 AndAlso e.ColIndex = 2 Then
            e.Style.Font = New PurchaseOrderSystem.Controls.GridFontInfo(New Font("Segoe UI", 12, FontStyle.Bold, GraphicsUnit.Pixel))
            e.Style.Text = "Outside Process"
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

    Private Sub formPurchaseOrderCreate_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call InitControl()

        InitDataBindingJobDet("")
    End Sub
    Private Sub InitControl()
        ' -- Set Default 
        TabControl1.SelectedTab = TabPage2

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
        '---------
        GetDataMultiComboPOLineType()

        Me.comboEmp.SelectedValue = ""
        Me.cboDept.SelectedValue = ""
        Me.cbCredit.SelectedValue = ""
        Me.cbCredit.Text = ""

        Me.cboCurrency.SelectedValue = ""
        Me.CbSupplier.SelectedValue = ""

        Dim obj As Control
        For Each obj In Me.Controls
            Call SetControlValue(obj)
        Next
        Dim delidt2 As DataGridViewCalendarColumn
        delidt2 = delidt

        DtpPacking_date.Value = DateTimePicker.MinimumDateTime


        GetItcd()
        GetSoNo()
        GetSoNoId()
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
        rcv_warehouse_id.DisplayMember = "warehouse_code"
        rcv_warehouse_id.ValueMember = "mtl_warehouse_id"

    End Sub
    Private Sub GetcomboSubInventoryinGrid(ByVal Int64mtl_warehouse_id As Int64)
        Dim objdb As New classMaster
        rcv_subinventory_id.DataSource = objdb.GetCombomtl_subinventory(Int64mtl_warehouse_id)
        rcv_subinventory_id.DisplayMember = "subinventory_code"
        rcv_subinventory_id.ValueMember = "mtl_subinventory_id"

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

    Private Sub SetControlValue(ByVal Obj As Control)

        If TypeOf Obj Is DateTimePicker Then
            Dim dtp As DateTimePicker = Obj
            If dtp.Name = "delidt" Then
                dtp.CustomFormat = " "  'An empty SPACE
                dtp.Format = DateTimePickerFormat.Custom
                dtp.Value = "01/01/1900"
            ElseIf dtp.Name = "effective_date" Then
                dtp.CustomFormat = " "  'An empty SPACE
                dtp.Format = DateTimePickerFormat.Custom
                dtp.Value = CDate(Now)
            Else
                dtp.CustomFormat = " "  'An empty SPACE
                dtp.Format = DateTimePickerFormat.Custom
            End If

        End If

    End Sub

    Private Sub GetDataComboCurrency()
        Dim GetdataItems As New GetDataYarn
        Dim ds As DataSet
        ds = GetdataItems.GetDataCurrency
        Me.cboCurrency.DataSource = ds.Tables(0)
        Me.cboCurrency.DisplayMember = "currname"
        Me.cboCurrency.ValueMember = "curr"
        Me.cboCurrency.SelectedValue = "THB"
    End Sub

    Private Sub GetDataComboInDgridUnit()
        Dim GetdataItems As New GetDataYarn
        Dim dt As DataTable
        dt = GetdataItems.GetDataUnit
        Me.coluom.DataSource = dt
        Me.coluom.DisplayMember = "uom_name"
        Me.coluom.ValueMember = "uom"
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

    Private Sub GetDataComcoInDgridItems()
        Dim GetdataItems As New GetDataYarn
        Dim dt As DataTable
        'dt = GetdataItems.GetDataItem
        '  dt = GetdataItems.GetDataItemcode("", comboItemNature.SelectedValue.ToString.Trim.ToUpper)

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

        'dt = getDatayarn.GetEmpList()  'Comment By Sitthana 24/03/2018
        dt = getDatayarn.GetEmpComboList 'Sitthana 24/03/2018
        Me.comboEmp.DataSource = dt
        Me.comboEmp.DisplayMember = "empname"
        Me.comboEmp.ValueMember = "empcd"
    End Sub

    Private Sub GetDataComboDept()
        Dim getDatayarn As New GetDataYarn
        Dim dt As DataTable
        dt = getDatayarn.GetDeptList()
        Me.cboDept.DataSource = dt
        Me.cboDept.DisplayMember = "deptname"
        Me.cboDept.ValueMember = "deptcd"
    End Sub

    Private Sub AssignSupplierData()
        Dim GetdataAddr As New GetDataYarn
        Dim Obj_Supp As New tbl_Suppliers
        Dim msgerr As String = ""
        Dim Address As String

        If Me.CbSupplier.SelectedIndex = -1 Then
            MessageBox.Show("����ԡ���͡ Supplier ��ҹ�鹤�Ѻ", "��ͼԴ��Ҵ", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Exit Sub
        End If

        Obj_Supp = GetdataAddr.GetDataAddress(Me.CbSupplier.SelectedValue, msgerr)
        Address = Obj_Supp.addr1 & " " & Obj_Supp.addr2 & " " & Obj_Supp.addr3 & " " & Obj_Supp.addr1t & " " & Obj_Supp.addr2t & " " & Obj_Supp.addr3t & ", " & Obj_Supp.city & " " & Obj_Supp.ctry & " " & Obj_Supp.tel & " " & Obj_Supp.fax & " " & Obj_Supp.email & " " & Obj_Supp.contact
        Me.txtAddress.Text = Address
        Me.txtcredit.Text = Obj_Supp.crdays
        m_import = Obj_Supp.import
        Me.checkImport.CheckState = m_import
    End Sub
    Private Sub CbSupplier_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CbSupplier.SelectedIndexChanged
        AssignSupplierData()
    End Sub

    Private Sub CbSupplier_Validated(sender As Object, e As EventArgs) Handles CbSupplier.Validated
        AssignSupplierData()
    End Sub
    Private Sub DgYarn_CellBeginEdit(sender As Object, e As DataGridViewCellCancelEventArgs) Handles dgvJobDet.CellBeginEdit
        Dim clsConfig As New clsConfig
        Dim currRow As Integer
        Dim currCol As Integer
        currRow = e.RowIndex
        currCol = e.ColumnIndex

        If dgvJobDet.Columns(e.ColumnIndex).Name = "supquoteno" Then
            Dim selectedkono As String = ""

        End If

        'If DgYarn.CurrentCell.IsInEditMode Then
        '    Dim cell As DataGridViewCell = DgYarn.CurrentCell
        '    DgYarn.EndEdit(DataGridViewDataErrorContexts.Commit)

        'End If

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
                    dgvccSubInven.Value = foundRows(0)("mtl_subinventory_id")
                Catch ex As Exception
                    dgvccSubInven.Value = DBNull.Value
                End Try
            End If
        End If
        '------------------ End



        Dim currRow As Integer
        Dim currCol As Integer
        currRow = e.RowIndex
        currCol = e.ColumnIndex

        If UCase(dgvJobDet.Columns(currCol).Name) = "COLSONO" Then
            If oConfig.IsNull(dgvJobDet.Rows(currRow).Cells(currCol).Value, "") = "?" Then
                Dim selectedSO As String
                Dim formSearchSO As New formSearchSO
                selectedSO = formSearchSO.getSOno
                If selectedSO <> "" Then
                    dgvJobDet.Rows(currRow).Cells(currCol).Value = selectedSO
                End If

            End If
        Else
            ' validate s/o. if invalid, display error
        End If
        Call calc_final_totals()
    End Sub

    Private Sub DgYarn_CellValidated(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvJobDet.CellValidated
        Qty = 0
        UnitPrice = 0
        DiscPerc = 0
        Discamt = 0
        sumGrossLineDiscAmt = 0
        sumGrossAmt = 0

        ' Try
        Dim i As Integer

        For i = 0 To Me.dgvJobDet.Rows.Count - 2
            Qty = Me.dgvJobDet.Rows(i).Cells("colQty").Value
            UnitPrice = Me.dgvJobDet.Rows(i).Cells("colPrice").Value
            DiscPerc = dgvJobDet.Rows(i).Cells("colDiscper").Value
            Discamt = dgvJobDet.Rows(i).Cells("colDiscamt").Value
            If DiscPerc > 0 Then
                Discamt = ((Qty * UnitPrice) * DiscPerc) / 100
            End If
            Me.dgvJobDet.Rows(i).Cells("colDiscamt").Value = Discamt
            Me.dgvJobDet.Rows(i).Cells("colLineamt").Value = (Qty * UnitPrice) - Discamt '((Qty * UnitPrice) * DiscPerc) / 100
            sumGrossLineDiscAmt = sumGrossLineDiscAmt + Me.dgvJobDet.Rows(i).Cells("colDiscAmt").Value
            sumGrossAmt = sumGrossAmt + (Qty * UnitPrice)
        Next
        txtGrossLineDiscount.Text = String.Format("{0:#,###0.00}", sumGrossLineDiscAmt)  ' sumDiscAmt
        Me.txtGrossamount.Text = String.Format("{0:#,###0.00}", sumGrossAmt) 'sumGrossAmt
        Dim grossamount As Double
        Dim vat As Double
        vat = Me.txtVatPer.Text
        grossamount = Me.txtGrossamount.Text
        txtVatAmount.Text = String.Format("{0:#,###0.00}", (grossamount * vat) / 100) '(grossamount * vat) / 100

        Dim discountamount As Double
        Dim taxamount As Double
        VatAmt = Me.txtVatAmount.Text
        discountamount = Me.txtDiscountamount.Text
        Dim Argtotalamount As Double
        Argtotalamount = grossamount - (VatAmt + taxamount + txtVatAmount.Text + discountamount)
        Me.txtTotalAmount.Text = String.Format("{0:#,###0.00}", Argtotalamount)

        calc_final_totals()

    End Sub

    Private Sub BtnYarnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnYarnSave.Click
        Dim m_Msgerr As String = ""  'Sittana 20190705
        Dim ErrRunno As Integer = 0  'Sittana 20190705

        'Sitthana 17/10/2018
        If txtPurNo.Text.Trim <> "" Then
            MessageBox.Show("��¡�ù�������ҧ���º�������Ǥ�Ѻ �س���������ö�����" & vbCr _
                          & Space(5) & "��Ҥس����� ���������� Edit ��Ѻ" _
                          , "��ͤ�������͹", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        '  If Not CheckData() Then Exit Sub 'Add By Neung 20190701

        If oConfig.IsNull(txtTotalAmount.Text, 0) = 0 Then
            Call calc_final_totals_percent()
        End If


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
        errordept.SetError(Me.cboDept, "")

        Me.errorSaved.Clear()

        '-------------------------------------Start-----------------------------------------------------------'
        'If Not (clsUser.DeptCD = "PURCHASING" Or clsUser.DeptCD = "ITC" Or clsUser.DeptCD = "ACC") Then
        '    MessageBox.Show("�ô�Դ��ͽ��¨Ѵ���� : Please Contact Purchasing ", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        '    Exit Sub
        'End If
        '--------------------------------------End----------------------------------------------------------'
        '------------  job ---- -----------------------
        'Sitthana 17/09/2018
        'If Me.CbSupplier.SelectedIndex = -1 Then
        ' MessageBox.Show("����ԡ���͡ Supplier ��ҹ�鹤�Ѻ", "��ͼԴ��Ҵ", MessageBoxButtons.OK, MessageBoxIcon.Stop)
        ' Exit Sub
        ' End If

        ErrRunno = 0  'Sittana 20190705
        m_Msgerr = ""  'Sittana 20190705

        If cboCurrency.SelectedValue <> "THB" And oConfig.IsValidDouble(Me.txtrate.Text.Trim) = "1" Then
            errorCurrency.SetError(Me.txtrate, "���ʡ���Թ��ʡ���Թ��ҧ����� �÷�Թ��ͧ�������ҡѺ 1..")
            ' MessageBox.Show("���ʡ���Թ��ʡ���Թ��ҧ����� �÷�Թ��ͧ�������ҡѺ 1", "System Meassge", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
            m_Msgerr = "���ʡ���Թ��ʡ���Թ��ҧ����� �÷�Թ��ͧ�������ҡѺ 1.."
            m_HeaderHasErrors = True
        End If

        If Me.CbSupplier.SelectedValue = "" Then
            Me.errorSupplier.SetError(Me.CbSupplier, "Select a valid supplier")
            m_Msgerr &= vbCr & ErrRunno.ToString & ") Select a valid supplier"
            m_HeaderHasErrors = True
        End If

        Obj_tbl_job.suppcd = Me.CbSupplier.SelectedValue
        Obj_tbl_job.jobdt = Me.DateYIN.Value.ToString("yyy/MM/dd")

        Obj_tbl_job.supquoteno = Me.textSupQuoteno.Text.Trim
        Obj_tbl_job.reqno = Me.textReqno.Text

        Dim SDate As Date
        Dim LDate As Date
        SDate = Today.Date
        LDate = Me.DtPayDate.Value
        Obj_tbl_job.delidays = DateDiff(DateInterval.Day, SDate, LDate) 'Me.DtPayDate.Value
        Obj_tbl_job.delidt = Me.DtDileveryDate.Value.ToString("yyyy/MM/dd") 'As DateTime

        Obj_tbl_job.crterm = Me.cbCredit.Text
        Obj_tbl_job.crdays = Val(Me.txtcredit.Text.Trim)

        If oConfig.IsNull(Me.comboEmp.SelectedValue, "") = "" Then
            ErrRunno += 1
            errorEmp.SetError(Me.comboEmp, "Please select the person who made the request.")
            m_Msgerr &= vbCr & ErrRunno.ToString & " Please select the person who made the request."
            m_HeaderHasErrors = True
        End If

        If oConfig.IsNull(Me.cboCurrency.SelectedValue, "") = "" Then 'As String
            ErrRunno += 1
            errorCurrency.SetError(Me.cboCurrency, "Select currency..")
            m_Msgerr &= vbCrLf & ErrRunno.ToString & " Select currency.."
            m_HeaderHasErrors = True
        End If
        If oConfig.IsNull(Me.cboDept.SelectedValue, "") = "" Then 'As String
            ErrRunno += 1
            errordept.SetError(Me.cboDept, "Select Dept..")
            m_Msgerr &= vbCrLf & ErrRunno.ToString & " Select Dept.."
            m_HeaderHasErrors = True
        End If

        If oConfig.IsNull(Me.mcboPoLineType.SelectedValue, 0) = 0 Then
            ErrRunno += 1
            ErrormcboPoLineType.SetError(Me.mcboPoLineType, "Select Line Type")
            m_Msgerr &= vbCrLf & ErrRunno.ToString & " Select Line Type."
            m_HeaderHasErrors = True
        End If

        Obj_tbl_job.Empcd = Me.comboEmp.SelectedValue
        Obj_tbl_job.Deptcd = Me.cboDept.SelectedValue
        Obj_tbl_job.jobtype = "PURCHASE"
        Obj_tbl_job.splins = Me.txtpackcd.Text.Trim 'As String
        Obj_tbl_job.remark = Me.txtremark.Text.Trim 'As String
        Obj_tbl_job.import = m_import 'As Boolean
        Obj_tbl_job.curr = Me.cboCurrency.SelectedValue 'As String
        Obj_tbl_job.exrt = oConfig.IsValidDouble(Me.txtrate.Text.Trim)         'As Double
        'End If

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
        Obj_tbl_job.shipvia = (Me.txtShipvia.Text) 'As Double
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

        Obj_tbl_job.packing_date = IIf(DtpPacking_date.Checked, DtpPacking_date.Value, Nothing)
        Obj_tbl_job.invoice_date = IIf(DtpInvoice_date.Checked, DtpInvoice_date.Value, Nothing)
        Obj_tbl_job.bl_date = IIf(DtpBL_date.Checked, DtpBL_date.Value, Nothing)
        Obj_tbl_job.awb_no = oConfig.IsNull(txtAWB_no.Text, Nothing)
        Obj_tbl_job.awb_date = IIf(DtpAWB_date.Checked, DtpAWB_date.Value, Nothing)
        Obj_tbl_job.awb_received_date = IIf(DtpAWB_Received_date.Checked, DtpAWB_Received_date.Value, Nothing)
        Obj_tbl_job.sell_back_to_vendor = IIf(chksell_back_to_vendor.Checked, chksell_back_to_vendor.Checked, Nothing)

        '-------------- job_det -------------------------------

        Dim i As Integer
        Dim Lineamt As Integer

        '------------- Check Items Code -----------------------


        For i = 0 To Me.dgvJobDet.Rows.Count - 2
            Qty = Me.dgvJobDet.Rows(i).Cells("colQty").Value
            UnitPrice = Me.dgvJobDet.Rows(i).Cells("colPrice").Value
            DiscPerc = dgvJobDet.Rows(i).Cells("colDiscper").Value
            Lineamt = Me.dgvJobDet.Rows(i).Cells("colLineamt").Value

            If Not Validate_Items(StrItcd:=Me.dgvJobDet.Rows(i).Cells("colItcd").Value) Then
                ErrRunno += 1
                m_errmess.Append("Item code InCorrect")
                m_Msgerr &= vbCrLf & ErrRunno.ToString & "Item code InCorrect"
                m_GridHasErrors = True
            End If


            If oConfig.IsNull(Me.dgvJobDet.Rows(i).Cells("colUom").Value, "").ToString = "" Then
                ErrRunno += 1
                m_errmess.Append(",Unit")
                m_Msgerr &= vbCrLf & ErrRunno.ToString & ",Unit"
                m_GridHasErrors = True
            End If

            If oConfig.IsNull(Me.dgvJobDet.Rows(i).Cells("rcv_warehouse_id").Value, 0) = 0 Then
                ErrRunno += 1
                m_errmess.Append("��ͧ�� WareHouse")
                m_Msgerr &= vbCrLf & ErrRunno.ToString & " ,Warehouse"
                m_GridHasErrors = True
            End If

            If oConfig.IsNull(Me.dgvJobDet.Rows(i).Cells("colItcd").Value, "").ToString.Substring(0, 3) = "YRA" And
                oConfig.IsNull(Me.dgvJobDet.Rows(i).Cells("rcv_subinventory_id").Value, 0) = 0 Then
                ErrRunno += 1
                m_errmess.Append("��ͧ�� SubInventory �ء���駷���ա�ë��� Bobbin YRA")
                m_Msgerr &= vbCrLf & ErrRunno.ToString & " ��ͧ�� SubInventory �ء���駷���ա�ë��� Bobbin YRA"
                m_GridHasErrors = True
            End If

            'Procurement can buy something for free Edit By Neung 25/12/2014

            'If clsConfig.IsNull(Me.DgYarn.Rows(i).Cells("colPrice").Value, 0).ToString = 0 Then
            '    m_errmess.Append(",Price")
            '    m_GridHasErrors = True
            'End If
            'If clsConfig.IsNull(Me.DgYarn.Rows(i).Cells("colQty").Value, 0) = 0 Then
            '    m_errmess.Append(",Qty")
            '    m_GridHasErrors = True
            'End If

            'Procurement can buy something for free Edit By Neung 25/12/2014

            If m_GridHasErrors Then
                errorItemGrid.SetError(Me.dgvJobDet, m_errmess.ToString)
                MsgBox(m_Msgerr.ToString, MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Data incomplete")
                Exit Sub
            End If

            ReDim Preserve Obj_tbl_job.tbl_job_det(i)
            Obj_tbl_job.tbl_job_det(i) = New tbl_job_det
            Obj_tbl_job.tbl_job_det(i).supquoteno = oConfig.IsNull(Me.dgvJobDet.Rows(i).Cells("supquoteno").Value, "").ToString 'K/O No.
            Obj_tbl_job.tbl_job_det(i).itcd = oConfig.IsNull(Me.dgvJobDet.Rows(i).Cells("colItcd").Value, "").ToString
            Obj_tbl_job.tbl_job_det(i).itdesc = oConfig.IsNull(Me.dgvJobDet.Rows(i).Cells("colMoreDesc").Value, "").ToString
            Obj_tbl_job.tbl_job_det(i).qty = oConfig.IsValidDouble(Me.dgvJobDet.Rows(i).Cells("colQty").Value.ToString)
            Obj_tbl_job.tbl_job_det(i).uom = oConfig.IsNull(Me.dgvJobDet.Rows(i).Cells("colUom").Value, "").ToString
            Obj_tbl_job.tbl_job_det(i).price = oConfig.IsValidDouble(Me.dgvJobDet.Rows(i).Cells("colprice").Value.ToString) ' As Double
            Obj_tbl_job.tbl_job_det(i).curr = Obj_tbl_job.curr    'As String
            Obj_tbl_job.tbl_job_det(i).exrt = Obj_tbl_job.exrt  'As Double
            Obj_tbl_job.tbl_job_det(i).discper = oConfig.IsValidDouble(Me.dgvJobDet.Rows(i).Cells("coldiscper").Value.ToString) 'As Double
            Obj_tbl_job.tbl_job_det(i).discamt = oConfig.IsValidDouble(Me.dgvJobDet.Rows(i).Cells("coldiscamt").Value.ToString)    'As Double
            Obj_tbl_job.tbl_job_det(i).lineamt = Lineamt
            'Obj_tbl_job.tbl_job_det(i).delidt = Obj_tbl_job.delidt	'As DateTime
            'Add By Neung 05/03/2015
            Obj_tbl_job.tbl_job_det(i).delidt = Me.DtDileveryDate.Value
            'Obj_tbl_job.tbl_job_det(i).delidt = clsConfig.IsNull(Me.DgYarn.Rows(i).Cells("delidt").Value, CDate("01/01/1900"))
            Obj_tbl_job.tbl_job_det(i).remark = oConfig.IsNull(Me.dgvJobDet.Rows(i).Cells("colRemark").Value, "").ToString
            Obj_tbl_job.tbl_job_det(i).closed = 0 ' As bit
            Obj_tbl_job.tbl_job_det(i).sono = oConfig.IsNull(Me.dgvJobDet.Rows(i).Cells("colSono").Value, "").ToString
            Obj_tbl_job.tbl_job_det(i).sonoid = oConfig.IsNull(Me.dgvJobDet.Rows(i).Cells("colSoNoId").Value, "").ToString
            Obj_tbl_job.tbl_job_det(i).suppitcd = oConfig.IsNull(Me.dgvJobDet.Rows(i).Cells("colSuppitcd").Value, "").ToString
            Obj_tbl_job.tbl_job_det(i).item_unit_price = oConfig.IsNull(Me.dgvJobDet.Rows(i).Cells("colitem_unit_price").Value, 0).ToString 'New
            Obj_tbl_job.tbl_job_det(i).freight_per_unit = oConfig.IsNull(Me.dgvJobDet.Rows(i).Cells("colfreight_per_unit").Value, 0).ToString 'New
            Obj_tbl_job.tbl_job_det(i).effective_date = oConfig.IsNull(Me.dgvJobDet.Rows(i).Cells("effective_date").Value, CDate(Now)) 'As Datetime - Now
            '--- Copy From Eschler Sitthana 20190309
            Obj_tbl_job.tbl_job_det(i).rcv_warehouse_id = oConfig.IsNull(Me.dgvJobDet.Rows(i).Cells("rcv_warehouse_id").Value, Nothing)
            Obj_tbl_job.tbl_job_det(i).rcv_subinventory_id = oConfig.IsNull(Me.dgvJobDet.Rows(i).Cells("rcv_subinventory_id").Value, Nothing)
            Obj_tbl_job.tbl_job_det(i).POLineTypesID = (oConfig).IsNull(mcboPoLineType.SelectedValue, Nothing)
            '--- End Copy From Eschler Sitthana 20190309
        Next

        If m_GridHasErrors Or m_HeaderHasErrors Then 'Double Check
            'm_Msgerr
            MsgBox(m_Msgerr, MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Data incomplete")
            ' MsgBox("Some required values are missing, please check..", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Data incomplete")
            Exit Sub
        End If

        Isvalid = classPurchase.InsertPurchaseOrder(Obj_tbl_job, purno, msgerr, Me.loginEmpcd)

        If Isvalid = True Then
            Me.txtPurNo.Text = Obj_tbl_job.jobno

            MsgBox("P/O updated successfully", MsgBoxStyle.Information)
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

        If cboCurrency.SelectedValue <> "THB" And oConfig.IsValidDouble(Me.txtrate.Text.Trim) = "1" Then
            MessageBox.Show("���ʡ���Թ��ʡ���Թ��ҧ����� �÷�Թ��ͧ�������ҡѺ 1", "System Meassge", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
            errorCurrency.SetError(Me.txtrate, "���ʡ���Թ��ʡ���Թ��ҧ����� �÷�Թ��ͧ�������ҡѺ 1..")
            result = False
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

    Private Sub DgYarn_DefaultValuesNeeded(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewRowEventArgs) Handles dgvJobDet.DefaultValuesNeeded
        e.Row.Cells("colUom").Value = "KGS"
        e.Row.Cells("colQty").Value = 0
        e.Row.Cells("colPrice").Value = 0
        e.Row.Cells("colDiscper").Value = 0
        e.Row.Cells("colDiscamt").Value = 0
        e.Row.Cells("collineamt").Value = 0
        e.Row.Cells("colMoredesc").Value = ""
        e.Row.Cells("colRemark").Value = ""
        e.Row.Cells("colSuppitcd").Value = ""
        e.Row.Cells("colSono").Value = ""
        e.Row.Cells("colitem_unit_price").Value = 0
        e.Row.Cells("colfreight_per_unit").Value = 0
        'e.Row.Cells("rcv_subinventory_id").Value = 4

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
        'Try
        '    ds.Tables("v_editJoboOrderForYarnEdit").Clear()
        '    chkErrbutUse = True
        'Catch ex As Exception
        '    chkErrbutUse = False
        '    Exit Function
        'End Try
    End Function
    Private Function chkErrbutUse2(ByVal strmsg As String) As Boolean
        'Dim strtempA As String = ""
        'Try
        '    strtempA = ds.Tables("v_editJoboOrderForYarnEdit").Rows(0).Item("itcd").ToString
        '    chkErrbutUse2 = True
        'Catch ex As Exception
        '    chkErrbutUse2 = False
        '    Exit Function
        'End Try
    End Function

    Private Sub calc_final_totals()
        Dim m_CurrExchangeRate As Double = 1 'Edit By Neung 2016/03/01
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

        m_CurrExchangeRate = Val(IIf(IsNumeric(txtrate.Text), txtrate.Text, 0)) 'Enable By Neung 2016/03/01
        m_CurrExchangeRate = IIf(m_CurrExchangeRate <= 0, 1, m_CurrExchangeRate) 'Enable By Neung 2016/03/01

        m_GrossLineAmt = sumGrossAmt '* m_CurrExchangeRate
        m_GrossLineDisc = sumGrossLineDiscAmt '* m_CurrExchangeRate
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
        ' m_OrderDiscPer = (m_OrderDiscAmt / m_NetLineAmt) * 100
        m_OrderDiscAmt = Val(txtDiscountamount.Text)

        m_NetOrderAmt = m_NetLineAmt - m_OrderDiscAmt
        m_VATPer = Val(IIf(IsNumeric(txtVatPer.Text), txtVatPer.Text, 0))

        If m_VATPer = 0 Then
            m_VATPer = Math.Round((m_VATAmt / m_NetOrderAmt) * 100, 2)
        ElseIf m_VATPer > 0 Then
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
        txtVatPer.Text = FormatNumber(m_VATPer, 2, TriState.False, TriState.False, TriState.True)
        txtVatAmount.Text = FormatNumber(m_VATAmt, 2, TriState.False, TriState.False, TriState.True)
        txtTotalAmount.Text = FormatNumber(m_NetOrderAmtAfterVAT, 2, TriState.False, TriState.False, TriState.True)
        If txtrate.Text = 0.0 Then
            txtrate.Text = 0.0
        End If
        If txtGrossamount.Text = "NaN" Then
            txtGrossamount.Text = 0.0
        End If
        If txtGrossLineDiscount.Text = "NaN" Then
            txtGrossLineDiscount.Text = 0.0
        End If
        If txtNetLineAmount.Text = "NaN" Then
            txtNetLineAmount.Text = 0.0
        End If
        If txtDiscper.Text = "NaN" Then
            txtDiscper.Text = 0.0
        End If
        If txtDiscountamount.Text = "NaN" Then
            txtDiscountamount.Text = 0.0
        End If
        If txtNetOrderAmount.Text = "NaN" Then
            txtNetOrderAmount.Text = 0.0
        End If
        If txtVatPer.Text = "NaN" Then
            txtVatPer.Text = 0.0
        End If
        If txtVatAmount.Text = "NaN" Then
            txtVatAmount.Text = 0.0
        End If
        If txtTotalAmount.Text = "NaN" Then
            txtTotalAmount.Text = 0.0
        End If
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

        ''(C)amount arrived after deducting vat discount from above (B)
        'm_vatamt = m_AfterAllDisc * m_vatper / 100
        'm_AfterVat = m_AfterAllDisc + m_vatamt

        ''(D)amount arrived after deducting vat (C) is the net amount
        'm_netTotalAmt = m_AfterVat

        ''put the arrived totals in the respective textboxes.
        'Me.txtGrossamount.Text = String.Format("{0:#,###0.00}", m_grossAmt)
        'Me.txtDiscountamount.Text = String.Format("{0:#,###0.00}", m_lineDiscAmt + m_finalDiscAmt)
        'Me.txtVatAmount.Text = String.Format("{0:#,###0.00}", m_vatamt)
        'Me.txtDiscountamount.Text = String.Format("{0:#,###0.00}", m_lineDiscAmt + m_finalDiscAmt)
        'Me.txtTotalAmount.Text = String.Format("{0:#,###0.00}", m_AfterVat)
    End Sub

    Private Sub sumLineTotals()
        Qty = 0
        UnitPrice = 0
        DiscPerc = 0
        sumGrossLineDiscAmt = 0
        sumGrossAmt = 0

        Try
            Dim i As Integer

            For i = 0 To Me.dgvJobDet.Rows.Count - 2
                If Me.dgvJobDet.Rows(i).Cells("colQty").Value = Nothing Then
                    Me.dgvJobDet.Rows(i).Cells("colqty").Value = 0
                End If

                If Me.dgvJobDet.Rows(i).Cells("colPrice").Value = Nothing Then
                    Me.dgvJobDet.Rows(i).Cells("colPrice").Value = 0
                End If

                If Me.dgvJobDet.Rows(i).Cells("colDiscper").Value = Nothing Then
                    Me.dgvJobDet.Rows(i).Cells("colDiscper").Value = 0
                End If

                If Me.dgvJobDet.Rows(i).Cells("colDiscamt").Value = Nothing Then
                    Me.dgvJobDet.Rows(i).Cells("coldiscamt").Value = 0
                End If

                Qty = Me.dgvJobDet.Rows(i).Cells("colQty").Value
                UnitPrice = Me.dgvJobDet.Rows(i).Cells("colPrice").Value
                DiscPerc = dgvJobDet.Rows(i).Cells("colDiscper").Value
                Discamt = Me.dgvJobDet.Rows(i).Cells("colDiscamt").Value

                If DiscPerc > 0 Then
                    Discamt = ((Qty * UnitPrice) * DiscPerc) / 100
                Else
                    If Discamt > 0 Then
                        DiscPerc = (Discamt * 100) / (Qty * UnitPrice)
                        dgvJobDet.Rows(i).Cells("colDiscper").Value = DiscPerc
                    End If 'Sitthana 20240605
                End If

                Me.dgvJobDet.Rows(i).Cells("colDiscamt").Value = Discamt

                Me.dgvJobDet.Rows(i).Cells("colLineamt").Value = (Qty * UnitPrice) - Discamt ' ((Qty * UnitPrice) * DiscPerc) / 100
                sumGrossLineDiscAmt = sumGrossLineDiscAmt + Me.dgvJobDet.Rows(i).Cells("colDiscAmt").Value
                sumGrossAmt = sumGrossAmt + (Qty * UnitPrice)
            Next
            txtGrossLineDiscount.Text = String.Format("{0:#,###0.00}", sumGrossLineDiscAmt)  ' sumDiscAmt
            ' Me.txtDiscountamount.Text = String.Format("{0:#,###0.00}", sumGrossDiscAmt)  ' sumDiscAmt
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
            discountamount = sumGrossLineDiscAmt
            Dim Argtotalamount As Double
            Argtotalamount = grossamount - (VatAmt + taxamount + txtVatAmount.Text + discountamount)
            Me.txtTotalAmount.Text = String.Format("{0:#,###0.00}", Argtotalamount)

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub BtnYarnPrintDoc_Click(sender As System.Object, e As System.EventArgs) Handles BtnYarnPrintDoc.Click
        Dim frm As New frmReport
        Dim rpt As New CrystalDecisions.CrystalReports.Engine.ReportDocument
        Dim rptFileName As String
        Dim jobno As String = ""
        Dim docno As String = txtPurNo.Text.Trim

        If docno = "" Then

            rptFileName = "RptPurchaseOrderCreate.rpt"
            ' If clsUser.ReportPath = "" Then clsUser.ReportPath = clsConfig.ReportPath
            If Not oConfig.CheckReport(clsUser.ReportPath, rptFileName) Then Exit Sub
            rpt.Load(clsUser.ReportPath & rptFileName)
            rpt.DataSourceConnections.Item(0).SetConnection(clsConn.servername, clsConn.database, False)
            rpt.DataSourceConnections.Item(0).SetLogon(clsConn.Userid, clsConn.Password)
            rpt.VerifyDatabase()
            rpt.SetParameterValue("@jobno", docno)

        Else
            rptFileName = "RptPurchaseOrderCreate.rpt"
            ' If clsUser.ReportPath = "" Then clsUser.ReportPath = clsConfig.ReportPath
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

    Private Function PrintReport(ByVal ds As DataSet) As Boolean
        Dim clsConn As New classConnection()
        Const rptFileName = "RptPurchaseOrderCreate.rpt"
        If Not oConfig.CheckReport(clsUser.ReportPath, rptFileName) Then Return False
        Dim frm As New frmReport
        Dim rpt As New CrystalDecisions.CrystalReports.Engine.ReportDocument
        Me.Cursor = Cursors.WaitCursor

        rpt.Load(clsUser.ReportPath & rptFileName)
        rpt.DataSourceConnections.Item(0).SetConnection(clsConn.servername, clsConn.database, False)
        rpt.DataSourceConnections.Item(0).SetLogon(clsConn.Userid, clsConn.Password)
        rpt.SetDataSource(ds.Tables("Tblprint"))

        'rpt.PrintOptions.PaperSize = CrystalDecisions.Shared.PaperSize.PaperA4
        'rpt.PrintOptions.PaperOrientation = CrystalDecisions.Shared.PaperOrientation.Portrait
        'rpt.PrintOptions.PaperSource = CrystalDecisions.Shared.PaperSource.Auto

        frm.Title = "Purchase Order"
        frm.CRViewer.ReportSource = rpt
        frm.MdiParent = Me.ParentForm
        frm.Show()
        Me.Cursor = Cursors.Default
        Return True
    End Function

    Private Sub cbCredit_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbCredit.SelectedIndexChanged
        Dim K As String
        K = Me.cbCredit.Text
    End Sub

    Private Sub DgYarn_DataError(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewDataErrorEventArgs) Handles dgvJobDet.DataError
        Dim m_rowIndex As Integer
        m_rowIndex = e.RowIndex
        e.Cancel = True
        Me.dgvJobDet.Rows(m_rowIndex).Cells("colItcd").Value = ""
    End Sub

    Private Sub txtrate_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtrate.LostFocus
        calc_final_totals()
        Call txtDiscper.Focus()
    End Sub

    Private Sub txtDiscper_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles txtDiscper.KeyDown
        Dim clsconfig As New clsConfig
        If e.KeyCode = Keys.Enter Then
            txtDiscountamount.Text = "0"
            If clsconfig.IsNull(txtDiscountamount.Text, 0) = 0 Then
                calc_final_totals_percent()
            End If
        End If
    End Sub

    Private Sub txtDisper_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtDiscper.LostFocus
        txtDiscountamount.Text = ""
        Dim clsconfig As New clsConfig
        If clsconfig.IsNull(txtDiscountamount.Text, 0) = 0 Then
            calc_final_totals_percent()
        End If
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

    Private Sub txtVatPer_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles txtVatPer.KeyDown
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
        m_GrossLineAmt = sumGrossAmt '* m_CurrExchangeRate 'Disble By Neung
        m_GrossLineDisc = sumGrossLineDiscAmt '* m_CurrExchangeRate 'Disble By Neung
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

        If oConfig.IsNull(txtDiscountamount.Text, 0) = 0 Then

        End If

        m_NetOrderAmt = m_NetLineAmt - m_OrderDiscAmt
        m_VATPer = Val(IIf(IsNumeric(txtVatPer.Text), txtVatPer.Text, 0))

        If m_VATPer = 0 Then
            If m_NetOrderAmt <> 0 Then
                m_VATPer = oConfig.IsValidDouble((Math.Round((m_VATAmt / m_NetOrderAmt) * 100, 2, MidpointRounding.AwayFromZero)))
            Else
                m_VATPer = 0
            End If
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
        txtVatPer.Text = FormatNumber(m_VATPer, 2, TriState.False, TriState.False, TriState.True)
        txtVatAmount.Text = FormatNumber(m_VATAmt, 2, TriState.False, TriState.False, TriState.True)
        txtTotalAmount.Text = FormatNumber(m_NetOrderAmtAfterVAT, 2, TriState.False, TriState.False, TriState.True)


    End Sub

    Private Sub sumLineTotals_dispercent()
        Qty = 0
        UnitPrice = 0
        DiscPerc = 0
        sumGrossLineDiscAmt = 0
        sumGrossAmt = 0

        Try
            Dim i As Integer

            For i = 0 To Me.dgvJobDet.Rows.Count - 2
                Me.dgvJobDet.Rows(i).Cells("colQty").Value = oConfig.IsNull(Me.dgvJobDet.Rows(i).Cells("colQty").Value, 0)
                Me.dgvJobDet.Rows(i).Cells("colPrice").Value = oConfig.IsNull(Me.dgvJobDet.Rows(i).Cells("colPrice").Value, 0)
                Me.dgvJobDet.Rows(i).Cells("colDiscper").Value = oConfig.IsNull(Me.dgvJobDet.Rows(i).Cells("colDiscper").Value, 0)
                Me.dgvJobDet.Rows(i).Cells("colDiscamt").Value = oConfig.IsNull(Me.dgvJobDet.Rows(i).Cells("colDiscamt").Value, 0)

                Qty = Me.dgvJobDet.Rows(i).Cells("colQty").Value
                UnitPrice = Me.dgvJobDet.Rows(i).Cells("colPrice").Value
                DiscPerc = dgvJobDet.Rows(i).Cells("colDiscper").Value
                Discamt = Me.dgvJobDet.Rows(i).Cells("colDiscamt").Value

                If DiscPerc > 0 Then
                    Discamt = ((Qty * UnitPrice) * DiscPerc) / 100
                End If

                Me.dgvJobDet.Rows(i).Cells("colDiscamt").Value = Discamt

                Me.dgvJobDet.Rows(i).Cells("colLineamt").Value = (Qty * UnitPrice) - Discamt '((Qty * UnitPrice) * DiscPerc) / 100
                sumGrossLineDiscAmt = sumGrossLineDiscAmt + Me.dgvJobDet.Rows(i).Cells("colDiscAmt").Value
                sumGrossAmt = sumGrossAmt + (Qty * UnitPrice)
            Next

            txtGrossLineDiscount.Text = String.Format("{0:#,###0.00}", sumGrossLineDiscAmt)
            'Me.txtDiscountamount.Text = String.Format("{0:#,###0.00}", sumGrossDiscAmt)  ' sumDiscAmt
            Me.txtGrossamount.Text = String.Format("{0:#,###0.00}", sumGrossAmt) 'sumGrossAmt
            Dim grossamount As Double
            Dim vat As Double
            vat = Val(Me.txtVatPer.Text)
            grossamount = sumGrossAmt
            txtVatAmount.Text = String.Format("{0:#,###0.00}", (grossamount * vat) / 100) '(grossamount * vat) / 100

            Dim discountamount As Double
            Dim taxamount As Double
            VatAmt = (grossamount * vat) / 100
            discountamount = sumGrossLineDiscAmt
            Dim Argtotalamount As Double
            Argtotalamount = grossamount - (VatAmt + taxamount + txtVatAmount.Text + discountamount)
            Me.txtTotalAmount.Text = String.Format("{0:#,###0.00}", Argtotalamount)

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles btnPrintTH.Click
        Dim frm As New frmReport
        Dim rpt As New CrystalDecisions.CrystalReports.Engine.ReportDocument
        Dim rptFileName As String
        Dim jobno As String = ""
        Dim docno As String = txtPurNo.Text.Trim

        If docno = "" Then

            rptFileName = "RptPurchaseOrderCreateTH.rpt"
            '  If clsUser.ReportPath = "" Then clsUser.ReportPath = clsConfig.ReportPath
            If Not oConfig.CheckReport(clsUser.ReportPath, rptFileName) Then Exit Sub
            rpt.Load(clsUser.ReportPath & rptFileName)
            rpt.DataSourceConnections.Item(0).SetConnection(clsConn.servername, clsConn.database, False)
            rpt.DataSourceConnections.Item(0).SetLogon(clsConn.Userid, clsConn.Password)
            rpt.VerifyDatabase()
            rpt.SetParameterValue("@jobno", docno)

        Else
            rptFileName = "RptPurchaseOrderCreateTH.rpt"
            '  If clsUser.ReportPath = "" Then clsUser.ReportPath = clsConfig.ReportPath
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

    Private Sub txtrate_TextChanged(sender As Object, e As EventArgs) Handles txtrate.TextChanged

    End Sub

    Private Sub txtVatPer_TextChanged(sender As Object, e As EventArgs) Handles txtVatPer.TextChanged

    End Sub

    Private Sub DgYarn_EditingControlShowing(sender As Object, e As DataGridViewEditingControlShowingEventArgs) Handles dgvJobDet.EditingControlShowing
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
    Private Sub LoadRate()
        If cboCurrency Is Nothing Then Exit Sub
        If cboCurrency.DataSource Is Nothing Then Exit Sub

        Dim currText As String = cboCurrency.Text.Trim()
        Dim currValue As String = ""

        ' �ѹ SelectedValue �ѧ�������
        If cboCurrency.SelectedValue IsNot Nothing Then
            currValue = cboCurrency.SelectedValue.ToString().Trim()
        End If

        ' �� value ��͹ �����ҧ������ text
        Dim curr As String = If(currValue <> "", currValue, currText).ToUpper()

        If curr = "THB" Then
            txtrate.Text = FormatNumber(1, 4) ' �� 1.0000
            lblExechageDate.Text = ""
            Exit Sub
        End If

        lblExechageDate.Text = "( " & DateYIN.Text.Trim & " )"

        Dim dt As DataTable = clsMaster.getExchangeRateByDateCurr(
        Format(DateYIN.Value, "yyyyMMdd"),
        curr
    )

        If dt IsNot Nothing AndAlso dt.Rows.Count > 0 AndAlso Not IsDBNull(dt.Rows(0)("exchange_rate")) Then
            txtrate.Text = FormatNumber(CDec(dt.Rows(0)("exchange_rate")), 4)
        Else
            txtrate.Text = ""
            lblExechageDate.Text = ""
        End If
    End Sub

    Private Sub cboCurrency_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboCurrency.SelectedIndexChanged
        LoadRate()
        'If Not IsDBNull(cboCurrency.DataSource) And cboCurrency.ValueMember = "curr" Then
        '    If cboCurrency.SelectedValue = "THB" Then
        '        txtrate.Text = FormatNumber("1.00", 4)
        '        lblExechageDate.Text = ""
        '    Else
        '        Dim dt As New DataTable

        '        lblExechageDate.Text = "( " & DateYIN.Text.Trim & " )"
        '        dt = clsMaster.getExchangeRateByDateCurr(Format(DateYIN.Value, "yyyyMMdd"), cboCurrency.Text.Trim)
        '        If dt.Rows.Count > 0 Then
        '            txtrate.Text = dt.Rows(0)("exchange_rate")
        '        Else
        '            txtrate.Text = ""
        '            lblExechageDate.Text = ""
        '        End If 'Sitthana 20201001
        '    End If
        'End If
    End Sub
    Private Sub cboCurrency_TextChanged(sender As Object, e As EventArgs) Handles cboCurrency.TextChanged
        LoadRate()
    End Sub

    Private Sub cboCurrency_Validated(sender As Object, e As EventArgs) Handles cboCurrency.Validated
        LoadRate()
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
                            ' drvJobDet.Row("itcd") = DBNull.Value
                            ' drvJobDet.Row("itdesc") = DBNull.Value
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
                '                ' drvJobDet.Row("itcd") = DBNull.Value
                '                '  drvJobDet.Row("itdesc") = DBNull.Value
                '                ' drvJobDet.Row("qty") = DBNull.Value
                '                '  drvJobDet.Row("uom") = DBNull.Value
                '                drvJobDet.Row.EndEdit()
                '                bsJobDet.EndEdit()
                '                dgvJobDet.RefreshEdit()
                '            End If
                '        End If
                '    End If
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
                ' drvJobDet.Row("itcd") = oConfig.IsNull(frmLov.pdrvSearchTable.Row("itcd"), DBNull.Value)
                '  drvJobDet.Row("itdesc") = oConfig.IsNull(frmLov.pdrvSearchTable.Row("itdesc"), DBNull.Value)
                '  drvJobDet.Row("qty") = oConfig.IsNull(frmLov.pdrvSearchTable.Row("qty"), DBNull.Value)
                '  drvJobDet.Row("uom") = oConfig.IsNull(frmLov.pdrvSearchTable.Row("uom"), DBNull.Value)
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
    End Sub
End Class