Imports System.Drawing
Imports System.Data.SqlClient
Imports System.Data
Imports System.Math

Public Class frmPackingListDyed

    Dim oConfig As New clsConfig
    Dim clsConn As New ClassConnection
    Dim clsuser As New classUserInfo

    Dim dbPackingListD As New classPackingListD
    Dim strreqno As String = ""
    Dim blnCancel As Boolean = False
    Dim strPacking_no As String = ""
    Dim strPackingNo As String = ""
    Dim strOut_no As String = ""
    Dim strCartno As String = ""
    Dim dtPackinglistD As New DataSet
    Dim PackinglistNo As String = ""
    Dim _StockType As String
    'Dim Doc_type As String = ""

    Public Property pStockType As String
        Get
            pStockType = _StockType
        End Get
        Set(ByVal Newvalue As String)
            _StockType = Newvalue
        End Set
    End Property
    Public Property Userinfo() As classUserInfo
        Get
            Userinfo = clsuser
        End Get
        Set(ByVal newvalue As classUserInfo)
            clsuser = newvalue
        End Set
    End Property

    Private Sub frmPackingListDyedOut_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
        Call InitControl()

    End Sub
    Private Sub InitControl()
        Call GenCboDoc_type()
        Call GenCboCartonsNo()
        'Call GenComboCustomer()
        'Dim obj As Control
        For Each obj In Me.Controls
            Call SetControlValue(obj)
        Next
        CleargrdDataPackingList()
        CleargrdDataCartons()
        ClearCboCartonsNo()
        'ClearcboCustomer()
        txtPackNo.Text = "NEW"
        strPacking_no = "NEW"
        txtcustomer.Text = ""
        btngout.Enabled = False
        DtpOutdt.Enabled = False
        DtpOutdt.Checked = False
        BtnYarnPrintBar.Enabled = False
        lblCancelled.Visible = False
        'Call GenComboCustomer()
        Dim strreqno As String = ""
        Dim blnCancel As Boolean = False
        'Dim strPacking_no As String = ""
        Dim strCartno As String = ""


        optReqNo.Checked = True

        txtDocNo.Focus()
        'Validate_Outno()
    End Sub
    Private Sub GenCboDoc_type()
        Dim objDB As New classMaster
        'Dim objREQ As New classPackingListG
        CboDoc_type.DataSource = objDB.GetDocType
        CboDoc_type.DisplayMember = "name"
        CboDoc_type.ValueMember = "doctyp"
        'Me.CboCartonsNo.DataSource = objDB.GetCartNo
        'Me.CboCartonsNo.DisplayMember = "cartno"
        'Me.CboCartonsNo.ValueMember = "cartno"

    End Sub
    Private Sub CleargrdDataPackingList()
        Dim objdb As New classPackingListD
        grdDataPackingList.AutoGenerateColumns = False
        grdDataPackingList.DataSource = objdb.GetPackinglistDDataDetail("0", "0")

    End Sub
    Private Sub CleargrdDataCartons()
        Dim objdb As New classPackingListD
        grdDataCartons.AutoGenerateColumns = False
        grdDataCartons.DataSource = objdb.GetPackinglistDDataCartons("")


    End Sub
    Private Sub ClearCboCartonsNo()
        Dim objdb As New classPackingListD
        grdDataCartons.AutoGenerateColumns = False
        'CboCartonsNo.DataSource = objdb.GetPackinglistGDataCartons("")
        CboCartonsNo.DataSource = grdDataCartons.DataSource
        CboCartonsNo.DisplayMember = "cartno"
        CboCartonsNo.ValueMember = "cartno"
        CboCartonsNo.Text = ""
        'CboCartonsNo.Visible = False
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
    Private Sub GenCboCartonsNo()
        'Dim objDB As New classMaster
        'Dim objREQ As New classPackingListG
        CboCartonsNo.DataSource = grdDataCartons.DataSource
        CboCartonsNo.DisplayMember = "cartno"
        CboCartonsNo.ValueMember = "cartno"
        'Me.CboCartonsNo.DataSource = objDB.GetCartNo
        'Me.CboCartonsNo.DisplayMember = "cartno"
        'Me.CboCartonsNo.ValueMember = "cartno"

    End Sub
    Private Sub btnSearchPackno_Click(sender As System.Object, e As System.EventArgs) Handles btnSearchPackno.Click
        Dim frm As New frmSearchPackingListD
        frm.pStockType = _StockType
        frm.ShowDialog(Me)
        Me.Cursor = Cursors.WaitCursor
        If frm.pblnOk = True Then
            txtPackNo.Text = (frm.pPackno.Trim.ToUpper)
            Call GetPackinglistDData(txtPackNo.Text, "")
            Call GetCartonsData(txtPackNo.Text)
            Call SumGrdPackingList() 'Show Total CBM after cartons loaded 20260923
            Call SumCBM() '20260923
        End If
        Me.Cursor = Cursors.Default
        frm.Dispose()

    End Sub
    Function GetCartonsData(ByVal StrPackno As String) As Boolean
        Dim dt As DataTable = dbPackingListD.GetPackinglistDDataCartons(StrPackno)
        If dt.Rows.Count > 0 Then

            Call BindCartonsData(dt)
            Return True

        End If
        Return False

    End Function
    Private Sub BindCartonsData(ByVal dt As DataTable)
        If txtPackNo.Text = "" Then Exit Sub
        Dim i As Integer = 0
        Dim j As Integer = 0
        grdDataCartons.AutoGenerateColumns = False
        grdDataCartons.DataSource = dt
        txtPackNo.Text = dt.Rows(0)("packno").ToString.Trim


        CboCartonsNo.DataSource = grdDataCartons.DataSource
        CboCartonsNo.DisplayMember = "cartno"
        CboCartonsNo.ValueMember = "cartno"



    End Sub
    Function GetPackinglistDData(ByVal strPacking_no As String, StrCartno2 As String) As Boolean
        Dim dt As DataTable = dbPackingListD.GetPackinglistDDataDetail(strPacking_no, StrCartno2)
        If dt.Rows.Count > 0 Then
            'Dev By Neung 26/03/2015
            Call BindPackinglistDData(dt)
            Return True
        End If
        Return False

    End Function
    'Private Sub BindgrdDataPackingList(ByVal dt As DataTable)
    '    grdDataPackingList.AutoGenerateColumns = False
    '    grdDataPackingList.DataSource = dt
    'End Sub
    Private Sub BindPackinglistDData(ByVal dt As DataTable)
        Dim i As Integer = 0
        Dim j As Integer = 0

        'grdDataPackingList.Rows.Clear()
        grdDataPackingList.AutoGenerateColumns = False
        grdDataPackingList.DataSource = dt

        'DtpPackDate.Value = (dt.Rows(0)("packdt"))
        txtPackNo.Text = dt.Rows(0)("packno").ToString.Trim

        DtpPackDate.Value = CDate(dt.Rows(0)("packdt").ToString)
        txtDocNo.Text = (dt.Rows(0)("outreqno").ToString) 'Add By Neung Userr Need show It
        txtcustomer.Text = (dt.Rows(0)("custname").ToString)
        'CboDoc_type.ValueMember = (dt.Rows(0)("doctyp").ToString)
        CboDoc_type.SelectedValue = dt.Rows(0)("doctyp").ToString.Trim
        If grdDataCartons.Rows.Count > 0 Then
            CboCartonsNo.DataSource = grdDataCartons.DataSource
            CboCartonsNo.DisplayMember = "cartno"
            CboCartonsNo.ValueMember = "cartno"

        End If


        SumGrdPackingList()
        btngout.Enabled = True
        DtpOutdt.Enabled = True
        txtOutNo.Text = ""


        If dt.Rows(0)("outno").ToString.Trim.Length > 0 Then
            txtOutNo.Text = dt.Rows(0)("outno").ToString.Trim()
            DtpOutdt.Value = CDate(dt.Rows(0)("outdt").ToString)
            btngout.Enabled = False
            DtpOutdt.Enabled = False
            DtpOutdt.Checked = True
        End If

        txtPackNo.Focus()

    End Sub
    Private Sub SumGrdPackingList()

        'Dim dtc As DataTable = grdDataCartons.DataSource
        'Dim dtp As DataTable = grdDataPackingList.DataSource

        Dim i As Integer = 0
        Dim j As Integer = 0
        Dim dblKgs As Double = 0
        Dim dblMts As Double = 0
        Dim dblYds As Double = 0
        Dim dblCBMCarton As Double = 0 'Siithana 20220723
        Dim dblCBMRoll As Double = 0 'Siithana 20220723

        Dim netwt As Double = 0.0
        Dim anetwt As Double = 0.0
        Dim CartMts As Double = 0.0
        Dim CartYds As Double = 0.0
        Dim totalroll As Double = 0
        'grdDataCartons.Rows(j).Cells("grdDataCartons_netwt").Value = 0
        If grdDataCartons.Rows.Count > 0 Then

            For j = 0 To grdDataCartons.Rows.Count - 2
                For i = 0 To grdDataPackingList.Rows.Count - 1

                    If oConfig.IsNull(grdDataCartons.Rows(j).Cells("grdDataCartons_cartno").Value, 0) = oConfig.IsNull(grdDataPackingList.Rows(i).Cells("grdDataPackingList_cartno").Value, 0) Then

                        netwt = netwt + oConfig.IsNull(grdDataPackingList.Rows(i).Cells("grdDataPackingList_outkg_g").Value, 0)
                        anetwt = 0.0
                        'grdDataCartons.Rows(j).Cells("grdDataCartons_netwt").Value = netwt

                        CartMts = CartMts + oConfig.IsNull(grdDataPackingList.Rows(i).Cells("grdDataPackingList_outmt_g").Value, 0)
                        'grdDataCartons.Rows(j).Cells("CartMts").Value = CartMts

                        CartYds = CartYds + oConfig.IsNull(grdDataPackingList.Rows(i).Cells("grdDataPackingList_outyd_g").Value, 0)
                        'grdDataCartons.Rows(j).Cells("CartYds").Value = CartYds

                        totalroll = totalroll + 1


                    End If
                Next
                grdDataCartons.Rows(j).Cells("grdDataCartons_netwt").Value = netwt 'FormatNumber(netwt, 2, TriState.False, TriState.False, TriState.True)
                'grdDataCartons.Rows(j).Cells("grdDataCartons_netwt").Value = netwt 'FormatNumber(netwt, 2, TriState.False, TriState.False, TriState.True)
                'String.Format("{0:#,###0.00}", grdDataCartons.Rows(j).Cells("grdDataCartons_netwt"))
                netwt = 0
                grdDataCartons.Rows(j).Cells("CartMts").Value = CartMts 'FormatNumber(CartMts, 2, TriState.False, TriState.False, TriState.True)
                CartMts = 0
                grdDataCartons.Rows(j).Cells("CartYds").Value = CartYds 'FormatNumber(CartYds, 2, TriState.False, TriState.False, TriState.True)
                CartYds = 0
                grdDataCartons.Rows(j).Cells("grdDataCartons_CartRolls").Value = totalroll
                grdDataCartons.Rows(j).Cells("grdData_CBMForRoll").Value = oConfig.IsNull(grdDataCartons.Rows(j).Cells("grdData_CBMForCarton").Value, 0) * totalroll 'Sitthana 20220723
                totalroll = 0
            Next
        End If

        For i = 0 To grdDataPackingList.Rows.Count - 1
            dblKgs = dblKgs + oConfig.IsNull(grdDataPackingList.Rows(i).Cells("grdDataPackingList_outkg_g").Value, 0)
            dblMts = dblMts + oConfig.IsNull(grdDataPackingList.Rows(i).Cells("grdDataPackingList_outmt_g").Value, 0)
            dblYds = dblYds + oConfig.IsNull(grdDataPackingList.Rows(i).Cells("grdDataPackingList_outyd_g").Value, 0)
        Next

        txtTotalRolls.Text = FormatNumber(grdDataPackingList.Rows.Count, 0, TriState.False, TriState.False, TriState.True)
        txtTotalKgs.Text = FormatNumber(dblKgs, 2, TriState.False, TriState.False, TriState.True)
        txtTotalMts.Text = FormatNumber(dblMts, 2, TriState.False, TriState.False, TriState.True)
        txtTotalYds.Text = FormatNumber(dblYds, 2, TriState.False, TriState.False, TriState.True)

        Call AutoDeleteCarton()

    End Sub
    Private Function CheckCartnoIsZero() As Boolean

        For i = 0 To grdDataPackingList.Rows.Count - 1
            If grdDataPackingList.Rows(i).Cells("grdDataPackingList_cartno").Value = "0" Then
                CheckCartnoIsZero = True
                Exit Function
            End If

        Next

        CheckCartnoIsZero = False

    End Function
    Private Sub AutoDeleteCarton()
        Call grdDataCartons.ClearSelection()


        If grdDataCartons.Rows.Count > 0 Then
            Dim i As Integer = 0
            Dim dt As New DataTable
            dt = grdDataCartons.DataSource
            Dim expression As String
            expression = "netwt = 0 or cartno = '0'"

            Dim foundRow As DataRow() = dt.Select(expression)

            For Each row As DataRow In foundRow
                row.Delete()
            Next

        End If

    End Sub
    Private Sub BtnCancel_Click(sender As System.Object, e As System.EventArgs) Handles BtnCancel.Click
        CancelPackinglistD()
    End Sub
    Private Sub CancelPackinglistD()
        If strPacking_no = "" Then strPacking_no = txtPackNo.Text.Trim.ToUpper
        strPacking_no = txtPackNo.Text.Trim.ToUpper
        If strPacking_no.Length = 0 Then Exit Sub
        If grdDataCartons.DataSource Is Nothing Then Exit Sub
        If grdDataPackingList.DataSource Is Nothing Then Exit Sub
        If grdDataCartons.Rows.Count = 0 Then Exit Sub
        If grdDataPackingList.Rows.Count = 0 Then Exit Sub


        If blnCancel Then Exit Sub
        'If lblCancelled.Visible Then
        '    MessageBox.Show("This document is already cancelled." & vbCrLf & "Can't cancel anymore.", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
        '    Exit Sub
        'End If
        'Dim obj As New classPackingListD
        'If obj.ValidateDinNoIsOut(strPacking_no, clsuser.UserID) = True Then
        '    MessageBox.Show("This document is already GOUT." & vbCrLf & "Can't cancel anymore.", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
        '    Exit Sub
        'End If

        If MessageBox.Show("Would you like to cancel this document ?", "System Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = DialogResult.No Then Exit Sub


        If CancelPLD() Then
            'MessageBox.Show("PACK NO." & vbCrLf & strPacking_no & "is Cancel", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Call InitControl()
            'lblCancelled.Visible = True
        End If

    End Sub
    Private Function CancelPLD() As Boolean
        Dim obidb As New classPackingListD
        Dim PLDHeader As New classPackingListD.PackingListDHeader
        Dim msgerr As String = ""

        Dim PLDNo As String = strPacking_no
        Dim OUTNo As String = strOut_no
        Dim OUTDT As String = DtpOutdt.Value.ToString("yyyyMMdd")

        Dim PACKDT As String = DtpPackDate.Value.ToString("yyyyMMdd")
        Dim OUTREQNo As String = txtDocNo.Text
        Dim USERID As String = clsuser.UserID
        Dim CheckNEW As String = txtPackNo.Text.Trim
        Dim Doc_type As String = CboDoc_type.SelectedValue

        Dim dtc As DataTable = grdDataCartons.DataSource
        Dim dv_dtc_add As New DataView(dtc, "", "", DataViewRowState.Added)
        Dim dv_dtc_upd As New DataView(dtc, "", "", DataViewRowState.ModifiedCurrent)
        Dim dv_dtc_del As New DataView(dtc, "", "", DataViewRowState.Deleted)

        Dim dtp As DataTable = grdDataPackingList.DataSource
        Dim dv_dtp_add As New DataView(dtp, "", "", DataViewRowState.Added)
        Dim dv_dtp_upd As New DataView(dtp, "", "", DataViewRowState.ModifiedCurrent)
        Dim dv_dtp_del As New DataView(dtp, "", "", DataViewRowState.Deleted)

        Dim dtc2 As DataTable = grdDataCartons.DataSource
        Dim dtp2 As DataTable = grdDataPackingList.DataSource

        If obidb.pldcancel(PLDHeader, dv_dtc_add, dv_dtp_add, dv_dtc_upd, dv_dtp_upd, dv_dtc_del, dv_dtp_del, msgerr, PLDNo, PACKDT, OUTREQNo, OUTNo, OUTDT, USERID, CheckNEW, Doc_type, dtc, dtp) Then
            MessageBox.Show("Pack NO." & PLDHeader.h02_packno & "  is Cancel Already!!  " & vbCrLf, "System Message", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
            CancelPLD = True
        Else
            MessageBox.Show(msgerr, "System Message", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
            CancelPLD = False
        End If

    End Function
    Private Sub btnNew_Click(sender As System.Object, e As System.EventArgs) Handles btnNew.Click
        Me.WindowState = FormWindowState.Maximized

        If Not blnCancel Then Call InitControl()
    End Sub

    Private Sub BtnExit_Click(sender As System.Object, e As System.EventArgs) Handles BtnExit.Click
        Me.Close()
    End Sub
    Private Sub frmPackingListDyed_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        'If MessageBox.Show("Would you like to close ?", "System Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.No Then
        '    e.Cancel = True
        'End If
    End Sub
    Private Sub btnSearchREQD_Click(sender As System.Object, e As System.EventArgs) Handles btnSearchREQD.Click
        Call ChkoptSearch()

    End Sub

    Private Sub ChkoptSearch()

        If optReqNo.Checked = True Then
            Dim frm As New frmSearchREQD
            frm.pStockType = _StockType
            frm.pOutReqTyp = ""
            frm.StartPosition = FormStartPosition.CenterParent
            frm.ShowDialog(Me)
            Me.Cursor = Cursors.WaitCursor
            If frm.pblnOk = True Then
                txtDocNo.Text = (frm.pReqNo)
                Call GetREQD(txtDocNo.Text)
            End If
            Me.Cursor = Cursors.Default
            frm.Dispose()
        ElseIf optDinNo.Checked = True Then
            Dim frm As New frmSearchDIN
            frm.pStockType = _StockType
            frm.pOutReqTyp = ""
            frm.StartPosition = FormStartPosition.CenterParent
            frm.ShowDialog(Me)
            txtDocNo.Text = (frm.pDINNO)
            Me.Cursor = Cursors.WaitCursor
            If Not blnCancel Then GetDINBalance(txtDocNo.Text)
            Me.Cursor = Cursors.Default
            frm.Dispose()
        ElseIf OptLotNo.Checked = True Then
            Dim frm As New frmSearchLOT
            frm.pStockType = _StockType
            frm.pOutReqTyp = ""
            frm.StartPosition = FormStartPosition.CenterParent
            frm.ShowDialog(Me)
            txtDocNo.Text = (frm.pLOTNO)
            Me.Cursor = Cursors.WaitCursor
            If Not blnCancel Then GetLotBalance(txtDocNo.Text)
            Me.Cursor = Cursors.Default
            frm.Dispose()
        End If
    End Sub

    Public Function GetDINBalance(ByRef StrDINNO As String) As Boolean

        Dim dt As DataTable = dbPackingListD.selectStrollsRecord(StrDINNO)
        If dt.Rows.Count > 0 Then
            BindDataREQD(dt)
            ' Call BindDataDIN(dt) '
            txtDocNo.Text = dt.Rows(0)("dinno").ToString()
            CboDoc_type.SelectedValue = dt.Rows(0)("outreqtyp").ToString()
            txtcustomer.Text = dt.Rows(0)("custname").ToString()

            Return True
        End If

        Return False

    End Function
    Public Function GetLotBalance(ByRef StrLOTNO As String) As Boolean

        Dim dt As DataTable = dbPackingListD.selectStrollsRecord(StrLOTNO)
        If dt.Rows.Count > 0 Then
            BindDataREQD(dt)
            'Call BindDataLot(dt) '
            txtDocNo.Text = dt.Rows(0)("dinno").ToString()
            CboDoc_type.SelectedValue = dt.Rows(0)("outreqtyp").ToString()
            txtcustomer.Text = dt.Rows(0)("custname").ToString()

            Return True
        End If
        Return False

    End Function

    Private Sub BindDataDIN(ByVal dt As DataTable)
        If txtDocNo.Text = "" Then Exit Sub

        grdDataPackingList.AutoGenerateColumns = False
        If dt.Rows.Count > 0 Then
            Dim dt1 As DataTable = dt
            Dim dt2 As DataTable = grdDataPackingList.DataSource

            Dim dr As DataRow

            Dim msg As String = ""
            Dim i As Integer = 0
            Dim j As Integer = 0
            For i = 0 To dt.Rows.Count - 1

                'For j = 0 To dt2.Rows.Count - 1
                '    If dt2.Rows(i)("roll_no_d").ToString.Trim = dt1.Rows(i)("roll_no_d").ToString.Trim Then
                '        MessageBox.Show("คุณ ใส่ม้วนซ้ำกัน ", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                '        Exit Sub
                '    End If
                'Next

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
                    dr("outno1") = dt1.Rows(i)("outno1") 'Roll_no_o From DIN
                    dr("batch") = dt1.Rows(i)("batch") 'Roll_no_o From DIN
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
    Private Sub BindDataLot(ByVal dt As DataTable)
        If txtDocNo.Text = "" Then Exit Sub

        grdDataPackingList.AutoGenerateColumns = False
        If dt.Rows.Count > 0 Then
            Dim dt1 As DataTable = dt
            Dim dt2 As DataTable = grdDataPackingList.DataSource

            Dim dr As DataRow

            Dim msg As String = ""
            Dim i As Integer = 0
            Dim j As Integer = 0
            For i = 0 To dt.Rows.Count - 1
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
                    dr("outno1") = dt1.Rows(i)("outno1") 'Roll_no_o From DIN
                    dr("batch") = dt1.Rows(i)("batch")
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

    Private Function GetREQD(ByVal StrReqno As String) As Boolean

        ' Dim ReqNo As String
        ' ReqNo = txtReqNo.Text
        If StrReqno = "" Then Exit Function
        If Not Validate_ReqNoIsCancel(StrReqno) Then 'Check ReqNo ,Is' Cancel?
            MessageBox.Show("Req. No : " & StrReqno & "............   Req No. is Already Cancel!!")
            Exit Function

        End If
        If Not Validate_ReqNoGOut(StrReqno) Then 'Check ReqNo ,Is' used?
            MessageBox.Show("Req. No : " & StrReqno & "............   is Already Used!! For " & strPackingNo)
            'Exit Function 'Disibel By Neung Gammaknit Didn't use 

        End If

        Dim dt As DataTable = dbPackingListD.GetREQD(StrReqno)


        If dt.Rows.Count > 0 Then
            Call BindDataREQD(dt)
            txtDocNo.Text = dt.Rows(0)("outreqno").ToString()
            CboDoc_type.SelectedValue = dt.Rows(0)("outreqtyp").ToString()
            txtcustomer.Text = dt.Rows(0)("custname").ToString()

            Return True
        End If
        Return False
    End Function
    Private Sub BindDataREQD(ByVal dt As DataTable)
        If txtDocNo.Text = "" Then Exit Sub
        grdDataPackingList.AutoGenerateColumns = False
        If dt.Rows.Count > 0 Then
            Dim dt1 As DataTable = dt
            Dim dt2 As DataTable = grdDataPackingList.DataSource
            Dim dr As DataRow
            Dim msg As String = ""
            Dim i As Integer = 0
            Dim j As Integer = 0
            For i = 0 To dt1.Rows.Count - 1
                dr = dt2.NewRow

                dr("cartno") = dt1.Rows(i)("cartno")
                dr("roll_no_d") = dt1.Rows(i)("roll_no_d")
                dr("roll_no_o") = dt1.Rows(i)("roll_no_o")
                dr("grade") = dt1.Rows(i)("grade")
                dr("design_no") = dt1.Rows(i)("design_no")
                dr("lot") = dt1.Rows(i)("lot")
                dr("col") = dt1.Rows(i)("col")
                dr("custcolor") = dt1.Rows(i)("custcolor")
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
                dr("outno1") = dt1.Rows(i)("outno1")

                Dim checkDupicateRoll As Boolean = False

                If dt2.Rows.Count > 0 Then
                    For Each row As DataRow In dt2.Rows
                        If row("roll_no_d").ToString().Equals(dt1.Rows(i)("roll_no_d")) And row("outreqno").ToString().Equals(dt1.Rows(i)("outreqno")) Then 'Edit By Neung 1 roll / 1 Req
                            checkDupicateRoll = True
                        End If
                    Next
                End If
                If Not checkDupicateRoll Then
                    dt2.Rows.Add(dr)
                End If

            Next

        End If
        Call SumGrdPackingList()


        'grdDataPackingList.DataSource = dt
        'txtReqNo.Text = dt.Rows(0)("outreqno").ToString()
    End Sub

    Private Function CheckRollDupicated(ByRef dt1 As DataTable, ByRef dt2 As DataTable) As Boolean

        For Each dr As DataRow In dt2.Rows
            If dr("roll_no_g").ToString().Trim = "" Then
                Return True
            End If
        Next

    End Function
    Private Sub grdDataPackingList_CellEndEdit(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles grdDataPackingList.CellEndEdit
        'If chkAutoGenCarntonNo.Checked Then
        If grdDataPackingList.Columns(e.ColumnIndex).Name = "grdDataPackingList_cartno" Then
            Call AutoBindDataCARTONS(grdDataPackingList.DataSource)
        End If
        'End If

        Call SumGrdPackingList()
    End Sub

    Private Sub AutoBindDataCARTONS(ByVal dt As DataTable)
        If grdDataPackingList.Rows.Count = 0 Then Exit Sub

        grdDataCartons.AutoGenerateColumns = False
        If dt.Rows.Count > 0 Then
            Dim dt1 As DataTable = dt
            Dim dt2 As DataTable = grdDataCartons.DataSource

            Dim dr1 As DataRow

            Dim msg As String = ""
            Dim i As Integer = 0
            Dim j As Integer = 0

            dr1 = dt2.NewRow
            dr1("cartno") = grdDataPackingList.CurrentRow.Cells("grdDataPackingList_cartno").Value

            Dim checkDupicateRoll As Boolean = False

            If dt2.Rows.Count > 0 Then
                For Each dr2 As DataRow In dt2.Rows

                    If dr2.RowState <> DataRowState.Deleted Then
                        If dr2("cartno").Equals(grdDataPackingList.CurrentRow.Cells("grdDataPackingList_cartno").Value) Then
                            checkDupicateRoll = True
                        End If
                    End If

                    'If dr2("cartno").Equals(grdDataPackingList.CurrentRow.Cells("grdDataPackingList_cartno").Value) Then
                    '    checkDupicateRoll = True
                    'End If

                Next
            End If
            If Not checkDupicateRoll Then
                dt2.Rows.Add(dr1)
            End If

        End If

    End Sub

    Private Sub grdDataCartons_CellEndEdit(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles grdDataCartons.CellEndEdit
        SumGrdPackingList()
    End Sub

    Private Sub BtnSave_Click(sender As System.Object, e As System.EventArgs) Handles BtnSave.Click

        blnCancel = False
        'Sitthana 20220624 Changed Windows.Forms.DialogResult To DialogResult
        Dim result As DialogResult ' Windows.Forms.DialogResult
        result = MessageBox.Show("Would you like to save ?", "System Message", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button3)
        If result = DialogResult.Cancel Then blnCancel = True
        If result <> DialogResult.Yes Then Exit Sub

        If Not CheckData() Then Exit Sub

        If grdDataCartons.Focus Then
            grdDataCartons.EndEdit() 'Add By Neung 20151211 Fix Bug User
            grdDataPackingList.EndEdit() 'Add By Neung 20151211 Fix Bug User
        End If

        If grdDataPackingList.Focus Then
            grdDataCartons.EndEdit() 'Add By Neung 20151211 Fix Bug User
            grdDataPackingList.EndEdit() 'Add By Neung 20151211 Fix Bug User
        End If

        txtPackNo.Focus()

        If Not grdDataCartons.EndEdit Then Exit Sub
        If Not grdDataPackingList.EndEdit Then Exit Sub


        Call BFSavePackD()
    End Sub

    Private Function CheckData() As Boolean
        CheckData = True
    End Function

    Private Sub BFSavePackD()
        strPacking_no = txtPackNo.Text.Trim.ToUpper
        If lblCancelled.Enabled = True Then lblCancelled.Enabled = False And strPacking_no = "NEW"
        If strPacking_no = "" Then strPacking_no = txtPackNo.Text.Trim.ToUpper
        If strOut_no = "" Then strOut_no = txtOutNo.Text.Trim.ToUpper
        If strPacking_no.Length = 0 Then Exit Sub
        If grdDataCartons.DataSource Is Nothing Then Exit Sub
        If grdDataCartons.Rows.Count = 0 Then Exit Sub
        If grdDataPackingList.DataSource Is Nothing Then Exit Sub
        If grdDataPackingList.Rows.Count = 0 Then Exit Sub
        Dim i As Integer
        For i = 0 To grdDataCartons.Rows.Count - 2
            If oConfig.IsNull(grdDataCartons.Rows(i).Cells("grdDataCartons_cartno").Value, 0) = 0 Then
                MessageBox.Show("Cartno. is not Zero." & vbCrLf & "Please Check it.", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
                Exit Sub
            End If

        Next
        For i = 0 To grdDataPackingList.Rows.Count - 1
            If oConfig.IsNull(grdDataPackingList.Rows(i).Cells("grdDataPackingList_cartno").Value, 0) = 0 Then
                MessageBox.Show("Cartno. is not Zero." & vbCrLf & "Please Check it.", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
                Exit Sub
            End If

        Next

        If oConfig.IsNull(CboDoc_type.SelectedValue, "") = "" Then
            MessageBox.Show("Please Select Type." & vbCrLf, "System Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            CboDoc_type.Focus()
            Exit Sub
        End If

        If SavePLD() Then
            Loaddata(txtPackNo.Text.Trim)
            GetPackinglistDData(txtPackNo.Text.Trim, "")
            Validate_Outno()
            If txtOutNo.Text <> "" Then
                Call BFSavePLDOUT()
            End If
        End If

    End Sub

    Private Function SavePLD() As Boolean
        Dim objdb As New classPackingListD
        Dim PLDHeader As New classPackingListD.PackingListDHeader
        Dim msgerr As String = ""

        Dim PLDNo As String = strPacking_no
        Dim OUTNo As String = strOut_no
        Dim OUTREQNo As String = txtDocNo.Text
        Dim PACKDT As String = DtpPackDate.Value.ToString("yyyyMMdd")
        Dim OUTDT As String = DtpOutdt.Value.ToString("yyyyMMdd")
        Dim USERID As String = clsuser.UserID
        Dim CheckNEW As String = txtPackNo.Text.Trim
        Dim Doc_type As String = CboDoc_type.SelectedValue



        ' Dim dtdt As DataTable = CboDoc_type.DataSource
        Dim dtc As DataTable = grdDataCartons.DataSource
        Dim dv_dtc_add As New DataView(dtc, "", "", DataViewRowState.Added)
        Dim dv_dtc_upd As New DataView(dtc, "", "", DataViewRowState.ModifiedCurrent)
        Dim dv_dtc_del As New DataView(dtc, "", "", DataViewRowState.Deleted)

        Dim dtp As DataTable = grdDataPackingList.DataSource
        Dim dv_dtp_add As New DataView(dtp, "", "", DataViewRowState.Added)
        Dim dv_dtp_upd As New DataView(dtp, "", "", DataViewRowState.ModifiedCurrent)
        Dim dv_dtp_del As New DataView(dtp, "", "", DataViewRowState.Deleted)

        'Dim dtdt As DataTable = CboDoc_type.DataSource
        'Dim dv_dtdt_add As New DataView(dtdt, "", "", DataViewRowState.Added)
        'Dim dv_dtdt_upd As New DataView(dtdt, "", "", DataViewRowState.ModifiedCurrent)
        'Dim dv_dtdt_del As New DataView(dtdt, "", "", DataViewRowState.Deleted)

        'header.h01_cartno = dtc.Rows(0)("cartno").ToString.Trim
        'header.h17_outreqno = txtReqNo.Text


        PLDHeader.h02_packno = txtPackNo.Text.Trim
        PLDHeader.h19_outreqtyp = CboDoc_type.SelectedValue
        PLDHeader.h38_packdt = DtpPackDate.Value '.ToString ("yyyyMMdd")
        PLDHeader.h20_outno = txtOutNo.Text.Trim
        PLDHeader.h21_outdt = DtpOutdt.Value '.ToString("yyyyMMdd")
        PLDHeader.h46_empcd = clsuser.UserID.Trim

        If objdb.pldsave(PLDHeader, dv_dtc_add, dv_dtp_add, dv_dtc_upd, dv_dtp_upd, dv_dtc_del, dv_dtp_del, msgerr, PLDNo, OUTREQNo, PACKDT, OUTNo, OUTDT, USERID, CheckNEW, Doc_type, _StockType) Then
            txtPackNo.Text = PLDHeader.h36_packno.Trim
            'strPacking_no = PLDNo
            'ValidateOutno()

            MessageBox.Show("Save is Complete! : บันทึกสำเร็จ! ", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
            SavePLD = True
        Else
            MessageBox.Show(msgerr, "System Message", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
            SavePLD = False
        End If


    End Function

    Private Sub Loaddata(ByVal PackinglistNo As String)
        Dim DtDataCartons As New DataTable
        Dim DtDataPackingList As New DataTable
        Dim objdb As New classPackingListD

        If objdb.ValidatePackno(txtPackNo.Text.Trim, clsuser.UserID) Then
            DtDataCartons = objdb.GetPackinglistDDataCartons(PackinglistNo)
            DtDataPackingList = objdb.GetPackinglistDDataDetail(PackinglistNo)

            Call BindDataGrd(DtDataCartons, DtDataPackingList)
            Call BindDataText(DtDataCartons, DtDataPackingList)

            Call AutoDeleteCarton()
            Call SumGrdPackingList()
            Call SumCBM() 'Moved after SumGrdPackingList so CBM Roll is multiplied by rolls first 20260923
        Else
            MessageBox.Show("Pack No ไม่ถูกต้อง ", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
            Call InitControl()

            Exit Sub
        End If

    End Sub
    Private Sub BindDataAfterSavePackNo(ByVal dt As DataTable)
        txtPackNo.Text = dt.Rows(0)("packno").ToString.Trim
    End Sub
    Private Sub BindDataGrd(ByVal DtDataCartons As DataTable, ByVal DtDataPackingList As DataTable)
        'grdDataCartons.Rows.Clear()
        grdDataCartons.AutoGenerateColumns = False
        grdDataCartons.DataSource = DtDataCartons

        grdDataPackingList.AutoGenerateColumns = False
        grdDataPackingList.DataSource = DtDataPackingList

    End Sub

    Private Sub BindDataText(ByVal DtDataCartons As DataTable, ByVal DtDataPackingList As DataTable)

        txtPackNo.Text = DtDataPackingList.Rows(0)("packno").ToString.Trim

        DtpPackDate.Value = CDate(DtDataPackingList.Rows(0)("packdt").ToString)
        txtDocNo.Text = (DtDataPackingList.Rows(0)("outreqno").ToString) 'Add By Neung Userr Need show It
        txtcustomer.Text = (DtDataPackingList.Rows(0)("custname").ToString)
        'CboDoc_type.ValueMember = (dt.Rows(0)("doctyp").ToString)
        CboDoc_type.SelectedValue = DtDataPackingList.Rows(0)("doctyp").ToString.Trim
        If grdDataCartons.Rows.Count > 0 Then
            CboCartonsNo.DataSource = grdDataCartons.DataSource
            CboCartonsNo.DisplayMember = "cartno"
            CboCartonsNo.ValueMember = "cartno"

        End If


        SumGrdPackingList()
        btngout.Enabled = True
        DtpOutdt.Enabled = True
        txtOutNo.Text = ""


        If DtDataPackingList.Rows(0)("outno").ToString.Trim.Length > 0 Then
            txtOutNo.Text = DtDataPackingList.Rows(0)("outno").ToString.Trim()
            DtpOutdt.Value = CDate(DtDataPackingList.Rows(0)("outdt").ToString)
            btngout.Enabled = False
            DtpOutdt.Enabled = False
            DtpOutdt.Checked = True
            BtnYarnPrintBar.Enabled = True
        Else
            txtOutNo.Text = ""
            DtpOutdt.Value = CDate(Today)
            btngout.Enabled = True
            DtpOutdt.Enabled = True
            DtpOutdt.Checked = False
            BtnYarnPrintBar.Enabled = False
        End If

        txtPackNo.Focus()


    End Sub

    Private Sub BtnPrint_Click(sender As System.Object, e As System.EventArgs)
        strPacking_no = txtPackNo.Text
        If strPacking_no = "" Then strPacking_no = txtPackNo.Text
        If strPacking_no.Length = 0 Then Exit Sub
        Const rptFileName = "rptPLD.rpt"

        If clsuser.ReportPath = "" Then clsuser.ReportPath = clsuser.ReportPath
        If Not oConfig.CheckReport(clsuser.ReportPath, rptFileName) Then Exit Sub
        'Dim frm As New frmReportPLG
        Dim frm As New frmReport
        Dim rpt As New CrystalDecisions.CrystalReports.Engine.ReportDocument
        Me.Cursor = Cursors.WaitCursor
        rpt.Load(clsuser.ReportPath & rptFileName)
        rpt.DataSourceConnections.Item(0).SetConnection(clsConn.servername, clsConn.database, False)
        rpt.DataSourceConnections.Item(0).SetLogon(clsConn.Userid, clsConn.Password)
        rpt.VerifyDatabase()
        rpt.SetParameterValue("@packno", strPacking_no)
        rpt.SetParameterValue("@cartno", "")

        'rpt.PrintOptions.PaperSize = CrystalDecisions.Shared.PaperSize.PaperA4
        'rpt.PrintOptions.PaperOrientation = CrystalDecisions.Shared.PaperOrientation.Portrait
        'rpt.PrintOptions.PaperSource = CrystalDecisions.Shared.PaperSource.Auto

        frm.Title = "PackingList D"
        frm.CRViewer.ReportSource = rpt
        'Dim dt As New DataTable
        frm.MdiParent = Me.ParentForm
        frm.Show()
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub btngout_Click(sender As System.Object, e As System.EventArgs) Handles btngout.Click
        BFSavePLDOUT()
    End Sub
    Private Sub BFSavePLDOUT()
        If strPacking_no = "" Then strPacking_no = txtPackNo.Text.Trim.ToUpper
        If strPacking_no.Length = 0 Then Exit Sub
        If grdDataCartons.DataSource Is Nothing Then Exit Sub
        If grdDataCartons.Rows.Count = 0 Then Exit Sub 'grdDataCartons is empty  Sitthana 20220818
        If grdDataPackingList.DataSource Is Nothing Then Exit Sub
        If grdDataPackingList.Rows.Count = 0 Then Exit Sub

        blnCancel = False
        'Sitthana 20220624 Changed Windows.Forms.DialogResult To DialogResult
        Dim result As DialogResult ' Windows.Forms.DialogResult
        result = MessageBox.Show("Would you like to save  Out ?", "System Message", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button3)
        If result = DialogResult.Cancel Then blnCancel = True
        If result <> DialogResult.Yes Then Exit Sub

        If SavePLDOUT() Then
            MessageBox.Show("Out No. : " & strOut_no & "Pack No. : " & PackinglistNo & "บันทึกสำเร็จ ! ", "System Message", MessageBoxButtons.OK, MessageBoxIcon.None, MessageBoxDefaultButton.Button1)
            LoaddataDout(PackinglistNo)
            Validate_Outno()
        End If



    End Sub
    Private Sub LoaddataDout(ByVal PackinglistNo As String)
        Dim objdb As New classPackingListD
        Dim dtDataCartons As New DataTable
        Dim dtgrdDataPackingList As New DataTable
        dtDataCartons = objdb.GetPackinglistDDataCartons(PackinglistNo)
        dtgrdDataPackingList = objdb.GetPackinglistDDataDetail(PackinglistNo)

        Call BindDataGrd(dtDataCartons, dtgrdDataPackingList)
        Call BindDataText(dtDataCartons, dtgrdDataPackingList)

        Call SumGrdPackingList()
        'Call BindDataDout(dt)

        txtOutNo.Text = strOut_no
        Call GetPackinglistDData(strPacking_no, "")
        'CboDoc_type.SelectedValue = dt.Rows(0)("doctyp")
    End Sub
    Private Function SavePLDOUT() As Boolean
        Dim objdb As New classPackingListD
        Dim PLDHeader As New classPackingListD.PackingListDHeader
        Dim CartonsHeader As New classPackingListD.CartonsHeader
        Dim msgerr As String = ""

        Dim PLDNo As String = strPacking_no
        Dim OUTNo As String = strOut_no
        Dim OUTREQNo As String = txtDocNo.Text
        Dim PACKDT As String = DtpPackDate.Value.ToString("yyyyMMdd")
        Dim OUTDT As String = DtpOutdt.Value.ToString("yyyyMMdd")
        Dim USERID As String = clsuser.UserID
        Dim CheckNEW As String = txtPackNo.Text.Trim
        Dim Doc_type As String = CboDoc_type.SelectedValue
        ' Dim Doc_type As String = CboDoc_type.SelectedValue
        Dim dtc As DataTable = grdDataCartons.DataSource
        Dim dv_dtc_add As New DataView(dtc, "", "", DataViewRowState.Added)
        Dim dv_dtc_upd As New DataView(dtc, "", "", DataViewRowState.ModifiedCurrent)
        Dim dv_dtc_del As New DataView(dtc, "", "", DataViewRowState.Deleted)

        Dim dtp As DataTable = grdDataPackingList.DataSource
        Dim dv_dtp_add As New DataView(dtp, "", "", DataViewRowState.Added)
        Dim dv_dtp_upd As New DataView(dtp, "", "", DataViewRowState.ModifiedCurrent)
        Dim dv_dtp_del As New DataView(dtp, "", "", DataViewRowState.Deleted)

        Dim dtp2 As DataTable = grdDataPackingList.DataSource
        'header.h01_cartno = dtc.Rows(0)("cartno").ToString.Trim
        'header.h17_outreqno = txtReqNo.Text

        CartonsHeader.h06_gout = 1
        CartonsHeader.h07_sel = True

        PLDHeader.h02_packno = txtPackNo.Text.Trim
        PLDHeader.h19_outreqtyp = CboDoc_type.SelectedValue
        PLDHeader.h20_outno = txtOutNo.Text.Trim
        PLDHeader.h21_outdt = DtpOutdt.Value
        PLDHeader.h46_empcd = clsuser.UserID.Trim
        'PLDHeader.h19_outreqtyp = CboDoc_type.SelectedValue
        'blnCancel = False

        If objdb.pldsaveDOUT(PLDHeader, dv_dtc_add, dv_dtp_add, dv_dtc_upd, dv_dtp_upd, dv_dtc_del, dv_dtp_del, msgerr, PLDNo, OUTREQNo, PACKDT, OUTNo, OUTDT, USERID, CheckNEW, Doc_type, dtp2, dtc, CartonsHeader, _StockType) Then
            PackinglistNo = PLDNo
            strOut_no = OUTNo
            'ValidateOutno()
            Validate_Outno()
            SavePLDOUT = True

        Else
            SavePLDOUT = False
            MessageBox.Show(msgerr, "System Message", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
        End If


    End Function

    Private Sub CboCartonsNo_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles CboCartonsNo.SelectedIndexChanged

    End Sub

    Private Sub Label9_Click(sender As System.Object, e As System.EventArgs) Handles Label9.Click

    End Sub

    Private Sub txtPackNo_HideSelectionChanged(sender As Object, e As System.EventArgs) Handles txtPackNo.HideSelectionChanged

    End Sub

    Private Sub txtPackNo_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles txtPackNo.KeyDown

        If e.KeyCode.Equals(Keys.Enter) Then
            Call GetPackinglistDData(txtPackNo.Text, "")
            Call GetCartonsData(txtPackNo.Text)
            Call SumGrdPackingList() 'Show Total CBM after cartons loaded 20260923
            Call SumCBM() '20260923
        End If

    End Sub

    Private Sub txtPackNo_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtPackNo.TextChanged

    End Sub

    Private Sub txtReqNo_GotFocus(sender As Object, e As System.EventArgs) Handles txtDocNo.GotFocus
        If txtDocNo.Text <> "" Then
            txtDocNo.Text = ""
        End If
        lblCancelled.Visible = False
    End Sub

    Private Sub txtReqNo_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles txtDocNo.KeyDown
        If e.KeyCode.Equals(Keys.Enter) Then
            If optDinNo.Checked Then
                GetDINBalance(txtDocNo.Text)
            ElseIf OptLotNo.Checked Then
                GetLotBalance(txtDocNo.Text)
            ElseIf optReqNo.Checked Then
                GetREQD(txtDocNo.Text)
            End If

        End If
    End Sub

    Private Function Validate_ReqNoIsCancel(ReqNo) As Boolean
        Dim objDB As New classPackingListD
        Dim dt As DataTable = objDB.ValidateReqNoIsCancel(ReqNo, clsuser.UserID)

        If dt.Rows.Count = 0 Then
            Return False
        End If
        Return True
    End Function
    Private Function Validate_ReqNoGOut(ReqNo) As Boolean
        Dim objDB As New classPackingListD
        Dim dt As DataTable = objDB.ValidateReqNoIsPack(ReqNo, clsuser.UserID)

        If dt.Rows.Count > 0 Then
            strPackingNo = (dt.Rows(0)("packno").ToString)
            Return False
            'Return True
        End If
        Return True
    End Function

    Private Function ValidateOutno() As Boolean
        ' We Use Validate_Outno()
        If txtOutNo.Text <> "" Then
            btngout.Enabled = False
            ValidateOutno = False
        Else
            btngout.Enabled = True
            ValidateOutno = True
        End If


    End Function

    Private Function Validate_Outno() As Boolean
        Dim objdb As New classPackingListD
        'Dim objDB As New classStockD
        Dim dt As DataTable = objdb.ValidateOutNoByPackno(txtPackNo.Text.Trim, clsuser.UserID)

        If dt.Rows.Count = 0 And txtPackNo.Text <> "" Then
            'If clsconfig.IsNull(txtOutNo.Text, "") = "" Then
            btngout.Enabled = True
            DtpOutdt.Enabled = True
        Else
            btngout.Enabled = False
            DtpOutdt.Enabled = False
        End If

    End Function

    Private Function Validate_Packno() As Boolean
        Dim objdb As New classPackingListD
        'Dim objDB As New classStockD
        Dim dt As DataTable = objdb.ValidateOutNoByPackno(txtPackNo.Text.Trim, clsuser.UserID)

        If dt.Rows.Count = 0 And txtPackNo.Text <> "" Then
            'If clsconfig.IsNull(txtOutNo.Text, "") = "" Then
            btngout.Enabled = True
            DtpOutdt.Enabled = True
        Else
            btngout.Enabled = False
            DtpOutdt.Enabled = False
        End If

    End Function

    Private Sub txtReqNo_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtDocNo.TextChanged

    End Sub

    Private Sub BtnPrintDOUT_Click(sender As Object, e As EventArgs)
        'Dim frm2 As New frmDOUTDocument
        'frm2.UserInfo = clsuser
        'frm2.MdiParent = Me.ParentForm
        'frm2.Show()

        If txtOutNo.Text.Length = 0 Then Exit Sub
        'Const rptFileName = "rptDOUT.rpt"
        Const rptFileName = "rptDOUTByPackNo.rpt"

        If clsuser.ReportPath = "" Then clsuser.ReportPath = clsuser.ReportPath
        If Not oConfig.CheckReport(clsuser.ReportPath, rptFileName) Then Exit Sub
        Dim frm As New frmReport
        Dim rpt As New CrystalDecisions.CrystalReports.Engine.ReportDocument
        Me.Cursor = Cursors.WaitCursor
        rpt.Load(clsuser.ReportPath & rptFileName)
        rpt.DataSourceConnections.Item(0).SetConnection(clsConn.servername, clsConn.database, False)
        rpt.DataSourceConnections.Item(0).SetLogon(clsConn.Userid, clsConn.Password)
        rpt.VerifyDatabase()
        rpt.SetParameterValue("@outno", txtOutNo.Text.Trim)
        rpt.SetParameterValue("@packno", txtPackNo.Text.Trim)
        'rpt.PrintOptions.PaperSize = CrystalDecisions.Shared.PaperSize.PaperA4
        'rpt.PrintOptions.PaperOrientation = CrystalDecisions.Shared.PaperOrientation.Portrait
        'rpt.PrintOptions.PaperSource = CrystalDecisions.Shared.PaperSource.Auto

        frm.Title = "Dyed Out"
        frm.CRViewer.ReportSource = rpt
        frm.MdiParent = Me.ParentForm
        frm.Show()
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub btnMoveLeft_Click(sender As System.Object, e As System.EventArgs) Handles btnMoveLeft.Click
        If grdDataCartons.Width > 150 Then
            grdDataCartons.Width = grdDataCartons.Width - 150
            btnMoveLeft.Left = grdDataCartons.Right
            btnMoveRight.Left = grdDataCartons.Right
            'btnAdd.Left = grdDataCartons.Right
            'btnDel.Left = grdDataCartons.Right
            'btnDelAll.Left = grdDataCartons.Right
            grdDataPackingList.Left = btnMoveLeft.Right
            grdDataPackingList.Width = grdDataPackingList.Width + 150
        End If
    End Sub

    Private Sub btnMoveRight_Click(sender As System.Object, e As System.EventArgs) Handles btnMoveRight.Click
        If grdDataPackingList.Width > 150 Then
            grdDataCartons.Width = grdDataCartons.Width + 150
            btnMoveLeft.Left = grdDataCartons.Right
            btnMoveRight.Left = grdDataCartons.Right
            'btnAdd.Left = grdDataCartons.Right
            'btnDel.Left = grdDataCartons.Right
            'btnDelAll.Left = grdDataCartons.Right
            grdDataPackingList.Left = btnMoveLeft.Right
            grdDataPackingList.Width = grdDataPackingList.Width - 150
        End If
    End Sub

    Private Sub optReqNo_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles optReqNo.CheckedChanged
        Checkopt()
    End Sub
    Public Sub Checkopt()
        If optReqNo.Checked Then
            lblDocNo.Text = "Req No."
            txtDocNo.Text = "Please Enter Req No."
        ElseIf OptLotNo.Checked Then
            lblDocNo.Text = "Lot No."
            txtDocNo.Text = "Please Enter Lot No."
        ElseIf optDinNo.Checked Then
            lblDocNo.Text = "DIN No."
            txtDocNo.Text = "Please Enter DIN No."
        End If
    End Sub

    Private Sub optDinNo_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles optDinNo.CheckedChanged
        Checkopt()
    End Sub

    Private Sub OptLotNo_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles OptLotNo.CheckedChanged
        Checkopt()
    End Sub

    Private Sub BtnYarnPrintBar_Click(sender As Object, e As EventArgs) Handles BtnYarnPrintBar.Click
        Dim rptFileName = "rptStockDBarcode.rpt"
        If clsuser.ReportPath = "" Then clsuser.ReportPath = clsuser.ReportPath
        'clsUser.ReportPath = "C:\Users\DELL\Desktop\GemmaKnits\"
        If Not oConfig.CheckReport(clsuser.ReportPath, rptFileName) Then Exit Sub
        Dim frm As New frmReport
        Dim rpt As New CrystalDecisions.CrystalReports.Engine.ReportDocument
        Dim stype As String = ""
        Dim ord As String = ""
        Me.Cursor = Cursors.WaitCursor

        rpt.Load(clsuser.ReportPath & rptFileName)
        rpt.DataSourceConnections.Item(0).SetConnection(clsConn.servername, clsConn.database, False)
        rpt.DataSourceConnections.Item(0).SetLogon(clsConn.Userid, clsConn.Password)
        rpt.VerifyDatabase()
        rpt.SetParameterValue("@roll_no", txtOutNo.Text.Trim)
        rpt.SetParameterValue("@loc", "")
        rpt.SetParameterValue("@logempcd", Userinfo.UserID)

        'rpt.PrintOptions.PaperSize = CrystalDecisions.Shared.PaperSize.PaperLetter
        'rpt.PrintOptions.PaperOrientation = CrystalDecisions.Shared.PaperOrientation.Portrait
        'rpt.PrintOptions.PaperSource = CrystalDecisions.Shared.PaperSource.Auto

        frm.Title = "Greige Barcode"
        frm.CRViewer.ReportSource = rpt
        frm.MdiParent = Me.ParentForm
        frm.Show()
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub btnPrintCartonLabel_Click(sender As Object, e As EventArgs) Handles btnPrintCartonLabel.Click
        strPacking_no = txtPackNo.Text
        If strPacking_no = "" Then strPacking_no = txtPackNo.Text
        If strPacking_no.Length = 0 Then Exit Sub
        Const rptFileName = "rptPackingCartonLabelWidePrint.rpt"

        If clsuser.ReportPath = "" Then clsuser.ReportPath = clsuser.ReportPath
        If Not oConfig.CheckReport(clsuser.ReportPath, rptFileName) Then Exit Sub
        'Dim frm As New frmReportPLG
        Dim frm As New frmReport
        Dim rpt As New CrystalDecisions.CrystalReports.Engine.ReportDocument
        Me.Cursor = Cursors.WaitCursor
        rpt.Load(clsuser.ReportPath & rptFileName)
        rpt.DataSourceConnections.Item(0).SetConnection(clsConn.servername, clsConn.database, False)
        rpt.DataSourceConnections.Item(0).SetLogon(clsConn.Userid, clsConn.Password)
        rpt.VerifyDatabase()
        rpt.SetParameterValue("@p_packno", strPacking_no)
        rpt.SetParameterValue("@p_cartno", 0)

        'rpt.PrintOptions.PaperSize = CrystalDecisions.Shared.PaperSize.PaperA4
        'rpt.PrintOptions.PaperOrientation = CrystalDecisions.Shared.PaperOrientation.Portrait
        'rpt.PrintOptions.PaperSource = CrystalDecisions.Shared.PaperSource.Auto

        frm.Title = "PackingList D PrintCarton Label"
        frm.CRViewer.ReportSource = rpt
        'Dim dt As New DataTable
        frm.MdiParent = Me.ParentForm
        frm.Show()
        Me.Cursor = Cursors.Default

    End Sub


    Private Sub btnPrintChantasiaLabel_Click(sender As Object, e As EventArgs) Handles btnPrintChantasiaLabel.Click
        strPacking_no = txtPackNo.Text
        If strPacking_no = "" Then strPacking_no = txtPackNo.Text
        If strPacking_no.Length = 0 Then Exit Sub
        Const rptFileName = "rptChantasiaBarcode.rpt"

        If clsuser.ReportPath = "" Then clsuser.ReportPath = clsuser.ReportPath
        If Not oConfig.CheckReport(clsuser.ReportPath, rptFileName) Then Exit Sub
        'Dim frm As New frmReportPLG
        Dim frm As New frmReport
        Dim rpt As New CrystalDecisions.CrystalReports.Engine.ReportDocument
        Me.Cursor = Cursors.WaitCursor
        rpt.Load(clsuser.ReportPath & rptFileName)
        rpt.DataSourceConnections.Item(0).SetConnection(clsConn.servername, clsConn.database, False)
        rpt.DataSourceConnections.Item(0).SetLogon(clsConn.Userid, clsConn.Password)
        rpt.VerifyDatabase()
        rpt.SetParameterValue("@p_packno", strPacking_no)
        rpt.SetParameterValue("@p_cartno", 0)

        'rpt.PrintOptions.PaperSize = CrystalDecisions.Shared.PaperSize.PaperA4
        'rpt.PrintOptions.PaperOrientation = CrystalDecisions.Shared.PaperOrientation.Portrait
        'rpt.PrintOptions.PaperSource = CrystalDecisions.Shared.PaperSource.Auto

        frm.Title = "PackingList D Print Chantasia Label"
        frm.CRViewer.ReportSource = rpt
        'Dim dt As New DataTable
        frm.MdiParent = Me.ParentForm
        frm.Show()
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub grdDataCartons_CellMouseClick(sender As Object, e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles grdDataCartons.CellMouseClick

        If grdDataCartons.Rows.Count > 0 Then
            grdDataCartons.ContextMenuStrip = mnu
        End If

    End Sub

    Private Sub Copy_Click(sender As System.Object, e As System.EventArgs) Handles Copy.Click
        'Copy to clipboard
        CopyToClipboard()
    End Sub

    Private Sub CopyToClipboard()
        'Copy to clipboard
        Dim DataObj As New DataObject
        DataObj = grdDataCartons.GetClipboardContent
        If Not DataObj Is Nothing Then
            Clipboard.SetDataObject(DataObj)
        End If
    End Sub


    Private Sub PasteClipboardValue()
        'Show Error if no cell is selected
        If grdDataCartons.SelectedCells.Count = 0 Then
            MessageBox.Show("Please select a cell", "Paste", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        'Get the starting Cell
        Dim startCell As DataGridViewCell = GetStartCell(grdDataCartons)
        'Get the clipboard value in a dictionary
        Dim cbValue As Dictionary(Of Integer, Dictionary(Of Integer, String)) = ClipBoardValues(Clipboard.GetText())
        'Dim cbValue As Dictionary(Of Integer, Dictionary(Of Integer, String)) = ClipBoardValues(Clipboard.GetText())

        Dim iRowIndex As Integer = startCell.RowIndex
        For Each rowKey As Integer In cbValue.Keys
            Dim iColIndex As Integer = startCell.ColumnIndex
            For Each cellKey As Integer In cbValue(rowKey).Keys
                'Check if the index is within the limit
                If iColIndex <= grdDataCartons.Columns.Count - 1 AndAlso iRowIndex <= grdDataCartons.Rows.Count - 1 Then
                    Dim cell As DataGridViewCell = grdDataCartons(iColIndex, iRowIndex)

                    'Copy to selected cells if 'chkPasteToSelectedCells' is checked
                    'If (chkPasteToSelectedCells.Checked AndAlso cell.Selected) OrElse (Not chkPasteToSelectedCells.Checked) Then
                    If cell.Selected Then
                        cell.Value = cbValue(rowKey)(cellKey)
                    End If
                    'End If
                End If
                iColIndex += 1
            Next
            iRowIndex += 1
        Next
    End Sub


    Private Function GetStartCell(dgView As DataGridView) As DataGridViewCell
        'get the smallest row,column index
        If dgView.SelectedCells.Count = 0 Then
            Return Nothing
        End If

        Dim rowIndex As Integer = dgView.Rows.Count - 1
        Dim colIndex As Integer = dgView.Columns.Count - 1

        For Each dgvCell As DataGridViewCell In dgView.SelectedCells
            If dgvCell.RowIndex < rowIndex Then
                rowIndex = dgvCell.RowIndex
            End If
            If dgvCell.ColumnIndex < colIndex Then
                colIndex = dgvCell.ColumnIndex
            End If
        Next

        Return dgView(colIndex, rowIndex)
    End Function


    Private Function ClipBoardValues(clipboardValue As String) As Dictionary(Of Integer, Dictionary(Of Integer, String))
        Dim copyValues As New Dictionary(Of Integer, Dictionary(Of Integer, String))()

        Dim lines As [String]() = clipboardValue.Split(ControlChars.Lf)

        For i As Integer = 0 To lines.Length - 1
            copyValues(i) = New Dictionary(Of Integer, String)()
            Dim lineContent As [String]() = lines(i).Split(ControlChars.Tab)

            'if an empty cell value copied, then set the dictionary with an empty string
            'else Set value to dictionary
            If lineContent.Length = 0 Then
                copyValues(i)(0) = String.Empty
            Else
                For j As Integer = 0 To lineContent.Length - 1
                    copyValues(i)(j) = lineContent(j)
                Next
            End If
        Next
        Return copyValues
    End Function


    Private Sub Cut_Click(sender As System.Object, e As System.EventArgs) Handles Cut.Click
        'Copy to clipboard
        CopyToClipboard()
        'Clear selected cells
        For Each dgvCell As DataGridViewCell In grdDataCartons.SelectedCells
            dgvCell.Value = String.Empty
        Next
    End Sub

    Private Sub Paste_Click(sender As System.Object, e As System.EventArgs) Handles Paste.Click
        Call PasteClipboardValue()
    End Sub

    Private Sub PLDDocumentToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PLDDocumentToolStripMenuItem.Click
        strPacking_no = txtPackNo.Text
        If strPacking_no = "" Then strPacking_no = txtPackNo.Text
        If strPacking_no.Length = 0 Then Exit Sub
        ' Dim rptFileName As String = "rptPLD.rpt"
        Dim rptFileName As String = "rptPLD.rpt"
        If _StockType = "C" Then
            rptFileName = "rptPLC.rpt"
        ElseIf _StockType = "D" Then
            rptFileName = "rptPLD.rpt"
        ElseIf _StockType = "S" Then
            rptFileName = "rptPLS.rpt"
        End If


        If clsuser.ReportPath = "" Then clsuser.ReportPath = clsuser.ReportPath
        If Not oConfig.CheckReport(clsuser.ReportPath, rptFileName) Then Exit Sub
        'Dim frm As New frmReportPLG
        Dim frm As New frmReport
        Dim rpt As New CrystalDecisions.CrystalReports.Engine.ReportDocument
        Me.Cursor = Cursors.WaitCursor
        rpt.Load(clsuser.ReportPath & rptFileName)
        rpt.DataSourceConnections.Item(0).SetConnection(clsConn.servername, clsConn.database, False)
        rpt.DataSourceConnections.Item(0).SetLogon(clsConn.Userid, clsConn.Password)
        rpt.VerifyDatabase()
        rpt.SetParameterValue("@packno", strPacking_no)
        rpt.SetParameterValue("@cartno", "")

        'rpt.PrintOptions.PaperSize = CrystalDecisions.Shared.PaperSize.PaperA4
        'rpt.PrintOptions.PaperOrientation = CrystalDecisions.Shared.PaperOrientation.Portrait
        'rpt.PrintOptions.PaperSource = CrystalDecisions.Shared.PaperSource.Auto


        frm.Title = "PackingList Document"
        frm.CRViewer.ReportSource = rpt
        'Dim dt As New DataTable
        frm.MdiParent = Me.ParentForm
        frm.Show()
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub DOUTDocumentToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DOUTDocumentToolStripMenuItem.Click
        'Dim frm2 As New frmDOUTDocument
        'frm2.UserInfo = clsuser
        'frm2.MdiParent = Me.ParentForm
        'frm2.Show()

        '   If txtOutNo.Text.Length = 0 Then Exit Sub
        ' dim rptFileName = "rptDOUT.rpt"
        Dim rptFileName As String = "rptDOUT.rpt"
        If _StockType = "C" Then
            rptFileName = "rptCOUT.rpt"
        ElseIf _StockType = "D" Then
            rptFileName = "rptDOUT.rpt"
        ElseIf _StockType = "S" Then
            rptFileName = "rptSOUT.rpt"
        End If
        'Const rptFileName = "rptDOUTByPackNo.rpt" 'NOT USE

        If clsuser.ReportPath = "" Then clsuser.ReportPath = clsuser.ReportPath
        If Not oConfig.CheckReport(clsuser.ReportPath, rptFileName) Then Exit Sub
        Dim frm As New frmReport
        Dim rpt As New CrystalDecisions.CrystalReports.Engine.ReportDocument
        Me.Cursor = Cursors.WaitCursor
        rpt.Load(clsuser.ReportPath & rptFileName)
        rpt.DataSourceConnections.Item(0).SetConnection(clsConn.servername, clsConn.database, False)
        rpt.DataSourceConnections.Item(0).SetLogon(clsConn.Userid, clsConn.Password)
        rpt.VerifyDatabase()
        rpt.SetParameterValue("@outno", txtOutNo.Text.Trim)
        'rpt.SetParameterValue("@packno", txtPackNo.Text.Trim)
        'rpt.PrintOptions.PaperSize = CrystalDecisions.Shared.PaperSize.PaperA4
        'rpt.PrintOptions.PaperOrientation = CrystalDecisions.Shared.PaperOrientation.Portrait
        'rpt.PrintOptions.PaperSource = CrystalDecisions.Shared.PaperSource.Auto

        frm.Title = "Out Document"
        frm.CRViewer.ReportSource = rpt
        frm.MdiParent = Me.ParentForm
        frm.Show()
        Me.Cursor = Cursors.Default
    End Sub

    '----- Tag Label
    Private Sub tsmnDINTagStandard_Click(sender As Object, e As EventArgs) Handles tsmnDINTagStandard.Click
        Dim rptFileName As String = "rptStockDBarcode.rpt"
        Dim TitleName As String = "Tag Of Standard Format"
        PrintReport(rptFileName, TitleName)
    End Sub

    Private Sub tsmnShowSentToCust_Click(sender As Object, e As EventArgs) Handles tsmnShowSentToCust.Click
        Dim rptFileName As String = "rptStockDBarcodeShowSentToCust.rpt"
        Dim TitleName As String = "Tag for show sent to customer"
        PrintReport(rptFileName, TitleName)
    End Sub

    Private Sub tsmnDINTagSTG_Click(sender As Object, e As EventArgs) Handles tsmnDINTagSTG.Click
        Dim rptFileName As String = "rptStockDStgBarcode.rpt"
        Dim TitleName As String = "Tag Of STG Format"
        PrintReport(rptFileName, TitleName)
    End Sub

    Private Sub tsmnTagChantasia_Click(sender As Object, e As EventArgs) Handles tsmnTagChantasia.Click
        Dim rptFileName As String = "rptStockDChantasiaBarcode.rpt"
        Dim TitleName As String = "Tag Of Chantasia Format"
        PrintReport(rptFileName, TitleName)
    End Sub

    Private Sub tsmnTagHanesbrandsVietnam_Click(sender As Object, e As EventArgs) Handles tsmnTagHanesbrandsVietnam.Click
        Dim rptFileName As String = "rptStockDHanesbrands.rpt"
        Dim TitleName As String = "Tag Of Hanesbrands Vietnam Format"
        PrintReport(rptFileName, TitleName)
    End Sub

    Private Sub PrintReport(pRptFileName As String, pTitle As String)
        If clsuser.ReportPath = "" Then clsuser.ReportPath = clsuser.ReportPath

        If Not oConfig.CheckReport(clsuser.ReportPath, pRptFileName) Then Exit Sub
        Dim frm As New frmReport
        Dim rpt As New CrystalDecisions.CrystalReports.Engine.ReportDocument
        Dim stype As String = ""
        Dim ord As String = ""
        Me.Cursor = Cursors.WaitCursor

        rpt.Load(clsuser.ReportPath & pRptFileName)
        rpt.DataSourceConnections.Item(0).SetConnection(clsConn.servername, clsConn.database, False)
        rpt.DataSourceConnections.Item(0).SetLogon(clsConn.Userid, clsConn.Password)
        'rpt.VerifyDatabase() 'Sitthana 20231120 Don't verify because it slow
        rpt.SetParameterValue("@roll_no", txtOutNo.Text.Trim)
        rpt.SetParameterValue("@loc", "")
        rpt.SetParameterValue("@logempcd", Userinfo.UserID)

        frm.Title = pTitle
        frm.CRViewer.ReportSource = rpt
        frm.MdiParent = Me.ParentForm
        frm.Show()
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub grdDataCartons_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs) Handles grdDataCartons.CellValueChanged
        With grdDataCartons
            Select Case .Columns(e.ColumnIndex).Name.ToUpper
                Case "grdData_carton_wide".ToUpper, "grdData_carton_long".ToUpper, "grdData_carton_high".ToUpper
                    AssignDimensionValue(.CurrentRow.Index)
            End Select
        End With 'Sitthana 20220757
    End Sub
    Private Sub AssignDimensionValue(pRow As Integer)
        'Sitthana 20220757
        With grdDataCartons
            If .Rows.Count > 0 Then
                Dim CartonWide As String = oConfig.IsNull(.Rows(pRow).Cells("grdData_carton_wide").Value, "").ToString.Trim
                Dim CartonLong As String = oConfig.IsNull(.Rows(pRow).Cells("grdData_carton_long").Value, "").ToString.Trim
                Dim CartonHigh As String = oConfig.IsNull(.Rows(pRow).Cells("grdData_carton_high").Value, "").ToString.Trim

                If CartonWide <> "" And CartonLong <> "" And CartonHigh <> "" Then
                    .Rows(pRow).Cells("grdDataCartons_dimension").Value = CartonWide & "CM X " _
                                                                            & CartonLong & "CM X " _
                                                                            & CartonHigh & "CM"
                    'SumCBM()
                End If
            End If
        End With
    End Sub

    Private Sub SumCBM()
        With grdDataCartons
            If .Rows.Count > 0 Then
                Dim dblCBMCarton As Double = 0 'Sitthana 20220729
                Dim dblCBMRoll As Double = 0 'Sitthana 20220729

                For i As Integer = 0 To .Rows.Count - 1
                    dblCBMCarton += oConfig.IsNull(.Rows(i).Cells("grdData_CBMForCarton").Value, 0)  'Sitthana 20220729
                    dblCBMRoll += oConfig.IsNull(.Rows(i).Cells("grdData_CBMForRoll").Value, 0) 'Sitthana 20220729
                Next

                txtTotalCBMCarton.Text = Format(dblCBMCarton, "##0.000") 'Sitthana 20220729
                txtTotalCBMRoll.Text = Format(dblCBMRoll, "##0.000") 'Sitthana 20220729
            End If
        End With
    End Sub


End Class
