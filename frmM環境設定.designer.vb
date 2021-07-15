<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmM環境設定
    'Inherits System.Windows.Forms.Form
    Inherits frmベース

    'フォームがコンポーネントの一覧をクリーンアップするために dispose をオーバーライドします。
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

    'Windows フォーム デザイナーで必要です。
    Private components As System.ComponentModel.IContainer

    'メモ: 以下のプロシージャは Windows フォーム デザイナーで必要です。
    'Windows フォーム デザイナーを使用して変更できます。  
    'コード エディターを使って変更しないでください。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.txtFAX番号 = New System.Windows.Forms.TextBox()
        Me.txt電話番号 = New System.Windows.Forms.TextBox()
        Me.btn取得 = New System.Windows.Forms.Button()
        Me.txt住所 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt郵便番号 = New System.Windows.Forms.TextBox()
        Me.txt会社名 = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtフリガナ = New System.Windows.Forms.TextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.txt代表者 = New System.Windows.Forms.TextBox()
        Me.cmb口座区分 = New System.Windows.Forms.ComboBox()
        Me.txt口座番号 = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txt支店名 = New System.Windows.Forms.TextBox()
        Me.txt銀行名 = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("MS UI Gothic", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label18.Location = New System.Drawing.Point(625, 60)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(85, 19)
        Me.Label18.TabIndex = 6
        Me.Label18.Text = "FAX番号"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("MS UI Gothic", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label17.Location = New System.Drawing.Point(622, 29)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(89, 19)
        Me.Label17.TabIndex = 4
        Me.Label17.Text = "電話番号"
        '
        'txtFAX番号
        '
        Me.txtFAX番号.Location = New System.Drawing.Point(712, 57)
        Me.txtFAX番号.Name = "txtFAX番号"
        Me.txtFAX番号.Size = New System.Drawing.Size(182, 26)
        Me.txtFAX番号.TabIndex = 7
        '
        'txt電話番号
        '
        Me.txt電話番号.Location = New System.Drawing.Point(712, 25)
        Me.txt電話番号.Name = "txt電話番号"
        Me.txt電話番号.Size = New System.Drawing.Size(182, 26)
        Me.txt電話番号.TabIndex = 5
        '
        'btn取得
        '
        Me.btn取得.Location = New System.Drawing.Point(230, 89)
        Me.btn取得.Name = "btn取得"
        Me.btn取得.Size = New System.Drawing.Size(27, 25)
        Me.btn取得.TabIndex = 10
        Me.btn取得.Text = "〒"
        Me.btn取得.UseVisualStyleBackColor = True
        '
        'txt住所
        '
        Me.txt住所.ImeMode = System.Windows.Forms.ImeMode.[On]
        Me.txt住所.Location = New System.Drawing.Point(258, 89)
        Me.txt住所.Name = "txt住所"
        Me.txt住所.Size = New System.Drawing.Size(634, 26)
        Me.txt住所.TabIndex = 11
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("MS UI Gothic", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label4.Location = New System.Drawing.Point(43, 93)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(89, 19)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "郵便番号"
        '
        'txt郵便番号
        '
        Me.txt郵便番号.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.txt郵便番号.Location = New System.Drawing.Point(133, 89)
        Me.txt郵便番号.Name = "txt郵便番号"
        Me.txt郵便番号.Size = New System.Drawing.Size(96, 26)
        Me.txt郵便番号.TabIndex = 9
        '
        'txt会社名
        '
        Me.txt会社名.Location = New System.Drawing.Point(133, 57)
        Me.txt会社名.Name = "txt会社名"
        Me.txt会社名.Size = New System.Drawing.Size(456, 26)
        Me.txt会社名.TabIndex = 3
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("MS UI Gothic", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label5.Location = New System.Drawing.Point(63, 60)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(69, 19)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "会社名"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("MS UI Gothic", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label6.Location = New System.Drawing.Point(65, 29)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(67, 19)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "フリガナ"
        '
        'txtフリガナ
        '
        Me.txtフリガナ.Location = New System.Drawing.Point(133, 25)
        Me.txtフリガナ.Name = "txtフリガナ"
        Me.txtフリガナ.Size = New System.Drawing.Size(456, 26)
        Me.txtフリガナ.TabIndex = 1
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("MS UI Gothic", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label20.Location = New System.Drawing.Point(63, 124)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(69, 19)
        Me.Label20.TabIndex = 12
        Me.Label20.Text = "代表者"
        '
        'txt代表者
        '
        Me.txt代表者.ImeMode = System.Windows.Forms.ImeMode.[On]
        Me.txt代表者.Location = New System.Drawing.Point(133, 120)
        Me.txt代表者.Name = "txt代表者"
        Me.txt代表者.Size = New System.Drawing.Size(182, 26)
        Me.txt代表者.TabIndex = 13
        '
        'cmb口座区分
        '
        Me.cmb口座区分.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmb口座区分.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmb口座区分.Font = New System.Drawing.Font("MS UI Gothic", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.cmb口座区分.FormattingEnabled = True
        Me.cmb口座区分.Location = New System.Drawing.Point(712, 154)
        Me.cmb口座区分.Name = "cmb口座区分"
        Me.cmb口座区分.Size = New System.Drawing.Size(62, 27)
        Me.cmb口座区分.TabIndex = 19
        '
        'txt口座番号
        '
        Me.txt口座番号.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.txt口座番号.Location = New System.Drawing.Point(773, 154)
        Me.txt口座番号.Name = "txt口座番号"
        Me.txt口座番号.Size = New System.Drawing.Size(119, 26)
        Me.txt口座番号.TabIndex = 20
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("MS UI Gothic", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label13.Location = New System.Drawing.Point(622, 157)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(89, 19)
        Me.Label13.TabIndex = 18
        Me.Label13.Text = "口座番号"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("MS UI Gothic", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label14.Location = New System.Drawing.Point(355, 157)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(49, 19)
        Me.Label14.TabIndex = 16
        Me.Label14.Text = "支店"
        '
        'txt支店名
        '
        Me.txt支店名.ImeMode = System.Windows.Forms.ImeMode.[On]
        Me.txt支店名.Location = New System.Drawing.Point(408, 154)
        Me.txt支店名.Name = "txt支店名"
        Me.txt支店名.Size = New System.Drawing.Size(182, 26)
        Me.txt支店名.TabIndex = 17
        '
        'txt銀行名
        '
        Me.txt銀行名.ImeMode = System.Windows.Forms.ImeMode.[On]
        Me.txt銀行名.Location = New System.Drawing.Point(133, 154)
        Me.txt銀行名.Name = "txt銀行名"
        Me.txt銀行名.Size = New System.Drawing.Size(182, 26)
        Me.txt銀行名.TabIndex = 15
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("MS UI Gothic", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label15.Location = New System.Drawing.Point(82, 157)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(49, 19)
        Me.Label15.TabIndex = 14
        Me.Label15.Text = "銀行"
        '
        'frmM環境設定
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1183, 762)
        Me.Controls.Add(Me.cmb口座区分)
        Me.Controls.Add(Me.txt口座番号)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.txt支店名)
        Me.Controls.Add(Me.txt銀行名)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.txt代表者)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.txtFAX番号)
        Me.Controls.Add(Me.txt電話番号)
        Me.Controls.Add(Me.btn取得)
        Me.Controls.Add(Me.txt住所)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txt郵便番号)
        Me.Controls.Add(Me.txt会社名)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtフリガナ)
        Me.Margin = New System.Windows.Forms.Padding(8)
        Me.Name = "frmM環境設定"
        Me.Text = "環境設定"
        Me.Controls.SetChildIndex(Me.txtフリガナ, 0)
        Me.Controls.SetChildIndex(Me.Label6, 0)
        Me.Controls.SetChildIndex(Me.Label5, 0)
        Me.Controls.SetChildIndex(Me.txt会社名, 0)
        Me.Controls.SetChildIndex(Me.txt郵便番号, 0)
        Me.Controls.SetChildIndex(Me.Label4, 0)
        Me.Controls.SetChildIndex(Me.txt住所, 0)
        Me.Controls.SetChildIndex(Me.btn取得, 0)
        Me.Controls.SetChildIndex(Me.txt電話番号, 0)
        Me.Controls.SetChildIndex(Me.txtFAX番号, 0)
        Me.Controls.SetChildIndex(Me.Label17, 0)
        Me.Controls.SetChildIndex(Me.Label18, 0)
        Me.Controls.SetChildIndex(Me.txt代表者, 0)
        Me.Controls.SetChildIndex(Me.Label20, 0)
        Me.Controls.SetChildIndex(Me.Label15, 0)
        Me.Controls.SetChildIndex(Me.txt銀行名, 0)
        Me.Controls.SetChildIndex(Me.txt支店名, 0)
        Me.Controls.SetChildIndex(Me.Label14, 0)
        Me.Controls.SetChildIndex(Me.Label13, 0)
        Me.Controls.SetChildIndex(Me.txt口座番号, 0)
        Me.Controls.SetChildIndex(Me.cmb口座区分, 0)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents txtFAX番号 As System.Windows.Forms.TextBox
    Friend WithEvents txt電話番号 As System.Windows.Forms.TextBox
    Friend WithEvents btn取得 As System.Windows.Forms.Button
    Friend WithEvents txt住所 As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txt郵便番号 As System.Windows.Forms.TextBox
    Friend WithEvents txt会社名 As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtフリガナ As System.Windows.Forms.TextBox
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents txt代表者 As System.Windows.Forms.TextBox
    Friend WithEvents cmb口座区分 As System.Windows.Forms.ComboBox
    Friend WithEvents txt口座番号 As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents txt支店名 As System.Windows.Forms.TextBox
    Friend WithEvents txt銀行名 As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
End Class
