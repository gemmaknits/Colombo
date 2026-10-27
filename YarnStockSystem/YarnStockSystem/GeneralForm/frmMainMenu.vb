Imports System.Windows.Forms
Imports System.Data
Imports System.Data.SqlClient
Imports System.Text
Imports System.Globalization
Imports System

Public Class frmMainMenu
    Private connStr As New classConnection
	Dim ds As New DataSet
    Public loginEmpcd As String
    Private clsUser As New classUserInfo
    Dim _ShortName As String

    Public Property pShortName As String
        Get
            pShortName = _ShortName
        End Get
        Set(ByVal Newvalue As String)
            _ShortName = Newvalue
        End Set
    End Property
    Public Property UserInfo() As classUserInfo
        Get
            UserInfo = clsUser
        End Get
        Set(ByVal NewValue As classUserInfo)
            clsUser = NewValue
        End Set
    End Property

	Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
		End
	End Sub

    Private Sub menuStockinNewPur_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        MessageBox.Show("คุณสุเรชให้ใช้ YARN IN PURCHASE 2", "SYSTEM MESSAGE", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
        'Dim aa As New formYarnIN
        'aa.UserInfo = clsUser
        'aa.MdiParent = Me
        'aa.loginEmpcd = Me.loginEmpcd
        'aa.Show()
    End Sub

    Private Sub Purchase2ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menuStockinNewPur2.Click
        Dim frm As New frmYarnInPurchase
        frm.MdiParent = Me
        frm.UserInfo = clsUser
        frm.Text = "NEW YARN IN PURCHASE"
        frm.Show()
    End Sub

    Private Sub formMainMenu_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Try
            For Each frm As Form In Me.MdiChildren
                frm.Close()
            Next
        Catch ex As Exception

        Finally
            TrayIcon.Dispose()
        End Try
        End
    End Sub

    Private Sub YarnStock_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        lblConnection.Text = "Server : " + New classConnection().ServerName '+ " | " + "Base:" + New classConnection().Database
        lblDatabase.Text = "DataBase : " & pShortName
        'Me.ReportToolStripMenuItem.Visible = False
        'Me.Text = "Yarn Stock System Ver. " & Me.ProductVersion.Trim
        ' lblConnection.Text = "Server : " + New classConnection().ServerName

        Dim culture As CultureInfo
        culture = CultureInfo.CurrentCulture
        If UCase(culture.DisplayName) <> "ENGLISH (UNITED KINGDOM)" Then
            My.Application.ChangeCulture("en-GB")
            My.Application.ChangeUICulture("en-GB")
        End If

        If System.Deployment.Application.ApplicationDeployment.IsNetworkDeployed Then
            Me.Text = "Eschler: Yarn Stock System Ver. " & System.Deployment.Application.ApplicationDeployment.CurrentDeployment.CurrentVersion.ToString
        Else
            Me.Text = "Eschler: Yarn Stock System Ver. " & My.Application.Info.Version.ToString
        End If

        'If Not System.Diagnostics.Debugger.IsAttached Then Me.Text = Me.Text & " Version " & My.Application.Deployment.CurrentVersion.ToString
        Me.ContextMenu = TrayMenu
        TrayIcon.Icon = Me.Icon
        TrayIcon.Visible = False
        TrayIcon.ContextMenu = TrayMenu
        TrayIcon.Text = "Yarn Stock System"

        checkMenuAccess()
    End Sub

    Private Sub JobOrderToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menuJobPrintJob.Click
        Dim frm As New frmPrintJobOrderforYarn
        frm.UserInfo = clsUser
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub ProcessingToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menuStockoutNewProcess.Click
        'MsgBox("This Menu has been moved from system.. Should Be Use Yarn Out Barcode")
        'Dim aa As New formYarnoutOld
        Dim frm As New formYarnout
        frm.Text = "Yarn Out New"
        frm.DgYarnOut.Columns("colIdJobDetYarn").Visible = False
        frm.DgYarnOut.Columns("colGb").Visible = False
        frm.DgYarnOut.Columns("colMfgProductionOrderLineId").Visible = False
        frm.DgYarnOut.Columns("colKoNo").Visible = False
        frm.UserInfo = clsUser
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub StockOutToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StockOutToolStripMenuItem1.Click
        Dim frm As New frmPrintYarnOutDocument
        frm.UserInfo = clsUser
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub ProcessToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim frm As New formJobOrderYarnNewEdit 'formJobOrderforYarnEdit
        frm.UserInfo = clsUser
        frm.MdiParent = Me
        frm.Show()

    End Sub

    Private Sub KnittingToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim frm As New formJobOrderYarnNewEdit
        frm.UserInfo = clsUser
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub ProcessingToolStripMenuItem3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'MsgBox("This Menu has been moved from system.. Should Be Use Yarn Out Barcode")
        Dim frm As New formYarnOutEdit
        frm.UserInfo = clsUser
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub menuReportYarnMove_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menuReportYarnMove.Click
        Dim frm As New formPrintYarnMoveByBox
        frm.UserInfo = clsUser
        frm.MdiParent = Me
        frm.Show()

    End Sub

    Private Sub menuStockInNewProcess_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim aa As New formYarnIn
        aa.UserInfo = clsUser
        aa.MdiParent = Me
        aa.loginEmpcd = Me.loginEmpcd
        aa.Show()

    End Sub

    Private Sub menuStockinEditPurchase_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim frm As New formYarnInEdit
        frm.MdiParent = Me
        frm.UserInfo = clsUser
        frm.Show()

    End Sub



    Private Sub menuStockinEditProcess_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim frm As New formYarnInEdit
        frm.MdiParent = Me
        frm.UserInfo = clsUser
        frm.Show()

    End Sub

    Private Sub menuStockinEditReturn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim frm As New formYarnInEdit
        frm.UserInfo = clsUser
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub menuStockinPrintStockin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menuStockinPrintStockin.Click
        Dim frm As New frmPrintYarnInDocument
        frm.UserInfo = clsUser
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub menuStockinPrintBarcode_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menuStockinPrintBarcode.Click
        Dim frm As New formPrintBarcode
        frm.MdiParent = Me
        frm.UserInfo = clsUser
        frm.Show()
    End Sub

    Private Sub menuStockinNewReturn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menuStockinNewReturn.Click
        Dim frm As New formYarnInReturn
        frm.UserInfo = clsUser
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub menuStockoutNewKnit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menuStockoutNewKnit.Click
        'MsgBox("This Menu has been moved from system.. Should Be Use Yarn Out Barcode")
        Dim frm As New formYarnout
        frm.UserInfo = clsUser
        frm.Text = "Yarn Out New (KNITTING)"
        frm.WindowState = FormWindowState.Maximized
        frm.MdiParent = Me
        frm.Show()

    End Sub

    'Private Sub menuStockoutEditKnit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    'MsgBox("This Menu has been moved from system.. Should Be Use Yarn Out Barcode")
    '    Dim FormYarnOutKnittingEdit As New FormYarnOutKnittingEdit
    '    FormYarnOutKnittingEdit.MdiParent = Me
    '    FormYarnOutKnittingEdit.loginEmpcd = Me.loginEmpcd
    '    FormYarnOutKnittingEdit.Show()
    'End Sub

    Private Sub menuJobApprove_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menuJobApprove.Click
        Dim frm As New formJobOrderforYarnApprove
        frm.MdiParent = Me
        frm.loginEmpcd = Me.loginEmpcd
        frm.UserInfo = clsUser
        frm.Show()
    End Sub

    Private Sub menuJobcancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menuJobcancel.Click
        Dim frm As New formJobOrderforYarnCancel
        frm.MdiParent = Me
        frm.loginEmpcd = Me.loginEmpcd
        frm.UserInfo = clsUser
        frm.Show()
    End Sub

    Private Sub mnuMachineUsage_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuMachineUsage.Click
        Dim frm As New FormRptMachineUsage
        frm.MdiParent = Me
        frm.loginEmpcd = Me.loginEmpcd
        frm.UserInfo = clsUser
        frm.Show()
    End Sub

    Private Sub CompanyStickerToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CompanyStickerToolStripMenuItem.Click
        Dim frm As New frmCompanySticker
        frm.UserInfo = clsUser
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub UsedStockInMonthToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menuReportYarnUsage.Click
        Dim frm As New FormRptYarnUsedByMonth
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub YarnUsageSummaryByYearToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles YarnUsageSummaryByYearToolStripMenuItem.Click
        Dim frm As New frmYarnUsedByYear
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub YarnPurchaseToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menuReportYarnStockControl.Click
        Dim frm As New FormRptYarnPurchase
        frm.ShowDialog(Me)
    End Sub


    Private Sub menuJobNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menuJobNewEdit.Click
        Dim frm As New formJobOrderYarnNewEdit
        frm.MdiParent = Me
        frm.UserInfo = clsUser
        frm.Show()
    End Sub

    Private Sub BarcodeToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles menuJobNewBarcode.Click
        Dim frm As New frmJobOrderBarcode
        frm.MdiParent = Me
        frm.UserInfo = clsUser
        frm.Show()
    End Sub

    Private Sub KIYarnConsumptionToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menuReportKIYarnConsumption.Click
        Dim frm As New formPrintKIConsumption
        frm.UserInfo = clsUser
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub KIYarnConsumption2ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles menuReportKIYarnConsumption2.Click
        Dim frm As New formPrintKIConsumption2
        frm.UserInfo = clsUser
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub KIDeliveryControlToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menuReportKIDeliveryControl.Click
        Dim frm As New formPrintKIGreigeDeliveryControl
        frm.UserInfo = clsUser
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub menuStockOutScrap_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menuStockOutScrap.Click
        Dim frm As New formYarnScrap
        frm.UserInfo = clsUser
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub YarnLatestPriceToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menuReportYarnLatestPrice.Click
        'menu disabled and moved to purchase project
        MsgBox("This report has been moved to the purchasing system..")
        'Exit Sub
        'Dim frm As New PrintYarnLatestPrice
        'frm.UserInfo = New classUserInfo
        'frm.MdiParent = Me
        'frm.Show()
    End Sub

    Private Sub KIJobSummaryToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menuReportKIJobSummary.Click
        Dim frm As New formPrintKIJobSummary
        frm.UserInfo = clsUser
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub menuJobClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menuJobClose.Click
        Dim frm As New frmJobClose
        frm.UserInfo = clsUser
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub menuStockOutCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menuStockOutCancel.Click
        Dim frm As New formYarnOutCancel
        frm.MdiParent = Me
        frm.UserInfo = clsUser
        frm.Show()
    End Sub

    Private Sub YarnStockBalanceByDaetToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menuReportYarnStockBalanceByDate.Click
        MsgBox("This report has been moved from system..")
        Exit Sub
        'Dim frm As New formRptYarnBalance
        'frm.MdiParent = Me
        ' frm.Show()
    End Sub

    Private Sub YarnDemandToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menuReportYarnDemand.Click
        Dim frm As New formPrintYarnDemandForecast
        frm.UserInfo = clsUser
        frm.MdiParent = Me
        frm.Show()
    End Sub
    Private Sub checkMenuAccess()
        'Dim dt As New DataTable
        Dim objconfig As New clsConfig
        'dt = objconfig.getMenuList(UserInfo.UserID)

        'Me.menuMasterColor.enabled = enableDisableMenu(dt, "SO0005")

        ' Me.menuStockinNewPur.Enabled = objconfig.UserAccess(loginEmpcd, "SY0010", "MENU")
        Me.menuStockinNewPur2.Enabled = objconfig.UserAccess(loginEmpcd, "SY0010", "MENU")
        'Me.menuStockInNewProcess.Enabled = objconfig.UserAccess(loginEmpcd, "SY0010", "MENU")
        'Me.menuStockinNewJobReturnWarp.Enabled = objconfig.UserAccess(loginEmpcd, "SY0010", "MENU")
        Me.menuStockinNewReturn.Enabled = objconfig.UserAccess(loginEmpcd, "SY0020", "MENU")
        'Me.menuStockinNewFromGemmaKnit.Enabled = objconfig.UserAccess(loginEmpcd, "SY0010", "MENU")



        'Me.menuStockinEdit.Enabled = objconfig.UserAccess(loginEmpcd, "SY0015", "MENU")
        ' Me.menuStockinEditProcess.Enabled = objconfig.UserAccess(loginEmpcd, "SY0015", "MENU")
        ' Me.menuStockInEditLocation.Enabled = objconfig.UserAccess(loginEmpcd, "SY0015", "MENU")

        'Me.menuStockinNewReturn.Enabled = objconfig.UserAccess(loginEmpcd, "SY0020", "MENU")
        ' Me.menuStockinEditReturn.Enabled = objconfig.UserAccess(loginEmpcd, "SY0020", "MENU")

        Me.menuJobNewEdit.Enabled = objconfig.UserAccess(loginEmpcd, "SY0025", "MENU")
        Me.menuJobNewBarcode.Enabled = objconfig.UserAccess(loginEmpcd, "SY0025", "MENU")
        'Use Temp after k.jiew come back remove Sitthana 20190903
        'If loginEmpcd.ToString.ToUpper = "STOCK" Then
        ' Me.menuJobNewEdit.Enabled = True
        ' End If

        Me.menuJobPrint.Enabled = objconfig.UserAccess(loginEmpcd, "SY0030", "MENU")
        Me.menuJobApprove.Enabled = objconfig.UserAccess(loginEmpcd, "SY0035", "MENU")
        Me.menuJobcancel.Enabled = objconfig.UserAccess(loginEmpcd, "SY0040", "MENU")
        Me.menuJobClose.Enabled = objconfig.UserAccess(loginEmpcd, "SY0045", "MENU")

        Me.menuStockoutNewBarCode.Enabled = objconfig.UserAccess(loginEmpcd, "SY0051", "MENU")
        Me.menuStockoutNewKnit.Enabled = objconfig.UserAccess(loginEmpcd, "SY0055", "MENU")

        Me.menuStockoutNewProcess.Enabled = objconfig.UserAccess(loginEmpcd, "SY0055", "MENU") 'Usermenu table 
        'Use Temp after k.jiew come back remove Sitthana 20190903
        '  If loginEmpcd.ToString.ToUpper = "STOCK" Then
        '  Me.menuStockoutNewProcess.Enabled = True
        '  End If

        ' Me.menuStockoutNewTransfer.Enabled = objconfig.UserAccess(loginEmpcd, "SY0055", "MENU")


        'Me.menuStockoutEditKnit.Enabled = objconfig.UserAccess(loginEmpcd, "SY0065", "MENU")
        Me.menuStockOutEdit.Enabled = objconfig.UserAccess(loginEmpcd, "SY0065", "MENU")
        ' Me.menuStockoutEditTransfer.Enabled = objconfig.UserAccess(loginEmpcd, "SY0065", "MENU")

        Me.menuStockOutCancel.Enabled = objconfig.UserAccess(loginEmpcd, "SY0075", "MENU")
        Me.menuStockOutScrap.Enabled = objconfig.UserAccess(loginEmpcd, "SY0080", "MENU")

        'Process - Sitthana 23/04/2018 -> No menu in database 
        If loginEmpcd.ToUpper = "STOCK" Then
            EndingInventoryToolStripMenuItem.Enabled = False
        Else
            EndingInventoryToolStripMenuItem.Enabled = True
        End If

        Me.menuStockinEdit.Enabled = objconfig.UserAccess(loginEmpcd, "SY0126", "MENU")

    End Sub

    Private Sub menuReportKIPending_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menuReportKIPending.Click
        Dim frm As New formPrintKIPending
        frm.UserInfo = clsUser
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub YarnStockAgingToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles YarnStockAgingToolStripMenuItem.Click
        Dim frm As New frmStockYarnAging
        frm.UserInfo = clsUser
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub YarnINPurchasedToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles YarnINPurchasedToolStripMenuItem.Click
        Dim frm As New frmPrintYarnInPurchased
        frm.UserInfo = clsUser
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub EndingInventoryToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles EndingInventoryToolStripMenuItem.Click
        Dim frm As New frmEndingInventory
        frm.UserInfo = clsUser
        frm.MdiParent = Me
        frm.Show()
    End Sub
    Private Sub YarnExpectedReturnToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles YarnExpectedReturnToolStripMenuItem.Click
        Dim frm As New frmYarnOnTime
        frm.UserInfo = clsUser
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub formMainMenu_SizeChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.SizeChanged
        If Me.WindowState = FormWindowState.Minimized Then
            Me.Hide()
            Me.Tag = "HIDE"
            TrayIcon.Visible = True
            TrayIcon.BalloonTipIcon = ToolTipIcon.Info
            TrayIcon.BalloonTipTitle = "System Message"
            TrayIcon.BalloonTipText = "Yarn Stock System อยู่ที่นี่"
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

    Private Sub TrayIcon_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles TrayIcon.MouseClick
        Me.Tag = ""
        Me.Show()
        Me.WindowState = FormWindowState.Maximized
        TrayIcon.Visible = False
    End Sub

    Private Sub menuStockInCancel_Click(sender As System.Object, e As System.EventArgs)

    End Sub


    Private Sub YarnLostByKOToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles YarnLostByKOToolStripMenuItem.Click
        Dim frm As New frmYarnLostByKO
        frm.UserInfo = clsUser
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub TranferFromGammeknitToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs)
        MsgBox("This Menu has been moved from system.. Should Be Use Yarn Out Barcode")
        'Dim frm As New frmYarnINFromGemmaknit
        'frm.MdiParent = Me
        'frm.UserInfo = clsUser
        'frm.Show()

    End Sub

    Private Sub BarcodeToolStripMenuItem1_Click(sender As System.Object, e As System.EventArgs) Handles menuStockoutNewBarCode.Click
        Dim frm As New frmYarnOutBarcode
        frm.UserInfo = clsUser
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub menuStockoutNewTransfer_Click(sender As System.Object, e As System.EventArgs)
        MsgBox("This Menu has been moved from system.. Should Be Use Yarn Out Barcode")
    End Sub

    Private Sub menuStockoutEditTransfer_Click(sender As System.Object, e As System.EventArgs)
        MsgBox("This Menu has been moved from system.. Should Be Use Yarn Out Barcode")
    End Sub

    Private Sub EditToolStripMenuItem1_Click(sender As System.Object, e As System.EventArgs) Handles menuStockOutEdit.Click
        Dim frm As New formYarnOutEdit
        frm.UserInfo = clsUser
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub WOYarnConsumptionToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles menuReportWOYarnConsumption.Click
        Dim frm As New formPrintWOConsumption
        frm.UserInfo = clsUser
        frm.MdiParent = Me
        frm.Show()

    End Sub

    Private Sub WOJobSummaryToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles WOJobSummaryToolStripMenuItem.Click
        MsgBox("This Menu has been moved from system.. To Yarn Stock Program : Menu > Report > (K/O And W/O) Production Job Summary Report")
        'Dim frm As New formPrintWOJobSummary
        'frm.MdiParent = Me
        'frm.Show()
    End Sub

    Private Sub WOClosedReportToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles WOClosedReportToolStripMenuItem.Click
        MsgBox("This Menu has been moved from system.. To Production Program : Menu > Production > Report > (K/O And W/O) Production Closed Report")
        'Dim frm As New frmWOClosed
        'frm.UserInfo = clsUser
        'frm.MdiParent = Me
        'frm.Show()
    End Sub

    Private Sub AdjustINToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Dim frm As New frmYarnInPurchase
        frm.UserInfo = clsUser
        frm.rptPurchase.Text = "ADJUST"
        frm.txtPONo.Text = "ADJUST"
        'frm.txtPONo.Enabled = False
        frm.MdiParent = Me
        frm.Text = "ADJUST IN"
        frm.Show()
        frm.txtPONo.Text = "ADJUST"
        frm.txtPONo.ReadOnly = True


    End Sub

    Private Sub YarnScarpHistoryToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles YarnScarpHistoryToolStripMenuItem.Click
        Dim frm As New formPrintYarnScarp
        frm.UserInfo = clsUser
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub menuStockInNewJobReturn_Click(sender As Object, e As EventArgs) Handles menuStockInProductionReturn.Click
        Dim frm As New formYarnInProcessReturn
        frm.UserInfo = clsUser
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub menuStockinEdit_Click(sender As Object, e As EventArgs) Handles menuStockinEdit.Click
        Dim frm As New formYarnInEdit
        frm.UserInfo = clsUser
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub PurchaseGMKToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PurchaseGMKToolStripMenuItem.Click
        Dim frm As New formYarnInPurchaseFromSupplier
        frm.UserInfo = clsUser
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub tsmnYarnNonMovement_Click(sender As Object, e As EventArgs) Handles tsmnYarnNonMovement.Click
        Dim frm As New DlgStockNonMovement
        frm.UserInfo = clsUser
        frm.pReportBy = clsUser.UserName
        frm.ShowDialog()

    End Sub

    Private Sub tsmnDeadStockBalanceYarn_Click(sender As Object, e As EventArgs) Handles tsmnDeadStockBalanceYarn.Click
        'Writen By  : Sitthana 20241216
        Dim frm As New frmDeadStockBalanceYarn
        frm.UserInfo = clsUser
        frm.pReportBy = clsUser.UserName
        frm.ShowDialog()
    End Sub

    Private Sub KIConsumptionAndLossToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles KIConsumptionAndLossToolStripMenuItem.Click
        Dim frm As New frmKIConsumptionAndLoss
        frm.UserInfo = clsUser
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub menuStockinNewTransferGMK_Click(sender As Object, e As EventArgs) Handles menuStockinNewTransferGMK.Click
        Dim frm As New frmYarnINYarnLocationsGMK
        frm.UserInfo = clsUser
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub TransferGMKToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Dim frm As New frmYarnINYarnLocationsGMK
        frm.UserInfo = clsUser
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub tsmnRawBeamYarnCompareBalance_Click(sender As Object, e As EventArgs) Handles tsmnRawBeamYarnCompareBalance.Click
        'Writen by      : Sitthana Boonlom
        'Writen Data    : 20200307
        Dim frm As New frmRawBeamYarnCompareBalance
        frm.clsUser = clsUser
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub CustomerYarnToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CustomerYarnToolStripMenuItem.Click
        Dim frm As New frmYarnInCustomerYarn
        frm.UserInfo = clsUser
        frm.MdiParent = Me
        frm.Show()
    End Sub

End Class
