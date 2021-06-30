Imports System.Data.SqlClient

Public Class frm取引集計表
    'Private mSDA As New SqlDataAdapter
    'Private msSQL As String
    'Private dtbl検索結果 As New DataTable
    Private get集計区分 As New clsコンボボックス

    Private Sub frm取引集計表_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call get集計区分.取引集計区分コンボ(cmb集計区分)
        'Call 結果表示()
        cmb集計区分.Select()
    End Sub
    'Private Sub cmb集計区分_SelectedValueChanged(sender As Object, e As EventArgs) Handles cmb集計区分.SelectedValueChanged
    '    If cmb集計区分.SelectedIndex < 0 Then
    '        Exit Sub
    '    End If

    '    'PosIdSave = cmb集計区分.SelectedValue.ToString()
    '    'PosNamSave = cmb集計区分.Text
    '    'MsgBox(cmbPOSパターン.Text)


    '    Select Case cmb集計区分.SelectedValue
    '        Case 1
    '            Call 結果表示()
    '        Case Else
    '            MsgBox("mikannsei")
    '    End Select
    'End Sub
    Private Sub 結果表示()
        Dim cDB As New clsDB
        Dim msSQL As String
        Dim mCommand As SqlCommand
        Dim mSDA As New SqlDataAdapter
        Dim dtbl検索結果 As New DataTable

        msSQL = " Select   a.銘柄コード as CODE , a.銘柄名 "
        msSQL += " ,b.返済日付,sum( b.返済株数) as 返済総数 "
        msSQL += ",sum(b.返済株数 * b.返済単価 - a.取引株数 * a.取得単価) as 概算損益"

        msSQL += " FROM MTD_取得 as A left join MTD_返済 as b"
        msSQL += " On a.入力ID = b.返済元ID"

        msSQL += " Where a.銘柄コード = "
        msSQL += "'" & txt銘柄コード.Text & "'"      'ex'6857'
        msSQL += " group by rollup (b.返済日付 ,a.銘柄コード,a.銘柄名)"
        mCommand = cDB.getsqlComand(msSQL)
        mSDA.SelectCommand = mCommand

        Call mSDA.Fill(dtbl検索結果) ''データセット作成
        Dgv検索結果.DataSource = dtbl検索結果

    End Sub

    Private Sub btn集計_Click(sender As Object, e As EventArgs) Handles btn集計.Click
        Dim cDB As New clsDB
        Dim msSQL As String
        Dim mCommand As SqlCommand
        Dim mSDA As New SqlDataAdapter
        Dim dtbl検索結果 As New DataTable

        Select Case cmb集計区分.SelectedValue
            Case 1      '概算損益

                msSQL = " Select   a.銘柄コード as CODE , a.銘柄名 "
                msSQL += " ,b.返済日付,sum( b.返済株数) as 返済総数 "
                msSQL += ",sum(b.返済株数 * b.返済単価 - a.取得株数 * a.取得単価) as 概算損益"

                msSQL += " FROM MTD_取得 as A left join MTD_返済 as b"
                msSQL += " On a.入力ID = b.返済元ID"

                msSQL += " Where a.銘柄コード = "
                msSQL += "'" & txt銘柄コード.Text & "'"      'ex'6857'
                msSQL += " group by rollup (b.返済日付 ,a.銘柄コード,a.銘柄名)"
                'mCommand = cDB.getsqlComand(msSQL)
                'mSDA.SelectCommand = mCommand

                'Call mSDA.Fill(dtbl検索結果) ''データセット作成
                'Dgv検索結果.DataSource = dtbl検索結果

            Case "3"               ' 返済履歴 (日付ごと) 

                msSQL = " Select a.銘柄コード,a.銘柄名"

                msSQL += " b,[返済日付] ,sum([返済株数]) as 返済総数 ,max([返済単価]) as 返済単価"

                msSQL += " From MTD_取得 As a inner Join MTD_返済 As b"
                msSQL += " On a.入力ID = b.返済元ID"

                msSQL += " group by [返済日付], a.銘柄コード, a.銘柄名;"

            Case "2"      '取引履歴(日付ごと)
                msSQL = " select b.返済日付"
                msSQL += ",sum( b.返済株数) as 返済総数"
                msSQL += ",sum(b.返済株数 * b.返済単価 - a.取得株数 * a.取得単価) as 概算損益"
                msSQL += " FROM MTD_取得 as A left join MTD_返済 as b"
                msSQL += " on a.入力ID = b.返済元ID"
                msSQL += " group by rollup(b.返済日付) --,a.銘柄コード, a.銘柄名)"

            Case "4" '未返済 一覧
                msSQL = " SELECT a.ID as 取得ID,a.取得日付 , b.ID as 返済ID,b.返済日付"
                msSQL += ", a.銘柄コード as CODE , a.銘柄名"
                msSQL += ",a.取得株数, b.返済株数 ,a.残株数"
                msSQL += " FROM Mtd_取得 as a left join MTd_返済 as b"
                msSQL += " on a.入力ID = b.返済元ID"
                msSQL += " where a.残株数 <> 0 and 現況='買建'"
                msSQL += " order by a.取得日付 desc"

            Case Else      

                MsgBox("mikannsei")
                Exit Sub
        End Select
        mCommand = cDB.getsqlComand(msSQL)
        mSDA.SelectCommand = mCommand

        Call mSDA.Fill(dtbl検索結果) ''データセット作成
        Dgv検索結果.DataSource = dtbl検索結果

        ' txt銘柄コード.Select()
    End Sub



End Class