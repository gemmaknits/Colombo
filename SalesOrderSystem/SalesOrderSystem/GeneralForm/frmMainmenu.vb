Imports System.Globalization
Imports System.Threading
Imports System
Imports System.Text
Imports System.Data.Sqlclient

Public Class frmMainmenu
	Public loginEmpcd As String
    Dim clsUser As New classUserInfo
    Dim classUserNew As New Classes.classUserInfo
    Dim _ShortName As String
    Public Property UserInfo() As classUserInfo
        Get
            UserInfo = clsUser
        End Get
        Set(ByVal NewValue As classUserInfo)
            clsUser = NewValue
        End Set
    End Property

    Public Property UserInfoNew() As Classes.classUserInfo
        Get
            UserInfoNew = classUserNew
        End Get
        Set(ByVal NewValue As Classes.classUserInfo)
            classUserNew = NewValue
        End Set
    End Property
    Public Property pShortName As String
        Get
            pShortName = _ShortName
        End Get
        Set(ByVal Newvalue As String)
            _ShortName = Newvalue
        End Set
    End Property
    Private Sub TakeLogOut()
        Dim conn As New SqlConnection((New classConnection).connection)
        conn.Open()
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "p_takelogout"
        comm.Parameters.AddWithValue("@log_id", clsUser.LogID)
        comm.ExecuteNonQuery()
    End Sub

    Private Sub formMainmenu_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        lblConnection.Text = "Server : " + New ClassConnection().servername '+ " | " + "Database:" + New classConnection().database
        lblDataBase.Text = "DataBase : " & pShortName 'New classConnection().database

        STV.ClassConnection.servername = ClassConnection.servername 'Add By Neung 20260206
        STV.ClassConnection.database = ClassConnection.database 'Add By Neung 20260206
        ProductionSystem.classConnection.servername = ClassConnection.servername 'Add By Neung 20260217
        ProductionSystem.classConnection.database = ClassConnection.database 'Add By Neung 20260217

        'Neung 12/06/2026 fix bug 
        Dim culture As New CultureInfo("en-GB")

        Thread.CurrentThread.CurrentCulture = culture
        Thread.CurrentThread.CurrentUICulture = culture
        CultureInfo.DefaultThreadCurrentCulture = culture
        CultureInfo.DefaultThreadCurrentUICulture = culture

        My.Application.ChangeCulture("en-GB")
        My.Application.ChangeUICulture("en-GB")

        'Dim culture As CultureInfo
        'culture = CultureInfo.CurrentCulture
        'If UCase(culture.DisplayName) <> "ENGLISH (UNITED KINGDOM)" Then
        '    'MsgBox("Select change your regional settings to English United Kingdom")
        '    'Me.Close()
        '    My.Application.ChangeCulture("en-GB")
        '    My.Application.ChangeUICulture("en-GB")
        'End If

        If Not System.Diagnostics.Debugger.IsAttached Then
            Me.Text = Me.Text & " Version " & My.Application.Deployment.CurrentVersion.ToString
            'Else
            '    If Not System.IO.File.Exists(clsUser.ReportPath) And Not System.IO.File.Exists(clsUser.ReportPath) Then
            '        clsUser.ReportPath = "C:\Users\DELL\Desktop\"
            '    End If
        End If
        Me.ContextMenu = TrayMenu
        TrayIcon.Icon = Me.Icon
        TrayIcon.Visible = False
        TrayIcon.ContextMenu = TrayMenu
        TrayIcon.Text = "Sales Order System"

        txtExchangeRate.Text = FormatNumber(clsUser.ExchangeRate, 4)
        'If clsUser.CanChat Then
        '	Dim frmChatRoom As New frmChatRoom
        '	frmChatRoom.MdiParent = Me
        '	frmChatRoom.UserInfo = clsUser
        '	frmChatRoom.TrayIcon = TrayIcon
        '	If frmChatRoom.StartChatRoom() Then
        '		frmChatRoom.WindowState = FormWindowState.Minimized
        '		frmChatRoom.Show()
        '	End If
        '      End If
        checkMenuAccess()
        If ClassConnection.database = "ColomboDB" Or ClassConnection.database = "ColomboDBTest" Then

        End If
    End Sub
    Private Sub frmMainmenu_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Me.Tag = "CLOSE"
        Dim obj As Form
        For Each obj In Me.MdiChildren
            obj.Close()
        Next
        Call TakeLogOut()
        TrayIcon.Dispose()
        'End
    End Sub

    Private Sub CustomerToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menuMasterCustomer.Click
        '        If Not (clsUser.DeptCD = "MKT" Or clsUser.DeptCD = "ITC" Or clsUser.DeptCD = "ACC") Then Exit Sub
        'Dim frm As New frmCustomer
        Dim frm As New frmCustomerNew
        frm.UserInfo = clsUser
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub CustomerItemsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CustomerItemsToolStripMenuItem.Click
        Dim frm As New STV.frmCustomerItems

        'frm.UserInfo = clsUser
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub AgencyToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menuMasterAgency.Click
        '        If Not (clsUser.DeptCD = "MKT" Or clsUser.DeptCD = "ITC" Or clsUser.DeptCD = "ACC") Then Exit Sub
        Dim frm As New frmAgent
        frm.UserInfo = clsUser
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub SupplierToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menuMasterSuppliers.Click
        '        If Not (clsUser.DeptCD = "MKT" Or clsUser.DeptCD = "ITC" Or clsUser.DeptCD = "ACC") Then Exit Sub
        Dim frm As New frmSupplier
        frm.UserInfo = clsUser
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub ColorToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menuMasterColor.Click
        '        If Not (clsUser.DeptCD = "MKT" Or clsUser.DeptCD = "ITC" Or clsUser.DeptCD = "ACC") Then Exit Sub
        Dim frm As New frmColor
        frm.UserInfo = clsUser
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub DesignToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menuMasterDesign.Click

    End Sub

    Private Sub DesignSpecToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menuMasterDesignSpec.Click
        MessageBox.Show("This menu is underconstruction.", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Exit Sub
        'Dim frm As New frmDesignSpec
        'frm.UserInfo = clsUser
        'frm.MdiParent = Me
        'frm.Show()
    End Sub

    Private Sub MouldToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles menuMasterMould.Click
        Dim frm As New frmMould
        frm.UserInfo = clsUser
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub CompositionGroupToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles MenuMasterCompositionGroup.Click
        Dim frm As New frmCompositionGroup
        frm.UserInfo = clsUser
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub EditSalesOrderStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menuSalesOrder_Edit.Click
        'If Not (clsUser.DeptCD = "MKT" Or clsUser.DeptCD = "ITC" Or clsUser.DeptCD = "ACC") Then Exit Sub
        Dim frm As New frmSalesOrder
        frm.UserInfo = clsUser
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub PrintSalesOrderToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menuSalesOrder_Print.Click
        Dim frm As New frmSalesOrderPrint
        frm.UserInfo = clsUser
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub menuSalesOrder_Close_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menuSalesOrder_Close.Click
        Dim frm As New frmSalesOrderClose
        frm.UserInfo = clsUser
        frm.MdiParent = Me
        frm.Show()
    End Sub
    Private Sub mnuCloseSalesOrderByPO_Click(sender As Object, e As EventArgs) Handles mnuCloseSalesOrderByPO.Click
        Dim frm As New STV.frmSOClosing
        Cursor = Cursors.WaitCursor
        'frm = New STV.frmSOClosing()
        ' frm.setConnectionString((New classConnection).getSQLConnectionPOC) 'STV project
        frm.pUserID = clsUser.UserID
        frm.MdiParent = Me
        frm.Show()
        Cursor = Cursors.Default
    End Sub
    Private Sub menuSTOrder_Click(sender As Object, e As EventArgs) Handles menuSTOrder_Close.Click
        Dim frm As New frmSTOrderClosing
        Cursor = Cursors.WaitCursor
        Dim conn As New SqlConnection((New classConnection).connection)
        frm.UserInfo = clsUser
        frm.setConnectionString(conn)
        frm.MdiParent = Me
        frm.Show()
        Cursor = Cursors.Default
    End Sub
    Private Sub SOInvControlSheetToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menuSalesOrder_Other_SOInvControl.Click
        Dim frm As New frmSalesOrderInvoice
        frm.UserInfo = clsUser
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub SOByMonthToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menuSalesOrder_Other_SOMonthly.Click
        Dim frm As New frmSalesOrderByMonth
        frm.UserInfo = clsUser
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub OrderDeliveryToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menuSalesOrder_Other_SODelivery.Click
        Dim frm As New frmSalesOrderDelivery
        frm.UserInfo = clsUser
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub SODeliveryPlanToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles menuSalesOrder_Other_SODeliveryPlan.Click
        Dim frm As New frmSalesOrderDeliveryPlan
        frm.UserInfo = clsUser
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub SOStatusToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menuSalesOrder_Other_SOStatusCustomer.Click
        Dim frm As New frmSalesOrderStatusByCustomer
        frm.UserInfo = clsUser
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub SOStatusByAgencyToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menuSalesOrder_Other_SOStatusAgent.Click
        Dim frm As New frmSalesOrderStatusByAgency
        frm.UserInfo = clsUser
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub NormalDyingOrderToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim frm As New frmDyingOrder
        frm.UserInfo = clsUser
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub PrintDyingOrderToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menuDforder_Print.Click
        Dim frm As New frmDyingOrderPrint
        frm.UserInfo = clsUser
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub ChangeDFSOToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menuDfOrder_ChangeDFSO.Click
        Dim frm As New frmDyingOrderChange
        frm.UserInfo = clsUser
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub DFBulkApproveToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menuDforder_BulkApprove.Click
        Dim frm As New formDFApvSheet
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub CloseDyingOrderToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menuDforder_Close.Click
        Dim frm As New frmDyingOrderClose
        frm.UserInfo = clsUser
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub ScrapReturnToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menuDforder_ScrapReturn.Click
        Dim frm As New frmStockSIN
        frm.UserInfo = clsUser
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub DyingOrderSummaryToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menuDforder_OthersSummary.Click
        Dim frm As New frmDyingOrderSummary
        frm.UserInfo = clsUser
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub WeightCToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menuDforder_Others_WeightControl.Click
        Dim frm As New frmDyingOrderWeight
        frm.UserInfo = clsUser
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub DFWeightControl2ToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles menuDforder_Others_WeightControl2.Click
        Dim frm As New frmDyingOrderWeight2
        frm.UserInfo = clsUser
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub DFOrderPendingToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menuDforder_Others_Pending.Click
        Dim frm As New frmDyingOrderPending
        frm.UserInfo = clsUser
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub DFOrderPending2ToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles menuDforder_Others_Pending2.Click
        Dim frm As New frmDyingOrderPending2
        frm.UserInfo = clsUser
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub DFOrderSearchDesignNoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menuDforder_Others_SearchDesignNo.Click
        Dim frm As New frmDyingOrderSearchDesign
        frm.UserInfo = clsUser
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub CheckKOYarnToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menuDforder_Others_CheckKOYarn.Click
        Dim frm As New frmKOYarn
        frm.UserInfo = clsUser
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub DFOrderCLosingToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles menuDforder_Others_DFOrderCLosing.Click
        Dim frm As New frmDyingOrderClosing
        frm.UserInfo = clsUser
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub DFOrderEvaluationToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles menuDforder_Others_DFOrderEvaluation.Click
        Dim frm As New frmDyingOrderEvaluation
        frm.UserInfo = clsUser
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub DFOrderInvoiceControlToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles menuDforder_Others_DFOrderInvoiceControl.Click
        Dim frm As New frmDyingOrderInvoiceControl
        frm.UserInfo = clsUser
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub StockSampleAgingToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles menuDforder_Others_StockSampleAging.Click
        Dim frm As New frmStockSampleAging
        frm.UserInfo = clsUser
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub EditLABToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menuLab_Edit.Click
        Dim frm As New frmLab
        frm.UserInfo = clsUser
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub PrintLabToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menuLab_Print.Click
        Dim frm As New frmLabPrint
        frm.UserInfo = clsUser
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub LabPendingToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menuLab_Others_Pending.Click
        Dim frm As New frmLabPending
        frm.UserInfo = clsUser
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub StockGToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menuRequest_Greige.Click
        Dim frm As New frmRequestG
        frm.UserInfo = clsUser
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub StockDToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menuRequest_Dyed.Click
        Dim frm As New frmRequestD
        frm.UserInfo = clsUser
        frm.pStockType = "D"
        frm.pRequestSampleStock = "N" 'For use Stock Dyed or Stock Sample 
        'If ClassConnection.database = "ColomboDB" Or ClassConnection.database = "ColomboDBTest" Then
        '    frm.pSubinventoryCode = "STKD" 'For Sub Inventory
        'ElseIf ClassConnection.database = "Gemmasoft" Or ClassConnection.database = "GemmasoftTest" Then
        '    frm.pSubinventoryCode = "ESH_DYED"
        'End If
        frm.Text = "Request Dyed"
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub StockCToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim frm As New frmRequestC
        frm.UserInfo = clsUser
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub StockSToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menuRequest_Sample.Click
        Dim frm As New frmRequestD
        frm.UserInfo = clsUser
        frm.pRequestSampleStock = "Y" 'For use Stock Dyed or Stock Sample
        frm.pStockType = "S"
        'frm.pSubinventoryCode = "N" 'For use Stock Dyed or Stock Sample
        frm.Text = "Request Sample"
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub PrintLocalInvoiceToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menuInvoice_Local_Print.Click
        '        If Not (clsUser.DeptCD = "MKT" Or clsUser.DeptCD = "ITC" Or clsUser.DeptCD = "ACC") Then Exit Sub
        Dim frm As New frmInvoiceLocalPrint
        frm.UserInfo = clsUser
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub PrintLocalInvoiceControlToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menuInvoice_Local_PrintControl.Click
        '        If Not (clsUser.DeptCD = "MKT" Or clsUser.DeptCD = "ITC" Or clsUser.DeptCD = "ACC") Then Exit Sub
        Dim frm As New frmInvoiceLocalControl
        frm.UserInfo = clsUser
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub PrintLocalInvoiceTaxToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menuInvoice_Local_OutputTax.Click
        '        If Not (clsUser.DeptCD = "MKT" Or clsUser.DeptCD = "ITC" Or clsUser.DeptCD = "ACC") Then Exit Sub
        Dim frm As New frmInvoiceLocalTax
        frm.UserInfo = clsUser
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub PrintExportInvoiceToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menuInvoice_Export_Print.Click
        '        If Not (clsUser.DeptCD = "MKT" Or clsUser.DeptCD = "ITC" Or clsUser.DeptCD = "ACC") Then Exit Sub
        Dim frm As New frmInvoiceExportPrint
        frm.UserInfo = clsUser
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub PrintExportInvoiceControlToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menuInvoice_Export_PrintControl.Click
        '        If Not (clsUser.DeptCD = "MKT" Or clsUser.DeptCD = "ITC" Or clsUser.DeptCD = "ACC") Then Exit Sub
        Dim frm As New frmInvoiceExportControl
        frm.UserInfo = clsUser
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub PrintExportInvoiceControl2ToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles menuInvoice_Export_PrintControl2.Click
        Dim frm As New frmInvoiceExportControl2
        frm.UserInfo = clsUser
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub InvoiceYearSummaryToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles InvoiceYearSummaryToolStripMenuItem.Click
        Dim frm As New frmInvoiceSummaryYear
        frm.UserInfo = clsUser
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub StockOnhandToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menuStock_Onhand.Click
        Dim frm As New frmStockOnhand
        frm.UserInfo = clsUser
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub GreigeOnhandMovementStatusToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles GreigeOnhandMovementStatusToolStripMenuItem.Click
        Dim frm As New frmStockGOnhandMovementStatus
        frm.UserInfo = clsUser
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub GreigeOnhandForCheckOldGoodsToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles menuStockGreigeOnhandForCheckOldGoods.Click
        Dim frm As New frmStockGOnhand2
        frm.UserInfo = Me.UserInfo
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub GreigeOnhandSummaryToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles GreigeOnhandSummaryToolStripMenuItem.Click
        Const rptFileName = "rptGreigeSummary.rpt"
        If clsUser.ReportPath = "" Then clsUser.ReportPath = clsUser.ReportPath
        If Not (New clsConfig).CheckReport(clsUser.ReportPath, rptFileName) Then Exit Sub
        Dim clsConn As New ClassConnection
        Dim frm As New frmReport
        Dim rpt As New CrystalDecisions.CrystalReports.Engine.ReportDocument
        Me.Cursor = Cursors.WaitCursor
        rpt.Load(clsUser.ReportPath & rptFileName)
        rpt.DataSourceConnections.Item(0).SetConnection(clsConn.servername, clsConn.database, False)
        rpt.DataSourceConnections.Item(0).SetLogon(clsConn.Userid, clsConn.Password)
        rpt.VerifyDatabase()

        rpt.PrintOptions.PaperSize = CrystalDecisions.Shared.PaperSize.PaperA4
        rpt.PrintOptions.PaperOrientation = CrystalDecisions.Shared.PaperOrientation.Portrait
        rpt.PrintOptions.PaperSource = CrystalDecisions.Shared.PaperSource.Auto

        frm.Title = "Greige Summary Report"
        frm.CRViewer.ReportSource = rpt
        frm.CRViewer.Zoom(1)
        frm.MdiParent = Me
        frm.Show()
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub GreigeOnhandToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menuStock_GreigeOnHand.Click
        Dim frm As New frmStockGOnhand
        frm.UserInfo = clsUser
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub GreigeOnhandByLocationToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles GreigeOnhandByLocationToolStripMenuItem.Click
        Dim frm As New frmStockGOnhandLocation
        frm.UserInfo = clsUser
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub GreigeOnhandAgingToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles GreigeOnhandAgingToolStripMenuItem.Click
        Dim frm As New frmGreigeOnhandAging
        frm.UserInfo = clsUser
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub CuttedOnhandToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menuStock_CutOnHand.Click
        Dim frm As New frmStockCOnhand
        frm.UserInfo = clsUser
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub GreigeTransferLocationToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'Dim frm As New frmGreigeTransfer
        'frm.MdiParent = Me
        'frm.UserInfo = Me.UserInfo
        'frm.Show()
    End Sub

    Private Sub GreigeOutFromDFToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles menuStock_GreigeOutFromDF.Click
        Dim frm As New frmGreigeOut
        frm.MdiParent = Me
        frm.UserInfo = Me.UserInfo
        frm.Show()
    End Sub

    Private Sub GreigeOutFromRequestToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GreigeOutFromRequestToolStripMenuItem.Click
        Dim frm As New frmGreigeOutFromRequest
        frm.MdiParent = Me
        frm.UserInfo = Me.UserInfo
        frm.Show()
    End Sub

    Private Sub GreigeOutChangeDesignToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles GreigeOutChangeDesignToolStripMenuItem.Click
        'MessageBox.Show("K.Suresh Block This Program (This program doesn't make sense)", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
        Dim frm As New frmGreigeOutChangeDesign
        frm.MdiParent = Me
        frm.UserInfo = Me.UserInfo
        frm.Show()
    End Sub

    Private Sub GreigeINReturnToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs)
        Dim frm As New frmGreigeINReturn
        frm.MdiParent = Me
        frm.UserInfo = Me.UserInfo
        frm.Show()
    End Sub

    Private Sub GreigeINByDateToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles GreigeINByDateToolStripMenuItem.Click
        Dim frm As New frmGreigeIN
        frm.MdiParent = Me
        frm.UserInfo = Me.UserInfo
        frm.Show()
    End Sub

    Private Sub DINToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DINToolStripMenuItem.Click
        Dim frm As New frmDyedIN
        frm.MdiParent = Me
        frm.UserInfo = Me.UserInfo
        frm.Show()
    End Sub

    Private Sub PendingCuttingToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles menuStock_PendingCut.Click
        Dim frm As New frmStockDPendingCutting
        frm.UserInfo = clsUser
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub StockOutForSampleToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles menuStock_OutSample.Click
        Dim frm As New frmStockOutSample
        frm.UserInfo = clsUser
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub GINNoDFToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles menuStock_GinNoDf.Click
        MessageBox.Show("This menu is not available now.", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
    End Sub

    Private Sub StockMovementToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles menuStock_StockMove.Click
        Dim frm As New frmStockMovement
        frm.UserInfo = clsUser
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub GreigeRollNoNotFoundToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles menuStock_RollGNotFound.Click
        Dim frm As New frmSearchRollNoG
        frm.UserInfo = clsUser
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub DyedRollNoNotFoundToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles menuStock_RollDNotFound.Click
        Dim frm As New frmSearchRollNoD
        frm.UserInfo = clsUser
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub GreigeOverloadToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles menuStock_GreigeOverLoad.Click
        Const rptFileName = "rptGreigeOverload.rpt"
        If clsUser.ReportPath = "" Then clsUser.ReportPath = clsUser.ReportPath
        If Not (New clsConfig).CheckReport(clsUser.ReportPath, rptFileName) Then Exit Sub
        Dim clsConn As New ClassConnection
        Dim frm As New frmReport
        Dim rpt As New CrystalDecisions.CrystalReports.Engine.ReportDocument
        Me.Cursor = Cursors.WaitCursor
        rpt.Load(clsUser.ReportPath & rptFileName)
        rpt.DataSourceConnections.Item(0).SetConnection(clsConn.servername, clsConn.database, False)
        rpt.DataSourceConnections.Item(0).SetLogon(clsConn.Userid, clsConn.Password)
        rpt.VerifyDatabase()

        rpt.PrintOptions.PaperSize = CrystalDecisions.Shared.PaperSize.PaperA4
        rpt.PrintOptions.PaperOrientation = CrystalDecisions.Shared.PaperOrientation.Landscape
        rpt.PrintOptions.PaperSource = CrystalDecisions.Shared.PaperSource.Auto

        frm.Title = "Greige Overload Report"
        frm.CRViewer.ReportSource = rpt
        frm.CRViewer.Zoom(1)
        frm.MdiParent = Me
        frm.Show()
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub StockCancelledToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles StockCancelledToolStripMenuItem.Click
        Dim frm As New frmStockCancelled
        frm.MdiParent = Me
        frm.UserInfo = Me.UserInfo
        frm.Show()
    End Sub

    Private Sub GreigeSummaryByDateToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles GreigeSummaryByDateToolStripMenuItem.Click
        Dim frm As New frmGreigeSummaryByDate
        frm.MdiParent = Me
        frm.UserInfo = Me.UserInfo
        frm.Show()
    End Sub

    Private Sub GreigeSummaryByMachineToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles GreigeSummaryByMachineToolStripMenuItem.Click
        Dim frm As New frmGreigeSummaryByMachine
        frm.MdiParent = Me
        frm.UserInfo = Me.UserInfo
        frm.Show()
    End Sub

    Private Sub GreigeINGradeToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles GreigeINGradeToolStripMenuItem.Click
        Dim frm As New frmGINGrade
        frm.MdiParent = Me
        frm.UserInfo = Me.UserInfo
        frm.Show()
    End Sub

    Private Sub SampleStockBalanceToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles SampleStockBalanceToolStripMenuItem.Click
        Dim frm As New frmSampleStockBalance
        frm.MdiParent = Me
        frm.UserInfo = Me.UserInfo
        frm.Show()
    End Sub
    Private Sub HangerStockBalanceToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HangerStockBalanceToolStripMenuItem.Click
        Dim frm As New frmHangerStockBalance
        frm.MdiParent = Me
        frm.UserInfo = Me.UserInfo
        frm.Show()
    End Sub
    Private Sub GreigeINLossToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles GreigeINLossToolStripMenuItem.Click
        Dim frm As New frmGINLoss
        frm.MdiParent = Me
        frm.UserInfo = Me.UserInfo
        frm.Show()
    End Sub

    Private Sub DyedINByMonthToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DyedINByMonthToolStripMenuItem.Click
        Dim frm As New frmDyedINByMonth
        frm.MdiParent = Me
        frm.UserInfo = Me.UserInfo
        frm.Show()
    End Sub

    Private Sub GreigePDFOnhandToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GreigePDFOnhandToolStripMenuItem.Click
        Dim frm As New frmGreigePDFOnhand
        frm.MdiParent = Me
        frm.UserInfo = Me.UserInfo
        frm.Show()
    End Sub

    Private Sub GreigeBarcodeToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles GreigeBarcodeToolStripMenuItem.Click
        Dim frm As New frmGreigeBarcode
        frm.MdiParent = Me
        frm.UserInfo = Me.UserInfo
        frm.Show()
    End Sub

    Private Sub StockDBarcodeToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles StockDBarcodeToolStripMenuItem.Click
        Dim frm As New frmStockDBarcode
        frm.MdiParent = Me
        frm.UserInfo = Me.UserInfo
        frm.Show()
    End Sub

    Private Sub PrintPOControlToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menuPurchase_POControl.Click
        Dim frm As New frmPOControl
        frm.UserInfo = clsUser
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub KOSchedulePlanToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles menuProduction_KOSchedulePlan.Click
        Dim frm As New frmKOSchedulePlan
        frm.UserInfo = clsUser
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub MachineCapacityToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles menuProduction_MachineCapacity.Click
        Dim frm As New frmMachineCapacity
        frm.UserInfo = clsUser
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub YarnDemandForecastToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim frm As New frmYarnDemandForecast
        frm.UserInfo = clsUser
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub YarnDemandForecastSummaryToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs)
        Dim frm As New frmYarnDemandForecastSummary
        frm.UserInfo = clsUser
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub YarnDemandPlanningToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs)
        Dim frm As New frmYarnDemandMachine
        frm.UserInfo = clsUser
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub SONotHaveKOToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles SONotHaveKOToolStripMenuItem.Click
        Dim frm As New frmSONotHaveKO
        frm.UserInfo = clsUser
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub MachineProductivityToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles MachineProductivityToolStripMenuItem.Click
        'Dim frm As New frmMachineProductivity
        Dim frm As New frmMachineProductivity2Month
        frm.UserInfo = clsUser
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub MachineProductivity2ToolStripMenuItem_Click(sender As Object, e As EventArgs)
        'Dim frm As New frmMachineProductivity2
        'frm.UserInfo = clsUser
        'frm.MdiParent = Me
        'frm.Show()
    End Sub

    Private Sub GreigeDailyProductionToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles GreigeDailyProductionToolStripMenuItem.Click
        Dim frm As New frmGreigeDailyProduction
        frm.UserInfo = clsUser
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub GreigeMonthlyProductionToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles GreigeMonthlyProductionToolStripMenuItem.Click
        Dim frm As New frmGreigeMonthlyProduction
        frm.UserInfo = clsUser
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub KOClosedReportToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles KOClosedReportToolStripMenuItem.Click
        Dim frm As New frmKOClosed
        frm.UserInfo = clsUser
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub KODesignHistoryToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles KODesignHistoryToolStripMenuItem.Click
        Dim frm As New frmKODesignHistory
        frm.UserInfo = clsUser
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub KILossByMachineToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles KILossByMachineToolStripMenuItem.Click
        Dim frm As New frmKILossByMachine
        frm.UserInfo = clsUser
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub DesignNoBOMToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles DesignNoBOMToolStripMenuItem.Click
        Dim frm As New frmDesignNoBOM
        frm.UserInfo = clsUser
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub KOOutsourceToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles KOOutsourceToolStripMenuItem.Click
        Dim frm As New frmKOOutsource
        frm.UserInfo = clsUser
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub YarnTestFormToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles YarnTestFormToolStripMenuItem.Click
        Dim frm As New frmYarnTestForm
        frm.UserInfo = clsUser
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub KOSchedulePlanDetailsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles KOSchedulePlanDetailsToolStripMenuItem.Click
        Dim frm As New frmKOSchedulePlanDet
        frm.UserInfo = clsUser
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub tsmnGammaCMR_Click(sender As Object, e As EventArgs) Handles tsmnGammaCMR.Click
        Dim ObjfrmRequestGMColorMatch As New frmRequestGMColorMatch
        ObjfrmRequestGMColorMatch.UserInfo = clsUser
        ObjfrmRequestGMColorMatch.MdiParent = Me
        ObjfrmRequestGMColorMatch.Show()
    End Sub
    Private Sub GemmaKnitsCMRControlToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles GemmaKnitsCMRControlToolStripMenuItem.Click
        Dim frm As New frmGemmaKnitsCMRControl
        frm.UserInfo = clsUser
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub DFSubmitAtGammaDyedHouseToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles DFSubmitAtGammaDyedHouseToolStripMenuItem.Click
        Dim frm As New frmGammaDFControl
        frm.UserInfo = clsUser
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub GemmaKnitsSOControlWithGammaToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles GemmaKnitsSOControlWithGammaToolStripMenuItem.Click
        Dim frm As New frmGemmaKnitsSOControl
        frm.UserInfo = clsUser
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub ManagementSummaryReportToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ManagementSummaryReportToolStripMenuItem.Click
        Dim frm As New frmManagementSummaryReport
        frm.UserInfo = clsUser
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub CascadeToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CascadeToolStripMenuItem1.Click
        Me.LayoutMdi(MdiLayout.Cascade)
    End Sub

    Private Sub TileHorizontalToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TileHorizontalToolStripMenuItem.Click
        Me.LayoutMdi(MdiLayout.TileHorizontal)
    End Sub

    Private Sub TileVerticalToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TileVerticalToolStripMenuItem.Click
        Me.LayoutMdi(MdiLayout.TileVertical)
    End Sub

    Private Sub ChangePasswordToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChangePasswordToolStripMenuItem.Click
        Dim frm As New frmChangePassword
        frm.UserInfo = clsUser
        frm.ShowDialog()
        clsUser.Password = frm.Password
        frm.Close()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Tag = "CLOSE"
        Me.Close()
        End
    End Sub

    Private Sub ExchangeRateUSTHBToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExchangeRateUSTHBToolStripMenuItem.Click
        'Dim process As System.Diagnostics.Process = System.Diagnostics.Process.Start("iexplore")
        Dim browser As New SHDocVw.InternetExplorer
        browser.Visible = True
        browser.Navigate(classMaster.WWW_BOT)
    End Sub

    Private Sub frmMainmenu_SizeChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.SizeChanged
        If Me.WindowState = FormWindowState.Minimized Then
            Me.Hide()
            Me.Tag = "HIDE"
            TrayIcon.Visible = True
            TrayIcon.BalloonTipIcon = ToolTipIcon.Info
            TrayIcon.BalloonTipTitle = "System Message"
            TrayIcon.BalloonTipText = "Sales Order System อยู่ที่นี่"
            TrayIcon.ShowBalloonTip(3)
        End If
    End Sub

    Private Sub mnuRestore_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuRestore.Click
        Me.Tag = ""
        Me.Show()
        Me.WindowState = FormWindowState.Maximized
        TrayIcon.Visible = False
    End Sub

    Private Sub mnuExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuExit.Click
        Me.Tag = "CLOSE"
        Me.Close()
        End
    End Sub

    Private Sub TrayIcon_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles TrayIcon.MouseClick
        Me.Tag = ""
        Me.Show()
        Me.WindowState = FormWindowState.Maximized
        TrayIcon.Visible = False
    End Sub

    Private Sub checkMenuAccess()
        'Dim objSecurity As New classSecurity
        Dim objSecurity As New clsConfig
        'objSecurity.LoadMenus(UserInfo.UserID)
        '---------------------------------------------- Menu Master -----------------------------
        Me.menuMasterCustomer.Enabled = objSecurity.UserAccess(UserInfo.UserID, "SO0001", "MENU")
        Me.menuMasterAgency.Enabled = objSecurity.UserAccess(UserInfo.UserID, "SO0005", "MENU")
        Me.menuMasterSuppliers.Enabled = objSecurity.UserAccess(UserInfo.UserID, "SO0010", "MENU")
        Me.menuMasterColor.Enabled = objSecurity.UserAccess(UserInfo.UserID, "SO0015", "MENU")
        Me.menuMasterDesign.Enabled = objSecurity.UserAccess(UserInfo.UserID, "SO0019", "MENU") '
        Me.menuMasterDesignEdit.Enabled = objSecurity.UserAccess(UserInfo.UserID, "SO0020", "MENU")
        'Me.menuMasterDesignView.Enabled = objSecurity.UserAccess(UserInfo.UserID, "SO0021", "MENU")
        Me.menuMasterDesignSpec.Enabled = objSecurity.UserAccess(UserInfo.UserID, "SO0025", "MENU")
        Me.menuMasterDesignReport.Enabled = objSecurity.UserAccess(UserInfo.UserID, "SO0022", "MENU") '

        Me.menuMasterMould.Enabled = objSecurity.UserAccess(UserInfo.UserID, "SO0026", "MENU") '
        Me.MenuMasterCompositionGroup.Enabled = objSecurity.UserAccess(UserInfo.UserID, "SO0027", "MENU")

        '---------------------------------------------- Menu Sale Order -------------------------------------
        Me.menuSalesOrder_Edit.Enabled = objSecurity.UserAccess(UserInfo.UserID, "SO0030", "MENU")
        Me.menuSalesOrder_Print.Enabled = objSecurity.UserAccess(UserInfo.UserID, "SO0035", "MENU")
        Me.menuSalesOrder_Close.Enabled = objSecurity.UserAccess(UserInfo.UserID, "SO0036", "MENU")
        Me.mnuCloseSalesOrderByPO.Enabled = objSecurity.UserAccess(UserInfo.UserID, "SO0036", "MENU") 'Sitthana 21/08/2018
        Me.menuSTOrder_Close.Enabled = objSecurity.UserAccess(UserInfo.UserID, "SO0036", "MENU") 'Sitthana 21/08/2018

        '---------------------------------------------- Menu Sale Order Other Report-------------------------
        Me.menuSalesOrder_Other.Enabled = objSecurity.UserAccess(UserInfo.UserID, "SO0039", "MENU")
        Me.menuSalesOrder_Other_SOInvControl.Enabled = objSecurity.UserAccess(UserInfo.UserID, "SO0040", "MENU")
        Me.menuSalesOrder_Other_SOMonthly.Enabled = objSecurity.UserAccess(UserInfo.UserID, "SO0045", "MENU")
        Me.menuSalesOrder_Other_SODelivery.Enabled = objSecurity.UserAccess(UserInfo.UserID, "SO0050", "MENU") '
        Me.menuSalesOrder_Other_SODeliveryPlan.Enabled = objSecurity.UserAccess(UserInfo.UserID, "SO0051", "MENU")
        Me.menuSalesOrder_Other_SOStatusCustomer.Enabled = objSecurity.UserAccess(UserInfo.UserID, "SO0055", "MENU")
        Me.menuSalesOrder_Other_SOStatusAgent.Enabled = objSecurity.UserAccess(UserInfo.UserID, "SO0060", "MENU")
        Me.menuSalesOrder_Other_SOStatusEmployee.Enabled = objSecurity.UserAccess(UserInfo.UserID, "SO0063", "MENU")
        Me.menuSalesOrder_Other_SOSummary.Enabled = objSecurity.UserAccess(UserInfo.UserID, "SO0061", "MENU")
        Me.menuSalesOrder_Other_SOTraceReport.Enabled = objSecurity.UserAccess(UserInfo.UserID, "SO0064", "MENU")
        Me.menuSalesOrder_Other_SalesPerformance.Enabled = objSecurity.UserAccess(UserInfo.UserID, "SO0066", "MENU")
        Me.menuSalesOrder_Other_PriceHistory.Enabled = objSecurity.UserAccess(UserInfo.UserID, "SO0067", "MENU")
        Me.menuSalesOrder_Other_SalesAmountCompare.Enabled = objSecurity.UserAccess(UserInfo.UserID, "SO0068", "MENU")
        Me.menuSalesOrder_Other_SOCalendar.Enabled = objSecurity.UserAccess(UserInfo.UserID, "SO0069", "MENU")
        Me.menuSalesOrder_Other_SOSummaryByYear.Enabled = objSecurity.UserAccess(UserInfo.UserID, "SO0071", "MENU")
        Me.menuSalesOrder_Other_SONotClosedPending.Enabled = objSecurity.UserAccess(UserInfo.UserID, "SO0073", "MENU")

        '---------------------------------------------- Menu D/F Order -------------------------------------
        Me.menuDforder_Edit.Enabled = objSecurity.UserAccess(UserInfo.UserID, "SO0065", "MENU")
        Me.menuDforder_Print.Enabled = objSecurity.UserAccess(UserInfo.UserID, "SO0070", "MENU")
        Me.menuDfOrder_ChangeDFSO.Enabled = objSecurity.UserAccess(UserInfo.UserID, "SO0072", "MENU")
        Me.menuDforder_BulkApprove.Enabled = objSecurity.UserAccess(UserInfo.UserID, "SO0075", "MENU")
        Me.menuDforder_Close.Enabled = objSecurity.UserAccess(UserInfo.UserID, "SO0080", "MENU")
        Me.menuDforder_ScrapReturn.Enabled = objSecurity.UserAccess(UserInfo.UserID, "SO0085", "MENU")

        '---------------------------------------------- Menu D/F Others Report-------------------------------------
        Me.menuDforder_Others.Enabled = objSecurity.UserAccess(UserInfo.UserID, "SO0086", "MENU")
        Me.menuDforder_Others_DFOrderSearch.Enabled = objSecurity.UserAccess(UserInfo.UserID, "SO0087", "MENU")
        Me.menuDforder_OthersSummary.Enabled = objSecurity.UserAccess(UserInfo.UserID, "SO0090", "MENU")
        Me.menuDforder_Others_WeightControl.Enabled = objSecurity.UserAccess(UserInfo.UserID, "SO0095", "MENU")
        Me.menuDforder_Others_WeightControl2.Enabled = objSecurity.UserAccess(UserInfo.UserID, "SO0096", "MENU")
        Me.menuDforder_Others_Pending.Enabled = objSecurity.UserAccess(UserInfo.UserID, "SO0100", "MENU")
        Me.menuDforder_Others_Pending2.Enabled = objSecurity.UserAccess(UserInfo.UserID, "SO0102", "MENU")
        Me.menuDforder_Others_SearchDesignNo.Enabled = objSecurity.UserAccess(UserInfo.UserID, "SO0101", "MENU")
        Me.menuDforder_Others_CheckKOYarn.Enabled = objSecurity.UserAccess(UserInfo.UserID, "SO0103", "MENU")
        Me.menuDforder_Others_DFOrderCLosing.Enabled = objSecurity.UserAccess(UserInfo.UserID, "SO0104", "MENU")
        Me.menuDforder_Others_DFOrderEvaluation.Enabled = objSecurity.UserAccess(UserInfo.UserID, "SO0106", "MENU")
        Me.menuDforder_Others_DFOrderInvoiceControl.Enabled = objSecurity.UserAccess(UserInfo.UserID, "SO0107", "MENU")
        Me.menuDforder_Others_StockSampleAging.Enabled = objSecurity.UserAccess(UserInfo.UserID, "SO0108", "MENU")

        '---------------------------------------------- Menu Lab --------------------------------------------------
        Me.menuLab_Edit.Enabled = objSecurity.UserAccess(UserInfo.UserID, "SO0105", "MENU")
        Me.menuLab_Print.Enabled = objSecurity.UserAccess(UserInfo.UserID, "SO0110", "MENU")

        '---------------------------------------------- Menu Lab Others Report-------------------------------------
        Me.menuLab_Others_Pending.Enabled = objSecurity.UserAccess(UserInfo.UserID, "SO0115", "MENU")

        '---------------------------------------------- Menu Request ---------------------------------------------
        Me.menuRequest_Dyed.Enabled = objSecurity.UserAccess(UserInfo.UserID, "SO0125", "MENU")
        Me.menuRequest_Greige.Enabled = objSecurity.UserAccess(UserInfo.UserID, "SO0120", "MENU")
        'Me.menuRequest_cut.Enabled = objSecurity.UserAccess(UserInfo.UserID, "SO0130", "MENU")
        Me.menuRequest_Sample.Enabled = objSecurity.UserAccess(UserInfo.UserID, "SO0140", "MENU")

        '---------------------------------------------- Menu Invoice Local-------------------------------------
        Me.menuInvoice_Local_Print.Enabled = objSecurity.UserAccess(UserInfo.UserID, "SO0145", "MENU")
        Me.menuInvoice_Local_OutputTax.Enabled = objSecurity.UserAccess(UserInfo.UserID, "SO0155", "MENU")
        Me.menuInvoice_Local_PrintControl.Enabled = objSecurity.UserAccess(UserInfo.UserID, "SO0150", "MENU")
        '---------------------------------------------- Menu Invoice Export-------------------------------------
        Me.menuInvoice_Export_Print.Enabled = objSecurity.UserAccess(UserInfo.UserID, "SO0160", "MENU")
        Me.menuInvoice_Export_PrintControl.Enabled = objSecurity.UserAccess(UserInfo.UserID, "SO0165", "MENU")
        Me.menuInvoice_Export_PrintControl2.Enabled = objSecurity.UserAccess(UserInfo.UserID, "SO0165", "MENU") '
        '---------------------------------------------- Menu Invoice Report-------------------------------------


        '---------------------------------------------- Menu Stock-------------------------------------
        Me.menuStock_Onhand.Enabled = objSecurity.UserAccess(UserInfo.UserID, "SO0170", "MENU")
        Me.menuStock_GreigeOnHand.Enabled = objSecurity.UserAccess(UserInfo.UserID, "SO0215", "MENU")
        Me.menuStock_CutOnHand.Enabled = objSecurity.UserAccess(UserInfo.UserID, "SO0210", "MENU")
        Me.menuStock_PendingCut.Enabled = objSecurity.UserAccess(UserInfo.UserID, "SO0225", "MENU")

        Me.menuStock_OutSample.Enabled = objSecurity.UserAccess(UserInfo.UserID, "SO0180", "MENU")
        Me.menuStock_GinNoDf.Enabled = objSecurity.UserAccess(UserInfo.UserID, "SO0185", "MENU")
        Me.menuStock_StockMove.Enabled = objSecurity.UserAccess(UserInfo.UserID, "SO0190", "MENU")
        Me.menuStock_RollDNotFound.Enabled = objSecurity.UserAccess(UserInfo.UserID, "SO0200", "MENU")
        Me.menuStock_RollGNotFound.Enabled = objSecurity.UserAccess(UserInfo.UserID, "SO0195", "MENU")
        Me.menuStock_GreigeOverLoad.Enabled = objSecurity.UserAccess(UserInfo.UserID, "SO0220", "MENU")
        Me.menuStockGreigeOnhandForCheckOldGoods.Enabled = objSecurity.UserAccess(UserInfo.UserID, "SO0231", "MENU")
        Me.menuPurchase_POControl.Enabled = objSecurity.UserAccess(UserInfo.UserID, "SO0205", "MENU")

        Me.menuTransferYarn.Enabled = objSecurity.UserAccess(UserInfo.UserID, "SO0234", "MENU")
        Me.menuTransferGreige.Enabled = objSecurity.UserAccess(UserInfo.UserID, "SO0235", "MENU")
        Me.menuTransferDyed.Enabled = objSecurity.UserAccess(UserInfo.UserID, "SO0236", "MENU")

        Me.menuEndingYarn.Enabled = objSecurity.UserAccess(UserInfo.UserID, "SO0237", "MENU")
        Me.menuEndingGreige.Enabled = objSecurity.UserAccess(UserInfo.UserID, "SO0238", "MENU")
        Me.menuEndingDyed.Enabled = objSecurity.UserAccess(UserInfo.UserID, "SO0239", "MENU")

        Me.menuStock_GreigeOutFromDF.Enabled = objSecurity.UserAccess(UserInfo.UserID, "SO0240", "MENU")
        'Me.menuTransferYarn.Enabled = objSecurity.UserAccess(UserInfo.UserID, "SO0233", "MENU")  'Sitthana  23/04/2018

        Me.menuProduction_KOSchedulePlan.Enabled = objSecurity.UserAccess(UserInfo.UserID, "PLN001", "MENU")
        Me.menuProduction_Reports_YarnDemandForecast.Enabled = objSecurity.UserAccess(UserInfo.UserID, "PLN002", "MENU")
        Me.menuProduction_Reports_YarnDemandPlanning.Enabled = objSecurity.UserAccess(UserInfo.UserID, "PLN003", "MENU")
        'Me.menuProduction_Reports_YarnDemandPlanning.Visible = objSecurity.UserAccess(UserInfo.UserID, "PLN003", "MENU")

        'Me.menuProduction_KOSchedulePlan.Enabled = objSecurity.UserAccess(UserInfo.UserID, "PLN001", "MENU")
        ' Me.menuProduction_Reports_YarnDemandForecast.Enabled = objSecurity.UserAccess(UserInfo.UserID, "PLN002", "MENU")
        ' Me.menuProduction_Reports_YarnDemandPlanning.Enabled = objSecurity.UserAccess(UserInfo.UserID, "PLN003", "MENU")
        Dim clsMaster As New classMaster
        Dim dt As DataTable
        dt = clsMaster.getEmpInPdrSystem(UserInfo.UserID)
        If dt.Rows.Count > 0 Then
            PDRToolStripMenuItem.Enabled = True
        Else
            PDRToolStripMenuItem.Enabled = False
        End If
    End Sub

    Private Function enableDisableMenu(ByVal dt As DataTable, ByVal menuid As String)
        Dim i As Integer
        Dim found As Boolean
        found = False
        For i = 0 To dt.Rows.Count - 1
            If dt.Rows(i)("menuid") = menuid Then
                found = True
                Exit For
            End If
        Next
        Return found
    End Function

    Private Sub menuSalesOrder_Other_SOSummary_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menuSalesOrder_Other_SOSummary.Click
        Dim frm As New frmSalesOrderSummary
        frm.UserInfo = clsUser
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub SOStatusByEmployeeToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menuSalesOrder_Other_SOStatusEmployee.Click
        Dim frm As New frmSalesOrderStatusByEmp
        frm.UserInfo = clsUser
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub SOTraceReportToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles menuSalesOrder_Other_SOTraceReport.Click
        Dim frm As New frmSalesOrderTrace
        frm.UserInfo = clsUser
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub SalesPerformanceToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles menuSalesOrder_Other_SalesPerformance.Click
        Dim frm As New frmSalesPerformance
        frm.UserInfo = clsUser
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub PriceHistoryToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles menuSalesOrder_Other_PriceHistory.Click
        Dim frm As New frmPriceHistory
        frm.UserInfo = clsUser
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub SalesAmountCompareToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles menuSalesOrder_Other_SalesAmountCompare.Click
        Dim frm As New frmSalesAmountCompare
        frm.UserInfo = clsUser
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub SOCalendarToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles menuSalesOrder_Other_SOCalendar.Click
        Dim frm As New frmSODeliveryCalendar
        frm.UserInfo = clsUser
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub SOSummaryByYearToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles menuSalesOrder_Other_SOSummaryByYear.Click
        Dim frm As New frmSOSummaryByYear
        frm.UserInfo = clsUser
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub SONotClosedPendingToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles menuSalesOrder_Other_SONotClosedPending.Click
        Dim frm As New frmSONotClosed
        frm.UserInfo = clsUser
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub SOBookShipmentToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles menuSalesOrder_Other_SOBookShipment.Click
        Dim frm As New frmSoBookShipMentReport
        frm.UserInfo = clsUser
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub tsmnExportInvoiceCommision_Click(sender As Object, e As EventArgs) Handles tsmnExportInvoiceCommision.Click
        'Writen By  : Sitthana 20210901

        Dim frm As New frmExpInvoiceCommision
        frm.UserInfo = clsUser
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub QuotationToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles QuotationToolStripMenuItem.Click
        Dim f As New frmSalesQuote
        f.MdiParent = Me
        UserInfoNew.UserID = UserInfo.UserID
        UserInfoNew.UserName = UserInfo.UserName
        f.userInfo = Me.UserInfoNew
        f.Show()
    End Sub

    Private Sub PDRToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles PDRToolStripMenuItem.Click

    End Sub

    Private Sub menuMasterDesignEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menuMasterDesignEdit.Click
        ' MessageBox.Show("This menu move to program Production System", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
        'Dim frm As New frmDesign
        'Dim frm As New ProductionSystem.frmDesign
        'frm.UserInfo.UserID = clsUser.UserID
        'frm.UserInfo.UserName = clsUser.UserName
        'frm.MdiParent = Me
        'frm.AllowEdit = False
        'frm.AllowNew = False '
        'frm.Show()

        Dim frm As New ProductionSystem.frmDesignNew
        frm.UserInfo.ReportPath = clsUser.ReportPath
        frm.UserInfo.UserID = clsUser.UserID
        frm.UserInfo.UserName = clsUser.UserName
        frm.MdiParent = Me
        frm.AllowEdit = False
        frm.AllowNew = False '
        frm.Show()
    End Sub

    Private Sub menuMasterDesignEditView_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        ' MessageBox.Show("This menu move to program Production System", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
        'Dim frm As New ProductionSystem.frmDesign
        'frm.UserInfo.UserID = clsUser.UserID
        'frm.UserInfo.UserName = clsUser.UserName
        'frm.MdiParent = Me
        'frm.AllowEdit = False
        'frm.AllowNew = False
        'frm.Show()
        Dim frm As New ProductionSystem.frmDesignNew
        frm.UserInfo.ReportPath = clsUser.ReportPath
        frm.UserInfo.UserID = clsUser.UserID
        frm.UserInfo.UserName = clsUser.UserName
        frm.MdiParent = Me
        frm.AllowEdit = False
        frm.AllowNew = False '
        frm.Show()
    End Sub

    Private Sub ReportToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menuMasterDesignReport.Click
        'Dim frm As New ProductionSystem.frmDesignMasterReport
        'frm.UserInfo.UserID = clsUser.UserID
        'frm.UserInfo.UserName = clsUser.UserName
        'frm.MdiParent = Me
        'frm.Show()
    End Sub

    Private Sub GreigeOnhandByDesignToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles GreigeOnhandByDesignToolStripMenuItem.Click
        Dim frm As New frmGreigeOnhandByDesigns
        frm.UserInfo = clsUser
        frm.MdiParent = Me
        frm.Show()

    End Sub

    Private Sub GreigeINKnittingToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs)
        MessageBox.Show("This menu move to program Production System / Stock / Greige In Knitting.", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
        'Dim frm As New frmStockGIN_KOManualIndex
        'frm.UserInfo = clsUser
        'frm.MdiParent = Me
        'frm.Show()

    End Sub

    Private Sub DyedOutFromPackingListToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs)
        'Dim frm As New frmPLD
        'frm.Userinfo = clsUser
        'frm.MdiParent = Me
        'frm.Show()
    End Sub

    Private Sub FrmGreigeOutFromPackinglistToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs)
        'Dim frm As New frmPLG
        'frm.Userinfo = clsUser
        'frm.MdiParent = Me
        'frm.Show()

    End Sub

    Private Sub DyedOutFromSampleToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles DyedOutFromSampleToolStripMenuItem.Click
        Dim frm As New frmDyedOutFromRequest
        frm.Userinfo = clsUser
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub DFOrderSearchToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles menuDforder_Others_DFOrderSearch.Click
        Dim frm As New frmDyingOrderSearch
        frm.Userinfo = clsUser
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub PriceListToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs)
        Dim frm As New frmPricelist
        frm.Userinfo = clsUser
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub CartonsToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs)
        Dim frm As New frmCartons
        frm.Userinfo = clsUser
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub YarnDemandForecstDailyToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles YarnDemandForecstDailyToolStripMenuItem.Click
        Dim frm As New frmYarnDemandForecastDaily
        frm.UserInfo = clsUser
        frm.MdiParent = Me
        frm.Show()
    End Sub
    Private Sub menuProduction_Reports_YarnDemandForecastSummary_Click(sender As Object, e As EventArgs) Handles menuProduction_Reports_YarnDemandForecastSummary.Click
        Dim frm As New frmYarnDemandForecastSummary
        frm.UserInfo = clsUser
        frm.MdiParent = Me
        frm.Show()
    End Sub
    Private Sub menuProduction_Reports_YarnDemandForecast_Click(sender As Object, e As EventArgs) Handles menuProduction_Reports_YarnDemandForecast.Click
        Dim frm As New frmYarnDemandForecast
        frm.UserInfo = clsUser
        frm.MdiParent = Me
        frm.Show()
    End Sub
    Private Sub menuProduction_Reports_YarnDemandPlanning_Click(sender As Object, e As EventArgs) Handles menuProduction_Reports_YarnDemandPlanning.Click
        Dim frm As New frmYarnDemandMachine
        frm.UserInfo = clsUser
        frm.MdiParent = Me
        frm.Show()

    End Sub
    Private Sub YarnDemandHistoryToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles YarnDemandHistoryToolStripMenuItem.Click
        Dim frm As New frmYarnDemandHistory
        frm.UserInfo = clsUser
        frm.MdiParent = Me
        frm.Show()
    End Sub
    Private Sub LocationsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LocationsToolStripMenuItem.Click
        Dim frm As New frmmtl_locations
        frm.p_mtl_warehouse_id = 4
        frm.p_mtl_subinventory_id = 12
        frm.BtnApply.Enabled = True
        frm.UserInfo = clsUser
        frm.MdiParent = Me
        frm.Show()
    End Sub

