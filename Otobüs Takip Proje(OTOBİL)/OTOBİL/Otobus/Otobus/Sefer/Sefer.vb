Imports MySql.Data.MySqlClient
Public Class Sefer
    Dim oku, oku2 As MySqlDataReader
    Dim MySqlConn As New MySqlConnection
    Dim komut, komut2 As New MySqlCommand
    Dim seferid, OtobusTuru, koltukid As String
    Sub FillBus()
        'Dim btn As Button = CType(Me.Controls.Find("Button" & 51, True)(0), Button)
        'btn.BackColor = Color.Blue
        Try
            MySqlConn.Open()
            'komut.Connection = MySqlConn
            komut2.Connection = MySqlConn
            komut.CommandText = "Select sefer_kodu From seferler where nerden='" & TxtKalkıs.Text & "' AND nereye='" & TxtVaris.Text & "' AND tarih='" & tarihDt.Text & "'"
            komut2.CommandText = "Select koltuk_no,musteri_cinsiyet,Otobus_turu From biletler where sefer_id='" & seferid.ToString & "'"
            oku = komut2.ExecuteReader()
            While oku.Read()
                If oku(1).ToString = "Bay" And oku(2).ToString = "2+1" Then
                    GB2arti1.Visible = True
                    GB2arti2.Visible = False
                    Dim btn As Button = CType(Me.Controls.Find("Btnikibir_" & oku(0).ToString, True)(0), Button)
                    btn.BackColor = Color.Blue
                ElseIf (oku(1).ToString = "Bayan" And oku(2).ToString = "2+1") Then
                    GB2arti1.Visible = True
                    GB2arti2.Visible = False
                    Dim btn As Button = CType(Me.Controls.Find("Btnikibir_" & oku(0).ToString, True)(0), Button)
                    btn.BackColor = Color.Red
                ElseIf oku(1).ToString = "Bay" And oku(2).ToString = "2+2" Then
                    GB2arti2.Visible = True
                    GB2arti1.Visible = False
                    Dim btn As Button = CType(Me.Controls.Find("Btnikiiki_" & oku(0).ToString, True)(0), Button)
                    btn.BackColor = Color.Blue
                ElseIf (oku(1).ToString = "Bayan" And oku(2).ToString = "2+2") Then
                    GB2arti2.Visible = True
                    GB2arti1.Visible = False
                    Dim btn As Button = CType(Me.Controls.Find("Btnikiiki_" & oku(0).ToString, True)(0), Button)
                    btn.BackColor = Color.Red
                End If
            End While
            oku.Dispose()
            ' MessageBox.Show("Otobüsler Boyandı")
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            MySqlConn.Close()
        End Try
    End Sub
    Sub UyeGetir()
        Try
            MySqlConn.Open()
            komut.Connection = MySqlConn
            komut.CommandText = "Select * From uyeler where telefon='" & TxtMusteriTel.Text & "'"
            oku = komut.ExecuteReader()
            While oku.Read()
                adTxt.Text = oku(2).ToString
                soyadTxt.Text = oku(3).ToString
                CbCinsiyet.Text = oku(12).ToString
                adTxt.Text = oku(2).ToString
                telefontxt.Text = oku(4).ToString
                tcnoTxt.Text = oku(1).ToString
                lblmail.Text = oku(5).ToString
            End While
            oku.Dispose()
        Catch ex As Exception
            MessageBox.Show("Üye Bulunamadı Lütfen Girilen Cep Telefon Numarasını Kontrol Ediniz.")
        Finally
            MySqlConn.Close()
        End Try
    End Sub
    Sub guncellestir()
        Try
            MySqlConn.Open()
            komut.CommandText = "Update biletler Set musteri_tc = '" & tcnoTxt.Text & "',musteri_adi = '" & adTxt.Text & "',musteri_soyadi = '" & soyadTxt.Text & "',musteri_telefon = '" & telefontxt.Text & "',musteri_mail = '" & lblmail.Text & "',musteri_cinsiyet = '" & CbCinsiyet.Text & "',koltuk_no='" & koltukCb.Text & "' where sefer_id ='" & seferid & "' and koltuk_no='" & koltukid & "'"
            komut.ExecuteNonQuery()
            MessageBox.Show("Bilet Güncellendi.")
            MySqlConn.Close()
            ' Dim btn As Button = CType(Me.Controls.Find("Btnikiiki_" & koltukid.ToString, True)(0), Button)
            BosaltKoltukları()
            FillBus()
            koltukid = koltukCb.Text
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            MySqlConn.Close()
        End Try
    End Sub
    Sub Kaydet()
        If seferlerLb.SelectedIndex <> -1 Then
            Dim Kelimeler As String = seferlerLb.SelectedItem
            Dim id() As String = Kelimeler.Split(" ")
            seferid = id(6)
            OtobusTuru = id(5)
            Try
                MySqlConn.Open()
                Dim komut As New MySqlCommand("insert into biletler(musteri_tc,musteri_adi,musteri_soyadi,musteri_telefon,musteri_cinsiyet,sefer_id,koltuk_no,Otobus_turu) values('" & tcnoTxt.Text & "','" & adTxt.Text & "','" & soyadTxt.Text & "','" & telefontxt.Text & "','" & CbCinsiyet.Text & "','" & seferid & "','" & koltukCb.Text & "','" & OtobusTuru & "')", MySqlConn)
                komut.ExecuteNonQuery()
                komut.Dispose()
                MessageBox.Show("Kayıt Başarılı")
                Dim btn As Button = CType(Me.Controls.Find("Btnikiiki_" & koltukid.ToString, True)(0), Button)
                If CbCinsiyet.Text = "Bay" Then
                    btn.BackColor = Color.Blue
                Else
                    btn.BackColor = Color.Red
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            Finally
                MySqlConn.Close()
            End Try
        End If
    End Sub
    Sub BosaltKoltukları()
        For i = 1 To 41
            Dim btn As Button = CType(Me.Controls.Find("Btnikibir_" & i.ToString, True)(0), Button)
            btn.BackColor = Color.Silver
        Next
        For i = 1 To 50
            Dim btn As Button = CType(Me.Controls.Find("Btnikiiki_" & i.ToString, True)(0), Button)
            btn.BackColor = Color.Silver
        Next
    End Sub
    Sub sil()
        Try
            MySqlConn.Open()
            komut.CommandText = "Delete From biletler where sefer_id ='" & seferid & "' and koltuk_no='" & koltukid & "'"
            komut.ExecuteNonQuery()
            MessageBox.Show("Koltuk Silindi.")
            komut.Dispose()
            Dim btn As Button = CType(Me.Controls.Find("Btnikibir_" & koltukid.ToString, True)(0), Button)
            btn.BackColor = Color.Silver
            Dim btn1 As Button = CType(Me.Controls.Find("Btnikiiki_" & koltukid.ToString, True)(0), Button)
            btn1.BackColor = Color.Silver
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            MySqlConn.Close()
        End Try
    End Sub
    Public Sub ilekle()
        Try
            MySqlConn.Open()
            komut.CommandText = "Select baslik From iller"
            oku = komut.ExecuteReader()
            While oku.Read()
                TxtKalkıs.Items.Add(oku(0).ToString())
                TxtVaris.Items.Add(oku(0).ToString())
            End While
            oku.Dispose()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            MySqlConn.Close()
        End Try
    End Sub
    Public Sub getirYolcu()
        Try
            MySqlConn.Open()
            komut.CommandText = "Select * From biletler where sefer_id ='" & seferid & "' and koltuk_no='" & koltukid & "'"
            oku = komut.ExecuteReader()
            If oku.Read() Then
                tcnoTxt.Text = oku(1)
                adTxt.Text = oku(2)
                soyadTxt.Text = oku(3)
                telefontxt.Text = oku(4)
                CbCinsiyet.Text = oku(6)
            Else
                tcnoTxt.Text = ""
                adTxt.Text = ""
                soyadTxt.Text = ""
                telefontxt.Text = ""
                CbCinsiyet.Text = ""
            End If
            oku.Dispose()
        Catch ex As Exception
            MessageBox.Show("Kayıtlarda Böyle Bir Yolcu Bulunmamaktadır.")
        Finally
            MySqlConn.Close()
        End Try
    End Sub
    Sub SeferSorgula()
        Try
            MySqlConn.Open()
            komut.Connection = MySqlConn
            komut.CommandText = "Select * From seferler where nerden='" & TxtKalkıs.Text & "' AND nereye='" & TxtVaris.Text & "' AND tarih='" & tarihDt.Text & "'"
            ' komut2.CommandText = "Select otobus_turu,plaka From otobusler"
            oku = komut.ExecuteReader()
            While oku.Read()
                seferlerLb.Items.Add(oku(1).ToString() + " " + oku(2).ToString() + " " + oku(3).ToString + " " + oku(4).ToString + " " + oku(7).ToString + " " + oku(8).ToString + " " + oku(6).ToString())
            End While
            oku.Dispose()
        Catch ex As Exception
            MessageBox.Show("Bu Tarihte Seferlerimiz Yoktur.")
        Finally
            MySqlConn.Close()
        End Try
    End Sub
    Private Sub Sefer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MySqlConn.ConnectionString = "Server=sql11.freemysqlhosting.net;Database=sql11168214;Uid=sql11168214;Password=4Ci7FaFEF8;"
        komut.Connection = MySqlConn
        tarihDt.Text = Date.Today
        ilekle()
    End Sub
    Private Sub BtnSeferSorgula_Click(sender As Object, e As EventArgs) Handles BtnSeferSorgula.Click
        If TxtKalkıs.Text = "" Or TxtVaris.Text = "" Or tarihDt.Text = "" Then
            MessageBox.Show("Lütfen Boş Yer Bırakmayınız.")
        Else
            seferlerLb.Items.Clear()
            SeferSorgula()
            neredenLbl.Text = TxtKalkıs.Text
            nereyeLbl.Text = TxtVaris.Text
            tarihLbl.Text = tarihDt.Text
        End If
    End Sub
    Private Sub BtnUyeGetir_Click(sender As Object, e As EventArgs) Handles BtnUyeGetir.Click
        If TxtMusteriTel.Text = "" Then
            MessageBox.Show("Lütfen Müşterinin CepTelefonunu giriniz.")
        ElseIf TxtMusteriTel.TextLength <> 10 Then
            MessageBox.Show("Lütfen Cep Telefonunu (5XX)XXXXXXX(10 Karakter Şeklinde) Şeklinde Giriniz.")
        Else
            UyeGetir()
        End If
    End Sub
    Private Sub BtnUyeOlustur_Click(sender As Object, e As EventArgs) Handles BtnUyeOlustur.Click
        Dim x = New UyeEkle
        x.Show()
    End Sub
    Private Sub Btnikibir_1_Click(sender As Object, e As EventArgs) Handles Btnikibir_1.Click, Btnikiiki_8.Click, Btnikiiki_7.Click, Btnikiiki_6.Click, Btnikiiki_5.Click, Btnikiiki_4.Click, Btnikiiki_3.Click, Btnikiiki_2.Click, Btnikiiki_1.Click, Btnikibir_6.Click, Btnikibir_5.Click, Btnikibir_3.Click, Btnikibir_2.Click, Btnikiiki_9.Click, Btnikiiki_50.Click, Btnikiiki_49.Click, Btnikiiki_48.Click, Btnikiiki_47.Click, Btnikiiki_46.Click, Btnikiiki_45.Click, Btnikiiki_44.Click, Btnikiiki_43.Click, Btnikiiki_42.Click, Btnikiiki_41.Click, Btnikiiki_40.Click, Btnikiiki_39.Click, Btnikiiki_38.Click, Btnikiiki_37.Click, Btnikiiki_36.Click, Btnikiiki_35.Click, Btnikiiki_34.Click, Btnikiiki_33.Click, Btnikiiki_32.Click, Btnikiiki_31.Click, Btnikiiki_30.Click, Btnikiiki_29.Click, Btnikiiki_28.Click, Btnikiiki_27.Click, Btnikiiki_26.Click, Btnikiiki_25.Click, Btnikiiki_24.Click, Btnikiiki_23.Click, Btnikiiki_22.Click, Btnikiiki_21.Click, Btnikiiki_20.Click, Btnikiiki_19.Click, Btnikiiki_18.Click, Btnikiiki_17.Click, Btnikiiki_16.Click, Btnikiiki_15.Click, Btnikiiki_14.Click, Btnikiiki_13.Click, Btnikiiki_12.Click, Btnikiiki_11.Click, Btnikiiki_10.Click, Btnikibir_9.Click, Btnikibir_8.Click, Btnikibir_7.Click, Btnikibir_41.Click, Btnikibir_40.Click, Btnikibir_4.Click, Btnikibir_39.Click, Btnikibir_38.Click, Btnikibir_37.Click, Btnikibir_36.Click, Btnikibir_35.Click, Btnikibir_34.Click, Btnikibir_33.Click, Btnikibir_32.Click, Btnikibir_31.Click, Btnikibir_30.Click, Btnikibir_29.Click, Btnikibir_28.Click, Btnikibir_27.Click, Btnikibir_26.Click, Btnikibir_25.Click, Btnikibir_24.Click, Btnikibir_23.Click, Btnikibir_22.Click, Btnikibir_21.Click, Btnikibir_20.Click, Btnikibir_19.Click, Btnikibir_18.Click, Btnikibir_17.Click, Btnikibir_16.Click, Btnikibir_15.Click, Btnikibir_14.Click, Btnikibir_13.Click, Btnikibir_12.Click, Btnikibir_11.Click, Btnikibir_10.Click
        Dim btn As Button = CType(sender, Button)
        '   MessageBox.Show(btn.Text + " isimli butona tıkladınız")
        koltukCb.Text = btn.Text
        koltukid = btn.Text
        getirYolcu()
    End Sub
    Private Sub BtnSil_Click(sender As Object, e As EventArgs) Handles BtnSil.Click
        If tcnoTxt.Text = "" Or adTxt.Text = "" Or soyadTxt.Text = "" Or telefontxt.Text = "" Or CbCinsiyet.Text = "" Or koltukCb.Text = "" Then
            MessageBox.Show("Lütfen Boş Yer Bırakmayınız.")
        ElseIf telefonTxt.TextLength <> 10 Then
            MessageBox.Show("Lütfen Cep Telefonunu (5XX)XXXXXXX(10 Karakter Şeklinde) Şeklinde Giriniz.")
        ElseIf tcnoTxt.TextLength <> 11 Then
            MessageBox.Show("Lütfen TC Kimlik Numarasını 11 Karakter Şeklinde giriniz.")
        Else
            sil()
        End If
    End Sub

    Private Sub BtnBiletiKes_Click(sender As Object, e As EventArgs) Handles BtnBiletiKes.Click
        If tcnoTxt.Text = "" Or adTxt.Text = "" Or soyadTxt.Text = "" Or telefontxt.Text = "" Or CbCinsiyet.Text = "" Or koltukCb.Text = "" Then
            MessageBox.Show("Lütfen Boş Yer Bırakmayınız.")
        ElseIf telefontxt.TextLength <> 10 Then
            MessageBox.Show("Lütfen Cep Telefonunu (5XX)XXXXXXX(10 Karakter Şeklinde) Şeklinde Giriniz.")
        ElseIf tcnoTxt.TextLength <> 11 Then
            MessageBox.Show("Lütfen TC Kimlik Numarasını 11 Karakter Şeklinde giriniz.")
        Else
            Kaydet()
        End If
    End Sub
    Private Sub guncelleBtn_Click(sender As Object, e As EventArgs) Handles guncelleBtn.Click
        If tcnoTxt.Text = "" Or adTxt.Text = "" Or soyadTxt.Text = "" Or telefontxt.Text = "" Or CbCinsiyet.Text = "" Or koltukCb.Text = "" Then
            MessageBox.Show("Lütfen Boş Yer Bırakmayınız.")
        ElseIf telefontxt.TextLength <> 10 Then
            MessageBox.Show("Lütfen Cep Telefonunu (5XX)XXXXXXX(10 Karakter Şeklinde) Şeklinde Giriniz.")
        ElseIf tcnoTxt.TextLength <> 11 Then
            MessageBox.Show("Lütfen TC Kimlik Numarasını 11 Karakter Şeklinde giriniz.")
        Else
            guncellestir()
        End If
    End Sub

    Private Sub telefontxt_KeyPress(sender As Object, e As KeyPressEventArgs) Handles telefontxt.KeyPress
        If Not (Char.IsNumber(e.KeyChar) = True) And e.KeyChar <> ChrW(Keys.Back) Then
            e.Handled = True
        End If
    End Sub

    Private Sub tcnoTxt_KeyPress_1(sender As Object, e As KeyPressEventArgs) Handles tcnoTxt.KeyPress
        If Not (Char.IsNumber(e.KeyChar) = True) And e.KeyChar <> ChrW(Keys.Back) Then
            e.Handled = True
        End If
    End Sub
    Private Sub soyadTxt_KeyPress(sender As Object, e As KeyPressEventArgs) Handles soyadTxt.KeyPress
        If Not Char.IsLetter(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) Then
            e.Handled = True
        End If
    End Sub

    Private Sub adTxt_KeyPress(sender As Object, e As KeyPressEventArgs) Handles adTxt.KeyPress
        If Not Char.IsLetter(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) Then
            e.Handled = True
        End If
    End Sub

    Private Sub tcnoTxt_KeyPress(sender As Object, e As KeyPressEventArgs)
        If Not (Char.IsNumber(e.KeyChar) = True) And e.KeyChar <> ChrW(Keys.Back) Then
            e.Handled = True
        End If
    End Sub
    Private Sub TxtMusteriTel_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtMusteriTel.KeyPress
        If Not (Char.IsNumber(e.KeyChar) = True) And e.KeyChar <> ChrW(Keys.Back) Then
            e.Handled = True
        End If
    End Sub
    Private Sub geriBtn_Click(sender As Object, e As EventArgs) Handles geriBtn.Click
        Dim x = New GecisForm
        x.Show()
        Me.Close()
    End Sub
    Private Sub seferlerLb_SelectedIndexChanged(sender As Object, e As EventArgs) Handles seferlerLb.SelectedIndexChanged
        If seferlerLb.SelectedIndex <> -1 Then
            BosaltKoltukları()
            koltukCb.Text = "---"
            Dim Kelimeler As String = seferlerLb.SelectedItem
            Dim id() As String = Kelimeler.Split(" ")
            seferid = id(6)
            saatLbl.Text = id(2)
            otobusturLbl.Text = id(5)
            LblTutar.Text = id(4)
            FillBus()
            If otobusturLbl.Text = "2+1" Then
                GB2arti1.Visible = True
                GB2arti2.Visible = False
                koltukCb.Items.Clear()
                For i = 1 To 41
                    koltukCb.Items.Add(i.ToString())
                Next
            Else
                GB2arti1.Visible = False
                GB2arti2.Visible = True
                koltukCb.Items.Clear()
                For i = 1 To 50
                    koltukCb.Items.Add(i.ToString())
                Next
            End If
        End If
    End Sub
End Class