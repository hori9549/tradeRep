<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm取引集計表
    ' Inherits System.Windows.Forms.Form
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
        Me.Dgv検索結果 = New System.Windows.Forms.DataGridView()
        Me.btnエクスポート = New System.Windows.Forms.Button()
        Me.btnレシート印刷 = New System.Windows.Forms.Button()
        Me.btn集計 = New System.Windows.Forms.Button()
        Me.grp入力項目 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt銘柄コード = New System.Windows.Forms.TextBox()
        Me.dtp日付終 = New System.Windows.Forms.DateTimePicker()
        Me.Dtp日付始 = New System.Windows.Forms.DateTimePicker()
        Me.lbl集計区分 = New System.Windows.Forms.Label()
        Me.cmb出力順昇降 = New System.Windows.Forms.ComboBox()
        Me.lbl出力順 = New System.Windows.Forms.Label()
        Me.cmb出力順項目 = New System.Windows.Forms.ComboBox()
        Me.lbl部門 = New System.Windows.Forms.Label()
        Me.lblX = New System.Windows.Forms.Label()
        Me.lbl波線 = New System.Windows.Forms.Label()
        Me.cmb集計区分 = New System.Windows.Forms.ComboBox()
        Me.cmb部門 = New System.Windows.Forms.ComboBox()
        CType(Me.Dgv検索結果, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grp入力項目.SuspendLayout()
        Me.SuspendLayout()
        '
        'Dgv検索結果
        '
        Me.Dgv検索結果.AllowUserToAddRows = False
        Me.Dgv検索結果.AllowUserToDeleteRows = False
        Me.Dgv検索結果.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Dgv検索結果.Location = New System.Drawing.Point(15, 134)
        Me.Dgv検索結果.Margin = New System.Windows.Forms.Padding(4)
        Me.Dgv検索結果.Name = "Dgv検索結果"
        Me.Dgv検索結果.ReadOnly = True
        Me.Dgv検索結果.RowHeadersWidth = 51
        Me.Dgv検索結果.RowTemplate.Height = 21
        Me.Dgv検索結果.Size = New System.Drawing.Size(1153, 553)
        Me.Dgv検索結果.TabIndex = 26
        '
        'btnエクスポート
        '
        Me.btnエクスポート.Location = New System.Drawing.Point(1031, 20)
        Me.btnエクスポート.Margin = New System.Windows.Forms.Padding(4)
        Me.btnエクスポート.Name = "btnエクスポート"
        Me.btnエクスポート.Size = New System.Drawing.Size(108, 41)
        Me.btnエクスポート.TabIndex = 25
        Me.btnエクスポート.Text = "ｴｸｽﾎﾟｰﾄ"
        Me.btnエクスポート.UseVisualStyleBackColor = True
        '
        'btnレシート印刷
        '
        Me.btnレシート印刷.Location = New System.Drawing.Point(922, 20)
        Me.btnレシート印刷.Margin = New System.Windows.Forms.Padding(4)
        Me.btnレシート印刷.Name = "btnレシート印刷"
        Me.btnレシート印刷.Size = New System.Drawing.Size(108, 41)
        Me.btnレシート印刷.TabIndex = 24
        Me.btnレシート印刷.Text = "ﾚｼｰﾄ印刷"
        Me.btnレシート印刷.UseVisualStyleBackColor = True
        '
        'btn集計
        '
        Me.btn集計.Location = New System.Drawing.Point(814, 20)
        Me.btn集計.Margin = New System.Windows.Forms.Padding(4)
        Me.btn集計.Name = "btn集計"
        Me.btn集計.Size = New System.Drawing.Size(108, 41)
        Me.btn集計.TabIndex = 23
        Me.btn集計.Text = "集計"
        Me.btn集計.UseVisualStyleBackColor = True
        '
        'grp入力項目
        '
        Me.grp入力項目.Controls.Add(Me.Label1)
        Me.grp入力項目.Controls.Add(Me.txt銘柄コード)
        Me.grp入力項目.Controls.Add(Me.dtp日付終)
        Me.grp入力項目.Controls.Add(Me.Dtp日付始)
        Me.grp入力項目.Controls.Add(Me.lbl集計区分)
        Me.grp入力項目.Controls.Add(Me.cmb出力順昇降)
        Me.grp入力項目.Controls.Add(Me.lbl出力順)
        Me.grp入力項目.Controls.Add(Me.cmb出力順項目)
        Me.grp入力項目.Controls.Add(Me.lbl部門)
        Me.grp入力項目.Controls.Add(Me.lblX)
        Me.grp入力項目.Controls.Add(Me.lbl波線)
        Me.grp入力項目.Controls.Add(Me.cmb集計区分)
        Me.grp入力項目.Controls.Add(Me.cmb部門)
        Me.grp入力項目.Location = New System.Drawing.Point(15, 15)
        Me.grp入力項目.Margin = New System.Windows.Forms.Padding(4)
        Me.grp入力項目.Name = "grp入力項目"
        Me.grp入力項目.Padding = New System.Windows.Forms.Padding(4)
        Me.grp入力項目.Size = New System.Drawing.Size(788, 111)
        Me.grp入力項目.TabIndex = 22
        Me.grp入力項目.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(395, 16)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(66, 19)
        Me.Label1.TabIndex = 27
        Me.Label1.Text = "集計日"
        '
        'txt銘柄コード
        '
        Me.txt銘柄コード.Font = New System.Drawing.Font("MS UI Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.txt銘柄コード.Location = New System.Drawing.Point(101, 46)
        Me.txt銘柄コード.Margin = New System.Windows.Forms.Padding(4)
        Me.txt銘柄コード.Name = "txt銘柄コード"
        Me.txt銘柄コード.Size = New System.Drawing.Size(124, 26)
        Me.txt銘柄コード.TabIndex = 23
        Me.txt銘柄コード.Text = "6857"
        Me.txt銘柄コード.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'dtp日付終
        '
        Me.dtp日付終.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp日付終.Location = New System.Drawing.Point(641, 11)
        Me.dtp日付終.Margin = New System.Windows.Forms.Padding(4)
        Me.dtp日付終.Name = "dtp日付終"
        Me.dtp日付終.Size = New System.Drawing.Size(129, 26)
        Me.dtp日付終.TabIndex = 22
        '
        'Dtp日付始
        '
        Me.Dtp日付始.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right
        Me.Dtp日付始.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.Dtp日付始.Location = New System.Drawing.Point(475, 14)
        Me.Dtp日付始.Margin = New System.Windows.Forms.Padding(4)
        Me.Dtp日付始.Name = "Dtp日付始"
        Me.Dtp日付始.Size = New System.Drawing.Size(129, 26)
        Me.Dtp日付始.TabIndex = 21
        Me.Dtp日付始.Value = New Date(2021, 7, 13, 5, 38, 53, 0)
        '
        'lbl集計区分
        '
        Me.lbl集計区分.AutoSize = True
        Me.lbl集計区分.Location = New System.Drawing.Point(9, 20)
        Me.lbl集計区分.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl集計区分.Name = "lbl集計区分"
        Me.lbl集計区分.Size = New System.Drawing.Size(85, 19)
        Me.lbl集計区分.TabIndex = 3
        Me.lbl集計区分.Text = "集計区分"
        '
        'cmb出力順昇降
        '
        Me.cmb出力順昇降.FormattingEnabled = True
        Me.cmb出力順昇降.Items.AddRange(New Object() {"昇順"})
        Me.cmb出力順昇降.Location = New System.Drawing.Point(462, 75)
        Me.cmb出力順昇降.Margin = New System.Windows.Forms.Padding(4)
        Me.cmb出力順昇降.Name = "cmb出力順昇降"
        Me.cmb出力順昇降.Size = New System.Drawing.Size(318, 27)
        Me.cmb出力順昇降.TabIndex = 15
        Me.cmb出力順昇降.Text = "昇順"
        '
        'lbl出力順
        '
        Me.lbl出力順.BackColor = System.Drawing.Color.Green
        Me.lbl出力順.ForeColor = System.Drawing.Color.White
        Me.lbl出力順.Location = New System.Drawing.Point(380, 49)
        Me.lbl出力順.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl出力順.Name = "lbl出力順"
        Me.lbl出力順.Size = New System.Drawing.Size(75, 51)
        Me.lbl出力順.TabIndex = 4
        Me.lbl出力順.Text = "出 力 順"
        Me.lbl出力順.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cmb出力順項目
        '
        Me.cmb出力順項目.FormattingEnabled = True
        Me.cmb出力順項目.Items.AddRange(New Object() {"概算損益"})
        Me.cmb出力順項目.Location = New System.Drawing.Point(462, 46)
        Me.cmb出力順項目.Margin = New System.Windows.Forms.Padding(4)
        Me.cmb出力順項目.Name = "cmb出力順項目"
        Me.cmb出力順項目.Size = New System.Drawing.Size(318, 27)
        Me.cmb出力順項目.TabIndex = 14
        Me.cmb出力順項目.Text = "コード"
        '
        'lbl部門
        '
        Me.lbl部門.BackColor = System.Drawing.Color.Green
        Me.lbl部門.Font = New System.Drawing.Font("MS UI Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lbl部門.ForeColor = System.Drawing.Color.White
        Me.lbl部門.Location = New System.Drawing.Point(30, 75)
        Me.lbl部門.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl部門.Name = "lbl部門"
        Me.lbl部門.Size = New System.Drawing.Size(64, 25)
        Me.lbl部門.TabIndex = 5
        Me.lbl部門.Text = "部 門"
        Me.lbl部門.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblX
        '
        Me.lblX.AutoSize = True
        Me.lblX.Location = New System.Drawing.Point(9, 49)
        Me.lblX.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblX.Name = "lblX"
        Me.lblX.Size = New System.Drawing.Size(90, 19)
        Me.lblX.TabIndex = 6
        Me.lblX.Text = "銘柄コード"
        '
        'lbl波線
        '
        Me.lbl波線.AutoSize = True
        Me.lbl波線.Location = New System.Drawing.Point(612, 20)
        Me.lbl波線.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl波線.Name = "lbl波線"
        Me.lbl波線.Size = New System.Drawing.Size(28, 19)
        Me.lbl波線.TabIndex = 7
        Me.lbl波線.Text = "～"
        '
        'cmb集計区分
        '
        Me.cmb集計区分.FormattingEnabled = True
        Me.cmb集計区分.Location = New System.Drawing.Point(101, 16)
        Me.cmb集計区分.Margin = New System.Windows.Forms.Padding(4)
        Me.cmb集計区分.Name = "cmb集計区分"
        Me.cmb集計区分.Size = New System.Drawing.Size(256, 27)
        Me.cmb集計区分.TabIndex = 8
        Me.cmb集計区分.Text = " 集計区分を選択してください"
        '
        'cmb部門
        '
        Me.cmb部門.FormattingEnabled = True
        Me.cmb部門.Items.AddRange(New Object() {"信用買(返済)"})
        Me.cmb部門.Location = New System.Drawing.Point(101, 75)
        Me.cmb部門.Margin = New System.Windows.Forms.Padding(4)
        Me.cmb部門.Name = "cmb部門"
        Me.cmb部門.Size = New System.Drawing.Size(256, 27)
        Me.cmb部門.TabIndex = 9
        '
        'frm取引集計表
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1184, 761)
        Me.Controls.Add(Me.Dgv検索結果)
        Me.Controls.Add(Me.btnエクスポート)
        Me.Controls.Add(Me.btnレシート印刷)
        Me.Controls.Add(Me.btn集計)
        Me.Controls.Add(Me.grp入力項目)
        Me.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.Name = "frm取引集計表"
        Me.Text = "frm取引集計表"
        Me.Controls.SetChildIndex(Me.grp入力項目, 0)
        Me.Controls.SetChildIndex(Me.btn集計, 0)
        Me.Controls.SetChildIndex(Me.btnレシート印刷, 0)
        Me.Controls.SetChildIndex(Me.btnエクスポート, 0)
        Me.Controls.SetChildIndex(Me.Dgv検索結果, 0)
        CType(Me.Dgv検索結果, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grp入力項目.ResumeLayout(False)
        Me.grp入力項目.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Dgv検索結果 As DataGridView
    Friend WithEvents btnエクスポート As Button
    Friend WithEvents btnレシート印刷 As Button
    Friend WithEvents btn集計 As Button
    Friend WithEvents grp入力項目 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txt銘柄コード As TextBox
    Friend WithEvents dtp日付終 As DateTimePicker
    Friend WithEvents Dtp日付始 As DateTimePicker
    Friend WithEvents lbl集計区分 As Label
    Friend WithEvents cmb出力順昇降 As ComboBox
    Friend WithEvents lbl出力順 As Label
    Friend WithEvents cmb出力順項目 As ComboBox
    Friend WithEvents lbl部門 As Label
    Friend WithEvents lblX As Label
    Friend WithEvents lbl波線 As Label
    Friend WithEvents cmb集計区分 As ComboBox
    Friend WithEvents cmb部門 As ComboBox
End Class
