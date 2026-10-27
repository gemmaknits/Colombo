Imports System.Data.Common
Imports System.Data.SqlClient
Imports System.Security.Cryptography.Xml
Imports System.Text
Imports Microsoft.ReportingServices.ReportProcessing.ReportObjectModel
Public Class frmListOfValues

#Region "Table & Valiable"
    Dim dtSearchTable As New DataTable
    Dim bsSearchTable As New BindingSource
    Dim drvSearchTable As DataRowView
    Private DataForFind As String = ""
    '
    Private UserValueFound As Boolean = False
    Private _ValueFoundAutoClose As Boolean = True ' set default is True
    Private UserNoDataFound As Boolean = False
    Private _NoDataAutoClose As Boolean = False ' set default is True
    Private _FilterItemCatCode As String()
    Private _FilterText As String
    '
    Private Const FIND_COLORS As String = "Colors"
    Private Const FIND_THREAD_CLIPPING As String = "code for thread clipping"
    Private Const FIND_ITEMS As String = "Items"
    Private Const FIND_SUPPLIERS As String = "Suppliers"
    Private Const FIND_PIECE_DYE_COLOR As String = "Piece Dye Color"
    Private Const FIND_ITEMS_VARIANT As String = "Items Variant"
    Private Const FIND_CUSTOMERS As String = "Customers"
    Private Const FIND_BILL_TO_SITE As String = "bill to site"
    Private Const FIND_SHIP_TO_SITE As String = "ship to site"
    Private Const FIND_SO As String = "SO"
    Private Const FIND_SOITM As String = "SOITM"
    Private Const FIND_SOITM_FOR_PO_LINE As String = "soitm for po line"
    Private Const FIND_SO_TEST As String = "SO Req" ' Require filter text
    Private Const FIND_BANKS As String = "Banks"
    Private Const FIND_GRADES As String = "Grades"
    Private Const FIND_MFG_BOM_HEADER As String = "Bom Header" ' << This for By Item ID
    Private Const FIND_COLORIT As String = "Colorit" ' << This for By Item ID
    Private Const FIND_MFG_BOM_HEADER_LIST As String = "BOM Header List"
    Private Const FIND_CALC_BOM_HEADER_LIST As String = "Calc BOM Header List"
    Private Const FIND_MFG_ROUTING_HEADER As String = "routing_header"
    Private Const FIND_TRN_NUMBER As String = "Transaction Number"
    Private Const FIND_PO_HEADER As String = "PO Header"
    Private Const FIND_PO_HEADER_SUBCONTRACT As String = "PO Header SubContract"
    Private Const FIND_PO_LINE As String = "PO Line"
    Private Const FIND_PO_LINE_SUBCONTRACT As String = "PO Line SubContract"
    Private Const FIND_WAREHOUSE As String = "Warehouse"
    Private Const FIND_SUBINVENTORY As String = "Subinventory"
    Private Const FIND_LOCATION As String = "Location"
    Private Const FIND_UOM As String = "Uom"
    Private Const FIND_UOM_BY_CLASS As String = "Uom By Class"
    Private Const FIND_YARN_MAKEUP As String = "Yarn Makeup"
    Private Const FIND_OPERATION_PLAN_FROM_SOITM_LIST As String = "Operation Plan from so"
    Private Const FIND_MTL_TRAN_TYPE As String = "MTL Tran Type"
    Private Const FIND_MTL_TRAN_REASON As String = "MTL Tran Reason"
    Private Const FIND_DEPARTMENTS As String = "Departments"
    Private Const FIND_EMPLOYEE As String = "Employee"
    Private Const FIND_ONHAND_PARENT_LOT As String = "MTL Onhand Parent Lot"
    Private Const FIND_CHILD_PRODUCTION_ORDER As String = "Child Production Order"
    Private Const FIND_MACHINES As String = "Machines"
    Private Const FIND_OPERATIONS As String = "Operations"
    Private Const FIND_AR_PAYMENT_TERMS As String = "AR Payment Terms"
    Private Const FIND_AP_PAYMENT_TERMS As String = "AP Payment Terms"
    Private Const FIND_DYE_JOB As String = "Dye Job No"
    Private Const FIND_ORDER_SET As String = "Order Set"
    Private Const FIND_DELIVERY_HEADER As String = "Delivery Header"
    Private Const FIND_STEP_NUMBER As String = "Step Number"
    Private Const FIND_SET_LIST As String = "Set List"
    Private Const FIND_SET_LIST_UPSTEP_STITCH As String = "Search Set List UpStep Stitch"
    Private Const FIND_SALES_PERSON_LIST As String = "Sales Person List"

    Private Const FIND_TRANSFER_SUBCONTRACT As String = "Transfer SubContract"
    Private Const FIND_TRANSFER_WH As String = "Transfer WH"
    Private Const FIND_TRANSFER_LOCATION As String = "Transfer Location"
    Private Const FIND_SHIP_VIA As String = "Ship Via"
    Private Const FIND_PRODUCTION_ORDER_HEADER As String = "Production Order Header"
    Private Const FIND_MATERIAL_LINE As String = "Material Line"
    Private Const FIND_PRODUCT_LINE As String = "Product Line"
    Private Const FIND_CODE_LEFT_RIGHT As String = "Code Left Right"

    Private Const FIND_AR_INVOICE_HEADER As String = "Ar Invoice Header"
    Private Const FIND_CALC_HEADER_LIST As String = "Calc Header List"
    Private Const FIND_EFFICIENCY As String = "Efficiency"
    Private Const FIND_TARIFF_HEADER_LIST As String = "Tariff Header List"
    Private Const FIND_TARIFF_LINE_LIST As String = "Tariff Line List"
    Private Const FIND_CUSTOMER_ITEMS_XREF_LIST As String = "Customer Items XRef List"
    '
    Dim _AppUserID As String
    Dim _AppCompanyID As Integer
    Dim _AppSessionID As Integer
    Dim _AppConn As SqlConnection
    Dim _AppDBName As String
    '

    Private _ItemId As Nullable(Of Int64)
    Private _ItemCode As String
    Private _Itnaturecd As String
    Private _WarehouseID As Nullable(Of Int64)
    Private _SubInventoryID As Nullable(Of Int64)
    Private _TxnTypeCode As String
    Private _UomCode As String
    Private _MfgBomHeaderId As Nullable(Of Int64)
    Private _MTLTranTypeID As Nullable(Of Int64)
    Private _DepartmentsCode As String
    Private _EmployeeCode As String
    Private _ParentProductionOrderId As Nullable(Of Int64)
    Private _SupplierId As Nullable(Of Int64)
    Private _PoHeaderId As Nullable(Of Int64)
    Private _SetNo As String
    Private _UomClassId As Nullable(Of Int64)
    Private _CompanyId As Nullable(Of Int64)
    Private _ProductionOrderTypeId As Nullable(Of Int64)
    Private _TariffType As String
    Private _Custcd As String
    Property _SoHeaderId As Nullable(Of Int64)


    '
    Dim _UserAction As String 'Ok or Exit
#End Region

#Region "Public Property"
    Public Property AppConnection As SqlConnection
        Get
            AppConnection = _AppConn
        End Get
        Set(ByVal Newvalue As SqlConnection)
            ' Sets the field from an external call.
            _AppConn = Newvalue
        End Set
    End Property
    Public Property AppDBName As String
        Get
            AppDBName = _AppDBName
        End Get
        Set(ByVal Newvalue As String)
            ' Sets the field from an external call.
            _AppDBName = Newvalue
        End Set
    End Property

    Public Property AppCompanyID As Integer
        Get
            AppCompanyID = _AppCompanyID
        End Get
        Set(ByVal Newvalue As Integer)
            ' Sets the field from an external call.
            _AppCompanyID = Newvalue
        End Set
    End Property
    Public Property AppUserId As String
        Get
            AppUserId = _AppUserID
        End Get
        Set(ByVal Newvalue As String)
            ' Sets the field from an external call.
            _AppUserID = Newvalue
        End Set
    End Property
    Public Property AppSessionID As Integer
        Get
            AppSessionID = _AppSessionID
        End Get
        Set(value As Integer)
            ' Sets the field from an external call.
            _AppSessionID = value
        End Set
    End Property

    Public Property pUserAction As String
        Get
            pUserAction = _UserAction
        End Get
        Set(ByVal Newvalue As String)
            _UserAction = Newvalue
        End Set
    End Property
    Public Property pdrvSearchTable As DataRowView
        Get
            pdrvSearchTable = drvSearchTable
        End Get
        Set(ByVal Newvalue As DataRowView)
            drvSearchTable = Newvalue
        End Set
    End Property
    Public Property pItemId As Nullable(Of Int64)
        Get
            pItemId = _ItemId
        End Get
        Set(value As Nullable(Of Int64))
            _ItemId = value
        End Set
    End Property
    Public Property pItemCode As String
        Get
            pItemCode = _ItemCode
        End Get
        Set(ByVal Newvalue As String)
            _ItemCode = Newvalue
        End Set
    End Property

    Public Property pItnatureCd As String
        Get
            pItnatureCd = _Itnaturecd
        End Get
        Set(ByVal Newvalue As String)
            _Itnaturecd = Newvalue
        End Set
    End Property
    Public Property pFilterText As String
        Get
            pFilterText = _FilterText
        End Get
        Set(ByVal Newvalue As String)
            _FilterText = Newvalue
        End Set
    End Property
    Public Property pFilterItemCatCode As String()
        Get
            pFilterItemCatCode = _FilterItemCatCode
        End Get
        Set(ByVal Newvalue As String())
            _FilterItemCatCode = Newvalue
        End Set
    End Property
    Public Property pUserValueFound As Boolean
        Get
            pUserValueFound = UserValueFound
        End Get
        Set(ByVal Newvalue As Boolean)
            UserValueFound = Newvalue
        End Set
    End Property
    Public Property pWarehouseID As Nullable(Of Int64) 'String
        Get
            pWarehouseID = _WarehouseID
        End Get
        Set(ByVal Newvalue As Nullable(Of Int64)) 'String)
            _WarehouseID = Newvalue
        End Set
    End Property
    Public Property pSubInventoryID As Nullable(Of Int64)
        Get
            pSubInventoryID = _SubInventoryID
        End Get
        Set(ByVal Newvalue As Nullable(Of Int64))
            _SubInventoryID = Newvalue
        End Set
    End Property
    Public Property pTxnTypeCode As String
        Get
            pTxnTypeCode = _TxnTypeCode
        End Get
        Set(ByVal Newvalue As String)
            _TxnTypeCode = Newvalue
        End Set
    End Property
    Public Property pUomCode As String
        Get
            pUomCode = _UomCode
        End Get
        Set(ByVal Newvalue As String)
            _UomCode = Newvalue
        End Set
    End Property
    Public Property pValueFoundAutoClose As Boolean
        Get
            pValueFoundAutoClose = _ValueFoundAutoClose
        End Get
        Set(ByVal Newvalue As Boolean)
            _ValueFoundAutoClose = Newvalue
        End Set
    End Property
    Public Property pNoDataAutoClose As Boolean
        Get
            pNoDataAutoClose = _NoDataAutoClose
        End Get
        Set(ByVal Newvalue As Boolean)
            _NoDataAutoClose = Newvalue
        End Set
    End Property
    Public Property pMfgBomHeaderId As Nullable(Of Int64)
        Get
            pMfgBomHeaderId = _MfgBomHeaderId
        End Get
        Set(ByVal NewValue As Nullable(Of Int64))
            _MfgBomHeaderId = NewValue
        End Set
    End Property
    Public Property pMTLTranTypeID As Nullable(Of Int64)
        Get
            pMTLTranTypeID = _MTLTranTypeID
        End Get
        Set(ByVal NewValue As Nullable(Of Int64))
            _MTLTranTypeID = NewValue
        End Set
    End Property
    Public Property pDepartmentsCode As String
        Get
            pDepartmentsCode = _DepartmentsCode
        End Get
        Set(ByVal Newvalue As String)
            _DepartmentsCode = Newvalue
        End Set
    End Property
    Public Property pEmployeeCode As String
        Get
            pEmployeeCode = _EmployeeCode
        End Get
        Set(ByVal Newvalue As String)
            _EmployeeCode = Newvalue
        End Set
    End Property
    Public Property pSoHeaderId As Nullable(Of Int64)
        Get
            pSoHeaderId = _SoHeaderId
        End Get
        Set(ByVal NewValue As Nullable(Of Int64))
            _SoHeaderId = NewValue
        End Set
    End Property
    Public Property pParentProductionOrderId As Nullable(Of Int64)
        Get
            pParentProductionOrderId = _ParentProductionOrderId
        End Get
        Set(ByVal NewValue As Nullable(Of Int64))
            _ParentProductionOrderId = NewValue
        End Set
    End Property
    Public Property pSupplierId As Nullable(Of Int64)
        Get
            pSupplierId = _SupplierId
        End Get
        Set(ByVal Newvalue As Nullable(Of Int64))
            _SupplierId = Newvalue
        End Set
    End Property
    Public Property pPoHeaderId As Nullable(Of Int64)
        Get
            pPoHeaderId = _PoHeaderId
        End Get
        Set(ByVal Newvalue As Nullable(Of Int64))
            _PoHeaderId = Newvalue
        End Set
    End Property
    Public Property pSetNo As String
        Get
            pSetNo = _SetNo
        End Get
        Set(ByVal Newvalue As String)
            _SetNo = Newvalue
        End Set
    End Property
    Public Property pUomClassId As Nullable(Of Int64)
        Get
            pUomClassId = _UomClassId
        End Get
        Set(ByVal Newvalue As Nullable(Of Int64))
            _UomClassId = Newvalue
        End Set
    End Property
    Public Property pCompanyId As Nullable(Of Int64)
        Get
            pCompanyId = _CompanyId
        End Get
        Set(ByVal Newvalue As Nullable(Of Int64))
            _CompanyId = Newvalue
        End Set
    End Property
    Public Property pProductionOrderTypeId As Nullable(Of Int64)
        Get
            pProductionOrderTypeId = _ProductionOrderTypeId
        End Get
        Set(ByVal Newvalue As Nullable(Of Int64))
            _ProductionOrderTypeId = Newvalue
        End Set
    End Property
    Public Property pTariffType As String
        Get
            pItemCode = _TariffType
        End Get
        Set(ByVal Newvalue As String)
            _TariffType = Newvalue
        End Set
    End Property
    Public Property pCustcd As String
        Get
            pCustcd = _Custcd
        End Get
        Set(ByVal Newvalue As String)
            _Custcd = Newvalue
        End Set
    End Property
