<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDOUTDocument
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDOUTDocument))
        Me.btnSearchOutno = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.OptLotNo = New System.Windows.Forms.RadioButton()
        Me.OptDesignNo = New System.Windows.Forms.RadioButton()
        Me.txtOUTNO = New System.Windows.Forms.TextBox()
        Me.lblDINNO = New System.Windows.Forms.Label()
        Me.btnMinimized = New System.Windows.Forms.ToolStripButton()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.btnPrint = New System.Windows.Forms.ToolStripButton()
        Me.btnExit = New System.Windows.Forms.ToolStripButton()
        Me.GroupBox1.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnSearchOutno
        '
        Me.btnSearchOutno.Image = CType(resources.GetObject("btnSearchOutno.Image"), System.Drawing.Image)
        Me.btnSearchOutno.Location = New System.Drawing.Point(168, 51)
        Me.btnSearchOutno.Name = "btnSearchOutno"
        Me.btnSearchOutno.Size = New System.Drawing.Size(30, 23)
        Me.btnSearchOutno.TabIndex = 203
        Me.btnSearchOutno.Text = "PackingList Dyes & Out"
        Me.btnSearchOutno.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.OptLotNo)
        Me.GroupBox1.Controls.Add(Me.btnSearchOutno)
        Me.GroupBox1.Controls.Add(Me.OptDesignNo)
        Me.GroupBox1.Controls.Add(Me.txtOUTNO)
        Me.GroupBox1.Controls.Add(Me.lblDINNO)
        Me.GroupBox1.Location = New System.Drawing.Point(5, 31)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(212, 93)
        Me.GroupBox1.TabIndex = 208
        Me.GroupBox1.TabStop = False
        '
        'OptLotNo
        '
        Me.OptLotNo.AutoSize = True
        Me.OptLotNo.Checked = True
        Me.OptLotNo.Location = New System.Drawing.Point(15, 19)
        Me.OptLotNo.Name = "OptLotNo"
        Me.OptLotNo.Size = New System.Drawing.Size(75, 17)
        Me.OptLotNo.TabIndex = 204
        Me.OptLotNo.TabStop = True
        Me.OptLotNo.Text = "By Lot No."
        Me.OptLotNo.UseVisualStyleBackColor = True
        '
        'OptDesignNo
        '
        Me.OptDesignNo.AutoSize = True
        Me.OptDesignNo.Location = New System.Drawing.Point(101, 19)
        Me.OptDesignNo.Name = "OptDesignNo"
        Me.OptDesignNo.Size = New System.Drawing.Size(93, 17)
        Me.OptDesignNo.TabIndex = 205
        Me.OptDesignNo.Text = "By Design No."
        Me.OptDesignNo.UseVisualStyleBackColor = True
        '
        'txtOUTNO
        '
        Me.txtOUTNO.Location = New System.Drawing.Point(66, 53)
        Me.txtOUTNO.Name = "txtOUTNO"
        Me.txtOUTNO.Size = New System.Drawing.Size(96, 20)
        Me.txtOUTNO.TabIndex = 200
        '
        'lblDINNO
        '
        Me.lblDINNO.AutoSize = True
        Me.lblDINNO.Location = New System.Drawing.Point(5, 53)
        Me.lblDINNO.Name = "lblDINNO"
        Me.lblDINNO.Size = New System.Drawing.Size(58, 13)
        Me.lblDINNO.TabIndex = 202
        Me.lblDINNO.Text = "DOUT No."
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
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnPrint, Me.btnMinimized, Me.btnExit})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(223, 25)
        Me.ToolStrip1.TabIndex = 207
        '
        'btnPrint
        '
        Me.btnPrint.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnPrint.Image = CType(resources.GetObject("btnPrint.Image"), System.Drawing.Image)
        Me.btnPrint.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(23, 22)
        Me.btnPrint.Text = "&Print"
        '
        'btnExit
        '
        Me.btnExit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnExit.Image = CType(resources.GetObject("btnExit.Image"), System.Drawing.Image)
        Me.btnExit.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(23, 22)
        Me.btnExit.Text = "E&xit"
        '
        'frmDOUTDocument
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(223, 131)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmDOUTDocument"
        Me.Text = "DOUT Document"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnSearchOutno As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents OptLotNo As System.Windows.Forms.RadioButton
    Friend WithEvents OptDesignNo As System.Windows.Forms.RadioButton
    Friend WithEvents txtOUTNO As System.Windows.Forms.TextBox
    Friend WithEvents lblDINNO As System.Windows.Forms.Label
    Friend WithEvents btnMinimized As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents btnPrint As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnExit As System.Windows.Forms.ToolStripButton
End Class
