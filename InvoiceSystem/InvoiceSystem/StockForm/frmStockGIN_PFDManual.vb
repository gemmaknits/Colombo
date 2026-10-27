Public Class frmStockGIN_PFDManual
    Dim clsConfig As New clsConfig
    Dim clsConn As New classConnection
    Dim clsUser As New classUserInfo
    Dim blnLocked As Boolean = False
    Dim blnCancel As Boolean = False



    Public Property UserInfo() As classUserInfo
        Get
            UserInfo = clsUser
        End Get
        Set(ByVal NewValue As classUserInfo)
            clsUser = NewValue
        End Set
    End Property

    Private Sub InitControl()
        txtGINNo.Text = ""
        dtpGINDATE.Value = Today

        txtDFNo.Text = ""
        'txtLot.Text = ""
        'txtsource_refno.Text = ""
        txtRemark.Text = ""
        Call BindGrid(grdData, (New classStockG).GetGINPFDmanual("", clsUser.UserID))

        txtDFNo.Focus()
        'Call BindGrid(grdData, (New classStockG).get("", clsUser.UserID))
    End Sub

    Private Sub BindGrid(ByRef grd As DataGridView, ByVal dt As DataTable)
        grd.AutoGenerateColumns = False
        grd.DataSource = dt
    End Sub
    Private Sub frmStockGIN_PFDManual_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        GenCboGINPFDNo()
        btnNew_Click(sender, e)
    End Sub
    Private Sub GenCboGINPFDNo()
        'Dim objDB As New classStockD
        Dim objDB As New classStockG
        cboGINPFDNo.ComboBox.DataSource = objDB.GetCBOGINPFDmanualNo()
        cboGINPFDNo.ComboBox.DisplayMember = "tran_no"
        cboGINPFDNo.ComboBox.ValueMember = "tran_no"

    End Sub
    Private Sub btnSearchColNo_Click(sender As System.Object, e As System.EventArgs)
        Dim frm As New frmSearchPO
        frm.ShowDialog(Me)



    End Sub

    Private Sub txtDFNo_TextChanged(sender As System.Object, e As System.EventArgs)

    End Sub

    Private Sub btnNew_Click(sender As System.Object, e As System.EventArgs) Handles btnNew.Click
        InitControl()
    End Sub

    Private Sub btnSearchDFNo_Click(sender As System.Object, e As System.EventArgs) Handles btnSearchDFNo.Click
        Dim frm As New frmSearchDFOrderPreset
        frm.ShowDialog(Me)
        txtDFNo.Text = (frm.pDFNo)
        Me.Cursor = Cursors.WaitCursor
        If Not blnCancel Then GetDForder(txtDFNo.Text)
        Me.Cursor = Cursors.Default
        frm.Dispose()
    End Sub
    Private Function GetDForder(ByVal strDfNo As String) As Boolean
        Dim dbStockD As New classStockG

        Dim dt As DataTable = dbStockD.GetDForder_Items(strDfNo, clsUser.UserID)
        If dt.Rows.Count > 0 Then
            Call BinddataDF(dt)
            Call BindDataDForder_items(dt)

            Return True
        End If
        Return False
    End Function
    Private Sub BinddataDF(ByVal dt As DataTable)
        ' txtDINNo.Text = dt.Rows(0)("dinno")
        ' dtpDINDate.Value = CDate(dt.Rows(0)("dindt"))
        txtDFNo.Text = dt.Rows(0)("dfno")
        'txtLot.Text = dt.Rows(0)("lot").ToString.Trim

        ' txtBillNo.Text = dt.Rows(0)("dono")
        txtRemark.Text = dt.Rows(0)("rem_qc")
    End Sub
    Private Sub BindDataDForder_items(ByVal dt As DataTable)
        Dim config As New clsConfig
        If txtDFNo.Text = "" Then Exit Sub
        Dim k As Integer = 0

        grdData.AutoGenerateColumns = False
        If dt.Rows.Count > 0 Then
            Dim dt1 As DataTable = dt
            Dim dt2 As DataTable = grdData.DataSource

            Dim dr As DataRow

            Dim msg As String = ""
            Dim i As Integer = 0
            Dim j As Integer = 0
            For i = 0 To dt.Rows.Count - 1

                'If dt1.Rows(i)("dfno") = dt2.Rows(i)("dfno") Then Exit Sub

                dr = dt2.NewRow

                For j = 0 To dt2.Columns.Count - 1

                    dr(j) = dt1.Rows(i)(j)

                    'dr("suppcd") = dt1.Rows(i)("suppcd")
                    'dr("source_refno") = dt1.Rows(i)("source_refno")
                    'dr("dfno") = dt1.Rows(i)("dfno")
                    'dr("design_no") = dt1.Rows(i)("design_no")
                    'dr("gwth") = dt1.Rows(i)("gwth")
                    ''dr("fwth") = dt1.Rows(i)("fwth")
                    'dr("col") = dt1.Rows(i)("col")
                    ''dr("gr") = dt1.Rows(i)("gr")
                    ''dr("custcolor") = dt1.Rows(i)("custcolor")
                    ''dr("roll_no_d") = dt1.Rows(i)("roll_no_d")
                    'dr("roll_no_o") = dt1.Rows(i)("roll_no_o")
                    'dr("sonoid") = dt1.Rows(i)("sonoid")
                    'dr("kg") = dt1.Rows(i)("kg")
                    'dr("mts") = dt1.Rows(i)("mts")
                    'dr("yds") = dt1.Rows(i)("yds")
                    'dr("lot") = dt1.Rows(i)("lot")
                    ''dr("rem_qc") = dt1.Rows(i)("rem_qc") source_refno
                    'dr("roll_no_f") = dt1.Rows(i)("roll_no_f")
                    'dr("mcno") = dt1.Rows(i)("mcno")
                    'dr("kono") = dt1.Rows(i)("kono")
                    'dr("grade") = dt1.Rows(i)("grade")
                    'dr("ProdFinishDate") = dt1.Rows(i)("ProdFinishDate")
                    'dr("ProdFinishTime") = dt1.Rows(i)("ProdFinishTime")
                    'dr("rem_qc") = dt1.Rows(i)("rem_qc")


                Next
                dt2.Rows.Add(dr)

            Next

        End If

        'SumGrdData()



    End Sub

    Private Sub txtDFNo_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtDFNo.KeyPress

    End Sub


    Private Sub txtDFNo_TextChanged_1(sender As System.Object, e As System.EventArgs) Handles txtDFNo.TextChanged

    End Sub

    Private Sub cboGINPFDNo_Click(sender As System.Object, e As System.EventArgs) Handles cboGINPFDNo.Click

    End Sub

    Private Sub cboGINPFDNo_DropDownClosed(sender As Object, e As System.EventArgs) Handles cboGINPFDNo.DropDownClosed
        If clsConfig.IsNull(cboGINPFDNo.SelectedItem, "").ToString.Length = 0 Then
            Call getGINPFDManual(clsConfig.IsNull(cboGINPFDNo.ComboBox.SelectedValue, ""))
        End If
    End Sub

    Function getGINPFDManual(ByRef strGINNO As String) As Boolean
        Dim dbStockG As New classStockG
        Dim dt As DataTable = dbStockG.GetGINPFDmanual(strGINNO, clsUser.UserID)
        If dt.Rows.Count > 0 Then
            'Dev By Neung 26/03/2015
            Call BindGINManual(dt)
            Return True
        End If
        Return False

    End Function

    Private Sub BindGINManual(ByVal dt As DataTable)
        Dim config As New clsConfig
        Dim i As Integer = 0
        Dim j As Integer = 0

        grdData.AutoGenerateColumns = False
        grdData.DataSource = dt

        txtGINNo.Text = dt.Rows(0)("tran_no").ToString.Trim
        dtpGINDATE.Value = CDate(dt.Rows(0)("tran_dt").ToString)

        txtDFNo.Text = dt.Rows(0)("dfno").ToString.Trim()

        'txtsource_refno.Text = dt.Rows(0)("source_refno").ToString.Trim()

        'txtDINNo.Text = dt.Rows(0)("dinno").ToString.Trim()

        ' txtLot.Text = dt.Rows(0)("lot").ToString.Trim()
        'dtpDINDate.Value = CDate(dt.Rows(0)("dindt").ToString)
        'dtpdodt.Value = config.IsNull(dt.Rows(0)("dodt"), Now)
        ' txtRemark.Text = dt.Rows(0)("rem_qc")

        'Dim dtt As DataTable = grdData.DataSource
        ' txttest.DataBindings.Add("", dt, "lot")

        'SumGrdData()

    End Sub


    Private Sub btnSave_Click(sender As System.Object, e As System.EventArgs) Handles btnSave.Click
        'If MessageBox.Show("Would you like to save ?", "System Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then Call SaveData(txtDFNo.Text.Trim)
        Call SaveData()
    End Sub
    Private Sub SaveData()
        Try
            'If MsgBox("Are you sure to Save ?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            If SaveGINPFD() Then
                Call GenCboGINPFDNo()
                Call getGINPFDManual(clsConfig.IsNull(txtGINNo.Text.Trim, ""))

            End If
            'End If
        Catch ex As Exception
            MsgBox("มีข้อผิดพลาดเกี่ยวกับการบันทึกข้อมูลครับ", MsgBoxStyle.Critical, "Insertdata Fail")
        End Try     '

        'Dim objDB As New classStockG
        'Dim dt As New DataTable
        'dt = objDB.SaveGINPFDManual(dfno, clsUser.UserID)
        'Call InitControl()
        ''If dt.Rows.Count > 0 Then Call BindData(dt)
        'Call BindGrid(grdData, dt)
    End Sub

    Private Function SaveGINPFD(Optional ByVal strGINNO As String = "") As Boolean
        Dim config As New clsConfig
        config.ChangeCulture()
        Dim objDB As New classStockG
        Dim Greige_Header As New classStockG.Greige_Header
        Dim msgerr As String = ""
        Dim Tran_no As String = strGINNO


        Greige_Header.h01_suppcd = ""
        Greige_Header.h02_source = ""
        Greige_Header.h03_source_refno = ""
        Greige_Header.h04_tran_no = txtGINNo.Text
        Greige_Header.h05_tran_dt = dtpGINDATE.Value

        Greige_Header.h25_loc = "NEW"

        Greige_Header.h53_preseted = "1"

        Greige_Header.h70_tran_type = "PRESET"



        Dim dtc As DataTable = grdData.DataSource

        'Dim i = 0
        'For i = 0 To dtc.Rows.Count - 1
        '    With dtc.Rows
        '        If dtc.Rows(i)("dono") <> txtBillNo.Text.Trim Then
        '            dtc.Rows(i)("dono") = txtBillNo.Text.Trim
        '            'dt.Rows(0)("dono").ToString.Trim()
        '        End If

        '        ' dtproduction_lots.Rows(i)("mfg_production_lots_id") = dtproduction_lots.Rows(i)("mfg_production_lots_id")

        '    End With
        'Next

        Dim dv_dtc_add As New DataView(dtc, "", "", DataViewRowState.Added)
        Dim dv_dtc_upd As New DataView(dtc, "", "", DataViewRowState.ModifiedCurrent)
        Dim dv_dtc_del As New DataView(dtc, "", "", DataViewRowState.Deleted)

        'Dim dts As DataTable = ds.Tables("v_strolls_d")
        'Dim dv_dts_add As New DataView(dts, "", "", DataViewRowState.Added)
        'Dim dv_dts_upd As New DataView(dts, "", "", DataViewRowState.ModifiedCurrent)
        'Dim dv_dts_del As New DataView(dts, "", "", DataViewRowState.Deleted)

        blnCancel = False
        Dim result As DialogResult
        result = MessageBox.Show("Would you like to save ?", "System Message", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button3)
        If result = DialogResult.Cancel Then blnCancel = True
        If result <> DialogResult.Yes Then Exit Function

        If objDB.GinPFDsave(Greige_Header, msgerr, dtc, dv_dtc_add, dv_dtc_upd, dv_dtc_del, clsUser.UserID, Tran_no) Then
            strGINNO = Tran_no
            txtGINNo.Text = strGINNO.Trim
            '    'strPacking_no = PLGNo
            '    'btngout.Enabled = True
            MessageBox.Show("Save is Complete! : บันทึกสำเร็จ! ", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
            SaveGINPFD = True

        Else
            SaveGINPFD = False
            MessageBox.Show(msgerr, "System Message", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
        End If

    End Function

    Private Sub btnCancel_Click(sender As System.Object, e As System.EventArgs) Handles btnCancel.Click
        Call Canceldata()
    End Sub
    Private Sub Canceldata()

        If CancelGINPFD() Then
            InitControl()
            GenCboGINPFDNo()
        Else

            Exit Sub
        End If

    End Sub
    Public Function CancelGINPFD(Optional ByVal strGINNO As String = "") As Boolean
        Dim config As New clsConfig
        config.ChangeCulture()
        Dim objDB As New classStockG
        Dim Greige_Header As New classStockG.Greige_Header
        Dim msgerr As String = ""
        Dim Tran_no As String = strGINNO


        Greige_Header.h01_suppcd = ""
        Greige_Header.h02_source = ""
        Greige_Header.h03_source_refno = ""
        Greige_Header.h04_tran_no = txtGINNo.Text
        Greige_Header.h05_tran_dt = dtpGINDATE.Value

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
        result = MessageBox.Show("Would you like to cancel document no. " & txtGINNo.Text & " ?", "System Message", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button3)
        If result = DialogResult.Cancel Then blnCancel = True
        If result <> DialogResult.Yes Then Exit Function

        If objDB.GINPFDcancel(Greige_Header, msgerr, dtc, dv_dtc_add, dv_dtc_upd, dv_dtc_del, clsUser.UserID, Tran_no) Then
            strGINNO = Tran_no
            txtGINNo.Text = strGINNO.Trim
            '    'strPacking_no = PLGNo
            '    'btngout.Enabled = True
            MessageBox.Show("Cancel is Complete! : ยกเลิกสำเร็จ! ", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
            CancelGINPFD = True

        Else
            CancelGINPFD = False
            MessageBox.Show(msgerr, "System Message", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
        End If



    End Function

    Private Sub btnPrint_Click(sender As System.Object, e As System.EventArgs) Handles btnPrint.Click
        'print
        If txtGINNo.Text = "" Then Exit Sub
        Const rptFileName = "rptGIN.rpt"
        
        If Not clsConfig.CheckReport(clsUser.ReportPath, rptFileName) Then Exit Sub
        Dim frm As New frmReport
        Dim rpt As New CrystalDecisions.CrystalReports.Engine.ReportDocument
        Me.Cursor = Cursors.WaitCursor

        rpt.Load(clsUser.ReportPath & rptFileName)
        rpt.DataSourceConnections.Item(0).SetConnection(clsConn.servername, clsConn.database, False)
        rpt.DataSourceConnections.Item(0).SetLogon(clsConn.Userid, clsConn.Password)

        rpt.VerifyDatabase()
        rpt.SetParameterValue("@trannofr", txtGINNo.Text)
        rpt.SetParameterValue("@trannoto", txtGINNo.Text)

        'rpt.PrintOptions.PaperSize = CrystalDecisions.Shared.PaperSize.PaperLetter
        'rpt.PrintOptions.PaperOrientation = CrystalDecisions.Shared.PaperOrientation.Portrait
        'rpt.PrintOptions.PaperSource = CrystalDecisions.Shared.PaperSource.Auto

        frm.Title = "Greige In"
        frm.CRViewer.ReportSource = rpt
        frm.MdiParent = Me.ParentForm
        frm.Show()
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub btnExit_Click(sender As System.Object, e As System.EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
    Private Sub frmStockGIN_PFD_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If MessageBox.Show("Would you like to close ?", "System Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.No Then
            e.Cancel = True
        End If
    End Sub

    Private Sub btncopy_Click(sender As System.Object, e As System.EventArgs) Handles btncopy.Click
        GetcopyRollNo()

    End Sub

    Private Function GetcopyRollNo() As Boolean
        Dim dtc As DataTable = grdData.DataSource
        Dim newrow As DataRow
        If grdData.Rows.Count > 0 Then

            newrow = dtc.NewRow

            'newrow.Item("suppcd") = grdData.CurrentRow.Cells("suppcd").Value
            newrow.Item("source_refno") = grdData.CurrentRow.Cells("source_refno").Value
            'newrow.Item("dfno") = grdData.CurrentRow.Cells("dfno").Value
            newrow.Item("design_no") = grdData.CurrentRow.Cells("design_no").Value
            newrow.Item("gwth") = grdData.CurrentRow.Cells("gwth").Value
            newrow.Item("col") = grdData.CurrentRow.Cells("col").Value
            newrow.Item("roll_no_o") = grdData.CurrentRow.Cells("roll_no_o").Value
            newrow.Item("sonoid") = grdData.CurrentRow.Cells("sonoid").Value
            newrow.Item("kg") = grdData.CurrentRow.Cells("kg").Value
            newrow.Item("mts") = grdData.CurrentRow.Cells("mts").Value
            newrow.Item("yds") = grdData.CurrentRow.Cells("yds").Value
            newrow.Item("lot") = grdData.CurrentRow.Cells("lot").Value
            newrow.Item("roll_no_f") = grdData.CurrentRow.Cells("roll_no_f").Value
            newrow.Item("mcno") = grdData.CurrentRow.Cells("mcno").Value
            'newrow.Item("kono") = grdData.CurrentRow.Cells("kono").Value
            newrow.Item("grade") = grdData.CurrentRow.Cells("grade").Value
            newrow.Item("rem_qc") = grdData.CurrentRow.Cells("rem_qc").Value
            'newrow.Item("ProdFinishDate") = grdData.CurrentRow.Cells("ProdFinishDate").Value
            'newrow.Item("ProdFinishTime") = grdData.CurrentRow.Cells("ProdFinishTime").Value

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

    Private Sub grdData_CellContentClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles grdData.CellContentClick

    End Sub

    Private Sub grdData_CellEndEdit(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles grdData.CellEndEdit
   
        Dim config As New clsConfig


        If grdData.Columns(e.ColumnIndex).Name = "mts" Then

            grdData.Rows(e.RowIndex).Cells("yds").Value = FormatNumber(config.IsNull(grdData.Rows(e.RowIndex).Cells("mts").Value, 0) / 0.9144, 4, TriState.False, TriState.False, TriState.True)
        ElseIf grdData.Columns(e.ColumnIndex).Name = "yds" Then
            grdData.Rows(e.RowIndex).Cells("mts").Value = FormatNumber(config.IsNull(grdData.Rows(e.RowIndex).Cells("yds").Value, 0) * 0.9144, 4, TriState.False, TriState.False, TriState.True)

        End If
    End Sub

    Private Sub grdData_CellEnter(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles grdData.CellEnter

        
    End Sub

    Private Sub grdData_CellValueChanged(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles grdData.CellValueChanged
        Dim obj As New classMaster
        Dim clsStockD As New classStockG
        Dim config As New clsConfig
        Dim designNo As String
        'Dim SoNo As String
        If e.RowIndex < 0 Or e.ColumnIndex < 0 Then Exit Sub

        If grdData.Columns(e.ColumnIndex).Name = "design_no" Then
            designNo = grdData.Rows(e.RowIndex).Cells("design_no").Value
            'grdData.Rows(e.RowIndex).Cells("colrefdesno").Value = obj.GetArticle(designNo)
            'grdData.Rows(e.RowIndex).Cells("colgmpersqm").Value = obj.GetGmPerSqm(designNo)
            grdData.Rows(e.RowIndex).Cells("Fwth").Value = obj.GetFWth(designNo)

            ' get article no. and show in grid
        End If

        'If grdData.Columns(e.ColumnIndex).Name = "sono" Then
        ' SoNo = grdData.Rows(e.RowIndex).Cells("sono").Value
        'grdData.Rows(e.RowIndex).Cells("sonoid").Value = clsStockD.GetSoNoId(SoNo, "", clsUser.UserID)

        ' get so no. and show in grid
        'End If

        'If grdData.Columns(e.ColumnIndex).Name = "mts" Then
        '    'grdData.Rows(e.RowIndex).Cells("mts").Value = FormatNumber(config.IsNull(grdData.Rows(e.RowIndex).Cells("mts").Value, 0), 2, TriState.False, TriState.False, TriState.True)

        '    grdData.Rows(e.RowIndex).Cells("yds").Value = FormatNumber(config.IsNull(grdData.Rows(e.RowIndex).Cells("mts").Value, 0) / 0.9144, 4, TriState.False, TriState.False, TriState.True)
        'Else If grdData.Columns(e.ColumnIndex).Name = "yds" Then
        '    'grdData.Rows(e.RowIndex).Cells("mts").Value = FormatNumber(config.IsNull(grdData.Rows(e.RowIndex).Cells("yds").Value, 0) * 0.9144, 2, TriState.False, TriState.False, TriState.True)
        '    grdData.Rows(e.RowIndex).Cells("mts").Value = FormatNumber(config.IsNull(grdData.Rows(e.RowIndex).Cells("yds").Value, 0) * 0.9144, 4, TriState.False, TriState.False, TriState.True)

        'End If

            If grdData.Columns(e.ColumnIndex).Name = "yds" Then
                'grdData.Rows(e.RowIndex).Cells("mts").Value = FormatNumber(config.IsNull(grdData.Rows(e.RowIndex).Cells("yds").Value, 0) * 0.9144, 2, TriState.False, TriState.False, TriState.True)
                'grdData.Rows(e.RowIndex).Cells("mts").Value = FormatNumber(config.IsNull(grdData.Rows(e.RowIndex).Cells("yds").Value, 0) * 0.9144, 2, TriState.False, TriState.False, TriState.True)
            End If

    End Sub
End Class