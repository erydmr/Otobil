Imports MySql.Data.MySqlClient
Public Class SeferEkle
    Dim nere, otobusturu As String
    Dim neye As String
    Dim oku As MySqlDataReader
    Dim MySqlConn As New MySqlConnection
    Dim komut As New MySqlCommand
    Public Sub ilekle()
        Try
            MySqlConn.Open()
            komut.CommandText = "Select baslik From iller"
            oku = komut.ExecuteReader()
            While oku.Read()
                neredenCb.Items.Add(oku(0).ToString())
                nereyeCb.Items.Add(oku(0).ToString())
            End While
            oku.Dispose()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            MySqlConn.Close()
        End Try
    End Sub
    Sub kaydet()
        Try
            MySqlConn.Open()
            Dim komut As New MySqlCommand("insert into seferler(nerden,nereye,tarih,saat,otobus_id,sefer_kodu,fiyat,Otobus_turu) values
    ('" & neredenCb.SelectedItem & "','" & nereyeCb.SelectedItem & "','" & tarihDt.Text & "','" & saatDt.Value.ToShortTimeString & "','" & otobusCb.Text & "','" & seferkodu.Text & "','" & fiyatTxt.Text & "','" & Lblotobusturu.Text & "')", MySqlConn)
            komut.ExecuteNonQuery()
            komut.Dispose()
            MessageBox.Show("Kayıt Başarılı")
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            MySqlConn.Close()
        End Try
    End Sub
    Public Sub otobusekle()
        Try
            MySqlConn.Open()
            komut.CommandText = "Select * From otobusler"
            oku = komut.ExecuteReader()
            While oku.Read()
                otobusCb.Items.Add(oku(1).ToString())
            End While
            oku.Dispose()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            MySqlConn.Close()
        End Try
    End Sub
    Sub otobus_turu()
        Try
            MySqlConn.Open()
            komut.CommandText = "Select otobus_turu From otobusler where plaka='" & otobusCb.Text & "'"
            oku = komut.ExecuteReader()
            While oku.Read()
                Lblotobusturu.Text = (oku(0).ToString())
            End While
            oku.Dispose()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            MySqlConn.Close()
        End Try
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim x = New GecisForm
        x.Show()
        Me.Close()
    End Sub
    Private Sub SeferEkle_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tarihDt.Text = Date.Today
        MySqlConn.ConnectionString = "Server=sql11.freemysqlhosting.net;Database=sql11168214;Uid=sql11168214;Password=4Ci7FaFEF8;"
        komut.Connection = MySqlConn
        ilekle()
        otobusekle()
    End Sub
    Private Sub neredenCb_SelectedIndexChanged(sender As Object, e As EventArgs) Handles neredenCb.SelectedIndexChanged
        nere = neredenCb.SelectedIndex
        If nere < 10 Then
            nere = 0 & neredenCb.SelectedIndex
        End If
        seferkodu.Text = nere
    End Sub
    Private Sub nereyeCb_SelectedIndexChanged(sender As Object, e As EventArgs) Handles nereyeCb.SelectedIndexChanged
        neye = nereyeCb.SelectedIndex
        If neye < 10 Then
            neye = 0 & nereyeCb.SelectedIndex
        End If
        seferkodu.Text = nere & neye
    End Sub
    Private Sub ekleBtn_Click(sender As Object, e As EventArgs) Handles ekleBtn.Click
        If neredenCb.Text = "" Or nereyeCb.Text = "" Or tarihDt.Text = "" Or saatDt.Text = "" Or otobusCb.Text = "" Or fiyatTxt.Text = "" Then
            MessageBox.Show("Lütfen Boş Alan Bırakmayınız.")
        Else
            Dim dt As String = saatDt.Value.ToShortTimeString.Remove(2, 1)
            seferkodu.Text = nere & neye & dt
            '    seferkodu.Text = nere & neye & saatDt.Text
            '   MessageBox.Show(nere & neye & saatDt.Text)
            kaydet()
        End If
    End Sub
    Private Sub fiyatTxt_KeyPress(sender As Object, e As KeyPressEventArgs) Handles fiyatTxt.KeyPress
        If Not (Char.IsNumber(e.KeyChar) = True) And e.KeyChar <> ChrW(Keys.Back) Then
            e.Handled = True
        End If
    End Sub
    Private Sub otobusCb_SelectedIndexChanged(sender As Object, e As EventArgs) Handles otobusCb.SelectedIndexChanged
        otobus_turu()
    End Sub
End Class