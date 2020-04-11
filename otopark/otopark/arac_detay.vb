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



 



      









        Dim timer As New Timer()
        timer.Interval = 1000
        AddHandler timer.Tick, AddressOf Timer1_Tick
        timer.Start()



        aracbutonu()
        Label6.Text = park_adi









        '
        '

        ' MEVCUT TARİH SAAT BİLGİLERİ

        '
        '
        Dim tarih1 As String
        Dim tarih1_array() As String
        Dim count2 As Integer
        tarih1 = Today
        tarih1_array = tarih1.Split(".")
        For count2 = 0 To 0
            mevcut_tarih1 = tarih1_array(0)
            mevcut_tarih2 = tarih1_array(1)
            mevcut_tarih3 = tarih1_array(2)
        Next

        '

        Dim saat1 As String
        Dim saat1_array() As String
        Dim count1 As Integer
        saat1 = TimeOfDay
        saat1_array = saat1.Split(":")
        For count1 = 0 To 0
            mevcut_saat1 = saat1_array(0)
            mevcut_saat2 = saat1_array(1)
            mevcut_saat3 = saat1_array(2)
        Next


        ' VERİTABANINDAKİ TARİH SAAT BİLGİLERİ

        Dim saat2 As String
        Dim saat2_array() As String
        Dim count3 As Integer
        saat2 = "14:42:33"
        saat2_array = saat2.Split(":")
        For count3 = 0 To 0
            veritabani_saat1 = saat2_array(0)
            veritabani_saat1 = saat2_array(1)
            veritabani_saat3 = saat2_array(2)
        Next

        '

        Dim tarih2 As String
        Dim tarih2_array() As String
        Dim count4 As Integer
        tarih2 = "10.4.2020"
        tarih2_array = tarih2.Split(".")
        For count4 = 0 To 0
            veritabani_tarih1 = tarih2_array(0)
            veritabani_tarih2 = tarih2_array(1)
            veritabani_tarih3 = tarih2_array(2)
        Next

        '
        '
        '




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
            label_giris_tarihi.Text = veriokuyucu("giris_tarihi")
            label_giris_saat.Text = veriokuyucu("giris_saati")
        Loop
        baglanti.Close()























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
        Me.gecen_sure.Refresh()


        gun = mevcut_tarih1.ToString - veritabani_tarih1
        ay = mevcut_tarih2.ToString - veritabani_tarih2
        yil = mevcut_tarih3.ToString - veritabani_tarih3

        saat = mevcut_saat1.ToString - veritabani_saat1
        dakika = mevcut_saat2.ToString - veritabani_saat2
        saniye = mevcut_saat3.ToString - veritabani_saat3


        gecen_tarih = gun + "." + ay + "." + yil + " LANM"
        gecen_saat = saat + ":" + dakika + ":" + saniye + "LAMN"
        gecen_sure.Text = gecen_tarih + " - " + gecen_saat
    End Sub

    Private Sub Button42_Click(sender As Object, e As EventArgs) Handles Button42.Click

        Dim fark As TimeSpan = New TimeSpan
        Dim dogum_tarihi As DateTime = New DateTime
        dogum_tarihi = TextBox1.Text
        fark = Now.Subtract(dogum_tarihi)
        Label11.Text = "yaşadığınız saat:" + fark.Hours.ToString() + Chr(13) + "Yaşadığınız dakika :" + fark.Minutes.ToString() + Chr(13) +
"Yaşadığınız Saniye :" + fark.Seconds.ToString() + Chr(13) +
"Yaşadığınız Gün :" + fark.Days.ToString() + Chr(13)




        'Dim saat As DateTime = "21:46"
        'Dim simdikisaat As DateTime = TimeOfDay
        'Dim span2 As TimeSpan = simdikisaat.Subtract(saat)

        'Dim gun As DateTime = "10.4.2020"
        'Dim simdikigun As DateTime = Today
        'Dim span As TimeSpan = simdikigun.Subtract(gun)

        'Label11.Text = span.ToString + " gün geçti, " + Chr(13) + span2.ToString + "saat geçti "


    End Sub
End Class