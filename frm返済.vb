'5/8 get日付に変更する必要あり？
'cloneしてきたもの5/9 10:15   
'上をOrigin/Masterに正常にプシュ5/9 11:19
'日付の受渡方法を変更、INSERT文をget日付で登録
'210518 14:40 プッシュできず
Imports System.Data.SqlClient

Public Class frm返済

    Private msSQL As String
    Private dtbl返済一覧 As New DataTable
    Private get日付 As Date
    '  Private 入力ID最大取得 As New clsHtools
    Public Property maxID As Integer
    Public Property 日付() As Date
        Get
            Return get日付
        End Get

        Set(ByVal value As Date)
            get日付 = value
        End Set
    End Property


    'ID 最大値を取得
    'Public Shared Function getMaxId() As String
    '    Dim mCommand As SqlCommand
    '    Dim mSDA As New SqlDataAdapter

    '    '入力ID ベース取得　yyMM  & "010"
    '    Dim IdBase As String = DateTime.Now.ToString("yyMMdd") + "010"
    '    Dim cDB As New clsDB
    '    Dim msSQL As String
    '    Dim mytable As New DataTable
    '    Dim 取得tabMaxId As Integer
    '    Dim 返済tabMaxId As Integer
    '    Dim maxID As Integer
    '    'MST_取得の最大値を計算する

    '    msSQL = " SELECT * FROM MST_取得"
    '    msSQL += " ORDER BY 入力ID DESC"

    '    mCommand = cDB.getsqlComand(msSQL)
    '    mSDA.SelectCommand = mCommand

    '    Call mSDA.Fill(mytable) ''データセット作成


    '    If mytable.Rows.Count = 0 Then
    '        取得tabMaxId = IdBase
    '    Else

    '        Select Case mytable.Rows(0).Item("入力ID")

    '            Case >= IdBase

    '                取得tabMaxId = mytable.Rows(0).Item("入力ID") + 10
    '            Case Else
    '                取得tabMaxId = IdBase

    '        End Select
    '    End If

    '    mytable.Clear()

    '    'MST_返済の最大値を計算する

    '    msSQL = " SELECT * FROM MST_返済"
    '    msSQL += " ORDER BY 入力ID DESC"

    '    mCommand = cDB.getsqlComand(msSQL)
    '    mSDA.SelectCommand = mCommand

    '    Call mSDA.Fill(mytable) ''データセット作成


    '    If mytable.Rows.Count = 0 Then
    '        返済tabMaxId = IdBase
    '    Else

    '        Select Case mytable.Rows(0).Item("入力ID")

    '            Case >= IdBase

    '                返済tabMaxId = mytable.Rows(0).Item("入力ID") + 10
    '            Case Else
    '                返済tabMaxId = IdBase

    '        End Select
    '    End If

    '    'MST_取得の最大値とMST_返済の最大値を比較して大きいほうをmaxIDにする
    '    If 取得tabMaxId > 返済tabMaxId Then
    '        maxID = 取得tabMaxId
    '    Else
    '        maxID = 返済tabMaxId
    '    End If
    '    Return maxID
    '    Call cDB.Close()

    'End Function

    Private Sub frm返済_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Call 入力ID最大取得.getMaxId()
        ' txt返済入力ID.Text = 入力ID最大取得.maxID
        '  txt返済入力ID.Text = ModuleGetMaxID.maxID
        '  txt返済入力ID.Text = getMaxId()
        txt返済入力ID.Text = getMaxId.ToString
        txt返済日付.Text = get日付.ToString("yyyy/MM/dd")
        dgv未返済一覧.DataSource = dtblGet()

        'ヘッダーとすべてのセルの内容に合わせて、列の幅を自動調整する
        dgv未返済一覧.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells

        'ヘッダーとすべてのセルの内容に合わせて、行の高さを自動調整する
        dgv未返済一覧.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells




        '[Enter]キーで次の TabIndex があるコントロールへフォーカスを移す
        'フォームがすべてのキー イベントを受け取る
        ' Me.KeyPreview = True


    End Sub
    Private Function dtblGet()
        Dim cDB As New clsDB
        Dim getデータ As New DataTable
        Dim mCommand As SqlCommand
        Dim mSDA As New SqlDataAdapter

        msSQL = " select * from [MST_取得] "
        msSQL += " where 残株数<>0"

        mCommand = cDB.getsqlComand(msSQL)
        mSDA.SelectCommand = mCommand
        Call mSDA.Fill(getデータ)
        Return getデータ
    End Function
    'Private Sub btn登録_Click(sender As Object, e As EventArgs) Handles btn登録.Click
    '    With txt電話番号
    '        Select Case .Text
    '            Case ""
    '                MessageBox.Show("必須入力項目です")
    '                Call .Focus()
    '                Exit Sub
    '            Case Else
    '                If IsNumeric(.Text) = False Then
    '                    MessageBox.Show("数字入力項目です")

    '                    Call .Focus()
    '                    Exit Sub

    '                End If

    '                If Len(.Text) > 10 Then
    '                    MessageBox.Show("10文字以内の入力項目です")

    '                    Call .Focus()
    '                    Exit Sub

    '                End If
    '        End Select
    '    End With
    'End Sub

    Private Sub btn閉じる_Click(sender As Object, e As EventArgs)
        Call Me.Close()
    End Sub

    Private Sub cmb定休日_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub



    Private Sub 未返済一覧_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv未返済一覧.CellClick

        If e.RowIndex < 0 Then Exit Sub
        If e.ColumnIndex < 0 Then Exit Sub

        'IDを取得
        ' colNam = dgv一覧.Columns(0).Name    '先頭の列名（ここでは”ID”）を取得

        Dim selID As String
        '  selID = dgv一覧.Rows(e.RowIndex).Cells(colNam).Value.ToString
        selID = dgv未返済一覧.Rows(e.RowIndex).Cells("入力ID").Value.ToString

        '取得したIDを持つレコードを取り出す
        Dim cDB As New clsDB
        Dim dtblSelectData As New DataTable
        Dim mCommand As SqlCommand
        Dim mSDA As New SqlDataAdapter

        msSQL = "select * FROM MST_取得 "
        msSQL += "where 入力ID =　" & "'" & selID & "'"

        mCommand = cDB.getsqlComand(msSQL)
        mSDA.SelectCommand = mCommand

        Call mSDA.Fill(dtblSelectData) ''データセット作成
        With dtblSelectData.Rows(0)
            txtID.Text = Trim(.Item("ID").ToString)
            txt返済玉ID.Text = Trim(.Item("入力ID").ToString)
            txt銘柄コード.Text = Trim(.Item("銘柄コード").ToString)
            txt銘柄名.Text = Trim(.Item("銘柄名").ToString)
            txt取引種別.Text = Trim(.Item("取引種別").ToString)

            'txt取引区分.Text = Trim(.Item("取引区分").ToString)
            'txt返済株数.Text = Trim(.Item("取引株数").ToString)
            txt残株数.Text = Trim(.Item("残株数").ToString)
            txt取得単価.Text = Trim(.Item("取得単価").ToString)
            txt取得日.Text = Trim(.Item("取得日付").ToString)
        End With
        txt返済単価.Select()
    End Sub

    Private Sub btn登録_Click(sender As Object, e As EventArgs) Handles btn登録.Click
        Dim mssql As String
        Dim cDB As New clsDB
        Dim mCommand As SqlCommand
        Dim mSDA As New SqlDataAdapter

        Select Case ErrorCheck()    'エラーチェック

            Case 1  'エラーなし
                '入力項目を確認させる
                'Dim int返済株数 As Integer
                'Dim int残株数 As Integer = Integer.Parse(txt残株数.Text)
                'Dim d取得単価 As Single
                'txt返済株数が””の場合、入力を促す
                Select Case txt返済株数.Text
                    Case ""
                        txt返済株数.Select()
                        Exit Sub
                        'Case Else
                        '    int返済株数 = Integer.Parse(txt返済株数.Text)
                End Select

                'txt取得単価””の場合、入力を促す
                Select Case txt取得単価.Text
                    Case ""
                        txt取得単価.Select()
                        Exit Sub
                        'Case Else

                        '    d取得単価 = Double.Parse(txt取得単価.Text)
                End Select


                ''  Dim d取得単価 As Single = Double.Parse(txt取得単価.Text)

                'Dim d返済単価 As Single = Double.Parse(txt返済単価.Text)

                'txt返済後残株数.Text = (int残株数 - int返済株数).ToString
                'txt売買差額.Text = (int返済株数 * (d返済単価 - d取得単価)).ToString("C")


                'ほんとうに登録しますか？
                Select Case MessageBox.Show("" & txt銘柄コード.Text & txt銘柄名.Text & "を" _
                & txt返済株数.Text & " " & txt返済単価.Text & "’約’" & txt売買差額.Text & "'返済売'で、登録しますか？",
               "確認", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

                    Case Windows.Forms.DialogResult.Yes
                    Case Else
                        txt返済単価.Select()
                        Exit Sub
                End Select

                '   Dim toInt As Integer
                mssql = "INSERT INTO [dbo].[MST_返済]"
                mssql += "([入力ID]"
                mssql += " ,[返済日付]"
                mssql += " ,[返済元ID]"
                mssql += " ,[取引種別]"
                mssql += " ,[取引区分]"
                mssql += " ,[返済株数]"
                mssql += " ,[返済単価])"
                mssql += " VALUES ( "
                mssql += "'" + txt返済入力ID.Text + "'"          ' ,<入力ID, nvarchar(9),>
                '  Dim dt As Date = DateTime.Parse(txt返済日付.Text)
                '  mssql += ",'" + txt返済日付.Text + "'"          ' ,<返済日付, date,>
                mssql += ",'" + get日付 + "'"
                mssql += ",'" + txt返済玉ID.Text + "'"          ' ,<返済元ID, nvarchar(9),>
                mssql += ",'" + txt取引種別.Text + "'"          ' ,<取引種別, nvarchar(4),>
                mssql += ",'" + txt取引区分.Text + "'"          ' ,<取引区分, nvarchar(4),>
                mssql += ",'" + txt残株数.Text + "'"          ' ,<返済株数, int,>
                mssql += ",'" + txt返済単価.Text + "'"          ' ,<返済単価, int,>)
                mssql += ") "

                mssql += "update MST_取得 "
                mssql += "set 残株数= "
                'toInt = Integer.Parse(txt残株数.Text)
                'mssql += "'" + toInt + "'"
                mssql += "'" + txt返済後残株数.Text + "' "
                mssql += ", 現況 = "
                mssql += "'" + cmb現況.Text + "'"
                mssql += " where 入力ID = "
                mssql += "'" + txt返済玉ID.Text + "'"

                mCommand = cDB.getsqlComand(mssql)
                Call mCommand.ExecuteNonQuery()
                '       MsgBox("返済手続きは、完了しました")
                Call subクリアー()
                dgv未返済一覧.DataSource = dtblGet()
                ActiveControl = Nothing

                btn登録.Enabled = False

            Case Else
                Exit Sub
        End Select

    End Sub
    Private Function ErrorCheck()
        With txt返済単価
            If IsNumeric(.Text) = False Then
                .Select()
                Return -1
            End If
        End With

        With txt返済株数
            If IsNumeric(.Text) = False Then
                .Select()
                Return -1
            End If
        End With



        Return 1
    End Function


    Private Sub subクリアー()
        dgv未返済一覧.DataSource = ""
        ' txt検索日付.Text = ""
        txtID.Text = ""
        txt返済玉ID.Text = ""
        txt銘柄コード.Text = ""
        txt銘柄名.Text = ""
        txt取得日.Text = ""
        txt残株数.Text = ""
        txt取得単価.Text = ""
        '  txt返済日付.Text = ""
        txt返済単価.Text = ""
        txt返済株数.Text = ""
        'txt取引種別.Text = ""
        'txt取引区分.Text = ""
        cmb現況.Text = ""

    End Sub
    'txt返済株数_Leave
    '仮の売買差額を表示
        Private Sub txt返済株数_Leave(sender As Object, e As EventArgs) Handles txt返済株数.Leave
        Dim int返済株数 As Integer
        Dim int残株数 As Integer = Integer.Parse(txt残株数.Text)
        '   Dim d取得単価 As Single
        'txt返済株数が””の場合、入力を促す
        With txt返済単価
            Select Case (.Text <> "") And IsNumeric(.Text)
                Case False
                    txt返済単価.Select()
                    'Case Else
                    Exit Sub
            End Select
        End With
        'txt取得単価””の場合、入力を促す
        With txt返済株数
            Select Case (.Text <> "") And IsNumeric(.Text)
                Case False
                    txt返済株数.Select()
                    Exit Sub
            End Select
        End With
        int返済株数 = Integer.Parse(txt返済株数.Text)

        Dim d取得単価 As Single = Double.Parse(txt取得単価.Text)

        Dim d返済単価 As Single = Double.Parse(txt返済単価.Text)

        txt返済後残株数.Text = (int残株数 - int返済株数).ToString
        txt売買差額.Text = (int返済株数 * (d返済単価 - d取得単価)).ToString("C")
        btn登録.Select()
    End Sub


    Private Sub btn検索日付_Click(sender As Object, e As EventArgs) Handles btn検索日付.Click
        Dim sfrm As New sfrm日付選択
        Call sfrm.ShowDialog()

        With sfrm.日付
            Select Case .Length
                Case 0
                    txt検索日付.Text = Now.Date.ToString("yyyy/MM/dd")
                Case Else
                    txt検索日付.Text = .ToString
            End Select
        End With
        ' 'tsuduite候補銘柄を示して選択してもらう
        'dtbl返済一覧.Rows.Clear()
        dtbl返済一覧.Clear()
        dgv未返済一覧.DataSource = ""
        Dim cDB As New clsDB
        Dim mCommand As SqlCommand
        Dim mSDA As New SqlDataAdapter

        msSQL = "Select * From MST_取得 "
        msSQL += " Where 取得日付 = "
        msSQL += "'" & txt検索日付.Text & "'"                   'EX '2021/2/1'
        msSQL += " AND [残株数]<>0 "
        mCommand = cDB.getsqlComand(msSQL)
        mSDA.SelectCommand = mCommand

        Call mSDA.Fill(dtbl返済一覧) ''データセット作成
        Select Case dtbl返済一覧.Rows.Count
            Case 0
                MessageBox.Show("返済する""玉""がありません")
                btn次へ.Select()
                Exit Sub
        End Select
        dgv未返済一覧.DataSource = dtbl返済一覧

    End Sub

    Private Sub btn次へ_Click(sender As Object, e As EventArgs) Handles btn次へ.Click
        Me.Close()
    End Sub

    Private Sub btn続ける_Click_1(sender As Object, e As EventArgs) Handles btn続ける.Click
        Dim mCommand As SqlCommand
        Dim mSDA As New SqlDataAdapter

        Call subクリアー()
        ' txt返済日付.Text = txt検索日付.Text     '返済日付は引き継ぐ
        '直近の入力を表示
        Dim cDB As New clsDB
        Dim getデータ As New DataTable

        msSQL = " select * from MST_取得 as A "
        msSQL += " left join MST_返済 as B "
        msSQL += " on A.入力ID = B.返済元ID "
        msSQL += " order by A.入力ID desc "
        mCommand = cDB.getsqlComand(msSQL)
        mSDA.SelectCommand = mCommand

        Call mSDA.Fill(getデータ) ''データセット作成
        dgv未返済一覧.DataSource = getデータ

        txt返済入力ID.Text = getMaxId.ToString()
        btn登録.Enabled = True
        '   btn続ける.Enabled = False
        btn検索日付.Select()

    End Sub

End Class