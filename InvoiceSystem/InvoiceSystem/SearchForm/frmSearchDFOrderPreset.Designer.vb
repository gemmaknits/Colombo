<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSearchDFOrderPreset
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSearchDFOrderPreset))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.btnMinimized = New System.Windows.Forms.ToolStripButton()
        Me.btnRefresh2 = New System.Windows.Forms.Button()
        Me.empname = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnRefresh = New System.Windows.Forms.ToolStripButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cboEmpCD = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cboDesignNo = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cboSoNo = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cboDyedHouse = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dtpDateTo = New System.Windows.Forms.DateTimePicker()
        Me.dtpDateFr = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cboCustomer = New System.Windows.Forms.ComboBox()
        Me.txtDFNo = New System.Windows.Forms.TextBox()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.btnExit = New System.Windows.Forms.ToolStripButton()
        Me.dhname = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.custname = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.sono = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.grdDF = New System.Windows.Forms.DataGridView()
        Me.dfno = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dfdt = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.design_no = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox1.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.grdDF, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(168, 64)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(38, 13)
        Me.Label8.TabIndex = 25
        Me.Label8.Text = "Owner"
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
        'btnRefresh2
        '
        Me.btnRefresh2.Image = CType(resources.GetObject("btnRefresh2.Image"), System.Drawing.Image)
        Me.btnRefresh2.Location = New System.Drawing.Point(623, 40)
        Me.btnRefresh2.Name = "btnRefresh2"
        Me.btnRefresh2.Size = New System.Drawing.Size(72, 32)
        Me.btnRefresh2.TabIndex = 30
        Me.btnRefresh2.Text = "&Refresh"
        Me.btnRefresh2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnRefresh2.UseVisualStyleBackColor = True
        '
        'empname
        '
        Me.empname.DataPropertyName = "empname"
        Me.empname.HeaderText = "Owner"
        Me.empname.Name = "empname"
        Me.empname.ReadOnly = True
        Me.empname.Width = 50
        '
        'btnRefresh
        '
        Me.btnRefresh.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnRefresh.Image = CType(resources.GetObject("btnRefresh.Image"), System.Drawing.Image)
        Me.btnRefresh.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(23, 22)
        Me.btnRefresh.Text = "&Refresh"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.cboEmpCD)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.cboDesignNo)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.cboSoNo)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.cboDyedHouse)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.dtpDateTo)
        Me.GroupBox1.Controls.Add(Me.dtpDateFr)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.cboCustomer)
        Me.GroupBox1.Controls.Add(Me.txtDFNo)
        Me.GroupBox1.Location = New System.Drawing.Point(7, 27)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(608, 96)
        Me.GroupBox1.TabIndex = 29
        Me.GroupBox1.TabStop = False
        '
        'cboEmpCD
        '
        Me.cboEmpCD.FormattingEnabled = True
        Me.cboEmpCD.Location = New System.Drawing.Point(208, 64)
        Me.cboEmpCD.Name = "cboEmpCD"
        Me.cboEmpCD.Size = New System.Drawing.Size(88, 21)
        Me.cboEmpCD.TabIndex = 24
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(304, 64)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(60, 13)
        Me.Label7.TabIndex = 23
        Me.Label7.Text = "Design No."
        '
        'cboDesignNo
        '
        Me.cboDesignNo.FormattingEnabled = True
        Me.cboDesignNo.Location = New System.Drawing.Point(376, 64)
        Me.cboDesignNo.Name = "cboDesignNo"
        Me.cboDesignNo.Size = New System.Drawing.Size(120, 21)
        Me.cboDesignNo.TabIndex = 22
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(304, 40)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(47, 13)
        Me.Label6.TabIndex = 21
        Me.Label6.Text = "S/O No."
        '
        'cboSoNo
        '
        Me.cboSoNo.FormattingEnabled = True
        Me.cboSoNo.Location = New System.Drawing.Point(376, 40)
        Me.cboSoNo.Name = "cboSoNo"
        Me.cboSoNo.Size = New System.Drawing.Size(120, 21)
        Me.cboSoNo.TabIndex = 20
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(304, 16)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(66, 13)
        Me.Label5.TabIndex = 19
        Me.Label5.Text = "Dyed House"
        '
        'cboDyedHouse
        '
        Me.cboDyedHouse.FormattingEnabled = True
        Me.cboDyedHouse.Location = New System.Drawing.Point(376, 16)
        Me.cboDyedHouse.Name = "cboDyedHouse"
        Me.cboDyedHouse.Size = New System.Drawing.Size(224, 21)
        Me.cboDyedHouse.TabIndex = 18
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(8, 64)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(46, 13)
        Me.Label4.TabIndex = 17
        Me.Label4.Text = "D/F No."
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(168, 40)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(20, 13)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "To"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(8, 40)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 13)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "D/F Date"
        '
        'dtpDateTo
        '
        Me.dtpDateTo.CustomFormat = "dd/MM/yyyy"
        Me.dtpDateTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpDateTo.Location = New System.Drawing.Point(208, 40)
        Me.dtpDateTo.Name = "dtpDateTo"
        Me.dtpDateTo.Size = New System.Drawing.Size(88, 20)
        Me.dtpDateTo.TabIndex = 14
        '
        'dtpDateFr
        '
        Me.dtpDateFr.CustomFormat = "dd/MM/yyyy"
        Me.dtpDateFr.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpDateFr.Location = New System.Drawing.Point(72, 40)
        Me.dtpDateFr.Name = "dtpDateFr"
        Me.dtpDateFr.Size = New System.Drawing.Size(88, 20)
        Me.dtpDateFr.TabIndex = 13
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(8, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(51, 13)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Customer"
        '
        'cboCustomer
        '
        Me.cboCustomer.FormattingEnabled = True
        Me.cboCustomer.Location = New System.Drawing.Point(72, 16)
        Me.cboCustomer.Name = "cboCustomer"
        Me.cboCustomer.Size = New System.Drawing.Size(224, 21)
        Me.cboCustomer.TabIndex = 11
        '
        'txtDFNo
        '
        Me.txtDFNo.Location = New System.Drawing.Point(72, 64)
        Me.txtDFNo.Name = "txtDFNo"
        Me.txtDFNo.Size = New System.Drawing.Size(88, 20)
        Me.txtDFNo.TabIndex = 10
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnRefresh, Me.btnMinimized, Me.btnExit})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(703, 25)
        Me.ToolStrip1.TabIndex = 27
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
        'dhname
        '
        Me.dhname.DataPropertyName = "dhname"
        Me.dhname.HeaderText = "Dyed House"
        Me.dhname.Name = "dhname"
        Me.dhname.ReadOnly = True
        '
        'custname
        '
        Me.custname.DataPropertyName = "custname"
        Me.custname.HeaderText = "Customer"
        Me.custname.Name = "custname"
        Me.custname.ReadOnly = True
        Me.custname.Width = 130
        '
        'sono
        '
        Me.sono.DataPropertyName = "sono"
        Me.sono.HeaderText = "S/O No."
        Me.sono.Name = "sono"
        Me.sono.ReadOnly = True
        Me.sono.Width = 85
        '
        'grdDF
        '
        Me.grdDF.AllowUserToAddRows = False
        Me.grdDF.AllowUserToDeleteRows = False
        Me.grdDF.AllowUserToOrderColumns = True
        Me.grdDF.BackgroundColor = System.Drawing.Color.PeachPuff
        Me.grdDF.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdDF.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.dfno, Me.dfdt, Me.design_no, Me.sono, Me.custname, Me.dhname, Me.empname})
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.grdDF.DefaultCellStyle = DataGridViewCellStyle1
        Me.grdDF.Location = New System.Drawing.Point(7, 131)
        Me.grdDF.Name = "grdDF"
        Me.grdDF.ReadOnly = True
        Me.grdDF.Size = New System.Drawing.Size(688, 344)
        Me.grdDF.TabIndex = 28
        '
        'dfno
        '
        Me.dfno.DataPropertyName = "dfno"
        Me.dfno.HeaderText = "D/F No."
        Me.dfno.Name = "dfno"
        Me.dfno.ReadOnly = True
        Me.dfno.Width = 85
        '
        'dfdt
        '
        Me.dfdt.DataPropertyName = "dfdt2"
        Me.dfdt.HeaderText = "D/F Date"
        Me.dfdt.Name = "dfdt"
        Me.dfdt.ReadOnly = True
        Me.dfdt.Width = 85
        '
        'design_no
        '
        Me.design_no.DataPropertyName = "design_no"
        Me.design_no.HeaderText = "Design No."
        Me.design_no.Name = "design_no"
        Me.design_no.ReadOnly = True
        Me.design_no.Width = 85
        '
        'frmSearchDFOrderPreset
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(703, 483)
        Me.Controls.Add(Me.btnRefresh2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.grdDF)
        Me.Name = "frmSearchDFOrderPreset"
        Me.Text = "Search Preset"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.grdDF, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents btnMinimized As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnRefresh2 As System.Windows.Forms.Button
    Friend WithEvents empname As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btnRefresh As System.Windows.Forms.ToolStripButton
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents cboEmpCD As System.Windows.Forms.ComboBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents cboDesignNo As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents cboSoNo As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents cboDyedHouse As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents dtpDateTo As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpDateFr As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cboCustomer As System.Windows.Forms.ComboBox
    Friend WithEvents txtDFNo As System.Windows.Forms.TextBox
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents btnExit As System.Windows.Forms.ToolStripButton
    Friend WithEvents dhname As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents custname As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents sono As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents grdDF As System.Windows.Forms.DataGridView
    Friend WithEvents dfno As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dfdt As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents design_no As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
