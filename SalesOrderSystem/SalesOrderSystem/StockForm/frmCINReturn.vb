Public Class frmCINReturn
    'ใช้ frmCuttingIN แทน

    Dim clsconn As New ClassConnection
    Dim clsconfig As New clsConfig
    Dim clsuser As New classUserInfo

    Dim oCIN As New classCIN


    Dim StrDesign_No As String
    Dim StrRollNoD As String
    Dim StrCol As String
    Dim StrCustcol As String
    Dim StrGr As String
    Dim StrBatch As String
    Dim StrFwth As String
    Dim StrKg As String
    Dim StrMts As String
    Dim StrYds As String

    'Dim newrow As DataRow

    Dim StrLot As String

    Dim StrDfNo As String

    Dim blnCancel As Boolean = False

    Dim dtMtlWarehouse As New DataTable
    Dim bsMtlWarehouse As New BindingSource
    Dim dtMtlSubInventory As New DataTable
    Dim bsMtlSubInventory As New BindingSource
    Dim dtmtlLocations As New DataTable
    Dim bsMtlLocations As New BindingSource
    Public Property Userinfo() As classUserInfo
        Get
            Userinfo = clsuser
        End Get
        Set(ByVal Newvalue As classUserInfo)
            clsuser = Newvalue
        End Set
    End Property
    Private Sub frmDINReturn_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
        ' Call GenComboDINReturnNo()
        Call btnNew_Click(sender, e)
    End Sub
    Private Sub InitControl()
        Call GenComboDINReturnNo()
        Call GenCombo()
        Call BindDINReturn(grdStockD, (New classCIN).selectStrollsDRecord("0", clsuser.UserID))

    End Sub
    Private Sub GenComboDINReturnNo()
        Dim objDB As New classCIN
        cboCinNo.ComboBox.DataSource = objDB.selectStrollsDList()
        cboCinNo.ComboBox.DisplayMember = "dinno"
        cboCinNo.ComboBox.ValueMember = "dinno"
        cboCinNo.ComboBox.SelectedIndex = -1
    End Sub

    Private Sub GenCombo()
        Dim objdb As New classMaster

        dtMtlWarehouse = (New classMaster).Combomtlwarehouse(strUSerID:=Userinfo.UserID)
        bsMtlWarehouse.DataSource = dtMtlWarehouse
        cbomtlWarehouse.DataSource = bsMtlWarehouse.DataSource
        cbomtlWarehouse.DisplayMember = "warehouse_code"
        cbomtlWarehouse.ValueMember = "mtl_warehouse_id"


        dtMtlSubInventory = (New classMaster).ComboMtlsubinventory(INt64mtl_warehouse_id:=0)
        bsMtlSubInventory.DataSource = dtMtlSubInventory
        cbomtlSubinventory.DataSource = bsMtlSubInventory.DataSource
        cbomtlSubinventory.DisplayMember = "subinventory_code"
        cbomtlSubinventory.ValueMember = "mtl_subinventory_id"

        dtmtlLocations = (New classMaster).Combomtllocations(INt64mtl_warehouse_id:=0, Int64mtl_subinventory_id:=0)
        bsMtlLocations.DataSource = dtmtlLocations
        cbomtlLocations.DataSource = bsMtlLocations.DataSource
        cbomtlLocations.DisplayMember = "location_name"
        cbomtlLocations.ValueMember = "mtl_locations_id"

        'Begin copy from gmk Sitthana 24/09/2018
        Call GetComboWarehouseinGrid()
        Call GetcomboSubInventoryinGrid(Int64mtl_warehouse_id:=0)
        GetComboLacationInGrid(0, 0) 'Sitthana 24/09/2018
        'End  copy from gmk Sitthana 24/09/2018
    End Sub
    Private Sub GetComboWarehouseinGrid()
        Dim objdb As New classMaster
        mtl_warehouse_id.DataSource = objdb.Combomtlwarehouse(clsuser.UserID)
        mtl_warehouse_id.DisplayMember = "warehouse_code"
        mtl_warehouse_id.ValueMember = "mtl_warehouse_id"
        'SetdefaultWarehouse()
    End Sub
    Private Sub GetcomboSubInventoryinGrid(ByVal Int64mtl_warehouse_id As Int64)
        Dim objdb As New classMaster
        mtl_subinventory_id.DataSource = objdb.ComboMtlsubinventory(Int64mtl_warehouse_id)
        mtl_subinventory_id.DisplayMember = "subinventory_code"
        mtl_subinventory_id.ValueMember = "mtl_subinventory_id"
        'Setdefaultsubinventory(0)
    End Sub
    Private Sub GetComboLacationInGrid(pWarehouseID As Integer, pSubinventoryID As Integer)
        'Sitthana 24/09/2018
        Dim objdb As New classMaster
        mtl_locations_id.DataSource = objdb.GetComboMtlLocation(pWarehouseID, pSubinventoryID)
        mtl_locations_id.DisplayMember = "location_name"
        mtl_locations_id.ValueMember = "mtl_locations_id"

    End Sub
    Private Sub BindGrid(ByRef grdStockD As DataGridView, ByVal dt As DataTable)
        grdStockD.AutoGenerateColumns = False
        grdStockD.DataSource = dt

        'grdData.AutoGenerateColumns = False
        'grdData.DataSource = dt
    End Sub
    Private Sub txtOutNo_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles txtOutNo.KeyDown
        If e.KeyCode = Keys.Enter Then

            Call Getoutno(txtOutNo.Text.Trim)

        End If
    End Sub
    Private Function Getoutno(ByRef Stroutno As String) As Boolean
        Dim dt As DataTable = oCIN.selectStrollsDORecord(Stroutno, clsuser.UserID)
        If dt.Rows.Count > 0 Then
            Call BindDataDoutReturn(dt)
            Call SumGrid() 'Copy from GMK Sitthana 24/09/2018
        End If

    End Function

    Private Sub BindDataDoutReturn(ByVal dt As DataTable)
        Dim config As New clsConfig
        If txtOutNo.Text = "" Then Exit Sub

        'grdStockD.DataSource = New dt

        grdStockD.AutoGenerateColumns = False
        If dt.Rows.Count > 0 Then
            Dim dt1 As DataTable = dt
            Dim dt2 As DataTable = grdStockD.DataSource
            'Dim dt2 As DataTable = grdData.DataSource

            Dim dr As DataRow
            Dim msg As String = ""
            Dim i As Integer = 0
            Dim j As Integer = 0
            For i = 0 To dt1.Rows.Count - 1

                dr = dt2.NewRow

                For j = 0 To dt2.Columns.Count - 1

                    dr("selected") = dt1.Rows(i)("selected")
                    dr("lot") = dt1.Rows(i)("lot")
                    dr("design_no") = dt1.Rows(i)("design_no")
                    dr("roll_no_d") = dt1.Rows(i)("roll_no_d")
                    'dr("col") = dt1.Rows(i)("col")
                    dr("col") = dt1.Rows(i)("col")
                    dr("custcolor") = dt1.Rows(i)("custcolor")
                    dr("gr") = dt1.Rows(i)("gr")
                    dr("batch") = dt1.Rows(i)("batch")
                    dr("fwth") = dt1.Rows(i)("fwth")
                    dr("kg") = dt1.Rows(i)("kg")
                    dr("mts") = dt1.Rows(i)("mts")
                    dr("yds") = dt1.Rows(i)("yds")
                    dr("mtkg") = dt1.Rows(i)("mtkg")  'For Cal
                    dr("sono") = dt1.Rows(i)("sono")
                    dr("sonoid") = dt1.Rows(i)("sonoid")
                    'Begin Copy from gmk Sitthana 24/09/2018
                    dr("mtl_warehouse_id") = dt1.Rows(i)("mtl_warehouse_id")
                    dr("mtl_subinventory_id") = dt1.Rows(i)("mtl_subinventory_id")
                    Me.cbomtlWarehouse.SelectedValue = dt1.Rows(i)("mtl_warehouse_id")
                    bsMtlSubInventory.Filter = "mtl_warehouse_id = '" & (New clsConfig).IsNull(cbomtlWarehouse.SelectedValue, 0) & "'"
                    Me.cbomtlSubinventory.SelectedValue = dt1.Rows(i)("mtl_subinventory_id")
                    bsMtlLocations.Filter = "mtl_warehouse_id = '" & (New clsConfig).IsNull(cbomtlWarehouse.SelectedValue, 0) & "' and mtl_subinventory_id = '" & (New clsConfig).IsNull(cbomtlSubinventory.SelectedValue, 0) & "'"
                    Me.cbomtlLocations.SelectedValue = dt1.Rows(i)("mtl_locations_id")
                    'End  Copy from gmk Sitthana 24/09/2018
                Next
                dt2.Rows.Add(dr)

            Next



        End If



    End Sub


    Private Sub txtOutNo_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtOutNo.TextChanged

    End Sub

    Private Sub btncopy_Click(sender As System.Object, e As System.EventArgs)
        ' Call GetcopyRollNoD()
    End Sub

    Private Function GetcopyRollNoD() As Boolean
        Dim dtc As DataTable = grdStockD.DataSource
        Dim newrow As DataRow
        If grdStockD.Rows.Count > 0 Then

            'StrDesign_No = grdStockD.CurrentRow.Cells("Design_no").Value
            'StrRollNoD = grdStockD.CurrentRow.Cells("roll_no_d").Value
            'StrCol = grdStockD.CurrentRow.Cells("col").Value
            'StrCustcol = grdStockD.CurrentRow.Cells("custcolor").Value
            'StrGr = grdStockD.CurrentRow.Cells("gr").Value
            'StrBatch = grdStockD.CurrentRow.Cells("batch").Value
            'StrFwth = grdStockD.CurrentRow.Cells("fwth").Value
            'StrKg = grdStockD.CurrentRow.Cells("kg").Value
            'StrMts = grdStockD.CurrentRow.Cells("mts").Value
            'StrYds = grdStockD.CurrentRow.Cells("yds").Value

            newrow = dtc.NewRow

            newrow.Item("Design_no") = grdStockD.CurrentRow.Cells("Design_no").Value
            newrow.Item("sono") = grdStockD.CurrentRow.Cells("sono").Value
            newrow.Item("roll_no_d") = grdStockD.CurrentRow.Cells("roll_no_d").Value
            newrow.Item("col") = grdStockD.CurrentRow.Cells("col").Value
            newrow.Item("custcolor") = grdStockD.CurrentRow.Cells("custcolor").Value
            newrow.Item("gr") = grdStockD.CurrentRow.Cells("gr").Value
            newrow.Item("batch") = grdStockD.CurrentRow.Cells("batch").Value
            newrow.Item("fwth") = grdStockD.CurrentRow.Cells("fwth").Value
            newrow.Item("kg") = grdStockD.CurrentRow.Cells("kg").Value
            newrow.Item("mts") = grdStockD.CurrentRow.Cells("mts").Value
            newrow.Item("yds") = grdStockD.CurrentRow.Cells("yds").Value
            newrow.Item("mtkg") = grdStockD.CurrentRow.Cells("mtkg").Value
            dtc.Rows.Add(newrow)

            Return True


        End If

        Return False

    End Function

    Private Sub btnSave_Click(sender As System.Object, e As System.EventArgs) Handles btnSave.Click

        grdStockD.EndEdit()

        'Sitthana 20220624 Changed Windows.Forms.DialogResult To DialogResult
        Dim result As DialogResult ' Windows.Forms.DialogResult
        result = MessageBox.Show("Would you like to save ?", "System Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button3)
        If result <> DialogResult.Yes Then Exit Sub

        If grdStockD.Focus Then grdStockD.Focus() 'Add By Neung 20151211

        If Not CheckData() Then Exit Sub

        If SaveDINReturn() Then
            Call GenComboDINReturnNo()
            cboCinNo.Text = txtCinno.Text
            Call GetDINReturn(txtCinno.Text.Trim)

            'Call BindGrid(grdStockD, (New classStockCIN).GetDINReturn(txtDinno.Text.Trim, clsuser.UserID))


        End If

        '
    End Sub

    Private Function CheckData() As Boolean

        ' Dim dt As DataTable = grdStockD.DataSource

        '============= Check Slect row > 1 =============================
        Dim i As Integer = 0
        For Each row As DataGridViewRow In grdStockD.Rows
            Dim chk As DataGridViewCheckBoxCell = row.Cells("selected")
            If (New clsConfig).IsNull(row.Cells("selected").Value, False) = True Then
                i = i + 1
            End If
        Next
        If i = 0 Then
            MsgBox("Must be select one roll or more then")
            Return False
        End If
        '===============================================================

        '--============= Check Combo Box ============================
        If clsconfig.IsNull(cbomtlWarehouse.SelectedValue, 0) = 0 Then
            MsgBox("WareHouse is incorrect, please select")
            Return False
        End If
        If clsconfig.IsNull(cbomtlSubinventory.SelectedValue, 0) = 0 Then
            MsgBox("SubInventory is incorrect, please select")
            Return False
        End If
        If clsconfig.IsNull(cbomtlLocations.SelectedValue, 0) = 0 Then
            MsgBox("SubInventory is incorrect, please select")
            Return False
        End If


        Return True
    End Function

    Private Function SaveDINReturn() As Boolean
        Dim config As New clsConfig
        clsconfig.ChangeCulture()
        Dim objdb As New classCIN
        Dim msgerr As String = ""
        Dim DINNo As String = Me.txtCinno.Text.Trim
        Dim Din_header As New classCIN.Strolls_DHeader

        Din_header.h01_dinno = Me.txtCinno.Text.Trim
        Din_header.h02_dindt = Me.dtpCINDate.Value
        Din_header.h03_doctyp = "K"
        Din_header.h04_dhcod = "RET"
        'Din_header.h05_dhdono = Me.txtBillNo.Text.Trim
        'Din_header.h06_dhdodt = Me.dtpdodt.Value
        Din_header.h07_dfno = txtOutNo.Text.Trim
        'Din_header.h08_dono = ""
        'If txtBillNo.Text.Trim = "" Then Din_header.h09_dodt = ""
        'If txtBillNo.Text.Trim <> "" Then Din_header.h09_dodt = dtpdodt.Value
        'Din_header.h09_dodt = ""
        'Din_header.h10_design_no = ds.Tables("v_strolls_d").Rows(0).Item("design_no").ToString.Trim
        'Din_header.h13_lot = ""
        'Din_header.h14_yr = ""
        'Din_header.h15_sh = ""
        'Din_header.h16_col = ""
        'Din_header.h17_Gr = ""
        'Din_header.h18_mtkg = 0
        'Din_header.h19_roll_no_d
        'Din_header.h34_lotbatno = ""
        'Din_header.h36_loc = ""
        'Din_header.h38_batch = ""
        'Din_header.h45_unit = ""


        For Each row As DataGridViewRow In grdStockD.Rows
            Dim chk As DataGridViewCheckBoxCell = row.Cells("selected")
            If (New clsConfig).IsNull(row.Cells("selected").Value, False) = True Then
                row.Cells("mtl_warehouse_id").Value = cbomtlWarehouse.SelectedValue
                row.Cells("mtl_subinventory_id").Value = cbomtlSubinventory.SelectedValue
                row.Cells("mtl_locations_id").Value = cbomtlLocations.SelectedValue

            End If
        Next

        Dim dtc As DataTable = grdStockD.DataSource

        Dim dv_dtc_add As New DataView(dtc, "", "", DataViewRowState.Added)
        Dim dv_dtc_upd As New DataView(dtc, "", "", DataViewRowState.ModifiedCurrent)
        Dim dv_dtc_del As New DataView(dtc, "", "", DataViewRowState.Deleted)

        'Dim dv_dtc_add As New DataView(grdStockD.DataSource, "", "", DataViewRowState.Added)
        'Dim dv_dtc_upd As New DataView(grdStockD.DataSource, "", "", DataViewRowState.ModifiedCurrent)
        'Dim dv_dtc_del As New DataView(grdStockD.DataSource, "", "", DataViewRowState.Deleted)

        If objdb.DReturnSave(Din_header, msgerr, dtc, dv_dtc_add, dv_dtc_upd, dv_dtc_del, clsuser.UserID, DINNo) Then
            txtCinno.Text = DINNo
            MessageBox.Show("บันทึกสำเร็จ", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
            SaveDINReturn = True
        Else
            MessageBox.Show(msgerr, "System Message", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
            SaveDINReturn = False
        End If

    End Function

    Private Sub btnSearchOutNo_Click(sender As System.Object, e As System.EventArgs) Handles btnSearchOutNo.Click
        Dim frm As New frmSearchDOUT
        frm.ShowDialog(Me)
        txtOutNo.Text = (frm.pOutno.ToUpper.Trim.ToUpper)

        Me.Cursor = Cursors.WaitCursor
        If Not blnCancel Then
            If Getoutno(txtOutNo.Text) Then

            End If
        End If
        Me.Cursor = Cursors.Default
        frm.Dispose()

    End Sub

    Private Sub btnNew_Click(sender As System.Object, e As System.EventArgs) Handles btnNew.Click
        Call InitControl()
    End Sub

    Private Sub cboDinNo_Click(sender As System.Object, e As System.EventArgs) Handles cboCinNo.Click

    End Sub

    Private Sub cboDinNo_DropDownClosed(sender As Object, e As System.EventArgs) Handles cboCinNo.DropDownClosed
        If clsconfig.IsNull(cboCinNo.ComboBox.SelectedValue, "").ToString.Length = 0 Then Exit Sub
        Call GetDINReturn(clsconfig.IsNull(cboCinNo.ComboBox.SelectedValue, ""))
    End Sub

    Function GetDINReturn(ByRef strDINNO As String) As Boolean

        Dim dt As DataTable = oCIN.selectStrollsDRecord(strDINNO, clsuser.UserID)
        If dt.Rows.Count > 0 Then
            'Dev By Neung 26/03/2015
            Call BindDINReturn(grdStockD, dt)
            Return True
        End If
        Return False

    End Function

    Private Sub BindDINReturn(ByRef grd As DataGridView, ByVal dt As DataTable)

        Dim config As New clsConfig
        Dim i As Integer = 0
        Dim j As Integer = 0

        grdStockD.AutoGenerateColumns = False
        grdStockD.DataSource = dt

        If dt.Rows.Count > 0 Then
            txtCinno.Text = dt.Rows(0)("dinno").ToString.Trim
            dtpCINDate.Value = dt.Rows(0)("dindt").ToString.Trim
            txtOutNo.Text = dt.Rows(0)("dfno").ToString.Trim
            Me.cbomtlWarehouse.SelectedValue = dt.Rows(i)("mtl_warehouse_id")
            bsMtlSubInventory.Filter = "mtl_warehouse_id = '" & (New clsConfig).IsNull(cbomtlWarehouse.SelectedValue, 0) & "'"
            Me.cbomtlSubinventory.SelectedValue = dt.Rows(i)("mtl_subinventory_id")
            bsMtlLocations.Filter = "mtl_warehouse_id = '" & (New clsConfig).IsNull(cbomtlWarehouse.SelectedValue, 0) & "' and mtl_subinventory_id = '" & (New clsConfig).IsNull(cbomtlSubinventory.SelectedValue, 0) & "'"
            Me.cbomtlLocations.SelectedValue = dt.Rows(i)("mtl_locations_id")

            ' txtOutNo.Text = dt.Rows(0)("outno").ToString.Trim
        ElseIf dt.Rows.Count = 0 Then
            txtCinno.Text = ""
            dtpCINDate.Value = Now
            txtOutNo.Text = ""
        End If


    End Sub


    Private Sub grdStockD_CellEndEdit(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles grdStockD.CellEndEdit
        '----------------------------- Funtion Set Default Value mtl_subinventory_id --------------------------------------------------------- 
        Dim objdb As New classMaster
        Dim dgvccSubInven As New DataGridViewComboBoxCell
        Dim dtSubInven As New DataTable
        If grdStockD.Columns(e.ColumnIndex).Name = "mtl_warehouse_id" Then
            If Not IsDBNull(grdStockD.Rows(e.RowIndex).Cells("mtl_warehouse_id").Value) Then
                dtSubInven = objdb.ComboMtlsubinventory(grdStockD.Rows(e.RowIndex).Cells("mtl_warehouse_id").Value)
                dgvccSubInven = grdStockD.Rows(e.RowIndex).Cells("mtl_subinventory_id")
                Try
                    dgvccSubInven.DataSource = dtSubInven
                    dgvccSubInven.DisplayMember = "subinventory_code"
                    dgvccSubInven.ValueMember = "mtl_subinventory_id"
                    Dim expression As String
                    expression = "subinventory_name like '%STOCK DYED%'"
                    Dim foundRows() As DataRow
                    foundRows = dtSubInven.Select(expression)
                    dgvccSubInven.Value = foundRows(0)("mtl_subinventory_id")

                Catch ex As Exception
                    Dim expression As String
                    expression = "subinventory_name like '%STOCK DYED%'"
                    Dim foundRows() As DataRow
                    foundRows = dtSubInven.Select(expression)
                    'dgvccSubInven.Value = foundRows(0)(0)
                    dgvccSubInven.Value = DBNull.Value
                End Try
            End If
        ElseIf grdStockD.Columns(e.ColumnIndex).Name = "mtl_subinventory_id" Then
            If Not IsDBNull(grdStockD.Rows(e.RowIndex).Cells("mtl_warehouse_id").Value) And
               Not IsDBNull(grdStockD.Rows(e.RowIndex).Cells("mtl_subinventory_id").Value) Then
                Dim dgvccLocation As New DataGridViewComboBoxCell
                Dim dtLocation As New DataTable

                dtLocation = objdb.GetComboMtlLocation(grdStockD.Rows(e.RowIndex).Cells("mtl_warehouse_id").Value,
                                                       grdStockD.Rows(e.RowIndex).Cells("mtl_subinventory_id").Value
                                                       )
                dgvccLocation = grdStockD.Rows(e.RowIndex).Cells("mtl_locations_id")
                Try
                    dgvccLocation.DataSource = dtLocation
                    dgvccLocation.DisplayMember = "location_name"
                    dgvccLocation.ValueMember = "mtl_locations_id"
                    'Dim expression As String
                    'expression = "location_name like '%STOCK DYED%'"
                    'Dim foundRows() As DataRow
                    'foundRows = dtSubInven.Select(expression)
                    'dgvccSubInven.Value = foundRows(0)("mtl_subinventory_id")
                Catch ex As Exception
                    'Dim expression As String
                    'expression = "subinventory_name like '%STOCK DYED%'"
                    'Dim foundRows() As DataRow
                    'foundRows = dtSubInven.Select(expression)
                    ''dgvccSubInven.Value = foundRows(0)(0)
                    'dgvccSubInven.Value = DBNull.Value
                End Try
            End If

        End If

        Dim dgvcc As New DataGridViewComboBoxCell
        Dim dt3 As New DataTable
        If grdStockD.Columns(e.ColumnIndex).Name = "mtl_warehouse_id" Or grdStockD.Columns(e.ColumnIndex).Name = "mtl_subinventory_id" Then
            If Not IsDBNull(grdStockD.Rows(e.RowIndex).Cells("mtl_warehouse_id").Value) And Not IsDBNull(grdStockD.Rows(e.RowIndex).Cells("mtl_subinventory_id").Value) Then
                dt3 = objdb.Combomtllocations(clsuser.UserID, grdStockD.Rows(e.RowIndex).Cells("mtl_warehouse_id").Value, grdStockD.Rows(e.RowIndex).Cells("mtl_subinventory_id").Value)
                dgvcc = grdStockD.Rows(e.RowIndex).Cells("mtl_locations_id")
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
        '------------------------------------------------------------End Funtion -------------------------------------------------

    End Sub

    Private Sub btnPrint_Click(sender As System.Object, e As System.EventArgs) Handles btnPrint.Click
        Dim clsConfig As New clsConfig
        Dim rptFileName = "rptDINManual.rpt"
        If clsuser.ReportPath = "" Then clsuser.ReportPath = clsuser.ReportPath
        'clsUser.ReportPath = "C:\Users\DELL\Desktop\GemmaKnits\"
        If Not clsConfig.CheckReport(clsuser.ReportPath, rptFileName) Then Exit Sub
        Dim frm As New frmReport
        Dim rpt As New CrystalDecisions.CrystalReports.Engine.ReportDocument
        Dim stype As String = ""
        Dim ord As String = ""
        Me.Cursor = Cursors.WaitCursor

        rpt.Load(clsuser.ReportPath & rptFileName)
        rpt.DataSourceConnections.Item(0).SetConnection(clsconn.servername, clsconn.database, False)
        rpt.DataSourceConnections.Item(0).SetLogon(clsconn.Userid, clsconn.Password)
        rpt.VerifyDatabase()
        rpt.SetParameterValue("@dinno", txtCinno.Text)

        'rpt.PrintOptions.PaperSize = CrystalDecisions.Shared.PaperSize.PaperA4
        'rpt.PrintOptions.PaperOrientation = CrystalDecisions.Shared.PaperOrientation.Portrait
        'rpt.PrintOptions.PaperSource = CrystalDecisions.Shared.PaperSource.Auto

        frm.Title = "DIN Document"
        frm.CRViewer.ReportSource = rpt
        frm.MdiParent = Me.ParentForm
        frm.Show()
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub btnCancel_Click(sender As System.Object, e As System.EventArgs) Handles btnCancel.Click
        'Sitthana 20220624 Changed Windows.Forms.DialogResult To DialogResult
        Dim result As DialogResult ' Windows.Forms.DialogResult
        result = MessageBox.Show("Would you like to cancel document no. " & txtCinno.Text & " ?", "System Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button3)
        If result <> DialogResult.Yes Then Exit Sub

        If Not CheckDataCancel() Then Exit Sub

        Dim message As String = ""
        If (New classStock).CancelDIN(txtCinno.Text, clsuser.UserID, message) Then
            MessageBox.Show("ยกเลิกสำเร็จ", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
            btnNew_Click(sender, e)
        Else
            MessageBox.Show(message, "System Message", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
        End If
        'BFCancelDIN()
    End Sub

    Private Function CheckDataCancel() As Boolean
        If txtCinno.Text.Trim.Length = 0 Then
            MessageBox.Show("คุณยังไม่ได้เลือก D IN No.", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return False
            Exit Function
        End If

        Return True
    End Function
    Private Sub BFCancelDIN()
        Dim strDinno As String = ""
        If strDinno = "" Then strDinno = txtCinno.Text.Trim.ToUpper
        If strDinno.Length = 0 Then Exit Sub
        If grdStockD.DataSource Is Nothing Then Exit Sub
        If grdStockD.DataSource Is Nothing Then Exit Sub
        If grdStockD.Rows.Count = 0 Then Exit Sub
        If grdStockD.Rows.Count = 0 Then Exit Sub


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


        If CancelDIN() Then
            MessageBox.Show("DIN NO." & vbCrLf & strDinno & "is Cancel", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Call InitControl()
            Call GenComboDINReturnNo()
            'lblCancelled.Visible = True
        End If

    End Sub
    Private Function CancelDIN() As Boolean
        Dim confid As New clsConfig

        Dim obidb As New classCIN
        Dim DINHeader As New classCIN.Strolls_DHeader
        Dim msgerr As String = ""

        Dim DINNo As String = txtCinno.Text.Trim

        DINHeader.h01_dinno = Me.txtCinno.Text.Trim
        DINHeader.h02_dindt = Me.dtpCINDate.Value
        DINHeader.h03_doctyp = ""
        'Din_header.h04_dhcod = ""
        'Din_header.h05_dhdono = Me.txtBillNo.Text.Trim
        'Din_header.h06_dhdodt = Me.dtpdodt.Value
        DINHeader.h07_dfno = ""
        DINHeader.h08_dono = ""
        'DINHeader.h09_dodt = ""
        'Din_header.h10_design_no = ds.Tables("v_strolls_d").Rows(0).Item("design_no").ToString.Trim
        DINHeader.h13_lot = ""
        'Din_header.h14_yr = ""
        'Din_header.h15_sh = ""
        'Din_header.h16_col = ""
        'Din_header.h17_Gr = ""
        'Din_header.h18_mtkg = 0
        'Din_header.h19_roll_no_d


        Dim dtp As DataTable = grdStockD.DataSource
        'Dim dv_dtc_add As New DataView(dtc, "", "", DataViewRowState.Added)
        'Dim dv_dtc_upd As New DataView(dtc, "", "", DataViewRowState.ModifiedCurrent)
        'Dim dv_dtc_del As New DataView(dtc, "", "", DataViewRowState.Deleted)

        If obidb.DINcancel(DINHeader, msgerr, dtp, clsuser.UserID) Then
            CancelDIN = True
        Else
            CancelDIN = False
        End If

    End Function

    Private Sub CalGrdDataYDS()

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

        For j = 0 To grdStockD.Rows.Count - 1
            grdStockD.Rows(j).Cells("yds").Value = FormatNumber(config.IsNull(grdStockD.Rows(j).Cells("mts").Value, 0) / 0.9144, 2, TriState.False, TriState.False, TriState.True)
        Next


        For i = 0 To grdStockD.Rows.Count - 1
            dblKgs = dblKgs + config.IsNull(grdStockD.Rows(i).Cells("kg").Value, 0)
            dblMts = dblMts + config.IsNull(grdStockD.Rows(i).Cells("mts").Value, 0)
            dblYds = dblYds + config.IsNull(grdStockD.Rows(i).Cells("yds").Value, 0)
        Next

        'txtTotalRolls.Text = FormatNumber(grdStockD.Rows.Count, 0, TriState.False, TriState.False, TriState.True)
        'txtTotalKgs.Text = FormatNumber(dblKgs, 2, TriState.False, TriState.False, TriState.True)
        'txtTotalMts.Text = FormatNumber(dblMts, 2, TriState.False, TriState.False, TriState.True)
        'txtTotalYds.Text = FormatNumber(dblYds, 2, TriState.False, TriState.False, TriState.True)

    End Sub

    Private Sub CalGrdDataMTS()

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

        For j = 0 To grdStockD.Rows.Count - 1
            grdStockD.Rows(j).Cells("mts").Value = FormatNumber(config.IsNull(grdStockD.Rows(j).Cells("yds").Value, 0) * 0.9144, 2, TriState.False, TriState.False, TriState.True)
        Next


        For i = 0 To grdStockD.Rows.Count - 1
            dblKgs = dblKgs + config.IsNull(grdStockD.Rows(i).Cells("kg").Value, 0)
            dblMts = dblMts + config.IsNull(grdStockD.Rows(i).Cells("mts").Value, 0)
            dblYds = dblYds + config.IsNull(grdStockD.Rows(i).Cells("yds").Value, 0)
        Next

        'txtTotalRolls.Text = FormatNumber(grdStockD.Rows.Count, 0, TriState.False, TriState.False, TriState.True)
        'txtTotalKgs.Text = FormatNumber(dblKgs, 2, TriState.False, TriState.False, TriState.True)
        'txtTotalMts.Text = FormatNumber(dblMts, 2, TriState.False, TriState.False, TriState.True)
        'txtTotalYds.Text = FormatNumber(dblYds, 2, TriState.False, TriState.False, TriState.True)

    End Sub
    Private Sub grdStockD_CellValueChanged(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles grdStockD.CellValueChanged
        If e.RowIndex < 0 Or e.ColumnIndex < 0 Then Exit Sub
        If grdStockD.Columns(e.ColumnIndex).Name = "kg" Or
         grdStockD.Columns(e.ColumnIndex).Name = "yds" Or
         grdStockD.Columns(e.ColumnIndex).Name = "mts" Then
            If CBool(chkAutoCalculate.Checked) Then
                Dim dt As DataTable = grdStockD.DataSource
                Dim i As Integer = CheckDelRow(dt)
                If clsconfig.IsNull(Val(dt.Rows(e.RowIndex + i)("mtkg")), 0) = 0 Then MessageBox.Show("Design No." & vbCrLf & Val(dt.Rows(e.RowIndex + i)("Design_No")) & vbCrLf & "ไม่ได้ใส่ MT/KG", "SyStem Message", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1)
                If grdStockD.Columns(e.ColumnIndex).Name = "kg" Then
                    If Val(dt.Rows(e.RowIndex + i)("mtkg")) > 0 Then dt.Rows(e.RowIndex + i)("mts") = FormatNumber(dt.Rows(e.RowIndex + i)("kg") * dt.Rows(e.RowIndex + i)("mtkg"), 2, TriState.False, TriState.False, TriState.False)
                    If Val(dt.Rows(e.RowIndex + i)("mtkg")) > 0 Then dt.Rows(e.RowIndex + i)("yds") = FormatNumber(dt.Rows(e.RowIndex + i)("kg") * (dt.Rows(e.RowIndex + i)("mtkg") / 0.9144), 2, TriState.False, TriState.False, TriState.False)
                End If
                If grdStockD.Columns(e.ColumnIndex).Name = "mts" Then
                    If Val(dt.Rows(e.RowIndex + i)("mtkg")) > 0 Then dt.Rows(e.RowIndex + i)("yds") = FormatNumber(dt.Rows(e.RowIndex + i)("mts") / 0.9144, 2, TriState.False, TriState.False, TriState.False)
                    If Val(dt.Rows(e.RowIndex + i)("mtkg")) > 0 Then dt.Rows(e.RowIndex + i)("kg") = FormatNumber(dt.Rows(e.RowIndex + i)("mts") / dt.Rows(e.RowIndex + i)("mtkg"), 2, TriState.False, TriState.False, TriState.False)
                End If
                If grdStockD.Columns(e.ColumnIndex).Name = "yds" Then
                    If Val(dt.Rows(e.RowIndex + i)("mtkg")) > 0 Then dt.Rows(e.RowIndex + i)("kg") = FormatNumber(dt.Rows(e.RowIndex + i)("yds") / (dt.Rows(e.RowIndex + i)("mtkg") * 0.9144), 2, TriState.False, TriState.False, TriState.False)
                    If Val(dt.Rows(e.RowIndex + i)("mtkg")) > 0 Then dt.Rows(e.RowIndex + i)("mts") = FormatNumber(dt.Rows(e.RowIndex + i)("kg") * dt.Rows(e.RowIndex + i)("mtkg"), 2, TriState.False, TriState.False, TriState.False)
                End If

            End If
            Call SumGrid()
        End If
    End Sub

    Private Function CheckDelRow(ByVal dt As DataTable) As Integer
        Dim i As Integer = 0
        Dim j As Integer = 0
        For i = 0 To dt.Rows.Count - 1
            If dt.Rows(i).RowState = DataRowState.Deleted Then j = j + 1
        Next
        Return j
    End Function

    Private Sub SumGrid()
        Dim i As Integer = 0
        Dim rolls As Integer = 0
        Dim kgs As Double = 0
        Dim yds As Double = 0
        Dim mts As Double = 0
        Dim dt As DataTable = grdStockD.DataSource
        For i = 0 To dt.Rows.Count - 1
            If dt.Rows(i).RowState <> DataRowState.Deleted Then
                rolls = rolls + 1
                kgs = kgs + clsconfig.IsNull(dt.Rows(i)("kg"), 0)
                yds = yds + clsconfig.IsNull(dt.Rows(i)("yds"), 0)
                mts = mts + clsconfig.IsNull(dt.Rows(i)("mts"), 0)
            End If
        Next
        txtSelectedRolls.Text = Format(rolls, "#,###")
        txtSelectedKgs.Text = Format(kgs, "#,###.#0")
        txtSelectedYds.Text = Format(yds, "#,###.#0")
        txtSelectedMts.Text = Format(mts, "#,###.#0")
    End Sub

    Private Sub cbomtlWarehouse_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbomtlWarehouse.SelectedIndexChanged

    End Sub

    Private Sub cbomtlWarehouse_DropDownClosed(sender As Object, e As EventArgs) Handles cbomtlWarehouse.DropDownClosed
        bsMtlSubInventory.Filter = "mtl_warehouse_id = '" & (New clsConfig).IsNull(cbomtlWarehouse.SelectedValue, 0) & "'"
        bsMtlLocations.Filter = "mtl_warehouse_id = '" & (New clsConfig).IsNull(cbomtlWarehouse.SelectedValue, 0) & "' and mtl_subinventory_id = '" & (New clsConfig).IsNull(cbomtlSubinventory.SelectedValue, 0) & "'"

    End Sub

    Private Sub cbomtlSubinventory_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbomtlSubinventory.SelectedIndexChanged

    End Sub

    Private Sub cbomtlSubinventory_DropDownClosed(sender As Object, e As EventArgs) Handles cbomtlSubinventory.DropDownClosed
        bsMtlLocations.Filter = "mtl_warehouse_id = '" & (New clsConfig).IsNull(cbomtlWarehouse.SelectedValue, 0) & "' and mtl_subinventory_id = '" & (New clsConfig).IsNull(cbomtlSubinventory.SelectedValue, 0) & "'"

    End Sub



    Private Sub btnSelectAll_Click(sender As Object, e As EventArgs) Handles btnSelectAll.Click
        Dim i As Integer = 0
        ' If e.KeyCode = Keys.Enter Then
        'If grdStockD.Columns(grdStockD.SelectedCells(i).ColumnIndex).Name = "selected" Then
        For i = 0 To grdStockD.Rows.Count - 1
            grdStockD.Rows(i).Cells("selected").Value = True
            'grdStockD.SelectedCells(i).Value = True 'Not CBool(grdStockD.SelectedCells(i).Value)
        Next
        ' End If
        'End If
    End Sub

    Private Sub btnCopyRoll_Click(sender As Object, e As EventArgs) Handles btnCopyRoll.Click
        Call GetcopyRollNoD()
    End Sub

    Private Sub btnChangeCurrRow_Click(sender As Object, e As EventArgs) Handles btnChangeCurrRow.Click
        'Sitthana 24/09/2018
        If MessageBox.Show("คุณยืนยันที่จะเปลี่ยน Sub Inventory / Location ใช่หรือไม่ ?" & vbCr _
                         & "   หมายเหตุ *** เราจะเปลี่ยนเฉพาะ WH ที่ตรงกับข้อมูลเดิมเท่านั้น" _
                         , "ยืนยันการเปลี่ยนแปลงข้อมูล", MessageBoxButtons.OKCancel _
                         , MessageBoxIcon.Question, MessageBoxDefaultButton.Button2
                          ) = vbOK Then
            With grdStockD
                If .Rows.Count > 0 Then
                    ChangeLocation(.CurrentRow.Index)
                End If
            End With
        End If
    End Sub

    Private Sub btnChangeAllRows_Click(sender As Object, e As EventArgs) Handles btnChangeAllRows.Click
        'Sitthana 24/09/2018
        If MessageBox.Show("คุณยืนยันที่จะเปลี่ยน Sub Inventory / Location ใช่หรือไม่ ?" & vbCr _
                         & "   หมายเหตุ *** เราจะเปลี่ยนเฉพาะ WH ที่ตรงกับข้อมูลเดิมเท่านั้น" _
                         , "ยืนยันการเปลี่ยนแปลงข้อมูล", MessageBoxButtons.OKCancel _
                         , MessageBoxIcon.Question, MessageBoxDefaultButton.Button2
                          ) = vbOK Then
            With grdStockD
                For i As Integer = 0 To .Rows.Count - 1
                    ChangeLocation(i)
                Next
            End With
        End If
    End Sub
    Private Sub btnChangeSelectedRows_Click(sender As Object, e As EventArgs) Handles btnChangeSelectedRows.Click
        'Sitthana 24/09/2018
        If MessageBox.Show("คุณยืนยันที่จะเปลี่ยน Sub Inventory / Location ใช่หรือไม่ ?" & vbCr _
                         & "   หมายเหตุ *** เราจะเปลี่ยนเฉพาะ WH ที่ตรงกับข้อมูลเดิมเท่านั้น" _
                         , "ยืนยันการเปลี่ยนแปลงข้อมูล", MessageBoxButtons.OKCancel _
                         , MessageBoxIcon.Question, MessageBoxDefaultButton.Button2
                          ) = vbOK Then
            With grdStockD
                For i As Integer = 0 To .Rows.Count - 1
                    If .Rows(i).Cells("selected").Value = True Then
                        ChangeLocation(i)
                    End If
                Next
            End With
        End If
    End Sub
    Private Sub ChangeLocation(pI As Integer)
        With grdStockD
            If .Rows(pI).Cells("mtl_warehouse_id").Value = cbomtlWarehouse.SelectedValue Then
                .Rows(pI).Cells("mtl_subinventory_id").Value = cbomtlSubinventory.SelectedValue
                .Rows(pI).Cells("mtl_locations_id").Value = cbomtlLocations.SelectedValue
            End If
        End With
    End Sub

    Private Sub tsbDInTag_Click(sender As Object, e As EventArgs) Handles tsbDInTag.Click
        Dim clsConfig As New clsConfig
        Dim rptFileName = "rptStockDBarcode.rpt"
        If clsuser.ReportPath = "" Then clsuser.ReportPath = clsuser.ReportPath
        'clsUser.ReportPath = "C:\Users\DELL\Desktop\GemmaKnits\"
        If Not clsConfig.CheckReport(clsuser.ReportPath, rptFileName) Then Exit Sub
        Dim frm As New frmReport
        Dim rpt As New CrystalDecisions.CrystalReports.Engine.ReportDocument
        Dim stype As String = ""
        Dim ord As String = ""
        Me.Cursor = Cursors.WaitCursor

        rpt.Load(clsuser.ReportPath & rptFileName)
        rpt.DataSourceConnections.Item(0).SetConnection(clsconn.servername, clsconn.database, False)
        rpt.DataSourceConnections.Item(0).SetLogon(clsconn.Userid, clsconn.Password)
        rpt.VerifyDatabase()
        'With grdData
        ' If .Rows.Count > 0 Then
        rpt.SetParameterValue("@roll_no", txtCinno.Text.Trim) '.Rows(.CurrentRow.Index).Cells("roll_no_d").Value)
        rpt.SetParameterValue("@loc", "") '.Rows(.CurrentRow.Index).Cells("loc").Value)
        rpt.SetParameterValue("@logempcd", Userinfo.UserID)
        '   Else
        '    MessageBox.Show("ไม่มีข้อมูลใน grid", "Mistake (ข้อผิดพลาด)", MessageBoxButtons.OK, MessageBoxIcon.Information)
        'Exit Sub
        'End If
        'End With

        'rpt.PrintOptions.PaperSize = CrystalDecisions.Shared.PaperSize.PaperLetter
        'rpt.PrintOptions.PaperOrientation = CrystalDecisions.Shared.PaperOrientation.Portrait
        'rpt.PrintOptions.PaperSource = CrystalDecisions.Shared.PaperSource.Auto

        frm.Title = "DIN Barcode"
        frm.CRViewer.ReportSource = rpt
        frm.MdiParent = Me.ParentForm
        frm.Show()
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub tsbDInDocument_Click(sender As Object, e As EventArgs) Handles tsbDInDocument.Click
        Dim clsConfig As New clsConfig
        Dim rptFileName = "rptDIN.rpt"
        If clsuser.ReportPath = "" Then clsuser.ReportPath = clsuser.ReportPath
        'clsUser.ReportPath = "C:\Users\DELL\Desktop\GemmaKnits\"
        If Not clsConfig.CheckReport(clsuser.ReportPath, rptFileName) Then Exit Sub
        Dim frm As New frmReport
        Dim rpt As New CrystalDecisions.CrystalReports.Engine.ReportDocument
        Dim stype As String = ""
        Dim ord As String = ""
        Me.Cursor = Cursors.WaitCursor

        rpt.Load(clsuser.ReportPath & rptFileName)
        rpt.DataSourceConnections.Item(0).SetConnection(clsconn.servername, clsconn.database, False)
        rpt.DataSourceConnections.Item(0).SetLogon(clsconn.Userid, clsconn.Password)
        rpt.VerifyDatabase()
        rpt.SetParameterValue("@dinnofr", txtCinno.Text.Trim)
        rpt.SetParameterValue("@dinnoto", txtCinno.Text.Trim)

        'rpt.PrintOptions.PaperSize = CrystalDecisions.Shared.PaperSize.PaperA4
        'rpt.PrintOptions.PaperOrientation = CrystalDecisions.Shared.PaperOrientation.Portrait
        'rpt.PrintOptions.PaperSource = CrystalDecisions.Shared.PaperSource.Auto

        frm.Title = "DIN Document"
        frm.CRViewer.ReportSource = rpt
        frm.MdiParent = Me.ParentForm
        frm.Show()
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub tsbHInDocument_Click(sender As Object, e As EventArgs) Handles tsbMInDocument.Click
        Dim clsConfig As New clsConfig
        Dim rptFileName = "rptMin.rpt"
        If clsuser.ReportPath = "" Then clsuser.ReportPath = clsuser.ReportPath
        'clsUser.ReportPath = "C:\Users\DELL\Desktop\GemmaKnits\"
        If Not clsConfig.CheckReport(clsuser.ReportPath, rptFileName) Then Exit Sub
        Dim frm As New frmReport
        Dim rpt As New CrystalDecisions.CrystalReports.Engine.ReportDocument
        Dim stype As String = ""
        Dim ord As String = ""
        Me.Cursor = Cursors.WaitCursor

        rpt.Load(clsuser.ReportPath & rptFileName)
        rpt.DataSourceConnections.Item(0).SetConnection(clsconn.servername, clsconn.database, False)
        rpt.DataSourceConnections.Item(0).SetLogon(clsconn.Userid, clsconn.Password)
        rpt.VerifyDatabase()
        rpt.SetParameterValue("@dinno", txtCinno.Text)

        'rpt.PrintOptions.PaperSize = CrystalDecisions.Shared.PaperSize.PaperA4
        'rpt.PrintOptions.PaperOrientation = CrystalDecisions.Shared.PaperOrientation.Portrait
        'rpt.PrintOptions.PaperSource = CrystalDecisions.Shared.PaperSource.Auto

        frm.Title = "MIN Document"
        frm.CRViewer.ReportSource = rpt
        frm.MdiParent = Me.ParentForm
        frm.Show()
        Me.Cursor = Cursors.Default
    End Sub
End Class