Option Explicit On
Imports System.Math
Imports InvoiceSystemESH.Controls
Public Class frmInvoiceLocalSC
    Dim clsConfig As New clsConfig
    Dim clsConn As New classConnection
    Dim clsUser As New classUserInfo

    Dim lngInvID As Long = 0
    Dim strInvNo As String = ""
    Dim blnCancel As Boolean = False
    Dim blnChange As Boolean = False

    Dim dtBanks As New DataTable
    Dim bsBanks As New BindingSource

    Dim dtCustomersBillToFlag As New DataTable
    Dim bsCustomersBillToFlag As New BindingSource

    Dim dtCustomersShipToFlag As New DataTable
    Dim bsCustomersShipToFlag As New BindingSource

    Public Property UserInfo() As classUserInfo
        Get
            UserInfo = clsUser
        End Get
        Set(ByVal NewValue As classUserInfo)
            clsUser = NewValue
        End Set
    End Property

    Private Sub InitControl()
        Dim obj As Control
        For Each obj In Me.Controls
            Call SetControlValue(obj)
        Next
        'Dim obj As Control
        'Dim obj2 As Control
        'For Each obj In Me.Controls
        '    If TypeOf obj Is GroupBox Then
        '        For Each obj2 In obj.Controls
        '            If TypeOf obj2 Is TextBox Then
        '                If obj2.Tag = "str" Then obj2.Text = ""
        '                If obj2.Tag = "int" Then obj2.Text = "0.00"
        '            End If
        '        Next
        '    End If
        '    If TypeOf obj Is TextBox Then
        '        If obj.Tag = "str" Then obj.Text = ""
        '        If obj.Tag = "int" Then obj.Text = "0.00"
        '    End If
        '    If TypeOf obj Is MultiColumnComboBox Then
        '        Dim cbo As MultiColumnComboBox = obj
        '        cbo.SelectedIndex = -1
        '    End If
        'Next

        Call EnabledControl(True)
        lngInvID = 0
        strInvNo = ""
        GroupBox2.Text = "Local Invoice"
        mcboCustomersBillToFlag.SelectedValue = ""
        mcboCustomersShipToFlag.SelectedValue = ""
        cboSalesMan.SelectedValue = ""
        dtpInvDate.Value = Now
        txtVat.Text = "7.00"
        lblCancelled.Visible = False
        lblLocked.Visible = False
        blnCancel = False

        Call LoadData(0, "")
        txtInvNo.Focus()
    End Sub

    Private Sub SetControlValue(ByVal Obj As Control)

        If TypeOf Obj Is TextBox Then
            If Obj.Tag = "str" Then Obj.Text = ""
            If Obj.Tag = "int" Then Obj.Text = "0.00"
            'If Obj.Tag = "" Then Obj.Text = ""
        End If
        If TypeOf Obj Is DateTimePicker Then
            Dim dtp As DateTimePicker = Obj
            dtp.Value = Now
        End If
        If TypeOf Obj Is ComboBox Then
            Dim cbo As ComboBox = Obj
            If Obj.Name = "cboPackAfterBulkApp" Then
                cbo.SelectedValue = 0
            ElseIf Obj.Name = "cboMtl_warehouse" Then
                cbo.SelectedIndex = -1
            ElseIf Obj.Name = "cbofulfilment_type" Then
                cbo.SelectedIndex = -1
            Else
                cbo.SelectedValue = " "
            End If
        End If
        If TypeOf Obj Is MultiColumnComboBox Then
            Dim cbo As MultiColumnComboBox = Obj
            cbo.SelectedIndex = -1
        End If
        If TypeOf Obj Is CheckBox Then
            Dim chk As CheckBox = Obj
            chk.Checked = False
        End If
        If TypeOf Obj Is TabControl Or TypeOf Obj Is TabPage Or TypeOf Obj Is GroupBox Or TypeOf Obj Is MultiColumnComboBox Then
            Dim obj2 As Control
            For Each obj2 In Obj.Controls
                Call SetControlValue(obj2)
            Next
        End If
    End Sub

    Private Sub EnabledControl(ByVal blnEnabled)
        Dim obj As Control
        Dim obj2 As Control
        For Each obj In Me.Controls
            If TypeOf obj Is GroupBox Then
                For Each obj2 In obj.Controls
                    If TypeOf obj2 Is TextBox Then obj2.Enabled = blnEnabled
                Next
            End If
            If TypeOf obj Is TextBox Then obj.Enabled = blnEnabled
        Next
        'cboCustomer.Enabled = blnEnabled
        'cboCustomer.Enabled = False
        dtpInvDate.Enabled = blnEnabled
        grdInv.ReadOnly = Not blnEnabled
        btnLoad.Enabled = blnEnabled
        btnSearchPacking.Enabled = blnEnabled
    End Sub

    Private Sub GenCombo()
        Dim objDB As New classMaster
        dtCustomersBillToFlag = (New classSalesOrder).getCustomersBillToFlag()
        bsCustomersBillToFlag.DataSource = dtCustomersBillToFlag
        Me.mcboCustomersBillToFlag.DataSource = bsCustomersBillToFlag.DataSource
        Me.mcboCustomersBillToFlag.DisplayMember = "name"
        Me.mcboCustomersBillToFlag.ValueMember = "custcd"
        Me.mcboCustomersBillToFlag.Text = ""
        Me.mcboCustomersBillToFlag.ListBox.Grid.Model.Cols.Hidden(1) = True
        Me.mcboCustomersBillToFlag.ListBox.Grid.Model.Cols.Hidden(2) = True
        Me.mcboCustomersBillToFlag.ListBox.Grid.Model.Cols.Hidden(6) = True
        Me.mcboCustomersBillToFlag.ListBox.Grid.Model.Cols.Hidden(7) = True
        Me.mcboCustomersBillToFlag.ListBox.Grid.Model.Cols.Hidden(8) = True
        Me.mcboCustomersBillToFlag.ListBox.Grid.Model.Cols.Hidden(9) = True
        Me.mcboCustomersBillToFlag.ListBox.Grid.Model.Cols.Hidden(10) = True
        Me.mcboCustomersBillToFlag.ListBox.Grid.Model.Cols.Hidden(11) = True
        Me.mcboCustomersBillToFlag.ListBox.Grid.Model.Cols.Hidden(12) = True
        Me.mcboCustomersBillToFlag.ListBox.Grid.Model.Cols.Hidden(13) = True
        Me.mcboCustomersBillToFlag.ListBox.Grid.Model.Cols.Hidden(14) = True
        Me.mcboCustomersBillToFlag.ListBox.Grid.Model.Cols.Hidden(15) = True
        Me.mcboCustomersBillToFlag.ListBox.Grid.Model.Cols.Hidden(16) = True
        Me.mcboCustomersBillToFlag.ListBox.Grid.Model.Cols.Hidden(17) = True
        Me.mcboCustomersBillToFlag.ListBox.Grid.Model.Cols.Hidden(18) = True
        Me.mcboCustomersBillToFlag.ListBox.Grid.Model.Cols.Hidden(19) = True
        AddHandler TryCast(mcboCustomersBillToFlag.ListControl, GridListBox).Grid.Model.QueryCellInfo, AddressOf Model_QueryCellInfoCustomersBillToFlag

        dtCustomersShipToFlag = (New classSalesOrder).getCustomersShipToFlag()
        bsCustomersShipToFlag.DataSource = dtCustomersShipToFlag
        Me.mcboCustomersShipToFlag.DataSource = bsCustomersShipToFlag.DataSource
        Me.mcboCustomersShipToFlag.DisplayMember = "name"
        Me.mcboCustomersShipToFlag.ValueMember = "custcd"
        Me.mcboCustomersShipToFlag.Text = ""
        Me.mcboCustomersShipToFlag.ListBox.Grid.Model.Cols.Hidden(1) = True
        Me.mcboCustomersShipToFlag.ListBox.Grid.Model.Cols.Hidden(2) = True
        Me.mcboCustomersShipToFlag.ListBox.Grid.Model.Cols.Hidden(6) = True
        Me.mcboCustomersShipToFlag.ListBox.Grid.Model.Cols.Hidden(7) = True
        Me.mcboCustomersShipToFlag.ListBox.Grid.Model.Cols.Hidden(8) = True
        Me.mcboCustomersShipToFlag.ListBox.Grid.Model.Cols.Hidden(9) = True
        Me.mcboCustomersShipToFlag.ListBox.Grid.Model.Cols.Hidden(10) = True
        Me.mcboCustomersShipToFlag.ListBox.Grid.Model.Cols.Hidden(11) = True
        Me.mcboCustomersShipToFlag.ListBox.Grid.Model.Cols.Hidden(12) = True
        Me.mcboCustomersShipToFlag.ListBox.Grid.Model.Cols.Hidden(13) = True
        Me.mcboCustomersShipToFlag.ListBox.Grid.Model.Cols.Hidden(14) = True
        Me.mcboCustomersShipToFlag.ListBox.Grid.Model.Cols.Hidden(15) = True
        Me.mcboCustomersShipToFlag.ListBox.Grid.Model.Cols.Hidden(16) = True
        Me.mcboCustomersShipToFlag.ListBox.Grid.Model.Cols.Hidden(17) = True
        Me.mcboCustomersShipToFlag.ListBox.Grid.Model.Cols.Hidden(18) = True
        Me.mcboCustomersShipToFlag.ListBox.Grid.Model.Cols.Hidden(19) = True
        AddHandler TryCast(mcboCustomersShipToFlag.ListControl, GridListBox).Grid.Model.QueryCellInfo, AddressOf Model_QueryCellInfo2CustomersShipToFlag

        ' Me.cboCustomer.DataSource = objDB.GetCustomer
        ' Me.cboCustomer.DisplayMember = "name"
        ' Me.cboCustomer.ValueMember = "custcd"

        Me.cboSoNo.DataSource = objDB.GetSoNo
        Me.cboSoNo.DisplayMember = "sono"
        Me.cboSoNo.ValueMember = "sono"
        Me.cboSoNo.SelectedIndex = -1

        Me.cboorder_type.DataSource = objDB.GetOrder_type
        Me.cboorder_type.DisplayMember = "type_name"
        Me.cboorder_type.ValueMember = "order_type"

        'Me.design_no.DataSource = objDB.GetDesign
        'Me.design_no.DisplayMember = "design_no"
        'Me.design_no.ValueMember = "design_no"

        'Me.col.DataSource = objDB.GetColor
        'Me.col.DisplayMember = "col2"
        'Me.col.ValueMember = "col2"

        Me.uom.DataSource = objDB.GetUOM
        Me.uom.DisplayMember = "uom2"
        Me.uom.ValueMember = "uom2"

        Me.cboUOM.DataSource = objDB.GetUOM
        Me.cboUOM.DisplayMember = "uom2"
        Me.cboUOM.ValueMember = "uom2"
        cboUOM.SelectedValue = "JOB"

        dtBanks = (New classMaster).comboBanks
        bsBanks.DataSource = dtBanks
        Me.mcboBanks.DataSource = bsBanks
        Me.mcboBanks.DisplayMember = "bank_display"
        Me.mcboBanks.ValueMember = "id_banks"
        Me.mcboBanks.Text = ""
        Me.mcboBanks.ListBox.Grid.Model.Cols.Hidden(1) = True
        Me.mcboBanks.ListBox.Grid.Model.Cols.Hidden(9) = True
        AddHandler TryCast(mcboBanks.ListControl, GridListBox).Grid.Model.QueryCellInfo, AddressOf Model_QueryCellInfoBanks

        Me.cboSalesMan.DataSource = objDB.GetEmp
        Me.cboSalesMan.DisplayMember = "empname"
        Me.cboSalesMan.ValueMember = "empcd2"

        Me.currency.DataSource = objDB.GetCurrency
        Me.currency.DisplayMember = "curr"
        Me.currency.ValueMember = "curr"

    End Sub
    Private Sub Model_QueryCellInfoCustomersBillToFlag(ByVal sender As Object, ByVal e As InvoiceSystemESH.Controls.GridQueryCellInfoEventArgs)
        'To specify the row and colum index.
        If e.RowIndex = 0 AndAlso e.ColIndex = 3 Then
            e.Style.Font = New InvoiceSystemESH.Controls.GridFontInfo(New Font("Segoe UI", 12, FontStyle.Bold, GraphicsUnit.Pixel))
            e.Style.Text = "Code"
        ElseIf e.RowIndex = 0 AndAlso e.ColIndex = 4 Then
            e.Style.Font = New InvoiceSystemESH.Controls.GridFontInfo(New Font("Segoe UI", 12, FontStyle.Bold, GraphicsUnit.Pixel))
            e.Style.Text = "Name"
        ElseIf e.RowIndex = 0 AndAlso e.ColIndex = 5 Then
            e.Style.Font = New InvoiceSystemESH.Controls.GridFontInfo(New Font("Segoe UI", 12, FontStyle.Bold, GraphicsUnit.Pixel))
            e.Style.Text = "Address"
        End If
    End Sub

    Private Sub Model_QueryCellInfo2CustomersShipToFlag(ByVal sender As Object, ByVal e As InvoiceSystemESH.Controls.GridQueryCellInfoEventArgs)
        'To specify the row and colum index.
        If e.RowIndex = 0 AndAlso e.ColIndex = 3 Then
            e.Style.Font = New InvoiceSystemESH.Controls.GridFontInfo(New Font("Segoe UI", 12, FontStyle.Bold, GraphicsUnit.Pixel))
            e.Style.Text = "Code"
        ElseIf e.RowIndex = 0 AndAlso e.ColIndex = 4 Then
            e.Style.Font = New InvoiceSystemESH.Controls.GridFontInfo(New Font("Segoe UI", 12, FontStyle.Bold, GraphicsUnit.Pixel))
            e.Style.Text = "Name"
        ElseIf e.RowIndex = 0 AndAlso e.ColIndex = 5 Then
            e.Style.Font = New InvoiceSystemESH.Controls.GridFontInfo(New Font("Segoe UI", 12, FontStyle.Bold, GraphicsUnit.Pixel))
            e.Style.Text = "Address"
        End If
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

    Private Sub GenComboInvLoc()
        Dim objDB As New classInvoice
        cboInvNo.ComboBox.DataSource = objDB.InvLocSCLoad
        cboInvNo.ComboBox.DisplayMember = "invno"
        cboInvNo.ComboBox.ValueMember = "invid"
        If lngInvID > 0 Then cboInvNo.ComboBox.SelectedValue = lngInvID
    End Sub

    Private Sub GenComboPackNo(Optional ByVal stock_type As String = "G")
        Me.Cursor = Cursors.WaitCursor
        Dim objDB As New classInvoice
        Me.cboPackNo.DataSource = objDB.GetPackNo(stock_type)
        Me.cboPackNo.DisplayMember = "packno_cartno"
        Me.cboPackNo.ValueMember = "packno_cartno"
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub BindData(ByVal dt As DataTable)
        lngInvID = dt.Rows(0)("invid")
        strInvNo = dt.Rows(0)("invno").ToString.Trim
        mcboCustomersBillToFlag.SelectedValue = dt.Rows(0)("custcd").ToString.Trim
        mcboCustomersShipToFlag.SelectedValue = dt.Rows(0)("shipcd").ToString.Trim
        txtTermCondition.Text = dt.Rows(0)("cond").ToString.Trim
        txtInvNo.Text = dt.Rows(0)("invno").ToString.Trim
        dtpInvDate.Value = CDate(dt.Rows(0)("invdt2").ToString)
        txtRemark.Text = dt.Rows(0)("remark").ToString.Trim
        txtGrossAmt.Text = FormatNumber(dt.Rows(0)("grossamt"), 2, TriState.False, TriState.False, TriState.True)
        txtDiscAmt.Text = FormatNumber(dt.Rows(0)("discamt"), 2, TriState.False, TriState.False, TriState.True)
        txtPreTaxAmt.Text = FormatNumber(dt.Rows(0)("pretaxamt"), 2, TriState.False, TriState.False, TriState.True)
        txtVat.Text = FormatNumber(dt.Rows(0)("vat"), 2, TriState.False, TriState.False, TriState.True)
        txtVatAmt.Text = FormatNumber(dt.Rows(0)("vatamt"), 2, TriState.False, TriState.False, TriState.True)
        txtNetAmt.Text = FormatNumber(dt.Rows(0)("netamt"), 2, TriState.False, TriState.False, TriState.True)
        cboorder_type.SelectedValue = dt.Rows(0)("order_type").ToString.Trim
        txtChargeIssue.Text = FormatNumber(dt.Rows(0)("chargeamt"), 2, TriState.False, TriState.False, TriState.True)
        txtChargeAmt.Text = dt.Rows(0)("chargeamt").ToString
        mcboBanks.SelectedValue = dt.Rows(0)("id_banks")
        cboSalesMan.SelectedValue = dt.Rows(0)("empcd")

        If dt.Rows(0)("cancel_by").ToString.Trim.Length > 0 Then
            lblCancelled.Visible = True
            Call EnabledControl(False)
        End If
        If CBool(dt.Rows(0)("locked")) Then
            lblLocked.Visible = True
            Call EnabledControl(False)
        End If
    End Sub

    Private Sub BindGrid(ByVal dt As DataTable)
        grdInv.AutoGenerateColumns = False
        grdInv.DataSource = dt
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
        Dim dt As New DataTable
        dt = grdInv.DataSource
        Dim dv As New DataView(dt, "", "", DataViewRowState.OriginalRows)
        If dt Is Nothing Or dv.Count = 0 Then
            If grdInv.Rows.Count > 1 Then result = True
            If config.IsNull(mcboCustomersBillToFlag.SelectedValue, "").ToString.Trim <> "" Then result = True
            If txtTermCondition.Text <> "" Then result = True
            If dtpInvDate.Value.ToString("yyyyMMdd") <> Now.ToString("yyyyMMdd") Then result = True
            If txtRemark.Text <> "" Then result = True
            If Val(txtDiscAmt.Text) <> 0 Then result = True
            If Val(txtVat.Text) <> 7 Then result = True
            If Val(txtNetAmt.Text) <> 0 Then result = True
        Else
            Dim i As Integer = CheckDelRow(dt)
            If i < dt.Rows.Count Then
                If mcboCustomersBillToFlag.SelectedValue.ToString.Trim <> dt.Rows(0)("custcd").ToString.Trim Then result = True
                If txtTermCondition.Text <> dt.Rows(0)("cond").ToString.Trim Then result = True
                If dtpInvDate.Value <> CDate(dt.Rows(0)("invdt2").ToString) Then result = True
                If txtRemark.Text <> dt.Rows(0)("remark").ToString.Trim Then result = True
                If FormatNumber(txtDiscAmt.Text, 2, TriState.False, TriState.False, TriState.True) <> FormatNumber(dt.Rows(0)("discamt"), 2, TriState.False, TriState.False, TriState.True) Then result = True
                If FormatNumber(txtVat.Text, 2, TriState.False, TriState.False, TriState.True) <> FormatNumber(dt.Rows(0)("vat"), 2, TriState.False, TriState.False, TriState.True) Then result = True
                If FormatNumber(txtNetAmt.Text, 2, TriState.False, TriState.False, TriState.True) <> FormatNumber(dt.Rows(0)("netamt"), 2, TriState.False, TriState.False, TriState.True) Then result = True
            End If

            Dim delRecs As New DataView(dt, "", "", DataViewRowState.Deleted)
            If delRecs.Count > 0 Then result = True

            Dim updRecs As New DataView(dt, "", "", DataViewRowState.ModifiedCurrent)
            If updRecs.Count > 0 Then result = True

            Dim addRecs As New DataView(dt, "", "", DataViewRowState.Added)
            If addRecs.Count > 0 Then result = True
        End If

        IsDataChange = result
    End Function

    Private Function CheckData() As Boolean
        Dim result As Boolean = True

        If lblCancelled.Visible Then
            MessageBox.Show("This document is cancelled." & vbCrLf & "Can't edit anymore.", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            result = False
            Exit Function
        End If
        If lblLocked.Visible Then
            MessageBox.Show("This document is locked." & vbCrLf & "If you want to edit, Please tell IT Department.", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            result = False
            Exit Function
        End If
        If mcboCustomersBillToFlag.SelectedValue.ToString.Trim = "" Then
            MessageBox.Show("Please choose customer!!", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            CheckData = False
            Exit Function
        End If
        If grdInv.Rows.Count <= 1 Then
            MessageBox.Show("Please insert data in table at least 1 record!!", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            result = False
            Exit Function
        End If

        Dim dt As DataTable = grdInv.DataSource
        For Each dr As DataRow In dt.Rows
            If dr.RowState <> DataRowState.Deleted Then
                If (New clsConfig).IsNull(dr("exchange_rate"), 0) = 0 Then
                    MessageBox.Show("Exchange Rate should be more then 0", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
                    result = False
                End If
                If (New clsConfig).IsNull(dr("currency"), "") = "THB" And (New clsConfig).IsNull(dr("exchange_rate"), 1) <> 1 Then
                    MessageBox.Show("If currency is THB exchange eate should be 1", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
                    result = False
                End If
            End If
        Next

        Return result
    End Function

    Private Sub LoadData(ByVal InvID As Long, ByVal InvNo As String)
        Dim objDB As New classInvoice
        Dim dt As New DataTable
        dt = objDB.InvLocDetscLoad(InvID, InvNo)
        Call BindGrid(dt)
        If dt.Rows.Count > 0 Then Call BindData(dt)
        ' Add By Neung 26/02/2015
        Call SumGrid()
    End Sub
    Private Function CheckIsDuplicatePackCart(ByVal pPackno As String, ByVal pCartNo As String) As Boolean
        Dim result As Boolean = False
        Dim dtInvDet As New DataTable
        dtInvDet = grdInv.DataSource
        If dtInvDet.Rows.Count > 0 Then
            For Each row As DataRow In dtInvDet.Rows
                If row.RowState <> DataRowState.Deleted Then
                    If (New clsConfig).IsNull(row("packno"), "").ToString().Trim.Equals(pPackno) And (New clsConfig).IsNull(row("cartno"), "").ToString().Trim.Equals(pCartNo) Then
                        MessageBox.Show("คุณกำลังพยายามเลือกซ้ำ!!!", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
                        Return True 'ซ้ำ
                    End If
                End If
            Next
        End If

        Return False 'ไม่ซ้ำ
    End Function
    Private Sub LoadPacking()
        'On Error Resume Next
        Dim config As New clsConfig
        Dim objdb As New classInvoice
        Dim dt As New DataTable
        Dim dt2 As New DataTable
        Dim dr As DataRow
        Dim i As Integer = 0
        Dim j As Integer = 0
        dt = objdb.InvLocscPacking(cboPackNo.SelectedValue, lngInvID, grdInv.Rows.Count)
        If dt.Rows.Count > 0 Then

            If Not CheckDataPacking(dt) Then Exit Sub

            If config.IsNull(mcboCustomersBillToFlag.SelectedValue, "") = "" Then
                mcboCustomersBillToFlag.SelectedValue = config.IsNull(dt.Rows(0)("custcd"), "").ToString.Trim
            Else
                If mcboCustomersBillToFlag.SelectedValue <> config.IsNull(dt.Rows(0)("custcd"), "").ToString.Trim Then If MessageBox.Show("Customer is incorrect." & vbCrLf & "Would you like to change Customer Bill to?", "System Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) Then mcboCustomersBillToFlag.SelectedValue = config.IsNull(dt.Rows(0)("custcd"), "").ToString.Trim
            End If

            If config.IsNull(mcboCustomersShipToFlag.SelectedValue, "") = "" Then
                mcboCustomersShipToFlag.SelectedValue = config.IsNull(dt.Rows(0)("shipcd"), "").ToString.Trim
            Else
                If mcboCustomersShipToFlag.SelectedValue <> config.IsNull(dt.Rows(0)("shipcd"), "").ToString.Trim Then If MessageBox.Show("Ship is incorrect." & vbCrLf & "Would you like to change Ship to ?", "System Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) Then mcboCustomersShipToFlag.SelectedValue = config.IsNull(dt.Rows(0)("shipcd"), "").ToString.Trim
            End If

            If config.IsNull(cboSalesMan.SelectedValue, "") = "" Then
                cboSalesMan.SelectedValue = config.IsNull(dt.Rows(0)("empcd"), "").ToString.Trim
            Else
                If cboSalesMan.SelectedValue <> config.IsNull(dt.Rows(0)("empcd"), "").ToString.Trim Then If MessageBox.Show("Sale Person is incorrect." & vbCrLf & "Would you like to change Sale Person ?", "System Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) Then mcboCustomersShipToFlag.SelectedValue = config.IsNull(dt.Rows(0)("empcd"), "").ToString.Trim
            End If

            'mcboCustomersBillToFlag.SelectedValue = config.IsNull(dt.Rows(0)("custcd"), "").ToString.Trim 'Then
            txtTermCondition.Text = config.IsNull(dt.Rows(0)("cond"), "").ToString.Trim
            dt2 = grdInv.DataSource
            For i = 0 To dt.Rows.Count - 1
                dr = dt2.NewRow
                For j = 0 To dt2.Columns.Count - 1
                    dr(j) = dt.Rows(i)(dt2.Columns(j).ColumnName)
                Next
                ' If Not CheckIsDuplicatePackCart(config.IsNull(dt.Rows(i)("packno"), "").ToString.Trim, config.IsNull(dt.Rows(i)("cartno"), "").ToString.Trim) Then
                dt2.Rows.Add(dr)
                ' End If
            Next
        End If
    End Sub

    Private Function CheckDataPacking(ByRef dt As DataTable) As Boolean

        Dim dtInv As DataTable = grdInv.DataSource

        For Each dr As DataRow In dt.Rows
            For Each drInv As DataRow In dtInv.Rows
                If drInv.RowState <> DataRowState.Deleted Then
                    If drInv.Item("currency").ToString.Trim <> dr.Item("currency").ToString.Trim Then
                        MessageBox.Show("คุณกำลัง Load Packing List ที่ ต่างสกุลเงินกัน โปรแกรมไม่สามารถทำให้ได้ กรุณาเลือก Packing อื่นหรือทำการแก้ไขก่อน", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
                        Return False
                    End If
                End If
            Next
        Next

        Return True
    End Function

    Private Sub SumGrid()
        Dim i As Integer = 0
        Dim dblGrossAmt As Decimal = 0
        Dim dblDiscAmt As Decimal = Val(txtDiscAmt.Text)
        Dim dblPreTaxAmt As Decimal = 0
        Dim dblVat As Decimal = txtVat.Text
        Dim dblVatAmt As Decimal = 0
        Dim dblNetAmt As Decimal = 0
        'Add By Neung 26/02/2015
        Dim dblChargeAmt As Decimal = Val(txtqty.Text)
        For i = 0 To grdInv.Rows.Count - 1
            dblGrossAmt = dblGrossAmt + Format(Val(clsConfig.IsNull(grdInv.Rows(i).Cells("linenetamt").Value, 0)), "#.#0")
        Next
        'Add By Neung 26/02/2015
        dblGrossAmt = dblGrossAmt '+ Format(dblChargeAmt, "#,###.#0")
        dblPreTaxAmt = dblGrossAmt - dblDiscAmt
        dblVatAmt = Format((dblPreTaxAmt * dblVat) / 100, "#.#0")
        'dblNetAmt = Round((dblPreTaxAmt * (100 + dblVat)) / 100, 2)
        dblNetAmt = dblPreTaxAmt + dblVatAmt
        txtGrossAmt.Text = Format(dblGrossAmt, "#,###.#0")
        txtDiscAmt.Text = Format(dblDiscAmt, "#,###.#0")
        txtPreTaxAmt.Text = Format(dblPreTaxAmt, "#,###.#0")
        txtVat.Text = Format(dblVat, "#,###.#0")
        txtVatAmt.Text = Format(dblVatAmt, "#,###.#0")
        txtNetAmt.Text = Format(dblNetAmt, "#,###.#0")
    End Sub

    Private Function SaveData() As Boolean
        Dim clsINV As New classInvoice
        Dim invh As classInvoice.InvLocHeader
        Dim msgerr As String = ""
        Dim invid As Long = 0
        Dim invno As String = ""
        Dim dt As New DataTable
        dt = grdInv.DataSource
        Dim dv_add As New DataView(dt, "", "", DataViewRowState.Added)
        Dim dv_upd As New DataView(dt, "", "", DataViewRowState.ModifiedCurrent)
        Dim dv_del As New DataView(dt, "", "", DataViewRowState.Deleted)
        invh.h01_invid = lngInvID
        invh.h02_invno = strInvNo
        invh.h03_invdt = dtpInvDate.Value.ToString("yyyyMMdd")
        invh.h04_cond = txtTermCondition.Text.Trim
        invh.h05_custcd = mcboCustomersBillToFlag.SelectedValue.ToString.Trim
        invh.h06_shipcd = mcboCustomersShipToFlag.SelectedValue.ToString.Trim
        invh.h07_credit = 0
        invh.h08_grossamt = FormatNumber(txtGrossAmt.Text.Trim, 4, TriState.False, TriState.False, TriState.False)
        invh.h09_discamt = txtDiscAmt.Text.Trim
        invh.h10_pretaxamt = txtPreTaxAmt.Text.Trim
        invh.h11_vat = txtVat.Text.Trim
        invh.h12_vatamt = txtVatAmt.Text.Trim
        invh.h13_netamt = txtNetAmt.Text.Trim
        invh.h14_remark = txtRemark.Text.Trim
        invh.h15_log_empcd = clsUser.UserID
        invh.h16_order_type = cboorder_type.SelectedValue.ToString.Trim
        invh.h17_chargetxt = txtChargeIssue.Text.Trim
        invh.h18_chargeamt = FormatNumber(txtChargeAmt.Text.Trim, 4, TriState.False, TriState.False, TriState.False)
        invh.h19_id_banks = (New clsConfig).IsNull(mcboBanks.SelectedValue, Nothing)
        invh.h20_empcd = (New clsConfig).IsNull(cboSalesMan.SelectedValue, Nothing)

        If clsINV.InvLocSCSave(invh, dv_add, dv_upd, dv_del, msgerr, invid, invno) Then
            lngInvID = invid
            strInvNo = invno
            SaveData = True
        Else
            MessageBox.Show(msgerr, "System Message", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
            SaveData = False
        End If
    End Function

    Private Sub FormInvoiceLocal_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized

        Call GenCombo()
        Call GenComboInvLoc()
        Call GenComboPackNo()
        Call InitControl()
    End Sub

    Private Sub FormInvoiceLocal_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If IsDataChange() Then Call btnSave_Click(sender, e)
        e.Cancel = blnCancel
    End Sub

    Private Sub btnNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNew.Click
        If IsDataChange() Then Call btnSave_Click(sender, e)
        If Not blnCancel Then Call InitControl()
    End Sub

    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
        Dim frm As New frmInvoiceLocalSearch
        frm.ShowDialog(Me)
        Call btnNew_Click(sender, e)
        Me.Cursor = Cursors.WaitCursor
        If Not blnCancel Then LoadData(frm.pInvID, "")
        frm.Dispose()
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Me.Validate()

        txtInvNo.Focus()
        Call SumGrid()
        blnCancel = False
        'If Not IsDataChange() Then Exit Sub
        Dim result As DialogResult
        result = MessageBox.Show("Would you like to save ?", "System Message", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button3)
        If result = DialogResult.Cancel Then blnCancel = True
        If result <> DialogResult.Yes Then Exit Sub
        If Not CheckData() Then Exit Sub
        Me.Cursor = Cursors.WaitCursor
        If SaveData() Then
            LoadData(lngInvID, "")
            Call GenComboInvLoc()
        End If
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub btnPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrint.Click
        'Add By Neung 27/02/2015
        Call SumGrid()
        If strInvNo = "" Then strInvNo = txtInvNo.Text.Trim.ToUpper
        If strInvNo.Length = 0 Then Exit Sub
        Const rptFileName = "rptInvLocalSC.rpt"
        If Not clsConfig.CheckReport(clsUser.ReportPath, rptFileName) Then Exit Sub
        Dim frm As New frmReport
        Dim rpt As New CrystalDecisions.CrystalReports.Engine.ReportDocument
        Me.Cursor = Cursors.WaitCursor
        rpt.Load(clsUser.ReportPath & rptFileName)
        rpt.PrintOptions.PaperSize = CrystalDecisions.Shared.PaperSize.PaperA4
        rpt.DataSourceConnections.Item(0).SetConnection(clsConn.servername, clsConn.database, False)
        rpt.DataSourceConnections.Item(0).SetLogon(clsConn.Userid, clsConn.Password)
        rpt.VerifyDatabase()
        rpt.SetParameterValue("@invid", lngInvID)
        rpt.SetParameterValue("@invno", "")
        rpt.SetParameterValue("@datefr", "")
        rpt.SetParameterValue("@dateto", "")
        rpt.SetParameterValue("@language", "TH")
        rpt.SetParameterValue("@custcd", "")
        rpt.SetParameterValue("@chargetxt", txtItdesc.Text)
        rpt.SetParameterValue("@chargeamt", txtqty.Text)

        'rpt.PrintOptions.PaperSize = CrystalDecisions.Shared.PaperSize.PaperLetter
        'rpt.PrintOptions.PaperOrientation = CrystalDecisions.Shared.PaperOrientation.Portrait
        'rpt.PrintOptions.PaperSource = CrystalDecisions.Shared.PaperSource.Auto

        frm.Title = "Local Invoice SC"
        'frm.CRViewer.DisplayGroupTree = False
        frm.CRViewer.ReportSource = rpt
        frm.MdiParent = Me.ParentForm
        frm.Show()
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Dim message As String = ""
        If lngInvID = 0 Then Exit Sub Else Call btnSave_Click(sender, e)
        If blnCancel Then Exit Sub
        If lblCancelled.Visible Then
            MessageBox.Show("This document is already cancelled." & vbCrLf & "Can't cancel anymore.", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Exit Sub
        End If
        If MessageBox.Show("Would you like to cancel this document ?", "System Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = DialogResult.No Then Exit Sub
        Dim inv As New classInvoice
        If inv.InvLocCancel(lngInvID, clsUser.UserID, message) Then
            MessageBox.Show("ยกเลิกสำเร็จ", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
        Else
            MessageBox.Show("ยกเลิก ไม่สำเร็จ : " + message, "System Message", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
        End If
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
        Call LoadPacking()
        Call SumGrid()
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub btnSearchPacking_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearchPacking.Click
        Dim frm As New frmInvoiceSearchPacking
        frm.ShowDialog(Me)
        If frm.pStockType = "G" Then optStockG.Checked = True
        If frm.pStockType = "D" Then optStockD.Checked = True
        If frm.pStockType = "C" Then optStockC.Checked = True
        If frm.pStockType = "Y" Then optStockY.Checked = True
        cboPackNo.SelectedValue = frm.pPackNoCartNo
        frm.Dispose()
        Call btnLoad_Click(sender, e)
    End Sub

    Private Sub cboInvNo_DropDownClosed(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboInvNo.DropDownClosed
        On Error Resume Next
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

    Private Sub grdInv_CellValueChanged(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles grdInv.CellValueChanged
        If e.RowIndex < 0 Or e.ColumnIndex < 0 Then Exit Sub
        If grdInv.Columns(e.ColumnIndex).Name = "qty" Or
         grdInv.Columns(e.ColumnIndex).Name = "uprice" Or
         grdInv.Columns(e.ColumnIndex).Name = "linediscamt" Then
            grdInv.Rows(e.RowIndex).Cells("lineamt").Value = Val(clsConfig.IsNull(grdInv.Rows(e.RowIndex).Cells("qty").Value, 0)) * Val(clsConfig.IsNull(grdInv.Rows(e.RowIndex).Cells("uprice").Value, 0))
            grdInv.Rows(e.RowIndex).Cells("linenetamt").Value = Val(clsConfig.IsNull(grdInv.Rows(e.RowIndex).Cells("lineamt").Value, 0)) - Val(clsConfig.IsNull(grdInv.Rows(e.RowIndex).Cells("linediscamt").Value, 0))
            Call SumGrid()
        End If
    End Sub

    Private Sub grdInv_UserDeletedRow(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewRowEventArgs) Handles grdInv.UserDeletedRow
        Call SumGrid()
    End Sub

    Private Sub txtDiscAmt_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtDiscAmt.LostFocus
        Call SumGrid()
    End Sub

    Private Sub txtVat_KeyDown(sender As Object, e As KeyEventArgs) Handles txtVat.KeyDown
        If e.KeyCode = Keys.Enter Then
            Call SumGrid()
        End If
    End Sub

    Private Sub txtVat_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtVat.LostFocus
        Call SumGrid()
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

    Private Sub cboInvNo_Click(sender As System.Object, e As System.EventArgs) Handles cboInvNo.Click

    End Sub

    Private Sub txtGrossAmt_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtGrossAmt.TextChanged

    End Sub

    Private Sub txtChargeAmt_LostFocus(sender As Object, e As System.EventArgs)
        SumGrid()
    End Sub

    Private Sub txtChargeAmt_TextChanged(sender As System.Object, e As System.EventArgs)

    End Sub

    Private Sub BtnLoadCharge_Click(sender As System.Object, e As System.EventArgs) Handles BtnLoadCharge.Click
        Call LoadCharge()
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

        dt2 = grdInv.DataSource
        dr = dt2.NewRow
        dr("design_no") = txtItdesc.Text
        dr("itdesc") = txtDesignNo.Text.Trim
        dr("cust_design") = txtItdesc.Text
            dr("col") = txtCol.Text.Trim
            dr("grade") = txtGrade.Text.Trim
            dr("qty") = txtqty.Text.Trim
            dr("uom") = cboUOM.SelectedValue
            dr("uprice") = txtUprice.Text
            dr("lineamt") = txtUprice.Text * txtqty.Text.Trim
            dr("linediscamt") = 0
            dr("linenetamt") = txtUprice.Text * txtqty.Text.Trim
            dr("pono") = txtCustPO.Text
            dr("sono") = cboSoNo.SelectedValue
            dr("sonoid") = txtSonoId.Text.Trim
            dt2.Rows.Add(dr)

    End Sub


    Private Sub mcboCustomersBillToFlag_DropDownCloseOnClick(sender As Object, args As MouseClickCancelEventArgs) Handles mcboCustomersBillToFlag.DropDownCloseOnClick
        bsCustomersShipToFlag.Filter = "parent_customer_id = " & Me.mcboCustomersBillToFlag.ListBox.Grid.Model(Me.mcboCustomersBillToFlag.SelectedIndex + 1, 1).CellValue & "" 'Disible By Neung K.Piew No Need to Filter Cust Deli
        Call bindCustomerBillToData()
        Call bindCustomerShipToData()
    End Sub

    Private Sub bindCustomerBillToData()
        Dim config As New clsConfig
        Dim i As Integer = 0
        Dim dt As DataTable = bsCustomersBillToFlag.DataSource 'cboCustomer.DataSource
        Dim dt2 As New DataTable
        dt2 = dt.Copy()
        For i = 0 To dt2.Rows.Count - 1
            If dt2.Rows(i)("custcd").ToString.Trim = config.IsNull(Me.mcboCustomersBillToFlag.ListBox.Grid.Model(Me.mcboCustomersBillToFlag.SelectedIndex + 1, 3).CellValue.ToString, "").ToString.Trim Then

                '  cboAgent.SelectedValue = dt2.Rows(i)("new_agcd").ToString.Trim
                txtTermCondition.Text = dt2.Rows(i)("new_payterms").ToString.Trim
                ' txtCreditDays.Text = dt2.Rows(i)("new_credit").ToString.Trim
                ' txtDeliveryTerm.Text = dt2.Rows(i)("deli").ToString.Trim
                ' txtCustAddr.Text = dt2.Rows(i)("custaddr").ToString.Trim()
                ' txtContact.Text = dt2.Rows(i)("contact").ToString.Trim
                'cboBank1.SelectedValue = dt2.Rows(i)("bank_code").ToString.Trim 'Add By Neung 30/10/2015
                mcboBanks.SelectedValue = dt2.Rows(i)("id_banks") '.ToString.Trim
                Exit For
            End If
        Next

    End Sub

    Private Sub bindCustomerShipToData()
        Dim config As New clsConfig
        Dim i As Integer = 0
        Dim dt As DataTable = bsCustomersShipToFlag.DataSource 'cboDeliveryLoc.DataSource
        ' Dim dt2 As New DataTable
        ' dt2 = dt.Copy()
        'For i = 0 To dt2.Rows.Count - 1
        'If dt2.Rows(i)("custcd").ToString.Trim = config.IsNull(Me.mcboCustomersBillToFlag.ListBox.Grid.Model(Me.mcboCustomersBillToFlag.SelectedIndex + 1, 3).CellValue.ToString, "").ToString.Trim Then
        'txtDeliAddr.Text = dt2.Rows(i)("custaddr").ToString.Trim
        'txtTransportBy.Text = Me.mcboCustomersShipToFlag.ListBox.Grid.Model(Me.mcboCustomersShipToFlag.SelectedIndex + 1, 14).CellValue.ToString.Trim
        ' txtAdditionalLabel.Text = Me.mcboCustomersShipToFlag.ListBox.Grid.Model(Me.mcboCustomersShipToFlag.SelectedIndex + 1, 15).CellValue.ToString.Trim
        'txtDeliAddr.Text = Me.mcboCustomersShipToFlag.ListBox.Grid.Model(Me.mcboCustomersShipToFlag.SelectedIndex + 1, 5).CellValue.ToString.Trim

        '          Exit For
        ' End If
        ' Next
    End Sub

    Private Sub mcboCustomersBillToFlag_SelectedIndexChanged(sender As Object, e As EventArgs) Handles mcboCustomersBillToFlag.SelectedIndexChanged
        bsCustomersShipToFlag.Filter = "parent_customer_id = " & Me.mcboCustomersBillToFlag.ListBox.Grid.Model(Me.mcboCustomersBillToFlag.SelectedIndex + 1, 1).CellValue & "" 'Disible By Neung K.Piew No Need to Filter Cust Deli
        Call bindCustomerBillToData()
        Call bindCustomerShipToData()
        'Call BindCustomerBillToAddr()
        'Call BindCustomerShipToAddr()

        ''Begin - Sitthana 19/09/2018
        'With mcboCustomersBillToFlag
        '    If .ListBox.Grid.Model(.SelectedIndex + 1, 18).CellValue = "1" Then
        '        If HadRight Then
        '            btnSave.Enabled = True
        '            tsbConfirmOrder.Enabled = True
        '        End If
        '        lblCustomersActive.Visible = False
        '    ElseIf .ListBox.Grid.Model(.SelectedIndex + 1, 18).CellValue = "0" Then
        '        If HadRight Then
        '            btnSave.Enabled = False
        '            tsbConfirmOrder.Enabled = False
        '        End If
        '        lblCustomersActive.Visible = True
        '        MessageBox.Show("ลูกค้าท่านนี้ ได้ถูกยกเลิกไปแล้ว " & vbCr _
        '                  & "   - คุณไม่สามารถสร้าง SO ได้" & vbCr _
        '                  & "   - คุณสามารถ ยกเลิก หรือ Unconfirm ได้เท่านั้น" _
        '                  , "ข้อความเตือน", MessageBoxButtons.OK, MessageBoxIcon.Information)
        '    End If
        'End With

    End Sub

    Private Sub mcboBanks_DropDownCloseOnClick(sender As Object, args As MouseClickCancelEventArgs) Handles mcboBanks.DropDownCloseOnClick
        Call BindDataBanks()
    End Sub

    Private Sub BindDataBanks()
        If txtBankCode.Text.Trim.Length = 0 Then txtBankCode.Text = (New clsConfig).IsNull(bsBanks.Current("bank_code"), "") 'Me.mcboCustomersBillToFlag.ListBox.Grid.Model(Me.mcboCustomersBillToFlag.SelectedIndex + 1, 5).CellValue.ToString
        If txtBankName.Text.Trim.Length = 0 Then txtBankName.Text = (New clsConfig).IsNull(bsBanks.Current("bank_name"), "")
        If txtBankBranch.Text.Trim.Length = 0 Then txtBankBranch.Text = (New clsConfig).IsNull(bsBanks.Current("bank_branch"), "")
    End Sub

    Private Sub mcboBanks_SelectedIndexChanged(sender As Object, e As EventArgs) Handles mcboBanks.SelectedIndexChanged
        Call BindDataBanks()
    End Sub

    Private Sub btnPrintInvoiceTH_Click(sender As Object, e As EventArgs) Handles btnPrintInvoiceTH.Click
        'Add By Neung 27/02/2015
        Call SumGrid()
        If strInvNo = "" Then strInvNo = txtInvNo.Text.Trim.ToUpper
        If strInvNo.Length = 0 Then Exit Sub
        Const rptFileName = "rptInvLocalSC.rpt"
        If Not clsConfig.CheckReport(clsUser.ReportPath, rptFileName) Then Exit Sub
        Dim frm As New frmReport
        Dim rpt As New CrystalDecisions.CrystalReports.Engine.ReportDocument
        Me.Cursor = Cursors.WaitCursor
        rpt.Load(clsUser.ReportPath & rptFileName)
        rpt.PrintOptions.PaperSize = CrystalDecisions.Shared.PaperSize.PaperA4
        rpt.DataSourceConnections.Item(0).SetConnection(clsConn.servername, clsConn.database, False)
        rpt.DataSourceConnections.Item(0).SetLogon(clsConn.Userid, clsConn.Password)
        rpt.VerifyDatabase()
        rpt.SetParameterValue("@invid", lngInvID)
        rpt.SetParameterValue("@invno", "")
        rpt.SetParameterValue("@datefr", "")
        rpt.SetParameterValue("@dateto", "")
        rpt.SetParameterValue("@language", "TH")
        rpt.SetParameterValue("@custcd", "")
        rpt.SetParameterValue("@chargetxt", txtItdesc.Text)
        rpt.SetParameterValue("@chargeamt", txtqty.Text)

        'rpt.PrintOptions.PaperSize = CrystalDecisions.Shared.PaperSize.PaperLetter
        'rpt.PrintOptions.PaperOrientation = CrystalDecisions.Shared.PaperOrientation.Portrait
        'rpt.PrintOptions.PaperSource = CrystalDecisions.Shared.PaperSource.Auto

        frm.Title = "Local Invoice SC"
        'frm.CRViewer.DisplayGroupTree = False
        frm.CRViewer.ReportSource = rpt
        frm.MdiParent = Me.ParentForm
        frm.Show()
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub btnPrintInvoiceEN_Click(sender As Object, e As EventArgs) Handles btnPrintInvoiceEN.Click
        'Add By Neung 27/02/2015
        Call SumGrid()
        If strInvNo = "" Then strInvNo = txtInvNo.Text.Trim.ToUpper
        If strInvNo.Length = 0 Then Exit Sub
        Const rptFileName = "rptInvLocalSC.rpt"
        If Not clsConfig.CheckReport(clsUser.ReportPath, rptFileName) Then Exit Sub
        Dim frm As New frmReport
        Dim rpt As New CrystalDecisions.CrystalReports.Engine.ReportDocument
        Me.Cursor = Cursors.WaitCursor
        rpt.Load(clsUser.ReportPath & rptFileName)
        rpt.PrintOptions.PaperSize = CrystalDecisions.Shared.PaperSize.PaperA4
        rpt.DataSourceConnections.Item(0).SetConnection(clsConn.servername, clsConn.database, False)
        rpt.DataSourceConnections.Item(0).SetLogon(clsConn.Userid, clsConn.Password)
        rpt.VerifyDatabase()
        rpt.SetParameterValue("@invid", lngInvID)
        rpt.SetParameterValue("@invno", "")
        rpt.SetParameterValue("@datefr", "")
        rpt.SetParameterValue("@dateto", "")
        rpt.SetParameterValue("@language", "EN")
        rpt.SetParameterValue("@custcd", "")
        rpt.SetParameterValue("@chargetxt", txtItdesc.Text)
        rpt.SetParameterValue("@chargeamt", txtqty.Text)

        'rpt.PrintOptions.PaperSize = CrystalDecisions.Shared.PaperSize.PaperLetter
        'rpt.PrintOptions.PaperOrientation = CrystalDecisions.Shared.PaperOrientation.Portrait
        'rpt.PrintOptions.PaperSource = CrystalDecisions.Shared.PaperSource.Auto

        frm.Title = "Local Invoice SC"
        'frm.CRViewer.DisplayGroupTree = False
        frm.CRViewer.ReportSource = rpt
        frm.MdiParent = Me.ParentForm
        frm.Show()
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub txtDiscAmt_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtDiscAmt.Validating
        Call SumGrid()  'Neung 20250818
    End Sub

    Private Sub txtVat_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtVat.Validating
        Call SumGrid() 'Neung 20250818
    End Sub
End Class