Public Class FormRptYarnUsedByMonth
	Dim empcd As String = ""
    Dim dtMtlSubInventory As New DataTable
    Dim bsMtlSubInventory As New BindingSource
    Dim clsUser As New classUserInfo
    Public Property UserInfo() As classUserInfo
        Get
            UserInfo = clsUser
        End Get
        Set(ByVal NewValue As classUserInfo)
            clsUser = NewValue
        End Set
    End Property
    Public Property loginEmpcd() As String
		Get
			loginEmpcd = empcd
		End Get
		Set(ByVal NewValue As String)
			empcd = NewValue
		End Set
	End Property

	Private Sub ResizeCRV()
		crvYarnUsed.Top = 40
		crvYarnUsed.Left = 8
		crvYarnUsed.Height = Me.Height - 83
		crvYarnUsed.Width = Me.Width - 25
	End Sub

	Private Sub FormRptYarnUsedByMonth_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Call ResizeCRV()
        Call GenCombo()
    End Sub

    Private Sub GenCombo()
        cbomtl_warehouse.DataSource = (New classMaster).GetCombomtl_warehouse((New classUserInfo))
        cbomtl_warehouse.DisplayMember = "warehouse_code"
        cbomtl_warehouse.ValueMember = "mtl_warehouse_id"

        dtMtlSubInventory = (New classMaster).GetCombomtl_subinventory(0)
        bsMtlSubInventory.DataSource = dtMtlSubInventory
        cbomtl_subinventory.DataSource = bsMtlSubInventory.DataSource
        cbomtl_subinventory.DisplayMember = "subinventory_code"
        cbomtl_subinventory.ValueMember = "mtl_subinventory_id"
    End Sub

	Private Sub FormRptYarnUsedByMonth_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize
        'Call ResizeCRV()
	End Sub

	Private Sub btnPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrint.Click
        'Dim config As New clsConfig
        '      Dim classCn As New classConnection
        '      Dim SortBy As String
        '      config.ChangeCulture()

        'btnPrint.Enabled = False
        'Me.Cursor = Cursors.WaitCursor
        '      Dim rpt As New rptYarnUsedByMonth

        '      SortBy = "CODE"
        '      If optSortByItemDesc.Checked = True Then
        '          SortBy = "DESC"
        '      End If

        'rpt.DataSourceConnections.Item(0).SetConnection(classCn.servername, classCn.database, False)
        'rpt.DataSourceConnections.Item(0).SetLogon(classCn.Userid, classCn.Password)

        '      rpt.VerifyDatabase()
        '      rpt.SetParameterValue(0, dtpPrint.Value.ToString("yyyyMMdd"))
        '      rpt.SetParameterValue("@SortBy", SortBy)

        'crvYarnUsed.ReportSource = rpt
        'crvYarnUsed.Zoom(75)
        'crvYarnUsed.Show()
        'Me.Cursor = Cursors.Default
        'btnPrint.Enabled = True

        Dim clsConn As New classConnection
        Dim clsConfig As New clsConfig
        Dim strDesignNo As String = ""
        Dim rptFileName As String = "rptYarnUsedByMonth.rpt"
        If Not clsConfig.CheckReport(clsuser.reportpath, rptFileName) Then Exit Sub
        Dim frm As New frmReport
        Dim rpt As New CrystalDecisions.CrystalReports.Engine.ReportDocument
        Me.Cursor = Cursors.WaitCursor

        Dim SortBy As String
        clsConfig.ChangeCulture()
        SortBy = "CODE"
        If optSortByItemDesc.Checked = True Then
            SortBy = "DESC"
        End If

        rpt.Load(clsuser.reportpath & rptFileName)
        rpt.DataSourceConnections.Item(0).SetConnection(clsConn.servername, clsConn.Database, False)
        rpt.DataSourceConnections.Item(0).SetLogon(clsConn.UserName, clsConn.Password)
        rpt.VerifyDatabase()
        rpt.SetParameterValue(0, dtpPrint.Value.ToString("yyyyMMdd"))
        rpt.SetParameterValue("@SortBy", SortBy)
        'rpt.SetParameterValue("@mtl_subinventory_id", cbomtl_subinventory.SelectedValue)

        'rpt.PrintOptions.PaperSize = CrystalDecisions.Shared.PaperSize.PaperA4
        'rpt.PrintOptions.PaperOrientation = CrystalDecisions.Shared.PaperOrientation.Portrait
        'rpt.PrintOptions.PaperSource = CrystalDecisions.Shared.PaperSource.Auto
        ' crvYarnUsed.ReportSource = rpt

        frm.Title = "Yarn Usage Summary"
        frm.CRViewer.ReportSource = rpt
        frm.MdiParent = Me.ParentForm
        frm.Show()
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub cbomtl_warehouse_DropDownClosed(sender As Object, e As EventArgs) Handles cbomtl_warehouse.DropDownClosed
        bsMtlSubInventory.Filter = "mtl_warehouse_id = '" & (New clsConfig).IsNull(cbomtl_warehouse.SelectedValue, 0) & "'"
    End Sub

    Private Sub cbomtl_warehouse_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbomtl_warehouse.SelectedIndexChanged

    End Sub
End Class