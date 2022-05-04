Public Class Form1
    Dim sayılar(5, 5) As Integer
    Dim bosdizi(5, 5) As Integer
    Dim i As Integer = 0
    Dim j As Integer = 0
    Dim sayı As Integer
    Dim rastgele As New Random


    Private Sub ListBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListBox1.SelectedIndexChanged

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        For i = 0 To 4
            For j = 0 To 4
                sayı = rastgele.Next(100)
                sayılar(i, j) = sayı ''ilyas bozdemir
                ListBox1.Items.Add(i.ToString + ".satır ve" + j.ToString + ". Sütun verisi :" + sayılar(i, j).ToString)
            Next

        Next

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        bosdizi(i, j) = sayılar(i, j)
        For i = 0 To 4
            For j = 0 To 4 ''ilyas bozdemir
                bosdizi(i, j) = sayılar(i, j)
                ListBox2.Items.Add(i.ToString + ".satır ve" + j.ToString + ". Sütun verisi :" + sayılar(i, j).ToString)
            Next

        Next

    End Sub

    Private Sub ListBox2_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListBox2.SelectedIndexChanged

    End Sub
End Class
