Imports System.Data.OleDb

Public Class Form1
    'Public Sub bayileridoldur()
    '    ComboBox2.Items.Clear()
    '    Dim cmd As New SqlCommand("select * from VERI", con)
    '    con.Open()
    '    Dim tbl As New DataTable()
    '    tbl.Load(cmd.ExecuteReader())
    '    con.Close()

    '    cmbbayiler.DataSource = tbl
    '    cmbbayiler.DisplayMember = "bayiadi"
    '    cmbbayiler.ValueMember = "bayiid"
    'End Sub
    'Public Sub islemciFiyat()
    '    If ComboBox1.Text = "İşlemci" And ComboBox2.SelectedIndex = 0 Then
    '        TextBox1.Text = "2.334,16" & " Türk Lirası"
    '    ElseIf ComboBox1.Text = "İşlemci" And ComboBox2.SelectedIndex = 1 Then
    '        TextBox1.Text = "11.156,84" & " Türk Lirası"
    '    ElseIf ComboBox1.Text = "İşlemci" And ComboBox2.SelectedIndex = 2 Then
    '        TextBox1.Text = "2.672,70" & "  Türk Lirası"
    '    ElseIf ComboBox1.Text = "İşlemci" And ComboBox2.SelectedIndex = 3 Then
    '        TextBox1.Text = "5.000,25" & "  Türk Lirası"
    '    End If
    'End Sub
    Public Sub anakartFiyat()
        If ComboBox1.Text = "Anakart" And ComboBox2.SelectedIndex = 0 Then
            TextBox1.Text = "12.102,55" & " Türk Lirası"
        ElseIf ComboBox1.Text = "Anakart" And ComboBox2.SelectedIndex = 1 Then
            TextBox1.Text = "5.677,98" & " Türk Lirası"
        ElseIf ComboBox1.Text = "Anakart" And ComboBox2.SelectedIndex = 2 Then
            TextBox1.Text = "406,04" & " Türk Lirası"
        ElseIf ComboBox1.Text = "Anakart" And ComboBox2.SelectedIndex = 3 Then
            TextBox1.Text = "938,10" & " Türk Lirası"
        End If
    End Sub
    Public Sub ekranKartıFiyat()
        If ComboBox1.Text = "Ekran Kartı" And ComboBox2.SelectedIndex = 0 Then
            TextBox1.Text = "53.100,00" & " Türk Lirası"
        ElseIf ComboBox1.Text = "Ekran Kartı" And ComboBox2.SelectedIndex = 1 Then
            TextBox1.Text = "39.690,87" & " Türk Lirası"
        ElseIf ComboBox1.Text = "Ekran Kartı" And ComboBox2.SelectedIndex = 2 Then
            TextBox1.Text = "7.150,80" & " Türk Lirası"
        ElseIf ComboBox1.Text = "Ekran Kartı" And ComboBox2.SelectedIndex = 3 Then
            TextBox1.Text = "2.035,50" & " Türk Lirası"
        End If
    End Sub
    Public Sub ramFiyat()
        If ComboBox1.Text = "RAM" And ComboBox2.SelectedIndex = 0 Then
            TextBox1.Text = "1.108,73" & " Türk Lirası"
        ElseIf ComboBox1.Text = "RAM" And ComboBox2.SelectedIndex = 1 Then
            TextBox1.Text = "1.221,30" & " Türk Lirası"
        ElseIf ComboBox1.Text = "RAM" And ComboBox2.SelectedIndex = 2 Then
            TextBox1.Text = "936,33" & " Türk Lirası"
        ElseIf ComboBox1.Text = "RAM" And ComboBox2.SelectedIndex = 3 Then
            TextBox1.Text = "548,70" & " Türk Lirası"
        End If
    End Sub


    Public Sub kasaFiyat()
        If ComboBox1.Text = "Kasa" And ComboBox2.SelectedIndex = 0 Then
            TextBox1.Text = "3.646,20" & " Türk Lirası"
        ElseIf ComboBox1.Text = "Kasa" And ComboBox2.SelectedIndex = 1 Then
            TextBox1.Text = "3.327,60 " & " Türk Lirası"
        ElseIf ComboBox1.Text = "Kasa" And ComboBox2.SelectedIndex = 2 Then
            TextBox1.Text = "1.575,30" & " Türk Lirası"
        ElseIf ComboBox1.Text = "Kasa" And ComboBox2.SelectedIndex = 3 Then
            TextBox1.Text = "1.477,95" & " Türk Lirası"
        End If
    End Sub
    Public Sub güçKaynagıFiyat()
        If ComboBox1.Text = "Güç Kaynağı" And ComboBox2.SelectedIndex = 0 Then
            TextBox1.Text = "3.115,20" & " Türk Lirası"
        ElseIf ComboBox1.Text = "Güç Kaynağı" And ComboBox2.SelectedIndex = 1 Then
            TextBox1.Text = "2.495,70" & " Türk Lirası"
        ElseIf ComboBox1.Text = "Güç Kaynağı" And ComboBox2.SelectedIndex = 2 Then
            TextBox1.Text = "583,39" & " Türk Lirası"
        ElseIf ComboBox1.Text = "Güç Kaynağı" And ComboBox2.SelectedIndex = 3 Then
            TextBox1.Text = "495,60" & " Türk Lirası"
        End If
    End Sub
    Public Sub hardDiskFiyat()
        If ComboBox1.Text = "Hard Disk" And ComboBox2.SelectedIndex = 0 Then
            TextBox1.Text = "920,40" & " Türk Lirası"
        ElseIf ComboBox1.Text = "Hard Disk" And ComboBox2.SelectedIndex = 1 Then
            TextBox1.Text = "488,52" & " Türk Lirası"
        ElseIf ComboBox1.Text = "Hard Disk" And ComboBox2.SelectedIndex = 2 Then
            TextBox1.Text = "1.194" & " Türk Lirası"
        ElseIf ComboBox1.Text = "Hard Disk" And ComboBox2.SelectedIndex = 3 Then
            TextBox1.Text = "804,03" & " Türk Lirası"
        End If
    End Sub
    Public Sub ssdFiyat()
        If ComboBox1.Text = "SSD" And ComboBox2.SelectedIndex = 0 Then
            TextBox1.Text = "504,45" & " Türk Lirası"
        ElseIf ComboBox1.Text = "SSD" And ComboBox2.SelectedIndex = 1 Then
            TextBox1.Text = "531,00" & " Türk Lirası"
        ElseIf ComboBox1.Text = "SSD" And ComboBox2.SelectedIndex = 2 Then
            TextBox1.Text = "19.642,58" & " Türk Lirası"
        ElseIf ComboBox1.Text = "SSD" And ComboBox2.SelectedIndex = 3 Then
            TextBox1.Text = "16.261,34" & " Türk Lirası"
        End If
    End Sub

    Public Sub islemciAktarma()
        If ComboBox1.Text = "İşlemci" And ComboBox2.SelectedIndex = 0 Then
            MsgBox("Ürününüz Sepete Eklendi")
            Form2.TextBox1.Text = TextBox1.Text
        ElseIf ComboBox1.Text = "İşlemci" And ComboBox2.SelectedIndex = 1 Then
            MsgBox("Ürününüz Sepete Eklendi")
            Form2.TextBox1.Text = TextBox1.Text
        ElseIf ComboBox1.Text = "İşlemci" And ComboBox2.SelectedIndex = 2 Then
            MsgBox("Ürününüz Sepete Eklendi")
            Form2.TextBox1.Text = TextBox1.Text
        ElseIf ComboBox1.Text = "İşlemci" And ComboBox2.SelectedIndex = 3 Then
            MsgBox("Ürününüz Sepete Eklendi")
            Form2.TextBox1.Text = TextBox1.Text
        End If
    End Sub
    Public Sub anakartAktarma()
        If ComboBox1.Text = "Anakart" And ComboBox2.SelectedIndex = 0 Then
            MsgBox("Ürününüz Sepete Eklendi")
            Form2.TextBox2.Text = TextBox1.Text
        ElseIf ComboBox1.Text = "Anakart" And ComboBox2.SelectedIndex = 1 Then
            MsgBox("Ürününüz Sepete Eklendi")
            Form2.TextBox2.Text = TextBox1.Text
        ElseIf ComboBox1.Text = "Anakart" And ComboBox2.SelectedIndex = 2 Then
            MsgBox("Ürününüz Sepete Eklendi")
            Form2.TextBox2.Text = TextBox1.Text
        ElseIf ComboBox1.Text = "Anakart" And ComboBox2.SelectedIndex = 3 Then
            MsgBox("Ürününüz Sepete Eklendi")
            Form2.TextBox2.Text = TextBox1.Text
        End If
    End Sub
    Public Sub ekranKartıAktarma()
        If ComboBox1.Text = "Ekran Kartı" And ComboBox2.SelectedIndex = 0 Then
            MsgBox("Ürününüz Sepete Eklendi")
            Form2.TextBox3.Text = TextBox1.Text
        ElseIf ComboBox1.Text = "Ekran Kartı" And ComboBox2.SelectedIndex = 1 Then
            MsgBox("Ürününüz Sepete Eklendi")
            Form2.TextBox3.Text = TextBox1.Text
        ElseIf ComboBox1.Text = "Ekran Kartı" And ComboBox2.SelectedIndex = 2 Then
            MsgBox("Ürününüz Sepete Eklendi")
            Form2.TextBox3.Text = TextBox1.Text
        ElseIf ComboBox1.Text = "Ekran Kartı" And ComboBox2.SelectedIndex = 3 Then
            MsgBox("Ürününüz Sepete Eklendi")
            Form2.TextBox3.Text = TextBox1.Text
        End If
    End Sub
    Public Sub ramAktarma()
        If ComboBox1.Text = "RAM" And ComboBox2.SelectedIndex = 0 Then
            MsgBox("Ürününüz Sepete Eklendi")
            Form2.TextBox4.Text = TextBox1.Text
        ElseIf ComboBox1.Text = "RAM" And ComboBox2.SelectedIndex = 1 Then
            MsgBox("Ürününüz Sepete Eklendi")
            Form2.TextBox4.Text = TextBox1.Text
        ElseIf ComboBox1.Text = "RAM" And ComboBox2.SelectedIndex = 2 Then
            MsgBox("Ürününüz Sepete Eklendi")
            Form2.TextBox4.Text = TextBox1.Text
        ElseIf ComboBox1.Text = "RAM" And ComboBox2.SelectedIndex = 3 Then
            MsgBox("Ürününüz Sepete Eklendi")
            Form2.TextBox4.Text = TextBox1.Text
        End If
    End Sub
    Public Sub kasaAktarma()
        If ComboBox1.Text = "Kasa" And ComboBox2.SelectedIndex = 0 Then
            MsgBox("Ürününüz Sepete Eklendi")
            Form2.TextBox5.Text = TextBox1.Text
        ElseIf ComboBox1.Text = "Kasa" And ComboBox2.SelectedIndex = 1 Then
            MsgBox("Ürününüz Sepete Eklendi")
            Form2.TextBox5.Text = TextBox1.Text
        ElseIf ComboBox1.Text = "Kasa" And ComboBox2.SelectedIndex = 2 Then
            MsgBox("Ürününüz Sepete Eklendi")
            Form2.TextBox5.Text = TextBox1.Text
        ElseIf ComboBox1.Text = "Kasa" And ComboBox2.SelectedIndex = 3 Then
            MsgBox("Ürününüz Sepete Eklendi")
            Form2.TextBox5.Text = TextBox1.Text
        End If
    End Sub
    Public Sub güçKaynagıAktarma()
        If ComboBox1.Text = "Güç Kaynağı" And ComboBox2.SelectedIndex = 0 Then
            MsgBox("Ürününüz Sepete Eklendi")
            Form2.TextBox6.Text = TextBox1.Text
        ElseIf ComboBox1.Text = "Güç Kaynağı" And ComboBox2.SelectedIndex = 1 Then
            MsgBox("Ürününüz Sepete Eklendi")
            Form2.TextBox6.Text = TextBox1.Text
        ElseIf ComboBox1.Text = "Güç Kaynağı" And ComboBox2.SelectedIndex = 2 Then
            MsgBox("Ürününüz Sepete Eklendi")
            Form2.TextBox6.Text = TextBox1.Text
        ElseIf ComboBox1.Text = "Güç Kaynağı" And ComboBox2.SelectedIndex = 3 Then
            MsgBox("Ürününüz Sepete Eklendi")
            Form2.TextBox6.Text = TextBox1.Text
        End If
    End Sub
    Public Sub hardDiskAktarma()
        If ComboBox1.Text = "Hard Disk" And ComboBox2.SelectedIndex = 0 Then
            MsgBox("Ürününüz Sepete Eklendi")
            Form2.TextBox7.Text = TextBox1.Text
        ElseIf ComboBox1.Text = "Hard Disk" And ComboBox2.SelectedIndex = 1 Then
            MsgBox("Ürününüz Sepete Eklendi")
            Form2.TextBox7.Text = TextBox1.Text
        ElseIf ComboBox1.Text = "Hard Disk" And ComboBox2.SelectedIndex = 2 Then
            MsgBox("Ürününüz Sepete Eklendi")
            Form2.TextBox7.Text = TextBox1.Text
        ElseIf ComboBox1.Text = "Hard Disk" And ComboBox2.SelectedIndex = 3 Then
            MsgBox("Ürününüz Sepete Eklendi")
            Form2.TextBox7.Text = TextBox1.Text
        End If
    End Sub
    Public Sub ssdAktarma()
        If ComboBox1.Text = "SSD" And ComboBox2.SelectedIndex = 0 Then
            MsgBox("Ürününüz Sepete Eklendi")
            Form2.TextBox8.Text = TextBox1.Text
        ElseIf ComboBox1.Text = "SSD" And ComboBox2.SelectedIndex = 1 Then
            MsgBox("Ürününüz Sepete Eklendi")
            Form2.TextBox8.Text = TextBox1.Text
        ElseIf ComboBox1.Text = "SSD" And ComboBox2.SelectedIndex = 2 Then
            MsgBox("Ürününüz Sepete Eklendi")
            Form2.TextBox8.Text = TextBox1.Text
        ElseIf ComboBox1.Text = "SSD" And ComboBox2.SelectedIndex = 3 Then
            MsgBox("Ürününüz Sepete Eklendi")
            Form2.TextBox8.Text = TextBox1.Text
        End If

    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = "Kendi Bilgisayarını Topla"
        ComboBox1.Items.Add("İşlemci")
        ComboBox1.Items.Add("Anakart")
        ComboBox1.Items.Add("Ekran Kartı")
        ComboBox1.Items.Add("RAM")
        ComboBox1.Items.Add("Kasa")
        ComboBox1.Items.Add("Güç Kaynağı")
        ComboBox1.Items.Add("Hard Disk")
        ComboBox1.Items.Add("SSD")
        'Dim conne As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0; Data Source='VERITABANI.mdb'")
        'Dim liste As String
        'liste = "select Parça_Fiyatı from islemciler"
        'Dim esk As New OleDb.OleDbCommand(liste, conne)
        'conne.Open()
        'Dim readerk As OleDbDataReader = esk.ExecuteReader
        'Do While readerk.Read
        '    TextBox1.Text = readerk.GetString(0)

        'Loop


        'Dim komut As String = "SELECT Parça_Fiyatı from islemci"
        'Dim baglanti As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0; Data Source='VERITABANI.mdb'")
        'Dim yeni As New OleDbCommand(komut, baglanti)
        'baglanti.Open()
        'Dim oku As OleDbDataReader

        'oku = yeni.ExecuteReader
        'Do While oku.Read
        '    TextBox1.Text = oku.GetString(0)

        'Loop
        'oku.Close()
        'baglanti.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        islemciAktarma()
        anakartAktarma()
        ekranKartıAktarma()
        ramAktarma()
        kasaAktarma()
        güçKaynagıAktarma()
        hardDiskAktarma()
        ssdAktarma()
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        'If ComboBox1.Text = "İşlemci" Then
        'Label2.Text = "İşlemci"
        'PictureBox1.SizeMode = PictureBoxSizeMode.AutoSize
        'PictureBox1.Image = Image.FromFile("C:\Users\fb_hl\Desktop\Dart1Dosyalar\İşlemciler.jpg")
        'ComboBox2.Text = ""
        'ComboBox2.Items.Clear()
        'ComboBox2.Items.Add("AMD Ryzen ™ 5 1600 AF 3.2GHz (Turbo 3.6GHz) 16MB Cache 12nm")
        'ComboBox2.Items.Add("Intel Core i9-12900K 3.20GHz (Turbo 5.10GHz) 30MB Cache LGA1700 12.Nesil")
        'ComboBox2.Items.Add("Intel Core I5 11400F 2.60GHz 12MB LGA1200 11.Nesil İşlemci")
        'ComboBox2.Items.Add("AMD Ryzen 7 5700G 3.8GHz (Turbo 4.4GHz) 8 Core 16 Threads 20MB Cache 7nm")

        'ElseIf ComboBox1.Text = "Anakart" Then
        'Label2.Text = "Anakart"
        'PictureBox1.Image = Image.FromFile("C:\Users\fb_hl\Desktop\Dart1Dosyalar\anakart1.jpg")
        'ComboBox2.Text = ""
        'ComboBox2.Items.Clear()
        'ComboBox2.Items.Add("Asus ROG Maximus Z690 Hero Intel Z690 Soket 1700 DDR5 6400(OC)MHz ATX Gaming Anakart")
        'ComboBox2.Items.Add("Gigabyte Z490 AORUS MASTER LGA1200, DDR4 5000MHz+ (OC), Ultra M.2, USB 3.2 Gen2, HDMI ATX RGB Anakart")
        'ComboBox2.Items.Add("ASRock A320M-HDVR4 Socket AM4, DDR4 3200MHz+(OC), Ultra M.2, USB 3.1 Gen1, HDMI, DVI, VGA mATX Anakart")
        'ComboBox2.Items.Add("Galax B450M Socket AM4, DDR4 3200MHz+, Ultra M.2, USB 3.1 Gen1, HDMI, DVI, VGA mATX Anakart")

        'ElseIf ComboBox1.Text = "Ekran Kartı" Then
        'Label2.Text = "Ekran Kartı"
        'PictureBox1.Image = Image.FromFile("C:\Users\fb_hl\Desktop\Dart1Dosyalar\ekrankartı1.jpg")
        'ComboBox2.Text = ""
        'ComboBox2.Items.Clear()
        'ComboBox2.Items.Add("GIGABYTE GeForce RTX 3090 GAMING OC 24GB GDDR6X 384 Bit Ekran Kartı")
        'ComboBox2.Items.Add("Asus ROG STRIX GeForce RTX 3080TI 12GB GDDR6X 384BIT NVIDIA Ekran Kartı")
        'ComboBox2.Items.Add("Sapphire PULSE Radeon RX6600 8GB 128Bit GDDR6 Ekran Kartı")
        'ComboBox2.Items.Add("MSI GeForce GT1030 2GB GDDR5 DP HDMI Ekran Kartı")

        'ElseIf ComboBox1.Text = "RAM" Then
        'Label2.Text = "RAM"
        'PictureBox1.Image = Image.FromFile("C:\Users\fb_hl\Desktop\Dart1Dosyalar\Ram1.jpg")
        'ComboBox2.Text = ""
        'ComboBox2.Items.Clear()
        'ComboBox2.Items.Add("Corsair DDR4 8GB Vengeance 3200MHz Ram Bellek")
        'ComboBox2.Items.Add("Adata DDR4 8GB 3600MHz D41 SPECTRIX RGB LED Kırmızı Ram")
        'ComboBox2.Items.Add("Kingston DDR4 8GB (1x8GB) 3200 MHz Fury Renegade Bellek Ram")
        'ComboBox2.Items.Add("Neo Forza 8GB 3600MHz Black Faye DDR4 PC Ram")

        'ElseIf ComboBox1.Text = "Kasa" Then
        'Label2.Text = "Kasa"
        'PictureBox1.Image = Image.FromFile("C:\Users\fb_hl\Desktop\Dart1Dosyalar\kasa2.jpg")
        'ComboBox2.Text = ""
        'ComboBox2.Items.Clear()
        'ComboBox2.Items.Add("Aerocool Tor Pro 750W 80+ GOLD 4 x Adreslenebilir RGB Fanlı Güçlendirilmiş Camlı USB 3.0 Full Tower Siyah Oyuncu Kasası")
        'ComboBox2.Items.Add("Dark Guardian PRO 650W 80+ GOLD 4x12cm Adreslenebilir RGB LED Fanlı, Full Cam Yan ve Mesh Ön Panel, USB 3.0 Bilgisayar Kasası")
        'ComboBox2.Items.Add("Aerocool Ore Saturn 4x12cm Fixed RGB Fanlı, Pencereli, Kart Okuyuculu USB 3.0 Siyah ATX Oyuncu Kasası")
        'ComboBox2.Items.Add("Dark Diamond PRO Mesh 4x12cm FRGB Fan, Full Akrilik Yan Panel, USB 3.0 Bilgisayar Kasası")

        'ElseIf ComboBox1.Text = "Güç Kaynağı" Then
        'Label2.Text = "Güç Kaynağı"
        'PictureBox1.Image = Image.FromFile("C:\Users\fb_hl\Desktop\Dart1Dosyalar\güçkaynağı.jpg")
        'ComboBox2.Text = ""
        'ComboBox2.Items.Clear()
        'ComboBox2.Items.Add("High Power Super GD+ Series 1050W 80+ GOLD Smart Fan, Full Moduler Güç Kaynağı")
        'ComboBox2.Items.Add("Seasonic FOCUS PLUS 850W 80+ GOLD Tam Modüler Güç Kaynağı")
        'ComboBox2.Items.Add("SilverStone Strider Essential 500W 80+ Aktif PFC Sessiz Güç Kaynağı")
        'ComboBox2.Items.Add("Aerocool 500W VX PLUS Serisi Aktif PFC Güç Kaynağı")

        'ElseIf ComboBox1.Text = "Hard Disk" Then
        'Label2.Text = "Hard Disk"
        'PictureBox1.Image = Image.FromFile("C:\Users\fb_hl\Desktop\Dart1Dosyalar\hdd2.jpg")
        'ComboBox2.Text = ""
        'ComboBox2.Items.Clear()
        'ComboBox2.Items.Add("Seagate Barracuda 2TB 3.5 7200RPM 256MB Cache Sata 3 Sabit Disk")
        'ComboBox2.Items.Add("WD 1TB Blue 3,5 SATA III 6Gbit/s 7200 RPM 64MB Cache")
        'ComboBox2.Items.Add("Seagate IronWolf NAS HDD 1TB 3.5 5900RPM 64MB Cache Sata 3 Sabit Disk")
        'ComboBox2.Items.Add("WD 1TB 3,5 PURPLE 64MB 5400RPM SATA III 7/24 Disk")

        'ElseIf ComboBox1.Text = "SSD" Then
        'Label2.Text = "SSD"
        'PictureBox1.Image = Image.FromFile("C:\Users\fb_hl\Desktop\Dart1Dosyalar\ssd1.jpg")
        'ComboBox2.Items.Clear()
        'ComboBox2.Items.Add("Adata SU630 240GB 520-450MB/s SSD")
        'ComboBox2.Items.Add("Sandisk SSD Plus 240GB 530-440MB/s SSD")
        'ComboBox2.Items.Add("Kingston FURY Renegade 4TB 7300-7000MB/s NVMe PCIe 4.0 m.2 Gen4 SSD")
        'ComboBox2.Items.Add("Samsung 870 QVO 8TB 560-530MB/s 2.5 SSD")
        'End If


        'If ComboBox1.SelectedItem = "İşlemci" Then
        '    Dim cn As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0; Data Source='VERITABANI.mdb")
        '    Dim da As New OleDbDataAdapter()
        '    Dim dt As New DataTable()
        '    cn.Open()
        '    da.SelectCommand = New OleDbCommand("select * from islemci", cn)
        '    da.Fill(dt)

        '    ComboBox3.DataSource = dt
        '    ComboBox3.DisplayMember = "Parça_Fiyatı"
        '    ComboBox3.ValueMember = "Parça_Fiyatı"
        '    cn.Close()
        'End If

        '    Dim komut As String = "SELECT Parça_Fiyatı from islemci"
        '    Dim baglanti As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0; Data Source='VERITABANI.mdb'")
        '    Dim yeni As New OleDbCommand(komut, baglanti)
        '    baglanti.Open()
        '    Dim oku As OleDbDataReader

        '    oku = yeni.ExecuteReader
        '    Do While oku.Read
        '        TextBox1.Text = oku.GetString(oku.GetOrdinal("Parça_Fiyatı"))
        '        TextBox1.Text = oku.GetString(oku.GetOrdinal("Parça_Fiyatı"))
        '    Loop
        '    oku.Close()
        '    baglanti.Close()

        'If ComboBox1.Text = "İşlemci" Then
        '    Dim connectionString As String = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source='VERITABANI.mdb';User Id=admin;Password="
        '    Dim query As String = "select Parça_Fiyatı from [islemciler] where [Parça_Fiyatı] = @Parça_Fiyatı"

        '    Using conn As New OleDbConnection(connectionString)
        '        Using command As New OleDbCommand(query)
        '            command.Parameters.Add("@Parça_Fiyatı", OleDbType.VarChar, 50).Value = ComboBox1.Text

        '            conn.Open()
        '            Using reader As OleDbDataReader = command.ExecuteReader
        '                If reader.Read Then
        '                    TextBox1.Text = reader.GetString(reader.GetOrdinal("Parça_Fiyatı"))
        '                End If
        '            End Using
        '        End Using
        '    End Using

        'End If






        If ComboBox1.Text = "İşlemci" Then
            Label2.Text = "İşlemci"
            PictureBox1.SizeMode = PictureBoxSizeMode.AutoSize
            PictureBox1.Image = Image.FromFile("C:\Users\fb_hl\Desktop\Dart1Dosyalar\İşlemciler.jpg")
            ComboBox2.Items.Clear()
            Dim connk As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0; Data Source='VERITABANI.mdb'")
            Dim listek As String
            listek = "select Parça_Adı, Parça_Fiyatı from islemci"
            Dim esk As New OleDb.OleDbCommand(listek, connk)
            connk.Open()
            Dim readerk As OleDbDataReader = esk.ExecuteReader

            Do While readerk.Read
                ComboBox2.Items.Add(readerk("Parça_Adı"))
                'TextBox1.Text = readerk("Parça_Fiyatı")
            Loop

            'readerk.Read()
            'TextBox1.Text = readerk("Parça_Fiyatı")

        End If

        If ComboBox1.Text = "Anakart" Then
            Label2.Text = "Anakart"
            PictureBox1.SizeMode = PictureBoxSizeMode.AutoSize
            PictureBox1.Image = Image.FromFile("C:\Users\fb_hl\Desktop\Dart1Dosyalar\anakart1.jpg")
            ComboBox2.Items.Clear()
            Dim connk As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0; Data Source='VERITABANI.mdb'")
            Dim listek As String
            listek = "select Parça_Adı from anakart"
            Dim esk As New OleDb.OleDbCommand(listek, connk)
            connk.Open()
            Dim readerk As OleDbDataReader = esk.ExecuteReader
            Do While readerk.Read
                ComboBox2.Items.Add(readerk("Parça_Adı"))
            Loop
        End If

        If ComboBox1.Text = "Ekran Kartı" Then
            Label2.Text = "Ekran Kartı"
            PictureBox1.SizeMode = PictureBoxSizeMode.AutoSize
            PictureBox1.Image = Image.FromFile("C:\Users\fb_hl\Desktop\Dart1Dosyalar\ekrankartı1.jpg")
            ComboBox2.Items.Clear()
            Dim connk As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0; Data Source='VERITABANI.mdb'")
            Dim listek As String
            listek = "select Parça_Adı from ekrankartı"
            Dim esk As New OleDb.OleDbCommand(listek, connk)
            connk.Open()
            Dim readerk As OleDbDataReader = esk.ExecuteReader
            Do While readerk.Read
                ComboBox2.Items.Add(readerk("Parça_Adı"))
            Loop
        End If

        If ComboBox1.Text = "RAM" Then
            Label2.Text = "RAM"
            PictureBox1.SizeMode = PictureBoxSizeMode.AutoSize
            PictureBox1.Image = Image.FromFile("C:\Users\fb_hl\Desktop\Dart1Dosyalar\Ram1.jpg")
            ComboBox2.Items.Clear()
            Dim connk As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0; Data Source='VERITABANI.mdb'")
            Dim listek As String
            listek = "select Parça_Adı from RAM"
            Dim esk As New OleDb.OleDbCommand(listek, connk)
            connk.Open()
            Dim readerk As OleDbDataReader = esk.ExecuteReader
            Do While readerk.Read
                ComboBox2.Items.Add(readerk("Parça_Adı"))
            Loop
        End If

        If ComboBox1.Text = "Kasa" Then
            Label2.Text = "Kasa"
            PictureBox1.SizeMode = PictureBoxSizeMode.AutoSize
            PictureBox1.Image = Image.FromFile("C:\Users\fb_hl\Desktop\Dart1Dosyalar\kasa2.jpg")
            ComboBox2.Items.Clear()
            Dim connk As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0; Data Source='VERITABANI.mdb'")
            Dim listek As String
            listek = "select Parça_Adı from Kasa"
            Dim esk As New OleDb.OleDbCommand(listek, connk)
            connk.Open()
            Dim readerk As OleDbDataReader = esk.ExecuteReader
            Do While readerk.Read
                ComboBox2.Items.Add(readerk("Parça_Adı"))
            Loop
        End If

        If ComboBox1.Text = "Güç Kaynağı" Then
            Label2.Text = "Güç Kaynağı"
            PictureBox1.SizeMode = PictureBoxSizeMode.AutoSize
            PictureBox1.Image = Image.FromFile("C:\Users\fb_hl\Desktop\Dart1Dosyalar\güçkaynağı.jpg")
            ComboBox2.Items.Clear()
            Dim connk As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0; Data Source='VERITABANI.mdb'")
            Dim listek As String
            listek = "select Parça_Adı from GücKaynagı"
            Dim esk As New OleDb.OleDbCommand(listek, connk)
            connk.Open()
            Dim readerk As OleDbDataReader = esk.ExecuteReader
            Do While readerk.Read
                ComboBox2.Items.Add(readerk("Parça_Adı"))
            Loop
        End If

        If ComboBox1.Text = "Hard Disk" Then
            Label2.Text = "Hard Disk"
            PictureBox1.SizeMode = PictureBoxSizeMode.AutoSize
            PictureBox1.Image = Image.FromFile("C:\Users\fb_hl\Desktop\Dart1Dosyalar\hdd2.jpg")
            ComboBox2.Items.Clear()
            Dim connk As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0; Data Source='VERITABANI.mdb'")
            Dim listek As String
            listek = "select Parça_Adı from HardDisk"
            Dim esk As New OleDb.OleDbCommand(listek, connk)
            connk.Open()
            Dim readerk As OleDbDataReader = esk.ExecuteReader
            Do While readerk.Read
                ComboBox2.Items.Add(readerk("Parça_Adı"))
            Loop
        End If

        If ComboBox1.Text = "SSD" Then
            Label2.Text = "SSD"
            PictureBox1.SizeMode = PictureBoxSizeMode.AutoSize
            PictureBox1.Image = Image.FromFile("C:\Users\fb_hl\Desktop\Dart1Dosyalar\ssd1.jpg")
            ComboBox2.Items.Clear()
            Dim connk As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0; Data Source='VERITABANI.mdb'")
            Dim listek As String
            listek = "select Parça_Adı from SSD"
            Dim esk As New OleDb.OleDbCommand(listek, connk)
            connk.Open()
            Dim readerk As OleDbDataReader = esk.ExecuteReader
            Do While readerk.Read
                ComboBox2.Items.Add(readerk("Parça_Adı"))
            Loop
        End If

    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox2.SelectedIndexChanged

        Dim connect As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0; Data Source='VERITABANI.mdb'")
        Dim list As String
        list = "select Parça_Fiyatı from islemci"
        Dim esk As New OleDb.OleDbCommand(list, connect)
        connect.Open()
        Dim readerk As OleDbDataReader = esk.ExecuteReader
        Do While readerk.Read

            TextBox1.Text = readerk("Parça_Fiyatı")
        Loop
        'islemciFiyat()
        anakartFiyat()
        ekranKartıFiyat()
        ramFiyat()
        kasaFiyat()
        güçKaynagıFiyat()
        hardDiskFiyat()
        ssdFiyat()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form2.Show()
        Me.Hide()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Form4.Show()
        Me.Hide()
    End Sub


    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Form3.Show()
        Me.Hide()

    End Sub
End Class
