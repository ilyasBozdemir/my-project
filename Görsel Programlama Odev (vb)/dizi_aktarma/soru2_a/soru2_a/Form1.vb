Public Class Form1
    Dim isimler(5), YeniDizi(5) As String

    Private Sub ListBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListBox1.SelectedIndexChanged

    End Sub

    Private Sub ListBox2_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListBox2.SelectedIndexChanged

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        isimler(0) = "Ali" ''ilyas bozdemir
        isimler(1) = "Mehmet"
        isimler(2) = "İlyas"
        isimler(3) = "Serkan"
        isimler(4) = "Hasan"
        Dim i As Integer = 0
        For i = 0 To 4
            ListBox1.Items.Add(isimler(i))
        Next
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        For i = 0 To 4
            YeniDizi(i) = isimler(i)
            ListBox2.Items.Add(YeniDizi(i))
        Next
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class
