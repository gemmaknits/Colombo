Imports System.Drawing.Drawing2D

Public Class frmSplashScreen
	Dim clsConfig As New clsConfig
	Dim intSecond As Long = 0
	Dim bmp As Bitmap
	Dim bak As New Bitmap(clsConfig.GetImagePath & "k_background.bmp")

	Private Function BitmapToRegion(ByVal img As Bitmap) As Region
		On Error Resume Next
		Dim height As Integer = img.Height
		Dim width As Integer = img.Width
		Dim path As New GraphicsPath()
		Dim i As Integer
		Dim j As Integer
		Dim col As Color = Color.FromArgb(255, 255, 255)

		For j = 0 To (height - 1)
			For i = 0 To (width - 1)
				If Not img.GetPixel(i, j).Equals(col) Then
					Dim x0 As Integer = i
					Do While ((i < width) AndAlso (Not img.GetPixel(i, j).Equals(col)))
						i += 1
					Loop
					path.AddRectangle(New Rectangle(x0, j, i - x0, 1))
				End If
			Next
		Next
		Dim region As New Region(path)
		path.Dispose()
		Return region
	End Function

	Protected Overrides Sub OnPaintBackground(ByVal e As PaintEventArgs)
		On Error Resume Next
		Dim grfx As Graphics = e.Graphics
		grfx.PageUnit = GraphicsUnit.Pixel
		Dim offScreenGraphics As Graphics
		Dim offScreenBitmap As Bitmap
		offScreenBitmap = New Bitmap(bmp.Width, bmp.Height)
		offScreenGraphics = Graphics.FromImage(offScreenBitmap)
		If Not bmp Is Nothing Then offScreenGraphics.DrawImage(bmp, 0, 0, bmp.Width, bmp.Height)
		grfx.DrawImage(offScreenBitmap, 0, 0)
	End Sub

	Private Sub frmSplashScreen_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
		On Error Resume Next
		bmp = New Bitmap(clsConfig.GetImagePath & "k" & ((Now.Millisecond Mod 9) + 1) & ".bmp")
		Me.Opacity = 0
		Me.BackgroundImage = bmp
		Me.BackgroundImageLayout = ImageLayout.Center
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.ShowInTaskbar = False
		Me.CenterToScreen()
		With Screen.PrimaryScreen.WorkingArea
			Me.SetBounds((.Width - bmp.Width) / 2 _
			  , (.Height - bmp.Height) / 2 _
			  , bmp.Width _
			  , bmp.Height)
		End With
		Me.Region = BitmapToRegion(bak)
		clsConfig.FadeIn(Me, 0.01)
	End Sub

	Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
		On Error Resume Next
		intSecond += 1
		If intSecond = 30 Then
			Call clsConfig.FadeOut(Me, 0.01)
			Dim frm As New frmLogin
			frm.Show()
			Me.Close()
		End If
	End Sub
End Class