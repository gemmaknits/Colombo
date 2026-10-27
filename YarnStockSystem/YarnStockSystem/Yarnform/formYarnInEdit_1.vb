Imports System.Data.SqlClient
Imports System.Text
Public Class formYarnInEdit
    Private dt_yarnindet As DataTable
    Private da As New SqlDataAdapter
    Private Clsconfig As New clsConfig
    Private saveItcd As String
    Private saveTube As String
    Private saveGross As String
    Private saveKG_net As String
    Private saveBoxTearWeight As String
    Dim clsUser As New classUserInfo

    Public Property UserInfo() As classUserInfo
        Get
            UserInfo = clsUser
        End Get
        Set(ByVal NewValue As classUserInfo)
            clsUser = NewValue
        End Set
    End Property

    Private Sub formYarnInEdit_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LoadCbSupplier()
        InsertComboGradeOur()
        insertcomboitemcode()
        insertcomboCurrency()
    End Sub

    Private Sub InsertComboGradeOur()
        Dim classYarnIn As New classYarnIn

        Dim dt As New DataTable
        dt = classYarnIn.GetDataGradeOUR()

        Dim DGVcbc As New DataGridViewComboBoxColumn

        DGVcbc = DgYarnGradeOur

        DGVcbc.DataSource = dt
        DGVcbc.DisplayMember = "grade_code"
        DGVcbc.ValueMember = "grade_code"


    End Sub

    Private Sub insertcomboCurrency()
        Dim tblItems As New tbl_Items
        Dim getDatayarn As New GetDataYarn
        Dim ds As New DataSet
        ds = getDatayarn.GetDataCurrency()
        If Not IsNothing(ds) Then
            'Me.cboCurrency.DataSource = ds.Tables(0)
            'Me.cboCurrency.DisplayMember = "currname"
            'Me.cboCurrency.ValueMember = "curr"
        End If
    End Sub

    Private Sub insertcomboitemcode()
        Dim tblItems As New tbl_Items
        Dim getDatayarn As New GetDataYarn
        Dim ds As New DataSet
        ds = getDatayarn.GetDataItem(tblItems)
        If Not IsNothing(ds) Then
            Me.cboitcd.DataSource = ds.Tables(0)
            Me.cboitcd.DisplayMember = "itdesc"
            Me.cboitcd.ValueMember = "Itcd"

        End If
    End Sub

    Private Sub LoadCbSupplier()
        Dim GetdataSupplier As New GetDataYarn
        Dim dt As DataTable
        dt = GetdataSupplier.GetSupplier
        If dt.Rows.Count > 0 Then
            Me.CbSupplier.DataSource = dt
            Me.CbSupplier.DisplayMember = "name"
            Me.CbSupplier.ValueMember = "suppcd"
        End If
    End Sub

    Private Sub Btnsearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btnsearch.Click
        Dim selectedYarn As String
        Dim formSearchyarn As New formSearchYarn
        selectedYarn = formSearchyarn.getYarnno()
        If formSearchyarn.pUserAction = "OK" Then
            Me.txtDocNo.Text = selectedYarn
        End If
        LoadDataYarnIn()
    End Sub

    Private Sub LoadDataYarnIn()
        Dim msgerr As String = ""
        Dim dt As DataTable
        Dim GetdataYarnIn As New GetDataYarn
        dt = GetdataYarnIn.GetData_YarnIn(Me.txtDocNo.Text, msgerr)
        If dt.Rows.Count > 0 Then
            If dt.Rows.Count > 0 Then

                If Not IsDBNull(dt.Rows(0).Item("cancel")) Then
                    If dt.Rows(0).Item("cancel") = True Then
                        Me.BtnYarnEdit_and_Save.Enabled = False
                        Me.btnCancel.Enabled = False
                    Else
                        Me.BtnYarnEdit_and_Save.Enabled = True
                        Me.btnCancel.Enabled = True
                    End If
                Else
                    Me.BtnYarnEdit_and_Save.Enabled = True
                    Me.btnCancel.Enabled = True
                End If
            End If
            'Edit By Neung 26/01/2015 Fix .ToString to .ToString.Trim
            Me.txtoutno.Text = dt.Rows(0).Item("outno").ToString.Trim
            Me.txtPONo.Text = dt.Rows(0).Item("purno").ToString.Trim
            Me.CbSupplier.SelectedValue = dt.Rows(0).Item("suppcd").ToString.Trim

            Me.txtSupp.Text = dt.Rows(0).Item("sinvno").ToString.Trim
            Me.txtSupDt.Text = dt.Rows(0).Item("sinvdt").ToString.Trim
            Me.txtSupLot.Text = dt.Rows(0).Item("lotno_sup").ToString.Trim
            Me.textStatus.Text = dt.Rows(0).Item("present_status").ToString.Trim
            'Me.txtSupref.Text = dt.Rows(0).Item("srefno").ToString.Trim
            'Me.txtFreight.Text = dt.Rows(0).Item("Freight").ToString.Trim
            'Me.txtInsurance.Text = dt.Rows(0).Item("Insurance").ToString.Trim
            'Me.txtAmt.Text = dt.Rows(0).Item("otheramt").ToString.Trim
            'Me.txtDetail.Text = dt.Rows(0).Item("other_text").ToString.Trim
            'Me.lblYINno.Text = dt.Rows(0).Item("docno").ToString.Trim
            'Me.DateYIN.Value = dt.Rows(0).Item("docdt").ToString.Trim
            dtpdocdt.Value = dt.Rows(0).Item("docdt").ToString.Trim
            'lbldate.Text = dt.Rows(0).Item("docdt").ToString.Trim
            Me.txtremark.Text = dt.Rows(0).Item("remark").ToString.Trim
            Me.txttotalboxes.Text = dt.Rows(0).Item("other_text").ToString.Trim
            Me.txttotalgross.Text = dt.Rows(0).Item("kg_gr").ToString.Trim
            Me.txttotalnet.Text = dt.Rows(0).Item("kg_nt").ToString.Trim

            '----------------- dgyarn ----------------------
            Me.DgYarn.AutoGenerateColumns = False
            Dim Getdatayarnindet As New GetDataYarn

            dt_yarnindet = Getdatayarnindet.GetData_YarnInDet(Me.txtDocNo.Text, msgerr, da)
            'Dim n As Integer
            'For n = 0 To dt_yarnindet.Rows.Count - 1
            '    If IsDBNull(dt_yarnindet.Rows(n).Item("")) = True Then

            '    End If

            'Next
            If Not IsNothing(dt_yarnindet) Then
                Me.DgYarn.DataSource = dt_yarnindet
                'With Me.DgYarn
                '                .Columns("colItcd").DataPropertyName = "itcd"
                '                .Columns(1).DataPropertyName = "docno"
                '	.Columns(2).DataPropertyName = "grade"
                '	.Columns(3).DataPropertyName = "boxno_s"
                '	.Columns(4).DataPropertyName = "boxno"
                '	.Columns(5).DataPropertyName = "spools"
                '	.Columns(6).DataPropertyName = "kg_gr"
                '	.Columns(7).DataPropertyName = "cart_tearwt"
                '	.Columns(8).DataPropertyName = "kg_nt"
                '	.Columns(9).DataPropertyName = "docno"
                '                .Columns(10).DataPropertyName = "lotno_our"
                'End With
            End If

            '-----------------------------------------------

            'Me.cboCurrency.SelectedValue = dt.Rows(0).Item("curr").ToString
            'Me.txtrate.Text = dt.Rows(0).Item("exrt").ToString
            'Me.txtVat.Text = dt.Rows(0).Item("vat").ToString
            'Me.txtTaxAmount.Text = dt.Rows(0).Item("taxamt").ToString
            'Me.txtDiscountamount.Text = dt.Rows(0).Item("discamt").ToString
            'Me.txtVatAmount.Text = dt.Rows(0).Item("vatamt").ToString
            'Me.txtTotalAmount.Text = dt.Rows(0).Item("totamt").ToString
        End If
        sumtotal()
    End Sub

    Private Sub txtyarnincode_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtDocNo.KeyPress
        If AscW(e.KeyChar) = 13 Then
            LoadDataYarnIn()
        End If
    End Sub

    Private Sub BtnYarnEdit_and_Save_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnYarnEdit_and_Save.Click
        Call sumtotal()

        If Not CheckData() Then Exit Sub

        Dim result As DialogResult
        result = MessageBox.Show("Would you like to save ?", "System Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button3)
        If result <> DialogResult.Yes Then Exit Sub

        Dim config As New clsConfig
        config.ChangeCulture()

        Dim connstr As New classConnection
        Dim ds1 As New DataSet
        Dim Obj_YarnIn As New tbl_Yarn_in
        Dim UpdateYarnin As New UpdateYarn
        Dim IsValid As Boolean
        Dim Msgerr As String = ""
        Dim strsql1 As String = ""

        strsql1 = "select * from yarn_in_det where docno = '" & Me.txtDocNo.Text.Trim & "'"
        Dim dadet As New SqlDataAdapter(strsql1, connstr.Connection)
        dadet.Fill(ds1, "tbl_yarn_in_det")
        Obj_YarnIn.docdt = IIf(IsDate(dtpdocdt.Text), CDate(dtpdocdt.Text), Today())
        Obj_YarnIn.docno = Me.txtDocNo.Text.Trim
        Obj_YarnIn.outno = Me.txtoutno.Text.Trim
        Obj_YarnIn.purno = Me.txtPONo.Text.Trim
        Obj_YarnIn.sinvno = UCase(Me.txtSupp.Text.Trim)
        Obj_YarnIn.sinvdt = Me.txtSupDt.Text.Trim
        If Not Me.CbSupplier.SelectedValue Is Nothing Then
            Obj_YarnIn.suppcd = Me.CbSupplier.SelectedValue.ToString.Trim
        End If
        Obj_YarnIn.lotno_sup = UCase(Me.txtSupLot.Text.Trim)
        Obj_YarnIn.srefno = Me.txtSupRefno.Text.Trim
        Obj_YarnIn.remark = Me.txtremark.Text.Trim

        IsValid = UpdateYarnin.UpdateYarnIn(Obj_YarnIn, dt_yarnindet, Msgerr, da, clsUser.UserID)

        If IsValid = True Then
            MsgBox("Update Success")
        ElseIf IsValid = False Then
            MsgBox(Msgerr)
        End If

    End Sub

    Private Function CheckData()

        If (New classYarnInEdit).ValitateDocNoAlreadyKOClosed(StrDocno:=txtDocNo.Text.Trim) Then
            MessageBox.Show("ไม่สามารแก้ไข ได้อีก เนื่อง Production Order Closed แล้ว", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
            Return False
        End If

        Return True
    End Function

    Private Sub txtPO_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtPONo.TextChanged
        Call LoadDataJOB(txtPONo.Text.Trim)

        Dim tblPur As New tbl_Pur
        Dim arr_tblPurPur As New tbl_Pur
        Dim msgerr As String = ""
        Dim getDatayarn As New GetDataYarn
        Dim objarr_tblPur() As tbl_Pur
        Dim ds As New DataSet
        Dim objsupp As New GetDataYarn
        Try
            arr_tblPurPur.purno = UCase(Me.txtPONo.Text.Trim)
            objarr_tblPur = getDatayarn.checkPurno(arr_tblPurPur, msgerr)
            If Not IsNothing(objarr_tblPur) Then
                CbSupplier.SelectedValue = objarr_tblPur(0).suppcd
            ElseIf IsNothing(objarr_tblPur) Then
                Me.CbSupplier.Text = ""
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub BtnYarnPrintDoc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnYarnPrintDoc.Click
        'Dim str As String
        'Dim connClass As New classConnection
        'Dim ds As New DataSet
        'str = "select * from v_yarn_in  " & _
        ' "where docno = '" & Me.txtyarnincode.Text & "' order by itcd,boxno_s"

        'Dim myda As New SqlDataAdapter(str.ToString, connClass.connection)
        'myda.Fill(ds, "TblDatayarnin")

        'Dim frmreport As New FormRptYarnIn
        'Dim rptFileName As String = "RptYarnIn.rpt"
        'Dim obj As New CrystalDecisions.CrystalReports.Engine.ReportDocument
        'obj.Load(clsuser.reportpath & rptFileName)
        ''Dim obj As New RptYarnIn
        'obj.SetDataSource(ds.Tables("TblDatayarnin"))

        'frmreport.CrystalReportViewer1.ReportSource = obj

        'frmreport.ShowDialog()

        Dim clsConn As New classConnection
        Dim rptFileName As String = "RptYarnIn.rpt"
        Dim frm As New frmReport

        If Not Clsconfig.CheckReport(clsUser.ReportPath, rptFileName) Then Exit Sub
        Dim rpt As New CrystalDecisions.CrystalReports.Engine.ReportDocument
        Me.Cursor = Cursors.WaitCursor

        rpt.Load(clsUser.ReportPath & rptFileName)
        rpt.DataSourceConnections.Item(0).SetConnection(clsConn.ServerName, clsConn.Database, False)
        rpt.DataSourceConnections.Item(0).SetLogon(clsConn.UserName, clsConn.Password)
        rpt.VerifyDatabase()
        rpt.SetParameterValue("@docno", txtDocNo.Text)

        'rpt.PrintOptions.PaperSize = CrystalDecisions.Shared.PaperSize.PaperA4
        rpt.PrintOptions.PaperSize = CrystalDecisions.Shared.PaperSize.PaperLetter
        rpt.PrintOptions.PaperOrientation = CrystalDecisions.Shared.PaperOrientation.Portrait
        rpt.PrintOptions.PaperSource = CrystalDecisions.Shared.PaperSource.Auto

        'frm.CRViewer.DisplayGroupTree = False
        frm.CRViewer.ReportSource = rpt
        frm.MdiParent = Me.ParentForm
        frm.Title = "Yarn In"
        frm.Show()
        Me.Cursor = Cursors.Default
    End Sub


    Private Sub sumtotal()
        Dim sumgross As Double
        Dim sumnet As Double
        Dim i As Integer
        Try
            Dim countGrid As Integer
            countGrid = Me.DgYarn.Rows.Count
            For i = 0 To Me.DgYarn.Rows.Count - 2
                Dim kg_gr As Double
                Dim kg_nt As Double

                If IsDBNull(Me.DgYarn.Rows(i).Cells("Kg_gr").Value) Then
                    kg_gr = 0
                Else
                    kg_gr = Clsconfig.IsValidDouble(Me.DgYarn.Rows(i).Cells("Kg_gr").Value)
                End If

                If IsDBNull(Me.DgYarn.Rows(i).Cells("Kg_nt").Value) Then
                    kg_nt = 0
                Else
                    kg_nt = Clsconfig.IsValidDouble(Me.DgYarn.Rows(i).Cells("Kg_gr").Value)
                End If

                sumgross = sumgross + kg_gr
                sumnet = sumnet + kg_nt
            Next
            Me.txttotalgross.Text = sumgross
            Me.txttotalnet.Text = sumnet
            txttotalboxes.Text = Me.DgYarn.RowCount - 1
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub BtnYarnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnYarnExit.Click
        Me.Close()
    End Sub


    Private Sub DgYarn_CellValidated(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DgYarn.CellValidated
        Dim currRow As Integer
        Dim currCol As Integer
        currRow = e.RowIndex
        currCol = e.ColumnIndex

        Try
            If currCol = DgYarn.Rows(currRow).Cells("colitcd").ColumnIndex Then
                DgYarn.Rows(currRow).Cells("cboitcd").Value = DgYarn.Rows(currRow).Cells("colitcd").Value
            End If
            If currCol = DgYarn.Rows(currRow).Cells("cboitcd").ColumnIndex Then
                DgYarn.Rows(currRow).Cells("colitcd").Value = DgYarn.Rows(currRow).Cells("cboitcd").Value
            End If
        Catch ex As Exception

        End Try

        sumtotal()
    End Sub

    Private Sub DgYarn_DefaultValuesNeeded(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewRowEventArgs) Handles DgYarn.DefaultValuesNeeded
        With e.Row
            .Cells("docno").Value = txtDocNo.Text
        End With
        '		e.Row.Cells(1).Value = Me.DgYarn.Rows(0).Cells(0).Value
        e.Row.Cells(2).Value = 0
        e.Row.Cells("Boxno").Value = ""
        e.Row.Cells("spools").Value = saveTube
        e.Row.Cells("kg_nt").Value = saveKG_net
        e.Row.Cells("kg_gr").Value = saveGross
        e.Row.Cells("kg_gr2").Value = saveBoxTearWeight
        e.Row.Cells("cboItcd").Value = saveItcd
    End Sub

    Private Sub DgYarn_RowValidated(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DgYarn.RowValidated
        Dim currentRow As Integer
        currentRow = e.RowIndex
        saveItcd = Me.DgYarn.Rows(currentRow).Cells("cboItcd").Value
        saveTube = Me.DgYarn.Rows(currentRow).Cells("spools").Value
        saveKG_net = Me.DgYarn.Rows(currentRow).Cells("kg_nt").Value
        saveBoxTearWeight = Me.DgYarn.Rows(currentRow).Cells("kg_gr2").Value
        saveGross = Me.DgYarn.Rows(currentRow).Cells("kg_gr").Value
    End Sub

    Private Sub BtnYarnPrintBar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnYarnPrintBar.Click
        If Me.txtDocNo.Text.Length > 5 Then
            Dim frm As New formPrintBarcode
            Dim stryarnin As String
            stryarnin = Me.txtDocNo.Text.Trim
            frm.loginEmpcd = clsUser.UserID
            frm.txtYarn_in_no.Text = stryarnin.ToString.Trim
            frm.btnFindByYarnInClick()
            frm.SelectAll(sender, e)
            frm.UserInfo = UserInfo
            frm.MdiParent = Me.ParentForm
            frm.Show()
        End If
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        If MsgBox("Are you sure to cancel this document?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Please confirm cancel") = MsgBoxResult.Yes Then
            Call cancelYin()
        End If
    End Sub
    Private Sub cancelYin()
        Dim comm As New SqlCommand
        Dim classCn As New classConnection
        Dim cn As New SqlConnection
        Dim tran As SqlTransaction
        cn.ConnectionString = classCn.Connection
        cn.Open()
        tran = cn.BeginTransaction
        Try
            comm.Connection = cn
            comm.Transaction = tran
            comm.CommandType = CommandType.StoredProcedure
            comm.CommandText = "p_yarn_in_cancel"
            comm.Parameters.AddWithValue("@docno", Me.txtDocNo.Text)
            comm.Parameters.AddWithValue("@log_empcd", clsUser.UserID)
            comm.ExecuteNonQuery()
            'MsgBox("Y-in cancelled successfully")

        Catch ex As Exception
            MsgBox(ex.Message)
            tran.Rollback()
            comm.Connection.Close()
            Exit Sub
        End Try
        MsgBox("Y-in cancelled successfully")
        tran.Commit()
        comm.Connection.Close()
    End Sub

    Private Sub DgYarn_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DgYarn.CellContentClick

    End Sub

    Private Sub txtPO_TextChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtPONo.TextChanged

    End Sub

    Private Sub txtyarnincode_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtDocNo.TextChanged

    End Sub

    Private Sub Label9_Click(sender As System.Object, e As System.EventArgs)

    End Sub

    Private Sub txtPO_KeyDown(sender As Object, e As KeyEventArgs) Handles txtPONo.KeyDown
        If e.KeyCode = Keys.Enter Then LoadDataJOB(txtPONo.Text.Trim)

        If e.KeyCode = Keys.Enter Then
            Dim tblPur As New tbl_Pur
            Dim arr_tblPurPur As New tbl_Pur
            Dim msgerr As String = ""
            Dim getDatayarn As New GetDataYarn
            Dim objarr_tblPur() As tbl_Pur
            Dim ds As New DataSet
            Dim objsupp As New GetDataYarn

            Try
                arr_tblPurPur.purno = UCase(Me.txtPONo.Text.Trim)
                objarr_tblPur = getDatayarn.checkPurno(arr_tblPurPur, msgerr)
                If Not IsNothing(objarr_tblPur) Then

                    CbSupplier.SelectedValue = objarr_tblPur(0).suppcd
                ElseIf IsNothing(objarr_tblPur) Then
                    Me.CbSupplier.Text = ""
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub

    Private Sub LoadDataJOB(ByVal jobno As String)
        Dim dt As DataTable

        If txtPONo.Text = ("FREE SAMPLE") Or txtPONo.Text = ("FREE OF CHARGE") Or txtPONo.Text = ("ADJUST IN") Then
            dt = (New GetDataYarn).getJobFree(jobno)
        Else
            dt = (New GetDataYarn).getJob(jobno)
        End If

        grdPO.AutoGenerateColumns = False
        grdPO.DataSource = dt

        If dt.Rows.Count > 0 Then
            CbSupplier.SelectedValue = dt.Rows(0).Item("suppcd")
        End If

    End Sub

    Private Sub btnCopy_Click(sender As Object, e As EventArgs) Handles btnApplyCurrentBox.Click
        Call ApplyRow(DgYarn.CurrentRow.Index)
    End Sub

    Private Sub ApplyRow(RowNo As Integer)
        With DgYarn
            DgYarn.Rows(RowNo).Cells("DgYarnIDJobdet").Value() = grdPO.CurrentRow.Cells("grdPOIdJobDet").Value
            DgYarn.Rows(RowNo).Cells("cboitcd").Value() = grdPO.CurrentRow.Cells("grdPOitcd").Value
            DgYarn.Rows(RowNo).Cells("colItcd").Value() = grdPO.CurrentRow.Cells("grdPOitcd").Value

            DgYarn.EndEdit()
        End With
    End Sub

    Private Sub btnApplyAllBox_Click(sender As Object, e As EventArgs) Handles btnApplyAllBox.Click
        Dim dt3 As New DataTable
        For i = 0 To DgYarn.Rows.Count - 1
            ApplyRow(i)
        Next
    End Sub
End Class
