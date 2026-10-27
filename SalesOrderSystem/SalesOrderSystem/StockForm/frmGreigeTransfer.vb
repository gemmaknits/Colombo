Public Class frmGreigeTransfer
    Dim config As New clsConfig
    Dim stock As New classStockTransferG
    Dim trn_id As Long = 0
    Dim Strtrn_no As String = ""
    Dim clsUser As New classUserInfo
    Dim strdono As String
    Dim StrGinNo As String = ""

    Dim StrRollNoD As String = ""
    Dim StrLot As String = ""
    Dim StrCol As String = ""
    Dim StrDfNo As String = ""

    Public Property UserInfo() As classUserInfo
        Get
            UserInfo = clsUser
        End Get
        Set(ByVal NewValue As classUserInfo)
            clsUser = NewValue
        End Set
    End Property

    Public Property p_dono As String
        Get
            p_dono = strdono
        End Get
        Set(ByVal Newvalue As String)
            strdono = Newvalue
        End Set
    End Property

    Public Property p_ginno As String
        Get
            p_ginno = StrGinNo
        End Get
        Set(ByVal Newvalue As String)
            StrGinNo = Newvalue
        End Set
    End Property

    Private Sub Initialize()
        txttrnNo.Text = ""
        ' dtpTrnDate.Value = Now
        'txtLocation.Text = ""
        ' txtSubLocation.Text = ""

        'txtLocation.Enabled = True
        ' txtSubLocation.Enabled = True
        ' cboNewmtl_subinventory.Enabled = True
        'cboNewmtl_warehouse.Enabled = True
        'cboNewmtl_locations.Enabled = True

        grdRollNo.DataSource = vbNull

        trn_id = Nothing
        Strtrn_no = ""
        Call LoadData("")
    End Sub

    'Private Sub EnabledControl(ByVal value As Boolean)
    '    ' txtLocation.Enabled = value
    '    ' txtSubLocation.Enabled = value
    '    grdRollNo.Enabled = value
    'End Sub

    Private Sub BindData(ByVal dt As DataTable)
        ' txtLocation.Text = dt.Rows(0)("new_location").ToString
        ' txtSubLocation.Text = dt.Rows(0)("new_sub_location").ToString
    End Sub

    Private Sub LoadTrnNo()
        Dim col As New AutoCompleteStringCollection
        Dim dt As DataTable = stock.GetTransferNoG()
        txttrnNo.AutoCompleteMode = AutoCompleteMode.Append
        For i = 0 To dt.Rows.Count - 1
            col.Add(dt.Rows(i)("trn_no").ToString())  '//columnname same as in query
        Next

        txttrnNo.AutoCompleteSource = AutoCompleteSource.CustomSource
        txttrnNo.AutoCompleteCustomSource = col
        txttrnNo.AutoCompleteMode = AutoCompleteMode.Suggest

        'TextBox1.AutoCompleteMode = AutoCompleteMode.Suggest
        'cboTrnNo.ComboBox.DataSource = dt
        'cboTrnNo.ComboBox.DisplayMember = "trn_no"
        'cboTrnNo.ComboBox.ValueMember = "trn_no"
    End Sub


    Private Sub LoadData(ByVal Trn_no As String)
        Dim dt As DataTable = stock.GetTransferDetG(Trn_no)

        grdRollNo.AutoGenerateColumns = False
        grdRollNo.DataSource = dt

        If dt.Rows.Count > 0 Then
            trn_id = dt.Rows(0)("trn_id")
            Trn_no = dt.Rows(0)("trn_no")
            txttrnNo.Text = Trn_no
            dtpLogdt.Value = dt.Rows(0)("trn_date")

            Call EnabledControl(False)
        Else
            trn_id = 0
            Trn_no = ""
            txttrnNo.Text = Trn_no
            dtpLogdt.Value = Now()
        End If


    End Sub

    Private Sub GetAllCombo()
        Call GenComboWarehouse(ComboWarehouse:=cbomtl_warehouse)
        Call GenComboSubvinventory(ComboWarehouse:=cbomtl_warehouse, ComboSubvinventory:=cbomtl_subinventory)
        Call GenComboLocations(ComboWarehouse:=cbomtl_warehouse, ComboSubvinventory:=cbomtl_subinventory, ComboLocations:=cbomtl_Location)
        Call GetComboWarehouseinGrid()
        Call GetcomboSubInventoryinGrid(Int64mtl_warehouse_id:=0)
        Call GetCombomtl_locationInGrid(Int64mtl_warehouse_id:=0, Int64mtl_subinventory_id:=0)
    End Sub

    Private Sub GetCombomtl_locationInGrid(Optional ByVal Int64mtl_warehouse_id As Nullable(Of Int64) = Nothing,
                                           Optional ByVal Int64mtl_subinventory_id As Nullable(Of Int64) = Nothing)
        Dim objdb As New classMaster

        MtlLocationsIdFrom.DataSource = objdb.Combomtllocations(strUSerID:=clsUser.UserID, INt64mtl_warehouse_id:=Int64mtl_warehouse_id, Int64mtl_subinventory_id:=Int64mtl_subinventory_id)
        MtlLocationsIdFrom.DisplayMember = "location_name"
        MtlLocationsIdFrom.ValueMember = "mtl_locations_id"

        MtlLocationsIdTo.DataSource = objdb.Combomtllocations(strUSerID:=clsUser.UserID, INt64mtl_warehouse_id:=Int64mtl_warehouse_id, Int64mtl_subinventory_id:=Int64mtl_subinventory_id)
        MtlLocationsIdTo.DisplayMember = "location_name"
        MtlLocationsIdTo.ValueMember = "mtl_locations_id"

    End Sub

    Private Sub GetcomboSubInventoryinGrid(ByVal Int64mtl_warehouse_id As Int64)
        Dim objdb As New classMaster


        MtlSubinventoryIdFrom.DataSource = objdb.ComboMtlsubinventory(0)
        MtlSubinventoryIdFrom.DisplayMember = "subinventory_code"
        MtlSubinventoryIdFrom.ValueMember = "mtl_subinventory_id"

        MtlSubinventoryIdTo.DataSource = objdb.ComboMtlsubinventory(0)
        MtlSubinventoryIdTo.DisplayMember = "subinventory_code"
        MtlSubinventoryIdTo.ValueMember = "mtl_subinventory_id"
    End Sub
    Private Sub GetComboWarehouseinGrid()
        Dim objdb As New classMaster


        MtlWarehouseIdFrom.DataSource = objdb.Combomtlwarehouse(clsUser.UserID)
        MtlWarehouseIdFrom.DisplayMember = "warehouse_code"
        MtlWarehouseIdFrom.ValueMember = "mtl_warehouse_id"

        MtlWarehouseIdTo.DataSource = objdb.Combomtlwarehouse(clsUser.UserID)
        MtlWarehouseIdTo.DisplayMember = "warehouse_code"
        MtlWarehouseIdTo.ValueMember = "mtl_warehouse_id"
    End Sub
    Private Sub SetdefaultWareHouse()
        Dim clsSO As New classSalesOrder
        Dim dt As New DataTable '= clsSO.Getfulfilment_typeFromSo_Type(ComboSaleOrderType1.SelectedValue)

        If dt.Rows.Count > 0 Then
            'cbofulfilment_type.SelectedValue = dt.Rows(0)("lookup_value_id")
        End If
    End Sub

    Private Sub GetData(ByVal StrRollNo As String, ByVal StrGinNo As String _
                        , ByVal strsource_refno As String, ByVal Strlot As String)
        Dim dt As DataTable
        dt = stock.GetTransferGregieByBarcode(Strroll_no:=StrRollNo, Strtran_no:=StrGinNo, Strsource_refno:=strsource_refno, Strlot:=Strlot, StrUSerID:=clsUser.UserID)
        Dim dt2 As DataTable = grdRollNo.DataSource
        Dim r As DataRow

        For i = 0 To dt.Rows.Count - 1
            r = dt2.NewRow

            r("roll_no_g") = dt.Rows(i)("roll_no_g")
            r("design_no") = dt.Rows(i)("design_no")
            r("lot") = dt.Rows(i)("lot")
            r("col") = dt.Rows(i)("col")
            r("mtl_warehouse_id_from") = dt.Rows(i)("mtl_warehouse_id_from")
            r("mtl_subinventory_id_from") = dt.Rows(i)("mtl_subinventory_id_from")
            r("mtl_locations_id_from") = dt.Rows(i)("mtl_locations_id_from")
            r("mtl_warehouse_id_to") = dt.Rows(i)("mtl_warehouse_id_to")
            r("mtl_subinventory_id_to") = dt.Rows(i)("mtl_subinventory_id_to")
            r("mtl_locations_id_to") = dt.Rows(i)("mtl_locations_id_to")
            r("loc_from") = dt.Rows(i)("loc_from")
            r("loc_to") = dt.Rows(i)("loc_to")
            r("grade_from") = dt.Rows(i)("grade_from")
            r("grade_to") = dt.Rows(i)("grade_to")
            r("grade_bdt_from") = dt.Rows(i)("grade_bdt_from")
            r("grade_bdt_to") = dt.Rows(i)("grade_bdt_to")
            r("grade_adt_from") = dt.Rows(i)("grade_adt_from")
            r("grade_adt_to") = dt.Rows(i)("grade_adt_to")
            'Call dt2.Rows.Add(r)

            If Not CheckIsDuplicateRollNo(Roll_no_g:=dt.Rows(i)("roll_no_g").ToString.Trim) Then dt2.Rows.Add(r)

            'txtlot.Enabled = False
        Next

        txtBarcode.Text = ""

    End Sub

    Public Function CheckIsDuplicateRollNo(ByVal Roll_no_g As String) As Boolean
        Dim dt2 As New DataTable
        dt2 = grdRollNo.DataSource
        'Dim dt2 As DataTable = DtGrdRollNo


        If dt2.Rows.Count > 0 Then
            For Each row As DataRow In dt2.Rows
                If row("roll_no_g").ToString().Trim.Equals(Roll_no_g) Then
                    MessageBox.Show("คุณกำลังพยายามป้อนม้วนซ้ำ!!!", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
                    Return True
                Else
                    Return False
                End If

            Next
        End If


        Return False
    End Function
    Private Sub frmGreigeTransfer_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        Me.WindowState = FormWindowState.Maximized

        Call InitControl()

        Call GetAllCombo()
        Call GetComboTranNo(cboDocNo)
        Call LoadData("")

        If StrGinNo.Length > 0 Then
            Call GetData(StrRollNo:="", StrGinNo:=StrGinNo, strsource_refno:="", Strlot:="")
        End If

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

        btnSave.Enabled = blnEnabled

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

    Private Sub GetComboTranNo(ByVal CbotranNo As ToolStripComboBox)
        Dim dt As DataTable = stock.GetTransferNoG()
        CbotranNo.ComboBox.DataSource = stock.GetTransferNoG()
        CbotranNo.ComboBox.DisplayMember = "trn_no"
        CbotranNo.ComboBox.ValueMember = "trn_no"
    End Sub
    Private Sub GenComboWarehouse(ByVal ComboWarehouse As ComboBox)

        ComboWarehouse.DataSource = (New classMaster).Combomtlwarehouse(clsUser.UserID)
        ComboWarehouse.DisplayMember = "warehouse_code"
        ComboWarehouse.ValueMember = "mtl_warehouse_id"
    End Sub
    Private Sub GenComboSubvinventory(ByVal ComboWarehouse As ComboBox, ByVal ComboSubvinventory As ComboBox)
        ComboSubvinventory.DataSource = (New classMaster).ComboMtlsubinventory(INt64mtl_warehouse_id:=(New clsConfig).IsNull(ComboWarehouse.SelectedValue, Nothing))
        ComboSubvinventory.DisplayMember = "subinventory_code"
        ComboSubvinventory.ValueMember = "mtl_subinventory_id"

    End Sub
    Private Sub SetDefaultSubInventory(ByVal dt As DataTable)
        Dim expression As String
        expression = "subinventory_code like '%GREIGE%'"
        Dim foundRows() As DataRow
        foundRows = dt.Select(expression)

        cbomtl_subinventory.SelectedValue = foundRows(0)("mtl_subinventory_id")

    End Sub
    Private Sub GenComboLocations(ByVal ComboWarehouse As ComboBox, ByVal ComboSubvinventory As ComboBox, ByVal ComboLocations As ComboBox)

        ComboLocations.DataSource = (New classMaster).Combomtllocations(strUSerID:=clsUser.UserID,
                                          INt64mtl_warehouse_id:=(New clsConfig).IsNull(ComboWarehouse.SelectedValue, Nothing),
                                          Int64mtl_subinventory_id:=(New clsConfig).IsNull(ComboSubvinventory.SelectedValue, Nothing))
        ComboLocations.DisplayMember = "location_name"
        ComboLocations.ValueMember = "mtl_locations_id"

    End Sub

    Private Sub cboTrnNo_Click(sender As System.Object, e As System.EventArgs)

    End Sub

    Private Sub cboTrnNo_DropDownClosed(sender As Object, e As System.EventArgs)
        Call LoadData(txttrnNo.Text.Trim)
    End Sub

    Private Sub grdRollNo_CellContentClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles grdRollNo.CellContentClick

    End Sub

    Private Sub grdRollNo_CellEndEdit(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles grdRollNo.CellEndEdit
        Dim objdb As New classMaster


        Dim dgvccSubInven As New DataGridViewComboBoxCell
        Dim dtSubInven As New DataTable
        If grdRollNo.Columns(e.ColumnIndex).Name = "mtl_warehouse_id" Then
            If Not IsDBNull(grdRollNo.Rows(e.RowIndex).Cells("mtl_warehouse_id").Value) Then
                dtSubInven = objdb.ComboMtlsubinventory(grdRollNo.Rows(e.RowIndex).Cells("mtl_warehouse_id").Value)
                dgvccSubInven = grdRollNo.Rows(e.RowIndex).Cells("mtl_subinventory_id")
                Try
                    dgvccSubInven.DataSource = dtSubInven
                    dgvccSubInven.DisplayMember = "subinventory_code"
                    dgvccSubInven.ValueMember = "mtl_subinventory_id"
                    'dgvccSubInven.Value = dtSubInven.Rows(0)("mtl_subinventory_id") 'Fix Error

                    Dim expression As String
                    expression = "subinventory_code like '%GREIGE%'"
                    Dim foundRows() As DataRow
                    foundRows = dtSubInven.Select(expression)
                    dgvccSubInven.Value = foundRows(0)("mtl_subinventory_id")
                Catch ex As Exception

                    'SetDefault
                    Dim expression As String
                    expression = "subinventory_code like '%GREIGE PRESET%'"
                    Dim foundRows() As DataRow
                    foundRows = dtSubInven.Select(expression)
                    dgvccSubInven.Value = DBNull.Value

                End Try
            End If
        End If

        Dim dgvcc As New DataGridViewComboBoxCell
        Dim dt3 As New DataTable
        If grdRollNo.Columns(e.ColumnIndex).Name = "mtl_warehouse_id" Or grdRollNo.Columns(e.ColumnIndex).Name = "mtl_subinventory_id" Then
            If Not IsDBNull(grdRollNo.Rows(e.RowIndex).Cells("mtl_warehouse_id").Value) And Not IsDBNull(grdRollNo.Rows(e.RowIndex).Cells("mtl_subinventory_id").Value) Then
                dt3 = objdb.Combomtllocations(clsUser.UserID, grdRollNo.Rows(e.RowIndex).Cells("mtl_warehouse_id").Value, grdRollNo.Rows(e.RowIndex).Cells("mtl_subinventory_id").Value)
                dgvcc = grdRollNo.Rows(e.RowIndex).Cells("mtl_locations_id")
                Try
                    dgvcc.DataSource = dt3
                    dgvcc.DisplayMember = "location_name"
                    dgvcc.ValueMember = "mtl_locations_id"
                    dgvcc.Value = dt3.Rows(0)("mtl_locations_id") 'Fix Error
                Catch ex As Exception
                    dgvcc.DataSource = dt3
                    dgvcc.DisplayMember = "location_name"
                    dgvcc.ValueMember = "mtl_locations_id"
                    dgvcc.Value = DBNull.Value
                End Try
            End If
        End If
    End Sub
    'Private Sub SetDefaultSubInventory(ByVal dt As DataTable)
    '    Dim expression As String
    '    expression = "subinventory_name like '%STOCK GREIGE%'"
    '    Dim foundRows() As DataRow
    '    foundRows = dt.Select(expression)

    '    'cbomtl_subinventory.SelectedValue = foundRows(0)(0)

    'End Sub

    Private Sub grdRollNo_CurrentCellDirtyStateChanged(sender As Object, e As System.EventArgs) Handles grdRollNo.CurrentCellDirtyStateChanged
        If grdRollNo.IsCurrentCellDirty Then
            grdRollNo.CommitEdit(DataGridViewDataErrorContexts.Commit)
        End If
    End Sub

    Private Sub btnSave_Click(sender As System.Object, e As System.EventArgs) Handles btnSave.Click


        If Not CheckData() Then Exit Sub


        If MessageBox.Show("Would you like to save ?", "System Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = DialogResult.Yes Then

            If grdRollNo.Rows.Count > 0 Then
                For i = 0 To grdRollNo.Rows.Count - 1
                    grdRollNo.Rows(i).Cells("LocFrom").Value = grdRollNo.Rows(i).Cells("MtlLocationsIdFrom").FormattedValue.ToString()
                    grdRollNo.Rows(i).Cells("LocTo").Value = grdRollNo.Rows(i).Cells("MtlLocationsIdTo").FormattedValue.ToString()
                Next

            End If

            Dim dt As DataTable = grdRollNo.DataSource
            Dim dv_add As New DataView(dt, "", "", DataViewRowState.Added)
            Dim dv_upd As New DataView(dt, "", "", DataViewRowState.ModifiedCurrent)
            Dim dv_del As New DataView(dt, "", "", DataViewRowState.Deleted)
            Dim TrnH As New classStockTransferG.TrnHeader
            Dim msg_err As String = ""
            TrnH.h01_trn_id = trn_id
            TrnH.h02_trn_no = txttrnNo.Text.Trim
            TrnH.h03_trn_date = Now.ToString("yyyyMMdd")
            TrnH.h04_trn_time = ""
            TrnH.h05_new_location = ""
            TrnH.h07_login_empcd = clsUser.UserID

            If stock.TrnGSave(TrnH:=TrnH, TrnD_ADD:=dv_add, TrnD_UPD:=dv_upd, TrnD_DEL:=dv_del, msgerr:=msg_err) Then
                Call LoadTrnNo()
                txttrnNo.Text = TrnH.h02_trn_no.Trim

                Call LoadData(TrnH.h02_trn_no)
            Else
                MessageBox.Show(msg_err, "System Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If
    End Sub

    Private Function CheckData() As Boolean

        For Each row As DataGridViewRow In grdRollNo.Rows

            If (New clsConfig).IsNull((row.Cells("MtlWarehouseIdTo").Value), "0") = "0" Then
                MessageBox.Show("Must be Enter W/H", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
                ErrorProvider1.SetError(grdRollNo, "Must be Enter W/H")
                CheckData = False
                Exit Function
            End If
            If (New clsConfig).IsNull((row.Cells("MtlSubinventoryIdTo").Value), "0") = "0" Then
                MessageBox.Show("Must be Enter Sub Inventory", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
                ErrorProvider1.SetError(grdRollNo, "Must be Enter Sub Inventory")
                CheckData = False
                Exit Function
            End If
            If (New clsConfig).IsNull((row.Cells("MtlLocationsIdTo").Value), "0") = "0" Then
                MessageBox.Show("Must be Enter Location", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
                ErrorProvider1.SetError(grdRollNo, "Must be Enter Location")
                CheckData = False
                Exit Function
            End If

        Next

        Return True
    End Function

    Private Sub txtTrnNo_Click(sender As System.Object, e As System.EventArgs)

    End Sub

    Private Sub txtTrnNo_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs)
        If txttrnNo.Text.Length > 0 Then
            LoadData(Trn_no:=txttrnNo.Text.Trim)
        End If
    End Sub

    Private Sub optGinNo_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles optGinNo.CheckedChanged

    End Sub

    Private Sub optReqNo_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles optRollNo.CheckedChanged

    End Sub

    Private Sub txtTrnNo_Validated(sender As Object, e As System.EventArgs)

        If txttrnNo.Text.Length > 0 Then
            LoadData(Trn_no:=txttrnNo.Text.Trim)
        End If

    End Sub

    Private Sub txtBarcode_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles txtBarcode.KeyDown
        If txtBarcode.Text.Length = 0 Then Exit Sub

        Call Checkopt()

        If e.KeyCode = Keys.Enter Then

            Call GetData(StrRollNo:=StrRollNoD,
                                    Strlot:="",
                                    strsource_refno:="",
                                    StrGinNo:=StrGinNo)

            txtBarcode.ReadOnly = False
            txtBarcode.Focus()
        End If

    End Sub

    Public Sub Checkopt()

        If optRollNo.Checked Then
            StrRollNoD = txtBarcode.Text.Trim
            StrGinNo = ""
        ElseIf optGinNo.Checked Then
            StrRollNoD = ""
            StrGinNo = txtBarcode.Text.Trim
        End If

    End Sub

    Private Sub txtBarcode_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtBarcode.TextChanged

    End Sub

    Private Sub btnLocations_Click(sender As System.Object, e As System.EventArgs) Handles btnApplyLocAllRow.Click

        Dim dt3 As New DataTable
        For i = 0 To grdRollNo.Rows.Count - 1


            grdRollNo.Rows(i).Cells("MtlWarehouseIdTo").Value() = cbomtl_warehouse.SelectedValue
            Dim dgvcc As New DataGridViewComboBoxCell
            dgvcc = grdRollNo.Rows(i).Cells("MtlSubinventoryIdTo")
            dgvcc.DataSource = cbomtl_subinventory.DataSource
            grdRollNo.Rows(i).Cells("MtlSubinventoryIdTo").Value() = cbomtl_subinventory.SelectedValue
            Dim dgvcc2 As New DataGridViewComboBoxCell
            dgvcc = grdRollNo.Rows(i).Cells("MtlLocationsIdTo")
            dgvcc.DataSource = cbomtl_Location.DataSource
            grdRollNo.Rows(i).Cells("MtlLocationsIdTo").Value() = cbomtl_Location.SelectedValue
        Next
    End Sub

    Private Sub ApplyRow(RowNo As Integer)
        With grdRollNo
            grdRollNo.Rows(RowNo).Cells("MtlWarehouseIdTo").Value() = cbomtl_warehouse.SelectedValue

            Dim dgvcc As New DataGridViewComboBoxCell
            dgvcc = grdRollNo.Rows(RowNo).Cells("MtlSubinventoryIdTo")
            dgvcc.DataSource = cbomtl_subinventory.DataSource
            grdRollNo.Rows(RowNo).Cells("MtlSubinventoryIdTo").Value() = cbomtl_subinventory.SelectedValue

            Dim dgvcc2 As New DataGridViewComboBoxCell
            dgvcc = grdRollNo.Rows(RowNo).Cells("MtlLocationsIdTo")
            dgvcc.DataSource = cbomtl_Location.DataSource
            If IsDBNull(cbomtl_Location.DataSource) Then
                grdRollNo.Rows(RowNo).Cells("MtlLocationsIdTo").Value = -1
            Else
                grdRollNo.Rows(RowNo).Cells("MtlLocationsIdTo").Value() = cbomtl_Location.SelectedValue
            End If

        End With
    End Sub

    Private Sub txtLogNo_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles txttrnNo.KeyDown
        If e.KeyCode = Keys.Enter Then
            If txttrnNo.Text.Length > 0 Then
                LoadData(Trn_no:=txttrnNo.Text.Trim)
            End If
        End If
    End Sub

    Private Sub txtLogNo_TabStopChanged(sender As Object, e As System.EventArgs) Handles txttrnNo.TabStopChanged

    End Sub

    Private Sub txtLogNo_TextChanged(sender As System.Object, e As System.EventArgs) Handles txttrnNo.TextChanged

    End Sub

    Private Sub btnPrint_Click(sender As System.Object, e As System.EventArgs) Handles btnPrint.Click

        If txttrnNo.Text.Length = 0 Then Exit Sub
        Const rptFileName = "rptGreigeTransfer.rpt"
        If clsUser.ReportPath = "" Then clsUser.ReportPath = clsUser.ReportPath
        If Not (New clsConfig).CheckReport(clsUser.ReportPath, rptFileName) Then Exit Sub
        Dim frm As New frmReport
        Dim rpt As New CrystalDecisions.CrystalReports.Engine.ReportDocument
        Dim logonInfo As New CrystalDecisions.Shared.TableLogOnInfo
        Me.Cursor = Cursors.WaitCursor
        logonInfo.ConnectionInfo.ServerName = (New classConnection).servername
        logonInfo.ConnectionInfo.DatabaseName = (New classConnection).database
        logonInfo.ConnectionInfo.IntegratedSecurity = False
        logonInfo.ConnectionInfo.UserID = (New classConnection).Userid
        logonInfo.ConnectionInfo.Password = (New classConnection).Password

        rpt.Load(clsUser.ReportPath & rptFileName)
        'rpt.Subreports(0).Database.Tables(0).ApplyLogOnInfo(logonInfo)
        rpt.DataSourceConnections.Item(0).SetConnection((New classConnection).servername, (New classConnection).database, False)
        rpt.DataSourceConnections.Item(0).SetLogon((New classConnection).Userid, (New classConnection).Password)
        rpt.VerifyDatabase()
        rpt.SetParameterValue("@trn_no", txttrnNo.Text)

        'rpt.PrintOptions.PaperSize = CrystalDecisions.Shared.PaperSize.PaperLetter
        'rpt.PrintOptions.PaperOrientation = CrystalDecisions.Shared.PaperOrientation.Portrait
        'rpt.PrintOptions.PaperSource = CrystalDecisions.Shared.PaperSource.Auto

        frm.Title = "Yarn Location Movement"
        'frm.CRViewer.DisplayGroupTree = False
        frm.CRViewer.ReportSource = rpt
        frm.MdiParent = Me.ParentForm
        frm.Show()
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub cbomtl_warehouse_DropDownClosed(sender As Object, e As System.EventArgs) Handles cbomtl_warehouse.DropDownClosed

        Call GenComboSubvinventory(ComboWarehouse:=cbomtl_warehouse, ComboSubvinventory:=cbomtl_subinventory)
        Call GenComboLocations(ComboWarehouse:=cbomtl_warehouse, ComboSubvinventory:=cbomtl_subinventory, ComboLocations:=cbomtl_Location)

    End Sub

    Private Sub cbomtl_warehouse_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cbomtl_warehouse.SelectedIndexChanged

    End Sub

    Private Sub btnNew_Click(sender As System.Object, e As System.EventArgs) Handles btnNew.Click
        Me.WindowState = FormWindowState.Maximized

        Call InitControl()

        Call GetAllCombo()
        Call GetComboTranNo(cboDocNo)
        Call LoadData("")

        If StrGinNo.Length > 0 Then
            Call GetData(StrRollNo:="", StrGinNo:=StrGinNo, strsource_refno:="", Strlot:="")
        End If

    End Sub

    Private Sub cboDocNo_Click(sender As System.Object, e As System.EventArgs) Handles cboDocNo.Click

    End Sub

    Private Sub cboDocNo_DropDownClosed(sender As Object, e As System.EventArgs) Handles cboDocNo.DropDownClosed
        Call LoadData(Trn_no:=cboDocNo.Text.Trim)
    End Sub

    Private Sub cboDocNo_SelectedIndexChanged(sender As Object, e As System.EventArgs) Handles cboDocNo.SelectedIndexChanged

    End Sub

    Private Sub cbomtl_subinventory_DropDownClosed(sender As Object, e As System.EventArgs) Handles cbomtl_subinventory.DropDownClosed
        Call GenComboLocations(ComboWarehouse:=cbomtl_warehouse, ComboSubvinventory:=cbomtl_subinventory, ComboLocations:=cbomtl_Location)

    End Sub

    Private Sub cbomtl_subinventory_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cbomtl_subinventory.SelectedIndexChanged

    End Sub

    Private Sub btnApplyGrAll_Click(sender As System.Object, e As System.EventArgs) Handles btnApplyGrAll.Click
        For i = 0 To grdRollNo.Rows.Count - 1
            ApplyRowGrade(i)
        Next
    End Sub

    Private Sub ApplyRowGrade(RowNo As Integer)
        With grdRollNo
            grdRollNo.Rows(RowNo).Cells("GradeTo").Value() = txtGradeTo.Text
            grdRollNo.Rows(RowNo).Cells("GradeBdtTo").Value() = txtGradeBdtTo.Text
            grdRollNo.Rows(RowNo).Cells("GradeAdtTo").Value() = txtGradeAdtTo.Text
        End With
    End Sub

    Private Sub btnApplyGrCurRow_Click(sender As System.Object, e As System.EventArgs) Handles btnApplyGrCurRow.Click
        Call ApplyRowGrade(grdRollNo.CurrentRow.Index)
    End Sub

    Private Sub btnApplyCurLocRow_Click(sender As Object, e As EventArgs) Handles btnApplyCurLocRow.Click
        Call ApplyRow(grdRollNo.CurrentRow.Index)
    End Sub

    Private Sub txtGradeBdtTo_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtGradeBdtTo.TextChanged
        Call GenLot_Grade()
    End Sub

    Private Sub GenLot_Grade()
        txtGradeTo.Text = Trim(txtGradeBdtTo.Text) + Trim(txtGradeAdtTo.Text)
    End Sub

    Private Sub txtGradeAdtTo_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtGradeAdtTo.TextChanged
        Call GenLot_Grade()
    End Sub
End Class