<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSearchItems
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSearchItems))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.btnRefresh2 = New System.Windows.Forms.Button()
        Me.txtDesign_no = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.grddata = New System.Windows.Forms.DataGridView()
        Me.id_yarnchange = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Design_no = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ynchgcd = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColorCode = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColorWay = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.yarndate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.bom_usage_name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ynperc = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.id_yarnchangedet = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.itcd = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.itdesc = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colReqdQty = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colUom = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.suppcd = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.bomversionid = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox1.SuspendLayout()
        CType(Me.grddata, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnRefresh2
        '
        Me.btnRefresh2.Image = CType(resources.GetObject("btnRefresh2.Image"), System.Drawing.Image)
        Me.btnRefresh2.Location = New System.Drawing.Point(316, 18)
        Me.btnRefresh2.Name = "btnRefresh2"
        Me.btnRefresh2.Size = New System.Drawing.Size(72, 32)
        Me.btnRefresh2.TabIndex = 38
        Me.btnRefresh2.Text = "&Refresh"
        Me.btnRefresh2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnRefresh2.UseVisualStyleBackColor = True
        '
        'txtDesign_no
        '
        Me.txtDesign_no.Location = New System.Drawing.Point(108, 20)
        Me.txtDesign_no.Name = "txtDesign_no"
        Me.txtDesign_no.Size = New System.Drawing.Size(132, 20)
        Me.txtDesign_no.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(32, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(60, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Design No."
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtDesign_no)
        Me.GroupBox1.Location = New System.Drawing.Point(18, 5)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(267, 55)
        Me.GroupBox1.TabIndex = 37
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Filter"
        '
        'grddata
        '
        Me.grddata.AllowUserToAddRows = False
        Me.grddata.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grddata.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.grddata.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grddata.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id_yarnchange, Me.Design_no, Me.ynchgcd, Me.ColorCode, Me.ColorWay, Me.yarndate, Me.bom_usage_name, Me.ynperc})
        Me.grddata.Location = New System.Drawing.Point(18, 74)
        Me.grddata.Name = "grddata"
        Me.grddata.Size = New System.Drawing.Size(970, 270)
        Me.grddata.TabIndex = 36
        '
        'id_yarnchange
        '
        Me.id_yarnchange.DataPropertyName = "id_yarnchange"
        Me.id_yarnchange.HeaderText = "id_yarnchange"
        Me.id_yarnchange.Name = "id_yarnchange"
        Me.id_yarnchange.Visible = False
        '
        'Design_no
        '
        Me.Design_no.DataPropertyName = "Design_no"
        Me.Design_no.HeaderText = "Design_no"
        Me.Design_no.Name = "Design_no"
        Me.Design_no.Width = 160
        '
        'ynchgcd
        '
        Me.ynchgcd.DataPropertyName = "ynchgcd"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.ynchgcd.DefaultCellStyle = DataGridViewCellStyle2
        Me.ynchgcd.HeaderText = "BOM"
        Me.ynchgcd.Name = "ynchgcd"
        Me.ynchgcd.Width = 60
        '
        'ColorCode
        '
        Me.ColorCode.DataPropertyName = "col"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.ColorCode.DefaultCellStyle = DataGridViewCellStyle3
        Me.ColorCode.HeaderText = "ColorCode"
        Me.ColorCode.Name = "ColorCode"
        Me.ColorCode.Width = 110
        '
        'ColorWay
        '
        Me.ColorWay.DataPropertyName = "color_way_code"
        Me.ColorWay.HeaderText = "Color Way"
        Me.ColorWay.Name = "ColorWay"
        Me.ColorWay.Width = 240
        '
        'yarndate
        '
        Me.yarndate.DataPropertyName = "ynchgdtwithformat"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.yarndate.DefaultCellStyle = DataGridViewCellStyle4
        Me.yarndate.HeaderText = "Date"
        Me.yarndate.Name = "yarndate"
        Me.yarndate.ReadOnly = True
        Me.yarndate.Width = 70
        '
        'bom_usage_name
        '
        Me.bom_usage_name.DataPropertyName = "bom_usage_name"
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.bom_usage_name.DefaultCellStyle = DataGridViewCellStyle5
        Me.bom_usage_name.HeaderText = "Bom Usage"
        Me.bom_usage_name.Name = "bom_usage_name"
        '
        'ynperc
        '
        Me.ynperc.DataPropertyName = "ynperc"
        Me.ynperc.HeaderText = "Total Proportion"
        Me.ynperc.Name = "ynperc"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.DataGridView1.ColumnHeadersHeight = 35
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id_yarnchangedet, Me.itcd, Me.itdesc, Me.DataGridViewTextBoxColumn1, Me.colReqdQty, Me.colUom, Me.suppcd, Me.bomversionid})
        DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle12.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView1.DefaultCellStyle = DataGridViewCellStyle12
        Me.DataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter
        Me.DataGridView1.Location = New System.Drawing.Point(18, 350)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersWidth = 25
        Me.DataGridView1.RowTemplate.Height = 30
        Me.DataGridView1.Size = New System.Drawing.Size(970, 192)
        Me.DataGridView1.TabIndex = 201
        '
        'id_yarnchangedet
        '
        Me.id_yarnchangedet.DataPropertyName = "id_yarnchangedet"
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.Khaki
        Me.id_yarnchangedet.DefaultCellStyle = DataGridViewCellStyle7
        Me.id_yarnchangedet.HeaderText = "ID"
        Me.id_yarnchangedet.Name = "id_yarnchangedet"
        Me.id_yarnchangedet.ReadOnly = True
        Me.id_yarnchangedet.Visible = False
        '
        'itcd
        '
        Me.itcd.DataPropertyName = "itcd"
        Me.itcd.HeaderText = "Item Code "
        Me.itcd.Name = "itcd"
        Me.itcd.ReadOnly = True
        Me.itcd.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.itcd.Width = 150
        '
        'itdesc
        '
        Me.itdesc.DataPropertyName = "itdesc"
        Me.itdesc.HeaderText = "Description"
        Me.itdesc.Name = "itdesc"
        Me.itdesc.ReadOnly = True
        Me.itdesc.Width = 290
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "ynperc"
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.DataGridViewTextBoxColumn1.DefaultCellStyle = DataGridViewCellStyle8
        Me.DataGridViewTextBoxColumn1.HeaderText = "%"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Width = 50
        '
        'colReqdQty
        '
        Me.colReqdQty.DataPropertyName = "rqdet_qty"
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.colReqdQty.DefaultCellStyle = DataGridViewCellStyle9
        Me.colReqdQty.HeaderText = "Reqd. Qty"
        Me.colReqdQty.Name = "colReqdQty"
        Me.colReqdQty.ReadOnly = True
        Me.colReqdQty.Width = 80
        '
        'colUom
        '
        Me.colUom.DataPropertyName = "rqdet_uom_name"
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.colUom.DefaultCellStyle = DataGridViewCellStyle10
        Me.colUom.HeaderText = "Uom"
        Me.colUom.Name = "colUom"
        Me.colUom.ReadOnly = True
        Me.colUom.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.colUom.Width = 60
        '
        'suppcd
        '
        Me.suppcd.DataPropertyName = "suppname"
        Me.suppcd.HeaderText = "Supplier"
        Me.suppcd.Name = "suppcd"
        Me.suppcd.ReadOnly = True
        Me.suppcd.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.suppcd.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.suppcd.Width = 250
        '
        'bomversionid
        '
        Me.bomversionid.DataPropertyName = "bom_version_id"
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.bomversionid.DefaultCellStyle = DataGridViewCellStyle11
        Me.bomversionid.HeaderText = "Bom Version"
        Me.bomversionid.Name = "bomversionid"
        Me.bomversionid.ReadOnly = True
        Me.bomversionid.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.bomversionid.Width = 60
        '
        'frmSearchItems
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(997, 547)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.grddata)
        Me.Controls.Add(Me.btnRefresh2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmSearchItems"
        Me.Text = "Search Design BOM"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.grddata, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnRefresh2 As System.Windows.Forms.Button
    Friend WithEvents txtDesign_no As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents grddata As DataGridView
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents id_yarnchange As DataGridViewTextBoxColumn
    Friend WithEvents Design_no As DataGridViewTextBoxColumn
    Friend WithEvents ynchgcd As DataGridViewTextBoxColumn
    Friend WithEvents ColorCode As DataGridViewTextBoxColumn
    Friend WithEvents ColorWay As DataGridViewTextBoxColumn
    Friend WithEvents yarndate As DataGridViewTextBoxColumn
    Friend WithEvents bom_usage_name As DataGridViewTextBoxColumn
    Friend WithEvents ynperc As DataGridViewTextBoxColumn
    Friend WithEvents id_yarnchangedet As DataGridViewTextBoxColumn
    Friend WithEvents itcd As DataGridViewTextBoxColumn
    Friend WithEvents itdesc As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents colReqdQty As DataGridViewTextBoxColumn
    Friend WithEvents colUom As DataGridViewTextBoxColumn
    Friend WithEvents suppcd As DataGridViewTextBoxColumn
    Friend WithEvents bomversionid As DataGridViewTextBoxColumn
    'Friend WithEvents Maps1 As Syncfusion.Windows.Forms.Maps.Maps
End Class
