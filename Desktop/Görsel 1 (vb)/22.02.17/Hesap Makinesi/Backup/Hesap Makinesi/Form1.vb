Public Class Form1
    Dim isaret As String
    Dim sayi1, sayi2, sonuc, modsonuc As Double
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If TextBox1.Text = "0" Then
            TextBox1.Text = "1"
        Else
            TextBox1.Text = TextBox1.Text + "1"
        End If
    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If TextBox1.Text = "0" Then
            TextBox1.Text = "2"
        Else
            TextBox1.Text = TextBox1.Text + "2"
        End If
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        If TextBox1.Text = "0" Then
            TextBox1.Text = TextBox1.Text + "3"
        Else
            TextBox1.Text = TextBox1.Text + "3"
        End If
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        If TextBox1.Text = "0" Then
            TextBox1.Text = "4"
        Else
            TextBox1.Text = TextBox1.Text + "4"
        End If
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        If TextBox1.Text = "0" Then
            TextBox1.Text = "5"
        Else
            TextBox1.Text = TextBox1.Text + "5"
        End If
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        If TextBox1.Text = "0" Then
            TextBox1.Text = "6"
        Else
            TextBox1.Text = TextBox1.Text + "6"
        End If
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        If TextBox1.Text = "0" Then
            TextBox1.Text = "7"
        Else
            TextBox1.Text = TextBox1.Text + "7"
        End If
    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        If TextBox1.Text = "0" Then
            TextBox1.Text = "8"
        Else
            TextBox1.Text = TextBox1.Text + "8"
        End If
    End Sub

    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click
        If TextBox1.Text = "0" Then
            TextBox1.Text = "9"
        Else
            TextBox1.Text = TextBox1.Text + "9"
        End If
    End Sub

    Private Sub Button11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button11.Click
        If TextBox1.Text = "0" Then
        Else : TextBox1.Text = TextBox1.Text + "0"
        End If
    End Sub

    Private Sub Button10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button10.Click
        TextBox1.Text = ""
        Label1.Text = ""
        isaret = 0
        sayi1 = 0
        sayi2 = 0
        modsonuc = 0
    End Sub

    Private Sub Button12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button12.Click
        Button13.Enabled = False
        ' butonları gösterdik.
        Button13.Enabled = True
        Button14.Enabled = True
        Button15.Enabled = True
        Button16.Enabled = True
        sayi2 = TextBox1.Text
        If isaret = "arti" Then
            sonuc = sayi1 + sayi2
            Label1.Text = sayi1 & "+" & sayi2 & "=" & sonuc
            TextBox1.Text = ""
        ElseIf isaret = "eksi" Then
            sonuc = sayi1 - sayi2
            Label1.Text = sayi1 & "-" & sayi2 & "=" & sonuc
            TextBox1.Text = ""
        ElseIf isaret = "carpma" Then
            sonuc = sayi1 * sayi2
            Label1.Text = sayi1 & "*" & sayi2 & "=" & sonuc
            TextBox1.Text = ""
        ElseIf isaret = "bolme" Then
            sonuc = sayi1 / sayi2
            modsonuc = sayi1 Mod sayi2
            Label1.Text = sayi1 & "/" & sayi2 & "=" & sonuc & vbNewLine & "Kalan :" & modsonuc
            TextBox1.Text = ""

        End If
    End Sub

    Private Sub Button13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button13.Click
        isaret = "arti"
        sayi1 = TextBox1.Text
        Label1.Text = sayi1 & "+"
        TextBox1.Text = ""
        '
        Button13.Enabled = True
        ' butonları gizledik
        Button13.Enabled = False
        Button14.Enabled = False
        Button15.Enabled = False
        Button16.Enabled = False


    End Sub

    Private Sub Button16_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button16.Click
        isaret = "bolme"
        sayi1 = TextBox1.Text
        Label1.Text = sayi1 & "/"
        TextBox1.Text = ""
        Button13.Enabled = True
        ' butonları gizledik
        Button13.Enabled = False
        Button14.Enabled = False
        Button15.Enabled = False
        Button16.Enabled = False
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button14.Click
        isaret = "eksi"
        sayi1 = TextBox1.Text
        Label1.Text = sayi1 & "-"
        TextBox1.Text = ""
        Button13.Enabled = True
        ' butonları gizledik
        Button13.Enabled = False
        Button14.Enabled = False
        Button15.Enabled = False
        Button16.Enabled = False
    End Sub

    Private Sub Button15_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button15.Click
        isaret = "carpma"
        sayi1 = TextBox1.Text
        Label1.Text = sayi1 & "*"
        TextBox1.Text = ""
        Button13.Enabled = True
        ' butonları gizledik
        Button13.Enabled = False
        Button14.Enabled = False
        Button15.Enabled = False
        Button16.Enabled = False
    End Sub
End Class
