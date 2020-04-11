Imports System.Data.OleDb
Imports System.Data

Public Class arac_detay
    Dim src = anasayfa.src
    Dim baglanti As New OleDbConnection("Provider=sqloledb;Data Source=" & src & ";Initial Catalog=otopark;Integrated Security=SSPI;")
    Dim park_adi As String = anasayfa.park_adi
    Dim tarih As String
    Dim gecen_tarih, gecen_saat As String
    Dim giris_tarihi, giris_saati As String
    Dim veritabani_saat1, veritabani_saat2, veritabani_saat3 As String
    Dim veritabani_tarih1, veritabani_tarih2, veritabani_tarih3 As String
    Dim mevcut_saat1, mevcut_saat2, mevcut_saat3 As String
    Dim mevcut_tarih1, mevcut_tarih2, mevcut_tarih3 As String
    Dim gun, ay, yil As String
    Dim saat, dakika, saniye As String



    Private Sub arac_detay_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        tarihh.Text = Today
        saatt.Text = TimeOfDay

        Dim timer As New Timer()
        timer.Interval = 1000
        AddHandler timer.Tick, AddressOf Timer1_Tick
        timer.Start()








        aracbutonu()




        Dim komut As New OleDbCommand("select * from araclar where plaka='" & plaka.Text & "'", baglanti)
        Dim veriokuyucu As OleDbDataReader
        baglanti.Open()
        veriokuyucu = komut.ExecuteReader
        Do While veriokuyucu.Read
            tc.Text = veriokuyucu("tc")
            If tc.Text = " " Or tc.Text = "" Then
                tc.Text = "BU BİLGİ GİRİLMEDİ"
            End If
            ad.Text = veriokuyucu("ad")
            If ad.Text = " " Or ad.Text = "" Then
                ad.Text = "BU BİLGİ GİRİLMEDİ"
            End If
            soyad.Text = veriokuyucu("soyad")
            If soyad.Text = " " Or soyad.Text = "" Then
                soyad.Text = "BU BİLGİ GİRİLMEDİ"
            End If
            telefon.Text = veriokuyucu("telefon")
            If telefon.Text = " " Or telefon.Text = "" Then
                telefon.Text = "BU BİLGİ GİRİLMEDİ"
            End If
            email.Text = veriokuyucu("email")
            If email.Text = " " Or email.Text = "" Then
                email.Text = "BU BİLGİ GİRİLMEDİ"
            End If
            plaka.Text = veriokuyucu("plaka")
            marka.Text = veriokuyucu("marka")
            model.Text = veriokuyucu("model")
            renk.Text = veriokuyucu("renk")
            giris_tarihi = veriokuyucu("giris_tarihi")
            giris_saati = veriokuyucu("giris_saati")
        Loop
        baglanti.Close()


        label_giris_tarihi.Text = giris_tarihi
        label_giris_saat.Text = giris_saati

        '
        '
        '
        gecensure()

        '
        '
        '
        Label6.Text = park_adi
    End Sub


    Private Sub aracbutonu()
        Dim metin As String
        Dim metin_array() As String
        Dim count As Integer
        metin = anasayfa.Button1.Text
        metin_array = metin.Split(Chr(13))
        For count = 1 To metin_array.Length - 1
            plaka.Text = metin_array(count)
        Next
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Me.tarihh.Refresh()
        Me.saatt.Refresh()
        tarihh.Text = Today
        saatt.Text = TimeOfDay
        '
        '
        '
        gecensure()

        '
        '
        '
    End Sub

    Private Sub gecensure()
        Dim fark As TimeSpan = New TimeSpan
        Dim giris_tarihi2 As DateTime = New DateTime
        giris_tarihi2 = giris_tarihi.ToString + " " + giris_saati.ToString
        fark = Now.Subtract(giris_tarihi2)
        gecen_sure.Text = fark.Days.ToString() + " Gün " +
        fark.Hours.ToString() + " saat, " + fark.Minutes.ToString() + " dakika"
        Me.gecen_sure.Refresh()
    End Sub

End Class