<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMainmenu
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMainmenu))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.menuMaster = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuMastemnuMasterSupplier = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuMasterItems = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuMasterItemsYarn = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuMasterItemsOthers = New System.Windows.Forms.ToolStripMenuItem()
        Me.PriceListToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReportsToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmnYarnMasterReport = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuPurchase = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuPurchaseNewedit = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuPurchaseNew = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuPurchaseEdit = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuPurchaseEditBOI = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuPurchaseApprove = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuPurchaseCancel = New System.Windows.Forms.ToolStripMenuItem()
        Me.PaidPOToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuClosePO = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuPrintPO = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReportsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuReportsPOHistory = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuReportsYarnLatestPrice = New System.Windows.Forms.ToolStripMenuItem()
        Me.POYarnPendingToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.POAllPendingToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.YarnInventorySpecificCostToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.POCalendarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.POOntimeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.POOntimeByYearToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.POImportAnalysisToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.POYarnTestReportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuJoborder = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuJoborderYarn = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuJoborderYarnNew = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuJoborderYarnEdit = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuJoborderYarnCancel = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuJoborderOthers = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuJoborderOthersNew = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuJoborderOthersEdit = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem3 = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuJoborderOthersCancel = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.CascadeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CascadeToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.TileHorizontalToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TileVerticalToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ChangePasswordToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExchangeRateUSTHBToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.txtExchangeRate = New System.Windows.Forms.ToolStripTextBox()
        Me.lblConnection = New System.Windows.Forms.ToolStripMenuItem()
        Me.lblDataBase = New System.Windows.Forms.ToolStripMenuItem()
        Me.TrayIcon = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.TrayMenu = New System.Windows.Forms.ContextMenu()
        Me.mnuRestore = New System.Windows.Forms.MenuItem()
        Me.mnuExit = New System.Windows.Forms.MenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.menuMaster, Me.MenuPurchase, Me.menuJoborder, Me.ToolStripMenuItem2, Me.ExchangeRateUSTHBToolStripMenuItem, Me.txtExchangeRate, Me.lblConnection, Me.lblDataBase})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(743, 27)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'menuMaster
        '
        Me.menuMaster.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.menuMastemnuMasterSupplier, Me.menuMasterItems, Me.PriceListToolStripMenuItem, Me.ReportsToolStripMenuItem1})
        Me.menuMaster.Name = "menuMaster"
        Me.menuMaster.Size = New System.Drawing.Size(55, 23)
        Me.menuMaster.Text = "Master"
        '
        'menuMastemnuMasterSupplier
        '
        Me.menuMastemnuMasterSupplier.Name = "menuMastemnuMasterSupplier"
        Me.menuMastemnuMasterSupplier.Size = New System.Drawing.Size(121, 22)
        Me.menuMastemnuMasterSupplier.Text = "Supplier"
        '
        'menuMasterItems
        '
        Me.menuMasterItems.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.menuMasterItemsYarn, Me.menuMasterItemsOthers})
        Me.menuMasterItems.Name = "menuMasterItems"
        Me.menuMasterItems.Size = New System.Drawing.Size(121, 22)
        Me.menuMasterItems.Text = "Items"
        '
        'menuMasterItemsYarn
        '
        Me.menuMasterItemsYarn.Name = "menuMasterItemsYarn"
        Me.menuMasterItemsYarn.Size = New System.Drawing.Size(136, 22)
        Me.menuMasterItemsYarn.Text = "Yarn"
        '
        'menuMasterItemsOthers
        '
        Me.menuMasterItemsOthers.Name = "menuMasterItemsOthers"
        Me.menuMasterItemsOthers.Size = New System.Drawing.Size(136, 22)
        Me.menuMasterItemsOthers.Text = "Other items"
        '
        'PriceListToolStripMenuItem
        '
        Me.PriceListToolStripMenuItem.Name = "PriceListToolStripMenuItem"
        Me.PriceListToolStripMenuItem.Size = New System.Drawing.Size(121, 22)
        Me.PriceListToolStripMenuItem.Text = "Price List"
        '
        'ReportsToolStripMenuItem1
        '
        Me.ReportsToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmnYarnMasterReport})
        Me.ReportsToolStripMenuItem1.Name = "ReportsToolStripMenuItem1"
        Me.ReportsToolStripMenuItem1.Size = New System.Drawing.Size(121, 22)
        Me.ReportsToolStripMenuItem1.Text = "Reports"
        '
        'tsmnYarnMasterReport
        '
        Me.tsmnYarnMasterReport.Name = "tsmnYarnMasterReport"
        Me.tsmnYarnMasterReport.Size = New System.Drawing.Size(174, 22)
        Me.tsmnYarnMasterReport.Text = "Yarn Master Report"
        '
        'MenuPurchase
        '
        Me.MenuPurchase.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.menuPurchaseNewedit, Me.menuPurchaseNew, Me.menuPurchaseEdit, Me.menuPurchaseEditBOI, Me.menuPurchaseApprove, Me.menuPurchaseCancel, Me.PaidPOToolStripMenuItem, Me.menuClosePO, Me.menuPrintPO, Me.ReportsToolStripMenuItem})
        Me.MenuPurchase.Name = "MenuPurchase"
        Me.MenuPurchase.Size = New System.Drawing.Size(67, 23)
        Me.MenuPurchase.Text = "Purchase"
        '
        'menuPurchaseNewedit
        '
        Me.menuPurchaseNewedit.Name = "menuPurchaseNewedit"
        Me.menuPurchaseNewedit.Size = New System.Drawing.Size(180, 22)
        Me.menuPurchaseNewedit.Text = "New / Edit"
        '
        'menuPurchaseNew
        '
        Me.menuPurchaseNew.Name = "menuPurchaseNew"
        Me.menuPurchaseNew.Size = New System.Drawing.Size(180, 22)
        Me.menuPurchaseNew.Text = "New"
        '
        'menuPurchaseEdit
        '
        Me.menuPurchaseEdit.Name = "menuPurchaseEdit"
        Me.menuPurchaseEdit.Size = New System.Drawing.Size(180, 22)
        Me.menuPurchaseEdit.Text = "Edit"
        '
        'menuPurchaseEditBOI
        '
        Me.menuPurchaseEditBOI.Name = "menuPurchaseEditBOI"
        Me.menuPurchaseEditBOI.Size = New System.Drawing.Size(180, 22)
        Me.menuPurchaseEditBOI.Text = "EditBOI"
        '
        'menuPurchaseApprove
        '
        Me.menuPurchaseApprove.Name = "menuPurchaseApprove"
        Me.menuPurchaseApprove.Size = New System.Drawing.Size(180, 22)
        Me.menuPurchaseApprove.Text = "Approve"
        '
        'menuPurchaseCancel
        '
        Me.menuPurchaseCancel.Name = "menuPurchaseCancel"
        Me.menuPurchaseCancel.Size = New System.Drawing.Size(180, 22)
        Me.menuPurchaseCancel.Text = "Cancel"
        '
        'PaidPOToolStripMenuItem
        '
        Me.PaidPOToolStripMenuItem.Name = "PaidPOToolStripMenuItem"
        Me.PaidPOToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.PaidPOToolStripMenuItem.Text = "Paid P/O"
        '
        'menuClosePO
        '
        Me.menuClosePO.Name = "menuClosePO"
        Me.menuClosePO.Size = New System.Drawing.Size(180, 22)
        Me.menuClosePO.Text = "Close P/O"
        '
        'menuPrintPO
        '
        Me.menuPrintPO.Name = "menuPrintPO"
        Me.menuPrintPO.Size = New System.Drawing.Size(180, 22)
        Me.menuPrintPO.Text = "Print P/O"
        '
        'ReportsToolStripMenuItem
        '
        Me.ReportsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.menuReportsPOHistory, Me.menuReportsYarnLatestPrice, Me.POYarnPendingToolStripMenuItem, Me.POAllPendingToolStripMenuItem, Me.YarnInventorySpecificCostToolStripMenuItem, Me.POCalendarToolStripMenuItem, Me.POOntimeToolStripMenuItem, Me.POOntimeByYearToolStripMenuItem, Me.POImportAnalysisToolStripMenuItem, Me.POYarnTestReportToolStripMenuItem})
        Me.ReportsToolStripMenuItem.Name = "ReportsToolStripMenuItem"
        Me.ReportsToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.ReportsToolStripMenuItem.Text = "Reports"
        '
        'menuReportsPOHistory
        '
        Me.menuReportsPOHistory.Name = "menuReportsPOHistory"
        Me.menuReportsPOHistory.Size = New System.Drawing.Size(221, 22)
        Me.menuReportsPOHistory.Text = "P/O History report"
        '
        'menuReportsYarnLatestPrice
        '
        Me.menuReportsYarnLatestPrice.Name = "menuReportsYarnLatestPrice"
        Me.menuReportsYarnLatestPrice.Size = New System.Drawing.Size(221, 22)
        Me.menuReportsYarnLatestPrice.Text = "Yarn Latest Price"
        '
        'POYarnPendingToolStripMenuItem
        '
        Me.POYarnPendingToolStripMenuItem.Name = "POYarnPendingToolStripMenuItem"
        Me.POYarnPendingToolStripMenuItem.Size = New System.Drawing.Size(221, 22)
        Me.POYarnPendingToolStripMenuItem.Text = "P/O Yarn Pending"
        '
        'POAllPendingToolStripMenuItem
        '
        Me.POAllPendingToolStripMenuItem.Name = "POAllPendingToolStripMenuItem"
        Me.POAllPendingToolStripMenuItem.Size = New System.Drawing.Size(221, 22)
        Me.POAllPendingToolStripMenuItem.Text = "P/O All Pending"
        '
        'YarnInventorySpecificCostToolStripMenuItem
        '
        Me.YarnInventorySpecificCostToolStripMenuItem.Name = "YarnInventorySpecificCostToolStripMenuItem"
        Me.YarnInventorySpecificCostToolStripMenuItem.Size = New System.Drawing.Size(221, 22)
        Me.YarnInventorySpecificCostToolStripMenuItem.Text = "Yarn Inventory Specific Cost"
        '
        'POCalendarToolStripMenuItem
        '
        Me.POCalendarToolStripMenuItem.Name = "POCalendarToolStripMenuItem"
        Me.POCalendarToolStripMenuItem.Size = New System.Drawing.Size(221, 22)
        Me.POCalendarToolStripMenuItem.Text = "P/O Calendar"
        '
        'POOntimeToolStripMenuItem
        '
        Me.POOntimeToolStripMenuItem.Name = "POOntimeToolStripMenuItem"
        Me.POOntimeToolStripMenuItem.Size = New System.Drawing.Size(221, 22)
        Me.POOntimeToolStripMenuItem.Text = "P/O Ontime"
        '
        'POOntimeByYearToolStripMenuItem
        '
        Me.POOntimeByYearToolStripMenuItem.Name = "POOntimeByYearToolStripMenuItem"
        Me.POOntimeByYearToolStripMenuItem.Size = New System.Drawing.Size(221, 22)
        Me.POOntimeByYearToolStripMenuItem.Text = "P/O Ontime By Year"
        '
        'POImportAnalysisToolStripMenuItem
        '
        Me.POImportAnalysisToolStripMenuItem.Name = "POImportAnalysisToolStripMenuItem"
        Me.POImportAnalysisToolStripMenuItem.Size = New System.Drawing.Size(221, 22)
        Me.POImportAnalysisToolStripMenuItem.Text = "P/O Import Analysis"
        '
        'POYarnTestReportToolStripMenuItem
        '
        Me.POYarnTestReportToolStripMenuItem.Name = "POYarnTestReportToolStripMenuItem"
        Me.POYarnTestReportToolStripMenuItem.Size = New System.Drawing.Size(221, 22)
        Me.POYarnTestReportToolStripMenuItem.Text = "P/O Yarn Test Report"
        '
        'menuJoborder
        '
        Me.menuJoborder.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.menuJoborderYarn, Me.menuJoborderOthers})
        Me.menuJoborder.Name = "menuJoborder"
        Me.menuJoborder.Size = New System.Drawing.Size(68, 23)
        Me.menuJoborder.Text = "Job order"
        Me.menuJoborder.Visible = False
        '
        'menuJoborderYarn
        '
        Me.menuJoborderYarn.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.menuJoborderYarnNew, Me.menuJoborderYarnEdit, Me.ToolStripMenuItem1, Me.menuJoborderYarnCancel})
        Me.menuJoborderYarn.Name = "menuJoborderYarn"
        Me.menuJoborderYarn.Size = New System.Drawing.Size(109, 22)
        Me.menuJoborderYarn.Text = "Yarn"
        '
        'menuJoborderYarnNew
        '
        Me.menuJoborderYarnNew.Name = "menuJoborderYarnNew"
        Me.menuJoborderYarnNew.Size = New System.Drawing.Size(119, 22)
        Me.menuJoborderYarnNew.Text = "New"
        '
        'menuJoborderYarnEdit
        '
        Me.menuJoborderYarnEdit.Name = "menuJoborderYarnEdit"
        Me.menuJoborderYarnEdit.Size = New System.Drawing.Size(119, 22)
        Me.menuJoborderYarnEdit.Text = "Edit"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(119, 22)
        Me.ToolStripMenuItem1.Text = "Approve"
        '
        'menuJoborderYarnCancel
        '
        Me.menuJoborderYarnCancel.Name = "menuJoborderYarnCancel"
        Me.menuJoborderYarnCancel.Size = New System.Drawing.Size(119, 22)
        Me.menuJoborderYarnCancel.Text = "Cancel"
        '
        'menuJoborderOthers
        '
        Me.menuJoborderOthers.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.menuJoborderOthersNew, Me.menuJoborderOthersEdit, Me.ToolStripMenuItem3, Me.menuJoborderOthersCancel})
        Me.menuJoborderOthers.Name = "menuJoborderOthers"
        Me.menuJoborderOthers.Size = New System.Drawing.Size(109, 22)
        Me.menuJoborderOthers.Text = "Others"
        '
        'menuJoborderOthersNew
        '
        Me.menuJoborderOthersNew.Name = "menuJoborderOthersNew"
        Me.menuJoborderOthersNew.Size = New System.Drawing.Size(119, 22)
        Me.menuJoborderOthersNew.Text = "New"
        '
        'menuJoborderOthersEdit
        '
        Me.menuJoborderOthersEdit.Name = "menuJoborderOthersEdit"
        Me.menuJoborderOthersEdit.Size = New System.Drawing.Size(119, 22)
        Me.menuJoborderOthersEdit.Text = "Edit"
        '
        'ToolStripMenuItem3
        '
        Me.ToolStripMenuItem3.Name = "ToolStripMenuItem3"
        Me.ToolStripMenuItem3.Size = New System.Drawing.Size(119, 22)
        Me.ToolStripMenuItem3.Text = "Approve"
        '
        'menuJoborderOthersCancel
        '
        Me.menuJoborderOthersCancel.Name = "menuJoborderOthersCancel"
        Me.menuJoborderOthersCancel.Size = New System.Drawing.Size(119, 22)
        Me.menuJoborderOthersCancel.Text = "Cancel"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CascadeToolStripMenuItem, Me.ChangePasswordToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(68, 23)
        Me.ToolStripMenuItem2.Text = "Windows"
        '
        'CascadeToolStripMenuItem
        '
        Me.CascadeToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CascadeToolStripMenuItem1, Me.TileHorizontalToolStripMenuItem, Me.TileVerticalToolStripMenuItem})
        Me.CascadeToolStripMenuItem.Name = "CascadeToolStripMenuItem"
        Me.CascadeToolStripMenuItem.Size = New System.Drawing.Size(168, 22)
        Me.CascadeToolStripMenuItem.Text = "Arrange Windows"
        '
        'CascadeToolStripMenuItem1
        '
        Me.CascadeToolStripMenuItem1.Name = "CascadeToolStripMenuItem1"
        Me.CascadeToolStripMenuItem1.Size = New System.Drawing.Size(150, 22)
        Me.CascadeToolStripMenuItem1.Text = "Cascade"
        '
        'TileHorizontalToolStripMenuItem
        '
        Me.TileHorizontalToolStripMenuItem.Name = "TileHorizontalToolStripMenuItem"
        Me.TileHorizontalToolStripMenuItem.Size = New System.Drawing.Size(150, 22)
        Me.TileHorizontalToolStripMenuItem.Text = "Tile Horizontal"
        '
        'TileVerticalToolStripMenuItem
        '
        Me.TileVerticalToolStripMenuItem.Name = "TileVerticalToolStripMenuItem"
        Me.TileVerticalToolStripMenuItem.Size = New System.Drawing.Size(150, 22)
        Me.TileVerticalToolStripMenuItem.Text = "Tile Vertical"
        '
        'ChangePasswordToolStripMenuItem
        '
        Me.ChangePasswordToolStripMenuItem.Name = "ChangePasswordToolStripMenuItem"
        Me.ChangePasswordToolStripMenuItem.Size = New System.Drawing.Size(168, 22)
        Me.ChangePasswordToolStripMenuItem.Text = "Change Password"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(168, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'ExchangeRateUSTHBToolStripMenuItem
        '
        Me.ExchangeRateUSTHBToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.ExchangeRateUSTHBToolStripMenuItem.Name = "ExchangeRateUSTHBToolStripMenuItem"
        Me.ExchangeRateUSTHBToolStripMenuItem.Size = New System.Drawing.Size(148, 23)
        Me.ExchangeRateUSTHBToolStripMenuItem.Text = "Exchange Rate USD/THB"
        Me.ExchangeRateUSTHBToolStripMenuItem.ToolTipText = "Exchange Rate From Bank Of Thailand"
        '
        'txtExchangeRate
        '
        Me.txtExchangeRate.Enabled = False
        Me.txtExchangeRate.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtExchangeRate.Name = "txtExchangeRate"
        Me.txtExchangeRate.Size = New System.Drawing.Size(50, 23)
        Me.txtExchangeRate.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblConnection
        '
        Me.lblConnection.Name = "lblConnection"
        Me.lblConnection.Size = New System.Drawing.Size(81, 23)
        Me.lblConnection.Text = "Connection"
        '
        'lblDataBase
        '
        Me.lblDataBase.Name = "lblDataBase"
        Me.lblDataBase.Size = New System.Drawing.Size(67, 23)
        Me.lblDataBase.Text = "Database"
        '
        'TrayIcon
        '
        Me.TrayIcon.Text = "NotifyIcon1"
        Me.TrayIcon.Visible = True
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
        'frmMainmenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(743, 443)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmMainmenu"
        Me.Text = "Eschler:  Purchase Order System - Main menu"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents ToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CascadeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CascadeToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TileHorizontalToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TileVerticalToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExchangeRateUSTHBToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents txtExchangeRate As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents TrayIcon As System.Windows.Forms.NotifyIcon
    Friend WithEvents TrayMenu As System.Windows.Forms.ContextMenu
    Friend WithEvents mnuRestore As System.Windows.Forms.MenuItem
    Friend WithEvents mnuExit As System.Windows.Forms.MenuItem
    Friend WithEvents ChangePasswordToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuMaster As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuMastemnuMasterSupplier As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuMasterItems As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuMasterItemsYarn As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuMasterItemsOthers As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuPurchase As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuPurchaseNew As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuPurchaseEdit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuPurchaseApprove As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuPurchaseCancel As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuClosePO As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ReportsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuReportsPOHistory As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuReportsYarnLatestPrice As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuJoborder As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuJoborderYarn As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuJoborderYarnNew As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuJoborderYarnEdit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuJoborderYarnCancel As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuJoborderOthers As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuJoborderOthersNew As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuJoborderOthersEdit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem3 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuJoborderOthersCancel As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents POYarnPendingToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents YarnInventorySpecificCostToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents lblConnection As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents POCalendarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents POOntimeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents POOntimeByYearToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents POImportAnalysisToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PriceListToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents POYarnTestReportToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents POAllPendingToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PaidPOToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuPurchaseEditBOI As ToolStripMenuItem
    Friend WithEvents ReportsToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents tsmnYarnMasterReport As ToolStripMenuItem
    Friend WithEvents menuPurchaseNewedit As ToolStripMenuItem
    Friend WithEvents menuPrintPO As ToolStripMenuItem
    Friend WithEvents lblDataBase As ToolStripMenuItem
End Class
