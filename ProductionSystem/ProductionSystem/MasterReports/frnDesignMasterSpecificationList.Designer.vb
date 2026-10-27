<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frnDesignMasterSpecificationList
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frnDesignMasterSpecificationList))
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.btnPrint = New System.Windows.Forms.ToolStripButton()
        Me.btnMinimized = New System.Windows.Forms.ToolStripButton()
        Me.btnExit = New System.Windows.Forms.ToolStripButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.rbSpecStatusNotCreated = New System.Windows.Forms.RadioButton()
        Me.rbSpecStatusCreated = New System.Windows.Forms.RadioButton()
        Me.rbSpecStatusApproved = New System.Windows.Forms.RadioButton()
        Me.rbSpecStatusDraft = New System.Windows.Forms.RadioButton()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.rbObsulete = New System.Windows.Forms.RadioButton()
        Me.rbCancel = New System.Windows.Forms.RadioButton()
        Me.ToolStrip1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnPrint, Me.btnMinimized, Me.btnExit})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(385, 25)
        Me.ToolStrip1.TabIndex = 201
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
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rbCancel)
        Me.GroupBox1.Controls.Add(Me.rbObsulete)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.rbSpecStatusNotCreated)
        Me.GroupBox1.Controls.Add(Me.rbSpecStatusCreated)
        Me.GroupBox1.Controls.Add(Me.rbSpecStatusApproved)
        Me.GroupBox1.Controls.Add(Me.rbSpecStatusDraft)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 28)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(361, 200)
        Me.GroupBox1.TabIndex = 202
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Condition"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(141, 32)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(10, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = ":"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(28, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(101, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Specification Status"
        '
        'rbSpecStatusNotCreated
        '
        Me.rbSpecStatusNotCreated.AutoSize = True
        Me.rbSpecStatusNotCreated.Location = New System.Drawing.Point(157, 158)
        Me.rbSpecStatusNotCreated.Name = "rbSpecStatusNotCreated"
        Me.rbSpecStatusNotCreated.Size = New System.Drawing.Size(108, 17)
        Me.rbSpecStatusNotCreated.TabIndex = 3
        Me.rbSpecStatusNotCreated.Text = "No  (Not Created)"
        Me.rbSpecStatusNotCreated.UseVisualStyleBackColor = True
        '
        'rbSpecStatusCreated
        '
        Me.rbSpecStatusCreated.AutoSize = True
        Me.rbSpecStatusCreated.Location = New System.Drawing.Point(157, 135)
        Me.rbSpecStatusCreated.Name = "rbSpecStatusCreated"
        Me.rbSpecStatusCreated.Size = New System.Drawing.Size(89, 17)
        Me.rbSpecStatusCreated.TabIndex = 2
        Me.rbSpecStatusCreated.Text = "Yes (Created)"
        Me.rbSpecStatusCreated.UseVisualStyleBackColor = True
        '
        'rbSpecStatusApproved
        '
        Me.rbSpecStatusApproved.AutoSize = True
        Me.rbSpecStatusApproved.Checked = True
        Me.rbSpecStatusApproved.Location = New System.Drawing.Point(157, 53)
        Me.rbSpecStatusApproved.Name = "rbSpecStatusApproved"
        Me.rbSpecStatusApproved.Size = New System.Drawing.Size(71, 17)
        Me.rbSpecStatusApproved.TabIndex = 1
        Me.rbSpecStatusApproved.TabStop = True
        Me.rbSpecStatusApproved.Text = "Approved"
        Me.rbSpecStatusApproved.UseVisualStyleBackColor = True
        '
        'rbSpecStatusDraft
        '
        Me.rbSpecStatusDraft.AutoSize = True
        Me.rbSpecStatusDraft.Location = New System.Drawing.Point(157, 30)
        Me.rbSpecStatusDraft.Name = "rbSpecStatusDraft"
        Me.rbSpecStatusDraft.Size = New System.Drawing.Size(48, 17)
        Me.rbSpecStatusDraft.TabIndex = 0
        Me.rbSpecStatusDraft.Text = "Draft"
        Me.rbSpecStatusDraft.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(28, 135)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(108, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Specification Created"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(141, 135)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(10, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = ":"
        '
        'rbObsulete
        '
        Me.rbObsulete.AutoSize = True
        Me.rbObsulete.Location = New System.Drawing.Point(157, 76)
        Me.rbObsulete.Name = "rbObsulete"
        Me.rbObsulete.Size = New System.Drawing.Size(67, 17)
        Me.rbObsulete.TabIndex = 8
        Me.rbObsulete.Text = "Obsulete"
        Me.rbObsulete.UseVisualStyleBackColor = True
        '
        'rbCancel
        '
        Me.rbCancel.AutoSize = True
        Me.rbCancel.Location = New System.Drawing.Point(157, 99)
        Me.rbCancel.Name = "rbCancel"
        Me.rbCancel.Size = New System.Drawing.Size(58, 17)
        Me.rbCancel.TabIndex = 9
        Me.rbCancel.Text = "Cancel"
        Me.rbCancel.UseVisualStyleBackColor = True
        '
        'frnDesignMasterSpecificationList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(385, 240)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Name = "frnDesignMasterSpecificationList"
        Me.Text = "Design Master Specificatoin List"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents btnPrint As ToolStripButton
    Friend WithEvents btnMinimized As ToolStripButton
    Friend WithEvents btnExit As ToolStripButton
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents rbSpecStatusNotCreated As RadioButton
    Friend WithEvents rbSpecStatusCreated As RadioButton
    Friend WithEvents rbSpecStatusApproved As RadioButton
    Friend WithEvents rbSpecStatusDraft As RadioButton
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents rbCancel As RadioButton
    Friend WithEvents rbObsulete As RadioButton
End Class
