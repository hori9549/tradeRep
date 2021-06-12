Imports System.Data.SqlClient

'Module ModuleGetMaxID
Module mdlTradeRep
    Private mCommand As SqlCommand
    Private mSDA As New SqlDataAdapter
    Public Property maxID As Integer

    Public Function getMaxId() As Integer
        '入力ID ベース取得　yyMM  & "010"
        Dim IdBase As String = DateTime.Now.ToString("yyMMdd") + "010"
        Dim cDB As New clsDB
        Dim msSQL As String
        Dim mytable As New DataTable
        Dim 取得tabMaxId As Integer
        Dim 返済tabMaxId As Integer

        'MST_取得の最大値を計算する

        msSQL = " SELECT * FROM MST_取得"
        msSQL += " ORDER BY 入力ID DESC"

        mCommand = cDB.getsqlComand(msSQL)
        mSDA.SelectCommand = mCommand

        Call mSDA.Fill(mytable) ''データセット作成


        If mytable.Rows.Count = 0 Then
            取得tabMaxId = IdBase
        Else

            Select Case mytable.Rows(0).Item("入力ID")

                Case >= IdBase

                    取得tabMaxId = mytable.Rows(0).Item("入力ID") + 1
                Case Else
                    取得tabMaxId = IdBase

            End Select
        End If

        mytable.Clear()

        'MST_返済の最大値を計算する

        msSQL = " SELECT * FROM MST_返済"
        msSQL += " ORDER BY 入力ID DESC"

        mCommand = cDB.getsqlComand(msSQL)
        mSDA.SelectCommand = mCommand

        Call mSDA.Fill(mytable) ''データセット作成


        If mytable.Rows.Count = 0 Then
            返済tabMaxId = IdBase
        Else

            Select Case mytable.Rows(0).Item("入力ID")

                Case >= IdBase

                    返済tabMaxId = mytable.Rows(0).Item("入力ID") + 1
                Case Else
                    返済tabMaxId = IdBase

            End Select
        End If

        'MST_取得の最大値とMST_返済の最大値を比較して大きいほうをmaxIDにする
        If 取得tabMaxId > 返済tabMaxId Then
            maxID = 取得tabMaxId
        Else
            maxID = 返済tabMaxId
        End If
        Return maxID
        Call cDB.Close()
    End Function
End Module
