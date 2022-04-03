Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim isimler(4) As String ''4 elemanlı isimler dizisi olusturduk
        isimler(0) = "halil"
        isimler(1) = "hale"
        isimler(2) = "cabbar"
        isimler(3) = "mehmet"
        Dim i As Integer = 0
        For i = 0 To 3
            ListBox1.Items.Add(isimler(i)) ''isimler dizisini listbox'a ekle 
        Next

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim Rastgele As New Random ''rastgele sınıfı olusturduk
        Dim Sayi As Integer  ''rastgele sınıfı değişkene atadık
        Dim sayıdizi(3, 3) As Integer '' dizi olusturalım.
        Dim i, j As Integer
        i = 0
        j = 0
        ''dizilere rastgele sayı atamak için
        For i = 0 To 2
            For j = 0 To 2
                Sayi = Rastgele.Next(1, 100)
                sayıdizi(i, j) = Sayi
                'ListBox2.Items.Add(i.ToString + ".Satır ve " + j.ToString + ".Sütun Verisi :" + sayıdizi(i, j).ToString)
            Next
        Next
        For i = 0 To 2
            For j = 0 To 2
                ListBox2.Items.Add(i.ToString + ".Satır ve " + j.ToString + ".Sütun Verisi :" + sayıdizi(i, j).ToString)
            Next
        Next
        ListBox2.Items.Add("          -----**-----**-----**-----             ") '' ara geçiş için 
    End Sub

    Private Sub TextBox2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox2.TextChanged

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim ilksayı As Integer = Convert.ToInt16(TextBox1.Text)
        Dim ikincisayı As Integer = Convert.ToInt16(TextBox2.Text)
        Dim say As Integer = ilksayı
        Dim toplam As Integer
        toplam = 0
        'Do While say <= ikincisayı

        '    If (say Mod 2 <> 0) Then
        '        ListBox3.Items.Add(say)
        '    End If
        '    say += 1
        'Loop
        Do While say <= ikincisayı ''tek sayılar toplamı
            If (say Mod 2 <> 0) Then ''mod alma
                ListBox3.Items.Add(say)
                toplam += say
            End If
            say += 1
        Loop
        ListBox3.Items.Add("Toplam :" & toplam)
    End Sub
End Class
