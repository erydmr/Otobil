Imports MySql.Data.MySqlClient
Public Class SeferGuncellestir
    Dim seferid As String
    Dim nere As String
    Dim neye As String
    Dim oku As MySqlDataReader
    Dim MySqlConn As New MySqlConnection
    Dim komut As New MySqlCommand
    Dim kom As New MySqlCommand
    Sub temizle()
        neredenCb.Text = ""
        nereyeCb.Text = ""
        saatDt.Text = ""
        tarihDt.Text = ""
        otobusCb.Text = ""
        seferkodu.Text = ""
        fiyatTxt.Text = ""
    End Sub
    Sub otobusekle()
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
    Sub guncellestir()
        Try
            MySqlConn.Open()
            komut.CommandText = "Update seferler Set nerden = '" & neredenCb.SelectedItem & "',nereye = '" & nereyeCb.SelectedItem & "',saat = '" & saatDt.Value.ToShortTimeString & "',tarih = '" & tarihDt.Text & "',otobus_id = '" & otobusCb.Text & "',sefer_kodu = '" & seferkodu.Text & "',fiyat = '" & fiyatTxt.Text & "',Otobus_turu = '" & CbOtobusTuru.Text & "' where id='" & seferid & "'"
            komut.ExecuteNonQuery()
            MessageBox.Show("Üye Güncellendi.")
            MySqlConn.Close()
            temizle()
            seferLb.Items.Clear()
            read()
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
                neredenCb.Items.Add(oku(0).ToString())
                nereyeCb.Items.Add(oku(0).ToString())
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
    Sub getir()
        Try
            MySqlConn.Open()
            komut.CommandText = "Select * From seferler where id='" & seferid & "'"
            oku = komut.ExecuteReader()
            While oku.Read()
                neredenCb.Text = oku(1)
                nereyeCb.Text = oku(2)
                saatDt.Text = oku(3)
                tarihDt.Text = oku(4)
                otobusCb.Text = oku(5)
                seferkodu.Text = oku(6)
                fiyatTxt.Text = oku(7)
                CbOtobusTuru.Text = oku(8)
            End While
            oku.Dispose()
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
            komut.CommandText = "Select * From seferler where nerden='" & TxtKalkıs.Text & "' AND nereye='" & TxtVaris.Text & "' AND tarih='" & sefertarihDt.Text & "'"
            oku = komut.ExecuteReader()
            While oku.Read()
                seferLb.Items.Add(oku(0).ToString() + " " + oku(1).ToString() + " " + oku(2).ToString() + " " + oku(6).ToString() + " " + oku(8).ToString)
            End While
            oku.Dispose()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            MySqlConn.Close()
        End Try
    End Sub
    Sub sil()
        Try
            MySqlConn.Open()
            komut.CommandText = "Delete From seferler where id='" & seferid & "'"
            komut.ExecuteNonQuery()
            MessageBox.Show("Sefer Silindi.")
            MySqlConn.Close()
            seferLb.Items.Clear()
            read()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            MySqlConn.Close()
        End Try
    End Sub
    Private Sub geriBtn_Click(sender As Object, e As EventArgs) Handles geriBtn.Click
        Dim x = New GecisForm
        x.Show()
        Me.Close()
    End Sub
    Private Sub seferLb_SelectedIndexChanged(sender As Object, e As EventArgs) Handles seferLb.SelectedIndexChanged
        Dim Kelimeler As String = seferLb.SelectedItem
        Dim id() As String = Kelimeler.Split(" ")
        seferid = id(0)
        getir()
    End Sub
    Private Sub SeferGuncellestir_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tarihDt.Text = Date.Today
        sefertarihDt.Text = Date.Today
        MySqlConn.ConnectionString = "Server=sql11.freemysqlhosting.net;Database=sql11168214;Uid=sql11168214;Password=4Ci7FaFEF8;"
        komut.Connection = MySqlConn
        otobusekle()
        ilekle()
    End Sub
    Private Sub silBtn_Click(sender As Object, e As EventArgs) Handles silBtn.Click
        If neredenCb.Text = "" Or nereyeCb.Text = "" Or tarihDt.Text = "" Or saatDt.Text = "" Or otobusCb.Text = "" Or fiyatTxt.Text = "" Then
            MessageBox.Show("Lütfen Boş Alan Bırakmayınız.")
        Else
            sil()
        End If
    End Sub
    Private Sub guncelleBtn_Click(sender As Object, e As EventArgs) Handles guncelleBtn.Click
        If neredenCb.Text = "" Or nereyeCb.Text = "" Or tarihDt.Text = "" Or saatDt.Text = "" Or otobusCb.Text = "" Or fiyatTxt.Text = "" Then
            MessageBox.Show("Lütfen Boş Alan Bırakmayınız.")
        Else
            guncellestir()
        End If
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
    Private Sub saatDt_ValueChanged(sender As Object, e As EventArgs) Handles saatDt.ValueChanged
        Dim dt As String = saatDt.Value.ToShortTimeString.Remove(2, 1)
        seferkodu.Text = nere & neye & dt
    End Sub
    Private Sub BtnSeferSorgula_Click(sender As Object, e As EventArgs) Handles BtnSeferSorgula.Click
        If TxtKalkıs.Text = "" Or TxtVaris.Text = "" Then
            MessageBox.Show("Lütfen Boş Alan Bırakmayınız.")
        Else
            read()
        End If
    End Sub
    Private Sub fiyatTxt_KeyPress(sender As Object, e As KeyPressEventArgs) Handles fiyatTxt.KeyPress
        If Not (Char.IsNumber(e.KeyChar) = True) And e.KeyChar <> ChrW(Keys.Back) Then
            e.Handled = True
        End If
    End Sub
End Class