Public Class frmPackingListGreigeRelateRequest
#Region "History"
    'Create By    : Sitthana Boonlom
    'Create Date  : 20240723
    'Description  : Copy Some Code from frmPackingListDyed
#End Region

#Region "Property"
    Private _clsUserInfo As classUserInfo
    Private _ReqNo As String
    Private _CustomerName As String
    Private _PackNo As String
    Private _OutNo As String

    Public Property clsUserInfo As classUserInfo
        Get
            clsUserInfo = _clsUserInfo
        End Get
        Set(ByVal Newvalue As classUserInfo)
            _clsUserInfo = Newvalue
        End Set
    End Property

    Public Property ReqNo As String
        Get
            ReqNo = _ReqNo
        End Get
        Set(ByVal Newvalue As String)
            _ReqNo = Newvalue
        End Set
    End Property

    Public Property CustomerName As String
        Get
            CustomerName = _CustomerName
        End Get
        Set(ByVal Newvalue As String)
            _CustomerName = Newvalue
        End Set
    End Property

    Public Property PackNo As String
        Get
            PackNo = _PackNo
        End Get
        Set(ByVal Newvalue As String)
            _PackNo = Newvalue
        End Set
    End Property

    Public Property OutNo As String
        Get
            OutNo = _OutNo
        End Get
        Set(ByVal Newvalue As String)
            _OutNo = Newvalue
        End Set
    End Property
