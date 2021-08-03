Imports System.Data.SqlClient

Public Class frmメニュー2
    '  Private msSQL As String
    Private mCommand As SqlCommand
    Private mSDA As New SqlDataAdapter

    Private Sub frmメニュー2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim sfrm As New sfrmログイン
        Select Case sfrm.ShowDialog()
            Case DialogResult.OK
            Case Else
                Call Application.Exit()
        End Select

        lblVersion.Text = "Ver" + System.Reflection.Assembly.GetExecutingAssembly().GetName().Version.ToString()

        ''環境設定読み込み
        '  my環境設定 = New cls環境設定        'どのFormからも見えるようにModule内に定義している

    End Sub
    Private Sub frmメニュー2_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        ''環境設定読み込み
        my環境設定 = New cls環境設定
    End Sub

    Private Sub btn約定通知_Click(sender As Object, e As EventArgs) Handles btn約定通知.Click
        Dim cDB As New clsDB
        Dim msSQL As String
        Dim myTable As New DataTable
        Dim g取引名称 As String    　 'Excelに記されたgmailのデーター
        Dim g銘柄コード As String     'Excelに記されたgmailのデーター
        Dim g銘柄名 As String         'Excelに記されたgmailのデーター
        Dim g株数 As String           'Excelに記されたgmailのデーター
        Dim g価格 As String           'Excelに記されたgmailのデーター
        Dim g日付 As String           'Excelに記されたgmailのデーター
        ' Dim sFname As String = "C:\Users\hori9\OneDrive\ドキュメント\Gmail約定通知2021625_629.xlsx"

        'Excelファイルを開く
        Dim SFD As New OpenFileDialog
        Dim sFname As String        'selected file name 
        'Dim di As New System.IO.DirectoryInfo(sフォルダ)
        'di.Create()
        With SFD
            .Filter = "excelファイル(*.xlsx,*.xlmx)|*.xlsx;*.xlmx"
            .Title = "excelファイルを選択してください"
            .RestoreDirectory = True
            .CheckFileExists = True
            .CheckPathExists = True

            '' dialog　ＯＫ が押されたら次へ
            If .ShowDialog <> Windows.Forms.DialogResult.OK Then Exit Sub

            MsgBox(.FileName)
            Console.WriteLine(.FileName)
            sFname = .FileName
        End With





        Using workbook = New ClosedXML.Excel.XLWorkbook(sFname)

            ''/****************ワークシートを取得する************************/
            Dim worksheet As ClosedXML.Excel.IXLWorksheet = workbook.Worksheet("約定通知")
            '  Dim worksheet As ClosedXML.Excel.IXLWorksheet = workbook.Worksheet("retry")

            ''/*****************空白がでてくるまで読み続ける******************/
            Dim i As Integer = 1
            Do While (worksheet.Cell(i, "A").Value) <> ""   '空白がでてくるまで読み続ける

                ''/**** 共通部分 Excel Gmail データーを取得 ****/
                Dim dt As String

                dt = (worksheet.Cell(i, "G").Value)   '取引名称 & vbLF  
                g取引名称 = dt.Substring(0, (dt.Length - 1))

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



                '/************** 取引種別ごとに分ける *****************/
                Select Case g取引名称
                    Case "信用新規買"
                        '  If g取引名称 = "信用新規買" Then

                        ''信用新規買 登録
                        '  txt入力ID.Text = 入力ID最大取得.maxID
                        Dim 入力ID As String = getMaxId().ToString

                        '         Select Case MessageBox.Show("" & g銘柄コード & " " & g銘柄名 & "を" _
                        ' & g株数 & " " & g価格 & "'新規買'で、登録しますか？",
                        '"確認", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

                        '             Case Windows.Forms.DialogResult.Yes
                        '             Case Else
                        '                 GoTo nextRec
                        '         End Select
                        If System.Windows.Forms.DialogResult.Yes <>
        MessageBox.Show("" & g銘柄コード & " " & g銘柄名 & "を" _
& g株数 & " " & g価格 & "'新規買'で、登録しますか？",
"確認", MessageBoxButtons.YesNo, MessageBoxIcon.Question) Then

                            'Case Windows.Forms.DialogResult.Yes
                            'Case Else
                            '    GoTo nextRec
                            worksheet.Cell(i, "N").Value = "NG"
                            GoTo nextRec
                        End If
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

                    ' 
                    ''信用返済売 
                    '------------------------------
                    Case "信用返済売", "現物売"
                        Dim 入力ID As String = getMaxId().ToString

                        '  g銘柄コード = worksheet.Cell(i, "I").Value

                        'dt = worksheet.Cell(i, "J").Value       '銘柄名 &vbLF
                        'g銘柄名 = dt.Substring(0, (dt.Length - 1))

                        'dt = worksheet.Cell(i, "L").Value        '"株数:1,000 &vbLF
                        'dt = dt.Substring(3)
                        'dt = dt.Substring(0, dt.Length - 1)
                        'g株数 = dt.Replace(",", "") '","をのぞく

                        'dt = (worksheet.Cell(i, "m").Value).substring(3)    '価格:#,###&vbLF
                        'dt = dt.Substring(0, dt.Length - 1)
                        'g価格 = dt.Replace(",", "") '","をのぞく

                        'dt = worksheet.Cell(i, "d").Value        ' g日付
                        'g日付 = dt.Substring(0, 10)


                        Dim sfrm As New sfrmExcel返済
                        sfrm.txtg銘柄コード.Text = g銘柄コード
                        sfrm.txtg銘柄名.Text = g銘柄名
                        sfrm.txtg返済株数.Text = g株数
                        sfrm.txtg価格.Text = g価格
                        sfrm.txtg日付.Text = g日付
                        sfrm.txtg取引名称.Text = g取引名称
                        If System.Windows.Forms.DialogResult.OK <> sfrm.ShowDialog() Then   'sfrmExcel返済に一任する
                            worksheet.Cell(i, "N").Value = "NG"
                        End If
                         ' 
                    ''　現物買 
                    '------------------------------
                    Case "現物買"
                        Dim 入力ID As String = getMaxId().ToString

                        'g銘柄コード = worksheet.Cell(i, "I").Value

                        'dt = worksheet.Cell(i, "J").Value       '銘柄名 &vbLF
                        'g銘柄名 = dt.Substring(0, (dt.Length - 1))


                        'dt = worksheet.Cell(i, "L").Value        '"株数:1,000 &vbLF
                        'dt = dt.Substring(3)
                        'dt = dt.Substring(0, dt.Length - 1)
                        'g株数 = dt.Replace(",", "") '","をのぞく

                        'dt = (worksheet.Cell(i, "m").Value).substring(3)    '価格:#,###&vbLF
                        'dt = dt.Substring(0, dt.Length - 1)
                        'g価格 = dt.Replace(",", "") '","をのぞく

                        'dt = worksheet.Cell(i, "d").Value        ' g日付
                        'g日付 = dt.Substring(0, 10)


                        If System.Windows.Forms.DialogResult.Yes <>
                         MessageBox.Show("" & g銘柄コード & " " & g銘柄名 & "を" _
                & g株数 & " " & g価格 & "'現物買'で、登録しますか？",
               "確認", MessageBoxButtons.YesNo, MessageBoxIcon.Question) Then

                            'Case Windows.Forms.DialogResult.Yes
                            'Case Else
                            '    GoTo nextRec
                            worksheet.Cell(i, "N").Value = "NG"
                            GoTo nextRec

                        End If



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
                        '  MsgBox($"{g取引名称}は、未完成です")

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

                        Dim sfrm As New sfrmExcel返済
                        sfrm.txtg銘柄コード.Text = g銘柄コード
                        sfrm.txtg銘柄名.Text = g銘柄名
                        sfrm.txtg返済株数.Text = g株数
                        sfrm.txtg価格.Text = g価格
                        sfrm.txtg日付.Text = g日付
                        sfrm.txtg取引名称.Text = g取引名称
                        If System.Windows.Forms.DialogResult.OK <> sfrm.ShowDialog() Then   'sfrmExcel返済に一任する
                            worksheet.Cell(i, "N").Value = "NG"
                        End If

                    Case Else
                        MsgBox($"{g取引名称}は、未完成です")
                        worksheet.Cell(i, "N").Value = "NG"

                End Select
nextRec:        i += 1
            Loop
            ' // ワークブックを保存する
            workbook.SaveAs(sFname)

            MsgBox("全Recを手続きしました")

        End Using



    End Sub
End Class