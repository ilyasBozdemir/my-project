Public Class Form1
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        CheckedListBox1.Items.Add(TextBox1.Text)
        CheckedListBox2.Items.Add(TextBox2.Text)
    End Sub
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim indeks As Integer
        indeks = CheckedListBox1.SelectedIndex
        If indeks < 0 Then
            MessageBox.Show("Ya Eleman Seçmediniz, Ya da Bileşen Boş")
        Else
            CheckedListBox1.Items.RemoveAt(indeks)
            CheckedListBox2.Items.RemoveAt(indeks)
        End If
    End Sub

    Private Sub CheckedListBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckedListBox1.SelectedIndexChanged
        Dim indeks, b, t, i As Integer
        indeks = CheckedListBox1.SelectedIndex
        CheckedListBox2.SelectedIndex = indeks
        If indeks < 0 Then Exit Sub
        ' set ayarla get ayarı çek 
        'sette kendin atarsın 
        ' gette kendisi atar varsayılandan  
        CheckedListBox2.SetItemChecked(indeks, CheckedListBox1.GetItemChecked(indeks))
        b = ListBox1.Items.IndexOf(CheckedListBox1.Items(indeks))
        If b < 0 Then
            If Not CheckedListBox1.GetItemChecked(indeks) Then
                ListBox1.Items.Add(CheckedListBox1.Items(indeks).ToString)
                ListBox2.Items.Add(CheckedListBox2.Items(indeks).ToString)
            End If
        End If
        If b >= 0 Then
            If Not CheckedListBox1.GetItemChecked(indeks) Then
                ListBox1.Items.RemoveAt(b)
                ListBox2.Items.RemoveAt(b)
            End If
        End If
        For i = 0 To ListBox1.Items.Count - 1
            t = t + Val(ListBox2.Items(i))

        Next
        Label6.Text = t




    End Sub
    Private Sub CheckedListBox2_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckedListBox2.SelectedIndexChanged
        Dim indeks As Integer
        indeks = CheckedListBox2.SelectedIndex
        CheckedListBox1.SelectedIndex = indeks

    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub
End Class
