﻿Imports System.Windows.Forms
Imports System.Text.RegularExpressions  ''正規表現

Imports System.Data
Imports System.Data.SqlClient

Public Class sfrmログイン

    ''データベース接続用-------------------------------
    Private msSQL As String
    Private mCommand As SqlCommand
    Private mSDA As New SqlDataAdapter

    Private Sub sfrm出勤確認_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblメッセージ.Text = ""
    End Sub

    Private Function subログイン() As Boolean
        'Dim cDB As New clsDB
        'Dim dtbl会員 As New DataTable

        'msSQL = "SELECT * FROM MST_会員"
        'msSQL += " WHERE 施設ID='" & my環境設定.施設ID & "'"
        'msSQL += " AND 会員ID='" & txt会員ID.Text & "'"
        'msSQL += " WHERE 会員ID='" & txt会員ID.Text & "'"

        'mCommand = cDB.getsqlComand(msSQL)
        'mSDA.SelectCommand = mCommand

        'Call mSDA.Fill(dtbl会員) ''データセット作成

        'If dtbl会員.Rows.Count = 0 Then
        '    lblメッセージ.Text = "会員ID、または、パスワードに誤りがあります。"

        'Else
        Dim str_CheckPassword As String = Now.Date.ToString("yyyyMMdd").Substring(7, 1)
        Dim str_InputPassword As String = txtパスワード.Text

        'パスワード大文字・小文字判別チェック
        If String.Compare(str_CheckPassword, str_InputPassword, True) = 0 Then
            '認証ＯＫ
            'MS会員ID = dtbl会員.Rows(0)("会員ID")
            'MS氏名 = dtbl会員.Rows(0)("氏名")

            'Me.DialogResult = System.Windows.Forms.DialogResult.OK
            'Me.Close()
            Return True
        Else
            '認証ＮＧ
            lblメッセージ.Text = "会員ID、または、パスワードに誤りがあります。"
            Return False
        End If
        'End If

    End Function

    Private Sub btnログイン_Click(sender As Object, e As EventArgs) Handles btnログイン.Click
        With txtパスワード
            Select Case .Text
                Case ""
                    lblメッセージ.Text = "パスワードを入力してください。"

                    Call .Select()
                    Exit Sub
                Case Else
            End Select
        End With
        Select Case subログイン()
            Case True
                Call Application.Exit()
            Case Else
                Call txtパスワード.Select()
        End Select
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Call Application.Exit()

    End Sub

End Class
