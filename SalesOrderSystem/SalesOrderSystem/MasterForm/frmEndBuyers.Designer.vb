<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEndBuyers
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmEndBuyers))
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.cboEndBuyers = New System.Windows.Forms.ToolStripComboBox()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnNew = New System.Windows.Forms.ToolStripButton()
        Me.btnSave = New System.Windows.Forms.ToolStripButton()
        Me.btnExit = New System.Windows.Forms.ToolStripButton()
        Me.txtendbuyername = New System.Windows.Forms.TextBox()
        Me.lblendbuyername = New System.Windows.Forms.Label()
        Me.lblendbuyercd = New System.Windows.Forms.Label()
        Me.txtendbuyercd = New System.Windows.Forms.TextBox()
        Me.lblendbuyerid = New System.Windows.Forms.Label()
        Me.txtendbuyerid = New System.Windows.Forms.TextBox()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel1, Me.cboEndBuyers, Me.ToolStripSeparator1, Me.btnNew, Me.btnSave, Me.btnExit})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(490, 25)
        Me.ToolStrip1.TabIndex = 18
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(65, 22)
        Me.ToolStripLabel1.Text = "End Buyers"
        '
        'cboEndBuyers
        '
        Me.cboEndBuyers.DropDownWidth = 150
        Me.cboEndBuyers.Name = "cboEndBuyers"
        Me.cboEndBuyers.Size = New System.Drawing.Size(200, 25)
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'btnNew
        '
        Me.btnNew.Image = CType(resources.GetObject("btnNew.Image"), System.Drawing.Image)
        Me.btnNew.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnNew.Name = "btnNew"
        Me.btnNew.Size = New System.Drawing.Size(51, 22)
        Me.btnNew.Text = "New"
        '
        'btnSave
        '
        Me.btnSave.Image = CType(resources.GetObject("btnSave.Image"), System.Drawing.Image)
        Me.btnSave.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(51, 22)
        Me.btnSave.Text = "Save"
        '
        'btnExit
        '
        Me.btnExit.Image = CType(resources.GetObject("btnExit.Image"), System.Drawing.Image)
        Me.btnExit.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(45, 22)
        Me.btnExit.Text = "Exit"
        '
        'txtendbuyername
        '
        Me.txtendbuyername.Location = New System.Drawing.Point(12, 98)
        Me.txtendbuyername.MaxLength = 50
        Me.txtendbuyername.Name = "txtendbuyername"
        Me.txtendbuyername.Size = New System.Drawing.Size(343, 22)
        Me.txtendbuyername.TabIndex = 2
        '
        'lblendbuyername
        '
        Me.lblendbuyername.AutoSize = True
        Me.lblendbuyername.Location = New System.Drawing.Point(9, 82)
        Me.lblendbuyername.Name = "lblendbuyername"
        Me.lblendbuyername.Size = New System.Drawing.Size(65, 13)
        Me.lblendbuyername.TabIndex = 20
        Me.lblendbuyername.Text = "Name (Eng)"
        '
        'lblendbuyercd
        '
        Me.lblendbuyercd.AutoSize = True
        Me.lblendbuyercd.Location = New System.Drawing.Point(12, 39)
        Me.lblendbuyercd.Name = "lblendbuyercd"
        Me.lblendbuyercd.Size = New System.Drawing.Size(34, 13)
        Me.lblendbuyercd.TabIndex = 21
        Me.lblendbuyercd.Text = "Code"
        '
        'txtendbuyercd
        '
        Me.txtendbuyercd.Location = New System.Drawing.Point(12, 59)
        Me.txtendbuyercd.MaxLength = 10
        Me.txtendbuyercd.Name = "txtendbuyercd"
        Me.txtendbuyercd.Size = New System.Drawing.Size(123, 22)
        Me.txtendbuyercd.TabIndex = 1
        '
        'lblendbuyerid
        '
        Me.lblendbuyerid.AutoSize = True
        Me.lblendbuyerid.Location = New System.Drawing.Point(145, 39)
        Me.lblendbuyerid.Name = "lblendbuyerid"
        Me.lblendbuyerid.Size = New System.Drawing.Size(18, 13)
        Me.lblendbuyerid.TabIndex = 1
        Me.lblendbuyerid.Text = "ID"
        '
        'txtendbuyerid
        '
        Me.txtendbuyerid.Location = New System.Drawing.Point(148, 59)
        Me.txtendbuyerid.Name = "txtendbuyerid"
        Me.txtendbuyerid.ReadOnly = True
        Me.txtendbuyerid.Size = New System.Drawing.Size(67, 22)
        Me.txtendbuyerid.TabIndex = 0
        '
        'frmEndBuyers
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(490, 145)
        Me.Controls.Add(Me.lblendbuyerid)
        Me.Controls.Add(Me.txtendbuyerid)
        Me.Controls.Add(Me.txtendbuyercd)
        Me.Controls.Add(Me.lblendbuyercd)
        Me.Controls.Add(Me.lblendbuyername)
        Me.Controls.Add(Me.txtendbuyername)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "frmEndBuyers"
        Me.Text = "End Buyers"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripLabel1 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents txtendbuyername As System.Windows.Forms.TextBox
    Friend WithEvents lblendbuyername As System.Windows.Forms.Label
    Friend WithEvents lblendbuyercd As System.Windows.Forms.Label
    Friend WithEvents txtendbuyercd As System.Windows.Forms.TextBox
    Friend WithEvents cboEndBuyers As System.Windows.Forms.ToolStripComboBox
    Friend WithEvents lblendbuyerid As System.Windows.Forms.Label
    Friend WithEvents txtendbuyerid As System.Windows.Forms.TextBox
    Friend WithEvents btnNew As ToolStripButton
    Friend WithEvents btnSave As ToolStripButton
    Friend WithEvents btnExit As ToolStripButton
End Class
