<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSearchMFGRouting
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
        Me.lblRouting = New System.Windows.Forms.Label()
        Me.txtStrrouting_code = New System.Windows.Forms.TextBox()
        Me.grddata = New System.Windows.Forms.DataGridView()
        Me.btnOK = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnNone = New System.Windows.Forms.Button()
        Me.btnRefresh2 = New System.Windows.Forms.Button()
        Me.colMfgRoutingHeaderId = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.routing_code = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.routing_name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.routing_status = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.created_by = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.last_modified_by = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.grddata, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblRouting
        '
        Me.lblRouting.AutoSize = True
        Me.lblRouting.Location = New System.Drawing.Point(30, 9)
        Me.lblRouting.Name = "lblRouting"
        Me.lblRouting.Size = New System.Drawing.Size(99, 13)
        Me.lblRouting.TabIndex = 3
        Me.lblRouting.Text = "Filter Routing No."
        '
        'txtStrrouting_code
        '
        Me.txtStrrouting_code.Location = New System.Drawing.Point(33, 25)
        Me.txtStrrouting_code.Name = "txtStrrouting_code"
        Me.txtStrrouting_code.Size = New System.Drawing.Size(132, 22)
        Me.txtStrrouting_code.TabIndex = 2
        '
        'grddata
        '
        Me.grddata.AllowUserToAddRows = False
        Me.grddata.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grddata.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colMfgRoutingHeaderId, Me.routing_code, Me.routing_name, Me.routing_status, Me.created_by, Me.last_modified_by})
        Me.grddata.Location = New System.Drawing.Point(33, 56)
        Me.grddata.Name = "grddata"
        Me.grddata.Size = New System.Drawing.Size(697, 319)
        Me.grddata.TabIndex = 46
        '
        'btnOK
        '
        Me.btnOK.Location = New System.Drawing.Point(497, 381)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(75, 23)
        Me.btnOK.TabIndex = 47
        Me.btnOK.Text = "Ok"
        Me.btnOK.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(655, 381)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 48
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnNone
        '
        Me.btnNone.Location = New System.Drawing.Point(578, 381)
        Me.btnNone.Name = "btnNone"
        Me.btnNone.Size = New System.Drawing.Size(75, 23)
        Me.btnNone.TabIndex = 49
        Me.btnNone.Text = "None"
        Me.btnNone.UseVisualStyleBackColor = True
        '
        'btnRefresh2
        '
        Me.btnRefresh2.Image = Global.ProductionSystem.My.Resources.Resources.Refresh_16x
        Me.btnRefresh2.Location = New System.Drawing.Point(171, 25)
        Me.btnRefresh2.Name = "btnRefresh2"
        Me.btnRefresh2.Size = New System.Drawing.Size(71, 25)
        Me.btnRefresh2.TabIndex = 45
        Me.btnRefresh2.Text = "&Refresh"
        Me.btnRefresh2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnRefresh2.UseVisualStyleBackColor = True
        '
        'colMfgRoutingHeaderId
        '
        Me.colMfgRoutingHeaderId.DataPropertyName = "mfg_routing_header_id"
        Me.colMfgRoutingHeaderId.HeaderText = "mfg_routing_header_id"
        Me.colMfgRoutingHeaderId.Name = "colMfgRoutingHeaderId"
        Me.colMfgRoutingHeaderId.ReadOnly = True
        Me.colMfgRoutingHeaderId.Visible = False
        '
        'routing_code
        '
        Me.routing_code.DataPropertyName = "routing_code"
        Me.routing_code.HeaderText = "Routing Code"
        Me.routing_code.Name = "routing_code"
        Me.routing_code.ReadOnly = True
        '
        'routing_name
        '
        Me.routing_name.DataPropertyName = "routing_name"
        Me.routing_name.HeaderText = "Routing Name"
        Me.routing_name.Name = "routing_name"
        Me.routing_name.ReadOnly = True
        Me.routing_name.Width = 50
        '
        'routing_status
        '
        Me.routing_status.DataPropertyName = "routing_status"
        Me.routing_status.HeaderText = "Routing Status"
        Me.routing_status.Name = "routing_status"
        Me.routing_status.ReadOnly = True
        '
        'created_by
        '
        Me.created_by.DataPropertyName = "created_by"
        Me.created_by.HeaderText = "Created By"
        Me.created_by.Name = "created_by"
        Me.created_by.ReadOnly = True
        '
        'last_modified_by
        '
        Me.last_modified_by.DataPropertyName = "last_modified_by"
        Me.last_modified_by.HeaderText = "Last Modified By"
        Me.last_modified_by.Name = "last_modified_by"
        Me.last_modified_by.ReadOnly = True
        '
        'frmSearchMFGRouting
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(739, 416)
        Me.Controls.Add(Me.btnNone)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnOK)
        Me.Controls.Add(Me.lblRouting)
        Me.Controls.Add(Me.txtStrrouting_code)
        Me.Controls.Add(Me.grddata)
        Me.Controls.Add(Me.btnRefresh2)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "frmSearchMFGRouting"
        Me.Text = "Search Routing"
        CType(Me.grddata, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblRouting As System.Windows.Forms.Label
    Friend WithEvents txtStrrouting_code As System.Windows.Forms.TextBox
    Friend WithEvents grddata As System.Windows.Forms.DataGridView
    Friend WithEvents btnRefresh2 As System.Windows.Forms.Button
    Friend WithEvents btnOK As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents btnNone As Button
    Friend WithEvents colMfgRoutingHeaderId As DataGridViewTextBoxColumn
    Friend WithEvents routing_code As DataGridViewTextBoxColumn
    Friend WithEvents routing_name As DataGridViewTextBoxColumn
    Friend WithEvents routing_status As DataGridViewTextBoxColumn
    Friend WithEvents created_by As DataGridViewTextBoxColumn
    Friend WithEvents last_modified_by As DataGridViewTextBoxColumn
End Class
