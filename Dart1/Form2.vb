Imports System.Data.OleDb

Public Class Form2
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = "Sepetiniz"
        'Dim ilkFiyat, taksitliFiyat As Single
        'ilkFiyat = Val(TextBox1.Text) + Val(TextBox2.Text) + Val(TextBox3.Text) + Val(TextBox4.Text) + Val(TextBox5.Text) + Val(TextBox6.Text) + Val(TextBox7.Text) + Val(TextBox8.Text)
        TextBox9.Text = Val(TextBox1.Text) + Val(TextBox2.Text) + Val(TextBox3.Text) + Val(TextBox4.Text) + Val(TextBox5.Text) + Val(TextBox6.Text) + Val(TextBox7.Text) + Val(TextBox8.Text) & " Türk Lirası"
        'TextBox9.Text = (ilkFiyat & " Türk Lirası")
        RadioButton6.Checked = True



    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form1.Show()
        Me.Hide()
    End Sub



    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim taksitliFiyat, sonuc As Decimal
        Dim s1, s2, s3, s4, s5, s6, s7, s8 As Decimal


        'ilkFiyat = Val(TextBox1.Text) + Val(TextBox2.Text) + Val(TextBox3.Text) + Val(TextBox4.Text) + Val(TextBox5.Text) + Val(TextBox6.Text) + Val(TextBox7.Text) + Val(TextBox8.Text)
        'TextBox9.Text = Val(TextBox1.Text) + Val(TextBox2.Text) + Val(TextBox3.Text) + Val(TextBox4.Text) + Val(TextBox5.Text) + Val(TextBox6.Text) + Val(TextBox7.Text) + Val(TextBox8.Text) & " Türk Lirası"
        s1 = Val(TextBox1.Text)
        s2 = Val(TextBox2.Text)
        s3 = Val(TextBox3.Text)
        s4 = Val(TextBox4.Text)
        s5 = Val(TextBox5.Text)
        s6 = Val(TextBox6.Text)
        s7 = Val(TextBox7.Text)
        s8 = Val(TextBox8.Text)
        sonuc = s1 + s2 + s3 + s4 + s5 + s6 + s7 + s8
        TextBox9.Text = sonuc
        If RadioButton1.Checked Then
            taksitliFiyat = (Val(TextBox9.Text) * (1.8 / 100)) * 2
            TextBox10.Text = Val(TextBox9.Text) + taksitliFiyat
        ElseIf RadioButton2.Checked Then
            taksitliFiyat = (Val(TextBox9.Text) * (1.8 / 100)) * 4
            TextBox10.Text = Val(TextBox9.Text) + taksitliFiyat
        ElseIf RadioButton3.Checked Then
            taksitliFiyat = (Val(TextBox9.Text) * (1.8 / 100)) * 6
            TextBox10.Text = Val(TextBox9.Text) + taksitliFiyat
        ElseIf RadioButton4.Checked Then
            taksitliFiyat = (Val(TextBox9.Text) * (1.8 / 100)) * 8
            TextBox10.Text = Val(TextBox9.Text) + taksitliFiyat
        ElseIf RadioButton5.Checked Then
            taksitliFiyat = (Val(TextBox9.Text) * (1.8 / 100)) * 12
            TextBox10.Text = Val(TextBox9.Text) + taksitliFiyat
        ElseIf RadioButton6.Checked Then
            TextBox10.Text = TextBox9.Text

        End If

        'sonuc = (ilkFiyat)
        'TextBox9.Text = sonuc
        's1 = Val(TextBox1.Text)
        's2 = Val(TextBox2.Text)
        's3 = Val(TextBox7.Text)
        'TextBox9.Text = s1 + s2 + s3
    End Sub




    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim durum As String
        durum = MsgBox("Alışverişinizi Tamamlamak İstediğinizden Emin Misiniz? ", MsgBoxStyle.Question + MsgBoxStyle.YesNoCancel, "Kayıt Uyarı")
        If durum = vbYes Then
            Dim sql As New String("INSERT INTO fatura (islemci,anakart,ekrankartı,ram,kasa,güc,hdd,ssd,tarih) values ('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}')")
            sql = String.Format(sql, TextBox1.Text, TextBox2.Text, TextBox3.Text, TextBox4.Text, TextBox5.Text, TextBox6.Text, TextBox7.Text, TextBox8.Text, DateTime.Parse(DateTimePicker1.Value))
            Dim baglanti As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0; Data Source='fatura.mdb'")
            Dim komutnesnesi As New OleDb.OleDbCommand(sql, baglanti)
            Dim sonuc As Integer
            baglanti.Open()
            sonuc = komutnesnesi.ExecuteNonQuery()
            If sonuc = 1 Then
                MsgBox("1.Parçanın Fiyatı = " & TextBox1.Text & vbNewLine & "2.Parçanın Fiyatı =  = " & TextBox2.Text & vbNewLine & "3.Parçanın Fiyatı =  = " & TextBox3.Text & vbNewLine & "4.Parçanın Fiyatı =  = " & TextBox4.Text & vbNewLine & "5.Parçanın Fiyatı =  = " & TextBox5.Text & vbNewLine & "6.Parçanın Fiyatı =  = " & TextBox6.Text & vbNewLine & "7.Parçanın Fiyatı =  = " & TextBox7.Text & vbNewLine & "8.Parçanın Fiyatı =  = " & TextBox8.Text & vbNewLine & "Toplam Tutarınız = " & TextBox10.Text & vbNewLine & "Faturanızın Oluşturulmasını Onaylıyor Musunuz? ", MsgBoxStyle.Question + MsgBoxStyle.YesNoCancel, "Kayıt Uyarı")
            End If
            baglanti.Close()
        End If


    End Sub






End Class