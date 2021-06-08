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
        Me.txt株数 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt価格 = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txt決済日付 = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'txt銘柄コード
        '
        Me.txt銘柄コード.Location = New System.Drawing.Point(610, 87)
        Me.txt銘柄コード.Name = "txt銘柄コード"
        Me.txt銘柄コード.Size = New System.Drawing.Size(146, 26)
        Me.txt銘柄コード.TabIndex = 0
        Me.txt銘柄コード.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(514, 90)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(90, 19)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "銘柄コード"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(533, 140)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(66, 19)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "銘柄名"
        '
        'txt銘柄名
        '
        Me.txt銘柄名.Location = New System.Drawing.Point(610, 133)
        Me.txt銘柄名.Name = "txt銘柄名"
        Me.txt銘柄名.Size = New System.Drawing.Size(146, 26)
        Me.txt銘柄名.TabIndex = 2
        Me.txt銘柄名.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(543, 188)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(47, 19)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "株数"
        '
        'txt株数
        '
        Me.txt株数.Location = New System.Drawing.Point(610, 181)
        Me.txt株数.Name = "txt株数"
        Me.txt株数.Size = New System.Drawing.Size(146, 26)
        Me.txt株数.TabIndex = 4
        Me.txt株数.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(543, 244)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(47, 19)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "価格"
        '
        'txt価格
        '
        Me.txt価格.Location = New System.Drawing.Point(610, 237)
        Me.txt価格.Name = "txt価格"
        Me.txt価格.Size = New System.Drawing.Size(146, 26)
        Me.txt価格.TabIndex = 6
        Me.txt価格.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(514, 294)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(85, 19)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "決済日付"
        '
        'txt決済日付
        '
        Me.txt決済日付.Location = New System.Drawing.Point(610, 287)
        Me.txt決済日付.Name = "txt決済日付"
        Me.txt決済日付.Size = New System.Drawing.Size(146, 26)
        Me.txt決済日付.TabIndex = 8
        Me.txt決済日付.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'sfrmExcel返済
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txt決済日付)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txt価格)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txt株数)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txt銘柄名)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txt銘柄コード)
        Me.Name = "sfrmExcel返済"
        Me.Text = "sfrmExcel返済"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txt銘柄コード As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txt銘柄名 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txt株数 As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txt価格 As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txt決済日付 As TextBox
End Class
