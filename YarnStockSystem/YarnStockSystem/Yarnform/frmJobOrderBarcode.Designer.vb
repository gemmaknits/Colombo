<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmJobOrderBarcode
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmJobOrderBarcode))
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cboDocType = New System.Windows.Forms.ComboBox()
        Me.btnSearchKI = New System.Windows.Forms.Button()
        Me.txtKONo = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.btnNew = New System.Windows.Forms.ToolStripButton()
        Me.btnSave = New System.Windows.Forms.ToolStripButton()
        Me.btnPrint = New System.Windows.Forms.ToolStripButton()
        Me.btnMinimized = New System.Windows.Forms.ToolStripButton()
        Me.btnExit = New System.Windows.Forms.ToolStripButton()
        Me.txtBarcode = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.grdData = New System.Windows.Forms.DataGridView()
        Me.id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.itcd = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.sinvno = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.docno = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.docdt = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.grade = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.boxno = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.spools = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.kg_gr = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.kg_nt = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lotno_our = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.txtTotalBox = New System.Windows.Forms.TextBox()
        Me.txtTotalKgNt = New System.Windows.Forms.TextBox()
        Me.txtTotalSpool = New System.Windows.Forms.TextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.txtTotalKgGr = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtRemark = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.dtpJobDate = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.CboSuppcd = New System.Windows.Forms.ComboBox()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.grdData, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox6.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label3.Location = New System.Drawing.Point(8, 40)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(48, 13)
        Me.Label3.TabIndex = 135
        Me.Label3.Text = "Process:"
        '
        'cboDocType
        '
        Me.cboDocType.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.cboDocType.FormattingEnabled = True
        Me.cboDocType.Location = New System.Drawing.Point(64, 40)
        Me.cboDocType.Name = "cboDocType"
        Me.cboDocType.Size = New System.Drawing.Size(121, 24)
        Me.cboDocType.TabIndex = 134
        '
        'btnSearchKI
        '
        Me.btnSearchKI.Image = CType(resources.GetObject("btnSearchKI.Image"), System.Drawing.Image)
        Me.btnSearchKI.ImageAlign = System.Drawing.ContentAlignment.BottomRight
        Me.btnSearchKI.Location = New System.Drawing.Point(528, 40)
        Me.btnSearchKI.Name = "btnSearchKI"
        Me.btnSearchKI.Size = New System.Drawing.Size(24, 24)
        Me.btnSearchKI.TabIndex = 157
        Me.btnSearchKI.UseVisualStyleBackColor = True
        '
        'txtKONo
        '
        Me.txtKONo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtKONo.Location = New System.Drawing.Point(424, 40)
        Me.txtKONo.Name = "txtKONo"
        Me.txtKONo.Size = New System.Drawing.Size(100, 22)
        Me.txtKONo.TabIndex = 156
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label15.Location = New System.Drawing.Point(376, 40)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(47, 13)
        Me.Label15.TabIndex = 158
        Me.Label15.Text = "K/O No."
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnNew, Me.btnSave, Me.btnPrint, Me.btnMinimized, Me.btnExit})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(889, 25)
        Me.ToolStrip1.TabIndex = 159
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
        'btnExit
        '
        Me.btnExit.Image = CType(resources.GetObject("btnExit.Image"), System.Drawing.Image)
        Me.btnExit.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(45, 22)
        Me.btnExit.Text = "Exit"
        '
        'txtBarcode
        '
        Me.txtBarcode.Location = New System.Drawing.Point(752, 40)
        Me.txtBarcode.Name = "txtBarcode"
        Me.txtBarcode.Size = New System.Drawing.Size(128, 22)
        Me.txtBarcode.TabIndex = 161
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(568, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(187, 13)
        Me.Label1.TabIndex = 160
        Me.Label1.Text = "Add Yarn Box No. Barcode Here -->"
        '
        'grdData
        '
        Me.grdData.AllowUserToAddRows = False
        Me.grdData.AllowUserToDeleteRows = False
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.grdData.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle4
        Me.grdData.BackgroundColor = System.Drawing.Color.PeachPuff
        Me.grdData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdData.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id, Me.itcd, Me.sinvno, Me.docno, Me.docdt, Me.grade, Me.boxno, Me.spools, Me.kg_gr, Me.kg_nt, Me.lotno_our})
        Me.grdData.Location = New System.Drawing.Point(8, 107)
        Me.grdData.Name = "grdData"
        Me.grdData.Size = New System.Drawing.Size(872, 325)
        Me.grdData.TabIndex = 163
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
        'itcd
        '
        Me.itcd.DataPropertyName = "itcd"
        Me.itcd.HeaderText = "Yarn Code"
        Me.itcd.Name = "itcd"
        Me.itcd.ReadOnly = True
        Me.itcd.Width = 75
        '
        'sinvno
        '
        Me.sinvno.DataPropertyName = "sinvno"
        Me.sinvno.HeaderText = "Supplier Inv No."
        Me.sinvno.Name = "sinvno"
        Me.sinvno.ReadOnly = True
        '
        'docno
        '
        Me.docno.DataPropertyName = "docno"
        Me.docno.HeaderText = "Y-IN No."
        Me.docno.Name = "docno"
        Me.docno.ReadOnly = True
        Me.docno.Width = 75
        '
        'docdt
        '
        Me.docdt.DataPropertyName = "docdt"
        Me.docdt.HeaderText = "Y-IN Date"
        Me.docdt.Name = "docdt"
        Me.docdt.ReadOnly = True
        Me.docdt.Width = 75
        '
        'grade
        '
        Me.grade.DataPropertyName = "grade"
        Me.grade.HeaderText = "Gr"
        Me.grade.Name = "grade"
        Me.grade.ReadOnly = True
        Me.grade.Width = 30
        '
        'boxno
        '
        Me.boxno.DataPropertyName = "boxno"
        Me.boxno.HeaderText = "Box No."
        Me.boxno.Name = "boxno"
        Me.boxno.ReadOnly = True
        '
        'spools
        '
        Me.spools.DataPropertyName = "spools"
        Me.spools.HeaderText = "Spools"
        Me.spools.Name = "spools"
        Me.spools.ReadOnly = True
        '
        'kg_gr
        '
        Me.kg_gr.DataPropertyName = "kg_gr"
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.kg_gr.DefaultCellStyle = DataGridViewCellStyle5
        Me.kg_gr.HeaderText = "Gross Kgs."
        Me.kg_gr.Name = "kg_gr"
        Me.kg_gr.ReadOnly = True
        Me.kg_gr.Width = 50
        '
        'kg_nt
        '
        Me.kg_nt.DataPropertyName = "kg_nt"
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.kg_nt.DefaultCellStyle = DataGridViewCellStyle6
        Me.kg_nt.HeaderText = "Net Kgs."
        Me.kg_nt.Name = "kg_nt"
        Me.kg_nt.ReadOnly = True
        Me.kg_nt.Width = 50
        '
        'lotno_our
        '
        Me.lotno_our.DataPropertyName = "lotno_our"
        Me.lotno_our.HeaderText = "Lot No."
        Me.lotno_our.Name = "lotno_our"
        Me.lotno_our.ReadOnly = True
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.Label19)
        Me.GroupBox6.Controls.Add(Me.txtTotalBox)
        Me.GroupBox6.Controls.Add(Me.txtTotalKgNt)
        Me.GroupBox6.Controls.Add(Me.txtTotalSpool)
        Me.GroupBox6.Controls.Add(Me.Label20)
        Me.GroupBox6.Controls.Add(Me.Label21)
        Me.GroupBox6.Controls.Add(Me.Label22)
        Me.GroupBox6.Controls.Add(Me.txtTotalKgGr)
        Me.GroupBox6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.GroupBox6.Location = New System.Drawing.Point(288, 440)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(592, 56)
        Me.GroupBox6.TabIndex = 164
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Total selection"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label19.Location = New System.Drawing.Point(16, 24)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(62, 13)
        Me.Label19.TabIndex = 127
        Me.Label19.Text = "Box Count :"
        '
        'txtTotalBox
        '
        Me.txtTotalBox.Location = New System.Drawing.Point(80, 24)
        Me.txtTotalBox.Name = "txtTotalBox"
        Me.txtTotalBox.ReadOnly = True
        Me.txtTotalBox.Size = New System.Drawing.Size(48, 20)
        Me.txtTotalBox.TabIndex = 126
        Me.txtTotalBox.Text = "0"
        Me.txtTotalBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtTotalKgNt
        '
        Me.txtTotalKgNt.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtTotalKgNt.Location = New System.Drawing.Point(512, 24)
        Me.txtTotalKgNt.Name = "txtTotalKgNt"
        Me.txtTotalKgNt.ReadOnly = True
        Me.txtTotalKgNt.Size = New System.Drawing.Size(64, 22)
        Me.txtTotalKgNt.TabIndex = 122
        Me.txtTotalKgNt.Text = "0"
        Me.txtTotalKgNt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtTotalSpool
        '
        Me.txtTotalSpool.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtTotalSpool.Location = New System.Drawing.Point(224, 24)
        Me.txtTotalSpool.Name = "txtTotalSpool"
        Me.txtTotalSpool.ReadOnly = True
        Me.txtTotalSpool.Size = New System.Drawing.Size(56, 22)
        Me.txtTotalSpool.TabIndex = 124
        Me.txtTotalSpool.Text = "0"
        Me.txtTotalSpool.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label20.Location = New System.Drawing.Point(288, 24)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(75, 13)
        Me.Label20.TabIndex = 119
        Me.Label20.Text = "Gross wt. (kg):"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label21.Location = New System.Drawing.Point(136, 24)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(83, 13)
        Me.Label21.TabIndex = 123
        Me.Label21.Text = "Tubes / Spools:"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label22.Location = New System.Drawing.Point(440, 24)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(65, 13)
        Me.Label22.TabIndex = 120
        Me.Label22.Text = "Net wt. (kg):"
        '
        'txtTotalKgGr
        '
        Me.txtTotalKgGr.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtTotalKgGr.Location = New System.Drawing.Point(368, 24)
        Me.txtTotalKgGr.Name = "txtTotalKgGr"
        Me.txtTotalKgGr.ReadOnly = True
        Me.txtTotalKgGr.Size = New System.Drawing.Size(64, 22)
        Me.txtTotalKgGr.TabIndex = 121
        Me.txtTotalKgGr.Text = "0"
        Me.txtTotalKgGr.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label4.Location = New System.Drawing.Point(8, 448)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(50, 13)
        Me.Label4.TabIndex = 165
        Me.Label4.Text = "Remark :"
        '
        'txtRemark
        '
        Me.txtRemark.Location = New System.Drawing.Point(64, 448)
        Me.txtRemark.Multiline = True
        Me.txtRemark.Name = "txtRemark"
        Me.txtRemark.Size = New System.Drawing.Size(216, 48)
        Me.txtRemark.TabIndex = 166
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label5.Location = New System.Drawing.Point(200, 40)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(50, 13)
        Me.Label5.TabIndex = 167
        Me.Label5.Text = "Job Date"
        '
        'dtpJobDate
        '
        Me.dtpJobDate.CustomFormat = "dd/MM/yyyy"
        Me.dtpJobDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpJobDate.Location = New System.Drawing.Point(256, 40)
        Me.dtpJobDate.Name = "dtpJobDate"
        Me.dtpJobDate.Size = New System.Drawing.Size(104, 22)
        Me.dtpJobDate.TabIndex = 168
        Me.dtpJobDate.Value = New Date(2007, 4, 9, 0, 0, 0, 0)
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label2.Location = New System.Drawing.Point(10, 75)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(48, 13)
        Me.Label2.TabIndex = 170
        Me.Label2.Text = "Supplier:"
        '
        'CboSuppcd
        '
        Me.CboSuppcd.BackColor = System.Drawing.Color.Gold
        Me.CboSuppcd.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.CboSuppcd.FormattingEnabled = True
        Me.CboSuppcd.Location = New System.Drawing.Point(64, 70)
        Me.CboSuppcd.Name = "CboSuppcd"
        Me.CboSuppcd.Size = New System.Drawing.Size(121, 24)
        Me.CboSuppcd.TabIndex = 169
        '
        'frmJobOrderBarcode
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(889, 505)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.CboSuppcd)
        Me.Controls.Add(Me.dtpJobDate)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtRemark)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.GroupBox6)
        Me.Controls.Add(Me.grdData)
        Me.Controls.Add(Me.txtBarcode)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.btnSearchKI)
        Me.Controls.Add(Me.txtKONo)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cboDocType)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmJobOrderBarcode"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Job Order Barcode"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.grdData, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cboDocType As System.Windows.Forms.ComboBox
    Friend WithEvents btnSearchKI As System.Windows.Forms.Button
    Friend WithEvents txtKONo As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents btnNew As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnSave As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnPrint As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnMinimized As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnExit As System.Windows.Forms.ToolStripButton
    Friend WithEvents txtBarcode As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents grdData As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents txtTotalBox As System.Windows.Forms.TextBox
    Friend WithEvents txtTotalKgNt As System.Windows.Forms.TextBox
    Friend WithEvents txtTotalSpool As System.Windows.Forms.TextBox
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents txtTotalKgGr As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtRemark As System.Windows.Forms.TextBox
    Friend WithEvents id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents itcd As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents sinvno As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents docno As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents docdt As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents grade As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents boxno As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents spools As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents kg_gr As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents kg_nt As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents lotno_our As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents dtpJobDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents CboSuppcd As System.Windows.Forms.ComboBox
End Class
