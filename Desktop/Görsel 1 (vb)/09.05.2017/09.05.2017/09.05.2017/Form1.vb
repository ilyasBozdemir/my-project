Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim iller(5) As String
        Dim i As Integer = 0
        iller(0) = "Antalya"
        iller(1) = "Adana"
        iller(2) = "Konya"
        iller(3) = "Urfa"
        iller(4) = "Aydın"
        iller(5) = "Diyarbakır"
        For i = 0 To 5
            ListBox1.Items.Add(iller(i))
        Next
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListBox1.SelectedIndexChanged

    End Sub
End Class
