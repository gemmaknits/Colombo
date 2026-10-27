Public Class frmCustomerSite
    Dim clsConfig As New clsConfig
    Dim clsConn As New classConnection
    Dim clsUser As New classUserInfo

    Dim strCustCD As String = ""
    Dim blnCancel As Boolean = False

    Dim dtCustomersSite As New DataTable
    Dim bsCustomersSite As New BindingSource

    Dim drvCustomersSite As DataRowView
    Dim drCustomerSite As DataRow

    Dim Int64CustomerID As New Nullable(Of Int64)
    Dim blnOk As Boolean = False
    Public Property UserInfo() As classUserInfo
        Get
            UserInfo = clsUser
        End Get
        Set(ByVal NewValue As classUserInfo)
            clsUser = NewValue
        End Set
    End Property

    Public Property PdrCustomerSite As DataRow
        Get
            PdrCustomerSite = drCustomerSite
        End Get
        Set(ByVal NewValue As DataRow)
            drCustomerSite = NewValue
        End Set
    End Property

    Public Property PdtCustomersSite As DataTable
        Get
            PdtCustomersSite = dtCustomersSite
        End Get
        Set(ByVal NewValue As DataTable)
            dtCustomersSite = NewValue
        End Set
    End Property

    Public Property PbsCustomersSite As BindingSource
        Get
            PbsCustomersSite = bsCustomersSite
        End Get
        Set(ByVal NewValue As BindingSource)
            bsCustomersSite = NewValue
        End Set
    End Property

    Public Property PdrvCustomersSite As DataRowView
        Get
            PdrvCustomersSite = drvCustomersSite
        End Get
        Set(ByVal NewValue As DataRowView)
            drvCustomersSite = NewValue
        End Set
    End Property
    Public Property pblnOk As Boolean
        Get
            pblnOk = blnOk
        End Get
        Set(ByVal NewValue As Boolean)
            blnOk = NewValue
        End Set
    End Property

    Private Sub frmCustomerSite_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        Call InitControl()

        Call GenCombo()

        Call InitDataBinding()

        Me.StartPosition = FormStartPosition.CenterScreen
    End Sub

    Private Sub InitControl()
        Dim obj As Control
        For Each obj In Me.Controls
            Call SetControlValue(obj)
        Next
        Call EnabledControl(True)
        Call SetErrorProvider()
        Call SetToolTip()

        ChkParentCustomerFlag.Enabled = False

    End Sub
    Private Sub SetToolTip()
        ToolTipCustcd.SetToolTip(txtCustCD, "Enter Customer Code")
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
            If chk.Name = "chkAutoCalculate" Then chk.Checked = True

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


    Private Sub SetErrorProvider()
        ErrorProvider1.Clear()
    End Sub

    Private Sub InitDataBinding()

        dtCustomersSite = (New classCustomers).GetCustomersSite(Int64CustomerID:=Int64CustomerID, strEmpcd:=clsUser.UserID)

        If Not dtCustomersSite.Rows.Count > 0 Then 'If Not Add Site
            dtCustomersSite.ImportRow(drCustomerSite)
        End If


        bsCustomersSite.DataSource = dtCustomersSite
        bsCustomersSite.MoveFirst()

        drvCustomersSite = CType(bsCustomersSite.Current, DataRowView)

        Call BindingData() '
    End Sub


    Private Sub BindingData()
        Call ClearDataBindings()
        txtCustCD.DataBindings.Add("text", bsCustomersSite, "custcd")
        txtName.DataBindings.Add("text", bsCustomersSite, "name")
        txtaddr1.DataBindings.Add("text", bsCustomersSite, "addr1")
        txtaddr2.DataBindings.Add("text", bsCustomersSite, "addr2")
        txtaddr3.DataBindings.Add("text", bsCustomersSite, "addr3")

        txtNamet.DataBindings.Add("text", bsCustomersSite, "namet")
        txtaddr1t.DataBindings.Add("text", bsCustomersSite, "addr1t")
        txtaddr2t.DataBindings.Add("text", bsCustomersSite, "addr2t")
        txtaddr3t.DataBindings.Add("text", bsCustomersSite, "addr3t")

        txtname2.DataBindings.Add("text", bsCustomersSite, "name2")
        txtContact.DataBindings.Add("text", bsCustomersSite, "contact")
        txtTel.DataBindings.Add("text", bsCustomersSite, "tel")
        txtFax.DataBindings.Add("text", bsCustomersSite, "fax")
        txtEmail.DataBindings.Add("text", bsCustomersSite, "email")
        txtCity.DataBindings.Add("text", bsCustomersSite, "city")
        cboctry.DataBindings.Add("selectedvalue", bsCustomersSite, "ctry")

        txtVatRegNo.DataBindings.Add("text", bsCustomersSite, "vatregno")
        txtCredit.DataBindings.Add("text", bsCustomersSite, "credit")
        txtpayterms.DataBindings.Add("text", bsCustomersSite, "payterms")
        cboagcd.DataBindings.Add("selectedvalue", bsCustomersSite, "agcd")

        txtdistrict.DataBindings.Add("text", bsCustomersSite, "district")

        txtGroupName.DataBindings.Add("text", bsCustomersSite, "group_name")
        txtMainProduct.DataBindings.Add("text", bsCustomersSite, "main_product")

        ChkParentCustomerFlag.DataBindings.Add("Checked", bsCustomersSite, "parent_customer_flag")
        ChkBillToFlag.DataBindings.Add("Checked", bsCustomersSite, "bill_to_flag")
        ChkShipToFlag.DataBindings.Add("Checked", bsCustomersSite, "ship_to_flag")

        cboBank.DataBindings.Add("selectedvalue", bsCustomersSite, "id_banks")
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

    Private Sub GenCombo()
        Dim objDB As New classMaster

        Me.cboagcd.DataSource = objDB.GetAgent()
        Me.cboagcd.DisplayMember = "name"
        Me.cboagcd.ValueMember = "agcd"

        Me.cboctry.DataSource = objDB.GetCountry()
        Me.cboctry.DisplayMember = "name2"
        Me.cboctry.ValueMember = "ctry"

        'Me.cboBank.DataSource = objDB.GetBanks()
        'Me.cboBank.DisplayMember = "bank_name"
        'Me.cboBank.ValueMember = "id_banks"

        Me.cboBank.populateData((New classConnection).getSQLConnection)
        Me.cboBank.DisplayMember = "bank_name"
        Me.cboBank.ValueMember = "id_banks"

        'Me.cboBank.populateData((New classConnection).getSQLConnection)
        'cboBank.SelectedIndex = -1
    End Sub

    Private Sub btnOk_Click(sender As System.Object, e As System.EventArgs) Handles btnOk.Click

        bsCustomersSite.EndEdit()
        drCustomerSite = CType(bsCustomersSite.Current, DataRowView).Row
        blnOk = True
        Me.Close()
    End Sub

    Private Sub BtnExit_Click(sender As System.Object, e As System.EventArgs) Handles BtnExit.Click
        blnOk = False
        Me.Close()
    End Sub

    Private Sub txtCustCD_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles txtCustCD.KeyDown
        If e.KeyCode = Keys.Enter Then
            If txtCustCD.Text.Length > 0 Then
                Int64CustomerID = (New classCustomers).GetCustomerID(StrCustcd:=txtCustCD.Text, strEmpcd:=clsUser.UserID)
                If (New clsConfig).IsNull(Int64CustomerID, 0) = 0 Then
                    MessageBox.Show("ไม่พบ Customer ID", "Message Box", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
                End If
            End If

            Call InitDataBinding()
        End If
    End Sub

End Class