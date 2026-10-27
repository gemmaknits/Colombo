<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGreigeDailyCapacity
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmGreigeDailyCapacity))
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.cboCustomer = New System.Windows.Forms.ComboBox()
        Me.lblSup = New System.Windows.Forms.Label()
        Me.CboKoNo = New System.Windows.Forms.ComboBox()
        Me.lblKO = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cboDesignNo = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dtpDateTo = New System.Windows.Forms.DateTimePicker()
        Me.dtpDateFr = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.btnPrint = New System.Windows.Forms.ToolStripButton()
        Me.btnMinimized = New System.Windows.Forms.ToolStripButton()
        Me.btnExit = New System.Windows.Forms.ToolStripButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.optBeta = New System.Windows.Forms.RadioButton()
        Me.OptStable = New System.Windows.Forms.RadioButton()
        Me.dgselectItem = New System.Windows.Forms.DataGridView()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnSelectAll = New System.Windows.Forms.Button()
        Me.txtFilter = New System.Windows.Forms.TextBox()
        Me.colSelect = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.mcno = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox2.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgselectItem, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.cboCustomer)
        Me.GroupBox2.Controls.Add(Me.lblSup)
        Me.GroupBox2.Controls.Add(Me.CboKoNo)
        Me.GroupBox2.Controls.Add(Me.lblKO)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.cboDesignNo)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.dtpDateTo)
        Me.GroupBox2.Controls.Add(Me.dtpDateFr)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Location = New System.Drawing.Point(22, 33)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(350, 192)
        Me.GroupBox2.TabIndex = 41
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Filter"
        '
        'cboCustomer
        '
        Me.cboCustomer.BackColor = System.Drawing.SystemColors.Window
        Me.cboCustomer.FormattingEnabled = True
        Me.cboCustomer.Location = New System.Drawing.Point(116, 143)
        Me.cboCustomer.Name = "cboCustomer"
        Me.cboCustomer.Size = New System.Drawing.Size(216, 21)
        Me.cboCustomer.TabIndex = 50
        '
        'lblSup
        '
        Me.lblSup.AutoSize = True
        Me.lblSup.Location = New System.Drawing.Point(50, 143)
        Me.lblSup.Name = "lblSup"
        Me.lblSup.Size = New System.Drawing.Size(51, 13)
        Me.lblSup.TabIndex = 49
        Me.lblSup.Text = "Customer"
        '
        'CboKoNo
        '
        Me.CboKoNo.FormattingEnabled = True
        Me.CboKoNo.Location = New System.Drawing.Point(116, 104)
        Me.CboKoNo.Name = "CboKoNo"
        Me.CboKoNo.Size = New System.Drawing.Size(216, 21)
        Me.CboKoNo.TabIndex = 47
        '
        'lblKO
        '
        Me.lblKO.AutoSize = True
        Me.lblKO.Location = New System.Drawing.Point(53, 104)
        Me.lblKO.Name = "lblKO"
        Me.lblKO.Size = New System.Drawing.Size(47, 13)
        Me.lblKO.TabIndex = 46
        Me.lblKO.Text = "K/O No."
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(34, 68)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(60, 13)
        Me.Label4.TabIndex = 45
        Me.Label4.Text = "Design No."
        '
        'cboDesignNo
        '
        Me.cboDesignNo.FormattingEnabled = True
        Me.cboDesignNo.Location = New System.Drawing.Point(116, 68)
        Me.cboDesignNo.Name = "cboDesignNo"
        Me.cboDesignNo.Size = New System.Drawing.Size(216, 21)
        Me.cboDesignNo.TabIndex = 44
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(212, 31)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(20, 13)
        Me.Label3.TabIndex = 42
        Me.Label3.Text = "To"
        '
        'dtpDateTo
        '
        Me.dtpDateTo.CustomFormat = "dd/MM/yyyy"
        Me.dtpDateTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpDateTo.Location = New System.Drawing.Point(244, 31)
        Me.dtpDateTo.Name = "dtpDateTo"
        Me.dtpDateTo.Size = New System.Drawing.Size(88, 20)
        Me.dtpDateTo.TabIndex = 41
        '
        'dtpDateFr
        '
        Me.dtpDateFr.CustomFormat = "dd/MM/yyyy"
        Me.dtpDateFr.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpDateFr.Location = New System.Drawing.Point(116, 31)
        Me.dtpDateFr.Name = "dtpDateFr"
        Me.dtpDateFr.Size = New System.Drawing.Size(88, 20)
        Me.dtpDateFr.TabIndex = 40
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 31)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(80, 13)
        Me.Label2.TabIndex = 39
        Me.Label2.Text = "Date between :"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnPrint, Me.btnMinimized, Me.btnExit})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(732, 25)
        Me.ToolStrip1.TabIndex = 42
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
        Me.GroupBox1.Controls.Add(Me.optBeta)
        Me.GroupBox1.Controls.Add(Me.OptStable)
        Me.GroupBox1.Location = New System.Drawing.Point(22, 231)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(350, 64)
        Me.GroupBox1.TabIndex = 43
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Version"
        '
        'optBeta
        '
        Me.optBeta.AutoSize = True
        Me.optBeta.Location = New System.Drawing.Point(232, 29)
        Me.optBeta.Name = "optBeta"
        Me.optBeta.Size = New System.Drawing.Size(47, 17)
        Me.optBeta.TabIndex = 1
        Me.optBeta.Text = "Beta"
        Me.optBeta.UseVisualStyleBackColor = True
        '
        'OptStable
        '
        Me.OptStable.AutoSize = True
        Me.OptStable.Checked = True
        Me.OptStable.Location = New System.Drawing.Point(52, 29)
        Me.OptStable.Name = "OptStable"
        Me.OptStable.Size = New System.Drawing.Size(55, 17)
        Me.OptStable.TabIndex = 0
        Me.OptStable.TabStop = True
        Me.OptStable.Text = "Stable"
        Me.OptStable.UseVisualStyleBackColor = True
        '
        'dgselectItem
        '
        Me.dgselectItem.AllowUserToAddRows = False
        Me.dgselectItem.AllowUserToDeleteRows = False
        Me.dgselectItem.AllowUserToResizeColumns = False
        Me.dgselectItem.AllowUserToResizeRows = False
        Me.dgselectItem.BackgroundColor = System.Drawing.Color.PeachPuff
        Me.dgselectItem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgselectItem.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colSelect, Me.mcno})
        Me.dgselectItem.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter
        Me.dgselectItem.Location = New System.Drawing.Point(26, 91)
        Me.dgselectItem.Name = "dgselectItem"
        Me.dgselectItem.Size = New System.Drawing.Size(265, 153)
        Me.dgselectItem.TabIndex = 44
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.btnClear)
        Me.GroupBox3.Controls.Add(Me.btnSelectAll)
        Me.GroupBox3.Controls.Add(Me.dgselectItem)
        Me.GroupBox3.Controls.Add(Me.txtFilter)
        Me.GroupBox3.Location = New System.Drawing.Point(397, 33)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(311, 262)
        Me.GroupBox3.TabIndex = 45
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "LookUp"
        '
        'btnClear
        '
        Me.btnClear.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnClear.Location = New System.Drawing.Point(233, 20)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(72, 24)
        Me.btnClear.TabIndex = 153
        Me.btnClear.Text = "Clear all"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnSelectAll
        '
        Me.btnSelectAll.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnSelectAll.Location = New System.Drawing.Point(233, 50)
        Me.btnSelectAll.Name = "btnSelectAll"
        Me.btnSelectAll.Size = New System.Drawing.Size(72, 24)
        Me.btnSelectAll.TabIndex = 152
        Me.btnSelectAll.Text = "SelectAll"
        Me.btnSelectAll.UseVisualStyleBackColor = True
        '
        'txtFilter
        '
        Me.txtFilter.Location = New System.Drawing.Point(37, 24)
        Me.txtFilter.Name = "txtFilter"
        Me.txtFilter.Size = New System.Drawing.Size(176, 20)
        Me.txtFilter.TabIndex = 150
        '
        'colSelect
        '
        Me.colSelect.HeaderText = ""
        Me.colSelect.Name = "colSelect"
        Me.colSelect.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.colSelect.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.colSelect.Width = 25
        '
        'mcno
        '
        Me.mcno.DataPropertyName = "mcno"
        Me.mcno.HeaderText = "M/C No."
        Me.mcno.Name = "mcno"
        Me.mcno.Width = 190
        '
        'frmGreigeDailyCapacity
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(732, 306)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.GroupBox2)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmGreigeDailyCapacity"
        Me.Text = "Greige Daily Capacity"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dgselectItem, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents dtpDateTo As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpDateFr As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents btnPrint As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnMinimized As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnExit As System.Windows.Forms.ToolStripButton
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cboDesignNo As System.Windows.Forms.ComboBox
    Friend WithEvents CboKoNo As System.Windows.Forms.ComboBox
    Friend WithEvents lblKO As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents optBeta As System.Windows.Forms.RadioButton
    Friend WithEvents OptStable As System.Windows.Forms.RadioButton
    Friend WithEvents cboCustomer As System.Windows.Forms.ComboBox
    Friend WithEvents lblSup As System.Windows.Forms.Label
    Friend WithEvents dgselectItem As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnSelectAll As System.Windows.Forms.Button
    Friend WithEvents txtFilter As System.Windows.Forms.TextBox
    Friend WithEvents colSelect As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents mcno As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
