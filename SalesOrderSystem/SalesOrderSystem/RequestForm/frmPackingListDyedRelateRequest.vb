Public Class frmPackingListDyedRelateRequest
#Region "History"
    'Create By    : Sitthana Boonlom
    'Create Date  : 20240628
    'Description  : Copy Some Code from frmPackingListDyed
#End Region

#Region "Property"
    Private _clsUserInfo As classUserInfo
    Private _ReqNo As String
    Private _CustomerName As String
    Private _PackNo As String
    Private _OutNo As String

    Public Property clsUserInfo As classUserInfo
        Get
            clsUserInfo = _clsUserInfo
        End Get
        Set(ByVal Newvalue As classUserInfo)
            _clsUserInfo = Newvalue
        End Set
    End Property

    Public Property ReqNo As String
        Get
            ReqNo = _ReqNo
        End Get
        Set(ByVal Newvalue As String)
            _ReqNo = Newvalue
        End Set
    End Property

    Public Property CustomerName As String
        Get
            CustomerName = _CustomerName
        End Get
        Set(ByVal Newvalue As String)
            _CustomerName = Newvalue
        End Set
    End Property

    Public Property PackNo As String
        Get
            PackNo = _PackNo
        End Get
        Set(ByVal Newvalue As String)
            _PackNo = Newvalue
        End Set
    End Property

    Public Property OutNo As String
        Get
            OutNo = _OutNo
        End Get
        Set(ByVal Newvalue As String)
            _OutNo = Newvalue
        End Set
    End Property
