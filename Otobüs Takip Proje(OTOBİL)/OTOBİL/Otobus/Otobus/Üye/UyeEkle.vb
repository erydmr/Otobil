Imports MySql.Data
Imports MySql.Data.MySqlClient
Public Class UyeEkle
    Dim oku As MySqlDataReader
    Dim MySqlConn As New MySqlConnection
    Dim komut As New MySqlCommand
    Public Sub temizle()
        TxtCepTel.Text = ""
        TxtAd.Text = ""
        TxtSoyad.Text = ""
        TxtMail.Text = ""
        TxtTc.Text = ""
        CbCinsiyet.Text = ""
        TxtAdres.Text = ""
        CbIl.Text = " "
        CbIlce.Text = " "
        DTPDogumTarihi.Text = DateTime.Now.Date
        CbOgrenimDurumu.Text = ""
        CbMeslek.Text = " "
    End Sub
    Sub kaydet()
        Try
            MySqlConn.Open()
            Dim komut As New MySqlCommand("insert into uyeler(tc,uye_adi,uye_soyadi,telefon,mail,il,ilce,adres,dogum_tarihi,ogrenim_durumu,meslek,cinsiyet,puan) values('" & TxtTc.Text & "','" & TxtAd.Text & "','" & TxtSoyad.Text & "','" & TxtCepTel.Text & "','" & TxtMail.Text & "','" & CbIl.Text & "','" & CbIlce.Text & "','" & TxtAdres.Text & "','" & DTPDogumTarihi.Text & "','" & CbOgrenimDurumu.Text & "','" & CbMeslek.Text & "','" & CbCinsiyet.Text & "','" & LblBakiye.Text & "')", MySqlConn)
            komut.ExecuteNonQuery()
            komut.Dispose()
            MessageBox.Show("Kayıt Başarılı")
            temizle()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            MySqlConn.Close()
        End Try
    End Sub
    Sub ilekle()
        Try
            MySqlConn.ConnectionString = "Server=web2.hosting.com.tr;database=webpaket_bus;Uid=webpaket_bir;Password=muharrem123?;"
            MySqlConn.Open()
            komut.Connection = MySqlConn
            komut.CommandText = "Select baslik From iller"
            oku = komut.ExecuteReader()
            'MessageBox.Show("Bağlantı açıldı..")
            While oku.Read()
                CbIl.Items.Add(oku(0).ToString())
            End While
            oku.Dispose()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            MySqlConn.Close()
        End Try
    End Sub
    Sub ilceekle()
        Try
            CbIlce.Items.Clear()
            MySqlConn.ConnectionString = "Server=web2.hosting.com.tr;database=webpaket_bus;Uid=webpaket_bir;Password=muharrem123?;"
            MySqlConn.Open()
            komut.Connection = MySqlConn
            komut.CommandText = "Select baslik From ilceler where il_id='" & CbIl.SelectedIndex & "'"
            oku = komut.ExecuteReader()
            While oku.Read()
                CbIlce.Items.Add(oku(0).ToString())
            End While
            oku.Dispose()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            MySqlConn.Close()
        End Try
    End Sub
    Private Sub BtnKaydet_Click(sender As Object, e As EventArgs) Handles BtnKaydet.Click
        'If TxtCepTel.TextLength < 10 Then
        '   MessageBox.Show("Lütfen Cep Telefonunu (5XX)XXXXXXX(10 Karakter Şeklinde) Şeklinde Giriniz.")
        'End If
        'elseIf TxtTc.TextLength < 11 Then
        '    MessageBox.Show("Lütfen TC Kimlik Numarasını 11 Karakter Şeklinde giriniz.")
        ' End If
        If TxtCepTel.Text = "" Or TxtAd.Text = "" Or TxtSoyad.Text = "" Or TxtMail.Text = "" Or TxtTc.Text = "" Or CbCinsiyet.Text = "" Or CbIl.Text = "" Or CbIlce.Text = "" Or TxtAdres.Text = "" Or DTPDogumTarihi.Text = "" Or CbOgrenimDurumu.Text = "" Or CbMeslek.Text = "" Then
            MessageBox.Show("Lütfen Boş Yer Bırakmayınız.")
        ElseIf TxtTc.TextLength <> 11 Then
            MessageBox.Show("Lütfen TC Kimlik Numarasını 11 Karakter Şeklinde giriniz.")
        ElseIf TxtCepTel.TextLength <> 10 Then
            MessageBox.Show("Lütfen Cep Telefonunu (5XX)XXXXXXX(10 Karakter Şeklinde) Şeklinde Giriniz.")
        Else
            kaydet()
        End If
    End Sub
    Private Sub UyeEkle_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DTPDogumTarihi.Text = Date.Today
        MySqlConn.ConnectionString = "Server=sql11.freemysqlhosting.net;Database=sql11168214;Uid=sql11168214;Password=4Ci7FaFEF8;"
        ilekle()
    End Sub
    Private Sub CbIl_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CbIl.SelectedIndexChanged
        ilceekle()
    End Sub
    Private Sub BtnGeri_Click(sender As Object, e As EventArgs) Handles BtnGeri.Click
        Dim x = New GecisForm
        x.Show()
        Me.Close()
    End Sub
    Private Sub TxtAd_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtAd.KeyPress, TxtSoyad.KeyPress
        If Not Char.IsLetter(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) Then
            e.Handled = True
        End If
    End Sub
    Private Sub TxtTc_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtTc.KeyPress
        If Not (Char.IsNumber(e.KeyChar) = True) And e.KeyChar <> ChrW(Keys.Back) Then
            e.Handled = True
        End If
    End Sub
    Private Sub TxtCepTel_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtCepTel.KeyPress
        If Not (Char.IsNumber(e.KeyChar) = True) And e.KeyChar <> ChrW(Keys.Back) Then
            e.Handled = True
        End If
    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub
End Class