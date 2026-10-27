Imports System.Data
Imports System.Data.SqlClient
Imports System.Text
Imports System.Net
Imports RestSharp
Public Class classLogin

    Public Function CheckConnection(ByRef pmssger As String) As Boolean
        Dim result As Boolean = True
        Dim conn As New SqlConnection((New classConnection).connection)

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
