<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmStockDClearanceSale
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmStockDClearanceSale))
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.lblError = New System.Windows.Forms.Label()
        Me.txtBarcode = New System.Windows.Forms.TextBox()
        Me.mts = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.kg = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.roll_no_o = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnNew = New System.Windows.Forms.ToolStripButton()
        Me.btnPrint = New System.Windows.Forms.ToolStripButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.btnSave = New System.Windows.Forms.ToolStripButton()
        Me.btnMinimized = New System.Windows.Forms.ToolStripButton()
        Me.btnExit = New System.Windows.Forms.ToolStripButton()
        Me.roll_no_d = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.gr = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.design_no = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dfno = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.grdData = New System.Windows.Forms.DataGridView()
        Me.col = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.custcolor = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lot = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dono = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dinno = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dindt = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cboCustomer = New System.Windows.Forms.ComboBox()
        Me.dtpDocDate = New System.Windows.Forms.DateTimePicker()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.grdData, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblError
        '
        Me.lblError.AutoSize = True
        Me.lblError.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblError.ForeColor = System.Drawing.Color.Red
        Me.lblError.Location = New System.Drawing.Point(274, 32)
        Me.lblError.Name = "lblError"
        Me.lblError.Size = New System.Drawing.Size(0, 13)
        Me.lblError.TabIndex = 53
        '
        'txtBarcode
        '
        Me.txtBarcode.Location = New System.Drawing.Point(208, 56)
        Me.txtBarcode.Name = "txtBarcode"
        Me.txtBarcode.Size = New System.Drawing.Size(264, 20)
        Me.txtBarcode.TabIndex = 51
        '
        'mts
        '
        Me.mts.DataPropertyName = "mts"
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.mts.DefaultCellStyle = DataGridViewCellStyle1
        Me.mts.HeaderText = "Mts."
        Me.mts.Name = "mts"
        Me.mts.ReadOnly = True
        Me.mts.Width = 50
        '
        'kg
        '
        Me.kg.DataPropertyName = "kg"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.kg.DefaultCellStyle = DataGridViewCellStyle2
        Me.kg.HeaderText = "Kgs."
        Me.kg.Name = "kg"
        Me.kg.ReadOnly = True
        Me.kg.Width = 50
        '
        'roll_no_o
        '
        Me.roll_no_o.DataPropertyName = "roll_no_o"
        Me.roll_no_o.HeaderText = "Greige Roll No."
        Me.roll_no_o.Name = "roll_no_o"
        Me.roll_no_o.ReadOnly = True
        '
        'btnNew
        '
        Me.btnNew.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnNew.Image = CType(resources.GetObject("btnNew.Image"), System.Drawing.Image)
        Me.btnNew.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnNew.Name = "btnNew"
        Me.btnNew.Size = New System.Drawing.Size(23, 22)
        Me.btnNew.Text = "New"
        '
        'btnPrint
        '
        Me.btnPrint.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnPrint.Image = CType(resources.GetObject("btnPrint.Image"), System.Drawing.Image)
        Me.btnPrint.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(23, 22)
        Me.btnPrint.Text = "Print"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(8, 56)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(193, 13)
        Me.Label1.TabIndex = 50
        Me.Label1.Text = "Add Stock D Roll No. Barcode Here -->"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnNew, Me.btnSave, Me.btnPrint, Me.btnMinimized, Me.btnExit})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1017, 25)
        Me.ToolStrip1.TabIndex = 49
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
        'roll_no_d
        '
        Me.roll_no_d.DataPropertyName = "roll_no_d"
        Me.roll_no_d.HeaderText = "Roll No."
        Me.roll_no_d.Name = "roll_no_d"
        Me.roll_no_d.ReadOnly = True
        Me.roll_no_d.Width = 75
        '
        'gr
        '
        Me.gr.DataPropertyName = "gr"
        Me.gr.HeaderText = "Gr"
        Me.gr.Name = "gr"
        Me.gr.ReadOnly = True
        Me.gr.Width = 30
        '
        'design_no
        '
        Me.design_no.DataPropertyName = "design_no"
        Me.design_no.HeaderText = "Design No."
        Me.design_no.Name = "design_no"
        Me.design_no.ReadOnly = True
        '
        'dfno
        '
        Me.dfno.DataPropertyName = "dfno"
        Me.dfno.HeaderText = "DF No."
        Me.dfno.Name = "dfno"
        Me.dfno.ReadOnly = True
        Me.dfno.Width = 75
        '
        'id
        '
        Me.id.DataPropertyName = "id"
        Me.id.HeaderText = "ID"
        Me.id.Name = "id"
        Me.id.ReadOnly = True
        Me.id.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.id.Width = 30
        '
        'grdData
        '
        Me.grdData.AllowUserToAddRows = False
        Me.grdData.AllowUserToDeleteRows = False
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.grdData.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle3
        Me.grdData.BackgroundColor = System.Drawing.Color.PeachPuff
        Me.grdData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdData.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id, Me.dfno, Me.design_no, Me.col, Me.custcolor, Me.lot, Me.dono, Me.dinno, Me.dindt, Me.gr, Me.roll_no_d, Me.roll_no_o, Me.kg, Me.mts})
        Me.grdData.Location = New System.Drawing.Point(8, 88)
        Me.grdData.Name = "grdData"
        Me.grdData.Size = New System.Drawing.Size(1000, 424)
        Me.grdData.TabIndex = 52
        '
        'col
        '
        Me.col.DataPropertyName = "col"
        Me.col.HeaderText = "Color Code"
        Me.col.Name = "col"
        Me.col.ReadOnly = True
        Me.col.Width = 65
        '
        'custcolor
        '
        Me.custcolor.DataPropertyName = "custcolor"
        Me.custcolor.HeaderText = "Color"
        Me.custcolor.Name = "custcolor"
        Me.custcolor.ReadOnly = True
        Me.custcolor.Width = 60
        '
        'lot
        '
        Me.lot.DataPropertyName = "lot"
        Me.lot.HeaderText = "Job No."
        Me.lot.Name = "lot"
        Me.lot.ReadOnly = True
        Me.lot.Width = 75
        '
        'dono
        '
        Me.dono.DataPropertyName = "dono"
        Me.dono.HeaderText = "Bill No."
        Me.dono.Name = "dono"
        Me.dono.ReadOnly = True
        Me.dono.Width = 75
        '
        'dinno
        '
        Me.dinno.DataPropertyName = "dinno"
        Me.dinno.HeaderText = "D-IN No."
        Me.dinno.Name = "dinno"
        Me.dinno.ReadOnly = True
        Me.dinno.Width = 75
        '
        'dindt
        '
        Me.dindt.DataPropertyName = "dindt"
        Me.dindt.HeaderText = "D-IN Date"
        Me.dindt.Name = "dindt"
        Me.dindt.ReadOnly = True
        Me.dindt.Width = 75
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Red
        Me.Label2.Location = New System.Drawing.Point(480, 56)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(146, 13)
        Me.Label2.TabIndex = 54
        Me.Label2.Text = "***Example : D11039762"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(8, 32)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(90, 13)
        Me.Label3.TabIndex = 55
        Me.Label3.Text = "Select Customer :"
        '
        'cboCustomer
        '
        Me.cboCustomer.FormattingEnabled = True
        Me.cboCustomer.Location = New System.Drawing.Point(208, 32)
        Me.cboCustomer.Name = "cboCustomer"
        Me.cboCustomer.Size = New System.Drawing.Size(264, 21)
        Me.cboCustomer.TabIndex = 56
        '
        'dtpDocDate
        '
        Me.dtpDocDate.AccessibleName = "dbnote_date"
        Me.dtpDocDate.CustomFormat = "dd/MM/yyyy"
        Me.dtpDocDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpDocDate.Location = New System.Drawing.Point(920, 56)
        Me.dtpDocDate.Name = "dtpDocDate"
        Me.dtpDocDate.Size = New System.Drawing.Size(88, 20)
        Me.dtpDocDate.TabIndex = 78
        Me.dtpDocDate.Tag = ""
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Location = New System.Drawing.Point(862, 59)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(53, 13)
        Me.Label28.TabIndex = 79
        Me.Label28.Text = "Doc Date"
        '
        'frmStockDClearanceSale
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1017, 521)
        Me.Controls.Add(Me.dtpDocDate)
        Me.Controls.Add(Me.Label28)
        Me.Controls.Add(Me.cboCustomer)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lblError)
        Me.Controls.Add(Me.txtBarcode)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.grdData)
        Me.Controls.Add(Me.Label2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmStockDClearanceSale"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Stock D Clearance Sale"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.grdData, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblError As System.Windows.Forms.Label
    Friend WithEvents txtBarcode As System.Windows.Forms.TextBox
    Friend WithEvents mts As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents kg As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents roll_no_o As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btnNew As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnPrint As System.Windows.Forms.ToolStripButton
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents btnMinimized As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnExit As System.Windows.Forms.ToolStripButton
    Friend WithEvents roll_no_d As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents gr As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents design_no As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dfno As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents grdData As System.Windows.Forms.DataGridView
    Friend WithEvents col As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents custcolor As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents lot As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dono As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dinno As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dindt As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cboCustomer As System.Windows.Forms.ComboBox
    Friend WithEvents btnSave As System.Windows.Forms.ToolStripButton
    Friend WithEvents dtpDocDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label28 As System.Windows.Forms.Label
End Class
