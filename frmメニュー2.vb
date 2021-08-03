Public Class frmメニュー2
    Private Sub frmメニュー2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim sfrm As New sfrmログイン
        Select Case sfrm.ShowDialog()
            Case DialogResult.OK
            Case Else
                Call Application.Exit()
        End Select

        lblVersion.Text = "Ver" + System.Reflection.Assembly.GetExecutingAssembly().GetName().Version.ToString()

        ''環境設定読み込み
        '  my環境設定 = New cls環境設定        'どのFormからも見えるようにModule内に定義している

    End Sub
    Private Sub frmメニュー2_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        ''環境設定読み込み
        my環境設定 = New cls環境設定
    End Sub

End Class