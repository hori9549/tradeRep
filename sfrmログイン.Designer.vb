﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class sfrmログイン
    'Inherits System.Windows.Forms.Form
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
        Me.lblメッセージ = New System.Windows.Forms.Label()
        Me.txtパスワード = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Cancel_Button = New System.Windows.Forms.Button()
        Me.btnログイン = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblメッセージ
        '
        Me.lblメッセージ.AutoSize = True
        Me.lblメッセージ.Font = New System.Drawing.Font("MS UI Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lblメッセージ.ForeColor = System.Drawing.Color.Red
        Me.lblメッセージ.Location = New System.Drawing.Point(108, 133)
        Me.lblメッセージ.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblメッセージ.Name = "lblメッセージ"
        Me.lblメッセージ.Size = New System.Drawing.Size(70, 24)
        Me.lblメッセージ.TabIndex = 111
        Me.lblメッセージ.Text = "XXXX"
        '
        'txtパスワード
        '
        Me.txtパスワード.Location = New System.Drawing.Point(225, 85)
        Me.txtパスワード.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtパスワード.Name = "txtパスワード"
        Me.txtパスワード.Size = New System.Drawing.Size(302, 31)
        Me.txtパスワード.TabIndex = 110
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("MS UI Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label2.Location = New System.Drawing.Point(108, 88)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(108, 24)
        Me.Label2.TabIndex = 108
        Me.Label2.Text = "パスワード"
        '
        'Cancel_Button
        '
        Me.Cancel_Button.Location = New System.Drawing.Point(361, 179)
        Me.Cancel_Button.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Cancel_Button.Name = "Cancel_Button"
        Me.Cancel_Button.Size = New System.Drawing.Size(166, 56)
        Me.Cancel_Button.TabIndex = 113
        Me.Cancel_Button.Text = "終了"
        Me.Cancel_Button.UseVisualStyleBackColor = True
        '
        'btnログイン
        '
        Me.btnログイン.Location = New System.Drawing.Point(113, 179)
        Me.btnログイン.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnログイン.Name = "btnログイン"
        Me.btnログイン.Size = New System.Drawing.Size(166, 56)
        Me.btnログイン.TabIndex = 112
        Me.btnログイン.Text = "ログイン"
        Me.btnログイン.UseVisualStyleBackColor = True
        '
        'sfrmログイン
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(13.0!, 24.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(697, 273)
        Me.ControlBox = False
        Me.Controls.Add(Me.Cancel_Button)
        Me.Controls.Add(Me.btnログイン)
        Me.Controls.Add(Me.lblメッセージ)
        Me.Controls.Add(Me.txtパスワード)
        Me.Controls.Add(Me.Label2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Margin = New System.Windows.Forms.Padding(10, 9, 10, 9)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "sfrmログイン"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ログイン"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblメッセージ As Label
    Friend WithEvents txtパスワード As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Cancel_Button As Button
    Friend WithEvents btnログイン As Button
End Class
