Public Class frmSelectItems
    Dim itemID As String
    Dim itcd As String
    Dim itdesc As String
    Dim itdescSupp As String
    Dim uomID As Nullable(Of Int64)
    Dim uom As String
    Dim blnOk As Boolean = False

    Public Property pItemID As String
        Get
            pItemID = itemID
        End Get
        Set(ByVal newvalue As String)
            itemID = newvalue
        End Set
    End Property
    Public Property pItcd As String
        Get
            pItcd = itcd
        End Get
        Set(ByVal newvalue As String)
            itcd = newvalue
        End Set
    End Property
    Public Property pItdesc As String
        Get
            pItdesc = itdesc
        End Get
        Set(ByVal newvalue As String)
            itdesc = newvalue
        End Set
    End Property
    Public Property pItdescSupp As String
        Get
            pItdescSupp = itdescSupp
        End Get
        Set(ByVal newvalue As String)
            itdescSupp = newvalue
        End Set
    End Property
    Public Property pUomID As Nullable(Of Int64)
        Get
            pUomID = uomID
        End Get
        Set(ByVal newvalue As Nullable(Of Int64))
            uomID = newvalue
        End Set
    End Property
    Public Property pUom As String
        Get
            pUom = uom
        End Get
        Set(ByVal newvalue As String)
            uom = newvalue
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

    Private Sub frmSelectItems_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToParent()
        'Me.StartPosition = FormStartPosition.CenterScreen
        Call GenGrid()
        txtFilter.Focus()
    End Sub

    Private Sub GenGrid()
        Dim objDB As New classSelectItems
        Dim dt As New DataTable
        dt = objDB.SearchItems(txtFilter.Text)

        grddata.AutoGenerateColumns = False
        grddata.DataSource = dt
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs)

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
            itemID = grddata.CurrentRow.Cells("colItemId").Value
            itcd = grddata.CurrentRow.Cells("colItcd").Value
            itdesc = (New clsConfig).IsNull(grddata.CurrentRow.Cells("colItdesc").Value, "")
            itdescSupp = (New clsConfig).IsNull(grddata.CurrentRow.Cells("colItdescSupp").Value, "")
            uomID = (New clsConfig).IsNull(grddata.CurrentRow.Cells("colUomId").Value, Nothing)
            uom = (New clsConfig).IsNull(grddata.CurrentRow.Cells("colUom").Value, String.Empty)
            blnOk = True
        End If
        Me.Hide()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        blnOk = False
        Me.Close()
    End Sub
End Class