Imports System.Data
Imports System.Data.SqlClient
Imports System.Text


Public Class formYarnoutOld

    Public loginEmpcd As String
    Private Clsconfig As New clsConfig
    Private dsYarn_in_det As DataTable
    Private ds As New DataSet
    Private connStr As New classConnection
    Private dt As DataTable
    Private dtJob As DataTable
    Dim clsUser As New classUserInfo
    Public Property UserInfo() As classUserInfo
        Get
            UserInfo = clsUser
        End Get
        Set(ByVal NewValue As classUserInfo)
            clsUser = NewValue
        End Set
    End Property
    Private Sub formYarnOut_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        formatform()
        Me.DgYarnOut.AutoGenerateColumns = False
        insertcombotrantype()
        insertcomboitemcode()
    End Sub

    Private Sub formatform()

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

    Private Sub txtJobno_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextJobNo.KeyPress
        If AscW(e.KeyChar) = 13 Then

            If Not CheckDataJob() Then Exit Sub

            Me.btnNew.Visible = False
            Me.BtnSave.Visible = True

            Me.textYarnInNo.Text = " "
            Call loadjobdata()

        End If
    End Sub

    Private Function CheckDataJob() As Boolean

        If Not Validate_JobNoAlreadyUse(TextJobNo.Text.Trim) Then Return False

        If (New classYarnOut).ValitateJobNoAlreadyKOClosed(StrJobno:=TextJobNo.Text.Trim) Then
            MessageBox.Show("ไม่สามารถ Yarn Out ได้ เนื่องจาก Production Order ถูก Closed ไปแล้ว", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button3)
            Return False
        End If

        Return True
    End Function
    Private Function Validate_JobNoAlreadyUse(Optional ByVal StrJobno As String = "") As Boolean
        Dim objdb As New classYarnOut
        Dim dt As DataTable = objdb.ValidateJobNoAlreadyOut(StrJobno, Me.loginEmpcd)

        If dt.Rows.Count > 0 Then
            MessageBox.Show("Job No .: " & StrJobno & "............   is Already Out!! For Outno : " & dt.Rows(0)("outno").ToString, "SyStem Messsage", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return False
        Else
            Return True
        End If


    End Function

    Private Sub LoadDataYarnInToYarnOut(ByVal SourceDoc As String)
        Dim getDatayarn As New GetDataYarn
        'Dim dt As DataTable
        If SourceDoc = "YIN" Then
            dt = getDatayarn.GetDataYarnOut(Me.textYarnInNo.Text, SourceDoc)
        Else
            dt = getDatayarn.GetDataYarnOut(Me.TextJobNo.Text, SourceDoc)
        End If
        If dt.Rows.Count > 0 Then
            Me.DgYarnOut.DataSource = dt
            'Me.lblYINDate.Text = dt.Rows(0).Item("docdt")
            Me.txtsupplier.Text = dt.Rows(0).Item("supname")
            Me.CbTrantype.SelectedValue = dt.Rows(0).Item("tran_type")
            txtkono.Text = dt.Rows(0).Item("kono")
            Dim dr As DataRow
            For Each dr In dt.Rows
                With Me.DgYarnOut
                    .Columns(1).DataPropertyName = "itcd"
                    Me.DgCombobox.ValueMember = "itcd"
                    .Columns(2).DataPropertyName = "grade"
                    .Columns(3).DataPropertyName = "boxno_s"
                    .Columns(4).DataPropertyName = "boxno"
                    .Columns(5).DataPropertyName = "spools"
                    .Columns(6).DataPropertyName = "kg_gr"
                    .Columns(7).DataPropertyName = "cart_tearwt"
                    .Columns(8).DataPropertyName = "kg_nt"
                    .Columns(9).DataPropertyName = "id_job_det_yarn"
                End With
            Next
            totalSum()
        Else
            MsgBox("Job order not found, please check if Y-out is already made..", MsgBoxStyle.Critical, "Cannot find")
            Me.DgYarnOut.DataSource = dt
            'Me.lblYINDate.Text = ""
            totalSum()
        End If
    End Sub

    Private Sub totalSum()
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
        'Sitthana 17/10/2018
        If txtYOUT.Text.Trim <> "" Then
            MessageBox.Show("รายการนี้ได้สร้างเรียบร้อยแล้วครับ คุณจะไม่สามารถแก้ไขได้" & vbCr _
                          & Space(5) & "ถ้าคุณจะแก้ไข ให้ใช้โปรแกรม Edit ครับ" _
                          , "ข้อความแจ้งเตือน", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        ElseIf DgYarnOut.Rows.Count <= 1 Then
            MessageBox.Show("ไม่มีรายการใน Grid" & vbCr _
                          & Space(5) & "ให้คุณ ระบุรายการก่อน ครับ" _
                          , "ข้อความแจ้งเตือน", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            If Not CheckData() Then Exit Sub

            If MsgBox("Are you sure to Save ?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                InsertData()
            End If
        End If
    End Sub

    Public Function CheckData() As Boolean


        If Not (New classYarnOut).ValidateJobno(StrJobno:=TextJobNo.Text.Trim) Then
            MessageBox.Show("JobNo :" & TextJobNo.Text.Trim & "InCorrect", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.ErrorProvider1.SetError(Me.TextJobNo, "JobNo :" & TextJobNo.Text.Trim & "InCorrect")
            Return False
        Else
            Me.ErrorProvider1.Clear()
        End If

        If Not (New classYarnOut).ValidateOutno(StrOutno:=txtYOUT.Text.Trim) Then
            MessageBox.Show("Outno :" & txtYOUT.Text.Trim & " Already", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.ErrorProvider1.SetError(Me.txtYOUT, "Outno :" & txtYOUT.Text.Trim & " Already")
            Return False
        Else
            Me.ErrorProvider1.Clear()
        End If

        ' If (New classYarnOut).ValitateJobNoAlreadyKOClosed(StrJobno:=TextJobNo.Text.Trim) Then
        'MessageBox.Show("ไม่สามารถ Yarn Out ได้ เนื่องจาก Production Order ถูก Closed ไปแล้ว", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button3)
        'Return False
        'End If

        Return True  'Sitthana 06/03/2018
    End Function

    Private Sub InsertData()
        Dim config As New clsConfig
        config.ChangeCulture()

        Dim tbl_Yarn_out As New tbl_Yarn_out
        Dim InsertYarn As New InsertYarn
        Dim isvalid As Boolean
        Try

            'tbl_Yarn_out.outno =
            tbl_Yarn_out.outdt = Me.Datetime.Value.ToString("yyyyMMdd")
            tbl_Yarn_out.tran_type = CbTrantype.SelectedValue
            'disible by neung jobno Is emply
            'If Me.textYarnInNo.Text = " " Then
            '    tbl_Yarn_out.refdocno = Me.TextJobNo.Text.ToUpper.Trim
            'Else
            '    tbl_Yarn_out.refdocno = Me.textYarnInNo.Text.ToUpper.Trim
            'End If
            'disible by neung jobno Is emply
            tbl_Yarn_out.refdocno = Me.TextJobNo.Text.ToUpper.Trim
            tbl_Yarn_out.suppcd = dt.Rows(0).Item("suppcd").ToString
            tbl_Yarn_out.remm = Me.txtRemark.Text
            tbl_Yarn_out.kono = txtkono.Text

            Dim count As Integer
            Dim i As Integer
            Dim j As Integer = 0
            count = Me.DgYarnOut.Rows.Count - 2

            For i = 0 To count
                If Me.DgYarnOut.Rows(i).Cells(0).Value = True Then
                    ReDim Preserve tbl_Yarn_out.tbl_Yarn_out_det(j)
                    tbl_Yarn_out.tbl_Yarn_out_det(j) = New tbl_Yarn_out_det
                    tbl_Yarn_out.tbl_Yarn_out_det(j).itcd = Me.DgYarnOut.Rows(i).Cells(1).Value.ToString
                    tbl_Yarn_out.tbl_Yarn_out_det(j).grade = Me.DgYarnOut.Rows(i).Cells("grade").Value.ToString
                    'tbl_Yarn_out.tbl_Yarn_out_det(j).boxno_s = Me.DgYarnOut.Rows(i).Cells("boxno_s").Value.ToString
                    tbl_Yarn_out.tbl_Yarn_out_det(j).boxno = Me.DgYarnOut.Rows(i).Cells("boxno").Value.ToString
                    tbl_Yarn_out.tbl_Yarn_out_det(j).spools = Clsconfig.IsValidDouble(Me.DgYarnOut.Rows(i).Cells("spools").Value)
                    tbl_Yarn_out.tbl_Yarn_out_det(j).kg_gr = Clsconfig.IsValidDouble(Me.DgYarnOut.Rows(i).Cells("kg_gr").Value)
                    tbl_Yarn_out.tbl_Yarn_out_det(j).cart_tearwt = Clsconfig.IsValidDouble(Me.DgYarnOut.Rows(i).Cells("cart_tearwt").Value)
                    tbl_Yarn_out.tbl_Yarn_out_det(j).kg_nt = Clsconfig.IsValidDouble(Me.DgYarnOut.Rows(i).Cells("kg_nt").Value)
                    tbl_Yarn_out.tbl_Yarn_out_det(j).actual_cone_weight = Clsconfig.IsValidDecimal(Me.DgYarnOut.Rows(i).Cells("actual_cone_weight").Value)
                    tbl_Yarn_out.tbl_Yarn_out_det(j).id_job_det_yarn = Me.DgYarnOut.Rows(i).Cells("id_Job_det_yarn").Value
                    j = j + 1
                Else
                End If
            Next

            'Dim Youtno As String = ""
            Dim msgerr As String = ""
            isvalid = InsertYarn.InsertYarnOut(tbl_Yarn_out, msgerr, Me.loginEmpcd)

            If isvalid = True Then
                MsgBox("success")
                txtYOUT.Text = tbl_Yarn_out.outno
                Me.btnNew.Visible = False
                Me.BtnSave.Visible = True
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
        '      obj.Load(clsuser.reportpath & rptFileName)
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
        'Dim rptFileName As String = "RptYarnOut.rpt"
        Dim frm As New frmReport

        If Not Clsconfig.CheckReport(clsuser.reportpath, rptFileName) Then Exit Sub
        Dim rpt As New CrystalDecisions.CrystalReports.Engine.ReportDocument
        Me.Cursor = Cursors.WaitCursor

        rpt.Load(clsuser.reportpath & rptFileName)
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
        Me.btnNew.Visible = False
        Me.BtnSave.Visible = True
        If Me.DgYarnOut.Rows.Count > 0 Then
            Me.DgYarnOut.Rows.Clear()
        End If
    End Sub

    Private Sub TextJobNo_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextJobNo.TextChanged

    End Sub

    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
        Dim frm As New formSearchJob
        frm.ShowDialog()
        If frm.pblnOk = True Then
            Me.TextJobNo.Text = frm.pJobNo
            If Not CheckDataJob() Then Exit Sub

            Call loadjobdata()
        End If

        frm.Dispose()
    End Sub

    Private Sub loadjobdata()
        LoadDataYarnInToYarnOut("JOB")
        Dim i As Integer
        Dim count As Integer
        count = Me.DgYarnOut.Rows.Count - 2
        For i = 0 To count
            Me.DgYarnOut.Rows(i).Cells(0).Value = True
        Next
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

    End Sub
End Class