Public Class Form1
    Dim Rastgele As New Random
    Dim sayi As Integer
    Dim i, j As Integer
    Dim sayıdizi(3, 3) As Integer


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        i = 0
        j = 0

        For i = 0 To 2
            For j = 0 To 2
                sayi = Rastgele.Next(100)
                sayıdizi(i, j) = sayi
                ListBox1.Items.Add(i.ToString + ".satırı ve" _
                    + j.ToString + ".sütunu =" + sayıdizi(i, j).ToString)

            Next
        Next


    End Sub

    Private Sub ListBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListBox1.SelectedIndexChanged

    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim yas As Integer
        yas = Val(InputBox("Yaşı Giriniz"))
        Select Case yas
            Case 0 To 5
                MsgBox("BEBEK".ToString)
            Case 6 To 14
                MsgBox("ÇOCUK".ToString)
            Case 15 To 35
                MsgBox("GENÇ".ToString)
            Case 36 To 45
                MsgBox("ORTA YAŞLI".ToString)
        End Select
        MsgBox("İHTİYAR".ToString)

    End Sub
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class
