<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPrintPO
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
        Me.buttonSearchPO = New System.Windows.Forms.Button()
        Me.txtPurNo = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.btnMinimized = New System.Windows.Forms.ToolStripButton()
        Me.btnExit = New System.Windows.Forms.ToolStripButton()
        Me.tsbPrint = New System.Windows.Forms.ToolStripSplitButton()
        Me.tsbPrintPO = New System.Windows.Forms.ToolStripMenuItem()
        Me.A4ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ENToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'buttonSearchPO
        '
        Me.buttonSearchPO.Image = Global.PurchaseOrderSystem.My.Resources.Resources.Search_16x
        Me.buttonSearchPO.Location = New System.Drawing.Point(223, 35)
        Me.buttonSearchPO.Name = "buttonSearchPO"
        Me.buttonSearchPO.Size = New System.Drawing.Size(34, 29)
        Me.buttonSearchPO.TabIndex = 154
        Me.buttonSearchPO.UseVisualStyleBackColor = True
        '
        'txtPurNo
        '
        Me.txtPurNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPurNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtPurNo.Location = New System.Drawing.Point(65, 36)
        Me.txtPurNo.Name = "txtPurNo"
        Me.txtPurNo.Size = New System.Drawing.Size(154, 22)
        Me.txtPurNo.TabIndex = 152
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 38)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(47, 13)
        Me.Label1.TabIndex = 153
        Me.Label1.Text = "P/O No."
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbPrint, Me.btnMinimized, Me.btnExit})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(279, 25)
        Me.ToolStrip1.TabIndex = 155
        '
        'btnMinimized
        '
        Me.btnMinimized.Image = Global.PurchaseOrderSystem.My.Resources.Resources.Minimize_16x
        Me.btnMinimized.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnMinimized.Name = "btnMinimized"
        Me.btnMinimized.Size = New System.Drawing.Size(83, 22)
        Me.btnMinimized.Text = "Minimized"
        '
        'btnExit
        '
        Me.btnExit.Image = Global.PurchaseOrderSystem.My.Resources.Resources.Exit_16x
        Me.btnExit.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(45, 22)
        Me.btnExit.Text = "E&xit"
        '
        'tsbPrint
        '
        Me.tsbPrint.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbPrintPO})
        Me.tsbPrint.Image = Global.PurchaseOrderSystem.My.Resources.Resources.Print_16x
        Me.tsbPrint.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbPrint.Name = "tsbPrint"
        Me.tsbPrint.Size = New System.Drawing.Size(64, 22)
        Me.tsbPrint.Text = "Print"
        '
        'tsbPrintPO
        '
        Me.tsbPrintPO.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.A4ToolStripMenuItem, Me.ENToolStripMenuItem})
        Me.tsbPrintPO.Name = "tsbPrintPO"
        Me.tsbPrintPO.Size = New System.Drawing.Size(152, 22)
        Me.tsbPrintPO.Text = "Print P/O"
        '
        'A4ToolStripMenuItem
        '
        Me.A4ToolStripMenuItem.Name = "A4ToolStripMenuItem"
        Me.A4ToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.A4ToolStripMenuItem.Text = "TH"
        '
        'ENToolStripMenuItem
        '
        Me.ENToolStripMenuItem.Name = "ENToolStripMenuItem"
        Me.ENToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ENToolStripMenuItem.Text = "EN"
        '
        'frmPrintPO
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(279, 84)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.buttonSearchPO)
        Me.Controls.Add(Me.txtPurNo)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmPrintPO"
        Me.Text = "Print P/O"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents buttonSearchPO As Button
    Friend WithEvents txtPurNo As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents btnMinimized As ToolStripButton
    Friend WithEvents btnExit As ToolStripButton
    Friend WithEvents tsbPrint As ToolStripSplitButton
    Friend WithEvents tsbPrintPO As ToolStripMenuItem
    Friend WithEvents A4ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ENToolStripMenuItem As ToolStripMenuItem
End Class
