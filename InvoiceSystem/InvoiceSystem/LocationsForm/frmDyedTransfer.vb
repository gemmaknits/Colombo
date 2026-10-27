Public Class frmDyedTransfer
    Dim config As New clsConfig
    Dim stock As New classStockTransferD
    Dim trn_id As Long = 0
    Dim trn_no As String = ""
    Dim clsUser As New classUserInfo
    Dim strdono As String
    Dim strdinno As String


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
        'txtLocation.Text = ""
        ' txtSubLocation.Text = ""

        'txtLocation.Enabled = True
        ' txtSubLocation.Enabled = True
        'cboNewmtl_subinventory.Enabled = True
        'cboNewmtl_warehouse.Enabled = True
        'cboNewmtl_locations.Enabled = True

        grdRollNo.DataSource = vbNull

        trn_id = 0
        trn_no = ""
        Call LoadData("")
    End Sub

    Private Sub EnabledControl(ByVal value As Boolean)
        ' txtLocation.Enabled = value
        ' txtSubLocation.Enabled = value
        grdRollNo.Enabled = value
    End Sub

    Private Sub BindData(ByVal dt As DataTable)
        ' txtLocation.Text = dt.Rows(0)("new_location").ToString
        ' txtSubLocation.Text = dt.Rows(0)("new_sub_location").ToString
    End Sub

    Private Sub LoadTrnNo()
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
            trn_id = dt.Rows(0)("trn_id")
            trn_no = dt.Rows(0)("trn_no")
            txtTrnNo.Text = trn_no
            dtpTrnDate.Value = dt.Rows(0)("trn_date2")

            cbomtl_warehouse.Enabled = False
            cbomtl_subinventory.Enabled = False
            cbomtl_Location.Enabled = False
            ' txtLocation.Text = dt.Rows(0)("location")
            ' txtSubLocation.Text = dt.Rows(0)("sub_location")
            'If StrTrn_no.Length > 0 Then
            '    'cbomtl_warehouse.Enabled = False
            '    'cbomtl_subinventory.Enabled = False
            '    'cbomtl_Location.Enabled = False
            '    'txtLocation.Enabled = False
            '    'txtSubLocation.Enabled = False
            'Else
            '    'cbomtl_warehouse.Enabled = True
            '    'cbomtl_subinventory.Enabled = True
            '    'cbomtl_Location.Enabled = True
            'End If
        End If
    End Sub

    Private Sub frmGreigeTransfer_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call InitControl()

    End Sub

    Private Sub InitControl()
        Call GetAllCombo()
        Call LoadTrnNo()
        Call LoadData("")
        Call GetData(Strroll_no_d:="", strdinno:=strdinno, strdono:="", Strlot:="")

        cbomtl_warehouse.Enabled = True
        cbomtl_subinventory.Enabled = True
        cbomtl_Location.Enabled = True
    End Sub

    Private Sub GetAllCombo()
        Call GetComboNewWarehouse()
        Call GetComboNewSubInventory((New clsConfig).IsNull(cbomtl_warehouse.SelectedValue, Nothing))
        Call GetComboWarehouseinGrid()
        Call GetcomboSubInventoryinGrid(Int64mtl_warehouse_id:=0)
        Call GetCombomtl_locationInGrid(Int64mtl_warehouse_id:=0, Int64mtl_subinventory_id:=0)
    
    End Sub
    Private Sub GetComboNewWarehouse()
        Dim objdb As New classMaster

        cbomtl_warehouse.DataSource = objdb.Combomtlwarehouse(clsUser.UserID)
        cbomtl_warehouse.DisplayMember = "warehouse_code"
        cbomtl_warehouse.ValueMember = "mtl_warehouse_id"
        cbomtl_warehouse.SelectedIndex = -1

    End Sub
    Private Sub GetComboNewSubInventory(Optional ByVal Int64mtl_warehouse_id As Nullable(Of Int64) = Nothing)
        Dim objdb As New classMaster

        cbomtl_subinventory.DataSource = objdb.GetCombomtl_subinventory(cbomtl_warehouse.SelectedValue)
        cbomtl_subinventory.DisplayMember = "subinventory_code"
        cbomtl_subinventory.ValueMember = "mtl_subinventory_id"
        cbomtl_subinventory.SelectedValue = -1

    End Sub



    Private Sub GetComboNewLocation(ByVal Int64mtl_warehouse_id As Int64, ByVal Int64mtl_subinventory_id As Int64)
        Dim objdb As New classMaster
        cbomtl_Location.DataSource = objdb.Combomtllocations(strUSerID:=clsUser.UserID, INt64mtl_warehouse_id:=Int64mtl_warehouse_id, Int64mtl_subinventory_id:=Int64mtl_subinventory_id)
        cbomtl_Location.DisplayMember = "location_name"
        cbomtl_Location.ValueMember = "mtl_locations_id"
        cbomtl_Location.SelectedValue = -1
    End Sub

    Private Sub GetCombomtl_locationInGrid(Optional ByVal Int64mtl_warehouse_id As Nullable(Of Int64) = Nothing, _
                                           Optional ByVal Int64mtl_subinventory_id As Nullable(Of Int64) = Nothing)
        Dim objdb As New classMaster



        mtl_locations_id.DataSource = objdb.Combomtllocations(strUSerID:=clsUser.UserID, INt64mtl_warehouse_id:=Int64mtl_warehouse_id, Int64mtl_subinventory_id:=Int64mtl_subinventory_id)
        mtl_locations_id.DisplayMember = "location_name"
        mtl_locations_id.ValueMember = "mtl_locations_id"

        old_mtl_locations_id.DataSource = objdb.Combomtllocations(strUSerID:=clsUser.UserID, INt64mtl_warehouse_id:=Int64mtl_warehouse_id, Int64mtl_subinventory_id:=Int64mtl_subinventory_id)
        old_mtl_locations_id.DisplayMember = "location_name"
        old_mtl_locations_id.ValueMember = "mtl_locations_id"
        'cboNewmtl_locations.SelectedValue = -1
    End Sub

    Private Sub GetcomboSubInventoryinGrid(ByVal Int64mtl_warehouse_id As Int64)
        Dim objdb As New classMaster


        mtl_subinventory_id.DataSource = objdb.GetCombomtl_subinventory(Int64mtl_warehouse_id)
        mtl_subinventory_id.DisplayMember = "subinventory_code"
        mtl_subinventory_id.ValueMember = "mtl_subinventory_id"

        'mtl_subinventory_id.DataSource = objdb.GetCombomtl_subinventory(0)
        'mtl_subinventory_id.DisplayMember = "subinventory_name"
        'mtl_subinventory_id.ValueMember = "mtl_subinventory_id"
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
        Call Initialize()
        'txtLocation.Focus()
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click


        If MessageBox.Show("Would you like to save ?", "System Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = DialogResult.Yes Then


            Dim dt As DataTable = grdRollNo.DataSource
            Dim TrnH As New classStockTransferD.TrnHeader
            If grdRollNo.Rows.Count > 0 Then
                For i = 0 To grdRollNo.Rows.Count - 1
                    TrnH.h01_trn_id = trn_id
                    TrnH.h02_trn_no = txtTrnNo.Text.Trim
                    TrnH.h03_trn_date = dtpTrnDate.Value.ToString("yyyyMMdd")
                    TrnH.h04_trn_time = ""
                    TrnH.h05_new_location = Me.grdRollNo.Rows(0).Cells("mtl_locations_id").FormattedValue.ToString()
                    TrnH.h06_new_sub_location = ""
                    TrnH.h07_login_empcd = clsUser.UserID
                    TrnH.h08_mtl_warehouse_id = grdRollNo.Rows(0).Cells("mtl_warehouse_id").Value 'dt.Rows(0)("mtl_warehouse_id")
                    TrnH.h09_mtl_subinventory_id = grdRollNo.Rows(0).Cells("mtl_subinventory_id").Value 'dt.Rows(0)("mtl_locations_id")
                    TrnH.h10_mtl_locations_id = grdRollNo.Rows(0).Cells("mtl_locations_id").Value
                Next
            End If
            Dim dv_add As New DataView(dt, "", "", DataViewRowState.Added)
            Dim dv_upd As New DataView(dt, "", "", DataViewRowState.ModifiedCurrent)
            Dim dv_del As New DataView(dt, "", "", DataViewRowState.Deleted)
            'Dim TrnH As New classStockTransferD.TrnHeader
            Dim msg_err As String = ""
            'TrnH.h01_trn_id = trn_id
            'TrnH.h02_trn_no = txtTrnNo.Text.Trim
            'TrnH.h03_trn_date = dtpTrnDate.Value.ToString("yyyyMMdd")
            'TrnH.h04_trn_time = ""
            'TrnH.h05_new_location = cboNewmtl_locations.Text
            '' TrnH.h06_new_sub_location = txtSubLocation.Text
            'TrnH.h07_login_empcd = clsUser.UserID
            'TrnH.h08_mtl_warehouse_id = cboNewmtl_warehouse.SelectedValue
            'TrnH.h09_mtl_locations_id = cboNewmtl_locations.SelectedValue
            'TrnH.h10_mtl_subinventory_id = cboNewmtl_subinventory.SelectedValue
            If stock.TrnSave(TrnH, dv_add, dv_upd, dv_del, msg_err) Then
                Call LoadTrnNo()
                cboTrnNo.Text = TrnH.h02_trn_no.Trim
                Call LoadData(TrnH.h02_trn_no)
            Else
                MessageBox.Show(msg_err, "System Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If
    End Sub

    Private Sub btnPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrint.Click
        If trn_no = "" Then trn_no = txtTrnNo.Text.Trim
        If trn_no.Length = 0 Then Exit Sub
        Const rptFileName = "rptDyedTransfer.rpt"
        Dim clsConfig As New clsConfig
        Dim clsConn As New ClassConnection
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
        rpt.SetParameterValue("@trn_no", trn_no)

        rpt.PrintOptions.PaperSize = CrystalDecisions.Shared.PaperSize.PaperA4
        rpt.PrintOptions.PaperOrientation = CrystalDecisions.Shared.PaperOrientation.Portrait
        rpt.PrintOptions.PaperSource = CrystalDecisions.Shared.PaperSource.Auto

        frm.Title = "Dyed Transfer"
        frm.CRViewer.ReportSource = rpt
        frm.MdiParent = Me.ParentForm
        frm.Show()
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        If MessageBox.Show("Would you like to cancel this document ?", "System Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = DialogResult.Yes Then
            If stock.TrnDelete(trn_id, clsUser.UserID) Then
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
        If grdRollNo.Columns(e.ColumnIndex).Name = "roll_no_g" Then
            If config.IsNull(grdRollNo.Rows(e.RowIndex).Cells("roll_no_g").Value, "") <> "" And config.IsNull(grdRollNo.Rows(e.RowIndex).Cells("g_location").Value, "") = "" Then
                Dim dt As DataTable = stock.GetRollLocationD(trn_id:=trn_id, trn_no:=trn_no, roll_no_d:=grdRollNo.Rows(e.RowIndex).Cells("roll_no_g").Value, lot:="")
                Dim dt2 As DataTable = grdRollNo.DataSource
                If dt.Rows.Count > 0 Then
                    grdRollNo.Rows(e.RowIndex).Cells("g_location").Value = dt.Rows(0)("location")
                    grdRollNo.Rows(e.RowIndex).Cells("sub_location").Value = dt.Rows(0)("sub_location")
                    grdRollNo.Rows(e.RowIndex).Cells("status").Value = dt.Rows(0)("status")
                    grdRollNo.Rows(e.RowIndex).Cells("new_status").Value = dt.Rows(0)("new_status")
                End If
            End If
        End If


        Dim objdb As New classMaster


        Dim dgvccSubInven As New DataGridViewComboBoxCell
        Dim dtSubInven As New DataTable
        If grdRollNo.Columns(e.ColumnIndex).Name = "mtl_warehouse_id" Then
            If Not IsDBNull(grdRollNo.Rows(e.RowIndex).Cells("mtl_warehouse_id").Value) Then
                dtSubInven = objdb.GetCombomtl_subinventory(grdRollNo.Rows(e.RowIndex).Cells("mtl_warehouse_id").Value)
                dgvccSubInven = grdRollNo.Rows(e.RowIndex).Cells("mtl_subinventory_id")
                Try
                    dgvccSubInven.DataSource = dtSubInven
                    dgvccSubInven.DisplayMember = "subinventory_code"
                    dgvccSubInven.ValueMember = "mtl_subinventory_id"
                    'dgvccSubInven.Value = dtSubInven.Rows(0)("mtl_subinventory_id") 'Fix Error

                    Dim expression As String
                    expression = "subinventory_code like '%DYED%'"
                    Dim foundRows() As DataRow
                    foundRows = dtSubInven.Select(expression)
                    dgvccSubInven.Value = foundRows(0)("mtl_subinventory_id")
                Catch ex As Exception

                    'SetDefault
                    Dim expression As String
                    expression = "subinventory_code like '%DYED%'"
                    Dim foundRows() As DataRow
                    foundRows = dtSubInven.Select(expression)

                    dgvccSubInven.Value = foundRows(0)(0)
                    'dgvccSubInven.DataSource = dtSubInven
                    'dgvccSubInven.DisplayMember = "subinventory_name"
                    'dgvccSubInven.ValueMember = "mtl_subinventory_id"
                    dgvccSubInven.Value = DBNull.Value
                    'dgvccSubInven.Value = DBNull.Value
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


    Private Sub txtBarcode_Keydown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtBarcode.KeyDown
        If e.KeyCode = Keys.Enter Then

            Dim dt As DataTable
            dt = stock.GetRollLocationD(trn_id:=trn_id, trn_no:=trn_no, roll_no_d:=txtBarcode.Text, lot:="")
            Dim dt2 As DataTable = grdRollNo.DataSource
            Dim r As DataRow
            r = dt2.NewRow
            For i = 0 To dt.Rows.Count - 1
                'If Not CheckIsDuplicateRollNoD(Roll_no_d:=dt.Rows(i)("roll_no_d").ToString.Trim) Then
                r("roll_no_d") = dt.Rows(i)("roll_no_d")
                'r("location") = txtLocation.Text
                'r("sub_location") = txtSubLocation.Text

                r("design_no") = dt.Rows(i)("design_no")
                r("lot") = dt.Rows(i)("lot")
                r("col") = dt.Rows(i)("col")
                r("old_mtl_warehouse_id") = dt.Rows(i)("mtl_warehouse_id")
                r("old_mtl_subinventory_id") = dt.Rows(i)("mtl_subinventory_id")
                r("old_mtl_locations_id") = dt.Rows(i)("mtl_locations_id")
                'dt2.Rows.Add(r)
                'End If
                'dt2.Rows.Add(r)


                'r("roll_no_d") = dt.Rows(i)("roll_no_d")
                ''r("location") = txtLocation.Text
                ''r("sub_location") = txtSubLocation.Text

                'r("design_no") = dt.Rows(i)("design_no")
                'r("lot") = dt.Rows(i)("lot")
                'r("col") = dt.Rows(i)("col")
                'r("old_mtl_warehouse_id") = dt.Rows(i)("mtl_warehouse_id")
                'r("old_mtl_locations_id") = dt.Rows(i)("mtl_locations_id")

                'dt2.Rows.Add(r)
                If Not CheckIsDuplicateRollNoD(Roll_no_d:=dt.Rows(i)("roll_no_d").ToString.Trim) Then dt2.Rows.Add(r)
                ' txtlot.Enabled = False
            Next
            'End If

            txtBarcode.SelectAll()
        End If
    End Sub

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


    Private Sub cboNewmtl_subinventory_DropDownClosed(sender As Object, e As System.EventArgs) Handles cbomtl_subinventory.DropDownClosed
        Call GetComboNewLocation(cbomtl_warehouse.SelectedValue, cbomtl_subinventory.SelectedValue)
    End Sub

    Private Sub cbomtl_warehouse_DropDownClosed(sender As Object, e As System.EventArgs) Handles cbomtl_warehouse.DropDownClosed
        Call GetComboNewSubInventory(Int64mtl_warehouse_id:=cbomtl_warehouse.SelectedValue)
        Call GetComboNewLocation(Int64mtl_warehouse_id:=cbomtl_warehouse.SelectedValue, Int64mtl_subinventory_id:=cbomtl_subinventory.SelectedValue)
    End Sub

    Private Sub cbomtl_warehouse_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cbomtl_warehouse.SelectedIndexChanged

    End Sub

    Private Sub btnApply_Click(sender As System.Object, e As System.EventArgs) Handles btnApply.Click

        Dim dt3 As New DataTable
        For i = 0 To grdRollNo.Rows.Count - 1


            grdRollNo.Rows(i).Cells("mtl_warehouse_id").Value() = cbomtl_warehouse.SelectedValue
            Dim dgvcc As New DataGridViewComboBoxCell
            dgvcc = grdRollNo.Rows(i).Cells("mtl_subinventory_id")
            dgvcc.DataSource = cbomtl_subinventory.DataSource
            grdRollNo.Rows(i).Cells("mtl_subinventory_id").Value() = cbomtl_subinventory.SelectedValue
            Dim dgvcc2 As New DataGridViewComboBoxCell
            dgvcc = grdRollNo.Rows(i).Cells("mtl_locations_id")
            dgvcc.DataSource = cbomtl_Location.DataSource
            grdRollNo.Rows(i).Cells("mtl_locations_id").Value() = cbomtl_Location.SelectedValue
        Next
    End Sub

    Private Sub grdRollNo_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles grdRollNo.CellContentClick

    End Sub
End Class