<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmメニュー
    'Inherits System.Windows.Forms.Form
    Inherits frmベース

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
        Me.btn企業マスタ = New System.Windows.Forms.Button()
        Me.btn会員マスタ = New System.Windows.Forms.Button()
        Me.tabManual = New System.Windows.Forms.TabControl()
        Me.tab手入力 = New System.Windows.Forms.TabPage()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.frmカレンダー表示 = New System.Windows.Forms.Button()
        Me.tabGmail = New System.Windows.Forms.TabPage()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btn会員スキルマスタ = New System.Windows.Forms.Button()
        Me.btnプロジェクトマスタ = New System.Windows.Forms.Button()
        Me.btn区分管理マスタ = New System.Windows.Forms.Button()
        Me.lblバージョン = New System.Windows.Forms.Label()
        Me.lbl日付 = New System.Windows.Forms.Label()
        Me.lbl時間 = New System.Windows.Forms.Label()
        Me.picImg = New System.Windows.Forms.PictureBox()
        Me.tabManual.SuspendLayout()
        Me.tab手入力.SuspendLayout()
        Me.tabGmail.SuspendLayout()
        CType(Me.picImg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btn企業マスタ
        '
        Me.btn企業マスタ.Location = New System.Drawing.Point(20, 71)
        Me.btn企業マスタ.Name = "btn企業マスタ"
        Me.btn企業マスタ.Size = New System.Drawing.Size(230, 45)
        Me.btn企業マスタ.TabIndex = 0
        Me.btn企業マスタ.Text = "企業マスタ"
        Me.btn企業マスタ.UseVisualStyleBackColor = True
        '
        'btn会員マスタ
        '
        Me.btn会員マスタ.Location = New System.Drawing.Point(20, 20)
        Me.btn会員マスタ.Name = "btn会員マスタ"
        Me.btn会員マスタ.Size = New System.Drawing.Size(230, 45)
        Me.btn会員マスタ.TabIndex = 1
        Me.btn会員マスタ.Text = "会員マスタ"
        Me.btn会員マスタ.UseVisualStyleBackColor = True
        '
        'tabManual
        '
        Me.tabManual.Controls.Add(Me.tab手入力)
        Me.tabManual.Controls.Add(Me.tabGmail)
        Me.tabManual.Location = New System.Drawing.Point(420, 12)
        Me.tabManual.Name = "tabManual"
        Me.tabManual.SelectedIndex = 0
        Me.tabManual.Size = New System.Drawing.Size(750, 654)
        Me.tabManual.TabIndex = 103
        '
        'tab手入力
        '
        Me.tab手入力.Controls.Add(Me.Button2)
        Me.tab手入力.Controls.Add(Me.frmカレンダー表示)
        Me.tab手入力.Location = New System.Drawing.Point(4, 29)
        Me.tab手入力.Name = "tab手入力"
        Me.tab手入力.Padding = New System.Windows.Forms.Padding(3)
        Me.tab手入力.Size = New System.Drawing.Size(742, 621)
        Me.tab手入力.TabIndex = 0
        Me.tab手入力.Text = "Manual"
        Me.tab手入力.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(9, 15)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(230, 45)
        Me.Button2.TabIndex = 3
        Me.Button2.Text = "カレンダー"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'frmカレンダー表示
        '
        Me.frmカレンダー表示.Location = New System.Drawing.Point(368, 455)
        Me.frmカレンダー表示.Name = "frmカレンダー表示"
        Me.frmカレンダー表示.Size = New System.Drawing.Size(230, 45)
        Me.frmカレンダー表示.TabIndex = 2
        Me.frmカレンダー表示.Text = "カレンダー表示"
        Me.frmカレンダー表示.UseVisualStyleBackColor = True
        '
        'tabGmail
        '
        Me.tabGmail.Controls.Add(Me.Button1)
        Me.tabGmail.Controls.Add(Me.btn会員スキルマスタ)
        Me.tabGmail.Controls.Add(Me.btnプロジェクトマスタ)
        Me.tabGmail.Controls.Add(Me.btn区分管理マスタ)
        Me.tabGmail.Controls.Add(Me.btn会員マスタ)
        Me.tabGmail.Controls.Add(Me.btn企業マスタ)
        Me.tabGmail.Location = New System.Drawing.Point(4, 29)
        Me.tabGmail.Name = "tabGmail"
        Me.tabGmail.Padding = New System.Windows.Forms.Padding(3)
        Me.tabGmail.Size = New System.Drawing.Size(742, 621)
        Me.tabGmail.TabIndex = 1
        Me.tabGmail.Text = "スプレッドS"
        Me.tabGmail.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(256, 71)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(230, 45)
        Me.Button1.TabIndex = 7
        Me.Button1.Text = "案件マスタ"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'btn会員スキルマスタ
        '
        Me.btn会員スキルマスタ.Location = New System.Drawing.Point(256, 20)
        Me.btn会員スキルマスタ.Name = "btn会員スキルマスタ"
        Me.btn会員スキルマスタ.Size = New System.Drawing.Size(230, 45)
        Me.btn会員スキルマスタ.TabIndex = 6
        Me.btn会員スキルマスタ.Text = "会員スキルマスタ"
        Me.btn会員スキルマスタ.UseVisualStyleBackColor = True
        '
        'btnプロジェクトマスタ
        '
        Me.btnプロジェクトマスタ.Location = New System.Drawing.Point(492, 20)
        Me.btnプロジェクトマスタ.Name = "btnプロジェクトマスタ"
        Me.btnプロジェクトマスタ.Size = New System.Drawing.Size(230, 45)
        Me.btnプロジェクトマスタ.TabIndex = 5
        Me.btnプロジェクトマスタ.Text = "プロジェクトマスタ"
        Me.btnプロジェクトマスタ.UseVisualStyleBackColor = True
        '
        'btn区分管理マスタ
        '
        Me.btn区分管理マスタ.Location = New System.Drawing.Point(256, 560)
        Me.btn区分管理マスタ.Name = "btn区分管理マスタ"
        Me.btn区分管理マスタ.Size = New System.Drawing.Size(230, 45)
        Me.btn区分管理マスタ.TabIndex = 3
        Me.btn区分管理マスタ.Text = "区分管理マスタ"
        Me.btn区分管理マスタ.UseVisualStyleBackColor = True
        '
        'lblバージョン
        '
        Me.lblバージョン.AutoSize = True
        Me.lblバージョン.BackColor = System.Drawing.Color.White
        Me.lblバージョン.Location = New System.Drawing.Point(162, 340)
        Me.lblバージョン.Name = "lblバージョン"
        Me.lblバージョン.Size = New System.Drawing.Size(93, 19)
        Me.lblバージョン.TabIndex = 104
        Me.lblバージョン.Text = "ver 0.0.0.0"
        '
        'lbl日付
        '
        Me.lbl日付.AutoSize = True
        Me.lbl日付.Font = New System.Drawing.Font("MS UI Gothic", 30.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lbl日付.Location = New System.Drawing.Point(92, 466)
        Me.lbl日付.Name = "lbl日付"
        Me.lbl日付.Size = New System.Drawing.Size(231, 40)
        Me.lbl日付.TabIndex = 105
        Me.lbl日付.Text = "yyyy/mm/dd"
        '
        'lbl時間
        '
        Me.lbl時間.AutoSize = True
        Me.lbl時間.Font = New System.Drawing.Font("MS UI Gothic", 30.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lbl時間.Location = New System.Drawing.Point(141, 529)
        Me.lbl時間.Name = "lbl時間"
        Me.lbl時間.Size = New System.Drawing.Size(135, 40)
        Me.lbl時間.TabIndex = 106
        Me.lbl時間.Text = "HH:mm"
        '
        'picImg
        '
        Me.picImg.Location = New System.Drawing.Point(12, 12)
        Me.picImg.Name = "picImg"
        Me.picImg.Size = New System.Drawing.Size(400, 400)
        Me.picImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picImg.TabIndex = 102
        Me.picImg.TabStop = False
        '
        'frmメニュー
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1184, 741)
        Me.Controls.Add(Me.lbl時間)
        Me.Controls.Add(Me.lbl日付)
        Me.Controls.Add(Me.lblバージョン)
        Me.Controls.Add(Me.tabManual)
        Me.Controls.Add(Me.picImg)
        Me.Margin = New System.Windows.Forms.Padding(8)
        Me.Name = "frmメニュー"
        Me.Text = "カシオペイア"
        Me.Controls.SetChildIndex(Me.picImg, 0)
        Me.Controls.SetChildIndex(Me.tabManual, 0)
        Me.Controls.SetChildIndex(Me.lblバージョン, 0)
        Me.Controls.SetChildIndex(Me.lbl日付, 0)
        Me.Controls.SetChildIndex(Me.lbl時間, 0)
        Me.tabManual.ResumeLayout(False)
        Me.tab手入力.ResumeLayout(False)
        Me.tabGmail.ResumeLayout(False)
        CType(Me.picImg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btn企業マスタ As Button
    Friend WithEvents btn会員マスタ As Button
    Public WithEvents picImg As PictureBox
    Friend WithEvents tabManual As TabControl
    Friend WithEvents tab手入力 As TabPage
    Friend WithEvents tabGmail As TabPage
    Friend WithEvents btn区分管理マスタ As Button
    Friend WithEvents lblバージョン As Label
    Friend WithEvents lbl日付 As Label
    Friend WithEvents lbl時間 As Label
    Friend WithEvents btnプロジェクトマスタ As Button
    Friend WithEvents btn会員スキルマスタ As Button
    Friend WithEvents frmカレンダー表示 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
End Class
