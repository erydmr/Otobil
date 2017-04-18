<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UyeEkle
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.DTPDogumTarihi = New System.Windows.Forms.DateTimePicker()
        Me.BtnKaydet = New System.Windows.Forms.Button()
        Me.LblBakiye = New System.Windows.Forms.Label()
        Me.CbMeslek = New System.Windows.Forms.ComboBox()
        Me.CbOgrenimDurumu = New System.Windows.Forms.ComboBox()
        Me.CbIlce = New System.Windows.Forms.ComboBox()
        Me.CbIl = New System.Windows.Forms.ComboBox()
        Me.CbCinsiyet = New System.Windows.Forms.ComboBox()
        Me.TxtAdres = New System.Windows.Forms.TextBox()
        Me.TxtMail = New System.Windows.Forms.TextBox()
        Me.TxtAd = New System.Windows.Forms.TextBox()
        Me.TxtCepTel = New System.Windows.Forms.TextBox()
        Me.TxtSoyad = New System.Windows.Forms.TextBox()
        Me.TxtTc = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label1.Location = New System.Drawing.Point(9, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(82, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Cep Telefon"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label2.Location = New System.Drawing.Point(9, 49)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(25, 16)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Ad"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label3.Location = New System.Drawing.Point(9, 110)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(45, 16)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "E Mail"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label4.Location = New System.Drawing.Point(9, 170)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(55, 16)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Cinsiyet"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label5.Location = New System.Drawing.Point(9, 201)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(14, 16)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "İl"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label6.Location = New System.Drawing.Point(9, 232)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(29, 16)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "İlçe"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label7.Location = New System.Drawing.Point(6, 261)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(44, 16)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Adres"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label8.Location = New System.Drawing.Point(6, 363)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(89, 16)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "Doğum Tarihi"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label9.Location = New System.Drawing.Point(6, 390)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(108, 16)
        Me.Label9.TabIndex = 8
        Me.Label9.Text = "Öğrenim Durumu"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label10.Location = New System.Drawing.Point(9, 419)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(52, 16)
        Me.Label10.TabIndex = 9
        Me.Label10.Text = "Meslek"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.TxtTc)
        Me.GroupBox1.Controls.Add(Me.TxtSoyad)
        Me.GroupBox1.Controls.Add(Me.DTPDogumTarihi)
        Me.GroupBox1.Controls.Add(Me.BtnKaydet)
        Me.GroupBox1.Controls.Add(Me.LblBakiye)
        Me.GroupBox1.Controls.Add(Me.CbMeslek)
        Me.GroupBox1.Controls.Add(Me.CbOgrenimDurumu)
        Me.GroupBox1.Controls.Add(Me.CbIlce)
        Me.GroupBox1.Controls.Add(Me.CbIl)
        Me.GroupBox1.Controls.Add(Me.CbCinsiyet)
        Me.GroupBox1.Controls.Add(Me.TxtAdres)
        Me.GroupBox1.Controls.Add(Me.TxtMail)
        Me.GroupBox1.Controls.Add(Me.TxtAd)
        Me.GroupBox1.Controls.Add(Me.TxtCepTel)
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
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(414, 527)
        Me.GroupBox1.TabIndex = 10
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Üye Ekle"
        '
        'DTPDogumTarihi
        '
        Me.DTPDogumTarihi.Location = New System.Drawing.Point(145, 363)
        Me.DTPDogumTarihi.Name = "DTPDogumTarihi"
        Me.DTPDogumTarihi.Size = New System.Drawing.Size(200, 20)
        Me.DTPDogumTarihi.TabIndex = 56
        '
        'BtnKaydet
        '
        Me.BtnKaydet.BackColor = System.Drawing.Color.Red
        Me.BtnKaydet.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.BtnKaydet.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.BtnKaydet.Location = New System.Drawing.Point(135, 448)
        Me.BtnKaydet.Name = "BtnKaydet"
        Me.BtnKaydet.Size = New System.Drawing.Size(235, 50)
        Me.BtnKaydet.TabIndex = 11
        Me.BtnKaydet.Text = "Kaydet"
        Me.BtnKaydet.UseVisualStyleBackColor = False
        '
        'LblBakiye
        '
        Me.LblBakiye.AutoSize = True
        Me.LblBakiye.Location = New System.Drawing.Point(318, 23)
        Me.LblBakiye.Name = "LblBakiye"
        Me.LblBakiye.Size = New System.Drawing.Size(13, 13)
        Me.LblBakiye.TabIndex = 55
        Me.LblBakiye.Text = "0"
        '
        'CbMeslek
        '
        Me.CbMeslek.FormattingEnabled = True
        Me.CbMeslek.Items.AddRange(New Object() {"SUBAY,ASTSUBAY", "BİLİŞİM", "AKADEMISYEN", "BANKACI", "DOKTOR", "EZCAZI", "OGRETMEN", "EMEKLI", "FINANS UZMANI", "GAZETECI", "HUKUKCU", "HALKLA ILISKILER", "IS YERI SAHIBI", "ISCI", "MEMUR", "MIMAR", "MUHENDIS", "OGRENCI", "SANATCI", "SPORCU", "AVUKAT", "YONETICI", "DIGER"})
        Me.CbMeslek.Location = New System.Drawing.Point(145, 418)
        Me.CbMeslek.Name = "CbMeslek"
        Me.CbMeslek.Size = New System.Drawing.Size(121, 21)
        Me.CbMeslek.TabIndex = 51
        '
        'CbOgrenimDurumu
        '
        Me.CbOgrenimDurumu.FormattingEnabled = True
        Me.CbOgrenimDurumu.Items.AddRange(New Object() {"ILK OKUL", "ORTA OKUL", "LISE", "YUKSEK OKUL", "FAKULTE", "MASTER", "DOKTORA"})
        Me.CbOgrenimDurumu.Location = New System.Drawing.Point(145, 389)
        Me.CbOgrenimDurumu.Name = "CbOgrenimDurumu"
        Me.CbOgrenimDurumu.Size = New System.Drawing.Size(121, 21)
        Me.CbOgrenimDurumu.TabIndex = 50
        '
        'CbIlce
        '
        Me.CbIlce.FormattingEnabled = True
        Me.CbIlce.Location = New System.Drawing.Point(145, 231)
        Me.CbIlce.Name = "CbIlce"
        Me.CbIlce.Size = New System.Drawing.Size(121, 21)
        Me.CbIlce.TabIndex = 49
        '
        'CbIl
        '
        Me.CbIl.FormattingEnabled = True
        Me.CbIl.Location = New System.Drawing.Point(145, 200)
        Me.CbIl.Name = "CbIl"
        Me.CbIl.Size = New System.Drawing.Size(121, 21)
        Me.CbIl.TabIndex = 48
        '
        'CbCinsiyet
        '
        Me.CbCinsiyet.FormattingEnabled = True
        Me.CbCinsiyet.Items.AddRange(New Object() {"Bay", "Bayan"})
        Me.CbCinsiyet.Location = New System.Drawing.Point(145, 170)
        Me.CbCinsiyet.Name = "CbCinsiyet"
        Me.CbCinsiyet.Size = New System.Drawing.Size(84, 21)
        Me.CbCinsiyet.TabIndex = 47
        '
        'TxtAdres
        '
        Me.TxtAdres.Location = New System.Drawing.Point(145, 260)
        Me.TxtAdres.Multiline = True
        Me.TxtAdres.Name = "TxtAdres"
        Me.TxtAdres.Size = New System.Drawing.Size(235, 96)
        Me.TxtAdres.TabIndex = 14
        '
        'TxtMail
        '
        Me.TxtMail.Location = New System.Drawing.Point(145, 109)
        Me.TxtMail.Multiline = True
        Me.TxtMail.Name = "TxtMail"
        Me.TxtMail.Size = New System.Drawing.Size(103, 23)
        Me.TxtMail.TabIndex = 13
        '
        'TxtAd
        '
        Me.TxtAd.Location = New System.Drawing.Point(145, 48)
        Me.TxtAd.Multiline = True
        Me.TxtAd.Name = "TxtAd"
        Me.TxtAd.Size = New System.Drawing.Size(103, 23)
        Me.TxtAd.TabIndex = 12
        '
        'TxtCepTel
        '
        Me.TxtCepTel.Location = New System.Drawing.Point(145, 19)
        Me.TxtCepTel.Multiline = True
        Me.TxtCepTel.Name = "TxtCepTel"
        Me.TxtCepTel.Size = New System.Drawing.Size(103, 23)
        Me.TxtCepTel.TabIndex = 11
        '
        'TxtSoyad
        '
        Me.TxtSoyad.Location = New System.Drawing.Point(145, 77)
        Me.TxtSoyad.Multiline = True
        Me.TxtSoyad.Name = "TxtSoyad"
        Me.TxtSoyad.Size = New System.Drawing.Size(103, 23)
        Me.TxtSoyad.TabIndex = 58
        '
        'TxtTc
        '
        Me.TxtTc.Location = New System.Drawing.Point(145, 140)
        Me.TxtTc.Multiline = True
        Me.TxtTc.Name = "TxtTc"
        Me.TxtTc.Size = New System.Drawing.Size(103, 23)
        Me.TxtTc.TabIndex = 59
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label12.Location = New System.Drawing.Point(9, 78)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(48, 16)
        Me.Label12.TabIndex = 60
        Me.Label12.Text = "Soyad"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label13.Location = New System.Drawing.Point(8, 141)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(83, 16)
        Me.Label13.TabIndex = 61
        Me.Label13.Text = "Tc Kimlik No"
        '
        'UyeEkle
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(502, 540)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "UyeEkle"
        Me.Text = "UyeEkle"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents TxtAdres As TextBox
    Friend WithEvents TxtMail As TextBox
    Friend WithEvents TxtAd As TextBox
    Friend WithEvents TxtCepTel As TextBox
    Friend WithEvents BtnKaydet As Button
    Friend WithEvents LblBakiye As Label
    Friend WithEvents CbMeslek As ComboBox
    Friend WithEvents CbOgrenimDurumu As ComboBox
    Friend WithEvents CbIlce As ComboBox
    Friend WithEvents CbIl As ComboBox
    Friend WithEvents CbCinsiyet As ComboBox
    Friend WithEvents DTPDogumTarihi As DateTimePicker
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents TxtTc As TextBox
    Friend WithEvents TxtSoyad As TextBox
End Class
