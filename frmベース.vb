Public Class frmベース
    Private Sub Template_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BackColorChg(sender)
    End Sub

    Public Shared Sub BackColorChg(ByVal sender As System.Object)
        'コントロールをループで取得する
        For Each c As Control In sender.Controls
            'テキストボックス、ボタン、リストボックス、コンボボックスだったらイベント埋め込み 
            If c.GetType Is GetType(System.Windows.Forms.TextBox) Or
                c.GetType Is GetType(System.Windows.Forms.Button) Or
                c.GetType Is GetType(System.Windows.Forms.ListBox) Or
                c.GetType Is GetType(System.Windows.Forms.ComboBox) Then

                AddHandler c.Enter, AddressOf TextBox_GotFocus
                AddHandler c.Leave, AddressOf TextBox_LostFocus
            ElseIf c.GetType Is GetType(System.Windows.Forms.GroupBox) Or
                c.GetType Is GetType(System.Windows.Forms.TabControl) Or
                c.GetType Is GetType(System.Windows.Forms.TabPage) Then
                Call BackColorChg(c)
            End If
        Next
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()

    End Sub
    Private Sub frmEnterNext_KeyDown(ByVal sender As Object,
                                     ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown

        If e.KeyCode = Keys.Enter Then
            If e.Control = False Then
                '[Enter]キーで次の TabIndex があるコントロールへフォーカスを移す
                Me.SelectNextControl(Me.ActiveControl, Not e.Shift, True, True, True)
            End If
        End If
    End Sub

    Private Sub frmEnterNext_KeyPress(ByVal sender As Object,
                                      ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles MyBase.KeyPress
        If e.KeyChar = ControlChars.Cr Then
            '[Enter]キーで音が出るので、キーイベントが処理されたことにして音を消す
            e.Handled = True
        End If
    End Sub

    '元のカラーを保存しておく変数
    Private Shared BeforeBackColor As Color '元のカラー

    ''フォーカス取得時のイベント
    Public Shared Sub TextBox_GotFocus(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'If BeforeSenderName.Equals(sender.name) Then Return
        Dim cn As Control = sender
        BeforeBackColor = cn.BackColor  '元のカラーを退避
        sender.BackColor = Color.Pink      'カラー変更
    End Sub

    ''フォーカス移動後のイベント
    Public Shared Sub TextBox_LostFocus(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'If Not BeforeSenderName.Equals(sender.name) Then Return
        sender.BackColor = BeforeBackColor  '元のカラーに戻す。
        If sender.GetType Is GetType(System.Windows.Forms.Button) Then
            sender.UseVisualStyleBackColor = True
        End If
    End Sub


End Class