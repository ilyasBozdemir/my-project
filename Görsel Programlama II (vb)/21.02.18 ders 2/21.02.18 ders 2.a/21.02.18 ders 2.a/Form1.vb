Imports System.Data.OleDb
Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim myBaglantiMetni As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\Veritabanı.accdb"
        Dim mySql As String = "Select * From Tablo1"
        Dim myBaglanti As New OleDbConnection(myBaglantiMetni)
        Dim myAdapter As New OleDbDataAdapter(mySql, myBaglanti)
        Dim myDataTable As New DataTable()
        myAdapter.Fill(myDataTable)
        Dim myDataSet As New DataSet()
        myDataSet.Tables.Add(myDataTable)
        BindingSource1.DataSource = myDataSet
        BindingSource1.DataMember = myDataSet.Tables(0).TableName
        '
        TextBox1.DataBindings.Add("Text", BindingSource1, "TC_No")
        TextBox2.DataBindings.Add("Text", BindingSource1, "Adı_soyadı")
        TextBox3.DataBindings.Add("Text", BindingSource1, "Adresi")
        TextBox4.DataBindings.Add("Text", BindingSource1, "Telefonu")
        TextBox5.DataBindings.Add("Text", BindingSource1, "E_mail")
        DateTimePicker1.DataBindings.Add("Text", BindingSource1, "Dogum_tarihi")
        '
    End Sub
End Class
