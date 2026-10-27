<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DlgGetMasterCode
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.grdData = New System.Windows.Forms.DataGridView()
        Me.MasterCode = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MasterEDescp = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MasterTDescp = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblSearchWording = New System.Windows.Forms.Label()
        Me.txtWordFilter = New System.Windows.Forms.TextBox()
        Me.btnOK = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        CType(Me.grdData, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.grdData)
        Me.GroupBox1.Location = New System.Drawing.Point(5, 64)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(660, 279)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        '
        'grdData
        '
        Me.grdData.AllowUserToAddRows = False
        Me.grdData.AllowUserToDeleteRows = False
        Me.grdData.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grdData.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.grdData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdData.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.MasterCode, Me.MasterEDescp, Me.MasterTDescp})
        Me.grdData.Location = New System.Drawing.Point(9, 18)
        Me.grdData.Name = "grdData"
        Me.grdData.ReadOnly = True
        Me.grdData.Size = New System.Drawing.Size(645, 255)
        Me.grdData.TabIndex = 0
        '
        'MasterCode
        '
        Me.MasterCode.DataPropertyName = "MasterCode"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.MasterCode.DefaultCellStyle = DataGridViewCellStyle2
        Me.MasterCode.HeaderText = "Code"
        Me.MasterCode.Name = "MasterCode"
        Me.MasterCode.ReadOnly = True
        '
        'MasterEDescp
        '
        Me.MasterEDescp.DataPropertyName = "MasterEDescp"
        Me.MasterEDescp.HeaderText = "Description (E)"
        Me.MasterEDescp.Name = "MasterEDescp"
        Me.MasterEDescp.ReadOnly = True
        Me.MasterEDescp.Width = 250
        '
        'MasterTDescp
        '
        Me.MasterTDescp.DataPropertyName = "MasterTDescp"
        Me.MasterTDescp.HeaderText = "Description (T)"
        Me.MasterTDescp.Name = "MasterTDescp"
        Me.MasterTDescp.ReadOnly = True
        Me.MasterTDescp.Width = 250
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.lblSearchWording)
        Me.GroupBox2.Controls.Add(Me.txtWordFilter)
        Me.GroupBox2.Location = New System.Drawing.Point(5, 7)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(327, 52)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Wording To Search"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(84, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(10, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = ":"
        '
        'lblSearchWording
        '
        Me.lblSearchWording.AutoSize = True
        Me.lblSearchWording.Location = New System.Drawing.Point(28, 22)
        Me.lblSearchWording.Name = "lblSearchWording"
        Me.lblSearchWording.Size = New System.Drawing.Size(47, 13)
        Me.lblSearchWording.TabIndex = 1
        Me.lblSearchWording.Text = "Wording"
        '
        'txtWordFilter
        '
        Me.txtWordFilter.Location = New System.Drawing.Point(102, 19)
        Me.txtWordFilter.Name = "txtWordFilter"
        Me.txtWordFilter.Size = New System.Drawing.Size(203, 20)
        Me.txtWordFilter.TabIndex = 0
        '
        'btnOK
        '
        Me.btnOK.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnOK.Location = New System.Drawing.Point(514, 358)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(71, 22)
        Me.btnOK.TabIndex = 3
        Me.btnOK.Text = "OK"
        Me.btnOK.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCancel.Location = New System.Drawing.Point(591, 358)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(71, 22)
        Me.btnCancel.TabIndex = 4
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'DlgGetMasterCode
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(673, 390)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnOK)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "DlgGetMasterCode"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Get Master Code"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.grdData, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents grdData As DataGridView
    Friend WithEvents MasterCode As DataGridViewTextBoxColumn
    Friend WithEvents MasterEDescp As DataGridViewTextBoxColumn
    Friend WithEvents MasterTDescp As DataGridViewTextBoxColumn
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents lblSearchWording As Label
    Friend WithEvents txtWordFilter As TextBox
    Friend WithEvents btnOK As Button
    Friend WithEvents btnCancel As Button
    Friend WithEvents Label1 As Label
End Class
