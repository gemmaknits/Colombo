<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmListOfValues
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
        Me.lblEnterText = New System.Windows.Forms.Label()
        Me.txtFilterText = New System.Windows.Forms.TextBox()
        Me.dgvSearchTable = New System.Windows.Forms.DataGridView()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.tspbStatusProgress = New System.Windows.Forms.ToolStripProgressBar()
        Me.lblStatusMessage = New System.Windows.Forms.ToolStripStatusLabel()
        Me.lblStatusUserID = New System.Windows.Forms.ToolStripStatusLabel()
        Me.lblStatusSessionID = New System.Windows.Forms.ToolStripStatusLabel()
        Me.lblStatusDatabase = New System.Windows.Forms.ToolStripStatusLabel()
        Me.lblStatusMode = New System.Windows.Forms.ToolStripStatusLabel()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnNone = New System.Windows.Forms.Button()
        Me.btnOK = New System.Windows.Forms.Button()
        CType(Me.dgvSearchTable, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblEnterText
        '
        Me.lblEnterText.AutoSize = True
        Me.lblEnterText.Location = New System.Drawing.Point(12, 9)
        Me.lblEnterText.Name = "lblEnterText"
        Me.lblEnterText.Size = New System.Drawing.Size(57, 13)
        Me.lblEnterText.TabIndex = 0
        Me.lblEnterText.Text = "Enter Text"
        '
        'txtFilterText
        '
        Me.txtFilterText.Location = New System.Drawing.Point(87, 9)
        Me.txtFilterText.Name = "txtFilterText"
        Me.txtFilterText.Size = New System.Drawing.Size(217, 22)
        Me.txtFilterText.TabIndex = 1
        '
        'dgvSearchTable
        '
        Me.dgvSearchTable.AllowUserToAddRows = False
        Me.dgvSearchTable.AllowUserToDeleteRows = False
        Me.dgvSearchTable.AllowUserToResizeRows = False
        Me.dgvSearchTable.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvSearchTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvSearchTable.Location = New System.Drawing.Point(15, 46)
        Me.dgvSearchTable.Name = "dgvSearchTable"
        Me.dgvSearchTable.Size = New System.Drawing.Size(675, 348)
        Me.dgvSearchTable.TabIndex = 2
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tspbStatusProgress, Me.lblStatusMessage, Me.lblStatusUserID, Me.lblStatusSessionID, Me.lblStatusDatabase, Me.lblStatusMode})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 425)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(702, 24)
        Me.StatusStrip1.TabIndex = 3
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'tspbStatusProgress
        '
        Me.tspbStatusProgress.Name = "tspbStatusProgress"
        Me.tspbStatusProgress.Size = New System.Drawing.Size(100, 18)
        Me.tspbStatusProgress.Visible = False
        '
        'lblStatusMessage
        '
        Me.lblStatusMessage.BorderSides = CType((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Right), System.Windows.Forms.ToolStripStatusLabelBorderSides)
        Me.lblStatusMessage.BorderStyle = System.Windows.Forms.Border3DStyle.Etched
        Me.lblStatusMessage.Name = "lblStatusMessage"
        Me.lblStatusMessage.Size = New System.Drawing.Size(450, 19)
        Me.lblStatusMessage.Spring = True
        '
        'lblStatusUserID
        '
        Me.lblStatusUserID.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right
        Me.lblStatusUserID.BorderStyle = System.Windows.Forms.Border3DStyle.Etched
        Me.lblStatusUserID.Name = "lblStatusUserID"
        Me.lblStatusUserID.Size = New System.Drawing.Size(90, 19)
        Me.lblStatusUserID.Text = "lblStatusUserID"
        '
        'lblStatusSessionID
        '
        Me.lblStatusSessionID.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right
        Me.lblStatusSessionID.BorderStyle = System.Windows.Forms.Border3DStyle.Etched
        Me.lblStatusSessionID.Name = "lblStatusSessionID"
        Me.lblStatusSessionID.Size = New System.Drawing.Size(50, 19)
        Me.lblStatusSessionID.Text = "Session"
        '
        'lblStatusDatabase
        '
        Me.lblStatusDatabase.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right
        Me.lblStatusDatabase.BorderStyle = System.Windows.Forms.Border3DStyle.Etched
        Me.lblStatusDatabase.Name = "lblStatusDatabase"
        Me.lblStatusDatabase.Size = New System.Drawing.Size(59, 19)
        Me.lblStatusDatabase.Text = "Database"
        '
        'lblStatusMode
        '
        Me.lblStatusMode.Name = "lblStatusMode"
        Me.lblStatusMode.Size = New System.Drawing.Size(38, 19)
        Me.lblStatusMode.Text = "Mode"
        '
        'btnCancel
        '
        Me.btnCancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCancel.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.Image = My.Resources.Resources.Exit_16x
        Me.btnCancel.Location = New System.Drawing.Point(615, 400)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel.TabIndex = 6
        Me.btnCancel.Text = "Exit"
        Me.btnCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnNone
        '
        Me.btnNone.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnNone.Image = My.Resources.Resources.None_16x
        Me.btnNone.Location = New System.Drawing.Point(535, 400)
        Me.btnNone.Name = "btnNone"
        Me.btnNone.Size = New System.Drawing.Size(75, 23)
        Me.btnNone.TabIndex = 5
        Me.btnNone.Text = "None"
        Me.btnNone.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnNone.UseVisualStyleBackColor = True
        '
        'btnOK
        '
        Me.btnOK.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnOK.Image = My.Resources.Resources.ConfirmButton_16x
        Me.btnOK.Location = New System.Drawing.Point(454, 400)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(75, 23)
        Me.btnOK.TabIndex = 4
        Me.btnOK.Text = "Ok"
        Me.btnOK.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnOK.UseVisualStyleBackColor = True
        '
        'frmListOfValues
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(702, 449)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnNone)
        Me.Controls.Add(Me.btnOK)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.dgvSearchTable)
        Me.Controls.Add(Me.txtFilterText)
        Me.Controls.Add(Me.lblEnterText)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "frmListOfValues"
        Me.Text = "List Of Value Form"
        CType(Me.dgvSearchTable, System.ComponentModel.ISupportInitialize).EndInit()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblEnterText As Label
    Friend WithEvents txtFilterText As TextBox
    Friend WithEvents dgvSearchTable As DataGridView
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents tspbStatusProgress As ToolStripProgressBar
    Friend WithEvents lblStatusMessage As ToolStripStatusLabel
    Friend WithEvents lblStatusUserID As ToolStripStatusLabel
    Friend WithEvents lblStatusSessionID As ToolStripStatusLabel
    Friend WithEvents lblStatusDatabase As ToolStripStatusLabel
    Friend WithEvents lblStatusMode As ToolStripStatusLabel
    Friend WithEvents btnOK As Button
    Friend WithEvents btnNone As Button
    Friend WithEvents btnCancel As Button
End Class
