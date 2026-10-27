<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formYarnScrap
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(formYarnScrap))
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.dgvYarnScrap = New System.Windows.Forms.DataGridView()
        Me.btnSearchKI = New System.Windows.Forms.Button()
        Me.txtKono = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.txtDesignNo = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dtpscrap_date = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DataGridViewCalendarColumn1 = New YarnStockSystem.DataGridViewCalendarColumn()
        Me.cboitcd = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.colYarnPerc = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colYarnOut = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colYarnRet = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colNetOutKg = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colYarnScrap = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colKono = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.scrap_date = New YarnStockSystem.DataGridViewCalendarColumn()
        CType(Me.dgvYarnScrap, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvYarnScrap
        '
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.dgvYarnScrap.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvYarnScrap.BackgroundColor = System.Drawing.Color.PeachPuff
        Me.dgvYarnScrap.ColumnHeadersHeight = 50
        Me.dgvYarnScrap.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.cboitcd, Me.colYarnPerc, Me.colYarnOut, Me.colYarnRet, Me.colNetOutKg, Me.colYarnScrap, Me.colKono, Me.scrap_date})
        Me.dgvYarnScrap.Location = New System.Drawing.Point(21, 54)
        Me.dgvYarnScrap.Name = "dgvYarnScrap"
        Me.dgvYarnScrap.Size = New System.Drawing.Size(660, 276)
        Me.dgvYarnScrap.TabIndex = 3
        '
        'btnSearchKI
        '
        Me.btnSearchKI.Image = CType(resources.GetObject("btnSearchKI.Image"), System.Drawing.Image)
        Me.btnSearchKI.Location = New System.Drawing.Point(231, 15)
        Me.btnSearchKI.Name = "btnSearchKI"
        Me.btnSearchKI.Size = New System.Drawing.Size(22, 23)
        Me.btnSearchKI.TabIndex = 157
        Me.btnSearchKI.UseVisualStyleBackColor = True
        '
        'txtKono
        '
        Me.txtKono.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtKono.Location = New System.Drawing.Point(114, 16)
        Me.txtKono.Name = "txtKono"
        Me.txtKono.Size = New System.Drawing.Size(111, 22)
        Me.txtKono.TabIndex = 156
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label15.Location = New System.Drawing.Point(20, 21)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(92, 13)
        Me.Label15.TabIndex = 158
        Me.Label15.Text = "Knitting order No.:"
        '
        'btnSave
        '
        Me.btnSave.Image = CType(resources.GetObject("btnSave.Image"), System.Drawing.Image)
        Me.btnSave.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.btnSave.Location = New System.Drawing.Point(711, 191)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 35)
        Me.btnSave.TabIndex = 159
        Me.btnSave.Text = "Save"
        Me.btnSave.TextAlign = System.Drawing.ContentAlignment.BottomRight
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Image = CType(resources.GetObject("btnExit.Image"), System.Drawing.Image)
        Me.btnExit.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.btnExit.Location = New System.Drawing.Point(711, 278)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 35)
        Me.btnExit.TabIndex = 160
        Me.btnExit.Text = "Exit"
        Me.btnExit.TextAlign = System.Drawing.ContentAlignment.BottomRight
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Image = CType(resources.GetObject("btnDelete.Image"), System.Drawing.Image)
        Me.btnDelete.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.btnDelete.Location = New System.Drawing.Point(711, 232)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(75, 35)
        Me.btnDelete.TabIndex = 161
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.TextAlign = System.Drawing.ContentAlignment.BottomRight
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'txtDesignNo
        '
        Me.txtDesignNo.Location = New System.Drawing.Point(349, 17)
        Me.txtDesignNo.Name = "txtDesignNo"
        Me.txtDesignNo.ReadOnly = True
        Me.txtDesignNo.Size = New System.Drawing.Size(147, 20)
        Me.txtDesignNo.TabIndex = 162
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label1.Location = New System.Drawing.Point(280, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(63, 13)
        Me.Label1.TabIndex = 163
        Me.Label1.Text = "Design No.:"
        '
        'dtpscrap_date
        '
        Me.dtpscrap_date.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpscrap_date.Location = New System.Drawing.Point(583, 17)
        Me.dtpscrap_date.Name = "dtpscrap_date"
        Me.dtpscrap_date.ShowUpDown = True
        Me.dtpscrap_date.Size = New System.Drawing.Size(98, 20)
        Me.dtpscrap_date.TabIndex = 164
        Me.dtpscrap_date.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(538, 21)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(30, 13)
        Me.Label2.TabIndex = 165
        Me.Label2.Text = "Date"
        Me.Label2.Visible = False
        '
        'DataGridViewCalendarColumn1
        '
        Me.DataGridViewCalendarColumn1.DataPropertyName = "scrap_date"
        DataGridViewCellStyle2.NullValue = "DateTime.Now"
        Me.DataGridViewCalendarColumn1.DefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridViewCalendarColumn1.HeaderText = "Scrap Date"
        Me.DataGridViewCalendarColumn1.Name = "DataGridViewCalendarColumn1"
        '
        'cboitcd
        '
        Me.cboitcd.DataPropertyName = "itcd"
        Me.cboitcd.HeaderText = "Item Code - Description"
        Me.cboitcd.Name = "cboitcd"
        Me.cboitcd.Width = 200
        '
        'colYarnPerc
        '
        Me.colYarnPerc.DataPropertyName = "ynperc"
        Me.colYarnPerc.HeaderText = "%"
        Me.colYarnPerc.Name = "colYarnPerc"
        Me.colYarnPerc.Width = 50
        '
        'colYarnOut
        '
        Me.colYarnOut.DataPropertyName = "yout_kg"
        Me.colYarnOut.HeaderText = "Total Yarn Out (kg)"
        Me.colYarnOut.Name = "colYarnOut"
        Me.colYarnOut.Width = 60
        '
        'colYarnRet
        '
        Me.colYarnRet.DataPropertyName = "ret_kg"
        Me.colYarnRet.HeaderText = "Yarn Ret (kg)"
        Me.colYarnRet.Name = "colYarnRet"
        Me.colYarnRet.Width = 60
        '
        'colNetOutKg
        '
        Me.colNetOutKg.DataPropertyName = "net_out_kg"
        Me.colNetOutKg.HeaderText = "Net Out Kg"
        Me.colNetOutKg.Name = "colNetOutKg"
        Me.colNetOutKg.Width = 50
        '
        'colYarnScrap
        '
        Me.colYarnScrap.DataPropertyName = "total_scrap_qty"
        Me.colYarnScrap.HeaderText = "Yarn scrap (kg)"
        Me.colYarnScrap.Name = "colYarnScrap"
        Me.colYarnScrap.Width = 60
        '
        'colKono
        '
        Me.colKono.DataPropertyName = "kono"
        Me.colKono.HeaderText = "K/I no."
        Me.colKono.Name = "colKono"
        Me.colKono.ReadOnly = True
        Me.colKono.Visible = False
        '
        'scrap_date
        '
        Me.scrap_date.DataPropertyName = "scrap_date"
        Me.scrap_date.HeaderText = "Scrap Date"
        Me.scrap_date.Name = "scrap_date"
        '
        'formYarnScrap
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(860, 349)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.dtpscrap_date)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtDesignNo)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnSearchKI)
        Me.Controls.Add(Me.txtKono)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.dgvYarnScrap)
        Me.Name = "formYarnScrap"
        Me.Text = "Update yarn scrap during production"
        CType(Me.dgvYarnScrap, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgvYarnScrap As System.Windows.Forms.DataGridView
    Friend WithEvents btnSearchKI As System.Windows.Forms.Button
    Friend WithEvents txtKono As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents txtDesignNo As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dtpscrap_date As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cboitcd As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents colYarnPerc As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colYarnOut As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colYarnRet As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colNetOutKg As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colYarnScrap As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colKono As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents scrap_date As YarnStockSystem.DataGridViewCalendarColumn
    Friend WithEvents DataGridViewCalendarColumn1 As YarnStockSystem.DataGridViewCalendarColumn
End Class
