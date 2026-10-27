Public Class formJobOrderYarnNewEditSelectProductionLine
    Dim _blnOk As Boolean = False
    Dim _GB As String
    Dim _MfgProductionOrderLineID As Nullable(Of Int64)
    Dim _KoNo As String
    Dim _Itcd As String
    Public Property pblnOk As Boolean
        Get
            pblnOk = _blnOk
        End Get
        Set(ByVal NewValue As Boolean)
            _blnOk = NewValue
        End Set
    End Property
    Public Property pGb As String
        Get
            pGb = _GB
        End Get
        Set(ByVal Newvalue As String)
            _GB = Newvalue
        End Set
    End Property
    Public Property pMfgProductionOrderLineID As Nullable(Of Int64)
        Get
            pMfgProductionOrderLineID = _MfgProductionOrderLineID
        End Get
        Set(ByVal NewValue As Nullable(Of Int64))
            _MfgProductionOrderLineID = NewValue
        End Set
    End Property
    Public Property pKoNo As String
        Get
            pKoNo = _KoNo
        End Get
        Set(ByVal NewValue As String)
            _KoNo = NewValue
        End Set
    End Property
    Public Property pItcd As String
        Get
            pItcd = _Itcd
        End Get
        Set(ByVal Newvalue As String)
            _Itcd = Newvalue
        End Set
    End Property

    Private Sub formJobOrderYarnNewEditSelectProductionLine_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.StartPosition = FormStartPosition.CenterScreen
        Call GenGrid()
    End Sub

    Private Sub GenGrid()
        Dim objDB As New classJobOrderYarnSelectProductionLine
        Dim dt As New DataTable
        dt = (New classJobOrderYarnSelectProductionLine).SearchItems(_itnaturecd:="", _Kono:=pKoNo, StrFilter:=txtFilter.Text)

        grddata.AutoGenerateColumns = False
        grddata.DataSource = dt
    End Sub


    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click

        Call GenGrid()

    End Sub

    Private Sub txtFilter_KeyDown(sender As Object, e As KeyEventArgs) Handles txtFilter.KeyDown
        If e.KeyCode = Keys.Enter Then
            Call GenGrid()
        End If
    End Sub

    Private Sub grddata_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles grddata.CellDoubleClick
        Call Getdata()

    End Sub

    Private Sub btnOk_Click(sender As Object, e As EventArgs) Handles btnOk.Click
        Call Getdata()
    End Sub

    Private Sub Getdata()
        If grddata.Rows.Count > 0 Then
            _MfgProductionOrderLineID = grddata.CurrentRow.Cells("colMfgProductionOrderLinesId").Value
            _GB = grddata.CurrentRow.Cells("colGb").Value
            _blnOk = True
        End If
        'blnOk = True
        Me.Hide()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        _blnOk = False
        Me.Close()
    End Sub
End Class