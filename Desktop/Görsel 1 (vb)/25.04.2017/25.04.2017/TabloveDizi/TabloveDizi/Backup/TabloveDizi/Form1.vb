Public Class Form1

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        DataGridView1.Rows(0).Cells(0).Value = "ilyas"
        DataGridView1.Rows(0).Cells(1).Value = "ermenek"
        DataGridView1.Rows(0).Cells(2).Value = "05370358669"
    End Sub
    Dim veriler(,) As String
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        ReDim veriler(DataGridView1.Rows.Count - 1, DataGridView1.ColumnCount - 1)
        Dim i, j As Integer
        i = 0
        j = 0
        For i = 0 To veriler.GetUpperBound(1) - 1 'satır
            For j = 0 To veriler.GetUpperBound(0) - 1 'sütun
                veriler(i, j) = Convert.ToString(DataGridView1(i, j).Value.ToString)
            Next
        Next
    End Sub

    Private Sub TextBox2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox2.TextChanged

    End Sub
    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Dim i, j As Integer
        i = 0
        j = 0
        For i = 0 To veriler.GetUpperBound(1) - 1 'satır
            For j = 0 To veriler.GetUpperBound(0) - 1 'sütun
                Select Case (j)
                    Case 0
                        ListBox1.Items.Add(veriler(i, j).ToString)
                    Case 1
                        ListBox2.Items.Add(veriler(i, j).ToString)
                    Case 2
                        ListBox3.Items.Add(veriler(i, j).ToString)
                End Select

            Next
        Next
    End Sub
End Class
