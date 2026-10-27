<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSearchPackingListD
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSearchPackingListD))
        Me.txtWordFilter = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnok = New System.Windows.Forms.Button()
        Me.btnexit = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtCustName = New System.Windows.Forms.TextBox()
        Me.txtCustCode = New System.Windows.Forms.TextBox()
        Me.btnCustomer = New System.Windows.Forms.Button()
        Me.btnRefresh2 = New System.Windows.Forms.Button()
        Me.lbcustomer = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dtpDateTo = New System.Windows.Forms.DateTimePicker()
        Me.dtpDateFr = New System.Windows.Forms.DateTimePicker()
        Me.txtPackNo = New System.Windows.Forms.TextBox()
        Me.grdData = New System.Windows.Forms.DataGridView()
        Me.grdPackinglistD_packno = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.grdPackinglistD_packdt = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OutNo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.outdt = New Classes.CalendarColumn()
        Me.grdPackinglistD_custname = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.grdData, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtWordFilter
        '
        Me.txtWordFilter.Location = New System.Drawing.Point(129, 16)
        Me.txtWordFilter.Name = "txtWordFilter"
        Me.txtWordFilter.Size = New System.Drawing.Size(188, 20)
        Me.txtWordFilter.TabIndex = 8
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(31, 19)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(58, 13)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Word Filter"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtWordFilter)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 111)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(365, 46)
        Me.GroupBox2.TabIndex = 38
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Filter"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(113, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(10, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = ":"
        '
        'btnok
        '
        Me.btnok.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnok.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnok.Image = Global.SalesOrderSystem.My.Resources.Resources.ApplyCodeChanges_16x
        Me.btnok.Location = New System.Drawing.Point(429, 480)
        Me.btnok.Name = "btnok"
        Me.btnok.Size = New System.Drawing.Size(90, 23)
        Me.btnok.TabIndex = 36
        Me.btnok.Text = "Ok"
        Me.btnok.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnok.UseVisualStyleBackColor = True
        '
        'btnexit
        '
        Me.btnexit.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnexit.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnexit.Image = Global.SalesOrderSystem.My.Resources.Resources.Exit_16x
        Me.btnexit.Location = New System.Drawing.Point(525, 480)
        Me.btnexit.Name = "btnexit"
        Me.btnexit.Size = New System.Drawing.Size(94, 23)
        Me.btnexit.TabIndex = 37
        Me.btnexit.Text = "Exit"
        Me.btnexit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnexit.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(113, 73)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(10, 13)
        Me.Label8.TabIndex = 28
        Me.Label8.Text = ":"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.txtCustName)
        Me.GroupBox1.Controls.Add(Me.txtCustCode)
        Me.GroupBox1.Controls.Add(Me.btnCustomer)
        Me.GroupBox1.Controls.Add(Me.btnRefresh2)
        Me.GroupBox1.Controls.Add(Me.lbcustomer)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.dtpDateTo)
        Me.GroupBox1.Controls.Add(Me.dtpDateFr)
        Me.GroupBox1.Controls.Add(Me.txtPackNo)
        Me.GroupBox1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 8)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(607, 102)
        Me.GroupBox1.TabIndex = 35
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Condition"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(113, 47)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(10, 13)
        Me.Label7.TabIndex = 28
        Me.Label7.Text = ":"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(113, 22)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(10, 13)
        Me.Label6.TabIndex = 27
        Me.Label6.Text = ":"
        '
        'txtCustName
        '
        Me.txtCustName.Location = New System.Drawing.Point(255, 70)
        Me.txtCustName.Name = "txtCustName"
        Me.txtCustName.ReadOnly = True
        Me.txtCustName.Size = New System.Drawing.Size(278, 22)
        Me.txtCustName.TabIndex = 26
        '
        'txtCustCode
        '
        Me.txtCustCode.Location = New System.Drawing.Point(129, 70)
        Me.txtCustCode.Name = "txtCustCode"
        Me.txtCustCode.Size = New System.Drawing.Size(88, 22)
        Me.txtCustCode.TabIndex = 25
        '
        'btnCustomer
        '
        Me.btnCustomer.Image = Global.SalesOrderSystem.My.Resources.Resources.Search_16x
        Me.btnCustomer.Location = New System.Drawing.Point(225, 69)
        Me.btnCustomer.Name = "btnCustomer"
        Me.btnCustomer.Size = New System.Drawing.Size(24, 23)
        Me.btnCustomer.TabIndex = 24
        Me.btnCustomer.UseVisualStyleBackColor = True
        '
        'btnRefresh2
        '
        Me.btnRefresh2.Image = CType(resources.GetObject("btnRefresh2.Image"), System.Drawing.Image)
        Me.btnRefresh2.Location = New System.Drawing.Point(513, 21)
        Me.btnRefresh2.Name = "btnRefresh2"
        Me.btnRefresh2.Size = New System.Drawing.Size(72, 32)
        Me.btnRefresh2.TabIndex = 23
        Me.btnRefresh2.Text = "&Refresh"
        Me.btnRefresh2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnRefresh2.UseVisualStyleBackColor = True
        '
        'lbcustomer
        '
        Me.lbcustomer.AutoSize = True
        Me.lbcustomer.Location = New System.Drawing.Point(27, 73)
        Me.lbcustomer.Name = "lbcustomer"
        Me.lbcustomer.Size = New System.Drawing.Size(56, 13)
        Me.lbcustomer.TabIndex = 18
        Me.lbcustomer.Text = "Customer"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(27, 22)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(51, 13)
        Me.Label4.TabIndex = 17
        Me.Label4.Text = "Pack No."
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(235, 47)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(19, 13)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "To"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(27, 47)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(74, 13)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "Packing Date"
        '
        'dtpDateTo
        '
        Me.dtpDateTo.CustomFormat = "dd/MM/yyyy"
        Me.dtpDateTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpDateTo.Location = New System.Drawing.Point(267, 44)
        Me.dtpDateTo.Name = "dtpDateTo"
        Me.dtpDateTo.Size = New System.Drawing.Size(88, 22)
        Me.dtpDateTo.TabIndex = 14
        '
        'dtpDateFr
        '
        Me.dtpDateFr.CustomFormat = "dd/MM/yyyy"
        Me.dtpDateFr.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpDateFr.Location = New System.Drawing.Point(129, 44)
        Me.dtpDateFr.Name = "dtpDateFr"
        Me.dtpDateFr.Size = New System.Drawing.Size(88, 22)
        Me.dtpDateFr.TabIndex = 13
        '
        'txtPackNo
        '
        Me.txtPackNo.Location = New System.Drawing.Point(129, 18)
        Me.txtPackNo.Name = "txtPackNo"
        Me.txtPackNo.Size = New System.Drawing.Size(88, 22)
        Me.txtPackNo.TabIndex = 10
        '
        'grdData
        '
        Me.grdData.AllowUserToAddRows = False
        Me.grdData.AllowUserToDeleteRows = False
        Me.grdData.AllowUserToOrderColumns = True
        Me.grdData.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grdData.BackgroundColor = System.Drawing.Color.PeachPuff
        Me.grdData.ColumnHeadersHeight = 30
        Me.grdData.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.grdPackinglistD_packno, Me.grdPackinglistD_packdt, Me.OutNo, Me.outdt, Me.grdPackinglistD_custname})
        Me.grdData.Location = New System.Drawing.Point(12, 162)
        Me.grdData.Name = "grdData"
        Me.grdData.ReadOnly = True
        Me.grdData.Size = New System.Drawing.Size(607, 308)
        Me.grdData.TabIndex = 34
        '
        'grdPackinglistD_packno
        '
        Me.grdPackinglistD_packno.DataPropertyName = "packno"
        Me.grdPackinglistD_packno.HeaderText = "Pack No."
        Me.grdPackinglistD_packno.Name = "grdPackinglistD_packno"
        Me.grdPackinglistD_packno.ReadOnly = True
        Me.grdPackinglistD_packno.Width = 90
        '
        'grdPackinglistD_packdt
        '
        Me.grdPackinglistD_packdt.DataPropertyName = "packdt"
        Me.grdPackinglistD_packdt.HeaderText = "Pack Date"
        Me.grdPackinglistD_packdt.Name = "grdPackinglistD_packdt"
        Me.grdPackinglistD_packdt.ReadOnly = True
        Me.grdPackinglistD_packdt.Width = 90
        '
        'OutNo
        '
        Me.OutNo.DataPropertyName = "outno"
        Me.OutNo.HeaderText = "Out No."
        Me.OutNo.Name = "OutNo"
        Me.OutNo.ReadOnly = True
        Me.OutNo.Width = 90
        '
        'outdt
        '
        Me.outdt.DataPropertyName = "outdt"
        Me.outdt.HeaderText = "Out Date"
        Me.outdt.Name = "outdt"
        Me.outdt.ReadOnly = True
        Me.outdt.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.outdt.Width = 90
        '
        'grdPackinglistD_custname
        '
        Me.grdPackinglistD_custname.DataPropertyName = "custname"
        Me.grdPackinglistD_custname.HeaderText = "Customer"
        Me.grdPackinglistD_custname.Name = "grdPackinglistD_custname"
        Me.grdPackinglistD_custname.ReadOnly = True
        Me.grdPackinglistD_custname.Width = 200
        '
        'frmSearchPackingListD
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(631, 511)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.btnok)
        Me.Controls.Add(Me.btnexit)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.grdData)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmSearchPackingListD"
        Me.Text = "Search PackingList Dyed"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.grdData, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnRefresh As System.Windows.Forms.ToolStripButton
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btnMinimized As System.Windows.Forms.ToolStripButton
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnRefresh2 As System.Windows.Forms.Button
    Friend WithEvents cbocustomer As System.Windows.Forms.ComboBox
    Friend WithEvents lbcustomer As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents dtpDateTo As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpDateFr As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtPackNo As System.Windows.Forms.TextBox
    Friend WithEvents grdPackinglistD As System.Windows.Forms.DataGridView
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents grdPackinglistD_packno As DataGridViewTextBoxColumn
    Friend WithEvents grdPackinglistD_custname As DataGridViewTextBoxColumn
    Friend WithEvents grdPackinglistD_packdt As DataGridViewTextBoxColumn
    Friend WithEvents OCNo As DataGridViewTextBoxColumn
    Friend WithEvents txtWordFilter As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnok As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtCustName As TextBox
    Friend WithEvents txtCustCode As TextBox
    Friend WithEvents btnCustomer As Button
    Friend WithEvents grdData As DataGridView
    Friend WithEvents OutNo As DataGridViewTextBoxColumn
    Friend WithEvents outdt As Classes.CalendarColumn
    Friend WithEvents btnexit As Button
End Class
