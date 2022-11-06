Public Class Form1
    Dim x As Integer = 1
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        End
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ListBox1.Items.Clear()
        ListBox1.Refresh()
        TextBox1.text = ""
        x = 1
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Do While (x <= 12)
            ListBox1.Items.Add(x & "*" & Val(TextBox1.Text) & "=" & x * Val(TextBox1.Text))
            x += 1
            ListBox1.Refresh()
        Loop
    End Sub
End Class
