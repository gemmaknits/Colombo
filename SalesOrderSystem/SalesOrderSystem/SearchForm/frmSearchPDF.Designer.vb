<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSearchPDF
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSearchPDF))
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.btnRefresh = New System.Windows.Forms.ToolStripButton()
        Me.btnMinimized = New System.Windows.Forms.ToolStripButton()
        Me.btnExit = New System.Windows.Forms.ToolStripButton()
        Me.grdData = New System.Windows.Forms.DataGridView()
        Me.poc_pdf_header_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.pdf_number = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.pdf_date = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.plan_out_date = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.poc_so_lines_ext_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.sonoid = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.custname = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtSoNoID = New System.Windows.Forms.TextBox()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.grdData, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnRefresh, Me.btnMinimized, Me.btnExit})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(805, 25)
        Me.ToolStrip1.TabIndex = 17
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
        'grdData
        '
        Me.grdData.AllowUserToAddRows = False
        Me.grdData.AllowUserToDeleteRows = False
        Me.grdData.AllowUserToOrderColumns = True
        Me.grdData.BackgroundColor = System.Drawing.Color.PeachPuff
        Me.grdData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdData.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.poc_pdf_header_id, Me.pdf_number, Me.pdf_date, Me.plan_out_date, Me.poc_so_lines_ext_id, Me.sonoid, Me.custname})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.grdData.DefaultCellStyle = DataGridViewCellStyle2
        Me.grdData.Location = New System.Drawing.Point(12, 85)
        Me.grdData.Name = "grdData"
        Me.grdData.ReadOnly = True
        Me.grdData.Size = New System.Drawing.Size(781, 240)
        Me.grdData.TabIndex = 16
        '
        'poc_pdf_header_id
        '
        Me.poc_pdf_header_id.DataPropertyName = "poc_pdf_header_id"
        Me.poc_pdf_header_id.HeaderText = "PDF Header ID"
        Me.poc_pdf_header_id.Name = "poc_pdf_header_id"
        Me.poc_pdf_header_id.ReadOnly = True
        Me.poc_pdf_header_id.Width = 85
        '
        'pdf_number
        '
        Me.pdf_number.DataPropertyName = "pdf_number"
        Me.pdf_number.HeaderText = "PDF No."
        Me.pdf_number.Name = "pdf_number"
        Me.pdf_number.ReadOnly = True
        Me.pdf_number.Width = 85
        '
        'pdf_date
        '
        Me.pdf_date.DataPropertyName = "pdf_date"
        Me.pdf_date.HeaderText = "PFD Date."
        Me.pdf_date.Name = "pdf_date"
        Me.pdf_date.ReadOnly = True
        Me.pdf_date.Width = 150
        '
        'plan_out_date
        '
        Me.plan_out_date.DataPropertyName = "plan_out_date"
        Me.plan_out_date.HeaderText = "Plan Out Date."
        Me.plan_out_date.Name = "plan_out_date"
        Me.plan_out_date.ReadOnly = True
        '
        'poc_so_lines_ext_id
        '
        Me.poc_so_lines_ext_id.DataPropertyName = "poc_so_lines_ext_id"
        Me.poc_so_lines_ext_id.HeaderText = "S/O lines Ext ID"
        Me.poc_so_lines_ext_id.Name = "poc_so_lines_ext_id"
        Me.poc_so_lines_ext_id.ReadOnly = True
        '
        'sonoid
        '
        Me.sonoid.DataPropertyName = "sonoid"
        Me.sonoid.HeaderText = "S/O No. ID"
        Me.sonoid.Name = "sonoid"
        Me.sonoid.ReadOnly = True
        '
        'custname
        '
        Me.custname.DataPropertyName = "custname"
        Me.custname.HeaderText = "Cust. Name"
        Me.custname.Name = "custname"
        Me.custname.ReadOnly = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(16, 41)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(61, 13)
        Me.Label4.TabIndex = 19
        Me.Label4.Text = "S/O No. ID"
        '
        'txtSoNoID
        '
        Me.txtSoNoID.Location = New System.Drawing.Point(93, 38)
        Me.txtSoNoID.Name = "txtSoNoID"
        Me.txtSoNoID.ReadOnly = True
        Me.txtSoNoID.Size = New System.Drawing.Size(131, 20)
        Me.txtSoNoID.TabIndex = 18
        '
        'frmSearchPDF
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(805, 337)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtSoNoID)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.grdData)
        Me.Name = "frmSearchPDF"
        Me.Text = "Search PDF"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.grdData, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents btnRefresh As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnMinimized As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnExit As System.Windows.Forms.ToolStripButton
    Friend WithEvents grdData As System.Windows.Forms.DataGridView
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtSoNoID As System.Windows.Forms.TextBox
    Friend WithEvents poc_pdf_header_id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents pdf_number As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents pdf_date As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents plan_out_date As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents poc_so_lines_ext_id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents sonoid As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents custname As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
