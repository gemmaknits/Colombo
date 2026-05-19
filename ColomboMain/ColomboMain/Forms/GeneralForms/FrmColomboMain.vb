Imports System.Globalization
Imports System
Imports System.Text
Imports System.Data.SqlClient

Public Class FrmColomboMain
#Region "Form Property"
    Public loginEmpcd As String
    Dim clsUser As New classUserInfo
    Private _CompanyId As Integer = 0
    Private _MtlWarehouseID As Integer
    Private _MtlWarehouseCd As String
    Private _MtlWarehouseName As String
    Private _SiteName As String
    Private _SiteNameThai As String
    Private _logEmpId As Integer

    Public Property UserInfo() As classUserInfo
        Get
            UserInfo = clsUser
        End Get
        Set(ByVal NewValue As classUserInfo)
            clsUser = NewValue
        End Set
    End Property
    Public Property CompanyId() As Integer
        Get
            CompanyId = _CompanyId
        End Get
        Set(ByVal NewValue As Integer)
            _CompanyId = NewValue
        End Set
    End Property
    Public Property MtlWarehouseID() As Integer
        Get
            MtlWarehouseID = _MtlWarehouseID
        End Get
        Set(ByVal NewValue As Integer)
            _MtlWarehouseID = NewValue
        End Set
    End Property
    Public Property MtlWarehouseCd() As String
        Get
            MtlWarehouseCd = _MtlWarehouseCd
        End Get
        Set(ByVal NewValue As String)
            _MtlWarehouseCd = NewValue
        End Set
    End Property
    Public Property MtlWarehouseName() As String
        Get
            MtlWarehouseName = _MtlWarehouseName
        End Get
        Set(ByVal NewValue As String)
            _MtlWarehouseName = NewValue
        End Set
    End Property
    Public Property SiteName() As String
        Get
            SiteName = _SiteName
        End Get
        Set(ByVal NewValue As String)
            _SiteName = NewValue
        End Set
    End Property
    Public Property SiteNameThai() As String
        Get
            SiteNameThai = _SiteNameThai
        End Get
        Set(ByVal NewValue As String)
            _SiteNameThai = NewValue
        End Set
    End Property
    Public Property logEmpId() As String
        Get
            logEmpId = _logEmpId
        End Get
        Set(ByVal NewValue As String)
            _logEmpId = NewValue
        End Set
    End Property
#End Region

    Private clsConnection As New classConnection
    Private clsMaster As New classMaster
    Private clsValidate As New ClassValidate

    Private dt As New DataTable
    Private bsSearchTable As New BindingSource

    Dim conn As New SqlConnection((New classConnection).connection)

    Private Sub tsbtnExit_Click(sender As Object, e As EventArgs) Handles tsbtnExit.Click
        Me.Close()
    End Sub

    Private Sub FrmGemmaMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'lblConnection.Text = "Server : " + New classConnection().servername
        tslbDatabase.Text = "Database: " & (New classConnection).database.ToString.Trim 'Add By Neung 20221216
        SalesOrderSystem.ClassConnection.servername = classConnection.servername 'Add By Neung 20260123
        SalesOrderSystem.ClassConnection.database = classConnection.database 'Add By Neung 20260123
        ProductionSystem.classConnection.servername = classConnection.servername 'Add By Neung 20260123
        ProductionSystem.classConnection.database = classConnection.database 'Add By Neung 20260123
        PurchaseOrderSystem.classConnection.servername = classConnection.servername 'Add By Neung 20260123
        PurchaseOrderSystem.classConnection.database = classConnection.database 'Add By Neung 20260123
        YarnStockSystem.classConnection.ServerName = classConnection.servername 'Add By Neung 20260123
        YarnStockSystem.classConnection.Database = classConnection.database 'Add By Neung 20260123
        InvoiceSystemESH.ClassConnection.servername = classConnection.servername 'Add By Neung 20260123
        InvoiceSystemESH.ClassConnection.database = classConnection.database 'Add By Neung 20260123

        STV.ClassConnection.servername = classConnection.servername 'Add By Neung 20260123
        STV.ClassConnection.database = classConnection.database 'Add By Neung 20260123

        Dim culture As CultureInfo
        culture = CultureInfo.CurrentCulture
        If UCase(culture.DisplayName) <> "ENGLISH (UNITED KINGDOM)" Then
            'MsgBox("Select change your regional settings to English United Kingdom")
            'Me.Close()
            My.Application.ChangeCulture("en-GB")
            My.Application.ChangeUICulture("en-GB")
        End If

        If Not System.Diagnostics.Debugger.IsAttached Then Me.Text = Me.Text & " Version " & My.Application.Deployment.CurrentVersion.ToString

        initComboBox()
        tslblSiteName.Text = _SiteName & "    (" & _SiteNameThai & ")"


        'getModuleRole()
        'initMenu() 'Sitthana 04/12/2021


        'Me.ContextMenu = TrayMenu
        'TrayIcon.Icon = Me.Icon
        'TrayIcon.Visible = False
        'TrayIcon.ContextMenu = TrayMenu
        'TrayIcon.Text = "Purchase Order System"

        'txtExchangeRate.Text = FormatNumber(clsUser.ExchangeRate, 4)

        'Call checkMenuAccess() 'Permission make security of yarn and purchase as per the excel file /K.Suresh 20210526

    End Sub

    Private Sub initComboBox()
        With tsmncboWareHouse.ComboBox
            .DataSource = clsMaster.Combomtlwarehouse("")
            .DisplayMember = "warehouse_code"
            .ValueMember = "mtl_warehouse_id"

            .SelectedValue = _MtlWarehouseID
        End With
    End Sub


#Region "Menu Right"
    Private Sub getModuleRole()
        dt = clsMaster.getUserRole(clsUser.UserID)
        bsSearchTable.DataSource = dt
        bsSearchTable.MoveFirst()
    End Sub

    Private Function ModuleHadRight(pSearchString As String)
        Dim HadRight As Boolean = False

        Dim FilterExp As New StringBuilder
        FilterExp.Clear()
        FilterExp.Append("ModuleId = '" & pSearchString & "'")
        If pSearchString <> "" Then
            bsSearchTable.MoveFirst()
            bsSearchTable.Filter = FilterExp.ToString
            If bsSearchTable.Count > 0 Then
                HadRight = True
            End If
        End If

        Return HadRight
    End Function

    Private Function RoleHadRight(pSearchString As String)
        Dim HadRight As Boolean = False

        Dim FilterExp As New StringBuilder
        FilterExp.Clear()
        FilterExp.Append("RoleId = '" & pSearchString & "'")
        If pSearchString <> "" Then
            bsSearchTable.MoveFirst()
            bsSearchTable.Filter = FilterExp.ToString
            If bsSearchTable.Count > 0 Then
                HadRight = True
            Else
                HadRight = False
                'MessageBox.Show("You don't had right to run this program", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        End If

        Return HadRight
    End Function
#End Region

#Region "Menu Initialize"

