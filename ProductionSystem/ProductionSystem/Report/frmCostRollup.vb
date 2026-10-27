Public Class frmCostRollup
#Region "Parameter"
    Dim oConn As New classConnection
    Dim clsUser As New classUserInfo

    Public Property UserInfo() As classUserInfo
        Get
            UserInfo = clsUser
        End Get
        Set(ByVal NewValue As classUserInfo)
            clsUser = NewValue
        End Set
    End Property

#End Region

#Region "Constat Value"
    Const ITEM_NATURE_FABRIC As String = "FABRIC"

#End Region

    Private SiteName As String = "Eschler"

    Private Sub btnSelectYarnCode_Click(sender As Object, e As EventArgs) Handles btnSelectYarnCode.Click

    End Sub
    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        'Sitthana 20191109
        Dim f As New Classes.formSearchItemcode
        Dim drv As DataRowView
        Dim SearchResult As New Classes.SearchFormResult

        ' pass nothing to use default connection string inside the class or pass your connection object if need to use different from default.
        f.setConnectionString(oConn.getSQLConnection)
        f.ItemNatureCD = ITEM_NATURE_FABRIC
        f.ItemCD = txtItemCode.Text.Trim

        SearchResult = f.ShowItems
        f.Close()
        f.Dispose()
        If SearchResult.ButtonClicked = "OK" Then
            drv = SearchResult.ResultRowView
            If IsNothing(SearchResult.ResultRowView) Then
                MessageBox.Show("Not select data", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error)

                txtItemCode.Text = ""
                txtItemName.Text = ""
                txtCompo.Text = ""
            Else
                txtItemCode.Text = drv.Item("itcd")
                txtCompo.Text = drv.Item("itdesc2")
                Select Case SiteName
                    Case "GMK"
                        txtItemName.Text = drv.Item("itdesc_spec")
                    Case "Eschler"
                        txtItemName.Text = drv.Item("itdesc")
                    Case Else
                        txtItemName.Text = drv.Item("itdesc_spec")
                End Select
            End If
        End If
    End Sub


End Class