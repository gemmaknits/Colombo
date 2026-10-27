<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDyingOrderChange
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
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDyingOrderChange))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.grdDF = New System.Windows.Forms.DataGridView
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel
        Me.cboDFNo = New System.Windows.Forms.ToolStripComboBox
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.btnSave = New System.Windows.Forms.ToolStripButton
        Me.btnMinimized = New System.Windows.Forms.ToolStripButton
        Me.btnExit = New System.Windows.Forms.ToolStripButton
        Me.cboSoNo = New System.Windows.Forms.ComboBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.design_no2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.gwth2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colCol = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colCustColor = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.sonoid = New System.Windows.Forms.DataGridViewComboBoxColumn
        Me.roll_no = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.roll_no_o = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.qc_kg = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.qc_yds = New System.Windows.Forms.DataGridViewTextBoxColumn
        CType(Me.grdDF, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'grdDF
        '
        Me.grdDF.AllowUserToAddRows = False
        Me.grdDF.AllowUserToDeleteRows = False
        Me.grdDF.AllowUserToOrderColumns = True
        Me.grdDF.BackgroundColor = System.Drawing.Color.PeachPuff
        Me.grdDF.ColumnHeadersHeight = 42
        Me.grdDF.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.design_no2, Me.gwth2, Me.colCol, Me.colCustColor, Me.sonoid, Me.roll_no, Me.roll_no_o, Me.qc_kg, Me.qc_yds})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.grdDF.DefaultCellStyle = DataGridViewCellStyle2
        Me.grdDF.Location = New System.Drawing.Point(8, 72)
        Me.grdDF.Name = "grdDF"
        Me.grdDF.Size = New System.Drawing.Size(917, 512)
        Me.grdDF.TabIndex = 40
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel1, Me.cboDFNo, Me.ToolStripSeparator1, Me.btnSave, Me.btnMinimized, Me.btnExit})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(940, 25)
        Me.ToolStrip1.TabIndex = 41
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(75, 22)
        Me.ToolStripLabel1.Text = "D/F Order No."
        '
        'cboDFNo
        '
        Me.cboDFNo.Name = "cboDFNo"
        Me.cboDFNo.Size = New System.Drawing.Size(100, 25)
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
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
        Me.btnExit.Text = "Exit"
        '
        'cboSoNo
        '
        Me.cboSoNo.FormattingEnabled = True
        Me.cboSoNo.Location = New System.Drawing.Point(56, 32)
        Me.cboSoNo.Name = "cboSoNo"
        Me.cboSoNo.Size = New System.Drawing.Size(112, 21)
        Me.cboSoNo.TabIndex = 43
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(8, 32)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(47, 13)
        Me.Label5.TabIndex = 42
        Me.Label5.Text = "S/O No."
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.Red
        Me.Label1.Location = New System.Drawing.Point(176, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(609, 13)
        Me.Label1.TabIndex = 44
        Me.Label1.Text = "* จะไม่โชว์ S/O No. ที่ปิดการขายไปหมดแล้ว และจะโชว์เฉพาะ S/O No. ที่มี Design No." & _
            " เหมือนกับ D/F ใบนี้เท่านั้น"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.Red
        Me.Label2.Location = New System.Drawing.Point(176, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(548, 13)
        Me.Label2.TabIndex = 45
        Me.Label2.Text = "** D/F ที่ทำการ DIN ผ้าแล้วไม่ว่าจะครบจำนวนหรือไม่ก็ตาม หรือปิดรายการไปแล้วไม่สาม" & _
            "ารถแก้ไขได้"
        '
        'design_no2
        '
        Me.design_no2.DataPropertyName = "design_no"
        Me.design_no2.HeaderText = "Design No."
        Me.design_no2.Name = "design_no2"
        Me.design_no2.ReadOnly = True
        Me.design_no2.Width = 120
        '
        'gwth2
        '
        Me.gwth2.DataPropertyName = "gwth"
        Me.gwth2.HeaderText = "Gwth"
        Me.gwth2.Name = "gwth2"
        Me.gwth2.ReadOnly = True
        Me.gwth2.Width = 50
        '
        'colCol
        '
        Me.colCol.DataPropertyName = "col"
        Me.colCol.HeaderText = "Color code"
        Me.colCol.Name = "colCol"
        Me.colCol.ReadOnly = True
        '
        'colCustColor
        '
        Me.colCustColor.DataPropertyName = "custcolor"
        Me.colCustColor.HeaderText = "Customer Color"
        Me.colCustColor.Name = "colCustColor"
        Me.colCustColor.ReadOnly = True
        '
        'sonoid
        '
        Me.sonoid.DataPropertyName = "sonoid"
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.sonoid.DefaultCellStyle = DataGridViewCellStyle1
        Me.sonoid.HeaderText = "S/O No. ID"
        Me.sonoid.Name = "sonoid"
        Me.sonoid.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.sonoid.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.sonoid.Width = 200
        '
        'roll_no
        '
        Me.roll_no.DataPropertyName = "roll_no"
        Me.roll_no.HeaderText = "Roll No."
        Me.roll_no.Name = "roll_no"
        Me.roll_no.ReadOnly = True
        Me.roll_no.Width = 75
        '
        'roll_no_o
        '
        Me.roll_no_o.DataPropertyName = "roll_no_o"
        Me.roll_no_o.HeaderText = "Factory Roll No."
        Me.roll_no_o.Name = "roll_no_o"
        Me.roll_no_o.ReadOnly = True
        Me.roll_no_o.Width = 120
        '
        'qc_kg
        '
        Me.qc_kg.DataPropertyName = "qc_kg"
        Me.qc_kg.HeaderText = "Kgs."
        Me.qc_kg.Name = "qc_kg"
        Me.qc_kg.ReadOnly = True
        Me.qc_kg.Width = 75
        '
        'qc_yds
        '
        Me.qc_yds.DataPropertyName = "qc_yds"
        Me.qc_yds.HeaderText = "Yds."
        Me.qc_yds.Name = "qc_yds"
        Me.qc_yds.ReadOnly = True
        Me.qc_yds.Width = 75
        '
        'frmDyingOrderChange
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(940, 593)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cboSoNo)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.grdDF)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmDyingOrderChange"
        Me.Text = "Dying Order Change"
        CType(Me.grdDF, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
	Friend WithEvents grdDF As System.Windows.Forms.DataGridView
	Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
	Friend WithEvents ToolStripLabel1 As System.Windows.Forms.ToolStripLabel
	Friend WithEvents cboDFNo As System.Windows.Forms.ToolStripComboBox
	Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
	Friend WithEvents btnSave As System.Windows.Forms.ToolStripButton
	Friend WithEvents btnMinimized As System.Windows.Forms.ToolStripButton
	Friend WithEvents btnExit As System.Windows.Forms.ToolStripButton
	Friend WithEvents cboSoNo As System.Windows.Forms.ComboBox
	Friend WithEvents Label5 As System.Windows.Forms.Label
	Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents design_no2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents gwth2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colCol As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colCustColor As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents sonoid As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents roll_no As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents roll_no_o As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents qc_kg As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents qc_yds As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
