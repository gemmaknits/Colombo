Public Class tbl_job
	'Public jobno As String = ""
	'Public jobdt As String = ""
	'Public suppcd As String = ""
	'Public reqno As String = ""
	'Public jobtype As String = ""
	'Public jobitcd As String = ""
	'Public tubeqty As Double
	'Public tubekg As Double
	'Public twists As String = ""
	'Public col As String = ""
	'Public splins As String = ""
	'Public remark As String = ""
	'Public jobfor As String = ""
	'Public import As Integer
	'Public curr As String = ""
	'Public exrt As Double
	'Public vat As Double
	'Public vatamt As Double
	'Public taxper As Double
	'Public taxamt As Double
	'Public freight As Double
	'Public insurance As Double
	'Public otheramt As Double
	'Public other_text As String = ""
	'Public totamt As Double
	'Public cancel_status As Integer

	'Public tbl_job_det() As tbl_job_det
	'Public tbl_job_det_yarn() As tbl_job_det_yarn


	Public jobno As String = ""
	Public jobdt As String = ""
	Public suppcd As String = ""
	Public supquoteno As String = ""
	Public sourcedocno As String = ""
	Public Empcd As String = ""
	Public Deptcd As String = ""
	Public reqno As String = ""
    Public delidays As String = ""
	Public delidt As String = ""
	Public crterm As String = ""
	Public crdays As Integer = 0
	Public crdesc As String = ""
	Public shipvia As String = ""
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

    Public gross_amt As Double = 0
    Public line_discamt As Double = 0
    Public net_lineamt As Double = 0
    Public discper As Double = 0
	Public discamt As Double = 0
    Public vat As Double = 0
	Public vatamt As Double = 0
	Public taxper As Double = 0
    Public taxamt As Double = 0
    Public total_discamt As Double = 0


    Public totamt As Double = 0
    Public netamt As Double = 0

	Public shipping As Double = 0
	Public freight As Double = 0
	Public insurance As Double = 0
	Public handling As Double = 0
	Public otheramt As Double = 0
	Public other_text As String = ""


	Public cancel_status As Integer
	Public shipterms As String = ""
	Public deliaddr As String = ""

	Public tbl_job_det() As tbl_job_det
	Public tbl_job_det_yarn() As tbl_job_det_yarn

	Public supplang As String = ""
	Public kono As String = ""
	Public paymodecd As String = ""
	Public cancel_date As Date = "01/01/1900"
	Public tstamp As Date = Today()
	Public approve_status As Integer
	Public approve_date As Date = "01/01/1900"
	Public rem_app As String = ""
	Public rem_cancel As String = ""
    Public present_status As String = ""
    Public itnaturecd As String = ""

    Public benefit As String = ""
    Public approved_period As String = ""
    Public vehicle_name As String = ""
    Public port_name As String = ""
    Public agency_name As String = ""
    Public benefit_amount As Double = 0


    Public payment_term As String = ""
    Public lc_no As String = ""
    Public lc_date As String = ""
    Public quotation_no As String = ""
    Public quotation_date As String = ""
    Public packing_no As String = ""
    Public invoice_no As String = ""
    Public bl_no As String = ""
    Public estimate_departure As String = ""
    Public estimate_arrival As String = ""
    Public packing_remark As String = ""
    Public benefit_kgs As Double = 0

    Public packing_date As Nullable(Of DateTime)
    Public invoice_date As Nullable(Of DateTime)
    Public bl_date As Nullable(Of DateTime)
    Public awb_no As String = String.Empty
    Public awb_date As Nullable(Of DateTime)
    Public awb_received_date As Nullable(Of DateTime)

    Public sell_back_to_vendor As Nullable(Of Boolean)
    Public rcv_warehouse_id As Nullable(Of Int64)
    Public rcv_subinventory_id As Nullable(Of Int64)

End Class
