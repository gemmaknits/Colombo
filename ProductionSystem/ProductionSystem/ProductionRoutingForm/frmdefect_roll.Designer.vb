<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmdefect_roll
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
        Me.GbDefect = New System.Windows.Forms.GroupBox()
        Me.btnApply = New System.Windows.Forms.Button()
        Me.lbldefect_details = New System.Windows.Forms.Label()
        Me.txtdefect_details = New System.Windows.Forms.TextBox()
        Me.lblDefect_code = New System.Windows.Forms.Label()
        Me.cbodefect_code = New System.Windows.Forms.ComboBox()
        Me.grdDefect = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.defect_code = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.Defect_name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.defect_details = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.stock_code = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GbDefect.SuspendLayout()
        CType(Me.grdDefect, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GbDefect
        '
        Me.GbDefect.Controls.Add(Me.btnApply)
        Me.GbDefect.Controls.Add(Me.lbldefect_details)
        Me.GbDefect.Controls.Add(Me.txtdefect_details)
        Me.GbDefect.Controls.Add(Me.lblDefect_code)
        Me.GbDefect.Controls.Add(Me.cbodefect_code)
        Me.GbDefect.Controls.Add(Me.grdDefect)
        Me.GbDefect.Location = New System.Drawing.Point(12, 21)
        Me.GbDefect.Name = "GbDefect"
        Me.GbDefect.Size = New System.Drawing.Size(338, 212)
        Me.GbDefect.TabIndex = 535
        Me.GbDefect.TabStop = False
        Me.GbDefect.Text = "Defect Detail"
        '
        'btnApply
        '
        Me.btnApply.Location = New System.Drawing.Point(267, 164)
        Me.btnApply.Name = "btnApply"
        Me.btnApply.Size = New System.Drawing.Size(57, 23)
        Me.btnApply.TabIndex = 437
        Me.btnApply.Text = "Apply"
        Me.btnApply.UseVisualStyleBackColor = True
        '
        'lbldefect_details
        '
        Me.lbldefect_details.AutoSize = True
        Me.lbldefect_details.Location = New System.Drawing.Point(195, 163)
        Me.lbldefect_details.Name = "lbldefect_details"
        Me.lbldefect_details.Size = New System.Drawing.Size(34, 13)
        Me.lbldefect_details.TabIndex = 436
        Me.lbldefect_details.Text = "Detail"
        '
        'txtdefect_details
        '
        Me.txtdefect_details.Location = New System.Drawing.Point(235, 166)
        Me.txtdefect_details.Name = "txtdefect_details"
        Me.txtdefect_details.Size = New System.Drawing.Size(21, 20)
        Me.txtdefect_details.TabIndex = 435
        '
        'lblDefect_code
        '
        Me.lblDefect_code.AutoSize = True
        Me.lblDefect_code.Location = New System.Drawing.Point(7, 163)
        Me.lblDefect_code.Name = "lblDefect_code"
        Me.lblDefect_code.Size = New System.Drawing.Size(52, 13)
        Me.lblDefect_code.TabIndex = 434
        Me.lblDefect_code.Text = "Def Code"
        '
        'cbodefect_code
        '
        Me.cbodefect_code.FormattingEnabled = True
        Me.cbodefect_code.Location = New System.Drawing.Point(65, 164)
        Me.cbodefect_code.Name = "cbodefect_code"
        Me.cbodefect_code.Size = New System.Drawing.Size(100, 21)
        Me.cbodefect_code.TabIndex = 433
        '
        'grdDefect
        '
        Me.grdDefect.AllowUserToAddRows = False
        Me.grdDefect.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grdDefect.BackgroundColor = System.Drawing.Color.PeachPuff
        Me.grdDefect.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdDefect.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn3, Me.defect_code, Me.Defect_name, Me.defect_details, Me.stock_code})
        Me.grdDefect.Location = New System.Drawing.Point(27, 19)
        Me.grdDefect.Name = "grdDefect"
        Me.grdDefect.Size = New System.Drawing.Size(297, 128)
        Me.grdDefect.TabIndex = 432
        Me.grdDefect.TabStop = False
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "roll_no"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Roll No."
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.Visible = False
        '
        'defect_code
        '
        Me.defect_code.DataPropertyName = "defect_code"
        Me.defect_code.HeaderText = "Defect Code"
        Me.defect_code.Name = "defect_code"
        Me.defect_code.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.defect_code.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.defect_code.Width = 120
        '
        'Defect_name
        '
        Me.Defect_name.DataPropertyName = "Defect_name"
        Me.Defect_name.HeaderText = "Defect Name"
        Me.Defect_name.Name = "Defect_name"
        Me.Defect_name.ReadOnly = True
        Me.Defect_name.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Defect_name.Visible = False
        '
        'defect_details
        '
        Me.defect_details.DataPropertyName = "defect_details"
        Me.defect_details.HeaderText = "Detail"
        Me.defect_details.Name = "defect_details"
        Me.defect_details.Width = 90
        '
        'stock_code
        '
        Me.stock_code.DataPropertyName = "stock_code"
        Me.stock_code.HeaderText = "Stock Code"
        Me.stock_code.Name = "stock_code"
        Me.stock_code.Visible = False
        '
        'frmdefect_roll
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(381, 247)
        Me.Controls.Add(Me.GbDefect)
        Me.Name = "frmdefect_roll"
        Me.Text = "Defect"
        Me.GbDefect.ResumeLayout(False)
        Me.GbDefect.PerformLayout()
        CType(Me.grdDefect, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GbDefect As System.Windows.Forms.GroupBox
    Friend WithEvents btnApply As System.Windows.Forms.Button
    Friend WithEvents lbldefect_details As System.Windows.Forms.Label
    Friend WithEvents txtdefect_details As System.Windows.Forms.TextBox
    Friend WithEvents lblDefect_code As System.Windows.Forms.Label
    Friend WithEvents cbodefect_code As System.Windows.Forms.ComboBox
    Friend WithEvents grdDefect As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents defect_code As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents Defect_name As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents defect_details As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents stock_code As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
