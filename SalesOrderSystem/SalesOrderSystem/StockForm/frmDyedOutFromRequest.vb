Imports System.Drawing
Imports System.Data.SqlClient
Imports System.Data
Imports System.Math
Public Class frmDyedOutFromRequest

    Dim clsconfig As New clsConfig
    Dim clsConn As New classConnection
    Dim clsuser As New classUserInfo
    Dim dbDyedOutFromRequest As New classDyedOutFromRequest
    Dim strreqno As String = ""
    Dim blnCancel As Boolean = False
    Dim strPacking_no As String = ""
    Dim strOutNo As String = ""
    Dim strPackno As String = ""
    Dim strCartno As String = ""
    Dim dtPackinglistD As New DataSet
    Dim PackinglistNo As String = ""
    'Dim Doc_type As String = ""


    Public Property Userinfo() As classUserInfo
        Get
            Userinfo = clsuser
        End Get
        Set(ByVal newvalue As classUserInfo)
            clsuser = newvalue
        End Set
    End Property

    Private Sub btnSearchREQD_Click(sender As System.Object, e As System.EventArgs) Handles btnSearchREQD.Click
        Dim frm As New frmSearchREQD
        frm.pStockType = "D"
        frm.pOutReqTyp = "M"
        frm.ShowDialog(Me)
        'Call btnNew_Click(sender, e)
        txtReqNo.Text = (frm.pReqNo)
        Me.Cursor = Cursors.WaitCursor
        If Not blnCancel Then GetREQD(txtReqNo.Text)
        Me.Cursor = Cursors.Default
        frm.Dispose()
    End Sub

    Private Function GetREQD(ByVal StrReqno As String) As Boolean

        ' Dim ReqNo As String
        ' ReqNo = txtReqNo.Text
        If StrReqno = "" Then Exit Function
        If Not Validate_ReqNoIsCancel(StrReqno) Then 'Check ReqNo ,Is' Cancel?
            MessageBox.Show("Req. No : " & StrReqno & "............   Req No. is Already Cancel!!")
            Exit Function

        End If
        If Not Validate_ReqNoGOut(StrReqno) Then 'Check ReqNo ,Is' used?
            MessageBox.Show("Req. No : " & StrReqno & "............   is Already Used!!" & vbNewLine & " For Out No. :" & strOutNo & vbNewLine & " Pack No. :" & strPackno)
            Exit Function

        End If

        Dim StrMessage As String = ""
        Dim dt As DataTable = dbDyedOutFromRequest.GetREQD(StrReqno, StrMessage)
        If dt.Rows.Count > 0 Then
            Call BindDataREQD(dt)
            txtReqNo.Text = dt.Rows(0)("outreqno").ToString()
            CboDoc_type.SelectedValue = dt.Rows(0)("outreqtyp").ToString()
            txtcustomer.Text = dt.Rows(0)("custname").ToString()

            Return True
        End If

        MessageBox.Show(StrMessage, "SyStem Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Return False
    End Function

    Private Function Validate_ReqNoIsCancel(ReqNo) As Boolean
        Dim objDB As New classDyedOutFromRequest
        Dim dt As DataTable = objDB.ValidateReqNoIsCancel(ReqNo, clsuser.UserID)

        If dt.Rows.Count = 0 Then
            Return False
        End If
        Return True
    End Function
    Private Function Validate_ReqNoGOut(ReqNo) As Boolean
        Dim objDB As New classDyedOutFromRequest
        Dim dt As DataTable = objDB.ValidateReqNoIsOut(ReqNo, clsuser.UserID)

        If dt.Rows.Count > 0 Then
            strOutNo = (dt.Rows(0)("outno").ToString)
            strPackNo = (dt.Rows(0)("packno").ToString)
            Return False
        End If
        Return True
    End Function

    Private Sub BindDataREQD(ByVal dt As DataTable)
        Dim config As New clsConfig
        If txtReqNo.Text = "" Then Exit Sub

        grdData.AutoGenerateColumns = False
        If dt.Rows.Count > 0 Then
            Dim dt1 As DataTable = dt
            Dim dt2 As DataTable = grdData.DataSource

            Dim dr As DataRow

            Dim msg As String = ""
            Dim i As Integer = 0
            Dim j As Integer = 0
            For i = 0 To dt.Rows.Count - 1
                'If (dt1.Rows(i)("sel").ToString) = True Then
                dr = dt2.NewRow



                For j = 0 To dt2.Columns.Count - 1
                    '(dt.Rows(0)("packdt").ToString)
                    dr("cartno") = dt1.Rows(i)("cartno")
                    dr("roll_no_d") = dt1.Rows(i)("roll_no_d")
                    dr("roll_no_o") = dt1.Rows(i)("roll_no_o")
                    dr("grade") = dt1.Rows(i)("grade")
                    dr("design_no") = dt1.Rows(i)("design_no")
                    dr("lot") = dt1.Rows(i)("lot")
                    dr("col") = dt1.Rows(i)("col")
                    dr("custcolor") = dt1.Rows(i)("custcolor")
                    'Format$(dblTestNumber, "##,##0.00")
                    'String.Format("{0:#,###0.00}", sumGrossAmt)
                    dr("outkg_g") = dt1.Rows(i)("outkg_g")
                    dr("outyd_g") = dt1.Rows(i)("outyd_g")
                    dr("outmt_g") = dt1.Rows(i)("outmt_g")
                    dr("sono") = dt1.Rows(i)("sono")
                    dr("sonoid") = dt1.Rows(i)("sonoid")
                    dr("Gwth") = dt1.Rows(i)("Gwth")
                    dr("Fwth") = dt1.Rows(i)("Fwth")
                    dr("outreqno") = dt1.Rows(i)("outreqno")
                    dr("outreqdt") = dt1.Rows(i)("outreqdt")
                    dr("outreqtyp") = dt1.Rows(i)("outreqtyp")
                    dr("pono") = dt1.Rows(i)("pono")
                    'dr("sono") = config.IsNull(dt1.Rows(i)("sono"), "")
                    'dr("sonoid") = config.IsNull(dt1.Rows(i)("sonoid"), "")
                    'Disible By Neung 14/03/2015
                    'dr(dt2.Columns(j).ColumnName.Trim) = dt1.Rows(i)(dt2.Columns(j).ColumnName.Trim)
                Next
                dt2.Rows.Add(dr)

            Next

        End If
        'Call SumGrdPackingList()


        'grdDataPackingList.DataSource = dt
        'txtReqNo.Text = dt.Rows(0)("outreqno").ToString()
    End Sub

    Private Sub grdDataPackingList_CellEndEdit(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles grdData.CellEndEdit
        'SumGrdPackingList()
    End Sub

    Private Sub frmDyedOutFromRequest_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        InitControl()
    End Sub
    Private Sub InitControl()
        Call GenCboDoc_type()

        Dim obj As Control
        For Each obj In Me.Controls
            Call SetControlValue(obj)
        Next
        CleargrdData()



        'txtPackNo.Text = "NEW"
        strPacking_no = "NEW"
        txtcustomer.Text = ""
        'btngout.Enabled = False
        DtpOutdt.Enabled = False
        lblCancelled.Visible = False

        Dim strreqno As String = ""
        Dim blnCancel As Boolean = False

        Dim strCartno As String = ""

        txtReqNo.Focus()

    End Sub

    Private Sub CleargrdData()
        Dim objdb As New classDyedOutFromRequest
        grdData.AutoGenerateColumns = False
        grdData.DataSource = objdb.GetDOUTDataDetail("0", "0", "0")

    End Sub

    Private Sub LoadgrdData(ByVal Outno As String)
        Dim objdb As New classDyedOutFromRequest
        grdData.AutoGenerateColumns = False
        grdData.DataSource = objdb.GetDOUTDataDetail(Outno, "", "")

    End Sub

    Private Sub GenCboDoc_type()
        Dim objDB As New classMaster

        CboDoc_type.DataSource = objDB.GetDocType
        CboDoc_type.DisplayMember = "name"
        CboDoc_type.ValueMember = "doctyp"

    End Sub

    Private Sub SetControlValue(ByVal Obj As Control)
        If TypeOf Obj Is TextBox Then
            Obj.Text = Obj.Tag
        End If
        If TypeOf Obj Is DateTimePicker Then
            Dim dtp As DateTimePicker = Obj
            dtp.Value = Now
        End If
        If TypeOf Obj Is ComboBox Then
            Dim cbo As ComboBox = Obj
            cbo.SelectedValue = 0
        End If
        If TypeOf Obj Is CheckBox Then
            Dim chk As CheckBox = Obj
            chk.Checked = False
        End If
        If TypeOf Obj Is RadioButton Then
            Dim opt As RadioButton = Obj
            opt.Checked = False
        End If
        If TypeOf Obj Is TabControl Or TypeOf Obj Is TabPage Or TypeOf Obj Is GroupBox Then
            Dim obj2 As Control
            For Each obj2 In Obj.Controls
                Call SetControlValue(obj2)
            Next
        End If
    End Sub

    Private Sub btnNew_Click(sender As System.Object, e As System.EventArgs) Handles btnNew.Click
        InitControl()
    End Sub

    Private Sub BtnPrint_Click(sender As System.Object, e As System.EventArgs) Handles BtnPrint.Click
        If txtOutNo.Text.Length = 0 Then Exit Sub
        Const rptFileName = "rptDOUT.rpt"

        If clsuser.ReportPath = "" Then clsuser.ReportPath = clsuser.ReportPath
        If Not clsconfig.CheckReport(clsuser.ReportPath, rptFileName) Then Exit Sub
        'Dim frm As New frmReportPLG
        Dim frm As New frmReport
        Dim rpt As New CrystalDecisions.CrystalReports.Engine.ReportDocument
        Me.Cursor = Cursors.WaitCursor
        rpt.Load(clsuser.ReportPath & rptFileName)
        rpt.DataSourceConnections.Item(0).SetConnection(clsConn.servername, clsConn.database, False)
        rpt.DataSourceConnections.Item(0).SetLogon(clsConn.Userid, clsConn.Password)
        rpt.VerifyDatabase()
        rpt.SetParameterValue("@outno", txtOutNo.Text.Trim)

        rpt.PrintOptions.PaperSize = CrystalDecisions.Shared.PaperSize.PaperA4
        rpt.PrintOptions.PaperOrientation = CrystalDecisions.Shared.PaperOrientation.Portrait
        rpt.PrintOptions.PaperSource = CrystalDecisions.Shared.PaperSource.Auto

        frm.Title = "DYED OUT"
        frm.CRViewer.ReportSource = rpt
        'Dim dt As New DataTable
        frm.MdiParent = Me.ParentForm
        frm.Show()
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub btnSearchOutno_Click(sender As System.Object, e As System.EventArgs) Handles btnSearchOutno.Click
        Dim frm As New frmSearchDOUT
        frm.pStockType = "D"
        frm.pDoctype = "M"
        frm.ShowDialog(Me)
        'Call btnNew_Click(sender, e)
        txtOutNo.Text = (frm.pOutno)
        Me.Cursor = Cursors.WaitCursor
        If Not blnCancel Then LoadgrdData(txtOutNo.Text)
        Me.Cursor = Cursors.Default
        frm.Dispose()
    End Sub

    Private Sub BtnSave_Click(sender As System.Object, e As System.EventArgs) Handles BtnSave.Click
        CheckSaveDOUT()
    End Sub
    Private Sub CheckSaveDOUT()
        'Dim DOUTHeader As classDyedOutFromRequest.DyedOutFromRequestHeader

        'If DOUTHeader.outno = "" Then strOutNo = txtOutNo.Text.Trim.ToUpper
        'If DOUTHeader.outno.Length = 0 Then Exit Sub

        If grdData.DataSource Is Nothing Then Exit Sub
        If grdData.Rows.Count = 0 Then Exit Sub


        blnCancel = False
        'Sitthana 20220624 Changed Windows.Forms.DialogResult To DialogResult
        Dim result As DialogResult ' Windows.Forms.DialogResult
        result = MessageBox.Show("Would you like to save Dyed Out ?", "System Message", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button3)
        If result = DialogResult.Cancel Then blnCancel = True
        If result <> DialogResult.Yes Then Exit Sub

        If SaveDYEDOUT() Then
            MessageBox.Show("Out No. : " & txtOutNo.Text & "บันทึกสำเร็จ ! ", "System Message", MessageBoxButtons.OK, MessageBoxIcon.None, MessageBoxDefaultButton.Button1)
            LoadgrdData(txtOutNo.Text)
            'Validate_Outno()
        End If

    End Sub

    Private Function SaveDYEDOUT() As Boolean
        Dim config As New clsConfig
        Dim objdb As New classDyedOutFromRequest
        Dim DOUTHeader As New classDyedOutFromRequest.DyedOutFromRequestHeader
        Dim msgerr As String = ""

        Dim PLDNo As String = strPacking_no
        Dim OUTNo As String = strOutNo
        Dim OUTREQNo As String = txtReqNo.Text
        Dim OUTDT As String = DtpOutdt.Value.ToString("yyyyMMdd")
        Dim USERID As String = clsuser.UserID
        Dim CheckNEW As String = txtOutNo.Text.Trim
        'Dim Doc_type As String = CboDoc_type.SelectedValue

        Dim dtd As DataTable = grdData.DataSource
        Dim dv_dtd_add As New DataView(dtd, "", "", DataViewRowState.Added)
        Dim dv_dtd_upd As New DataView(dtd, "", "", DataViewRowState.ModifiedCurrent)
        Dim dv_dtd_del As New DataView(dtd, "", "", DataViewRowState.Deleted)

        DOUTHeader.outno = txtOutNo.Text.Trim
        DOUTHeader.outdt = DtpOutdt.Value.Date
        DOUTHeader.empcd = clsuser.UserID.Trim
        DOUTHeader.outreqtyp = CboDoc_type.SelectedValue
        DOUTHeader.msgerr = ""


        If objdb.SAVEDOUT(DOUTHeader, dtd, dv_dtd_add, dv_dtd_upd, dv_dtd_del, clsuser) Then
            'PackinglistNo = PLDNo
            'strOutNo = OUTNo
            'ValidateOutno()
            'Validate_Outno()
            txtOutNo.Text = DOUTHeader.outno
            SaveDYEDOUT = True

        Else
            SaveDYEDOUT = False
            MessageBox.Show(DOUTHeader.msgerr, "System Message", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
        End If


    End Function

    Private Sub txtOutNo_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles txtOutNo.KeyDown
        If e.KeyCode.Equals(Keys.Enter) Then
            If Not blnCancel Then LoadgrdData(txtOutNo.Text)
        End If
    End Sub

    Private Sub txtOutNo_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtOutNo.TextChanged

    End Sub

    Private Sub txtReqNo_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles txtReqNo.KeyDown
        If e.KeyCode.Equals(Keys.Enter) Then
            If Not blnCancel Then GetREQD(txtReqNo.Text)
        End If
    End Sub

    Private Sub BtnCancel_Click(sender As System.Object, e As System.EventArgs) Handles BtnCancel.Click
        CheckCancelDYEDOUT()
    End Sub
    Private Sub CheckCancelDYEDOUT()

        If txtOutNo.Text.Trim = "" Then Exit Sub
        If grdData.DataSource Is Nothing Then Exit Sub
        If grdData.Rows.Count = 0 Then Exit Sub

        If blnCancel Then Exit Sub

        If MessageBox.Show("Would you like to cancel this document ?", "System Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = DialogResult.No Then Exit Sub

        If CancelDYEDOUT() Then
            MessageBox.Show("Out NO." & vbCrLf & strOutNo & "is Cancel", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Call InitControl()

        End If

    End Sub

    Private Function CancelDYEDOUT() As Boolean
        Dim config As New clsConfig
        Dim objdb As New classDyedOutFromRequest
        Dim DOUTHeader As New classDyedOutFromRequest.DyedOutFromRequestHeader
        Dim msgerr As String = ""

        Dim OUTDT As String = DtpOutdt.Value.ToString("yyyyMMdd")
        Dim USERID As String = clsuser.UserID
        Dim CheckNEW As String = txtOutNo.Text.Trim


        Dim dtd As DataTable = grdData.DataSource
        Dim dv_dtd_add As New DataView(dtd, "", "", DataViewRowState.Added)
        Dim dv_dtd_upd As New DataView(dtd, "", "", DataViewRowState.ModifiedCurrent)
        Dim dv_dtd_del As New DataView(dtd, "", "", DataViewRowState.Deleted)

        DOUTHeader.outno = txtOutNo.Text.Trim
        DOUTHeader.outdt = DtpOutdt.Value.Date
        DOUTHeader.empcd = clsuser.UserID.Trim
        DOUTHeader.outreqtyp = CboDoc_type.SelectedValue
        DOUTHeader.msgerr = ""

        If objdb.CANCELDOUT(DOUTHeader, dtd, dv_dtd_add, dv_dtd_upd, dv_dtd_del, clsuser) Then

            strOutNo = DOUTHeader.outno
            CancelDYEDOUT = True

        Else
            CancelDYEDOUT = False
            MessageBox.Show(DOUTHeader.msgerr, "System Message", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
        End If
    End Function
End Class