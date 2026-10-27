' Popup "LOV"-style dialog: shows the candidate price line(s) returned by
' SO.P_SO_PRICE_LIST_PKG_select_price_line for one order line's design/color/uom/qty,
' and lets the user pick one. Always shown, even when there is only one candidate.
' -- John 29/09/2026
Public Class frmSelectPriceLine
    Private _selectedDetailId As Nullable(Of Int64)

    ''' <summary>Unit price and currency of the row the user picked, so the caller
    ''' can push them onto the SO line alongside the detail id. -- John 01/10/2026</summary>
    Private _selectedPrice As Nullable(Of Decimal)
    Private _selectedCurrency As String
    Public ReadOnly Property SelectedPrice As Nullable(Of Decimal)
        Get
            Return _selectedPrice
        End Get
    End Property
    Public ReadOnly Property SelectedCurrency As String
        Get
            Return _selectedCurrency
        End Get
    End Property

    ''' <summary>
    ''' Pass the calling form as owner -- without it, ShowDialog() in this MDI app
    ''' can open the modal dialog behind the main window's Z-order: it's really
    ''' open and blocking, just invisible, which looks exactly like "no popup".
    ''' -- John 30/09/2026
    ''' </summary>
    Public Function ShowAndSelect(dt As DataTable, owner As IWin32Window) As Nullable(Of Int64)
        _selectedDetailId = Nothing
        dgvResults.AutoGenerateColumns = True
        dgvResults.DataSource = dt
        ConfigureColumns()
        If dgvResults.Rows.Count > 0 Then dgvResults.Rows(0).Selected = True
        Me.ShowDialog(owner)
        Return _selectedDetailId
    End Function

    Private Sub ConfigureColumns()
        Dim hiddenCols() As String = {"so_price_list_header_id", "so_price_list_detail_id", "set_no", "line_no"}
        For Each colName In hiddenCols
            If dgvResults.Columns.Contains(colName) Then dgvResults.Columns(colName).Visible = False
        Next

        Dim headers As New Dictionary(Of String, String) From {
            {"matched_design_no", "Design No"},
            {"color_tier", "Color Tier"},
            {"qty_min", "Qty Min"},
            {"qty_max", "Qty Max"},
            {"uom", "UOM"},
            {"curr", "Currency"},
            {"price", "Price"},
            {"notes", "Notes"},
            {"resolution", "Resolution"}
        }
        For Each kv In headers
            If dgvResults.Columns.Contains(kv.Key) Then dgvResults.Columns(kv.Key).HeaderText = kv.Value
        Next
    End Sub

    Private Sub btnSelect_Click(sender As Object, e As EventArgs) Handles btnSelect.Click
        CommitSelection()
    End Sub

    Private Sub dgvResults_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvResults.CellDoubleClick
        If e.RowIndex >= 0 Then CommitSelection()
    End Sub

    Private Sub CommitSelection()
        If dgvResults.CurrentRow Is Nothing Then
            MessageBox.Show("Please select a price line.", "Select Price Line", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If

        Dim raw As Object = dgvResults.CurrentRow.Cells("so_price_list_detail_id").Value
        If raw Is Nothing OrElse IsDBNull(raw) Then
            _selectedDetailId = Nothing
        Else
            _selectedDetailId = Convert.ToInt64(raw)
        End If

        Dim priceRaw As Object = dgvResults.CurrentRow.Cells("price").Value
        _selectedPrice = If(priceRaw Is Nothing OrElse IsDBNull(priceRaw), Nothing, CType(Convert.ToDecimal(priceRaw), Decimal?))

        Dim currRaw As Object = dgvResults.CurrentRow.Cells("curr").Value
        _selectedCurrency = If(currRaw Is Nothing OrElse IsDBNull(currRaw), Nothing, currRaw.ToString.Trim)

        Me.DialogResult = DialogResult.OK
        Me.Close()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        _selectedDetailId = Nothing
        _selectedPrice = Nothing
        _selectedCurrency = Nothing
        Me.DialogResult = DialogResult.Cancel
        Me.Close()
    End Sub
End Class
