Imports System.Data.OleDb
Imports System.Data

Public Class gecmis
    Dim src = anasayfa.src
    Dim baglanti As New OleDbConnection("Provider=sqloledb;Data Source=" & src & ";Initial Catalog=otopark;Integrated Security=SSPI;")


    Private Sub veri_cek()
        Dim ds As New DataSet
        Dim komut As New OleDbDataAdapter("select * from gecmis ORDER BY id desc", baglanti)
        baglanti.Open()
        komut.Fill(ds)
        BunifuCustomDataGrid1.DataSource = ds.Tables(0)
        baglanti.Close()

    End Sub


    Private Sub gecmis_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            veri_cek()
            'TODO: This line of code loads data into the 'OtoparkDataSet.gecmis' table. You can move, or remove it, as needed.
            Me.GecmisTableAdapter.Fill(Me.OtoparkDataSet.gecmis)
        Catch ex As Exception
            anasayfa.catch_msg()

        End Try
    End Sub
End Class