Imports System.Data
Imports System.Data.SqlClient
Imports System.Text


Public Class formYarnMaster
    Dim oYarnMaster As New classYarnMaster 'Neung 20250919
    Dim m_formMode As String = ""
    Dim clsUser As New classUserInfo
    Dim _AllowEdit As Boolean = True
    Dim _AllowPrint As Boolean = True
    Dim _AllowNew As Boolean = True
    Dim oConfig As New clsConfig

    Public Property UserInfo() As classUserInfo
        Get
            UserInfo = clsUser
        End Get
        Set(ByVal NewValue As classUserInfo)
            clsUser = NewValue
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
    Public Property AllowNew()
        Get
            Return _AllowNew
        End Get
        Set(ByVal value)
            _AllowNew = value
        End Set
    End Property
    Public Property AllowPrint()
        Get
            Return _AllowPrint
        End Get
        Set(ByVal value)
            _AllowPrint = value
        End Set
    End Property

    Private Sub GetDetailputCombo()
        Dim GetDataYarn As New GetDataYarn
        '----------  Yarn group  ---------------
        Dim dtyarngroup As DataTable
        dtyarngroup = GetDataYarn.GetData_Item_group
        If Not IsNothing(dtyarngroup) Then
            Me.cboItgroupcd.DataSource = dtyarngroup
            Me.cboItgroupcd.DisplayMember = "itgroupdesc"
            Me.cboItgroupcd.ValueMember = "itgroupcd"
        End If

        '----------   Yarn type  ---------------
        Dim dtyarntype As DataTable
        dtyarntype = GetDataYarn.GetData_Item_type
        If Not IsNothing(dtyarntype) Then
            Me.cboItTypeCd.DataSource = dtyarntype
            Me.cboItTypeCd.DisplayMember = "ittypedesc"
            Me.cboItTypeCd.ValueMember = "ittypecd"
        End If

        '----------   Yarn form  ---------------
        Dim dtyarnsub As DataTable
        dtyarnsub = GetDataYarn.GetData_Item_sub
        If Not IsNothing(dtyarnsub) Then
            Me.cbitsubcd.DataSource = dtyarnsub
            Me.cbitsubcd.DisplayMember = "itsubdesc"
            Me.cbitsubcd.ValueMember = "itsubcd"
        End If
        '------------------------------------------------------
        '----------   Yarn Lustre  ---------------
        Dim dtyarnsub2 As DataTable
        dtyarnsub2 = GetDataYarn.GetData_Item_sub2
        If Not IsNothing(dtyarnsub2) Then
            Me.cbitsubcd2.DataSource = dtyarnsub2
            Me.cbitsubcd2.DisplayMember = "itsubdesc2"
            Me.cbitsubcd2.ValueMember = "itsubcd2"
        End If

        '----------   Yarn Twist type  ---------------
        Dim dtyarncat As DataTable
        dtyarncat = GetDataYarn.GetData_Item_cat
        If Not IsNothing(dtyarncat) Then
            Me.cbitcatcd.DataSource = dtyarncat
            Me.cbitcatcd.DisplayMember = "itcatdesc"
            Me.cbitcatcd.ValueMember = "itcatcd"
        End If

        '----------   Yarn function  ---------------
        Dim dtyarnfunction As DataTable
        dtyarnfunction = GetDataYarn.GetData_Item_subcat
        If Not IsNothing(dtyarnfunction) Then
            Me.cbitsubcatcd.DataSource = dtyarnfunction
            Me.cbitsubcatcd.DisplayMember = "itsubcatdesc"
            Me.cbitsubcatcd.ValueMember = "itsubcatcd"
        End If

        '----------   Yarn supplier  ---------------
        Dim dtyarnsupplier As DataTable
        dtyarnsupplier = GetDataYarn.GetData_Suppliers
        If Not IsNothing(dtyarnsupplier) Then
            Me.cbsuppcd.DataSource = dtyarnsupplier
            Me.cbsuppcd.DisplayMember = "name"
            Me.cbsuppcd.ValueMember = "suppcd"
        End If

        '----------   Unit Of Mesurement  ---------------
        Dim dtuom As DataTable
        dtuom = GetDataYarn.GetDataUnit()
        If Not IsNothing(dtuom) Then
            Me.cboReorderUOM.DataSource = dtuom
            Me.cboReorderUOM.DisplayMember = "uom"
            Me.cboReorderUOM.ValueMember = "uom"
        End If

        Me.cboUom2.DataSource = oYarnMaster.selectUomList() 'Neung 20250919
        Me.cboUom2.DisplayMember = "uom"
        Me.cboUom2.ValueMember = "uom_id"
        Me.cboUom2.SelectedIndex = -1

    End Sub

    Private Sub ClearDetailputCombo()
        Me.cboItgroupcd.DataSource = Nothing
        Me.cboItTypeCd.DataSource = Nothing
        Me.cbitsubcd.DataSource = Nothing

        Me.cbitsubcd2.DataSource = Nothing
        Me.cbitcatcd.DataSource = Nothing
        Me.cbitsubcatcd.DataSource = Nothing
        Me.cbsuppcd.DataSource = Nothing

    End Sub

    Private Sub BtnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub

    Private Sub Btnsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        If Not CheckData() Then Exit Sub

        Dim tbl_items As New tbl_Items
        Dim classPurchase As New classPurchase
        Dim msgerr As String = ""
        Dim isvalid As Boolean


        tbl_items.itcd = Me.txtyarncode.Text.Trim.ToUpper
        tbl_items.itdesc = Me.txtdesc.Text.Trim
        tbl_items.itdesc2 = Me.txtdesc2.Text.Trim
        tbl_items.itdesct = Me.txtdesct.Text.Trim
        tbl_items.itdesct2 = Me.txtdesct2.Text.Trim
        tbl_items.itdesc3 = Me.txtDesc3.Text.Trim
        tbl_items.itdesc_spec = Me.txtDescSpec.Text.Trim
        tbl_items.itnaturecd = "YARNS"
        tbl_items.ittypecd = Me.cboItTypeCd.SelectedValue
        tbl_items.itcatcd = Me.cbitcatcd.SelectedValue
        tbl_items.itsubcatcd = Me.cbitsubcatcd.SelectedValue
        tbl_items.itgroupcd = Me.cboItgroupcd.SelectedValue
        tbl_items.itsubcd = Me.cbitsubcd.SelectedValue
        tbl_items.itsubcd2 = Me.cbitsubcd2.SelectedValue
        'tbl_items. itsubcd3 =
        'tbl_items. mrpcode =
        tbl_items.dinear = Me.txtcount.Text.Trim
        tbl_items.filament = Me.txtfilament.Text.Trim
        tbl_items.twists = Me.txttwists.Text.Trim
        'tbl_items. col =
        'tbl_items. dimension =
        tbl_items.suppcd = Me.cbsuppcd.SelectedValue
        'tbl_items. tstamp=
        tbl_items.reorder_qty = Val(txtReorderQTY.Text)
        tbl_items.reorder_unit = cboReorderUOM.SelectedValue.ToString.Trim
        tbl_items.uom2_id = oConfig.IsNull(cboUom2.SelectedValue, Nothing)

        tbl_items.itdesc_supp = txtDescSupp.Text
        tbl_items.uprice_std = Val(txtUprice_std.Text)
        tbl_items.maximum_qty = Val(txtMaxQty.Text)
        tbl_items.beam_length = Val(txtbeam_length.Text)
        tbl_items.warped_ends = Val(txtwarped_ends.Text)
        tbl_items.beams_per_set = Val(txtbeams_per_set.Text)
        tbl_items.lead_time = Val(txtlead_time.Text)
        tbl_items.safety_stock = Val(txtsafety_stock.Text)

        isvalid = classPurchase.updateYarnMaster(tbl_items, m_formMode, msgerr)

        If isvalid = True Then
            MsgBox("Yarn master record saved succesfully", MsgBoxStyle.Information, "Save")
        Else
            MsgBox(msgerr)
        End If
    End Sub

    Private Function CheckData() As Boolean
        If Me.cboItgroupcd.SelectedIndex < 0 Then
            MessageBox.Show("Please Enter Items Group" & vbCrLf & "ไม่สามารถบันทึกได้ เนื่องจากยังไม่ได้เลือก Group",
                "System Message", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
            ErrorProvider1.SetError(cboItgroupcd, "Please Enter Items Group" & vbCrLf & "ไม่สามารถบันทึกได้ เนื่องจากยังไม่ได้เลือก Group")
            Return False
        End If
        If Me.cboItTypeCd.SelectedIndex < 0 Then
            MessageBox.Show("Please Enter Items Type" & vbCrLf & "ไม่สามารถบันทึกได้ เนื่องจากยังไม่ได้เลือก Type",
                "System Message", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
            ErrorProvider1.SetError(cboItTypeCd, "Please Enter Items Type" & vbCrLf & "ไม่สามารถบันทึกได้ เนื่องจากยังไม่ได้เลือก Type")
            Return False
        End If
        If Me.cbitsubcd.SelectedIndex < 0 Then
            MessageBox.Show("Please Enter Items Form" & vbCrLf & "ไม่สามารถบันทึกได้  เนื่องจากยังไม่ได้เลือก Sub",
                "System Message", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
            ErrorProvider1.SetError(cbitsubcd, "Please Enter Items Form" & vbCrLf & "ไม่สามารถบันทึกได้ เนื่องจากยังไม่ได้เลือก Form")
            Return False
        End If
        If Me.cbitsubcd2.SelectedIndex < 0 Then
            MessageBox.Show("Please Enter Items Lustre" & vbCrLf & "ไม่สามารถบันทึกได้  เนื่องจากยังไม่ได้เลือก Lustre",
                "System Message", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
            ErrorProvider1.SetError(cbitsubcd2, "Please Enter Items Lustre" & vbCrLf & "ไม่สามารถบันทึกได้ เนื่องจากยังไม่ได้เลือก Lustre")
            Return False
        End If
        If Me.cbitcatcd.SelectedIndex < 0 Then
            MessageBox.Show("Please Enter Items Twist type" & vbCrLf & "ไม่สามารถบันทึกได้  เนื่องจากยังไม่ได้เลือก Twist type",
                "System Message", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
            ErrorProvider1.SetError(cbitcatcd, "Please Enter Items Twist type" & vbCrLf & "ไม่สามารถบันทึกได้ เนื่องจากยังไม่ได้เลือก Twist type")
            Return False
        End If
        If Me.cbitsubcatcd.SelectedIndex < 0 Then
            MessageBox.Show("Please Enter Items Function" & vbCrLf & "ไม่สามารถบันทึกได้  เนื่องจากยังไม่ได้เลือก Function",
                "System Message", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
            ErrorProvider1.SetError(cbitsubcatcd, "Please Enter Items Function" & vbCrLf & "ไม่สามารถบันทึกได้ เนื่องจากยังไม่ได้เลือก Function")
            Return False
        End If
        If Me.cbsuppcd.SelectedIndex < 0 Then
            MessageBox.Show("Please Enter Supplier" & vbCrLf & "ไม่สามารถบันทึกได้  เนื่องจากยังไม่ได้เลือก Supplier",
                "System Message", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
            ErrorProvider1.SetError(cbsuppcd, "Please Enter Supplier" & vbCrLf & "ไม่สามารถบันทึกได้ เนื่องจากยังไม่ได้เลือก Supplier")
            Return False
        End If

        If (New clsConfig).IsNull(cboReorderUOM.SelectedValue, "") = "" Then
            Me.ErrorReorderUOM.SetError(Me.cboReorderUOM, "Uom should be mandatory and cannot be blank")
            MessageBox.Show("Uom should be mandatory and cannot be blank", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
            Return False
        End If

        Return True
    End Function

    Private Sub formYarnMaster_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        m_formMode = "LOAD"
        Dim dtItems As New DataTable
        Dim getdatayarn As New GetDataYarn
        dtItems = getdatayarn.GetDataItemcode("", "YARNS")
        Me.txtyarncode.Text = ""
        Me.cboItems.DataSource = dtItems
        Me.cboItems.DisplayMember = "Itcd_desc"
        Me.cboItems.ValueMember = "itcd"
        Me.cboItems.SelectedIndex = -1
        Me.tooltipbuttonGenDesc.SetToolTip(Me.buttonGenDesc, "Generate Description")
        m_formMode = "NEW"
        GetDetailputCombo()
        InitEnvForm() 'Sitthana 13/03/2018
    End Sub
    Private Sub InitEnvForm()
        If AllowNew Or AllowEdit Then
            tsbtnSave.Enabled = True
            tsbtnDelete.Enabled = True
        Else
            tsbtnSave.Enabled = False
            tsbtnDelete.Enabled = False
        End If
    End Sub
    Private Sub buttonGenerateItemDesc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles buttonGenDesc.Click
        Dim connStr As New classConnection
        Dim strQuery As New StringBuilder
        Dim m_ItGroupCd As String
        Dim m_ItTypeCd As String
        Dim m_Itsubcd As String
        Dim m_Count As String
        Dim m_Filament As String
        Dim m_Twists As String
        Dim m_ItSubcd2 As String
        Dim m_Itcatcd As String
        Dim m_Itsubcatcd As String
        Dim m_Suppcd As String
        Try
            m_ItGroupCd = Me.cboItgroupcd.SelectedValue.ToString.Trim
            m_ItTypeCd = Me.cboItTypeCd.SelectedValue.ToString.Trim
            m_Itsubcd = Me.cbitsubcd.SelectedValue.ToString.Trim
            m_Count = Me.txtcount.Text.ToUpper.Trim
            m_Filament = Me.txtfilament.Text.Trim
            m_Twists = Me.txttwists.Text.Trim
            m_ItSubcd2 = Me.cbitsubcd2.SelectedValue.ToString.Trim
            m_Itcatcd = Me.cbitcatcd.SelectedValue.ToString.Trim
            m_Itsubcatcd = Me.cbitsubcatcd.SelectedValue.ToString.Trim
            m_Suppcd = Me.cbsuppcd.SelectedValue.ToString.Trim
        Catch ex As Exception
            MsgBox("Some of the required values are not set", MsgBoxStyle.Information, "Generate Description")
            Exit Sub
        End Try

        If Me.cboItgroupcd.SelectedIndex < 0 Or
         Me.cboItTypeCd.SelectedIndex < 0 Or
         Me.cbitsubcd.SelectedIndex < 0 Or
         Me.cbitsubcd2.SelectedIndex < 0 Or
         Me.cbitcatcd.SelectedIndex < 0 Or
         Me.cbitsubcatcd.SelectedIndex < 0 Or
         Me.cbsuppcd.SelectedIndex < 0 Then
            MsgBox("Some of the required values are not set", MsgBoxStyle.Information, "Generate Description")
            Exit Sub
        End If

        Dim m_ItGroupCd_User As String = ""
        Dim m_ItTypeCd_User As String = ""
        Dim m_Itsubcd_User As String = ""
        Dim m_ItSubcd2_user As String = ""
        Dim m_Itcatcd_user As String = ""
        Dim m_Itsubcatcd_user As String = ""
        Dim m_Suppcd_user As String = ""
        Dim m_Desc As New StringBuilder

        Dim cn As New SqlConnection(connStr.connection)

        cn.Open()

        strQuery.Append("Select ItGroupCd_User From Items_group where itgroupcd='")
        strQuery.Append(m_ItGroupCd)
        strQuery.Append("'")
        Dim cmdItems_group As New SqlCommand(strQuery.ToString, cn)
        m_ItGroupCd_User = cmdItems_group.ExecuteScalar.ToString.Trim

        strQuery = strQuery.Replace(strQuery.ToString, "")
        strQuery.Append("Select ItTypecd_User From Items_type where ittypecd='")
        strQuery.Append(m_ItTypeCd)
        strQuery.Append("'")
        Dim cmdItems_type As New SqlCommand(strQuery.ToString, cn)
        m_ItTypeCd_User = cmdItems_type.ExecuteScalar.ToString.Trim

        strQuery = strQuery.Replace(strQuery.ToString, "")
        strQuery.Append("Select ItSubcd_User From Items_sub where itsubcd='")
        strQuery.Append(m_Itsubcd)
        strQuery.Append("'")
        Dim cmdItems_sub As New SqlCommand(strQuery.ToString, cn)
        m_Itsubcd_User = cmdItems_sub.ExecuteScalar.ToString.Trim


        strQuery = strQuery.Replace(strQuery.ToString, "")
        strQuery.Append("Select ItSubcd2_User From Items_sub2 where itsubcd2='")
        strQuery.Append(m_ItSubcd2)
        strQuery.Append("'")
        Dim cmdItems_sub2 As New SqlCommand(strQuery.ToString, cn)
        m_ItSubcd2_user = cmdItems_sub2.ExecuteScalar.ToString.Trim


        strQuery = strQuery.Replace(strQuery.ToString, "")
        strQuery.Append("Select ItCatcd_User From Items_Cat where itcatcd='")
        strQuery.Append(m_Itcatcd)
        strQuery.Append("'")
        Dim cmdItems_cat As New SqlCommand(strQuery.ToString, cn)
        m_Itcatcd_user = cmdItems_cat.ExecuteScalar.ToString.Trim


        strQuery = strQuery.Replace(strQuery.ToString, "")
        strQuery.Append("Select ItSubCatcd_User From Items_SubCat where itsubcatcd='")
        strQuery.Append(m_Itsubcatcd)
        strQuery.Append("'")
        Dim cmdItems_subcat As New SqlCommand(strQuery.ToString, cn)
        m_Itsubcatcd_user = cmdItems_subcat.ExecuteScalar.ToString.Trim


        strQuery = strQuery.Replace(strQuery.ToString, "")
        strQuery.Append("Select Abbrev2 From Suppliers where Suppcd='")
        strQuery.Append(m_Suppcd)
        strQuery.Append("'")
        Dim cmdSuppliers As New SqlCommand(strQuery.ToString, cn)
        m_Suppcd_user = cmdSuppliers.ExecuteScalar().ToString.Trim


        m_Desc.Append(m_ItGroupCd_User & "-")
        m_Desc.Append(m_ItTypeCd_User & "-")
        m_Desc.Append(m_Itsubcd_User & "-")
        m_Desc.Append(m_Count & "-")
        m_Desc.Append(m_Filament & "-")
        m_Desc.Append(m_Twists & "-")
        m_Desc.Append(m_ItSubcd2_user & "-")
        m_Desc.Append(m_Itcatcd_user & "-")
        m_Desc.Append(m_Itsubcatcd_user & "-")
        m_Desc.Append(m_Suppcd_user)

        Me.txtdesc.Text = m_Desc.ToString
        Me.txtdesc2.Text = m_Desc.ToString
        Me.txtDesc3.Text = m_Desc.ToString

        cn.Close()

        Me.tooltipbuttonGenDesc.Active = True

    End Sub

    Private Sub txtyarncode_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtyarncode.LostFocus
        getItemMasterData()
    End Sub

    Private Sub getItemMasterData()
        Dim getdatayarn As New GetDataYarn
        Dim dtItems As New DataTable
        Dim m_itcd As String
        m_itcd = Me.txtyarncode.Text.Trim

        ' If m_itcd = "" Then
        ' Exit Sub
        ' End If
        'dtItems = getdatayarn.GetDataItemcode(m_itcd)
        dtItems = oYarnMaster.selectItemsRecord(m_itcd) 'Neung 20251010
        ' Me.ErrorProvider1.SetError(Me.txtyarncode, "")

        If m_formMode = "NEW" Then
            ' m_formMode = "NEW"
            Me.txtItemId.Text = ""
            Me.txtdesc.Text = " "
            Me.txtdesc2.Text = " "
            Me.txtDesc3.Text = " "
            Me.txtDescSpec.Text = " "
            Me.txtdesct.Text = " "
            Me.txtdesct2.Text = " "
            Me.cboItgroupcd.SelectedValue = " "
            Me.cboItTypeCd.SelectedValue = " "
            Me.cbitsubcd.SelectedValue = " "
            Me.txtcount.Text = " "
            Me.txtfilament.Text = " "
            Me.txttwists.Text = " "
            Me.cbitsubcd2.SelectedValue = " "
            Me.cbitcatcd.SelectedValue = " "
            Me.cbitsubcatcd.SelectedValue = " "
            Me.cbsuppcd.SelectedValue = " "
            Me.txtReorderQTY.Text = "0"
            Me.cboReorderUOM.SelectedValue = " "
            Me.cboUom2.SelectedIndex = -1
            Me.txtDescSupp.Text = ""
            Me.txtUprice_std.Text = "0"
            Me.txtMaxQty.Text = "0"
            Me.txtbeam_length.Text = "0"
            Me.txtwarped_ends.Text = "0"
            Me.txtbeams_per_set.Text = "0"
            Me.txtlead_time.Text = "0"
            Me.txtsafety_stock.Text = "0"
            Me.ErrorProvider1.SetError(Me.txtyarncode, "Item code is New")
        ElseIf m_formMode = "EDIT" Then
            Me.txtItemId.Text = dtItems.Rows(0).Item("item_id")
            'Me.txtyarncode.Text = dtItems.Rows(0).Item("itcd").ToString
            Me.txtdesc.Text = dtItems.Rows(0).Item("itdesc").ToString
            Me.txtdesc2.Text = dtItems.Rows(0).Item("itdesc2").ToString
            Me.txtDesc3.Text = dtItems.Rows(0).Item("itdesc3").ToString
            Me.txtDescSpec.Text = dtItems.Rows(0).Item("itdesc_spec").ToString
            Me.txtdesct.Text = dtItems.Rows(0).Item("itdesct").ToString
            Me.txtdesct2.Text = dtItems.Rows(0).Item("itdesct2").ToString
            Me.cboItgroupcd.SelectedValue = dtItems.Rows(0).Item("itgroupcd").ToString
            Me.cboItTypeCd.SelectedValue = dtItems.Rows(0).Item("ittypecd").ToString
            Me.cbitsubcd.SelectedValue = dtItems.Rows(0).Item("itsubcd").ToString
            Me.txtcount.Text = dtItems.Rows(0).Item("Dinear").ToString
            Me.txtfilament.Text = dtItems.Rows(0).Item("Filament").ToString
            Me.txttwists.Text = dtItems.Rows(0).Item("Twists").ToString
            Me.cbitsubcd2.SelectedValue = dtItems.Rows(0).Item("itsubcd2").ToString
            Me.cbitcatcd.SelectedValue = dtItems.Rows(0).Item("itcatcd").ToString
            Me.cbitsubcatcd.SelectedValue = dtItems.Rows(0).Item("itsubcatcd").ToString
            Me.cbsuppcd.SelectedValue = dtItems.Rows(0).Item("suppcd").ToString
            Me.txtReorderQTY.Text = dtItems.Rows(0).Item("reorder_qty").ToString
            Me.cboReorderUOM.SelectedValue = dtItems.Rows(0).Item("reorder_unit").ToString.Trim
            Me.cboUom2.SelectedValue = dtItems.Rows(0).Item("uom2_id")
            Me.txtDescSupp.Text = dtItems.Rows(0).Item("itdesc_supp").ToString
            Me.txtUprice_std.Text = dtItems.Rows(0).Item("uprice_std").ToString
            Me.txtMaxQty.Text = dtItems.Rows(0).Item("maximum_qty").ToString
            Me.txtbeam_length.Text = dtItems.Rows(0).Item("beam_length").ToString
            Me.txtwarped_ends.Text = dtItems.Rows(0).Item("warped_ends").ToString
            Me.txtbeams_per_set.Text = dtItems.Rows(0).Item("beams_per_set").ToString
            Me.txtlead_time.Text = dtItems.Rows(0).Item("lead_time").ToString
            Me.txtsafety_stock.Text = dtItems.Rows(0).Item("safety_stock").ToString
            Me.ErrorProvider1.SetError(Me.txtyarncode, "")
        End If

        'ClearDetailputCombo()
        'Me.txtyarncode.Text = ""
        'MsgBox("Yarn code have already")
        'ElseIf isvalid = False Then
        'End If

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If m_formMode <> "NEW" Then
            Dim response As Integer
            response = MsgBox("Are you sure you want to delete", MsgBoxStyle.YesNo, "Delete item")
            If response = 6 Then
                Dim classPurchase As New InsertYarn
                Dim msgerr As String = ""
                Dim isvalid As Boolean

                Dim m_itcd As String = Me.txtyarncode.Text
                isvalid = classPurchase.deleteYarnMaster(m_itcd, m_formMode, msgerr)

                If isvalid = True Then
                    MsgBox("Item code: " & m_itcd & " deleted")
                Else
                    MsgBox(msgerr)
                End If
            End If
        End If
    End Sub


    Private Sub btnSearchItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearchItem.Click
        'Dim selectedItemCode As String
        'Dim frm As New formSearchItemcode
        'frm.p_itnaturecd = ("YARNS")
        'frm.ShowDialog()
        '' selectedItemCode = frm.getItemcode("YARNS")
        'If frm.userAction = "OK" Then
        '    m_formMode = "EDIT"
        '    Me.txtyarncode.Text = frm.p_Itcd
        '    Call getItemMasterData()
        'End If

        Dim frm As New formSearchItemcode
        frm.p_itnaturecd = "YARNS"
        frm.Text = "Search Yarn Master"
        frm.ShowDialog()
        If frm.userAction = "OK" Then
            Dim dt As DataTable = oYarnMaster.selectItemsRecord(frm.p_Itcd)
            If dt.Rows.Count > 0 Then
                m_formMode = "EDIT"
                Me.txtyarncode.Text = frm.p_Itcd
            Else
                m_formMode = "NEW"
            End If
            getItemMasterData()
        End If
    End Sub



    Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles tsbtnNew.Click
        Dim dtItems As New DataTable
        Dim getdatayarn As New GetDataYarn
        dtItems = getdatayarn.GetDataItemcode("", "YARNS")
        Me.txtyarncode.Text = ""
        Me.cboItems.DataSource = dtItems
        Me.cboItems.DisplayMember = "Itcd_desc"
        Me.cboItems.ValueMember = "itcd"
        Me.cboItems.SelectedIndex = -1
        Me.tooltipbuttonGenDesc.SetToolTip(Me.buttonGenDesc, "Generate Description")
        m_formMode = "NEW"
        GetDetailputCombo()
        getItemMasterData()

        'Dim dtItems As New DataTable
        'Dim getdatayarn As New GetDataYarn
        'dtItems = getdatayarn.GetDataItemcode("", "YARNS")
        'Me.txtyarncode.Text = ""
        'Me.comboItems.DataSource = dtItems
        'Me.comboItems.DisplayMember = "Itcd_desc"
        'Me.comboItems.ValueMember = "itcd"
        'Me.comboItems.SelectedIndex = -1
        'Me.tooltipbuttonGenDesc.SetToolTip(Me.buttonGenDesc, "Generate Description")
        'm_formMode = "NEW"
        'GetDetailputCombo()
    End Sub

    Private Function SaveData() As Boolean

        Dim tbl_items As New tbl_Items
        Dim classPurchase As New classPurchase
        Dim msgerr As String = ""
        Dim isvalid As Boolean
        Dim pitcd As String = Me.txtyarncode.Text.Trim

        tbl_items.item_id = Val(Me.txtItemId.Text.Trim)
        tbl_items.itcd = Me.txtyarncode.Text.Trim
        tbl_items.itdesc = Me.txtdesc.Text.Trim
        tbl_items.itdesc2 = Me.txtdesc2.Text.Trim
        tbl_items.itdesct = Me.txtdesct.Text.Trim
        tbl_items.itdesct2 = Me.txtdesct2.Text.Trim
        tbl_items.itdesc3 = Me.txtDesc3.Text.Trim
        tbl_items.itdesc_spec = Me.txtDescSpec.Text.Trim
        tbl_items.itnaturecd = "YARNS"
        tbl_items.ittypecd = Me.cboItTypeCd.SelectedValue
        tbl_items.itcatcd = Me.cbitcatcd.SelectedValue
        tbl_items.itsubcatcd = Me.cbitsubcatcd.SelectedValue
        tbl_items.itgroupcd = Me.cboItgroupcd.SelectedValue
        tbl_items.itsubcd = Me.cbitsubcd.SelectedValue
        tbl_items.itsubcd2 = Me.cbitsubcd2.SelectedValue
        'tbl_items. itsubcd3 =
        'tbl_items. mrpcode =
        tbl_items.dinear = Me.txtcount.Text.Trim
        tbl_items.filament = Me.txtfilament.Text.Trim
        tbl_items.twists = Me.txttwists.Text.Trim
        ' tbl_items.col = cboColor.SelectedValue 'Sitthana 20200715
        'tbl_items. dimension =
        tbl_items.suppcd = Me.cbsuppcd.SelectedValue
        'tbl_items. tstamp=
        tbl_items.reorder_qty = Val(txtReorderQTY.Text)
        tbl_items.reorder_unit = cboReorderUOM.SelectedValue.ToString.Trim
        tbl_items.uom2_id = oConfig.IsNull(cboUom2.SelectedValue, Nothing)

        'Dim drv As DataRowView = CType(cboUom2.SelectedItem, DataRowView)
        'Dim reorder_unit2 As String
        'If drv IsNot Nothing Then
        '    drv = CType(cboUom2.SelectedItem, DataRowView)
        '    reorder_unit2 = oConfig.IsNull(drv("uom"), "")
        'Else
        '    reorder_unit2 = ""
        'End If
        'tbl_items.reorder_unit2 = cboUom2.Text

        tbl_items.itdesc_supp = txtDescSupp.Text
        tbl_items.uprice_std = Val(txtUprice_std.Text)
        tbl_items.maximum_qty = Val(txtMaxQty.Text)
        tbl_items.beam_length = Val(txtbeam_length.Text)
        tbl_items.warped_ends = Val(txtwarped_ends.Text)
        tbl_items.beams_per_set = Val(txtbeams_per_set.Text)
        tbl_items.lead_time = Val(txtlead_time.Text)
        tbl_items.safety_stock = Val(txtsafety_stock.Text)

        isvalid = oYarnMaster.updateItemsRecord(pitcd, tbl_items, m_formMode, msgerr)

        If isvalid = True Then
            MsgBox("Yarn master record saved succesfully", MsgBoxStyle.Information, "Save")
            m_formMode = "EDIT"
            txtyarncode.Text = pitcd
            getItemMasterData()
        Else
            MsgBox(msgerr)
        End If

    End Function

    Private Sub btnSave2_Click(sender As Object, e As EventArgs) Handles tsbtnSave.Click
        'Call Btnsave_Click(sender, e)
        Dim result As DialogResult
        result = MessageBox.Show("Would you like to save ?" & vbCrLf &
        IIf(IIf(txtyarncode.Text.Trim.Length = 0, txtyarncode.Text.Trim, txtyarncode.Text.Trim).ToString.Trim.Length = 0, "** ถ้าไม่ใส่ Yarn Code. ระบบจะรันให้อัติโนมัติ **", "Yarn Code. = '" & IIf(txtyarncode.Text.Trim.Length = 0, txtyarncode.Text.Trim, txtyarncode.Text.Trim) & "'"),
        "System Message", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button3)

        If Not CheckData() Then Exit Sub

        Call SaveData()

    End Sub

    Private Sub BtnfrmItemsCategory_Click(sender As Object, e As EventArgs) Handles tsbtnfrmItemsCategory.Click
        If Not ValidateItems(txtyarncode.Text.Trim) Or txtyarncode.Text.Trim = "" Then
            MessageBox.Show("Item No. : " & txtyarncode.Text & "............    Not Valid!!", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Exit Sub
        End If

        'Sitthana Comment 20200415
        'Dim frm As New frmItemsCategory
        'frm.UserInfo = clsUser
        'frm.PItcd = txtyarncode.Text.Trim
        'frm.Pitnaturecd = "YARNS" 'cbItNaturecd.SelectedValue
        'frm.MdiParent = Me.ParentForm
        'frm.AllowEdit = True 'AllowEdit
        'frm.Show()
    End Sub
    Private Function ValidateItems(ByVal pItcd As String) As Boolean
        Dim Result As Boolean = True

        If Not (New classProduction).ValidateItems(txtyarncode.Text.Trim, clsUser.UserID) Then
            MessageBox.Show("ไม่พบ Item Code ในระบบ", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
            Result = False
            Return Result
        End If


        Return Result
    End Function
    Private Sub btnMinimized_Click(sender As Object, e As EventArgs) Handles tsbtnMinimized.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub ToolStripButton2_Click(sender As Object, e As EventArgs) Handles tsbtnExit.Click
        Me.Close()
    End Sub

    Private Sub tsbtnDelete_Click(sender As Object, e As EventArgs) Handles tsbtnDelete.Click
        If m_formMode <> "NEW" Then
            Dim response As Integer
            response = MsgBox("Are you sure you want to delete", MsgBoxStyle.YesNo, "Delete item")
            If response = 6 Then
                Dim classPurchase As New InsertYarn
                Dim msgerr As String = ""
                Dim isvalid As Boolean

                Dim m_itcd As String = Me.txtyarncode.Text
                isvalid = classPurchase.deleteYarnMaster(m_itcd, m_formMode, msgerr)

                If isvalid = True Then
                    MsgBox("Item code: " & m_itcd & " deleted")
                Else
                    MsgBox(msgerr)
                End If
            End If
        End If
    End Sub

    Private Sub cboItems_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cboItems.SelectionChangeCommitted
        'Dim Itcd As String = oConfig.IsNull(Me.cboItems.SelectedValue, "").ToString
        'If Itcd.ToString.Length > 0 Then
        '    m_formMode = "EDIT"
        '    Me.txtyarncode.Text = oConfig.IsNull(Me.cboItems.SelectedValue, "").ToString
        '    getItemMasterData()
        'End If
        Dim m_itcd = oConfig.IsNull(Me.cboItems.SelectedValue, "").ToString
        Dim dt As DataTable = oYarnMaster.selectItemsRecord(m_itcd)
        If dt.Rows.Count > 0 Then
            m_formMode = "EDIT"
            txtyarncode.Text = m_itcd
        Else
            m_formMode = "NEW"
        End If
        getItemMasterData()
    End Sub

    Private Sub txtyarncode_KeyDown(sender As Object, e As KeyEventArgs) Handles txtyarncode.KeyDown
        If e.KeyCode = Keys.Enter Then
            Dim Itcd As String = txtyarncode.Text.Trim
            Dim dt As New DataTable
            dt = oYarnMaster.selectItemsRecord(Itcd)
            If dt.Rows.Count > 0 Then
                m_formMode = "EDIT"
            Else
                m_formMode = "NEW"
            End If
            getItemMasterData()
        End If
    End Sub
End Class
