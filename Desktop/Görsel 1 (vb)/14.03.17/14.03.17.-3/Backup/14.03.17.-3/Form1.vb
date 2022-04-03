Public Class Form1

    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged
        TextBox1.Font = New Font(TextBox1.Font, TextBox1.Font.Style Xor FontStyle.Bold)





    End Sub

    Private Sub CheckBox2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox2.CheckedChanged
        TextBox1.Font = New Font(TextBox1.Font, TextBox1.Font.Style Xor FontStyle.Italic)
    End Sub

    Private Sub CheckBox3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox3.CheckedChanged
        TextBox1.Font = New Font(TextBox1.Font, TextBox1.Font.Style Xor FontStyle.Underline)
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class
