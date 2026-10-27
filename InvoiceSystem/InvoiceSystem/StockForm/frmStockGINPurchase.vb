Public Class frmStockGINPurchase
    Dim clsUser As New classUserInfo
    Dim clsConfig As New clsConfig
    Dim DbStockG As New classStockG

    Dim blnCancel As Boolean = False
    Dim jobID As Long = 0

    Public Property UserInfo() As classUserInfo
        Get
            UserInfo = clsUser
        End Get
        Set(ByVal NewValue As classUserInfo)
            clsUser = NewValue
        End Set
    End Property

    Private Sub btnSearchOutNo_Click(sender As System.Object, e As System.EventArgs) Handles btnSearchOutNo.Click
        Dim frm As New frmSearchPO
        frm.ShowDialog(Me)
        txtPONo.Text = frm.pPono
        Me.Cursor = Cursors.WaitCursor
        If Not blnCancel Then LoadDataJOB(txtPONo.Text.Trim)
        'If Not blnCancel Then getPO(txtPONo.Text)
        Me.Cursor = Cursors.Default
        frm.Dispose()
    End Sub
    Private Function GetPO(ByVal StrPO As String) As Boolean
        Dim dbStockG As New classStockG
        Dim dt As DataTable = dbStockG.GetGINPOByPO(StrPO, clsUser.UserID)
        If dt.Rows.Count > 0 Then
            Call BindData(dt)
            Return True
        Else
            Return False
        End If
    End Function
    Private Sub BindData(ByVal dt As DataTable)
        Dim config As New clsConfig
        If txtPONo.Text = "" Then Exit Sub
        Dim k As Integer = 0

        grdData.AutoGenerateColumns = False
        If dt.Rows.Count > 0 Then
            Dim dt1 As DataTable = dt
            Dim dt2 As DataTable = grdData.DataSource

            Dim dr As DataRow

            Dim msg As String = ""
            Dim i As Integer = 0
            Dim j As Integer = 0
            For i = 0 To dt.Rows.Count - 1

                'If dt1.Rows(i)("dfno") = dt2.Rows(i)("dfno") Then Exit Sub

                dr = dt2.NewRow

                For j = 0 To dt2.Columns.Count - 1
                    dr("job_line_id") = dt1.Rows(i)("job_line_id")
                    dr("suppcd") = dt1.Rows(i)("suppcd")
                    dr("source_refno") = dt1.Rows(i)("source_refno")
                    dr("dfno") = dt1.Rows(i)("dfno")
                    dr("design_no") = dt1.Rows(i)("design_no")
                    dr("gwth") = dt1.Rows(i)("gwth")
                    'dr("fwth") = dt1.Rows(i)("fwth")
                    dr("col") = dt1.Rows(i)("col")
                    'dr("gr") = dt1.Rows(i)("gr")
                    'dr("custcolor") = dt1.Rows(i)("custcolor")
                    'dr("roll_no_d") = dt1.Rows(i)("roll_no_d")
                    dr("roll_no_o") = dt1.Rows(i)("roll_no_o")
                    dr("sonoid") = dt1.Rows(i)("sonoid")
                    dr("kg") = dt1.Rows(i)("kg")
                    dr("mts") = dt1.Rows(i)("mts")
                    dr("yds") = dt1.Rows(i)("yds")
                    dr("lot") = dt1.Rows(i)("lot")
                    'dr("rem_qc") = dt1.Rows(i)("rem_qc") source_refno
                    dr("roll_no_f") = dt1.Rows(i)("roll_no_f")
                    dr("mcno") = dt1.Rows(i)("mcno")
                    dr("kono") = dt1.Rows(i)("kono")
                    dr("grade") = dt1.Rows(i)("grade")
                    dr("ProdFinishDate") = dt1.Rows(i)("ProdFinishDate")
                    dr("ProdFinishTime") = dt1.Rows(i)("ProdFinishTime")
                    dr("purno") = dt1.Rows(i)("purno")
                    dr("mtl_warehouse_id") = dt1.Rows(i)("mtl_warehouse_id")
                    dr("mtl_subinventory_id") = dt1.Rows(i)("mtl_subinventory_id")
                    dr("mtl_locations_id") = dt1.Rows(i)("mtl_locations_id")
                Next
                dt2.Rows.Add(dr)

            Next

        End If

        'SumGrdData()



    End Sub


    Private Sub frmStockGINPurchase_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        Me.WindowState = FormWindowState.Maximized

        Call InitControl()
    End Sub
    Private Sub InitControl()
        txtGINNo.Text = ""
        dtpGINDATE.Value = Today

        txtPONo.Text = ""
        'txtLot.Text = ""
        'txtsource_refno.Text = ""
        ' txtRemark.Text = ""
        'Call GenCbo()
        Call GenCombo()
        Call BindGrid(grdData, (New classStockG).GetGINPOmanual("", clsUser.UserID))

        grdPO.AutoGenerateColumns = False
        grdPO.DataSource = (New GetDataYarn).getJob("")


        ErrorProvider1.Clear()

        txtPONo.Enabled = True
        txtPONo.Focus()
        'Call BindGrid(grdData, (New classStockG).get("", clsUser.UserID))
    End Sub


    Private Sub GenCbo()
        'Dim objDB As New classStockD
        Dim objDB As New classStockG
        cboGINNo.ComboBox.DataSource = objDB.GetCBOGINPOmanualNo()
        cboGINNo.ComboBox.DisplayMember = "tran_no"
        cboGINNo.ComboBox.ValueMember = "tran_no"

    End Sub

    Private Sub GenCombo()
        Dim objdb As New classMaster
        Dim classStockG As New classStockG
        'Dim clsYarn As GetDataYarn

        cboGINNo.ComboBox.DataSource = classStockG.GetCBOGINPOmanualNo()
        cboGINNo.ComboBox.DisplayMember = "tran_no"
        cboGINNo.ComboBox.ValueMember = "tran_no"

        cbomtl_warehouse.DataSource = (New classMaster).Combomtlwarehouse(clsUser.UserID)
        cbomtl_warehouse.DisplayMember = "warehouse_code"
        cbomtl_warehouse.ValueMember = "mtl_warehouse_id"
        cbomtl_warehouse.SelectedIndex = -1

        cbomtl_subinventory.DataSource = Nothing
        cbomtl_subinventory.SelectedIndex = -1
        cbomtl_Location.DataSource = Nothing
        cbomtl_Location.SelectedIndex = -1

        Call GetComboWarehouseinGrid()
        'Call GetcomboSubInventoryinGrid(Int64mtl_warehouse_id:=objdb.GetdefaultWarehouse(strUSerID:=clsUser.UserID))
        ' Call GetCombomtl_locationInGrid(Int64mtl_warehouse_id:=0, Int64mtl_subinventory_id:=0)

        Dim dt As DataTable = (New GetDataYarn).GetSupplier()
        cboSupplier.DataSource = dt
        cboSupplier.DisplayMember = "name"
        cboSupplier.ValueMember = "suppcd"
        cboSupplier.SelectedIndex = 0

    End Sub

    Private Sub GetComboWarehouseinGrid()
        Dim objdb As New classMaster
        mtl_warehouse_id.DataSource = objdb.Combomtlwarehouse(clsUser.UserID)
        mtl_warehouse_id.DisplayMember = "warehouse_name"
        mtl_warehouse_id.ValueMember = "mtl_warehouse_id"
        'SetdefaultWarehouse()
    End Sub
    Private Sub GetcomboSubInventoryinGrid(ByVal Int64mtl_warehouse_id As Int64)
        Dim objdb As New classMaster
        mtl_subinventory_id.DataSource = objdb.GetCombomtl_subinventory(Int64mtl_warehouse_id)
        mtl_subinventory_id.DisplayMember = "subinventory_name"
        mtl_subinventory_id.ValueMember = "mtl_subinventory_id"
        'Setdefaultsubinventory(0)
    End Sub

    Private Sub GetCombomtl_locationInGrid(ByVal Int64mtl_warehouse_id As Int64, ByVal Int64mtl_subinventory_id As Int64)
        Dim objdb As New classMaster
        mtl_locations_id.DataSource = objdb.Combomtllocations(strUSerID:=clsUser.UserID _
                             , Int64mtl_warehouse_id:=Int64mtl_warehouse_id _
                             , Int64mtl_subinventory_id:=Int64mtl_subinventory_id)
        mtl_locations_id.DisplayMember = "location_name"
        mtl_locations_id.ValueMember = "mtl_locations_id"
    End Sub

    Private Sub Setdefaultsubinventory(ByVal dt As DataTable)
        Dim expression As String
        expression = "subinventory_code like '%GREIGE%'"
        Dim foundRows() As DataRow
        foundRows = dt.Select(expression)
        If foundRows.Length > 0 Then cbomtl_subinventory.SelectedValue = foundRows(0)("mtl_subinventory_id")
    End Sub

    Private Sub SetdefaultsubinventoryInGrid(ByVal Int64mtl_warehouse_id As Int64)

        Dim clsMaster As New classMaster
        Dim dtSubInven As New DataTable

        Dim i As Integer = 0
        For i = 0 To grdData.Rows.Count - 1
            Dim dgvccSubInven As New DataGridViewComboBoxCell
            'dgvccSubInven.Clone()
            dgvccSubInven = grdData.Rows(i).Cells("mtl_subinventory_id")
            dgvccSubInven.DataSource = clsMaster.GetdefaultSubinventory(grdData.Rows(i).Cells("mtl_warehouse_id").Value, Strsubinventory_code:="DYED", strUSerID:=clsUser.UserID)
            dgvccSubInven.DisplayMember = "subinventory_name"
            dgvccSubInven.ValueMember = "mtl_subinventory_id"
            Dim expression As String
            expression = "subinventory_name like '%STOCK DYED%'"
            Dim foundRows() As DataRow
            foundRows = dtSubInven.Select(expression)
            dgvccSubInven.Value = foundRows(0)("mtl_subinventory_id")

        Next
    End Sub

    Private Sub SetDefaultLocation(ByVal dt As DataTable)
        Dim expression As String
        expression = "location_name like '%N/A%'"
        Dim foundRows() As DataRow
        foundRows = dt.Select(expression)

        If foundRows.Length > 0 Then cbomtl_Location.SelectedValue = foundRows(0)(0)

    End Sub

    Private Sub BindGrid(ByRef grd As DataGridView, ByVal dt As DataTable)
        grdData.AutoGenerateColumns = False
        grdData.DataSource = dt
    End Sub
    Private Sub btncopy_Click(sender As System.Object, e As System.EventArgs) Handles btncopy.Click
        Call GetcopyRollNo()
    End Sub
    Private Function GetcopyRollNo() As Boolean
        Dim clsconfig As New clsConfig
        Dim dtc As DataTable = grdData.DataSource
        Dim newrow As DataRow
        If grdData.Rows.Count > 0 Then

            newrow = dtc.NewRow
            newrow.Item("job_line_id") = grdData.CurrentRow.Cells("job_line_id").Value
            newrow.Item("suppcd") = grdData.CurrentRow.Cells("suppcd").Value
            newrow.Item("source_refno") = grdData.CurrentRow.Cells("source_refno").Value
            'newrow.Item("dfno") = grdData.CurrentRow.Cells("dfno").Value
            newrow.Item("design_no") = grdData.CurrentRow.Cells("design_no").Value
            newrow.Item("gwth") = grdData.CurrentRow.Cells("gwth").Value
            newrow.Item("col") = grdData.CurrentRow.Cells("col").Value
            newrow.Item("roll_no_o") = grdData.CurrentRow.Cells("roll_no_o").Value
            newrow.Item("sonoid") = grdData.CurrentRow.Cells("sonoid").Value
            newrow.Item("kg") = grdData.CurrentRow.Cells("kg").Value
            newrow.Item("mts") = grdData.CurrentRow.Cells("mts").Value
            newrow.Item("yds") = grdData.CurrentRow.Cells("yds").Value
            newrow.Item("lot") = grdData.CurrentRow.Cells("lot").Value
            newrow.Item("roll_no_f") = grdData.CurrentRow.Cells("roll_no_f").Value
            newrow.Item("mcno") = grdData.CurrentRow.Cells("mcno").Value
            'newrow.Item("kono") = grdData.CurrentRow.Cells("kono").Value
            newrow.Item("grade") = grdData.CurrentRow.Cells("grade").Value
            'newrow.Item("ProdFinishDate") = grdData.CurrentRow.Cells("ProdFinishDate").Value
            'newrow.Item("ProdFinishTime") = grdData.CurrentRow.Cells("ProdFinishTime").Value
            newrow.Item("purno") = grdData.CurrentRow.Cells("purno").Value
            newrow.Item("preseted") = grdData.CurrentRow.Cells("preseted").Value
            newrow.Item("mtl_warehouse_id") = clsconfig.IsNull(grdData.CurrentRow.Cells("mtl_warehouse_id").Value, DBNull.Value)
            newrow.Item("mtl_subinventory_id") = clsconfig.IsNull(grdData.CurrentRow.Cells("mtl_subinventory_id").Value, DBNull.Value)
            'dr("suppcd") = dt1.Rows(i)("suppcd")
            'dr("source_refno") = dt1.Rows(i)("source_refno")
            'dr("dfno") = dt1.Rows(i)("dfno")
            'dr("design_no") = dt1.Rows(i)("design_no")
            'dr("gwth") = dt1.Rows(i)("gwth")
            'dr("col") = dt1.Rows(i)("col")
            'dr("roll_no_o") = dt1.Rows(i)("roll_no_o")
            'dr("sonoid") = dt1.Rows(i)("sonoid")
            'dr("kg") = dt1.Rows(i)("kg")
            'dr("mts") = dt1.Rows(i)("mts")
            ' dr("yds") = dt1.Rows(i)("yds")
            'dr("lot") = dt1.Rows(i)("lot")
            'dr("roll_no_f") = dt1.Rows(i)("roll_no_f")
            ' dr("mcno") = dt1.Rows(i)("mcno")
            'dr("kono") = dt1.Rows(i)("kono")
            'dr("grade") = dt1.Rows(i)("grade")
            'dr("ProdFinishDate") = dt1.Rows(i)("ProdFinishDate")
            'dr("ProdFinishTime") = dt1.Rows(i)("ProdFinishTime")



            dtc.Rows.Add(newrow)

            Return True


        End If

        Return False

    End Function
    Private Sub cboGINNo_Click(sender As System.Object, e As System.EventArgs) Handles cboGINNo.Click

    End Sub

    Private Sub cboGINNo_DropDownClosed(sender As Object, e As System.EventArgs) Handles cboGINNo.DropDownClosed
        Dim objDB As New classStockG
        If clsConfig.IsNull(cboGINNo.SelectedItem, "").ToString.Length = 0 Then
            'Call GetcomboSubInventoryinGrid(Int64mtl_warehouse_id:=0)
            'Call GetCombomtl_locationInGrid(Int64mtl_warehouse_id:=0, Int64mtl_subinventory_id:=0)
            Call GetGINPOmanual(clsConfig.IsNull(cboGINNo.ComboBox.SelectedValue, ""))
        End If
    End Sub

    Function GetGINPOmanual(ByRef strGINNO As String) As Boolean
        Dim dbStockG As New classStockG
        Dim dt As DataTable = dbStockG.GetGINPOmanual(strGINNO, clsUser.UserID)
        If dt.Rows.Count > 0 Then
            'Dev By Neung 26/03/2015
            Call BindGINPOManual(dt)
            Return True
        End If
        Return False
    End Function

    Private Sub BindGINPOManual(ByVal dt As DataTable)
        Dim config As New clsConfig
        Dim i As Integer = 0
        Dim j As Integer = 0

        grdData.AutoGenerateColumns = False
        grdData.DataSource = dt


        txtGinno.Text = dt.Rows(0)("tran_no").ToString.Trim
        dtpGINDate.Value = CDate(dt.Rows(0)("tran_dt").ToString)

        txtPONo.Text = dt.Rows(0)("purno").ToString.Trim()

        cboSupplier.SelectedValue = dt.Rows(0)("suppcd").ToString.Trim()
        txtSuppInvNo.Text = (New clsConfig).IsNull(dt.Rows(0)("sinvno"), "").ToString.Trim()

        If (New clsConfig).IsNull(dt.Rows(0)("sinvdt"), CDate("01/01/1900")) = CDate("01/01/1900") Then
            dtpsinvdt.Value = CDate("01/01/1900")
            dtpsinvdt.Checked = False
        Else
            dtpsinvdt.Value = dt.Rows(0)("sinvdt")
            dtpsinvdt.Checked = True
        End If


        txtSuppLot.Text = dt.Rows(0)("lotno_sup").ToString.Trim
        txtSuppRefNo.Text = dt.Rows(0)("srefno").ToString.Trim

        If Not dt Is Nothing Then
            If dt.Rows.Count > 0 Then
                cbomtl_warehouse.SelectedValue = dt.Rows(0)("mtl_warehouse_id")
                Call GetComboNewSubInventory(Int64mtl_warehouse_id:=dt.Rows(0)("mtl_warehouse_id"))
                cbomtl_subinventory.SelectedValue = dt.Rows(0)("mtl_subinventory_id")
                Call GetComboLocation(Int64mtl_warehouse_id:=dt.Rows(0)("mtl_warehouse_id"), Int64mtl_subinventory_id:=dt.Rows(0)("mtl_subinventory_id"))
            End If
        End If
        'txtsource_refno.Text = dt.Rows(0)("source_refno").ToString.Trim()

        'txtDINNo.Text = dt.Rows(0)("dinno").ToString.Trim()

        ' txtLot.Text = dt.Rows(0)("lot").ToString.Trim()
        'dtpDINDate.Value = CDate(dt.Rows(0)("dindt").ToString)
        'dtpdodt.Value = config.IsNull(dt.Rows(0)("dodt"), Now)
        ' txtRemark.Text = dt.Rows(0)("rem_qc")

        'Dim dtt As DataTable = grdData.DataSource
        ' txttest.DataBindings.Add("", dt, "lot")

        'SumGrdData()

    End Sub

    Private Sub GetComboNewSubInventory(Optional ByVal Int64mtl_warehouse_id As Nullable(Of Int64) = Nothing)
        Dim objdb As New classMaster

        cbomtl_subinventory.DataSource = objdb.GetCombomtl_subinventory(Int64mtl_warehouse_id)
        cbomtl_subinventory.DisplayMember = "subinventory_code"
        cbomtl_subinventory.ValueMember = "mtl_subinventory_id"
        Dim clsconfig As New clsConfig
        If clsconfig.IsNull(cbomtl_subinventory.SelectedValue, 0) = 0 Then Setdefaultsubinventory(cbomtl_subinventory.DataSource)

    End Sub

    Private Sub GetComboLocation(Optional ByVal Int64mtl_warehouse_id As Nullable(Of Int64) = Nothing, Optional ByVal Int64mtl_subinventory_id As Nullable(Of Int64) = Nothing)
        Dim objdb As New classMaster
        cbomtl_Location.DataSource = objdb.Combomtllocations(strUSerID:=clsUser.UserID, INt64mtl_warehouse_id:=Int64mtl_warehouse_id, Int64mtl_subinventory_id:=Int64mtl_subinventory_id)
        cbomtl_Location.DisplayMember = "location_name"
        cbomtl_Location.ValueMember = "mtl_locations_id"
        Dim clsconfig As New clsConfig
        If clsconfig.IsNull(cbomtl_Location.SelectedValue, 0) = 0 Then SetDefaultLocation(cbomtl_Location.DataSource)
        'SetDefaultLocation(cbomtl_location.DataSource)
    End Sub

    Private Sub btnNew_Click(sender As System.Object, e As System.EventArgs) Handles btnNew.Click
        InitControl()
    End Sub

    Private Sub btnSave_Click(sender As System.Object, e As System.EventArgs) Handles btnSave.Click
        Call SaveData()
    End Sub
    Private Sub SaveData()

        grdData.EndEdit(DataGridViewDataErrorContexts.Commit) 'Fix Bug User
        'grdData.CurrentCell = grdData.Rows(0).Cells("job_line_id") 'Fix Bug User

        'If Not CheckData() Then Exit Sub

        blnCancel = False
        Dim result As DialogResult
        result = MessageBox.Show("Would you like to save ?", "System Message", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button3)
        If result = DialogResult.Cancel Then blnCancel = True
        If result <> DialogResult.Yes Then Exit Sub

        If Not CheckData() Then Exit Sub

        Call SaveGINPOManual()

    End Sub

    Private Function CheckData() As Boolean
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

        If clsconfig.IsNull(cbomtl_Location.SelectedValue, 0) = 0 Then
            MessageBox.Show("คุณยังไม่ไดเลือก Location")
            ErrorProvider1.SetError(cbomtl_Location, "คุณยังไม่ได้เลือก Locations")
            CheckData = False
            Exit Function
        End If

        CheckData = True
    End Function

    Private Function SaveGINPOManual(Optional ByVal strGINNO As String = "") As Boolean

        'For i = 0 To grdData.Rows.Count - 1
        '    If clsConfig.IsNull(Me.grdData.Rows(i).Cells("mtl_warehouse_id").Value, 0) = 0 Then
        '        MsgBox("WareHouse is incorrect, please select")
        '        Exit Function
        '    End If
        '    If clsConfig.IsNull(Me.grdData.Rows(i).Cells("mtl_subinventory_id").Value, 0) = 0 Then
        '        MsgBox("SubInventory is incorrect, please select")
        '        Exit Function
        '    End If
        '    grdData.Rows(i).Cells("loc").Value = Me.grdData.Rows(i).Cells("mtl_locations_id").FormattedValue.ToString()

        'Next

        Dim config As New clsConfig
        config.ChangeCulture()
        Dim objDB As New classStockG
        Dim Greige_Header As New classStockG.Greige_Header
        Dim msgerr As String = ""
        Dim Tran_no As String = strGINNO


        Greige_Header.h01_suppcd = ""
        Greige_Header.h02_source = ""
        Greige_Header.h03_source_refno = ""
        Greige_Header.h04_tran_no = txtGinno.Text
        Greige_Header.h05_tran_dt = dtpGINDate.Value

        Greige_Header.h25_loc = "NEW"

        'Greige_Header.h53_preseted = "1"

        Greige_Header.h70_tran_type = "PURCHASE"


        'For i = 0 To grdData.Rows.Count - 1
        '    grdData.Rows(i).Cells("loc").Value = cbomtl_Location.SelectedText
        'Next

        Dim dtc As DataTable = grdData.DataSource

        For i = 0 To dtc.Rows.Count - 1
            If dtc.Rows(i).RowState = DataRowState.Added Or dtc.Rows(i).RowState = DataRowState.Modified Then
                dtc.Rows(i)("suppcd") = cboSupplier.SelectedValue
                dtc.Rows(i)("sinvno") = txtSuppInvNo.Text.Trim
                dtc.Rows(i)("sinvdt") = IIf(dtpsinvdt.Checked, dtpsinvdt.Value, DBNull.Value)
                dtc.Rows(i)("lotno_sup") = txtSuppLot.Text.Trim
                dtc.Rows(i)("srefno") = txtSuppRefNo.Text.Trim

                dtc.Rows(i)("mtl_warehouse_id") = cbomtl_warehouse.SelectedValue
                dtc.Rows(i)("mtl_subinventory_id") = cbomtl_subinventory.SelectedValue
                dtc.Rows(i)("mtl_locations_id") = cbomtl_Location.SelectedValue
                dtc.Rows(i)("loc") = cbomtl_Location.Text
                'grdData.Rows(i).Cells("loc").Value = cbomtl_Location.SelectedText

            End If
        Next

        Dim dv_dtc_add As New DataView(dtc, "", "", DataViewRowState.Added)
        Dim dv_dtc_upd As New DataView(dtc, "", "", DataViewRowState.ModifiedCurrent)
        Dim dv_dtc_del As New DataView(dtc, "", "", DataViewRowState.Deleted)

        'Dim dts As DataTable = ds.Tables("v_strolls_d")
        'Dim dv_dts_add As New DataView(dts, "", "", DataViewRowState.Added)
        'Dim dv_dts_upd As New DataView(dts, "", "", DataViewRowState.ModifiedCurrent)
        'Dim dv_dts_del As New DataView(dts, "", "", DataViewRowState.Deleted)

        

        If objDB.GINPOsave(Greige_Header, msgerr, dtc, dv_dtc_add, dv_dtc_upd, dv_dtc_del, clsUser.UserID, Tran_no) Then
            strGINNO = Tran_no
            txtGinno.Text = strGINNO.Trim
            MessageBox.Show("Save is Complete! : บันทึกสำเร็จ! ", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
            ' SaveGINPOManual = True
            Call GenCbo()
            Call GetcomboSubInventoryinGrid(Int64mtl_warehouse_id:=0)
            Call GetCombomtl_locationInGrid(Int64mtl_warehouse_id:=0, Int64mtl_subinventory_id:=0)
            Call GetGINPOmanual(clsConfig.IsNull(txtGinno.Text.Trim, ""))
            SaveGINPOManual = True
        Else
            MessageBox.Show(msgerr, "System Message", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
            SaveGINPOManual = False
        End If

    End Function

    Private Sub btnPrint_Click(sender As System.Object, e As System.EventArgs) Handles btnPrint.Click
        'print
        Dim clsconn As New classConnection

        If txtGinno.Text = "" Then Exit Sub
        Const rptFileName = "rptGIN.rpt"
        
        If Not clsConfig.CheckReport(clsUser.ReportPath, rptFileName) Then Exit Sub
        Dim frm As New frmReport
        Dim rpt As New CrystalDecisions.CrystalReports.Engine.ReportDocument
        Me.Cursor = Cursors.WaitCursor

        rpt.Load(clsUser.ReportPath & rptFileName)
        rpt.DataSourceConnections.Item(0).SetConnection(clsConn.servername, clsConn.database, False)
        rpt.DataSourceConnections.Item(0).SetLogon(clsConn.Userid, clsConn.Password)

        rpt.VerifyDatabase()
        rpt.SetParameterValue("@trannofr", txtGinno.Text)
        rpt.SetParameterValue("@trannoto", txtGinno.Text)

        'rpt.PrintOptions.PaperSize = CrystalDecisions.Shared.PaperSize.PaperLetter
        'rpt.PrintOptions.PaperOrientation = CrystalDecisions.Shared.PaperOrientation.Portrait
        'rpt.PrintOptions.PaperSource = CrystalDecisions.Shared.PaperSource.Auto

        frm.Title = "Greige In"
        frm.CRViewer.ReportSource = rpt
        frm.MdiParent = Me.ParentForm
        frm.Show()
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub btnCancel_Click(sender As System.Object, e As System.EventArgs) Handles btnCancel.Click
        Call Canceldata()
    End Sub

    Private Sub Canceldata()

        If CancelGINPO() Then
            GenCbo()
            InitControl()
        Else
            Exit Sub
        End If

    End Sub
    Public Function CancelGINPO(Optional ByVal strGINNO As String = "") As Boolean
        Dim config As New clsConfig
        config.ChangeCulture()
        Dim objDB As New classStockG
        Dim Greige_Header As New classStockG.Greige_Header
        Dim msgerr As String = ""
        Dim Tran_no As String = strGINNO


        Greige_Header.h01_suppcd = ""
        Greige_Header.h02_source = ""
        Greige_Header.h03_source_refno = ""
        Greige_Header.h04_tran_no = txtGinno.Text
        Greige_Header.h05_tran_dt = dtpGINDate.Value

        Dim dtc As DataTable = grdData.DataSource

        Dim dv_dtc_add As New DataView(dtc, "", "", DataViewRowState.Added)
        Dim dv_dtc_upd As New DataView(dtc, "", "", DataViewRowState.ModifiedCurrent)
        Dim dv_dtc_del As New DataView(dtc, "", "", DataViewRowState.Deleted)

        'Dim dts As DataTable = ds.Tables("v_strolls_d")
        'Dim dv_dts_add As New DataView(dts, "", "", DataViewRowState.Added)
        'Dim dv_dts_upd As New DataView(dts, "", "", DataViewRowState.ModifiedCurrent)
        'Dim dv_dts_del As New DataView(dts, "", "", DataViewRowState.Deleted)

        blnCancel = False
        Dim result As DialogResult
        result = MessageBox.Show("Would you like to cancel document no. " & txtGinno.Text & " ?", "System Message", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button3)
        If result = DialogResult.Cancel Then blnCancel = True
        If result <> DialogResult.Yes Then Exit Function

        If objDB.GINPOcancel(Greige_Header, msgerr, dtc, dv_dtc_add, dv_dtc_upd, dv_dtc_del, clsUser.UserID, Tran_no) Then
            strGINNO = Tran_no
            txtGinno.Text = strGINNO.Trim
            MessageBox.Show("Cancel is Complete! : ยกเลิกสำเร็จ! ", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
            CancelGINPO = True
        Else
            MessageBox.Show(msgerr, "System Message", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
            CancelGINPO = False
        End If



    End Function

    Private Sub txtPONo_Enter(sender As Object, e As System.EventArgs) Handles txtPONo.Enter

    End Sub

    Private Sub txtPONo_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles txtPONo.KeyDown
        If e.KeyCode = Keys.Enter Then LoadDataJOB(txtPONo.Text.Trim)

        'If e.KeyCode = Keys.Enter Then
        '    If Not blnCancel Then GetPO(txtPONo.Text)

        'End If
    End Sub

    Private Sub LoadDataJOB(ByVal jobno As String)
        Dim dt As DataTable
        Dim clsyarn As New GetDataYarn
        If txtPONo.Text = ("FREE SAMPLE") Or txtPONo.Text = ("FREE OF CHARGE") Then
            'grdYarnIN.Columns(1).ReadOnly = False
            dt = clsYarn.getJobFree(jobno)
        Else
            dt = clsYarn.getJob(jobno)
        End If

        If dt.Rows.Count > 0 Then
            grdPO.AutoGenerateColumns = False
            grdPO.DataSource = dt
            jobID = clsConfig.IsNull(dt.Rows(0).Item("id_jobdet"), 0)

            cboSupplier.SelectedValue = dt.Rows(0).Item("suppcd")

        End If

        'GridView1.Columns(3).Visible = True

    End Sub
    Private Sub txtPONo_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtPONo.TextChanged

    End Sub

    Private Sub grdData_CellBeginEdit(sender As Object, e As System.Windows.Forms.DataGridViewCellCancelEventArgs) Handles grdData.CellBeginEdit
        Dim objdb As New classMaster
        Dim dgvccSubInven As New DataGridViewComboBoxCell
        Dim dtSubInven As New DataTable
        If grdData.Columns(e.ColumnIndex).Name = "mtl_subinventory_id" Then
            If Not IsDBNull(grdData.Rows(e.RowIndex).Cells("mtl_warehouse_id").Value) Then
                dtSubInven = objdb.GetCombomtl_subinventory(grdData.Rows(e.RowIndex).Cells("mtl_warehouse_id").Value)
                dgvccSubInven = grdData.Rows(e.RowIndex).Cells("mtl_subinventory_id")
                Try
                    dgvccSubInven.DataSource = dtSubInven
                    dgvccSubInven.DisplayMember = "subinventory_name"
                    dgvccSubInven.ValueMember = "mtl_subinventory_id"
                    Dim expression As String
                    If grdData.Rows(e.RowIndex).Cells("preseted").Value = True Then
                        expression = "subinventory_name like '%GREIGE PRESET%'"
                    Else
                        expression = "subinventory_name like '%STOCK GREIGE%'"
                    End If
                    'expression = "subinventory_name like '%STOCK GREIGE%'"
                    Dim foundRows() As DataRow
                    foundRows = dtSubInven.Select(expression)
                    dgvccSubInven.Value = foundRows(0)("mtl_subinventory_id")
                Catch ex As Exception
                    Dim expression As String
                    expression = "subinventory_name like '%STOCK GREIGE%'"
                    Dim foundRows() As DataRow
                    foundRows = dtSubInven.Select(expression)
                    'dgvccSubInven.Value = foundRows(0)(0)
                    dgvccSubInven.Value = DBNull.Value
                End Try
            End If
        End If
    End Sub

    Private Sub grdData_CellEndEdit(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles grdData.CellEndEdit
        If e.RowIndex < 0 Or e.ColumnIndex < 0 Then Exit Sub
        If grdData.Columns(e.ColumnIndex).Name = "kg" Or _
         grdData.Columns(e.ColumnIndex).Name = "yds" Or _
         grdData.Columns(e.ColumnIndex).Name = "mts" Then
            If CBool(chkAutoCalculate.Checked) Then
                Dim dt As DataTable = grdData.DataSource
                Dim i As Integer = CheckDelRow(dt)

                If (New clsConfig).IsNull(dt.Rows(e.RowIndex + i)("ydkg"), 0) = 0 Then
                    MessageBox.Show("Cannot Calculate Because ydkg on design is emply", "System Messsage")
                    Exit Sub
                End If

                If grdData.Columns(e.ColumnIndex).Name = "kg" Then
                    dt.Rows(e.RowIndex + i)("yds") = FormatNumber(dt.Rows(e.RowIndex + i)("kg") * dt.Rows(e.RowIndex + i)("ydkg"), 2, TriState.False, TriState.False, TriState.False)
                    dt.Rows(e.RowIndex + i)("mts") = FormatNumber(dt.Rows(e.RowIndex + i)("yds") * 0.9144, 2, TriState.False, TriState.False, TriState.False)
                End If
                If grdData.Columns(e.ColumnIndex).Name = "yds" Then
                    If Val(dt.Rows(e.RowIndex + i)("ydkg")) > 0 Then dt.Rows(e.RowIndex + i)("kg") = FormatNumber(dt.Rows(e.RowIndex + i)("yds") / dt.Rows(e.RowIndex + i)("ydkg"), 2, TriState.False, TriState.False, TriState.False)
                    dt.Rows(e.RowIndex + i)("mts") = FormatNumber(dt.Rows(e.RowIndex + i)("yds") * 0.9144, 2, TriState.False, TriState.False, TriState.False)
                End If
                If grdData.Columns(e.ColumnIndex).Name = "mts" Then
                    dt.Rows(e.RowIndex + i)("yds") = FormatNumber(dt.Rows(e.RowIndex + i)("mts") / 0.9144, 2, TriState.False, TriState.False, TriState.False)
                    If Val(dt.Rows(e.RowIndex + i)("ydkg")) > 0 Then dt.Rows(e.RowIndex + i)("kg") = FormatNumber(dt.Rows(e.RowIndex + i)("yds") / dt.Rows(e.RowIndex + i)("ydkg"), 2, TriState.False, TriState.False, TriState.False)
                End If
            End If

        End If

        'Auto
        Dim objdb As New classMaster
        Dim dgvccSubInven As New DataGridViewComboBoxCell
        Dim dtSubInven As New DataTable
        If grdData.Columns(e.ColumnIndex).Name = "preseted" Then
            If Not IsDBNull(grdData.Rows(e.RowIndex).Cells("mtl_warehouse_id").Value) Then
                dtSubInven = objdb.GetCombomtl_subinventory(grdData.Rows(e.RowIndex).Cells("mtl_warehouse_id").Value)
                dgvccSubInven = grdData.Rows(e.RowIndex).Cells("mtl_subinventory_id")

                Try
                    dgvccSubInven.DataSource = dtSubInven
                    dgvccSubInven.DisplayMember = "subinventory_code"
                    dgvccSubInven.ValueMember = "mtl_subinventory_id"

                    Dim expression As String
                    If Not grdData.Rows(e.RowIndex).Cells("preseted").Value Then
                        expression = "subinventory_code = 'GREIGE'"
                    Else
                        expression = "subinventory_code = 'PFD'"
                    End If

                    Dim foundRows() As DataRow
                    foundRows = dtSubInven.Select(expression)
                    dgvccSubInven.Value = foundRows(0)("mtl_subinventory_id")
                Catch ex As Exception
                    dgvccSubInven.Value = DBNull.Value
                End Try
            End If
        End If
        If grdData.Columns(e.ColumnIndex).Name = "mtl_warehouse_id" Then
            If Not IsDBNull(grdData.Rows(e.RowIndex).Cells("mtl_warehouse_id").Value) Then
                dtSubInven = objdb.GetCombomtl_subinventory(grdData.Rows(e.RowIndex).Cells("mtl_warehouse_id").Value)
                dgvccSubInven = grdData.Rows(e.RowIndex).Cells("mtl_subinventory_id")

                Try
                    dgvccSubInven.DataSource = dtSubInven
                    dgvccSubInven.DisplayMember = "subinventory_code"
                    dgvccSubInven.ValueMember = "mtl_subinventory_id"

                    Dim expression As String
                    If Not IsDBNull(grdData.Rows(e.RowIndex).Cells("preseted").Value) Then
                        expression = "subinventory_code = 'GREIGE'"
                    Else
                        expression = "subinventory_code = 'PFD'"
                    End If

                    Dim foundRows() As DataRow
                    foundRows = dtSubInven.Select(expression)
                    dgvccSubInven.Value = foundRows(0)("mtl_subinventory_id")
                Catch ex As Exception
                    dgvccSubInven.Value = DBNull.Value
                End Try
            End If
        End If

        Dim dgvcc As New DataGridViewComboBoxCell
        Dim dt3 As New DataTable
        If grdData.Columns(e.ColumnIndex).Name = "mtl_warehouse_id" Or grdData.Columns(e.ColumnIndex).Name = "mtl_subinventory_id" Then
            If Not IsDBNull(grdData.Rows(e.RowIndex).Cells("mtl_warehouse_id").Value) And Not IsDBNull(grdData.Rows(e.RowIndex).Cells("mtl_subinventory_id").Value) Then
                dt3 = objdb.Combomtllocations(clsUser.UserID, grdData.Rows(e.RowIndex).Cells("mtl_warehouse_id").Value, grdData.Rows(e.RowIndex).Cells("mtl_subinventory_id").Value)
                dgvcc = grdData.Rows(e.RowIndex).Cells("mtl_locations_id")
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
    End Sub

    Private Function CheckDelRow(ByVal dt As DataTable) As Integer 'Add By Neung 20151222
        Dim i As Integer = 0
        Dim j As Integer = 0
        For i = 0 To dt.Rows.Count - 1
            If dt.Rows(i).RowState = DataRowState.Deleted Then j = j + 1
        Next
        Return j
    End Function

    Private Sub grdData_CellContentClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles grdData.CellContentClick

    End Sub

    Private Sub grdData_CellValidated(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles grdData.CellValidated

    End Sub

    Private Sub cboGINNo_Enter(sender As Object, e As System.EventArgs) Handles cboGINNo.Enter

    End Sub

    Private Sub btnAdd_Click(sender As System.Object, e As System.EventArgs) Handles btnAdd.Click
        Call AddNewBox()
    End Sub

    Private Function AddNewBox() As Boolean
        If grdPO.Rows.Count = 0 Then
            Return False
            Exit Function
        End If
        If grdPO.CurrentRow.Cells("colID").Value Is DBNull.Value Then
            Return False
            Exit Function
        End If


        Dim dtc As New DataTable
        'Dim dtPO As New DataTable

        dtc = grdData.DataSource


        Dim newRow As DataRow
        Dim Int32id_jobdet As Nullable(Of Int32)
        Dim strItcd As String
        Dim strjob_line_id As String


        Int32id_jobdet = grdPO.CurrentRow.Cells("colID").Value
        strItcd = grdPO.CurrentRow.Cells("itcd").Value
        strjob_line_id = grdPO.CurrentRow.Cells("po_job_line_id").Value
        newRow = dtc.NewRow

        If grdPO.Rows.Count > 0 Then
            newRow.Item("job_line_id") = strjob_line_id
            newRow.Item("id_jobdet") = Int32id_jobdet
            newRow.Item("design_no") = strItcd
            newRow.Item("ydkg") = grdPO.CurrentRow.Cells("ydkg").Value
            'newRow.Item("grade_our") = "BF"
        End If


        dtc.Rows.Add(newRow)


        'SumGrid(grdYarnIN.DataSource)


    End Function

    Private Sub ToolStrip1_ItemClicked(sender As System.Object, e As System.Windows.Forms.ToolStripItemClickedEventArgs) Handles ToolStrip1.ItemClicked

    End Sub

    Private Sub cbomtl_warehouse_DropDownClosed(sender As Object, e As System.EventArgs) Handles cbomtl_warehouse.DropDownClosed
        Call GetComboNewSubInventory(Int64mtl_warehouse_id:=(New clsConfig).IsNull(cbomtl_warehouse.SelectedValue, Nothing))
        Call GetComboLocation(Int64mtl_warehouse_id:=(New clsConfig).IsNull(cbomtl_warehouse.SelectedValue, Nothing), _
                              Int64mtl_subinventory_id:=(New clsConfig).IsNull(cbomtl_subinventory.SelectedValue, Nothing))
    End Sub

    Private Sub cbomtl_subinventory_DropDownClosed(sender As Object, e As System.EventArgs) Handles cbomtl_subinventory.DropDownClosed
        Call GetComboLocation(Int64mtl_warehouse_id:=(New clsConfig).IsNull(cbomtl_warehouse.SelectedValue, Nothing), _
                              Int64mtl_subinventory_id:=(New clsConfig).IsNull(cbomtl_subinventory.SelectedValue, Nothing))
    End Sub

    Private Sub cbomtl_warehouse_Enter(sender As Object, e As EventArgs) Handles cbomtl_warehouse.Enter

    End Sub

    Private Sub cbomtl_warehouse_HandleCreated(sender As Object, e As EventArgs) Handles cbomtl_warehouse.HandleCreated

    End Sub

    Private Sub cbomtl_warehouse_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cbomtl_warehouse.SelectedIndexChanged

    End Sub
End Class