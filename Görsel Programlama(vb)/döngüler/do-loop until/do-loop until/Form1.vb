Public Class Form1

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub TextBox2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox2.TextChanged

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim ilksayı As Integer = Convert.ToInt16(TextBox1.Text)
        Dim ikincisayı As Integer = Convert.ToInt16(TextBox2.Text)
        Dim say As Integer = ilksayı
        Dim toplam As Integer
        toplam = 0
        Do ''ilyas bozdemir
            If (say Mod 2 <> 0) Then
                ListBox3.Items.Add(say)
                toplam += say
            End If ''ilyas bozdemir
            say += 1

        Loop Until say > ikincisayı
        ListBox3.Items.Add("Toplam :" & toplam)
    End Sub

    Private Sub ListBox3_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListBox3.SelectedIndexChanged

    End Sub
End Class
