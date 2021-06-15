Imports System.Data.SqlClient

Public Class frm取引集計表
    'Private mSDA As New SqlDataAdapter
    'Private msSQL As String
    'Private dtbl検索結果 As New DataTable

    Private Sub frm取引集計表_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call 結果表示()
    End Sub
    Private Sub 結果表示()
        Dim cDB As New clsDB
        Dim msSQL As String
        Dim mCommand As SqlCommand
        Dim mSDA As New SqlDataAdapter
        Dim dtbl検索結果 As New DataTable

        msSQL = " Select  a.ID  as 取得ID, a.取得日付 , b.ID As 返済ID , b.返済日付 "
        msSQL += " , a.銘柄コード As CODE , a.銘柄名 , a.取引株数 as 取得株数, b.返済株数 ,a.残株数 "
        msSQL += ", format(b.[返済株数] * b.[返済単価] - a.取引株数 * 取得単価,'#,##0') as 損益"
        msSQL += " From MST_取得 As A left Join MST_返済 As b On a.入力ID = b.返済元ID"

        msSQL += " Where a.銘柄コード = '8604'"
        mCommand = cDB.getsqlComand(msSQL)
        mSDA.SelectCommand = mCommand

        Call mSDA.Fill(dtbl検索結果) ''データセット作成
        Dgv検索結果.DataSource = dtbl検索結果

    End Sub
End Class