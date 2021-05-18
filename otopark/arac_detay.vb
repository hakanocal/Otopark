Imports System.Data.OleDb
Imports System.Data

Public Class arac_detay
    Dim src = anasayfa.src
    Dim baglanti As New OleDbConnection("Provider=sqloledb;Data Source=" & src & ";Initial Catalog=otopark;Integrated Security=SSPI;")
    Dim park_adi As String = anasayfa.park_adi
    Dim park_yeri_plaka As String = anasayfa.park_yeri_plaka
    Dim park_adi_without_plaka As String
    Dim tarih As String
    Dim gecen_tarih, gecen_saat As String
    Dim giris_tarihi, giris_saati As String
    Dim veritabani_saat1, veritabani_saat2, veritabani_saat3 As String
    Dim veritabani_tarih1, veritabani_tarih2, veritabani_tarih3 As String
    Dim mevcut_saat1, mevcut_saat2, mevcut_saat3 As String
    Dim mevcut_tarih1, mevcut_tarih2, mevcut_tarih3 As String
    Dim gun, ay, yil As String
    Dim saat, dakika, saniye As String
    Public toplam_tutar As Integer
    Dim toplam_tutar_saat As String

    Dim otomobil_pikap_minubus_ucret As Integer = anasayfa.otomobil_pikap_minubus_ucret
    Dim midibus_otobus_kamyon_ucret As Integer = anasayfa.midibus_otobus_kamyon_ucret
    Dim motosiklet_ucret As Integer = anasayfa.motosiklet_ucret
    Dim diger_ucret As Integer = anasayfa.diger_ucret
    Dim arac_turune_gore_hesaplanan_ucret As Integer = 0

    Dim dr_arac_turu As String

    Dim label_tutar_without_tl As Integer

    Dim dr_ad, dr_soyad, dr_mail As String
    Dim dr_tc, dr_telefon As String


   


    Private Sub arac_detay_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
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
                Else
                    dr_tc = veriokuyucu("tc")
                End If
                ad.Text = veriokuyucu("ad")
                If ad.Text = " " Or ad.Text = "" Then
                    ad.Text = "BU BİLGİ GİRİLMEDİ"
                Else
                    dr_ad = veriokuyucu("ad")
                End If
                soyad.Text = veriokuyucu("soyad")
                If soyad.Text = " " Or soyad.Text = "" Then
                    soyad.Text = "BU BİLGİ GİRİLMEDİ"
                Else
                    dr_soyad = veriokuyucu("soyad")
                End If
                telefon.Text = veriokuyucu("telefon")
                If telefon.Text = " " Or telefon.Text = "" Then
                    telefon.Text = "BU BİLGİ GİRİLMEDİ"
                Else
                    dr_telefon = veriokuyucu("telefon")
                End If
                email.Text = veriokuyucu("email")
                If email.Text = " " Or email.Text = "" Then
                    email.Text = "BU BİLGİ GİRİLMEDİ"
                Else
                    dr_mail = veriokuyucu("email")
                End If
                plaka.Text = veriokuyucu("plaka")
                marka.Text = veriokuyucu("marka")
                model.Text = veriokuyucu("model")
                renk.Text = veriokuyucu("renk")
                giris_tarihi = veriokuyucu("giris_tarihi")
                giris_saati = veriokuyucu("giris_saati")
                arac_turu.Text = veriokuyucu("arac_turu")
                dr_arac_turu = veriokuyucu("arac_turu")
            Loop
            baglanti.Close()

            '
            '

            'ARAÇ TÜRÜNE GÖRE ÜCRET BİLGİSİ ÇEKME
            If dr_arac_turu = "Otomobil, Pikap, Minibüs" Then
                arac_turune_gore_hesaplanan_ucret = otomobil_pikap_minubus_ucret
            ElseIf dr_arac_turu = "Midibüs, Otobüs, Kamyon" Then
                arac_turune_gore_hesaplanan_ucret = midibus_otobus_kamyon_ucret
            ElseIf dr_arac_turu = "Motosiklet" Then
                arac_turune_gore_hesaplanan_ucret = motosiklet_ucret
            ElseIf dr_arac_turu = "Diğer" Then
                arac_turune_gore_hesaplanan_ucret = diger_ucret
            End If
            '
            '
            '
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
        Catch ex As Exception
            anasayfa.catch_msg()

        End Try
        

    End Sub


    Private Sub aracbutonu()
        Try
            Dim metin As String
            Dim park_adi_array() As String
            Dim count As Integer
            metin = park_adi
            park_adi_array = metin.Split(Chr(13))
            For count = 1 To park_adi_array.Length - 1
                plaka.Text = park_adi_array(count)
            Next
            For count = 1 To park_adi_array.Length - 1
                park_adi_without_plaka = park_adi_array(0)
            Next
        Catch ex As Exception
            anasayfa.catch_msg()

        End Try
        
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Try
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
        Catch ex As Exception
            anasayfa.catch_msg()

        End Try
        
    End Sub

    Private Sub gecensure()
        Try
            Dim fark As TimeSpan = New TimeSpan
            Dim giris_tarihi2 As DateTime = New DateTime
            giris_tarihi2 = giris_tarihi.ToString + " " + giris_saati.ToString
            fark = Now.Subtract(giris_tarihi2)
            gecen_sure.Text = fark.Days.ToString() + " Gün, " +
            fark.Hours.ToString() + " Saat, " + fark.Minutes.ToString() + " Dakika"
            Me.gecen_sure.Refresh()
            '
            '
            'SAATE GÖRE TOPLAM ÜCRETİN HESAPLANMASI
            Dim Kelimeler As String = fark.TotalHours.ToString()
            Dim Dizi() As String
            Dizi = Kelimeler.Split(",")
            If Dizi(0) = 0 Then
                Dizi(0) = arac_turune_gore_hesaplanan_ucret
                label_tutar.Text = Dizi(0) + " TL"
                label_tutar_without_tl = Dizi(0)
            Else
                label_tutar.Text = Convert.ToInt32((Dizi(0) * arac_turune_gore_hesaplanan_ucret) + arac_turune_gore_hesaplanan_ucret) & (" TL")
                label_tutar_without_tl = Convert.ToInt32((Dizi(0) * arac_turune_gore_hesaplanan_ucret) + arac_turune_gore_hesaplanan_ucret)
            End If
            '
            '
        Catch ex As Exception
            anasayfa.catch_msg()

        End Try
        
       
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub






    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            ' Araç çıkışı yapıldığında, araç, "araclar" tablosundan silinip "gecmis" tablosuna ekleniyor
            Dim gecmis As New OleDbCommand("insert into gecmis(plaka, marka, model, renk, arac_turu, tc, ad, soyad, telefon, email, park_yeri, giris_tarihi, giris_saati, cikis_tarihi, cikis_saati, sure, ucret) values('" & plaka.Text & "', '" & marka.Text & "', '" & model.Text & "', '" & renk.Text & "', '" & arac_turu.Text & "','" & dr_tc & "', '" & dr_ad & "', '" & dr_soyad & "', '" & dr_telefon & "', '" & dr_mail & "', '" & park_adi_without_plaka & "', '" & label_giris_tarihi.Text & "' , '" & label_giris_saat.Text & "' , '" & Today & "', '" & TimeOfDay & "', '" & gecen_sure.Text & "', '" & label_tutar_without_tl & "')", baglanti)
            Dim komut2 As New OleDbCommand("update araclar set cikis_tarihi = '" & Today & "', cikis_saati = '" & TimeOfDay & "', sure='" & gecen_sure.Text & "', ucret='" & label_tutar_without_tl & "' where plaka ='" & plaka.Text & "' ", baglanti)
            Dim arac_sil As New OleDbCommand("delete from araclar where plaka='" & plaka.Text & "'", baglanti)

            baglanti.Open()
            komut2.ExecuteNonQuery()
            gecmis.ExecuteNonQuery()
            arac_sil.ExecuteNonQuery()
            baglanti.Close()
            anasayfa.parkkontrol()
            MsgBox(plaka.Text + "  PLAKALI ARACIN ÇIKIŞI BAŞARILI" + Chr(13) + "ÜCRET: " + label_tutar.Text, MsgBoxStyle.Information, "BAŞARILI")
            Me.Close()
            Application.Restart()
        Catch ex As Exception
            anasayfa.catch_msg()

        End Try
        
    End Sub
End Class