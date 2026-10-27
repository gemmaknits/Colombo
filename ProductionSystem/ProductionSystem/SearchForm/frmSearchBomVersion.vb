Public Class frmSearchBomVersion
       Dim clsuser As new classUserInfo
    Dim StrItcd As String
    Dim Int64ColID As Int64
    Public Int64bomversionid As Int64

    Dim dtdata As New DataTable
    Dim bsdata As New BindingSource

    Public Property UserInfo() As classUserInfo
        Get
            UserInfo = clsUser
        End Get
        Set(ByVal NewValue As classUserInfo)
            clsUser = NewValue
        End Set
    End Property

    Public Property PItcd() As String
        Get
            PItcd = StrItcd
        End Get
        Set(ByVal NewValue As String)
            StrItcd = NewValue
        End Set
    End Property

    Public Property PColID() As Int64
        Get
            PColID = Int64ColID
        End Get
        Set(ByVal NewValue As Int64)
            Int64ColID = NewValue
        End Set
    End Property

    Public Property Pbomversionid() As Int64
        Get
            Pbomversionid = Int64bomversionid
        End Get
        Set(ByVal NewValue As Int64)
            Int64bomversionid = NewValue
        End Set
    End Property

    Private Sub frmSearchBomVersion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call InitControl()

        Call Gencombobox()
        Call GenGrid()
    End Sub

    Private Sub InitControl()

        Dim obj As Control
        For Each obj In Me.Controls
            Call SetControlValue(obj)
        Next


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

    Private Sub GenGrid()

        dtdata = (New ClassSearchBomVersion).SearchBomVersion(StrItcd:=cboItcd.SelectedValue, Int64ColId:=CboColor.SelectedValue)
        bsdata.DataSource = dtdata

        Call BindingData()


    End Sub

    Private Sub BindingData()
        Call ClearDataBindings()

        grddata.AutoGenerateColumns = False
        grddata.DataSource = bsdata.DataSource

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

    Private Sub Gencombobox()

        Me.cboItcd.DataSource = (New ClassSearchBomVersion).comboYarn("")
        Me.cboItcd.DisplayMember = "itcd"
        Me.cboItcd.ValueMember = "itcd"
        cboItcd.SelectedValue = PItcd

        Me.CboColor.DataSource = (New ClassSearchBomVersion).GetBOMColorWay
        Me.CboColor.DisplayMember = "col2"
        Me.CboColor.ValueMember = "id"
        CboColor.SelectedValue = PColID

    End Sub

    Private Sub grddata_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles grddata.CellContentClick

    End Sub

    Private Sub grddata_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles grddata.CellDoubleClick
        If grddata.Rows.Count > 0 Then Int64bomversionid = grddata.CurrentRow.Cells("idyarnchange").Value
        Me.Hide()
    End Sub
End Class