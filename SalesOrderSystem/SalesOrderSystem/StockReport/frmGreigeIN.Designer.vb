<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGreigeIN
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmGreigeIN))
        Me.Label27 = New System.Windows.Forms.Label()
        Me.ddlKO = New System.Windows.Forms.ComboBox()
        Me.dtpDateFr = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dtpDateTo = New System.Windows.Forms.DateTimePicker()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.btnPrint = New System.Windows.Forms.ToolStripButton()
        Me.btnMinimized = New System.Windows.Forms.ToolStripButton()
        Me.btnExit = New System.Windows.Forms.ToolStripButton()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.optKO = New System.Windows.Forms.RadioButton()
        Me.optMachine = New System.Windows.Forms.RadioButton()
        Me.optDate = New System.Windows.Forms.RadioButton()
        Me.CboMcNo = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtCustName = New System.Windows.Forms.TextBox()
        Me.btnSelectCustomer = New System.Windows.Forms.Button()
        Me.txtCustCd = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ToolStrip1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Location = New System.Drawing.Point(26, 26)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(47, 13)
        Me.Label27.TabIndex = 189
        Me.Label27.Text = "K/O No."
        '
        'ddlKO
        '
        Me.ddlKO.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ddlKO.Enabled = False
        Me.ddlKO.FormattingEnabled = True
        Me.ddlKO.Location = New System.Drawing.Point(117, 23)
        Me.ddlKO.Name = "ddlKO"
        Me.ddlKO.Size = New System.Drawing.Size(104, 21)
        Me.ddlKO.TabIndex = 0
        '
        'dtpDateFr
        '
        Me.dtpDateFr.CustomFormat = "dd/MM/yyyy"
        Me.dtpDateFr.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpDateFr.Location = New System.Drawing.Point(117, 79)
        Me.dtpDateFr.Name = "dtpDateFr"
        Me.dtpDateFr.Size = New System.Drawing.Size(97, 20)
        Me.dtpDateFr.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(238, 83)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(46, 13)
        Me.Label1.TabIndex = 194
        Me.Label1.Text = "To Date"
        '
        'dtpDateTo
        '
        Me.dtpDateTo.CustomFormat = "dd/MM/yyyy"
        Me.dtpDateTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpDateTo.Location = New System.Drawing.Point(289, 81)
        Me.dtpDateTo.Name = "dtpDateTo"
        Me.dtpDateTo.Size = New System.Drawing.Size(97, 20)
        Me.dtpDateTo.TabIndex = 2
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnPrint, Me.btnMinimized, Me.btnExit})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(436, 25)
        Me.ToolStrip1.TabIndex = 6
        '
        'btnPrint
        '
        Me.btnPrint.Image = CType(resources.GetObject("btnPrint.Image"), System.Drawing.Image)
        Me.btnPrint.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(52, 22)
        Me.btnPrint.Text = "&Print"
        '
        'btnMinimized
        '
        Me.btnMinimized.Image = CType(resources.GetObject("btnMinimized.Image"), System.Drawing.Image)
        Me.btnMinimized.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnMinimized.Name = "btnMinimized"
        Me.btnMinimized.Size = New System.Drawing.Size(83, 22)
        Me.btnMinimized.Text = "Minimized"
        '
        'btnExit
        '
        Me.btnExit.Image = CType(resources.GetObject("btnExit.Image"), System.Drawing.Image)
        Me.btnExit.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(45, 22)
        Me.btnExit.Text = "E&xit"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(26, 83)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 13)
        Me.Label2.TabIndex = 191
        Me.Label2.Text = "From Date"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.optKO)
        Me.GroupBox1.Controls.Add(Me.optMachine)
        Me.GroupBox1.Controls.Add(Me.optDate)
        Me.GroupBox1.Location = New System.Drawing.Point(14, 195)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(407, 48)
        Me.GroupBox1.TabIndex = 195
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Group By"
        '
        'optKO
        '
        Me.optKO.AutoSize = True
        Me.optKO.Location = New System.Drawing.Point(311, 20)
        Me.optKO.Name = "optKO"
        Me.optKO.Size = New System.Drawing.Size(45, 17)
        Me.optKO.TabIndex = 5
        Me.optKO.Text = "K/O"
        Me.optKO.UseVisualStyleBackColor = True
        '
        'optMachine
        '
        Me.optMachine.AutoSize = True
        Me.optMachine.Location = New System.Drawing.Point(170, 20)
        Me.optMachine.Name = "optMachine"
        Me.optMachine.Size = New System.Drawing.Size(66, 17)
        Me.optMachine.TabIndex = 4
        Me.optMachine.Text = "Machine"
        Me.optMachine.UseVisualStyleBackColor = True
        '
        'optDate
        '
        Me.optDate.AutoSize = True
        Me.optDate.Checked = True
        Me.optDate.Location = New System.Drawing.Point(34, 20)
        Me.optDate.Name = "optDate"
        Me.optDate.Size = New System.Drawing.Size(48, 17)
        Me.optDate.TabIndex = 3
        Me.optDate.TabStop = True
        Me.optDate.Text = "Date"
        Me.optDate.UseVisualStyleBackColor = True
        '
        'CboMcNo
        '
        Me.CboMcNo.FormattingEnabled = True
        Me.CboMcNo.Location = New System.Drawing.Point(117, 51)
        Me.CboMcNo.Name = "CboMcNo"
        Me.CboMcNo.Size = New System.Drawing.Size(104, 21)
        Me.CboMcNo.TabIndex = 196
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(26, 54)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(48, 13)
        Me.Label3.TabIndex = 197
        Me.Label3.Text = "M/C No."
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtCustName)
        Me.GroupBox2.Controls.Add(Me.btnSelectCustomer)
        Me.GroupBox2.Controls.Add(Me.txtCustCd)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.dtpDateFr)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.CboMcNo)
        Me.GroupBox2.Controls.Add(Me.dtpDateTo)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.Label27)
        Me.GroupBox2.Controls.Add(Me.ddlKO)
        Me.GroupBox2.Location = New System.Drawing.Point(14, 28)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(407, 163)
        Me.GroupBox2.TabIndex = 198
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Conditions"
        '
        'txtCustName
        '
        Me.txtCustName.Location = New System.Drawing.Point(117, 129)
        Me.txtCustName.Name = "txtCustName"
        Me.txtCustName.ReadOnly = True
        Me.txtCustName.Size = New System.Drawing.Size(269, 20)
        Me.txtCustName.TabIndex = 201
        '
        'btnSelectCustomer
        '
        Me.btnSelectCustomer.Image = Global.SalesOrderSystem.My.Resources.Resources.Search_16x1
        Me.btnSelectCustomer.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnSelectCustomer.Location = New System.Drawing.Point(175, 105)
        Me.btnSelectCustomer.Name = "btnSelectCustomer"
        Me.btnSelectCustomer.Size = New System.Drawing.Size(24, 22)
        Me.btnSelectCustomer.TabIndex = 200
        Me.btnSelectCustomer.UseVisualStyleBackColor = True
        '
        'txtCustCd
        '
        Me.txtCustCd.Location = New System.Drawing.Point(117, 106)
        Me.txtCustCd.Name = "txtCustCd"
        Me.txtCustCd.ReadOnly = True
        Me.txtCustCd.Size = New System.Drawing.Size(51, 20)
        Me.txtCustCd.TabIndex = 199
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(26, 109)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(51, 13)
        Me.Label4.TabIndex = 198
        Me.Label4.Text = "Customer"
        '
        'frmGreigeIN
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(436, 255)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmGreigeIN"
        Me.Text = "Greige IN"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents ddlKO As System.Windows.Forms.ComboBox
    Friend WithEvents dtpDateFr As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dtpDateTo As System.Windows.Forms.DateTimePicker
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents btnPrint As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnMinimized As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnExit As System.Windows.Forms.ToolStripButton
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents optKO As System.Windows.Forms.RadioButton
    Friend WithEvents optMachine As System.Windows.Forms.RadioButton
    Friend WithEvents optDate As System.Windows.Forms.RadioButton
    Friend WithEvents CboMcNo As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents txtCustName As TextBox
    Friend WithEvents btnSelectCustomer As Button
    Friend WithEvents txtCustCd As TextBox
    Friend WithEvents Label4 As Label
End Class
