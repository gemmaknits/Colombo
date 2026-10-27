<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmInvoiceExportDetailReport
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmInvoiceExportDetailReport))
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.btnPrint = New System.Windows.Forms.ToolStripButton()
        Me.btnMinimized = New System.Windows.Forms.ToolStripButton()
        Me.btnExit = New System.Windows.Forms.ToolStripButton()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dtpDateTo = New System.Windows.Forms.DateTimePicker()
        Me.dtpDateFr = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtInvTo = New System.Windows.Forms.TextBox()
        Me.txtInvFrom = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.StatusStrip = New System.Windows.Forms.StatusStrip()
        Me.tsslUser = New System.Windows.Forms.ToolStripStatusLabel()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.rdbtnFile = New System.Windows.Forms.RadioButton()
        Me.rdbtnScreen = New System.Windows.Forms.RadioButton()
        Me.grpOutputFile = New System.Windows.Forms.GroupBox()
        Me.txtFileName = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.btnGetDirectoryName = New System.Windows.Forms.Button()
        Me.txtPathName = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.ToolStrip1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.StatusStrip.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.grpOutputFile.SuspendLayout()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnPrint, Me.btnMinimized, Me.btnExit})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(489, 25)
        Me.ToolStrip1.TabIndex = 22
        '
        'btnPrint
        '
        Me.btnPrint.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnPrint.Image = CType(resources.GetObject("btnPrint.Image"), System.Drawing.Image)
        Me.btnPrint.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(23, 22)
        Me.btnPrint.Text = "&Print"
        '
        'btnMinimized
        '
        Me.btnMinimized.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnMinimized.Image = CType(resources.GetObject("btnMinimized.Image"), System.Drawing.Image)
        Me.btnMinimized.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnMinimized.Name = "btnMinimized"
        Me.btnMinimized.Size = New System.Drawing.Size(23, 22)
        Me.btnMinimized.Text = "Minimized"
        '
        'btnExit
        '
        Me.btnExit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnExit.Image = CType(resources.GetObject("btnExit.Image"), System.Drawing.Image)
        Me.btnExit.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(23, 22)
        Me.btnExit.Text = "E&xit"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(305, 56)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(20, 13)
        Me.Label3.TabIndex = 26
        Me.Label3.Text = "To"
        '
        'dtpDateTo
        '
        Me.dtpDateTo.CustomFormat = "dd/MM/yyyy"
        Me.dtpDateTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpDateTo.Location = New System.Drawing.Point(329, 52)
        Me.dtpDateTo.Name = "dtpDateTo"
        Me.dtpDateTo.ShowCheckBox = True
        Me.dtpDateTo.Size = New System.Drawing.Size(103, 20)
        Me.dtpDateTo.TabIndex = 25
        '
        'dtpDateFr
        '
        Me.dtpDateFr.CustomFormat = "dd/MM/yyyy"
        Me.dtpDateFr.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpDateFr.Location = New System.Drawing.Point(181, 52)
        Me.dtpDateFr.Name = "dtpDateFr"
        Me.dtpDateFr.ShowCheckBox = True
        Me.dtpDateFr.Size = New System.Drawing.Size(106, 20)
        Me.dtpDateFr.TabIndex = 24
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(31, 26)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(59, 13)
        Me.Label2.TabIndex = 23
        Me.Label2.Text = "Invoice No"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txtInvTo)
        Me.GroupBox1.Controls.Add(Me.txtInvFrom)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.dtpDateTo)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.dtpDateFr)
        Me.GroupBox1.Location = New System.Drawing.Point(15, 31)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(462, 89)
        Me.GroupBox1.TabIndex = 27
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Condition"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(145, 56)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(30, 13)
        Me.Label6.TabIndex = 32
        Me.Label6.Text = "From"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(145, 26)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(30, 13)
        Me.Label5.TabIndex = 31
        Me.Label5.Text = "From"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(305, 26)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(20, 13)
        Me.Label4.TabIndex = 30
        Me.Label4.Text = "To"
        '
        'txtInvTo
        '
        Me.txtInvTo.Location = New System.Drawing.Point(329, 23)
        Me.txtInvTo.Name = "txtInvTo"
        Me.txtInvTo.Size = New System.Drawing.Size(88, 20)
        Me.txtInvTo.TabIndex = 29
        '
        'txtInvFrom
        '
        Me.txtInvFrom.Location = New System.Drawing.Point(181, 23)
        Me.txtInvFrom.Name = "txtInvFrom"
        Me.txtInvFrom.Size = New System.Drawing.Size(88, 20)
        Me.txtInvFrom.TabIndex = 28
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(31, 56)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(68, 13)
        Me.Label1.TabIndex = 27
        Me.Label1.Text = "Invoice Data"
        '
        'StatusStrip
        '
        Me.StatusStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsslUser})
        Me.StatusStrip.Location = New System.Drawing.Point(0, 232)
        Me.StatusStrip.Name = "StatusStrip"
        Me.StatusStrip.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.StatusStrip.Size = New System.Drawing.Size(489, 22)
        Me.StatusStrip.TabIndex = 28
        Me.StatusStrip.Text = "StatusStrip1"
        '
        'tsslUser
        '
        Me.tsslUser.Name = "tsslUser"
        Me.tsslUser.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.tsslUser.RightToLeftAutoMirrorImage = True
        Me.tsslUser.Size = New System.Drawing.Size(30, 17)
        Me.tsslUser.Text = "User"
        Me.tsslUser.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.rdbtnFile)
        Me.GroupBox2.Controls.Add(Me.rdbtnScreen)
        Me.GroupBox2.Location = New System.Drawing.Point(15, 122)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(99, 94)
        Me.GroupBox2.TabIndex = 29
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Output Type"
        '
        'rdbtnFile
        '
        Me.rdbtnFile.AutoSize = True
        Me.rdbtnFile.Checked = True
        Me.rdbtnFile.Location = New System.Drawing.Point(22, 53)
        Me.rdbtnFile.Name = "rdbtnFile"
        Me.rdbtnFile.Size = New System.Drawing.Size(41, 17)
        Me.rdbtnFile.TabIndex = 1
        Me.rdbtnFile.TabStop = True
        Me.rdbtnFile.Text = "File"
        Me.rdbtnFile.UseVisualStyleBackColor = True
        '
        'rdbtnScreen
        '
        Me.rdbtnScreen.AutoSize = True
        Me.rdbtnScreen.Location = New System.Drawing.Point(22, 30)
        Me.rdbtnScreen.Name = "rdbtnScreen"
        Me.rdbtnScreen.Size = New System.Drawing.Size(59, 17)
        Me.rdbtnScreen.TabIndex = 0
        Me.rdbtnScreen.Text = "Screen"
        Me.rdbtnScreen.UseVisualStyleBackColor = True
        '
        'grpOutputFile
        '
        Me.grpOutputFile.Controls.Add(Me.txtFileName)
        Me.grpOutputFile.Controls.Add(Me.Label8)
        Me.grpOutputFile.Controls.Add(Me.btnGetDirectoryName)
        Me.grpOutputFile.Controls.Add(Me.txtPathName)
        Me.grpOutputFile.Controls.Add(Me.Label7)
        Me.grpOutputFile.Controls.Add(Me.RadioButton2)
        Me.grpOutputFile.Controls.Add(Me.RadioButton1)
        Me.grpOutputFile.Location = New System.Drawing.Point(120, 122)
        Me.grpOutputFile.Name = "grpOutputFile"
        Me.grpOutputFile.Size = New System.Drawing.Size(357, 95)
        Me.grpOutputFile.TabIndex = 30
        Me.grpOutputFile.TabStop = False
        Me.grpOutputFile.Text = "Output File"
        '
        'txtFileName
        '
        Me.txtFileName.Location = New System.Drawing.Point(93, 63)
        Me.txtFileName.Name = "txtFileName"
        Me.txtFileName.Size = New System.Drawing.Size(208, 20)
        Me.txtFileName.TabIndex = 32
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(27, 66)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(54, 13)
        Me.Label8.TabIndex = 31
        Me.Label8.Text = "File Name"
        '
        'btnGetDirectoryName
        '
        Me.btnGetDirectoryName.Location = New System.Drawing.Point(305, 38)
        Me.btnGetDirectoryName.Name = "btnGetDirectoryName"
        Me.btnGetDirectoryName.Size = New System.Drawing.Size(36, 21)
        Me.btnGetDirectoryName.TabIndex = 30
        Me.btnGetDirectoryName.Text = "Get"
        Me.btnGetDirectoryName.UseVisualStyleBackColor = True
        '
        'txtPathName
        '
        Me.txtPathName.Location = New System.Drawing.Point(93, 40)
        Me.txtPathName.Name = "txtPathName"
        Me.txtPathName.Size = New System.Drawing.Size(208, 20)
        Me.txtPathName.TabIndex = 29
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(27, 43)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(60, 13)
        Me.Label7.TabIndex = 24
        Me.Label7.Text = "Path Name"
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Location = New System.Drawing.Point(123, 18)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(60, 17)
        Me.RadioButton2.TabIndex = 2
        Me.RadioButton2.Text = "Pdf File"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Checked = True
        Me.RadioButton1.Location = New System.Drawing.Point(29, 19)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(70, 17)
        Me.RadioButton1.TabIndex = 1
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "Excel File"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'frmInvoiceExportDetailReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(489, 254)
        Me.Controls.Add(Me.grpOutputFile)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.StatusStrip)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmInvoiceExportDetailReport"
        Me.Text = "Invoice Export Detail Report"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.StatusStrip.ResumeLayout(False)
        Me.StatusStrip.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.grpOutputFile.ResumeLayout(False)
        Me.grpOutputFile.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents btnPrint As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnMinimized As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnExit As System.Windows.Forms.ToolStripButton
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents dtpDateTo As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpDateFr As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents StatusStrip As StatusStrip
    Friend WithEvents tsslUser As ToolStripStatusLabel
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtInvTo As TextBox
    Friend WithEvents txtInvFrom As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents rdbtnFile As RadioButton
    Friend WithEvents rdbtnScreen As RadioButton
    Friend WithEvents grpOutputFile As GroupBox
    Friend WithEvents txtFileName As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents btnGetDirectoryName As Button
    Friend WithEvents txtPathName As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents SaveFileDialog1 As SaveFileDialog
End Class
