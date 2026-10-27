Public Class frmSelectSO
    Dim clsUser As New classUserInfo
    Dim _soheaderid As String
    Dim _sono As String
    Dim _sonoid As String
    Dim _solineid As String
    Dim blnOk As Boolean = False

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

        Call GenGrid("")
    End Sub
    Private Sub GenGrid(ByVal _filter As String)

        Dim objDB As New classSelectSo
        Dim dt As New DataTable
        dt = objDB.SearchSo(_filter)

        grddata.AutoGenerateColumns = False
        grddata.DataSource = dt
    End Sub

    Private Sub grddata_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles grddata.CellDoubleClick
        Call Getdata()
    End Sub

    Private Sub Getdata()
        If grddata.Rows.Count > 0 Then
            pSoHeaderID = grddata.CurrentRow.Cells("colSoHeaderId").Value
            pSoNo = grddata.CurrentRow.Cells("colsono").Value
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
            Call GenGrid(txtFilter.Text.Trim)
        End If
    End Sub


End Class