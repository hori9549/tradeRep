<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmメニュー2
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
        Me.pcbTop = New System.Windows.Forms.PictureBox()
        Me.grp導入 = New System.Windows.Forms.GroupBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        CType(Me.pcbTop, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grp導入.SuspendLayout()
        Me.SuspendLayout()
        '
        'pcbTop
        '
        Me.pcbTop.Image = Global.カシオペイア.My.Resources.Resources.虫眼鏡イラストS
        Me.pcbTop.Location = New System.Drawing.Point(12, 12)
        Me.pcbTop.Name = "pcbTop"
        Me.pcbTop.Size = New System.Drawing.Size(249, 193)
        Me.pcbTop.TabIndex = 0
        Me.pcbTop.TabStop = False
        '
        'grp導入
        '
        Me.grp導入.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.grp導入.Controls.Add(Me.Button2)
        Me.grp導入.Controls.Add(Me.Button1)
        Me.grp導入.Location = New System.Drawing.Point(370, 37)
        Me.grp導入.Name = "grp導入"
        Me.grp導入.Size = New System.Drawing.Size(284, 132)
        Me.grp導入.TabIndex = 1
        Me.grp導入.TabStop = False
        Me.grp導入.Text = "導入処理"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Chartreuse
        Me.Button1.Location = New System.Drawing.Point(53, 28)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(170, 36)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.LawnGreen
        Me.Button2.Location = New System.Drawing.Point(53, 79)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(170, 36)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "Button2"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'frmメニュー2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.grp導入)
        Me.Controls.Add(Me.pcbTop)
        Me.Name = "frmメニュー2"
        Me.Text = "frmメニュー2"
        CType(Me.pcbTop, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grp導入.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pcbTop As PictureBox
    Friend WithEvents grp導入 As GroupBox
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
End Class
