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

        msSQL = " select * from MTD_取得 as A "
        msSQL += " left join MTD_返済 as B "
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

    '    msSQL = " SELECT * FROM MTD_取得"
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
        ' Call subクリア()
        Dim cDB As New clsDB
        Dim msSQL As String
        Dim myTable As New DataTable
        Dim g取引名称 As String    　 'Excelに規されたgmailのデーター
        Dim g銘柄コード As String     'Excelに規されたgmailのデーター
        Dim g銘柄名 As String         'Excelに規されたgmailのデーター
        Dim g株数 As String           'Excelに規されたgmailのデーター
        Dim g価格 As String           'Excelに規されたgmailのデーター
        Dim g日付 As String           'Excelに規されたgmailのデーター
        Dim sテンプレートパス As String = "C:\Users\hori9\OneDrive\ドキュメント\Gmail約定通知210621.xlsx"

        '   Dim sテンプレートパス As String = "Temp\会員名簿.xlsx"
        '  Dim getExcelファイル As String

        'Try
        'Excelファイルを開く
        Using workbook = New ClosedXML.Excel.XLWorkbook(sテンプレートパス)
            'ワークシートを取得する
            Dim worksheet As ClosedXML.Excel.IXLWorksheet = workbook.Worksheet("約定通知")
            ' Dim worksheet As ClosedXML.Excel.IXLWorksheet = workbook.Worksheet("work")

            '  Dim g取引名称 As String = worksheet.Cell(1, "G")
            Dim i As Integer = 1

            Do While (worksheet.Cell(i, "A").Value) <> ""

                Dim dt As String
                dt = worksheet.Cell(i, "d").Value        ' g日付
                g日付 = dt.Substring(0, 10)

                dt = (worksheet.Cell(i, "G").Value)   '取引種別&vbLF
                g取引名称 = dt.Substring(0, (dt.Length - 1))

                '/************** 取引種別ごとに分ける *****************/
                Select Case g取引名称
                    Case "信用新規買"
                        '  If g取引名称 = "信用新規買" Then

                        ''信用新規買 登録
                        '  txt入力ID.Text = 入力ID最大取得.maxID
                        Dim 入力ID As String = getMaxId().ToString

                        g銘柄コード = worksheet.Cell(i, "I").Value

                        dt = worksheet.Cell(i, "J").Value       '銘柄名 &vbLF
                        g銘柄名 = dt.Substring(0, (dt.Length - 1))



                        dt = worksheet.Cell(i, "L").Value        '"株数:1,000 &vbLF
                        dt = dt.Substring(3)
                        dt = dt.Substring(0, dt.Length - 1)
                        g株数 = dt.Replace(",", "") '","をのぞく

                        dt = (worksheet.Cell(i, "m").Value).substring(3)    '価格:#,###&vbLF
                        dt = dt.Substring(0, dt.Length - 1)
                        g価格 = dt.Replace(",", "") '","をのぞく




                        Select Case MessageBox.Show("" & g銘柄コード & " " & g銘柄名 & "を" _
                & g株数 & " " & g価格 & "'新規買'で、登録しますか？",
               "確認", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

                            Case Windows.Forms.DialogResult.Yes
                            Case Else
                                GoTo nextRec
                        End Select



                        '追加Dataのセット
                        msSQL = " INSERT INTO MTD_取得 ( "
                        msSQL += " [入力ID]"
                        msSQL += " ,[銘柄コード]"
                        msSQL += " ,[銘柄名]"
                        msSQL += " ,[取引名称]"
                        msSQL += " ,[取得株数]"
                        msSQL += " ,[取得単価]"
                        msSQL += " ,[取得日付]"
                        msSQL += " ,[残株数]"
                        msSQL += " ,[現況]"
                        msSQL += " )"

                        msSQL += "  VALUES "
                        msSQL += " ('" & 入力ID & "'"                        ' <入力ID, nvarchar(10),>
                        msSQL += ",'" & g銘柄コード & "'"
                        msSQL += ",'" & g銘柄名 & "'"
                        msSQL += ",'信用新規買'"
                        msSQL += ",'" & g株数 & "'"
                        msSQL += ",'" & g価格 & "'"
                        msSQL += ",'" & g日付 & "'"   ' g日付
                        msSQL += ",'" & g株数 & "'"
                        msSQL += ",'買建'"
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

                    ' 
                    ''信用返済売 
                    '------------------------------
                    Case "信用返済売"
                        Dim 入力ID As String = getMaxId().ToString

                        g銘柄コード = worksheet.Cell(i, "I").Value

                        dt = worksheet.Cell(i, "J").Value       '銘柄名 &vbLF
                        g銘柄名 = dt.Substring(0, (dt.Length - 1))

                        dt = worksheet.Cell(i, "L").Value        '"株数:1,000 &vbLF
                        dt = dt.Substring(3)
                        dt = dt.Substring(0, dt.Length - 1)
                        g株数 = dt.Replace(",", "") '","をのぞく

                        dt = (worksheet.Cell(i, "m").Value).substring(3)    '価格:#,###&vbLF
                        dt = dt.Substring(0, dt.Length - 1)
                        g価格 = dt.Replace(",", "") '","をのぞく

                        'dt = worksheet.Cell(i, "d").Value        ' g日付
                        'g日付 = dt.Substring(0, 10)


                        Dim sfrm As New sfrmExcel返済
                        sfrm.txtg銘柄コード.Text = g銘柄コード
                        sfrm.txt銘柄名.Text = g銘柄名
                        sfrm.txt決済総株数.Text = g株数
                        sfrm.txt価格.Text = g価格
                        sfrm.txtg日付.Text = g日付
                        sfrm.txtg取引名称.Text = "信用返済売"
                        If System.Windows.Forms.DialogResult.OK <> sfrm.ShowDialog() Then
                            worksheet.Cell(i, "N").Value = "NG"
                        End If
                         ' 
                    ''　現物買 
                    '------------------------------
                    Case "現物買"
                        Dim 入力ID As String = getMaxId().ToString

                        g銘柄コード = worksheet.Cell(i, "I").Value

                        dt = worksheet.Cell(i, "J").Value       '銘柄名 &vbLF
                        g銘柄名 = dt.Substring(0, (dt.Length - 1))


                        dt = worksheet.Cell(i, "L").Value        '"株数:1,000 &vbLF
                        dt = dt.Substring(3)
                        dt = dt.Substring(0, dt.Length - 1)
                        g株数 = dt.Replace(",", "") '","をのぞく

                        dt = (worksheet.Cell(i, "m").Value).substring(3)    '価格:#,###&vbLF
                        dt = dt.Substring(0, dt.Length - 1)
                        g価格 = dt.Replace(",", "") '","をのぞく

                        dt = worksheet.Cell(i, "d").Value        ' g日付
                        g日付 = dt.Substring(0, 10)



                        Select Case MessageBox.Show("" & g銘柄コード & " " & g銘柄名 & "を" _
                & g株数 & " " & g価格 & "'現物買'で、登録しますか？",
               "確認", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

                            Case Windows.Forms.DialogResult.Yes
                            Case Else
                                GoTo nextRec
                        End Select



                        '追加Dataのセット
                        msSQL = " INSERT INTO MTD_取得 ( "
                        msSQL += " [入力ID]"
                        msSQL += " ,[銘柄コード]"
                        msSQL += " ,[銘柄名]"
                        msSQL += " ,[取引名称]"
                        msSQL += " ,[取得株数]"
                        msSQL += " ,[取得単価]"
                        msSQL += " ,[取得日付]"
                        msSQL += " ,[残株数]"
                        msSQL += " ,[現況]"
                        msSQL += " )"

                        msSQL += "  VALUES "
                        msSQL += " ('" & 入力ID & "'"                        ' <入力ID, nvarchar(10),>
                        msSQL += ",'" & g銘柄コード & "'"
                        msSQL += ",'" & g銘柄名 & "'"
                        msSQL += ",'現物買'"
                        msSQL += ",'" & g株数 & "'"
                        msSQL += ",'" & g価格 & "'"
                        msSQL += ",'" & g日付 & "'"   ' g日付
                        msSQL += ",'" & g株数 & "'"
                        msSQL += ",'特定預り'"
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

                    ' 
                    ''　現引 
                    '------------------------------
                    Case "現引"
                        MsgBox($"{g取引名称}は、未完成です")
                        worksheet.Cell(i, "N").Value = "NG"

                        'Dim 入力ID As String = getMaxId().ToString

                        ' g銘柄コード = worksheet.Cell(i, "I").Value

                        'dt = worksheet.Cell(i, "J").Value       '銘柄名 &vbLF
                        ' g銘柄名 = dt.Substring(0, (dt.Length - 1))

                        'dt = worksheet.Cell(i, "L").Value        '"株数:1,000 &vbLF
                        'dt = dt.Substring(3)
                        'dt = dt.Substring(0, dt.Length - 1)
                        ' g株数 = dt.Replace(",", "") '","をのぞく

                        'dt = (worksheet.Cell(i, "m").Value).substring(3)    '価格:#,###&vbLF
                        'dt = dt.Substring(0, dt.Length - 1)
                        ' g価格 = dt.Replace(",", "") '","をのぞく

                        'dt = worksheet.Cell(i, "d").Value        ' g日付
                        ' g日付 = dt.Substring(0, 10)


                        'Dim sfrm As New sfrmExcel返済
                        'sfrm.txt銘柄コード.Text =  g銘柄コード
                        'sfrm.txt銘柄名.Text =  g銘柄名
                        'sfrm.txt決済総株数.Text =  g株数
                        'sfrm.txt価格.Text =  g価格
                        'sfrm.txt g日付.Text =  g日付
                        'sfrm.txt取引名称.Text = "現引"
                        'Call sfrm.ShowDialog()


                    Case Else
                        MsgBox($"{g取引名称}は、未完成です")
                        worksheet.Cell(i, "N").Value = "NG"

                End Select
nextRec:        i += 1
            Loop
            ' // ワークブックを保存する
            workbook.SaveAs(sテンプレートパス)

            MsgBox("全Recを手続きしました")

        End Using



        ' Catch ex As Exception

        'パスD:\カシオペイア\カシオペイア-Work\bin\Debug\Temp\会員名簿.xlsx' の一部が見つかりませんでした。
        ' sfrmメッセージ.ShowDialog(ex.Message, "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error)

        ' End Try





        ' Call excel読込み()
    End Sub

    Private Sub dgv直近一覧_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv直近一覧.CellClick

        If e.RowIndex < 0 Then Exit Sub
        If e.ColumnIndex < 0 Then Exit Sub

        'IDを取得
        ' colNam = dgv一覧.Columns(0).Name    '先頭の列名（ここでは”ID”）を取得

        Dim selID As String
        '  selID = dgv一覧.Rows(e.RowIndex).Cells(colNam).Value.ToString
        selID = dgv直近一覧.Rows(e.RowIndex).Cells("入力ID").Value.ToString

        '取得したIDを持つレコードを取り出す
        Dim cDB As New clsDB
        Dim dtblSelectData As New DataTable
        Dim mCommand As SqlCommand
        Dim mSDA As New SqlDataAdapter

        msSQL = "select * FROM MTD_取得 "
        msSQL += "where 入力ID =　" & "'" & selID & "'"

        mCommand = cDB.getsqlComand(msSQL)
        mSDA.SelectCommand = mCommand

        Call mSDA.Fill(dtblSelectData) ''データセット作成
        With dtblSelectData.Rows(0)
            Dim txtIDText As String = Trim(.Item("ID").ToString)
            Dim txt返済玉IDText As String = Trim(.Item("入力ID").ToString)
            Dim txtg銘柄コード As String = Trim(.Item("銘柄コード").ToString)
            Dim txt銘柄名Tex As String = Trim(.Item("銘柄名").ToString)
            Dim txt取引種別Text As String = Trim(.Item("取引種別").ToString)

            'txt取引区分.Text = Trim(.Item("取引区分").ToString)
            'txt返済株数.Text = Trim(.Item("取引株数").ToString)
            Dim txt残株数 As String = Trim(.Item("残株数").ToString)
            Dim txt価格 As String = Trim(.Item("取得単価").ToString)
            Dim txt取得日Text As String = Trim(.Item("取得日付").ToString)
        End With
    End Sub

    Private Sub btn取引集計_Click(sender As Object, e As EventArgs) Handles btn取引集計.Click
        Dim sfrm As New frm取引集計表
        Call sfrm.ShowDialog()

    End Sub
End Class
