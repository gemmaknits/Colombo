Imports System.Data.Sql
Imports System.Data.SqlClient
Imports System.Text
Imports System

Public Class formSupplierCreate

    Dim oSuppliers As New classSuppliers
    Dim oConn As New classConnection
    Dim connStr As String = oConn.connection
    Dim _UserEvents As String = "ADD"
    '  Dim _UserEvents As String = "ADD"
    Dim dtSuppliers As New DataTable
    Dim bsSuppliers As New BindingSource
    Dim drvSuppliers As DataRowView
    Dim blnCancel As Boolean = False

    Dim clsUser As New classUserInfo
    Dim oConfig As New clsConfig

    Public Property pUserEvents As String
        Get
            pUserEvents = _UserEvents
        End Get
        Set(ByVal Newvalue As String)
            _UserEvents = Newvalue
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

    Private Sub formSupplierCreate_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim ds As New DataSet
        Dim da As New SqlDataAdapter("select * from country where ctry <> '00'", connStr)
        da.Fill(ds, "country")
        da.Dispose()
        da = New SqlDataAdapter("select * from paymode", connStr)
        da.Fill(ds, "paymode")
        da.Dispose()
        da = New SqlDataAdapter("p_suppliers_select_by_code", connStr)
        da.Fill(ds, "suppliers")
        Me.cboCtry.DataSource = ds.Tables("country")
        Me.cboCtry.DisplayMember = "name"
        Me.cboCtry.ValueMember = "ctry"
        Me.cboPayModeCd.DataSource = ds.Tables("paymode")
        Me.cboPayModeCd.DisplayMember = "paymodedesc"
        Me.cboPayModeCd.ValueMember = "paymodecd"
        Me.cboCrTerms.Items.Add("CASH")
        Me.cboCrTerms.Items.Add("CREDIT")

        _UserEvents = "ADD"
        BindData("")

    End Sub

    Private Function SqlStr(ByVal strType As String) As SqlCommand
        Dim conn As New SqlConnection(oConn.connection())
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure
        If strType = "INS" Then
            comm.CommandText = "p_suppliers_insert"
        Else
            comm.CommandText = "p_suppliers_update"
        End If
        comm.Parameters.AddWithValue("@suppcd", Me.txtSuppcd.Text.Trim)
        comm.Parameters.AddWithValue("@name", Me.txtName.Text.Trim)
        comm.Parameters.AddWithValue("@namet", Me.txtNamet.Text.Trim)
        comm.Parameters.AddWithValue("@addr1", Me.txtaddr1.Text.Trim)
        comm.Parameters.AddWithValue("@addr2", Me.txtAddr2.Text.Trim)
        comm.Parameters.AddWithValue("@addr3", Me.txtAddr3.Text.Trim)
        comm.Parameters.AddWithValue("@addr1t", Me.txtAddrt1.Text.Trim)
        comm.Parameters.AddWithValue("@addr2t", Me.txtAddrt2.Text.Trim)
        comm.Parameters.AddWithValue("@addr3t", Me.txtAddrt3.Text.Trim)
        comm.Parameters.AddWithValue("@city", Me.txtCity.Text.Trim)
        comm.Parameters.AddWithValue("@ctry", Me.cboCtry.SelectedValue)
        comm.Parameters.AddWithValue("@tel", Me.txtTel.Text.Trim)
        comm.Parameters.AddWithValue("@fax", Me.txtFax.Text.Trim)
        comm.Parameters.AddWithValue("@email", Me.txtEmail.Text.Trim)
        comm.Parameters.AddWithValue("@contact", Me.txtContact.Text.Trim)
        comm.Parameters.AddWithValue("@dyer", IIf(chkDyer.Checked, "1", "0"))
        comm.Parameters.AddWithValue("@scalloper", 0)
        comm.Parameters.AddWithValue("@greige", 0)
        comm.Parameters.AddWithValue("@altcode", "")
        comm.Parameters.AddWithValue("@abbrev", Me.txtAbbrev.Text)
        comm.Parameters.AddWithValue("@abbrev2", Me.txtAbbrev2.Text)
        comm.Parameters.AddWithValue("@crdays", Val(Me.txtCrDays.Text.Trim))
        comm.Parameters.AddWithValue("@crterms", Me.cboCrTerms.Text.Trim)
        comm.Parameters.AddWithValue("@paymodecd", IIf(cboPayModeCd.SelectedIndex <= 0, "", Me.cboPayModeCd.SelectedValue))
        comm.Parameters.AddWithValue("@internal", IIf(chkInternal.Checked, "1", "0"))
        comm.Parameters.AddWithValue("@vatregno", Me.txtvatregno.Text.Trim)
        comm.Parameters.AddWithValue("@supplier_id", txtSupplierId.Text)
        SqlStr = comm
    End Function
    Private Function SaveData() As Boolean
        Dim msgerr As String = ""
        drvSuppliers = CType(bsSuppliers.Current, DataRowView)

        If oSuppliers.updateSuppliersRecord(_UserEvents, drvSuppliers, msgerr, clsUser.UserID) Then
            _UserEvents = "EDIT"
            txtSuppcd.Text = drvSuppliers.Row("suppcd")
            MessageBox.Show("บันทึกสำเร็จ" & txtSuppcd.Text.Trim, "System Message", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)

            SaveData = True
        Else
            MessageBox.Show(msgerr, "System Message", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
            SaveData = False
        End If

    End Function
    Private Function CheckData() As Boolean
        Dim result As Boolean = True
        Dim MessageError As String = ""

        drvSuppliers = CType(bsSuppliers.Current, DataRowView)

        'If (New clsConfig).IsNull(drvJob.Row("curr"), "").ToString.Trim <> "THB" And clsConfig.IsNull(drvJob.Row("exrt"), 0) = 1 Then
        '    MessageError &= "ถ้าสกุลเงินเป็นสกุลเงินต่างประเทศ เรทเงินต้องไม่ได้เท่ากับ 1" & vbCrLf
        '    eptxtrate.SetError(Me.txtrate, "ถ้าสกุลเงินเป็นสกุลเงินต่างประเทศ เรทเงินต้องไม่ได้เท่ากับ 1" & vbCrLf & "If Currency equals foreigner then exchange rate not equals one")
        '    result = False
        'Else
        '    eptxtrate.Clear()
        'End If

        If oConfig.IsNull(drvSuppliers.Row("ctry"), "") = "" Then
            MessageError &= "ยังไม่ได้เลือกประเทศนะคะ :)" & vbCrLf
            Me.ErrorProvider1.SetError(Me.cboCtry, "ยังไม่ได้เลือกประเทศนะคะ :)")
            result = False
        Else
            ErrorProvider1.Clear()
        End If

        'If clsConfig.IsNull(drvJob.Row("empcd"), "") = "" Then
        '    MessageError &= "ยังไม่ได้เลือก Person Request" & vbCrLf
        '    'MessageBox.Show("ต้องมี Person Request", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
        '    epcomboEmp.SetError(Me.comboEmp, "Select person who made the request..")
        '    result = False
        'Else
        '    epcomboEmp.Clear()
        'End If

        'If clsConfig.IsNull(drvJob.Row("curr"), "") = "" Then 'As String
        '    MessageError &= "ยังไม่ได้เลือก currency" & vbCrLf
        '    'MessageBox.Show("ต้องมี currency", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
        '    epcboCurrency.SetError(Me.cboCurrency, "Select currency..")
        '    result = False
        'Else
        '    epcboCurrency.Clear()
        'End If

        'If clsConfig.IsNull(drvJob.Row("deptcd"), "") = "" Then
        '    MessageError &= "ยังไม่ได้เลือก Department" & vbCrLf
        '    ' MessageBox.Show("ต้องมี Dept", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
        '    epcboDept.SetError(Me.cboDept, "Select Dept..")
        '    result = False
        'Else
        '    epcboDept.Clear()
        'End If

        'If (New clsConfig).IsNull(drvJob.Row("ap_payment_term_id"), 0) = 0 Then
        '    MessageError &= "ยังไม่ได้เลือก Payment Term" & vbCrLf
        '    'MessageBox.Show("ต้องมี Payment Term", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
        '    epcboPaymentTerm.SetError(Me.cboPaymentTerm, "Select Payment Term")
        '    result = False
        'Else
        '    epcboPaymentTerm.Clear()
        'End If

        'If clsConfig.IsNull(drvJob.Row("po_line_types_id"), 0) = 0 Then
        '    MessageError &= "ยังไม่ได้เลือก Line Type" & vbCrLf
        '    'MessageBox.Show("ต้องมี Line Type", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
        '    epmcboPoLineType.SetError(Me.mcboPoLineType, "Select Line Type")
        '    result = False
        'Else
        '    epmcboPoLineType.Clear()
        'End If

        'For Each dr As DataRow In dtJobDet.Rows
        '    If dr.RowState <> DataRowState.Deleted Then

        '        If Not (New classPurchaseNewEdit).ValidateItcd(StrItcd:=clsConfig.IsNull(dr("itcd"), "")) Then
        '            MessageError &= "รายการที่ " & (dtJobDet.Rows.IndexOf(dr) + 1).ToString.Trim & " " & "Item No ไม่ถูกต้อง" & vbCrLf
        '            ' MessageBox.Show("ไม่พบ Item Master ในระบบ", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
        '            result = False
        '        End If

        '        If clsConfig.IsNull(dr("uom"), "") = "" Then
        '            MessageError &= "รายการที่ " & (dtJobDet.Rows.IndexOf(dr) + 1).ToString.Trim & " " & " ต้องมี UOM" & vbCrLf

        '            'MessageBox.Show("ต้องมี UOM", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
        '            result = False
        '        End If

        '        If clsConfig.IsNull(dr("rcv_warehouse_id"), 0) = 0 Then
        '            MessageError &= "รายการที่ " & (dtJobDet.Rows.IndexOf(dr) + 1).ToString.Trim & " " & " ต้องมี W/H" & vbCrLf

        '            ' MessageBox.Show("ต้องมี W/H", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
        '            result = False
        '        End If

        '        If clsConfig.IsNull(dr("qty"), 0) = 0 Then
        '            MessageError &= "รายการที่ " & (dtJobDet.Rows.IndexOf(dr) + 1).ToString.Trim & " " & "ต้องมี Qty มากกว่า 0" & vbCrLf

        '            ' MessageBox.Show("ต้องมี Qty มากกว่า 0", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
        '            result = False
        '        End If
        '    End If
        'Next

        If result = False Then
            MessageBox.Show(MessageError, "System Message", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
        End If

        Return result
    End Function
    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Me.Validate()
        bsSuppliers.EndEdit()

        blnCancel = False

        Dim result As System.Windows.Forms.DialogResult
        result = MessageBox.Show("Would you like to save ?" & vbCrLf &
        IIf(IIf(txtSuppcd.Text.Trim.Length = 0, txtSuppcd.Text.Trim, txtSuppcd.Text.Trim).ToString.Trim.Length = 0, "** ถ้าไม่ใส่ Supplier Code. ระบบจะรันให้อัติโนมัติ **", "Supplier No. = '" & IIf(txtSuppcd.Text.Trim.Length = 0, txtSuppcd.Text.Trim, txtSuppcd.Text.Trim) & "'"),
        "System Message", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button3)

        If result = System.Windows.Forms.DialogResult.Cancel Then blnCancel = True
        If result <> System.Windows.Forms.DialogResult.Yes Then Exit Sub

        If Not CheckData() Then Exit Sub

        Me.Cursor = Cursors.WaitCursor
        If SaveData() Then
            Dim pSuppcd As String = txtSuppcd.Text.Trim
            Call BindData(pSuppcd)
        End If
        Me.Cursor = Cursors.Default
    End Sub


    Private Function SearchData(ByVal strSearch As String, ByRef dt As DataTable) As Boolean
        Dim da As New SqlDataAdapter("exec dbo.p_suppliers_select '" & strSearch & "'", connStr)
        da.Fill(dt)
        If dt.Rows.Count > 0 Then
            SearchData = True
        Else
            SearchData = False
        End If
    End Function

    Private Sub BindData(ByVal dt As DataTable, ByVal r As Long)
        Me.txtSuppcd.Text = dt.Rows(r).Item("Suppcd").ToString.Trim
        Me.txtName.Text = dt.Rows(r).Item("Name").ToString.Trim
        Me.txtNamet.Text = dt.Rows(r).Item("Namet").ToString.Trim
        Me.txtAbbrev.Text = dt.Rows(r).Item("Abbrev").ToString.Trim
        Me.txtAbbrev2.Text = dt.Rows(r).Item("Abbrev2").ToString.Trim
        Me.txtNamet.Text = dt.Rows(r).Item("Namet").ToString.Trim
        Me.txtaddr1.Text = dt.Rows(r).Item("Addr1").ToString.Trim
        Me.txtAddr2.Text = dt.Rows(r).Item("Addr2").ToString.Trim
        Me.txtAddr3.Text = dt.Rows(r).Item("Addr3").ToString.Trim
        Me.txtAddrt1.Text = dt.Rows(r).Item("Addr1t").ToString.Trim
        Me.txtAddrt2.Text = dt.Rows(r).Item("Addr2t").ToString.Trim
        Me.txtAddrt3.Text = dt.Rows(r).Item("Addr3t").ToString.Trim
        Me.txtCity.Text = dt.Rows(r).Item("City").ToString.Trim
        Me.txtEmail.Text = dt.Rows(r).Item("Email").ToString.Trim
        Me.txtTel.Text = dt.Rows(r).Item("Tel").ToString.Trim
        Me.txtFax.Text = dt.Rows(r).Item("Fax").ToString.Trim
        Me.txtContact.Text = dt.Rows(r).Item("Contact").ToString.Trim
        Me.txtCrDays.Text = dt.Rows(r).Item("CrDays").ToString.Trim
        Me.cboCrTerms.Text = dt.Rows(r).Item("CrTerms").ToString.Trim
        Me.cboPayModeCd.SelectedValue = dt.Rows(r).Item("Paymodecd").ToString.Trim
        Me.cboCtry.SelectedValue = dt.Rows(r).Item("Ctry").ToString.Trim
        Me.chkDyer.Checked = CBool(dt.Rows(r).Item("dyer"))
        Me.chkInternal.Checked = CBool(dt.Rows(r).Item("internal"))
        Me.txtvatregno.Text = dt.Rows(r).Item("vatregno").ToString.Trim
        Me.txtSupplierId.Text = dt.Rows(r).Item("supplier_id").ToString.Trim
    End Sub

    Private Sub InitData()
        'Me.textSuppcd.Text = ""
        'Me.cboSuppliers.SelectedIndex = -1  'Sitthana 20210521 (Delete Combo Box)
        Me.txtName.Text = ""
        Me.txtNamet.Text = ""
        Me.txtAbbrev.Text = ""
        Me.txtAbbrev2.Text = ""
        Me.txtNamet.Text = ""
        Me.txtaddr1.Text = ""
        Me.txtAddr2.Text = ""
        Me.txtAddr3.Text = ""
        Me.txtAddrt1.Text = ""
        Me.txtAddrt2.Text = ""
        Me.txtAddrt3.Text = ""
        Me.txtCity.Text = ""
        Me.txtEmail.Text = ""
        txtEmailCC.Text = ""
        Me.txtTel.Text = ""
        Me.txtFax.Text = ""
        Me.txtContact.Text = ""
        Me.txtCrDays.Text = ""
        Me.cboCrTerms.Text = ""
        Me.cboPayModeCd.SelectedValue = ""
        Me.cboCtry.SelectedValue = ""
        Me.txtvatregno.Text = ""
        Me.txtSupplierId.Text = ""
        Me.chkDyer.Checked = False
        Me.chkInternal.Checked = False
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    'Private Sub cboSuppliers_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    If IsDBNull(cboSuppliers.DataSource) Then Exit Sub
    '    If Me.cboSuppliers.SelectedIndex < 0 Then Exit Sub

    '    textSuppcd.Text = Me.cboSuppliers.SelectedValue.ToString.Trim
    '    textSuppcd_LostFocus(sender, e)
    'End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrint.Click
        Dim clsConfig As New clsConfig
        Const rptFileName = "rptMasterSupplier.rpt"
        'Const rptFileName = "rptSupplierMaster.rpt"
        If Not clsConfig.CheckReport(clsUser.ReportPath, rptFileName) Then Exit Sub
        Dim frm As New frmReport
        Dim rpt As New CrystalDecisions.CrystalReports.Engine.ReportDocument
        Me.Cursor = Cursors.WaitCursor

        rpt.Load(clsUser.ReportPath & rptFileName)
        rpt.DataSourceConnections.Item(0).SetConnection(oConn.servername, oConn.database, False)
        rpt.DataSourceConnections.Item(0).SetLogon(oConn.Userid, oConn.Password)
        rpt.VerifyDatabase()
        'rpt.SetParameterValue("@suppcd", "")
        '/rpt.SetDataSource(ds.Tables("Tblprint"))

        rpt.PrintOptions.PaperSize = CrystalDecisions.Shared.PaperSize.PaperA4
        'rpt.PrintOptions.PaperOrientation = CrystalDecisions.Shared.PaperOrientation.Portrait 'Sitthana 20191128
        rpt.PrintOptions.PaperSource = CrystalDecisions.Shared.PaperSource.Auto

        frm.Title = "Supplier Master"
        frm.CRViewer.ReportSource = rpt
        frm.MdiParent = Me.MdiParent
        frm.Show()
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub btnNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNew.Click
        _UserEvents = "ADD"
        Call BindData("")
    End Sub
    Public Sub ClearDataBindings()
        Dim obj As Control
        For Each obj In Me.Controls
            Call ClearControlBindings(obj)
        Next
    End Sub

    Private Sub ClearControlBindings(ByVal obj As Control)
        obj.DataBindings.Clear()
        If TypeOf obj Is TabControl Or TypeOf obj Is TabPage Or TypeOf obj Is GroupBox Then
            Dim obj2 As Control
            For Each obj2 In obj.Controls
                Call ClearControlBindings(obj2)
            Next
        End If
    End Sub
    Private Sub BindData(ByVal pSuppcd As String)
        Call ClearDataBindings()

        Select Case pUserEvents.ToString.Trim
            Case "ADD"
                dtSuppliers = oSuppliers.selectSuppliersRecord("")
                If dtSuppliers.Rows.Count = 0 Then
                    Dim drNew As DataRow = dtSuppliers.NewRow
                    drNew("Suppcd") = pSuppcd 'ปกติ USer พิมพ์รหัสแล้ว Enter
                    drNew("dyer") = False
                    drNew("internal") = False
                    dtSuppliers.Rows.Add(drNew)
                End If
            Case "EDIT"
                dtSuppliers = oSuppliers.selectSuppliersRecord(pSuppcd)
        End Select

        bsSuppliers.DataSource = dtSuppliers
        bsSuppliers.MoveFirst()
        drvSuppliers = CType(bsSuppliers.Current, DataRowView)

        txtSupplierId.DataBindings.Add("text", bsSuppliers, "supplier_id")
        txtSuppcd.DataBindings.Add("text", bsSuppliers, "Suppcd")
        txtName.DataBindings.Add("text", bsSuppliers, "Name")
        txtNamet.DataBindings.Add("text", bsSuppliers, "Namet")
        txtAbbrev.DataBindings.Add("text", bsSuppliers, "Abbrev")
        txtAbbrev2.DataBindings.Add("text", bsSuppliers, "Abbrev2")
        txtaddr1.DataBindings.Add("text", bsSuppliers, "Addr1")
        txtAddr2.DataBindings.Add("text", bsSuppliers, "Addr2")
        txtAddr3.DataBindings.Add("text", bsSuppliers, "Addr3")
        txtAddrt1.DataBindings.Add("text", bsSuppliers, "Addr1t")
        txtAddrt2.DataBindings.Add("text", bsSuppliers, "Addr2t")
        txtAddrt3.DataBindings.Add("text", bsSuppliers, "Addr3t")
        txtCity.DataBindings.Add("text", bsSuppliers, "City")
        txtEmail.DataBindings.Add("text", bsSuppliers, "Email")
        txtEmailCC.DataBindings.Add("text", bsSuppliers, "email_cc")
        txtTel.DataBindings.Add("text", bsSuppliers, "Tel")
        txtFax.DataBindings.Add("text", bsSuppliers, "Fax")
        txtContact.DataBindings.Add("text", bsSuppliers, "Contact")
        txtCrDays.DataBindings.Add("text", bsSuppliers, "CrDays")
        cboCrTerms.DataBindings.Add("selectedvalue", bsSuppliers, "CrTerms")
        cboPayModeCd.DataBindings.Add("selectedvalue", bsSuppliers, "Paymodecd")
        cboCtry.DataBindings.Add("selectedvalue", bsSuppliers, "Ctry")
        chkDyer.DataBindings.Add("Checked", bsSuppliers, "dyer")
        chkInternal.DataBindings.Add("Checked", bsSuppliers, "internal")
        txtvatregno.DataBindings.Add("text", bsSuppliers, "vatregno")
    End Sub

    Private Sub btnGetSuppCd_Click(sender As Object, e As EventArgs) Handles btnGetSuppCd.Click
        Dim f As New Classes.formSearchSupplier
        Dim drv As DataRowView
        Dim SearchResult As New Classes.SearchFormResult
        ' pass nothing to use default connection string inside the class or pass your connection object if need to use different from default.
        f.setConnectionString((New classConnection).getSQLConnection())
        SearchResult = f.ShowSuppliers()
        f.Close()
        f.Dispose()
        drv = SearchResult.ResultRowView
        If SearchResult.ButtonClicked = "OK" Then
            drv = SearchResult.ResultRowView
            txtSuppcd.Text = drv.Item("suppcd")
            _UserEvents = "EDIT"
            Call BindData(txtSuppcd.Text.Trim)
        End If
    End Sub

    Private Sub txtSuppcd_KeyDown(sender As Object, e As KeyEventArgs) Handles txtSuppcd.KeyDown
        'If e.KeyCode = Keys.Enter Then
        '    _UserEvents = "EDIT"
        '    Call BindData(txtSuppcd.Text.Trim)
        'End If

        If e.KeyCode = Keys.Enter Then
            Dim pSuppcd As String = txtSuppcd.Text.Trim
            Dim dt As New DataTable
            dt = oSuppliers.selectSuppliersRecord(pSuppcd)
            If dt.Rows.Count > 0 Then
                _UserEvents = "EDIT"
            Else
                _UserEvents = "ADD"
            End If
            Call BindData(txtSuppcd.Text.Trim)
        End If
    End Sub
End Class