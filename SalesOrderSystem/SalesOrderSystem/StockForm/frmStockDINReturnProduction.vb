Public Class frmStockDINReturnProduction
    Dim clsConn As New classConnection
    Dim clsConfig As New clsConfig
    Dim clsUser As New classUserInfo
    Public Property UserInfo() As classUserInfo
        Get
            UserInfo = clsUser
        End Get
        Set(ByVal NewValue As classUserInfo)
            clsUser = NewValue
        End Set
    End Property



End Class