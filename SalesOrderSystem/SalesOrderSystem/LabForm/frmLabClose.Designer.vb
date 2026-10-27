<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLabClose
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLabClose))
		Me.ToolStrip1 = New System.Windows.Forms.ToolStrip
		Me.btnSave = New System.Windows.Forms.ToolStripButton
		Me.btnExit = New System.Windows.Forms.ToolStripButton
		Me.Label1 = New System.Windows.Forms.Label
		Me.dtpReceiveDate = New System.Windows.Forms.DateTimePicker
		Me.dtpCommentDate = New System.Windows.Forms.DateTimePicker
		Me.Label2 = New System.Windows.Forms.Label
		Me.Label3 = New System.Windows.Forms.Label
		Me.txtComment = New System.Windows.Forms.TextBox
		Me.chkApprove = New System.Windows.Forms.CheckBox
		Me.chkReject = New System.Windows.Forms.CheckBox
		Me.GroupBox1 = New System.Windows.Forms.GroupBox
		Me.chkClosed = New System.Windows.Forms.CheckBox
		Me.txtShade = New System.Windows.Forms.TextBox
		Me.Label4 = New System.Windows.Forms.Label
		Me.ToolStrip1.SuspendLayout()
		Me.GroupBox1.SuspendLayout()
		Me.SuspendLayout()
		'
		'ToolStrip1
		'
		Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnSave, Me.btnExit})
		Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
		Me.ToolStrip1.Name = "ToolStrip1"
		Me.ToolStrip1.Size = New System.Drawing.Size(345, 25)
		Me.ToolStrip1.TabIndex = 138
		'
		'btnSave
		'
		Me.btnSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
		Me.btnSave.Image = CType(resources.GetObject("btnSave.Image"), System.Drawing.Image)
		Me.btnSave.ImageTransparentColor = System.Drawing.Color.Magenta
		Me.btnSave.Name = "btnSave"
		Me.btnSave.Size = New System.Drawing.Size(23, 22)
		Me.btnSave.Text = "Save"
		'
		'btnExit
		'
		Me.btnExit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
		Me.btnExit.Image = CType(resources.GetObject("btnExit.Image"), System.Drawing.Image)
		Me.btnExit.ImageTransparentColor = System.Drawing.Color.Magenta
		Me.btnExit.Name = "btnExit"
		Me.btnExit.Size = New System.Drawing.Size(23, 22)
		Me.btnExit.Text = "Exit"
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.Location = New System.Drawing.Point(8, 32)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(94, 13)
		Me.Label1.TabIndex = 139
		Me.Label1.Text = "Lab Receive Date"
		'
		'dtpReceiveDate
		'
		Me.dtpReceiveDate.CustomFormat = "dd/MM/yyyy"
		Me.dtpReceiveDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
		Me.dtpReceiveDate.Location = New System.Drawing.Point(144, 32)
		Me.dtpReceiveDate.Name = "dtpReceiveDate"
		Me.dtpReceiveDate.Size = New System.Drawing.Size(88, 20)
		Me.dtpReceiveDate.TabIndex = 140
		'
		'dtpCommentDate
		'
		Me.dtpCommentDate.CustomFormat = "dd/MM/yyyy"
		Me.dtpCommentDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
		Me.dtpCommentDate.Location = New System.Drawing.Point(144, 56)
		Me.dtpCommentDate.Name = "dtpCommentDate"
		Me.dtpCommentDate.Size = New System.Drawing.Size(88, 20)
		Me.dtpCommentDate.TabIndex = 142
		'
		'Label2
		'
		Me.Label2.AutoSize = True
		Me.Label2.Location = New System.Drawing.Point(8, 56)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(124, 13)
		Me.Label2.TabIndex = 141
		Me.Label2.Text = "Customer Comment Date"
		'
		'Label3
		'
		Me.Label3.AutoSize = True
		Me.Label3.Location = New System.Drawing.Point(8, 80)
		Me.Label3.Name = "Label3"
		Me.Label3.Size = New System.Drawing.Size(98, 13)
		Me.Label3.TabIndex = 143
		Me.Label3.Text = "Customer Comment"
		'
		'txtComment
		'
		Me.txtComment.Location = New System.Drawing.Point(144, 80)
		Me.txtComment.Name = "txtComment"
		Me.txtComment.Size = New System.Drawing.Size(192, 20)
		Me.txtComment.TabIndex = 195
		Me.txtComment.Tag = ""
		'
		'chkApprove
		'
		Me.chkApprove.AutoSize = True
		Me.chkApprove.Location = New System.Drawing.Point(16, 24)
		Me.chkApprove.Name = "chkApprove"
		Me.chkApprove.Size = New System.Drawing.Size(66, 17)
		Me.chkApprove.TabIndex = 196
		Me.chkApprove.Text = "Approve"
		Me.chkApprove.UseVisualStyleBackColor = True
		'
		'chkReject
		'
		Me.chkReject.AutoSize = True
		Me.chkReject.Location = New System.Drawing.Point(120, 24)
		Me.chkReject.Name = "chkReject"
		Me.chkReject.Size = New System.Drawing.Size(57, 17)
		Me.chkReject.TabIndex = 197
		Me.chkReject.Text = "Reject"
		Me.chkReject.UseVisualStyleBackColor = True
		'
		'GroupBox1
		'
		Me.GroupBox1.Controls.Add(Me.chkReject)
		Me.GroupBox1.Controls.Add(Me.chkApprove)
		Me.GroupBox1.Location = New System.Drawing.Point(8, 128)
		Me.GroupBox1.Name = "GroupBox1"
		Me.GroupBox1.Size = New System.Drawing.Size(224, 56)
		Me.GroupBox1.TabIndex = 198
		Me.GroupBox1.TabStop = False
		Me.GroupBox1.Text = "Result From Customer"
		'
		'chkClosed
		'
		Me.chkClosed.AutoSize = True
		Me.chkClosed.Location = New System.Drawing.Point(240, 152)
		Me.chkClosed.Name = "chkClosed"
		Me.chkClosed.Size = New System.Drawing.Size(98, 17)
		Me.chkClosed.TabIndex = 198
		Me.chkClosed.Text = "Closed Lab Dip"
		Me.chkClosed.UseVisualStyleBackColor = True
		'
		'txtShade
		'
		Me.txtShade.Location = New System.Drawing.Point(144, 104)
		Me.txtShade.Name = "txtShade"
		Me.txtShade.Size = New System.Drawing.Size(88, 20)
		Me.txtShade.TabIndex = 200
		Me.txtShade.Tag = ""
		'
		'Label4
		'
		Me.Label4.AutoSize = True
		Me.Label4.Location = New System.Drawing.Point(8, 104)
		Me.Label4.Name = "Label4"
		Me.Label4.Size = New System.Drawing.Size(104, 13)
		Me.Label4.TabIndex = 199
		Me.Label4.Text = "Shade OK (A,B,C,...)"
		'
		'frmLabClose
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(345, 193)
		Me.Controls.Add(Me.txtShade)
		Me.Controls.Add(Me.Label4)
		Me.Controls.Add(Me.chkClosed)
		Me.Controls.Add(Me.GroupBox1)
		Me.Controls.Add(Me.txtComment)
		Me.Controls.Add(Me.Label3)
		Me.Controls.Add(Me.dtpCommentDate)
		Me.Controls.Add(Me.Label2)
		Me.Controls.Add(Me.dtpReceiveDate)
		Me.Controls.Add(Me.Label1)
		Me.Controls.Add(Me.ToolStrip1)
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
		Me.MaximizeBox = False
		Me.MinimizeBox = False
		Me.Name = "frmLabClose"
		Me.Text = "Close Lab Dip"
		Me.ToolStrip1.ResumeLayout(False)
		Me.ToolStrip1.PerformLayout()
		Me.GroupBox1.ResumeLayout(False)
		Me.GroupBox1.PerformLayout()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub
	Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
	Friend WithEvents btnSave As System.Windows.Forms.ToolStripButton
	Friend WithEvents btnExit As System.Windows.Forms.ToolStripButton
	Friend WithEvents Label1 As System.Windows.Forms.Label
	Friend WithEvents dtpReceiveDate As System.Windows.Forms.DateTimePicker
	Friend WithEvents dtpCommentDate As System.Windows.Forms.DateTimePicker
	Friend WithEvents Label2 As System.Windows.Forms.Label
	Friend WithEvents Label3 As System.Windows.Forms.Label
	Friend WithEvents txtComment As System.Windows.Forms.TextBox
	Friend WithEvents chkApprove As System.Windows.Forms.CheckBox
	Friend WithEvents chkReject As System.Windows.Forms.CheckBox
	Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
	Friend WithEvents chkClosed As System.Windows.Forms.CheckBox
	Friend WithEvents txtShade As System.Windows.Forms.TextBox
	Friend WithEvents Label4 As System.Windows.Forms.Label
End Class