#End Region

    Private clsConn As New classConnection
    Private clsconfig As New clsConfig
    Private clsMaster As New classMaster
    Private clsPackingListG As New classPackingListG

    Private PackingNo As String = ""

    Private PackingListNo As String = "" 'get after saved
    Private strPacking_no As String = ""
    Private strOut_no As String = "" 'get after saved

    Private rptFileName As String = ""

    Private ErrNo As Integer = 0
    Private ErrMsg As String = ""

    Private Sub BtnExit_Click(sender As Object, e As EventArgs) Handles BtnExit.Click
        Me.Close()
    End Sub

    Private Sub frmPackingListGreigeRelateRequest_Load(sender As Object, e As EventArgs) Handles Me.Load
        initComboBox()
        InitControl()

        txtReqNo.Text = _ReqNo
        txtcustomer.Text = _CustomerName

        If clsconfig.IsNull(_PackNo, "").Trim <> "" Then
            txtPackNo.Text = clsconfig.IsNull(_PackNo, "").Trim
            Call GetCartonsData(txtPackNo.Text)
            Call SumGrdPackingList()
        Else
            GetREQG(_ReqNo)
        End If
    End Sub

    Private Sub initComboBox()
        With CboDoc_type
            .DataSource = clsMaster.GetDocType
            .DisplayMember = "name"
            .ValueMember = "doctyp"
        End With

        With CboCartonsNo
            .DataSource = grdDataCartons.DataSource
            .DisplayMember = "cartno"
            .ValueMember = "cartno"
        End With
    End Sub

    Private Sub InitControl()
        For Each obj In Me.Controls
            Call SetControlValue(obj)
        Next

        With grdDataPackingList
            .AutoGenerateColumns = False
            .DataSource = clsPackingListG.GetPackinglistGDataDetail("0", "0")
        End With

        With grdDataCartons
            .AutoGenerateColumns = False
            .DataSource = clsPackingListG.GetPackinglistGDataCartons("")
        End With

        With CboCartonsNo
            .DataSource = grdDataCartons.DataSource
            .DisplayMember = "cartno"
            .ValueMember = "cartno"
            .SelectedIndex = -1
        End With

        btngout.Enabled = False
        DtpOutdt.Enabled = False
        DtpOutdt.Checked = False
        BtnYarnPrintBar.Enabled = False
    End Sub

    Private Sub SetControlValue(ByVal Obj As Control)
        If TypeOf Obj Is TextBox Then
            Obj.Text = Obj.Tag
        End If
        If TypeOf Obj Is DateTimePicker Then
            Dim dtp As DateTimePicker = Obj
            dtp.Value = Now
        End If
        If TypeOf Obj Is ComboBox Then
            Dim cbo As ComboBox = Obj
            cbo.SelectedValue = 0
        End If
        If TypeOf Obj Is CheckBox Then
            Dim chk As CheckBox = Obj
            chk.Checked = False
        End If
        If TypeOf Obj Is RadioButton Then
            Dim opt As RadioButton = Obj
            opt.Checked = False
        End If
        If TypeOf Obj Is TabControl Or TypeOf Obj Is TabPage Or TypeOf Obj Is GroupBox Then
            Dim obj2 As Control
            For Each obj2 In Obj.Controls
                Call SetControlValue(obj2)
            Next
        End If
    End Sub

    Function GetCartonsData(ByVal StrPackno As String) As Boolean
        Dim dt As DataTable = clsPackingListG.GetPackinglistGDataCartons(StrPackno)
        'If dt.Rows.Count > 0 Then

        Call BindCartonsData(dt)
        SumCBM()
        Return True
    End Function

    Private Sub BindCartonsData(ByVal dt As DataTable)
        If txtPackNo.Text = "" Then Exit Sub
        Dim i As Integer = 0
        Dim j As Integer = 0
        grdDataCartons.AutoGenerateColumns = False
        grdDataCartons.DataSource = dt
        If dt.Rows.Count > 0 Then
            txtPackNo.Text = dt.Rows(0)("packno").ToString()
        End If
        CboCartonsNo.DataSource = grdDataCartons.DataSource
        CboCartonsNo.DisplayMember = "cartno"
        CboCartonsNo.ValueMember = "cartno"
        ' End If
    End Sub

    Private Sub SumCBM()
        With grdDataCartons
            If .Rows.Count > 0 Then
                Dim dblCBMCarton As Double = 0
                Dim dblCBMRoll As Double = 0

                For i As Integer = 0 To .Rows.Count - 1
                    dblCBMCarton += clsconfig.IsNull(.Rows(i).Cells("grdData_CBMForCarton").Value, 0)  'Sitthana 20220729
                    dblCBMRoll += clsconfig.IsNull(.Rows(i).Cells("grdData_CBMForRoll").Value, 0) 'Sitthana 20220729
                Next

                txtTotalCBMCarton.Text = Format(dblCBMCarton, "##0.000")
                txtTotalCBMRoll.Text = Format(dblCBMRoll, "##0.000")
            End If
        End With
    End Sub

    Private Function GetREQG(ByVal StrReqno As String) As Boolean
        Dim dt As DataTable = clsPackingListG.GetREQG(StrReqno)
        If dt.Rows.Count > 0 Then
            Call BindDataREQG(dt)
            CboDoc_type.SelectedValue = dt.Rows(0)("outreqtyp").ToString()
            Return True
        End If
        Return False
    End Function

    Private Sub BindDataREQG(ByVal dt As DataTable)
        Dim config As New clsConfig

        grdDataPackingList.AutoGenerateColumns = False
        If dt.Rows.Count > 0 Then
            Dim dt1 As DataTable = dt
            Dim dt2 As DataTable = grdDataPackingList.DataSource

            Dim dr As DataRow

            Dim msg As String = ""
            Dim i As Integer = 0
            Dim j As Integer = 0
            For i = 0 To dt.Rows.Count - 1
                'If (dt1.Rows(i)("sel").ToString) = True Then
                dr = dt2.NewRow



                For j = 0 To dt2.Columns.Count - 1
                    '(dt.Rows(0)("packdt").ToString)
                    dr("cartno") = dt1.Rows(i)("cartno")
                    dr("roll_no_g") = dt1.Rows(i)("roll_no_g")
                    dr("roll_no_o") = dt1.Rows(i)("roll_no_o")
                    dr("grade") = dt1.Rows(i)("grade")
                    dr("design_no") = dt1.Rows(i)("design_no")
                    'Format$(dblTestNumber, "##,##0.00")
                    'String.Format("{0:#,###0.00}", sumGrossAmt)
                    dr("outkg_g") = dt1.Rows(i)("outkg_g")
                    dr("outyd_g") = dt1.Rows(i)("outyd_g")
                    dr("outmt_g") = dt1.Rows(i)("outmt_g")
                    dr("sono") = dt1.Rows(i)("sono")
                    dr("sonoid") = dt1.Rows(i)("sonoid")
                    dr("Gwth") = dt1.Rows(i)("Gwth")
                    dr("outreqno") = dt1.Rows(i)("outreqno")
                    dr("outreqdt") = dt1.Rows(i)("outreqdt")
                    dr("outreqtyp") = dt1.Rows(i)("outreqtyp")
                    dr("pono") = dt1.Rows(i)("pono")
                    dr("preseted") = dt1.Rows(i)("preseted")
                    'dr("sono") = config.IsNull(dt1.Rows(i)("sono"), "")
                    'dr("sonoid") = config.IsNull(dt1.Rows(i)("sonoid"), "")
                    'Disible By Neung 14/03/2015
                    'dr(dt2.Columns(j).ColumnName.Trim) = dt1.Rows(i)(dt2.Columns(j).ColumnName.Trim)
                Next
                dt2.Rows.Add(dr)

            Next

        End If
        Call SumGrdPackingList()


        'grdDataPackingList.DataSource = dt
        'txtReqNo.Text = dt.Rows(0)("outreqno").ToString()
    End Sub

    Private Sub SumGrdPackingList()

        Dim config As New clsConfig
        Dim i As Integer = 0
        Dim j As Integer = 0
        Dim dblKgs As Double = 0
        Dim dblMts As Double = 0
        Dim dblYds As Double = 0

        'Dim netwt As Double = 0.0
        Dim netwt As Single = 0.0
        ' Dim anetwt As Double = 0.0
        Dim anetwt As Single = 0.0
        Dim CartMts As Double = 0.0
        Dim CartYds As Double = 0.0
        Dim totalroll As Double = 0


        If grdDataCartons.Rows.Count > 0 Then
            For j = 0 To grdDataCartons.Rows.Count - 2
                For i = 0 To grdDataPackingList.Rows.Count - 1
                    If config.IsNull(grdDataCartons.Rows(j).Cells("grdDataCartons_cartno").Value, 0) = config.IsNull(grdDataPackingList.Rows(i).Cells("grdDataPackingList_cartno").Value, 0) Then

                        netwt = netwt + config.IsNull(grdDataPackingList.Rows(i).Cells("grdDataPackingList_outkg_g").Value, 0)
                        anetwt = 0.0


                        CartMts = CartMts + config.IsNull(grdDataPackingList.Rows(i).Cells("grdDataPackingList_outmt_g").Value, 0)


                        CartYds = CartYds + config.IsNull(grdDataPackingList.Rows(i).Cells("grdDataPackingList_outyd_g").Value, 0)

                        totalroll = totalroll + 1
                    End If
                Next

                grdDataCartons.Rows(j).Cells("grdDataCartons_netwt").Value = netwt 'FormatNumber(netwt, 2, TriState.False, TriState.False, TriState.True)
                netwt = 0
                grdDataCartons.Rows(j).Cells("CartMts").Value = CartMts 'FormatNumber(CartMts, 2, TriState.False, TriState.False, TriState.True)
                CartMts = 0
                grdDataCartons.Rows(j).Cells("CartYds").Value = CartYds 'FormatNumber(CartYds, 2, TriState.False, TriState.False, TriState.True)

                grdDataCartons.Rows(j).Cells("grdDataCartons_CartRolls").Value = totalroll
                grdDataCartons.Rows(j).Cells("grdData_CBMForRoll").Value = clsconfig.IsNull(grdDataCartons.Rows(j).Cells("grdData_CBMForCarton").Value, 0) * totalroll 'Sitthana 20220723
                CartYds = 0

                totalroll = 0
            Next
        End If

        For i = 0 To grdDataPackingList.Rows.Count - 1
            dblKgs = dblKgs + config.IsNull(grdDataPackingList.Rows(i).Cells("grdDataPackingList_outkg_g").Value, 0)
            dblMts = dblMts + config.IsNull(grdDataPackingList.Rows(i).Cells("grdDataPackingList_outmt_g").Value, 0)
            dblYds = dblYds + config.IsNull(grdDataPackingList.Rows(i).Cells("grdDataPackingList_outyd_g").Value, 0)
        Next

        txtTotalRolls.Text = FormatNumber(grdDataPackingList.Rows.Count, 0, TriState.False, TriState.False, TriState.True)
        txtTotalKgs.Text = FormatNumber(dblKgs, 2, TriState.False, TriState.False, TriState.True)
        txtTotalMts.Text = FormatNumber(dblMts, 2, TriState.False, TriState.False, TriState.True)
        txtTotalYds.Text = FormatNumber(dblYds, 2, TriState.False, TriState.False, TriState.True)

        Call AutoDeleteCarton()
    End Sub

    Private Sub AutoDeleteCarton()
        Call grdDataCartons.ClearSelection()

        If grdDataCartons.Rows.Count > 0 Then
            Dim i As Integer = 0
            Dim dt As New DataTable
            dt = grdDataCartons.DataSource
            Dim expression As String
            expression = "netwt = 0 or cartno = '0'"

            Dim foundRow As DataRow() = dt.Select(expression)

            For Each row As DataRow In foundRow
                row.Delete()
            Next
        End If
    End Sub

    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click

    End Sub
End Class
