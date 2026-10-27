Imports System.globalization
Imports System
Imports System.Text
Imports System.Data.SqlClient

Public Class frmMainmenu
	Public loginEmpcd As String
	Dim clsUser As New classUserInfo
    Dim _ShortName As String
    Public Property UserInfo() As classUserInfo
		Get
			UserInfo = clsUser
		End Get
		Set(ByVal NewValue As classUserInfo)
			clsUser = NewValue
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
        lblConnection.Text = "Server : " + New classConnection().servername
        lblDataBase.Text = "DataBase : " & pShortName 'New classConnection().database

        Dim culture As CultureInfo
        culture = CultureInfo.CurrentCulture
        If UCase(culture.DisplayName) <> "ENGLISH (UNITED KINGDOM)" Then
            'MsgBox("Select change your regional settings to English United Kingdom")
            'Me.Dispose()
            My.Application.ChangeCulture("en-GB")
            My.Application.ChangeUICulture("en-GB")
        End If

        If Not System.Diagnostics.Debugger.IsAttached Then Me.Text = Me.Text & " Version " & My.Application.Deployment.CurrentVersion.ToString
        Me.ContextMenu = TrayMenu
        TrayIcon.Icon = Me.Icon
        TrayIcon.Visible = False
        TrayIcon.ContextMenu = TrayMenu
        TrayIcon.Text = "Invoice System"

        txtExchangeRate.Text = FormatNumber(clsUser.ExchangeRate, 4)
        InitAccessMenu
    End Sub

    Private Sub InitAccessMenu()
        Dim objSecurity As New clsConfig

        'Menu Invoice
        'Local
        'Export
        'Report
        tsmnInvoiceYarnLot.Enabled = objSecurity.UserRole(UserInfo.UserID, "R0215")

    End Sub
    Private Sub frmMainmenu_SizeChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.SizeChanged
        If Me.WindowState = FormWindowState.Minimized Then
            Me.Hide()
            Me.Tag = "HIDE"
            TrayIcon.Visible = True
            TrayIcon.BalloonTipIcon = ToolTipIcon.Info
            TrayIcon.BalloonTipTitle = "System Message"
            TrayIcon.BalloonTipText = "Invoice System อยู่ที่นี่"
            TrayIcon.ShowBalloonTip(3)
        End If
    End Sub

	Private Sub frmMainmenu_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
		Me.Tag = "CLOSE"
        Dim obj As Form
        For Each obj In Me.MdiChildren
            obj.Close()
        Next
        frmLogin.Close()
        Call TakeLogOut()
        TrayIcon.Dispose()
        'End
    End Sub

	Private Sub EditToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EditToolStripMenuItem.Click
		Dim frm As New frmInvoiceLocal
		frm.UserInfo = clsUser
		frm.MdiParent = Me
		frm.Show()
	End Sub

    Private Sub PrintInvoiceToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PrintInvoiceToolStripMenuItem.Click
		Dim frm As New frmInvoiceLocalPrint
		frm.UserInfo = clsUser
		frm.MdiParent = Me
		frm.Show()
	End Sub

	Private Sub PrintControlToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PrintControlToolStripMenuItem.Click
		Dim frm As New frmInvoiceLocalControl
		frm.UserInfo = clsUser
		frm.MdiParent = Me
		frm.Show()
	End Sub

	Private Sub EditInvoiceToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EditInvoiceToolStripMenuItem.Click
		Dim frm As New frmInvoiceExport
		frm.UserInfo = clsUser
		frm.MdiParent = Me
		frm.Show()
	End Sub

	Private Sub PrintInvoiceToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PrintInvoiceToolStripMenuItem1.Click
		Dim frm As New frmInvoiceExportPrint
		frm.UserInfo = clsUser
		frm.MdiParent = Me
		frm.Show()
	End Sub

	Private Sub PrintControlToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PrintControlToolStripMenuItem1.Click
		Dim frm As New frmInvoiceExportControl
		frm.UserInfo = clsUser
		frm.MdiParent = Me
		frm.Show()
    End Sub

    Private Sub PrintBOIAnalysisToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles PrintBOIAnalysisToolStripMenuItem.Click
        Dim frm As New frmInvoiceExportAnalysis
        frm.UserInfo = clsUser
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub PrintInvoiceWithNotesToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles PrintInvoiceWithNotesToolStripMenuItem.Click
        Dim frm As New frmInvoiceExportReportWithNotes
        frm.UserInfo = clsUser
        frm.MdiParent = Me
        frm.Show()
    End Sub
    Private Sub PrintCargoDeliveryReceiptToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PrintCargoDeliveryReceiptToolStripMenuItem.Click
        Dim frm As New frmCargoDeliveryReceipt
        frm.UserInfo = clsUser
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub GammaBillControlToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles GammaBillControlToolStripMenuItem.Click
        Dim frm As New frmBillControl
        frm.UserInfo = clsUser
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub InvoiceBOIControlToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles InvoiceBOIControlToolStripMenuItem.Click
        Dim frm As New frmInvoiceBOIControl
        frm.UserInfo = clsUser
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub DailyInvoiceSummaryToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles DailyInvoiceSummaryToolStripMenuItem.Click
        Dim frm As New frmInvoiceDailySummary
        frm.UserInfo = clsUser
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub ExportInvoiceDINBalanceToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ExportInvoiceDINBalanceToolStripMenuItem.Click
        Dim frm As New frmInvoiceExportDINBalance
        frm.UserInfo = clsUser
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub CreditNotesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim frm As New frmCreditNoteLocal
        frm.UserInfo = clsUser
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub DebitNotesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim frm As New frmDebitNoteProducts
        frm.UserInfo = clsUser
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub DebitNotesChargeToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs)
        Dim frm As New frmDebitNoteCharge
        frm.UserInfo = clsUser
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub CreditNotesControlToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CreditNotesControlToolStripMenuItem.Click
        Dim frm As New frmCRNoteControl
        frm.UserInfo = clsUser
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub DINToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles DINToolStripMenuItem.Click
        Dim frm As New frmStockDIN
        frm.UserInfo = clsUser
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub GINPFDToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GINPFDToolStripMenuItem.Click
        Dim frm As New frmStockGIN_PFD
        frm.UserInfo = clsUser
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub StockGToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles StockGToolStripMenuItem.Click
        Dim frm As New frmStockGClearanceSale
        frm.UserInfo = clsUser
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub StockDToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles StockDToolStripMenuItem.Click
        Dim frm As New frmStockDClearanceSale
        frm.UserInfo = clsUser
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub YarnStockToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles YarnStockToolStripMenuItem.Click
        Dim frm As New frmEndingYarnInventory
        frm.UserInfo = clsUser
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub GreigeStockToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles GreigeStockToolStripMenuItem.Click
        Dim frm As New frmEndingGreigeInventory
        frm.UserInfo = clsUser
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub DyedStockToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles DyedStockToolStripMenuItem.Click
        Dim frm As New frmEndingDyedInventory
        frm.UserInfo = clsUser
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub DINControlToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles DINControlToolStripMenuItem.Click
        Dim frm As New frmDINControl
        frm.UserInfo = clsUser
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub DINControl2ToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles DINControl2ToolStripMenuItem.Click
        Dim frm As New frmDINControl2
        frm.UserInfo = clsUser
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub DINDyeChargeToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles DINDyeChargeToolStripMenuItem.Click
        Dim frm As New frmDINDyeCharge
        frm.UserInfo = clsUser
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub StockByBOIToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles StockByBOIToolStripMenuItem.Click
        Dim frm As New frmStockByBOI
        frm.UserInfo = clsUser
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub GOUTControlToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles GOUTControlToolStripMenuItem.Click
        Dim frm As New frmGOUTControl
        frm.UserInfo = clsUser
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub GOUTAndDFControlToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles GOUTAndDFControlToolStripMenuItem.Click
        Dim frm As New frmGOUTDFControl
        frm.UserInfo = clsUser
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub NewYarnCodeToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles NewYarnCodeToolStripMenuItem.Click
        Dim frm As New frmNewYarnCode
        frm.UserInfo = clsUser
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub NewDesignNoToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles NewDesignNoToolStripMenuItem.Click
        Dim frm As New frmNewDesignNo
        frm.UserInfo = clsUser
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub GreigeLogToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles GreigeLogToolStripMenuItem.Click
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

    Private Sub PrintSalesOrderToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PrintSalesOrderToolStripMenuItem.Click
        Dim frm As New frmSalesOrderPrint
        frm.UserInfo = clsUser
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub DFOrderPending2ToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles DFOrderPending2ToolStripMenuItem.Click
        Dim frm As New frmDyingOrderPending2
        frm.UserInfo = clsUser
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub ExchangeRateUSTHBToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExchangeRateUSTHBToolStripMenuItem.Click
        Dim browser As New SHDocVw.InternetExplorer
        browser.Visible = True
        browser.Navigate(classMaster.WWW_BOT)
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

        'frm.MdiParent = Me
        'frm.UserInfo = clsUser
        'frm.ShowDialog()
        'clsUser.Password = frm.Password
        'frm.Close()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        End
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


    Private Sub EditInvoiceToolStripMenuItem1_Click(sender As System.Object, e As System.EventArgs) Handles EditInvoiceToolStripMenuItem1.Click
        Dim frm As New frmInvoiceLocalSC
        frm.UserInfo = clsUser
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub PackingListGreigeToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles PackingListGreigeToolStripMenuItem.Click
        Dim frm As New frmPackingListGreige
        frm.Userinfo = clsUser
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub PackingListDyedToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles PackingListDyedToolStripMenuItem.Click
        'MessageBox.Show("Construction" & vbCrLf & ".", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
        Dim frm As New frmPackingListDyed
        frm.Userinfo = clsUser
        frm.MdiParent = Me
        frm.Show()
    End Sub


    Private Sub PackingListYarnsToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles PackingListYarnsToolStripMenuItem.Click
        MessageBox.Show("Construction" & vbCrLf & ".", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
        'Dim frm As New frmPackingListDyed
        'frm.Userinfo = clsUser
        ' frm.MdiParent = Me
        'frm.Show()
    End Sub

    Private Sub DINManualMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles DINManualMenuItem.Click
        'MessageBox.Show("Construction" & vbCrLf & ".", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
        Dim frm As New frmStockDINManual
        frm.UserInfo = clsUser
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub DINDocumentToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs)
        Dim frm As New frmDINDocument
        frm.UserInfo = clsUser
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub PrintDINDocumentToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles PrintDINDocumentToolStripMenuItem.Click
        Dim frm As New frmDINDocument
        frm.UserInfo = clsUser
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub DFOrderToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles DFOrderToolStripMenuItem.Click

    End Sub

    Private Sub DINRemarkToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs)
        Dim frm As New frmDINRemark
        frm.Userinfo = clsUser
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub StockDLocationToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles StockDLocationToolStripMenuItem.Click
        MessageBox.Show("This menu is move to stock / Transfer Location (New Arrival) / Dyed Stock.", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)

        'Dim frm As New frmStockDLocation
        'frm.userinfo = clsUser
        'frm.MdiParent = Me
        'frm.Show()
    End Sub

    Private Sub DINReturnToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles DINReturnToolStripMenuItem.Click
        Dim frm As New frmStockDINReturn
        frm.userinfo = clsUser
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub GOUTManualToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles GOUTManualToolStripMenuItem.Click
        Dim frm As New frmStockGOUTManual
        frm.Userinfo = clsUser
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub PrintGINDocumentToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles PrintGINDocumentToolStripMenuItem.Click
        Dim frm As New frmGINDocument
        frm.UserInfo = clsUser
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub DINFromDyedingNoDFToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles DINFromDyedingNoDFToolStripMenuItem.Click
        Dim frm As New frmStockDINPurchase
        frm.UserInfo = clsUser
        frm.MdiParent = Me
        frm.Show()

    End Sub

    Private Sub GINPFDManualToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles GINPFDManualToolStripMenuItem.Click
        Dim frm As New frmStockGIN_PFDManual
        frm.UserInfo = clsUser
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub GINReturnToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles GINReturnToolStripMenuItem.Click
        MessageBox.Show("This menu is move to program sale order / stock / GIN RETURN.", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
        'Dim frm As New frmStockGReturn
        'frm.UserInfo = clsUser
        'frm.MdiParent = Me
        'frm.Show()
    End Sub

    Private Sub GINPurchaseToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles GINPurchaseToolStripMenuItem.Click
        Dim frm As New frmStockGINPurchase
        frm.userinfo = clsUser
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub GINManualToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles GINManualToolStripMenuItem.Click
        'Dim frm As New frmStockGINManualKO
        'frm.UserInfo = clsUser
        'frm.MdiParent = Me
        MessageBox.Show("Program's move to Sale Order System > Stock > Greige IN Knitting" & vbCrLf & ".", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)

        'frm.Show()
    End Sub


    Private Sub BOIFromGINToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles BOIFromGINToolStripMenuItem.Click
        Dim frm As New frmBOIFromGIN
        frm.UserInfo = clsUser
        frm.MdiParent = Me
        frm.Show()

    End Sub

    Private Sub BOIFromGOUTToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles BOIFromGOUTToolStripMenuItem.Click
        Dim frm As New frmBOIFromGOUT
        frm.UserInfo = clsUser
        frm.MdiParent = Me
        frm.Show()

    End Sub

    Private Sub BOIFromDINToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles BOIFromDINToolStripMenuItem.Click
        Dim frm As New frmBOIFromDIN
        frm.UserInfo = clsUser
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub BOIFromDOUTToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles BOIFromDOUTToolStripMenuItem.Click
        Dim frm As New frmBOIFromDOUT
        frm.UserInfo = clsUser
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub CreditsNotesToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs)
        'MessageBox.Show("Construction" & vbCrLf & ".", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
        Dim frm As New frmDebitNoteExport
        frm.UserInfo = clsUser
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub CreditNotesForExportToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs)
        Dim frm As New frmCreditNoteExport
        frm.UserInfo = clsUser
        frm.MdiParent = Me
        frm.Show()

        'MessageBox.Show("Construction" & vbCrLf & ".", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
    End Sub

    Private Sub DebitNotesLocalChargeToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles DebitNotesLocalChargeToolStripMenuItem.Click
        Dim frm As New frmDebitNoteCharge
        frm.UserInfo = clsUser
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub DebitNotesLocalProductToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles DebitNotesLocalProductToolStripMenuItem.Click
        Dim frm As New frmDebitNoteProducts
        frm.UserInfo = clsUser
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub CreditNotesLocalToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles CreditNotesLocalToolStripMenuItem.Click
        Dim frm As New frmCreditNoteLocal
        frm.UserInfo = clsUser
        frm.MdiParent = Me
        frm.Show()
    End Sub
    Private Sub DebitNotesExportToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles DebitNotesExportChargeToolStripMenuItem.Click
        Dim frm As New frmDebitNoteExport
        frm.UserInfo = clsUser
        frm.MdiParent = Me
        frm.Show()
    End Sub


    Private Sub CreditNotesForExportToolStripMenuItem_Click_1(sender As System.Object, e As System.EventArgs) Handles CreditNotesForExportToolStripMenuItem.Click
        Dim frm As New frmCreditNoteExport
        frm.UserInfo = clsUser
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub PrintDOUTDocumentToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles PrintDOUTDocumentToolStripMenuItem.Click
        Dim frm As New frmDOUTDocument
        frm.UserInfo = clsUser
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub DOUTControlToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles DOUTControlToolStripMenuItem.Click
        Dim frm As New frmDOUTControl
        frm.UserInfo = clsUser
        frm.MdiParent = Me
        frm.Show()

    End Sub

    Private Sub YarnStockToolStripMenuItem1_Click(sender As System.Object, e As System.EventArgs) Handles YarnStockLocationToolStripMenuItem1.Click
        Dim frm As New frmYarnLocation
        frm.UserInfo = clsUser
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub ExportToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ExportToolStripMenuItem.Click

    End Sub

    Private Sub LocalToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LocalToolStripMenuItem.Click

    End Sub

    Private Sub GreigeStockToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles GreigeStockToolStripMenuItem1.Click
        Dim frm As New frmGreigeTransfer
        frm.UserInfo = clsUser
        frm.MdiParent = Me
        frm.Show()

    End Sub

    Private Sub DyedStockToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles DyedStockToolStripMenuItem1.Click
        Dim frm As New frmDyedTransfer
        frm.UserInfo = clsUser
        frm.MdiParent = Me
        frm.Show()


    End Sub

    Private Sub DebilNotesForExportProductToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Dim frm As New frmDebitNoteProducts
        frm.UserInfo = clsUser
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub ExportInvoiceDeailToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExportInvoiceDeailToolStripMenuItem.Click
        Dim frm As New frmInvoiceExportDetailReport
        frm.UserInfo = clsUser
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub tsmnInvoiceYarnLot_Click(sender As Object, e As EventArgs) Handles tsmnInvoiceYarnLot.Click
        Dim objFrmInvoiceYarnLot As New FrmInvoiceYarnLot
        objFrmInvoiceYarnLot.ShowDialog(Me)
    End Sub


End Class
