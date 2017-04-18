Imports MySql.Data.MySqlClient
Public Class UyeGuncellestir
    Dim oku As MySqlDataReader
    Dim MySqlConn As New MySqlConnection
    Dim komut As New MySqlCommand
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
    Sub temizle()
        TxtCepTel.Text = ""
        TxtAd.Text = ""
        TxtSoyad.Text = ""
        TxtMail.Text = ""
        TxtTc.Text = ""
        CbCinsiyet.Text = ""
        CbIl.Text = ""
        CbIlce.Text = ""
        TxtAdres.Text = ""
        DTPDogumTarihi.Text = ""
        CbOgrenimDurumu.Text = ""
        CbMeslek.Text = ""
    End Sub
    Sub sil()
        Try
            MySqlConn.Open()
            komut.CommandText = "Delete From uyeler where tc='" & TxtTc.Text & "'"
            komut.ExecuteNonQuery()
            MessageBox.Show("Üye Silindi.")
            LsUyeler.Items.Clear()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            MySqlConn.Close()
        End Try
    End Sub
    Sub guncelle()
        Try
            MySqlConn.Open()
            komut.CommandText = "Update uyeler Set uye_adi= '" & TxtAd.Text & "',uye_soyadi='" & TxtSoyad.Text & "',telefon='" & TxtCepTel.Text & "',mail='" & TxtMail.Text & "',il='" & CbIl.Text & "',ilce='" & CbIlce.Text & "',adres='" & TxtAdres.Text & "',dogum_tarihi='" & DTPDogumTarihi.Text & "',ogrenim_durumu='" & CbOgrenimDurumu.Text & "',meslek='" & CbMeslek.Text & "' ,cinsiyet='" & CbCinsiyet.Text & "'where tc='" & TxtTc.Text & "'"
            komut.ExecuteNonQuery()
            MessageBox.Show("Üye Güncellendi.")
            LsUyeler.Items.Clear()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            MySqlConn.Close()
        End Try
    End Sub
    Sub read()
        Try
            MySqlConn.Open()
            komut.Connection = MySqlConn
            komut.CommandText = "Select * From uyeler"
            oku = komut.ExecuteReader()
            While oku.Read()
                LsUyeler.Items.Add(oku(2).ToString() + " " + oku(3).ToString() + " " + oku(4).ToString())
            End While
            oku.Dispose()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            MySqlConn.Close()
        End Try
    End Sub
    Sub getir()
        Try
            MySqlConn.Open()
            komut.Connection = MySqlConn
            ' komut.CommandText = "Select * From uyeler where telefon='" & fortel & "'" ''" & oku(4).ToString() & "'
            komut.CommandText = "Select * From uyeler where telefon='" & LblSorguIcin.Text & "'" ''" & oku(4).ToString() & "'
            oku = komut.ExecuteReader()
            While oku.Read()
                TxtCepTel.Text = oku(4).ToString
                TxtAd.Text = oku(2).ToString
                TxtSoyad.Text = oku(3).ToString
                TxtMail.Text = oku(5).ToString
                TxtTc.Text = oku(1).ToString
                CbCinsiyet.Text = oku(12).ToString
                CbIl.Text = oku(6).ToString
                CbIlce.Text = oku(7).ToString
                TxtAdres.Text = oku(8).ToString
                DTPDogumTarihi.Text = oku(9).ToString
                CbOgrenimDurumu.Text = oku(10).ToString
                CbMeslek.Text = oku(11).ToString
            End While
            oku.Dispose()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            MySqlConn.Close()
        End Try
    End Sub
    Private Sub BtnGuncelle_Click(sender As Object, e As EventArgs) Handles BtnGuncelle.Click
        If TxtCepTel.Text = "" Or TxtAd.Text = "" Or TxtSoyad.Text = "" Or TxtMail.Text = "" Or TxtTc.Text = "" Or CbCinsiyet.Text = "" Or CbIl.Text = "" Or CbIlce.Text = "" Or TxtAdres.Text = "" Or DTPDogumTarihi.Text = "" Or CbOgrenimDurumu.Text = "" Or CbMeslek.Text = "" Then
            MessageBox.Show("Lütfen Boş Alan Bırakmayınız.")
        ElseIf TxtCepTel.TextLength <> 10 Then
            MessageBox.Show("Lütfen Cep Telefonunu (5XX)XXXXXXX(10 Karakter Şeklinde) Şeklinde Giriniz.")
        ElseIf TxtTc.TextLength <> 11 Then
            MessageBox.Show("Lütfen TC Kimlik Numarasını 11 Karakter Şeklinde giriniz.")
        Else
            guncelle()
            temizle()
            read()
        End If
    End Sub
    Private Sub UyeGuncellestir_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MySqlConn.ConnectionString = "Server=sql11.freemysqlhosting.net;Database=sql11168214;Uid=sql11168214;Password=4Ci7FaFEF8;"
        komut.Connection = MySqlConn
        read()
        ilekle()
    End Sub
    Private Sub LsUyeler_SelectedIndexChanged(sender As Object, e As EventArgs) Handles LsUyeler.SelectedIndexChanged
        'LblSorguIcin.Text = LsUyeler.SelectedItem
        If LsUyeler.SelectedIndex <> -1 Then
            Dim parcalar() As String
            parcalar = LsUyeler.SelectedItem.Split(" ")
            LblSorguIcin.Text = ""
            LblSorguIcin.Text = parcalar(2).ToString
            getir()
        End If
    End Sub
    Private Sub BtnGeri_Click(sender As Object, e As EventArgs) Handles BtnGeri.Click
        Dim x = New GecisForm
        x.Show()
        Me.Close()
    End Sub
    Private Sub BtnSil_Click(sender As Object, e As EventArgs) Handles BtnSil.Click
        'If TxtCepTel.Text = "" Or TxtAd.Text = "" Or TxtSoyad.Text = "" Or TxtMail.Text = "" Or TxtTc.Text = "" Or CbCinsiyet.Text = "" Or CbIl.Text = "" Or CbIlce.Text = "" Or TxtAdres.Text = "" Or DTPDogumTarihi.Text = "" Or CbOgrenimDurumu.Text = "" Or CbMeslek.Text = "" Then
        'MessageBox.Show("Lütfen Boş Alan Bırakmayınız.")
        'ElseIf TxtCepTel.TextLength <> 10 Then
        'MessageBox.Show("Lütfen Cep Telefonunu (5XX)XXXXXXX(10 Karakter Şeklinde) Şeklinde Giriniz.")
        'ElseIf TxtTc.TextLength <> 11 Then
        'MessageBox.Show("Lütfen TC Kimlik Numarasını 11 Karakter Şeklinde giriniz.")
        'Else
        sil()
            temizle()
            read()
        'End If
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

    Private Sub CbIl_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CbIl.SelectedIndexChanged
        ilceekle()
    End Sub
End Class