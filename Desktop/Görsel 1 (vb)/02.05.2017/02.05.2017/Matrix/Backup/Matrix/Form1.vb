Public Class Form1

    Private Sub ListBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListBox1.SelectedIndexChanged

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim Dizidenal(,) As String
        Dim ilk, orta, son As ArrayList
        ilk = New ArrayList
        ilk.AddRange(ListBox1.Items)
        orta = New ArrayList
        orta.AddRange(ListBox2.Items)
        son = New ArrayList
        son.AddRange(ListBox3.Items)
        Dizidenal = tabloyagönder(ilk, orta, son)
        For i As Integer = 0 To Dizidenal.GetUpperBound(0)
            ListView1.Items.Add(Dizidenal(i, 0))
            ListView1.Items(i).SubItems.Add(Dizidenal(i, 1))
            ListView1.Items(i).SubItems.Add(Dizidenal(i, 2))
        Next
    End Sub
    Private Function tabloyagönder(ByVal adlar As ArrayList, ByVal adresler As ArrayList, ByVal telefon As ArrayList)
        Dim dizideğer(,) As String
        Dim adet, i As Integer
        adet = adlar.Count
        ReDim dizideğer(adet, 3)
        Dim dizioku As IEnumerator = adlar.GetEnumerator

        Do While (dizioku.MoveNext())
            dizideğer(i, 0) = dizioku.Current.ToString
            i += 1
        Loop
        i = 0
        dizioku = adresler.GetEnumerator
        '
        Do While (dizioku.MoveNext())
            dizideğer(i, 1) = dizioku.Current.ToString
            i += 1 ''bir sonra ki satır için 
        Loop
        i = 0
        dizioku = telefon.GetEnumerator
        Do While (dizioku.MoveNext())
            dizideğer(i, 2) = dizioku.Current.ToString
            i += 1 ''bir sonra ki satır için 
        Loop
        i = 0
        Return dizideğer
    End Function
End Class
