Imports System.globalization
Imports System
Imports System.Text
Imports System.Data.SqlClient

Public Class frmMainmenu

#Region "Properties"
    Dim clsUser As New classUserInfo

    Public Property UserInfo() As classUserInfo
        Get
            UserInfo = clsUser
        End Get
        Set(ByVal NewValue As classUserInfo)
            clsUser = NewValue
        End Set
    End Property
#End Region


    Public loginEmpcd As String
    Private clsConnection As New classConnection

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
        lblConnection.Text = "Server : " + New classConnection().servername + " | " + "Base:" + New classConnection().database

        Dim culture As CultureInfo
        culture = CultureInfo.CurrentCulture
        If UCase(culture.DisplayName) <> "ENGLISH (UNITED KINGDOM)" Then
            'MsgBox("Select change your regional settings to English United Kingdom")
            'Me.Close()
            My.Application.ChangeCulture("en-GB")
            My.Application.ChangeUICulture("en-GB")
        End If

        If Not System.Diagnostics.Debugger.IsAttached Then
            Me.Text = Me.Text & " Version " & My.Application.Deployment.CurrentVersion.ToString
            'Else
            '    If Not System.IO.File.Exists(clsUser.ReportPath) And Not System.IO.File.Exists(clsConfig.ReportPath) Then
            '        clsUser.ReportPath = "C:\Users\DELL\Desktop\"
            '    End If
        End If
        Me.ContextMenu = TrayMenu
        TrayIcon.Icon = Me.Icon
        TrayIcon.Visible = False
        TrayIcon.ContextMenu = TrayMenu
        TrayIcon.Text = "Production System"

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
    End Sub

    Private Sub frmMainmenu_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Me.Tag = "CLOSE"

        Dim obj As Form
        For Each obj In Me.MdiChildren
            obj.Close()
        Next

        Call TakeLogOut()

        If Not IsNothing(TrayIcon) Then
            TrayIcon.Dispose()
        End If

        Application.Exit() 'End
    End Sub

    Private Sub MachinesToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles MachinesToolStripMenuItem.Click
        Dim frm As New frmMachine
        frm.UserInfo = clsUser
        frm.MdiParent = Me
        frm.Show()
    End Sub
    Private Sub tsmnMachinesMaster_Click(sender As Object, e As EventArgs) Handles tsmnMachinesMaster.Click
        Dim frm As New frmMachinesMaster
        frm.UserInfo = clsUser
        frm.MdiParent = Me
        frm.Show()
    End Sub
    Private Sub EditToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles EditToolStripMenuItem.Click
        'Sitthana 13/03/2018
        Dim frm As New frmDesignNew

        'R0003	  Edit design master
        'R0004	  View Design master
        Dim objDB As New clsConfig
        Dim dt As New DataTable
        dt = objDB.getUserRoleRight(clsUser.UserID, "")

        frm.AllowNew = False
        frm.AllowEdit = False
        If dt.Rows.Count > 0 Then
            For i As Integer = 0 To dt.Rows.Count - 1
                Select Case dt.Rows(i).Item("Roleid").ToString.Trim
                    Case "R0003"
                        frm.AllowNew = True
                        frm.AllowEdit = True
                    Case "R0004"
                        frm.AllowNew = False
                        frm.AllowEdit = False
                End Select
            Next
        End If

        frm.MdiParent = Me
        frm.UserInfo = UserInfo
        frm.Show()
    End Sub

    Private Sub ViewToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs)
        'Sitthana 13/03/2018
        Dim frm As New frmDesignNew

        'R0003	  Edit design master
        'R0004	  View Design master
        Dim objDB As New clsConfig
        Dim dt As New DataTable
        dt = objDB.getUserRoleRight(clsUser.UserID, "")

        frm.AllowNew = False
        frm.AllowEdit = False
        If dt.Rows.Count > 0 Then
            For i As Integer = 0 To dt.Rows.Count - 1
                Select Case dt.Rows(i).Item("Roleid").ToString.Trim
                    Case "R0003"
                        frm.AllowNew = True
                        frm.AllowEdit = True
                    Case "R0004"
                        frm.AllowNew = False
                        frm.AllowEdit = False
                End Select
            Next
        End If

        frm.MdiParent = Me
        frm.UserInfo = UserInfo
        frm.Show()
    End Sub

    Private Sub CompositionGroupToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles CompositionGroupToolStripMenuItem.Click
        Dim frm As New frmCompositionGroup
        frm.UserInfo = clsUser
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub DesignBOMToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs)
        Dim frm As New frmDesignBOM
        frm.UserInfo = clsUser
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub KnittingOrderKIKOKPToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles KnittingOrderKIKOKPToolStripMenuItem.Click
        Dim frm As New frmKnittingOrderNew
        frm.UserInfo = clsUser
        frm.MdiParent = Me
        frm.Show()
    End Sub

    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub KOSchedulePlanToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles menuKOSchedulePlanToolStripMenuItem.Click
        Dim frm As New frmKOSchedulePlan
        frm.UserInfo = clsUser
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub MachineCapacityToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles MachineCapacityToolStripMenuItem.Click
        Dim frm As New frmMachineCapacity
        frm.UserInfo = clsUser
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub KOYarnReturnToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles KOYarnReturnToolStripMenuItem.Click
        Dim frm As New frmKOYarnReturn
        frm.UserInfo = clsUser
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub TransferYarnToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TransferYarnToolStripMenuItem.Click
        Dim frm As New frmTransferYarn
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

    Private Sub DesignNoBOMToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles tsmnBOM.Click

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

    Private Sub PDRToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles PDRToolStripMenuItem.Click
        Dim frm As New frmPDR
        frm.UserInfo = clsUser
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub DRToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs)
        'Dim frm As New frmDR
        'frm.UserInfo = clsUser
        'frm.MdiParent = Me
        'frm.Show()
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
            TrayIcon.BalloonTipText = "Production System อยู่ที่นี่"
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
        Dim objSecurity As New clsConfig
        'Dim objSecurity As New classSecurity
        'objSecurity.LoadMenus(UserInfo.UserID)

        Me.menuKOSchedulePlanToolStripMenuItem.Enabled = objSecurity.UserAccess(UserInfo.UserID, "PLN001", "MENU")
        Me.menuYarnDemandForecast.Enabled = objSecurity.UserAccess(UserInfo.UserID, "PLN002", "MENU")
        Me.menuYarnDemandPlanningToolStripMenuItem.Enabled = objSecurity.UserAccess(UserInfo.UserID, "PLN003", "MENU")


        Me.menuGreigeINKnitting.Enabled = objSecurity.UserAccess(UserInfo.UserID, "PD0035", "MENU")
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



    Private Sub YarnBOMToolStripMenuItem_Click(sender As Object, e As EventArgs)
        MessageBox.Show("Under Construction", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub GreigeBOMToolStripMenuItem_Click(sender As Object, e As EventArgs)
        MessageBox.Show("Under Construction", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub KOCalendarToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles KOCalendarMenuItem.Click
        Dim frm As New frmKOCalendar
        frm.MdiParent = Me
        frm.UserInfo = clsUser
        frm.Show()
    End Sub

    Private Sub KOPendingToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles KOPendingToolStripMenuItem.Click
        Dim frm As New frmKOPending
        frm.MdiParent = Me
        frm.UserInfo = clsUser
        frm.Show()
    End Sub

    Private Sub KOOntimeToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles KOOntimeToolStripMenuItem.Click
        Dim frm As New frmKOOntime
        frm.MdiParent = Me
        frm.UserInfo = clsUser
        frm.Show()
    End Sub

    Private Sub GreigeDailyCapToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles GreigeDailyCapToolStripMenuItem.Click
        Dim frm As New frmGreigeDailyCapacity
        frm.MdiParent = Me
        frm.UserInfo = clsUser
        frm.Show()
    End Sub

    Private Sub LostByKOINWeekToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs)

    End Sub

    Private Sub WOClosedReportToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs)
        Dim frm As New frmWOClosed
        frm.MdiParent = Me
        frm.UserInfo = clsUser
        frm.Show()
    End Sub

    Private Sub OperationsMasterToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles OperationsMasterToolStripMenuItem.Click
        Dim frm As New frmOperationsMaster
        frm.UserInfo = clsUser
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub RoutingMasterToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles RoutingMasterToolStripMenuItem.Click
        Dim frm As New frmRoutingMaster
        frm.UserInfo = clsUser
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub OperationStepToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles OperationStepToolStripMenuItem.Click
        Dim frm As New frmOperationKnitting
        frm.UserInfo = clsUser
        frm.MdiParent = Me
        frm.Show()
    End Sub
    Private Sub OperationStepKNITTINGNEWToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OperationStepKNITTINGNEWToolStripMenuItem.Click '29/09/2025 John
        Dim frm As New frmOperationKnittingNEW
        frm.UserInfo = clsUser
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub OperationStepWarpingToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles OperationStepWarpingToolStripMenuItem.Click
        Dim frm As New frmOperationWarp
        frm.UserInfo = clsUser
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub GreigeINKnittingToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles menuGreigeINKnitting.Click
        Dim frm As New frmStockGIN_KOManualIndex
        frm.UserInfo = clsUser
        frm.MdiParent = Me
        frm.Show()

    End Sub

    Private Sub ProductionPendingToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ProductionPendingToolStripMenuItem.Click

    End Sub
    Private Sub tsmnProductionWarpPending_Click(sender As Object, e As EventArgs) Handles tsmnProductionWarpPending.Click
        Dim frm As New frmProductionPending
        frm.UserInfo = clsUser
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub tsmnWarpingProductionReport_Click(sender As Object, e As EventArgs) Handles tsmnWarpingProductionReport.Click
        Dim frm As New frmProductionLotsPending
        frm.UserInfo = clsUser
        frm.MdiParent = Me
        frm.Show()
    End Sub
    Private Sub menuYarnDemandForecastToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles menuYarnDemandForecast.Click
        Dim frm As New frmYarnDemandForecast
        frm.UserInfo = clsUser
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub YarnDemandDailyToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles YarnDemandDailyToolStripMenuItem.Click
        Dim frm As New frmYarnDemandForecastDaily
        frm.UserInfo = clsUser
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub YarnDemandForecastSummaryToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles YarnDemandForecastSummaryToolStripMenuItem.Click
        Dim frm As New frmYarnDemandForecastSummary
        frm.UserInfo = clsUser
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub menuYarnDemandPlanningToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles menuYarnDemandPlanningToolStripMenuItem.Click
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

    Private Sub DesignToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DesignToolStripMenuItem.Click

    End Sub

    Private Sub WarpingPendingWarpInToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles WarpingPendingWarpInToolStripMenuItem.Click
        Dim frm As New frmWarpingPendingWarpIn
        frm.UserInfo = clsUser
        frm.MdiParent = Me
        frm.Show()

    End Sub

    Private Sub ProductionOrderNewToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProductionOrderNewToolStripMenuItem.Click
        Dim frm As New frmKnittingOrderNew
        frm.UserInfo = clsUser
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub DesignMasterNewToolStripMenuItem_Click(sender As Object, e As EventArgs)
        'Sitthana 13/03/2018
        Dim frm As New frmDesignNew

        'R0003	  Edit design master
        'R0004	  View Design master
        Dim objDB As New clsConfig
        Dim dt As New DataTable
        dt = objDB.getUserRoleRight(clsUser.UserID, "")

        frm.AllowNew = False
        frm.AllowEdit = False
        If dt.Rows.Count > 0 Then
            For i As Integer = 0 To dt.Rows.Count - 1
                Select Case dt.Rows(i).Item("Roleid").ToString.Trim
                    Case "R0003"
                        frm.AllowNew = True
                        frm.AllowEdit = True
                    Case "R0004"
                        frm.AllowNew = False
                        frm.AllowEdit = False
                End Select
            Next
        End If

        frm.MdiParent = Me
        frm.UserInfo = UserInfo
        frm.Show()
    End Sub

    Private Sub DesisgnBOMWithColorwayToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DesisgnBOMWithColorwayToolStripMenuItem.Click
        'Copy By Sitthana 23/12/2017
        Dim frm As New frmDesignBOMNew
        frm.UserInfo = clsUser
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub ProductionReservationsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProductionReservationsToolStripMenuItem.Click
        Dim frm As New frmWOReservations
        frm.UserInfo = clsUser
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub tsmnDRNew_Click(sender As Object, e As EventArgs) Handles tsmnDRNew.Click
        Dim frm As New frmDR2
        frm.UserInfo = clsUser
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub RDToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RDToolStripMenuItem.Click

    End Sub

    Private Sub ReportsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReportsToolStripMenuItem.Click

    End Sub

    Private Sub ProductionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProductionToolStripMenuItem.Click

    End Sub

    Private Sub DefectKNITTINGToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GreigeLossToolStripMenuItem.Click
        Dim frm As New frmStockGreigeLoss
        frm.UserInfo = clsUser
        frm.MdiParent = Me
        frm.Show()

    End Sub

    Private Sub ProductionTargetToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProductionTargetToolStripMenuItem.Click
        Dim frmCustRevenueTarget As New STV.frmCustRevenueTarget
        frmCustRevenueTarget.Show()
    End Sub

    Private Sub tsmnLookupValue_Click(sender As Object, e As EventArgs) Handles tsmnLookupValue.Click
        'Sitthana 20240201 Copy From GMK
        Dim frm As New frmLookup
        frm.UserInfo = clsUser
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub RDSsProductionReportToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RDSsProductionReportToolStripMenuItem.Click
        Dim frm As New frmRDSsProductionReport
        frm.UserInfo = clsUser
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub GreigeOutputByMCToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GreigeOutputByMCToolStripMenuItem.Click
        Dim frm As New frmGreigeSummaryByMC
        frm.UserInfo = clsUser
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub BeamControlReortToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BeamControlReortToolStripMenuItem.Click
        Dim frm As New FrmBeamControlReport
        frm.UserInfo = clsUser
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub tsmnDesignNoBom_Click(sender As Object, e As EventArgs) Handles tsmnDesignNoBom.Click
        Dim frm As New frmDesignNoBOM
        frm.UserInfo = clsUser
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub tsmnFindDesignFromYarn_Click(sender As Object, e As EventArgs) Handles tsmnFindDesignFromYarn.Click
        Dim frm As New frmfindDesignFromYarn
        frm.UserInfo = clsUser
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub tsmnTDS_Click(sender As Object, e As EventArgs) Handles tsmnTDS.Click
        'Sitthana 20200131


        'Dim frmCollection As New FormCollection()
        'frmCollection = Application.OpenForms()
        'If frmCollection.key = "frmQASpec" Then

        'End If

        'If frmCollection.Item("frmQASpec").IsHandleCreated Then
        '    frmCollection.Item("frmQASpec").Focus()
        '    MessageBox.Show("opened")
        'Else
        Dim objfrm = New STV.frmQASpec
        objfrm.SiteName = "Eschler"
        objfrm.logempcd = clsUser.UserID
        objfrm.Show()
        'End If

    End Sub

    Private Sub tsmnDesignMasterSpecificatoinList_Click(sender As Object, e As EventArgs) Handles tsmnDesignMasterSpecificatoinList.Click
        Dim frm As New frnDesignMasterSpecificationList
        frm.clsUser = clsUser
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub tsmnDesignMasterList_Click(sender As Object, e As EventArgs) Handles tsmnDesignMasterList.Click
        Dim frm As New frmDesignMasterReport
        frm.UserInfo = clsUser
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub tsmnDesignMasterReport_Click(sender As Object, e As EventArgs) Handles tsmnDesignMasterReport.Click
        'Writen By : Sitthana Boonlom 20200622
        Dim frm As New FrmMasterReport
        frm.UserInfo = clsUser
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub tsmnCostRollup_Click(sender As Object, e As EventArgs) Handles tsmnCostRollup.Click
        'Writen By : Sitthana Boonlom 20200902
        Dim frm As New frmCostRollup
        frm.UserInfo = clsUser
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub tsmnDesignDocumentAttachment_Click(sender As Object, e As EventArgs) Handles tsmnDesignDocumentAttachment.Click
        'Sitthana 20200928
        Dim frm As New STV.frmDocAttRpt ' frmDocAttachments
        frm.SystemName = "PRODUCTION" 'PURCHASE, PRODUCTION
        frm.Show()
    End Sub

    Private Sub tsmnProductOperation_Click(sender As Object, e As EventArgs) Handles tsmnProductOperation.Click
        'Sitthana 20210722
        Dim frm As New frmProductOperation
        frm.UserInfo = clsUser
        frm.Show()
    End Sub

    Private Sub WarpingOrderToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles WarpingOrderToolStripMenuItem.Click
        Dim frm As New frmKnittingOrderNew
        frm.UserInfo = clsUser
        frm.pProductionOrderTypeCode = "WONO"
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub KnittingOrderToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles KnittingOrderToolStripMenuItem.Click
        Dim frm As New frmKnittingOrderNew
        frm.UserInfo = clsUser
        frm.pProductionOrderTypeCode = "KINO"
        frm.MdiParent = Me
        frm.Show()
    End Sub
End Class