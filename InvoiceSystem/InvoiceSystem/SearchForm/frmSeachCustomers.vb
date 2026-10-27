Public Class frmSearchCustomers
    Dim dtCustomers As New DataTable
    Dim bsCustomers As New BindingSource

    Dim Int64CustomerID As Int64 = 0
    Dim StrCustomerCode As String
    Dim _CustomerName As String = ""
    Dim dgvrData As DataGridViewRow
    Dim drData As DataRow
    Dim blnOk As Boolean = False
    Public Property pblnOk As Boolean
        Get
            pblnOk = blnOk
        End Get
        Set(ByVal NewValue As Boolean)
            blnOk = NewValue
        End Set
    End Property
    Public Property pCustomerID As Int64
        Get
            pCustomerID = Int64CustomerID
        End Get
        Set(ByVal NewValue As Int64)
            Int64CustomerID = NewValue
        End Set
    End Property

    Public Property pCustomerCode As String
        Get
            pCustomerCode = StrCustomerCode
        End Get
        Set(ByVal NewValue As String)
            StrCustomerCode = NewValue
        End Set
    End Property
    Public Property pCustomerName As String
        Get
            pCustomerName = _CustomerName
        End Get
        Set(ByVal NewValue As String)
            _CustomerName = NewValue
        End Set
    End Property
    Public Property pDgvrData As DataGridViewRow
        Get
            pDgvrData = dgvrData
        End Get
        Set(ByVal NewValue As DataGridViewRow)
            dgvrData = NewValue
        End Set
    End Property
    Public Property pdrdata As DataRow
        Get
            pdrdata = drData
        End Get
        Set(ByVal Newvalue As DataRow)
            drData = Newvalue
        End Set
    End Property

    Private Sub frmSeachCustomers_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        Call InitControl()

        Call InitDataBinding()
    End Sub
    Private Sub InitControl()
        Dim obj As Control
        For Each obj In Me.Controls
            Call SetControlValue(obj)
        Next
        Call EnabledControl(True)

    End Sub


    Private Sub SetControlValue(ByVal Obj As Control)
        If TypeOf Obj Is TextBox Then
            Obj.Text = Obj.Tag
        End If
        If TypeOf Obj Is DateTimePicker Then
            Dim dtp As DateTimePicker = Obj
            dtp.Value = Now
            dtp.Checked = False
        End If
        If TypeOf Obj Is ComboBox Then
            Dim cbo As ComboBox = Obj
            cbo.SelectedIndex = -1
        End If
        If TypeOf Obj Is CheckBox Then
            Dim chk As CheckBox = Obj
            chk.Checked = False
        End If
        If TypeOf Obj Is TabControl Or TypeOf Obj Is TabPage Or TypeOf Obj Is GroupBox Then
            Dim obj2 As Control
            For Each obj2 In Obj.Controls
                Call SetControlValue(obj2)
            Next
        End If
    End Sub

    Private Sub EnabledControl(ByVal blnEnabled As Boolean)
        Dim obj As Control
        For Each obj In Me.Controls
            Call SetControlEnabled(obj, blnEnabled)
        Next
    End Sub

    Private Sub SetControlEnabled(ByVal Obj As Control, ByVal blnEnabled As Boolean)
        If TypeOf Obj Is TextBox Then Obj.Enabled = blnEnabled
        If TypeOf Obj Is DateTimePicker Then Obj.Enabled = blnEnabled
        If TypeOf Obj Is ComboBox Then Obj.Enabled = blnEnabled
        If TypeOf Obj Is CheckBox Then Obj.Enabled = blnEnabled
        If TypeOf Obj Is DataGridView Then
            Dim grd As DataGridView = Obj
            grd.ReadOnly = Not blnEnabled
        End If
        If TypeOf Obj Is TabControl Or TypeOf Obj Is TabPage Or TypeOf Obj Is GroupBox Then
            Dim obj2 As Control
            For Each obj2 In Obj.Controls
                Call SetControlEnabled(obj2, blnEnabled)
            Next
        End If

    End Sub

    Private Sub InitDataBinding()

        dtCustomers = (New classSearchCustomers).GetGridCustomers()

        bsCustomers.DataSource = dtCustomers

        Call BindingData() '
    End Sub

    Private Sub BindingData()
        Call ClearDataBindings()

        GrdData.DataSource = bsCustomers

    End Sub

    Public Sub ClearDataBindings()
        Dim obj As Control
        For Each obj In Me.Controls
            Call ClearControlBindings(obj)
        Next
    End Sub

    Private Sub ClearControlBindings(ByVal obj As Control)
        obj.DataBindings.Clear()
        If TypeOf obj Is TabControl Or TypeOf obj Is TabPage Or TypeOf obj Is GroupBox Then
            Dim obj2 As Control
            For Each obj2 In obj.Controls
                Call ClearControlBindings(obj2)
            Next
        End If

    End Sub

    Private Sub TextBox1_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles txtSearch.KeyDown
        If e.KeyCode = Keys.Enter Then
            bsCustomers.Filter = "name like '%" & txtSearch.Text & "%'"
            ' or " & cboline_type.SelectedValue & " = 0"

        End If
    End Sub

    Private Sub TextBox1_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtSearch.TextChanged

    End Sub

    Private Sub btnSearch_Click(sender As System.Object, e As System.EventArgs) Handles btnSearch.Click
        bsCustomers.Filter = "name like '%" & txtSearch.Text & "%'"
    End Sub



    Private Sub GrdData_CellDoubleClick(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles GrdData.CellDoubleClick
        If (e.RowIndex >= 0) Then
            If GrdData.Rows.Count > 0 Then
                Int64CustomerID = GrdData.CurrentRow.Cells("GrdDatacustomerID").Value
                StrCustomerCode = GrdData.CurrentRow.Cells("GrdDataCustcd").Value
                _CustomerName = GrdData.CurrentRow.Cells("GrdDataName").Value
                pblnOk = True
                Me.Close()
            End If
        End If
    End Sub

    Private Sub Getdata()

        If GrdData.Rows.Count > 0 Then
            Int64CustomerID = GrdData.CurrentRow.Cells("GrdDatacustomerID").Value
            StrCustomerCode = GrdData.CurrentRow.Cells("GrdDataCustcd").Value
            _CustomerName = GrdData.CurrentRow.Cells("GrdDataName").Value
            pblnOk = True
            Me.Hide()
        Else
            pCustomerID = 0
            pCustomerCode = ""
            pCustomerName = ""
        End If

    End Sub

    Private Sub btnOk_Click(sender As Object, e As EventArgs) Handles btnOk.Click
        Call Getdata()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        pblnOk = False
        Me.Hide()
    End Sub
End Class