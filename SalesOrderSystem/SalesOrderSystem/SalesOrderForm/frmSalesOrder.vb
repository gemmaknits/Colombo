Imports System.Drawing
Imports System.Data.SqlClient
Imports System.Windows.Forms
Imports SalesOrderSystem.Controls
Imports System.Text.RegularExpressions
Imports System.Linq
Imports System.Globalization

Public Class frmSalesOrder
    Dim oConfig As New clsConfig
    Dim clsConn As New classConnection
    Dim clsUser As New classUserInfo
    Dim objSecurity As New clsConfig
    Private clsMaster As New classMaster

    Dim strSoNo As String = ""
    Dim blnCancel As Boolean = False
    Dim CustomerComboDone As Boolean = False
    Dim DeliveryComboDone As Boolean = False
    Dim SonoComboDone As Boolean = False

    'Begin Copy From Gemmaknits Sitthana 23/04/2018
    Dim currentGridDesignNo As String
    Dim currentGridColorCode As String
    Dim currentGridQty As Decimal
    Dim currentGridUom As String
    Dim currentGridSono As String
    Dim currentGridSonoID As String
    Dim currentGridSoLineID As Integer

    Dim dtFulfilmentType As DataTable
    Dim fulfilmentTypeCode As String

    Dim dtCustomersBillToFlag As New DataTable
    Dim bsCustomersBillToFlag As New BindingSource

    Dim dtDesignProperties As New DataTable
    Dim bsDesignProperties As New BindingSource

    Dim dtCustomersShipToFlag As New DataTable
    Dim bsCustomersShipToFlag As New BindingSource
    'End  Copy From Gemmaknits Sitthana 23/04/2018

    Private HadRight As Boolean = False 'Sitthana 20190624
    Private CaseCopy As Boolean = False 'Sitthana 20190624

    Dim oGridLayoutSettings As New classGridLayoutSettings
    Public pGridName As String
    Private dtGridLayoutSettings As New DataTable
    Private bsGridLayoutSettings As New BindingSource
    Private drvGridLayoutSettings As DataRowView
    Private autoSave As String

    Public Property UserInfo() As classUserInfo
        Get
            UserInfo = clsUser
        End Get
        Set(ByVal NewValue As classUserInfo)
            clsUser = NewValue
        End Set
    End Property

    ''Constant Value
    Private Const btnDesignFileColName As String = "btnDesignFile"
    Private Const btnDesignFileTextName As String = "File"
    Private Const SRType As String = "SR_TYPE"
    Private Const SRSentTo As String = "SR_SENT_TO"


    Private Sub SetControlValue(ByVal Obj As Control)

        If TypeOf Obj Is TextBox Then
            If Obj.Tag = "str" Then Obj.Text = ""
            If Obj.Tag = "int" Then Obj.Text = "0.00"
            'If Obj.Tag = "" Then Obj.Text = ""
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
                cbo.SelectedValue = vbNull
            End If
        End If
        If TypeOf Obj Is MultiColumnComboBox Then
            Dim cbo As MultiColumnComboBox = Obj
            cbo.SelectedIndex = -1
        End If
        If TypeOf Obj Is CheckBox Then
            Dim chk As CheckBox = Obj
            chk.Checked = False
        End If
        If TypeOf Obj Is TabControl Or TypeOf Obj Is TabPage Or TypeOf Obj Is GroupBox Or TypeOf Obj Is MultiColumnComboBox Then
            Dim obj2 As Control
            For Each obj2 In Obj.Controls
                Call SetControlValue(obj2)
            Next
        End If

        'If TypeOf Obj Is MultiColumnComboBox Then
        '    Dim obj2 As Control
        '    For Each obj2 In Obj.Controls
        '        Call SetControlValue(obj2)
        '    Next
        'End If
    End Sub

    Private Sub InitControl()
        Dim obj As Control
        For Each obj In Me.Controls
            Call SetControlValue(obj)
        Next

        Call EnabledControl(True)
        strSoNo = ""
        lblCancelled.Visible = False
        'grpSampleRequest.Enabled = False
        btnCancel.Text = "Cancel"
        Call LoadData("")
        Me.ComboSaleOrderType1.SelectedValue = "CUSTORDER"
        Me.chkSpecial1.Checked = True
        Me.checkBulkAppInternal.Checked = False
        Call SetdefaultSo_typeByUserID()
        Call Setdefaultfulfilment_typeBySo_type()
        tsbUnConfirmOrder.Enabled = False
        txtCustAddr.Text = ""
        'Call SetdefaultSo_typeByUserID()

        'Begin - Sitthana 19/09/2018
        lblCustomersActive.Visible = False
        If HadRight Then
            btnSave.Enabled = True
            tsbConfirmOrder.Enabled = True
        End If

        'End  - Sitthana 19/09/2018

        txtSoNo.Focus()
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

    Private Sub GenCombo()
        Dim objDB As New classMaster

        'Me.cboCustomer.DataSource = objDB.GetCustomer
        'Me.cboCustomer.DisplayMember = "name"
        'Me.cboCustomer.ValueMember = "new_custcd"

        'Me.cboDeliveryLoc.DataSource = objDB.GetCustomer
        'Me.cboDeliveryLoc.DisplayMember = "name"
        'Me.cboDeliveryLoc.ValueMember = "new_custcd"

        Me.cboAgent.DataSource = objDB.GetAgent
        Me.cboAgent.DisplayMember = "name"
        Me.cboAgent.ValueMember = "agcd2"

        Me.cboPackAfterBulkApp.DataSource = objDB.GetLookupPackAfterBulkApp
        Me.cboPackAfterBulkApp.DisplayMember = "lookup_value"
        Me.cboPackAfterBulkApp.ValueMember = "lookup_value_id"

        Me.cboSalesMan.DataSource = objDB.GetEmp
        Me.cboSalesMan.DisplayMember = "empname"
        Me.cboSalesMan.ValueMember = "empcd2"

        Me.cboFinalCustomer.DataSource = objDB.GetEndBuyers
        Me.cboFinalCustomer.DisplayMember = "endbuyername"
        Me.cboFinalCustomer.ValueMember = "endbuyercd"

        Me.cboPaymode.DataSource = objDB.GetPaymode
        Me.cboPaymode.DisplayMember = "paymodeDesc"
        Me.cboPaymode.ValueMember = "paymodecd"

        Me.ComboSaleOrderType1.populateData((New classConnection).getSQLConnection)
        ' Me.cboBank1.populateData((New classConnection).getSQLConnection)

        Me.cboMtl_warehouse.DataSource = objDB.Combomtlwarehouse(clsUser.UserID)
        Me.cboMtl_warehouse.DisplayMember = "warehouse_name"
        Me.cboMtl_warehouse.ValueMember = "mtl_warehouse_id"

        'Me.cbofulfilment_type.DataSource = objDB.Combofulfilment_type(clsUser.UserID) 'Comment By Sitthana 24/04/2018
        dtFulfilmentType = objDB.Combofulfilment_type(clsUser.UserID) 'Sitthana 24/04/2018
        Me.cbofulfilment_type.DataSource = dtFulfilmentType 'Sitthana 24/04/2018
        Me.cbofulfilment_type.DisplayMember = "lookup_value"
        Me.cbofulfilment_type.ValueMember = "lookup_value_id"

        'Me.cboPriceListCustomer.DataSource = objDB.getPriceListCustomer(Nothing)
        'Me.cboPriceListCustomer.DisplayMember = "name"
        'Me.cboPriceListCustomer.ValueMember = "so_price_list_header_id"

        'John 27/10/2025
        'Me.cboDesignProperties.DataSource = objDB.getDesignProperties
        'Me.cboDesignProperties.DisplayMember = "lookup_value_code"
        'Me.cboDesignProperties.ValueMember = "lookup_value_id"
        dtDesignProperties = objDB.getDesignProperties
        bsDesignProperties.DataSource = dtDesignProperties
        Me.mcboDesignProperties.DataSource = bsDesignProperties.DataSource
        Me.mcboDesignProperties.DisplayMember = "lookup_value_code"
        Me.mcboDesignProperties.ValueMember = "lookup_value_id"
        Me.mcboDesignProperties.Text = ""
        Me.mcboDesignProperties.ListBox.Grid.Model.Cols.Hidden(1) = True
        Me.mcboDesignProperties.ListBox.Grid.Model.Cols.Hidden(4) = True

        dtCustomersBillToFlag = (New classSalesOrder).getCustomersBillToFlag()
        bsCustomersBillToFlag.DataSource = dtCustomersBillToFlag
        Me.mcboCustomersBillToFlag.DataSource = bsCustomersBillToFlag '.DataSource
        Me.mcboCustomersBillToFlag.DisplayMember = "name"
        Me.mcboCustomersBillToFlag.ValueMember = "custcd"
        Me.mcboCustomersBillToFlag.AllowTypeFilter = True ' allow typing to filter the customer list -- John 18/09/2026
        Me.mcboCustomersBillToFlag.Text = ""
        Me.mcboCustomersBillToFlag.ListBox.Grid.Model.Cols.Hidden(1) = True
        Me.mcboCustomersBillToFlag.ListBox.Grid.Model.Cols.Hidden(2) = True
        Me.mcboCustomersBillToFlag.ListBox.Grid.Model.Cols.Hidden(6) = True
        Me.mcboCustomersBillToFlag.ListBox.Grid.Model.Cols.Hidden(7) = True
        Me.mcboCustomersBillToFlag.ListBox.Grid.Model.Cols.Hidden(8) = True
        Me.mcboCustomersBillToFlag.ListBox.Grid.Model.Cols.Hidden(9) = True
        Me.mcboCustomersBillToFlag.ListBox.Grid.Model.Cols.Hidden(10) = True
        Me.mcboCustomersBillToFlag.ListBox.Grid.Model.Cols.Hidden(11) = True
        Me.mcboCustomersBillToFlag.ListBox.Grid.Model.Cols.Hidden(12) = True
        Me.mcboCustomersBillToFlag.ListBox.Grid.Model.Cols.Hidden(13) = True
        Me.mcboCustomersBillToFlag.ListBox.Grid.Model.Cols.Hidden(14) = True
        Me.mcboCustomersBillToFlag.ListBox.Grid.Model.Cols.Hidden(15) = True
        Me.mcboCustomersBillToFlag.ListBox.Grid.Model.Cols.Hidden(16) = True
        Me.mcboCustomersBillToFlag.ListBox.Grid.Model.Cols.Hidden(17) = True
        Me.mcboCustomersBillToFlag.ListBox.Grid.Model.Cols.Hidden(18) = True
        Me.mcboCustomersBillToFlag.ListBox.Grid.Model.Cols.Hidden(19) = True
        AddHandler TryCast(mcboCustomersBillToFlag.ListControl, GridListBox).Grid.Model.QueryCellInfo, AddressOf Model_QueryCellInfoCustomersBillToFlag

        dtCustomersShipToFlag = (New classSalesOrder).getCustomersShipToFlag()
        bsCustomersShipToFlag.DataSource = dtCustomersShipToFlag
        Me.mcboCustomersShipToFlag.DataSource = bsCustomersShipToFlag '.DataSource
        Me.mcboCustomersShipToFlag.DisplayMember = "name"
        Me.mcboCustomersShipToFlag.ValueMember = "custcd"
        Me.mcboCustomersShipToFlag.AllowTypeFilter = True ' allow typing to filter the customer list -- John 18/09/2026
        Me.mcboCustomersShipToFlag.Text = ""
        Me.mcboCustomersShipToFlag.ListBox.Grid.Model.Cols.Hidden(1) = True
        Me.mcboCustomersShipToFlag.ListBox.Grid.Model.Cols.Hidden(2) = True
        Me.mcboCustomersShipToFlag.ListBox.Grid.Model.Cols.Hidden(6) = True
        Me.mcboCustomersShipToFlag.ListBox.Grid.Model.Cols.Hidden(7) = True
        Me.mcboCustomersShipToFlag.ListBox.Grid.Model.Cols.Hidden(8) = True
        Me.mcboCustomersShipToFlag.ListBox.Grid.Model.Cols.Hidden(9) = True
        Me.mcboCustomersShipToFlag.ListBox.Grid.Model.Cols.Hidden(10) = True
        Me.mcboCustomersShipToFlag.ListBox.Grid.Model.Cols.Hidden(11) = True
        Me.mcboCustomersShipToFlag.ListBox.Grid.Model.Cols.Hidden(12) = True
        Me.mcboCustomersShipToFlag.ListBox.Grid.Model.Cols.Hidden(13) = True
        Me.mcboCustomersShipToFlag.ListBox.Grid.Model.Cols.Hidden(14) = True
        Me.mcboCustomersShipToFlag.ListBox.Grid.Model.Cols.Hidden(15) = True
        Me.mcboCustomersShipToFlag.ListBox.Grid.Model.Cols.Hidden(16) = True
        Me.mcboCustomersShipToFlag.ListBox.Grid.Model.Cols.Hidden(17) = True
        Me.mcboCustomersShipToFlag.ListBox.Grid.Model.Cols.Hidden(18) = True
        Me.mcboCustomersShipToFlag.ListBox.Grid.Model.Cols.Hidden(19) = True
        AddHandler TryCast(mcboCustomersShipToFlag.ListControl, GridListBox).Grid.Model.QueryCellInfo, AddressOf Model_QueryCellInfo2CustomersShipToFlag

        Me.mcboBanks.DataSource = (New classMaster).comboBanks
        Me.mcboBanks.DisplayMember = "bank_display"
        Me.mcboBanks.ValueMember = "id_banks"
        Me.mcboBanks.Text = ""
        Me.mcboBanks.ListBox.Grid.Model.Cols.Hidden(1) = True
        Me.mcboBanks.ListBox.Grid.Model.Cols.Hidden(9) = True
        AddHandler TryCast(mcboBanks.ListControl, GridListBox).Grid.Model.QueryCellInfo, AddressOf Model_QueryCellInfoBanks

        With cbbSrTypeId
            .DataSource = clsMaster.getLookpValueByType(SRType)
            .DisplayMember = "lookup_value"
            .ValueMember = "lookup_value_id"
        End With

        Me.cboPriceListCustomer.DataSource = objDB.getPriceListCustomer(Nothing)
        Me.cboPriceListCustomer.DisplayMember = "list_name"
        Me.cboPriceListCustomer.ValueMember = "so_price_list_header_id"

        'Used In Datagrid
        'Me.design_gwth_nob.DataSource = objDB.GetDesignGwth
        'Me.design_gwth_nob.DisplayMember = "design_gwth_nob"
        'Me.design_gwth_nob.ValueMember = "design_gwth_nob"

        Me.cboWidth.DataSource = objDB.GetWidth
        Me.cboWidth.DisplayMember = "name_en"
        Me.cboWidth.ValueMember = "id"

        Me.col.DataSource = objDB.GetColor
        Me.col.DisplayMember = "colname2"
        Me.col.ValueMember = "col"

        With uom
            .DataSource = objDB.GetUOM
            .DisplayMember = "uom2"
            .ValueMember = "uom2"
        End With

        With curr
            .DataSource = objDB.GetCurrency
            .DisplayMember = "curr"
            .ValueMember = "curr"
        End With

        With sent_to
            .DataSource = clsMaster.getLookpValueByType(SRSentTo)
            .DisplayMember = "lookup_value"
            .ValueMember = "lookup_value_id"
        End With
    End Sub

    Private Sub Model_QueryCellInfoCustomersBillToFlag(ByVal sender As Object, ByVal e As GridQueryCellInfoEventArgs)
        If e.RowIndex = 0 AndAlso e.ColIndex = 3 Then
            e.Style.Font = New GridFontInfo(New Font("Segoe UI", 12, FontStyle.Bold, GraphicsUnit.Pixel))
            e.Style.Text = "Code"
        ElseIf e.RowIndex = 0 AndAlso e.ColIndex = 4 Then
            e.Style.Font = New GridFontInfo(New Font("Segoe UI", 12, FontStyle.Bold, GraphicsUnit.Pixel))
            e.Style.Text = "Name"
        ElseIf e.RowIndex = 0 AndAlso e.ColIndex = 5 Then
            e.Style.Font = New GridFontInfo(New Font("Segoe UI", 12, FontStyle.Bold, GraphicsUnit.Pixel))
            e.Style.Text = "Address"
        End If
    End Sub

    Private Sub Model_QueryCellInfo2CustomersShipToFlag(ByVal sender As Object, ByVal e As GridQueryCellInfoEventArgs)
        If e.RowIndex = 0 AndAlso e.ColIndex = 3 Then
            e.Style.Font = New GridFontInfo(New Font("Segoe UI", 12, FontStyle.Bold, GraphicsUnit.Pixel))
            e.Style.Text = "Code"
        ElseIf e.RowIndex = 0 AndAlso e.ColIndex = 4 Then
            e.Style.Font = New GridFontInfo(New Font("Segoe UI", 12, FontStyle.Bold, GraphicsUnit.Pixel))
            e.Style.Text = "Name"
        ElseIf e.RowIndex = 0 AndAlso e.ColIndex = 5 Then
            e.Style.Font = New GridFontInfo(New Font("Segoe UI", 12, FontStyle.Bold, GraphicsUnit.Pixel))
            e.Style.Text = "Address"
        End If
    End Sub

    Private Sub Model_QueryCellInfoBanks(ByVal sender As Object, ByVal e As GridQueryCellInfoEventArgs)
        If e.RowIndex = 0 AndAlso e.ColIndex = 2 Then
            e.Style.Font = New GridFontInfo(New Font("Segoe UI", 12, FontStyle.Bold, GraphicsUnit.Pixel))
            e.Style.Text = "Code"
        ElseIf e.RowIndex = 0 AndAlso e.ColIndex = 3 Then
            e.Style.Font = New GridFontInfo(New Font("Segoe UI", 12, FontStyle.Bold, GraphicsUnit.Pixel))
            e.Style.Text = "Name"
        ElseIf e.RowIndex = 0 AndAlso e.ColIndex = 4 Then
            e.Style.Font = New GridFontInfo(New Font("Segoe UI", 12, FontStyle.Bold, GraphicsUnit.Pixel))
            e.Style.Text = "Address"
        ElseIf e.RowIndex = 0 AndAlso e.ColIndex = 5 Then
            e.Style.Font = New GridFontInfo(New Font("Segoe UI", 11, FontStyle.Bold, GraphicsUnit.Pixel))
            e.Style.Text = "Swift Code"
        ElseIf e.RowIndex = 0 AndAlso e.ColIndex = 6 Then
            e.Style.Font = New GridFontInfo(New Font("Segoe UI", 12, FontStyle.Bold, GraphicsUnit.Pixel))
            e.Style.Text = "Account No."
        ElseIf e.RowIndex = 0 AndAlso e.ColIndex = 7 Then
            e.Style.Font = New GridFontInfo(New Font("Segoe UI", 12, FontStyle.Bold, GraphicsUnit.Pixel))
            e.Style.Text = "Currency"
        ElseIf e.RowIndex = 0 AndAlso e.ColIndex = 8 Then
            e.Style.Font = New GridFontInfo(New Font("Segoe UI", 12, FontStyle.Bold, GraphicsUnit.Pixel))
            e.Style.Text = "Branch"
        End If
    End Sub
    'Private Sub GenComboSoNo()
    '    Dim objDB As New classSalesOrder
    '    cboSoNo.ComboBox.DataSource = objDB.SOLoad(strUserID:=clsUser.UserID)
    '    cboSoNo.ComboBox.DisplayMember = "sono2"
    '    cboSoNo.ComboBox.ValueMember = "sono2"
    '    If strSoNo.Trim.Length > 0 Then cboSoNo.ComboBox.SelectedValue = strSoNo.Trim
    'End Sub

    Private Sub BindData(ByVal dt As DataTable)
        strSoNo = dt.Rows(0)("sono").ToString.Trim
        txtSoNo.Text = dt.Rows(0)("sono").ToString.Trim
        dtpSoDate.Value = CDate(dt.Rows(0)("sodt2").ToString)

        txtPoNo.Text = dt.Rows(0)("custpo").ToString.Trim
        txtCustPoUnique.Text = dt.Rows(0)("custpo_unique").ToString.Trim
        txtContractNumber.Text = If(dt.Columns.Contains("contract_number"), dt.Rows(0)("contract_number").ToString.Trim, "")
        txtCustPoSuffix.Text = dt.Rows(0)("custpo_suffix").ToString.Trim
        txtCustAddlInfo.Text = dt.Rows(0)("cust_addl_info").ToString.Trim

        dtpPoDate.Value = CDate(dt.Rows(0)("podt2").ToString)

        mcboCustomersBillToFlag.SelectedValue = dt.Rows(0)("custcd").ToString.Trim
        bsCustomersShipToFlag.Filter = "parent_customer_id = " & Me.mcboCustomersBillToFlag.ListBox.Grid.Model(Me.mcboCustomersBillToFlag.SelectedIndex + 1, 1).CellValue & "" 'Disible By Neung K.Piew No Need to Filter Cust Deli

        cboAgent.SelectedValue = dt.Rows(0)("agcd").ToString.Trim
        cboSalesMan.SelectedValue = dt.Rows(0)("empcd").ToString.Trim
        cboFinalCustomer.SelectedValue = dt.Rows(0)("endbuyercd").ToString.Trim
        txtTermCondition.Text = dt.Rows(0)("payterms").ToString.Trim
        txtCreditDays.Text = dt.Rows(0)("crdays").ToString.Trim

        mcboCustomersShipToFlag.SelectedValue = dt.Rows(0)("delicd").ToString.Trim
        txtDeliveryTerm.Text = dt.Rows(0)("deli").ToString.Trim
        txtTransportBy.Text = dt.Rows(0)("shipvia").ToString.Trim
        txtAdditionalLabel.Text = dt.Rows(0)("shipmark").ToString.Trim
        txtRemark.Text = dt.Rows(0)("REM").ToString.Trim

        '---- John 20/10/2025 ----
        txtRefJobNo1.Text = dt.Rows(0)("ref_jobno1").ToString.Trim
        txtRefJobNo2.Text = dt.Rows(0)("ref_jobno2").ToString.Trim
        txtRefJobNo3.Text = dt.Rows(0)("ref_jobno3").ToString.Trim
        txtRefJobNo4.Text = dt.Rows(0)("ref_jobno4").ToString.Trim
        txtJobNoComment1.Text = dt.Rows(0)("ref_job_comment1").ToString.Trim
        txtJobNoComment2.Text = dt.Rows(0)("ref_job_comment2").ToString.Trim
        txtJobNoComment3.Text = dt.Rows(0)("ref_job_comment3").ToString.Trim
        txtJobNoComment4.Text = dt.Rows(0)("ref_job_comment4").ToString.Trim
        '----------------------------
        txtRevise.Text = dt.Rows(0)("rev").ToString.Trim
        chkExport.Checked = CBool(dt.Rows(0)("exploc"))

        Me.txtRef.Text = dt.Rows(0)("ref").ToString.Trim

        Me.optAppByDH.Checked = dt.Rows(0)("bulk_app_by_dh")
        Me.optAppByMK.Checked = dt.Rows(0)("bulk_app_by_mk")


        chkSpecial1.Checked = CBool(dt.Rows(0)("submit_bulk"))
        checkBulkAppInternal.Checked = Not CBool(dt.Rows(0)("submit_bulk"))
        chkSpecial2.Checked = CBool(dt.Rows(0)("sample_order"))
        chkSpecial3.Checked = CBool(dt.Rows(0)("prgOrder"))
        Me.chkStockOrder.Checked = CBool(dt.Rows(0)("stock_Order"))
        Me.chkDevlOrder.Checked = CBool(dt.Rows(0)("devl_Order"))
        Me.chkClearOrder.Checked = CBool(dt.Rows(0)("clearance_Order"))
        Me.chkSubmitAllBatches.Checked = CBool(dt.Rows(0)("submit_bulk_all_batch"))
        Me.textBatches.Text = dt.Rows(0)("no_of_batches")
        txtNetAmt.Text = FormatNumber(dt.Rows(0)("gr_soamt"), 2, TriState.False, TriState.False, TriState.True)
        txtContact.Text = dt.Rows(0)("contact").ToString.Trim
        Me.txtShipQty_tolerance.Text = dt.Rows(0)("shipqty_tolerance").ToString.Trim
        If CBool(dt.Rows(0)("cancel_status")) Then
            lblCancelled.Visible = True
            btnCancel.Text = "UnCancel"
            Call EnabledControl(False)
        Else
            btnCancel.Text = "Cancel"
        End If
        Me.txtShipQty_Tolerance_high.Text = dt.Rows(0)("shipqty_tolerance_high").ToString.Trim
        Me.txtShipQty_Tolerance_low.Text = dt.Rows(0)("shipqty_tolerance_low").ToString.Trim
        Me.ComboSaleOrderType1.SelectedValue = dt.Rows(0)("order_type").ToString.Trim

        Me.cboPaymode.SelectedValue = dt.Rows(0)("paymodecd").ToString.Trim
        Me.txtAgentCommPer.Text = dt.Rows(0)("agentcommper")
        Me.txtSalesCommPer.Text = dt.Rows(0)("salescommper")
        txtDyeStandard.Text = dt.Rows(0)("dye_standard")
        txtQualitySpecialReq.Text = dt.Rows(0)("quality_special_request")
        'cboBank1.SelectedValue = dt.Rows(0)("bank_code")
        mcboBanks.SelectedValue = dt.Rows(0)("id_banks")
        cboPackAfterBulkApp.SelectedValue = dt.Rows(0)("pack_after_bulk_app_lookup_type")

        cboMtl_warehouse.SelectedValue = dt.Rows(0)("ship_from_warehouse_id")
        cbofulfilment_type.SelectedValue = dt.Rows(0)("SO_FULFIL_SRC_ID")
        txtFulfilmentComment.Text = dt.Rows(0)("fulfilment_comment") 'Sitthana 19/09/2018
        cbbSrTypeId.SelectedValue = dt.Rows(0)("sr_type_id") 'Sitthana 20240523
        mcboDesignProperties.SelectedValue = dt.Rows(0)("design_properties_id") 'John 28/10/2025
        cboPriceListCustomer.SelectedValue = dt.Rows(0)("price_list_header_id")
        txtSampleFabricQty.Text = If(dt.Columns.Contains("so_sample_fabric_qty"), dt.Rows(0)("so_sample_fabric_qty").ToString, "0")
        txtSampleBulkQty.Text = If(dt.Columns.Contains("so_sample_bulk_qty"), dt.Rows(0)("so_sample_bulk_qty").ToString, "0")

        If Not IsDBNull(dt.Rows(0)("flow_status_code")) Then
            txtFlowStatusCode.Text = dt.Rows(0)("flow_status_code")
            If dt.Rows(0)("flow_status_code").ToString.Trim = "CFM" Then grdSalesOrder.Columns("qty").ReadOnly = (True And Not objSecurity.UserAccess(UserInfo.UserID, "SO0030", "EDIT"))
            If dt.Rows(0)("flow_status_code").ToString.Trim = "CFM" Then grdSalesOrder.AllowUserToAddRows = (False Or objSecurity.UserAccess(UserInfo.UserID, "SO0030", "EDIT"))
            If dt.Rows(0)("flow_status_code").ToString.Trim = "CFM" Then grdSalesOrder.AllowUserToDeleteRows = (False Or objSecurity.UserAccess(UserInfo.UserID, "SO0030", "EDIT"))
            'If dt.Rows(0)("flow_status_code").ToString.Trim = "CFM" Then txtFlowStatusCode.BackColor = Color.Green
            ' If dt.Rows(0)("flow_status_code").ToString.Trim = "CFM" Then txtFlowStatusCode.ForeColor = Color.Red

            If dt.Rows(0)("flow_status_code").ToString.Trim = "ENT" Then grdSalesOrder.Columns("qty").ReadOnly = False
            If dt.Rows(0)("flow_status_code").ToString.Trim = "ENT" Then grdSalesOrder.AllowUserToAddRows = (True Or objSecurity.UserAccess(UserInfo.UserID, "SO0030", "EDIT"))
            If dt.Rows(0)("flow_status_code").ToString.Trim = "ENT" Then grdSalesOrder.AllowUserToDeleteRows = (True Or objSecurity.UserAccess(UserInfo.UserID, "SO0030", "EDIT"))
            'If dt.Rows(0)("flow_status_code").ToString.Trim = "ENT" Then txtFlowStatusCode.BackColor = Color.Yellow
        Else
            txtFlowStatusCode.Text = ""
            grdSalesOrder.Columns("qty").ReadOnly = False
        End If

        Call enableDisableControls()

        'Begin - Sitthana 19/09/2018
        If dt.Rows(0)("active") = 1 Then
            If HadRight Then
                btnSave.Enabled = True
                tsbConfirmOrder.Enabled = True
            End If
            lblCustomersActive.Visible = False
        Else
            If HadRight Then
                btnSave.Enabled = False
                tsbConfirmOrder.Enabled = False
            End If
            lblCustomersActive.Visible = True
            MessageBox.Show("ลูกค้าท่านนี้ ถูกยกเลิกแล้ว " & vbCr _
                          & "   - คุณไม่สามารถแก้ไขข้อมูลได้" & vbCr _
                          & "   - คุณสามารถ ยกเลิก แต่ Unconfirm ไม่ได้" _
                          , "ข้อความเตือน", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
        'End  - Sitthana 19/09/2018
    End Sub

    Private Sub BindGrid(ByVal dt As DataTable)
        grdSalesOrder.AutoGenerateColumns = False
        grdSalesOrder.DataSource = dt
        hidecolumns()
    End Sub

    Private Function IsDataChange() As Boolean
        Dim config As New clsConfig
        Dim result As Boolean = False
        Dim dt As New DataTable
        dt = grdSalesOrder.DataSource
        Dim dv As New DataView(dt, "", "", DataViewRowState.OriginalRows)
        If dt Is Nothing Or dv.Count = 0 Then
            If grdSalesOrder.Rows.Count > 1 Then result = True

            If dtpSoDate.Value.ToString("yyyyMMdd") <> Now.ToString("yyyyMMdd") Then result = True
            If txtPoNo.Text <> "" Then result = True
            If dtpPoDate.Value.ToString("yyyyMMdd") <> Now.ToString("yyyyMMdd") Then result = True
            If config.IsNull(mcboCustomersBillToFlag.SelectedValue, "").ToString.Trim <> "" Then result = True
            If config.IsNull(cboAgent.SelectedValue, "").ToString.Trim <> "" Then result = True
            If config.IsNull(cboSalesMan.SelectedValue, "").ToString.Trim <> "" Then result = True
            If config.IsNull(cboFinalCustomer.SelectedValue, "").ToString.Trim <> "" Then result = True
            If txtTermCondition.Text <> "" Then result = True
            If txtCreditDays.Text <> "0" And txtCreditDays.Text <> "" Then result = True

            If config.IsNull(mcboCustomersShipToFlag.SelectedValue, "").ToString.Trim <> "" Then result = True
            If txtDeliveryTerm.Text <> "" Then result = True
            If txtTransportBy.Text <> "" Then result = True
            If txtAdditionalLabel.Text <> "" Then result = True
            If txtRemark.Text <> "" Then result = True

            'John 20/10/2025 --------
            If txtRefJobNo1.Text <> "" Then result = True
            If txtRefJobNo2.Text <> "" Then result = True
            If txtRefJobNo3.Text <> "" Then result = True
            If txtRefJobNo4.Text <> "" Then result = True
            If txtJobNoComment1.Text <> "" Then result = True
            If txtJobNoComment2.Text <> "" Then result = True
            If txtJobNoComment3.Text <> "" Then result = True
            If txtJobNoComment4.Text <> "" Then result = True
            '---------------------------
            If txtSampleFabricQty.Text.Trim <> "" AndAlso Val(txtSampleFabricQty.Text.Trim) <> 0 Then result = True
            If txtSampleBulkQty.Text.Trim <> "" AndAlso Val(txtSampleBulkQty.Text.Trim) <> 0 Then result = True
            If chkExport.Checked = True Then result = True

            If chkSpecial1.Checked = True Then result = False
            If chkSpecial2.Checked = True Then result = True
            If chkSpecial2.Checked = True Then result = True
        Else
            If dtpSoDate.Value <> CDate(dt.Rows(0)("sodt2").ToString) Then result = True
            If txtPoNo.Text <> dt.Rows(0)("custpo").ToString.Trim Then result = True
            If dtpPoDate.Value <> CDate(dt.Rows(0)("podt2").ToString) Then result = True
            If (New clsConfig).IsNull(mcboCustomersBillToFlag.SelectedValue, "").ToString.Trim <> (New clsConfig).IsNull(dt.Rows(0)("custcd"), "").ToString.Trim Then result = True
            If cboAgent.SelectedValue <> dt.Rows(0)("agcd").ToString.Trim Then result = True
            If cboSalesMan.SelectedValue <> dt.Rows(0)("empcd").ToString.Trim Then result = True
            If cboFinalCustomer.SelectedValue <> dt.Rows(0)("endbuyercd").ToString.Trim Then result = True
            If txtTermCondition.Text <> dt.Rows(0)("payterms").ToString.Trim Then result = True
            If txtCreditDays.Text <> dt.Rows(0)("crdays").ToString.Trim Then result = True
            If (New clsConfig).IsNull(mcboCustomersShipToFlag.SelectedValue, "").ToString.Trim <> (New clsConfig).IsNull(dt.Rows(0)("delicd"), "").ToString.Trim Then result = True
            If txtDeliveryTerm.Text <> dt.Rows(0)("deli").ToString.Trim Then result = True
            If txtTransportBy.Text <> dt.Rows(0)("shipvia").ToString.Trim Then result = True
            If txtAdditionalLabel.Text <> dt.Rows(0)("shipmark").ToString.Trim Then result = True
            If txtRemark.Text <> dt.Rows(0)("rem").ToString.Trim Then result = True

            'John 20/10/2025 ---------
            If txtRefJobNo1.Text <> dt.Rows(0)("ref_jobno1").ToString.Trim Then result = True
            If txtRefJobNo2.Text <> dt.Rows(0)("ref_jobno2").ToString.Trim Then result = True
            If txtRefJobNo3.Text <> dt.Rows(0)("ref_jobno3").ToString.Trim Then result = True
            If txtRefJobNo4.Text <> dt.Rows(0)("ref_jobno4").ToString.Trim Then result = True
            If txtJobNoComment1.Text <> dt.Rows(0)("ref_job_comment1").ToString.Trim Then result = True
            If txtJobNoComment2.Text <> dt.Rows(0)("ref_job_comment2").ToString.Trim Then result = True
            If txtJobNoComment3.Text <> dt.Rows(0)("ref_job_comment3").ToString.Trim Then result = True
            If txtJobNoComment4.Text <> dt.Rows(0)("ref_job_comment4").ToString.Trim Then result = True
            '-------------------------
            If dt.Columns.Contains("so_sample_fabric_qty") AndAlso Val(txtSampleFabricQty.Text) <> Val(dt.Rows(0)("so_sample_fabric_qty").ToString) Then result = True
            If dt.Columns.Contains("so_sample_bulk_qty") AndAlso Val(txtSampleBulkQty.Text) <> Val(dt.Rows(0)("so_sample_bulk_qty").ToString) Then result = True
            If chkExport.Checked <> CBool(dt.Rows(0)("exploc")) Then result = True

            If chkSpecial1.Checked <> CBool(dt.Rows(0)("submit_bulk")) Then result = True
            If chkSpecial2.Checked <> CBool(dt.Rows(0)("sample_order")) Then result = True
            If chkSpecial3.Checked <> CBool(dt.Rows(0)("prgorder")) Then result = True

            Dim delRecs As New DataView(dt, "", "", DataViewRowState.Deleted)
            If delRecs.Count > 0 Then result = True

            Dim updRecs As New DataView(dt, "", "", DataViewRowState.ModifiedCurrent)
            If updRecs.Count > 0 Then result = True

            Dim addRecs As New DataView(dt, "", "", DataViewRowState.Added)
            If addRecs.Count > 0 Then result = True
        End If

        IsDataChange = result
    End Function

    Private Function CheckData() As Boolean
        If lblCancelled.Visible Then
            MessageBox.Show("This document is cancelled." & vbCrLf & "Can't edit anymore.", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Return False
        End If
        If txtPoNo.Text.Trim = "" And Me.ComboSaleOrderType1.SelectedValue = "CUSTORDER" Then
            MessageBox.Show("Please input Customer Purchase Order No. because this looks like a customer order", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Return False
        End If
        'Begin Check By Sitthana 12/09/2018
        If mcboCustomersBillToFlag.SelectedIndex = -1 Then
            MessageBox.Show("คุณยังไม่ได้เลือก Customer Bill To " & vbCr _
                          & "  กรุณาเลือกก่อนกลับ" _
                          , "ข้อความเตือน", MessageBoxButtons.OK, MessageBoxIcon.Error)
            CheckData = False
            Exit Function
        End If
        If mcboCustomersShipToFlag.SelectedIndex = -1 Then
            MessageBox.Show("คุณยังไม่ได้เลือก Delivery To " & vbCr _
                          & "  กรุณาเลือกก่อนกลับ" _
                          , "ข้อความเตือน", MessageBoxButtons.OK, MessageBoxIcon.Error)
            CheckData = False
            Exit Function
        End If
        'End Check By Sitthana 12/09/2018

        If (New clsConfig).IsNull(mcboCustomersBillToFlag.SelectedValue, "") = "" Then
            MessageBox.Show("Please choose customer bill to!!", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            ErrorProvider1.SetError(mcboCustomersBillToFlag, "Please choose customer bill to!!")
            Return False
        Else
            ErrorProvider1.SetError(mcboCustomersBillToFlag, "")
        End If

        If (New clsConfig).IsNull(mcboCustomersShipToFlag.SelectedValue, "") = "" Then
            MessageBox.Show("Please choose customer ship to!!", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            ErrorProvider1.SetError(mcboCustomersBillToFlag, "Please choose customer ship to!!")
            Return False
        End If

        If oConfig.IsNull(ComboSaleOrderType1.SelectedValue, "").ToString.Trim = "CUSTORDER" Then 'Add By Neung Check only CUSTORDER
            If cboPriceListCustomer.SelectedIndex = -1 OrElse (New clsConfig).IsNull(cboPriceListCustomer.SelectedValue, "").ToString.Trim = "" Then ' John 25/09/2026

                'MessageBox.Show("A Price List Customer must be selected before the order can be saved.", "Validation Required", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1)
                'ErrorProvider1.SetError(cboPriceListCustomer, "A Price List Customer must be selected.")
                'CheckData = False
                'Exit Function
            End If
        End If

        If (New clsConfig).IsNull(cboSalesMan.SelectedValue, "").ToString.Trim = "" Then
            MessageBox.Show("Please choose salesman (customer service)!!", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            CheckData = False
            Exit Function
        End If
        If grdSalesOrder.Rows.Count <= 1 Then
            MessageBox.Show("Please insert data in table at least 1 record!!", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            CheckData = False
            Exit Function
        End If
        If (New clsConfig).IsNull(Me.ComboSaleOrderType1.SelectedValue, "").ToString.Trim = "" Then
            MessageBox.Show("Please choose a valid order type  !! for ex., Sample, Devl, Customer P/o, Stock etc", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            CheckData = False
            Exit Function
        End If
        If Not cboMtl_warehouse.DataSource Is Nothing Then
            If (New clsConfig).IsNull(Me.cboMtl_warehouse.SelectedValue, 0).ToString.Trim = 0 Then
                MessageBox.Show("Please choose Ship From WareHouse  !! ", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
                ErrorProvider1.SetError(cboMtl_warehouse, "Please choose Ship From WareHouse  !!")
                CheckData = False
                Exit Function
            Else
                ErrorProvider1.SetError(cboMtl_warehouse, "")
            End If
        End If

        'Begin Copy From Gemmaknit  Sitthana 23/04/2018
        If (New clsConfig).IsNull(Me.cboPackAfterBulkApp.SelectedValue, -1) <= 0 Then
            MessageBox.Show("Please select Packing flow after bulk approval", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            CheckData = False
            TabControl1.SelectedTab = tabOther
            cboPackAfterBulkApp.Focus()
            Exit Function
        End If

        If oConfig.IsNull(cbofulfilment_type.SelectedValue, 0) = 0 Then
            MessageBox.Show("Must be have Fulfilment Source", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
            CheckData = False
            cbofulfilment_type.Focus()
            Exit Function
        End If

        If Not CheckSalesOrderItemMasterData() Then
            CheckData = False
            Exit Function
        End If

        'If (checkBulkAppInternal.Checked = True Or chkSpecial1.Checked = True) And clsConfig.IsNull(txtMtsPerRoll.Text, 0) = 0 Then
        '    MessageBox.Show("Please enter LENGTH PER ROLL (Mts)", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
        '    CheckData = False
        '    txtMtsPerRoll.Focus()
        '    Exit Function
        'End If
        'End Copy From Gemmaknit  Sitthana 23/04/2018

        CheckData = True
    End Function

    Private Function CheckSalesOrderItemMasterData() As Boolean
        Dim objSalesOrder As New classSalesOrder
        Dim isCustomerOrder As Boolean = Me.ComboSaleOrderType1.SelectedValue = "CUSTORDER"

        For Each row As DataGridViewRow In grdSalesOrder.Rows
            If row.IsNewRow Then Continue For

            Dim rowNo As Integer = row.Index + 1
            Dim designNo As String = oConfig.IsNull(row.Cells("design_no").Value, "").ToString.Trim

            If designNo.Length = 0 Then
                ShowSalesOrderGridError(row, "design_no", "Please input Design No. / Item No. in row " & rowNo & ".")
                Return False
            End If

            If isCustomerOrder AndAlso Not objSalesOrder.SalesOrderDesignNoExists(designNo) Then
                ShowSalesOrderGridError(row, "design_no", "Design No. / Item No. '" & designNo & "' does not exist in master. Please check row " & rowNo & ".")
                Return False
            End If
        Next

        Return True
    End Function

    Private Sub ShowSalesOrderGridError(ByVal row As DataGridViewRow, ByVal columnName As String, ByVal message As String)
        MessageBox.Show(message, "System Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
        grdSalesOrder.CurrentCell = row.Cells(columnName)
        grdSalesOrder.Focus()
    End Sub

    Private Sub LoadData(ByVal SoNo As String)
        Dim objDB As New classSalesOrder
        Dim dt As New DataTable
        dt = objDB.SODetLoad(SoNo)
        Call BindGrid(dt)
        If dt.Rows.Count > 0 Then
            Call BindData(dt)
            tsbtnCopySO.Enabled = True
        Else
            tsbtnCopySO.Enabled = False
        End If
    End Sub

    Private Sub SumGrid()
        Dim config As New clsConfig
        Dim i As Integer = 0
        Dim dblNetAmt As Double = 0
        For i = 0 To grdSalesOrder.Rows.Count - 1
            dblNetAmt = dblNetAmt + config.IsNull(grdSalesOrder.Rows(i).Cells("nt_itamt").Value, 0)
        Next
        txtNetAmt.Text = Format(dblNetAmt, "#,###.#0")
    End Sub

    Private Function SaveData() As Boolean
        Dim config As New clsConfig
        Dim clsSO As New classSalesOrder
        Dim header As New classSalesOrder.SOHeader
        Dim msgerr As String = ""
        Dim sono As String = ""
        Dim dt As New DataTable
        'Begin Copy From Gemmaknit Sitthana 23/04/2018
        getFulfilmentTypeCode()
        If fulfilmentTypeCode = "NEW_PROD" And txtFulfilmentComment.Text = "" Then
            MessageBox.Show("Please enter fulfilment comment because you want NEW PRODUCTION for this order", "Fulfilment Comment Missing")
            txtFulfilmentComment.Focus()
            Return False
        End If
        'End  Copy From Gemmaknit Sitthana 23/04/2018

        dt = grdSalesOrder.DataSource
        'Begin Sitthana 20190625
        Dim dv_add As New DataView
        Dim dv_upd As New DataView
        Dim dv_del As New DataView

        Dim i As Integer = 0
        If CaseCopy Then

            'Add by sittana  case create new from old data
            If dt.Rows.Count > 0 Then
                For i = 0 To dt.Rows.Count - 1
                    dt.Rows(i)("slno") = i + 1
                    dt.Rows(i)("closed") = 0 'Clear close flag
                Next
            End If
            dv_add = New DataView(dt, "", "", DataViewRowState.None)
            dv_upd = New DataView(dt, "", "", DataViewRowState.None)
            dv_del = New DataView(dt, "", "", DataViewRowState.None)

            strSoNo = ""
            header.h01_sono = strSoNo
            header.h02_sodt = Format(Today(), "yyyyMMdd")
            header.h22_lastsonoid = 0
            header.h21_cancel_status = False
            header.h19_rev = 0
            header.h18_ref = ""
            header.ship_from_warehouse_id = Nothing
        Else
            'Old code case normal
            If dt.Rows.Count > 0 Then
                For i = 0 To dt.Rows.Count - 1
                    If dt.Rows(i).RowState <> DataRowState.Deleted Then If config.IsNull(dt.Rows(i)("slno"), 0) = 0 Then dt.Rows(i)("slno") = i + 1
                Next
            End If
            dv_add = New DataView(dt, "", "", DataViewRowState.Added)
            dv_upd = New DataView(dt, "", "", DataViewRowState.ModifiedCurrent)
            dv_del = New DataView(dt, "", "", DataViewRowState.Deleted)

            header.h01_sono = IIf(strSoNo.Trim.Length = 0, txtSoNo.Text.Trim.ToUpper, strSoNo)
            header.h02_sodt = dtpSoDate.Value.ToString("yyyyMMdd")
            header.h21_cancel_status = lblCancelled.Visible
            header.h19_rev = Val(txtRevise.Text.Trim)
            header.h18_ref = Me.txtRef.Text
            header.ship_from_warehouse_id = (New clsConfig).IsNull(cboMtl_warehouse.SelectedValue, Nothing)
        End If
        'End Sitthana 20190625

        'Dim dv_add As New DataView(dt, "", "", DataViewRowState.Added)
        'Dim dv_upd As New DataView(dt, "", "", DataViewRowState.ModifiedCurrent)
        'Dim dv_del As New DataView(dt, "", "", DataViewRowState.Deleted)

        'header.h01_sono = strSoNo
        'header.h01_sono = IIf(strSoNo.Trim.Length = 0, txtSoNo.Text.Trim.ToUpper, strSoNo) 'Sitthana move to above
        'header.h02_sodt = dtpSoDate.Value.ToString("yyyyMMdd") 'Sittana move to above
        header.h03_custcd = oConfig.IsNull(Me.mcboCustomersBillToFlag.ListBox.Grid.Model(Me.mcboCustomersBillToFlag.SelectedIndex + 1, 3).CellValue, Nothing).ToString ' config.IsNull(mcboCustomersBillToFlag.SelectedValue, "").ToString.Trim
        header.h04_agcd = config.IsNull(cboAgent.SelectedValue, "").ToString.Trim
        header.h05_empcd = config.IsNull(cboSalesMan.SelectedValue, "").ToString.Trim
        header.h06_rem = txtRemark.Text.Trim
        header.h07_gr_soamt = FormatNumber(txtNetAmt.Text, 2, , TriState.False, TriState.False)
        header.h08_discamt = 0
        header.h09_nt_soamt = FormatNumber(txtNetAmt.Text, 2, , TriState.False, TriState.False)
        header.h10_attn = ""
        header.h11_shipcustcd = oConfig.IsNull(Me.mcboCustomersShipToFlag.ListBox.Grid.Model(Me.mcboCustomersShipToFlag.SelectedIndex + 1, 3).CellValue, Nothing) 'config.IsNull(cboDeliveryLoc.SelectedValue, "").ToString.Trim
        header.h12_payterms = txtTermCondition.Text.Trim
        header.h13_credit = 0
        header.h14_crdays = Val(txtCreditDays.Text.Trim)
        header.h15_custpo = txtPoNo.Text.Trim
        header.h15_custpo_unique = txtCustPoUnique.Text.Trim
        header.h15_contract_number = txtContractNumber.Text.Trim
        header.h15_custpo_suffix = txtCustPoSuffix.Text.Trim
        header.h16_deli = txtDeliveryTerm.Text.Trim
        header.h17_delicd = oConfig.IsNull(Me.mcboCustomersShipToFlag.ListBox.Grid.Model(Me.mcboCustomersShipToFlag.SelectedIndex + 1, 3).CellValue, Nothing)  'config.IsNull(cboDeliveryLoc.SelectedValue, "").ToString.Trim
        'header.h18_ref = Me.txtRef.Text 'Sitthana move to above
        'header.h19_rev = Val(txtRevise.Text.Trim) 'Sitthana move to above
        header.h20_sono1 = strSoNo
        'header.h21_cancel_status = lblCancelled.Visible 'Sitthana move above
        'header.h22_lastsonoid = 0
        header.h23_endbuyercd = config.IsNull(cboFinalCustomer.SelectedValue, "").ToString.Trim
        header.h24_prgorder = chkSpecial3.Checked
        header.h25_shipmark = txtAdditionalLabel.Text.Trim
        '        header.h26_sample_order = chkSpecial2.Checked
        '       header.h33_stock_Order = Me.chkStockOrder.Checked
        '      header.h34_devl_Order = Me.chkDevlOrder.Checked
        '     header.h35_clearance_Order = Me.chkClearOrder.Checked
        header.h27_submit_bulk = chkSpecial1.Checked
        header.h28_shipvia = txtTransportBy.Text.Trim
        header.h29_exploc = chkExport.Checked
        header.h30_log_empcd = clsUser.UserID
        header.h31_submit_bulk_all_batch = Me.chkSubmitAllBatches.Checked
        header.h32_no_of_batches = Me.textBatches.Text
        header.h36_contact = Me.txtContact.Text.Trim
        header.h37_bulk_app_by_dh = Me.optAppByDH.Checked
        header.h38_bulk_app_by_mk = Me.optAppByMK.Checked
        header.h39_shipqty_tolerance = config.IsNull(Me.txtShipQty_tolerance.Text, 0)
        header.h40_paymodecd = config.IsNull(Me.cboPaymode.SelectedValue, "")
        header.h41_shipqty_tolerance_high = config.IsNull(Me.txtShipQty_Tolerance_high.Text, 0)
        header.h42_shipqty_tolerance_low = config.IsNull(Me.txtShipQty_Tolerance_low.Text, 0)
        header.h43_order_type = Me.ComboSaleOrderType1.SelectedValue
        header.h44_agentcommper = Me.txtAgentCommPer.Text
        header.h45_salescommper = Me.txtSalesCommPer.Text
        header.h46_dye_standard = txtDyeStandard.Text
        header.h47_quality_special_request = txtQualitySpecialReq.Text
        header.h48_pack_after_bulk_app_lookup_type = cboPackAfterBulkApp.SelectedValue
        'header.h50_bank_code = cboBank1.SelectedValue
        header.h51_id_banks = (New clsConfig).IsNull(mcboBanks.SelectedValue, Nothing)
        'header.ship_from_warehouse_id = (New clsConfig).IsNull(cboMtl_warehouse.SelectedValue, Nothing)  'Sitthana move to above
        header.SO_FULFIL_SRC_ID = cbofulfilment_type.SelectedValue
        header.fulfilment_comment = txtFulfilmentComment.Text.Trim
        header.mts_per_roll = oConfig.IsNull(txtMtsPerRoll.Text, 0)
        header.h52_sr_type_id = (New clsConfig).IsNull(cbbSrTypeId.SelectedValue, Nothing) 'Sitthana 20240523
        'John 20/10/2025----------------
        header.h53_refjobno1 = txtRefJobNo1.Text.Trim
        header.h54_refJobno2 = txtRefJobNo2.Text.Trim
        header.h55_refJobno3 = txtRefJobNo3.Text.Trim
        header.h56_refJobno4 = txtRefJobNo4.Text.Trim
        header.h57_jobnocomment1 = txtJobNoComment1.Text.Trim
        header.h58_jobnocomment2 = txtJobNoComment2.Text.Trim
        header.h59_jobnocomment3 = txtJobNoComment3.Text.Trim
        header.h60_jobnocomment4 = txtJobNoComment4.Text.Trim
        header.h61_design_properties_id = oConfig.IsNull(mcboDesignProperties.SelectedValue, Nothing) 'John 28/10/2025
        header.h62_cust_addl_info = txtCustAddlInfo.Text.Trim
        header.h63_sample_fabric_qty = Val(txtSampleFabricQty.Text)
        header.h64_sample_bulk_qty = Val(txtSampleBulkQty.Text)
        header.h65_price_list_header_id = oConfig.IsNull(cboPriceListCustomer.SelectedValue, Nothing) 'John 25/09/2026
        '--------------------------------
        If Me.textBatches.Text = "" Then
            Me.textBatches.Text = 0
        End If

        If clsSO.SOSave(header, dv_add, dv_upd, dv_del, msgerr, sono) Then
            strSoNo = sono
            SaveData = True
        Else
            MessageBox.Show(msgerr, "System Message", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
            SaveData = False
        End If
    End Function
    Private Sub getFulfilmentTypeCode()
        'Copy From Gemmaknits Sitthana 23/04/2018
        Dim ft As Integer
        ft = cbofulfilment_type.SelectedValue
        For Each r As DataRow In dtFulfilmentType.Rows
            If r("lookup_value_id") = ft Then
                fulfilmentTypeCode = r("lookup_value_code")
                fulfilmentTypeCode = fulfilmentTypeCode.Trim
            End If
        Next
    End Sub
    Private Sub CheckDuplicatePO()
        Dim clsSO As New classSalesOrder
        Dim dt As DataTable = clsSO.GetSOFromPO(txtPoNo.Text.Trim)
        Dim isDuplicate As Boolean = False
        If dt.Rows.Count > 0 Then
            isDuplicate = True

            For Each dr As DataRow In dt.Rows
                If strSoNo.Trim.Length > 0 And dr("sono").ToString().Equals(strSoNo) Then
                    isDuplicate = False
                End If
            Next

            If isDuplicate Then MessageBox.Show("There is a duplicate Customer P/O with S/O No. " + dt.Rows(0)("sono").ToString(), "System Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub
    Private Sub CheckDuplicateCustPoUnique()
        Dim clsSO As New classSalesOrder
        Dim dt As DataTable = clsSO.GetSOFromCustPOUnique(txtCustPoUnique.Text.Trim)
        Dim isDuplicate As Boolean = False
        If dt.Rows.Count > 0 Then
            isDuplicate = True

            For Each dr As DataRow In dt.Rows
                If strSoNo.Trim.Length > 0 And dr("sono").ToString().Equals(strSoNo) Then
                    isDuplicate = False
                End If
            Next

            If isDuplicate Then MessageBox.Show("There is a duplicate Customer P/O with S/O No. " + dt.Rows(0)("sono").ToString(), "System Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub


    Private Sub frmSalesOrder_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Me.WindowState = FormWindowState.Maximized

        formatSoItemsGrid()
        tabOthers.Hide()
        Call GenCombo()
        '		Call GenComboSoNo()
        Call InitControl()
        'Call checkUserAccess()

        Me.tabCustomer.Show()
        applyGridLayoutSettingsToGrid(grdSalesOrder) 'John 27/10/2025

        Dim dbname = (New classConnection).database
        If dbname = "ColomboDB" OrElse dbname = "ColomboDBTest" Then
            btnCheckStock.Enabled = False
            btnCustomerItems.Enabled = False
            btnSpecialCharges.Enabled = False
            btnAltItems.Enabled = False
            ref_stnoid.Visible = False
            st_reorder_bal_kg.Visible = False
        End If

    End Sub

    Private Sub checkUserAccess()
        'Dim objSecurity As New classSecurity
        Dim objSecurity As New clsConfig
        'objSecurity.LoadMenus(UserInfo.UserID)

        btnNew.Enabled = objSecurity.UserAccess(UserInfo.UserID, "SO0030", "NEW")
        'btnSave.Enabled = objSecurity.UserAccess(UserInfo.UserID, "SO0030", "SAVE")
        btnPrint.Enabled = objSecurity.UserAccess(UserInfo.UserID, "SO0030", "PRINT")
        'btnPrint.Enabled = objSecurity.UserAccess(UserInfo.UserID, "SO0030", "PRINT")
        btnCancel.Enabled = objSecurity.UserAccess(UserInfo.UserID, "SO0030", "DELETE")
        btnSearch.Enabled = objSecurity.UserAccess(UserInfo.UserID, "SO0030", "SEARCH")

        'If objSecurity.UserAccess(UserInfo.UserID, "SO0030", "MENU") Then
        'ComboSaleOrderType1.SelectedValue = "SRP"
        'ComboSaleOrderType1.Enabled = False
        'End If

    End Sub
    Private Sub SetdefaultSo_typeByUserID()
        If clsUser Is Nothing OrElse String.IsNullOrWhiteSpace(clsUser.UserID) Then
            HadRight = False
            Exit Sub
        End If

        Dim clsSO As New classSalesOrder
        Dim dt As DataTable = clsSO.GetSo_TypeFromUserId(Strentitytype:="ORDERTYPE", Struserid:=clsUser.UserID)
        If dt.Rows.Count > 0 Then
            HadRight = True 'Sitthana 20190624
            If dt.Rows(0)("entityitem").ToString.Trim = "SRP" Then
                ComboSaleOrderType1.SelectedValue = "SRP"
                'ComboSaleOrderType1.Enabled = False
            Else
                Me.ComboSaleOrderType1.SelectedValue = "CUSTORDER"
                ComboSaleOrderType1.Enabled = True 'Sitthana 20241210
            End If
        Else
            'Being 'Sitthana 20190624
            HadRight = False
            btnNew.Enabled = False
            btnSearch.Enabled = False
            btnSave.Enabled = False
            btnCancel.Enabled = False
            tsbConfirmOrder.Enabled = False
            tsbUnConfirmOrder.Enabled = False
            ComboSaleOrderType1.Enabled = True 'Sitthana 20241210
            'End 'Sitthana 20190624
            MessageBox.Show("คุณไม่มีสิทธิ์ สร้าง/แก้ไข Sales Order ครับ", "ผลการตรวจสอบสิทธิ์", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub frmSalesOrder_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If IsDataChange() Then Call btnSave_Click(sender, e)
        e.Cancel = blnCancel
    End Sub

    Private Sub btnNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNew.Click
        Me.tabCustomer.Show()
        'CaseCopy = False
        If IsDataChange() Then Call btnSave_Click(sender, e)
        If Not blnCancel Then Call InitControl()
    End Sub

    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
        Dim f As New Classes.frmSearchSoNo
        Dim drv As DataRowView
        Dim SearchResult As New Classes.SearchFormResult
        ' pass nothing to use default connection string inside the class or pass your connection object if need to use different from default.
        f.setConnectionString(Nothing)
        f.logempcd = clsUser.UserName
        SearchResult = f.ShowFrm
        f.Close()
        f.Dispose()
        If SearchResult.ButtonClicked = "OK" Then
            drv = SearchResult.ResultRowView
            txtSoNo.Text = drv.Item("sono")
            getSoData()
        End If

        'Dim frm As New frmSalesOrderSearch
        'frm.UserInfo = clsUser
        'frm.ShowDialog(Me)
        'Me.Cursor = Cursors.WaitCursor
        'If frm.pblnOk = True Then
        '    'Call btnNew_Click(sender, e)
        '    If Not blnCancel Then LoadData(frm.pSoNo)
        'End If
        'Me.Cursor = Cursors.Default
        'frm.Dispose()
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Dim clsconfig As New clsConfig
        If grdSalesOrder.Focus Then
            txtSoNo.Focus() 'Fix Bug User 
        End If

        blnCancel = False
        Dim result As System.Windows.Forms.DialogResult
        result = MessageBox.Show("Would you like to save ?" & vbCrLf &
        IIf(IIf(strSoNo.Trim.Length = 0, txtSoNo.Text.Trim, strSoNo).ToString.Trim.Length = 0, "** กรุณากรอก S/O No. ระบบจะสร้างอัตโนมัติ **", "S/O No. = '" & IIf(strSoNo.Trim.Length = 0, txtSoNo.Text.Trim, strSoNo) & "'"),
        "System Message", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button3)
        If result = System.Windows.Forms.DialogResult.Cancel Then blnCancel = True
        If result <> System.Windows.Forms.DialogResult.Yes Then Exit Sub

        If CaseCopy = False Then
            CreateOrUpdateSoNo()
        Else
            Dim dt As DataTable
            dt = grdSalesOrder.DataSource
            For i As Integer = 0 To grdSalesOrder.RowCount - 2
                'MsgBox(dt.Rows(i)("sonoid").ToString)
            Next
        End If


    End Sub
    Private Sub tsbtnCopySO_Click(sender As Object, e As EventArgs) Handles tsbtnCopySO.Click

        Dim result As System.Windows.Forms.DialogResult
        result = MessageBox.Show("Would you like to copy S/O ?",
        "System Message", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button3)

        If result = System.Windows.Forms.DialogResult.Cancel Then blnCancel = True
        If result <> System.Windows.Forms.DialogResult.Yes Then Exit Sub

        If Not CheckDataCopySo() Then Exit Sub

        Dim sono As String = txtSoNo.Text.Trim

        If CopySo(sender, e) Then
            MessageBox.Show(
              "S/O No. " & sono & " copied successfully." & vbCrLf &
              "Please click Save to save the changes.",
              "System Message",
              MessageBoxButtons.OK,
              MessageBoxIcon.Information
            )
        End If

        'If MessageBox.Show("คุณยืนยันที่จะสร้าง So No ใหม่ " & vbCr & Space(3) & "โดยคัดลอกข้อมูลจาก So No : " & txtSoNo.Text.Trim & " ใช่ไหม ?" _
        '                 , "ยืนยันการ สร้างใหม่โดยคัดลอกข้อมูลจากต้นแบบ" _
        '                 , MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2
        '                   ) = vbOK Then
        '    CaseCopy = True
        '    blnCancel = False
        '    strSoNo = ""
        '    txtSoNo.Text = strSoNo
        '    txtRevise.Text = "0"
        '    For i As Integer = 0 To grdSalesOrder.RowCount - 1
        '        grdSalesOrder.Rows(i).Cells("sonoid").Value = ""
        '    Next
        '    tsbtnCopySO.Enabled = False
        '    'CreateOrUpdateSoNo()
        '    'CaseCopy = False
        'Else
        '    MessageBox.Show("ยกเลิกการสร้าง So No ใหม่แล้ว", "ตั้งผลการสร้างใหม่โดยคัดลอกข้อมูลจากต้นแบบ", MessageBoxButtons.OK, MessageBoxIcon.Information)
        'End If
    End Sub
    Private Function CheckDataCopySo() As Boolean
        If txtSoNo.Text.Trim.Length = 0 Then
            MessageBox.Show("This S/O No. is Empty", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Return False
        End If

        Return True
    End Function
    Private Function CopySo(sender As System.Object, e As System.EventArgs) As Boolean
        ' Try

        Dim Sono As String = txtSoNo.Text.Trim
        '========= Copy Data =========='
        Dim dtCopy As DataTable = (New classSalesOrder).GetCopySoitm(strSoNo:=Sono)
        '========= Clear Data ========='
        Call btnNew_Click(sender:=sender, e:=e)
        '========= Loop Copy Data ====='
        Dim dtOld As DataTable = TryCast(grdSalesOrder.DataSource, DataTable)

        If dtOld Is Nothing Then
            MessageBox.Show("Data source not found", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End If

        ' Dim drOldNewRow As DataRow
        For Each drCopy As DataRow In dtCopy.Rows

            Dim drNew As DataRow = dtOld.NewRow

            For Each dcOld As DataColumn In dtOld.Columns

                For Each dcCopy As DataColumn In dtCopy.Columns

                    If dcOld.ColumnName.Trim <> "ref_stnoid" AndAlso dtCopy.Columns.Contains(dcOld.ColumnName) Then
                        drNew(dcOld.ColumnName) = drCopy(dcOld.ColumnName)
                    End If

                Next
            Next

            dtOld.Rows.Add(drNew)
        Next

        If dtOld.Rows.Count > 0 Then
            Call BindData(dtOld)
        End If

        '  Catch ex As Exception
        '  MessageBox.Show("Copy S/O Not Success", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
        '  Return False
        '  End Try

        Return True
    End Function
    Private Sub CreateOrUpdateSoNo()
        'Sitthana 20190624
        If Not CheckData() Then Exit Sub
        Me.Cursor = Cursors.WaitCursor
        If SaveData() Then
            LoadData(strSoNo)
            'Call GenComboSoNo()
            tsbtnCopySO.Enabled = False
        End If
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub tsmnPrintSO_Click(sender As Object, e As EventArgs) Handles tsmnPrintSO.Click
        setupReport("rptSOConfirm.rpt", "SO")
    End Sub

    Private Sub tsmnPrintQSR_Click(sender As Object, e As EventArgs) Handles tsmnPrintQSR.Click
        setupReport("rptSOConfirm_Remark.rpt", "QSR")
    End Sub

    Private Sub tsmnPrintProformaInvoice_Click(sender As Object, e As EventArgs) Handles tsmnPrintProformaInvoice.Click
        setupReport("rptSOConfirm.rpt", "PFM")
    End Sub

    Private Sub btnPrintSR_Click(sender As Object, e As EventArgs) Handles btnPrintSR.Click
        'printSRReport("rptSampleRequest.rpt")
        setupReport("rptSampleRequest.rpt", "SMR")
    End Sub

    Private Sub setupReport(rptFileName As String, pRptType As String)
        If strSoNo = "" Then strSoNo = txtSoNo.Text.Trim.ToUpper
        If strSoNo.Length = 0 Then Exit Sub
        'Const rptFileName = "rptSOConfirm.rpt"  'Comment by Sitthana 21/03/2018

        If clsUser.ReportPath = "" Then clsUser.ReportPath = clsUser.ReportPath
        If Not oConfig.CheckReport(clsUser.ReportPath, rptFileName, False) Then
            'Try
            '    Dim rpt As New rptSOConfirm
            '    printReport(rpt)
            'Catch ex As Exception
            '    MsgBox(ex.Message)
            '    Exit Sub
            'End Try
        Else
            Dim rpt As New CrystalDecisions.CrystalReports.Engine.ReportDocument
            Me.Cursor = Cursors.WaitCursor
            'rpt.Load(clsUser.ReportPath & rptFileName)
            'Dim frm As New frmReport
            rpt.Load(clsUser.ReportPath & rptFileName)
            printReport(rpt, pRptType)
        End If
    End Sub

    Private Sub printReport(ByRef rpt As CrystalDecisions.CrystalReports.Engine.ReportDocument, pRptType As String)
        Dim frm As New frmReport

        frm.Title = "Sales Order"
        frm.CRViewer.ReportSource = rpt
        frm.MdiParent = Me.ParentForm

        Dim logonInfo As New CrystalDecisions.Shared.TableLogOnInfo
        Me.Cursor = Cursors.WaitCursor

        logonInfo.ConnectionInfo.ServerName = clsConn.servername
        logonInfo.ConnectionInfo.DatabaseName = clsConn.database
        logonInfo.ConnectionInfo.IntegratedSecurity = False
        logonInfo.ConnectionInfo.UserID = clsConn.Userid
        logonInfo.ConnectionInfo.Password = clsConn.Password

        If UCase((New classConnection).database) = "KARISMA" Then
            rpt.Subreports(0).Database.Tables(0).ApplyLogOnInfo(logonInfo)
            rpt.DataSourceConnections.Item(0).SetConnection(clsConn.servername, clsConn.database, False)
            rpt.DataSourceConnections.Item(0).SetLogon(clsConn.Userid, clsConn.Password)
        Else
            'rpt.Database.Tables(0).ApplyLogOnInfo(logonInfo)
            rpt.DataSourceConnections.Item(0).SetConnection(clsConn.servername, clsConn.database, False)
            rpt.DataSourceConnections.Item(0).SetLogon(clsConn.Userid, clsConn.Password)

        End If
        'rpt.VerifyDatabase()

        rpt.SetParameterValue("@sono", strSoNo)
        rpt.SetParameterValue("@datefr", "")
        rpt.SetParameterValue("@dateto", "")
        rpt.SetParameterValue("@custcd", "")
        rpt.SetParameterValue("@print_performa", False)
        rpt.SetParameterValue("@use_show_price", False)
        rpt.SetParameterValue("@print_yield", False)

        If UCase((New classConnection).database) = "KARISMA" Then
            rpt.DataDefinition.ParameterFields("@sono", rpt.Subreports(0).Name).ApplyCurrentValues(rpt.ParameterFields("@sono").CurrentValues)
            rpt.DataDefinition.ParameterFields("@datefr", rpt.Subreports(0).Name).ApplyCurrentValues(rpt.ParameterFields("@datefr").CurrentValues)
            rpt.DataDefinition.ParameterFields("@dateto", rpt.Subreports(0).Name).ApplyCurrentValues(rpt.ParameterFields("@dateto").CurrentValues)
            rpt.DataDefinition.ParameterFields("@custcd", rpt.Subreports(0).Name).ApplyCurrentValues(rpt.ParameterFields("@custcd").CurrentValues)
            rpt.DataDefinition.ParameterFields("@print_performa", rpt.Subreports(0).Name).ApplyCurrentValues(rpt.ParameterFields("@print_performa").CurrentValues)
            rpt.DataDefinition.ParameterFields("@use_show_price", rpt.Subreports(0).Name).ApplyCurrentValues(rpt.ParameterFields("@use_show_price").CurrentValues)
            rpt.DataDefinition.ParameterFields("@print_yield", rpt.Subreports(0).Name).ApplyCurrentValues(rpt.ParameterFields("@print_yield").CurrentValues)
        Else
            If pRptType = "PFM" Then
                rpt.SetParameterValue("@print_performa", 1)
            Else
                rpt.SetParameterValue("@print_performa", 0)
            End If
        End If

        If UCase((New classConnection).database) = "KARISMA" Then
            rpt.PrintOptions.PaperSize = CrystalDecisions.Shared.PaperSize.PaperLetter
            rpt.PrintOptions.PaperOrientation = CrystalDecisions.Shared.PaperOrientation.Landscape
            rpt.PrintOptions.PaperSource = CrystalDecisions.Shared.PaperSource.Auto
        Else
            rpt.PrintOptions.PaperSize = CrystalDecisions.Shared.PaperSize.PaperA4
            rpt.PrintOptions.PaperOrientation = CrystalDecisions.Shared.PaperOrientation.Portrait
            rpt.PrintOptions.PaperSource = CrystalDecisions.Shared.PaperSource.Auto
        End If

        frm.Show()
        'obj.SetDataSource(dt)
        'obj.Subreports(0).SetDataSource(dt)

        Me.Cursor = Cursors.Default

    End Sub

    Private Sub _printReport(ByRef rpt As CrystalDecisions.CrystalReports.Engine.ReportDocument)
        Dim frm As New frmReport
        Dim logonInfo As New CrystalDecisions.Shared.TableLogOnInfo
        Me.Cursor = Cursors.WaitCursor
        logonInfo.ConnectionInfo.ServerName = clsConn.servername
        logonInfo.ConnectionInfo.DatabaseName = clsConn.database
        logonInfo.ConnectionInfo.IntegratedSecurity = False
        logonInfo.ConnectionInfo.UserID = clsConn.Userid
        logonInfo.ConnectionInfo.Password = clsConn.Password

        rpt.Subreports(0).Database.Tables(0).ApplyLogOnInfo(logonInfo)
        rpt.DataSourceConnections.Item(0).SetConnection(clsConn.servername, clsConn.database, False)
        rpt.DataSourceConnections.Item(0).SetLogon(clsConn.Userid, clsConn.Password)

        rpt.VerifyDatabase()
        rpt.SetParameterValue("@sono", strSoNo)
        rpt.SetParameterValue("@datefr", "")
        rpt.SetParameterValue("@dateto", "")
        rpt.SetParameterValue("@custcd", "")
        rpt.SetParameterValue("@print_performa", False)
        rpt.SetParameterValue("@use_show_price", False)

        rpt.DataDefinition.ParameterFields("@sono", rpt.Subreports(0).Name).ApplyCurrentValues(rpt.ParameterFields("@sono").CurrentValues)
        rpt.DataDefinition.ParameterFields("@datefr", rpt.Subreports(0).Name).ApplyCurrentValues(rpt.ParameterFields("@datefr").CurrentValues)
        rpt.DataDefinition.ParameterFields("@dateto", rpt.Subreports(0).Name).ApplyCurrentValues(rpt.ParameterFields("@dateto").CurrentValues)
        rpt.DataDefinition.ParameterFields("@custcd", rpt.Subreports(0).Name).ApplyCurrentValues(rpt.ParameterFields("@custcd").CurrentValues)
        rpt.DataDefinition.ParameterFields("@print_performa", rpt.Subreports(0).Name).ApplyCurrentValues(rpt.ParameterFields("@print_performa").CurrentValues)
        rpt.DataDefinition.ParameterFields("@use_show_price", rpt.Subreports(0).Name).ApplyCurrentValues(rpt.ParameterFields("@use_show_price").CurrentValues)

        rpt.PrintOptions.PaperSize = CrystalDecisions.Shared.PaperSize.PaperLetter
        rpt.PrintOptions.PaperOrientation = CrystalDecisions.Shared.PaperOrientation.Landscape
        rpt.PrintOptions.PaperSource = CrystalDecisions.Shared.PaperSource.Auto

        frm.Title = "Sales Order"
        frm.CRViewer.ReportSource = rpt
        frm.MdiParent = Me.ParentForm
        frm.Show()
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub old_print_click()
        If strSoNo = "" Then strSoNo = txtSoNo.Text.Trim.ToUpper
        If strSoNo.Length = 0 Then Exit Sub
        Const rptFileName = "rptSO.rpt"
        If clsUser.ReportPath = "" Then clsUser.ReportPath = clsUser.ReportPath
        If Not oConfig.CheckReport(clsUser.ReportPath, rptFileName) Then Exit Sub
        Dim frm As New frmReport
        Dim rpt As New CrystalDecisions.CrystalReports.Engine.ReportDocument
        Dim logonInfo As New CrystalDecisions.Shared.TableLogOnInfo
        Me.Cursor = Cursors.WaitCursor
        logonInfo.ConnectionInfo.ServerName = clsConn.servername
        logonInfo.ConnectionInfo.DatabaseName = clsConn.database
        logonInfo.ConnectionInfo.IntegratedSecurity = False
        logonInfo.ConnectionInfo.UserID = clsConn.Userid
        logonInfo.ConnectionInfo.Password = clsConn.Password

        rpt.Load(clsUser.ReportPath & rptFileName)
        rpt.Subreports(0).Database.Tables(0).ApplyLogOnInfo(logonInfo)
        rpt.DataSourceConnections.Item(0).SetConnection(clsConn.servername, clsConn.database, False)
        rpt.DataSourceConnections.Item(0).SetLogon(clsConn.Userid, clsConn.Password)
        rpt.VerifyDatabase()
        rpt.SetParameterValue("@sono", strSoNo)
        rpt.SetParameterValue("@datefr", "")
        rpt.SetParameterValue("@dateto", "")
        rpt.SetParameterValue("@custcd", "")
        rpt.SetParameterValue("@print_performa", False)
        rpt.SetParameterValue("@use_show_price", False)

        rpt.DataDefinition.ParameterFields("@sono", rpt.Subreports(0).Name).ApplyCurrentValues(rpt.ParameterFields("@sono").CurrentValues)
        rpt.DataDefinition.ParameterFields("@datefr", rpt.Subreports(0).Name).ApplyCurrentValues(rpt.ParameterFields("@datefr").CurrentValues)
        rpt.DataDefinition.ParameterFields("@dateto", rpt.Subreports(0).Name).ApplyCurrentValues(rpt.ParameterFields("@dateto").CurrentValues)
        rpt.DataDefinition.ParameterFields("@custcd", rpt.Subreports(0).Name).ApplyCurrentValues(rpt.ParameterFields("@custcd").CurrentValues)
        rpt.DataDefinition.ParameterFields("@print_performa", rpt.Subreports(0).Name).ApplyCurrentValues(rpt.ParameterFields("@print_performa").CurrentValues)
        rpt.DataDefinition.ParameterFields("@use_show_price", rpt.Subreports(0).Name).ApplyCurrentValues(rpt.ParameterFields("@use_show_price").CurrentValues)

        rpt.PrintOptions.PaperSize = CrystalDecisions.Shared.PaperSize.PaperLetter
        rpt.PrintOptions.PaperOrientation = CrystalDecisions.Shared.PaperOrientation.Landscape
        rpt.PrintOptions.PaperSource = CrystalDecisions.Shared.PaperSource.Auto

        frm.Title = "Sales Order"
        frm.CRViewer.ReportSource = rpt
        frm.MdiParent = Me.ParentForm
        frm.Show()
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub printSRReport(pRptFileName As String)
        If clsUser.ReportPath = "" Then clsUser.ReportPath = clsUser.ReportPath
        Dim rpt As New CrystalDecisions.CrystalReports.Engine.ReportDocument
        rpt.Load(clsUser.ReportPath & pRptFileName)


        Dim frm As New frmReport

        frm.Title = "Sample Request"
        frm.CRViewer.ReportSource = rpt
        frm.MdiParent = Me.ParentForm

        Dim logonInfo As New CrystalDecisions.Shared.TableLogOnInfo
        Me.Cursor = Cursors.WaitCursor

        logonInfo.ConnectionInfo.ServerName = clsConn.servername
        logonInfo.ConnectionInfo.DatabaseName = clsConn.database
        logonInfo.ConnectionInfo.IntegratedSecurity = False
        logonInfo.ConnectionInfo.UserID = clsConn.Userid
        logonInfo.ConnectionInfo.Password = clsConn.Password

        rpt.DataSourceConnections.Item(0).SetConnection(clsConn.servername, clsConn.database, False)
        rpt.DataSourceConnections.Item(0).SetLogon(clsConn.Userid, clsConn.Password)

        rpt.SetParameterValue("@sono", strSoNo)

        frm.Show()

        Me.Cursor = Cursors.Default

    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        'If strSoNo.Trim.Length = 0 Then Exit Sub Else Call btnSave_Click(sender, e)
        If blnCancel Then Exit Sub
        Dim objDB As New classSalesOrder
        If Not lblCancelled.Visible Then
            If MessageBox.Show("Would you Like To cancel this document ?", "System Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = DialogResult.No Then Exit Sub
            Call objDB.SOCancel(strSoNo, clsUser.UserID)
            Call btnNew_Click(sender, e)
        Else
            If MessageBox.Show("Would you Like To uncancel this document ?", "System Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = DialogResult.No Then Exit Sub
            Call objDB.SOUnCancelled(strSoNo, clsUser.UserID)
            Call getSoData()
            'Call btnNew_Click(sender, e)
            ' MessageBox.Show("This document Is already cancelled." & vbCrLf & "Can't cancel anymore.", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            ' Exit Sub
        End If
    End Sub

    Private Sub btnMinimized_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMinimized.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        'Dim ex_rate As New ExchangeRate.DOTSCurrencyExchange
        'MessageBox.Show(ex_rate.GetExchangeRate("USD", "USD", "").ExchangeRate.ToString, "System Message", MessageBoxButtons.OK)
        If MessageBox.Show("Would you like to exit ?", "System Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = System.Windows.Forms.DialogResult.Yes Then Me.Close()
    End Sub

    'Private Sub cboSoNo_DropDownClosed(ByVal sender As Object, ByVal e As System.EventArgs)
    '    'On Error Resume Next
    '    Dim SoNo As String
    '    SoNo = cboSoNo.ComboBox.SelectedValue
    '    If SoNo Is Nothing Then
    '        SoNo = ""
    '    End If

    '    If SoNo.Trim.Length > 0 Then
    '        If Not CustomerComboDone Then loadCustomerCombo()
    '        If Not DeliveryComboDone Then loadDeliveryCombo()
    '        Call btnNew_Click(sender, e)
    '        If Not blnCancel Then LoadData(SoNo)
    '        CaseCopy = False
    '    End If

    'End Sub

    Private Sub getSoData()
        Dim SoNo As String = ""
        'If Not SonoComboDone Then GenComboSoNo()
        If Not CustomerComboDone Then loadCustomerCombo()
        If Not DeliveryComboDone Then loadDeliveryCombo()
        SonoComboDone = True
        CustomerComboDone = True
        DeliveryComboDone = True

        SoNo = txtSoNo.Text.Trim.ToUpper
        'Call btnNew_Click(sender, e)
        Call btnNew_Click(Nothing, Nothing)
        If Not blnCancel Then LoadData(SoNo)
    End Sub

    Private Sub txtSoNo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtSoNo.KeyPress
        Dim SoNo As String = ""
        If Asc(e.KeyChar) = 13 Then
            'If Not SonoComboDone Then GenComboSoNo()
            If Not CustomerComboDone Then loadCustomerCombo()
            If Not DeliveryComboDone Then loadDeliveryCombo()
            SonoComboDone = True
            CustomerComboDone = True
            DeliveryComboDone = True

            SoNo = txtSoNo.Text.Trim.ToUpper
            Call btnNew_Click(sender, e)
            If Not blnCancel Then LoadData(SoNo)
        End If
    End Sub

    Private Sub grdSalesOrder_CellValueChanged(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles grdSalesOrder.CellValueChanged
        Dim obj As New classMaster
        Dim designNo As String
        If e.RowIndex < 0 Or e.ColumnIndex < 0 Then Exit Sub
        If grdSalesOrder.Columns(e.ColumnIndex).Name = "qty" Or
         grdSalesOrder.Columns(e.ColumnIndex).Name = "price" Or
         grdSalesOrder.Columns(e.ColumnIndex).Name = "discamt" Then
            grdSalesOrder.Rows(e.RowIndex).Cells("gr_itamt").Value = Val(oConfig.IsNull(grdSalesOrder.Rows(e.RowIndex).Cells("qty").Value, 0)) * Val(oConfig.IsNull(grdSalesOrder.Rows(e.RowIndex).Cells("price").Value, 0))
            grdSalesOrder.Rows(e.RowIndex).Cells("nt_itamt").Value = Val(oConfig.IsNull(grdSalesOrder.Rows(e.RowIndex).Cells("gr_itamt").Value, 0)) - Val(oConfig.IsNull(grdSalesOrder.Rows(e.RowIndex).Cells("discamt").Value, 0))
            Call SumGrid()
        End If
        If grdSalesOrder.Columns(e.ColumnIndex).Name = "curr" Then
            'If clsConfig.IsNull(grdSalesOrder.Rows(e.RowIndex).Cells("curr").Value, "") = "USD" Then grdSalesOrder.Rows(e.RowIndex).Cells("exrt").Value = FormatNumber(clsUser.ExchangeRate, 4)
            'If clsConfig.IsNull(grdSalesOrder.Rows(e.RowIndex).Cells("curr").Value, "") = "THB" Then grdSalesOrder.Rows(e.RowIndex).Cells("exrt").Value = FormatNumber(1, 4)
            With grdSalesOrder
                Select Case oConfig.IsNull(.Rows(e.RowIndex).Cells("curr").Value, "").ToString.ToUpper
                    Case "USD"
                        .Rows(e.RowIndex).Cells("exrt").Value = FormatNumber(clsUser.ExchangeRate, 4)
                    Case "JPY"
                        .Rows(e.RowIndex).Cells("exrt").Value = FormatNumber(clsUser.ExchangeRateJPY, 4)
                    Case "AUD"
                        .Rows(e.RowIndex).Cells("exrt").Value = FormatNumber(clsUser.ExchangeRateAUD, 4)
                    Case "CHF"
                        .Rows(e.RowIndex).Cells("exrt").Value = FormatNumber(clsUser.ExchangeRateCHF, 4)
                    Case "EUR"
                        .Rows(e.RowIndex).Cells("exrt").Value = FormatNumber(clsUser.ExchangeRateEUR, 4)
                    Case "HKD"
                        .Rows(e.RowIndex).Cells("exrt").Value = FormatNumber(clsUser.ExchangeRateHKD, 4)
                    Case "RMB"
                        .Rows(e.RowIndex).Cells("exrt").Value = FormatNumber(clsUser.ExchangeRateRMB, 4)
                    Case "CNY"
                        .Rows(e.RowIndex).Cells("exrt").Value = FormatNumber(clsUser.ExchangeRateCNY, 4)
                    Case "THB"
                        .Rows(e.RowIndex).Cells("exrt").Value = FormatNumber(clsUser.ExchangeRate, 4)
                End Select
            End With 'Sitthana 20240913
        End If
        If grdSalesOrder.Columns(e.ColumnIndex).Name = "design_no" Then
            designNo = (New clsConfig).IsNull(grdSalesOrder.Rows(e.RowIndex).Cells("design_no").Value, "")
            grdSalesOrder.Rows(e.RowIndex).Cells("colrefdesno").Value = obj.GetArticle(designNo)
            grdSalesOrder.Rows(e.RowIndex).Cells("colgmpersqm").Value = obj.GetGmPerSqm(designNo)
            grdSalesOrder.Rows(e.RowIndex).Cells("Fwth").Value = obj.GetFWth(designNo)

            ' get article no. and show in grid
        End If

        If grdSalesOrder.Columns(e.ColumnIndex).Name = "col" Then
            Dim StrCol As String
            StrCol = grdSalesOrder.Rows(e.RowIndex).Cells("col").Value
            grdSalesOrder.Rows(e.RowIndex).Cells("custcol").Value = obj.GetCustCol(StrCol)
        End If
    End Sub

    Private Sub cboCustomer_DropDownClosed(ByVal sender As Object, ByVal e As System.EventArgs)
        bindCustomerBillToData()
    End Sub

    Private Sub grdSalesOrder_DataError(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewDataErrorEventArgs) Handles grdSalesOrder.DataError
        'MessageBox.Show("Data error, please check your value !!", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
        'e.Cancel = True
    End Sub

    Private Sub chkSpecial2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkSpecial2.CheckedChanged
        If Me.chkSpecial2.Checked = True Then
            Me.chkStockOrder.Checked = False
            Me.chkDevlOrder.Checked = False
            Me.chkClearOrder.Checked = False
        End If
    End Sub

    Private Sub chkDevlOrder_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkDevlOrder.CheckedChanged
        If Me.chkDevlOrder.Checked = True Then
            Me.chkStockOrder.Checked = False
            Me.chkSpecial2.Checked = False
            Me.chkClearOrder.Checked = False
        End If
    End Sub

    Private Sub chkStockOrder_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkStockOrder.CheckedChanged
        If Me.chkStockOrder.Checked = True Then
            Me.chkSpecial2.Checked = False
            Me.chkDevlOrder.Checked = False
            Me.chkClearOrder.Checked = False
        End If
    End Sub

    Private Sub chkClearOrder_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkClearOrder.CheckedChanged
        If Me.chkClearOrder.Checked = True Then
            Me.chkStockOrder.Checked = False
            Me.chkDevlOrder.Checked = False
            Me.chkSpecial2.Checked = False
        End If
    End Sub

    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles checkBulkAppInternal.CheckedChanged
        If checkBulkAppInternal.Checked = True Then
            chkSpecial1.Checked = False
            optAppByDH.Checked = True
            optAppByDH.Enabled = True
            optAppByMK.Enabled = True
        Else
            optAppByDH.Checked = False
            optAppByMK.Checked = False
            optAppByDH.Enabled = False
            optAppByMK.Enabled = False
        End If
    End Sub

    Private Sub chkSpecial1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkSpecial1.CheckedChanged
        If chkSpecial1.Checked = True Then
            checkBulkAppInternal.Checked = False
            optAppByDH.Checked = False
            optAppByMK.Checked = False
            optAppByDH.Enabled = False
            optAppByMK.Enabled = False
        End If
    End Sub

    Private Sub cboCustomer_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs)
        If Not CustomerComboDone Then
            loadCustomerCombo()
            CustomerComboDone = True
            'GenComboSoNo()
            SonoComboDone = True
            loadDeliveryCombo()
            DeliveryComboDone = True
        End If
    End Sub

    Private Sub cboCustomer_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        bindCustomerBillToData()
    End Sub

    Private Sub loadCustomerCombo()

    End Sub
    Private Sub loadDeliveryCombo()

        'dtCustomersShipToFlag = (New classSalesOrder).getCustomersShipToFlag()
        'bsCustomersShipToFlag.DataSource = dtCustomersShipToFlag
        'Me.mcboCustomersShipToFlag.DataSource = bsCustomersShipToFlag.DataSource
        'Me.mcboCustomersShipToFlag.DisplayMember = "name"
        'Me.mcboCustomersShipToFlag.ValueMember = "custcd"
        'Me.mcboCustomersShipToFlag.Text = ""
        'Me.mcboCustomersShipToFlag.ListBox.Grid.Model.Cols.Hidden(1) = True
        'Me.mcboCustomersShipToFlag.ListBox.Grid.Model.Cols.Hidden(2) = True
        'Me.mcboCustomersShipToFlag.ListBox.Grid.Model.Cols.Hidden(6) = True
        'Me.mcboCustomersShipToFlag.ListBox.Grid.Model.Cols.Hidden(7) = True
        'Me.mcboCustomersShipToFlag.ListBox.Grid.Model.Cols.Hidden(8) = True
        'Me.mcboCustomersShipToFlag.ListBox.Grid.Model.Cols.Hidden(9) = True
        'Me.mcboCustomersShipToFlag.ListBox.Grid.Model.Cols.Hidden(10) = True
        'Me.mcboCustomersShipToFlag.ListBox.Grid.Model.Cols.Hidden(11) = True
        'Me.mcboCustomersShipToFlag.ListBox.Grid.Model.Cols.Hidden(12) = True
        'Me.mcboCustomersShipToFlag.ListBox.Grid.Model.Cols.Hidden(13) = True
        'Me.mcboCustomersShipToFlag.ListBox.Grid.Model.Cols.Hidden(14) = True
        'Me.mcboCustomersShipToFlag.ListBox.Grid.Model.Cols.Hidden(15) = True
        'Me.mcboCustomersShipToFlag.ListBox.Grid.Model.Cols.Hidden(16) = True
        'Me.mcboCustomersShipToFlag.ListBox.Grid.Model.Cols.Hidden(17) = True
        'Me.mcboCustomersShipToFlag.ListBox.Grid.Model.Cols.Hidden(18) = True
        'AddHandler TryCast(mcboCustomersShipToFlag.ListControl, GridListBox).Grid.Model.QueryCellInfo, AddressOf Model_QueryCellInfo2

        'Dim objDB As New classMaster

        ' Me.cboDeliveryLoc.DataSource = objDB.GetCustomer
        'Me.cboDeliveryLoc.DisplayMember = "name2"
        ' Me.cboDeliveryLoc.ValueMember = "new_custcd"

        'Dim dt As DataTable = objDB.GetCustomer
        'Dim dt2 As DataTable = dt.Clone
        'Dim expression As String
        'expression = "active = '1' "
        'Dim foundRows() As DataRow
        'foundRows = dt.Select(expression)
        'For Each row As DataRow In foundRows
        '    dt2.ImportRow(row)
        'Next
        'Me.cboDeliveryLoc.DataSource = dt2
        'Me.cboDeliveryLoc.DisplayMember = "name2"
        'Me.cboDeliveryLoc.ValueMember = "new_custcd"
    End Sub

    Private Sub cboDeliveryLoc_DropDownClosed(ByVal sender As Object, ByVal e As System.EventArgs)
        bindCustomerShipToData()
    End Sub

    Private Sub cboDeliveryLoc_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs)
        If Not DeliveryComboDone Then
            loadDeliveryCombo()
            DeliveryComboDone = True
            'GenComboSoNo()
            SonoComboDone = True
            loadCustomerCombo()
            CustomerComboDone = True
        End If
    End Sub


    Private Sub cboSoNo_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs)
        If Not SonoComboDone Then
            'GenComboSoNo()
            SonoComboDone = True
            loadCustomerCombo()
            CustomerComboDone = True
            loadDeliveryCombo()
            DeliveryComboDone = True
        End If
    End Sub

    'Private Sub cboDeliveryLoc_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    bindCustomerShipToData()
    'End Sub
    Private Sub BindCustomerBillToAddr()
        txtCustAddr.Text = oConfig.IsNull(Me.mcboCustomersBillToFlag.ListBox.Grid.Model(Me.mcboCustomersBillToFlag.SelectedIndex + 1, 5).CellValue, "").ToString
    End Sub
    Private Sub BindCustomerShipToAddr()
        txtDeliAddr.Text = oConfig.IsNull(Me.mcboCustomersShipToFlag.ListBox.Grid.Model(Me.mcboCustomersShipToFlag.SelectedIndex + 1, 5).CellValue, "").ToString
    End Sub
    Private Sub bindCustomerBillToData()
        Dim config As New clsConfig
        Dim i As Integer = 0
        Dim dt As DataTable = bsCustomersBillToFlag.DataSource 'cboCustomer.DataSource
        Dim dt2 As New DataTable
        dt2 = dt.Copy()
        For i = 0 To dt2.Rows.Count - 1
            If dt2.Rows(i)("custcd").ToString.Trim = config.IsNull(Me.mcboCustomersBillToFlag.ListBox.Grid.Model(Me.mcboCustomersBillToFlag.SelectedIndex + 1, 3).CellValue, "").ToString.Trim Then

                cboAgent.SelectedValue = dt2.Rows(i)("new_agcd").ToString.Trim
                txtTermCondition.Text = dt2.Rows(i)("new_payterms").ToString.Trim
                txtCreditDays.Text = dt2.Rows(i)("new_credit").ToString.Trim
                txtDeliveryTerm.Text = dt2.Rows(i)("deli").ToString.Trim
                txtCustAddr.Text = dt2.Rows(i)("custaddr").ToString.Trim()
                txtContact.Text = dt2.Rows(i)("contact").ToString.Trim
                'cboBank1.SelectedValue = dt2.Rows(i)("bank_code").ToString.Trim 'Add By Neung 30/10/2015
                mcboBanks.SelectedValue = dt2.Rows(i)("id_banks") '.ToString.Trim
                Exit For
            End If
        Next

    End Sub
    Private Sub bindCustomerShipToData()
        Dim config As New clsConfig
        Dim i As Integer = 0
        Dim dt As DataTable = bsCustomersShipToFlag.DataSource 'cboDeliveryLoc.DataSource
        ' Dim dt2 As New DataTable
        ' dt2 = dt.Copy()
        'For i = 0 To dt2.Rows.Count - 1
        'If dt2.Rows(i)("custcd").ToString.Trim = config.IsNull(Me.mcboCustomersBillToFlag.ListBox.Grid.Model(Me.mcboCustomersBillToFlag.SelectedIndex + 1, 3).CellValue.ToString, "").ToString.Trim Then
        'txtDeliAddr.Text = dt2.Rows(i)("custaddr").ToString.Trim
        txtTransportBy.Text = oConfig.IsNull(Me.mcboCustomersShipToFlag.ListBox.Grid.Model(Me.mcboCustomersShipToFlag.SelectedIndex + 1, 14).CellValue, "").ToString.Trim
        txtAdditionalLabel.Text = oConfig.IsNull(Me.mcboCustomersShipToFlag.ListBox.Grid.Model(Me.mcboCustomersShipToFlag.SelectedIndex + 1, 15).CellValue, "").ToString.Trim
        txtDeliAddr.Text = oConfig.IsNull(Me.mcboCustomersShipToFlag.ListBox.Grid.Model(Me.mcboCustomersShipToFlag.SelectedIndex + 1, 5).CellValue, "").ToString.Trim

        '          Exit For
        ' End If
        ' Next
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

    Private Sub hidecolumns()
        Dim classcn As New classConnection
        If UCase(classcn.database) = "GEMMASOFT" Then
            colRefdesno.Visible = True
            colGmPerSqM.Visible = True
        Else
            colRefdesno.Visible = False
            colGmPerSqM.Visible = False
        End If

    End Sub

    Private Sub formatSoItemsGrid()
        price.DefaultCellStyle.Format = "####0.0000"
        'show_price.DefaultCellStyle.Format = "####0.0000"
        exrt.DefaultCellStyle.Format = "####0.0000"
    End Sub

    Private Sub Label27_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label27.Click

    End Sub

    Private Sub enableDisableControls()

        If Me.txtSoNo.Text <> "" Then
            If Me.ComboSaleOrderType1.Text.Trim = "" Then
                Me.ComboSaleOrderType1.Enabled = True
            Else
                Me.ComboSaleOrderType1.Enabled = False
            End If 'Sitthana 20241210
        End If

        tsbUnConfirmOrder.Enabled = objSecurity.UserAccess(UserInfo.UserID, "SO0030", "EDIT")
    End Sub


    Private Sub cboAgent_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboAgent.SelectedIndexChanged
        Dim dt As DataTable
        Try
            If Me.cboAgent.SelectedIndex = 0 Then Exit Sub
            dt = (New classMaster).GetAgent(oConfig.IsNull(Me.cboAgent.SelectedValue, "").ToString.Trim)
            If dt.Rows.Count = 0 Then Exit Sub
            Me.lblAgentCommPer.Text = "Std.Comm%: " + dt.Rows(0)("commPer").ToString
            Me.txtAgentCommPer.Text = dt.Rows(0)("commPer").ToString

        Catch ex As Exception
            Exit Sub
        End Try
    End Sub

    Private Sub cboSalesMan_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboSalesMan.SelectedIndexChanged
        Dim dt As DataTable
        Try
            If Me.cboSalesMan.Text.ToString.Trim Is Nothing Then Exit Sub
            dt = (New classMaster).GetEmp(oConfig.IsNull(Me.cboSalesMan.SelectedValue, "").ToString.Trim)
            If dt.Rows.Count = 0 Then Exit Sub
            Me.lblSalesCommPer.Text = "Std.Comm%: " + dt.Rows(0)("CommPer").ToString
            Me.txtSalesCommPer.Text = dt.Rows(0)("commPer").ToString
        Catch ex As Exception
            Exit Sub
        End Try
    End Sub

    Private Sub txtPoNo_Leave(sender As System.Object, e As System.EventArgs) Handles txtPoNo.Leave
        Call CheckDuplicatePO()
    End Sub

    Private Sub ComboSaleOrderType1_DropDownClosed(sender As Object, e As System.EventArgs) Handles ComboSaleOrderType1.DropDownClosed
        Call Setdefaultfulfilment_typeBySo_type()
        If ComboSaleOrderType1.SelectedValue.ToString.Trim.ToUpper = "SR" Then
            'grpSampleRequest.Enabled = True
        Else
            cbbSrTypeId.SelectedIndex = -1
            'grpSampleRequest.Enabled = False
        End If 'Sitthana 20240522
    End Sub

    Private Sub Setdefaultfulfilment_typeBySo_type()
        Dim clsSO As New classSalesOrder
        Dim dt As DataTable = clsSO.Getfulfilment_typeFromSo_Type(ComboSaleOrderType1.SelectedValue)

        If dt.Rows.Count > 0 Then
            cbofulfilment_type.SelectedValue = dt.Rows(0)("lookup_value_id")
        End If
    End Sub

    Private Sub btnCustomerItems_Click(sender As Object, e As EventArgs) Handles btnCustomerItems.Click
        'Sitthana 12/02/2018
        If mcboCustomersBillToFlag.SelectedIndex < 0 Or mcboCustomersBillToFlag.Text.ToString.Trim = "" Then
            MsgBox("คุณต้องเลือกลูกค้าก่อนครับ", MsgBoxStyle.OkOnly, "ข้อผิดพลาด")
            TabControl1.SelectTab(1)
            txtContact.Focus()
            Exit Sub
        End If

        'If grdSalesOrder.Then Then
        '    MsgBox("คุณต้องกรอกข้อมูล Design NO หรือ Customer Design NO ก่อนกลับ", MsgBoxStyle.OkOnly, "ข้อผิดพลาด")
        '    grdSalesOrder.Focus()
        '    txtContact.Focus()
        '    Exit Sub
        'End If

        Dim objfrmSearchSOCustItem As New frmSearchSOCustItem

        With objfrmSearchSOCustItem
            objfrmSearchSOCustItem.CustomerNumber = Me.mcboCustomersBillToFlag.ListBox.Grid.Model(Me.mcboCustomersBillToFlag.SelectedIndex + 1, 3).CellValue  'cboCustomer.SelectedValue
            objfrmSearchSOCustItem.CustomerName = Me.mcboCustomersBillToFlag.ListBox.Grid.Model(Me.mcboCustomersBillToFlag.SelectedIndex + 1, 4).CellValue 'cboCustomer.Text
            If grdSalesOrder.Rows.Count > 1 Then
                objfrmSearchSOCustItem.CustItemNumber = oConfig.IsNull(grdSalesOrder.CurrentRow.Cells("Custdes").Value, "")
                objfrmSearchSOCustItem.OurItemNumber = oConfig.IsNull(grdSalesOrder.CurrentRow.Cells("design_no").Value, "")
            Else
                If grdSalesOrder.IsCurrentCellInEditMode = False Then
                    MsgBox("กรุณา กรอกข้อมูล Design No หรือ Customer Design ว่างที่ว่าง ๆ Grid ก่อนกดปุ่ม Customer ครับ" _
                           & vbCr & "(Please enter the Design No. or Customer Design or space in the grid " _
                           & vbCr & "        before pressing the customer button.)" _
                           , MsgBoxStyle.OkOnly, "ข้อผิดพลาด")
                    Exit Sub
                End If
            End If

        End With

        objfrmSearchSOCustItem.ShowDialog(Me)

        If objfrmSearchSOCustItem.btnSelect = vbOK Then
            With grdSalesOrder
                Try
                    .CurrentRow.Cells("design_no").Value = objfrmSearchSOCustItem.OurItemNumber  ''OurDesignNo
                    .CurrentRow.Cells("Custdes").Value = objfrmSearchSOCustItem.CustItemNumber  ''CustDesignNo
                    .CurrentRow.Cells("fwth").Value = objfrmSearchSOCustItem.FullWidth
                    .CurrentRow.Cells("mtl_customer_items_id").Value = objfrmSearchSOCustItem.mtl_customer_items_id
                    .CurrentRow.Cells("mtl_customer_items_xref_id").Value = objfrmSearchSOCustItem.mtl_customer_items_xref_id
                    '.CurrentRow.Cells("fwth").Value = objfrmSearchSOCustItem.getUseableWidth ''UseableWidth
                    '.CurrentRow.Cells("colGmPerSqM").Value = objfrmSearchSOCustItem.GMPerSQM ''GMPerSQM
                Catch ex As Exception
                    '' MsgBox(ex.Message.ToString)
                End Try
            End With
        End If
        objfrmSearchSOCustItem.Dispose()
    End Sub

    Private Sub grdSalesOrder_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles grdSalesOrder.CellDoubleClick

        'Sitthana Copy From Gemmaknit Site 23/04/2018
        Dim clsMaster As New classMaster 'Sitthana 20200806
        Dim currentColIndex As Integer
        Dim currentColName As String
        Dim dgr As DataGridViewRow
        Dim frmSOSTListSelect As STV.frmSTBOOKINGSelection
        If e.RowIndex < 0 OrElse e.ColumnIndex < 0 Then Exit Sub

        currentColIndex = e.ColumnIndex
        currentColName = grdSalesOrder.Columns(currentColIndex).Name
        dgr = grdSalesOrder.Rows(e.RowIndex)
        If dgr Is Nothing OrElse dgr.IsNewRow Then Exit Sub

        setOrderLineValue(dgr)
        If currentColName = "ref_stnoid" Then

            With grdSalesOrder
                If oConfig.IsNull(dgr.Cells("qty").Value, 0) = 0 Then
                    MessageBox.Show("qty must greater than zero", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
                ElseIf oConfig.IsNull(dgr.Cells("uom").Value, "") = "" Then
                    MessageBox.Show("uom must not blank", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
                ElseIf currentGridDesignNo = "" Then
                    MessageBox.Show("Design must not blank", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
                ElseIf oConfig.IsNull(dgr.Cells("so_line_id").Value, 0) = 0 Then
                    MessageBox.Show("S/O Line Id must not blank", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Else
                    currentGridSoLineID = oConfig.IsNull(dgr.Cells("so_line_id").Value, 0)
                    ' Open ST Booking Web Page
                    Dim url As String = "http://172.16.3.2:3001/STBook/st-booking/" &
    "?so_line_id=" & currentGridSoLineID &
    "&dbname=" & clsConn.database &
    "&logempcd=" & clsUser.UserID &
    "&username=" & Uri.EscapeDataString(clsUser.UserName)
                    Process.Start(url)

                    'frmSOSTListSelect = New STV.frmSTBOOKINGSelection

                    'Dim dbname = (New ClassConnection).database
                    'If dbname = "ColomboDB" OrElse dbname = "ColomboDBTest" Then
                    '    Exit Sub
                    'End If

                    '' frmSOSTListSelect.pConnection = conn 'Sitthana 21/08/2018
                    'frmSOSTListSelect.DesignNo = currentGridDesignNo
                    'frmSOSTListSelect.DemandQty = oConfig.IsNull(.Rows(.CurrentRow.Index).Cells("qty").Value, 0) 'Sitthana 20200806
                    'frmSOSTListSelect.DemandUom = oConfig.IsNull(.Rows(.CurrentRow.Index).Cells("uom").Value, "") 'Sitthana 20200806
                    'frmSOSTListSelect.DemandKgWeight = clsMaster.GetDesignKg(currentGridDesignNo _
                    '                                                      , oConfig.IsNull(.Rows(.CurrentRow.Index).Cells("qty").Value, 1) _
                    '                                                      , oConfig.IsNull(.Rows(.CurrentRow.Index).Cells("uom").Value, "")
                    '                                                        ) 'Sitthana 20200806
                    'frmSOSTListSelect.ShowDialog()
                    'If frmSOSTListSelect.SONOID <> "" Then
                    '    dgr.Cells("ref_stnoid").Value = frmSOSTListSelect.SONOID
                    'End If
                End If 'Sitthana 20200806
            End With
        End If
    End Sub

    Private Sub grdSalesOrder_CellLeave(sender As Object, e As DataGridViewCellEventArgs) Handles grdSalesOrder.CellLeave
        'Sitthana Copy From Gemmaknit Site 23/04/2018
        Dim r As DataGridViewRow
        r = grdSalesOrder.CurrentRow
        setOrderLineValue(r)
    End Sub
    Private Sub setOrderLineValue(r As DataGridViewRow)
        'Sitthana Copy From Gemmaknit Site 23/04/2018
        If r Is Nothing Then Exit Sub

        If r.Cells("design_no").Value Is Nothing OrElse IsDBNull(r.Cells("design_no").Value) Then
            currentGridDesignNo = ""
        Else
            currentGridDesignNo = r.Cells("design_no").Value.ToString
        End If
        If r.Cells("col").Value Is Nothing OrElse IsDBNull(r.Cells("col").Value) Then
            currentGridColorCode = ""
        Else
            currentGridColorCode = r.Cells("col").Value.ToString
        End If
        currentGridQty = 0
        currentGridUom = "KGS"
        currentGridSonoID = ""
        currentGridSoLineID = 0
        If r.Cells("qty").Value IsNot Nothing AndAlso Not IsDBNull(r.Cells("qty").Value) Then
            currentGridQty = r.Cells("Qty").Value.ToString
        End If
        If r.Cells("uom").Value IsNot Nothing AndAlso Not IsDBNull(r.Cells("uom").Value) Then
            currentGridUom = r.Cells("Uom").Value.ToString
        End If
        If r.Cells("sonoid").Value IsNot Nothing AndAlso Not IsDBNull(r.Cells("sonoid").Value) Then
            currentGridSonoID = r.Cells("sonoid").Value.ToString
        End If
        If txtSoNo.Text <> "" Then
            currentGridSono = txtSoNo.Text
        End If
        If r.Cells("so_line_id").Value IsNot Nothing AndAlso Not IsDBNull(r.Cells("so_line_id").Value) Then
            Integer.TryParse(r.Cells("so_line_id").Value.ToString, currentGridSoLineID)
        End If
    End Sub

    Private Sub btnCheckStock_Click(sender As Object, e As EventArgs) Handles btnCheckStock.Click
        Dim dbname = (New classConnection).database
        If dbname = "ColomboDB" OrElse dbname = "ColomboDBTest" Then
            Exit Sub
        End If

        'Sitthana Copy From Gemmaknit Site 23/04/2018
        Dim frm As STV.frmStockAvailabilityViews
        'frm = New STV.frmStockAvailabilityViews(CMBUnitOfMeasure.SelectedValue, txtQtyRequired.Text, txtGradeGreige.Text, txtColor.Text, txtGradeDyed.Text)
        If currentGridDesignNo Is Nothing Then
            MessageBox.Show("Please enter design no. or select an order line")
            Exit Sub
        End If
        frm = New STV.frmStockAvailabilityViews()
        frm.GetDesignno = currentGridDesignNo
        frm.GetUnitofMeasure = currentGridUom
        frm.GetQtyRequired = Conversion.Int(currentGridQty)
        frm.GetColor = currentGridColorCode
        frm.GetGreigeGrade = ""
        frm.GetDyedGrade = ""
        frm.MdiParent = Me.MdiParent

        frm.Show()
    End Sub

    Private Sub btnSpecialCharges_Click(sender As Object, e As EventArgs) Handles btnSpecialCharges.Click
        Dim dbname = (New classConnection).database
        If dbname = "ColomboDB" OrElse dbname = "ColomboDBTest" Then
            Exit Sub
        End If

        'Sitthana Copy From Gemmaknit Site 23/04/2018
        Dim frmsocharges As STV.frmSoCharges
        'frm = New STV.frmStockAvailabilityViews(CMBUnitOfMeasure.SelectedValue, txtQtyRequired.Text, txtGradeGreige.Text, txtColor.Text, txtGradeDyed.Text)
        If currentGridDesignNo Is Nothing Then
            MessageBox.Show("Please enter design no. or select an order line")
            Exit Sub
        End If
        Cursor = Cursors.WaitCursor
        frmsocharges = New STV.frmSoCharges()
        frmsocharges.GetOrderNo = currentGridSono
        frmsocharges.GetOrderLineID = currentGridSonoID
        frmsocharges.GetItemCode = currentGridDesignNo
        frmsocharges.GetColor = currentGridColorCode
        frmsocharges.ShowDialog()
        Cursor = Cursors.Default
    End Sub

    Private Sub btnAltItems_Click(sender As Object, e As EventArgs) Handles btnAltItems.Click
        Dim dbname = (New classConnection).database
        If dbname = "ColomboDB" OrElse dbname = "ColomboDBTest" Then
            Exit Sub
        End If

        Dim frmSOAltItems As STV.frmSOAltItems
        If currentGridDesignNo Is Nothing Then
            MessageBox.Show("Please enter design no. or select an order line")
            Exit Sub
        End If
        frmSOAltItems = New STV.frmSOAltItems()
        frmSOAltItems.GetOrderNo = currentGridSono
        frmSOAltItems.GetOrderLineID = currentGridSoLineID.ToString
        frmSOAltItems.GetItemCode = currentGridDesignNo
        frmSOAltItems.GetColor = currentGridColorCode
        frmSOAltItems.GetOrderSONOID = currentGridSonoID
        frmSOAltItems.ShowDialog()
    End Sub

    Private Sub grdSalesOrder_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles grdSalesOrder.CellContentClick

    End Sub

    Private Sub tsbConfirmOrder_Click(sender As Object, e As EventArgs) Handles tsbConfirmOrder.Click
        Dim classSO As New classSalesOrder
        Dim Result As System.Windows.Forms.DialogResult
        Result = MessageBox.Show("Would you like to comfirmed S/O", "System Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)
        If Result = System.Windows.Forms.DialogResult.Yes Then
            classSO.SOConfirm(txtSoNo.Text, clsUser.UserID)
            LoadData(txtSoNo.Text)
            MessageBox.Show("SO has been confirmed. You cannot edit some information after this step")
        End If

    End Sub

    Private Sub tsbUnConfirmOrder_Click(sender As Object, e As EventArgs) Handles tsbUnConfirmOrder.Click
        Dim classSO As New classSalesOrder
        'Sitthana 20220624 Changed Windows.Forms.DialogResult To DialogResult
        Dim result As DialogResult ' Windows.Forms.DialogResult
        result = MessageBox.Show("Would you like to Uncomfirmed S/O", "System Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)
        If result = DialogResult.Yes Then
            classSO.SOUnConfirm(txtSoNo.Text, clsUser.UserID)
            LoadData(txtSoNo.Text)
            MessageBox.Show("SO has been unconfirmed and set to ENT status")
        End If

    End Sub



    Private Sub mcboCustomersBillToFlag_SelectedIndexChanged(sender As Object, e As EventArgs) Handles mcboCustomersBillToFlag.SelectedIndexChanged
        bsCustomersShipToFlag.Filter = "parent_customer_id = " & Me.mcboCustomersBillToFlag.ListBox.Grid.Model(Me.mcboCustomersBillToFlag.SelectedIndex + 1, 1).CellValue & "" 'Disible By Neung K.Piew No Need to Filter Cust Deli

        ' Refresh the customer's price list to match the selected Bill To customer -- John 25/09/2026
        ' By name, not column index, so this can't silently break if
        ' P_SO_FORM_PKG_get_customers_bill_to_flag's column order ever changes.
        ' (The Ship-To filter above intentionally uses parent_customer_id instead --
        ' a different field, not interchangeable with customer_id.) -- John 01/10/2026
        Dim objDB As New classMaster
        Dim custIdCell As Object = Me.mcboCustomersBillToFlag.ListBox.Grid.Model(Me.mcboCustomersBillToFlag.SelectedIndex + 1, "customer_id").CellValue
        Dim custId As Nullable(Of Int64) = Nothing
        If custIdCell IsNot Nothing AndAlso Not IsDBNull(custIdCell) Then custId = Convert.ToInt64(custIdCell)
        Me.cboPriceListCustomer.DataSource = objDB.getPriceListCustomer(custId)
        Me.cboPriceListCustomer.DisplayMember = "list_name"
        Me.cboPriceListCustomer.ValueMember = "so_price_list_header_id" ' John 01/10/2026 -- was "customer_id", which fed the wrong id into @p_so_price_list_header_id and into the saved so.price_list_header_id

        Call bindCustomerBillToData()
        Call bindCustomerShipToData()
        Call BindCustomerBillToAddr()
        Call BindCustomerShipToAddr()

        'Begin - Sitthana 19/09/2018
        With mcboCustomersBillToFlag
            If .ListBox.Grid.Model(.SelectedIndex + 1, 18).CellValue = "1" Then
                If HadRight Then
                    btnSave.Enabled = True
                    tsbConfirmOrder.Enabled = True
                End If
                lblCustomersActive.Visible = False
            ElseIf .ListBox.Grid.Model(.SelectedIndex + 1, 18).CellValue = "0" Then
                If HadRight Then
                    btnSave.Enabled = False
                    tsbConfirmOrder.Enabled = False
                End If
                lblCustomersActive.Visible = True
                MessageBox.Show("ลูกค้าท่านนี้ ถูกยกเลิกแล้ว " & vbCr _
                          & "   - คุณไม่สามารถสร้าง SO ได้" & vbCr _
                          & "   - คุณสามารถ ยกเลิก แต่ Unconfirm ไม่ได้" _
                          , "ข้อความเตือน", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End With
        'End  - Sitthana 19/09/2018
    End Sub


    Private Sub mcboCustomersShipToFlag_SelectedIndexChanged(sender As Object, e As EventArgs) Handles mcboCustomersShipToFlag.SelectedIndexChanged
        Call bindCustomerShipToData()
        Call BindCustomerShipToAddr()
    End Sub

    Private Sub mcboCustomersBillToFlag_DropDownCloseOnClick(sender As Object, args As MouseClickCancelEventArgs) Handles mcboCustomersBillToFlag.DropDownCloseOnClick
        bsCustomersShipToFlag.Filter = "parent_customer_id = " & Me.mcboCustomersBillToFlag.ListBox.Grid.Model(Me.mcboCustomersBillToFlag.SelectedIndex + 1, 1).CellValue & "" 'Disible By Neung K.Piew No Need to Filter Cust Deli
        Call bindCustomerBillToData()
        Call bindCustomerShipToData()
    End Sub

    Private Sub mcboCustomersShipToFlag_DropDownCloseOnClick(sender As Object, args As MouseClickCancelEventArgs) Handles mcboCustomersShipToFlag.DropDownCloseOnClick
        Call bindCustomerShipToData()
    End Sub

    Private Sub GenCustPo()
        txtPoNo.Text = Trim(txtCustPoUnique.Text) + Trim(txtCustPoSuffix.Text)
    End Sub

    Private Sub btnCustPo_Click(sender As Object, e As EventArgs) Handles btnCustPoUnique.Click
        Dim frm As New frmSalesOrderEnterCustPoUnique
        frm.pCustPoUnique = txtCustPoUnique.Text.Trim
        frm.pSoNo = txtSoNo.Text.Trim
        frm.ShowDialog()

        Me.Cursor = Cursors.WaitCursor
        'If (New clsConfig).IsNull(frm.pCustPoUnique, "") <> "" Then
        If frm.pblnCancel = False Then
            txtCustPoUnique.Text = frm.pCustPoUnique
            Call GenCustPo()
        End If
        Me.Cursor = Cursors.Default
        frm.Dispose()
    End Sub

    Private Sub txtCustPoUnique_TextChanged(sender As Object, e As EventArgs) Handles txtCustPoUnique.TextChanged
        Call GenCustPo()
    End Sub

    Private Sub txtCustPoSuffix_TextChanged(sender As Object, e As EventArgs) Handles txtCustPoSuffix.TextChanged
        Call GenCustPo()
    End Sub

    Private Sub txtCustPoUnique_Leave(sender As Object, e As EventArgs) Handles txtCustPoUnique.Leave
        Call CheckDuplicateCustPoUnique()
    End Sub

    Private Sub btnGetSoNo_Click(sender As Object, e As EventArgs) Handles btnGetSoNo.Click
        Dim f As New Classes.frmSearchSoNo
        Dim drv As DataRowView
        Dim SearchResult As New Classes.SearchFormResult
        ' pass nothing to use default connection string inside the class or pass your connection object if need to use different from default.
        f.setConnectionString(clsConn.getSQLConnection)
        f.logempcd = clsUser.UserName
        SearchResult = f.ShowFrm
        f.Close()
        f.Dispose()
        If SearchResult.ButtonClicked = "OK" Then
            drv = SearchResult.ResultRowView
            txtSoNo.Text = drv.Item("sono")
            getSoData()
        End If

        'Dim frm As New frmSalesOrderSearch
        'frm.UserInfo = clsUser
        'frm.ShowDialog(Me)
        'Me.Cursor = Cursors.WaitCursor
        'If frm.pblnOk = True Then
        '    Call btnNew_Click(sender, e)
        '    If Not blnCancel Then LoadData(frm.pSoNo)
        'End If
        'Me.Cursor = Cursors.Default
        'frm.Dispose()
    End Sub

    Private Sub txtRemark_TextChanged(sender As Object, e As EventArgs) Handles txtRemark.TextChanged 'John 20/10/2025
        Dim pattern As String = "\bJ[0-9][A-Z0-9]{7}\b"
        Dim matches As MatchCollection = Regex.Matches(txtRemark.Text, pattern)

        ' Convert matches to a list of strings
        Dim jobList As List(Of String) = matches.Cast(Of Match).Select(Function(m) m.Value).ToList()

        ' Sort by numeric part (remove "J" and parse remaining as number)
        jobList.Sort(Function(a, b) CLng(a.Substring(1)).CompareTo(CLng(b.Substring(1))))

        ' Fill textboxes in sorted order
        If jobList.Count > 0 Then txtRefJobNo1.Text = jobList(0)
        If jobList.Count > 1 Then txtRefJobNo2.Text = jobList(1)
        If jobList.Count > 2 Then txtRefJobNo3.Text = jobList(2)
        If jobList.Count > 3 Then txtRefJobNo3.Text = jobList(3)
    End Sub
    Private Sub InitDataBinding_GetGridLayoutSettings() 'John 27/10/2025

        dtGridLayoutSettings = oGridLayoutSettings.selectGridLayoutSettings(clsUser.UserID, "grdSalesOrder")

        bsGridLayoutSettings.DataSource = dtGridLayoutSettings
        drvGridLayoutSettings = CType(bsGridLayoutSettings.Current, DataRowView)
    End Sub

    Private Sub applyGridLayoutSettingsToGrid(targetGrid As DataGridView) 'John 27/10/2025
        InitDataBinding_GetGridLayoutSettings()
        If dtGridLayoutSettings Is Nothing OrElse dtGridLayoutSettings.Rows.Count = 0 Then Exit Sub

        For Each row As DataRow In dtGridLayoutSettings.Rows
            Dim colHeader As String = row("column_name").ToString().Trim()
            Dim colVisible As Boolean = False

            If Not IsDBNull(row("col_visible")) AndAlso row("col_visible").ToString().Trim().ToUpper() = "Y" Then
                colVisible = True
            End If

            For Each col As DataGridViewColumn In targetGrid.Columns
                If String.Equals(col.HeaderText.Trim(), colHeader, StringComparison.OrdinalIgnoreCase) Then
                    col.Visible = colVisible
                    If Not IsDBNull(row("col_width")) Then
                        Dim width As Integer
                        If Integer.TryParse(row("col_width").ToString(), width) Then
                            col.Width = width
                        End If
                    End If

                    Exit For
                End If
            Next
        Next
    End Sub

    Private Sub btnGridLayoutSettings_Click(sender As Object, e As EventArgs) Handles btnGridLayoutSettings.Click 'John 27/10/2025
        If autoSave = "Y" Then
            saveSettings()
        End If

        Dim frm As New frmGridLayoutSettings
        frm.pGridName = "grdSalesOrder"
        frm.sourceGrid = grdSalesOrder
        frm.clsUser = clsUser

        If frm.ShowDialog() = DialogResult.OK Then
            dtGridLayoutSettings = frm.dtGridLayoutSettings
            autoSave = "Y"
        End If
    End Sub

    Private Sub btnSaveSettings_Click(sender As Object, e As EventArgs) Handles btnSaveSettings.Click 'John 27/10/2025
        saveSettings()
        MessageBox.Show("Grid Settings Saved Successfully.", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
    End Sub

    Private Sub saveSettings()  'John 27/10/2025
        Dim msgerr As String = ""

        For Each row As DataRow In dtGridLayoutSettings.Rows
            Dim colName As String = row("column_name").ToString().Trim()
            Dim col As DataGridViewColumn = grdSalesOrder.Columns.Cast(Of DataGridViewColumn)() _
                                       .FirstOrDefault(Function(c) String.Equals(c.HeaderText.Trim(), colName, StringComparison.OrdinalIgnoreCase))
            If col IsNot Nothing Then
                row("col_width") = col.Width
                row("col_data_property") = col.DataPropertyName
            End If
        Next

        If oGridLayoutSettings.saveGridLayoutSettings(dtGridLayoutSettings, "grdSalesOrder", msgerr, clsUser.UserID) Then

        Else
            MessageBox.Show("Error saving layout: " & msgerr, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    ''' <summary>
    ''' Blocks editing design no / color / uom / qty until a Price List Customer is
    ''' selected, so nothing can be typed in the first place -- a warning inside
    ''' CellEndEdit is too late, since the value is already committed by then.
    ''' -- John 30/09/2026
    ''' </summary>
    Private Sub grdSalesOrder_CellBeginEdit(sender As Object, e As DataGridViewCellCancelEventArgs) Handles grdSalesOrder.CellBeginEdit
        Dim colName As String = grdSalesOrder.Columns(e.ColumnIndex).Name
        If colName = "design_no" OrElse colName = "col" OrElse colName = "uom" OrElse colName = "qty" Then
            If cboPriceListCustomer.SelectedValue Is Nothing OrElse IsDBNull(cboPriceListCustomer.SelectedValue) Then
                MessageBox.Show("Please select a Price List Customer before editing this!", "Validation Required", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1)
                e.Cancel = True
            End If
        End If

        ' Remember the value this edit session started with, so CellEndEdit can tell a
        ' real change from a session that ended with nothing changed. -- John 05/10/2026
        If Not e.Cancel Then
            _editStartRow = e.RowIndex
            _editStartCol = e.ColumnIndex
            _editStartValue = oConfig.IsNull(grdSalesOrder.Rows(e.RowIndex).Cells(e.ColumnIndex).Value, "").ToString.Trim
        End If
        PriceLineTrace("BeginEdit  r=" & e.RowIndex & " c=" & colName & " cancelled=" & e.Cancel & " startValue='" & _editStartValue & "'")
    End Sub

    ' Value of the cell when its edit session began (see CellBeginEdit / CellEndEdit).
    Private _editStartRow As Integer = -1
    Private _editStartCol As Integer = -1
    Private _editStartValue As String = ""

    ''' <summary>
    ''' True if a price line input cell really changed during an edit session. qty is
    ''' compared as a number (1500 vs 1500.00 is not a change); everything else as text,
    ''' since e.g. design no 0123 and 123 are different designs. -- John 05/10/2026
    ''' </summary>
    Private Function PriceLineInputChanged(colName As String, before As String, after As String) As Boolean
        If colName = "qty" Then
            Dim b As Decimal, a As Decimal
            If Decimal.TryParse(before, b) AndAlso Decimal.TryParse(after, a) Then Return a <> b
        End If
        Return Not String.Equals(before, after, StringComparison.Ordinal)
    End Function

    Private Sub grdSalesOrder_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles grdSalesOrder.CellEndEdit
        If grdSalesOrder.Columns(e.ColumnIndex).Name = "colProdLossPerc" Then 'John 26/03/2026
            Dim qty = grdSalesOrder.Rows(e.RowIndex).Cells("qty").Value
            Dim lossPerc = grdSalesOrder.Rows(e.RowIndex).Cells("colProdLossPerc").Value

            If IsDBNull(qty) OrElse qty = 0 Then
                grdSalesOrder.Rows(e.RowIndex).Cells("colProdLossPerc").Value = 0.0
            Else
                grdSalesOrder.Rows(e.RowIndex).Cells("colQtyWithLoss").Value = Val(oConfig.IsNull(qty, 0)) * (1 + Val(oConfig.IsNull(lossPerc, 0)) / 100)
            End If
        End If

        If grdSalesOrder.Columns(e.ColumnIndex).Name = "qty" Then 'John 26/03/2026
            Dim qty = grdSalesOrder.Rows(e.RowIndex).Cells("qty").Value
            Dim lossPerc = grdSalesOrder.Rows(e.RowIndex).Cells("colProdLossPerc").Value

            If IsDBNull(qty) OrElse qty = 0 Then
                grdSalesOrder.Rows(e.RowIndex).Cells("colProdLossPerc").Value = 0.0
            Else
                grdSalesOrder.Rows(e.RowIndex).Cells("colQtyWithLoss").Value = Val(oConfig.IsNull(qty, 0)) * (1 + Val(oConfig.IsNull(lossPerc, 0)) / 100)
            End If
        End If

        ' Re-check the price line only when one of the inputs to it (design no, color,
        ' uom, qty, curr) actually changed. CellEndEdit also fires for an edit session
        ' that ended with nothing changed -- e.g. a click on the already-selected cell
        ' followed by an arrow key -- which used to reopen the popup. CheckSelectPriceLine
        ' itself still waits until design no, color, uom and qty are all filled.
        ' -- John 29/09/2026, changed 05/10/2026
        Dim endColName As String = grdSalesOrder.Columns(e.ColumnIndex).Name
        If endColName = "design_no" OrElse endColName = "col" OrElse endColName = "uom" OrElse endColName = "qty" OrElse endColName = "curr" Then
            Dim endValue As String = oConfig.IsNull(grdSalesOrder.Rows(e.RowIndex).Cells(e.ColumnIndex).Value, "").ToString.Trim
            Dim sameCell As Boolean = (e.RowIndex = _editStartRow AndAlso e.ColumnIndex = _editStartCol)
            Dim changed As Boolean = sameCell AndAlso PriceLineInputChanged(endColName, _editStartValue, endValue)
            PriceLineTrace("EndEdit    r=" & e.RowIndex & " c=" & endColName & " beginWasSameCell=" & sameCell & " start='" & _editStartValue & "' end='" & endValue & "' -> fires=" & changed)
            If changed Then
                Call CheckSelectPriceLine(e.RowIndex)
            End If
        Else
            PriceLineTrace("EndEdit    r=" & e.RowIndex & " c=" & endColName & " (not a price line input)")
        End If
        _editStartRow = -1
        _editStartCol = -1

        ' grdSalesOrder.Rows(e.RowIndex).ErrorText = ""
    End Sub

    ''' <summary>
    ''' Step 1 of price-line selection: once design no, color, uom and qty are all
    ''' filled on a line, ask SO.P_SO_PRICE_LIST_PKG_select_price_line for the
    ''' matching price line(s) and let the user pick one via frmSelectPriceLine
    ''' (shown every time, even for a single unambiguous match). The chosen
    ''' so_price_list_detail_id is only held in the hidden grid column for now --
    ''' where it ultimately gets saved comes later. -- John 29/09/2026
    ''' </summary>
    ' TEMP DIAGNOSTIC -- John 12/10/2026 -- silent trace to %TEMP%\so_priceline_trace.log
    ' to find why the price line popup stops firing on a second qty edit. Remove after.
    Private Sub PriceLineTrace(msg As String)
        Try
            System.IO.File.AppendAllText(System.IO.Path.Combine(System.IO.Path.GetTempPath(), "so_priceline_trace.log"),
                                         DateTime.Now.ToString("HH:mm:ss.fff") & "  " & msg & vbCrLf)
        Catch
        End Try
    End Sub

    Private Sub CheckSelectPriceLine(rowIndex As Integer)
        If rowIndex < 0 OrElse rowIndex >= grdSalesOrder.Rows.Count Then PriceLineTrace("  CheckSelectPriceLine r=" & rowIndex & ": EXIT bad row index") : Exit Sub

        Dim row As DataGridViewRow = grdSalesOrder.Rows(rowIndex)
        Dim designNo As String = oConfig.IsNull(row.Cells("design_no").Value, "").ToString.Trim
        Dim colorCode As String = oConfig.IsNull(row.Cells("col").Value, "").ToString.Trim
        Dim uom As String = oConfig.IsNull(row.Cells("uom").Value, "").ToString.Trim
        Dim qtyText As String = oConfig.IsNull(row.Cells("qty").Value, "").ToString.Trim
        Dim curr As String = oConfig.IsNull(row.Cells("curr").Value, "").ToString.Trim

        ' Currency is required too: it filters the price lines, so the popup waits until
        ' design no, color, uom, qty and curr are all filled. -- John 12/10/2026
        If designNo = "" OrElse colorCode = "" OrElse uom = "" OrElse qtyText = "" OrElse curr = "" Then
            PriceLineTrace("  CheckSelectPriceLine r=" & rowIndex & ": EXIT blank field  design='" & designNo & "' col='" & colorCode & "' uom='" & uom & "' qty='" & qtyText & "' curr='" & curr & "'")
            Exit Sub
        End If

        Dim qty As Decimal
        If Not Decimal.TryParse(qtyText, qty) Then PriceLineTrace("  CheckSelectPriceLine r=" & rowIndex & ": EXIT qty not a number '" & qtyText & "'") : Exit Sub

        Dim headerId As Nullable(Of Int64) = Nothing
        If cboPriceListCustomer.SelectedValue IsNot Nothing AndAlso Not IsDBNull(cboPriceListCustomer.SelectedValue) Then
            headerId = Convert.ToInt64(cboPriceListCustomer.SelectedValue)
        End If

        ' selectPriceLine needs so_price_list_header_id -- that comes from
        ' cboPriceListCustomer, so don't call the SP without it. -- John 29/09/2026
        If Not headerId.HasValue Then
            PriceLineTrace("  CheckSelectPriceLine r=" & rowIndex & ": EXIT no price list customer selected (warning shown)")
            MessageBox.Show("Please select a Price List Customer before editing this!", "Validation Required", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1)
            Exit Sub
        End If

        PriceLineTrace("  CheckSelectPriceLine r=" & rowIndex & ": calling SP header=" & headerId.Value & " design='" & designNo & "' col='" & colorCode & "' uom='" & uom & "' qty=" & qty & " curr='" & curr & "'")
        Dim dt As DataTable = (New classSalesOrder).selectPriceLine(headerId, designNo, colorCode, uom, qty, curr)
        PriceLineTrace("  CheckSelectPriceLine r=" & rowIndex & ": SP returned " & If(dt Is Nothing, "NOTHING", dt.Rows.Count.ToString & " row(s)"))
        If dt Is Nothing OrElse dt.Rows.Count = 0 Then Exit Sub

        Dim frm As New frmSelectPriceLine
        Dim selectedId As Nullable(Of Int64) = frm.ShowAndSelect(dt, Me)
        Dim selectedPrice As Nullable(Of Decimal) = frm.SelectedPrice
        Dim selectedCurrency As String = frm.SelectedCurrency
        frm.Dispose()
        PriceLineTrace("  CheckSelectPriceLine r=" & rowIndex & ": popup closed selectedId=" & If(selectedId.HasValue, selectedId.Value.ToString, "none (cancelled)") & " price=" & If(selectedPrice.HasValue, selectedPrice.Value.ToString, "none") & " curr='" & selectedCurrency & "'")

        If selectedId.HasValue Then
            row.Cells("so_price_list_detail_id").Value = selectedId.Value
            If selectedPrice.HasValue Then row.Cells("price").Value = selectedPrice.Value
            If Not String.IsNullOrEmpty(selectedCurrency) Then row.Cells("curr").Value = selectedCurrency
        End If
    End Sub

    Private Sub btnViewSTTracking_Click(sender As Object, e As EventArgs) Handles btnViewSTTracking.Click 'John 07/07/2026
        Dim soNo As String = txtSoNo.Text.Trim()

        Dim url As String
        If soNo = "" Then
            url = "http://172.16.3.2:3001/STTracking/"
        Else
            url = "http://172.16.3.2:3001/STTracking/?ocno=" & Uri.EscapeDataString(soNo)
        End If

        Process.Start(New ProcessStartInfo(url) With {.UseShellExecute = True})
    End Sub

    Private Sub txtSampleFabricQty_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtSampleFabricQty.KeyPress
        If Not Char.IsNumber(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) AndAlso Not (Asc(e.KeyChar) = Asc(".")) Then
            MessageBox.Show("You must entry numeric only", "User Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            e.KeyChar = Nothing
        End If
    End Sub

    Private Sub txtSampleBulkQty_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtSampleBulkQty.KeyPress
        If Not Char.IsNumber(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) AndAlso Not (Asc(e.KeyChar) = Asc(".")) Then
            MessageBox.Show("You must entry numeric only", "User Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            e.KeyChar = Nothing
        End If
    End Sub

    Private Sub btnApplySampleToGrid_Click(sender As Object, e As EventArgs) Handles btnApplySampleToGrid.Click
        With grdSalesOrder
            If .Rows.Count > 0 Then
                Dim SampleFabricQty As Double = 0
                Dim SampleBulkQty As Double = 0

                For i As Integer = 0 To .Rows.Count - 2
                    If txtSampleFabricQty.Text.Trim = "" Then
                        SampleFabricQty = 0
                    Else
                        SampleFabricQty = Convert.ToDouble(txtSampleFabricQty.Text)
                    End If

                    If txtSampleBulkQty.Text.Trim = "" Then
                        SampleBulkQty = 0
                    Else
                        SampleBulkQty = Convert.ToDouble(txtSampleBulkQty.Text)
                    End If

                    .Rows(i).Cells("sample_fabric_qty").Value = SampleFabricQty
                    .Rows(i).Cells("sample_bulk_qty").Value = SampleBulkQty
                Next
            End If
        End With
    End Sub
    Private Function ValidateDate(value As String) As Boolean

        If value = "" Then
            Return True
        End If

        Dim dt As DateTime

        If Not DateTime.TryParseExact(
            value,
            "dd/MM/yyyy",
            Globalization.CultureInfo.InvariantCulture,
            Globalization.DateTimeStyles.None,
            dt) Then

            Return False
        End If

        If dt.Year < 1900 OrElse dt.Year > 2099 Then
            Return False
        End If

        Return True

    End Function
    Private Function ValidateDecimal(value As String) As Boolean

        If value = "" Then
            Return True
        End If

        Dim n As Decimal

        Return Decimal.TryParse(value, n)

    End Function
    Private Function ValidateInteger(value As String) As Boolean

        If value = "" Then
            Return True
        End If

        Dim n As Integer

        Return Integer.TryParse(value, n)

    End Function
    Private Sub grdSalesOrder_CellValidating(sender As Object, e As DataGridViewCellValidatingEventArgs) Handles grdSalesOrder.CellValidating
        Dim colName As String = grdSalesOrder.Columns(e.ColumnIndex).Name
        Dim value As String = e.FormattedValue.ToString().Trim()

        Select Case colName

        '========================
        ' Date
        '========================
            Case "colCustDelidt", "shipdt", "confirmed_shipdt"

                If Not ValidateDate(value) Then
                    MessageBox.Show(
                    grdSalesOrder.Columns(e.ColumnIndex).HeaderText &
                    " is invalid." & vbCrLf &
                    "Please enter date as dd/MM/yyyy." & vbCrLf &
                    "Year must be between 1900 and 2099.",
                    "Invalid Date",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning)

                    e.Cancel = True
                End If


        '========================
        ' Decimal / Quantity
        '========================
            Case "qty", "price", "exrt"

                If Not ValidateDecimal(value) Then
                    MessageBox.Show(
                    grdSalesOrder.Columns(e.ColumnIndex).HeaderText &
                    " must be a number.",
                    "Invalid Number",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning)

                    e.Cancel = True
                End If


        '========================
        ' Integer
        '========================
            Case "credit_days"

                If Not ValidateInteger(value) Then
                    MessageBox.Show(
                    grdSalesOrder.Columns(e.ColumnIndex).HeaderText &
                    " must be an integer.",
                    "Invalid Number",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning)

                    e.Cancel = True
                End If


                '========================
                ' Required field
                '========================
                'Case "design_no", "col", "uom"

                '    If value = "" Then
                '        MessageBox.Show(
                '        grdSalesOrder.Columns(e.ColumnIndex).HeaderText &
                '        " is required.",
                '        "Required Field",
                '        MessageBoxButtons.OK,
                '        MessageBoxIcon.Warning)

                '        e.Cancel = True
                '    End If

        End Select
    End Sub

    Private Sub grdSalesOrder_CellParsing(sender As Object, e As DataGridViewCellParsingEventArgs) Handles grdSalesOrder.CellParsing
        Dim colName As String = grdSalesOrder.Columns(e.ColumnIndex).Name

        Select Case colName

            Case "colCustDelidt", "shipdt", "confirmed_shipdt"

                Dim value As String = ""

                If e.Value IsNot Nothing Then
                    value = e.Value.ToString.Trim
                End If

                'อนุญาตให้วันที่ว่าง
                If value = "" Then
                    e.Value = DBNull.Value
                    e.ParsingApplied = True
                    Exit Sub
                End If

        End Select
    End Sub
End Class
