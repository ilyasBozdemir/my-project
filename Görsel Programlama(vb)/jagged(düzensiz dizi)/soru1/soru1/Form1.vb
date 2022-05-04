Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim DüzensizDizi(5) As Integer
        Dim i As Integer
        Dim rastgele As New Random ''ilyas bozdemir
        DüzensizDizi(0) = New Integer = DüzensizDizi(1)
        DüzensizDizi(1) = New Integer = DüzensizDizi(2)
        DüzensizDizi(2) = New Integer = DüzensizDizi(3)
        DüzensizDizi(3) = New Integer = DüzensizDizi(4)
        DüzensizDizi(4) = New Integer = DüzensizDizi(5)
        ListBox1.Items.Add("DüzensizDizi(0) ==> 2 tane :")
        For i = 0 To 1
            DüzensizDizi(0) = i
            ListBox1.Items.Add(DüzensizDizi(0).ToString)
        Next
        ListBox1.Items.Add(" ")
        ListBox1.Items.Add("DüzensizDizi(1) ==> 3 tane :")
        ListBox1.Items.Add(" ") ''ilyas bozdemir
        For i = 0 To 2
            DüzensizDizi(1) = i
            ListBox1.Items.Add(DüzensizDizi(1).ToString)
        Next
        ListBox1.Items.Add(" ") ''ilyas bozdemir
        ListBox1.Items.Add("DüzensizDizi(2) ==> 4 tane :")
        ListBox1.Items.Add(" ")
        For i = 0 To 3
            DüzensizDizi(2) = i
            ListBox1.Items.Add(DüzensizDizi(2).ToString)
        Next
        ListBox1.Items.Add(" ")
        ListBox1.Items.Add("DüzensizDizi(3) ==> 5 tane :")
        ListBox1.Items.Add(" ")
        For i = 0 To 4
            DüzensizDizi(3) = i
            ListBox1.Items.Add(DüzensizDizi(3).ToString)
        Next
        ListBox1.Items.Add(" ")
        ListBox1.Items.Add("DüzensizDizi(4) ==> 6 tane :")
        ListBox1.Items.Add(" ")
        For i = 0 To 5
            DüzensizDizi(4) = i
            ListBox1.Items.Add(DüzensizDizi(4).ToString)
        Next
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListBox1.SelectedIndexChanged

    End Sub
End Class
