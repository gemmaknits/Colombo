Public Class frmSearchMFGRouting
    Dim Strmfg_routing_header_id As String = ""
    Dim Strrouting_code As String = ""
    Dim clsUser As New classUserInfo
    Dim _MfgRoutingHearder As mfg_routing_hearder
    Dim _UserAction As String 'Ok or None or Exit
    Public Property pUserAction As String
        Get
            pUserAction = _UserAction
        End Get
        Set(ByVal Newvalue As String)
            _UserAction = Newvalue
        End Set
    End Property

    Public Property pMfgRoutingHearder As mfg_routing_hearder
        Get
            pMfgRoutingHearder = _MfgRoutingHearder
        End Get
        Set(ByVal NewValue As mfg_routing_hearder)
            _MfgRoutingHearder = NewValue
        End Set
    End Property

    'Public Property pmfg_routing_header_id() As String
    '    Get
    '        pmfg_routing_header_id = Strmfg_routing_header_id
    '    End Get
    '    Set(ByVal NewValue As String)
    '        Strmfg_routing_header_id = NewValue
    '    End Set
    'End Property

    Public Property Prouting_code() As String
        Get
            Prouting_code = Strrouting_code
        End Get
        Set(ByVal Newvalue As String)
            Strrouting_code = Newvalue
        End Set

    End Property

    Private Sub GenGrid()
        Dim objDB As New classSearchMFGRouting
        Dim dt As New DataTable
        dt = objDB.SearchMFGRouting(txtStrrouting_code.Text)

        grddata.AutoGenerateColumns = False
        grddata.DataSource = dt
    End Sub

    Private Sub frmSearchMFGRouting_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        GenGrid()
    End Sub

    Private Sub txtStrrouting_code_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles txtStrrouting_code.KeyDown
        If e.KeyCode = Keys.Enter Then
            GenGrid()
        End If
    End Sub

    Private Sub grddata_CellDoubleClick(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles grddata.CellDoubleClick
        If grddata.Rows.Count > 0 Then
            _MfgRoutingHearder.mfg_routing_header_id = grddata.CurrentRow.Cells("colMfgRoutingHeaderId").Value
            _MfgRoutingHearder.routing_code = grddata.CurrentRow.Cells("routing_code").Value
            Strrouting_code = grddata.CurrentRow.Cells("routing_code").Value
            _UserAction = "OK"
            Me.Hide()
        End If
        Me.Hide()
    End Sub

    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        If grddata.Rows.Count > 0 Then
            _MfgRoutingHearder.mfg_routing_header_id = grddata.CurrentRow.Cells("colMfgRoutingHeaderId").Value
            _MfgRoutingHearder.routing_code = grddata.CurrentRow.Cells("routing_code").Value
            Strrouting_code = grddata.CurrentRow.Cells("routing_code").Value
            _UserAction = "OK"
        End If
        Me.Close()
    End Sub
End Class