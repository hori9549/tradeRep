Imports System.Data.SqlClient
Imports NPOI
Imports NPOI.SS.UserModel
Imports NPOI.HSSF.UserModel
Imports NPOI.XSSF.UserModel

Public Class frmTradeRepo
    Private msSQL As String
    Private mCommand As SqlCommand
    Private mSDA As New SqlDataAdapter
    Private get日付 As Date = Now.Date
    Private Sub btn新規建入力_Click(sender As Object, e As EventArgs) Handles btn新規建入力.Click
        '  txt入力ID.Text = 入力ID最大取得()
        Dim frm As New frm新規建入力
        '  frm.txt入力ID.Text = txt入力ID.Text
        frm.日付 = get日付
        frm.ShowDialog()

    End Sub

    Private Sub btn返済入力_Click(sender As Object, e As EventArgs) Handles btn返済入力.Click
        Dim sfrm As New frm返済
        sfrm.日付 = get日付
        sfrm.ShowDialog()

    End Sub

    Private Sub btn閉じる_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

    Private Sub btn画像_Click(sender As Object, e As EventArgs)
        Dim sfd As New OpenFileDialog
        sfd.Filter = "画像ファイル|*.png;*.jpg;"
        Call sfd.ShowDialog()

    End Sub

    Private Sub frmTradeRepo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'ヘッダーとすべてのセルの内容に合わせて、列の幅を自動調整する
        dgv直近一覧.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells

        'ヘッダーとすべてのセルの内容に合わせて、行の高さを自動調整する
        dgv直近一覧.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells

        dgv直近一覧.DataSource = get一覧()

    End Sub
    Private Function get一覧() As DataTable

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

        Return getデータ
        ''[Enter]キーで次の TabIndex があるコントロールへフォーカスを移す
        ''フォームがすべてのキー イベントを受け取る
        'Me.KeyPreview = True

    End Function
    '  Private Function 入力ID最大取得() As Integer
    'Public Function 入力ID最大取得() As Integer

    '    '入力ID ベース取得　yyMM  & "010"
    '    Dim IdBase As String = DateTime.Now.ToString("yyMMdd") + "010"
    '    Dim cDB As New clsDB
    '    Dim msSQL As String
    '    Dim mytable As New DataTable

    '    msSQL = " SELECT * FROM MST_取得"
    '    msSQL += " ORDER BY 入力ID DESC"

    '    mCommand = cDB.getsqlComand(msSQL)
    '    mSDA.SelectCommand = mCommand

    '    Call mSDA.Fill(mytable) ''データセット作成


    '    If mytable.Rows.Count = 0 Then
    '        Return IdBase
    '    Else

    '        Select Case mytable.Rows(0).Item("入力ID")

    '            Case >= IdBase

    '                Return mytable.Rows(0).Item("入力ID") + 10
    '            Case Else
    '                Return IdBase

    '        End Select
    '    End If

    '    Call cDB.Close()
    'End Function
    ''NPOIを使うために必要
    '  Imports NPOI.SS.UserModel

    ''読込み
    Private Sub excel読込み()
        Dim WB As IWorkbook = WorkbookFactory.Create("f:\data.xls")
        Dim WS As ISheet = WB.GetSheetAt(0)         ''最初のシート取得
        Dim iLastRow As Integer = WS.LastRowNum   ''シートの最終行数取得
        ''最終行まで読込み
        'For iCount As Integer = 0 To iLastRow - 1
        '    Dim getRow As IRow = WS.GetRow(iCount) ''行取得
        '    '  Dim getCell = getRow.GetCell(0)         ''取得した行のA列取得
        '    '  Dim getCell = getRow.GetCell(2)         ''取得した行のxx列取得
        '    Dim getCell = getRow.GetCell(iLastRow - 2)         ''取得した行のxxx列取得

        '    ''セルにデータがあればメッセージ表示
        '    If getCell IsNot Nothing Then
        '        MsgBox(getCell.StringCellValue)
        '        MsgBox(iLastRow)
        '    End If
        'Next
        '最終行まで読込み
        'For iCount As Integer = 0 To iLastRow - 1
        '    Dim getRow As IRow = WS.GetRow(iCount) ''行取得

        '    Dim getCell = getRow.GetCell(2)         ''取得した行のxx列取得

        '    MsgBox(getCell.StringCellValue)
        'Next

        '試し書き
        Dim cDB As New clsDB

        For i As Integer = 2 To iLastRow
            Dim getRow As IRow = WS.GetRow(i) ''行取得
            ' Dim getCellコード As ICell = getRow.GetCell(1)         ''取得した行のxx列取得
            Dim getCellコード As ICell = getRow.GetCell(1)         ''取得した行のxx列取得

            Dim getCell銘柄名 As ICell = getRow.GetCell(2)         ''取得した行のxx列取得
            Dim getCell市場区分 As ICell = getRow.GetCell(3)         ''取得した行のxx列取得
            Dim getCell業種区分 As ICell = getRow.GetCell(7)         ''取得した行のxx列取得

            '  MsgBox(getCell.StringCellValue)

            msSQL = " insert into MST_銘柄表 (コード,銘柄名,市場区分,業種区分) "
            msSQL += " values ( "
            msSQL += " '" & getCellコード.ToString & "'"
            msSQL += " ,'" + getCell銘柄名.StringCellValue + "'"
            msSQL += " ,'" + getCell市場区分.StringCellValue + "'"
            msSQL += " ,'" + getCell業種区分.StringCellValue + "'"
            msSQL += ")"
            mCommand = cDB.getsqlComand(msSQL)
            Call mCommand.ExecuteNonQuery()
        Next

    End Sub
    Private Sub btn取引日付_Click(sender As Object, e As EventArgs) Handles btn取引日付.Click
        Dim sfrm As New sfrm日付選択
        Call sfrm.ShowDialog()

        With sfrm.日付
            Select Case .Length
                Case 0
                    get日付 = Now.Date.ToString("yyyy/MM/dd")
                Case Else
                    get日付 = .ToString
            End Select
        End With
        txt取得日付.Text = get日付.ToString("yyyy/MM/dd")
        ActiveControl = Nothing
    End Sub

    Private Sub btn郵便番号取込_Click(sender As Object, e As EventArgs)
        ' Dim sfrm As New frmM郵便番号取込
        '  Call sfrm.ShowDialog()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnCallExcel.Click
        Call excel読込み()
    End Sub
End Class
