Imports System.Data.Sql
Imports System.data.SqlClient
Imports System.Globalization

Public Class clsConfig


    Public Function IsValidDate(ByVal DateData As Object) As Date
        If IsDBNull(DateData) Then
            Return Today.Date()
        Else
            Return DateData
        End If
    End Function

    Public Function IsValidString(ByVal Isstr As String) As String
        If Isstr = Nothing Then
            Return ""
        ElseIf IsDBNull(Isstr) Then
            Return ""
        Else
            Return Isstr
        End If
    End Function

    Public Function IsValidBoolean(ByVal Isarr_tblPur As Boolean) As Boolean
        If IsDBNull(Isarr_tblPur) Then
            Return False
        Else
            Return Isarr_tblPur
        End If
    End Function

    Public Function IsValidinteger(ByVal Isinteger As Integer) As Integer
        If IsDBNull(Isinteger) Then
            Return 0
        Else
            Return Isinteger
        End If
    End Function

    Public Function IsValidDouble(ByVal Isdouble As Double) As Double
        If IsNothing(Isdouble) Then
            Return Convert.ToDouble(0)
        Else
            Return Isdouble
        End If
    End Function

    Public Function IsValidDecimal(ByVal IsDecimal As Decimal) As Decimal
        If IsNothing(IsDecimal) Then
            Return Convert.ToDecimal(0)
        Else
            Return IsDecimal
        End If
    End Function

    Public Function ConvertFormatDateTostring(ByVal FieldDate As Object) As String
        Dim Day As String
        Dim Month As String
        Dim Year As String
        Dim NewStrDate As String
        Day = Mid(FieldDate, 1, 2)
        Month = Mid(FieldDate, 4, 2)
        Year = Mid(FieldDate, 7, 4)
        NewStrDate = Year + "/" + Month + "/" + Day
        Return NewStrDate
    End Function

    Public Function GetCultureDate(ByVal testDate As DateTime, ByVal cultureName As String) As String
        ' Create the CultureInfo object for the specified culture,
        ' and use it as the IFormatProvider when converting the date.
        Dim culture As CultureInfo = New CultureInfo(cultureName)
        Dim dateString As String = Convert.ToString(testDate, culture)
        ' Bracket the culture name, and display the name and date.
        Return dateString
    End Function

    Public Sub ChangeCulture(Optional ByVal strCulture As String = "en-GB")
        Dim Thread As System.Threading.Thread = System.Threading.Thread.CurrentThread
        Thread.CurrentCulture = New CultureInfo(strCulture)
        Thread.CurrentUICulture = New CultureInfo(strCulture)
        'MsgBox(System.Globalization.CultureInfo.CurrentUICulture.DateTimeFormat.ShortDatePattern)
        'MsgBox(Now.ToString("dd/MM/yyyy"))
    End Sub

    Public Function CheckReport(ByVal strRptPath As String, ByVal strReport As String, Optional ByVal showErrorMessage As Boolean = True) As Boolean
        CheckReport = True
        If Not FileIO.FileSystem.DirectoryExists(strRptPath) Then
            If showErrorMessage Then
                MessageBox.Show("Report Path (" & Chr(32) & strRptPath & Chr(32) & ") is not found.", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly, False)
            End If
            CheckReport = False
        Else
            If Not FileIO.FileSystem.FileExists(strRptPath & strReport) Then
                If showErrorMessage Then
                    MessageBox.Show("Report File is not found.", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly, False)
                End If
                CheckReport = False
            End If
        End If
    End Function
    Public Function IsNull(ByVal obj1 As Object, ByVal obj2 As Object) As Object
        IsNull = obj1
        If IsDBNull(obj1) Or TypeOf obj1 Is VariantType Or IsNothing(obj1) Or obj1 Is Nothing Then
            IsNull = obj2
        Else
            Select Case VarType(obj1)
                Case VariantType.String
                    If RTrim(obj1) = "" Then IsNull = obj2
                Case VariantType.Long
                    If Val(obj1) = 0 Then IsNull = obj2
                Case VariantType.Double
                    If Val(obj1) = 0 Then IsNull = obj2
                Case VariantType.Integer
                    If Val(obj1) = 0 Then IsNull = obj2
                Case VariantType.Decimal
                    If Val(obj1) = 0 Then IsNull = obj2
                Case VariantType.Date
                    If obj1 = CDate("01/01/1900") Then IsNull = obj2
                Case VariantType.Boolean
                    If obj1 = True Then IsNull = obj2
                Case Else
                    IsNull = obj1
            End Select
        End If
    End Function

    Public Function BuildSQL(ByVal comm As SqlClient.SqlCommand) As String
        Dim sql As String = ""
        Dim i As Integer = 0
        sql = comm.CommandText & " "
        For i = 0 To comm.Parameters.Count - 1
            sql = sql & comm.Parameters(i).ParameterName & "='" & comm.Parameters(i).Value & "'"
            If i < comm.Parameters.Count - 1 Then sql = sql & ","
        Next
        BuildSQL = sql
    End Function
    Public Function UserAccess(ByVal UserId As String, ByVal MenuId As String, Optional ByVal AccessType As String = "MENU") As Boolean
        Dim conn As New SqlConnection((New classConnection).Connection)
        Dim comm As New SqlCommand("", conn)
        Dim sql As String
        sql = "select dbo.fn_UserAccess('" + UserId + "','" + MenuId + "','" + AccessType + "')"

        comm.CommandType = CommandType.Text
        comm.CommandText = sql

        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        If Not dt Is Nothing Then
            If dt.Rows(0).Item(0) = True Then
                UserAccess = True
            Else
                UserAccess = False
            End If
        End If
    End Function
    Public Sub UpdatePassword(ByVal strUsername As String, ByVal strPassword As String)
        'Create By Sitthana
        Dim conn As New SqlConnection((New classConnection).Connection)
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "p_login_pkg_update_password   " '"p_change_password"  'Sitthana 18/01/2018
        comm.Parameters.AddWithValue("@empname", strUsername.Trim)
        comm.Parameters.AddWithValue("@password", strPassword.Trim)
        conn.Open()
        comm.ExecuteNonQuery()
        conn.Close()  'Sitthana 20190325
    End Sub
End Class
