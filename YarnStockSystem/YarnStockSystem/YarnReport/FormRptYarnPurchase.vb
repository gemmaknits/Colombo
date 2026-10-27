Public Class FormRptYarnPurchase
	Dim empcd As String = ""
    Dim clsUser As New classUserInfo
    Public Property UserInfo() As classUserInfo
        Get
            UserInfo = clsUser
        End Get
        Set(ByVal NewValue As classUserInfo)
            clsUser = NewValue
        End Set
    End Property
    Public Property loginEmpcd() As String
		Get
			loginEmpcd = empcd
		End Get
		Set(ByVal NewValue As String)
			empcd = NewValue
		End Set
	End Property

	Private Sub ResizeCRV()
		crvYarnUsed.Top = 40
		crvYarnUsed.Left = 8
		crvYarnUsed.Height = Me.Height - 83
		crvYarnUsed.Width = Me.Width - 25
	End Sub

	Private Sub FormRptYarnPurchase_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
		Call ResizeCRV()
	End Sub

	Private Sub FormRptYarnPurchase_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize
		Call ResizeCRV()
	End Sub

	Private Sub btnPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrint.Click
		Dim config As New clsConfig
		Dim classCn As New classConnection
		config.ChangeCulture()

		btnPrint.Enabled = False
        Me.Cursor = Cursors.WaitCursor

        Dim rptFileName As String = "rptYarnPurchase.rpt"
        Dim frm As New frmReport
        Dim rpt As New CrystalDecisions.CrystalReports.Engine.ReportDocument
        rpt.Load(clsuser.reportpath & rptFileName)
        'Dim rpt As New rptYarnPurchase
        rpt.DataSourceConnections.Item(0).SetConnection(classCn.servername, classCn.Database, False)
        rpt.DataSourceConnections.Item(0).SetLogon(classCn.UserName, classCn.Password)

		rpt.VerifyDatabase()
		rpt.SetParameterValue(0, Mid(dtpPrint.Value.ToString("yyyyMMdd"), 1, 6))
		crvYarnUsed.ReportSource = rpt
		crvYarnUsed.Zoom(75)
		crvYarnUsed.Show()
		Me.Cursor = Cursors.Default
		btnPrint.Enabled = True
	End Sub
End Class