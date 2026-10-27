Public Class frmDesignNoBOM
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

    Private Sub frmDesignNoBOM_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Me.StartPosition = FormStartPosition.CenterScreen
    End Sub

    Private Sub btnPrint_Click(sender As System.Object, e As System.EventArgs) Handles btnPrint.Click
        If rbDesignNo.Checked Then
            If txtDesignNo.Text = "" Then
                MessageBox.Show("คุณเลือก จะดูรายงานตาม Designs No ดังนั้น Designs No จะปล่อยว่างไม่ได้ครับ", "ข้อผิดพลาด", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                Dim rptFileName = "rptDesignNoBOM.rpt"
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

                frm.Title = "Design No. BOM"
                frm.CRViewer.ReportSource = rpt
                frm.MdiParent = Me.ParentForm
                frm.Show()
                Me.Cursor = Cursors.Default
            End If
        ElseIf rbItemsNo.Checked Then
            If txtItcd.Text = "" Then
                MessageBox.Show("คุณเลือก จะดูรายงานตาม Items No ดังนั้น Items No จะปล่อยว่างไม่ได้ครับ", "ข้อผิดพลาด", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                Dim rptFileName = "rptDesignNoBOMByItems.rpt"
                'If clsuser.ReportPath = "" Then clsuser.ReportPath = clsConfig.ReportPath
                If Not clsConfig.CheckReport(clsUser.ReportPath, rptFileName) Then Exit Sub
                Dim frm As New frmReport
                Dim rpt As New CrystalDecisions.CrystalReports.Engine.ReportDocument
                Me.Cursor = Cursors.WaitCursor

                rpt.Load(clsUser.ReportPath & rptFileName)
                rpt.DataSourceConnections.Item(0).SetConnection(clsConn.servername, clsConn.database, False)
                rpt.DataSourceConnections.Item(0).SetLogon(clsConn.Userid, clsConn.Password)
                rpt.VerifyDatabase()
                rpt.SetParameterValue("@itcd", txtItcd.Text.Trim())
                rpt.SetParameterValue("@logempcd", clsConfig.IsNull(clsUser.UserID, ""))

                frm.Title = "Design No. BOM"
                frm.CRViewer.ReportSource = rpt
                frm.MdiParent = Me.ParentForm
                frm.Show()
                Me.Cursor = Cursors.Default
            End If
        End If

    End Sub

    Private Sub btnMinimized_Click(sender As System.Object, e As System.EventArgs) Handles btnMinimized.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub btnExit_Click(sender As System.Object, e As System.EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub txtDesignNo_GotFocus(sender As Object, e As System.EventArgs) Handles txtDesignNo.GotFocus
        txtItcd.Text = ""
    End Sub

    Private Sub txtDesignNo_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles txtDesignNo.KeyDown
        If e.KeyCode = Keys.Enter Then
            btnPrint_Click(sender, e)

        End If
    End Sub

    Private Sub txtDesignNo_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtDesignNo.TextChanged
        'txtItcd.Text = ""
    End Sub

    Private Sub txtItcd_GotFocus(sender As Object, e As System.EventArgs) Handles txtItcd.GotFocus
        txtDesignNo.Text = ""
    End Sub

    Private Sub txtItcd_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles txtItcd.KeyDown
        If e.KeyCode = Keys.Enter Then
            btnPrint_Click(sender, e)

        End If
    End Sub

    Private Sub txtItcd_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtItcd.KeyPress

    End Sub

    Private Sub txtItcd_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtItcd.TextChanged
        'txtDesignNo.Text = ""
    End Sub

    Private Sub getYarnCodeDescpAndAssignValueToText(objYarnCode As Object, objYarnDescp As Object)
        'Sitthana 20191109
        Dim f As New Classes.formSearchItemcode
        Dim drv As DataRowView
        Dim SearchResult As New Classes.SearchFormResult

        ' pass nothing to use default connection string inside the class or pass your connection object if need to use different from default.
        f.setConnectionString(clsConn.getSQLConnection)
        f.ItemNatureCD = "YARNS"

        SearchResult = f.ShowItems
        f.Close()
        f.Dispose()
        If SearchResult.ButtonClicked = "OK" Then
            drv = SearchResult.ResultRowView
            If IsNothing(SearchResult.ResultRowView) Then
                MessageBox.Show("Not select data", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                objYarnCode.Text = drv.Item("itcd")
                objYarnDescp.Text = drv.Item("itdesc")
            End If
        End If
    End Sub
    Private Sub btnGetYarnCodeNo1_Click(sender As Object, e As EventArgs) Handles btnGetYarnCodeNo1.Click
        getYarnCodeDescpAndAssignValueToText(txtItcd, txtYarnDescpNo1)
    End Sub
End Class