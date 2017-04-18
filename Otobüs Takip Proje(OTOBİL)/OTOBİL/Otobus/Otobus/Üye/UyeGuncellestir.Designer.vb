<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UyeGuncellestir
    Inherits System.Windows.Forms.Form

    'Form, bileşen listesini temizlemeyi bırakmayı geçersiz kılar.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Windows Form Tasarımcısı tarafından gerektirilir
    Private components As System.ComponentModel.IContainer

    'NOT: Aşağıdaki yordam Windows Form Tasarımcısı için gereklidir
    'Windows Form Tasarımcısı kullanılarak değiştirilebilir.  
    'Kod düzenleyicisini kullanarak değiştirmeyin.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TxtTc = New System.Windows.Forms.TextBox()
        Me.TxtCepTel = New System.Windows.Forms.TextBox()
        Me.TxtAd = New System.Windows.Forms.MaskedTextBox()
        Me.TxtSoyad = New System.Windows.Forms.MaskedTextBox()
        Me.TxtMail = New System.Windows.Forms.MaskedTextBox()
        Me.BtnSil = New System.Windows.Forms.Button()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.LblSorguIcin = New System.Windows.Forms.Label()
        Me.BtnGeri = New System.Windows.Forms.Button()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.DTPDogumTarihi = New System.Windows.Forms.DateTimePicker()
        Me.BtnGuncelle = New System.Windows.Forms.Button()
        Me.LblBakiye = New System.Windows.Forms.Label()
        Me.CbMeslek = New System.Windows.Forms.ComboBox()
        Me.CbOgrenimDurumu = New System.Windows.Forms.ComboBox()
        Me.CbIlce = New System.Windows.Forms.ComboBox()
        Me.CbIl = New System.Windows.Forms.ComboBox()
        Me.CbCinsiyet = New System.Windows.Forms.ComboBox()
        Me.TxtAdres = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.LsUyeler = New System.Windows.Forms.ListBox()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TxtTc)
        Me.GroupBox1.Controls.Add(Me.TxtCepTel)
        Me.GroupBox1.Controls.Add(Me.TxtAd)
        Me.GroupBox1.Controls.Add(Me.TxtSoyad)
        Me.GroupBox1.Controls.Add(Me.TxtMail)
        Me.GroupBox1.Controls.Add(Me.BtnSil)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.LblSorguIcin)
        Me.GroupBox1.Controls.Add(Me.BtnGeri)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.DTPDogumTarihi)
        Me.GroupBox1.Controls.Add(Me.BtnGuncelle)
        Me.GroupBox1.Controls.Add(Me.LblBakiye)
        Me.GroupBox1.Controls.Add(Me.CbMeslek)
        Me.GroupBox1.Controls.Add(Me.CbOgrenimDurumu)
        Me.GroupBox1.Controls.Add(Me.CbIlce)
        Me.GroupBox1.Controls.Add(Me.CbIl)
        Me.GroupBox1.Controls.Add(Me.CbCinsiyet)
        Me.GroupBox1.Controls.Add(Me.TxtAdres)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Location = New System.Drawing.Point(366, -5)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(390, 524)
        Me.GroupBox1.TabIndex = 11
        Me.GroupBox1.TabStop = False
        '
        'TxtTc
        '
        Me.TxtTc.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.TxtTc.Location = New System.Drawing.Point(145, 139)
        Me.TxtTc.Multiline = True
        Me.TxtTc.Name = "TxtTc"
        Me.TxtTc.Size = New System.Drawing.Size(133, 21)
        Me.TxtTc.TabIndex = 4
        '
        'TxtCepTel
        '
        Me.TxtCepTel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.TxtCepTel.Location = New System.Drawing.Point(145, 20)
        Me.TxtCepTel.Multiline = True
        Me.TxtCepTel.Name = "TxtCepTel"
        Me.TxtCepTel.Size = New System.Drawing.Size(133, 21)
        Me.TxtCepTel.TabIndex = 0
        '
        'TxtAd
        '
        Me.TxtAd.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.TxtAd.Location = New System.Drawing.Point(145, 49)
        Me.TxtAd.Margin = New System.Windows.Forms.Padding(2)
        Me.TxtAd.Name = "TxtAd"
        Me.TxtAd.Size = New System.Drawing.Size(133, 21)
        Me.TxtAd.TabIndex = 1
        '
        'TxtSoyad
        '
        Me.TxtSoyad.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.TxtSoyad.Location = New System.Drawing.Point(145, 78)
        Me.TxtSoyad.Margin = New System.Windows.Forms.Padding(2)
        Me.TxtSoyad.Name = "TxtSoyad"
        Me.TxtSoyad.Size = New System.Drawing.Size(133, 21)
        Me.TxtSoyad.TabIndex = 2
        '
        'TxtMail
        '
        Me.TxtMail.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.TxtMail.Location = New System.Drawing.Point(145, 108)
        Me.TxtMail.Margin = New System.Windows.Forms.Padding(2)
        Me.TxtMail.Name = "TxtMail"
        Me.TxtMail.Size = New System.Drawing.Size(133, 21)
        Me.TxtMail.TabIndex = 3
        '
        'BtnSil
        '
        Me.BtnSil.BackColor = System.Drawing.Color.Red
        Me.BtnSil.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.BtnSil.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.BtnSil.Location = New System.Drawing.Point(12, 462)
        Me.BtnSil.Name = "BtnSil"
        Me.BtnSil.Size = New System.Drawing.Size(120, 50)
        Me.BtnSil.TabIndex = 13
        Me.BtnSil.Text = "Sil"
        Me.BtnSil.UseVisualStyleBackColor = False
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label13.Location = New System.Drawing.Point(8, 141)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(88, 15)
        Me.Label13.TabIndex = 61
        Me.Label13.Text = "Tc Kimlik No"
        '
        'LblSorguIcin
        '
        Me.LblSorguIcin.AutoSize = True
        Me.LblSorguIcin.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.LblSorguIcin.Location = New System.Drawing.Point(397, 239)
        Me.LblSorguIcin.Name = "LblSorguIcin"
        Me.LblSorguIcin.Size = New System.Drawing.Size(47, 15)
        Me.LblSorguIcin.TabIndex = 63
        Me.LblSorguIcin.Text = "--------"
        Me.LblSorguIcin.Visible = False
        '
        'BtnGeri
        '
        Me.BtnGeri.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.BtnGeri.Location = New System.Drawing.Point(331, 20)
        Me.BtnGeri.Name = "BtnGeri"
        Me.BtnGeri.Size = New System.Drawing.Size(47, 31)
        Me.BtnGeri.TabIndex = 14
        Me.BtnGeri.Text = "Geri"
        Me.BtnGeri.UseVisualStyleBackColor = True
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label12.Location = New System.Drawing.Point(9, 78)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(46, 15)
        Me.Label12.TabIndex = 60
        Me.Label12.Text = "Soyad"
        '
        'DTPDogumTarihi
        '
        Me.DTPDogumTarihi.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.DTPDogumTarihi.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTPDogumTarihi.Location = New System.Drawing.Point(145, 363)
        Me.DTPDogumTarihi.Name = "DTPDogumTarihi"
        Me.DTPDogumTarihi.Size = New System.Drawing.Size(133, 21)
        Me.DTPDogumTarihi.TabIndex = 9
        '
        'BtnGuncelle
        '
        Me.BtnGuncelle.BackColor = System.Drawing.Color.Red
        Me.BtnGuncelle.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.BtnGuncelle.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.BtnGuncelle.Location = New System.Drawing.Point(145, 462)
        Me.BtnGuncelle.Name = "BtnGuncelle"
        Me.BtnGuncelle.Size = New System.Drawing.Size(235, 50)
        Me.BtnGuncelle.TabIndex = 12
        Me.BtnGuncelle.Text = "Güncelle"
        Me.BtnGuncelle.UseVisualStyleBackColor = False
        '
        'LblBakiye
        '
        Me.LblBakiye.AutoSize = True
        Me.LblBakiye.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.LblBakiye.Location = New System.Drawing.Point(415, 226)
        Me.LblBakiye.Name = "LblBakiye"
        Me.LblBakiye.Size = New System.Drawing.Size(15, 15)
        Me.LblBakiye.TabIndex = 55
        Me.LblBakiye.Text = "0"
        Me.LblBakiye.Visible = False
        '
        'CbMeslek
        '
        Me.CbMeslek.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbMeslek.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.CbMeslek.FormattingEnabled = True
        Me.CbMeslek.Items.AddRange(New Object() {"SUBAY,ASTSUBAY", "BİLİŞİM", "AKADEMISYEN", "BANKACI", "DOKTOR", "EZCAZI", "OGRETMEN", "EMEKLI", "FINANS UZMANI", "GAZETECI", "HUKUKCU", "HALKLA ILISKILER", "IS YERI SAHIBI", "ISCI", "MEMUR", "MIMAR", "MUHENDIS", "OGRENCI", "SANATCI", "SPORCU", "AVUKAT", "YONETICI", "DIGER"})
        Me.CbMeslek.Location = New System.Drawing.Point(145, 418)
        Me.CbMeslek.Name = "CbMeslek"
        Me.CbMeslek.Size = New System.Drawing.Size(133, 23)
        Me.CbMeslek.TabIndex = 11
        '
        'CbOgrenimDurumu
        '
        Me.CbOgrenimDurumu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbOgrenimDurumu.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.CbOgrenimDurumu.FormattingEnabled = True
        Me.CbOgrenimDurumu.Items.AddRange(New Object() {"ILK OKUL", "ORTA OKUL", "LISE", "YUKSEK OKUL", "FAKULTE", "MASTER", "DOKTORA"})
        Me.CbOgrenimDurumu.Location = New System.Drawing.Point(145, 389)
        Me.CbOgrenimDurumu.Name = "CbOgrenimDurumu"
        Me.CbOgrenimDurumu.Size = New System.Drawing.Size(133, 23)
        Me.CbOgrenimDurumu.TabIndex = 10
        '
        'CbIlce
        '
        Me.CbIlce.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.CbIlce.FormattingEnabled = True
        Me.CbIlce.Location = New System.Drawing.Point(145, 231)
        Me.CbIlce.Name = "CbIlce"
        Me.CbIlce.Size = New System.Drawing.Size(133, 23)
        Me.CbIlce.TabIndex = 7
        '
        'CbIl
        '
        Me.CbIl.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.CbIl.FormattingEnabled = True
        Me.CbIl.Location = New System.Drawing.Point(145, 200)
        Me.CbIl.Name = "CbIl"
        Me.CbIl.Size = New System.Drawing.Size(133, 23)
        Me.CbIl.TabIndex = 6
        '
        'CbCinsiyet
        '
        Me.CbCinsiyet.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbCinsiyet.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.CbCinsiyet.FormattingEnabled = True
        Me.CbCinsiyet.Items.AddRange(New Object() {"Bay", "Bayan"})
        Me.CbCinsiyet.Location = New System.Drawing.Point(145, 170)
        Me.CbCinsiyet.Name = "CbCinsiyet"
        Me.CbCinsiyet.Size = New System.Drawing.Size(133, 23)
        Me.CbCinsiyet.TabIndex = 5
        '
        'TxtAdres
        '
        Me.TxtAdres.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.TxtAdres.Location = New System.Drawing.Point(145, 260)
        Me.TxtAdres.Multiline = True
        Me.TxtAdres.Name = "TxtAdres"
        Me.TxtAdres.Size = New System.Drawing.Size(235, 96)
        Me.TxtAdres.TabIndex = 8
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label9.Location = New System.Drawing.Point(6, 390)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(117, 15)
        Me.Label9.TabIndex = 8
        Me.Label9.Text = "Öğrenim Durumu"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label10.Location = New System.Drawing.Point(9, 419)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(53, 15)
        Me.Label10.TabIndex = 9
        Me.Label10.Text = "Meslek"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label1.Location = New System.Drawing.Point(9, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(84, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Cep Telefon"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label2.Location = New System.Drawing.Point(9, 49)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(23, 15)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Ad"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label8.Location = New System.Drawing.Point(6, 363)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(94, 15)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "Doğum Tarihi"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label3.Location = New System.Drawing.Point(9, 110)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(48, 15)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "E Mail"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label7.Location = New System.Drawing.Point(6, 261)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(43, 15)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Adres"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label4.Location = New System.Drawing.Point(9, 170)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(57, 15)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Cinsiyet"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label6.Location = New System.Drawing.Point(9, 232)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(30, 15)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "İlçe"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label5.Location = New System.Drawing.Point(9, 201)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(15, 15)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "İl"
        '
        'LsUyeler
        '
        Me.LsUyeler.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.LsUyeler.FormattingEnabled = True
        Me.LsUyeler.ItemHeight = 15
        Me.LsUyeler.Location = New System.Drawing.Point(4, 5)
        Me.LsUyeler.Name = "LsUyeler"
        Me.LsUyeler.Size = New System.Drawing.Size(357, 514)
        Me.LsUyeler.TabIndex = 15
        '
        'UyeGuncellestir
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(756, 531)
        Me.Controls.Add(Me.LsUyeler)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "UyeGuncellestir"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Üye Güncelleştir"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents DTPDogumTarihi As DateTimePicker
    Friend WithEvents BtnGuncelle As Button
    Friend WithEvents LblBakiye As Label
    Friend WithEvents CbMeslek As ComboBox
    Friend WithEvents CbOgrenimDurumu As ComboBox
    Friend WithEvents CbIlce As ComboBox
    Friend WithEvents CbIl As ComboBox
    Friend WithEvents CbCinsiyet As ComboBox
    Friend WithEvents TxtAdres As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents LsUyeler As ListBox
    Friend WithEvents LblSorguIcin As Label
    Friend WithEvents BtnGeri As Button
    Friend WithEvents BtnSil As Button
    Friend WithEvents TxtAd As MaskedTextBox
    Friend WithEvents TxtSoyad As MaskedTextBox
    Friend WithEvents TxtMail As MaskedTextBox
    Friend WithEvents TxtTc As TextBox
    Friend WithEvents TxtCepTel As TextBox
End Class
