Imports System.Data.SqlClient
Imports System.Runtime.InteropServices.JavaScript.JSType

Public Class classListOfValue
    Public Function selectColorsList(Optional ByVal pFilterText As String = Nothing, Optional ByVal pSessionId As Nullable(Of Int64) = Nothing, Optional ByVal pSessionUserId As String = Nothing, Optional ByVal pAppConn As SqlConnection = Nothing) As DataTable
        'select FtTypeOfFabric List for Search , combobox
        Dim comm As New SqlCommand("", pAppConn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "dbo.P_LOV_PKG_select_colors_list"
        comm.Parameters.Clear()
        comm.Parameters.AddWithValue("@p_filter_text", pFilterText)
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        pAppConn.Close()
        Return dt
    End Function
    Public Function selectClipInstrLookUpList(Optional ByVal pFilterText As String = Nothing, Optional ByVal pSessionId As Nullable(Of Int64) = Nothing, Optional ByVal pSessionUserId As String = Nothing, Optional ByVal pAppConn As SqlConnection = Nothing) As DataTable
        'select FtTypeOfFabric List for Search , combobox
        Dim comm As New SqlCommand("", pAppConn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "LOV.P_LOV_PKG_select_clip_instr_lookup_list"
        comm.Parameters.Clear()
        comm.Parameters.AddWithValue("@p_filter_text", pFilterText)
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        pAppConn.Close()
        Return dt
    End Function
    Public Function selectItemsList(pFilterText As String, pFilterItemCatCode As String(), pSessionId As Nullable(Of Int64), pSessionUserId As String, pAppConn As SqlConnection) As DataTable
        Dim comm As New SqlCommand("", pAppConn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "dbo.P_LOV_PKG_select_items_list"
        comm.Parameters.Clear()
        comm.Parameters.AddWithValue("@p_filter_text", pFilterText)

        If pFilterItemCatCode IsNot Nothing Then
            Dim stringArray As DataTable = New DataTable()
            stringArray.Columns.Add("Value", GetType(String))
            For Each i In pFilterItemCatCode
                stringArray.Rows.Add(i)
            Next
            Dim parameter As SqlParameter = comm.Parameters.AddWithValue("@p_string_array", stringArray)
            parameter.SqlDbType = SqlDbType.Structured
            parameter.TypeName = "dbo.StringArray"
        End If

        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        pAppConn.Close()
        Return dt
    End Function

    ' test, saharat
    Public Function selectItemsListTest(pFilterText As String, pFilterItemCatCode As String(), pSessionId As Nullable(Of Int64), pSessionUserId As String, pAppConn As SqlConnection) As DataTable
        Dim comm As New SqlCommand("", pAppConn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "LOV.P_LOV_PKG_select_items_list_test_ger"
        comm.Parameters.Clear()
        comm.Parameters.AddWithValue("@p_filter_text", pFilterText)

        If pFilterItemCatCode IsNot Nothing Then
            Dim stringArray As DataTable = New DataTable()
            stringArray.Columns.Add("Value", GetType(String))
            For Each i In pFilterItemCatCode
                stringArray.Rows.Add(i)
            Next
            Dim parameter As SqlParameter = comm.Parameters.AddWithValue("@p_string_array", stringArray)
            parameter.SqlDbType = SqlDbType.Structured
            parameter.TypeName = "dbo.StringArray"
        End If

        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        pAppConn.Close()
        Return dt
    End Function
    Public Function selectSuppliersList(pFilterText As String, pSessionId As Nullable(Of Int64), pSessionUserId As String, pAppConn As SqlConnection) As DataTable
        'select Suppliers List for Search , combobox
        Dim comm As New SqlCommand("", pAppConn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "LOV.P_LOV_PKG_select_suppliers_list"
        comm.Parameters.Clear()
        comm.Parameters.AddWithValue("@p_filter_text", pFilterText)
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        pAppConn.Close()
        Return dt
    End Function
    Public Function selectCustomersList(pFilterText As String, pSessionId As Nullable(Of Int64), pSessionUserId As String, pAppConn As SqlConnection) As DataTable
        'select Suppliers List for Search , combobox
        Dim comm As New SqlCommand("", pAppConn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "LOV.P_LOV_PKG_select_customers_list"
        comm.Parameters.Clear()
        comm.Parameters.AddWithValue("@p_filter_text", pFilterText)
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        pAppConn.Close()
        Return dt
    End Function
    Public Function selectBillToSiteList(pFilterText As String, pSessionId As Nullable(Of Int64), pSessionUserId As String, pAppConn As SqlConnection) As DataTable
        'select Suppliers List for Search , combobox
        Dim comm As New SqlCommand("", pAppConn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "LOV.P_LOV_PKG_select_bill_to_site_list"
        comm.Parameters.Clear()
        comm.Parameters.AddWithValue("@p_filter_text", pFilterText)
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        pAppConn.Close()
        Return dt
    End Function
    Public Function selectShipToSiteList(pFilterText As String, pSessionId As Nullable(Of Int64), pSessionUserId As String, pAppConn As SqlConnection) As DataTable
        'select Suppliers List for Search , combobox
        Dim comm As New SqlCommand("", pAppConn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "LOV.P_LOV_PKG_select_ship_to_site_list"
        comm.Parameters.Clear()
        comm.Parameters.AddWithValue("@p_filter_text", pFilterText)
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        pAppConn.Close()
        Return dt
    End Function
    Public Function selectPieceDyeColorsList(pFilterText As String, pSessionId As Nullable(Of Int64), pSessionUserId As String, pAppConn As SqlConnection) As DataTable
        'select Piece dye colors List for Search , combobox
        Dim comm As New SqlCommand("", pAppConn)
        comm.CommandType = CommandType.StoredProcedure
        'comm.CommandText = "MFG.P_COLORIT_FORM_PKG_select_piece_dye_colors_lookup_list"
        comm.CommandText = "LOV.P_LOV_PKG_select_piece_dye_colors_list"
        comm.Parameters.Clear()
        comm.Parameters.AddWithValue("@p_filter_text", pFilterText)
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        pAppConn.Close()
        Return dt
    End Function

    Public Function selectItemsVariantList(pFilterText As String, pItemId As Nullable(Of Int64), pSessionId As Nullable(Of Int64), pSessionUserId As String, pAppConn As SqlConnection) As DataTable
        'select Items Variant List for Search
        Dim comm As New SqlCommand("", pAppConn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "LOV.P_LOV_PKG_select_items_variant_list"
        comm.Parameters.Clear()
        comm.Parameters.AddWithValue("@p_filter_text", pFilterText)
        comm.Parameters.AddWithValue("@p_item_id", pItemId)
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        pAppConn.Close()
        Return dt
    End Function
    Public Function selectSOList(pFilterText As String, pSessionId As Nullable(Of Int64), pSessionUserId As String, pAppConn As SqlConnection) As DataTable
        'select Suppliers List for Search , combobox
        Dim comm As New SqlCommand("", pAppConn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "LOV.P_LOV_PKG_select_so_list"
        comm.Parameters.Clear()
        comm.Parameters.AddWithValue("@p_filter_text", pFilterText)
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        pAppConn.Close()
        Return dt
    End Function
    Public Function selectSOItmList(pFilterText As String, pSessionId As Nullable(Of Int64), pSessionUserId As String, pAppConn As SqlConnection) As DataTable
        'select Suppliers List for Search , combobox
        Dim comm As New SqlCommand("", pAppConn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "LOV.P_LOV_PKG_select_soitm_list"
        comm.Parameters.Clear()
        comm.Parameters.AddWithValue("@p_filter_text", pFilterText)
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        pAppConn.Close()
        Return dt
    End Function
    Public Function selectSOItmForPoLineList(pFilterText As String, pItcd As String, pSessionId As Nullable(Of Int64), pSessionUserId As String, pAppConn As SqlConnection) As DataTable
        'select Suppliers List for Search , combobox
        Dim comm As New SqlCommand("", pAppConn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "LOV.P_LOV_PKG_select_soitm_for_po_line_list"
        comm.Parameters.Clear()
        comm.Parameters.AddWithValue("@p_filter_text", pFilterText)
        comm.Parameters.AddWithValue("@p_itcd", pItcd)
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        pAppConn.Close()
        Return dt
    End Function
    Public Function selectSOListTest(pFilterText As String, pSessionId As Nullable(Of Int64), pSessionUserId As String, pAppConn As SqlConnection) As DataTable
        'select Suppliers List for Search , combobox
        Dim comm As New SqlCommand("", pAppConn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "LOV.P_LOV_PKG_select_so_list_test"
        comm.Parameters.Clear()
        comm.Parameters.AddWithValue("@p_filter_text", pFilterText)
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        pAppConn.Close()
        Return dt
    End Function
    Public Function selectBanksList(pFilterText As String, pSessionId As Nullable(Of Int64), pSessionUserId As String, pAppConn As SqlConnection) As DataTable
        'select Banks List for Search , combobox
        Dim comm As New SqlCommand("", pAppConn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "LOV.P_LOV_PKG_select_banks_list"
        comm.Parameters.Clear()
        comm.Parameters.AddWithValue("@p_filter_text", pFilterText)
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        pAppConn.Close()
        Return dt
    End Function
    Public Function selectGradesList(pFilterText As String, pItnatureCd As String, pSessionId As Nullable(Of Int64), pSessionUserId As String, pAppConn As SqlConnection) As DataTable
        'select Banks List for Search , combobox
        Dim comm As New SqlCommand("", pAppConn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "LOV.P_LOV_PKG_select_grades_list"
        comm.Parameters.Clear()
        comm.Parameters.AddWithValue("@p_filter_text", pFilterText)
        comm.Parameters.AddWithValue("@p_itnaturcd", pItnatureCd)
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        pAppConn.Close()
        Return dt
    End Function
    Public Function selectMfgBomHeader(pitemId As Nullable(Of Int64), pFilterText As String, pSessionId As Nullable(Of Int64), pSessionUserId As String, pAppConn As SqlConnection) As DataTable
        'select Banks List for Search , combobox
        Dim comm As New SqlCommand("", pAppConn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "LOV.P_LOV_PKG_select_mfg_bom_header_list"
        comm.Parameters.Clear()
        comm.Parameters.AddWithValue("@p_filter_text", pFilterText)
        comm.Parameters.AddWithValue("@p_item_id", pitemId)
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        pAppConn.Close()
        Return dt
    End Function
    Public Function selectColoritList(pitemId As Nullable(Of Int64), pFilterText As String, pSessionId As Nullable(Of Int64), pSessionUserId As String, pAppConn As SqlConnection) As DataTable
        'select Banks List for Search , combobox
        Dim comm As New SqlCommand("", pAppConn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "LOV.P_LOV_PKG_select_colorit_list"
        comm.Parameters.Clear()
        comm.Parameters.AddWithValue("@p_filter_text", pFilterText)
        comm.Parameters.AddWithValue("@p_item_id", pitemId)
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        pAppConn.Close()
        Return dt
    End Function
    Public Function selectMfgBomHeaderList(pFilterText As String, pItemId As Nullable(Of Int64), pItemCode As String, pAppConn As SqlConnection) As DataTable
        Dim comm As New SqlCommand("", pAppConn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "LOV.P_LOV_PKG_select_mfg_bom_header_list_test_ger"
        comm.Parameters.Clear()
        comm.Parameters.AddWithValue("@p_filter_text", pFilterText)
        comm.Parameters.AddWithValue("@p_item_id", pItemId)
        comm.Parameters.AddWithValue("@p_itcd", pItemCode)
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        pAppConn.Close()
        Return dt
    End Function

    Public Function selectMfgRoutingHeader(Optional pFilterText As String = Nothing,
                                           Optional pitemId As Nullable(Of Int64) = Nothing,
                                           Optional pMfgBomHeaderId As Nullable(Of Int64) = Nothing,
                                           Optional pSessionId As Nullable(Of Int64) = Nothing,
                                           Optional pSessionUserId As String = Nothing,
                                           Optional pAppConn As SqlConnection = Nothing) As DataTable
        'select Banks List for Search , combobox
        Dim comm As New SqlCommand("", pAppConn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "LOV.P_LOV_PKG_select_mfg_routing_header_list"
        comm.Parameters.Clear()
        comm.Parameters.AddWithValue("@p_filter_text", pFilterText)
        comm.Parameters.AddWithValue("@p_item_id", pitemId)
        comm.Parameters.AddWithValue("@p_mfg_bom_header_id", pMfgBomHeaderId)
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        pAppConn.Close()
        Return dt
    End Function

    Public Function selectTrnNumber(pFilterText As String, pWarehouseID As Nullable(Of Int64), pTxnTypeCode As String, pSessionId As Nullable(Of Int64), pSessionUserId As String, pAppConn As SqlConnection) As DataTable
        Dim comm As New SqlCommand("", pAppConn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "LOV.P_LOV_PKG_select_txn_number_list"
        comm.Parameters.Clear()
        'comm.Parameters.AddWithValue("@p_warehouse_code", pWarehouseCode)
        comm.Parameters.AddWithValue("@p_filter_text", pFilterText)
        comm.Parameters.AddWithValue("@p_warehouse_id", pWarehouseID)
        comm.Parameters.AddWithValue("@p_txn_type_code", pTxnTypeCode)
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        Return dt
    End Function

    Public Function selectPOHeader(pFilterText As String, pAppConn As SqlConnection) As DataTable
        Dim comm As New SqlCommand("", pAppConn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "LOV.P_LOV_PKG_select_po_header_list"
        comm.Parameters.Clear()
        comm.Parameters.AddWithValue("@p_jobno", pFilterText)
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        Return dt
    End Function
    Public Function selectPOHeaderSubcontract(pFilterText As String, pSupplierId As Nullable(Of Int64), pAppConn As SqlConnection) As DataTable
        Dim comm As New SqlCommand("", pAppConn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "LOV.P_LOV_PKG_select_po_header_sub_contract_list"
        comm.Parameters.Clear()
        comm.Parameters.AddWithValue("@p_filter_text", pFilterText)
        comm.Parameters.AddWithValue("@p_supplier_id", pSupplierId)
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        Return dt
    End Function

    Public Function selectPOLine(pFilterText As String, pShowOnlyLineOpen As String, pSessionId As Nullable(Of Int64), pSessionUserId As String, pAppConn As SqlConnection) As DataTable
        Dim comm As New SqlCommand("", pAppConn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "LOV.P_LOV_PKG_select_po_line_list"
        comm.Parameters.Clear()
        comm.Parameters.AddWithValue("@p_jobno", pFilterText)
        comm.Parameters.AddWithValue("@p_ShowOnlyLineOpen", pShowOnlyLineOpen)
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        Return dt
    End Function
    Public Function selectPOLineSubContract(pPoHeaderId As Nullable(Of Int64), pFilterText As String, pShowOnlyLineOpen As String, pSessionId As Nullable(Of Int64), pSessionUserId As String, pAppConn As SqlConnection) As DataTable
        Dim comm As New SqlCommand("", pAppConn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "LOV.P_LOV_PKG_select_po_line_sub_contract_list"
        comm.Parameters.Clear()
        comm.Parameters.AddWithValue("@p_po_header_id", pPoHeaderId)
        comm.Parameters.AddWithValue("@p_word_filter", pFilterText)
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        Return dt
    End Function

    Public Function selectWarehouse(pFilterText As String, pCompanyID As Nullable(Of Int64), pAppConn As SqlConnection) As DataTable
        Dim comm As New SqlCommand("", pAppConn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "LOV.P_LOV_PKG_select_mtl_warehouse"
        comm.Parameters.Clear()
        comm.Parameters.AddWithValue("@p_filter_text", pFilterText)
        comm.Parameters.AddWithValue("@p_company_id", pCompanyID)
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        Return dt
    End Function

    Public Function selectSubInventory(pFilterText As String, pWarehouseID As Integer, pSessionId As Nullable(Of Int64), pSessionUserId As String, pAppConn As SqlConnection) As DataTable
        Dim comm As New SqlCommand("", pAppConn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "LOV.P_LOV_PKG_select_mtl_subinventory"
        comm.Parameters.Clear()
        comm.Parameters.AddWithValue("@p_filter_text", pFilterText)
        comm.Parameters.AddWithValue("@mtl_warehouse_id", pWarehouseID)
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        Return dt
    End Function

    Public Function selectLocation(pFilterText As String, pWarehouseID As Integer, pSubInventory As Integer, pSessionId As Nullable(Of Int64), pSessionUserId As String, pAppConn As SqlConnection) As DataTable
        Dim comm As New SqlCommand("", pAppConn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "LOV.P_LOV_PKG_select_mtl_locations"
        comm.Parameters.Clear()
        comm.Parameters.AddWithValue("@p_filter_text", pFilterText)
        comm.Parameters.AddWithValue("@mtl_warehouse_id", pWarehouseID)
        comm.Parameters.AddWithValue("@mtl_subinventory_id", pSubInventory)
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        Return dt
    End Function
    Public Function selectUomList(pFilterText As String, pUomClassId As Nullable(Of Int64), pSessionId As Nullable(Of Int64), pSessionUserId As String, pAppConn As SqlConnection) As DataTable
        Dim comm As New SqlCommand("", pAppConn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "LOV.P_LOV_PKG_select_uom_list"
        comm.Parameters.Clear()
        comm.Parameters.AddWithValue("@p_filter_text", pFilterText)
        comm.Parameters.AddWithValue("@p_uom_class_id", pUomClassId)
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        Return dt
    End Function
    Public Function selectUomByClass(pUomClassId As Nullable(Of Int64), pUomCode As String, pSessionId As Nullable(Of Int64), pSessionUserId As String, pAppConn As SqlConnection) As DataTable
        Dim comm As New SqlCommand("", pAppConn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "LOV.P_LOV_PKG_select_uom_by_class"
        comm.Parameters.Clear()
        comm.Parameters.AddWithValue("@p_uom_class_id", pUomClassId)
        comm.Parameters.AddWithValue("@p_uom", pUomCode)
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        Return dt
    End Function

    Public Function selectYarnMakeup(pFilterText As String, pSessionId As Nullable(Of Int64), pSessionUserId As String, pAppConn As SqlConnection) As DataTable
        Dim comm As New SqlCommand("", pAppConn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "LOV.P_LOV_PKG_select_yarn_makeup_lookup_list"
        comm.Parameters.Clear()
        comm.Parameters.AddWithValue("@p_filter_text", pFilterText)
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        Return dt
    End Function

    Public Function selectMTLTranTypeList(pMtlTxnSourceTypeID As Integer, pSessionId As Nullable(Of Int64), pSessionUserId As String, pAppConn As SqlConnection) As DataTable
        Dim comm As New SqlCommand("", pAppConn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "LOV.P_LOV_PKG_select_mtl_txn_type"
        comm.Parameters.Clear()
        comm.Parameters.AddWithValue("@p_mtl_txn_source_type_id", pMtlTxnSourceTypeID)
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        Return dt
    End Function

    Public Function selectMTLTranReasonList(pCompanyID As Integer, pSessionId As Nullable(Of Int64), pSessionUserId As String, pAppConn As SqlConnection) As DataTable
        Dim comm As New SqlCommand("", pAppConn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "LOV.P_LOV_PKG_select_mtl_txn_reason"
        comm.Parameters.Clear()
        comm.Parameters.AddWithValue("@p_company_id", pCompanyID)
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        Return dt
    End Function

    Public Function selectDepartmentList(pSessionId As Nullable(Of Int64), pSessionUserId As String, pAppConn As SqlConnection) As DataTable
        Dim comm As New SqlCommand("", pAppConn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "LOV.P_LOV_PKG_select_dept_list"
        comm.Parameters.Clear()
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        Return dt
    End Function

    Public Function selectEmployeeList(pDepartmentCode As String, pEmployeeCode As String, pSessionId As Nullable(Of Int64), pSessionUserId As String, pAppConn As SqlConnection) As DataTable
        Dim comm As New SqlCommand("", pAppConn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "LOV.P_LOV_PKG_select_employee_list"
        comm.Parameters.Clear()
        comm.Parameters.AddWithValue("@p_deptcd", pDepartmentCode)
        comm.Parameters.AddWithValue("@p_empcd", pEmployeeCode)
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        Return dt
    End Function

    Public Function selectMTLOnhandParentLotNumberList(pItemID As Integer, pSessionId As Nullable(Of Int64), pSessionUserId As String, pAppConn As SqlConnection) As DataTable
        Dim comm As New SqlCommand("", pAppConn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "LOV.P_LOV_PKG_select_mtl_onhand_parent_lot_number_list"
        comm.Parameters.Clear()
        comm.Parameters.AddWithValue("@p_item_id", pItemID)
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        Return dt
    End Function
    Public Function selectOperationPlanFromSoitmList(Optional pFilterText As String = Nothing,
                                        Optional pSoHeaderId As Nullable(Of Int64) = Nothing,
                                        Optional pSessionId As Nullable(Of Int64) = Nothing,
                                        Optional pSessionUserId As String = Nothing,
                                        Optional pAppConn As SqlConnection = Nothing) As DataTable
        'select Banks List for Search , combobox
        Dim comm As New SqlCommand("", pAppConn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "LOV.P_LOV_PKG_select_operation_plan_from_soitm_list"
        comm.Parameters.Clear()
        comm.Parameters.AddWithValue("@p_filter_text", pFilterText)
        comm.Parameters.AddWithValue("@p_so_header_id", pSoHeaderId)
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        pAppConn.Close()
        Return dt
    End Function
    Public Function selectChildProductionOrderList(Optional pFilterText As String = Nothing,
                                        Optional pParentProductionOrderId As Nullable(Of Int64) = Nothing,
                                        Optional pSessionId As Nullable(Of Int64) = Nothing,
                                        Optional pSessionUserId As String = Nothing,
                                        Optional pAppConn As SqlConnection = Nothing) As DataTable
        'select Banks List for Search , combobox
        Dim comm As New SqlCommand("", pAppConn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "LOV.P_LOV_PKG_select_child_production_order_list"
        comm.Parameters.Clear()
        comm.Parameters.AddWithValue("@p_filter_text", pFilterText)
        comm.Parameters.AddWithValue("@p_parent_production_order_id", pParentProductionOrderId)
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        pAppConn.Close()
        Return dt
    End Function
    Public Function selectMachinesList(Optional pFilterText As String = Nothing,
                                       Optional pMtlWarehouseId As Nullable(Of Int64) = Nothing,
                                       Optional pSessionId As Nullable(Of Int64) = Nothing,
                                        Optional pSessionUserId As String = Nothing,
                                       Optional pAppConn As SqlConnection = Nothing) As DataTable
        'select Banks List for Search , combobox
        Dim comm As New SqlCommand("", pAppConn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "LOV.P_LOV_PKG_select_mfg_machines_list"
        comm.Parameters.Clear()
        comm.Parameters.AddWithValue("@p_filter_text", pFilterText)
        comm.Parameters.AddWithValue("@p_mtl_warehouse_id", pMtlWarehouseId)
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        pAppConn.Close()
        Return dt
    End Function
    Public Function selectOperationsList(Optional pFilterText As String = Nothing,
                                       Optional pSessionId As Nullable(Of Int64) = Nothing,
                                       Optional pSessionUserId As String = Nothing,
                                       Optional pAppConn As SqlConnection = Nothing) As DataTable
        'select Banks List for Search , combobox
        Dim comm As New SqlCommand("", pAppConn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "LOV.P_LOV_PKG_select_mfg_operations_list"
        comm.Parameters.Clear()
        comm.Parameters.AddWithValue("@p_filter_text", pFilterText)
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        pAppConn.Close()
        Return dt
    End Function
    'Public Function selectStockOnhandList(pMTLWarehouseCd As String,
    '                                      pMtlSubinventoryCode As String,
    '                                      pMtlLocatonName As String,
    '                                      pItemCode As String,
    '                                      pSessionId As Nullable(Of Int64), pSessionUserId As String, pAppConn As SqlConnection) As DataTable
    '    Dim comm As New SqlCommand("", pAppConn)
    '    comm.CommandType = CommandType.StoredProcedure
    '    comm.CommandText = "LOV.P_LOV_PKG_select_stock_onhand_list"
    '    comm.Parameters.Clear()
    '    comm.Parameters.Clear()
    '    comm.Parameters.AddWithValue("@p_warehouse_code", pMTLWarehouseCd.Trim)
    '    comm.Parameters.AddWithValue("@p_subinventory_code", pMtlSubinventoryCode.Trim)
    '    comm.Parameters.AddWithValue("@p_location_name", pMtlLocatonName.Trim)
    '    comm.Parameters.AddWithValue("@p_item_code", pItemCode.Trim)
    '    comm.Parameters.AddWithValue("@p_item_name", "")
    '    comm.Parameters.AddWithValue("@p_date_type", 0) 'RealTime
    '    comm.Parameters.AddWithValue("@p_show_before_date", DBNull.Value) 'RealTime
    '    comm.Parameters.AddWithValue("@p_show_value", "Y") 'RealTime
    '    comm.Parameters.AddWithValue("@p_exclude_subcontract", "N") 'RealTime
    '    comm.Parameters.AddWithValue("@p_show_detail", "Y") 'RealTime

    '    Dim da As New SqlDataAdapter(comm)
    '    Dim dt As New DataTable
    '    da.Fill(dt)
    '    Return dt
    'End Function

    Public Function selectARPaymentTermsList(pFilterText As String, pSessionId As Nullable(Of Int64), pSessionUserId As String, pAppConn As SqlConnection) As DataTable
        Dim comm As New SqlCommand("", pAppConn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "LOV.P_LOV_PKG_select_ar_payment_term_list"
        comm.Parameters.Clear()
        comm.Parameters.AddWithValue("@p_filter_text", pFilterText)
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        Return dt
    End Function
    Public Function selectAPPaymentTermsList(pFilterText As String, pSessionId As Nullable(Of Int64), pSessionUserId As String, pAppConn As SqlConnection) As DataTable
        Dim comm As New SqlCommand("", pAppConn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "LOV.P_LOV_PKG_select_ap_payment_term_list"
        comm.Parameters.Clear()
        comm.Parameters.AddWithValue("@p_filter_text", pFilterText)
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        Return dt
    End Function
    Public Function selectDeliveryHeaderList(pFilterText As String, pSessionId As Nullable(Of Int64), pSessionUserId As String, pAppConn As SqlConnection) As DataTable
        Dim comm As New SqlCommand("", pAppConn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "LOV.P_LOV_PKG_select_delivery_header_list"
        comm.Parameters.Clear()
        comm.Parameters.AddWithValue("@p_filter_text", pFilterText)
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        Return dt
    End Function

    Public Function selectDyeJobNoList(pFilterText As String, pAppConn As SqlConnection) As DataTable
        Dim comm As New SqlCommand("", pAppConn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "LOV.P_LOV_PKG_select_dye_job_no_list"
        comm.Parameters.Clear()
        comm.Parameters.AddWithValue("@p_filter_text", pFilterText)
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        Return dt
    End Function

    Public Function selectOrderSetList(pFilterText As String, pAppConn As SqlConnection) As DataTable
        Dim comm As New SqlCommand("", pAppConn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "LOV.P_LOV_PKG_select_order_set_list"
        comm.Parameters.Clear()
        comm.Parameters.AddWithValue("@p_filter_text", pFilterText)
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        Return dt
    End Function
    Public Function selectStepNumberList(Optional pFilterText As String = Nothing,
                                    Optional pSetNo As String = Nothing,
                                    Optional pSessionId As Nullable(Of Int64) = Nothing,
                                    Optional pSessionUserId As String = Nothing,
                                    Optional pAppConn As SqlConnection = Nothing) As DataTable
        'select Step Number List for Search , combobox
        Dim comm As New SqlCommand("", pAppConn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "LOV.P_LOV_PKG_select_step_number_list"
        comm.Parameters.Clear()
        comm.Parameters.AddWithValue("@p_filter_text", pFilterText)
        comm.Parameters.AddWithValue("@p_set_no", pSetNo)
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        pAppConn.Close()
        Return dt
    End Function
    Public Function selectSetList(pFilterText As String, pSessionId As Nullable(Of Int64), pSessionUserId As String, pAppConn As SqlConnection) As DataTable
        Dim comm As New SqlCommand("", pAppConn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "LOV.P_LOV_PKG_select_set_list"
        comm.Parameters.Clear()
        comm.Parameters.AddWithValue("@p_filter_text", pFilterText)
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        Return dt
    End Function
    Public Function selectSetListUpStepStitch(pFilterText As String, pSessionId As Nullable(Of Int64), pSessionUserId As String, pAppConn As SqlConnection) As DataTable '13/09/2024 John
        Dim comm As New SqlCommand("", pAppConn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "[LOV].[P_LOV_PKG_select_set_list_upstep_stitch]"
        comm.Parameters.Clear()
        comm.Parameters.AddWithValue("@p_filter_text", pFilterText)
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        Return dt
    End Function
    Public Function selectTransferSubcontractList(pFilterText As String, pSessionId As Nullable(Of Int64), pSessionUserId As String, pAppConn As SqlConnection) As DataTable
        Dim comm As New SqlCommand("", pAppConn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "LOV.P_LOV_PKG_select_transfer_subcontract_list"
        comm.Parameters.Clear()
        comm.Parameters.AddWithValue("@p_filter_text", pFilterText)
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        Return dt
    End Function
    Public Function selectTransferWHList(pFilterText As String, pSessionId As Nullable(Of Int64), pSessionUserId As String, pAppConn As SqlConnection) As DataTable
        Dim comm As New SqlCommand("", pAppConn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "LOV.P_LOV_PKG_select_transfer_wh_list"
        comm.Parameters.Clear()
        comm.Parameters.AddWithValue("@p_filter_text", pFilterText)
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        Return dt
    End Function
    Public Function selectTransferLocationList(pFilterText As String, pSessionId As Nullable(Of Int64), pSessionUserId As String, pAppConn As SqlConnection) As DataTable
        Dim comm As New SqlCommand("", pAppConn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "LOV.P_LOV_PKG_select_transfer_location_list"
        comm.Parameters.Clear()
        comm.Parameters.AddWithValue("@p_filter_text", pFilterText)
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        Return dt
    End Function
    Public Function selectShipVia(pFilterText As String, pSessionId As Nullable(Of Int64), pSessionUserId As String, pAppConn As SqlConnection) As DataTable
        Dim comm As New SqlCommand("", pAppConn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "[LOV].[P_LOV_PKG_select_ship_via_lookup_list]"
        comm.Parameters.Clear()
        comm.Parameters.AddWithValue("@p_filter_text", pFilterText)
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        Return dt
    End Function
    Public Function selectProductionHeaderList(pFilterText As String, pProductionOrderTypeId As Nullable(Of Int64), pSessionId As Nullable(Of Int64), pSessionUserId As String, pAppConn As SqlConnection) As DataTable
        Dim comm As New SqlCommand("", pAppConn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "LOV.P_LOV_PKG_select_production_order_list"
        comm.Parameters.Clear()
        comm.Parameters.AddWithValue("@p_filter_text", pFilterText)
        comm.Parameters.AddWithValue("@p_production_order_type_id", pProductionOrderTypeId)
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        Return dt
    End Function
    Public Function selectProductLineList(pFilterText As String, pAppConn As SqlConnection) As DataTable
        Dim comm As New SqlCommand("", pAppConn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "LOV.P_LOV_PKG_select_product_line_list"
        comm.Parameters.Clear()
        comm.Parameters.AddWithValue("@p_filter_text", pFilterText)
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        Return dt
    End Function
    Public Function selectMateriaLineList(pFilterText As String, pAppConn As SqlConnection) As DataTable
        Dim comm As New SqlCommand("", pAppConn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "LOV.P_LOV_PKG_select_material_line_list"
        comm.Parameters.Clear()
        comm.Parameters.AddWithValue("@p_filter_text", pFilterText)
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        Return dt
    End Function
    Public Function selectSalesPersonList(pFilterText As String, pAppConn As SqlConnection) As DataTable
        Dim comm As New SqlCommand("", pAppConn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "[LOV].[P_LOV_PKG_select_so_saleperson_list]"
        comm.Parameters.Clear()
        comm.Parameters.AddWithValue("@p_filter_text", pFilterText)
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        Return dt
    End Function
    Public Function selectCodeLeftRightLookupList(pFilterText As String, pAppConn As SqlConnection) As DataTable
        Dim comm As New SqlCommand("", pAppConn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "LOV.P_LOV_PKG_select_code_left_right_lookup_list"
        comm.Parameters.Clear()
        comm.Parameters.AddWithValue("@p_filter_text", pFilterText)
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        Return dt
    End Function
    Public Function selectArInvoiceHeaderList(pFilterText As String, pAppConn As SqlConnection) As DataTable
        Dim comm As New SqlCommand("", pAppConn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "LOV.P_LOV_PKG_select_ar_invoice_header_list"
        comm.Parameters.Clear()
        comm.Parameters.AddWithValue("@p_filter_text", pFilterText)
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        Return dt
    End Function
    Public Function selectCalcHeaderList(pFilterText As String, pAppConn As SqlConnection) As DataTable '20/08/2024 John
        Dim comm As New SqlCommand("", pAppConn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "[LOV].[P_LOV_PKG_select_calc_header_list]"
        comm.Parameters.Clear()
        comm.Parameters.AddWithValue("@p_filter_text", pFilterText)
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        Return dt
    End Function
    Public Function selectEfficiency(pFilterText As String, pSessionId As Nullable(Of Int64), pSessionUserId As String, pAppConn As SqlConnection) As DataTable '29/08/2024 John
        Dim comm As New SqlCommand("", pAppConn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "[LOV].[P_LOV_PKG_select_efficiency_lookup_list]"
        comm.Parameters.Clear()
        comm.Parameters.AddWithValue("@p_filter_text", pFilterText)
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        Return dt
    End Function
    Public Function selectTariffHeaderList(pFilterText As String, pTariffType As String, pAppConn As SqlConnection) As DataTable '30/08/2024 John
        Dim comm As New SqlCommand("", pAppConn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "[LOV].[P_LOV_PKG_PKG_select_tariff_header_list]"
        comm.Parameters.Clear()
        comm.Parameters.AddWithValue("@p_filter_text", pFilterText)
        comm.Parameters.AddWithValue("@p_tariff_type", pTariffType)
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        Return dt
    End Function
    Public Function selectTariffLineList(pFilterText As String, pAppConn As SqlConnection) As DataTable '30/08/2024 John
        Dim comm As New SqlCommand("", pAppConn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "[LOV].[P_LOV_PKG_PKG_select_tariff_line_list]"
        comm.Parameters.Clear()
        comm.Parameters.AddWithValue("@p_filter_text", pFilterText)
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        Return dt
    End Function
    Public Function selectCalcBomHeaderList(pFilterText As String, pItemId As Nullable(Of Int64), pItemCode As String, pAppConn As SqlConnection) As DataTable
        Dim comm As New SqlCommand("", pAppConn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "[LOV].[P_LOV_PKG_select_calc_bom_header_list]"
        comm.Parameters.Clear()
        comm.Parameters.AddWithValue("@p_filter_text", pFilterText)
        comm.Parameters.AddWithValue("@p_item_id", pItemId)
        comm.Parameters.AddWithValue("@p_itcd", pItemCode)
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        pAppConn.Close()
        Return dt
    End Function
    Public Function selectCustomerItemsXrefList(pFilterText As String, pCustcd As String, pItemId As Nullable(Of Int64), pItemCode As String, pAppConn As SqlConnection) As DataTable
        Dim comm As New SqlCommand("", pAppConn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "LOV.P_LOV_PKG_select_mtl_customer_items_xref_list"
        comm.Parameters.Clear()
        comm.Parameters.AddWithValue("@p_filter_text", pFilterText)
        comm.Parameters.AddWithValue("@p_custcd", pCustcd)
        comm.Parameters.AddWithValue("@p_item_id", pItemId)
        comm.Parameters.AddWithValue("@p_itcd", pItemCode)
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        pAppConn.Close()
        Return dt
    End Function
End Class
