Public Class frmDyedOutSample
    Dim clsuser As New classUserInfo
    Dim blnCancel As Boolean

    Public dtCboCustomer As New DataTable
    Public bsCboCustomer As New BindingSource

    Public dtcboDocType As New DataTable
    Public bscboDocType As New BindingSource

    Public dtcboEmp As New DataTable
    Public bscboEmp As New BindingSource

    Dim dtStockD As New DataTable
    Dim bsStockD As New BindingSource

    Dim dtDoutNew As New DataTable
    Dim bsDoutNew As New BindingSource

    Public Property Userinfo() As classUserInfo
        Get
            Userinfo = clsuser
        End Get
        Set(ByVal newvalue As classUserInfo)
            clsuser = newvalue
        End Set
    End Property

    Private Sub frmDyedOutSample_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized

        Call InitControl()

        Call GenComBo()

        Call InitDataBinding()

        Call LoadGrdDoutStock()
        Call LoadGrdDOutNewByPackNo()

        txtOutno.Enabled = False
        dtpOutDt.Enabled = False
    End Sub

    Private Sub InitControl()
        Dim obj As Control
        For Each obj In Me.Controls
            Call SetControlValue(obj)
        Next
        Call EnabledControl(True)
        Call SetErrorProvider()


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

    Private Sub GenComBo()

        dtCboCustomer = (New classDyedOutSample).GetComBoCustomer()
        bsCboCustomer.DataSource = dtCboCustomer
        cboCustomer.DataSource = bsCboCustomer
        cboCustomer.DisplayMember = "name"
        cboCustomer.ValueMember = "customer_id"

        dtcboDocType = (New classMaster).GetDocType
        bscboDocType.DataSource = dtcboDocType
        cboDocType.DataSource = bscboDocType
        cboDocType.DisplayMember = "name"
        cboDocType.ValueMember = "doctyp"
        cboDocType.SelectedValue = "M"

        'dtcboEmp = (New classMaster).comboEmployee(strUserID:=Userinfo.UserID)
        bscboEmp.DataSource = (New classMaster).GetEmp
        cboempcd.DataSource = bscboEmp
        cboempcd.DisplayMember = "empname"
        cboempcd.ValueMember = "empcd"


    End Sub

    Private Sub InitDataBinding()

        dtDoutNew = (New classDyedOutSample).GetGridDoutNewByOutno(StrOutno:=txtOutno.Text.Trim)

        bsDoutNew.DataSource = dtDoutNew

        Call BindingData() '
    End Sub

    Private Sub BindingData()
        Call ClearDataBindings()

        txtaddr1.DataBindings.Add("text", bsCboCustomer, "addr1")
        'txtOutno.DataBindings.Add("text", bsDoutNew, "outno")
        'dtpOutDt.DataBindings.Add("Value", bsDoutNew, "outdt")
        'cboCustomer.DataBindings.Add("SelectedValue", bsDoutNew, "customer_id")
        'cboDocType.DataBindings.Add("SelectedValue", bsDoutNew, "doctyp")
        'cboempcd.DataBindings.Add("SelectedValue", bsDoutNew, "empcd")

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

    Private Sub LoadGrdDoutStock()

        Dim dt As DataTable = (New classDyedOutSample).GetSampleStock(StrDesignNo:=txtDesignNo.Text,
                                                              StrRefdesno:=txtRefdesno.Text,
                                                              StrLot:=txtLot.Text,
                                                              StrCol:=txtCol.Text)

        Call BindGrdDoutStock(dt)

    End Sub

    Private Sub BindGrdDoutStock(ByVal dt As DataTable)
        dtStockD = dt
        bsStockD.DataSource = dtStockD
        grdDoutStock.AutoGenerateColumns = False
        grdDoutStock.DataSource = bsStockD.DataSource

    End Sub
    Private Sub LoadGrdDOutNewByPackNo()

        Dim dt As DataTable = (New classDyedOutSample).GetGridDoutNewByPackno(StrPackno:=txtpackno.Text.Trim)
        If dt.Rows.Count > 0 Then BindtxtDoutNew(dt)
        Call BindGrdDoutNew(dt)

    End Sub

    'Private Sub LoadGrdDOutNewByOutNo()

    '    Dim dt As DataTable = (New classDyedOutSample).GetGridDoutNewByOutno(StrOutno:=txtOutno.Text.Trim)
    '    If dt.Rows.Count > 0 Then BindtxtDoutNew(dt)
    '    Call BindGrdDoutNew(dt)

    'End Sub

    Private Sub BindtxtDoutNew(ByVal dt As DataTable)
        dtDoutNew = dt

        bsDoutNew.DataSource = dtDoutNew

        txtpackno.Text = dtDoutNew.Rows(0)("packno")
        If (New clsConfig).IsNull(dtDoutNew.Rows(0)("packdt"), CDate("01/01/1900")) = CDate("01/01/1900") Then
            dtpPackdt.Value = Now
            dtpPackdt.Checked = False
        Else
            dtpPackdt.Value = dtDoutNew.Rows(0)("packdt")
            dtpPackdt.Checked = True
        End If
        txtOutno.Text = dtDoutNew.Rows(0)("outno")
        If (New clsConfig).IsNull(dtDoutNew.Rows(0)("outdt"), CDate("01/01/1900")) = CDate("01/01/1900") Then
            dtpOutDt.Value = Now
            dtpOutDt.Checked = False
        Else
            dtpOutDt.Value = dtDoutNew.Rows(0)("outdt")
            dtpOutDt.Checked = True
        End If
        cboCustomer.SelectedValue = dtDoutNew.Rows(0)("customer_id")
        cboDocType.SelectedValue = dtDoutNew.Rows(0)("doctyp")
        cboempcd.SelectedValue = dtDoutNew.Rows(0)("empcd")
        txtRemark.Text = dtDoutNew.Rows(0)("remark")

        If txtOutno.Text.Trim.Length > 0 Then
            BtnMakeDyedout.Enabled = False
        Else
            BtnMakeDyedout.Enabled = True
        End If

        txtpackno.Enabled = False
        dtpPackdt.Enabled = False
       

    End Sub

    Private Sub BindGrdDoutNew(ByVal dt As DataTable)
        dtDoutNew = dt

        bsDoutNew.DataSource = dtDoutNew

        grdDoutNew.AutoGenerateColumns = False
        grdDoutNew.DataSource = bsDoutNew.DataSource

    End Sub

    Private Sub cboDocType_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cboDocType.SelectedIndexChanged

    End Sub
    Private Sub Label7_Click(sender As System.Object, e As System.EventArgs) Handles Label7.Click

    End Sub

    Private Sub txtDesignNo_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles txtDesignNo.KeyDown
        If e.KeyCode = Keys.Enter Then
            bsStockD.Filter = "design_no like '%" & txtDesignNo.Text.Trim & "%'" & " and " &
                "refdesno like '%" & txtRefdesno.Text.Trim & "%'" & " and " &
                "lot like '%" & txtLot.Text.Trim & "%'" & " and " &
                "col like '%" & txtCol.Text.Trim & "%'"
        End If
    End Sub

    Private Sub txtDesignNo_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtDesignNo.KeyPress

    End Sub

    Private Sub txtDesignNo_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtDesignNo.TextChanged

    End Sub

    Private Sub txtRefdesno_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles txtRefdesno.KeyDown
        If e.KeyCode = Keys.Enter Then
            bsStockD.Filter = "refdesno like '%" & txtRefdesno.Text.Trim & "%'" & " and " &
                "lot like '%" & txtLot.Text.Trim & "%'" & " and " &
                "col like '%" & txtCol.Text.Trim & "%'" & " and " &
                "design_no like '%" & txtDesignNo.Text.Trim & "%'"
        End If
    End Sub

    Private Sub txtRefdesno_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtRefdesno.TextChanged

    End Sub

    Private Sub txtLot_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles txtLot.KeyDown
        If e.KeyCode = Keys.Enter Then
            bsStockD.Filter = "lot like '%" & txtLot.Text.Trim & "%'" & " and " &
                "col like '%" & txtCol.Text.Trim & "%'" & " and " &
                "design_no like '%" & txtDesignNo.Text.Trim & "%'" & " and " &
                "refdesno like '%" & txtRefdesno.Text.Trim & "%'"
        End If
    End Sub

    Private Sub txtLot_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtLot.TextChanged

    End Sub

    Private Sub txtCol_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles txtCol.KeyDown
        If e.KeyCode = Keys.Enter Then
            bsStockD.Filter = "col like '%" & txtCol.Text.Trim & "%'" & " and " &
                "design_no like '%" & txtDesignNo.Text.Trim & "%'" & " and " &
                "refdesno like '%" & txtRefdesno.Text.Trim & "%'" & " and " &
                "design_no like '%" & txtDesignNo.Text.Trim & "%'"

        End If
    End Sub

    Private Sub txtCol_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtCol.TextChanged

    End Sub

    Private Sub btnMoveLeft_Click(sender As System.Object, e As System.EventArgs) Handles btnMoveLeft.Click
        If grdDoutStock.Height > 200 Then
            grdDoutStock.Height = grdDoutStock.Height - 100
            lbStockOut.Top = grdDoutStock.Bottom + 5
            btnMoveLeft.Top = grdDoutStock.Bottom + 5
            btnMoveRight.Top = grdDoutStock.Bottom + 5
            btnAdd.Top = grdDoutStock.Bottom + 5
            btnDel.Top = grdDoutStock.Bottom + 5
            btnDelAll.Top = grdDoutStock.Bottom + 5
            txtSelectRolls.Top = grdDoutStock.Bottom + 5
            lblStockRoll.Top = grdDoutStock.Bottom + 5
            txtSelectKgs.Top = grdDoutStock.Bottom + 5
            lblStockKgs.Top = grdDoutStock.Bottom + 5
            txtSelectMts.Top = grdDoutStock.Bottom + 5
            lblStockMts.Top = grdDoutStock.Bottom + 5
            txtSelectYds.Top = grdDoutStock.Bottom + 5
            lblStockYds.Top = grdDoutStock.Bottom + 5
            grdDoutNew.Top = btnMoveLeft.Bottom
            grdDoutNew.Height = grdDoutNew.Height + 100
        End If
    End Sub

    Private Sub btnMoveRight_Click(sender As System.Object, e As System.EventArgs) Handles btnMoveRight.Click
        If grdDoutNew.Height > 200 Then
            grdDoutStock.Height = grdDoutStock.Height + 100
            lbStockOut.Top = grdDoutStock.Bottom + 5
            btnMoveLeft.Top = grdDoutStock.Bottom + 5
            btnMoveRight.Top = grdDoutStock.Bottom + 5
            btnAdd.Top = grdDoutStock.Bottom + 5
            btnDel.Top = grdDoutStock.Bottom + 5
            btnDelAll.Top = grdDoutStock.Bottom + 5
            txtSelectRolls.Top = grdDoutStock.Bottom + 5
            lblStockRoll.Top = grdDoutStock.Bottom + 5
            txtSelectKgs.Top = grdDoutStock.Bottom + 5
            lblStockKgs.Top = grdDoutStock.Bottom + 5
            txtSelectMts.Top = grdDoutStock.Bottom + 5
            lblStockMts.Top = grdDoutStock.Bottom + 5
            txtSelectYds.Top = grdDoutStock.Bottom + 5
            lblStockYds.Top = grdDoutStock.Bottom + 5
            grdDoutNew.Top = btnMoveLeft.Bottom + 5
            grdDoutNew.Height = grdDoutNew.Height - 100
        End If
    End Sub

    Private Sub btnAdd_Click(sender As System.Object, e As System.EventArgs) Handles btnAdd.Click
        Call CheckGrdStock()
        'If MessageBox.Show("Would you like to add selected Roll No. from left grid to right grid ?" & vbCrLf & "คุณต้องการเพิ่มม้วนที่เลือกไว้ด้านซ้ายเพื่อนำไปย้อมด้านขวาใช่หรือไม่ ?", "System Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.No Then Exit Sub
        Call AddRollNoNew()
        ' Call CompareTwoGrids()

        Call ClearGrdStockSeleted()
        Call ClearGrdNewSeleted()

        Call SumGridStock()
        Call SumGridNew()
    End Sub

    Private Sub ClearGrdStockSeleted()
        Dim i As Integer = 0
        Dim rolls As Integer = 0
        Dim dt As DataTable = grdDoutStock.DataSource
        For i = 0 To dt.Rows.Count - 1
            If dt.Rows(i).RowState <> DataRowState.Deleted Then
                If CBool((New clsConfig).IsNull(dt.Rows(i)("sel"), False)) Then
                    rolls = rolls + 1
                    dt.Rows(i)("sel") = False
                End If
            End If
        Next
    End Sub


    Private Sub ClearGrdNewSeleted()
        Dim i As Integer = 0
        Dim rolls As Integer = 0
        Dim dt As DataTable = grdDoutNew.DataSource
        For i = 0 To dt.Rows.Count - 1
            If dt.Rows(i).RowState <> DataRowState.Deleted Then
                If CBool((New clsConfig).IsNull(dt.Rows(i)("sel"), False)) Then
                    rolls = rolls + 1
                    dt.Rows(i)("sel") = False
                End If
            End If
        Next
    End Sub

    Private Function CheckGrdStock() As Boolean
        If grdDoutStock.DataSource Is Nothing Then Return False
        If grdDoutStock.Rows.Count = 0 Then Return False
        Dim i As Integer = 0
        For i = 0 To grdDoutStock.Rows.Count - 1
            If CBool(grdDoutStock.Rows(i).Cells("grdDoutStockSel").Value) Then Return True
        Next
        Return False
    End Function

    Private Sub AddRollNoNew()
        If grdDoutStock.Rows.Count > 0 Then
            Dim config As New clsConfig
            Dim dt As DataTable = grdDoutStock.DataSource
            Dim dt2 As DataTable = grdDoutNew.DataSource
            Dim dr As DataRow
            Dim msg As String = ""
            Dim i As Integer = 0
            Dim j As Integer = 0
            For i = 0 To dt.Rows.Count - 1
                If dt.Rows(i).RowState <> DataRowState.Deleted Then
                    If CBool(dt.Rows(i)("sel")) Then
                        If Not CheckDuplicate(dt.Rows(i)("roll_no_d").ToString.Trim, dt.Rows(i)("col").ToString.Trim, dt2.Copy()) Then
                            dr = dt2.NewRow
                            For j = 0 To dt2.Columns.Count - 1
                                dr(dt2.Columns(j).ColumnName.Trim) = dt.Rows(i)(dt2.Columns(j).ColumnName.Trim)
                            Next
                            dt2.Rows.Add(dr)
                        Else
                            dr = dt2.NewRow
                            For j = 0 To dt2.Columns.Count - 1
                                dr(dt2.Columns(j).ColumnName.Trim) = dt.Rows(i)(dt2.Columns(j).ColumnName.Trim)
                            Next
                            'MessageBox.Show("คุณกำลัง เลือกม้วนเดิมอยู่ ไม่มีอะไรเราแค่แจ้งเตือนเฉยๆ", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            dt2.Rows.Add(dr)

                        End If
                    End If
                End If

            Next
        End If

        'Call SumGridNew()

    End Sub

    Private Function CheckDuplicate(ByVal strRollNoD As String, ByVal strCol As String, ByVal dt As DataTable) As Boolean
        If dt.Rows.Count > 0 Then
            Dim i As Integer = 0
            For i = 0 To dt.Rows.Count - 1
                If dt.Rows(i).RowState <> DataRowState.Deleted Then
                    If dt.Rows(i)("roll_no_d").ToString.Trim = strRollNoD _
                    And dt.Rows(i)("col").ToString.Trim = strCol Then Return True
                End If
            Next
        End If
        Return False
    End Function


    Private Sub CompareTwoGrids()

        Dim i As Integer
        Dim j As Integer

        For i = 0 To Me.grdDoutNew.Rows.Count - 1
            j = 0
            Do While Me.grdDoutStock.Rows.Count - 1 >= 0 And j <= Me.grdDoutStock.Rows.Count - 1
                If Me.grdDoutStock.Rows(j).Cells("grdDoutStockRollNoD").Value.ToString.Trim = Me.grdDoutNew.Rows(i).Cells("grdDoutNewRollNoD").Value.ToString.Trim Then
                    Dim dgvRow As New DataGridViewRow
                    dgvRow = Me.grdDoutStock.Rows(j)


                    'Me.grdDoutStock.Rows(j).Cells("grdDoutStockKg").Value = Me.grdDoutStock.Rows(j).Cells("grdDoutStockKg").Value - Me.grdDoutNew.Rows(i).Cells("grdDoutNewRequestKg").Value
                    'Me.grdDoutStock.Rows(j).Cells("grdDoutStockRequestKg").Value = Me.grdDoutStock.Rows(j).Cells("grdDoutStockKg").Value

                    'If Me.grdDoutStock.Rows(j).Cells("grdDoutStockRequestKg").Value <= 0 Then
                    'Me.grdDoutStock.Rows.Remove(dgvRow)
                    ' End If
                    'If Me.grdDoutStock.Rows(j).Cells("grdDoutStockRequestMts").Value <= 0 Then
                    '    Me.grdDoutStock.Rows.Remove(dgvRow)
                    'End If
                    'If Me.grdDoutStock.Rows(j).Cells("grdDoutStockRequestYds").Value <= 0 Then
                    '    Me.grdDoutStock.Rows.Remove(dgvRow)
                    'End If
                    j = j + 1
                Else
                    j = j + 1
                End If
            Loop
        Next

        Call SumGridStock()
        Call SumGridNew()
    End Sub

    Private Sub SumGridNew()
        Dim i As Integer = 0
        Dim rolls As Integer = 0
        Dim kgs As Double = 0
        Dim yds As Double = 0
        Dim mts As Double = 0
        Dim dt As DataTable = grdDoutNew.DataSource
        For i = 0 To dt.Rows.Count - 1
            If dt.Rows(i).RowState <> DataRowState.Deleted Then
                rolls = rolls + 1
                kgs = kgs + (New clsConfig).IsNull(dt.Rows(i)("request_kg"), 0)
                yds = yds + (New clsConfig).IsNull(dt.Rows(i)("request_yds"), 0)
                mts = mts + (New clsConfig).IsNull(dt.Rows(i)("request_mts"), 0)
            End If
        Next

        txtSelectedRolls.Text = Format(rolls, "#,###")
        txtSelectedKgs.Text = Format(kgs, "#,###.#0")
        txtSelectedYds.Text = Format(yds, "#,###.#0")
        txtSelectedMts.Text = Format(mts, "#,###.#0")

    End Sub

    Private Sub SumGridStock()
        Dim i As Integer = 0
        Dim rolls As Integer = 0
        Dim kgs As Double = 0
        Dim yds As Double = 0
        Dim mts As Double = 0
        ' Dim no_of_units As Integer = 0 ' Sitthana 09/01/2018
        Dim dt As DataTable = grdDoutStock.DataSource
        For i = 0 To dt.Rows.Count - 1
            If dt.Rows(i).RowState <> DataRowState.Deleted Then
                If CBool((New clsConfig).IsNull(dt.Rows(i)("sel"), False)) Then
                    rolls = rolls + 1
                    kgs = kgs + (New clsConfig).IsNull(dt.Rows(i)("request_kg"), 0)
                    yds = yds + (New clsConfig).IsNull(dt.Rows(i)("request_yds"), 0)
                    mts = mts + (New clsConfig).IsNull(dt.Rows(i)("request_mts"), 0)
                    'no_of_units = no_of_units + (New clsConfig).IsNull(dt.Rows(i)("no_of_units"), 0)
                End If
            End If
        Next
        txtSelectRolls.Text = Format(rolls, "#,###")
        txtSelectKgs.Text = Format(kgs, "#,###.#0")
        txtSelectYds.Text = Format(yds, "#,###.#0")
        txtSelectMts.Text = Format(mts, "#,###.#0")

    End Sub

    Private Sub btnDel_Click(sender As System.Object, e As System.EventArgs) Handles btnDel.Click
        If Not CheckGrdNew() Then Exit Sub
        'If MessageBox.Show("Would you like to delete selected Roll No. in right grid ?" & vbCrLf & "คุณต้องการลบม้วนที่เลือกไว้เพื่อย้อมในด้านขวาออกใช่หรือไม่ ?", "System Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.No Then Exit Sub
        Call AddRollNoStock()
        If grdDoutNew.CurrentRow.Index >= 0 Then Call DeleteRollNoNew("SOME")
        'Call CompareTwoGrids()

        Call ClearGrdNewSeleted()

        Call SumGridNew()


    End Sub

    Private Function CheckGrdNew() As Boolean
        If grdDoutNew.DataSource Is Nothing Then Return False
        If grdDoutNew.Rows.Count = 0 Then Return False
        Dim i As Integer = 0
        For i = 0 To grdDoutNew.Rows.Count - 1
            If CBool(grdDoutNew.Rows(i).Cells("grdDoutNewSel").Value) Then Return True
        Next
        Return False
    End Function


    Private Sub AddRollNoStock()
        If grdDoutNew.Rows.Count > 0 Then
            Dim config As New clsConfig
            Dim dt As DataTable = grdDoutNew.DataSource
            Dim dt2 As DataTable = grdDoutStock.DataSource
            Dim dr As DataRow
            Dim msg As String = ""
            Dim i As Integer = 0
            Dim j As Integer = 0
            For i = 0 To dt.Rows.Count - 1
                If dt.Rows(i).RowState <> DataRowState.Deleted Then
                    If CBool(dt.Rows(i)("sel")) Then
                        If Not CheckDuplicate(dt.Rows(i)("roll_no_d").ToString.Trim, dt.Rows(i)("col").ToString.Trim, dt2.Copy()) Then
                            dr = dt2.NewRow
                            For j = 0 To dt2.Columns.Count - 1
                                dr(dt2.Columns(j).ColumnName.Trim) = dt.Rows(i)(dt2.Columns(j).ColumnName.Trim)
                            Next
                            dt2.Rows.Add(dr)
                        Else

                        End If
                    End If
                End If
            Next
        End If

        'Call SumGridNew()

    End Sub

    Private Sub DeleteRollNoNew(ByVal strType As String)
        If grdDoutNew.Rows.Count > 0 Then
            Dim i As Integer = 0
            Dim dt As DataTable = grdDoutNew.DataSource
            If strType = "ALL" Then
                Call LoadGrdDOutNewByPackNo()
            Else
                Do While i < dt.Rows.Count
                    If dt.Rows.Count = 0 Then Exit Do
                    For i = 0 To dt.Rows.Count - 1
                        If Not dt.Rows(i).RowState = DataRowState.Deleted Then
                            If CBool(dt.Rows(i)("sel")) Then
                                dt.Rows(i).Delete()
                                Exit For
                            End If
                        End If
                    Next
                Loop
            End If
        End If
        'Call SumGrid()
    End Sub


    Private Sub btnSave_Click(sender As System.Object, e As System.EventArgs) Handles btnSave.Click
        blnCancel = False
        'Sitthana 20220624 Changed Windows.Forms.DialogResult To DialogResult
        Dim result As DialogResult ' Windows.Forms.DialogResult
        result = MessageBox.Show("Would you like to save Packing List Sample ?", "System Message", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button3)
        If result = DialogResult.Cancel Then blnCancel = True
        If result <> DialogResult.Yes Then Exit Sub

        If Not CheckData() Then Exit Sub

        If SaveData() Then

        End If
    End Sub

    Public Function CheckData() As Boolean

        If grdDoutNew.Rows.Count <= 0 Then
            MessageBox.Show("คุณยังไม่ได้เลือก ม้วน", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return False
            Exit Function
        End If

        If (New clsConfig).IsNull(cboCustomer.SelectedValue, 0) = 0 Then
            MessageBox.Show("คุณยังไม่ได้เลือก ลูกค้า", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return False
            Exit Function
        End If

        If (New clsConfig).IsNull(cboempcd.SelectedValue, "") = "" Then
            MessageBox.Show("คุณยังไม่ได้เลือก ผู้ขอ", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return False
            Exit Function
        End If


        Return True
    End Function

    Public Function CheckDataMakeDyedOut() As Boolean


        If Not (New classDyedOutSample).ValidateOutNo(StrOutno:=txtOutno.Text.Trim) Then
            MessageBox.Show("คุณทำ Sample Out ไปแล้ว ไม่สามารถเบิ้ลได้", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return False
            Exit Function
        End If

        If txtpackno.Text.Trim.Length = 0 Then
            MessageBox.Show("คุณยังไม่ได้เลือก PLS", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return False
            Exit Function
        End If

        If grdDoutNew.Rows.Count <= 0 Then
            MessageBox.Show("คุณยังไม่ได้เลือก ม้วน", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return False
            Exit Function
        End If

        If (New clsConfig).IsNull(cboCustomer.SelectedValue, 0) = 0 Then
            MessageBox.Show("คุณยังไม่ได้เลือก ลูกค้า", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return False
            Exit Function
        End If

        If (New clsConfig).IsNull(cboempcd.SelectedValue, "") = "" Then
            MessageBox.Show("คุณยังไม่ได้เลือก ผู้ขอ", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return False
            Exit Function
        End If

        Return True
    End Function

    Public Function SaveData() As Boolean
        Dim dt As DataTable = bsDoutNew.DataSource
        Dim dv_add As New DataView(dt, "", "", DataViewRowState.Added)
        Dim dv_upd As New DataView(dt, "", "", DataViewRowState.ModifiedCurrent)
        Dim dv_del As New DataView(dt, "", "", DataViewRowState.Deleted)
        Dim msgerr As String = "'"

        Dim StrollsDO As New StrollsDO

        StrollsDO.StrOutno = txtOutno.Text
        If txtOutno.Text.Trim <> "" Then StrollsDO.DateOutdt = dtpOutDt.Value Else StrollsDO.DateOutdt = Nothing
        StrollsDO.Strpackno = txtpackno.Text
        If txtpackno.Text.Trim <> "" Then StrollsDO.Datepackdt = dtpPackdt.Value Else StrollsDO.Datepackdt = Nothing
        StrollsDO.Int32Cartno = "1"
        StrollsDO.StrDoctyp = cboDocType.SelectedValue
        StrollsDO.Int64CustomerID = cboCustomer.SelectedValue

        StrollsDO.StrEmpcd = cboempcd.SelectedValue 'Request 
        StrollsDO.strRemark = txtRemark.Text.Trim

        If (New classDyedOutSample).ProductionDOutSavePackNo(StrollsDO:=StrollsDO, DV_ADD:=dv_add, DV_UPD:=dv_upd, DV_DEL:=dv_del, msgerr:=msgerr, Userinfo:=Userinfo) Then
            MessageBox.Show("บันทึกสำเร็จ PACK No. :" & StrollsDO.Strpackno & "", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtpackno.Text = StrollsDO.Strpackno
            Call LoadGrdDoutStock()
            Call LoadGrdDOutNewByPackNo()
        Else
            MessageBox.Show(msgerr, "System Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

    End Function

    Private Sub txtOutno_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles txtOutno.KeyDown
        'If e.KeyCode = Keys.Enter Then
        'Call LoadGrdDOutNewByOutNo()
        'End If
    End Sub

    Private Sub txtOutno_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtOutno.KeyPress

    End Sub

    Private Sub txtOutno_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtOutno.TextChanged

    End Sub

    Private Sub btnNew_Click(sender As System.Object, e As System.EventArgs) Handles btnNew.Click
        Call frmDyedOutSample_Load(sender:=sender, e:=e)


        'Me.WindowState = FormWindowState.Maximized

        'Call InitControl()

        'Call GenComBo()

        'Call InitDataBinding()

        'Call LoadGrdDInFromDout()
        'Call LoadGrdDInNew()
    End Sub

    Private Sub btnSearchDFNo_Click(sender As System.Object, e As System.EventArgs) Handles btnSearchCustomers.Click
        Dim frm As New frmSearchCustomers
        frm.ShowDialog(Me)
        Me.Cursor = Cursors.WaitCursor
        If (New clsConfig).IsNull(frm.pCustomerID, 0) <> 0 Then
            cboCustomer.SelectedValue = frm.pCustomerID
        End If

        Me.Cursor = Cursors.Default
        frm.Dispose()
    End Sub

    Private Sub PrintSampleOut_Click(sender As System.Object, e As System.EventArgs) Handles btnPrintSampleOut.Click

        If txtOutno.Text.Length = 0 Then Exit Sub

        Const rptFileName = "rptSamPleOut.rpt"

        If clsuser.ReportPath = "" Then clsuser.ReportPath = clsuser.ReportPath
        If Not (New clsConfig).CheckReport(clsuser.ReportPath, rptFileName) Then Exit Sub
        Dim frm As New frmReport
        Dim rpt As New CrystalDecisions.CrystalReports.Engine.ReportDocument
        Me.Cursor = Cursors.WaitCursor
        rpt.Load(clsuser.ReportPath & rptFileName)
        rpt.DataSourceConnections.Item(0).SetConnection((New ClassConnection).servername, (New ClassConnection).database, False)
        rpt.DataSourceConnections.Item(0).SetLogon((New ClassConnection).Userid, (New ClassConnection).Password)
        rpt.VerifyDatabase()
        rpt.SetParameterValue("@docno", txtOutno.Text.Trim)


        frm.Title = "Dyed Out"
        frm.CRViewer.ReportSource = rpt
        frm.MdiParent = Me.ParentForm
        frm.Show()
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub BtnPrintTag_Click(sender As System.Object, e As System.EventArgs) Handles BtnPrintTag.Click


        Dim clsConfig As New clsConfig
        Dim rptFileName = "rptDOutBarcode.rpt"
        If clsuser.ReportPath = "" Then clsuser.ReportPath = clsuser.ReportPath

        If Not clsConfig.CheckReport(clsuser.ReportPath, rptFileName) Then Exit Sub
        Dim frm As New frmReport
        Dim rpt As New CrystalDecisions.CrystalReports.Engine.ReportDocument
        Dim stype As String = ""
        Dim ord As String = ""
        Me.Cursor = Cursors.WaitCursor

        rpt.Load(clsuser.ReportPath & rptFileName)
        rpt.DataSourceConnections.Item(0).SetConnection((New ClassConnection).servername, (New ClassConnection).database, False)
        rpt.DataSourceConnections.Item(0).SetLogon((New ClassConnection).Userid, (New ClassConnection).Password)
        rpt.VerifyDatabase()

        'If txtOutno.Text.Trim.Length = 0 Then
        rpt.SetParameterValue("@docno", txtpackno.Text.Trim)
        'Else
        'rpt.SetParameterValue("@docno", txtOutno.Text.Trim)
        'End If

        frm.Title = "Sample Out Barcode"
        frm.CRViewer.ReportSource = rpt
        frm.MdiParent = Me.ParentForm
        frm.Show()
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub PrintTag(ByVal TagType As String)


        Dim clsConfig As New clsConfig
        Dim rptFileName = "rptDOutBarcode.rpt"
        If clsuser.ReportPath = "" Then clsuser.ReportPath = clsuser.ReportPath

        If Not clsConfig.CheckReport(clsuser.ReportPath, rptFileName) Then Exit Sub
        Dim frm As New frmReport
        Dim rpt As New CrystalDecisions.CrystalReports.Engine.ReportDocument
        Dim stype As String = ""
        Dim ord As String = ""
        Me.Cursor = Cursors.WaitCursor

        rpt.Load(clsuser.ReportPath & rptFileName)
        rpt.DataSourceConnections.Item(0).SetConnection((New ClassConnection).servername, (New ClassConnection).database, False)
        rpt.DataSourceConnections.Item(0).SetLogon((New ClassConnection).Userid, (New ClassConnection).Password)
        rpt.VerifyDatabase()

        'If txtOutno.Text.Trim.Length = 0 Then
        rpt.SetParameterValue("@docno", txtpackno.Text.Trim)
        rpt.SetParameterValue("@tag_type", TagType)
        'Else
        'rpt.SetParameterValue("@docno", txtOutno.Text.Trim)
        'End If

        frm.Title = "Sample Out Barcode"
        frm.CRViewer.ReportSource = rpt
        frm.MdiParent = Me.ParentForm
        frm.Show()
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub grdDoutStock_CellContentClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles grdDoutStock.CellContentClick
        If grdDoutStock.CurrentCell.IsInEditMode Then grdDoutStock.EndEdit()
    End Sub

    Private Sub grdDoutNew_CellContentClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles grdDoutNew.CellContentClick
        If grdDoutNew.CurrentCell.IsInEditMode Then grdDoutNew.EndEdit()
    End Sub

    Private Sub grdDoutNew_CellEndEdit(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles grdDoutNew.CellEndEdit
        If e.RowIndex < 0 Or e.ColumnIndex < 0 Then Exit Sub
        If grdDoutNew.Columns(e.ColumnIndex).Name = "grdDoutNewRequestKg" Or
         grdDoutNew.Columns(e.ColumnIndex).Name = "grdDoutNewRequestMts" Or
         grdDoutNew.Columns(e.ColumnIndex).Name = "grdDoutNewRequestYds" Then

            If CBool(chkAutoCalculate.Checked) Then

                If (New clsConfig).IsNull(grdDoutNew.CurrentRow.Cells("grdDoutNewRequestMtkg").Value, 0) = 0 Then MessageBox.Show("ไม่พบ Mtkg", "System Message")

                If grdDoutNew.Columns(e.ColumnIndex).Name = "grdDoutNewRequestKg" Then
                    'If Val(grdDoutNew.CurrentRow.Cells("grdDoutNewRequestMtkg").Value) > 0 Then grdDoutNew.CurrentRow.Cells("grdDoutNewRequestMts").Value = FormatNumber(grdDoutNew.CurrentRow.Cells("grdDoutNewRequestKg").Value * grdDoutNew.CurrentRow.Cells("grdDoutNewRequestMtkg").Value, 2, TriState.False, TriState.False, TriState.False)
                    If Val(grdDoutNew.CurrentRow.Cells("grdDoutNewRequestMtkg").Value) > 0 Then grdDoutNew.CurrentRow.Cells("grdDoutNewRequestMts").Value = FormatNumber(Math.Round(grdDoutNew.CurrentRow.Cells("grdDoutNewRequestKg").Value * grdDoutNew.CurrentRow.Cells("grdDoutNewRequestMtkg").Value, 2, MidpointRounding.AwayFromZero), 2, TriState.False, TriState.False, TriState.False)
                    'grdDoutNew.CurrentRow.Cells("grdDoutNewRequestYds").Value = FormatNumber(Me.grdDoutNew.Rows(e.RowIndex).Cells("grdDoutNewRequestMts").Value / 0.9144, 2, TriState.False, TriState.False, TriState.False)
                    grdDoutNew.CurrentRow.Cells("grdDoutNewRequestYds").Value = FormatNumber(Math.Round(Me.grdDoutNew.Rows(e.RowIndex).Cells("grdDoutNewRequestMts").Value / 0.9144, 2, MidpointRounding.AwayFromZero), 2, TriState.False, TriState.False, TriState.False)

                End If
                If grdDoutNew.Columns(e.ColumnIndex).Name = "grdDoutNewRequestYds" Then
                    'grdDoutNew.CurrentRow.Cells("grdDoutNewRequestMts").Value = FormatNumber(grdDoutNew.CurrentRow.Cells("grdDoutNewRequestYds").Value * 0.9144, 2, TriState.False, TriState.False, TriState.False)
                    grdDoutNew.CurrentRow.Cells("grdDoutNewRequestMts").Value = FormatNumber(Math.Round(grdDoutNew.CurrentRow.Cells("grdDoutNewRequestYds").Value * 0.9144, 2, MidpointRounding.AwayFromZero), 2, TriState.False, TriState.False, TriState.False)
                    'If Val(grdDoutNew.CurrentRow.Cells("grdDoutNewRequestMtkg").Value) > 0 Then grdDoutNew.CurrentRow.Cells("grdDoutNewRequestKg").Value = FormatNumber(grdDoutNew.CurrentRow.Cells("grdDoutNewRequestMts").Value / grdDoutNew.CurrentRow.Cells("grdDoutNewRequestMtkg").Value, 2, TriState.False, TriState.False, TriState.False)
                    If Val(grdDoutNew.CurrentRow.Cells("grdDoutNewRequestMtkg").Value) > 0 Then grdDoutNew.CurrentRow.Cells("grdDoutNewRequestKg").Value = FormatNumber(Math.Round(grdDoutNew.CurrentRow.Cells("grdDoutNewRequestMts").Value / grdDoutNew.CurrentRow.Cells("grdDoutNewRequestMtkg").Value, 2, MidpointRounding.AwayFromZero), 2, TriState.False, TriState.False, TriState.False)
                End If
                If grdDoutNew.Columns(e.ColumnIndex).Name = "grdDoutNewRequestMts" Then
                    'grdDoutNew.CurrentRow.Cells("grdDoutNewRequestYds").Value = FormatNumber(grdDoutNew.CurrentRow.Cells("grdDoutNewRequestMts").Value / 0.9144, 2, TriState.False, TriState.False, TriState.False)
                    grdDoutNew.CurrentRow.Cells("grdDoutNewRequestYds").Value = FormatNumber(Math.Round(grdDoutNew.CurrentRow.Cells("grdDoutNewRequestMts").Value / 0.9144, 2, MidpointRounding.AwayFromZero), 2, TriState.False, TriState.False, TriState.False)
                    'If Val(grdDoutNew.CurrentRow.Cells("grdDoutNewRequestMtkg").Value) > 0 Then grdDoutNew.CurrentRow.Cells("grdDoutNewRequestKg").Value = FormatNumber(grdDoutNew.CurrentRow.Cells("grdDoutNewRequestMts").Value / grdDoutNew.CurrentRow.Cells("grdDoutNewRequestMtkg").Value, 2, TriState.False, TriState.False, TriState.False)
                    If Val(grdDoutNew.CurrentRow.Cells("grdDoutNewRequestMtkg").Value) > 0 Then grdDoutNew.CurrentRow.Cells("grdDoutNewRequestKg").Value = FormatNumber(Math.Round(grdDoutNew.CurrentRow.Cells("grdDoutNewRequestMts").Value / grdDoutNew.CurrentRow.Cells("grdDoutNewRequestMtkg").Value, 2, MidpointRounding.AwayFromZero), 2, TriState.False, TriState.False, TriState.False)
                End If

            End If

            If (New clsConfig).IsNull(grdDoutNew.CurrentRow.Cells("grdDoutNewRequestKg").Value, 0) > 0 Or
            (New clsConfig).IsNull(grdDoutNew.CurrentRow.Cells("grdDoutNewRequestMts").Value, 0) > 0 Or
            (New clsConfig).IsNull(grdDoutNew.CurrentRow.Cells("grdDoutNewRequestYds").Value, 0) > 0 Then

                grdDoutNew.CurrentRow.Cells("grdDoutNewSel").Value = True
            End If

        End If

        Call SumGridNew()
    End Sub

    Private Function CheckDelRow(ByVal dt As DataTable) As Integer
        Dim i As Integer = 0
        Dim j As Integer = 0
        For i = 0 To dt.Rows.Count - 1
            If dt.Rows(i).RowState = DataRowState.Deleted Then j = j + 1
        Next
        Return j
    End Function

    Private Sub grdDoutStock_CellEndEdit(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles grdDoutStock.CellEndEdit
        If e.RowIndex < 0 Or e.ColumnIndex < 0 Then Exit Sub
        If grdDoutStock.Columns(e.ColumnIndex).Name = "grdDoutStockRequestkg" Or
         grdDoutStock.Columns(e.ColumnIndex).Name = "grdDoutStockRequestMts" Or
         grdDoutStock.Columns(e.ColumnIndex).Name = "grdDoutStockRequestYds" Then
            If CBool(chkAutoCalculate.Checked) Then
                If (New clsConfig).IsNull(grdDoutStock.CurrentRow.Cells("grdDoutStockRequestMtkg").Value, 0) = 0 Then MessageBox.Show("ไม่พบ Mtkg", "System Message")

                If grdDoutStock.Columns(e.ColumnIndex).Name = "grdDoutStockRequestkg" Then
                    If Val(grdDoutStock.CurrentRow.Cells("grdDoutStockRequestMtkg").Value) > 0 Then grdDoutStock.CurrentRow.Cells("grdDoutStockRequestMts").Value = FormatNumber(grdDoutStock.CurrentRow.Cells("grdDoutStockRequestKg").Value * grdDoutStock.CurrentRow.Cells("grdDoutStockRequestMtkg").Value, 2, TriState.False, TriState.False, TriState.False)
                    grdDoutStock.CurrentRow.Cells("grdDoutStockRequestYds").Value = FormatNumber(Me.grdDoutStock.Rows(e.RowIndex).Cells("grdDoutStockRequestMts").Value / 0.9144, 2, TriState.False, TriState.False, TriState.False)
                End If
                If grdDoutStock.Columns(e.ColumnIndex).Name = "grdDoutStockRequestYds" Then
                    grdDoutStock.CurrentRow.Cells("grdDoutStockRequestMts").Value = FormatNumber(grdDoutStock.CurrentRow.Cells("grdDoutStockRequestYds").Value * 0.9144, 2, TriState.False, TriState.False, TriState.False)
                    If Val(grdDoutStock.CurrentRow.Cells("grdDoutStockRequestMtkg").Value) > 0 Then grdDoutStock.CurrentRow.Cells("grdDoutStockRequestKg").Value = FormatNumber(grdDoutStock.CurrentRow.Cells("grdDoutStockRequestMts").Value / grdDoutStock.CurrentRow.Cells("grdDoutStockRequestMtkg").Value, 2, TriState.False, TriState.False, TriState.False)
                    'If Val(grdDoutStock.CurrentRow.Cells("grdDoutStockRequestYdkg").Value) > 0 Then grdDoutStock.CurrentRow.Cells("grdDoutStockRequestKg").Value = FormatNumber(grdDoutStock.CurrentRow.Cells("grdDoutStockRequestYds").Value / grdDoutStock.CurrentRow.Cells("grdDoutStockRequestYdkg").Value, 2, TriState.False, TriState.False, TriState.False)
                End If
                If grdDoutStock.Columns(e.ColumnIndex).Name = "grdDoutStockRequestMts" Then
                    grdDoutStock.CurrentRow.Cells("grdDoutStockRequestYds").Value = FormatNumber(grdDoutStock.CurrentRow.Cells("grdDoutStockRequestMts").Value / 0.9144, 2, TriState.False, TriState.False, TriState.False)
                    If Val(grdDoutStock.CurrentRow.Cells("grdDoutStockRequestMtkg").Value) > 0 Then grdDoutStock.CurrentRow.Cells("grdDoutStockRequestKg").Value = FormatNumber(grdDoutStock.CurrentRow.Cells("grdDoutStockRequestMts").Value / grdDoutStock.CurrentRow.Cells("grdDoutStockRequestMtkg").Value, 2, TriState.False, TriState.False, TriState.False)
                End If

            End If

        End If

        If (New clsConfig).IsNull(grdDoutStock.CurrentRow.Cells("grdDoutStockRequestKg").Value, 0) > 0 Or
            (New clsConfig).IsNull(grdDoutStock.CurrentRow.Cells("grdDoutStockRequestMts").Value, 0) > 0 Or
            (New clsConfig).IsNull(grdDoutStock.CurrentRow.Cells("grdDoutStockRequestYds").Value, 0) > 0 Then

            grdDoutStock.CurrentRow.Cells("grdDoutStockSel").Value = True
        End If

        Call SumGridStock()
    End Sub

    Private Sub btnDelAll_Click(sender As System.Object, e As System.EventArgs) Handles btnDelAll.Click

    End Sub

    Private Sub btnCancel_Click(sender As System.Object, e As System.EventArgs) Handles btnCancel.Click
        blnCancel = False
        'Sitthana 20220624 Changed Windows.Forms.DialogResult To DialogResult
        Dim result As DialogResult ' Windows.Forms.DialogResult
        result = MessageBox.Show("Would you like to Cancel PLS ?", "System Message", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button3)
        If result = DialogResult.Cancel Then blnCancel = True
        If result <> DialogResult.Yes Then Exit Sub

        If Not CheckDataCancel() Then Exit Sub

        Call CancelPLS()
    End Sub

    Private Function CheckDataCancel() As Boolean
        If txtpackno.Text.Trim.Length = 0 Then
            MessageBox.Show("คุณยังไม่ได้เลือก Packno", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return False
            Exit Function
        End If

        Return True
    End Function

    Private Function CancelPLS() As Boolean
        Dim config As New clsConfig

        Dim DOUTHeader As New StrollsDO
        Dim msgerr As String = ""

        'Dim OUTDT As String = dtpOutDt.Value.ToString("yyyyMMdd")
        ' Dim USERID As String = clsuser.UserID
        'Dim CheckNEW As String = txtOutno.Text.Trim


        Dim dtd As DataTable = grdDoutNew.DataSource
        Dim dv_dtd_add As New DataView(dtd, "", "", DataViewRowState.Added)
        Dim dv_dtd_upd As New DataView(dtd, "", "", DataViewRowState.ModifiedCurrent)
        Dim dv_dtd_del As New DataView(dtd, "", "", DataViewRowState.Deleted)

        DOUTHeader.Strpackno = txtpackno.Text.Trim
        DOUTHeader.Datepackdt = dtpPackdt.Value.Date

        DOUTHeader.Strmsgerr = ""

        If (New classDyedOutSample).CANCELPLS(DOUTHeader, clsuser) Then

            MessageBox.Show("ยกเลิกสำเร็จ ", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Information)

            Me.WindowState = FormWindowState.Maximized
            Call InitControl()
            Call GenComBo()
            Call InitDataBinding()
            Call LoadGrdDoutStock()
            Call LoadGrdDOutNewByPackNo()

            CancelPLS = True
        Else
            CancelPLS = False
            MessageBox.Show(DOUTHeader.Strmsgerr, "System Message", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
        End If
    End Function

    Private Function CancelDYEDOUT() As Boolean
        Dim config As New clsConfig
        Dim objdb As New classDyedOutFromRequest
        Dim DOUTHeader As New classDyedOutFromRequest.DyedOutFromRequestHeader
        Dim msgerr As String = ""

        Dim OUTDT As String = dtpOutDt.Value.ToString("yyyyMMdd")
        Dim USERID As String = clsuser.UserID
        Dim CheckNEW As String = txtOutno.Text.Trim


        Dim dtd As DataTable = grdDoutNew.DataSource
        Dim dv_dtd_add As New DataView(dtd, "", "", DataViewRowState.Added)
        Dim dv_dtd_upd As New DataView(dtd, "", "", DataViewRowState.ModifiedCurrent)
        Dim dv_dtd_del As New DataView(dtd, "", "", DataViewRowState.Deleted)

        DOUTHeader.outno = txtOutno.Text.Trim
        DOUTHeader.outdt = dtpOutDt.Value.Date
        DOUTHeader.empcd = clsuser.UserID.Trim
        DOUTHeader.outreqtyp = cboDocType.SelectedValue
        DOUTHeader.msgerr = ""

        If objdb.CANCELDOUT(DOUTHeader, dtd, dv_dtd_add, dv_dtd_upd, dv_dtd_del, clsuser) Then

            MessageBox.Show("ยกเลิกสำเร็จ ", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ' txtOutno.Text = DOUTHeader.outno
            Call LoadGrdDoutStock()
            Call LoadGrdDOutNewByPackNo()
            CancelDYEDOUT = True

        Else
            CancelDYEDOUT = False
            MessageBox.Show(DOUTHeader.msgerr, "System Message", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
        End If
    End Function

    Private Sub txtpackno_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles txtpackno.KeyDown
        If e.KeyCode = Keys.Enter Then
            Call LoadGrdDOutNewByPackNo()
        End If
    End Sub

    Private Sub txtpackno_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtpackno.TextChanged

    End Sub

    Private Sub txtpackno_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtpackno.Validating

    End Sub

    Private Sub BtnMakeDyedout_Click(sender As System.Object, e As System.EventArgs) Handles BtnMakeDyedout.Click
        blnCancel = False
        'Sitthana 20220624 Changed Windows.Forms.DialogResult To DialogResult
        Dim result As DialogResult ' Windows.Forms.DialogResult
        result = MessageBox.Show("Would you like to Make Sample Out Sample ?", "System Message", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button3)
        If result = DialogResult.Cancel Then blnCancel = True
        If result <> DialogResult.Yes Then Exit Sub

        If Not CheckDataMakeDyedOut() Then Exit Sub

        If SaveDataOut() Then

        End If
    End Sub

    Private Function SaveDataOut() As Boolean
        Dim dt As DataTable = bsDoutNew.DataSource
        Dim dv_add As New DataView(dt, "", "", DataViewRowState.Added)
        Dim dv_upd As New DataView(dt, "", "", DataViewRowState.ModifiedCurrent)
        Dim dv_del As New DataView(dt, "", "", DataViewRowState.Deleted)
        Dim msgerr As String = "'"

        Dim StrollsDO As New StrollsDO

        StrollsDO.StrOutno = txtOutno.Text
        If txtpackno.Text.Trim <> "" Then StrollsDO.DateOutdt = dtpOutDt.Value Else StrollsDO.DateOutdt = Nothing
        StrollsDO.Strpackno = txtpackno.Text
        If txtpackno.Text.Trim <> "" Then StrollsDO.Datepackdt = dtpPackdt.Value Else StrollsDO.Datepackdt = Nothing
        StrollsDO.Int32Cartno = "1"
        StrollsDO.StrDoctyp = cboDocType.SelectedValue
        StrollsDO.Int64CustomerID = cboCustomer.SelectedValue

        StrollsDO.StrEmpcd = cboempcd.SelectedValue 'Request 


        If (New classDyedOutSample).ProductionDOutSaveOutNo(StrollsDO:=StrollsDO, msgerr:=msgerr, Userinfo:=Userinfo) Then
            MessageBox.Show("บันทึกสำเร็จ Out No. :" & StrollsDO.StrOutno & "", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtOutno.Text = StrollsDO.StrOutno
            Call LoadGrdDoutStock()
            Call LoadGrdDOutNewByPackNo()
            'Call LoadGrdDOutNewByOutNo() 'No Need to use
            Return True
        Else
            MessageBox.Show(msgerr, "System Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End If


    End Function

    Private Sub PrintPLS_Click(sender As System.Object, e As System.EventArgs) Handles btnPrintPLS.Click

        If txtpackno.Text.Length = 0 Then Exit Sub

        Const rptFileName = "rptPLS.rpt"

        If clsuser.ReportPath = "" Then clsuser.ReportPath = clsuser.ReportPath
        If Not (New clsConfig).CheckReport(clsuser.ReportPath, rptFileName) Then Exit Sub
        Dim frm As New frmReport
        Dim rpt As New CrystalDecisions.CrystalReports.Engine.ReportDocument
        Me.Cursor = Cursors.WaitCursor
        rpt.Load(clsuser.ReportPath & rptFileName)
        rpt.DataSourceConnections.Item(0).SetConnection((New classConnection).servername, (New classConnection).database, False)
        rpt.DataSourceConnections.Item(0).SetLogon((New classConnection).Userid, (New classConnection).Password)
        rpt.VerifyDatabase()
        rpt.SetParameterValue("@docno", txtpackno.Text.Trim)


        frm.Title = "Dyed Out"
        frm.CRViewer.ReportSource = rpt
        frm.MdiParent = Me.ParentForm
        frm.Show()
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub txtSelectMts_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtSelectMts.TextChanged

    End Sub

    Private Sub txtSelectYds_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtSelectYds.TextChanged

    End Sub

    Private Sub txtOutno_Validated(sender As Object, e As System.EventArgs) Handles txtOutno.Validated

    End Sub

    Private Sub TagToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles btnPrinttagForSample.Click
        Call PrintTag("SAMPLE")
    End Sub

    Private Sub btnPrinttagForSale_Click(sender As System.Object, e As System.EventArgs) Handles btnPrinttagForSales.Click
        Call PrintTag("SALES")
    End Sub

    Private Sub grdDoutStock_CellMouseUp(sender As System.Object, e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles grdDoutStock.CellMouseUp
        Dim Sum As Decimal
        Dim Count As Int64 = 0
        For Each dgvc As DataGridViewCell In grdDoutStock.SelectedCells
            If VarType(dgvc.Value) = VariantType.Decimal Or VarType(dgvc.Value) = VariantType.Integer Or VarType(dgvc.Value) = VariantType.Double Then
                Sum = Sum + dgvc.Value
            End If
            Count = Count + 1
        Next

        lblSum.Text = Sum
        lblCount.Text = Count
    End Sub

    Private Sub grdDoutNew_CellMouseUp(sender As System.Object, e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles grdDoutNew.CellMouseUp
        Dim Sum As Decimal
        Dim Count As Int64 = 0
        For Each dgvc As DataGridViewCell In grdDoutNew.SelectedCells
            If VarType(dgvc.Value) = VariantType.Decimal Or VarType(dgvc.Value) = VariantType.Integer Or VarType(dgvc.Value) = VariantType.Double Then
                Sum = Sum + dgvc.Value
            End If
            Count = Count + 1
        Next

        lblSum.Text = Sum
        lblCount.Text = Count
    End Sub

    Private Sub btnSearchPLS_Click(sender As System.Object, e As System.EventArgs) Handles btnSearchPLS.Click
        Dim frm As New frmDyedOutSampleSearchPLS
        frm.ShowDialog(Me)
        Me.Cursor = Cursors.WaitCursor
        If Not frm.pdrData Is Nothing Then
            txtpackno.Text = frm.pdrData("packno")
            Call LoadGrdDOutNewByPackNo()
        End If

        Me.Cursor = Cursors.Default
        frm.Dispose()

    End Sub
End Class