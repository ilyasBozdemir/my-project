Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged
       
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim Mk, cocuk, aileyard As Double
        Mk = Val(TextBox1.Text)
        '' cocuk = Val(TextBox1.Text)
        If CheckBox1.Checked = False Then
            aileyard = 0
        Else

            cocuk = Val(TextBox1.Text)
            If cocuk > 2 Then
                cocuk = 2
                If CheckBox2.Checked Then
                    aileyard = cocuk * 250 * Mk
                Else
                    aileyard = cocuk * 250 * Mk + 50 * Mk
                End If
            End If
        End If
        Label3.Text = aileyard.ToString
    End Sub


    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged

    End Sub
End Class












