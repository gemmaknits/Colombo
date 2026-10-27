Imports System.Data
Imports System.Data.SqlClient
Imports System.Text


Public Class classPurchaseEdit
    Private connStr As New classConnection

    Public Structure PurchaseHeader
        Dim h01_itnaturecd As String
        Dim h02_delidt As String
        Dim h03_splins As String
        Dim h04_exrt As String
        Dim h05_vat As String
        Dim h06_discper_h As String
        Dim h07_shipvia As String
        Dim h08_shipterms As String
        Dim h09_supquoteno As String
        Dim h10_crdays As String
        Dim h11_crterm As String
        Dim h12_reqno As String
        Dim h13_rem As String
        Dim h14_splins As Double
        Dim h15_Empcd As String
        Dim h16_deptcd As String
        Dim h17_suppcd As String
        Dim h18_curr As String
        Dim h19_jobdt As String
        Dim h20_benefit As String
        Dim h21_approve_period As String
        Dim h22_vehicle_name As String
        Dim h23_port_name As String
        Dim h24_agency_name As String
        Dim h25_benefit_amount As String
        Dim h26_packing_no As String
        Dim h27_invoice_no As String
        Dim h28_bl_no As String
        Dim h29_packing_remark As String
        Dim h30_estimate_departure As String
        Dim h31_estimate_arrival As String
        Dim h32_benefit_kgs As String

    End Structure

    Public Function Validate_PO(Optional ByVal StrPONO As String = "", Optional ByVal StrEMPCD As String = "") As DataTable
        Dim conn As New SqlConnection((New classConnection).connection)
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure

        comm.CommandText = "p_po_edit_select_po_validate"

        comm.Parameters.AddWithValue("@pono", StrPONO)
        comm.Parameters.AddWithValue("@logempcd", StrEMPCD)
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        conn.Close()  'Sitthana 20190325
        Return (dt)
    End Function
End Class
