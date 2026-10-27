Public Class frmStockGINPurchase
    Dim clsUser As New classUserInfo
    Dim oConfig As New clsConfig
    Dim oStockG As New classStockG
    Dim clsConn As New ClassConnection
    Dim blnCancel As Boolean = False
    Dim jobID As Long = 0

    Dim dtPO As New DataTable
    Dim dtData As New DataTable

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

        Me.Cursor = Cursors.Default
        frm.Dispose()
    End Sub
    Private Function GetPO(ByVal StrPO As String) As Boolean
        ' Dim dbStockG As New classStockG
        Dim dt As DataTable = oStockG.GetGINPOByPO(StrPO, clsUser.UserID)
        If dt.Rows.Count > 0 Then
            Call addData(dt)
            Return True
        Else
            Return False
        End If
    End Function
    Private Sub addData(ByVal dt As DataTable)
        Dim config As New clsConfig
        If txtPONo.Text = "" Then Exit Sub
        Dim k As Integer = 0

        grdData.AutoGenerateColumns = False
        ' grdData.DataSource = dt


        'If dt.Rows.Count > 0 Then
        '    Dim dt1 As DataTable = dt
        '    Dim dt2 As DataTable = grdData.DataSource

        '    Dim dr As DataRow

        '    Dim msg As String = ""
        '    Dim i As Integer = 0
        '    Dim j As Integer = 0
        '    For i = 0 To dt.Rows.Count - 1

        '        'If dt1.Rows(i)("dfno") = dt2.Rows(i)("dfno") Then Exit Sub

        '        dr = dt2.NewRow

        '        For j = 0 To dt2.Columns.Count - 1
        '            dr("job_line_id") = dt1.Rows(i)("job_line_id")
        '            dr("suppcd") = dt1.Rows(i)("suppcd")
        '            dr("source_refno") = dt1.Rows(i)("source_refno")
        '            dr("dfno") = dt1.Rows(i)("dfno")
        '            dr("design_no") = dt1.Rows(i)("design_no")
        '            dr("gwth") = dt1.Rows(i)("gwth")
        '            'dr("fwth") = dt1.Rows(i)("fwth")
        '            dr("col") = dt1.Rows(i)("col")
        '            'dr("gr") = dt1.Rows(i)("gr")
        '            'dr("custcolor") = dt1.Rows(i)("custcolor")
        '            'dr("roll_no_d") = dt1.Rows(i)("roll_no_d")
        '            dr("roll_no_o") = dt1.Rows(i)("roll_no_o")
        '            dr("sonoid") = dt1.Rows(i)("sonoid")
        '            dr("kg") = dt1.Rows(i)("kg")
        '            dr("mts") = dt1.Rows(i)("mts")
        '            dr("yds") = dt1.Rows(i)("yds")
        '            dr("lot") = dt1.Rows(i)("lot")
        '            'dr("rem_qc") = dt1.Rows(i)("rem_qc") source_refno
        '            dr("roll_no_f") = dt1.Rows(i)("roll_no_f")
        '            dr("mcno") = dt1.Rows(i)("mcno")
        '            dr("kono") = dt1.Rows(i)("kono")
        '            dr("grade") = dt1.Rows(i)("grade")
        '            dr("ProdFinishDate") = dt1.Rows(i)("ProdFinishDate")
        '            dr("ProdFinishTime") = dt1.Rows(i)("ProdFinishTime")
        '            dr("purno") = dt1.Rows(i)("purno")
        '            dr("mtl_warehouse_id") = dt1.Rows(i)("mtl_warehouse_id")
        '            dr("mtl_subinventory_id") = dt1.Rows(i)("mtl_subinventory_id")
        '            dr("mtl_locations_id") = dt1.Rows(i)("mtl_locations_id")
        '        Next
        '        dt2.Rows.Add(dr)

        '    Next

        'End If



    End Sub


    Private Sub frmStockGINPurchase_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        Me.WindowState = FormWindowState.Maximized

        Call InitControl()
    End Sub
    Private Sub InitControl()
        txtGinno.Text = ""
        dtpGINDate.Value = Today
        txtPONo.Text = ""
        txtSuppInvNo.Text = ""
        txtSuppLot.Text = ""
        txtSuppRefNo.Text = ""
        Call GenCombo()
        '   Call BindGrid(grdData, (New classStockG).GetGINPOmanual("", clsUser.UserID))

        grdPO.AutoGenerateColumns = False
        grdPO.DataSource = (New GetDataYarn).getJob("")

        ErrorProvider1.Clear()
        txtPONo.Enabled = True

        dtData = oStockG.GetGINPOmanual("", clsUser.UserID)
        grdData.AutoGenerateColumns = False
        grdData.DataSource = dtData

        Call SumGrid()

        txtPONo.Select()

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

        cboMtlWarehouse.DataSource = (New classMaster).Combomtlwarehouse(clsUser.UserID)
        cboMtlWarehouse.DisplayMember = "warehouse_code"
        cboMtlWarehouse.ValueMember = "mtl_warehouse_id"
        cboMtlWarehouse.SelectedIndex = -1

        cboMtlSubinventory.DataSource = Nothing
        cboMtlSubinventory.SelectedIndex = -1
        cboMtlLocation.DataSource = Nothing
        cboMtlLocation.SelectedIndex = -1

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
        mtl_subinventory_id.DataSource = objdb.ComboMtlsubinventory(Int64mtl_warehouse_id)
        mtl_subinventory_id.DisplayMember = "subinventory_name"
        mtl_subinventory_id.ValueMember = "mtl_subinventory_id"
        'Setdefaultsubinventory(0)
    End Sub

    Private Sub GetCombomtl_locationInGrid(ByVal Int64mtl_warehouse_id As Int64, ByVal Int64mtl_subinventory_id As Int64)
        Dim objdb As New classMaster
        mtl_locations_id.DataSource = objdb.Combomtllocations(strUSerID:=clsUser.UserID _
                             , INt64mtl_warehouse_id:=Int64mtl_warehouse_id _
                             , Int64mtl_subinventory_id:=Int64mtl_subinventory_id)
        mtl_locations_id.DisplayMember = "location_name"
        mtl_locations_id.ValueMember = "mtl_locations_id"
    End Sub

    Private Sub Setdefaultsubinventory(ByVal dt As DataTable)
        Dim expression As String
        expression = "subinventory_code like '%GREIGE%'"
        Dim foundRows() As DataRow
        foundRows = dt.Select(expression)
        If foundRows.Length > 0 Then cboMtlSubinventory.SelectedValue = foundRows(0)("mtl_subinventory_id")
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

        If foundRows.Length > 0 Then cboMtlLocation.SelectedValue = foundRows(0)(0)

    End Sub

    Private Sub BindGrid(ByRef grd As DataGridView, ByVal dt As DataTable)
        grdData.AutoGenerateColumns = False
        grdData.DataSource = dt
    End Sub
    Private Sub btncopy_Click(sender As System.Object, e As System.EventArgs)
        Call GetcopyRollNo()
    End Sub
    Private Function GetcopyRollNo() As Boolean
        Dim clsconfig As New clsConfig
        Dim dtc As DataTable = grdData.DataSource
        Dim newrow As DataRow
        If grdData.Rows.Count > 0 Then

            newrow = dtc.NewRow

            newrow.Item("id_jobdet") = grdData.CurrentRow.Cells("colIDJobDet").Value
            newrow.Item("job_line_id") = grdData.CurrentRow.Cells("job_line_id").Value
            newrow.Item("suppcd") = grdData.CurrentRow.Cells("suppcd").Value
            newrow.Item("source_refno") = grdData.CurrentRow.Cells("source_refno").Value
            newrow.Item("design_no") = grdData.CurrentRow.Cells("design_no").Value
            newrow.Item("ydkg") = grdData.CurrentRow.Cells("colydkg").Value
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
        If oConfig.IsNull(cboGINNo.SelectedItem, "").ToString.Length = 0 Then
            'Call GetcomboSubInventoryinGrid(Int64mtl_warehouse_id:=0)
            'Call GetCombomtl_locationInGrid(Int64mtl_warehouse_id:=0, Int64mtl_subinventory_id:=0)
            Call GetGINPOmanual(oConfig.IsNull(cboGINNo.ComboBox.SelectedValue, ""))
        End If
    End Sub

    Function GetGINPOmanual(ByRef strGINNO As String) As Boolean

        dtData = oStockG.GetGINPOmanual(strGINNO, clsUser.UserID)

        grdData.AutoGenerateColumns = False
        grdData.DataSource = dtData

        Call SumGrid()

        If dtData.Rows.Count > 0 Then
            'Dev By Neung 26/03/2015
            Call BindGINPOManualText()
            Return True
        End If
        Return False
    End Function

    Private Sub BindGINPOManualText()
        Dim config As New clsConfig
        Dim i As Integer = 0
        Dim j As Integer = 0

        ' grdData.AutoGenerateColumns = False
        '  grdData.DataSource = Me.dtData


        txtGinno.Text = dtData.Rows(0)("tran_no").ToString.Trim
        dtpGINDate.Value = CDate(dtData.Rows(0)("tran_dt").ToString)

        txtPONo.Text = dtData.Rows(0)("purno").ToString.Trim()
        txtPONo.Enabled = False
        Call LoadDataJOB(txtPONo.Text.Trim)
        cboSupplier.SelectedValue = dtData.Rows(0)("suppcd").ToString.Trim()
        txtSuppInvNo.Text = (New clsConfig).IsNull(dtData.Rows(0)("sinvno"), "").ToString.Trim()

        If (New clsConfig).IsNull(dtData.Rows(0)("sinvdt"), CDate("01/01/1900")) = CDate("01/01/1900") Then
            dtpsinvdt.Value = CDate("01/01/1900")
            dtpsinvdt.Checked = False
        Else
            dtpsinvdt.Value = dtData.Rows(0)("sinvdt")
            dtpsinvdt.Checked = True
        End If


        txtSuppLot.Text = dtData.Rows(0)("lotno_sup").ToString.Trim
        txtSuppRefNo.Text = dtData.Rows(0)("srefno").ToString.Trim

        If Not dtData Is Nothing Then
            If dtData.Rows.Count > 0 Then
                cboMtlWarehouse.SelectedValue = oConfig.IsNull(dtData.Rows(0)("mtl_warehouse_id"), Nothing)
                Call setComboSubInventory(pMtlWarehouseId:=oConfig.IsNull(dtData.Rows(0)("mtl_warehouse_id"), Nothing))
                cboMtlSubinventory.SelectedValue = oConfig.IsNull(dtData.Rows(0)("mtl_subinventory_id"), Nothing)
                Call setComboLocation(pMtlWarehouseId:=dtData.Rows(0)("mtl_warehouse_id"), pMtlSubinventoryId:=oConfig.IsNull(dtData.Rows(0)("mtl_subinventory_id"), Nothing))
                cboMtlLocation.SelectedValue = oConfig.IsNull(dtData.Rows(0)("mtl_locations_id"), Nothing)
            End If
        End If

    End Sub

    Private Sub GetComboNewSubInventory(Optional ByVal Int64mtl_warehouse_id As Nullable(Of Int64) = Nothing)
        Dim objdb As New classMaster

        cboMtlSubinventory.DataSource = objdb.ComboMtlsubinventory(Int64mtl_warehouse_id)
        cboMtlSubinventory.DisplayMember = "subinventory_code"
        cboMtlSubinventory.ValueMember = "mtl_subinventory_id"
        Dim clsconfig As New clsConfig
        If clsconfig.IsNull(cboMtlSubinventory.SelectedValue, 0) = 0 Then Setdefaultsubinventory(cboMtlSubinventory.DataSource)

    End Sub

    Private Sub setComboLocation(Optional ByVal pMtlWarehouseId As Nullable(Of Int64) = Nothing, Optional ByVal pMtlSubinventoryId As Nullable(Of Int64) = Nothing)
        Dim objdb As New classMaster
        cboMtlLocation.DataSource = objdb.Combomtllocations(strUSerID:=clsUser.UserID, INt64mtl_warehouse_id:=pMtlWarehouseId, Int64mtl_subinventory_id:=pMtlSubinventoryId)
        cboMtlLocation.DisplayMember = "location_name"
        cboMtlLocation.ValueMember = "mtl_locations_id"
    End Sub

    Private Sub btnNew_Click(sender As System.Object, e As System.EventArgs) Handles btnNew.Click
        Call InitControl()
    End Sub

    Private Sub btnSave_Click(sender As System.Object, e As System.EventArgs) Handles btnSave.Click
        Call SaveData()
    End Sub
    Private Sub SaveData()

        grdData.EndEdit(DataGridViewDataErrorContexts.Commit) 'Fix Bug User

        blnCancel = False
        'Sitthana 20220624 Changed Windows.Forms.DialogResult To DialogResult
        Dim result As DialogResult ' Windows.Forms.DialogResult
        result = MessageBox.Show("Would you like to save ?", "System Message", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button3)
        If result = DialogResult.Cancel Then blnCancel = True
        If result <> DialogResult.Yes Then Exit Sub

        If Not CheckData() Then Exit Sub

        Call SaveGINPOManual()

    End Sub

    Private Function CheckData() As Boolean
        If oConfig.IsNull(cboMtlWarehouse.SelectedValue, 0) = 0 Then
            MessageBox.Show("คุณยังไม่ไดเลือก WareHouse")
            ErrorProvider1.SetError(cboMtlWarehouse, "คุณยังไม่ไดเลือก WareHouse")
            CheckData = False
            Exit Function
        End If

        If Val(cboMtlSubinventory.SelectedValue) = 0 Then
            MessageBox.Show("คุณยังไม่ได้เลือก Subinventory")
            ErrorProvider1.SetError(cboMtlSubinventory, "คุณยังไม่ได้เลือก Subinventory")
            CheckData = False
            Exit Function
        End If

        If oConfig.IsNull(cboMtlLocation.SelectedValue, 0) = 0 Then
            MessageBox.Show("คุณยังไม่ไดเลือก Location")
            ErrorProvider1.SetError(cboMtlLocation, "คุณยังไม่ได้เลือก Locations")
            CheckData = False
            Exit Function
        End If

        For Each row As DataGridViewRow In grdData.Rows
            If Not (txtPONo.Text.Trim = ("FREE SAMPLE") Or txtPONo.Text.Trim = ("FREE OF CHARGE")) Then
                If (New clsConfig).IsNull(row.Cells("colIDJobDet").Value, 0) = 0 Then
                    MessageBox.Show("Please check ID Job Detail in Box Before Saving should be not zero", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    ErrorProvider1.SetError(grdData, "Please check ID Job Detail in Box Before Saving should be not zero")
                    CheckData = False
                    Exit Function
                End If
            End If
        Next

        CheckData = True
    End Function

    Private Function SaveGINPOManual(Optional ByVal strGINNO As String = "") As Boolean

        Dim config As New clsConfig
        config.ChangeCulture()
        Dim objDB As New classStockG
        Dim Greige_Header As New classStockG.Greige_Header
        Dim msgerr As String = ""
        Dim Tran_no As String = strGINNO


        Greige_Header.h01_suppcd = cboSupplier.SelectedValue

        Greige_Header.h02_source = ""
        Greige_Header.h03_source_refno = ""
        Greige_Header.h04_tran_no = txtGinno.Text
        Greige_Header.h05_tran_dt = dtpGINDate.Value
        Greige_Header.h71_purno = txtPONo.Text.Trim
        Greige_Header.h25_loc = "NEW"
        Greige_Header.h70_tran_type = "PURCHASE"
        Greige_Header.h83_mtl_warehouse_id = oConfig.IsNull(cboMtlWarehouse.SelectedValue, Nothing)
        Greige_Header.h86_mtl_subinventory_id = oConfig.IsNull(cboMtlSubinventory.SelectedValue, Nothing)
        Greige_Header.h84_mtl_locations_id = oConfig.IsNull(cboMtlLocation.SelectedValue, Nothing)
        Greige_Header.h25_loc = cboMtlLocation.Text

        Dim dtc As DataTable = grdData.DataSource

        For i = 0 To dtc.Rows.Count - 1
            If dtc.Rows(i).RowState <> DataRowState.Deleted Then
                dtc.Rows(i)("suppcd") = cboSupplier.SelectedValue
                dtc.Rows(i)("sinvno") = txtSuppInvNo.Text.Trim
                dtc.Rows(i)("sinvdt") = IIf(dtpsinvdt.Checked, dtpsinvdt.Value, DBNull.Value)
                dtc.Rows(i)("lotno_sup") = txtSuppLot.Text.Trim
                dtc.Rows(i)("srefno") = txtSuppRefNo.Text.Trim
                dtc.Rows(i)("purno") = txtPONo.Text.Trim
                dtc.Rows(i)("mtl_warehouse_id") = oConfig.IsNull(cboMtlWarehouse.SelectedValue, Nothing)
                dtc.Rows(i)("mtl_subinventory_id") = oConfig.IsNull(cboMtlSubinventory.SelectedValue, Nothing)
                dtc.Rows(i)("mtl_locations_id") = oConfig.IsNull(cboMtlLocation.SelectedValue, Nothing)
                dtc.Rows(i)("loc") = cboMtlLocation.Text
            End If
        Next

        For Each dr As DataRow In dtc.Rows
            If dr.RowState = DataRowState.Unchanged Then
                dr.SetModified()
            End If
        Next


        Dim dv_dtc_add As New DataView(dtc, "", "", DataViewRowState.Added)
        Dim dv_dtc_upd As New DataView(dtc, "", "", DataViewRowState.ModifiedCurrent)
        Dim dv_dtc_del As New DataView(dtc, "", "", DataViewRowState.Deleted)

        If objDB.GINPOsave(Greige_Header, msgerr, dtc, dv_dtc_add, dv_dtc_upd, dv_dtc_del, clsUser.UserID, Tran_no) Then
            strGINNO = Tran_no
            txtGinno.Text = strGINNO.Trim
            MessageBox.Show("Save is Complete! : บันทึกสำเร็จ! ", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
            ' SaveGINPOManual = True
            Call GenCbo()
            Call GetcomboSubInventoryinGrid(Int64mtl_warehouse_id:=0)
            Call GetCombomtl_locationInGrid(Int64mtl_warehouse_id:=0, Int64mtl_subinventory_id:=0)
            Call GetGINPOmanual(oConfig.IsNull(txtGinno.Text.Trim, ""))
            SaveGINPOManual = True
        Else
            MessageBox.Show(msgerr, "System Message", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
            SaveGINPOManual = False
        End If

    End Function

    Private Sub btnPrint_Click(sender As System.Object, e As System.EventArgs)
        'print
        Dim clsconn As New ClassConnection

        If txtGinno.Text = "" Then Exit Sub
        Const rptFileName = "rptGIN.rpt"
        If clsUser.ReportPath = "" Then clsUser.ReportPath = clsUser.ReportPath
        If Not oConfig.CheckReport(clsUser.ReportPath, rptFileName) Then Exit Sub
        Dim frm As New frmReport
        Dim rpt As New CrystalDecisions.CrystalReports.Engine.ReportDocument
        Me.Cursor = Cursors.WaitCursor

        rpt.Load(clsUser.ReportPath & rptFileName)
        rpt.DataSourceConnections.Item(0).SetConnection(clsconn.servername, clsconn.database, False)
        rpt.DataSourceConnections.Item(0).SetLogon(clsconn.Userid, clsconn.Password)

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
        'Sitthana 20220624 Changed Windows.Forms.DialogResult To DialogResult
        Dim result As DialogResult ' Windows.Forms.DialogResult
        result = MessageBox.Show("Would you like to cancel document no. " & txtGinno.Text & " ?", "System Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button3)
        If result <> DialogResult.Yes Then Exit Sub

        If Not CheckDataCancel() Then Exit Sub

        Dim message As String = ""

        If (New classStock).CancelGIN(strGINNo:=txtGinno.Text, Dtptran_dt:=dtpGINDate.Value, strEmpCode:=clsUser.UserID, Strmessage:=message) Then
            MessageBox.Show("cancel is completed", "System Message!", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Call btnNew_Click(sender, e)
        Else
            MessageBox.Show(message, "System Message!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
        'Call Canceldata()
    End Sub

    Private Function CheckDataCancel() As Boolean
        If txtGinno.Text.Trim.Length = 0 Then
            MessageBox.Show("คุณยังไม่ได้เลือก D IN No.", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return False
            Exit Function
        End If

        Return True
    End Function

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
        'Sitthana 20220624 Changed Windows.Forms.DialogResult To DialogResult
        Dim result As DialogResult ' Windows.Forms.DialogResult
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
        If e.KeyCode = Keys.Enter Then
            If Not CheckDataJob() Then Exit Sub
            Call LoadDataJOB(txtPONo.Text.Trim)
        End If

    End Sub
    Private Function CheckDataJob() As Boolean



        Return True
    End Function
    Private Sub LoadDataJOB(ByVal jobno As String)
        Dim dt As DataTable
        Dim clsyarn As New GetDataYarn
        If txtPONo.Text = ("FREE SAMPLE") Or txtPONo.Text = ("FREE OF CHARGE") Then
            dt = clsyarn.getJobFree(jobno)
        Else
            dt = clsyarn.getJob(jobno)
        End If

        If dt.Rows.Count > 0 Then
            grdPO.AutoGenerateColumns = False
            grdPO.DataSource = dt
            jobID = oConfig.IsNull(dt.Rows(0).Item("id_jobdet"), 0)
            cboSupplier.SelectedValue = dt.Rows(0).Item("suppcd")
            txtPONo.Enabled = False
        End If

    End Sub
    Private Sub txtPONo_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtPONo.TextChanged

    End Sub

    Private Sub grdData_CellBeginEdit(sender As Object, e As System.Windows.Forms.DataGridViewCellCancelEventArgs) Handles grdData.CellBeginEdit
        Dim objdb As New classMaster
        Dim dgvccSubInven As New DataGridViewComboBoxCell
        Dim dtSubInven As New DataTable
        If grdData.Columns(e.ColumnIndex).Name = "mtl_subinventory_id" Then
            If Not IsDBNull(grdData.Rows(e.RowIndex).Cells("mtl_warehouse_id").Value) Then
                dtSubInven = objdb.ComboMtlsubinventory(grdData.Rows(e.RowIndex).Cells("mtl_warehouse_id").Value)
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
        If grdData.Columns(e.ColumnIndex).Name = "kg" Or
         grdData.Columns(e.ColumnIndex).Name = "yds" Or
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

        Call SumGrid()

        If grdData.Columns(e.ColumnIndex).Name = "grade_bdt" Or
         grdData.Columns(e.ColumnIndex).Name = "grade_adt" Then
            grdData.Rows(e.RowIndex).Cells("grade").Value = grdData.Rows(e.RowIndex).Cells("grade_bdt").Value.ToString.ToUpper.Trim + grdData.Rows(e.RowIndex).Cells("grade_adt").Value.ToString.ToUpper.Trim
        End If
        'Auto
        Dim objdb As New classMaster
        Dim dgvccSubInven As New DataGridViewComboBoxCell
        Dim dtSubInven As New DataTable
        If grdData.Columns(e.ColumnIndex).Name = "preseted" Then
            If Not IsDBNull(grdData.Rows(e.RowIndex).Cells("mtl_warehouse_id").Value) Then
                dtSubInven = objdb.ComboMtlsubinventory(grdData.Rows(e.RowIndex).Cells("mtl_warehouse_id").Value)
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
                dtSubInven = objdb.ComboMtlsubinventory(grdData.Rows(e.RowIndex).Cells("mtl_warehouse_id").Value)
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

    Private Sub SumGrid()
        Dim dt As DataTable = grdData.DataSource
        If dt Is Nothing Then
            txtTotalKg.Text = ""
            txtTotalMts.Text = ""
            txtTotalYds.Text = ""
            Exit Sub
        End If
        Dim totalKg As Decimal = 0
        Dim totalMts As Decimal = 0
        Dim totalYds As Decimal = 0
        For Each dr As DataRow In dt.Rows
            If dr.RowState <> DataRowState.Deleted Then
                totalKg += (New clsConfig).IsNull(dr("kg"), 0D)
                totalMts += (New clsConfig).IsNull(dr("mts"), 0D)
                totalYds += (New clsConfig).IsNull(dr("yds"), 0D)
            End If
        Next
        txtTotalKg.Text = FormatNumber(totalKg, 2, TriState.False, TriState.False, TriState.False)
        txtTotalMts.Text = FormatNumber(totalMts, 2, TriState.False, TriState.False, TriState.False)
        txtTotalYds.Text = FormatNumber(totalYds, 2, TriState.False, TriState.False, TriState.False)
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

        Call SumGrid()

    End Function

    Private Sub ToolStrip1_ItemClicked(sender As System.Object, e As System.Windows.Forms.ToolStripItemClickedEventArgs) Handles ToolStrip1.ItemClicked

    End Sub

    Private Sub cbomtl_warehouse_DropDownClosed(sender As Object, e As System.EventArgs) Handles cboMtlWarehouse.DropDownClosed
        Call GetComboNewSubInventory(Int64mtl_warehouse_id:=(New clsConfig).IsNull(cboMtlWarehouse.SelectedValue, Nothing))
        Call setComboLocation(pMtlWarehouseId:=(New clsConfig).IsNull(cboMtlWarehouse.SelectedValue, Nothing),
                              pMtlSubinventoryId:=(New clsConfig).IsNull(cboMtlSubinventory.SelectedValue, Nothing))
    End Sub

    Private Sub cbomtl_subinventory_DropDownClosed(sender As Object, e As System.EventArgs) Handles cboMtlSubinventory.DropDownClosed
        Call setComboLocation(pMtlWarehouseId:=(New clsConfig).IsNull(cboMtlWarehouse.SelectedValue, Nothing),
                              pMtlSubinventoryId:=(New clsConfig).IsNull(cboMtlSubinventory.SelectedValue, Nothing))
    End Sub

    Private Sub cbomtl_warehouse_Enter(sender As Object, e As EventArgs) Handles cboMtlWarehouse.Enter

    End Sub

    Private Sub cbomtl_warehouse_HandleCreated(sender As Object, e As EventArgs) Handles cboMtlWarehouse.HandleCreated

    End Sub
    Private Sub setComboSubInventory(ByVal pMtlWarehouseId As Nullable(Of Int64))
        Dim objdb As New classMaster

        cboMtlSubinventory.DataSource = objdb.ComboMtlsubinventory(oConfig.IsNull(cboMtlWarehouse.SelectedValue, Nothing))
        cboMtlSubinventory.DisplayMember = "subinventory_code"
        cboMtlSubinventory.ValueMember = "mtl_subinventory_id"

    End Sub

    Private Sub cbomtl_warehouse_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cboMtlWarehouse.SelectedIndexChanged
        Call setComboSubInventory(oConfig.IsNull(cboMtlWarehouse.SelectedValue, Nothing))
        Call setComboLocation(pMtlWarehouseId:=oConfig.IsNull(cboMtlWarehouse.SelectedValue, Nothing), pMtlSubinventoryId:=oConfig.IsNull(cboMtlSubinventory.SelectedValue, Nothing))
    End Sub

    Private Sub BtnCopyRoll_Click(sender As Object, e As EventArgs) Handles BtnCopyRoll.Click
        Call GetcopyRollNo()
    End Sub

    Private Sub BtnPrintBarcode_Click(sender As Object, e As EventArgs) Handles BtnPrintBarcode.Click
        Dim clsconn As New ClassConnection
        Dim clsConfig As New clsConfig
        Dim rptFileName = "rptGreigeBarcode.rpt"
        If clsUser.ReportPath = "" Then clsUser.ReportPath = clsUser.ReportPath
        'clsUser.ReportPath = "C:\Users\DELL\Desktop\GemmaKnits\"
        If Not clsConfig.CheckReport(clsUser.ReportPath, rptFileName) Then Exit Sub
        Dim frm As New frmReport
        Dim rpt As New CrystalDecisions.CrystalReports.Engine.ReportDocument
        Dim stype As String = ""
        Dim ord As String = ""
        Me.Cursor = Cursors.WaitCursor

        rpt.Load(clsUser.ReportPath & rptFileName)
        rpt.DataSourceConnections.Item(0).SetConnection(clsconn.servername, clsconn.database, False)
        rpt.DataSourceConnections.Item(0).SetLogon(clsconn.Userid, clsconn.Password)
        rpt.VerifyDatabase()
        rpt.SetParameterValue("@roll_no", txtGinno.Text)
        rpt.SetParameterValue("@loc", "")
        rpt.SetParameterValue("@logempcd", UserInfo.UserID)

        'rpt.PrintOptions.PaperSize = CrystalDecisions.Shared.PaperSize.PaperLetter
        'rpt.PrintOptions.PaperOrientation = CrystalDecisions.Shared.PaperOrientation.Portrait
        'rpt.PrintOptions.PaperSource = CrystalDecisions.Shared.PaperSource.Auto

        frm.Title = "Greige Barcode"
        frm.CRViewer.ReportSource = rpt
        frm.MdiParent = Me.ParentForm
        frm.Show()
        Me.Cursor = Cursors.Default
    End Sub
    Private Sub tsbGInDocument_Click(sender As Object, e As EventArgs) Handles tsbGInDocument.Click
        'print
        If txtGinno.Text = "" Then Exit Sub
        Const rptFileName = "rptGIN.rpt"
        If clsUser.ReportPath = "" Then clsUser.ReportPath = clsUser.ReportPath
        If Not oConfig.CheckReport(clsUser.ReportPath, rptFileName) Then Exit Sub
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

    Private Sub tsbGInTag_Click(sender As Object, e As EventArgs) Handles tsbGInTag.Click
        Dim clsConfig As New clsConfig
        Dim rptFileName As String = "rptGreigeBarcode.rpt"
        Dim objdb As New classStockGIN_KOManual
        'Dim dt As DataTable = objdb.Validate_RollNo_WareHouse(StrRollno:=txtGINNo.Text.Trim, StrEmpcd:=clsUser.UserID)

        'If dt.Rows.Count > 0 Then
        '    If dt.Rows(0)("mtl_warehouse_id").ToString.Trim = "7" Then
        '        rptFileName = "rptGreigeBarcodeEschler.rpt"
        '    Else
        '        rptFileName = "rptGreigeBarcode.rpt"
        '    End If

        'End If

        If clsUser.ReportPath = "" Then clsUser.ReportPath = clsUser.ReportPath
        'clsUser.ReportPath = "C:\Users\DELL\Desktop\GemmaKnits\"
        If Not clsConfig.CheckReport(clsUser.ReportPath, rptFileName) Then Exit Sub
        Dim frm As New frmReport
        Dim rpt As New CrystalDecisions.CrystalReports.Engine.ReportDocument
        Dim stype As String = ""
        Dim ord As String = ""
        Me.Cursor = Cursors.WaitCursor

        rpt.Load(clsUser.ReportPath & rptFileName)
        rpt.DataSourceConnections.Item(0).SetConnection(clsConn.servername, clsConn.database, False)
        rpt.DataSourceConnections.Item(0).SetLogon(clsConn.Userid, clsConn.Password)
        rpt.VerifyDatabase()
        rpt.SetParameterValue("@roll_no", txtGinno.Text)
        rpt.SetParameterValue("@loc", "")
        rpt.SetParameterValue("@logempcd", UserInfo.UserID)

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