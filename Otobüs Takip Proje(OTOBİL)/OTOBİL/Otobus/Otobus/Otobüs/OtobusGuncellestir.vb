Imports MySql.Data.MySqlClient
Public Class OtobusGuncellestir
    Dim busid As String
    Dim oku As MySqlDataReader
    Dim MySqlConn As New MySqlConnection
    Dim komut As New MySqlCommand
    Sub temizle()
        TxtAd.Text = ""
        TxtCepTel.Text = ""
        plakaTxt.Text = ""
        CbTur.Text = ""
    End Sub
    Sub sil()
        Try
            MySqlConn.Open()
            komut.CommandText = "Delete From otobusler where id='" & busid & "'"
            komut.ExecuteNonQuery()
            komut.Dispose()
            MessageBox.Show("Otobüs İşlemleri Silindi.")
            otobusLb.Items.Clear()
            read()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            MySqlConn.Close()
        End Try
    End Sub
    Sub guncellestir()
        Try
            MySqlConn.Open()
            komut.CommandText = "Update otobusler Set plaka = '" & plakaTxt.Text.ToUpper & "',sofor_adi = '" & TxtAd.Text & "',sofor_tel = '" & TxtCepTel.Text & "',otobus_turu = '" & CbTur.Text & "' where id='" & busid & "'"
            komut.ExecuteNonQuery()
            komut.Dispose()
            MessageBox.Show("Otobüs İşlemleri Güncellendi.")
            temizle()
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
            komut.CommandText = "Select * From otobusler"
            oku = komut.ExecuteReader()
            While oku.Read()
                otobusLb.Items.Add(oku(0).ToString() + "- " + oku(1).ToString() + " " + oku(2).ToString())
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
            komut.CommandText = "Select * From otobusler where id='" & busid & "'"
            oku = komut.ExecuteReader()
            While oku.Read()
                plakaTxt.Text = oku(1).ToString()
                TxtAd.Text = oku(2).ToString()
                TxtCepTel.Text = oku(3).ToString()
                CbTur.Text = oku(4).ToString()
            End While
            oku.Dispose()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            MySqlConn.Close()
        End Try
    End Sub
    Private Sub geriBtn_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim x = New GecisForm
        x.Show()
        Me.Close()
    End Sub
    Private Sub OtobusGuncellestir_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MySqlConn.ConnectionString = "Server=sql11.freemysqlhosting.net;Database=sql11168214;Uid=sql11168214;Password=4Ci7FaFEF8;"
        komut.Connection = MySqlConn
        read()
    End Sub
    Private Sub otobusLb_SelectedIndexChanged(sender As Object, e As EventArgs) Handles otobusLb.SelectedIndexChanged
        Dim Kelimeler As String = otobusLb.SelectedItem
        Dim id() As String = Kelimeler.Split("-")
        busid = id(0)
        getir()
    End Sub
    Private Sub silBtn_Click(sender As Object, e As EventArgs) Handles silBtn.Click
        If TxtAd.Text = "" Or TxtCepTel.Text = "" Or plakaTxt.Text = "" Or CbTur.Text = "" Then
            MessageBox.Show("Lütfen Boş Alan Bırakmayınız.")
        ElseIf TxtCepTel.TextLength <> 10 Then
            MessageBox.Show("Lütfen Cep Telefonunu (5XX)XXXXXXX(10 Karakter Şeklinde) Şeklinde Giriniz.")
        Else
            sil()
        End If
    End Sub
    Private Sub guncellestirBtn_Click(sender As Object, e As EventArgs) Handles guncellestirBtn.Click
        If TxtAd.Text = "" Or TxtCepTel.Text = "" Or plakaTxt.Text = "" Or CbTur.Text = "" Then
            MessageBox.Show("Lütfen Boş Alan Bırakmayınız.")
        ElseIf TxtCepTel.TextLength <> 10 Then
            MessageBox.Show("Lütfen Cep Telefonunu (5XX)XXXXXXX(10 Karakter Şeklinde) Şeklinde Giriniz.")
        Else
            guncellestir()
        End If
    End Sub
    Private Sub TxtAd_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtAd.KeyPress
        If Not Char.IsLetter(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) Then
            e.Handled = True
        End If
    End Sub
    Private Sub TxtCepTel_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtCepTel.KeyPress
        If Not (Char.IsNumber(e.KeyChar) = True) And e.KeyChar <> ChrW(Keys.Back) Then
            e.Handled = True
        End If
    End Sub
End Class