#End Region

    Private clsConn As New classConnection
    Private clsconfig As New clsConfig
    Private clsMaster As New classMaster
    Private clsPackingListD As New classPackingListD

    Private PackingNo As String = ""

    Private PackingListNo As String = "" 'get after saved
    Private strPacking_no As String = ""
    Private strOut_no As String = "" 'get after saved

    Private rptFileName As String = ""

    Private ErrNo As Integer = 0
    Private ErrMsg As String = ""
    Dim _StockType As String

    Dim clsUser As New classUserInfo
    Public Property UserInfo() As classUserInfo
        Get
            UserInfo = clsUser
        End Get
        Set(ByVal NewValue As classUserInfo)
            clsUser = NewValue
        End Set
    End Property
    Public Property pStockType As String
        Get
            pStockType = _StockType
        End Get
        Set(ByVal Newvalue As String)
            _StockType = Newvalue
        End Set
    End Property
    Private Sub frmPackingListDyeRelateRequest_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        initComboBox()
        InitControl()

        txtReqNo.Text = _ReqNo
        txtcustomer.Text = _CustomerName
        If clsconfig.IsNull(_PackNo, "").Trim <> "" Then
            txtPackNo.Text = clsconfig.IsNull(_PackNo, "").Trim
            Call GetPackinglistDData(_PackNo, "")
            Call GetCartonsData(txtPackNo.Text)
            Call SumGrdPackingList()
        Else
            GetREQD(txtReqNo.Text)
        End If
    End Sub

    Private Sub initComboBox()
        With CboDoc_type
            .DataSource = clsMaster.GetDocType
            .DisplayMember = "name"
            .ValueMember = "doctyp"
        End With

        With CboCartonsNo
            .DataSource = grdDataCartons.DataSource
            .DisplayMember = "cartno"
            .ValueMember = "cartno"
        End With
    End Sub

    Private Sub InitControl()
        For Each obj In Me.Controls
            Call SetControlValue(obj)
        Next

        With grdDataPackingList
            .AutoGenerateColumns = False
            .DataSource = clsPackingListD.GetPackinglistDDataDetail("0", "0")
        End With

        With grdDataCartons
            .AutoGenerateColumns = False
            .DataSource = clsPackingListD.GetPackinglistDDataCartons("")
        End With

        With CboCartonsNo
            .DataSource = grdDataCartons.DataSource
            .DisplayMember = "cartno"
            .ValueMember = "cartno"
            .SelectedIndex = -1
        End With

        btngout.Enabled = False
        DtpOutdt.Enabled = False
        DtpOutdt.Checked = False
        BtnYarnPrintBar.Enabled = False
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

    Function GetCartonsData(ByVal StrPackno As String) As Boolean
        Dim dt As DataTable = clsPackingListD.GetPackinglistDDataCartons(StrPackno)

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

    Private Function GetREQD(ByVal pReqNo As String) As Boolean
        If pReqNo = "" Then Exit Function

        If Not Validate_ReqNoIsCancel(pReqNo) Then 'Check ReqNo ,Is' Cancel?
            MessageBox.Show("Req. No : " & pReqNo & "............   Req No. is Already Cancel!!")
            Exit Function
        End If

        If Not Validate_ReqNoGOut(pReqNo) Then 'Check ReqNo ,Is' used?
            MessageBox.Show("Req. No : " & pReqNo & "............   is Already Used!! For " & PackingNo)
            'Exit Function 'Disibel By Neung Gammaknit Didn't use 
        End If

        Dim dt As DataTable
        dt = clsPackingListD.GetREQD(pReqNo)

        If dt.Rows.Count > 0 Then
            Call BindDataREQD(dt)
            txtReqNo.Text = dt.Rows(0)("outreqno").ToString()
            CboDoc_type.SelectedValue = dt.Rows(0)("outreqtyp").ToString()
            txtcustomer.Text = dt.Rows(0)("custname").ToString()

            Return True
        End If
        Return False
    End Function

    Private Function Validate_ReqNoIsCancel(ReqNo) As Boolean
        Dim dt As DataTable = clsPackingListD.ValidateReqNoIsCancel(ReqNo, clsUserInfo.UserID)

        If dt.Rows.Count = 0 Then
            Return False
        End If
        Return True
    End Function

    Private Function Validate_ReqNoGOut(ReqNo) As Boolean
        Dim dt As DataTable = clsPackingListD.ValidateReqNoIsPack(ReqNo, clsUserInfo.UserID)

        If dt.Rows.Count > 0 Then
            PackingNo = (dt.Rows(0)("packno").ToString)
            Return False
            'Return True
        End If
        Return True
    End Function

    Private Sub BindDataREQD(ByVal dt As DataTable)
        If txtReqNo.Text = "" Then Exit Sub
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
    End Sub

    Private Sub SumGrdPackingList()
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

        If grdDataCartons.Rows.Count > 0 Then

            For j = 0 To grdDataCartons.Rows.Count - 2
                For i = 0 To grdDataPackingList.Rows.Count - 1

                    If clsconfig.IsNull(grdDataCartons.Rows(j).Cells("grdDataCartons_cartno").Value, 0) = clsconfig.IsNull(grdDataPackingList.Rows(i).Cells("grdDataPackingList_cartno").Value, 0) Then

                        netwt = netwt + clsconfig.IsNull(grdDataPackingList.Rows(i).Cells("grdDataPackingList_outkg_g").Value, 0)
                        anetwt = 0.0

                        CartMts = CartMts + clsconfig.IsNull(grdDataPackingList.Rows(i).Cells("grdDataPackingList_outmt_g").Value, 0)

                        CartYds = CartYds + clsconfig.IsNull(grdDataPackingList.Rows(i).Cells("grdDataPackingList_outyd_g").Value, 0)

                        totalroll = totalroll + 1

                    End If
                Next
                grdDataCartons.Rows(j).Cells("grdDataCartons_netwt").Value = netwt 'FormatNumber(netwt, 2, TriState.False, TriState.False, TriState.True)
                netwt = 0
                grdDataCartons.Rows(j).Cells("CartMts").Value = CartMts 'FormatNumber(CartMts, 2, TriState.False, TriState.False, TriState.True)
                CartMts = 0
                grdDataCartons.Rows(j).Cells("CartYds").Value = CartYds 'FormatNumber(CartYds, 2, TriState.False, TriState.False, TriState.True)
                CartYds = 0
                grdDataCartons.Rows(j).Cells("grdDataCartons_CartRolls").Value = totalroll
                grdDataCartons.Rows(j).Cells("grdData_CBMForRoll").Value = clsconfig.IsNull(grdDataCartons.Rows(j).Cells("grdData_CBMForCarton").Value, 0) * totalroll 'Sitthana 20220723
                totalroll = 0
            Next
        End If

        For i = 0 To grdDataPackingList.Rows.Count - 1
            dblKgs = dblKgs + clsconfig.IsNull(grdDataPackingList.Rows(i).Cells("grdDataPackingList_outkg_g").Value, 0)
            dblMts = dblMts + clsconfig.IsNull(grdDataPackingList.Rows(i).Cells("grdDataPackingList_outmt_g").Value, 0)
            dblYds = dblYds + clsconfig.IsNull(grdDataPackingList.Rows(i).Cells("grdDataPackingList_outyd_g").Value, 0)
        Next

        txtTotalRolls.Text = FormatNumber(grdDataPackingList.Rows.Count, 0, TriState.False, TriState.False, TriState.True)
        txtTotalKgs.Text = FormatNumber(dblKgs, 2, TriState.False, TriState.False, TriState.True)
        txtTotalMts.Text = FormatNumber(dblMts, 2, TriState.False, TriState.False, TriState.True)
        txtTotalYds.Text = FormatNumber(dblYds, 2, TriState.False, TriState.False, TriState.True)

        Call AutoDeleteCarton()
    End Sub

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

    Private Sub btnMoveLeft_Click(sender As Object, e As EventArgs) Handles btnMoveLeft.Click
        If grdDataCartons.Width > 150 Then
            grdDataCartons.Width = grdDataCartons.Width - 150
            btnMoveLeft.Left = grdDataCartons.Right
            btnMoveRight.Left = grdDataCartons.Right
            grdDataPackingList.Left = btnMoveLeft.Right
            grdDataPackingList.Width = grdDataPackingList.Width + 150
        End If
    End Sub

    Private Sub btnMoveRight_Click(sender As Object, e As EventArgs) Handles btnMoveRight.Click
        If grdDataPackingList.Width > 150 Then
            grdDataCartons.Width = grdDataCartons.Width + 150
            btnMoveLeft.Left = grdDataCartons.Right
            btnMoveRight.Left = grdDataCartons.Right
            grdDataPackingList.Left = btnMoveLeft.Right
            grdDataPackingList.Width = grdDataPackingList.Width - 150
        End If
    End Sub

    'grdDataPackingList
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
                Next
            End If
            If Not checkDupicateRoll Then
                dt2.Rows.Add(dr1)
            End If
        End If
    End Sub

    'grdDataCartons
    Private Sub grdDataCartons_CellEndEdit(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles grdDataCartons.CellEndEdit
        SumGrdPackingList()
    End Sub

    Private Sub grdDataCartons_CellMouseClick(sender As Object, e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles grdDataCartons.CellMouseClick
        If grdDataCartons.Rows.Count > 0 Then
            grdDataCartons.ContextMenuStrip = mnu
        End If
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
                Dim CartonWide As String = clsconfig.IsNull(.Rows(pRow).Cells("grdData_carton_wide").Value, "").ToString.Trim
                Dim CartonLong As String = clsconfig.IsNull(.Rows(pRow).Cells("grdData_carton_long").Value, "").ToString.Trim
                Dim CartonHigh As String = clsconfig.IsNull(.Rows(pRow).Cells("grdData_carton_high").Value, "").ToString.Trim

                If CartonWide <> "" And CartonLong <> "" And CartonHigh <> "" Then
                    .Rows(pRow).Cells("grdDataCartons_dimension").Value = CartonWide & "CM X " _
                                                                            & CartonLong & "CM X " _
                                                                            & CartonHigh & "CM"
                End If
            End If
        End With
    End Sub

    Private Sub BtnExit_Click(sender As Object, e As EventArgs) Handles BtnExit.Click
        Me.Close()
    End Sub

    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click
        'Sitthana 20220624 Changed Windows.Forms.DialogResult To DialogResult
        Dim result As DialogResult ' Windows.Forms.DialogResult
        result = MessageBox.Show("Would you like to save ?", "System Message", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button3)

        If result = DialogResult.Yes Then
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

            If CheckData() = True Then
                If SavePLD() Then
                    _PackNo = txtPackNo.Text.Trim
                    Loaddata(_PackNo)
                    GetPackinglistDData(_PackNo, "")

                    Validate_Outno()
                    'If txtOutNo.Text <> "" Then
                    '    Call BFSavePLDOUT()
                    'End If
                    Call BFSavePLDOUT()
                    _OutNo = txtOutNo.Text.Trim
                End If
            End If
        End If
    End Sub

    Private Function CheckData() As Boolean
        CheckData = False

        strPacking_no = txtPackNo.Text.Trim.ToUpper
        If strPacking_no = "" Then
            strPacking_no = txtPackNo.Text.Trim.ToUpper
        End If
        If strOut_no = "" Then
            strOut_no = txtOutNo.Text.Trim.ToUpper
        End If
        'If strPacking_no.Length = 0 Then
        '    ConcatMsg("Packing No is empty")
        '    CheckData = False
        'End If

        If grdDataCartons.DataSource Is Nothing Then
            ConcatMsg("DataSource Of Cartons datagrid is nothing")
        End If
        If grdDataCartons.Rows.Count = 0 Then
            ConcatMsg("Cartons is empty")
        End If
        If grdDataPackingList.DataSource Is Nothing Then
            ConcatMsg("DataSource of PackingList datagrid is nothing")
        End If
        If grdDataPackingList.Rows.Count = 0 Then
            ConcatMsg("PackingList is empty")
        End If

        Dim i As Integer
        For i = 0 To grdDataCartons.Rows.Count - 2
            If clsconfig.IsNull(grdDataCartons.Rows(i).Cells("grdDataCartons_cartno").Value, 0) = 0 Then
                'MessageBox.Show("Cartno. is not Zero." & vbCrLf & "Please Check it.", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
                ConcatMsg("Cartno. is not Zero.")
            End If
        Next

        For i = 0 To grdDataPackingList.Rows.Count - 1
            If grdDataPackingList.Rows(i).Cells("grdDataPackingList_cartno").Value = 0 Then
                'MessageBox.Show("PackingList is not Zero." & vbCrLf & "Please Check it.", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
                ConcatMsg("PackingList is not Zero.")
            End If
        Next

        If clsconfig.IsNull(CboDoc_type.SelectedValue, "") = "" Then
            'MessageBox.Show("Please Select Type." & vbCrLf, "System Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            ConcatMsg("Please Select Type.")
            CboDoc_type.Focus()
        End If

        If ErrMsg.Trim <> "" Then
            CheckData = False
            MessageBox.Show(ErrMsg, "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            CheckData = True
        End If
        Return CheckData
    End Function

    Private Sub ConcatMsg(pCurrErrorMsg As String)
        ErrNo += 1
        If ErrMsg.Length > 0 Then
            ErrMsg &= vbCr
        End If
        ErrMsg &= ErrNo.ToString & ") " & pCurrErrorMsg
    End Sub

    Private Function SavePLD() As Boolean
        Dim PLDHeader As New classPackingListD.PackingListDHeader
        Dim msgerr As String = ""

        Dim PLDNo As String = strPacking_no
        Dim OUTNo As String = strOut_no
        Dim OUTREQNo As String = txtReqNo.Text.Trim
        Dim PACKDT As String = DtpPackDate.Value.ToString("yyyyMMdd")
        Dim OUTDT As String = DtpOutdt.Value.ToString("yyyyMMdd")
        Dim USERID As String = clsUserInfo.UserID
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
        PLDHeader.h46_empcd = clsUserInfo.UserID.Trim

        If clsPackingListD.pldsave(PLDHeader, dv_dtc_add, dv_dtp_add, dv_dtc_upd, dv_dtp_upd, dv_dtc_del, dv_dtp_del, msgerr, PLDNo, OUTREQNo, PACKDT, OUTNo, OUTDT, USERID, CheckNEW, Doc_type, _StockType) Then
            txtPackNo.Text = PLDHeader.h36_packno.Trim

            MessageBox.Show("Save Is Complete! : บันทึกสำเร็จ! ", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
            SavePLD = True
        Else
            MessageBox.Show(msgerr, "System Message", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
            SavePLD = False
        End If
    End Function

    Private Sub Loaddata(ByVal PackinglistNo As String)
        Dim DtDataCartons As New DataTable
        Dim DtDataPackingList As New DataTable

        If clsPackingListD.ValidatePackno(txtPackNo.Text.Trim, clsUserInfo.UserID) Then
            DtDataCartons = clsPackingListD.GetPackinglistDDataCartons(PackinglistNo)
            DtDataPackingList = clsPackingListD.GetPackinglistDDataDetail(PackinglistNo)

            Call BindDataGrd(DtDataCartons, DtDataPackingList)
            Call BindDataText(DtDataCartons, DtDataPackingList)

            Call AutoDeleteCarton()
            Call SumCBM()
            Call SumGrdPackingList()
        Else
            MessageBox.Show("Pack No ไม่ถูกต้อง ", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
            Call InitControl()
            Exit Sub
        End If
    End Sub

    Private Sub BindDataGrd(ByVal DtDataCartons As DataTable, ByVal DtDataPackingList As DataTable)
        With grdDataCartons
            .AutoGenerateColumns = False
            .DataSource = DtDataCartons
        End With

        With grdDataPackingList
            .AutoGenerateColumns = False
            .DataSource = DtDataPackingList
        End With
    End Sub

    Private Sub BindDataText(ByVal DtDataCartons As DataTable, ByVal DtDataPackingList As DataTable)

        txtPackNo.Text = DtDataPackingList.Rows(0)("packno").ToString.Trim

        DtpPackDate.Value = CDate(DtDataPackingList.Rows(0)("packdt").ToString)
        txtReqNo.Text = (DtDataPackingList.Rows(0)("outreqno").ToString) 'Add By Neung Userr Need show It
        txtcustomer.Text = (DtDataPackingList.Rows(0)("custname").ToString)
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

    Private Sub SumCBM()
        With grdDataCartons
            If .Rows.Count > 0 Then
                Dim dblCBMCarton As Double = 0 'Sitthana 20220729
                Dim dblCBMRoll As Double = 0 'Sitthana 20220729

                For i As Integer = 0 To .Rows.Count - 1
                    dblCBMCarton += clsconfig.IsNull(.Rows(i).Cells("grdData_CBMForCarton").Value, 0)  'Sitthana 20220729
                    dblCBMRoll += clsconfig.IsNull(.Rows(i).Cells("grdData_CBMForRoll").Value, 0) 'Sitthana 20220729
                Next

                txtTotalCBMCarton.Text = Format(dblCBMCarton, "##0.000") 'Sitthana 20220729
                txtTotalCBMRoll.Text = Format(dblCBMRoll, "##0.000") 'Sitthana 20220729
            End If
        End With
    End Sub

    Function GetPackinglistDData(ByVal strPacking_no As String, StrCartno2 As String) As Boolean
        Dim dt As DataTable = clsPackingListD.GetPackinglistDDataDetail(strPacking_no, StrCartno2)
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
        txtPackNo.Text = dt.Rows(0)("packno").ToString.Trim

        DtpPackDate.Value = CDate(dt.Rows(0)("packdt").ToString)
        txtReqNo.Text = (dt.Rows(0)("outreqno").ToString) 'Add By Neung Userr Need show It
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

    Private Function Validate_Outno() As Boolean
        Dim dt As DataTable = clsPackingListD.ValidateOutNoByPackno(txtPackNo.Text.Trim, clsUserInfo.UserID)

        If dt.Rows.Count = 0 And txtPackNo.Text <> "" Then
            'If clsconfig.IsNull(txtOutNo.Text, "") = "" Then
            btngout.Enabled = True
            DtpOutdt.Enabled = True
        Else
            btngout.Enabled = False
            DtpOutdt.Enabled = False
        End If
    End Function


    'Dout Section
    Private Sub btngout_Click(sender As Object, e As EventArgs) Handles btngout.Click
        BFSavePLDOUT()
    End Sub

    Private Sub BFSavePLDOUT()
        If strPacking_no = "" Then strPacking_no = txtPackNo.Text.Trim.ToUpper
        If strPacking_no.Length = 0 Then Exit Sub
        If grdDataCartons.DataSource Is Nothing Then Exit Sub
        If grdDataCartons.Rows.Count = 0 Then Exit Sub 'grdDataCartons is empty  Sitthana 20220818
        If grdDataPackingList.DataSource Is Nothing Then Exit Sub
        If grdDataPackingList.Rows.Count = 0 Then Exit Sub

        'Sitthana 20220624 Changed Windows.Forms.DialogResult To DialogResult
        Dim result As DialogResult ' Windows.Forms.DialogResult
        result = MessageBox.Show("Would you like to save Dyed Out ?", "System Message", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button3)
        If result = DialogResult.Yes Then
            If SavePLDOUT() Then
                MessageBox.Show("Out No. : " & txtOutNo.Text & "Pack No. : " & txtPackNo.Text & "บันทึกสำเร็จ ! ", "System Message", MessageBoxButtons.OK, MessageBoxIcon.None, MessageBoxDefaultButton.Button1)
                LoaddataDout(PackinglistNo)
                Validate_Outno()
            End If
        End If
    End Sub

    Private Function SavePLDOUT() As Boolean
        Dim objdb As New classPackingListD
        Dim PLDHeader As New classPackingListD.PackingListDHeader
        Dim CartonsHeader As New classPackingListD.CartonsHeader
        Dim msgerr As String = ""

        Dim PLDNo As String = strPacking_no
        'Dim OUTNo As String = strOut_no
        Dim OUTREQNo As String = txtReqNo.Text
        Dim PACKDT As String = DtpPackDate.Value.ToString("yyyyMMdd")
        Dim OUTDT As String = DtpOutdt.Value.ToString("yyyyMMdd")
        Dim USERID As String = clsUserInfo.UserID
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
        PLDHeader.h46_empcd = clsUserInfo.UserID.Trim
        'PLDHeader.h19_outreqtyp = CboDoc_type.SelectedValue
        'blnCancel = False

        If objdb.pldsaveDOUT(PLDHeader, dv_dtc_add, dv_dtp_add, dv_dtc_upd, dv_dtp_upd, dv_dtc_del, dv_dtp_del, msgerr, PLDNo, OUTREQNo, PACKDT, _OutNo, OUTDT, USERID, CheckNEW, Doc_type, dtp2, dtc, CartonsHeader, _StockType) Then
            PackingListNo = PLDNo
            strOut_no = _OutNo
            Validate_Outno()
            SavePLDOUT = True
        Else
            SavePLDOUT = False
            MessageBox.Show(msgerr, "System Message", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
        End If
    End Function

    Private Sub LoaddataDout(ByVal PackinglistNo As String)
        Dim dtDataCartons As New DataTable
        Dim dtgrdDataPackingList As New DataTable
        dtDataCartons = clsPackingListD.GetPackinglistDDataCartons(PackinglistNo)
        dtgrdDataPackingList = clsPackingListD.GetPackinglistDDataDetail(PackinglistNo)

        Call BindDataGrd(dtDataCartons, dtgrdDataPackingList)
        Call BindDataText(dtDataCartons, dtgrdDataPackingList)

        Call SumGrdPackingList()
        'Call BindDataDout(dt)

        txtOutNo.Text = strOut_no
        Call GetPackinglistDData(strPacking_no, "")
        'CboDoc_type.SelectedValue = dt.Rows(0)("doctyp")
    End Sub


    'Print Label and report

    Private Sub btnPrintCartonLabel_Click(sender As Object, e As EventArgs) Handles btnPrintCartonLabel.Click
        If txtPackNo.Text.Trim = "" Then
            MessageBox.Show("You must create Pack No. before print carton label", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            Me.Cursor = Cursors.WaitCursor
            rptFileName = "rptPackingCartonLabelWidePrint.rpt"

            If clsUserInfo.ReportPath = "" Then clsUserInfo.ReportPath = clsUser.ReportPath
            If Not clsconfig.CheckReport(clsUserInfo.ReportPath, rptFileName) Then Exit Sub

            Dim frm As New frmReport
            Dim rpt As New CrystalDecisions.CrystalReports.Engine.ReportDocument

            rpt.Load(clsUserInfo.ReportPath & rptFileName)
            rpt.DataSourceConnections.Item(0).SetConnection(clsConn.servername, clsConn.database, False)
            rpt.DataSourceConnections.Item(0).SetLogon(clsConn.Userid, clsConn.Password)

            rpt.SetParameterValue("@p_packno", txtPackNo.Text.Trim)
            rpt.SetParameterValue("@p_cartno", 0)

            frm.Title = "PackingList D PrintCarton Label"
            frm.CRViewer.ReportSource = rpt
            frm.MdiParent = Me.ParentForm
            frm.Show()
        End If
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub btnPrintChantasiaLabel_Click(sender As Object, e As EventArgs) Handles btnPrintChantasiaLabel.Click
        If txtPackNo.Text.Trim = "" Then
            MessageBox.Show("You must create Pack No. before print carton label", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            rptFileName = "rptChantasiaBarcode.rpt"

            If clsUserInfo.ReportPath = "" Then clsUserInfo.ReportPath = clsUser.ReportPath
            If Not clsconfig.CheckReport(clsUserInfo.ReportPath, rptFileName) Then Exit Sub

            Dim frm As New frmReport
            Dim rpt As New CrystalDecisions.CrystalReports.Engine.ReportDocument

            Me.Cursor = Cursors.WaitCursor
            rpt.Load(clsUserInfo.ReportPath & rptFileName)
            rpt.DataSourceConnections.Item(0).SetConnection(clsConn.servername, clsConn.database, False)
            rpt.DataSourceConnections.Item(0).SetLogon(clsConn.Userid, clsConn.Password)
            rpt.VerifyDatabase()
            rpt.SetParameterValue("@p_packno", txtPackNo.Text.Trim)
            rpt.SetParameterValue("@p_cartno", 0)

            frm.Title = "PackingList D Print Chantasia Label"
            frm.CRViewer.ReportSource = rpt

            frm.MdiParent = Me.ParentForm
            frm.Show()
        End If

        Me.Cursor = Cursors.Default
    End Sub

    Private Sub BtnYarnPrintBar_Click(sender As Object, e As EventArgs) Handles BtnYarnPrintBar.Click
        If txtOutNo.Text.Trim = "" Then
            MessageBox.Show("You must create Out No. before print", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            rptFileName = "rptStockDBarcode.rpt"

            If clsUserInfo.ReportPath = "" Then clsUserInfo.ReportPath = clsUser.ReportPath
            If Not clsconfig.CheckReport(clsUserInfo.ReportPath, rptFileName) Then Exit Sub
            Dim frm As New frmReport
            Dim rpt As New CrystalDecisions.CrystalReports.Engine.ReportDocument
            Dim stype As String = ""
            Dim ord As String = ""
            Me.Cursor = Cursors.WaitCursor

            rpt.Load(clsUserInfo.ReportPath & rptFileName)
            rpt.DataSourceConnections.Item(0).SetConnection(clsConn.servername, clsConn.database, False)
            rpt.DataSourceConnections.Item(0).SetLogon(clsConn.Userid, clsConn.Password)

            rpt.SetParameterValue("@roll_no", txtOutNo.Text.Trim)
            rpt.SetParameterValue("@loc", "")
            rpt.SetParameterValue("@logempcd", clsUserInfo.UserID)

            frm.Title = "Dyed Barcode"
            frm.CRViewer.ReportSource = rpt
            frm.MdiParent = Me.ParentForm
            frm.Show()
        End If

        Me.Cursor = Cursors.Default
    End Sub

    Private Sub PLDDocumentToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PLDDocumentToolStripMenuItem.Click
        If txtPackNo.Text.Trim = "" Then
            MessageBox.Show("You must create Pack No. before print", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            rptFileName = "rptPLD.rpt"

            If clsUserInfo.ReportPath = "" Then clsUserInfo.ReportPath = clsUser.ReportPath
            If Not clsconfig.CheckReport(clsUserInfo.ReportPath, rptFileName) Then Exit Sub

            Dim frm As New frmReport
            Dim rpt As New CrystalDecisions.CrystalReports.Engine.ReportDocument

            Me.Cursor = Cursors.WaitCursor
            rpt.Load(clsUserInfo.ReportPath & rptFileName)
            rpt.DataSourceConnections.Item(0).SetConnection(clsConn.servername, clsConn.database, False)
            rpt.DataSourceConnections.Item(0).SetLogon(clsConn.Userid, clsConn.Password)

            rpt.SetParameterValue("@packno", strPacking_no)
            rpt.SetParameterValue("@cartno", "")

            frm.Title = "PackingList D"
            frm.CRViewer.ReportSource = rpt
            frm.MdiParent = Me.ParentForm
            frm.Show()
        End If

        Me.Cursor = Cursors.Default
    End Sub

    Private Sub DOUTDocumentToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DOUTDocumentToolStripMenuItem.Click
        If txtOutNo.Text.Trim = "" Then
            MessageBox.Show("You must create Out No. before print", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            rptFileName = "rptDOUT.rpt"

            If clsUserInfo.ReportPath = "" Then clsUserInfo.ReportPath = clsUser.ReportPath
            If Not clsconfig.CheckReport(clsUserInfo.ReportPath, rptFileName) Then Exit Sub
            Dim frm As New frmReport
            Dim rpt As New CrystalDecisions.CrystalReports.Engine.ReportDocument
            Me.Cursor = Cursors.WaitCursor
            rpt.Load(clsUserInfo.ReportPath & rptFileName)
            rpt.DataSourceConnections.Item(0).SetConnection(clsConn.servername, clsConn.database, False)
            rpt.DataSourceConnections.Item(0).SetLogon(clsConn.Userid, clsConn.Password)

            rpt.SetParameterValue("@outno", txtOutNo.Text.Trim)

            frm.Title = "Dyed Out"
            frm.CRViewer.ReportSource = rpt
            frm.MdiParent = Me.ParentForm
            frm.Show()
        End If

        Me.Cursor = Cursors.Default
    End Sub

    '----- Tag Label
    Private Sub tsmnDINTagStandard_Click(sender As Object, e As EventArgs) Handles tsmnDINTagStandard.Click
        Dim rptFileName As String = "rptStockDBarcode.rpt"
        Dim TitleName As String = "Tag Of Standard Format"
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
        If clsUserInfo.ReportPath = "" Then clsUserInfo.ReportPath = clsUser.ReportPath

        If Not clsconfig.CheckReport(clsUserInfo.ReportPath, pRptFileName) Then Exit Sub
        Dim frm As New frmReport
        Dim rpt As New CrystalDecisions.CrystalReports.Engine.ReportDocument
        Dim stype As String = ""
        Dim ord As String = ""
        Me.Cursor = Cursors.WaitCursor

        rpt.Load(clsUserInfo.ReportPath & pRptFileName)
        rpt.DataSourceConnections.Item(0).SetConnection(clsConn.servername, clsConn.database, False)
        rpt.DataSourceConnections.Item(0).SetLogon(clsConn.Userid, clsConn.Password)

        rpt.SetParameterValue("@roll_no", txtOutNo.Text.Trim)
        rpt.SetParameterValue("@loc", "")
        rpt.SetParameterValue("@logempcd", clsUserInfo.UserID)

        frm.Title = pTitle
        frm.CRViewer.ReportSource = rpt
        frm.MdiParent = Me.ParentForm
        frm.Show()
        Me.Cursor = Cursors.Default
    End Sub


End Class
