Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'CheckedListBox1.SetItemChecked(3, True) '
        'CheckedListBox1.SetItemCheckState(4, CheckState.Checked) '
        'CheckedListBox3.SetSelected(3, True) '
        'CheckedListBox3.CheckOnClick = True 'sec clickle

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim i As Integer
        For i = 0 To CheckedListBox1.Items.Count - 1
            If CheckedListBox1.GetItemChecked(i) Then
                DataGridView1.Rows.Add(DataGridView1.RowCount + 1, CheckedListBox1.Items(i).ToString, ComboBox1.Text, ComboBox2.Text)
                ListBox1.Items.Add((DataGridView1.RowCount + 1).ToString + " " + CheckedListBox1.Items(i).ToString + " " + ComboBox1.Text + " " + ComboBox2.Text)

            End If
        Next
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim i As Integer
        For i = 0 To CheckedListBox2.Items.Count - 1
            If CheckedListBox2.GetItemChecked(i) Then
                DataGridView1.Rows.Add(DataGridView1.RowCount + 1, CheckedListBox2.Items(i).ToString, TextBox1.Text, ComboBox2.Text)
                ListBox1.Items.Add((DataGridView1.RowCount + 1).ToString + " " + CheckedListBox2.Items(i).ToString + " " + TextBox1.Text + " " + ComboBox2.Text)

            End If
        Next
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim i As Integer
        For i = 0 To CheckedListBox3.Items.Count - 1
            If CheckedListBox3.GetItemChecked(i) Then
                DataGridView1.Rows.Add(DataGridView1.RowCount + 1, CheckedListBox3.Items(i).ToString, TextBox1.Text, ComboBox2.Text)
                ListBox1.Items.Add((DataGridView1.RowCount + 1).ToString + " " + CheckedListBox3.Items(i).ToString + " " + TextBox2.Text + " " + ComboBox2.Text)

            End If
        Next
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim i As Integer
        For i = 0 To CheckedListBox4.Items.Count - 1
            If CheckedListBox4.GetItemChecked(i) Then
                DataGridView1.Rows.Add(DataGridView1.RowCount + 1, CheckedListBox4.Items(i).ToString, TextBox3.Text, ComboBox2.Text)
                ListBox1.Items.Add((DataGridView1.RowCount + 1).ToString + " " + CheckedListBox4.Items(i).ToString + " " + TextBox3.Text + " " + ComboBox2.Text)

            End If
        Next
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim i As Integer
        For i = 0 To CheckedListBox5.Items.Count - 1
            If CheckedListBox5.GetItemChecked(i) Then
                DataGridView1.Rows.Add(DataGridView1.RowCount + 1, CheckedListBox5.Items(i).ToString, TextBox4.Text, ComboBox2.Text)
                ListBox1.Items.Add((DataGridView1.RowCount + 1).ToString + " " + CheckedListBox5.Items(i).ToString + " " + TextBox4.Text + " " + ComboBox2.Text)

            End If
        Next
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Dim i As Integer
        For i = 0 To CheckedListBox6.Items.Count - 1
            If CheckedListBox6.GetItemChecked(i) Then
                DataGridView1.Rows.Add(DataGridView1.RowCount + 1, CheckedListBox6.Items(i).ToString, TextBox5.Text, ComboBox2.Text)
                ListBox1.Items.Add((DataGridView1.RowCount + 1).ToString + " " + CheckedListBox6.Items(i).ToString + " " + TextBox5.Text + " " + ComboBox2.Text)

            End If
        Next
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Dim i As Integer
        For i = 0 To CheckedListBox7.Items.Count - 1
            If CheckedListBox7.GetItemChecked(i) Then
                DataGridView1.Rows.Add(DataGridView1.RowCount + 1, CheckedListBox7.Items(i).ToString, TextBox6.Text, ComboBox2.Text)
                ListBox1.Items.Add((DataGridView1.RowCount + 1).ToString + " " + CheckedListBox7.Items(i).ToString + " " + TextBox6.Text + " " + ComboBox2.Text)

            End If
        Next
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        PageSetupDialog1.Document = PrintDocument1
        PageSetupDialog1.ShowDialog()
        PrintDocument1.Print()

    End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Dim asdf As New TextBox
        Dim yazı As String
        Dim i As Integer
        For i = 0 To ListBox1.Items.Count - 1
            yazı = yazı + ListBox1.Items(i).ToString + vbCrLf
        Next
        asdf.Text = yazı
        Dim yenifont As New Font("Arial", 15, FontStyle.Bold)
        e.Graphics.DrawString(asdf.Text, yenifont, Brushes.Black, 100, 100)
    End Sub
End Class


