Imports System.Data.OleDb
Public Class Form3

    Dim conn As New OleDbConnection("provider=microsoft.jet.oledb.4.0; data source =parcalar.mdb;")
    Dim da As New OleDbDataAdapter("select * from anakart", conn)
    Dim ds As New DataSet()
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        da.Fill(ds)
        TextBox1.DataBindings.Add("text", ds.Tables(0), "id")
        TextBox2.DataBindings.Add("text", ds.Tables(0), "Parça_Adı")
        TextBox3.DataBindings.Add("text", ds.Tables(0), "Parça_Fiyatı")
        ListView1.View = View.Details
        ListView1.GridLines = True
        ListView1.Columns.Add("id", 20, HorizontalAlignment.Left)
        ListView1.Columns.Add("Parça Adı", 800, HorizontalAlignment.Left)
        ListView1.Columns.Add("Parça Fiyatı", 80, HorizontalAlignment.Left)


        Dim baglan As OleDb.OleDbConnection = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source='parcalar.mdb'")
        Dim adp As New OleDb.OleDbDataAdapter()
        adp.SelectCommand = New OleDb.OleDbCommand("Select * From anakart", baglan)
        baglan.Open()
        Dim ds1 As New DataSet()
        adp.Fill(ds1)
        baglan.Close()
        Dim item As New ListViewItem
        For Each row As DataRow In ds1.Tables(0).Rows
            item = ListView1.Items.Add(row.Item("id"))
            item.SubItems.Add(row.Item("Parça_Adı"))
            item.SubItems.Add(row.Item("Parça_Fiyatı"))
            item.SubItems.Add(row.Item("id"))
        Next

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        BindingContext(ds.Tables(0)).Position = 0

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        BindingContext(ds.Tables(0)).Position -= 1
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        BindingContext(ds.Tables(0)).Position += 1
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        BindingContext(ds.Tables(0)).Position = (BindingContext(ds.Tables(0)).Count - 1)
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click

        Dim conn1 As New OleDbConnection("provider=microsoft.jet.oledb.4.0; data source =parcalar.mdb;")
        Dim da1 As New OleDbDataAdapter("select * from islemci", conn)
        Dim ds1 As New DataSet()
        da1.Fill(ds1)
        TextBox1.DataBindings.Add("text", ds1.Tables(0), "id")
        TextBox2.DataBindings.Add("text", ds1.Tables(0), "Parça_Adı")
        TextBox3.DataBindings.Add("text", ds1.Tables(0), "Parça_Fiyatı")
        ListView1.View = View.Details
        ListView1.GridLines = True
        ListView1.Columns.Add("id", 20, HorizontalAlignment.Left)
        ListView1.Columns.Add("Parça Adı", 800, HorizontalAlignment.Left)
        ListView1.Columns.Add("Parça Fiyatı", 80, HorizontalAlignment.Left)


        Dim baglan As OleDb.OleDbConnection = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source='parcalar.mdb'")
        Dim adp As New OleDb.OleDbDataAdapter()
        adp.SelectCommand = New OleDb.OleDbCommand("Select * From islemci", baglan)
        baglan.Open()
        adp.Fill(ds1)
        baglan.Close()
        Dim item As New ListViewItem
        For Each row As DataRow In ds1.Tables(0).Rows
            item = ListView1.Items.Add(row.Item("id"))
            item.SubItems.Add(row.Item("Parça_Adı"))
            item.SubItems.Add(row.Item("Parça_Fiyatı"))
            item.SubItems.Add(row.Item("id"))
        Next
    End Sub
End Class
