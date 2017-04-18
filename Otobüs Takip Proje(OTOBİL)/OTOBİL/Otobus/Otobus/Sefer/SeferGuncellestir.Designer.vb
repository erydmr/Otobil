<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SeferGuncellestir
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.seferLb = New System.Windows.Forms.ListBox()
        Me.geriBtn = New System.Windows.Forms.Button()
        Me.saatDt = New System.Windows.Forms.DateTimePicker()
        Me.seferkodu = New System.Windows.Forms.Label()
        Me.tarihDt = New System.Windows.Forms.DateTimePicker()
        Me.otobusCb = New System.Windows.Forms.ComboBox()
        Me.nereyeCb = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.neredenCb = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.guncelleBtn = New System.Windows.Forms.Button()
        Me.silBtn = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TxtVaris = New System.Windows.Forms.ComboBox()
        Me.TxtKalkıs = New System.Windows.Forms.ComboBox()
        Me.BtnSeferSorgula = New System.Windows.Forms.Button()
        Me.sefertarihDt = New System.Windows.Forms.DateTimePicker()
        Me.fiyatTxt = New System.Windows.Forms.MaskedTextBox()
        Me.CbOtobusTuru = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'seferLb
        '
        Me.seferLb.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.seferLb.FormattingEnabled = True
        Me.seferLb.ItemHeight = 15
        Me.seferLb.Location = New System.Drawing.Point(12, 12)
        Me.seferLb.Name = "seferLb"
        Me.seferLb.Size = New System.Drawing.Size(252, 379)
        Me.seferLb.TabIndex = 13
        '
        'geriBtn
        '
        Me.geriBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.geriBtn.Location = New System.Drawing.Point(470, 1)
        Me.geriBtn.Name = "geriBtn"
        Me.geriBtn.Size = New System.Drawing.Size(75, 31)
        Me.geriBtn.TabIndex = 12
        Me.geriBtn.Text = "Geri"
        Me.geriBtn.UseVisualStyleBackColor = True
        '
        'saatDt
        '
        Me.saatDt.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.saatDt.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.saatDt.Location = New System.Drawing.Point(425, 210)
        Me.saatDt.Name = "saatDt"
        Me.saatDt.Size = New System.Drawing.Size(121, 21)
        Me.saatDt.TabIndex = 7
        '
        'seferkodu
        '
        Me.seferkodu.AutoSize = True
        Me.seferkodu.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.seferkodu.Location = New System.Drawing.Point(425, 303)
        Me.seferkodu.Name = "seferkodu"
        Me.seferkodu.Size = New System.Drawing.Size(37, 15)
        Me.seferkodu.TabIndex = 76
        Me.seferkodu.Text = "------"
        '
        'tarihDt
        '
        Me.tarihDt.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.tarihDt.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.tarihDt.Location = New System.Drawing.Point(425, 183)
        Me.tarihDt.Name = "tarihDt"
        Me.tarihDt.Size = New System.Drawing.Size(121, 21)
        Me.tarihDt.TabIndex = 6
        Me.tarihDt.Value = New Date(2016, 12, 15, 0, 0, 0, 0)
        '
        'otobusCb
        '
        Me.otobusCb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.otobusCb.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.otobusCb.FormattingEnabled = True
        Me.otobusCb.Location = New System.Drawing.Point(425, 244)
        Me.otobusCb.Name = "otobusCb"
        Me.otobusCb.Size = New System.Drawing.Size(121, 23)
        Me.otobusCb.TabIndex = 8
        '
        'nereyeCb
        '
        Me.nereyeCb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.nereyeCb.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.nereyeCb.FormattingEnabled = True
        Me.nereyeCb.Location = New System.Drawing.Point(425, 152)
        Me.nereyeCb.Name = "nereyeCb"
        Me.nereyeCb.Size = New System.Drawing.Size(121, 23)
        Me.nereyeCb.TabIndex = 5
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label7.Location = New System.Drawing.Point(288, 304)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(78, 15)
        Me.Label7.TabIndex = 66
        Me.Label7.Text = "Sefer Kodu"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label4.Location = New System.Drawing.Point(289, 249)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(52, 15)
        Me.Label4.TabIndex = 67
        Me.Label4.Text = "Otobus"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label3.Location = New System.Drawing.Point(289, 216)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(36, 15)
        Me.Label3.TabIndex = 68
        Me.Label3.Text = "Saat"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label2.Location = New System.Drawing.Point(289, 183)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 15)
        Me.Label2.TabIndex = 69
        Me.Label2.Text = "Tarih "
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label1.Location = New System.Drawing.Point(289, 153)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(52, 15)
        Me.Label1.TabIndex = 70
        Me.Label1.Text = "Nereye"
        '
        'neredenCb
        '
        Me.neredenCb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.neredenCb.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.neredenCb.FormattingEnabled = True
        Me.neredenCb.Location = New System.Drawing.Point(425, 125)
        Me.neredenCb.Name = "neredenCb"
        Me.neredenCb.Size = New System.Drawing.Size(121, 23)
        Me.neredenCb.TabIndex = 4
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label5.Location = New System.Drawing.Point(289, 126)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(62, 15)
        Me.Label5.TabIndex = 71
        Me.Label5.Text = "Nereden"
        '
        'guncelleBtn
        '
        Me.guncelleBtn.BackColor = System.Drawing.Color.Red
        Me.guncelleBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.guncelleBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.guncelleBtn.Location = New System.Drawing.Point(282, 362)
        Me.guncelleBtn.Name = "guncelleBtn"
        Me.guncelleBtn.Size = New System.Drawing.Size(85, 38)
        Me.guncelleBtn.TabIndex = 10
        Me.guncelleBtn.Text = "Güncelle"
        Me.guncelleBtn.UseVisualStyleBackColor = False
        '
        'silBtn
        '
        Me.silBtn.BackColor = System.Drawing.Color.Red
        Me.silBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.silBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.silBtn.Location = New System.Drawing.Point(432, 362)
        Me.silBtn.Name = "silBtn"
        Me.silBtn.Size = New System.Drawing.Size(85, 38)
        Me.silBtn.TabIndex = 11
        Me.silBtn.Text = "Sil"
        Me.silBtn.UseVisualStyleBackColor = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label8.Location = New System.Drawing.Point(522, 332)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(23, 15)
        Me.Label8.TabIndex = 80
        Me.Label8.Text = "TL"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label6.Location = New System.Drawing.Point(291, 333)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(37, 15)
        Me.Label6.TabIndex = 81
        Me.Label6.Text = "Fiyat"
        '
        'TxtVaris
        '
        Me.TxtVaris.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.TxtVaris.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.TxtVaris.FormattingEnabled = True
        Me.TxtVaris.Location = New System.Drawing.Point(424, 37)
        Me.TxtVaris.Name = "TxtVaris"
        Me.TxtVaris.Size = New System.Drawing.Size(121, 23)
        Me.TxtVaris.TabIndex = 1
        '
        'TxtKalkıs
        '
        Me.TxtKalkıs.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.TxtKalkıs.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.TxtKalkıs.FormattingEnabled = True
        Me.TxtKalkıs.Location = New System.Drawing.Point(292, 37)
        Me.TxtKalkıs.Name = "TxtKalkıs"
        Me.TxtKalkıs.Size = New System.Drawing.Size(121, 23)
        Me.TxtKalkıs.TabIndex = 0
        '
        'BtnSeferSorgula
        '
        Me.BtnSeferSorgula.BackColor = System.Drawing.Color.Red
        Me.BtnSeferSorgula.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.BtnSeferSorgula.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BtnSeferSorgula.Location = New System.Drawing.Point(446, 66)
        Me.BtnSeferSorgula.Name = "BtnSeferSorgula"
        Me.BtnSeferSorgula.Size = New System.Drawing.Size(99, 43)
        Me.BtnSeferSorgula.TabIndex = 3
        Me.BtnSeferSorgula.Text = "Sefer Sorgula"
        Me.BtnSeferSorgula.UseVisualStyleBackColor = False
        '
        'sefertarihDt
        '
        Me.sefertarihDt.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.sefertarihDt.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.sefertarihDt.Location = New System.Drawing.Point(294, 76)
        Me.sefertarihDt.MinDate = New Date(2016, 12, 3, 0, 0, 0, 0)
        Me.sefertarihDt.Name = "sefertarihDt"
        Me.sefertarihDt.Size = New System.Drawing.Size(121, 21)
        Me.sefertarihDt.TabIndex = 2
        Me.sefertarihDt.Value = New Date(2016, 12, 3, 0, 0, 0, 0)
        '
        'fiyatTxt
        '
        Me.fiyatTxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.fiyatTxt.Location = New System.Drawing.Point(426, 333)
        Me.fiyatTxt.Margin = New System.Windows.Forms.Padding(2)
        Me.fiyatTxt.Name = "fiyatTxt"
        Me.fiyatTxt.Size = New System.Drawing.Size(91, 21)
        Me.fiyatTxt.TabIndex = 9
        '
        'CbOtobusTuru
        '
        Me.CbOtobusTuru.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbOtobusTuru.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.CbOtobusTuru.FormattingEnabled = True
        Me.CbOtobusTuru.Items.AddRange(New Object() {"2+1", "2+2"})
        Me.CbOtobusTuru.Location = New System.Drawing.Point(424, 273)
        Me.CbOtobusTuru.Name = "CbOtobusTuru"
        Me.CbOtobusTuru.Size = New System.Drawing.Size(121, 23)
        Me.CbOtobusTuru.TabIndex = 82
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label9.Location = New System.Drawing.Point(288, 274)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(85, 15)
        Me.Label9.TabIndex = 83
        Me.Label9.Text = "Otobus Türü"
        '
        'SeferGuncellestir
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(562, 415)
        Me.Controls.Add(Me.CbOtobusTuru)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.fiyatTxt)
        Me.Controls.Add(Me.TxtVaris)
        Me.Controls.Add(Me.TxtKalkıs)
        Me.Controls.Add(Me.BtnSeferSorgula)
        Me.Controls.Add(Me.sefertarihDt)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.silBtn)
        Me.Controls.Add(Me.guncelleBtn)
        Me.Controls.Add(Me.saatDt)
        Me.Controls.Add(Me.seferkodu)
        Me.Controls.Add(Me.tarihDt)
        Me.Controls.Add(Me.otobusCb)
        Me.Controls.Add(Me.nereyeCb)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.neredenCb)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.geriBtn)
        Me.Controls.Add(Me.seferLb)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "SeferGuncellestir"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Sefer Güncelle"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents seferLb As ListBox
    Friend WithEvents geriBtn As Button
    Friend WithEvents saatDt As DateTimePicker
    Friend WithEvents seferkodu As Label
    Friend WithEvents tarihDt As DateTimePicker
    Friend WithEvents otobusCb As ComboBox
    Friend WithEvents nereyeCb As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents neredenCb As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents guncelleBtn As Button
    Friend WithEvents silBtn As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents TxtVaris As ComboBox
    Friend WithEvents TxtKalkıs As ComboBox
    Friend WithEvents BtnSeferSorgula As Button
    Friend WithEvents sefertarihDt As DateTimePicker
    Friend WithEvents fiyatTxt As MaskedTextBox
    Friend WithEvents CbOtobusTuru As ComboBox
    Friend WithEvents Label9 As Label
End Class
