'210509 MaxID取得をClassからPublicFunctionに変更    
'fetch と Pull用に掃除0519 on fujitsu
Imports System.Data
Imports System.Data.SqlClient
Public Class frm新規建入力
    Private msSQL As String
    Private mCommand As SqlCommand
    Private mSDA As New SqlDataAdapter
    Private dtbl一覧 As New DataTable
    Private dtbl取得マスタ As New DataTable
    Private contNam As String     'Control "Name"をSave
    Private sendSav As String     'sender の内容をSave
    Private get日付 As Date
    '   Private 入力ID最大取得 As New clsHtools
    'Private tabNam As String
    'Private cond As String
    '   private getデータ As New DataTable
    Public Property 日付() As Date
        Get
            Return get日付
        End Get

        Set(ByVal value As Date)
            get日付 = value
        End Set
    End Property
    Private Function dtblGet()
        Dim cDB As New clsDB
        Dim getデータ As New DataTable

        '表示
        msSQL = " SELECT * from [MTD_取得]"
        msSQL += " where 残株数 <> 0 "
        msSQL += " order by 入力ID desc "
        mCommand = cDB.getsqlComand(msSQL)
        mSDA.SelectCommand = mCommand

        Call mSDA.Fill(getデータ) ''データセット作成
        Return getデータ
    End Function

    Private Sub frm新規建入力_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ' txt取得日付.Enabled = False     '取得日付は、変更不可
        txt取得日付.Text = get日付.ToString("yyyy/MM/dd")
        Call subクリア()
        '  Call 入力ID最大取得.getMaxId()

        '  txt入力ID.Text = 入力ID最大取得.maxID
        txt入力ID.Text = getMaxId().ToString

        '    txt入力ID.Text = getMaxId()

        'tabNam = "MTD_取得"
        'cond = "残株数 <> 0"

        'ヘッダーとすべてのセルの内容に合わせて、列の幅を自動調整する
        dgv新規一覧.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells

        'ヘッダーとすべてのセルの内容に合わせて、行の高さを自動調整する
        dgv新規一覧.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells

        dgv新規一覧.DataSource = dtblGet()
        ' txt入力ID.Text = sid.ToString("0000000000")

        '[Enter]キーで次の TabIndex があるコントロールへフォーカスを移す
        'フォームがすべてのキー イベントを受け取る
        ' Me.KeyPreview = True
        txt銘柄コード.Select()

    End Sub

    Private Sub subクリア()
        '     txt氏名.Text = "新道 結"
        txt銘柄名.Text = ""
        txt銘柄コード.Text = ""
        txt業種区分.Text = ""
        txt取得株数.Text = ""
        '  txt取引区分.Text = ""
        txt取得単価.Text = ""
        txt残株数.Text = ""
        dgv新規一覧.DataSource = ""
    End Sub
    '
    ' 機能      : 社員ID（ID)の最大数を取得する
    '
    ' 返り値    : 最大数に１0を加算する
    '
    ' 機能説明  : 
    '
    ' 備考      : 
    '
    Private Sub btn登録_Click(sender As Object, e As EventArgs) Handles btn登録.Click

        'If rdo男.Checked = True Then MessageBox.Show("男")
        'If rdo女.Checked = True Then MessageBox.Show("女")
        Dim msg入力ID As String = ""
        Dim UorI As Boolean = True  '新規追加
        Dim OorN As Boolean = True  '成功

        'Select Case ErrorCheck()
        '    Case 0   'エラーなし

        Dim 銘柄コードText As String = txt銘柄コード.Text
        Dim 銘柄名Text As String = txt銘柄名.Text
        Dim 取得株数Text As String = txt取得株数.Text   'msg出力用
        Dim 取得単価Text As String = txt取得単価.Text   'msg出力用

        Select Case MessageBox.Show("" & 銘柄コードText & 銘柄名Text & "を" _
                & 取得株数Text & " " & 取得単価Text & "'新規買'で、登録しますか？",
               "確認", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            Case Windows.Forms.DialogResult.Yes
            Case Else
                txt銘柄コード.Select()
                Exit Sub
        End Select
        txt残株数.Text = 取得株数Text
        Dim cDB As New clsDB
        Dim msSQL As String
        Dim myTable As New DataTable
        'msSQL = " SELECT * FROM MTD_取得"
        'msSQL += " WHERE 入力ID = " & txt入力ID.Text

        'mCommand = cDB.getsqlComand(msSQL)
        'mSDA.SelectCommand = mCommand

        'Call mSDA.Fill(myTable) ''データセット作成

        '   If myTable.Rows.Count = 0 Then

        ''新規追加
        'messagebox用語句登録
        msg入力ID = txt入力ID.Text
        UorI = True  '新規追加

        '追加Dataのセット
        msSQL = " INSERT INTO MTD_取得 ( "
        msSQL += " [入力ID]"
        msSQL += " ,[銘柄コード]"
        msSQL += " ,[銘柄名]"
        msSQL += " ,[取引種別]"
        msSQL += " ,[取引区分]"
        msSQL += " ,[取引株数]"
        msSQL += " ,[取得単価]"
        msSQL += " ,[取得日付]"
        msSQL += " ,[残株数]"
        msSQL += " )"

        msSQL += "  VALUES "
        msSQL += " ('" & Trim(txt入力ID.Text) & "'"                        ' <入力ID, nvarchar(10),>
        msSQL += ",'" & txt銘柄コード.Text.Trim & "'"

        msSQL += ",'" & txt銘柄名.Text.Trim & " '"
        msSQL += ",'" & txt取引種別.Text.Trim & " '"

        msSQL += ",'" & txt取引区分.Text.Trim & "'"
        msSQL += ",'" & txt取得株数.Text.Trim & "'"  '
        msSQL += ",'" & txt取得単価.Text.Trim & "'"  '
        'Select Case txt取得日付.Text.Length
        '    Case 0
        '        msSQL += ",null"
        '    Case Else
        msSQL += ",'" & get日付 + "'"   '取得日付
        msSQL += ",'" & txt残株数.Text + "'"

        msSQL += ")"

        Try

            mCommand = cDB.getsqlComand(msSQL)
            Call mCommand.ExecuteNonQuery()
            btn続けて入力.Select()

        Catch ex As Exception
            OorN = False      '失敗
            MsgBox("新規登録は、失敗！")
            btn閉じる.Select()
        End Try

        ' Call msgOut(msg入力ID, UorI, OorN)

        ''クリア
        Call subクリア()

        ''再表示
        dgv新規一覧.DataSource = dtblGet()

        '    txt入力ID.Text = 入力ID最大取得()

        '   Call cDB.Close()

    End Sub
    Private Function ErrorCheck() As Integer
        ErrorCheck = 1

        ' 氏名は、必須入力項目です
        With txt銘柄名
            If .Text = "新道 結" Or .Text = "" Then
                MessageBox.Show("氏名は省略できません！")
                .Text = ""
                .Select()
                Return 1
            End If
        End With

        ' 住所は、必須入力項目です
        With txt取引区分
            If .Text.Length = 0 Or
                            .Text = "甲府市 上阿原町 417番地 1 スモールワールドオフィスビル４階 B号 99999" Then
                MessageBox.Show("住所は,必須入力項目です。")
                .Text = ""
                .Select()
                Return 1
            End If
        End With

        ' 電話番号は、必須入力項目です
        With txt取得株数
            If .Text.Length = 0 Or .Text = "055-225-9999" Then
                MessageBox.Show("電話番号は,必須入力項目です。")
                .Text = ""
                .Select()
                Return 1
            End If
        End With

        'With txt入会日
        '    If .Text.Length = 0 Or .Text = "右のbtnで選択" Then
        '        MessageBox.Show("入会日をいれてください。")
        '        .Text = ""
        '        btn入会入力.Select()
        '        Return 1
        '    End If
        'End With

        'Return 0

    End Function
    'Private Sub msgOut(kID As String, flg1 As Boolean, flg2 As Boolean)
    '    Dim msg1 As String
    '    Dim msg2 As String

    '    If flg1 = True Then
    '        msg1 = "' 新規登録 '"
    '    Else
    '        msg1 = "' 更新 '"
    '    End If
    '    If flg2 = True Then
    '        msg2 = "は,正常に実行されました。"
    '    Else
    '        msg2 = "は,失敗しました。"
    '    End If
    '    MessageBox.Show("入力ID： " + kID + " の" + msg1 + msg2)

    'End Sub
    Private Sub btn閉じる_Click(sender As Object, e As EventArgs) Handles btn閉じる.Click
        Me.Close()
    End Sub


    Private Sub btn続けて入力_Click(sender As Object, e As EventArgs) Handles btn続けて入力.Click
        Call subクリア()
        ' 入力ID最大取得.maxID
        '   Call 入力ID最大取得.getMaxId()

        '  txt入力ID.Text = 入力ID最大取得.maxID
        txt入力ID.Text = getMaxId().ToString
        dgv新規一覧.DataSource = dtblGet()
        btn登録.Enabled = True
        txt銘柄コード.Select()
    End Sub

    'Private Sub txt取得株数_TextChanged(sender As Object, e As EventArgs) Handles txt取得株数.TextChanged
    '    txt残株数.Text = txt取得株数.Text
    '    ' txt取得単価.Select()
    'End Sub

    Private Sub btn銘柄名検索_Click_1(sender As Object, e As EventArgs) Handles btn銘柄名検索.Click
        Dim cDB As New clsDB
        Dim msSQL As String
        Dim testTable As New DataTable


        msSQL = " Select * From [MTD_銘柄表] "
        msSQL += " Where コード = "
        msSQL += "'" & txt銘柄コード.Text & "'"
        mCommand = cDB.getsqlComand(msSQL)
        '   Call mCommand.ExecuteNonQuery()
        mSDA.SelectCommand = mCommand
        Call mSDA.Fill(testTable)

        If testTable.Rows.Count = 0 Then
            txt銘柄名.Text = ""
            txt市場区分.Text = ""
            txt業種区分.Text = ""
            txt銘柄コード.Select()
            Exit Sub

        Else
            With testTable.Rows(0)
                txt銘柄名.Text = .Item("銘柄名").ToString
                txt市場区分.Text = .Item("市場区分").ToString
                txt業種区分.Text = .Item("業種区分").ToString
                txt取得株数.Select()
            End With
        End If

    End Sub


    Private Sub txt銘柄コード_Leave(sender As Object, e As EventArgs) Handles txt銘柄コード.Leave
        btn銘柄名検索.PerformClick()

    End Sub



    ' <summary>
    ' フォームロードイベント
    ' </summary>
End Class
