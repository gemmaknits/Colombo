Imports System.Data
Imports System.Data.SqlClient
Imports System.Text

Public Class FormYarnOutKnittingEdit

    Public loginEmpcd As String
    Private Clsconfig As New clsConfig
    Private dsYarn_in_det As New DataTable
    Private da As New SqlDataAdapter
    Private ds As New DataSet
    Private connStr As New classConnection
    Private dt As New DataTable
    Private dtJob As New DataTable
    Private oldRefDocno As String

    Private Sub FormYarnOutKnittingEdit_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Me.DgYarnOut.AutoGenerateColumns = False
        insertcombotrantype()
        insertcomboitemcode()
        GenSoNoInGridData()
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
        End If
    End Sub

    Private Sub insertcomboitemcode()
        Dim tblItems As New tbl_Items
        Dim getDatayarn As New GetDataYarn
        Dim ds As New DataSet
        tblItems.itcd = ""
        ds = getDatayarn.GetDataItem(tblItems)
        If Not IsNothing(ds) Then
            Me.DgCombobox.DataSource = ds.Tables(0)
            Me.DgCombobox.DisplayMember = "itdesc"
            Me.DgCombobox.ValueMember = "Itcd"

        End If
    End Sub


    Private Sub GenSoNoInGridData()
        Dim Objdb As New GetDataYarn
        Me.GB.DataSource = Objdb.getGB()
        Me.GB.DisplayMember = "gb"
        Me.GB.ValueMember = "gb"
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
        Try
            Dim countGrid As Integer
            countGrid = Me.DgYarnOut.Rows.Count
            For i = 0 To Me.DgYarnOut.Rows.Count - 2
                Dim kg_gr As Double
                Dim kg_nt As Double

                If IsDBNull(Me.DgYarnOut.Rows(i).Cells("Kg_gr").Value) Then
                    kg_gr = 0
                Else
                    kg_gr = Clsconfig.IsValidDouble(Me.DgYarnOut.Rows(i).Cells("Kg_gr").Value)
                End If

                If IsDBNull(Me.DgYarnOut.Rows(i).Cells("Kg_nt").Value) Then
                    kg_nt = 0
                Else
                    kg_nt = Clsconfig.IsValidDouble(Me.DgYarnOut.Rows(i).Cells("Kg_nt").Value)
                End If

                sumgross = sumgross + kg_gr
                sumnet = sumnet + kg_nt
            Next
            Me.txttotalgross.Text = sumgross
            Me.txttotalnet.Text = sumnet
            txttotalboxes.Text = Me.DgYarnOut.RowCount - 1
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub LoadDataYarnInToYarnOut(ByVal SourceDoc As String)
        Dim getDatayarn As New GetDataYarn
        Dim dt2 As New DataTable
        If IIf(SourceDoc = "YIN", textYarnInNo.Text.Trim.Length, TextJobNo.Text.Trim.Length) < 8 Then Exit Sub
        dt2 = getDatayarn.GetDataYarnOut(IIf(SourceDoc = "YIN", textYarnInNo.Text.Trim, TextJobNo.Text.Trim), SourceDoc)
        DgYarnOut.DataSource = dt2
        Call totalsum()

        'If SourceDoc = "YIN" Then
        '	dt = getDatayarn.GetDataYarnOut(Me.textYarnInNo.Text, SourceDoc)
        'Else
        '	dt = getDatayarn.GetDataYarnOut(Me.TextJobNo.Text, SourceDoc)
        'End If

        'If dtJob.Rows.Count > 0 Then
        '	If SourceDoc = "YIN" Then
        '		Me.DgYarnOut.DataSource = dt
        '	Else
        '		For i As Integer = dt.Rows.Count() - 1 To 0 Step -1
        '			dt.Rows(i).Delete()
        '		Next

        '		For i As Integer = 0 To dtJob.Rows.Count - 1
        '			Dim newRow As DataRow
        '			newRow = dt.NewRow
        '			newRow.Item("itcd") = dtJob.Rows(i).Item("itcd")
        '			newRow.Item("grade") = dtJob.Rows(i).Item("grade")
        '			newRow.Item("boxno_s") = dtJob.Rows(i).Item("boxno_s")
        '			newRow.Item("boxno") = dtJob.Rows(i).Item("boxno")
        '			newRow.Item("spools") = dtJob.Rows(i).Item("spools")
        '			newRow.Item("kg_gr") = dtJob.Rows(i).Item("kg_gr")
        '			newRow.Item("itcd") = dtJob.Rows(i).Item("itcd")
        '			'newRow.Item("cart_tearwt") = dtJob.Rows(i).Item("cart_tearwt")
        '			newRow.Item("kg_nt") = dtJob.Rows(i).Item("kg_nt")
        '			dt.Rows.Add(newRow)
        '			Me.DgYarnOut.DataSource = dt
        '		Next i
        '	End If

        '	'Me.lblYINDate.Text = dt.Rows(0).Item("docdt")
        '	Me.txtsupplier.Text = dt.Rows(0).Item("supname")
        '	Dim dr As DataRow
        '	For Each dr In dt.Rows
        '		With Me.DgYarnOut
        '			.Columns(1).DataPropertyName = "itcd"
        '			Me.DgCombobox.ValueMember = "itcd"
        '			.Columns(2).DataPropertyName = "grade"
        '			.Columns(3).DataPropertyName = "boxno_s"
        '			.Columns(4).DataPropertyName = "boxno"
        '			.Columns(5).DataPropertyName = "spools"
        '			.Columns(6).DataPropertyName = "kg_gr"
        '			.Columns(7).DataPropertyName = "cart_tearwt"
        '			.Columns(8).DataPropertyName = "kg_nt"
        '		End With
        '	Next

        '	totalsum()
        'Else
        '	Me.DgYarnOut.DataSource = dt
        '	'Me.lblYINDate.Text = ""
        '	totalsum()
        'End If
    End Sub

    Private Sub totalsum()
        Dim sumgross As Double
        Dim sumnet As Double
        Dim i As Integer
        Try
            Dim countGrid As Integer
            countGrid = Me.DgYarnOut.Rows.Count
            For i = 0 To Me.DgYarnOut.Rows.Count - 2
                Dim kg_gr As Double
                Dim kg_nt As Double

                If IsDBNull(Me.DgYarnOut.Rows(i).Cells(6).Value) Then
                    kg_gr = 0
                Else
                    kg_gr = Clsconfig.IsValidDouble(Me.DgYarnOut.Rows(i).Cells(6).Value)
                End If

                If IsDBNull(Me.DgYarnOut.Rows(i).Cells(8).Value) Then
                    kg_nt = 0
                Else
                    kg_nt = Clsconfig.IsValidDouble(Me.DgYarnOut.Rows(i).Cells(8).Value)
                End If

                sumgross = sumgross + kg_gr
                sumnet = sumnet + kg_nt
            Next
            Me.txttotalgross.Text = sumgross
            Me.txttotalnet.Text = sumnet
            txttotalboxes.Text = Me.DgYarnOut.RowCount - 1
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Me.Close()
    End Sub

    Private Sub BtnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSave.Click
        If MsgBox("Are you sure to Save ?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            InsertData()
        End If
    End Sub

    Private Sub InsertData()
        Dim config As New clsConfig
        config.ChangeCulture()

        Dim tbl_Yarn_out As New tbl_Yarn_out
        Dim UpdateYarn As New UpdateYarn
        Dim isvalid As Boolean
        Try

            'tbl_Yarn_out.outno =
            'tbl_Yarn_out.outdt = Me.textYoutDate.Text.ToString("yyy/MM/dd")
            tbl_Yarn_out.tran_type = CbTrantype.SelectedValue
            If Me.textYarnInNo.Text = "" Then
                tbl_Yarn_out.refdocno = Me.TextJobNo.Text.ToUpper.Trim
            Else
                tbl_Yarn_out.refdocno = Me.textYarnInNo.Text.ToUpper.Trim
            End If
            tbl_Yarn_out.outno = Me.txtYOUT.Text.Trim
            '			tbl_Yarn_out.suppcd = dt.Rows(0).Item("suppcd").ToString
            tbl_Yarn_out.remm = Me.txtRemark.Text

            Dim count As Integer
            Dim i As Integer
            Dim j As Integer = 0
            count = Me.DgYarnOut.Rows.Count - 2

            For i = 0 To count
                If Me.DgYarnOut.Rows(i).Cells(0).Value = True Then
                    ReDim Preserve tbl_Yarn_out.tbl_Yarn_out_det(j)
                    tbl_Yarn_out.tbl_Yarn_out_det(j) = New tbl_Yarn_out_det
                    tbl_Yarn_out.tbl_Yarn_out_det(j).itcd = Me.DgYarnOut.Rows(i).Cells("DgCombobox").Value.ToString
                    tbl_Yarn_out.tbl_Yarn_out_det(j).grade = Me.DgYarnOut.Rows(i).Cells("grade").Value.ToString
                    'tbl_Yarn_out.tbl_Yarn_out_det(j).boxno_s = Me.DgYarnOut.Rows(i).Cells("boxno_s").Value.ToString
                    tbl_Yarn_out.tbl_Yarn_out_det(j).boxno = Me.DgYarnOut.Rows(i).Cells("boxno").Value.ToString
                    tbl_Yarn_out.tbl_Yarn_out_det(j).gb = Me.DgYarnOut.Rows(i).Cells("gb").Value.ToString
                    'tbl_Yarn_out.tbl_Yarn_out_det(j).spools = Clsconfig.IsValidDouble(Me.DgYarnOut.Rows(i).Cells("spools").Value)
                    'tbl_Yarn_out.tbl_Yarn_out_det(j).kg_gr = Clsconfig.IsValidDouble(Me.DgYarnOut.Rows(i).Cells("kg_gr").Value)
                    'tbl_Yarn_out.tbl_Yarn_out_det(j).cart_tearwt = Clsconfig.IsValidDouble(Me.DgYarnOut.Rows(i).Cells("cart_tearwt").Value)
                    'tbl_Yarn_out.tbl_Yarn_out_det(j).kg_nt = Clsconfig.IsValidDouble(Me.DgYarnOut.Rows(i).Cells("kg_nt").Value)
                    j = j + 1
                Else
                End If
            Next

            Dim Youtno As String = ""
            Dim msgerr As String = ""
            Dim RefDocnochanged As Boolean
            If tbl_Yarn_out.refdocno <> oldRefDocno Then
                RefDocnochanged = True
            Else
                RefDocnochanged = False
            End If
            'isvalid = UpdateYarn.UpdateYarnOut(tbl_Yarn_out, dt, msgerr, Me.loginEmpcd, RefDocnochanged)
            isvalid = UpdateYarn.UpdateYarnOut(tbl_Yarn_out, DgYarnOut.DataSource, msgerr, Me.loginEmpcd, RefDocnochanged)

            If isvalid = True Then
                MsgBox("success")
                dt.AcceptChanges()
            Else
                MsgBox(msgerr)
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
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
        '      obj.Load(Clsconfig.ReportPath & rptFileName)
        '      'Dim obj As New RptYarnOut
        'obj.SetDataSource(ds.Tables("TblDatayarnout"))

        'frmreport.CrystalReportViewer1.ReportSource = obj

        'frmreport.ShowDialog()
        Dim clsYarnOutBarCode As New classYarnOutBarcode
        Dim rptFileName As String
        rptFileName = "RptYarnOut.rpt"

        Dim dt As DataTable = clsYarnOutBarCode.GetYOutByJob(strJobNo:="", strOutno:=txtYOUT.Text.Trim, strlogempcd:=loginEmpcd)
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

        If Not Clsconfig.CheckReport(Clsconfig.ReportPath, rptFileName) Then Exit Sub
        Dim rpt As New CrystalDecisions.CrystalReports.Engine.ReportDocument
        Me.Cursor = Cursors.WaitCursor

        rpt.Load(Clsconfig.ReportPath & rptFileName)
        rpt.DataSourceConnections.Item(0).SetConnection(clsConn.servername, clsConn.DatabaseName, False)
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

    Private Sub textYarnInNo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles textYarnInNo.KeyPress
        'If e.KeyChar = vbCr Then
        '	LoadDataYarnInToYarnOut("YIN")
        'End If
    End Sub

    Private Sub txtJobno_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextJobNo.KeyPress
        'If AscW(e.KeyChar) = 13 Then
        'If e.KeyChar = vbCr Then
        '	LoadDataYarnInToYarnOut("JOB")
        'End If
    End Sub

    Private Sub textYarnInNo_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles textYarnInNo.TextChanged
        'If TextJobNo.Text.Trim.Length < 8 Then Exit Sub
        'Call LoadDataYarnInToYarnOut("YIN")
        'Dim i As Integer
        'Me.DgYarnOut.Visible = False
        'For i = 0 To Me.DgYarnOut.Rows.Count - 2
        '	Me.DgYarnOut.Rows(i).Cells(0).Value = True
        'Next
        'Me.DgYarnOut.Refresh()
        'Me.DgYarnOut.Visible = True
        'Me.TextJobNo.Text = ""
    End Sub

    Private Sub TextJobNo_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextJobNo.TextChanged
        'If TextJobNo.Text.Trim.Length < 8 Then Exit Sub
        'Call LoadDataYarnInToYarnOut("JOB")
        'Dim i As Integer
        'Me.DgYarnOut.Visible = False
        'For i = 0 To Me.DgYarnOut.Rows.Count - 2
        '	Me.DgYarnOut.Rows(i).Cells(0).Value = True
        'Next
        'Me.DgYarnOut.Refresh()
        'Me.DgYarnOut.Visible = True
        'Me.textYarnInNo.Text = ""
    End Sub

    Private Sub txtYOUT_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtYOUT.KeyPress
        If AscW(e.KeyChar) = 13 Then
            If txtYOUT.Text.Trim.Length > 8 Then loadDataYarnOut()
        End If
    End Sub

    Private Sub loadDataYarnOut()
        Dim Getdatayarnout As New GetDataYarn
        Dim msgerr As String = ""
        Dim dtt As New DataTable
        dtt = Getdatayarnout.GetData_YarnOut(Me.txtYOUT.Text.Trim, da, msgerr)
        dt.Dispose()
        dt = New DataTable
        dt = Getdatayarnout.GetData_YarnOutdet(Me.txtYOUT.Text, da, msgerr)
        Me.DgYarnOut.DataSource = dt
        If dt.Rows.Count > 0 Then
            Me.TextJobNo.Text = dtt.Rows(0).Item("refdocno").ToString
            Me.oldRefDocno = dtt.Rows(0).Item("refdocno").ToString
            Me.textYoutDate.Text = dtt.Rows(0).Item("outdt").ToString

            txtsupplier.Text = Getdatayarnout.GetData_NameSuppliers(dtt.Rows(0).Item("suppcd").ToString, msgerr)
            CbTrantype.SelectedValue = dtt.Rows(0).Item("tran_type").ToString
            Me.textStatus.Text = dtt.Rows(0).Item("present_status").ToString
            txtRemark.Text = dtt.Rows(0).Item("rem").ToString
        End If
    End Sub

    Private Sub DgYarnOut_DefaultValuesNeeded(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewRowEventArgs) Handles DgYarnOut.DefaultValuesNeeded
        e.Row.Cells("outno").Value = Me.txtYOUT.Text
    End Sub

    Private Sub btnSearchYout_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearchYout.Click
        Dim selectedYarnOut As String
        Dim formSearchyarnOut As New formSearchYarnOut
        selectedYarnOut = formSearchyarnOut.getYarnOutno
        If selectedYarnOut <> "" Then
            Me.txtYOUT.Text = selectedYarnOut
        End If
        loadDataYarnOut()
    End Sub

    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
        Dim selectedJobno As String
        Dim formSearchJobno As New formSearchJob
        selectedJobno = formSearchJob.getJobno
        If selectedJobno <> "" Then
            Me.TextJobNo.Text = selectedJobno
        End If
        LoadDataYarnInToYarnOut("JOB")

    End Sub

End Class