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
        Me.lbl現況 = New System.Windows.Forms.Label()
        Me.lblフリガナ = New System.Windows.Forms.Label()
        Me.lbl銘柄名 = New System.Windows.Forms.Label()
        Me.lbl取引名称 = New System.Windows.Forms.Label()
        Me.lbl株数 = New System.Windows.Forms.Label()
        Me.lbl取得単価 = New System.Windows.Forms.Label()
        Me.lbl残株数 = New System.Windows.Forms.Label()
        Me.txt現況 = New System.Windows.Forms.TextBox()
        Me.txt銘柄名 = New System.Windows.Forms.TextBox()
        Me.txt取引名称 = New System.Windows.Forms.TextBox()
        Me.txt取得株数 = New System.Windows.Forms.TextBox()
        Me.txt取得単価 = New System.Windows.Forms.TextBox()
        Me.txt残株数 = New System.Windows.Forms.TextBox()
        Me.rdo信新買い = New System.Windows.Forms.RadioButton()
        Me.rdo信用新規売 = New System.Windows.Forms.RadioButton()
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
        'lbl現況
        '
        Me.lbl現況.AutoSize = True
        Me.lbl現況.Location = New System.Drawing.Point(123, 387)
        Me.lbl現況.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl現況.Name = "lbl現況"
        Me.lbl現況.Size = New System.Drawing.Size(47, 19)
        Me.lbl現況.TabIndex = 10
        Me.lbl現況.Text = "現況"
        '
        'lblフリガナ
        '
        Me.lblフリガナ.AutoSize = True
        Me.lblフリガナ.Location = New System.Drawing.Point(127, 39)
        Me.lblフリガナ.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblフリガナ.Name = "lblフリガナ"
        Me.lblフリガナ.Size = New System.Drawing.Size(90, 19)
        Me.lblフリガナ.TabIndex = 5
        Me.lblフリガナ.Text = "銘柄コード"
        '
        'lbl銘柄名
        '
        Me.lbl銘柄名.AutoSize = True
        Me.lbl銘柄名.Location = New System.Drawing.Point(143, 83)
        Me.lbl銘柄名.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl銘柄名.Name = "lbl銘柄名"
        Me.lbl銘柄名.Size = New System.Drawing.Size(66, 19)
        Me.lbl銘柄名.TabIndex = 8
        Me.lbl銘柄名.Text = "銘柄名"
        '
        'lbl取引名称
        '
        Me.lbl取引名称.AutoSize = True
        Me.lbl取引名称.Location = New System.Drawing.Point(123, 132)
        Me.lbl取引名称.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl取引名称.Name = "lbl取引名称"
        Me.lbl取引名称.Size = New System.Drawing.Size(85, 19)
        Me.lbl取引名称.TabIndex = 16
        Me.lbl取引名称.Text = "取引名称"
        '
        'lbl株数
        '
        Me.lbl株数.AutoSize = True
        Me.lbl株数.Location = New System.Drawing.Point(121, 177)
        Me.lbl株数.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl株数.Name = "lbl株数"
        Me.lbl株数.Size = New System.Drawing.Size(85, 19)
        Me.lbl株数.TabIndex = 18
        Me.lbl株数.Text = "取得株数" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'lbl取得単価
        '
        Me.lbl取得単価.AutoSize = True
        Me.lbl取得単価.Location = New System.Drawing.Point(86, 247)
        Me.lbl取得単価.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl取得単価.Name = "lbl取得単価"
        Me.lbl取得単価.Size = New System.Drawing.Size(85, 19)
        Me.lbl取得単価.TabIndex = 20
        Me.lbl取得単価.Text = "取得単価"
        '
        'lbl残株数
        '
        Me.lbl残株数.AutoSize = True
        Me.lbl残株数.Location = New System.Drawing.Point(105, 327)
        Me.lbl残株数.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl残株数.Name = "lbl残株数"
        Me.lbl残株数.Size = New System.Drawing.Size(66, 19)
        Me.lbl残株数.TabIndex = 23
        Me.lbl残株数.Text = "残株数"
        '
        'txt現況
        '
        Me.txt現況.Font = New System.Drawing.Font("MS UI Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.txt現況.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txt現況.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.txt現況.Location = New System.Drawing.Point(213, 381)
        Me.txt現況.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.txt現況.MaxLength = 50
        Me.txt現況.Name = "txt現況"
        Me.txt現況.Size = New System.Drawing.Size(247, 20)
        Me.txt現況.TabIndex = 11
        Me.txt現況.TabStop = False
        Me.txt現況.Text = "買建"
        Me.txt現況.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt銘柄名
        '
        Me.txt銘柄名.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt銘柄名.Font = New System.Drawing.Font("MS UI Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.txt銘柄名.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txt銘柄名.ImeMode = System.Windows.Forms.ImeMode.[On]
        Me.txt銘柄名.Location = New System.Drawing.Point(213, 81)
        Me.txt銘柄名.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.txt銘柄名.MaxLength = 20
        Me.txt銘柄名.Name = "txt銘柄名"
        Me.txt銘柄名.Size = New System.Drawing.Size(247, 20)
        Me.txt銘柄名.TabIndex = 9
        Me.txt銘柄名.TabStop = False
        Me.txt銘柄名.Text = "新道 結"
        Me.txt銘柄名.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt取引名称
        '
        Me.txt取引名称.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt取引名称.Font = New System.Drawing.Font("MS UI Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.txt取引名称.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txt取引名称.ImeMode = System.Windows.Forms.ImeMode.[On]
        Me.txt取引名称.Location = New System.Drawing.Point(213, 132)
        Me.txt取引名称.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.txt取引名称.MaxLength = 50
        Me.txt取引名称.Name = "txt取引名称"
        Me.txt取引名称.Size = New System.Drawing.Size(247, 20)
        Me.txt取引名称.TabIndex = 17
        Me.txt取引名称.TabStop = False
        Me.txt取引名称.Text = "信用新規買"
        Me.txt取引名称.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt取得株数
        '
        Me.txt取得株数.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt取得株数.Font = New System.Drawing.Font("MS UI Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.txt取得株数.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txt取得株数.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.txt取得株数.Location = New System.Drawing.Point(213, 171)
        Me.txt取得株数.MaxLength = 15
        Me.txt取得株数.Name = "txt取得株数"
        Me.txt取得株数.Size = New System.Drawing.Size(247, 20)
        Me.txt取得株数.TabIndex = 19
        Me.txt取得株数.Text = "100"
        Me.txt取得株数.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt取得単価
        '
        Me.txt取得単価.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.txt取得単価.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txt取得単価.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.txt取得単価.Location = New System.Drawing.Point(213, 244)
        Me.txt取得単価.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.txt取得単価.MaxLength = 10
        Me.txt取得単価.Name = "txt取得単価"
        Me.txt取得単価.Size = New System.Drawing.Size(247, 22)
        Me.txt取得単価.TabIndex = 21
        Me.txt取得単価.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt残株数
        '
        Me.txt残株数.Font = New System.Drawing.Font("MS UI Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.txt残株数.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txt残株数.ImeMode = System.Windows.Forms.ImeMode.[On]
        Me.txt残株数.Location = New System.Drawing.Point(213, 326)
        Me.txt残株数.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.txt残株数.MaxLength = 10
        Me.txt残株数.Name = "txt残株数"
        Me.txt残株数.Size = New System.Drawing.Size(247, 20)
        Me.txt残株数.TabIndex = 24
        Me.txt残株数.TabStop = False
        '
        'rdo信新買い
        '
        Me.rdo信新買い.AutoSize = True
        Me.rdo信新買い.Checked = True
        Me.rdo信新買い.Location = New System.Drawing.Point(34, 25)
        Me.rdo信新買い.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.rdo信新買い.Name = "rdo信新買い"
        Me.rdo信新買い.Size = New System.Drawing.Size(122, 23)
        Me.rdo信新買い.TabIndex = 0
        Me.rdo信新買い.TabStop = True
        Me.rdo信新買い.Text = "信用新規買"
        Me.rdo信新買い.UseVisualStyleBackColor = True
        '
        'rdo信用新規売
        '
        Me.rdo信用新規売.AutoSize = True
        Me.rdo信用新規売.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.rdo信用新規売.Location = New System.Drawing.Point(34, 54)
        Me.rdo信用新規売.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.rdo信用新規売.Name = "rdo信用新規売"
        Me.rdo信用新規売.Size = New System.Drawing.Size(122, 23)
        Me.rdo信用新規売.TabIndex = 1
        Me.rdo信用新規売.Text = "信用新規売"
        Me.rdo信用新規売.UseVisualStyleBackColor = True
        '
        'dgv新規一覧
        '
        Me.dgv新規一覧.AllowUserToAddRows = False
        Me.dgv新規一覧.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv新規一覧.Location = New System.Drawing.Point(14, 459)
        Me.dgv新規一覧.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.dgv新規一覧.Name = "dgv新規一覧"
        Me.dgv新規一覧.RowHeadersWidth = 51
        Me.dgv新規一覧.RowTemplate.Height = 21
        Me.dgv新規一覧.Size = New System.Drawing.Size(1156, 333)
        Me.dgv新規一覧.TabIndex = 27
        Me.dgv新規一覧.TabStop = False
        '
        'btn閉じる
        '
        Me.btn閉じる.Font = New System.Drawing.Font("MS UI Gothic", 9.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btn閉じる.ForeColor = System.Drawing.Color.Red
        Me.btn閉じる.Location = New System.Drawing.Point(951, 381)
        Me.btn閉じる.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.btn閉じる.Name = "btn閉じる"
        Me.btn閉じる.Size = New System.Drawing.Size(125, 40)
        Me.btn閉じる.TabIndex = 26
        Me.btn閉じる.Text = "閉じる(&N)"
        Me.btn閉じる.UseVisualStyleBackColor = True
        '
        'grb性別
        '
        Me.grb性別.Controls.Add(Me.rdoクリア)
        Me.grb性別.Controls.Add(Me.rdo信新買い)
        Me.grb性別.Controls.Add(Me.rdo信用新規売)
        Me.grb性別.Location = New System.Drawing.Point(812, 72)
        Me.grb性別.Name = "grb性別"
        Me.grb性別.Size = New System.Drawing.Size(328, 124)
        Me.grb性別.TabIndex = 4
        Me.grb性別.TabStop = False
        Me.grb性別.Text = "取引種別"
        '
        'rdoクリア
        '
        Me.rdoクリア.AutoSize = True
        Me.rdoクリア.Location = New System.Drawing.Point(34, 95)
        Me.rdoクリア.Name = "rdoクリア"
        Me.rdoクリア.Size = New System.Drawing.Size(65, 23)
        Me.rdoクリア.TabIndex = 2
        Me.rdoクリア.Text = "クリア"
        Me.rdoクリア.UseVisualStyleBackColor = True
        '
        'btn登録
        '
        Me.btn登録.Font = New System.Drawing.Font("MS UI Gothic", 9.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btn登録.Location = New System.Drawing.Point(603, 381)
        Me.btn登録.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.btn登録.Name = "btn登録"
        Me.btn登録.Size = New System.Drawing.Size(125, 45)
        Me.btn登録.TabIndex = 22
        Me.btn登録.Text = "登録(&U)"
        Me.btn登録.UseVisualStyleBackColor = True
        '
        'txt入力ID
        '
        Me.txt入力ID.Font = New System.Drawing.Font("MS UI Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.txt入力ID.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txt入力ID.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.txt入力ID.Location = New System.Drawing.Point(222, 2)
        Me.txt入力ID.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.txt入力ID.MaxLength = 10
        Me.txt入力ID.Name = "txt入力ID"
        Me.txt入力ID.Size = New System.Drawing.Size(221, 20)
        Me.txt入力ID.TabIndex = 3
        Me.txt入力ID.TabStop = False
        Me.txt入力ID.Text = "210211010"
        Me.txt入力ID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lbl取引ID
        '
        Me.lbl取引ID.AutoSize = True
        Me.lbl取引ID.Location = New System.Drawing.Point(125, 7)
        Me.lbl取引ID.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl取引ID.Name = "lbl取引ID"
        Me.lbl取引ID.Size = New System.Drawing.Size(64, 19)
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
        Me.txt取得日付.Location = New System.Drawing.Point(213, 286)
        Me.txt取得日付.MaxLength = 15
        Me.txt取得日付.Name = "txt取得日付"
        Me.txt取得日付.ReadOnly = True
        Me.txt取得日付.Size = New System.Drawing.Size(161, 23)
        Me.txt取得日付.TabIndex = 1
        Me.txt取得日付.TabStop = False
        Me.txt取得日付.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lbl取得日付
        '
        Me.lbl取得日付.AutoSize = True
        Me.lbl取得日付.Location = New System.Drawing.Point(86, 286)
        Me.lbl取得日付.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl取得日付.Name = "lbl取得日付"
        Me.lbl取得日付.Size = New System.Drawing.Size(85, 19)
        Me.lbl取得日付.TabIndex = 0
        Me.lbl取得日付.Text = "取得日付"
        '
        'btn続けて入力
        '
        Me.btn続けて入力.Font = New System.Drawing.Font("MS UI Gothic", 9.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btn続けて入力.Location = New System.Drawing.Point(770, 381)
        Me.btn続けて入力.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.btn続けて入力.Name = "btn続けて入力"
        Me.btn続けて入力.Size = New System.Drawing.Size(125, 35)
        Me.btn続けて入力.TabIndex = 25
        Me.btn続けて入力.Text = "続けて入力(&C)"
        Me.btn続けて入力.UseVisualStyleBackColor = True
        '
        'btn銘柄名検索
        '
        Me.btn銘柄名検索.Location = New System.Drawing.Point(412, 33)
        Me.btn銘柄名検索.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.btn銘柄名検索.Name = "btn銘柄名検索"
        Me.btn銘柄名検索.Size = New System.Drawing.Size(32, 26)
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
        Me.txt銘柄コード.Location = New System.Drawing.Point(222, 32)
        Me.txt銘柄コード.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.txt銘柄コード.MaxLength = 8
        Me.txt銘柄コード.Name = "txt銘柄コード"
        Me.txt銘柄コード.Size = New System.Drawing.Size(174, 26)
        Me.txt銘柄コード.TabIndex = 6
        '
        'frm新規建入力
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1184, 761)
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
        Me.Controls.Add(Me.txt残株数)
        Me.Controls.Add(Me.txt取得単価)
        Me.Controls.Add(Me.txt取得株数)
        Me.Controls.Add(Me.txt取引名称)
        Me.Controls.Add(Me.txt銘柄名)
        Me.Controls.Add(Me.txt現況)
        Me.Controls.Add(Me.lbl残株数)
        Me.Controls.Add(Me.lbl取得単価)
        Me.Controls.Add(Me.lbl株数)
        Me.Controls.Add(Me.lbl取引名称)
        Me.Controls.Add(Me.lbl銘柄名)
        Me.Controls.Add(Me.lblフリガナ)
        Me.Controls.Add(Me.lbl現況)
        Me.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.Name = "frm新規建入力"
        Me.Text = "新規建"
        CType(Me.dgv新規一覧, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grb性別.ResumeLayout(False)
        Me.grb性別.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbl現況 As Label
    Friend WithEvents lblフリガナ As Label
    Friend WithEvents lbl銘柄名 As Label
    Friend WithEvents lbl取引名称 As Label
    Friend WithEvents lbl株数 As Label
    Friend WithEvents lbl取得単価 As Label
    Friend WithEvents lbl残株数 As Label
    Friend WithEvents txt現況 As TextBox
    Friend WithEvents txt銘柄名 As TextBox
    Friend WithEvents txt取引名称 As TextBox
    Friend WithEvents txt取得株数 As TextBox
    Friend WithEvents txt取得単価 As TextBox
    Friend WithEvents txt残株数 As TextBox
    Friend WithEvents rdo信新買い As RadioButton
    Friend WithEvents rdo信用新規売 As RadioButton
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
