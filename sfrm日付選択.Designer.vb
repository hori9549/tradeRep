<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class sfrm日付選択
    Inherits System.Windows.Forms.Form

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
        Me.btn取消 = New System.Windows.Forms.Button()
        Me.mcd日付選択 = New System.Windows.Forms.MonthCalendar()
        Me.SuspendLayout()
        '
        'btn取消
        '
        Me.btn取消.Location = New System.Drawing.Point(141, 283)
        Me.btn取消.Margin = New System.Windows.Forms.Padding(2)
        Me.btn取消.Name = "btn取消"
        Me.btn取消.Size = New System.Drawing.Size(56, 33)
        Me.btn取消.TabIndex = 9
        Me.btn取消.Text = "取消"
        Me.btn取消.UseVisualStyleBackColor = True
        '
        'mcd日付選択
        '
        Me.mcd日付選択.Location = New System.Drawing.Point(93, 52)
        Me.mcd日付選択.Name = "mcd日付選択"
        Me.mcd日付選択.TabIndex = 10
        '
        'sfrm日付選択
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(381, 392)
        Me.Controls.Add(Me.mcd日付選択)
        Me.Controls.Add(Me.btn取消)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "sfrm日付選択"
        Me.Text = "日付を選択してください"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btn取消 As Button
    Friend WithEvents mcd日付選択 As MonthCalendar
End Class
