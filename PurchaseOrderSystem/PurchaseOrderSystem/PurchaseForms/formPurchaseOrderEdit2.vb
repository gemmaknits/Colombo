Imports System.Data
Imports System.Data.SqlClient
Imports System.Text

Public Class formPurchaseOrderEdit2
    Public loginEmpcd As String = ""
    Private Clsconfig As New clsConfig
    Public selectitdesc As String
    Public selectitcd As String

    Private connStr As New classConnection
    Private m_import As Integer
    Dim ds As New DataSet
    Private dts As New DataTable
    Private dt As New DataTable

    Dim Qty As Double
    Dim UnitPrice As Double
    Dim Disc As Double
    Dim Discamt As Double
    Dim VatAmt As Double
    Dim sumDiscAmt As Double
    Dim sumGrossAmt As Double
    Dim dsTable1 As DataTable
    Dim dst2 As DataTable
    Dim clsUser As New classUserInfo

    Public Property UserInfo() As classUserInfo
        Get
            UserInfo = clsUser
        End Get
        Set(ByVal NewValue As classUserInfo)
            clsUser = NewValue
        End Set
    End Property

    Dim enableEdit As Boolean

    Private Sub formPurchaseOrderEdit_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.F4 Then
            loadSearchPO()
        End If
    End Sub

    Private Sub formPurchaseOrderEdit_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Me.KeyPress
        If e.KeyChar = (System.Windows.Forms.Keys.F4.ToString) Then
            loadSearchPO()
        End If
    End Sub

    Private Sub formPurchaseOrderCreate_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ' ----------------------   Supplier --------------------
        GetDataComboSupplier()
        GetDataComboDept()
        GetDataComboEmp()
        GetDataComboItemNature()
        ' ----------------------   Items    --------------------
        GetDataComcoInDgridItems()
        GetDataComboInDgridUnit()
        GetDataComboCurrency()

        Me.comboEmp.SelectedValue = ""
        Me.comboDept.SelectedValue = ""
        Me.cbCredit.SelectedValue = ""
        Me.cboCurrency.SelectedValue = ""
        Me.CbSupplier.SelectedValue = ""
    End Sub

    Private Sub GetDataComboCurrency()
        Dim GetdataItems As New GetDataYarn
        Dim ds As DataSet
        ds = GetdataItems.GetDataCurrency
        Me.cboCurrency.DataSource = ds.Tables(0)
        Me.cboCurrency.DisplayMember = "currname"
        Me.cboCurrency.ValueMember = "curr"
    End Sub

    Private Sub GetDataComboInDgridUnit()
        Dim GetdataItems As New GetDataYarn
        Dim dt As New DataTable
        dt = GetdataItems.GetDataUnit
        Me.coluom.DataSource = dt
        Me.coluom.DisplayMember = "uom"
        Me.coluom.ValueMember = "uom"
    End Sub

    Private Sub GetDataComcoInDgridItems()
        Dim GetdataItems As New GetDataYarn
        Dim dt As New DataTable
        dt = GetdataItems.GetDataItemcode("", comboItemNature.SelectedValue.ToString.Trim.ToUpper)
        'dt = GetdataItems.GetDataItem
        Me.cboitcd.DataSource = dt
        Me.cboitcd.DisplayMember = "itdesc"
        Me.cboitcd.ValueMember = "itcd"
    End Sub

    ' ----------------------   Supplier --------------------
    Private Sub GetDataComboSupplier()
        Dim GetdataComboSupp As New GetDataYarn
        Dim dt As DataTable
        dt = GetdataComboSupp.GetData_Suppliers
        Me.CbSupplier.DataSource = dt
        Me.CbSupplier.DisplayMember = "name"
        Me.CbSupplier.ValueMember = "suppcd"
    End Sub
    Private Sub GetDataComboEmp()
        Dim getDatayarn As New GetDataYarn
        Dim dt As DataTable
        dt = getDatayarn.GetEmpList()
        Me.comboEmp.DataSource = dt
        Me.comboEmp.DisplayMember = "empname"
        Me.comboEmp.ValueMember = "empcd"
    End Sub

    Private Sub GetDataComboDept()
        Dim getDatayarn As New GetDataYarn
        Dim dt As DataTable
        dt = getDatayarn.GetDeptList()
        Me.comboDept.DataSource = dt
        Me.comboDept.DisplayMember = "deptname"
        Me.comboDept.ValueMember = "deptcd"
    End Sub

    Private Sub GetDataComboItemNature()
        Dim getDatayarn As New GetDataYarn
        Dim dt As DataTable
        dt = getDatayarn.GetDataItemNature()
        Me.comboItemNature.DataSource = dt
        Me.comboItemNature.DisplayMember = "itnaturedesc"
        Me.comboItemNature.ValueMember = "itnaturecd"
        Me.comboItemNature.SelectedIndex = 0
    End Sub

    Private Sub CbSupplier_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CbSupplier.SelectedIndexChanged
        'GetDataComboSupplier()
        Dim GetdataAddr As New GetDataYarn
        Dim Obj_Supp As New tbl_Suppliers
        Dim msgerr As String = ""
        Dim Address As String
        If Not Me.CbSupplier.SelectedValue Is Nothing Then
            Obj_Supp = GetdataAddr.GetDataAddress(Me.CbSupplier.SelectedValue, msgerr)
            Address = Obj_Supp.addr1 & " " & Obj_Supp.addr2 & " " & Obj_Supp.addr3 & " " & Obj_Supp.addr1t & " " & Obj_Supp.addr2t & " " & Obj_Supp.addr3t & ", " & Obj_Supp.city & " " & Obj_Supp.ctry & " " & Obj_Supp.tel & " " & Obj_Supp.fax & " " & Obj_Supp.email & " " & Obj_Supp.contact
            m_import = Obj_Supp.import
            Me.checkImport.CheckState = m_import

            Me.txtAddress.Text = Address
            'Me.txtcredit.Text = Obj_Supp.crdays
        End If
    End Sub

    Private Sub DgYarn_CellValidated(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs)
        Dim column As DataGridViewColumn = DgYarn.Columns(e.ColumnIndex)
        Try
            If LCase(column.Name) = "itemcd" Then
                Me.DgYarn.CurrentRow.Cells("cboItcd").Value = Me.DgYarn.CurrentRow.Cells("Itemcd").Value
                selectitdesc = Me.DgYarn.CurrentRow.Cells("cboitcd").Value
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        Try
            If LCase(column.Name) = "cboitcd" Then
                Me.DgYarn.CurrentRow.Cells("Itemcd").Value = Me.DgYarn.CurrentRow.Cells("cboitcd").Value
                selectitdesc = Me.DgYarn.CurrentRow.Cells("cboitcd").Value
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        calc_final_totals()
    End Sub

    Private Sub BtnYarnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnYarnSave.Click
        Dim Obj_tbl_job As New tbl_job
        Dim Isvalid As Boolean
        Dim classPurchase As New classPurchase
        Dim msgerr As String = ""
        Dim purno As String = ""
        Dim m_HeaderHasErrors As Boolean = False
        Dim m_GridHasErrors As Boolean = False

        Dim m_errmess As New StringBuilder

        errorSupplier.SetError(Me.CbSupplier, "")
        errorEmp.SetError(Me.comboEmp, "")
        errorCurrency.SetError(Me.cboCurrency, "")
        errorItemGrid.SetError(Me.DgYarn, "")
        Me.errorSaved.Clear()

        '------------  job ---- -----------------------
        If Me.CbSupplier.SelectedValue = "" Then
            Me.errorSupplier.SetError(Me.CbSupplier, "Select a valid supplier")
            m_HeaderHasErrors = True
        End If

        Obj_tbl_job.suppcd = Me.CbSupplier.SelectedValue
        Obj_tbl_job.jobno = Me.txtPurno.Text
        Obj_tbl_job.jobdt = Me.DateYIN.Value.ToString("yyy/MM/dd")

        Obj_tbl_job.supquoteno = Me.textSupQuoteno.Text
        Obj_tbl_job.reqno = Me.textReqno.Text

        Dim SDate As Date
        Dim LDate As Date
        SDate = Today.Date
        LDate = Me.DtPayDate.Value
        Obj_tbl_job.delidays = DateDiff(DateInterval.Day, SDate, LDate) 'Me.DtPayDate.Value
        Obj_tbl_job.delidt = Me.DtDileveryDate.Value.ToString("yyy/MM/dd") 'As DateTime

        Obj_tbl_job.crterm = Me.cbCredit.Text
        Obj_tbl_job.crdays = Val(Me.txtcredit.Text.Trim)

        If Me.comboEmp.SelectedValue = "" Then
            errorEmp.SetError(Me.comboEmp, "Select person who made the request..")
            m_HeaderHasErrors = True
        End If
        If Me.cboCurrency.SelectedValue = "" Then 'As String
            errorCurrency.SetError(Me.cboCurrency, "Select currency..")
            m_HeaderHasErrors = True
        End If

        Obj_tbl_job.Empcd = Me.comboEmp.SelectedValue
        Obj_tbl_job.Deptcd = Me.comboDept.SelectedValue
        Obj_tbl_job.jobtype = "PURCHASE"
        Obj_tbl_job.splins = Me.txtpackcd.Text.Trim 'As String
        Obj_tbl_job.remark = Me.txtremark.Text.Trim 'As String
        Obj_tbl_job.import = m_import 'As Boolean
        Obj_tbl_job.curr = Me.cboCurrency.SelectedValue 'As String
        Obj_tbl_job.exrt = (Me.txtrate.Text.Trim) 'As Double
        Obj_tbl_job.discper = (Me.txtDisper.Text.Trim) 'As Double
        Obj_tbl_job.discamt = (Me.txtDiscountamount.Text.Trim) 'As Double
        Obj_tbl_job.vat = Me.txtVat.Text.Trim 'As Double
        Obj_tbl_job.vatamt = Me.txtVatAmount.Text.Trim  'As Double
        '		Obj_tbl_job.taxamt = Val(Me.txtTaxAmount.Text.Trim)	'As Double
        Obj_tbl_job.taxamt = 0  'As Double
        Obj_tbl_job.shipvia = (Me.txtShipvia.Text.Trim) 'As Double
        Obj_tbl_job.totamt = (Me.txtTotalAmount.Text.Trim) 'As Double
        Obj_tbl_job.deliaddr = Me.textDeliAddr.Text
        Obj_tbl_job.shipterms = Me.textShipterms.Text
        Obj_tbl_job.remark = Me.txtremark.Text
        Obj_tbl_job.cancel_status = 0 'As Boolean

        '-------------- job_det -------------------------------

        Dim i As Integer
        Dim Lineamt As Integer
        For i = 0 To Me.DgYarn.Rows.Count - 2
            Qty = Me.DgYarn.Rows(i).Cells("colQty").Value
            UnitPrice = Me.DgYarn.Rows(i).Cells("colPrice").Value
            Disc = DgYarn.Rows(i).Cells("colDiscper").Value
            Lineamt = Me.DgYarn.Rows(i).Cells("colLineamt").Value
            m_errmess.Append("Please check ")

            If Me.DgYarn.Rows(i).Cells("Itemcd").Value.ToString = "" Then
                m_errmess.Append("Item code")
                m_GridHasErrors = True
            End If
            If Me.DgYarn.Rows(i).Cells("colUom").Value.ToString = "" Then
                m_errmess.Append(",Unit")
                m_GridHasErrors = True
            End If
            If Me.DgYarn.Rows(i).Cells("colPrice").Value.ToString = "" Then
                m_errmess.Append(",Price")
                m_GridHasErrors = True
            End If
            If Me.DgYarn.Rows(i).Cells("colQty").Value.ToString = "" Then
                m_errmess.Append(",Qty")
                m_GridHasErrors = True
            End If

            If Me.DgYarn.Rows(i).Cells("colMoreDesc").Value = "" Then
                Me.DgYarn.Rows(i).Cells("colMoreDesc").Value = " "
            End If

            If m_GridHasErrors Then
                errorItemGrid.SetError(Me.DgYarn, m_errmess.ToString)
            End If

            ReDim Preserve Obj_tbl_job.tbl_job_det(i)
            Obj_tbl_job.tbl_job_det(i) = New tbl_job_det
            Obj_tbl_job.tbl_job_det(i).supquoteno = Obj_tbl_job.supquoteno  'As String
            If Not IsDBNull(Me.DgYarn.Rows(i).Cells("colIdJobdet").Value) Then  ' New records do not have id
                Obj_tbl_job.tbl_job_det(i).id_jobdet = Me.DgYarn.Rows(i).Cells("colIdJobdet").Value
            End If
            Obj_tbl_job.tbl_job_det(i).itcd = Me.DgYarn.Rows(i).Cells("Itemcd").Value.ToString
            Obj_tbl_job.tbl_job_det(i).itdesc = Me.DgYarn.Rows(i).Cells("colMoreDesc").Value.ToString
            Obj_tbl_job.tbl_job_det(i).qty = Me.DgYarn.Rows(i).Cells("colQty").Value.ToString
            Obj_tbl_job.tbl_job_det(i).uom = Me.DgYarn.Rows(i).Cells("colUom").Value.ToString
            Obj_tbl_job.tbl_job_det(i).price = Me.DgYarn.Rows(i).Cells("colprice").Value.ToString
            Obj_tbl_job.tbl_job_det(i).curr = Obj_tbl_job.curr    'As String
            Obj_tbl_job.tbl_job_det(i).exrt = Obj_tbl_job.exrt  'As Double
            Obj_tbl_job.tbl_job_det(i).discper = (Me.DgYarn.Rows(i).Cells("coldiscper").Value.ToString) 'As Double
            Obj_tbl_job.tbl_job_det(i).discamt = (Me.DgYarn.Rows(i).Cells("coldiscamt").Value.ToString)   'As Double
            Obj_tbl_job.tbl_job_det(i).lineamt = Lineamt
            'Obj_tbl_job.tbl_job_det(i).delidt = Obj_tbl_job.delidt	'As DateTime
            Obj_tbl_job.tbl_job_det(i).delidt = Me.DgYarn.Rows(i).Cells("delidt").Value
            Obj_tbl_job.tbl_job_det(i).closed = 0 ' As bit
            Obj_tbl_job.tbl_job_det(i).remark = Me.DgYarn.Rows(i).Cells("colRemLine").Value.ToString.Trim
            If Not IsDBNull(Me.DgYarn.Rows(i).Cells("colSono").Value) Then
                Obj_tbl_job.tbl_job_det(i).sono = Me.DgYarn.Rows(i).Cells("colSono").Value
            Else
                Obj_tbl_job.tbl_job_det(i).sono = " "
            End If
            If Not IsDBNull(Me.DgYarn.Rows(i).Cells("colSuppitcd").Value) Then
                Obj_tbl_job.tbl_job_det(i).suppitcd = Me.DgYarn.Rows(i).Cells("colSuppitcd").Value
            Else
                Obj_tbl_job.tbl_job_det(i).suppitcd = " "
            End If
        Next

        If m_GridHasErrors Or m_HeaderHasErrors Then
            MsgBox("Some required values are missing, please check..", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Data incomplete")
            Exit Sub
        End If
        '------------------ Delete records ---------------------

        Dim deletedRecs As New DataView(dst2, "", "", DataViewRowState.Deleted)
        'Dim deletedRec As DataRowView
        'Dim m_Boxno As String
        'Dim strDelete As String

        'For Each deletedRec In deletedRecs
        '	m_Boxno = deletedRec("Boxno")
        '	strDelete = "Delete Yarn_in_det where boxno = '" & m_Boxno & "'"
        '	comm.CommandText = strDelete.ToString
        '	comm.ExecuteNonQuery()
        'Next
        '----------------
        Isvalid = classPurchase.updatePurchaseOrder(Obj_tbl_job, deletedRecs, msgerr, Me.loginEmpcd)

        If Isvalid = True Then
            '			MsgBox("P/O updated successfully", MsgBoxStyle.Information)
            errorSaved.SetError(Me.txtPurno, "Last update successful")
            '-- refresh the PO data from database
            Me.showPOData()
        Else
            MsgBox(msgerr)
        End If
    End Sub

    Private Sub DgYarn_DefaultValuesNeeded(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewRowEventArgs)
        e.Row.Cells("colQty").Value = 0
        e.Row.Cells("colPrice").Value = 0
        e.Row.Cells("colDiscper").Value = 0
        e.Row.Cells("colDiscamt").Value = 0
        e.Row.Cells("collineamt").Value = 0
        e.Row.Cells("colMoredesc").Value = " "
        e.Row.Cells("remark").Value = " "
        e.Row.Cells("colSono").Value = " "
        e.Row.Cells("colSuppitcd").Value = " "
    End Sub

    Private Sub txtdeliveryday_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtdeliveryday.TextChanged
        Dim aa As Integer
        Try
            aa = txtdeliveryday.Text
            Me.DtDileveryDate.Value = Me.DateYIN.Value.AddDays(aa)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub txtShipvia_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtShipvia.KeyDown
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send("{tab}")
        End If
    End Sub

    Private Sub txtcredit_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtcredit.TextChanged
        Dim d As Integer
        If IsNumeric(Me.txtcredit.Text.Trim) = True Then
            d = CDec(Me.txtcredit.Text.Trim)
        Else
            d = 0
        End If
        Try
            Me.DtPayDate.Value = Now().AddDays(d)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub BtnYarnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnYarnExit.Click
        Me.Close()
    End Sub

    Private Function chkErrbutUse(ByVal strmsg As String) As Boolean
        'Try
        '    ds.Tables("v_editJoboOrderForYarnEdit").Clear()
        '    chkErrbutUse = True
        'Catch ex As Exception
        '    chkErrbutUse = False
        '    Exit Function
        'End Try
    End Function

    Private Function chkErrbutUse2(ByVal strmsg As String) As Boolean
        'Dim strtempA As String = ""
        'Try
        '    strtempA = ds.Tables("v_editJoboOrderForYarnEdit").Rows(0).Item("itcd").ToString
        '    chkErrbutUse2 = True
        'Catch ex As Exception
        '    chkErrbutUse2 = False
        '    Exit Function
        'End Try
    End Function

    Private Sub DgYarn_RowValidated(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs)
        Try
            Me.DgYarn.CurrentRow.Cells("Itemcd").Value = Me.DgYarn.CurrentRow.Cells("cboitcd").Value
            selectitdesc = Me.DgYarn.CurrentRow.Cells("cboitcd").Value
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        calc_final_totals()
    End Sub

    Private Sub calc_final_totals()
        Dim m_CurrExchangeRate As Double = 0
        Dim m_GrossLineAmt As Double = 0
        Dim m_GrossLineDisc As Double = 0
        Dim m_NetLineAmt As Double = 0
        Dim m_OrderDiscPer As Double = 0
        Dim m_OrderDiscAmt As Double = Val(IIf(IsNumeric(txtDiscountamount.Text.Replace(",", "")), txtDiscountamount.Text.Replace(",", ""), 0))
        Dim m_NetOrderAmt As Double = 0
        Dim m_VATPer As Double = 0
        Dim m_VATAmt As Double = Val(IIf(IsNumeric(txtVatAmount.Text.Replace(",", "")), txtVatAmount.Text.Replace(",", ""), 0))
        Dim m_NetOrderAmtAfterVAT As Double = 0

        Call sumLineTotals()

        m_CurrExchangeRate = Val(IIf(IsNumeric(txtrate.Text), txtrate.Text, 0))
        m_CurrExchangeRate = IIf(m_CurrExchangeRate <= 0, 1, m_CurrExchangeRate)
        m_GrossLineAmt = sumGrossAmt * m_CurrExchangeRate
        m_GrossLineDisc = sumDiscAmt * m_CurrExchangeRate
        m_NetLineAmt = m_GrossLineAmt - m_GrossLineDisc
        m_OrderDiscPer = Val(IIf(IsNumeric(txtDisper.Text), txtDisper.Text, 0))
        If m_OrderDiscPer = 0 Then
            m_OrderDiscPer = Math.Round((m_OrderDiscAmt / m_NetLineAmt) * 100, 2)
        Else
            m_OrderDiscAmt = m_NetLineAmt * m_OrderDiscPer * 0.01
        End If
        m_NetOrderAmt = m_NetLineAmt - m_OrderDiscAmt
        m_VATPer = Val(IIf(IsNumeric(txtVat.Text), txtVat.Text, 0))
        If m_VATPer = 0 Then
            m_VATPer = Math.Round((m_VATAmt / m_NetOrderAmt) * 100, 2)
        Else
            m_VATAmt = m_NetOrderAmt * m_VATPer * 0.01
        End If
        m_NetOrderAmtAfterVAT = m_NetOrderAmt + m_VATAmt

        txtrate.Text = FormatNumber(m_CurrExchangeRate, 2, TriState.False, TriState.False, TriState.True)
        txtGrossamount.Text = FormatNumber(m_GrossLineAmt, 2, TriState.False, TriState.False, TriState.True)
        txtGrossLineDiscount.Text = FormatNumber(m_GrossLineDisc, 2, TriState.False, TriState.False, TriState.True)
        txtNetLineAmount.Text = FormatNumber(m_NetLineAmt, 2, TriState.False, TriState.False, TriState.True)
        txtDisper.Text = FormatNumber(m_OrderDiscPer, 2, TriState.False, TriState.False, TriState.True)
        txtDiscountamount.Text = FormatNumber(m_OrderDiscAmt, 2, TriState.False, TriState.False, TriState.True)
        txtNetOrderAmount.Text = FormatNumber(m_NetOrderAmt, 2, TriState.False, TriState.False, TriState.True)
        txtVat.Text = FormatNumber(m_VATPer, 2, TriState.False, TriState.False, TriState.True)
        txtVatAmount.Text = FormatNumber(m_VATAmt, 2, TriState.False, TriState.False, TriState.True)
        txtTotalAmount.Text = FormatNumber(m_NetOrderAmtAfterVAT, 2, TriState.False, TriState.False, TriState.True)

        '' Define variables to hold totals
        'Dim m_grossAmt As Double
        'Dim m_lineDiscAmt As Double

        'Dim m_finalDiscAmt As Double
        'Dim m_vatper As Double
        'Dim m_vatamt As Double
        'Dim m_taxamt As Double

        'Dim m_finalDiscPer As Double
        'Dim m_AfterLineDisc As Double
        'Dim m_AfterAllDisc As Double
        'Dim m_AfterVat As Double
        'Dim m_netTotalAmt As Double

        'sumLineTotals()

        ''check for null & initialise the values in the textbox
        'If txtDisper.Text = "" Then
        '	txtDisper.Text = 0
        'End If
        'If txtVat.Text = "" Then
        '	txtVat.Text = 0
        'End If

        ''final discount % & vat
        'm_finalDiscPer = txtDisper.Text
        'm_vatper = txtVat.Text

        ''gross amount arrived by Qty*price from line items
        'm_grossAmt = sumGrossAmt

        ''disc amount arrived by qty*price*discper/100 from line items
        'm_lineDiscAmt = sumDiscAmt

        ''(A) amount arrived after deducting line discount from gross amount
        'm_AfterLineDisc = m_grossAmt - m_lineDiscAmt

        ''(B) amount arrived after deducting final discount from above amount (A)
        'm_finalDiscAmt = m_AfterLineDisc * m_finalDiscPer / 100
        'm_AfterAllDisc = m_AfterLineDisc - m_finalDiscAmt

        ''(C)amount arrived after adding vat amount from above (B)
        'm_vatamt = m_AfterAllDisc * m_vatper / 100
        'm_AfterVat = m_AfterAllDisc + m_vatamt

        ''(D)amount arrived after adding vat (C) is the net amount
        'm_netTotalAmt = m_AfterVat

        ''put the arrived totals in the respective textboxes.
        'Me.txtGrossamount.Text = String.Format("{0:#,###0.00}", m_grossAmt)
        'Me.txtDiscountamount.Text = String.Format("{0:#,###0.00}", m_lineDiscAmt + m_finalDiscAmt)
        'Me.txtVatAmount.Text = String.Format("{0:#,###0.00}", m_vatamt)
        'Me.txtDiscountamount.Text = String.Format("{0:#,###0.00}", m_lineDiscAmt + m_finalDiscAmt)
        'Me.txtTotalAmount.Text = String.Format("{0:#,###0.00}", m_AfterVat)
    End Sub

    Private Sub txtPurno_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtPurno.KeyDown
        errorSaved.SetError(Me.txtPurno, "")
        If e.KeyCode = Keys.F4 Then
            loadSearchPO()
            Exit Sub
        End If
        If e.KeyCode = Keys.Enter Then
            showPOData()
        End If
    End Sub

    Private Function chkErrbutUseClearTable(ByVal strmsg As String) As Boolean
        Try
            ds.Tables("v_pur").Clear()
            chkErrbutUseClearTable = True
        Catch ex As Exception
            chkErrbutUseClearTable = False
            Exit Function
        End Try
    End Function

    Private Function chkErrbutUseClearTableDet(ByVal strmsg As String) As Boolean
        Try
            ds.Tables("v_purdet").Clear()
            chkErrbutUseClearTableDet = True
        Catch ex As Exception
            chkErrbutUseClearTableDet = False
            Exit Function
        End Try
    End Function

    Private Function chkErrbutUseHavedataIntable(ByVal strmsg As String) As Boolean
        Dim strtempA As String = ""
        Try
            strtempA = ds.Tables("v_pur").Rows(0).Item("itcd").ToString
            chkErrbutUseHavedataIntable = True
        Catch ex As Exception
            chkErrbutUseHavedataIntable = False
            Exit Function
        End Try
    End Function

    Private Sub BtnYarnPrintDoc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnYarnPrintDoc.Click
        Dim str As String
        str = ""
        ds.Clear()
        If Me.txtPurno.Text.Trim = "" Then
            Exit Sub
        End If
        str = "select * from v_pur where jobno = '" & Me.txtPurno.Text.Trim & "'"
        Dim myda As New SqlDataAdapter(str.ToString, connStr.connection)
        myda.Fill(ds, "Tblprint")
        If ds.Tables("Tblprint").Rows.Count > 0 Then
            If Not PrintReport(ds) Then
                'Dim frmreport As New FormRptPurchaseOrderCreate
                'Dim obj As New RptPurchaseOrderCreate
                'obj.SetDataSource(ds.Tables("Tblprint"))
                'frmreport.CrystalReportViewer1.ReportSource = obj
                'frmreport.ShowDialog()
            End If
        End If
    End Sub

    Private Function PrintReport(ByVal ds As DataSet) As Boolean
        Dim clsConn As New classConnection()
        Const rptFileName = "RptPurchaseOrderCreate.rpt"
        If Not Clsconfig.CheckReport(clsUser.ReportPath, rptFileName) Then Return False
        Dim frm As New frmReport
        Dim rpt As New CrystalDecisions.CrystalReports.Engine.ReportDocument
        Me.Cursor = Cursors.WaitCursor

        rpt.Load(clsUser.ReportPath & rptFileName)
        rpt.DataSourceConnections.Item(0).SetConnection(clsConn.servername, clsConn.database, False)
        rpt.DataSourceConnections.Item(0).SetLogon(clsConn.Userid, clsConn.Password)
        rpt.SetDataSource(ds.Tables("Tblprint"))

        rpt.PrintOptions.PaperSize = CrystalDecisions.Shared.PaperSize.PaperA4
        rpt.PrintOptions.PaperOrientation = CrystalDecisions.Shared.PaperOrientation.Portrait
        rpt.PrintOptions.PaperSource = CrystalDecisions.Shared.PaperSource.Auto

        frm.Title = "Purchase Order"
        frm.CRViewer.ReportSource = rpt
        frm.MdiParent = Me.ParentForm
        frm.Show()
        Me.Cursor = Cursors.Default
        Return True
    End Function

    Private Sub sumLineTotals()
        Qty = 0
        UnitPrice = 0
        Disc = 0
        sumDiscAmt = 0
        sumGrossAmt = 0

        Try
            Dim i As Integer

            For i = 0 To Me.DgYarn.Rows.Count - 2
                'If Me.DgYarn.Rows(i).Cells("colQty").Value = Nothing Then
                '	Me.DgYarn.Rows(i).Cells("colqty").Value = 0
                'End If

                'If Me.DgYarn.Rows(i).Cells("colPrice").Value = Nothing Then
                '	Me.DgYarn.Rows(i).Cells("colPrice").Value = 0
                'End If

                'If Me.DgYarn.Rows(i).Cells("colDiscper").Value = Nothing Then
                '	Me.DgYarn.Rows(i).Cells("colDiscper").Value = 0
                'End If

                'If Me.DgYarn.Rows(i).Cells("colDiscamt").Value = Nothing Then
                '	Me.DgYarn.Rows(i).Cells("coldiscamt").Value = 0
                'End If
                Me.DgYarn.Rows(i).Cells("colQty").Value = Clsconfig.IsNull(Me.DgYarn.Rows(i).Cells("colQty").Value, 0)
                Me.DgYarn.Rows(i).Cells("colPrice").Value = Clsconfig.IsNull(Me.DgYarn.Rows(i).Cells("colPrice").Value, 0)
                Me.DgYarn.Rows(i).Cells("colDiscper").Value = Clsconfig.IsNull(Me.DgYarn.Rows(i).Cells("colDiscper").Value, 0)
                Me.DgYarn.Rows(i).Cells("colDiscamt").Value = Clsconfig.IsNull(Me.DgYarn.Rows(i).Cells("colDiscamt").Value, 0)

                Qty = Me.DgYarn.Rows(i).Cells("colQty").Value
                UnitPrice = Me.DgYarn.Rows(i).Cells("colPrice").Value
                Disc = DgYarn.Rows(i).Cells("colDiscper").Value
                Discamt = Me.DgYarn.Rows(i).Cells("colDiscamt").Value

                If Disc > 0 Then
                    Discamt = ((Qty * UnitPrice) * Disc) / 100
                Else
                    'If MsgBox("Discount % is 0, do you want to reset discount amount to 0?", MsgBoxStyle.YesNo, "Reset discount") = MsgBoxResult.Yes Then
                    Discamt = 0
                    'End If
                End If

                Me.DgYarn.Rows(i).Cells("colDiscamt").Value = Discamt

                Me.DgYarn.Rows(i).Cells("colLineamt").Value = (Qty * UnitPrice) - ((Qty * UnitPrice) * Disc) / 100
                sumDiscAmt = sumDiscAmt + Me.DgYarn.Rows(i).Cells("colDiscAmt").Value
                sumGrossAmt = sumGrossAmt + (Qty * UnitPrice)
            Next
            Me.txtDiscountamount.Text = String.Format("{0:#,###0.00}", sumDiscAmt)  ' sumDiscAmt
            Me.txtGrossamount.Text = String.Format("{0:#,###0.00}", sumGrossAmt) 'sumGrossAmt
            Dim grossamount As Double
            Dim vat As Double
            vat = Val(Me.txtVat.Text)
            'grossamount = Me.txtGrossamount.Text
            grossamount = sumGrossAmt
            txtVatAmount.Text = String.Format("{0:#,###0.00}", (grossamount * vat) / 100) '(grossamount * vat) / 100

            Dim discountamount As Double
            Dim taxamount As Double
            'VatAmt = Me.txtVatAmount.Text
            VatAmt = (grossamount * vat) / 100
            'discountamount = Me.txtDiscountamount.Text
            discountamount = sumDiscAmt
            Dim Argtotalamount As Double
            Argtotalamount = grossamount - (VatAmt + taxamount + txtVatAmount.Text + discountamount)
            Me.txtTotalAmount.Text = String.Format("{0:#,###0.00}", Argtotalamount)

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub buttonSearchPO_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles buttonSearchPO.Click
        loadSearchPO()
    End Sub

    Private Sub showPOData()
        Dim dsset As New DataSet
        Dim strsql2 As String
        Dim strmsg As String = ""
        Try
            strsql2 = "select * from v_pur where jobno = '" & Me.txtPurno.Text.Trim & "'"
            Dim da As New SqlDataAdapter(strsql2.ToString, connStr.connection)
            strsql2 = "select jobno,id_jobdet,itcd,itcd as itcd1,addldesc AS itdesc,qty,uom,price,discper,discamt,lineamt,rem_line,sono,suppitcd,delidt2 as delidt from v_pur where jobno = '" & Me.txtPurno.Text.Trim & "'"

            Dim daDet As New SqlDataAdapter(strsql2.ToString, connStr.connection)
            If chkErrbutUseClearTable(strmsg) = True Then
                ds.Tables("v_pur").Clear()
            End If

            If chkErrbutUseClearTableDet(strmsg) = True Then
                ds.Tables("v_purdet").Clear()
            End If

            da.Fill(ds, "v_pur")
            daDet.Fill(ds, "v_purdet")

            '==================================================================================
            If ds.Tables("v_pur").Rows.Count > 0 Then
                comboItemNature.SelectedValue = ds.Tables("v_pur").Rows(0).Item("itnaturecd")
                Me.DtDileveryDate.Text = ds.Tables("v_pur").Rows(0).Item("delidt")
                Me.txtpackcd.Text = ds.Tables("v_pur").Rows(0).Item("splins")
                Me.txtremark.Text = ds.Tables("v_pur").Rows(0).Item("splins")
                Me.txtrate.Text = ds.Tables("v_pur").Rows(0).Item("exrt")
                Me.txtVat.Text = ds.Tables("v_pur").Rows(0).Item("vat")
                Me.txtDisper.Text = ds.Tables("v_pur").Rows(0).Item("discper_h")
                Me.txtShipvia.Text = ds.Tables("v_pur").Rows(0).Item("shipvia")
                Me.textShipterms.Text = ds.Tables("v_pur").Rows(0).Item("shipterms")
                Me.textSupQuoteno.Text = ds.Tables("v_pur").Rows(0).Item("supquoteno")
                Me.txtcredit.Text = ds.Tables("v_pur").Rows(0).Item("crdays")
                Me.cbCredit.Text = ds.Tables("v_pur").Rows(0).Item("crterm").ToString
                Me.textReqno.Text = ds.Tables("v_pur").Rows(0).Item("reqno").ToString
                Me.txtremark.Text = ds.Tables("v_pur").Rows(0).Item("rem").ToString
                Me.txtpackcd.Text = ds.Tables("v_pur").Rows(0).Item("splins").ToString
                Me.comboEmp.SelectedValue = ds.Tables("v_pur").Rows(0).Item("Empcd").ToString
                Me.comboDept.SelectedValue = ds.Tables("v_pur").Rows(0).Item("deptcd").ToString
                Me.CbSupplier.SelectedValue = ds.Tables("v_pur").Rows(0).Item("suppcd").ToString
                Me.cboCurrency.SelectedValue = ds.Tables("v_pur").Rows(0).Item("curr").ToString.Trim
                Me.DateYIN.Value = ds.Tables("v_pur").Rows(0).Item("jobdt").ToString.Trim
            Else
                'Me.DgYarn.DataSource = ""
                MsgBox("data not found kap pom !", MsgBoxStyle.Critical, "กรุณาตรวจสอบหมายเลข PO no :")
            End If
            If ds.Tables("v_purdet").Rows.Count > 0 Then
                dst2 = ds.Tables("v_purdet")
                Me.DgYarn.DataSource = dst2
            Else
                'Me.DgYarn.DataSource = ""
                'MsgBox("data not found kap pom !", MsgBoxStyle.Critical, "กรุณาตรวจสอบหมายเลข PO no :")
            End If
            '			If ds.Tables("v_pur").Rows(0).Item("present_status").ToString.Trim = "CANCELLED" Or ds.Tables("v_pur").Rows(0).Item("present_status").ToString.Trim = "APPROVED" Then
            If ds.Tables("v_pur").Rows(0).Item("present_status").ToString.Trim = "CANCELLED" Then
                enableEdit = False
            Else
                enableEdit = True
            End If
            Me.textPresentStatus.Text = ds.Tables("v_pur").Rows(0).Item("present_status").ToString
            enableDisableEdit()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        calc_final_totals()

    End Sub

    Private Sub loadSearchPO()
        Dim formSearchPO As New formSearchPO
        formSearchPO.ShowDialog()

        If formSearchPO.puserAction = "OK" Then
            Me.txtPurno.Text = formSearchPO.pSelectedPO
            Call showPOData()
        End If
    End Sub

    Private Sub enableDisableEdit()
        Me.BtnYarnSave.Enabled = enableEdit
    End Sub

    Private Sub DgYarn_CellEndEdit(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DgYarn.CellEndEdit
        Dim currRow As Integer
        Dim currCol As Integer
        currRow = e.RowIndex
        currCol = e.ColumnIndex

        If UCase(DgYarn.Columns(currCol).Name) = "COLSONO" Then
            If DgYarn.Rows(currRow).Cells(currCol).Value = "?" Then
                Dim selectedSO As String
                Dim formSearchSO As New formSearchSO
                selectedSO = formSearchSO.getSOno
                If selectedSO <> "" Then
                    DgYarn.Rows(currRow).Cells(currCol).Value = selectedSO
                End If

            End If
        Else
            ' validate s/o. if invalid, display error
        End If
        Call calc_final_totals()
    End Sub

    Private Sub txtrate_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtrate.LostFocus
        calc_final_totals()
        Call txtDisper.Focus()
    End Sub

    Private Sub txtDisper_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtDisper.LostFocus
        txtDiscountamount.Text = ""
        calc_final_totals()
    End Sub

    Private Sub txtDiscountamount_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtDiscountamount.LostFocus
        txtDisper.Text = ""
        calc_final_totals()
    End Sub

    Private Sub txtVat_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtVat.LostFocus
        txtVatAmount.Text = ""
        calc_final_totals()
    End Sub

    Private Sub txtVatAmount_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtVatAmount.LostFocus
        txtVat.Text = ""
        calc_final_totals()
    End Sub

    Private Sub comboItemNature_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles comboItemNature.SelectedIndexChanged
        GetDataComcoInDgridItems()
    End Sub

    Private Sub txtPurno_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtPurno.TextChanged

    End Sub

    Private Sub DtPayDate_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DtPayDate.ValueChanged

    End Sub
End Class