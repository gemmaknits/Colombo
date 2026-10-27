Imports System.Drawing
Imports System.Data.SqlClient
Imports System.Data
Imports System.Math

Public Class frmPLD

    Dim clsconfig As New clsConfig
    Dim clsConn As New classConnection
    Dim clsuser As New classUserInfo
    Dim dbPackingListD As New classPLD
    Dim strreqno As String = ""
    Dim blnCancel As Boolean = False
    Dim strPacking_no As String = ""
    Dim strPackingNo As String = ""
    Dim strOut_no As String = ""
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

    Private Sub frmPackingListDyedOut_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Call InitControl()
    End Sub
    Private Sub InitControl()
        Call GenCboDoc_type()
        Call GenCboCartonsNo()
        'Call GenComboCustomer()
        Dim obj As Control
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
        lblCancelled.Visible = False
        'Call GenComboCustomer()
        Dim strreqno As String = ""
        Dim blnCancel As Boolean = False
        'Dim strPacking_no As String = ""
        Dim strCartno As String = ""

        txtReqNo.Focus()

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
        Dim objdb As New classPLD
        grdDataPackingList.AutoGenerateColumns = False
        grdDataPackingList.DataSource = objdb.GetPackinglistDDataDetail("0", "0")

    End Sub
    Private Sub CleargrdDataCartons()
        Dim objdb As New classPLD
        grdDataCartons.AutoGenerateColumns = False
        grdDataCartons.DataSource = objdb.GetPackinglistDDataCartons("")


    End Sub
    Private Sub ClearCboCartonsNo()
        Dim objdb As New classPLD
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
        Dim frm As New frmSearchPLD
        frm.ShowDialog(Me)
        txtPackNo.Text = (frm.pPackno.Trim.ToUpper)
        'Call btnNew_Click(sender, e)
        Me.Cursor = Cursors.WaitCursor
        If Not blnCancel Then
            If GetCartonsData(txtPackNo.Text) Then
                strPacking_no = txtPackNo.Text
                Dim strcartno2 As String = ""
                GetPackinglistDData(strPacking_no.Trim.ToUpper, strcartno2)
                'btngout.Enabled = True
            End If
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
        txtPackNo.Text = dt.Rows(0)("packno").ToString()

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
    Private Sub BindPackinglistDData(ByVal dt As DataTable)
        Dim i As Integer = 0
        Dim j As Integer = 0

        'grdDataPackingList.Rows.Clear()
        grdDataPackingList.AutoGenerateColumns = False
        grdDataPackingList.DataSource = dt

        'DtpPackDate.Value = (dt.Rows(0)("packdt"))
        DtpPackDate.Value = CDate(dt.Rows(0)("packdt").ToString)
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
        End If
    End Sub
    Private Sub SumGrdPackingList()

        'Dim dtc As DataTable = grdDataCartons.DataSource
        'Dim dtp As DataTable = grdDataPackingList.DataSource
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
        'grdDataCartons.Rows(j).Cells("grdDataCartons_netwt").Value = 0
        If grdDataCartons.Rows.Count > 0 Then

            For j = 0 To grdDataCartons.Rows.Count - 2
                For i = 0 To grdDataPackingList.Rows.Count - 1
                    If config.IsNull(grdDataCartons.Rows(j).Cells("grdDataCartons_cartno").Value, 0) = config.IsNull(grdDataPackingList.Rows(i).Cells("grdDataPackingList_cartno").Value, 0) Then

                        netwt = netwt + config.IsNull(grdDataPackingList.Rows(i).Cells("grdDataPackingList_outkg_g").Value, 0)
                        anetwt = 0.0
                        'grdDataCartons.Rows(j).Cells("grdDataCartons_netwt").Value = netwt

                        CartMts = CartMts + config.IsNull(grdDataPackingList.Rows(i).Cells("grdDataPackingList_outmt_g").Value, 0)
                        'grdDataCartons.Rows(j).Cells("CartMts").Value = CartMts

                        CartYds = CartYds + config.IsNull(grdDataPackingList.Rows(i).Cells("grdDataPackingList_outyd_g").Value, 0)
                        'grdDataCartons.Rows(j).Cells("CartYds").Value = CartYds

                        totalroll = totalroll + 1


                    End If
                Next
                grdDataCartons.Rows(j).Cells("grdDataCartons_netwt").Value = FormatNumber(netwt, 2, TriState.False, TriState.False, TriState.True)
                'grdDataCartons.Rows(j).Cells("grdDataCartons_netwt").Value = netwt 'FormatNumber(netwt, 2, TriState.False, TriState.False, TriState.True)
                'String.Format("{0:#,###0.00}", grdDataCartons.Rows(j).Cells("grdDataCartons_netwt"))
                netwt = 0
                grdDataCartons.Rows(j).Cells("CartMts").Value = FormatNumber(CartMts, 2, TriState.False, TriState.False, TriState.True)
                CartMts = 0
                grdDataCartons.Rows(j).Cells("CartYds").Value = FormatNumber(CartYds, 2, TriState.False, TriState.False, TriState.True)
                CartYds = 0
                grdDataCartons.Rows(j).Cells("grdDataCartons_CartRolls").Value = totalroll
                totalroll = 0
            Next
        End If

        For i = 0 To grdDataPackingList.Rows.Count - 1
            dblKgs = dblKgs + config.IsNull(grdDataPackingList.Rows(i).Cells("grdDataPackingList_outkg_g").Value, 0)
            dblMts = dblMts + config.IsNull(grdDataPackingList.Rows(i).Cells("grdDataPackingList_outmt_g").Value, 0)
            dblYds = dblYds + config.IsNull(grdDataPackingList.Rows(i).Cells("grdDataPackingList_outyd_g").Value, 0)


        Next
        'For j = 0 To grdDataCartons.Rows.Count - 1
        'If grdDataCartons.Rows(j).Cells("grdDataCartons_packno").Value = grdDataPackingList.Rows(j).Cells("grdDataPackingList_packno").Value Then
        'grdDataPackingList.Rows(j).Cells("CartRolls").Value = grdDataPackingList.Rows(j).Cells("CartRolls").Value + config.IsNull(grdDataPackingList.Rows(i).Cells("grdDataPackingList_outkg_g").Value, 0)
        'End If
        ' Next

        txtTotalRolls.Text = FormatNumber(grdDataPackingList.Rows.Count, 0, TriState.False, TriState.False, TriState.True)
        txtTotalKgs.Text = FormatNumber(dblKgs, 2, TriState.False, TriState.False, TriState.True)
        txtTotalMts.Text = FormatNumber(dblMts, 2, TriState.False, TriState.False, TriState.True)
        txtTotalYds.Text = FormatNumber(dblYds, 2, TriState.False, TriState.False, TriState.True)
        'For j = 0 To grdDataPackingList.Rows.Count - 1
        '    If grdDataCartons.Rows(0).Cells("grdDataCartons_cartno").Value = (grdDataPackingList.Rows(i).Cells("grdDataPackingList_cartno").Value Then
        '        grdDataPackingList.Rows(i).Cells("grdDataCartons_netwt").Value = grdDataPackingList.Rows(i).Cells("grdDataCartons_netwt").Value + config.IsNull(grdDataPackingList.Rows(i).Cells("grdDataPackingList_outkg_g").Value, 0)

        '    End If

        'Next

    End Sub
    Private Sub BtnCancel_Click(sender As System.Object, e As System.EventArgs) Handles BtnCancel.Click
        CancelPackinglistD()
    End Sub
    Private Sub CancelPackinglistD()
        If strPacking_no = "" Then strPacking_no = txtPackNo.Text.Trim.ToUpper
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
        'Dim obj As New classPackingListG
        'If obj.IsAlreadyGOUT(strPacking_no) = True Then
        '    MessageBox.Show("This document is already GOUT." & vbCrLf & "Can't cancel anymore.", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
        '    Exit Sub
        'End If
        If MessageBox.Show("Would you like to cancel this document ?", "System Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = DialogResult.No Then Exit Sub


        If CancelPLD() Then
            MessageBox.Show("PACK NO." & vbCrLf & strPacking_no & "is Cancel", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Call InitControl()
            'lblCancelled.Visible = True
        End If

    End Sub
    Private Function CancelPLD() As Boolean
        Dim confid As New clsConfig
        Dim obidb As New classPLD
        Dim PLDHeader As New classPLD.PackingListDHeader
        Dim msgerr As String = ""

        Dim PLDNo As String = strPacking_no
        Dim OUTNo As String = strOut_no
        Dim OUTDT As String = DtpOutdt.Value.ToString("yyyyMMdd")

        Dim PACKDT As String = DtpPackDate.Value.ToString("yyyyMMdd")
        Dim OUTREQNo As String = txtReqNo.Text
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
            CancelPLD = True
        Else
            CancelPLD = False
        End If

    End Function
    Private Sub btnNew_Click(sender As System.Object, e As System.EventArgs) Handles btnNew.Click
        If Not blnCancel Then Call InitControl()
    End Sub

    Private Sub BtnExit_Click(sender As System.Object, e As System.EventArgs) Handles BtnExit.Click
        Me.Close()
    End Sub
    Private Sub frmPackingListDyed_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If MessageBox.Show("Would you like to close ?", "System Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.No Then
            e.Cancel = True
        End If
    End Sub
    Private Sub btnSearchREQD_Click(sender As System.Object, e As System.EventArgs) Handles btnSearchREQD.Click
        Dim frm As New frmSearchREQD
        frm.pStockType = "D"
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
            MessageBox.Show("Req. No : " & StrReqno & "............   is Already Used!! For " & strPackingNo)
            'Exit Function 'Edit By Neung Doesn't use

        End If

        Dim dt As DataTable = dbPackingListD.GetREQD(StrReqno)
        If dt.Rows.Count > 0 Then
            Call BindDataREQD(dt)
            txtReqNo.Text = dt.Rows(0)("outreqno").ToString()
            CboDoc_type.SelectedValue = dt.Rows(0)("outreqtyp").ToString()
            txtcustomer.Text = dt.Rows(0)("custname").ToString()

            Return True
        End If
        Return False
    End Function
    Private Sub BindDataREQD(ByVal dt As DataTable)
        Dim config As New clsConfig
        If txtReqNo.Text = "" Then Exit Sub

        grdDataPackingList.AutoGenerateColumns = False
        If dt.Rows.Count > 0 Then
            Dim dt1 As DataTable = dt
            Dim dt2 As DataTable = grdDataPackingList.DataSource

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
        Call SumGrdPackingList()


        'grdDataPackingList.DataSource = dt
        'txtReqNo.Text = dt.Rows(0)("outreqno").ToString()
    End Sub

    Private Sub grdDataPackingList_CellEndEdit(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles grdDataPackingList.CellEndEdit
        SumGrdPackingList()
    End Sub


    Private Sub grdDataCartons_CellEndEdit(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles grdDataCartons.CellEndEdit
        SumGrdPackingList()
    End Sub

    Private Sub BtnSave_Click(sender As System.Object, e As System.EventArgs) Handles BtnSave.Click
        If Not grdDataCartons.EndEdit Then Exit Sub
        If Not grdDataPackingList.EndEdit Then Exit Sub
        'Fix Bug User
        txtPackNo.Focus()
        'Fix Bug User

        SavePackinglistD()
    End Sub
    Private Sub SavePackinglistD()
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
            If clsconfig.IsNull(grdDataCartons.Rows(i).Cells("grdDataCartons_cartno").Value, 0) = 0 Then
                MessageBox.Show("Cartno. is not Zero." & vbCrLf & "Please Check it.", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
                Exit Sub
            End If

        Next
        For i = 0 To grdDataPackingList.Rows.Count - 1
            If grdDataPackingList.Rows(i).Cells("grdDataPackingList_cartno").Value = 0 Then
                MessageBox.Show("Cartno. is not Zero." & vbCrLf & "Please Check it.", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
                Exit Sub
            End If

        Next

        If SavePLD() Then
            Loaddata(PackinglistNo)
            GetPackinglistDData(PackinglistNo, "")
            Validate_Outno()
        End If



    End Sub
    Private Sub Loaddata(ByVal PackinglistNo As String)
        Dim objdb As New classPLD
        Dim dt As New DataTable

        dt = objdb.GetPackinglistDDataCartons(PackinglistNo)

        Call bindGrdDataPackingList(dt)
        Call SumGrdPackingList()
        Call BindDataAfterSavePackNo(dt)


    End Sub
    Private Sub BindDataAfterSavePackNo(ByVal dt As DataTable)
        txtPackNo.Text = dt.Rows(0)("packno").ToString.Trim
    End Sub
    Private Sub bindGrdDataPackingList(ByVal dt As DataTable)
        'grdDataCartons.Rows.Clear()
        grdDataCartons.AutoGenerateColumns = False
        grdDataCartons.DataSource = dt
    End Sub
    Private Function SavePLD() As Boolean
        Dim config As New clsConfig
        Dim objdb As New classPLD
        Dim PLDHeader As New classPLD.PackingListDHeader
        Dim msgerr As String = ""

        Dim PLDNo As String = strPacking_no
        Dim OUTNo As String = strOut_no
        Dim OUTREQNo As String = txtReqNo.Text
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
        PLDHeader.h38_packdt = DtpPackDate.Value '.ToString ("yyyyMMdd")
        PLDHeader.h20_outno = txtOutNo.Text.Trim
        PLDHeader.h21_outdt = DtpOutdt.Value '.ToString("yyyyMMdd")
        PLDHeader.h46_empcd = clsuser.UserID.Trim

        blnCancel = False
        'Sitthana 20220624 Changed Windows.Forms.DialogResult To DialogResult
        Dim result As DialogResult ' Windows.Forms.DialogResult
        result = MessageBox.Show("Would you like to save ?", "System Message", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button3)
        If result = DialogResult.Cancel Then blnCancel = True
        If result <> DialogResult.Yes Then Exit Function



        If objdb.pldsave(PLDHeader, dv_dtc_add, dv_dtp_add, dv_dtc_upd, dv_dtp_upd, dv_dtc_del, dv_dtp_del, msgerr, PLDNo, OUTREQNo, PACKDT, OUTNo, OUTDT, USERID, CheckNEW, Doc_type) Then
            PackinglistNo = PLDNo
            strPacking_no = PLDNo
            'ValidateOutno()
            Validate_Outno()
            SavePLD = True

        Else
            SavePLD = False
            MessageBox.Show(msgerr, "System Message", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
        End If


    End Function

    Private Sub BtnPrint_Click(sender As System.Object, e As System.EventArgs) Handles BtnPrintPLD.Click
        strPacking_no = txtPackNo.Text
        If strPacking_no = "" Then strPacking_no = txtPackNo.Text
        If strPacking_no.Length = 0 Then Exit Sub
        Const rptFileName = "rptPLD.rpt"

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
        rpt.SetParameterValue("@packno", strPacking_no)
        rpt.SetParameterValue("@cartno", "")
        rpt.PrintOptions.PaperSize = CrystalDecisions.Shared.PaperSize.PaperA4
        rpt.PrintOptions.PaperOrientation = CrystalDecisions.Shared.PaperOrientation.Portrait
        rpt.PrintOptions.PaperSource = CrystalDecisions.Shared.PaperSource.Auto

        frm.Title = "PackingList D"
        frm.CRViewer.ReportSource = rpt
        'Dim dt As New DataTable
        frm.MdiParent = Me.ParentForm
        frm.Show()
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub btngout_Click(sender As System.Object, e As System.EventArgs) Handles btngout.Click
        SavePackinglistDOUT()
    End Sub
    Private Sub SavePackinglistDOUT()
        If strPacking_no = "" Then strPacking_no = txtPackNo.Text.Trim.ToUpper
        If strPacking_no.Length = 0 Then Exit Sub
        If grdDataCartons.DataSource Is Nothing Then Exit Sub
        If grdDataCartons.Rows.Count = 0 Then Exit Sub
        If grdDataPackingList.DataSource Is Nothing Then Exit Sub
        If grdDataPackingList.Rows.Count = 0 Then Exit Sub


        blnCancel = False
        'Sitthana 20220624 Changed Windows.Forms.DialogResult To DialogResult
        Dim result As DialogResult ' Windows.Forms.DialogResult
        result = MessageBox.Show("Would you like to save Dyed Out ?", "System Message", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button3)
        If result = DialogResult.Cancel Then blnCancel = True
        If result <> DialogResult.Yes Then Exit Sub

        If SavePLDOUT() Then
            MessageBox.Show("Pack No. : " & PackinglistNo & "บันทึกสำเร็จ ! ", "System Message", MessageBoxButtons.OK, MessageBoxIcon.None, MessageBoxDefaultButton.Button1)
            LoaddataDout(PackinglistNo)
            Validate_Outno()
        End If



    End Sub
    Private Sub LoaddataDout(ByVal PackinglistNo As String)
        Dim objdb As New classPLD
        Dim dt As New DataTable
        dt = objdb.GetPackinglistDDataCartons(PackinglistNo)

        Call bindGrdDataPackingList(dt)
        Call SumGrdPackingList()
        'Call BindDataDout(dt)

        txtOutNo.Text = strOut_no
        Call GetPackinglistDData(strPacking_no, "")
        'CboDoc_type.SelectedValue = dt.Rows(0)("doctyp")
    End Sub
    Private Function SavePLDOUT() As Boolean
        Dim config As New clsConfig
        Dim objdb As New classPLD
        Dim PLDHeader As New classPLD.PackingListDHeader
        Dim CartonsHeader As New classPLD.CartonsHeader
        Dim msgerr As String = ""

        Dim PLDNo As String = strPacking_no
        Dim OUTNo As String = strOut_no
        Dim OUTREQNo As String = txtReqNo.Text
        Dim PACKDT As String = DtpPackDate.Value.ToString("yyyyMMdd")
        Dim OUTDT As String = DtpOutdt.Value.ToString("yyyyMMdd")
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

        Dim dtp2 As DataTable = grdDataPackingList.DataSource
        'header.h01_cartno = dtc.Rows(0)("cartno").ToString.Trim
        'header.h17_outreqno = txtReqNo.Text

        CartonsHeader.h06_gout = 1
        CartonsHeader.h07_sel = True

        PLDHeader.h02_packno = txtPackNo.Text.Trim
        PLDHeader.h20_outno = txtOutNo.Text.Trim
        PLDHeader.h46_empcd = clsuser.UserID.Trim

        'blnCancel = False
        'Dim result As Windows.Forms.DialogResult
        'result = MessageBox.Show("Would you like to save ?", "System Message", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button3)
        'If result = Windows.Forms.DialogResult.Cancel Then blnCancel = True
        'If result <> Windows.Forms.DialogResult.Yes Then Exit Function



        If objdb.pldsaveDOUT(PLDHeader, dv_dtc_add, dv_dtp_add, dv_dtc_upd, dv_dtp_upd, dv_dtc_del, dv_dtp_del, msgerr, PLDNo, OUTREQNo, PACKDT, OUTNo, OUTDT, USERID, CheckNEW, Doc_type, dtp2, dtc, CartonsHeader) Then
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

    Private Sub txtPackNo_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles txtPackNo.KeyDown
        If e.KeyCode.Equals(Keys.Enter) Then

            If GetPackinglistDData(txtPackNo.Text, "") And GetCartonsData(txtPackNo.Text) Then
                'If GetCartonsData(txtPackNo.Text) Then
                '    strPacking_no = txtPackNo.Text
                '    Dim strcartno2 As String = ""
                '    GetPackinglistDData(strPacking_no, strcartno2)

                'End If
            Else
                MessageBox.Show("ไม่พบ Packlist Dyed โปรดลองใหม่อีกครั้ง", "System Message", MessageBoxButtons.OK)
            End If


        End If

    End Sub

    Private Sub txtPackNo_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtPackNo.TextChanged

    End Sub

    Private Sub txtReqNo_GotFocus(sender As Object, e As System.EventArgs) Handles txtReqNo.GotFocus
        lblCancelled.Visible = False
    End Sub

    Private Sub txtReqNo_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles txtReqNo.KeyDown
        If e.KeyCode.Equals(Keys.Enter) Then



            If GetREQD(txtReqNo.Text) Then

            End If
        End If
    End Sub

    Private Function Validate_ReqNoIsCancel(ReqNo) As Boolean
        Dim objDB As New classPLD
        Dim dt As DataTable = objDB.ValidateReqNoIsCancel(ReqNo, clsuser.UserID)

        If dt.Rows.Count = 0 Then
            Return False
        End If
        Return True
    End Function
    Private Function Validate_ReqNoGOut(ReqNo) As Boolean
        Dim objDB As New classPLD
        Dim dt As DataTable = objDB.ValidateReqNoIsPack(ReqNo, clsuser.UserID)

        If dt.Rows.Count > 0 Then
            strPackingNo = (dt.Rows(0)("packno").ToString)
            Return False

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
        Dim objdb As New classPLD
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

    Private Sub txtReqNo_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtReqNo.TextChanged

    End Sub

    Private Sub BtnPrintDOut_Click(sender As System.Object, e As System.EventArgs) Handles BtnPrintDOut.Click
        'strPacking_no = txtPackNo.Text
        'If strPacking_no = "" Then strPacking_no = txtPackNo.Text
        'If strPacking_no.Length = 0 Then Exit Sub
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

        frm.Title = "PackingList D"
        frm.CRViewer.ReportSource = rpt
        'Dim dt As New DataTable
        frm.MdiParent = Me.ParentForm
        frm.Show()
        Me.Cursor = Cursors.Default
    End Sub
End Class