<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class sfrmExcel返済
    ' Inherits System.Windows.Forms.Form
    Inherits sfrmベース
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
        Me.txt銘柄コード = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt銘柄名 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt決済総株数 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt価格 = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txt決済日付 = New System.Windows.Forms.TextBox()
        Me.dgv返済玉 = New System.Windows.Forms.DataGridView()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txt返済玉取引種別 = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txt返済玉銘柄名 = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txt返済玉銘柄コード = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txt返済玉入力ID = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txt返済玉ID = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txt返済玉取得日 = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txt返済玉価格 = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txt返済株数 = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txt概算損益 = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.txt返済ID = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.txt返済後残株数 = New System.Windows.Forms.TextBox()
        Me.cmb現況 = New System.Windows.Forms.ComboBox()
        Me.Label18 = New System.Windows.Forms.Label()
        CType(Me.dgv返済玉, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txt銘柄コード
        '
        Me.txt銘柄コード.Location = New System.Drawing.Point(767, 38)
        Me.txt銘柄コード.Name = "txt銘柄コード"
        Me.txt銘柄コード.Size = New System.Drawing.Size(146, 26)
        Me.txt銘柄コード.TabIndex = 0
        Me.txt銘柄コード.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(671, 41)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(90, 19)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "銘柄コード"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(690, 91)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(66, 19)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "銘柄名"
        '
        'txt銘柄名
        '
        Me.txt銘柄名.Location = New System.Drawing.Point(767, 84)
        Me.txt銘柄名.Name = "txt銘柄名"
        Me.txt銘柄名.Size = New System.Drawing.Size(146, 26)
        Me.txt銘柄名.TabIndex = 2
        Me.txt銘柄名.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(661, 136)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(104, 19)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "決済総株数"
        '
        'txt決済総株数
        '
        Me.txt決済総株数.Location = New System.Drawing.Point(767, 132)
        Me.txt決済総株数.Name = "txt決済総株数"
        Me.txt決済総株数.Size = New System.Drawing.Size(146, 26)
        Me.txt決済総株数.TabIndex = 4
        Me.txt決済総株数.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(700, 195)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(47, 19)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "価格"
        '
        'txt価格
        '
        Me.txt価格.Location = New System.Drawing.Point(767, 188)
        Me.txt価格.Name = "txt価格"
        Me.txt価格.Size = New System.Drawing.Size(146, 26)
        Me.txt価格.TabIndex = 6
        Me.txt価格.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(671, 245)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(85, 19)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "決済日付"
        '
        'txt決済日付
        '
        Me.txt決済日付.Location = New System.Drawing.Point(767, 238)
        Me.txt決済日付.Name = "txt決済日付"
        Me.txt決済日付.Size = New System.Drawing.Size(146, 26)
        Me.txt決済日付.TabIndex = 8
        Me.txt決済日付.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'dgv返済玉
        '
        Me.dgv返済玉.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv返済玉.Location = New System.Drawing.Point(12, 291)
        Me.dgv返済玉.Name = "dgv返済玉"
        Me.dgv返済玉.RowHeadersWidth = 51
        Me.dgv返済玉.RowTemplate.Height = 21
        Me.dgv返済玉.Size = New System.Drawing.Size(901, 138)
        Me.dgv返済玉.TabIndex = 10
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(14, 259)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(197, 19)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "返済対象建玉をえらんで"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(21, 141)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(165, 19)
        Me.Label7.TabIndex = 21
        Me.Label7.Text = "txt返済玉取引種別"
        '
        'txt返済玉取引種別
        '
        Me.txt返済玉取引種別.Location = New System.Drawing.Point(190, 134)
        Me.txt返済玉取引種別.Name = "txt返済玉取引種別"
        Me.txt返済玉取引種別.Size = New System.Drawing.Size(146, 26)
        Me.txt返済玉取引種別.TabIndex = 20
        Me.txt返済玉取引種別.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(40, 115)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(146, 19)
        Me.Label8.TabIndex = 19
        Me.Label8.Text = "txt返済玉銘柄名"
        '
        'txt返済玉銘柄名
        '
        Me.txt返済玉銘柄名.Location = New System.Drawing.Point(190, 109)
        Me.txt返済玉銘柄名.Name = "txt返済玉銘柄名"
        Me.txt返済玉銘柄名.Size = New System.Drawing.Size(146, 26)
        Me.txt返済玉銘柄名.TabIndex = 18
        Me.txt返済玉銘柄名.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(14, 88)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(170, 19)
        Me.Label9.TabIndex = 17
        Me.Label9.Text = "txt返済玉銘柄コード"
        '
        'txt返済玉銘柄コード
        '
        Me.txt返済玉銘柄コード.Location = New System.Drawing.Point(190, 85)
        Me.txt返済玉銘柄コード.Name = "txt返済玉銘柄コード"
        Me.txt返済玉銘柄コード.Size = New System.Drawing.Size(146, 26)
        Me.txt返済玉銘柄コード.TabIndex = 16
        Me.txt返済玉銘柄コード.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(40, 56)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(144, 19)
        Me.Label10.TabIndex = 15
        Me.Label10.Text = "txt返済玉入力ID"
        '
        'txt返済玉入力ID
        '
        Me.txt返済玉入力ID.Location = New System.Drawing.Point(190, 53)
        Me.txt返済玉入力ID.Name = "txt返済玉入力ID"
        Me.txt返済玉入力ID.Size = New System.Drawing.Size(146, 26)
        Me.txt返済玉入力ID.TabIndex = 14
        Me.txt返済玉入力ID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(78, 23)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(106, 19)
        Me.Label11.TabIndex = 13
        Me.Label11.Text = "txt返済玉ID"
        '
        'txt返済玉ID
        '
        Me.txt返済玉ID.Location = New System.Drawing.Point(190, 23)
        Me.txt返済玉ID.Name = "txt返済玉ID"
        Me.txt返済玉ID.Size = New System.Drawing.Size(146, 26)
        Me.txt返済玉ID.TabIndex = 12
        Me.txt返済玉ID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(38, 220)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(146, 19)
        Me.Label12.TabIndex = 27
        Me.Label12.Text = "txt返済玉取得日"
        '
        'txt返済玉取得日
        '
        Me.txt返済玉取得日.Location = New System.Drawing.Point(190, 213)
        Me.txt返済玉取得日.Name = "txt返済玉取得日"
        Me.txt返済玉取得日.Size = New System.Drawing.Size(146, 26)
        Me.txt返済玉取得日.TabIndex = 26
        Me.txt返済玉取得日.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(57, 195)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(127, 19)
        Me.Label13.TabIndex = 25
        Me.Label13.Text = "txt返済玉価格"
        '
        'txt返済玉価格
        '
        Me.txt返済玉価格.Location = New System.Drawing.Point(190, 188)
        Me.txt返済玉価格.Name = "txt返済玉価格"
        Me.txt返済玉価格.Size = New System.Drawing.Size(146, 26)
        Me.txt返済玉価格.TabIndex = 24
        Me.txt返済玉価格.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(38, 171)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(108, 19)
        Me.Label14.TabIndex = 23
        Me.Label14.Text = "txt返済株数"
        '
        'txt返済株数
        '
        Me.txt返済株数.Location = New System.Drawing.Point(190, 164)
        Me.txt返済株数.Name = "txt返済株数"
        Me.txt返済株数.Size = New System.Drawing.Size(146, 26)
        Me.txt返済株数.TabIndex = 22
        Me.txt返済株数.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(420, 75)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(85, 19)
        Me.Label15.TabIndex = 31
        Me.Label15.Text = "概算損益"
        '
        'txt概算損益
        '
        Me.txt概算損益.Location = New System.Drawing.Point(511, 68)
        Me.txt概算損益.Name = "txt概算損益"
        Me.txt概算損益.Size = New System.Drawing.Size(146, 26)
        Me.txt概算損益.TabIndex = 30
        Me.txt概算損益.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(441, 38)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(64, 19)
        Me.Label16.TabIndex = 29
        Me.Label16.Text = "返済ID"
        '
        'txt返済ID
        '
        Me.txt返済ID.Location = New System.Drawing.Point(511, 38)
        Me.txt返済ID.Name = "txt返済ID"
        Me.txt返済ID.Size = New System.Drawing.Size(146, 26)
        Me.txt返済ID.TabIndex = 28
        Me.txt返済ID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(382, 141)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(123, 19)
        Me.Label17.TabIndex = 33
        Me.Label17.Text = "返済後残株数"
        '
        'txt返済後残株数
        '
        Me.txt返済後残株数.Location = New System.Drawing.Point(511, 138)
        Me.txt返済後残株数.Name = "txt返済後残株数"
        Me.txt返済後残株数.Size = New System.Drawing.Size(146, 26)
        Me.txt返済後残株数.TabIndex = 32
        Me.txt返済後残株数.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'cmb現況
        '
        Me.cmb現況.FormattingEnabled = True
        Me.cmb現況.Items.AddRange(New Object() {"", "一部返済", "　現引"})
        Me.cmb現況.Location = New System.Drawing.Point(454, 212)
        Me.cmb現況.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.cmb現況.Name = "cmb現況"
        Me.cmb現況.Size = New System.Drawing.Size(91, 27)
        Me.cmb現況.TabIndex = 52
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(401, 219)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(47, 19)
        Me.Label18.TabIndex = 51
        Me.Label18.Text = "現況"
        '
        'sfrmExcel返済
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(946, 450)
        Me.Controls.Add(Me.cmb現況)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.txt返済後残株数)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.txt概算損益)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.txt返済ID)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.txt返済玉取得日)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.txt返済玉価格)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.txt返済株数)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txt返済玉取引種別)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txt返済玉銘柄名)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txt返済玉銘柄コード)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.txt返済玉入力ID)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.txt返済玉ID)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.dgv返済玉)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txt決済日付)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txt価格)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txt決済総株数)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txt銘柄名)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txt銘柄コード)
        Me.Name = "sfrmExcel返済"
        Me.Text = "sfrmExcel返済"
        CType(Me.dgv返済玉, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txt銘柄コード As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txt銘柄名 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txt決済総株数 As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txt価格 As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txt決済日付 As TextBox
    Friend WithEvents dgv返済玉 As DataGridView
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents txt返済玉取引種別 As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txt返済玉銘柄名 As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents txt返済玉銘柄コード As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents txt返済玉入力ID As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents txt返済玉ID As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents txt返済玉取得日 As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents txt返済玉価格 As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents txt返済株数 As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents txt概算損益 As TextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents txt返済ID As TextBox
    Friend WithEvents Label17 As Label
    Friend WithEvents txt返済後残株数 As TextBox
    Friend WithEvents cmb現況 As ComboBox
    Friend WithEvents Label18 As Label
End Class
