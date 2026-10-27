Imports System.Data
Imports System.Data.SqlClient
Imports System.Text

Public Class formItemMaster
    Dim m_formMode As String = ""
    Dim clsUser As New classUserInfo

    Dim _AllowEdit As Boolean = True
    Dim _AllowPrint As Boolean = True
    Dim _AllowNew As Boolean = True

    Dim _Itnature As String

    Public Property pItnature As String
        Get
            pItnature = _Itnature
        End Get
        Set(ByVal Newvalue As String)
            _Itnature = Newvalue
        End Set
    End Property
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

    Public Property AllowPrint()
        Get
            Return _AllowPrint
        End Get
        Set(ByVal value)
            _AllowPrint = value
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
    Private Sub txtyarncode_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtyarncode.KeyPress
		If AscW(e.KeyChar) = 13 Then
			getItemMasterData()
		End If
	End Sub

	Private Sub GetDetailputCombo()
		Dim GetDataYarn As New GetDataYarn

		'----------  Yarn nature  ---------------
		Dim dtyarnNature As DataTable
		dtyarnNature = GetDataYarn.GetData_Item_Nature
		If Not IsNothing(dtyarnNature) Then
			Me.cbItNaturecd.DataSource = dtyarnNature
			Me.cbItNaturecd.DisplayMember = "itnaturedesc"
			Me.cbItNaturecd.ValueMember = "itnaturecd"
		End If

		'----------  Yarn group  ---------------
		Dim dtyarngroup As DataTable
		dtyarngroup = GetDataYarn.GetData_Item_group
		If Not IsNothing(dtyarngroup) Then
			Me.cbitgroupcd.DataSource = dtyarngroup
			Me.cbitgroupcd.DisplayMember = "itgroupdesc"
			Me.cbitgroupcd.ValueMember = "itgroupcd"
		End If

		'----------   Yarn type  ---------------
		Dim dtyarntype As DataTable
		dtyarntype = GetDataYarn.GetData_Item_type
		If Not IsNothing(dtyarntype) Then
			Me.cbittypecd.DataSource = dtyarntype
			Me.cbittypecd.DisplayMember = "ittypedesc"
			Me.cbittypecd.ValueMember = "ittypecd"
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
			'Me.cbsuppcd.DataSource = dtyarnsupplier
			'Me.cbsuppcd.DisplayMember = "name"
			'Me.cbsuppcd.ValueMember = "suppcd"
		End If

		'----------   Unit Of Mesurement  ---------------
		Dim dtuom As DataTable
		dtuom = GetDataYarn.GetDataUnit()
		If Not IsNothing(dtuom) Then
			Me.cboReorderUOM.DataSource = dtuom
			Me.cboReorderUOM.DisplayMember = "uom"
			Me.cboReorderUOM.ValueMember = "uom"
		End If

	End Sub

	Private Sub ClearDetailputCombo()
		Me.cbitgroupcd.DataSource = Nothing
		Me.cbittypecd.DataSource = Nothing
		Me.cbitsubcd.DataSource = Nothing

		Me.cbitsubcd2.DataSource = Nothing
		Me.cbitcatcd.DataSource = Nothing
		Me.cbitsubcatcd.DataSource = Nothing
		'		Me.cbsuppcd.DataSource = Nothing
	End Sub

	Private Sub BtnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnExit.Click
		Me.Close()
	End Sub

    Private Sub Btnsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btnsave.Click
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
        tbl_items.itnaturecd = Me.cbItNaturecd.SelectedValue
        tbl_items.ittypecd = Me.cbittypecd.SelectedValue
        tbl_items.itcatcd = Me.cbitcatcd.SelectedValue
        tbl_items.itsubcatcd = Me.cbitsubcatcd.SelectedValue
        tbl_items.itgroupcd = Me.cbitgroupcd.SelectedValue
        tbl_items.itsubcd = Me.cbitsubcd.SelectedValue
        tbl_items.itsubcd2 = Me.cbitsubcd2.SelectedValue
        'tbl_items. itsubcd3 =
        'tbl_items. mrpcode =
        tbl_items.dinear = ""
        tbl_items.filament = ""
        tbl_items.twists = ""
        'tbl_items. col =
        'tbl_items. dimension =
        tbl_items.suppcd = "NONE"
        'tbl_items. tstamp=
        tbl_items.reorder_qty = Val(txtReorderQTY.Text)
        tbl_items.reorder_unit = cboReorderUOM.SelectedValue.ToString.Trim
        tbl_items.itdesc_supp = txtDescSupp.Text
        isvalid = classPurchase.updateYarnMaster(tbl_items, m_formMode, msgerr)

        If isvalid = True Then
            MsgBox("Item created successfully")
        Else
            MsgBox(msgerr)
        End If
    End Sub

    Private Function CheckData() As Boolean

        If (New clsConfig).IsNull(cbItNaturecd.SelectedValue, "") = "" Then
            Me.ErrorProvider1.SetError(Me.cbItNaturecd, "Items nature should be mandatory and cannot be blank")
            MessageBox.Show("Items nature should be mandatory and cannot be blank" _
                            , "¢éÍ¼Ô´¾ÅÒ´" _
                            , MessageBoxButtons.OK _
                            , MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
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
		dtItems = getdatayarn.GetDataItem()
		Me.txtyarncode.Text = ""
		Me.comboItems.DataSource = dtItems
		Me.comboItems.DisplayMember = "Itcd_desc"
		Me.comboItems.ValueMember = "itcd"
		'		Me.tooltipbuttonGenDesc.SetToolTip(Me.buttonGenDesc, "Generate Description")
		m_formMode = "NEW"
        GetDetailputCombo()
        InitEnvForm() 'Sitthana 13/03/2018
    End Sub
    Private Sub InitEnvForm()
        If AllowNew Or AllowEdit Then
            Btnsave.Enabled = True
            buttonDelete.Enabled = True
        Else
            Btnsave.Enabled = False
            buttonDelete.Enabled = False
        End If
    End Sub
    Private Sub buttonGenerateItemDesc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
		generateItemDesc()
	End Sub

	Private Sub txtyarncode_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtyarncode.LostFocus
		getItemMasterData()
	End Sub

	Private Sub comboItems_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles comboItems.SelectedValueChanged
		If m_formMode = "LOAD" Then
			Exit Sub
		End If
		Me.txtyarncode.Text = Me.comboItems.SelectedValue.ToString
		getItemMasterData()
	End Sub

	Private Sub comboItems_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles comboItems.Validating
		Me.txtyarncode.Text = Me.comboItems.SelectedValue.ToString
	End Sub

	Private Sub getItemMasterData()
		Dim getdatayarn As New GetDataYarn
		Dim dtItems As New DataTable
		Dim m_itcd As String
		m_itcd = Me.txtyarncode.Text.Trim

		If m_itcd = "" Then
			Exit Sub
		End If

		dtItems = getdatayarn.GetDataItemcode(m_itcd)
		Me.ErrorProvider1.SetError(Me.txtyarncode, "")

		If dtItems.Rows.Count > 0 Then
			If dtItems.Rows(0).Item("Itnaturecd") = "YARNS" Then
				MsgBox("Item code belongs to yarn, please go to yarn master to edit yarn code..")
				Me.Btnsave.Enabled = False
				Me.buttonDelete.Enabled = False
				Exit Sub
			Else
				Me.Btnsave.Enabled = True
				Me.buttonDelete.Enabled = True
			End If
		End If
		If dtItems.Rows.Count = 0 Then
			m_formMode = "NEW"
			Me.txtdesc.Text = " "
			Me.txtdesc2.Text = " "
			Me.txtDesc3.Text = " "
			Me.txtdesct.Text = " "
			Me.txtdesct2.Text = " "
            Me.cbitgroupcd.SelectedValue = "N/A"
            Me.cbittypecd.SelectedValue = "NONE"
            Me.cbitsubcd.SelectedValue = "NONE"
			'Me.txtcount.Text = " "
			'Me.txtfilament.Text = " "
			'Me.txttwists.Text = " "
            Me.cbitsubcd2.SelectedValue = "NONE"
            Me.cbitcatcd.SelectedValue = "NONE"
            Me.cbitsubcatcd.SelectedValue = "NONE"
            'Me.cbsuppcd.SelectedValue = " "
            Me.txtDescSupp.Text = ""
			Me.ErrorProvider1.SetError(Me.txtyarncode, "Item code is New")
		Else
			m_formMode = "EDIT"
            ''Me.txtyarncode.Text = dtItems.Rows(0).Item("itcd").ToString
			Me.txtdesc.Text = dtItems.Rows(0).Item("itdesc").ToString
			Me.txtdesc2.Text = dtItems.Rows(0).Item("itdesc2").ToString
			Me.txtDesc3.Text = dtItems.Rows(0).Item("itdesc3").ToString
			Me.txtdesct.Text = dtItems.Rows(0).Item("itdesct").ToString
			Me.txtdesct2.Text = dtItems.Rows(0).Item("itdesct2").ToString
			Me.cbitgroupcd.SelectedValue = dtItems.Rows(0).Item("itgroupcd").ToString
			Me.cbittypecd.SelectedValue = dtItems.Rows(0).Item("ittypecd").ToString
			Me.cbitsubcd.SelectedValue = dtItems.Rows(0).Item("itsubcd").ToString
            ''Me.txtcount.Text = dtItems.Rows(0).Item("Dinear").ToString
            ''Me.txtfilament.Text = dtItems.Rows(0).Item("Filament").ToString
            ''Me.txttwists.Text = dtItems.Rows(0).Item("Twists").ToString
			Me.cbitsubcd2.SelectedValue = dtItems.Rows(0).Item("itsubcd2").ToString
			Me.cbitcatcd.SelectedValue = dtItems.Rows(0).Item("itcatcd").ToString
			Me.cbitsubcatcd.SelectedValue = dtItems.Rows(0).Item("itsubcatcd").ToString
            ''Me.cbsuppcd.SelectedValue = dtItems.Rows(0).Item("suppcd").ToString
            Me.ErrorProvider1.SetError(Me.txtyarncode, "")
            Me.txtDescSupp.Text = dtItems.Rows(0).Item("itdesc_supp").ToString.Trim

            'Add New Something To show it Edit By Neung 25/12/2014
            Me.cbItNaturecd.SelectedValue = dtItems.Rows(0).Item("itnaturecd").ToString.Trim
            Me.cboReorderUOM.SelectedValue = dtItems.Rows(0).Item("reorder_unit").ToString.Trim
            Me.txtReorderQTY.Text = dtItems.Rows(0).Item("reorder_qty").ToString.Trim
            'Add New Something To show it Edit By Neung 25/12/2014

		End If

		'ClearDetailputCombo()
		'Me.txtyarncode.Text = ""
		'MsgBox("Yarn code have already")
		'ElseIf isvalid = False Then
		'End If
	End Sub
	Private Sub checkItemDesc()
		Dim getdatayarn As New GetDataYarn
		Dim dtItems As New DataTable
		Dim m_itdesc As String
		Dim m_itcd As String

		m_itdesc = Me.txtdesc.Text.Trim
		m_itcd = Me.txtyarncode.Text.Trim
		If m_itdesc = "" Then
			Exit Sub
		End If
		dtItems = getdatayarn.GetDataItemDesc(m_itdesc, m_itcd)
		Me.errorItemDesc.SetError(Me.txtyarncode, "")

		If Not dtItems Is Nothing Then
			Me.errorItemDesc.SetError(Me.txtyarncode, "Item description already exists")
		Else
			Me.errorItemDesc.SetError(Me.txtyarncode, "")
		End If
	End Sub

	Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles buttonDelete.Click
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
	Private Sub txtdesc_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtdesc.KeyPress
		checkItemDesc()
	End Sub

	Private Sub txtdesc_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtdesc.TextChanged
		checkItemDesc()
	End Sub
	Private Sub generateItemDesc()
		Dim connStr As New classConnection
		Dim strQuery As New StringBuilder
		Dim m_ItGroupCd As String
		Dim m_ItTypeCd As String
		Dim m_Itsubcd As String
		Dim m_ItSubcd2 As String
		Dim m_Itcatcd As String
		Dim m_Itsubcatcd As String
		Dim m_Suppcd As String
		Try
			m_ItGroupCd = Me.cbitgroupcd.SelectedValue.ToString.Trim
			m_ItTypeCd = Me.cbittypecd.SelectedValue.ToString.Trim
			m_Itsubcd = Me.cbitsubcd.SelectedValue.ToString.Trim
			'm_Count = Me.txtcount.Text.ToUpper.Trim
			'm_Filament = Me.txtfilament.Text.Trim
			'm_Twists = Me.txttwists.Text.Trim
			m_ItSubcd2 = Me.cbitsubcd2.SelectedValue.ToString.Trim
			m_Itcatcd = Me.cbitcatcd.SelectedValue.ToString.Trim
			m_Itsubcatcd = Me.cbitsubcatcd.SelectedValue.ToString.Trim
            m_Suppcd = "" 'Me.cbsuppcd.SelectedValue.ToString.Trim
		Catch ex As Exception
			MsgBox("Some of the required values are not set", MsgBoxStyle.Information, "Generate Description")
			Exit Sub
		End Try

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
		m_Desc.Append(m_ItSubcd2_user & "-")
		m_Desc.Append(m_Itcatcd_user & "-")
		m_Desc.Append(m_Itsubcatcd_user & "-")
		m_Desc.Append(m_Suppcd_user)

		Me.txtdesc.Text = m_Desc.ToString
		Me.txtdesc2.Text = m_Desc.ToString
		Me.txtDesc3.Text = m_Desc.ToString

		cn.Close()

		Me.tooltipbuttonGenDesc.Active = True
		checkItemDesc()
	End Sub

    Private Sub btnSearchItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearchItem.Click
        Dim frm As New formSearchItemcode
        frm.p_itnaturecd = ("")
        frm.ShowDialog()
        ' selectedItemCode = frm.getItemcode("YARNS")
        If frm.userAction = "OK" Then
            Me.txtyarncode.Text = frm.p_Itcd
            Call getItemMasterData()
        End If


        'Dim selectedItemCode As String
        '      Dim frm As New formSearchItemcode
        '      frm.p_itnaturecd = ("")
        '      frm.ShowDialog()
        '      'selectedItemCode = frm.getItemcode("ALL")
        '      If selectedItemCode <> "" Then
        '	Me.txtyarncode.Text = selectedItemCode
        'End If
        'getItemMasterData()
    End Sub

    Private Sub comboItems_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles comboItems.SelectedIndexChanged

    End Sub

    Private Sub txtyarncode_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtyarncode.TextChanged

    End Sub

    Private Sub cbItNaturecd_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cbItNaturecd.SelectedIndexChanged

    End Sub
End Class
