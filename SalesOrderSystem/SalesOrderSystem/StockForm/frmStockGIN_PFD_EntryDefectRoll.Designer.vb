<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmStockGIN_PFD_EntryDefectRoll
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtRollNo = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtGINNo = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtDefectDetails = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnGetDefectCode = New System.Windows.Forms.Button()
        Me.txtLengthStart = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.txtDefectRemark = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtDefectName = New System.Windows.Forms.TextBox()
        Me.txtLengthDefect = New System.Windows.Forms.TextBox()
        Me.txtDefectCode = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnOk = New System.Windows.Forms.Button()
        Me.txtStockCode = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtRollNo)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txtGINNo)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 6)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(205, 84)
        Me.GroupBox1.TabIndex = 286
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "G-IN Document"
        '
        'txtRollNo
        '
        Me.txtRollNo.Location = New System.Drawing.Point(84, 48)
        Me.txtRollNo.Name = "txtRollNo"
        Me.txtRollNo.ReadOnly = True
        Me.txtRollNo.Size = New System.Drawing.Size(96, 20)
        Me.txtRollNo.TabIndex = 271
        Me.txtRollNo.TabStop = False
        Me.txtRollNo.Tag = ""
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(26, 51)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(42, 13)
        Me.Label4.TabIndex = 270
        Me.Label4.Text = "Roll No"
        '
        'txtGINNo
        '
        Me.txtGINNo.Location = New System.Drawing.Point(84, 24)
        Me.txtGINNo.Name = "txtGINNo"
        Me.txtGINNo.ReadOnly = True
        Me.txtGINNo.Size = New System.Drawing.Size(96, 20)
        Me.txtGINNo.TabIndex = 268
        Me.txtGINNo.TabStop = False
        Me.txtGINNo.Tag = ""
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(26, 27)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(46, 13)
        Me.Label3.TabIndex = 267
        Me.Label3.Text = "GIN No."
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtDefectDetails)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.btnGetDefectCode)
        Me.GroupBox2.Controls.Add(Me.txtLengthStart)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.Label21)
        Me.GroupBox2.Controls.Add(Me.txtDefectRemark)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.txtDefectName)
        Me.GroupBox2.Controls.Add(Me.txtLengthDefect)
        Me.GroupBox2.Controls.Add(Me.txtDefectCode)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 93)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(698, 188)
        Me.GroupBox2.TabIndex = 287
        Me.GroupBox2.TabStop = False
        '
        'txtDefectDetails
        '
        Me.txtDefectDetails.Location = New System.Drawing.Point(132, 40)
        Me.txtDefectDetails.Name = "txtDefectDetails"
        Me.txtDefectDetails.Size = New System.Drawing.Size(48, 20)
        Me.txtDefectDetails.TabIndex = 285
        Me.txtDefectDetails.TabStop = False
        Me.txtDefectDetails.Tag = ""
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(26, 43)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(58, 13)
        Me.Label2.TabIndex = 284
        Me.Label2.Text = "Defect Qty"
        '
        'btnGetDefectCode
        '
        Me.btnGetDefectCode.Location = New System.Drawing.Point(231, 16)
        Me.btnGetDefectCode.Name = "btnGetDefectCode"
        Me.btnGetDefectCode.Size = New System.Drawing.Size(23, 21)
        Me.btnGetDefectCode.TabIndex = 283
        Me.btnGetDefectCode.Text = "..."
        Me.btnGetDefectCode.UseVisualStyleBackColor = True
        '
        'txtLengthStart
        '
        Me.txtLengthStart.Location = New System.Drawing.Point(132, 63)
        Me.txtLengthStart.Name = "txtLengthStart"
        Me.txtLengthStart.Size = New System.Drawing.Size(48, 20)
        Me.txtLengthStart.TabIndex = 280
        Me.txtLengthStart.TabStop = False
        Me.txtLengthStart.Tag = ""
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(26, 66)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(39, 13)
        Me.Label8.TabIndex = 279
        Me.Label8.Text = "เมตรที่"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(211, 89)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(25, 13)
        Me.Label21.TabIndex = 278
        Me.Label21.Text = "Cm."
        '
        'txtDefectRemark
        '
        Me.txtDefectRemark.Location = New System.Drawing.Point(132, 110)
        Me.txtDefectRemark.Multiline = True
        Me.txtDefectRemark.Name = "txtDefectRemark"
        Me.txtDefectRemark.Size = New System.Drawing.Size(545, 67)
        Me.txtDefectRemark.TabIndex = 275
        Me.txtDefectRemark.TabStop = False
        Me.txtDefectRemark.Tag = ""
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(26, 113)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(79, 13)
        Me.Label7.TabIndex = 274
        Me.Label7.Text = "Defect Remark"
        '
        'txtDefectName
        '
        Me.txtDefectName.Location = New System.Drawing.Point(261, 17)
        Me.txtDefectName.Multiline = True
        Me.txtDefectName.Name = "txtDefectName"
        Me.txtDefectName.ReadOnly = True
        Me.txtDefectName.Size = New System.Drawing.Size(416, 20)
        Me.txtDefectName.TabIndex = 275
        Me.txtDefectName.TabStop = False
        Me.txtDefectName.Tag = ""
        '
        'txtLengthDefect
        '
        Me.txtLengthDefect.Location = New System.Drawing.Point(132, 86)
        Me.txtLengthDefect.Name = "txtLengthDefect"
        Me.txtLengthDefect.Size = New System.Drawing.Size(73, 20)
        Me.txtLengthDefect.TabIndex = 275
        Me.txtLengthDefect.TabStop = False
        Me.txtLengthDefect.Tag = ""
        '
        'txtDefectCode
        '
        Me.txtDefectCode.Location = New System.Drawing.Point(132, 17)
        Me.txtDefectCode.Name = "txtDefectCode"
        Me.txtDefectCode.Size = New System.Drawing.Size(96, 20)
        Me.txtDefectCode.TabIndex = 275
        Me.txtDefectCode.TabStop = False
        Me.txtDefectCode.Tag = ""
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(26, 89)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(75, 13)
        Me.Label6.TabIndex = 274
        Me.Label6.Text = "Defect Length"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(26, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 13)
        Me.Label1.TabIndex = 274
        Me.Label1.Text = "Defect"
        '
        'btnCancel
        '
        Me.btnCancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCancel.Location = New System.Drawing.Point(631, 296)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(82, 23)
        Me.btnCancel.TabIndex = 289
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnOk
        '
        Me.btnOk.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnOk.Location = New System.Drawing.Point(543, 296)
        Me.btnOk.Name = "btnOk"
        Me.btnOk.Size = New System.Drawing.Size(82, 23)
        Me.btnOk.TabIndex = 288
        Me.btnOk.Text = "OK"
        Me.btnOk.UseVisualStyleBackColor = True
        '
        'txtStockCode
        '
        Me.txtStockCode.Location = New System.Drawing.Point(659, 12)
        Me.txtStockCode.Name = "txtStockCode"
        Me.txtStockCode.ReadOnly = True
        Me.txtStockCode.Size = New System.Drawing.Size(51, 20)
        Me.txtStockCode.TabIndex = 291
        Me.txtStockCode.TabStop = False
        Me.txtStockCode.Tag = ""
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(618, 15)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(35, 13)
        Me.Label10.TabIndex = 290
        Me.Label10.Text = "Stock"
        '
        'frmStockGIN_PFD_EntryDefectRoll
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(725, 331)
        Me.Controls.Add(Me.txtStockCode)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnOk)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmStockGIN_PFD_EntryDefectRoll"
        Me.Text = "Entry Defect Roll"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtRollNo As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtGINNo As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents txtDefectCode As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtDefectName As TextBox
    Friend WithEvents txtLengthDefect As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents txtDefectRemark As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtLengthStart As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents btnCancel As Button
    Friend WithEvents btnOk As Button
    Friend WithEvents txtStockCode As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents btnGetDefectCode As Button
    Friend WithEvents txtDefectDetails As TextBox
    Friend WithEvents Label2 As Label
End Class
