<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSearchDR
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSearchDR))
        Me.grddata = New System.Windows.Forms.DataGridView()
        Me.btnRefresh2 = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtDesign_no = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtDrNo = New System.Windows.Forms.TextBox()
        Me.id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.new_design_no = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dr_no = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dr_date = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.bom_usage_name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ynperc = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.grddata, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'grddata
        '
        Me.grddata.AllowUserToAddRows = False
        Me.grddata.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grddata.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id, Me.new_design_no, Me.dr_no, Me.dr_date, Me.bom_usage_name, Me.ynperc})
        Me.grddata.Location = New System.Drawing.Point(18, 123)
        Me.grddata.Name = "grddata"
        Me.grddata.Size = New System.Drawing.Size(495, 270)
        Me.grddata.TabIndex = 39
        '
        'btnRefresh2
        '
        Me.btnRefresh2.Image = CType(resources.GetObject("btnRefresh2.Image"), System.Drawing.Image)
        Me.btnRefresh2.Location = New System.Drawing.Point(441, 28)
        Me.btnRefresh2.Name = "btnRefresh2"
        Me.btnRefresh2.Size = New System.Drawing.Size(72, 32)
        Me.btnRefresh2.TabIndex = 41
        Me.btnRefresh2.Text = "&Refresh"
        Me.btnRefresh2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnRefresh2.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtDrNo)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtDesign_no)
        Me.GroupBox1.Location = New System.Drawing.Point(18, 28)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(267, 72)
        Me.GroupBox1.TabIndex = 40
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Filter"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(21, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(60, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Design No."
        '
        'txtDesign_no
        '
        Me.txtDesign_no.Location = New System.Drawing.Point(97, 19)
        Me.txtDesign_no.Name = "txtDesign_no"
        Me.txtDesign_no.Size = New System.Drawing.Size(132, 20)
        Me.txtDesign_no.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(21, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(43, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "DR No."
        '
        'txtDrNo
        '
        Me.txtDrNo.Location = New System.Drawing.Point(97, 45)
        Me.txtDrNo.Name = "txtDrNo"
        Me.txtDrNo.Size = New System.Drawing.Size(132, 20)
        Me.txtDrNo.TabIndex = 4
        '
        'id
        '
        Me.id.DataPropertyName = "id"
        Me.id.HeaderText = "id"
        Me.id.Name = "id"
        Me.id.Visible = False
        '
        'new_design_no
        '
        Me.new_design_no.DataPropertyName = "new_design_no"
        Me.new_design_no.HeaderText = "New Design No."
        Me.new_design_no.Name = "new_design_no"
        '
        'dr_no
        '
        Me.dr_no.DataPropertyName = "dr_no"
        Me.dr_no.HeaderText = "DR No."
        Me.dr_no.Name = "dr_no"
        '
        'dr_date
        '
        Me.dr_date.DataPropertyName = "dr_date"
        Me.dr_date.HeaderText = "DATE"
        Me.dr_date.Name = "dr_date"
        '
        'bom_usage_name
        '
        Me.bom_usage_name.DataPropertyName = "bom_usage_name"
        Me.bom_usage_name.HeaderText = "Bom Usage"
        Me.bom_usage_name.Name = "bom_usage_name"
        '
        'ynperc
        '
        Me.ynperc.DataPropertyName = "ynperc"
        Me.ynperc.HeaderText = "Total Proportion"
        Me.ynperc.Name = "ynperc"
        '
        'frmSearchDR
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(531, 420)
        Me.Controls.Add(Me.grddata)
        Me.Controls.Add(Me.btnRefresh2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmSearchDR"
        Me.Text = "Search D/R"
        CType(Me.grddata, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents grddata As System.Windows.Forms.DataGridView
    Friend WithEvents btnRefresh2 As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtDesign_no As System.Windows.Forms.TextBox
    Friend WithEvents id As DataGridViewTextBoxColumn
    Friend WithEvents new_design_no As DataGridViewTextBoxColumn
    Friend WithEvents dr_no As DataGridViewTextBoxColumn
    Friend WithEvents dr_date As DataGridViewTextBoxColumn
    Friend WithEvents bom_usage_name As DataGridViewTextBoxColumn
    Friend WithEvents ynperc As DataGridViewTextBoxColumn
    Friend WithEvents Label2 As Label
    Friend WithEvents txtDrNo As TextBox
End Class
