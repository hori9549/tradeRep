﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Me.txtg銘柄コード = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtg銘柄名 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtg株数 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtg価格 = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtg日付 = New System.Windows.Forms.TextBox()
        Me.dgv返済玉 = New System.Windows.Forms.DataGridView()
        Me.Label6 = New System.Windows.Forms.Label()
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
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.txtg取引名称 = New System.Windows.Forms.TextBox()
        Me.txt現況 = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        CType(Me.dgv返済玉, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtg銘柄コード
        '
        Me.txtg銘柄コード.Location = New System.Drawing.Point(779, 85)
        Me.txtg銘柄コード.Name = "txtg銘柄コード"
        Me.txtg銘柄コード.Size = New System.Drawing.Size(146, 26)
        Me.txtg銘柄コード.TabIndex = 0
        Me.txtg銘柄コード.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(674, 88)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(99, 19)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "g銘柄コード"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(698, 133)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(75, 19)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "g銘柄名"
        '
        'txtg銘柄名
        '
        Me.txtg銘柄名.Location = New System.Drawing.Point(779, 130)
        Me.txtg銘柄名.Name = "txtg銘柄名"
        Me.txtg銘柄名.Size = New System.Drawing.Size(146, 26)
        Me.txtg銘柄名.TabIndex = 2
        Me.txtg銘柄名.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(717, 184)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(56, 19)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "g株数"
        '
        'txtg株数
        '
        Me.txtg株数.Location = New System.Drawing.Point(779, 175)
        Me.txtg株数.Name = "txtg株数"
        Me.txtg株数.Size = New System.Drawing.Size(146, 26)
        Me.txtg株数.TabIndex = 4
        Me.txtg株数.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(717, 223)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(56, 19)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "g価格"
        '
        'txtg価格
        '
        Me.txtg価格.Location = New System.Drawing.Point(779, 220)
        Me.txtg価格.Name = "txtg価格"
        Me.txtg価格.Size = New System.Drawing.Size(146, 26)
        Me.txtg価格.TabIndex = 6
        Me.txtg価格.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(717, 268)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(56, 19)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "g日付"
        '
        'txtg日付
        '
        Me.txtg日付.Location = New System.Drawing.Point(779, 265)
        Me.txtg日付.Name = "txtg日付"
        Me.txtg日付.Size = New System.Drawing.Size(146, 26)
        Me.txtg日付.TabIndex = 8
        Me.txtg日付.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'dgv返済玉
        '
        Me.dgv返済玉.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv返済玉.Location = New System.Drawing.Point(12, 359)
        Me.dgv返済玉.Name = "dgv返済玉"
        Me.dgv返済玉.RowHeadersWidth = 51
        Me.dgv返済玉.RowTemplate.Height = 21
        Me.dgv返済玉.Size = New System.Drawing.Size(901, 138)
        Me.dgv返済玉.TabIndex = 10
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(12, 336)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(197, 19)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "返済対象建玉をえらんで"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(38, 101)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(146, 19)
        Me.Label8.TabIndex = 19
        Me.Label8.Text = "txt返済玉銘柄名"
        '
        'txt返済玉銘柄名
        '
        Me.txt返済玉銘柄名.Location = New System.Drawing.Point(188, 96)
        Me.txt返済玉銘柄名.Name = "txt返済玉銘柄名"
        Me.txt返済玉銘柄名.Size = New System.Drawing.Size(146, 26)
        Me.txt返済玉銘柄名.TabIndex = 18
        Me.txt返済玉銘柄名.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(12, 74)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(170, 19)
        Me.Label9.TabIndex = 17
        Me.Label9.Text = "txt返済玉銘柄コード"
        '
        'txt返済玉銘柄コード
        '
        Me.txt返済玉銘柄コード.Location = New System.Drawing.Point(188, 71)
        Me.txt返済玉銘柄コード.Name = "txt返済玉銘柄コード"
        Me.txt返済玉銘柄コード.Size = New System.Drawing.Size(146, 26)
        Me.txt返済玉銘柄コード.TabIndex = 16
        Me.txt返済玉銘柄コード.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(38, 43)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(144, 19)
        Me.Label10.TabIndex = 15
        Me.Label10.Text = "txt返済玉入力ID"
        '
        'txt返済玉入力ID
        '
        Me.txt返済玉入力ID.Location = New System.Drawing.Point(188, 40)
        Me.txt返済玉入力ID.Name = "txt返済玉入力ID"
        Me.txt返済玉入力ID.Size = New System.Drawing.Size(146, 26)
        Me.txt返済玉入力ID.TabIndex = 14
        Me.txt返済玉入力ID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(76, 10)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(106, 19)
        Me.Label11.TabIndex = 13
        Me.Label11.Text = "txt返済玉ID"
        '
        'txt返済玉ID
        '
        Me.txt返済玉ID.Location = New System.Drawing.Point(188, 10)
        Me.txt返済玉ID.Name = "txt返済玉ID"
        Me.txt返済玉ID.Size = New System.Drawing.Size(146, 26)
        Me.txt返済玉ID.TabIndex = 12
        Me.txt返済玉ID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(35, 238)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(146, 19)
        Me.Label12.TabIndex = 27
        Me.Label12.Text = "txt返済玉取得日"
        '
        'txt返済玉取得日
        '
        Me.txt返済玉取得日.Location = New System.Drawing.Point(187, 230)
        Me.txt返済玉取得日.Name = "txt返済玉取得日"
        Me.txt返済玉取得日.Size = New System.Drawing.Size(146, 26)
        Me.txt返済玉取得日.TabIndex = 26
        Me.txt返済玉取得日.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(54, 212)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(127, 19)
        Me.Label13.TabIndex = 25
        Me.Label13.Text = "txt返済玉価格"
        '
        'txt返済玉価格
        '
        Me.txt返済玉価格.Location = New System.Drawing.Point(187, 205)
        Me.txt返済玉価格.Name = "txt返済玉価格"
        Me.txt返済玉価格.Size = New System.Drawing.Size(146, 26)
        Me.txt返済玉価格.TabIndex = 24
        Me.txt返済玉価格.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(35, 188)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(108, 19)
        Me.Label14.TabIndex = 23
        Me.Label14.Text = "txt返済株数"
        '
        'txt返済株数
        '
        Me.txt返済株数.Location = New System.Drawing.Point(187, 181)
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
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(112, 279)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(47, 19)
        Me.Label18.TabIndex = 51
        Me.Label18.Text = "現況"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(674, 45)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(94, 19)
        Me.Label19.TabIndex = 54
        Me.Label19.Text = "g取引種別"
        '
        'txtg取引名称
        '
        Me.txtg取引名称.Location = New System.Drawing.Point(780, 40)
        Me.txtg取引名称.Name = "txtg取引名称"
        Me.txtg取引名称.Size = New System.Drawing.Size(146, 26)
        Me.txtg取引名称.TabIndex = 53
        Me.txtg取引名称.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt現況
        '
        Me.txt現況.Location = New System.Drawing.Point(188, 272)
        Me.txt現況.Name = "txt現況"
        Me.txt現況.Size = New System.Drawing.Size(146, 26)
        Me.txt現況.TabIndex = 55
        Me.txt現況.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.ForeColor = System.Drawing.Color.DarkGreen
        Me.Label7.Location = New System.Drawing.Point(712, 10)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(142, 19)
        Me.Label7.TabIndex = 56
        Me.Label7.Text = "ExcelGmailデータ"
        '
        'sfrmExcel返済
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(946, 511)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txt現況)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.txtg取引名称)
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
        Me.Controls.Add(Me.txtg日付)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtg価格)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtg株数)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtg銘柄名)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtg銘柄コード)
        Me.Name = "sfrmExcel返済"
        Me.Text = "sfrmExcel返済"
        CType(Me.dgv返済玉, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtg銘柄コード As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtg銘柄名 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtg株数 As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtg価格 As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtg日付 As TextBox
    Friend WithEvents dgv返済玉 As DataGridView
    Friend WithEvents Label6 As Label
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
    Friend WithEvents Label18 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents txtg取引名称 As TextBox
    Friend WithEvents txt現況 As TextBox
    Friend WithEvents Label7 As Label
End Class
