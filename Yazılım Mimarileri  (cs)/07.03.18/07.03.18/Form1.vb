Imports System.Data.OleDb
Public Class Form1
    Dim Al As New DataSet
    Dim Yönet As CurrencyManager
    Dim ilişki As DataRelation
    Dim VeriAl, VeriAl2 As OleDbDataAdapter
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim Yeni As New OleDbConnection("Provider=Microsoft.Ace.OleDb.12.0;Data Source=|DataDirectory|/db.accdb")
        VeriAl = New OleDbDataAdapter("Select * from Kitap", Yeni)
        VeriAl2 = New OleDbDataAdapter("Select * from KitapSatis", Yeni)
        VeriAl.Fill(Al, "Kitap")
        VeriAl2.Fill(Al, "KitapSatis")
        ilişki = Al.Relations.Add("iliski", Al.Tables(0).Columns(0), Al.Tables(1).Columns(1), False)
        Dim kısıtla As New ForeignKeyConstraint(Al.Tables("Kitap").Columns("KitapAdi"), Al.Tables("KitapSatis").Columns("KitapAdi"))
        kısıtla.UpdateRule = Rule.Cascade
        kısıtla.DeleteRule = Rule.SetNull
        Al.Tables("KitapSatis").Constraints.Add(kısıtla)
        Al.EnforceConstraints = True
        DataGridView1.DataSource = Al
        DataGridView1.DataMember = Al.Tables(0).TableName
        '
        DataGridView2.DataSource = Al
        DataGridView2.DataMember = "Kitap.iliski"
        '
        Yönet = DirectCast(Me.BindingContext(Al, "Kitap"), CurrencyManager)
        Dim Satır As DataRow = Al.Tables(0).Rows(Yönet.Position)
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Math.Max(System.Threading.Interlocked.Increment(Yönet.Position), Yönet.Position + 1)
        Dim satir As DataRow = Al.Tables(0).Rows(Yönet.Position)
        DataGridView2.DataSource = Al
        DataGridView2.DataMember = "Kitap.iliski"
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Math.Max(System.Threading.Interlocked.Decrement(Yönet.Position), Yönet.Position + 1)
        Dim satir As DataRow = Al.Tables(0).Rows(Yönet.Position)
        DataGridView2.DataSource = Al
        DataGridView2.DataMember = "Kitap.iliski"
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim Uygula As New OleDbCommandBuilder(VeriAl)
        Dim Uygula2 As New OleDbCommandBuilder(VeriAl2)
        VeriAl.Update(Al.Tables(0))
        VeriAl2.Update(Al.Tables(1))
    End Sub
End Class