#End Region

    Public Sub New(pDataForFind As String)
        ' This call is required by the designer.
        InitializeComponent()
        ' Add any initialization after the InitializeComponent() call.
        DataForFind = pDataForFind


    End Sub

    Public Overridable Sub OkButtonClicked()
        _UserAction = "OK"
        Me.Close()
    End Sub

    Public Function ShowFrm()
        txtFilterText.Text = _FilterText
        getAndShowDataRec()

        If UserValueFound = True Then
            'กรณีที่เจอ และ ส่งข้อมูลฟิลเตอร์ ให้นำข้อมูลแรกกลับไป
            _UserAction = "OK"
            Me.Close()
            Return drvSearchTable
            'ElseIf txtFilterText.Text.Length = 0 And bsSearchTable.Current("") <>  Then
            '    'กรณีที่ไม่ได้ส่งอะไรมา Filter เลย และมี การเปลี่ยน id
            '    pUserAction = "NONE"
            '    drvSearchTable = DirectCast(bsSearchTable.AddNew(), DataRowView)
            '    bsSearchTable.MoveLast()
            '    Me.Close()
            '    Return drvSearchTable
        ElseIf UserNoDataFound = True Then
            _UserAction = "CANCEL"
            Me.Close()
        Else
            Me.ShowDialog()
            Return drvSearchTable
        End If

    End Function
    Private Sub getAndShowDataRec()
        Me.Cursor = Cursors.WaitCursor

        _FilterText = txtFilterText.Text.Trim

        Dim oListOfvalue As New classListOfValue

        Select Case DataForFind
            Case FIND_COLORS
                dtSearchTable = oListOfvalue.selectColorsList(_FilterText, _AppSessionID, _AppUserID, _AppConn)
            Case FIND_ITEMS
                dtSearchTable = oListOfvalue.selectItemsList(_FilterText, _FilterItemCatCode, _AppSessionID, _AppUserID, _AppConn)
            Case FIND_THREAD_CLIPPING '"code for thread clipping"
                dtSearchTable = oListOfvalue.selectClipInstrLookUpList(_FilterText, _AppSessionID, _AppUserID, _AppConn)
            Case FIND_SUPPLIERS
                dtSearchTable = oListOfvalue.selectSuppliersList(_FilterText, _AppSessionID, _AppUserID, _AppConn)
            Case FIND_PIECE_DYE_COLOR
                dtSearchTable = oListOfvalue.selectPieceDyeColorsList(_FilterText, _AppSessionID, _AppUserID, _AppConn)
            Case FIND_ITEMS_VARIANT
                dtSearchTable = oListOfvalue.selectItemsVariantList(_FilterText, _ItemId, _AppSessionID, _AppUserID, _AppConn)
            Case FIND_CUSTOMERS
                dtSearchTable = oListOfvalue.selectCustomersList(_FilterText, _AppSessionID, _AppUserID, _AppConn)
            Case FIND_BILL_TO_SITE
                dtSearchTable = oListOfvalue.selectBillToSiteList(_FilterText, _AppSessionID, _AppUserID, _AppConn)
            Case FIND_SHIP_TO_SITE
                dtSearchTable = oListOfvalue.selectShipToSiteList(_FilterText, _AppSessionID, _AppUserID, _AppConn)
            Case FIND_SO
                dtSearchTable = oListOfvalue.selectSOList(_FilterText, _AppSessionID, _AppUserID, _AppConn)
            Case FIND_SOITM
                dtSearchTable = oListOfvalue.selectSOItmList(_FilterText, _AppSessionID, _AppUserID, _AppConn)
            Case FIND_SOITM_FOR_PO_LINE
                dtSearchTable = oListOfvalue.selectSOItmForPoLineList(_FilterText, _ItemCode, _AppSessionID, _AppUserID, _AppConn)
            Case FIND_SO_TEST
                dtSearchTable = oListOfvalue.selectSOListTest(_FilterText, _AppSessionID, _AppUserID, _AppConn)
            Case FIND_BANKS
                dtSearchTable = oListOfvalue.selectBanksList(_FilterText, _AppSessionID, _AppUserID, _AppConn)
            Case FIND_GRADES
                dtSearchTable = oListOfvalue.selectGradesList(_FilterText, _Itnaturecd, _AppSessionID, _AppUserID, _AppConn)
            Case FIND_MFG_BOM_HEADER
                dtSearchTable = oListOfvalue.selectMfgBomHeader(_ItemId, _FilterText, _AppSessionID, _AppUserID, _AppConn)
            Case FIND_COLORIT
                dtSearchTable = oListOfvalue.selectColoritList(_ItemId, _FilterText, _AppSessionID, _AppUserID, _AppConn)
            Case FIND_MFG_BOM_HEADER_LIST
                dtSearchTable = oListOfvalue.selectMfgBomHeaderList(_FilterText, _ItemId, _ItemCode, _AppConn)
            Case FIND_MFG_ROUTING_HEADER
                dtSearchTable = oListOfvalue.selectMfgRoutingHeader(_FilterText, _ItemId, _MfgBomHeaderId, _AppSessionID, _AppUserID, _AppConn)
            Case FIND_TRN_NUMBER
                dtSearchTable = oListOfvalue.selectTrnNumber(_FilterText, _WarehouseID, _TxnTypeCode, _AppSessionID, _AppUserID, _AppConn)
            Case FIND_PO_HEADER
                dtSearchTable = oListOfvalue.selectPOHeader(_FilterText, _AppConn)
            Case FIND_PO_HEADER_SUBCONTRACT
                dtSearchTable = oListOfvalue.selectPOHeaderSubcontract(_FilterText, _SupplierId, _AppConn)
            Case FIND_PO_LINE
                dtSearchTable = oListOfvalue.selectPOLine(_FilterText, "", _AppSessionID, _AppUserID, _AppConn)
            Case FIND_PO_LINE_SUBCONTRACT
                dtSearchTable = oListOfvalue.selectPOLineSubContract(_PoHeaderId, _FilterText, "", _AppSessionID, _AppUserID, _AppConn)
            Case FIND_WAREHOUSE
                dtSearchTable = oListOfvalue.selectWarehouse(_FilterText, _CompanyId, _AppConn)
            Case FIND_SUBINVENTORY
                dtSearchTable = oListOfvalue.selectSubInventory(_FilterText, pWarehouseID, _AppSessionID, _AppUserID, _AppConn)
            Case FIND_LOCATION
                dtSearchTable = oListOfvalue.selectLocation(_FilterText, pWarehouseID, pSubInventoryID, _AppSessionID, _AppUserID, _AppConn)
            Case FIND_UOM
                dtSearchTable = oListOfvalue.selectUomList(_FilterText, pUomClassId, _AppSessionID, _AppUserID, _AppConn)
            Case FIND_UOM_BY_CLASS
                dtSearchTable = oListOfvalue.selectUomByClass(pUomClassId, pUomCode, _AppSessionID, _AppUserID, _AppConn)
            Case FIND_YARN_MAKEUP
                dtSearchTable = oListOfvalue.selectYarnMakeup(_FilterText, _AppSessionID, _AppUserID, _AppConn)
            Case FIND_MTL_TRAN_TYPE
                dtSearchTable = oListOfvalue.selectMTLTranTypeList(_MTLTranTypeID, _AppSessionID, _AppUserID, _AppConn)
            Case FIND_MTL_TRAN_REASON
                dtSearchTable = oListOfvalue.selectMTLTranReasonList(_AppCompanyID, _AppSessionID, _AppUserID, _AppConn)
            Case FIND_DEPARTMENTS
                dtSearchTable = oListOfvalue.selectDepartmentList(_AppCompanyID, _AppSessionID, _AppConn)
            Case FIND_EMPLOYEE
                dtSearchTable = oListOfvalue.selectEmployeeList(_DepartmentsCode, _EmployeeCode, _AppCompanyID, _AppSessionID, _AppConn)
            Case FIND_ONHAND_PARENT_LOT
                dtSearchTable = oListOfvalue.selectMTLOnhandParentLotNumberList(_ItemId, _AppCompanyID, _AppSessionID, _AppConn)
            Case FIND_OPERATION_PLAN_FROM_SOITM_LIST
                dtSearchTable = oListOfvalue.selectOperationPlanFromSoitmList(_FilterText, _SoHeaderId, _AppCompanyID, _AppSessionID, _AppConn)
            Case FIND_CHILD_PRODUCTION_ORDER
                dtSearchTable = oListOfvalue.selectChildProductionOrderList(_FilterText, _ParentProductionOrderId, _AppCompanyID, _AppSessionID, _AppConn)
            Case FIND_MACHINES
                dtSearchTable = oListOfvalue.selectMachinesList(_FilterText, _WarehouseID, _AppSessionID, _AppUserID, _AppConn)
            Case FIND_OPERATIONS
                dtSearchTable = oListOfvalue.selectOperationsList(_FilterText, _AppCompanyID, _AppSessionID, _AppConn)
            Case FIND_AR_PAYMENT_TERMS
                dtSearchTable = oListOfvalue.selectARPaymentTermsList(_FilterText, _AppCompanyID, _AppSessionID, _AppConn)
            Case FIND_AP_PAYMENT_TERMS
                dtSearchTable = oListOfvalue.selectAPPaymentTermsList(_FilterText, _AppCompanyID, _AppSessionID, _AppConn)
            Case FIND_DYE_JOB
                dtSearchTable = oListOfvalue.selectDyeJobNoList(_FilterText, _AppConn)
            Case FIND_ORDER_SET
                dtSearchTable = oListOfvalue.selectOrderSetList(_FilterText, _AppConn)
            Case FIND_DELIVERY_HEADER
                dtSearchTable = oListOfvalue.selectDeliveryHeaderList(_FilterText, _AppCompanyID, _AppSessionID, _AppConn)
            Case FIND_STEP_NUMBER
                dtSearchTable = oListOfvalue.selectStepNumberList(_FilterText, _SetNo, _AppCompanyID, _AppSessionID, _AppConn)
            Case FIND_SET_LIST
                dtSearchTable = oListOfvalue.selectSetList(_FilterText, _AppCompanyID, _AppSessionID, _AppConn)
            Case FIND_SET_LIST_UPSTEP_STITCH
                dtSearchTable = oListOfvalue.selectSetListUpStepStitch(_FilterText, _AppCompanyID, _AppSessionID, _AppConn)
            Case FIND_TRANSFER_SUBCONTRACT
                dtSearchTable = oListOfvalue.selectTransferSubcontractList(_FilterText, _AppCompanyID, _AppSessionID, _AppConn)
            Case FIND_TRANSFER_WH
                dtSearchTable = oListOfvalue.selectTransferWHList(_FilterText, _AppCompanyID, _AppSessionID, _AppConn)
            Case FIND_TRANSFER_LOCATION
                dtSearchTable = oListOfvalue.selectTransferLocationList(_FilterText, _AppCompanyID, _AppSessionID, _AppConn)
            Case FIND_SHIP_VIA
                dtSearchTable = oListOfvalue.selectShipVia(_FilterText, _AppCompanyID, _AppSessionID, _AppConn)
            Case FIND_PRODUCTION_ORDER_HEADER
                dtSearchTable = oListOfvalue.selectProductionHeaderList(_FilterText, pProductionOrderTypeId, _AppCompanyID, _AppSessionID, _AppConn)
            Case FIND_MATERIAL_LINE
                dtSearchTable = oListOfvalue.selectMateriaLineList(_FilterText, _AppConn)
            Case FIND_PRODUCT_LINE
                dtSearchTable = oListOfvalue.selectProductLineList(_FilterText, _AppConn)
            Case FIND_SALES_PERSON_LIST
                dtSearchTable = oListOfvalue.selectSalesPersonList(_FilterText, _AppConn)
            Case FIND_CODE_LEFT_RIGHT
                dtSearchTable = oListOfvalue.selectCodeLeftRightLookupList(_FilterText, _AppConn)
            Case FIND_AR_INVOICE_HEADER
                dtSearchTable = oListOfvalue.selectArInvoiceHeaderList(_FilterText, _AppConn)
            Case FIND_CALC_HEADER_LIST
                dtSearchTable = oListOfvalue.selectCalcHeaderList(_FilterText, _AppConn)
            Case FIND_EFFICIENCY
                dtSearchTable = oListOfvalue.selectEfficiency(_FilterText, _AppSessionID, _AppUserID, _AppConn)
            Case FIND_TARIFF_HEADER_LIST
                dtSearchTable = oListOfvalue.selectTariffHeaderList(_FilterText, _TariffType, _AppConn)
            Case FIND_TARIFF_LINE_LIST
                dtSearchTable = oListOfvalue.selectTariffLineList(_FilterText, _AppConn)
            Case FIND_CALC_BOM_HEADER_LIST
                dtSearchTable = oListOfvalue.selectCalcBomHeaderList(_FilterText, _ItemId, _ItemCode, _AppConn)
            Case FIND_CUSTOMER_ITEMS_XREF_LIST
                dtSearchTable = oListOfvalue.selectCustomerItemsXrefList(_FilterText, _Custcd, _ItemId, _ItemCode, _AppConn)
        End Select

        bsSearchTable.DataSource = dtSearchTable
        bsSearchTable.MoveFirst()
        drvSearchTable = CType(bsSearchTable.Current, DataRowView)
        dgvSearchTable.AutoGenerateColumns = False
        dgvSearchTable.DataSource = bsSearchTable

        Select Case dtSearchTable.Rows.Count
            Case 0
                btnOK.Enabled = False
            Case Else
                btnOK.Enabled = True
        End Select
        Me.Cursor = Cursors.Default
        If dgvSearchTable.Rows.Count > 0 Then 'Neung 20240506
            dgvSearchTable.Focus()
        End If

        If dtSearchTable.Rows.Count = 1 And _ValueFoundAutoClose Then
            UserValueFound = True
            _UserAction = "OK"
            Me.Close()
        End If

        If dtSearchTable.Rows.Count = 0 And _NoDataAutoClose Then
            UserNoDataFound = True
            _UserAction = "CANCEL"
            Me.Close()
        End If

    End Sub
    Private Sub returnSelectValueAndCloseDlg() 'NO USE
        If dgvSearchTable.Rows.Count > 0 Then
            Select Case DataForFind
                Case FIND_THREAD_CLIPPING '"code for thread clipping"
                    drvSearchTable = CType(bsSearchTable.Current, DataRowView)
            End Select
        End If
        Me.DialogResult = System.Windows.Forms.DialogResult.OK

        Me.Close()
    End Sub
    Private Sub createDatagridview()
        Select Case DataForFind
            Case FIND_COLORS
                Dim colNames As New List(Of String) From {"colColorId", "colCol", "colColName", "colCustcol", "colCustcd", "colCustname"}
                Dim DataPropertyNames As New List(Of String) From {"color_id", "col", "colname", "custcol", "custcd", "custname"}
                Dim HeaderTexts = {"Color Id", "Color Code", "Color Name", "Customer Color", "Customer Code", "Customer Name"}
                For i = 0 To colNames.Count - 1
                    Dim dgvtxtNew As New DataGridViewTextBoxColumn
                    With dgvtxtNew
                        .Name = colNames(i) ' Optional for reference
                        .DataPropertyName = DataPropertyNames(i)
                        .HeaderText = HeaderTexts(i)
                        .ReadOnly = True
                        .AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
                    End With
                    dgvSearchTable.Columns.Add(dgvtxtNew)
                Next
            Case FIND_THREAD_CLIPPING '"code for thread clipping"
                With dgvSearchTable
                    Dim dgvc1 As DataGridViewColumn = New DataGridViewTextBoxColumn()
                    With dgvc1
                        .DataPropertyName = "lookup_value_id"
                        .Name = "colLookupValueId"
                        .HeaderText = "ID"
                        .Width = 50
                        .ReadOnly = True
                    End With

                    Dim dgvc2 As DataGridViewColumn = New DataGridViewTextBoxColumn()
                    With dgvc2
                        .DataPropertyName = "lookup_value_code"
                        .Name = "colLookupvalueCode"
                        .HeaderText = "Code"
                        .Width = 150
                        .ReadOnly = True
                    End With

                    Dim dgvc3 As DataGridViewColumn = New DataGridViewTextBoxColumn()
                    With dgvc3
                        .DataPropertyName = "lookup_value"
                        .Name = "colLookupvalueName"
                        .HeaderText = "Name"
                        .Width = 400
                        .ReadOnly = True
                    End With


                    .Columns.Clear()
                    .Columns.Add(dgvc1)
                    .Columns.Add(dgvc2)
                    .Columns.Add(dgvc3)
                End With
            Case FIND_ITEMS
                With dgvSearchTable
                    Dim dgvc1 As DataGridViewColumn = New DataGridViewTextBoxColumn()
                    With dgvc1
                        .DataPropertyName = "item_id"
                        .Name = "colItemId"
                        .HeaderText = "ID"
                        .Width = 50
                        .ReadOnly = True
                        .AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
                    End With

                    Dim dgvc2 As DataGridViewColumn = New DataGridViewTextBoxColumn()
                    With dgvc2
                        .DataPropertyName = "itcd"
                        .Name = "colitcd"
                        .HeaderText = "Code"
                        .Width = 150
                        .ReadOnly = True
                        .AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
                    End With

                    Dim dgvc3 As DataGridViewColumn = New DataGridViewTextBoxColumn()
                    With dgvc3
                        .DataPropertyName = "itdesc"
                        .Name = "colitdesc"
                        .HeaderText = "Name"
                        .Width = 250
                        .ReadOnly = True
                        '.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
                    End With
                    Dim dgvc4 As DataGridViewColumn = New DataGridViewTextBoxColumn()
                    With dgvc4
                        .DataPropertyName = "itnaturedesc"
                        .Name = "colItnaturedesc"
                        .HeaderText = "Nature"
                        .Width = 100
                        .ReadOnly = True
                        .AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
                    End With
                    Dim dgvc5 As DataGridViewColumn = New DataGridViewTextBoxColumn()
                    With dgvc5
                        .DataPropertyName = "itcatdesc"
                        .Name = "colItcatdesc"
                        .HeaderText = "Category"
                        .Width = 100
                        .ReadOnly = True
                        .AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
                    End With

                    Dim dgvc6 As DataGridViewColumn = New DataGridViewTextBoxColumn() ' 30/07/2024 John
                    With dgvc6
                        .DataPropertyName = "colname"
                        .Name = "colColname"
                        .HeaderText = "Color"
                        .Width = 100
                        .ReadOnly = True
                        .AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
                    End With

                    .Columns.Clear()
                    .Columns.Add(dgvc1)
                    .Columns.Add(dgvc2)
                    .Columns.Add(dgvc3)
                    .Columns.Add(dgvc4)
                    .Columns.Add(dgvc5)
                    .Columns.Add(dgvc6)
                End With
            Case FIND_SUPPLIERS
                With dgvSearchTable
                    Dim dgvc1 As DataGridViewColumn = New DataGridViewTextBoxColumn()
                    With dgvc1
                        .DataPropertyName = "supplier_id"
                        .Name = "colSupplierId"
                        .HeaderText = "ID"
                        .Width = 50
                        .ReadOnly = True
                    End With

                    Dim dgvc2 As DataGridViewColumn = New DataGridViewTextBoxColumn()
                    With dgvc2
                        .DataPropertyName = "supplier_code"
                        .Name = "colSupplierCode"
                        .HeaderText = "Code"
                        .Width = 60
                        .ReadOnly = True
                    End With

                    Dim dgvc3 As DataGridViewColumn = New DataGridViewTextBoxColumn()
                    With dgvc3
                        .DataPropertyName = "supplier_name"
                        .Name = "colSupplierName"
                        .HeaderText = "Name"
                        .Width = 250
                        .ReadOnly = True
                    End With

                    Dim dgvc4 As DataGridViewColumn = New DataGridViewTextBoxColumn()
                    With dgvc4
                        .DataPropertyName = "supplier_addr1"
                        .Name = "colSupplierAddr1"
                        .HeaderText = "Addr1"
                        .Width = 350
                        .ReadOnly = True
                    End With
                    .Columns.Clear()
                    .Columns.Add(dgvc1)
                    .Columns.Add(dgvc2)
                    .Columns.Add(dgvc3)
                    .Columns.Add(dgvc4)
                End With
            Case FIND_PIECE_DYE_COLOR
                With dgvSearchTable
                    Dim dgvc1 As DataGridViewColumn = New DataGridViewTextBoxColumn()
                    With dgvc1
                        .DataPropertyName = "lookup_value_id"
                        .Name = "colLookupValueId"
                        .HeaderText = "ID"
                        .Width = 50
                        .ReadOnly = True
                    End With

                    Dim dgvc2 As DataGridViewColumn = New DataGridViewTextBoxColumn()
                    With dgvc2
                        .DataPropertyName = "lookup_value_code"
                        .Name = "colLookupvalueCode"
                        .HeaderText = "Code"
                        .Width = 150
                        .ReadOnly = True
                    End With

                    Dim dgvc3 As DataGridViewColumn = New DataGridViewTextBoxColumn()
                    With dgvc3
                        .DataPropertyName = "lookup_value"
                        .Name = "colLookupvalueName"
                        .HeaderText = "Name"
                        .Width = 400
                        .ReadOnly = True
                    End With


                    .Columns.Clear()
                    .Columns.Add(dgvc1)
                    .Columns.Add(dgvc2)
                    .Columns.Add(dgvc3)
                End With
            Case FIND_ITEMS_VARIANT
                With dgvSearchTable
                    Dim dgvc1 As DataGridViewColumn = New DataGridViewTextBoxColumn()
                    With dgvc1
                        .DataPropertyName = "items_variant_id"
                        .Name = "colItemsVariantId"
                        .HeaderText = "ID"
                        .Width = 50
                        .ReadOnly = True
                    End With

                    Dim dgvc2 As DataGridViewColumn = New DataGridViewTextBoxColumn()
                    With dgvc2
                        .DataPropertyName = "variant_code"
                        .Name = "colVariantCode"
                        .HeaderText = "Code"
                        .Width = 150
                        .ReadOnly = True
                    End With

                    Dim dgvc3 As DataGridViewColumn = New DataGridViewTextBoxColumn()
                    With dgvc3
                        .DataPropertyName = "variant_name"
                        .Name = "colVariantName"
                        .HeaderText = "Name"
                        .Width = 400
                        .ReadOnly = True
                    End With

                    Dim dgvc4 As DataGridViewColumn = New DataGridViewTextBoxColumn()
                    With dgvc4
                        .DataPropertyName = "variant_type_id"
                        .Name = "colVariantTypeId"
                        .HeaderText = "Type ID"
                        .Width = 50
                        .ReadOnly = True
                    End With

                    Dim dgvc5 As DataGridViewColumn = New DataGridViewTextBoxColumn()
                    With dgvc5
                        .DataPropertyName = "variant_type"
                        .Name = "colVariantType"
                        .HeaderText = "Type"
                        .Width = 150
                        .ReadOnly = True
                    End With


                    .Columns.Clear()
                    .Columns.Add(dgvc1)
                    .Columns.Add(dgvc2)
                    .Columns.Add(dgvc3)
                    .Columns.Add(dgvc4)
                    .Columns.Add(dgvc5)
                End With
            Case FIND_CUSTOMERS
                With dgvSearchTable
                    Dim dgvc1 As DataGridViewColumn = New DataGridViewTextBoxColumn()
                    With dgvc1
                        .DataPropertyName = "customer_id"
                        .Name = "colCustomerId"
                        .HeaderText = "ID"
                        .Width = 50
                        .ReadOnly = True
                    End With

                    Dim dgvc2 As DataGridViewColumn = New DataGridViewTextBoxColumn()
                    With dgvc2
                        .DataPropertyName = "customer_code"
                        .Name = "colCustomerCode"
                        .HeaderText = "Code"
                        .Width = 60
                        .ReadOnly = True
                    End With

                    Dim dgvc3 As DataGridViewColumn = New DataGridViewTextBoxColumn()
                    With dgvc3
                        .DataPropertyName = "customer_name"
                        .Name = "colCustomerName"
                        .HeaderText = "Name"
                        .Width = 250
                        .ReadOnly = True
                    End With

                    Dim dgvc4 As DataGridViewColumn = New DataGridViewTextBoxColumn()
                    With dgvc4
                        .DataPropertyName = "ctry"
                        .Name = "colCountry"
                        .HeaderText = "Country"
                        .Width = 50
                        .ReadOnly = True
                    End With

                    Dim dgvc5 As DataGridViewColumn = New DataGridViewTextBoxColumn()
                    With dgvc5
                        .DataPropertyName = "match_code"
                        .Name = "colMatchCode"
                        .HeaderText = "Match Code"
                        .Width = 250
                        .ReadOnly = True
                    End With

                    Dim dgvc6 As DataGridViewColumn = New DataGridViewTextBoxColumn()
                    With dgvc6
                        .DataPropertyName = "customer_addr1"
                        .Name = "colCustomerAddr1"
                        .HeaderText = "Addr1"
                        .Width = 450
                        .ReadOnly = True
                    End With
                    .Columns.Clear()
                    .Columns.Add(dgvc1)
                    .Columns.Add(dgvc2)
                    .Columns.Add(dgvc3)
                    .Columns.Add(dgvc4)
                    .Columns.Add(dgvc5)
                    .Columns.Add(dgvc6)
                End With
            Case FIND_BILL_TO_SITE
                With dgvSearchTable
                    Dim dgvc1 As DataGridViewColumn = New DataGridViewTextBoxColumn()
                    With dgvc1
                        .DataPropertyName = "bill_to_site_id"
                        .Name = "colBilltoSiteId"
                        .HeaderText = "ID"
                        .Width = 50
                        .ReadOnly = True
                    End With

                    Dim dgvc2 As DataGridViewColumn = New DataGridViewTextBoxColumn()
                    With dgvc2
                        .DataPropertyName = "bill_to_site_code"
                        .Name = "colBillToSiteCode"
                        .HeaderText = "Code"
                        .Width = 60
                        .ReadOnly = True
                    End With

                    Dim dgvc3 As DataGridViewColumn = New DataGridViewTextBoxColumn()
                    With dgvc3
                        .DataPropertyName = "bill_to_site_name"
                        .Name = "colBillToSiteName"
                        .HeaderText = "Name"
                        .Width = 250
                        .ReadOnly = True
                    End With

                    Dim dgvc4 As DataGridViewColumn = New DataGridViewTextBoxColumn()
                    With dgvc4
                        .DataPropertyName = "bill_to_site_addr1"
                        .Name = "colBillToSiteAddr1"
                        .HeaderText = "Addr1"
                        .Width = 350
                        .ReadOnly = True
                    End With
                    .Columns.Clear()
                    .Columns.Add(dgvc1)
                    .Columns.Add(dgvc2)
                    .Columns.Add(dgvc3)
                    .Columns.Add(dgvc4)
                End With
            Case FIND_SHIP_TO_SITE
                With dgvSearchTable
                    Dim dgvc1 As DataGridViewColumn = New DataGridViewTextBoxColumn()
                    With dgvc1
                        .DataPropertyName = "ship_to_site_id"
                        .Name = "colShipToSiteId"
                        .HeaderText = "ID"
                        .Width = 50
                        .ReadOnly = True
                    End With

                    Dim dgvc2 As DataGridViewColumn = New DataGridViewTextBoxColumn()
                    With dgvc2
                        .DataPropertyName = "ship_to_site_code"
                        .Name = "colShipToSiteCode"
                        .HeaderText = "Code"
                        .Width = 60
                        .ReadOnly = True
                    End With

                    Dim dgvc3 As DataGridViewColumn = New DataGridViewTextBoxColumn()
                    With dgvc3
                        .DataPropertyName = "ship_to_site_name"
                        .Name = "colShipToSiteName"
                        .HeaderText = "Name"
                        .Width = 250
                        .ReadOnly = True
                    End With

                    Dim dgvc4 As DataGridViewColumn = New DataGridViewTextBoxColumn()
                    With dgvc4
                        .DataPropertyName = "ship_to_site_addr1"
                        .Name = "colShipToSiteAddr1"
                        .HeaderText = "Addr1"
                        .Width = 350
                        .ReadOnly = True
                    End With
                    .Columns.Clear()
                    .Columns.Add(dgvc1)
                    .Columns.Add(dgvc2)
                    .Columns.Add(dgvc3)
                    .Columns.Add(dgvc4)
                End With
            Case FIND_BANKS
                With dgvSearchTable
                    Dim dgvc1 As DataGridViewColumn = New DataGridViewTextBoxColumn()
                    With dgvc1
                        .DataPropertyName = "id_banks"
                        .Name = "colIdBanks"
                        .HeaderText = "ID"
                        .Width = 50
                        .ReadOnly = True
                    End With

                    Dim dgvc2 As DataGridViewColumn = New DataGridViewTextBoxColumn()
                    With dgvc2
                        .DataPropertyName = "bank_code"
                        .Name = "colBankCode"
                        .HeaderText = "Code"
                        .Width = 60
                        .ReadOnly = True
                    End With

                    Dim dgvc3 As DataGridViewColumn = New DataGridViewTextBoxColumn()
                    With dgvc3
                        .DataPropertyName = "bank_name"
                        .Name = "colBankName"
                        .HeaderText = "Name"
                        .Width = 250
                        .ReadOnly = True
                    End With

                    Dim dgvc4 As DataGridViewColumn = New DataGridViewTextBoxColumn()
                    With dgvc4
                        .DataPropertyName = "bank_addr"
                        .Name = "colBankAddr"
                        .HeaderText = "Addr"
                        .Width = 350
                        .ReadOnly = True
                    End With
                    Dim dgvc5 As DataGridViewColumn = New DataGridViewTextBoxColumn()
                    With dgvc5
                        .DataPropertyName = "swift_code"
                        .Name = "colSwiftCode"
                        .HeaderText = "Swift Code"
                        .Width = 100
                        .ReadOnly = True
                    End With
                    Dim dgvc6 As DataGridViewColumn = New DataGridViewTextBoxColumn()
                    With dgvc6
                        .DataPropertyName = "account_code"
                        .Name = "colAccountCode"
                        .HeaderText = "Account Code"
                        .Width = 100
                        .ReadOnly = True
                    End With
                    Dim dgvc7 As DataGridViewColumn = New DataGridViewTextBoxColumn()
                    With dgvc7
                        .DataPropertyName = "default_currency"
                        .Name = "colDefaultCurrency"
                        .HeaderText = "Default Currency"
                        .Width = 100
                        .ReadOnly = True
                    End With
                    Dim dgvc8 As DataGridViewColumn = New DataGridViewTextBoxColumn()
                    With dgvc8
                        .DataPropertyName = "bank_branch"
                        .Name = "colBankBranch"
                        .HeaderText = "Bank Branch"
                        .Width = 100
                        .ReadOnly = True
                    End With
                    .Columns.Clear()
                    .Columns.Add(dgvc1)
                    .Columns.Add(dgvc2)
                    .Columns.Add(dgvc3)
                    .Columns.Add(dgvc4)
                    .Columns.Add(dgvc5)
                    .Columns.Add(dgvc6)
                    .Columns.Add(dgvc7)
                    .Columns.Add(dgvc8)
                End With
            Case FIND_GRADES
                With dgvSearchTable
                    Dim dgvc1 As DataGridViewColumn = New DataGridViewTextBoxColumn()
                    With dgvc1
                        .DataPropertyName = "mtl_grades_id"
                        .Name = "colMtlGradesID"
                        .HeaderText = "ID"
                        .Width = 50
                        .ReadOnly = True
                    End With
                    Dim dgvc2 As DataGridViewColumn = New DataGridViewTextBoxColumn()
                    With dgvc2
                        .DataPropertyName = "grade_code"
                        .Name = "colGradeCode"
                        .HeaderText = "Code"
                        .Width = 60
                        .ReadOnly = True
                    End With
                    Dim dgvc3 As DataGridViewColumn = New DataGridViewTextBoxColumn()
                    With dgvc3
                        .DataPropertyName = "grade_desc"
                        .Name = "colGradeDesc"
                        .HeaderText = "Desc"
                        .Width = 250
                        .ReadOnly = True
                    End With
                    .Columns.Clear()
                    .Columns.Add(dgvc1)
                    .Columns.Add(dgvc2)
                    .Columns.Add(dgvc3)
                End With
            Case FIND_MFG_BOM_HEADER
                With dgvSearchTable
                    Dim dgvc1 As DataGridViewColumn = New DataGridViewTextBoxColumn()
                    With dgvc1
                        .DataPropertyName = "mfg_bom_header_id"
                        .Name = "colMfgBomHeaderId"
                        .HeaderText = "ID"
                        .Width = 50
                        .ReadOnly = True
                    End With
                    Dim dgvc2 As DataGridViewColumn = New DataGridViewTextBoxColumn()
                    With dgvc2
                        .DataPropertyName = "itcd"
                        .Name = "colItCd"
                        .HeaderText = "Article No."
                        .Width = 80
                        .ReadOnly = True
                    End With
                    Dim dgvc3 As DataGridViewColumn = New DataGridViewTextBoxColumn()
                    With dgvc3
                        .DataPropertyName = "bom_code"
                        .Name = "colBomCode"
                        .HeaderText = "Color"
                        .Width = 80
                        .ReadOnly = True
                    End With
                    Dim dgvc4 As DataGridViewColumn = New DataGridViewTextBoxColumn()
                    With dgvc4
                        .DataPropertyName = "bom_name"
                        .Name = "colBomName"
                        .HeaderText = "Strings"
                        .Width = 750
                        .ReadOnly = True
                    End With
                    .Columns.Clear()
                    .Columns.Add(dgvc1)
                    .Columns.Add(dgvc2)
                    .Columns.Add(dgvc3)
                    .Columns.Add(dgvc4)
                End With
            Case FIND_COLORIT
                With dgvSearchTable
                    Dim dgvc1 As DataGridViewColumn = New DataGridViewTextBoxColumn()
                    With dgvc1
                        .DataPropertyName = "mfg_bom_header_id"
                        .Name = "colMfgBomHeaderId"
                        .HeaderText = "ID"
                        .Width = 50
                        .ReadOnly = True
                    End With
                    Dim dgvc2 As DataGridViewColumn = New DataGridViewTextBoxColumn()
                    With dgvc2
                        .DataPropertyName = "itcd"
                        .Name = "colItCd"
                        .HeaderText = "Article No."
                        .Width = 80
                        .ReadOnly = True
                    End With
                    Dim dgvc3 As DataGridViewColumn = New DataGridViewTextBoxColumn()
                    With dgvc3
                        .DataPropertyName = "bom_code"
                        .Name = "colBomCode"
                        .HeaderText = "Color"
                        .Width = 80
                        .ReadOnly = True
                    End With
                    Dim dgvc4 As DataGridViewColumn = New DataGridViewTextBoxColumn()
                    With dgvc4
                        .DataPropertyName = "bom_name"
                        .Name = "colBomName"
                        .HeaderText = "Strings"
                        .Width = 750
                        .ReadOnly = True
                    End With
                    .Columns.Clear()
                    .Columns.Add(dgvc1)
                    .Columns.Add(dgvc2)
                    .Columns.Add(dgvc3)
                    .Columns.Add(dgvc4)
                End With
            Case FIND_MFG_ROUTING_HEADER
                With dgvSearchTable
                    Dim dgvc1 As DataGridViewColumn = New DataGridViewTextBoxColumn()
                    With dgvc1
                        .DataPropertyName = "mfg_routing_header_id"
                        .Name = "colMfgRountHeaderId"
                        .HeaderText = "ID"
                        .Width = 50
                        .ReadOnly = True
                    End With
                    Dim dgvc2 As DataGridViewColumn = New DataGridViewTextBoxColumn()
                    With dgvc2
                        .DataPropertyName = "routing_code"
                        .Name = "colRoutingCode"
                        .HeaderText = "Routing Code."
                        .Width = 80
                        .ReadOnly = True
                    End With
                    Dim dgvc3 As DataGridViewColumn = New DataGridViewTextBoxColumn()
                    With dgvc3
                        .DataPropertyName = "routing_name"
                        .Name = "colRoutingName"
                        .HeaderText = "Name"
                        .Width = 80
                        .ReadOnly = True
                    End With
                    Dim dgvc4 As DataGridViewColumn = New DataGridViewTextBoxColumn()
                    With dgvc4
                        .DataPropertyName = "routing_status"
                        .Name = "colRoutingStatus"
                        .HeaderText = "Status"
                        .Width = 80
                        .ReadOnly = True
                    End With
                    Dim dgvc5 As DataGridViewColumn = New DataGridViewTextBoxColumn()
                    With dgvc5
                        .DataPropertyName = "itcd"
                        .Name = "colItcd"
                        .HeaderText = "Item Code"
                        .Width = 90
                        .ReadOnly = True
                    End With
                    Dim dgvc6 As DataGridViewColumn = New DataGridViewTextBoxColumn()
                    With dgvc6
                        .DataPropertyName = "bom_code"
                        .Name = "colBomCode"
                        .HeaderText = "Colorit"
                        .Width = 90
                        .ReadOnly = True
                    End With
                    .Columns.Clear()
                    .Columns.Add(dgvc1)
                    .Columns.Add(dgvc2)
                    .Columns.Add(dgvc3)
                    .Columns.Add(dgvc4)
                    .Columns.Add(dgvc5)
                    .Columns.Add(dgvc6)
                End With
            Case FIND_OPERATION_PLAN_FROM_SOITM_LIST
                With dgvSearchTable
                    Dim dgvc1 As DataGridViewColumn = New DataGridViewTextBoxColumn()
                    With dgvc1
                        .DataPropertyName = "mfg_routing_header_id"
                        .Name = "colMfgRountHeaderId"
                        .HeaderText = "ID"
                        .Width = 50
                        .ReadOnly = True
                    End With
                    Dim dgvc2 As DataGridViewColumn = New DataGridViewTextBoxColumn()
                    With dgvc2
                        .DataPropertyName = "routing_code"
                        .Name = "colRoutingCode"
                        .HeaderText = "Routing Code."
                        .Width = 80
                        .ReadOnly = True
                    End With
                    Dim dgvc3 As DataGridViewColumn = New DataGridViewTextBoxColumn()
                    With dgvc3
                        .DataPropertyName = "routing_name"
                        .Name = "colRoutingName"
                        .HeaderText = "Name"
                        .Width = 80
                        .ReadOnly = True
                    End With
                    Dim dgvc4 As DataGridViewColumn = New DataGridViewTextBoxColumn()
                    With dgvc4
                        .DataPropertyName = "routing_status"
                        .Name = "colRoutingStatus"
                        .HeaderText = "Status"
                        .Width = 80
                        .ReadOnly = True
                    End With
                    Dim dgvc5 As DataGridViewColumn = New DataGridViewTextBoxColumn()
                    With dgvc5
                        .DataPropertyName = "itcd"
                        .Name = "colItcd"
                        .HeaderText = "Item Code"
                        .Width = 90
                        .ReadOnly = True
                    End With
                    Dim dgvc6 As DataGridViewColumn = New DataGridViewTextBoxColumn()
                    With dgvc6
                        .DataPropertyName = "bom_code"
                        .Name = "colBomCode"
                        .HeaderText = "Colorit"
                        .Width = 90
                        .ReadOnly = True
                    End With
                    .Columns.Clear()
                    .Columns.Add(dgvc1)
                    .Columns.Add(dgvc2)
                    .Columns.Add(dgvc3)
                    .Columns.Add(dgvc4)
                    .Columns.Add(dgvc5)
                    .Columns.Add(dgvc6)
                End With
            Case FIND_TRN_NUMBER
                With dgvSearchTable
                    Dim dgvc1 As DataGridViewColumn = New DataGridViewTextBoxColumn()
                    With dgvc1
                        .DataPropertyName = "warehouse_code"
                        .Name = "warehouse_code"
                        .HeaderText = "Warehouse Code"
                        .Width = 90
                        .ReadOnly = True
                    End With
                    Dim dgvc2 As DataGridViewColumn = New DataGridViewTextBoxColumn()
                    With dgvc2
                        .DataPropertyName = "mtl_txn_type_id"
                        .Name = "mtl_txn_type_id"
                        .HeaderText = "Txn Type ID"
                        .Width = 80
                        .ReadOnly = True
                        .Visible = False
                    End With
                    Dim dgvc3 As DataGridViewColumn = New DataGridViewTextBoxColumn()
                    With dgvc3
                        .DataPropertyName = "txn_type_code"
                        .Name = "txn_type_code"
                        .HeaderText = "Type Code"
                        .Width = 80
                        .ReadOnly = True
                    End With
                    Dim dgvc4 As DataGridViewColumn = New DataGridViewTextBoxColumn()
                    With dgvc4
                        .DataPropertyName = "mtl_txn_type_name"
                        .Name = "mtl_txn_type_name"
                        .HeaderText = "Type Name"
                        .Width = 80
                        .ReadOnly = True
                    End With
                    Dim dgvc5 As DataGridViewColumn = New DataGridViewTextBoxColumn()
                    With dgvc5
                        .DataPropertyName = "txn_number"
                        .Name = "txn_number"
                        .HeaderText = "Txn Number"
                        .Width = 90
                        .ReadOnly = True
                    End With
                    Dim dgvc6 As DataGridViewColumn = New DataGridViewTextBoxColumn()
                    With dgvc6
                        .DataPropertyName = "txn_date"
                        .Name = "txn_date"
                        .HeaderText = "Txn Date"
                        .Width = 80
                        .ReadOnly = True
                    End With
                    Dim dgvc7 As DataGridViewColumn = New DataGridViewTextBoxColumn()
                    With dgvc7
                        .DataPropertyName = "jobno"
                        .Name = "jobno"
                        .HeaderText = "P/O Number"
                        .Width = 80
                        .ReadOnly = True
                    End With
                    Dim dgvc8 As DataGridViewColumn = New DataGridViewTextBoxColumn()
                    With dgvc8
                        .DataPropertyName = "suppcd"
                        .Name = "suppcd"
                        .HeaderText = "Supp Code"
                        .Width = 80
                        .ReadOnly = True
                    End With
                    Dim dgvc9 As DataGridViewColumn = New DataGridViewTextBoxColumn()
                    With dgvc9
                        .DataPropertyName = "supp_name"
                        .Name = "supp_name"
                        .HeaderText = "Supp Name"
                        .Width = 150
                        .ReadOnly = True
                    End With
                    .Columns.Clear()
                    .Columns.Add(dgvc1)
                    .Columns.Add(dgvc2)
                    .Columns.Add(dgvc3)
                    .Columns.Add(dgvc4)
                    .Columns.Add(dgvc5)
                    .Columns.Add(dgvc6)
                    .Columns.Add(dgvc7)
                    .Columns.Add(dgvc8)
                    .Columns.Add(dgvc9)
                End With
                ' Not yet added column
                '.Columns.Add("supp_invoice_num", "Invoice Num")
                '.Columns.Add("supp_invoice_date", "Invoice Date")
                '.Columns.Add("supp_deliv_num", "Supp Delivery Num")
                '.Columns.Add("supp_deliv_date", "Supp Delivery Date")
                '.Columns.Add("po_header_id", "po_header_id")
                '.Columns.Add("mtl_txn_set_id", "mtl_txn_set_id")
            Case FIND_SO, FIND_SO_TEST
                SetAndAddColumnDataGrid_TestGer(pPropName:="so_header_id", pName:="colso", pHeaderText:="ID", pWidth:=60, pReadOnly:=True)
                SetAndAddColumnDataGrid_TestGer(pPropName:="sono", pName:="colSono", pHeaderText:="Code", pWidth:=120, pReadOnly:=True)
                SetAndAddColumnDataGrid_TestGer(pPropName:="order_type", pName:="colOrderType", pHeaderText:="Order Type", pWidth:=250, pReadOnly:=True)
                SetAndAddColumnDataGrid_TestGer(pPropName:="sodt", pName:="colSodt", pHeaderText:="Date", pWidth:=60, pReadOnly:=True)
                SetAndAddColumnDataGrid_TestGer(pPropName:="custpo", pName:="colCustPo", pHeaderText:="Customer P/O #", pWidth:=120, pReadOnly:=True)
                SetAndAddColumnDataGrid_TestGer(pPropName:="cust_name", pName:="colCustName", pHeaderText:="Customer Name", pWidth:=250, pReadOnly:=True)
                SetAndAddColumnDataGrid_TestGer(pPropName:="order_status", pName:="colOrderStatus", pHeaderText:="Status", pWidth:=250, pReadOnly:=True)
            Case FIND_SOITM
                ' SetAndAddColumnDataGrid_TestGer(pPropName:="so_header_id", pName:="colso", pHeaderText:="ID", pWidth:=60, pReadOnly:=True)
                SetAndAddColumnDataGrid_TestGer(pPropName:="sono", pName:="colSono", pHeaderText:="S/O No.", pWidth:=90, pReadOnly:=True)
                ' SetAndAddColumnDataGrid_TestGer(pPropName:="order_type", pName:="colOrderType", pHeaderText:="Order Type", pWidth:=90, pReadOnly:=True)
                SetAndAddColumnDataGrid_TestGer(pPropName:="sodt", pName:="colSodt", pHeaderText:="Date", pWidth:=60, pReadOnly:=True)
                SetAndAddColumnDataGrid_TestGer(pPropName:="custpo", pName:="colCustPo", pHeaderText:="Customer P/O #", pWidth:=90, pReadOnly:=True)
                SetAndAddColumnDataGrid_TestGer(pPropName:="cust_name", pName:="colCustName", pHeaderText:="Customer Name", pWidth:=50, pReadOnly:=True)
                SetAndAddColumnDataGrid_TestGer(pPropName:="sonoid", pName:="colSonoId", pHeaderText:="S/O No. Id", pWidth:=110, pReadOnly:=True)
                SetAndAddColumnDataGrid_TestGer(pPropName:="itcd", pName:="colItcd", pHeaderText:="Design No.", pWidth:=100, pReadOnly:=True)
                SetAndAddColumnDataGrid_TestGer(pPropName:="itdesc", pName:="colDesc", pHeaderText:="Desc", pWidth:=150, pReadOnly:=True)
                SetAndAddColumnDataGrid_TestGer(pPropName:="col", pName:="colCol", pHeaderText:="Color Code", pWidth:=100, pReadOnly:=True)
                SetAndAddColumnDataGrid_TestGer(pPropName:="custcol", pName:="colCustCol", pHeaderText:="Cust Color", pWidth:=100, pReadOnly:=True)
                SetAndAddColumnDataGrid_TestGer(pPropName:="qty", pName:="colQty", pHeaderText:="Qty", pWidth:=70, pReadOnly:=True)
                SetAndAddColumnDataGrid_TestGer(pPropName:="uom", pName:="colUom", pHeaderText:="Uom", pWidth:=50, pReadOnly:=True)
            Case FIND_PO_HEADER
                SetAndAddColumnDataGrid_TestGer(pPropName:="jobno", pName:="colJobNo", pHeaderText:="P/O No.", pWidth:=100, pReadOnly:=True)
                SetAndAddColumnDataGrid_TestGer(pPropName:="jobdt", pName:="colJobDt", pHeaderText:="P/O Date", pWidth:=100, pReadOnly:=True)
                SetAndAddColumnDataGrid_TestGer(pPropName:="suppcd", pName:="colSuppCd", pHeaderText:="Supplier Code", pWidth:=80, pReadOnly:=True)
                SetAndAddColumnDataGrid_TestGer(pPropName:="SuppName", pName:="colSuppName", pHeaderText:="Supplier Name", pWidth:=300, pReadOnly:=True)
            Case FIND_PO_HEADER_SUBCONTRACT
                SetAndAddColumnDataGrid_TestGer(pPropName:="jobno", pName:="colJobNo", pHeaderText:="P/O No.", pWidth:=100, pReadOnly:=True)
                SetAndAddColumnDataGrid_TestGer(pPropName:="jobdt", pName:="colJobDt", pHeaderText:="P/O Date", pWidth:=100, pReadOnly:=True)
                SetAndAddColumnDataGrid_TestGer(pPropName:="suppcd", pName:="colSuppCd", pHeaderText:="Supplier Code", pWidth:=80, pReadOnly:=True)
                SetAndAddColumnDataGrid_TestGer(pPropName:="suppname", pName:="colSuppName", pHeaderText:="Supplier Name", pWidth:=300, pReadOnly:=True)

            Case FIND_PO_LINE
                SetAndAddColumnDataGrid_TestGer(pPropName:="job_line_id", pName:="colJobLineId", pHeaderText:="P/O Line No.", pWidth:=100, pReadOnly:=True)
                SetAndAddColumnDataGrid_TestGer(pPropName:="itcd", pName:="colItCd", pHeaderText:="Item Code", pWidth:=100, pReadOnly:=True)
                SetAndAddColumnDataGrid_TestGer(pPropName:="ItemName", pName:="colItemName", pHeaderText:="Description", pWidth:=250, pReadOnly:=True)
                SetAndAddColumnDataGrid_TestGer(pPropName:="variant_code", pName:="colVariantCode", pHeaderText:="Variant Code", pWidth:=70, pReadOnly:=True)
                SetAndAddColumnDataGrid_TestGer(pPropName:="variant_name", pName:="colVariantName", pHeaderText:="Variant Name", pWidth:=140, pReadOnly:=True)
                SetAndAddColumnDataGrid_TestGer(pPropName:="dimension", pName:="colSize", pHeaderText:="Size", pWidth:=70, pReadOnly:=True)
                SetAndAddColumnDataGrid_TestGer(pPropName:="qty", pName:="colQty", pHeaderText:="Qty", pWidth:=80, pReadOnly:=True)
                SetAndAddColumnDataGrid_TestGer(pPropName:="uom", pName:="colUom", pHeaderText:="Uom", pWidth:=100, pReadOnly:=True)
                SetAndAddColumnDataGrid_TestGer(pPropName:="secondary_uom", pName:="colSecondaryUom", pHeaderText:="Secondary Uom", pWidth:=60, pReadOnly:=True)
                SetAndAddColumnDataGrid_TestGer(pPropName:="txn_qty_received", pName:="colTxnQtyReceived", pHeaderText:="Qty Received", pWidth:=80, pReadOnly:=True)
                SetAndAddColumnDataGrid_TestGer(pPropName:="txn_qty2_received", pName:="colTxnQty2Received", pHeaderText:="Qty2 Received", pWidth:=60, pReadOnly:=True)
                SetAndAddColumnDataGrid_TestGer(pPropName:="item_unit_price", pName:="colItemUnitPrice", pHeaderText:="Item Unit Price", pWidth:=80, pReadOnly:=True)
                SetAndAddColumnDataGrid_TestGer(pPropName:="freight_per_unit", pName:="colFreightPerUnit", pHeaderText:="Freight Per Unit", pWidth:=80, pReadOnly:=True)
                SetAndAddColumnDataGrid_TestGer(pPropName:="discamt", pName:="colDiscAmt", pHeaderText:="Discount Amount", pWidth:=80, pReadOnly:=True)
                SetAndAddColumnDataGrid_TestGer(pPropName:="price", pName:="colPrice", pHeaderText:="Price", pWidth:=80, pReadOnly:=True)
                SetAndAddColumnDataGrid_TestGer(pPropName:="po_line_closed", pName:="colPOLineClosed", pHeaderText:="P/O Line Closed", pWidth:=50, pReadOnly:=True)
                SetAndAddColumnDataGrid_TestGer(pPropName:="Closed", pName:="colLineClosed", pHeaderText:="Line Closed", pWidth:=50, pReadOnly:=True)
            Case FIND_PO_LINE_SUBCONTRACT
                Dim colNames As New List(Of String) From {"colIdJobDet", "colJobLineId", "colItcd", "colItdesc"}
                Dim DataPropertyNames As New List(Of String) From {"id_jobdet", "job_line_id", "itcd", "itdesc"}
                Dim HeaderTexts = {"P/O Line Id", "P/O Line #", "Item Code", "Desc"}
                For i = 0 To colNames.Count - 1
                    Dim dgvtxtNew As New DataGridViewTextBoxColumn
                    With dgvtxtNew
                        .Name = colNames(i) ' Optional for reference
                        .DataPropertyName = DataPropertyNames(i)
                        .HeaderText = HeaderTexts(i)
                        .ReadOnly = True
                    End With
                    dgvSearchTable.Columns.Add(dgvtxtNew)
                Next
            Case FIND_WAREHOUSE
                SetAndAddColumnDataGrid_TestGer(pPropName:="warehouse_code", pName:="colWarehouseCode", pHeaderText:="Warehouse Code", pWidth:=100, pReadOnly:=True)
                SetAndAddColumnDataGrid_TestGer(pPropName:="warehouse_name", pName:="colWarehouseName", pHeaderText:="Warehouse Name", pWidth:=150, pReadOnly:=True)
                SetAndAddColumnDataGrid_TestGer(pPropName:="site_name", pName:="colSiteName", pHeaderText:="Site Name", pWidth:=250, pReadOnly:=True)


            Case FIND_SUBINVENTORY
                SetAndAddColumnDataGrid_TestGer(pPropName:="subinventory_code", pName:="colSubinventoryCode", pHeaderText:="Subinventory Code", pWidth:=150, pReadOnly:=True)
                SetAndAddColumnDataGrid_TestGer(pPropName:="subinventory_name", pName:="colSubinventoryName", pHeaderText:="Subinventory Name", pWidth:=250, pReadOnly:=True)

            Case FIND_LOCATION
                SetAndAddColumnDataGrid_TestGer(pPropName:="mtl_locations_id", pName:="colMtlLocationsID", pHeaderText:="Locations ID", pWidth:=140, pReadOnly:=True)
                SetAndAddColumnDataGrid_TestGer(pPropName:="location_name", pName:="colLocationName", pHeaderText:="Locations Name", pWidth:=300, pReadOnly:=True)
            Case FIND_UOM
                Dim colNames As New List(Of String) From {"colUomId", "colUom", "colUomclassName"}
                Dim DataPropertyNames As New List(Of String) From {"uom_id", "uom", "uom_class_name"}
                Dim HeaderTexts = {"Uom Id", "uom", "Uom Class"}
                For i = 0 To colNames.Count - 1
                    Dim dgvtxtNew As New DataGridViewTextBoxColumn
                    With dgvtxtNew
                        .Name = colNames(i) ' Optional for reference
                        .DataPropertyName = DataPropertyNames(i)
                        .HeaderText = HeaderTexts(i)
                        .ReadOnly = True
                    End With
                    dgvSearchTable.Columns.Add(dgvtxtNew)
                Next
            Case FIND_UOM_BY_CLASS
                SetAndAddColumnDataGrid_TestGer(pPropName:="uom_class_id", pName:="colUomClassID", pHeaderText:="Uom Class ID", pWidth:=80, pReadOnly:=True)
                SetAndAddColumnDataGrid_TestGer(pPropName:="uom", pName:="colUom", pHeaderText:="Uom", pWidth:=80, pReadOnly:=True)
                SetAndAddColumnDataGrid_TestGer(pPropName:="uom_name", pName:="colUomName", pHeaderText:="Uom Name", pWidth:=140, pReadOnly:=True)
                SetAndAddColumnDataGrid_TestGer(pPropName:="uom_class_name", pName:="colUomClassName", pHeaderText:="Uom Class Name", pWidth:=180, pReadOnly:=True)
            Case FIND_YARN_MAKEUP
                SetAndAddColumnDataGrid_TestGer(pPropName:="lookup_value_id", pName:="colLookupValueId", pHeaderText:="Lookup Value_id", pWidth:=80, pReadOnly:=True)
                SetAndAddColumnDataGrid_TestGer(pPropName:="lookup_value_code", pName:="colLookupValueCode", pHeaderText:="Lookup Value Code", pWidth:=120, pReadOnly:=True)
                SetAndAddColumnDataGrid_TestGer(pPropName:="lookup_value", pName:="colLookupValue", pHeaderText:="Lookup Value", pWidth:=200, pReadOnly:=True)
            Case FIND_MTL_TRAN_TYPE
                SetAndAddColumnDataGrid_TestGer(pPropName:="txn_type_code", pName:="colTxnTypeCode", pHeaderText:="Transaction Type Code", pWidth:=100, pReadOnly:=True)
                SetAndAddColumnDataGrid_TestGer(pPropName:="txn_type_name", pName:="colTxnTypeName", pHeaderText:="Transaction Type Name", pWidth:=240, pReadOnly:=True)
            Case FIND_MTL_TRAN_REASON
                SetAndAddColumnDataGrid_TestGer(pPropName:="mtl_txn_reason_id", pName:="colReasonID", pHeaderText:="Reason ID", pWidth:=60, pReadOnly:=True)
                SetAndAddColumnDataGrid_TestGer(pPropName:="reason_code", pName:="colReasonCode", pHeaderText:="Reason Code", pWidth:=120, pReadOnly:=True)
                SetAndAddColumnDataGrid_TestGer(pPropName:="reason_desc", pName:="colReasonDesc", pHeaderText:="Reason Desc", pWidth:=250, pReadOnly:=True)
            Case FIND_DEPARTMENTS
                SetAndAddColumnDataGrid_TestGer(pPropName:="deptcd", pName:="colDepartmentCode", pHeaderText:="Department Code", pWidth:=100, pReadOnly:=True)
                SetAndAddColumnDataGrid_TestGer(pPropName:="deptname", pName:="colDepartmentName", pHeaderText:="Department Name", pWidth:=240, pReadOnly:=True)
            Case FIND_EMPLOYEE
                SetAndAddColumnDataGrid_TestGer(pPropName:="empcd", pName:="colEmployeeCode", pHeaderText:="Employee Code", pWidth:=100, pReadOnly:=True)
                SetAndAddColumnDataGrid_TestGer(pPropName:="empname2", pName:="colEmployeeName", pHeaderText:="Employee Name", pWidth:=240, pReadOnly:=True)
            Case FIND_ONHAND_PARENT_LOT
                SetAndAddColumnDataGrid_TestGer(pPropName:="parent_lot_number", pName:="colParentLotNumber", pHeaderText:="Parent Lot Number", pWidth:=120, pReadOnly:=True)
                SetAndAddColumnDataGrid_TestGer(pPropName:="lot_number", pName:="colLotNumber", pHeaderText:="Lot Number", pWidth:=120, pReadOnly:=True)
                SetAndAddColumnDataGrid_TestGer(pPropName:="qty", pName:="colQty", pHeaderText:="Qty", pWidth:=80, pReadOnly:=True)
                SetAndAddColumnDataGrid_TestGer(pPropName:="uom", pName:="colUom", pHeaderText:="UOM", pWidth:=100, pReadOnly:=True)
                SetAndAddColumnDataGrid_TestGer(pPropName:="warehouse_code", pName:="colWarehouseCode", pHeaderText:="Warehouse Code", pWidth:=120, pReadOnly:=True)
                SetAndAddColumnDataGrid_TestGer(pPropName:="subinventory_code", pName:="colSubinventoryCode", pHeaderText:="Subinventory Code", pWidth:=120, pReadOnly:=True)
                SetAndAddColumnDataGrid_TestGer(pPropName:="location_name", pName:="colLocationName", pHeaderText:="Location Name", pWidth:=120, pReadOnly:=True)
                'Case FIND_STOCK_ONHAND_LIST
                '    SetAndAddColumnDataGrid_TestGer(pPropName:="package_num", pName:="colPackageNum", pHeaderText:="Pkg No.", pWidth:=50, pReadOnly:=True)
                '    SetAndAddColumnDataGrid_TestGer(pPropName:="itcd", pName:="colItemCode", pHeaderText:="Item Code", pWidth:=120, pReadOnly:=True)
                '    SetAndAddColumnDataGrid_TestGer(pPropName:="item_descp", pName:="colItemDesc", pHeaderText:="Description", pWidth:=240, pReadOnly:=True)
                '    SetAndAddColumnDataGrid_TestGer(pPropName:="parent_lot_number", pName:="colParentLotNo", pHeaderText:="Parent Lot Number", pWidth:=80, pReadOnly:=True)
                '    SetAndAddColumnDataGrid_TestGer(pPropName:="lot_number", pName:="colLotNo", pHeaderText:="Lot Number", pWidth:=120, pReadOnly:=True)
                '    SetAndAddColumnDataGrid_TestGer(pPropName:="grade_code", pName:="colGradeCode", pHeaderText:="Grade Code", pWidth:=80, pReadOnly:=True)
                '    SetAndAddColumnDataGrid_TestGer(pPropName:="subinventory_code", pName:="colSubinventory", pHeaderText:="Subinventory", pWidth:=100, pReadOnly:=True)
                '    SetAndAddColumnDataGrid_TestGer(pPropName:="location_name", pName:="colLocationName", pHeaderText:="Location", pWidth:=100, pReadOnly:=True)
                '    SetAndAddColumnDataGrid_TestGer(pPropName:="qty", pName:="colQty", pHeaderText:="Qty", pWidth:=80, pReadOnly:=True)
                '    SetAndAddColumnDataGrid_TestGer(pPropName:="uom_name1", pName:="colUOM1", pHeaderText:="UOM", pWidth:=80, pReadOnly:=True)
                '    SetAndAddColumnDataGrid_TestGer(pPropName:="qty2", pName:="colQty2", pHeaderText:="Qty 2", pWidth:=80, pReadOnly:=True)
                '    SetAndAddColumnDataGrid_TestGer(pPropName:="uom_name2", pName:="colUOM2", pHeaderText:="UOM 2", pWidth:=80, pReadOnly:=True)
            Case FIND_MFG_BOM_HEADER_LIST
                SetAndAddColumnDataGrid_TestGer(pPropName:="mfg_bom_header_id", pName:="colMfgBomHeaderId", pHeaderText:="ID", pWidth:=50, pReadOnly:=True)
                SetAndAddColumnDataGrid_TestGer(pPropName:="itcd", pName:="colItCd", pHeaderText:="Article No.", pWidth:=80, pReadOnly:=True)
                SetAndAddColumnDataGrid_TestGer(pPropName:="bom_code", pName:="colBomCode", pHeaderText:="Color", pWidth:=80, pReadOnly:=True)
                SetAndAddColumnDataGrid_TestGer(pPropName:="bom_name", pName:="colBomName", pHeaderText:="Strings", pWidth:=750, pReadOnly:=True)
            Case FIND_AR_PAYMENT_TERMS
                SetAndAddColumnDataGrid_TestGer(pPropName:="ar_payment_term_id", pName:="colARPaymentTermId", pHeaderText:="ID", pWidth:=50, pReadOnly:=True)
                SetAndAddColumnDataGrid_TestGer(pPropName:="term_name", pName:="colTermName", pHeaderText:="Name", pWidth:=150, pReadOnly:=True)
                SetAndAddColumnDataGrid_TestGer(pPropName:="term_description", pName:="colTermDescription", pHeaderText:="Description", pWidth:=200, pReadOnly:=True)
                SetAndAddColumnDataGrid_TestGer(pPropName:="credit_days", pName:="colCreditDays", pHeaderText:="Credit Days", pWidth:=50, pReadOnly:=True)
            Case FIND_AP_PAYMENT_TERMS
                SetAndAddColumnDataGrid_TestGer(pPropName:="ap_payment_term_id", pName:="colAPPaymentTermId", pHeaderText:="ID", pWidth:=50, pReadOnly:=True)
                SetAndAddColumnDataGrid_TestGer(pPropName:="term_name", pName:="colTermName", pHeaderText:="Name", pWidth:=150, pReadOnly:=True)
                SetAndAddColumnDataGrid_TestGer(pPropName:="term_description", pName:="colTermDescription", pHeaderText:="Description", pWidth:=200, pReadOnly:=True)
                SetAndAddColumnDataGrid_TestGer(pPropName:="credit_days", pName:="colCreditDays", pHeaderText:="Credit Days", pWidth:=50, pReadOnly:=True)
            Case FIND_DYE_JOB
                SetAndAddColumnDataGrid_TestGer(pPropName:="jobno", pName:="colJobNo", pHeaderText:="P/O No.", pWidth:=100, pReadOnly:=True)
                SetAndAddColumnDataGrid_TestGer(pPropName:="jobdt", pName:="colJobDt", pHeaderText:="P/O Date", pWidth:=100, pReadOnly:=True)
                SetAndAddColumnDataGrid_TestGer(pPropName:="suppcd", pName:="colSuppCd", pHeaderText:="Supplier Code", pWidth:=80, pReadOnly:=True)
                SetAndAddColumnDataGrid_TestGer(pPropName:="supp_name", pName:="colSuppName", pHeaderText:="Supplier Name", pWidth:=300, pReadOnly:=True)
            Case FIND_ORDER_SET
                SetAndAddColumnDataGrid_TestGer(pPropName:="so_header_id", pName:="colSoHeaderId", pHeaderText:="ID", pWidth:=40, pReadOnly:=True)
                SetAndAddColumnDataGrid_TestGer(pPropName:="sono", pName:="colSoNo", pHeaderText:="Order No.", pWidth:=80, pReadOnly:=True)
                SetAndAddColumnDataGrid_TestGer(pPropName:="sodt", pName:="colSoDt", pHeaderText:="Date", pWidth:=80, pReadOnly:=True)
                SetAndAddColumnDataGrid_TestGer(pPropName:="custpo", pName:="colCustPo", pHeaderText:="Customer P/O", pWidth:=120, pReadOnly:=True)
                SetAndAddColumnDataGrid_TestGer(pPropName:="cust_name", pName:="colCustName", pHeaderText:="Customer Name", pWidth:=120, pReadOnly:=True)

            Case FIND_MACHINES
                'Test By Neung for simple check and easy to see
                Dim colNames As New List(Of String) From {"colMachinesId", "colMcno", "colMcdesc", "colMctyp", "colStitches", "colMaxRuntimePerDay"}
                Dim DataPropertyNames As New List(Of String) From {"machines_id", "mcno", "mcdesc", "mctyp", "stitches", "max_runtime_per_day"}
                Dim HeaderTexts = {"Machines Id", "M/C No.", "Desc.", "Type", "Stitches", "Max Runtime/Day"}
                For i = 0 To colNames.Count - 1
                    Dim dgvtxtNew As New DataGridViewTextBoxColumn
                    With dgvtxtNew
                        .Name = colNames(i) ' Optional for reference
                        .DataPropertyName = DataPropertyNames(i)
                        .HeaderText = HeaderTexts(i)
                        .ReadOnly = True
                    End With
                    dgvSearchTable.Columns.Add(dgvtxtNew)
                Next
            Case FIND_OPERATIONS
                Dim colNames As New List(Of String) From {"colMfgOperationsId", "colOperationCode", "colOperationName", "colOperationStatus", "colProgGroupCode"}
                Dim DataPropertyNames As New List(Of String) From {"mfg_operations_id", "operation_code", "operation_name", "operation_status", "prog_group_code"}
                Dim HeaderTexts = {"Operation Id", "Code", "Name.", "Status", "Prog Group Code"}
                For i = 0 To colNames.Count - 1
                    Dim dgvtxtNew As New DataGridViewTextBoxColumn
                    With dgvtxtNew
                        .Name = colNames(i) ' Optional for reference
                        .DataPropertyName = DataPropertyNames(i)
                        .HeaderText = HeaderTexts(i)
                        .ReadOnly = True
                    End With
                    dgvSearchTable.Columns.Add(dgvtxtNew)
                Next
            Case FIND_DELIVERY_HEADER
                Dim colNames As New List(Of String) From {"colDeliveryNumber", "colDeliveryDate", "colDeliveryStatus", "colSoNoDisplay"}
                Dim DataPropertyNames As New List(Of String) From {"delivery_number", "delivery_date", "delivery_status", "sono_display"}
                Dim HeaderTexts = {"Delivery Number", "Date", "Status", "S/O No."}
                For i = 0 To colNames.Count - 1
                    Dim dgvtxtNew As New DataGridViewTextBoxColumn
                    With dgvtxtNew
                        .Name = colNames(i) ' Optional for reference
                        .DataPropertyName = DataPropertyNames(i)
                        .HeaderText = HeaderTexts(i)
                        .ReadOnly = True
                        .AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
                    End With
                    dgvSearchTable.Columns.Add(dgvtxtNew)
                Next
            Case FIND_STEP_NUMBER
                SetAndAddColumnDataGrid_TestGer(pPropName:="mfg_production_steps_id", pName:="colProductionStepsID", pHeaderText:="Production Steps ID", pWidth:=150, pReadOnly:=True)
                SetAndAddColumnDataGrid_TestGer(pPropName:="pos_no", pName:="colPosNo", pHeaderText:="Pos No", pWidth:=120, pReadOnly:=True)
                SetAndAddColumnDataGrid_TestGer(pPropName:="step_number", pName:="colStepNumber", pHeaderText:="Step Number", pWidth:=120, pReadOnly:=True)
                ' SetAndAddColumnDataGrid_TestGer(pPropName:="production_order_no", pName:="colProductionOrderNo", pHeaderText:="ProductionOrderNo", pWidth:=120, pReadOnly:=True) ' ///////////TESTING//////////////
                'SetAndAddColumnDataGrid_TestGer(pPropName:="operation_id", pName:="colOperationID", pHeaderText:="Operation ID", pWidth:=120, pReadOnly:=True)
                SetAndAddColumnDataGrid_TestGer(pPropName:="operation_code", pName:="colOperationCode", pHeaderText:="Operation Code", pWidth:=150, pReadOnly:=True)
                SetAndAddColumnDataGrid_TestGer(pPropName:="operation_name", pName:="colOperationName", pHeaderText:="Operation Name", pWidth:=220, pReadOnly:=True)

            Case FIND_SET_LIST
                SetAndAddColumnDataGrid_TestGer(pPropName:="production_order_id", pName:="colProductionOrderID", pHeaderText:="Production Order ID", pWidth:=150, pReadOnly:=True)
                SetAndAddColumnDataGrid_TestGer(pPropName:="production_order_no", pName:="colcolProductionOrderNO", pHeaderText:="Production Order No", pWidth:=120, pReadOnly:=True)
                SetAndAddColumnDataGrid_TestGer(pPropName:="production_order_date", pName:="colProductionOrderDate", pHeaderText:="Production Order Date", pWidth:=120, pReadOnly:=True)

            Case FIND_SET_LIST_UPSTEP_STITCH
                SetAndAddColumnDataGrid_TestGer(pPropName:="production_order_id", pName:="colProductionOrderID", pHeaderText:="Production Order ID", pWidth:=150, pReadOnly:=True)
                SetAndAddColumnDataGrid_TestGer(pPropName:="production_order_no", pName:="colcolProductionOrderNO", pHeaderText:="Production Order No", pWidth:=120, pReadOnly:=True)
                SetAndAddColumnDataGrid_TestGer(pPropName:="production_order_date", pName:="colProductionOrderDate", pHeaderText:="Production Order Date", pWidth:=120, pReadOnly:=True)

            Case FIND_SALES_PERSON_LIST
                SetAndAddColumnDataGrid_TestGer(pPropName:="sales_person_id", pName:="colSalePersonId", pHeaderText:="Sales Person ID", pWidth:=100, pReadOnly:=True)
                SetAndAddColumnDataGrid_TestGer(pPropName:="sales_person_name", pName:="colSalesPersonName", pHeaderText:="Sales Person Name", pWidth:=100, pReadOnly:=True)
                SetAndAddColumnDataGrid_TestGer(pPropName:="first_name", pName:="colFirstName", pHeaderText:="First Name", pWidth:=100, pReadOnly:=True)
                SetAndAddColumnDataGrid_TestGer(pPropName:="last_name", pName:="colLastName", pHeaderText:="Last Name", pWidth:=100, pReadOnly:=True)

            Case FIND_CALC_BOM_HEADER_LIST
                SetAndAddColumnDataGrid_TestGer(pPropName:="mfg_bom_header_id", pName:="colMfgBomHeaderId", pHeaderText:="ID", pWidth:=50, pReadOnly:=True)
                SetAndAddColumnDataGrid_TestGer(pPropName:="itcd", pName:="colItCd", pHeaderText:="Article No.", pWidth:=80, pReadOnly:=True)
                SetAndAddColumnDataGrid_TestGer(pPropName:="bom_code", pName:="colBomCode", pHeaderText:="Color", pWidth:=80, pReadOnly:=True)
                SetAndAddColumnDataGrid_TestGer(pPropName:="bom_name", pName:="colBomName", pHeaderText:="Strings", pWidth:=750, pReadOnly:=True)

            Case FIND_TRANSFER_SUBCONTRACT
                Dim colNames As New List(Of String) From {"colMtlTxnSetId", "colTxnNumber", "colTxnDate", "colSuppCode", "colSuppName", "colJobNo"} ' 30/07/2024 John added supplier and jobno
                Dim DataPropertyNames As New List(Of String) From {"mtl_txn_set_id", "txn_number", "txn_date", "suppcd", "suppname", "jobno"}
                Dim HeaderTexts = {"MTL Txn Set ID", "Txn Number", "Date", "Supplier Code", "Supplier Name", "P/O No."}
                For i = 0 To colNames.Count - 1
                    Dim dgvtxtNew As New DataGridViewTextBoxColumn
                    With dgvtxtNew
                        .Name = colNames(i) ' Optional for reference
                        .DataPropertyName = DataPropertyNames(i)
                        .HeaderText = HeaderTexts(i)
                        .ReadOnly = True
                    End With
                    dgvSearchTable.Columns.Add(dgvtxtNew)
                Next
            Case FIND_TRANSFER_WH
                Dim colNames As New List(Of String) From {"colMtlTxnSetId", "colTxnNumber", "colTxnDate"}
                Dim DataPropertyNames As New List(Of String) From {"mtl_txn_set_id", "txn_number", "txn_date"}
                Dim HeaderTexts = {"Mtl Txn Set Id", "Txn Number", "Date"}
                For i = 0 To colNames.Count - 1
                    Dim dgvtxtNew As New DataGridViewTextBoxColumn
                    With dgvtxtNew
                        .Name = colNames(i) ' Optional for reference
                        .DataPropertyName = DataPropertyNames(i)
                        .HeaderText = HeaderTexts(i)
                        .ReadOnly = True
                    End With
                    dgvSearchTable.Columns.Add(dgvtxtNew)
                Next
            Case FIND_TRANSFER_LOCATION
                Dim colNames As New List(Of String) From {"colMtlTxnSetId", "colTxnNumber", "colTxnDate"}
                Dim DataPropertyNames As New List(Of String) From {"mtl_txn_set_id", "txn_number", "txn_date"}
                Dim HeaderTexts = {"Mtl Txn Set Id", "Txn Number", "Date"}
                For i = 0 To colNames.Count - 1
                    Dim dgvtxtNew As New DataGridViewTextBoxColumn
                    With dgvtxtNew
                        .Name = colNames(i) ' Optional for reference
                        .DataPropertyName = DataPropertyNames(i)
                        .HeaderText = HeaderTexts(i)
                        .ReadOnly = True
                    End With
                    dgvSearchTable.Columns.Add(dgvtxtNew)
                Next
            Case FIND_SHIP_VIA
                Dim colNames As New List(Of String) From {"colLookValueUpid", "colLookUpValueCode", "colLookUpValue"}
                Dim DataPropertyNames As New List(Of String) From {"lookup_value_id", "lookup_value_code", "lookup_value"}
                Dim HeaderTexts = {"Ship Via Id", "Shia Via Code", "ship via"}
                For i = 0 To colNames.Count - 1
                    Dim dgvtxtNew As New DataGridViewTextBoxColumn
                    With dgvtxtNew
                        .Name = colNames(i) ' Optional for reference
                        .DataPropertyName = DataPropertyNames(i)
                        .HeaderText = HeaderTexts(i)
                        .ReadOnly = True
                    End With
                    dgvSearchTable.Columns.Add(dgvtxtNew)
                Next
            Case FIND_PRODUCTION_ORDER_HEADER
                Dim colNames As New List(Of String) From {"colProductionOrderId", "colProductionOrderNo", "colProductionOrderDate", "colSoNo", "colCustomerName"}
                Dim DataPropertyNames As New List(Of String) From {"production_order_id", "production_order_no", "production_order_date", "sono", "customer_name"}
                Dim HeaderTexts = {"Prod Id.", "Prod No.", "Prod Date", "S/O No.", "Customer Name"}
                For i = 0 To colNames.Count - 1
                    Dim dgvtxtNew As New DataGridViewTextBoxColumn
                    With dgvtxtNew
                        .Name = colNames(i) ' Optional for reference
                        .DataPropertyName = DataPropertyNames(i)
                        .HeaderText = HeaderTexts(i)
                        .ReadOnly = True
                    End With
                    dgvSearchTable.Columns.Add(dgvtxtNew)
                Next
            Case FIND_MATERIAL_LINE
                Dim colNames As New List(Of String) From {"colItemId", "colItcd", "colItdesc", "colQtyOnHand", "colUom"}
                Dim DataPropertyNames As New List(Of String) From {"item_id", "itcd", "itdesc", "qty_onhand", "Uom"}
                Dim HeaderTexts = {"Item Id.", "Article No.", "Description", "Onhand Qty", "Uom"}
                For i = 0 To colNames.Count - 1
                    Dim dgvtxtNew As New DataGridViewTextBoxColumn
                    With dgvtxtNew
                        .Name = colNames(i) ' Optional for reference
                        .DataPropertyName = DataPropertyNames(i)
                        .HeaderText = HeaderTexts(i)
                        .ReadOnly = True
                    End With
                    dgvSearchTable.Columns.Add(dgvtxtNew)
                Next
            Case FIND_PRODUCT_LINE
                Dim colNames As New List(Of String) From {"colItemId", "colItcd", "colItdesc", "colQtyOnHand", "colUom"}
                Dim DataPropertyNames As New List(Of String) From {"item_id", "itcd", "itdesc", "qty_onhand", "Uom"}
                Dim HeaderTexts = {"Item Id.", "Article No.", "Description", "Onhand Qty", "Uom"}
                For i = 0 To colNames.Count - 1
                    Dim dgvtxtNew As New DataGridViewTextBoxColumn
                    With dgvtxtNew
                        .Name = colNames(i) ' Optional for reference
                        .DataPropertyName = DataPropertyNames(i)
                        .HeaderText = HeaderTexts(i)
                        .ReadOnly = True
                    End With
                    dgvSearchTable.Columns.Add(dgvtxtNew)
                Next
            Case FIND_CODE_LEFT_RIGHT
                Dim colNames As New List(Of String) From {"colLookValueUpid", "colLookUpValueCode", "colLookUpValue"}
                Dim DataPropertyNames As New List(Of String) From {"lookup_value_id", "lookup_value_code", "lookup_value"}
                Dim HeaderTexts = {"Code Left Right Id", "Left Right Code", "Left Right"}
                For i = 0 To colNames.Count - 1
                    Dim dgvtxtNew As New DataGridViewTextBoxColumn
                    With dgvtxtNew
                        .Name = colNames(i) ' Optional for reference
                        .DataPropertyName = DataPropertyNames(i)
                        .HeaderText = HeaderTexts(i)
                        .ReadOnly = True
                    End With
                    dgvSearchTable.Columns.Add(dgvtxtNew)
                Next
            Case FIND_AR_INVOICE_HEADER
                Dim colNames As New List(Of String) From {"colArinvoiceHeaderId", "colInvoiceNumber", "colInvoiceDate"}
                Dim DataPropertyNames As New List(Of String) From {"ar_invoice_header_id", "invoice_number", "invoice_date"}
                Dim HeaderTexts = {"Invoice Header Id", "Invoice Number", "Invoice Date"}
                For i = 0 To colNames.Count - 1
                    Dim dgvtxtNew As New DataGridViewTextBoxColumn
                    With dgvtxtNew
                        .Name = colNames(i) ' Optional for reference
                        .DataPropertyName = DataPropertyNames(i)
                        .HeaderText = HeaderTexts(i)
                        .ReadOnly = True
                    End With
                    dgvSearchTable.Columns.Add(dgvtxtNew)
                Next
            Case FIND_CALC_HEADER_LIST
                Dim colNames As New List(Of String) From {"colCalcNumber", "colCalcDate"}
                Dim DataPropertyNames As New List(Of String) From {"calc_number", "calc_date"}
                Dim HeaderTexts = {"Calc No.", "Calc Date"}
                For i = 0 To colNames.Count - 1
                    Dim dgvtxtNew As New DataGridViewTextBoxColumn
                    With dgvtxtNew
                        .Name = colNames(i) ' Optional for reference
                        .DataPropertyName = DataPropertyNames(i)
                        .HeaderText = HeaderTexts(i)
                        .ReadOnly = True
                    End With
                    dgvSearchTable.Columns.Add(dgvtxtNew)
                Next
            Case FIND_EFFICIENCY
                Dim colNames As New List(Of String) From {"colLookUpValueCode", "colLookUpValue"}
                Dim DataPropertyNames As New List(Of String) From {"lookup_value_code", "lookup_value"}
                Dim HeaderTexts = {"Lookup Value Code", "Lookup Value"}
                For i = 0 To colNames.Count - 1
                    Dim dgvtxtNew As New DataGridViewTextBoxColumn
                    With dgvtxtNew
                        .Name = colNames(i) ' Optional for reference
                        .DataPropertyName = DataPropertyNames(i)
                        .HeaderText = HeaderTexts(i)
                        .ReadOnly = True
                    End With
                    dgvSearchTable.Columns.Add(dgvtxtNew)
                Next
            Case FIND_TARIFF_HEADER_LIST
                Dim colNames As New List(Of String) From {"colTariffNumber", "colTariffDate", "colTariffType", "colTariffName"}
                Dim DataPropertyNames As New List(Of String) From {"tariff_number", "tariff_date", "tariff_type", "tariff_name"}
                Dim HeaderTexts = {"Tariff Number", "Tariff Date", "Tariff Type", "Tariff Name"}
                For i = 0 To colNames.Count - 1
                    Dim dgvtxtNew As New DataGridViewTextBoxColumn
                    With dgvtxtNew
                        .Name = colNames(i) ' Optional for reference
                        .DataPropertyName = DataPropertyNames(i)
                        .HeaderText = HeaderTexts(i)
                        .ReadOnly = True
                    End With
                    dgvSearchTable.Columns.Add(dgvtxtNew)
                Next
            Case FIND_TARIFF_LINE_LIST
                Dim colNames As New List(Of String) From {"colTariffNumber", "colLineNumber", "colTariffDesc", "colDyeLycraPerc"}
                Dim DataPropertyNames As New List(Of String) From {"tariff_number", "line_number", "tariff_desc", "dye_lycra_perc"}
                Dim HeaderTexts = {"Tariff Number", "Line Number", "Tariff Description", "DYE Lycra Perc"}
                For i = 0 To colNames.Count - 1
                    Dim dgvtxtNew As New DataGridViewTextBoxColumn
                    With dgvtxtNew
                        .Name = colNames(i) ' Optional for reference
                        .DataPropertyName = DataPropertyNames(i)
                        .HeaderText = HeaderTexts(i)
                        .ReadOnly = True
                    End With
                    dgvSearchTable.Columns.Add(dgvtxtNew)
                Next
            Case FIND_TARIFF_LINE_LIST
                Dim colNames As New List(Of String) From {"col", "colLineNumber", "colTariffDesc", "colDyeLycraPerc"}
                Dim DataPropertyNames As New List(Of String) From {"tariff_number", "line_number", "tariff_desc", "dye_lycra_perc"}
                Dim HeaderTexts = {"Tariff Number", "Line Number", "Tariff Description", "DYE Lycra Perc"}
                For i = 0 To colNames.Count - 1
                    Dim dgvtxtNew As New DataGridViewTextBoxColumn
                    With dgvtxtNew
                        .Name = colNames(i) ' Optional for reference
                        .DataPropertyName = DataPropertyNames(i)
                        .HeaderText = HeaderTexts(i)
                        .ReadOnly = True
                    End With
                    dgvSearchTable.Columns.Add(dgvtxtNew)
                Next
            Case FIND_CUSTOMER_ITEMS_XREF_LIST
                Dim colNames As New List(Of String) From {"colCustomerItemNumber", "colCustomerItemName", "colCustomerName"}
                Dim DataPropertyNames As New List(Of String) From {"customer_item_number", "customer_item_name", "customer_name"}
                Dim HeaderTexts = {"Customer Item Number", "Customer Item Name", "Customer Name"}
                For i = 0 To colNames.Count - 1
                    Dim dgvtxtNew As New DataGridViewTextBoxColumn
                    With dgvtxtNew
                        .Name = colNames(i) ' Optional for reference
                        .DataPropertyName = DataPropertyNames(i)
                        .HeaderText = HeaderTexts(i)
                        .ReadOnly = True
                    End With
                    dgvSearchTable.Columns.Add(dgvtxtNew)
                Next
            Case Else

        End Select
    End Sub

    Private Sub SetAndAddColumnDataGrid_TestGer(pPropName As String, pName As String, pHeaderText As String, pWidth As Integer, pReadOnly As Boolean)
        ' for test, 
        With dgvSearchTable
            Dim dgvc As DataGridViewColumn = New DataGridViewTextBoxColumn()
            With dgvc
                .DataPropertyName = pPropName
                .Name = pName
                .HeaderText = pHeaderText
                .Width = pWidth
                .ReadOnly = pReadOnly
            End With
            .Columns.Add(dgvc)
        End With
    End Sub

    Private Sub InitForm()
        Select Case DataForFind
            Case FIND_COLORS
                Me.Width = 1024
                Me.Height = 500
                Me.Text = "Search code for colors"
            Case FIND_THREAD_CLIPPING '"code for thread clipping"
                Me.Width = 1024
                Me.Height = 500
                Me.Text = "Search code for thread clipping"
            Case FIND_ITEMS
                Me.Width = 1024
                Me.Height = 500
                Me.Text = "Search Items (ใส่ % เพื่อ ช่วยในการค้นหา เช่น %905%)"
            Case FIND_SUPPLIERS
                Me.Width = 1024
                Me.Height = 500
                Me.Text = "Search Suppliers"
            Case FIND_PIECE_DYE_COLOR
                Me.Width = 1024
                Me.Height = 500
                Me.Text = "Search piecd dye color"
            Case FIND_ITEMS_VARIANT
                Me.Width = 1024
                Me.Height = 500
                Me.Text = "Search Item Variant"
            Case FIND_CUSTOMERS
                Me.Width = 1024
                Me.Height = 500
                Me.Text = "Search Customers"
            Case FIND_BILL_TO_SITE
                Me.Width = 1024
                Me.Height = 500
                Me.Text = "Search Customers bill to Site"
            Case FIND_SHIP_TO_SITE
                Me.Width = 1024
                Me.Height = 500
                Me.Text = "Search Customers Ship to Site"
            Case FIND_SO, FIND_SO_TEST
                Me.Width = 1024
                Me.Height = 500
                Me.Text = "Search Sale Order"
            Case FIND_SOITM
                Me.Width = 1024
                Me.Height = 500
                Me.Text = "Search S/O Line Item"
            Case FIND_BANKS
                Me.Width = 1024
                Me.Height = 500
                Me.Text = "Search Banks"
            Case FIND_GRADES
                Me.Width = 1024
                Me.Height = 500
                Me.Text = "Search Grades"
            Case FIND_MFG_BOM_HEADER
                Me.Width = 1024
                Me.Height = 500
                Me.Text = "Search Bom Header"
            Case FIND_COLORIT
                Me.Width = 1024
                Me.Height = 500
                Me.Text = "Search Colorit"
            Case FIND_MFG_BOM_HEADER_LIST
                Me.Width = 1024
                Me.Height = 500
                Me.Text = "Search Bom Header List"
            Case FIND_MFG_ROUTING_HEADER
                Me.Width = 1024
                Me.Height = 500
                Me.Text = "Search Routing Header"
            Case FIND_TRN_NUMBER
                Me.Width = 1024
                Me.Height = 500
                Me.Text = "Search Transaction Number"
            Case FIND_PO_HEADER
                Me.Width = 1024
                Me.Height = 500
                Me.Text = "Search P/O Header Number"
            Case FIND_PO_HEADER_SUBCONTRACT
                Me.Width = 1024
                Me.Height = 500
                Me.Text = "Search P/O Header Subcontract"
            Case FIND_PO_LINE
                Me.Width = 1024
                Me.Height = 500
                Me.Text = "Search P/O Line Number"
            Case FIND_PO_LINE_SUBCONTRACT
                Me.Width = 1024
                Me.Height = 500
                Me.Text = "Search P/O Line Number"
            Case FIND_WAREHOUSE
                Me.Width = 1024
                Me.Height = 500
                Me.Text = "Search Warehouse"
            Case FIND_SUBINVENTORY
                Me.Width = 1024
                Me.Height = 500
                Me.Text = "Search Subinventory"
            Case FIND_LOCATION
                Me.Width = 1024
                Me.Height = 500
                Me.Text = "Search Location"
            Case FIND_UOM
                Me.Width = 1024
                Me.Height = 500
                Me.Text = "Search Uom"
            Case FIND_UOM_BY_CLASS
                Me.Width = 1024
                Me.Height = 500
                Me.Text = "Search Uom By Class"
            Case FIND_YARN_MAKEUP
                Me.Width = 1024
                Me.Height = 500
                Me.Text = "Search Yarn Makeup"
            Case FIND_MTL_TRAN_TYPE
                Me.Width = 1024
                Me.Height = 500
                Me.Text = "Search MTL Tran Type"
            Case FIND_MTL_TRAN_REASON
                Me.Width = 1024
                Me.Height = 500
                Me.Text = "Search MTL Tran Reason"
            Case FIND_DEPARTMENTS
                Me.Width = 1024
                Me.Height = 500
                Me.Text = "Search Departments"
            Case FIND_EMPLOYEE
                Me.Width = 1024
                Me.Height = 500
                Me.Text = "Search Employee"
            Case FIND_ONHAND_PARENT_LOT
                Me.Width = 1024
                Me.Height = 500
                Me.Text = "Search MTL Onhand Parent Lot No."
            Case FIND_CHILD_PRODUCTION_ORDER
                Me.Width = 1024
                Me.Height = 500
                Me.Text = "Search MTL Onhand Parent Lot No."
            Case FIND_OPERATIONS
                Me.Width = 1024
                Me.Height = 500
                Me.Text = "Search MTL Onhand Parent Lot No."
            Case FIND_AR_PAYMENT_TERMS
                Me.Width = 1024
                Me.Height = 500
                Me.Text = "Search AR Payment Terms"
            Case FIND_AP_PAYMENT_TERMS
                Me.Width = 1024
                Me.Height = 500
                Me.Text = "Search AP Payment Terms"
            Case FIND_DYE_JOB
                Me.Width = 1024
                Me.Height = 500
                Me.Text = "Search Dye Job No"
            Case FIND_ORDER_SET
                Me.Width = 1024
                Me.Height = 500
                Me.Text = "Search Order Set"
            Case FIND_DELIVERY_HEADER
                Me.Width = 1024
                Me.Height = 500
                Me.Text = "Search Delivery"
            Case FIND_STEP_NUMBER
                Me.Width = 1024
                Me.Height = 500
                Me.Text = "Search Step Number"
            Case FIND_SALES_PERSON_LIST
                Me.Width = 1024
                Me.Height = 500
                Me.Text = "Search Sales Person List"
            Case FIND_SET_LIST
                Me.Width = 1024
                Me.Height = 500
                Me.Text = "Search Set List"
            Case FIND_SET_LIST_UPSTEP_STITCH
                Me.Width = 1024
                Me.Height = 500
                Me.Text = "Search Set List UpStep Stitch"
            Case FIND_TRANSFER_SUBCONTRACT
                Me.Width = 1024
                Me.Height = 500
                Me.Text = "Search Transfer Subcontract"
            Case FIND_TRANSFER_WH
                Me.Width = 1024
                Me.Height = 500
                Me.Text = "Search Transfer WH"
            Case FIND_TRANSFER_LOCATION
                Me.Width = 1024
                Me.Height = 500
                Me.Text = "Search Transfer Location"
            Case FIND_PRODUCTION_ORDER_HEADER
                Me.Width = 1024
                Me.Height = 500
                Me.Text = "Search Production Order"
            Case FIND_MATERIAL_LINE
                Me.Width = 1024
                Me.Height = 500
                Me.Text = "Search Material Line"
            Case FIND_PRODUCT_LINE
                Me.Width = 1024
                Me.Height = 500
                Me.Text = "Search Product Line"
            Case FIND_CODE_LEFT_RIGHT
                Me.Width = 1024
                Me.Height = 500
                Me.Text = "Search Left / Right Code"
            Case FIND_AR_INVOICE_HEADER
                Me.Width = 1024
                Me.Height = 500
                Me.Text = "Search Invoice Header"
            Case FIND_CALC_HEADER_LIST
                Me.Width = 1024
                Me.Height = 500
                Me.Text = "Search Calc Header List"
            Case FIND_EFFICIENCY
                Me.Width = 1024
                Me.Height = 500
                Me.Text = "Search Calc Header List"
            Case FIND_TARIFF_HEADER_LIST
                Me.Width = 1024
                Me.Height = 500
                Me.Text = "Search Tariff Header List"
            Case FIND_TARIFF_LINE_LIST
                Me.Width = 1024
                Me.Height = 500
                Me.Text = "Search Tariff Line List"
            Case FIND_CALC_BOM_HEADER_LIST
                Me.Width = 1024
                Me.Height = 500
                Me.Text = "Search Bom Header List"
            Case FIND_CUSTOMER_ITEMS_XREF_LIST
                Me.Width = 1024
                Me.Height = 500
                Me.Text = "Search Customer Items (ใส่ % เพื่อ ช่วยในการค้นหา เช่น 905%)"
            Case Else
                Me.Width = 1024
                Me.Height = 500
                Me.Text = "Search (ใส่ % เพื่อ ช่วยในการค้นหา เช่น 905%)"
        End Select
    End Sub
    Private Sub setTextofStatusStrip()

        Select Case DataForFind
            Case FIND_COLORS
                lblStatusUserID.Text = _AppUserID
                lblStatusSessionID.Text = _AppSessionID
                lblStatusDatabase.Text = _AppConn.Database
                lblStatusMessage.Text = ""
                lblStatusMode.Text = "Search"
            Case FIND_THREAD_CLIPPING
                lblStatusUserID.Text = _AppUserID
                lblStatusSessionID.Text = _AppSessionID
                lblStatusDatabase.Text = _AppConn.Database
                lblStatusMessage.Text = ""
                lblStatusMode.Text = "Search"
            Case FIND_ITEMS
                lblStatusUserID.Text = _AppUserID
                lblStatusSessionID.Text = _AppSessionID
                lblStatusDatabase.Text = _AppConn.Database
                lblStatusMessage.Text = ""
                lblStatusMode.Text = "Search"
            Case FIND_SUPPLIERS
                lblStatusUserID.Text = _AppUserID
                lblStatusSessionID.Text = _AppSessionID
                lblStatusDatabase.Text = _AppConn.Database
                lblStatusMessage.Text = ""
                lblStatusMode.Text = "Search"
            Case FIND_PIECE_DYE_COLOR
                lblStatusUserID.Text = _AppUserID
                lblStatusSessionID.Text = _AppSessionID
                lblStatusDatabase.Text = _AppConn.Database
                lblStatusMessage.Text = ""
                lblStatusMode.Text = "Search"
            Case FIND_ITEMS_VARIANT
                lblStatusUserID.Text = _AppUserID
                lblStatusSessionID.Text = _AppSessionID
                lblStatusDatabase.Text = _AppConn.Database
                lblStatusMessage.Text = ""
                lblStatusMode.Text = "Search"
            Case FIND_CUSTOMERS
                lblStatusUserID.Text = _AppUserID
                lblStatusSessionID.Text = _AppSessionID
                lblStatusDatabase.Text = _AppConn.Database
                lblStatusMessage.Text = ""
                lblStatusMode.Text = "Search"
            Case FIND_BILL_TO_SITE
                lblStatusUserID.Text = _AppUserID
                lblStatusSessionID.Text = _AppSessionID
                lblStatusDatabase.Text = _AppConn.Database
                lblStatusMessage.Text = ""
                lblStatusMode.Text = "Search"
            Case FIND_SHIP_TO_SITE
                lblStatusUserID.Text = _AppUserID
                lblStatusSessionID.Text = _AppSessionID
                lblStatusDatabase.Text = _AppConn.Database
                lblStatusMessage.Text = ""
                lblStatusMode.Text = "Search"
            Case FIND_SO, FIND_SO_TEST
                lblStatusUserID.Text = _AppUserID
                lblStatusSessionID.Text = _AppSessionID
                lblStatusDatabase.Text = _AppConn.Database
                lblStatusMessage.Text = ""
                lblStatusMode.Text = "Search"
            Case FIND_SOITM
                lblStatusUserID.Text = _AppUserID
                lblStatusSessionID.Text = _AppSessionID
                lblStatusDatabase.Text = _AppConn.Database
                lblStatusMessage.Text = ""
                lblStatusMode.Text = "Search"
            Case FIND_BANKS
                lblStatusUserID.Text = _AppUserID
                lblStatusSessionID.Text = _AppSessionID
                lblStatusDatabase.Text = _AppConn.Database
                lblStatusMessage.Text = ""
                lblStatusMode.Text = "Search"
            Case FIND_GRADES
                lblStatusUserID.Text = _AppUserID
                lblStatusSessionID.Text = _AppSessionID
                lblStatusDatabase.Text = _AppConn.Database
                lblStatusMessage.Text = ""
                lblStatusMode.Text = "Search"
            Case FIND_MFG_BOM_HEADER, FIND_MFG_BOM_HEADER_LIST, FIND_CALC_BOM_HEADER_LIST
                lblStatusUserID.Text = _AppUserID
                lblStatusSessionID.Text = _AppSessionID
                lblStatusDatabase.Text = _AppConn.Database
                lblStatusMessage.Text = ""
                lblStatusMode.Text = "Search"
            Case FIND_COLORIT
                lblStatusUserID.Text = _AppUserID
                lblStatusSessionID.Text = _AppSessionID
                lblStatusDatabase.Text = _AppConn.Database
                lblStatusMessage.Text = ""
                lblStatusMode.Text = "Search"
            Case FIND_TRN_NUMBER
                lblStatusUserID.Text = _AppUserID
                lblStatusSessionID.Text = _AppSessionID
                lblStatusDatabase.Text = _AppConn.Database
                lblStatusMessage.Text = ""
                lblStatusMode.Text = "Search"
            Case FIND_PO_HEADER, FIND_PO_HEADER_SUBCONTRACT, FIND_PO_LINE, FIND_PO_LINE_SUBCONTRACT, FIND_WAREHOUSE, FIND_SUBINVENTORY, FIND_LOCATION, FIND_UOM, FIND_UOM_BY_CLASS, FIND_YARN_MAKEUP, FIND_MTL_TRAN_TYPE, FIND_MTL_TRAN_REASON, FIND_DEPARTMENTS, FIND_EMPLOYEE, FIND_ONHAND_PARENT_LOT
                lblStatusUserID.Text = _AppUserID
                lblStatusSessionID.Text = _AppSessionID
                lblStatusDatabase.Text = _AppConn.Database
                lblStatusMessage.Text = ""
                lblStatusMode.Text = "Search"
            Case FIND_CHILD_PRODUCTION_ORDER
                lblStatusUserID.Text = _AppUserID
                lblStatusSessionID.Text = _AppSessionID
                lblStatusDatabase.Text = _AppConn.Database
                lblStatusMessage.Text = ""
                lblStatusMode.Text = "Search"
            Case FIND_OPERATIONS
                lblStatusUserID.Text = _AppUserID
                lblStatusSessionID.Text = _AppSessionID
                lblStatusDatabase.Text = _AppConn.Database
                lblStatusMessage.Text = ""
                lblStatusMode.Text = "Search"
            Case FIND_DELIVERY_HEADER
                lblStatusUserID.Text = _AppUserID
                lblStatusSessionID.Text = _AppSessionID
                lblStatusDatabase.Text = _AppConn.Database
                lblStatusMessage.Text = ""
                lblStatusMode.Text = "Search"
            Case FIND_STEP_NUMBER
                lblStatusUserID.Text = _AppUserID
                lblStatusSessionID.Text = _AppSessionID
                lblStatusDatabase.Text = _AppConn.Database
                lblStatusMessage.Text = ""
                lblStatusMode.Text = "Search"
            Case FIND_SALES_PERSON_LIST
                lblStatusUserID.Text = _AppUserID
                lblStatusSessionID.Text = _AppSessionID
                lblStatusDatabase.Text = _AppConn.Database
                lblStatusMessage.Text = ""
                lblStatusMode.Text = "Search"
            Case FIND_SET_LIST
                lblStatusUserID.Text = _AppUserID
                lblStatusSessionID.Text = _AppSessionID
                lblStatusDatabase.Text = _AppConn.Database
                lblStatusMessage.Text = ""
                lblStatusMode.Text = "Search"
            Case FIND_SET_LIST_UPSTEP_STITCH
                lblStatusUserID.Text = _AppUserID
                lblStatusSessionID.Text = _AppSessionID
                lblStatusDatabase.Text = _AppConn.Database
                lblStatusMessage.Text = ""
                lblStatusMode.Text = "Search"
            Case FIND_TRANSFER_SUBCONTRACT
                lblStatusUserID.Text = _AppUserID
                lblStatusSessionID.Text = _AppSessionID
                lblStatusDatabase.Text = _AppConn.Database
                lblStatusMessage.Text = ""
                lblStatusMode.Text = "Search"
            Case FIND_TRANSFER_WH
                lblStatusUserID.Text = _AppUserID
                lblStatusSessionID.Text = _AppSessionID
                lblStatusDatabase.Text = _AppConn.Database
                lblStatusMessage.Text = ""
                lblStatusMode.Text = "Search"
            Case FIND_TRANSFER_LOCATION
                lblStatusUserID.Text = _AppUserID
                lblStatusSessionID.Text = _AppSessionID
                lblStatusDatabase.Text = _AppConn.Database
                lblStatusMessage.Text = ""
                lblStatusMode.Text = "Search"
            Case FIND_EFFICIENCY
                lblStatusUserID.Text = _AppUserID
                lblStatusSessionID.Text = _AppSessionID
                lblStatusDatabase.Text = _AppConn.Database
                lblStatusMessage.Text = ""
                lblStatusMode.Text = "Search"
            Case Else
                lblStatusUserID.Text = _AppUserID
                lblStatusSessionID.Text = _AppSessionID
                lblStatusDatabase.Text = _AppConn.Database
                lblStatusMessage.Text = ""
                lblStatusMode.Text = "Search"

        End Select


    End Sub
    Private Sub getSearchTableFocus()
        If dgvSearchTable.Rows.Count > 0 Then
            'dgvSearchTable.Focus()
            txtFilterText.Focus()
        End If
    End Sub
    Private Sub txtFilterText_GotFocus(sender As Object, e As EventArgs) Handles txtFilterText.GotFocus
        RemovePlaceholder(txtFilterText, "Use % for partial search, e.g. %905%")
    End Sub

    Private Sub txtFilterText_LostFocus(sender As Object, e As EventArgs) Handles txtFilterText.LostFocus
        SetPlaceholder(txtFilterText, "Use % for partial search, e.g. %905%")
    End Sub

    '--------------------------
    Private Sub SetPlaceholder(tb As TextBox, text As String)
        If tb.Text = "" Then
            tb.Text = text
            tb.ForeColor = Color.Gray
        End If
    End Sub

    Private Sub RemovePlaceholder(tb As TextBox, text As String)
        If tb.Text = text Then
            tb.Text = ""
            tb.ForeColor = Color.Black
        End If
    End Sub
    Private Sub frmListOfValue_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' When the form loads, the KeyPreview property is set to True.
        ' This lets the form capture keyboard events before
        ' any other element in the form.
        Me.KeyPreview = True

        SetPlaceholder(txtFilterText, "Use % for partial search, e.g. %905%")

        Select Case DataForFind
            Case FIND_COLORS
                Me.WindowState = FormWindowState.Normal
            Case FIND_THREAD_CLIPPING
                Me.WindowState = FormWindowState.Maximized
            Case FIND_ITEMS
                Me.WindowState = FormWindowState.Normal
            Case FIND_SUPPLIERS
                Me.WindowState = FormWindowState.Maximized
            Case FIND_PIECE_DYE_COLOR
                Me.WindowState = FormWindowState.Normal
            Case FIND_ITEMS_VARIANT, FIND_SO_TEST
                Me.WindowState = FormWindowState.Normal
            Case FIND_SO
                Me.WindowState = FormWindowState.Maximized
            Case FIND_SOITM
                Me.WindowState = FormWindowState.Maximized
            Case FIND_BANKS
                Me.WindowState = FormWindowState.Maximized
            Case FIND_GRADES
                Me.WindowState = FormWindowState.Maximized
            Case FIND_MFG_BOM_HEADER
                Me.WindowState = FormWindowState.Maximized
            Case FIND_COLORIT
                Me.WindowState = FormWindowState.Maximized
            Case FIND_MFG_ROUTING_HEADER
                Me.WindowState = FormWindowState.Maximized
            Case FIND_TRN_NUMBER
                Me.WindowState = FormWindowState.Normal
            Case FIND_PO_HEADER, FIND_PO_HEADER_SUBCONTRACT, FIND_PO_LINE, FIND_PO_LINE_SUBCONTRACT
                Me.WindowState = FormWindowState.Normal
            Case FIND_WAREHOUSE, FIND_SUBINVENTORY, FIND_LOCATION, FIND_UOM, FIND_UOM_BY_CLASS, FIND_YARN_MAKEUP, FIND_MTL_TRAN_TYPE, FIND_MTL_TRAN_REASON, FIND_DEPARTMENTS, FIND_EMPLOYEE
                Me.WindowState = FormWindowState.Normal
            Case FIND_ONHAND_PARENT_LOT, FIND_MFG_BOM_HEADER_LIST, FIND_CALC_BOM_HEADER_LIST
                Me.WindowState = FormWindowState.Normal
            Case FIND_CHILD_PRODUCTION_ORDER
                Me.WindowState = FormWindowState.Normal
            Case FIND_OPERATIONS, FIND_AR_PAYMENT_TERMS, FIND_AP_PAYMENT_TERMS, FIND_DYE_JOB, FIND_ORDER_SET, FIND_AR_INVOICE_HEADER
                Me.WindowState = FormWindowState.Normal
            Case FIND_CALC_HEADER_LIST, FIND_EFFICIENCY, FIND_TARIFF_HEADER_LIST, FIND_TARIFF_LINE_LIST
                Me.WindowState = FormWindowState.Normal
            Case Else
                Me.WindowState = FormWindowState.Maximized

        End Select

        Me.CenterToParent()
        'Me.StartPosition = FormStartPosition.CenterScreen

        InitForm()
        setTextofStatusStrip()
        createDatagridview()
        getAndShowDataRec()
        getSearchTableFocus()
    End Sub

    Private Sub txtWordFilter_TextChanged(sender As Object, e As EventArgs) Handles txtFilterText.TextChanged
        'Dim FilterExp As New StringBuilder
        'Dim SearchString As String
        'SearchString = txtWordFilter.Text.Trim
        'FilterExp.Clear()

        'Select Case DataForFind
        '    Case FIND_THREAD_CLIPPING '"code for thread clipping"
        '        FilterExp.Append(" lookup_value_code LIKE '*" & SearchString & "*'")
        '        FilterExp.Append(" or lookup_value LIKE '*" & SearchString & "*'")
        '    Case FIND_ITEMS
        '        FilterExp.Append(" itcd LIKE '*" & SearchString & "*'")
        '        FilterExp.Append(" or itdesc LIKE '*" & SearchString & "*'")
        '    Case FIND_SUPPLIERS
        '        FilterExp.Append(" supplier_code LIKE '*" & SearchString & "*'")
        '        FilterExp.Append(" or supplier_name LIKE '*" & SearchString & "*'")
        '    Case FIND_PIECE_DYE_COLOR
        '        FilterExp.Append(" lookup_value_code LIKE '*" & SearchString & "*'")
        '        FilterExp.Append(" or lookup_value LIKE '*" & SearchString & "*'")
        '    Case FIND_ITEMS_VARIANT
        '        FilterExp.Append(" variant_code LIKE '*" & SearchString & "*'")
        '        FilterExp.Append(" or variant_name LIKE '*" & SearchString & "*'")
        'End Select

        'If SearchString <> "" Then
        '    bsSearchTable.Filter = FilterExp.ToString
        'Else
        '    bsSearchTable.Filter = ""
        'End If
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        _UserAction = "CANCEL"
        Me.Close()
    End Sub

    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        drvSearchTable = CType(bsSearchTable.Current, DataRowView)
        _UserAction = "OK"
        Me.Close()
    End Sub

    Private Sub dgvSearchTable_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvSearchTable.CellDoubleClick
        ' drvSearchTable = CType(bsSearchTable.Current, DataRowView)
        ' _UserAction = "OK"
        ' Me.Close()
        Call btnOK_Click(sender, e)
    End Sub

    Private Sub txtWordFilter_KeyDown(sender As Object, e As KeyEventArgs) Handles txtFilterText.KeyDown
        If e.KeyCode = Keys.Enter Then

            getAndShowDataRec()
            getSearchTableFocus()

            If UserValueFound = True Then
                drvSearchTable = CType(bsSearchTable.Current, DataRowView)
                _UserAction = "OK"
                Me.Close()
            End If

            If dgvSearchTable.Rows.Count > 0 Then 'Neung 20240506
                dgvSearchTable.Focus()
            End If

        End If
    End Sub

    Private Sub frmListOfValues_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Escape Then
            pUserAction = "EXIT"
            Me.Hide()
        End If
    End Sub

    Private Sub btnNone_Click(sender As Object, e As EventArgs) Handles btnNone.Click
        drvSearchTable = DirectCast(bsSearchTable.AddNew(), DataRowView)
        bsSearchTable.MoveLast()
        pUserAction = "NONE"
        Me.Close()
    End Sub

    Private Sub dgvSearchTable_KeyDown(sender As Object, e As KeyEventArgs) Handles dgvSearchTable.KeyDown
        If e.KeyCode = Keys.Enter Then
            drvSearchTable = CType(bsSearchTable.Current, DataRowView)
            _UserAction = "OK"
            Me.Close()

        End If
    End Sub
End Class