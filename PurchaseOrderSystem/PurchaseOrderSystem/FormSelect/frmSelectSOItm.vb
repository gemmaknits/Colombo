Public Class frmSelectSOItm
    Dim clsUser As New classUserInfo
    Dim _soheaderid As String
    Dim _sono As String
    Dim _sonoid As String
    Dim _solineid As String
    Dim _DesignNo As String
    Dim _col As String
    Dim _qty As Decimal
    Dim _uom As String
    Dim _UomId As Nullable(Of Int64)
    Dim blnOk As Boolean = False
    Dim oConfig As New clsConfig

    Public Property UserInfo() As classUserInfo
        Get
            UserInfo = clsuser
        End Get
        Set(ByVal NewValue As classUserInfo)
            clsuser = NewValue
        End Set
    End Property
    Public Property pSoHeaderID As String
        Get
            pSoHeaderID = _soheaderid
        End Get
        Set(ByVal newvalue As String)
            _soheaderid = newvalue
        End Set
    End Property
    Public Property pSoNo As String
        Get
            pSoNo = _sono
        End Get
        Set(ByVal newvalue As String)
            _sono = newvalue
        End Set
    End Property
    Public Property pSoNoID As String
        Get
            pSoNoID = _sonoid
        End Get
        Set(ByVal Newvalue As String)
            _sonoid = Newvalue
        End Set
    End Property
    Public Property pSoLineID As String
        Get
            pSoLineID = _solineid
        End Get
        Set(ByVal Newvalue As String)
            _solineid = Newvalue
        End Set
    End Property
    Public Property pDesignNo As String
        Get
            pDesignNo = _DesignNo
        End Get
        Set(ByVal Newvalue As String)
            _DesignNo = Newvalue
        End Set
    End Property
    Public Property pCol As String
        Get
            pCol = _col
        End Get
        Set(ByVal NewValue As String)
            _col = NewValue
        End Set
    End Property
    Public Property pQty As Decimal
        Get
            pQty = _qty
        End Get
        Set(ByVal Newvalue As Decimal)
            _qty = Newvalue
        End Set
    End Property
    Public Property pUom As String
        Get
            pUom = _uom
        End Get
        Set(ByVal Newvalue As String)
            _uom = Newvalue
        End Set
    End Property
    Public Property pUomID As Nullable(Of Int64)
        Get
            pUomID = _UomId
        End Get
        Set(ByVal Newvalue As Nullable(Of Int64))
            _UomId = Newvalue
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
    Private Sub frmSelectSOItm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToParent()

        ' Me.StartPosition = FormStartPosition.CenterScreen
        Call GenGrid()
    End Sub
    Private Sub GenGrid()

        Dim objDB As New classSelectSoItm
        Dim dt As New DataTable
        dt = objDB.SearchSoItm(_sono)

        grddata.AutoGenerateColumns = False
        grddata.DataSource = dt
    End Sub

    Private Sub grddata_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles grddata.CellDoubleClick
        Call Getdata()
    End Sub

    Private Sub Getdata()
        If grddata.Rows.Count > 0 Then
            pSoHeaderID = grddata.CurrentRow.Cells("colsono").Value
            pSoNo = grddata.CurrentRow.Cells("colsono").Value
            pSoNoID = grddata.CurrentRow.Cells("colsonoid").Value
            pSoLineID = grddata.CurrentRow.Cells("colSoLineID").Value
            pDesignNo = grddata.CurrentRow.Cells("colDesignNo").Value
            pCol = grddata.CurrentRow.Cells("colCol").Value
            pQty = grddata.CurrentRow.Cells("colQty").Value
            pUomID = oconfig.isnull(grddata.CurrentRow.Cells("colUomID").Value, Nothing)
            pUom = grddata.CurrentRow.Cells("colUom").Value
            blnOk = True
        End If
        Me.Hide()
    End Sub

    Private Sub btnOk_Click(sender As Object, e As EventArgs) Handles btnOk.Click
        Call Getdata()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        blnOk = False
        Me.Hide()
    End Sub

    Private Sub txtFilter_KeyDown(sender As Object, e As KeyEventArgs) Handles txtFilter.KeyDown
        If e.KeyCode = Keys.Enter Then
            Call GenGrid()
        End If
    End Sub

End Class