<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm返済
    ' Inherits System.Windows.Forms.Form
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
        Me.lblA = New System.Windows.Forms.Label()
        Me.txt銘柄コード = New System.Windows.Forms.TextBox()
        Me.dgv未返済一覧 = New System.Windows.Forms.DataGridView()
        Me.lbl電話 = New System.Windows.Forms.Label()
        Me.lbl８ = New System.Windows.Forms.Label()
        Me.lblC = New System.Windows.Forms.Label()
        Me.lblB = New System.Windows.Forms.Label()
        Me.lblｘ = New System.Windows.Forms.Label()
        Me.txt返済単価 = New System.Windows.Forms.TextBox()
        Me.txt返済玉ID = New System.Windows.Forms.TextBox()
        Me.txt返済入力ID = New System.Windows.Forms.TextBox()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.txt検索日付 = New System.Windows.Forms.TextBox()
        Me.lb残株数 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.btn登録 = New System.Windows.Forms.Button()
        Me.txt返済株数 = New System.Windows.Forms.TextBox()
        Me.txt取得単価 = New System.Windows.Forms.TextBox()
        Me.txt返済後残株数 = New System.Windows.Forms.TextBox()
        Me.txt売買差額 = New System.Windows.Forms.TextBox()
        Me.txt取得日 = New System.Windows.Forms.TextBox()
        Me.lbl取得単価 = New System.Windows.Forms.Label()
        Me.lblD = New System.Windows.Forms.Label()
        Me.txt銘柄名 = New System.Windows.Forms.TextBox()
        Me.lblF = New System.Windows.Forms.Label()
        Me.lbl取得株数 = New System.Windows.Forms.Label()
        Me.txt残株数 = New System.Windows.Forms.TextBox()
        Me.lbl定休日 = New System.Windows.Forms.Label()
        Me.lblE = New System.Windows.Forms.Label()
        Me.txt取引区分 = New System.Windows.Forms.TextBox()
        Me.txt取引名称 = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txt返済日付 = New System.Windows.Forms.TextBox()
        Me.btn検索日付 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btn次へ = New System.Windows.Forms.Button()
        Me.btn続ける = New System.Windows.Forms.Button()
        CType(Me.dgv未返済一覧, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grp取引名称.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblA
        '
        Me.lblA.AutoSize = True
        Me.lblA.Location = New System.Drawing.Point(101, 126)
        Me.lblA.Name = "lblA"
        Me.lblA.Size = New System.Drawing.Size(57, 17)
        Me.lblA.TabIndex = 3
        Me.lblA.Text = "入力ID"
        '
        'txt銘柄コード
        '
        Me.txt銘柄コード.Location = New System.Drawing.Point(162, 188)
        Me.txt銘柄コード.Name = "txt銘柄コード"
        Me.txt銘柄コード.Size = New System.Drawing.Size(169, 24)
        Me.txt銘柄コード.TabIndex = 8
        '
        'dgv未返済一覧
        '
        Me.dgv未返済一覧.AllowUserToAddRows = False
        Me.dgv未返済一覧.AllowUserToDeleteRows = False
        Me.dgv未返済一覧.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv未返済一覧.Location = New System.Drawing.Point(23, 547)
        Me.dgv未返済一覧.Name = "dgv未返済一覧"
        Me.dgv未返済一覧.ReadOnly = True
        Me.dgv未返済一覧.RowHeadersWidth = 51
        Me.dgv未返済一覧.RowTemplate.Height = 24
        Me.dgv未返済一覧.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv未返済一覧.Size = New System.Drawing.Size(820, 279)
        Me.dgv未返済一覧.TabIndex = 17
        '
        'lbl電話
        '
        Me.lbl電話.AutoSize = True
        Me.lbl電話.Location = New System.Drawing.Point(739, 161)
        Me.lbl電話.Name = "lbl電話"
        Me.lbl電話.Size = New System.Drawing.Size(110, 17)
        Me.lbl電話.TabIndex = 36
        Me.lbl電話.Text = "概算売買差額"
        '
        'lbl８
        '
        Me.lbl８.AutoSize = True
        Me.lbl８.Location = New System.Drawing.Point(426, 146)
        Me.lbl８.Name = "lbl８"
        Me.lbl８.Size = New System.Drawing.Size(110, 17)
        Me.lbl８.TabIndex = 22
        Me.lbl８.Text = "返済約定単価"
        '
        'lblC
        '
        Me.lblC.AutoSize = True
        Me.lblC.Location = New System.Drawing.Point(83, 191)
        Me.lblC.Name = "lblC"
        Me.lblC.Size = New System.Drawing.Size(80, 17)
        Me.lblC.TabIndex = 7
        Me.lblC.Text = "銘柄コード"
        '
        'lblB
        '
        Me.lblB.AutoSize = True
        Me.lblB.Location = New System.Drawing.Point(74, 160)
        Me.lblB.Name = "lblB"
        Me.lblB.Size = New System.Drawing.Size(74, 17)
        Me.lblB.TabIndex = 5
        Me.lblB.Text = "返済玉ID"
        '
        'lblｘ
        '
        Me.lblｘ.AutoSize = True
        Me.lblｘ.Location = New System.Drawing.Point(444, 78)
        Me.lblｘ.Name = "lblｘ"
        Me.lblｘ.Size = New System.Drawing.Size(91, 17)
        Me.lblｘ.TabIndex = 18
        Me.lblｘ.Text = "返済入力ID"
        '
        'txt返済単価
        '
        Me.txt返済単価.Location = New System.Drawing.Point(543, 143)
        Me.txt返済単価.Name = "txt返済単価"
        Me.txt返済単価.Size = New System.Drawing.Size(141, 24)
        Me.txt返済単価.TabIndex = 23
        '
        'txt返済玉ID
        '
        Me.txt返済玉ID.Location = New System.Drawing.Point(162, 154)
        Me.txt返済玉ID.Name = "txt返済玉ID"
        Me.txt返済玉ID.Size = New System.Drawing.Size(223, 24)
        Me.txt返済玉ID.TabIndex = 6
        '
        'txt返済入力ID
        '
        Me.txt返済入力ID.Location = New System.Drawing.Point(541, 71)
        Me.txt返済入力ID.Name = "txt返済入力ID"
        Me.txt返済入力ID.Size = New System.Drawing.Size(174, 24)
        Me.txt返済入力ID.TabIndex = 19
        '
        'txtID
        '
        Me.txtID.Location = New System.Drawing.Point(162, 121)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(223, 24)
        Me.txtID.TabIndex = 4
        '
        'txt検索日付
        '
        Me.txt検索日付.Location = New System.Drawing.Point(163, 71)
        Me.txt検索日付.Name = "txt検索日付"
        Me.txt検索日付.Size = New System.Drawing.Size(222, 24)
        Me.txt検索日付.TabIndex = 1
        '
        'lb残株数
        '
        Me.lb残株数.AutoSize = True
        Me.lb残株数.Location = New System.Drawing.Point(426, 328)
        Me.lb残株数.Name = "lb残株数"
        Me.lb残株数.Size = New System.Drawing.Size(110, 17)
        Me.lb残株数.TabIndex = 30
        Me.lb残株数.Text = "返済後残株数"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(88, 262)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(59, 17)
        Me.Label10.TabIndex = 11
        Me.Label10.Text = "取得日"
        '
        'btn登録
        '
        Me.btn登録.Location = New System.Drawing.Point(735, 262)
        Me.btn登録.Name = "btn登録"
        Me.btn登録.Size = New System.Drawing.Size(96, 40)
        Me.btn登録.TabIndex = 38
        Me.btn登録.Text = "登録"
        Me.btn登録.UseVisualStyleBackColor = True
        '
        'txt返済株数
        '
        Me.txt返済株数.Location = New System.Drawing.Point(543, 178)
        Me.txt返済株数.Name = "txt返済株数"
        Me.txt返済株数.Size = New System.Drawing.Size(172, 24)
        Me.txt返済株数.TabIndex = 25
        '
        'txt取得単価
        '
        Me.txt取得単価.Location = New System.Drawing.Point(162, 325)
        Me.txt取得単価.Name = "txt取得単価"
        Me.txt取得単価.Size = New System.Drawing.Size(202, 24)
        Me.txt取得単価.TabIndex = 16
        '
        'txt返済後残株数
        '
        Me.txt返済後残株数.Location = New System.Drawing.Point(541, 321)
        Me.txt返済後残株数.Name = "txt返済後残株数"
        Me.txt返済後残株数.Size = New System.Drawing.Size(157, 24)
        Me.txt返済後残株数.TabIndex = 31
        '
        'txt売買差額
        '
        Me.txt売買差額.Location = New System.Drawing.Point(735, 180)
        Me.txt売買差額.Name = "txt売買差額"
        Me.txt売買差額.Size = New System.Drawing.Size(138, 24)
        Me.txt売買差額.TabIndex = 37
        '
        'txt取得日
        '
        Me.txt取得日.Location = New System.Drawing.Point(162, 255)
        Me.txt取得日.Name = "txt取得日"
        Me.txt取得日.Size = New System.Drawing.Size(169, 24)
        Me.txt取得日.TabIndex = 12
        '
        'lbl取得単価
        '
        Me.lbl取得単価.AutoSize = True
        Me.lbl取得単価.Location = New System.Drawing.Point(79, 332)
        Me.lbl取得単価.Name = "lbl取得単価"
        Me.lbl取得単価.Size = New System.Drawing.Size(76, 17)
        Me.lbl取得単価.TabIndex = 15
        Me.lbl取得単価.Text = "取得単価"
        '
        'lblD
        '
        Me.lblD.AutoSize = True
        Me.lblD.Location = New System.Drawing.Point(79, 223)
        Me.lblD.Name = "lblD"
        Me.lblD.Size = New System.Drawing.Size(59, 17)
        Me.lblD.TabIndex = 9
        Me.lblD.Text = "銘柄名"
        '
        'txt銘柄名
        '
        Me.txt銘柄名.Location = New System.Drawing.Point(162, 221)
        Me.txt銘柄名.Name = "txt銘柄名"
        Me.txt銘柄名.Size = New System.Drawing.Size(223, 24)
        Me.txt銘柄名.TabIndex = 10
        '
        'lblF
        '
        Me.lblF.AutoSize = True
        Me.lblF.Location = New System.Drawing.Point(458, 181)
        Me.lblF.Name = "lblF"
        Me.lblF.Size = New System.Drawing.Size(76, 17)
        Me.lblF.TabIndex = 24
        Me.lblF.Text = "返済株数"
        '
        'lbl取得株数
        '
        Me.lbl取得株数.AutoSize = True
        Me.lbl取得株数.Location = New System.Drawing.Point(88, 293)
        Me.lbl取得株数.Name = "lbl取得株数"
        Me.lbl取得株数.Size = New System.Drawing.Size(59, 17)
        Me.lbl取得株数.TabIndex = 13
        Me.lbl取得株数.Text = "残株数"
        '
        'txt残株数
        '
        Me.txt残株数.Location = New System.Drawing.Point(162, 289)
        Me.txt残株数.Name = "txt残株数"
        Me.txt残株数.Size = New System.Drawing.Size(159, 24)
        Me.txt残株数.TabIndex = 14
        '
        'lbl定休日
        '
        Me.lbl定休日.AutoSize = True
        Me.lbl定休日.Location = New System.Drawing.Point(458, 217)
        Me.lbl定休日.Name = "lbl定休日"
        Me.lbl定休日.Size = New System.Drawing.Size(76, 17)
        Me.lbl定休日.TabIndex = 26
        Me.lbl定休日.Text = "取引名称"
        '
        'lblE
        '
        Me.lblE.AutoSize = True
        Me.lblE.Location = New System.Drawing.Point(458, 251)
        Me.lblE.Name = "lblE"
        Me.lblE.Size = New System.Drawing.Size(76, 17)
        Me.lblE.TabIndex = 28
        Me.lblE.Text = "取引区分"
        '
        'txt取引区分
        '
        Me.txt取引区分.Location = New System.Drawing.Point(547, 248)
        Me.txt取引区分.Name = "txt取引区分"
        Me.txt取引区分.Size = New System.Drawing.Size(119, 24)
        Me.txt取引区分.TabIndex = 29
        Me.txt取引区分.Text = "信返済売"
        '
        'txt取引名称
        '
        Me.txt取引名称.AcceptsReturn = True
        Me.txt取引名称.Location = New System.Drawing.Point(547, 214)
        Me.txt取引名称.Name = "txt取引名称"
        Me.txt取引名称.Size = New System.Drawing.Size(119, 24)
        Me.txt取引名称.TabIndex = 27
        Me.txt取引名称.Text = "信用返済売"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(458, 112)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(76, 17)
        Me.Label6.TabIndex = 20
        Me.Label6.Text = "返済日付"
        '
        'txt返済日付
        '
        Me.txt返済日付.Location = New System.Drawing.Point(541, 108)
        Me.txt返済日付.Name = "txt返済日付"
        Me.txt返済日付.Size = New System.Drawing.Size(174, 24)
        Me.txt返済日付.TabIndex = 21
        '
        'btn検索日付
        '
        Me.btn検索日付.Font = New System.Drawing.Font("MS UI Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btn検索日付.Location = New System.Drawing.Point(23, 17)
        Me.btn検索日付.Name = "btn検索日付"
        Me.btn検索日付.Size = New System.Drawing.Size(128, 97)
        Me.btn検索日付.TabIndex = 0
        Me.btn検索日付.Text = "** Click Here **" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "返済(現引)する" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "レコードの取得日を" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "カレンダーから" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "選択してください" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(一覧表から選択することもできます)" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.btn検索日付.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(490, 287)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(42, 17)
        Me.Label1.TabIndex = 49
        Me.Label1.Text = "現況"
        '
        'btn次へ
        '
        Me.btn次へ.Location = New System.Drawing.Point(735, 316)
        Me.btn次へ.Name = "btn次へ"
        Me.btn次へ.Size = New System.Drawing.Size(96, 40)
        Me.btn次へ.TabIndex = 51
        Me.btn次へ.Text = "次へ"
        Me.btn次へ.UseVisualStyleBackColor = True
        '
        'btn続ける
        '
        Me.btn続ける.Font = New System.Drawing.Font("MS UI Gothic", 9.267326!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btn続ける.Location = New System.Drawing.Point(735, 211)
        Me.btn続ける.Name = "btn続ける"
        Me.btn続ける.Size = New System.Drawing.Size(96, 40)
        Me.btn続ける.TabIndex = 52
        Me.btn続ける.Text = "返済の" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "入力を続ける"
        Me.btn続ける.UseVisualStyleBackColor = True
        '
        'frm返済
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1264, 761)
        Me.Controls.Add(Me.btn続ける)
        Me.Controls.Add(Me.btn次へ)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btn検索日付)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txt返済日付)
        Me.Controls.Add(Me.txt取引名称)
        Me.Controls.Add(Me.txt取引区分)
        Me.Controls.Add(Me.lblE)
        Me.Controls.Add(Me.lbl定休日)
        Me.Controls.Add(Me.txt残株数)
        Me.Controls.Add(Me.lbl取得株数)
        Me.Controls.Add(Me.lblF)
        Me.Controls.Add(Me.txt銘柄名)
        Me.Controls.Add(Me.lblD)
        Me.Controls.Add(Me.lbl取得単価)
        Me.Controls.Add(Me.txt取得日)
        Me.Controls.Add(Me.txt売買差額)
        Me.Controls.Add(Me.txt返済後残株数)
        Me.Controls.Add(Me.txt取得単価)
        Me.Controls.Add(Me.txt返済株数)
        Me.Controls.Add(Me.btn登録)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.lb残株数)
        Me.Controls.Add(Me.txt検索日付)
        Me.Controls.Add(Me.txtID)
        Me.Controls.Add(Me.txt返済入力ID)
        Me.Controls.Add(Me.txt返済玉ID)
        Me.Controls.Add(Me.txt返済単価)
        Me.Controls.Add(Me.lblｘ)
        Me.Controls.Add(Me.lblB)
        Me.Controls.Add(Me.lblC)
        Me.Controls.Add(Me.lbl８)
        Me.Controls.Add(Me.lbl電話)
        Me.Controls.Add(Me.dgv未返済一覧)
        Me.Controls.Add(Me.txt銘柄コード)
        Me.Controls.Add(Me.lblA)
        Me.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3)
        Me.Name = "frm返済"
        Me.Text = "frm返済"
        CType(Me.dgv未返済一覧, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grp取引名称.ResumeLayout(False)
        Me.grp取引名称.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblA As Label
    Friend WithEvents txt銘柄コード As TextBox
    Friend WithEvents dgv未返済一覧 As DataGridView
    Friend WithEvents lbl電話 As Label
    Friend WithEvents lbl８ As Label
    Friend WithEvents lblC As Label
    Friend WithEvents lblB As Label
    Friend WithEvents lblｘ As Label
    Friend WithEvents txt返済単価 As TextBox
    Friend WithEvents txt返済玉ID As TextBox
    Friend WithEvents txt返済入力ID As TextBox
    Friend WithEvents txtID As TextBox
    Friend WithEvents txt検索日付 As TextBox
    Friend WithEvents lb残株数 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents btn登録 As Button
    Friend WithEvents txt返済株数 As TextBox
    Friend WithEvents txt取得単価 As TextBox
    Friend WithEvents txt返済後残株数 As TextBox
    Friend WithEvents txt売買差額 As TextBox
    Friend WithEvents txt取得日 As TextBox
    Friend WithEvents lbl取得単価 As Label
    Friend WithEvents lblD As Label
    Friend WithEvents txt銘柄名 As TextBox
    Friend WithEvents lblF As Label
    Friend WithEvents lbl取得株数 As Label
    Friend WithEvents txt残株数 As TextBox
    Friend WithEvents lbl定休日 As Label
    Friend WithEvents lblE As Label
    Friend WithEvents txt取引区分 As TextBox
    Friend WithEvents txt取引名称 As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txt返済日付 As TextBox
    Friend WithEvents btn検索日付 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents btn次へ As Button
    Friend WithEvents btn続ける As Button
End Class
