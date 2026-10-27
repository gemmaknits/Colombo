Public Class frmWOReservations
    Dim blnCancel As Boolean
    Dim clsConn As New classConnection
    Dim clsConfig As New clsConfig
    Dim clsUser As New classUserInfo

    Dim dtWOItems As New DataTable
    Dim bsWOtems As New BindingSource

    Dim dtProductionOrderLines As New DataTable
    Dim bsProductionOrderLines As New BindingSource
    Dim dtProductionLotsBalance As New DataTable
    Dim bsProductionLotsBalance As New BindingSource
    Dim dtReservations As New DataTable
    Dim bsReservations As New BindingSource

    Public Property UserInfo() As classUserInfo
        Get
            UserInfo = clsUser
        End Get
        Set(ByVal NewValue As classUserInfo)
            clsUser = NewValue
        End Set
    End Property


    Private Sub frmWOReservations_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized

        Call InitControl()

        Call InitDataBinding()

        Call LoadGrdgrdReservations()

        Call LoadGrdgrdProductionLots()

        Call LoadgrdProductionOrderLines()
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

    Private Sub LoadGrdgrdReservations()

        Dim dt As DataTable = (New classWOReservation).GetWOReservations(StrReservationsNumber:=txtReservationsNumber.Text.Trim)
        Call BindGrdgrdReservations(dt)
        If dt.Rows.Count > 0 Then BindTxtReservations(dt)

    End Sub

    Private Sub BindGrdgrdReservations(ByVal dt As DataTable)
        dtReservations = dt

        bsReservations.DataSource = dtReservations

        grdReservations.AutoGenerateColumns = False
        grdReservations.DataSource = bsReservations.DataSource

    End Sub
    Private Sub BindTxtReservations(ByVal dt As DataTable)

        txtWoNo.Text = dt.Rows(0)("supply_source_header_code").ToString.Trim
        Call GenComboWOItems()

    End Sub

    Private Sub LoadgrdProductionOrderLines()

        Dim dt As DataTable = (New classWOReservation).GetKOProdLine(StrKoNo:=txtKoNo.Text)
        Call BindgrdProductionOrderLines(dt)

    End Sub

    Private Sub BindgrdProductionOrderLines(ByVal dt As DataTable)
        dtProductionOrderLines = dt

        bsProductionOrderLines.DataSource = dtProductionOrderLines

        grdProductionOrderLines.AutoGenerateColumns = False
        grdProductionOrderLines.DataSource = bsProductionOrderLines.DataSource


    End Sub


    Private Sub LoadGrdgrdProductionLots()

        Dim dt As DataTable = (New classWOReservation).GetWOProdLot(StrWoNo:=txtWoNo.Text,
                                                                    StrDemandSourceItemCode:=cboWOItems.Text,
                                                                    StrDemandSourceHeaderCode:=txtKoNo.Text.Trim)
        ', StrDemandSourceLineID:=grdProductionOrderLines.CurrentRow.Cells("grdProductionOrderLinesDemandSourceLineID").Value)
        Call BindGrdgrdProductionLots(dt)

    End Sub

    Private Sub BindGrdgrdProductionLots(ByVal dt As DataTable)
        dtProductionLotsBalance = dt

        bsProductionLotsBalance.DataSource = dtProductionLotsBalance

        grdProductionLots.AutoGenerateColumns = False
        grdProductionLots.DataSource = bsProductionLotsBalance.DataSource

    End Sub

    Private Sub InitDataBinding()

        dtWOItems = (New classWOReservation).GetWoItems(StrWoNo:=txtWoNo.Text.Trim)
        bsWOtems.DataSource = dtWOItems

        dtProductionOrderLines = (New classWOReservation).GetKOProdLine(StrKoNo:=txtKoNo.Text.Trim)
        bsProductionOrderLines.DataSource = dtProductionOrderLines

        dtReservations = (New classWOReservation).GetWOReservations(StrReservationsNumber:=txtReservationsNumber.Text)
        bsReservations.DataSource = dtReservations

        Call BindingData() '
    End Sub

    Private Sub BindingData()
        Call ClearDataBindings()

        txtWoNo.DataBindings.Add("text", bsWOtems, "supply_source_header_code")
        cboWOItems.DataBindings.Add("SelectedValue", bsWOtems, "supply_source_item_id")
        txtitdesc2.DataBindings.Add("text", bsWOtems, "itdesc2")
        txtSupplySourceHeaderMcno.DataBindings.Add("text", bsWOtems, "supply_source_header_mcno")

        'txtKoNo.DataBindings.Add("text", bsProductionOrderLines, "demand_source_header_code")
        txtDesignNo.DataBindings.Add("text", bsProductionOrderLines, "design_no")
        txtMcNo.DataBindings.Add("text", bsProductionOrderLines, "mcno")


        txtReservationsNumber.DataBindings.Add("text", bsReservations, "reservations_number")
        dtpReservationsDate.DataBindings.Add("text", bsReservations, "reservations_date")
        'txtWoNo.DataBindings.Add("text", bsReservations, "supply_source_header_code")

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

    Private Sub btnMoveLeft_Click(sender As Object, e As EventArgs) Handles btnMoveLeft.Click
        If grdProductionLots.Width > 300 Then
            grdProductionLots.Width = grdProductionLots.Width - 300
            btnMoveLeft.Left = grdProductionLots.Right
            btnMoveRight.Left = grdProductionLots.Right
            btnAdd.Left = grdProductionLots.Right
            btnDel.Left = grdProductionLots.Right
            btnDelAll.Left = grdProductionLots.Right

            grdReservations.Left = btnMoveLeft.Right
            grdReservations.Width = grdReservations.Width + 300
        End If
    End Sub

    Private Sub txtWoNo_TextChanged(sender As Object, e As EventArgs) Handles txtWoNo.TextChanged
        ' Call GenComboWOItems()
    End Sub

    Private Sub btnMoveRight_Click(sender As Object, e As EventArgs) Handles btnMoveRight.Click
        If grdReservations.Width > 300 Then
            grdProductionLots.Width = grdProductionLots.Width + 300
            btnMoveLeft.Left = grdProductionLots.Right
            btnMoveRight.Left = grdProductionLots.Right
            btnAdd.Left = grdProductionLots.Right
            btnDel.Left = grdProductionLots.Right
            btnDelAll.Left = grdProductionLots.Right

            grdReservations.Left = btnMoveLeft.Right
            grdReservations.Width = grdReservations.Width - 300
        End If
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Call CheckgrdProductionLots()

        Call AddSupplySourceLotNumber()

        Call CompareTwoGrids()

        Call CleargrdProductionLotsSeleted()

        Call CleargrdReservationsSeleted()

        Call SumgrdProductionLots()
        Call SumgrdReservations()
    End Sub

    Private Sub CompareTwoGrids()

        For Each rowgrdProductionLots As DataGridViewRow In grdProductionLots.Rows

            Dim totalReserveQtyPerLotsProd As Double = 0
            totalReserveQtyPerLotsProd = rowgrdProductionLots.Cells("grdProductionLotsReserveQty").Value
            Dim totalreserveqtyPerLotsReser As Double = 0

            For Each rowgrdReservations As DataGridViewRow In grdReservations.Rows
                If rowgrdProductionLots.Cells("grdProductionLotsSupplySourceLotNumber").Value.Equals(rowgrdReservations.Cells("grdReservationsSupplySourceLotNumber").Value) Then
                    totalreserveqtyPerLotsReser = totalreserveqtyPerLotsReser + (New clsConfig).IsNull(rowgrdReservations.Cells("grdReservationsReserveQty").Value, 0)
                End If
            Next

            rowgrdProductionLots.Cells("grdProductionLotsReserveQtyBal").Value = totalReserveQtyPerLotsProd - totalreserveqtyPerLotsReser

        Next


        Call SumgrdProductionLots()
        Call SumgrdReservations()
    End Sub
    Private Function CheckgrdProductionLots() As Boolean
        If grdProductionLots.DataSource Is Nothing Then Return False
        If grdProductionLots.Rows.Count = 0 Then Return False
        Dim i As Integer = 0
        For i = 0 To grdProductionLots.Rows.Count - 1
            If CBool(grdProductionLots.Rows(i).Cells("grdProductionLotsSel").Value) Then Return True
        Next
        Return False
    End Function

    Private Sub AddSupplySourceLotNumber()
        If grdProductionLots.Rows.Count > 0 Then
            Dim config As New clsConfig
            Dim dt As DataTable = grdProductionLots.DataSource
            Dim dt2 As DataTable = grdReservations.DataSource
            Dim dr As DataRow
            Dim msg As String = ""
            Dim i As Integer = 0
            Dim j As Integer = 0
            For i = 0 To dt.Rows.Count - 1
                If dt.Rows(i).RowState <> DataRowState.Deleted Then
                    If CBool(dt.Rows(i)("sel")) Then
                        If Not (New clsConfig).IsNull(dt.Rows(i)("reserve_qty_bal"), 0) = 0 Then 'Check Bal = 0
                            dr = dt2.NewRow
                            For j = 0 To dt2.Columns.Count - 1
                                dr(dt2.Columns(j).ColumnName.Trim) = dt.Rows(i)(dt2.Columns(j).ColumnName.Trim)
                            Next
                            dt2.Rows.Add(dr)
                        End If
                        'If Not CheckDuplicate(dt.Rows(i)("supply_source_lot_number").ToString.Trim, dt2.Copy()) Then

                        '    dr = dt2.NewRow
                        '    For j = 0 To dt2.Columns.Count - 1
                        '        dr(dt2.Columns(j).ColumnName.Trim) = dt.Rows(i)(dt2.Columns(j).ColumnName.Trim)
                        '    Next
                        '    dt2.Rows.Add(dr)
                        'Else
                        '    dr = dt2.NewRow
                        '    For j = 0 To dt2.Columns.Count - 1
                        '        dr(dt2.Columns(j).ColumnName.Trim) = dt.Rows(i)(dt2.Columns(j).ColumnName.Trim)
                        '    Next
                        '    dt2.Rows.Add(dr)

                        'End If
                    End If
                End If

            Next
        End If

        'Call SumGridNew()

    End Sub

    Private Sub CleargrdProductionLotsSeleted()
        Dim i As Integer = 0
        Dim rolls As Integer = 0
        Dim dt As DataTable = grdProductionLots.DataSource
        For i = 0 To dt.Rows.Count - 1
            If dt.Rows(i).RowState <> DataRowState.Deleted Then
                If CBool((New clsConfig).IsNull(dt.Rows(i)("sel"), False)) Then
                    rolls = rolls + 1
                    dt.Rows(i)("sel") = False
                End If
            End If
        Next
    End Sub

    Private Function CheckDuplicate(ByVal strSupplySourceLotNumber As String, ByVal dt As DataTable) As Boolean
        If dt.Rows.Count > 0 Then
            Dim i As Integer = 0
            For i = 0 To dt.Rows.Count - 1
                If dt.Rows(i).RowState <> DataRowState.Deleted Then
                    If dt.Rows(i)("supply_source_lot_number").ToString.Trim = strSupplySourceLotNumber Then Return True
                End If
            Next
        End If
        Return False
    End Function






    Private Sub txtWoNo_KeyDown(sender As Object, e As KeyEventArgs) Handles txtWoNo.KeyDown
        If e.KeyCode = Keys.Enter Then
            Call GenComboWOItems()
        End If
    End Sub

    Private Sub CleargrdReservationsSeleted()
        Dim i As Integer = 0
        Dim rolls As Integer = 0
        Dim dt As DataTable = grdReservations.DataSource
        For i = 0 To dt.Rows.Count - 1
            If dt.Rows(i).RowState <> DataRowState.Deleted Then
                If CBool((New clsConfig).IsNull(dt.Rows(i)("sel"), False)) Then
                    rolls = rolls + 1
                    dt.Rows(i)("sel") = False
                End If
            End If
        Next
    End Sub

    Private Sub GenComboWOItems()
        dtWOItems = (New classWOReservation).GetWoItems(StrWoNo:=txtWoNo.Text.Trim)
        bsWOtems.DataSource = dtWOItems
        cboWOItems.DataSource = bsWOtems.DataSource
        cboWOItems.ValueMember = "supply_source_item_id"
        cboWOItems.DisplayMember = "supply_source_item_code"
    End Sub

    Private Sub txtKoNo_TextChanged(sender As Object, e As EventArgs) Handles txtKoNo.TextChanged
        dtProductionOrderLines = (New classWOReservation).GetKOProdLine(StrKoNo:=txtKoNo.Text.Trim)
        bsProductionOrderLines.DataSource = dtProductionOrderLines
        bsProductionOrderLines.MoveFirst()

        Call LoadgrdProductionOrderLines()
        Call LoadGrdgrdProductionLots()
    End Sub

    Private Sub txtKoNo_KeyDown(sender As Object, e As KeyEventArgs) Handles txtKoNo.KeyDown
        'If e.KeyCode = Keys.Enter Then
        '    dtProductionOrderLines = (New classWOReservation).GetKOProdLine(StrKoNo:=txtKoNo.Text.Trim)
        '    bsProductionOrderLines.DataSource = dtProductionOrderLines
        '    bsProductionOrderLines.MoveFirst()

        '    Call LoadgrdProductionOrderLines()
        '    Call LoadGrdgrdProductionLots()

        'End If
    End Sub


    Private Sub cboWOItems_SelectedValueChanged(sender As Object, e As EventArgs) Handles cboWOItems.SelectedValueChanged

        'Call LoadGrdgrdReservations()
        'Call LoadGrdgrdProductionLots()

    End Sub

    Private Sub btnDel_Click(sender As Object, e As EventArgs) Handles btnDel.Click
        If Not CheckGrdNew() Then Exit Sub

        Call AddRollNoStock()

        If grdReservations.CurrentRow.Index >= 0 Then Call DeleteRollNoNew("SOME")

        Call CleargrdReservationsSeleted()

        Call CompareTwoGrids()


        Call SumgrdProductionLots()
        Call SumgrdReservations()
    End Sub

    Private Function CheckGrdNew() As Boolean
        If grdReservations.DataSource Is Nothing Then Return False
        If grdReservations.Rows.Count = 0 Then Return False
        Dim i As Integer = 0
        For i = 0 To grdReservations.Rows.Count - 1
            If CBool(grdReservations.Rows(i).Cells("grdReservationsSel").Value) Then Return True
        Next
        Return False
    End Function


    Private Sub AddRollNoStock()
        If grdReservations.Rows.Count > 0 Then
            Dim config As New clsConfig
            Dim dt As DataTable = grdReservations.DataSource
            Dim dt2 As DataTable = grdProductionLots.DataSource
            Dim dr As DataRow
            Dim msg As String = ""
            Dim i As Integer = 0
            Dim j As Integer = 0
            For i = 0 To dt.Rows.Count - 1
                If dt.Rows(i).RowState <> DataRowState.Deleted Then
                    If CBool(dt.Rows(i)("sel")) Then
                        If Not CheckDuplicate(dt.Rows(i)("supply_source_lot_number").ToString.Trim, dt2.Copy()) Then
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

    End Sub

    Private Sub DeleteRollNoNew(ByVal strType As String)
        If grdReservations.Rows.Count > 0 Then
            Dim i As Integer = 0
            Dim dt As DataTable = grdReservations.DataSource
            If strType = "ALL" Then
                Call LoadGrdgrdReservations()
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

    End Sub

    Private Sub SumgrdProductionLots()

        Dim Lots As Integer = 0
        Dim totalreserveqty As Double = 0


        For Each row As DataGridViewRow In grdProductionLots.Rows
            totalreserveqty = totalreserveqty + (New clsConfig).IsNull(row.Cells("grdProductionLotsReserveQtyBal").Value, 0) '+ Integer.Parse(row.Cells(1).Value)
            Lots = Lots + 1
        Next

        txtTotalLotsStk.Text = Format(Lots, "#,###")
        txtTotalQtyBalStk.Text = Format(totalreserveqty, "#,###.#0")

    End Sub

    Private Sub SumgrdReservations()

        Dim TotalLots As Integer = 0
        Dim ToTalQty As Double = 0

        For Each row As DataGridViewRow In grdReservations.Rows
            ToTalQty = ToTalQty + (New clsConfig).IsNull(row.Cells("grdReservationsReserveQty").Value, 0) '+ Integer.Parse(row.Cells(1).Value)
            TotalLots = TotalLots + 1
        Next

        txtTotalLotsRs.Text = Format(TotalLots, "#,###")
        txtTotalQtyRS.Text = Format(ToTalQty, "#,###.#0")

    End Sub

    Private Sub grdProductionLots_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles grdProductionLots.CellContentClick
        If grdProductionLots.CurrentCell.IsInEditMode Then grdProductionLots.EndEdit()
    End Sub

    Private Sub grdReservations_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles grdReservations.CellContentClick
        If grdReservations.CurrentCell.IsInEditMode Then grdReservations.EndEdit()
    End Sub

    Private Sub txtSelectRolls_TextChanged(sender As Object, e As EventArgs) Handles txtTotalLotsStk.TextChanged

    End Sub

    Private Sub lblStockRoll_Click(sender As Object, e As EventArgs) Handles lblStockRoll.Click

    End Sub

    Private Sub txtSelectKgs_TextChanged(sender As Object, e As EventArgs) Handles txtTotalQtyBalStk.TextChanged

    End Sub

    Private Sub lblStockKgs_Click(sender As Object, e As EventArgs) Handles lblStockKgs.Click

    End Sub

    Private Sub grdProductionLots_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles grdProductionLots.CellEndEdit
        Call SumgrdProductionLots()
    End Sub

    Private Sub grdProductionLots_CurrentCellDirtyStateChanged(sender As Object, e As EventArgs) Handles grdProductionLots.CurrentCellDirtyStateChanged
        '  If grdProductionLots.IsCurrentCellDirty Then

        ' grdProductionLots.CommitEdit(DataGridViewDataErrorContexts.Commit)
        ' End If

        'If grdProductionLots.CurrentCell.IsInEditMode Then grdProductionLots.EndEdit()
    End Sub

    Private Sub grdProductionLots_CellMouseLeave(sender As Object, e As DataGridViewCellEventArgs) Handles grdProductionLots.CellMouseLeave
        If grdProductionLots.IsCurrentCellDirty Then
            grdProductionLots.CommitEdit(DataGridViewDataErrorContexts.Commit)
        End If
    End Sub

    Private Sub grdProductionOrderLines_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles grdProductionOrderLines.CellContentClick

    End Sub

    Private Sub grdProductionOrderLines_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles grdProductionOrderLines.CellClick
        If grdProductionOrderLines.DataSource Is Nothing Then Exit Sub
        If grdProductionOrderLines.Rows.Count = 0 Then Exit Sub
        If e.RowIndex < 0 Then Exit Sub

        Call LoadGrdgrdProductionLots()

        Dim dt As DataTable = (New classWOReservation).GetWOProdLot(StrWoNo:=txtWoNo.Text,
                StrDemandSourceItemCode:=(New clsConfig).IsNull(grdProductionOrderLines.Rows(e.RowIndex).Cells("grdProductionOrderLinesSupplySourceItemCode").Value, "").ToString.Trim,
                StrDemandSourceHeaderCode:=txtKoNo.Text,
                StrDemandSourceLineID:=(New clsConfig).IsNull(grdProductionOrderLines.Rows(e.RowIndex).Cells("grdProductionOrderLinesDemandSourceLineID").Value, 0).ToString.Trim)

        Call BindGrdgrdProductionLots(dt)

        Call CompareTwoGrids()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnMinimized_Click(sender As Object, e As EventArgs) Handles btnMinimized.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        blnCancel = False
        Dim result As System.Windows.Forms.DialogResult
        result = MessageBox.Show("Would you like to Save ?", "System Message", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button3)
        If result = System.Windows.Forms.DialogResult.Cancel Then blnCancel = True
        If result <> System.Windows.Forms.DialogResult.Yes Then Exit Sub

        If Not CheckData() Then Exit Sub

        If Not SaveData() Then

        End If

    End Sub

    Public Function CheckData() As Boolean



        Return True
    End Function

    Public Function SaveData() As Boolean
        Dim dt As DataTable = bsReservations.DataSource
        Dim dv_add As New DataView(dt, "", "", DataViewRowState.Added)
        Dim dv_upd As New DataView(dt, "", "", DataViewRowState.ModifiedCurrent)
        Dim dv_del As New DataView(dt, "", "", DataViewRowState.Deleted)
        Dim msgerr As String = "'"

        Dim mtlreservations As New mtlreservations
        mtlreservations.StrreservationsNumber = txtReservationsNumber.Text
        mtlreservations.DataReservationsDate = dtpReservationsDate.Value


        If (New classWOReservation).WOReservationsSave(Mtlreservations:=mtlreservations, DV_ADD:=dv_add, DV_UPD:=dv_upd, DV_DEL:=dv_del, msgerr:=msgerr, Userinfo:=UserInfo) Then
            MessageBox.Show("บันทึกสำเร็จ", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtReservationsNumber.Text = mtlreservations.StrreservationsNumber
            Call LoadGrdgrdReservations()

        Else
            MessageBox.Show(msgerr, "System Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

    End Function

    Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click
        Me.WindowState = FormWindowState.Maximized

        Call InitControl()

        Call InitDataBinding()

        Call LoadGrdgrdReservations()

        Call LoadGrdgrdProductionLots()

        Call LoadgrdProductionOrderLines()
    End Sub

    Private Sub txtReservationsNumber_TextChanged(sender As Object, e As EventArgs) Handles txtReservationsNumber.TextChanged

    End Sub

    Private Sub txtReservationsNumber_KeyDown(sender As Object, e As KeyEventArgs) Handles txtReservationsNumber.KeyDown
        If e.KeyCode = Keys.Enter Then

            Call GenComboWOItems()

            dtReservations = (New classWOReservation).GetWOReservations(StrReservationsNumber:=txtReservationsNumber.Text)
            bsReservations.DataSource = dtReservations
            bsReservations.MoveFirst()

            Call LoadGrdgrdReservations()

        End If
    End Sub

    Private Sub btnDelAll_Click(sender As Object, e As EventArgs) Handles btnDelAll.Click
        'If lblCancelled.Visible Then Exit Sub
        If grdReservations.Rows.Count = 0 Then Exit Sub
        If MessageBox.Show("Would you like to delete all System Lot No. in right grid ?" & vbCrLf & "คุณต้องการลบล็อต ทั้งหมด ที่เตรียมจะย้อมในด้านขวาออกใช่หรือไม่ ?", "System Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = DialogResult.No Then Exit Sub
        Call DeleteRollNoNew("ALL")

        Call CompareTwoGrids()

        Call SumgrdProductionLots()
        Call SumgrdReservations()
    End Sub

    Private Sub grdReservations_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles grdReservations.CellEndEdit

        Call CompareTwoGrids()

        Call SumgrdReservations()
    End Sub

    Private Sub grdProductionLots_CellValidated(sender As Object, e As DataGridViewCellEventArgs) Handles grdProductionLots.CellValidated
        Call SumgrdProductionLots()
    End Sub

    Private Sub btnSelectAll_Click(sender As Object, e As EventArgs) Handles btnSelectAll.Click
        Dim i As Integer
        If Me.grdProductionLots.Rows.Count = 0 Then Exit Sub
        ' Try
        For i = 0 To Me.grdProductionLots.Rows.Count - 1
                If Me.grdProductionLots.Rows(i).Cells("grdProductionLotsSel").Value = False Then Me.grdProductionLots.Rows(i).Cells("grdProductionLotsSel").Value = True
            Next
        'Catch ex As Exception

        'End Try

        Call SumgrdProductionLots()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        Dim i As Integer
        If Me.grdProductionLots.Rows.Count = 0 Then Exit Sub 'And Me.DgYarn_in.Rows(1).Cells(1).ToString = ""
        ' Try
        For i = 0 To Me.grdProductionLots.Rows.Count - 1
            Me.grdProductionLots.Rows(i).Cells("grdProductionLotsSel").Value = False
        Next

        'Catch ex As Exception

        'End Try

        Call SumgrdProductionLots()
    End Sub

    Private Sub btnGetRSNo_Click(sender As Object, e As EventArgs) Handles btnGetRSNo.Click
        'Sitthana 20200226
        Dim f As New Classes.frmSearchReservationNo
        Dim drv As DataRowView
        Dim SearchResult As New Classes.SearchFormResult

        ' pass nothing to use default connection string inside the class or pass your connection object if need to use different from default.
        f.setConnectionString(clsConn.getSQLConnection)
        f.logempcd = clsUser.UserName

        SearchResult = f.ShowFrm
        f.Close()
        f.Dispose()
        If SearchResult.ButtonClicked = "OK" Then
            drv = SearchResult.ResultRowView
            txtReservationsNumber.Text = drv.Item("reservations_number")

            Call GenComboWOItems()

            dtReservations = (New classWOReservation).GetWOReservations(StrReservationsNumber:=txtReservationsNumber.Text)
            bsReservations.DataSource = dtReservations
            bsReservations.MoveFirst()

            Call LoadGrdgrdReservations()
        End If
    End Sub
End Class