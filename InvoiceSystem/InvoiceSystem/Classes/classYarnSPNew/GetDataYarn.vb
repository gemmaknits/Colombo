Imports System.Data
Imports System.Data.SqlClient
Imports System.Text

Public Class tbl_Pur
    Public purno As String = ""
    Public purdt As DateTime = Today()
    Public suppcd As String = ""
    Public reqno As String = ""
    Public purtype As String = ""
    Public remm As String = ""
    Public import As Boolean = False
    Public curr As String = ""
    Public exrt As Integer = 0
    Public vat As Integer = 0
    Public vatamt As Integer = 0
    Public taxper As Integer = 0
    Public taxamt As Integer = 0
    Public freight As Integer = 0
    Public insurance As Integer = 0
    Public shipping As Integer = 0
    Public handling As Integer = 0
    Public miscamt As Integer = 0
    Public misc_desc As String = ""
    Public discamt As Integer = 0
    Public totamt As Integer = 0
End Class

Public Class tbl_Items
    Public itcd As String = ""
    Public itdesc As String = ""
    Public itdesc2 As String = ""
    Public itdesc3 As String = ""
    Public itdesc_spec As String = ""
    Public itdesct As String = ""
    Public itdesct2 As String = ""
    Public itdesct3 As String = ""
    Public itnaturecd As String = ""
    Public ittypecd As String = ""
    Public itcatcd As String = ""
    Public itsubcatcd As String = ""
    Public itgroupcd As String = ""
    Public itsubcd As String = ""
    Public itsubcd2 As String = ""
    Public itsubcd3 As String = ""
    Public mrpcode As String = ""
    Public dinear As String = ""
    Public filament As String = ""
    Public twists As String = ""
    Public col As String = ""
    Public dimension As String = ""
    Public suppcd As String = ""
    Public location As String = ""
    Public tstamp As DateTime = Today()
End Class


