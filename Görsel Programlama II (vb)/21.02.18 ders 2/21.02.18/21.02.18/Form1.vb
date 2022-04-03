Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'VeritabanıDataSet.Tablo1' table. You can move, or remove it, as needed.
        Me.Tablo1TableAdapter.Fill(Me.VeritabanıDataSet.Tablo1)
        'Provider = Microsoft.ACE.OLEDB.12.0; Data Source = |DataDirectory|\Veritabanı.accdb
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        BindingSource1.AddNew()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim numara As Integer
        numara = BindingSource1.Position
        BindingSource1.RemoveAt(numara)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim numara As Integer = BindingSource1.Position
        If numara <= 0 Then
            MessageBox.Show("zaten ilk kayıttasınız")
        Else
            BindingSource1.MovePrevious()
        End If
    End Sub
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim adet As Integer = BindingSource1.Count
        Dim numara As Integer = BindingSource1.Position
        If numara >= adet - 1 Then
            MessageBox.Show("zaten son kayıttasınız")
        Else
            BindingSource1.MoveNext()
        End If
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        BindingSource1.MoveFirst()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        BindingSource1.MoveLast()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        BindingSource1.EndEdit()
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        BindingSource1.CancelEdit()
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
        TextBox4.Clear()
        TextBox5.Clear()
    End Sub
End Class
