Imports System.Data.OleDb
Imports System.Data

Public Class ucretlendirme
    Dim src = anasayfa.src
    Dim baglanti As New OleDbConnection("Provider=sqloledb;Data Source=" & src & ";Initial Catalog=otopark;Integrated Security=SSPI;")
    Dim dr_satir_id As Integer

    Dim load_otomobil_ucret As Integer
    Dim load_midibus_ucret As Integer
    Dim load_motosiklet_ucret As Integer
    Dim load_diger_ucret As Integer




    Private Sub ucretlendirme_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Dim komut As New OleDbCommand("select * from ucretlendirme", baglanti)
            Dim veriokuyucu As OleDbDataReader
            baglanti.Open()
            veriokuyucu = komut.ExecuteReader
            If veriokuyucu.Read Then
                TextBox1.Text = veriokuyucu("otomobil_pikap_minubus")
                TextBox2.Text = veriokuyucu("midibus_otobus_kamyon")
                TextBox3.Text = veriokuyucu("motosiklet")
                TextBox4.Text = veriokuyucu("diger")
            End If

            baglanti.Close()

            load_otomobil_ucret = TextBox1.Text
            load_midibus_ucret = TextBox2.Text
            load_motosiklet_ucret = TextBox3.Text
            load_diger_ucret = TextBox4.Text
        Catch ex As Exception
            anasayfa.catch_msg()
        End Try

       
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            If load_otomobil_ucret = TextBox1.Text And load_midibus_ucret = TextBox2.Text And load_motosiklet_ucret = TextBox3.Text And load_diger_ucret = TextBox4.Text Then
                MsgBox("HERHANGİ BİR ÜCRET DEĞİŞİKLİĞİ YAPMADINIZ.", MsgBoxStyle.Critical, "UYARI")
            Else
                Dim cevap As Integer = MsgBox("SAATLİK ÜCRETLER DEĞİŞTİRİLECEK EMİN MİSİNİZ?", MsgBoxStyle.YesNo, "Uyarı")
                If cevap = DialogResult.Yes Then
                    If TextBox1.Text <= "0" Or TextBox2.Text <= "0" Or TextBox3.Text <= "0" Or TextBox4.Text <= "0" Then
                        MsgBox("LÜTFEN GEÇERLİ BİR ÜCRET GİRİNİZ", MsgBoxStyle.Critical, "UYARI")
                    Else
                        ' VERİTABANINDAN ID değerinin alınması
                        Dim satir_id As New OleDbCommand("select max(id) as id from ucretlendirme", baglanti)
                        Dim veriokuyucu As OleDbDataReader
                        baglanti.Open()
                        veriokuyucu = satir_id.ExecuteReader
                        If veriokuyucu.Read Then
                            dr_satir_id = veriokuyucu("id")
                        End If
                        baglanti.Close()


                        ' ALINAN ID DEĞERİNE GÖRE ARAÇ TÜRLERİ ÜCRET GÜNCELLEME İŞLEMİ
                        Dim komut As New OleDbCommand("update ucretlendirme set otomobil_pikap_minubus = '" & TextBox1.Text & "', midibus_otobus_kamyon = '" & TextBox2.Text & "', motosiklet='" & TextBox3.Text & "', diger='" & TextBox4.Text & "' where id ='" & dr_satir_id & "' ", baglanti)
                        baglanti.Open()
                        komut.ExecuteNonQuery()
                        baglanti.Close()
                        MsgBox("SAATLİK ÜCRETLER BAŞARIYLA GÜNCELLENDİ", MsgBoxStyle.Information, "BAŞARILI")

                        anasayfa.saatlik_ucret_hesapla()
                        Me.Close()
                    End If
                Else

                End If
            End If
        Catch ex As Exception
            anasayfa.catch_msg()
        End Try
        

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

End Class