#Region "StockMenu"
    Private Sub DINToolStripMenuItem1_Click(sender As Object, e As EventArgs)
        Dim frm As New frmStockDIN
        frm.UserInfo = clsUser
        frm.MdiParent = Me
        frm.Show()
    End Sub
    Private Sub DINManualToolStripMenuItem_Click(sender As Object, e As EventArgs)
        'MessageBox.Show("Construction" & vbCrLf & ".", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
        Dim frm As New frmStockDINManual
        frm.UserInfo = clsUser
        frm.MdiParent = Me
        frm.Show()
    End Sub
    Private Sub DINPurchaseToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Dim frm As New frmStockDINPurchase
        frm.UserInfo = clsUser
        frm.MdiParent = Me
        frm.Show()
    End Sub
    Private Sub DINReturnToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Dim frm As New frmStockDINReturn
        frm.Userinfo = clsUser
        frm.MdiParent = Me
        frm.Show()
    End Sub
    Private Sub StockLocationToolStripMenuItem_Click(sender As Object, e As EventArgs)
        'MessageBox.Show("This menu is move to stock / Transfer Location (New Arrival) / Dyed Stock.", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)

        Dim frm As New frmStockDLocation
        frm.Userinfo = clsUser
        frm.MdiParent = Me
        frm.Show()
    End Sub
    Private Sub PrintGINDocumentToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PrintGINDocumentToolStripMenuItem.Click
        Dim frm As New frmGINDocument
        frm.UserInfo = clsUser
        frm.MdiParent = Me
        frm.Show()
    End Sub
    Private Sub PrintDINDocumentToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PrintDINDocumentToolStripMenuItem.Click
        Dim frm As New frmDINDocument
        frm.UserInfo = clsUser
        frm.MdiParent = Me
        frm.Show()
    End Sub
    Private Sub PrintDOUTDocumentToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PrintDOUTDocumentToolStripMenuItem.Click
        Dim frm As New frmDOUTDocument
        frm.UserInfo = clsUser
        frm.MdiParent = Me
        frm.Show()
    End Sub
    Private Sub GINManualToolStripMenuItem_Click(sender As Object, e As EventArgs)
        'Dim frm As New frmStockGINManualKO
        'frm.UserInfo = clsUser
        'frm.MdiParent = Me
        MessageBox.Show("Program's move to Sale Order System > Stock > Greige IN Knitting" & vbCrLf & ".", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)

        'frm.Show()
    End Sub
    Private Sub GINPurchaseToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Dim frm As New frmStockGINPurchase
        frm.UserInfo = clsUser
        frm.MdiParent = Me
        frm.Show()
    End Sub
    Private Sub GINPFDToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Dim frm As New frmStockGIN_PFD
        frm.UserInfo = clsUser
        frm.MdiParent = Me
        frm.Show()
    End Sub
    Private Sub GINPFDManualToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Dim frm As New frmStockGIN_PFDManual
        frm.UserInfo = clsUser
        frm.MdiParent = Me
        frm.Show()
    End Sub
    Private Sub GINReturnNOTUSEDToolStripMenuItem_Click(sender As Object, e As EventArgs)
        MessageBox.Show("This menu is move to program sale order / stock / GIN RETURN.", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
        'Dim frm As New frmStockGReturn
        'frm.UserInfo = clsUser
        'frm.MdiParent = Me
        'frm.Show()
    End Sub
    Private Sub GOUTManualToolStripMenuItem_Click(sender As Object, e As EventArgs)
        'Dim frm As New frmStockGOUTManual
        'frm.Userinfo = clsUser
        'frm.MdiParent = Me
        'frm.Show()
    End Sub
    Private Sub StockGToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles StockGToolStripMenuItem1.Click
        Dim frm As New frmStockGClearanceSale
        frm.UserInfo = clsUser
        frm.MdiParent = Me
        frm.Show()
    End Sub
    Private Sub StockDToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles StockDToolStripMenuItem1.Click
        Dim frm As New frmStockDClearanceSale
        frm.UserInfo = clsUser
        frm.MdiParent = Me
        frm.Show()
    End Sub
    Private Sub EndingYarnStockToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles menuEndingYarn.Click
        Dim frm As New frmEndingYarnInventory
        frm.UserInfo = clsUser
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub EndingGreigeStockToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles menuEndingGreige.Click
        Dim frm As New frmEndingGreigeInventory
        frm.UserInfo = clsUser
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub EndingDyedStockToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles menuEndingDyed.Click
        ' MessageBox.Show("This menu is move to stock / Transfer Location And Grade / Dyed Stock.", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
        Dim frm As New frmEndingDyedInventory
        frm.UserInfo = clsUser
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub TransferYarnStockToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles menuTransferYarn.Click
        'Dim frm As New frmYarnLocation
        Dim frm As New frmYarnTransfer
        frm.UserInfo = clsUser
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub TransferGreigeStockToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles menuTransferGreige.Click
        Dim frm As New frmGreigeTransfer
        frm.UserInfo = clsUser
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub TransferDyedStockToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles menuTransferDyed.Click
        Dim frm As New frmDyedTransfer
        frm.UserInfo = clsUser
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub PackingListGreigeOutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PackingListGreigeOutToolStripMenuItem.Click
        Dim frm As New frmPackingListGreige
        frm.Userinfo = clsUser
        frm.MdiParent = Me
        frm.Show()
    End Sub
    Private Sub PackingListDyedOutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PackingListDyedOutToolStripMenuItem.Click
        'MessageBox.Show("Construction" & vbCrLf & ".", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
        Dim frm As New frmPackingListDyed
        frm.Userinfo = clsUser
        frm.Text = "Packing List Dyed"
        frm.pStockType = "D"
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub DINControlToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DINControlToolStripMenuItem.Click
        Dim frm As New frmDINControl
        frm.UserInfo = clsUser
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub DINControl2ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DINControl2ToolStripMenuItem.Click
        Dim frm As New frmDINControl2
        frm.UserInfo = clsUser
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub DINDyeChargeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DINDyeChargeToolStripMenuItem.Click
        Dim frm As New frmDINDyeCharge
        frm.UserInfo = clsUser
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub StockByBOIToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles StockByBOIToolStripMenuItem.Click
        Dim frm As New frmStockByBOI
        frm.UserInfo = clsUser
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub GOUTControlToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GOUTControlToolStripMenuItem.Click
        Dim frm As New frmGOUTControl
        frm.UserInfo = clsUser
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub GOUTAndDFControlToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GOUTAndDFControlToolStripMenuItem.Click
        Dim frm As New frmGOUTDFControl
        frm.UserInfo = clsUser
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub NewYarnCodeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewYarnCodeToolStripMenuItem.Click
        Dim frm As New frmNewYarnCode
        frm.UserInfo = clsUser
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub NewDesignNoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewDesignNoToolStripMenuItem.Click
        Dim frm As New frmNewDesignNo
        frm.UserInfo = clsUser
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub GreigeLogToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GreigeLogToolStripMenuItem.Click
        Dim frm As New frmGreigeLog
        frm.UserInfo = clsUser
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub CancelledOrderPendingToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CancelledOrderPendingToolStripMenuItem.Click
        Dim frm As New frmCancelledOrderPending
        frm.UserInfo = clsUser
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub DOUTControlToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DOUTControlToolStripMenuItem.Click
        Dim frm As New frmDOUTControl
        frm.UserInfo = clsUser
        frm.MdiParent = Me
        frm.Show()
    End Sub


#End Region

    Private Sub DINProductionReturnToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Dim frm As New frmStockDINReturnProduction
        frm.UserInfo = clsUser
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub EditDyingOrderNewTestingToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles menuDforder_Edit.Click
        Dim frm As New frmDyingOrderV01
        frm.UserInfo = clsUser
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub GINPurchaseToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles GINPurchaseToolStripMenuItem1.Click
        Dim frm As New frmStockGINPurchase
        frm.UserInfo = clsUser
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub GINPFDToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles GINPFDToolStripMenuItem1.Click
        Dim frm As New frmStockGIN_PFD
        frm.UserInfo = clsUser
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub GINPFDManualToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles GINPFDManualToolStripMenuItem1.Click
        Dim frm As New frmStockGIN_PFDManual
        frm.UserInfo = clsUser
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub GINReturnToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GINReturnToolStripMenuItem.Click
        Dim frm As New frmGreigeINReturn
        frm.MdiParent = Me
        frm.UserInfo = Me.UserInfo
        frm.Show()
    End Sub

    Private Sub tsmnGINEditQCRemark_Click(sender As Object, e As EventArgs) Handles tsmnGINEditQCRemark.Click
        Dim frm As New frmGreigeInEditQcRemark

        frm.UserInfo = Me.UserInfo
        frm.Show()
    End Sub

    Private Sub tsmnEndBuyer_Click(sender As Object, e As EventArgs) Handles tsmnEndBuyer.Click
        Dim frm As New frmEndBuyers
        frm.UserInfo = clsUser
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub CustomerNewToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Dim frm As New frmCustomerNew
        frm.MdiParent = Me
        frm.UserInfo = Me.UserInfo
        frm.Show()
    End Sub

    Private Sub tsmnitmCMRList_Click(sender As Object, e As EventArgs) Handles tsmnitmCMRList.Click
        'Sitthana 18/09/2018
        Dim frm As New frmrptCMRList
        frm.UserInfo = clsUser
        frm.ShowDialog(Me)
    End Sub

    Private Sub DInToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles DInToolStripMenuItem2.Click
        Dim frm As New frmStockDIN
        frm.UserInfo = clsUser
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub DINManualToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles DINManualToolStripMenuItem1.Click
        Dim frm As New frmStockDINManual
        frm.UserInfo = clsUser
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub DINPurchaseToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles DINPurchaseToolStripMenuItem1.Click
        Dim frm As New frmStockDINPurchase
        frm.UserInfo = clsUser
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub DINReturnToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles DINReturnToolStripMenuItem1.Click
        Dim frm As New frmStockDINReturn
        frm.Userinfo = clsUser
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub DINLocationEditQCRemarkToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DINLocationEditQCRemarkToolStripMenuItem.Click
        Dim frm As New frmStockDLocation
        frm.Userinfo = clsUser
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub tsmnGammaLabStockIssue_Click(sender As Object, e As EventArgs) Handles tsmnGammaLabStockIssue.Click
        Dim frmGammaLabStockIssue = New STV.frmGammaLabStockIssue
        frmGammaLabStockIssue = New STV.frmGammaLabStockIssue()
        frmGammaLabStockIssue.ShowDialog()
    End Sub

    Private Sub SampleGreigeINToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SampleGreigeINToolStripMenuItem.Click
        Dim frm As New frmSampleGreigeStockIN
        frm.MdiParent = Me
        frm.Userinfo = Me.UserInfo
        frm.Show()
    End Sub

    Private Sub DesignMAsterNewToolStripMenuItem_Click(sender As Object, e As EventArgs)
        'Dim frm As New ProductionSystem.frmDesignNew
        'frm.UserInfo.ReportPath = clsUser.ReportPath
        'frm.UserInfo.UserID = clsUser.UserID
        'frm.UserInfo.UserName = clsUser.UserName
        'frm.MdiParent = Me
        'frm.AllowEdit = False
        'frm.AllowNew = False '
        'frm.Show()

        'Sitthana 13/03/2018
        'Dim frm As New ProductionSystem.frmDesignNew
        'Dim objDB As New clsConfig
        'Dim dt As New DataTable
        'dt = objDB.getUserRoleRight(clsUser.UserID, "")
        'frm.AllowNew = False
        'frm.AllowEdit = False
        'If dt.Rows.Count > 0 Then
        '    For i As Integer = 0 To dt.Rows.Count - 1
        '        Select Case dt.Rows(i).Item("Roleid").ToString.Trim
        '            Case "R0003"
        '                frm.AllowNew = True
        '                frm.AllowEdit = True
        '            Case "R0004"
        '                frm.AllowNew = False
        '                frm.AllowEdit = False
        '        End Select
        '    Next
        'End If
        'frm.MdiParent = Me
        'frm.UserInfo = UserInfo
        'frm.Show()
    End Sub

    Private Sub DyedOutBarcodeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DyedOutBarcodeToolStripMenuItem.Click
        Dim frm As New frmDyedOutSampleBarcode
        frm.UserInfo = clsUser
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub DyedOutSamplePLSToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DyedOutSamplePLSToolStripMenuItem.Click
        Dim frm As New frmDyedOutSample
        frm.Userinfo = clsUser
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub SampleOutControlToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SampleOutControlToolStripMenuItem.Click
        Dim frm As New frmSampleOutControl
        frm.MdiParent = Me
        frm.UserInfo = Me.UserInfo
        frm.Show()
    End Sub
    Private Sub SampleDesignHistoryToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SampleDesignHistoryToolStripMenuItem.Click
        Dim frm As New frmSampleDesignHistory
        frm.UserInfo = clsUser
        frm.MdiParent = Me
        frm.Show()
    End Sub
    Private Sub tsmnPrintSampleLabel_Click(sender As Object, e As EventArgs) Handles tsmnPrintSampleLabel.Click

    End Sub

    Private Sub HangerInBarcodeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HangerInBarcodeToolStripMenuItem.Click
        Dim frm As New frmHangerINBarcode
        frm.Userinfo = clsUser
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub HangerOutBarcodeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HangerOutBarcodeToolStripMenuItem.Click
        Dim frm As New frmHangerOutBarcode
        frm.Userinfo = clsUser
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub HangerReturnBarcodeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HangerReturnBarcodeToolStripMenuItem.Click
        Dim frm As New frmHangerReturnBarcode
        frm.Userinfo = clsUser
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub HangerOutControlToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HangerOutControlToolStripMenuItem.Click
        Dim frm As New frmHangerOutControl
        frm.UserInfo = clsUser
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub StockOhhandSummaryYearToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles StockOhhandSummaryYearToolStripMenuItem.Click
        Dim frm As New frmStockOnHandSummaryYear
        frm.UserInfo = clsUser
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub GOUTManualNoDFToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GOUTManualNoDFToolStripMenuItem.Click
        Dim frm As New frmStockGOUTManual
        frm.Userinfo = clsUser
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub PrintGOUTDocumentToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PrintGOUTDocumentToolStripMenuItem.Click
        Dim frm As New frmGOUTDocument
        frm.UserInfo = clsUser
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub tsmnGammaColourMatchingRequestTracking_Click(sender As Object, e As EventArgs) Handles tsmnGammaColourMatchingRequestTracking.Click
        Dim objfrmCMRStatus = New STV.frmCMRStatus
        objfrmCMRStatus.pUserID = clsUser.UserID
        objfrmCMRStatus.ShowDialog()
    End Sub

    Private Sub tsmnProductionProcessingTrackingChart_Click(sender As Object, e As EventArgs) Handles tsmnProductionProcessingTrackingChart.Click
        Dim frm = New PPTC.frmOCTracking
        frm.ShowDialog()
    End Sub

    Private Sub tsmnSampleStockBalance_Click(sender As Object, e As EventArgs) Handles tsmnSampleStockBalance.Click
        Dim ObjSampleStockBalance = New STV.DlgGetMasterCode("RollNo")
        ObjSampleStockBalance.pRollNo = ""
        ObjSampleStockBalance.pDesignNO = ""
        ObjSampleStockBalance.pMtlSubinvId = 46 'mtlSubinvIdLABGAM
        ObjSampleStockBalance.ShowDialog()
    End Sub

    Private Sub tsmnGammaProcessTracking_Click(sender As Object, e As EventArgs) Handles tsmnGammaProcessTracking.Click
        'Sitthana 20200901
        Dim objfrm = New STV.frmGammaProcessTracking
        objfrm.ShowDialog()
    End Sub

    Private Sub menuSalesOrder_Other_STSummary_Click(sender As Object, e As EventArgs) Handles menuSalesOrder_Other_STSummary.Click
        Dim frm As New frmStockOrderSummary
        frm.UserInfo = clsUser
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub tsmgPDRProgram_Click(sender As Object, e As EventArgs) Handles tsmgPDRProgram.Click
        Dim frm As New frmPDR
        frm.UserInfo = clsUser
        frm.MdiParent = Me
        frm.Show()
    End Sub
    Private Sub tsmnPDRList_Click(sender As Object, e As EventArgs) Handles tsmnPDRList.Click
        'Sitthana 20200928
        Dim frm As New STV.frmPdrList  ' frmDocAttachments
        frm.Show()
    End Sub

    Private Sub tsmnCMRLabStatus_Click(sender As Object, e As EventArgs) Handles tsmnCMRLabStatus.Click
        Dim frm As New frmCMRLabStatus
        frm.UserInfo = clsUser
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub tsmnSampleTag_Click(sender As Object, e As EventArgs) Handles tsmnSampleTag.Click
        Dim frm As New frmPrintSampleTag
        frm.UserInfo = clsUser
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub GammaDyePerformanceToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GammaDyePerformanceToolStripMenuItem.Click
        Dim frm As New frmGammaDyePerformance
        frm.UserInfo = clsUser
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub StockCuttingToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles StockCuttingToolStripMenuItem.Click
        Dim frm As New frmRequestD
        frm.UserInfo = clsUser
        frm.pRequestSampleStock = "N" 'For use Stock Dyed or Stock Sample
        frm.pStockType = "C"
        frm.Text = "Request Cutting"
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub CINPurchaseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CINPurchaseToolStripMenuItem.Click
        Dim frm As New frmStockDINPurchase
        frm.UserInfo = clsUser
        frm.pStockType = "C"
        frm.tslblDocNo.Text = "CIN No."
        frm.lblDocNo.Text = "CIN No."
        frm.lblDocDate.Text = "CIN Date."
        frm.Text = "CIN Purchase"
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub CINFromDOUTToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CINFromDOUTToolStripMenuItem.Click
        Dim frm As New frmCINReturn
        frm.UserInfo = clsUser
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub PackingListCuttingOutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PackingListCuttingOutToolStripMenuItem.Click
        Dim frm As New frmPackingListDyed
        frm.Userinfo = clsUser
        frm.Text = "Packing List Cutting"
        frm.pStockType = "C"
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub CuttingINToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles CuttingINToolStripMenuItem1.Click
        Dim frm As New frmCuttingIN
        frm.Userinfo = clsUser
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub tsmiStockSummary_Click(sender As Object, e As EventArgs) Handles tsmiStockSummary.Click
        Dim frm As New frmStockSummary
        frm.UserInfo = clsUser
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub menuSalesOrder_Click(sender As Object, e As EventArgs) Handles menuSalesOrder.Click

    End Sub
    '---------------Websites Menu------------Added By John 09/10/2026---------------------------------
    Private Sub tsmiSOStatus_Click(sender As Object, e As EventArgs) Handles tsmiSOStatus.Click '08/10/2026 John
        Dim url As String = "http://172.16.3.2:3001/SOStatus/?emp=" & Uri.EscapeDataString(clsUser.UserName) & "&dbname=" & Uri.EscapeDataString(classConnection.database)
        System.Diagnostics.Process.Start(url)
    End Sub

    Private Sub tsmiSOPriceList_Click(sender As Object, e As EventArgs) Handles tsmiSOPriceList.Click '08/10/2026 John
        Dim url As String = "http://172.16.3.2:3001/SOPRICELIST/"
        System.Diagnostics.Process.Start(url)
    End Sub

    Private Sub tsmiCMRStatus_Click(sender As Object, e As EventArgs) Handles tsmiCMRStatus.Click '08/10/2026 John
        Dim url As String = "http://172.16.3.2:3001/CmrStatus/?emp=" & Uri.EscapeDataString(clsUser.UserName) & "&dbname=" & Uri.EscapeDataString(classConnection.database)
        System.Diagnostics.Process.Start(url)
    End Sub

    Private Sub tsmiGammaDyePerf_Click(sender As Object, e As EventArgs) Handles tsmiGammaDyePerf.Click '08/10/2026 John
        Dim url As String = "http://172.16.3.2:3001/GammaDye/"
        System.Diagnostics.Process.Start(url)
    End Sub

    Private Sub tsmiDFGammaControl_Click(sender As Object, e As EventArgs) Handles tsmiDFGammaControl.Click '08/10/2026 John
        Dim url As String = "http://172.16.3.2:3001/DFGamma/?emp=" & Uri.EscapeDataString(clsUser.UserName) & "&dbname=" & Uri.EscapeDataString(classConnection.database)
        System.Diagnostics.Process.Start(url)
    End Sub

    Private Sub tsmiGreigeDefectRoll_Click(sender As Object, e As EventArgs) Handles tsmiGreigeDefectRoll.Click '08/10/2026 John
        Dim url As String = "http://172.16.3.2:3001/GreigeRollDefect/"
        System.Diagnostics.Process.Start(url)
    End Sub

    Private Sub tsmiSTTracking_Click(sender As Object, e As EventArgs) Handles tsmiSTTracking.Click '08/10/2026 John
        Dim url As String = "http://172.16.3.2:3001/STTracking/"
        System.Diagnostics.Process.Start(url)
    End Sub

    Private Sub tsmiStenterView_Click(sender As Object, e As EventArgs) Handles tsmiStenterView.Click '08/10/2026 John
        Dim url As String = "http://172.16.3.2:3001/StenterView/"
        System.Diagnostics.Process.Start(url)
    End Sub

    Private Sub tsmiPDR_Click(sender As Object, e As EventArgs) Handles tsmiPDR.Click '09/10/2026 John
        Dim url As String = "http://172.16.3.2:5000/ui/login.aspx?user_id=" & Uri.EscapeDataString(clsUser.UserName) & "&pwd=" & Uri.EscapeDataString(clsUser.Password)
        System.Diagnostics.Process.Start(url)
    End Sub
    '-------------------------------------------------------------------------------------------------------------------------------
End Class
