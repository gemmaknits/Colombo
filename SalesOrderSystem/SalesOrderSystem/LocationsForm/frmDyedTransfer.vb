Public Class frmDyedTransfer
    Dim config As New clsConfig
    Dim stock As New classStockTransferD
    Dim TrnH As New classStockTransferD.TrnHeader
    'Dim trn_id As Long = 0
    'Dim trn_no As String = ""
    Dim clsUser As New classUserInfo
    Dim strdono As String
    Dim strdinno As String = ""

    Dim StrRollNoD As String
    Dim StrLot As String
    Dim StrCol As String
    Dim StrDfNo As String

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

    Public Property p_dono As String
        Get
            p_dono = strdono
        End Get
        Set(ByVal Newvalue As String)
            strdono = Newvalue
        End Set
    End Property

    Public Property p_dinno As String
        Get
            p_dinno = strdinno
        End Get
        Set(ByVal Newvalue As String)
            strdinno = Newvalue
        End Set
    End Property

    Private Sub Initialize()
        txtTrnNo.Text = ""
        dtpTrnDate.Value = Now

        grdRollNo.DataSource = vbNull

        TrnH.h01_trn_id = 0
        TrnH.h02_trn_no = ""
        Call LoadData("")
    End Sub

    'Private Sub EnabledControl(ByVal value As Boolean)

    '    grdRollNo.Enabled = value
    'End Sub

    Private Sub BindData(ByVal dt As DataTable)

    End Sub

    Private Sub GetComboTrnNo()
        Dim dt As DataTable = stock.GetTransferNoD()
        cboTrnNo.ComboBox.DataSource = dt
        cboTrnNo.ComboBox.DisplayMember = "trn_no"
        cboTrnNo.ComboBox.ValueMember = "trn_no"
    End Sub


    Private Sub LoadData(ByVal StrTrn_no As String)
        Dim dt As DataTable = stock.GetTransferDetD(StrTrn_no)
        grdRollNo.AutoGenerateColumns = False
        grdRollNo.DataSource = dt

        If dt.Rows.Count > 0 Then
            TrnH.h01_trn_id = dt.Rows(0)("trn_id")
            TrnH.h02_trn_no = dt.Rows(0)("trn_no")
            txtTrnNo.Text = TrnH.h02_trn_no
            dtpTrnDate.Value = dt.Rows(0)("trn_date2")

            Call EnabledControl(False)
        Else
            TrnH.h01_trn_id = 0
            TrnH.h02_trn_no = ""
            txtTrnNo.Text = TrnH.h02_trn_no
            dtpTrnDate.Value = Now
        End If


    End Sub

    Private Sub frmGreigeTransfer_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.WindowState = FormWindowState.Maximized

        Call InitControl()

        Call GetAllCombo()
        Call GetComboTrnNo()
        Call LoadData("")

        If strdinno.Length > 0 Then
            Call GetData(Strroll_no_d:="", strdinno:=strdinno, strdono:="", Strlot:="")
        End If

    End Sub

    Private Sub InitControl()
        Dim obj As Control
        For Each obj In Me.Controls
            Call SetControlValue(obj)
        Next
        Call EnabledControl(True)
        Call SetErrorProvider()

        ChkLocationsEmply.Checked = True
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

    Private Sub GetAllCombo()



        Call GetComboNewWarehouse()
        Call GetComboNewSubInventory((New clsConfig).IsNull(cbomtlwarehouse.SelectedValue, Nothing))

        Call GetComboWarehouseinGrid()
        Call GetcomboSubInventoryinGrid(Int64mtl_warehouse_id:=0)
        Call GetCombomtlLocationInGrid(Int64mtl_warehouse_id:=0, Int64mtl_subinventory_id:=0)
        'Call GetCombomtl_locationInGrid((New clsConfig).IsNull(cbomtl_warehouse.SelectedValue, Nothing), _
        '                                (New clsConfig).IsNull(cbomtl_subinventory.SelectedValue, Nothing))
    End Sub
    Private Sub GetComboNewWarehouse()
        Dim objdb As New classMaster

        cbomtlwarehouse.DataSource = objdb.Combomtlwarehouse(clsUser.UserID)
        cbomtlwarehouse.DisplayMember = "warehouse_code"
        cbomtlwarehouse.ValueMember = "mtl_warehouse_id"
        cbomtlwarehouse.SelectedIndex = -1

    End Sub
    Private Sub GetComboNewSubInventory(Optional ByVal Int64mtl_warehouse_id As Nullable(Of Int64) = Nothing)
        Dim objdb As New classMaster

        cbomtlsubinventory.DataSource = objdb.ComboMtlsubinventory(Int64mtl_warehouse_id)
        cbomtlsubinventory.DisplayMember = "subinventory_code"
        cbomtlsubinventory.ValueMember = "mtl_subinventory_id"
        'cbomtl_subinventory.SelectedValue = -1

    End Sub

    Private Sub GetComboNewLocation(Optional ByVal Int64mtl_warehouse_id As Nullable(Of Int64) = Nothing,
                                    Optional ByVal Int64mtl_subinventory_id As Nullable(Of Int64) = Nothing)
        If ChkLocationsEmply.Checked Then
            cbomtlLocation.DataSource = (New classStockTransferD).Combomtllocations(strUSerID:=clsUser.UserID, INt64mtl_warehouse_id:=Int64mtl_warehouse_id, Int64mtl_subinventory_id:=Int64mtl_subinventory_id)
        Else
            cbomtlLocation.DataSource = (New classMaster).Combomtllocations(strUSerID:=clsUser.UserID, INt64mtl_warehouse_id:=Int64mtl_warehouse_id, Int64mtl_subinventory_id:=Int64mtl_subinventory_id)
        End If

        cbomtlLocation.DisplayMember = "location_name"
        cbomtlLocation.ValueMember = "mtl_locations_id"

    End Sub

    Private Sub GetCombomtlLocationInGrid(Optional ByVal Int64mtl_warehouse_id As Nullable(Of Int64) = Nothing,
                                           Optional ByVal Int64mtl_subinventory_id As Nullable(Of Int64) = Nothing)
        Dim objdb As New classMaster



        mtl_locations_id.DataSource = objdb.Combomtllocations(strUSerID:=clsUser.UserID, INt64mtl_warehouse_id:=0, Int64mtl_subinventory_id:=0)
        mtl_locations_id.DisplayMember = "location_name"
        mtl_locations_id.ValueMember = "mtl_locations_id"

        old_mtl_locations_id.DataSource = objdb.Combomtllocations(strUSerID:=clsUser.UserID, INt64mtl_warehouse_id:=0, Int64mtl_subinventory_id:=0)
        old_mtl_locations_id.DisplayMember = "location_name"
        old_mtl_locations_id.ValueMember = "mtl_locations_id"

    End Sub

    Private Sub GetcomboSubInventoryinGrid(Optional ByVal Int64mtl_warehouse_id As Nullable(Of Int64) = Nothing)
        Dim objdb As New classMaster


        mtl_subinventory_id.DataSource = objdb.ComboMtlsubinventory(0)
        mtl_subinventory_id.DisplayMember = "subinventory_code"
        mtl_subinventory_id.ValueMember = "mtl_subinventory_id"

        old_mtl_subinventory_id.DataSource = objdb.ComboMtlsubinventory(0)
        old_mtl_subinventory_id.DisplayMember = "subinventory_code"
        old_mtl_subinventory_id.ValueMember = "mtl_subinventory_id"
    End Sub
    Private Sub GetComboWarehouseinGrid()
        Dim objdb As New classMaster


        mtl_warehouse_id.DataSource = objdb.Combomtlwarehouse(clsUser.UserID)
        mtl_warehouse_id.DisplayMember = "warehouse_code"
        mtl_warehouse_id.ValueMember = "mtl_warehouse_id"

        old_mtl_warehouse_id.DataSource = objdb.Combomtlwarehouse(clsUser.UserID)
        old_mtl_warehouse_id.DisplayMember = "warehouse_code"
        old_mtl_warehouse_id.ValueMember = "mtl_warehouse_id"
    End Sub
    Private Sub SetdefaultWareHouse()
        Dim clsSO As New classSalesOrder
        Dim dt As New DataTable '= clsSO.Getfulfilment_typeFromSo_Type(ComboSaleOrderType1.SelectedValue)

        If dt.Rows.Count > 0 Then
            'cbofulfilment_type.SelectedValue = dt.Rows(0)("lookup_value_id")
        End If
    End Sub
    Private Sub btnNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNew.Click

        Me.WindowState = FormWindowState.Maximized

        Call InitControl()

        Call GetAllCombo()
        Call GetComboTrnNo()
        Call LoadData("")
        If strdinno.Length > 0 Then
            Call GetData(Strroll_no_d:="", strdinno:=strdinno, strdono:="", Strlot:="")
        End If

    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click


        'Sitthana 20220624 Changed Windows.Forms.DialogResult To DialogResult
        Dim result As DialogResult ' Windows.Forms.DialogResult
        result = MessageBox.Show("Would you like to save ?", "System Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button3)
        If result <> DialogResult.Yes Then Exit Sub

        If Not CheckData() Then Exit Sub

        Call SaveData()
    End Sub

    Public Function CheckData() As Boolean

        For Each row As DataGridViewRow In grdRollNo.Rows

            If (New clsConfig).IsNull((row.Cells("mtl_warehouse_id").Value), "0") = "0" Then
                MessageBox.Show("Must be Enter W/H", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
                ErrorProvider1.SetError(grdRollNo, "Must be Enter W/H")
                CheckData = False
                Exit Function
            End If
            If (New clsConfig).IsNull((row.Cells("mtl_subinventory_id").Value), "0") = "0" Then
                MessageBox.Show("Must be Enter Sub Inventory", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
                ErrorProvider1.SetError(grdRollNo, "Must be Enter Sub Inventory")
                CheckData = False
                Exit Function
            End If
            If (New clsConfig).IsNull((row.Cells("mtl_locations_id").Value), "0") = "0" Then
                MessageBox.Show("Must be Enter Location", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
                ErrorProvider1.SetError(grdRollNo, "Must be Enter Location")
                CheckData = False
                Exit Function
            End If

        Next



        Return True
    End Function

    Private Function SaveData() As Boolean

        Dim dt As DataTable = grdRollNo.DataSource
        'Dim TrnH As New classStockTransferD.TrnHeader
        If grdRollNo.Rows.Count > 0 Then
            For i = 0 To grdRollNo.Rows.Count - 1
                'TrnH.h01_trn_id = trn_id
                TrnH.h02_trn_no = txtTrnNo.Text.Trim
                TrnH.h03_trn_date = dtpTrnDate.Value.ToString("yyyyMMdd")
                TrnH.h04_trn_time = ""
                TrnH.h05_new_location = Me.grdRollNo.Rows(0).Cells("mtl_locations_id").FormattedValue.ToString()
                TrnH.h06_new_sub_location = ""
                TrnH.h07_login_empcd = clsUser.UserID
                'TrnH.h08_mtl_warehouse_id = grdRollNo.Rows(0).Cells("mtl_warehouse_id").Value 'dt.Rows(0)("mtl_warehouse_id")
                'TrnH.h09_mtl_subinventory_id = grdRollNo.Rows(0).Cells("mtl_subinventory_id").Value 'dt.Rows(0)("mtl_locations_id")
                'TrnH.h10_mtl_locations_id = grdRollNo.Rows(0).Cells("mtl_locations_id").Value

            Next
        End If
        Dim dv_add As New DataView(dt, "", "", DataViewRowState.Added)
        Dim dv_upd As New DataView(dt, "", "", DataViewRowState.ModifiedCurrent)
        Dim dv_del As New DataView(dt, "", "", DataViewRowState.Deleted)

        Dim msg_err As String = ""

        If stock.TrnDSave(TrnH, dv_add, dv_upd, dv_del, msg_err) Then
            Call GetComboTrnNo()
            cboTrnNo.Text = TrnH.h02_trn_no.Trim
            Call LoadData(TrnH.h02_trn_no)
        Else
            MessageBox.Show(msg_err, "System Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

        Return True
    End Function

    Private Sub btnPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrint.Click
        If TrnH.h02_trn_no = "" Then TrnH.h02_trn_no = txtTrnNo.Text.Trim
        If TrnH.h02_trn_no.Length = 0 Then Exit Sub
        Const rptFileName = "rptDyedTransfer.rpt"
        Dim clsConfig As New clsConfig
        Dim clsConn As New ClassConnection
        If clsUser.ReportPath = "" Then clsUser.ReportPath = clsUser.ReportPath
        If Not clsConfig.CheckReport(clsUser.ReportPath, rptFileName) Then Exit Sub
        Dim frm As New frmReport
        Dim rpt As New CrystalDecisions.CrystalReports.Engine.ReportDocument
        Dim logonInfo As New CrystalDecisions.Shared.TableLogOnInfo
        Me.Cursor = Cursors.WaitCursor
        logonInfo.ConnectionInfo.ServerName = clsConn.servername
        logonInfo.ConnectionInfo.DatabaseName = clsConn.database
        logonInfo.ConnectionInfo.IntegratedSecurity = False
        logonInfo.ConnectionInfo.UserID = clsConn.Userid
        logonInfo.ConnectionInfo.Password = clsConn.Password

        rpt.Load(clsUser.ReportPath & rptFileName)
        rpt.DataSourceConnections.Item(0).SetConnection(clsConn.servername, clsConn.database, False)
        rpt.DataSourceConnections.Item(0).SetLogon(clsConn.Userid, clsConn.Password)
        rpt.VerifyDatabase()
        rpt.SetParameterValue("@trn_no", TrnH.h02_trn_no)

        'rpt.PrintOptions.PaperSize = CrystalDecisions.Shared.PaperSize.PaperA4
        'rpt.PrintOptions.PaperOrientation = CrystalDecisions.Shared.PaperOrientation.Landscape
        'rpt.PrintOptions.PaperSource = CrystalDecisions.Shared.PaperSource.Auto

        frm.Title = "Dyed Transfer"
        frm.CRViewer.ReportSource = rpt
        frm.MdiParent = Me.ParentForm
        frm.Show()
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click

        Dim StrMessage As String = ""

        If MessageBox.Show("Would you like to cancel this document ?", "System Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = DialogResult.Yes Then
            If stock.TrnDCancel(TrnH.h01_trn_id, clsUser.UserID, StrMessage:=StrMessage) Then
                Call LoadData("")
                MessageBox.Show("Cancelled the document.", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        If MessageBox.Show("Would you like to exit ?", "System Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = DialogResult.Yes Then
            Me.Close()
        End If
    End Sub

    Private Sub cboTrnNo_DropDownClosed(sender As Object, e As System.EventArgs) Handles cboTrnNo.DropDownClosed
        Call LoadData(cboTrnNo.Text.Trim)
    End Sub

    Private Sub cboTrnNo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboTrnNo.SelectedIndexChanged

    End Sub

    Private Sub txtTrnNo_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtTrnNo.KeyDown
        If e.KeyCode = Keys.Enter Then
            Call LoadData(txtTrnNo.Text)
        End If
    End Sub

    Private Sub grdRollNo_CellEndEdit(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles grdRollNo.CellEndEdit
        'If grdRollNo.Columns(e.ColumnIndex).Name = "roll_no_g" Then
        '    If config.IsNull(grdRollNo.Rows(e.RowIndex).Cells("roll_no_g").Value, "") <> "" And config.IsNull(grdRollNo.Rows(e.RowIndex).Cells("g_location").Value, "") = "" Then
        '        Dim dt As DataTable = stock.GetRollLocationD(StrRollNoD:=grdRollNo.Rows(e.RowIndex).Cells("roll_no_g").Value, StrLot:="")
        '        Dim dt2 As DataTable = grdRollNo.DataSource
        '        If dt.Rows.Count > 0 Then
        '            grdRollNo.Rows(e.RowIndex).Cells("g_location").Value = dt.Rows(0)("location")
        '            grdRollNo.Rows(e.RowIndex).Cells("sub_location").Value = dt.Rows(0)("sub_location")
        '            grdRollNo.Rows(e.RowIndex).Cells("status").Value = dt.Rows(0)("status")
        '            grdRollNo.Rows(e.RowIndex).Cells("new_status").Value = dt.Rows(0)("new_status")
        '        End If
        '    End If
        'End If
    End Sub


    Private Sub txtBarcode_Keydown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtBarcode.KeyDown
        If e.KeyCode = Keys.Enter Then

            Call Checkopt()

            Dim dt As New DataTable
            dt = stock.GetRollLocationD(StrRollNoD:=StrRollNoD, StrLot:=StrLot)
            Dim dtRollNo As DataTable = grdRollNo.DataSource
            Dim r As DataRow

            For i = 0 To dt.Rows.Count - 1
                r = dtRollNo.NewRow
                If CheckDuplicate(dt.Rows(i)("roll_no_d").ToString, dtRollNo) Then
                    MessageBox.Show("ยิงข้อมูลซ้ำที่มีอยู่ครับ", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                    Exit Sub
                End If

                r("roll_no_d") = dt.Rows(i)("roll_no_d")
                r("design_no") = dt.Rows(i)("design_no")
                r("lot") = dt.Rows(i)("lot")
                r("col") = dt.Rows(i)("col")
                r("old_mtl_warehouse_id") = dt.Rows(i)("old_mtl_warehouse_id")
                r("old_mtl_subinventory_id") = dt.Rows(i)("old_mtl_subinventory_id")
                r("old_mtl_locations_id") = dt.Rows(i)("old_mtl_locations_id")
                r("mtl_warehouse_id") = dt.Rows(i)("mtl_warehouse_id")
                r("mtl_subinventory_id") = dt.Rows(i)("mtl_subinventory_id")
                r("mtl_locations_id") = dt.Rows(i)("mtl_locations_id")
                r("grade_from") = dt.Rows(i)("grade_from")
                r("grade_to") = dt.Rows(i)("grade_to")
                dtRollNo.Rows.Add(r)

            Next

            txtBarcode.Text = ""
            txtBarcode.Focus()
        End If
    End Sub

    Private Function CheckDuplicate(ByVal Strroll_no_d As String, ByVal dt As DataTable) As Boolean
        If dt.Rows.Count > 0 Then
            Dim i As Integer = 0
            For i = 0 To dt.Rows.Count - 1
                If dt.Rows(i).RowState <> DataRowState.Deleted Then
                    If dt.Rows(i)("roll_no_d").ToString.Trim = Strroll_no_d.Trim Then
                        Return True
                    End If
                End If
            Next
        End If
        Return False
    End Function

    Private Sub GetData(ByVal Strroll_no_d As String, ByVal strdinno As String, ByVal strdono As String, ByVal Strlot As String)
        Dim dt As DataTable
        dt = stock.GetTransferDyedByBarcode(Strroll_no_d:=Strroll_no_d, Strdinno:="", Strdono:="", Strlot:="", StrUSerID:=clsUser.UserID)
        Dim dt2 As DataTable = grdRollNo.DataSource
        Dim r As DataRow

        For i = 0 To dt.Rows.Count - 1
            r = dt2.NewRow

            r("roll_no_d") = dt.Rows(i)("roll_no_d")
            'r("location") = txtLocation.Text
            'r("sub_location") = txtSubLocation.Text

            r("design_no") = dt.Rows(i)("design_no")
            r("lot") = dt.Rows(i)("lot")
            r("col") = dt.Rows(i)("col")
            r("old_mtl_warehouse_id") = dt.Rows(i)("mtl_warehouse_id")
            r("old_mtl_subinventory_id") = dt.Rows(i)("mtl_subinventory_id")
            r("old_mtl_locations_id") = dt.Rows(i)("mtl_locations_id")


            If Not CheckIsDuplicateRollNoD(Roll_no_d:=dt.Rows(i)("roll_no_d").ToString.Trim) Then dt2.Rows.Add(r)

            'txtlot.Enabled = False
        Next
    End Sub




    Public Function CheckIsDuplicateRollNoD(ByVal Roll_no_d As String) As Boolean
        Dim dt2 As New DataTable
        dt2 = grdRollNo.DataSource
        'Dim dt2 As DataTable = DtGrdRollNo


        If dt2.Rows.Count > 0 Then
            For Each row As DataRow In dt2.Rows
                If row("roll_no_d").ToString().Trim.Equals(Roll_no_d) Then
                    MessageBox.Show("คุณกำลังพยายามป้อนม้วนซ้ำ!!!", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
                    Return True
                Else
                    Return False
                End If

            Next
        End If


        Return False
    End Function


    Private Sub cboNewmtl_subinventory_DropDownClosed(sender As Object, e As System.EventArgs) Handles cbomtlsubinventory.DropDownClosed
        Call GetComboNewLocation((New clsConfig).IsNull(cbomtlwarehouse.SelectedValue, Nothing), (New clsConfig).IsNull(cbomtlsubinventory.SelectedValue, Nothing))

    End Sub

    Private Sub cbomtl_warehouse_DropDownClosed(sender As Object, e As System.EventArgs) Handles cbomtlwarehouse.DropDownClosed
        Call GetComboNewSubInventory(Int64mtl_warehouse_id:=(New clsConfig).IsNull(cbomtlwarehouse.SelectedValue, Nothing))
        Call GetComboNewLocation(Int64mtl_warehouse_id:=(New clsConfig).IsNull(cbomtlwarehouse.SelectedValue, Nothing),
                                 Int64mtl_subinventory_id:=(New clsConfig).IsNull(cbomtlsubinventory.SelectedValue, Nothing))
    End Sub

    Private Sub cbomtl_warehouse_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cbomtlwarehouse.SelectedIndexChanged

    End Sub

    Private Sub ApplyRow(RowNo As Integer)
        With grdRollNo
            grdRollNo.Rows(RowNo).Cells("mtl_warehouse_id").Value() = cbomtlwarehouse.SelectedValue

            Dim dgvcc As New DataGridViewComboBoxCell
            dgvcc = grdRollNo.Rows(RowNo).Cells("mtl_subinventory_id")
            dgvcc.DataSource = cbomtlsubinventory.DataSource
            grdRollNo.Rows(RowNo).Cells("mtl_subinventory_id").Value() = cbomtlsubinventory.SelectedValue

            Dim dgvcc2 As New DataGridViewComboBoxCell
            dgvcc2 = grdRollNo.Rows(RowNo).Cells("mtl_locations_id")
            dgvcc2.DataSource = cbomtlLocation.DataSource
            If IsDBNull(cbomtlLocation.DataSource) Then
                grdRollNo.Rows(RowNo).Cells("mtl_locations_id").Value = -1
            Else
                grdRollNo.Rows(RowNo).Cells("mtl_locations_id").Value() = cbomtlLocation.SelectedValue
            End If

        End With
    End Sub
    Private Sub btnApplyCurRow_Click(sender As Object, e As EventArgs) Handles btnApplyCurRow.Click
        ApplyRow(grdRollNo.CurrentRow.Index)
    End Sub
    Private Sub btnApply_Click(sender As System.Object, e As System.EventArgs) Handles btnApplyAll.Click
        Dim dt3 As New DataTable
        For i = 0 To grdRollNo.Rows.Count - 1
            ApplyRow(i)
        Next
    End Sub

    Public Sub Checkopt()

        If optRollNoD.Checked Then
            StrRollNoD = txtBarcode.Text.Trim
            StrLot = ""
            StrCol = ""
            StrDfNo = ""
        ElseIf optLotNo.Checked Then
            StrLot = txtBarcode.Text.Trim
            StrRollNoD = ""
            StrCol = ""
            StrDfNo = ""
        End If

    End Sub

    Private Sub txtBarcode_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtBarcode.TextChanged

    End Sub

    Private Sub txtTrnNo_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtTrnNo.TextChanged

    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles btnApplyGrCurRow.Click
        ApplyRowGrade(grdRollNo.CurrentRow.Index)
    End Sub

    Private Sub ApplyRowGrade(RowNo As Integer)
        With grdRollNo
            grdRollNo.Rows(RowNo).Cells("GradeTo").Value() = txtGradeTo.Text
        End With
    End Sub

    Private Sub btnApplyGrAll_Click(sender As System.Object, e As System.EventArgs) Handles btnApplyGrAll.Click
        Dim dt3 As New DataTable
        For i = 0 To grdRollNo.Rows.Count - 1
            ApplyRowGrade(i)
        Next
    End Sub

    Private Sub cbomtl_subinventory_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbomtlsubinventory.SelectedIndexChanged

    End Sub

    Private Sub ChkLocationsEmply_CheckedChanged(sender As Object, e As EventArgs) Handles ChkLocationsEmply.CheckedChanged
        If Not cbomtlsubinventory.SelectedIndex > -1 Then Exit Sub
        Call GetComboNewLocation((New clsConfig).IsNull(cbomtlwarehouse.SelectedValue, Nothing), (New clsConfig).IsNull(cbomtlsubinventory.SelectedValue, Nothing))

    End Sub

    Private Sub grdRollNo_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles grdRollNo.CellContentClick

    End Sub
End Class