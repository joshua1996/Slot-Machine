Public Class Form3

    Private Sub Form3_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Form2.Label5.Text = NumericUpDown1.Value
        Form2.Label6.Text = 1
        Me.Close()
    End Sub
End Class