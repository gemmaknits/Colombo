Imports System.Data.SqlClient
Public Class frmSearchSOCustItem
    Private _CustomerNumber As String = ""
    Private _CustomerName As String = ""
    Private _CustItemNumber As String = ""
    Private _OurItemNumber As String = ""
    Private _mtl_customer_items_id As String = ""
    Private _mtl_customer_items_xref_id As String = ""
    Private _FullWidth As String = "" ''As Double = 0
    Private _UseableWidth As String = "" ''As Double = 0
    Private _GMPerSQM As String = "" ''As Double = 0
    Private _btnSelect As String = "" ''As String = ""

#Region "Property"
    'ToDo: Property Use Sent Data Between Form

    Public Property CustomerNumber() As String
        Get
            CustomerNumber = _CustomerNumber
        End Get
        Set(ByVal NewValue As String)

            _CustomerNumber = NewValue
        End Set
    End Property
    Public Property CustomerName() As String
        Get
            CustomerName = _CustomerName
        End Get
        Set(ByVal NewValue As String)

            _CustomerName = NewValue
        End Set
    End Property

    Public Property CustItemNumber() As String
        Get
            CustItemNumber = _CustItemNumber
        End Get
        Set(ByVal NewValue As String)

            _CustItemNumber = NewValue
        End Set
    End Property

    Public Property OurItemNumber() As String
        Get
            OurItemNumber = _OurItemNumber
        End Get
        Set(ByVal NewValue As String)
            _OurItemNumber = NewValue
        End Set
    End Property

    Public Property mtl_customer_items_id() As String
        Get
            mtl_customer_items_id = _mtl_customer_items_id
        End Get
        Set(ByVal NewValue As String)
            _mtl_customer_items_id = NewValue
        End Set
    End Property

    Public Property mtl_customer_items_xref_id() As String
        Get
            mtl_customer_items_xref_id = _mtl_customer_items_xref_id
        End Get
        Set(ByVal NewValue As String)
            _mtl_customer_items_xref_id = NewValue
        End Set
    End Property

    Public Property FullWidth() As String
        Get
            FullWidth = _FullWidth
        End Get
        Set(ByVal NewValue As String)
            _FullWidth = NewValue
        End Set
    End Property

    Public Property UseableWidth() As String
        Get
            UseableWidth = _UseableWidth
        End Get
        Set(ByVal NewValue As String)
            _UseableWidth = NewValue
        End Set
    End Property

    Public Property GMPerSQM() As String
        Get
            GMPerSQM = _GMPerSQM
        End Get
        Set(ByVal NewValue As String)
            _GMPerSQM = NewValue
        End Set
    End Property
    Public Property btnSelect() As String
        Get
            btnSelect = _btnSelect
        End Get
        Set(ByVal NewValue As String)
            _btnSelect = NewValue
        End Set
    End Property
#End Region

    Private Sub setTxtReadOnly(objTxt As Object, ReadOnlyFlag As Boolean)
        objTxt.ReadOnly = True
        objTxt.BackColor = Color.PeachPuff
    End Sub
    Private Sub initObject()
        setTxtReadOnly(txtCustomerID, True)
        setTxtReadOnly(txtCustomerName, True)

        With grdCustomer_Item
            .ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .AlternatingRowsDefaultCellStyle.BackColor = Color.SlateGray
            .SelectionMode = DataGridViewSelectionMode.FullRowSelect
        End With
    End Sub

    Private Sub frmSearchSOCustItem_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        initObject()
        getDataToHeader()
        getDataInsertToGrd()
    End Sub

    Private Sub getDataToHeader()
        txtCustomerID.Text = CustomerNumber
        txtCustomerName.Text = CustomerName
        txtCustItemNumber.Text = CustItemNumber
        txtOurItemNumber.Text = OurItemNumber
    End Sub
    Private Sub getDataInsertToGrd()
        Dim conn As New SqlConnection((New classConnection).connection)
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "p_so_customer_item_select"
        comm.Parameters.AddWithValue("@CustCode", CustomerNumber)
        comm.Parameters.AddWithValue("@CustDesign", CustItemNumber)
        comm.Parameters.AddWithValue("@OurDesign", OurItemNumber)

        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        comm.Connection.Close()

        grdCustomer_Item.AutoGenerateColumns = False
        grdCustomer_Item.DataSource = dt
    End Sub

    Private Function chgStrToDouble(strValue As String, Optional defauleValue As Double = 0)
        Dim doubleReturnValue As Double = 0
        If IsDBNull(strValue) Then
            doubleReturnValue = defauleValue
        ElseIf strValue.Trim = "" Then
            doubleReturnValue = defauleValue
        Else
            doubleReturnValue = Convert.ToDouble(strValue.Trim)
        End If

        Return doubleReturnValue
    End Function
    Private Function chgGrdStrToDouble(strValue As Object, Optional defauleValue As Double = 0)
        Dim doubleReturnValue As Double = 0
        If IsDBNull(strValue.value) Then
            doubleReturnValue = defauleValue
        ElseIf strValue.value.Trim = "" Then
            doubleReturnValue = defauleValue
        Else
            doubleReturnValue = Convert.ToDouble(strValue.value.Trim)
        End If

        Return doubleReturnValue
    End Function
    Private Sub AssignValueToReturnVar()
        With grdCustomer_Item
            If .Rows.Count > 0 Then
                _CustItemNumber = .CurrentRow.Cells("customer_design").Value.trim
                _OurItemNumber = .CurrentRow.Cells("dm_design_no").Value.trim
                _mtl_customer_items_id = .CurrentRow.Cells("customer_items_id").Value
                _mtl_customer_items_xref_id = .CurrentRow.Cells("customer_items_xref_id").Value
                _FullWidth = .CurrentRow.Cells("full_width").Value.trim
                _UseableWidth = .CurrentRow.Cells("useable_width").Value.trim
                _GMPerSQM = .CurrentRow.Cells("grams_per_sqm").Value.trim   ''chgGrdStrToDouble(.CurrentRow.Cells("grams_per_sqm"))
            Else
                _CustItemNumber = ""
                _OurItemNumber = ""
                _mtl_customer_items_id = 0
                _mtl_customer_items_xref_id = 0
                _FullWidth = 0
                _UseableWidth = 0
                _GMPerSQM = 0
            End If
        End With
    End Sub
    Private Sub dgvCustomer_Item_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles grdCustomer_Item.CellDoubleClick
        AssignValueToReturnVar()
        _btnSelect = vbOK
        Me.Close()
    End Sub

    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        AssignValueToReturnVar()
        _btnSelect = vbOK
        Me.Close()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        _btnSelect = vbCancel
    End Sub

    Private Sub frmSearchSOCustItem_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        If btnSelect.Trim = "" Then
            _btnSelect = vbCancel
        End If
    End Sub

    Private Sub btnSerch_Click(sender As Object, e As EventArgs) Handles btnSerch.Click
        CustItemNumber = txtCustItemNumber.Text.Trim
        OurItemNumber = txtOurItemNumber.Text.Trim
        getDataInsertToGrd()
    End Sub
End Class