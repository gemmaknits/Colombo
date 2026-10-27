Imports System
Imports System.Text
Imports System.Data.SqlClient
Imports System.Net

Public Class frmLogin
    Dim clsUser As New classUserInfo
    Dim clsConfig As New clsConfig

    Public Property UserInfo() As classUserInfo
        Get
            UserInfo = clsUser
        End Get
        Set(ByVal NewValue As classUserInfo)
            clsUser = NewValue
        End Set
    End Property


    Private Sub frmLogin_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'On Error Resume Next
        Me.CenterToScreen()
        enableGrpChangePassword(False)

        With Screen.PrimaryScreen.WorkingArea
            Me.SetBounds((.Width - Me.Width) / 2 _
              , (.Height - Me.Height) / 2 _
              , Me.Width _
              , Me.Height)
        End With

        'Dim wmi As New System.Management.ManagementClass("\\localhost\root\cimv2:Win32_Process")
        'Dim obj As New System.Management.ManagementObject
        'Dim name As String = ""
        'Dim i As Integer = 0
        'For Each obj In wmi.GetInstances()
        '	If obj.GetPropertyValue("name").ToString = "SalesOrderSystem.exe" Then i += 1
        'Next
        'If i = 2 Then
        '	MessageBox.Show("SalesOrderSystem is already open. See the tray icon in the right bottom of your screen and click it." & vbCrLf & "โปรแกรม SalesOrderSystem เปิดอยู่แล้ว กรุณาดูที่ Tray Icon ด้านขวาล่าง", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        '	Me.Close()
        'End If
    End Sub

    Private Sub btnLogin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLogin.Click
        checkUser()
        'Dim exrt As New ExchangeRateConversion.CurrencyConvertor
        'MessageBox.Show(exrt.ConversionRate(ExchangeRateConversion.Currency.USD, ExchangeRateConversion.Currency.THB))
        'Dim exrt As New ExchangeRate.DOTSCurrencyExchange
        'MessageBox.Show(exrt.ConvertCurrency(100, "USD", "USD", "FREE TRIAL").ConvertedAmount, "System Message")
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub txtPassword_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtPassword.KeyPress
        If e.KeyChar = Chr(13) Then
            checkUser()
        End If
    End Sub

    Private Function CheckIP(ByVal ipAddress As String) As Boolean
        Dim hostname As String = ""
        Try
            Dim host As IPHostEntry = Dns.GetHostEntry(ipAddress)
            hostname = host.HostName
            'hostname = Dns.GetHostEntry(ipAddress).HostName
            Return True
        Catch ex As Exception
            'MessageBox.Show(ex.Message, "System Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function

    Private Function chgPasswordCaseExpire(pwd_expire_days As Integer, pwd_reset_date As Date)
        'Create By Sitthana 18/01/2018
        'CurrentDate in not real date -> today 
        Dim CanLogin As Boolean = False
        Dim RechangePassword As Boolean = False

        If pwd_expire_days = 0 Then
            RechangePassword = False
        ElseIf Today >= pwd_reset_date Then
            RechangePassword = True
        End If

        If RechangePassword Then
            MessageBox.Show("Your Password is Expired (รหัสผ่านหมดอายุการใช้งาน)" & vbCr _
                             & Space(9) & "You much change it before use program " & vbCr _
                             & Space(9) & "(ให้คุณเปลี่ยนรหัสผ่านก่อน ถึงจะเริ่มใช้งานโปรแกรมได้)" _
                             , "Password Expire", MessageBoxButtons.OK)
        Else
            CanLogin = True
        End If

        Return CanLogin
    End Function

    Private Function checkCanLogin()
        Dim canLogin As Boolean = False

        Dim classConn As New classConnection
        Dim cn As New SqlConnection
        Dim comm As New SqlCommand("", cn)
        Dim ds As New DataSet

        cn.ConnectionString = classConn.connection

        clsUser.IPAddress = Net.Dns.GetHostAddresses(My.Computer.Name)(0).ToString

        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "p_login_pkg_verify_user_password"  'p_verify_user_password"  Sitthana 18/01/2018
        comm.Parameters.AddWithValue("@username", Me.txtUserName.Text.Trim)
        comm.Parameters.AddWithValue("@password", Me.txtPassword.Text.Trim)
        comm.Parameters.AddWithValue("@ip_address", clsUser.IPAddress)

        Dim da As New SqlDataAdapter(comm)

        Try
            da.Fill(ds, "tableEmp")
        Catch ex As Exception
            Console.WriteLine(ex)
        End Try

        If ds.Tables("tableEmp").Rows.Count = 0 Then
            MsgBox("Incorrect username or password, please verify.." & vbCr _
                  & "(ชื่อผู้ใช้ หรือ รหัสผ่าน  ไม่ถูกต้อง, ให้ตรวจสอบอีกครั้งหนึ่ง)" _
                   , MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Access denied")
        Else
            canLogin = True
        End If

        Return canLogin
    End Function

    Private Sub checkUser()
        Dim classConn As New classConnection

        'If Not CheckIP(classConn.servername) Then
        '    classConn.servername = "61.19.83.61"
        '    clsConfig.ReportPath = "\\192.168.16.247\Projects\Reports"
        '    If Not CheckIP(classConn.servername) Then
        '        classConn.servername = "172.16.3.4"
        '        clsConfig.ReportPath = "P:\Reports\"
        '        'MessageBox.Show("Cannot verify server.", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
        '        'Exit Sub 
        '    End If
        'End If

        Dim clsMaster As New classMaster
        Dim cn As New SqlConnection
        Dim comm As New SqlCommand("", cn)
        Dim ds As New DataSet
        'Dim strSql As New StringBuilder
        Dim curr_date As String = ""

        cn.ConnectionString = classConn.connection
        'strSql.Append("select emp.*,")
        'strSql.Append("convert(varchar(8),case when convert(varchar(2),getdate(),108) < '09' then dateadd(day,-1,getdate()) else getdate() end,112) as curr_date,")
        'strSql.Append("convert(varchar(2),getdate(),108) as curr_time,")
        'strSql.Append("isnull((select top 1 exchange_rate from exchange_rate where curr = 'USD' and curr_date = convert(varchar(8),case when convert(varchar(2),getdate(),108) < '09' then dateadd(day,-1,getdate()) else getdate() end,112)),0) as exchange_rate from emp where empname='")
        'strSql.Append(Me.TextBox1.Text.ToString.Trim)
        'strSql.Append("'")
        'strSql.Append(" and password='")
        'strSql.Append(Me.TextBox2.Text.Trim)
        'strSql.Append("'")
        'da.SelectCommand.CommandText = strSql.ToString

        clsUser.IPAddress = Net.Dns.GetHostAddresses(My.Computer.Name)(0).ToString

        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "p_login_pkg_verify_user_password"  'p_verify_user_password"  Sitthana 18/01/2018
        comm.Parameters.AddWithValue("@username", Me.txtUserName.Text.Trim)
        comm.Parameters.AddWithValue("@password", Me.txtPassword.Text.Trim)
        comm.Parameters.AddWithValue("@ip_address", clsUser.IPAddress)

        Dim da As New SqlDataAdapter(comm)

        Try
            da.Fill(ds, "tableEmp")
        Catch ex As Exception
            Console.WriteLine(ex)
            Exit Sub
        End Try

        If ds.Tables("tableEmp").Rows.Count = 0 Then
            MsgBox("Incorrect username or password, please verify.." & vbCr _
                   & "(ชื่อผู้ใช้ หรือ รหัสผ่าน  ไม่ถูกต้อง, ให้ตรวจสอบอีกครั้งหนึ่ง)" _
                   , MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Access denied")
            txtPassword.Text = ""
            txtPassword.Focus()
            Exit Sub
        Else
            '*** Begin - Sitthana 18/01/2018
            If chgPasswordCaseExpire(ds.Tables("tableEmp").Rows(0)("pwd_expire_days") _
                                     , clsConfig.IsNull(ds.Tables("tableEmp").Rows(0)("pwd_reset_date"), clsUser.CurrentDate)
                                     ) = False Then
                chbChangePassword.Checked = True
                txtPassword.ReadOnly = True
                txtPassword.BackColor = Color.PeachPuff
                txtPasswordNew.Focus()
                Exit Sub
            End If
            '*** End - Sitthana 18/01/2018

            clsUser.UserID = ds.Tables("tableEmp").Rows(0)("empcd").ToString.Trim.ToUpper
            clsUser.UserName = ds.Tables("tableEmp").Rows(0)("empname").ToString.Trim.ToUpper
            clsUser.Password = ds.Tables("tableEmp").Rows(0)("password").ToString.Trim
            clsUser.DeptCD = ds.Tables("tableEmp").Rows(0)("deptcd").ToString.Trim.ToUpper
            If classConn.servername.Equals("61.19.83.61") Then
                clsUser.ReportPath = "\\192.168.16.247\Projects\Reports"
            Else
                clsUser.ReportPath = ds.Tables("tableEmp").Rows(0)("report_path").ToString.Trim.ToUpper
            End If
            clsUser.ImagePath = ds.Tables("tableEmp").Rows(0)("image_path").ToString.Trim.ToUpper
            clsUser.CurrentDate = ds.Tables("tableEmp").Rows(0)("curr_date").ToString.Trim
            clsUser.LogID = ds.Tables("tableEmp").Rows(0)("log_id")
            clsUser.CanChat = CBool(ds.Tables("tableEmp").Rows(0)("can_chat"))
            If clsConfig.IsNull(ds.Tables("tableEmp").Rows(0)("exchange_rate"), 0) = 0 Then
                MessageBox.Show("You are the lucky one, Please take a seat and rest while program automatically receive data from Bank Of Thailand." &
                vbCrLf & "คุณคือผู้โชคดี.. กรุณานั่งพักแล้วรอสักครู่โปรแกรมกำลังทำการดึงข้อมูลจากธนาคารแห่งประเทศไทย" _
                , "System Message", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
                clsUser.ExchangeRate = clsMaster.GetUSExchnageRate
                If ds.Tables("tableEmp").Rows(0)("curr_time").ToString.Trim >= "09" Then 'Bank Of Thailand Update Data After 9 O'Clock Everyday
                    comm = New SqlCommand("", cn)
                    comm.CommandType = CommandType.StoredProcedure
                    comm.CommandText = "p_exchange_rate_insert"
                    comm.Parameters.AddWithValue("@curr_fr", "USD")
                    comm.Parameters.AddWithValue("@curr_to", "THB")
                    comm.Parameters.AddWithValue("@curr_date", Now.ToString("yyyyMMdd"))
                    comm.Parameters.AddWithValue("@exchange_rate", clsUser.ExchangeRate)
                    da = New SqlDataAdapter(comm)
                    da.Fill(ds, "exchange_rate")
                End If
            Else
                clsUser.ExchangeRate = clsConfig.IsNull(ds.Tables("tableEmp").Rows(0)("exchange_rate"), 0)
            End If

            If clsUser.ExchangeRate = 0 Then MessageBox.Show("Please Contect Programmer About Exchange Rate Didn't Show ", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1) 'Add By Neung 2015/10/28


        End If
        Dim formMain As New frmMainmenu
        formMain.UserInfo = clsUser
        'formMain.UserInfoNew = classUserNew
        formMain.loginEmpcd = ds.Tables("tableEmp").Rows(0).Item("empcd")

        formMain.Show()
        Me.Close()
    End Sub

    Private Function GetReportPath() As String
        Dim conn As New SqlConnection((New classConnection).connection)
        Dim da As New SqlDataAdapter("select * from company", conn)
        Dim dt As New DataTable
        da.Fill(dt)
        GetReportPath = dt.Rows(0)("report_path").ToString.Trim.ToUpper
    End Function

    Private Sub btnChangePassword_Click(sender As Object, e As EventArgs) Handles btnChangePassword.Click
        Dim ErrorMsg As String = ""
        Dim ErrorFlag As Boolean = False
        Dim i As Byte = 0

        If txtUserName.Text.Trim = "" Then
            i += 1
            ErrorMsg = i & ". User Name don't empty (ชื่อผู้ใช้ ห้ามปล่อยว่าง)"
            ErrorFlag = True
        End If
        If txtPassword.Text.Trim = "" Then
            i += 1
            If ErrorMsg <> "" Then ErrorMsg &= vbCr
            ErrorMsg &= i & ". Password don't empty (รหัสผ่าน ของผู้ใช้ ห้ามปล่อยว่าง)"
            ErrorFlag = True
        End If
        If txtPasswordNew.Text.Trim = "" Then
            i += 1
            If ErrorMsg <> "" Then ErrorMsg &= vbCr
            ErrorMsg &= i & ". New password don't empty (รหัสผ่านใหม่ ของผู้ใช้ ห้ามปล่อยว่าง)"
            ErrorFlag = True
        End If
        If txtPasswordConfirm.Text.Trim = "" Then
            i += 1
            If ErrorMsg <> "" Then ErrorMsg &= vbCr
            ErrorMsg &= i & ". Confirm Password don't empty (ยืนยันรหัสผ่านใหม่ ของผู้ใช้ ห้ามปล่อยว่าง)"
            ErrorFlag = True
        End If
        If txtPassword.Text.Trim = txtPasswordNew.Text.Trim Then
            i += 1
            If ErrorMsg <> "" Then ErrorMsg &= vbCr
            ErrorMsg &= i & ". New password must different old password (รหัสผ่านใหม่ของผู้ใช้ ต้องแตกต่างจากรหัสผ่านเดิม)"
            ErrorFlag = True
        End If

        If ErrorFlag = True Then
            MessageBox.Show(ErrorMsg, "Stop", MessageBoxButtons.OK)
        ElseIf txtPasswordNew.Text.Trim <> txtPasswordConfirm.Text.Trim Then
            MessageBox.Show("Passwords are not the same, Re-enter" _
                            & "(รหัสผ่านใหม่ กับ ยืนยันรหัสผ่าน ไม่ตรงกัน, ให้คุณป้อนใหม่อีกครั้งหนึ่ง" _
                            , "Stop", MessageBoxButtons.OK)
        Else
            'clsConfig.ChangePassword(clsUser.UserName, txtPasswordNew.Text)
            If checkCanLogin() Then
                clsConfig.UpdatePassword(txtUserName.Text.Trim, txtPasswordNew.Text.Trim)
                MessageBox.Show("Changed Password Complete" & vbCr _
                            & "(เปลี่ยนรหัสผ่านสำเร็จแล้วครับ  ต่อไปให้คุณใช้รหัสผ่านนี้ ในการเข้าใช้งานโปรแกรม)" _
                                , "Result", MessageBoxButtons.OK)
                txtPassword.Text = txtPasswordNew.Text.Trim
                btnLogin_Click(Nothing, Nothing)

                'txtPassword.Text = ""
                'txtPassword.ReadOnly = False
                'txtPassword.BackColor = Color.White
                'txtPasswordNew.Text = ""
                'txtPasswordConfirm.Text = ""
                'chbChangePassword.Checked = False
                'txtPassword.Focus()
            End If
        End If
    End Sub
    Private Sub updPassword()

    End Sub

    Private Sub enableGrpChangePassword(enableFlag As Boolean)
        txtPasswordNew.Enabled = enableFlag
        txtPasswordConfirm.Enabled = enableFlag
        btnChangePassword.Enabled = enableFlag
        If enableFlag = True Then
            txtPasswordNew.BackColor = Color.White
            txtPasswordConfirm.BackColor = Color.White
        Else
            txtPasswordNew.BackColor = Color.PeachPuff
            txtPasswordConfirm.BackColor = Color.PeachPuff
        End If
    End Sub
    Private Sub chbChangePassword_CheckedChanged(sender As Object, e As EventArgs) Handles chbChangePassword.CheckedChanged
        If chbChangePassword.Checked = True Then
            enableGrpChangePassword(True)
        Else
            enableGrpChangePassword(False)
        End If
    End Sub

    Private Sub txtUserName_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtUserName.KeyPress
        If e.KeyChar = vbCr Then
            txtPassword.Focus()
        End If
    End Sub

    Private Sub txtPasswordNew_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPasswordNew.KeyPress
        If e.KeyChar = vbCr Then
            If txtPassword.Text.Trim = txtPasswordNew.Text.Trim Then
                MessageBox.Show("New password must different old password" & vbCr _
                                & "(รหัสผ่านใหม่ ต้องแตกต่างจากรหัสผ่านเดิม)" _
                , "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Else
                txtPasswordConfirm.Focus()
            End If
        End If
    End Sub

    Private Sub txtPasswordConfirm_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPasswordConfirm.KeyPress
        If e.KeyChar = vbCr Then
            If txtPassword.Text.Trim = txtPasswordConfirm.Text.Trim Then
                MessageBox.Show("New password must different old password" & vbCr _
                                & "(รหัสผ่านใหม่ ต้องแตกต่างจากรหัสผ่านเดิม)" _
                                , "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Else
                btnChangePassword_Click(Nothing, Nothing)
            End If
        End If
    End Sub
End Class