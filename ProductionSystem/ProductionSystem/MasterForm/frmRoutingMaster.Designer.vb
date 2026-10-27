<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRoutingMaster
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRoutingMaster))
        Me.lblRoutingdesc = New System.Windows.Forms.Label()
        Me.lblRoutingStatus = New System.Windows.Forms.Label()
        Me.btnNew = New System.Windows.Forms.ToolStripButton()
        Me.dgvsMfgRoutingLine = New System.Windows.Forms.DataGridView()
        Me.step_number = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cbomfg_operation_id = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.btnSave = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.lblRoutingcode = New System.Windows.Forms.Label()
        Me.btnMinimized = New System.Windows.Forms.ToolStripButton()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.btnExit = New System.Windows.Forms.ToolStripButton()
        Me.btnSeacthRouting = New System.Windows.Forms.Button()
        Me.txtRoutingCode = New System.Windows.Forms.TextBox()
        Me.txtRoutingDesc = New System.Windows.Forms.TextBox()
        Me.txtRoutingStatus = New System.Windows.Forms.TextBox()
        CType(Me.dgvsMfgRoutingLine, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblRoutingdesc
        '
        Me.lblRoutingdesc.AutoSize = True
        Me.lblRoutingdesc.Location = New System.Drawing.Point(166, 25)
        Me.lblRoutingdesc.Name = "lblRoutingdesc"
        Me.lblRoutingdesc.Size = New System.Drawing.Size(66, 13)
        Me.lblRoutingdesc.TabIndex = 30
        Me.lblRoutingdesc.Text = "Description"
        '
        'lblRoutingStatus
        '
        Me.lblRoutingStatus.AutoSize = True
        Me.lblRoutingStatus.Location = New System.Drawing.Point(424, 24)
        Me.lblRoutingStatus.Name = "lblRoutingStatus"
        Me.lblRoutingStatus.Size = New System.Drawing.Size(39, 13)
        Me.lblRoutingStatus.TabIndex = 31
        Me.lblRoutingStatus.Text = "Status"
        '
        'btnNew
        '
        Me.btnNew.Image = CType(resources.GetObject("btnNew.Image"), System.Drawing.Image)
        Me.btnNew.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnNew.Name = "btnNew"
        Me.btnNew.Size = New System.Drawing.Size(51, 22)
        Me.btnNew.Text = "New"
        '
        'dgvsMfgRoutingLine
        '
        Me.dgvsMfgRoutingLine.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvsMfgRoutingLine.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvsMfgRoutingLine.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.step_number, Me.cbomfg_operation_id})
        Me.dgvsMfgRoutingLine.Location = New System.Drawing.Point(8, 70)
        Me.dgvsMfgRoutingLine.Name = "dgvsMfgRoutingLine"
        Me.dgvsMfgRoutingLine.Size = New System.Drawing.Size(540, 265)
        Me.dgvsMfgRoutingLine.TabIndex = 28
        '
        'step_number
        '
        Me.step_number.DataPropertyName = "step_number"
        Me.step_number.HeaderText = "Step #"
        Me.step_number.Name = "step_number"
        '
        'cbomfg_operation_id
        '
        Me.cbomfg_operation_id.DataPropertyName = "mfg_operation_id"
        Me.cbomfg_operation_id.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.[Nothing]
        Me.cbomfg_operation_id.HeaderText = "Operation"
        Me.cbomfg_operation_id.Name = "cbomfg_operation_id"
        Me.cbomfg_operation_id.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.cbomfg_operation_id.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.cbomfg_operation_id.Width = 150
        '
        'btnSave
        '
        Me.btnSave.Image = CType(resources.GetObject("btnSave.Image"), System.Drawing.Image)
        Me.btnSave.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(51, 22)
        Me.btnSave.Text = "Save"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'lblRoutingcode
        '
        Me.lblRoutingcode.AutoSize = True
        Me.lblRoutingcode.Location = New System.Drawing.Point(5, 25)
        Me.lblRoutingcode.Name = "lblRoutingcode"
        Me.lblRoutingcode.Size = New System.Drawing.Size(80, 13)
        Me.lblRoutingcode.TabIndex = 29
        Me.lblRoutingcode.Text = "Routing code:"
        '
        'btnMinimized
        '
        Me.btnMinimized.Image = CType(resources.GetObject("btnMinimized.Image"), System.Drawing.Image)
        Me.btnMinimized.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnMinimized.Name = "btnMinimized"
        Me.btnMinimized.Size = New System.Drawing.Size(83, 22)
        Me.btnMinimized.Text = "Minimized"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripSeparator1, Me.btnNew, Me.btnSave, Me.btnMinimized, Me.btnExit})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(556, 25)
        Me.ToolStrip1.TabIndex = 27
        '
        'btnExit
        '
        Me.btnExit.Image = CType(resources.GetObject("btnExit.Image"), System.Drawing.Image)
        Me.btnExit.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(45, 22)
        Me.btnExit.Text = "Exit"
        '
        'btnSeacthRouting
        '
        Me.btnSeacthRouting.Image = CType(resources.GetObject("btnSeacthRouting.Image"), System.Drawing.Image)
        Me.btnSeacthRouting.Location = New System.Drawing.Point(135, 41)
        Me.btnSeacthRouting.Name = "btnSeacthRouting"
        Me.btnSeacthRouting.Size = New System.Drawing.Size(28, 23)
        Me.btnSeacthRouting.TabIndex = 271
        Me.btnSeacthRouting.UseVisualStyleBackColor = True
        '
        'txtRoutingCode
        '
        Me.txtRoutingCode.Location = New System.Drawing.Point(8, 42)
        Me.txtRoutingCode.Name = "txtRoutingCode"
        Me.txtRoutingCode.Size = New System.Drawing.Size(121, 22)
        Me.txtRoutingCode.TabIndex = 272
        '
        'txtRoutingDesc
        '
        Me.txtRoutingDesc.Location = New System.Drawing.Point(169, 41)
        Me.txtRoutingDesc.Name = "txtRoutingDesc"
        Me.txtRoutingDesc.Size = New System.Drawing.Size(252, 22)
        Me.txtRoutingDesc.TabIndex = 273
        '
        'txtRoutingStatus
        '
        Me.txtRoutingStatus.Enabled = False
        Me.txtRoutingStatus.Location = New System.Drawing.Point(427, 41)
        Me.txtRoutingStatus.Name = "txtRoutingStatus"
        Me.txtRoutingStatus.ReadOnly = True
        Me.txtRoutingStatus.Size = New System.Drawing.Size(121, 22)
        Me.txtRoutingStatus.TabIndex = 274
        '
        'frmRoutingMaster
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(556, 341)
        Me.Controls.Add(Me.txtRoutingStatus)
        Me.Controls.Add(Me.txtRoutingDesc)
        Me.Controls.Add(Me.txtRoutingCode)
        Me.Controls.Add(Me.btnSeacthRouting)
        Me.Controls.Add(Me.lblRoutingdesc)
        Me.Controls.Add(Me.lblRoutingStatus)
        Me.Controls.Add(Me.dgvsMfgRoutingLine)
        Me.Controls.Add(Me.lblRoutingcode)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "frmRoutingMaster"
        Me.Text = "Routing Master"
        CType(Me.dgvsMfgRoutingLine, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblRoutingdesc As System.Windows.Forms.Label
    Friend WithEvents lblRoutingStatus As System.Windows.Forms.Label
    Friend WithEvents btnNew As System.Windows.Forms.ToolStripButton
    Friend WithEvents dgvsMfgRoutingLine As System.Windows.Forms.DataGridView
    Friend WithEvents btnSave As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents lblRoutingcode As System.Windows.Forms.Label
    Friend WithEvents btnMinimized As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents btnExit As System.Windows.Forms.ToolStripButton
    Friend WithEvents step_number As DataGridViewTextBoxColumn
    Friend WithEvents cboMfgOperationId As DataGridViewComboBoxColumn
    Friend WithEvents btnSeacthRouting As Button
    Friend WithEvents txtRoutingCode As TextBox
    Friend WithEvents txtRoutingDesc As TextBox
    Friend WithEvents txtRoutingStatus As TextBox
    Friend WithEvents cbomfg_operation_id As DataGridViewComboBoxColumn
End Class
