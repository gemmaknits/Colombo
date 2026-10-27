Public Class frmHangerStockBalance
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
    Private Sub frmHangerStockBalance_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Me.StartPosition = FormStartPosition.CenterParent

        dtpDateFr.Value = CDate("01/01/1900")
        dtpDateTo.Value = Now
        Call GenCombo()
        txtDesignNo.Focus()
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


    End Sub


    Private Sub btnPrint_Click(sender As System.Object, e As System.EventArgs) Handles btnPrint.Click
        'Const rptFileName = "rptHangerStockBalance.rpt"
        Dim rptFileName = "rptStockHOnhand.rpt"
        If ChkShowDesignOutOfStock.Checked Then
            rptFileName = "rptStockHOnhandDesignOutOfStock.rpt"
        End If

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
        rpt.SetParameterValue("@design_no", txtDesignNo.Text.Trim)
        'rpt.SetParameterValue("@suffix", txtFinishing.Text.Trim)
        'rpt.SetParameterValue("@loc", cbomtlLocation.Text.Trim)
        If optPrintAll.Checked Then
            rpt.SetParameterValue("@loc_type", 0)
            rpt.SetParameterValue("@mtl_warehouse_id", 0)
            rpt.SetParameterValue("@mtl_subinventory_id", 0)
            rpt.SetParameterValue("@mtl_locations_id", 0)
            'rpt.SetParameterValue("@loc", "")
        ElseIf optPrintOnly.Checked Then
            rpt.SetParameterValue("@loc_type", 1)
            rpt.SetParameterValue("@mtl_warehouse_id", (New clsConfig).IsNull(cbomtlWarehouse.SelectedValue, 0))
            rpt.SetParameterValue("@mtl_subinventory_id", (New clsConfig).IsNull(cbomtlSubinventory.SelectedValue, 0))
            rpt.SetParameterValue("@mtl_locations_id", (New clsConfig).IsNull(cbomtlLocation.SelectedValue, 0))
            'rpt.SetParameterValue("@loc", cbomtlLocation.Text.Trim)
        ElseIf optPrintExcept.Checked Then
            rpt.SetParameterValue("@loc_type", 2)
            rpt.SetParameterValue("@mtl_warehouse_id", (New clsConfig).IsNull(cbomtlWarehouse.SelectedValue, 0))
            rpt.SetParameterValue("@mtl_subinventory_id", (New clsConfig).IsNull(cbomtlSubinventory.SelectedValue, 0))
            rpt.SetParameterValue("@mtl_locations_id", (New clsConfig).IsNull(cbomtlLocation.SelectedValue, 0))
            'rpt.SetParameterValue("@loc", cbomtlLocation.Text.Trim)
        End If
        rpt.SetParameterValue("@logempcd", clsUser.UserName)

        rpt.PrintOptions.PaperSize = CrystalDecisions.Shared.PaperSize.PaperA4
        rpt.PrintOptions.PaperOrientation = CrystalDecisions.Shared.PaperOrientation.Landscape
        rpt.PrintOptions.PaperSource = CrystalDecisions.Shared.PaperSource.Auto

        frm.Title = "Sample Stock Balance"
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

    Private Sub cbomtlWarehouse_DropDownClosed(sender As Object, e As System.EventArgs) Handles cbomtlWarehouse.DropDownClosed

    End Sub



    Private Sub cbomtlWarehouse_SelectedValueChanged(sender As Object, e As System.EventArgs) Handles cbomtlWarehouse.SelectedValueChanged
        bsMtlSubInventory.Filter = "mtl_warehouse_id = '" & (New clsConfig).IsNull(cbomtlWarehouse.SelectedValue, 0) & "' and hanger_subinventory = 'Y'"
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
            ' cbomtlWarehouse.SelectedIndex = -1
            cbomtlWarehouse.Enabled = True
            ' cbomtlSubinventory.SelectedIndex = -1
            cbomtlSubinventory.Enabled = True
            ' cbomtlLocation.SelectedIndex = -1
            cbomtlLocation.Enabled = True
        End If
    End Sub

    Private Sub optPrintExcept_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles optPrintExcept.CheckedChanged
        If optPrintExcept.Checked Then
            ' cbomtlWarehouse.SelectedIndex = -1
            cbomtlWarehouse.Enabled = True
            ' cbomtlSubinventory.SelectedIndex = -1
            cbomtlSubinventory.Enabled = True
            ' cbomtlLocation.SelectedIndex = -1
            cbomtlLocation.Enabled = True
        End If
    End Sub

    Private Sub cbomtlWarehouse_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cbomtlWarehouse.SelectedIndexChanged

    End Sub
End Class