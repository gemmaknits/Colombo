Public Class frmHangerOutBarcode
    Dim clsuser As New classUserInfo
    Dim blnCancel As Boolean

    Public dtCboCustomer As New DataTable
    Public bsCboCustomer As New BindingSource

    Public dtcboDocType As New DataTable
    Public bscboDocType As New BindingSource

    Public dtcboEmp As New DataTable
    Public bscboEmp As New BindingSource

    Dim dtHangerOutBarcodeNew As New DataTable
    Dim bsHangerOutBarcodeNew As New BindingSource

    Dim dtHangerOutNew As New DataTable
    Dim bsHangerOutNew As New BindingSource

    Dim dtMtlWarehouse As New DataTable
    Dim bsMtlWarehouse As New BindingSource
    Dim dtMtlSubInventory As New DataTable
    Dim bsMtlSubInventory As New BindingSource
    Dim dtmtlLocations As New DataTable
    Dim bsMtlLocations As New BindingSource

    Public Property Userinfo() As classUserInfo
        Get
            Userinfo = clsuser
        End Get
        Set(ByVal newvalue As classUserInfo)
            clsuser = newvalue
        End Set
    End Property

    Private Sub txtRollNoD_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles txtRollNoD.KeyDown
        If e.KeyCode = Keys.Enter Then
            dtHangerOutBarcodeNew = (New classHangerOutBarcode).GetHanger(StrRollNoD:=txtRollNoD.Text.Trim)
            bsHangerOutBarcodeNew.DataSource = dtHangerOutBarcodeNew
            bsHangerOutBarcodeNew.MoveFirst()

            Call AddRollNo()
            txtRollNoD.Clear() ' = ""
            txtRollNoD.Focus()
        End If
    End Sub

    Private Sub AddRollNo()
        If dtHangerOutBarcodeNew.Rows.Count > 0 Then
            Dim config As New clsConfig
            Dim dr As DataRow
            Dim msg As String = ""
            Dim i As Integer = 0
            Dim j As Integer = 0
            For i = 0 To dtHangerOutBarcodeNew.Rows.Count - 1

                If CheckDuplicateAndUpdateRecord(dtHangerOutBarcodeNew.Rows(i)("roll_no_d").ToString.Trim, dtHangerOutNew) Then Exit Sub
                dr = dtHangerOutNew.NewRow

                For j = 0 To dtHangerOutBarcodeNew.Columns.Count - 1
                    dr(dtHangerOutBarcodeNew.Columns(j).ColumnName.Trim) = dtHangerOutBarcodeNew.Rows(i)(dtHangerOutBarcodeNew.Columns(j).ColumnName.Trim)
                Next


                dtHangerOutNew.Rows.Add(dr)

            Next
        End If
        ' Call SumGrid()
    End Sub

    Private Function CheckDuplicateAndUpdateRecord(ByVal StrRollNoD As String, ByVal dt As DataTable) As Boolean
        If dt.Rows.Count > 0 Then
            Dim i As Integer = 0
            For i = 0 To dt.Rows.Count - 1
                If dt.Rows(i).RowState <> DataRowState.Deleted Then
                    If dt.Rows(i)("roll_no_d").ToString.Trim = StrRollNoD Then
                        If dt.Rows(i)("bal_kg") > dt.Rows(i)("kg") Then
                            dt.Rows(i)("kg") = dt.Rows(i)("kg") + 1
                        End If
                        Return True
                    End If

                End If
            Next
        End If
        Return False
    End Function

    Private Sub txtRollNoD_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtRollNoD.TextChanged

    End Sub

    Private Sub frmHangerOut_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized

        Call InitControl()

        Call GenComBo()

        Call InitDataBinding()

        Call LoadGrdDOutNewByOutno("N/A")
    End Sub

    Private Sub InitControl()
        Dim obj As Control
        For Each obj In Me.Controls
            Call SetControlValue(obj)
        Next
        Call EnabledControl(True)
        Call SetErrorProvider()

        ' txtOutno.Enabled = False
        ' dtpOutDt.Enabled = False
    End Sub


    Private Sub SetControlValue(ByVal Obj As Control)
        If TypeOf Obj Is TextBox Then
            Obj.Text = Obj.Tag

        End If
        If TypeOf Obj Is DateTimePicker Then
            Dim dtp As DateTimePicker = Obj
            dtp.Value = Now
            dtp.Checked = False
        End If
        If TypeOf Obj Is ComboBox Then
            Dim cbo As ComboBox = Obj
            cbo.SelectedIndex = -1
        End If
        If TypeOf Obj Is CheckBox Then
            Dim chk As CheckBox = Obj
            chk.Checked = False
            If chk.Name = "chkAutoCalculate" Then chk.Checked = True

        End If
        If TypeOf Obj Is TabControl Or TypeOf Obj Is TabPage Or TypeOf Obj Is GroupBox Then
            Dim obj2 As Control
            For Each obj2 In Obj.Controls
                Call SetControlValue(obj2)
            Next
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


    Private Sub SetErrorProvider()
        ErrorProvider1.Clear()
    End Sub

    Private Sub InitDataBinding()

        dtHangerOutBarcodeNew = (New classHangerOutBarcode).GetHanger(StrRollNoD:=txtRollNoD.Text.Trim)
        bsHangerOutBarcodeNew.DataSource = dtHangerOutBarcodeNew

        dtHangerOutNew = (New classHangerOutBarcode).GetGridHangerOutByOutNo(StrOutNo:=txtOutno.Text.Trim)
        bsHangerOutNew.DataSource = dtHangerOutNew

        Call BindingData() '
    End Sub

    Private Sub BindingData()
        Call ClearDataBindings()

        txtaddr1.DataBindings.Add("text", bsCboCustomer, "addr1")


    End Sub




    Private Sub GenComBo()

        dtCboCustomer = (New classDyedOutSample).GetComBoCustomer()
        bsCboCustomer.DataSource = dtCboCustomer
        cboCustomer.DataSource = bsCboCustomer
        cboCustomer.DisplayMember = "name"
        cboCustomer.ValueMember = "customer_id"

        dtcboDocType = (New classMaster).GetDocType
        bscboDocType.DataSource = dtcboDocType
        cboDocType.DataSource = bscboDocType
        cboDocType.DisplayMember = "name"
        cboDocType.ValueMember = "doctyp"
        cboDocType.SelectedValue = "0"

        'dtcboEmp = (New classMaster).comboEmployee(strUserID:=Userinfo.UserID) 'comment by sitthana 20190801
        dtcboEmp = (New classMaster).GetEmp 'Copy from frmDyedOutSample Sitthana 20190801
        bscboEmp.DataSource = dtcboEmp
        cboempcd.DataSource = bscboEmp
        cboempcd.DisplayMember = "empname" '"empname2" 'usewith comboEmployee
        cboempcd.ValueMember = "empcd"


    End Sub

    Private Sub LoadGrdDOutNewByOutno(ByVal StrOutno As String)

        Dim dt As DataTable = (New classHangerOutBarcode).GetGridHangerOutByOutNo(StrOutNo:=StrOutno)
        If dt.Rows.Count > 0 Then BindtxtDoutNew(dt)
        Call BindGrdDoutNew(dt)

    End Sub

    Private Sub BindtxtDoutNew(ByVal dt As DataTable)
        dtHangerOutNew = dt

        bsHangerOutNew.DataSource = dtHangerOutNew

    End Sub

    Private Sub BindGrdDoutNew(ByVal dt As DataTable)
        dtHangerOutNew = dt

        bsHangerOutNew.DataSource = dtHangerOutNew

        grdHanger.AutoGenerateColumns = False
        grdHanger.DataSource = bsHangerOutNew.DataSource

        Call BinddataTxnLines()
    End Sub


    Private Sub BinddataTxnLines()
        Call ClearDataBindings()

        txtOutno.DataBindings.Add("text", bsHangerOutNew, "outno")
        dtpOutDt.DataBindings.Add("text", bsHangerOutNew, "outdt")
        txtPackNo.DataBindings.Add("text", bsHangerOutNew, "packno")
        dtpPackdt.DataBindings.Add("text", bsHangerOutNew, "packdt")
        cboCustomer.DataBindings.Add("SelectedValue", bsHangerOutNew, "customer_id")
        cboDocType.DataBindings.Add("SelectedValue", bsHangerOutNew, "doctyp")
        cboempcd.DataBindings.Add("SelectedValue", bsHangerOutNew, "empcd")
        txtRemark.DataBindings.Add("text", bsHangerOutNew, "remark")

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

    Private Sub btnSearchCustomers_Click(sender As System.Object, e As System.EventArgs) Handles btnSearchCustomers.Click
        Dim frm As New frmSearchCustomers
        frm.ShowDialog(Me)
        Me.Cursor = Cursors.WaitCursor

        Dim dgvr As DataGridViewRow = frm.pDgvrData
        Dim dr As DataRow = frm.pdrdata

        cboCustomer.SelectedValue = frm.pCustomerID

        txtaddr1.Text = dr("addr1")
        Me.Cursor = Cursors.Default
        frm.Dispose()
    End Sub

    Private Sub txtDINNO_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles txtOutno.KeyDown
        If e.KeyCode = Keys.Enter Then
            dtHangerOutNew = (New classHangerOutBarcode).GetGridHangerOutByOutNo(txtOutno.Text.Trim)
            bsHangerOutNew.DataSource = dtHangerOutNew
            grdHanger.DataSource = bsHangerOutNew
        End If
    End Sub

    Private Sub txtDINNO_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtOutno.TextChanged

    End Sub

    Private Sub btnSave_Click(sender As System.Object, e As System.EventArgs) Handles btnSave.Click
        'Sitthana 20220624 Changed Windows.Forms.DialogResult To DialogResult
        Dim result As DialogResult ' Windows.Forms.DialogResult
        result = MessageBox.Show("Would you like to Save Hanger Out?", "System Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button3)
        If result <> DialogResult.Yes Then Exit Sub

        If Not CheckData() Then Exit Sub

        Call SaveHangerOut()
    End Sub

    Private Function CheckData() As Boolean

        '============= Check Slect row > 1 =============================
        Dim i As Integer = 0 'num select row
        For Each row As DataGridViewRow In grdHanger.Rows
            Dim chk As DataGridViewCheckBoxCell = row.Cells("grdHangerINSel")
            If row.Cells("grdHangerINSel").Value = True Then
                i = i + 1
            End If
        Next
        If i = 0 Then
            MsgBox("Must be select one roll or more then")
            Return False
        End If
        '===============================================================

        '--============= Check Data In Grid ============================
        For Each row As DataGridViewRow In grdHanger.Rows
            Dim chk As DataGridViewCheckBoxCell = row.Cells("grdHangerINSel")
            If row.Cells("grdHangerINSel").Value = True Then
                'If (New clsConfig).IsNull(row.Cells("grdHangerINMtlWareHouse").Value, 0) = 0 Then
                '    MessageBox.Show("ยังไมได้เลือก W/H ", "Syatem Message", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
                '    Return False
                'End If
                'If (New clsConfig).IsNull(row.Cells("grdHangerINMtlSubinventory").Value, 0) = 0 Then
                '    MessageBox.Show("ยังไมได้เลือก Sub ", "Syatem Message", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
                '    Return False
                'End If

                'If (New clsConfig).IsNull(row.Cells("grdHangerINMtlLocations").Value, 0) = 0 Then
                '    MessageBox.Show("ยังไมได้เลือก Loc ", "Syatem Message", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
                '    Return False
                'End If

                If (New clsConfig).IsNull(row.Cells("grdHangerINKg").Value, 0) = 0 Then
                    MessageBox.Show("ยังไมได้ใส่่ QTY ", "Syatem Message", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
                    Return False
                End If
            End If
        Next

        If (New clsConfig).IsNull(cboCustomer.SelectedValue, 0) = 0 Then
            MessageBox.Show("คุณยังไม่ได้เลือก ลูกค้า", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return False
            Exit Function
        End If

        If (New clsConfig).IsNull(cboempcd.SelectedValue, "") = "" Then
            MessageBox.Show("คุณยังไม่ได้เลือก ผู้ขอ", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return False
            Exit Function
        End If


        Return True
    End Function


    Private Function SaveHangerOut() As Boolean

        bsHangerOutNew.EndEdit()
        Dim dt As DataTable = bsHangerOutNew.DataSource
        Dim dv_add As New DataView(dt, "", "", DataViewRowState.Added)
        Dim dv_upd As New DataView(dt, "", "", DataViewRowState.ModifiedCurrent)
        Dim dv_del As New DataView(dt, "", "", DataViewRowState.Deleted)
        Dim msgerr As String = "'"

        Dim HOutheader As New classHangerOutBarcode.StrollsDOHeader

        HOutheader.h01_outno = txtOutno.Text.Trim
        HOutheader.h02_outdt = dtpOutDt.Value
        HOutheader.h03_doctyp = cboDocType.SelectedValue
        HOutheader.h56_packno = txtPackNo.Text.Trim
        HOutheader.h57_packdt = dtpPackdt.Value
        HOutheader.h58_remark = txtRemark.Text
        HOutheader.Int64CustomerID = cboCustomer.SelectedValue
        HOutheader.StrEmpcd = cboempcd.SelectedValue 'Request 

        If (New classHangerOutBarcode).SaveHangerOut(StrollsDOHeader:=HOutheader, DV_ADD:=dv_add, DV_UPD:=dv_upd, DV_DEL:=dv_del, Userinfo:=Userinfo, msgerr:=msgerr) Then
            txtOutno.Text = HOutheader.h01_outno
            dtHangerOutNew = (New classHangerOutBarcode).GetGridHangerOutByOutNo(txtOutno.Text.Trim)
            bsHangerOutNew.DataSource = dtHangerOutNew
            grdHanger.DataSource = bsHangerOutNew
            MessageBox.Show("บันทึกสำเร็จ", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
            SaveHangerOut = True
        Else
            MessageBox.Show(msgerr, "System Message", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
            SaveHangerOut = False
        End If

    End Function

    Private Sub grdHangerIN_CellContentClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles grdHanger.CellContentClick
        If grdHanger.CurrentCell.IsInEditMode Then grdHanger.EndEdit()
    End Sub

    Private Sub btnCancel_Click(sender As System.Object, e As System.EventArgs) Handles btnCancel.Click
        blnCancel = False
        'Sitthana 20220624 Changed Windows.Forms.DialogResult To DialogResult
        Dim result As DialogResult ' Windows.Forms.DialogResult
        result = MessageBox.Show("Would you like to Cancel Dyed Out Sample ?", "System Message", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button3)
        If result = DialogResult.Cancel Then blnCancel = True
        If result <> DialogResult.Yes Then Exit Sub

        If Not CheckDataCancel() Then Exit Sub

        Call CancelHangerOUT()
    End Sub

    Private Function CheckDataCancel() As Boolean
        If txtOutno.Text.Trim.Length = 0 Then
            MessageBox.Show("คุณยังไม่ได้เลือก Outno", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return False
            Exit Function
        End If

        Return True
    End Function


    Private Function CancelHangerOUT() As Boolean
        Dim config As New clsConfig

        Dim DOUTHeader As New classHangerOutBarcode.StrollsDOHeader
        Dim msgerr As String = ""

        Dim OUTDT As String = DtpOutdt.Value.ToString("yyyyMMdd")
        Dim USERID As String = clsuser.UserID
        Dim CheckNEW As String = txtOutNo.Text.Trim


        Dim dtd As DataTable = grdHanger.DataSource
        Dim dv_dtd_add As New DataView(dtd, "", "", DataViewRowState.Added)
        Dim dv_dtd_upd As New DataView(dtd, "", "", DataViewRowState.ModifiedCurrent)
        Dim dv_dtd_del As New DataView(dtd, "", "", DataViewRowState.Deleted)

        DOUTHeader.h01_outno = txtOutno.Text.Trim
        DOUTHeader.h02_outdt = dtpOutDt.Value.Date

        DOUTHeader.msgerr = ""

        If (New classHangerOutBarcode).CANCELHOUT(DOUTHeader, clsuser) Then

            MessageBox.Show("ยกเลิกสำเร็จ ", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Information)

            Call InitControl()
            Call GenComBo()
            Call InitDataBinding()
            Call LoadGrdDOutNewByOutno("N/A")

            CancelHangerOUT = True
        Else
            CancelHangerOUT = False
            MessageBox.Show(DOUTHeader.msgerr, "System Message", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
        End If
    End Function

    Private Sub btnExit_Click(sender As System.Object, e As System.EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnNew_Click(sender As System.Object, e As System.EventArgs) Handles btnNew.Click
        Call frmHangerOut_Load(sender:=sender, e:=e)
    End Sub

    Private Sub btnPrintHangerOut_Click(sender As System.Object, e As System.EventArgs) Handles btnPrintHangerOut.Click

        If txtOutno.Text.Length = 0 Then Exit Sub

        Const rptFileName = "rptHOUT.rpt"

        If clsuser.ReportPath = "" Then clsuser.ReportPath = clsuser.ReportPath
        If Not (New clsConfig).CheckReport(clsuser.ReportPath, rptFileName) Then Exit Sub
        Dim frm As New frmReport
        Dim rpt As New CrystalDecisions.CrystalReports.Engine.ReportDocument
        Me.Cursor = Cursors.WaitCursor
        rpt.Load(clsuser.ReportPath & rptFileName)
        rpt.DataSourceConnections.Item(0).SetConnection((New classConnection).servername, (New classConnection).database, False)
        rpt.DataSourceConnections.Item(0).SetLogon((New classConnection).Userid, (New classConnection).Password)
        rpt.VerifyDatabase()
        rpt.SetParameterValue("@docno", txtOutno.Text.Trim)


        frm.Title = "Hanger Out"
        frm.CRViewer.ReportSource = rpt
        frm.MdiParent = Me.ParentForm
        frm.Show()
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub grdHangerIN_CellEndEdit(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles grdHanger.CellEndEdit
        If e.RowIndex < 0 Or e.ColumnIndex < 0 Then Exit Sub
        If grdHanger.Columns(e.ColumnIndex).Name = "grdHangerINKg" Then

            If (New clsConfig).IsNull(grdHanger.CurrentRow.Cells("grdHangerINKg").Value, 0) > 0 Then
                grdHanger.CurrentRow.Cells("grdHangerINSel").Value = True
            End If

        End If

    End Sub
End Class