#End Region



    '*** System Menu
    Private Sub selectSystemModule(pSystemNodeName As String, pSelectNodeName As String)
        '7 System ()
        Dim SystemModule As String = ""

        If InStr(pSystemNodeName, "\") > 0 Then
            SystemModule = Mid(pSystemNodeName, 1, InStr(pSystemNodeName, "\") - 1)
        Else
            SystemModule = pSystemNodeName
        End If

        Select Case SystemModule.ToUpper.Trim
            Case "Setup".ToUpper
                selectFromMdSetup(pSelectNodeName)
            Case "Purchasing".ToUpper
                selectFromMdPurchasing(pSelectNodeName)
            Case "Inventory".ToUpper
                selectFromMdInventory(pSelectNodeName)
            Case "ORDERS MANAGEMENT".ToUpper
                selectFromMdOrdersManagement(pSelectNodeName)
            Case "Shipping".ToUpper
                selectFromMdShipping(pSelectNodeName)
            Case "Production".ToUpper
                selectFromMdProduction(pSelectNodeName)
            Case "ACCOUNT RECEIVABLES".ToUpper
                selectFromMdAccountReceivables(pSelectNodeName)
        End Select
    End Sub
    '*** End System Menu

    '*** Setup, Transaction, Report Menu

    Private Sub selectFromMdSetup(pSelectNodeName As String)
        '*** 1. Setup

        Select Case pSelectNodeName.ToUpper
            Case "ndSetupUser".ToUpper
                MsgBox("Under Construction")
            Case "ndSetupRole".ToUpper
                MsgBox("Under Construction")
            Case "ndSetupRoleChangePassword".ToUpper
                MsgBox("Under Construction")
            Case "ndSetupRoleChangeWH".ToUpper
                MsgBox("Under Construction")
            Case "ndSetupRoleExchangeRate".ToUpper
                MsgBox("Under Construction")
        End Select
    End Sub

    Private Sub selectFromMdPurchasing(pSelectNodeName As String)

        Select Case pSelectNodeName.ToUpper.Trim
            '*** 2. Purchase System - Program
            Case "ndPCMasterSupplier".ToUpper
                callFrmStdParameter(New PurchaseOrderSystem.formSupplierCreate)
            Case "ndPCMasterItemsGeneralItems".ToUpper
                callGeneralItem()
            Case "ndPCMasterItemsMatrixItems".ToUpper
                callMatrixItem()
            Case "ndPCMasterUomUom".ToUpper
                'Dim frm As New STV.frmUOM
                '  Dim frm As New InventorySystem.frmUOM 'Sitthana 20221213
                ' Call SetUserInfobyFrm(pfrm:=frm)
              '  CallFormWithConnection(frm)
            Case "ndPCMasterUomSTDUnitsConversion".ToUpper 'Conversion
                'Dim frm As New STV.frmUOMSimpleConversion 'Conversion
                ' Dim frm As New InventorySystem.frmUOMSimpleConversion 'Conversion 'Sitthana 20221213
                '' Call SetUserInfobyFrm(pfrm:=frm)
              '  CallFormWithConnection(frm)
            Case "ndPCMasterUomItemsUnitsConversion".ToUpper 'Class
                'Dim frm As New STV.frmUOMConversion 'Class
                'CallFormWithConnection(frm)
                '    Dim frm As New InventorySystem.frmUOMConversion 'Class 'Sitthana 20221213
            '    CallFormWithSentSqlConn(frm)
            Case "ndPCOrderPurchaseOrder_NewEdit".ToUpper
                'callFrmStdParameter(New PurchaseOrderSystem.formPurchaseOrderCreate)
                callFrmPurchaseOrderSystem(New PurchaseOrderSystem.frmPurchaseOrderNewEdit)
            Case "ndPCOrderPurchaseOrder".ToUpper
                'callFrmStdParameter(New PurchaseOrderSystem.formPurchaseOrderCreate)
                callFrmPurchaseOrderSystem(New PurchaseOrderSystem.formPurchaseOrderCreate)
            Case "ndPCOrderPurchaseOrder_Edit".ToUpper
                'callFrmStdParameter(New PurchaseOrderSystem.formPurchaseOrderEdit3)
                callFrmPurchaseOrderSystem(New PurchaseOrderSystem.formPurchaseOrderEdit3)
            Case "ndPCOrderApprove".ToUpper
                callFrmStdParameter(New PurchaseOrderSystem.formPurchaseOrderApprove)
            Case "ndPCOrderCancel".ToUpper
                callFrmPurchaseOrderSystem(New PurchaseOrderSystem.formPurchaseOrderCancel)
            Case "ndPCOrderTracking".ToUpper
               ' callFrmStdParameter(New PurchaseOrderSystem.frmPOShipmentStepUpdate)
            Case "ndPCOrdersClosePO".ToUpper
                callFrmStdParameter(New PurchaseOrderSystem.frmPOClose)


                '2. Purchase System - Reports
            Case "ndPOControlCenter".ToUpper
                'callFrmStdParameter(New PurchaseOrderSystem.frmPOControlCenter) 'saharat 20230221

        End Select
    End Sub

    Private Sub selectFromMdInventory(pSelectNodeName As String)
        Select Case pSelectNodeName.ToUpper
            '*** 3. Inventory

            '3. Inventory - Master
            Case "ndInventoryMasterSupplier".ToUpper
                callFrmStdParameter(New PurchaseOrderSystem.formSupplierCreate)

            '3. Inventory - Items
            Case "ndInventoryItemsGeneral".ToUpper
                callGeneralItem()
            Case "ndInventoryItemsMatrix".ToUpper
                callMatrixItem()
            Case "ndInventoryItemsSuplierItems".ToUpper
                ' Dim frm As New STV.frmSupplierItems
             '   CallFormWithConnection(frm)
            Case "ndInventoryItemsCustomerItems".ToUpper
                'Dim frm As New SalesOrderSystem.frmCustmerItems
                'frm.setConnectionString(clsConnection.getSQLConnection)
                'Call SetUserInfobyFrm(pfrm:=frm)
                ''frm.MdiParent = Me
                'frm.Show()

            '    CallFormWithConnection(frm)
            Case "ndInventoryItemsItemsCrossRef".ToUpper
                'Dim frm As New InventorySystem.frmItemRelation
                'Call SetUserInfobyFrm(pfrm:=frm)
                'CallForm(frm)
            Case "ndInventoryItemOnhand".ToUpper
                'Dim frm As New InventorySystem.frmStockOnHand  'Add by Neung 20221228
                'Call SetUserInfobyFrm(frm) 'Add by Neung 20221228
                'CallForm(frm)

            '3. Inventory - Setup
            Case "ndInventorySetupTransactiontype".ToUpper
                MsgBox("Under Construction")
            Case "ndInventorySetupTransactionSources".ToUpper
                MsgBox("Under Construction")
            Case "ndInventorySetupLookupType".ToUpper
                'callLookupType()

                'If RoleHadRight("R0708") Then

                'Else
                '    MessageBox.Show("คุณไม่มีสิทธิ์เรียกโปรแกรม Lookup Type ครับ", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
                'End If
            Case "ndInventorySetupLookupValue".ToUpper
              '  callLookupValue()
            Case "ndInventorySetupUnitOfMeasure".ToUpper
                MsgBox("Under Construction")
            Case "ndInventorySetupWarehouse".ToUpper
                MsgBox("Under Construction")
            Case "ndInventorySetupSubinventory".ToUpper
                MsgBox("Under Construction")
            Case "ndInventorySetupLocation".ToUpper
                'Dim frm As New SalesOrderSystem.frmLocations
                'frm.p_mtl_warehouse_id = 1
                'frm.p_mtl_subinventory_id = 2
                ''frm.BtnApply.Enabled = True
                'CallForm(frm)

            '3. Inventory - PO Transaction
            Case "ndInventoryPOTransactionReceipt".ToUpper
                'callFrmInventoryStdParameter(New InventorySystem.frmPoReceiptMain) 'Sitthana 20221125
            '    callFrmInventoryStdParameterNew(New InventorySystem.frmPoReceiptMain) 'Sitthana 20221125

                'Dim frm As New InventorySystem.frmPoReceiptMain
                'frm.CompanyId = _CompanyId
                'frm.logEmpId = _UserInfo.UserID
                'frm.WarehouseID = _MtlWarehouseID
                'frm.WarehouseCode = _MtlWarehouseCd
                ''frm.UserInfo = _UserInfo.
                'frm.ShowDialog(Me)
            Case "ndInventoryPOTransactionReturn".ToUpper
                MsgBox("Under Construction")

            '3. Inventory - Transactions
            Case "ndInventoryTransactionsMiscellaneous".ToUpper
                'Dim frm As New InventorySystem.frmInventoryMiscTrans
                'Call SetUserInfobyFrm(pfrm:=frm) 'Add By neung 20230223
                'frm.CompanyId = _CompanyId
                'frm.MtlWarehouseId = _MtlWarehouseID
                'frm.MtlWarehouseCd = _MtlWarehouseCd
                'CallForm(frm)
            Case "ndInventoryTransactionsWHTransfer".ToUpper
                'callFrmInventoryStdParameter(New InventorySystem.frmTransferInvLoc)
                'Dim frm As New InventorySystem.frmTransferInvLoc
                'Call SetUserInfobyFrm(pfrm:=frm)
                'frm.CompanyId = _CompanyId
                ''frm.logEmpId = _clsUser.EmpId
                'frm.MtlWarehouseID = _MtlWarehouseID
                'frm.MtlWarehouseCd = _MtlWarehouseCd
                'frm.MtlWarehouseName = _MtlWarehouseName
                'frm.TransferBetweenWH = True
                'CallForm(frm)
            Case "ndInventoryTransactionsLocationTransfer".ToUpper
                'callFrmInventoryStdParameter(New InventorySystem.frmTransferInvLoc)
                'Dim frm As New InventorySystem.frmTransferInvLoc
                'Call SetUserInfobyFrm(pfrm:=frm)
                'frm.CompanyId = _CompanyId
                'frm.MtlWarehouseID = _MtlWarehouseID
                'frm.MtlWarehouseCd = _MtlWarehouseCd
                'frm.MtlWarehouseName = _MtlWarehouseName
                'frm.TransferBetweenWH = False
               ' CallForm(frm)
            Case "ndInventoryTransactionsLocationTransferMulti".ToUpper  'saharat 20230529
                'Dim frm As New InventorySystem.frmTransferInvLocMulti
                'Call SetUserInfobyFrm(pfrm:=frm)
                'frm.CompanyId = _CompanyId
                'frm.MtlWarehouseID = _MtlWarehouseID
                'frm.MtlWarehouseCd = _MtlWarehouseCd
                'frm.MtlWarehouseName = _MtlWarehouseName
                ''frm.TransferBetweenWH = False
                'CallForm(frm)
            Case "ndInventoryTransactionsSubcontractTransfer".ToUpper
                'callFrmInventoryStdParameter(New InventorySystem.frmTransferInvLoc)
                'Dim frm As New InventorySystem.frmTransferInvSubContract
                'Call SetUserInfobyFrm(pfrm:=frm)
                '' frm.CompanyId = _CompanyId
                'frm.MtlWarehouseID = _MtlWarehouseID
                'frm.MtlWarehouseCd = _MtlWarehouseCd
                'frm.MtlWarehouseName = _MtlWarehouseName
                'frm.TransferBetweenWH = False
                'CallForm(frm)
            Case "ndInventoryTransactionsLotDetails".ToUpper
                'Dim frm As New InventorySystem.frmLotDetails
                'Call SetUserInfobyFrm(pfrm:=frm)
                'CallForm(frm)
            Case "ndInventoryTransactionsRMAReceipt".ToUpper    'saharat 20230929
                'Dim frm As New InventorySystem.frmRMAReceiptMain
                'Call SetUserInfobyFrmRMA(pfrm:=frm)
                'CallForm(frm)
            Case "ndInventoryTransactionsSOReceipt".ToUpper   'saharat 20231016
                'Dim frm As New InventorySystem.frmSOReceiptMain
                'SetUserInfobyFrmRMA(frm)
                'frm.ShowDialog(Me)
            Case "ndInventoryTransactionsPOReceiptUpdate".ToUpper    'saharat 20231020
                'Dim frm As New InventorySystem.frmPOReceiptUpdateMain
                'SetUserInfobyFrmRMA(frm)
                'frm.ShowDialog(Me)
            Case "ndInventoryLotDetails".ToUpper
                ''Sitthana 20231201
                'Dim frm As New InventorySystem.frmLotDetails
                'Call SetUserInfobyFrm(frm) 'Neung 20230526
                'frm.ShowDialog(Me)

            '3. Inventory - Shipping
            Case "ndInventoryDelivery".ToUpper
                'Dim frm As New InventorySystem.frmDelivery
                'Call SetUserInfobyFrm(pfrm:=frm)
                'frm.CompanyId = _CompanyId
                'frm.MtlWarehouseID = _MtlWarehouseID
                'frm.MtlWarehouseCd = _MtlWarehouseCd
                'frm.MtlWarehouseName = _MtlWarehouseName
                'CallForm(frm)

            '3. Inventory - Reports
            Case "ndInventoryReportStockOnhand".ToUpper
                'Dim frm As New InventorySystem.frmStockOnHand  'Add by Neung 20221228
                'Call SetUserInfobyFrm(frm) 'Add by Neung 20221228
                'CallForm(frm)
            Case "ndInventoryReportStockMovement".ToUpper
                'Dim frm As New InventorySystem.frmStockMovement
                'Call SetUserInfobyFrm(pfrm:=frm)
                'frm.CompanyId = _CompanyId
                'frm.WarehouseID = _MtlWarehouseID
                'frm.WarehouseCode = _MtlWarehouseCd
                'CallForm(frm)
            '3. Inventory - QA
            'saharat 20230310
            Case "ndInventoryQATestResultReport".ToUpper
                'callFrmStdParameter(New InventorySystem.frmQASample)
        End Select
    End Sub

    Private Sub selectFromMdOrdersManagement(pSelectNodeName As String)
        Select Case pSelectNodeName.ToUpper
            '*** 4. ORDERS Management

            '4. ORDERS Management - Master
            Case "ndOrdersManagementMasterCustomer".ToUpper
                callFrmStdParameter(New SalesOrderSystem.frmCustomerNew)
            Case "ndOrdersManagementMasterSalesperson".ToUpper
                MsgBox("Under Construction")
            Case "ndOrdersManagementMasterAgents".ToUpper
                callFrmStdParameter(New SalesOrderSystem.frmAgent)
            Case "ndOrdersManagementMasterEndBuyers".ToUpper
                callFrmStdParameter(New SalesOrderSystem.frmEndBuyers)


            '4. ORDERS Management - Sales Order
            Case "ndOrdersManagementSalesOrderCreate".ToUpper
                callFrmStdParameterNotInPanel(New SalesOrderSystem.frmSalesOrder)
            Case "ndOrdersManagementSalesOrderClose".ToUpper
                callFrmStdParameter(New SalesOrderSystem.frmSalesOrderClose)
            Case "ndOrdersManagementSalesOrderCancel".ToUpper
                MsgBox("Under Construction")
            Case "ndOrdersManagementSalesOrderOrderBOM".ToUpper
                callFrmStdParameterNotInPanel(New ProductionSystem.frmDesignBOMNew)


                '4. ORDERS Management - Reports
            Case "ndOrdersManagementReportsSalesOrderInvoice".ToUpper
                callFrmStdParameter(New SalesOrderSystem.frmSalesOrderInvoice)
            Case "ndOrdersManagementReportsSalesOrderSummary".ToUpper
                callFrmStdParameter(New SalesOrderSystem.frmSalesOrderSummary)
        End Select
    End Sub

    Private Sub selectFromMdShipping(pSelectNodeName As String)
        'Select Case pSelectNodeName.ToUpper
        '    '5 Shipping

        '    '5 Shipping - Delivery
        '    Case "ndShippingDelivery".ToUpper
        '        Dim frm As New InventorySystem.frmDelivery
        '        Call SetUserInfobyFrm(frm)
        '        frm.CompanyId = _CompanyId
        '        frm.MtlWarehouseID = _MtlWarehouseID
        '        frm.MtlWarehouseCd = _MtlWarehouseCd
        '        frm.MtlWarehouseName = _MtlWarehouseName
        '        CallForm(frm)


        '    '5 Shipping - Invoice
        '    Case "ndShippingInvoiceLocalInvoiceIV".ToUpper
        '        'callFrmStdParameterNotInPanel(New InvoiceSystem.frmInvoiceLocal)

        '        Dim frm As New ReceivablesSystem.frmArInvoice
        '        Call SetUserInfobyFrm(pfrm:=frm) 'Add By neung 20230223
        '        frm.pArTranTypeID = 6 'IV
        '        frm.ShipFromWarehouseId = clsUser.MtlWarehouseID
        '        frm.Show()
        '    Case "ndShippingInvoiceLocalInvoiceIC".ToUpper
        '        'callFrmStdParameterNotInPanel(New InvoiceSystem.frmInvoiceLocal)

        '        Dim frm As New ReceivablesSystem.frmArInvoice
        '        Call SetUserInfobyFrm(pfrm:=frm) 'Add By neung 20230223
        '        frm.pArTranTypeID = 17 'IC
        '        frm.ShipFromWarehouseId = clsUser.MtlWarehouseID
        '        frm.Show()
        '    Case "ndShippingInvoiceExportInvoiceEI".ToUpper
        '        'callFrmStdParameterNotInPanel(New InvoiceSystem.frmInvoiceExport)

        '        Dim frm As New ReceivablesSystem.frmArInvoice
        '        Call SetUserInfobyFrm(pfrm:=frm) 'Add By neung 20230223
        '        frm.pArTranTypeID = 5 'EI-
        '        frm.ShipFromWarehouseId = clsUser.MtlWarehouseID
        '        frm.Show()
        '    Case "ndShippingInvoiceExportPackingList".ToUpper
        '        MsgBox("Under Construction")


        '        '5 Shipping - Reports
        '    Case "ndInvoiceYearSummary".ToUpper
        '        callFrmStdParameterNotInPanel(New SalesOrderSystem.frmInvoiceSummaryYear)
        'End Select
    End Sub

    Private Sub selectFromMdProduction(pSelectNodeName As String)
        Select Case pSelectNodeName.ToUpper
            '6. Production

            '6. Production - Setup
            Case "ndProductionSetupLookupType".ToUpper
                'callFrmStdParameter(New ProductionSystem.frmMatrixLookupType) 'frmLookUpType
            Case "ndProductionSetupLookupValue".ToUpper
                'Const'callFrmStdParameter(New ProductionSystem.frmLookup)
                'Dim frm As New ProductionSystem.frmLookupValue
                ''frm.MatrixItem = "Y"
                'CallForm(frm)
            Case "ndProductionSetupBom".ToUpper
                callFrmStdParameterNotInPanel(New ProductionSystem.frmDesignBOMNew)
            Case "ndProductionSetupUomUom".ToUpper
                'Dim frm As New STV.frmUOM
                'Dim frm As New InventorySystem.frmUOM 'Sitthana 20221213
                'CallFormWithConnection(frm)
            Case "ndProductionSetupUomSTDUnitsConversion".ToUpper 'Conversion
                'Dim frm As New STV.frmUOMSimpleConversion 'Conversion
                'Dim frm As New InventorySystem.frmUOMSimpleConversion 'Conversion 'Sitthana 20221213
                'CallFormWithConnection(frm)
            Case "ndProductionSetupUomItemsUnitsConversion".ToUpper 'Class
                'Dim frm As New STV.frmUOMConversion 'Class
                'CallFormWithConnection(frm)
                'Dim frm As New InventorySystem.frmUOMConversion 'Class 'Sitthana 20221213
                'CallFormWithConnection(frm)

            '6. Production - Master
            Case "ndProductionMasterMachines".ToUpper
                callFrmStdParameter(New ProductionSystem.frmMachine)
            Case "ndProductionMasterReportsBomCostSheet".ToUpper
               ' callFrmStdParameter(New ProductionSystem.frmBomCostSheet)
            '6. Production - Orders
            Case "ndProductionOrdersProductionOrder".ToUpper
                MsgBox("Under Construction")
            Case "ndProductionOrdersClose".ToUpper
                MsgBox("Under Construction")
            Case "ndProductionOrdersCancel".ToUpper
                MsgBox("Under Construction")


                '6. Production - Reports
        End Select
    End Sub

    Private Sub selectFromMdAccountReceivables(pSelectNodeName As String)
        'Edit By Neung 20230322
        'Select Case pSelectNodeName.ToUpper
        '    '7. Accounts Receivables
        '    Case "ndARInvoice".ToUpper
        '        Dim frm As New ReceivablesSystem.frmArInvoice
        '        Call SetUserInfobyFrm(pfrm:=frm) 'Add By neung 20230223
        '        frm.pArTranTypeID = Nothing 'All
        '        frm.ShipFromWarehouseId = clsUser.MtlWarehouseID
        '        frm.Show()
        '    Case "ndARInvoice6".ToUpper
        '        Dim frm As New ReceivablesSystem.frmArInvoice
        '        Call SetUserInfobyFrm(pfrm:=frm) 'Add By neung 20230223
        '        frm.pArTranTypeID = 6 ' = "INVLOC"
        '        frm.ShipFromWarehouseId = clsUser.MtlWarehouseID
        '        frm.Show()
        '    Case "ndARInvoice17".ToUpper
        '        Dim frm As New ReceivablesSystem.frmArInvoice
        '        Call SetUserInfobyFrm(pfrm:=frm) 'Add By neung 20230223
        '        frm.pArTranTypeID = 17 '"INVLOCIC"
        '        frm.ShipFromWarehouseId = clsUser.MtlWarehouseID
        '        frm.Show()
        '    Case "ndARInvoice18".ToUpper
        '        Dim frm As New ReceivablesSystem.frmArInvoice
        '        Call SetUserInfobyFrm(pfrm:=frm) 'Add By neung 20230223
        '        frm.pArTranTypeID = 18 ' = "INVLOCAI"
        '        frm.ShipFromWarehouseId = clsUser.MtlWarehouseID
        '        frm.Show()
        '    Case "ndARInvoice20".ToUpper
        '        Dim frm As New ReceivablesSystem.frmArInvoice
        '        Call SetUserInfobyFrm(pfrm:=frm) 'Add By neung 20230223
        '        frm.pArTranTypeID = 20 ' = "INVOS"
        '        frm.ShipFromWarehouseId = clsUser.MtlWarehouseID
        '        frm.Show()
        '    Case "ndARInvoice21".ToUpper
        '        Dim frm As New ReceivablesSystem.frmArInvoice
        '        Call SetUserInfobyFrm(pfrm:=frm) 'Add By neung 20230223
        '        frm.pArTranTypeID = 21 ' = "INVON"
        '        frm.ShipFromWarehouseId = clsUser.MtlWarehouseID
        '        frm.Show()
        '    Case "ndARInvoice22".ToUpper
        '        Dim frm As New ReceivablesSystem.frmArInvoice
        '        Call SetUserInfobyFrm(pfrm:=frm) 'Add By neung 20230223
        '        frm.pArTranTypeID = 22 ' = "INVSA"
        '        frm.ShipFromWarehouseId = clsUser.MtlWarehouseID
        '        frm.Show()
        '    Case "ndARInvoice2".ToUpper
        '        Dim frm As New ReceivablesSystem.frmArInvoice
        '        Call SetUserInfobyFrm(pfrm:=frm)
        '        frm.pArTranTypeID = 2 '"CRNOTEAR"
        '        frm.ShipFromWarehouseId = clsUser.MtlWarehouseID
        '        frm.Show()
        '    Case "ndARInvoice4".ToUpper
        '        Dim frm As New ReceivablesSystem.frmArInvoice
        '        Call SetUserInfobyFrm(pfrm:=frm)
        '        frm.pArTranTypeID = 4 '"DBNOTEARL"
        '        frm.ShipFromWarehouseId = clsUser.MtlWarehouseID
        '        frm.Show()
        '    Case "ndBillingNote".ToUpper
        '        Dim frm As New ReceivablesSystem.frmBaiwangBill
        '        Call SetUserInfobyFrm(pfrm:=frm) 'Add By neung 20230223
        '        frm.Show()
        '    Case "ndReceiptRE".ToUpper
        '        Dim frm As New ReceivablesSystem.frmArReceipt
        '        Call SetUserInfobyFrm(pfrm:=frm) 'Add By neung 20230223
        '        frm.pRegion = "LOCAL"
        '        frm.pidname = "RENO"
        '        frm.Show()
        '    Case "ndReceiptRI".ToUpper
        '        Dim frm As New ReceivablesSystem.frmArReceipt
        '        Call SetUserInfobyFrm(pfrm:=frm) 'Add By neung 20230223
        '        frm.pRegion = "LOCAL"
        '        frm.pidname = "RINO"
        '        frm.Show()
        '    Case "ndChequeReceipt".ToUpper
        '        Dim frm As New ReceivablesSystem.frmChequeReceipt
        '        Call SetUserInfobyFrm(pfrm:=frm) 'Add By neung 20230223
        '        frm.Show()
        '    Case "ndARActivity".ToUpper
        '        Dim frm As New ReceivablesSystem.frmArActivity
        '        Call SetUserInfobyFrm(pfrm:=frm) 'Add By neung 20230223
        '        frm.Show()
        '    Case "ndARReceiptMethod".ToUpper
        '        Dim frm As New ReceivablesSystem.frmARReceiptMethod
        '        Call SetUserInfobyFrm(pfrm:=frm) 'Add By neung 20230223
        '        frm.Show()
        '    Case "ndARTaxType".ToUpper
        '        Dim frm As New ReceivablesSystem.frmArTaxType
        '        Call SetUserInfobyFrm(pfrm:=frm) 'Add By neung 20230223
        '        frm.Show()
        '    Case "ndARTranType".ToUpper
        '        Dim frm As New ReceivablesSystem.frmARTranType
        '        Call SetUserInfobyFrm(pfrm:=frm) 'Add By neung 20230223
        '        frm.Show()
        '    Case "ndAROtherIncome".ToUpper
        '        Dim frm As New ReceivablesSystem.frmAROtherIncome
        '        Call SetUserInfobyFrm(pfrm:=frm) 'Add By neung 20230223
        '        frm.Show()

        '        'Report
        '    Case "ndArtaxReport".ToUpper
        '        Dim frm As New ReceivablesSystem.frmARInvoiceTaxReport
        '        Call SetUserInfobyFrm(pfrm:=frm) 'Add By neung 20230407
        '        frm.Show()
        '    Case "ndArBalance".ToUpper
        '        Dim frm As New ReceivablesSystem.frmARInvoiceBLReport
        '        Call SetUserInfobyFrm(pfrm:=frm) 'Add By neung 20230407
        '        frm.Show()
        '    Case "ndARInvoiceSummaryReport".ToUpper
        '        Dim frm As New ReceivablesSystem.frmARInviceSummaryReport
        '        Call SetUserInfobyFrm(pfrm:=frm) 'Add By neung 20230407
        '        frm.Show()
        '    Case "ndARReceiptReport".ToUpper
        '        Dim frm As New ReceivablesSystem.frmARReceiptReport
        '        Call SetUserInfobyFrm(pfrm:=frm) 'Add By neung 20230407
        '        frm.Show()
        '    Case "ndReceiptChequeOrderByPaymentDocDate".ToUpper
        '        Dim frm As New ReceivablesSystem.frmReceiptChequeOrderByPaymentDocDate
        '        Call SetUserInfobyFrm(pfrm:=frm) 'Add By neung 20230407
        '        frm.Show()
        '    Case "ndReceiptChequeBalanceGL".ToUpper
        '        Dim frm As New ReceivablesSystem.frmReceiptChequeBalanceGL
        '        Call SetUserInfobyFrm(pfrm:=frm) 'Add By neung 20230407
        '        frm.Show()
        '    Case "ndGLReceiptChequeByCleardDate".ToUpper
        '        MessageBox.Show("Comming Soon", "System Message")

        '    Case "ndReceiptChequeGL".ToUpper
        '        Dim frm As New ReceivablesSystem.frmReceiptChequeGL
        '        Call SetUserInfobyFrm(pfrm:=frm) 'Add By neung 20230407
        '        frm.Show()
        '    Case "ndARGLReport".ToUpper
        '        Dim frm As New ReceivablesSystem.frmARGLReport
        '        Call SetUserInfobyFrm(pfrm:=frm) 'Add By neung 20230407
        '        frm.Show()
        '    Case "ndARCashInvoiceOrdByInvNumReport".ToUpper
        '        Dim frm As New ReceivablesSystem.frmARCashInvoiceOrdByInvNumReport
        '        Call SetUserInfobyFrm(pfrm:=frm) 'Add By neung 20230407
        '        frm.Show()
        '    Case "ndARCashInvoiceOrdByInvDateReport".ToUpper
        '        Dim frm As New ReceivablesSystem.frmARCashInvoiceOrdByInvDateReport
        '        Call SetUserInfobyFrm(pfrm:=frm) 'Add By neung 20230407
        '        frm.Show()
        '    Case "ndARCashInvoiceGrpByCustomerReport".ToUpper
        '        Dim frm As New ReceivablesSystem.frmARCashInvoiceGrpByCustomerReport
        '        Call SetUserInfobyFrm(pfrm:=frm) 'Add By neung 20230407
        '        frm.Show()
        '    Case "ndARCashInvoiceGrpBySaleReport".ToUpper
        '        Dim frm As New ReceivablesSystem.frmARCashInvoiceGrpByCustomerReport
        '        Call SetUserInfobyFrm(pfrm:=frm) 'Add By neung 20230407
        '        frm.Show()
        '    Case "ndARSalesOrderInvoiceControl".ToUpper
        '        Dim frm As New ReceivablesSystem.frmARSalesOrderInvoiceControl
        '        Call SetUserInfobyFrm(pfrm:=frm) 'Add By neung 20230407
        '        frm.Show()
        'End Select
    End Sub
    '*** End Setup, Transaction, Report Menu


    '*** call Frm

    Private Sub callFrmStdParameter(pfrm As Object)
        pfrm.UserInfo.UserID = clsUser.UserID
        pfrm.UserInfo.UserName = clsUser.UserName
        pfrm.UserInfo.Password = clsUser.Password
        pfrm.UserInfo.ReportPath = clsUser.ReportPath
        pfrm.UserInfo.DeptCD = clsUser.DeptCD
        pfrm.UserInfo.CurrentDate = clsUser.CurrentDate
        pfrm.UserInfo.ExchangeRate = clsUser.ExchangeRate
        pfrm.UserInfo.ExchangeRateUSD = clsUser.ExchangeRateUSD
        pfrm.UserInfo.ExchangeRateJPY = clsUser.ExchangeRateJPY
        pfrm.UserInfo.ExchangeRateAUD = clsUser.ExchangeRateAUD
        pfrm.UserInfo.ExchangeRateCHF = clsUser.ExchangeRateCHF
        pfrm.UserInfo.ExchangeRateEUR = clsUser.ExchangeRateEUR
        pfrm.UserInfo.ExchangeRateHKD = clsUser.ExchangeRateHKD
        pfrm.UserInfo.ExchangeRateRMB = clsUser.ExchangeRateRMB
        pfrm.UserInfo.ExchangeRateCNY = clsUser.ExchangeRateCNY
        pfrm.UserInfo.LogID = clsUser.LogID
        pfrm.UserInfo.IPAddress = clsUser.IPAddress
        pfrm.UserInfo.CanChat = clsUser.CanChat
        pfrm.UserInfo.MessageWindowStyle = clsUser.MessageWindowStyle
        pfrm.UserInfo.ImagePath = clsUser.ImagePath
        pfrm.UserInfo.MtlWarehouseID = clsUser.MtlWarehouseID  'Add By Neung 20221128 ต้องส่งไปด้วย ครับ

        CallForm(pfrm)
    End Sub
    'PurchaseOrderSystem
    Private Sub callFrmPurchaseOrderSystem(pfrm As Object)
        pfrm.UserInfo.UserID = clsUser.UserID
        pfrm.UserInfo.UserName = clsUser.UserName
        pfrm.UserInfo.Password = clsUser.Password
        pfrm.UserInfo.ReportPath = clsUser.ReportPath
        pfrm.UserInfo.DeptCD = clsUser.DeptCD
        pfrm.UserInfo.CurrentDate = clsUser.CurrentDate
        pfrm.UserInfo.ExchangeRate = clsUser.ExchangeRate
        pfrm.UserInfo.ExchangeRateUSD = clsUser.ExchangeRateUSD
        pfrm.UserInfo.ExchangeRateJPY = clsUser.ExchangeRateJPY
        pfrm.UserInfo.ExchangeRateAUD = clsUser.ExchangeRateAUD
        pfrm.UserInfo.ExchangeRateCHF = clsUser.ExchangeRateCHF
        pfrm.UserInfo.ExchangeRateEUR = clsUser.ExchangeRateEUR
        pfrm.UserInfo.ExchangeRateHKD = clsUser.ExchangeRateHKD
        pfrm.UserInfo.ExchangeRateRMB = clsUser.ExchangeRateRMB
        pfrm.UserInfo.ExchangeRateCNY = clsUser.ExchangeRateCNY
        pfrm.UserInfo.LogID = clsUser.LogID
        pfrm.UserInfo.IPAddress = clsUser.IPAddress
        pfrm.UserInfo.CanChat = clsUser.CanChat
        pfrm.UserInfo.MessageWindowStyle = clsUser.MessageWindowStyle
        pfrm.UserInfo.ImagePath = clsUser.ImagePath
        pfrm.UserInfo.MtlWarehouseID = clsUser.MtlWarehouseID  'Add By Neung 20221128 ต้องส่งไปด้วย ครับ
        CallForm(pfrm)
    End Sub
    'ProductionOrderSystem
    Private Sub callFrmProductionOrderSystem(pfrm As Object)
        pfrm.UserInfo.UserID = clsUser.UserID
        pfrm.UserInfo.UserName = clsUser.UserName
        pfrm.UserInfo.Password = clsUser.Password
        pfrm.UserInfo.ReportPath = clsUser.ReportPath
        pfrm.UserInfo.DeptCD = clsUser.DeptCD
        pfrm.UserInfo.CurrentDate = clsUser.CurrentDate
        pfrm.UserInfo.ExchangeRate = clsUser.ExchangeRate
        pfrm.UserInfo.ExchangeRateUSD = clsUser.ExchangeRateUSD
        pfrm.UserInfo.ExchangeRateJPY = clsUser.ExchangeRateJPY
        pfrm.UserInfo.ExchangeRateAUD = clsUser.ExchangeRateAUD
        pfrm.UserInfo.ExchangeRateCHF = clsUser.ExchangeRateCHF
        pfrm.UserInfo.ExchangeRateEUR = clsUser.ExchangeRateEUR
        pfrm.UserInfo.ExchangeRateHKD = clsUser.ExchangeRateHKD
        pfrm.UserInfo.ExchangeRateRMB = clsUser.ExchangeRateRMB
        pfrm.UserInfo.ExchangeRateCNY = clsUser.ExchangeRateCNY
        pfrm.UserInfo.LogID = clsUser.LogID
        pfrm.UserInfo.IPAddress = clsUser.IPAddress
        pfrm.UserInfo.CanChat = clsUser.CanChat
        pfrm.UserInfo.MessageWindowStyle = clsUser.MessageWindowStyle
        pfrm.UserInfo.ImagePath = clsUser.ImagePath
        pfrm.UserInfo.MtlWarehouseID = clsUser.MtlWarehouseID  'Add By Neung 20221128 ต้องส่งไปด้วย ครับ
        CallForm(pfrm)
    End Sub
    'YarnSystem
    Private Sub callFrmYarnSystem(pfrm As Object)
        pfrm.UserInfo.UserID = clsUser.UserID
        pfrm.UserInfo.UserName = clsUser.UserName
        pfrm.UserInfo.Password = clsUser.Password
        pfrm.UserInfo.ReportPath = clsUser.ReportPath
        pfrm.UserInfo.DeptCD = clsUser.DeptCD
        pfrm.UserInfo.CurrentDate = clsUser.CurrentDate
        pfrm.UserInfo.ExchangeRate = clsUser.ExchangeRate
        pfrm.UserInfo.ExchangeRateUSD = clsUser.ExchangeRateUSD
        pfrm.UserInfo.ExchangeRateJPY = clsUser.ExchangeRateJPY
        pfrm.UserInfo.ExchangeRateAUD = clsUser.ExchangeRateAUD
        pfrm.UserInfo.ExchangeRateCHF = clsUser.ExchangeRateCHF
        pfrm.UserInfo.ExchangeRateEUR = clsUser.ExchangeRateEUR
        pfrm.UserInfo.ExchangeRateHKD = clsUser.ExchangeRateHKD
        pfrm.UserInfo.ExchangeRateRMB = clsUser.ExchangeRateRMB
        pfrm.UserInfo.ExchangeRateCNY = clsUser.ExchangeRateCNY
        pfrm.UserInfo.LogID = clsUser.LogID
        pfrm.UserInfo.IPAddress = clsUser.IPAddress
        pfrm.UserInfo.CanChat = clsUser.CanChat
        pfrm.UserInfo.MessageWindowStyle = clsUser.MessageWindowStyle
        pfrm.UserInfo.ImagePath = clsUser.ImagePath
        pfrm.UserInfo.MtlWarehouseID = clsUser.MtlWarehouseID  'Add By Neung 20221128 ต้องส่งไปด้วย ครับ
        CallForm(pfrm)
    End Sub
    Private Sub callFrmStdParameterNotInPanel(pfrm As Object)
        pfrm.UserInfo.UserID = clsUser.UserID
        pfrm.UserInfo.UserName = clsUser.UserName
        pfrm.UserInfo.Password = clsUser.Password
        pfrm.UserInfo.ReportPath = clsUser.ReportPath
        pfrm.UserInfo.DeptCD = clsUser.DeptCD
        pfrm.UserInfo.CurrentDate = clsUser.CurrentDate
        pfrm.UserInfo.ExchangeRate = clsUser.ExchangeRate
        pfrm.UserInfo.ExchangeRateUSD = clsUser.ExchangeRateUSD
        pfrm.UserInfo.ExchangeRateJPY = clsUser.ExchangeRateJPY
        pfrm.UserInfo.ExchangeRateAUD = clsUser.ExchangeRateAUD
        pfrm.UserInfo.ExchangeRateCHF = clsUser.ExchangeRateCHF
        pfrm.UserInfo.ExchangeRateEUR = clsUser.ExchangeRateEUR
        pfrm.UserInfo.ExchangeRateHKD = clsUser.ExchangeRateHKD
        pfrm.UserInfo.ExchangeRateRMB = clsUser.ExchangeRateRMB
        pfrm.UserInfo.ExchangeRateCNY = clsUser.ExchangeRateCNY
        pfrm.UserInfo.LogID = clsUser.LogID
        pfrm.UserInfo.IPAddress = clsUser.IPAddress
        pfrm.UserInfo.CanChat = clsUser.CanChat
        pfrm.UserInfo.MessageWindowStyle = clsUser.MessageWindowStyle
        pfrm.UserInfo.ImagePath = clsUser.ImagePath
        pfrm.UserInfo.MtlWarehouseID = clsUser.MtlWarehouseID 'Add By Neung 20221128 ต้องส่งไปด้วย ครับ
        pfrm.Show()
    End Sub
    Private Sub callFrmInventoryStdParameter(pfrm As Object)
        pfrm.CompanyId = _CompanyId
        pfrm.WarehouseID = _MtlWarehouseID
        pfrm.WarehouseCode = _MtlWarehouseCd

        'pfrm.UserInfo.UserID = _UserInfo.UserID
        'pfrm.UserInfo.UserName = _UserInfo.UserName
        'pfrm.UserInfo.Password = _UserInfo.Password
        'pfrm.UserInfo.ReportPath = _UserInfo.ReportPath
        'pfrm.UserInfo.DeptCD = _UserInfo.DeptCD

        'pfrm.UserInfo.CurrentDate = _UserInfo.CurrentDate
        'pfrm.UserInfo.ExchangeRate = _UserInfo.ExchangeRate
        'pfrm.UserInfo.ExchangeRateUSD = _UserInfo.ExchangeRateUSD
        'pfrm.UserInfo.ExchangeRateJPY = _UserInfo.ExchangeRateJPY
        'pfrm.UserInfo.ExchangeRateAUD = _UserInfo.ExchangeRateAUD
        'pfrm.UserInfo.ExchangeRateCHF = _UserInfo.ExchangeRateCHF
        'pfrm.UserInfo.ExchangeRateEUR = _UserInfo.ExchangeRateEUR
        'pfrm.UserInfo.ExchangeRateHKD = _UserInfo.ExchangeRateHKD
        'pfrm.UserInfo.ExchangeRateRMB = _UserInfo.ExchangeRateRMB
        'pfrm.UserInfo.ExchangeRateCNY = _UserInfo.ExchangeRateCNY
        'pfrm.UserInfo.LogID = _UserInfo.LogID
        'pfrm.UserInfo.IPAddress = _UserInfo.IPAddress
        'pfrm.UserInfo.CanChat = _UserInfo.CanChat
        'pfrm.UserInfo.MessageWindowStyle = _UserInfo.MessageWindowStyle
        'pfrm.UserInfo.ImagePath = _UserInfo.ImagePath
        CallForm(pfrm)
    End Sub

    Private Sub callFrmInventoryStdParameterNew(pfrm As Object)
        pfrm.CompanyId = _CompanyId
        pfrm.WarehouseID = _MtlWarehouseID
        pfrm.WarehouseCode = _MtlWarehouseCd

        pfrm.UserInfo.UserID = clsUser.UserID
        pfrm.UserInfo.UserName = clsUser.UserName
        pfrm.UserInfo.Password = clsUser.Password
        pfrm.UserInfo.ReportPath = clsUser.ReportPath
        pfrm.UserInfo.DeptCD = clsUser.DeptCD
        pfrm.UserInfo.CurrentDate = clsUser.CurrentDate
        pfrm.UserInfo.ExchangeRate = clsUser.ExchangeRate
        pfrm.UserInfo.ExchangeRateTHB = clsUser.ExchangeRateTHB
        pfrm.UserInfo.ExchangeRateUSD = clsUser.ExchangeRateUSD
        pfrm.UserInfo.ExchangeRateJPY = clsUser.ExchangeRateJPY
        pfrm.UserInfo.ExchangeRateAUD = clsUser.ExchangeRateAUD
        pfrm.UserInfo.ExchangeRateCHF = clsUser.ExchangeRateCHF
        pfrm.UserInfo.ExchangeRateEUR = clsUser.ExchangeRateEUR
        pfrm.UserInfo.ExchangeRateHKD = clsUser.ExchangeRateHKD
        pfrm.UserInfo.ExchangeRateRMB = clsUser.ExchangeRateRMB
        pfrm.UserInfo.ExchangeRateCNY = clsUser.ExchangeRateCNY
        pfrm.UserInfo.LogID = clsUser.LogID
        pfrm.UserInfo.IPAddress = clsUser.IPAddress
        pfrm.UserInfo.CanChat = clsUser.CanChat
        pfrm.UserInfo.MessageWindowStyle = clsUser.MessageWindowStyle
        pfrm.UserInfo.ImagePath = clsUser.ImagePath
        pfrm.UserInfo.MtlWareHouseID = clsUser.MtlWarehouseID

        Call SetUserInfobyFrm(pfrm) 'add by neung 20220106

        pfrm.Show()
    End Sub
    Private Sub SetUserInfo(pUserInfo As Object)
        pUserInfo.UserID = clsUser.UserID
        pUserInfo.UserName = clsUser.UserName
        pUserInfo.Password = clsUser.Password
        pUserInfo.ReportPath = clsUser.ReportPath
        pUserInfo.DeptCD = clsUser.DeptCD
        pUserInfo.CurrentDate = clsUser.CurrentDate
        pUserInfo.ExchangeRate = clsUser.ExchangeRate
        pUserInfo.ExchangeRateTHB = clsUser.ExchangeRateTHB
        pUserInfo.ExchangeRateUSD = clsUser.ExchangeRateUSD
        pUserInfo.ExchangeRateJPY = clsUser.ExchangeRateJPY
        pUserInfo.ExchangeRateAUD = clsUser.ExchangeRateAUD
        pUserInfo.ExchangeRateCHF = clsUser.ExchangeRateCHF
        pUserInfo.ExchangeRateEUR = clsUser.ExchangeRateEUR
        pUserInfo.ExchangeRateHKD = clsUser.ExchangeRateHKD
        pUserInfo.ExchangeRateRMB = clsUser.ExchangeRateRMB
        pUserInfo.ExchangeRateCNY = clsUser.ExchangeRateCNY
        pUserInfo.LogID = clsUser.LogID
        pUserInfo.IPAddress = clsUser.IPAddress
        pUserInfo.CanChat = clsUser.CanChat
        pUserInfo.MessageWindowStyle = clsUser.MessageWindowStyle
        pUserInfo.ImagePath = clsUser.ImagePath
        pUserInfo.MtlWareHouseID = clsUser.MtlWarehouseID 'Add By Neung 20221128 
        ' pUserInfo.Language = clsUser.Language
    End Sub
    Private Sub SetUserInfobyFrm(ByRef pfrm As Object) 'Add By Neung 20221228
        pfrm.UserInfo.UserID = clsUser.UserID
        pfrm.UserInfo.UserName = clsUser.UserName
        pfrm.UserInfo.Password = clsUser.Password
        pfrm.UserInfo.ReportPath = clsUser.ReportPath
        pfrm.UserInfo.DeptCD = clsUser.DeptCD
        pfrm.UserInfo.CurrentDate = clsUser.CurrentDate
        pfrm.UserInfo.ExchangeRate = clsUser.ExchangeRate
        pfrm.UserInfo.ExchangeRateTHB = clsUser.ExchangeRateTHB
        pfrm.UserInfo.ExchangeRateUSD = clsUser.ExchangeRateUSD
        pfrm.UserInfo.ExchangeRateJPY = clsUser.ExchangeRateJPY
        pfrm.UserInfo.ExchangeRateAUD = clsUser.ExchangeRateAUD
        pfrm.UserInfo.ExchangeRateCHF = clsUser.ExchangeRateCHF
        pfrm.UserInfo.ExchangeRateEUR = clsUser.ExchangeRateEUR
        pfrm.UserInfo.ExchangeRateHKD = clsUser.ExchangeRateHKD
        pfrm.UserInfo.ExchangeRateRMB = clsUser.ExchangeRateRMB
        pfrm.UserInfo.ExchangeRateCNY = clsUser.ExchangeRateCNY
        pfrm.UserInfo.LogID = clsUser.LogID
        pfrm.UserInfo.IPAddress = clsUser.IPAddress
        pfrm.UserInfo.CanChat = clsUser.CanChat
        pfrm.UserInfo.MessageWindowStyle = clsUser.MessageWindowStyle
        pfrm.UserInfo.ImagePath = clsUser.ImagePath
        pfrm.UserInfo.CompanyID = clsUser.CompanyID
        pfrm.UserInfo.MtlWarehouseID = clsUser.MtlWarehouseID
        pfrm.UserInfo.Language = clsUser.Language
    End Sub
    Private Sub SetUserInfobyFrmRMA(ByRef pfrm As Object)
        pfrm.pUserInfo.UserID = clsUser.UserID
        pfrm.pUserInfo.UserName = clsUser.UserName
        pfrm.pUserInfo.Password = clsUser.Password
        pfrm.pUserInfo.ReportPath = clsUser.ReportPath
        pfrm.pUserInfo.DeptCD = clsUser.DeptCD
        pfrm.pUserInfo.CurrentDate = clsUser.CurrentDate
        pfrm.pUserInfo.ExchangeRate = clsUser.ExchangeRate
        pfrm.pUserInfo.ExchangeRateTHB = clsUser.ExchangeRateTHB
        pfrm.pUserInfo.ExchangeRateUSD = clsUser.ExchangeRateUSD
        pfrm.pUserInfo.ExchangeRateJPY = clsUser.ExchangeRateJPY
        pfrm.pUserInfo.ExchangeRateAUD = clsUser.ExchangeRateAUD
        pfrm.pUserInfo.ExchangeRateCHF = clsUser.ExchangeRateCHF
        pfrm.pUserInfo.ExchangeRateEUR = clsUser.ExchangeRateEUR
        pfrm.pUserInfo.ExchangeRateHKD = clsUser.ExchangeRateHKD
        pfrm.pUserInfo.ExchangeRateRMB = clsUser.ExchangeRateRMB
        pfrm.pUserInfo.ExchangeRateCNY = clsUser.ExchangeRateCNY
        pfrm.pUserInfo.LogID = clsUser.LogID
        pfrm.pUserInfo.IPAddress = clsUser.IPAddress
        pfrm.pUserInfo.CanChat = clsUser.CanChat
        pfrm.pUserInfo.MessageWindowStyle = clsUser.MessageWindowStyle
        pfrm.pUserInfo.ImagePath = clsUser.ImagePath
        pfrm.pUserInfo.MtlWarehouseID = clsUser.MtlWarehouseID
        pfrm.pUserInfo.Language = clsUser.Language
    End Sub
    Private Sub CallForm(pfrm As Object)
        'pfrm.toplevel = False
        'pfrm.topmost = True
        'pfrm.Focus()
        'Me.SplitContainer1.Panel2.Controls.Add(pfrm)
        'Me.SplitContainer1.Panel2.TopLevelControl.Top = True
        pfrm.StartPosition = FormStartPosition.CenterScreen 'Sitthana 20230202
        pfrm.Show()
        'pfrm.BringToFront()
    End Sub

    Private Sub CallFormWithConnection(pfrm As Object)
        'Sitthana 20221114
        pfrm.setConnectionString(conn)
        pfrm.StartPosition = FormStartPosition.CenterScreen 'Sitthana 20230202
        pfrm.Show()
        'pfrm.BringToFront()
    End Sub

    Private Sub CallFormWithSentSqlConn(pfrm As Object)
        'Sitthana 20221213
        pfrm.SqlConn = clsConnection.getSQLConnection
        pfrm.StartPosition = FormStartPosition.CenterScreen 'Sitthana 20230202
        pfrm.Show()
        'pfrm.BringToFront()
    End Sub

    'Call Form From Panel & Button
#Region "1. Setup"
    '1.1 LookupType
    'Private Sub btnLookupType_Click(sender As Object, e As EventArgs) Handles btnLookupType.Click
    '    callLookupType()
    'End Sub
    'Private Sub callLookupType()
    '    callFrmStdParameter(New ProductionSystem.frmLookUpType)
    'End Sub

    ''1.2 LookupValue
    'Private Sub btnLookupValue_Click(sender As Object, e As EventArgs) Handles btnLookupValue.Click
    '    callLookupValue()
    'End Sub
    'Private Sub callLookupValue()
    '    Dim frm As New ProductionSystem.frmLookupValue
    '    CallForm(frm)
    'End Sub
#End Region

#Region "2. Purchasing"
    '2.1 GeneralItem
    'Private Sub btnGeneralItem_Click(sender As Object, e As EventArgs) Handles btnGeneralItem.Click
    '    callGeneralItem()
    'End Sub
    Private Sub callGeneralItem()
        ' callFrmStdParameter(New PurchaseOrderSystem.frmItemsGeneralMain) 'Sitthana 20221108
    End Sub
    '2.2 MatrixItem
    'Private Sub btnMatrixItem_Click(sender As Object, e As EventArgs) Handles btnMatrixItem.Click
    '    callMatrixItem()
    'End Sub
    Private Sub callMatrixItem()
        '  callFrmStdParameter(New PurchaseOrderSystem.frmGarmentItems)
    End Sub

    Private Sub btnSupplier_Click(sender As Object, e As EventArgs) Handles btnSupplier.Click
        callFrmStdParameter(New PurchaseOrderSystem.formSupplierCreate)
    End Sub

    Private Sub btnPurchaseOrderNewEdit_Click(sender As Object, e As EventArgs) Handles btnPurchaseOrderNewEdit.Click
        callFrmPurchaseOrderSystem(New PurchaseOrderSystem.frmPurchaseOrderNewEdit)
    End Sub

    Private Sub btnPurchaseOrderNew_Click(sender As Object, e As EventArgs)
        callFrmStdParameterNotInPanel(New PurchaseOrderSystem.formPurchaseOrderCreate)
    End Sub

    Private Sub btnPurchaseOrderEdit_Click(sender As Object, e As EventArgs)
        callFrmStdParameterNotInPanel(New PurchaseOrderSystem.formPurchaseOrderEdit3)
    End Sub
#End Region

#Region "3. Order Management"
    Private Sub btnSalesOrder_Click(sender As Object, e As EventArgs) Handles btnSalesOrderMartix.Click
        callFrmStdParameterNotInPanel(New SalesOrderSystem.frmSalesOrder)
    End Sub

    Private Sub btnCustomer_Click(sender As Object, e As EventArgs) Handles btnCustomer.Click
        callFrmStdParameter(New SalesOrderSystem.frmCustomerNew)
    End Sub

    'Private Sub btnInvoiceLocal_Click(sender As Object, e As EventArgs) Handles btnARInvoice6.Click
    '    'callFrmStdParameter(New InvoiceSystem.frmInvoiceLocal)

    '    Dim frm As New ReceivablesSystem.frmArInvoice
    '    Call SetUserInfobyFrm(pfrm:=frm) 'Add By neung 20230223
    '    frm.pArTranTypeID = 6 'IV -> HS
    '    frm.ShipFromWarehouseId = clsUser.MtlWarehouseID
    '    frm.Show()
    'End Sub
#End Region

#Region "4. Inventory"
    'Private Sub btbOnHand_Click(sender As Object, e As EventArgs) Handles btnOnHand.Click
    '    Dim frm As New InventorySystem.frmStockOnHand  'Add by Neung 20221228
    '    Call SetUserInfobyFrm(frm) 'Add by Neung 20221228
    '    CallForm(frm)
    'End Sub

    'Private Sub btnPoReceipt_Click(sender As Object, e As EventArgs) Handles btnPoReceipt.Click

    '    Dim frm As New InventorySystem.frmPoReceiptMain
    '    Call SetUserInfo(frm.UserInfo)
    '    frm.CompanyId = _CompanyId
    '    ' frm.logEmpId = clsUser.UserID
    '    frm.logempcd = clsUser.UserID
    '    frm.WarehouseID = _MtlWarehouseID
    '    frm.WarehouseCode = _MtlWarehouseCd
    '    frm.Show(Me)

    '    callFrmInventoryStdParameterNew(New InventorySystem.frmPoReceiptMain) 'Sitthana 20221125
    'End Sub

    'Private Sub btnMisellaneous_Click(sender As Object, e As EventArgs) Handles btnMiscellaneous.Click
    '    Dim frm As New InventorySystem.frmInventoryMiscTrans
    '    Call SetUserInfobyFrm(frm)
    '    frm.CompanyId = _CompanyId
    '    frm.MtlWarehouseId = _MtlWarehouseID
    '    frm.MtlWarehouseCd = _MtlWarehouseCd
    '    frm.StartPosition = FormStartPosition.CenterScreen 'Sitthana 20230202
    '    frm.Show()

    'End Sub

    'Private Sub btnWhTransfer_Click(sender As Object, e As EventArgs) Handles btnWhTransfer.Click
    '    Dim frm As New InventorySystem.frmTransferInvLoc
    '    Call SetUserInfobyFrm(frm) 'Add by Neung 20221228
    '    frm.CompanyId = _CompanyId
    '    frm.MtlWarehouseID = _MtlWarehouseID
    '    frm.MtlWarehouseCd = _MtlWarehouseCd
    '    frm.MtlWarehouseName = _MtlWarehouseName
    '    frm.TransferBetweenWH = True
    '    frm.StartPosition = FormStartPosition.CenterScreen 'Sitthana 20230202
    '    frm.ShowDialog(Me)


    'End Sub

    'Private Sub btnLocTransfer_Click(sender As Object, e As EventArgs) Handles btnLocTransfer.Click
    '    Dim frm As New InventorySystem.frmTransferInvLoc
    '    Call SetUserInfobyFrm(frm)
    '    frm.CompanyId = _CompanyId
    '    'frm.logEmpId = _UserInfo.UserID
    '    frm.MtlWarehouseID = _MtlWarehouseID
    '    frm.MtlWarehouseCd = _MtlWarehouseCd
    '    frm.MtlWarehouseName = _MtlWarehouseName
    '    frm.TransferBetweenWH = False
    '    frm.StartPosition = FormStartPosition.CenterScreen 'Sitthana 20230202
    '    frm.ShowDialog(Me)
    '    'frm.BringToFront()
    'End Sub

    'Private Sub btnSubcontactTransfer_Click(sender As Object, e As EventArgs) Handles btnSubcontactTransfer.Click
    '    Dim frm As New InventorySystem.frmTransferInvSubContract
    '    Call SetUserInfobyFrm(frm)
    '    ' frm.CompanyId = _CompanyId
    '    'frm.logEmpId = _UserInfo.UserID

    '    frm.MtlWarehouseID = _MtlWarehouseID
    '    frm.MtlWarehouseCd = _MtlWarehouseCd
    '    frm.MtlWarehouseName = _MtlWarehouseName
    '    frm.TransferBetweenWH = False
    '    frm.StartPosition = FormStartPosition.CenterScreen 'Sitthana 20230202
    '    frm.Show()
    '    ' frm.BringToFront()
    'End Sub

#End Region

#Region "5. Production"
    Private Sub btnProductionOrder_Click(sender As Object, e As EventArgs) Handles btnKnittingOrder.Click
        'callFrmStdParameterNotInPanel(New ProductionSystem.frmKnittingOrderNew)
        Dim frm As New ProductionSystem.frmKnittingOrderNew
        frm.UserInfo.UserID = clsUser.UserID
        frm.UserInfo.UserName = clsUser.UserName
        frm.UserInfo.Password = clsUser.Password
        frm.UserInfo.ReportPath = clsUser.ReportPath
        frm.UserInfo.DeptCD = clsUser.DeptCD
        frm.UserInfo.CurrentDate = clsUser.CurrentDate
        frm.UserInfo.ExchangeRate = clsUser.ExchangeRate
        frm.UserInfo.ExchangeRateUSD = clsUser.ExchangeRateUSD
        frm.UserInfo.ExchangeRateJPY = clsUser.ExchangeRateJPY
        frm.UserInfo.ExchangeRateAUD = clsUser.ExchangeRateAUD
        frm.UserInfo.ExchangeRateCHF = clsUser.ExchangeRateCHF
        frm.UserInfo.ExchangeRateEUR = clsUser.ExchangeRateEUR
        frm.UserInfo.ExchangeRateHKD = clsUser.ExchangeRateHKD
        frm.UserInfo.ExchangeRateRMB = clsUser.ExchangeRateRMB
        frm.UserInfo.ExchangeRateCNY = clsUser.ExchangeRateCNY
        frm.UserInfo.LogID = clsUser.LogID
        frm.UserInfo.IPAddress = clsUser.IPAddress
        frm.UserInfo.CanChat = clsUser.CanChat
        frm.UserInfo.MessageWindowStyle = clsUser.MessageWindowStyle
        frm.UserInfo.ImagePath = clsUser.ImagePath
        frm.UserInfo.MtlWareHouseID = clsUser.MtlWarehouseID 'Add By Neung 20221128 ต้องส่งไปด้วย ครับ
        frm.pProductionOrderTypeCode = "KINO"
        frm.Show()
    End Sub

    Private Sub btnRouting_Click(sender As Object, e As EventArgs) Handles btnRouting.Click
        callFrmStdParameter(New ProductionSystem.frmRoutingMaster)
    End Sub

    Private Sub btnOperations_Click(sender As Object, e As EventArgs) Handles btnOperations.Click
        callFrmStdParameter(New ProductionSystem.frmOperationsMaster)
    End Sub

    Private Sub btnYarnInPurchase_Click(sender As Object, e As EventArgs) Handles btnYarnInPurchase.Click
        callFrmYarnSystem(New YarnStockSystem.frmYarnInPurchase)
    End Sub

    Private Sub btnYarnStockBalance_Click(sender As Object, e As EventArgs) Handles btnYarnStockBalance.Click
        callFrmYarnSystem(New YarnStockSystem.formPrintYarnMoveByBox)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnYarnMaster.Click
        callFrmPurchaseOrderSystem(New PurchaseOrderSystem.formYarnMaster)
    End Sub

    Private Sub btnAgents_Click(sender As Object, e As EventArgs) Handles btnAgent.Click
        callFrmStdParameter(New SalesOrderSystem.frmAgent)
    End Sub

    Private Sub btnDesignMaster_Click(sender As Object, e As EventArgs) Handles btnDesignMaster.Click
        callFrmStdParameterNotInPanel(New ProductionSystem.frmDesignNew)
    End Sub

    Private Sub btnEndBuyer_Click(sender As Object, e As EventArgs) Handles btnEndBuyer.Click
        callFrmStdParameter(New SalesOrderSystem.frmEndBuyers)
    End Sub

    Private Sub btnColor_Click(sender As Object, e As EventArgs) Handles btnColor.Click
        callFrmStdParameter(New SalesOrderSystem.frmColor)
    End Sub

    Private Sub btnDesignBOM_Click(sender As Object, e As EventArgs) Handles btnDesignBOM.Click
        callFrmStdParameter(New ProductionSystem.frmDesignBOMNew)
    End Sub

    Private Sub btnMachines_Click(sender As Object, e As EventArgs) Handles btnMachines.Click
        callFrmStdParameter(New ProductionSystem.frmMachine)
    End Sub

    Private Sub btnJobYarn_Click(sender As Object, e As EventArgs) Handles btnJobYarn.Click
        callFrmStdParameter(New YarnStockSystem.formJobOrderYarnNewEdit)
    End Sub

    Private Sub btnYarnOut_Click(sender As Object, e As EventArgs) Handles btnYarnOut.Click
        callFrmStdParameter(New YarnStockSystem.formYarnout)
    End Sub

    Private Sub btnItems_Click(sender As Object, e As EventArgs) Handles btnItems.Click
        callFrmPurchaseOrderSystem(New PurchaseOrderSystem.formItemMaster)
    End Sub

    Private Sub btnYarnInReturn_Click(sender As Object, e As EventArgs) Handles btnYarnInReturn.Click
        callFrmStdParameter(New YarnStockSystem.formYarnInReturn)
    End Sub

    Private Sub btnYarnInReturnProcess_Click(sender As Object, e As EventArgs) Handles btnYarnInReturnProcess.Click
        callFrmStdParameter(New YarnStockSystem.formYarnInProcessReturn)
    End Sub

    Private Sub btnWarpingOrder_Click(sender As Object, e As EventArgs) Handles btnWarpingOrder.Click
        Dim frm As New ProductionSystem.frmKnittingOrderNew
        frm.UserInfo.UserID = clsUser.UserID
        frm.UserInfo.UserName = clsUser.UserName
        frm.UserInfo.Password = clsUser.Password
        frm.UserInfo.ReportPath = clsUser.ReportPath
        frm.UserInfo.DeptCD = clsUser.DeptCD
        frm.UserInfo.CurrentDate = clsUser.CurrentDate
        frm.UserInfo.ExchangeRate = clsUser.ExchangeRate
        frm.UserInfo.ExchangeRateUSD = clsUser.ExchangeRateUSD
        frm.UserInfo.ExchangeRateJPY = clsUser.ExchangeRateJPY
        frm.UserInfo.ExchangeRateAUD = clsUser.ExchangeRateAUD
        frm.UserInfo.ExchangeRateCHF = clsUser.ExchangeRateCHF
        frm.UserInfo.ExchangeRateEUR = clsUser.ExchangeRateEUR
        frm.UserInfo.ExchangeRateHKD = clsUser.ExchangeRateHKD
        frm.UserInfo.ExchangeRateRMB = clsUser.ExchangeRateRMB
        frm.UserInfo.ExchangeRateCNY = clsUser.ExchangeRateCNY
        frm.UserInfo.LogID = clsUser.LogID
        frm.UserInfo.IPAddress = clsUser.IPAddress
        frm.UserInfo.CanChat = clsUser.CanChat
        frm.UserInfo.MessageWindowStyle = clsUser.MessageWindowStyle
        frm.UserInfo.ImagePath = clsUser.ImagePath
        frm.UserInfo.MtlWareHouseID = clsUser.MtlWarehouseID 'Add By Neung 20221128 ต้องส่งไปด้วย ครับ
        frm.pProductionOrderTypeCode = "WONO"
        frm.Show()
    End Sub

    Private Sub btnDyingOrder_Click(sender As Object, e As EventArgs) Handles btnDyingOrder.Click
        callFrmStdParameterNotInPanel(New SalesOrderSystem.frmDyingOrderV01)
    End Sub

    Private Sub btnOperaionWarp_Click(sender As Object, e As EventArgs) Handles btnOperaionWarp.Click
        callFrmPurchaseOrderSystem(New ProductionSystem.frmOperationWarp)
    End Sub

    Private Sub btnOperationKnitting_Click(sender As Object, e As EventArgs) Handles btnOperationKnitting.Click
        callFrmPurchaseOrderSystem(New ProductionSystem.frmOperationKnittingNEW)
    End Sub

    Private Sub btnGreigeOutDF_Click(sender As Object, e As EventArgs) Handles btnGreigeOutDF.Click
        callFrmStdParameterNotInPanel(New SalesOrderSystem.frmGreigeOut)
    End Sub

    Private Sub btnStockDINManual_Click(sender As Object, e As EventArgs) Handles btnStockDINManual.Click
        callFrmStdParameterNotInPanel(New SalesOrderSystem.frmStockDINManual)
    End Sub

    Private Sub btnRequestGreige_Click(sender As Object, e As EventArgs) Handles btnRequestGreige.Click
        callFrmStdParameterNotInPanel(New SalesOrderSystem.frmRequestG)
    End Sub

    Private Sub btnRequestDyed_Click(sender As Object, e As EventArgs) Handles btnRequestDyed.Click
        Dim frm As New SalesOrderSystem.frmRequestD
        SetUserInfo(frm.UserInfo)
        frm.pStockType = "D" 'D, C S
        frm.pRequestSampleStock = "N" 'For use Stock Dyed or Stock Sample
        frm.Text = "Request Dyed"
        frm.Show()
    End Sub

    Private Sub btnPackingListGreige_Click(sender As Object, e As EventArgs) Handles btnPackingListGreige.Click
        callFrmStdParameterNotInPanel(New SalesOrderSystem.frmPackingListGreige)
    End Sub

    Private Sub btnPackingListDyed_Click(sender As Object, e As EventArgs) Handles btnPackingListDyed.Click
        Dim frm As New SalesOrderSystem.frmPackingListDyed
        SetUserInfo(frm.Userinfo)
        frm.pStockType = "D"
        frm.Text = "Packing List Dyed"
        frm.Show()
    End Sub

    Private Sub btnInvoiceLocal_Click(sender As Object, e As EventArgs) Handles btnInvoiceLocal.Click
        callFrmStdParameterNotInPanel(New InvoiceSystemESH.frmInvoiceLocal)
    End Sub

    Private Sub btnInvoiceExport_Click(sender As Object, e As EventArgs) Handles btnInvoiceExport.Click
        callFrmStdParameterNotInPanel(New InvoiceSystemESH.frmInvoiceExport)
    End Sub

    Private Sub btnCuttingIn_Click(sender As Object, e As EventArgs)
        callFrmStdParameterNotInPanel(New SalesOrderSystem.frmCuttingIN)
    End Sub

    Private Sub btnStockGOnhand_Click(sender As Object, e As EventArgs) Handles btnStockOnhand.Click
        callFrmStdParameterNotInPanel(New SalesOrderSystem.frmStockOnhand)
    End Sub

    Private Sub btnPrintYarnOutDocument_Click(sender As Object, e As EventArgs) Handles btnPrintYarnOutDocument.Click
        callFrmYarnSystem(New YarnStockSystem.frmPrintYarnOutDocument)
    End Sub

    Private Sub btnGINDocument_Click(sender As Object, e As EventArgs) Handles btnGINDocument.Click
        callFrmStdParameter(New SalesOrderSystem.frmGINDocument)
    End Sub

    Private Sub btnGOUTDocument_Click(sender As Object, e As EventArgs) Handles btnGOUTDocument.Click
        callFrmStdParameter(New SalesOrderSystem.frmGOUTDocument)
    End Sub

    Private Sub btnDyedOutFromRequest_Click(sender As Object, e As EventArgs) Handles btnDyedOutFromRequest.Click
        callFrmStdParameter(New SalesOrderSystem.frmDyedOutFromRequest)
    End Sub

    Private Sub btnInvLocal_Click(sender As Object, e As EventArgs)
        callFrmStdParameter(New InvoiceSystemESH.frmInvoiceLocal)
    End Sub

    Private Sub btnExport_Click(sender As Object, e As EventArgs)
        callFrmStdParameter(New InvoiceSystemESH.frmInvoiceExport)
    End Sub

    Private Sub btnCreditNote_Click(sender As Object, e As EventArgs) Handles btnCreditNote.Click
        callFrmStdParameter(New InvoiceSystemESH.frmCreditNoteExport)
    End Sub

    Private Sub btnDebitNote_Click(sender As Object, e As EventArgs) Handles btnDebitNote.Click
        callFrmStdParameter(New InvoiceSystemESH.frmDebitNoteExport)
    End Sub

    Private Sub btnPrintYarnINDocument_Click(sender As Object, e As EventArgs) Handles btnPrintYarnINDocument.Click
        callFrmStdParameter(New YarnStockSystem.frmPrintYarnInDocument)
    End Sub

    Private Sub btnCuttingOrder_Click(sender As Object, e As EventArgs)
        'callFrmStdParameterNotInPanel(New ProductionSystem.frmKnittingOrderNew)
        Dim frm As New ProductionSystem.frmKnittingOrderNew
        frm.UserInfo.UserID = clsUser.UserID
        frm.UserInfo.UserName = clsUser.UserName
        frm.UserInfo.Password = clsUser.Password
        frm.UserInfo.ReportPath = clsUser.ReportPath
        frm.UserInfo.DeptCD = clsUser.DeptCD
        frm.UserInfo.CurrentDate = clsUser.CurrentDate
        frm.UserInfo.ExchangeRate = clsUser.ExchangeRate
        frm.UserInfo.ExchangeRateTHB = clsUser.ExchangeRateTHB
        frm.UserInfo.ExchangeRateUSD = clsUser.ExchangeRateUSD
        frm.UserInfo.ExchangeRateJPY = clsUser.ExchangeRateJPY
        frm.UserInfo.ExchangeRateAUD = clsUser.ExchangeRateAUD
        frm.UserInfo.ExchangeRateCHF = clsUser.ExchangeRateCHF
        frm.UserInfo.ExchangeRateEUR = clsUser.ExchangeRateEUR
        frm.UserInfo.ExchangeRateHKD = clsUser.ExchangeRateHKD
        frm.UserInfo.ExchangeRateRMB = clsUser.ExchangeRateRMB
        frm.UserInfo.ExchangeRateCNY = clsUser.ExchangeRateCNY
        frm.UserInfo.LogID = clsUser.LogID
        frm.UserInfo.IPAddress = clsUser.IPAddress
        frm.UserInfo.CanChat = clsUser.CanChat
        frm.UserInfo.MessageWindowStyle = clsUser.MessageWindowStyle
        frm.UserInfo.ImagePath = clsUser.ImagePath
        frm.UserInfo.MtlWareHouseID = clsUser.MtlWarehouseID 'Add By Neung 20221128 ต้องส่งไปด้วย ครับ
        frm.pProductionOrderTypeCode = "KINO"
        frm.Show()
    End Sub

    Private Sub btnGreigeInPurchase_Click(sender As Object, e As EventArgs) Handles btnGreigeInPurchase.Click
        callFrmStdParameterNotInPanel(New SalesOrderSystem.frmStockGINPurchase)
    End Sub

    Private Sub btnDyedInPurchase_Click(sender As Object, e As EventArgs) Handles btnDyedInPurchase.Click
        callFrmStdParameterNotInPanel(New SalesOrderSystem.frmStockDINPurchase)
    End Sub

    Private Sub btnOperationCutting_Click(sender As Object, e As EventArgs)
        callFrmStdParameterNotInPanel(New SalesOrderSystem.frmCuttingIN)
    End Sub

    Private Sub btnStockMovement_Click(sender As Object, e As EventArgs) Handles btnStockMovement.Click
        callFrmStdParameterNotInPanel(New SalesOrderSystem.frmStockMovement)
    End Sub

    Private Sub btnRequestCutting_Click(sender As Object, e As EventArgs) Handles btnRequestCutting.Click
        Dim frm As New SalesOrderSystem.frmRequestD
        SetUserInfo(frm.UserInfo)
        frm.pStockType = "C" 'D, C S
        frm.pRequestSampleStock = "N" 'For use Stock Dyed or Stock Sample
        frm.Text = "Request Cutting"
        frm.Show()
    End Sub

    Private Sub btnCuttingInPurchase_Click(sender As Object, e As EventArgs) Handles btnCuttingInPurchase.Click
        Dim frm As New SalesOrderSystem.frmStockDINPurchase
        SetUserInfo(frm.UserInfo)
        frm.pStockType = "C"
        frm.Text = "CIN Purchase"
        frm.Show()
    End Sub

    Private Sub btnCuttingInFromDOut_Click(sender As Object, e As EventArgs) Handles btnCuttingInFromDOut.Click
        Dim frm As New SalesOrderSystem.frmCuttingIN
        SetUserInfo(frm.UserInfo)
        frm.Text = "CIN"
        frm.Show()
    End Sub

    Private Sub btnPackingListCutting_Click(sender As Object, e As EventArgs) Handles btnPackingListCutting.Click
        Dim frm As New SalesOrderSystem.frmPackingListDyed
        SetUserInfo(frm.Userinfo)
        frm.pStockType = "C"
        frm.Text = "Packing List Cutting"
        frm.Show()
    End Sub

#End Region

#Region "6.Shipping"
    'Private Sub btnDelivery_Click(sender As Object, e As EventArgs) Handles btnDelivery.Click
    '    Dim frm As New InventorySystem.frmDelivery
    '    Call SetUserInfobyFrm(frm)
    '    frm.CompanyId = _CompanyId
    '    frm.MtlWarehouseID = _MtlWarehouseID
    '    frm.MtlWarehouseCd = _MtlWarehouseCd
    '    frm.MtlWarehouseName = _MtlWarehouseName
    '    frm.StartPosition = FormStartPosition.CenterScreen 'Sitthana 20230202
    '    frm.Show()
    'End Sub
#End Region

#Region "7. Costing"
    ' Private Sub btnFGCost_Click(sender As Object, e As EventArgs) Handles btnFGCost.Click
    '  Dim frm As New ProductionSystem.frmFGCost
    ' frm.Show()
    '   End Sub

#End Region

    'Private Sub btnInventoryQATestResultReport_Click(sender As Object, e As EventArgs) Handles btnInventoryQATestResultReport.Click
    '    callFrmStdParameter(New InventorySystem.frmQASample)
    'End Sub

    'Private Sub btnOnhandPivot_Click(sender As Object, e As EventArgs) Handles btnOnhandPivot.Click
    '    callFrmStdParameter(New InventorySystem.frmStockOnHandPivot)
    'End Sub

    'Private Sub btnPOControlCenter_Click(sender As Object, e As EventArgs) Handles btnPOControlCenter.Click
    '    callFrmStdParameter(New PurchaseOrderSystem.frmPOControlCenter) 'saharat 20230405
    'End Sub

    'Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnARInvoice17.Click
    '    Dim frm As New ReceivablesSystem.frmArInvoice
    '    Call SetUserInfobyFrm(pfrm:=frm) 'Add By neung 20230223
    '    frm.pArTranTypeID = 17 'IC -> IV
    '    frm.ShipFromWarehouseId = clsUser.MtlWarehouseID
    '    frm.Show()
    'End Sub

    'Private Sub btnARInvoice18_Click(sender As Object, e As EventArgs) Handles btnARInvoice18.Click
    '    Dim frm As New ReceivablesSystem.frmArInvoice
    '    Call SetUserInfobyFrm(pfrm:=frm) 'Add By neung 20230223
    '    frm.pArTranTypeID = 18 ' = "INVLOCAI" 'AI
    '    frm.ShipFromWarehouseId = clsUser.MtlWarehouseID
    '    frm.Show()
    'End Sub

    'Private Sub btnArInvoice20_Click(sender As Object, e As EventArgs) Handles btnArInvoice20.Click
    '    Dim frm As New ReceivablesSystem.frmArInvoice
    '    Call SetUserInfobyFrm(pfrm:=frm) 'Add By neung 20230110
    '    frm.pArTranTypeID = 20 'OS
    '    frm.ShipFromWarehouseId = clsUser.MtlWarehouseID
    '    frm.Show()
    'End Sub

    'Private Sub btnRMAReceipt_Click(sender As Object, e As EventArgs) Handles btnRMAReceipt.Click
    '    selectFromMdInventory("ndInventoryTransactionsRMAReceipt")
    'End Sub

    'Private Sub btnArInvoice21_Click(sender As Object, e As EventArgs) Handles btnArInvoice21.Click
    '    Dim frm As New ReceivablesSystem.frmArInvoice
    '    Call SetUserInfobyFrm(pfrm:=frm) 'Add By neung 20250425
    '    frm.pArTranTypeID = 21 'ON
    '    frm.ShipFromWarehouseId = clsUser.MtlWarehouseID
    '    frm.Show()
    'End Sub

    'Private Sub btnArInvoice22_Click(sender As Object, e As EventArgs) Handles btnArInvoice22.Click
    '    Dim frm As New ReceivablesSystem.frmArInvoice
    '    Call SetUserInfobyFrm(pfrm:=frm) 'Add By neung 20250425
    '    frm.pArTranTypeID = 22 'SA
    '    frm.ShipFromWarehouseId = clsUser.MtlWarehouseID
    '    frm.Show()
    'End Sub

    'Private Sub btnArInvoiceAll_Click(sender As Object, e As EventArgs) Handles btnArInvoiceAll.Click
    '    Dim frm As New ReceivablesSystem.frmArInvoice
    '    Call SetUserInfobyFrm(pfrm:=frm) 'Add By neung 20250425
    '    frm.pArTranTypeID = Nothing 'Nothing
    '    frm.ShipFromWarehouseId = clsUser.MtlWarehouseID
    '    frm.Show()
    'End Sub

    'Private Sub btnTransferInvLocMulti_Click(sender As Object, e As EventArgs) Handles btnTransferInvLocMulti.Click
    '    Dim frm As New InventorySystem.frmTransferInvLocMulti
    '    Call SetUserInfobyFrm(pfrm:=frm)
    '    frm.CompanyId = _CompanyId
    '    frm.MtlWarehouseID = _MtlWarehouseID
    '    frm.MtlWarehouseCd = _MtlWarehouseCd
    '    frm.MtlWarehouseName = _MtlWarehouseName
    '    'frm.TransferBetweenWH = False
    '    CallForm(frm)
    'End Sub

    'Private Sub frmLotDetail_Click(sender As Object, e As EventArgs) Handles frmLotDetail.Click
    '    selectFromMdInventory("ndInventoryLotDetails")
    'End Sub
End Class
