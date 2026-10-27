Imports System.Math
Imports InvoiceSystemESH.Controls

Public Class frmInvoiceExport
    Public Property UserInfo() As classUserInfo
        Get
            UserInfo = clsUser
        End Get
        Set(ByVal NewValue As classUserInfo)
            clsUser = NewValue
        End Set
    End Property

    Dim clsConfig As New clsConfig
    Dim clsConn As New classConnection
    Dim clsUser As New classUserInfo

    Dim lngInvID As Long = 0
    Dim strInvNo As String = ""
    Dim blnCancel As Boolean = False
    Dim blnChange As Boolean = False

    Dim bsBanks As New BindingSource
    Dim dtBanks As New DataTable
    Private dtPackingList As New DataTable

    'LULITEX
    Private Const cstLULITEX_1 As String = "844"
    Private Const cstLULITEX_2 As String = "876"
    Private Const cstLULITEX_3 As String = "892"

    'Delta Bogart Lingerie Ltd.
    Private Const cstDeltaBogart As String = "1002"




    Private Sub SetControlValue(ByVal Obj As Control)
        If TypeOf Obj Is TextBox Then
            If Obj.Tag = "str" Then Obj.Text = ""
            If Obj.Tag = "int" Then Obj.Text = "0.00"
        End If
        If TypeOf Obj Is DateTimePicker Then
            Dim dtp As DateTimePicker = Obj
            dtp.Value = Now
        End If
        If TypeOf Obj Is ComboBox Then
            Dim cbo As ComboBox = Obj
            cbo.SelectedValue = ""
        End If
        If TypeOf Obj Is TabControl Or TypeOf Obj Is TabPage Or TypeOf Obj Is GroupBox Then
            Dim obj2 As Control
            For Each obj2 In Obj.Controls
                Call SetControlValue(obj2)
            Next
        End If
    End Sub

    Private Sub InitControl()
        Dim obj As Control
        For Each obj In Me.Controls
            Call SetControlValue(obj)
        Next
        Call EnabledControl(True)
        lngInvID = 0
        strInvNo = ""
        lblCancelled.Visible = False
        blnCancel = False
        Call LoadData(0, "")
        TabControl1.TabIndex = 0
        txtInvNo.Focus()
        cboUOM.SelectedValue = "JOB"
        cbocurrency.SelectedValue = "USD"

        'Add By Neung Getfreight(4846) use for Eschler
        'If Validate_Company() Then
        'Call Getfreight(4846)
        ' End If


    End Sub
    Private Function Validate_Company() As Boolean
        Dim objDB As New classInvoice
        Dim dt As DataTable = objDB.ValidateCompany("CA", clsUser.UserID)

        If dt.Rows.Count = 0 Then
            Return False
        End If
        Return True
    End Function


    Private Sub SetControlEnabled(ByVal Obj As Control, ByVal blnEnabled As Boolean)
        If TypeOf Obj Is TextBox Then Obj.Enabled = blnEnabled
        If TypeOf Obj Is DateTimePicker Then Obj.Enabled = blnEnabled
        If TypeOf Obj Is ComboBox Then Obj.Enabled = blnEnabled
        If TypeOf Obj Is DataGridView Then
            Dim grd As DataGridView = Obj
            grd.ReadOnly = Not blnEnabled
        End If
        If TypeOf Obj Is TabControl Or TypeOf Obj Is TabPage Or TypeOf Obj Is GroupBox Then
            Dim obj2 As Control
            For Each obj2 In Obj.Controls
                Call SetControlEnabled(obj2, blnEnabled)
            Next
        End If
    End Sub

    Private Sub EnabledControl(ByVal blnEnabled As Boolean)
        Dim obj As Control
        For Each obj In Me.Controls
            Call SetControlEnabled(obj, blnEnabled)
        Next
        'cboCustomer.Enabled = False
        'cboAgent.Enabled = False
        'cboReceiver.Enabled = False
        btnLoad.Enabled = blnEnabled
        btnSearchPacking.Enabled = blnEnabled
    End Sub

    Private Sub GenCombo()
        Dim objDB As New classMaster

        Me.cboCustomer.DataSource = objDB.GetCustomer
        Me.cboCustomer.DisplayMember = "name"
        Me.cboCustomer.ValueMember = "new_custcd"

        Me.cboReceiver.DataSource = objDB.GetCustomer
        Me.cboReceiver.DisplayMember = "name"
        Me.cboReceiver.ValueMember = "new_custcd"

        Me.cboAgent.DataSource = objDB.GetAgent
        Me.cboAgent.DisplayMember = "name"
        Me.cboAgent.ValueMember = "agcd2"

        Me.currency.DataSource = objDB.GetCurrency
        Me.currency.DisplayMember = "curr"
        Me.currency.ValueMember = "curr"

        Me.uom.DataSource = objDB.GetUOM
        Me.uom.DisplayMember = "uom2"
        Me.uom.ValueMember = "uom2"

        Me.fr_item_code.DataSource = objDB.GetFreightCharge
        Me.fr_item_code.DisplayMember = "charge_desc"
        Me.fr_item_code.ValueMember = "charge_code"

        Me.cboFreigthType.DataSource = objDB.GetFreightType
        Me.cboFreigthType.DisplayMember = "FREIGHT_TYPE_NAME"
        Me.cboFreigthType.ValueMember = "FREIGHT_TYPE_NAME"

        Me.cboForwarder.DataSource = objDB.GetForwarder
        Me.cboForwarder.DisplayMember = "forwarder_name"
        Me.cboForwarder.ValueMember = "forwarder_name"

        Me.cboUOM.DataSource = objDB.GetUOM
        Me.cboUOM.DisplayMember = "uom2"
        Me.cboUOM.ValueMember = "uom2"
        Me.cboUOM.Text = "JOB"

        Me.cbocurrency.DataSource = objDB.GetCurrency
        Me.cbocurrency.DisplayMember = "curr"
        Me.cbocurrency.ValueMember = "curr"
        Me.cbocurrency.Text = "USD"

        dtBanks = (New classMaster).comboBanks
        bsBanks.DataSource = dtBanks
        Me.mcboBanks.DataSource = bsBanks '(New classMaster).comboBanks
        Me.mcboBanks.DisplayMember = "bank_display"
        Me.mcboBanks.ValueMember = "id_banks"
        Me.mcboBanks.Text = ""
        Me.mcboBanks.ListBox.Grid.Model.Cols.Hidden(1) = True
        Me.mcboBanks.ListBox.Grid.Model.Cols.Hidden(9) = True
        AddHandler TryCast(mcboBanks.ListControl, GridListBox).Grid.Model.QueryCellInfo, AddressOf Model_QueryCellInfoBanks
    End Sub
    Private Sub Model_QueryCellInfoBanks(ByVal sender As Object, ByVal e As InvoiceSystemESH.Controls.GridQueryCellInfoEventArgs)
        'To specify the row and colum index.
        If e.RowIndex = 0 AndAlso e.ColIndex = 2 Then
            e.Style.Font = New InvoiceSystemESH.Controls.GridFontInfo(New Font("Segoe UI", 12, FontStyle.Bold, GraphicsUnit.Pixel))
            e.Style.Text = "Code"
        ElseIf e.RowIndex = 0 AndAlso e.ColIndex = 3 Then
            e.Style.Font = New InvoiceSystemESH.Controls.GridFontInfo(New Font("Segoe UI", 12, FontStyle.Bold, GraphicsUnit.Pixel))
            e.Style.Text = "Name"
        ElseIf e.RowIndex = 0 AndAlso e.ColIndex = 4 Then
            e.Style.Font = New InvoiceSystemESH.Controls.GridFontInfo(New Font("Segoe UI", 12, FontStyle.Bold, GraphicsUnit.Pixel))
            e.Style.Text = "Address"
        ElseIf e.RowIndex = 0 AndAlso e.ColIndex = 5 Then
            e.Style.Font = New InvoiceSystemESH.Controls.GridFontInfo(New Font("Segoe UI", 11, FontStyle.Bold, GraphicsUnit.Pixel))
            e.Style.Text = "Swift Code"
        ElseIf e.RowIndex = 0 AndAlso e.ColIndex = 6 Then
            e.Style.Font = New InvoiceSystemESH.Controls.GridFontInfo(New Font("Segoe UI", 12, FontStyle.Bold, GraphicsUnit.Pixel))
            e.Style.Text = "Account No."
        ElseIf e.RowIndex = 0 AndAlso e.ColIndex = 7 Then
            e.Style.Font = New InvoiceSystemESH.Controls.GridFontInfo(New Font("Segoe UI", 12, FontStyle.Bold, GraphicsUnit.Pixel))
            e.Style.Text = "Currency"
        ElseIf e.RowIndex = 0 AndAlso e.ColIndex = 8 Then
            e.Style.Font = New InvoiceSystemESH.Controls.GridFontInfo(New Font("Segoe UI", 12, FontStyle.Bold, GraphicsUnit.Pixel))
            e.Style.Text = "Branch"

        End If
    End Sub

    Private Sub GenComboExpInv()
        Dim objDB As New classInvoice
        cboInvNo.ComboBox.DataSource = objDB.InvExpLoad
        'cboInvNo.ComboBox.DisplayMember = "invno"
        cboInvNo.ComboBox.DisplayMember = "invnowithstat" '"invno"
        cboInvNo.ComboBox.ValueMember = "invid"
        If lngInvID > 0 Then cboInvNo.ComboBox.SelectedValue = lngInvID
    End Sub

    Private Sub GenComboPackNo(Optional ByVal stock_type As String = "G")
        Me.Cursor = Cursors.WaitCursor
        Dim objDB As New classInvoice
        'Me.cboPackNo.DataSource = objDB.GetPackNo(stock_type)

        dtPackingList = objDB.GetPackNo(stock_type) 'Sitthana 20200810
        Me.cboPackNo.DataSource = dtPackingList 'Sitthana 20200810
        Me.cboPackNo.DisplayMember = "packno_cartno"
        Me.cboPackNo.ValueMember = "packno_cartno"
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub BindData(ByVal dt As DataTable)
        lngInvID = dt.Rows(0)("invid")
        strInvNo = dt.Rows(0)("invno").ToString.Trim
        cboCustomer.SelectedValue = dt.Rows(0)("custcd").ToString.Trim
        cboAgent.SelectedValue = dt.Rows(0)("agcd").ToString.Trim
        'txtTermCondition.Text = dt.Rows(0)("cond").ToString.Trim 'Disible By Neung 2015/11/30
        'cboFreigthType.SelectedValue = dt.Rows(0)("cond").ToString.Trim 'Add By Neung 2015/11/30
        cboFreigthType.Text = dt.Rows(0)("cond").ToString.Trim 'Add By Neung 2015/11/30
        mcboBanks.SelectedValue = dt.Rows(0)("id_banks") 'Neung 20260429
        txtBankCode.Text = dt.Rows(0)("bankcode").ToString.Trim
        txtBankName.Text = dt.Rows(0)("bankname").ToString.Trim
        txtBankBranch.Text = dt.Rows(0)("bankbranch").ToString.Trim
        txtLcNo.Text = dt.Rows(0)("lcno").ToString.Trim
        dtpLcDate.Value = CDate(dt.Rows(0)("lcdt2").ToString)
        txtLcAmt.Text = dt.Rows(0)("lcamt").ToString.Trim

        txtGrossWeight.Text = dt.Rows(0)("gross_weight").ToString.Trim
        txtNetWeight.Text = dt.Rows(0)("net_weight").ToString.Trim
        txtCapacity.Text = FormatNumber(dt.Rows(0)("capacity"), 3, TriState.True, TriState.False, TriState.True)
        txtEnWrapMaterial.Text = dt.Rows(0)("enwrap_material").ToString.Trim
        txtEnWrapCost.Text = dt.Rows(0)("enwrap_cost").ToString.Trim

        txtInvNo.Text = dt.Rows(0)("invno").ToString.Trim
        dtpInvDate.Value = CDate(dt.Rows(0)("invdt2").ToString)

        txtFreightType.Text = dt.Rows(0)("freight_type").ToString.Trim
        txtFOBLoc.Text = dt.Rows(0)("fob_loc").ToString.Trim
        cboReceiver.SelectedValue = dt.Rows(0)("receiver_code").ToString.Trim
        'txtForwarder.Text = dt.Rows(0)("forwarder").ToString.Trim 'Add By Neung 20151130
        'cboForwarder.SelectedValue = dt.Rows(0)("forwarder").ToString.Trim 'Add By Neung 20151130
        cboForwarder.Text = dt.Rows(0)("forwarder").ToString.Trim 'Add By Neung 20151130

        txtParcelCode.Text = dt.Rows(0)("parcel_code").ToString.Trim
        dtpRegisterDate.Value = CDate(dt.Rows(0)("register_dt2").ToString)
        txtDepartLoc.Text = dt.Rows(0)("depart_loc").ToString
        dtpDepartDate.Value = CDate(dt.Rows(0)("depart_dt2").ToString)
        txtArriveLoc.Text = dt.Rows(0)("arrive_loc").ToString
        dtpArriveDate.Value = CDate(dt.Rows(0)("arrive_dt2").ToString)
        txtFreightAmt.Text = dt.Rows(0)("freight_amt").ToString
        txtInsuranceAmt.Text = dt.Rows(0)("insurance_amt").ToString
        txtChargeIssue.Text = dt.Rows(0)("chargetxt").ToString.Trim
        txtChargeAmt.Text = dt.Rows(0)("chargeamt").ToString

        txtRemark.Text = dt.Rows(0)("remark").ToString.Trim
        txtGrossAmt.Text = FormatNumber(dt.Rows(0)("grossamt"), 2, TriState.True, TriState.False, TriState.True)
        txtDiscAmt.Text = FormatNumber(dt.Rows(0)("discamt"), 2, TriState.True, TriState.False, TriState.True)
        txtPreTaxAmt.Text = FormatNumber(dt.Rows(0)("pretaxamt"), 2, TriState.True, TriState.False, TriState.True)
        txtVat.Text = FormatNumber(dt.Rows(0)("vat"), 2, TriState.True, TriState.False, TriState.True)
        txtVatAmt.Text = FormatNumber(dt.Rows(0)("vatamt"), 2, TriState.True, TriState.False, TriState.True)
        txtNetAmt.Text = FormatNumber(dt.Rows(0)("netamt"), 2, TriState.True, TriState.False, TriState.True)

        txtShipVia.Text = dt.Rows(0)("shipvia").ToString.Trim
        txtFrInvNo.Text = dt.Rows(0)("fr_inv_no").ToString.Trim
        dtpFrInvDate.Value = CDate(dt.Rows(0)("fr_inv_date2").ToString)
        dtpFrDueDate.Value = CDate(dt.Rows(0)("fr_due_date2").ToString)
        txtFrRefNo.Text = dt.Rows(0)("fr_ref_no").ToString.Trim
        txtFrContact.Text = dt.Rows(0)("fr_contact").ToString.Trim
        txtFrTel.Text = dt.Rows(0)("fr_tel").ToString.Trim
        txtShipName.Text = dt.Rows(0)("fr_shipname").ToString.Trim
        txtFrRemark.Text = dt.Rows(0)("fr_remark").ToString.Trim
        txtFrVat.Text = dt.Rows(0)("fr_vat").ToString.Trim
        chkProforma.Checked = CBool(dt.Rows(0)("is_proforma"))
        txtEntryOutputNo.Text = dt.Rows(0)("entry_output_no").ToString.Trim
        dtpEntryOutputDate.Value = clsConfig.IsNull(dt.Rows(0)("entry_output_date"), "#01/01/2019#") 'Sitthana 20190319
        txtEntryOutputStatus.Text = dt.Rows(0)("entry_output_status").ToString.Trim
        txtBOI.Text = dt.Rows(0)("boi_no").ToString.Trim
        txtBenefit.Text = dt.Rows(0)("benefit").ToString.Trim
        txtRMNo.Text = dt.Rows(0)("rm_no").ToString.Trim
        txtPending.Text = dt.Rows(0)("pending").ToString.Trim

        If dt.Rows(0)("cancel_by").ToString.Trim.Length > 0 Then
            lblCancelled.Visible = True
            Call EnabledControl(False)
        End If
    End Sub

    Private Sub BindGrid(ByVal dt As DataTable)
        If dt.Rows.Count > 0 Then TabControl1.SelectedTab = TabPage3
        grdInv.AutoGenerateColumns = False
        grdInv.DataSource = dt

        Call SumGrid()

        TabControl1.SelectedTab = TabPage1
    End Sub
    Private Sub BindGridCopy(ByVal invidCopy As Long)

        Dim objDB As New classInvoice
        Dim dt As New DataTable
        If dt.Rows.Count > 0 Then TabControl1.SelectedTab = TabPage3
        dt = objDB.InvExpDetLoadCopy(invidCopy)

        grdInv.AutoGenerateColumns = False
        Dim dtNew As New DataTable
        Dim dr As DataRow
        dtNew = grdInv.DataSource

        If Not dt.Rows.Count > 0 Then Exit Sub

        For i = 0 To dt.Rows.Count - 1
            dr = dtNew.NewRow
            For j = 0 To dtNew.Columns.Count - 1
                dr(dtNew.Columns(j).ColumnName) = dt.Rows(i)(dtNew.Columns(j).ColumnName)
            Next

            dtNew.Rows.Add(dr)
        Next

        Call SumGrid()

        TabControl1.SelectedTab = TabPage1
    End Sub
    Private Sub BindGridLabel(ByVal invid As Long)
        Dim objDB As New classInvoice
        Dim dt As New DataTable
        dt = objDB.InvExpLabel(invid)
        grdLabel.AutoGenerateColumns = False
        grdLabel.DataSource = dt
    End Sub

    Private Sub BindGridLabelCopy(ByVal invid As Long)
        Dim objDB As New classInvoice
        Dim dt As New DataTable
        dt = objDB.InvExpLabelCopy(invid)
        grdLabel.AutoGenerateColumns = False

        Dim dtNew As New DataTable
        Dim dr As DataRow
        dtNew = grdLabel.DataSource

        If Not dt.Rows.Count > 0 Then Exit Sub

        For i = 0 To dt.Rows.Count - 1
            dr = dtNew.NewRow
            For j = 0 To dtNew.Columns.Count - 1
                dr(dtNew.Columns(j).ColumnName) = dt.Rows(i)(dtNew.Columns(j).ColumnName)
            Next

            dtNew.Rows.Add(dr)
        Next
    End Sub

    Private Sub BindGridProduct(ByVal invid As Long)
        Dim objDB As New classInvoice
        Dim dt As New DataTable
        dt = objDB.InvExpProduct(invid)
        grdProduct.AutoGenerateColumns = False
        grdProduct.DataSource = dt
    End Sub

    Private Sub BindGridProductCopy(ByVal invid As Long)
        Dim objDB As New classInvoice
        Dim dt As New DataTable
        dt = objDB.InvExpProductCopy(invid)
        grdProduct.AutoGenerateColumns = False

        Dim dtNew As New DataTable
        Dim dr As DataRow
        dtNew = grdProduct.DataSource

        If Not dt.Rows.Count > 0 Then Exit Sub

        For i = 0 To dt.Rows.Count - 1
            dr = dtNew.NewRow
            For j = 0 To dtNew.Columns.Count - 1
                dr(dtNew.Columns(j).ColumnName) = dt.Rows(i)(dtNew.Columns(j).ColumnName)
            Next

            dtNew.Rows.Add(dr)
        Next
    End Sub

    Private Sub BindGridFreight(ByVal invid As Long)
        Dim objDB As New classInvoice
        Dim dt As New DataTable
        dt = objDB.InvExpFreight(invid)
        grdFreight.AutoGenerateColumns = False
        grdFreight.DataSource = dt
        'Call grdFreight()
        Call SumGridFreight()
    End Sub

    Private Sub BindGridFreightCopy(ByVal invid As Long)
        Dim objDB As New classInvoice
        Dim dt As New DataTable
        dt = objDB.InvExpFreightCopy(invid)
        grdFreight.AutoGenerateColumns = False
        Dim dtNew As New DataTable
        Dim dr As DataRow
        dtNew = grdFreight.DataSource

        If Not dt.Rows.Count > 0 Then Exit Sub

        For i = 0 To dt.Rows.Count - 1
            dr = dtNew.NewRow
            For j = 0 To dtNew.Columns.Count - 1
                dr(dtNew.Columns(j).ColumnName) = dt.Rows(i)(dtNew.Columns(j).ColumnName)
            Next

            dtNew.Rows.Add(dr)
        Next
        Call SumGridFreight()
    End Sub

    Private Function CheckDelRow(ByVal dt As DataTable) As Integer
        Dim i As Integer = 0
        Dim j As Integer = 0
        For i = 0 To dt.Rows.Count - 1
            If dt.Rows(i).RowState = DataRowState.Deleted Then j = j + 1
        Next
        Return j
    End Function

    Private Function IsDataChange() As Boolean
        Dim config As New clsConfig
        Dim result As Boolean = False
        Dim i As Integer = 0
        Dim j As Integer = 0
        Dim dt As DataTable = grdInv.DataSource
        Dim dt2 As DataTable = grdLabel.DataSource
        Dim dt3 As DataTable = grdProduct.DataSource
        Dim dt4 As DataTable = grdFreight.DataSource
        Dim dv As New DataView(dt, "", "", DataViewRowState.OriginalRows)
        Dim dv2 As New DataView(dt2, "", "", DataViewRowState.OriginalRows)
        Dim dv3 As New DataView(dt3, "", "", DataViewRowState.OriginalRows)
        Dim dv4 As New DataView(dt4, "", "", DataViewRowState.OriginalRows)
        If dt Is Nothing Or (dv.Count = 0 And dv2.Count = 0 And dv3.Count = 0 And dv4.Count = 0) Then
            If grdInv.Rows.Count > 1 Then result = True
            If dtpInvDate.Value.ToString("yyyyMMdd") <> Now.ToString("yyyyMMdd") Then result = True
            If config.IsNull(cboCustomer.SelectedValue, "").ToString.Trim <> "" Then result = True
            If config.IsNull(cboAgent.SelectedValue, "").ToString.Trim <> "" Then result = True
            'If txtTermCondition.Text <> "" Then result = True ' Disible By Neung 20151130
            If cboFreigthType.Text <> "" Then result = True ' Add By Neung 20151130

            If txtBankCode.Text.Trim <> "" Then result = True
            If txtBankName.Text.Trim <> "" Then result = True
            If txtBankBranch.Text.Trim <> "" Then result = True
            If txtLcNo.Text.Trim <> "" Then result = True
            If dtpLcDate.Value.ToString("yyyyMMdd") <> Now.ToString("yyyyMMdd") Then result = True
            If Val(txtLcAmt.Text) <> 0 Then result = True
            If Val(txtGrossWeight.Text) <> 0 Then result = True
            If Val(txtNetWeight.Text) <> 0 Then result = True
            If Val(txtCapacity.Text) <> 0 Then result = True
            If txtEnWrapMaterial.Text.Trim <> "" Then result = True
            If Val(txtEnWrapCost.Text) <> 0 Then result = True
            If txtFreightType.Text.Trim <> "" Then result = True
            If txtFOBLoc.Text.Trim <> "" Then result = True
            If config.IsNull(cboReceiver.SelectedValue, "").ToString.Trim <> "" Then result = True
            ' If txtForwarder.Text.Trim <> "" Then result = True 'Disible By Neung 20151130
            If cboForwarder.Text.Trim <> "" Then result = True 'Add By Neung 20151130

            If txtParcelCode.Text.Trim <> "" Then result = True
            If dtpRegisterDate.Value.ToString("yyyyMMdd") <> Now.ToString("yyyyMMdd") Then result = True
            If txtDepartLoc.Text.Trim <> "" Then result = True
            If dtpDepartDate.Value.ToString("yyyyMMdd") <> Now.ToString("yyyyMMdd") Then result = True
            If txtArriveLoc.Text.Trim <> "" Then result = True
            If dtpArriveDate.Value.ToString("yyyyMMdd") <> Now.ToString("yyyyMMdd") Then result = True
            If Val(txtFreightAmt.Text) <> 0 Then result = True
            If Val(txtInsuranceAmt.Text) <> 0 Then result = True
            If txtChargeIssue.Text.Trim <> "" Then result = True
            If Val(txtChargeAmt.Text) <> 0 Then result = True
            If txtRemark.Text <> "" Then result = True
            If Val(txtDiscAmt.Text) <> 0 Then result = True
            If Val(txtVat.Text) <> 0 Then result = True
            If Val(txtNetAmt.Text) <> 0 Then result = True
            If txtShipVia.Text <> "" Then result = True
            If txtBOI.Text <> "" Then result = True
            If txtBenefit.Text <> "" Then result = True
            If txtRMNo.Text <> "" Then result = True
            If txtPending.Text <> "" Then result = True
            If txtFrInvNo.Text <> "" Then result = True
            If dtpFrInvDate.Value.ToString("yyyyMMdd") <> Now.ToString("yyyyMMdd") Then result = True
            If dtpFrDueDate.Value.ToString("yyyyMMdd") <> Now.ToString("yyyyMMdd") Then result = True
            If txtFrRefNo.Text <> "" Then result = True
            If txtFrContact.Text <> "" Then result = True
            If txtFrTel.Text <> "" Then result = True
            If txtShipName.Text <> "" Then result = True
            If txtFrRemark.Text <> "" Then result = True
            If Val(txtFrVat.Text) <> 0 Then result = True
            If dt.Rows.Count > 0 Then result = True
            If dt2.Rows.Count > 0 Then result = True
            If dt3.Rows.Count > 0 Then result = True
            If dt4.Rows.Count > 0 Then result = True
        Else

            'Dim i As Integer = CheckDelRow(dt)
            For i = 0 To dt.Rows.Count - 1
                If dt.Rows(i).RowState <> DataRowState.Deleted Then
                    'If i < dt.Rows.Count Then
                    If dtpInvDate.Value <> CDate(dt.Rows(i)("invdt2").ToString) Then result = True
                    If cboCustomer.SelectedValue.ToString.Trim <> dt.Rows(i)("custcd").ToString.Trim Then result = True
                    If cboAgent.SelectedValue.ToString.Trim <> dt.Rows(i)("agcd").ToString.Trim Then result = True
                    'If txtTermCondition.Text <> dt.Rows(i)("cond").ToString.Trim Then result = True ' Disible By Neung 20151130
                    If cboFreigthType.Text <> dt.Rows(i)("cond").ToString.Trim Then result = True ' Add By Neung 20151130
                    If txtBankCode.Text <> dt.Rows(i)("bankcode").ToString.Trim Then result = True
                    If txtBankName.Text <> dt.Rows(i)("bankname").ToString.Trim Then result = True
                    If txtBankBranch.Text <> dt.Rows(i)("bankbranch").ToString.Trim Then result = True
                    If txtLcNo.Text <> dt.Rows(i)("lcno").ToString.Trim Then result = True
                    If dtpLcDate.Value <> CDate(dt.Rows(i)("lcdt2").ToString) Then result = True
                    If Val(txtLcAmt.Text) <> Val(dt.Rows(i)("lcamt")) Then result = True
                    If Val(txtGrossWeight.Text) <> Val(dt.Rows(i)("gross_weight")) Then result = True
                    If Val(txtNetWeight.Text) <> Val(dt.Rows(i)("net_weight")) Then result = True
                    If Val(txtCapacity.Text) <> Val(dt.Rows(i)("capacity")) Then result = True
                    If txtEnWrapMaterial.Text <> dt.Rows(i)("enwrap_material").ToString.Trim Then result = True
                    If Val(txtEnWrapCost.Text) <> Val(dt.Rows(i)("enwrap_cost")) Then result = True
                    If txtFreightType.Text <> dt.Rows(i)("freight_type").ToString.Trim Then result = True
                    If txtFOBLoc.Text <> dt.Rows(i)("fob_loc").ToString.Trim Then result = True
                    If cboReceiver.SelectedValue.ToString.Trim <> dt.Rows(i)("receiver_code").ToString.Trim Then result = True
                    ' If txtForwarder.Text <> dt.Rows(i)("forwarder").ToString.Trim Then result = True ' Disible By Neung 20151130
                    If cboForwarder.Text <> dt.Rows(i)("forwarder").ToString.Trim Then result = True 'Add By Neung 20151130

                    If txtParcelCode.Text <> dt.Rows(i)("parcel_code").ToString.Trim Then result = True
                    If dtpRegisterDate.Value <> CDate(dt.Rows(i)("register_dt2").ToString) Then result = True
                    If txtDepartLoc.Text <> dt.Rows(i)("depart_loc").ToString.Trim Then result = True
                    If dtpDepartDate.Value <> CDate(dt.Rows(i)("depart_dt2").ToString) Then result = True
                    If txtArriveLoc.Text <> dt.Rows(i)("arrive_loc").ToString.Trim Then result = True
                    If dtpArriveDate.Value <> CDate(dt.Rows(i)("arrive_dt2").ToString) Then result = True
                    If Val(txtFreightAmt.Text) <> Val(dt.Rows(i)("freight_amt")) Then result = True
                    If Val(txtInsuranceAmt.Text) <> Val(dt.Rows(i)("insurance_amt")) Then result = True
                    If txtChargeIssue.Text <> dt.Rows(i)("chargetxt").ToString.Trim Then result = True
                    If Val(txtChargeAmt.Text) <> Val(dt.Rows(i)("chargeamt")) Then result = True
                    If txtRemark.Text <> dt.Rows(i)("remark").ToString.Trim Then result = True
                    If FormatNumber(txtDiscAmt.Text, 2, TriState.False, TriState.False, TriState.True) <> FormatNumber(dt.Rows(i)("discamt"), 2, TriState.False, TriState.False, TriState.True) Then result = True
                    If FormatNumber(txtVat.Text, 2, TriState.False, TriState.False, TriState.True) <> FormatNumber(dt.Rows(i)("vat"), 2, TriState.False, TriState.False, TriState.True) Then result = True
                    If FormatNumber(txtNetAmt.Text, 2, TriState.False, TriState.False, TriState.True) <> FormatNumber(dt.Rows(i)("netamt"), 2, TriState.False, TriState.False, TriState.True) Then result = True
                    If txtShipVia.Text <> dt.Rows(i)("shipvia").ToString.Trim Then result = True
                    If txtBOI.Text <> dt.Rows(i)("boi_no").ToString.Trim Then result = True
                    If txtBenefit.Text <> dt.Rows(0)("benefit").ToString.Trim Then result = True
                    If txtRMNo.Text <> dt.Rows(0)("rm_no").ToString.Trim Then result = True
                    If txtPending.Text <> dt.Rows(0)("pending").ToString.Trim Then result = True
                    If txtFrInvNo.Text <> dt.Rows(i)("fr_inv_no").ToString.Trim Then result = True
                    If dtpFrInvDate.Value <> CDate(dt.Rows(i)("fr_inv_date2").ToString) Then result = True
                    If dtpFrDueDate.Value <> CDate(dt.Rows(i)("fr_due_date2").ToString) Then result = True
                    If txtFrRefNo.Text <> dt.Rows(i)("fr_ref_no").ToString.Trim Then result = True
                    If txtFrContact.Text <> dt.Rows(i)("fr_contact").ToString.Trim Then result = True
                    If txtFrTel.Text <> dt.Rows(i)("fr_tel").ToString.Trim Then result = True
                    If txtShipName.Text <> dt.Rows(i)("fr_shipname").ToString.Trim Then result = True
                    If txtFrRemark.Text <> dt.Rows(i)("fr_remark").ToString.Trim Then result = True
                    If Val(txtFrVat.Text) <> Val(dt.Rows(i)("fr_vat")) Then result = True
                    ' End If
                    Exit For
                End If
            Next



            Dim delRecs As New DataView(dt, "", "", DataViewRowState.Deleted)
            If delRecs.Count > 0 Then result = True

            Dim updRecs As New DataView(dt, "", "", DataViewRowState.ModifiedCurrent)
            If updRecs.Count > 0 Then result = True

            Dim addRecs As New DataView(dt, "", "", DataViewRowState.Added)
            If addRecs.Count > 0 Then result = True

            Dim delRecs2 As New DataView(dt2, "", "", DataViewRowState.Deleted)
            If delRecs2.Count > 0 Then result = True

            Dim updRecs2 As New DataView(dt2, "", "", DataViewRowState.ModifiedCurrent)
            If updRecs2.Count > 0 Then result = True

            Dim addRecs2 As New DataView(dt2, "", "", DataViewRowState.Added)
            If addRecs2.Count > 0 Then result = True

            Dim delRecs3 As New DataView(dt3, "", "", DataViewRowState.Deleted)
            If delRecs3.Count > 0 Then result = True

            Dim updRecs3 As New DataView(dt3, "", "", DataViewRowState.ModifiedCurrent)
            If updRecs3.Count > 0 Then result = True

            Dim addRecs3 As New DataView(dt3, "", "", DataViewRowState.Added)
            If addRecs3.Count > 0 Then result = True

            Dim delRecs4 As New DataView(dt4, "", "", DataViewRowState.Deleted)
            If delRecs4.Count > 0 Then result = True

            Dim updRecs4 As New DataView(dt4, "", "", DataViewRowState.ModifiedCurrent)
            If updRecs4.Count > 0 Then result = True

            Dim addRecs4 As New DataView(dt4, "", "", DataViewRowState.Added)
            If addRecs4.Count > 0 Then result = True
        End If

        IsDataChange = result
    End Function

    Private Sub SetEmptyControl(ByVal Obj As Control)
        If TypeOf Obj Is TextBox Then
            If Obj.Tag = "int" Then
                If Obj.Text.Trim = "" Then Obj.Text = "0"
            End If
        End If
        If TypeOf Obj Is TabControl Or TypeOf Obj Is TabPage Or TypeOf Obj Is GroupBox Then
            Dim obj2 As Control
            For Each obj2 In Obj.Controls
                Call SetEmptyControl(obj2)
            Next
        End If
    End Sub

    Private Function CheckData() As Boolean
        Dim obj As Control
        For Each obj In Me.Controls
            Call SetEmptyControl(obj)
        Next

        If lblCancelled.Visible Then
            MessageBox.Show("This document is cancelled." & vbCrLf & "Can't edit anymore.", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            CheckData = False
            Exit Function
        End If
        If cboCustomer.SelectedValue.ToString.Trim = "" Then
            MessageBox.Show("Please choose customer!!", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            CheckData = False
            Exit Function
        End If
        If grdInv.Rows.Count <= 1 Then
            MessageBox.Show("Please insert data in table at least 1 record!!", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            CheckData = False
            Exit Function
        End If
        CheckData = True
    End Function

    Private Sub LoadData(ByVal InvID As Long, ByVal InvNo As String)
        Dim objDB As New classInvoice
        Dim dt As New DataTable
        dt = objDB.InvExpDetLoad(InvID, InvNo)
        If dt.Rows.Count > 0 Then Call BindData(dt)
        Call BindGrid(dt)
        Call BindGridLabel(lngInvID)
        Call BindGridProduct(lngInvID)
        Call BindGridFreight(lngInvID)

    End Sub
    Private Function CheckIsDuplicatePackCart(ByVal pPackno As String, ByVal pCartNo As String) As Boolean
        Dim result As Boolean = False
        Dim dtInvDet As New DataTable
        dtInvDet = grdInv.DataSource
        If dtInvDet.Rows.Count > 0 Then
            For Each row As DataRow In dtInvDet.Rows
                If row.RowState <> DataRowState.Deleted Then
                    If (New clsConfig).IsNull(row("packno"), "").ToString().Trim.Equals(pPackno) And (New clsConfig).IsNull(row("cartno"), "").ToString().Trim.Equals(pCartNo) Then
                        MessageBox.Show("คุณกำลังเลือกข้อมูลซ้ำ!!!", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
                        Return True 'ซ้ำ
                    End If
                End If
            Next
        End If

        Return False 'ไม่ซ้ำ
    End Function
    Private Function CheckIsNotDuplicatePackCart(ByVal pPackno As String, ByVal pCartNo As String) As Boolean
        Dim result As Boolean = False
        Dim dtInvDet As New DataTable
        dtInvDet = grdInv.DataSource
        If dtInvDet.Rows.Count > 0 Then
            For Each row As DataRow In dtInvDet.Rows
                If row.RowState <> DataRowState.Deleted Then
                    If (New clsConfig).IsNull(row("packno"), "").ToString().Trim.Equals(pPackno) And (New clsConfig).IsNull(row("cartno"), "").ToString().Trim.Equals(pCartNo) Then
                        MessageBox.Show("Packno and Cartno is Already in Grid." & vbCrLf & "Do not get dupicate!!!", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
                        Return False 'ซ้ำ
                    End If
                End If
            Next
        End If

        Return True 'ไม่ซ้ำ
    End Function
    Private Sub LoadPacking(pPacknoCartno As String)
        Dim config As New clsConfig
        Dim objdb As New classInvoice
        Dim dtNew As New DataTable
        Dim dt2 As New DataTable
        Dim dr As DataRow
        Dim i As Integer = 0
        Dim j As Integer = 0
        ' dt = objdb.InvExpPacking(cboPackNo.SelectedValue, lngInvID, grdInv.Rows.Count - 1) 'Comment by Sitthana 20200810
        dtNew = objdb.InvExpPacking(pPacknoCartno, lngInvID, grdInv.Rows.Count - 1) 'Sitthana 20200810
        If dtNew.Rows.Count > 0 Then

            If Not CheckDataPacking(dtNew) Then Exit Sub
            'เช็ค packno, cartno ว่าซ้ำหรือไม่
            If Not CheckIsNotDuplicatePackCart(config.IsNull(dtNew.Rows(0)("packno"), "").ToString.Trim, config.IsNull(dtNew.Rows(i)("cartno"), "").ToString.Trim) Then Exit Sub


            If config.IsNull(cboCustomer.SelectedValue, "") = "" Then
                cboCustomer.SelectedValue = config.IsNull(dtNew.Rows(0)("custcd"), "").ToString.Trim
            Else
                If cboCustomer.SelectedValue <> config.IsNull(dtNew.Rows(0)("custcd"), "").ToString.Trim Then If MessageBox.Show("Customer is incorrect." & vbCrLf & "Would you like to change customer ?", "System Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) Then cboCustomer.SelectedValue = config.IsNull(dtNew.Rows(0)("custcd"), "").ToString.Trim
            End If
            If config.IsNull(cboCustomer.SelectedValue, "") = "" Then
                cboAgent.SelectedValue = config.IsNull(dtNew.Rows(0)("agcd"), "").ToString.Trim
            Else
                If cboAgent.SelectedValue <> config.IsNull(dtNew.Rows(0)("agcd"), "").ToString.Trim Then If MessageBox.Show("Agency is incorrect." & vbCrLf & "Would you like to change agency ?", "System Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) Then cboAgent.SelectedValue = config.IsNull(dtNew.Rows(0)("agcd"), "").ToString.Trim
            End If
            If config.IsNull(cboReceiver.SelectedValue, "") = "" Then
                cboReceiver.SelectedValue = config.IsNull(dtNew.Rows(0)("receiver_code"), "").ToString.Trim
            Else
                If cboReceiver.SelectedValue <> config.IsNull(dtNew.Rows(0)("receiver_code"), "").ToString.Trim Then If MessageBox.Show("Receiver is incorrect." & vbCrLf & "Would you like to change receiver ?", "System Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) Then cboReceiver.SelectedValue = config.IsNull(dtNew.Rows(0)("receiver_code"), "").ToString.Trim
            End If

            If (New clsConfig).IsNull(mcboBanks.SelectedValue, Nothing) = Nothing Then
                mcboBanks.SelectedValue = dtNew.Rows(0)("id_banks")
            Else
                If mcboBanks.SelectedValue <> dtNew.Rows(0)("id_banks") Then If MessageBox.Show("Banks is incorrect." & vbCrLf & "Would you like to change Banks ?", "System Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) Then mcboBanks.SelectedValue = dtNew.Rows(0)("id_banks")
            End If

            If txtLcNo.Text.Trim = "" Then txtLcNo.Text = dtNew.Rows(0)("lcno").ToString

            dt2 = grdInv.DataSource
            For i = 0 To dtNew.Rows.Count - 1
                dr = dt2.NewRow
                For j = 0 To dt2.Columns.Count - 1
                    dr(dt2.Columns(j).ColumnName) = dtNew.Rows(i)(dt2.Columns(j).ColumnName)
                Next

                dt2.Rows.Add(dr)

            Next
        End If
    End Sub

    Private Function CheckDataPacking(ByRef dt As DataTable) As Boolean

        Dim dtInv As DataTable = grdInv.DataSource

        For Each dr As DataRow In dt.Rows
            For Each drInv As DataRow In dtInv.Rows
                If drInv.RowState <> DataRowState.Deleted Then
                    If drInv.Item("currency").ToString.Trim <> dr.Item("currency").ToString.Trim Then
                        MessageBox.Show("คุณกำลัง Load Packing List ที่ต่างสกุลเงินกัน ไม่สามารถโหลดได้ กรุณาเลือก Packing ใหม่หรือทำการแก้ไขก่อน", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
                        Return False
                    End If
                End If
                'If drInv.Item("currency").ToString.Trim <> dr.Item("currency").ToString.Trim Then
                '    MessageBox.Show("คุณกำลัง Load Packing List ที่ต่างสกุลเงินกัน ไม่สามารถโหลดได้ กรุณาเลือก Packing ใหม่หรือทำการแก้ไขก่อน", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
                '    Return False
                'End If
            Next
            'For Each row As DataGridViewRow In grdInv.Rows
            '    If row.Cells("currency").Value.ToString.Trim <> dr.Item("currency").ToString.Trim Then
            '        MessageBox.Show("คุณกำลัง Packing ไม่ถูกต้อง หรือต่างสกุลเงินกัน", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
            '        Return False
            '    End If
            'Next
        Next

        Return True
    End Function

    Private Sub SumGrid()
        Dim i As Integer = 0
        Dim dblGrossAmt As Double = 0
        'Dim dblDiscAmt As Double = Val(txtDiscAmt.Text)
        Dim dblDiscAmt As Double = Convert.ToDouble(txtDiscAmt.Text) 'Sitthana 20240612
        Dim dblPreTaxAmt As Double = 0
        Dim dblVat As Double = Val(txtVat.Text)
        Dim dblVatAmt As Double = 0
        Dim dblNetAmt As Double = 0
        Dim dblCapacity As Double = 0
        Dim config As New clsConfig
        If grdInv.Rows.Count = 0 Then Exit Sub
        For i = 0 To grdInv.Rows.Count - 1
            dblGrossAmt = dblGrossAmt + config.IsNull(grdInv.Rows(i).Cells("linenetamt").Value, 0)
            dblCapacity = dblCapacity + config.IsNull(grdInv.Rows(i).Cells("cbm").Value, 0)
        Next
        dblPreTaxAmt = dblGrossAmt - dblDiscAmt
        dblVatAmt = Round((dblPreTaxAmt * dblVat) / 100, 2)
        dblNetAmt = Round((dblPreTaxAmt * (100 + dblVat)) / 100, 2)
        txtGrossAmt.Text = Format(dblGrossAmt, "#,###.#0")
        txtDiscAmt.Text = Format(dblDiscAmt, "#,###.#0")
        txtPreTaxAmt.Text = Format(dblPreTaxAmt, "#,###.#0")
        txtVat.Text = Format(dblVat, "#,###.#0")
        txtVatAmt.Text = Format(dblVatAmt, "#,###.#0")
        txtNetAmt.Text = Format(dblNetAmt, "#,###.#0")
        'txtCapacity.Text = Format(dblCapacity, "#,###.#0") 'Disible By Neung
    End Sub

    Private Sub SumGridFreight()
        Dim i As Integer = 0
        Dim dblGrossAmt As Double = 0
        Dim dblGrossAmtNonVat As Double = 0
        Dim dblPreTaxAmt As Double = 0
        Dim dblVat As Double = Val(txtFrVat.Text)
        Dim dblVatAmt As Double = 0
        Dim dblNetAmt As Double = 0
        Dim config As New clsConfig
        If grdFreight.Rows.Count = 0 Then Exit Sub 'Fix Bug Neung 20221013
        For i = 0 To grdFreight.Rows.Count - 1
            dblGrossAmt = dblGrossAmt + config.IsNull(grdFreight.Rows(i).Cells("fr_amt_vat").Value, 0)
            dblGrossAmtNonVat = dblGrossAmtNonVat + config.IsNull(grdFreight.Rows(i).Cells("fr_amt_non_vat").Value, 0)
        Next
        dblVatAmt = Round((dblGrossAmt * dblVat) / 100, 2)
        dblNetAmt = Round(((dblGrossAmt * (100 + dblVat)) / 100), 2) + dblGrossAmtNonVat
        txtFrNonVatAmt.Text = Format(dblGrossAmtNonVat, "#,###.#0")
        txtFrAmt.Text = Format(dblGrossAmt, "#,###.#0")
        txtFrVatAmt.Text = Format(dblVatAmt, "#,###.#0")
        txtFrNetAmt.Text = Format(dblNetAmt, "#,###.#0")

        'grdFreight.Rows(0).Cells("fr_ord").Value = "1"
        'grdFreight.Rows(0).Cells("fr_item_desc").Value = "1"
        'grdFreight.Rows(0).Cells("fr_amt_non_vat").Value = "1"
        'grdFreight.Rows(0).Cells("fr_amt_vat").Value = "1"
    End Sub

    Private Function SaveData() As Boolean
        Dim clsINV As New classInvoice
        Dim config As New clsConfig
        Dim invh As New classInvoice.InvExpHeader
        Dim msgerr As String = ""
        Dim invid As Long = 0
        Dim invno As String = ""

        Dim dt As DataTable = grdInv.DataSource

        Dim dv_add As DataView
        Dim dv_upd As DataView
        Dim dv_del As DataView

        Dim dvl_add As New DataView
        Dim dvl_upd As New DataView
        Dim dvl_del As New DataView

        Dim dvp_add As New DataView
        Dim dvp_upd As New DataView
        Dim dvp_del As New DataView

        Dim dvf_add As New DataView
        Dim dvf_upd As New DataView
        Dim dvf_del As New DataView

        'If txtInvNo.Text = "COPY" Then ' dont copy items 
        '    '            Dim dv_add As New DataView(dt, "", "", DataViewRowState.CurrentRows)
        '    '            Dim dv_upd As New DataView(dt, "", "", DataViewRowState.None)
        '    '            Dim dv_del As New DataView(dt, "", "", DataViewRowState.None)
        '    dv_add = New DataView(dt, "", "", DataViewRowState.None)
        '    dv_upd = New DataView(dt, "", "", DataViewRowState.None)
        '    dv_del = New DataView(dt, "", "", DataViewRowState.None)

        'Else
        '            Dim dv_add As New DataView(dt, "", "", DataViewRowState.Added)
        '            Dim dv_upd As New DataView(dt, "", "", DataViewRowState.ModifiedCurrent)
        '            Dim dv_del As New DataView(dt, "", "", DataViewRowState.Deleted)
        dv_add = New DataView(dt, "", "", DataViewRowState.Added)
        dv_upd = New DataView(dt, "", "", DataViewRowState.ModifiedCurrent)
        dv_del = New DataView(dt, "", "", DataViewRowState.Deleted)
        ' End If


        Dim dt2 As DataTable = grdLabel.DataSource

        'If txtInvNo.Text = "COPY" Then
        '    dvl_add = New DataView(dt2, "", "", DataViewRowState.CurrentRows)
        '    dvl_upd = New DataView(dt2, "", "", DataViewRowState.None)
        '    dvl_del = New DataView(dt2, "", "", DataViewRowState.None)

        'Else
        dvl_add = New DataView(dt2, "", "", DataViewRowState.Added)
        dvl_upd = New DataView(dt2, "", "", DataViewRowState.ModifiedCurrent)
        dvl_del = New DataView(dt2, "", "", DataViewRowState.Deleted)
        ' End If

        Dim dt3 As DataTable = grdProduct.DataSource

        'If txtInvNo.Text = "COPY" Then
        '    dvp_add = New DataView(dt3, "", "", DataViewRowState.CurrentRows)
        '    dvp_upd = New DataView(dt3, "", "", DataViewRowState.None)
        '    dvp_del = New DataView(dt3, "", "", DataViewRowState.None)
        'Else
        dvp_add = New DataView(dt3, "", "", DataViewRowState.Added)
        dvp_upd = New DataView(dt3, "", "", DataViewRowState.ModifiedCurrent)
        dvp_del = New DataView(dt3, "", "", DataViewRowState.Deleted)
        'End If

        Dim dt4 As DataTable = grdFreight.DataSource
        'If txtInvNo.Text = "COPY" Then
        '    dvf_add = New DataView(dt4, "", "", DataViewRowState.CurrentRows)
        '    dvf_upd = New DataView(dt4, "", "", DataViewRowState.None)
        '    dvf_del = New DataView(dt4, "", "", DataViewRowState.None)
        'Else
        dvf_add = New DataView(dt4, "", "", DataViewRowState.Added)
        dvf_upd = New DataView(dt4, "", "", DataViewRowState.ModifiedCurrent)
        dvf_del = New DataView(dt4, "", "", DataViewRowState.Deleted)
        'End If

        strInvNo = txtInvNo.Text.Trim
        invid = lngInvID
        invno = strInvNo
        invh.h01_invid = lngInvID
        invh.h02_invno = strInvNo
        invh.h03_invdt = dtpInvDate.Value.ToString("yyyyMMdd")
        'invh.h04_cond = txtTermCondition.Text.Trim ' Disible By Neung 20151130
        invh.h04_cond = cboFreigthType.Text ' Add By Neung 20151130

        invh.h05_custcd = clsConfig.IsNull(cboCustomer.SelectedValue, "")
        invh.h06_agcd = clsConfig.IsNull(cboAgent.SelectedValue, "")
        invh.h07_grossamt = FormatNumber(txtGrossAmt.Text.Trim, 4, TriState.False, TriState.False, TriState.False)
        invh.h08_discamt = FormatNumber(txtDiscAmt.Text.Trim, 4, TriState.False, TriState.False, TriState.False)
        invh.h09_pretaxamt = FormatNumber(txtPreTaxAmt.Text.Trim, 4, TriState.False, TriState.False, TriState.False)
        invh.h10_vat = FormatNumber(txtVat.Text.Trim, 4, TriState.False, TriState.False, TriState.False)
        invh.h11_vatamt = FormatNumber(txtVatAmt.Text.Trim, 4, TriState.False, TriState.False, TriState.False)
        invh.h12_chargetxt = txtChargeIssue.Text.Trim
        invh.h13_chargeamt = FormatNumber(txtChargeAmt.Text.Trim, 4, TriState.False, TriState.False, TriState.False)
        invh.h14_netamt = FormatNumber(txtNetAmt.Text.Trim, 4, TriState.False, TriState.False, TriState.False)
        invh.h15_remark = txtRemark.Text.Trim
        invh.h16_enwrap_material = txtEnWrapMaterial.Text.Trim
        invh.h17_enwrap_cost = FormatNumber(txtEnWrapCost.Text.Trim, 4, TriState.False, TriState.False, TriState.False)
        invh.h18_gross_weight = FormatNumber(txtGrossWeight.Text.Trim, 4, TriState.False, TriState.False, TriState.False)
        invh.h19_net_weight = FormatNumber(txtNetWeight.Text.Trim, 4, TriState.False, TriState.False, TriState.False)
        invh.h20_capacity = FormatNumber(txtCapacity.Text.Trim, 3, TriState.False, TriState.False, TriState.False)
        invh.h21_freight_type = txtFreightType.Text.Trim
        invh.h22_fob_loc = txtFOBLoc.Text.Trim
        invh.h23_receiver_code = clsConfig.IsNull(cboReceiver.SelectedValue, "")
        ' invh.h24_forwarder = txtForwarder.Text.Trim 'Disible By Neung 20153011
        invh.h24_forwarder = cboForwarder.Text.Trim 'Add By Neung 20153011
        invh.h25_parcel_code = txtParcelCode.Text.Trim
        invh.h26_register_dt = dtpRegisterDate.Value.ToString("yyyyMMdd")
        invh.h27_depart_dt = dtpDepartDate.Value.ToString("yyyyMMdd")
        invh.h28_depart_time = "00:00:00"
        invh.h29_arrive_dt = dtpArriveDate.Value.ToString("yyyyMMdd")
        invh.h30_arrive_time = "00:00:00"
        invh.h31_depart_loc = txtDepartLoc.Text.Trim
        invh.h32_arrive_loc = txtArriveLoc.Text.Trim
        invh.h33_freight_amt = FormatNumber(txtFreightAmt.Text.Trim, 4, TriState.False, TriState.False, TriState.False)
        invh.h34_insurance_amt = FormatNumber(txtInsuranceAmt.Text.Trim, 4, TriState.False, TriState.False, TriState.False)
        invh.h35_lcno = txtLcNo.Text.Trim
        invh.h36_lcdt = dtpLcDate.Value.ToString("yyyyMMdd")
        invh.h37_lcamt = FormatNumber(txtLcAmt.Text.Trim, 4, TriState.False, TriState.False, TriState.False)
        invh.h52_id_banks = (New clsConfig).IsNull(mcboBanks.SelectedValue, Nothing)
        invh.h38_bankcode = txtBankCode.Text.Trim
        invh.h39_bankname = txtBankName.Text.Trim
        invh.h40_bankbranch = txtBankBranch.Text.Trim
        invh.h41_bankacct = (New clsConfig).IsNull(bsBanks.Current("account_code"), "")
        invh.h42_shipvia = txtShipVia.Text.Trim
        invh.h43_log_empcd = clsUser.UserID
        invh.h44_is_proforma = chkProforma.Checked
        invh.h45_entry_output_no = txtEntryOutputNo.Text.Trim
        invh.h51_entry_output_date = dtpEntryOutputDate.Value 'Sitthana 20190319
        invh.h46_entry_output_status = txtEntryOutputStatus.Text.Trim
        invh.h47_boi_no = txtBOI.Text.Trim
        invh.h48_benefit = txtBenefit.Text.Trim
        invh.h49_rm_no = txtRMNo.Text.Trim
        invh.h50_pending = txtPending.Text.Trim

        invh.f01_fr_inv_no = txtFrInvNo.Text.Trim
        invh.f02_fr_inv_date = dtpFrInvDate.Value.ToString("yyyyMMdd")
        invh.f03_fr_due_date = dtpFrDueDate.Value.ToString("yyyyMMdd")
        invh.f04_fr_ref_no = txtFrRefNo.Text.Trim
        invh.f05_fr_contact = txtFrContact.Text.Trim
        invh.f06_fr_tel = txtFrTel.Text.Trim
        invh.f07_fr_vat = Val(txtFrVat.Text)
        invh.f08_fr_shipname = txtShipName.Text.Trim
        invh.f09_fr_remark = txtFrRemark.Text.Trim

        If clsINV.InvExpSave(invh, dv_add, dv_upd, dv_del, dvl_add, dvl_upd, dvl_del, dvp_add, dvp_upd, dvp_del, dvf_add, dvf_upd, dvf_del, msgerr, invid, invno) Then
            lngInvID = invid
            strInvNo = invno
            SaveData = True
        Else
            MessageBox.Show(msgerr, "System Message", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
            SaveData = False
        End If
    End Function

    Private Sub FormInvoiceExport_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized

        Call GenCombo()
        Call GenComboExpInv()
        Call GenComboPackNo()
        Call InitControl()

    End Sub

    Private Sub FormInvoiceExport_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If IsDataChange() Then Call btnSave_Click(sender, e)
        e.Cancel = blnCancel
    End Sub

    Private Sub btnNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNew.Click
        'If lngInvID <> 0 Then Call btnSave_Click(sender, e)
        'Disible By Neung 20150508
        If IsDataChange() Then Call btnSave_Click(sender, e)
        If Not blnCancel Then
            Call GenCombo()
            Call GenComboExpInv()
            Call GenComboPackNo()
            Call InitControl()
        End If
    End Sub

    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
        Dim frm As New frmInvoiceExportSearch
        frm.ShowDialog(Me)
        Call btnNew_Click(sender, e)
        Me.Cursor = Cursors.WaitCursor
        If Not blnCancel Then LoadData(frm.pInvID, "")
        Me.Cursor = Cursors.Default
        frm.Dispose()
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Me.Validate()

        blnCancel = False
        'If Not IsDataChange() Then Exit Sub
        Dim result As DialogResult
        result = MessageBox.Show("Would you like to save ?", "System Message", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button3)
        If result = DialogResult.Cancel Then blnCancel = True
        If result <> DialogResult.Yes Then Exit Sub
        If Not CheckData() Then Exit Sub
        Me.Cursor = Cursors.WaitCursor
        ' SumGridFreight() 'Fix Program not update
        ' SumGrid()  'Fix Program not update
        If SaveData() Then
            LoadData(lngInvID, "")
            Call GenComboExpInv()
        End If
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub PrintInvoice(pRptFileName As String, pTitle As String)
        If strInvNo = "" Then strInvNo = txtInvNo.Text.Trim.ToUpper
        If strInvNo.Length = 0 Then Exit Sub

        'Begin Sitthana 20190712
        'Dim rptFileName As String = ""
        'Select Case cboCustomer.SelectedValue
        '    Case CustScaviHue, CustScaviJoint
        '        rptFileName = "rptInvExportScavi.rpt"
        '    Case Else
        '        rptFileName = "rptInvExport.rpt"
        'End Select
        'End Sitthana 20190712

        '
        If Not clsConfig.CheckReport(clsUser.ReportPath, pRptFileName) Then Exit Sub

        Dim frm As New frmReport
        Dim rpt As New CrystalDecisions.CrystalReports.Engine.ReportDocument

        Me.Cursor = Cursors.WaitCursor
        rpt.Load(clsUser.ReportPath & pRptFileName)
        rpt.DataSourceConnections.Item(0).SetConnection(clsConn.servername, clsConn.database, False)
        rpt.DataSourceConnections.Item(0).SetLogon(clsConn.Userid, clsConn.Password)
        rpt.VerifyDatabase()
        rpt.SetParameterValue("@invid", lngInvID)
        rpt.SetParameterValue("@invno", "")
        rpt.SetParameterValue("@datefr", "")
        rpt.SetParameterValue("@dateto", "")
        rpt.SetParameterValue("@custcd", "")
        rpt.SetParameterValue("@for_cust", True)
        rpt.SetParameterValue("@use_show_price", False)

        'rpt.PrintOptions.PaperSize = CrystalDecisions.Shared.PaperSize.PaperA4
        'rpt.PrintOptions.PaperOrientation = CrystalDecisions.Shared.PaperOrientation.Portrait
        'rpt.PrintOptions.PaperSource = CrystalDecisions.Shared.PaperSource.Auto

        frm.Title = pTitle
        'frm.CRViewer.DisplayGroupTree = False
        frm.CRViewer.ReportSource = rpt
        frm.MdiParent = Me.ParentForm
        frm.Show()
        Me.Cursor = Cursors.Default
    End Sub
    Private Sub tsmnStandardInvoice_Click(sender As Object, e As EventArgs) Handles tsmnStandardInvoice.Click
        '768, 991    : Scavi
        '967', 968, 1133   : Pressless

        'If InStr(1, cboCustomer.Text.Trim.ToUpper, "PRESSLESS") > 0 Then
        '    MessageBox.Show("ลูกค้า Pressless ไม่สามารถพิมพ์ Standard Invoice ได้ครับ", "ข้อผิดพลาด", MessageBoxButtons.OK, MessageBoxIcon.Error)
        'Else
        '    If InStr(1, cboCustomer.Text.Trim.ToUpper, "SCAVI") > 0 Then
        '        MessageBox.Show("ลูกค้า SCAVI ไม่สามารถพิมพ์ Standard Invoice ได้ครับ", "ข้อผิดพลาด", MessageBoxButtons.OK, MessageBoxIcon.Error)
        '    Else
        '        Select Case cboCustomer.SelectedValue
        '            Case 967, 968, 1133
        '                MessageBox.Show("ลูกค้า Pressless ไม่สามารถพิมพ์ Standard Invoice ได้ครับ", "ข้อผิดพลาด", MessageBoxButtons.OK, MessageBoxIcon.Error)
        '            Case 768, 991
        '                MessageBox.Show("ลูกค้า SCAVI ไม่สามารถพิมพ์ Standard Invoice ได้ครับ", "ข้อผิดพลาด", MessageBoxButtons.OK, MessageBoxIcon.Error)
        '            Case Else
        '                PrintInvoice("rptInvExport.rpt", "Export Invoice")
        '        End Select
        '    End If
        'End If 'Sitthana 20230504

        PrintInvoice("rptInvExport.rpt", "Export Invoice") 'Sitthana 20231120 K.joom need to print
    End Sub

    Private Sub tsmnScaviInvoiceStd_Click(sender As Object, e As EventArgs) Handles tsmnScaviInvoiceStd.Click
        '768    : SCAVI HUE COMPANY
        '991    : SCAVI JOINT STOCK COMPANY
        '1107   : SCAVI JOINT STOCK COMPANY

        'If InStr(1, cboCustomer.Text.Trim.ToUpper, "SCAVI") > 0 Then
        '    PrintInvoice("rptInvExportScavi.rpt", "Export Invoice Scavi Format")
        'Else
        'Select Case cboCustomer.SelectedValue
        '        Case 768, 991, 1107
        '            PrintInvoice("rptInvExportScavi.rpt", "Export Invoice Scavi Format")
        '        Case Else
        '            MessageBox.Show("ลูกค้าต้องมีคำว่า SCAVI หรือระบุ Customer Code จึงจะพิมพ์ Scavi Invoice ได้ครับ", "ข้อผิดพลาด", MessageBoxButtons.OK, MessageBoxIcon.Error)
        '    End Select
        'End If 'Sitthana 20230504, 20231116 K.joom need to use for anthor customer
        PrintInvoice("rptInvExportScavi.rpt", "Export Invoice Scavi Format")
    End Sub

    Private Sub tsmnScaviInvoiceNoInvNo_Click(sender As Object, e As EventArgs) Handles tsmnScaviInvoiceNoInvNo.Click
        PrintInvoice("rptInvExportScaviNoInvNo.rpt", "Export Invoice Scavi Format")
    End Sub

    Private Sub tsmnPresslessInvoice_Click(sender As Object, e As EventArgs) Handles tsmnPresslessInvoice.Click
        '967  : Pressless GmbH
        '968  : PREELESS GmbH
        '1133 : Pressless GmbH

        If InStr(1, cboCustomer.Text.Trim.ToUpper, "PRESSLESS") > 0 Then
            PrintInvoice("rptInvExportPressless.rpt", "Export Invoice Pressless Format")
        Else
            Select Case cboCustomer.SelectedValue
                Case 967, 968, 1133
                    PrintInvoice("rptInvExportPressless.rpt", "Export Invoice Pressless Format")
                Case Else
                    MessageBox.Show("ลูกค้าต้องมีคำว่า Pressless หรือระบุ Customer Code จึงจะพิมพ์ Pressless Invoice ได้ครับ", "ข้อผิดพลาด", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Select
        End If 'Sitthana 20230504
    End Sub

    Private Sub PrintPacking(pRptFileName As String, pTitle As String)
        If strInvNo = "" Then strInvNo = txtInvNo.Text.Trim.ToUpper
        If strInvNo.Length = 0 Then Exit Sub

        '  
        If Not clsConfig.CheckReport(clsUser.ReportPath, pRptFileName) Then Exit Sub
        Dim frm As New frmReport
        Dim rpt As New CrystalDecisions.CrystalReports.Engine.ReportDocument
        Me.Cursor = Cursors.WaitCursor
        rpt.Load(clsUser.ReportPath & pRptFileName)
        rpt.DataSourceConnections.Item(0).SetConnection(clsConn.servername, clsConn.database, False)
        rpt.DataSourceConnections.Item(0).SetLogon(clsConn.Userid, clsConn.Password)
        rpt.VerifyDatabase()
        rpt.SetParameterValue("@invid", lngInvID)
        rpt.SetParameterValue("@invno", "")
        rpt.SetParameterValue("@datefr", "")
        rpt.SetParameterValue("@dateto", "")
        rpt.SetParameterValue("@custcd", "")

        'rpt.PrintOptions.PaperSize = CrystalDecisions.Shared.PaperSize.PaperA4
        ' rpt.PrintOptions.PaperOrientation = CrystalDecisions.Shared.PaperOrientation.Portrait
        'rpt.PrintOptions.PaperSource = CrystalDecisions.Shared.PaperSource.Auto

        frm.Title = pTitle
        'frm.CRViewer.DisplayGroupTree = False
        frm.CRViewer.ReportSource = rpt
        frm.MdiParent = Me.ParentForm
        frm.Show()
        Me.Cursor = Cursors.Default
    End Sub
    Private Sub tsmnStandardPack_Click(sender As Object, e As EventArgs) Handles tsmnStandardPack.Click
        '768    : ScaviHue
        '991    : ScaviJoint
        '967    : Pressless GmbH
        '968    : PREELESS GmbH
        ' Select Case cboCustomer.SelectedValue
        ' Case 768, 991
        ' MessageBox.Show("ลูกค้า Scavi สามารถพิมพ์ Packing รูปแบบ Scavi เท่านั้น", "ข้อผิดพลาด", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ' Case 967, 968
        'MessageBox.Show("ลูกค้า Pressless สามารถพิมพ์ Packing รูปแบบ Pressless เท่านั้น", "ข้อผิดพลาด", MessageBoxButtons.OK, MessageBoxIcon.Error)
        'Case Else
        PrintPacking("rptInvExportPacking.rpt", "Export Invoice Packing List (Standard Packing)")
        'End Select
    End Sub

    Private Sub tsmnScaviPackStd_Click(sender As Object, e As EventArgs) Handles tsmnScaviPackStd.Click
        '768    : ScaviHue
        '991    : ScaviJoint
        ' Select Case cboCustomer.SelectedValue
        ' Case 768, 991
        PrintPacking("rptInvExportPackingScavi.rpt", "Export Invoice Packing List (Scavi Format)")
        '     Case Else
        'MessageBox.Show("พิมพ์ Packing เฉพาะลูกค้า Scavi เท่านั้น", "ข้อผิดพลาด", MessageBoxButtons.OK, MessageBoxIcon.Error)
        'End Select
    End Sub

    Private Sub tsmnScaviPackNoInvNo_Click(sender As Object, e As EventArgs) Handles tsmnScaviPackNoInvNo.Click
        PrintPacking("rptInvExportPackingScaviNoInvNo.rpt", "Export Invoice Packing List (Scavi Format)")
    End Sub
    Private Sub tsmnPresslessPack_Click(sender As Object, e As EventArgs) Handles tsmnPresslessPack.Click
        '967  : Pressless GmbH
        '968  : PREELESS GmbH
        ' Select Case cboCustomer.SelectedValue
        ' Case 967, 968
        PrintPacking("rptInvExportPackingPressless.rpt", "Export Invoice Packing List (Pressless Format)")
        '    Case Else
        'MessageBox.Show("พิมพ์ Packing เฉพาะลูกค้า Pressless เท่านั้น", "ข้อผิดพลาด", MessageBoxButtons.OK, MessageBoxIcon.Error)
        'End Select
    End Sub

    Private Sub PrintPack(pReportSize As String)
        If strInvNo = "" Then strInvNo = txtInvNo.Text.Trim.ToUpper
        If strInvNo.Length = 0 Then Exit Sub
        Const rptFileName = "rptInvExportPacking.rpt"

        If Not clsConfig.CheckReport(clsUser.ReportPath, rptFileName) Then Exit Sub
        Dim frm As New frmReport
        Dim rpt As New CrystalDecisions.CrystalReports.Engine.ReportDocument
        Me.Cursor = Cursors.WaitCursor
        rpt.Load(clsUser.ReportPath & rptFileName)
        rpt.DataSourceConnections.Item(0).SetConnection(clsConn.servername, clsConn.database, False)
        rpt.DataSourceConnections.Item(0).SetLogon(clsConn.Userid, clsConn.Password)
        rpt.VerifyDatabase()
        rpt.SetParameterValue("@invid", lngInvID)
        rpt.SetParameterValue("@invno", "")
        rpt.SetParameterValue("@datefr", "")
        rpt.SetParameterValue("@dateto", "")
        rpt.SetParameterValue("@custcd", "")

        Dim NewPageMargins As New CrystalDecisions.Shared.PageMargins

        If pReportSize.ToUpper = "A4" Then
            rpt.PrintOptions.PaperSize = CrystalDecisions.Shared.PaperSize.PaperA4
            ' as 1 inch equal to 1440 tups
            NewPageMargins.leftMargin = 0.4 * 1400
            NewPageMargins.rightMargin = 0.2 * 1400
            NewPageMargins.topMargin = 0.2 * 1400
            NewPageMargins.bottomMargin = 0.2 * 1400
            rpt.PrintOptions.ApplyPageMargins(NewPageMargins)
        Else
            rpt.PrintOptions.PaperSize = CrystalDecisions.Shared.PaperSize.PaperLetter
        End If
        'rpt.PrintOptions.PaperSize = CrystalDecisions.Shared.PaperSize.PaperA4
        ' rpt.PrintOptions.PaperOrientation = CrystalDecisions.Shared.PaperOrientation.Portrait
        'rpt.PrintOptions.PaperSource = CrystalDecisions.Shared.PaperSource.Auto

        frm.Title = "Export Invoice Packing List"
        'frm.CRViewer.DisplayGroupTree = False
        frm.CRViewer.ReportSource = rpt
        frm.MdiParent = Me.ParentForm
        frm.Show()
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        If lngInvID = 0 Then Exit Sub Else Call btnSave_Click(sender, e)
        If blnCancel Then Exit Sub
        If lblCancelled.Visible Then
            MessageBox.Show("This document is already cancelled." & vbCrLf & "Can't cancel anymore.", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Exit Sub
        End If
        If MessageBox.Show("Would you like to cancel this document ?", "System Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = DialogResult.No Then Exit Sub
        Dim inv As New classInvoice
        Call inv.InvExpCancel(lngInvID, clsUser.UserID)
        Call btnNew_Click(sender, e)
    End Sub

    Private Sub btnMinimized_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMinimized.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnLoad_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLoad.Click
        Me.Cursor = Cursors.WaitCursor
        Call LoadPacking(cboPackNo.SelectedValue)
        Call SumGrid()

        'Sitthana 20190805
        '967  : Pressless GmbH
        '968  : PREELESS GmbH

        ' Comment by neung 20230223
        'Select Case cboCustomer.SelectedValue
        '    Case "967", "968"
        '        grdInv.Columns("qty").ReadOnly = False
        '    Case Else
        '        grdInv.Columns("qty").ReadOnly = True
        'End Select
        'grdInv.Columns("linediscamt").ReadOnly = False

        Me.Cursor = Cursors.Default
    End Sub
    Private Sub btnLoadAll_Click(sender As Object, e As EventArgs) Handles btnLoadAll.Click
        If cboPackNo.Items.Count > 0 Then
            Me.Cursor = Cursors.WaitCursor

            Dim PackNo As String
            PackNo = dtPackingList.Rows(cboPackNo.SelectedIndex)("packno").ToString

            If MessageBox.Show("Do you want to load data Packno ?" & PackNo, "Comfirm Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question
                               ) = vbYes Then
                Dim FilteredRows As DataRow()
                FilteredRows = dtPackingList.Select("packno='" & PackNo & "'")

                For Each row As DataRow In FilteredRows
                    Call LoadPacking(row("packno_cartno"))
                Next

                Call SumGrid()

                'Sitthana 20190805
                '967  : Pressless GmbH
                '968  : PREELESS GmbH
                'comment by neugn20230223
                'Select Case cboCustomer.SelectedValue
                '    Case "967", "968"
                '        grdInv.Columns("qty").ReadOnly = False
                '    Case Else
                '        grdInv.Columns("qty").ReadOnly = True
                'End Select
                'grdInv.Columns("linediscamt").ReadOnly = False

            End If

            Me.Cursor = Cursors.Default
        End If
    End Sub

    Private Sub btnSearchPacking_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearchPacking.Click
        Dim frm As New frmInvoiceSearchPacking
        frm.ShowDialog(Me)
        If frm.pStockType = "G" Then optStockG.Checked = True
        If frm.pStockType = "D" Then optStockD.Checked = True
        If frm.pStockType = "C" Then optStockC.Checked = True
        cboPackNo.SelectedValue = frm.pPackNoCartNo
        Call btnLoad_Click(sender, e)
    End Sub

    Private Sub cboInvNo_DropDownClosed(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboInvNo.DropDownClosed
        'On Error Resume Next
        Dim InvID As Long
        InvID = cboInvNo.ComboBox.SelectedValue
        If InvID > 0 Then
            Call btnNew_Click(sender, e)
            If Not blnCancel Then LoadData(InvID, "")
        End If
    End Sub

    Private Sub txtInvNo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtInvNo.KeyPress
        Dim InvNo As String = ""
        If Asc(e.KeyChar) = 13 Then
            InvNo = txtInvNo.Text.Trim.ToUpper
            Call btnNew_Click(sender, e)
            If Not blnCancel Then LoadData(0, InvNo)
        End If
    End Sub

    Private Sub grdInv_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles grdInv.CellEndEdit
        Call SumGrid()
    End Sub

    Private Sub grdInv_CellLeave(sender As Object, e As DataGridViewCellEventArgs) Handles grdInv.CellLeave
        'Call SumGrid()
    End Sub

    Private Sub grdInv_CellValueChanged(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles grdInv.CellValueChanged
        If e.RowIndex < 0 Or e.ColumnIndex < 0 Then Exit Sub
        If (grdInv.Columns(e.ColumnIndex).Name = "qty" Or
         grdInv.Columns(e.ColumnIndex).Name = "uprice" Or
         grdInv.Columns(e.ColumnIndex).Name = "linediscamt") And
         IsNumeric(grdInv.Rows(e.RowIndex).Cells(e.ColumnIndex).Value) Then
            grdInv.Rows(e.RowIndex).Cells("lineamt").Value = Val(clsConfig.IsNull(grdInv.Rows(e.RowIndex).Cells("qty").Value, 0)) * Val(clsConfig.IsNull(grdInv.Rows(e.RowIndex).Cells("uprice").Value, 0))
            grdInv.Rows(e.RowIndex).Cells("linenetamt").Value = Val(clsConfig.IsNull(grdInv.Rows(e.RowIndex).Cells("lineamt").Value, 0)) - Val(clsConfig.IsNull(grdInv.Rows(e.RowIndex).Cells("linediscamt").Value, 0))
            'Call SumGrid()
        End If
    End Sub

    Private Sub txtDiscAmt_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtDiscAmt.LostFocus
        Call SumGrid()
    End Sub

    Private Sub txtVat_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtVat.LostFocus
        Call SumGrid()
    End Sub

    Private Sub txtCapacity_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCapacity.LostFocus
        If txtCapacity.Text.Trim <> "" Then txtCapacity.Text = FormatNumber(txtCapacity.Text.Trim, 3, TriState.False, TriState.False, TriState.True)
    End Sub

    Private Sub txtNetAmt_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtNetAmt.LostFocus
        txtDiscAmt.Text = Val(FormatNumber(txtGrossAmt.Text, 2, TriState.False, TriState.False, TriState.False)) - (Val(FormatNumber(txtNetAmt.Text, 2, TriState.False, TriState.False, TriState.False)) / (1 + (Val(FormatNumber(txtVat.Text, 2, TriState.False, TriState.False, TriState.False)) / 100)))
        Call SumGrid()
    End Sub

    Private Sub optStockG_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles optStockG.CheckedChanged
        Call GenComboPackNo("G")
    End Sub

    Private Sub optStockD_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles optStockD.CheckedChanged
        Call GenComboPackNo("D")
    End Sub

    Private Sub optStockC_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles optStockC.CheckedChanged
        Call GenComboPackNo("C")
    End Sub
    Private Sub optStockY_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles optStockY.CheckedChanged
        Call GenComboPackNo("Y")
    End Sub

    Private Sub grdFreight_CellStyleChanged(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles grdFreight.CellStyleChanged

    End Sub

    Private Sub grdFreight_CellValueChanged(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles grdFreight.CellValueChanged
        If e.RowIndex < 0 Or e.ColumnIndex < 0 Then Exit Sub
        If (grdFreight.Columns(e.ColumnIndex).Name = "fr_amt_vat" Or
         grdFreight.Columns(e.ColumnIndex).Name = "fr_amt_non_vat") And
         IsNumeric(grdFreight.Rows(e.RowIndex).Cells(e.ColumnIndex).Value) Then
            Call SumGridFreight()
        End If

        'gengrid()
        'If e.RowIndex > 0 Then
        '    Dim i As Integer = 0
        '    For i = 0 To grdFreight.Rows.Count - 1
        '        grdFreight.Columns(0).HeaderText = "#"
        '        grdFreight.Rows(i).Cells(0).Value = i + 1
        '        grdFreight.Rows(0).Cells("fr_item_desc").Value = "SHIPPING CHARGE"
        '    Next
        'End If
        'Add By Neung 26/01/2015
        'grdFreight.Rows(0).Cells("fr_ord").Value = "1"
        'grdFreight.Rows(0).Cells("fr_item_desc").Value = "SHIPPING CHARGE"
        'grdFreight.Rows(0).Cells("fr_amt_non_vat").Value = "0.00"
        'grdFreight.Rows(0).Cells("fr_amt_vat").Value = "0.00"
    End Sub
    Private Sub gengrdFreight()
        'Add By Neung 26/01/2015
        'If e.RowIndex < 0 Or e.ColumnIndex < 0 
        'If .RowCount > 0 Then
        '    Dim i As Integer = 0
        '    For i = 0 To dgvSectionList.Rows.Count - 1

        '            .Columns(0).HeaderText = "#"
        '        dgvSectionList.Rows(i).Cells(0).Value = i + 1

        '        '.Columns(1).HeaderText = "เลขที่ผลิต"

        '        .Columns(1).HeaderText = "หน่วย"

        '        .Columns(0).Width = 40

        '        .Columns(1).Width = 5

        '        '.Columns(3).Width = 40

        '      Next()

        'End If
        'grdFreight.Rows(0).Cells("fr_ord").Value = "1"
        'grdFreight.Rows(0).Cells("fr_item_desc").Value = "SHIPPING CHARGE"
        'grdFreight.Rows(0).Cells("fr_amt_non_vat").Value = "0.00"
        'grdFreight.Rows(0).Cells("fr_amt_vat").Value = "0.00"
        'grdFreight.Rows(1).Cells("fr_ord").Value = "2"
        'grdFreight.Rows(1).Cells("fr_item_desc").Value = "SHIPPING CHARGE"
        'grdFreight.Rows(0).Cells("fr_amt_non_vat").Value = "0.00"
        'grdFreight.Rows(0).Cells("fr_amt_vat").Value = "0.00"
    End Sub

    Private Sub txtFrVat_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtFrVat.LostFocus
        Call SumGridFreight()
    End Sub

    Private Sub btnExchangeRate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExchangeRate.Click
        Dim i As Integer = 0
        If grdInv.Rows.Count > 1 Then
            Try
                Dim exrt As Double = InputBox("Input the exchange rate." & vbCrLf & "กรุณาใส่อัตราแลกเปลี่ยนเงินตรา", "System Message", "0.00")
                For i = 0 To grdInv.Rows.Count - 2
                    grdInv.Rows(i).Cells("exchange_rate").Value = exrt
                Next
            Catch ex As Exception
                MessageBox.Show(ex.Message, "System Message", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
            End Try
        End If
    End Sub


    Private Sub btnPrintLabel_Click(sender As System.Object, e As System.EventArgs) Handles btnPrintLabel.Click

    End Sub

    Private Sub grdFreight_CellContentClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles grdFreight.CellContentClick
        'Add By Neung 26/01/2015
        'grdFreight.Rows(0).Cells("fr_ord").Value = "1"
        'grdFreight.Rows(0).Cells("fr_item_desc").Value = "SHIPPING CHARGE"
        ''grdFreight.Rows(0).Cells("fr_amt_non_vat").Value = "0.00"
        ''grdFreight.Rows(0).Cells("fr_amt_vat").Value = "0.00"
        'grdFreight.Rows(1).Cells("fr_ord").Value = "2"
        'grdFreight.Rows(1).Cells("fr_item_desc").Value = "SHIPPING CHARGE"
    End Sub


    Private Sub btnPrintRollLableEsc_Click(sender As System.Object, e As System.EventArgs)
        If strInvNo = "" Then strInvNo = txtInvNo.Text.Trim.ToUpper
        If strInvNo.Length = 0 Then Exit Sub
        Const rptFileName = "rptGreigeBarcodeExport2.rpt"
        If Not clsConfig.CheckReport(clsUser.ReportPath, rptFileName) Then Exit Sub
        Dim frm As New frmReport
        Dim rpt As New CrystalDecisions.CrystalReports.Engine.ReportDocument
        Me.Cursor = Cursors.WaitCursor
        rpt.Load(clsUser.ReportPath & rptFileName)
        rpt.DataSourceConnections.Item(0).SetConnection(clsConn.servername, clsConn.database, False)
        rpt.DataSourceConnections.Item(0).SetLogon(clsConn.Userid, clsConn.Password)
        rpt.VerifyDatabase()
        rpt.SetParameterValue("@invid", lngInvID)
        rpt.SetParameterValue("@invno", "")
        rpt.SetParameterValue("@datefr", "")
        rpt.SetParameterValue("@dateto", "")
        rpt.SetParameterValue("@custcd", "")

        rpt.PrintOptions.PaperSize = CrystalDecisions.Shared.PaperSize.PaperA4
        rpt.PrintOptions.PaperOrientation = CrystalDecisions.Shared.PaperOrientation.Portrait
        rpt.PrintOptions.PaperSource = CrystalDecisions.Shared.PaperSource.Auto

        frm.Title = "Export Invoice Roll Label"
        'frm.CRViewer.DisplayGroupTree = False
        frm.CRViewer.ReportSource = rpt
        frm.MdiParent = Me.ParentForm
        frm.Show()
        Me.Cursor = Cursors.Default
    End Sub


    Private Sub cboPackNo_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cboPackNo.SelectedIndexChanged

    End Sub

    Private Function Getfreight(ByVal StrInvid As String) As Boolean
        Dim objDB As New classInvoice
        Dim dt As DataTable = objDB.InvExpFreight(StrInvid)
        If dt.Rows.Count > 0 Then
            Call BindDataFreight(dt)


            Return True
        End If
        Return False
    End Function

    Private Sub BindDataFreight(ByVal dt As DataTable)
        Dim config As New clsConfig
        'If txtReqNo.Text = "" Then Exit Sub

        grdFreight.AutoGenerateColumns = False
        If dt.Rows.Count > 0 Then
            Dim dt1 As DataTable = dt
            Dim dt2 As DataTable = grdFreight.DataSource

            Dim dr As DataRow

            Dim msg As String = ""
            Dim i As Integer = 0
            Dim j As Integer = 0
            For i = 0 To dt.Rows.Count - 1
                dr = dt2.NewRow



                For j = 0 To dt2.Columns.Count - 1

                    'dr("fr_id") = dt1.Rows(i)("fr_id")
                    'dr("invid") = dt1.Rows(i)("invid")
                    'dr("inv_no") = dt1.Rows(i)("inv_no")
                    dr("fr_ord") = dt1.Rows(i)("fr_ord")
                    dr("fr_item_code") = dt1.Rows(i)("fr_item_code")
                    dr("fr_item_desc") = dt1.Rows(i)("fr_item_desc")
                    dr("fr_vat") = dt1.Rows(i)("fr_vat")
                    dr("fr_amt_vat") = dt1.Rows(i)("fr_amt_vat")
                    dr("fr_amt_non_vat") = dt1.Rows(i)("fr_amt_non_vat")

                Next
                dt2.Rows.Add(dr)

            Next

        End If
        'Call SumGrdPackingList()


        'grdDataPackingList.DataSource = dt
        'txtReqNo.Text = dt.Rows(0)("outreqno").ToString()
    End Sub

    Private Sub BtnLoadCharge_Click(sender As System.Object, e As System.EventArgs) Handles BtnLoadCharge.Click
        LoadCharge()
    End Sub

    Private Sub LoadCharge()
        'On Error Resume Next
        Dim config As New clsConfig
        Dim objdb As New classInvoice
        Dim dt As New DataTable
        Dim dt2 As New DataTable
        Dim dr As DataRow
        Dim i As Integer = 0
        Dim j As Integer = 0
        'dt = objdb.InvLocPacking(cboPackNo.SelectedValue, lngInvID, grdInv.Rows.Count)
        If txtcharge.TextLength > 0 Then
            'cboCustomer.SelectedValue = config.IsNull(dt.Rows(0)("custcd"), "").ToString.Trim
            'txtTermCondition.Text = config.IsNull(dt.Rows(0)("cond"), "").ToString.Trim
            dt2 = grdInv.DataSource
            'For i = 0 To dt.Rows.Count - 1
            dr = dt2.NewRow
            For j = 0 To dt2.Columns.Count - 1
                dr("design_no") = txtcharge.Text
                dr("lineamt") = FormatNumber(txtlinenetamt.Text.Trim, 4, TriState.False, TriState.False, TriState.False)
                ' FormatNumber(txtGrossWeight.Text.Trim, 4, TriState.False, TriState.False, TriState.False)
                dr("linenetamt") = FormatNumber(txtlinenetamt.Text.Trim, 4, TriState.False, TriState.False, TriState.False)
                dr("linediscamt") = FormatNumber(0, 4, TriState.False, TriState.False, TriState.False)
                dr("currency") = "USD"
                dr("exchange_rate") = clsUser.ExchangeRate
                'dr(j) = dt.Rows(i)(dt2.Columns(j).ColumnName)
                dr("qty") = FormatNumber(txtQty.Text.Trim, 4, TriState.False, TriState.False, TriState.False)
                dr("uom") = cboUOM.SelectedValue

            Next
            dt2.Rows.Add(dr)
            'Next
        End If
    End Sub


    Private Sub grdInv_RowLeave(sender As Object, e As DataGridViewCellEventArgs) Handles grdInv.RowLeave
        ' Call SumGrid()
    End Sub

    Private Sub grdInv_RowsRemoved(sender As Object, e As DataGridViewRowsRemovedEventArgs) Handles grdInv.RowsRemoved
        ' Call SumGrid()
    End Sub

    Private Sub btnCOPY_Click(sender As Object, e As EventArgs) Handles btnCopy.Click
        Dim result As DialogResult
        result = MessageBox.Show("Would you like to copy " & vbCrLf &
        "Invoice No" + txtInvNo.Text + " ?", "System Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button3)
        If result = DialogResult.No Then Exit Sub

        Dim lngInvIDCopy As Int64 = lngInvID
        Dim StrInvIDCopy As String = txtInvNo.Text

        lngInvID = 0
        txtInvNo.Text = ""
        strInvNo = ""
        dtpInvDate.Value = Now
        lblCancelled.Visible = False
        blnCancel = False

        Call EnabledControl(True)
        '------- Clear Data ------------------------
        ''Call InitControl()
        Dim dt As New DataTable
        dt = (New classInvoice).InvExpDetLoad(lngInvID, strInvNo)
        Call BindGrid(dt)
        Call BindGridLabel(lngInvID)
        Call BindGridProduct(lngInvID)
        Call BindGridFreight(lngInvID)

        '------- Load New Copy ----------------------
        'Dim dtCopy As New DataTable
        'dtCopy = (New classInvoice).InvExpDetLoadCopy(lngInvIDCopy, StrInvIDCopy)
        Call BindGridCopy(lngInvIDCopy)
        Call BindGridLabelCopy(lngInvIDCopy)
        Call BindGridProductCopy(lngInvIDCopy)
        Call BindGridFreightCopy(lngInvIDCopy)

        MessageBox.Show("Invoice " + txtInvNo.Text + " is copied but not saved yet")
    End Sub

    Private Sub txtInvNo_TextChanged(sender As Object, e As EventArgs) Handles txtInvNo.TextChanged

    End Sub

    Private Sub BtnAddFreight_Click(sender As Object, e As EventArgs) Handles BtnGetMasterData.Click
        Dim dt As New DataTable
        dt = (New classInvoice).InvExpFreightMaster(lngInvID:=lngInvID)
        If dt.Rows.Count > 0 Then BindDataFreightMaster(dt)
    End Sub

    Private Sub BindDataFreightMaster(ByVal dt As DataTable)
        Dim config As New clsConfig

        grdFreight.AutoGenerateColumns = False
        If dt.Rows.Count > 0 Then
            Dim dt1 As DataTable = dt
            Dim dt2 As DataTable = grdFreight.DataSource

            Dim dr1 As DataRow

            Dim msg As String = ""
            Dim i As Integer = 0



            Dim j As Integer = 0
            For i = 0 To dt.Rows.Count - 1

                dr1 = dt2.NewRow

                dr1("fr_id") = dt1.Rows(i)("fr_id")
                dr1("invid") = dt1.Rows(i)("invid")
                dr1("invno") = dt1.Rows(i)("invno")
                dr1("fr_ord") = dt1.Rows(i)("fr_ord")
                dr1("fr_item_code") = dt1.Rows(i)("fr_item_code")
                dr1("fr_item_desc") = dt1.Rows(i)("fr_item_desc")
                dr1("fr_amt_non_vat") = dt1.Rows(i)("fr_vat")
                dr1("fr_amt_vat") = dt1.Rows(i)("fr_amt_vat")
                dr1("fr_amt_non_vat") = dt1.Rows(i)("fr_amt_non_vat")

                Dim checkDupicateRoll As Boolean = False

                If dt2.Rows.Count > 0 Then
                    For Each dr2 As DataRow In dt2.Rows
                        If dr2("fr_item_code").ToString().Equals(dt1.Rows(i)("fr_item_code")) Then
                            checkDupicateRoll = True
                        End If

                    Next
                End If
                If Not checkDupicateRoll Then
                    dt2.Rows.Add(dr1)
                End If


            Next

        End If

        Call SumGridFreight()

    End Sub

    Private Sub BindDataCopy(ByVal dtCopy As DataTable)
        Dim config As New clsConfig

        grdInv.AutoGenerateColumns = False
        If Not dtCopy.Rows.Count > 0 Then Exit Sub

        Dim dtNew As DataTable = dtCopy
        Dim dtInv As DataTable = grdInv.DataSource

        Dim drNew As DataRow

        Dim msg As String = ""
        Dim i As Integer = 0


        Dim j As Integer = 0
        For i = 0 To dtNew.Rows.Count - 1

            drNew = dtInv.NewRow
            For j = 0 To dtInv.Columns.Count - 1
                drNew(dtNew.Columns(j).ColumnName) = dtNew.Rows(i)(dtNew.Columns(j).ColumnName)

            Next

            Dim checkDupicateRoll As Boolean = False

            If dtInv.Rows.Count > 0 Then
                For Each dr2 As DataRow In dtInv.Rows
                    If dr2("fr_item_code").ToString().Equals(dtNew.Rows(i)("fr_item_code")) Then
                        checkDupicateRoll = True
                    End If

                Next
            End If
            If Not checkDupicateRoll Then
                dtInv.Rows.Add(drNew)
            End If

        Next

        Call SumGridFreight()

    End Sub

    Private Sub tsmnETHNoShowRollNoPerInvoice_Click(sender As Object, e As EventArgs)
        PrintRollLable("rptGreigeBarcodeExport1.rpt")
    End Sub

    Private Sub tsmnETHNoShowRollNoPerPack_Click(sender As Object, e As EventArgs)
        PrintRollLable("rptGreigeBarcodeExportShowRollPerPack.rpt")
    End Sub

    Private Sub tsmnStandardRollI_Click(sender As Object, e As EventArgs) Handles tsmnStandardRollI.Click
        PrintRollLable("rptGreigeBarcodeExportStandard_1.rpt")
    End Sub

    Private Sub tsmnPLDNoShowRollNoPerInvoice_Click(sender As Object, e As EventArgs) Handles tsmnPLDNoShowRollNoPerInvoice.Click
        PrintRollLable("rptGreigeBarcodeExport_PLD.rpt")
    End Sub

    Private Sub tsmnPLDNoShowRollNoPerPack_Click(sender As Object, e As EventArgs) Handles tsmnPLDNoShowRollNoPerPack.Click
        PrintRollLable("rptGreigeBarcodeExport_PLDShowRollPerPack.rpt")
    End Sub

    Private Sub CHRISTIANToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CHRISTIANToolStripMenuItem.Click
        printGreigeBarcodeExport("rptGreigeBarcodeExport2.rpt")
    End Sub

    Private Sub tsmnWedTexWSET_Click(sender As Object, e As EventArgs) Handles tsmnWedTexWSET.Click
        printGreigeBarcodeExport("rptGreigeBarcodeExportWedTex.rpt")
    End Sub

    Private Sub tsmnWedTexMJO_Click(sender As Object, e As EventArgs) Handles tsmnWedTexMJO.Click
        printGreigeBarcodeExport("rptGreigeBarcodeExportWedTexMjo.rpt")
    End Sub

    Private Sub tsmnScaviStd_Click(sender As Object, e As EventArgs) Handles tsmnScaviStd.Click
        printGreigeBarcodeExport("rptGreigeBarcodeExportScavi.rpt")
    End Sub

    Private Sub tsmnScaviNoInvNo_Click(sender As Object, e As EventArgs) Handles tsmnScaviNoInvNo.Click
        printGreigeBarcodeExport("rptGreigeBarcodeExportScaviNoInv.rpt")
    End Sub
    Private Sub WacoalToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles WacoalToolStripMenuItem.Click
        printGreigeBarcodeExport("rptGreigeBarcodeExportWacoal.rpt")
    End Sub
    Private Sub tsmnPresslessRoll_Click(sender As Object, e As EventArgs) Handles tsmnPresslessRoll.Click
        printGreigeBarcodeExport("rptGreigeBarcodeExportPressless_1.rpt")
    End Sub



    Private Sub PrintRollLable(pRptFileName As String)
        If strInvNo = "" Then strInvNo = txtInvNo.Text.Trim.ToUpper
        If strInvNo.Length = 0 Then Exit Sub


        If Not clsConfig.CheckReport(clsUser.ReportPath, pRptFileName) Then Exit Sub
        Dim frm As New frmReport
        Dim rpt As New CrystalDecisions.CrystalReports.Engine.ReportDocument
        Me.Cursor = Cursors.WaitCursor
        rpt.Load(clsUser.ReportPath & pRptFileName)
        rpt.DataSourceConnections.Item(0).SetConnection(clsConn.servername, clsConn.database, False)
        rpt.DataSourceConnections.Item(0).SetLogon(clsConn.Userid, clsConn.Password)
        rpt.VerifyDatabase()
        rpt.SetParameterValue("@invid", lngInvID)
        rpt.SetParameterValue("@invno", "")
        rpt.SetParameterValue("@datefr", "")
        rpt.SetParameterValue("@dateto", "")
        rpt.SetParameterValue("@custcd", "")

        ' rpt.PrintOptions.PaperSize = CrystalDecisions.Shared.PaperSize.PaperA4
        'rpt.PrintOptions.PaperOrientation = CrystalDecisions.Shared.PaperOrientation.Portrait
        'rpt.PrintOptions.PaperSource = CrystalDecisions.Shared.PaperSource.Auto

        frm.Title = "Export Invoice Roll Label"
        'frm.CRViewer.DisplayGroupTree = False
        frm.CRViewer.ReportSource = rpt
        frm.MdiParent = Me.ParentForm
        frm.Show()
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub BtnGennarateParcelLabel_Click(sender As Object, e As EventArgs) Handles BtnGennarateParcelLabel.Click

        Dim objdb As New classInvoice
        Dim dtLabelNew As New DataTable
        Dim LabelType As String = ""

        If rbPacelLabel_Schweniger.Checked Then
            LabelType = "STG"
        ElseIf rbPacelLabel_Pressless.Checked Then
            LabelType = "PRESSLESS"
        ElseIf rbTriumphVietnam.Checked Then
            LabelType = "TRIUMPHVIETNAM"
        ElseIf rbForRollPacking.Checked Then
            LabelType = "ROLLPACKING"
        Else
            LabelType = ""
        End If

        dtLabelNew = objdb.InvExpLabelDefault(txtInvNo.Text, LabelType)

        Dim drLabelNew As DataRow
        Dim dtLabel As DataTable

        dtLabel = grdLabel.DataSource

        'drLabelNew = dtLabel.NewRow

        For i = 0 To dtLabelNew.Rows.Count - 1
            drLabelNew = dtLabel.NewRow
            drLabelNew("lblord") = dtLabel.Rows.Count + 1
            drLabelNew("line01") = dtLabelNew.Rows(i)("line01")
            drLabelNew("line02") = dtLabelNew.Rows(i)("line02")
            drLabelNew("line03") = dtLabelNew.Rows(i)("line03")
            drLabelNew("line04") = dtLabelNew.Rows(i)("line04")
            drLabelNew("line05") = dtLabelNew.Rows(i)("line05")
            drLabelNew("line06") = dtLabelNew.Rows(i)("line06")
            drLabelNew("line07") = dtLabelNew.Rows(i)("line07")
            drLabelNew("line08") = dtLabelNew.Rows(i)("line08")
            drLabelNew("line09") = dtLabelNew.Rows(i)("line09")
            drLabelNew("line10") = dtLabelNew.Rows(i)("line10")
            drLabelNew("line11") = dtLabelNew.Rows(i)("line11")
            drLabelNew("line12") = dtLabelNew.Rows(i)("line12")
            drLabelNew("line13") = dtLabelNew.Rows(i)("line13")
            drLabelNew("line14") = dtLabelNew.Rows(i)("line14")
            drLabelNew("line15") = dtLabelNew.Rows(i)("line15")
            dtLabel.Rows.Add(drLabelNew)
        Next


    End Sub

    Private Sub btnPrdNameUp_Click(sender As Object, e As EventArgs) Handles btnPrdNameUp.Click
        With grdProduct
            Select Case .CurrentRow.Index
                Case 0
                    MessageBox.Show("รายการนี้อยู่รายการแรกสุดแล้วครับ", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Case Else
                    Dim i As Integer
                    i = .CurrentRow.Index
                    If i > 0 Then
                        Dim dt As New DataTable
                        Dim dr As DataRow
                        dt = grdProduct.DataSource
                        dr = dt.NewRow


                        Dim prodord_Curr As Integer = 0
                        prodord_Curr = .Rows(i).Cells("prodord").Value

                        With dt
                            'Keep old data of current row
                            dr("prodord") = dt.Rows(i)("prodord")
                            dr("prodname") = dt.Rows(i)("prodname")
                            dr("composition") = dt.Rows(i)("composition")

                            'Replace Current Row with Previous Row
                            dt.Rows(i)("prodord") = dt.Rows(i - 1)("prodord")
                            dt.Rows(i)("prodname") = dt.Rows(i - 1)("prodname")
                            dt.Rows(i)("composition") = dt.Rows(i - 1)("composition")

                            'Replace Previous Row with old data of current row
                            dt.Rows(i - 1)("prodord") = dr("prodord")
                            dt.Rows(i - 1)("prodname") = dr("prodname")
                            dt.Rows(i - 1)("composition") = dr("composition")

                            'Move Current Row
                            grdProduct.CurrentCell = grdProduct.Rows(i - 1).Cells(0)
                        End With
                    End If
            End Select
        End With
    End Sub

    Private Sub btnPrdNameDown_Click(sender As Object, e As EventArgs) Handles btnPrdNameDown.Click
        With grdProduct
            Select Case .CurrentRow.Index
                Case .RowCount - 2
                    MessageBox.Show("รายการนี้อยู่รายการสุดท้ายแล้วครับ", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Case Else
                    Dim i As Integer
                    i = .CurrentRow.Index
                    If i < .RowCount - 2 Then
                        Dim dt As New DataTable
                        Dim dr As DataRow
                        dt = grdProduct.DataSource
                        dr = dt.NewRow


                        Dim prodord_Curr As Integer = 0
                        prodord_Curr = .Rows(i).Cells("prodord").Value

                        With dt
                            'Keep old data of current row
                            dr("prodord") = dt.Rows(i)("prodord")
                            dr("prodname") = dt.Rows(i)("prodname")
                            dr("composition") = dt.Rows(i)("composition")

                            'Replace Current Row with Next Row
                            dt.Rows(i)("prodord") = dt.Rows(i + 1)("prodord")
                            dt.Rows(i)("prodname") = dt.Rows(i + 1)("prodname")
                            dt.Rows(i)("composition") = dt.Rows(i + 1)("composition")

                            'Replace Next Row with old data of current row
                            dt.Rows(i + 1)("prodord") = dr("prodord")
                            dt.Rows(i + 1)("prodname") = dr("prodname")
                            dt.Rows(i + 1)("composition") = dr("composition")

                            'Move Current Row
                            grdProduct.CurrentCell = grdProduct.Rows(i + 1).Cells(0)
                        End With
                    End If
            End Select
        End With
    End Sub


    Private Sub printGreigeBarcodeExport(pRptFileName As String)
        If strInvNo = "" Then strInvNo = txtInvNo.Text.Trim.ToUpper
        If strInvNo.Length = 0 Then Exit Sub
        'Const rptFileName = "rptGreigeBarcodeExport2.rpt" 'Comment by sitthana 20190115
        If Not clsConfig.CheckReport(clsUser.ReportPath, pRptFileName) Then Exit Sub
        Dim frm As New frmReport
        Dim rpt As New CrystalDecisions.CrystalReports.Engine.ReportDocument
        Me.Cursor = Cursors.WaitCursor
        rpt.Load(clsUser.ReportPath & pRptFileName)
        rpt.DataSourceConnections.Item(0).SetConnection(clsConn.servername, clsConn.database, False)
        rpt.DataSourceConnections.Item(0).SetLogon(clsConn.Userid, clsConn.Password)
        rpt.VerifyDatabase()
        rpt.SetParameterValue("@invid", lngInvID)
        rpt.SetParameterValue("@invno", "")
        rpt.SetParameterValue("@datefr", "")
        rpt.SetParameterValue("@dateto", "")
        rpt.SetParameterValue("@custcd", "")

        rpt.PrintOptions.PaperSize = CrystalDecisions.Shared.PaperSize.PaperA4
        rpt.PrintOptions.PaperOrientation = CrystalDecisions.Shared.PaperOrientation.Portrait
        rpt.PrintOptions.PaperSource = CrystalDecisions.Shared.PaperSource.Auto

        frm.Title = "Export Invoice Roll Label"
        'frm.CRViewer.DisplayGroupTree = False
        frm.CRViewer.ReportSource = rpt
        frm.MdiParent = Me.ParentForm
        frm.Show()
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub mcboBanks_DropDownCloseOnClick(sender As Object, args As MouseClickCancelEventArgs) Handles mcboBanks.DropDownCloseOnClick
        txtBankCode.Text = (New clsConfig).IsNull(bsBanks.Current("bank_code"), "") 'Me.mcboCustomersBillToFlag.ListBox.Grid.Model(Me.mcboCustomersBillToFlag.SelectedIndex + 1, 5).CellValue.ToString
        txtBankName.Text = (New clsConfig).IsNull(bsBanks.Current("bank_name"), "")
        txtBankBranch.Text = (New clsConfig).IsNull(bsBanks.Current("bank_branch"), "")
    End Sub

    Private Sub mcboBanks_SelectedIndexChanged(sender As Object, e As EventArgs) Handles mcboBanks.SelectedIndexChanged

        If txtBankCode.Text.Trim.Length = 0 Then txtBankCode.Text = (New clsConfig).IsNull(bsBanks.Current("bank_code"), "") 'Me.mcboCustomersBillToFlag.ListBox.Grid.Model(Me.mcboCustomersBillToFlag.SelectedIndex + 1, 5).CellValue.ToString
        If txtBankName.Text.Trim.Length = 0 Then txtBankName.Text = (New clsConfig).IsNull(bsBanks.Current("bank_name"), "")
        If txtBankBranch.Text.Trim.Length = 0 Then txtBankBranch.Text = (New clsConfig).IsNull(bsBanks.Current("bank_branch"), "")
    End Sub

    Private Sub PrintReport(pReportName As String)
        If Not clsConfig.CheckReport(clsUser.ReportPath, pReportName) Then Exit Sub
        Dim frm As New frmReport
        Dim rpt As New CrystalDecisions.CrystalReports.Engine.ReportDocument
        Me.Cursor = Cursors.WaitCursor
        rpt.Load(clsUser.ReportPath & pReportName)
        rpt.DataSourceConnections.Item(0).SetConnection(clsConn.servername, clsConn.database, False)
        rpt.DataSourceConnections.Item(0).SetLogon(clsConn.Userid, clsConn.Password)
        rpt.VerifyDatabase()

        If cboCustomer.SelectedValue = "892" Or cboCustomer.SelectedValue = "844" Or cboCustomer.SelectedValue = "876" Then
            rpt.SetParameterValue("@p_invid", lngInvID)
        Else
            Select Case pReportName
                Case "rptInvoiceExportCartonDyedLabelDetail.rpt", "rptDeltaInvoiceExportCartonDyedLabelDetail.rpt" _
                    , "rptInvoiceExportCartonDyedLabelDetail_Triumph.rpt", "rptInvoiceExportCartonDyedLabelDetail_Sacvi.rpt" _
                    , "rptInvoiceExportCartonDyedLabelDetailShowL7.rpt"
                    rpt.SetParameterValue("@invno", strInvNo)
                Case "rptInvoiceExportCartonDyedLabelPoInvDetail.rpt"
                    rpt.SetParameterValue("@invno", strInvNo)
                Case Else
                    rpt.SetParameterValue("@invid", lngInvID)
                    rpt.SetParameterValue("@invno", strInvNo)
                    rpt.SetParameterValue("@datefr", "")
                    rpt.SetParameterValue("@dateto", "")
                    rpt.SetParameterValue("@custcd", "")
                    rpt.SetParameterValue("@for_cust", "1")
                    rpt.SetParameterValue("@use_show_price", "0")
            End Select
        End If

        'rpt.PrintOptions.PaperSize = CrystalDecisions.Shared.PaperSize.PaperA4
        'rpt.PrintOptions.PaperOrientation = CrystalDecisions.Shared.PaperOrientation.Portrait
        ' rpt.PrintOptions.PaperSource = CrystalDecisions.Shared.PaperSource.Auto

        frm.Title = "Export Invoice Carton Label"
        'frm.CRViewer.DisplayGroupTree = False
        frm.CRViewer.ReportSource = rpt
        frm.MdiParent = Me.ParentForm
        frm.Show()
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub tsmnCartonStandard_Click(sender As Object, e As EventArgs) Handles tsmnCartonStandard.Click
        Dim rptFileName As String
        If strInvNo = "" Then strInvNo = txtInvNo.Text.Trim.ToUpper
        If strInvNo.Length = 0 Then Exit Sub
        If cboCustomer.SelectedValue = "892" Or cboCustomer.SelectedValue = "844" Or cboCustomer.SelectedValue = "876" Then
            'For LULITEX COM IMP & EXP. LTDA Only
            'rptFileName = "rptLulitexCartonLabelBigSize.rpt"
            rptFileName = "rptLulitexCartonLabel.rpt"
        Else
            rptFileName = "rptInvoiceExportCartonLabel.rpt"
        End If
        PrintReport(rptFileName)
    End Sub

    Private Sub tsmnCartonStandardWithDetail_Click(sender As Object, e As EventArgs) Handles tsmnCartonStandardWithDetail.Click
        Dim rptFileName As String
        If strInvNo = "" Then strInvNo = txtInvNo.Text.Trim.ToUpper
        If strInvNo.Length = 0 Then Exit Sub
        If cboCustomer.SelectedValue = "892" Or cboCustomer.SelectedValue = "844" Or cboCustomer.SelectedValue = "876" Then
            'For LULITEX COM IMP & EXP. LTDA Only
            'rptFileName = "rptLulitexCartonLabelBigSize.rpt"
            rptFileName = "rptLulitexCartonLabel.rpt"
        Else
            rptFileName = "rptInvoiceExportCartonLabelWithDetail.rpt"
        End If
        PrintReport(rptFileName)
    End Sub

    'Carton Dyed With Detail
    Private Sub tsmnCartonDyedWDStandard_Click(sender As Object, e As EventArgs) Handles tsmnCartonDyedWDStandard.Click
        'Sitthana 20230525
        Select Case cboCustomer.SelectedValue
            Case cstLULITEX_1, cstLULITEX_2, cstLULITEX_2 'LULITEX
                MessageBox.Show("You must select LULITEX For Print", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Case cstDeltaBogart
                MessageBox.Show("You must select Delta Bogart Lingerie For Print", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Case Else
                If strInvNo = "" Then
                    strInvNo = txtInvNo.Text.Trim.ToUpper
                End If
                If strInvNo.Length = 0 Then
                    Exit Sub
                End If
                PrintReport("rptInvoiceExportCartonDyedLabelDetail.rpt")
        End Select
    End Sub

    Private Sub tsmnStandardWithPOInvoice_Click(sender As Object, e As EventArgs) Handles tsmnStandardWithPOInvoice.Click
        'Sitthana 20240108
        PrintReport("rptInvoiceExportCartonDyedLabelPoInvDetail.rpt")
    End Sub

    Private Sub tsmnCartonDyedWDShowLine7_Click(sender As Object, e As EventArgs) Handles tsmnCartonDyedWDShowLine7.Click
        'Sitthana 20241112
        Select Case cboCustomer.SelectedValue
            Case cstLULITEX_1, cstLULITEX_2, cstLULITEX_2 'LULITEX
                MessageBox.Show("You must select LULITEX For Print", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Case cstDeltaBogart
                MessageBox.Show("You must select Delta Bogart Lingerie For Print", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Case Else
                If strInvNo = "" Then
                    strInvNo = txtInvNo.Text.Trim.ToUpper
                End If
                If strInvNo.Length = 0 Then
                    Exit Sub
                End If
                PrintReport("rptInvoiceExportCartonDyedLabelDetailShowL7.rpt")
        End Select
    End Sub

    Private Sub tsmnCartonDyedWDLulitex_Click(sender As Object, e As EventArgs) Handles tsmnCartonDyedWDLulitex.Click
        'For LULITEX Only
        'Sitthana 20230525
        Select Case cboCustomer.SelectedValue
            Case cstLULITEX_1, cstLULITEX_2, cstLULITEX_2 'LULITEX
                If strInvNo = "" Then
                    strInvNo = txtInvNo.Text.Trim.ToUpper
                End If
                If strInvNo.Length = 0 Then
                    Exit Sub
                End If
                PrintReport("rptDeltaInvoiceExportCartonDyedLabelDetail.rpt")
            Case Else
                MessageBox.Show("This option print for LULITEX  only", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Select
    End Sub

    Private Sub tsmnCartonDyedWDDeltaBogart_Click(sender As Object, e As EventArgs) Handles tsmnCartonDyedWDDeltaBogart.Click
        'For Delta Bogart Lingerie Ltd. Only
        'Sitthana 20230525
        Select Case cboCustomer.SelectedValue
            Case cstDeltaBogart
                If strInvNo = "" Then
                    strInvNo = txtInvNo.Text.Trim.ToUpper
                End If
                If strInvNo.Length = 0 Then
                    Exit Sub
                End If
                PrintReport("rptDeltaInvoiceExportCartonDyedLabelDetail.rpt")
            Case Else
                MessageBox.Show("This option print for Delta Bogart Lingerie only", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Select
    End Sub

    'Carton Greige With Detail
    Private Sub tsmnCartonGreigeWithDetailStandard_Click(sender As Object, e As EventArgs) Handles tsmnCartonGreigeWDlStandard.Click
        'Sitthana 20230525
        Select Case cboCustomer.SelectedValue
            Case cstLULITEX_1, cstLULITEX_2, cstLULITEX_2 'LULITEX
                MessageBox.Show("You must select LULITEX For Print", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Case cstDeltaBogart
                MessageBox.Show("You must select Delta Bogart Lingerie For Print", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Case Else
                If strInvNo = "" Then
                    strInvNo = txtInvNo.Text.Trim.ToUpper
                End If
                If strInvNo.Length = 0 Then
                    Exit Sub
                End If
                PrintReport("rptInvoiceExportCartonGreigeLabelDetail.rpt")
        End Select


        'Dim rptFileName As String
        'If strInvNo = "" Then strInvNo = txtInvNo.Text.Trim.ToUpper
        'If strInvNo.Length = 0 Then Exit Sub
        'If cboCustomer.SelectedValue = "892" Or cboCustomer.SelectedValue = "844" Or cboCustomer.SelectedValue = "876" Then
        '    'For LULITEX COM IMP & EXP. LTDA Only
        '    'rptFileName = "rptLulitexCartonLabelBigSize.rpt"
        '    rptFileName = "rptLulitexCartonLabel.rpt"
        'Else
        '    rptFileName = "rptInvoiceExportCartonGreigeLabelDetail.rpt"
        'End If
        'PrintReport(rptFileName)
    End Sub

    Private Sub tsmnCartonGreigeWithDetailShow7Line_Click(sender As Object, e As EventArgs) Handles tsmnCartonGreigeWDlShow7Line.Click
        'For LULITEX Only
        'Sitthana 20230525
        Select Case cboCustomer.SelectedValue
            Case cstLULITEX_1, cstLULITEX_2, cstLULITEX_2 'LULITEX
                MessageBox.Show("You must select LULITEX For Print", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Case cstDeltaBogart
                MessageBox.Show("You must select Delta Bogart Lingerie For Print", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Case Else
                If strInvNo = "" Then
                    strInvNo = txtInvNo.Text.Trim.ToUpper
                End If
                If strInvNo.Length = 0 Then
                    Exit Sub
                End If
                PrintReport("rptInvoiceExportCartonGreigeLabelDetailShowL7.rpt")
        End Select

        'Dim rptFileName As String
        'If strInvNo = "" Then strInvNo = txtInvNo.Text.Trim.ToUpper
        'If strInvNo.Length = 0 Then Exit Sub
        'rptFileName = "rptInvoiceExportCartonGreigeLabelDetailShowL7.rpt"
        'PrintReport(rptFileName)
    End Sub

    Private Sub tsmnCartonGreigeWDLulitex_Click(sender As Object, e As EventArgs) Handles tsmnCartonGreigeWDLulitex.Click
        'For LULITEX Only
        'Sitthana 20230525
        Select Case cboCustomer.SelectedValue
            Case cstLULITEX_1, cstLULITEX_2, cstLULITEX_2 'LULITEX
                If strInvNo = "" Then
                    strInvNo = txtInvNo.Text.Trim.ToUpper
                End If
                If strInvNo.Length = 0 Then
                    Exit Sub
                End If
                PrintReport("rptLulitexCartonLabel.rpt")
            Case Else
                MessageBox.Show("This option print for LULITEX  only", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Select
    End Sub

    Private Sub tsmnCartonGreigeWDDeltaBogart_Click(sender As Object, e As EventArgs) Handles tsmnCartonGreigeWDDeltaBogart.Click
        'For Delta Bogart Lingerie Ltd. Only
        'Sitthana 20230525
        Select Case cboCustomer.SelectedValue
            Case cstDeltaBogart
                If strInvNo = "" Then
                    strInvNo = txtInvNo.Text.Trim.ToUpper
                End If
                If strInvNo.Length = 0 Then
                    Exit Sub
                End If
                PrintReport("rptDeltaInvoiceExportCartonGreigeLabelDetail.rpt")
            Case Else
                MessageBox.Show("This option print for Delta Bogart Lingerie only", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Select
    End Sub

    Private Sub tsmnGreigeTriumphVietnam_Click(sender As Object, e As EventArgs) Handles tsmnGreigeTriumphVietnam.Click
        'printGreigeBarcodeExport("rptInvoiceExportCartonLabelWithDetailPressLess.rpt")
        PrintReport("rptInvoiceExportCartonLabelWithDetailTriumph.rpt")
    End Sub

    Private Sub tsmnDyedTriumphVietnam_Click(sender As Object, e As EventArgs) Handles tsmnDyedTriumphVietnam.Click
        PrintReport("rptInvoiceExportCartonDyedLabelDetail_Triumph.rpt")
    End Sub

    Private Sub tsmnDyedScavi_Click(sender As Object, e As EventArgs) Handles tsmnDyedScavi.Click
        PrintReport("rptInvoiceExportCartonDyedLabelDetail_Sacvi.rpt")
    End Sub

    Private Sub GrossWeightPackToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GrossWeightPackToolStripMenuItem.Click
        PrintPacking("rptInvExportPackingGrossWeight.rpt", "Export Invoice Packing List (Gross Weight Packing)")
    End Sub

    Private Sub tsmnScaviInvoice_Click(sender As Object, e As EventArgs) Handles tsmnScaviInvoice.Click

    End Sub
End Class
