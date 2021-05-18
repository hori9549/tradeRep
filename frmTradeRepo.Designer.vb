<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTradeRepo
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
        Me.btn返済入力 = New System.Windows.Forms.Button()
        Me.btn新規建入力 = New System.Windows.Forms.Button()
        Me.btn取引日付 = New System.Windows.Forms.Button()
        Me.txt取得日付 = New System.Windows.Forms.TextBox()
        Me.btnCallExcel = New System.Windows.Forms.Button()
        Me.dgv直近一覧 = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.dgv直近一覧, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btn返済入力
        '
        Me.btn返済入力.Location = New System.Drawing.Point(218, 283)
        Me.btn返済入力.Name = "btn返済入力"
        Me.btn返済入力.Size = New System.Drawing.Size(147, 74)
        Me.btn返済入力.TabIndex = 5
        Me.btn返済入力.Text = "返済入力(R)"
        Me.btn返済入力.UseVisualStyleBackColor = True
        '
        'btn新規建入力
        '
        Me.btn新規建入力.Font = New System.Drawing.Font("MS UI Gothic", 9.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btn新規建入力.Location = New System.Drawing.Point(218, 177)
        Me.btn新規建入力.Name = "btn新規建入力"
        Me.btn新規建入力.Size = New System.Drawing.Size(147, 74)
        Me.btn新規建入力.TabIndex = 4
        Me.btn新規建入力.Text = "新規建入力(&N)"
        Me.btn新規建入力.UseVisualStyleBackColor = True
        '
        'btn取引日付
        '
        Me.btn取引日付.Location = New System.Drawing.Point(72, 25)
        Me.btn取引日付.Name = "btn取引日付"
        Me.btn取引日付.Size = New System.Drawing.Size(195, 123)
        Me.btn取引日付.TabIndex = 1
        Me.btn取引日付.Text = "-- Click Here --" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "何日の取引を" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "記帳しますか？" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "カレンダーから" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "選択してください。"
        Me.btn取引日付.UseVisualStyleBackColor = True
        '
        'txt取得日付
        '
        Me.txt取得日付.BackColor = System.Drawing.Color.White
        Me.txt取得日付.Enabled = False
        Me.txt取得日付.Font = New System.Drawing.Font("MS UI Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.txt取得日付.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txt取得日付.ImeMode = System.Windows.Forms.ImeMode.Disable
        Me.txt取得日付.Location = New System.Drawing.Point(295, 102)
        Me.txt取得日付.MaxLength = 15
        Me.txt取得日付.Name = "txt取得日付"
        Me.txt取得日付.ReadOnly = True
        Me.txt取得日付.Size = New System.Drawing.Size(200, 26)
        Me.txt取得日付.TabIndex = 2
        Me.txt取得日付.TabStop = False
        Me.txt取得日付.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnCallExcel
        '
        Me.btnCallExcel.Location = New System.Drawing.Point(772, 84)
        Me.btnCallExcel.Margin = New System.Windows.Forms.Padding(5)
        Me.btnCallExcel.Name = "btnCallExcel"
        Me.btnCallExcel.Size = New System.Drawing.Size(223, 93)
        Me.btnCallExcel.TabIndex = 6
        Me.btnCallExcel.Text = "excelTest"
        Me.btnCallExcel.UseVisualStyleBackColor = True
        '
        'dgv直近一覧
        '
        Me.dgv直近一覧.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv直近一覧.Location = New System.Drawing.Point(15, 388)
        Me.dgv直近一覧.Name = "dgv直近一覧"
        Me.dgv直近一覧.RowHeadersWidth = 51
        Me.dgv直近一覧.RowTemplate.Height = 24
        Me.dgv直近一覧.Size = New System.Drawing.Size(1273, 236)
        Me.dgv直近一覧.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("MS UI Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label1.Location = New System.Drawing.Point(512, 105)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 39)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "この日の" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "取引を" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "記帳します。"
        '
        'frmTradeRepo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1184, 761)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dgv直近一覧)
        Me.Controls.Add(Me.btnCallExcel)
        Me.Controls.Add(Me.btn取引日付)
        Me.Controls.Add(Me.txt取得日付)
        Me.Controls.Add(Me.btn新規建入力)
        Me.Controls.Add(Me.btn返済入力)
        Me.Margin = New System.Windows.Forms.Padding(7, 8, 7, 8)
        Me.Name = "frmTradeRepo"
        Me.Text = "TradingReport"
        Me.Controls.SetChildIndex(Me.btn返済入力, 0)
        Me.Controls.SetChildIndex(Me.btn新規建入力, 0)
        Me.Controls.SetChildIndex(Me.txt取得日付, 0)
        Me.Controls.SetChildIndex(Me.btn取引日付, 0)
        Me.Controls.SetChildIndex(Me.btnCallExcel, 0)
        Me.Controls.SetChildIndex(Me.dgv直近一覧, 0)
        Me.Controls.SetChildIndex(Me.Label1, 0)
        CType(Me.dgv直近一覧, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btn返済入力 As Button
    Friend WithEvents btn新規建入力 As Button
    Friend WithEvents btn取引日付 As Button
    Friend WithEvents txt取得日付 As TextBox
    Friend WithEvents btnCallExcel As Button
    Friend WithEvents dgv直近一覧 As DataGridView
    Friend WithEvents Label1 As Label
End Class
