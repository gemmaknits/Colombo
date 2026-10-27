Imports System.Data
Imports System.Data.SqlClient
Imports System.Text

Public Class classPurchase


    'Private ds As New DataSet
    'Private Clsconfig As New clsConfig
    Private connStr As New classConnection

    Public Structure PurchaseHeader
        Dim h01_itnaturecd As String
        Dim h02_delidt As String
        Dim h03_splins As String
        Dim h04_exrt As String
        Dim h05_vat As String
        Dim h06_discper_h As String
        Dim h07_shipvia As String
        Dim h08_shipterms As String
        Dim h09_supquoteno As String
        Dim h10_crdays As String
        Dim h11_crterm As String
        Dim h12_reqno As String
        Dim h13_rem As String
        Dim h14_splins As Double
        Dim h15_Empcd As String
        Dim h16_deptcd As String
        Dim h17_suppcd As String
        Dim h18_curr As String
        Dim h19_jobdt As String
        Dim h20_benefit As String
        Dim h21_approve_period As String
        Dim h22_vehicle_name As String
        Dim h23_port_name As String
        Dim h24_agency_name As String
        Dim h25_benefit_amount As String
        Dim h26_packing_no As String
        Dim h27_invoice_no As String
        Dim h28_bl_no As String
        Dim h29_packing_remark As String
        Dim h30_estimate_departure As String
        Dim h31_estimate_arrival As String
        Dim h32_benefit_kgs As String

    End Structure

    Public Function PODetLoad(ByVal strPONo As String) As DataTable
        Dim conn As New SqlConnection((New classConnection).connection)
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "p_po_det_select"
        comm.Parameters.AddWithValue("@POno", strPONo)
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        conn.Close()
        Return dt
    End Function

    Public Function GetPOUnclose() As DataTable
        Dim conn As New SqlConnection((New classConnection).connection)
        Dim da As New SqlDataAdapter("exec p_po_closing", conn)
        Dim dt As New DataTable
        da.Fill(dt)
        conn.Close()  'Sitthana 20190325
        Return dt
    End Function


    Public Function GetPOUncloseDetail(ByVal strPONO As String) As DataTable
        Dim conn As New SqlConnection((New classConnection).connection)
        Dim da As New SqlDataAdapter("exec p_po_closing2 '" & strPONO & "'", conn)
        Dim dt As New DataTable
        da.Fill(dt)
        conn.Close()  'Sitthana 20190325
        Return dt
    End Function

    Public Function ClosePO(ByVal dt As DataTable, ByRef msgerr As String) As Boolean
        Dim conn As New SqlConnection((New classConnection).connection)
        Dim comm As New SqlCommand("", conn)
        conn.Open()
        Dim tran As SqlTransaction = conn.BeginTransaction
        Dim i As Integer = 0
        comm.Transaction = tran
        comm.CommandType = Data.CommandType.StoredProcedure
        comm.CommandText = "p_po_closing_update"
        For i = 0 To dt.Rows.Count - 1
            Try
                comm.Parameters.Clear()
                comm.Parameters.AddWithValue("@id_jobdet", dt.Rows(i)("id_jobdet"))
                comm.Parameters.AddWithValue("@closed", CBool(dt.Rows(i)("closed")))
                comm.ExecuteNonQuery()
            Catch ex As Exception
                msgerr = ex.Message
                tran.Rollback()
                conn.Close()  'Sitthana 20190325
                Return False
            End Try
        Next

        tran.Commit()
        comm.Dispose()
        If conn.State = ConnectionState.Open Then conn.Close()
        conn.Dispose()
        Return True
    End Function
    Public Function PaidPO(ByVal dt As DataTable, ByRef msgerr As String) As Boolean
        Dim conn As New SqlConnection((New classConnection).connection)
        Dim comm As New SqlCommand("", conn)
        conn.Open()
        Dim tran As SqlTransaction = conn.BeginTransaction
        Dim i As Integer = 0
        comm.Transaction = tran
        comm.CommandType = Data.CommandType.StoredProcedure
        comm.CommandText = "p_po_paid_update"
        For i = 0 To dt.Rows.Count - 1
            Try
                comm.Parameters.Clear()
                comm.Parameters.AddWithValue("@jobno", dt.Rows(i)("jobno"))
                comm.Parameters.AddWithValue("@crdesc", (dt.Rows(i)("crdesc")))
                comm.ExecuteNonQuery()
            Catch ex As Exception
                msgerr = ex.Message
                tran.Rollback()
                conn.Close()  'Sitthana 20190325
                Return False
            End Try
        Next

        tran.Commit()
        comm.Dispose()
        If conn.State = ConnectionState.Open Then conn.Close()
        conn.Dispose()
        Return True
    End Function
    Public Function InsertPurchaseOrder(ByRef Param_tbl_job As tbl_job, ByRef Purno As String, ByRef msgerr As String, ByVal loginEmpcd As String) As Boolean
        Dim config As New clsConfig
        Dim conn As New SqlConnection(connStr.connection())
        Dim comm As New SqlCommand("", conn)
        conn.Open()
        Dim tran As SqlTransaction = conn.BeginTransaction
        comm.Transaction = tran
        comm.CommandType = Data.CommandType.StoredProcedure
        comm.CommandText = "p_pur_insert"
        With Param_tbl_job
            comm.Parameters.Clear()
            comm.Parameters.AddWithValue("@jobdt", .jobdt.Trim)
            comm.Parameters.AddWithValue("@suppcd", .suppcd.Trim)
            comm.Parameters.AddWithValue("@supquoteno", .supquoteno.Trim)
            comm.Parameters.AddWithValue("@sourcedocno", .sourcedocno.Trim)
            comm.Parameters.AddWithValue("@supplang", .supplang.Trim)
            comm.Parameters.AddWithValue("@empcd", .Empcd.Trim)
            comm.Parameters.AddWithValue("@deptcd", .Deptcd.Trim)
            comm.Parameters.AddWithValue("@reqno", .reqno.Trim)
            comm.Parameters.AddWithValue("@delidays", .delidays.ToString)
            comm.Parameters.AddWithValue("@delidt", CDate(.delidt).ToString("yyyyMMdd"))
            comm.Parameters.AddWithValue("@crterm", .crterm.Trim)
            comm.Parameters.AddWithValue("@crdays", .crdays.ToString)
            comm.Parameters.AddWithValue("@crdesc", .crdesc.Trim)
            comm.Parameters.AddWithValue("@paymodecd", .paymodecd.Trim)
            comm.Parameters.AddWithValue("@shipvia", .shipvia.Trim)
            comm.Parameters.AddWithValue("@splins", .splins.Trim)
            comm.Parameters.AddWithValue("@rem", .remark.Trim)
            comm.Parameters.AddWithValue("@import", .import.ToString)
            comm.Parameters.AddWithValue("@curr", .curr.Trim)
            comm.Parameters.AddWithValue("@exrt", .exrt.ToString)

            comm.Parameters.AddWithValue("@gross_amt", .gross_amt) 'Edit By Neung 03/04/2015 string to Num
            comm.Parameters.AddWithValue("@line_discamt", .line_discamt) 'Edit By Neung 03/04/2015 string to Num
            comm.Parameters.AddWithValue("@net_lineamt", .net_lineamt) 'Edit By Neung 03/04/2015 string to Num
            comm.Parameters.AddWithValue("@discper", .discper) 'Edit By Neung 03/04/2015 string to Num
            comm.Parameters.AddWithValue("@discamt", .discamt) 'Edit By Neung 03/04/2015 string to Num
            comm.Parameters.AddWithValue("@vat", .vat) 'Edit By Neung 03/04/2015 string to Num
            comm.Parameters.AddWithValue("@vatamt", .vatamt) 'Edit By Neung 03/04/2015 string to Num
            comm.Parameters.AddWithValue("@total_discamt", .total_discamt) 'Edit By Neung 03/04/2015 string to Num
            comm.Parameters.AddWithValue("@totamt", .totamt) 'Edit By Neung 03/04/2015 string to Num
            comm.Parameters.AddWithValue("@net_amt", .netamt) 'Edit By Neung 03/04/2015 string to Num

            'comm.Parameters.AddWithValue("@discper", .discper.ToString)
            'comm.Parameters.AddWithValue("@discamt", .discamt.ToString)
            'comm.Parameters.AddWithValue("@vat", .vat.ToString)

            comm.Parameters.AddWithValue("@shipterms", .shipterms.Trim)
            comm.Parameters.AddWithValue("@deliaddr", .deliaddr.Trim)
            comm.Parameters.AddWithValue("@log_empcd", loginEmpcd.Trim)
            comm.Parameters.AddWithValue("@itnaturecd", .itnaturecd.Trim)

            comm.Parameters.AddWithValue("@benefit", .benefit.Trim)
            comm.Parameters.AddWithValue("@approve_period", .approved_period.Trim)
            comm.Parameters.AddWithValue("@vehicle_name", .vehicle_name.Trim)
            comm.Parameters.AddWithValue("@port_name", .port_name.Trim)
            comm.Parameters.AddWithValue("@agency_name", .agency_name.Trim)
            comm.Parameters.AddWithValue("@benefit_amount", .benefit_amount.ToString)

            comm.Parameters.AddWithValue("@payment_term", .payment_term.Trim)
            comm.Parameters.AddWithValue("@lc_no", .lc_no.Trim)
            comm.Parameters.AddWithValue("@lc_date", .lc_date)
            comm.Parameters.AddWithValue("@quotation_no", .quotation_no.Trim)
            comm.Parameters.AddWithValue("@quotation_date", .quotation_date)

            comm.Parameters.AddWithValue("@packing_no", .packing_no.Trim)
            comm.Parameters.AddWithValue("@invoice_no", .invoice_no.Trim)
            comm.Parameters.AddWithValue("@bl_no", .bl_no.Trim)
            comm.Parameters.AddWithValue("@estimate_departure", .estimate_departure)
            comm.Parameters.AddWithValue("@estimate_arrival", .estimate_arrival)
            comm.Parameters.AddWithValue("@packing_remark", .packing_remark.Trim)
            comm.Parameters.AddWithValue("@benefit_kgs", .benefit_kgs.ToString)

            comm.Parameters.AddWithValue("@packing_date", .packing_date)
            comm.Parameters.AddWithValue("@invoice_date", .invoice_date)
            comm.Parameters.AddWithValue("@bl_date", .bl_date)
            comm.Parameters.AddWithValue("@awb_no", .awb_no)
            comm.Parameters.AddWithValue("@awb_date", .awb_date)
            comm.Parameters.AddWithValue("@awb_received_date", .awb_received_date)
            comm.Parameters.AddWithValue("@sell_back_to_vendor", .sell_back_to_vendor)
        End With

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

        Param_tbl_job.jobno = dt.Rows(0)("jobno").ToString.Trim

        Dim docno As String = dt.Rows(0)("jobno").ToString.Trim
        Dim i As Integer = 0
        Dim j As Integer = 0
        Dim tbl_job_det As New tbl_job_det
        Dim tbl_job_det_yarn As New tbl_job_det_yarn
        Purno = docno

        Try
            If Not IsNothing(Param_tbl_job.tbl_job_det) Then
                For Each tbl_job_det In Param_tbl_job.tbl_job_det
                    If tbl_job_det Is Nothing Then Exit For
                    comm = New SqlCommand("", conn)
                    comm.CommandType = CommandType.StoredProcedure
                    comm.Transaction = tran
                    comm.CommandText = "p_pur_det_insert "
                    With tbl_job_det
                        comm.Parameters.Clear()
                        comm.Parameters.AddWithValue("@jobno", docno)
                        'comm.Parameters.AddWithValue("@id_jobdet", .id_jobdet.ToString)
                        comm.Parameters.AddWithValue("@itcd", .itcd.Trim)
                        comm.Parameters.AddWithValue("@itdesc", .itdesc.Trim)
                        comm.Parameters.AddWithValue("@qty", .qty.ToString)
                        comm.Parameters.AddWithValue("@uom", .uom.Trim)
                        comm.Parameters.AddWithValue("@price", .price.ToString)
                        comm.Parameters.AddWithValue("@discper", .discper.ToString)
                        comm.Parameters.AddWithValue("@rem", .remark.Trim)
                        comm.Parameters.AddWithValue("@sono", .sono.Trim)
                        comm.Parameters.AddWithValue("@sonoid", .sonoid.Trim)
                        comm.Parameters.AddWithValue("@suppitcd", .suppitcd.Trim)
                        comm.Parameters.AddWithValue("@delidt", CDate(tbl_job_det.delidt).ToString("yyyyMMdd"))
                        comm.Parameters.AddWithValue("@supquoteno", .supquoteno.Trim)
                        comm.Parameters.AddWithValue("@freight_per_unit", .freight_per_unit)
                        comm.Parameters.AddWithValue("@item_unit_price", .item_unit_price)
                        comm.Parameters.AddWithValue("@effective_date", .effective_date)
                        comm.Parameters.AddWithValue("@rcv_warehouse_id", .rcv_warehouse_id)
                        comm.Parameters.AddWithValue("@rcv_subinventory_id", .rcv_subinventory_id)
                        comm.Parameters.AddWithValue("@po_line_types_id", .POLineTypesID)
                    End With
                    da = New SqlDataAdapter(comm)
                    dt = New DataTable
                    da.Fill(dt)
                    Param_tbl_job.tbl_job_det(i).id_jobdet = dt.Rows(0)("id_jobdet")
                    i += 1
                    'j = 0
                    'If Not IsNothing(Param_tbl_job.tbl_job_det_yarn) Then
                    '	For Each tbl_job_det_yarn In Param_tbl_job.tbl_job_det_yarn
                    '		If tbl_job_det_yarn Is Nothing Then Exit For
                    '		If tbl_job_det.itcd.Trim = tbl_job_det_yarn.itcd.Trim Then
                    '			comm = New SqlCommand("", conn)
                    '			comm.CommandType = CommandType.StoredProcedure
                    '			comm.Transaction = tran
                    '			comm.CommandText = "p_job_det_yarn_insert"
                    '			With tbl_job_det_yarn
                    '				comm.Parameters.AddWithValue("@id_job_det_yarn", .id_job_det_yarn.ToString)
                    '				comm.Parameters.AddWithValue("@id_job_det", Param_tbl_job.tbl_job_det(i).id_jobdet.ToString)
                    '				comm.Parameters.AddWithValue("@lotno_sup", .lotno_sup.Trim)
                    '				comm.Parameters.AddWithValue("@lotno_our", .lotno_our.Trim)
                    '				comm.Parameters.AddWithValue("@itcd", .itcd.Trim)
                    '				comm.Parameters.AddWithValue("@boxno", .boxno.Trim)
                    '				comm.Parameters.AddWithValue("@spools", .spools.ToString)
                    '				comm.Parameters.AddWithValue("@kg_gr", .kg_gr.ToString)
                    '				comm.Parameters.AddWithValue("@kg_nt", .kg_nt.ToString)
                    '				comm.Parameters.AddWithValue("@tstamp", CDate(.tstamp).ToString("yyyyMMdd"))
                    '			End With
                    '			da = New SqlDataAdapter(comm)
                    '			dt = New DataTable
                    '			da.Fill(dt)
                    '			Param_tbl_job.tbl_job_det_yarn(j).id_job_det_yarn = dt.Rows(0)("id_job_det_yarn")
                    '		End If
                    '		j += 1
                    '	Next
                    'End If
                Next
            End If
        Catch ex As Exception
            msgerr = ex.Message
            tran.Rollback()
            conn.Close()  'Sitthana 20190325
            Return False
        End Try

        tran.Commit()
        comm.Connection.Close()
        comm.Dispose()
        If conn.State = ConnectionState.Open Then conn.Dispose()
        conn.Dispose()
        Return True
    End Function

    Public Function updateYarnMaster(ByVal Param_tbl_items As tbl_Items, ByVal commandType As String, ByRef msgerr As String, Optional ByVal loginempcd As String = "") As Boolean
        Dim conn As New SqlConnection(connStr.connection())
        Dim comm As New SqlCommand("", conn)
        conn.Open()
        Dim tran As SqlTransaction = conn.BeginTransaction
        comm.Transaction = tran
        comm.CommandType = Data.CommandType.StoredProcedure
        Select Case commandType
            Case "NEW"
                With Param_tbl_items
                    comm.CommandText = "p_items_insert"
                    comm.Parameters.AddWithValue("@itcd", .itcd.Trim)
                    comm.Parameters.AddWithValue("@itdesc", .itdesc.Trim)
                    comm.Parameters.AddWithValue("@itdesc2", .itdesc2.Trim)
                    comm.Parameters.AddWithValue("@itdesc3", .itdesc3.Trim)
                    comm.Parameters.AddWithValue("@itdesc_spec", .itdesc_spec.Trim)
                    comm.Parameters.AddWithValue("@itdesct", .itdesct.Trim)
                    comm.Parameters.AddWithValue("@itdesct2", .itdesct2.Trim)
                    comm.Parameters.AddWithValue("@itdesct3", .itdesct3)
                    comm.Parameters.AddWithValue("@itnaturecd", .itnaturecd.Trim)
                    comm.Parameters.AddWithValue("@ittypecd", .ittypecd.Trim)
                    comm.Parameters.AddWithValue("@itcatcd", .itcatcd.Trim)
                    comm.Parameters.AddWithValue("@itsubcatcd", .itsubcatcd.Trim)
                    comm.Parameters.AddWithValue("@itgroupcd", .itgroupcd.Trim)
                    comm.Parameters.AddWithValue("@itsubcd", .itsubcd.Trim)
                    comm.Parameters.AddWithValue("@itsubcd2", .itsubcd2.Trim)
                    comm.Parameters.AddWithValue("@itsubcd3", .itsubcd3.Trim)
                    comm.Parameters.AddWithValue("@mrpcode", .mrpcode.Trim)
                    comm.Parameters.AddWithValue("@dinear", .dinear.Trim)
                    comm.Parameters.AddWithValue("@filament", .filament.Trim)
                    comm.Parameters.AddWithValue("@twists", .twists.Trim)
                    comm.Parameters.AddWithValue("@col", .col.Trim)
                    comm.Parameters.AddWithValue("@dimension", .dimension.Trim)
                    comm.Parameters.AddWithValue("@suppcd", .suppcd.Trim)
                    comm.Parameters.AddWithValue("@reorder_qty", .reorder_qty)
                    comm.Parameters.AddWithValue("@reorder_unit", .reorder_unit.Trim)
                    comm.Parameters.AddWithValue("@itdesc_supp", .itdesc_supp.Trim)
                    comm.Parameters.AddWithValue("@maximum_qty", .maximum_qty)
                    comm.Parameters.AddWithValue("@beam_length", .beam_length)
                    comm.Parameters.AddWithValue("@warped_ends", .warped_ends)
                    comm.Parameters.AddWithValue("@beams_per_set", .beams_per_set)
                    comm.Parameters.AddWithValue("@lead_time", .lead_time)
                    comm.Parameters.AddWithValue("@safety_stock", .safety_stock)

                End With
            Case "EDIT"
                With Param_tbl_items
                    comm.CommandText = "p_items_update"
                    comm.Parameters.AddWithValue("@itcd", .itcd.Trim)
                    comm.Parameters.AddWithValue("@itdesc", .itdesc.Trim)
                    comm.Parameters.AddWithValue("@itdesc2", .itdesc2.Trim)
                    comm.Parameters.AddWithValue("@itdesc3", .itdesc3.Trim)
                    comm.Parameters.AddWithValue("@itdesc_spec", .itdesc_spec.Trim)
                    comm.Parameters.AddWithValue("@itdesct", .itdesct.Trim)
                    comm.Parameters.AddWithValue("@itdesct2", .itdesct2.Trim)
                    comm.Parameters.AddWithValue("@itdesct3", .itdesct3)
                    comm.Parameters.AddWithValue("@itnaturecd", .itnaturecd.Trim)
                    comm.Parameters.AddWithValue("@ittypecd", .ittypecd.Trim)
                    comm.Parameters.AddWithValue("@itcatcd", .itcatcd.Trim)
                    comm.Parameters.AddWithValue("@itsubcatcd", .itsubcatcd.Trim)
                    comm.Parameters.AddWithValue("@itgroupcd", .itgroupcd.Trim)
                    comm.Parameters.AddWithValue("@itsubcd", .itsubcd.Trim)
                    comm.Parameters.AddWithValue("@itsubcd2", .itsubcd2.Trim)
                    comm.Parameters.AddWithValue("@itsubcd3", .itsubcd3.Trim)
                    comm.Parameters.AddWithValue("@mrpcode", .mrpcode.Trim)
                    comm.Parameters.AddWithValue("@dinear", .dinear.Trim)
                    comm.Parameters.AddWithValue("@filament", .filament.Trim)
                    comm.Parameters.AddWithValue("@twists", .twists.Trim)
                    comm.Parameters.AddWithValue("@col", .col.Trim)
                    comm.Parameters.AddWithValue("@dimension", .dimension.Trim)
                    comm.Parameters.AddWithValue("@suppcd", .suppcd.Trim)
                    comm.Parameters.AddWithValue("@reorder_qty", .reorder_qty)
                    comm.Parameters.AddWithValue("@reorder_unit", .reorder_unit.Trim)
                    comm.Parameters.AddWithValue("@itdesc_supp", .itdesc_supp.Trim)
                    comm.Parameters.AddWithValue("@maximum_qty", .maximum_qty)
                    comm.Parameters.AddWithValue("@beam_length", .beam_length)
                    comm.Parameters.AddWithValue("@warped_ends", .warped_ends)
                    comm.Parameters.AddWithValue("@beams_per_set", .beams_per_set)
                    comm.Parameters.AddWithValue("@lead_time", .lead_time)
                    comm.Parameters.AddWithValue("@safety_stock", .safety_stock)
                End With
            Case "DEL"
                With Param_tbl_items
                    comm.CommandText = "p_items_update"
                    comm.Parameters.AddWithValue("@itcd", .itcd.Trim)
                    comm.Parameters.AddWithValue("@log_empcd", loginempcd.Trim)
                End With
        End Select

        Try
            comm.ExecuteNonQuery()
        Catch ex As Exception
            msgerr = ex.Message
            tran.Rollback()
            conn.Close()  'Sitthana 20190325
            Return False
        End Try

        tran.Commit()
        comm.Connection.Close()
        comm.Dispose()
        If conn.State = ConnectionState.Open Then conn.Close()
        conn.Dispose()
        Return True
    End Function
    Public Function updateTransReportRcvdFlag(pIdJobDet As Integer _
                                             , pRcvdFlagName As String, pRecycleTransreportRcvdFlag As String _
                                             , ByRef msgerr As String)
        'Writen By  : Sitthana 20200925
        Dim conn As New SqlConnection(connStr.connection())
        Dim comm As New SqlCommand("", conn)
        conn.Open()
        Dim tran As SqlTransaction = conn.BeginTransaction
        comm.Transaction = tran
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "P_PUR_PKG_update_rcvd_flag "
        comm.Parameters.AddWithValue("@id_jobdet", pIdJobDet)
        comm.Parameters.AddWithValue("@prcvd_flag_name", pRcvdFlagName)
        comm.Parameters.AddWithValue("@pflagvalue", pRecycleTransreportRcvdFlag)

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
        comm.Connection.Close()
        comm.Dispose()
        If conn.State = ConnectionState.Open Then conn.Close()
        conn.Dispose()
        Return True
    End Function
    Public Function updatePurchaseOrder(ByVal Param_tbl_job As tbl_job, ByVal paramJobDet_Deleted As DataView, ByRef msgerr As String, ByVal loginEmpcd As String) As Boolean
        Dim nDeliDays As Integer
        Dim conn As New SqlConnection(connStr.connection())
        Dim comm As New SqlCommand("", conn)
        conn.Open()
        Dim tran As SqlTransaction = conn.BeginTransaction
        comm.Transaction = tran
        comm.CommandType = Data.CommandType.StoredProcedure
        With Param_tbl_job
            comm.CommandText = "p_pur_update"
            comm.Parameters.Clear()
            comm.Parameters.AddWithValue("@jobno", .jobno.Trim)
            'comm.Parameters.AddWithValue("@jobdt", CDate(.jobdt).ToString("yyyyMMdd"))
            comm.Parameters.AddWithValue("@jobdt", CDate(.jobdt).ToString("yyyyMMdd"))
            comm.Parameters.AddWithValue("@suppcd", .suppcd.Trim)
            comm.Parameters.AddWithValue("@supquoteno", .supquoteno.Trim)
            comm.Parameters.AddWithValue("@sourcedocno", .sourcedocno.Trim)
            comm.Parameters.AddWithValue("@supplang", .supplang.Trim)
            comm.Parameters.AddWithValue("@empcd", .Empcd.Trim)
            comm.Parameters.AddWithValue("@deptcd", .Deptcd.Trim)
            comm.Parameters.AddWithValue("@reqno", .reqno.Trim)
            nDeliDays = Val(.delidays.ToString)
            comm.Parameters.AddWithValue("@delidays", nDeliDays)
            comm.Parameters.AddWithValue("@delidt", CDate(Param_tbl_job.delidt).ToString("yyyyMMdd"))
            comm.Parameters.AddWithValue("@crterm", .crterm.Trim)
            comm.Parameters.AddWithValue("@crdays", .crdays.ToString)
            comm.Parameters.AddWithValue("@crdesc", .crdesc.Trim)
            comm.Parameters.AddWithValue("@paymodecd", .paymodecd.Trim)
            comm.Parameters.AddWithValue("@shipvia", .shipvia.Trim)
            comm.Parameters.AddWithValue("@jobtype", .jobtype.Trim)
            comm.Parameters.AddWithValue("@splins", .splins.Trim)
            comm.Parameters.AddWithValue("@rem", .remark.Trim)
            comm.Parameters.AddWithValue("@import", .import.ToString)
            comm.Parameters.AddWithValue("@curr", .curr.Trim)
            comm.Parameters.AddWithValue("@exrt", .exrt.ToString)

            comm.Parameters.AddWithValue("@gross_amt", .gross_amt) 'Edit By Neung 03/04/2015 string to Num
            comm.Parameters.AddWithValue("@line_discamt", .line_discamt) 'Edit By Neung 03/04/2015 string to Num
            comm.Parameters.AddWithValue("@net_lineamt", .net_lineamt) 'Edit By Neung 03/04/2015 string to Num
            comm.Parameters.AddWithValue("@discper", .discper) 'Edit By Neung 03/04/2015 string to Num
            comm.Parameters.AddWithValue("@discamt", .discamt) 'Edit By Neung 03/04/2015 string to Num
            comm.Parameters.AddWithValue("@vat", .vat) 'Edit By Neung 03/04/2015 string to Num
            comm.Parameters.AddWithValue("@vatamt", .vatamt) 'Edit By Neung 03/04/2015 string to Num
            comm.Parameters.AddWithValue("@total_discamt", .total_discamt) 'Edit By Neung 03/04/2015 string to Num
            comm.Parameters.AddWithValue("@totamt", .totamt) 'Edit By Neung 03/04/2015 string to Num
            comm.Parameters.AddWithValue("@net_amt", .netamt) 'Edit By Neung 03/04/2015 string to Num


            comm.Parameters.AddWithValue("@shipterms", .shipterms.Trim)
            comm.Parameters.AddWithValue("@deliaddr", .deliaddr.Trim)
            comm.Parameters.AddWithValue("@log_empcd", loginEmpcd.Trim)

            comm.Parameters.AddWithValue("@benefit", .benefit.Trim)
            comm.Parameters.AddWithValue("@approve_period", .approved_period.Trim)
            comm.Parameters.AddWithValue("@vehicle_name", .vehicle_name.Trim)
            comm.Parameters.AddWithValue("@port_name", .port_name.Trim)
            comm.Parameters.AddWithValue("@agency_name", .agency_name.Trim)
            comm.Parameters.AddWithValue("@benefit_amount", .benefit_amount.ToString)

            comm.Parameters.AddWithValue("@payment_term", .payment_term.Trim)
            comm.Parameters.AddWithValue("@lc_no", .lc_no.Trim)
            comm.Parameters.AddWithValue("@lc_date", .lc_date)
            comm.Parameters.AddWithValue("@quotation_no", .quotation_no.Trim)
            comm.Parameters.AddWithValue("@quotation_date", .quotation_date)

            comm.Parameters.AddWithValue("@packing_no", .packing_no.Trim)
            comm.Parameters.AddWithValue("@invoice_no", .invoice_no.Trim)
            comm.Parameters.AddWithValue("@bl_no", .bl_no.Trim)
            comm.Parameters.AddWithValue("@estimate_departure", .estimate_departure)
            comm.Parameters.AddWithValue("@estimate_arrival", .estimate_arrival)
            comm.Parameters.AddWithValue("@packing_remark", .packing_remark.Trim)
            comm.Parameters.AddWithValue("@benefit_kgs", .benefit_kgs.ToString)
            comm.Parameters.AddWithValue("@sell_back_to_vendor", .sell_back_to_vendor)
        End With

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

        REM delete job detail ------------------------------

        Dim i As Integer = 0

        Dim deletedRec As DataRowView
        Dim m_id_jobdet As String
        Dim m_Jobno As String

        For Each deletedRec In paramJobDet_Deleted
            m_id_jobdet = deletedRec("id_jobdet")
            m_Jobno = deletedRec("Jobno")

            comm = New SqlCommand("", conn)
            comm.CommandType = CommandType.StoredProcedure
            comm.Transaction = tran
            comm.CommandText = "p_pur_det_delete "
            comm.Parameters.AddWithValue("@jobno", m_Jobno)
            comm.Parameters.AddWithValue("@id_jobdet", m_id_jobdet)
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

        REM update / insert job detail ------------------------------

        Dim tbl_job_det As New tbl_job_det
        i = 0

        If Not Param_tbl_job.tbl_job_det Is Nothing Then
            For Each tbl_job_det In Param_tbl_job.tbl_job_det
                comm = New SqlCommand("", conn)
                comm.CommandType = CommandType.StoredProcedure
                comm.Transaction = tran
                With tbl_job_det
                    If tbl_job_det.id_jobdet = 0 Then
                        comm.CommandText = "p_pur_det_insert "
                        comm.Parameters.Clear()
                        comm.Parameters.AddWithValue("@jobno", Param_tbl_job.jobno.Trim)
                        comm.Parameters.AddWithValue("@itcd", .itcd.Trim)
                        comm.Parameters.AddWithValue("@itdesc", .itdesc.Trim)
                        comm.Parameters.AddWithValue("@qty", .qty.ToString)
                        comm.Parameters.AddWithValue("@uom", .uom.Trim)
                        comm.Parameters.AddWithValue("@price", .price.ToString)
                        comm.Parameters.AddWithValue("@discper", .discper.ToString)
                        comm.Parameters.AddWithValue("@discamt", .discamt.ToString)
                        comm.Parameters.AddWithValue("@rem", .remark)
                        comm.Parameters.AddWithValue("@sono", .sono)
                        comm.Parameters.AddWithValue("@sonoid", .sonoid)
                        comm.Parameters.AddWithValue("@suppitcd", .suppitcd.Trim)
                        'Edit By Neung 11/02/2015
                        comm.Parameters.AddWithValue("@delidt", CDate(Param_tbl_job.delidt).ToString("yyyyMMdd"))
                        'comm.Parameters.AddWithValue("@delidt", tbl_job_det.delidt.ToString) 'ปกติ delidt ข้อมูลเป็น Datetime
                        'comm.Parameters.AddWithValue("@delidt", tbl_job_det.delidt.ToString.Trim)
                        comm.Parameters.AddWithValue("@supquoteno", .supquoteno)
                        comm.Parameters.AddWithValue("@freight_per_unit", .freight_per_unit)
                        comm.Parameters.AddWithValue("@item_unit_price", .item_unit_price)
                        comm.Parameters.AddWithValue("@effective_date", .effective_date)
                        comm.Parameters.AddWithValue("@rcv_warehouse_id", .rcv_warehouse_id)
                        comm.Parameters.AddWithValue("@rcv_subinventory_id", .rcv_subinventory_id)
                        comm.Parameters.AddWithValue("@po_line_types_id", .POLineTypesID)
                    Else
                        comm.CommandText = "p_pur_det_update "
                        comm.Parameters.Clear()
                        comm.Parameters.AddWithValue("@jobno", Param_tbl_job.jobno.Trim)
                        comm.Parameters.AddWithValue("@id_jobdet", .id_jobdet.ToString)
                        comm.Parameters.AddWithValue("@itcd", .itcd.Trim)
                        comm.Parameters.AddWithValue("@itdesc", .itdesc.Trim)
                        comm.Parameters.AddWithValue("@qty", .qty.ToString)
                        comm.Parameters.AddWithValue("@uom", .uom.Trim)
                        comm.Parameters.AddWithValue("@price", .price.ToString)
                        comm.Parameters.AddWithValue("@discper", .discper.ToString)
                        comm.Parameters.AddWithValue("@discamt", .discamt.ToString)
                        comm.Parameters.AddWithValue("@rem", .remark)
                        comm.Parameters.AddWithValue("@sono", .sono.Trim)
                        comm.Parameters.AddWithValue("@sonoid", .sonoid)
                        comm.Parameters.AddWithValue("@suppitcd", .suppitcd.Trim)
                        'Edit By Neung 11/02/2015

                        'Obj_tbl_job.tbl_job_det(i).delidt = clsConfig.IsNull(Me.DgYarn.Rows(i).Cells("delidt").Value, CDate("01/01/1900"))
                        comm.Parameters.AddWithValue("@delidt", CDate(tbl_job_det.delidt).ToString("yyyyMMdd")) 'ปกติ delidt ข้อมูลเป็น Datetime 'Disible By Neung 20151224
                        'comm.Parameters.AddWithValue("@delidt", tbl_job_det.delidt.ToString.Trim)  'Add By Neung 20151224
                        comm.Parameters.AddWithValue("@supquoteno", .supquoteno)
                        comm.Parameters.AddWithValue("@freight_per_unit", .freight_per_unit)
                        comm.Parameters.AddWithValue("@item_unit_price", .item_unit_price)
                        comm.Parameters.AddWithValue("@effective_date", .effective_date)
                        comm.Parameters.AddWithValue("@rcv_warehouse_id", .rcv_warehouse_id)
                        comm.Parameters.AddWithValue("@rcv_subinventory_id", .rcv_subinventory_id)
                        comm.Parameters.AddWithValue("@po_line_types_id", .POLineTypesID)
                    End If
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
                i += 1
            Next

        End If

        tran.Commit()
        conn.Close()  'Sitthana 20190325
        Return True
    End Function
    Public Function updatePurchaseOrderBOI(pJobNo As String, pBenefit As String, ByRef msgerr As String, pUserID As Integer) As Boolean
        Dim conn As New SqlConnection(connStr.connection())
        Dim comm As New SqlCommand("", conn)
        conn.Open()
        Dim tran As SqlTransaction = conn.BeginTransaction
        comm.Transaction = tran
        comm.CommandType = Data.CommandType.StoredProcedure

        comm.CommandText = "p_pur_update_boi"
        comm.Parameters.Clear()
        comm.Parameters.AddWithValue("@p_job_no", pJobNo)
        comm.Parameters.AddWithValue("@p_benefit", pBenefit)

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

    Public Function deleteYarnMaster(ByVal para_itemCode As String, ByVal commandType As String, ByRef msgerr As String, Optional ByVal loginempcd As String = "") As Boolean
        Dim conn As New SqlConnection(connStr.connection())
        Dim comm As New SqlCommand("", conn)
        Dim tran As SqlTransaction = conn.BeginTransaction
        comm.Transaction = tran
        comm.CommandType = Data.CommandType.StoredProcedure
        comm.CommandText = "p_items_delete"
        comm.Parameters.AddWithValue("@itcd", para_itemCode.Trim)
        comm.Parameters.AddWithValue("@log_empcd", loginempcd.Trim)
        Try
            comm.ExecuteNonQuery()
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

    Public Function CheckKeySGN_of_Month(ByVal Num As Integer, ByVal idname As String) As String
        Dim conn As New SqlConnection(connStr.connection())
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = Data.CommandType.StoredProcedure
        comm.CommandText = "p_num_select"
        comm.Parameters.AddWithValue("@idname", idname.Trim)
        comm.Parameters.AddWithValue("@yr", Year(Today()).ToString)
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        Dim KeyMM As String = ""

        Try
            da.Fill(dt)
            conn.Close()  'Sitthana 20190325
        Catch ex As Exception
            conn.Close()  'Sitthana 20190325
            Return KeyMM
        End Try

        If dt.Rows.Count > 0 Then
            If dt.Rows(0)("format").ToString.Trim.ToUpper = "YY" Then
                KeyMM = Val(dt.Rows(0)("num")).ToString
            Else
                KeyMM = Val(dt.Rows(0)("num" & Num)).ToString
            End If
        End If
        Return KeyMM
    End Function

    Public Function approvePurchaseOrder(ByVal Purno As String, ByVal rem_app As String, ByRef msgerr As String, ByVal loginEmpcd As String) As Boolean
        Dim conn As New SqlConnection(connStr.connection())
        Dim comm As New SqlCommand("", conn)

        conn.Open()
        Dim tran As SqlTransaction = conn.BeginTransaction

        comm.Transaction = tran
        comm.CommandType = Data.CommandType.StoredProcedure
        comm.CommandText = "p_pur_approve"

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
            conn.Close()  'Sitthana 20190325
            Return False
        End Try

        tran.Commit()
        conn.Close()  'Sitthana 20190325
        Return True
    End Function
    Public Function cancelPurchaseOrder(ByVal Purno As String, ByVal rem_cancel As String, ByRef msgerr As String, ByVal loginEmpcd As String) As Boolean
        Dim conn As New SqlConnection(connStr.connection())
        Dim comm As New SqlCommand("", conn)

        conn.Open()
        Dim tran As SqlTransaction = conn.BeginTransaction

        comm.Transaction = tran
        comm.CommandType = Data.CommandType.StoredProcedure
        comm.CommandText = "p_pur_cancel"

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

    Public Function POLoad(Optional ByVal StrPOno As String = "", _
       Optional ByVal strDateFr As String = "", _
       Optional ByVal strDateTo As String = "", _
       Optional ByVal strSuppcd As String = "") As DataTable

        Dim conn As New SqlConnection((New classConnection).connection)
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "p_pur_select"
        comm.Parameters.AddWithValue("@pono", StrPOno)
        comm.Parameters.AddWithValue("@datefr", strDateFr)
        comm.Parameters.AddWithValue("@dateto", strDateTo)
        comm.Parameters.AddWithValue("@suppcd", strSuppcd)
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        conn.Close()
        Return dt
    End Function


End Class
