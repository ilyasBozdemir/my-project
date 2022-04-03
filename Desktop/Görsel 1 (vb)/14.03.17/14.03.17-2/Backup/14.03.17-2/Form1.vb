Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    

    Private Sub TextBox2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox2.TextChanged, TextBox3.TextAlignChanged, CheckBox1.CheckStateChanged, CheckBox2.CheckStateChanged
        Dim a, bf, t As Double
        bf = Val(TextBox2.Text)
        a = Val(TextBox3.Text)
        t = bf * a
        If CheckBox1.Checked Then
            t = t + t * 0.18
        End If
        If CheckBox2.Checked Then
            t = t - t * 0.25
        End If
        Label5.Text = TextBox1.Text + " malzemesi için " + t.ToString + " tl "
    End Sub

    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2.Click

    End Sub

    Private Sub CheckBox2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox2.CheckedChanged

    End Sub

    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim a, bf, t As Double
        bf = Val(TextBox2.Text)
        a = Val(TextBox3.Text)
        t = bf * a
        If CheckBox1.Checked Then
            t = t + t * 0.18
        End If
        If CheckBox2.Checked Then
            t = t - t * 0.25
        End If
        Label5.Text = TextBox1.Text + " malzemesi için " + t.ToString + " tl "





    End Sub

    

    Private Sub TextBox2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox2.TextChanged

    End Sub
End Class







