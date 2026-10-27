Public Class frmYarnINFromGemmaknit
    Dim clsUser As New classUserInfo

    Public Property UserInfo() As classUserInfo
        Get
            UserInfo = clsUser
        End Get
        Set(ByVal NewValue As classUserInfo)
            clsUser = NewValue
        End Set
    End Property


    Private Sub btnLoad_Click(sender As System.Object, e As System.EventArgs) Handles btnLoad.Click
        LoadDataLog(txtLogNo.Text.Trim.ToUpper)
    End Sub
    Private Sub txtLogNo_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles txtLogNo.KeyDown
        If e.KeyCode = Keys.Enter Then

            LoadDataLog(txtLogNo.Text.Trim.ToUpper)
        End If
    End Sub
    'Private Function Validate_sinvno(Optional ByVal StrSinvno As String = "") As Boolean
    '    Dim objdb As New classYarnINFromGemmaknit

    '    Validate_sinvno = objdb.Validate_sinvno(StrSinvno)

    '    'If dt.Rows.Count = 0 Then

    '    '    Return False
    '    'Else
    '    '    Return True
    '    'End If


    'End Function

    Private Sub frmYarnINFromGemmaknit_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        InitControl()
    End Sub
    Private Sub InitControl()

        GenCombo()
        GenComboDocno()
        insertcomboitemcode()

        LoadDataLog(txtLogNo.Text.Trim.ToUpper)
        LoadDataYarnIn(txtYINNo.Text.Trim.ToUpper)

    End Sub
    Private Sub GenComboDocno()


    End Sub
    Private Sub insertcomboitemcode()
        Dim tblItems As New tbl_Items
        Dim getDatayarn As New GetDataYarn
        Dim ds As New DataSet
        tblItems.itcd = ""
        ds = getDatayarn.GetDataItem(tblItems)
        If Not IsNothing(ds) Then


            Me.cboYarnCode.DataSource = ds.Tables(0)
            Me.cboYarnCode.DisplayMember = "itcd"
            Me.cboYarnCode.ValueMember = "itcd"
        End If
    End Sub

    Private Sub GenCombo()
        Dim clsmaster As New classMaster
        Dim clsYarn As New GetDataYarn
        'Dim objdb As New classYarnINFromGemmaknit
        'Dim clsYarn As New GetDataYarn

        'Dim dt As DataTable = objdb.GetComboYarnIn(clsUser)

        'Dim dt2 As DataTable = clsYarn.GetSupplier()

        cbomtl_warehouse.DataSource = clsmaster.Combomtlwarehouse(clsUser.UserID)
        cbomtl_warehouse.DisplayMember = "warehouse_name"
        cbomtl_warehouse.ValueMember = "mtl_warehouse_id"
        cbomtl_warehouse.SelectedIndex = -1
        cbomtl_warehouse.SelectedValue = 4

        cbomtl_Location.DataSource = clsmaster.Combomtllocations(clsUser.UserID)
        cbomtl_Location.ValueMember = "mtl_locations_id"
        cbomtl_Location.DisplayMember = "location_name"
        cbomtl_Location.SelectedIndex = -1
        cbomtl_Location.SelectedValue = 4

        tr_mtl_warehouse.DataSource = clsmaster.Combomtlwarehouse(clsUser.UserID)
        tr_mtl_warehouse.DisplayMember = "warehouse_name"
        tr_mtl_warehouse.ValueMember = "mtl_warehouse_id"

        tr_mtl_locations.DataSource = clsmaster.Combomtllocations(clsUser.UserID)
        tr_mtl_locations.ValueMember = "mtl_locations_id"
        tr_mtl_locations.DisplayMember = "location_name"

        yn_mtl_warehouse.DataSource = clsmaster.Combomtlwarehouse(clsUser.UserID)
        yn_mtl_warehouse.DisplayMember = "warehouse_name"
        yn_mtl_warehouse.ValueMember = "mtl_warehouse_id"

        yn_mtl_locations.DataSource = clsmaster.Combomtllocations(clsUser.UserID)
        yn_mtl_locations.ValueMember = "mtl_locations_id"
        yn_mtl_locations.DisplayMember = "location_name"

        cboSupplier.DataSource = clsmaster.GetSupplier("")
        cboSupplier.DisplayMember = "name"
        cboSupplier.ValueMember = "suppcd"
        cboSupplier.SelectedIndex = -1

        tr_itcd.DataSource = clsYarn.getItems()
        tr_itcd.DisplayMember = "itcd_desc"
        tr_itcd.ValueMember = "itcd"

        yn_itcd.DataSource = clsYarn.getItems()
        yn_itcd.DisplayMember = "itcd_desc"
        yn_itcd.ValueMember = "itcd"

        'cboSupplier.SelectedValue

    End Sub

    Private Sub LoadDataYarnIn(ByVal StrDocno As String)
        Dim classGetYarnIn As New classYarnINFromGemmaknit

        Dim dt As DataTable = classGetYarnIn.GetYarnIn(txtYINNo.Text.Trim.ToUpper)

        grdYarnIN.AutoGenerateColumns = False
        grdYarnIN.DataSource = dt



    End Sub

    Private Sub LoadDataLog(ByVal strLogNoLoad As String)
        Dim classGetYarnIn As New classYarnINFromGemmaknit
        Dim dtTr As DataTable = classGetYarnIn.GetYarnInFromGemmaknits(txtLogNo.Text.Trim.ToUpper)

        grdTransfer.AutoGenerateColumns = False
        grdTransfer.DataSource = dtTr

        If dtTr.Rows.Count > 0 Then
            cboSupplier.SelectedValue = dtTr.Rows(0)("suppcd")
            txtlotno_sup.Text = dtTr.Rows(0)("lotno_sup")
            dtpLogDt.Value = dtTr.Rows(0)("logdate")

            txtLogNo.ReadOnly = False


        Else
            'cboSupplier.SelectedIndex = -1
            'txtlotno_sup.Text = ""
            'dtpLogDt.Value = ""

            'txtLogNo.ReadOnly = True

        End If

        Call CompareTwoGrids()
    End Sub

    Private Sub txtLogNo_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtLogNo.TextChanged

    End Sub

    Private Sub btnSelect_Click(sender As System.Object, e As System.EventArgs) Handles btnSelect.Click

        Dim dt As New DataTable
        dt = grdTransfer.DataSource

        If dt.Rows.Count = 0 Then
            Exit Sub
        End If

        'If checkItems() Then
        'MessageBox.Show("ยังไม่ได้ใส่ Item Code", "System Message!", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
        'Exit Sub
        'End If

        If Not CheckgrdTransfer() Then Exit Sub
        If MessageBox.Show("Would you like to add selected Roll No. from left grid to right grid ?" & vbCrLf & "คุณต้องการเพิ่มกล่องที่เลือกไว้ด้านซ้ายเพื่อนำไปใส่ในเอกสารด้านขวาใช่หรือไม่ ?", "System Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = DialogResult.No Then Exit Sub
        If cbomtl_warehouse.Text.Trim.Length = 0 Then
            MessageBox.Show("Please fill the new location to transfer." & vbCrLf & "คุณยังไม่ได้ใส่ Location ที่จะทำการย้ายไป", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            cbomtl_warehouse.Focus()
        Else
            Call AddRollNo()
            Call DeleteRollNogrdTransfer()
            Call CompareTwoGrids()
        End If
    End Sub

    Private Sub CompareTwoGrids()
        Dim i As Integer
        Dim j As Integer

        For i = 0 To Me.grdYarnIN.Rows.Count - 2
            j = 0
            Do While Me.grdTransfer.Rows.Count - 2 >= 0 And j <= Me.grdTransfer.Rows.Count - 2
                If Me.grdTransfer.Rows(j).Cells("tr_boxno_s").Value.ToString.Trim = Me.grdYarnIN.Rows(i).Cells("yn_boxno_s").Value.ToString.Trim Then
                    Dim dgvRow As New DataGridViewRow
                    dgvRow = Me.grdTransfer.Rows(j)
                    Me.grdTransfer.Rows(j).Cells("tr_spools").Value = Me.grdTransfer.Rows(j).Cells("tr_spools").Value - Me.grdYarnIN.Rows(i).Cells("yn_spools").Value
                    Me.grdTransfer.Rows(j).Cells("tr_kg_nt").Value = Me.grdTransfer.Rows(j).Cells("tr_kg_nt").Value - Me.grdYarnIN.Rows(i).Cells("yn_kg_nt").Value
                    If Me.grdTransfer.Rows(j).Cells("tr_spools").Value <= 0 Then
                        Me.grdTransfer.Rows.Remove(dgvRow)
                    End If
                    j = j + 1
                Else
                    j = j + 1
                End If
            Loop
        Next
    End Sub

   


    Private Function CheckgrdTransfer() As Boolean
        If grdTransfer.DataSource Is Nothing Then Return False
        If grdTransfer.Rows.Count = 0 Then Return False
        Dim i As Integer = 0
        For i = 0 To grdTransfer.Rows.Count - 1
            If CBool(grdTransfer.Rows(i).Cells("tr_chkSelect").Value) Then Return True
        Next
        Return False
    End Function

    Private Function AddRollNo() As Boolean


        If grdTransfer.Rows.Count > 0 Then
            Dim config As New clsConfig
            Dim dtTransfer As DataTable = grdTransfer.DataSource
            Dim dtYarnIn As DataTable = grdYarnIN.DataSource
            Dim dr As DataRow
            Dim msg As String = ""
            Dim i As Integer = 0
            Dim j As Integer = 0
            For i = 0 To dtTransfer.Rows.Count - 1
                If CBool(dtTransfer.Rows(i)("chkSelect")) Then
                    dr = dtYarnIn.NewRow
                    For j = 0 To dtYarnIn.Columns.Count - 1
                        dr(dtYarnIn.Columns(j).ColumnName.Trim) = dtTransfer.Rows(i)(dtYarnIn.Columns(j).ColumnName.Trim)

                        If dtYarnIn.Columns(j).ColumnName.Trim = "loc" Then
                            dr(dtYarnIn.Columns(j).ColumnName.Trim) = cbomtl_warehouse.Text.Trim
                        End If

                        If dtYarnIn.Columns(j).ColumnName = "mtl_warehouse_id" Then
                            dr(dtYarnIn.Columns(j).ColumnName.Trim) = cbomtl_warehouse.SelectedValue
                        End If
                        If dtYarnIn.Columns(j).ColumnName = "mtl_locations_id" Then
                            dr(dtYarnIn.Columns(j).ColumnName.Trim) = cbomtl_Location.SelectedValue
                        End If
                    Next
                    dtYarnIn.Rows.Add(dr)


                End If
            Next

        End If

    End Function

    Private Sub txtYINNo_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles txtYINNo.KeyDown
        If e.KeyCode = Keys.Enter Then
            LoadDataYarnIn(txtYINNo.Text.Trim.ToUpper)
        End If
    End Sub

    Private Sub txtYINNo_MouseCaptureChanged(sender As Object, e As System.EventArgs) Handles txtYINNo.MouseCaptureChanged

    End Sub

    Private Sub txtYINNo_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtYINNo.TextChanged

    End Sub

    Private Sub btnNew_Click(sender As System.Object, e As System.EventArgs) Handles btnNew.Click
        InitControl()
    End Sub

    Private Sub btnExit_Click(sender As System.Object, e As System.EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnMinimized_Click(sender As System.Object, e As System.EventArgs) Handles btnMinimized.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub


    Private Sub btnDeselect_Click(sender As System.Object, e As System.EventArgs) Handles btnDeselect.Click
        If Not CheckGrdYarnIn() Then Exit Sub
        If MessageBox.Show("Would you like to delete selected Roll No. in right grid ?" & vbCrLf & "คุณต้องการลบกล่องที่เลือกไว้ในเอกสารในด้านขวาออกใช่หรือไม่ ?", "System Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = DialogResult.No Then Exit Sub

        If grdYarnIN.CurrentRow.Index >= 0 Then Call DeleteRollNoGrdYarnIn()
        Call CompareTwoGrids()
    End Sub

    Private Sub DeleteRollNoGrdYarnIn()
        If grdYarnIN.Rows.Count > 0 Then
            Dim i As Integer = 0
            Dim dt As DataTable = grdYarnIN.DataSource
            Do While i < dt.Rows.Count
                If dt.Rows.Count = 0 Then Exit Do
                For i = 0 To dt.Rows.Count - 1
                    If Not dt.Rows(i).RowState = DataRowState.Deleted Then
                        If CBool(dt.Rows(i)("chkSelect")) Then
                            dt.Rows(i).Delete()
                            Exit For
                        End If
                    End If
                Next
            Loop
            If dt.Rows.Count = 0 Then cbomtl_warehouse.Enabled = True
        End If
    End Sub

    Private Sub DeleteRollNogrdTransfer()
        If grdTransfer.Rows.Count > 0 Then
            Dim i As Integer = 0
            Dim dt As DataTable = grdTransfer.DataSource
            Do While i < dt.Rows.Count
                If dt.Rows.Count = 0 Then Exit Do
                For i = 0 To dt.Rows.Count - 1
                    If Not dt.Rows(i).RowState = DataRowState.Deleted Then
                        If CBool(dt.Rows(i)("chkSelect")) Then
                            dt.Rows(i).Delete()
                            Exit For
                        End If
                    End If
                Next
            Loop
            If dt.Rows.Count = 0 Then cbomtl_warehouse.Enabled = True
        End If
    End Sub

    Private Function CheckGrdYarnIn() As Boolean
        If grdYarnIN.DataSource Is Nothing Then Return False
        If grdYarnIN.Rows.Count = 0 Then Return False
        Dim i As Integer = 0
        For i = 0 To grdYarnIN.Rows.Count - 1
            If CBool(grdYarnIN.Rows(i).Cells("yn_chkSelect").Value) Then Return True
        Next
        Return False
    End Function

    Private Sub btnSave_Click(sender As System.Object, e As System.EventArgs) Handles btnSave.Click
        Call SaveData()
    End Sub

    Private Function SaveData() As Boolean



        Dim objdb As New classYarnINFromGemmaknit
        Dim yarnin As New classYarnINFromGemmaknit.YarnIn
        Dim clsconfig As New clsConfig

        yarnin.docno = txtYINNo.Text.Trim.ToUpper
        yarnin.docdt = dtpDocDate.Value
        yarnin.tran_type = "TRANSFER"
        yarnin.sinvno = txtLogNo.Text.Trim '
        yarnin.sinvdt = dtpLogDt.Value.ToString

        yarnin.lotno_sup = txtlotno_sup.Text.Trim
        yarnin.suppcd = cboSupplier.SelectedValue.ToString

        Dim dtYarnIn As DataTable = grdYarnIN.DataSource

        If dtYarnIn.Rows.Count = 0 Then
            MsgBox("คุณยังไมได้เลือก Items")
            Return False
            Exit Function
        End If

        If dtYarnIn.Rows.Count > 0 Then
            If dtYarnIn.Rows(0)("docdt") <> dtpDocDate.Value.ToString("dd/MM/yyyy") Then dtYarnIn.Rows(0)("docdt") = dtpDocDate.Value.ToString("dd/MM/yyyy")
            If clsconfig.IsNull(dtYarnIn.Rows(0)("purno"), "") <> "FREE OF CHARGE" Then dtYarnIn.Rows(0)("purno") = "FREE OF CHARGE"
            If dtYarnIn.Rows(0)("suppcd") <> cboSupplier.SelectedValue Then dtYarnIn.Rows(0)("suppcd") = cboSupplier.SelectedValue
            If dtYarnIn.Rows(0)("sinvno") <> txtLogNo.Text Then dtYarnIn.Rows(0)("sinvno") = txtLogNo.Text.Trim.ToUpper
            If dtYarnIn.Rows(0)("sinvdt") <> dtpLogDt.Value.ToString("dd/MM/yyyy") Then dtYarnIn.Rows(0)("sinvdt") = dtpLogDt.Value.ToString("dd/MM/yyyy")
            If dtYarnIn.Rows(0)("lotno_sup") <> txtlotno_sup.Text Then dtYarnIn.Rows(0)("lotno_sup") = txtlotno_sup.Text
            If clsconfig.IsNull(dtYarnIn.Rows(0)("srefno"), "") <> txtSuppRefNo.Text Then dtYarnIn.Rows(0)("srefno") = txtSuppRefNo.Text
            If dtYarnIn.Rows(0)("remark") <> txtRemark.Text Then dtYarnIn.Rows(0)("remark") = txtRemark.Text
            If dtYarnIn.Rows(0)("tran_type") <> "PURCHASE" Then dtYarnIn.Rows(0)("tran_type") = "PURCHASE"
        End If

        Dim dv_add As New DataView(dtYarnIn, "", "", DataViewRowState.Added)
        Dim dv_upd As New DataView(dtYarnIn, "", "", DataViewRowState.ModifiedCurrent)
        Dim dv_del As New DataView(dtYarnIn, "", "", DataViewRowState.Deleted)


        Dim result As DialogResult
        result = MessageBox.Show("Would you like to save ?", "System Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button3)
        'If result = Windows.Forms.DialogResult.Cancel Then blnCancel = True
        If result <> DialogResult.Yes Then Exit Function

        If objdb.SaveYarnIn(YarnIn:=yarnin, dv_add:=dv_add, dv_upd:=dv_upd, dv_del:=dv_del, clsuser:=clsUser) Then
            MessageBox.Show("Save is Complete! : บันทึกสำเร็จ! ", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
            txtYINNo.Text = yarnin.docno
            LoadDataYarnIn(txtYINNo.Text.Trim.ToUpper)
            SaveData = True
        Else
            MessageBox.Show(yarnin.Message, "System Message", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
            SaveData = False
        End If


    End Function

    Private Sub cbomtl_warehouse_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles cbomtl_warehouse.KeyPress
        e.Handled = True
    End Sub

    Private Sub cbomtl_warehouse_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cbomtl_warehouse.SelectedIndexChanged

    End Sub

    Private Sub lblWarehourse_Click(sender As System.Object, e As System.EventArgs) Handles lblWarehourse.Click

    End Sub

    Private Sub cbomtl_Location_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles cbomtl_Location.KeyPress
        e.Handled = True
    End Sub

    Private Sub cbomtl_Location_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cbomtl_Location.SelectedIndexChanged

    End Sub

    Private Sub btnChangeYarnCode_Click(sender As System.Object, e As System.EventArgs) Handles btnChangeYarnCode.Click
        If grdTransfer.DataSource Is Nothing Then Exit Sub

        Dim dtTransfer As DataTable = grdTransfer.DataSource
        Dim itcd As String = cboYarnCode.SelectedValue
        For i As Integer = 0 To dtTransfer.Rows.Count - 1
            If CBool(dtTransfer.Rows(i)("chkSelect")) Then
                dtTransfer.Rows(i)("itcd") = itcd
            End If

        Next
        grdTransfer.Refresh()


    End Sub

    Private Function checkItems() As Boolean
        Dim clsconfig As New clsConfig
        If grdTransfer.DataSource Is Nothing Then Exit Function

        Dim dtTransfer As DataTable = grdTransfer.DataSource
        Dim itcd As String = cboYarnCode.SelectedValue
        For i As Integer = 0 To dtTransfer.Rows.Count - 1
            If CBool(dtTransfer.Rows(i)("chkSelect")) Then
                If clsconfig.IsNull(dtTransfer.Rows(i)("itcd"), "") = "" Then
                    Return True
                    Exit Function
                Else
                    Return False
                    Exit Function
                End If
            End If

        Next
    End Function

    Private Sub btnPrintBarcode_Click(sender As System.Object, e As System.EventArgs) Handles btnPrintBarcode.Click
        If txtYINNo.Text.Length = 0 Then Exit Sub
        Dim frm As New formPrintBarcode

        frm.loginEmpcd = clsUser.UserID
        frm.UserInfo = clsUser
        frm.Show()

        frm.txtYarn_in_no.Text = txtYINNo.Text.Length

        frm.btnFindByYarnInClick()
        frm.SelectAll(sender, e)
    End Sub

    Private Sub btnPrint_Click(sender As System.Object, e As System.EventArgs) Handles btnPrint.Click
        Dim clsConn As New classConnection
        Dim rptFileName As String = "rptYarnIn.rpt"
        Dim frm As New frmReport
        Dim clsConfig As New clsConfig

        If Not clsConfig.CheckReport(clsuser.reportpath, rptFileName) Then Exit Sub
        Dim rpt As New CrystalDecisions.CrystalReports.Engine.ReportDocument
        Dim stype As String = ""
        Dim ord As String = ""
        Me.Cursor = Cursors.WaitCursor

        rpt.Load(clsuser.reportpath & rptFileName)
        rpt.DataSourceConnections.Item(0).SetConnection(clsConn.ServerName, clsConn.Database, False)
        rpt.DataSourceConnections.Item(0).SetLogon(clsConn.UserName, clsConn.Password)
        rpt.VerifyDatabase()
        rpt.SetParameterValue("@docno", txtYINNo.Text.Trim)

        'rpt.PrintOptions.PaperSize = CrystalDecisions.Shared.PaperSize.PaperA4
        'rpt.PrintOptions.PaperOrientation = CrystalDecisions.Shared.PaperOrientation.Portrait
        'rpt.PrintOptions.PaperSource = CrystalDecisions.Shared.PaperSource.Auto

        'frm.CRViewer.DisplayGroupTree = False
        frm.CRViewer.ReportSource = rpt
        frm.MdiParent = Me.ParentForm
        frm.Title = "Yarn In"
        frm.Show()
        Me.Cursor = Cursors.Default
    End Sub
End Class