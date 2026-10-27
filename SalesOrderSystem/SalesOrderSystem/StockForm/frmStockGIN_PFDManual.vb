Public Class frmStockGIN_PFDManual
    Dim clsConfig As New clsConfig
    Dim clsConn As New classConnection
    Dim clsUser As New classUserInfo
    Dim blnLocked As Boolean = False
    Dim blnCancel As Boolean = False

    Public Property UserInfo() As classUserInfo
        Get
            UserInfo = clsUser
        End Get
        Set(ByVal NewValue As classUserInfo)
            clsUser = NewValue
        End Set
    End Property

    Private Sub InitControl()
        Call GenCboGINPFDNo()
        Call GenCombo()

        txtGINNo.Text = ""
        dtpGINDATE.Value = Today

        txtDFNo.Text = ""
        'txtLot.Text = ""
        'txtsource_refno.Text = ""
        'txtRemark.Text = ""
        Call BindGrid(grdData, (New classStockG).GetGINPFDmanual("", clsUser.UserID))

        txtDFNo.Focus()
        'Call BindGrid(grdData, (New classStockG).get("", clsUser.UserID))
    End Sub

    Private Sub GenCombo()

        cbomtl_warehouse.DataSource = (New classMaster).Combomtlwarehouse(clsUser.UserID)
        cbomtl_warehouse.DisplayMember = "warehouse_code"
        cbomtl_warehouse.ValueMember = "mtl_warehouse_id"
        cbomtl_warehouse.SelectedIndex = -1

        cbomtl_subinventory.DataSource = Nothing
        cbomtl_subinventory.SelectedIndex = -1

        cbomtl_location.DataSource = Nothing
        cbomtl_location.SelectedIndex = -1

        Dim objdb As New classMaster
        cboDyedHouse.DataSource = (New classMaster).GetSupplier
        cboDyedHouse.DisplayMember = "name"
        cboDyedHouse.ValueMember = "suppcd"

        'Call GetComboWarehouseinGrid()
        '' Call GetcomboSubInventoryinGrid(Int64mtl_warehouse_id:=0)
        'Call GetCombomtl_locationInGrid(Int64mtl_warehouse_id:=0, Int64mtl_subinventory_id:=0)


    End Sub

    Private Sub BindGrid(ByRef grd As DataGridView, ByVal dt As DataTable)
        grd.AutoGenerateColumns = False
        grd.DataSource = dt
    End Sub
    Private Sub frmStockGIN_PFDManual_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized

        Call btnNew_Click(sender, e)
    End Sub
    Private Sub GenCboGINPFDNo()
        'Dim objDB As New classStockD
        Dim objDB As New classStockG
        cboGINPFDNo.ComboBox.DataSource = objDB.GetCBOGINPFDmanualNo()
        cboGINPFDNo.ComboBox.DisplayMember = "tran_no"
        cboGINPFDNo.ComboBox.ValueMember = "tran_no"

    End Sub
    Private Sub btnSearchColNo_Click(sender As System.Object, e As System.EventArgs)
        Dim frm As New frmSearchPO
        frm.ShowDialog(Me)



    End Sub

    Private Sub txtDFNo_TextChanged(sender As System.Object, e As System.EventArgs)

    End Sub

    Private Sub btnNew_Click(sender As System.Object, e As System.EventArgs) Handles btnNew.Click
        Call InitControl()
    End Sub

    Private Sub btnSearchDFNo_Click(sender As System.Object, e As System.EventArgs) Handles btnSearchDFNo.Click
        Dim frm As New frmSearchDFOrderPreset
        frm.ShowDialog(Me)
        txtDFNo.Text = (frm.pDFNo)
        Me.Cursor = Cursors.WaitCursor
        If Not blnCancel Then GetDForder(txtDFNo.Text)
        Me.Cursor = Cursors.Default
        frm.Dispose()
    End Sub
    Private Function GetDForder(ByVal strDfNo As String) As Boolean
        Dim dbStockD As New classStockG

        Dim dt As DataTable = dbStockD.GetDForder_Items(strDfNo, clsUser.UserID)
        If dt.Rows.Count > 0 Then
            Call BinddataTextDF(dt)
            Call BindDataGridDF(dt)

            Return True
        End If
        Return False
    End Function
    Private Sub BinddataTextDF(ByVal dt As DataTable)

        'txtDFNo.Text = dt.Rows(0)("dfno")
        'txtLotNo.Text = dt.Rows(0)("lot").ToString.Trim

        'cboDyedHouse.SelectedValue = dt.Rows(0)("dhcod").ToString
        'txtBillNo.Text = dt.Rows(0)("dono")
        'txtRemark.Text = dt.Rows(0)("rem_qc")
        txtGINNo.Text = dt.Rows(0)("tran_no").ToString.Trim
        dtpGINDATE.Value = CDate(dt.Rows(0)("tran_dt").ToString)
        txtDFNo.Text = dt.Rows(0)("dfno").ToString.Trim()

        cboDyedHouse.SelectedValue = dt.Rows(0)("dhcod").ToString
        txtLotNo.Text = dt.Rows(0)("lot").ToString
        txtBillNo.Text = dt.Rows(0)("source_refno").ToString
        cboGINPFDNo.Text = dt.Rows(0)("tran_no").ToString.Trim

        cbomtl_warehouse.SelectedValue = clsConfig.IsNull(dt.Rows(0)("mtl_warehouse_id"), Nothing)
        Call GetComboNewSubInventory(Int64mtl_warehouse_id:=(New clsConfig).IsNull(cbomtl_warehouse.SelectedValue, Nothing))
        cbomtl_subinventory.SelectedValue = clsConfig.IsNull(dt.Rows(0)("mtl_subinventory_id"), DBNull.Value)
        Call GetComboNewLocation(Int64mtl_warehouse_id:=(New clsConfig).IsNull(cbomtl_warehouse.SelectedValue, Nothing),
                                Int64mtl_subinventory_id:=(New clsConfig).IsNull(cbomtl_subinventory.SelectedValue, Nothing),
                                Int64mtl_locations_id:=(New clsConfig).IsNull(cbomtl_location.SelectedValue, Nothing))
        cbomtl_location.SelectedValue = clsConfig.IsNull(dt.Rows(0)("mtl_locations_id"), DBNull.Value)
    End Sub

    Private Sub GetComboNewWarehouse()
        Dim objdb As New classMaster

        cbomtl_warehouse.DataSource = objdb.Combomtlwarehouse(clsUser.UserID)
        cbomtl_warehouse.DisplayMember = "warehouse_code"
        cbomtl_warehouse.ValueMember = "mtl_warehouse_id"
        cbomtl_warehouse.SelectedIndex = -1
        'cbomtl_warehouse.SelectedValue = objdb.GetdefaultWarehouse(clsUser.UserID)

    End Sub

    Private Sub GetComboNewSubInventory(Optional ByVal Int64mtl_warehouse_id As Nullable(Of Int64) = Nothing)
        Dim objdb As New classMaster

        cbomtl_subinventory.DataSource = objdb.ComboMtlsubinventory(Int64mtl_warehouse_id)
        cbomtl_subinventory.DisplayMember = "subinventory_code"
        cbomtl_subinventory.ValueMember = "mtl_subinventory_id"

        'Setdefaultsubinventory(dt:=cbomtl_subinventory.DataSource)

    End Sub

    Private Sub GetComboLocation(Optional ByVal Int64mtl_warehouse_id As Nullable(Of Int64) = Nothing,
                                 Optional ByVal Int64mtl_subinventory_id As Nullable(Of Int64) = Nothing,
                                 Optional ByVal Int64mtl_locations_id As Nullable(Of Int64) = Nothing)
        Dim objdb As New classMaster
        cbomtl_location.DataSource = objdb.Combomtllocations(strUSerID:=clsUser.UserID, INt64mtl_warehouse_id:=Int64mtl_warehouse_id, Int64mtl_subinventory_id:=Int64mtl_subinventory_id)
        cbomtl_location.DisplayMember = "location_name"
        cbomtl_location.ValueMember = "mtl_locations_id"


    End Sub
    Private Sub GetComboNewLocation(ByVal Int64mtl_warehouse_id As Int64, ByVal Int64mtl_subinventory_id As Int64, ByVal Int64mtl_locations_id As Int64)
        Dim objdb As New classMaster
        cbomtl_location.DataSource = objdb.Combomtllocations(strUSerID:=clsUser.UserID,
                                         INt64mtl_warehouse_id:=Int64mtl_warehouse_id,
                                         Int64mtl_subinventory_id:=Int64mtl_subinventory_id)

        cbomtl_location.DisplayMember = "location_name"
        cbomtl_location.ValueMember = "mtl_locations_id"
        'cbomtl_Location.SelectedIndex = -1

    End Sub

    Private Sub Setdefaultsubinventory(ByVal dt As DataTable)

        Dim expression As String
        expression = "subinventory_code like '%PFD%'"
        Dim foundRows() As DataRow
        foundRows = dt.Select(expression)

        cbomtl_subinventory.SelectedValue = foundRows(0)(0)


    End Sub

    Private Sub SetDefaultLocation(ByVal dt As DataTable)
        Dim expression As String
        expression = "location_name like '%N/A%'"
        Dim foundRows() As DataRow
        foundRows = dt.Select(expression)

        cbomtl_location.SelectedValue = foundRows(0)(0)

    End Sub
    Private Sub BindDataGridDF(ByVal dt As DataTable)
        Dim config As New clsConfig
        If txtDFNo.Text = "" Then Exit Sub
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

                    dr(j) = dt1.Rows(i)(j)

                    'dr("suppcd") = dt1.Rows(i)("suppcd")
                    'dr("source_refno") = dt1.Rows(i)("source_refno")
                    'dr("dfno") = dt1.Rows(i)("dfno")
                    'dr("design_no") = dt1.Rows(i)("design_no")
                    'dr("gwth") = dt1.Rows(i)("gwth")
                    ''dr("fwth") = dt1.Rows(i)("fwth")
                    'dr("col") = dt1.Rows(i)("col")
                    ''dr("gr") = dt1.Rows(i)("gr")
                    ''dr("custcolor") = dt1.Rows(i)("custcolor")
                    ''dr("roll_no_d") = dt1.Rows(i)("roll_no_d")
                    'dr("roll_no_o") = dt1.Rows(i)("roll_no_o")
                    'dr("sonoid") = dt1.Rows(i)("sonoid")
                    'dr("kg") = dt1.Rows(i)("kg")
                    'dr("mts") = dt1.Rows(i)("mts")
                    'dr("yds") = dt1.Rows(i)("yds")
                    'dr("lot") = dt1.Rows(i)("lot")
                    ''dr("rem_qc") = dt1.Rows(i)("rem_qc") source_refno
                    'dr("roll_no_f") = dt1.Rows(i)("roll_no_f")
                    'dr("mcno") = dt1.Rows(i)("mcno")
                    'dr("kono") = dt1.Rows(i)("kono")
                    'dr("grade") = dt1.Rows(i)("grade")
                    'dr("ProdFinishDate") = dt1.Rows(i)("ProdFinishDate")
                    'dr("ProdFinishTime") = dt1.Rows(i)("ProdFinishTime")
                    'dr("rem_qc") = dt1.Rows(i)("rem_qc")


                Next
                dt2.Rows.Add(dr)

            Next

        End If


        Call SumGrdData()

    End Sub

    Private Sub txtDFNo_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtDFNo.KeyPress

    End Sub


    Private Sub txtDFNo_TextChanged_1(sender As System.Object, e As System.EventArgs) Handles txtDFNo.TextChanged

    End Sub

    Private Sub cboGINPFDNo_Click(sender As System.Object, e As System.EventArgs) Handles cboGINPFDNo.Click

    End Sub

    Private Sub cboGINPFDNo_DropDownClosed(sender As Object, e As System.EventArgs) Handles cboGINPFDNo.DropDownClosed
        If clsConfig.IsNull(cboGINPFDNo.SelectedItem, "").ToString.Length = 0 Then
            Call getGINPFDManual(clsConfig.IsNull(cboGINPFDNo.ComboBox.SelectedValue, ""))
        End If
    End Sub

    Function getGINPFDManual(ByRef strGINNO As String) As Boolean
        Dim dbStockG As New classStockG
        Dim dt As DataTable = dbStockG.GetGINPFDmanual(strGINNO, clsUser.UserID)
        If dt.Rows.Count > 0 Then
            'Dev By Neung 26/03/2015
            'Call BindDataGridByGIN(dt)
            ' Call BindDataText(dt)
            Call BindGINManual(dt)
            Return True
        End If
        Return False

    End Function

    Private Sub BindGINManual(ByVal dt As DataTable)
        Dim config As New clsConfig
        Dim i As Integer = 0
        Dim j As Integer = 0

        grdData.AutoGenerateColumns = False
        grdData.DataSource = dt

        txtGINNo.Text = dt.Rows(0)("tran_no").ToString.Trim
        dtpGINDATE.Value = CDate(dt.Rows(0)("tran_dt").ToString)

        txtDFNo.Text = dt.Rows(0)("dfno").ToString.Trim()

        cboDyedHouse.SelectedValue = dt.Rows(0)("dhcod").ToString
        txtLotNo.Text = dt.Rows(0)("lot").ToString
        txtBillNo.Text = dt.Rows(0)("source_refno").ToString

        cbomtl_warehouse.SelectedValue = clsConfig.IsNull(dt.Rows(0)("mtl_warehouse_id"), Nothing)
        Call GetComboNewSubInventory(Int64mtl_warehouse_id:=(New clsConfig).IsNull(cbomtl_warehouse.SelectedValue, Nothing))
        cbomtl_subinventory.SelectedValue = clsConfig.IsNull(dt.Rows(0)("mtl_subinventory_id"), DBNull.Value)
        Call GetComboNewLocation(Int64mtl_warehouse_id:=(New clsConfig).IsNull(cbomtl_warehouse.SelectedValue, Nothing),
                                Int64mtl_subinventory_id:=(New clsConfig).IsNull(cbomtl_subinventory.SelectedValue, Nothing),
                                Int64mtl_locations_id:=(New clsConfig).IsNull(cbomtl_location.SelectedValue, Nothing))
        cbomtl_location.SelectedValue = clsConfig.IsNull(dt.Rows(0)("mtl_locations_id"), DBNull.Value)

        Call SumGrdData()
    End Sub


    Private Sub btnSave_Click(sender As System.Object, e As System.EventArgs) Handles btnSave.Click
        Me.Validate()
        If grdData.Focus Then grdData.EndEdit()

        'Sitthana 20220624 Changed Windows.Forms.DialogResult To DialogResult
        Dim result As DialogResult ' Windows.Forms.DialogResult
        result = MessageBox.Show("Would you like to save ?", "System Message", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button3)
        If result = DialogResult.Cancel Then blnCancel = True
        If result <> DialogResult.Yes Then Exit Sub

        If Not CheckData() Then Exit Sub

        Call SaveGINPFD()

        'blnCancel = False
        'Dim result As Windows.Forms.DialogResult
        'result = MessageBox.Show("Would you like to save ?", "System Message", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button3)
        'If result = Windows.Forms.DialogResult.Cancel Then blnCancel = True
        'If result <> Windows.Forms.DialogResult.Yes Then Exit Sub
        ''If MessageBox.Show("Would you like to save ?", "System Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then Call SaveData(txtDFNo.Text.Trim)
        'If SaveGINPFD() Then

        'End If
        'Call SaveData()
    End Sub

    Private Function CheckData() As Boolean

        If clsConfig.IsNull(cboDyedHouse.SelectedValue, "") = "" Then
            MessageBox.Show("คุณยังไม่ไดเลือก DyedHouse", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button3)
            ErrorProvider1.SetError(cboDyedHouse, "คุณยังไม่ไดเลือก DyedHouse")
            Return False
            Exit Function
        End If

        If clsConfig.IsNull(cbomtl_warehouse.SelectedValue, 0) = 0 Then
            MessageBox.Show("คุณยังไม่ไดเลือก WareHouse", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button3)
            ErrorProvider1.SetError(cbomtl_warehouse, "คุณยังไม่ไดเลือก WareHouse")
            Return False
            Exit Function
        End If

        If clsConfig.IsNull(cbomtl_subinventory.SelectedValue, 0) = 0 Then
            MessageBox.Show("คุณยังไม่ได้เลือก Subinventory", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button3)
            ErrorProvider1.SetError(cbomtl_subinventory, "คุณยังไม่ได้เลือก Subinventory")
            Return False
            Exit Function
        End If

        If clsConfig.IsNull(cbomtl_location.SelectedValue, 0) = 0 Then
            MessageBox.Show("คุณยังไม่ไดเลือก Location", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button3)
            ErrorProvider1.SetError(cbomtl_location, "คุณยังไม่ได้เลือก Locations")
            Return False
            Exit Function
        End If

        If txtBillNo.Text.Trim.Length = 0 Then
            MessageBox.Show("คุณยังไม่ได้ใส่ Bill No.", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button3)
            ErrorProvider1.SetError(txtBillNo, "คุณยังไม่ได้ใส่ Bill No.")
            Return False
            Exit Function
        End If

        ErrorProvider1.Clear()
        Return True
    End Function
    'Private Sub SaveData()
    '    Try
    '        'If MsgBox("Are you sure to Save ?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
    '        If SaveGINPFD() Then
    '            Call GenCboGINPFDNo()
    '            Call getGINPFDManual(clsConfig.IsNull(txtGINNo.Text.Trim, ""))

    '        End If
    '        'End If
    '    Catch ex As Exception
    '        MsgBox("มีข้อผิดพลาดเกี่ยวกับการบันทึกข้อมูลครับ", MsgBoxStyle.Critical, "Insertdata Fail")
    '    End Try     '

    '    'Dim objDB As New classStockG
    '    'Dim dt As New DataTable
    '    'dt = objDB.SaveGINPFDManual(dfno, clsUser.UserID)
    '    'Call InitControl()
    '    ''If dt.Rows.Count > 0 Then Call BindData(dt)
    '    'Call BindGrid(grdData, dt)
    'End Sub

    Private Function SaveGINPFD(Optional ByVal strGINNO As String = "") As Boolean
        Dim config As New clsConfig
        config.ChangeCulture()
        Dim objDB As New classStockG
        Dim Greige_Header As New classStockG.Greige_Header
        Dim msgerr As String = ""
        Dim Tran_no As String = strGINNO


        Greige_Header.h01_suppcd = ""
        Greige_Header.h02_source = ""
        Greige_Header.h03_source_refno = ""
        Greige_Header.h04_tran_no = txtGINNo.Text
        Greige_Header.h05_tran_dt = dtpGINDATE.Value

        Greige_Header.h25_loc = "NEW"

        Greige_Header.h53_preseted = "1"

        Greige_Header.h70_tran_type = "PRESET"



        Dim dtc As DataTable = grdData.DataSource
        Dim j As Integer = 0
        For j = 0 To dtc.Rows.Count - 1
            If dtc.Rows(j).RowState <> DataRowState.Deleted Then
                If txtBillNo.Text <> dtc.Rows(j)("source_refno").ToString.Trim And dtc.Rows(j).RowState <> DataRowState.Deleted Then
                    dtc.Rows(j)("source_refno") = txtBillNo.Text
                End If
                If txtDFNo.Text <> dtc.Rows(j)("dfno").ToString.Trim And dtc.Rows(j).RowState <> DataRowState.Deleted Then
                    dtc.Rows(j)("dfno") = txtDFNo.Text
                End If
                If cboDyedHouse.SelectedValue <> (New clsConfig).IsNull(dtc.Rows(j)("dhcod"), 0) Then
                    dtc.Rows(j)("dhcod") = cboDyedHouse.SelectedValue
                End If
                If txtLotNo.Text <> dtc.Rows(j)("lot").ToString.Trim And dtc.Rows(j).RowState <> DataRowState.Deleted Then
                    dtc.Rows(j)("lot") = txtLotNo.Text
                End If
                If cbomtl_warehouse.SelectedValue <> (New clsConfig).IsNull(dtc.Rows(j)("mtl_warehouse_id"), 0) And dtc.Rows(j).RowState <> DataRowState.Deleted Then
                    dtc.Rows(j)("mtl_warehouse_id") = cbomtl_warehouse.SelectedValue
                End If
                If cbomtl_subinventory.SelectedValue <> (New clsConfig).IsNull(dtc.Rows(j)("mtl_subinventory_id"), 0) And dtc.Rows(j).RowState <> DataRowState.Deleted Then
                    dtc.Rows(j)("mtl_subinventory_id") = cbomtl_subinventory.SelectedValue
                End If
                If cbomtl_location.SelectedValue <> (New clsConfig).IsNull(dtc.Rows(j)("mtl_locations_id"), 0) And dtc.Rows(j).RowState <> DataRowState.Deleted Then
                    dtc.Rows(j)("mtl_locations_id") = cbomtl_location.SelectedValue
                End If
                If cbomtl_location.Text <> (New clsConfig).IsNull(dtc.Rows(j)("loc"), "").ToString.Trim And dtc.Rows(j).RowState <> DataRowState.Deleted Then
                    dtc.Rows(j)("loc") = cbomtl_location.Text
                End If
            End If
        Next


        Dim dv_dtc_add As New DataView(dtc, "", "", DataViewRowState.Added)
        Dim dv_dtc_upd As New DataView(dtc, "", "", DataViewRowState.ModifiedCurrent)
        Dim dv_dtc_del As New DataView(dtc, "", "", DataViewRowState.Deleted)



        If objDB.GinPFDsave(Greige_Header, msgerr, dtc, dv_dtc_add, dv_dtc_upd, dv_dtc_del, clsUser.UserID, Tran_no) Then
            strGINNO = Tran_no
            txtGINNo.Text = strGINNO.Trim
            Call GenCboGINPFDNo()
            Call getGINPFDManual(clsConfig.IsNull(txtGINNo.Text.Trim, ""))
            '    'strPacking_no = PLGNo
            '    'btngout.Enabled = True
            MessageBox.Show("Save is Complete! : บันทึกสำเร็จ! ", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
            SaveGINPFD = True

        Else
            SaveGINPFD = False
            MessageBox.Show(msgerr, "System Message", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
        End If

    End Function

    Private Sub btnCancel_Click(sender As System.Object, e As System.EventArgs) Handles btnCancel.Click
        'Sitthana 20220624 Changed Windows.Forms.DialogResult To DialogResult
        Dim result As DialogResult ' Windows.Forms.DialogResult
        result = MessageBox.Show("Would you like to cancel document no. " & txtGINNo.Text & " ?", "System Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button3)
        If result <> DialogResult.Yes Then Exit Sub

        If Not CheckDataCancel() Then Exit Sub

        Dim message As String = ""

        If (New classStock).CancelGIN(strGINNo:=txtGINNo.Text, Dtptran_dt:=dtpGINDATE.Value, strEmpCode:=clsUser.UserID, Strmessage:=message) Then
            MessageBox.Show("cancel is completed", "System Message!", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Call btnNew_Click(sender, e)
        Else
            MessageBox.Show(message, "System Message!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
        ' Call Canceldata()
    End Sub

    Private Function CheckDataCancel() As Boolean
        If txtGINNo.Text.Trim.Length = 0 Then
            MessageBox.Show("คุณยังไม่ได้เลือก D IN No.", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return False
            Exit Function
        End If

        Return True
    End Function
    Private Sub Canceldata()

        If CANCELGINPFD() Then
            InitControl()
            GenCboGINPFDNo()
        Else

            Exit Sub
        End If

    End Sub
    Public Function CancelGINPFD(Optional ByVal strGINNO As String = "") As Boolean
        Dim config As New clsConfig
        config.ChangeCulture()
        Dim objDB As New classStockG
        Dim Greige_Header As New classStockG.Greige_Header
        Dim msgerr As String = ""
        Dim Tran_no As String = strGINNO


        Greige_Header.h01_suppcd = ""
        Greige_Header.h02_source = ""
        Greige_Header.h03_source_refno = ""
        Greige_Header.h04_tran_no = txtGINNo.Text
        Greige_Header.h05_tran_dt = dtpGINDATE.Value

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
        result = MessageBox.Show("Would you like to cancel document no. " & txtGINNo.Text & " ?", "System Message", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button3)
        If result = DialogResult.Cancel Then blnCancel = True
        If result <> DialogResult.Yes Then Exit Function

        If objDB.GINPFDcancel(Greige_Header, msgerr, dtc, dv_dtc_add, dv_dtc_upd, dv_dtc_del, clsUser.UserID, Tran_no) Then
            strGINNO = Tran_no
            txtGINNo.Text = strGINNO.Trim
            '    'strPacking_no = PLGNo
            '    'btngout.Enabled = True
            MessageBox.Show("Cancel is Complete! : ยกเลิกสำเร็จ! GIN No. " + strGINNO.Trim, "System Message", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
            CancelGINPFD = True

        Else
            CancelGINPFD = False
            MessageBox.Show(msgerr, "System Message", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
        End If



    End Function

    Private Sub btnPrint_Click(sender As System.Object, e As System.EventArgs)
        'print
        If txtGINNo.Text = "" Then Exit Sub
        Const rptFileName = "rptGIN.rpt"
        If clsUser.ReportPath = "" Then clsUser.ReportPath = clsUser.ReportPath
        If Not clsConfig.CheckReport(clsUser.ReportPath, rptFileName) Then Exit Sub
        Dim frm As New frmReport
        Dim rpt As New CrystalDecisions.CrystalReports.Engine.ReportDocument
        Me.Cursor = Cursors.WaitCursor

        rpt.Load(clsUser.ReportPath & rptFileName)
        rpt.DataSourceConnections.Item(0).SetConnection(clsConn.servername, clsConn.database, False)
        rpt.DataSourceConnections.Item(0).SetLogon(clsConn.Userid, clsConn.Password)

        rpt.VerifyDatabase()
        rpt.SetParameterValue("@trannofr", txtGINNo.Text)
        rpt.SetParameterValue("@trannoto", txtGINNo.Text)

        'rpt.PrintOptions.PaperSize = CrystalDecisions.Shared.PaperSize.PaperLetter
        'rpt.PrintOptions.PaperOrientation = CrystalDecisions.Shared.PaperOrientation.Portrait
        'rpt.PrintOptions.PaperSource = CrystalDecisions.Shared.PaperSource.Auto

        frm.Title = "Greige In"
        frm.CRViewer.ReportSource = rpt
        frm.MdiParent = Me.ParentForm
        frm.Show()
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub btnExit_Click(sender As System.Object, e As System.EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
    Private Sub frmStockGIN_PFD_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If MessageBox.Show("Would you like to close ?", "System Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.No Then
            e.Cancel = True
        End If
    End Sub

    Private Sub btncopy_Click(sender As System.Object, e As System.EventArgs)
        ' GetcopyRollNo()

    End Sub

    Private Function GetcopyRollNo() As Boolean
        Dim dtc As DataTable = grdData.DataSource
        Dim newrow As DataRow
        If grdData.Rows.Count > 0 Then

            newrow = dtc.NewRow

            'newrow.Item("suppcd") = grdData.CurrentRow.Cells("suppcd").Value
            newrow.Item("source_refno") = grdData.CurrentRow.Cells("source_refno").Value
            'newrow.Item("dfno") = grdData.CurrentRow.Cells("dfno").Value
            newrow.Item("design_no") = grdData.CurrentRow.Cells("design_no").Value
            newrow.Item("gwth") = grdData.CurrentRow.Cells("gwth").Value
            newrow.Item("col") = grdData.CurrentRow.Cells("col").Value
            newrow.Item("roll_no_o") = grdData.CurrentRow.Cells("roll_no_o").Value
            newrow.Item("sono") = grdData.CurrentRow.Cells("sono").Value
            newrow.Item("sonoid") = grdData.CurrentRow.Cells("sonoid").Value
            newrow.Item("kg") = grdData.CurrentRow.Cells("kg").Value
            newrow.Item("mts") = grdData.CurrentRow.Cells("mts").Value
            newrow.Item("yds") = grdData.CurrentRow.Cells("yds").Value
            newrow.Item("lot") = grdData.CurrentRow.Cells("lot").Value
            newrow.Item("roll_no_f") = grdData.CurrentRow.Cells("roll_no_f").Value
            newrow.Item("mcno") = grdData.CurrentRow.Cells("mcno").Value
            'newrow.Item("kono") = grdData.CurrentRow.Cells("kono").Value
            newrow.Item("grade_bdt") = grdData.CurrentRow.Cells("grade_bdt").Value
            newrow.Item("grade_adt") = grdData.CurrentRow.Cells("grade_adt").Value
            newrow.Item("grade") = grdData.CurrentRow.Cells("grade").Value
            newrow.Item("rem_qc") = grdData.CurrentRow.Cells("rem_qc").Value
            newrow.Item("thickness") = grdData.CurrentRow.Cells("thickness").Value
            newrow.Item("useable_mts") = grdData.CurrentRow.Cells("useable_mts").Value

            dtc.Rows.Add(newrow)

            Return True


        End If

        Return False

    End Function

    Private Sub grdData_CellContentClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles grdData.CellContentClick

    End Sub

    Private Sub grdData_CellEndEdit(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles grdData.CellEndEdit

        Dim config As New clsConfig


        If grdData.Columns(e.ColumnIndex).Name = "mts" Then

            grdData.Rows(e.RowIndex).Cells("yds").Value = FormatNumber(config.IsNull(grdData.Rows(e.RowIndex).Cells("mts").Value, 0) / 0.9144, 4, TriState.False, TriState.False, TriState.True)
        ElseIf grdData.Columns(e.ColumnIndex).Name = "yds" Then
            grdData.Rows(e.RowIndex).Cells("mts").Value = FormatNumber(config.IsNull(grdData.Rows(e.RowIndex).Cells("yds").Value, 0) * 0.9144, 4, TriState.False, TriState.False, TriState.True)

        End If

        If grdData.Columns(e.ColumnIndex).Name = "grade_bdt" Or
         grdData.Columns(e.ColumnIndex).Name = "grade_adt" Then
            grdData.Rows(e.RowIndex).Cells("grade").Value = grdData.Rows(e.RowIndex).Cells("grade_bdt").Value.ToString.ToUpper.Trim + grdData.Rows(e.RowIndex).Cells("grade_adt").Value.ToString.ToUpper.Trim
        End If

        Call SumGrdData()
    End Sub

    Private Sub SumGrdData()

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

        'For j = 0 To grdData.Rows.Count - 1
        'grdData.Rows(i).Cells("mts").Value = FormatNumber(config.IsNull(grdData.Rows(i).Cells("mts").Value, 0), 2, TriState.False, TriState.False, TriState.True)

        'grdData.Rows(j).Cells("yds").Value = FormatNumber(config.IsNull(grdData.Rows(j).Cells("mts").Value, 0) / 0.9144, 2, TriState.False, TriState.False, TriState.True)
        'Next


        For i = 0 To grdData.Rows.Count - 1
            dblKgs = dblKgs + config.IsNull(grdData.Rows(i).Cells("kg").Value, 0)
            dblMts = dblMts + config.IsNull(grdData.Rows(i).Cells("mts").Value, 0)
            dblYds = dblYds + config.IsNull(grdData.Rows(i).Cells("yds").Value, 0)
        Next

        txtTotalRolls.Text = FormatNumber(grdData.Rows.Count, 0, TriState.False, TriState.False, TriState.True)
        txtTotalKgs.Text = FormatNumber(dblKgs, 2, TriState.False, TriState.False, TriState.True)
        txtTotalMts.Text = FormatNumber(dblMts, 2, TriState.False, TriState.False, TriState.True)
        txtTotalYds.Text = FormatNumber(dblYds, 2, TriState.False, TriState.False, TriState.True)

    End Sub

    Private Sub grdData_CellValueChanged(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles grdData.CellValueChanged
        Dim obj As New classMaster
        Dim clsStockD As New classStockG
        Dim config As New clsConfig
        Dim designNo As String
        'Dim SoNo As String
        If e.RowIndex < 0 Or e.ColumnIndex < 0 Then Exit Sub

        If grdData.Columns(e.ColumnIndex).Name = "design_no" Then
            designNo = grdData.Rows(e.RowIndex).Cells("design_no").Value
            'grdData.Rows(e.RowIndex).Cells("colrefdesno").Value = obj.GetArticle(designNo)
            'grdData.Rows(e.RowIndex).Cells("colgmpersqm").Value = obj.GetGmPerSqm(designNo)
            grdData.Rows(e.RowIndex).Cells("Fwth").Value = obj.GetFWth(designNo)

            ' get article no. and show in grid
        End If

        'If grdData.Columns(e.ColumnIndex).Name = "sono" Then
        ' SoNo = grdData.Rows(e.RowIndex).Cells("sono").Value
        'grdData.Rows(e.RowIndex).Cells("sonoid").Value = clsStockD.GetSoNoId(SoNo, "", clsUser.UserID)

        ' get so no. and show in grid
        'End If

        'If grdData.Columns(e.ColumnIndex).Name = "mts" Then
        '    'grdData.Rows(e.RowIndex).Cells("mts").Value = FormatNumber(config.IsNull(grdData.Rows(e.RowIndex).Cells("mts").Value, 0), 2, TriState.False, TriState.False, TriState.True)

        '    grdData.Rows(e.RowIndex).Cells("yds").Value = FormatNumber(config.IsNull(grdData.Rows(e.RowIndex).Cells("mts").Value, 0) / 0.9144, 4, TriState.False, TriState.False, TriState.True)
        'Else If grdData.Columns(e.ColumnIndex).Name = "yds" Then
        '    'grdData.Rows(e.RowIndex).Cells("mts").Value = FormatNumber(config.IsNull(grdData.Rows(e.RowIndex).Cells("yds").Value, 0) * 0.9144, 2, TriState.False, TriState.False, TriState.True)
        '    grdData.Rows(e.RowIndex).Cells("mts").Value = FormatNumber(config.IsNull(grdData.Rows(e.RowIndex).Cells("yds").Value, 0) * 0.9144, 4, TriState.False, TriState.False, TriState.True)

        'End If

        If grdData.Columns(e.ColumnIndex).Name = "yds" Then
            'grdData.Rows(e.RowIndex).Cells("mts").Value = FormatNumber(config.IsNull(grdData.Rows(e.RowIndex).Cells("yds").Value, 0) * 0.9144, 2, TriState.False, TriState.False, TriState.True)
            'grdData.Rows(e.RowIndex).Cells("mts").Value = FormatNumber(config.IsNull(grdData.Rows(e.RowIndex).Cells("yds").Value, 0) * 0.9144, 2, TriState.False, TriState.False, TriState.True)
        End If

    End Sub

    Private Sub btncopyRoll_Click(sender As Object, e As EventArgs) Handles btncopyRoll.Click
        Call GetcopyRollNo()
    End Sub

    Private Sub cbomtl_warehouse_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbomtl_warehouse.SelectedIndexChanged

    End Sub

    Private Sub cbomtl_warehouse_DropDownClosed(sender As Object, e As EventArgs) Handles cbomtl_warehouse.DropDownClosed
        Call GetComboNewSubInventory(Int64mtl_warehouse_id:=(New clsConfig).IsNull(cbomtl_warehouse.SelectedValue, Nothing))
        Call Setdefaultsubinventory(cbomtl_subinventory.DataSource)
        Call GetComboLocation(Int64mtl_warehouse_id:=(New clsConfig).IsNull(cbomtl_warehouse.SelectedValue, Nothing),
                              Int64mtl_subinventory_id:=(New clsConfig).IsNull(cbomtl_subinventory.SelectedValue, Nothing))
        Call SetDefaultLocation(cbomtl_location.DataSource)
    End Sub

    Private Sub cbomtl_subinventory_DropDownStyleChanged(sender As Object, e As EventArgs) Handles cbomtl_subinventory.DropDownStyleChanged

    End Sub

    Private Sub cbomtl_subinventory_DropDownClosed(sender As Object, e As EventArgs) Handles cbomtl_subinventory.DropDownClosed
        Call GetComboLocation(Int64mtl_warehouse_id:=(New clsConfig).IsNull(cbomtl_warehouse.SelectedValue, Nothing),
                            Int64mtl_subinventory_id:=(New clsConfig).IsNull(cbomtl_subinventory.SelectedValue, Nothing))
        Call SetDefaultLocation(cbomtl_location.DataSource)
    End Sub

    Private Sub txtDFNo_KeyDown(sender As Object, e As KeyEventArgs) Handles txtDFNo.KeyDown
        If e.KeyCode = Keys.Enter Then GetDForder(txtDFNo.Text)
    End Sub

    Private Sub btnEntryDefectRoll_Click(sender As Object, e As EventArgs) Handles btnEntryDefectRoll.Click
        If txtGINNo.Text.Trim = "" Then
            MessageBox.Show("ให้คุณเลือก เลขที่ G-In ก่อนครับ", "ข้อความเตือน", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
        Else
            Dim ObjfrmStockDefectRollGIN_PFD As New frmStockGIN_PFD_DefectRoll
            ObjfrmStockDefectRollGIN_PFD.TranNo = txtGINNo.Text.Trim  '"GI17060321"
            ObjfrmStockDefectRollGIN_PFD.TranDt = dtpGINDATE.Text.Trim
            ObjfrmStockDefectRollGIN_PFD.ShowDialog()
        End If
    End Sub

    Private Sub tsmnGINDocumentStandard_Click(sender As Object, e As EventArgs) Handles tsmnGINDocumentStandard.Click
        printGIDocument("rptGIN.rpt")
    End Sub

    Private Sub tsmnGINDocumentSTG_Click(sender As Object, e As EventArgs) Handles tsmnGINDocumentSTG.Click
        printGIDocument("rptGIN_STG.rpt")
    End Sub

    Private Sub printGIDocument(pReportName As String)
        If txtGINNo.Text = "" Then Exit Sub
        If clsUser.ReportPath = "" Then clsUser.ReportPath = clsUser.ReportPath
        If Not clsConfig.CheckReport(clsUser.ReportPath, pReportName) Then Exit Sub
        Dim frm As New frmReport
        Dim rpt As New CrystalDecisions.CrystalReports.Engine.ReportDocument
        Me.Cursor = Cursors.WaitCursor

        rpt.Load(clsUser.ReportPath & pReportName)
        rpt.DataSourceConnections.Item(0).SetConnection(clsConn.servername, clsConn.database, False)
        rpt.DataSourceConnections.Item(0).SetLogon(clsConn.Userid, clsConn.Password)

        rpt.VerifyDatabase()
        rpt.SetParameterValue("@trannofr", txtGINNo.Text)
        rpt.SetParameterValue("@trannoto", txtGINNo.Text)

        'rpt.PrintOptions.PaperSize = CrystalDecisions.Shared.PaperSize.PaperLetter
        'rpt.PrintOptions.PaperOrientation = CrystalDecisions.Shared.PaperOrientation.Portrait
        'rpt.PrintOptions.PaperSource = CrystalDecisions.Shared.PaperSource.Auto

        frm.Title = "Greige In"
        frm.CRViewer.ReportSource = rpt
        frm.MdiParent = Me.ParentForm
        frm.Show()
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub tsmnGINTagStandared_Click(sender As Object, e As EventArgs) Handles tsmnGINTagStandared.Click
        PrintReport("rptGreigeBarcode.rpt")
    End Sub

    Private Sub tsmnGINTagSTGCustomerFormat_Click(sender As Object, e As EventArgs) Handles tsmnGINTagSTGCustomerFormat.Click
        PrintReport("rptGreigeBarcodeSTG.rpt")
    End Sub

    Private Sub PrintReport(pReportName As String)
        Dim clsConfig As New clsConfig
        'Dim rptFileName As String
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
        If Not clsConfig.CheckReport(clsUser.ReportPath, pReportName) Then Exit Sub

        Dim frm As New frmReport
        Dim rpt As New CrystalDecisions.CrystalReports.Engine.ReportDocument
        Dim stype As String = ""
        Dim ord As String = ""
        Me.Cursor = Cursors.WaitCursor

        rpt.Load(clsUser.ReportPath & pReportName)
        rpt.DataSourceConnections.Item(0).SetConnection(clsConn.servername, clsConn.database, False)
        rpt.DataSourceConnections.Item(0).SetLogon(clsConn.Userid, clsConn.Password)
        rpt.VerifyDatabase()
        rpt.SetParameterValue("@roll_no", txtGINNo.Text)
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

    Private Sub TagPresslessToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TagPresslessToolStripMenuItem.Click
        If txtGINNo.Text.Trim.Length = 0 Then
            MessageBox.Show("คุณยังไมได้ทำ GOUT", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
            Exit Sub
        End If
        Dim rptFileName As String = ""    'Sitthana 20190509

        printTagPressless("rptGreigeInBarcodePressless.rpt")

    End Sub

    Private Sub printTagPressless(pReportName As String)
        'Sittthana 20190509

        Dim clsConfig As New clsConfig
        'Dim rptFileName = "" '-"rptGreigeOutBarcode.rpt", "rptGreigeOutBarcodePressless.rpt"
        ''Sitthana 20190429
        'If CustCd.Trim = PresslessCustCd Then
        '    'Pressless
        '    rptFileName = "rptGreigeOutBarcodePressless.rpt"
        'Else
        '    rptFileName = "rptGreigeOutBarcode.rpt"
        'End If

        If clsUser.ReportPath = "" Then clsUser.ReportPath = clsUser.ReportPath
        If Not clsConfig.CheckReport(clsUser.ReportPath, pReportName) Then Exit Sub
        Dim frm As New frmReport
        Dim rpt As New CrystalDecisions.CrystalReports.Engine.ReportDocument
        Dim stype As String = ""
        Dim ord As String = ""
        Me.Cursor = Cursors.WaitCursor

        rpt.Load(clsUser.ReportPath & pReportName)
        rpt.DataSourceConnections.Item(0).SetConnection(clsConn.servername, clsConn.database, False)
        rpt.DataSourceConnections.Item(0).SetLogon(clsConn.Userid, clsConn.Password)
        rpt.VerifyDatabase()
        rpt.SetParameterValue("@p_GinNo", txtGINNo.Text.Trim)

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