Imports System.Data
Imports System.Data.SqlClient

Public Class frmM環境設定
    ''データベース接続用-------------------------------
    Private msSQL As String
    Private mCommand As SqlCommand
    Private mSDA As New SqlDataAdapter
    Private myコンボ As New clsコンボボックス

    Private Sub frm利用者登録_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        Call frmメニュー.Show()
    End Sub

    Private Sub frm利用者登録_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call myコンボ.口座区分コンボ(cmb口座区分)
        ''一覧表示
        Call sub_Display_環境設定()

    End Sub

    Private Sub sub_Display_環境設定()

        txtフリガナ.Text = my環境設定.フリガナ
        txt会社名.Text = my環境設定.会社名
        txt代表者.Text = my環境設定.代表者
        txt郵便番号.Text = my環境設定.郵便番号
        txt住所.Text = my環境設定.住所
        txt電話番号.Text = my環境設定.電話番号
        txtFAX番号.Text = my環境設定.FAX番号
        txt銀行名.Text = my環境設定.銀行名
        txt支店名.Text = my環境設定.支店名
        '   cmb口座区分.SelectedValue = my環境設定.口座区分
        txt口座番号.Text = my環境設定.口座番号


    End Sub


    Private Sub btn登録_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim cDB As New clsDB
        Dim strPrint As String = 0 ''印刷値
        Dim str利用者 As String = 0 ''印刷値

        Select Case MessageBox.Show("利用者の修正登録を行います。よろしいですか？", "確認", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            Case Windows.Forms.DialogResult.Yes
            Case Else : Exit Sub
        End Select

        Try

            ''フリガナ------------------------------------
            msSQL = "UPDATE mst_環境設定 SET "
            msSQL += " パラメータ ='" & Trim(txtフリガナ.Text) & "'"
            msSQL += " WHERE ID=1"

            mCommand = cDB.getsqlComand(msSQL)
            Call mCommand.ExecuteNonQuery()

            ''会社名------------------------------------
            msSQL = "UPDATE mst_環境設定 SET "
            msSQL += " パラメータ ='" & Trim(txt会社名.Text) & "'"
            msSQL += " WHERE ID=2"

            mCommand = cDB.getsqlComand(msSQL)
            Call mCommand.ExecuteNonQuery()

            ''代表者------------------------------------
            msSQL = "UPDATE mst_環境設定 SET "
            msSQL += " パラメータ ='" & Trim(txt代表者.Text) & "'"
            msSQL += " WHERE ID=3"

            mCommand = cDB.getsqlComand(msSQL)
            Call mCommand.ExecuteNonQuery()

            ''郵便番号------------------------------------
            msSQL = "UPDATE mst_環境設定 SET "
            msSQL += " パラメータ ='" & Trim(txt郵便番号.Text) & "'"
            msSQL += " WHERE ID=4"

            mCommand = cDB.getsqlComand(msSQL)
            Call mCommand.ExecuteNonQuery()

            ''住所------------------------------------
            msSQL = "UPDATE mst_環境設定 SET "
            msSQL += " パラメータ ='" & Trim(txt住所.Text) & "'"
            msSQL += " WHERE ID=5"

            mCommand = cDB.getsqlComand(msSQL)
            Call mCommand.ExecuteNonQuery()

            ''電話番号------------------------------------
            msSQL = "UPDATE mst_環境設定 SET "
            msSQL += " パラメータ ='" & Trim(txt電話番号.Text) & "'"
            msSQL += " WHERE ID=6"

            mCommand = cDB.getsqlComand(msSQL)
            Call mCommand.ExecuteNonQuery()

            ''FAX番号------------------------------------
            msSQL = "UPDATE mst_環境設定 SET "
            msSQL += " パラメータ ='" & Trim(txtFAX番号.Text) & "'"
            msSQL += " WHERE ID=7"

            mCommand = cDB.getsqlComand(msSQL)
            Call mCommand.ExecuteNonQuery()

            ''銀行名------------------------------------
            msSQL = "UPDATE mst_環境設定 SET "
            msSQL += " パラメータ ='" & Trim(txt銀行名.Text) & "'"
            msSQL += " WHERE ID=8"

            mCommand = cDB.getsqlComand(msSQL)
            Call mCommand.ExecuteNonQuery()

            ''支店名------------------------------------
            msSQL = "UPDATE mst_環境設定 SET "
            msSQL += " パラメータ ='" & Trim(txt支店名.Text) & "'"
            msSQL += " WHERE ID=9"

            mCommand = cDB.getsqlComand(msSQL)
            Call mCommand.ExecuteNonQuery()

            ''口座区分------------------------------------
            msSQL = "UPDATE mst_環境設定 SET "
            msSQL += " パラメータ ='" & Trim(cmb口座区分.SelectedValue) & "'"
            msSQL += " WHERE ID=10"

            mCommand = cDB.getsqlComand(msSQL)
            Call mCommand.ExecuteNonQuery()

            ''口座番号------------------------------------
            msSQL = "UPDATE mst_環境設定 SET "
            msSQL += " パラメータ ='" & Trim(txt口座番号.Text) & "'"
            msSQL += " WHERE ID=11"

            mCommand = cDB.getsqlComand(msSQL)
            Call mCommand.ExecuteNonQuery()


            my環境設定 = New cls環境設定
            MessageBox.Show("環境設定を更新しました。", "情報", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Call Me.Close()

        Catch exs As SqlException
            ''SQLエラー時
            MessageBox.Show(exs.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning)

        Catch ex As Exception
            MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning)

        End Try
    End Sub

    Private Sub btn取得_Click(sender As Object, e As EventArgs) Handles btn取得.Click
        Dim subForm As New sfrm住所検索
        subForm.検索郵便 = txt郵便番号.Text
        Call subForm.ShowDialog()

        txt郵便番号.Text = subForm.検索郵便
        txt住所.Text = subForm.検索住所

        Call txt住所.Select(Len(txt住所.Text), 0)
    End Sub
End Class