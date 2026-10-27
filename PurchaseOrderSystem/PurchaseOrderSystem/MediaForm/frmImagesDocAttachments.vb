Imports System.IO
'Imports AxWMPLib 'Sitthana Comment 20220624
'Imports WMPLib 'Sitthana Comment 20220624
Public Class frmImagesDocAttachments
    ''Private toggle As Boolean = False
    ''Private myColor As Color
    ' Private picBoxLocation As Point ' Sitthana

    Private clsuser As classUserInfo
    Private _SourceDocNumber As String = ""
    Private _SourceDocType As String = ""
    Private _SourceType As String = ""
    Private _DefaultSourcePath As String = "" 'Sitthana 20210708
    Private _LoadDocComplete As Boolean = False

    Public Property UserInfo() As classUserInfo
        Get
            UserInfo = clsuser
        End Get
        Set(ByVal NewValue As classUserInfo)
            clsuser = NewValue
        End Set
    End Property
    Public Property pSourceDocNumber As String
        Get
            pSourceDocNumber = _SourceDocNumber
        End Get
        Set(ByVal NewValue As String)
            _SourceDocNumber = NewValue
        End Set
    End Property
    Public Property pSourceDocType As String
        Get
            pSourceDocType = _SourceDocType
        End Get
        Set(ByVal NewValue As String)
            _SourceDocType = NewValue
        End Set
    End Property
    Public Property pSourceType As String
        Get
            pSourceType = _SourceType
        End Get
        Set(ByVal NewValue As String)
            _SourceType = NewValue
        End Set
    End Property
    Public Property pDefaultSourcePath As String
        Get
            pDefaultSourcePath = _DefaultSourcePath
        End Get
        Set(ByVal newvalue As String)
            _DefaultSourcePath = newvalue
        End Set
    End Property
    Public Property LoadDocComplete As Boolean
        Get
            LoadDocComplete = _LoadDocComplete
        End Get
        Set(ByVal NewValue As Boolean)
            _LoadDocComplete = NewValue
        End Set
    End Property
#Region "Constant Variable"
    Private Const SourceDocTypeSoLine As String = "SO_LINE"
    Private Const SourceDocTypeTransFile As String = "TRANS_FILE"
    Private Const SourceDocTypeYarnFile As String = "YARN_FILE"

    Private Const OutputFilePathSoItm As String = "\\Srv-gemmaknits\MEDIA\FILE\SOLINE\"
    Private Const OutputFilePathTrans As String = "\\Srv-gemmaknits\MEDIA\FILE\TRANS_FILE\"
    Private Const OutputFilePathYarn As String = "\\Srv-gemmaknits\MEDIA\FILE\YARN_FILE\"

    Private Const OutputPhotoPathSoItm As String = "\\Srv-gemmaknits\MEDIA\PHOTO\SOLINE\"

    Private Const SourceTypePhoto As String = "Photo"
    Private Const SourceTypeDoc As String = "File"
