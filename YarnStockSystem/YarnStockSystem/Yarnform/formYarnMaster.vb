Public Class formYarnMaster

	Private Sub txtyarncode_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtyarncode.KeyPress
		If AscW(e.KeyChar) = 13 Then
			Dim isvalid As Boolean
			Dim getdatayarn As New GetDataYarn
			isvalid = getdatayarn.GetCheckDataYarn_Code(Me.txtyarncode.Text)
			If isvalid = True Then
				ClearDetailputCombo()
				Me.txtyarncode.Text = ""
				MsgBox("Yarn code have already")
			ElseIf isvalid = False Then
				GetDetailputCombo()
			End If
		End If
	End Sub

	Private Sub GetDetailputCombo()
		Dim GetDataYarn As New GetDataYarn
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
			Me.cbsuppcd.DataSource = dtyarnsupplier
			Me.cbsuppcd.DisplayMember = "name"
			Me.cbsuppcd.ValueMember = "suppcd"
		End If

	End Sub

	Private Sub ClearDetailputCombo()
		Me.cbitgroupcd.DataSource = Nothing
		Me.cbittypecd.DataSource = Nothing
		Me.cbitsubcd.DataSource = Nothing

		Me.cbitsubcd2.DataSource = Nothing
		Me.cbitcatcd.DataSource = Nothing
		Me.cbitsubcatcd.DataSource = Nothing
		Me.cbsuppcd.DataSource = Nothing

	End Sub

	Private Sub BtnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnExit.Click
		Me.Close()
	End Sub

	Private Sub Btnsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btnsave.Click
		Dim tbl_items As New tbl_Items
		Dim InsertYarn As New InsertYarn
		Dim msgerr As String = ""
		Dim isvalid As Boolean

		tbl_items.itcd = Me.txtyarncode.Text.Trim
		tbl_items.itdesc = Me.txtdesc.Text.Trim
		tbl_items.itdesc2 = Me.txtdesc2.Text.Trim
		tbl_items.itdesc_spec = Me.txtDescSpec.Text.Trim
		tbl_items.itdesct = Me.txtdesct.Text.Trim
		tbl_items.itdesct2 = Me.txtdesct2.Text.Trim
		'tbl_items. itnaturecd  =
		tbl_items.ittypecd = Me.cbittypecd.SelectedValue
		tbl_items.itcatcd = Me.cbitcatcd.SelectedValue
		tbl_items.itsubcatcd = Me.cbitsubcatcd.SelectedValue
		tbl_items.itgroupcd = Me.cbitgroupcd.SelectedValue
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
		isvalid = InsertYarn.InsertYarnMaster(tbl_items, msgerr)
		If isvalid = True Then
			MsgBox("Success")
		Else
			MsgBox(msgerr)
		End If
	End Sub

	Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
		Dim K As New clsConfig
		MsgBox(Today())
		MsgBox(K.GetCultureDate(Today(), "en-GB"))

	End Sub
End Class
