Imports System.Data
Imports System.Data.SqlClient
Imports System.Text
Public Class classItemsCategory

    Public Structure ItemsCategory_Header
        '-=============== Items Category =============================
        Dim items_category_id As Int32
        Dim items_category_set_id As Nullable(Of Int32)
        Dim itcd As String
        Dim itcatcd As String
        Dim itsubcatcd As String
        Dim itgroupcd As String
        Dim itsubcd As String
        Dim items_sub_group2_id As Nullable(Of Int32)    'Insert By Sitthana 20171219
        Dim ittypecd As String
        Dim itsubcd2 As String
        Dim creation_date As Nullable(Of DateTime)
        Dim created_by As String
        Dim last_modified_date As Nullable(Of DateTime)
        Dim last_modified_by As String
        Dim category_enabled As String
        Dim itnaturecd As String
        Dim msgerr As String

        '-============================================================
    End Structure

    Public Structure ItemsProperties_Header
        '-============== Items Properties=============================
        Dim items_properties_id As Int64
        Dim itcd As String
        Dim lookup_id As Nullable(Of Int64)
        Dim lookup_value_id As Nullable(Of Int64)
        '-============================================================
    End Structure
    Public Function GetDefaultItemsCategory(Optional ByRef Int32itemsCategoryId As Int32 = 0, Optional ByRef StrItcd As String = "", Optional ByRef logempcd As String = "") As DataTable
        Dim conn As New SqlConnection((New classConnection).connection)
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "p_inventory_category_get_default_master_items_category"
        comm.Parameters.AddWithValue("@items_category_id", Int32itemsCategoryId)
        comm.Parameters.AddWithValue("@itcd", StrItcd)
        comm.Parameters.AddWithValue("@logempcd", logempcd)
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        conn.Close()
        Return dt
    End Function
    Public Function VerifyDesignRemoved(Optional ByVal strDesignNo As String = "", Optional ByVal Stritem_disabled As String = "N") As DataTable
        Dim conn As New SqlConnection((New classConnection).connection)
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "p_verify_design_removed"
        comm.Parameters.AddWithValue("@design_no", strDesignNo)
        comm.Parameters.AddWithValue("@item_disabled", Stritem_disabled)
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        conn.Close()  'Sitthana 20190325
        Return dt
    End Function

    Public Function GetItemNature(Optional ByVal Stritnaturecd As String = "") As DataTable
        Dim conn As New SqlConnection((New classConnection).connection)
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "p_items_nature_select"
        comm.Parameters.AddWithValue("@itnaturecd", Stritnaturecd)
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        conn.Close()  'Sitthana 20190325
        Return dt
    End Function

    Public Function GetItemsCategorySet(Optional ByRef Stritems_category_set_id As Int32 = 0, Optional ByRef logempcd As String = "") As DataTable
        Dim conn As New SqlConnection((New classConnection).connection)
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "p_inventory_category_select_items_category_set"
        comm.Parameters.AddWithValue("@items_category_set_id", Stritems_category_set_id)
        comm.Parameters.AddWithValue("@logempcd", logempcd)
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        conn.Close()
        Return dt
    End Function

    Public Function GetItemsCategory(Optional ByRef Int32itemsCategoryId As Int32 = 0, Optional ByRef StrItcd As String = "", Optional ByRef logempcd As String = "") As DataTable
        Dim conn As New SqlConnection((New classConnection).connection)
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "p_inventory_category_select_items_category"
        comm.Parameters.AddWithValue("@items_category_id", Int32itemsCategoryId)
        comm.Parameters.AddWithValue("@itcd", StrItcd)
        comm.Parameters.AddWithValue("@logempcd", logempcd)
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        conn.Close()
        Return dt
    End Function
    Public Function GetLookUpTypeAndvalues(Optional ByRef Int64lookupid As Int64 = 0, Optional ByRef Strlogempcd As String = "") As DataTable
        Dim conn As New SqlConnection((New classConnection).connection)
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "p_inventory_category_select_lookup_type_and_values"
        comm.Parameters.AddWithValue("@lookup_id", Int64lookupid)
        comm.Parameters.AddWithValue("@logempcd", Strlogempcd)
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        conn.Close()
        Return dt
    End Function

    'Table Lookup
    Public Function getMasterLookupValueByValueType(ByRef pLookupType As String, pForFilter As String) As DataTable
        'Writen By : Sitthana Boonlom 20200622
        Dim conn As New SqlConnection((New classConnection).connection)
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "P_MASTER_COMBO_PKG_select_lookup_value_by_value_type"
        comm.Parameters.AddWithValue("@p_lookup_type", pLookupType)
        comm.Parameters.AddWithValue("@p_for_filter", pForFilter)
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        conn.Close()
        Return dt
    End Function
    Public Function GetLookUpType(Optional ByRef Int64lookupid As Int64 = 0, Optional ByRef Strlogempcd As String = "") As DataTable
        Dim conn As New SqlConnection((New classConnection).connection)
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "p_inventory_category_select_lookup_type"
        comm.Parameters.AddWithValue("@lookup_id", Int64lookupid)
        comm.Parameters.AddWithValue("@logempcd", Strlogempcd)
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        conn.Close()
        Return dt
    End Function
    Public Function GetLookUpValues(Optional ByRef Int64lookupvalueid As Int64 = 0, Optional ByRef logempcd As String = "") As DataTable
        Dim conn As New SqlConnection((New classConnection).connection)
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "p_inventory_category_select_lookup_values"
        'comm.Parameters.AddWithValue("@lookup_id", Int64lookupid)
        comm.Parameters.AddWithValue("@lookup_value_id", Int64lookupvalueid)
        comm.Parameters.AddWithValue("@logempcd", logempcd)
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        conn.Close()
        Return dt
    End Function
    Public Function GetLookUpValuesOnlyActived(Optional ByRef Int64lookupvalueid As Int64 = 0, Optional ByRef logempcd As String = "") As DataTable
        'Sitthana 20230911 modify from GetLookUpValues
        Dim conn As New SqlConnection((New classConnection).connection)
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "p_inventory_category_select_lookup_values_OnlyActive"
        'comm.Parameters.AddWithValue("@lookup_id", Int64lookupid)
        comm.Parameters.AddWithValue("@lookup_value_id", Int64lookupvalueid)
        comm.Parameters.AddWithValue("@logempcd", logempcd)
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        conn.Close()
        Return dt
    End Function

    'Master Data
    Public Function getMasterItemsCategory(ByRef pItnatureCd As String, pForFilter As String) As DataTable
        'Writen By : Sitthana Boonlom 20200622
        Dim conn As New SqlConnection((New classConnection).connection)
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "P_MASTER_COMBO_PKG_select_items_category"
        comm.Parameters.AddWithValue("@p_itnaturecd", pItnatureCd)
        comm.Parameters.AddWithValue("@p_for_filter", pForFilter)
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        conn.Close()
        Return dt
    End Function
    Public Function getMasterItemsSubcategory(ByRef pItnatureCd As String, pForFilter As String) As DataTable
        'Writen By : Sitthana Boonlom 20200708
        Dim conn As New SqlConnection((New classConnection).connection)
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "P_MASTER_COMBO_PKG_select_items_subcategory"
        comm.Parameters.AddWithValue("@p_itnaturecd", pItnatureCd)
        comm.Parameters.AddWithValue("@p_for_filter", pForFilter)
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        conn.Close()
        Return dt
    End Function
    Public Function getMasterItemsGroup(ByRef pItnatureCd As String, pForFilter As String) As DataTable
        'Writen By : Sitthana Boonlom 20200622
        Dim conn As New SqlConnection((New classConnection).connection)
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "P_MASTER_COMBO_PKG_select_items_group"
        comm.Parameters.AddWithValue("@p_itnaturecd", pItnatureCd)
        comm.Parameters.AddWithValue("@p_for_filter", pForFilter)
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        conn.Close()
        Return dt
    End Function
    Public Function getMasterItemsSubgroup(ByRef pItnatureCd As String, pForFilter As String) As DataTable
        'Writen By : Sitthana Boonlom 20200708
        Dim conn As New SqlConnection((New classConnection).connection)
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "P_MASTER_COMBO_PKG_select_items_subgroup"
        comm.Parameters.AddWithValue("@p_itnaturecd", pItnatureCd)
        comm.Parameters.AddWithValue("@p_for_filter", pForFilter)
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        conn.Close()
        Return dt
    End Function

    Public Function GetCbolookupCode(Optional ByRef Int64lookupid As Int64 = 0, Optional ByRef logempcd As String = "") As DataTable
        Dim conn As New SqlConnection((New classConnection).connection)
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "p_inventory_category_select_cbo_look_up"
        comm.Parameters.AddWithValue("@lookup_id", Int64lookupid)
        'comm.Parameters.AddWithValue("@logempcd", logempcd)
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        conn.Close()
        Return dt
    End Function

    Public Function GetCbolookupCodeOnlyActived(Optional ByRef Int64lookupid As Int64 = 0, Optional ByRef logempcd As String = "") As DataTable
        Dim conn As New SqlConnection((New classConnection).connection)
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "p_inventory_category_select_cbo_look_up_OnlyActive"
        comm.Parameters.AddWithValue("@lookup_id", Int64lookupid)
        'comm.Parameters.AddWithValue("@logempcd", logempcd)
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        conn.Close()
        Return dt
    End Function

    Public Function GetItemsProPerties(Optional ByRef Int64items_properties_id As Int64 = 0, Optional ByRef StrItcd As String = "", Optional ByRef logempcd As String = "") As DataTable
        Dim conn As New SqlConnection((New classConnection).connection)
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "p_inventory_category_select_items_properties"
        comm.Parameters.AddWithValue("@items_properties_id", Int64items_properties_id)
        comm.Parameters.AddWithValue("@itcd", StrItcd)
        comm.Parameters.AddWithValue("@logempcd", logempcd)
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        conn.Close()
        Return dt
    End Function

    Public Function GetItemsCat(Optional ByRef StrItcatcd As String = "", Optional ByRef Stritnaturecd As String = "", Optional ByRef Intitems_category_set_id As Integer = 0, Optional ByRef logempcd As String = "") As DataTable
        Dim conn As New SqlConnection((New classConnection).connection)
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "p_inventory_category_select_items_cat"
        comm.Parameters.AddWithValue("@itcatcd", StrItcatcd)
        comm.Parameters.AddWithValue("@itnaturecd", Stritnaturecd)
        comm.Parameters.AddWithValue("@items_category_set_id", Intitems_category_set_id)
        comm.Parameters.AddWithValue("@logempcd", logempcd)
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        conn.Close()
        Return dt
    End Function

    Public Function GetComboItemsCat(Optional ByRef StrItcatcd As String = "", Optional ByRef Stritnaturecd As String = "", Optional ByRef Intitems_category_set_id As Integer = 0) As DataTable
        'Modify By Sitthana 20171219
        Dim conn As New SqlConnection((New classConnection).connection)
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "p_inventory_category_Combo_items_cat"
        comm.Parameters.AddWithValue("@itcatcd", StrItcatcd)
        comm.Parameters.AddWithValue("@itnaturecd", Stritnaturecd)
        comm.Parameters.AddWithValue("@items_category_set_id", Intitems_category_set_id)
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        conn.Close()
        Return dt
    End Function

    Public Function GetItemsSubCat(Optional ByRef Stritsubcatcd As String = "", Optional ByRef Stritnaturecd As String = "", Optional ByRef Intitems_category_set_id As Integer = 0, Optional ByRef logempcd As String = "") As DataTable
        Dim conn As New SqlConnection((New classConnection).connection)
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "p_inventory_category_select_items_subcat"
        comm.Parameters.AddWithValue("@itsubcatcd", Stritsubcatcd)
        comm.Parameters.AddWithValue("@itnaturecd", Stritnaturecd)
        comm.Parameters.AddWithValue("@items_category_set_id", Intitems_category_set_id)
        comm.Parameters.AddWithValue("@logempcd", logempcd)
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        conn.Close()
        Return dt
    End Function

    Public Function getComboItemsSubCat(Optional ByRef Stritsubcatcd As String = "", Optional ByRef Stritnaturecd As String = "", Optional ByRef Intitems_category_set_id As Integer = 0, Optional ByRef logempcd As String = "") As DataTable
        'Modify By Sitthana 20171219
        Dim conn As New SqlConnection((New classConnection).connection)
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "p_inventory_category_combo_items_subcat"
        comm.Parameters.AddWithValue("@itsubcatcd", Stritsubcatcd)
        comm.Parameters.AddWithValue("@itnaturecd", Stritnaturecd)
        comm.Parameters.AddWithValue("@items_category_set_id", Intitems_category_set_id)
        comm.Parameters.AddWithValue("@logempcd", logempcd)
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        conn.Close()
        Return dt
    End Function

    Public Function GetItemsGroup(Optional ByRef StrItgroupcd As String = "", Optional ByRef Stritnaturecd As String = "", Optional ByRef Intitems_category_set_id As Integer = 0, Optional ByRef logempcd As String = "") As DataTable
        Dim conn As New SqlConnection((New classConnection).connection)
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "p_inventory_category_select_items_group"
        comm.Parameters.AddWithValue("@itgroupcd", StrItgroupcd)
        comm.Parameters.AddWithValue("@itnaturecd", Stritnaturecd)
        comm.Parameters.AddWithValue("@items_category_set_id", Intitems_category_set_id)
        comm.Parameters.AddWithValue("@logempcd", logempcd)
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        conn.Close()
        Return dt
    End Function

    Public Function getComboItemsGroup(Optional ByRef StrItgroupcd As String = "", Optional ByRef Stritnaturecd As String = "", Optional ByRef Intitems_category_set_id As Integer = 0, Optional ByRef logempcd As String = "") As DataTable
        'Modify By Sitthana 20171219
        Dim conn As New SqlConnection((New classConnection).connection)
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "p_inventory_category_combo_items_group"
        comm.Parameters.AddWithValue("@itgroupcd", StrItgroupcd)
        comm.Parameters.AddWithValue("@itnaturecd", Stritnaturecd)
        comm.Parameters.AddWithValue("@items_category_set_id", Intitems_category_set_id)
        comm.Parameters.AddWithValue("@logempcd", logempcd)
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        conn.Close()
        Return dt
    End Function

    Public Function getComboItemsSubGroup2(Optional ByRef Stritnaturecd As String = "", Optional ByRef Intitems_category_set_id As Integer = 0) As DataTable
        'Create By Sitthana 20171219
        Dim conn As New SqlConnection((New classConnection).connection)
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "p_inventory_category_combo_items_sub_group2"
        comm.Parameters.AddWithValue("@itnaturecd", Stritnaturecd)
        comm.Parameters.AddWithValue("@items_category_set_id", Intitems_category_set_id)
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        conn.Close()
        Return dt
    End Function

    Public Function GetItemsSub(Optional ByRef Stritsubcd As String = "", Optional ByRef Stritnaturecd As String = "", Optional ByRef Intitems_category_set_id As Integer = 0, Optional ByRef logempcd As String = "") As DataTable
        Dim conn As New SqlConnection((New classConnection).connection)
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "p_inventory_category_select_items_sub"
        comm.Parameters.AddWithValue("@itsubcd", Stritsubcd)
        comm.Parameters.AddWithValue("@itnaturecd", Stritnaturecd)
        comm.Parameters.AddWithValue("@items_category_set_id", Intitems_category_set_id)
        comm.Parameters.AddWithValue("@logempcd", logempcd)
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        conn.Close()
        Return dt
    End Function

    Public Function getComboItemsSub(Optional ByRef Stritnaturecd As String = "", Optional ByRef Intitems_category_set_id As Integer = 0) As DataTable
        'Modify By Sitthana 20171219
        Dim conn As New SqlConnection((New classConnection).connection)
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "p_inventory_category_Combo_items_sub"
        comm.Parameters.AddWithValue("@itnaturecd", Stritnaturecd)
        comm.Parameters.AddWithValue("@items_category_set_id", Intitems_category_set_id)
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        conn.Close()
        Return dt
    End Function

    Public Function GetItemsType(Optional ByRef Strittypecd As String = "", Optional ByRef Stritnaturecd As String = "", Optional ByRef Intitems_category_set_id As Integer = 0, Optional ByRef logempcd As String = "") As DataTable
        Dim conn As New SqlConnection((New classConnection).connection)
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "p_inventory_category_select_items_type"
        comm.Parameters.AddWithValue("@ittypecd", Strittypecd)
        comm.Parameters.AddWithValue("@itnaturecd", Stritnaturecd)
        comm.Parameters.AddWithValue("@items_category_set_id", Intitems_category_set_id)
        comm.Parameters.AddWithValue("@logempcd", logempcd)
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        conn.Close()
        Return dt
    End Function

    Public Function GetComboItemsType(Optional ByRef Strittypecd As String = "", Optional ByRef Stritnaturecd As String = "", Optional ByRef Intitems_category_set_id As Integer = 0, Optional ByRef logempcd As String = "") As DataTable
        'Modify By Sitthana 20171219
        Dim conn As New SqlConnection((New classConnection).connection)
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "p_inventory_category_combo_items_type"
        comm.Parameters.AddWithValue("@ittypecd", Strittypecd)
        comm.Parameters.AddWithValue("@itnaturecd", Stritnaturecd)
        comm.Parameters.AddWithValue("@items_category_set_id", Intitems_category_set_id)
        comm.Parameters.AddWithValue("@logempcd", logempcd)
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        conn.Close()
        Return dt
    End Function

    Public Function GetItemsSub2(Optional ByRef Stritsubcd2 As String = "", Optional ByRef Stritnaturecd As String = "", Optional ByRef Intitems_category_set_id As Integer = 0, Optional ByRef logempcd As String = "") As DataTable
        Dim conn As New SqlConnection((New classConnection).connection)
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "p_inventory_category_select_items_sub2"
        comm.Parameters.AddWithValue("@itsubcd2", Stritsubcd2)
        comm.Parameters.AddWithValue("@itnaturecd", Stritnaturecd)
        comm.Parameters.AddWithValue("@items_category_set_id", Intitems_category_set_id)
        comm.Parameters.AddWithValue("@logempcd", logempcd)
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        conn.Close()
        Return dt
    End Function

    Public Function getComboItemsSub2(Optional ByRef Stritsubcd2 As String = "", Optional ByRef Stritnaturecd As String = "", Optional ByRef Intitems_category_set_id As Integer = 0) As DataTable
        'Modify By Sitthana 20171219
        Dim conn As New SqlConnection((New classConnection).connection)
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "p_inventory_category_Combo_items_sub2"
        comm.Parameters.AddWithValue("@itsubcd2", Stritsubcd2)
        comm.Parameters.AddWithValue("@itnaturecd", Stritnaturecd)
        comm.Parameters.AddWithValue("@items_category_set_id", Intitems_category_set_id)
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        conn.Close()
        Return dt
    End Function

    Public Function GetApplication() As DataTable
        Dim conn As New SqlConnection((New classConnection).connection)
        Dim comm As New SqlCommand("", conn)
        comm.CommandText = CommandType.StoredProcedure
        comm.CommandText = "p_inventory_category_select_application"


        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        conn.Close()
        Return dt

    End Function

    Public Function SaveItemDisible(ByRef DM As classMasterUpdate.DM, ByRef ItemsCategory_Header As ItemsCategory_Header, ByRef ItemsProperties_Header As ItemsProperties_Header, ByVal dvItemsCategory_add As DataView, ByVal dvItemsCategory_upd As DataView, ByVal dvItemsCategory_del As DataView, ByVal dvItemsProperties_add As DataView, ByVal dvItemsProperties_upd As DataView, ByVal dvItemsProperties_del As DataView, ByVal clsuser As classUserInfo) As Boolean
        Dim config As New clsConfig
        Dim conn As New SqlConnection((New classConnection).connection)
        conn.Open()
        Dim tran As SqlTransaction = conn.BeginTransaction
        Dim comm As New SqlCommand("", conn)
        Dim i As Integer = 0
        Dim j As Integer = 0
        Dim strLotNo As String = ""
        Dim Action As String = ""
        comm.Transaction = tran
        comm.CommandType = CommandType.StoredProcedure

        comm.CommandText = "p_inventory_category_update_items"
        With DM
            comm.Parameters.Clear()
            comm.Parameters.AddWithValue("@itcd", ItemsCategory_Header.itcd)
            comm.Parameters.AddWithValue("@item_disabled", DM.h37_item_disabled)
            comm.Parameters.AddWithValue("@dm_remark", DM.h38_dm_remark)
            comm.Parameters.AddWithValue("@empcd", clsuser.UserID)
        End With
        Dim dadm = New SqlDataAdapter(comm)
        Dim dtdm = New DataTable
        Try
            dadm.Fill(dtdm)
        Catch ex As Exception
            ItemsCategory_Header.msgerr = ex.Message
            tran.Rollback()
            conn.Close()  'Sitthana 20190325
            Return False
        End Try


        tran.Commit()
        conn.Close()  'Sitthana 20190325
        Return True

    End Function

    Public Function ItemsCategorySave(ByRef DM As classMasterUpdate.DM, ByRef ItemsCategory_Header As ItemsCategory_Header, ByRef ItemsProperties_Header As ItemsProperties_Header, ByVal dvItemsCategory_add As DataView, ByVal dvItemsCategory_upd As DataView, ByVal dvItemsCategory_del As DataView, ByVal dvItemsProperties_add As DataView, ByVal dvItemsProperties_upd As DataView, ByVal dvItemsProperties_del As DataView, ByVal clsuser As classUserInfo) As Boolean
        Dim config As New clsConfig
        Dim conn As New SqlConnection((New classConnection).connection)
        conn.Open()
        Dim tran As SqlTransaction = conn.BeginTransaction
        Dim comm As New SqlCommand("", conn)
        Dim i As Integer = 0
        Dim j As Integer = 0
        Dim strLotNo As String = ""
        Dim Action As String = ""
        comm.Transaction = tran
        comm.CommandType = CommandType.StoredProcedure

        comm.CommandText = "p_inventory_category_update_items"
        With DM
            comm.Parameters.Clear()
            comm.Parameters.AddWithValue("@itcd", ItemsCategory_Header.itcd)
            comm.Parameters.AddWithValue("@item_disabled", DM.h37_item_disabled)
            comm.Parameters.AddWithValue("@dm_remark", DM.h38_dm_remark)
            comm.Parameters.AddWithValue("@empcd", clsuser.UserID)
        End With
        Dim dadm = New SqlDataAdapter(comm)
        Dim dtdm = New DataTable
        Try
            dadm.Fill(dtdm)
        Catch ex As Exception
            ItemsCategory_Header.msgerr = ex.Message
            tran.Rollback()
            conn.Close()  'Sitthana 20190325
            Return False
        End Try


        comm.CommandText = "p_inventory_category_insert_items_category"
        i = 0
        For i = 0 To dvItemsCategory_add.Count - 1
            With dvItemsCategory_add
                comm.Parameters.Clear()
                comm.Parameters.AddWithValue("@items_category_id", ItemsCategory_Header.items_category_id) '= 0
                comm.Parameters.AddWithValue("@items_category_set_id", .Item(i)("items_category_set_id"))
                comm.Parameters.AddWithValue("@itcd", ItemsCategory_Header.itcd)
                comm.Parameters.AddWithValue("@itcatcd", config.IsNull(.Item(i)("itcatcd"), Nothing))
                comm.Parameters.AddWithValue("@itsubcatcd", config.IsNull(.Item(i)("itsubcatcd"), Nothing))
                comm.Parameters.AddWithValue("@itgroupcd", config.IsNull(.Item(i)("itgroupcd"), Nothing))
                comm.Parameters.AddWithValue("@itsubcd", config.IsNull(.Item(i)("itsubcd"), Nothing))
                comm.Parameters.AddWithValue("@items_sub_group2_id", config.IsNull(.Item(i)("items_sub_group2_id"), Nothing))  'Sitthana1 13/03/2018
                comm.Parameters.AddWithValue("@ittypecd", config.IsNull(.Item(i)("ittypecd"), Nothing))
                comm.Parameters.AddWithValue("@itsubcd2", config.IsNull(.Item(i)("itsubcd2"), Nothing))
                comm.Parameters.AddWithValue("@creation_date", ItemsCategory_Header.creation_date)
                comm.Parameters.AddWithValue("@created_by", ItemsCategory_Header.created_by)
                comm.Parameters.AddWithValue("@last_modified_date", ItemsCategory_Header.last_modified_date)
                comm.Parameters.AddWithValue("@last_modified_by", ItemsCategory_Header.last_modified_by)
                comm.Parameters.AddWithValue("@category_enabled", .Item(i)("category_enabled"))
                comm.Parameters.AddWithValue("@itnaturecd", ItemsCategory_Header.itnaturecd)
                comm.Parameters.AddWithValue("@empcd", clsuser.UserID)
                comm.CommandTimeout = 360
                '  comm.Parameters.AddWithValue("@checknew", CheckNEW)
            End With
            'Dim sql As String = config.BuildSQL(comm)
            Dim dac_int = New SqlDataAdapter(comm)
            Dim dtc_int = New DataTable
            Try
                dac_int.Fill(dtc_int)
            Catch ex As Exception
                ItemsCategory_Header.msgerr = ex.Message
                tran.Rollback()
                conn.Close()  'Sitthana 20190325
                Return False
            End Try
            Action = "ADD"
        Next

        comm.CommandText = "p_inventory_category_update_items_category"
        i = 0
        For i = 0 To dvItemsCategory_upd.Count - 1
            With dvItemsCategory_upd
                comm.Parameters.Clear()
                comm.Parameters.AddWithValue("@items_category_id", .Item(i)("items_category_id"))
                comm.Parameters.AddWithValue("@items_category_set_id", .Item(i)("items_category_set_id"))
                comm.Parameters.AddWithValue("@itcd", .Item(i)("itcd"))
                comm.Parameters.AddWithValue("@itcatcd", config.IsNull(.Item(i)("itcatcd"), Nothing))
                comm.Parameters.AddWithValue("@itsubcatcd", config.IsNull(.Item(i)("itsubcatcd"), Nothing))
                comm.Parameters.AddWithValue("@itgroupcd", config.IsNull(.Item(i)("itgroupcd"), Nothing))
                comm.Parameters.AddWithValue("@itsubcd", config.IsNull(.Item(i)("itsubcd"), Nothing))
                comm.Parameters.AddWithValue("@items_sub_group2_id", config.IsNull(.Item(i)("items_sub_group2_id"), Nothing))  'Sitthana 13/03/2018
                comm.Parameters.AddWithValue("@ittypecd", config.IsNull(.Item(i)("ittypecd"), Nothing))
                comm.Parameters.AddWithValue("@itsubcd2", config.IsNull(.Item(i)("itsubcd2"), Nothing))
                comm.Parameters.AddWithValue("@creation_date", config.IsNull(.Item(i)("creation_date"), ItemsCategory_Header.creation_date))
                comm.Parameters.AddWithValue("@created_by", config.IsNull(.Item(i)("created_by"), ItemsCategory_Header.created_by))
                comm.Parameters.AddWithValue("@last_modified_date", ItemsCategory_Header.last_modified_date)
                comm.Parameters.AddWithValue("@last_modified_by", ItemsCategory_Header.last_modified_by)
                comm.Parameters.AddWithValue("@category_enabled", .Item(i)("category_enabled"))
                comm.Parameters.AddWithValue("@itnaturecd", ItemsCategory_Header.itnaturecd)
                comm.Parameters.AddWithValue("@empcd", clsuser.UserID)
                comm.CommandTimeout = 360
                '  comm.Parameters.AddWithValue("@checknew", CheckNEW)
            End With
            'Dim sql As String = config.BuildSQL(comm)
            Dim dac_int = New SqlDataAdapter(comm)
            Dim dtc_int = New DataTable
            Try
                dac_int.Fill(dtc_int)
            Catch ex As Exception
                ItemsCategory_Header.msgerr = ex.Message
                tran.Rollback()
                conn.Close()  'Sitthana 20190325
                Return False
            End Try
            Action = "UPD"
        Next

        comm.CommandText = "p_inventory_category_delete_items_category"
        i = 0
        For i = 0 To dvItemsCategory_del.Count - 1
            With dvItemsCategory_del
                comm.Parameters.Clear()
                comm.Parameters.AddWithValue("@items_category_id", .Item(i)("items_category_id"))
                comm.Parameters.AddWithValue("@items_category_set_id", .Item(i)("items_category_set_id"))
                comm.Parameters.AddWithValue("@itcd", .Item(i)("itcd"))
                comm.Parameters.AddWithValue("@itcatcd", config.IsNull(.Item(i)("itcatcd"), Nothing))
                comm.Parameters.AddWithValue("@itsubcatcd", config.IsNull(.Item(i)("itsubcatcd"), Nothing))
                comm.Parameters.AddWithValue("@itgroupcd", config.IsNull(.Item(i)("itgroupcd"), Nothing))
                comm.Parameters.AddWithValue("@itsubcd", config.IsNull(.Item(i)("itsubcd"), Nothing))
                comm.Parameters.AddWithValue("@ittypecd", config.IsNull(.Item(i)("ittypecd"), Nothing))
                comm.Parameters.AddWithValue("@itsubcd2", config.IsNull(.Item(i)("itsubcd2"), Nothing))
                comm.Parameters.AddWithValue("@creation_date", .Item(i)("creation_date"))
                comm.Parameters.AddWithValue("@created_by", .Item(i)("created_by"))
                comm.Parameters.AddWithValue("@last_modified_date", ItemsCategory_Header.last_modified_date)
                comm.Parameters.AddWithValue("@last_modified_by", ItemsCategory_Header.last_modified_by)
                comm.Parameters.AddWithValue("@category_enabled", .Item(i)("category_enabled"))
                comm.Parameters.AddWithValue("@itnaturecd", ItemsCategory_Header.itnaturecd)
                comm.Parameters.AddWithValue("@empcd", clsuser.UserID)
                comm.CommandTimeout = 360
                '  comm.Parameters.AddWithValue("@checknew", CheckNEW)
            End With
            'Dim sql As String = config.BuildSQL(comm)
            Dim dac_int = New SqlDataAdapter(comm)
            Dim dtc_int = New DataTable
            Try
                dac_int.Fill(dtc_int)
            Catch ex As Exception
                ItemsCategory_Header.msgerr = ex.Message
                tran.Rollback()
                conn.Close()  'Sitthana 20190325
                Return False
            End Try
            Action = "DEL"
        Next

        comm.CommandText = "p_inventory_category_insert_items_properties"
        i = 0
        For i = 0 To dvItemsProperties_add.Count - 1
            With dvItemsProperties_add
                comm.Parameters.Clear()
                comm.Parameters.AddWithValue("@items_properties_id", ItemsProperties_Header.items_properties_id) '= 0
                comm.Parameters.AddWithValue("@itcd", ItemsProperties_Header.itcd)
                comm.Parameters.AddWithValue("@lookup_id", .Item(i)("lookup_id"))
                comm.Parameters.AddWithValue("@lookup_value_id", .Item(i)("lookup_value_id"))
                comm.Parameters.AddWithValue("@items_properties_enabled", .Item(i)("items_properties_enabled"))
                comm.Parameters.AddWithValue("@empcd", clsuser.UserID)
                comm.CommandTimeout = 360
            End With
            'Dim sql As String = config.BuildSQL(comm)
            Dim dac_int = New SqlDataAdapter(comm)
            Dim dtc_int = New DataTable
            Try
                dac_int.Fill(dtc_int)
            Catch ex As Exception
                ItemsCategory_Header.msgerr = ex.Message
                tran.Rollback()
                conn.Close()  'Sitthana 20190325
                Return False
            End Try
            Action = "ADD"
        Next

        comm.CommandText = "p_inventory_category_update_items_properties"
        i = 0
        For i = 0 To dvItemsProperties_upd.Count - 1
            With dvItemsProperties_upd
                comm.Parameters.Clear()
                comm.Parameters.AddWithValue("@items_properties_id", .Item(i)("items_properties_id"))
                comm.Parameters.AddWithValue("@itcd", .Item(i)("itcd"))
                comm.Parameters.AddWithValue("@lookup_id", .Item(i)("lookup_id"))
                comm.Parameters.AddWithValue("@lookup_value_id", .Item(i)("lookup_value_id"))
                comm.Parameters.AddWithValue("@items_properties_enabled", .Item(i)("items_properties_enabled"))
                comm.Parameters.AddWithValue("@empcd", clsuser.UserID)
                comm.CommandTimeout = 360
            End With
            'Dim sql As String = config.BuildSQL(comm)
            Dim dac_int = New SqlDataAdapter(comm)
            Dim dtc_int = New DataTable
            Try
                dac_int.Fill(dtc_int)
            Catch ex As Exception
                ItemsCategory_Header.msgerr = ex.Message
                tran.Rollback()
                conn.Close()  'Sitthana 20190325
                Return False
            End Try
            Action = "UPD"
        Next

        comm.CommandText = "p_inventory_category_delete_items_properties"
        i = 0
        For i = 0 To dvItemsProperties_del.Count - 1
            With dvItemsProperties_del
                comm.Parameters.Clear()
                comm.Parameters.AddWithValue("@items_properties_id", .Item(i)("items_properties_id"))
                comm.Parameters.AddWithValue("@itcd", .Item(i)("itcd"))
                comm.Parameters.AddWithValue("@lookup_id", .Item(i)("lookup_id"))
                comm.Parameters.AddWithValue("@lookup_value_id", .Item(i)("lookup_value_id"))
                comm.Parameters.AddWithValue("@items_properties_enabled", .Item(i)("items_properties_enabled"))
                comm.Parameters.AddWithValue("@empcd", clsuser.UserID)

                comm.CommandTimeout = 360
            End With
            'Dim sql As String = config.BuildSQL(comm)
            Dim dac_int = New SqlDataAdapter(comm)
            Dim dtc_int = New DataTable
            Try
                dac_int.Fill(dtc_int)
            Catch ex As Exception
                ItemsCategory_Header.msgerr = ex.Message
                tran.Rollback()
                conn.Close()  'Sitthana 20190325
                Return False
            End Try
            Action = "DEL"
        Next

        tran.Commit()
        conn.Close()  'Sitthana 20190325
        Return True
    End Function

    'Select data for report
    Public Function rep_designs_properties(pAppName As String, pSubappName As String, pSplFncName As String _
                                         , pCompo As String, pArticle As String, pCategory As String _
                                         , pSubcategory As String, pFabricGroup As String, pFabricSubgroup As String _
                                         , pDesignDateFrom As String, pDesignDateTo As String _
                                         , pFwthFrom As String, pFwthTo As String, pMtkgFrom As String, pMtkgTo As String
                                           ) As DataTable
        'Create By Sitthana 20200630
        Dim conn As New SqlConnection((New classConnection).connection)
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "P_MASTER_PKG_rep_designs_properties"
        comm.Parameters.AddWithValue("@p_app_name", pAppName)
        comm.Parameters.AddWithValue("@p_subapp_name", pSubappName)
        comm.Parameters.AddWithValue("@p_spl_fnc_name", pSplFncName)
        comm.Parameters.AddWithValue("@p_compo", pCompo)
        comm.Parameters.AddWithValue("@p_article", pArticle)
        comm.Parameters.AddWithValue("@p_category", pCategory)
        comm.Parameters.AddWithValue("@p_subcategory", pSubcategory)
        comm.Parameters.AddWithValue("@p_fabric_group", pFabricGroup)
        comm.Parameters.AddWithValue("@p_fabric_subgroup", pFabricSubgroup)
        comm.Parameters.AddWithValue("@p_design_date_from", pDesignDateFrom)
        comm.Parameters.AddWithValue("@p_design_date_to", pDesignDateTo)
        comm.Parameters.AddWithValue("@p_fwth_from", pFwthFrom)
        comm.Parameters.AddWithValue("@p_fwth_to", pFwthTo)
        comm.Parameters.AddWithValue("@p_mtkg_from", pMtkgFrom)
        comm.Parameters.AddWithValue("@p_mtkg_to", pMtkgTo)
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        conn.Close()
        Return dt
    End Function

    Public Function getLookupTypeId(pLookupType As String) As Integer
        Dim LookupType As Integer
        Dim conn As New SqlConnection((New classConnection).connection)
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "p_lookup_select_lookup_type_id"
        comm.Parameters.AddWithValue("@p_lookup_type", pLookupType)
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        If dt.Rows.Count > 0 Then
            LookupType = dt.Rows(0)("lookup_id")
        Else
            LookupType = -1
        End If
        conn.Close()
        Return LookupType
    End Function

    Public Function getLookupValueByType(ByRef pLookupId As Integer) As DataTable
        Dim conn As New SqlConnection((New classConnection).connection)
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "p_combo_lookup_value_by_value_type"
        comm.Parameters.AddWithValue("@lookup_id", pLookupId)
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        conn.Close()
        Return dt
    End Function

End Class
