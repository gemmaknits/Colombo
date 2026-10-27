<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmSearchBomVersion
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.lbDesignNo = New System.Windows.Forms.Label()
        Me.grddata = New System.Windows.Forms.DataGridView()
        Me.cboItcd = New System.Windows.Forms.ComboBox()
        Me.CboColor = New System.Windows.Forms.ComboBox()
        Me.lbColor = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DesignNo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Ynchgdt = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colorwaycode = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.bomversionno = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.idyarnchange = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.grddata, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lbDesignNo
        '
        Me.lbDesignNo.AutoSize = True
        Me.lbDesignNo.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbDesignNo.Location = New System.Drawing.Point(15, 37)
        Me.lbDesignNo.Name = "lbDesignNo"
        Me.lbDesignNo.Size = New System.Drawing.Size(50, 13)
        Me.lbDesignNo.TabIndex = 5
        Me.lbDesignNo.Text = "Item No."
        '
        'grddata
        '
        Me.grddata.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grddata.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id, Me.DesignNo, Me.Ynchgdt, Me.colorwaycode, Me.bomversionno, Me.idyarnchange})
        Me.grddata.Location = New System.Drawing.Point(34, 117)
        Me.grddata.Name = "grddata"
        Me.grddata.Size = New System.Drawing.Size(495, 270)
        Me.grddata.TabIndex = 40
        '
        'cboItcd
        '
        Me.cboItcd.FormattingEnabled = True
        Me.cboItcd.Location = New System.Drawing.Point(95, 29)
        Me.cboItcd.Name = "cboItcd"
        Me.cboItcd.Size = New System.Drawing.Size(121, 21)
        Me.cboItcd.TabIndex = 41
        '
        'CboColor
        '
        Me.CboColor.FormattingEnabled = True
        Me.CboColor.Location = New System.Drawing.Point(337, 29)
        Me.CboColor.Name = "CboColor"
        Me.CboColor.Size = New System.Drawing.Size(121, 21)
        Me.CboColor.TabIndex = 42
        '
        'lbColor
        '
        Me.lbColor.AutoSize = True
        Me.lbColor.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbColor.Location = New System.Drawing.Point(262, 37)
        Me.lbColor.Name = "lbColor"
        Me.lbColor.Size = New System.Drawing.Size(56, 13)
        Me.lbColor.TabIndex = 43
        Me.lbColor.Text = "Color No."
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cboItcd)
        Me.GroupBox1.Controls.Add(Me.lbColor)
        Me.GroupBox1.Controls.Add(Me.lbDesignNo)
        Me.GroupBox1.Controls.Add(Me.CboColor)
        Me.GroupBox1.Location = New System.Drawing.Point(34, 25)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(495, 72)
        Me.GroupBox1.TabIndex = 44
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Filter Detail"
        '
        'id
        '
        Me.id.DataPropertyName = "id"
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.id.DefaultCellStyle = DataGridViewCellStyle1
        Me.id.HeaderText = "id"
        Me.id.Name = "id"
        Me.id.Visible = False
        '
        'DesignNo
        '
        Me.DesignNo.DataPropertyName = "design_no"
        Me.DesignNo.HeaderText = "Design No."
        Me.DesignNo.Name = "DesignNo"
        '
        'Ynchgdt
        '
        Me.Ynchgdt.DataPropertyName = "ynchgdt"
        Me.Ynchgdt.HeaderText = "DATE"
        Me.Ynchgdt.Name = "Ynchgdt"
        '
        'colorwaycode
        '
        Me.colorwaycode.DataPropertyName = "color_way_code"
        Me.colorwaycode.HeaderText = "Color Way Code"
        Me.colorwaycode.Name = "colorwaycode"
        '
        'bomversionno
        '
        Me.bomversionno.DataPropertyName = "bom_version_no"
        Me.bomversionno.HeaderText = "Bom Version"
        Me.bomversionno.Name = "bomversionno"
        '
        'idyarnchange
        '
        Me.idyarnchange.DataPropertyName = "id_yarnchange"
        Me.idyarnchange.HeaderText = "Bom Version ID"
        Me.idyarnchange.Name = "idyarnchange"
        Me.idyarnchange.Visible = False
        '
        'frmSearchBomVersion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(560, 399)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.grddata)
        Me.Name = "frmSearchBomVersion"
        Me.Text = "Search Bom Version"
        CType(Me.grddata, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lbDesignNo As Label
    Friend WithEvents grddata As DataGridView
    Friend WithEvents cboItcd As ComboBox
    Friend WithEvents CboColor As ComboBox
    Friend WithEvents lbColor As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents id As DataGridViewTextBoxColumn
    Friend WithEvents DesignNo As DataGridViewTextBoxColumn
    Friend WithEvents Ynchgdt As DataGridViewTextBoxColumn
    Friend WithEvents colorwaycode As DataGridViewTextBoxColumn
    Friend WithEvents bomversionno As DataGridViewTextBoxColumn
    Friend WithEvents idyarnchange As DataGridViewTextBoxColumn
End Class
