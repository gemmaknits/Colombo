'ADD BY NEUNG 03/02/2015
Imports System.Data
Imports System.Data.SqlClient
Imports System.Text

Public Class FormPurchaseOrderEdit5
    Dim blnCancel As Boolean = False
    'classUserInfo
    Dim clsUser As New classUserInfo
    'loginEmpcd
    Public loginEmpcd As String

    Public Property UserInfo() As classUserInfo
        Get
            UserInfo = clsUser
        End Get
        Set(ByVal NewValue As classUserInfo)
            clsUser = NewValue
        End Set
    End Property

    Private Sub buttonSearchPO_Click(sender As System.Object, e As System.EventArgs) Handles buttonSearchPO.Click
        Dim frm As New frmSearchPO2
        frm.ShowDialog(Me)
        SaveDF()
        Me.Cursor = Cursors.WaitCursor
        If Not blnCancel Then LoadData(frm.pPONo)
        Me.Cursor = Cursors.Default
        frm.Dispose()
    End Sub

    Private Sub LoadData(ByVal PONo As String)
        Dim objDB As New classPurchase
        Dim dt As New DataTable
        dt = objDB.PODetLoad(PONo)
        Call BindGridPO(dt)
        Call SumGridPO()
        If dt.Rows.Count > 0 Then Call BindData(dt)
    End Sub

    Private Sub BindGridPO(ByVal dt As DataTable)
       
    End Sub

    Private Sub SumGridPO()

    End Sub



    Private Sub SaveDF()

    End Sub
    Private Sub BindData(ByVal dt As DataTable)

        cboItemNature.SelectedValue = dt.Rows(0).Item("itnaturecd")
        Me.DtDileveryDate.Text = dt.Rows(0).Item("delidt")
        Me.txtpackcd.Text = dt.Rows(0).Item("splins")
        Me.txtremark.Text = dt.Rows(0).Item("splins")
        Me.txtrate.Text = dt.Rows(0).Item("exrt")
        Me.txtVat.Text = dt.Rows(0).Item("vat")
        Me.txtDisper.Text = dt.Rows(0).Item("discper_h")
        Me.txtShipvia.Text = dt.Rows(0).Item("shipvia")
        Me.textShipterms.Text = dt.Rows(0).Item("shipterms")
        Me.textSupQuoteno.Text = dt.Rows(0).Item("supquoteno").ToString.Trim
        Me.txtcredit.Text = dt.Rows(0).Item("crdays")
        Me.cboCredit.Text = dt.Rows(0).Item("crterm").ToString
        Me.textReqno.Text = dt.Rows(0).Item("reqno").ToString
        Me.txtremark.Text = dt.Rows(0).Item("rem").ToString
        Me.txtpackcd.Text = dt.Rows(0).Item("splins").ToString
        Me.cboEmp.SelectedValue = dt.Rows(0).Item("Empcd").ToString
        Me.cboDept.SelectedValue = dt.Rows(0).Item("deptcd").ToString
        Me.cboSupplier.SelectedValue = dt.Rows(0).Item("suppcd").ToString
        Me.cboCurrency.SelectedValue = dt.Rows(0).Item("curr").ToString.Trim
        Me.DateYIN.Value = dt.Rows(0).Item("jobdt").ToString.Trim

        txtBenefit.Text = dt.Rows(0).Item("benefit").ToString.Trim
        txtPeriod.Text = dt.Rows(0).Item("approve_period").ToString.Trim
        txtVehicleName.Text = dt.Rows(0).Item("vehicle_name").ToString.Trim
        txtPortName.Text = dt.Rows(0).Item("port_name").ToString.Trim
        txtAgencyName.Text = dt.Rows(0).Item("agency_name").ToString.Trim
        txtBenefitAmount.Text = dt.Rows(0).Item("benefit_amount").ToString.Trim

        txtPackingNo.Text = dt.Rows(0).Item("packing_no").ToString
        txtInvoiceNo.Text = dt.Rows(0).Item("invoice_no").ToString
        txtBLNo.Text = dt.Rows(0).Item("bl_no").ToString
        txtPackingRemark.Text = dt.Rows(0).Item("packing_remark").ToString
        dtpDeparture.Value = (dt.Rows(0).Item("estimate_departure").ToString) 'ยังไม่ได้ใส่ clsConfig.ConvertFormatDateTostring
        dtpArrival.Value = (dt.Rows(0).Item("estimate_arrival").ToString) 'ยังไม่ได้ใส่ clsConfig.ConvertFormatDateTostring
        txtBenefitKgs.Text = dt.Rows(0).Item("benefit_kgs").ToString.Trim

    End Sub

    Private Sub FormPurchaseOrderEdit5_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Call gencombo()
        Call gencomboingrid()
        'Call GenComboPONo()
        'Call InitControl()
    End Sub
    Private Sub gencombo()
        Dim objDB As New classMaster
        Dim objDBItem As New classItems


        'DataTable ItemNature
        Me.cboItemNature.DataSource = objDBItem.GetDataItemNature
        Me.cboItemNature.DisplayMember = "itnaturedesc"
        Me.cboItemNature.ValueMember = "itnaturecd"
        Me.cboItemNature.SelectedIndex = 0

        'DataTable Supplier
        Me.cboSupplier.DataSource = objDB.GetSupplier1
        Me.cboSupplier.DisplayMember = "name"
        Me.cboSupplier.ValueMember = "suppcd"
        Me.cboSupplier.SelectedIndex = -1

        'DataSet Currency
        Me.cboCurrency.DataSource = objDBItem.GetDataCurrency.Tables(0)
        Me.cboCurrency.DisplayMember = "currname"
        Me.cboCurrency.ValueMember = "curr"
        Me.cboCurrency.SelectedIndex = -1

        'DataTable Dept
        Me.cboDept.DataSource = objDBItem.GetDeptList
        Me.cboDept.DisplayMember = "deptname"
        Me.cboDept.ValueMember = "deptcd"
        Me.cboDept.SelectedIndex = -1

        'DataTable Emp
        Me.cboEmp.DataSource = objDBItem.GetEmpList
        Me.cboEmp.DisplayMember = "empname"
        Me.cboEmp.ValueMember = "empcd"
        Me.cboEmp.SelectedIndex = -1

        

    End Sub
    Private Sub gencomboingrid()
        Dim objDB As New classMaster
        Dim objDBItem As New classItems

        'DataTable itdesc
        Me.cboitcd.DataSource = objDBItem.GetDataItemcode("", cboItemNature.SelectedValue.ToString.Trim.ToUpper)
        Me.cboitcd.DisplayMember = "itdesc"
        Me.cboitcd.ValueMember = "itcd"

        'DataTable itdesc
        Me.cboItcd.DataSource = objDBItem.GetDataItemcode("", cboItemNature.SelectedValue.ToString.Trim.ToUpper)
        Me.cboItcd.DisplayMember = "itcd"
        Me.cboItcd.ValueMember = "itcd"

        'DataTable uom
        Me.cbouom.DataSource = objDBItem.GetDataUnit
        Me.cbouom.DisplayMember = "uom"
        Me.cbouom.ValueMember = "uom"

    End Sub

    Private Sub cboItemNature_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cboItemNature.SelectedIndexChanged
        Call gencomboingrid()
    End Sub
End Class