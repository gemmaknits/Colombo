Public Class tbl_job
	Public jobno As String = ""
	Public jobdt As Date = Today()
	Public suppcd As String = ""
	Public reqno As String = ""
	Public kono As String = ""
	Public jobtype As String = ""
	Public jobitcd As String = ""
	Public tubeqty As Double = 0
	Public tubekg As Double = 0
	Public twists As String = ""
	Public col As String = ""
	Public packcd As String = ""
	Public splins As String = ""
	Public remark As String = ""
	Public jobfor As String = ""
	Public import As Integer = 0
	Public curr As String = ""
	Public exrt As Double = 0
	Public vat As Double = 0
	Public vatamt As Double = 0
	Public taxper As Double = 0
	Public taxamt As Double = 0
	Public freight As Double = 0
	Public insurance As Double = 0
	Public otheramt As Double = 0
	Public other_text As String = ""
	Public totamt As Double = 0
	Public cancel_status As Integer = 0

	Public supquoteno As String = ""
	Public sourcedocno As String = ""
	Public supplang As String = ""
	Public empcd As String = ""
	Public deptcd As String = ""
	Public delidays As Integer = 0
	Public delidt As Date = "01/01/1900"
	Public crterm As String = ""
	Public crdays As Integer = 0
	Public crdesc As String = ""
	Public paymodecd As String = ""
	Public shipvia As String = ""
	Public discper As Double = 0
	Public discamt As Double = 0
	Public shipping As Integer = 0
	Public handling As Integer = 0
	Public shipterms As Integer = 0
	Public deliaddr As String = ""

	Public tbl_job_det() As tbl_job_det
	Public tbl_job_det_yarn() As tbl_job_det_yarn

	Public cancel_date As Date = "01/01/1900"
	Public tstamp As Date = Today()
	Public approve_status As Integer
	Public approve_date As Date = "01/01/1900"
	Public rem_app As String = ""
	Public rem_cancel As String = ""
	Public present_status As String = ""
End Class
