Public Class frmメニュー

    Private Shared _mutex As System.Threading.Mutex
    Private OpenForm As Form

    Private Sub frmメニュー_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim sfrm As New sfrmログイン
        Select Case sfrm.ShowDialog()
            Case DialogResult.OK
            Case Else
                Call Application.Exit()
        End Select

        lblバージョン.Text = "Ver" + System.Reflection.Assembly.GetExecutingAssembly().GetName().Version.ToString()

        ''環境設定読み込み
        '  my環境設定 = New cls環境設定        'どのFormからも見えるようにModule内に定義している


        lbl日付.Text = Now.Date.ToString("yyyy/MM/dd（ddd）")
        lbl時間.Text = Now.ToString("HH:mm")
    End Sub

    Private Sub btn環境設定_Click(sender As Object, e As EventArgs) Handles btn環境設定.Click
        Dim sfrm As New frmM環境設定
        Call sfrm.ShowDialog()
    End Sub

    'Private Sub btn区分管理マスタ_Click(sender As Object, e As EventArgs) Handles btn区分管理マスタ.Click
    '    Dim sfrm As New frmM区分管理
    '    Call sfrm.ShowDialog()
    'End Sub


    Private Sub frmメニュー_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        ''環境設定読み込み
        my環境設定 = New cls環境設定
    End Sub











    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim frm As New frmTradeRepo
        frm.ShowDialog()
    End Sub

    Private Sub btn区分管理マスタ_Click(sender As Object, e As EventArgs) Handles btn区分管理マスタ.Click
        Dim sfrm As New frmM区分管理
        sfrm.ShowDialog()

    End Sub

    Private Sub btn会員マスタ_Click(sender As Object, e As EventArgs) Handles btn会員マスタ.Click
        Dim frm As New frm取引集計表
        frm.ShowDialog()
    End Sub

    Private Sub btnCallExcel_Click(sender As Object, e As EventArgs) Handles btnCallExcel.Click

    End Sub
End Class
