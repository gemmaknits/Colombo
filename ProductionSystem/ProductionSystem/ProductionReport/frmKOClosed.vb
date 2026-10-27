Public Class frmKOClosed
    Dim clsConn As New classConnection
    Dim clsConfig As New clsConfig
    Dim clsUser As New classUserInfo

    Public Property UserInfo() As classUserInfo
        Get
            UserInfo = clsUser
        End Get
        Set(ByVal NewValue As classUserInfo)
            clsUser = NewValue
        End Set
    End Property

    Private Sub frmKOClosed_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Me.StartPosition = FormStartPosition.CenterScreen
        dtpDateFr.Value = CDate("01" + DateAdd(DateInterval.Month, -1, Now).ToString("/MM/yyyy"))
        dtpDateTo.Value = DateAdd(DateInterval.Day, -1, CDate("01" + Now.ToString("/MM/yyyy")))
    End Sub

    Private Function getRptName()
        'Sitthana 18/5/2018
        Dim result As String = ""

        If optClosedDate.Checked And chkKnitting.Checked Then
            If chkActual.Checked = False Then
                'Closed Date, knitting  -> rptKOClosed
                If rdGrpByOrder.Checked Then
                    result = "rptKOClosed.rpt"
                Else
                    result = "rptKOClosed_ByKO.rpt"
                End If
            Else
                'closed date, knitting, Actual  ->  rptKOClosedActual.rpt
                result = "rptKOClosedActual.rpt"
            End If
        ElseIf optClosedDate.Checked And ChkWarping.Checked Then
            If chkActual.Checked = False Then
                'closed date,  Warping  ->  rptWOClosed.rpt
                result = "rptWOClosed.rpt"
            Else
                'closed date,  Warping , Actual ->  rptKOClosed.rpt
                If rdGrpByOrder.Checked Then
                    result = "rptKOClosed.rpt"
                Else
                    result = "rptKOClosed_ByKO.rpt"
                End If
            End If
        ElseIf (optKODate.Checked) And chkKnitting.Checked Then
            If chkActual.Checked = False Then
                'Production Date, knitting  ->  rptKOClosed.rpt
                If rdGrpByOrder.Checked Then
                    result = "rptKOClosed.rpt"
                Else
                    result = "rptKOClosed_ByKO.rpt"
                End If
            Else
                'Production Date, knitting, Actual  ->  rptKOClosedActual.rpt
                result = "rptKOClosedActual.rpt"
            End If
        ElseIf (optKODate.Checked) And ChkWarping.Checked Then
            If chkActual.Checked = False Then
                'Production Date, Warping   ->  rptWOClosed.rpt
                result = "rptWOClosed.rpt"
            Else
                'Production Date, Warping , Actual 	->   rptKOClosed.rpt
                If rdGrpByOrder.Checked Then
                    result = "rptKOClosed.rpt"
                Else
                    result = "rptKOClosed_ByKO.rpt"
                End If
            End If
        ElseIf optUnclosed.Checked And chkKnitting.Checked Then
            If chkActual.Checked = False Then
                'Unclosed,  knitting    ->   rptKOClosed.rpt
                If rdGrpByOrder.Checked Then
                    result = "rptKOClosed.rpt"
                Else
                    result = "rptKOClosed_ByKO.rpt"
                End If
            Else
                'Unclosed,  knitting, Actual -> rptKOClosedActual.rpt
                result = "rptKOClosedActual.rpt"
            End If
        ElseIf optUnclosed.Checked And ChkWarping.Checked Then
            If chkActual.Checked = False Then
                'Unclosed,  Warping ->   rptWOClosed.rpt
                result = "rptWOClosed.rpt"
            Else
                'Unclosed,  Warping , Actual ->   rptKOClosed.rpt
                If rdGrpByOrder.Checked Then
                    result = "rptKOClosed.rpt"
                Else
                    result = "rptKOClosed_ByKO.rpt"
                End If
            End If
        End If

        Return result
    End Function
    Private Sub btnPrint_Click(sender As System.Object, e As System.EventArgs) Handles btnPrint.Click

        Dim rptFileName As String = "rptKOClosed.rpt"
        'IIf(chkKnitting.Checked = True, rptFileName = "rptKOClosed.rpt", rptFileName = "rptWOClosed.rpt")
        'Comment By Sitthana 18/05/2018, Uncomment 30/05/2018
        If chkKnitting.Checked = True And chkActual.Checked Then rptFileName = "rptKOClosedActual.rpt"
        If ChkWarping.Checked = True Then rptFileName = "rptWOClosed.rpt"
        If ChkWarping.Checked = True And chkActual.Checked Then rptFileName = "rptWOClosedActual.rpt"


        'rptFileName = getRptName() 'Sitthana 18/5/2018, Comment 30/05/2018

        'If clsuser.ReportPath = "" Then clsuser.ReportPath = clsConfig.ReportPath
        If Not clsConfig.CheckReport(clsUser.ReportPath, rptFileName) Then Exit Sub
        Dim frm As New frmReport
        Dim rpt As New CrystalDecisions.CrystalReports.Engine.ReportDocument
        Me.Cursor = Cursors.WaitCursor

        rpt.Load(clsUser.ReportPath & rptFileName)
        rpt.DataSourceConnections.Item(0).SetConnection(clsConn.servername, clsConn.database, False)
        rpt.DataSourceConnections.Item(0).SetLogon(clsConn.Userid, clsConn.Password)
        rpt.VerifyDatabase()

        rpt.SetParameterValue("@date_type", IIf(optClosedDate.Checked, 2, IIf(optKODate.Checked, 1, 3)))
        rpt.SetParameterValue("@datefr", dtpDateFr.Value.ToString("yyyyMMdd"))
        rpt.SetParameterValue("@dateto", dtpDateTo.Value.ToString("yyyyMMdd"))
        rpt.SetParameterValue("@kono", txtKoNo.Text.Trim())
        rpt.SetParameterValue("@design_no", txtDesignNo.Text.Trim())
        rpt.SetParameterValue("@mcno", txtMcNo.Text.Trim())
        rpt.SetParameterValue("@logempcd", clsConfig.IsNull(clsUser.UserID, ""))

        frm.Title = "Greige Daily Production"
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

    Private Sub optClosedDate_CheckedChanged(sender As Object, e As EventArgs) Handles optClosedDate.CheckedChanged
        rdGrpByOrder.Checked = True
        'GrpSortBy.Enabled = False
    End Sub

    Private Sub optUnclosed_CheckedChanged(sender As Object, e As EventArgs) Handles optUnclosed.CheckedChanged
        rdGrpByOrder.Checked = True
        'GrpSortBy.Enabled = True
    End Sub

    Private Sub optKODate_CheckedChanged(sender As Object, e As EventArgs) Handles optKODate.CheckedChanged
        rdGrpByKO.Checked = True
        'GrpSortBy.Enabled = False
    End Sub

End Class