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
        Me.tab入力 = New System.Windows.Forms.TabPage()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.btnCallExcel = New System.Windows.Forms.Button()
        Me.tab分析 = New System.Windows.Forms.TabPage()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btn会員スキルマスタ = New System.Windows.Forms.Button()
        Me.btnプロジェクトマスタ = New System.Windows.Forms.Button()
        Me.btn区分管理マスタ = New System.Windows.Forms.Button()
        Me.lblバージョン = New System.Windows.Forms.Label()
        Me.lbl日付 = New System.Windows.Forms.Label()
        Me.lbl時間 = New System.Windows.Forms.Label()
        Me.picImg = New System.Windows.Forms.PictureBox()
        Me.tabManual.SuspendLayout()
        Me.tab入力.SuspendLayout()
        Me.tab分析.SuspendLayout()
        CType(Me.picImg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btn企業マスタ
        '
        Me.btn企業マスタ.Location = New System.Drawing.Point(24, 86)
        Me.btn企業マスタ.Margin = New System.Windows.Forms.Padding(4)
        Me.btn企業マスタ.Name = "btn企業マスタ"
        Me.btn企業マスタ.Size = New System.Drawing.Size(276, 54)
        Me.btn企業マスタ.TabIndex = 0
        Me.btn企業マスタ.Text = "企業マスタ"
        Me.btn企業マスタ.UseVisualStyleBackColor = True
        '
        'btn会員マスタ
        '
        Me.btn会員マスタ.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btn会員マスタ.Location = New System.Drawing.Point(313, 188)
        Me.btn会員マスタ.Margin = New System.Windows.Forms.Padding(4)
        Me.btn会員マスタ.Name = "btn会員マスタ"
        Me.btn会員マスタ.Size = New System.Drawing.Size(276, 54)
        Me.btn会員マスタ.TabIndex = 1
        Me.btn会員マスタ.Text = "集計表"
        Me.btn会員マスタ.UseVisualStyleBackColor = False
        '
        'tabManual
        '
        Me.tabManual.Controls.Add(Me.tab入力)
        Me.tabManual.Controls.Add(Me.tab分析)
        Me.tabManual.Location = New System.Drawing.Point(504, 15)
        Me.tabManual.Margin = New System.Windows.Forms.Padding(4)
        Me.tabManual.Name = "tabManual"
        Me.tabManual.SelectedIndex = 0
        Me.tabManual.Size = New System.Drawing.Size(900, 792)
        Me.tabManual.TabIndex = 103
        '
        'tab入力
        '
        Me.tab入力.Controls.Add(Me.Button2)
        Me.tab入力.Controls.Add(Me.btnCallExcel)
        Me.tab入力.Location = New System.Drawing.Point(4, 33)
        Me.tab入力.Margin = New System.Windows.Forms.Padding(4)
        Me.tab入力.Name = "tab入力"
        Me.tab入力.Padding = New System.Windows.Forms.Padding(4)
        Me.tab入力.Size = New System.Drawing.Size(892, 755)
        Me.tab入力.TabIndex = 0
        Me.tab入力.Text = "入力"
        Me.tab入力.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(11, 18)
        Me.Button2.Margin = New System.Windows.Forms.Padding(4)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(276, 54)
        Me.Button2.TabIndex = 3
        Me.Button2.Text = "Manyual入力"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'btnCallExcel
        '
        Me.btnCallExcel.Location = New System.Drawing.Point(442, 551)
        Me.btnCallExcel.Margin = New System.Windows.Forms.Padding(4)
        Me.btnCallExcel.Name = "btnCallExcel"
        Me.btnCallExcel.Size = New System.Drawing.Size(276, 54)
        Me.btnCallExcel.TabIndex = 2
        Me.btnCallExcel.Text = "excel約定通知から"
        Me.btnCallExcel.UseVisualStyleBackColor = True
        '
        'tab分析
        '
        Me.tab分析.Controls.Add(Me.Button1)
        Me.tab分析.Controls.Add(Me.btn会員スキルマスタ)
        Me.tab分析.Controls.Add(Me.btnプロジェクトマスタ)
        Me.tab分析.Controls.Add(Me.btn区分管理マスタ)
        Me.tab分析.Controls.Add(Me.btn会員マスタ)
        Me.tab分析.Controls.Add(Me.btn企業マスタ)
        Me.tab分析.Location = New System.Drawing.Point(4, 33)
        Me.tab分析.Margin = New System.Windows.Forms.Padding(4)
        Me.tab分析.Name = "tab分析"
        Me.tab分析.Padding = New System.Windows.Forms.Padding(4)
        Me.tab分析.Size = New System.Drawing.Size(892, 755)
        Me.tab分析.TabIndex = 1
        Me.tab分析.Text = "分析"
        Me.tab分析.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(307, 86)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(276, 54)
        Me.Button1.TabIndex = 7
        Me.Button1.Text = "案件マスタ"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'btn会員スキルマスタ
        '
        Me.btn会員スキルマスタ.Location = New System.Drawing.Point(307, 24)
        Me.btn会員スキルマスタ.Margin = New System.Windows.Forms.Padding(4)
        Me.btn会員スキルマスタ.Name = "btn会員スキルマスタ"
        Me.btn会員スキルマスタ.Size = New System.Drawing.Size(276, 54)
        Me.btn会員スキルマスタ.TabIndex = 6
        Me.btn会員スキルマスタ.Text = "会員スキルマスタ"
        Me.btn会員スキルマスタ.UseVisualStyleBackColor = True
        '
        'btnプロジェクトマスタ
        '
        Me.btnプロジェクトマスタ.Location = New System.Drawing.Point(590, 24)
        Me.btnプロジェクトマスタ.Margin = New System.Windows.Forms.Padding(4)
        Me.btnプロジェクトマスタ.Name = "btnプロジェクトマスタ"
        Me.btnプロジェクトマスタ.Size = New System.Drawing.Size(276, 54)
        Me.btnプロジェクトマスタ.TabIndex = 5
        Me.btnプロジェクトマスタ.Text = "プロジェクトマスタ"
        Me.btnプロジェクトマスタ.UseVisualStyleBackColor = True
        '
        'btn区分管理マスタ
        '
        Me.btn区分管理マスタ.Location = New System.Drawing.Point(307, 678)
        Me.btn区分管理マスタ.Margin = New System.Windows.Forms.Padding(4)
        Me.btn区分管理マスタ.Name = "btn区分管理マスタ"
        Me.btn区分管理マスタ.Size = New System.Drawing.Size(276, 54)
        Me.btn区分管理マスタ.TabIndex = 3
        Me.btn区分管理マスタ.Text = "区分管理マスタ"
        Me.btn区分管理マスタ.UseVisualStyleBackColor = True
        '
        'lblバージョン
        '
        Me.lblバージョン.AutoSize = True
        Me.lblバージョン.BackColor = System.Drawing.Color.White
        Me.lblバージョン.Location = New System.Drawing.Point(194, 412)
        Me.lblバージョン.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblバージョン.Name = "lblバージョン"
        Me.lblバージョン.Size = New System.Drawing.Size(111, 24)
        Me.lblバージョン.TabIndex = 104
        Me.lblバージョン.Text = "ver 0.0.0.0"
        '
        'lbl日付
        '
        Me.lbl日付.AutoSize = True
        Me.lbl日付.Font = New System.Drawing.Font("MS UI Gothic", 30.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lbl日付.Location = New System.Drawing.Point(110, 564)
        Me.lbl日付.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl日付.Name = "lbl日付"
        Me.lbl日付.Size = New System.Drawing.Size(292, 50)
        Me.lbl日付.TabIndex = 105
        Me.lbl日付.Text = "yyyy/mm/dd"
        '
        'lbl時間
        '
        Me.lbl時間.AutoSize = True
        Me.lbl時間.Font = New System.Drawing.Font("MS UI Gothic", 30.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lbl時間.Location = New System.Drawing.Point(169, 640)
        Me.lbl時間.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl時間.Name = "lbl時間"
        Me.lbl時間.Size = New System.Drawing.Size(170, 50)
        Me.lbl時間.TabIndex = 106
        Me.lbl時間.Text = "HH:mm"
        '
        'picImg
        '
        Me.picImg.Location = New System.Drawing.Point(14, 15)
        Me.picImg.Margin = New System.Windows.Forms.Padding(4)
        Me.picImg.Name = "picImg"
        Me.picImg.Size = New System.Drawing.Size(480, 484)
        Me.picImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picImg.TabIndex = 102
        Me.picImg.TabStop = False
        '
        'frmメニュー
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 23.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1421, 897)
        Me.Controls.Add(Me.lbl時間)
        Me.Controls.Add(Me.lbl日付)
        Me.Controls.Add(Me.lblバージョン)
        Me.Controls.Add(Me.tabManual)
        Me.Controls.Add(Me.picImg)
        Me.Margin = New System.Windows.Forms.Padding(10)
        Me.Name = "frmメニュー"
        Me.Text = "カシオペイア"
        Me.Controls.SetChildIndex(Me.picImg, 0)
        Me.Controls.SetChildIndex(Me.tabManual, 0)
        Me.Controls.SetChildIndex(Me.lblバージョン, 0)
        Me.Controls.SetChildIndex(Me.lbl日付, 0)
        Me.Controls.SetChildIndex(Me.lbl時間, 0)
        Me.tabManual.ResumeLayout(False)
        Me.tab入力.ResumeLayout(False)
        Me.tab分析.ResumeLayout(False)
        CType(Me.picImg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btn企業マスタ As Button
    Friend WithEvents btn会員マスタ As Button
    Public WithEvents picImg As PictureBox
    Friend WithEvents tabManual As TabControl
    Friend WithEvents tab入力 As TabPage
    Friend WithEvents tab分析 As TabPage
    Friend WithEvents btn区分管理マスタ As Button
    Friend WithEvents lblバージョン As Label
    Friend WithEvents lbl日付 As Label
    Friend WithEvents lbl時間 As Label
    Friend WithEvents btnプロジェクトマスタ As Button
    Friend WithEvents btn会員スキルマスタ As Button
    Friend WithEvents btnCallExcel As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
End Class
