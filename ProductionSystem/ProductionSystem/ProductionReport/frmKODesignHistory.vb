Public Class frmKODesignHistory
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

    Private Sub frmKODesignHistory_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnPrint_Click(sender As System.Object, e As System.EventArgs) Handles btnPrint.Click
        Dim rptFileName = "rptKODesignHistory.rpt"
        'If clsuser.ReportPath = "" Then clsuser.ReportPath = clsConfig.ReportPath
        If Not clsConfig.CheckReport(clsUser.ReportPath, rptFileName) Then Exit Sub
        Dim frm As New frmReport
        Dim rpt As New CrystalDecisions.CrystalReports.Engine.ReportDocument
        Me.Cursor = Cursors.WaitCursor

        rpt.Load(clsUser.ReportPath & rptFileName)
        rpt.DataSourceConnections.Item(0).SetConnection(clsConn.servername, clsConn.database, False)
        rpt.DataSourceConnections.Item(0).SetLogon(clsConn.Userid, clsConn.Password)
        rpt.VerifyDatabase()
        rpt.SetParameterValue("@design_no", txtDesignNo.Text.Trim())
        rpt.SetParameterValue("@logempcd", clsConfig.IsNull(clsUser.UserID, ""))

        frm.Title = "K/O Design History"
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

    Private Sub btnSearchDesign_Click(sender As Object, e As EventArgs) Handles btnSearchDesign.Click
        'Sitthana 20220124
        Dim f As New Classes.FrmSearchDesign
        Dim drv As DataRowView
        Dim SearchResult As New Classes.SearchFormResult

        ' pass nothing to use default connection string inside the class or pass your connection object if need to use different from default.
        f.setConnectionString(clsConn.getSQLConnection)
        f.logempcd = "Sitthana"
        f.DesignNo = "" '"204823"

        SearchResult = f.ShowFrm
        f.Close()
        f.Dispose()
        If SearchResult.ButtonClicked = "OK" Then
            drv = SearchResult.ResultRowView
            If IsNothing(SearchResult.ResultRowView) Then
                MessageBox.Show("Not select data", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                txtDesignNo.Text = drv.Item("design_no")
                txtDesignDescp.Text = clsConfig.IsNull(drv.Item("refdesno"), "").ToString.Trim & "  " & clsConfig.IsNull(drv.Item("compo"), "").ToString.Trim
            End If
        End If
    End Sub

    Private Sub txtDesignDescp_TextChanged(sender As Object, e As EventArgs) Handles txtDesignDescp.TextChanged

    End Sub
End Class