<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SeferEkle
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.fiyatTxt = New System.Windows.Forms.MaskedTextBox()
        Me.ekleBtn = New System.Windows.Forms.Button()
        Me.saatDt = New System.Windows.Forms.DateTimePicker()
        Me.seferkodu = New System.Windows.Forms.Label()
        Me.tarihDt = New System.Windows.Forms.DateTimePicker()
        Me.otobusCb = New System.Windows.Forms.ComboBox()
        Me.nereyeCb = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.neredenCb = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Lblotobusturu = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.fiyatTxt)
        Me.GroupBox1.Controls.Add(Me.ekleBtn)
        Me.GroupBox1.Controls.Add(Me.saatDt)
        Me.GroupBox1.Controls.Add(Me.seferkodu)
        Me.GroupBox1.Controls.Add(Me.tarihDt)
        Me.GroupBox1.Controls.Add(Me.otobusCb)
        Me.GroupBox1.Controls.Add(Me.nereyeCb)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.neredenCb)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 32)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(282, 337)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'fiyatTxt
        '
        Me.fiyatTxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.fiyatTxt.Location = New System.Drawing.Point(149, 236)
        Me.fiyatTxt.Margin = New System.Windows.Forms.Padding(2)
        Me.fiyatTxt.Name = "fiyatTxt"
        Me.fiyatTxt.Size = New System.Drawing.Size(92, 21)
        Me.fiyatTxt.TabIndex = 5
        '
        'ekleBtn
        '
        Me.ekleBtn.BackColor = System.Drawing.Color.Red
        Me.ekleBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.ekleBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ekleBtn.Location = New System.Drawing.Point(16, 259)
        Me.ekleBtn.Name = "ekleBtn"
        Me.ekleBtn.Size = New System.Drawing.Size(252, 69)
        Me.ekleBtn.TabIndex = 6
        Me.ekleBtn.Text = "Ekle"
        Me.ekleBtn.UseVisualStyleBackColor = False
        '
        'saatDt
        '
        Me.saatDt.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.saatDt.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.saatDt.Location = New System.Drawing.Point(149, 126)
        Me.saatDt.Name = "saatDt"
        Me.saatDt.Size = New System.Drawing.Size(121, 21)
        Me.saatDt.TabIndex = 3
        '
        'seferkodu
        '
        Me.seferkodu.AutoSize = True
        Me.seferkodu.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.seferkodu.Location = New System.Drawing.Point(149, 201)
        Me.seferkodu.Name = "seferkodu"
        Me.seferkodu.Size = New System.Drawing.Size(37, 15)
        Me.seferkodu.TabIndex = 52
        Me.seferkodu.Text = "------"
        '
        'tarihDt
        '
        Me.tarihDt.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.tarihDt.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.tarihDt.Location = New System.Drawing.Point(149, 101)
        Me.tarihDt.Name = "tarihDt"
        Me.tarihDt.Size = New System.Drawing.Size(121, 21)
        Me.tarihDt.TabIndex = 2
        Me.tarihDt.Value = New Date(2016, 12, 15, 0, 0, 0, 0)
        '
        'otobusCb
        '
        Me.otobusCb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.otobusCb.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.otobusCb.FormattingEnabled = True
        Me.otobusCb.Location = New System.Drawing.Point(149, 160)
        Me.otobusCb.Name = "otobusCb"
        Me.otobusCb.Size = New System.Drawing.Size(121, 23)
        Me.otobusCb.TabIndex = 4
        '
        'nereyeCb
        '
        Me.nereyeCb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.nereyeCb.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.nereyeCb.FormattingEnabled = True
        Me.nereyeCb.Location = New System.Drawing.Point(149, 68)
        Me.nereyeCb.Name = "nereyeCb"
        Me.nereyeCb.Size = New System.Drawing.Size(121, 23)
        Me.nereyeCb.TabIndex = 1
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label8.Location = New System.Drawing.Point(246, 237)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(23, 15)
        Me.Label8.TabIndex = 49
        Me.Label8.Text = "TL"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label6.Location = New System.Drawing.Point(15, 233)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(37, 15)
        Me.Label6.TabIndex = 49
        Me.Label6.Text = "Fiyat"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label7.Location = New System.Drawing.Point(15, 201)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(78, 15)
        Me.Label7.TabIndex = 49
        Me.Label7.Text = "Sefer Kodu"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label4.Location = New System.Drawing.Point(13, 165)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(52, 15)
        Me.Label4.TabIndex = 49
        Me.Label4.Text = "Otobus"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label3.Location = New System.Drawing.Point(13, 132)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(36, 15)
        Me.Label3.TabIndex = 49
        Me.Label3.Text = "Saat"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label2.Location = New System.Drawing.Point(13, 99)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 15)
        Me.Label2.TabIndex = 49
        Me.Label2.Text = "Tarih "
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label1.Location = New System.Drawing.Point(13, 69)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(52, 15)
        Me.Label1.TabIndex = 49
        Me.Label1.Text = "Nereye"
        '
        'neredenCb
        '
        Me.neredenCb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.neredenCb.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.neredenCb.FormattingEnabled = True
        Me.neredenCb.Location = New System.Drawing.Point(149, 41)
        Me.neredenCb.Name = "neredenCb"
        Me.neredenCb.Size = New System.Drawing.Size(121, 23)
        Me.neredenCb.TabIndex = 0
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label5.Location = New System.Drawing.Point(13, 42)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(62, 15)
        Me.Label5.TabIndex = 49
        Me.Label5.Text = "Nereden"
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Button1.Location = New System.Drawing.Point(213, 3)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 32)
        Me.Button1.TabIndex = 7
        Me.Button1.Text = "Geri"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Lblotobusturu
        '
        Me.Lblotobusturu.AutoSize = True
        Me.Lblotobusturu.Enabled = False
        Me.Lblotobusturu.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Lblotobusturu.Location = New System.Drawing.Point(143, -14)
        Me.Lblotobusturu.Name = "Lblotobusturu"
        Me.Lblotobusturu.Size = New System.Drawing.Size(22, 15)
        Me.Lblotobusturu.TabIndex = 57
        Me.Lblotobusturu.Text = "---"
        Me.Lblotobusturu.Visible = False
        '
        'SeferEkle
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(306, 365)
        Me.Controls.Add(Me.Lblotobusturu)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "SeferEkle"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Sefer Ekle"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Button1 As Button
    Friend WithEvents nereyeCb As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents neredenCb As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents tarihDt As DateTimePicker
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents otobusCb As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents seferkodu As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents saatDt As DateTimePicker
    Friend WithEvents ekleBtn As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Lblotobusturu As Label
    Friend WithEvents fiyatTxt As MaskedTextBox
End Class
