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
        Me.lblName = New System.Windows.Forms.Label()
        Me.btnMinimized = New System.Windows.Forms.ToolStripButton()
        Me.cbomtl_warehouse = New System.Windows.Forms.ComboBox()
        Me.btnExit = New System.Windows.Forms.ToolStripButton()
        Me.txtlocation_name = New System.Windows.Forms.TextBox()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnPrint = New System.Windows.Forms.ToolStripButton()
        Me.grdmtl_Locations = New System.Windows.Forms.DataGridView()
        Me.chkbox = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.mtl_locations_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.location_name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.mtl_warehouse = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.btnSave = New System.Windows.Forms.ToolStripButton()
        Me.btnSearch = New System.Windows.Forms.ToolStripButton()
        Me.btnNew = New System.Windows.Forms.ToolStripButton()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.lblWareHouse = New System.Windows.Forms.Label()
        CType(Me.grdmtl_Locations, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Location = New System.Drawing.Point(139, 82)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(35, 13)
        Me.lblName.TabIndex = 31
        Me.lblName.Text = "Name"
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
        'cbomtl_warehouse
        '
        Me.cbomtl_warehouse.FormattingEnabled = True
        Me.cbomtl_warehouse.Location = New System.Drawing.Point(391, 77)
        Me.cbomtl_warehouse.Name = "cbomtl_warehouse"
        Me.cbomtl_warehouse.Size = New System.Drawing.Size(121, 21)
        Me.cbomtl_warehouse.TabIndex = 30
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
        'txtlocation_name
        '
        Me.txtlocation_name.Location = New System.Drawing.Point(180, 78)
        Me.txtlocation_name.Name = "txtlocation_name"
        Me.txtlocation_name.Size = New System.Drawing.Size(100, 20)
        Me.txtlocation_name.TabIndex = 29
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.ToolStripLabel1.ForeColor = System.Drawing.Color.Red
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(219, 22)
        Me.ToolStripLabel1.Text = "เลือก WareHouse ก่อนที่จะสร้าง Location"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(28, 76)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 28
        Me.Button1.Text = "Add"
        Me.Button1.UseVisualStyleBackColor = True
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
        'grdmtl_Locations
        '
        Me.grdmtl_Locations.AllowUserToAddRows = False
        Me.grdmtl_Locations.AllowUserToDeleteRows = False
        Me.grdmtl_Locations.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdmtl_Locations.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.chkbox, Me.mtl_locations_id, Me.location_name, Me.mtl_warehouse})
        Me.grdmtl_Locations.Location = New System.Drawing.Point(28, 117)
        Me.grdmtl_Locations.Name = "grdmtl_Locations"
        Me.grdmtl_Locations.Size = New System.Drawing.Size(603, 219)
        Me.grdmtl_Locations.TabIndex = 26
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
        Me.mtl_warehouse.HeaderText = "Warehouse"
        Me.mtl_warehouse.Name = "mtl_warehouse"
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
        'btnSearch
        '
        Me.btnSearch.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnSearch.Image = CType(resources.GetObject("btnSearch.Image"), System.Drawing.Image)
        Me.btnSearch.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(23, 22)
        Me.btnSearch.Text = "Search"
        '
        'btnNew
        '
        Me.btnNew.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnNew.Image = CType(resources.GetObject("btnNew.Image"), System.Drawing.Image)
        Me.btnNew.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnNew.Name = "btnNew"
        Me.btnNew.Size = New System.Drawing.Size(23, 22)
        Me.btnNew.Text = "New"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripSeparator1, Me.btnNew, Me.btnSearch, Me.btnSave, Me.btnPrint, Me.btnMinimized, Me.btnExit, Me.ToolStripLabel1})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(685, 25)
        Me.ToolStrip1.TabIndex = 27
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'lblWareHouse
        '
        Me.lblWareHouse.AutoSize = True
        Me.lblWareHouse.Location = New System.Drawing.Point(308, 85)
        Me.lblWareHouse.Name = "lblWareHouse"
        Me.lblWareHouse.Size = New System.Drawing.Size(64, 13)
        Me.lblWareHouse.TabIndex = 32
        Me.lblWareHouse.Text = "WareHouse"
        '
        'frmmtl_locations
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(685, 353)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.cbomtl_warehouse)
        Me.Controls.Add(Me.txtlocation_name)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.grdmtl_Locations)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.lblWareHouse)
        Me.Name = "frmmtl_locations"
        Me.Text = "Locations Master"
        CType(Me.grdmtl_Locations, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblName As System.Windows.Forms.Label
    Friend WithEvents btnMinimized As System.Windows.Forms.ToolStripButton
    Friend WithEvents cbomtl_warehouse As System.Windows.Forms.ComboBox
    Friend WithEvents btnExit As System.Windows.Forms.ToolStripButton
    Friend WithEvents txtlocation_name As System.Windows.Forms.TextBox
    Friend WithEvents ToolStripLabel1 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents btnPrint As System.Windows.Forms.ToolStripButton
    Friend WithEvents grdmtl_Locations As System.Windows.Forms.DataGridView
    Friend WithEvents chkbox As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents mtl_locations_id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents location_name As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents mtl_warehouse As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents btnSave As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnSearch As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnNew As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents lblWareHouse As System.Windows.Forms.Label
End Class
