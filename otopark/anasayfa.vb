Imports System.Data.OleDb
Imports System.Data

Public Class anasayfa
    Public src As String = "CASPER\SQLEXPRESS"
    Public park_adi, park_yeri_plaka As String
    Dim baglanti As New OleDbConnection("Provider=sqloledb;Data Source=" & src & ";Initial Catalog=otopark;Integrated Security=SSPI;")

    Public otomobil_pikap_minubus_ucret As Integer
    Public midibus_otobus_kamyon_ucret As Integer
    Public motosiklet_ucret As Integer
    Public diger_ucret As Integer

    Dim park_yeri As String = " ARAÇ EKLE"

    Public Sub catch_msg()
        MsgBox("BİR HATAYLA KARŞILAŞILDI. LÜTFEN SON İŞLEMLERİNİZİ KONTROL EDİNİZ", MsgBoxStyle.Critical, "HATA")
    End Sub


    Public Sub parkkontrol()
        Try
            Dim park_yeri_arti(20) As Button
            park_yeri_arti(1) = p1
            park_yeri_arti(2) = p2
            park_yeri_arti(3) = p3
            park_yeri_arti(4) = p4
            park_yeri_arti(5) = p5
            park_yeri_arti(6) = p6
            park_yeri_arti(7) = p7
            park_yeri_arti(8) = p8
            park_yeri_arti(9) = p9
            park_yeri_arti(10) = p10
            park_yeri_arti(11) = p11
            park_yeri_arti(12) = p12
            park_yeri_arti(13) = p13
            park_yeri_arti(14) = p14
            park_yeri_arti(15) = p15
            park_yeri_arti(16) = p16
            park_yeri_arti(17) = p17
            park_yeri_arti(18) = p18
            park_yeri_arti(19) = p19
            park_yeri_arti(20) = p20



            Dim park_yeri(20) As Button
            park_yeri(1) = Button1
            park_yeri(2) = Button2
            park_yeri(3) = Button3
            park_yeri(4) = Button4
            park_yeri(5) = Button5
            park_yeri(6) = Button6
            park_yeri(7) = Button7
            park_yeri(8) = Button8
            park_yeri(9) = Button9
            park_yeri(10) = Button10
            park_yeri(11) = Button11
            park_yeri(12) = Button12
            park_yeri(13) = Button13
            park_yeri(14) = Button14
            park_yeri(15) = Button15
            park_yeri(16) = Button16
            park_yeri(17) = Button17
            park_yeri(18) = Button18
            park_yeri(19) = Button19
            park_yeri(20) = Button20

            Dim komut As New OleDbCommand("select * from araclar", baglanti)
            Dim veriokuyucu As OleDbDataReader
            baglanti.Open()
            veriokuyucu = komut.ExecuteReader
            Do While veriokuyucu.Read
                For i = 1 To 20
                    If veriokuyucu("park_yeri") = park_yeri(i).Text Then
                        park_yeri(i).Enabled = True
                        park_yeri(i).BackColor = Color.Red
                        park_yeri_arti(i).Visible = False
                        park_yeri(i).Text = park_yeri(i).Text + Chr(13) + veriokuyucu("plaka")
                    Else
                        'park_yeri(i).Enabled = False
                        'park_yeri(i).BackColor = Color.Green
                        'park_yeri_arti(i).Visible = True
                        'park_yeri(i).Text = park_yeri(i).Text
                    End If
                Next
            Loop
            baglanti.Close()
        Catch ex As Exception
            catch_msg()
        End Try
        

    End Sub


    Public Sub saatlik_ucret_hesapla()
        Try
            Dim komut As New OleDbCommand("select * from ucretlendirme", baglanti)
            Dim veriokuyucu As OleDbDataReader
            baglanti.Open()
            veriokuyucu = komut.ExecuteReader
            If veriokuyucu.Read Then
                otomobil_pikap_minubus_ucret = veriokuyucu("otomobil_pikap_minubus")
                midibus_otobus_kamyon_ucret = veriokuyucu("midibus_otobus_kamyon")
                motosiklet_ucret = veriokuyucu("motosiklet")
                diger_ucret = veriokuyucu("diger")
            End If
            baglanti.Close()
        Catch ex As Exception
            catch_msg()

        End Try
        
    End Sub


    Public Sub anasayfa_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            '
            ' EĞER PROGRAM İLK AÇILDIĞINDA SAATLİK ÜCRETLER TANIMLI DEĞİLSE ARAÇ TİPİNE GÖRE SAATLİK ÜCRETLERİ AYARLA:
            ' Bu İşlem sadece program ilk çalıştırıldığında gerçekleştirilir. Değerler varsayılan olarak atanır. Bu değerler daha sonra program içerisinden değiştirilebilir.
            ' Değerler:
            ' otomobil_pikap_minubus = 4
            ' midibus_otobus_kamyon = 5
            ' motosiklet = 3
            ' diger = 5
            Dim ucret_komut As New OleDbCommand("select * from ucretlendirme", baglanti)
            Dim veriokuyucu3 As OleDbDataReader
            baglanti.Open()
            veriokuyucu3 = ucret_komut.ExecuteReader
            If veriokuyucu3.HasRows Then
                baglanti.Close()
            Else
                baglanti.Close()
                Dim ucret_kayit_komut As New OleDbCommand("insert into ucretlendirme(otomobil_pikap_minubus, midibus_otobus_kamyon, motosiklet, diger) values('4', '5', '3', '5')", baglanti)
                baglanti.Open()
                ucret_kayit_komut.ExecuteNonQuery()
                baglanti.Close()
            End If


            '
            '
            '

            saatlik_ucret_hesapla()



            tarih.Text = Today
            saat.Text = TimeOfDay

            Dim timer As New Timer()
            timer.Interval = 1000
            AddHandler timer.Tick, AddressOf Timer1_Tick
            timer.Start()



            parkkontrol()
        Catch ex As Exception
            catch_msg()

        End Try
        
    End Sub


    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Try
            Me.tarih.Refresh()
            Me.saat.Refresh()
            tarih.Text = Today
            saat.Text = TimeOfDay
        Catch ex As Exception
            catch_msg()

        End Try
        
    End Sub

    Private Sub Button21_Click(sender As Object, e As EventArgs) Handles Button21.Click
        gecmis.Show()
    End Sub




    Private Sub p1_Click_1(sender As Object, e As EventArgs) Handles p1.Click
        park_adi = Button1.Text
        arac_ekle.Show()
    End Sub

    Private Sub p2_Click_1(sender As Object, e As EventArgs) Handles p2.Click
        park_adi = Button2.Text
        arac_ekle.Show()
    End Sub

    Private Sub p3_Click_1(sender As Object, e As EventArgs) Handles p3.Click
        park_adi = Button3.Text
        arac_ekle.Show()
    End Sub

    Private Sub p4_Click_1(sender As Object, e As EventArgs) Handles p4.Click
        park_adi = Button4.Text
        arac_ekle.Show()
    End Sub

    Private Sub p5_Click_1(sender As Object, e As EventArgs) Handles p5.Click
        park_adi = Button5.Text
        arac_ekle.Show()
    End Sub

    Private Sub p6_Click_1(sender As Object, e As EventArgs) Handles p6.Click
        park_adi = Button6.Text
        arac_ekle.Show()
    End Sub

    Private Sub p7_Click_1(sender As Object, e As EventArgs) Handles p7.Click
        park_adi = Button7.Text
        arac_ekle.Show()
    End Sub

    Private Sub p8_Click_1(sender As Object, e As EventArgs) Handles p8.Click
        park_adi = Button8.Text
        arac_ekle.Show()
    End Sub

    Private Sub p9_Click_1(sender As Object, e As EventArgs) Handles p9.Click
        park_adi = Button9.Text
        arac_ekle.Show()
    End Sub

    Private Sub p10_Click_1(sender As Object, e As EventArgs) Handles p10.Click
        park_adi = Button10.Text
        arac_ekle.Show()
    End Sub

    Private Sub p11_Click_1(sender As Object, e As EventArgs) Handles p11.Click
        park_adi = Button11.Text
        arac_ekle.Show()
    End Sub

    Private Sub p12_Click_1(sender As Object, e As EventArgs) Handles p12.Click
        park_adi = Button12.Text
        arac_ekle.Show()
    End Sub

    Private Sub p13_Click_1(sender As Object, e As EventArgs) Handles p13.Click
        park_adi = Button13.Text
        arac_ekle.Show()
    End Sub

    Private Sub p14_Click_1(sender As Object, e As EventArgs) Handles p14.Click
        park_adi = Button14.Text
        arac_ekle.Show()
    End Sub

    Private Sub p15_Click_1(sender As Object, e As EventArgs) Handles p15.Click
        park_adi = Button15.Text
        arac_ekle.Show()
    End Sub

    Private Sub p16_Click_1(sender As Object, e As EventArgs) Handles p16.Click
        park_adi = Button16.Text
        arac_ekle.Show()
    End Sub

    Private Sub p17_Click_1(sender As Object, e As EventArgs) Handles p17.Click
        park_adi = Button17.Text
        arac_ekle.Show()
    End Sub


    Private Sub p18_Click_1(sender As Object, e As EventArgs) Handles p18.Click
        park_adi = Button18.Text
        arac_ekle.Show()
    End Sub

    Private Sub p19_Click_1(sender As Object, e As EventArgs) Handles p19.Click
        park_adi = Button19.Text
        arac_ekle.Show()
    End Sub

    Private Sub p20_Click_1(sender As Object, e As EventArgs) Handles p20.Click
        park_adi = Button20.Text
        arac_ekle.Show()
    End Sub




    ''
    ''
    ''








    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        park_adi = Button1.Text
        arac_detay.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        park_adi = Button2.Text
        arac_detay.Show()

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        park_adi = Button3.Text
        arac_detay.Show()

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        park_adi = Button4.Text
        arac_detay.Show()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        park_adi = Button5.Text
        arac_detay.Show()

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        park_adi = Button6.Text
        arac_detay.Show()

    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        park_adi = Button7.Text
        arac_detay.Show()

    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        park_adi = Button8.Text
        arac_detay.Show()

    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        park_adi = Button9.Text
        arac_detay.Show()

    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        park_adi = Button10.Text
        arac_detay.Show()

    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        park_adi = Button11.Text
        arac_detay.Show()

    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        park_adi = Button12.Text
        arac_detay.Show()

    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        park_adi = Button13.Text
        arac_detay.Show()

    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        park_adi = Button14.Text
        arac_detay.Show()

    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click
        park_adi = Button15.Text
        arac_detay.Show()

    End Sub

    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles Button16.Click
        park_adi = Button16.Text
        arac_detay.Show()

    End Sub

    Private Sub Button17_Click(sender As Object, e As EventArgs) Handles Button17.Click
        park_adi = Button17.Text
        arac_detay.Show()

    End Sub

    Private Sub Button18_Click(sender As Object, e As EventArgs) Handles Button18.Click
        park_adi = Button18.Text
        arac_detay.Show()

    End Sub

    Private Sub Button19_Click(sender As Object, e As EventArgs) Handles Button19.Click
        park_adi = Button19.Text
        arac_detay.Show()

    End Sub

    Private Sub Button20_Click(sender As Object, e As EventArgs) Handles Button20.Click
        park_adi = Button20.Text
        arac_detay.Show()

    End Sub


    Private Sub Button23_Click(sender As Object, e As EventArgs)
        Application.Exit()
    End Sub

    Private Sub Button22_Click(sender As Object, e As EventArgs) Handles Button22.Click
        ucretlendirme.Show()
    End Sub


    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Application.Exit()
    End Sub
End Class
