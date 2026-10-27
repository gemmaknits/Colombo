Public Class classUserInfo
	Public UserID As String
	Public UserName As String
	Public Password As String
    Public ReportPath As String
	Public DeptCD As String
	Public CurrentDate As String
    Public ExchangeRate As Decimal '
    Public ExchangeRateTHB As Decimal '
    Public ExchangeRateUSD As Decimal '
    Public ExchangeRateJPY As Decimal '
    Public ExchangeRateAUD As Decimal '
    Public ExchangeRateCHF As Decimal '
    Public ExchangeRateEUR As Decimal '
    Public ExchangeRateHKD As Decimal '
    Public ExchangeRateRMB As Decimal 'BOT use CNY not use RMB
    Public ExchangeRateCNY As Decimal 'BOT use CNY not use RMB
    Public LogID As Long
	Public IPAddress As String
	Public CanChat As Boolean
	Public MessageWindowStyle As Integer = 1
    Public ImagePath As String
    Public MtlWareHouseID As Nullable(Of Int64)

End Class
