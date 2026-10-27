Public Class frmDebitNoteCharge
#Region "Variables"
    'l = Local Variable, p = Public Variable
    'str = String, int = Integer, lng = Long, dbl = Double,
    'bln = Boolean, dat = Date, cls = Class
    Private clsConfig As New clsConfig
    Private clsUser As New classUserInfo

    Private lLngDocID As Long = 0
    Private lStrDocNo As String = ""
    Private lBlnCancel As Boolean = False
    Private lIntIdx As Integer = 0
    Private lObjOldData As DataTable = Nothing
#End Region

#Region "Properties"
    Public Property UserInfo() As classUserInfo
        Get
            UserInfo = clsUser
        End Get
        Set(ByVal NewValue As classUserInfo)
            clsUser = NewValue
        End Set
    End Property

    Public Property DocID() As Long
        Get
            DocID = lLngDocID
        End Get
        Set(ByVal NewValue As Long)
            lLngDocID = NewValue
        End Set
    End Property

    Public Property DocNo() As String
        Get
            DocNo = lStrDocNo
        End Get
        Set(ByVal NewValue As String)
            lStrDocNo = NewValue
        End Set
    End Property
#End Region

#Region "General Function"
    Private Sub SetControlValue(ByVal Obj As Control)
        If TypeOf Obj Is TextBox Then
            Obj.Text = Obj.AccessibleDescription
        ElseIf TypeOf Obj Is DateTimePicker Then
            Dim dtp As DateTimePicker = Obj
            If IsDate(dtp.AccessibleDescription) Then
                dtp.Value = CDate(dtp.AccessibleDescription)
            Else
                dtp.Value = Now
            End If
        ElseIf TypeOf Obj Is ComboBox Then
            Dim cbo As ComboBox = Obj
            'If cbo.AccessibleDescription = "" Then
            cbo.SelectedIndex = -1
            'Else
            '	cbo.SelectedValue = cbo.AccessibleDescription
            'End If
        ElseIf TypeOf Obj Is CheckBox Then
            Dim chk As CheckBox = Obj
            chk.Checked = CBool(Val(chk.AccessibleDescription))
        ElseIf TypeOf Obj Is ContainerControl Or Obj.HasChildren Then
            Dim obj2 As Control
            For Each obj2 In Obj.Controls
                Call SetControlValue(obj2)
            Next
        End If
    End Sub

    Public Sub InitControl()
        Dim obj As Control
        For Each obj In Me.Controls
            If Not TypeOf obj Is ToolStrip Then Call SetControlValue(obj)
            If obj.Name = "txtDocNo" Then obj.Focus()
        Next
        Call EnabledControl(True)
        Call LoadData("")
        lLngDocID = 0
        lStrDocNo = ""
        lBlnCancel = False
        lIntIdx = 0
        lObjOldData = Nothing
    End Sub

    Private Sub SetControlEnabled(ByVal Obj As Control, ByVal blnEnabled As Boolean)
        If TypeOf Obj Is TextBox Then Obj.Enabled = blnEnabled
        If TypeOf Obj Is DateTimePicker Then Obj.Enabled = blnEnabled
        If TypeOf Obj Is ComboBox Then Obj.Enabled = blnEnabled
        If TypeOf Obj Is CheckBox Then Obj.Enabled = blnEnabled
        If TypeOf Obj Is DataGridView Then
            Dim grd As DataGridView = Obj
            grd.ReadOnly = Not blnEnabled
        End If
        If TypeOf Obj Is ContainerControl Or Obj.HasChildren Then
            Dim obj2 As Control
            For Each obj2 In Obj.Controls
                Call SetControlEnabled(obj2, blnEnabled)
            Next
        End If
    End Sub

    Public Sub EnabledControl(ByVal blnEnabled As Boolean)
        Dim obj As Control
        For Each obj In Me.Controls
            If Not TypeOf obj Is ToolStrip Then
                If obj.Name = "txtDocNo" Then
                    Call SetControlEnabled(obj, True)
                Else
                    Call SetControlEnabled(obj, blnEnabled)
                End If
            End If
        Next
    End Sub

    Private Sub SetCombo(ByRef cbo As ComboBox)
        Dim objDB As New classMaster
        Select Case cbo.Name
            Case "cboAgent"
                cbo.DataSource = objDB.GetAgent
                cbo.DisplayMember = "agname2"
                cbo.ValueMember = "agcd2"
            Case "cboColor"
                cbo.DataSource = objDB.GetColor
                cbo.DisplayMember = "colname2"
                cbo.ValueMember = "col2"
            Case "cboCountry"
                cbo.DataSource = objDB.GetCountry
                cbo.DisplayMember = "name2"
                cbo.ValueMember = "ctry2"
            Case "cboCurrency"
                cbo.DataSource = objDB.GetCurrency
                cbo.DisplayMember = "currname"
                cbo.ValueMember = "curr"
            Case "cboCustomer"
                cbo.DataSource = objDB.GetCustomer
                cbo.DisplayMember = "new_custname"
                cbo.ValueMember = "new_custcd"
            Case "cboDesignNo"
                cbo.DataSource = objDB.GetDesign
                cbo.DisplayMember = "design_no"
                cbo.ValueMember = "design_no"
            Case "cboDesignGroup"
                cbo.DataSource = objDB.GetDesignGroup
                cbo.DisplayMember = "itgroupdesc"
                cbo.ValueMember = "itgroupcd"
            Case "cboDesignGwthNob"
                cbo.DataSource = objDB.GetDesignGwth
                cbo.DisplayMember = "design_gwth_nob"
                cbo.ValueMember = "design_gwth_nob"
            Case "cboDesignType"
                cbo.DataSource = objDB.GetDesignType
                cbo.DisplayMember = "ittypedesc"
                cbo.ValueMember = "ittypecd"
            Case "cboDocType"
                cbo.DataSource = objDB.GetDocType
                cbo.DisplayMember = "name"
                cbo.ValueMember = "doctyp"
            Case "cboDyedCase"
                cbo.DataSource = objDB.GetDyedCase
                cbo.DisplayMember = "dyedcase"
                cbo.ValueMember = "dyedcase"
            Case "cboDyedHouse"
                cbo.DataSource = objDB.GetDyedHouse
                cbo.DisplayMember = "suppname"
                cbo.ValueMember = "suppcd2"
            Case "cboDyedMethod"
                cbo.DataSource = objDB.GetDyingMethod
                cbo.DisplayMember = "dmethod"
                cbo.ValueMember = "dmethodcd"
            Case "cboEmp"
                cbo.DataSource = objDB.GetEmp
                cbo.DisplayMember = "empname2"
                cbo.ValueMember = "empcd2"
            Case "cboFreightCharge"
                cbo.DataSource = objDB.GetFreightCharge
                cbo.DisplayMember = "charge_desc"
                cbo.ValueMember = "charge_code"
            Case "cboGwth"
                cbo.DataSource = objDB.GetGwth
                cbo.DisplayMember = "gwth"
                cbo.ValueMember = "gwth"
            Case "cboLightSource"
                cbo.DataSource = objDB.GetLightSource
                cbo.DisplayMember = "description"
                cbo.ValueMember = "lights"
            Case "cboMCType"
                cbo.DataSource = objDB.GetMCType
                cbo.DisplayMember = "mname"
                cbo.ValueMember = "mctyp"
            Case "cboOutNo"
                cbo.DataSource = objDB.GetOutNo
                cbo.DisplayMember = "outno"
                cbo.ValueMember = "outno"
            Case "cboPayMode"
                cbo.DataSource = objDB.GetPaymode
                cbo.DisplayMember = "paymodecd"
                cbo.ValueMember = "paymodecd"
            Case "cboSoNo"
                cbo.DataSource = objDB.GetSoNo
                cbo.DisplayMember = "sono"
                cbo.ValueMember = "sono"
            Case "cboSoNoID"
                cbo.DataSource = objDB.GetSoNoID
                cbo.DisplayMember = "sono_design_col"
                cbo.ValueMember = "sonoid"
            Case "cboSupplier"
                cbo.DataSource = objDB.GetSupplier
                cbo.DisplayMember = "suppname"
                cbo.ValueMember = "suppcd2"
            Case "cboUOM"
                cbo.DataSource = objDB.GetUOM
                cbo.DisplayMember = "uom"
                cbo.ValueMember = "uom"
            Case "cboYesNo"
                cbo.DataSource = objDB.GetYesNo
                cbo.DisplayMember = "yesno"
                cbo.ValueMember = "value"
            Case "cboTrueFalse"
                cbo.DataSource = objDB.GetYesNo
                cbo.DisplayMember = "truefalse"
                cbo.ValueMember = "value"
            Case "cboEndBuyer"
                cbo.DataSource = objDB.GetEndBuyers
                cbo.DisplayMember = "endbuyername"
                cbo.ValueMember = "endbuyercd"
            Case "cboReason"
                cbo.DataSource = objDB.GetReasons
                cbo.DisplayMember = "reason_desc"
                cbo.ValueMember = "reason_id"
            Case "cboReason2"
                cbo.DataSource = objDB.GetReasons
                cbo.DisplayMember = "reason_desc"
                cbo.ValueMember = "reason_id"
            Case "cboReason3"
                cbo.DataSource = objDB.GetReasons
                cbo.DisplayMember = "reason_desc"
                cbo.ValueMember = "reason_id"
            Case "cboSalesMan"
                cbo.DataSource = objDB.GetEmp
                cbo.DisplayMember = "empname"
                cbo.ValueMember = "empcd2"
        End Select
        cbo.SelectedIndex = -1
        cbo.Font = New Font("Courier New", 8, FontStyle.Regular)
    End Sub

    Private Sub GenCombo(ByVal parent As Control)
        Dim obj As Control
        For Each obj In parent.Controls
            If TypeOf obj Is ComboBox Then Call SetCombo(obj)
            If TypeOf obj Is ContainerControl Or obj.HasChildren Then Call GenCombo(obj)
        Next
    End Sub

    Private Function IsControlChange(ByVal obj As Control) As Boolean
        If TypeOf obj Is ContainerControl Or obj.HasChildren Then
            Dim obj2 As Control
            For Each obj2 In obj.Controls
                If IsControlChange(obj2) Then Return True
            Next
        Else
            If obj.AccessibleName <> "" And obj.Name <> "txtDocNo" And obj.Name <> "cboDocNo" And obj.Name <> "cboInvNo" Then
                If TypeOf obj Is TextBox Then
                    If obj.Text <> obj.AccessibleDescription Then Return True
                ElseIf TypeOf obj Is DateTimePicker Then
                    If IsDate(obj.AccessibleDescription) Then
                        If DirectCast(obj, DateTimePicker).Value.ToString("yyyyMMdd") <> CDate(obj.AccessibleDescription).ToString("yyyyMMdd") Then Return True
                    Else
                        If DirectCast(obj, DateTimePicker).Value.ToString("yyyyMMdd") <> Now.ToString("yyyyMMdd") Then Return True
                    End If
                ElseIf TypeOf obj Is ComboBox Then
                    'If obj.AccessibleDescription = "" Then
                    If clsConfig.IsNull(DirectCast(obj, ComboBox).SelectedIndex, -1) <> -1 Then Return True
                    'Else
                    '	If clsConfig.IsNull(DirectCast(obj, ComboBox).SelectedValue, "") <> obj.AccessibleDescription Then Return True
                    'End If
                End If
            End If
        End If
        Return False
    End Function

    Private Function IsControlChange(ByVal obj As Control, ByVal dv As DataView) As Boolean
        If TypeOf obj Is ContainerControl Or obj.HasChildren Then
            Dim obj2 As Control
            For Each obj2 In obj.Controls
                If IsControlChange(obj2) Then Return True
            Next
        Else
            If obj.AccessibleName <> "" And obj.Name <> "txtDocNo" And obj.Name <> "cboDocNo" Then
                If TypeOf obj Is TextBox Then
                    If obj.Text <> dv(0)(obj.AccessibleName) Then Return True
                ElseIf TypeOf obj Is DateTimePicker Then
                    'If DirectCast(obj, DateTimePicker).Value.ToString("yyyyMMdd") <> CDate(dv(0)(obj.AccessibleName & "2")).ToString("yyyyMMdd") Then Return True
                    If DirectCast(obj, DateTimePicker).Value.ToString("yyyyMMdd") <> dv(0)(obj.AccessibleName) Then Return True
                ElseIf TypeOf obj Is ComboBox Then
                    If clsConfig.IsNull(DirectCast(obj, ComboBox).SelectedValue, obj.AccessibleDescription) <> dv(0)(obj.AccessibleName) Then Return True
                End If
            End If
        End If
        Return False
    End Function

    Private Function IsDataChange(ByVal dt As DataTable) As Boolean
        On Error Resume Next
        Dim strStatus As String = IIf(Me.DocNo = "", "NEW", "EDIT")
        Dim dv As New DataView(dt, "", "", DataViewRowState.OriginalRows)
        Dim obj As Control
        If dt Is Nothing Or dv.Count = 0 Or dt.Rows.Count = 0 Or strStatus = "NEW" Then
            If Not dt Is Nothing Then
                If dt.Rows.Count > 1 Then Return True
            End If
            For Each obj In Me.Controls
                If IsControlChange(obj) Then
                    Return True
                End If
            Next
        Else
            If Not txtStatus.Text = "CANCELLED" Then
                For Each obj In Me.Controls
                    If IsControlChange(obj, dv) Then
                        Return True
                    End If
                Next

                Dim delRecs As New DataView(dt, "", "", DataViewRowState.Deleted)
                If delRecs.Count > 0 Then Return True

                Dim updRecs As New DataView(dt, "", "", DataViewRowState.ModifiedCurrent)
                If updRecs.Count > 0 Then Return True

                Dim addRecs As New DataView(dt, "", "", DataViewRowState.Added)
                If addRecs.Count > 0 Then Return True
            End If
        End If

        Return False
    End Function

    Private Sub BindData(ByRef grd As DataGridView, ByVal dt As DataTable)
        Dim obj As Control
        Dim obj2 As DateTimePicker
        Dim obj3 As ComboBox
        Dim obj4 As CheckBox
        If dt.Rows.Count > 0 Then

            'cboDocNo.SelectedItem = txtDocNo.Text

            cboInvNo.SelectedValue = dt.Rows(0)("invid")
            cboCustomer.SelectedValue = dt.Rows(0)("custcd").ToString.Trim
            For Each obj In Me.Controls
                If obj.AccessibleName <> "" And obj.Name <> "cboDocNo" Then
                    If TypeOf obj Is TextBox Then
                        If obj.AccessibleDescription = "0" Then
                            obj.Text = FormatNumber(Val(dt.Rows(0)(obj.AccessibleName)), 0, TriState.False, TriState.False, TriState.False)
                        ElseIf obj.AccessibleDescription = "0.00" Then
                            obj.Text = FormatNumber(Val(dt.Rows(0)(obj.AccessibleName)), 2, TriState.False, TriState.False, TriState.False)
                        ElseIf obj.AccessibleDescription = "0.0000" Then
                            obj.Text = FormatNumber(Val(dt.Rows(0)(obj.AccessibleName)), 4, TriState.False, TriState.False, TriState.False)
                        Else
                            obj.Text = dt.Rows(0)(obj.AccessibleName)
                        End If
                    ElseIf TypeOf obj Is DateTimePicker Then
                        obj2 = DirectCast(obj, DateTimePicker)
                        obj2.Value = CDate(dt.Rows(0)(obj.AccessibleName & "2"))
                    ElseIf TypeOf obj Is ComboBox Then
                        obj3 = DirectCast(obj, ComboBox)
                        obj3.SelectedValue = dt.Rows(0)(obj.AccessibleName)
                    ElseIf TypeOf obj Is CheckBox Then
                        obj4 = DirectCast(obj, CheckBox)
                        obj4.Checked = dt.Rows(0)(obj.AccessibleName)
                    End If
                End If
            Next
            If dt.Rows(0)(0) > 0 Then
                Me.DocID = dt.Rows(0)(0)
                Me.DocNo = txtDocNo.Text
                lObjOldData = dt
                cboInvNo.SelectedValue = dt.Rows(0)("invid")
                cboCustomer.SelectedValue = dt.Rows(0)("custcd").ToString.Trim 'Sitthana 05/09/2018
            End If
        End If
        Call BindGrid(grd, dt)
    End Sub

    Private Sub AddData(ByRef source As DataTable, ByVal dt As DataTable)
        Dim dr As DataRow
        Dim row As Integer = 0
        Dim col As Integer = 0

        If dt.Rows.Count > 0 Then
            'txtCustomer.Text = dt.Rows(0)("custname").ToString()
            cboCustomer.SelectedValue = dt.Rows(0)("custcd").ToString.Trim
            'txtReference.Text = dt.Rows(0)("reference").ToString()
            'txtRemarks.Text = dt.Rows(0)("remarks").ToString()
        End If

        For row = 0 To dt.Rows.Count - 1
            dr = source.NewRow()
            For col = 0 To source.Columns.Count - 1
                dr.Item(col) = dt.Rows(row)(source.Columns(col).ColumnName)
            Next
            source.Rows.Add(dr)
        Next
    End Sub

    Private Sub DeleteData(ByRef dt As DataTable)
        If dt Is Nothing Then
            Exit Sub
        Else
            grdDetails.DataSource = Nothing
            grdDetails.Refresh()
        End If

        'Dim row As Integer = 0
        'For row = 0 To dt.Rows.Count - 1
        '    If dt.Rows(row).RowState <> DataRowState.Deleted Then dt.Rows(row).Delete()
        'Next
    End Sub

    Private Sub BindGrid(ByRef grd As DataGridView, ByVal dt As DataTable)
        grd.AutoGenerateColumns = False
        grd.DataSource = dt
    End Sub

    Private Sub ClearGrid(ByRef grd As DataGridView, ByVal dt As DataTable)
        grd.AutoGenerateColumns = False
        grd.DataSource = dt
    End Sub

    Private Function CanChange() As Boolean
        Dim result As DialogResult = DialogResult.No
        If IsDataChange(grdDetails.DataSource) Then
            result = MessageBox.Show("Would you like to save ?", "System Message", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)
            Select Case result
                Case DialogResult.Yes
                    Call SaveData()
                    Return True
                Case DialogResult.Cancel
                    Return False
                Case DialogResult.No
                    Return True
            End Select
        Else
            Return True
        End If
    End Function

    Private Function CanSave() As Boolean
        If Not (txtStatus.Text.Trim = "" Or txtStatus.Text.Trim = "MODIFIED") Then
            MessageBox.Show("This document has been already " & txtStatus.Text.Trim & ".", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Return False
        ElseIf cboInvNo.SelectedIndex = -1 Then
            'Sitthana 06/09/2018
            MessageBox.Show("คุณต้องระบุ Invoice ก่อน", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Return False
        ElseIf cboCustomer.SelectedIndex = -1 Then
            'Sitthana 06/09/2018
            MessageBox.Show("คุณต้องระบุ Customer ก่อน", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Return False
        Else
            Return True
        End If
    End Function
#End Region

#Region "Customized Functions"
    Public Overridable Sub GenCombo2()
        cboInvNo.DataSource = (New classDebitNoteAR).GetInvNo()
        cboInvNo.DisplayMember = "invno"
        cboInvNo.ValueMember = "invid"

        uom.DataSource = (New classMaster).GetUOM()
        uom.DisplayMember = "uom"
        uom.ValueMember = "uom_id"

        Dim objDB As New classMaster
        Me.cboCustomer.DataSource = objDB.GetCustomer
        Me.cboCustomer.DisplayMember = "name"
        Me.cboCustomer.ValueMember = "custcd"

        cboCurrency.DataSource = (New classMaster).GetCurrency
        cboCurrency.DisplayMember = "Curr"
        cboCurrency.ValueMember = "Curr"

        cboInvtype.DataSource = (New classMaster).GetInvType
        cboInvtype.DisplayMember = "invtype_name"
        cboInvtype.ValueMember = "invtype"
    End Sub

    Public Overridable Sub GenComboDocNo()
        Dim objDB As New classDebitNoteAR
        cboDocNo.ComboBox.DataSource = objDB.GetDocNo(0, "")
        cboDocNo.ComboBox.DisplayMember = "dbnote_no"
        cboDocNo.ComboBox.ValueMember = "id_dbnote"
        cboDocNo.ComboBox.SelectedIndex = -1

    End Sub

    Public Overridable Sub LoadData(Optional ByVal strDocNo As String = "")
        'If Not CanChange() Then Exit Sub
        Dim objDB As New classDebitNoteAR
        Call BindData(grdDetails, objDB.GetDocDetails(0, strDocNo))
    End Sub

    Public Overridable Function SaveData() As Boolean
        If Not CanSave() Then Return False
        If MessageBox.Show("Would you like to save ?", "System Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = DialogResult.No Then Return False
        Dim clsdbnote As New classDebitNoteAR
        Dim header As classDebitNoteAR.DebitNoteARHeader
        Dim msgerr As String = ""
        Dim docid As Long = 0
        Dim docno As String = ""
        Dim dt As New DataTable
        Call grdDetails.CommitEdit(DataGridViewDataErrorContexts.Commit)
        dt = grdDetails.DataSource
        Call SumGrid(dt)
        Dim dv_add As New DataView(dt, "", "", DataViewRowState.None)
        Dim dv_upd As New DataView(dt, "", "", DataViewRowState.CurrentRows)
        Dim dv_del As New DataView(dt, "", "", DataViewRowState.Deleted)

        header.h01_id_dbnote = Me.DocID
        header.h02_dbnote_no = Me.DocNo
        header.h03_dbnote_date = dtpDocDate.Value.ToString("yyyyMMdd")
        header.h04_dbnote_type_id = 0
        header.h05_present_status = ""
        header.h06_approval_status = ""
        header.h07_posting_status = ""
        header.h08_dbnote_reqno = ""
        header.h09_dbnote_reason1 = clsConfig.IsNull(cboReason.SelectedValue, 0)
        header.h10_dbnote_reason2 = clsConfig.IsNull(cboReason2.SelectedValue, 0)
        header.h11_dbnote_reason3 = clsConfig.IsNull(cboReason3.SelectedValue, 0)
        'header.h12_custcd = "" 'Comment By sitthana 06/09/2018
        header.h12_custcd = cboCustomer.SelectedValue
        header.h13_source_docno = ""
        header.h14_source_docdate = "19000101"
        header.h15_source_refno = ""
        header.h16_source_doctype = ""
        'header.h17_invid = clsConfig.IsNull(cboInvNo.SelectedValue.ToString.Substring(1), 0)
        header.h17_invid = clsConfig.IsNull(cboInvNo.SelectedValue.ToString, 0)
        header.h18_invno = clsConfig.IsNull(cboInvNo.Text, "")
        'header.h19_invtype = clsConfig.IsNull(cboInvNo.SelectedValue.ToString.Substring(0, 1), "")
        'header.h19_invtype = clsConfig.IsNull(cboInvNo.Text.ToString.Substring(0, 1), "") 'Comment By Sitthana 06/09/2018
        If clsConfig.IsNull(cboInvNo.Text.ToString.Substring(0, 1), "") = "I" Then
            header.h19_invtype = "L"
        Else
            header.h19_invtype = clsConfig.IsNull(cboInvNo.Text.ToString.Substring(0, 1), "")
        End If

        header.h20_reference = txtReference.Text.Trim
        header.h21_remarks = txtRemarks.Text.Trim
        header.h22_grossamt = Val(FormatNumber(txtGrossAmt.Text, 2, TriState.False, TriState.False, TriState.False))
        header.h23_discamt = Val(FormatNumber(txtDiscAmt.Text, 2, TriState.False, TriState.False, TriState.False))
        header.h24_pretaxamt = Val(FormatNumber(txtPreTaxAmt.Text, 2, TriState.False, TriState.False, TriState.False))
        header.h25_vat = Val(FormatNumber(txtVat.Text, 2, TriState.False, TriState.False, TriState.False))
        header.h26_vatamt = Val(FormatNumber(txtVatAmt.Text, 2, TriState.False, TriState.False, TriState.False))
        header.h27_netamt = Val(FormatNumber(txtNetAmt.Text, 2, TriState.False, TriState.False, TriState.False))
        header.h28_revise = 0
        header.h29_create_by = clsUser.UserID
        header.h30_create_date = "19000101"
        header.h31_create_time = "19000101"
        header.h32_update_by = clsUser.UserID
        header.h33_update_date = "19000101"
        header.h34_update_time = "19000101"
        header.h35_cancel_by = ""
        header.h36_cancel_date = "19000101"
        header.h37_cancel_time = "19000101"
        header.h38_approve_by = ""
        header.h39_approve_date = "19000101"
        header.h40_approve_time = "19000101"
        header.h41_empcd = (New clsConfig).IsNull(cboSalesMan.SelectedValue, "").ToString.Trim

        If clsdbnote.SaveData(header, dv_add, dv_upd, dv_del, msgerr, docid, docno) Then
            Call GenComboDocNo()
            Call LoadData(docno)
            cboDocNo.Text = txtDocNo.Text
            'Call GenComboDocNo()
            SaveData = True
        Else
            MessageBox.Show(msgerr, "System Message", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
            SaveData = False
        End If
    End Function

    Public Overridable Sub ApproveData()
        If Not CanSave() Then Exit Sub
        If MessageBox.Show("Would you like to approve ?", "System Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = DialogResult.Yes Then Call (New classDebitNoteAR).Approve(Me.DocID, Me.UserInfo.UserID)
        txtStatus.Text = "APPROVED"
    End Sub

    Public Overridable Sub CancelData()
        If Not CanSave() Then Exit Sub
        If MessageBox.Show("Would you like to cancel ?", "System Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = DialogResult.Yes Then Call (New classDebitNoteAR).Cancel(Me.DocID, Me.UserInfo.UserID)
        txtStatus.Text = "CANCELLED"
    End Sub

    Public Overridable Sub SumGrid(ByVal dt As DataTable)
        If dt Is Nothing Or dt.Rows.Count = 0 Then Exit Sub
        Dim i As Integer = 0
        Dim dblGrossAmt As Double = 0
        Dim dblDiscAmt As Double = Val(txtDiscAmt.Text)
        Dim dblPreTaxAmt As Double = 0
        Dim dblVAT As Double = Val(txtVat.Text)
        Dim dblVATAmt As Double = 0
        Dim dblNetAmt As Double = 0
        For i = 0 To dt.Rows.Count - 1
            If dt.Rows(i).RowState <> DataRowState.Deleted Then
                dblGrossAmt = dblGrossAmt + Math.Round(dt.Rows(i)("qty") * dt.Rows(i)("uprice"), 2)
            End If
        Next
        dblPreTaxAmt = dblGrossAmt - Math.Round(dblDiscAmt, 2)
        dblVATAmt = Math.Round((dblPreTaxAmt * dblVAT) / 100, 2)
        dblNetAmt = dblPreTaxAmt + dblVATAmt

        txtGrossAmt.Text = FormatNumber(dblGrossAmt, 2, TriState.False, TriState.False, TriState.False)
        txtDiscAmt.Text = FormatNumber(dblDiscAmt, 2, TriState.False, TriState.False, TriState.False)
        txtPreTaxAmt.Text = FormatNumber(dblPreTaxAmt, 2, TriState.False, TriState.False, TriState.False)
        txtVat.Text = FormatNumber(dblVAT, 2, TriState.False, TriState.False, TriState.False)
        txtVatAmt.Text = FormatNumber(dblVATAmt, 2, TriState.False, TriState.False, TriState.False)
        txtNetAmt.Text = FormatNumber(dblNetAmt, 2, TriState.False, TriState.False, TriState.False)
    End Sub
#End Region

#Region "Events"
    Private Sub frmDebitNote_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call GenCombo(Me)
        Call GenCombo2()
        Call GenComboDocNo()
        Call InitControl()
        Application.DoEvents()
    End Sub

    Private Sub frmDebitNote_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If Not CanChange() Then e.Cancel = True
    End Sub

    Private Sub btnNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNew.Click
        If CanChange() Then Call InitControl()
        Application.DoEvents()
    End Sub

    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
        Application.DoEvents()
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        If grdDetails.EditMode Then grdDetails.EndEdit()

        If Not checkData() Then Exit Sub

        Call SaveData()
        Application.DoEvents()
    End Sub
    Private Function checkData() As Boolean
        If (New clsConfig).IsNull(cboSalesMan.SelectedValue, "") = "" Then
            ErrorProvider1.SetError(cboSalesMan, "Should Be Enter Sale Person" + vbCr + vbCr + "ต้องเลือก Sale Person ด้วยครับ")
            MessageBox.Show("Should Be Enter Sale Person" + vbCr + vbCr + "ต้องเลือก Sale Person ด้วยครับ", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
            Return False
        End If

        ErrorProvider1.Clear()
        Return True
    End Function


    Private Sub btnPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrint.Click
        If Me.DocID = 0 Then Exit Sub
        Const rptFileName = "rptDBNoteAR.rpt"
        If Not clsConfig.CheckReport(clsUser.ReportPath, rptFileName) Then Exit Sub
        Dim clsConn As New classConnection
        Dim frm As New frmReport
        Dim rpt As New CrystalDecisions.CrystalReports.Engine.ReportDocument
        Me.Cursor = Cursors.WaitCursor
        rpt.Load(clsUser.ReportPath & rptFileName)
        rpt.DataSourceConnections.Item(0).SetConnection(clsConn.servername, clsConn.database, False)
        rpt.DataSourceConnections.Item(0).SetLogon(clsConn.Userid, clsConn.Password)

        rpt.VerifyDatabase()
        rpt.SetParameterValue("@id_dbnote", Me.DocID)

        'rpt.PrintOptions.PaperSize = CrystalDecisions.Shared.PaperSize.PaperLetter
        'rpt.PrintOptions.PaperOrientation = CrystalDecisions.Shared.PaperOrientation.Portrait
        'rpt.PrintOptions.PaperSource = CrystalDecisions.Shared.PaperSource.Auto

        frm.Title = "Debit Note"
        'frm.CRViewer.DisplayGroupTree = False
        frm.CRViewer.ReportSource = rpt
        frm.MdiParent = Me.ParentForm
        frm.Show()
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub btnApprove_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnApprove.Click
        If CanChange() Then Call ApproveData()
        Application.DoEvents()
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        If CanChange() Then Call CancelData()
        Application.DoEvents()
    End Sub

    Private Sub btnMinimized_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMinimized.Click
        Me.WindowState = FormWindowState.Minimized
        Application.DoEvents()
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Me.Close()
        Application.DoEvents()
    End Sub

    Private Sub btnLoadINV_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLoadINV.Click
        If cboInvNo.SelectedIndex < 0 Then Exit Sub
        If CanChange() Then
            Call DeleteData(grdDetails.DataSource)
            Call AddData(grdDetails.DataSource, (New classDebitNoteAR).GetInvDetails(cboInvNo.Text))
        End If
    End Sub

    Private Sub btnLoadStkIN_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLoadStkIN.Click
        If cboStkINNo.SelectedIndex < 0 Then Exit Sub
        If CanChange() Then
            Call AddData(grdDetails.DataSource, (New classDebitNoteAR).GetStkDetails(cboInvNo.Text, cboStkINNo.SelectedValue.ToString))
        End If
    End Sub

    Private Sub cboDocNo_DropDownClosed(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboDocNo.DropDownClosed
        If CanChange() Then
            Call BindData(grdDetails, (New classDebitNoteAR).GetDocDetails(clsConfig.IsNull(cboDocNo.ComboBox.SelectedValue, 0), ""))

        End If
    End Sub

    Private Sub txtDocNo_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtDocNo.KeyDown
        If e.KeyCode = Keys.Enter And txtDocNo.Text.Trim.Length >= 10 Then If CanChange() Then Call LoadData(txtDocNo.Text.Trim)
        Application.DoEvents()
    End Sub

    Private Sub cboInvNo_DropDownClosed(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboInvNo.DropDownClosed
        If CanChange() Then Call DeleteData(grdDetails.DataSource)
        cboStkINNo.DataSource = (New classDebitNoteAR).GetStkNo(cboInvNo.Text)
        cboStkINNo.DisplayMember = "stk_in_no"
        cboStkINNo.ValueMember = "stk_in_no"
        cboStkINNo.SelectedIndex = -1

        loadDataInvNo() ' Add By Neung 20151203
        'Call AddData(cboCustomer.DataSource, (New classDebitNoteAR).GetInvDetails(cboInvNo.Text))

    End Sub

    Private Sub loadDataInvNo()
        Dim objdb As New classDebitNoteAR
        Dim dt As New DataTable
        dt = objdb.GetInvDetails(cboInvNo.Text)
        If dt.Rows.Count > 0 Then Call BinddataInvNo(dt)

    End Sub

    Private Sub BinddataInvNo(ByVal dt As DataTable)
        cboCustomer.SelectedValue = dt.Rows(0)("custcd")

    End Sub



    Private Sub grdDetails_CellValueChanged(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles grdDetails.CellValueChanged
        If grdDetails.Columns(e.ColumnIndex).Name = "qty" _
         Or grdDetails.Columns(e.ColumnIndex).Name = "uprice" Then
            grdDetails.CurrentRow.Cells("lineamt").Value = Math.Round(clsConfig.IsNull(grdDetails.CurrentRow.Cells("qty").Value, 0) * clsConfig.IsNull(grdDetails.CurrentRow.Cells("uprice").Value, 0), 2)
            Call SumGrid(grdDetails.DataSource)
        End If
    End Sub

    Private Sub txtVat_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles txtVat.KeyDown
        If e.KeyCode = Keys.Enter Then
            Call SumGrid(grdDetails.DataSource)
        End If
    End Sub

    Private Sub Textbox_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtDiscAmt.LostFocus, txtVat.LostFocus
        Call SumGrid(grdDetails.DataSource)
    End Sub
#End Region

    Private Sub cboDocNo_Click(sender As System.Object, e As System.EventArgs) Handles cboDocNo.Click

    End Sub

    Private Sub cboInvNo_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cboInvNo.SelectedIndexChanged

    End Sub

    Private Sub grdDetails_CellContentClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles grdDetails.CellContentClick

    End Sub

    Private Sub txtVat_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtVat.TextChanged

    End Sub

    Private Sub btnExchangeRate_Click(sender As Object, e As EventArgs) Handles btnExchangeRate.Click
        On Error Resume Next '
        If grdDetails.EditMode Then grdDetails.EndEdit()
        Dim i As Integer = 0
        If grdDetails.Rows.Count = 0 Then Exit Sub
        Dim exrt As Double = InputBox("Input the exchange rate." & vbCrLf & "ใส่อัตราแลกเปลี่ยนเงินตรา", "System Message", "0.00")
        Dim dt As DataTable = grdDetails.DataSource
        For Each dr As DataRow In dt.Rows
            If dr.RowState <> DataRowState.Deleted Then
                dr("exchange_rate") = exrt
            End If
        Next
    End Sub
End Class