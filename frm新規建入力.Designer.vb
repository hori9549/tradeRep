<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm新規建入力
    'Inherits System.Windows.Forms.Form
    Inherits sfrmベース
    'フォームがコンポーネントの一覧をクリーンアップするために dispose をオーバーライドします。
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

    'Windows フォーム デザイナーで必要です。
    Private components As System.ComponentModel.IContainer

    'メモ: 以下のプロシージャは Windows フォーム デザイナーで必要です。
    'Windows フォーム デザイナーを使用して変更できます。  
    'コード エディターを使って変更しないでください。
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.lbl取引種別 = New System.Windows.Forms.Label()
        Me.lblフリガナ = New System.Windows.Forms.Label()
        Me.lbl銘柄名 = New System.Windows.Forms.Label()
        Me.lbl取引区分 = New System.Windows.Forms.Label()
        Me.lbl株数 = New System.Windows.Forms.Label()
        Me.lbl取得単価 = New System.Windows.Forms.Label()
        Me.lbl残株数 = New System.Windows.Forms.Label()
        Me.lbl市場区分 = New System.Windows.Forms.Label()
        Me.lbl業種区分 = New System.Windows.Forms.Label()
        Me.txt取引種別 = New System.Windows.Forms.TextBox()
        Me.txt銘柄名 = New System.Windows.Forms.TextBox()
        Me.txt取引区分 = New System.Windows.Forms.TextBox()
        Me.txt取得株数 = New System.Windows.Forms.TextBox()
        Me.txt取得単価 = New System.Windows.Forms.TextBox()
        Me.txt残株数 = New System.Windows.Forms.TextBox()
        Me.txt市場区分 = New System.Windows.Forms.TextBox()
        Me.txt業種区分 = New System.Windows.Forms.TextBox()
        Me.rdo信新買い = New System.Windows.Forms.RadioButton()
        Me.rdo信返売り = New System.Windows.Forms.RadioButton()
        Me.dgv新規一覧 = New System.Windows.Forms.DataGridView()
        Me.btn閉じる = New System.Windows.Forms.Button()
        Me.grb性別 = New System.Windows.Forms.GroupBox()
        Me.rdoクリア = New System.Windows.Forms.RadioButton()
        Me.btn登録 = New System.Windows.Forms.Button()
        Me.txt入力ID = New System.Windows.Forms.TextBox()
        Me.lbl取引ID = New System.Windows.Forms.Label()
        Me.txt取得日付 = New System.Windows.Forms.TextBox()
        Me.lbl取得日付 = New System.Windows.Forms.Label()
        Me.btn続けて入力 = New System.Windows.Forms.Button()
        Me.btn銘柄名検索 = New System.Windows.Forms.Button()
        Me.txt銘柄コード = New System.Windows.Forms.TextBox()
        CType(Me.dgv新規一覧, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grb性別.SuspendLayout()
        Me.SuspendLayout()
        '
        'lbl取引種別
        '
        Me.lbl取引種別.AutoSize = True
        Me.lbl取引種別.Location = New System.Drawing.Point(66, 143)
        Me.lbl取引種別.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl取引種別.Name = "lbl取引種別"
        Me.lbl取引種別.Size = New System.Drawing.Size(89, 20)
        Me.lbl取引種別.TabIndex = 10
        Me.lbl取引種別.Text = "取引種別"
        '
        'lblフリガナ
        '
        Me.lblフリガナ.AutoSize = True
        Me.lblフリガナ.Location = New System.Drawing.Point(57, 83)
        Me.lblフリガナ.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblフリガナ.Name = "lblフリガナ"
        Me.lblフリガナ.Size = New System.Drawing.Size(93, 20)
        Me.lblフリガナ.TabIndex = 5
        Me.lblフリガナ.Text = "銘柄コード"
        '
        'lbl銘柄名
        '
        Me.lbl銘柄名.AutoSize = True
        Me.lbl銘柄名.Location = New System.Drawing.Point(509, 85)
        Me.lbl銘柄名.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl銘柄名.Name = "lbl銘柄名"
        Me.lbl銘柄名.Size = New System.Drawing.Size(69, 20)
        Me.lbl銘柄名.TabIndex = 8
        Me.lbl銘柄名.Text = "銘柄名"
        '
        'lbl取引区分
        '
        Me.lbl取引区分.AutoSize = True
        Me.lbl取引区分.Location = New System.Drawing.Point(66, 214)
        Me.lbl取引区分.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl取引区分.Name = "lbl取引区分"
        Me.lbl取引区分.Size = New System.Drawing.Size(89, 20)
        Me.lbl取引区分.TabIndex = 16
        Me.lbl取引区分.Text = "取引区分"
        '
        'lbl株数
        '
        Me.lbl株数.AutoSize = True
        Me.lbl株数.Location = New System.Drawing.Point(64, 265)
        Me.lbl株数.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl株数.Name = "lbl株数"
        Me.lbl株数.Size = New System.Drawing.Size(89, 20)
        Me.lbl株数.TabIndex = 18
        Me.lbl株数.Text = "取得株数" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'lbl取得単価
        '
        Me.lbl取得単価.AutoSize = True
        Me.lbl取得単価.Location = New System.Drawing.Point(64, 304)
        Me.lbl取得単価.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl取得単価.Name = "lbl取得単価"
        Me.lbl取得単価.Size = New System.Drawing.Size(89, 20)
        Me.lbl取得単価.TabIndex = 20
        Me.lbl取得単価.Text = "取得単価"
        '
        'lbl残株数
        '
        Me.lbl残株数.AutoSize = True
        Me.lbl残株数.Location = New System.Drawing.Point(475, 264)
        Me.lbl残株数.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl残株数.Name = "lbl残株数"
        Me.lbl残株数.Size = New System.Drawing.Size(69, 20)
        Me.lbl残株数.TabIndex = 23
        Me.lbl残株数.Text = "残株数"
        '
        'lbl市場区分
        '
        Me.lbl市場区分.AutoSize = True
        Me.lbl市場区分.Location = New System.Drawing.Point(492, 137)
        Me.lbl市場区分.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl市場区分.Name = "lbl市場区分"
        Me.lbl市場区分.Size = New System.Drawing.Size(89, 20)
        Me.lbl市場区分.TabIndex = 12
        Me.lbl市場区分.Text = "市場区分"
        '
        'lbl業種区分
        '
        Me.lbl業種区分.AutoSize = True
        Me.lbl業種区分.Location = New System.Drawing.Point(492, 174)
        Me.lbl業種区分.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl業種区分.Name = "lbl業種区分"
        Me.lbl業種区分.Size = New System.Drawing.Size(89, 20)
        Me.lbl業種区分.TabIndex = 14
        Me.lbl業種区分.Text = "業種区分"
        '
        'txt取引種別
        '
        Me.txt取引種別.Font = New System.Drawing.Font("MS UI Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.txt取引種別.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txt取引種別.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.txt取引種別.Location = New System.Drawing.Point(165, 137)
        Me.txt取引種別.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.txt取引種別.MaxLength = 50
        Me.txt取引種別.Name = "txt取引種別"
        Me.txt取引種別.Size = New System.Drawing.Size(271, 21)
        Me.txt取引種別.TabIndex = 11
        Me.txt取引種別.TabStop = False
        Me.txt取引種別.Text = "制度信用"
        Me.txt取引種別.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt銘柄名
        '
        Me.txt銘柄名.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt銘柄名.Font = New System.Drawing.Font("MS UI Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.txt銘柄名.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txt銘柄名.ImeMode = System.Windows.Forms.ImeMode.[On]
        Me.txt銘柄名.Location = New System.Drawing.Point(586, 83)
        Me.txt銘柄名.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.txt銘柄名.MaxLength = 20
        Me.txt銘柄名.Name = "txt銘柄名"
        Me.txt銘柄名.Size = New System.Drawing.Size(271, 21)
        Me.txt銘柄名.TabIndex = 9
        Me.txt銘柄名.TabStop = False
        Me.txt銘柄名.Text = "新道 結"
        Me.txt銘柄名.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt取引区分
        '
        Me.txt取引区分.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt取引区分.Font = New System.Drawing.Font("MS UI Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.txt取引区分.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txt取引区分.ImeMode = System.Windows.Forms.ImeMode.[On]
        Me.txt取引区分.Location = New System.Drawing.Point(165, 214)
        Me.txt取引区分.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.txt取引区分.MaxLength = 50
        Me.txt取引区分.Name = "txt取引区分"
        Me.txt取引区分.Size = New System.Drawing.Size(271, 21)
        Me.txt取引区分.TabIndex = 17
        Me.txt取引区分.TabStop = False
        Me.txt取引区分.Text = "信新規買"
        Me.txt取引区分.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt取得株数
        '
        Me.txt取得株数.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt取得株数.Font = New System.Drawing.Font("MS UI Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.txt取得株数.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txt取得株数.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.txt取得株数.Location = New System.Drawing.Point(165, 259)
        Me.txt取得株数.MaxLength = 15
        Me.txt取得株数.Name = "txt取得株数"
        Me.txt取得株数.Size = New System.Drawing.Size(271, 21)
        Me.txt取得株数.TabIndex = 19
        Me.txt取得株数.Text = "100"
        Me.txt取得株数.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt取得単価
        '
        Me.txt取得単価.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.txt取得単価.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txt取得単価.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.txt取得単価.Location = New System.Drawing.Point(165, 299)
        Me.txt取得単価.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.txt取得単価.MaxLength = 10
        Me.txt取得単価.Name = "txt取得単価"
        Me.txt取得単価.Size = New System.Drawing.Size(271, 23)
        Me.txt取得単価.TabIndex = 21
        Me.txt取得単価.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt残株数
        '
        Me.txt残株数.Font = New System.Drawing.Font("MS UI Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.txt残株数.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txt残株数.ImeMode = System.Windows.Forms.ImeMode.[On]
        Me.txt残株数.Location = New System.Drawing.Point(553, 259)
        Me.txt残株数.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.txt残株数.MaxLength = 10
        Me.txt残株数.Name = "txt残株数"
        Me.txt残株数.Size = New System.Drawing.Size(271, 21)
        Me.txt残株数.TabIndex = 24
        Me.txt残株数.TabStop = False
        '
        'txt市場区分
        '
        Me.txt市場区分.Font = New System.Drawing.Font("MS UI Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.txt市場区分.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txt市場区分.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.txt市場区分.Location = New System.Drawing.Point(593, 129)
        Me.txt市場区分.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.txt市場区分.MaxLength = 10
        Me.txt市場区分.Name = "txt市場区分"
        Me.txt市場区分.Size = New System.Drawing.Size(271, 21)
        Me.txt市場区分.TabIndex = 13
        Me.txt市場区分.TabStop = False
        Me.txt市場区分.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt業種区分
        '
        Me.txt業種区分.Font = New System.Drawing.Font("MS UI Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.txt業種区分.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txt業種区分.ImeMode = System.Windows.Forms.ImeMode.[On]
        Me.txt業種区分.Location = New System.Drawing.Point(593, 166)
        Me.txt業種区分.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.txt業種区分.MaxLength = 10
        Me.txt業種区分.Name = "txt業種区分"
        Me.txt業種区分.Size = New System.Drawing.Size(271, 21)
        Me.txt業種区分.TabIndex = 15
        Me.txt業種区分.TabStop = False
        '
        'rdo信新買い
        '
        Me.rdo信新買い.AutoSize = True
        Me.rdo信新買い.Checked = True
        Me.rdo信新買い.Location = New System.Drawing.Point(37, 26)
        Me.rdo信新買い.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.rdo信新買い.Name = "rdo信新買い"
        Me.rdo信新買い.Size = New System.Drawing.Size(127, 24)
        Me.rdo信新買い.TabIndex = 0
        Me.rdo信新買い.TabStop = True
        Me.rdo信新買い.Text = "信用新規買"
        Me.rdo信新買い.UseVisualStyleBackColor = True
        '
        'rdo信返売り
        '
        Me.rdo信返売り.AutoSize = True
        Me.rdo信返売り.Location = New System.Drawing.Point(37, 57)
        Me.rdo信返売り.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.rdo信返売り.Name = "rdo信返売り"
        Me.rdo信返売り.Size = New System.Drawing.Size(127, 24)
        Me.rdo信返売り.TabIndex = 1
        Me.rdo信返売り.Text = "信用返済売"
        Me.rdo信返売り.UseVisualStyleBackColor = True
        '
        'dgv新規一覧
        '
        Me.dgv新規一覧.AllowUserToAddRows = False
        Me.dgv新規一覧.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv新規一覧.Location = New System.Drawing.Point(15, 423)
        Me.dgv新規一覧.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.dgv新規一覧.Name = "dgv新規一覧"
        Me.dgv新規一覧.RowHeadersWidth = 51
        Me.dgv新規一覧.RowTemplate.Height = 21
        Me.dgv新規一覧.Size = New System.Drawing.Size(1272, 351)
        Me.dgv新規一覧.TabIndex = 27
        Me.dgv新規一覧.TabStop = False
        '
        'btn閉じる
        '
        Me.btn閉じる.Font = New System.Drawing.Font("MS UI Gothic", 9.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btn閉じる.Location = New System.Drawing.Point(444, 365)
        Me.btn閉じる.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.btn閉じる.Name = "btn閉じる"
        Me.btn閉じる.Size = New System.Drawing.Size(138, 42)
        Me.btn閉じる.TabIndex = 26
        Me.btn閉じる.Text = "次へ(&N)"
        Me.btn閉じる.UseVisualStyleBackColor = True
        '
        'grb性別
        '
        Me.grb性別.Controls.Add(Me.rdo信新買い)
        Me.grb性別.Controls.Add(Me.rdo信返売り)
        Me.grb性別.Location = New System.Drawing.Point(893, 76)
        Me.grb性別.Name = "grb性別"
        Me.grb性別.Size = New System.Drawing.Size(361, 103)
        Me.grb性別.TabIndex = 4
        Me.grb性別.TabStop = False
        Me.grb性別.Text = "取引種別"
        '
        'rdoクリア
        '
        Me.rdoクリア.AutoSize = True
        Me.rdoクリア.Location = New System.Drawing.Point(930, 174)
        Me.rdoクリア.Name = "rdoクリア"
        Me.rdoクリア.Size = New System.Drawing.Size(68, 24)
        Me.rdoクリア.TabIndex = 2
        Me.rdoクリア.Text = "クリア"
        Me.rdoクリア.UseVisualStyleBackColor = True
        '
        'btn登録
        '
        Me.btn登録.Font = New System.Drawing.Font("MS UI Gothic", 9.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btn登録.Location = New System.Drawing.Point(61, 365)
        Me.btn登録.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.btn登録.Name = "btn登録"
        Me.btn登録.Size = New System.Drawing.Size(138, 47)
        Me.btn登録.TabIndex = 22
        Me.btn登録.Text = "確認(&U)"
        Me.btn登録.UseVisualStyleBackColor = True
        '
        'txt入力ID
        '
        Me.txt入力ID.Font = New System.Drawing.Font("MS UI Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.txt入力ID.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txt入力ID.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.txt入力ID.Location = New System.Drawing.Point(746, 18)
        Me.txt入力ID.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.txt入力ID.MaxLength = 10
        Me.txt入力ID.Name = "txt入力ID"
        Me.txt入力ID.Size = New System.Drawing.Size(243, 21)
        Me.txt入力ID.TabIndex = 3
        Me.txt入力ID.TabStop = False
        Me.txt入力ID.Text = "210211010"
        Me.txt入力ID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lbl取引ID
        '
        Me.lbl取引ID.AutoSize = True
        Me.lbl取引ID.Location = New System.Drawing.Point(640, 23)
        Me.lbl取引ID.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl取引ID.Name = "lbl取引ID"
        Me.lbl取引ID.Size = New System.Drawing.Size(67, 20)
        Me.lbl取引ID.TabIndex = 2
        Me.lbl取引ID.Text = "入力ID"
        '
        'txt取得日付
        '
        Me.txt取得日付.BackColor = System.Drawing.Color.White
        Me.txt取得日付.Enabled = False
        Me.txt取得日付.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.txt取得日付.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txt取得日付.ImeMode = System.Windows.Forms.ImeMode.Disable
        Me.txt取得日付.Location = New System.Drawing.Point(165, 32)
        Me.txt取得日付.MaxLength = 15
        Me.txt取得日付.Name = "txt取得日付"
        Me.txt取得日付.ReadOnly = True
        Me.txt取得日付.Size = New System.Drawing.Size(177, 24)
        Me.txt取得日付.TabIndex = 1
        Me.txt取得日付.TabStop = False
        Me.txt取得日付.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lbl取得日付
        '
        Me.lbl取得日付.AutoSize = True
        Me.lbl取得日付.Location = New System.Drawing.Point(57, 32)
        Me.lbl取得日付.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl取得日付.Name = "lbl取得日付"
        Me.lbl取得日付.Size = New System.Drawing.Size(89, 20)
        Me.lbl取得日付.TabIndex = 0
        Me.lbl取得日付.Text = "取得日付"
        '
        'btn続けて入力
        '
        Me.btn続けて入力.Font = New System.Drawing.Font("MS UI Gothic", 9.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btn続けて入力.Location = New System.Drawing.Point(245, 365)
        Me.btn続けて入力.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.btn続けて入力.Name = "btn続けて入力"
        Me.btn続けて入力.Size = New System.Drawing.Size(138, 37)
        Me.btn続けて入力.TabIndex = 25
        Me.btn続けて入力.Text = "続けて入力(&C)"
        Me.btn続けて入力.UseVisualStyleBackColor = True
        '
        'btn銘柄名検索
        '
        Me.btn銘柄名検索.Location = New System.Drawing.Point(370, 77)
        Me.btn銘柄名検索.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.btn銘柄名検索.Name = "btn銘柄名検索"
        Me.btn銘柄名検索.Size = New System.Drawing.Size(35, 27)
        Me.btn銘柄名検索.TabIndex = 7
        Me.btn銘柄名検索.Text = "？"
        Me.btn銘柄名検索.UseVisualStyleBackColor = True
        '
        'txt銘柄コード
        '
        Me.txt銘柄コード.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt銘柄コード.Font = New System.Drawing.Font("MS UI Gothic", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.txt銘柄コード.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txt銘柄コード.ImeMode = System.Windows.Forms.ImeMode.Disable
        Me.txt銘柄コード.Location = New System.Drawing.Point(161, 76)
        Me.txt銘柄コード.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.txt銘柄コード.MaxLength = 8
        Me.txt銘柄コード.Name = "txt銘柄コード"
        Me.txt銘柄コード.Size = New System.Drawing.Size(191, 27)
        Me.txt銘柄コード.TabIndex = 6
        '
        'frm新規建入力
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1302, 801)
        Me.Controls.Add(Me.rdoクリア)
        Me.Controls.Add(Me.btn銘柄名検索)
        Me.Controls.Add(Me.txt銘柄コード)
        Me.Controls.Add(Me.btn続けて入力)
        Me.Controls.Add(Me.txt取得日付)
        Me.Controls.Add(Me.lbl取得日付)
        Me.Controls.Add(Me.txt入力ID)
        Me.Controls.Add(Me.lbl取引ID)
        Me.Controls.Add(Me.grb性別)
        Me.Controls.Add(Me.btn閉じる)
        Me.Controls.Add(Me.dgv新規一覧)
        Me.Controls.Add(Me.btn登録)
        Me.Controls.Add(Me.txt業種区分)
        Me.Controls.Add(Me.txt市場区分)
        Me.Controls.Add(Me.txt残株数)
        Me.Controls.Add(Me.txt取得単価)
        Me.Controls.Add(Me.txt取得株数)
        Me.Controls.Add(Me.txt取引区分)
        Me.Controls.Add(Me.txt銘柄名)
        Me.Controls.Add(Me.txt取引種別)
        Me.Controls.Add(Me.lbl業種区分)
        Me.Controls.Add(Me.lbl市場区分)
        Me.Controls.Add(Me.lbl残株数)
        Me.Controls.Add(Me.lbl取得単価)
        Me.Controls.Add(Me.lbl株数)
        Me.Controls.Add(Me.lbl取引区分)
        Me.Controls.Add(Me.lbl銘柄名)
        Me.Controls.Add(Me.lblフリガナ)
        Me.Controls.Add(Me.lbl取引種別)
        Me.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.Name = "frm新規建入力"
        Me.Text = "新規建"
        CType(Me.dgv新規一覧, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grb性別.ResumeLayout(False)
        Me.grb性別.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbl取引種別 As Label
    Friend WithEvents lblフリガナ As Label
    Friend WithEvents lbl銘柄名 As Label
    Friend WithEvents lbl取引区分 As Label
    Friend WithEvents lbl株数 As Label
    Friend WithEvents lbl取得単価 As Label
    Friend WithEvents lbl残株数 As Label
    Friend WithEvents lbl市場区分 As Label
    Friend WithEvents lbl業種区分 As Label
    Friend WithEvents txt取引種別 As TextBox
    Friend WithEvents txt銘柄名 As TextBox
    Friend WithEvents txt取引区分 As TextBox
    Friend WithEvents txt取得株数 As TextBox
    Friend WithEvents txt取得単価 As TextBox
    Friend WithEvents txt残株数 As TextBox
    Friend WithEvents txt市場区分 As TextBox
    Friend WithEvents txt業種区分 As TextBox
    Friend WithEvents rdo信新買い As RadioButton
    Friend WithEvents rdo信返売り As RadioButton
    Friend WithEvents btn登録 As Button
    Friend WithEvents dgv新規一覧 As DataGridView
    Friend WithEvents btn閉じる As Button
    Friend WithEvents grb性別 As GroupBox
    Friend WithEvents rdoクリア As RadioButton
    Friend WithEvents txt入力ID As TextBox
    Friend WithEvents lbl取引ID As Label
    Friend WithEvents txt取得日付 As TextBox
    Friend WithEvents lbl取得日付 As Label
    Friend WithEvents btn続けて入力 As Button
    Friend WithEvents btn銘柄名検索 As Button
    Friend WithEvents txt銘柄コード As TextBox
End Class
