Public Class Form1

    Private Sub DateTimePicker1_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DateTimePicker1.ValueChanged

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        'Me.Text = DateTimePicker1.Value
        Timer1.Enabled = True
        Timer1.Start()

    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        DateTimePicker1.Refresh()
        Me.Text = DateTimePicker1.Value.Date + " " + TimeOfDay.Hour.ToString + ":" + TimeOfDay.Minute.ToString + ":" + TimeOfDay.Second.ToString
        Timer2.Start()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Label1.Text = DateTimePicker1.Value.Date + " " + TextBox1.Text + ":" + TextBox2.Text + ":" + TextBox3.Text
    End Sub

    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer2.Tick

        If (Label1.Text = Me.Text) Then
            AxWindowsMediaPlayer1.URL = "Dillon Francis, DJ Snake - Get Low (MV Ost. Furious 7)"
        End If

    End Sub


    

    Private Sub AxWindowsMediaPlayer1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AxWindowsMediaPlayer1.Enter

    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class
