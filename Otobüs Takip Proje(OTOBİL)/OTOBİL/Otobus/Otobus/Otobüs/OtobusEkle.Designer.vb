<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class OtobusEkle
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TxtCepTel = New System.Windows.Forms.TextBox()
        Me.CbTur = New System.Windows.Forms.ComboBox()
        Me.plakaTxt = New System.Windows.Forms.MaskedTextBox()
        Me.TxtAd = New System.Windows.Forms.MaskedTextBox()
        Me.BtnKaydet = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Button1.Location = New System.Drawing.Point(216, 10)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "Geri"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TxtCepTel)
        Me.GroupBox1.Controls.Add(Me.CbTur)
        Me.GroupBox1.Controls.Add(Me.plakaTxt)
        Me.GroupBox1.Controls.Add(Me.TxtAd)
        Me.GroupBox1.Controls.Add(Me.BtnKaydet)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(13, 39)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(278, 200)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        '
        'TxtCepTel
        '
        Me.TxtCepTel.Location = New System.Drawing.Point(153, 48)
        Me.TxtCepTel.Name = "TxtCepTel"
        Me.TxtCepTel.Size = New System.Drawing.Size(120, 21)
        Me.TxtCepTel.TabIndex = 1
        '
        'CbTur
        '
        Me.CbTur.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbTur.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.CbTur.FormattingEnabled = True
        Me.CbTur.Items.AddRange(New Object() {"2+1", "2+2"})
        Me.CbTur.Location = New System.Drawing.Point(151, 105)
        Me.CbTur.Name = "CbTur"
        Me.CbTur.Size = New System.Drawing.Size(122, 23)
        Me.CbTur.TabIndex = 3
        '
        'plakaTxt
        '
        Me.plakaTxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.plakaTxt.Location = New System.Drawing.Point(153, 76)
        Me.plakaTxt.Margin = New System.Windows.Forms.Padding(2)
        Me.plakaTxt.Mask = "00 ??? 999"
        Me.plakaTxt.Name = "plakaTxt"
        Me.plakaTxt.Size = New System.Drawing.Size(120, 21)
        Me.plakaTxt.TabIndex = 2
        '
        'TxtAd
        '
        Me.TxtAd.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.TxtAd.Location = New System.Drawing.Point(153, 18)
        Me.TxtAd.Margin = New System.Windows.Forms.Padding(2)
        Me.TxtAd.Name = "TxtAd"
        Me.TxtAd.Size = New System.Drawing.Size(120, 21)
        Me.TxtAd.TabIndex = 0
        '
        'BtnKaydet
        '
        Me.BtnKaydet.BackColor = System.Drawing.Color.Red
        Me.BtnKaydet.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.BtnKaydet.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.BtnKaydet.Location = New System.Drawing.Point(20, 144)
        Me.BtnKaydet.Name = "BtnKaydet"
        Me.BtnKaydet.Size = New System.Drawing.Size(235, 50)
        Me.BtnKaydet.TabIndex = 4
        Me.BtnKaydet.Text = "Kaydet"
        Me.BtnKaydet.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label4.Location = New System.Drawing.Point(17, 105)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(36, 15)
        Me.Label4.TabIndex = 66
        Me.Label4.Text = "Türü"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label3.Location = New System.Drawing.Point(17, 76)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(43, 15)
        Me.Label3.TabIndex = 66
        Me.Label3.Text = "Plaka"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label1.Location = New System.Drawing.Point(17, 47)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(84, 15)
        Me.Label1.TabIndex = 61
        Me.Label1.Text = "Cep Telefon"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label2.Location = New System.Drawing.Point(17, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 15)
        Me.Label2.TabIndex = 62
        Me.Label2.Text = "Şöför Ad"
        '
        'OtobusEkle
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(304, 248)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Button1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "OtobusEkle"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "OtobusEkle"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents BtnKaydet As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents plakaTxt As MaskedTextBox
    Friend WithEvents TxtAd As MaskedTextBox
    Friend WithEvents CbTur As ComboBox
    Friend WithEvents TxtCepTel As TextBox
End Class
