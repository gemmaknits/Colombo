Imports System.Text
Public Class frmSalesQuote
#Region "Declare local variables"
    Dim clsConfig As New clsConfig
    Dim clsUser As New classUserInfo
    Dim bsQuote As New BindingSource
    Dim bsQuoteItems As New BindingSource
    Dim bsQuoteCharges As New BindingSource
    Dim oldDTPFormat As DateTimePickerFormat
    Dim oldDTPcustomformat As String
    Dim gridTextBox As TextBox
#End Region

#Region "Declare the data tables for all database tables involved in the data entry "
    Dim dtQuote As New DataTable
    Dim dtQuoteItems As New DataTable
    Dim dtQuoteCharges As New DataTable
    Dim Quotation As New classQuotation
#End Region

#Region "Base form methods and functions"
    Private Sub frmSalesQuote_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtTotalAmt.NoOfDecimalsToDisplay = 2
        RefreshLookupControls()
        InitControl()
        oldDTPFormat = dtpQuoteDate.Format
        oldDTPcustomformat = dtpQuoteDate.CustomFormat
        Me.tsButtonCopy.Visible = True
        LoadData("NEW") ' start form with a new record
    End Sub
    Public Overrides Sub RefreshLookupControls()
        MyBase.RefreshLookupControls()
        Me.PopulateDocumentCombo("SOQUOTE", (New classConnection).getSQLConnection)
        Me.cboSalesMan.populateData((New classConnection).getSQLConnection)
        Me.cboPaymode.populateData((New classConnection).getSQLConnection)
        Me.cboCustomer.populateData((New classConnection).getSQLConnection)
        Me.cboAgent.populateData((New classConnection).getSQLConnection)
        Me.cboDeliveryLoc.populateData((New classConnection).getSQLConnection)
        Me.cboFinalCustomer.populateData((New classConnection).getSQLConnection)
        Me.col.populateData((New classConnection).getSQLConnection)
        Me.curr.populateData((New classConnection).getSQLConnection)
        Me.uom.populateData((New classConnection).getSQLConnection)
        Me.colChargeCurr.populateData((New classConnection).getSQLConnection)
        Me.ComboBank1.populateData((New classConnection).getSQLConnection)
    End Sub
    Public Overrides Sub MainDocNo_DropDownClosedEvent()
        Dim mainDocno As String = ""
        mainDocno = Me.tsComboMainDocNo.ComboBox.Text
        LoadData(mainDocno)
    End Sub
    Public Overrides Sub LoadData(ByVal MainDocno As String)
        Dim quoteno As String = MainDocno
        Try
            Quotation = Quotation.GetQuotation(quoteno)

            ClearDataBindings()

            dtQuote = Quotation.Quote
            dtQuoteItems = Quotation.QuoteItems
            dtQuoteCharges = Quotation.QuoteCharges

            bsQuote.DataSource = dtQuote
            bsQuoteItems.DataSource = dtQuoteItems
            bsQuoteCharges.DataSource = dtQuoteCharges

            SetDataBindings()

        Catch ex As Exception
            MsgBox("Quotation no." + quoteno + " could not be loaded due to following error" + Chr(13) + ex.Message, MsgBoxStyle.Critical, "Load Error")
            Exit Sub
        End Try
    End Sub
    Public Overrides Sub SetDataBindings()
        MyBase.SetDataBindings() ' this is required to clear existing bindings

        ' header data
        txtQuoteNo.DataBindings.Add("text", bsQuote, "quoteno")
        dtpQuoteDate.DataBindings.Add("value", bsQuote, "Quotedt2")
        chkIsProforma.DataBindings.Add("checked", bsQuote, "IsProforma")
        txtValidDays.DataBindings.Add("text", bsQuote, "validdays")
        dtpExpiryDate.DataBindings.Add("value", bsQuote, "ExpiryDt2")
        txtPoNo.DataBindings.Add("text", bsQuote, "custpo")
        'dtpPoDate.DataBindings.Add("value", bsQuote, "custpodt2")
        cboCustomer.DataBindings.Add("selectedvalue", bsQuote, "custcd")
        cboAgent.DataBindings.Add("selectedvalue", bsQuote, "agcd")
        cboSalesMan.DataBindings.Add("selectedvalue", bsQuote, "empcd")
        cboFinalCustomer.DataBindings.Add("selectedvalue", bsQuote, "endbuyercd")
        txtTermCondition.DataBindings.Add("text", bsQuote, "payterms")
        ComboBank1.DataBindings.Add("selectedvalue", bsQuote, "bank_code")
        txtCreditDays.DataBindings.Add("text", bsQuote, "crdays")
        cboDeliveryLoc.DataBindings.Add("selectedvalue", bsQuote, "shipcustcd")
        txtDeliveryTerm.DataBindings.Add("text", bsQuote, "shipterms")
        txtTransportBy.DataBindings.Add("text", bsQuote, "shipvia")
        txtRemark.DataBindings.Add("text", bsQuote, "remarks")
        txtRevise.DataBindings.Add("text", bsQuote, "rev")
        chkExport.DataBindings.Add("checked", bsQuote, "exploc")
        txtRef.DataBindings.Add("text", bsQuote, "ref")
        txtContact.DataBindings.Add("text", bsQuote, "contact")
        txtShipQty_tolerance.DataBindings.Add("text", bsQuote, "shipqty_tolerance")
        txtShipQty_Tolerance_high.DataBindings.Add("text", bsQuote, "shipqty_tolerance_high")
        txtShipQty_Tolerance_low.DataBindings.Add("text", bsQuote, "shipqty_tolerance_low")
        cboPaymode.DataBindings.Add("selectedvalue", bsQuote, "paymodecd")

        txtLineGrossAmt.DataBindings.Add("text", bsQuote, "LineGrossAmt")
        txtLineTotalDisc.DataBindings.Add("text", bsQuote, "LineDiscAmt")
        txtLineNetAmt.DataBindings.Add("text", bsQuote, "LineNetAmt")
        txtOrderDiscPer.DataBindings.Add("text", bsQuote, "Discper")
        txtOrderDiscAmt.DataBindings.Add("text", bsQuote, "DiscAmt")
        txtOrderNetAmt.DataBindings.Add("text", bsQuote, "NetAmt")
        txtLineGrossCharges.DataBindings.Add("text", bsQuote, "LineGrossCharges")
        'txtTotalAmt.DataBindings.Add("text", bsQuote, "NetAmt")

        Me.txtConditionsTitle1.DataBindings.Add("text", bsQuote, "ConditionsTitle1")
        Me.txtConditionsTitle2.DataBindings.Add("text", bsQuote, "ConditionsTitle2")
        Me.txtConditionsTitle3.DataBindings.Add("text", bsQuote, "ConditionsTitle3")
        Me.txtConditionsTitle4.DataBindings.Add("text", bsQuote, "ConditionsTitle4")
        Me.txtConditionsTitle5.DataBindings.Add("text", bsQuote, "ConditionsTitle5")
        Me.txtConditionsTitle6.DataBindings.Add("text", bsQuote, "ConditionsTitle6")
        Me.txtConditionsTitle7.DataBindings.Add("text", bsQuote, "ConditionsTitle7")
        Me.txtConditionsTitle8.DataBindings.Add("text", bsQuote, "ConditionsTitle8")

        Me.txtConditionsText1.DataBindings.Add("text", bsQuote, "ConditionsText1")
        Me.txtConditionsText2.DataBindings.Add("text", bsQuote, "ConditionsText2")
        Me.txtConditionsText3.DataBindings.Add("text", bsQuote, "ConditionsText3")
        Me.txtConditionsText4.DataBindings.Add("text", bsQuote, "ConditionsText4")
        Me.txtConditionsText5.DataBindings.Add("text", bsQuote, "ConditionsText5")
        Me.txtConditionsText6.DataBindings.Add("text", bsQuote, "ConditionsText6")
        Me.txtConditionsText7.DataBindings.Add("text", bsQuote, "ConditionsText7")
        Me.txtConditionsText8.DataBindings.Add("text", bsQuote, "ConditionsText8")

        ' Grid data
        Me.grdQuoteItems.AutoGenerateColumns = False
        Me.grdCharges.AutoGenerateColumns = False

        Me.grdQuoteItems.DataSource = bsQuoteItems
        Me.grdCharges.DataSource = bsQuoteCharges

        If RTrim(dtQuote.Rows(0).Item("present_status")) = "CANCELLED" Then
            Me.formMode = "CANCEL"
        End If

        If formMode = "EDIT" Then
            Me.chkIsProforma.Enabled = False
        Else
            Me.chkIsProforma.Enabled = True
        End If
        Me.RefreshForm()
        CalculateTotals()
    End Sub

    Public Overrides Sub UndoRecord()
        dtQuote.RejectChanges()
        dtQuoteItems.RejectChanges()
    End Sub
    Public Overrides Function CheckDataChanges() As Boolean
        Return True
        'Dim m_CurrentVal As String
        'Dim m_OriginalVal As String

        'For Each row As DataRow In dtQuote.Rows
        '    For Each col As DataColumn In dtQuote.Columns
        '        m_CurrentVal = row(col, DataRowVersion.Current).ToString
        '        m_OriginalVal = row(col, DataRowVersion.Original).ToString


        '        ' if numeric textbox, convert all values to decimal format
        '        If col.DataType.ToString = "System.int32" Or col.DataType.ToString = "System.Decimal" Then
        '            m_CurrentVal = Val(m_CurrentVal)
        '            m_OriginalVal = Val(m_OriginalVal)
        '        End If

        '        ' if dtpicker control is used extract only date part
        '        If UCase(col.ColumnName) = "QUOTEDT2" Or UCase(col.ColumnName) = "EXPIRYDT2" Then
        '            m_CurrentVal = m_CurrentVal.Substring(0, 10)
        '            m_OriginalVal = m_OriginalVal.Substring(0, 10)
        '        End If

        '        If m_CurrentVal <> m_OriginalVal Then
        '            Return True
        '        End If
        '    Next
        '    'If Not row.RowState = DataRowState.Unchanged Then
        '    '    Return True
        '    'End If
        'Next
        'For Each row As DataRow In dtQuoteItems.Rows
        '    If row.RowState = DataRowState.Deleted Then Return True
        '    For Each col As DataColumn In dtQuoteItems.Columns
        '        m_CurrentVal = row(col, DataRowVersion.Current).ToString
        '        m_OriginalVal = row(col, DataRowVersion.Original).ToString
        '        If m_CurrentVal <> m_OriginalVal Then
        '            Return True
        '        End If
        '    Next

        '    'If Not row.RowState = DataRowState.Unchanged Then
        '    '    Return True
        '    'End If
        'Next
        'For Each row As DataRow In dtQuoteCharges.Rows
        '    If row.RowState = DataRowState.Deleted Then Return True
        '    For Each col As DataColumn In dtQuoteCharges.Columns
        '        m_CurrentVal = row(col, DataRowVersion.Current).ToString
        '        m_OriginalVal = row(col, DataRowVersion.Original).ToString
        '        If m_CurrentVal <> m_OriginalVal Then
        '            Return True
        '        End If
        '    Next

        '    'If Not row.RowState = DataRowState.Unchanged Then
        '    '    Return True
        '    'End If
        'Next

        'Return False
    End Function
    Public Overrides Function SaveRecord() As Boolean
        Dim result As classResult
        Dim mailResult As classResult

        For Each row As DataRow In dtQuoteItems.Rows
            If row.RowState <> DataRowState.Deleted Then
                If row.Item("shipdt") <> "" Then
                    If Not IsDate(row.Item("shipdt")) Then
                        MsgBox("Please enter Ship date in dd/mm/yyyy format", MsgBoxStyle.Critical, "Date format error")
                        Return False
                    End If
                End If
                If row.Item("cust_shipdt") <> "" Then
                    If Not IsDate(row.Item("cust_shipdt")) Then
                        MsgBox("Please enter Cust Required Deliv date in dd/mm/yyyy format", MsgBoxStyle.Critical, "Date format error")
                        Return False
                    End If
                End If
            End If
        Next

        If Me.dtpQuoteDate.Value.ToString("yyyyMMdd") = "19000101" Then
            dtQuote.Rows(0)("quotedt") = ""
        Else
            dtQuote.Rows(0)("quotedt") = Me.dtpQuoteDate.Value.ToString("yyyyMMdd")
        End If
        If Me.dtpExpiryDate.Value.ToString("yyyyMMdd") = "19000101" Then
            dtQuote.Rows(0)("expirydt") = ""
        Else
            dtQuote.Rows(0)("expirydt") = Me.dtpExpiryDate.Value.ToString("yyyyMMdd")
        End If

        If Me.dtpPoDate.Value.ToString("yyyyMMdd") = "19000101" Then
            dtQuote.Rows(0)("custpodt") = ""
        Else
            dtQuote.Rows(0)("custpodt") = Me.dtpPoDate.Value.ToString("yyyyMMdd")
        End If

        result = Quotation.SaveQuotation(dtQuote, dtQuoteItems, dtQuoteCharges, userInfo.UserID)

        If result.Success = False Then
            MsgBox("Operation failed due to following error:" + Chr(13) + result.Message)
            Return result.Success
        Else
            LoadData(dtQuote.Rows(0)("Quoteno")) ' reload data
            Me.statusProgress.Visible = True
            statusMessage.Text = "Mailing quotation .."
            Me.Timer.Enabled = True
            Me.Cursor = Cursors.WaitCursor
            Me.Timer.Enabled = False
            statusMessage.Text = "Attempting to e-mail quotation.."
            mailResult = Quotation.MailQuotation(dtQuote.Rows(0)("quoteno"))
            statusProgress.Visible = False
            If mailResult.Success = True Then
                statusMessage.Text = "Quotation e-mailed.."
            Else
                statusMessage.Text = "e-Mailing failed .."
            End If
        End If
        Me.Cursor = Cursors.Default
        Return result.Success
    End Function
    Public Overrides Sub EndAllEdits()

        bsQuote.EndEdit()
        bsQuoteItems.EndEdit()
        bsQuoteCharges.EndEdit()

        For Each row As DataRow In dtQuote.Rows
            row.EndEdit()
        Next

        For Each row As DataRow In dtQuoteItems.Rows
            row.EndEdit()
        Next

        For Each row As DataRow In dtQuoteCharges.Rows
            row.EndEdit()
        Next
    End Sub
    Public Overrides Sub newrecord()
        LoadData("NEW")
    End Sub
    Public Overrides Function CancelRecord() As Boolean
        Dim result As classResult

        result = Quotation.CancelQuotation(dtQuote, userInfo.UserID)
        If result.Success = False Then
            MsgBox("Operation failed due to following error:" + Chr(13) + result.Message)
            Return result.Success
        Else
            LoadData(dtQuote.Rows(0)("Quoteno")) ' reload data
        End If
        SetDataBindings()
        Return result.Success
    End Function
    Public Overrides Function SearchRecord() As Boolean
        Dim formSearchQuotation As New Classes.formSearchQuotation
        Dim SearchResult As New Classes.SearchFormResult
        formSearchQuotation.SqlConn = (New classConnection).getSQLConnection
        SearchResult = formSearchQuotation.ShowQuotation()
        If SearchResult IsNot Nothing Then
            If SearchResult.ResultRowView IsNot Nothing Then
                LoadData(SearchResult.ResultRowView.Item("quoteno"))
            End If
        End If
    End Function
    Public Overrides Function CopyRecord() As Boolean
        Dim drv As DataRowView
        Dim OldQuoteNo As String
        drv = bsQuote.Current
        OldQuoteNo = drv("quoteno")
        drv("quoteno") = "NEW"
        For Each row As DataRow In dtQuoteItems.Rows
            row("itemlineid") = ""
        Next
        For Each row As DataRow In dtQuoteCharges.Rows
            row("chargelineid") = ""
        Next
        bsQuote.EndEdit()
        formMode = "NEW"
        Me.chkIsProforma.Enabled = True
        RefreshForm()
        MsgBox("New record copied from " + OldQuoteNo)
    End Function
    Public Overrides Function PrintRecord() As Boolean
        Dim f As New frmPreviewQuotation
        f.Quoteno = Me.txtQuoteNo.Text.Trim
        If dtQuote.Rows(0)("isProforma") = True Then
            f.ReportFile = "rptQuotePI.rpt"
        Else
            f.ReportFile = "rptQuote.rpt"
        End If
        f.setupReport()
        f.Show()
    End Function
