Imports System.Data
Imports System.Data.SqlClient
Imports System.Text
Imports System.Net.Mail

Public Class classQuotation
    Public Quote As DataTable
    Public QuoteItems As DataTable
    Public QuoteCharges As DataTable

    Public Function GetQuotation(ByVal QuoteNo As String)
        Dim quote As New classQuotation
        Dim conn As New SqlConnection((New classConnection).connection)
        Dim comm As New SqlCommand("", conn)
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        Dim dt2 As New DataTable
        Dim dt3 As New DataTable
        Try
            ' Get Quote
            comm.CommandType = CommandType.StoredProcedure
            comm.CommandText = "p_quote_select"
            comm.Parameters.AddWithValue("@quoteno", QuoteNo)
            da.Fill(dt)
            quote.Quote = dt

            ' Get QuoteItems
            comm.CommandText = "p_quote_items_select"
            comm.Parameters.Clear()
            comm.Parameters.AddWithValue("@quoteno", QuoteNo)
            da.Fill(dt2)
            quote.QuoteItems = dt2

            ' Get QuoteItems
            comm.CommandText = "p_quote_charges_select"
            comm.Parameters.Clear()
            comm.Parameters.AddWithValue("@quoteno", QuoteNo)
            da.Fill(dt3)
            conn.Close()  'Sitthana 20190325
            quote.QuoteCharges = dt3
        Catch ex As Exception
            conn.Close()  'Sitthana 20190325
            Throw
        End Try
        Return quote
    End Function
    Public Function SaveQuotation(ByRef dtQuote As DataTable, ByRef dtQuoteItems As DataTable, ByRef dtQuoteCharges As DataTable, ByVal UserID As String) As classResult
        Dim Row As DataRow
        Dim QuoteNo As String
        Dim config As New clsConfig
        Dim cn As New SqlConnection((New classConnection).connection)
        Dim tran As SqlTransaction
        Dim Quotation As New classQuotation
        Dim comm As New SqlCommand
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable

        Dim result As New classResult
        Dim dvQuoteItems_del As New DataView(dtQuoteItems, "", "", DataViewRowState.Deleted)
        Dim dvQuoteCharges_del As New DataView(dtQuoteCharges, "", "", DataViewRowState.Deleted)


        Dim ShipDt As String = ""
        Dim cust_shipdt As String
        If dtQuote.Rows.Count > 0 Then
            Row = dtQuote.Rows(0)
        Else
            result.Success = False
            result.Message = "There is no record to save.."
            Return result
        End If
        tran = Nothing

        cn.Open()
        tran = cn.BeginTransaction
        comm.Connection = cn
        comm.Transaction = tran
        comm.CommandType = CommandType.StoredProcedure

        Try
            comm.CommandText = "p_quote_update"
            comm.Parameters.AddWithValue("@quoteno", Row("quoteno"))
            comm.Parameters.AddWithValue("@quotedt", Row("quotedt"))
            comm.Parameters.AddWithValue("@isProforma", Row("isproforma"))
            comm.Parameters.AddWithValue("@expirydt", Row("expirydt"))
            comm.Parameters.AddWithValue("@validdays", Row("validdays"))
            comm.Parameters.AddWithValue("@custcd", Row("custcd"))
            comm.Parameters.AddWithValue("@empcd", Row("empcd"))
            comm.Parameters.AddWithValue("@agcd", Row("agcd"))
            comm.Parameters.AddWithValue("@remarks", Row("remarks"))
            comm.Parameters.AddWithValue("@attn", Row("attn"))
            comm.Parameters.AddWithValue("@shipcustcd", Row("shipcustcd"))
            comm.Parameters.AddWithValue("@payterms", Row("payterms"))
            comm.Parameters.AddWithValue("@shipterms", Row("shipterms"))
            comm.Parameters.AddWithValue("@bank_code", Row("bank_code"))
            comm.Parameters.AddWithValue("@credit", Row("credit"))
            comm.Parameters.AddWithValue("@crdays", Row("crdays"))
            comm.Parameters.AddWithValue("@custpo", Row("custpo"))
            comm.Parameters.AddWithValue("@ref", Row("ref"))
            comm.Parameters.AddWithValue("@rev", Row("rev"))
            comm.Parameters.AddWithValue("@endbuyercd", Row("endbuyercd"))
            comm.Parameters.AddWithValue("@prgorder", Row("prgorder"))
            comm.Parameters.AddWithValue("@shipmark", Row("shipmark"))
            comm.Parameters.AddWithValue("@submit_bulk", Row("submit_bulk"))
            comm.Parameters.AddWithValue("@no_of_batches", Row("no_of_batches"))
            comm.Parameters.AddWithValue("@submit_bulk_all_batch", Row("submit_bulk_all_batch"))
            comm.Parameters.AddWithValue("@shipvia", Row("shipvia"))
            comm.Parameters.AddWithValue("@contact", Row("contact"))
            comm.Parameters.AddWithValue("@exploc", Row("exploc"))
            comm.Parameters.AddWithValue("@bulk_app_by_dh", Row("bulk_app_by_dh"))
            comm.Parameters.AddWithValue("@bulk_app_by_mk", Row("bulk_app_by_mk"))
            comm.Parameters.AddWithValue("@shipqty_tolerance_high", Row("shipqty_tolerance_high"))
            comm.Parameters.AddWithValue("@shipqty_tolerance_low", Row("shipqty_tolerance_low"))
            comm.Parameters.AddWithValue("@paymodecd", Row("paymodecd"))
            comm.Parameters.AddWithValue("@order_type", Row("order_type"))
            comm.Parameters.AddWithValue("@cancel_status", Row("cancel_status"))
            comm.Parameters.AddWithValue("@approval_status", Row("approval_status"))
            comm.Parameters.AddWithValue("@ConditionsTitle1", Row("Conditionstitle1"))
            comm.Parameters.AddWithValue("@ConditionsTitle2", Row("Conditionstitle2"))
            comm.Parameters.AddWithValue("@ConditionsTitle3", Row("Conditionstitle3"))
            comm.Parameters.AddWithValue("@ConditionsTitle4", Row("Conditionstitle4"))
            comm.Parameters.AddWithValue("@ConditionsTitle5", Row("Conditionstitle5"))
            comm.Parameters.AddWithValue("@ConditionsTitle6", Row("Conditionstitle6"))
            comm.Parameters.AddWithValue("@ConditionsTitle7", Row("Conditionstitle7"))
            comm.Parameters.AddWithValue("@ConditionsTitle8", Row("Conditionstitle8"))
            comm.Parameters.AddWithValue("@ConditionsText1", Row("ConditionsText1"))
            comm.Parameters.AddWithValue("@ConditionsText2", Row("ConditionsText2"))
            comm.Parameters.AddWithValue("@ConditionsText3", Row("ConditionsText3"))
            comm.Parameters.AddWithValue("@ConditionsText4", Row("ConditionsText4"))
            comm.Parameters.AddWithValue("@ConditionsText5", Row("ConditionsText5"))
            comm.Parameters.AddWithValue("@ConditionsText6", Row("ConditionsText6"))
            comm.Parameters.AddWithValue("@ConditionsText7", Row("ConditionsText7"))
            comm.Parameters.AddWithValue("@ConditionsText8", Row("ConditionsText8"))
            comm.Parameters.AddWithValue("@userID", UserID)

            result.Success = True
            result.Message = ""

            Try
                da.Fill(dt)
            Catch ex As Exception
                result.Success = False
                result.Message = ex.Message
                tran.Rollback()
                cn.Close()  'Sitthana 20190325
                Return result
            End Try
            QuoteNo = dt.Rows(0).Item("Quoteno").ToString   ' first column is the quoteno
            dtQuote = dt

            If dtQuoteItems.Rows.Count > 0 Then
                comm.CommandText = "p_quote_items_update"
                For Each Row In dtQuoteItems.Rows
                    If Row.RowState <> DataRowState.Deleted Then
                        cust_shipdt = CDate(config.IsNull(Row("cust_shipdt"), "01/01/1900")).ToString("yyyyMMdd")
                        ShipDt = CDate(config.IsNull(Row("shipdt"), "01/01/1900")).ToString("yyyyMMdd")

                        comm.Parameters.Clear()
                        comm.Parameters.AddWithValue("quoteno", QuoteNo)
                        comm.Parameters.AddWithValue("id_quote_items", Row("id_quote_items"))
                        comm.Parameters.AddWithValue("itemlineid", Row("ItemLineID"))
                        comm.Parameters.AddWithValue("design_no", Row("design_no"))
                        comm.Parameters.AddWithValue("col", Row("col"))
                        comm.Parameters.AddWithValue("custdes", Row("custdes"))
                        comm.Parameters.AddWithValue("custcol", Row("custcol"))
                        comm.Parameters.AddWithValue("labeldes", Row("labeldes"))
                        comm.Parameters.AddWithValue("custpono", Row("custpono"))
                        comm.Parameters.AddWithValue("qtyfrom", Row("qtyfrom"))
                        comm.Parameters.AddWithValue("qtyto", Row("qtyto"))
                        comm.Parameters.AddWithValue("uom", Row("uom"))
                        comm.Parameters.AddWithValue("price", Row("price"))
                        comm.Parameters.AddWithValue("exrt", Row("exrt"))
                        comm.Parameters.AddWithValue("curr", Row("curr"))
                        comm.Parameters.AddWithValue("discamt", Row("discamt"))
                        comm.Parameters.AddWithValue("discper", Row("discper"))
                        comm.Parameters.AddWithValue("shipdt", ShipDt)
                        comm.Parameters.AddWithValue("gwth", Row("gwth"))
                        comm.Parameters.AddWithValue("cust_shipdt", cust_shipdt)
                        comm.Parameters.AddWithValue("fwth", Row("fwth"))
                        comm.Parameters.AddWithValue("item_remarks", Row("item_remarks"))
                        comm.Parameters.AddWithValue("status_remarks", Row("status_remarks"))
                        comm.Parameters.AddWithValue("userid", UserID)

                        Try
                            da.Fill(dt)
                        Catch ex As Exception
                            result.Success = False
                            result.Message = ex.Message
                            QuoteNo = ""
                            tran.Rollback()
                            cn.Close()  'Sitthana 20190325
                            Return result
                        End Try
                    End If
                Next
            End If

            If dvQuoteItems_del.Count > 0 Then
                comm.CommandText = "p_quote_items_delete"
                For Each drvCharges As DataRowView In dvQuoteItems_del

                    comm.Parameters.Clear()
                    comm.Parameters.AddWithValue("id_quote_items", drvCharges("id_quote_items"))
                    comm.Parameters.AddWithValue("userid", UserID)
                    Try
                        comm.ExecuteNonQuery()
                    Catch ex As Exception
                        result.Success = False
                        result.Message = ex.Message
                        tran.Rollback()
                        cn.Close()  'Sitthana 20190325
                        Return result
                    End Try
                Next
            End If

            If dtQuoteCharges.Rows.Count > 0 Then
                comm.CommandText = "p_quote_charges_update"
                For Each Row In dtQuoteCharges.Rows
                    If Row.RowState <> DataRowState.Deleted Then
                        comm.Parameters.Clear()
                        comm.Parameters.AddWithValue("QuoteNO", QuoteNo)
                        comm.Parameters.AddWithValue("id_quote_charges", Row("id_quote_charges"))
                        comm.Parameters.AddWithValue("ChargeLineID", Row("ChargeLineID"))
                        comm.Parameters.AddWithValue("itcd", Row("itcd"))
                        comm.Parameters.AddWithValue("exrt", Row("exrt"))
                        comm.Parameters.AddWithValue("curr", Row("curr"))
                        comm.Parameters.AddWithValue("ChargeAmt", Row("ChargeAmt"))
                        comm.Parameters.AddWithValue("Charge_Remarks", Row("Charge_Remarks"))
                        comm.Parameters.AddWithValue("userid", UserID)

                        Try
                            da.Fill(dt)
                        Catch ex As Exception
                            result.Success = False
                            result.Message = ex.Message
                            QuoteNo = ""
                            tran.Rollback()
                            cn.Close()  'Sitthana 20190325
                            Return result
                        End Try
                    End If
                Next
            End If

            If dvQuoteCharges_del.Count > 0 Then
                comm.CommandText = "p_quote_charges_delete"
                For Each drv As DataRowView In dvQuoteCharges_del

                    comm.Parameters.Clear()
                    comm.Parameters.AddWithValue("id_quote_charges", drv("id_quote_charges"))
                    comm.Parameters.AddWithValue("userid", UserID)
                    Try
                        comm.ExecuteNonQuery()
                    Catch ex As Exception
                        result.Success = False
                        result.Message = ex.Message
                        tran.Rollback()
                        cn.Close()  'Sitthana 20190325
                        Return result
                    End Try
                Next
            End If

            tran.Commit()
            cn.Close()  'Sitthana 20190325
            ' reload saved data
            'Quotation = GetQuotation(QuoteNo)
            'dtQuote = Quotation.Quote
            'dtQuoteItems = Quotation.QuoteItems
            'dtQuoteCharges = Quotation.QuoteCharges
            Return result
        Catch ex As Exception
            result.Success = False
            result.Message = ex.Message
            QuoteNo = ""
            tran.Rollback()
            cn.Close()  'Sitthana 20190325
            Return result
        End Try
    End Function
    Public Function CancelQuotation(ByRef dtQuote As DataTable, ByVal UserID As String) As classResult
        Dim Row As DataRow
        Dim QuoteNo As String
        Dim cn As New SqlConnection((New classConnection).connection)
        Dim tran As SqlTransaction
        Dim comm As New SqlCommand
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable

        Dim result As New classResult

        If dtQuote.Rows.Count > 0 Then
            Row = dtQuote.Rows(0)
        Else
            result.Success = False
            result.Message = "There is no record to cancel.."
            Return result
        End If
        tran = Nothing

        cn.Open()
        tran = cn.BeginTransaction
        comm.Connection = cn
        comm.Transaction = tran
        comm.CommandType = CommandType.StoredProcedure

        Try
            comm.CommandText = "p_quote_cancel"
            comm.Parameters.AddWithValue("@quoteno", Row("quoteno"))
            comm.Parameters.AddWithValue("@userID", UserID)

            result.Success = True
            result.Message = ""

            Try
                da.Fill(dt)
            Catch ex As Exception
                result.Success = False
                result.Message = ex.Message
                tran.Rollback()
                cn.Close()  'Sitthana 20190325
                Return result
            End Try
            dtQuote = dt
        Catch ex As Exception
            result.Success = False
            result.Message = ex.Message
            QuoteNo = ""
            tran.Rollback()
            cn.Close()  'Sitthana 20190325
            Return result
        End Try
        tran.Commit()
        cn.Close()  'Sitthana 20190325
        Return result
    End Function
    Public Function MailQuotation(ByVal QuoteNo As String) As classResult
        Dim strBodyHTML As New StringBuilder

        Dim cn As New SqlClient.SqlConnection
        Dim cmd As New SqlClient.SqlCommand
        Dim dt As New DataTable
        Dim dr As DataRow

        Dim Font3 As String
        Dim font2 As String

        Dim strFrom As MailAddress
        Dim strTo As MailAddress
        Dim strCc As MailAddress
        Dim strSubject As String
        Dim strAttachments As String
        Dim strSMTPServer As String
        Dim SMTPClient As New SmtpClient

        Dim result As New classResult
        strFrom = Nothing
        strTo = Nothing
        strCc = Nothing
        strSMTPServer = ""
        strAttachments = ""
        result.Message = ""
        result.Success = True

        Try
            cn = (New classConnection).getSQLConnection

            cmd.CommandType = CommandType.StoredProcedure
            cmd.CommandText = "p_quote_rep"
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@quoteno", QuoteNo)
            cmd.Connection = cn

            Dim da As New SqlClient.SqlDataAdapter(cmd)

            da.Fill(dt)
            cn.Close()  'Sitthana 20190325
            If dt.Rows.Count = 0 Then
                result.Message = "Requested quotation is not found.."
                result.Success = False
                MailQuotation = result
            End If
            strFrom = New MailAddress(dt.Rows(0)("empmail"))
            strTo = New MailAddress("amorn@geminitextile.com")
            strCc = New MailAddress(dt.Rows(0)("empmail"))

            strAttachments = ""
            strSMTPServer = dt.Rows(0)("SMTPServer")
        Catch ex As Exception
            result.Message = ex.Message.ToString
            result.Success = False
            MailQuotation = result
        End Try

        Font3 = "<font size=""" + "3" + """" + "face=""" + "Times" + """" + ">"
        font2 = "<font size=""" + "2" + """" + "face=""" + "Times" + """" + ">"

        strSubject = "Quotation No.: " + dt.Rows(0)("quoteno") + ", " + dt.Rows(0)("quotedt2") + ", REV#: " + dt.Rows(0)("rev").ToString + " For: " + dt.Rows(0)("custname")

        strBodyHTML.Append("<HTML>")
        strBodyHTML.Append("<H1> Quotation </h1>")
        strBodyHTML.Append("<P>")
        strBodyHTML.Append("<H1>")
        strBodyHTML.Append(Font3)
        strBodyHTML.Append("No. " + dt.Rows(0)("quoteno") + "       ")
        strBodyHTML.Append("Dt:  " + dt.Rows(0)("quotedt2") + "     ")
        strBodyHTML.Append("For: " + dt.Rows(0)("custname"))
        strBodyHTML.Append("<BR>")
        strBodyHTML.Append("Sales person: " + dt.Rows(0)("empname") + "</FONT>")
        strBodyHTML.Append("</H1>")

        strBodyHTML.Append("<TABLE CELLSPACING=3 CELLPADING=1 ")

        'strBodyHTML.Append("<TR BGCOLOR=""" + "#99CCFF" + """" + ">")
        'strBodyHTML.Append("<TD>&nbsp;</TD>")
        'strBodyHTML.Append("<TH>" + font2 + "Design no." + "</TH>")
        'strBodyHTML.Append("<TH>" + font2 + "Color" + "</TH>")
        'strBodyHTML.Append("<TH>" + font2 + "Qty" + "</TH>")
        'strBodyHTML.Append("<TH>" + font2 + "Price" + "</TH>")
        'strBodyHTML.Append("</TR>")

        For Each dr In dt.Rows
            strBodyHTML.Append("<TR bgcolor=""WHITE""" + ">")

            strBodyHTML.Append("<TH>" + font2 + dr("refdesno").ToString + "</th>")

            strBodyHTML.Append("<TD >")
            strBodyHTML.Append(font2)
            strBodyHTML.Append("")
            strBodyHTML.Append(dr("design_no").ToString)
            strBodyHTML.Append("</FONT>")
            strBodyHTML.Append("</TD>")

            strBodyHTML.Append("<TD >")
            strBodyHTML.Append(font2)
            strBodyHTML.Append("")
            strBodyHTML.Append(dr("col").ToString)
            strBodyHTML.Append("</FONT>")
            strBodyHTML.Append("</TD>")

            'strBodyHTML.Append("<TD >")
            'strBodyHTML.Append(font2)
            'strBodyHTML.Append("")
            'strBodyHTML.Append(dr("Qtyto").ToString.Trim + " " + dr("UOM").ToString)
            'strBodyHTML.Append("</FONT>")
            'strBodyHTML.Append("</TD>")

            strBodyHTML.Append("<TD >")
            strBodyHTML.Append(font2)
            strBodyHTML.Append("")
            strBodyHTML.Append(dr("Curr").ToString.Trim + " " + dr("Price").ToString)
            strBodyHTML.Append("</FONT>")
            strBodyHTML.Append("</TD>")

            strBodyHTML.Append("</TR>")
        Next

        strBodyHTML.Append("</TABLE>")
        strBodyHTML.Append("</HTML>")

        Try
            Dim insMail As New MailMessage()
            With insMail
                .IsBodyHtml = True
                .From = strFrom
                .To.Add(strTo)
                .Subject = strSubject
                .Body = strBodyHTML.ToString
                If strCc IsNot Nothing Then
                    .CC.Add(strCc)
                End If
                .CC.Add("suresh@geminitextile.com")

                If Not strAttachments.Equals(String.Empty) Then
                    Dim strFile As String
                    Dim strAttach() As String = strAttachments.Split(";")
                    For Each strFile In strAttach
                        .Attachments.Add(New Attachment(strFile.Trim()))
                    Next
                End If
            End With

            If Not strSMTPServer.Equals(String.Empty) Then
                SmtpClient.Host = strSMTPServer
                SmtpClient.Send(insMail)
            End If

        Catch e As Exception
            Console.WriteLine(e.Message)
        End Try
        MailQuotation = result
    End Function
End Class
