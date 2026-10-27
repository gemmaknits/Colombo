Imports System.Data
Imports System.Data.SqlClient
Imports System.Text
Public Class classPurchaseNewEdit
    Private connStr As New classConnection
    Private clsConnection As New classConnection
    Public Function ValidateItcd(Optional ByVal StrItcd As String = "") As Boolean
        Dim conn As New SqlConnection((New classConnection).connection)
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "P_PO_PKG_validate_itcd"
        comm.Parameters.Clear()
        comm.Parameters.AddWithValue("@itcd", StrItcd)
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        conn.Close()  'Sitthana 20190325
        Dim result As Boolean = True
        If dt.Rows.Count > 0 Then
            result = True
        Else
            result = False
        End If
        Return result
    End Function

    Public Function GetItcdAutocomplete() As DataTable
        Dim conn As New SqlConnection(clsConnection.connection)
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "P_PO_PKG_get_itcd_autocomplete"
        comm.Parameters.Clear()
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        conn.Close()
        Return dt
    End Function
    Public Function GetCrTermAutocomplete() As DataTable
        Dim conn As New SqlConnection(clsConnection.connection)
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "P_PO_PKG_get_crterm_autocomplete"
        comm.Parameters.Clear()
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        conn.Close()
        Return dt
    End Function

    Public Function GetJob(ByVal _jobno As String) As DataTable
        Dim conn As New SqlConnection(clsConnection.connection)
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "P_PO_PKG_select_job"
        comm.Parameters.Clear()
        comm.Parameters.AddWithValue("@jobno", _jobno)
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        conn.Close()
        Return dt
    End Function

    Public Function GetJobDet(ByVal _jobno As String) As DataTable
        Dim conn As New SqlConnection(clsConnection.connection)
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "P_PO_PKG_select_job_det"
        comm.Parameters.Clear()
        comm.Parameters.AddWithValue("@jobno", _jobno)
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        conn.Close()
        Return dt
    End Function

    Public Function GetExchageRate(ByVal currency As String) As Decimal
        ' Dim pExchangeRate As Decimal = 0.0000
        Dim conn As New SqlConnection(clsConnection.connection)
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "P_PO_PKG_get_exchange_rate"
        comm.Parameters.Clear()
        comm.Parameters.AddWithValue("@curr_fr", currency)
        comm.Parameters.Add("@p_exchange_rate", SqlDbType.NVarChar, 10, 4)
        comm.Parameters("@p_exchange_rate").Direction = ParameterDirection.Output
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        conn.Close()
        GetExchageRate = (New clsConfig).IsNull(comm.Parameters("@p_exchange_rate").Value, 0)
        Return GetExchageRate
    End Function

    Public Function GetPoItemFromSoitm(ByVal _sono As String) As DataTable
        Dim conn As New SqlConnection(clsConnection.connection)
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "P_PO_PKG_get_job_det_from_soitm"
        comm.Parameters.Clear()
        comm.Parameters.AddWithValue("@sono", _sono)
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        conn.Close()
        Return dt
    End Function


    Public Function SavePurchaseOrder(ByRef drvJob As DataRowView, ByRef dtJobDet As DataTable, ByRef msgerr As String, ByVal loginEmpcd As String) As Boolean
        Dim conn As New SqlConnection(clsConnection.connection())
        Dim comm As New SqlCommand("", conn)
        conn.Open()
        Dim tran As SqlTransaction = conn.BeginTransaction
        comm.Transaction = tran
        comm.CommandType = Data.CommandType.StoredProcedure
        comm.CommandText = "P_PO_PKG_update_job"
        With drvJob
            comm.Parameters.Clear()
            comm.Parameters.AddWithValue("@jobno", .Item("jobno"))
            comm.Parameters.AddWithValue("@jobdt", .Item("jobdt"))
            comm.Parameters.AddWithValue("@suppcd", .Item("suppcd"))
            comm.Parameters.AddWithValue("@supquoteno", .Item("supquoteno"))
            comm.Parameters.AddWithValue("@sourcedocno", .Item("sourcedocno"))
            comm.Parameters.AddWithValue("@supplang", .Item("supplang"))
            comm.Parameters.AddWithValue("@empcd", .Item("empcd"))
            comm.Parameters.AddWithValue("@deptcd", .Item("deptcd"))
            comm.Parameters.AddWithValue("@reqno", .Item("reqno"))
            comm.Parameters.AddWithValue("@delidays", .Item("delidays"))
            comm.Parameters.AddWithValue("@delidt", .Item("delidt"))
            comm.Parameters.AddWithValue("@crterm", .Item("crterm"))
            comm.Parameters.AddWithValue("@crdays", .Item("crdays"))
            comm.Parameters.AddWithValue("@crdesc", .Item("crdesc"))
            comm.Parameters.AddWithValue("@paymodecd", .Item("paymodecd"))
            comm.Parameters.AddWithValue("@shipvia", .Item("shipvia"))
            comm.Parameters.AddWithValue("@splins", .Item("splins"))
            comm.Parameters.AddWithValue("@rem", .Item("rem"))
            comm.Parameters.AddWithValue("@import", .Item("import"))
            comm.Parameters.AddWithValue("@curr", .Item("curr"))
            comm.Parameters.AddWithValue("@exrt", .Item("exrt"))
            comm.Parameters.AddWithValue("@discper", drvJob.Item("discper"))
            comm.Parameters.AddWithValue("@discamt", drvJob.Item("discamt"))
            comm.Parameters.AddWithValue("@vat", drvJob.Item("vat"))
            comm.Parameters.AddWithValue("@shipterms", .Item("shipterms"))
            comm.Parameters.AddWithValue("@deliaddr", .Item("deliaddr"))

            comm.Parameters.AddWithValue("@itnaturecd", .Item("itnaturecd"))

            comm.Parameters.AddWithValue("@benefit", .Item("benefit"))
            comm.Parameters.AddWithValue("@approve_period", .Item("approve_period"))
            comm.Parameters.AddWithValue("@vehicle_name", .Item("vehicle_name"))
            comm.Parameters.AddWithValue("@port_name", .Item("port_name"))
            comm.Parameters.AddWithValue("@agency_name", .Item("agency_name"))
            comm.Parameters.AddWithValue("@benefit_amount", .Item("benefit_amount"))

            comm.Parameters.AddWithValue("@payment_term", .Item("payment_term"))
            comm.Parameters.AddWithValue("@lc_no", .Item("lc_no"))
            comm.Parameters.AddWithValue("@lc_date", .Item("lc_date"))
            comm.Parameters.AddWithValue("@quotation_no", .Item("quotation_no"))
            comm.Parameters.AddWithValue("@quotation_date", .Item("quotation_date"))

            comm.Parameters.AddWithValue("@packing_no", .Item("packing_no"))
            comm.Parameters.AddWithValue("@invoice_no", .Item("invoice_no"))
            comm.Parameters.AddWithValue("@bl_no", .Item("bl_no"))
            comm.Parameters.AddWithValue("@estimate_departure", .Item("estimate_departure"))
            comm.Parameters.AddWithValue("@estimate_arrival", .Item("estimate_arrival"))
            comm.Parameters.AddWithValue("@packing_remark", .Item("packing_remark"))
            comm.Parameters.AddWithValue("@benefit_kgs", .Item("benefit_kgs"))

            comm.Parameters.AddWithValue("@packing_date", .Item("packing_date"))
            comm.Parameters.AddWithValue("@invoice_date", .Item("invoice_date"))
            comm.Parameters.AddWithValue("@bl_date", .Item("bl_date"))
            comm.Parameters.AddWithValue("@awb_no", .Item("awb_no"))
            comm.Parameters.AddWithValue("@awb_date", .Item("awb_date"))
            comm.Parameters.AddWithValue("@awb_received_date", .Item("awb_received_date"))
            comm.Parameters.AddWithValue("@rcv_warehouse_id", .Item("rcv_warehouse_id"))

            comm.Parameters.AddWithValue("@p_forwarder_id", .Item("forwarder_id"))
            comm.Parameters.AddWithValue("@p_ship_via_id", .Item("ship_via_id"))
            comm.Parameters.AddWithValue("@p_ap_payment_term_id", .Item("ap_payment_term_id"))
            comm.Parameters.AddWithValue("@p_inco_term_id", .Item("inco_term_id"))
            comm.Parameters.AddWithValue("@p_freight", .Item("freight"))
            comm.Parameters.AddWithValue("@p_validate_qty_cone_yn", .Item("validate_qty_cone_yn"))
            comm.Parameters.AddWithValue("@p_email_to", .Item("email_to"))
            comm.Parameters.AddWithValue("@p_email_cc", .Item("email_cc"))
            comm.Parameters.AddWithValue("@log_empcd", loginEmpcd.Trim)
        End With

        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        Try
            da.Fill(dt)
        Catch ex As Exception
            msgerr = ex.Message
            tran.Rollback()
            conn.Close()
            Return False
        End Try

        drvJob.Row("jobno") = dt.Rows(0)("jobno").ToString.Trim

        Dim dv_add As New DataView(dtJobDet, "", "", DataViewRowState.Added)
        Dim dv_upd As New DataView(dtJobDet, "", "", DataViewRowState.ModifiedCurrent)
        Dim dv_del As New DataView(dtJobDet, "", "", DataViewRowState.Deleted)

        For i = 0 To dv_del.Count - 1
            With dv_del(i)
                comm.CommandText = "P_PO_PKG_delete_job_det"
                comm.Parameters.Clear()
                comm.Parameters.AddWithValue("@id_jobdet", .Item("id_jobdet"))
                comm.Parameters.AddWithValue("@log_empcd", loginEmpcd)
            End With
            da = New SqlDataAdapter(comm)
            dt = New DataTable
            Try
                da.Fill(dt)
            Catch ex As Exception
                msgerr = ex.Message
                tran.Rollback()
                conn.Close()  'Sitthana 20190325
                Return False
            End Try
        Next


        For i = 0 To dv_del.Count - 1
            With dv_del(i)
                comm.CommandText = "P_PO_PKG_delete_po_shipment_step"
                comm.Parameters.Clear()
                comm.Parameters.AddWithValue("@p_po_line_id", .Item("id_jobdet"))
                comm.Parameters.AddWithValue("@log_empcd", loginEmpcd)
            End With
            da = New SqlDataAdapter(comm)
            dt = New DataTable
            Try
                da.Fill(dt)
            Catch ex As Exception
                msgerr = ex.Message
                tran.Rollback()
                conn.Close()  'Sitthana 20190325
                Return False
            End Try
        Next


        For Each dr As DataRow In dtJobDet.Rows
            If dr.RowState <> DataRowState.Deleted Then
                comm.CommandText = "P_PO_PKG_update_job_det "
                comm.Parameters.Clear()
                comm.Parameters.AddWithValue("@id_jobdet", dr("id_jobdet"))
                comm.Parameters.AddWithValue("@jobno", drvJob.Row("jobno"))
                comm.Parameters.AddWithValue("@itcd", dr("itcd"))
                comm.Parameters.AddWithValue("@itdesc", dr("itdesc"))
                comm.Parameters.AddWithValue("@qty", dr("qty"))
                comm.Parameters.AddWithValue("@uom_id", dr("uom_id"))
                comm.Parameters.AddWithValue("@uom", dr("uom"))
                comm.Parameters.AddWithValue("@qty2", dr("qty2"))
                comm.Parameters.AddWithValue("@uom2_id", dr("uom2_id"))
                comm.Parameters.AddWithValue("@price", dr("price"))
                comm.Parameters.AddWithValue("@discper", dr("discper"))
                comm.Parameters.AddWithValue("@discamt", dr("discamt")) 'Sitthana 20250128
                comm.Parameters.AddWithValue("@rem", dr("rem"))
                comm.Parameters.AddWithValue("@sono", dr("sono"))
                comm.Parameters.AddWithValue("@sonoid", dr("sonoid"))
                comm.Parameters.AddWithValue("@suppitcd", dr("suppitcd"))
                comm.Parameters.AddWithValue("@delidt", dr("delidt"))
                comm.Parameters.AddWithValue("@supquoteno", dr("supquoteno"))
                comm.Parameters.AddWithValue("@mfg_production_order_line_id", dr("mfg_production_order_line_id"))
                comm.Parameters.AddWithValue("@freight_per_unit", dr("freight_per_unit"))
                comm.Parameters.AddWithValue("@item_unit_price", dr("item_unit_price"))
                comm.Parameters.AddWithValue("@effective_date", dr("effective_date"))
                comm.Parameters.AddWithValue("@rcv_warehouse_id", dr("rcv_warehouse_id"))
                comm.Parameters.AddWithValue("@rcv_subinventory_id", dr("rcv_subinventory_id"))
                comm.Parameters.AddWithValue("@po_line_types_id", drvJob.Row("po_line_types_id"))
                comm.Parameters.AddWithValue("@recycle_trans_report_rcvd_flag", dr("recycle_trans_report_rcvd_flag"))
                comm.Parameters.AddWithValue("@supplier_spec_rcvd_flag", dr("supplier_spec_rcvd_flag"))
                comm.Parameters.AddWithValue("@log_empcd", loginEmpcd)

                da = New SqlDataAdapter(comm)
                dt = New DataTable
                Try
                    da.Fill(dt)
                    dr("id_jobdet") = dt.Rows(0)("id_jobdet")
                Catch ex As Exception
                    msgerr = ex.Message
                    tran.Rollback()
                    conn.Close()
                    Return False
                End Try

                'Create po_shipment_step
                comm.CommandText = "P_PO_PKG_create_po_shipment_step"
                comm.Parameters.Clear()
                comm.Parameters.AddWithValue("@p_po_line_id", dr("id_jobdet"))
                comm.Parameters.AddWithValue("@log_empcd", loginEmpcd)
                da = New SqlDataAdapter(comm)
                dt = New DataTable
                Try
                    da.Fill(dt)
                Catch ex As Exception
                    msgerr = ex.Message
                    tran.Rollback()
                    conn.Close()
                    Return False
                End Try
            End If
        Next

        comm.CommandText = "P_PO_PKG_recalc_amt"
        With drvJob
            comm.Parameters.Clear()
            comm.Parameters.AddWithValue("@jobno", .Row("jobno"))
            comm.Parameters.AddWithValue("@log_empcd", loginEmpcd.Trim)

            da = New SqlDataAdapter(comm)
            dt = New DataTable
            Try
                da.Fill(dt)
            Catch ex As Exception
                msgerr = ex.Message
                tran.Rollback()
                conn.Close()
                Return False
            End Try
        End With

        comm.CommandText = "log_job"
        With drvJob
            comm.Parameters.Clear()
            comm.Parameters.AddWithValue("@empcd", loginEmpcd.Trim)
            comm.Parameters.AddWithValue("@docno", .Row("jobno"))
            comm.Parameters.AddWithValue("@action", "UPD")

            da = New SqlDataAdapter(comm)
            dt = New DataTable
            Try
                da.Fill(dt)
            Catch ex As Exception
                msgerr = ex.Message
                tran.Rollback()
                conn.Close()
                Return False
            End Try
        End With

        tran.Commit()
        comm.Connection.Close()
        comm.Dispose()
        If conn.State = ConnectionState.Open Then conn.Dispose()
        conn.Dispose()
        Return True
    End Function

    Public Function ApprovePurchaseOrder(ByVal Purno As String, ByVal rem_app As String, ByRef msgerr As String, ByVal loginEmpcd As String) As Boolean
        Dim conn As New SqlConnection(clsConnection.connection())
        Dim comm As New SqlCommand("", conn)

        conn.Open()
        Dim tran As SqlTransaction = conn.BeginTransaction

        comm.Transaction = tran
        comm.CommandType = Data.CommandType.StoredProcedure
        comm.CommandText = "P_PO_PKG_approve"
        comm.Parameters.Clear()
        comm.Parameters.AddWithValue("@jobno", Purno.Trim)
        comm.Parameters.AddWithValue("@rem_app", rem_app.Trim)
        comm.Parameters.AddWithValue("@log_empcd", loginEmpcd.Trim)

        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable

        Try
            da.Fill(dt)
        Catch ex As Exception
            msgerr = ex.Message
            tran.Rollback()
            conn.Close()
            Return False
        End Try

        tran.Commit()
        conn.Close()
        Return True
    End Function
    Public Function CancelPurchaseOrder(ByVal Purno As String, ByVal rem_cancel As String, ByRef msgerr As String, ByVal loginEmpcd As String) As Boolean
        Dim conn As New SqlConnection(clsConnection.connection())
        Dim comm As New SqlCommand("", conn)

        conn.Open()
        Dim tran As SqlTransaction = conn.BeginTransaction

        comm.Transaction = tran
        comm.CommandType = Data.CommandType.StoredProcedure
        comm.CommandText = "P_PO_PKG_cancel"
        comm.Parameters.Clear()
        comm.Parameters.AddWithValue("@jobno", Purno.Trim)
        comm.Parameters.AddWithValue("@rem_cancel", rem_cancel.Trim)
        comm.Parameters.AddWithValue("@log_empcd", loginEmpcd.Trim)

        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable

        Try
            da.Fill(dt)
        Catch ex As Exception
            msgerr = ex.Message
            tran.Rollback()
            conn.Close()  'Sitthana 20190325
            Return False
        End Try

        tran.Commit()
        conn.Close()  'Sitthana 20190325
        Return True
    End Function

    Public Function ClosePurchaseOrder(ByVal Purno As String, ByVal rem_app As String, ByRef msgerr As String, ByVal loginEmpcd As String) As Boolean
        Dim conn As New SqlConnection(clsConnection.connection())
        Dim comm As New SqlCommand("", conn)

        conn.Open()
        Dim tran As SqlTransaction = conn.BeginTransaction

        comm.Transaction = tran
        comm.CommandType = Data.CommandType.StoredProcedure
        comm.CommandText = "P_PO_PKG_close"
        comm.Parameters.Clear()
        comm.Parameters.AddWithValue("@jobno", Purno.Trim)
        'comm.Parameters.AddWithValue("@rem_app", rem_app.Trim)
        comm.Parameters.AddWithValue("@log_empcd", loginEmpcd.Trim)

        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable

        Try
            da.Fill(dt)
        Catch ex As Exception
            msgerr = ex.Message
            tran.Rollback()
            conn.Close()
            Return False
        End Try

        tran.Commit()
        conn.Close()
        Return True
    End Function
    Public Function GetMtlWareHouseCode(ByVal pRcvWarehouseId As Int64) As String
        Dim conn As New SqlConnection(clsConnection.connection)
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "P_PO_PKG_get_warehouse_code"
        comm.Parameters.Clear()
        comm.Parameters.AddWithValue("@rcv_warehouse_id", pRcvWarehouseId)
        comm.Parameters.Add("@p_warehouse_code", SqlDbType.Char, 20)
        comm.Parameters("@p_warehouse_code").Direction = ParameterDirection.Output
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        conn.Close()
        Dim _Warehouse As String = ""
        _Warehouse = (New clsConfig).IsNull(comm.Parameters("@p_warehouse_code").Value, 0)
        Return _Warehouse
    End Function
    Public Function GetDefaultDeliaddr(ByVal ploginEmpcd As String) As String
        Dim conn As New SqlConnection(clsConnection.connection)
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "P_PO_PKG_get_default_deliaddr"
        comm.Parameters.Clear()
        comm.Parameters.AddWithValue("@p_logempcd", ploginEmpcd)
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        conn.Close()
        Dim pDeliaddr As String = ""
        If dt.Rows.Count > 0 Then
            pDeliaddr = dt.Rows(0)("deliaddr")
        End If
        Return pDeliaddr
    End Function
    Public Function GetDataVItem(pItcd As String) As DataTable
        Dim conn As New SqlConnection(connStr.connection())
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "P_PO_PKG_get_v_items_des_mc_by_itcd"
        comm.Parameters.Clear()
        comm.Parameters.AddWithValue("@p_itcd", pItcd)
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        conn.Close()  'Sitthana 20190325
        Return dt
    End Function
    'Neung 13/08/2024 copy from APY,GDM
    Public Function GetDeliaddrFromMtlWarehouse(ByVal pMtlwarehouseID As Nullable(Of Int64)) As String
        Dim conn As New SqlConnection(clsConnection.connection)
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "P_PO_PKG_get_deliaddr_from_mtl_warehouse"
        comm.Parameters.Clear()
        comm.Parameters.AddWithValue("@p_mtl_warehouse_id", pMtlwarehouseID)
        comm.Parameters.Add("@p_deliaddr", SqlDbType.NVarChar, 200, 4)
        comm.Parameters("@p_deliaddr").Direction = ParameterDirection.Output
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        conn.Close()
        'Dim pDeliaddr As String = ""
        GetDeliaddrFromMtlWarehouse = (New clsConfig).IsNull(comm.Parameters("@p_deliaddr").Value, "")
        Return GetDeliaddrFromMtlWarehouse
    End Function
    'saharat 20230905
    Public Function GetPrimaryQty(Optional ByVal pItemId As Int64 = 0,
                                  Optional ByVal pQty As Decimal = 0,
                                  Optional ByVal pUomIdFrom As Nullable(Of Int64) = Nothing,
                                  Optional ByVal pUomIdTo As Nullable(Of Int64) = Nothing) As Decimal
        Dim conn As New SqlConnection((New classConnection).connection)
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "P_PO_PKG_get_primary_qty"
        comm.Parameters.Clear()
        comm.Parameters.AddWithValue("@p_item_id", pItemId)
        comm.Parameters.AddWithValue("@p_qty", pQty)
        comm.Parameters.AddWithValue("@p_uom_id_from", pUomIdFrom)
        comm.Parameters.AddWithValue("@p_uom_id_to", pUomIdTo)
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable

        'da.Fill(dt)
        'conn.Close()
        'Return dt.Rows(0)("primary_qty")

        Try
            da.Fill(dt)
            conn.Close()
            Return dt.Rows(0)("primary_qty") 'dt.Rows(0)("po_qty")
        Catch ex As Exception
            MessageBox.Show(ex.Message, "System Message", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
            Return 0
        End Try

    End Function
    'saharat 20230905
    Function GetPrimaryUomItem(pItemId As Int64) As Int64
        Dim conn As New SqlConnection((New classConnection).connection)
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "P_PO_PKG_get_primary_uom_item"
        comm.Parameters.Clear()
        comm.Parameters.AddWithValue("@p_item_id", pItemId)
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        Try
            da.Fill(dt)
            conn.Close()
            Return dt.Rows(0)("uom_id")
        Catch ex As Exception
            MessageBox.Show(ex.Message, "System Message", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
            Return 0
        End Try
    End Function
    Public Function selectUomList() As DataTable
        Dim conn As New SqlConnection(clsConnection.connection)
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "P_PO_PKG_select_uom_list"
        comm.Parameters.Clear()
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        conn.Close()
        Return dt
    End Function
End Class
