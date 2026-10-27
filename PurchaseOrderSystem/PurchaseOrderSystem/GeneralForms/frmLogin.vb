Imports System
Imports System.Text
Imports System.Data.SqlClient
Imports System.Net

Public Class frmLogin
    Dim oLogin As New classlogin
    Dim clsUser As New classUserInfo
    Private clsMaster As New classMaster
    'Dim classUserNew As New Classes.classUserInfo ' Sitthana 17/02/2018
    Dim oConfig As New clsConfig

    Dim pwd_expire_days As Integer, pwd_reset_date As Date   ' Sitthana 17/02/2018

    Public Property UserInfo() As classUserInfo
        Get
            UserInfo = clsUser
        End Get
        Set(ByVal NewValue As classUserInfo)
            clsUser = NewValue
        End Set
    End Property
    Private Sub setComboWarehouse()
        cboWarehouse.DataSource = clsMaster.Combomtlwarehouse("")
        cboWarehouse.DisplayMember = "warehouse_code"
        cboWarehouse.ValueMember = "mtl_warehouse_id"
        cboWarehouse.SelectedValue = clsMaster.GetdefaultWarehouseID(clsUser.UserID)

    End Sub

    Private Sub frmLogin_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'On Error Resume Next
        Me.CenterToScreen()
        grbChangePassword.Visible = False
        enableGrpChangePassword(False)
        'Me.Height = 170
        setComboDatabase()
        'Neung 20/02/2025 for Check Connention
        Dim mssger As String = ""
        If Not oLogin.CheckConnection(mssger) Then
            MessageBox.Show("ไม่สามารถเชื่อมต่อกับ Server ได้ โปรดลองใหม่อีกครั้ง ", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.Close()
            Exit Sub
        End If
        setComboWarehouse()
        'With Screen.PrimaryScreen.WorkingArea
        '    Me.SetBounds((.Width - Me.Width) / 2,
        '       (.Height - Me.Height) / 2,
        '       Me.Width,
        '       Me.Height)
        'End With

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

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnLogin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLogin.Click
        If checkCanLoginAndKeepGlbValue() = False Then
            MsgBox("Incorrect username or password, please verify.." & vbCr _
                   & "(ชื่อผู้ใช้ หรือ รหัสผ่าน  ไม่ถูกต้อง, ให้ตรวจสอบอีกครั้งหนึ่ง)" _
                   , MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Access denied")
            txtPassword.Text = ""
            txtPassword.Focus()
            Exit Sub
        ElseIf chgPasswordExpired() Then
            chbChangePassword.Checked = True
        Else
            LoginToSystem()
        End If

        'Old Comment By Sitthana 17/02/2018
        'checkUser()
        ''Dim exrt As New ExchangeRateConversion.CurrencyConvertor
        ''MessageBox.Show(exrt.ConversionRate(ExchangeRateConversion.Currency.USD, ExchangeRateConversion.Currency.THB))
        ''Dim exrt As New ExchangeRate.DOTSCurrencyExchange
        ''MessageBox.Show(exrt.ConvertCurrency(100, "USD", "USD", "FREE TRIAL").ConvertedAmount, "System Message")
    End Sub

    Private Sub LoginToSystem()
        Dim formMain As New frmMainmenu
        formMain.pShortName = oConfig.IsNull(cboDatabase.SelectedValue, "")
        formMain.UserInfo = clsUser
        formMain.loginEmpcd = clsUser.UserID
        formMain.Show()
        Me.Close()
    End Sub

    Private Function checkCanLoginAndKeepGlbValue()
        Dim canLogin As Boolean = False

        Dim classConn As New classConnection
        Dim cn As New SqlConnection
        Dim comm As New SqlCommand("", cn)
        Dim ds As New DataSet

        cn.ConnectionString = classConn.connection

        clsUser.IPAddress = Net.Dns.GetHostAddresses(My.Computer.Name)(0).ToString

        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "p_login_pkg_verify_user_password"  'p_verify_user_password"  Sitthana 18/01/2018
        comm.Parameters.Clear()
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
            canLogin = False
        Else
            Dim clsMaster As New classMaster

            clsUser.UserID = ds.Tables("tableEmp").Rows(0)("empcd").ToString.Trim.ToUpper
            clsUser.UserName = ds.Tables("tableEmp").Rows(0)("empname").ToString.Trim.ToUpper
            clsUser.Password = ds.Tables("tableEmp").Rows(0)("password").ToString.Trim
            clsUser.DeptCD = ds.Tables("tableEmp").Rows(0)("deptcd").ToString.Trim.ToUpper

            'If classConn.servername.Equals("61.19.83.61") Then
            '    clsUser.ReportPath = "\\192.168.16.247\Projects\Reports"
            'Else
            '    clsUser.ReportPath = ds.Tables("tableEmp").Rows(0)("report_path").ToString.Trim.ToUpper
            'End If 'Comment By Sitthana 20220615  (Temporary)

            clsUser.ReportPath = ds.Tables("tableEmp").Rows(0)("report_path").ToString ' "\\srv-gemmaknits\ESCHLER_REPORTS\" 'Sitthana 20220615  Temp.

            clsUser.ImagePath = ds.Tables("tableEmp").Rows(0)("image_path").ToString.Trim.ToUpper
            clsUser.CurrentDate = ds.Tables("tableEmp").Rows(0)("curr_date").ToString.Trim
            clsUser.LogID = ds.Tables("tableEmp").Rows(0)("log_id")
            clsUser.CanChat = CBool(ds.Tables("tableEmp").Rows(0)("can_chat"))

            pwd_expire_days = ds.Tables("tableEmp").Rows(0)("pwd_expire_days") ' Sitthana 17/02/2018
            pwd_reset_date = oConfig.IsNull(ds.Tables("tableEmp").Rows(0)("pwd_reset_date"), clsUser.CurrentDate) ' Sitthana 17/02/2018

            '============================================ Get Exchange Rate USD JPY AND OTHER====================================
            clsUser.ExchangeRate = (New clsConfig).IsNull(ds.Tables("tableEmp").Rows(0)("exchange_rate"), 0)
            clsUser.ExchangeRateUSD = (New clsConfig).IsNull(ds.Tables("tableEmp").Rows(0)("exchange_rate_usd"), 0)
            clsUser.ExchangeRateJPY = (New clsConfig).IsNull(ds.Tables("tableEmp").Rows(0)("exchange_rate_jpy"), 0)
            clsUser.ExchangeRateAUD = (New clsConfig).IsNull(ds.Tables("tableEmp").Rows(0)("exchange_rate_aud"), 0)
            clsUser.ExchangeRateCHF = (New clsConfig).IsNull(ds.Tables("tableEmp").Rows(0)("exchange_rate_chf"), 0)
            clsUser.ExchangeRateEUR = (New clsConfig).IsNull(ds.Tables("tableEmp").Rows(0)("exchange_rate_eur"), 0)
            clsUser.ExchangeRateHKD = (New clsConfig).IsNull(ds.Tables("tableEmp").Rows(0)("exchange_rate_hkd"), 0)
            clsUser.ExchangeRateRMB = (New clsConfig).IsNull(ds.Tables("tableEmp").Rows(0)("exchange_rate_rmb"), 0) 'BOT use CNY
            clsUser.ExchangeRateCNY = (New clsConfig).IsNull(ds.Tables("tableEmp").Rows(0)("exchange_rate_cny"), 0)
            '============================================ Get Exchange Rate API (Update After 18:00 /Data Entry 20200221) =======================================
            If oConfig.IsNull(clsUser.ExchangeRateUSD, 0) = 0 Then
                clsUser.ExchangeRate = clsMaster.GetExchangeRateAPIByDate("USD", Now, Now)
                clsUser.ExchangeRateUSD = clsMaster.GetExchangeRateAPIByDate("USD", Now, Now)
                Call (New classMasterUpdate).InsertExchangeRate("USD", "THB", clsUser.ExchangeRateUSD)
            End If
            If oConfig.IsNull(clsUser.ExchangeRateJPY, 0) = 0 Then
                clsUser.ExchangeRateJPY = clsMaster.GetExchangeRateAPIByDate("JPY", Now, Now)
                Call (New classMasterUpdate).InsertExchangeRate("JPY", "THB", clsUser.ExchangeRateJPY)
            End If
            If oConfig.IsNull(clsUser.ExchangeRateAUD, 0) = 0 Then
                clsUser.ExchangeRateAUD = clsMaster.GetExchangeRateAPIByDate("AUD", Now, Now)
                Call (New classMasterUpdate).InsertExchangeRate("AUD", "THB", clsUser.ExchangeRateAUD)
            End If
            If oConfig.IsNull(clsUser.ExchangeRateCHF, 0) = 0 Then
                clsUser.ExchangeRateCHF = clsMaster.GetExchangeRateAPIByDate("CHF", Now, Now)
                Call (New classMasterUpdate).InsertExchangeRate("CHF", "THB", clsUser.ExchangeRateCHF)
            End If
            If oConfig.IsNull(clsUser.ExchangeRateEUR, 0) = 0 Then
                clsUser.ExchangeRateEUR = clsMaster.GetExchangeRateAPIByDate("EUR", Now, Now)
                Call (New classMasterUpdate).InsertExchangeRate("EUR", "THB", clsUser.ExchangeRateEUR)
            End If
            If oConfig.IsNull(clsUser.ExchangeRateHKD, 0) = 0 Then
                clsUser.ExchangeRateHKD = clsMaster.GetExchangeRateAPIByDate("HKD", Now, Now)
                Call (New classMasterUpdate).InsertExchangeRate("HKD", "THB", clsUser.ExchangeRateHKD)
            End If
            If oConfig.IsNull(clsUser.ExchangeRateRMB, 0) = 0 Then
                clsUser.ExchangeRateRMB = clsMaster.GetExchangeRateAPIByDate("CNY", Now, Now)
                Call (New classMasterUpdate).InsertExchangeRate("RMB", "THB", clsUser.ExchangeRateRMB)
            End If
            If oConfig.IsNull(clsUser.ExchangeRateCNY, 0) = 0 Then
                clsUser.ExchangeRateCNY = clsMaster.GetExchangeRateAPIByDate("CNY", Now, Now)
                Call (New classMasterUpdate).InsertExchangeRate("CNY", "THB", clsUser.ExchangeRateCNY)
            End If
            clsUser.MtlWareHouseID = (New clsConfig).IsNull(cboWarehouse.SelectedValue, Nothing)

            canLogin = True
        End If

        Return canLogin
    End Function

    Private Function chgPasswordExpired()
        'Create By Sitthana 18/01/2018
        'CurrentDate in not real date -> today 
        Dim PasswordExpired As Boolean = False

        If pwd_expire_days = 0 Then      ' If user had pwd_expire_days = 0 -> No need change password
            PasswordExpired = False
        ElseIf Today >= pwd_reset_date Then
            MessageBox.Show("Your Password is Expired (รหัสผ่านหมดอายุการใช้งาน)" & vbCr _
                             & Space(9) & "You much change it before use program " & vbCr _
                             & Space(9) & "(ให้คุณเปลี่ยนรหัสผ่านก่อน ถึงจะเริ่มใช้งานโปรแกรมได้)" _
                             , "Password Expire", MessageBoxButtons.OK)
            grbChangePassword.Visible = True
            PasswordExpired = True
        Else
            PasswordExpired = False
        End If

        Return PasswordExpired
    End Function

    Private Sub txtPassword_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtPassword.KeyPress
        If e.KeyChar = Chr(13) Then
            ''checkUser()
            btnLogin_Click(Nothing, Nothing)
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


    'Private Sub checkUser()
    '    Comment By Sitthana 17/02/2018
    '    Dim classConn As New classConnection

    '    'If Not CheckIP(classConn.servername) Then
    '    '    classConn.servername = "61.19.83.61"
    '    '    clsConfig.ReportPath = "\\192.168.16.247\Projects\Reports"
    '    '    If Not CheckIP(classConn.servername) Then
    '    '        classConn.servername = "172.16.3.4"
    '    '        clsConfig.ReportPath = "P:\Reports\"
    '    '        'MessageBox.Show("Cannot verify server.", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '    '        'Exit Sub 
    '    '    End If
    '    'End If

    '    Dim clsMaster As New classMaster
    '    Dim cn As New SqlConnection
    '    Dim comm As New SqlCommand("", cn)
    '    Dim ds As New DataSet
    '    'Dim strSql As New StringBuilder
    '    Dim curr_date As String = ""

    '    cn.ConnectionString = classConn.connection
    '    'strSql.Append("select emp.*,")
    '    'strSql.Append("convert(varchar(8),case when convert(varchar(2),getdate(),108) < '09' then dateadd(day,-1,getdate()) else getdate() end,112) as curr_date,")
    '    'strSql.Append("convert(varchar(2),getdate(),108) as curr_time,")
    '    'strSql.Append("isnull((select top 1 exchange_rate from exchange_rate where curr = 'USD' and curr_date = convert(varchar(8),case when convert(varchar(2),getdate(),108) < '09' then dateadd(day,-1,getdate()) else getdate() end,112)),0) as exchange_rate from emp where empname='")
    '    'strSql.Append(Me.TextBox1.Text.ToString.Trim)
    '    'strSql.Append("'")
    '    'strSql.Append(" and password='")
    '    'strSql.Append(Me.TextBox2.Text.Trim)
    '    'strSql.Append("'")
    '    'da.SelectCommand.CommandText = strSql.ToString

    '    clsUser.IPAddress = Net.Dns.GetHostAddresses(My.Computer.Name)(0).ToString

    '    comm.CommandType = CommandType.StoredProcedure
    '    comm.CommandText = "p_login_pkg_verify_user_password"  'p_verify_user_password"  Sitthana 18/01/2018
    '    comm.Parameters.AddWithValue("@username", Me.txtUserName.Text.Trim)
    '    comm.Parameters.AddWithValue("@password", Me.txtPassword.Text.Trim)
    '    comm.Parameters.AddWithValue("@ip_address", clsUser.IPAddress)

    '    Dim da As New SqlDataAdapter(comm)

    '    Try
    '        da.Fill(ds, "tableEmp")
    '    Catch ex As Exception
    '        Console.WriteLine(ex)
    '        Exit Sub
    '    End Try

    '    If ds.Tables("tableEmp").Rows.Count = 0 Then
    '        MsgBox("Incorrect username or password, please verify.." & vbCr _
    '               & "(ชื่อผู้ใช้ หรือ รหัสผ่าน  ไม่ถูกต้อง, ให้ตรวจสอบอีกครั้งหนึ่ง)" _
    '               , MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Access denied")
    '        txtPassword.Text = ""
    '        txtPassword.Focus()
    '        Exit Sub
    '    Else
    '        '*** Begin - Sitthana 18/01/2018
    '        If chgPasswordExpired() = False Then
    '            chbChangePassword.Checked = True
    '            Exit Sub
    '        End If
    '        '*** End - Sitthana 18/01/2018

    '        clsUser.UserID = ds.Tables("tableEmp").Rows(0)("empcd").ToString.Trim.ToUpper
    '        clsUser.UserName = ds.Tables("tableEmp").Rows(0)("empname").ToString.Trim.ToUpper
    '        clsUser.Password = ds.Tables("tableEmp").Rows(0)("password").ToString.Trim
    '        clsUser.DeptCD = ds.Tables("tableEmp").Rows(0)("deptcd").ToString.Trim.ToUpper
    '        If classConn.servername.Equals("61.19.83.61") Then
    '            clsUser.ReportPath = "\\192.168.16.247\Projects\Reports"
    '        Else
    '            clsUser.ReportPath = ds.Tables("tableEmp").Rows(0)("report_path").ToString.Trim.ToUpper
    '        End If
    '        clsUser.ImagePath = ds.Tables("tableEmp").Rows(0)("image_path").ToString.Trim.ToUpper
    '        clsUser.CurrentDate = ds.Tables("tableEmp").Rows(0)("curr_date").ToString.Trim
    '        clsUser.LogID = ds.Tables("tableEmp").Rows(0)("log_id")
    '        clsUser.CanChat = CBool(ds.Tables("tableEmp").Rows(0)("can_chat"))
    '        If clsConfig.IsNull(ds.Tables("tableEmp").Rows(0)("exchange_rate"), 0) = 0 Then
    '            'Sitthana 08/02/2018 Comment Message 
    '            'MessageBox.Show("You are the lucky one, Please take a seat and rest while program automatically receive data from Bank Of Thailand." &
    '            'vbCrLf & "คุณคือผู้โชคดี.. กรุณานั่งพักแล้วรอสักครู่โปรแกรมกำลังทำการดึงข้อมูลจากธนาคารแห่งประเทศไทย" _
    '            ', "System Message", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
    '            clsUser.ExchangeRate = clsMaster.GetUSExchnageRate
    '            If ds.Tables("tableEmp").Rows(0)("curr_time").ToString.Trim >= "09" Then 'Bank Of Thailand Update Data After 9 O'Clock Everyday
    '                comm = New SqlCommand("", cn)
    '                comm.CommandType = CommandType.StoredProcedure
    '                comm.CommandText = "p_exchange_rate_insert"
    '                comm.Parameters.AddWithValue("@curr_fr", "USD")
    '                comm.Parameters.AddWithValue("@curr_to", "THB")
    '                comm.Parameters.AddWithValue("@curr_date", Now.ToString("yyyyMMdd"))
    '                comm.Parameters.AddWithValue("@exchange_rate", clsUser.ExchangeRate)
    '                da = New SqlDataAdapter(comm)
    '                da.Fill(ds, "exchange_rate")
    '            End If
    '        Else
    '            clsUser.ExchangeRate = clsConfig.IsNull(ds.Tables("tableEmp").Rows(0)("exchange_rate"), 0)
    '        End If

    '        If clsUser.ExchangeRate = 0 Then MessageBox.Show("Please Contect Programmer About Exchange Rate Didn't Show ", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1) 'Add By Neung 2015/10/28


    '    End If
    '    Dim formMain As New frmMainmenu
    '    formMain.UserInfo = clsUser
    '    'formMain.UserInfoNew = classUserNew
    '    formMain.loginEmpcd = ds.Tables("tableEmp").Rows(0).Item("empcd")

    '    formMain.Show()
    '    Me.Close()
    'End Sub

    Private Sub chbChangePassword_CheckedChanged(sender As Object, e As EventArgs) Handles chbChangePassword.CheckedChanged
        If chbChangePassword.Checked = True Then
            If checkCanLoginAndKeepGlbValue() Then
                grbChangePassword.Visible = True
                ' Me.Height = 255
                enableGrpChangePassword(True)
                txtUserName.ReadOnly = True
                txtUserName.BackColor = Color.PeachPuff
                txtPassword.ReadOnly = True
                txtPassword.BackColor = Color.PeachPuff
                txtPasswordNew.Focus()
                btnLogin.Enabled = False
            Else
                MessageBox.Show("คุณต้องป้อน ชื่อผู้ใช้และรหัสผ่าน ให้ถูกต้อง" & vbCr & "ก่อนที่จะทำการเปลี่ยนแปลงรหัสผ่านใหม่", "ข้อผิดพลาด (Error)", MessageBoxButtons.OK, MessageBoxIcon.Error)
                chbChangePassword.Checked = False
                txtPassword.Focus()
            End If
        Else
            btnLogin.Enabled = True
            grbChangePassword.Visible = False
            ' Me.Height = 170
            enableGrpChangePassword(False)
            txtUserName.ReadOnly = False
            txtUserName.BackColor = Color.White
            txtPassword.ReadOnly = False
            txtPassword.BackColor = Color.White
            txtPassword.Focus()
        End If
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
            ErrorMsg = i & ". User Name don't empty" & vbCr & "(ชื่อผู้ใช้ ห้ามปล่อยว่าง)"
            ErrorFlag = True
        End If
        If txtPassword.Text.Trim = "" Then
            i += 1
            If ErrorMsg <> "" Then ErrorMsg &= vbCr
            ErrorMsg &= i & ". Password don't empty" & vbCr & "(รหัสผ่าน ของผู้ใช้ ห้ามปล่อยว่าง)"
            ErrorFlag = True
        End If
        If txtPasswordNew.Text.Trim = "" Then
            i += 1
            If ErrorMsg <> "" Then ErrorMsg &= vbCr
            ErrorMsg &= i & ". New password don't empty" & vbCr & "(รหัสผ่านใหม่ ของผู้ใช้ ห้ามปล่อยว่าง)"
            ErrorFlag = True
        End If
        If txtPasswordConfirm.Text.Trim = "" Then
            i += 1
            If ErrorMsg <> "" Then ErrorMsg &= vbCr
            ErrorMsg &= i & ". Confirm Password don't empty" & vbCr & "(ยืนยันรหัสผ่านใหม่ ของผู้ใช้ ห้ามปล่อยว่าง)"
            ErrorFlag = True
        End If

        If txtPasswordNew.Text.Trim <> txtPasswordConfirm.Text.Trim Then
            i += 1
            If ErrorMsg <> "" Then ErrorMsg &= vbCr
            ErrorMsg &= i & ". Passwords are not the same, Re-enter" & vbCr _
                           & "(รหัสผ่านใหม่ กับ ยืนยันรหัสผ่าน ไม่ตรงกัน, ให้คุณป้อนใหม่อีกครั้งหนึ่ง"
            ErrorFlag = True
        ElseIf txtPassword.Text.Trim = txtPasswordNew.Text.Trim Then
            i += 1
            If ErrorMsg <> "" Then ErrorMsg &= vbCr
            ErrorMsg &= i & ". New password must different old password " & vbCr & "(รหัสผ่านใหม่ของผู้ใช้ ต้องแตกต่างจากรหัสผ่านเดิม)"
            ErrorFlag = True
        End If

        If ErrorFlag = True Then
            MessageBox.Show(ErrorMsg, "Stop", MessageBoxButtons.OK)
        Else
            'clsConfig.ChangePassword(clsUser.UserName, txtPasswordNew.Text)
            If checkCanLoginAndKeepGlbValue() Then
                oConfig.UpdatePassword(txtUserName.Text.Trim, txtPasswordNew.Text.Trim)
                MessageBox.Show("Changed Password Complete" & vbCr _
                            & "(เปลี่ยนรหัสผ่านสำเร็จแล้วครับ  ต่อไปให้คุณใช้รหัสผ่านนี้ ในการเข้าใช้งานโปรแกรม)" _
                                , "Result", MessageBoxButtons.OK)
                'txtPassword.Text = txtPasswordNew.Text.Trim
                LoginToSystem()
            Else
                MsgBox("Incorrect username or password, please verify.." _
                      & vbCr & "คุณจะเปลี่ยนรหัสผ่านได้ ก็ต่อเมื่อ ชื่อผู้ใช้ หรือ รหัสผ่าน ถูกต้อง" _
                      & vbCr & "  ให้คุณตรวจสอบอีกครั้งหนึ่ง)" _
                       , MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Access denied")
            End If
        End If
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
    Private Sub setComboDatabase()
        cboDatabase.DataSource = (New classConnection).ComboDatabase
        cboDatabase.DisplayMember = "short_name"
        cboDatabase.ValueMember = "short_name"
        cboDatabase.SelectedValue = (New classConnection).GetdefaultDatabase()
    End Sub

    Private Sub cboDatabase_SelectedValueChanged(sender As Object, e As EventArgs) Handles cboDatabase.SelectedValueChanged
        Dim drv As DataRowView = CType(cboDatabase.SelectedItem, DataRowView)

        If drv IsNot Nothing Then
            classConnection.database = oConfig.IsNull(drv("database"), "").ToString()
            classConnection.servername = oConfig.IsNull(drv("servername"), "").ToString()

            'Neung 20/02/2025 for Check Connention
            Dim mssger As String = ""
            If Not oLogin.CheckConnection(mssger) Then
                MessageBox.Show("ไม่สามารถเชื่อมต่อกับ Server ได้ โปรดลองใหม่อีกครั้ง ", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Me.Close()
                Exit Sub
            End If

            setComboWarehouse()
        End If

    End Sub

    Private Sub txtPasswordConfirm_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPasswordConfirm.KeyPress
        If e.KeyChar = vbCr Then
            If txtPasswordNew.Text.Trim <> txtPasswordConfirm.Text.Trim Then
                MessageBox.Show("New password and Confirm password not same" & vbCr _
                                & "(รหัสผ่านใหม่ กับรหัสยืนยันรหัสผ่านใหม่ ไม่เหมือนกัน)" _
                                , "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Else
                btnChangePassword_Click(Nothing, Nothing)
            End If
        End If
    End Sub
End Class