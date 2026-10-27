Imports System.IO
Imports System.Security.Permissions
Imports System.Security.Principal
Imports System.Runtime.InteropServices
Public Class frmDocAttachments
    Private toggle As Boolean = False
    Private myColor As Color
    Private picBoxLocation As Point

    Dim config As New clsConfig
    Dim dtdoc_attachments As DataTable
    Dim dsPhoto As DataSet
    Dim RowsNo As Integer
    Dim Strsource_doc_number As String = ""
    Dim Strsource_doc_type As String

       Dim clsuser As new classUserInfo

    Public Property UserInfo() As classUserInfo
        Get
            UserInfo = clsuser
        End Get
        Set(ByVal NewValue As classUserInfo)
            clsuser = NewValue
        End Set
    End Property

    Public Property Psource_doc_number As String
        Get
            Psource_doc_number = Strsource_doc_number
        End Get
        Set(ByVal NewValue As String)
            Strsource_doc_number = NewValue
        End Set
    End Property

    Public Property Psource_doc_type As String
        Get
            Psource_doc_type = Strsource_doc_type
        End Get
        Set(ByVal NewValue As String)
            Strsource_doc_type = NewValue
        End Set
    End Property

    Private Sub btnImagePath_Click(sender As Object, e As EventArgs) Handles btnImagePath.Click
        If txtDocno.Text = "" Then
            MessageBox.Show("โปรด เลือก Doc No. ", "System Message!", MessageBoxButtons.OK, MessageBoxIcon.Stop, MessageBoxDefaultButton.Button1)
            Exit Sub

        End If

        Dim OpenFileDialog As New OpenFileDialog


        Dim replace As String = txtDocno.Text.Replace("/", "-")
        Dim strFileName As String = replace
        Dim strFileType As String = ".JPG"
        Dim strFilePath As String = "C:"


        OpenFileDialog.InitialDirectory = "C:"
        OpenFileDialog.Filter = "Image Files(*.JPG;*.BMP;*.GIF,*.AVI;*.MPG;*.MP4)|*.JPG;*.BMP;*.GIF;*.AVI;*.MPG;*.MP4|All files (*.*)|*.*"
        'OpenFileDialog.Filter = "Image Files (*.JPG;*.BMP;*.GIF)|*.JPG;*.BMP;*.GIF|Video Files (*.AVI;*.MPG;*.MP4)|*.AVI;*.MPG;*.MP4|All files (*.*)|*.*"
        OpenFileDialog.Multiselect = False


        If OpenFileDialog.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            txtfile_location.Text = OpenFileDialog.FileName
            strFileType = OpenFileDialog.FileName.ToString.Substring(OpenFileDialog.FileName.ToString.Length - 4, 4).ToUpper

            If strFileType = ".JPG" Or strFileType = ".GIF" Or strFileType = ".PNG" Then
                'AxWindowsMediaPlayer1.Visible = False
                PictureBox1.Visible = True
                'PictureBox1.Image = Image.FromFile(txtfile_location.Text.Trim.ToString)
                PictureBox1.ImageLocation = txtfile_location.Text.Trim.ToString
            ElseIf strFileType = ".AVI" Or strFileType = ".MPG" Or strFileType = ".MP4" Then
                PictureBox1.Visible = False
                'AxWindowsMediaPlayer1.Visible = True
                'AxWindowsMediaPlayer1.URL = txtfile_location.Text.Trim.ToString
            ElseIf strFileType.ToUpper = ".PDF" Then
                PictureBox1.ImageLocation = txtfile_location.Text.Trim.ToString
            Else
                PictureBox1.Visible = False
                'AxWindowsMediaPlayer1.Visible = False
            End If
        End If

    End Sub

    Private Sub frmDocAttachments_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized

        Call GenCombosourceDocType()

        Call InitControl()
    End Sub

    Private Sub GenCombosourceDocType()
        Dim objdb As New classPhoto

        cbosource_doc_type.DataSource = objdb.GetsourceDocType("")
        cbosource_doc_type.DisplayMember = "source_doc_type_name"
        cbosource_doc_type.ValueMember = "source_doc_type_code"


    End Sub

    Private Sub InitControl()

        RowsNo = Nothing
        txtCount.Text = 0

        txtrow_number.Text = 0
        Call Loaddata(Strsource_doc_number)

    End Sub

    Private Sub Loaddata(ByVal StrDocno As String)
        Dim objDB As New classPhoto

        dtdoc_attachments = Nothing
        dtdoc_attachments = objDB.GetPhoto(StrDocno)

        grddata.AutoGenerateColumns = False
        grddata.DataSource = dtdoc_attachments

        Call Binddata(dtdoc_attachments)


    End Sub


    Private Sub Binddata(ByVal dtPhoto As DataTable)
        Dim config As New clsConfig


        If dtPhoto.Rows.Count > 0 Then

            txtDocno.Text = dtPhoto.Rows(0)("source_doc_number").ToString
            CboPhotoNo.DataSource = dtPhoto
            CboPhotoNo.DisplayMember = "row_number"
            CboPhotoNo.ValueMember = "row_number"
            RowsNo = dtPhoto.Rows(0)("row_number")
            If dtPhoto.Rows(0)("file_type").ToString.Trim = ".JPG" Or dtPhoto.Rows(0)("file_type").ToString.Trim = ".PNG" Or dtPhoto.Rows(0)("file_type").ToString.Trim = ".GIF" Then
                'AxWindowsMediaPlayer1.Visible = False
                PictureBox1.Visible = True
                PictureBox1.Image = Image.FromFile(grddata.CurrentRow.Cells("file_location").Value)
            ElseIf dtPhoto.Rows(0)("file_type").ToString.Trim = ".AVI" Or dtPhoto.Rows(0)("file_type").ToString.Trim = ".MPG" Or dtPhoto.Rows(0)("file_type").ToString.Trim = ".MP4" Then
                PictureBox1.Visible = False

                'AxWindowsMediaPlayer1.Visible = True
                'AxWindowsMediaPlayer1.URL = grddata.CurrentRow.Cells("file_location").Value.ToString
                'AxWindowsMediaPlayer1.Ctlcontrols.play()
            ElseIf dtPhoto.Rows(0)("file_type").ToString.Trim.ToUpper = ".PDF" Then
                PictureBox1.Visible = False
                'AxWindowsMediaPlayer1.Visible = False

            End If

            txtfile_location.Text = dtPhoto.Rows(0)("file_location").ToString
            txtrow_number.Text = dtPhoto.Rows(0)("row_number")
            txtCount.Text = dtdoc_attachments.Rows.Count
            txtRemark.Text = dtPhoto.Rows(0)("file_description")
        Else
            txtDocno.Text = Strsource_doc_number
            CboPhotoNo.DataSource = dtPhoto
            CboPhotoNo.DisplayMember = "row_number"
            CboPhotoNo.ValueMember = "row_number"
            RowsNo = 0
            txtrow_number.Text = 0
            txtCount.Text = 0
            cbosource_doc_type.SelectedValue = Strsource_doc_type
            txtfile_location.Text = ""
            PictureBox1.Image = Image.FromFile(clsuser.ImagePath + "GK.bmp") '"\\ESCH-SVR-APP\MEDIA\PHOTO\MACHINE\GK.bmp")
            PictureBox1.Visible = False
            'AxWindowsMediaPlayer1.URL = "\\srv-gemmaknits\MEDIA\PHOTO\MACHINE\GK.bmp"
            'AxWindowsMediaPlayer1.Visible = False
        End If

    End Sub

    Private Sub btnleft_Click(sender As Object, e As EventArgs) Handles btnleft.Click
        If RowsNo > 0 Then
            RowsNo = RowsNo - 1
            Loader(RowsNo)
        End If

        If CboPhotoNo.SelectedValue > 1 Then
            CboPhotoNo.SelectedValue = CboPhotoNo.SelectedValue - 1
        End If
    End Sub

    Private Sub btnright_Click(sender As Object, e As EventArgs) Handles btnright.Click
        If RowsNo < dtdoc_attachments.Rows.Count - 1 Then
            RowsNo = RowsNo + 1
            Loader(RowsNo)
        End If
        If CboPhotoNo.SelectedValue < grddata.Rows.Count - 1 Then
            CboPhotoNo.SelectedValue = CboPhotoNo.SelectedValue + 1
        End If
    End Sub

    Private Sub Loader(ByVal row_number As Nullable(Of Integer))


        txtCount.Text = dtdoc_attachments.Rows.Count
        txtrow_number.Text = dtdoc_attachments.Rows(row_number)("row_number").ToString
        txtfile_location.Text = dtdoc_attachments.Rows(row_number)("file_location")

        If dtdoc_attachments.Rows(row_number)("file_type").ToString.Trim = ".JPG" Or dtdoc_attachments.Rows(row_number)("file_type").ToString.Trim = ".GIF" Or dtdoc_attachments.Rows(row_number)("file_type").ToString.Trim = ".PNG" Then
            ' AxWindowsMediaPlayer1.Visible = False
            PictureBox1.Visible = True
            PictureBox1.Image = Image.FromFile(dtdoc_attachments.Rows(row_number)("file_location").ToString)
        ElseIf dtdoc_attachments.Rows(row_number)("file_type").ToString.Trim = ".AVI" Or dtdoc_attachments.Rows(row_number)("file_type").ToString.Trim = ".MPG" Or dtdoc_attachments.Rows(row_number)("file_type").ToString.Trim = ".MP4" Then
            PictureBox1.Visible = False
            ' AxWindowsMediaPlayer1.Visible = True
            ' AxWindowsMediaPlayer1.URL = dtdoc_attachments.Rows(row_number)("file_location").ToString

        End If


        txtRemark.Text = dtdoc_attachments.Rows(row_number)("file_description")
        txtdoc_attachments_id.Text = dtdoc_attachments.Rows(row_number)("doc_attachments_id")
    End Sub

    Private Sub btnUpload_Click(sender As Object, e As EventArgs) Handles btnUpload.Click
        Call UploadFile()
    End Sub

    Private Sub UploadFile()

        Dim thisDate As Date = Now

        thisDate.ToString("yyyyMMdd-HHmmss")

        Dim OpenFileDialog As New OpenFileDialog
        Dim NewDesignNoreplace As String = txtDocno.Text.Replace("/", "-")
        Dim strFileName As String = NewDesignNoreplace & "-" & thisDate.ToString("yyyyMMdd-HHmmss")


        Dim strFileType As String = txtfile_location.Text.Trim.Substring(txtfile_location.Text.Trim.ToString.Length - 4, 4)
        Dim strFilePath As String = clsuser.ImagePath '"\\srv-gemmaknits\media\PHOTO\MACHINE\"

        OpenFileDialog.FileName = txtfile_location.Text.Trim

        Try
            If OpenFileDialog.FileName <> "" Then 'Add By Neung
                My.Computer.FileSystem.CopyFile(
                OpenFileDialog.FileName,
                strFilePath & strFileName & strFileType,
               Microsoft.VisualBasic.FileIO.UIOption.AllDialogs,
                Microsoft.VisualBasic.FileIO.UICancelOption.ThrowException)
            End If

            txtfile_location.Text = strFilePath & strFileName & strFileType


            If strFileType = ".JPG" Or strFileType = ".GIF" Or strFileType = ".PNG" Then
                'AxWindowsMediaPlayer1.Visible = False
                PictureBox1.Visible = True
                PictureBox1.Image = Image.FromFile(txtfile_location.Text.Trim.ToString)
            ElseIf strFileType = ".AVI" Or strFileType = ".MPG" Or strFileType = ".MP4" Then
                PictureBox1.Visible = False
                'AxWindowsMediaPlayer1.Visible = True
                'AxWindowsMediaPlayer1.URL = txtfile_location.Text.Trim.ToString
            ElseIf strFileType = ".PDF" Then

            End If

            MessageBox.Show("Upload สำเร็จ", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)

            Call AddNewPhoto(0, cbosource_doc_type.SelectedValue, Strsource_doc_number, txtRemark.Text, txtfile_location.Text.Trim, strFileType)
            Call SaveData()
            Call Loaddata(txtDocno.Text.Trim) 'Add By Neung 

        Catch ex As Exception
            MessageBox.Show("Upload ไม่สำเร็จ", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)

        End Try
    End Sub


    Private Sub AddNewPhoto(ByVal doc_attachments_id As Nullable(Of Long), ByVal source_doc_type As String, ByVal source_doc_number As String, ByVal file_description As String, ByVal file_location As String, ByVal file_type As String)
        Dim config As New clsConfig
        If txtDocno.Text = "" Then Exit Sub

        If doc_attachments_id = 0 Then
            Dim dr As DataRow
            Dim msg As String = ""
            Dim i As Integer = 0

            Dim j As Integer = 0
            dr = dtdoc_attachments.NewRow
            For j = 0 To dtdoc_attachments.Columns.Count - 1
                dr("doc_attachments_id") = doc_attachments_id
                dr("source_doc_type") = source_doc_type
                dr("source_doc_number") = source_doc_number
                dr("file_description") = file_description
                dr("file_location") = file_location
                dr("file_type") = file_type
            Next
            dtdoc_attachments.Rows.Add(dr)
        End If

        Call GenCboPhotoNo(dtdoc_attachments)

    End Sub

    Private Sub GenCboPhotoNo(ByVal dtdoc_attachments As DataTable)

        CboPhotoNo.DataSource = dtdoc_attachments
        CboPhotoNo.ValueMember = "row_number"
        CboPhotoNo.DisplayMember = "row_number"
        'CboPhotoNo.DisplayMember = "row_number"
        'CboPhotoNo.ValueMember = "row_number"

    End Sub

    Private Function SaveData() As Boolean
        Dim config As New clsConfig
        Dim objdb As New classPhoto
        Dim PhotoHeader As New classPhoto.PhotoHeader

        'Call Updatetextbox(txtRemark.Text, dtdoc_attachments)   'เอาข้อความที่พิมพ์ใน text box ไปใว้ใน descrition ของ  grid ทุก row


        Dim dtv_add As New DataView(dtdoc_attachments, "", "", DataViewRowState.Added)
        Dim dtv_upd As New DataView(dtdoc_attachments, "", "", DataViewRowState.ModifiedCurrent)
        Dim dtv_del As New DataView(dtdoc_attachments, "", "", DataViewRowState.Deleted)

        PhotoHeader.source_doc_type = Strsource_doc_number

        PhotoHeader.Message = ""

        If objdb.SavePhoto(PhotoHeader, dtdoc_attachments, dtv_add, dtv_upd, dtv_del, clsuser) Then
            Return True
        Else
            Return False
        End If


    End Function

    Private Function Updatetextbox(ByVal file_description As String, ByRef dt As DataTable) As Boolean
        If dt.Rows.Count > 0 Then
            Dim i As Integer = 0
            For i = 0 To dt.Rows.Count - 1
                'MsgBox(dt.Rows(i).RowState.ToString)  '-> When debug RowState = Unchanged
                If dt.Rows(i).RowState <> DataRowState.Deleted Then
                    If grddata.CurrentRow.Cells("file_description").Value <> file_description Then
                        grddata.CurrentRow.Cells("file_description").Value = file_description
                    End If
                End If
            Next
        End If


        Return False
    End Function
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        txtRemark.Focus()
        Dim result As System.Windows.Forms.DialogResult
        result = MessageBox.Show("Would you like to save ?", "System Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button3)
        If result = System.Windows.Forms.DialogResult.No Then Exit Sub



        If SaveData() Then
            MessageBox.Show("Save is Complete! : บันทึกสำเร็จ! ", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
            Call Loaddata(txtDocno.Text.Trim)
        Else
            MessageBox.Show("Save is not Complete! : บันทึกไม่สำเร็จ! ", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
        End If
    End Sub

    Private Sub btnMinimized_Click(sender As Object, e As EventArgs) Handles btnMinimized.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        If MessageBox.Show("Would you like to exit ?", "System Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = System.Windows.Forms.DialogResult.Yes Then Me.Close()
    End Sub

    Private Sub grddata_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles grddata.CellContentClick
        If grddata.CurrentCell.IsInEditMode Then grddata.EndEdit()
    End Sub

    Private Sub grddata_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles grddata.CellClick
        With grddata
            If .Rows.Count = 0 Then
                Exit Sub
            End If

            Dim FileName As String = .Rows(.CurrentRow.Index).Cells("file_location").Value.ToString.ToUpper
            If System.IO.File.Exists(FileName) = False Then
                MessageBox.Show("ไม่พบ File " & FileName & vbCr _
                              & "ให้คุณตรวจสอบตำแหน่งที่จัดเก็บอีกครั้งหนึ่ง ", "ข้อผิดพลาด", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If

            PictureBox1.Image = Image.FromFile(FileName)
            Select Case .Columns(.CurrentCell.ColumnIndex).Name.ToUpper
                Case "BTNVIEW"
                    Select Case .Rows(.CurrentRow.Index).Cells("file_type").Value.ToString.ToUpper.Trim
                        Case ".PDF"
                            Process.Start("AcroRd32", FileName)
                        Case ".JPG", ".GIF", ".PNG"
                            Process.Start("mspaint", FileName)
                        Case ".AVI", ".MPG", ".MP4"
                            MessageBox.Show("ไม่มี แอปที่จะใช้เปิดไฟว์ ที่คุณเลือก", "ข้อผิดพลาด", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                        Case Else
                            MessageBox.Show("ไม่มี แอปที่จะใช้เปิดไฟว์ ที่คุณเลือก", "ข้อผิดพลาด", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                    End Select
            End Select
        End With
    End Sub
End Class