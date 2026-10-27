<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSearchKO
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtDesignNo = New System.Windows.Forms.TextBox()
        Me.lblDesignNo = New System.Windows.Forms.Label()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.dtpDateTo = New System.Windows.Forms.DateTimePicker()
        Me.dtpDateFr = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cboSup = New System.Windows.Forms.ComboBox()
        Me.grdData = New System.Windows.Forms.DataGridView()
        Me.ProductionOrderId = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.kodt = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.kono = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Design_no = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.grd_cbosup = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.ynchgcd = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.kg = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnexit = New System.Windows.Forms.Button()
        Me.cboProdType = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnok = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        CType(Me.grdData, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cboProdType)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txtDesignNo)
        Me.GroupBox1.Controls.Add(Me.lblDesignNo)
        Me.GroupBox1.Controls.Add(Me.btnSearch)
        Me.GroupBox1.Controls.Add(Me.dtpDateTo)
        Me.GroupBox1.Controls.Add(Me.dtpDateFr)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.cboSup)
        Me.GroupBox1.Location = New System.Drawing.Point(26, 16)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(604, 108)
        Me.GroupBox1.TabIndex = 35
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Filter"
        '
        'txtDesignNo
        '
        Me.txtDesignNo.Location = New System.Drawing.Point(22, 69)
        Me.txtDesignNo.Name = "txtDesignNo"
        Me.txtDesignNo.Size = New System.Drawing.Size(241, 22)
        Me.txtDesignNo.TabIndex = 17
        '
        'lblDesignNo
        '
        Me.lblDesignNo.AutoSize = True
        Me.lblDesignNo.Location = New System.Drawing.Point(19, 53)
        Me.lblDesignNo.Name = "lblDesignNo"
        Me.lblDesignNo.Size = New System.Drawing.Size(64, 13)
        Me.lblDesignNo.TabIndex = 16
        Me.lblDesignNo.Text = "Design No."
        '
        'btnSearch
        '
        Me.btnSearch.Location = New System.Drawing.Point(482, 68)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(81, 23)
        Me.btnSearch.TabIndex = 13
        Me.btnSearch.Text = "Show"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'dtpDateTo
        '
        Me.dtpDateTo.CustomFormat = "dd/MM/yyyy"
        Me.dtpDateTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpDateTo.Location = New System.Drawing.Point(388, 69)
        Me.dtpDateTo.Name = "dtpDateTo"
        Me.dtpDateTo.Size = New System.Drawing.Size(88, 22)
        Me.dtpDateTo.TabIndex = 12
        '
        'dtpDateFr
        '
        Me.dtpDateFr.CustomFormat = "dd/MM/yyyy"
        Me.dtpDateFr.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpDateFr.Location = New System.Drawing.Point(269, 69)
        Me.dtpDateFr.Name = "dtpDateFr"
        Me.dtpDateFr.Size = New System.Drawing.Size(88, 22)
        Me.dtpDateFr.TabIndex = 11
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(363, 75)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(19, 13)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "To"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(266, 53)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(60, 13)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "From Date"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(266, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 13)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Supplier:"
        '
        'cboSup
        '
        Me.cboSup.FormattingEnabled = True
        Me.cboSup.Location = New System.Drawing.Point(269, 29)
        Me.cboSup.Name = "cboSup"
        Me.cboSup.Size = New System.Drawing.Size(207, 21)
        Me.cboSup.TabIndex = 9
        '
        'grdData
        '
        Me.grdData.AllowUserToAddRows = False
        Me.grdData.AllowUserToDeleteRows = False
        Me.grdData.ColumnHeadersHeight = 40
        Me.grdData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.grdData.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ProductionOrderId, Me.kodt, Me.kono, Me.Design_no, Me.grd_cbosup, Me.ynchgcd, Me.kg})
        Me.grdData.Location = New System.Drawing.Point(26, 130)
        Me.grdData.Name = "grdData"
        Me.grdData.ReadOnly = True
        Me.grdData.Size = New System.Drawing.Size(605, 290)
        Me.grdData.TabIndex = 32
        '
        'ProductionOrderId
        '
        Me.ProductionOrderId.DataPropertyName = "production_order_id"
        Me.ProductionOrderId.HeaderText = "Prod. ID"
        Me.ProductionOrderId.Name = "ProductionOrderId"
        Me.ProductionOrderId.ReadOnly = True
        Me.ProductionOrderId.Width = 60
        '
        'kodt
        '
        Me.kodt.DataPropertyName = "kodt"
        Me.kodt.HeaderText = "Prod. Date"
        Me.kodt.Name = "kodt"
        Me.kodt.ReadOnly = True
        '
        'kono
        '
        Me.kono.DataPropertyName = "kono"
        Me.kono.HeaderText = "Prod. No."
        Me.kono.Name = "kono"
        Me.kono.ReadOnly = True
        '
        'Design_no
        '
        Me.Design_no.DataPropertyName = "Design_no"
        Me.Design_no.HeaderText = "Design No."
        Me.Design_no.Name = "Design_no"
        Me.Design_no.ReadOnly = True
        Me.Design_no.Width = 150
        '
        'grd_cbosup
        '
        Me.grd_cbosup.DataPropertyName = "suppcd"
        Me.grd_cbosup.HeaderText = "Supplier"
        Me.grd_cbosup.Name = "grd_cbosup"
        Me.grd_cbosup.ReadOnly = True
        Me.grd_cbosup.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grd_cbosup.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.grd_cbosup.Visible = False
        Me.grd_cbosup.Width = 250
        '
        'ynchgcd
        '
        Me.ynchgcd.DataPropertyName = "ynchgcd"
        Me.ynchgcd.HeaderText = "Bom"
        Me.ynchgcd.Name = "ynchgcd"
        Me.ynchgcd.ReadOnly = True
        Me.ynchgcd.Width = 50
        '
        'kg
        '
        Me.kg.DataPropertyName = "kg"
        Me.kg.HeaderText = "FG IN (Kg.)"
        Me.kg.Name = "kg"
        Me.kg.ReadOnly = True
        '
        'btnexit
        '
        Me.btnexit.Image = Global.ProductionSystem.My.Resources.Resources.Exit_16x
        Me.btnexit.Location = New System.Drawing.Point(538, 435)
        Me.btnexit.Name = "btnexit"
        Me.btnexit.Size = New System.Drawing.Size(94, 23)
        Me.btnexit.TabIndex = 34
        Me.btnexit.Text = "Exit"
        Me.btnexit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnexit.UseVisualStyleBackColor = True
        '
        'cboProdType
        '
        Me.cboProdType.FormattingEnabled = True
        Me.cboProdType.Location = New System.Drawing.Point(20, 29)
        Me.cboProdType.Name = "cboProdType"
        Me.cboProdType.Size = New System.Drawing.Size(243, 21)
        Me.cboProdType.TabIndex = 260
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(17, 13)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(90, 13)
        Me.Label4.TabIndex = 259
        Me.Label4.Text = "Production Type"
        '
        'btnok
        '
        Me.btnok.Image = Global.ProductionSystem.My.Resources.Resources.ConfirmButton_16x
        Me.btnok.Location = New System.Drawing.Point(442, 435)
        Me.btnok.Name = "btnok"
        Me.btnok.Size = New System.Drawing.Size(90, 23)
        Me.btnok.TabIndex = 33
        Me.btnok.Text = "Ok"
        Me.btnok.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnok.UseVisualStyleBackColor = True
        '
        'frmSearchKO
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(658, 474)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnok)
        Me.Controls.Add(Me.grdData)
        Me.Controls.Add(Me.btnexit)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmSearchKO"
        Me.Text = "Search Prod. No."
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.grdData, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtDesignNo As TextBox
    Friend WithEvents lblDesignNo As Label
    Friend WithEvents btnSearch As Button
    Friend WithEvents dtpDateTo As DateTimePicker
    Friend WithEvents dtpDateFr As DateTimePicker
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents cboSup As ComboBox
    Friend WithEvents btnok As Button
    Friend WithEvents grdData As DataGridView
    Friend WithEvents ProductionOrderId As DataGridViewTextBoxColumn
    Friend WithEvents kodt As DataGridViewTextBoxColumn
    Friend WithEvents kono As DataGridViewTextBoxColumn
    Friend WithEvents Design_no As DataGridViewTextBoxColumn
    Friend WithEvents grd_cbosup As DataGridViewComboBoxColumn
    Friend WithEvents ynchgcd As DataGridViewTextBoxColumn
    Friend WithEvents kg As DataGridViewTextBoxColumn
    Friend WithEvents btnexit As Button
    Friend WithEvents cboProdType As ComboBox
    Friend WithEvents Label4 As Label
End Class
