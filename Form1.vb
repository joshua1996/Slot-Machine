Imports System.Drawing

Public Class Form1

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load


        'PictureBox1.Image = My.Resources.reel_overlay
        'PictureBox1.Width = My.Resources.reel_overlay.Width
        'PictureBox1.Height = My.Resources.reel_overlay.Height

        'PictureBox2.Image = My.Resources.reel_strip
        'PictureBox2.Width = My.Resources.reel_strip.Width
        'PictureBox2.Height = My.Resources.reel_strip.Height

        'PictureBox3.Image = My.Resources.main_bg_machine
        'PictureBox3.Width = My.Resources.main_bg_machine.Width
        'PictureBox3.Height = My.Resources.main_bg_machine.Height

        'Console.WriteLine(PictureBox2.Width & " " & PictureBox2.Height)

        '    PictureBox3.BackColor = Color.Transparent
        'PictureBox1.Parent = PictureBox3
        'PictureBox1.Size = PictureBox3.Size
        'PictureBox1.BackColor = Color.Transparent

        Dim OverlayImage As New Bitmap(My.Resources.reel_overlay)
        Dim BackImage As New Bitmap(My.Resources.main_bg_machine)
        Dim reelStrip As New Bitmap(My.Resources.reel_strip)
        Dim g As Graphics = Graphics.FromImage(BackImage)

        g.DrawImage(OverlayImage, 311, 300)
        g.DrawImage(reelStrip, 0, 0)

        PictureBox1.Image = BackImage
        PictureBox1.Width = My.Resources.main_bg_machine.Width
        PictureBox1.Height = My.Resources.main_bg_machine.Height

        Me.Height = PictureBox1.Height + 100
        Me.Width = PictureBox1.Width + 100
    End Sub

    Private Sub Form1_Paint(sender As Object, e As System.Windows.Forms.PaintEventArgs) Handles Me.Paint
        'Dim i = PictureBox1
        'e.Graphics.DrawImageUnscaled(i.Image, New Point(i.Left, i.Top))
        'Dim j = PictureBox3
        'e.Graphics.DrawImageUnscaled(i.Image, New Point(j.Left, j.Top))
        'e.Graphics.Flush()

    End Sub
End Class
