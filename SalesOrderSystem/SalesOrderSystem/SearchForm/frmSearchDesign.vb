Public Class frmSearchDesign
    Dim strDesignno As String = ""
    Public Property pDesignNo As String
        Get
            pDesignNo = strDesignno
        End Get
        Set(ByVal Newvalue As String)
            strDesignno = Newvalue
        End Set
    End Property

    Private Sub frmSearchDesign_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Call gengrid()

    End Sub
    Private Sub gengrid()
        Dim config As New clsConfig
        Dim objdb As New classMaster
        Dim dt As New DataTable
        dt = objdb.GetDesign()
        If dt.Rows.Count > 0 Then
            strDesignno = dt.Rows(0)("design_no")
        End If
        grddata.AutoGenerateColumns = False
        grddata.DataSource = dt
    End Sub

    Private Sub grddata_CellContentClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles grddata.CellContentClick

    End Sub

    Private Sub grddata_CellDoubleClick(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles grddata.CellDoubleClick
        If grddata.Rows.Count > 0 Then strDesignno = grddata.CurrentRow.Cells("Design_no").Value
        Me.Hide()
    End Sub
End Class