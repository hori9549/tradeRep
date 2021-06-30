Imports System.Data
Imports System.Data.SqlClient

Public Class clsコンボボックス
    Private msSQL As String
    Private mCommand As SqlCommand
    Private mSDA As New SqlDataAdapter

    Public Sub 取引集計区分コンボ(ByVal setDDL As ComboBox)
        Dim cDB As New clsDB
        Dim getSQL As String
        Dim myTable As New DataTable

        ''検索SQL======================================================
        getSQL = "SELECT DISTINCT (集計区分名) as 表示,(集計区分ID) as ID"
        getSQL += " FROM MTD_集計区分"
        getSQL += " ORDER BY 集計区分ID,集計区分名"

        mCommand = cDB.getsqlComand(getSQL)
        mSDA.SelectCommand = mCommand


        Call mSDA.Fill(myTable)
        ''=============================================================

        '空行追加-----------------------------------------------------
        'Dim myRow As DataRow = myTable.NewRow
        'myRow("ID") = "0"
        'myRow("表示") = ""
        'Call myTable.Rows.InsertAt(myRow, 0)

        With setDDL
            .DisplayMember = "表示"
            .ValueMember = "ID"

            ''グリッド表示
            .DataSource = myTable.DefaultView
            .SelectedValue = 1

        End With
    End Sub
    Public Sub 区分コンボ(ByVal setDDL As ComboBox)
        Dim cDB As New clsDB
        Dim getSQL As String
        Dim myTable As New DataTable

        ''検索SQL======================================================
        getSQL = "SELECT DISTINCT (区分名) as 表示,区分"
        getSQL += " FROM MTD_集計区分"
        'getSQL += " WHERE 施設ID='" & my環境設定.施設ID & "'"
        getSQL += " ORDER BY 区分,区分名"

        mCommand = cDB.getsqlComand(getSQL)
        mSDA.SelectCommand = mCommand

        Call mSDA.Fill(myTable)
        ''=============================================================

        ''空行追加-----------------------------------------------------
        Dim myRow As DataRow = myTable.NewRow
        myRow("区分") = "0"
        myRow("表示") = ""
        Call myTable.Rows.InsertAt(myRow, 0)

        With setDDL
            .DisplayMember = "表示"
            .ValueMember = "区分"

            ''グリッド表示
            .DataSource = myTable.DefaultView
            .SelectedValue = 0

        End With
    End Sub

End Class