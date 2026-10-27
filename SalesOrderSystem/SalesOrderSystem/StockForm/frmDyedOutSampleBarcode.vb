Imports System.Data.SqlClient

Public Class frmDyedOutSampleBarcode
    Dim blnCancel As Boolean
    Dim clsUser As New classUserInfo
    Dim dtDoutBarcodeNew As New DataTable
    Dim bsDoutBarcodeNew As New BindingSource

    Dim dtDoutNew As New DataTable
    Dim bsDoutNew As New BindingSource

    Public Property UserInfo() As classUserInfo
        Get
            UserInfo = clsUser
        End Get
        Set(ByVal NewValue As classUserInfo)
            clsUser = NewValue
        End Set
    End Property

    Private Sub frmDyedOutSampleBarcode_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized

        Call InitControl()

        Call InitDataBinding()

        Call LoadGrdDOutNewByOutno("N/A")

    End Sub

    Private Sub txtIDstrollsdo_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles txtIDstrollsdo.KeyDown
        If e.KeyCode = Keys.Enter Then

            dtDoutBarcodeNew = (New classDyedOutSampleBarcode).GetGridDoutNewByBarcode(Int64IDStrollsDO:=Val(txtIDstrollsdo.Text.Trim))
            bsDoutBarcodeNew.DataSource = dtDoutBarcodeNew
            bsDoutBarcodeNew.MoveFirst()

            txtkgs.Focus()
        End If
    End Sub


    Private Sub InitControl()
        Dim obj As Control
        For Each obj In Me.Controls
            Call SetControlValue(obj)
        Next
        Call EnabledControl(True)
        Call SetErrorProvider()

        txtOutno.Enabled = False
        dtpOutDt.Enabled = False
    End Sub


    Private Sub SetControlValue(ByVal Obj As Control)
        If TypeOf Obj Is TextBox Then
            Obj.Text = Obj.Tag

        End If
        If TypeOf Obj Is DateTimePicker Then
            Dim dtp As DateTimePicker = Obj
            dtp.Value = Now
            dtp.Checked = False
        End If
        If TypeOf Obj Is ComboBox Then
            Dim cbo As ComboBox = Obj
            cbo.SelectedIndex = -1
        End If
        If TypeOf Obj Is CheckBox Then
            Dim chk As CheckBox = Obj
            chk.Checked = False
            If chk.Name = "chkAutoCalculate" Then chk.Checked = True

        End If
        If TypeOf Obj Is TabControl Or TypeOf Obj Is TabPage Or TypeOf Obj Is GroupBox Then
            Dim obj2 As Control
            For Each obj2 In Obj.Controls
                Call SetControlValue(obj2)
            Next
        End If
    End Sub

    Private Sub EnabledControl(ByVal blnEnabled As Boolean)
        Dim obj As Control
        For Each obj In Me.Controls
            Call SetControlEnabled(obj, blnEnabled)
        Next

    End Sub

    Private Sub SetControlEnabled(ByVal Obj As Control, ByVal blnEnabled As Boolean)
        If TypeOf Obj Is TextBox Then Obj.Enabled = blnEnabled
        If TypeOf Obj Is DateTimePicker Then Obj.Enabled = blnEnabled
        If TypeOf Obj Is ComboBox Then Obj.Enabled = blnEnabled
        If TypeOf Obj Is CheckBox Then Obj.Enabled = blnEnabled
        If TypeOf Obj Is DataGridView Then
            Dim grd As DataGridView = Obj
            grd.ReadOnly = Not blnEnabled
        End If
        If TypeOf Obj Is TabControl Or TypeOf Obj Is TabPage Or TypeOf Obj Is GroupBox Then
            Dim obj2 As Control
            For Each obj2 In Obj.Controls
                Call SetControlEnabled(obj2, blnEnabled)
            Next
        End If



    End Sub


    Private Sub SetErrorProvider()
        ErrorProvider1.Clear()
    End Sub

    Private Sub InitDataBinding()

        dtDoutBarcodeNew = (New classDyedOutSampleBarcode).GetGridDoutNewByBarcode(Int64IDStrollsDO:=Val(txtIDstrollsdo.Text.Trim))

        bsDoutBarcodeNew.DataSource = dtDoutBarcodeNew
        ' dtDoutBarcodeNew = (New classDyedOutSample).GetGridDoutNewByOutno(StrOutno:=txtOutno.Text.Trim)

        'dtDoutBarcodeNew.DataSource = dtDoutdtDoutBarcodeNew

        Call BindingData() '
    End Sub

    Private Sub BindingData()
        Call ClearDataBindings()

        txtIDstrollsdo.DataBindings.Add("text", bsDoutBarcodeNew, "id_strolls_d_o")
        txtkgs.DataBindings.Add("text", bsDoutBarcodeNew, "request_kg")
        txtMts.DataBindings.Add("text", bsDoutBarcodeNew, "request_mts")
        txtYds.DataBindings.Add("text", bsDoutBarcodeNew, "request_yds")
        txtmtkg.DataBindings.Add("text", bsDoutBarcodeNew, "mtkg")
        txtOutno.DataBindings.Add("text", bsDoutBarcodeNew, "outno")
        ' txtaddr1.DataBindings.Add("text", bsCboCustomer, "addr1")

    End Sub

    Public Sub ClearDataBindings()
        Dim obj As Control
        For Each obj In Me.Controls
            Call ClearControlBindings(obj)
        Next
    End Sub

    Private Sub ClearControlBindings(ByVal obj As Control)
        obj.DataBindings.Clear()
        If TypeOf obj Is TabControl Or TypeOf obj Is TabPage Or TypeOf obj Is GroupBox Then
            Dim obj2 As Control
            For Each obj2 In obj.Controls
                Call ClearControlBindings(obj2)
            Next
        End If

    End Sub

    Private Sub LoadGrdDOutNewByOutno(ByVal StrOutno As String)

        Dim dt As DataTable = (New classDyedOutSampleBarcode).GetGridDoutNewByOutno(StrOutno:=StrOutno)
        If dt.Rows.Count > 0 Then BindtxtDoutNew(dt)
        Call BindGrdDoutNew(dt)

    End Sub

    Private Sub BindtxtDoutNew(ByVal dt As DataTable)
        dtDoutNew = dt

        bsDoutNew.DataSource = dtDoutNew

    End Sub

    Private Sub BindGrdDoutNew(ByVal dt As DataTable)
        dtDoutNew = dt

        bsDoutNew.DataSource = dtDoutNew

        grdDoutNew.AutoGenerateColumns = False
        grdDoutNew.DataSource = bsDoutNew.DataSource

    End Sub

    Private Sub txtDesignNo_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtIDstrollsdo.TextChanged

    End Sub

    Private Sub txtkgs_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles txtkgs.KeyDown
        If e.KeyCode = Keys.Enter Then
            Call AddRollNo()

            txtIDstrollsdo.Focus()
        End If
    End Sub

    'Private Sub BindDataREQD(ByVal dt As DataTable)
    '    Dim config As New clsConfig
    '    ' If txtDocNo.Text = "" Then Exit Sub

    '    grdDoutBarcodeNew.AutoGenerateColumns = False
    '    If dt.Rows.Count > 0 Then
    '        Dim dt1 As DataTable = dt
    '        Dim dt2 As DataTable = grdDoutBarcodeNew.DataSource

    '        Dim dr1 As DataRow

    '        Dim msg As String = ""
    '        Dim i As Integer = 0



    '        Dim j As Integer = 0
    '        For i = 0 To dt.Rows.Count - 1
    '            dr1 = dt2.NewRow
    '            dr1("cartno") = dt1.Rows(i)("cartno")
    '            dr1("roll_no_d") = dt1.Rows(i)("roll_no_d")
    '            dr1("roll_no_o") = dt1.Rows(i)("roll_no_o")
    '            dr1("grade") = dt1.Rows(i)("grade")
    '            dr1("design_no") = dt1.Rows(i)("design_no")
    '            dr1("lot") = dt1.Rows(i)("lot")
    '            dr1("col") = dt1.Rows(i)("col")
    '            dr1("custcolor") = dt1.Rows(i)("custcolor")
    '            dr1("outkg_g") = dt1.Rows(i)("outkg_g")
    '            dr1("outyd_g") = dt1.Rows(i)("outyd_g")
    '            dr1("outmt_g") = dt1.Rows(i)("outmt_g")
    '            dr1("sono") = dt1.Rows(i)("sono")
    '            dr1("sonoid") = dt1.Rows(i)("sonoid")
    '            dr1("Gwth") = dt1.Rows(i)("Gwth")
    '            dr1("Fwth") = dt1.Rows(i)("Fwth")
    '            dr1("outreqno") = dt1.Rows(i)("outreqno")
    '            dr1("outreqdt") = dt1.Rows(i)("outreqdt")
    '            dr1("outreqtyp") = dt1.Rows(i)("outreqtyp")
    '            dr1("pono") = dt1.Rows(i)("pono")
    '            dr1("outno1") = dt1.Rows(i)("outno1")
    '            dr1("no_of_units") = dt1.Rows(i)("no_of_units")
    '            Dim checkDupicateRoll As Boolean = False

    '            If dt2.Rows.Count > 0 Then
    '                For Each dr2 As DataRow In dt2.Rows
    '                    If dr2("id").ToString().Equals(dt1.Rows(i)("roll_no_d")) Then
    '                        checkDupicateRoll = True
    '                    End If

    '                Next
    '            End If
    '            If Not checkDupicateRoll Then
    '                dt2.Rows.Add(dr1)
    '            End If


    '        Next

    '    End If

    '    'Call SumGrdPackingList()

    'End Sub

    Private Sub AddRollNo()
        If dtDoutBarcodeNew.Rows.Count > 0 Then
            Dim config As New clsConfig
            Dim dr As DataRow
            Dim msg As String = ""
            Dim i As Integer = 0
            Dim j As Integer = 0
            For i = 0 To dtDoutBarcodeNew.Rows.Count - 1
                If Not CheckDuplicate(dtDoutBarcodeNew.Rows(i)("id_strolls_d_o").ToString.Trim, dtDoutNew.Copy()) Then

                    dr = dtDoutNew.NewRow

                    For j = 0 To dtDoutBarcodeNew.Columns.Count - 1
                        dr(dtDoutNew.Columns(j).ColumnName.Trim) = dtDoutBarcodeNew.Rows(i)(dtDoutBarcodeNew.Columns(j).ColumnName.Trim)
                        dr.Item("request_kg") = txtkgs.Text.Trim
                        dr.Item("request_mts") = txtMts.Text.Trim
                        dr.Item("request_yds") = txtYds.Text.Trim
                    Next

                    dtDoutNew.Rows.Add(dr)
                End If
            Next
        End If
        ' Call SumGrid()
    End Sub

    Private Function CheckDuplicate(ByVal strRollNo As String, ByVal dt As DataTable) As Boolean
        If dt.Rows.Count > 0 Then
            Dim i As Integer = 0
            For i = 0 To dt.Rows.Count - 1
                If dt.Rows(i).RowState <> DataRowState.Deleted Then
                    If dt.Rows(i)("id_strolls_d_o").ToString.Trim = strRollNo Then Return True
                End If
            Next
        End If
        Return False
    End Function

    Private Sub txtkgs_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtkgs.TextChanged
        If CBool(chkAutoCalculate.Checked) Then

            'If (New clsConfig).IsNull(Val(txtmtkg.Text.Trim), 0) = 0 Then MessageBox.Show("ไม่พบ Mtkg", "System Message")

            'If grdDoutNew.Columns(e.ColumnIndex).Name = "grdDoutNewRequestKg" Then
            If (New clsConfig).IsNull(Val(txtkgs.Text.Trim), 0) > 0 And (New clsConfig).IsNull(Val(txtmtkg.Text.Trim), 0) > 0 Then
                If (New clsConfig).IsNull(Val(txtmtkg.Text.Trim), 0) > 0 Then txtMts.Text = FormatNumber(Val(txtkgs.Text) * Val(txtmtkg.Text), 2, TriState.False, TriState.False, TriState.False)
                If (New clsConfig).IsNull(Val(txtmtkg.Text.Trim), 0) > 0 Then txtYds.Text = FormatNumber(Val(txtMts.Text) / 0.9144, 2, TriState.False, TriState.False, TriState.False)
                ' txtYds.Text = FormatNumber(Me.grdDoutNew.Rows(e.RowIndex).Cells("grdDoutNewRequestMts").Value / 0.9144, 2, TriState.False, TriState.False, TriState.False)

            End If
            ' txtYds.Text = FormatNumber(Me.grdDoutNew.Rows(e.RowIndex).Cells("grdDoutNewRequestMts").Value / 0.9144, 2, TriState.False, TriState.False, TriState.False)
            'grdDoutNew.CurrentRow.Cells("grdDoutNewRequestYds").Value = FormatNumber(Me.grdDoutNew.Rows(e.RowIndex).Cells("grdDoutNewRequestMts").Value / 0.9144, 2, TriState.False, TriState.False, TriState.False)
            'End If
            'If grdDoutNew.Columns(e.ColumnIndex).Name = "grdDoutNewRequestYds" Then
            '    grdDoutNew.CurrentRow.Cells("grdDoutNewRequestMts").Value = FormatNumber(grdDoutNew.CurrentRow.Cells("grdDoutNewRequestYds").Value * 0.9144, 2, TriState.False, TriState.False, TriState.False)
            '    If Val(grdDoutNew.CurrentRow.Cells("grdDoutNewRequestMtkg").Value) > 0 Then grdDoutNew.CurrentRow.Cells("grdDoutNewRequestKg").Value = FormatNumber(grdDoutNew.CurrentRow.Cells("grdDoutNewRequestMts").Value / grdDoutNew.CurrentRow.Cells("grdDoutNewRequestMtkg").Value, 2, TriState.False, TriState.False, TriState.False)
            'End If
            'If grdDoutNew.Columns(e.ColumnIndex).Name = "grdDoutNewRequestMts" Then
            '    grdDoutNew.CurrentRow.Cells("grdDoutNewRequestYds").Value = FormatNumber(grdDoutNew.CurrentRow.Cells("grdDoutNewRequestMts").Value / 0.9144, 2, TriState.False, TriState.False, TriState.False)
            '    If Val(grdDoutNew.CurrentRow.Cells("grdDoutNewRequestMtkg").Value) > 0 Then grdDoutNew.CurrentRow.Cells("grdDoutNewRequestKg").Value = FormatNumber(grdDoutNew.CurrentRow.Cells("grdDoutNewRequestMts").Value / grdDoutNew.CurrentRow.Cells("grdDoutNewRequestMtkg").Value, 2, TriState.False, TriState.False, TriState.False)
            'End If

        End If
    End Sub

    Private Sub BtnMakeDyedout_Click(sender As System.Object, e As System.EventArgs) Handles BtnMakeDyedout.Click
        blnCancel = False
        'Sitthana 20220624 Changed Windows.Forms.DialogResult To DialogResult
        Dim result As DialogResult ' Windows.Forms.DialogResult
        result = MessageBox.Show("Would you like to Make Sample Out Sample ?", "System Message", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button3)
        If result = DialogResult.Cancel Then blnCancel = True
        If result <> DialogResult.Yes Then Exit Sub

        If Not CheckDataMakeDyedOut() Then Exit Sub

        If MakeSampleOut() Then

        End If
    End Sub

    Public Function CheckDataMakeDyedOut() As Boolean

        If grdDoutNew.Rows.Count = 0 Then
            MessageBox.Show("คุณยังไม่ได้เลือก ม้วน Sample", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return False
            Exit Function
        End If

        If Not txtOutno.Text.Trim = "" Then
            MessageBox.Show("ทำ Sample Out ไปแล้ว ไม่สามารถทำได้อีก ", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return False
            Exit Function
        End If
        'If txtpackno.Text.Trim.Length = 0 Then
        '    MessageBox.Show("คุณยังไม่ได้เลือก PLS", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
        '    Return False
        '    Exit Function
        'End If

        'If grdDoutNew.Rows.Count <= 0 Then
        '    MessageBox.Show("คุณยังไม่ได้เลือก ม้วน", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
        '    Return False
        '    Exit Function
        'End If

        'If (New clsConfig).IsNull(cboCustomer.SelectedValue, 0) = 0 Then
        '    MessageBox.Show("คุณยังไม่ได้เลือก ลูกค้า", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
        '    Return False
        '    Exit Function
        'End If

        Return True
    End Function


    Public Function MakeSampleOut() As Boolean
        Dim dt As DataTable = bsDoutNew.DataSource
        Dim dv_add As New DataView(dt, "", "", DataViewRowState.Added)
        Dim dv_upd As New DataView(dt, "", "", DataViewRowState.ModifiedCurrent)
        Dim dv_del As New DataView(dt, "", "", DataViewRowState.Deleted)
        Dim msgerr As String = "'"

        Dim StrollsDO As New StrollsDO

        StrollsDO.StrOutno = txtOutno.Text
        If txtOutno.Text.Trim <> "" Then StrollsDO.DateOutdt = dtpOutDt.Value Else StrollsDO.DateOutdt = Nothing
        'StrollsDO.Strpackno = txtpackno.Text
        'If txtpackno.Text.Trim <> "" Then StrollsDO.Datepackdt = dtpPackdt.Value Else StrollsDO.Datepackdt = Nothing
        StrollsDO.Int32Cartno = "1"
        'StrollsDO.StrDoctyp = cboDocType.SelectedValue
        ' StrollsDO.Int64CustomerID = cboCustomer.SelectedValue

        'StrollsDO.StrEmpcd = cboempcd.SelectedValue 'Request 


        If (New classDyedOutSampleBarcode).MakeSampleOut(StrollsDO:=StrollsDO, DV_ADD:=dv_add, DV_UPD:=dv_upd, DV_DEL:=dv_del, msgerr:=msgerr, Userinfo:=UserInfo) Then
            MessageBox.Show("บันทึกสำเร็จ Out No. :" & StrollsDO.StrOutno & "", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtOutno.Text = StrollsDO.StrOutno
            Call LoadGrdDOutNewByOutno(StrOutno:=txtOutno.Text)
        Else
            MessageBox.Show(msgerr, "System Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

    End Function

    Private Sub grdDoutNew_CellContentClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles grdDoutNew.CellContentClick
        If Not e.RowIndex >= 0 Then Exit Sub
        If grdDoutNew.CurrentCell.IsInEditMode Then grdDoutNew.EndEdit()
    End Sub

    Private Sub txtMts_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtMts.TextChanged
        If CBool(chkAutoCalculate.Checked) Then

        End If
    End Sub

    Private Sub btnNew_Click(sender As System.Object, e As System.EventArgs) Handles btnNew.Click

        Call frmDyedOutSampleBarcode_Load(sender:=sender, e:=e)

    End Sub

    Private Sub txtmtkg_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtmtkg.TextChanged

        If CBool(chkAutoCalculate.Checked) Then
            If (New clsConfig).IsNull(Val(txtkgs.Text.Trim), 0) > 0 And (New clsConfig).IsNull(Val(txtmtkg.Text.Trim), 0) > 0 Then
                If (New clsConfig).IsNull(Val(txtmtkg.Text.Trim), 0) > 0 Then txtMts.Text = FormatNumber(Val(txtkgs.Text) * Val(txtmtkg.Text), 2, TriState.False, TriState.False, TriState.False)
                If (New clsConfig).IsNull(Val(txtmtkg.Text.Trim), 0) > 0 Then txtYds.Text = FormatNumber(Val(txtMts.Text) / 0.9144, 2, TriState.False, TriState.False, TriState.False)
            End If
        End If

    End Sub

    Private Sub txtOutno_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtOutno.TextChanged

    End Sub

    Private Sub txtkgs_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtkgs.KeyPress

    End Sub
End Class