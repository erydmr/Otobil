Imports MySql.Data.MySqlClient
Public Class OtobusNerede
    Dim oku As MySqlDataReader
    Dim MySqlConn As New MySqlConnection
    Dim komut As New MySqlCommand
    Public Sub getirOtobus()
        Try
            MySqlConn.Open()
            komut.CommandText = "Select plaka From koordinatlar"
            oku = komut.ExecuteReader()
            While oku.Read()
                otobusLb.Items.Add(oku(0).ToString())
            End While
            MySqlConn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            MySqlConn.Dispose()
        End Try
    End Sub
    Private Sub OtobusNerede_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MySqlConn.ConnectionString = "Server=sql11.freemysqlhosting.net;Database=sql11168214;Uid=sql11168214;Password=4Ci7FaFEF8;"
        komut.Connection = MySqlConn
        getirOtobus()
    End Sub
    Private Sub gitBtn_Click(sender As Object, e As EventArgs) Handles gitBtn.Click
        If otobusLb.SelectedIndex <> -1 Then
            System.Diagnostics.Process.Start("http://webpaketleri.xyz/tek.php?id=" + otobusLb.SelectedItem.ToString())
        End If
    End Sub
    Private Sub hepsiBtn_Click(sender As Object, e As EventArgs) Handles hepsiBtn.Click
        System.Diagnostics.Process.Start("http://webpaketleri.xyz/hepsi.php")
    End Sub

    Private Sub BtnGeri_Click(sender As Object, e As EventArgs) Handles BtnGeri.Click
        Dim x As New GecisForm
        x.Show()
        Me.Close()
    End Sub
End Class