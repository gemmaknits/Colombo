<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmOperationsMaster
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmOperationsMaster))
        Me.cbooperation_name = New System.Windows.Forms.ComboBox()
        Me.cbomfg_operations_id = New System.Windows.Forms.ComboBox()
        Me.lblOperatioName = New System.Windows.Forms.Label()
        Me.lblOperationCode = New System.Windows.Forms.Label()
        Me.grddata = New System.Windows.Forms.DataGridView()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnSave = New System.Windows.Forms.ToolStripButton()
        Me.btnMinimized = New System.Windows.Forms.ToolStripButton()
        Me.btnExit = New System.Windows.Forms.ToolStripButton()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.operation_code = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OPERNAME = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.grddata, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'cbooperation_name
        '
        Me.cbooperation_name.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple
        Me.cbooperation_name.Enabled = False
        Me.cbooperation_name.FormattingEnabled = True
        Me.cbooperation_name.Location = New System.Drawing.Point(139, 52)
        Me.cbooperation_name.Name = "cbooperation_name"
        Me.cbooperation_name.Size = New System.Drawing.Size(121, 20)
        Me.cbooperation_name.TabIndex = 25
        '
        'cbomfg_operations_id
        '
        Me.cbomfg_operations_id.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple
        Me.cbomfg_operations_id.Enabled = False
        Me.cbomfg_operations_id.FormattingEnabled = True
        Me.cbomfg_operations_id.Location = New System.Drawing.Point(12, 52)
        Me.cbomfg_operations_id.Name = "cbomfg_operations_id"
        Me.cbomfg_operations_id.Size = New System.Drawing.Size(121, 20)
        Me.cbomfg_operations_id.TabIndex = 24
        '
        'lblOperatioName
        '
        Me.lblOperatioName.AutoSize = True
        Me.lblOperatioName.Location = New System.Drawing.Point(140, 33)
        Me.lblOperatioName.Name = "lblOperatioName"
        Me.lblOperatioName.Size = New System.Drawing.Size(98, 13)
        Me.lblOperatioName.TabIndex = 23
        Me.lblOperatioName.Text = "Operation Name :"
        '
        'lblOperationCode
        '
        Me.lblOperationCode.AutoSize = True
        Me.lblOperationCode.Location = New System.Drawing.Point(9, 33)
        Me.lblOperationCode.Name = "lblOperationCode"
        Me.lblOperationCode.Size = New System.Drawing.Size(96, 13)
        Me.lblOperationCode.TabIndex = 22
        Me.lblOperationCode.Text = "Operation Code :"
        '
        'grddata
        '
        Me.grddata.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.grddata.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grddata.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.operation_code, Me.OPERNAME})
        Me.grddata.Location = New System.Drawing.Point(12, 80)
        Me.grddata.Name = "grddata"
        Me.grddata.Size = New System.Drawing.Size(540, 214)
        Me.grddata.TabIndex = 21
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'btnSave
        '
        Me.btnSave.Image = CType(resources.GetObject("btnSave.Image"), System.Drawing.Image)
        Me.btnSave.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(51, 22)
        Me.btnSave.Text = "Save"
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
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripSeparator1, Me.btnSave, Me.btnMinimized, Me.btnExit})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(622, 25)
        Me.ToolStrip1.TabIndex = 20
        '
        'operation_code
        '
        Me.operation_code.DataPropertyName = "operation_code"
        Me.operation_code.HeaderText = "Operation Code"
        Me.operation_code.Name = "operation_code"
        '
        'OPERNAME
        '
        Me.OPERNAME.DataPropertyName = "operation_name"
        Me.OPERNAME.HeaderText = "Operation Name"
        Me.OPERNAME.Name = "OPERNAME"
        '
        'frmOperationsMaster
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(622, 302)
        Me.Controls.Add(Me.cbooperation_name)
        Me.Controls.Add(Me.cbomfg_operations_id)
        Me.Controls.Add(Me.lblOperatioName)
        Me.Controls.Add(Me.lblOperationCode)
        Me.Controls.Add(Me.grddata)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "frmOperationsMaster"
        Me.Text = "Operations Master"
        CType(Me.grddata, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cbooperation_name As System.Windows.Forms.ComboBox
    Friend WithEvents cbomfg_operations_id As System.Windows.Forms.ComboBox
    Friend WithEvents lblOperatioName As System.Windows.Forms.Label
    Friend WithEvents lblOperationCode As System.Windows.Forms.Label
    Friend WithEvents grddata As System.Windows.Forms.DataGridView
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnSave As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnMinimized As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnExit As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents operation_code As DataGridViewTextBoxColumn
    Friend WithEvents OPERNAME As DataGridViewTextBoxColumn
End Class
