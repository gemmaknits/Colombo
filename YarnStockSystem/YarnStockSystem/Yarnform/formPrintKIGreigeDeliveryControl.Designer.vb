<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formPrintKIGreigeDeliveryControl
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(formPrintKIGreigeDeliveryControl))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dtpToDate = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dtpFromDate = New System.Windows.Forms.DateTimePicker()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.checkAllDate = New System.Windows.Forms.CheckBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.checkClosedDelivery = New System.Windows.Forms.CheckBox()
        Me.checkClosedProduction = New System.Windows.Forms.CheckBox()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnPrint = New System.Windows.Forms.ToolStripButton()
        Me.btnMinimized = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton()
        Me.btnSearchKI = New System.Windows.Forms.Button()
        Me.textKono = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.chkShowMissingLSOnly = New System.Windows.Forms.CheckBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(11, 42)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(36, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "From:"
        '
        'dtpToDate
        '
        Me.dtpToDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpToDate.Location = New System.Drawing.Point(59, 62)
        Me.dtpToDate.Name = "dtpToDate"
        Me.dtpToDate.Size = New System.Drawing.Size(95, 22)
        Me.dtpToDate.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(11, 62)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(22, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "To:"
        '
        'dtpFromDate
        '
        Me.dtpFromDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFromDate.Location = New System.Drawing.Point(59, 36)
        Me.dtpFromDate.Name = "dtpFromDate"
        Me.dtpFromDate.Size = New System.Drawing.Size(95, 22)
        Me.dtpFromDate.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.checkAllDate)
        Me.GroupBox1.Controls.Add(Me.dtpFromDate)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.dtpToDate)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 87)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(254, 88)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "K/I date"
        '
        'checkAllDate
        '
        Me.checkAllDate.AutoSize = True
        Me.checkAllDate.Location = New System.Drawing.Point(59, 13)
        Me.checkAllDate.Name = "checkAllDate"
        Me.checkAllDate.Size = New System.Drawing.Size(39, 17)
        Me.checkAllDate.TabIndex = 6
        Me.checkAllDate.Text = "All"
        Me.checkAllDate.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.chkShowMissingLSOnly)
        Me.GroupBox2.Controls.Add(Me.checkClosedDelivery)
        Me.GroupBox2.Controls.Add(Me.checkClosedProduction)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 181)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(254, 92)
        Me.GroupBox2.TabIndex = 5
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Include"
        '
        'checkClosedDelivery
        '
        Me.checkClosedDelivery.AutoSize = True
        Me.checkClosedDelivery.Location = New System.Drawing.Point(16, 42)
        Me.checkClosedDelivery.Name = "checkClosedDelivery"
        Me.checkClosedDelivery.Size = New System.Drawing.Size(155, 17)
        Me.checkClosedDelivery.TabIndex = 8
        Me.checkClosedDelivery.Text = "K/I is closed after delivery"
        Me.checkClosedDelivery.UseVisualStyleBackColor = True
        '
        'checkClosedProduction
        '
        Me.checkClosedProduction.AutoSize = True
        Me.checkClosedProduction.Location = New System.Drawing.Point(16, 19)
        Me.checkClosedProduction.Name = "checkClosedProduction"
        Me.checkClosedProduction.Size = New System.Drawing.Size(174, 17)
        Me.checkClosedProduction.TabIndex = 7
        Me.checkClosedProduction.Text = "K/I is closed after production"
        Me.checkClosedProduction.UseVisualStyleBackColor = True
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripSeparator1, Me.btnPrint, Me.btnMinimized, Me.ToolStripButton2})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(374, 25)
        Me.ToolStrip1.TabIndex = 15
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'btnPrint
        '
        Me.btnPrint.Image = CType(resources.GetObject("btnPrint.Image"), System.Drawing.Image)
        Me.btnPrint.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(52, 22)
        Me.btnPrint.Text = "Print"
        '
        'btnMinimized
        '
        Me.btnMinimized.Image = CType(resources.GetObject("btnMinimized.Image"), System.Drawing.Image)
        Me.btnMinimized.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnMinimized.Name = "btnMinimized"
        Me.btnMinimized.Size = New System.Drawing.Size(83, 22)
        Me.btnMinimized.Text = "Minimized"
        '
        'ToolStripButton2
        '
        Me.ToolStripButton2.Image = CType(resources.GetObject("ToolStripButton2.Image"), System.Drawing.Image)
        Me.ToolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton2.Name = "ToolStripButton2"
        Me.ToolStripButton2.Size = New System.Drawing.Size(45, 22)
        Me.ToolStripButton2.Text = "Exit"
        '
        'btnSearchKI
        '
        Me.btnSearchKI.Image = CType(resources.GetObject("btnSearchKI.Image"), System.Drawing.Image)
        Me.btnSearchKI.Location = New System.Drawing.Point(230, 44)
        Me.btnSearchKI.Name = "btnSearchKI"
        Me.btnSearchKI.Size = New System.Drawing.Size(22, 23)
        Me.btnSearchKI.TabIndex = 160
        Me.btnSearchKI.UseVisualStyleBackColor = True
        '
        'textKono
        '
        Me.textKono.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.textKono.Location = New System.Drawing.Point(113, 45)
        Me.textKono.Name = "textKono"
        Me.textKono.Size = New System.Drawing.Size(111, 22)
        Me.textKono.TabIndex = 159
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(19, 50)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(103, 13)
        Me.Label15.TabIndex = 161
        Me.Label15.Text = "Knitting order No.:"
        '
        'chkShowMissingLSOnly
        '
        Me.chkShowMissingLSOnly.AutoSize = True
        Me.chkShowMissingLSOnly.Location = New System.Drawing.Point(16, 65)
        Me.chkShowMissingLSOnly.Name = "chkShowMissingLSOnly"
        Me.chkShowMissingLSOnly.Size = New System.Drawing.Size(201, 17)
        Me.chkShowMissingLSOnly.TabIndex = 162
        Me.chkShowMissingLSOnly.Text = "Show only pending LS from GMK3"
        Me.chkShowMissingLSOnly.UseVisualStyleBackColor = True
        '
        'formPrintKIGreigeDeliveryControl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(374, 290)
        Me.Controls.Add(Me.btnSearchKI)
        Me.Controls.Add(Me.textKono)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "formPrintKIGreigeDeliveryControl"
        Me.Text = "Print K/I Delivery Control report"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dtpToDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents dtpFromDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents checkClosedDelivery As System.Windows.Forms.CheckBox
    Friend WithEvents checkClosedProduction As System.Windows.Forms.CheckBox
    Friend WithEvents checkAllDate As System.Windows.Forms.CheckBox
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnPrint As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnMinimized As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton2 As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnSearchKI As System.Windows.Forms.Button
    Friend WithEvents textKono As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents chkShowMissingLSOnly As CheckBox
End Class
