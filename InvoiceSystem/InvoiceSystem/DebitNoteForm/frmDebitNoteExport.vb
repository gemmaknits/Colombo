Public Class frmDebitNoteExport
    Private clsConfig As New clsConfig
    Private clsUser As New classUserInfo
    Dim blnCancel As Boolean
    Dim header As New classDebitNoteExport.DebitNoteARHeader
    Dim lngInvID As Integer

    Public Property UserInfo() As classUserInfo
        Get
            UserInfo = clsUser
        End Get
        Set(ByVal NewValue As classUserInfo)
            clsUser = NewValue
        End Set
    End Property

    Public Sub GenComboDocNo()
        Dim objdb As New classDebitNoteExport
        'Dim objDB As New classDebitNoteAR
        cboDocNo.ComboBox.DataSource = objdb.GetDocNo(0, "")
        cboDocNo.ComboBox.DisplayMember = "dbnote_no"
        cboDocNo.ComboBox.ValueMember = "id_dbnote"
        cboDocNo.ComboBox.SelectedIndex = -1
    End Sub

    Public Sub GenCombo()
  
        uom.DataSource = (New classMaster).GetUOM()
        uom.DisplayMember = "uom"
        uom.ValueMember = "uom_id"

        cboinvno.DataSource = (New classDebitNoteExport).GetInvNo()
        cboinvno.DisplayMember = "invno"
        cboinvno.ValueMember = "invid"
        cboinvno.SelectedIndex = -1

        Dim objDB As New classMaster
        Me.cboCustomer.DataSource = objDB.GetCustomer
        Me.cboCustomer.DisplayMember = "name"
        Me.cboCustomer.ValueMember = "custcd"

        'Case "cboSalesMan"
        cboSalesMan.DataSource = objDB.GetEmp
        cboSalesMan.DisplayMember = "empname"
        cboSalesMan.ValueMember = "empcd2"

        cboCurrency.DataSource = (New classMaster).GetCurrency
        cboCurrency.DisplayMember = "Curr"
        cboCurrency.ValueMember = "Curr"

        cboInvtype.DataSource = (New classMaster).GetInvType
        cboInvtype.DisplayMember = "invtype_name"
        cboInvtype.ValueMember = "invtype"
        cboInvtype.SelectedValue = "E"
    End Sub
    Private Sub frmDebitNoteExport_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Call btnNew_Click(sender, e)
        Application.DoEvents()
    End Sub

    Public Sub InitControl()
        Call LoadData("")

        cboInvtype.SelectedValue = "E"
    End Sub

    Public Sub LoadData(Optional ByVal strDocNo As String = "")
        Dim objDB As New classDebitNoteExport
        Dim dt As New DataTable
        dt = objDB.GetDocDetails(0, strDocNo)

        Call BindGrid(grdDetails, dt)
        Call Bindtext(grdDetails, dt)
    End Sub

    Private Sub Binddata(ByRef grd As DataGridView, ByVal dt As DataTable)
        Call Bindtext(grd, dt)
        Call BindGrid(grd, dt)
    End Sub
    Private Sub Bindtext(ByRef grd As DataGridView, ByVal dt As DataTable)
        If dt.Rows.Count > 0 Then
            header.h01_id_dbnote = dt.Rows(0)("id_dbnote")

            cboCustomer.SelectedValue = dt.Rows(0)("custcd")

            cboinvno.Text = dt.Rows(0)("invno")

            txtDbNoteNo.Text = dt.Rows(0)("dbnote_no")
            txtpresent_status.Text = dt.Rows(0)("present_status")
            dtpDocDate.Value = DateTime.ParseExact(dt.Rows(0)("dbnote_date"), "yyyyMMdd", Nothing)
            txtReference.Text = dt.Rows(0)("reference")
            txtRemarks.Text = dt.Rows(0)("remarks")
            cboSalesMan.SelectedValue = dt.Rows(0)("empcd")
            cboInvtype.SelectedValue = dt.Rows(0)("invtype")
            SumGrid(dt)

            If dt.Rows(0)("present_status").ToString.Trim = "CANCELLED" Then
                Call EnabledControl(False)
            End If

        Else
            header.h01_id_dbnote = 0
            cboCustomer.SelectedIndex = -1

            cboinvno.Text = ""
            txtDbNoteNo.Text = ""
            txtpresent_status.Text = ""
            dtpDocDate.Value = Now
            txtReference.Text = ""
            txtRemarks.Text = ""
            cboSalesMan.SelectedIndex = -1
            cboInvtype.SelectedValue = "E"
            SumGrid(dt)

            'If dt.Rows(0)("present_status").ToString.Trim = "CANCELLED" Then
            'lblCancelled.Visible = True
            'lblCancelled.Text = "CANCELLED BY:" + dt.Rows(0)("CancelRecUserName").ToString.Trim + " / Dt: " + dt.Rows(0)("CancelRecDate").ToString.Trim
            Call EnabledControl(True)
            'End If
        End If

    End Sub

    Private Sub EnabledControl(ByVal blnEnabled As Boolean)
        Dim obj As Control
        For Each obj In Me.Controls
            Call SetControlEnabled(obj, blnEnabled)
        Next


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
        If TypeOf Obj Is TabControl Or TypeOf Obj Is TabPage Or TypeOf Obj Is GroupBox Then
            Dim obj2 As Control
            For Each obj2 In Obj.Controls
                Call SetControlEnabled(obj2, blnEnabled)
            Next
        End If
    End Sub


    Private Sub BindGrid(ByRef grd As DataGridView, ByVal dt As DataTable)
        grd.AutoGenerateColumns = False
        grd.DataSource = dt
    End Sub

    Private Sub cboDocNo_Click(sender As System.Object, e As System.EventArgs) Handles cboDocNo.Click

    End Sub

    Private Sub cboDocNo_DropDown(sender As Object, e As System.EventArgs) Handles cboDocNo.DropDown

    End Sub

    Private Sub cboDocNo_DropDownClosed(sender As Object, e As System.EventArgs) Handles cboDocNo.DropDownClosed
        Call Binddata(grdDetails, (New classDebitNoteExport).GetDocDetails(clsConfig.IsNull(cboDocNo.ComboBox.SelectedValue, 0), ""))
        Call SumGrid(grdDetails.DataSource)
    End Sub

    Private Sub ToolStrip1_ItemClicked(sender As System.Object, e As System.Windows.Forms.ToolStripItemClickedEventArgs) Handles ToolStrip1.ItemClicked

    End Sub

    Private Sub btnNew_Click(sender As System.Object, e As System.EventArgs) Handles btnNew.Click
        Call GenCombo()
        Call GenComboDocNo()
        Call InitControl()

    End Sub

    Private Sub btnSearchDFNo_Click(sender As System.Object, e As System.EventArgs) Handles btnSearchInvNo.Click
        Dim frm As New frmInvoiceExportSearch
        frm.ShowDialog(Me)
        Call btnNew_Click(sender, e)
        Me.Cursor = Cursors.WaitCursor
        If Not blnCancel Then
            header.h18_invno = frm.pInvNo
            header.h17_invid = frm.pInvID
        End If



        Me.Cursor = Cursors.Default
        frm.Dispose()
        'LoadDataInvNo()
    End Sub
    Public Overridable Sub SumGrid(ByVal dt As DataTable)
        If dt Is Nothing Then Exit Sub
        If dt.Rows.Count = 0 Then Exit Sub
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
    'Public Sub SumGrid(ByVal dt As DataTable)
    '    If dt Is Nothing Then Exit Sub
    '    Dim config As New clsConfig
    '    Dim dt1 As New DataTable
    '    dt1 = grdDetails.DataSource
    '    If dt1 Is Nothing Or dt1.Rows.Count = 0 Then Exit Sub
    '    Dim i As Integer = 0
    '    Dim dblGrossAmt As Double = 0
    '    Dim dblDiscAmt As Double = Val(txtDiscAmt.Text)
    '    Dim dblPreTaxAmt As Double = 0
    '    Dim dblVAT As Double = Val(txtVat.Text)
    '    Dim dblVATAmt As Double = 0
    '    Dim dblNetAmt As Double = 0
    '    If grdDetails.ColumnCount = 0 Then
    '        Exit Sub
    '    End If

    '    For i = 0 To dt1.Rows.Count - 1
    '        dblGrossAmt = dblGrossAmt + Math.Round(clsConfig.IsNull(dt1.Rows(i)("qty"), 0) * clsConfig.IsNull(dt1.Rows(i)("uprice"), 0), 2)
    '    Next


    '    dblPreTaxAmt = dblGrossAmt - Math.Round(dblDiscAmt, 2)
    '    dblVATAmt = Math.Round((dblPreTaxAmt * dblVAT) / 100, 2)
    '    dblNetAmt = dblPreTaxAmt + dblVATAmt

    '    txtGrossAmt.Text = FormatNumber(dblGrossAmt, 2, TriState.False, TriState.False, TriState.False)
    '    txtDiscAmt.Text = FormatNumber(dblDiscAmt, 2, TriState.False, TriState.False, TriState.False)
    '    txtPreTaxAmt.Text = FormatNumber(dblPreTaxAmt, 2, TriState.False, TriState.False, TriState.False)
    '    txtVat.Text = FormatNumber(dblVAT, 2, TriState.False, TriState.False, TriState.False)
    '    txtVatAmt.Text = FormatNumber(dblVATAmt, 2, TriState.False, TriState.False, TriState.False)
    '    txtNetAmt.Text = FormatNumber(clsConfig.IsNull(dblNetAmt, 0), 2, TriState.False, TriState.False, TriState.False)
    'End Sub

    Private Sub grdDetails_CellValidated(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles grdDetails.CellValidated
        'Call SumGrid(grdDetails.DataSource)
    End Sub

    Private Sub grdDetails_CellValueChanged(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles grdDetails.CellValueChanged
        If grdDetails.Columns(e.ColumnIndex).Name = "qty" Then
            grdDetails.CurrentRow.Cells("lineamt").Value = Math.Round(clsConfig.IsNull(grdDetails.CurrentRow.Cells("qty").Value, 0) * clsConfig.IsNull(grdDetails.CurrentRow.Cells("uprice").Value, 0), 2)
            'Call SumGrid(grdDetails.DataSource)
        End If
        If grdDetails.Columns(e.ColumnIndex).Name = "uprice" Then
            grdDetails.CurrentRow.Cells("lineamt").Value = Math.Round(clsConfig.IsNull(grdDetails.CurrentRow.Cells("qty").Value, 0) * clsConfig.IsNull(grdDetails.CurrentRow.Cells("uprice").Value, 0), 2)
            'Call SumGrid(grdDetails.DataSource)
        End If
        'If grdDetails.Rows.Count >= 1 Then
        Call SumGrid(grdDetails.DataSource)
        'End If


    End Sub

    Private Function Validate_InvNo(Optional ByVal StrInvno As String = "") As Boolean
        Dim objdb As New classDebitNoteExport
        Dim dt As DataTable = objdb.Validate_InvNo(StrInvno, clsUser.UserID)

        If dt.Rows.Count = 0 Then
            MessageBox.Show("Inv No .: " & StrInvno & "............   is Not Correct!!", "SyStem Messsage", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return False
        Else
            Return True
        End If


    End Function

    Private Sub btnSave_Click(sender As System.Object, e As System.EventArgs) Handles btnSave.Click

        If grdDetails.EditMode Then grdDetails.EndEdit()

        If Not CheckData() Then Exit Sub

        Call SaveData()

    End Sub

    Private Sub CheckGrid(ByRef DGV As DataGridView)
        If Not DGV.DataSource Is Nothing Then
            If DGV.Rows.Count > 0 And DGV.Focused Then
                'If DGV.CurrentCell.IsInEditMode Then
                Dim cell As DataGridViewCell = DGV.CurrentCell
                DGV.EndEdit(DataGridViewDataErrorContexts.Commit)
                DGV.CurrentCell = DGV.Rows(0).Cells(0)
                DGV.CurrentCell = cell
                'End If
            End If
        End If
    End Sub
    Private Function CheckData() As Boolean

        Dim clsconfig As New clsConfig
        Dim dt As DataTable = grdDetails.DataSource
        For Each dr As DataRow In dt.Rows
            If dr.RowState <> DataRowState.Deleted Then
                If (New clsConfig).IsNull(dr("currency"), "").ToString = "" Then
                    MessageBox.Show("ต้องมีสกุลเงิน", "System Meassge", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
                    Return False
                End If
                If (New clsConfig).IsNull(dr("exchange_rate"), 0) = 0 Then
                    MessageBox.Show("Exchange Rate ต้องไม่เท่ากับ 0", "System Meassge", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
                    Return False
                End If
                If (New clsConfig).IsNull(dr("currency"), "").ToString <> "THB" And (New clsConfig).IsNull(dr("exchange_rate"), 0) = 1 Then
                    MessageBox.Show("ถ้าสกุลเงินเป็นสกุลเงินต่างประเทศ เรทเงินต้องไม่ได้เท่ากับ 1", "System Meassge", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
                    Return False
                End If
            End If
        Next


        If rbRefInv.Checked Then 'Sitthana 20190823
            If Not Validate_InvNo(clsconfig.IsNull(cboinvno.Text, "")) Then
                MessageBox.Show("Please Select Invoice No.", "System Message!", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return False
            End If

            If cboinvno.Text.Trim = "" Then
                MessageBox.Show("Please Select Invoice No.", "System Message!", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return False
            End If
        Else
            cboinvno.Text = ""
        End If

        If cboCustomer.SelectedIndex = -1 Then
            MessageBox.Show("Please Select Customer", "System Message!", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return False
        End If

        If grdDetails.Rows.Count = 1 Then
            MessageBox.Show("Please Enter detail in datagrid", "System Message!", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return False
        End If

        If (New clsConfig).IsNull(cboSalesMan.SelectedValue, "") = "" Then
            ErrorProvider1.SetError(cboSalesMan, "Should Be Enter Sale Person" + vbCr + vbCr + "ต้องเลือก Sale Person ด้วยครับ")
            MessageBox.Show("Should Be Enter Sale Person" + vbCr + vbCr + "ต้องเลือก Sale Person ด้วยครับ", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
            Return False
        End If

        ErrorProvider1.Clear()
        Return True
    End Function

    Private Function SaveData() As Boolean
        If MessageBox.Show("Would you like to save ?", "System Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = DialogResult.No Then Return False
        Dim clsdbnote As New classDebitNoteExport

        Dim msgerr As String = ""
        Dim docid As Long = 0
        Dim docno As String = ""
        Dim dt As New DataTable
        Call grdDetails.CommitEdit(DataGridViewDataErrorContexts.Commit)
        dt = grdDetails.DataSource
        Call SumGrid(dt)

        Dim dv_add As New DataView(dt, "", "", DataViewRowState.Added)
        Dim dv_upd As New DataView(dt, "", "", DataViewRowState.ModifiedCurrent)
        Dim dv_del As New DataView(dt, "", "", DataViewRowState.Deleted)
        'header.h01_id_dbnote = 0
        header.h02_dbnote_no = Me.txtDbNoteNo.Text
        header.h03_dbnote_date = dtpDocDate.Value.ToString("yyyyMMdd")
        header.h04_dbnote_type_id = 0
        header.h05_present_status = ""
        header.h06_approval_status = ""
        header.h07_posting_status = ""
        header.h08_dbnote_reqno = ""
        'header.h09_dbnote_reason1 = clsConfig.IsNull(cboReason.SelectedValue, 0)  'Comment By Sitthana 20190822
        'header.h10_dbnote_reason2 = clsConfig.IsNull(cboReason2.SelectedValue, 0) 'Comment By Sitthana 20190822
        'header.h11_dbnote_reason3 = clsConfig.IsNull(cboReason3.SelectedValue, 0) 'Comment By Sitthana 20190822
        header.h12_custcd = clsConfig.IsNull(cboCustomer.SelectedValue, "")
        header.h13_source_docno = ""
        header.h14_source_docdate = "19000101"
        header.h15_source_refno = ""
        header.h16_source_doctype = ""

        'header.h17_invid = clsConfig.IsNull(cboInvNo.SelectedValue.ToString.Substring(1), 0)
        'header.h17_invid = clsConfig.IsNull(cboInvNo.SelectedValue.ToString, 0)

        header.h18_invno = clsConfig.IsNull(cboinvno.Text, "")
        'header.h19_invtype = clsConfig.IsNull(cboInvNo.SelectedValue.ToString.Substring(0, 1), "")
        header.h19_invtype = "E" 'clsConfig.IsNull(cboinvno.Text.ToString.Substring(0, 1), "") 'Comment by Sitthana 20190823
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
            Call Binddata(grdDetails, (New classDebitNoteExport).GetDocDetails(clsConfig.IsNull(header.h01_id_dbnote, 0), ""))
            Call SumGrid(grdDetails.DataSource)
            cboDocNo.Text = txtDbNoteNo.Text
            MessageBox.Show("Save is Complete!", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
            SaveData = True
        Else
            MessageBox.Show(msgerr, "System Message", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
            SaveData = False
        End If
    End Function

    Private Sub txtinvno_DropDownClosed(sender As Object, e As System.EventArgs) Handles cboinvno.DropDownClosed
        Call LoadDataInvNo()
    End Sub

    Private Sub txtinvno_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles cboinvno.KeyDown
        If e.KeyCode = Keys.Enter Then
            Call LoadDataInvNo()
        End If
    End Sub

    Private Sub LoadDataInvNo()
        Dim objdb As New classDebitNoteExport
        Dim dt As New DataTable
        Dim clsconfig As New clsConfig

        If clsconfig.IsNull(cboinvno.SelectedValue, 0) = 0 Then Exit Sub

        dt = objdb.GetInvExportDet("", clsconfig.IsNull(cboinvno.SelectedValue, 0)) 'Enable By Neung 20171207

        'dt = objdb.GetInvExportDet(clsconfig.IsNull(cboinvno.Text, ""), clsconfig.IsNull(cboinvno.SelectedValue, 0)) 'Disible By Neung 20171207

        If dt.Rows.Count > 0 Then Call BinddataInvNo(dt)

    End Sub

    Private Sub BinddataInvNo(ByVal dt As DataTable)
        cboCustomer.SelectedValue = dt.Rows(0)("custcd")

    End Sub

    Private Sub txtinvno_TextChanged(sender As System.Object, e As System.EventArgs)

    End Sub

    Private Sub btnPrint_Click(sender As System.Object, e As System.EventArgs) Handles btnPrint.Click
        If header.h01_id_dbnote = 0 Then Exit Sub

        Const rptFileName = "rptDBNoteARExport.rpt"
        If Not clsConfig.CheckReport(clsUser.ReportPath, rptFileName) Then Exit Sub
        Dim clsConn As New classConnection
        Dim frm As New frmReport
        Dim rpt As New CrystalDecisions.CrystalReports.Engine.ReportDocument
        Me.Cursor = Cursors.WaitCursor
        rpt.Load(clsUser.ReportPath & rptFileName)
        rpt.DataSourceConnections.Item(0).SetConnection(clsConn.servername, clsConn.database, False)
        rpt.DataSourceConnections.Item(0).SetLogon(clsConn.Userid, clsConn.Password)

        rpt.VerifyDatabase()
        rpt.SetParameterValue("@id_dbnote", header.h01_id_dbnote)

        rpt.PrintOptions.PaperSize = CrystalDecisions.Shared.PaperSize.PaperLetter
        rpt.PrintOptions.PaperOrientation = CrystalDecisions.Shared.PaperOrientation.Portrait
        rpt.PrintOptions.PaperSource = CrystalDecisions.Shared.PaperSource.Auto

        frm.Title = "Debit Note"
        'frm.CRViewer.DisplayGroupTree = False
        frm.CRViewer.ReportSource = rpt
        frm.MdiParent = Me.ParentForm
        frm.Show()
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub btnApprove_Click(sender As System.Object, e As System.EventArgs) Handles btnApprove.Click
        ApproveData()
    End Sub

    Public Overridable Sub ApproveData()
        'If Not CanSave() Then Exit Sub
        If MessageBox.Show("Would you like to approve ?", "System Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = DialogResult.Yes Then Call (New classDebitNoteExport).Approve(header.h01_id_dbnote, Me.UserInfo.UserID)
        txtpresent_status.Text = "APPROVED"
    End Sub

    Private Sub btnCancel_Click(sender As System.Object, e As System.EventArgs) Handles btnCancel.Click
        Call CancelData()
    End Sub
    Private Sub CancelData()
        'If Not CanSave() Then Exit Sub
        If MessageBox.Show("Would you like to cancel ?", "System Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = DialogResult.Yes Then Call (New classDebitNoteExport).Cancel(header.h01_id_dbnote, Me.UserInfo.UserID)
        txtpresent_status.Text = "CANCELLED"
    End Sub

    Private Sub btnMinimized_Click(sender As System.Object, e As System.EventArgs) Handles btnMinimized.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub btnExit_Click(sender As System.Object, e As System.EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnLoadINV_Click(sender As System.Object, e As System.EventArgs) Handles btnLoadINV.Click
        If cboinvno.Text.Trim = "" Then Exit Sub
        'Call LoadDataInvNo()

        Call AddData(grdDetails.DataSource, (New classDebitNoteExport).GetInvExportDet("", cboinvno.SelectedValue))
    End Sub
    Private Function CheckDuplicate(ByVal dt1 As DataTable, ByVal Intinvdetid As Nullable(Of Int64)) As Boolean
        If dt1.Rows.Count > 0 Then
            Dim i As Integer = 0
            For i = 0 To dt1.Rows.Count - 1
                If dt1.Rows(i).RowState <> DataRowState.Deleted Then
                    If clsConfig.IsNull(dt1.Rows(i)("invdetid"), 0) = Intinvdetid Then Return True
                End If
            Next
        End If
        Return False
    End Function


    Private Sub AddData(ByRef source As DataTable, ByVal dt As DataTable)
        Dim dr As DataRow
        Dim rowNo As Integer = 0
        Dim colNo As Integer = 0
        For rowNo = 0 To dt.Rows.Count - 1
            If Not CheckDuplicate(source, dt.Rows(rowNo)("invdetid")) Then
                dr = source.NewRow()
                For colNo = 0 To source.Columns.Count - 1
                    'If Not CheckDuplicate(source, dt.Rows(row)("invdetid")) Then
                    dr("invord") = dt.Rows(rowNo)("invord")
                    dr("sono") = dt.Rows(rowNo)("sono")
                    dr("sonoid") = dt.Rows(rowNo)("sonoid")
                    dr("stk_in_no") = dt.Rows(rowNo)("stk_in_no")
                    dr("design_no") = dt.Rows(rowNo)("design_no")
                    dr("qty") = dt.Rows(rowNo)("qty")
                    dr("uprice") = dt.Rows(rowNo)("uprice")
                    dr("lineamt") = dt.Rows(rowNo)("lineamt")

                    dr("pono") = dt.Rows(rowNo)("pono")
                    'dr("stk_in_no") = dt.Rows(row)("stk_in_no")

                    dr("invdetid") = dt.Rows(rowNo)("invdetid")
                    dr("currency") = dt.Rows(rowNo)("currency")
                Next

                source.Rows.Add(dr)
            End If
        Next

        If dt.Rows.Count > 0 Then Call BinddataInvNo(dt)

        Call SumGrid(grdDetails.DataSource)
    End Sub

    Private Sub enanbledInvObj(pEnabled As Boolean)
        'Sitthana 20190822
        cboinvno.Enabled = pEnabled
        btnSearchInvNo.Enabled = pEnabled
        btnLoadINV.Enabled = pEnabled
    End Sub
    Private Sub rbRefInv_CheckedChanged(sender As Object, e As EventArgs) Handles rbRefInv.CheckedChanged
        'Sitthana 20190822
        enanbledInvObj(True)
    End Sub
    Private Sub rbNotRefInv_CheckedChanged(sender As Object, e As EventArgs) Handles rbNotRefInv.CheckedChanged
        'Sitthana 20190822
        enanbledInvObj(False)
        cboinvno.SelectedIndex = -1
    End Sub

    Private Sub grdDetails_DataError(sender As Object, e As DataGridViewDataErrorEventArgs) Handles grdDetails.DataError
        'Sitthana 20190823

        Select Case e.Context
            Case DataGridViewDataErrorContexts.Commit
                MessageBox.Show("Commit error", "ข้อผิดพลาด", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Case DataGridViewDataErrorContexts.Parsing
                MessageBox.Show("parsing error", "ข้อผิดพลาด", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Case DataGridViewDataErrorContexts.CurrentCellChange
                MessageBox.Show("Cell change", "ข้อผิดพลาด", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Case DataGridViewDataErrorContexts.LeaveControl
                MessageBox.Show("leave control error", "ข้อผิดพลาด", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Case 768
                MessageBox.Show(grdDetails.Columns(e.ColumnIndex).HeaderText & " not numberic", "ข้อผิดพลาด", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Select

        If (TypeOf (e.Exception) Is ConstraintException) Then
            Dim view As DataGridView = CType(sender, DataGridView)
            view.Rows(e.RowIndex).ErrorText = "an error"
            view.Rows(e.RowIndex).Cells(e.ColumnIndex) _
                .ErrorText = "an error"

            e.ThrowException = False
        End If
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