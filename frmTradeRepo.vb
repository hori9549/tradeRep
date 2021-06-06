Imports System.Data.SqlClient
Imports ClosedXML.Excel

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
        'Dim WB As IWorkbook = WorkbookFactory.Create("f:\data.xls")
        'Dim WS As ISheet = WB.GetSheetAt(0)         ''最初のシート取得
        'Dim iLastRow As Integer = WS.LastRowNum   ''シートの最終行数取得
        '''最終行まで読込み
        ''For iCount As Integer = 0 To iLastRow - 1
        ''    Dim getRow As IRow = WS.GetRow(iCount) ''行取得
        ''    '  Dim getCell = getRow.GetCell(0)         ''取得した行のA列取得
        ''    '  Dim getCell = getRow.GetCell(2)         ''取得した行のxx列取得
        ''    Dim getCell = getRow.GetCell(iLastRow - 2)         ''取得した行のxxx列取得

        ''    ''セルにデータがあればメッセージ表示
        ''    If getCell IsNot Nothing Then
        ''        MsgBox(getCell.StringCellValue)
        ''        MsgBox(iLastRow)
        ''    End If
        ''Next
        ''最終行まで読込み
        ''For iCount As Integer = 0 To iLastRow - 1
        ''    Dim getRow As IRow = WS.GetRow(iCount) ''行取得

        ''    Dim getCell = getRow.GetCell(2)         ''取得した行のxx列取得

        ''    MsgBox(getCell.StringCellValue)
        ''Next

        ''試し書き
        'Dim cDB As New clsDB

        'For i As Integer = 2 To iLastRow
        '    Dim getRow As IRow = WS.GetRow(i) ''行取得
        '    ' Dim getCellコード As ICell = getRow.GetCell(1)         ''取得した行のxx列取得
        '    Dim getCellコード As ICell = getRow.GetCell(1)         ''取得した行のxx列取得

        '    Dim getCell銘柄名 As ICell = getRow.GetCell(2)         ''取得した行のxx列取得
        '    Dim getCell市場区分 As ICell = getRow.GetCell(3)         ''取得した行のxx列取得
        '    Dim getCell業種区分 As ICell = getRow.GetCell(7)         ''取得した行のxx列取得

        '    '  MsgBox(getCell.StringCellValue)

        '    msSQL = " insert into MST_銘柄表 (コード,銘柄名,市場区分,業種区分) "
        '    msSQL += " values ( "
        '    msSQL += " '" & getCellコード.ToString & "'"
        '    msSQL += " ,'" + getCell銘柄名.StringCellValue + "'"
        '    msSQL += " ,'" + getCell市場区分.StringCellValue + "'"
        '    msSQL += " ,'" + getCell業種区分.StringCellValue + "'"
        '    msSQL += ")"
        '    mCommand = cDB.getsqlComand(msSQL)
        '    Call mCommand.ExecuteNonQuery()
        'Next

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

    Private Sub btnCallExcel_Click(sender As Object, e As EventArgs) Handles btnCallExcel.Click
        Dim sテンプレートパス As String = "C:\Users\hori9\OneDrive\ドキュメント\getMailTest.xlsx"

        '   Dim sテンプレートパス As String = "Temp\会員名簿.xlsx"
        Dim getExcelファイル As String

        Try
            'Excelファイルを開く
            Using workbook = New ClosedXML.Excel.XLWorkbook(sテンプレートパス)
                'ワークシートを取得する
                Dim worksheet As ClosedXML.Excel.IXLWorksheet = workbook.Worksheet("約定通知")

                '  Dim worksheet As ClosedXML.Excel.IXLWorksheet = workbook.Worksheet("Sheet1")
                '  Dim ws取引種別 As String = worksheet.Cell(1, "G")

                Dim ws取引種別 As String = (worksheet.Cell(1, "G").Value).substring(0, 5)
                If ws取引種別 = "信用新規買" Then


                    'Dim n行カウント As Integer = 9
                    'For Each get行 As DataRow In mdtbl会員.Rows
                    '    '位置を指定してセルを取得する
                    '    Dim cel役職名 = worksheet.Cell(n行カウント, 2) ' 行番号と列名でも指定可能
                    '    cel役職名.Value = get行("役職名").ToString

                    '    Dim cel氏名 = worksheet.Cell(n行カウント, 3) ' 行番号と列名でも指定可能
                    '    cel氏名.Value = get行("氏名").ToString

                    '    Dim cel郵便番号 = worksheet.Cell(n行カウント, 4) ' 行番号と列名でも指定可能
                    '    cel郵便番号.Value = get行("郵便番号").ToString

                    '    Dim cel住所 = worksheet.Cell(n行カウント, 5) ' 行番号と列名でも指定可能
                    '    cel住所.Value = get行("住所").ToString

                    '    Dim cel電話番号 = worksheet.Cell(n行カウント, 6) ' 行番号と列名でも指定可能
                    '    cel電話番号.Value = get行("電話番号").ToString

                    '    Dim cel担当理事 = worksheet.Cell(n行カウント, 7) ' 行番号と列名でも指定可能
                    '    cel担当理事.Value = get行("担当理事").ToString

                    '    Dim cel備考 = worksheet.Cell(n行カウント, 8) ' 行番号と列名でも指定可能
                    '    cel備考.Value = get行("備考").ToString

                    '    n行カウント += 1
                    'Next
                    Dim dt As String
                    Dim 銘柄コードText As String = worksheet.Cell(1, "I").Value
                    dt = worksheet.Cell(1, "J").Value
                    Dim 銘柄名Text As String = dt.Substring(0, (dt.Length - 1))


                    dt = worksheet.Cell(1, "L").Value        '"株数:100
                    Dim 取得株数Text As String = dt.Substring(3)
                    Dim 取得単価Text As String = (worksheet.Cell(1, "m").Value).substring(3)

                    ' Select Case MessageBox.Show("" & 銘柄コードText & 銘柄名Text & "を" _
                    ' & 取得株数Text & " " & 取得単価Text & "'新規買'で、登録しますか？",
                    '"確認", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

                    '     Case Windows.Forms.DialogResult.Yes
                    '     Case Else
                    '         txt銘柄コード.Select()
                    '         Exit Sub
                    ' End Select
                    ' txt残株数.Text = 取得株数Text
                    Dim cDB As New clsDB
                    Dim msSQL As String
                    Dim myTable As New DataTable
                    'msSQL = " SELECT * FROM MST_取得"
                    'msSQL += " WHERE 入力ID = " & txt入力ID.Text

                    'mCommand = cDB.getsqlComand(msSQL)
                    'mSDA.SelectCommand = mCommand

                    'Call mSDA.Fill(myTable) ''データセット作成

                    '   If myTable.Rows.Count = 0 Then

                    ''新規追加
                    'messagebox用語句登録
                    'msg入力ID = txt入力ID.Text
                    'UorI = True  '新規追加

                    ''追加Dataのセット
                    'msSQL = " INSERT INTO MST_取得 ( "
                    'msSQL += " [入力ID]"
                    'msSQL += " ,[銘柄コード]"
                    'msSQL += " ,[銘柄名]"
                    'msSQL += " ,[取引種別]"
                    'msSQL += " ,[取引区分]"
                    'msSQL += " ,[取引株数]"
                    'msSQL += " ,[取得単価]"
                    'msSQL += " ,[取得日付]"
                    'msSQL += " ,[残株数]"
                    'msSQL += " )"

                    'msSQL += "  VALUES "
                    'msSQL += " ('" & Trim(txt入力ID.Text) & "'"                        ' <入力ID, nvarchar(10),>
                    'msSQL += ",'" & txt銘柄コード.Text.Trim & "'"

                    'msSQL += ",'" & txt銘柄名.Text.Trim & " '"
                    'msSQL += ",'" & txt取引種別.Text.Trim & " '"

                    'msSQL += ",'" & txt取引区分.Text.Trim & "'"
                    'msSQL += ",'" & txt取得株数.Text.Trim & "'"  '
                    'msSQL += ",'" & txt取得単価.Text.Trim & "'"  '
                    ''Select Case txt取得日付.Text.Length
                    ''    Case 0
                    ''        msSQL += ",null"
                    ''    Case Else
                    'msSQL += ",'" & get日付 + "'"   '取得日付
                    'msSQL += ",'" & txt残株数.Text + "'"

                    msSQL += ")"

                    Try

                        mCommand = cDB.getsqlComand(msSQL)
                        Call mCommand.ExecuteNonQuery()
                        '  btn続けて入力.Select()

                    Catch ex As Exception
                        '   OorN = False      '失敗
                        MsgBox("新規登録は、失敗！")
                        btn閉じる.Select()
                    End Try

                    ' Call msgOut(msg入力ID, UorI, OorN)

                    ''クリア
                    '   Call subクリア()

                    ''再表示

                End If


                ''ワークブックを保存する
                'Using sfd As SaveFileDialog = New SaveFileDialog
                '    'デフォルトのファイル名を指定します
                '    sfd.Filter = "Excelファイル(*.xlsx)|*.xlsx"
                '    sfd.FileName = "会員名簿"
                '    sfd.InitialDirectory = System.Windows.Forms.Application.StartupPath & "\Excel"

                '    If sfd.ShowDialog() = DialogResult.OK Then
                '        getExcelファイル = sfd.FileName
                '        workbook.SaveAs(getExcelファイル)     ''別ブックで保存

                '        ''作成ファイルオープン
                '        '  Select Case sfrmメッセージ.ShowDialog("フィルが作成されました。" & vbCrLf _
                '        '                            & "作成ファイルを開きますか？", "確認", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
                '        '    Case vbOK
                '        '        Dim execProc As New Process
                '        '        With execProc
                '        '            .StartInfo.FileName = getExcelファイル
                '        '            .Start()
                '        '        End With
                '        'End Select

                '    End If
                'End Using
            End Using



        Catch ex As Exception

            'パスD:\カシオペイア\カシオペイア-Work\bin\Debug\Temp\会員名簿.xlsx' の一部が見つかりませんでした。
            ' sfrmメッセージ.ShowDialog(ex.Message, "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try





        ' Call excel読込み()
    End Sub
End Class
