Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Panel1.Visible = Not Panel1.Visible
        If Panel1.Visible Then
            Button1.Text = "Hide"
        Else Button1.Text = "Show"
        End If
    End Sub
    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        PictureBox1.Visible = False
        If RadioButton1.Checked Then
            PictureBox1.Visible = True
        End If
    End Sub
    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        PictureBox2.Visible = False
        If RadioButton2.Checked Then
            PictureBox2.Visible = True
        End If
    End Sub
    Private Sub RadioButton3_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton3.CheckedChanged
        PictureBox3.Visible = False
        If RadioButton3.Checked Then
            PictureBox3.Visible = True
        End If
    End Sub
    Private Sub RadioButton4_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton4.CheckedChanged
        PictureBox4.Visible = False
        If RadioButton4.Checked Then
            PictureBox4.Visible = True
        End If
    End Sub
    'Public Sub
    'Select Case True
    '        Case RadioButton1.checked
    '            picturebox1.visible = True
    '        Case RadioButton1.checked
    '            picturebox1.visible = True
    '        Case RadioButton1.checked
    '            picturebox1.visible = True
    '    End Select
    'End Sub
End Class