#End Region

    Dim config As New clsConfig
    Dim dtDocAttachments As DataTable
    Dim bsDocAttachments As DataSet
    Dim dsPhoto As DataSet
    Dim RowsNo As Integer

    'From Input File
    Private OutputFileName As String = ""
    Private OutputExtensionsName As String = ""
    Private FilenameWithDotLen As Integer = 0

    'Keep Data
    Private DocAttachmentsId As Integer = 0

    Private Sub tsbtnExit_Click(sender As Object, e As EventArgs) Handles tsbtnExit.Click
        Me.Close()
    End Sub
    Private Sub frmImagesDocAttachments_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If MessageBox.Show("คุณยืนยันที่จะออกจากโปรแกรม ?" _
                           , "Confirm Close Program" _
                           , MessageBoxButtons.OKCancel _
                           , MessageBoxIcon.Question
                           ) = vbOK Then
            e.Cancel = False
        Else
            e.Cancel = True
        End If
    End Sub
    Private Sub frmPhoto_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        InitControl()
        InitObject()
        InitObjValue()
    End Sub
    Private Sub InitObject()
        '12, 103651, 310
        Select Case _SourceType
            Case SourceTypeDoc
                grpImage.Visible = False
                With Me
                    .Width = 651
                    .Height = 313
                    .Left = 100
                    .Top = 100
                End With
            Case SourceTypePhoto
                grpImage.Visible = True
                With Me
                    .Width = 1026
                    .Height = 509
                    .Left = 50
                    .Top = 1
                End With
        End Select

    End Sub
    Private Sub InitObjValue()
        txtSourceDocNumber.Text = _SourceDocNumber
        txtSourceDocType.Text = _SourceDocType.ToUpper
        txtFileLocation.Text = _DefaultSourcePath
        SetDefaultOutputPath()
        lblCurrentSize.Text = ""
        lblReducingFactor.Text = ""
        lblReducingSize.Text = ""

        Loaddata(_SourceDocType, _SourceDocNumber)
    End Sub

    Private Sub SetDefaultOutputPath()
        Select Case _SourceDocType
            Case SourceDocTypeSoLine
                Select Case _SourceType
                    Case SourceTypeDoc
                        txtOutputPathName.Text = OutputFilePathSoItm
                    Case SourceTypePhoto
                        txtOutputPathName.Text = OutputPhotoPathSoItm
                End Select
            Case SourceDocTypeTransFile
                Select Case _SourceType
                    Case SourceTypeDoc
                        txtOutputPathName.Text = OutputFilePathTrans
                    Case SourceTypePhoto
                        txtOutputPathName.Text = OutputFilePathTrans
                End Select
            Case SourceDocTypeYarnFile
                Select Case _SourceType
                    Case SourceTypeDoc
                        txtOutputPathName.Text = OutputFilePathYarn
                    Case SourceTypePhoto
                        txtOutputPathName.Text = OutputFilePathYarn
                End Select
        End Select
    End Sub
    Private Sub SetOutputFileName(pInpupFileName As String)
        txtInputFileName.Text = pInpupFileName
        OutputFileName = txtSourceDocNumber.Text.ToString.Replace("/", "-")
        FilenameWithDotLen = InStr(pInpupFileName, ".")
        OutputExtensionsName = getFileExtension(pInpupFileName)
        txtOutputFileName.Text = txtOutputPathName.Text.Trim & OutputFileName & "." & OutputExtensionsName
        'OutputFileNameWithPath = txtOutputPathName.Text.Trim & txtOutputFileName.Text.Trim
        'Directory.SetCurrentDirectory(Mid(pInpupFileName, 1, InStr(pInpupFileName, "\")))
    End Sub
    Private Function getFileExtension(pFileName As String)
        Dim FileExtension As String = ""
        FilenameWithDotLen = InStr(pFileName, ".")
        FileExtension = Mid(pFileName, FilenameWithDotLen + 1, Len(pFileName) - FilenameWithDotLen).Trim.ToUpper
        Return FileExtension
    End Function
    Private Sub btnGetSourceFileName_Click(sender As Object, e As EventArgs) Handles btnGetSourceFileName.Click
        'GetBrowsFileName()
        Dim InputFileName As String = ""

        If Trim(_DefaultSourcePath) = "" Then
            InputFileName = BrowseGetFile(System.IO.Directory.GetCurrentDirectory)
        Else
            InputFileName = BrowseGetFile(_DefaultSourcePath) 'Sitthana 20210708
        End If
        txtFileLocation.Text = InputFileName 'Sitthana 20210708

        If InputFileName <> "" Then
            _DefaultSourcePath = Path.GetDirectoryName(InputFileName) 'Sitthana 20210708
            SetOutputFileName(InputFileName.Trim)
            If System.IO.File.Exists(txtOutputFileName.Text.Trim) = True Then
                MessageBox.Show("This File is Exists" & vbCr _
                              & Space(5) & "If you need to replace it, please Click upload again" & vbCr _
                              & Space(5) & "If you don't need to replace you can click save only" _
                              , "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        End If
    End Sub

    Private Sub btnGetOutputFileName_Click(sender As Object, e As EventArgs) Handles btnGetOutputFileName.Click
        Dim OutputFileName As String = ""
        OutputFileName = BrowseGetFile(txtOutputPathName.Text.Trim) 'OutputFilePathSoItm
        txtOutputFileName.Text = OutputFileName
        txtFileLocation.Text = OutputFileName
    End Sub
    Private Function BrowseGetFile(pDirectory As String) As String
        Dim RetFile As String = ""

        If txtSourceDocNumber.Text = "" Then
            MessageBox.Show("โปรด เลือก Doc No. ", "System Message!", MessageBoxButtons.OK, MessageBoxIcon.Stop, MessageBoxDefaultButton.Button1)
            Return RetFile
        End If

        Dim OpenFileDialog As New OpenFileDialog
        OpenFileDialog.InitialDirectory = pDirectory
        Select Case _SourceType
            Case SourceTypeDoc
                OpenFileDialog.Filter = "All files (*.*)|*.*" _
                                      & "|Microsoft 97-2003 (*.doc;*.xls;*.ppt)|*.doc;*.xls;*.ppt" _
                                      & "|Microsoft Office (*.docx;*.xlsx;*.pptx)|*.docx;*.xlsx;*.pptx" _
                                      & "|PDF Files (*.pdf)|*.pdf" _
                                      & "|Text files (*.txt;*.csv)|*.txt;*.csv"
            Case SourceTypePhoto
                OpenFileDialog.Filter = "All files (*.*)|*.*" _
                                      & "|Image Files (*.JPG;*.BMP;*.GIF;*.PNG)|*.JPG;*.BMP;*.GIF;*.PNG"
        End Select
        OpenFileDialog.Multiselect = False
        If OpenFileDialog.ShowDialog() = DialogResult.OK Then
            RetFile = OpenFileDialog.FileName.ToString
        Else
            RetFile = ""
        End If
        Return RetFile
    End Function
    Private Sub UploadDocFile(pFileName As String)
        Try
            My.Computer.FileSystem.CopyFile(txtInputFileName.Text.Trim _
                                              , pFileName _
                                              , Microsoft.VisualBasic.FileIO.UIOption.AllDialogs _
                                              , Microsoft.VisualBasic.FileIO.UICancelOption.DoNothing
                                                )
            MessageBox.Show("Upload Complete", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show("Upload Not Complete", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub
    Private Sub tsbtnUpload_Click(sender As Object, e As EventArgs) Handles tsbtnUpload.Click
        If txtOutputFileName.Text.Trim = "" Then
            MessageBox.Show("Please, select file to upload", "ข้อผิดพลาด", MessageBoxButtons.OK, MessageBoxIcon.Stop)
        Else
            UploadDocFile(txtOutputFileName.Text.Trim)
        End If
    End Sub
    Private Sub tsbtnView_Click(sender As Object, e As EventArgs) Handles tsbtnView.Click
        If txtOutputFileName.Text.Trim <> "" Then
            If System.IO.File.Exists(txtOutputFileName.Text.Trim) = True Then
                Process.Start(txtOutputFileName.Text.Trim)
            Else
                MsgBox("File Does Not Exist")
            End If
        End If
    End Sub
    Private Sub Loaddata(pSourceDocType As String, ByVal pSourceDocNumber As String)
        Dim objDB As New classPhoto

        dtDocAttachments = Nothing
        dtDocAttachments = objDB.getDocAttachment(pSourceDocType, pSourceDocNumber)
        Binddata(dtDocAttachments)
    End Sub
    Private Sub ChkPhysicalFile()
        OutputFileName = OutputFilePathSoItm & txtSourceDocNumber.Text.Trim
        If System.IO.File.Exists(OutputFileName) = True Then
            txtOutputFileName.Text = OutputFileName
        Else
            txtOutputFileName.Text = "*** File not found, Please Upload File first ***"
        End If
    End Sub
    Private Sub Binddata(ByVal pdtDocAttachments As DataTable)
        Dim config As New clsConfig

        With pdtDocAttachments
            If .Rows.Count > 0 Then
                'Data From DataBase
                DocAttachmentsId = .Rows(0)("Doc_Attachments_Id")
                OutputExtensionsName = .Rows(0)("file_type")
                txtFileLocation.Text = .Rows(0)("file_location").trim
                txtFileDescription.Text = .Rows(0)("File_Description")
                'Physical File
                txtInputFileName.Text = ""
                If System.IO.File.Exists(.Rows(0)("file_location").trim) = True Then
                    txtOutputFileName.Text = .Rows(0)("file_location")
                Else
                    txtOutputFileName.Text = "*** File not found, Please Upload File again ***"
                End If
            Else
                ChkPhysicalFile()
            End If
        End With
        'If dtPhoto.Rows.Count > 0 Then
        '    txtSourceDocType.Text = dtPhoto.Rows(0)("source_doc_number").ToString
        '    'CboPhotoNo.DataSource = dtPhoto
        '    'CboPhotoNo.DisplayMember = "row_number"
        '    'CboPhotoNo.ValueMember = "row_number"
        '    RowsNo = dtPhoto.Rows(0)("row_number")
        '    showPictureBox(dtPhoto.Rows(0)("file_type").ToString.Trim) 'Sitthana 05/06/2017

        '    'txtfile_location.Text = dtPhoto.Rows(0)("file_location").ToString
        '    'txtrow_number.Text = dtPhoto.Rows(0)("row_number")
        '    'txtCount.Text = dtdoc_attachments.Rows.Count
        '    'txtRemark.Text = dtPhoto.Rows(0)("file_description")
        'Else
        '    txtSourceDocType.Text = _SourceDocNumber
        '    'CboPhotoNo.DataSource = dtPhoto
        '    'CboPhotoNo.DisplayMember = "row_number"
        '    'CboPhotoNo.ValueMember = "row_number"
        '    RowsNo = 0
        '    'txtrow_number.Text = 0
        '    'txtCount.Text = 0
        '    'cbosource_doc_type.SelectedValue = _SourceDocType
        '    'txtfile_location.Text = ""
        '    PictureBox1.Image = Image.FromFile(clsConfig.ImagePath + "GK.bmp") '("\\srv-gemmaknits\MEDIA\PHOTO\MACHINE\GK.bmp")
        '    PictureBox1.Visible = False
        '    'AxWindowsMediaPlayer1.URL = clsConfig.ImagePath + "GK.bmp" '"\\srv-gemmaknits\MEDIA\PHOTO\MACHINE\GK.bmp"
        '    'AxWindowsMediaPlayer1.Visible = False
        'End If

    End Sub
    Private Sub tsbtnSave_Click(sender As System.Object, e As System.EventArgs) Handles tsbtnSave.Click
        If MessageBox.Show("Would you Like to save ?" _
                         , "System Message", MessageBoxButtons.YesNo _
                         , MessageBoxIcon.Question) = vbYes Then
            If System.IO.File.Exists(txtOutputFileName.Text.Trim) = False Then
                MessageBox.Show("Can not save because not found physial file" & vbCr _
                                & Space(5) & "Please Upload File again or " & vbCr _
                                & Space(5) & "If youe selected file done, Please" & vbCr _
                                & Space(10) & "1. Click button upload and then " & vbCr _
                                & Space(10) & "2. Click button save again" _
                                , "Error Message" _
                                , MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                If SaveOneRecData() Then
                    MessageBox.Show("Save Is Complete" & vbCr _
                                  & "(บันทึกสำเร็จ)" _
                                  , "System Message" _
                                  , MessageBoxButtons.OK, MessageBoxIcon.Information
                                   )
                    Loaddata(_SourceDocType, _SourceDocNumber)
                    _LoadDocComplete = True
                Else
                    MessageBox.Show("Save Is Not Complete" & vbCr _
                                  & "(บันทึกไม่สำเร็จ)" _
                                  , "System Message", MessageBoxButtons.OK, MessageBoxIcon.Error
                                    )
                    _LoadDocComplete = False
                End If
            End If
            _LoadDocComplete = True
        End If
    End Sub
    Private Function SaveOneRecData() As Boolean

        Dim config As New clsConfig
        Dim objdb As New classPhoto
        Dim PhotoHeader As New classPhoto.PhotoHeader

        With dtDocAttachments
            PhotoHeader.doc_attachments_id = DocAttachmentsId
            PhotoHeader.source_doc_type = _SourceDocType
            PhotoHeader.source_doc_number = _SourceDocNumber
            PhotoHeader.file_description = txtFileDescription.Text.Trim
            PhotoHeader.file_location = txtOutputFileName.Text.Trim
            PhotoHeader.file_type = getFileExtension(txtOutputFileName.Text.Trim)
        End With
        If objdb.SaveFile(PhotoHeader, clsuser) Then
            Return True
        Else
            Return False
        End If
    End Function


    Private Function SaveData() As Boolean
        Dim config As New clsConfig
        Dim objdb As New classPhoto
        Dim PhotoHeader As New classPhoto.PhotoHeader

        'Call Updatetextbox(txtRemark.Text, dtdoc_attachments)   'เอาข้อความที่พิมพ์ใน text box ไปใว้ใน descrition ของ  grid ทุก row

        Dim dtv_add As New DataView(dtDocAttachments, "", "", DataViewRowState.Added)
        Dim dtv_upd As New DataView(dtDocAttachments, "", "", DataViewRowState.ModifiedCurrent)
        Dim dtv_del As New DataView(dtDocAttachments, "", "", DataViewRowState.Deleted)

        'PhotoHeader.id = dtPhoto.Rows(RowsNo)("id")
        'PhotoHeader.docno = dtPhoto.Rows(RowsNo)("docno")
        'PhotoHeader.source_doc_type = _SourceDocType
        'PhotoHeader.filepath = dtPhoto.Rows(RowsNo)("filepath")
        'PhotoHeader.filename = dtPhoto.Rows(RowsNo)("filename")
        'PhotoHeader.filetype = dtPhoto.Rows(RowsNo)("filetype")
        'PhotoHeader.filetype = dt.Rows(RowsNo)("filetype")
        'PhotoHeader.remark = txtRemark.Text.Trim
        ' PhotoHeader.image = txtImage.Text.Trim

        PhotoHeader.Message = ""

        'Dim result As Windows.Forms.DialogResult
        'result = MessageBox.Show("Would you Like to save ?", "System Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button3)
        ' If result = Windows.Forms.DialogResult.No Then Exit Function

        If objdb.SavePhoto(PhotoHeader, dtDocAttachments, dtv_add, dtv_upd, dtv_del, clsuser) Then
            'MessageBox.Show("Save Is Complete! : บันทึกสำเร็จ! ", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
            Return True
        Else
            ' MessageBox.Show(PhotoHeader.Message, "System Message", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
            Return False
        End If
    End Function



    Private Sub GetBrowsFileName()
        If txtSourceDocNumber.Text = "" Then
            MessageBox.Show("โปรด เลือก Doc No. ", "System Message!", MessageBoxButtons.OK, MessageBoxIcon.Stop, MessageBoxDefaultButton.Button1)
            Exit Sub
        End If

        Dim OpenFileDialog As New OpenFileDialog

        Dim strFileName As String = txtSourceDocNumber.Text.Replace("/", "-")
        Dim strFileType As String = ".JPG"
        Dim strFilePath As String = "C:"

        OpenFileDialog.InitialDirectory = "C:"
        OpenFileDialog.Filter = "Image Files (*.JPG;*.BMP;*.GIF)|*.JPG;*.BMP;*.GIF|Video Files (*.AVI;*.MPG;*.MP4)|*.AVI;*.MPG;*.MP4|All files (*.*)|*.*"
        'OpenFileDialog.Filter = "Image Files (*.JPG;*.BMP;*.GIF)|*.JPG;*.BMP;*.GIF|Video Files (*.AVI;*.MPG;*.MP4)|*.AVI;*.MPG;*.MP4|All files (*.*)|*.*"
        OpenFileDialog.Multiselect = False

        If OpenFileDialog.ShowDialog() = DialogResult.OK Then
            SetOutputFileName(OpenFileDialog.FileName.ToString)
            strFileType = OpenFileDialog.FileName.ToString.Substring(OpenFileDialog.FileName.ToString.Length - 4, 4).ToUpper
            txtInputFileName.Text = OpenFileDialog.FileName.ToString.Trim
            If strFileType = ".JPG" Or strFileType = ".GIF" Or strFileType = ".PNG" Then
                'AxWindowsMediaPlayer1.Visible = False
                PictureBox1.Visible = True
                'PictureBox1.ImageLocation = txtfile_location.Text.Trim.ToString
            ElseIf strFileType = ".AVI" Or strFileType = ".MPG" Or strFileType = ".MP4" Then
                PictureBox1.Visible = False
                'AxWindowsMediaPlayer1.Visible = True
                'AxWindowsMediaPlayer1.URL = txtfile_location.Text.Trim.ToString
            Else
                PictureBox1.Visible = False
                'AxWindowsMediaPlayer1.Visible = False
            End If
        End If
    End Sub

    Private Sub txtDocno_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles txtSourceDocType.KeyDown
        If e.KeyCode = Keys.Enter Then
            Call Loaddata(_SourceDocType, _SourceDocNumber)
        End If
    End Sub



    Private Sub showPictureBox(FileType As String)
        If FileType = ".JPG" Or FileType = ".PNG" Or FileType = ".GIF" Then
            'AxWindowsMediaPlayer1.Visible = False
            PictureBox1.Visible = True
            'PictureBox1.Image = Image.FromFile(grddata.CurrentRow.Cells("file_location").Value)
        ElseIf FileType = ".AVI" Or FileType = ".MPG" Or FileType = ".MP4" Then
            PictureBox1.Visible = False
            'AxWindowsMediaPlayer1.Visible = True
            'AxWindowsMediaPlayer1.URL = grddata.CurrentRow.Cells("file_location").Value.ToString
            'AxWindowsMediaPlayer1.Ctlcontrols.play()
        ElseIf FileType = ".PDF" Then
            PictureBox1.Visible = False
            'AxWindowsMediaPlayer1.Visible = False
        End If
    End Sub
    Private Sub CheckFile_Type(ByVal StrFile_Type As String)

        If StrFile_Type = ".JPG" Or StrFile_Type = ".GIF" Or StrFile_Type = ".PNG" Then
            PictureBox1.Visible = True
            'PictureBox1.Image = Image.FromFile(grddata.CurrentRow.Cells("file_location").Value)
        ElseIf StrFile_Type = ".AVI" Or StrFile_Type = ".MPG" Or StrFile_Type = ".MP4" Then
            'AxWindowsMediaPlayer1.Visible = True
            'AxWindowsMediaPlayer1.URL = grddata.CurrentRow.Cells("file_location").Value.ToString
            'AxWindowsMediaPlayer1.Ctlcontrols.play()
        End If
    End Sub

    Private Sub InitControl()
        Dim obj As Control
        For Each obj In Me.Controls
            Call SetControlValue(obj)
        Next
        Call EnabledControl(True)
        Call SetErrorProvider()

        RowsNo = Nothing
    End Sub

    Private Sub SetErrorProvider()
        ErrorProvider1.Clear()
    End Sub

    Private Sub SetControlValue(ByVal Obj As Control)
        If TypeOf Obj Is TextBox Then
            Obj.Text = Obj.Tag

        End If
        If TypeOf Obj Is DateTimePicker Then
            Dim dtp As DateTimePicker = Obj
            dtp.Value = Now
            dtp.Checked = False
        End If
        If TypeOf Obj Is ComboBox Then
            Dim cbo As ComboBox = Obj
            cbo.SelectedIndex = -1
        End If
        If TypeOf Obj Is CheckBox Then
            Dim chk As CheckBox = Obj
            chk.Checked = False
            If chk.Name = "chkAutoCalculate" Then chk.Checked = True

        End If
        If TypeOf Obj Is TabControl Or TypeOf Obj Is TabPage Or TypeOf Obj Is GroupBox Then
            Dim obj2 As Control
            For Each obj2 In Obj.Controls
                Call SetControlValue(obj2)
            Next
        End If
    End Sub
    '===
    Private Sub SetControlEnabled(ByVal Obj As Control, ByVal blnEnabled As Boolean)
        If TypeOf Obj Is TextBox Then Obj.Enabled = blnEnabled
        If TypeOf Obj Is DateTimePicker Then Obj.Enabled = blnEnabled
        If TypeOf Obj Is ComboBox Then Obj.Enabled = blnEnabled
        If TypeOf Obj Is CheckBox Then Obj.Enabled = blnEnabled
        If TypeOf Obj Is PictureBox Then Obj.Enabled = blnEnabled

        If TypeOf Obj Is DataGridView Then
            Dim grd As DataGridView = Obj
            grd.ReadOnly = Not blnEnabled
        End If
        If TypeOf Obj Is TabControl Or TypeOf Obj Is TabPage Or TypeOf Obj Is GroupBox Then
            Dim obj2 As Control
            For Each obj2 In Obj.Controls
                Call SetControlEnabled(obj2, blnEnabled)
            Next
        End If
    End Sub
    Private Sub EnabledControl(ByVal blnEnabled As Boolean)
        Dim obj As Control
        For Each obj In Me.Controls
            Call SetControlEnabled(obj, blnEnabled)
        Next
    End Sub

    Private Sub txtDocno_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtSourceDocType.KeyPress

    End Sub

    Private Sub btnleft_Click(sender As System.Object, e As System.EventArgs)
        If RowsNo > 0 Then
            RowsNo = RowsNo - 1
            Loader(RowsNo)
        End If

        'If CboPhotoNo.SelectedValue > 1 Then
        '    CboPhotoNo.SelectedValue = CboPhotoNo.SelectedValue - 1
        'End If
    End Sub

    Private Sub btnright_Click(sender As System.Object, e As System.EventArgs)
        If RowsNo < dtDocAttachments.Rows.Count - 1 Then
            RowsNo = RowsNo + 1
            Loader(RowsNo)
        End If
        'If CboPhotoNo.SelectedValue < grddata.Rows.Count - 1 Then
        '    CboPhotoNo.SelectedValue = CboPhotoNo.SelectedValue + 1
        'End If
    End Sub

    Private Sub Loader(ByVal row_number As Nullable(Of Integer))
        'txtCount.Text = grddata.Rows.Count '- 1
        'txtrow_number.Text = grddata.CurrentRow.Cells("row_number").Value
        'txtfile_location.Text = grddata.CurrentRow.Cells("file_location").Value
        'PictureBox1.Image = Image.FromFile(grddata.CurrentRow.Cells("file_location").Value)
        'txtRemark.Text = grddata.CurrentRow.Cells("file_description").Value
        'txtdoc_attachments_id.Text = grddata.CurrentRow.Cells("doc_attachments_id").Value

        'txtCount.Text = dtdoc_attachments.Rows.Count
        'txtrow_number.Text = dtdoc_attachments.Rows(row_number)("row_number").ToString
        'txtfile_location.Text = dtdoc_attachments.Rows(row_number)("file_location")

        If dtDocAttachments.Rows(row_number)("file_type").ToString.Trim = ".JPG" Or dtDocAttachments.Rows(row_number)("file_type").ToString.Trim = ".GIF" Or dtDocAttachments.Rows(row_number)("file_type").ToString.Trim = ".PNG" Then
            'AxWindowsMediaPlayer1.Visible = False
            PictureBox1.Visible = True
            PictureBox1.Image = Image.FromFile(dtDocAttachments.Rows(row_number)("file_location").ToString)
        ElseIf dtDocAttachments.Rows(row_number)("file_type").ToString.Trim = ".AVI" Or dtDocAttachments.Rows(row_number)("file_type").ToString.Trim = ".MPG" Or dtDocAttachments.Rows(row_number)("file_type").ToString.Trim = ".MP4" Then
            PictureBox1.Visible = False
            'AxWindowsMediaPlayer1.Visible = True
            'AxWindowsMediaPlayer1.URL = dtdoc_attachments.Rows(row_number)("file_location").ToString
        End If

        'txtRemark.Text = dtdoc_attachments.Rows(row_number)("file_description")
        'txtdoc_attachments_id.Text = dtdoc_attachments.Rows(row_number)("doc_attachments_id")
    End Sub

    Private Sub btnImagePath_Click(sender As System.Object, e As System.EventArgs)
        If txtSourceDocType.Text = "" Then
            MessageBox.Show("โปรด เลือก Doc No. ", "System Message!", MessageBoxButtons.OK, MessageBoxIcon.Stop, MessageBoxDefaultButton.Button1)
            Exit Sub
        End If

        Dim OpenFileDialog As New OpenFileDialog

        Dim replace As String = txtSourceDocType.Text.Replace("/", "-")
        Dim strFileName As String = replace
        Dim strFileType As String = ".JPG"
        Dim strFilePath As String = "C:"

        OpenFileDialog.InitialDirectory = "C:"
        OpenFileDialog.Filter = "Image Files(*.JPG;*.BMP;*.GIF,*.AVI;*.MPG;*.MP4)|*.JPG;*.BMP;*.GIF;*.AVI;*.MPG;*.MP4|All files (*.*)|*.*"
        'OpenFileDialog.Filter = "Image Files (*.JPG;*.BMP;*.GIF)|*.JPG;*.BMP;*.GIF|Video Files (*.AVI;*.MPG;*.MP4)|*.AVI;*.MPG;*.MP4|All files (*.*)|*.*"
        OpenFileDialog.Multiselect = False

        If OpenFileDialog.ShowDialog() = DialogResult.OK Then
            'txtfile_location.Text = OpenFileDialog.FileName
            strFileType = OpenFileDialog.FileName.ToString.Substring(OpenFileDialog.FileName.ToString.Length - 4, 4).ToUpper

            If strFileType = ".JPG" Or strFileType = ".GIF" Or strFileType = ".PNG" Then
                'AxWindowsMediaPlayer1.Visible = False
                PictureBox1.Visible = True
                'PictureBox1.ImageLocation = txtfile_location.Text.Trim.ToString
            ElseIf strFileType = ".AVI" Or strFileType = ".MPG" Or strFileType = ".MP4" Then
                PictureBox1.Visible = False
                'AxWindowsMediaPlayer1.Visible = True
                'AxWindowsMediaPlayer1.URL = txtfile_location.Text.Trim.ToString
            Else
                PictureBox1.Visible = False
                'AxWindowsMediaPlayer1.Visible = False
            End If
        End If
    End Sub



    Private Sub btnUpload_Click(sender As System.Object, e As System.EventArgs)
        Call UploadFile()
    End Sub

    Private Sub UploadFile()
        Dim thisDate As Date = Now

        thisDate.ToString("yyyyMMdd-HHmmss")

        Dim OpenFileDialog As New OpenFileDialog
        Dim NewDesignNoreplace As String = txtSourceDocType.Text.Replace("/", "-")
        Dim strFileName As String = NewDesignNoreplace & "-" & thisDate.ToString("yyyyMMdd-HHmmss")

        'Dim strFileType As String = txtfile_location.Text.Trim.Substring(txtfile_location.Text.Trim.ToString.Length - 4, 4)
        Dim strFilePath As String = clsuser.ImagePath '"\\srv-gemmaknits\media\PHOTO\MACHINE\"

        'OpenFileDialog.FileName = txtfile_location.Text.Trim

        Try
            'If OpenFileDialog.FileName <> "" Then 'Add By Neung
            '    My.Computer.FileSystem.CopyFile(
            '    OpenFileDialog.FileName,
            '    strFilePath & strFileName & strFileType,
            '   Microsoft.VisualBasic.FileIO.UIOption.AllDialogs,
            '    Microsoft.VisualBasic.FileIO.UICancelOption.ThrowException)
            'End If

            'txtfile_location.Text = strFilePath & strFileName & strFileType
            'showPictureBox(strFileType) 'Sitthana 05/06/2078

            'If strFileType = ".JPG" Or strFileType = ".GIF" Or strFileType = ".PNG" Then
            '    AxWindowsMediaPlayer1.Visible = False
            '    PictureBox1.Visible = True
            '    PictureBox1.Image = Image.FromFile(txtfile_location.Text.Trim.ToString)
            'ElseIf strFileType = ".AVI" Or strFileType = ".MPG" Or strFileType = ".MP4" Then
            '    PictureBox1.Visible = False
            '    AxWindowsMediaPlayer1.Visible = True
            '    AxWindowsMediaPlayer1.URL = txtfile_location.Text.Trim.ToString
            'ElseIf strFileType = ".PDF" Then

            'End If

            MessageBox.Show("Upload สำเร็จ", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)

            'Call AddNewPhoto(0, cbosource_doc_type.SelectedValue, _SourceDocNumber, txtRemark.Text, txtfile_location.Text.Trim, strFileType)
            Call SaveData()
            Call Loaddata(_SourceDocType, _SourceDocNumber)

        Catch ex As Exception
            MessageBox.Show("Upload ไม่สำเร็จ", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
        End Try
    End Sub

    Private Sub AddNewPhoto(ByVal doc_attachments_id As Nullable(Of Long), ByVal source_doc_type As String, ByVal source_doc_number As String, ByVal file_description As String, ByVal file_location As String, ByVal file_type As String)
        Dim config As New clsConfig
        If txtSourceDocType.Text = "" Then Exit Sub

        If doc_attachments_id = 0 Then
            Dim dr As DataRow
            Dim msg As String = ""
            Dim i As Integer = 0

            Dim j As Integer = 0
            dr = dtDocAttachments.NewRow
            For j = 0 To dtDocAttachments.Columns.Count - 1
                dr("doc_attachments_id") = doc_attachments_id
                dr("source_doc_type") = source_doc_type
                dr("source_doc_number") = source_doc_number
                dr("file_description") = file_description
                dr("file_location") = file_location
                dr("file_type") = file_type
            Next
            dtDocAttachments.Rows.Add(dr)
        End If

        Call GenCboPhotoNo(dtDocAttachments)

    End Sub

    Private Sub GenCboPhotoNo(ByVal dtdoc_attachments As DataTable)
        'CboPhotoNo.DataSource = dtdoc_attachments
        'CboPhotoNo.ValueMember = "row_number"
        'CboPhotoNo.DisplayMember = "row_number"
        'CboPhotoNo.DisplayMember = "row_number"
        'CboPhotoNo.ValueMember = "row_number"
    End Sub

    Private Sub PictureBox1_DoubleClick(sender As Object, e As System.EventArgs) Handles PictureBox1.DoubleClick
        Dim frm As New frmViewImage
        'frm.Pfile_location = txtfile_location.Text.Trim
        'frm.PFile_type = grddata.CurrentRow.Cells("file_type").Value.ToString.Trim
        'frm.UserInfo = clsuser
        'frm.Psource_doc_number = txtDesignNo.Text.Trim
        'frm.Psource_doc_type = "DESIGN_NO"
        frm.ShowDialog()
    End Sub

    Private Sub cboitemsnature_SelectedIndexChanged(sender As System.Object, e As System.EventArgs)
        Dim frm As New frmViewImage

    End Sub

    Private Sub CboPhotoNo_DropDownClosed(sender As Object, e As System.EventArgs)
        Dim config As New clsConfig
        'If config.IsNull(CboPhotoNo.SelectedValue, 0) = 0 Then Exit Sub
        'Dim row_number As Integer = CboPhotoNo.SelectedValue - 1
        'Call Loader(row_number)
    End Sub

    Private Sub CboPhotoNo_SelectedIndexChanged(sender As System.Object, e As System.EventArgs)
        Dim config As New clsConfig
        'If config.IsNull(CboPhotoNo.SelectedValue, 0) = 0 Then Exit Sub

        'Dim row_number As Integer = CboPhotoNo.SelectedValue - 1 'grddata.CurrentRow.Cells("row_number").Value
        'Call Loader(row_number)
    End Sub

    Private Function Updatetextbox(ByVal file_description As String, ByRef dt As DataTable) As Boolean
        If dt.Rows.Count > 0 Then
            Dim i As Integer = 0
            For i = 0 To dt.Rows.Count - 1
                'MsgBox(dt.Rows(i).RowState.ToString)  '-> When debug RowState = Unchanged
                'If dt.Rows(i).RowState <> DataRowState.Deleted Then
                '    If grddata.CurrentRow.Cells("file_description").Value <> file_description Then
                '        grddata.CurrentRow.Cells("file_description").Value = file_description
                '    End If
                'End If
            Next
        End If
        Return False
    End Function

    Private Sub grddata_CellClick(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs)
        'Dim config As New clsConfig
        'If config.IsNull(grddata.CurrentRow.Cells("file_description").Value, "") = "" Then Exit Sub
        'txtRemark.Text = grddata.CurrentRow.Cells("file_description").Value
        'txtrow_number.Text = grddata.CurrentRow.Cells("row_number").Value
        'txtdoc_attachments_id.Text = grddata.CurrentRow.Cells("doc_attachments_id").Value
        'txtCount.Text = dtdoc_attachments.Rows.Count
        'txtfile_location.Text = grddata.CurrentRow.Cells("file_location").Value
        'PictureBox1.Image = Image.FromFile(grddata.CurrentRow.Cells("file_location").Value)
        'With grddata
        '    showPictureBox(.Rows(.CurrentRow.Index).Cells("file_type").Value.ToString.Trim)
        'End With
    End Sub

    Private Sub grddata_CellContentClick(sender As System.Object, e As DataGridViewCellEventArgs)

        Dim senderGrid = DirectCast(sender, DataGridView)

        'If TypeOf senderGrid.Columns(e.ColumnIndex) Is DataGridViewButtonColumn AndAlso
        If TypeOf senderGrid.Columns(e.ColumnIndex) Is DataGridViewButtonColumn _
        AndAlso senderGrid.Columns(e.ColumnIndex) Is senderGrid.Columns("btnView") _
        AndAlso e.RowIndex >= 0 Then
            '===================================== Funtion Copy =======================================
            'Dim saveFileDialog1 As New SaveFileDialog()

            'saveFileDialog1.Filter = "Image Files(*.JPG;*.BMP;*.GIF,*.AVI;*.MPG;*.MP4;*.PDF)|*.JPG;*.BMP;*.GIF;*.AVI;*.MPG;*.MP4;*.PDF|All files (*.*)|*.*"

            'saveFileDialog1.Title = "Save an Image File"
            'saveFileDialog1.ShowDialog()

            'If saveFileDialog1.FileName <> "" Then
            '    My.Computer.FileSystem.CopyFile(
            '    grddata.CurrentRow.Cells("file_location").Value.ToString,
            '    saveFileDialog1.FileName,
            '   Microsoft.VisualBasic.FileIO.UIOption.AllDialogs,
            '    Microsoft.VisualBasic.FileIO.UICancelOption.ThrowException)
            'End If
            '================================ END Function ==============================================

            Dim OpenFileDlg As New OpenFileDialog

            'OpenFileDlg.FileName = grddata.CurrentRow.Cells("file_location").Value.ToString
            Dim result? As Boolean

            For Each path In OpenFileDlg.FileNames
                Try
                    System.Diagnostics.Process.Start(path)

                Catch ex As Exception
                    MsgBox("Unable to load the file. Maybe it was deleted?")
                End Try
                If result = True Then
                    ' Open document
                Else
                    Exit Sub
                End If
            Next
        End If


        If TypeOf senderGrid.Columns(e.ColumnIndex) Is DataGridViewButtonColumn _
        AndAlso senderGrid.Columns(e.ColumnIndex) Is senderGrid.Columns("btnDownLoad") _
        AndAlso e.RowIndex >= 0 Then
            '===================================== Funtion Copy =======================================
            Dim saveFileDialog1 As New SaveFileDialog()

            saveFileDialog1.Filter = "Image Files(*.JPG;*.BMP;*.GIF,*.AVI;*.MPG;*.MP4;*.PDF)|*.JPG;*.BMP;*.GIF;*.AVI;*.MPG;*.MP4;*.PDF|All files (*.*)|*.*"

            saveFileDialog1.Title = "Save an Image File"
            saveFileDialog1.ShowDialog()

            'If saveFileDialog1.FileName <> "" Then
            '    My.Computer.FileSystem.CopyFile(
            '    grddata.CurrentRow.Cells("file_location").Value.ToString,
            '    saveFileDialog1.FileName,
            '   Microsoft.VisualBasic.FileIO.UIOption.AllDialogs,
            '    Microsoft.VisualBasic.FileIO.UICancelOption.ThrowException)
            'End If
            '================================ END Function ==============================================

            Dim OpenFileDlg As New OpenFileDialog

            OpenFileDlg.FileName = saveFileDialog1.FileName
            Dim result? As Boolean

            For Each path In OpenFileDlg.FileNames
                Try
                    System.Diagnostics.Process.Start(path)

                Catch ex As Exception
                    MsgBox("Unable to load the file. Maybe it was deleted?")
                End Try
                If result = True Then
                    ' Open document
                Else
                    Exit Sub
                End If
            Next
        End If
    End Sub

    Private Sub txtDesc_KeyPress(sender As Object, e As KeyPressEventArgs)
        'Sitthana 05/06/2018
        If e.KeyChar = vbCr Then
            'Dim ai As Integer = 0
            'With grddata
            '    If .Rows.Count > 0 Then
            '        RowsNo = .CurrentRow.Index + 1
            '        For i = RowsNo To .Rows.Count - 1
            '            If InStr(.Rows(i).Cells("file_description").Value.trim.ToUpper, txtDesc.Text.Trim.ToUpper) Then
            '                .CurrentCell = .Rows(i).Cells("file_description")
            '                Exit Sub
            '            End If
            '        Next
            '    End If
            'End With
        End If
    End Sub
End Class