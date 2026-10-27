Public Class frmCustomerNew
    Dim clsConfig As New clsConfig
    Dim clsConn As New ClassConnection

    Dim dtCustomers As New DataTable
    Dim bsCustomers As New BindingSource

    Dim drvCustomers As DataRowView

    Dim Int64parentCustomerID As New Nullable(Of Int64)
    Dim clsUser As New classUserInfo
    Public Property UserInfo() As classUserInfo
        Get
            UserInfo = clsUser
        End Get
        Set(ByVal NewValue As classUserInfo)
            clsUser = NewValue
        End Set
    End Property


    Private Sub frmCustomerNew_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized

        Call InitControl()

        Call InitDataBinding()


        btnAddParentOrSite.Text = "Add Parent"

    End Sub

    Private Sub InitControl()
        Dim obj As Control
        For Each obj In Me.Controls
            Call SetControlValue(obj)
        Next
        Call EnabledControl(True)
        Call SetErrorProvider()

        grdCustomers.AutoGenerateColumns = False
        grdCustomers.DataSource = Nothing

        Int64parentCustomerID = Nothing
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

    Private Sub SetToolTips()

    End Sub

    Private Sub InitDataBinding()

        dtCustomers = (New classCustomers).GetCustomers(Int64ParentCustomerID:=Int64parentCustomerID, strEmpcd:=clsUser.UserID)

        'If dtCustomers.Rows.Count = 0 Then
        '    Dim drCustomers As DataRow
        '    drCustomers = dtCustomers.NewRow
        '    dtCustomers.Rows.Add(drCustomers)
        'End If

        bsCustomers.DataSource = dtCustomers
        bsCustomers.MoveFirst()

        grdCustomers.AutoGenerateColumns = False
        grdCustomers.DataSource = bsCustomers '.DataSource

        drvCustomers = CType(bsCustomers.Current, DataRowView)
        Call BindingData() '
    End Sub

    Private Sub BindingData()
        Call ClearDataBindings()

        txtCustCD.DataBindings.Add("text", bsCustomers, "custcd")
        txtname.DataBindings.Add("text", bsCustomers, "name")
        txtname2.DataBindings.Add("text", bsCustomers, "name2")
        txtnamet.DataBindings.Add("text", bsCustomers, "namet")



        txtTotalSite.Text = bsCustomers.DataSource.compute("Count(custcd)", "")


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


    Private Sub BtnAdd_Click(sender As System.Object, e As System.EventArgs) Handles btnAddParentOrSite.Click

        Call AddParetnOrSite()
    End Sub

    Private Sub AddParetnOrSite()

        If btnAddParentOrSite.Text.Trim = "Add Parent" Then
            Int64parentCustomerID = (New classCustomers).GetparentCustomerID(StrCustcd:=txtCustCD.Text, strEmpcd:=clsUser.UserID)
        End If

        Dim frm As New frmCustomerSite
        frm.UserInfo = UserInfo
        bsCustomers.EndEdit()

        Dim dtCustomersClone As DataTable = dtCustomers.Clone
        Dim bsCustomersClone As New BindingSource
        bsCustomersClone.DataSource = dtCustomersClone
        Dim drNew As DataRow
        drNew = dtCustomersClone.NewRow
        drNew("custcd") = "" 'txtCustCD.Text
        drNew("name") = "" 'txtname.Text
        drNew("namet") = "" 'txtnamet.Text
        drNew("name2") = "" 'txtname2.Text
        drNew("ship_to_flag") = 1
        drNew("bill_to_flag") = 1
        drNew("parent_customer_flag") = IIf(btnAddParentOrSite.Text = "Add Parent", 1, 0)
        drNew("parent_customer_id") = IIf(btnAddParentOrSite.Text = "Add Parent", DBNull.Value, Int64parentCustomerID)
        drNew("ctry") = "TH"
        drNew("active") = 1
        dtCustomersClone.Rows.Add(drNew)
        bsCustomersClone.EndEdit()
        bsCustomersClone.MoveFirst()
        Dim drCustomersSiteSend As DataRow = (CType(bsCustomersClone.Current, DataRowView)).Row
        frm.PdrCustomerSite = drCustomersSiteSend

        frm.ShowDialog(Me)
        If frm.pblnOk = True Then
            Dim drCustomersSite As DataRow
            drCustomersSite = frm.PdrCustomerSite
            For Each drCustomers As DataRow In dtCustomers.Rows
                If drCustomersSite Is Nothing Then Exit Sub
                If drCustomers("custcd") = drCustomersSite("custcd") Then
                    MessageBox.Show("This Cust Code Still Already", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
                    Exit Sub
                End If
            Next
            dtCustomers.ImportRow(drCustomersSite)
            bsCustomers.EndEdit()
            txtTotalSite.Text = bsCustomers.DataSource.compute("Count(custcd)", "")

            frm.Dispose()
        End If

    End Sub

    Private Sub BtnEdit_Click(sender As System.Object, e As System.EventArgs) Handles BtnEdit.Click

        If Not CheckEditSite() Then Exit Sub

        Call EditSite()

    End Sub

    Private Function CheckEditSite() As Boolean
        If grdCustomers.Rows.Count = 0 Then
            MessageBox.Show("Please Selected Customer Data !!!", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
            Return False
        End If

        Return True
    End Function

    Private Sub EditSite()
        Me.Validate()

        If Not grdCustomers.Rows.Count > 0 Then Exit Sub
        Dim frm As New frmCustomerSite
        frm.UserInfo = UserInfo
        Dim drCustomersSite As DataRow
        drCustomersSite = (CType(bsCustomers.Current, DataRowView)).Row
        frm.PdrCustomerSite = drCustomersSite
        frm.ShowDialog(Me)

        If frm.pblnOk = True Then
            drCustomersSite = frm.PdrCustomerSite
            bsCustomers.EndEdit()
            grdCustomers.Rows(grdCustomers.CurrentRow.Index).Cells("ColParentCustomerFlag").Value = drCustomersSite("parent_customer_flag")
            grdCustomers.Rows(grdCustomers.CurrentRow.Index).Cells("colcustcd").Value = drCustomersSite("custcd")
            grdCustomers.Rows(grdCustomers.CurrentRow.Index).Cells("colName").Value = drCustomersSite("Name")
            grdCustomers.Rows(grdCustomers.CurrentRow.Index).Cells("coladdr1").Value = drCustomersSite("addr1")
            grdCustomers.Rows(grdCustomers.CurrentRow.Index).Cells("coladdr2").Value = drCustomersSite("addr2")
            grdCustomers.Rows(grdCustomers.CurrentRow.Index).Cells("coladdr3").Value = drCustomersSite("addr3")
            grdCustomers.Rows(grdCustomers.CurrentRow.Index).Cells("colnamet").Value = drCustomersSite("namet")
            grdCustomers.Rows(grdCustomers.CurrentRow.Index).Cells("coladdr1t").Value = drCustomersSite("addr1t")
            grdCustomers.Rows(grdCustomers.CurrentRow.Index).Cells("coladdr2t").Value = drCustomersSite("addr2t")
            grdCustomers.Rows(grdCustomers.CurrentRow.Index).Cells("coladdr3t").Value = drCustomersSite("addr3t")
            grdCustomers.Rows(grdCustomers.CurrentRow.Index).Cells("colname2").Value = drCustomersSite("name2")
            grdCustomers.Rows(grdCustomers.CurrentRow.Index).Cells("colContact").Value = drCustomersSite("Contact")
            grdCustomers.Rows(grdCustomers.CurrentRow.Index).Cells("coltel").Value = drCustomersSite("tel")
            grdCustomers.Rows(grdCustomers.CurrentRow.Index).Cells("colfax").Value = drCustomersSite("fax")
            grdCustomers.Rows(grdCustomers.CurrentRow.Index).Cells("colemail").Value = drCustomersSite("email")
            grdCustomers.Rows(grdCustomers.CurrentRow.Index).Cells("ColVatregno").Value = drCustomersSite("vatregno")
            grdCustomers.Rows(grdCustomers.CurrentRow.Index).Cells("colCredit").Value = drCustomersSite("Credit")
            grdCustomers.Rows(grdCustomers.CurrentRow.Index).Cells("colpayterms").Value = drCustomersSite("payterms")
            grdCustomers.Rows(grdCustomers.CurrentRow.Index).Cells("colagcd").Value = drCustomersSite("agcd")
            grdCustomers.Rows(grdCustomers.CurrentRow.Index).Cells("Coldistrict").Value = drCustomersSite("district")
            grdCustomers.Rows(grdCustomers.CurrentRow.Index).Cells("ColCity").Value = drCustomersSite("city")
            grdCustomers.Rows(grdCustomers.CurrentRow.Index).Cells("ColCtry").Value = drCustomersSite("ctry")
            grdCustomers.Rows(grdCustomers.CurrentRow.Index).Cells("ColGroupName").Value = drCustomersSite("group_name")
            grdCustomers.Rows(grdCustomers.CurrentRow.Index).Cells("ColMainProduct").Value = drCustomersSite("main_product")
            grdCustomers.Rows(grdCustomers.CurrentRow.Index).Cells("Colshiptoflag").Value = drCustomersSite("ship_to_flag")
            grdCustomers.Rows(grdCustomers.CurrentRow.Index).Cells("ColBillToFlag").Value = drCustomersSite("bill_to_flag")
            grdCustomers.Rows(grdCustomers.CurrentRow.Index).Cells("ColIDBanks").Value = drCustomersSite("id_banks")
            grdCustomers.Rows(grdCustomers.CurrentRow.Index).Cells("ColBranchNum").Value = drCustomersSite("branch_num")
            bsCustomers.EndEdit()
        End If

        txtTotalSite.Text = bsCustomers.DataSource.compute("Count(custcd)", "")
        Me.Cursor = Cursors.Default
        frm.Dispose()
    End Sub

    Private Sub UpdateCurrentrow(ByVal row As DataRow)
        ' Dim drvr As DataGridViewRow = grdCustomers.CurrentRow
        Dim drCustomersSite As DataRow = (CType(grdCustomers.CurrentRow.DataBoundItem, DataRowView)).Row
        'drvr = (CType(row.DataBoundItem, DataRow))
        drCustomersSite = row
        ' For i = 0 To grdCustomers.Rows(grdCustomers.CurrentRow.Index).Cells.Count - 1
        'grdCustomers.Rows(grdCustomers.CurrentRow.Index).Cells(i).Value = row(i)
        'Next


        ''Dim idColumn As Integer = Integer.Parse(row("IdColumn").ToString())

        'For Each DGVrow As DataGridViewRow In grdCustomers.Rows

        '    If idColumn = Integer.Parse(DGVrow.Cells("IdColumn").Value.ToString()) Then

        '        For i As Integer = 0 To row.ItemArray.Length - 1
        '            grdCustomers(i, DGVrow.Index).Value = row.ItemArray(i).ToString()
        '        Next
        '    End If
        'Next
    End Sub


    Private Sub txtCustCD_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles txtCustCD.KeyDown
        If e.KeyCode = Keys.Enter Then

            If txtCustCD.Text.Length > 0 Then
                Int64parentCustomerID = (New classCustomers).GetparentCustomerID(StrCustcd:=txtCustCD.Text, strEmpcd:=clsUser.UserID)

            End If

            If (clsConfig).IsNull(Int64parentCustomerID, 0) = 0 Then
                MessageBox.Show("ไม่พบ Paraent Customer ID", "Message Box", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
                btnAddParentOrSite.Text = "Add Parent"
            Else
                btnAddParentOrSite.Text = "Add Site"
                'Exit Sub
            End If

            Call InitDataBinding()
        End If
    End Sub

    Private Sub txtname_LostFocus(sender As Object, e As System.EventArgs) Handles txtname.LostFocus
        bsCustomers.EndEdit()
    End Sub


    Private Sub txtname_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtname.TextChanged
        bsCustomers.EndEdit()
    End Sub

    Private Sub btnSave_Click(sender As System.Object, e As System.EventArgs) Handles btnSave.Click
        Me.Validate()

        'Sitthana 20220624 Changed Windows.Forms.DialogResult To DialogResult
        Dim result As DialogResult ' Windows.Forms.DialogResult
        result = MessageBox.Show("Would you like to save ?", "System Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button3)
        If result <> DialogResult.Yes Then Exit Sub

        If Not CheckData() Then Exit Sub

        Call SaveData()
    End Sub

    Private Function CheckData() As Boolean
        Dim config As New clsConfig

        If txtname.Text.Trim.Length = 0 Then
            MessageBox.Show("Please fill the customer name (Eng) !!", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            CheckData = False
            Exit Function
        End If

        If txtnamet.Text.Trim.Length = 0 Then
            MessageBox.Show("Please fill the customer name (Thai) !!", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            CheckData = False
            Exit Function
        End If

        'If config.IsNull(cboCountry.SelectedValue, "").ToString.Trim = "" Then
        '    MessageBox.Show("Please choose country !!", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
        '    CheckData = False
        '    Exit Function
        'End If

        CheckData = True
    End Function

    Private Function SaveData() As Boolean
        Dim objdb As New classCustomers
        Dim Header As New classCustomers.Customer

        Dim msgerr As String = ""
        Dim CustCD As String = ""

        bsCustomers.EndEdit()
        dtCustomers.GetChanges()

        Header.h01_custcd = txtCustCD.Text
        Header.h25_parent_customer_id = Int64parentCustomerID

        If objdb.SaveData(dtCustomers, Header, msgerr, CustCD) Then
            txtCustCD.Text = Header.h01_custcd
            MessageBox.Show("บันทึกสำเร็จ", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)

            If txtCustCD.Text.Length > 0 Then
                Int64parentCustomerID = (New classCustomers).GetparentCustomerID(StrCustcd:=txtCustCD.Text, strEmpcd:=clsUser.UserID)
            End If
            If (clsConfig).IsNull(Int64parentCustomerID, 0) = 0 Then
                MessageBox.Show("ไม่พบ Paraent Customer ID", "Message Box", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
            End If
            Call InitDataBinding()
            SaveData = True
        Else
            MessageBox.Show(msgerr, "System Message", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
            SaveData = False
        End If
    End Function

    Private Sub txtCustCD_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtCustCD.TextChanged
        bsCustomers.EndEdit()
    End Sub

    Private Sub btnNew_Click(sender As System.Object, e As System.EventArgs) Handles btnNew.Click
        Me.WindowState = FormWindowState.Maximized

        Call InitControl()

        Call InitDataBinding()

        btnAddParentOrSite.Text = "Add Parent"

        txtCustCD.Focus()
    End Sub

    Private Sub BtnDel_Click(sender As System.Object, e As System.EventArgs) Handles BtnDel.Click
        Call DeleteSite()
    End Sub

    Private Sub DeleteSite()

        grdCustomers.Rows.RemoveAt(grdCustomers.CurrentRow.Index)

        'For Each row As DataGridViewRow In grdCustomers.SelectedRows
        'grdCustomers.Rows.Remove(row)
        ' Next

    End Sub

    Private Sub BtnSearch_Click(sender As System.Object, e As System.EventArgs) Handles BtnSearch.Click
        Dim frm As New frmSeachCustomersParent
        frm.ShowDialog(Me)
        Me.Cursor = Cursors.WaitCursor
        txtCustCD.Text = frm.pCustomerCoDe
        Me.Cursor = Cursors.Default
        frm.Dispose()
        If frm.pblnOk = True Then
            If txtCustCD.Text.Length > 0 Then
                Int64parentCustomerID = (New classCustomers).GetparentCustomerID(StrCustcd:=txtCustCD.Text, strEmpcd:=clsUser.UserID)
            End If
            If (clsConfig).IsNull(Int64parentCustomerID, 0) = 0 Then
                MessageBox.Show("ไม่พบ Paraent Customer ID", "Message Box", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
                btnAddParentOrSite.Text = "Add Parent"
            Else
                btnAddParentOrSite.Text = "Add Site"
                'Exit Sub
            End If

            Call InitDataBinding()
        End If

    End Sub

    Private Sub txtname2_LostFocus(sender As Object, e As System.EventArgs) Handles txtname2.LostFocus

    End Sub

    Private Sub txtname2_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtname2.TextChanged
        bsCustomers.EndEdit()
    End Sub

    Private Sub txtnamet_LostFocus(sender As Object, e As System.EventArgs) Handles txtnamet.LostFocus

    End Sub

    Private Sub txtnamet_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtnamet.TextChanged
        bsCustomers.EndEdit()
    End Sub
End Class