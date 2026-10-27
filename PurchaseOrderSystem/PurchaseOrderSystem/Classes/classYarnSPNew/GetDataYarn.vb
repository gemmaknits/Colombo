Imports System.Data
Imports System.Data.SqlClient
Imports System.Text

Public Class GetDataYarn
	'Private ds As New DataSet
	'Private clsConfig As New clsConfig
	Private connStr As New classConnection

	Public Function GetDataItem(ByVal paramItems As tbl_Items) As DataSet
		Dim conn As New SqlConnection(connStr.connection())
		Dim comm As New SqlCommand("", conn)
		comm.CommandType = CommandType.StoredProcedure
		comm.CommandText = "p_items_select"
		comm.Parameters.AddWithValue("@itcd", paramItems.itcd.Trim)
		Dim da As New SqlDataAdapter(comm)
		Dim ds As New DataSet
        da.Fill(ds, "items")
        conn.Close()  'Sitthana 20190325
        Return ds
	End Function

	Public Function GetDataCurrency() As DataSet
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

    Public Function GetDataPOLineType() As DataTable
        Dim conn As New SqlConnection(connStr.connection())
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "P_PO_PKG_get_po_line_type"
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        conn.Close()  'Sitthana 20190325
        Return dt
    End Function
    '-------------------- JobOrderforYarn -----------------

    Public Function GetSupplier() As DataTable
		Dim conn As New SqlConnection(connStr.connection())
		Dim comm As New SqlCommand("", conn)
		comm.CommandType = CommandType.StoredProcedure
		comm.CommandText = "p_suppliers_select"
		Dim da As New SqlDataAdapter(comm)
		Dim dt As New DataTable
        da.Fill(dt)
        conn.Close()  'Sitthana 20190325
        Return dt
	End Function

	Public Function Getjobtype() As DataTable
		Dim conn As New SqlConnection(connStr.connection())
		Dim comm As New SqlCommand("", conn)
		comm.CommandType = CommandType.StoredProcedure
		comm.CommandText = "p_tran_type_select"
		Dim da As New SqlDataAdapter(comm)
		Dim ds As New DataSet
        da.Fill(ds, "tbl_tran_type")
        conn.Close()  'Sitthana 20190325
        Return ds.Tables("tbl_tran_type")
	End Function

	Public Function GetYarnInno(ByVal YarnIn As String, ByVal Itemcode As String, ByRef Msgerr As String) As DataTable
		If YarnIn = "" And Itemcode = "" Then MessageBox.Show("Yarn IN No. or Item Code is incorrect.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly, False)
		Dim conn As New SqlConnection(connStr.connection())
		Dim comm As New SqlCommand("", conn)
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

	Public Function GetColor() As DataTable
		Dim conn As New SqlConnection(connStr.connection())
		Dim comm As New SqlCommand("", conn)
		comm.CommandType = CommandType.StoredProcedure
		comm.CommandText = "p_colors_select"
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
		comm.CommandText = "p_items_select"
		comm.Parameters.AddWithValue("@docno", Yarn_code.Trim)
		Dim da As New SqlDataAdapter(comm)
		Dim ds As New DataSet
        da.Fill(ds, "tblItems")
        conn.Close()  'Sitthana 20190325
        Return IIf(ds.Tables("tblItems").Rows.Count > 0, True, False)
	End Function

	Public Function GetData_Item_Nature() As DataTable
		Dim conn As New SqlConnection(connStr.connection())
		Dim comm As New SqlCommand("", conn)
		comm.CommandType = CommandType.StoredProcedure
		comm.CommandText = "p_items_nature_select"
		Dim da As New SqlDataAdapter(comm)
		Dim ds As New DataSet
        da.Fill(ds, "tblItemsnature")
        conn.Close()  'Sitthana 20190325
        Return ds.Tables("tblItemsnature")
	End Function

	Public Function GetData_Item_group() As DataTable
		Dim conn As New SqlConnection(connStr.connection())
		Dim comm As New SqlCommand("", conn)
		comm.CommandType = CommandType.StoredProcedure
		comm.CommandText = "p_items_group_select"
		Dim da As New SqlDataAdapter(comm)
		Dim ds As New DataSet
        da.Fill(ds, "tblItemsgroup")
        conn.Close()  'Sitthana 20190325
        Return ds.Tables("tblItemsgroup")
	End Function

	Public Function GetData_Item_type() As DataTable
		Dim conn As New SqlConnection(connStr.connection())
		Dim comm As New SqlCommand("", conn)
		comm.CommandType = CommandType.StoredProcedure
		comm.CommandText = "p_items_type_select"
		Dim da As New SqlDataAdapter(comm)
		Dim ds As New DataSet
        da.Fill(ds, "tblitems_type")
        conn.Close()  'Sitthana 20190325
        Return ds.Tables("tblitems_type")
	End Function

	Public Function GetData_Item_sub() As DataTable
		Dim conn As New SqlConnection(connStr.connection())
		Dim comm As New SqlCommand("", conn)
		comm.CommandType = CommandType.StoredProcedure
		comm.CommandText = "p_items_sub_select"
		Dim da As New SqlDataAdapter(comm)
		Dim ds As New DataSet
        da.Fill(ds, "tblitems_sub")
        conn.Close()  'Sitthana 20190325
        Return ds.Tables("tblitems_sub")
	End Function

	Public Function GetData_Item_sub2() As DataTable
		Dim conn As New SqlConnection(connStr.connection())
		Dim comm As New SqlCommand("", conn)
		comm.CommandType = CommandType.StoredProcedure
		comm.CommandText = "p_items_sub2_select"
		Dim da As New SqlDataAdapter(comm)
		Dim ds As New DataSet
        da.Fill(ds, "tblitems_sub2")
        conn.Close()  'Sitthana 20190325
        Return ds.Tables("tblitems_sub2")
	End Function

	Public Function GetData_Item_cat() As DataTable
		Dim conn As New SqlConnection(connStr.connection())
		Dim comm As New SqlCommand("", conn)
		comm.CommandType = CommandType.StoredProcedure
		comm.CommandText = "p_items_cat_select"
		Dim da As New SqlDataAdapter(comm)
		Dim ds As New DataSet
        da.Fill(ds, "tblitems_cat")
        conn.Close()  'Sitthana 20190325
        Return ds.Tables("tblitems_cat")
	End Function

	Public Function GetData_Item_subcat() As DataTable
		Dim conn As New SqlConnection(connStr.connection())
		Dim comm As New SqlCommand("", conn)
		comm.CommandType = CommandType.StoredProcedure
		comm.CommandText = "p_items_subcat_select"
		Dim da As New SqlDataAdapter(comm)
		Dim ds As New DataSet
        da.Fill(ds, "tblitems_subcat")
        conn.Close()  'Sitthana 20190325
        Return ds.Tables("tblitems_subcat")
	End Function

	Public Function GetData_Suppliers() As DataTable
		Dim conn As New SqlConnection(connStr.connection())
		Dim comm As New SqlCommand("", conn)

		comm.CommandType = CommandType.StoredProcedure
		comm.CommandText = "p_suppliers_select"
		comm.Parameters.AddWithValue("@suppcd", "")

		Dim da As New SqlDataAdapter(comm)
		Dim ds As New DataSet
        da.Fill(ds, "tblitems_Suppliers")
        conn.Close()  'Sitthana 20190325
        Return ds.Tables("tblitems_Suppliers")
	End Function

	'---------------------------Get Data Create Purchase order -----------

	Public Function GetDataAddress(ByVal suppcd As String, ByRef msgerr As String) As tbl_Suppliers
		Dim conn As New SqlConnection(connStr.connection())
		Dim comm As New SqlCommand("", conn)
		comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "p_suppliers_select2"
        comm.Parameters.Clear()
        comm.Parameters.AddWithValue("@suppcd", suppcd)
        Dim da As New SqlDataAdapter(comm)
		Dim ds As New DataSet
		Dim obj_supp As New tbl_Suppliers
        da.Fill(ds, "tblitems_Suppliers")
        conn.Close()  'Sitthana 20190325
        If ds.Tables("tblitems_Suppliers").Rows.Count > 0 Then
			obj_supp.suppcd = ds.Tables("tblitems_Suppliers").Rows(0).Item("suppcd").ToString
			obj_supp.name = ds.Tables("tblitems_Suppliers").Rows(0).Item("name").ToString
			obj_supp.namet = ds.Tables("tblitems_Suppliers").Rows(0).Item("namet").ToString
			obj_supp.addr1 = ds.Tables("tblitems_Suppliers").Rows(0).Item("addr1").ToString
			obj_supp.addr2 = ds.Tables("tblitems_Suppliers").Rows(0).Item("addr2").ToString
			obj_supp.addr3 = ds.Tables("tblitems_Suppliers").Rows(0).Item("addr3").ToString
			obj_supp.addr1t = ds.Tables("tblitems_Suppliers").Rows(0).Item("addr1t").ToString
			obj_supp.addr2t = ds.Tables("tblitems_Suppliers").Rows(0).Item("addr2t").ToString
			obj_supp.addr3t = ds.Tables("tblitems_Suppliers").Rows(0).Item("addr3t").ToString
			obj_supp.city = ds.Tables("tblitems_Suppliers").Rows(0).Item("city").ToString
			obj_supp.ctry = ds.Tables("tblitems_Suppliers").Rows(0).Item("ctry").ToString
			obj_supp.tel = ds.Tables("tblitems_Suppliers").Rows(0).Item("tel").ToString
			obj_supp.fax = ds.Tables("tblitems_Suppliers").Rows(0).Item("fax").ToString
            obj_supp.email = ds.Tables("tblitems_Suppliers").Rows(0).Item("email").ToString
            obj_supp.email_cc = ds.Tables("tblitems_Suppliers").Rows(0).Item("email_cc").ToString
            obj_supp.contact = ds.Tables("tblitems_Suppliers").Rows(0).Item("contact").ToString
			obj_supp.altcode = ds.Tables("tblitems_Suppliers").Rows(0).Item("altcode").ToString
			obj_supp.abbrev = ds.Tables("tblitems_Suppliers").Rows(0).Item("abbrev").ToString
			obj_supp.crdays = ds.Tables("tblitems_Suppliers").Rows(0).Item("crdays").ToString
			obj_supp.crterms = ds.Tables("tblitems_Suppliers").Rows(0).Item("crterms").ToString
			obj_supp.paymode = ds.Tables("tblitems_Suppliers").Rows(0).Item("paymodecd").ToString
			obj_supp.import = ds.Tables("tblitems_Suppliers").Rows(0).Item("import").ToString
		End If
		Return obj_supp
	End Function

	Public Function GetDataItem() As DataTable
		Dim conn As New SqlConnection(connStr.connection())
		Dim comm As New SqlCommand("", conn)
		comm.CommandType = CommandType.StoredProcedure
		comm.CommandText = "p_items_select2"
		comm.Parameters.AddWithValue("@itcd", "")
		Dim da As New SqlDataAdapter(comm)
		Dim ds As New DataSet
        da.Fill(ds, "tblitems")
        conn.Close()  'Sitthana 20190325
        Return ds.Tables("tblItems")
	End Function

	Public Overloads Function GetDataItemcode(ByVal itcd As String) As DataTable
		Dim conn As New SqlConnection(connStr.connection())
		Dim comm As New SqlCommand("", conn)
		comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "p_items_select"
		comm.Parameters.AddWithValue("@itcd", itcd.Trim)
		Dim da As New SqlDataAdapter(comm)
        Dim ds As New DataSet
        conn.Close()  'Sitthana 20190325
        da.Fill(ds, "items")
		Return ds.Tables("items")
	End Function

	Public Overloads Function GetDataItemcode(ByVal itcd As String, ByVal ItNatureCd As String) As DataTable
		Dim conn As New SqlConnection(connStr.connection())
		Dim comm As New SqlCommand("", conn)
		comm.CommandType = CommandType.StoredProcedure
		comm.CommandText = "p_items_select3"
		comm.Parameters.AddWithValue("@itcd", itcd.Trim)
		comm.Parameters.AddWithValue("@itnaturecd", ItNatureCd.Trim)
		Dim da As New SqlDataAdapter(comm)
		Dim ds As New DataSet
        da.Fill(ds, "items")
        conn.Close()  'Sitthana 20190325
        Return ds.Tables("items")
    End Function
    Public Overloads Function GetSupplierItems(ByVal suppcd As String) As DataTable
        Dim conn As New SqlConnection(connStr.connection())
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "p_supplier_items"
        comm.Parameters.AddWithValue("@suppcd", suppcd)
        Dim da As New SqlDataAdapter(comm)
        Dim ds As New DataSet
        da.Fill(ds, "items")
        conn.Close()  'Sitthana 20190325
        Return ds.Tables("items")
    End Function

	Public Function GetDataItemNature() As DataTable
		Dim conn As New SqlConnection(connStr.connection())
		Dim comm As New SqlCommand("", conn)
		comm.CommandType = CommandType.StoredProcedure
		comm.CommandText = "p_items_nature_select"
		comm.Parameters.AddWithValue("@itnaturecd", "")
		Dim da As New SqlDataAdapter(comm)
		Dim ds As New DataSet
        da.Fill(ds, "itemnature")
        conn.Close()  'Sitthana 20190325
        Return ds.Tables("itemnature")
	End Function

	Public Function GetDataItemDesc(ByVal stritdesc As String, ByVal stritcd As String) As DataTable
		Dim conn As New SqlConnection(connStr.connection())
		Dim comm As New SqlCommand("", conn)
		comm.CommandType = CommandType.StoredProcedure
		comm.CommandText = "p_items_select4"
		comm.Parameters.AddWithValue("@itdesc", stritdesc.Trim)
		comm.Parameters.AddWithValue("@itcd", stritcd.Trim)
		Dim da As New SqlDataAdapter(comm)
		Dim ds As New DataSet
        da.Fill(ds, "TblItems")
        conn.Close()  'Sitthana 20190325
        Return ds.Tables("TblItems")
	End Function

	Public Function GetDataUnit() As DataTable
		Dim conn As New SqlConnection(connStr.connection())
		Dim comm As New SqlCommand("", conn)
		comm.CommandType = CommandType.StoredProcedure
		comm.CommandText = "p_uom_select"
		Dim da As New SqlDataAdapter(comm)
		Dim ds As New DataSet
        da.Fill(ds, "uom")
        conn.Close()  'Sitthana 20190325
        Return ds.Tables("uom")
	End Function

	Public Function GetDeptList() As DataTable
		Dim conn As New SqlConnection(connStr.connection())
		Dim comm As New SqlCommand("", conn)
		comm.CommandType = CommandType.StoredProcedure
		comm.CommandText = "p_dept_select"
		Dim da As New SqlDataAdapter(comm)
		Dim ds As New DataSet
        da.Fill(ds, "dept")
        conn.Close()  'Sitthana 20190325
        Return ds.Tables("dept")
	End Function

    Public Function GetEmpList() As DataTable
        Dim conn As New SqlConnection(connStr.connection())
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "p_emp_select"
        Dim da As New SqlDataAdapter(comm)
        Dim ds As New DataSet
        da.Fill(ds, "emp")
        conn.Close()  'Sitthana 20190325
        Return ds.Tables("emp")
    End Function
    Public Function GetEmpComboList() As DataTable
        'Create By : Sitthana 24/03/2018
        Dim conn As New SqlConnection(connStr.connection())
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "p_combo_emp_select"
        comm.Parameters.Clear()
        Dim da As New SqlDataAdapter(comm)
        Dim ds As New DataSet
        da.Fill(ds, "emp")
        conn.Close()  'Sitthana 20190325
        Return ds.Tables("emp")
    End Function
End Class