#End Region

#Region "This form methods & Functions"
    Private Sub CalculateTotals()
        Dim config As New clsConfig
        Dim i As Integer = 0
        Dim LineGrossAmt As Double = 0
        Dim LineDiscAmt As Double = 0
        Dim LineNetAmt As Double = 0
        Dim LineChargeAmt As Double = 0
        Dim OrderGrossAmt As Double = 0
        Dim OrderDiscAmt As Double = 0
        Dim OrderNetAmt As Double = 0
        For Each row As DataRow In dtQuoteItems.Rows
            LineGrossAmt = LineGrossAmt + row.Item("grossamt")
            LineDiscAmt = LineDiscAmt + row.Item("discamt")
            LineNetAmt = LineNetAmt + row.Item("netamt")
        Next
        OrderGrossAmt = LineNetAmt

        If Val(Me.txtOrderDiscAmt.Text) <> 0 Then
            OrderDiscAmt = Val(OrderGrossAmt * Me.txtOrderDiscPer.Text.ToString)
            OrderDiscAmt = Val(Me.txtOrderDiscAmt.Text)
        End If
        OrderNetAmt = Val(OrderGrossAmt - OrderDiscAmt)

        For Each row As DataRow In dtQuoteCharges.Select
            LineChargeAmt = LineChargeAmt + row.Item("ChargeAmt")
        Next
        Me.txtLineGrossAmt.Text = LineGrossAmt
        Me.txtLineTotalDisc.Text = LineDiscAmt
        Me.txtLineNetAmt.Text = LineNetAmt
        Me.txtOrderDiscAmt.Text = OrderDiscAmt
        Me.txtOrderNetAmt.Text = OrderNetAmt
        Me.txtLineGrossCharges.Text = LineChargeAmt
        Me.txtTotalAmt.Text = OrderNetAmt + LineChargeAmt
    End Sub

    Private Sub grdCharges_CellValueChanged(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles grdCharges.CellValueChanged
        Dim ColPropertyName As String
        Dim drv As DataRowView
        Dim dt As DataTable
        Dim objMaster As New classMaster
        drv = bsQuoteCharges.Current
        If bsQuoteCharges.DataSource Is Nothing Then Exit Sub
        ColPropertyName = UCase(grdCharges.CurrentCell.OwningColumn.DataPropertyName)
        If ColPropertyName = "ITCD" Then
            dt = objMaster.GetItemDesc(drv.Item("ITCD"))
            If dt IsNot Nothing Then
                drv.Item("itdesc") = dt.Rows(0).Item("itdesc")
            Else
                drv.Item("itdesc") = ""
            End If
        End If
        If ColPropertyName = "CHARGEAMT" Then
            CalculateTotals()
        End If
    End Sub

    Private Sub dtpExpiryDate_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles dtpExpiryDate.Enter
        dtpExpiryDate.Format = DateTimePickerFormat.Short
        dtpExpiryDate.CustomFormat = oldDTPcustomformat
    End Sub

    Private Sub dtpExpiryDate_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles dtpExpiryDate.Validating
        SetDTPExpiryDateFormat()
    End Sub

    Private Sub dtpExpiryDate_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dtpExpiryDate.ValueChanged
        SetDTPExpiryDateFormat()
    End Sub
    Private Sub SetDTPExpiryDateFormat()
        bsQuote.EndEdit()
        Dim drv As DataRowView = bsQuote.Current
        If drv Is Nothing Then Exit Sub
        If CDate(dtpExpiryDate.Value).ToString("yyyyMMdd") = "19000101" Then
            dtpExpiryDate.Format = DateTimePickerFormat.Custom
            dtpExpiryDate.CustomFormat = "  /  /    "
        Else
            dtpExpiryDate.Format = DateTimePickerFormat.Short
            dtpExpiryDate.CustomFormat = oldDTPcustomformat
        End If
    End Sub
    Private Sub grdQuoteItems_DefaultValuesNeeded(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewRowEventArgs) Handles grdQuoteItems.DefaultValuesNeeded
        Dim drv As DataRowView
        drv = bsQuoteItems.Current
        drv.Item("curr") = "THB"
        drv.Item("uom") = "KGS"
        drv.Item("shipdt") = ""
        drv.Item("cust_shipdt") = ""
        drv.Item("grossamt") = 0
        drv.Item("discper") = 0
        drv.Item("discamt") = 0
        drv.Item("netamt") = 0
        drv.Item("qtyfrom") = 0
        drv.Item("qtyto") = 0
        drv.Item("price") = 0
        drv.Item("item_remarks") = ""
        drv.Item("status_remarks") = ""
    End Sub
    Private Sub dtpQuoteDate_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtpQuoteDate.ValueChanged
        bsQuote.EndEdit()
        Dim drv As DataRowView = bsQuote.Current
        If drv Is Nothing Then Exit Sub

        drv.Item("expirydt2") = DateAdd(DateInterval.Day, drv.Item("validdays"), drv.Item("quotedt2"))
    End Sub

    Private Sub grdCharges_EditingControlShowing(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewEditingControlShowingEventArgs) Handles grdCharges.EditingControlShowing
        Dim ColPropertyName As String
        ColPropertyName = UCase(grdCharges.CurrentCell.OwningColumn.DataPropertyName)
        If ColPropertyName = "ITCD" Then
            gridTextBox = CType(e.Control, TextBox)
            If Not (gridTextBox Is Nothing) Then
                RemoveHandler gridTextBox.KeyPress, AddressOf gridTextBox_KeyPress
                AddHandler gridTextBox.KeyPress, AddressOf gridTextBox_KeyPress
            End If
        End If
    End Sub

    Private Sub grdCharges_CellLeave(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs)
        ' if the editing control is not nothing, unsubscribe the KeyPress event
        If Not (gridTextBox Is Nothing) Then
            RemoveHandler gridTextBox.KeyPress, AddressOf gridTextBox_KeyPress
        End If
    End Sub
    Private Sub gridTextBox_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        Dim drv As DataRowView
        Dim row As DataRow
        Dim ColPropertyName As String
        Dim formSearchItem As New Classes.formSearchItemcode
        Dim SearchResult As New Classes.SearchFormResult
        If bsQuoteCharges.DataSource Is Nothing Then Exit Sub
        bsQuoteCharges.EndEdit()
        drv = bsQuoteCharges.Current
        row = drv.Row

        ColPropertyName = UCase(grdCharges.CurrentCell.OwningColumn.DataPropertyName)
        If e.KeyChar = "?" Then
            formSearchItem.SqlConn = (New classConnection).getSQLConnection
            'SearchResult = formSearchItem.ShowItems("CHARGES")  'Old Comment by Sitthana 17/03/2018
            SearchResult = formSearchItem.ShowItems 'Sitthana 17/03/2018
            If SearchResult IsNot Nothing Then
                If SearchResult.ResultRowView IsNot Nothing Then
                    drv.Item("itcd") = SearchResult.ResultRowView.Item("itcd")
                    drv.Item("itdesc") = SearchResult.ResultRowView.Item("itdesc")
                Else
                    If drv.Item("itcd").ToString = "?" Then
                        drv.Item("itcd") = ""
                    End If
                End If
            End If
        End If
        e.Handled = True
    End Sub
    Private Sub grdCharges_DataError(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewDataErrorEventArgs) Handles grdCharges.DataError
        e.Cancel = True ' Suppress error message that occurs when column bound to combo box have values not in combolist
    End Sub
    Private Sub txtOrderDiscPer_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtOrderDiscPer.LostFocus
        CalculateTotals()
    End Sub

    Private Sub grdQuoteItems_CellValueChanged(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles grdQuoteItems.CellValueChanged
        Dim obj As New classMaster
        Dim designNo As String

        Dim drv As DataRowView
        Dim m_qty As Decimal
        Dim m_price As Decimal
        Dim m_grossamt As Decimal
        Dim m_discper As Decimal
        Dim m_discamt As Decimal
        Dim m_netamt As Decimal
        'Dim m_exrt As Decimal
        Dim ColPropertyName As String
        bsQuoteItems.EndEdit()
        bsQuoteCharges.EndEdit()

        drv = bsQuoteItems.Current
        If drv Is Nothing Then Exit Sub

        ' set values from grid to local variables
        m_qty = drv.Item("qtyto")
        m_price = drv.Item("price")
        m_discper = drv.Item("discper")

        ' calculate line amounts
        ' if the discper is entered by user then recalculate m_discamt otherwise keep user entered value
        m_discamt = drv.Item("discamt")
        m_grossamt = m_qty * m_price
        If m_discper > 0 Then
            m_discamt = m_grossamt * m_discper / 100
        End If
        drv.Item("discamt") = m_discamt

        m_netamt = m_grossamt - m_discamt

        ' set calculated amounts back to grid source
        drv.Item("grossamt") = m_grossamt
        drv.Item("netamt") = m_netamt

        CalculateTotals()
        If grdCharges.CurrentCell Is Nothing Then Exit Sub
        ColPropertyName = UCase(grdCharges.CurrentCell.OwningColumn.DataPropertyName)
        If ColPropertyName = "design_no" Then
            designNo = drv.Item("design_no")
            drv.Item("colrefdesno") = obj.GetArticle(designNo)
            drv.Item("colgmpersqm") = obj.GetGmPerSqm(designNo)
            drv.Item("Fwth") = obj.GetFWth(designNo)
        End If
    End Sub

#End Region

End Class
