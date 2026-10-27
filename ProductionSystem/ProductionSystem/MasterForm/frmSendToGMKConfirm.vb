Imports System.Drawing
Imports System.Windows.Forms

'=====================================================================
' Confirmation window of the "Send to GMK" button (created 16/10/2026)
' Shows the values that would change in GMK; the user presses Send or Cancel.
' The flow of the button is in frmDesignNew (SendToGmkFlow), the data work is in classDesignNew.
' This form is built in code, it has no Designer file.
'=====================================================================
Public Class frmSendToGMKConfirm
    Inherits Form

    Public Sub New(ByVal designNo As String, ByVal diff As classDesignNew.DiffResult)
        Me.Text = "Send to GMK"
        Me.StartPosition = FormStartPosition.CenterParent
        Me.Size = New Size(860, 560)
        Me.MinimizeBox = False
        Me.ShowInTaskbar = False

        'list of differences (fills the middle)
        Dim lv As New ListView
        lv.Dock = DockStyle.Fill
        lv.View = View.Details
        lv.FullRowSelect = True
        lv.GridLines = True
        lv.HideSelection = False
        lv.Columns.Add("Field", 230)
        lv.Columns.Add("GMK (current)", 290)
        lv.Columns.Add("Eschler (will be sent)", 290)
        For Each item As classDesignNew.DiffItem In diff.Items
            Dim li As New ListViewItem(item.Field)
            li.SubItems.Add(item.GmkValue)
            li.SubItems.Add(item.EschlerValue)
            lv.Items.Add(li)
        Next

        'notes at the bottom of the list
        Dim txtNote As New TextBox
        txtNote.Dock = DockStyle.Bottom
        txtNote.Multiline = True
        txtNote.ReadOnly = True
        txtNote.ScrollBars = ScrollBars.Vertical
        txtNote.Height = 90
        Dim note As String = "หมายเหตุ: ไม่ส่ง Machine group และสถานะ/เวอร์ชัน Spec ไป GMK"
        If diff.Warnings.Count > 0 Then
            note &= vbCrLf & "ค่าที่ไม่ได้ส่ง (ตามกติกา):" & vbCrLf & String.Join(vbCrLf, diff.Warnings.ToArray())
        End If
        txtNote.Text = note

        'buttons
        'buttons are lined up from the right edge (RightToLeft: the first one added is the rightmost)
        Dim pnlButtons As New FlowLayoutPanel
        pnlButtons.Dock = DockStyle.Bottom
        pnlButtons.Height = 50
        pnlButtons.FlowDirection = FlowDirection.RightToLeft
        pnlButtons.Padding = New Padding(10, 8, 10, 8)
        Dim btnCancel As New Button
        btnCancel.Text = "Cancel"
        btnCancel.Size = New Size(120, 30)
        btnCancel.DialogResult = DialogResult.Cancel
        Dim btnSend As New Button
        btnSend.Text = "Send to GMK"
        btnSend.Size = New Size(120, 30)
        btnSend.DialogResult = DialogResult.OK
        pnlButtons.Controls.Add(btnCancel)
        pnlButtons.Controls.Add(btnSend)
        Me.CancelButton = btnCancel   'no default "send" button: Enter must not send by accident

        'header
        Dim lblInfo As New Label
        lblInfo.Dock = DockStyle.Top
        lblInfo.Height = 56
        lblInfo.Padding = New Padding(8, 8, 8, 0)
        lblInfo.Text = "Design No.: " & designNo & vbCrLf & _
                       "ค่าต่อไปนี้ใน GMK จะถูกแทนที่ด้วยค่าจาก Eschler (" & diff.Items.Count.ToString() & " รายการ)"

        'the fill control is added first, the docked edges after it
        Me.Controls.Add(lv)
        Me.Controls.Add(txtNote)
        Me.Controls.Add(pnlButtons)
        Me.Controls.Add(lblInfo)
    End Sub

End Class
