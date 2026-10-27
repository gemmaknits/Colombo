Public Class FormRptMachineUsage
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
		crvMachine.Top = 40
		crvMachine.Left = 8
		crvMachine.Height = Me.Height - 83
		crvMachine.Width = Me.Width - 25
	End Sub

	Private Sub frmRptMachineUsage_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
		Call ResizeCRV()
	End Sub

	Private Sub frmRptMachineUsage_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize
		Call ResizeCRV()
	End Sub

	Private Sub btnPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrint.Click
		Dim config As New clsConfig
		config.ChangeCulture()

        Dim clsConnection As New classConnection
        Dim rptFileName As String = "rptMachineUsage.rpt"
        Dim frm As New frmReport
        Dim rpt As New CrystalDecisions.CrystalReports.Engine.ReportDocument
        rpt.Load(clsuser.reportpath & rptFileName)
        'Dim rpt As New rptMachineUsage
        rpt.DataSourceConnections.Item(0).SetLogon(clsConnection.UserName, clsConnection.Password)
		rpt.VerifyDatabase()
		rpt.SetParameterValue(0, dtpPrint.Value.ToString("yyyyMMdd"))
		crvMachine.ReportSource = rpt
		crvMachine.Show()
	End Sub
End Class