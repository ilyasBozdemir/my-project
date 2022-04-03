Public Class Form1
    Dim ögrenciler(1, 1) As String
    Dim i, j As Integer

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        i = 0
        j = 0
        ögrenciler(0, 0) = "Ali"
        ögrenciler(0, 1) = "Veli"
        ögrenciler(1, 0) = "Ayşe"
        ögrenciler(1, 1) = "Burak"
        For i = 0 To ögrenciler.GetUpperBound(0) ''0 olunca satır sayısını verir.
            For j = 0 To ögrenciler.GetUpperBound(1) ''1 olunca sütun sayısını verir.
                ListBox1.Items.Add(ögrenciler(i, j)) ''UpperBound==> üst sınır demektir.
            Next
        Next
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListBox1.SelectedIndexChanged


    End Sub
End Class
