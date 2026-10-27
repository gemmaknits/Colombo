Imports System.Data
Imports System.Data.SqlClient
Imports System.Text
Imports System.Net
Imports RestSharp
Public Class classLogin
    Dim oConfig As New clsConfig
    Public Function selectExchageRateRecord(ByVal pCurrFr As String, ByVal pCurrTo As String, ByVal pCurrDate As DateTime) As Decimal
        Dim conn As New SqlConnection((New classConnection).Connection)
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "P_EXCHANGE_RATE_PKG_select_exchange_rate_record"
        comm.Parameters.Clear()
        comm.Parameters.AddWithValue("@p_curr_fr", pCurrFr) 'USD and ETC
        comm.Parameters.AddWithValue("@p_curr_to", pCurrTo) 'THB
        comm.Parameters.AddWithValue("@p_curr_date", pCurrDate) 'Date
        Dim pExchangeRate As New SqlParameter("@p_exchange_rate", SqlDbType.Decimal)
        With pExchangeRate
            ' Set precision and scale and Direction
            .Precision = 18
            .Scale = 4
            .Direction = ParameterDirection.Output
        End With
        comm.Parameters.Add(pExchangeRate)
        comm.Parameters("@p_exchange_rate").Precision = 18
        comm.Parameters("@p_exchange_rate").Scale = 4
        comm.Parameters("@p_exchange_rate").Direction = ParameterDirection.Output
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        comm.Connection.Close()
        selectExchageRateRecord = oConfig.IsNull(pExchangeRate.Value, 0) 'clsConfig.IsNull(comm.Parameters("@p_exchange_rate").Value, 0)
        Return selectExchageRateRecord
    End Function
    Public Function GetExchangeRateAPIByDate(ByVal currency As String, ByVal SPeriod As DateTime, ByVal EPeriod As DateTime) As Decimal
        On Error Resume Next
        'ดึงข้อมูลจาก ธนาคารแห่งประเทศไทย แบบ Realtime ถ้ายังเป็นวันใหม่ๆ ธนาคารยังไม่อัพเดทให้
        Dim ExchangeRate As Decimal = 0
        'If SPeriod.Date = Now.Date And (SPeriod.Hour > 0 And SPeriod.Hour < 18) Then GoTo EX
        If currency.Trim = "THB" Then
            ExchangeRate = 1
            GoTo EX 'กรณ๊ที่เป็นไทยบาท 
        Else
            ExchangeRate = selectExchageRateRecord(currency, "THB", SPeriod)
            If ExchangeRate > 0 Then
                GoTo EX
            End If
        End If
        ServicePointManager.SecurityProtocol = DirectCast(3072, SecurityProtocolType) 'Protocol tls12 = 3072

        '=========================================== Get Data From Current Date ===============================================================

        Dim startPeriod As String
        Dim endPeriod As String
BEGIN:
        startPeriod = SPeriod.ToString("yyyy-MM-dd")
        endPeriod = EPeriod.ToString("yyyy-MM-dd")
        Dim client As New RestClient("https://gateway.api.bot.or.th/Stat-ExchangeRate/v2/DAILY_AVG_EXG_RATE/?start_period=" + startPeriod + "&end_period=" + endPeriod + "&currency=" + currency)
        Dim request = New RestRequest(Method.GET)
        request.AddHeader("Authorization", "eyJvcmciOiI2NzM1NzgwZWM4YzFlYjAwMDEyYTM3NzEiLCJpZCI6ImY5NzllNGRhYjllNjQyZjFiMGFmNWJiYzI5YTRlYzcyIiwiaCI6Im11cm11cjEyOCJ9") ' John 09/01/2026 'Client ID
        request.AddHeader("accept", "undefined")

        Dim response As IRestResponse = client.Execute(request)
        If (response.StatusCode.Equals(HttpStatusCode.OK)) Then
            Console.WriteLine(response.Content)
            ExchangeRate = response.Content.ToString.Substring(InStr(response.Content.ToString, "buying_sight") + 14, 8) 'Add By Neung 20151028 buying_sight คืำ ตำแหน่ง + 14 นับจาก b และ 10 คือข้อมูล
            If ExchangeRate = 0 Then
                SPeriod = SPeriod.AddDays(-1)
                EPeriod = EPeriod.AddDays(-1)
                GoTo BEGIN
            End If
        End If
EX:
        Return ExchangeRate
    End Function
    Public Function CheckConnection(ByRef pmssger As String) As Boolean
        Dim result As Boolean = True
        Dim conn As New SqlConnection((New classConnection).Connection)

        Try
            ' ตรวจสอบว่าการเชื่อมต่อปิดอยู่ก่อนเปิด
            If conn.State = ConnectionState.Closed Then
                conn.Open()
            End If
            ' ถ้าผ่านจุดนี้ แสดงว่าเชื่อมต่อได้
            result = True

        Catch ex As Exception
            result = False
            pmssger = ex.Message
            'MsgBox(ex.Message)
        Finally
            ' ปิดการเชื่อมต่อถ้าถูกเปิดโดยฟังก์ชันนี้
            If conn.State = ConnectionState.Open Then
                conn.Close()
            End If
        End Try

        conn.Close()
        Return result
    End Function
End Class
