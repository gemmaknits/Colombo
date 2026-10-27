Public Class classComboColorPicker
	Inherits System.Windows.Forms.ComboBox
	Private mColors As List(Of Color)

	Public Sub New()
		DrawMode = Windows.Forms.DrawMode.OwnerDrawFixed
		Me.DropDownStyle = ComboBoxStyle.DropDownList
		mColors = New List(Of Color)
		Dim reflect As System.Array = [Enum].GetValues(GetType(KnownColor))
		Dim known(reflect.Length) As KnownColor
		Array.Copy(reflect, known, reflect.Length)
		For ix As Integer = 0 To known.Length - 2
			Dim clr As Color = Color.FromKnownColor(known(ix))
			If Not clr.IsSystemColor Then
				MyBase.Items.Add(clr)
				mColors.Add(clr)
			End If
		Next
	End Sub

	Public Shadows ReadOnly Property Items() As List(Of Color)
		Get
			Return mColors
		End Get
	End Property

	Private Sub ColorComboBox_DrawItem(ByVal sender As Object, ByVal e As System.Windows.Forms.DrawItemEventArgs) Handles Me.DrawItem
		Dim gr As Graphics = e.Graphics
		Dim w As Integer = e.Bounds.Bottom - e.Bounds.Top
		Dim bbr As New SolidBrush(Me.BackColor)
		gr.FillRectangle(bbr, e.Bounds)
		If e.Index >= 0 And e.Index < mColors.Count Then
			Dim rbr As New SolidBrush(mColors(e.Index))
			gr.FillRectangle(rbr, e.Bounds.Left + 2, e.Bounds.Top + 2, w - 4, w - 4)
			If (e.State And DrawItemState.Selected) = DrawItemState.Selected Then gr.FillRectangle(SystemBrushes.Highlight, e.Bounds.Left + w, e.Bounds.Top, e.Bounds.Width - w, e.Bounds.Height)
			Dim tbr As SolidBrush
			If (e.State And DrawItemState.Focus) = DrawItemState.Focus Then tbr = CType(SystemBrushes.HighlightText, SolidBrush) Else tbr = New SolidBrush(e.ForeColor)
			Dim txt As String = mColors(e.Index).ToString
			Dim ix As Integer = txt.IndexOf("[")
			If ix <> 0 Then
				Dim jx As Integer = txt.IndexOf("]")
				If jx > ix Then txt = txt.Substring(ix + 1, jx - ix - 1)
			End If
			If e.Index >= 0 Then gr.DrawString(txt, Me.Font, tbr, e.Bounds.Left + w, e.Bounds.Top)
		Else
			gr.DrawString("Not set", Me.Font, Brushes.Black, e.Bounds.Left, e.Bounds.Top)
		End If
	End Sub
End Class
