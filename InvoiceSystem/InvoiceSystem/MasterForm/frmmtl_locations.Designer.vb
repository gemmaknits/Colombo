<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmmtl_locations
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmmtl_locations))
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.grdmtl_Locations = New System.Windows.Forms.DataGridView()
        Me.chkbox = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.mtl_locations_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.location_name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.mtl_warehouse = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.mtl_subinventory = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.BtnApply = New System.Windows.Forms.Button()
        Me.lblSub = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cboNewmtl_subinventory = New System.Windows.Forms.ComboBox()
        Me.lblName = New System.Windows.Forms.Label()
        Me.cbomtl_warehouse = New System.Windows.Forms.ComboBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtlocation_name = New System.Windows.Forms.TextBox()
        Me.lblWareHouse = New System.Windows.Forms.Label()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.btnExit = New System.Windows.Forms.ToolStripButton()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnSave = New System.Windows.Forms.ToolStripButton()
        Me.btnPrint = New System.Windows.Forms.ToolStripButton()
        Me.btnMinimized = New System.Windows.Forms.ToolStripButton()
        CType(Me.grdmtl_Locations, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Red
        Me.Label3.Location = New System.Drawing.Point(640, 79)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(12, 13)
        Me.Label3.TabIndex = 32
        Me.Label3.Text = "*"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Red
        Me.Label2.Location = New System.Drawing.Point(640, 52)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(12, 13)
        Me.Label2.TabIndex = 31
        Me.Label2.Text = "*"
        '
        'grdmtl_Locations
        '
        Me.grdmtl_Locations.AllowUserToAddRows = False
        Me.grdmtl_Locations.AllowUserToDeleteRows = False
        Me.grdmtl_Locations.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdmtl_Locations.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.chkbox, Me.mtl_locations_id, Me.location_name, Me.mtl_warehouse, Me.mtl_subinventory})
        Me.grdmtl_Locations.Location = New System.Drawing.Point(19, 19)
        Me.grdmtl_Locations.Name = "grdmtl_Locations"
        Me.grdmtl_Locations.Size = New System.Drawing.Size(619, 186)
        Me.grdmtl_Locations.TabIndex = 0
        '
        'chkbox
        '
        Me.chkbox.HeaderText = "#"
        Me.chkbox.Name = "chkbox"
        Me.chkbox.Width = 30
        '
        'mtl_locations_id
        '
        Me.mtl_locations_id.DataPropertyName = "mtl_locations_id"
        Me.mtl_locations_id.HeaderText = "ID"
        Me.mtl_locations_id.Name = "mtl_locations_id"
        Me.mtl_locations_id.ReadOnly = True
        Me.mtl_locations_id.Width = 20
        '
        'location_name
        '
        Me.location_name.DataPropertyName = "location_name"
        Me.location_name.HeaderText = "Name"
        Me.location_name.Name = "location_name"
        Me.location_name.Width = 200
        '
        'mtl_warehouse
        '
        Me.mtl_warehouse.DataPropertyName = "mtl_warehouse_id"
        Me.mtl_warehouse.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.[Nothing]
        Me.mtl_warehouse.HeaderText = "Warehouse"
        Me.mtl_warehouse.Name = "mtl_warehouse"
        Me.mtl_warehouse.ReadOnly = True
        '
        'mtl_subinventory
        '
        Me.mtl_subinventory.DataPropertyName = "mtl_subinventory_id"
        Me.mtl_subinventory.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.[Nothing]
        Me.mtl_subinventory.HeaderText = "Sub Inventory"
        Me.mtl_subinventory.Name = "mtl_subinventory"
        Me.mtl_subinventory.ReadOnly = True
        '
        'BtnApply
        '
        Me.BtnApply.Location = New System.Drawing.Point(6, 22)
        Me.BtnApply.Name = "BtnApply"
        Me.BtnApply.Size = New System.Drawing.Size(67, 70)
        Me.BtnApply.TabIndex = 21
        Me.BtnApply.Text = "Apply"
        Me.BtnApply.UseVisualStyleBackColor = True
        '
        'lblSub
        '
        Me.lblSub.AutoSize = True
        Me.lblSub.Location = New System.Drawing.Point(79, 49)
        Me.lblSub.Name = "lblSub"
        Me.lblSub.Size = New System.Drawing.Size(73, 13)
        Me.lblSub.TabIndex = 27
        Me.lblSub.Text = "Sub Inventory"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.grdmtl_Locations)
        Me.GroupBox1.Location = New System.Drawing.Point(28, 145)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(658, 228)
        Me.GroupBox1.TabIndex = 31
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Location Informations"
        '
        'cboNewmtl_subinventory
        '
        Me.cboNewmtl_subinventory.FormattingEnabled = True
        Me.cboNewmtl_subinventory.Location = New System.Drawing.Point(158, 49)
        Me.cboNewmtl_subinventory.Name = "cboNewmtl_subinventory"
        Me.cboNewmtl_subinventory.Size = New System.Drawing.Size(480, 21)
        Me.cboNewmtl_subinventory.TabIndex = 26
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Location = New System.Drawing.Point(117, 79)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(35, 13)
        Me.lblName.TabIndex = 24
        Me.lblName.Text = "Name"
        '
        'cbomtl_warehouse
        '
        Me.cbomtl_warehouse.FormattingEnabled = True
        Me.cbomtl_warehouse.Location = New System.Drawing.Point(158, 22)
        Me.cbomtl_warehouse.Name = "cbomtl_warehouse"
        Me.cbomtl_warehouse.Size = New System.Drawing.Size(480, 21)
        Me.cbomtl_warehouse.TabIndex = 23
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.BtnApply)
        Me.GroupBox2.Controls.Add(Me.lblSub)
        Me.GroupBox2.Controls.Add(Me.cboNewmtl_subinventory)
        Me.GroupBox2.Controls.Add(Me.lblName)
        Me.GroupBox2.Controls.Add(Me.cbomtl_warehouse)
        Me.GroupBox2.Controls.Add(Me.txtlocation_name)
        Me.GroupBox2.Controls.Add(Me.lblWareHouse)
        Me.GroupBox2.Location = New System.Drawing.Point(28, 34)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(658, 105)
        Me.GroupBox2.TabIndex = 32
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Data to Apply"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Red
        Me.Label1.Location = New System.Drawing.Point(640, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(12, 13)
        Me.Label1.TabIndex = 30
        Me.Label1.Text = "*"
        '
        'txtlocation_name
        '
        Me.txtlocation_name.Location = New System.Drawing.Point(158, 76)
        Me.txtlocation_name.Name = "txtlocation_name"
        Me.txtlocation_name.Size = New System.Drawing.Size(480, 20)
        Me.txtlocation_name.TabIndex = 22
        '
        'lblWareHouse
        '
        Me.lblWareHouse.AutoSize = True
        Me.lblWareHouse.Location = New System.Drawing.Point(88, 22)
        Me.lblWareHouse.Name = "lblWareHouse"
        Me.lblWareHouse.Size = New System.Drawing.Size(64, 13)
        Me.lblWareHouse.TabIndex = 25
        Me.lblWareHouse.Text = "WareHouse"
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.ToolStripLabel1.ForeColor = System.Drawing.Color.Red
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(323, 22)
        Me.ToolStripLabel1.Text = "เลือก WareHouse และ Sub Inventory ก่อนที่จะสร้าง Location"
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
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripSeparator1, Me.btnSave, Me.btnPrint, Me.btnMinimized, Me.btnExit, Me.ToolStripLabel1})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(719, 25)
        Me.ToolStrip1.TabIndex = 30
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
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
        'btnPrint
        '
        Me.btnPrint.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnPrint.Image = CType(resources.GetObject("btnPrint.Image"), System.Drawing.Image)
        Me.btnPrint.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(23, 22)
        Me.btnPrint.Text = "Print"
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
        'frmmtl_locations
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(719, 378)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Name = "frmmtl_locations"
        Me.Text = "Locations Master"
        CType(Me.grdmtl_Locations, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents grdmtl_Locations As System.Windows.Forms.DataGridView
    Friend WithEvents chkbox As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents mtl_locations_id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents location_name As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents mtl_warehouse As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents mtl_subinventory As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents BtnApply As System.Windows.Forms.Button
    Friend WithEvents lblSub As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents cboNewmtl_subinventory As System.Windows.Forms.ComboBox
    Friend WithEvents lblName As System.Windows.Forms.Label
    Friend WithEvents cbomtl_warehouse As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtlocation_name As System.Windows.Forms.TextBox
    Friend WithEvents lblWareHouse As System.Windows.Forms.Label
    Friend WithEvents ToolStripLabel1 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents btnExit As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnSave As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnPrint As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnMinimized As System.Windows.Forms.ToolStripButton
End Class
