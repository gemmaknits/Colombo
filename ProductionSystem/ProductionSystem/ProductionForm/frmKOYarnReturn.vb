Public Class frmKOYarnReturn
    Dim config As New clsConfig
    Dim clsConn As New classConnection
    Dim clsUser As New classUserInfo
    Dim kono As String = ""

    Public Property UserInfo() As classUserInfo
        Get
            UserInfo = clsUser
        End Get
        Set(ByVal NewValue As classUserInfo)
            clsUser = NewValue
        End Set
    End Property

    Private Sub SetControlValue(ByVal Obj As Control)
        If TypeOf Obj Is TextBox Then
            Obj.Text = Obj.Tag
        End If
        If TypeOf Obj Is DateTimePicker Then
            Dim dtp As DateTimePicker = Obj
            dtp.Value = "01/01/1900"
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

    Private Sub EnabledControl(ByVal blnEnabled As Boolean)
        Dim obj As Control
        For Each obj In Me.Controls
            Call SetControlEnabled(obj, blnEnabled)
        Next
    End Sub

    Private Sub InitControl()
        Dim obj As Control
        For Each obj In Me.Controls
            Call SetControlValue(obj)
        Next
        Call EnabledControl(True)
        kono = ""
        txtKONo.Focus()
    End Sub

    Private Sub GenComboKONo()
        Dim objDB As New classMaster

        Me.cboKoNo.ComboBox.DataSource = objDB.comboKO(clsUser.UserID)
        Me.cboKoNo.ComboBox.DisplayMember = "kono"
        Me.cboKoNo.ComboBox.ValueMember = "kono"
        Me.cboKoNo.ComboBox.SelectedIndex = 0
    End Sub

    Private Sub BindData(ByVal dt As DataTable)
        kono = dt.Rows(0)("kono").ToString
        txtKONo.Text = dt.Rows(0)("kono").ToString

        chkClosed.Checked = dt.Rows(0)("koclosed_final").ToString
        dtpClosed.Value = dt.Rows(0)("koclosed_final_date").ToString
        txtClosedRemark.Text = dt.Rows(0)("rem_closed_final").ToString
    End Sub

    Private Sub LoadData(ByVal strKONo As String)
        Dim objDB As New classProduction
        Dim dt As DataTable = objDB.KOYarnReturnSelect(strKONo, clsUser.UserID)
        If dt.Rows.Count > 0 Then
            Call BindData(dt)
        End If
    End Sub

    Private Function SaveData() As Boolean
        Dim objKO As New KO
        Dim objDB As New classProduction
        Dim errmsg As String = ""

        objKO.kono = kono
        objKO.koclosed_final = chkClosed.Checked
        objKO.koclosed_final_date = dtpClosed.Value.ToString("yyyyMMdd")
        objKO.rem_closed_final = txtClosedRemark.Text

        If objDB.KOYarnReturnUpdate(objKO, clsUser.UserID, errmsg) Then
            Call GenComboKONo()

            If txtKONo.Text.Length = 0 Or kono.Length = 0 Then
                Call InitControl()
                Call LoadData(errmsg)
            End If

            MessageBox.Show("Save Completed" & vbCrLf & errmsg, "System Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            MessageBox.Show(errmsg, "System Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Function

    Private Sub frmProductionYarnReturn_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Call InitControl()
        Call GenComboKONo()
    End Sub

    Private Sub frmProductionYarnReturn_FormClosing(sender As System.Object, e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        If MessageBox.Show("Would you like to exit ?", "System Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = System.Windows.Forms.DialogResult.No Then
            e.Cancel = True
        End If
    End Sub

    Private Sub btnNew_Click(sender As System.Object, e As System.EventArgs) Handles btnNew.Click
        Call InitControl()
    End Sub

    Private Sub btnSave_Click(sender As System.Object, e As System.EventArgs) Handles btnSave.Click
        If MessageBox.Show("Would you like to save ?", "System Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = System.Windows.Forms.DialogResult.Yes Then
            Call SaveData()
        End If
    End Sub

    Private Sub btnPrint_Click(sender As System.Object, e As System.EventArgs) Handles btnPrint.Click
        MessageBox.Show("No Report.", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
    End Sub

    Private Sub btnMinimized_Click(sender As System.Object, e As System.EventArgs) Handles btnMinimized.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub btnExit_Click(sender As System.Object, e As System.EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub cboKoNo_DropDownClosed(sender As System.Object, e As System.EventArgs) Handles cboKoNo.DropDownClosed
        Dim strKONo As String = config.IsNull(cboKoNo.ComboBox.SelectedValue, "")
        If strKONo.Length > 0 Then
            Call LoadData(strKONo)
        End If
    End Sub
End Class