<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMainMenu
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub


    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMainMenu))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.StockInToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CreateToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuStockinNewPur2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuStockinNewReturn = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuStockInProductionReturn = New System.Windows.Forms.ToolStripMenuItem()
        Me.PurchaseGMKToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuStockinNewTransferGMK = New System.Windows.Forms.ToolStripMenuItem()
        Me.CustomerYarnToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuStockinEdit = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuStockinPrint = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuStockinPrintStockin = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuStockinPrintBarcode = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.JobOrderToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuJobNewEdit = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuJobNewBarcode = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuJobPrint = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuJobPrintJob = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.menuJobApprove = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuJobcancel = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuJobClose = New System.Windows.Forms.ToolStripMenuItem()
        Me.StockOutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuStockoutNewBarCode = New System.Windows.Forms.ToolStripMenuItem()
        Me.CreateToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuStockoutNewProcess = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuStockoutNewKnit = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuStockOutEdit = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuStockoutPrintStockout = New System.Windows.Forms.ToolStripMenuItem()
        Me.StockOutToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.menuStockOutCancel = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuStockOutScrap = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuReportYarnMove = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmnRawBeamYarnCompareBalance = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmnYarnNonMovement = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmnDeadStockBalanceYarn = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuMachineUsage = New System.Windows.Forms.ToolStripMenuItem()
        Me.CompanyStickerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuReportYarnUsage = New System.Windows.Forms.ToolStripMenuItem()
        Me.YarnUsageSummaryByYearToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuReportYarnStockControl = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuReportKIYarnConsumption = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuReportKIYarnConsumption2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuReportKIDeliveryControl = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuReportYarnLatestPrice = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuReportKIJobSummary = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuReportYarnStockBalanceByDate = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuReportYarnDemand = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuReportKIPending = New System.Windows.Forms.ToolStripMenuItem()
        Me.YarnStockAgingToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.YarnINPurchasedToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.YarnExpectedReturnToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.YarnLostByKOToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.WOJobSummaryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuReportWOYarnConsumption = New System.Windows.Forms.ToolStripMenuItem()
        Me.WOClosedReportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.YarnScarpHistoryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.KIConsumptionAndLossToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProcessToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EndingInventoryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.lblConnection = New System.Windows.Forms.ToolStripMenuItem()
        Me.lblDatabase = New System.Windows.Forms.ToolStripMenuItem()
        Me.TrayMenu = New System.Windows.Forms.ContextMenu()
        Me.mnuRestore = New System.Windows.Forms.MenuItem()
        Me.mnuExit = New System.Windows.Forms.MenuItem()
        Me.TrayIcon = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.StockInToolStripMenuItem, Me.JobOrderToolStripMenuItem, Me.StockOutToolStripMenuItem, Me.ReportToolStripMenuItem, Me.ProcessToolStripMenuItem, Me.ExitToolStripMenuItem, Me.ToolStripMenuItem1, Me.lblConnection, Me.lblDatabase})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1016, 24)
        Me.MenuStrip1.TabIndex = 9
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'StockInToolStripMenuItem
        '
        Me.StockInToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CreateToolStripMenuItem, Me.menuStockinEdit, Me.menuStockinPrint, Me.ToolStripSeparator1})
        Me.StockInToolStripMenuItem.Name = "StockInToolStripMenuItem"
        Me.StockInToolStripMenuItem.Size = New System.Drawing.Size(63, 20)
        Me.StockInToolStripMenuItem.Text = "Stock-In"
        '
        'CreateToolStripMenuItem
        '
        Me.CreateToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.menuStockinNewPur2, Me.menuStockInProductionReturn, Me.menuStockinNewReturn, Me.PurchaseGMKToolStripMenuItem, Me.menuStockinNewTransferGMK, Me.CustomerYarnToolStripMenuItem})
        Me.CreateToolStripMenuItem.Image = CType(resources.GetObject("CreateToolStripMenuItem.Image"), System.Drawing.Image)
        Me.CreateToolStripMenuItem.Name = "CreateToolStripMenuItem"
        Me.CreateToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.CreateToolStripMenuItem.Text = "New"
        '
        'menuStockinNewPur2
        '
        Me.menuStockinNewPur2.Name = "menuStockinNewPur2"
        Me.menuStockinNewPur2.Size = New System.Drawing.Size(211, 22)
        Me.menuStockinNewPur2.Text = "Purchase"
        '
        'menuStockinNewReturn
        '
        Me.menuStockinNewReturn.Name = "menuStockinNewReturn"
        Me.menuStockinNewReturn.Size = New System.Drawing.Size(211, 22)
        Me.menuStockinNewReturn.Text = "Return"
        '
        'menuStockInProductionReturn
        '
        Me.menuStockInProductionReturn.Name = "menuStockInProductionReturn"
        Me.menuStockInProductionReturn.Size = New System.Drawing.Size(211, 22)
        Me.menuStockInProductionReturn.Text = "Process Return (WARP IN)"
        '
        'PurchaseGMKToolStripMenuItem
        '
        Me.PurchaseGMKToolStripMenuItem.Name = "PurchaseGMKToolStripMenuItem"
        Me.PurchaseGMKToolStripMenuItem.Size = New System.Drawing.Size(211, 22)
        Me.PurchaseGMKToolStripMenuItem.Text = "Purchase GMK"
        '
        'menuStockinNewTransferGMK
        '
        Me.menuStockinNewTransferGMK.Name = "menuStockinNewTransferGMK"
        Me.menuStockinNewTransferGMK.Size = New System.Drawing.Size(211, 22)
        Me.menuStockinNewTransferGMK.Text = "Transfer GMK"
        '
        'CustomerYarnToolStripMenuItem
        '
        Me.CustomerYarnToolStripMenuItem.Name = "CustomerYarnToolStripMenuItem"
        Me.CustomerYarnToolStripMenuItem.Size = New System.Drawing.Size(211, 22)
        Me.CustomerYarnToolStripMenuItem.Text = "Customer Yarn"
        '
        'menuStockinEdit
        '
        Me.menuStockinEdit.Image = CType(resources.GetObject("menuStockinEdit.Image"), System.Drawing.Image)
        Me.menuStockinEdit.Name = "menuStockinEdit"
        Me.menuStockinEdit.Size = New System.Drawing.Size(152, 22)
        Me.menuStockinEdit.Text = "Edit"
        '
        'menuStockinPrint
        '
        Me.menuStockinPrint.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.menuStockinPrintStockin, Me.menuStockinPrintBarcode})
        Me.menuStockinPrint.Image = CType(resources.GetObject("menuStockinPrint.Image"), System.Drawing.Image)
        Me.menuStockinPrint.Name = "menuStockinPrint"
        Me.menuStockinPrint.Size = New System.Drawing.Size(152, 22)
        Me.menuStockinPrint.Text = "Print"
        '
        'menuStockinPrintStockin
        '
        Me.menuStockinPrintStockin.Name = "menuStockinPrintStockin"
        Me.menuStockinPrintStockin.Size = New System.Drawing.Size(118, 22)
        Me.menuStockinPrintStockin.Text = "Stock-ln"
        '
        'menuStockinPrintBarcode
        '
        Me.menuStockinPrintBarcode.Name = "menuStockinPrintBarcode"
        Me.menuStockinPrintBarcode.Size = New System.Drawing.Size(118, 22)
        Me.menuStockinPrintBarcode.Text = "Barcode"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(149, 6)
        '
        'JobOrderToolStripMenuItem
        '
        Me.JobOrderToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.menuJobNewEdit, Me.menuJobNewBarcode, Me.menuJobPrint, Me.ToolStripSeparator2, Me.menuJobApprove, Me.menuJobcancel, Me.menuJobClose})
        Me.JobOrderToolStripMenuItem.Name = "JobOrderToolStripMenuItem"
        Me.JobOrderToolStripMenuItem.Size = New System.Drawing.Size(68, 20)
        Me.JobOrderToolStripMenuItem.Text = "Job order"
        '
        'menuJobNewEdit
        '
        Me.menuJobNewEdit.Name = "menuJobNewEdit"
        Me.menuJobNewEdit.Size = New System.Drawing.Size(152, 22)
        Me.menuJobNewEdit.Text = "New/Edit"
        '
        'menuJobNewBarcode
        '
        Me.menuJobNewBarcode.Name = "menuJobNewBarcode"
        Me.menuJobNewBarcode.Size = New System.Drawing.Size(152, 22)
        Me.menuJobNewBarcode.Text = "Barcode"
        '
        'menuJobPrint
        '
        Me.menuJobPrint.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.menuJobPrintJob})
        Me.menuJobPrint.Name = "menuJobPrint"
        Me.menuJobPrint.Size = New System.Drawing.Size(152, 22)
        Me.menuJobPrint.Text = "Print"
        '
        'menuJobPrintJob
        '
        Me.menuJobPrintJob.Name = "menuJobPrintJob"
        Me.menuJobPrintJob.Size = New System.Drawing.Size(123, 22)
        Me.menuJobPrintJob.Text = "Job order"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(149, 6)
        '
        'menuJobApprove
        '
        Me.menuJobApprove.Name = "menuJobApprove"
        Me.menuJobApprove.Size = New System.Drawing.Size(152, 22)
        Me.menuJobApprove.Text = "Approve"
        '
        'menuJobcancel
        '
        Me.menuJobcancel.Name = "menuJobcancel"
        Me.menuJobcancel.Size = New System.Drawing.Size(152, 22)
        Me.menuJobcancel.Text = "Cancel"
        '
        'menuJobClose
        '
        Me.menuJobClose.Name = "menuJobClose"
        Me.menuJobClose.Size = New System.Drawing.Size(152, 22)
        Me.menuJobClose.Text = "Close"
        '
        'StockOutToolStripMenuItem
        '
        Me.StockOutToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.menuStockoutNewBarCode, Me.CreateToolStripMenuItem1, Me.menuStockOutEdit, Me.menuStockoutPrintStockout, Me.ToolStripSeparator3, Me.menuStockOutCancel, Me.menuStockOutScrap})
        Me.StockOutToolStripMenuItem.Name = "StockOutToolStripMenuItem"
        Me.StockOutToolStripMenuItem.Size = New System.Drawing.Size(73, 20)
        Me.StockOutToolStripMenuItem.Text = "Stock-Out"
        '
        'menuStockoutNewBarCode
        '
        Me.menuStockoutNewBarCode.Name = "menuStockoutNewBarCode"
        Me.menuStockoutNewBarCode.Size = New System.Drawing.Size(152, 22)
        Me.menuStockoutNewBarCode.Text = "Barcode"
        '
        'CreateToolStripMenuItem1
        '
        Me.CreateToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.menuStockoutNewProcess, Me.menuStockoutNewKnit})
        Me.CreateToolStripMenuItem1.Name = "CreateToolStripMenuItem1"
        Me.CreateToolStripMenuItem1.Size = New System.Drawing.Size(152, 22)
        Me.CreateToolStripMenuItem1.Text = "New"
        '
        'menuStockoutNewProcess
        '
        Me.menuStockoutNewProcess.Name = "menuStockoutNewProcess"
        Me.menuStockoutNewProcess.Size = New System.Drawing.Size(131, 22)
        Me.menuStockoutNewProcess.Text = "Processing"
        '
        'menuStockoutNewKnit
        '
        Me.menuStockoutNewKnit.Name = "menuStockoutNewKnit"
        Me.menuStockoutNewKnit.Size = New System.Drawing.Size(131, 22)
        Me.menuStockoutNewKnit.Text = "Knitting"
        '
        'menuStockOutEdit
        '
        Me.menuStockOutEdit.Name = "menuStockOutEdit"
        Me.menuStockOutEdit.Size = New System.Drawing.Size(152, 22)
        Me.menuStockOutEdit.Text = "Edit"
        '
        'menuStockoutPrintStockout
        '
        Me.menuStockoutPrintStockout.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.StockOutToolStripMenuItem1})
        Me.menuStockoutPrintStockout.Name = "menuStockoutPrintStockout"
        Me.menuStockoutPrintStockout.Size = New System.Drawing.Size(152, 22)
        Me.menuStockoutPrintStockout.Text = "Print"
        '
        'StockOutToolStripMenuItem1
        '
        Me.StockOutToolStripMenuItem1.Name = "StockOutToolStripMenuItem1"
        Me.StockOutToolStripMenuItem1.Size = New System.Drawing.Size(128, 22)
        Me.StockOutToolStripMenuItem1.Text = "Stock-Out"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(149, 6)
        '
        'menuStockOutCancel
        '
        Me.menuStockOutCancel.Name = "menuStockOutCancel"
        Me.menuStockOutCancel.Size = New System.Drawing.Size(152, 22)
        Me.menuStockOutCancel.Text = "Cancel"
        '
        'menuStockOutScrap
        '
        Me.menuStockOutScrap.Name = "menuStockOutScrap"
        Me.menuStockOutScrap.Size = New System.Drawing.Size(152, 22)
        Me.menuStockOutScrap.Text = "Scrap"
        '
        'ReportToolStripMenuItem
        '
        Me.ReportToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.menuReportYarnMove, Me.tsmnRawBeamYarnCompareBalance, Me.tsmnYarnNonMovement, Me.tsmnDeadStockBalanceYarn, Me.mnuMachineUsage, Me.CompanyStickerToolStripMenuItem, Me.menuReportYarnUsage, Me.YarnUsageSummaryByYearToolStripMenuItem, Me.menuReportYarnStockControl, Me.menuReportKIYarnConsumption, Me.menuReportKIYarnConsumption2, Me.menuReportKIDeliveryControl, Me.menuReportYarnLatestPrice, Me.menuReportKIJobSummary, Me.menuReportYarnStockBalanceByDate, Me.menuReportYarnDemand, Me.menuReportKIPending, Me.YarnStockAgingToolStripMenuItem, Me.YarnINPurchasedToolStripMenuItem, Me.YarnExpectedReturnToolStripMenuItem, Me.YarnLostByKOToolStripMenuItem, Me.WOJobSummaryToolStripMenuItem, Me.menuReportWOYarnConsumption, Me.WOClosedReportToolStripMenuItem, Me.YarnScarpHistoryToolStripMenuItem, Me.KIConsumptionAndLossToolStripMenuItem})
        Me.ReportToolStripMenuItem.Name = "ReportToolStripMenuItem"
        Me.ReportToolStripMenuItem.Size = New System.Drawing.Size(54, 20)
        Me.ReportToolStripMenuItem.Text = "Report"
        '
        'menuReportYarnMove
        '
        Me.menuReportYarnMove.Name = "menuReportYarnMove"
        Me.menuReportYarnMove.Size = New System.Drawing.Size(286, 22)
        Me.menuReportYarnMove.Text = "Yarn Movement && Balance"
        '
        'tsmnRawBeamYarnCompareBalance
        '
        Me.tsmnRawBeamYarnCompareBalance.Name = "tsmnRawBeamYarnCompareBalance"
        Me.tsmnRawBeamYarnCompareBalance.Size = New System.Drawing.Size(286, 22)
        Me.tsmnRawBeamYarnCompareBalance.Text = "Raw / Beam Yarn Balance Compare"
        '
        'tsmnYarnNonMovement
        '
        Me.tsmnYarnNonMovement.Name = "tsmnYarnNonMovement"
        Me.tsmnYarnNonMovement.Size = New System.Drawing.Size(286, 22)
        Me.tsmnYarnNonMovement.Text = "Yarn Non Movement"
        '
        'tsmnDeadStockBalanceYarn
        '
        Me.tsmnDeadStockBalanceYarn.Name = "tsmnDeadStockBalanceYarn"
        Me.tsmnDeadStockBalanceYarn.Size = New System.Drawing.Size(286, 22)
        Me.tsmnDeadStockBalanceYarn.Text = "Dead Stock Balance Yarn"
        '
        'mnuMachineUsage
        '
        Me.mnuMachineUsage.Name = "mnuMachineUsage"
        Me.mnuMachineUsage.Size = New System.Drawing.Size(286, 22)
        Me.mnuMachineUsage.Text = "Machine Usage"
        '
        'CompanyStickerToolStripMenuItem
        '
        Me.CompanyStickerToolStripMenuItem.Name = "CompanyStickerToolStripMenuItem"
        Me.CompanyStickerToolStripMenuItem.Size = New System.Drawing.Size(286, 22)
        Me.CompanyStickerToolStripMenuItem.Text = "Company Sticker"
        Me.CompanyStickerToolStripMenuItem.Visible = False
        '
        'menuReportYarnUsage
        '
        Me.menuReportYarnUsage.Name = "menuReportYarnUsage"
        Me.menuReportYarnUsage.Size = New System.Drawing.Size(286, 22)
        Me.menuReportYarnUsage.Text = "Yarn Usage Summary"
        '
        'YarnUsageSummaryByYearToolStripMenuItem
        '
        Me.YarnUsageSummaryByYearToolStripMenuItem.Name = "YarnUsageSummaryByYearToolStripMenuItem"
        Me.YarnUsageSummaryByYearToolStripMenuItem.Size = New System.Drawing.Size(286, 22)
        Me.YarnUsageSummaryByYearToolStripMenuItem.Text = "Yarn Usage Summary By Year"
        '
        'menuReportYarnStockControl
        '
        Me.menuReportYarnStockControl.Name = "menuReportYarnStockControl"
        Me.menuReportYarnStockControl.Size = New System.Drawing.Size(286, 22)
        Me.menuReportYarnStockControl.Text = "Yarn Stock Control"
        '
        'menuReportKIYarnConsumption
        '
        Me.menuReportKIYarnConsumption.Name = "menuReportKIYarnConsumption"
        Me.menuReportKIYarnConsumption.Size = New System.Drawing.Size(286, 22)
        Me.menuReportKIYarnConsumption.Text = "K/I Yarn consumption "
        '
        'menuReportKIYarnConsumption2
        '
        Me.menuReportKIYarnConsumption2.Name = "menuReportKIYarnConsumption2"
        Me.menuReportKIYarnConsumption2.Size = New System.Drawing.Size(286, 22)
        Me.menuReportKIYarnConsumption2.Text = "K/I Yarn consumption 2"
        '
        'menuReportKIDeliveryControl
        '
        Me.menuReportKIDeliveryControl.Name = "menuReportKIDeliveryControl"
        Me.menuReportKIDeliveryControl.Size = New System.Drawing.Size(286, 22)
        Me.menuReportKIDeliveryControl.Text = "K/I delivery control"
        '
        'menuReportYarnLatestPrice
        '
        Me.menuReportYarnLatestPrice.Name = "menuReportYarnLatestPrice"
        Me.menuReportYarnLatestPrice.Size = New System.Drawing.Size(286, 22)
        Me.menuReportYarnLatestPrice.Text = "Yarn Latest Price"
        '
        'menuReportKIJobSummary
        '
        Me.menuReportKIJobSummary.Name = "menuReportKIJobSummary"
        Me.menuReportKIJobSummary.Size = New System.Drawing.Size(286, 22)
        Me.menuReportKIJobSummary.Text = "(K/I And W/O) Production Job summary"
        '
        'menuReportYarnStockBalanceByDate
        '
        Me.menuReportYarnStockBalanceByDate.Name = "menuReportYarnStockBalanceByDate"
        Me.menuReportYarnStockBalanceByDate.Size = New System.Drawing.Size(286, 22)
        Me.menuReportYarnStockBalanceByDate.Text = "Yarn Stock Balance By Date"
        '
        'menuReportYarnDemand
        '
        Me.menuReportYarnDemand.Name = "menuReportYarnDemand"
        Me.menuReportYarnDemand.Size = New System.Drawing.Size(286, 22)
        Me.menuReportYarnDemand.Text = "Yarn demand "
        '
        'menuReportKIPending
        '
        Me.menuReportKIPending.Name = "menuReportKIPending"
        Me.menuReportKIPending.Size = New System.Drawing.Size(286, 22)
        Me.menuReportKIPending.Text = "K/I Pending status"
        '
        'YarnStockAgingToolStripMenuItem
        '
        Me.YarnStockAgingToolStripMenuItem.Name = "YarnStockAgingToolStripMenuItem"
        Me.YarnStockAgingToolStripMenuItem.Size = New System.Drawing.Size(286, 22)
        Me.YarnStockAgingToolStripMenuItem.Text = "Yarn Stock Aging"
        '
        'YarnINPurchasedToolStripMenuItem
        '
        Me.YarnINPurchasedToolStripMenuItem.Name = "YarnINPurchasedToolStripMenuItem"
        Me.YarnINPurchasedToolStripMenuItem.Size = New System.Drawing.Size(286, 22)
        Me.YarnINPurchasedToolStripMenuItem.Text = "Yarn IN Purchased"
        '
        'YarnExpectedReturnToolStripMenuItem
        '
        Me.YarnExpectedReturnToolStripMenuItem.Name = "YarnExpectedReturnToolStripMenuItem"
        Me.YarnExpectedReturnToolStripMenuItem.Size = New System.Drawing.Size(286, 22)
        Me.YarnExpectedReturnToolStripMenuItem.Text = "Yarn Ontime"
        '
        'YarnLostByKOToolStripMenuItem
        '
        Me.YarnLostByKOToolStripMenuItem.Name = "YarnLostByKOToolStripMenuItem"
        Me.YarnLostByKOToolStripMenuItem.Size = New System.Drawing.Size(286, 22)
        Me.YarnLostByKOToolStripMenuItem.Text = "Yarn Lost By K/O"
        '
        'WOJobSummaryToolStripMenuItem
        '
        Me.WOJobSummaryToolStripMenuItem.Name = "WOJobSummaryToolStripMenuItem"
        Me.WOJobSummaryToolStripMenuItem.Size = New System.Drawing.Size(286, 22)
        Me.WOJobSummaryToolStripMenuItem.Text = "W/O Job Summary"
        '
        'menuReportWOYarnConsumption
        '
        Me.menuReportWOYarnConsumption.Name = "menuReportWOYarnConsumption"
        Me.menuReportWOYarnConsumption.Size = New System.Drawing.Size(286, 22)
        Me.menuReportWOYarnConsumption.Text = "W/O Yarn consumption"
        '
        'WOClosedReportToolStripMenuItem
        '
        Me.WOClosedReportToolStripMenuItem.Name = "WOClosedReportToolStripMenuItem"
        Me.WOClosedReportToolStripMenuItem.Size = New System.Drawing.Size(286, 22)
        Me.WOClosedReportToolStripMenuItem.Text = "W/O Closed"
        '
        'YarnScarpHistoryToolStripMenuItem
        '
        Me.YarnScarpHistoryToolStripMenuItem.Name = "YarnScarpHistoryToolStripMenuItem"
        Me.YarnScarpHistoryToolStripMenuItem.Size = New System.Drawing.Size(286, 22)
        Me.YarnScarpHistoryToolStripMenuItem.Text = "Yarn Scarp"
        '
        'KIConsumptionAndLossToolStripMenuItem
        '
        Me.KIConsumptionAndLossToolStripMenuItem.Name = "KIConsumptionAndLossToolStripMenuItem"
        Me.KIConsumptionAndLossToolStripMenuItem.Size = New System.Drawing.Size(286, 22)
        Me.KIConsumptionAndLossToolStripMenuItem.Text = "KI Consumption and Loss (ESH)"
        '
        'ProcessToolStripMenuItem
        '
        Me.ProcessToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EndingInventoryToolStripMenuItem})
        Me.ProcessToolStripMenuItem.Name = "ProcessToolStripMenuItem"
        Me.ProcessToolStripMenuItem.Size = New System.Drawing.Size(59, 20)
        Me.ProcessToolStripMenuItem.Text = "Process"
        '
        'EndingInventoryToolStripMenuItem
        '
        Me.EndingInventoryToolStripMenuItem.Name = "EndingInventoryToolStripMenuItem"
        Me.EndingInventoryToolStripMenuItem.Size = New System.Drawing.Size(164, 22)
        Me.EndingInventoryToolStripMenuItem.Text = "Ending Inventory"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(22, 20)
        Me.ToolStripMenuItem1.Text = "|"
        '
        'lblConnection
        '
        Me.lblConnection.Name = "lblConnection"
        Me.lblConnection.Size = New System.Drawing.Size(81, 20)
        Me.lblConnection.Text = "Connection"
        '
        'lblDatabase
        '
        Me.lblDatabase.Name = "lblDatabase"
        Me.lblDatabase.Size = New System.Drawing.Size(67, 20)
        Me.lblDatabase.Text = "Database"
        '
        'TrayMenu
        '
        Me.TrayMenu.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnuRestore, Me.mnuExit})
        '
        'mnuRestore
        '
        Me.mnuRestore.Index = 0
        Me.mnuRestore.Text = "&Restore"
        '
        'mnuExit
        '
        Me.mnuExit.Index = 1
        Me.mnuExit.Text = "E&xit"
        '
        'TrayIcon
        '
        Me.TrayIcon.Text = "NotifyIcon1"
        Me.TrayIcon.Visible = True
        '
        'frmMainMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1016, 729)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.Name = "frmMainMenu"
        Me.Text = "Eschler: Yarn stock system - Main menu"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents StockInToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CreateToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuStockinNewReturn As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuStockinEdit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuStockinPrint As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuStockinPrintStockin As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuStockinPrintBarcode As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StockOutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CreateToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuStockoutNewKnit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuStockoutNewProcess As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuStockOutEdit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuStockoutPrintStockout As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StockOutToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ReportToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ProcessToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents JobOrderToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuJobNewEdit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuJobPrint As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuJobPrintJob As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuReportYarnMove As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuJobcancel As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuStockOutCancel As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuJobApprove As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents mnuMachineUsage As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CompanyStickerToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuReportYarnUsage As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuReportYarnStockControl As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuReportKIYarnConsumption As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuReportKIDeliveryControl As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuStockOutScrap As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuReportYarnLatestPrice As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuReportKIJobSummary As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuJobClose As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuReportYarnStockBalanceByDate As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuReportYarnDemand As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuReportKIPending As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TrayMenu As System.Windows.Forms.ContextMenu
    Friend WithEvents mnuRestore As System.Windows.Forms.MenuItem
    Friend WithEvents mnuExit As System.Windows.Forms.MenuItem
    Friend WithEvents TrayIcon As System.Windows.Forms.NotifyIcon
    Friend WithEvents menuStockinNewPur2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EndingInventoryToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuJobNewBarcode As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents YarnUsageSummaryByYearToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents lblConnection As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents YarnStockAgingToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuReportKIYarnConsumption2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents YarnINPurchasedToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents YarnExpectedReturnToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents YarnLostByKOToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuStockoutNewBarCode As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuReportWOYarnConsumption As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents WOJobSummaryToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents WOClosedReportToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents YarnScarpHistoryToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuStockInProductionReturn As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PurchaseGMKToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents tsmnYarnNonMovement As ToolStripMenuItem
    Friend WithEvents KIConsumptionAndLossToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents menuStockinNewTransferGMK As ToolStripMenuItem
    Friend WithEvents tsmnRawBeamYarnCompareBalance As ToolStripMenuItem
    Friend WithEvents CustomerYarnToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents tsmnDeadStockBalanceYarn As ToolStripMenuItem
    Friend WithEvents lblDatabase As ToolStripMenuItem
End Class
