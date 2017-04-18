Imports MySql.Data
Imports MySql.Data.MySqlClient
Public Class UyeEkle
    Dim MySqlConn As New MySqlConnection
    Dim komut As New MySqlCommand
    Dim oku As MySqlDataReader

    Private Sub BtnKaydet_Click(sender As Object, e As EventArgs) Handles BtnKaydet.Click
        'MySqlConn = New MySqlConnection()
        MySqlConn.ConnectionString = "Server=web2.hosting.com.tr;database=webpaket_bus;Uid=webpaket_bir;Password=muharrem123?;"
        Try
            MySqlConn.Open()
            Dim komut As New MySqlCommand("insert into uyeler(tc,uye_adi,uye_soyadi,telefon,mail,il,ilce,adres,dogum_tarihi,ogrenim_durumu,meslek,cinsiyet,puan) values('" & TxtTc.Text & "','" & TxtAd.Text & "','" & TxtSoyad.Text & "','" & TxtCepTel.Text & "','" & TxtMail.Text & "','" & CbIl.Text & "','" & CbIlce.Text & "','" & TxtAdres.Text & "','" & DTPDogumTarihi.Text & "','" & CbOgrenimDurumu.Text & "','" & CbMeslek.Text & "','" & CbCinsiyet.Text & "','" & LblBakiye.Text & "')", MySqlConn)
            komut.ExecuteNonQuery()
            komut.Dispose()
            MessageBox.Show("Kayıt Başarılı")
            MySqlConn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub UyeEkle_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            MySqlConn.Open()
            MessageBox.Show("Database Açıldı...")
            komut.CommandText = "Select * From iller"
            komut.Connection = MySqlConn
            oku = komut.ExecuteReader
            While oku.Read
                CbIl.Items.Add(oku(1).ToString())
            End While
            MySqlConn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
End Class