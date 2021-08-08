Imports System.Data.SqlClient

Public Class frm取引集計表
    'Private mSDA As New SqlDataAdapter
    'Private msSQL As String
    Private dtbl検索結果 As New DataTable
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
                msSQL += ",sum(b.返済株数 *( b.返済単価 - a.取得単価)) as 概算損益"

                msSQL += " FROM MTD_取得 as A left join MTD_返済 as b"
                msSQL += " On a.入力ID = b.返済元ID"

                msSQL += " Where a.銘柄コード = "
                msSQL += "'" & txt銘柄コード.Text & "'"      'ex'6857'
                msSQL += " group by rollup (b.返済日付 ,a.銘柄コード,a.銘柄名)"
                'mCommand = cDB.getsqlComand(msSQL)
                'mSDA.SelectCommand = mCommand

                'Call mSDA.Fill(dtbl検索結果) ''データセット作成
                'Dgv検索結果.DataSource = dtbl検索結果
            Case "2"      '取引履歴(日付ごと)
                msSQL = " select b.返済日付"
                msSQL += ",sum( b.返済株数) as 返済総数"
                msSQL += ",sum(b.返済株数 *( b.返済単価 - a.取得単価)) as 概算損益"
                msSQL += " FROM MTD_取得 as A left join MTD_返済 as b"
                msSQL += " on a.入力ID = b.返済元ID"
                msSQL += " group by rollup(b.返済日付) --,a.銘柄コード, a.銘柄名)"

            Case "3"               '  取引明細(銘柄別)
                Dim 集計日付始 As String = Dtp日付始.Value.ToShortDateString()
                Dim 集計日付終 As String = dtp日付終.Value.ToShortDateString()

                msSQL = " SELECT  a.ID as 返済ID,a.返済日付 , b.ID as 取得ID,b.取得日付"
                msSQL += ", b.銘柄コード as CODE , b.銘柄名"
                msSQL += ",b.取得株数, a.返済株数 ,b.残株数 "
                msSQL += ",a.返済単価,b.取得単価"
                msSQL += ", format(a.[返済株数] * a.[返済単価] - a.返済株数 * 取得単価,'#,##0') as 損益"
                msSQL += " FROM MTD_返済 as a left join MTD_取得 as b"
                msSQL += " on b.入力ID = a.返済元ID"

                msSQL += " WHERE 返済日付 >= '" + 集計日付始 + "'"
                msSQL += " And  返済日付 <= '" + 集計日付終 + "'"

                msSQL += " AND b.銘柄コード = "
                msSQL += "'" & txt銘柄コード.Text & "'"      'ex'6857'

                msSQL += " order by a.返済日付"

            Case "4" '未返済 一覧
                msSQL = " SELECT a.ID as 取得ID,a.取得日付 , b.ID as 返済ID,b.返済日付"
                msSQL += ", a.銘柄コード as CODE , a.銘柄名"
                msSQL += ",a.取得株数, b.返済株数 ,a.残株数"
                msSQL += " FROM Mtd_取得 as a left join MTd_返済 as b"
                msSQL += " on a.入力ID = b.返済元ID"
                msSQL += " where a.残株数 <> 0 and 現況='買建'"
                msSQL += " order by a.取得日付 desc"

            Case "5" '日付ごと取引状況

                '日付けの指定にあやまりはないか？
                If Dtp日付始.Value > dtp日付終.Value Then
                    MsgBox("集計日付始は集計日付終よりも前の日付を指定してください")
                    Exit Sub
                Else
                    Dim 集計日付始 As String = Dtp日付始.Value.ToShortDateString()
                    Dim 集計日付終 As String = dtp日付終.Value.ToShortDateString()
                    '集計日付始 = Dtp日付始.Text.Substring(0, 4) &
                    '               Dtp日付始.Text.Substring(5, 2) &
                    '               Dtp日付始.Text.Substring(8, 2)

                    '集計日付終 = Dtp終.Text.Substring(0, 4) &
                    '            Dtp終.Text.Substring(5, 2) &
                    '            Dtp終.Text.Substring(8, 2)

                    ''取得の表示
                    msSQL = " SELECT "
                    msSQL += " min([入力ID]) as ID"
                    msSQL += ",[銘柄コード] as CODE"
                    msSQL += ",[銘柄名]"
                    msSQL += ",[取引名称]"
                    msSQL += ",sum(取得株数) as 株数"
                    msSQL += ",avg([取得単価]) as 価格"
                    msSQL += ",[取得日付] as 日付"
                    msSQL += " FROM [MTD_取得]"
                    msSQL += " WHERE 取得日付 >= '" + 集計日付始 + "'"
                    msSQL += " And  取得日付 <= '" + 集計日付終 + "'"
                    msSQL += "group by [銘柄コード],銘柄名,[取引名称],[取得日付]"
                    ''返済の表示
                    msSQL += "  UNION "

                    msSQL += " SELECT"
                    msSQL += " MAX(a.[入力ID]) as ID "
                    msSQL += ",b.銘柄コード as CODE"
                    msSQL += ",b.銘柄名"
                    msSQL += ",a.[取引名称]"
                    msSQL += ",sum([返済株数]) as 株数"
                    msSQL += ",AVG([返済単価]) as 価格"
                    msSQL += ",a.[返済日付] as 日付"
                    msSQL += " FROM [MTD_返済] as a INNER JOIN [MTD_取得] as b "
                    msSQL += " ON a.返済元ID = b.入力ID "

                    msSQL += " WHERE 返済日付 >= '" + 集計日付始 + "'"
                    msSQL += " And  返済日付 <= '" + 集計日付終 + "'"
                    msSQL += "group by  b.銘柄コード,b.銘柄名,a.[取引名称],a.[返済日付]"
                    msSQL += " ORDER BY 日付,取引名称"
                End If

            Case "6"    '/****** [MTD_返済] 損益計算 with grouping set ******/

                Dim 集計日付始 As String = Dtp日付始.Value.ToShortDateString()
                Dim 集計日付終 As String = dtp日付終.Value.ToShortDateString()

                msSQL = " SELECT "
                msSQL += " Case WHEN grouping(a.返済日付)=1 THEN  '＊　合　計　＊' "
                msSQL += " WHEN grouping(a.返済単価)=1 then '＊　日　計　＊' "
                msSQL += " Else cast( min(b.取得日付) As varchar(max)) End As 取得日付 "
                msSQL += ",case when grouping(a.返済日付)=1 then '' "
                msSQL += " when grouping(a.返済単価)=1 then '' "
                msSQL += " Else max(b.銘柄コード) End As CODE	"
                msSQL += ", Case WHEN grouping(a.返済日付)=1 then  '' "
                msSQL += " WHEN grouping(a.返済単価)=1 then '' "
                msSQL += " Else max(b.銘柄名) End As NAME "
                msSQL += ",case when grouping(a.返済日付)=1 then  '' "
                msSQL += " Else cast( min(a.返済日付) As varchar(max)) End As 返済日付 "
                msSQL += ",count(a.返済株数) AS 件数 "
                msSQL += ",sum(a.返済株数) AS 返済株数       "
                msSQL += ",format(avg(a.返済単価),'#,###') AS avg返済単価 "
                msSQL += " ,format(sum(a.返済株数*(a.返済単価-b.取得単価)),'#,###') as 概算損益 "
                msSQL += " FROM [MTD_返済] as a left join [MTD_取得] as b "
                msSQL += " ON a.返済元ID=b.入力ID"

                msSQL += " WHERE 返済日付 >= '" + 集計日付始 + "'"
                msSQL += " And  返済日付 <= '" + 集計日付終 + "'"
                msSQL += " group by grouping sets"
                msSQL += " (()"
                msSQL += " ,(a.返済日付)"
                msSQL += " ,(a.返済日付,a.返済単価/*,a.返済株数)*/)"
                msSQL += " )"

            Case Else

                MsgBox("mikannsei")
                Exit Sub
        End Select
        mCommand = cDB.getsqlComand(msSQL)
        mSDA.SelectCommand = mCommand

        Call mSDA.Fill(dtbl検索結果) ''データセット作成
        Dgv検索結果.DataSource = dtbl検索結果
        Dgv検索結果.Columns(0).Width = 150
        Dgv検索結果.Columns(1).Width = 150
        Dgv検索結果.Columns(2).Width = 150
        '  Dgv検索結果.Columns(3).Width = 150


        ' txt銘柄コード.Select()
    End Sub

    Private Sub Dtp日付始_ValueChanged(sender As Object, e As EventArgs) Handles Dtp日付始.ValueChanged

    End Sub

    Private Sub btnExcel出力_Click(sender As Object, e As EventArgs) Handles btnExcel出力.Click

        'sheet.Cell(1, 1).Value = Dgv検索結果(0, 0).Value
        'sheet.Cell(1, 2).Value = Dgv検索結果(1, 0).Value
        'sheet.Cell(1, 3).Value = Dgv検索結果(2, 0).Value




        '' ファイルに保存
        'book.SaveAs("c:\temp\取引集計表" & Format(Now, "yyyyMMdd HHmmss") & " .xlsx")




        'Dim sテンプレートパス As String = "Temp\会員名簿.xlsx"
        'Dim getExcelファイル As String

        '' Using workbook = New ClosedXML.Excel.XLWorkbook(sテンプレートパス)
        'Dim workbook = New ClosedXML.Excel.XLWorkbook(sテンプレートパス)

        ''Excelファイルを開く
        'Dim SFD As New OpenFileDialog
        'Dim sFname As String        'selected file name 
        ''Dim di As New System.IO.DirectoryInfo(sフォルダ)
        ''di.Create()
        'With SFD
        '    .FileName = "TradeRep01"
        '    .Filter = "excelファイル(*.xlsx,*.xlmx)|*.xlsx;*.xlmx"
        '    .Title = "excelファイル名は？"
        '    .RestoreDirectory = True
        '    .CheckFileExists = True
        '    .CheckPathExists = True

        '    '' dialog　ＯＫ が押されたら次へ
        '    If .ShowDialog <> Windows.Forms.DialogResult.OK Then Exit Sub

        '    MsgBox(.FileName)
        '    Console.WriteLine(.FileName)
        '    sFname = .FileName
        'End With
        ' End Using
        'ワークブックを保存する
        '  Using sfd As SaveFileDialog = New SaveFileDialog
        Dim sfd As SaveFileDialog = New SaveFileDialog


        'デフォルトのファイル名を指定します
        sfd.Filter = "Excelファイル(*.xlsx)|*.xlsx"
        sfd.FileName = "取引集計表" & Format(Now, "yyyyMMdd HHmm") & " .xlsx"
        sfd.InitialDirectory = System.Windows.Forms.Application.StartupPath & "\Excel集計表"

        If sfd.ShowDialog() = DialogResult.OK Then
            ' ワークブックを作成
            Dim book As New ClosedXML.Excel.XLWorkbook
            ' ワークシートを作成し、シートを取得
            Dim sheet As ClosedXML.Excel.IXLWorksheet = book.Worksheets.Add("page1")
            ' 列ヘッダーをコピー
            For i = 0 To Dgv検索結果.ColumnCount - 1
                sheet.Cell(1, i + 1).Value = Dgv検索結果.Columns(i).Name
            Next
            ' 行列番号でセルを指定して値を挿入
            ' ExcelSheetは(行,列),DGVは(列,行)の並び
            ' インデックスはExcelSheetは[１]から始まるDGVは[0]から始まる
            For r = 1 To Dgv検索結果.RowCount - 1
                For i = 0 To Dgv検索結果.ColumnCount - 1
                    sheet.Cell(r + 1, i + 1).Value = Dgv検索結果(i, r).Value

                Next
            Next

            ' getExcelファイル = sfd.FileName
            book.SaveAs(sfd.FileName)     ''別ブックで保存

        End If
        ' End Using
    End Sub
End Class