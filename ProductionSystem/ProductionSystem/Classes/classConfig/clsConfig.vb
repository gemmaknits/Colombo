Imports System.Data.SqlClient
Imports System.Globalization

Public Class classResult
    Public Success As Boolean
    Public Message As String
End Class

Public Class classSecurity
    Const useSecurityMenu As Boolean = False
    Public dtSecurity As New DataTable

    Public Sub LoadMenus(ByVal Userid As String)
        Dim conn As New SqlConnection((New classConnection).connection)
        Dim comm As New SqlCommand("", conn)
        Dim sql As String

        sql = "select * from v_user_security_using_role where empcd='" & Userid & "'"

        comm.CommandType = CommandType.Text
        comm.CommandText = sql

        Dim da As New SqlDataAdapter(comm)
        da.Fill(dtSecurity)
        conn.Close()  'Sitthana 20190325
    End Sub

    Public Function UserAccess(ByVal UserId As String, ByVal MenuId As String, Optional ByVal AccessType As String = "MENU") As Boolean
        If useSecurityMenu Then
            Dim rows As DataRow() = dtSecurity.Select("empcd='" & UserId & "'" & " And menuid='" & MenuId & "'")
            For Each r As DataRow In rows
                If Trim(r("menuid")) = Trim(MenuId) Then
                    UserAccess = True
                    Exit Function
                End If
            Next
            UserAccess = False
        Else
            UserAccess = True
        End If
    End Function
End Class



Public Class clsConfig
    'Public Const ReportPath = "\\srv-gemmaknits\ESCHLER_REPORTS\" 'Sitthana 20220615 '"D:\setup\Reports" 
    'Public Const ImagePath = "\\ESCH-SVR-APP\MEDIA\PHOTO\MACHINE\" 'Add By Neung 

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

	Public Function IsValidDouble(ByVal Isdouble As Object) As Object
		If IsNothing(Isdouble) Then
			Return Convert.ToDouble(0)
		ElseIf IsDBNull(Isdouble) Or Isdouble = "" Then
			Return Convert.ToDouble(0)
		Else
			Return Isdouble
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

    Public Function IsEmpty(ByVal str1 As String, ByVal str2 As String) As String
        If IsNull(str1, "") = "" Or str1.Length = 0 Then
            IsEmpty = str2
        Else
            IsEmpty = str1
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
                Case VariantType.Date
                    If obj1 = CDate("01/01/1900") Then IsNull = obj2
                Case VariantType.Object
                    If TypeOf obj1 Is DataRowView Then IsNull = obj2
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

    Public Sub ChangePassword(ByVal strUsername As String, ByVal strPassword As String)
        Dim conn As New SqlConnection((New classConnection).connection)
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "p_change_password"
        comm.Parameters.AddWithValue("@empname", strUsername.Trim)
        comm.Parameters.AddWithValue("@password", strPassword.Trim)
        conn.Open()
        comm.ExecuteNonQuery()
        conn.Close()  'Sitthana 20190325
    End Sub

    Public Sub UpdatePassword(ByVal strUsername As String, ByVal strPassword As String)
        'Create By Sitthana
        Dim conn As New SqlConnection((New classConnection).connection)
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "p_login_pkg_update_password   " '"p_change_password"  'Sitthana 18/01/2018
        comm.Parameters.AddWithValue("@empname", strUsername.Trim)
        comm.Parameters.AddWithValue("@password", strPassword.Trim)
        conn.Open()
        comm.ExecuteNonQuery()
        conn.Close()  'Sitthana 20190325
    End Sub

    Public Sub FadeIn(ByVal TargetForm As Form, ByVal FadeStep As Double)
        Dim _i As Double = 0.0
        Dim _MaxOpacity As Integer = 1

        If TargetForm.Visible = False Then
            TargetForm.Opacity = 0
            TargetForm.Visible = True
        End If

        For _i = 0 To _MaxOpacity Step FadeStep
            TargetForm.Opacity = _i
            TargetForm.Refresh()
        Next
    End Sub

    Public Sub FadeOut(ByVal TargetForm As Form, ByVal FadeStep As Double)
        Dim _i As Double = 0.0
        Dim _MinOpacity As Integer = 0

        If TargetForm.Visible = False Then
            Return
        End If

        For _i = 1 To _MinOpacity Step -FadeStep
            TargetForm.Opacity = _i
            TargetForm.Refresh()
        Next
    End Sub

    Public Function GetImagePath() As String
        Dim conn As New SqlConnection((New classConnection).connection)
        Dim da As New SqlDataAdapter("select * from company", conn)
        Dim dt As New DataTable
        da.Fill(dt)
        conn.Close()  'Sitthana 20190325
        GetImagePath = dt.Rows(0)("image_path").ToString.Trim.ToUpper
    End Function

    Public Function UserAccess(ByVal UserId As String, ByVal MenuId As String, Optional ByVal AccessType As String = "MENU") As Boolean
        Dim conn As New SqlConnection((New classConnection).connection)
        Dim comm As New SqlCommand("", conn)
        Dim sql As String
        sql = "select dbo.fn_UserAccess('" + UserId + "','" + MenuId + "','" + AccessType + "')"

        comm.CommandType = CommandType.Text
        comm.CommandText = sql
        
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        conn.Close()  'Sitthana 20190325
        If Not dt Is Nothing Then
            If dt.Rows(0).Item(0) = True Then
                UserAccess = True
            Else
                UserAccess = False
            End If
        End If
    End Function

    Public Function ChangeDate(ByVal strDate As String) As String
        If IsDate(strDate) Then
            Return CDate(strDate).ToString("yyyyMMdd")
        Else
            Return CDate("01/01/1900").ToString("yyyyMMdd")
        End If
    End Function

    Public Function ChangeDate(ByVal oldDate As Date) As String
        Return oldDate.ToString("dd/MM/yyyy")
    End Function
    Public Function getUserRoleRight(ByVal p_EmpCd As String, p_RoleID As String) As DataTable
        'Sitthana 08/08/2018
        Dim conn As New SqlConnection((New classConnection).connection)
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "p_userrole_select"
        comm.Parameters.Clear()
        comm.Parameters.AddWithValue("@p_RoleID", p_RoleID)
        comm.Parameters.AddWithValue("@p_EmpCd", p_EmpCd)
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        conn.Close()  'Sitthana 20190325
        Return dt
    End Function
End Class
