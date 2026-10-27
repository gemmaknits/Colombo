Public Class frmHangerOutControl

    Dim clsConn As New classConnection
    Dim clsConfig As New clsConfig
    Dim clsUser As New classUserInfo

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

    Private Sub frmSampleStockBalance_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'dtpDateFr.Value = CDate("01/01/1900")
        dtpDateFr.Value = CDate(Now)
        dtpDateTo.Value = CDate(Now)
        Call GenCombo()
        txtDesignNo.Focus()
    End Sub

    Private Sub btnPrint_Click(sender As System.Object, e As System.EventArgs) Handles btnPrint.Click
        Dim rptFileName = "rptHangerOutControl.rpt"
        If optDesign.Checked Then rptFileName = "rptHangerOutControlByDesign.rpt"
        If optRequested.Checked Then rptFileName = "rptHangerOutControlBySale.rpt"
        If optCustomer.Checked Then rptFileName = "rptHangerOutControlByCustomers.rpt"
        'Const rptFileName = "rptHangerOutControl.rpt"
        If clsUser.ReportPath = "" Then clsUser.ReportPath = clsUser.ReportPath
        If Not clsConfig.CheckReport(clsUser.ReportPath, rptFileName) Then Exit Sub
        Dim frm As New frmReport
        Dim rpt As New CrystalDecisions.CrystalReports.Engine.ReportDocument
        Me.Cursor = Cursors.WaitCursor

        rpt.Load(clsUser.ReportPath & rptFileName)
        rpt.DataSourceConnections.Item(0).SetConnection(clsConn.servername, clsConn.database, False)
        rpt.DataSourceConnections.Item(0).SetLogon(clsConn.Userid, clsConn.Password)
        rpt.VerifyDatabase()

        rpt.SetParameterValue("@datefr", dtpDateFr.Value.ToString("yyyyMMdd"))
        rpt.SetParameterValue("@dateto", dtpDateTo.Value.ToString("yyyyMMdd"))
        If optPrintAllDesign.Checked Then
            rpt.SetParameterValue("@design_type", 0)
            rpt.SetParameterValue("@design_no", txtDesignNo.Text.Trim)
        ElseIf optPrintOnlyDesign.Checked Then
            rpt.SetParameterValue("@design_type", 1)
            rpt.SetParameterValue("@design_no", txtDesignNo.Text.Trim)
        ElseIf optPrintExceptDesign.Checked Then
            rpt.SetParameterValue("@design_type", 2)
            rpt.SetParameterValue("@design_no", txtDesignNo.Text.Trim)
        End If
        If optPrintAllEmpcd.Checked Then
            rpt.SetParameterValue("@emp_type", 0)
            rpt.SetParameterValue("@empcd", (New clsConfig).IsNull(comboSalesPerson.SelectedValue, ""))
        ElseIf optPrintOnlyEmpcd.Checked Then
            rpt.SetParameterValue("@emp_type", 1)
            rpt.SetParameterValue("@empcd", (New clsConfig).IsNull(comboSalesPerson.SelectedValue, ""))
        ElseIf optPrintExceptEmpcd.Checked Then
            rpt.SetParameterValue("@emp_type", 2)
            rpt.SetParameterValue("@empcd", (New clsConfig).IsNull(comboSalesPerson.SelectedValue, ""))
        End If
        If optPrintAllCustomers.Checked Then
            rpt.SetParameterValue("@customer_type", 0)
            rpt.SetParameterValue("@customer_id", (New clsConfig).IsNull(cboCustomer.SelectedValue, 0))
        ElseIf optPrintOnlyCustomers.Checked Then
            rpt.SetParameterValue("@customer_type", 1)
            rpt.SetParameterValue("@customer_id", (New clsConfig).IsNull(cboCustomer.SelectedValue, 0))
        ElseIf optPrintExceptCustomers.Checked Then
            rpt.SetParameterValue("@customer_type", 2)
            rpt.SetParameterValue("@customer_id", (New clsConfig).IsNull(cboCustomer.SelectedValue, 0))
        End If

        If optPrintAll.Checked Then
            rpt.SetParameterValue("@loc_type", 0)
            rpt.SetParameterValue("@mtl_warehouse_id", 0)
            rpt.SetParameterValue("@mtl_subinventory_id", 0)
            rpt.SetParameterValue("@mtl_locations_id", 0)
        ElseIf optPrintOnly.Checked Then
            rpt.SetParameterValue("@loc_type", 1)
            rpt.SetParameterValue("@mtl_warehouse_id", (New clsConfig).IsNull(cbomtlWarehouse.SelectedValue, 0))
            rpt.SetParameterValue("@mtl_subinventory_id", (New clsConfig).IsNull(cbomtlSubinventory.SelectedValue, 0))
            rpt.SetParameterValue("@mtl_locations_id", (New clsConfig).IsNull(cbomtlLocation.SelectedValue, 0))
        ElseIf optPrintExcept.Checked Then
            rpt.SetParameterValue("@loc_type", 2)
            rpt.SetParameterValue("@mtl_warehouse_id", (New clsConfig).IsNull(cbomtlWarehouse.SelectedValue, 0))
            rpt.SetParameterValue("@mtl_subinventory_id", (New clsConfig).IsNull(cbomtlSubinventory.SelectedValue, 0))
            rpt.SetParameterValue("@mtl_locations_id", (New clsConfig).IsNull(cbomtlLocation.SelectedValue, 0))
        End If


        rpt.SetParameterValue("@logempcd", clsUser.UserName)

        rpt.PrintOptions.PaperSize = CrystalDecisions.Shared.PaperSize.PaperA4
        rpt.PrintOptions.PaperOrientation = CrystalDecisions.Shared.PaperOrientation.Landscape
        rpt.PrintOptions.PaperSource = CrystalDecisions.Shared.PaperSource.Auto

        frm.Title = "Hanger Out Control"
        frm.CRViewer.ReportSource = rpt
        frm.MdiParent = Me.ParentForm
        frm.Show()
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub btnMinimized_Click(sender As System.Object, e As System.EventArgs) Handles btnMinimized.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub btnExit_Click(sender As System.Object, e As System.EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub GenCombo()

        dtmtlLocations = (New classMaster).Combomtllocations(INt64mtl_warehouse_id:=0, Int64mtl_subinventory_id:=0)
        bsMtlLocations.DataSource = dtmtlLocations
        cbomtlLocation.DataSource = bsMtlLocations.DataSource
        cbomtlLocation.DisplayMember = "location_name"
        cbomtlLocation.ValueMember = "mtl_locations_id"

        dtMtlSubInventory = (New classMaster).ComboMtlsubinventory(INt64mtl_warehouse_id:=0)
        bsMtlSubInventory.DataSource = dtMtlSubInventory
        cbomtlSubinventory.DataSource = bsMtlSubInventory.DataSource
        cbomtlSubinventory.DisplayMember = "subinventory_code"
        cbomtlSubinventory.ValueMember = "mtl_subinventory_id"

        dtMtlWarehouse = (New classMaster).Combomtlwarehouse()
        bsMtlWarehouse.DataSource = dtMtlWarehouse
        cbomtlWarehouse.DataSource = bsMtlWarehouse.DataSource
        cbomtlWarehouse.DisplayMember = "warehouse_code"
        cbomtlWarehouse.ValueMember = "mtl_warehouse_id"

        Me.comboSalesPerson.DataSource = (New classMaster).GetEmp
        Me.comboSalesPerson.DisplayMember = "empname"
        Me.comboSalesPerson.ValueMember = "empcd"
        Me.comboSalesPerson.SelectedValue = clsUser.UserID
        Me.comboSalesPerson.SelectedIndex = -1

        Me.cboCustomer.DataSource = (New classMaster).GetCustomer
        Me.cboCustomer.DisplayMember = "name"
        Me.cboCustomer.ValueMember = "customer_id"
        Me.cboCustomer.SelectedIndex = -1
    End Sub

    Private Sub cbomtlWarehouse_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles cbomtlWarehouse.KeyDown

    End Sub

    Private Sub cbomtlWarehouse_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cbomtlWarehouse.SelectedIndexChanged

    End Sub

    Private Sub cbomtlSubinventory_DropDownClosed(sender As Object, e As System.EventArgs) Handles cbomtlSubinventory.DropDownClosed
        ' bsMtlLocations.Filter = "mtl_warehouse_id = '" & (New clsConfig).IsNull(cbomtlWarehouse.SelectedValue, 0) & "' and mtl_subinventory_id = '" & (New clsConfig).IsNull(cbomtlSubinventory.SelectedValue, 0) & "'"
    End Sub

    Private Sub cbomtlSubinventory_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cbomtlSubinventory.SelectedIndexChanged

    End Sub

    Private Sub cbomtlWarehouse_SelectedValueChanged(sender As Object, e As System.EventArgs) Handles cbomtlWarehouse.SelectedValueChanged
        bsMtlSubInventory.Filter = "mtl_warehouse_id = '" & (New clsConfig).IsNull(cbomtlWarehouse.SelectedValue, 0) & "' and sample_subinventory = 'Y'"
        cbomtlSubinventory.SelectedIndex = -1
        bsMtlLocations.Filter = "mtl_warehouse_id = '" & (New clsConfig).IsNull(cbomtlWarehouse.SelectedValue, 0) & "' and mtl_subinventory_id = '" & (New clsConfig).IsNull(cbomtlSubinventory.SelectedValue, 0) & "'"
        cbomtlLocation.SelectedIndex = -1
    End Sub

    Private Sub cbomtlSubinventory_SelectedValueChanged(sender As Object, e As System.EventArgs) Handles cbomtlSubinventory.SelectedValueChanged
        bsMtlLocations.Filter = "mtl_warehouse_id = '" & (New clsConfig).IsNull(cbomtlWarehouse.SelectedValue, 0) & "' and mtl_subinventory_id = '" & (New clsConfig).IsNull(cbomtlSubinventory.SelectedValue, 0) & "'"
        cbomtlLocation.SelectedIndex = -1
    End Sub

    Private Sub optPrintAll_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles optPrintAll.CheckedChanged
        If optPrintAll.Checked Then
            cbomtlWarehouse.SelectedIndex = -1
            cbomtlWarehouse.Enabled = False
            cbomtlSubinventory.SelectedIndex = -1
            cbomtlSubinventory.Enabled = False
            cbomtlLocation.SelectedIndex = -1
            cbomtlLocation.Enabled = False
        End If
    End Sub

    Private Sub optPrintOnly_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles optPrintOnly.CheckedChanged
        If optPrintOnly.Checked Then
            cbomtlWarehouse.Enabled = True
            cbomtlSubinventory.Enabled = True
            cbomtlLocation.Enabled = True
        End If
    End Sub

    Private Sub optPrintExcept_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles optPrintExcept.CheckedChanged
        If optPrintExcept.Checked Then
            cbomtlWarehouse.Enabled = True
            cbomtlSubinventory.Enabled = True
            cbomtlLocation.Enabled = True
        End If
    End Sub

    Private Sub RadioButton7_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles optPrintExceptDesign.CheckedChanged
        If optPrintAllDesign.Checked Then
            txtDesignNo.Enabled = False
        ElseIf optPrintExceptDesign.Checked Then
            txtDesignNo.Enabled = True
        ElseIf optPrintOnlyDesign.Checked Then
            txtDesignNo.Enabled = True
        End If
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles optPrintOnlyDesign.CheckedChanged
        If optPrintAllDesign.Checked Then
            txtDesignNo.Enabled = False
        ElseIf optPrintExceptDesign.Checked Then
            txtDesignNo.Enabled = True
        ElseIf optPrintOnlyDesign.Checked Then
            txtDesignNo.Enabled = True
        End If
    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles optPrintAllDesign.CheckedChanged
        If optPrintAllDesign.Checked Then
            txtDesignNo.Enabled = False
        ElseIf optPrintExceptDesign.Checked Then
            txtDesignNo.Enabled = True
        ElseIf optPrintOnlyDesign.Checked Then
            txtDesignNo.Enabled = True
        End If
    End Sub

    Private Sub optPrintAllEmpcd_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles optPrintAllEmpcd.CheckedChanged
        If optPrintAllEmpcd.Checked Then
            comboSalesPerson.Enabled = False
        ElseIf optPrintExceptEmpcd.Checked Then
            comboSalesPerson.Enabled = True
        ElseIf optPrintOnlyEmpcd.Checked Then
            comboSalesPerson.Enabled = True
        End If
    End Sub

    Private Sub optPrintOnlyEmpcd_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles optPrintOnlyEmpcd.CheckedChanged
        If optPrintAllEmpcd.Checked Then
            comboSalesPerson.Enabled = False
        ElseIf optPrintExceptEmpcd.Checked Then
            comboSalesPerson.Enabled = True
        ElseIf optPrintOnlyEmpcd.Checked Then
            comboSalesPerson.Enabled = True
        End If
    End Sub

    Private Sub optPrintExceptEmpcd_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles optPrintExceptEmpcd.CheckedChanged
        If optPrintAllEmpcd.Checked Then
            comboSalesPerson.Enabled = False
        ElseIf optPrintExceptEmpcd.Checked Then
            comboSalesPerson.Enabled = True
        ElseIf optPrintOnlyEmpcd.Checked Then
            comboSalesPerson.Enabled = True
        End If
    End Sub

    Private Sub optPrintAllCustomers_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles optPrintAllCustomers.CheckedChanged
        If optPrintAllCustomers.Checked Then
            cboCustomer.Enabled = False
        ElseIf optPrintExceptCustomers.Checked Then
            cboCustomer.Enabled = True
        ElseIf optPrintOnlyCustomers.Checked Then
            cboCustomer.Enabled = True
        End If
    End Sub

    Private Sub optPrintOnlyCustomers_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles optPrintOnlyCustomers.CheckedChanged
        If optPrintAllCustomers.Checked Then
            cboCustomer.Enabled = False
        ElseIf optPrintExceptCustomers.Checked Then
            cboCustomer.Enabled = True
        ElseIf optPrintOnlyCustomers.Checked Then
            cboCustomer.Enabled = True
        End If
    End Sub

    Private Sub optPrintExceptCustomers_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles optPrintExceptCustomers.CheckedChanged
        If optPrintAllCustomers.Checked Then
            cboCustomer.Enabled = False
        ElseIf optPrintExceptCustomers.Checked Then
            cboCustomer.Enabled = True
        ElseIf optPrintOnlyCustomers.Checked Then
            cboCustomer.Enabled = True
        End If
    End Sub
End Class