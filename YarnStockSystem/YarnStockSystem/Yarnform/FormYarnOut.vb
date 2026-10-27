Public Class formYarnout
    Private oConfig As New clsConfig
    Private dsYarn_in_det As DataTable
    Private ds As New DataSet
    Private connStr As New classConnection
    Private dt As DataTable
    Private dtJob As DataTable
    Dim blnCancel As Boolean = False
    Private clsUser As New classUserInfo
    Public Property UserInfo() As classUserInfo
        Get
            UserInfo = clsUser
        End Get
        Set(ByVal NewValue As classUserInfo)
            clsUser = NewValue
        End Set
    End Property
    Private Sub FormYarnOutKnitting_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized

        Call InitControl()

        'Call formatform()
        Call insertcombotrantype()
        Call insertcomboitemcode()
        Call GenComboInGrid() 'Sitthana 20190403
        txtJobNo.Select()
    End Sub

    Private Sub insertcombotrantype()
        Dim tblItems As New tbl_Items
        Dim getDatayarn As New GetDataYarn
        Dim dt As New DataTable
        dt = getDatayarn.GetDataTrantype()
        If Not IsNothing(dt) Then
            Me.CbTrantype.DataSource = dt
            Me.CbTrantype.DisplayMember = "tran_desc"
            Me.CbTrantype.ValueMember = "tran_type"
            Me.CbTrantype.SelectedIndex = -1
            Me.CbTrantype.Enabled = False
        End If
    End Sub

    Private Sub insertcomboitemcode()
        Dim tblItems As New tbl_Items
        Dim getDatayarn As New GetDataYarn
        Dim ds As New DataSet
        tblItems.itcd = ""
        ds = getDatayarn.GetDataItem(tblItems)
        If Not IsNothing(ds) Then
            Me.colitcd.DataSource = ds.Tables(0)
            Me.colitcd.DisplayMember = "itdesc"
            Me.colitcd.ValueMember = "Itcd"

        End If
    End Sub

    Private Sub GenComboInGrid()
        'Dim Objdb As New GetDataYarn
        'Me.GB.DataSource = Objdb.getGB()
        'Me.GB.DisplayMember = "gb"
        'Me.GB.ValueMember = "gb"
    End Sub

    Private Sub butSelectAll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butSelectAll.Click
        Dim i As Integer
        Dim count As Integer
        count = Me.DgYarnOut.Rows.Count - 2
        For i = 0 To count
            Me.DgYarnOut.Rows(i).Cells(0).Value = True
        Next
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Dim i As Integer
        Dim count As Integer
        count = Me.DgYarnOut.Rows.Count - 2
        For i = 0 To count
            Me.DgYarnOut.Rows(i).Cells(0).Value = False
        Next
    End Sub

    Private Sub DgYarnOut_CellValidated(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DgYarnOut.CellValidated
        Dim sumgross As Double
        Dim sumnet As Double
        Dim i As Integer
        ' Try
        Dim countGrid As Integer
        countGrid = Me.DgYarnOut.Rows.Count
        For i = 0 To Me.DgYarnOut.Rows.Count - 2
            'Dim kg_gr As Integer
            'Dim kg_nt As Integer
            'kg_gr = (New clsConfig).IsNull(Me.DgYarnOut.Rows(i).Cells("colKgGr").Value, 0)
            'kg_nt = (New clsConfig).IsNull(Me.DgYarnOut.Rows(i).Cells("colKgNt").Value, 0)
            ''If IsDBNull(Me.DgYarnOut.Rows(i).Cells("colKgGr").Value) Then
            '        kg_gr = 0
            '    Else
            '        kg_gr = Clsconfig.IsValidDouble(Me.DgYarnOut.Rows(i).Cells("colKgGr").Value)
            '    End If

            '    If IsDBNull(Me.DgYarnOut.Rows(i).Cells("colKgNt").Value) Then
            '        kg_nt = 0
            '    Else
            '        kg_nt = Clsconfig.IsValidDouble(Me.DgYarnOut.Rows(i).Cells("colKgNt").Value)
            '    End If

            sumgross = sumgross + (New clsConfig).IsNull(Me.DgYarnOut.Rows(i).Cells("colKgGr").Value, 0)
            sumnet = sumnet + (New clsConfig).IsNull(Me.DgYarnOut.Rows(i).Cells("colKgNt").Value, 0)
        Next
        Me.txttotalgross.Text = sumgross
        Me.txttotalnet.Text = sumnet
        txttotalboxes.Text = Me.DgYarnOut.RowCount - 1
        ' Catch ex As Exception
        'MsgBox(ex.Message)
        'End Try
    End Sub

    Private Sub txtJobno_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtJobNo.KeyPress
        If AscW(e.KeyChar) = 13 Then
            txtJobNo.Text = txtJobNo.Text.Trim

            If Not CheckDataJob() Then Exit Sub

            ' Me.btnNew.Visible = False
            'Me.BtnSave.Visible = True

            Me.textYarnInNo.Text = " "

            Call loadjobdata()
            txtJobNo.Enabled = False
        End If
    End Sub

    Private Function ValidateJobNoAlreadyUse(Optional ByVal StrJobno As String = "") As Boolean
        Dim objdb As New classYarnOut
        Dim dt As DataTable = objdb.ValidateJobNoAlreadyOut(StrJobno, clsUser.UserID)

        If dt.Rows.Count > 0 Then
            MessageBox.Show("Job No .: " & StrJobno & "............   is Already Out!! For Outno : " & dt.Rows(0)("outno").ToString, "SyStem Messsage", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return False
        Else
            Return True
        End If


    End Function

    Private Sub loadjobdata()
        LoadDataYarnInToYarnOut("JOB")
        Dim i As Integer
        Dim count As Integer
        count = Me.DgYarnOut.Rows.Count - 2
        For i = 0 To count
            Me.DgYarnOut.Rows(i).Cells(0).Value = True
        Next
    End Sub

    Private Sub LoadDataYarnInToYarnOut(ByVal SourceDoc As String)
        Dim getDatayarn As New GetDataYarn
        'Dim dt As DataTable
        If SourceDoc = "YIN" Then
            dt = getDatayarn.GetDataYarnOut(Me.textYarnInNo.Text, SourceDoc)
        ElseIf SourceDoc = "JOB" Then
            dt = getDatayarn.GetDataYarnOut(Me.txtJobNo.Text, SourceDoc)
        End If
        If dt.Rows.Count > 0 Then
            Me.DgYarnOut.DataSource = dt
            'Me.lblYINDate.Text = dt.Rows(0).Item("docdt")
            Me.txtsupplier.Text = dt.Rows(0).Item("supname")
            Me.CbTrantype.SelectedValue = dt.Rows(0).Item("tran_type")

            'Dim dr As DataRow
            'For Each dr In dt.Rows
            '    With Me.DgYarnOut
            '        .Columns(1).DataPropertyName = "itcd"
            '        Me.DgCombobox.ValueMember = "itcd"
            '        .Columns(2).DataPropertyName = "grade"
            '        .Columns(3).DataPropertyName = "boxno_s"
            '        .Columns(4).DataPropertyName = "boxno"
            '        .Columns(5).DataPropertyName = "spools"
            '        .Columns(6).DataPropertyName = "kg_gr"
            '        .Columns(7).DataPropertyName = "cart_tearwt"
            '        .Columns(8).DataPropertyName = "kg_nt"
            '        .Columns(9).DataPropertyName = "id_job_det_yarn"

            '    End With
            'Next

            totalSum()
        Else
            MsgBox("Job order Not found, please check If Y-out Is already made..", MsgBoxStyle.Critical, "Cannot find")
            Me.DgYarnOut.DataSource = dt
            'Me.lblYINDate.Text = ""
            totalSum()
        End If
    End Sub

    Private Sub totalSum()
        Dim sumgross As Double
        Dim sumnet As Double
        Dim i As Integer
        ' Try
        Dim countGrid As Integer
        countGrid = Me.DgYarnOut.Rows.Count
        For i = 0 To Me.DgYarnOut.Rows.Count - 2
            Dim kg_gr As Double
            Dim kg_nt As Double

            kg_gr = (New clsConfig).IsNull(Me.DgYarnOut.Rows(i).Cells("colKgGr").Value, 0)
            kg_nt = (New clsConfig).IsNull(Me.DgYarnOut.Rows(i).Cells("colKgNt").Value, 0)
            'If IsDBNull(Me.DgYarnOut.Rows(i).Cells("colKgGr").Value) Then
            '    kg_gr = 0
            'Else
            '    kg_gr = Clsconfig.IsValidDouble(Me.DgYarnOut.Rows(i).Cells("colKgGr").Value)
            'End If

            'If IsDBNull(Me.DgYarnOut.Rows(i).Cells(8).Value) Then
            '    kg_nt = 0
            'Else
            '    kg_nt = Clsconfig.IsValidDouble(Me.DgYarnOut.Rows(i).Cells(8).Value)
            'End If

            sumgross = sumgross + kg_gr
            sumnet = sumnet + kg_nt
        Next
        Me.txttotalgross.Text = sumgross
        Me.txttotalnet.Text = sumnet
        txttotalboxes.Text = Me.DgYarnOut.RowCount - 1
        '  Catch ex As Exception
        '      MsgBox(ex.Message)
        '  End Try
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Me.Close()
    End Sub

    Private Sub BtnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSave.Click
        Me.Validate()

        blnCancel = False
        Dim result As DialogResult
        result = MessageBox.Show("Would you like to save ?", "System Message", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button3)
        If result = DialogResult.Cancel Then blnCancel = True
        If result <> DialogResult.Yes Then Exit Sub

        If Not CheckData() Then Exit Sub

        Call InsertData()

    End Sub

    Public Function CheckData() As Boolean

        If txtYOUT.Text.Trim <> "" Then
            MessageBox.Show("รายการนี้ได้สร้างเรียบร้อยแล้วครับ คุณจะไม่สามารถแก้ไขได้" & vbCr _
                          & Space(5) & "ถ้าคุณจะแก้ไข ให้ใช้โปรแกรม Edit ครับ" _
                          , "ข้อความแจ้งเตือน", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Me.ErrorProvider1.SetError(Me.txtYOUT, "รายการนี้ได้สร้างเรียบร้อยแล้วครับ คุณจะไม่สามารถแก้ไขได้")
            Return False
        End If

        If DgYarnOut.Rows.Count <= 1 Then
            MessageBox.Show("ไม่มีรายการใน Grid" & vbCr _
                          & Space(5) & "ให้คุณ ระบุรายการก่อน ครับ" _
                          , "ข้อความแจ้งเตือน", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Me.ErrorProvider1.SetError(Me.DgYarnOut, "ให้คุณ ระบุรายการก่อน ครับ")
            Return False
        End If

        If Not (New classYarnOut).ValidateJobno(StrJobno:=txtJobNo.Text.Trim) Then
            MessageBox.Show("JobNo :" & txtJobNo.Text.Trim & "InCorrect", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.ErrorProvider1.SetError(Me.txtJobNo, "JobNo :" & txtJobNo.Text.Trim & "InCorrect")
            Return False
        End If

        If Not (New classYarnOut).ValidateOutno(StrOutno:=txtYOUT.Text.Trim) Then
            MessageBox.Show("Outno :" & txtYOUT.Text.Trim & " Already", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.ErrorProvider1.SetError(Me.txtYOUT, "Outno :" & txtYOUT.Text.Trim & " Already")
            Return False
        End If

        If Not ValidateJobNoAlreadyUse(txtJobNo.Text.Trim) Then
            MessageBox.Show("ไม่สามารถ Yarn Out ได้ เนื่องจาก Job No Already Use", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button3)
            Me.ErrorProvider1.SetError(Me.txtJobNo, "Job No :" & txtJobNo.Text.Trim & " Already Use")
            Return False
        End If

        If (New classYarnOut).ValitateJobNoAlreadyKOClosed(StrJobno:=txtJobNo.Text.Trim) Then
            MessageBox.Show("ไม่สามารถ Yarn Out ได้ เนื่องจาก Production Order ถูก Closed ไปแล้ว", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button3)
            Me.ErrorProvider1.SetError(Me.txtJobNo, "Job No :" & txtJobNo.Text.Trim & " Prod Order Already Closed")
            Return False
        End If

        Me.ErrorProvider1.Clear()
        Return True  'Sitthana 06/03/2018
    End Function


    Private Sub InsertData()
        Dim config As New clsConfig
        config.ChangeCulture()

        Dim tbl_Yarn_out As New tbl_Yarn_out
        Dim InsertYarn As New InsertYarn
        '  Dim isvalid As Boolean
        ' Try

        'tbl_Yarn_out.outno =
        tbl_Yarn_out.outdt = Me.Datetime.Value.ToString("yyyyMMdd")
        tbl_Yarn_out.tran_type = CbTrantype.SelectedValue
        tbl_Yarn_out.kono = dt.Rows(0).Item("kono")
        tbl_Yarn_out.refdocno = IIf(Me.txtJobNo.Text.Trim <> "", Me.txtJobNo.Text.ToUpper.Trim, Me.textYarnInNo.Text.Trim)
        tbl_Yarn_out.suppcd = dt.Rows(0).Item("suppcd").ToString
        tbl_Yarn_out.remm = Me.txtRemark.Text

        Dim count As Integer
        Dim i As Integer
        Dim j As Integer = 0
        count = Me.DgYarnOut.Rows.Count - 2

        For i = 0 To count
            If Me.DgYarnOut.Rows(i).Cells("colCheckbox").Value = True Then
                ReDim Preserve tbl_Yarn_out.tbl_Yarn_out_det(j)
                tbl_Yarn_out.tbl_Yarn_out_det(j) = New tbl_Yarn_out_det
                tbl_Yarn_out.tbl_Yarn_out_det(j).itcd = oConfig.IsNull(Me.DgYarnOut.Rows(i).Cells("colitcd").Value, "").ToString
                tbl_Yarn_out.tbl_Yarn_out_det(j).grade = oConfig.IsNull(Me.DgYarnOut.Rows(i).Cells("colGrade").Value, "").ToString
                'tbl_Yarn_out.tbl_Yarn_out_det(j).boxno_s = Me.DgYarnOut.Rows(i).Cells("boxno_s").Value.ToString
                tbl_Yarn_out.tbl_Yarn_out_det(j).boxno = oConfig.IsNull(Me.DgYarnOut.Rows(i).Cells("colBoxno").Value, "").ToString
                tbl_Yarn_out.tbl_Yarn_out_det(j).spools = oConfig.IsNull(Me.DgYarnOut.Rows(i).Cells("colSpools").Value, 0)
                tbl_Yarn_out.tbl_Yarn_out_det(j).kg_gr = oConfig.IsNull(Me.DgYarnOut.Rows(i).Cells("colKgGr").Value, 0)
                tbl_Yarn_out.tbl_Yarn_out_det(j).cart_tearwt = oConfig.IsNull(Me.DgYarnOut.Rows(i).Cells("cart_tearwt").Value, 0)
                tbl_Yarn_out.tbl_Yarn_out_det(j).actual_cone_weight = oConfig.IsNull(Me.DgYarnOut.Rows(i).Cells("colActualConeWeight").Value, 0)
                tbl_Yarn_out.tbl_Yarn_out_det(j).kg_nt = oConfig.IsValidDouble(Me.DgYarnOut.Rows(i).Cells("colKgNt").Value)
                tbl_Yarn_out.tbl_Yarn_out_det(j).gb = oConfig.IsNull(Me.DgYarnOut.Rows(i).Cells("colGb").Value.ToString, "")
                tbl_Yarn_out.tbl_Yarn_out_det(j).id_job_det_yarn = oConfig.IsNull(Me.DgYarnOut.Rows(i).Cells("colidJobDetYarn").Value, Nothing)
                tbl_Yarn_out.tbl_Yarn_out_det(j).mfg_production_order_line_id = oConfig.IsNull(Me.DgYarnOut.Rows(i).Cells("colMfgProductionOrderLineId").Value, Nothing)
                j = j + 1
            Else
            End If
        Next

        ' Dim Youtno As String = ""
        Dim msgerr As String = ""
        'isvalid = InsertYarn.InsertYarnOut(tbl_Yarn_out, msgerr, Me.loginEmpcd)

        If InsertYarn.InsertYarnOut(tbl_Yarn_out, msgerr, Me.clsUser.UserID) Then
            MsgBox("success")
            txtYOUT.Text = tbl_Yarn_out.outno
            Me.btnNew.Visible = False
            Me.BtnSave.Visible = True
        Else
            MsgBox(msgerr)
        End If

        ' Catch ex As Exception
        '     MsgBox(ex.Message)
        ' End Try
    End Sub

    Private Sub btnPrintYarnout_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrintYarnout.Click
        'Dim str As String
        ''str.Append("SELECT dbo.yarn_in.*, dbo.Yarn_in_det.*  ")
        ''str.Append("FROM   dbo.yarn_in INNER JOIN ")
        ''str.Append("dbo.Yarn_in_det ON dbo.yarn_in.docno = dbo.Yarn_in_det.docno ")
        ''str.Append("where  (dbo.yarn_in.docno =  '" & Me.txtDocno.Text & "')")
        'str = ""
        'ds.Clear()
        'str = "select * from v_yarn_out  " & _
        ' "where outno = '" & Me.txtYOUT.Text & "'"

        'Dim myda As New SqlDataAdapter(str.ToString, connStr.connection)
        'myda.Fill(ds, "TblDatayarnout")

        '      Dim frmreport As New FormRptYarnOut
        '      Dim rptFileName As String = "RptYarnOut.rpt"
        '      Dim obj As New CrystalDecisions.CrystalReports.Engine.ReportDocument
        '      obj.Load(clsuser.reportpath & rptFileName)
        '      'Dim obj As New RptYarnOut
        'obj.SetDataSource(ds.Tables("TblDatayarnout"))

        'frmreport.CrystalReportViewer1.ReportSource = obj

        'frmreport.ShowDialog()
        Dim clsYarnOutBarCode As New classYarnOutBarcode
        Dim rptFileName As String
        rptFileName = "RptYarnOut.rpt"

        Dim dt As DataTable = clsYarnOutBarCode.GetYOutByJob(strJobNo:="", strOutno:=txtYOUT.Text.Trim, strlogempcd:=clsUser.UserID)
        If dt.Rows.Count > 0 Then
            If dt.Rows(0)("tran_type").ToString.Trim = "WARPING" Then
                rptFileName = "RptYarnOut.rpt"
            ElseIf dt.Rows(0)("tran_type").ToString.Trim = "KNITTING" Then
                rptFileName = "RptYarnOutKnitting.rpt"
            Else
                rptFileName = "RptYarnOut.rpt"
            End If
        End If

        Dim clsConn As New classConnection
        'Dim rptFileName As String = "RptYarnOutKnitting.rpt"
        Dim frm As New frmReport

        If Not oConfig.CheckReport(clsUser.ReportPath, rptFileName) Then Exit Sub
        Dim rpt As New CrystalDecisions.CrystalReports.Engine.ReportDocument
        Me.Cursor = Cursors.WaitCursor

        rpt.Load(clsUser.ReportPath & rptFileName)
        rpt.DataSourceConnections.Item(0).SetConnection(clsConn.ServerName, clsConn.Database, False)
        rpt.DataSourceConnections.Item(0).SetLogon(clsConn.UserName, clsConn.Password)
        rpt.VerifyDatabase()
        rpt.SetParameterValue("@outno", txtYOUT.Text)

        'rpt.PrintOptions.PaperSize = CrystalDecisions.Shared.PaperSize.PaperA4
        'rpt.PrintOptions.PaperOrientation = CrystalDecisions.Shared.PaperOrientation.Portrait
        'rpt.PrintOptions.PaperSource = CrystalDecisions.Shared.PaperSource.Auto

        'frm.CRViewer.DisplayGroupTree = False
        frm.CRViewer.ReportSource = rpt
        frm.MdiParent = Me.ParentForm
        frm.Title = "Yarn OUT"
        frm.Show()
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub textYarnInNo_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles textYarnInNo.TextChanged
        'Me.TextJobNo.Text = " "
        'LoadDataYarnInToYarnOut("YIN")
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.btnNew.Visible = False
        Me.BtnSave.Visible = True
    End Sub

    Private Sub btnNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNew.Click

        Me.WindowState = FormWindowState.Maximized

        Call InitControl()
        Call totalSum()

        insertcombotrantype()
        insertcomboitemcode()
        GenComboInGrid() 'Sitthana 20190403
        txtJobNo.Select()
    End Sub

    Private Sub InitControl()
        Dim obj As Control
        For Each obj In Me.Controls
            Call SetControlValue(obj)
        Next
        Call EnabledControl(True)

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

    Private Sub EnabledControl(ByVal blnEnabled As Boolean)
        Dim obj As Control
        For Each obj In Me.Controls
            Call SetControlEnabled(obj, blnEnabled)
        Next
    End Sub

    Private Sub SetControlValue(ByVal Obj As Control)

        If TypeOf Obj Is DataGridView Then
            Dim dgv As DataGridView = Obj
            If dgv.DataSource IsNot Nothing Then dgv.DataSource = Nothing
            If dgv.AutoGenerateColumns = True Then dgv.AutoGenerateColumns = False
        End If

        If TypeOf Obj Is TextBox Then
            If Obj.Tag = "str" Or Obj.Tag = "" Then Obj.Text = ""
            If Obj.Tag = "int" Then Obj.Text = "0.00"
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


                cbo.SelectedValue = vbNull
            End If
        End If

        If TypeOf Obj Is CheckBox Then
            Dim chk As CheckBox = Obj
            chk.Checked = False
        End If

        If TypeOf Obj Is TabControl Or TypeOf Obj Is TabPage Or TypeOf Obj Is GroupBox Then
            Dim obj2 As Control
            For Each obj2 In Obj.Controls
                Call SetControlValue(obj2)
            Next
        End If
    End Sub

    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
        Dim frm As New formSearchJob
        frm.ShowDialog()
        If frm.pblnOk = True Then
            Me.txtJobNo.Text = frm.pJobNo
            If Not CheckDataJob() Then Exit Sub
            Call loadjobdata()
        End If
        frm.Dispose()
    End Sub

    Private Function CheckDataJob() As Boolean

        If Not ValidateJobNoAlreadyUse(txtJobNo.Text.Trim) Then Return False

        If (New classYarnOut).ValitateJobNoAlreadyKOClosed(StrJobno:=txtJobNo.Text.Trim) Then
            MessageBox.Show("ไม่สามารถ Yarn Out ได้ เนื่องจาก Production Order ถูก Closed ไปแล้ว", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button3)
            Return False
        End If

        Return True
    End Function

    Private Sub DgYarnOut_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgYarnOut.CellDoubleClick
        Dim currentColIndex As Integer = DgYarnOut.CurrentCell.ColumnIndex
        Dim currentColName As String = DgYarnOut.Columns(currentColIndex).Name
        Dim dgr As DataGridViewRow = DgYarnOut.CurrentRow
        If currentColName = "colGb" Then
            Dim frmSelectItems As New formJobOrderYarnNewEditSelectProductionLine

            frmSelectItems.pKoNo = dgr.Cells("colKoNo").Value
            frmSelectItems.ShowDialog(Me)
            If frmSelectItems.pblnOk = True Then
                dgr.Cells("colDgJobYarndetGb").Value = frmSelectItems.pGb
                dgr.Cells("colDgJobYarndetMfgProductionOrderLinesId").Value = frmSelectItems.pMfgProductionOrderLineID
            End If
        End If
    End Sub
End Class