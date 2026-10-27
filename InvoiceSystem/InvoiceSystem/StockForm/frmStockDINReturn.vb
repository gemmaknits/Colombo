Public Class frmStockDINReturn
    Dim clsconn As New classConnection
    Dim clsconfig As New clsConfig
    Dim clsuser As New classUserInfo

    Dim DbStockD As New classStockDINReturn


    Dim StrDesign_No As String
    Dim StrRollNoD As String
    Dim StrCol As String
    Dim StrCustcol As String
    Dim StrGr As String
    Dim StrBatch As String
    Dim StrFwth As String
    Dim StrKg As String
    Dim StrMts As String
    Dim StrYds As String

    'Dim newrow As DataRow

    Dim StrLot As String

    Dim StrDfNo As String

    Dim blnCancel As Boolean = False

    Public Property Userinfo() As classUserInfo
        Get
            Userinfo = clsuser
        End Get
        Set(ByVal Newvalue As classUserInfo)
            clsuser = Newvalue
        End Set
    End Property
    Private Sub frmDINReturn_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        ' Call GenComboDINReturnNo()
        Call btnNew_Click(sender, e)
    End Sub
    Private Sub InitControl()
        Call GenComboDINReturnNo()
        Call BindDINReturn(grdStockD, (New classStockDINReturn).GetDINReturn("0", clsuser.UserID))

    End Sub
    Private Sub GenComboDINReturnNo()
        Dim objDB As New classStockDINReturn
        cboDinNo.ComboBox.DataSource = objDB.GetComboDINNO()
        cboDinNo.ComboBox.DisplayMember = "dinno"
        cboDinNo.ComboBox.ValueMember = "dinno"
        cboDinNo.ComboBox.SelectedIndex = -1
    End Sub
    Private Sub BindGrid(ByRef grdStockD As DataGridView, ByVal dt As DataTable)
        grdStockD.AutoGenerateColumns = False
        grdStockD.DataSource = dt

        'grdData.AutoGenerateColumns = False
        'grdData.DataSource = dt
    End Sub
    Private Sub txtOutNo_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles txtOutNo.KeyDown
        If e.KeyCode = Keys.Enter Then

            Getoutno(txtOutNo.Text.Trim)

        End If
    End Sub
    Private Function Getoutno(ByRef Stroutno As String) As Boolean
        Dim dt As DataTable = DbStockD.GetDOut_Return(Stroutno, clsuser.UserID)
        If dt.Rows.Count > 0 Then
            Call BindDataDoutReturn(dt)

        End If

    End Function

    Private Sub BindDataDoutReturn(ByVal dt As DataTable)
        Dim config As New clsConfig
        If txtOutNo.Text = "" Then Exit Sub

        'grdStockD.DataSource = New dt

        grdStockD.AutoGenerateColumns = False
        If dt.Rows.Count > 0 Then
            Dim dt1 As DataTable = dt
            Dim dt2 As DataTable = grdStockD.DataSource
            'Dim dt2 As DataTable = grdData.DataSource

            Dim dr As DataRow
            Dim msg As String = ""
            Dim i As Integer = 0
            Dim j As Integer = 0
            For i = 0 To dt1.Rows.Count - 1

                dr = dt2.NewRow

                For j = 0 To dt2.Columns.Count - 1
                    dr("lot") = dt1.Rows(i)("lot")
                    dr("design_no") = dt1.Rows(i)("design_no")
                    dr("roll_no_d") = dt1.Rows(i)("roll_no_d")
                    'dr("col") = dt1.Rows(i)("col")
                    dr("col") = dt1.Rows(i)("col")
                    dr("custcolor") = dt1.Rows(i)("custcolor")
                    dr("gr") = dt1.Rows(i)("gr")
                    dr("batch") = dt1.Rows(i)("batch")
                    dr("fwth") = dt1.Rows(i)("fwth")
                    dr("kg") = dt1.Rows(i)("kg")
                    dr("mts") = dt1.Rows(i)("mts")
                    dr("yds") = dt1.Rows(i)("yds")
                    dr("mtkg") = dt1.Rows(i)("mtkg")  'For Cal



                Next
                dt2.Rows.Add(dr)

            Next



        End If



    End Sub


    Private Sub txtOutNo_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtOutNo.TextChanged

    End Sub

    Private Sub btncopy_Click(sender As System.Object, e As System.EventArgs) Handles btncopy.Click
        Call GetcopyRollNoD()
    End Sub

    Private Function GetcopyRollNoD() As Boolean
        Dim dtc As DataTable = grdStockD.DataSource
        Dim newrow As DataRow
        If grdStockD.Rows.Count > 0 Then

            'StrDesign_No = grdStockD.CurrentRow.Cells("Design_no").Value
            'StrRollNoD = grdStockD.CurrentRow.Cells("roll_no_d").Value
            'StrCol = grdStockD.CurrentRow.Cells("col").Value
            'StrCustcol = grdStockD.CurrentRow.Cells("custcolor").Value
            'StrGr = grdStockD.CurrentRow.Cells("gr").Value
            'StrBatch = grdStockD.CurrentRow.Cells("batch").Value
            'StrFwth = grdStockD.CurrentRow.Cells("fwth").Value
            'StrKg = grdStockD.CurrentRow.Cells("kg").Value
            'StrMts = grdStockD.CurrentRow.Cells("mts").Value
            'StrYds = grdStockD.CurrentRow.Cells("yds").Value

            newrow = dtc.NewRow

            newrow.Item("Design_no") = grdStockD.CurrentRow.Cells("Design_no").Value
            newrow.Item("sono") = grdStockD.CurrentRow.Cells("sono").Value
            newrow.Item("roll_no_d") = grdStockD.CurrentRow.Cells("roll_no_d").Value
            newrow.Item("col") = grdStockD.CurrentRow.Cells("col").Value
            newrow.Item("custcolor") = grdStockD.CurrentRow.Cells("custcolor").Value
            newrow.Item("gr") = grdStockD.CurrentRow.Cells("gr").Value
            newrow.Item("batch") = grdStockD.CurrentRow.Cells("batch").Value
            newrow.Item("fwth") = grdStockD.CurrentRow.Cells("fwth").Value
            newrow.Item("kg") = grdStockD.CurrentRow.Cells("kg").Value
            newrow.Item("mts") = grdStockD.CurrentRow.Cells("mts").Value
            newrow.Item("yds") = grdStockD.CurrentRow.Cells("yds").Value
            newrow.Item("mtkg") = grdStockD.CurrentRow.Cells("mtkg").Value
            dtc.Rows.Add(newrow)

            Return True


        End If

        Return False

    End Function

    Private Sub btnSave_Click(sender As System.Object, e As System.EventArgs) Handles btnSave.Click
        Try
            If MsgBox("Are you sure to Save ?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                If InsertStockDReturn() Then

                    Call BindGrid(grdStockD, (New classStockDINReturn).GetDINReturn(txtDinno.Text.Trim, clsuser.UserID))

                    Exit Sub

                End If


            End If
        Catch ex As Exception
            MsgBox("มีข้อผิดพลาดเกี่ยวกับการบันทึกข้อมูลครับ", MsgBoxStyle.Critical, "Insertdata Fail")
        End Try     '
    End Sub

    Private Function InsertStockDReturn() As Boolean
        Dim config As New clsConfig
        clsconfig.ChangeCulture()
        Dim objdb As New classStockDINReturn
        Dim msgerr As String = ""
        Dim DINNo As String = Me.txtDinno.Text.Trim
        Dim Din_header As New classStockDINReturn.Strolls_DHeader

        Din_header.h01_dinno = Me.txtDINNo.Text.Trim
        Din_header.h02_dindt = Me.dtpDINDate.Value
        Din_header.h03_doctyp = "K"
        Din_header.h04_dhcod = "RET"
        'Din_header.h05_dhdono = Me.txtBillNo.Text.Trim
        'Din_header.h06_dhdodt = Me.dtpdodt.Value
        Din_header.h07_dfno = txtOutNo.Text.Trim
        'Din_header.h08_dono = ""
        'If txtBillNo.Text.Trim = "" Then Din_header.h09_dodt = ""
        'If txtBillNo.Text.Trim <> "" Then Din_header.h09_dodt = dtpdodt.Value
        'Din_header.h09_dodt = ""
        'Din_header.h10_design_no = ds.Tables("v_strolls_d").Rows(0).Item("design_no").ToString.Trim
        'Din_header.h13_lot = ""
        'Din_header.h14_yr = ""
        'Din_header.h15_sh = ""
        'Din_header.h16_col = ""
        'Din_header.h17_Gr = ""
        'Din_header.h18_mtkg = 0
        'Din_header.h19_roll_no_d
        'Din_header.h34_lotbatno = ""
        'Din_header.h36_loc = ""
        'Din_header.h38_batch = ""
        'Din_header.h45_unit = ""


        Dim dtc As DataTable = grdStockD.DataSource

        Dim dv_dtc_add As New DataView(dtc, "", "", DataViewRowState.Added)
        Dim dv_dtc_upd As New DataView(dtc, "", "", DataViewRowState.ModifiedCurrent)
        Dim dv_dtc_del As New DataView(dtc, "", "", DataViewRowState.Deleted)

        'Dim dv_dtc_add As New DataView(grdStockD.DataSource, "", "", DataViewRowState.Added)
        'Dim dv_dtc_upd As New DataView(grdStockD.DataSource, "", "", DataViewRowState.ModifiedCurrent)
        'Dim dv_dtc_del As New DataView(grdStockD.DataSource, "", "", DataViewRowState.Deleted)



        If objdb.DReturnSave(Din_header, msgerr, dtc, dv_dtc_add, dv_dtc_upd, dv_dtc_del, clsuser.UserID, DINNo) Then
            txtDinno.Text = DINNo

            InsertStockDReturn = True
        Else
            InsertStockDReturn = False
        End If






    End Function

    Private Sub btnSearchOutNo_Click(sender As System.Object, e As System.EventArgs) Handles btnSearchOutNo.Click
        Dim frm As New frmSearchDOUT
        frm.ShowDialog(Me)
        txtOutNo.Text = (frm.pOutno.ToUpper.Trim.ToUpper)

        Me.Cursor = Cursors.WaitCursor
        If Not blnCancel Then
            If Getoutno(txtOutNo.Text) Then
                'stroutno = txtOutNo.Text
                ' Dim strcartno2 As String = ""
                'GetPackinglistDData(strPacking_no.ToUpper, strcartno2)
            End If
        End If
        Me.Cursor = Cursors.Default
        frm.Dispose()

    End Sub

    Private Sub btnNew_Click(sender As System.Object, e As System.EventArgs) Handles btnNew.Click
        Call InitControl()
    End Sub

    Private Sub cboDinNo_Click(sender As System.Object, e As System.EventArgs) Handles cboDinNo.Click

    End Sub

    Private Sub cboDinNo_DropDownClosed(sender As Object, e As System.EventArgs) Handles cboDinNo.DropDownClosed
        If clsconfig.IsNull(cboDinNo.ComboBox.SelectedValue, "").ToString.Length = 0 Then Exit Sub
        Call GetDINReturn(clsconfig.IsNull(cboDinNo.ComboBox.SelectedValue, ""))
    End Sub

    Function GetDINReturn(ByRef strDINNO As String) As Boolean

        Dim dt As DataTable = DbStockD.GetDINReturn(strDINNO, clsuser.UserID)
        If dt.Rows.Count > 0 Then
            'Dev By Neung 26/03/2015
            Call BindDINReturn(grdStockD, dt)
            Return True
        End If
        Return False

    End Function

    Private Sub BindDINReturn(ByRef grd As DataGridView, ByVal dt As DataTable)

        Dim config As New clsConfig
        Dim i As Integer = 0
        Dim j As Integer = 0

        grdStockD.AutoGenerateColumns = False
        grdStockD.DataSource = dt

        If dt.Rows.Count > 0 Then
            txtDinno.Text = dt.Rows(0)("dinno").ToString.Trim
            dtpDINDate.Value = dt.Rows(0)("dindt").ToString.Trim
            ' txtOutNo.Text = dt.Rows(0)("outno").ToString.Trim
        ElseIf dt.Rows.Count = 0 Then
            txtDinno.Text = ""
            dtpDINDate.Value = Now
            txtOutNo.Text = ""
        End If


    End Sub

    Private Sub grdStockD_CellContentClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles grdStockD.CellContentClick

    End Sub

    Private Sub grdStockD_CellEndEdit(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles grdStockD.CellEndEdit

    End Sub

    Private Sub btnPrint_Click(sender As System.Object, e As System.EventArgs) Handles btnPrint.Click
        Dim clsConfig As New clsConfig
        Dim rptFileName = "rptDINManual.rpt"
        
        'clsUser.ReportPath = "C:\Users\DELL\Desktop\GemmaKnits\"
        If Not clsConfig.CheckReport(clsuser.ReportPath, rptFileName) Then Exit Sub
        Dim frm As New frmReport
        Dim rpt As New CrystalDecisions.CrystalReports.Engine.ReportDocument
        Dim stype As String = ""
        Dim ord As String = ""
        Me.Cursor = Cursors.WaitCursor

        rpt.Load(clsuser.ReportPath & rptFileName)
        rpt.DataSourceConnections.Item(0).SetConnection(clsconn.servername, clsconn.database, False)
        rpt.DataSourceConnections.Item(0).SetLogon(clsconn.Userid, clsconn.Password)
        rpt.VerifyDatabase()
        rpt.SetParameterValue("@dinno", txtDinno.Text)

        'rpt.PrintOptions.PaperSize = CrystalDecisions.Shared.PaperSize.PaperA4
        'rpt.PrintOptions.PaperOrientation = CrystalDecisions.Shared.PaperOrientation.Portrait
        'rpt.PrintOptions.PaperSource = CrystalDecisions.Shared.PaperSource.Auto

        frm.Title = "DIN Document"
        frm.CRViewer.ReportSource = rpt
        frm.MdiParent = Me.ParentForm
        frm.Show()
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub btnCancel_Click(sender As System.Object, e As System.EventArgs) Handles btnCancel.Click
        BFCancelDIN()
    End Sub
    Private Sub BFCancelDIN()
        Dim strDinno As String = ""
        If strDinno = "" Then strDinno = txtDinno.Text.Trim.ToUpper
        If strDinno.Length = 0 Then Exit Sub
        If grdStockD.DataSource Is Nothing Then Exit Sub
        If grdStockD.DataSource Is Nothing Then Exit Sub
        If grdStockD.Rows.Count = 0 Then Exit Sub
        If grdStockD.Rows.Count = 0 Then Exit Sub


        If blnCancel Then Exit Sub
        'If lblCancelled.Visible Then
        '    MessageBox.Show("This document is already cancelled." & vbCrLf & "Can't cancel anymore.", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
        '    Exit Sub
        'End If
        'Dim obj As New classPackingListG
        'If obj.IsAlreadyGOUT(strPacking_no) = True Then
        '    MessageBox.Show("This document is already GOUT." & vbCrLf & "Can't cancel anymore.", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
        '    Exit Sub
        'End If
        If MessageBox.Show("Would you like to cancel this document ?", "System Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = DialogResult.No Then Exit Sub


        If CancelDIN() Then
            MessageBox.Show("DIN NO." & vbCrLf & strDinno & "is Cancel", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Call InitControl()
            Call GenComboDINReturnNo()
            'lblCancelled.Visible = True
        End If

    End Sub
    Private Function CancelDIN() As Boolean
        Dim confid As New clsConfig

        Dim obidb As New classStockDINReturn
        Dim DINHeader As New classStockDINReturn.Strolls_DHeader
        Dim msgerr As String = ""

        Dim DINNo As String = txtDinno.Text.Trim

        DINHeader.h01_dinno = Me.txtDINNo.Text.Trim
        DINHeader.h02_dindt = Me.dtpDINDate.Value
        DINHeader.h03_doctyp = ""
        'Din_header.h04_dhcod = ""
        'Din_header.h05_dhdono = Me.txtBillNo.Text.Trim
        'Din_header.h06_dhdodt = Me.dtpdodt.Value
        DINHeader.h07_dfno = ""
        DINHeader.h08_dono = ""
        'DINHeader.h09_dodt = ""
        'Din_header.h10_design_no = ds.Tables("v_strolls_d").Rows(0).Item("design_no").ToString.Trim
        DINHeader.h13_lot = ""
        'Din_header.h14_yr = ""
        'Din_header.h15_sh = ""
        'Din_header.h16_col = ""
        'Din_header.h17_Gr = ""
        'Din_header.h18_mtkg = 0
        'Din_header.h19_roll_no_d


        Dim dtp As DataTable = grdStockD.DataSource
        'Dim dv_dtc_add As New DataView(dtc, "", "", DataViewRowState.Added)
        'Dim dv_dtc_upd As New DataView(dtc, "", "", DataViewRowState.ModifiedCurrent)
        'Dim dv_dtc_del As New DataView(dtc, "", "", DataViewRowState.Deleted)

        If obidb.DINcancel(DINHeader, msgerr, dtp, clsUser.UserID) Then
            CancelDIN = True
        Else
            CancelDIN = False
        End If

    End Function

    Private Sub CalGrdDataYDS()

        Dim config As New clsConfig
        Dim i As Integer = 0
        Dim j As Integer = 0
        Dim dblKgs As Double = 0
        Dim dblMts As Double = 0
        Dim dblYds As Double = 0

        Dim netwt As Double = 0.0
        Dim anetwt As Double = 0.0
        Dim CartMts As Double = 0.0
        Dim CartYds As Double = 0.0
        Dim totalroll As Double = 0

        For j = 0 To grdStockD.Rows.Count - 1
            grdStockD.Rows(j).Cells("yds").Value = FormatNumber(config.IsNull(grdStockD.Rows(j).Cells("mts").Value, 0) / 0.9144, 2, TriState.False, TriState.False, TriState.True)
        Next


        For i = 0 To grdStockD.Rows.Count - 1
            dblKgs = dblKgs + config.IsNull(grdStockD.Rows(i).Cells("kg").Value, 0)
            dblMts = dblMts + config.IsNull(grdStockD.Rows(i).Cells("mts").Value, 0)
            dblYds = dblYds + config.IsNull(grdStockD.Rows(i).Cells("yds").Value, 0)
        Next

        'txtTotalRolls.Text = FormatNumber(grdStockD.Rows.Count, 0, TriState.False, TriState.False, TriState.True)
        'txtTotalKgs.Text = FormatNumber(dblKgs, 2, TriState.False, TriState.False, TriState.True)
        'txtTotalMts.Text = FormatNumber(dblMts, 2, TriState.False, TriState.False, TriState.True)
        'txtTotalYds.Text = FormatNumber(dblYds, 2, TriState.False, TriState.False, TriState.True)

    End Sub

    Private Sub CalGrdDataMTS()

        Dim config As New clsConfig
        Dim i As Integer = 0
        Dim j As Integer = 0
        Dim dblKgs As Double = 0
        Dim dblMts As Double = 0
        Dim dblYds As Double = 0

        Dim netwt As Double = 0.0
        Dim anetwt As Double = 0.0
        Dim CartMts As Double = 0.0
        Dim CartYds As Double = 0.0
        Dim totalroll As Double = 0

        For j = 0 To grdStockD.Rows.Count - 1
            grdStockD.Rows(j).Cells("mts").Value = FormatNumber(config.IsNull(grdStockD.Rows(j).Cells("yds").Value, 0) * 0.9144, 2, TriState.False, TriState.False, TriState.True)
        Next


        For i = 0 To grdStockD.Rows.Count - 1
            dblKgs = dblKgs + config.IsNull(grdStockD.Rows(i).Cells("kg").Value, 0)
            dblMts = dblMts + config.IsNull(grdStockD.Rows(i).Cells("mts").Value, 0)
            dblYds = dblYds + config.IsNull(grdStockD.Rows(i).Cells("yds").Value, 0)
        Next

        'txtTotalRolls.Text = FormatNumber(grdStockD.Rows.Count, 0, TriState.False, TriState.False, TriState.True)
        'txtTotalKgs.Text = FormatNumber(dblKgs, 2, TriState.False, TriState.False, TriState.True)
        'txtTotalMts.Text = FormatNumber(dblMts, 2, TriState.False, TriState.False, TriState.True)
        'txtTotalYds.Text = FormatNumber(dblYds, 2, TriState.False, TriState.False, TriState.True)

    End Sub
    Private Sub grdStockD_CellValueChanged(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles grdStockD.CellValueChanged
        If e.RowIndex < 0 Or e.ColumnIndex < 0 Then Exit Sub
        If grdStockD.Columns(e.ColumnIndex).Name = "kg" Or _
         grdStockD.Columns(e.ColumnIndex).Name = "yds" Or _
         grdStockD.Columns(e.ColumnIndex).Name = "mts" Then
            If CBool(chkAutoCalculate.Checked) Then
                Dim dt As DataTable = grdStockD.DataSource
                Dim i As Integer = CheckDelRow(dt)
                If clsconfig.IsNull(Val(dt.Rows(e.RowIndex + i)("mtkg")), 0) = 0 Then MessageBox.Show("Design No." & vbCrLf & Val(dt.Rows(e.RowIndex + i)("Design_No")) & vbCrLf & "ไม่ได้ใส่ MT/KG", "SyStem Message", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1)
                If grdStockD.Columns(e.ColumnIndex).Name = "kg" Then
                    If Val(dt.Rows(e.RowIndex + i)("mtkg")) > 0 Then dt.Rows(e.RowIndex + i)("mts") = FormatNumber(dt.Rows(e.RowIndex + i)("kg") * dt.Rows(e.RowIndex + i)("mtkg"), 2, TriState.False, TriState.False, TriState.False)
                    If Val(dt.Rows(e.RowIndex + i)("mtkg")) > 0 Then dt.Rows(e.RowIndex + i)("yds") = FormatNumber(dt.Rows(e.RowIndex + i)("kg") * dt.Rows(e.RowIndex + i)("mtkg") / 0.9144, 2, TriState.False, TriState.False, TriState.False)
                End If
                If grdStockD.Columns(e.ColumnIndex).Name = "mts" Then
                    If Val(dt.Rows(e.RowIndex + i)("mtkg")) > 0 Then dt.Rows(e.RowIndex + i)("yds") = FormatNumber(dt.Rows(e.RowIndex + i)("mts") / 0.9144, 2, TriState.False, TriState.False, TriState.False)
                    If Val(dt.Rows(e.RowIndex + i)("mtkg")) > 0 Then dt.Rows(e.RowIndex + i)("kg") = FormatNumber(dt.Rows(e.RowIndex + i)("mts") / dt.Rows(e.RowIndex + i)("mtkg"), 2, TriState.False, TriState.False, TriState.False)
                End If
                If grdStockD.Columns(e.ColumnIndex).Name = "yds" Then
                    If Val(dt.Rows(e.RowIndex + i)("mtkg")) > 0 Then dt.Rows(e.RowIndex + i)("kg") = FormatNumber(dt.Rows(e.RowIndex + i)("yds") / dt.Rows(e.RowIndex + i)("mtkg") * 0.9144, 2, TriState.False, TriState.False, TriState.False)
                    If Val(dt.Rows(e.RowIndex + i)("mtkg")) > 0 Then dt.Rows(e.RowIndex + i)("mts") = FormatNumber(dt.Rows(e.RowIndex + i)("kg") * dt.Rows(e.RowIndex + i)("mtkg"), 2, TriState.False, TriState.False, TriState.False)
                End If

            End If
            Call SumGrid()
        End If
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
        Dim dt As DataTable = grdStockD.DataSource
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
End Class