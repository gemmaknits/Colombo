Public Class frmYarnInCustomerYarn
    'Public loginEmpcd As String
    Dim clsYarn As New GetDataYarn
    Dim clsMaster As New classMaster
    Dim clsConfig As New clsConfig
    Dim jobID As Long = 0
    Dim jobQty As Single = 0
    Dim netKg As Single = 0
    Dim docno As String = ""
    Dim Stritcd As String = ""
    Dim clsUser As New classUserInfo

    Dim dtYarnIn As New DataTable
    Dim bsYarnIn As New BindingSource
    Dim dtYarnInDet As New DataTable
    Dim bsYarnInDet As New BindingSource
    ' Dim dtJob As New DataTable
    'Dim bsJob As New BindingSource
    Dim dtJobDet As New DataTable
    Dim bsJobDet As New BindingSource

    Dim dtMtlWarehouse As New DataTable
    Dim bsMtlWarehouse As New BindingSource
    Dim dtMtlSubInventory As New DataTable
    Dim bsMtlSubInventory As New BindingSource
    Dim dtmtlLocations As New DataTable
    Dim bsMtlLocations As New BindingSource

    Public Property UserInfo() As classUserInfo
        Get
            UserInfo = clsUser
        End Get
        Set(ByVal NewValue As classUserInfo)
            clsUser = NewValue
        End Set
    End Property

    Private Sub InitControl2()
        'docno = ""
        'txtDocNo.Text = ""
        'txtPONo.Text = ""
        'dtpDocDate.Value = Now
        'cboSupplier.SelectedValue = ""
        'txtSuppInvNo.Text = ""
        'txtSuppLot.Text = ""
        'txtSuppInvDate.Text = ""
        'txtSuppRefNo.Text = ""
        'txtRemark.Text = ""

        'txtTotalBoxes.Text = ""
        'txtTotalTubes.Text = ""
        'txtTotalGrossWeight.Text = ""
        'txtTotalNetWeight.Text = ""

        ' Dim sender As New System.Object
        ' Dim e As New System.EventArgs

        ' Call GenCombo()
        ' Call GenComboGradeOur()

        ' Dim dt As DataTable = clsYarn.GetData_YarnIn9(txtDocNo.Text.Trim, "")
        'grdYarnIN.AutoGenerateColumns = False
        'grdYarnIN.DataSource = dt

    End Sub

    Private Sub InitControl()
        Dim obj As Control
        For Each obj In Me.Controls
            Call SetControlValue(obj)
        Next
        Call EnabledControl(True)
        Call SetErrorProvider()

        txtPurNo.Text = "COMMPROC"

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


    'Private Sub genComboLoc()
    '    Dim clsmaster As New classMaster
    '    Dim dt As DataTable = clsMaster.GetWareHouse


    '    loc.DataSource = dt
    '    loc.ValueMember = "loc"
    '    loc.DisplayMember = "loc"


    '    'mtl_warehouse.DataSource = clsmaster.Combomtlwarehouse(clsUser.UserID)
    '    'mtl_warehouse.DisplayMember = "warehouse_name"
    '    'mtl_warehouse.ValueMember = "mtl_warehouse_id"


    '    'mtl_Location.DataSource = clsmaster.Combomtllocations(Int64mtl_warehouse_id:=0, strUSerID:=clsUser.UserID)
    '    'mtl_Location.DisplayMember = "location_name"
    '    'mtl_Location.ValueMember = "mtl_locations_id"


    'End Sub
    Private Sub genComboLocByYarnInDet()

        Dim clsYarnIN As New classYarnIn
        Dim dt As DataTable = clsYarnIN.GetLocationByYarnInDet

        'loc.DataSource = dt
        'loc.ValueMember = "loc"
        ' loc.DisplayMember = "loc"

    End Sub
    Private Sub GenCombo()
        Dim objdb As New classMaster

        Call GetComboNewWarehouse()
        Call GetComboNewSubInventory(Int64mtl_warehouse_id:=(New clsConfig).IsNull(cbomtl_warehouse.SelectedValue, Nothing))
        Call GetComboLocation(Int64mtl_warehouse_id:=(New clsConfig).IsNull(cbomtl_warehouse.SelectedValue, Nothing),
                              Int64mtl_subinventory_id:=(New clsConfig).IsNull(cbomtl_subinventory.SelectedValue, Nothing))

        Call GetComboWarehouseinGrid()
        Call GetcomboSubInventoryinGrid(Int64mtl_warehouse_id:=objdb.GetdefaultWarehouse(strUSerID:=UserInfo.UserID))
        Call GetCombomtl_locationInGrid(Int64mtl_warehouse_id:=objdb.GetdefaultWarehouse(strUSerID:=UserInfo.UserID),
                                        Int64mtl_subinventory_id:=0)



        Dim dt As DataTable = clsYarn.GetSupplier()
        cboSupplier.DataSource = dt
        cboSupplier.DisplayMember = "name"
        cboSupplier.ValueMember = "suppcd"
        cboSupplier.SelectedIndex = 0

        dt = clsYarn.getItems()
        cboITCD.DataSource = dt
        cboITCD.DisplayMember = "itcd_desc"
        cboITCD.ValueMember = "itcd"
    End Sub

    Private Sub GetComboNewWarehouse()
        Dim objdb As New classMaster

        cbomtl_warehouse.DataSource = objdb.Combomtlwarehouse(clsUser.UserID)
        cbomtl_warehouse.DisplayMember = "warehouse_code"
        cbomtl_warehouse.ValueMember = "mtl_warehouse_id"
        cbomtl_warehouse.SelectedIndex = -1

        cbomtl_warehouse.SelectedValue = objdb.GetdefaultWarehouse(strUSerID:=clsUser.UserID)

    End Sub

    Private Sub GetComboNewSubInventory(Optional ByVal Int64mtl_warehouse_id As Nullable(Of Int64) = Nothing)
        Dim objdb As New classMaster

        cbomtl_subinventory.DataSource = objdb.GetCombomtl_subinventory(Int64mtl_warehouse_id)
        cbomtl_subinventory.DisplayMember = "subinventory_name"
        cbomtl_subinventory.ValueMember = "mtl_subinventory_id"
        cbomtl_subinventory.SelectedIndex = -1

        Dim dt As DataTable = cbomtl_subinventory.DataSource
        If dt.Rows.Count > 0 Then
            Call Setdefaultsubinventory(Int64mtl_warehouse_id:=Int64mtl_warehouse_id)
        End If
        'Setdefaultsubinventory(cboNewmtl_subinventory.DataSource)
    End Sub

    Private Sub GetComboLocation(Optional ByVal Int64mtl_warehouse_id As Nullable(Of Int64) = Nothing,
                                 Optional ByVal Int64mtl_subinventory_id As Nullable(Of Int64) = Nothing)
        Dim objdb As New classMaster
        cbomtl_locations.DataSource = objdb.Combomtllocations(strUSerID:=clsUser.UserID,
                                         INt64mtl_warehouse_id:=Int64mtl_warehouse_id,
                                         Int64mtl_subinventory_id:=Int64mtl_subinventory_id)

        cbomtl_locations.DisplayMember = "location_name"
        cbomtl_locations.ValueMember = "mtl_locations_id"
        cbomtl_locations.SelectedIndex = -1

        Dim dt As DataTable = cbomtl_locations.DataSource
        If dt.Rows.Count > 0 Then
            Call SetDefaultLocation(Int64mtl_warehouse_id:=Int64mtl_warehouse_id,
                                    Int64mtl_subinventory_id:=Int64mtl_subinventory_id)
        End If
    End Sub

    Private Sub Setdefaultsubinventory(Optional ByVal Int64mtl_warehouse_id As Nullable(Of Int64) = Nothing)
        Dim clsMaster As New classMaster
        If cbomtl_subinventory.Items.Count > 0 Then
            cbomtl_subinventory.SelectedValue = (New clsConfig).IsNull(clsMaster.GetdefaultSubinventory(Int64mtl_warehouse_id, Strsubinventory_code:="YARN", strUSerID:=clsUser.UserID), DBNull.Value)
        End If

    End Sub

    Private Sub SetDefaultLocation(Optional ByVal Int64mtl_warehouse_id As Nullable(Of Int64) = Nothing,
                                 Optional ByVal Int64mtl_subinventory_id As Nullable(Of Int64) = Nothing)
        Dim clsMaster As New classMaster
        Dim dt As DataTable = clsMaster.Getdefaultlocations(Int64mtl_warehouse_id:=Int64mtl_warehouse_id,
                                                            Int64mtl_subinventory_id:=Int64mtl_subinventory_id,
                                                            Strlocation_name:="N/A",
                                                            strUSerID:=clsUser.UserID)
        If dt.Rows.Count > 0 Then
            cbomtl_locations.SelectedValue = dt.Rows(0)("mtl_locations_id")
        Else
            cbomtl_locations.SelectedValue = DBNull.Value
        End If
    End Sub
    Private Sub GetComboWarehouseinGrid()
        Dim objdb As New classMaster
        mtl_warehouse_id.DataSource = objdb.Combomtlwarehouse(clsUser.UserID)
        mtl_warehouse_id.DisplayMember = "warehouse_name"
        mtl_warehouse_id.ValueMember = "mtl_warehouse_id"
    End Sub

    Private Sub GetcomboSubInventoryinGrid(ByVal Int64mtl_warehouse_id As Int64)
        Dim objdb As New classMaster
        mtl_subinventory_id.DataSource = objdb.GetCombomtl_subinventory(Int64mtl_warehouse_id)
        mtl_subinventory_id.DisplayMember = "subinventory_name"
        mtl_subinventory_id.ValueMember = "mtl_subinventory_id"
    End Sub

    Private Sub GetCombomtl_locationInGrid(ByVal Int64mtl_warehouse_id As Int64, ByVal Int64mtl_subinventory_id As Int64)
        Dim objdb As New classMaster
        mtl_locations_id.DataSource = objdb.Combomtllocations(strUSerID:=clsUser.UserID _
                             , INt64mtl_warehouse_id:=Int64mtl_warehouse_id _
                             , Int64mtl_subinventory_id:=Int64mtl_subinventory_id)
        mtl_locations_id.DisplayMember = "location_name"
        mtl_locations_id.ValueMember = "mtl_locations_id"
    End Sub

    Private Sub LoadDataJOB(ByVal jobno As String)
        ' Dim dt As DataTable
        txtPurNo.Text = txtPurNo.Text.Trim.ToUpper
        If txtPurNo.Text.Trim.ToUpper = ("FREE SAMPLE") Or
             txtPurNo.Text.Trim.ToUpper = ("FREE OF CHARGE") Or
             txtPurNo.Text.Trim.ToUpper = ("ADJUST IN") Or
             txtPurNo.Text.Trim.ToUpper = ("COMMPROC") Then
            dtJobDet = (New classYarnInCustomerYarn).getJobFree(jobno, "YARNS")
            '  Else
            '     dtJobDet = clsYarn.getJobDet(jobno)
        End If

        If dtJobDet.Rows.Count > 0 Then
            bsJobDet.DataSource = dtJobDet
            grdJobDet.AutoGenerateColumns = False
            grdJobDet.DataSource = bsJobDet
            jobID = clsConfig.IsNull(dtJobDet.Rows(0).Item("id_jobdet"), 0)
            cboSupplier.SelectedValue = dtJobDet.Rows(0).Item("suppcd")
        End If


    End Sub

    Private Sub LoadDataYarn(ByVal docno As String)

        Dim dt As DataTable = clsYarn.GetData_YarnIn9(docno, "")

        If dt.Rows.Count > 0 Then

            Call LoadDataJOB(clsConfig.IsNull(dt.Rows(0)("purno"), ""))

            Call SumGrid(dt)
            Call BindData(dt)
            Call genCboGKNo()

        End If
    End Sub

    Private Function AddNewBox(ByVal N As Int32) As Boolean
        If grdJobDet.Rows.Count = 0 Then
            Return False
            Exit Function
        End If

        Dim dtc As New DataTable
        dtc = grdYarnINDet.DataSource

        Dim newRow As DataRow
        If grdJobDet.Rows.Count > 0 Then
            For i = 1 To N
                newRow = dtc.NewRow
                newRow.Item("id_jobdet") = grdJobDet.CurrentRow.Cells("colID").Value
                newRow.Item("itcd") = grdJobDet.CurrentRow.Cells("itcd").Value
                newRow.Item("grade_our") = "BF"
                dtc.Rows.Add(newRow)
            Next
        End If

        SumGrid(grdYarnINDet.DataSource)

    End Function
    Private Function GetNewYarnInDet() As Boolean

        Dim dtc As DataTable = grdYarnINDet.DataSource

        Dim newRow As DataRow


        'newRow("mtl_warehouse_id") = clsConfig.IsNull(dtc.Rows(0)("mtl_warehouse_id"), DBNull.Value)
        'newRow("mtl_locations_id") = clsConfig.IsNull(dtc.Rows(0)("mtl_locations_id"), DBNull.Value)


        newRow = dtc.NewRow


        dtc.Rows.Add(newRow)


        SumGrid(grdYarnINDet.DataSource)

    End Function

    Private Sub mDGV_CellValidating(ByVal sender As Object, ByVal e As DataGridViewCellValidatingEventArgs)
        Dim dgv As DataGridView = DirectCast(sender, DataGridView)
        Dim cell As DataGridViewComboBoxCell = TryCast(dgv.CurrentCell, DataGridViewComboBoxCell)

        If cell IsNot Nothing AndAlso Not cell.Items.Contains(e.FormattedValue) Then

            ' Insert the new value into position 0
            ' in the item collection of the cell
            cell.Items.Insert(0, e.FormattedValue)
            ' When setting the Value of the cell, the  
            ' string is not shown until it has been
            ' comitted. The code below will make sure 
            ' it is committed directly.
            If dgv.IsCurrentCellDirty Then
                ' Ensure the inserted value will 
                ' be shown directly.
                ' First tell the DataGridView to commit 
                ' itself using the Commit context...
                dgv.CommitEdit(DataGridViewDataErrorContexts.Commit)
            End If
            ' ...then set the Value that needs 
            ' to be committed in order to be displayed directly.
            cell.Value = cell.Items(0)
        End If
    End Sub

    Private Sub BindData(ByVal dt As DataTable)
        dtpDocDt.Value = CDate(dt.Rows(0)("docdt2"))
        txtPurNo.Text = clsConfig.IsNull(dt.Rows(0)("purno"), "")
        cboSupplier.SelectedValue = dt.Rows(0)("suppcd")
        txtSinvno.Text = clsConfig.IsNull(dt.Rows(0)("sinvno"), "")
        dtpSinvdt.Value = clsConfig.IsNull(dt.Rows(0)("sinvdt"), "01/01/1900")

        txtLotno_sup.Text = clsConfig.IsNull(dt.Rows(0)("lotno_sup"), "")
        txtSrefno.Text = clsConfig.IsNull(dt.Rows(0)("srefno"), "")
        txtRemark.Text = clsConfig.IsNull(dt.Rows(0)("remark"), "")
    End Sub

    Private Sub SumGrid(ByVal dt As DataTable)
        Dim spools As Double = 0
        Dim kg_gr As Double = 0
        Dim kg_nt As Double = 0
        If Not dt Is Nothing Then
            If dt.Rows.Count > 0 Then
                For i As Integer = 0 To dt.Rows.Count - 1
                    If dt.Rows(i).RowState <> DataRowState.Deleted Then
                        spools = spools + Val(clsConfig.IsNull(dt.Rows(i).Item("spools"), 0))
                        kg_gr = kg_gr + Val(clsConfig.IsNull(dt.Rows(i).Item("kg_gr"), 0))
                        kg_nt = kg_nt + Val(clsConfig.IsNull(dt.Rows(i).Item("kg_nt"), 0))
                    End If
                Next
                txtTotalBoxes.Text = FormatNumber(dt.Rows.Count, 0, TriState.False, TriState.False, TriState.False)
                txtTotalTubes.Text = FormatNumber(spools, 0, TriState.False, TriState.False, TriState.False)
                txtTotalGrossWeight.Text = FormatNumber(kg_gr, 2, TriState.False, TriState.False, TriState.False)
                txtTotalNetWeight.Text = FormatNumber(kg_nt, 2, TriState.False, TriState.False, TriState.False)
                netKg = kg_nt
            End If
        End If
    End Sub

    Private Sub SaveDataYarn()

        Dim dt As DataTable = grdYarnINDet.DataSource
        Dim config As New clsConfig
        If dt.Rows.Count > 0 Then
            For i = 0 To dt.Rows.Count - 1
                If dt.Rows(i).RowState <> DataRowState.Deleted Then
                    If config.IsNull(dt.Rows(i)("docdt2"), "01/01/1900") <> dtpDocDt.Value.ToString("dd/MM/yyyy") Then dt.Rows(i)("docdt2") = dtpDocDt.Value.ToString("dd/MM/yyyy")
                    If config.IsNull(dt.Rows(i)("purno"), "") <> txtPurNo.Text Then dt.Rows(i)("purno") = txtPurNo.Text
                    If config.IsNull(dt.Rows(i)("suppcd"), "") <> cboSupplier.SelectedValue Then dt.Rows(i)("suppcd") = cboSupplier.SelectedValue
                    If config.IsNull(dt.Rows(i)("sinvno"), "") <> txtSinvno.Text Then dt.Rows(i)("sinvno") = txtSinvno.Text
                    If config.IsNull(dt.Rows(i)("sinvdt"), "01/01/1900") <> dtpSinvdt.Text Then dt.Rows(i)("sinvdt") = dtpSinvdt.Text
                    If config.IsNull(dt.Rows(i)("lotno_sup"), "") <> txtLotno_sup.Text Then dt.Rows(i)("lotno_sup") = txtLotno_sup.Text
                    If config.IsNull(dt.Rows(i)("srefno"), "") <> txtSrefno.Text Then dt.Rows(i)("srefno") = txtSrefno.Text
                    If config.IsNull(dt.Rows(i)("remark"), "") <> txtRemark.Text Then dt.Rows(i)("remark") = txtRemark.Text
                    If config.IsNull(dt.Rows(i)("tran_type"), "") <> "PURCHASE" Then dt.Rows(i)("tran_type") = "PURCHASE"

                    If config.IsNull(dt.Rows(i)("mtl_warehouse_id"), 0) <> cbomtl_warehouse.SelectedValue Then dt.Rows(i)("mtl_warehouse_id") = cbomtl_warehouse.SelectedValue
                    If config.IsNull(dt.Rows(i)("mtl_subinventory_id"), 0) <> cbomtl_subinventory.SelectedValue Then dt.Rows(i)("mtl_subinventory_id") = cbomtl_subinventory.SelectedValue
                    If config.IsNull(dt.Rows(i)("mtl_locations_id"), 0) <> cbomtl_locations.SelectedValue Then dt.Rows(i)("mtl_locations_id") = cbomtl_locations.SelectedValue
                    If config.IsNull(dt.Rows(i)("loc"), "") <> cbomtl_locations.Text Then dt.Rows(i)("loc") = cbomtl_locations.Text
                End If
            Next
            If (New classYarnInCustomerYarn).SaveData(dt, clsUser.UserID, docno) Then
                ErrorProvider1.Clear()
                txtDocNo.Text = docno

                Call InitDataBinding()
                Call LoadDataJOB(txtPurNo.Text.Trim)
                Call GenCombo()
                Call GenComboGradeOur()
                ' Call genCboGKNo()
            End If

        End If
    End Sub

    Private Function CheckData() As Boolean
        Dim clsconfig As New clsConfig
        If clsconfig.IsNull(cbomtl_warehouse.SelectedValue, 0) = 0 Then
            MessageBox.Show("คุณยังไม่ไดเลือก WareHouse")
            ErrorProvider1.SetError(cbomtl_warehouse, "คุณยังไม่ไดเลือก WareHouse")
            CheckData = False
            Exit Function
        End If

        If Val(cbomtl_subinventory.SelectedValue) = 0 Then
            MessageBox.Show("คุณยังไม่ได้เลือก Subinventory")
            ErrorProvider1.SetError(cbomtl_subinventory, "คุณยังไม่ได้เลือก Subinventory")
            CheckData = False
            Exit Function
        End If

        If clsconfig.IsNull(cbomtl_locations.SelectedValue, 0) = 0 Then
            MessageBox.Show("คุณยังไม่ไดเลือก Location")
            ErrorProvider1.SetError(cbomtl_locations, "คุณยังไม่ได้เลือก Locations")
            CheckData = False
            Exit Function
        End If

        CheckData = True
    End Function

    Private Sub formYarnIN_2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized

        Call InitControl()
        Call InitDataBinding()
        Call LoadDataJOB(txtPurNo.Text.Trim)
        Call GenCombo()
        Call GenComboGradeOur()
        'Call genCboGKNo()
    End Sub

    Private Sub InitDataBinding()

        dtYarnIn = (New classYarnInCustomerYarn).GetYarnIn(pdocno:=txtDocNo.Text.Trim)
        bsYarnIn.DataSource = dtYarnIn

        dtYarnInDet = (New classYarnInCustomerYarn).GetYarnInDet(pdocno:=txtDocNo.Text.Trim)
        bsYarnInDet.DataSource = dtYarnInDet

        grdYarnINDet.AutoGenerateColumns = False
        grdYarnINDet.DataSource = bsYarnInDet.DataSource

        Call BindingData() '

        'dtJob = (New classYarnInCustomerYarn).getJob(txtPurNo.Text.Trim)
        'bsJob.DataSource = dtJob

        dtJobDet = (New classYarnInCustomerYarn).getJobDet(txtPurNo.Text.Trim)
        bsJobDet.DataSource = dtJobDet

        grdJobDet.AutoGenerateColumns = False
        grdJobDet.DataSource = bsJobDet.DataSource

    End Sub

    Private Sub BindingData()
        Call ClearDataBindings()
        'Yarn In
        txtDocNo.DataBindings.Add("text", bsYarnIn, "docno")
        dtpDocDt.DataBindings.Add("text", bsYarnIn, "docdt")

        txtPurNo.DataBindings.Add("text", bsYarnIn, "purno")
        'Yarn In Det
        cbomtl_warehouse.DataBindings.Add("SelectedValue", bsYarnInDet, "mtl_warehouse_id")
        Call GetComboNewSubInventory(Int64mtl_warehouse_id:=(New clsConfig).IsNull(cbomtl_warehouse.SelectedValue, Nothing))
        cbomtl_subinventory.DataBindings.Add("SelectedValue", bsYarnInDet, "mtl_subinventory_id")
        Call GetComboLocation(Int64mtl_warehouse_id:=(New clsConfig).IsNull(cbomtl_warehouse.SelectedValue, Nothing),
                              Int64mtl_subinventory_id:=(New clsConfig).IsNull(cbomtl_subinventory.SelectedValue, Nothing))
        cbomtl_locations.DataBindings.Add("SelectedValue", bsYarnInDet, "mtl_locations_id")

        'Job
        cboSupplier.DataBindings.Add("SelectedValue", bsYarnIn, "suppcd")
        txtSinvno.DataBindings.Add("text", bsYarnIn, "sinvno")
        dtpSinvdt.DataBindings.Add("text", bsYarnIn, "sinvdt")
        txtLotno_sup.DataBindings.Add("text", bsYarnIn, "lotno_sup")
        txtSrefno.DataBindings.Add("text", bsYarnIn, "srefno")
        txtRemark.DataBindings.Add("text", bsYarnIn, "remark")

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


    Private Sub GenComboGradeOur()
        Dim classYarnIn As New classYarnIn
        Dim clsmaster As New classMaster

        Dim dt As New DataTable
        Dim dtWH As New DataTable
        Dim dtLoc As New DataTable

        dt = classYarnIn.GetDataGradeOUR()
        dtWH = clsmaster.Combomtlwarehouse(clsUser.UserID)
        dtLoc = clsmaster.Combomtllocations(INt64mtl_warehouse_id:=0, strUSerID:=clsUser.UserID)

        Dim cbograde_ourColumn As New DataGridViewComboBoxColumn
        Dim cbomtl_warehouseColumn As New DataGridViewComboBoxColumn
        Dim cbomtl_LocationColumn As New DataGridViewComboBoxColumn

        cbograde_ourColumn = cbograde_our

        cbograde_ourColumn.DataSource = dt
        cbograde_ourColumn.DisplayMember = "grade_code"
        cbograde_ourColumn.ValueMember = "grade_code"

    End Sub

    Private Sub btnNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNew.Click
        Call InitControl()
        Call InitDataBinding()
        Call LoadDataJOB(txtPurNo.Text.Trim)
        Call GenCombo()
        Call GenComboGradeOur()
        ' Call genCboGKNo()
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Me.Validate()
        Dim result As DialogResult
        result = MessageBox.Show("Would you like to save ?", "System Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button3)
        If result <> DialogResult.Yes Then Exit Sub

        If Not CheckData() Then Exit Sub

        'grdYarnIN.EndEdit(DataGridViewDataErrorContexts.Commit)
        ' grdYarnIN.CurrentCell = grdYarnIN.Rows(0).Cells(0)

        Call SaveDataYarn()
    End Sub

    'Private Function CheckData()
    '    For i = 0 To grdYarnIN.Rows.Count - 1
    '        If clsConfig.IsNull(Me.grdYarnIN.Rows(i).Cells("mtl_warehouse_id").Value, 0) = 0 Then
    '            MsgBox("WareHouse is incorrect, please select")
    '            Return False
    '        End If
    '        If clsConfig.IsNull(Me.grdYarnIN.Rows(i).Cells("mtl_subinventory_id").Value, 0) = 0 Then
    '            MsgBox("SubInventory is incorrect, please select")
    '            Return False
    '        End If
    '        If clsConfig.IsNull(Me.grdYarnIN.Rows(i).Cells("mtl_locations_id").Value, 0) = 0 Then
    '            MsgBox("Location is incorrect, please check")
    '            Return False
    '        End If
    '        grdYarnIN.Rows(i).Cells("loc").Value = (New clsConfig).IsNull(cbomtl_locations.Text, "")
    '        'grdYarnIN.Rows(i).Cells("loc").Value = Me.grdYarnIN.Rows(i).Cells("mtl_locations_id").FormattedValue.ToString()
    '    Next

    '    Return True
    'End Function

    Private Sub btnPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrint.Click
        Dim clsConn As New classConnection
        Dim rptFileName As String = "rptYarnIn.rpt"
        Dim frm As New frmReport

        If Not clsConfig.CheckReport(clsuser.reportpath, rptFileName) Then Exit Sub
        Dim rpt As New CrystalDecisions.CrystalReports.Engine.ReportDocument
        Dim stype As String = ""
        Dim ord As String = ""
        Me.Cursor = Cursors.WaitCursor

        rpt.Load(clsuser.reportpath & rptFileName)
        rpt.DataSourceConnections.Item(0).SetConnection(clsConn.ServerName, clsConn.Database, False)
        rpt.DataSourceConnections.Item(0).SetLogon(clsConn.UserName, clsConn.Password)
        rpt.VerifyDatabase()
        rpt.SetParameterValue("@docno", txtDocNo.Text)

        frm.CRViewer.ReportSource = rpt
        frm.MdiParent = Me.ParentForm
        frm.Title = "Yarn In"
        frm.Show()
        Me.Cursor = Cursors.Default
    End Sub
    Private Sub printReport()
        Dim clsConn As New classConnection
        Dim rptFileName As String = "rptYarnQASampleTestForm.rpt"
        Dim frm As New frmReport

        If Not clsConfig.CheckReport(clsuser.reportpath, rptFileName) Then Exit Sub
        Dim rpt As New CrystalDecisions.CrystalReports.Engine.ReportDocument
        Dim stype As String = ""
        Dim ord As String = ""
        Me.Cursor = Cursors.WaitCursor

        rpt.Load(clsuser.reportpath & rptFileName)
        rpt.DataSourceConnections.Item(0).SetConnection(clsConn.ServerName, clsConn.Database, False)
        rpt.DataSourceConnections.Item(0).SetLogon(clsConn.UserName, clsConn.Password)
        rpt.VerifyDatabase()
        rpt.SetParameterValue("@p_qa_sample_header_id", cboGKNo.SelectedValue)

        frm.Title = "Yarn Test Requirement Form (YT)"
        frm.CRViewer.ReportSource = rpt
        frm.MdiParent = Me.ParentForm
        frm.Show()

        Me.Cursor = Cursors.Default
    End Sub
    Private Sub btnPrintBarcode_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrintBarcode.Click
        If docno.Length = 0 Then Exit Sub
        Dim frm As New formPrintBarcode

        frm.loginEmpcd = clsUser.UserID
        frm.UserInfo = clsUser
        frm.Show()

        frm.txtYarn_in_no.Text = docno

        frm.btnFindByYarnInClick()
        frm.SelectAll(sender, e)
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub txtPONo_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtPurNo.KeyDown
        If e.KeyCode = Keys.Enter Then
            Call LoadDataJOB(txtPurNo.Text.Trim.ToUpper)
        End If
    End Sub

    Private Sub txtDocNo_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtDocNo.KeyDown
        If e.KeyCode = Keys.Enter Then
            ' Call InitDataBinding()
            ' Call txtPONo_KeyDown(sender, e)
            Call InitDataBinding()
            Call LoadDataJOB(txtPurNo.Text.Trim)
            Call GenCombo()
            Call GenComboGradeOur()
            Call genCboGKNo()
            Call SumGrid(grdYarnINDet.DataSource)
            'Call LoadDataJOB(txtPurNo.Text.Trim.ToUpper)
            'Call LoadDataYarn(txtDocNo.Text.Trim)
        End If
    End Sub

    Private Sub grdPO_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs)
        If grdJobDet.Rows.Count > 0 Then
            jobID = grdJobDet.Rows(e.RowIndex).Cells("colID").Value
            Stritcd = grdJobDet.Rows(e.RowIndex).Cells("itcd").Value

        End If

    End Sub

    Private Sub grdYarnIN_CausesValidationChanged(sender As Object, e As System.EventArgs) Handles grdYarnINDet.CausesValidationChanged

    End Sub



    Private Sub grdYarnIN_DefaultValuesNeeded(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewRowEventArgs) Handles grdYarnINDet.DefaultValuesNeeded
        'If grdYarnIN.Rows.Count > 1 And e.Row.Index > 0 Then

        '    Try
        '        e.Row.Cells("cboitcd").Value = grdPO.CurrentRow.Cells("itcd").Value
        '        e.Row.Cells("grade").Value = grdYarnIN.Item("grade", e.Row.Index - 1).Value
        '        e.Row.Cells("cbograde_our").Value = grdYarnIN.Item("cbograde_our", e.Row.Index - 1).Value 'Add By Neung
        '        e.Row.Cells("spools").Value = grdYarnIN.Item("spools", e.Row.Index - 1).Value
        '        e.Row.Cells("kg_gr").Value = grdYarnIN.Item("kg_gr", e.Row.Index - 1).Value
        '        e.Row.Cells("kg_nt").Value = grdYarnIN.Item("kg_nt", e.Row.Index - 1).Value
        '        e.Row.Cells("cart_tearwt").Value = grdYarnIN.Item("cart_tearwt", e.Row.Index - 1).Value
        '        e.Row.Cells("loc").Value = grdYarnIN.Item("loc", e.Row.Index - 1).Value
        '        e.Row.Cells("mtl_warehouse_id").Value = grdYarnIN.Item("mtl_warehouse_id", e.Row.Index - 1).Value 'Add By Neung
        '        e.Row.Cells("mtl_locations_id").Value = grdYarnIN.Item("mtl_locations_id", e.Row.Index - 1).Value 'Add By Neung
        '    Catch ex As Exception

        '    End Try

        'End If

        'If grdPO.Rows.Count > 0 Then
        '    e.Row.Cells("id_jobdet").Value = grdPO.CurrentRow.Cells("colID").Value

        'End If

    End Sub



    Private Sub grdYarnIN_RowLeave(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles grdYarnINDet.RowLeave
        'If Not grdYarnINDet.DataSource Is Nothing Then
        '    If grdYarnINDet.Rows.Count > 1 Then
        '        If grdYarnINDet.CurrentCell.IsInEditMode Then
        '            Dim cell As DataGridViewCell = grdYarnINDet.CurrentCell
        '            If grdYarnINDet.EndEdit(DataGridViewDataErrorContexts.Commit) Then
        '                grdYarnINDet.CurrentCell = grdYarnINDet.Rows(0).Cells(0)
        '                grdYarnINDet.CurrentCell = cell
        '            Else
        '                grdYarnINDet.CancelEdit()
        '            End If
        '        End If
        '    End If
        'End If

        Me.Validate()
        Call SumGrid(grdYarnINDet.DataSource)
    End Sub

    Private Sub grdPO_CellContentDoubleClick(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles grdJobDet.CellContentDoubleClick
        Call AddNewBox(1)
    End Sub

    Private Sub grdPO_RowEnter(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles grdJobDet.RowEnter


    End Sub

    Private Sub grdPO_CellEnter(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles grdJobDet.CellEnter


    End Sub



    Private Sub grdYarnIN_CellEndEdit(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles grdYarnINDet.CellEndEdit
        SumGrid(grdYarnINDet.DataSource)

    End Sub

    Private Sub grdPO_CellContentClick_1(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles grdJobDet.CellContentClick

    End Sub

    Private Sub txtPONo_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtPurNo.TextChanged

    End Sub

    Private Sub btnAdd_Click(sender As System.Object, e As System.EventArgs) Handles btnAdd.Click
        Dim userMsg As String
        userMsg = Microsoft.VisualBasic.InputBox("How many Boxes do you need to add?" & vbCrLf & "ต้องการเพิ่มกี่กล่อง?",
                                                 "System Message", "1")

        If IsNumeric(userMsg) Then
            Call AddNewBox(userMsg)
        End If

    End Sub

    Private Sub grdYarnIN_CellContentClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles grdYarnINDet.CellContentClick

    End Sub

    Private Sub btnDel_Click(sender As System.Object, e As System.EventArgs) Handles btnDel.Click
        Dim result As DialogResult
        result = MessageBox.Show("Would You Like To Delete Current Box ?", "System Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button3)
        If result = DialogResult.No Then Exit Sub
        Call RemoveNewBox()
        Call SumGrid(grdYarnINDet.DataSource)
    End Sub
    Private Sub RemoveNewBox()

        For Each row As DataGridViewRow In grdYarnINDet.SelectedRows
            grdYarnINDet.Rows.Remove(row)
        Next

        'For Each row As DataGridViewRow In grdYarnINDet.Rows
        '    If (New clsConfig).IsNull(row.Cells("sel").Value, False) = True Then
        '        grdYarnINDet.Rows.Remove(row)
        '    End If
        'Next

    End Sub

    Private Function GetCopyStep(ByVal Qty As Integer) As Boolean
        Dim objdb As New classMaster
        Dim dtc As DataTable = grdYarnINDet.DataSource

        If grdYarnINDet.Rows.Count > 0 Then
            For i = 1 To Qty
                Dim newRow As DataRow
                newRow = dtc.NewRow
                newRow.Item("itcd") = grdYarnINDet.CurrentRow.Cells("cboITCD").Value
                newRow.Item("grade") = grdYarnINDet.CurrentRow.Cells("grade").Value
                newRow.Item("grade_our") = grdYarnINDet.CurrentRow.Cells("cbograde_our").Value
                newRow.Item("boxno_s") = grdYarnINDet.CurrentRow.Cells("boxno_s").Value
                newRow.Item("spools") = grdYarnINDet.CurrentRow.Cells("spools").Value
                newRow.Item("kg_gr") = grdYarnINDet.CurrentRow.Cells("kg_gr").Value
                newRow.Item("kg_nt") = grdYarnINDet.CurrentRow.Cells("kg_nt").Value
                newRow.Item("cart_tearwt") = grdYarnINDet.CurrentRow.Cells("cart_tearwt").Value
                newRow.Item("boxno") = grdYarnINDet.CurrentRow.Cells("boxno").Value
                newRow.Item("loc") = grdYarnINDet.CurrentRow.Cells("loc").Value
                newRow.Item("mtl_warehouse_id") = clsConfig.IsNull(grdYarnINDet.CurrentRow.Cells("mtl_warehouse_id").Value, DBNull.Value)

                'Dim dt = New DataTable
                'dt = objdb.GetCombomtl_subinventory(clsConfig.IsNull(grdYarnIN.CurrentRow.Cells("mtl_warehouse_id").Value, 1))
                'newRow.Item("mtl_subinventory_id") = dt.NewRow

                newRow.Item("mtl_subinventory_id") = clsConfig.IsNull(grdYarnINDet.CurrentRow.Cells("mtl_subinventory_id").Value, DBNull.Value)
                newRow.Item("mtl_locations_id") = clsConfig.IsNull(grdYarnINDet.CurrentRow.Cells("mtl_locations_id").Value, DBNull.Value)
                newRow.Item("loc_sub") = grdYarnINDet.CurrentRow.Cells("loc_sub").Value
                newRow.Item("id_jobdet") = grdYarnINDet.CurrentRow.Cells("id_jobdet").Value
                newRow.Item("box_remark") = grdYarnINDet.CurrentRow.Cells("box_remark").Value


                dtc.Rows.Add(newRow)
            Next


            Call SumGrid(grdYarnINDet.DataSource)
            Return True
        End If

        Return False

    End Function

    Private Sub grdYarnIN_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles grdYarnINDet.KeyDown
        If e.KeyCode = Keys.Enter Then
            Call GetCopyStep(1)
        End If
    End Sub

    Private Sub txtDocNo_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtDocNo.TextChanged

    End Sub


    Private Sub grdYarnIN_CellValueChanged(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles grdYarnINDet.CellValueChanged
        'Call SumGrid(grdYarnINDet.DataSource)

    End Sub

    Private Sub grdYarnIN_CellClick(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles grdYarnINDet.CellClick
        'grdYarnIN.BeginEdit(True)
        'If grdYarnIN.Rows(e.RowIndex).Cells("mtl_warehouse").Selected = True Then

        '    'DirectCast(grdYarnIN.EditingControl, DataGridViewComboBoxEditingControl).DroppedDown = True
        '    Dim dgvcc As New DataGridViewComboBoxCell

        '    dgvcc = grdYarnIN.Rows(e.RowIndex).Cells("mtl_Location")


        '    dgvcc.DataSource = clsMaster.CombomtllocationsByWarehouse_id(Int64mtl_warehouse_id:=grdYarnIN.Rows(e.RowIndex).Cells("mtl_warehouse").Value, strUSerID:=clsUser.UserID)
        '    dgvcc.DisplayMember = "location_name"
        '    dgvcc.ValueMember = "mtl_locations_id"
        '    DirectCast(grdYarnIN.EditingControl, DataGridViewComboBoxEditingControl).DroppedDown = True
        'End If

        'If grdYarnIN.Columns(e.ColumnIndex).Name = "mtl_warehouse" Then


        '    Dim dgvcc As New DataGridViewComboBoxCell

        '    dgvcc = grdYarnIN.Rows(e.RowIndex).Cells("mtl_Location")


        '    dgvcc.DataSource = clsMaster.Combomtllocations(Int64mtl_warehouse_id:=grdYarnIN.Rows(e.RowIndex).Cells("mtl_warehouse").Value, strUSerID:=clsUser.UserID)
        '    dgvcc.DisplayMember = "location_name"
        '    dgvcc.ValueMember = "mtl_locations_id"

        'End If
    End Sub

    Private Sub grdYarnIN_CellValidated(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles grdYarnINDet.CellValidated
        'Auto
        Dim objdb As New classMaster
        Dim dgvccSubInven As New DataGridViewComboBoxCell
        Dim dtSubInven As New DataTable
        If grdYarnINDet.Columns(e.ColumnIndex).Name = "mtl_warehouse_id" Then
            If Not IsDBNull(grdYarnINDet.Rows(e.RowIndex).Cells("mtl_warehouse_id").Value) Then
                dtSubInven = objdb.GetCombomtl_subinventory(grdYarnINDet.Rows(e.RowIndex).Cells("mtl_warehouse_id").Value)
                dgvccSubInven = grdYarnINDet.Rows(e.RowIndex).Cells("mtl_subinventory_id")

                Try
                    dgvccSubInven.DataSource = dtSubInven
                    dgvccSubInven.DisplayMember = "subinventory_code"
                    dgvccSubInven.ValueMember = "mtl_subinventory_id"
                    'dgvccSubInven.Value = dtSubInven.Rows(0)("mtl_subinventory_id") 'Fix Error

                    Dim expression As String
                    expression = "subinventory_code like '%YARN%'"
                    Dim foundRows() As DataRow
                    foundRows = dtSubInven.Select(expression)
                    dgvccSubInven.Value = foundRows(0)("mtl_subinventory_id")
                Catch ex As Exception

                    'SetDefault
                    Dim expression As String
                    expression = "subinventory_code like '%YARN%'"
                    Dim foundRows() As DataRow
                    foundRows = dtSubInven.Select(expression)

                    'dgvccSubInven.Value = foundRows(0)(0)
                    dgvccSubInven.Value = DBNull.Value
                End Try
            End If
        End If

        Dim dgvcc As New DataGridViewComboBoxCell
        Dim dt3 As New DataTable
        If grdYarnINDet.Columns(e.ColumnIndex).Name = "mtl_warehouse_id" Or grdYarnINDet.Columns(e.ColumnIndex).Name = "mtl_subinventory_id" Then
            If Not IsDBNull(grdYarnINDet.Rows(e.RowIndex).Cells("mtl_warehouse_id").Value) And Not IsDBNull(grdYarnINDet.Rows(e.RowIndex).Cells("mtl_subinventory_id").Value) Then
                dt3 = objdb.Combomtllocations(clsUser.UserID, grdYarnINDet.Rows(e.RowIndex).Cells("mtl_warehouse_id").Value, grdYarnINDet.Rows(e.RowIndex).Cells("mtl_subinventory_id").Value)
                dgvcc = grdYarnINDet.Rows(e.RowIndex).Cells("mtl_locations_id")
                Try
                    dgvcc.DataSource = dt3
                    dgvcc.DisplayMember = "location_name"
                    dgvcc.ValueMember = "mtl_locations_id"
                    'dgvcc.Value = dt3.Rows(0)("mtl_locations_id") 'Fix Error
                    'dgvcc.Value = grdYarnIN.Rows(e.RowIndex).Cells("mtl_locations_id").Value
                    dgvcc.Value = DBNull.Value 'K Suresh Need Default Value = Null
                Catch ex As Exception
                    dgvcc.DataSource = dt3
                    dgvcc.DisplayMember = "location_name"
                    dgvcc.ValueMember = "mtl_locations_id"
                    dgvcc.Value = DBNull.Value
                End Try
            End If
        End If

        Call SumGrid(grdYarnINDet.DataSource)
    End Sub

    Private Sub cbomtl_subinventory_DropDownClosed(sender As Object, e As System.EventArgs) Handles cbomtl_subinventory.DropDownClosed
        Call GetComboLocation(Int64mtl_warehouse_id:=(New clsConfig).IsNull(cbomtl_warehouse.SelectedValue, Nothing),
                        Int64mtl_subinventory_id:=(New clsConfig).IsNull(cbomtl_subinventory.SelectedValue, Nothing))
    End Sub

    Private Sub cboNewmtl_subinventory_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cbomtl_subinventory.SelectedIndexChanged

    End Sub

    Private Sub cbomtl_warehouse_DropDownClosed(sender As Object, e As System.EventArgs) Handles cbomtl_warehouse.DropDownClosed
        Call GetComboNewSubInventory(Int64mtl_warehouse_id:=(New clsConfig).IsNull(cbomtl_warehouse.SelectedValue, Nothing))

        Call GetComboLocation(Int64mtl_warehouse_id:=(New clsConfig).IsNull(cbomtl_warehouse.SelectedValue, Nothing),
                         Int64mtl_subinventory_id:=(New clsConfig).IsNull(cbomtl_subinventory.SelectedValue, Nothing))
    End Sub

    Private Sub cbomtl_warehouse_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cbomtl_warehouse.SelectedIndexChanged

    End Sub

    Private Sub grdYarnIN_CellEnter(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles grdYarnINDet.CellEnter

    End Sub

    Private Sub txtItmFind_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtItmFind.KeyPress

        bsJobDet.Filter = "itcd like '%" + txtItmFind.Text.Trim + "%'"
        Me.Validate()
        ' Sitthana 18/08/2018
        If e.KeyChar = vbCr Then
            With grdJobDet
                If .Rows.Count > 0 Then
                    Dim SearchWithinThis As String = ""

                    For i As Integer = .CurrentRow.Index + 1 To .Rows.Count - 1
                        SearchWithinThis = .Rows(i).Cells("itcd").Value.ToString.ToUpper
                        If SearchWithinThis.IndexOf(txtItmFind.Text.ToUpper) <> -1 Then
                            .CurrentCell = .Rows(i).Cells("itcd")
                            Exit For
                        End If
                    Next
                    If .CurrentRow.Index = 0 Then
                        SearchWithinThis = .Rows(.CurrentRow.Index).Cells("itcd").Value.ToString.ToUpper
                        If SearchWithinThis.IndexOf(txtItmFind.Text.ToUpper) = -1 Then
                            MessageBox.Show("ไม่พบข้อมูล Item Code ที่คุณต้องการหา", "รายงานผลการค้นหาข้อมูล", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        End If
                    End If
                End If
            End With
        End If
    End Sub
    Private Sub genCboGKNo()
        'Sitthana 20200117
        'Dim dt As DataTable
        'Dim QASampleHeaderId As Integer = 0
        'dt = (New classYarnIn).getGKNo(txtPurNo.Text.Trim _
        '                             , grdYarnINDet.Rows(0).Cells("id_jobdet").Value _
        '                             , txtLotno_sup.Text.Trim _
        '                             , txtDocNo.Text.Trim
        '                               )
        'If dt.Rows.Count <> 0 Then
        '    QASampleHeaderId = dt.Rows(0)("qa_sample_header_id")
        '    cboGKNo.DataSource = dt
        '    cboGKNo.DisplayMember = "sample_code"
        '    cboGKNo.ValueMember = "qa_sample_header_id"
        'Else
        '    cboGKNo.DataSource = Nothing
        'End If

    End Sub
    Private Sub btnPrnYarnTest_Click(sender As Object, e As EventArgs) Handles btnPrnYarnTest.Click
        'Sitthana 20200117
        'If txtPurNo.Text.Trim <> "" Then
        '    If cboGKNo.SelectedIndex = -1 Then
        '        'If MessageBox.Show("คุณต้องการ สร้าง ใบนำส่งเส้นด้ายเพื่อไปทำการตรวจสอบ ใช่หรือไม่", "Question Message", MessageBoxButtons.OKCancel, MessageBoxIcon.Question
        '        ') = vbOK Then
        '        Dim objfrm = New STV.frmQASample
        '        objfrm.logempcd = clsUser.UserID
        '        objfrm.PoNo = txtPurNo.Text.Trim
        '        objfrm.ShowDialog()
        '        'End If
        '    Else
        '        If MessageBox.Show("คุณต้องการ สร้าง ใบนำส่งเส้นด้ายเพื่อไปทำการตรวจสอบ ใช่หรือไม่" & vbCr _
        '                          & "(Do you need to create new GK No or not?)" _
        '                          , "Question Message", MessageBoxButtons.OKCancel, MessageBoxIcon.Question
        '                            ) = vbOK Then
        '            Dim objfrm = New STV.frmQASample
        '            objfrm.logempcd = clsUser.UserID
        '            objfrm.PoNo = txtPurNo.Text.Trim
        '            objfrm.ShowDialog()
        '        Else
        '            printReport()
        '        End If
        '    End If
        'End If
    End Sub

    Private Sub GroupBox6_Enter(sender As Object, e As EventArgs) Handles GroupBox6.Enter

    End Sub

    Private Sub btnNewYarnTest_Click(sender As Object, e As EventArgs) Handles btnNewYarnTest.Click
        'Dim objfrm = New STV.frmQASample
        'objfrm.logempcd = clsUser.UserID
        'objfrm.PoNo = txtPurNo.Text.Trim
        'objfrm.ShowDialog()
        'genCboGKNo() 'Sitthana 20200118
    End Sub

    Private Sub btnEditYarnTest_Click(sender As Object, e As EventArgs) Handles btnEditYarnTest.Click
        'If cboGKNo.SelectedIndex >= 0 Then
        '    Dim objfrm = New STV.frmQASample
        '    Dim GKNo As String = ""

        '    objfrm.logempcd = clsUser.UserID
        '    objfrm.PoNo = txtPurNo.Text.Trim

        '    GKNo = cboGKNo.Text.Trim

        '    objfrm.GKNo = GKNo
        '    objfrm.GInMode = "EDIT"
        '    objfrm.ShowDialog()
        '    genCboGKNo() 'Sitthana 20200118
        'End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If cboGKNo.SelectedIndex >= 0 Then
            printReport()
        End If
    End Sub

    Private Sub btnCopy_Click(sender As Object, e As EventArgs) Handles btnCopy.Click
        Dim userMsg As String
        userMsg = Microsoft.VisualBasic.InputBox("How many Boxes do you need to copy?" & vbCrLf & "ต้องการ Copy เพิ่มกี่กล่อง?",
                                                 "System Message", "1")

        If IsNumeric(userMsg) Then
            Call GetCopyStep(userMsg)
        End If

    End Sub
End Class