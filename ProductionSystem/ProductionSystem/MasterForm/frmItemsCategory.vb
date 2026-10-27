Imports Microsoft.Reporting.WinForms
Imports System.Net.Mail

Public Class frmItemsCategory
    Dim clsConn As New classConnection
       Dim clsuser As new classUserInfo
    Dim StrItcd As String = ""
    Dim StrItnaturecd As String = "FABRIC"
    Dim dm As classMasterUpdate.DM
    Dim BooleanBFitem_disabled As Boolean
    Dim _AllowEdit As Boolean = True

    Public Property PItcd() As String
        Get
            PItcd = StrItcd
        End Get
        Set(ByVal NewValue As String)
            StrItcd = NewValue
        End Set

    End Property

    Public Property Pitnaturecd() As String
        Get
            Pitnaturecd = StrItnaturecd
        End Get
        Set(ByVal Newvalue As String)
            StrItnaturecd = Newvalue
        End Set
    End Property

    Public Property UserInfo() As classUserInfo
        Get
            UserInfo = clsuser
        End Get
        Set(ByVal NewValue As classUserInfo)
            clsuser = NewValue
        End Set
    End Property
    Public Property AllowEdit()
        Get
            Return _AllowEdit
        End Get
        Set(ByVal value)
            _AllowEdit = value
        End Set
    End Property
    'Public Property clsdm As classMasterUpdate.DM
    '    Get
    '        clsdm = dm
    '    End Get
    '    Set(ByVal NewValue As classMasterUpdate.DM)
    '        dm = NewValue
    '    End Set
    'End Property


    Private Sub InitControl()
        Call GenCBO()
        Call GenCBOINGRID()
        Call GenGrid()
        Call LoadData(0, StrItcd)
        cboitemsnature.SelectedValue = StrItnaturecd
        txtItemCd.Text = StrItcd
        txtItemCd.Select()
    End Sub

    Private Function LoadData(ByVal id As Integer, ByVal StrItcd As String) As Boolean
        Dim objDB As New classItemsCategory
        Dim clsmasterDM As New classMaster
        Dim dtdm As DataTable = clsmasterDM.GetDesign3(design_no:=StrItcd)

        Dim dtItemsCategory As DataTable = objDB.GetItemsCategory(0, StrItcd, clsuser.UserID)
        Dim dtItemsProperties As DataTable = objDB.GetItemsProPerties(0, StrItcd, clsuser.UserID)

        Call BindText(dtdm)
        Call BindgrdItemsCategory(dtItemsCategory) 'Sitthana test 20181223
        Call BindgrdItemsProperties(dtItemsProperties) 'Sitthana test 20181223

        btnSave.Enabled = AllowEdit

    End Function

    Private Sub BindText(ByVal dt As DataTable)
        If dt.Rows.Count > 0 Then
            chkitem_disabled.Checked = IIf(dt.Rows(0)("item_disabled").ToString = "Y", True, False)
            BooleanBFitem_disabled = IIf(dt.Rows(0)("item_disabled").ToString = "Y", True, False)

            txtdm_remark.Text = dt.Rows(0)("dm_remark").ToString
        Else
            chkitem_disabled.Checked = False
            txtdm_remark.Text = ""
        End If
        'chkitem_disabled.Checked = IIf(dt.Rows(0)("item_disabled").ToString = "Y", True, False)


    End Sub

    Private Sub BindDataItemsCategory(ByVal dt As DataTable)

        cboitemsnature.SelectedValue = dt.Rows(0)("itemsnature")

    End Sub

    Private Sub BindgrdItemsCategory(ByVal dt As DataTable)
        grdItemsCategory.AutoGenerateColumns = False
        grdItemsCategory.DataSource = dt

        Call InitializeDataGridView()
    End Sub

    Private Sub InitializeDataGridView()
        For Each dgvr As DataGridViewRow In grdItemsCategory.Rows
            If Not dgvr.IsNewRow Then
                If dgvr.Cells("items_category_id").Value Is DBNull.Value Then
                    For ColNo As Integer = 0 To grdItemsCategory.ColumnCount - 1
                        dgvr.Cells(ColNo).Style.BackColor = Color.Yellow
                    Next
                Else
                    For ColNo As Integer = 0 To grdItemsCategory.ColumnCount - 1
                        dgvr.Cells(ColNo).Style.BackColor = Nothing
                    Next
                End If
            ElseIf dgvr.IsNewRow Then
                If dgvr.Cells("items_category_id").Value Is DBNull.Value Then
                    For ColNo As Integer = 0 To grdItemsCategory.ColumnCount - 1
                        dgvr.Cells(ColNo).Style.BackColor = Color.Yellow
                    Next
                End If
            End If
        Next

    End Sub

    '-- Comment By Sitthana Because This procedure not use
    'Private Sub BindgrdItemsCategoryManual(ByVal dt As DataTable)
    '    'Comment By Sitthana Because This procedure not use 20/12/2017
    '    Dim dr As DataRow
    '    Dim dtItemsCategory As New DataTable

    '    dtItemsCategory.Columns.Add("items_category_set_id")
    '    dtItemsCategory.Columns.Add("itcd")
    '    dtItemsCategory.Columns.Add("itcatcd")
    '    dtItemsCategory.Columns.Add("itsubcatcd")
    '    dtItemsCategory.Columns.Add("itgroupcd")
    '    dtItemsCategory.Columns.Add("itsubcd")
    '    dtItemsCategory.Columns.Add("items_sub_group2_id")   'Insert By Sitthana 19/12/2017
    '    dtItemsCategory.Columns.Add("ittypecd")
    '    dtItemsCategory.Columns.Add("itsubcd2")
    '    dtItemsCategory.Columns.Add("creation_date")
    '    dtItemsCategory.Columns.Add("created_by")
    '    dtItemsCategory.Columns.Add("last_modified_date")
    '    dtItemsCategory.Columns.Add("last_modified_by")
    '    dtItemsCategory.Columns.Add("category_enabled")
    '    dtItemsCategory.Columns.Add("itnaturecd")

    '    If dt.Rows.Count > 0 Then

    '        For i = 0 To dt.Rows.Count - 1
    '            dr = dtItemsCategory.NewRow()

    '            For j = 0 To dt.Columns.Count - 1
    '                Dim dgvcc As New DataGridViewComboBoxCell
    '                dr("items_category_set_id") = dt.Rows(i)("items_category_set_id")
    '                dr("itcd") = dt.Rows(i)("itcd")
    '                dr("itcatcd") = dt.Rows(i)("itcatcd")
    '                dr("itsubcatcd") = dt.Rows(i)("itsubcatcd")
    '                dr("itgroupcd") = dt.Rows(i)("itgroupcd")
    '                dr("itsubcd") = dt.Rows(i)("itsubcd")
    '                dr("items_sub_group2_id") = dt.Rows(i)("items_sub_group2_id")   'Insert By Sitthana 19/12/2017
    '                dr("ittypecd") = dt.Rows(i)("ittypecd")
    '                dr("itsubcd2") = dt.Rows(i)("itsubcd2")
    '                dr("creation_date") = dt.Rows(i)("creation_date")
    '                dr("created_by") = dt.Rows(i)("created_by")
    '                dr("last_modified_date") = dt.Rows(i)("last_modified_date")
    '                dr("last_modified_by") = dt.Rows(i)("last_modified_by")
    '                dr("category_enabled") = dt.Rows(i)("category_enabled")
    '                dr("itnaturecd") = dt.Rows(i)("itnaturecd")
    '            Next
    '            dtItemsCategory.Rows.Add(dr)
    '        Next

    '        grdItemsCategory.AutoGenerateColumns = False
    '        grdItemsCategory.DataSource = dtItemsCategory

    '    End If
    'End Sub
    Private Sub BindgrdItemsProperties(ByVal dt As DataTable)
        grdItemsProperties.AutoGenerateColumns = False
        grdItemsProperties.DataSource = dt
    End Sub
    Private Sub GenCBO()
        Dim objdb As New classItemsCategory

        '====================== Gen Combo Box========================================= 
        cboproperty.DataSource = objdb.GetLookUpType(0, clsuser.UserID)
        cboproperty.DisplayMember = "lookup_name"
        cboproperty.ValueMember = "lookup_id"
        cboproperty.SelectedIndex = -1

        'cboValue.DataSource = objdb.GetLookUpValues(0, clsuser.UserID)
        'cboValue.DisplayMember = "lookup_value"
        'cboValue.ValueMember = "lookup_value_id"
        'cboValue.SelectedIndex = 0

        cboitemsnature.DataSource = objdb.GetItemNature
        cboitemsnature.DisplayMember = "itnaturecddesc"
        cboitemsnature.ValueMember = "itnaturecd"
        cboitemsnature.SelectedIndex = -1


        '=============================================================================

    End Sub
    Private Sub GenCBOINGRID()
        Dim objdb As New classItemsCategory


        '======================Combo Items Properties======================================= 
        'cboproperty.DataSource = objdb.GetLookUpType(0, clsuser.UserID)
        'cboproperty.DisplayMember = "lookup_name"
        'cboproperty.ValueMember = "lookup_id"
        'cboproperty.SelectedIndex = -1

        'cboValue.DataSource = objdb.GetLookUpValues(0, clsuser.UserID)
        'cboValue.DisplayMember = "lookup_value"
        'cboValue.ValueMember = "lookup_value_id"
        'cboValue.SelectedIndex = -1

        '======================Grid Items Properties======================================= 

        cbolookuptype.DataSource = objdb.GetLookUpType(0, clsuser.UserID)
        cbolookuptype.DisplayMember = "lookup_name"
        cbolookuptype.ValueMember = "lookup_id"

        'cbolookupvalue.DataSource = objdb.GetLookUpValues(0, clsuser.UserID)
        'cbolookupvalue.DisplayMember = "lookup_value"
        'cbolookupvalue.ValueMember = "lookup_value_id"

        cbolookupvalue.DataSource = objdb.GetLookUpValues(0, clsuser.UserID)
        cbolookupvalue.DisplayMember = "lookup_value"
        cbolookupvalue.ValueMember = "lookup_value_id"


        'dgvcc.SelectedIndex = -1

        'cbolookupvalue.DisplayMember = "lookup_name"
        'cbolookupvalue.ValueMember = "lookup_id"
        '==================================================================================  
        '======================= GrdApplication ==========================================
        cbolookuptype5.DataSource = objdb.GetLookUpType(0, clsuser.UserID)
        cbolookuptype5.DisplayMember = "lookup_name"
        cbolookuptype5.ValueMember = "lookup_id"

        'cbolookup_value_id5.DataSource = objdb.GetLookUpValues(0, clsuser.UserID)
        cbolookup_value_id5.DataSource = objdb.GetLookUpValuesOnlyActived(0, clsuser.UserID) 'Sitthana 20230911 used its error
        cbolookup_value_id5.DisplayMember = "lookup_value"
        cbolookup_value_id5.ValueMember = "lookup_value_id"
        '======================================================================================

        '======================= grdSub ===========================================================
        cbolookuptype6.DataSource = objdb.GetLookUpType(0, clsuser.UserID)
        cbolookuptype6.DisplayMember = "lookup_name"
        cbolookuptype6.ValueMember = "lookup_id"

        'cbolookup_value_id6.DataSource = objdb.GetLookUpValues(0, clsuser.UserID)
        cbolookup_value_id6.DataSource = objdb.GetLookUpValuesOnlyActived(0, clsuser.UserID) 'Sitthana 20230911 used its error
        cbolookup_value_id6.DisplayMember = "lookup_value"
        cbolookup_value_id6.ValueMember = "lookup_value_id"

        '==========================================================================================

        '======================== grdSPLFunction ===================================================
        cbolookuptype7.DataSource = objdb.GetLookUpType(0, clsuser.UserID)
        cbolookuptype7.DisplayMember = "lookup_name"
        cbolookuptype7.ValueMember = "lookup_id"

        'cbolookup_value_id7.DataSource = objdb.GetLookUpValues(0, clsuser.UserID)
        cbolookup_value_id7.DataSource = objdb.GetLookUpValuesOnlyActived(0, clsuser.UserID) 'Sitthana 20230911 used its error
        cbolookup_value_id7.DisplayMember = "lookup_value"
        cbolookup_value_id7.ValueMember = "lookup_value_id"
        '========================================================================================



        '======================Grid Items Category=================================================   

        cboItemsCategorySet.DataSource = objdb.GetItemsCategorySet(0, clsuser.UserID)
        cboItemsCategorySet.DisplayMember = "items_category_set_name"
        cboItemsCategorySet.ValueMember = "items_category_set_id"

        'cboItemsCategorySetId.DataSource = objdb.GetItemsCategorySet(0, clsuser.UserID)
        'cboItemsCategorySetId.DisplayMember = "items_category_set_id"
        'cboItemsCategorySetId.ValueMember = "items_category_set_id"

        cboItemsCat.DataSource = objdb.GetItemsCat("", StrItnaturecd, 0, clsuser.UserID)
        cboItemsCat.DisplayMember = "itcatdesc"
        cboItemsCat.ValueMember = "itcatcd"

        cboItemssubcat.DataSource = objdb.GetItemsSubCat("", StrItnaturecd, 0, clsuser.UserID)
        cboItemssubcat.DisplayMember = "itsubcatdesc"
        cboItemssubcat.ValueMember = "itsubcatcd"

        cboItemsGroup.DataSource = objdb.GetItemsGroup("", StrItnaturecd, 0, clsuser.UserID)
        cboItemsGroup.DisplayMember = "itgroupdesc"
        cboItemsGroup.ValueMember = "itgroupcd"

        cboItemsSub.DataSource = objdb.GetItemsSub("", StrItnaturecd, 0, clsuser.UserID)
        cboItemsSub.DisplayMember = "itsubdesc"
        cboItemsSub.ValueMember = "itsubcd"

        'Appen By Sitthana 19/12/2017
        cboItemSubgroup2.DataSource = objdb.getComboItemsSubGroup2(StrItnaturecd, 0)
        cboItemSubgroup2.DisplayMember = "items_sub_group2_desc"  'Change from items_sub_group_desc to items_sub_group2_desc  'Sitthana 27/12/2017
        cboItemSubgroup2.ValueMember = "items_sub_group2_id"
        'End Appen

        cboItemsType.DataSource = objdb.GetItemsType("", StrItnaturecd, 0, clsuser.UserID)
        cboItemsType.DisplayMember = "ittypedesc"
        cboItemsType.ValueMember = "ittypecd"

        cboItemsSub2.DataSource = objdb.GetItemsSub2("", StrItnaturecd, 0, clsuser.UserID)
        cboItemsSub2.DisplayMember = "itsubdesc2"
        cboItemsSub2.ValueMember = "itsubcd2"

        '================================================================================== 

    End Sub

    Private Sub GenGrid()

        Dim objDB As New classItemsCategory
        'Dim dtApplication As DataTable = objDB.GetCbolookupCode(5)
        'Dim dtSubAppl As DataTable = objDB.GetCbolookupCode(6)
        'Dim dtSPLFuntion As DataTable = objDB.GetCbolookupCode(7)
        'Dim dtZone As DataTable = objDB.GetCbolookupCode(8)

        Dim dtApplication As DataTable = objDB.GetCbolookupCodeOnlyActived(5) 'Sitthana 20230911
        Dim dtSubAppl As DataTable = objDB.GetCbolookupCodeOnlyActived(6) 'Sitthana 20230911
        Dim dtSPLFuntion As DataTable = objDB.GetCbolookupCodeOnlyActived(7) 'Sitthana 20230911
        Dim dtZone As DataTable = objDB.GetCbolookupCodeOnlyActived(8) 'Sitthana 20230911

        Call BindGrid(dtApplication, dtSubAppl, dtSPLFuntion, dtZone)


        'Call BindgrdItemsCategory(dtItemsCategory)
        'Call BindgrdItemsProperties(dtItemsProperties)

    End Sub

    Private Sub BindGrid(ByVal dtApplication As DataTable, ByVal dtSubAppl As DataTable, ByVal dtSPLFuntion As DataTable, ByVal dtZone As DataTable)

        grdApplication.AutoGenerateColumns = False
        grdSub.AutoGenerateColumns = False
        grdSPLFunction.AutoGenerateColumns = False
        'grdZone.AutoGenerateColumns = False

        grdApplication.DataSource = dtApplication
        grdSub.DataSource = dtSubAppl
        grdSPLFunction.DataSource = dtSPLFuntion

        'grdApplication.AllowUserToOrderColumns = False
        'grdSub.AllowUserToOrderColumns = False
        'grdSPLFunction.AllowUserToOrderColumns = False
        'grdZone.DataSource = dtZone

    End Sub

    Private Sub frmItemsCategory_FormClosing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Me.WindowState = FormWindowState.Normal
    End Sub

    Private Sub frmItemsCategory_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
        Call InitControl()
        Call InitializeDataGridView()
        Call LoadData(0, txtItemCd.Text)
        txtItemCd.Select()
    End Sub

    Private Sub btnSave_Click(sender As System.Object, e As System.EventArgs) Handles btnSave.Click
        If txtItemCd.Text.Trim = "" Then Exit Sub

        If grdItemsCategory.Focus Then
            txtItemCd.Focus()
            grdItemsCategory.EndEdit() 'Add By Neung 20151211 Fix Bug 
        End If
        If grdItemsProperties.Focus Then
            txtItemCd.Focus()
            grdItemsProperties.EndEdit() 'Add By Neung 20151211 Fix Bug User
        End If

        If grdItemsCategory.Rows.Count = 0 Then
            If MessageBox.Show("ยังไม่ได้ใส่ Item Category", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Stop) Then
                Exit Sub
            End If
        End If

        'If grdItemsProperties.Rows.Count = 0 Then
        '    If MessageBox.Show("ยังไม่ได้ใส่ Item Property", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Stop, MessageBoxDefaultButton.Button1) = Windows.Forms.DialogResult.OK Then
        '        Exit Sub
        '    End If
        'End If

        'If grdItemsCategory.EditMode Then grdItemsCategory.EndEdit()

        'Wait K.ton prepare data before use this 20190906
        'With grdItemsCategory
        '    'Sitthana 20190903 all column must had value
        '    Dim ErrorMsg As String = ""

        '    For i As Integer = 0 To .Rows.Count - 2
        '        If IsDBNull(.Rows(i).Cells("cboItemsCategorySet").Value) Then
        '            ErrorMsg &= vbCr & "Row No : " & i + 1 & " Column " & .Columns("cboItemsCategorySet").HeaderText
        '        End If
        '        If IsDBNull(.Rows(i).Cells("cboItemsCat").Value) Then
        '            ErrorMsg &= vbCr & "Row No : " & i + 1 & " Column " & .Columns("cboItemsCat").HeaderText
        '        End If
        '        If IsDBNull(.Rows(i).Cells("cboItemssubcat").Value) Then
        '            ErrorMsg &= vbCr & "Row No : " & i + 1 & " Column " & .Columns("cboItemssubcat").HeaderText
        '        End If
        '        If IsDBNull(.Rows(i).Cells("cboItemsGroup").Value) Then
        '            ErrorMsg &= vbCr & "Row No : " & i + 1 & " Column " & .Columns("cboItemsGroup").HeaderText
        '        End If
        '        If IsDBNull(.Rows(i).Cells("cboItemsSub").Value) Then
        '            ErrorMsg &= vbCr & "Row No : " & i + 1 & " Column " & .Columns("cboItemsSub").HeaderText
        '        End If
        '        If IsDBNull(.Rows(i).Cells("cboItemSubgroup2").Value) Then
        '            ErrorMsg &= vbCr & "Row No : " & i + 1 & " Column " & .Columns("cboItemSubgroup2").HeaderText
        '        End If
        '        If IsDBNull(.Rows(i).Cells("cboItemsType").Value) Then
        '            ErrorMsg &= vbCr & "Row No : " & i + 1 & " Column " & .Columns("cboItemsType").HeaderText
        '        End If
        '        If IsDBNull(.Rows(i).Cells("cboItemsSub2").Value) Then
        '            ErrorMsg &= vbCr & "Row No : " & i + 1 & " Column " & .Columns("cboItemsSub2").HeaderText
        '        End If
        '    Next
        '    If Trim(ErrorMsg) <> "" Then
        '        MessageBox.Show("คุณไม่สามารถบันทึกได้เพราะ บาง Column " & " ยังไม่มีข้อมูล ดังนี้" & ErrorMsg, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
        '        Exit Sub
        '    End If
        'End With

        If Not Validate_Design_no() Then
            MessageBox.Show("Design No. ไม่ถูกต้อง", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
            Exit Sub
        End If

        If SaveData() Then
            LoadData(0, txtItemCd.Text)
        End If
    End Sub

    Private Function SaveData() As Boolean

        Dim msgerr As String = ""
        Dim objdb As New classItemsCategory
        Dim ItemsCategory_Header As New classItemsCategory.ItemsCategory_Header
        Dim ItemsProperties_Header As New classItemsCategory.ItemsProperties_Header
        Dim Dm_Header As New classMasterUpdate.DM


        ItemsCategory_Header.items_category_id = 0
        ItemsCategory_Header.items_category_set_id = Nothing
        ItemsCategory_Header.itcd = txtItemCd.Text
        ItemsCategory_Header.itcatcd = Nothing
        ItemsCategory_Header.itsubcatcd = Nothing
        ItemsCategory_Header.itgroupcd = Nothing
        ItemsCategory_Header.itsubcd = Nothing
        ItemsCategory_Header.items_sub_group2_id = Nothing  'Add By Sitthana 20171219
        ItemsCategory_Header.ittypecd = Nothing
        ItemsCategory_Header.itsubcd2 = Nothing
        ItemsCategory_Header.creation_date = dtpitcd.Value
        ItemsCategory_Header.created_by = clsuser.UserID
        ItemsCategory_Header.last_modified_date = dtpitcd.Value
        ItemsCategory_Header.last_modified_by = clsuser.UserID
        ItemsCategory_Header.itnaturecd = cboitemsnature.SelectedValue

        ItemsCategory_Header.category_enabled = Nothing
        ItemsCategory_Header.msgerr = Nothing

        ItemsProperties_Header.items_properties_id = 0
        ItemsProperties_Header.lookup_id = Nothing
        ItemsProperties_Header.lookup_value_id = Nothing
        ItemsProperties_Header.itcd = txtItemCd.Text

        Dm_Header.h37_item_disabled = IIf(chkitem_disabled.Checked = True, "Y", IIf(chkitem_disabled.Checked = False, "N", "N"))
        Dm_Header.h38_dm_remark = txtdm_remark.Text.Trim
        'Dim dtItemsCategory As DataTable = grdItemsCategory.DataSource
        'Dim dtItemsProperties As DataTable = grdItemsProperties.DataSource

        Dim dvItemsCategory_add As New DataView(grdItemsCategory.DataSource, "", "", DataViewRowState.Added)
        Dim dvItemsCategory_upd As New DataView(grdItemsCategory.DataSource, "", "", DataViewRowState.ModifiedCurrent)
        Dim dvItemsCategory_del As New DataView(grdItemsCategory.DataSource, "", "", DataViewRowState.Deleted)

        Dim dvItemsProperties_add As New DataView(grdItemsProperties.DataSource, "", "", DataViewRowState.Added)
        Dim dvItemsProperties_upd As New DataView(grdItemsProperties.DataSource, "", "", DataViewRowState.ModifiedCurrent)
        Dim dvItemsProperties_del As New DataView(grdItemsProperties.DataSource, "", "", DataViewRowState.Deleted)

        'blnCancel = False
        Dim result As System.Windows.Forms.DialogResult
        result = MessageBox.Show("Would you like to save ?", "System Message", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button3)
        'If result = System.Windows.Forms.DialogResult.Cancel Then Exit Function
        If result <> System.Windows.Forms.DialogResult.Yes Then Exit Function

        'Dim chkitem_disabledOld As New Boolean
        'If chkitem_disabled.Checked = True Then
        '    chkitem_disabledOld = True
        'Else
        '    chkitem_disabledOld = False
        'End If

        'Dim CansendEmail As New Boolean
        'If VerifyDesignRemove() Then
        'CansendEmail = True
        'Else
        ' CansendEmail = False
        'End If
        'dvItemsCategory_add

        If objdb.ItemsCategorySave(Dm_Header, ItemsCategory_Header, ItemsProperties_Header, dvItemsCategory_add, dvItemsCategory_upd, dvItemsCategory_del, dvItemsProperties_add, dvItemsProperties_upd, dvItemsProperties_del, clsuser) Then
            MessageBox.Show("บันทึกสำเร็จ", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
            If BooleanBFitem_disabled = False And chkitem_disabled.Checked = True Then
                sending_email()
            End If
            SaveData = True

            'LoadData(0, txtItemCd.Text)

            'If chkitem_disabled.Checked = True Then
            '    If chkitem_disabledOld = False Then
            '        sending_email()
            '    End If
            'End If

            'LoadData(0, txtItemCd.Text)
        Else
            MessageBox.Show(ItemsCategory_Header.msgerr, "System Message", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
            SaveData = False
        End If
    End Function

    Private Sub grdItemsProperties_CellClick(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles grdItemsProperties.CellClick
        'Dim objdb As New classItemsCategory
        'Dim clsconfig As New clsConfig

        'If e.RowIndex = -1 Then Exit Sub
        'If e.ColumnIndex = -1 Then Exit Sub

        'If grdItemsProperties.Columns(e.ColumnIndex).Name = "cbolookupvalue" Then
        '    If IsDBNull(grdItemsProperties.Rows(e.RowIndex).Cells("cbolookuptype").Value) Or TypeOf grdItemsProperties.Rows(e.RowIndex).Cells("cbolookuptype").Value Is VariantType Or grdItemsProperties.Rows(e.RowIndex).Cells("cbolookuptype").Value Is Nothing Then
        '        MessageBox.Show("โปรดเลือก PROPERTY ", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
        '        Exit Sub
        '    Else
        '        'grdItemsProperties.Rows(e.RowIndex).Cells("cbolookupvalue").ReadOnly = False

        '    End If

        '    Dim dgvcc As New DataGridViewComboBoxCell

        '    dgvcc = grdItemsProperties.Rows(e.RowIndex).Cells("cbolookupvalue")

        '    Dim dt As New DataTable

        '    dt = objdb.GetCbolookupCode(grdItemsProperties.Rows(e.RowIndex).Cells("cbolookuptype").Value)

        '    Try
        '        dgvcc.DataSource = dt
        '        dgvcc.DisplayMember = "lookup_value"
        '        dgvcc.ValueMember = "lookup_value_id"
        '        dgvcc.Value = dt.Rows(0)("lookup_value_id") 'Fix Error
        '    Catch ex As Exception
        '        dgvcc.DataSource = dt
        '        dgvcc.DisplayMember = "lookup_value"
        '        dgvcc.ValueMember = "lookup_value_id"
        '        dgvcc.Value = Nothing
        '    End Try

        'End If
    End Sub

    Private Sub grdItemsProperties_CellEndEdit(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles grdItemsProperties.CellEndEdit
        Dim objdb As New classItemsCategory
        Dim dgvcc As New DataGridViewComboBoxCell
        Dim dt As New DataTable

        If grdItemsProperties.Columns(e.ColumnIndex).Name = "cbolookupvalue" Then
            If IsDBNull(grdItemsProperties.Rows(e.RowIndex).Cells("cbolookupvalue").Value) Or TypeOf grdItemsProperties.Rows(e.RowIndex).Cells("cbolookupvalue").Value Is VariantType Or grdItemsProperties.Rows(e.RowIndex).Cells("cbolookupvalue").Value Is Nothing Then
                dt = objdb.GetCbolookupCode(grdItemsProperties.Rows(e.RowIndex).Cells("cbolookuptype").Value)
                Try
                    dgvcc.DataSource = dt
                    dgvcc.DisplayMember = "lookup_value"
                    dgvcc.ValueMember = "lookup_value_id"
                    dgvcc.Value = dt.Rows(0)("lookup_value_id") 'Fix Error
                Catch ex As Exception
                    dgvcc.DataSource = dt
                    dgvcc.DisplayMember = "lookup_value"
                    dgvcc.ValueMember = "lookup_value_id"
                    dgvcc.Value = Nothing
                End Try

            End If
        End If
    End Sub

    Private Sub grdItemsProperties_CellValueChanged(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles grdItemsProperties.CellValueChanged
        Dim objdb As New classItemsCategory

        If grdItemsProperties.Columns(e.ColumnIndex).Name = "cbolookuptype" Then
            ' grdItemsProperties.Rows(e.RowIndex).Cells("cbolookupvalue").ReadOnly = False

            Dim dgvcc As New DataGridViewComboBoxCell

            dgvcc = grdItemsProperties.Rows(e.RowIndex).Cells("cbolookupvalue")


            Dim dt As New DataTable
            dt = objdb.GetCbolookupCode(grdItemsProperties.Rows(e.RowIndex).Cells("cbolookuptype").Value)

            If dt.Rows.Count > 0 Then
                dgvcc.DataSource = objdb.GetCbolookupCode(grdItemsProperties.Rows(e.RowIndex).Cells("cbolookuptype").Value)
                dgvcc.DisplayMember = "lookup_value"
                dgvcc.ValueMember = "lookup_value_id"
                Try
                    'dgvcc.Value = olddata 'Fix Error
                    dgvcc.Value = dt.Rows(0)("lookup_value_id") 'Fix Error
                Catch ex As Exception

                    'dgvcc.Value = Nothing
                End Try
            End If
        End If
    End Sub

    Private Sub txtItemCd_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles txtItemCd.KeyDown
        If e.KeyCode = Keys.Enter Then

            If Not Validate_Design_no(txtItemCd.Text.Trim) Or txtItemCd.Text.Trim = "" Then
                MessageBox.Show("Design No. : " & txtItemCd.Text & "............    Not Valid!!", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Stop)

                Me.Close()
                txtItemCd.Text = ""
                LoadData(0, txtItemCd.Text)
                Exit Sub
            End If

            If LoadData(0, txtItemCd.Text) Then

                'cboitemsnature.SelectedValue = StrItnaturecd
                'txtItemCd.Text = StrItcd
            Else

            End If
        End If
    End Sub

    Private Function Validate_Design_no(ByVal Design_no As String) As Boolean
        Dim objDB As New classProduction
        Dim dt As DataTable = objDB.ValidateDesignNo(Design_no, clsuser.UserID)

        If dt.Rows.Count > 0 Then
            Return True
        Else
            Return False
        End If

    End Function

    Private Function ValidateItemCD() As Boolean


    End Function

    Private Sub txtItemCd_LostFocus(sender As Object, e As System.EventArgs) Handles txtItemCd.LostFocus
        If Not Validate_Design_no(txtItemCd.Text.Trim) Or txtItemCd.Text.Trim = "" Then
            MessageBox.Show("Design No. : " & txtItemCd.Text & "............    Not Valid!!", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Me.Close()
            Exit Sub
        End If

    End Sub
    Private Sub txtItemCd_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtItemCd.TextChanged
        'Disible By Neung
        'Dim i As Integer = 0
        'For i = 0 To grdItemsCategory.Rows.Count - 2
        '    grdItemsCategory.Rows(i).Cells("txtDesigns").Value = txtItemCd.Text
        'Next

    End Sub

    'Private Sub grdItemsCategory_CellClick(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles grdItemsCategory.CellClick
    '    Dim objdb As New classItemsCategory
    '    Dim config As New clsConfig

    '    If e.ColumnIndex = -1 Then Exit Sub
    '    If e.RowIndex = -1 Then Exit Sub


    '    If grdItemsCategory.Columns(e.ColumnIndex).Name = "cboItemsCat" Then

    '        Dim dgvcc As New DataGridViewComboBoxCell
    '        dgvcc = grdItemsCategory.Rows(e.RowIndex).Cells("cboItemsCat")

    '        Dim dt As New DataTable

    '        If Not e.RowIndex <> -1 Or e.ColumnIndex <> -1 Then
    '            If Not IsDBNull(grdItemsCategory.Rows(e.RowIndex).Cells("cboItemsCategorySet").Value) Then
    '                Dim Strolddata As String
    '                If config.IsNull(grdItemsCategory.Rows(e.RowIndex).Cells("cboItemsCat").Value, "") = "" Then
    '                    Strolddata = String.Empty
    '                Else
    '                    Strolddata = grdItemsCategory.Rows(e.RowIndex).Cells("cboItemsCat").Value
    '                End If

    '                dt = objdb.GetItemsCat("", StrItnaturecd, grdItemsCategory.Rows(e.RowIndex).Cells("cboItemsCategorySet").Value, "")

    '                dgvcc.DataSource = objdb.GetItemsCat("", StrItnaturecd, grdItemsCategory.Rows(e.RowIndex).Cells("cboItemsCategorySet").Value, "")
    '                dgvcc.DisplayMember = "itcatdesc"
    '                dgvcc.ValueMember = "itcatcd"

    '                If CheckDataColumn(Strolddata, dt, dgvcc.ValueMember.ToString) Then 'Check Data In table?
    '                    dgvcc.Value = Strolddata
    '                Else
    '                    dgvcc.Value = dt.Rows(0)("itcatcd")
    '                End If

    '            Else
    '                dt = objdb.GetItemsCat("", "NONE", 0, "")

    '                dgvcc.DataSource = objdb.GetItemsCat("", "NONE", 0, "")
    '                dgvcc.DisplayMember = "itcatdesc"
    '                dgvcc.ValueMember = "itcatcd"
    '                dgvcc.Value = Nothing 'Fix Error
    '            End If
    '        End If

    '    End If

    '    If grdItemsCategory.Columns(e.ColumnIndex).Name = "cboItemssubcat" Then

    '        Dim dgvcc As New DataGridViewComboBoxCell
    '        dgvcc = grdItemsCategory.Rows(e.RowIndex).Cells("cboItemssubcat")

    '        Dim dt As New DataTable

    '        If Not e.RowIndex <> -1 Or e.ColumnIndex <> -1 Then
    '            If Not IsDBNull(grdItemsCategory.Rows(e.RowIndex).Cells("cboItemsCategorySet").Value) Then
    '                Dim Strolddata As String
    '                If config.IsNull(grdItemsCategory.Rows(e.RowIndex).Cells("cboItemssubcat").Value, "") = "" Then
    '                    Strolddata = String.Empty
    '                Else
    '                    Strolddata = grdItemsCategory.Rows(e.RowIndex).Cells("cboItemssubcat").Value
    '                End If

    '                dt = objdb.GetItemsSubCat("", StrItnaturecd, grdItemsCategory.Rows(e.RowIndex).Cells("cboItemsCategorySet").Value, "")


    '                dgvcc.DataSource = objdb.GetItemsSubCat("", StrItnaturecd, grdItemsCategory.Rows(e.RowIndex).Cells("cboItemsCategorySet").Value, "")
    '                dgvcc.DisplayMember = "itsubcatdesc"
    '                dgvcc.ValueMember = "itsubcatcd"

    '                If CheckDataColumn(Strolddata, dt, dgvcc.ValueMember.ToString) Then 'Check Data In table?
    '                    dgvcc.Value = Strolddata
    '                Else
    '                    dgvcc.Value = dt.Rows(0)(dgvcc.ValueMember.ToString)
    '                End If
    '            Else
    '                dt = objdb.GetItemsSubCat("", "NONE", 0, "")


    '                dgvcc.DataSource = objdb.GetItemsSubCat("", "NONE", 0, "")
    '                dgvcc.DisplayMember = "itsubcatdesc"
    '                dgvcc.ValueMember = "itsubcatcd"
    '                dgvcc.Value = Nothing 'Fix Error

    '            End If
    '        End If

    '    End If
    '    If grdItemsCategory.Columns(e.ColumnIndex).Name = "cboItemsGroup" Then

    '        Dim dgvcc As New DataGridViewComboBoxCell
    '        dgvcc = grdItemsCategory.Rows(e.RowIndex).Cells("cboItemsGroup")

    '        Dim dt As New DataTable

    '        If Not e.RowIndex <> -1 Or e.ColumnIndex <> -1 Then
    '            If Not IsDBNull(grdItemsCategory.Rows(e.RowIndex).Cells("cboItemsCategorySet").Value) Then
    '                Dim Strolddata As String
    '                If config.IsNull(grdItemsCategory.Rows(e.RowIndex).Cells("cboItemsGroup").Value, "") = "" Then
    '                    Strolddata = String.Empty
    '                Else
    '                    Strolddata = grdItemsCategory.Rows(e.RowIndex).Cells("cboItemsGroup").Value
    '                End If

    '                dt = objdb.GetItemsGroup("", StrItnaturecd, grdItemsCategory.Rows(e.RowIndex).Cells("cboItemsCategorySet").Value, "")

    '                dgvcc.DataSource = objdb.GetItemsGroup("", StrItnaturecd, grdItemsCategory.Rows(e.RowIndex).Cells("cboItemsCategorySet").Value, "")
    '                dgvcc.DisplayMember = "itgroupdesc"
    '                dgvcc.ValueMember = "itgroupcd"

    '                If CheckDataColumn(Strolddata, dt, dgvcc.ValueMember.ToString) Then 'Check Data In table?
    '                    dgvcc.Value = Strolddata
    '                Else
    '                    dgvcc.Value = dt.Rows(0)(dgvcc.ValueMember.ToString)
    '                End If
    '            Else
    '                dt = objdb.GetItemsGroup("", "NONE", 0, "")

    '                dgvcc.DataSource = objdb.GetItemsGroup("", "NONE", 0, "")
    '                dgvcc.DisplayMember = "itgroupdesc"
    '                dgvcc.ValueMember = "itgroupcd"
    '                dgvcc.Value = Nothing 'Fix Error
    '            End If
    '        End If

    '    End If

    '    If grdItemsCategory.Columns(e.ColumnIndex).Name = "cboItemsSub" Then

    '        Dim dgvcc As New DataGridViewComboBoxCell
    '        dgvcc = grdItemsCategory.Rows(e.RowIndex).Cells("cboItemsSub")

    '        Dim dt As New DataTable
    '        If Not e.RowIndex <> -1 Or e.ColumnIndex <> -1 Then
    '            If Not IsDBNull(grdItemsCategory.Rows(e.RowIndex).Cells("cboItemsCategorySet").Value) Then
    '                Dim Strolddata As String
    '                If config.IsNull(grdItemsCategory.Rows(e.RowIndex).Cells("cboItemsSub").Value, "") = "" Then
    '                    Strolddata = String.Empty
    '                Else
    '                    Strolddata = grdItemsCategory.Rows(e.RowIndex).Cells("cboItemsSub").Value
    '                End If

    '                dt = objdb.GetItemsSub("", StrItnaturecd, grdItemsCategory.Rows(e.RowIndex).Cells("cboItemsCategorySet").Value, "")

    '                dgvcc.DataSource = objdb.GetItemsSub("", StrItnaturecd, grdItemsCategory.Rows(e.RowIndex).Cells("cboItemsCategorySet").Value, "")
    '                dgvcc.DisplayMember = "itsubdesc"
    '                dgvcc.ValueMember = "itsubcd"

    '                If CheckDataColumn(Strolddata, dt, dgvcc.ValueMember.ToString) Then 'Check Data In table?
    '                    dgvcc.Value = Strolddata
    '                Else
    '                    dgvcc.Value = dt.Rows(0)(dgvcc.ValueMember.ToString)
    '                End If

    '            Else
    '                dt = objdb.GetItemsSub("", "NONE", 0, "")

    '                dgvcc.DataSource = objdb.GetItemsSub("", "NONE", 0, "")
    '                dgvcc.DisplayMember = "itsubdesc"
    '                dgvcc.ValueMember = "itsubcd"
    '                dgvcc.Value = Nothing 'Fix Error
    '            End If

    '        End If
    '    End If

    '    If grdItemsCategory.Columns(e.ColumnIndex).Name = "cboItemsType" Then

    '        Dim dgvcc As New DataGridViewComboBoxCell
    '        dgvcc = grdItemsCategory.Rows(e.RowIndex).Cells("cboItemsType")

    '        Dim dt As New DataTable
    '        If Not e.RowIndex <> -1 Or e.ColumnIndex <> -1 Then
    '            If Not IsDBNull(grdItemsCategory.Rows(e.RowIndex).Cells("cboItemsCategorySet").Value) Then
    '                Dim Strolddata As String
    '                If config.IsNull(grdItemsCategory.Rows(e.RowIndex).Cells("cboItemsType").Value, "") = "" Then
    '                    Strolddata = String.Empty
    '                Else
    '                    Strolddata = grdItemsCategory.Rows(e.RowIndex).Cells("cboItemsType").Value
    '                End If

    '                dt = objdb.GetItemsType("", StrItnaturecd, grdItemsCategory.Rows(e.RowIndex).Cells("cboItemsCategorySet").Value, "")

    '                dgvcc.DataSource = objdb.GetItemsType("", StrItnaturecd, grdItemsCategory.Rows(e.RowIndex).Cells("cboItemsCategorySet").Value, "")
    '                dgvcc.DisplayMember = "ittypedesc"
    '                dgvcc.ValueMember = "ittypecd"

    '                If CheckDataColumn(Strolddata, dt, dgvcc.ValueMember.ToString) Then 'Check Data In table?
    '                    dgvcc.Value = Strolddata
    '                Else
    '                    dgvcc.Value = dt.Rows(0)(dgvcc.ValueMember.ToString)
    '                End If
    '            Else
    '                dt = objdb.GetItemsType("", "NONE", 0, "")

    '                dgvcc.DataSource = objdb.GetItemsType("", "NONE", 0, "")
    '                dgvcc.DisplayMember = "ittypedesc"
    '                dgvcc.ValueMember = "ittypecd"
    '                dgvcc.Value = Nothing
    '            End If
    '        End If
    '    End If

    '    If grdItemsCategory.Columns(e.ColumnIndex).Name = "cboItemsSub2" Then

    '        Dim dgvcc As New DataGridViewComboBoxCell
    '        dgvcc = grdItemsCategory.Rows(e.RowIndex).Cells("cboItemsSub2")

    '        Dim dt As New DataTable

    '        If Not e.RowIndex <> -1 Or e.ColumnIndex <> -1 Then
    '            If Not IsDBNull(grdItemsCategory.Rows(e.RowIndex).Cells("cboItemsCategorySet").Value) Then
    '                Dim Strolddata As String
    '                If config.IsNull(grdItemsCategory.Rows(e.RowIndex).Cells("cboItemsSub2").Value, "") = "" Then
    '                    Strolddata = String.Empty
    '                Else
    '                    Strolddata = grdItemsCategory.Rows(e.RowIndex).Cells("cboItemsSub2").Value
    '                End If

    '                dgvcc.DataSource = objdb.GetItemsSub2("", StrItnaturecd, grdItemsCategory.Rows(e.RowIndex).Cells("cboItemsCategorySet").Value, "")
    '                dgvcc.DisplayMember = "itsubdesc2"
    '                dgvcc.ValueMember = "itsubcd2"
    '                If CheckDataColumn(Strolddata, dt, dgvcc.ValueMember.ToString) Then 'Check Data In table?
    '                    dgvcc.Value = Strolddata
    '                Else
    '                    'dgvcc.Value = dt.Rows(0)(dgvcc.ValueMember.ToString)
    '                    dgvcc.Value = Strolddata
    '                End If

    '            Else
    '                dt = objdb.GetItemsSub2("", "NONE", 0, "")

    '                dgvcc.DataSource = objdb.GetItemsSub2("", "NONE", 0, "")
    '                dgvcc.DisplayMember = "itsubdesc2"
    '                dgvcc.ValueMember = "itsubcd2"
    '                dgvcc.Value = Nothing
    '            End If
    '        End If
    '    End If

    'End Sub

    'Private Sub grdItemsCategory_CellValueChanged(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles grdItemsCategory.CellValueChanged
    '    Dim objdb As New classItemsCategory

    '    If grdItemsCategory.Columns(e.ColumnIndex).Name = "cboItemsCategorySet" Then

    '        Dim dgvcc As New DataGridViewComboBoxCell
    '        dgvcc = grdItemsCategory.Rows(e.RowIndex).Cells("cboItemsCat")

    '        Dim dt As New DataTable
    '        dt = objdb.GetItemsCat("", StrItnaturecd, grdItemsCategory.Rows(e.RowIndex).Cells("cboItemsCategorySet").Value, "")


    '        dgvcc.DataSource = objdb.GetItemsCat("", StrItnaturecd, grdItemsCategory.Rows(e.RowIndex).Cells("cboItemsCategorySet").Value, "")
    '        dgvcc.DisplayMember = "itcatdesc"
    '        dgvcc.ValueMember = "itcatcd"
    '        Try
    '            dgvcc.Value = dt.Rows(0)("itcatcd") 'Fix Error
    '        Catch ex As Exception
    '            dgvcc.Value = Nothing
    '        End Try
    '    End If

    '    If grdItemsCategory.Columns(e.ColumnIndex).Name = "cboItemsCategorySet" Then

    '        Dim dgvcc As New DataGridViewComboBoxCell
    '        dgvcc = grdItemsCategory.Rows(e.RowIndex).Cells("cboItemssubcat")

    '        Dim dt As New DataTable
    '        dt = objdb.GetItemsSubCat("", StrItnaturecd, grdItemsCategory.Rows(e.RowIndex).Cells("cboItemsCategorySet").Value, "")


    '        dgvcc.DataSource = objdb.GetItemsSubCat("", StrItnaturecd, grdItemsCategory.Rows(e.RowIndex).Cells("cboItemsCategorySet").Value, "")
    '        dgvcc.DisplayMember = "itsubcatdesc"
    '        dgvcc.ValueMember = "itsubcatcd"
    '        Try
    '            dgvcc.Value = dt.Rows(0)("itsubcatcd") 'Fix Error
    '        Catch ex As Exception
    '            dgvcc.Value = Nothing
    '        End Try
    '    End If

    '    If grdItemsCategory.Columns(e.ColumnIndex).Name = "cboItemsCategorySet" Then

    '        Dim dgvcc As New DataGridViewComboBoxCell
    '        dgvcc = grdItemsCategory.Rows(e.RowIndex).Cells("cboItemsGroup")

    '        Dim dt As New DataTable
    '        dt = objdb.GetItemsGroup("", StrItnaturecd, grdItemsCategory.Rows(e.RowIndex).Cells("cboItemsCategorySet").Value, "")

    '        dgvcc.DataSource = objdb.GetItemsGroup("", StrItnaturecd, grdItemsCategory.Rows(e.RowIndex).Cells("cboItemsCategorySet").Value, "")
    '        dgvcc.DisplayMember = "itgroupdesc"
    '        dgvcc.ValueMember = "itgroupcd"
    '        Try
    '            dgvcc.Value = dt.Rows(0)("itgroupcd") 'Fix Error
    '        Catch ex As Exception
    '            dgvcc.Value = Nothing
    '        End Try
    '    End If

    '    If grdItemsCategory.Columns(e.ColumnIndex).Name = "cboItemsCategorySet" Then

    '        Dim dgvcc As New DataGridViewComboBoxCell
    '        dgvcc = grdItemsCategory.Rows(e.RowIndex).Cells("cboItemsSub")

    '        Dim dt As New DataTable
    '        dt = objdb.GetItemsSub("", StrItnaturecd, grdItemsCategory.Rows(e.RowIndex).Cells("cboItemsCategorySet").Value, "")

    '        dgvcc.DataSource = objdb.GetItemsSub("", StrItnaturecd, grdItemsCategory.Rows(e.RowIndex).Cells("cboItemsCategorySet").Value, "")
    '        dgvcc.DisplayMember = "itsubdesc"
    '        dgvcc.ValueMember = "itsubcd"
    '        Try
    '            dgvcc.Value = dt.Rows(0)("itsubcd") 'Fix Error
    '        Catch ex As Exception
    '            dgvcc.Value = Nothing
    '        End Try
    '    End If

    '    If grdItemsCategory.Columns(e.ColumnIndex).Name = "cboItemsCategorySet" Then

    '        Dim dgvcc As New DataGridViewComboBoxCell
    '        dgvcc = grdItemsCategory.Rows(e.RowIndex).Cells("cboItemsType")

    '        Dim dt As New DataTable
    '        dt = objdb.GetItemsType("", StrItnaturecd, grdItemsCategory.Rows(e.RowIndex).Cells("cboItemsCategorySet").Value, "")

    '        dgvcc.DataSource = objdb.GetItemsType("", StrItnaturecd, grdItemsCategory.Rows(e.RowIndex).Cells("cboItemsCategorySet").Value, "")
    '        dgvcc.DisplayMember = "ittypedesc"
    '        dgvcc.ValueMember = "ittypecd"
    '        Try
    '            dgvcc.Value = dt.Rows(0)("ittypecd") 'Fix Error
    '        Catch ex As Exception
    '            dgvcc.Value = Nothing
    '        End Try


    '    End If

    '    If grdItemsCategory.Columns(e.ColumnIndex).Name = "cboItemsCategorySet" Then

    '        Dim dgvcc As New DataGridViewComboBoxCell
    '        dgvcc = grdItemsCategory.Rows(e.RowIndex).Cells("cboItemsSub2")

    '        Dim dt As New DataTable
    '        dt = objdb.GetItemsSub2("", StrItnaturecd, grdItemsCategory.Rows(e.RowIndex).Cells("cboItemsCategorySet").Value, "")

    '        dgvcc.DataSource = objdb.GetItemsSub2("", StrItnaturecd, grdItemsCategory.Rows(e.RowIndex).Cells("cboItemsCategorySet").Value, "")
    '        dgvcc.DisplayMember = "itsubdesc2"
    '        dgvcc.ValueMember = "itsubcd2"
    '        'dgvcc.Value = dt.Rows(0)("ittypecd") 'Fix Error
    '        Try
    '            dgvcc.Value = dt.Rows(0)("itsubcd2") 'Fix Error
    '            'dgvcc.Value = Nothing 'Fix Error
    '        Catch ex As Exception
    '            dgvcc.Value = Nothing
    '        End Try

    '    End If

    'End Sub

    Private Sub SetControlValue(ByVal Obj As Control)
        If TypeOf Obj Is TextBox Then
            Obj.Text = Obj.Tag
        End If
        If TypeOf Obj Is DateTimePicker Then
            Dim dtp As DateTimePicker = Obj
            dtp.Value = Now
        End If
        If TypeOf Obj Is ComboBox Then
            Dim cbo As ComboBox = Obj
            cbo.SelectedValue = 0
        End If
        If TypeOf Obj Is CheckBox Then
            Dim chk As CheckBox = Obj
            chk.Checked = False
        End If
        If TypeOf Obj Is RadioButton Then
            Dim opt As RadioButton = Obj
            opt.Checked = False
        End If
        If TypeOf Obj Is TabControl Or TypeOf Obj Is TabPage Or TypeOf Obj Is GroupBox Then
            Dim obj2 As Control
            For Each obj2 In Obj.Controls
                Call SetControlValue(obj2)
            Next
        End If
    End Sub

    Private Function Validate_Design_no() As Boolean
        Dim objDB As New classProduction
        Dim dt As DataTable = objDB.ValidateDesignNo(txtItemCd.Text.Trim, clsuser.UserID)

        If dt.Rows.Count = 0 Then
            Return False
        End If
        Return True
    End Function

    Private Sub mDGV_CellValidating(ByVal sender As Object, ByVal e As DataGridViewCellValidatingEventArgs)
        Dim dgv As DataGridView = DirectCast(sender, DataGridView)
        Dim cell As DataGridViewComboBoxCell = TryCast(dgv.CurrentCell, DataGridViewComboBoxCell)

        If cell IsNot Nothing AndAlso Not cell.Items.Contains(e.FormattedValue) Then

            ' Insert the new value into position 0
            ' in the item collection of the cell
            cell.Items.Insert(0, e.FormattedValue)
            ' When setting the Value of the cell, the  
            ' string is not shown until it has been
            ' comitted. The code below will make sure 
            ' it is committed directly.
            If dgv.IsCurrentCellDirty Then
                ' Ensure the inserted value will 
                ' be shown directly.
                ' First tell the DataGridView to commit 
                ' itself using the Commit context...
                dgv.CommitEdit(DataGridViewDataErrorContexts.Commit)
            End If
            ' ...then set the Value that needs 
            ' to be committed in order to be displayed directly.
            cell.Value = cell.Items(0)
        End If
    End Sub

    Private Sub btnApply_Click(sender As System.Object, e As System.EventArgs) Handles btnApply.Click
        BindData()
    End Sub
    Private Sub BindData() '(ByVal dt As DataTable)
        Dim config As New clsConfig
        If cboValue.SelectedIndex = -1 Then Exit Sub
        If cboproperty.SelectedIndex = -1 Then Exit Sub

        grdItemsProperties.AutoGenerateColumns = False
        ' If dt.Rows.Count > 0 Then
        'Dim dt1 As DataTable = dt
        Dim dt2 As DataTable = grdItemsProperties.DataSource

        Dim dr As DataRow

        Dim msg As String = ""
        Dim i As Integer = 0
        Dim j As Integer = 0
        'For i = 0 To dt.Rows.Count - 1

        'For i = 0 To dt2.Rows.Count - 1
        If CheckDuplicate(Me.cboproperty.SelectedValue, Me.cboValue.SelectedValue, dt2) Then
            MessageBox.Show("ข้อมูลซ้ำกัน", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Exit Sub
        End If
        ' If dt2.Rows(i)("lookup_value_id").ToString.Trim = Me.cboValue.SelectedValue And dt2.Rows(i)("lookup_id").ToString.Trim = Me.cboproperty.SelectedValue Then
        'MessageBox.Show("ข้อมูลซ้ำกัน", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Stop)
        'Exit Sub
        ' End If
        'Next

        dr = dt2.NewRow

        For j = 0 To dt2.Columns.Count - 1
            '(dt.Rows(0)("packdt").ToString)
            dr("lookup_id") = Me.cboproperty.SelectedValue
            dr("lookup_value_id") = Me.cboValue.SelectedValue
        Next
        dt2.Rows.Add(dr)
        'grdItemsProperties.DataSource = dt2
        ' Next

        'End If
        ' Call SumGrdPackingList()


        'grdDataPackingList.DataSource = dt
        'txtReqNo.Text = dt.Rows(0)("outreqno").ToString()
    End Sub

    Private Function CheckDuplicate(ByVal lookup_id As String, ByVal lookup_value_id As String, ByVal dt As DataTable) As Boolean
        If dt IsNot Nothing Then
            If dt.Rows.Count > 0 Then
                Dim i As Integer = 0
                For i = 0 To dt.Rows.Count - 1
                    If dt.Rows(i).RowState <> DataRowState.Deleted Then
                        If dt.Rows(i)("lookup_value_id").ToString.Trim = lookup_value_id And dt.Rows(i)("lookup_id").ToString.Trim = lookup_id Then Return True
                    End If
                Next
            End If
        End If

        Return False
    End Function

    Private Function CheckDataColumn(ByVal StrItem As String, ByVal dt As DataTable, ByVal StrColumnName As String) As Boolean
        If dt.Rows.Count > 0 Then
            Dim i As Integer = 0
            For i = 0 To dt.Rows.Count - 1
                If dt.Rows(i).RowState <> DataRowState.Deleted Then
                    If dt.Rows(i)(StrColumnName).ToString.Trim = StrItem.Trim Then Return True
                End If
            Next
        End If
        Return False

    End Function

    Private Sub cboproperty_DropDownClosed(sender As Object, e As System.EventArgs) Handles cboproperty.DropDownClosed
        Dim objdb As New classItemsCategory
        ' grdItemsProperties.Rows(e.RowIndex).Cells("cbolookupvalue").ReadOnly = False
        If cboproperty.SelectedValue Is Nothing Then Exit Sub

        Dim dgvcc As New ComboBox

        dgvcc = cboValue

        dgvcc.DataSource = objdb.GetCbolookupCode(cboproperty.SelectedValue)
        'dgvcc.DisplayMember = "lookup_name"
        'dgvcc.ValueMember = "lookup_id"

        dgvcc.DisplayMember = "lookup_value"
        dgvcc.ValueMember = "lookup_value_id"
        dgvcc.SelectedIndex = -1
    End Sub
    Private Sub GetLookUpValues(Optional ByRef Intlookup_id As Integer = 0, Optional ByRef sender As System.Object = Nothing, Optional ByRef e As System.EventArgs = Nothing)

        Dim objdb As New classItemsCategory

        Dim dt As DataTable = objdb.GetLookUpValues(Intlookup_id, clsuser.UserID)
        Dim dr As DataRow
        Dim dtValues As New DataTable

        dtValues.Columns.Add("lookup_value")
        dtValues.Columns.Add("lookup_value_id")

        If dt.Rows.Count > 0 Then

            For i = 0 To dt.Rows.Count - 1
                dr = dtValues.NewRow()

                For j = 0 To dt.Columns.Count - 1
                    dr("lookup_value") = dt.Rows(i)("lookup_value")
                    dr("lookup_value_id") = dt.Rows(i)("lookup_value_id")

                Next
                dtValues.Rows.Add(dr)

            Next

            cboValue.DataSource = objdb.GetLookUpValuesOnlyActived(0, clsuser.UserID)
            cboValue.DisplayMember = "lookup_value"
            cboValue.ValueMember = "lookup_value_id"
            cboValue.SelectedIndex = 0

            cboValue.DataSource = dtValues

        End If
    End Sub

    Private Sub btnSearchItems_Click(sender As System.Object, e As System.EventArgs) Handles btnSearchItems.Click
        'Dim frm As New frmSalesOrderSearch
        'frm.ShowDialog(Me)
        Me.Cursor = Cursors.WaitCursor
        'If Not blnCancel Then cboSoNo.SelectedValue = frm.pSoNo
        Me.Cursor = Cursors.Default
        ' frm.Dispose()
    End Sub

    Private Sub grdItemsCategory_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs)
        If e.KeyCode = Keys.Delete Then

        End If
    End Sub

    Private Sub Control_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs)
        'Dim ErrorMessage As String

        If ((e.KeyCode = Keys.Delete) And (Me.grdItemsCategory.SelectedRows.Count > 0)) Then

            Try
                Me.grdItemsCategory.Rows.Remove(Me.grdItemsCategory.SelectedRows.Item(0))
                e.Handled = True
            Catch ex As Exception
                'ErrorMessage = ex.Message
                MessageBox.Show(ex.Message, "System Message!", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
                e.Handled = False
            End Try
            'e.Handled = True
        End If
    End Sub

    'Private Sub grdItemsCategory_EditingControlShowing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewEditingControlShowingEventArgs) Handles grdItemsCategory.EditingControlShowing
    '    'AddHandler e.Control.KeyDown, New KeyEventHandler(AddressOf Me.Control_KeyDown) 'Sitthana Comment 20181217
    'End Sub

    Private Sub btnAdd_Click(sender As System.Object, e As System.EventArgs) Handles btnAdd.Click
        BindData2()
    End Sub

    Private Sub BindData2() '(ByVal dt As DataTable)
        Dim config As New clsConfig

        grdItemsProperties.AutoGenerateColumns = False

        Dim dtApplication As DataTable = grdApplication.DataSource
        Dim dtSub As DataTable = grdSub.DataSource
        Dim dtSPLFunction As DataTable = grdSPLFunction.DataSource


        Dim dtItemsProperties As DataTable = grdItemsProperties.DataSource

        Dim dr As DataRow

        Dim msg As String = ""
        Dim i As Integer = 0
        Dim j As Integer = 0

        For i = 0 To dtApplication.Rows.Count - 1
            If CBool(dtApplication.Rows(i)("sel")) Then
                If CheckDuplicate(dtApplication.Rows(i)("lookup_id").ToString.Trim, dtApplication.Rows(i)("lookup_value_id").ToString.Trim, dtItemsProperties) Then
                    MessageBox.Show("ข้อมูลซ้ำกัน", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                    clearAllItems(dtApplication)
                    'Exit Sub
                Else
                    dr = dtItemsProperties.NewRow

                    For j = 0 To dtItemsProperties.Columns.Count - 1
                        dr("lookup_id") = dtApplication.Rows(i)("lookup_id").ToString.Trim
                        dr("lookup_value_id") = dtApplication.Rows(i)("lookup_value_id").ToString.Trim
                    Next
                    dtItemsProperties.Rows.Add(dr)
                End If

            End If
        Next

        For i = 0 To dtSub.Rows.Count - 1
            If CBool(dtSub.Rows(i)("sel")) Then
                If CheckDuplicate(dtSub.Rows(i)("lookup_id").ToString.Trim, dtSub.Rows(i)("lookup_value_id").ToString.Trim, dtItemsProperties) Then
                    MessageBox.Show("ข้อมูลซ้ำกัน", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                    clearAllItems(dtSub)
                    'Exit Sub
                Else
                    dr = dtItemsProperties.NewRow

                    For j = 0 To dtItemsProperties.Columns.Count - 1
                        dr("lookup_id") = dtSub.Rows(i)("lookup_id").ToString.Trim
                        dr("lookup_value_id") = dtSub.Rows(i)("lookup_value_id").ToString.Trim
                    Next
                    dtItemsProperties.Rows.Add(dr)
                End If

            End If
        Next

        For i = 0 To dtSPLFunction.Rows.Count - 1
            If CBool(dtSPLFunction.Rows(i)("sel")) Then
                If CheckDuplicate(dtSPLFunction.Rows(i)("lookup_id").ToString.Trim, dtSPLFunction.Rows(i)("lookup_value_id").ToString.Trim, dtItemsProperties) Then
                    MessageBox.Show("ข้อมูลซ้ำกัน", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                    clearAllItems(dtSPLFunction)
                    'Exit Sub
                Else

                    dr = dtItemsProperties.NewRow

                    For j = 0 To dtItemsProperties.Columns.Count - 1
                        dr("lookup_id") = dtSPLFunction.Rows(i)("lookup_id").ToString.Trim
                        dr("lookup_value_id") = dtSPLFunction.Rows(i)("lookup_value_id").ToString.Trim
                    Next
                    dtItemsProperties.Rows.Add(dr)
                End If

            End If
        Next

        clearAllItems(dtApplication)
        clearAllItems(dtSub)
        clearAllItems(dtSPLFunction)

        'grdItemsProperties.DataSource = dt2
        ' Next

        'End If
        ' Call SumGrdPackingList()


        'grdDataPackingList.DataSource = dt
        'txtReqNo.Text = dt.Rows(0)("outreqno").ToString()
    End Sub

    Private Sub clearAllItems(ByRef dt As DataTable)
        Dim i As Integer


        If dt.Rows.Count = 0 Then Exit Sub 'And Me.DgYarn_in.Rows(1).Cells(1).ToString = ""
        Try
            For i = 0 To dt.Rows.Count - 1
                If CBool(dt.Rows(i)("sel")) = True Then dt.Rows(i)("sel") = False
            Next
        Catch ex As Exception

        End Try
    End Sub

    Private Function CheckDuplicate2(ByVal lookup_id As String, ByVal lookup_value_id As String, ByVal dt As DataTable) As Boolean
        If dt.Rows.Count > 0 Then
            Dim i As Integer = 0
            For i = 0 To dt.Rows.Count - 1
                If dt.Rows(i).RowState <> DataRowState.Deleted Then
                    If dt.Rows(i)("lookup_value_id").ToString.Trim = lookup_value_id And dt.Rows(i)("lookup_id").ToString.Trim = lookup_id Then Return True
                End If
            Next
        End If
        Return False
    End Function

    Private Sub grdApplication_CellClick(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles grdApplication.CellClick
        Dim dtApplication As DataTable = grdApplication.DataSource
        Dim RowIndex As Integer = e.RowIndex
        Dim ColumnIndex As Integer = e.ColumnIndex

        ChangeSel2(grdApplication, RowIndex, ColumnIndex)




        ''If grdApplication.Columns(e.ColumnIndex).Name = "cbolookup_value_id5" Then
        ''If grdApplication.Columns(e.ColumnIndex).Name <> "sel" Then
        ''ChangeSel(dtApplication, RowIndex, ColumnIndex)
        ''ChangeSel2(grdApplication, RowIndex, ColumnIndex)
        ''End If

    End Sub

    Private Sub ChangeSel(ByVal dt As DataTable, ByVal RowIndex As Integer, ByVal ColumnIndex As Integer)
        Try
            If CBool(dt.Rows(RowIndex)("sel")) = True Then
                dt.Rows(RowIndex)("sel") = False
            ElseIf CBool(dt.Rows(RowIndex)("sel")) = False Then
                dt.Rows(RowIndex)("sel") = True
            End If
        Catch ex As Exception

        End Try

    End Sub

    Private Sub ChangeSel2(ByVal grd As DataGridView, ByVal RowIndex As Integer, ByVal ColumnIndex As Integer)

        Try
            If CBool(grd.Rows(RowIndex).Cells(0).Value) = True Then
                grd.Rows(RowIndex).Cells(0).Value = False
            ElseIf CBool(grd.Rows(RowIndex).Cells(0).Value) = False Then
                grd.Rows(RowIndex).Cells(0).Value = True
            End If
        Catch ex As Exception

        End Try

    End Sub

    Private Sub grdSub_CellClick(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles grdSub.CellClick
        Dim dtdSub As DataTable = grdSub.DataSource
        Dim RowIndex As Integer = e.RowIndex
        Dim ColumnIndex As Integer = e.ColumnIndex

        ChangeSel2(grdSub, RowIndex, ColumnIndex)



        ''If grdSub.Columns(e.ColumnIndex).Name = "cbolookup_value_id6" Then
        ''If grdSub.Columns(e.ColumnIndex).Name <> "sel" Then

        ''ChangeSel(dtdSub, RowIndex, ColumnIndex)
        ''ChangeSel2(grdSub, RowIndex, ColumnIndex)
        ''End If
    End Sub


    Private Sub grdSPLFunction_CellClick(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles grdSPLFunction.CellClick
        Dim dtSPLFunction As DataTable = grdSPLFunction.DataSource
        Dim RowIndex As Integer = e.RowIndex
        Dim ColumnIndex As Integer = e.ColumnIndex

        ChangeSel2(grdSPLFunction, RowIndex, ColumnIndex)



        ''If grdSPLFunction.Columns(e.ColumnIndex).Name = "cbolookup_value_id7" Then
        ''If grdSub.Columns(e.ColumnIndex).Name <> "sel" Then
        ''ChangeSel(dtSPLFunction, RowIndex, ColumnIndex)
        ''ChangeSel2(grdSPLFunction, RowIndex, ColumnIndex)
        ''End If
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs)
        grdApplication.AllowUserToOrderColumns = False
    End Sub

    Private Sub btnPrintReportViewer_Click(sender As System.Object, e As System.EventArgs)

        Dim dt As New DataTable


        dt = grdItemsCategory.DataSource
        Dim ds As New DataSet

        'Dim rv1 As New ReportViewer
        Dim rds As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource
        Dim clsconfig As New clsConfig
        Dim rptFileName = "rptItemsCategory.rdlc"
        ' ''If clsuser.ReportPath = "" Then clsuser.ReportPath = clsConfig.ReportPath
        If Not clsconfig.CheckReport(clsuser.ReportPath, rptFileName) Then Exit Sub
        Dim frm As New frmReportViewer
        Dim rv As ReportViewer
        rv = frm.rv

        frm.rv.LocalReport.DisplayName = "Items Category"
        frm.rv.ProcessingMode = ProcessingMode.Local
        Dim localReport As LocalReport
        localReport = frm.rv.LocalReport
        localReport.ReportPath = (clsuser.ReportPath & rptFileName)

        Dim itcd = New ReportParameter("itcd", txtItemCd.Text.Trim)
        Dim items_category_id = New ReportParameter("items_category_id", 0)
        Dim logempcd = New ReportParameter("logempcd", clsuser.UserID)
        localReport.SetParameters(itcd)
        localReport.SetParameters(items_category_id)
        localReport.SetParameters(logempcd)


        frm.rv.LocalReport.GetParameters()
        frm.rv.RefreshReport()

        frm.MdiParent = Me.ParentForm
        frm.Title = "Items Category"
        frm.Show()




        'frm.rv1.Reset()
        'frm.rv1.LocalReport.ReportEmbeddedResource = (clsuser.ReportPath & rptFileName)

        'Dim RDS1 As ReportDataSource = New ReportDataSource("Test Report", dt)

        'frm.rv1.LocalReport.DataSources.Clear()
        'frm.rv1.ProcessingMode = ProcessingMode.Local
        'frm.rv1.LocalReport.EnableExternalImages = True
        'frm.rv1.LocalReport.ReportEmbeddedResource = (clsuser.ReportPath & rptFileName)
        'frm.rv1.LocalReport.DataSources.Add(RDS1)

        'frm.ReportViewer1.ServerReport.ReportServerUrl = New Uri("http://SERVERNAME/ReportServer")
        'frm.rv1.ServerReport.ReportPath = (clsuser.ReportPath & rptFileName)

        'frm.rv.Reset()
        'frm.rv.ProcessingMode = ProcessingMode.Local
        'frm.rv.LocalReport.ReportPath = ("ProductionSystem." & rptFileName)
        'Dim test As String

        'test = frm.rv.LocalReport.ReportPath

        'frm.rv.LocalReport.DisplayName = "Items Category"


        'frm.ReportViewer1.LocalReport.DataSources.Clear()

        'rpt.DataSourceConnections.Item(0).SetConnection(clsConn.servername, clsConn.database, False)
        'rpt.DataSourceConnections.Item(0).SetLogon(clsConn.Userid, clsConn.Password)
        'rpt.VerifyDatabase()


        'frm.rv.LocalReport.DisplayName = "Items Category"
        'frm.rv.ProcessingMode = ProcessingMode.Local

        'Dim localReport As LocalReport
        'localReport = frm.rv.LocalReport
        'localReport.ReportEmbeddedResource = ("ProductionSystem." & rptFileName)
        'localReport.ReportPath = (clsuser.ReportPath & rptFileName)

        'frm.rv.ProcessingMode = ProcessingMode.Remote
        'Dim ServerReport As ServerReport
        'ServerReport = frm.rv.ServerReport
        'ServerReport.ReportPath = (clsuser.ReportPath & rptFileName)

        '"ReportViewerIntro.Sales Order Detail.rdlc"

        'Dim rprtDTSource = New Microsoft.Reporting.WinForms.ReportDataSource(dt.TableName, dt)
        'Dim itcd = New ReportParameter("itcd", txtItemCd.Text.Trim)
        'Dim items_category_id = New ReportParameter("items_category_id", 0)
        'Dim logempcd = New ReportParameter("logempcd", clsuser.UserID)
        'frm.rv.LocalReport.SetParameters(itcd)
        'frm.rv.LocalReport.SetParameters(items_category_id)
        'frm.rv.LocalReport.SetParameters(logempcd)

        'frm.rv.LocalReport.GetParameters()
        ' frm.ReportViewer1.LocalReport.DataSources.Add(rprtDTSource)

        'frm.rv1.DataBindings()

        'frm.rv.RefreshReport()


        'frm.MdiParent = Me.ParentForm
        'frm.Title = "Items Category"
        'frm.Show()


    End Sub

    Private Sub BtnPrint2_Click(sender As System.Object, e As System.EventArgs)
        Dim clsconfig As New clsConfig
        Const rptFileName = "rptInventoryCategory.rpt" 'Only For 1 Design

        ' ''If clsuser.ReportPath = "" Then clsuser.ReportPath = clsConfig.ReportPath
        If Not clsconfig.CheckReport(clsuser.ReportPath, rptFileName) Then Exit Sub
        Dim frm As New frmReport
        Dim rpt As New CrystalDecisions.CrystalReports.Engine.ReportDocument
        Me.Cursor = Cursors.WaitCursor
        rpt.Load(clsuser.ReportPath & rptFileName)
        rpt.DataSourceConnections.Item(0).SetConnection(clsConn.servername, clsConn.database, False)
        rpt.DataSourceConnections.Item(0).SetLogon(clsConn.Userid, clsConn.Password)
        rpt.VerifyDatabase()

        rpt.SetParameterValue("@items_category_id", 0)
        rpt.SetParameterValue("@itcd", txtItemCd.Text.Trim)
        rpt.SetParameterValue("@logempcd", clsuser.UserID)

        rpt.SetParameterValue("@Title", "Inventory Category")

        frm.Title = "Inventory Category"
        frm.CRViewer.ReportSource = rpt
        frm.MdiParent = Me.ParentForm
        frm.Show()
        Me.Cursor = Cursors.Default
    End Sub

    Private Function VerifyDesignRemove() As Boolean
        Dim objdb As New classItemsCategory
        Dim clsconfig As New clsConfig
        Dim dt As DataTable = objdb.VerifyDesignRemoved(txtItemCd.Text.Trim, IIf(chkitem_disabled.Checked, "Y", "N"))

        If dt.Rows.Count > 0 Then
            If IIf(dt.Rows(0)("item_disabled").ToString = "Y", True, False) Then
                Return True
            Else
                Return False
            End If
        Else : Return False

        End If

    End Function
    Private Function SaveDataRemove() As Boolean

        If VerifyDesignRemove() Then
            Return True
        Else
            Return False
            'Try
            '    Dim Smtp_Server As New SmtpClient
            '    Dim e_mail As New MailMessage()
            '    Dim Body As String = "Design No." & txtItemCd.Text.Trim.ToString & " : Removing Already "

            '    Smtp_Server.UseDefaultCredentials = False
            '    Smtp_Server.Credentials = New Net.NetworkCredential("noreply@gemmaknits.com", "shk,9v]d]y[")
            '    Smtp_Server.Port = 25
            '    Smtp_Server.EnableSsl = False
            '    Smtp_Server.Host = "mail.gemmaknits.com"

            '    e_mail = New MailMessage()
            '    e_mail.From = New MailAddress("noreply@gemmaknits.com")
            '    e_mail.To.Add("kanyarat@gemmaknits.com")
            '    e_mail.To.Add("sampleroom@gemmaknits.com")
            '    e_mail.To.Add("sureewat@gemmaknits.com")
            '    e_mail.To.Add("supapat@gemmaknits.com")
            '    e_mail.To.Add("joylin@gemmaknits.com")

            '    e_mail.Subject = "แจ้งการถอดถอนดีไซน์ / Notice of Removing Design"

            '    e_mail.IsBodyHtml = False
            '    e_mail.Body = Body
            '    Smtp_Server.Send(e_mail)

            'Catch error_t As Exception
            '    MsgBox(error_t.ToString)
            'End Try
        End If


        'Dim msgerr As String = ""
        'Dim objdb As New classItemsCategory
        'Dim ItemsCategory_Header As New classItemsCategory.ItemsCategory_Header
        'Dim ItemsProperties_Header As New classItemsCategory.ItemsProperties_Header
        'Dim Dm_Header As New classMasterUpdate.DM


        'ItemsCategory_Header.items_category_id = 0
        'ItemsCategory_Header.items_category_set_id = Nothing
        'ItemsCategory_Header.itcd = txtItemCd.Text
        'ItemsCategory_Header.itcatcd = Nothing
        'ItemsCategory_Header.itsubcatcd = Nothing
        'ItemsCategory_Header.itgroupcd = Nothing
        'ItemsCategory_Header.itsubcd = Nothing
        'ItemsCategory_Header.ittypecd = Nothing
        'ItemsCategory_Header.itsubcd2 = Nothing
        'ItemsCategory_Header.creation_date = dtpitcd.Value
        'ItemsCategory_Header.created_by = clsuser.UserID
        'ItemsCategory_Header.last_modified_date = dtpitcd.Value
        'ItemsCategory_Header.last_modified_by = clsuser.UserID
        'ItemsCategory_Header.itnaturecd = cboitemsnature.SelectedValue

        'ItemsCategory_Header.category_enabled = Nothing
        'ItemsCategory_Header.msgerr = Nothing

        'ItemsProperties_Header.items_properties_id = 0
        'ItemsProperties_Header.lookup_id = Nothing
        'ItemsProperties_Header.lookup_value_id = Nothing
        'ItemsProperties_Header.itcd = txtItemCd.Text

        'Dm_Header.h37_item_disabled = IIf(chkitem_disabled.Checked = True, "Y", IIf(chkitem_disabled.Checked = False, "N", ""))
        'Dm_Header.h38_dm_remark = txtdm_remark.Text.Trim

        'Dim dvItemsCategory_add As New DataView(grdItemsCategory.DataSource, "", "", DataViewRowState.Added)
        'Dim dvItemsCategory_upd As New DataView(grdItemsCategory.DataSource, "", "", DataViewRowState.ModifiedCurrent)
        'Dim dvItemsCategory_del As New DataView(grdItemsCategory.DataSource, "", "", DataViewRowState.Deleted)

        'Dim dvItemsProperties_add As New DataView(grdItemsProperties.DataSource, "", "", DataViewRowState.Added)
        'Dim dvItemsProperties_upd As New DataView(grdItemsProperties.DataSource, "", "", DataViewRowState.ModifiedCurrent)
        'Dim dvItemsProperties_del As New DataView(grdItemsProperties.DataSource, "", "", DataViewRowState.Deleted)


        'If objdb.SaveItemDisible(Dm_Header, ItemsCategory_Header, ItemsProperties_Header, dvItemsCategory_add, dvItemsCategory_upd, dvItemsCategory_del, dvItemsProperties_add, dvItemsProperties_upd, dvItemsProperties_del, clsuser) Then
        '    SaveDataRemove = True
        'Else
        '    MessageBox.Show(ItemsCategory_Header.msgerr, "System Message", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
        '    SaveDataRemove = False
        'End If
    End Function
    Private Sub sending_email()
        Try
            Dim Smtp_Server As New SmtpClient
            Dim e_mail As New MailMessage()
            Dim Body As String = "Design No." & txtItemCd.Text.Trim.ToString & " : Removing Already "

            Smtp_Server.UseDefaultCredentials = False
            Smtp_Server.Credentials = New Net.NetworkCredential("wf@gemmaknits.com", "8tSGadgeR%AP")
            Smtp_Server.Port = 25
            Smtp_Server.EnableSsl = False
            Smtp_Server.Host = "mail.gemmaknits.com"

            e_mail = New MailMessage()
            e_mail.From = New MailAddress("noreply@gemmaknits.com")
            e_mail.To.Add("kanyarat@gemmaknits.com")
            e_mail.CC.Add("sampleroom@gemmaknits.com")
            e_mail.CC.Add("sureewat@gemmaknits.com")
            e_mail.CC.Add("supapat@gemmaknits.com")
            e_mail.CC.Add("joylin@gemmaknits.com")
            'e_mail.CC.Add("neung@eschler.co.th")
            e_mail.Bcc.Add("neung@eschler.co.th") 'For Check Error

            e_mail.Subject = "แจ้งการถอดถอนดีไซน์ / Notice of Removing Design"

            e_mail.IsBodyHtml = False
            e_mail.Body = Body
            Smtp_Server.Send(e_mail)

        Catch error_t As Exception
            MsgBox(error_t.ToString)
        End Try
    End Sub
    Private Sub chkitem_disabled_Click(sender As Object, e As System.EventArgs) Handles chkitem_disabled.Click
        'If txtItemCd.Text.Trim.Length > 0 Then
        'SaveDataRemove()
        'End If
    End Sub

    Private Sub grdItemsCategory_DataError(sender As Object, e As DataGridViewDataErrorEventArgs) Handles grdItemsCategory.DataError
        'Don't Delete this sub
    End Sub

    Private Sub BtnGetMasterData_Click(sender As Object, e As EventArgs) Handles BtnGetMasterData.Click
        Call GetDefaultItemData()
    End Sub

    Private Sub GetDefaultItemData()
        Dim dtnew As DataTable = (New classItemsCategory).GetDefaultItemsCategory(0, StrItcd, clsuser.UserID)
        Dim dt As DataTable = grdItemsCategory.DataSource

        For Each drNew As DataRow In dtnew.Rows
            Dim NewROw As DataRow = dt.NewRow
            For colNo As Integer = 0 To dt.Columns.Count - 1
                NewROw(colNo) = drNew(colNo)
            Next

            If CheckNotDupicateItemCat(dt, NewROw) Then
                dt.Rows.Add(NewROw)
            End If
        Next

    End Sub

    Private Function CheckNotDupicateItemCat(ByVal dt As DataTable, ByVal newrow As DataRow) As Boolean
        For Each row As DataRow In dt.Rows
            If row("items_category_set_id") = newrow("items_category_set_id") Then
                Return False
            End If
        Next

        Return True
    End Function

    Private Sub btnPrintItemCatgory1_Click(sender As Object, e As EventArgs) Handles btnPrintItemCatgory1.Click

        Dim dt As New DataTable


        dt = grdItemsCategory.DataSource
        Dim ds As New DataSet

        'Dim rv1 As New ReportViewer
        Dim rds As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource
        Dim clsconfig As New clsConfig
        Dim rptFileName = "rptItemsCategory.rdlc"
        '  ''If clsuser.ReportPath = "" Then clsuser.ReportPath = clsConfig.ReportPath
        If Not clsconfig.CheckReport(clsuser.ReportPath, rptFileName) Then Exit Sub
        Dim frm As New frmReportViewer
        Dim rv As ReportViewer
        rv = frm.rv

        frm.rv.LocalReport.DisplayName = "Items Category"
        frm.rv.ProcessingMode = ProcessingMode.Local
        Dim localReport As LocalReport
        localReport = frm.rv.LocalReport
        localReport.ReportPath = (clsuser.ReportPath & rptFileName)

        Dim itcd = New ReportParameter("itcd", txtItemCd.Text.Trim)
        Dim items_category_id = New ReportParameter("items_category_id", 0)
        Dim logempcd = New ReportParameter("logempcd", clsuser.UserID)
        localReport.SetParameters(itcd)
        localReport.SetParameters(items_category_id)
        localReport.SetParameters(logempcd)


        frm.rv.LocalReport.GetParameters()
        frm.rv.RefreshReport()

        frm.MdiParent = Me.ParentForm
        frm.Title = "Items Category"
        frm.Show()
    End Sub

    Private Sub btnPrintItemCategory2_Click(sender As Object, e As EventArgs) Handles btnPrintItemCategory2.Click
        Dim clsconfig As New clsConfig
        Const rptFileName = "rptInventoryCategory.rpt" 'Only For 1 Design

        ''If clsuser.ReportPath = "" Then clsuser.ReportPath = clsConfig.ReportPath
        If Not clsconfig.CheckReport(clsuser.ReportPath, rptFileName) Then Exit Sub
        Dim frm As New frmReport
        Dim rpt As New CrystalDecisions.CrystalReports.Engine.ReportDocument
        Me.Cursor = Cursors.WaitCursor
        rpt.Load(clsuser.ReportPath & rptFileName)
        rpt.DataSourceConnections.Item(0).SetConnection(clsConn.servername, clsConn.database, False)
        rpt.DataSourceConnections.Item(0).SetLogon(clsConn.Userid, clsConn.Password)
        rpt.VerifyDatabase()

        rpt.SetParameterValue("@items_category_id", 0)
        rpt.SetParameterValue("@itcd", txtItemCd.Text.Trim)
        rpt.SetParameterValue("@logempcd", clsuser.UserID)

        rpt.SetParameterValue("@Title", "Inventory Category")

        frm.Title = "Inventory Category"
        frm.CRViewer.ReportSource = rpt
        frm.MdiParent = Me.ParentForm
        frm.Show()
        Me.Cursor = Cursors.Default
    End Sub
End Class