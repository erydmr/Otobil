Imports MySql.Data
Imports MySql.Data.MySqlClient
Public Class OtobusEkle
    Dim oku As MySqlDataReader
    Dim MySqlConn As New MySqlConnection
    Dim komut As New MySqlCommand
    Sub temizle()
        TxtAd.Text = ""
        TxtCepTel.Text = ""
        plakaTxt.Text = ""
        CbTur.Text = ""
    End Sub
    Sub kaydet()
        Try
            MySqlConn.Open()
            Dim komut As New MySqlCommand("insert into otobusler(plaka,sofor_adi,sofor_tel,otobus_turu) values('" & plakaTxt.Text.ToUpper & "','" & TxtAd.Text & "','" & TxtCepTel.Text & "','" & CbTur.Text & "')", MySqlConn)
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
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim x = New GecisForm
        x.Show()
        Me.Close()
    End Sub
    Private Sub BtnKaydet_Click(sender As Object, e As EventArgs) Handles BtnKaydet.Click
        If TxtAd.Text = "" Or TxtCepTel.Text = "" Or plakaTxt.Text = "" Or CbTur.Text = "" Then
            MessageBox.Show("Lütfen Boş Alan Bırakmayınız.")
        ElseIf TxtCepTel.TextLength <> 10 Then
            MessageBox.Show("Lütfen Cep Telefonunu (5XX)XXXXXXX(10 Karakter Şeklinde) Şeklinde Giriniz.")
        Else
            kaydet()
            temizle()
        End If
    End Sub


    Private Sub OtobusEkle_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MySqlConn.ConnectionString = "Server=sql11.freemysqlhosting.net;Database=sql11168214;Uid=sql11168214;Password=4Ci7FaFEF8;"
        komut.Connection = MySqlConn
    End Sub

    Private Sub TxtCepTel_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtCepTel.KeyPress
        If Not (Char.IsNumber(e.KeyChar) = True) And e.KeyChar <> ChrW(Keys.Back) Then
            e.Handled = True
        End If
    End Sub
End Class