Public Class GetDataYarn
    'Private ds As New DataSet
    'Private clsConfig As New clsConfig
    Private connStr As New classConnection

    '----------------------- Yarn In ------------------

    Public Function checkPurno(ByVal tblPur As Tbl_Pur, ByRef MsgErr As String) As Tbl_Pur()
        Dim i As Integer = 0
        Dim clsConfig As New clsConfig
        Dim dr As DataRow
        Dim dt As New DataTable
        Dim conn As New SqlConnection(connStr.connection())
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "p_job_select"
        comm.Parameters.AddWithValue("@jobno", tblPur.purno.Trim)
        Dim myda As New SqlDataAdapter(comm)
        myda.Fill(dt)
        conn.Close()  'Sitthana 20190325
        If dt.Rows.Count > 0 Then
            Dim objTablePur(0) As tbl_Pur
            For Each dr In dt.Rows
                ReDim Preserve objTablePur(i)
                objTablePur(i) = New tbl_Pur
                objTablePur(i).purno = dr("jobno").ToString
                objTablePur(i).purdt = clsConfig.IsValidDate(dr("jobdt"))
                objTablePur(i).suppcd = dr("suppcd").ToString
                objTablePur(i).reqno = dr("reqno").ToString
                objTablePur(i).purtype = dr("jobtype").ToString
                i = i + 1
            Next
            checkPurno = objTablePur
        Else
            MsgErr = "Can not found"
            checkPurno = Nothing
        End If
    End Function

    Public Function GetDataSupplier() As DataSet
        Dim conn As New SqlConnection(connStr.connection())
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "p_suppliers_select"
        Dim da As New SqlDataAdapter(comm)
        Dim ds As New DataSet
        da.Fill(ds, "tblSuppResult")
        conn.Close()  'Sitthana 20190325
        Return ds
    End Function
    Public Function GetPOSupplier(ByVal purno As String) As DataSet
        Dim conn As New SqlConnection(connStr.connection())
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "p_pur_select_supplier"
        comm.Parameters.AddWithValue("@jobno", purno)
        Dim da As New SqlDataAdapter(comm)
        Dim ds As New DataSet
        da.Fill(ds, "tblSuppResult")
        conn.Close()  'Sitthana 20190325
        Return ds
    End Function

    Public Function GetPODelivery(ByVal purno As String, ByVal itcd As String) As DataTable
        Dim conn As New SqlConnection(connStr.connection())
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "p_purno_select"
        comm.Parameters.AddWithValue("@jobno", purno)
        comm.Parameters.AddWithValue("@itcd", itcd)
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        conn.Close()  'Sitthana 20190325
        Return dt
    End Function

    Public Function GetLocationByYarnInDet() As DataTable
        Dim conn As New SqlConnection(connStr.connection())
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "p_yarn_in_job_return_select_location"

        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        conn.Close()  'Sitthana 20190325
        Return dt
    End Function

    Public Function GetDataItem(ByVal paramItems As tbl_Items) As DataSet
        Dim conn As New SqlConnection(connStr.connection())
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "p_items_select_yarns"
        comm.Parameters.AddWithValue("@itcd", paramItems.itcd.Trim)
        Dim da As New SqlDataAdapter(comm)
        Dim ds As New DataSet
        da.Fill(ds, "items")
        conn.Close()  'Sitthana 20190325
        Return ds
    End Function



    Public Function GetDataCurrency(Optional ByVal strCurr As String = "") As DataSet
        Dim conn As New SqlConnection(connStr.connection())
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "p_currency_select"
        Dim da As New SqlDataAdapter(comm)
        Dim ds As New DataSet
        da.Fill(ds, "tblCurrencyResult")
        conn.Close()  'Sitthana 20190325
        Return ds
    End Function

    Public Function GetDataYarnInDetail(Optional ByVal strDocNo As String = "") As DataTable
        Dim conn As New SqlConnection(connStr.connection())
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "p_yarn_in_det_select"
        comm.Parameters.AddWithValue("@docno", strDocNo.Trim)
        Dim da As New SqlDataAdapter(comm)
        Dim ds As New DataSet
        da.Fill(ds, "TblYarnin_Detail")
        conn.Close()  'Sitthana 20190325
        Return ds.Tables("TblYarnin_Detail")
    End Function

    '----------------------- Yarn Out ---------------

    Public Function GetDataYarnOut(ByVal paramdocno As String, ByVal SourceDoc As String) As DataTable
        Dim conn As New SqlConnection(connStr.connection())
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "p_job_yarn_select"
        comm.Parameters.AddWithValue("@docno", paramdocno.Trim)
        comm.Parameters.AddWithValue("@type", SourceDoc.Trim)
        Dim da As New SqlDataAdapter(comm)
        Dim ds As New DataSet
        da.Fill(ds, "view_YarnBalByBox")
        conn.Close()  'Sitthana 20190325
        Return ds.Tables("view_YarnBalByBox")
    End Function

    Public Function GetDataTrantype(Optional ByVal strTranType As String = "") As DataTable
        Dim conn As New SqlConnection(connStr.connection())
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "p_tran_type_select"
        comm.Parameters.AddWithValue("@tran_type", strTranType.Trim)
        Dim da As New SqlDataAdapter(comm)
        Dim ds As New DataSet
        da.Fill(ds, "tbl_tran_type")
        conn.Close()  'Sitthana 20190325
        Return ds.Tables("tbl_tran_type")
    End Function

    '-------------------- JobOrderforYarn -----------------

    Public Function GetDataPacktype(Optional ByVal strPackCD As String = "") As DataTable
        Dim conn As New SqlConnection(connStr.connection())
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "p_pack_type_select"
        comm.Parameters.AddWithValue("@packcd", strPackCD.Trim)
        Dim da As New SqlDataAdapter(comm)
        Dim ds As New DataSet
        da.Fill(ds, "TblPacktype")
        conn.Close()  'Sitthana 20190325
        Return ds.Tables("TblPacktype")
    End Function

    Public Function GetSupplier(Optional ByVal strSuppcd As String = "") As DataTable
        Dim conn As New SqlConnection(connStr.connection())
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "p_suppliers_select"
        comm.Parameters.AddWithValue("@suppcd", strSuppcd.Trim)
        Dim da As New SqlDataAdapter(comm)
        Dim ds As New DataSet
        da.Fill(ds, "TblSupplier")
        conn.Close()  'Sitthana 20190325
        Return ds.Tables("TblSupplier")
    End Function

    Public Function Getjobtype(Optional ByVal strTranType As String = "") As DataTable
        Dim conn As New SqlConnection(connStr.connection())
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "p_tran_type_select"
        comm.Parameters.AddWithValue("@tran_type", strTranType.Trim)
        Dim da As New SqlDataAdapter(comm)
        Dim ds As New DataSet
        da.Fill(ds, "TblTrantype")
        conn.Close()  'Sitthana 20190325
        Return ds.Tables("TblTrantype")
    End Function

    Public Function GetYarnInno(ByVal YarnIn As String, ByVal Itemcode As String, ByRef Msgerr As String) As DataTable
        If YarnIn = "" And Itemcode = "" Then MessageBox.Show("Yarn IN No. or Item Code is incorrect.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly, False)
        Dim conn As New SqlConnection(connStr.connection())
        Dim comm As New SqlCommand("", conn)
        comm.CommandTimeout = 600
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "p_yarn_in_select2"
        comm.Parameters.AddWithValue("@docno", YarnIn.Trim)
        comm.Parameters.AddWithValue("@itcd", Itemcode.Trim)
        Dim da As New SqlDataAdapter(comm)
        Dim ds As New DataSet

        Try
            da.Fill(ds, "v_YarnBalByBox")
            conn.Close()  'Sitthana 20190325
        Catch ex As Exception
            conn.Close()  'Sitthana 20190325
            Msgerr = ex.Message
        End Try

        Return ds.Tables("v_YarnBalByBox")
    End Function

    Public Function GetYarnInno2(ByRef Msgerr As String) As DataTable
        Dim conn As New SqlConnection(connStr.connection())
        Dim comm As New SqlCommand("", conn)
        comm.CommandTimeout = 600
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "p_yarn_in_select7"
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        Try
            da.Fill(dt)
            conn.Close()  'Sitthana 20190325
        Catch ex As Exception
            conn.Close()  'Sitthana 20190325
            Msgerr = ex.Message
        End Try
        Return dt
    End Function

    Public Function GetYarnInnoPrintBarcode(ByVal YarnIn As String, ByVal Itemcode As String, ByRef Msgerr As String) As DataTable
        If YarnIn = "" And Itemcode = "" Then MessageBox.Show("Yarn IN No. or Item Code is incorrect.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly, False)
        Dim conn As New SqlConnection(connStr.connection())
        Dim comm As New SqlCommand("", conn)
        comm.CommandTimeout = 600
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "p_yarn_in_select3"
        comm.Parameters.AddWithValue("@docno", YarnIn.Trim)
        comm.Parameters.AddWithValue("@itcd", Itemcode.Trim)
        Dim da As New SqlDataAdapter(comm)
        Dim ds As New DataSet

        Try
            da.Fill(ds, "v_YarnBalByBox")
            conn.Close()  'Sitthana 20190325
        Catch ex As Exception
            conn.Close()  'Sitthana 20190325
            Msgerr = ex.Message
        End Try

        Return ds.Tables("v_YarnBalByBox")
    End Function

    Public Function GetColor(Optional ByVal strCol As String = "") As DataTable
        Dim conn As New SqlConnection(connStr.connection())
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "p_colors_select"
        comm.Parameters.AddWithValue("@col", strCol.Trim)
        Dim da As New SqlDataAdapter(comm)
        Dim ds As New DataSet
        da.Fill(ds, "TblColors")
        conn.Close()  'Sitthana 20190325
        Return ds.Tables("TblColors")
    End Function

    '---------------- Create Yarn Master in form Purcahse -----------

    Public Function GetCheckDataYarn_Code(ByVal Yarn_code As String) As Boolean
        Dim conn As New SqlConnection(connStr.connection())
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "p_items_select_yarns"
        comm.Parameters.AddWithValue("@itcd", Yarn_code.Trim)
        Dim da As New SqlDataAdapter(comm)
        Dim ds As New DataSet
        da.Fill(ds, "tblItems")
        conn.Close()  'Sitthana 20190325
        Return IIf(ds.Tables("tblItems").Rows.Count > 0, True, False)
    End Function

    Public Function GetData_Item_group(Optional ByVal strGrpCD As String = "") As DataTable
        Dim conn As New SqlConnection(connStr.connection())
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "p_items_group_select"
        comm.Parameters.AddWithValue("@itgroupcd", strGrpCD.Trim)
        Dim da As New SqlDataAdapter(comm)
        Dim ds As New DataSet
        da.Fill(ds, "tblItemsgroup")
        conn.Close()  'Sitthana 20190325
        Return ds.Tables("tblItemsgroup")
    End Function

    Public Function GetData_Item_type(Optional ByVal strTypeCD As String = "") As DataTable
        Dim conn As New SqlConnection(connStr.connection())
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "p_items_type_select"
        comm.Parameters.AddWithValue("@ittypecd", strTypeCD.Trim)
        Dim da As New SqlDataAdapter(comm)
        Dim ds As New DataSet
        da.Fill(ds, "tblitems_type")
        conn.Close()  'Sitthana 20190325
        Return ds.Tables("tblitems_type")
    End Function

    Public Function GetData_Item_sub(Optional ByVal strSubCD As String = "") As DataTable
        Dim conn As New SqlConnection(connStr.connection())
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "p_items_sub_select"
        comm.Parameters.AddWithValue("@itsubcd", strSubCD.Trim)
        Dim da As New SqlDataAdapter(comm)
        Dim ds As New DataSet
        da.Fill(ds, "tblitems_sub")
        conn.Close()  'Sitthana 20190325
        Return ds.Tables("tblitems_sub")
    End Function

    Public Function GetData_Item_sub2(Optional ByVal strSubCD2 As String = "") As DataTable
        Dim conn As New SqlConnection(connStr.connection())
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "p_items_sub2_select"
        comm.Parameters.AddWithValue("@itsubcd2", strSubCD2.Trim)
        Dim da As New SqlDataAdapter(comm)
        Dim ds As New DataSet
        da.Fill(ds, "tblitems_sub2")
        conn.Close()  'Sitthana 20190325
        Return ds.Tables("tblitems_sub2")
    End Function

    Public Function GetData_Item_cat(Optional ByVal strCatCD As String = "") As DataTable
        Dim conn As New SqlConnection(connStr.connection())
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "p_items_cat_select"
        comm.Parameters.AddWithValue("@itcatcd", strCatCD.Trim)
        Dim da As New SqlDataAdapter(comm)
        Dim ds As New DataSet
        da.Fill(ds, "tblitems_cat")
        conn.Close()  'Sitthana 20190325
        Return ds.Tables("tblitems_cat")
    End Function

    Public Function GetData_Item_subcat(Optional ByVal strSubCatCD As String = "") As DataTable
        Dim conn As New SqlConnection(connStr.connection())
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "p_items_subcat_select"
        comm.Parameters.AddWithValue("@itsubcatcd", strSubCatCD.Trim)
        Dim da As New SqlDataAdapter(comm)
        Dim ds As New DataSet
        da.Fill(ds, "tblitems_subcat")
        conn.Close()  'Sitthana 20190325
        Return ds.Tables("tblitems_subcat")
    End Function

    Public Function GetData_Suppliers(Optional ByVal strSuppcd As String = "") As DataTable
        Dim conn As New SqlConnection(connStr.connection())
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "p_suppliers_select"
        comm.Parameters.AddWithValue("@suppcd", strSuppcd.Trim)
        Dim da As New SqlDataAdapter(comm)
        Dim ds As New DataSet
        da.Fill(ds, "tblitems_Suppliers")
        conn.Close()  'Sitthana 20190325
        Return ds.Tables("tblitems_Suppliers")
    End Function

    '------------------------  Get DataYarnIn -----------------------

    Public Function GetData_YarnIn(ByVal Param_YarninCode As String, ByRef Msgerr As String) As DataTable
        Dim conn As New SqlConnection(connStr.connection())
        Dim comm As New SqlCommand("", conn)
        comm.CommandTimeout = 600
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "p_yarn_in_select4"
        comm.Parameters.AddWithValue("@docno", Param_YarninCode.Trim)
        Dim da As New SqlDataAdapter(comm)
        Dim ds As New DataSet

        Try
            da.Fill(ds, "TblDataYarnIn")
            conn.Close()  'Sitthana 20190325
        Catch ex As Exception
            conn.Close()  'Sitthana 20190325
            Msgerr = ex.Message
        End Try

        Return ds.Tables("TblDataYarnIn")
    End Function

    Public Function GetData_YarnIn2(ByVal Param_YarninCode As String, ByRef Msgerr As String) As DataTable
        Dim conn As New SqlConnection(connStr.connection())
        Dim comm As New SqlCommand("", conn)
        comm.CommandTimeout = 600
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "p_yarn_in_select8"
        comm.Parameters.AddWithValue("@docno", Param_YarninCode.Trim)
        Dim da As New SqlDataAdapter(comm)
        Dim ds As New DataSet

        Try
            da.Fill(ds, "TblDataYarnIn")
            conn.Close()  'Sitthana 20190325
        Catch ex As Exception
            conn.Close()  'Sitthana 20190325
            Msgerr = ex.Message
        End Try

        Return ds.Tables("TblDataYarnIn")
    End Function

    Public Function GetData_YarnIn9(ByVal Param_YarninCode As String, ByRef Msgerr As String) As DataTable
        Dim conn As New SqlConnection(connStr.connection())
        Dim comm As New SqlCommand("", conn)
        comm.CommandTimeout = 600
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "p_yarn_in_select9"
        comm.Parameters.AddWithValue("@docno", Param_YarninCode.Trim)
        Dim da As New SqlDataAdapter(comm)
        Dim ds As New DataSet

        Try
            da.Fill(ds, "TblDataYarnIn")
            conn.Close()  'Sitthana 20190325
        Catch ex As Exception
            conn.Close()  'Sitthana 20190325
            Msgerr = ex.Message
        End Try

        Return ds.Tables("TblDataYarnIn")
    End Function

    Public Function GetData_YarnInDet(ByVal Param_YarninCode As String, ByRef Msgerr As String, ByRef da As SqlDataAdapter) As DataTable
        Dim conn As New SqlConnection(connStr.connection())
        Dim comm As New SqlCommand("", conn)
        comm.CommandTimeout = 600
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "p_yarn_in_det_select"
        comm.Parameters.AddWithValue("@docno", Param_YarninCode.Trim)
        da = New SqlDataAdapter(comm)
        Dim ds As New DataSet

        Try
            da.Fill(ds, "TblDataYarnIndet")
            conn.Close()  'Sitthana 20190325
        Catch ex As Exception
            conn.Close()  'Sitthana 20190325
            Msgerr = ex.Message
        End Try

        Return ds.Tables("TblDataYarnIndet")
    End Function

    '-----------------------------   Get DataYarnOut ----------------

    Public Function GetData_YarnOut(ByVal Param_YarnOutCode As String, ByRef da As SqlDataAdapter, ByRef Msgerr As String) As DataTable
        Dim conn As New SqlConnection(connStr.connection())
        Dim comm As New SqlCommand("", conn)
        comm.CommandTimeout = 600
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "p_yarn_out_select2"
        comm.Parameters.AddWithValue("@docno", Param_YarnOutCode.Trim)
        da = New SqlDataAdapter(comm)
        Dim ds As New DataSet

        Try
            da.Fill(ds, "TblDataYarnOut")
            conn.Close()  'Sitthana 20190325
        Catch ex As Exception
            conn.Close()  'Sitthana 20190325
            Msgerr = ex.Message
        End Try

        Return ds.Tables("TblDataYarnOut")
    End Function

    Public Function GetData_YarnOutdet(ByVal Param_YarnOutCode As String, ByRef da As SqlDataAdapter, ByRef Msgerr As String) As DataTable
        Dim conn As New SqlConnection(connStr.connection())
        Dim comm As New SqlCommand("", conn)
        comm.CommandTimeout = 600
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "p_yarn_out_det_select"
        comm.Parameters.AddWithValue("@outno", Param_YarnOutCode.Trim)
        da = New SqlDataAdapter(comm)
        Dim ds As New DataSet

        Try
            da.Fill(ds, "TblDataYarnOut")
            conn.Close()  'Sitthana 20190325
        Catch ex As Exception
            conn.Close()  'Sitthana 20190325
            Msgerr = ex.Message
        End Try

        Return ds.Tables("TblDataYarnOut")
    End Function

    Public Function GetData_v_Yarn_bal_box(ByVal Param_YarnInCode As String, ByRef Msgerr As String) As DataTable
        Dim conn As New SqlConnection(connStr.connection())
        Dim comm As New SqlCommand("", conn)
        comm.CommandTimeout = 600
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "p_yarn_in_select5 '"
        comm.Parameters.AddWithValue("@docno", Param_YarnInCode.Trim)
        Dim da As New SqlDataAdapter(comm)
        Dim ds As New DataSet

        Try
            da.Fill(ds, "TblDataYarnbalbox")
            conn.Close()  'Sitthana 20190325
        Catch ex As Exception
            conn.Close()  'Sitthana 20190325
            Msgerr = ex.Message
        End Try

        Return ds.Tables("TblDataYarnbalbox")
    End Function

    Public Function GetData_NameSuppliers(ByVal Param_SuppCd As String, ByRef Msgerr As String) As String
        Dim conn As New SqlConnection(connStr.connection())
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "p_suppliers_select"
        comm.Parameters.AddWithValue("@suppcd", Param_SuppCd.Trim)
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable

        Try
            da.Fill(dt)
            conn.Close()  'Sitthana 20190325
        Catch ex As Exception
            conn.Close()  'Sitthana 20190325
            Msgerr = ex.Message
        End Try

        If dt.Rows.Count > 0 Then
            Return dt.Rows(0)("name").ToString
        Else
            Return ""
        End If
    End Function
    Public Function getItemDataFromKI(ByVal paramKono As String) As DataSet
        Dim conn As New SqlConnection(connStr.connection())
        Dim comm As New SqlCommand("", conn)
        comm.CommandTimeout = 600
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "p_items_select_yarns_from_ki"
        comm.Parameters.AddWithValue("@kono", paramKono)
        Dim da As New SqlDataAdapter(comm)
        Dim ds As New DataSet
        da.Fill(ds, "items")
        conn.Close()  'Sitthana 20190325
        Return ds
    End Function
    Public Function getKOYarnDetails(ByVal paramKono As String) As DataSet
        Dim conn As New SqlConnection(connStr.connection())
        Dim comm As New SqlCommand("", conn)
        comm.CommandTimeout = 600
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "p_ko_yarn_select2"
        comm.Parameters.AddWithValue("@kono", paramKono)
        Dim da As New SqlDataAdapter(comm)
        Dim ds As New DataSet
        da.Fill(ds, "ko_yarn")
        conn.Close()  'Sitthana 20190325
        Return ds
    End Function
    Public Function GetJobUncloseDetail(ByVal strPONO As String) As DataTable
        Dim conn As New SqlConnection((New classConnection).connection)
        Dim da As New SqlDataAdapter("exec p_job_closing2 '" & strPONO & "'", conn)
        Dim dt As New DataTable
        da.Fill(dt)
        conn.Close()  'Sitthana 20190325
        Return dt
    End Function
    Public Function GetJobUnclose() As DataTable
        Dim conn As New SqlConnection((New classConnection).connection)
        Dim da As New SqlDataAdapter("exec p_job_closing", conn)
        Dim dt As New DataTable
        da.Fill(dt)
        conn.Close()  'Sitthana 20190325
        Return dt
    End Function

    Public Function getJob(ByVal jobno As String) As DataTable
        Dim conn As New SqlConnection((New classConnection).connection)
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "p_job_select2"
        comm.Parameters.AddWithValue("@jobno", jobno)
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        conn.Close()  'Sitthana 20190325
        Return dt
    End Function

    Public Function getJobFree(ByVal jobno As String) As DataTable
        Dim conn As New SqlConnection((New classConnection).connection)
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "p_job_select_free"
        comm.Parameters.AddWithValue("@jobno", jobno)
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        conn.Close()  'Sitthana 20190325
        Return dt
    End Function

    Public Function getItems() As DataTable
        Dim conn As New SqlConnection((New classConnection).connection)
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "p_items_select"
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        conn.Close()  'Sitthana 20190325
        Return dt
    End Function

    Public Function getYarnIN(ByVal itcd As String) As DataTable
        Dim conn As New SqlConnection((New classConnection).connection)
        Dim comm As New SqlCommand("", conn)
        comm.CommandTimeout = 600
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "p_yarn_in_select6"
        comm.Parameters.AddWithValue("@itcd", itcd)
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        conn.Close()  'Sitthana 20190325
        Return dt
    End Function

    Public Function getYarnLocationLog(ByVal logno As String) As DataTable
        Dim conn As New SqlConnection((New classConnection).connection)
        Dim comm As New SqlCommand("", conn)
        comm.CommandTimeout = 600
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "p_yarn_location_log_select"
        comm.Parameters.AddWithValue("@logno", logno)
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        conn.Close()  'Sitthana 20190325
        Return dt
    End Function

    Public Function getYarnLocationLogNo() As DataTable
        Dim conn As New SqlConnection((New classConnection).connection)
        Dim comm As New SqlCommand("", conn)
        comm.CommandTimeout = 600
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "p_yarn_location_log_select2"
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        conn.Close()  'Sitthana 20190325
        Return dt
    End Function

    Public Function getYarnOut(ByVal Stroutno As String) As DataSet
        Dim conn As New SqlConnection(connStr.connection())
        Dim comm As New SqlCommand("", conn)
        comm.CommandTimeout = 600
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "p_yarn_in_return_job_select_yarn_out"
        comm.Parameters.AddWithValue("@outno", Stroutno)
        Dim da As New SqlDataAdapter(comm)
        Dim ds As New DataSet
        da.Fill(ds, "v_YarnInReturn")
        conn.Close()  'Sitthana 20190325
        Return ds
    End Function

    Public Function Validate_ItemsInKO(ByVal StrKoNO As String, ByVal StrItcd As String, ByVal StrUSerID As String)
        Dim conn As New SqlConnection((New classConnection).connection)
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "p_ko_yarn_validate_items"
        comm.Parameters.AddWithValue("@kono", StrKoNO)
        comm.Parameters.AddWithValue("@itcd", StrItcd)
        comm.Parameters.AddWithValue("@logempcd", StrUSerID)
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        conn.Close()  'Sitthana 20190325
        Return (dt)
    End Function

    Public Function getProductionItem(kono As String) As DataTable
        Dim conn As New SqlConnection((New classConnection).connection)
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "p_get_production_item"
        comm.Parameters.AddWithValue("@kono", kono)
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        conn.Close()  'Sitthana 20190325
        Return dt
    End Function

    Public Function GetdefaultWarehouse(ByVal strUSerID As String) As Nullable(Of Int64)
        Dim conn As New SqlConnection((New classConnection).connection)
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "p_combo_master_mtl_warehouse_set_default"
        comm.Parameters.AddWithValue("@logempcd", strUSerID.Trim)
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        conn.Close()  'Sitthana 20190325
        Return dt.Rows(0)("mtl_warehouse_id")
    End Function

End Class

