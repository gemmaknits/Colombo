Public Class frmSearchPDF
    Dim Strsonoid As String
    Dim Int64Poc_pdf_header_id As Nullable(Of Int64)
    Dim Dtpoc_pdf_header As DataTable
    Dim strpoc_pdf_header() As String

    Public Property pSoNoID As String
        Get
            pSoNoID = Strsonoid
        End Get
        Set(ByVal NewValue As String)
            Strsonoid = NewValue
        End Set
    End Property

    Public Property pPoc_pdf_header_id As Nullable(Of Int64)
        Get
            pPoc_pdf_header_id = Int64Poc_pdf_header_id
        End Get
        Set(ByVal NewValue As Nullable(Of Int64))
            Int64Poc_pdf_header_id = NewValue
        End Set
    End Property

    Public Property pPoc_pdf_header As DataTable
        Get
            pPoc_pdf_header = Dtpoc_pdf_header
        End Get
        Set(ByVal NewValue As DataTable)
            Dtpoc_pdf_header = Newvalue
        End Set
    End Property

    Private Sub GenGrid()
        Dim objDB As New classSearchPDF
        Dim dt As New DataTable
        txtSoNoID.Text = Strsonoid
        dt = objDB.SearchPDF(Strsonoid)
        If dt.Rows.Count > 0 Then
            'Int64Poc_pdf_header_id = dt.Rows(0)("poc_pdf_header_id")
        End If
        grdData.AutoGenerateColumns = False
        grdData.DataSource = dt
    End Sub

    Private Sub frmSearchPDF_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        GenGrid()
    End Sub

    Private Sub btnRefresh_Click(sender As System.Object, e As System.EventArgs) Handles btnRefresh.Click
        GenGrid()
    End Sub

    Private Sub grdData_CellContentClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles grdData.CellContentClick

    End Sub

    Private Sub grdData_CellDoubleClick(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles grdData.CellDoubleClick
        If grdData.Rows.Count > 0 Then Int64Poc_pdf_header_id = grdData.CurrentRow.Cells("poc_pdf_header_id").Value
        Me.Hide()
    End Sub

    Private Sub btnMinimized_Click(sender As System.Object, e As System.EventArgs) Handles btnMinimized.Click

    End Sub

    Private Sub btnExit_Click(sender As System.Object, e As System.EventArgs) Handles btnExit.Click

        Me.Close()
    End Sub
End Class