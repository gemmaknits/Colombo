Imports System.globalization
Imports System
Imports System.Text
Imports System.Data.Sqlclient

Public Class frmMainmenu
	Public loginEmpcd As String
    Dim clsUser As New classUserInfo

    'Sitthana For Sent RoleID To Form
    Dim NewRoleID As String = ""
    Dim EditRoleID As String = ""
    Dim PrintRoleID As String = ""
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

    Private Sub TakeLogOut()
        Dim conn As New SqlConnection((New classConnection).connection)
        conn.Open()
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "p_takelogout"
        comm.Parameters.AddWithValue("@log_id", clsUser.LogID)
        comm.ExecuteNonQuery()
    End Sub
    Private Sub checkMenuAccess() 'Neung 20230802
        Dim objconfig As New clsConfig

        'เพิ่ม Userrole R0400 (ใช้งานได้ทุกเมนู) (MenuRole = PU0010,PU0015,PU0020,PU0025,PU0030,PU0035,PU0040,PU0045)
        'เพิ่ม Userrole R0450 (ใช้งานได้ทุกรายงาน) (MenuRole = PU0050,PU0055)
        'Menu
        'PU0010                              PUR  	Create / edit supplier master
        'PU0015                              PUR  	Create / edit yarn master
        'PU0020                              PUR  	Create / edit other items
        'PU0025                              PUR  	Create New purchase order
        'PU0030                              PUR  	Edit un-approved purchase order
        'PU0035                              PUR  	Approve purchase order
        'PU0040                              PUR  	Cancel purchase order
        'PU0045                              PUR  	Close open purchase order items

        'PU0050                              PUR  	Print list of P/O for given period
        'PU0055                              PUR  	Print latest purchase price of yarns

        Me.menuMastemnuMasterSupplier.Enabled = objconfig.UserAccess(loginEmpcd, "PU0010", "MENU")
        Me.menuMasterItemsYarn.Enabled = objconfig.UserAccess(loginEmpcd, "PU0015", "MENU")
        Me.menuMasterItemsOthers.Enabled = objconfig.UserAccess(loginEmpcd, "PU0020", "MENU")

        Me.menuPurchaseNewedit.Enabled = objconfig.UserAccess(loginEmpcd, "PU0025", "MENU")
        Me.menuPurchaseNew.Enabled = objconfig.UserAccess(loginEmpcd, "PU0025", "MENU")
        Me.menuPurchaseEdit.Enabled = objconfig.UserAccess(loginEmpcd, "PU0030", "MENU")
        Me.menuPurchaseEditBOI.Enabled = objconfig.UserAccess(loginEmpcd, "PU0030", "MENU")
        Me.menuPurchaseApprove.Enabled = objconfig.UserAccess(loginEmpcd, "PU0035", "MENU")
        Me.menuPurchaseCancel.Enabled = objconfig.UserAccess(loginEmpcd, "PU0040", "MENU")
        'Me.PaidPOToolStripMenuItem.Enabled = objconfig.UserAccess(loginEmpcd, "PU0045", "MENU")
        Me.menuClosePO.Enabled = objconfig.UserAccess(loginEmpcd, "PU0045", "MENU")

        Me.menuReportsPOHistory.Enabled = objconfig.UserAccess(loginEmpcd, "PU0050", "MENU")
        Me.menuReportsYarnLatestPrice.Enabled = objconfig.UserAccess(loginEmpcd, "PU0055", "MENU")

    End Sub
    Private Sub formMainmenu_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        lblConnection.Text = "Server : " + New classConnection().servername
        lblDataBase.Text = "DataBase : " & pShortName 'New classConnection().database

        Dim culture As CultureInfo
        culture = CultureInfo.CurrentCulture
        If UCase(culture.DisplayName) <> "ENGLISH (UNITED KINGDOM)" Then
            'MsgBox("Select change your regional settings to English United Kingdom")
            'Me.Close()
            My.Application.ChangeCulture("en-GB")
            My.Application.ChangeUICulture("en-GB")
        End If

        If Not System.Diagnostics.Debugger.IsAttached Then Me.Text = Me.Text & " Version " & My.Application.Deployment.CurrentVersion.ToString
        Me.ContextMenu = TrayMenu
        TrayIcon.Icon = Me.Icon
        TrayIcon.Visible = False
        TrayIcon.ContextMenu = TrayMenu
        TrayIcon.Text = "Purchase Order System"

        txtExchangeRate.Text = FormatNumber(clsUser.ExchangeRate, 4)
        'If clsUser.CanChat Then
        '    Dim frmChatRoom As New frmChatRoom
        '    frmChatRoom.MdiParent = Me
        '    frmChatRoom.UserInfo = clsUser
        '    frmChatRoom.TrayIcon = TrayIcon
        '    If frmChatRoom.StartChatRoom() Then
        '        frmChatRoom.WindowState = FormWindowState.Minimized
        '        frmChatRoom.Show()
        '    End If
        'End If
        Call checkMenuAccess() 'Neung 20230802
        If clsUser.UserID = "NEUNG" Or clsUser.UserID = "JOHN" Or clsUser.UserID = "JIEW" Then 'John 16/01/2026
            menuClosePO.Enabled = True
        Else
            menuClosePO.Enabled = False
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
        End
    End Sub

    Private Sub menuMastemnuMasterSupplier_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menuMastemnuMasterSupplier.Click
        Dim frm As New formSupplierCreate
        frm.MdiParent = Me
        frm.UserInfo = clsUser
        frm.Show()
    End Sub

    Private Sub SetDataRight(p_form As Object, p_NewRoleID As String _
                           , p_EditRoleID As String, p_PrintRoleID As String
                             )
        Dim objDB As New clsConfig
        Dim dt As New DataTable
        dt = objDB.getUserRoleRight(clsUser.UserID, "")

        p_form.AllowNew = False
        p_form.AllowEdit = False
        p_form.AllowPrint = False

        If dt.Rows.Count > 0 Then
            For i As Integer = 0 To dt.Rows.Count - 1
                Select Case dt.Rows(i).Item("Roleid").ToString.Trim.ToUpper
                    Case p_NewRoleID.Trim.ToUpper
                        p_form.AllowNew = True
                    Case p_EditRoleID.Trim.ToUpper
                        p_form.AllowEdit = True
                    Case p_PrintRoleID.Trim.ToUpper
                        p_form.AllowPrint = True
                End Select
            Next
        End If
    End Sub
    Private Sub menuMasterItemsYarn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menuMasterItemsYarn.Click
        Dim frm As New formYarnMaster

        NewRoleID = "R0005"
        EditRoleID = "R0006"
        PrintRoleID = ""
        SetDataRight(frm, NewRoleID, EditRoleID, PrintRoleID)

        frm.MdiParent = Me
        frm.UserInfo = clsUser
        frm.Show()
    End Sub

    Private Sub menuMasterItemsOthers_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menuMasterItemsOthers.Click
        Dim frm As New formItemMaster

        NewRoleID = "R0007"
        EditRoleID = "R0008"
        PrintRoleID = ""
        SetDataRight(frm, NewRoleID, EditRoleID, PrintRoleID)

        frm.MdiParent = Me
        frm.UserInfo = clsUser
        frm.Show()
    End Sub

    Private Sub PriceListToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles PriceListToolStripMenuItem.Click
        Dim frm As New frmPriceList
        frm.MdiParent = Me
        frm.UserInfo = clsUser
        frm.Show()
    End Sub

    Private Sub menuPurchaseNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menuPurchaseNew.Click
        'If Not (clsUser.DeptCD = "PURCHASING" Or clsUser.DeptCD = "ITC" Or clsUser.DeptCD = "ACC") Then
        '    MessageBox.Show("โปรดติดต่อฝ่ายจัดซื้อ : Please Contact Purchasing ", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        '    Exit Sub
        'End If

        Dim frm As New formPurchaseOrderCreate
        frm.MdiParent = Me
        frm.UserInfo = clsUser
        frm.loginEmpcd = Me.loginEmpcd
        frm.Show()
    End Sub

    Private Sub menuPurchaseEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menuPurchaseEdit.Click
        'If Not (clsUser.DeptCD = "PURCHASING" Or clsUser.DeptCD = "ITC" Or clsUser.DeptCD = "ACC") Then
        '    MessageBox.Show("โปรดติดต่อฝ่ายจัดซื้อ : Please Contact Purchasing ", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        '    Exit Sub
        'End If
        'Dim frm As New frmPurchaseOrderNewEdit
        'frm.MdiParent = Me
        'frm.UserInfo = clsUser
        'frm.Show()

        Dim frm As New formPurchaseOrderEdit3
        frm.MdiParent = Me
        frm.UserInfo = clsUser
        frm.loginEmpcd = Me.loginEmpcd
        frm.Show()
    End Sub

    Private Sub menuPurchaseApprove_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menuPurchaseApprove.Click

        Dim frm As New formPurchaseOrderApprove
        frm.MdiParent = Me
        frm.UserInfo = clsUser
        frm.loginEmpcd = Me.loginEmpcd
        frm.Show()
    End Sub

    Private Sub menuPurchaseCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menuPurchaseCancel.Click
        'If Not (clsUser.DeptCD = "PURCHASING" Or clsUser.DeptCD = "ITC" Or clsUser.DeptCD = "ACC") Then
        '    MessageBox.Show("โปรดติดต่อฝ่ายจัดซื้อ : Please Contact Purchasing ", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        '    Exit Sub
        'End If
        Dim frm As New formPurchaseOrderCancel
        frm.MdiParent = Me
        frm.UserInfo = clsUser
        frm.loginEmpcd = Me.loginEmpcd
        frm.Show()
    End Sub

    Private Sub menuClosePO_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menuClosePO.Click
        'If Not (clsUser.DeptCD = "PURCHASING" Or clsUser.DeptCD = "ITC" Or clsUser.DeptCD = "ACC") Then
        '    MessageBox.Show("โปรดติดต่อฝ่ายจัดซื้อ : Please Contact Purchasing ", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        '    Exit Sub
        'End If
        Dim frm As New frmPOClose
        frm.MdiParent = Me
        frm.UserInfo = clsUser
        frm.Show()
    End Sub

    Private Sub menuReportsPOHistory_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menuReportsPOHistory.Click
        Dim frm As New formPOHistoryReport
        frm.MdiParent = Me
        frm.UserInfo = clsUser
        frm.Show()
    End Sub

    Private Sub menuReportsYarnLatestPrice_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menuReportsYarnLatestPrice.Click
        Dim frm As New frmPrintYarnLatestPrice
        frm.MdiParent = Me
        frm.UserInfo = clsUser
        frm.Show()
    End Sub

    Private Sub POYarnPendingToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles POYarnPendingToolStripMenuItem.Click
        Dim frm As New frmPOYarnPending
        frm.MdiParent = Me
        frm.UserInfo = clsUser
        frm.Show()
    End Sub

    Private Sub YarnInventorySpecificCostToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles YarnInventorySpecificCostToolStripMenuItem.Click
        Dim frm As New frmYarnOnhandCost
        frm.MdiParent = Me
        frm.UserInfo = clsUser
        frm.Show()
    End Sub

    Private Sub POCalendarToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles POCalendarToolStripMenuItem.Click
        Dim frm As New frmPOCalendar
        frm.MdiParent = Me
        frm.UserInfo = clsUser
        frm.Show()
    End Sub

    Private Sub POOntimeToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles POOntimeToolStripMenuItem.Click
        Dim frm As New frmPOOntime
        frm.MdiParent = Me
        frm.UserInfo = clsUser
        frm.Show()
    End Sub

    Private Sub POOntimeByYearToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles POOntimeByYearToolStripMenuItem.Click
        Dim frm As New frmPOOntimeByYear
        frm.MdiParent = Me
        frm.UserInfo = clsUser
        frm.Show()
    End Sub

    Private Sub POImportAnalysisToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles POImportAnalysisToolStripMenuItem.Click
        Dim frm As New frmPOImportAnalysis
        frm.MdiParent = Me
        frm.UserInfo = clsUser
        frm.Show()
    End Sub

    Private Sub POYarnTestReportToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles POYarnTestReportToolStripMenuItem.Click
        Dim frm As New frmPOYarnTest
        frm.MdiParent = Me
        frm.UserInfo = clsUser
        frm.Show()
    End Sub

    Private Sub menuJoborderYarnNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menuJoborderYarnNew.Click
        Dim frm As New formJobOrderforYarn
        frm.MdiParent = Me
        frm.UserInfo = clsUser
        frm.Show()
    End Sub

    Private Sub menuJoborderYarnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menuJoborderYarnEdit.Click
        MessageBox.Show("Under Construction", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
    End Sub

    Private Sub ToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem1.Click
        MessageBox.Show("Under Construction", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
    End Sub

    Private Sub menuJoborderYarnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menuJoborderYarnCancel.Click
        MessageBox.Show("Under Construction", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
    End Sub

    Private Sub menuJoborderOthersNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menuJoborderOthersNew.Click
        MessageBox.Show("Under Construction", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
    End Sub

    Private Sub menuJoborderOthersEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menuJoborderOthersEdit.Click
        MessageBox.Show("Under Construction", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
    End Sub

    Private Sub ToolStripMenuItem3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem3.Click
        MessageBox.Show("Under Construction", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
    End Sub

    Private Sub menuJoborderOthersCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menuJoborderOthersCancel.Click
        MessageBox.Show("Under Construction", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
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

        'Dim frm As New frmChangePassword
        'frm.MdiParent = Me
        'frm.UserInfo = clsUser
        'frm.ShowDialog()
        'clsUser.Password = frm.Password
        'frm.Close()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Tag = "CLOSE"
        Me.Close()
        End
    End Sub

    Private Sub ExchangeRateUSTHBToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExchangeRateUSTHBToolStripMenuItem.Click
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
            TrayIcon.BalloonTipText = "Purchase Order System อยู่ที่นี่"
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

    Private Sub POAllPendingToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles POAllPendingToolStripMenuItem.Click
        Dim frm As New frmPOALLPending
        frm.MdiParent = Me
        frm.UserInfo = clsUser
        frm.Show()
    End Sub

    Private Sub PaidPOToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles PaidPOToolStripMenuItem.Click
        'If Not (clsUser.DeptCD = "PURCHASING" Or clsUser.DeptCD = "ITC" Or clsUser.DeptCD = "ACC") Then
        '    MessageBox.Show("โปรดติดต่อฝ่ายจัดซื้อ : Please Contact Purchasing ", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        '    Exit Sub
        'End If
        Dim frm As New frmPOPaid
        frm.MdiParent = Me
        frm.UserInfo = clsUser
        frm.Show()
    End Sub

    Private Sub tsmnEditBOI_Click(sender As Object, e As EventArgs) Handles menuPurchaseEditBOI.Click
        Dim Ofrm As New frmPurchaseOrderEditBOI
        frmPurchaseOrderEditBOI.Show()
    End Sub

    Private Sub tsmnYarnMasterReport_Click(sender As Object, e As EventArgs) Handles tsmnYarnMasterReport.Click
        Dim frm As New frmRptYarnMaster
        frm.UserInfo = clsUser
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub NewEditToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles menuPurchaseNewedit.Click
        Dim frm As New frmPurchaseOrderNewEdit
        frm.MdiParent = Me
        frm.UserInfo = clsUser
        frm.Show()
    End Sub

    Private Sub menuPrintPO_Click(sender As Object, e As EventArgs) Handles menuPrintPO.Click
        Dim frm As New frmPrintPO
        frm.MdiParent = Me
        frm.UserInfo = clsUser
        frm.Show()
    End Sub

    Private Sub menuMastemnuMasterSupplier_Click_1()

    End Sub
End Class