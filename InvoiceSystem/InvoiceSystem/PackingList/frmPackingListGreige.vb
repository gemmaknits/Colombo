Imports System.Drawing
Imports System.Data.SqlClient
Imports System.Data
Imports System.Math

Public Class frmPackingListGreige

    Dim clsconfig As New clsConfig
    Dim clsConn As New classConnection
    Dim clsuser As New classUserInfo
    Dim dbPackingListG As New classPackingListG
    Dim strreqno As String = ""
    Dim blnCancel As Boolean = False
    Dim strPacking_no As String = ""
    Dim strPackingNo As String = ""
    Dim strOut_no As String = ""
    Dim strCartno As String = ""
    Dim dtPackinglistG As New DataSet
    Dim PackinglistNo As String = ""

    Private Const PresslessCustCd As String = "967" 'Pressless GmbH 'Sitthana 20190509
    Private Custcd As String = "" 'Sitthana 20190509

    Public Property Userinfo() As classUserInfo
        Get
            Userinfo = clsuser
        End Get
        Set(ByVal newvalue As classUserInfo)
            clsuser = newvalue
        End Set
    End Property

    Private Sub txtReqNo_GotFocus(sender As Object, e As System.EventArgs) Handles txtDocNo.GotFocus
        If txtDocNo.Text <> "" Then
            txtDocNo.Text = ""
        End If
        lblCancelled.Visible = False
    End Sub


    Private Sub txtReqNo_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles txtDocNo.KeyDown
        If e.KeyCode.Equals(Keys.Enter) Then
            If optReqNo.Checked Then
                GetREQG(txtDocNo.Text)
            ElseIf optGinNo.Checked Then
                GetGINBalance(txtDocNo.Text)
            End If
        End If

       
    End Sub

    Public Function GetGINBalance(ByRef StrDINNO As String) As Boolean

        Dim dt As DataTable = dbPackingListG.GetBalanceGIN(StrDINNO)
        If dt.Rows.Count > 0 Then
            Call BindData(dt)
            txtDocNo.Text = dt.Rows(0)("tran_no").ToString()
            CboDoc_type.SelectedValue = dt.Rows(0)("outreqtyp").ToString()
            Custcd = dt.Rows(0)("custcd") 'Sitthana 20190509
            txtcustomer.Text = dt.Rows(0)("custname").ToString()

            Return True
        End If

        Return False

    End Function


    Private Sub txtPackNo_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles txtPackNo.KeyDown
        If e.KeyCode.Equals(Keys.Enter) Then

            If Trim(txtPackNo.Text.Trim) = "" Then
                Exit Sub
            End If

            If GetPackinglistGData(txtPackNo.Text, "") Then
                'GetCartonsData(txtPackNo.Text)
                'strPacking_no = txtPackNo.Text
                'Dim strcartno2 As String = ""
                'GetPackinglistGData(strPacking_no, strcartno2)
            End If
            If GetCartonsData(txtPackNo.Text) Then

            End If

        End If
    End Sub

    Private Function GetREQG(ByVal StrReqno As String) As Boolean
        If Not Validate_ReqNoIsCancel(StrReqno) Then
            MessageBox.Show("Req. No : " & StrReqno & "............   Req No. is Already Cancel!!")
            Exit Function

        End If
        If Not Validate_ReqNoIsPack(StrReqno) Then
            MessageBox.Show("Req. No : " & StrReqno & "............   is Already Used!! For " & strPackingNo)
            Exit Function

        End If


        Dim dt As DataTable = dbPackingListG.GetREQG(StrReqno)
        If dt.Rows.Count > 0 Then
            Call BindDataREQG(dt)
            txtDocNo.Text = dt.Rows(0)("outreqno").ToString()

            'CboCartonsNo.DataSource = dt
            ' CboCartonsNo.DisplayMember = "custcd"
            ' CboCartonsNo.DisplayMember = "custname"
            Custcd = dt.Rows(0)("custcd") 'Sitthana 20190509
            txtcustomer.Text = dt.Rows(0)("custname").ToString()
            CboDoc_type.SelectedValue = dt.Rows(0)("outreqtyp").ToString()
            Return True
        End If
        Return False
    End Function
    Private Function Validate_ReqNoIsCancel(ReqNo) As Boolean
        Dim objDB As New classPackingListG
        Dim dt As DataTable = objDB.ValidateReqNoisCancel(ReqNo, clsuser.UserID)

        If dt.Rows.Count = 0 Then
            Return False
        End If
        Return True
    End Function
    Private Function Validate_ReqNoIsPack(ReqNo) As Boolean
        Dim objDB As New classPackingListG
        Dim dt As DataTable = objDB.ValidateReqNoIsPack(ReqNo, clsuser.UserID)

        If dt.Rows.Count > 0 Then
            strPackingNo = (dt.Rows(0)("packno").ToString)
            Return False
        End If
        Return True
    End Function

    Private Function Validate_Outno() As Boolean
        Dim objDB As New classPackingListG
        Dim dt As DataTable = objDB.ValidateOutNoByPackno(txtPackNo.Text.Trim, clsuser.UserID)

        If dt.Rows.Count > 0 Then
            btngout.Enabled = False
        Else
            btngout.Enabled = True
        End If

    End Function

    Private Sub BindDataREQG(ByVal dt As DataTable)
        Dim config As New clsConfig
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
                'If (dt1.Rows(i)("sel").ToString) = True Then
                dr = dt2.NewRow



                For j = 0 To dt2.Columns.Count - 1
                    '(dt.Rows(0)("packdt").ToString)
                    dr("cartno") = dt1.Rows(i)("cartno")
                    dr("roll_no_g") = dt1.Rows(i)("roll_no_g")
                    dr("roll_no_o") = dt1.Rows(i)("roll_no_o")
                    dr("grade") = dt1.Rows(i)("grade")
                    dr("design_no") = dt1.Rows(i)("design_no")
                    'Format$(dblTestNumber, "##,##0.00")
                    'String.Format("{0:#,###0.00}", sumGrossAmt)
                    dr("outkg_g") = dt1.Rows(i)("outkg_g")
                    dr("outyd_g") = dt1.Rows(i)("outyd_g")
                    dr("outmt_g") = dt1.Rows(i)("outmt_g")
                    dr("sono") = dt1.Rows(i)("sono")
                    dr("sonoid") = dt1.Rows(i)("sonoid")
                    dr("Gwth") = dt1.Rows(i)("Gwth")
                    dr("outreqno") = dt1.Rows(i)("outreqno")
                    dr("outreqdt") = dt1.Rows(i)("outreqdt")
                    dr("outreqtyp") = dt1.Rows(i)("outreqtyp")
                    dr("pono") = dt1.Rows(i)("pono")
                    dr("preseted") = dt1.Rows(i)("preseted")
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
    Private Sub AddRollNoPackingList()
        'grdDataPackingList.AutoGenerateColumns = False
        'If grdReqG.Rows.Count > 0 Then
        '    Dim config As New clsConfig

        '    Dim dt As DataTable = grdReqG.DataSource
        '    Dim dt2 As DataTable = grdDataPackingList.DataSource
        '    Dim dr As DataRow
        '    Dim msg As String = ""
        '    Dim i As Integer = 0
        '    Dim j As Integer = 0

        '    For i = 0 To dt.Rows.Count - 1
        '        ' If (dt.Rows(i)("grdReqG_sel").ToString) = "" Then
        '        'If (dt.Rows(i)("grdReqG_sel")) = True Then
        '        If (grdReqG.Rows(i).Cells("grdReqG_sel").Value) = True Then
        '            If Not CheckDuplicate(dt.Rows(i)("roll_no_g").ToString.Trim, dt2.Copy()) Then
        '                dr = dt2.NewRow
        '                For j = 0 To dt2.Columns.Count - 1

        '                    dr(dt2.Columns(j).ColumnName.Trim) = dt.Rows(i)(dt2.Columns(j).ColumnName.Trim)
        '                Next
        '                dt2.Rows.Add(dr)

        '            Else
        '                MessageBox.Show("Roll No. " & dt.Rows(i)("roll_no_g").ToString.Trim & " Design no " & dt.Rows(i)("Design_no").ToString.Trim & " is duplicated in right grid." & vbCrLf _
        '                & "If you want to add same Roll No., Please change color by change S/O No. ID in Grid Above." & vbCrLf _
        '                & "เลขม้วน " & dt.Rows(i)("roll_no_g").ToString.Trim & " สี " & dt.Rows(i)("Design_no").ToString.Trim & " ซ้ำกับที่เลือกไว้แล้วด้านขวา" & vbCrLf _
        '                , "System Message", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1)
        '            End If
        '        End If
        '    Next
        'End If
        'Call SumGrdPackingList()
    End Sub
    Function GetCartonsData(ByVal StrPackno As String) As Boolean
        Dim dt As DataTable = dbPackingListG.GetPackinglistGDataCartons(StrPackno)
        'If dt.Rows.Count > 0 Then

        Call BindCartonsData(dt)
        Return True

        'End If
        'Return False

    End Function
    Function GetPackinglistGData(ByVal strPacking_no As String, StrCartno2 As String) As Boolean
        Dim dt As DataTable = dbPackingListG.GetPackinglistGDataDetail(strPacking_no, StrCartno2)
        If dt.Rows.Count > 0 Then
            Call BindPackinglistGData(dt)
            Return True
        End If
        Return False

    End Function
    Private Sub BindPackinglistGData(ByVal dt As DataTable)
        Dim i As Integer = 0
        Dim j As Integer = 0

        grdDataPackingList.AutoGenerateColumns = False
        grdDataPackingList.DataSource = dt
        CboDoc_type.SelectedValue = (dt.Rows(0)("outreqtyp").ToString)
        'DtpPackDate.Value = (dt.Rows(0)("packdt"))
        DtpPackDate.Value = CDate(dt.Rows(0)("packdt").ToString)
        Custcd = dt.Rows(0)("custcd") 'Sitthana 20190509
        txtcustomer.Text = (dt.Rows(0)("custname").ToString)
        If grdDataCartons.Rows.Count > 0 Then
            CboCartonsNo.DataSource = grdDataCartons.DataSource
            CboCartonsNo.DisplayMember = "cartno"
            CboCartonsNo.ValueMember = "cartno"

        End If


        SumGrdPackingList()
        btngout.Enabled = True
        DtpOutdt.Enabled = True
        txtOutNo.Text = ""
        Validate_Outno()

        If dt.Rows(0)("outno").ToString.Trim.Length > 0 Then
            txtOutNo.Text = dt.Rows(0)("outno").ToString.Trim()
            DtpOutdt.Value = CDate(dt.Rows(0)("outdt").ToString)
            btngout.Enabled = False
            DtpOutdt.Enabled = False
        End If



    End Sub

    Private Sub BindCartonsData(ByVal dt As DataTable)
        If txtPackNo.Text = "" Then Exit Sub
        Dim i As Integer = 0
        Dim j As Integer = 0
        grdDataCartons.AutoGenerateColumns = False
        grdDataCartons.DataSource = dt
        If dt.Rows.Count > 0 Then
            txtPackNo.Text = dt.Rows(0)("packno").ToString()
        End If
        CboCartonsNo.DataSource = grdDataCartons.DataSource
        CboCartonsNo.DisplayMember = "cartno"
        CboCartonsNo.ValueMember = "cartno"
        ' End If
    End Sub
    Private Function CheckgrdDataCartons() As Boolean
        'If grdReqG.DataSource Is Nothing Then Return False
        'If grdReqG.RowCount = 0 Then Return False
        'Dim i As Integer = 0
        'For i = 0 To grdReqG.RowCount - 1
        '    If (grdReqG.Rows(i).Cells("grdReqG_sel").Value) = True Then Return True
        '    'If CBool(grdReqG.Rows(i).Cells("grdReqG_sel").Value) Then Return True
        'Next
        'Return False
    End Function

    Private Sub btnAdd_Click(sender As System.Object, e As System.EventArgs)
        If Not CheckgrdReqG() Then Exit Sub
        If MessageBox.Show("Would you like to select roll no From Request G to Packing List G ?" & vbCrLf & "คุณต้องการเพิ่มผ้าดิบที่จองผ้าไว้ใช่หรือไม่?", "System Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = DialogResult.No Then Exit Sub


        Call AddRollNoPackingList()
    End Sub

    Private Function CheckDuplicate(ByVal strRollNo As String, ByVal dt2 As DataTable) As Boolean
        If dt2.Rows.Count > 0 Then
            Dim i As Integer = 0
            For i = 0 To dt2.Rows.Count - 1
                If dt2.Rows(i).RowState <> DataRowState.Deleted Then
                    If dt2.Rows(i)("roll_no_g").ToString.Trim = strRollNo Then Return True
                End If
            Next
        End If
        Return False
    End Function
    Private Sub GennarateCartons()

        'Dim dt1 As DataTable = grdDataPackingList.DataSource
        'Dim dt2 As DataTable = grdDataCartons.DataSource

        'For Each dr As DataRow In dtc.Rows
        '    If Not dr("dono").ToString().Trim.Equals(txtBillNo.Text.Trim) Then
        '        dr.Item("dono") = txtBillNo.Text.Trim
        '    End If
        'Next


        grdDataCartons.AutoGenerateColumns = False

        Dim dtDataPackingList As DataTable = grdDataPackingList.DataSource
        Dim dtDataCartons As DataTable = grdDataCartons.DataSource
        If dtDataPackingList.Rows.Count > 0 Then

            Dim dr As DataRow
            Dim msg As String = ""
            Dim i As Integer = 0
            Dim j As Integer = 0
            Dim CartonsNew As Boolean = False

            For i = 0 To dtDataPackingList.Rows.Count - 1
                CartonsNew = False
                If dtDataCartons.Rows.Count = 0 Then
                    dr = dtDataCartons.NewRow
                    dr("cartno") = dtDataPackingList.Rows(i)("cartno")

                    dtDataCartons.Rows.Add(dr)
                ElseIf dtDataCartons.Rows.Count > 0 Then
                    For Each drcartons As DataRow In dtDataCartons.Rows
                        'CartonsNew = True
                        If Not drcartons("cartno").ToString().Trim.Equals(dtDataPackingList.Rows(j)("cartno").ToString.Trim) Then
                            CartonsNew = True
                            'dr = dtDataCartons.NewRow
                           
                        End If


                    Next
                End If

                If CartonsNew Then
                    dr = dtDataCartons.NewRow
                    dr("cartno") = dtDataPackingList.Rows(i)("cartno")
                    dtDataCartons.Rows.Add(dr)
                End If

            Next

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

        'Call GennarateCartons()
        

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
                'Dim dgvccSubInven As New DataGridViewComboBoxCell
                'dgvccSubInven = grdDataCartons.Rows(j).Cells("rcv_subinventory_id")
                'grdDataCartons.Columns("grdDataCartons_netwt").DefaultCellStyle.Format = "N2"
                'Format(dgvccSubInven) = "N2"
                grdDataCartons.Rows(j).Cells("grdDataCartons_netwt").Value = netwt 'FormatNumber(netwt, 2, TriState.False, TriState.False, TriState.True)
                netwt = 0
                grdDataCartons.Rows(j).Cells("CartMts").Value = CartMts 'FormatNumber(CartMts, 2, TriState.False, TriState.False, TriState.True)
                CartMts = 0
                grdDataCartons.Rows(j).Cells("CartYds").Value = CartYds 'FormatNumber(CartYds, 2, TriState.False, TriState.False, TriState.True)
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

    

    Private Sub SumGrdPackingList2()
        Dim config As New clsConfig
        Dim i As Integer = 0
        Dim j As Integer = 0
        Dim dblKgs As Double = 0
        Dim dblMts As Double = 0
        Dim dblYds As Double = 0

        Dim netwt As Double = 0
        Dim CartMts As Double = 0
        Dim CartYds As Double = 0
        Dim totalroll As Double = 0
        'grdDataCartons.Rows(j).Cells("grdDataCartons_netwt").Value = 0

        If grdDataCartons.Rows(j).Cells("grdDataCartons_cartno").Value = grdDataPackingList.Rows(i).Cells("grdDataPackingList_cartno").Value Then
            grdDataCartons.Rows(j).Cells("grdDataCartons_netwt").Value = config.IsNull(grdDataPackingList.Rows(j).Cells("grdDataPackingList_outkg_g").Value, 0)
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

    Private Function CheckgrdReqG() As Boolean
        'If grdReqG.DataSource Is Nothing Then Return False
        'If grdReqG.RowCount = 0 Then Return False
        'Dim i As Integer = 0
        'For i = 0 To grdReqG.RowCount - 1
        '    If (grdReqG.Rows(i).Cells("grdReqG_sel").Value) = True Then Return True
        '    'If CBool(grdReqG.Rows(i).Cells("grdReqG_sel").Value) Then Return True
        'Next
        'Return False
    End Function
    Private Function CheckgrdFreeStockD() As Boolean
        'If grdReqG.DataSource Is Nothing Then Return False
        'If grdReqG.RowCount = 0 Then Return False
        'Dim i As Integer = 0
        'For i = 0 To grdReqG.RowCount - 1
        '    If (grdReqG.Rows(i).Cells("grdReqG_sel").Value) = "" Then Return True

        '    'If CBool(grdReqG.Rows(i).Cells("grdReqG_sel").Value) = True Then Return True
        'Next
        'Return False
    End Function

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs)
        ' grdReqG.SelectAll()
    End Sub

    Private Sub frmPackingListGreigeOut_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load


        Call InitControl()

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
    Private Sub grdReqG_CellContentClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs)


        'If grdReqG.CurrentCell.IsInEditMode Then grdReqG.EndEdit()
    End Sub

   
    'Private Sub grdReqG_CellEndEdit(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs)
    '    If grdReqG.Columns(e.ColumnIndex).Name = "sel" Then Call SumGrdPackingList()
    'End Sub

   

    Private Sub cboPackNo_Click(sender As System.Object, e As System.EventArgs)

    End Sub

    'Private Sub cboPackNo_DropDownClosed(sender As Object, e As System.EventArgs)
    '    If cboPackNo.ComboBox.SelectedValue = "" Then Exit Sub
    '    strPacking_no = clsconfig.IsNull(cboPackNo.ComboBox.SelectedValue, "")
    '    If strPacking_no.Trim.Length > 0 Then
    '        Call btnNew_Click(sender, e)
    '        If Not blnCancel Then Loaddata(strPacking_no)

    '        ' If strPacking_no <> "" Then Call grdDataCartons_CellClick(sender, e)
    '    End If
    '    'grdDataCartons_CellClick(1, e)
    'End Sub


    'Private Sub CboCartonsNo_DropDownClosed(sender As Object, e As System.EventArgs)
    '    strCartno = CboCartonsNo.SelectedValue
    '    If strPacking_no.Trim.Length > 0 Then
    '        Call btnNew_Click(sender, e)
    '        If Not blnCancel Then LoaddataCartno(strCartno)


    '    End If

    'End Sub
    Private Sub LoaddataCartno(ByVal strCartno As String)
        Dim objdb As New classPackingListG
        Dim dt As New DataTable
        dt = objdb.GetPackinglistGDataDetail(strCartno)
        Call bindgrdDataPackingList(dt)
        Call SumGrdPackingList()
    End Sub
    'Private Sub Loaddata(ByVal PackinglistNo As String)
    '    Dim objdb As New classPackingListG
    '    Dim dt As New DataTable
    '    GetgrdDataPackingList(PackinglistNo, "")
    '    GetgrdDataCartons(PackinglistNo)

    '    'Call bindgrdDataPackingList(dt)
    '    Call SumGrdPackingList()

    '    Call BindData(PackinglistNo)


    'End Sub
    Private Sub LoaddataGout(ByVal PackinglistNo As String)
        Dim objdb As New classPackingListG
        Dim dt As New DataTable
        dt = objdb.GetPackinglistGDataCartons(PackinglistNo)

        Call bindgrdDataPackingList(dt)
        Call SumGrdPackingList()
        'Call BindDataGout(dt)
        Call GetPackinglistGData(strPacking_no, "")
        txtOutNo.Text = strOut_no
    End Sub

    Private Sub BindData(ByVal dt As DataTable)
        Dim config As New clsConfig
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
                'If (dt1.Rows(i)("sel").ToString) = True Then
                dr = dt2.NewRow



                For j = 0 To dt2.Columns.Count - 1
                    '(dt.Rows(0)("packdt").ToString)
                    dr("cartno") = dt1.Rows(i)("cartno")
                    dr("roll_no_g") = dt1.Rows(i)("roll_no_g")
                    dr("roll_no_o") = dt1.Rows(i)("roll_no_o")
                    dr("grade") = dt1.Rows(i)("grade")
                    dr("design_no") = dt1.Rows(i)("design_no")
                    'Format$(dblTestNumber, "##,##0.00")
                    'String.Format("{0:#,###0.00}", sumGrossAmt)
                    dr("outkg_g") = dt1.Rows(i)("outkg_g")
                    dr("outyd_g") = dt1.Rows(i)("outyd_g")
                    dr("outmt_g") = dt1.Rows(i)("outmt_g")
                    dr("sono") = dt1.Rows(i)("sono")
                    dr("sonoid") = dt1.Rows(i)("sonoid")
                    dr("Gwth") = dt1.Rows(i)("Gwth")
                    dr("outreqno") = dt1.Rows(i)("outreqno")
                    dr("outreqdt") = dt1.Rows(i)("outreqdt")
                    dr("outreqtyp") = dt1.Rows(i)("outreqtyp")
                    dr("pono") = dt1.Rows(i)("pono")
                    dr("preseted") = dt1.Rows(i)("preseted")
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
    Private Sub BindDataGout(ByVal dt As DataTable)
        txtOutNo.Text = dt.Rows(0)("gout")
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
        ClearCboDoc_type()
        'ClearcboCustomer()
        txtPackNo.Text = "NEW"
        txtcustomer.Text = ""
        btngout.Enabled = False
        DtpOutdt.Enabled = False
        lblCancelled.Visible = False
        'Call GenComboCustomer()
        Dim strreqno As String = ""
        Dim blnCancel As Boolean = False
        Dim strPacking_no As String = ""
        Dim strCartno As String = ""

        optReqNo.Checked = True

        txtDocNo.Focus()

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
    Private Sub GetgrdDataPackingList(ByRef StrPackno As String, ByRef StrCartno As String)
        Dim objdb As New classPackingListG
        grdDataPackingList.AutoGenerateColumns = False
        grdDataPackingList.DataSource = objdb.GetPackinglistGDataDetail(StrPackno, StrCartno)

    End Sub
    Private Sub GetgrdDataCartons(ByRef StrPackno As String)
        Dim objdb As New classPackingListG
        grdDataCartons.AutoGenerateColumns = False
        grdDataCartons.DataSource = objdb.GetPackinglistGDataCartons(StrPackno)
    End Sub
    Private Sub CleargrdDataPackingList()
        Dim objdb As New classPackingListG
        grdDataPackingList.AutoGenerateColumns = False
        grdDataPackingList.DataSource = objdb.GetPackinglistGDataDetail("0", "0")

    End Sub
    Private Sub CleargrdDataCartons()
        Dim objdb As New classPackingListG
        grdDataCartons.AutoGenerateColumns = False
        grdDataCartons.DataSource = objdb.GetPackinglistGDataCartons("")
    End Sub
    Private Sub ClearCboCartonsNo()
        Dim objdb As New classPackingListG
        grdDataCartons.AutoGenerateColumns = False
        'CboCartonsNo.DataSource = objdb.GetPackinglistGDataCartons("")
        CboCartonsNo.DataSource = grdDataCartons.DataSource
        CboCartonsNo.DisplayMember = "cartno"
        CboCartonsNo.ValueMember = "cartno"
        CboCartonsNo.Text = ""
    End Sub
    Private Sub ClearCboDoc_type()
        Dim objDB As New classMaster
        'Dim objREQ As New classPackingListG
        CboDoc_type.DataSource = objDB.GetDocType
        CboDoc_type.DisplayMember = "name"
        CboDoc_type.ValueMember = "doctyp"
        CboDoc_type.Text = ""
    End Sub
    'Private Sub GencboPackNo(Optional ByVal stock_type As String = "G")
    '    Me.Cursor = Cursors.WaitCursor
    '    Dim objDB As New classPackingListG
    '    Me.cboPackNo.ComboBox.DataSource = objDB.GetPackinglistG
    '    Me.cboPackNo.ComboBox.DisplayMember = "packno"
    '    Me.cboPackNo.ComboBox.ValueMember = "packno"
    '    Me.Cursor = Cursors.Default

    'End Sub

    Private Sub btnNew_Click(sender As System.Object, e As System.EventArgs) Handles btnNew.Click
        If Not blnCancel Then Call InitControl()
    End Sub

    Private Sub bindgrdDataPackingList(ByVal dt As DataTable)
        grdDataCartons.AutoGenerateColumns = False
        grdDataCartons.DataSource = dt
    End Sub


    Private Sub CboCartonsNo_DropDownClosed(sender As Object, e As System.EventArgs) Handles CboCartonsNo.DropDownClosed
        If grdDataCartons.DataSource Is Nothing Then Exit Sub
        If grdDataCartons.Rows.Count = 0 Then Exit Sub

        Dim config As New clsConfig
        Dim objDB As New classPackingListG
        Dim dt As New DataTable
        Dim strCartno2 As String
        grdDataPackingList.AutoGenerateColumns = False
        strPacking_no = txtPackNo.Text
        strCartno2 = CboCartonsNo.SelectedValue
        If strCartno2 Is Nothing Then Exit Sub

        'If grdDataCartons.Rows.Count > 0 Then
        '    dt = objDB.GetPackinglistGDataDetail(strPacking_no, strCartno2)
        '    grdDataPackingList.DataSource = dt
        '    dt = objDB.GetPackinglistGDataCartons(strPacking_no)
        '    grdDataCartons.DataSource = dt
        'End If


        SumGrdPackingList()

    End Sub

    Private Sub grdDataCartons_CellClick(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles grdDataCartons.CellClick
        SumGrdPackingList()
    End Sub


    Private Sub btnSearchPackno_Click(sender As System.Object, e As System.EventArgs) Handles btnSearchPackno.Click
        Dim frm As New frmSearchPackingListG
        frm.ShowDialog(Me)
        txtPackNo.Text = (frm.pPackno)
        'Call btnNew_Click(sender, e)
        Me.Cursor = Cursors.WaitCursor
        If Trim(txtPackNo.Text.Trim) = "" Then
            Exit Sub
        End If

        If Not blnCancel Then
            If GetPackinglistGData(txtPackNo.Text, "") Then

            End If
            If GetCartonsData(txtPackNo.Text) Then

            End If
        End If
        Me.Cursor = Cursors.Default
        frm.Dispose()
    End Sub

    Private Sub btnSearchREQG_Click(sender As System.Object, e As System.EventArgs) Handles btnSearchREQG.Click
        ChkoptSearch
    End Sub

    Private Sub ChkoptSearch()

        If optReqNo.Checked = True Then
            Dim frm As New frmSearchREQG
            frm.pStockType = "G"
            frm.ShowDialog(Me)
            txtDocNo.Text = (frm.pReqNo)
            Me.Cursor = Cursors.WaitCursor
            If Not blnCancel Then GetREQG(txtDocNo.Text)
            Me.Cursor = Cursors.Default
            frm.Dispose()
        ElseIf optGinNo.Checked = True Then
            Dim frm As New frmSearchGIN
            frm.pStockType = "G"
            frm.pOutReqTyp = ""
            frm.ShowDialog(Me)
            txtDocNo.Text = (frm.pTranNo)
            Me.Cursor = Cursors.WaitCursor
            If Not blnCancel Then GetGINBalance(txtDocNo.Text)
            Me.Cursor = Cursors.Default
            frm.Dispose()
        End If
    End Sub


    Private Sub grdDataPackingList_CellEndEdit(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles grdDataPackingList.CellEndEdit
        'If chkAutoGenCarntonNo.Checked Then
        If grdDataPackingList.Columns(e.ColumnIndex).Name = "grdDataPackingList_cartno" Then
            Call AutoBindDataCARTONS(grdDataPackingList.DataSource)
        End If
        'End If
        Call SumGrdPackingList()
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

    Private Sub AutoBindDataCARTONS(ByVal dt As DataTable)
        Dim config As New clsConfig
        If txtDocNo.Text = "" Then Exit Sub

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

                    If dr2("cartno").Equals(grdDataPackingList.CurrentRow.Cells("grdDataPackingList_cartno").Value) Then
                        checkDupicateRoll = True
                    End If

                Next
            End If
            If Not checkDupicateRoll Then
                dt2.Rows.Add(dr1)
            End If

        End If


    End Sub

    Private Sub BtnCancel_Click(sender As System.Object, e As System.EventArgs) Handles BtnCancel.Click
        CancelPackinglistG()
    End Sub
    Private Sub CancelPackinglistG()
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


        If CancelPLG() Then
            Call InitControl()
            lblCancelled.Visible = True
        End If

    End Sub
    Private Sub BtnSave_Click(sender As System.Object, e As System.EventArgs) Handles BtnSave.Click
        If Not grdDataCartons.EndEdit Then Exit Sub
        If Not grdDataPackingList.EndEdit Then Exit Sub

        '--------------------------------------Fix Bug User-----------------------------------------
        If grdDataPackingList.Rows.Count > 0 Then
            grdDataPackingList.CurrentCell = grdDataPackingList.Rows(0).Cells(0)
        End If

        If grdDataCartons.Rows.Count > 0 Then
            grdDataCartons.CurrentCell = grdDataCartons.Rows(0).Cells(0)
        End If
        '---------------------------------------Fix Bug User-----------------------------------------

        'Fix Bug User
        txtPackNo.Focus()
        'Fix Bug User
        If Not CheckData() Then Exit Sub

        SavePackinglistG()
    End Sub
    Private Function CheckData() As Boolean
        Dim i As Integer


        If grdDataCartons.DataSource Is Nothing Then
            Return False
            Exit Function
        End If

        If grdDataCartons.Rows.Count = 0 Then
            Return False
            Exit Function
        End If
        If grdDataPackingList.DataSource Is Nothing Then
            Return False
            Exit Function
        End If
        If grdDataPackingList.Rows.Count = 0 Then
            Return False
            Exit Function
        End If

        If grdDataCartons.Rows.Count = 0 Then
            Return False
            MessageBox.Show("ไม่มีข้อมูล Cartons" & vbCrLf & "Please Check it.", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Exit Function
        End If

        If grdDataPackingList.Rows.Count = 0 Then
            Return False
            MessageBox.Show("ไม่มีข้อมูล ม้วน" & vbCrLf & "Please Check it.", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Exit Function
        End If


        For i = 0 To grdDataCartons.Rows.Count - 2
            If grdDataCartons.Rows(i).Cells("grdDataCartons_cartno").Value = 0 Then
                Return False
                MessageBox.Show("Cartno. is not Zero." & vbCrLf & "Please Check it.", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
                Exit Function
            End If

        Next
        For i = 0 To grdDataPackingList.Rows.Count - 1
            If grdDataPackingList.Rows(i).Cells("grdDataPackingList_cartno").Value = 0 Then
                Return False
                MessageBox.Show("Cartno. is not Zero." & vbCrLf & "Please Check it.", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
                Exit Function
            End If

        Next

        Return True
    End Function
    Private Sub SavePackinglistG()
        strPacking_no = txtPackNo.Text.Trim
        'If lblCancelled.Enabled = True Then lblCancelled.Enabled = False And strPacking_no = "NEW"
        If strPacking_no = "" Then strPacking_no = txtPackNo.Text.Trim.ToUpper
        If strOut_no = "" Then strOut_no = txtOutNo.Text.Trim.ToUpper
        

        If SavePLG() Then
            MessageBox.Show("Pack No. : " & PackinglistNo & "บันทึกสำเร็จ ! ", "System Message", MessageBoxButtons.OK, MessageBoxIcon.None, MessageBoxDefaultButton.Button1)
            GetCartonsData(PackinglistNo)
            GetPackinglistGData(PackinglistNo, "")
            Validate_Outno()
            If txtOutNo.Text.Trim.Length = 0 Then Call SaveGOUTBF() '

        End If



    End Sub
    Private Sub SaveGOUTBF()
        If strPacking_no = "" Then strPacking_no = txtPackNo.Text.Trim.ToUpper
        If strPacking_no.Length = 0 Then Exit Sub
        If grdDataCartons.DataSource Is Nothing Then Exit Sub
        If grdDataCartons.Rows.Count = 0 Then Exit Sub
        If grdDataPackingList.DataSource Is Nothing Then Exit Sub
        If grdDataPackingList.Rows.Count = 0 Then Exit Sub


        blnCancel = False
        Dim result As DialogResult
        result = MessageBox.Show("Would you like to save Greige Out ?", "System Message", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button3)
        If result = DialogResult.Cancel Then blnCancel = True
        If result <> DialogResult.Yes Then Exit Sub

        If SaveGOUT() Then
            MessageBox.Show("Out No. : " & txtOutNo.Text.Trim & "บันทึกสำเร็จ ! ", "System Message", MessageBoxButtons.OK, MessageBoxIcon.None, MessageBoxDefaultButton.Button1)
            GetCartonsData(txtPackNo.Text.Trim)
            GetPackinglistGData(txtPackNo.Text.Trim, "")
            Validate_Outno()
        End If



    End Sub
    Private Function CancelPLG() As Boolean
        Dim confid As New clsConfig
        Dim obidb As New classPackingListG
        Dim PLGHeader As New classPackingListG.PackingListGHeader
        Dim msgerr As String = ""

        Dim PLGNo As String = strPacking_no
        Dim OUTNo As String = strOut_no
        Dim OUTDT As String = DtpOutdt.Value.ToString("yyyyMMdd")
        Dim OUTREQNo As String = txtDocNo.Text
        Dim USERID As String = clsuser.UserID
        Dim CheckNEW As String = txtPackNo.Text.Trim

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

        If obidb.plgcancel(PLGHeader, dv_dtc_add, dv_dtp_add, dv_dtc_upd, dv_dtp_upd, dv_dtc_del, dv_dtp_del, msgerr, PLGNo, OUTREQNo, OUTNo, OUTDT, USERID, CheckNEW, dtc, dtp) Then
            CancelPLG = True
        Else
            CancelPLG = False
        End If

    End Function
    Private Function SaveGOUT() As Boolean
        Dim config As New clsConfig
        Dim objdb As New classPackingListG
        Dim PLGHeader As New classPackingListG.PackingListGHeader
        Dim msgerr As String = ""

        Dim PLGNo As String = PackinglistNo
        Dim OUTNo As String = strOut_no
        Dim OUTREQNo As String = txtDocNo.Text
        Dim OUTDT As String = DtpOutdt.Value.ToString("yyyyMMdd")
        Dim USERID As String = clsuser.UserID
        Dim CheckNEW As String = txtPackNo.Text.Trim
        Dim Doc_type As String = CboDoc_type.DisplayMember

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
        PLGHeader.h02_packno = txtPackNo.Text.Trim
        PLGHeader.h38_packdt = DtpPackDate.Value.ToString("dd-MM-yyyy") 'เอาแต่วันที่
        PLGHeader.h06_gout = 1
        PLGHeader.h07_sel = True

        PLGHeader.h20_outno = txtOutNo.Text.Trim
        PLGHeader.h21_outdt = DtpOutdt.Value.ToString("dd-MM-yyyy") 'CDate(DtpOutdt.Value.ToString("dd-MM-yyyy")) 'เอาแต่วันที่
        PLGHeader.h46_empcd = clsuser.UserID.Trim


        If objdb.plgsaveGOUT(PLGHeader, dv_dtc_add, dv_dtp_add, dv_dtc_upd, dv_dtp_upd, dv_dtc_del, dv_dtp_del, msgerr, PLGNo, OUTREQNo, OUTNo, OUTDT, USERID, CheckNEW, grdDataCartons.DataSource, dtp2, Doc_type) Then
            txtPackNo.Text = PLGHeader.h02_packno.Trim
            txtOutNo.Text = PLGHeader.h20_outno.Trim
            ValidateOutno()
            SaveGOUT = True
        Else
            SaveGOUT = False
            MessageBox.Show(msgerr, "System Message", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
        End If


    End Function
    Private Function ValidateOutno() As Boolean
        If txtOutNo.Text <> "" Then
            btngout.Enabled = False
            ValidateOutno = False
        Else
            btngout.Enabled = True
            ValidateOutno = True
        End If


    End Function
    Private Function SavePLG() As Boolean
        Dim config As New clsConfig
        Dim objdb As New classPackingListG
        Dim PLGHeader As New classPackingListG.PackingListGHeader
        Dim msgerr As String = ""

        Dim PLGNo As String = strPacking_no
        Dim OUTNo As String = strOut_no
        Dim OUTREQNo As String = txtDocNo.Text
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


        'header.h01_cartno = dtc.Rows(0)("cartno").ToString.Trim
        'header.h17_outreqno = txtReqNo.Text
        PLGHeader.h02_packno = txtPackNo.Text.Trim
        PLGHeader.h20_outno = txtOutNo.Text.Trim
        If clsconfig.IsNull(PLGHeader.h20_outno.Trim, "") <> "" Then
            PLGHeader.h21_outdt = DtpOutdt.Value.ToString("dd-MM-yyyy")
        ElseIf clsconfig.IsNull(PLGHeader.h20_outno.Trim, "") = "" Then
            PLGHeader.h21_outdt = Nothing
        End If
        'PLGHeader.h21_outdt = CDate(DtpOutdt.Value.ToString("dd-MM-yyyy")) 'เอาแต่วันที่
        PLGHeader.h38_packdt = DtpPackDate.Value.ToString("dd-MM-yyyy") 'เอาแต่วันที่
        PLGHeader.h46_empcd = clsuser.UserID.Trim

        blnCancel = False
        Dim result As DialogResult
        result = MessageBox.Show("Would you like to save ?", "System Message", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button3)
        If result = DialogResult.Cancel Then blnCancel = True
        If result <> DialogResult.Yes Then Exit Function



        If objdb.plgsave(PLGHeader:=PLGHeader, dv_dtc_add:=dv_dtc_add, dv_dtc_upd:=dv_dtc_upd, dv_dtc_del:=dv_dtc_del, _
                         dv_dtp_add:=dv_dtp_add, dv_dtp_upd:=dv_dtp_upd, dv_dtp_del:=dv_dtp_del, msgerr:=msgerr, PLGNo:=PLGNo, OUTREQNo:=OUTREQNo, _
                         OUTNO:=OUTNo, OUTDT:=OUTDT, USERID:=USERID, CheckNEW:=CheckNEW, Doc_Type:=Doc_type) Then
            PackinglistNo = PLGHeader.h02_packno
            Call Validate_Outno()
            SavePLG = True

        Else
            SavePLG = False
            MessageBox.Show(msgerr, "System Message", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
        End If


    End Function

    Private Sub txtPackNo_MouseClick(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles txtPackNo.MouseClick
        ' txtPackNo.SelectAll()
    End Sub



    Private Sub txtPackNo_RightToLeftChanged(sender As Object, e As System.EventArgs) Handles txtPackNo.RightToLeftChanged

    End Sub

    Private Sub txtPackNo_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtPackNo.TextChanged

    End Sub

    Private Sub grdDataCartons_CellContextMenuStripNeeded(sender As Object, e As System.Windows.Forms.DataGridViewCellContextMenuStripNeededEventArgs) Handles grdDataCartons.CellContextMenuStripNeeded

    End Sub

    Private Sub grdDataCartons_CellEndEdit(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles grdDataCartons.CellEndEdit
        'If grdDataCartons.DataSource Is Nothing Then Exit Sub
        'If grdDataCartons.Rows.Count = 0 Then Exit Sub
        ' If grdDataCartons.Rows(e.RowIndex).Cells("grdDataCartons_cartno").Value Is Nothing Then Exit Sub
        ' Dim config As New clsConfig
        ' Dim objDB As New classPackingListG
        ' Dim dtc As New DataTable
        ' Dim dtp As New DataTable
        'grdDataPackingList.AutoGenerateColumns = False
        'strPacking_no = txtPackNo.Text
        'strCartno = grdDataCartons.Rows(e.RowIndex).Cells("grdDataCartons_cartno").Value
        'If strCartno = "" Then Exit Sub
        'dtc = grdDataCartons.DataSource
        'dtp = grdDataPackingList.DataSource
        ' If grdDataCartons.Rows.Count > 0 Then

        'dtc = objDB.GetPackinglistGDataDetail(strPacking_no, _
        'config.IsNull(grdDataCartons.Rows(e.RowIndex).Cells("grdDataCartons_cartno").Value, "").ToString.Trim)
        ' End If

        'grdDataPackingList.DataSource = dt
        ' SumGrdPackingList()

        'CboCartonsNo.DataSource = dtc
        'CboCartonsNo.DataSource = grdDataCartons.DataSource
        'CboCartonsNo.ValueMember = "cartno"
        'CboCartonsNo.ValueMember = "cartno"
        SumGrdPackingList()
    End Sub


    Private Sub BtnExit_Click(sender As System.Object, e As System.EventArgs) Handles BtnExit.Click
        Me.Close()
    End Sub

    Private Sub frmPackingListDyed_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If MessageBox.Show("Would you like to close ?", "System Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.No Then
            e.Cancel = True
        End If
    End Sub


    Private Sub btngout_Click(sender As System.Object, e As System.EventArgs) Handles btngout.Click
        SaveGOUTBF()
    End Sub

    Private Sub BtnPrint_Click(sender As System.Object, e As System.EventArgs) Handles BtnPrintPLG.Click
        strPacking_no = txtPackNo.Text
        If strPacking_no = "" Then strPacking_no = txtPackNo.Text
        If strPacking_no.Length = 0 Then Exit Sub

        'Const rptFileName = "rptPLG.rpt"   'Comment By Sitthana 20190509
        Dim rptFileName As String = ""    'Sitthana 20190509
        Select Case Custcd
            Case PresslessCustCd
                rptFileName = "rptPLGPressless.rpt"
            Case Else
                rptFileName = "rptPLG.rpt"
        End Select

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

        'rpt.PrintOptions.PaperSize = CrystalDecisions.Shared.PaperSize.PaperA4
        'rpt.PrintOptions.PaperOrientation = CrystalDecisions.Shared.PaperOrientation.Portrait
        'rpt.PrintOptions.PaperSource = CrystalDecisions.Shared.PaperSource.Auto

        frm.Title = "PackingList G"
        frm.CRViewer.ReportSource = rpt
        'Dim dt As New DataTable
        frm.MdiParent = Me.ParentForm
        frm.Show()
        Me.Cursor = Cursors.Default

    End Sub

    Private Sub grdDataCartons_CellEnter(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles grdDataCartons.CellEnter

    End Sub

    Private Sub grdDataCartons_CellContentClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles grdDataCartons.CellContentClick

    End Sub

    Private Sub grdDataCartons_Layout(sender As Object, e As System.Windows.Forms.LayoutEventArgs) Handles grdDataCartons.Layout

    End Sub

    Private Sub grdDataCartons_LostFocus(sender As Object, e As System.EventArgs) Handles grdDataCartons.LostFocus
        SumGrdPackingList()
    End Sub

    Private Sub CboCartonsNo_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles CboCartonsNo.SelectedIndexChanged

    End Sub

    Private Sub BtnPrintOutNo_Click(sender As System.Object, e As System.EventArgs) Handles BtnPrintGout.Click
        'strPacking_no = txtPackNo.Text
        'If txtOutNo.Text = "" Then strPacking_no = txtPackNo.Text
        If txtOutNo.Text.Length = 0 Then Exit Sub
        Const rptFileName = "rptGOut.rpt"

        If Not clsconfig.CheckReport(clsuser.ReportPath, rptFileName) Then Exit Sub
        'Dim frm As New frmReportPLG
        Dim frm As New frmReport
        Dim rpt As New CrystalDecisions.CrystalReports.Engine.ReportDocument
        Me.Cursor = Cursors.WaitCursor
        rpt.Load(clsuser.ReportPath & rptFileName)
        rpt.DataSourceConnections.Item(0).SetConnection(clsConn.servername, clsConn.database, False)
        rpt.DataSourceConnections.Item(0).SetLogon(clsConn.Userid, clsConn.Password)
        rpt.VerifyDatabase()
        rpt.SetParameterValue("@outnofr", txtOutNo.Text)
        rpt.SetParameterValue("@outnoto", txtOutNo.Text)
        rpt.SetParameterValue("@outdtfr", "")
        rpt.SetParameterValue("@outdtto", "")

        'rpt.PrintOptions.PaperSize = CrystalDecisions.Shared.PaperSize.PaperA4
        'rpt.PrintOptions.PaperOrientation = CrystalDecisions.Shared.PaperOrientation.Portrait
        'rpt.PrintOptions.PaperSource = CrystalDecisions.Shared.PaperSource.Auto

        frm.Title = "Greige Out"
        frm.CRViewer.ReportSource = rpt
        'Dim dt As New DataTable
        frm.MdiParent = Me.ParentForm
        frm.Show()
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub grdDataCartons_CellValueChanged(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles grdDataCartons.CellValueChanged
        Dim config As New clsConfig
        If grdDataCartons.Columns(e.ColumnIndex).Name = "grdDataCartons_dimension" Then 'Add By Neung 20160530 For K.Joom
            If grdDataCartons.Rows(e.RowIndex).Cells("grdDataCartons_dimension").Value.ToString = "52CM X 160CM X 52CM" Then
                grdDataCartons.Rows(e.RowIndex).Cells("grdDataCartons_grswt").Value = FormatNumber(config.IsNull(grdDataCartons.Rows(e.RowIndex).Cells("grdDataCartons_netwt").Value, 0) + 5.5, 2, TriState.False, TriState.False, TriState.True)
            ElseIf grdDataCartons.Rows(e.RowIndex).Cells("grdDataCartons_dimension").Value.ToString = "52CM X 180CM X 52CM" Then
                grdDataCartons.Rows(e.RowIndex).Cells("grdDataCartons_grswt").Value = FormatNumber(config.IsNull(grdDataCartons.Rows(e.RowIndex).Cells("grdDataCartons_netwt").Value, 0) + 5.9, 2, TriState.False, TriState.False, TriState.True)
            ElseIf grdDataCartons.Rows(e.RowIndex).Cells("grdDataCartons_dimension").Value.ToString = "52CM X 250CM X 52CM" Then
                grdDataCartons.Rows(e.RowIndex).Cells("grdDataCartons_grswt").Value = FormatNumber(config.IsNull(grdDataCartons.Rows(e.RowIndex).Cells("grdDataCartons_netwt").Value, 0) + 8.6, 2, TriState.False, TriState.False, TriState.True)
            ElseIf grdDataCartons.Rows(e.RowIndex).Cells("grdDataCartons_dimension").Value.ToString = "52CM X 160CM X 25CM" Then
                grdDataCartons.Rows(e.RowIndex).Cells("grdDataCartons_grswt").Value = FormatNumber(config.IsNull(grdDataCartons.Rows(e.RowIndex).Cells("grdDataCartons_netwt").Value, 0) + 4, 2, TriState.False, TriState.False, TriState.True)
            ElseIf grdDataCartons.Rows(e.RowIndex).Cells("grdDataCartons_dimension").Value.ToString = "52CM X 180CM X 25CM" Then
                grdDataCartons.Rows(e.RowIndex).Cells("grdDataCartons_grswt").Value = FormatNumber(config.IsNull(grdDataCartons.Rows(e.RowIndex).Cells("grdDataCartons_netwt").Value, 0) + 4.5, 2, TriState.False, TriState.False, TriState.True)
            ElseIf grdDataCartons.Rows(e.RowIndex).Cells("grdDataCartons_dimension").Value.ToString = "25CM X 160CM X 25CM" Then
                grdDataCartons.Rows(e.RowIndex).Cells("grdDataCartons_grswt").Value = FormatNumber(config.IsNull(grdDataCartons.Rows(e.RowIndex).Cells("grdDataCartons_netwt").Value, 0) + 2.25, 2, TriState.False, TriState.False, TriState.True)
            ElseIf grdDataCartons.Rows(e.RowIndex).Cells("grdDataCartons_dimension").Value.ToString = "25CM X 180CM X 25CM" Then
                grdDataCartons.Rows(e.RowIndex).Cells("grdDataCartons_grswt").Value = FormatNumber(config.IsNull(grdDataCartons.Rows(e.RowIndex).Cells("grdDataCartons_netwt").Value, 0) + 2.7, 2, TriState.False, TriState.False, TriState.True)
            ElseIf grdDataCartons.Rows(e.RowIndex).Cells("grdDataCartons_dimension").Value.ToString = "52CM X 210CM X 52CM" Then
                grdDataCartons.Rows(e.RowIndex).Cells("grdDataCartons_grswt").Value = FormatNumber(config.IsNull(grdDataCartons.Rows(e.RowIndex).Cells("grdDataCartons_netwt").Value, 0) + 6.5, 2, TriState.False, TriState.False, TriState.True)
            ElseIf grdDataCartons.Rows(e.RowIndex).Cells("grdDataCartons_dimension").Value.ToString = "52CM X 130CM X 52CM" Then
                grdDataCartons.Rows(e.RowIndex).Cells("grdDataCartons_grswt").Value = FormatNumber(config.IsNull(grdDataCartons.Rows(e.RowIndex).Cells("grdDataCartons_netwt").Value, 0) + 5.5, 2, TriState.False, TriState.False, TriState.True)
            ElseIf grdDataCartons.Rows(e.RowIndex).Cells("grdDataCartons_dimension").Value.ToString = "10CM X 160CM X 10CM" Then
                grdDataCartons.Rows(e.RowIndex).Cells("grdDataCartons_grswt").Value = FormatNumber(config.IsNull(grdDataCartons.Rows(e.RowIndex).Cells("grdDataCartons_netwt").Value, 0) + 1.0, 2, TriState.False, TriState.False, TriState.True)
            ElseIf grdDataCartons.Rows(e.RowIndex).Cells("grdDataCartons_dimension").Value.ToString = "10CM X 180CM X 10CM" Then
                grdDataCartons.Rows(e.RowIndex).Cells("grdDataCartons_grswt").Value = FormatNumber(config.IsNull(grdDataCartons.Rows(e.RowIndex).Cells("grdDataCartons_netwt").Value, 0) + 1.8, 2, TriState.False, TriState.False, TriState.True)
            ElseIf grdDataCartons.Rows(e.RowIndex).Cells("grdDataCartons_dimension").Value.ToString = "15CM X 160CM X 15CM" Then
                grdDataCartons.Rows(e.RowIndex).Cells("grdDataCartons_grswt").Value = FormatNumber(config.IsNull(grdDataCartons.Rows(e.RowIndex).Cells("grdDataCartons_netwt").Value, 0) + 2.0, 2, TriState.False, TriState.False, TriState.True)
            ElseIf grdDataCartons.Rows(e.RowIndex).Cells("grdDataCartons_dimension").Value.ToString = "15CM X 180CM X 15CM" Then
                grdDataCartons.Rows(e.RowIndex).Cells("grdDataCartons_grswt").Value = FormatNumber(config.IsNull(grdDataCartons.Rows(e.RowIndex).Cells("grdDataCartons_netwt").Value, 0) + 2.8, 2, TriState.False, TriState.False, TriState.True)
            ElseIf grdDataCartons.Rows(e.RowIndex).Cells("grdDataCartons_dimension").Value.ToString = "52CM X 160CM X 40CM" Then
                grdDataCartons.Rows(e.RowIndex).Cells("grdDataCartons_grswt").Value = FormatNumber(config.IsNull(grdDataCartons.Rows(e.RowIndex).Cells("grdDataCartons_netwt").Value, 0) + 3.5, 2, TriState.False, TriState.False, TriState.True)
            ElseIf grdDataCartons.Rows(e.RowIndex).Cells("grdDataCartons_dimension").Value.ToString = "52CM X 180CM X 40CM" Then
                grdDataCartons.Rows(e.RowIndex).Cells("grdDataCartons_grswt").Value = FormatNumber(config.IsNull(grdDataCartons.Rows(e.RowIndex).Cells("grdDataCartons_netwt").Value, 0) + 4.25, 2, TriState.False, TriState.False, TriState.True)

            Else
                grdDataCartons.Rows(e.RowIndex).Cells("grdDataCartons_grswt").Value = FormatNumber(config.IsNull(grdDataCartons.Rows(e.RowIndex).Cells("grdDataCartons_netwt").Value, 0), 2, TriState.False, TriState.False, TriState.True)
            End If


        End If
    End Sub

    Private Sub btnMoveLeft_Click(sender As System.Object, e As System.EventArgs) Handles btnMoveLeft.Click
        If grdDataCartons.Width > 300 Then
            grdDataCartons.Width = grdDataCartons.Width - 300
            btnMoveLeft.Left = grdDataCartons.Right
            btnMoveRight.Left = grdDataCartons.Right
            'btnAdd.Left = grdDataCartons.Right
            'btnDel.Left = grdDataCartons.Right
            'btnDelAll.Left = grdDataCartons.Right
            grdDataPackingList.Left = btnMoveLeft.Right
            grdDataPackingList.Width = grdDataPackingList.Width + 300
        End If
    End Sub

    Private Sub btnMoveRight_Click(sender As System.Object, e As System.EventArgs) Handles btnMoveRight.Click
        If grdDataPackingList.Width > 300 Then
            grdDataCartons.Width = grdDataCartons.Width + 300
            btnMoveLeft.Left = grdDataCartons.Right
            btnMoveRight.Left = grdDataCartons.Right
            'btnAdd.Left = grdDataCartons.Right
            'btnDel.Left = grdDataCartons.Right
            'btnDelAll.Left = grdDataCartons.Right
            grdDataPackingList.Left = btnMoveLeft.Right
            grdDataPackingList.Width = grdDataPackingList.Width - 300
        End If
    End Sub

    Private Sub optReqNo_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles optReqNo.CheckedChanged
        Checkopt()
    End Sub

    Public Sub Checkopt()
        If optReqNo.Checked Then
            lblDocNo.Text = "REQ No."
            txtDocNo.Text = "Please Enter Req No."
            'ElseIf OptLotNo.Checked Then
            '     lblDocNo.Text = "Lot No."
            '     txtDocNo.Text = "Please Enter Lot No."
        ElseIf optGinNo.Checked Then
            lblDocNo.Text = "GIN No."
            txtDocNo.Text = "Please Enter GIN No."
        End If
    End Sub

    Private Sub txtDocNo_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtDocNo.TextChanged

    End Sub

    Private Sub optGinNo_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles optGinNo.CheckedChanged
        Checkopt()
    End Sub

    Private Sub grdDataPackingList_CellContentClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles grdDataPackingList.CellContentClick

    End Sub

    Private Sub BtnYarnPrintBar_Click(sender As Object, e As EventArgs) Handles BtnYarnPrintBar.Click
        Dim clsConfig As New clsConfig
        Dim rptFileName = "rptGreigeBarcode.rpt"
        'clsUser.ReportPath = "C:\Users\DELL\Desktop\GemmaKnits\"
        If Not clsConfig.CheckReport(clsuser.ReportPath, rptFileName) Then Exit Sub
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
End Class