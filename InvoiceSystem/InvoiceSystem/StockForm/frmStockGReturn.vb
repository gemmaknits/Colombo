Public Class frmStockGReturn
    Dim clsUser As New classUserInfo
    Dim clsConfig As New clsConfig
    Dim DbStockG As New classStockG

    Dim blnCancel As Boolean = False

    Public Property UserInfo() As classUserInfo
        Get
            UserInfo = clsUser
        End Get
        Set(ByVal NewValue As classUserInfo)
            clsUser = NewValue
        End Set
    End Property

    Private Sub btnSearchOutNo_Click(sender As System.Object, e As System.EventArgs) Handles btnSearchOutNo.Click
        Dim frm As New frmSearchGOUT
        frm.ShowDialog(Me)
        txtOutNo.Text = (frm.pOutno.ToUpper.Trim.ToUpper)

        Me.Cursor = Cursors.WaitCursor
        If Not blnCancel Then
            If Getoutno(txtOutNo.Text) Then

            End If
        End If
        Me.Cursor = Cursors.Default
        frm.Dispose()
    End Sub

    Private Function Getoutno(ByRef Stroutno As String) As Boolean
        Dim dt As DataTable = DbStockG.GetGINReturnManualByGOUT(Stroutno, clsUser.UserID)
        If dt.Rows.Count > 0 Then
            Call BindDataGoutReturn(dt)
            Call BindDataText(dt)

        End If

    End Function

    Private Sub BindDataGoutReturn(ByVal dt As DataTable)
        Dim config As New clsConfig
        If txtOutNo.Text = "" Then Exit Sub

        Call BindGrid(grdData, (New classStockG).GetGINReturnmanual("", clsUser.UserID))


        grdData.AutoGenerateColumns = False
        If dt.Rows.Count > 0 Then
            Dim dt1 As DataTable = dt
            Dim dt2 As DataTable = grdData.DataSource
            'Dim dt2 As DataTable = grdData.DataSource

            Dim dr As DataRow
            Dim msg As String = ""
            Dim i As Integer = 0
            Dim j As Integer = 0
            For i = 0 To dt1.Rows.Count - 1
                dr = dt2.NewRow
                For j = 0 To dt2.Columns.Count - 1
                    dr("selected") = dt1.Rows(i)("selected")
                    dr("design_no") = dt1.Rows(i)("design_no")
                    dr("roll_no") = dt1.Rows(i)("roll_no_g")
                    dr("roll_no_o") = dt1.Rows(i)("roll_no_o")
                    dr("roll_no_f") = dt1.Rows(i)("roll_no_f")
                    'dr("col") = dt1.Rows(i)("col")
                    dr("col") = dt1.Rows(i)("col")
                    'dr("custcolor") = dt1.Rows(i)("custcolor")
                    dr("grade") = dt1.Rows(i)("grade")
                    'dr("lot") = dt1.Rows(i)("lot")
                    'dr("gwth") = dt1.Rows(i)("gwth")
                    dr("kg") = dt1.Rows(i)("kg")
                    dr("mts") = dt1.Rows(i)("mts")
                    dr("yds") = dt1.Rows(i)("yds")
                    dr("mtkg") = dt1.Rows(i)("mtkg")  'For Cal
                Next
                dt2.Rows.Add(dr)
            Next
        End If
    End Sub
    Private Sub BindDataText(ByVal dt As DataTable)
        If dt.Rows.Count > 0 Then
            txtOutNo.Text = dt.Rows(0)("outno")
            If Not clsConfig.IsNull(dt.Rows(0)("outdt"), "1900-01-01 00:00:00.000") = "1900-01-01 00:00:00.000" Then
                dtpoutdt.Value = dt.Rows(0)("outdt")
                dtpoutdt.Checked = True
            Else
                dtpoutdt.Value = "1900-01-01 00:00:00.000"
                dtpoutdt.Checked = False
            End If

            txtGinno.Text = dt.Rows(0)("tran_no").ToString.Trim

            If Not clsConfig.IsNull(dt.Rows(0)("tran_dt"), "1900-01-01 00:00:00.000") = "1900-01-01 00:00:00.000" Then
                dtpGINDate.Value = CDate(dt.Rows(0)("tran_dt").ToString)
                dtpGINDate.Checked = True
            Else
                dtpGINDate.Value = CDate(Now())
                dtpGINDate.Checked = True
            End If

            txtsource_refno.Text = dt.Rows(0)("source_refno").ToString.Trim

        Else
            txtOutNo.Text = ""
            dtpoutdt.Value = CDate(Now())
            txtGinno.Text = ""
            dtpGINDate.Value = CDate(Now())
            txtsource_refno.Text = ""
        End If


    End Sub
    Private Sub btncopy_Click(sender As System.Object, e As System.EventArgs) Handles btncopy.Click
        GetcopyRollNo()
    End Sub
    Private Function GetcopyRollNo() As Boolean

        Dim dt1 As DataTable = grdData.DataSource
        Dim dtc As DataTable = grdData.DataSource
        Dim newrow As DataRow
        If grdData.Rows.Count > 0 Then

            newrow = dtc.NewRow

            newrow.Item("suppcd") = grdData.CurrentRow.Cells("suppcd").Value 'Don't show
            newrow.Item("source_refno") = grdData.CurrentRow.Cells("source_refno").Value
            newrow.Item("dfno") = grdData.CurrentRow.Cells("dfno").Value 'Don't show
            newrow.Item("design_no") = grdData.CurrentRow.Cells("design_no").Value
            newrow.Item("gwth") = grdData.CurrentRow.Cells("gwth").Value
            newrow.Item("col") = grdData.CurrentRow.Cells("col").Value
            newrow.Item("roll_no") = grdData.CurrentRow.Cells("roll_no").Value
            newrow.Item("roll_no_o") = grdData.CurrentRow.Cells("roll_no_o").Value
            newrow.Item("sono") = grdData.CurrentRow.Cells("sono").Value 'Don't show
            newrow.Item("sonoid") = grdData.CurrentRow.Cells("sonoid").Value 'Don't show
            newrow.Item("kg") = grdData.CurrentRow.Cells("kg").Value
            newrow.Item("mts") = grdData.CurrentRow.Cells("mts").Value
            newrow.Item("yds") = grdData.CurrentRow.Cells("yds").Value
            newrow.Item("lot") = grdData.CurrentRow.Cells("lot").Value
            newrow("roll_no_f") = grdData.CurrentRow.Cells("roll_no_f").Value 'Don't show
            newrow.Item("mcno") = grdData.CurrentRow.Cells("mcno").Value 'Don't show
            newrow.Item("kono") = grdData.CurrentRow.Cells("kono").Value 'Don't show
            newrow.Item("grade") = grdData.CurrentRow.Cells("grade").Value
            'newrow.Item("ProdFinishDate") = grdData.CurrentRow.Cells("ProdFinishDate").Value
            'newrow.Item("ProdFinishTime") = grdData.CurrentRow.Cells("ProdFinishTime").Value

            'comm.Parameters.AddWithValue("@suppcd", config.IsNull(.Item(j)("suppcd"), "").Trim)

            'dr("suppcd") = dt1.Rows(i)("suppcd")
            'dr("source_refno") = dt1.Rows(i)("source_refno")
            'dr("dfno") = dt1.Rows(i)("dfno")
            'dr("design_no") = dt1.Rows(i)("design_no")
            'dr("gwth") = dt1.Rows(i)("gwth")
            'dr("col") = dt1.Rows(i)("col")
            'dr("roll_no_o") = dt1.Rows(i)("roll_no_o")
            'dr("sonoid") = dt1.Rows(i)("sonoid")
            'dr("kg") = dt1.Rows(i)("kg")
            'dr("mts") = dt1.Rows(i)("mts")
            ' dr("yds") = dt1.Rows(i)("yds")
            'dr("lot") = dt1.Rows(i)("lot")
            'dr("roll_no_f") = dt1.Rows(i)("roll_no_f")
            ' dr("mcno") = dt1.Rows(i)("mcno")
            'dr("kono") = dt1.Rows(i)("kono")
            'dr("grade") = dt1.Rows(i)("grade")
            'dr("ProdFinishDate") = dt1.Rows(i)("ProdFinishDate")
            'dr("ProdFinishTime") = dt1.Rows(i)("ProdFinishTime")



            dtc.Rows.Add(newrow)

            Return True


        End If

        Return False

    End Function

    Private Sub txtOutNo_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtOutNo.TextChanged

    End Sub

    Private Sub frmStockGReturn_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        GenCboGINReturnNo()
        btnNew_Click(sender, e)
    End Sub
    Private Sub GenCboGINReturnNo()
        'Dim objDB As New classStockD
        Dim objDB As New classStockG
        cboGinNo.ComboBox.DataSource = objDB.GetCBOGINReturnManualNo()
        cboGinNo.ComboBox.DisplayMember = "tran_no"
        cboGinNo.ComboBox.ValueMember = "tran_no"

    End Sub

    Private Sub btnNew_Click(sender As System.Object, e As System.EventArgs) Handles btnNew.Click
        InitControl()
    End Sub
    Private Sub InitControl()
        txtGINNo.Text = ""
        dtpGINDATE.Value = Today
        txtOutNo.Text = ""


        txtsource_refno.Text = ""
        Call BindGrid(grdData, (New classStockG).GetGINReturnmanual("", clsUser.UserID))


    End Sub

    Private Sub BindGrid(ByRef grd As DataGridView, ByVal dt As DataTable)
        grd.AutoGenerateColumns = False
        grd.DataSource = dt
    End Sub

    Private Sub cboGinNo_Click(sender As System.Object, e As System.EventArgs) Handles cboGinNo.Click

    End Sub

    Private Sub cboGinNo_DropDownClosed(sender As Object, e As System.EventArgs) Handles cboGinNo.DropDownClosed
        If clsConfig.IsNull(cboGinNo.SelectedItem, "").ToString.Length = 0 Then
            Call getGINReturnManual(clsConfig.IsNull(cboGinNo.ComboBox.SelectedValue, ""))
        End If
    End Sub

    Private Sub GetGINReturnManual(Optional ByRef StrGINNO As String = "", Optional ByRef StrUserID As String = "")

        Dim DBStockG As New classStockG
        Dim dt As DataTable = DBStockG.GetGINReturnmanual(StrGINNO, StrUserID)
        If dt.Rows.Count > 0 Then
            BindDataGrid(dt)
            BindDataText(dt:=dt)
        End If

    End Sub
    Private Sub BindDataGrid(ByRef dt As DataTable)

        grdData.AutoGenerateColumns = False
        grdData.DataSource = dt

    End Sub

    Private Sub btnSave_Click(sender As System.Object, e As System.EventArgs) Handles btnSave.Click
        Call SaveData()
    End Sub
    Private Sub SaveData()
        'Try
        'If MsgBox("Are you sure to Save ?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
        If SaveGINReturnManual() Then
            Call GenCboGINReturnNo()
            Call GetGINReturnManual(clsConfig.IsNull(txtGinno.Text.Trim, ""))

        End If
        'Catch ex As Exception
        'MsgBox("มีข้อผิดพลาดเกี่ยวกับการบันทึกข้อมูลครับ", MsgBoxStyle.Critical, "Insertdata Fail")
        'End Try     '
    End Sub

    Private Function SaveGINReturnManual(Optional ByVal strGINNO As String = "") As Boolean
        Dim config As New clsConfig
        config.ChangeCulture()
        Dim objDB As New classStockG
        Dim Greige_Header As New classStockG.Greige_Header
        Dim msgerr As String = ""
        Dim Tran_no As String = strGINNO


        Greige_Header.h01_suppcd = ""
        Greige_Header.h02_source = ""
        Greige_Header.h03_source_refno = txtsource_refno.Text.Trim
        Greige_Header.h04_tran_no = txtGinno.Text
        Greige_Header.h05_tran_dt = dtpGINDate.Value

        Greige_Header.h25_loc = "NEW"
        Greige_Header.h52_doctyp = "K"
        Greige_Header.h53_preseted = "0"
        Greige_Header.h29_outno = txtOutNo.Text.Trim
        If dtpoutdt.Checked = True Then
            Greige_Header.h30_outdt = CDate(dtpoutdt.Value)
        Else
            Greige_Header.h30_outdt = Nothing
        End If

        Greige_Header.h70_tran_type = "RETURN"

        Dim dtc As New DataTable
        'Dim dt1 As New DataTable
        Dim dr As DataRow

        'dtc = grdData.DataSource
        dtc.Rows.Clear()
        dr = dtc.NewRow
        For i = 0 To grdData.Rows.Count - 1

            If Me.grdData.Rows(i).Cells("selected").Value = True Then
                dr("design_no") = grdData.Rows(i).Cells("design_no")
                dr("roll_no") = grdData.Rows(i).Cells("roll_no_g")
                dr("roll_no_o") = grdData.Rows(i).Cells("roll_no_o")
                dr("roll_no_f") = grdData.Rows(i).Cells("roll_no_f")
                dr("col") = grdData.Rows(i).Cells("col")
                dr("custcolor") = grdData.Rows(i).Cells("custcolor")
                dr("grade") = grdData.Rows(i).Cells("grade")
                dr("lot") = grdData.Rows(i).Cells("lot")
                dr("gwth") = grdData.Rows(i).Cells("gwth")
                dr("kg") = grdData.Rows(i).Cells("kg")
                dr("mts") = grdData.Rows(i).Cells("mts")
                dr("yds") = grdData.Rows(i).Cells("yds")
                dr("mtkg") = grdData.Rows(i).Cells("mtkg")
                dtc.Rows.Add(dr)
            End If

        Next


        'For i = 0 To dt1.Rows.Count - 1
        '    dr = dt2.NewRow
        '    For j = 0 To dt2.Columns.Count - 1
        '        dr("design_no") = dt1.Rows(i)("design_no")
        '        dr("roll_no") = dt1.Rows(i)("roll_no_g")
        '        dr("roll_no_o") = dt1.Rows(i)("roll_no_o")
        '        dr("roll_no_f") = dt1.Rows(i)("roll_no_f")
        '        'dr("col") = dt1.Rows(i)("col")
        '        dr("col") = dt1.Rows(i)("col")
        '        'dr("custcolor") = dt1.Rows(i)("custcolor")
        '        dr("grade") = dt1.Rows(i)("grade")
        '        'dr("lot") = dt1.Rows(i)("lot")
        '        'dr("gwth") = dt1.Rows(i)("gwth")
        '        dr("kg") = dt1.Rows(i)("kg")
        '        dr("mts") = dt1.Rows(i)("mts")
        '        dr("yds") = dt1.Rows(i)("yds")
        '        dr("mtkg") = dt1.Rows(i)("mtkg")  'For Cal
        '    Next
        '    dt2.Rows.Add(dr)
        'Next
        ' Dim dtc As DataTable = grdData.DataSource

        Dim dv_dtc_add As New DataView(dtc, "", "", DataViewRowState.Added)
        Dim dv_dtc_upd As New DataView(dtc, "", "", DataViewRowState.ModifiedCurrent)
        Dim dv_dtc_del As New DataView(dtc, "", "", DataViewRowState.Deleted)

        blnCancel = False
        Dim result As DialogResult
        result = MessageBox.Show("Would you like to save ?", "System Message", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button3)
        If result = DialogResult.Cancel Then blnCancel = True
        If result <> DialogResult.Yes Then Exit Function

        If objDB.GinReturnManualsave(Greige_Header, msgerr, dtc, dv_dtc_add, dv_dtc_upd, dv_dtc_del, clsUser.UserID, Tran_no) Then
            strGINNO = Tran_no
            txtGinno.Text = strGINNO.Trim
            '    'strPacking_no = PLGNo
            '    'btngout.Enabled = True
            MessageBox.Show("Save is Complete! : บันทึกสำเร็จ! ", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
            SaveGINReturnManual = True

        Else
            SaveGINReturnManual = False
            MessageBox.Show(msgerr, "System Message", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
        End If

    End Function

    Private Sub btnExit_Click(sender As System.Object, e As System.EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
    Private Sub frmStockGReturn_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If MessageBox.Show("Would you like to close ?", "System Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.No Then
            e.Cancel = True
        End If
    End Sub

    

    Private Sub btnPrint_Click(sender As System.Object, e As System.EventArgs) Handles btnPrint.Click
        'print
        Dim clsConn As New classConnection

        If txtGinno.Text = "" Then Exit Sub
        Const rptFileName = "rptGIN.rpt"
        
        If Not clsConfig.CheckReport(clsUser.ReportPath, rptFileName) Then Exit Sub
        Dim frm As New frmReport
        Dim rpt As New CrystalDecisions.CrystalReports.Engine.ReportDocument
        Me.Cursor = Cursors.WaitCursor

        rpt.Load(clsUser.ReportPath & rptFileName)
        rpt.DataSourceConnections.Item(0).SetConnection(clsConn.servername, clsConn.database, False)
        rpt.DataSourceConnections.Item(0).SetLogon(clsConn.Userid, clsConn.Password)

        rpt.VerifyDatabase()
        rpt.SetParameterValue("@trannofr", txtGinno.Text)
        rpt.SetParameterValue("@trannoto", txtGinno.Text)

        'rpt.PrintOptions.PaperSize = CrystalDecisions.Shared.PaperSize.PaperLetter
        'rpt.PrintOptions.PaperOrientation = CrystalDecisions.Shared.PaperOrientation.Portrait
        'rpt.PrintOptions.PaperSource = CrystalDecisions.Shared.PaperSource.Auto

        frm.Title = "Greige In"
        frm.CRViewer.ReportSource = rpt
        frm.MdiParent = Me.ParentForm
        frm.Show()
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub btnCancel_Click(sender As System.Object, e As System.EventArgs) Handles btnCancel.Click
        Canceldata()
    End Sub
    Private Sub Canceldata()

        If CancelGINRETURN() Then
            InitControl()
            GenCboGINReturnNo()
        Else

            Exit Sub
        End If

    End Sub
    Public Function CancelGINRETURN(Optional ByVal strGINNO As String = "") As Boolean
        Dim config As New clsConfig
        config.ChangeCulture()
        Dim objDB As New classStockG
        Dim Greige_Header As New classStockG.Greige_Header
        Dim msgerr As String = ""
        Dim Tran_no As String = strGINNO


        Greige_Header.h01_suppcd = ""
        Greige_Header.h02_source = ""
        Greige_Header.h03_source_refno = ""
        Greige_Header.h04_tran_no = txtGinno.Text
        Greige_Header.h05_tran_dt = dtpGINDate.Value

        Dim dtc As DataTable = grdData.DataSource

        Dim dv_dtc_add As New DataView(dtc, "", "", DataViewRowState.Added)
        Dim dv_dtc_upd As New DataView(dtc, "", "", DataViewRowState.ModifiedCurrent)
        Dim dv_dtc_del As New DataView(dtc, "", "", DataViewRowState.Deleted)

        'Dim dts As DataTable = ds.Tables("v_strolls_d")
        'Dim dv_dts_add As New DataView(dts, "", "", DataViewRowState.Added)
        'Dim dv_dts_upd As New DataView(dts, "", "", DataViewRowState.ModifiedCurrent)
        'Dim dv_dts_del As New DataView(dts, "", "", DataViewRowState.Deleted)

        blnCancel = False
        Dim result As DialogResult
        result = MessageBox.Show("Would you like to cancel document no. " & txtGinno.Text & " ?", "System Message", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button3)
        If result = DialogResult.Cancel Then blnCancel = True
        If result <> DialogResult.Yes Then Exit Function

        If objDB.GINRETURNcancel(Greige_Header, msgerr, dtc, dv_dtc_add, dv_dtc_upd, dv_dtc_del, clsUser.UserID, Tran_no) Then
            strGINNO = Tran_no
            txtGinno.Text = strGINNO.Trim
            '    'strPacking_no = PLGNo
            '    'btngout.Enabled = True
            MessageBox.Show("Cancel is Complete! : ยกเลิกสำเร็จ! ", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
            CancelGINRETURN = True

        Else
            CancelGINRETURN = False
            MessageBox.Show(msgerr, "System Message", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
        End If



    End Function

    Private Sub grdData_CellContentClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles grdData.CellContentClick

    End Sub

    'Private Sub grdData_CellValueChanged(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles grdData.CellValueChanged
    '    Dim config As New clsConfig

    '    If grdData.Columns(e.ColumnIndex).Name = "mts" Then
    '        grdData.Rows(e.RowIndex).Cells("yds").Value = FormatNumber(config.IsNull(grdData.Rows(e.RowIndex).Cells("mts").Value, 0) / 0.9144, 2, TriState.False, TriState.False, TriState.True)

    '    End If
    '    If grdData.Columns(e.ColumnIndex).Name = "yds" Then
    '        'grdData.Rows(e.RowIndex).Cells("mts").Value = FormatNumber(config.IsNull(grdData.Rows(e.RowIndex).Cells("mts").Value, 0), 2, TriState.False, TriState.False, TriState.True)

    '        grdData.Rows(e.RowIndex).Cells("mts").Value = FormatNumber(config.IsNull(grdData.Rows(e.RowIndex).Cells("yds").Value, 0) * 0.9144, 2, TriState.False, TriState.False, TriState.True)

    '    End If

    'End Sub

    Private Sub grdData_CellValueChanged(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles grdData.CellValueChanged
        If e.RowIndex < 0 Or e.ColumnIndex < 0 Then Exit Sub
        If grdData.Columns(e.ColumnIndex).Name = "kg" Or _
         grdData.Columns(e.ColumnIndex).Name = "yds" Or _
         grdData.Columns(e.ColumnIndex).Name = "mts" Then
            If CBool(chkAutoCalculate.Checked) Then
                Dim dt As DataTable = grdData.DataSource
                Dim i As Integer = CheckDelRow(dt)
                If clsConfig.IsNull(Val(dt.Rows(e.RowIndex + i)("mtkg")), 0) = 0 Then MessageBox.Show("Design No." & vbCrLf & Val(dt.Rows(e.RowIndex + i)("Design_No")) & vbCrLf & "ไม่ได้ใส่ MT/KG", "SyStem Message", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1)
                If grdData.Columns(e.ColumnIndex).Name = "kg" Then
                    If Val(dt.Rows(e.RowIndex + i)("mtkg")) > 0 Then dt.Rows(e.RowIndex + i)("mts") = FormatNumber(dt.Rows(e.RowIndex + i)("kg") * dt.Rows(e.RowIndex + i)("mtkg"), 2, TriState.False, TriState.False, TriState.False)
                    If Val(dt.Rows(e.RowIndex + i)("mtkg")) > 0 Then dt.Rows(e.RowIndex + i)("yds") = FormatNumber(dt.Rows(e.RowIndex + i)("kg") * dt.Rows(e.RowIndex + i)("mtkg") / 0.9144, 2, TriState.False, TriState.False, TriState.False)
                End If
                If grdData.Columns(e.ColumnIndex).Name = "mts" Then
                    If Val(dt.Rows(e.RowIndex + i)("mtkg")) > 0 Then dt.Rows(e.RowIndex + i)("yds") = FormatNumber(dt.Rows(e.RowIndex + i)("mts") / 0.9144, 2, TriState.False, TriState.False, TriState.False)
                    If Val(dt.Rows(e.RowIndex + i)("mtkg")) > 0 Then dt.Rows(e.RowIndex + i)("kg") = FormatNumber(dt.Rows(e.RowIndex + i)("mts") / dt.Rows(e.RowIndex + i)("mtkg"), 2, TriState.False, TriState.False, TriState.False)
                End If
                If grdData.Columns(e.ColumnIndex).Name = "yds" Then
                    If Val(dt.Rows(e.RowIndex + i)("mtkg")) > 0 Then dt.Rows(e.RowIndex + i)("kg") = FormatNumber(dt.Rows(e.RowIndex + i)("yds") / dt.Rows(e.RowIndex + i)("mtkg") * 0.9144, 2, TriState.False, TriState.False, TriState.False)
                    If Val(dt.Rows(e.RowIndex + i)("mtkg")) > 0 Then dt.Rows(e.RowIndex + i)("mts") = FormatNumber(dt.Rows(e.RowIndex + i)("kg") * dt.Rows(e.RowIndex + i)("mtkg"), 2, TriState.False, TriState.False, TriState.False)
                End If

            End If
            Call SumGrid()
        End If
    End Sub
    Private Sub TextBox1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtsource_refno.KeyPress
        Select Case Asc(e.KeyChar)
            Case 48 To 57 ' key โค๊ด ของตัวเลขจะอยู่ระหว่าง48-57ครับ 48คือเลข0 57คือเลข9ตามลำดับ
                e.Handled = False
            Case 8, 13, 46 ' ปุ่ม Backspace = 8,ปุ่ม Enter = 13, ปุ่มDelete = 46
                e.Handled = False

            Case Else
                e.Handled = True
                MessageBox.Show("สามารถกดได้แค่ตัวเลข")
        End Select

    End Sub

    Private Function CheckDelRow(ByVal dt As DataTable) As Integer
        Dim i As Integer = 0
        Dim j As Integer = 0
        For i = 0 To dt.Rows.Count - 1
            If dt.Rows(i).RowState = DataRowState.Deleted Then j = j + 1
        Next
        Return j
    End Function

    Private Sub SumGrid()
        Dim i As Integer = 0
        Dim rolls As Integer = 0
        Dim kgs As Double = 0
        Dim yds As Double = 0
        Dim mts As Double = 0
        Dim dt As DataTable = grdData.DataSource
        For i = 0 To dt.Rows.Count - 1
            If dt.Rows(i).RowState <> DataRowState.Deleted Then
                rolls = rolls + 1
                kgs = kgs + clsConfig.IsNull(dt.Rows(i)("kg"), 0)
                yds = yds + clsConfig.IsNull(dt.Rows(i)("yds"), 0)
                mts = mts + clsConfig.IsNull(dt.Rows(i)("mts"), 0)
            End If
        Next
        txtSelectedRolls.Text = Format(rolls, "#,###")
        txtSelectedKgs.Text = Format(kgs, "#,###.#0")
        txtSelectedYds.Text = Format(yds, "#,###.#0")
        txtSelectedMts.Text = Format(mts, "#,###.#0")
    End Sub

    'Private Sub chkAutoCalculate_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles chkAutoCalculate.CheckedChanged
    '    If CBool(chkAutoCalculate.Checked) Then
    '        Call grdData_CellValueChanged(sender, e)
    '    ElseIf chkAutoCalculate.Checked = False Then

    '    End If
    'End Sub

    Private Sub grdData_CurrentCellDirtyStateChanged(sender As Object, e As System.EventArgs) Handles grdData.CurrentCellDirtyStateChanged
        If grdData.IsCurrentCellDirty Then
            grdData.CommitEdit(DataGridViewDataErrorContexts.Commit)
        End If
    End Sub
End Class