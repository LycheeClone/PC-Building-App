Imports System.Data.OleDb

Public Class Form4

    Private Sub listele(ByVal SQL As String)
        Dim baglanti As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0; Data Source='VERITABANI.mdb'")
        Dim veriler As New DataTable("veriler")
        Dim adapter As New OleDbDataAdapter(SQL, baglanti)
        adapter.Fill(veriler)
        DataGridView1.DataSource = veriler
    End Sub

    'Private Sub anakartListele(ByVal SQL As String)
    '    Dim baglanti As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0; Data Source='VERITABANI.mdb'")
    '    Dim anakartveri As New DataTable("veriler")
    '    Dim adapter As New OleDbDataAdapter(SQL, baglanti)
    '    adapter.Fill(anakartveri)
    '    DataGridView2.DataSource = anakartveri
    'End Sub
    'Private Sub ekranKartıListele(ByVal SQL As String)
    '    Dim baglanti As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0; Data Source='VERITABANI.mdb'")
    '    Dim ekranveri As New DataTable("veriler")
    '    Dim adapter As New OleDbDataAdapter(SQL, baglanti)
    '    adapter.Fill(ekranveri)
    '    DataGridView4.DataSource = ekranveri
    'End Sub
    'Private Sub ramListele(ByVal SQL As String)
    '    Dim baglanti As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0; Data Source='VERITABANI.mdb'")
    '    Dim ramveri As New DataTable("veriler")
    '    Dim adapter As New OleDbDataAdapter(SQL, baglanti)
    '    adapter.Fill(ramveri)
    '    DataGridView3.DataSource = ramveri
    'End Sub
    'Private Sub kasaListele(ByVal SQL As String)
    '    Dim baglanti As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0; Data Source='VERITABANI.mdb'")
    '    Dim kasaveri As New DataTable("veriler")
    '    Dim adapter As New OleDbDataAdapter(SQL, baglanti)
    '    adapter.Fill(kasaveri)
    '    DataGridView2.DataSource = kasaveri
    'End Sub
    'Private Sub gücKaynagıListele(ByVal SQL As String)
    '    Dim baglanti As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0; Data Source='VERITABANI.mdb'")
    '    Dim gücveri As New DataTable("veriler")
    '    Dim adapter As New OleDbDataAdapter(SQL, baglanti)
    '    adapter.Fill(gücveri)
    '    DataGridView2.DataSource = gücveri
    'End Sub
    'Private Sub hardDiskListele(ByVal SQL As String)
    '    Dim baglanti As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0; Data Source='VERITABANI.mdb'")
    '    Dim hddveri As New DataTable("veriler")
    '    Dim adapter As New OleDbDataAdapter(SQL, baglanti)
    '    adapter.Fill(hddveri)
    '    DataGridView2.DataSource = hddveri
    'End Sub
    'Private Sub SSDListele(ByVal SQL As String)
    '    Dim baglanti As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0; Data Source='VERITABANI.mdb'")
    '    Dim ssdveri As New DataTable("veriler")
    '    Dim adapter As New OleDbDataAdapter(SQL, baglanti)
    '    adapter.Fill(ssdveri)
    '    DataGridView2.DataSource = ssdveri
    'End Sub
    Private Sub Temizle()
        TextBox1.Clear()
        TextBox2.Clear()
    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'For x = 0 To DataGridView1.Rows.Count + 1
        DataGridView1.EditMode = DataGridViewEditMode.EditProgrammatically
        DataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        listele("SELECT * FROM islemci,anakart,ekrankartı,RAM,Kasa,GücKaynagı,HardDisk,SSD'")
        'Next
        ComboBox1.Items.Add("İşlemci")
        ComboBox1.Items.Add("Anakart")
        ComboBox1.Items.Add("Ekran Kartı")
        ComboBox1.Items.Add("RAM")
        ComboBox1.Items.Add("Kasa")
        ComboBox1.Items.Add("Güç Kaynağı")
        ComboBox1.Items.Add("Hard Disk")
        ComboBox1.Items.Add("SSD")




    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click


        If ComboBox1.Text = "İşlemci" Then
            Dim durum As String
            durum = MsgBox("Parça Adı = " & TextBox1.Text & vbNewLine & "Parça Fiyatı = " & TextBox2.Text & vbNewLine & "Girmiş Olduğunuz Verilerin Kayıt Edilmesini Onaylıyor Musunuz? ", MsgBoxStyle.Question + MsgBoxStyle.YesNoCancel, "Kayıt Uyarı")
            If durum = vbYes Then
                Dim sql As New String("INSERT INTO islemci (Parça_Adı,Parça_Fiyatı) values ('{0}','{1}')")
                sql = String.Format(sql, TextBox1.Text, TextBox2.Text)
                Dim baglanti As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0; Data Source='VERITABANI.mdb'")
                Dim komutnesnesi As New OleDb.OleDbCommand(sql, baglanti)
                Dim sonuc As Integer
                baglanti.Open()
                sonuc = komutnesnesi.ExecuteNonQuery()
                If sonuc = 1 Then
                    MsgBox("Girmiş Olduğunuz Veriler Veri Tabanına Kayıt Edilmiştir.", MsgBoxStyle.Exclamation, "Kayıt Uyarı")
                End If
                listele("SELECT * FROM islemci'")
                baglanti.Close()
                Temizle()
            Else

            End If

        ElseIf ComboBox1.Text = "Anakart" Then
            Dim durum As String
            durum = MsgBox("Parça Adı = " & TextBox1.Text & vbNewLine & "Parça Fiyatı = " & TextBox2.Text & vbNewLine & "Girmiş Olduğunuz Verilerin Kayıt Edilmesini Onaylıyor Musunuz? ", MsgBoxStyle.Question + MsgBoxStyle.YesNoCancel, "Kayıt Uyarı")
            If durum = vbYes Then
                Dim sql As New String("INSERT INTO anakart (Parça_Adı,Parça_Fiyatı) values ('{0}','{1}')")
                sql = String.Format(sql, TextBox1.Text, TextBox2.Text)
                Dim baglanti As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0; Data Source='VERITABANI.mdb'")
                Dim komutnesnesi As New OleDb.OleDbCommand(sql, baglanti)
                Dim sonuc As Integer
                baglanti.Open()
                sonuc = komutnesnesi.ExecuteNonQuery()
                If sonuc = 1 Then
                    MsgBox("Girmiş Olduğunuz Veriler Veri Tabanına Kayıt Edilmiştir.", MsgBoxStyle.Exclamation, "Kayıt Uyarı")
                End If
                listele("SELECT * FROM anakart'")
                baglanti.Close()
                Temizle()
            End If

        ElseIf ComboBox1.Text = "Ekran Kartı" Then
            Dim durum As String
            durum = MsgBox("Parça Adı = " & TextBox1.Text & vbNewLine & "Parça Fiyatı = " & TextBox2.Text & vbNewLine & "Girmiş Olduğunuz Verilerin Kayıt Edilmesini Onaylıyor Musunuz? ", MsgBoxStyle.Question + MsgBoxStyle.YesNoCancel, "Kayıt Uyarı")
            If durum = vbYes Then
                Dim sql As New String("INSERT INTO ekrankartı (Parça_Adı,Parça_Fiyatı) values ('{0}','{1}')")
                sql = String.Format(sql, TextBox1.Text, TextBox2.Text)
                Dim baglanti As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0; Data Source='VERITABANI.mdb'")
                Dim komutnesnesi As New OleDb.OleDbCommand(sql, baglanti)
                Dim sonuc As Integer
                baglanti.Open()
                sonuc = komutnesnesi.ExecuteNonQuery()
                If sonuc = 1 Then
                    MsgBox("Girmiş Olduğunuz Veriler Veri Tabanına Kayıt Edilmiştir.", MsgBoxStyle.Exclamation, "Kayıt Uyarı")
                End If
                listele("SELECT * FROM ekrankartı'")
                baglanti.Close()
                Temizle()
            End If

        ElseIf ComboBox1.Text = "RAM" Then
            Dim durum As String
            durum = MsgBox("Parça Adı = " & TextBox1.Text & vbNewLine & "Parça Fiyatı = " & TextBox2.Text & vbNewLine & "Girmiş Olduğunuz Verilerin Kayıt Edilmesini Onaylıyor Musunuz? ", MsgBoxStyle.Question + MsgBoxStyle.YesNoCancel, "Kayıt Uyarı")
            If durum = vbYes Then
                Dim sql As New String("INSERT INTO RAM (Parça_Adı,Parça_Fiyatı) values ('{0}','{1}')")
                sql = String.Format(sql, TextBox1.Text, TextBox2.Text)
                Dim baglanti As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0; Data Source='VERITABANI.mdb'")
                Dim komutnesnesi As New OleDb.OleDbCommand(sql, baglanti)
                Dim sonuc As Integer
                baglanti.Open()
                sonuc = komutnesnesi.ExecuteNonQuery()
                If sonuc = 1 Then
                    MsgBox("Girmiş Olduğunuz Veriler Veri Tabanına Kayıt Edilmiştir.", MsgBoxStyle.Exclamation, "Kayıt Uyarı")
                End If
                listele("SELECT * FROM RAM'")
                baglanti.Close()
                Temizle()
            End If

        ElseIf ComboBox1.Text = "Kasa" Then
            Dim durum As String
            durum = MsgBox("Parça Adı = " & TextBox1.Text & vbNewLine & "Parça Fiyatı = " & TextBox2.Text & vbNewLine & "Girmiş Olduğunuz Verilerin Kayıt Edilmesini Onaylıyor Musunuz? ", MsgBoxStyle.Question + MsgBoxStyle.YesNoCancel, "Kayıt Uyarı")
            If durum = vbYes Then
                Dim sql As New String("INSERT INTO Kasa (Parça_Adı,Parça_Fiyatı) values ('{0}','{1}')")
                sql = String.Format(sql, TextBox1.Text, TextBox2.Text)
                Dim baglanti As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0; Data Source='VERITABANI.mdb'")
                Dim komutnesnesi As New OleDb.OleDbCommand(sql, baglanti)
                Dim sonuc As Integer
                baglanti.Open()
                sonuc = komutnesnesi.ExecuteNonQuery()
                If sonuc = 1 Then
                    MsgBox("Girmiş Olduğunuz Veriler Veri Tabanına Kayıt Edilmiştir.", MsgBoxStyle.Exclamation, "Kayıt Uyarı")
                End If
                listele("SELECT * FROM Kasa'")
                baglanti.Close()
                Temizle()
            End If

        ElseIf ComboBox1.Text = "Güç Kaynağı" Then
            Dim durum As String
            durum = MsgBox("Parça Adı = " & TextBox1.Text & vbNewLine & "Parça Fiyatı = " & TextBox2.Text & vbNewLine & "Girmiş Olduğunuz Verilerin Kayıt Edilmesini Onaylıyor Musunuz? ", MsgBoxStyle.Question + MsgBoxStyle.YesNoCancel, "Kayıt Uyarı")
            If durum = vbYes Then
                Dim sql As New String("INSERT INTO GücKaynagı (Parça_Adı,Parça_Fiyatı) values ('{0}','{1}')")
                sql = String.Format(sql, TextBox1.Text, TextBox2.Text)
                Dim baglanti As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0; Data Source='VERITABANI.mdb'")
                Dim komutnesnesi As New OleDb.OleDbCommand(sql, baglanti)
                Dim sonuc As Integer
                baglanti.Open()
                sonuc = komutnesnesi.ExecuteNonQuery()
                If sonuc = 1 Then
                    MsgBox("Girmiş Olduğunuz Veriler Veri Tabanına Kayıt Edilmiştir.", MsgBoxStyle.Exclamation, "Kayıt Uyarı")
                End If
                listele("SELECT * FROM GücKaynagı'")
                baglanti.Close()
                Temizle()
            End If

        ElseIf ComboBox1.Text = "Hard Disk" Then
            Dim durum As String
            durum = MsgBox("Parça Adı = " & TextBox1.Text & vbNewLine & "Parça Fiyatı = " & TextBox2.Text & vbNewLine & "Girmiş Olduğunuz Verilerin Kayıt Edilmesini Onaylıyor Musunuz? ", MsgBoxStyle.Question + MsgBoxStyle.YesNoCancel, "Kayıt Uyarı")
            If durum = vbYes Then
                Dim sql As New String("INSERT INTO HardDisk (Parça_Adı,Parça_Fiyatı) values ('{0}','{1}')")
                sql = String.Format(sql, TextBox1.Text, TextBox2.Text)
                Dim baglanti As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0; Data Source='VERITABANI.mdb'")
                Dim komutnesnesi As New OleDb.OleDbCommand(sql, baglanti)
                Dim sonuc As Integer
                baglanti.Open()
                sonuc = komutnesnesi.ExecuteNonQuery()
                If sonuc = 1 Then
                    MsgBox("Girmiş Olduğunuz Veriler Veri Tabanına Kayıt Edilmiştir.", MsgBoxStyle.Exclamation, "Kayıt Uyarı")
                End If
                listele("SELECT * FROM HardDisk'")
                baglanti.Close()
                Temizle()
            End If

        ElseIf ComboBox1.Text = "SSD" Then
            Dim durum As String
            durum = MsgBox("Parça Adı = " & TextBox1.Text & vbNewLine & "Parça Fiyatı = " & TextBox2.Text & vbNewLine & "Girmiş Olduğunuz Verilerin Kayıt Edilmesini Onaylıyor Musunuz? ", MsgBoxStyle.Question + MsgBoxStyle.YesNoCancel, "Kayıt Uyarı")
            If durum = vbYes Then
                Dim sql As New String("INSERT INTO SSD (Parça_Adı,Parça_Fiyatı) values ('{0}','{1}')")
                sql = String.Format(sql, TextBox1.Text, TextBox2.Text)
                Dim baglanti As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0; Data Source='VERITABANI.mdb'")
                Dim komutnesnesi As New OleDb.OleDbCommand(sql, baglanti)
                Dim sonuc As Integer
                baglanti.Open()
                sonuc = komutnesnesi.ExecuteNonQuery()
                If sonuc = 1 Then
                    MsgBox("Girmiş Olduğunuz Veriler Veri Tabanına Kayıt Edilmiştir.", MsgBoxStyle.Exclamation, "Kayıt Uyarı")
                End If
                listele("SELECT * FROM SSD'")
                baglanti.Close()
                Temizle()
            End If
        End If




    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If ComboBox1.Text = "İşlemci" Then
            Dim sql As New String("UPDATE islemci SET Parça_Adı='{0}',Parça_Fiyatı='{1}' WHERE Parça_Adı='{2}' AND Parça_Fiyatı='{3}'")
            sql = String.Format(sql, TextBox1.Text, TextBox2.Text, DataGridView1.CurrentRow.Cells(1).Value, DataGridView1.CurrentRow.Cells(2).Value)
            Dim baglanti As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0; Data Source='VERITABANI.mdb'")
            Dim komutnesnesi As New OleDb.OleDbCommand(sql, baglanti)
            Dim sonuc As Integer
            baglanti.Open()
            sonuc = komutnesnesi.ExecuteNonQuery()
            If sonuc = 1 Then
                MsgBox("Değiştirmiş Olduğunuz Veriler Güncellenmiştir.", MsgBoxStyle.Exclamation, "Kayıt Uyarı")

            End If
            listele("SELECT * FROM islemci'")
            baglanti.Close()
            Temizle()
        End If

        If ComboBox1.Text = "Anakart" Then
            Dim sql As New String("UPDATE anakart SET Parça_Adı='{0}',Parça_Fiyatı='{1}' WHERE Parça_Adı='{2}' AND Parça_Fiyatı='{3}'")
            sql = String.Format(sql, TextBox1.Text, TextBox2.Text, DataGridView1.CurrentRow.Cells(1).Value, DataGridView1.CurrentRow.Cells(2).Value)
            Dim baglanti As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0; Data Source='VERITABANI.mdb'")
            Dim komutnesnesi As New OleDb.OleDbCommand(sql, baglanti)
            Dim sonuc As Integer
            baglanti.Open()
            sonuc = komutnesnesi.ExecuteNonQuery()
            If sonuc = 1 Then
                MsgBox("Değiştirmiş Olduğunuz Veriler Güncellenmiştir.", MsgBoxStyle.Exclamation, "Kayıt Uyarı")

            End If
            listele("SELECT * FROM anakart'")
            baglanti.Close()
            Temizle()
        End If

        If ComboBox1.Text = "Ekran Kartı" Then
            Dim sql As New String("UPDATE ekrankartı SET Parça_Adı='{0}',Parça_Fiyatı='{1}' WHERE Parça_Adı='{2}' AND Parça_Fiyatı='{3}'")
            sql = String.Format(sql, TextBox1.Text, TextBox2.Text, DataGridView1.CurrentRow.Cells(1).Value, DataGridView1.CurrentRow.Cells(2).Value)
            Dim baglanti As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0; Data Source='VERITABANI.mdb'")
            Dim komutnesnesi As New OleDb.OleDbCommand(sql, baglanti)
            Dim sonuc As Integer
            baglanti.Open()
            sonuc = komutnesnesi.ExecuteNonQuery()
            If sonuc = 1 Then
                MsgBox("Değiştirmiş Olduğunuz Veriler Güncellenmiştir.", MsgBoxStyle.Exclamation, "Kayıt Uyarı")

            End If
            listele("SELECT * FROM ekrankartı'")
            baglanti.Close()
            Temizle()
        End If

        If ComboBox1.Text = "RAM" Then
            Dim sql As New String("UPDATE RAM SET Parça_Adı='{0}',Parça_Fiyatı='{1}' WHERE Parça_Adı='{2}' AND Parça_Fiyatı='{3}'")
            sql = String.Format(sql, TextBox1.Text, TextBox2.Text, DataGridView1.CurrentRow.Cells(1).Value, DataGridView1.CurrentRow.Cells(2).Value)
            Dim baglanti As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0; Data Source='VERITABANI.mdb'")
            Dim komutnesnesi As New OleDb.OleDbCommand(sql, baglanti)
            Dim sonuc As Integer
            baglanti.Open()
            sonuc = komutnesnesi.ExecuteNonQuery()
            If sonuc = 1 Then
                MsgBox("Değiştirmiş Olduğunuz Veriler Güncellenmiştir.", MsgBoxStyle.Exclamation, "Kayıt Uyarı")

            End If
            listele("SELECT * FROM RAM'")
            baglanti.Close()
            Temizle()
        End If

        If ComboBox1.Text = "Kasa" Then
            Dim sql As New String("UPDATE Kasa SET Parça_Adı='{0}',Parça_Fiyatı='{1}' WHERE Parça_Adı='{2}' AND Parça_Fiyatı='{3}'")
            sql = String.Format(sql, TextBox1.Text, TextBox2.Text, DataGridView1.CurrentRow.Cells(1).Value, DataGridView1.CurrentRow.Cells(2).Value)
            Dim baglanti As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0; Data Source='VERITABANI.mdb'")
            Dim komutnesnesi As New OleDb.OleDbCommand(sql, baglanti)
            Dim sonuc As Integer
            baglanti.Open()
            sonuc = komutnesnesi.ExecuteNonQuery()
            If sonuc = 1 Then
                MsgBox("Değiştirmiş Olduğunuz Veriler Güncellenmiştir.", MsgBoxStyle.Exclamation, "Kayıt Uyarı")

            End If
            listele("SELECT * FROM Kasa'")
            baglanti.Close()
            Temizle()
        End If

        If ComboBox1.Text = "Güç Kaynağı" Then
            Dim sql As New String("UPDATE GücKaynagı SET Parça_Adı='{0}',Parça_Fiyatı='{1}' WHERE Parça_Adı='{2}' AND Parça_Fiyatı='{3}'")
            sql = String.Format(sql, TextBox1.Text, TextBox2.Text, DataGridView1.CurrentRow.Cells(1).Value, DataGridView1.CurrentRow.Cells(2).Value)
            Dim baglanti As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0; Data Source='VERITABANI.mdb'")
            Dim komutnesnesi As New OleDb.OleDbCommand(sql, baglanti)
            Dim sonuc As Integer
            baglanti.Open()
            sonuc = komutnesnesi.ExecuteNonQuery()
            If sonuc = 1 Then
                MsgBox("Değiştirmiş Olduğunuz Veriler Güncellenmiştir.", MsgBoxStyle.Exclamation, "Kayıt Uyarı")

            End If
            listele("SELECT * FROM GücKaynagı'")
            baglanti.Close()
            Temizle()
        End If

        If ComboBox1.Text = "Hard Disk" Then
            Dim sql As New String("UPDATE HardDisk SET Parça_Adı='{0}',Parça_Fiyatı='{1}' WHERE Parça_Adı='{2}' AND Parça_Fiyatı='{3}'")
            sql = String.Format(sql, TextBox1.Text, TextBox2.Text, DataGridView1.CurrentRow.Cells(1).Value, DataGridView1.CurrentRow.Cells(2).Value)
            Dim baglanti As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0; Data Source='VERITABANI.mdb'")
            Dim komutnesnesi As New OleDb.OleDbCommand(sql, baglanti)
            Dim sonuc As Integer
            baglanti.Open()
            sonuc = komutnesnesi.ExecuteNonQuery()
            If sonuc = 1 Then
                MsgBox("Değiştirmiş Olduğunuz Veriler Güncellenmiştir.", MsgBoxStyle.Exclamation, "Kayıt Uyarı")

            End If
            listele("SELECT * FROM HardDisk'")
            baglanti.Close()
            Temizle()
        End If

        If ComboBox1.Text = "SSD" Then
            Dim sql As New String("UPDATE SSD SET Parça_Adı='{0}',Parça_Fiyatı='{1}' WHERE Parça_Adı='{2}' AND Parça_Fiyatı='{3}'")
            sql = String.Format(sql, TextBox1.Text, TextBox2.Text, DataGridView1.CurrentRow.Cells(1).Value, DataGridView1.CurrentRow.Cells(2).Value)
            Dim baglanti As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0; Data Source='VERITABANI.mdb'")
            Dim komutnesnesi As New OleDb.OleDbCommand(sql, baglanti)
            Dim sonuc As Integer
            baglanti.Open()
            sonuc = komutnesnesi.ExecuteNonQuery()
            If sonuc = 1 Then
                MsgBox("Değiştirmiş Olduğunuz Veriler Güncellenmiştir.", MsgBoxStyle.Exclamation, "Kayıt Uyarı")

            End If
            listele("SELECT * FROM SSD'")
            baglanti.Close()
            Temizle()
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        'Dim sql As New String("DELETE FROM VERI WHERE Parça_Adı='{0}' AND Parça_Fiyatı='{1}'")
        'sql = String.Format(sql, TextBox1.Text, TextBox2.Text)
        'Dim baglanti As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0; Data Source='VERITABANI.mdb'")
        'Dim komutnesnesi As New OleDb.OleDbCommand(sql, baglanti)
        'Dim sonuc As Integer
        'baglanti.Open()
        'sonuc = komutnesnesi.ExecuteNonQuery()
        'If sonuc = 1 Then
        '    MsgBox("Seçmiş Olduğunuz Veri Silinmiştir.", MsgBoxStyle.Exclamation, "Kayıt Uyarı")

        'End If
        'listele("SELECT * FROM VERI'")
        'baglanti.Close()
        'Temizle()
        If ComboBox1.Text = "İşlemci" Then
            Dim sql As New String("DELETE FROM islemci WHERE Parça_Adı='{0}' AND Parça_Fiyatı='{1}'")
            sql = String.Format(sql, TextBox1.Text, TextBox2.Text)
            Dim baglanti As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0; Data Source='VERITABANI.mdb'")
            Dim komutnesnesi As New OleDb.OleDbCommand(sql, baglanti)
            Dim sonuc As Integer
            baglanti.Open()
            sonuc = komutnesnesi.ExecuteNonQuery()
            If sonuc = 1 Then
                MsgBox("Seçmiş Olduğunuz Veri Silinmiştir.", MsgBoxStyle.Exclamation, "Kayıt Uyarı")

            End If
            listele("SELECT * FROM islemci'")
            baglanti.Close()
            Temizle()
        End If

        If ComboBox1.Text = "Anakart" Then
            Dim sql As New String("DELETE FROM anakart WHERE Parça_Adı='{0}' AND Parça_Fiyatı='{1}'")
            sql = String.Format(sql, TextBox1.Text, TextBox2.Text)
            Dim baglanti As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0; Data Source='VERITABANI.mdb'")
            Dim komutnesnesi As New OleDb.OleDbCommand(sql, baglanti)
            Dim sonuc As Integer
            baglanti.Open()
            sonuc = komutnesnesi.ExecuteNonQuery()
            If sonuc = 1 Then
                MsgBox("Seçmiş Olduğunuz Veri Silinmiştir.", MsgBoxStyle.Exclamation, "Kayıt Uyarı")

            End If
            listele("SELECT * FROM anakart'")
            baglanti.Close()
            Temizle()
        End If

        If ComboBox1.Text = "Ekran Kartı" Then
            Dim sql As New String("DELETE FROM ekrankartı WHERE Parça_Adı='{0}' AND Parça_Fiyatı='{1}'")
            sql = String.Format(sql, TextBox1.Text, TextBox2.Text)
            Dim baglanti As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0; Data Source='VERITABANI.mdb'")
            Dim komutnesnesi As New OleDb.OleDbCommand(sql, baglanti)
            Dim sonuc As Integer
            baglanti.Open()
            sonuc = komutnesnesi.ExecuteNonQuery()
            If sonuc = 1 Then
                MsgBox("Seçmiş Olduğunuz Veri Silinmiştir.", MsgBoxStyle.Exclamation, "Kayıt Uyarı")

            End If
            listele("SELECT * FROM ekrankartı'")
            baglanti.Close()
            Temizle()
        End If

        If ComboBox1.Text = "RAM" Then
            Dim sql As New String("DELETE FROM RAM WHERE Parça_Adı='{0}' AND Parça_Fiyatı='{1}'")
            sql = String.Format(sql, TextBox1.Text, TextBox2.Text)
            Dim baglanti As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0; Data Source='VERITABANI.mdb'")
            Dim komutnesnesi As New OleDb.OleDbCommand(sql, baglanti)
            Dim sonuc As Integer
            baglanti.Open()
            sonuc = komutnesnesi.ExecuteNonQuery()
            If sonuc = 1 Then
                MsgBox("Seçmiş Olduğunuz Veri Silinmiştir.", MsgBoxStyle.Exclamation, "Kayıt Uyarı")

            End If
            listele("SELECT * FROM RAM'")
            baglanti.Close()
            Temizle()
        End If

        If ComboBox1.Text = "Kasa" Then
            Dim sql As New String("DELETE FROM Kasa WHERE Parça_Adı='{0}' AND Parça_Fiyatı='{1}'")
            sql = String.Format(sql, TextBox1.Text, TextBox2.Text)
            Dim baglanti As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0; Data Source='VERITABANI.mdb'")
            Dim komutnesnesi As New OleDb.OleDbCommand(sql, baglanti)
            Dim sonuc As Integer
            baglanti.Open()
            sonuc = komutnesnesi.ExecuteNonQuery()
            If sonuc = 1 Then
                MsgBox("Seçmiş Olduğunuz Veri Silinmiştir.", MsgBoxStyle.Exclamation, "Kayıt Uyarı")

            End If
            listele("SELECT * FROM Kasa'")
            baglanti.Close()
            Temizle()
        End If

        If ComboBox1.Text = "Güç Kaynağı" Then
            Dim sql As New String("DELETE FROM GücKaynagı WHERE Parça_Adı='{0}' AND Parça_Fiyatı='{1}'")
            sql = String.Format(sql, TextBox1.Text, TextBox2.Text)
            Dim baglanti As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0; Data Source='VERITABANI.mdb'")
            Dim komutnesnesi As New OleDb.OleDbCommand(sql, baglanti)
            Dim sonuc As Integer
            baglanti.Open()
            sonuc = komutnesnesi.ExecuteNonQuery()
            If sonuc = 1 Then
                MsgBox("Seçmiş Olduğunuz Veri Silinmiştir.", MsgBoxStyle.Exclamation, "Kayıt Uyarı")

            End If
            listele("SELECT * FROM GücKaynagı'")
            baglanti.Close()
            Temizle()
        End If

        If ComboBox1.Text = "Hard Disk" Then
            Dim sql As New String("DELETE FROM HardDisk WHERE Parça_Adı='{0}' AND Parça_Fiyatı='{1}'")
            sql = String.Format(sql, TextBox1.Text, TextBox2.Text)
            Dim baglanti As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0; Data Source='VERITABANI.mdb'")
            Dim komutnesnesi As New OleDb.OleDbCommand(sql, baglanti)
            Dim sonuc As Integer
            baglanti.Open()
            sonuc = komutnesnesi.ExecuteNonQuery()
            If sonuc = 1 Then
                MsgBox("Seçmiş Olduğunuz Veri Silinmiştir.", MsgBoxStyle.Exclamation, "Kayıt Uyarı")

            End If
            listele("SELECT * FROM HardDisk'")
            baglanti.Close()
            Temizle()
        End If

        If ComboBox1.Text = "SSD" Then
            Dim sql As New String("DELETE FROM SSD WHERE Parça_Adı='{0}' AND Parça_Fiyatı='{1}'")
            sql = String.Format(sql, TextBox1.Text, TextBox2.Text)
            Dim baglanti As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0; Data Source='VERITABANI.mdb'")
            Dim komutnesnesi As New OleDb.OleDbCommand(sql, baglanti)
            Dim sonuc As Integer
            baglanti.Open()
            sonuc = komutnesnesi.ExecuteNonQuery()
            If sonuc = 1 Then
                MsgBox("Seçmiş Olduğunuz Veri Silinmiştir.", MsgBoxStyle.Exclamation, "Kayıt Uyarı")

            End If
            listele("SELECT * FROM SSD'")
            baglanti.Close()
            Temizle()
        End If

    End Sub

    Private Sub DataGridView1_CellMouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles DataGridView1.CellMouseDoubleClick
        TextBox1.Text = DataGridView1.CurrentRow.Cells(1).Value
        TextBox2.Text = DataGridView1.CurrentRow.Cells(2).Value
        'TextBox3.Text = DataGridView1.CurrentRow.Cells(2).Value
    End Sub


    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Form1.Show()
        Me.Hide()

    End Sub

    'Private Sub Button5_Click(sender As Object, e As EventArgs)
    '    Dim durum As String
    '    durum = MsgBox("Parça Adı = " & TextBox1.Text & vbNewLine & "Parça Fiyatı = " & TextBox2.Text & vbNewLine & "Girmiş Olduğunuz Verilerin Kayıt Edilmesini Onaylıyor Musunuz? ", MsgBoxStyle.Question + MsgBoxStyle.YesNoCancel, "Kayıt Uyarı")
    '    If durum = vbYes Then
    '        Dim sql As New String("INSERT INTO anakart (Parça_Adı,Parça_Fiyatı) values ('{0}','{1}')")
    '        sql = String.Format(sql, TextBox1.Text, TextBox2.Text)
    '        Dim baglanti As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0; Data Source='VERITABANI.mdb'")
    '        Dim komutnesnesi As New OleDb.OleDbCommand(sql, baglanti)
    '        Dim sonuc As Integer
    '        baglanti.Open()
    '        sonuc = komutnesnesi.ExecuteNonQuery()
    '        If sonuc = 1 Then
    '            MsgBox("Girmiş Olduğunuz Veriler Veri Tabanına Kayıt Edilmiştir.", MsgBoxStyle.Exclamation, "Kayıt Uyarı")
    '        End If
    '        listele("SELECT * FROM anakart'")
    '        baglanti.Close()
    '        Temizle()
    '    Else

    '    End If
   'End Sub
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click

        If ComboBox1.Text = "İşlemci" Then
            listele("SELECT * FROM islemci'")

        ElseIf ComboBox1.Text = "Anakart" Then
            listele("SELECT * FROM anakart'")

        ElseIf ComboBox1.Text = "Ekran Kartı" Then
            listele("SELECT * FROM ekrankartı'")

        ElseIf ComboBox1.Text = "RAM" Then
            listele("SELECT * FROM RAM'")

        ElseIf ComboBox1.Text = "Kasa" Then
            listele("SELECT * FROM Kasa'")

        ElseIf ComboBox1.Text = "Güç Kaynağı" Then
            listele("SELECT * FROM GücKaynagı'")

        ElseIf ComboBox1.Text = "Hard Disk" Then
            listele("SELECT * FROM HardDisk'")

        ElseIf ComboBox1.Text = "SSD" Then
            listele("SELECT * FROM SSD'")
        End If

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs)

    End Sub
End Class