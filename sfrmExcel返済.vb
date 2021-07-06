Imports System.Data.SqlClient

Public Class sfrmExcel返済
    Private mCommand As SqlCommand
    Private mSDA As New SqlDataAdapter
    Private g返済株数 As Integer
    Private g返済後未返済株数 As Integer = 0
    Private s残株数 As Integer      'dgv返済玉_CellClick で選択された[MTD_取得]の項目[残株数]
    Private s返済後残株数 As Integer
    Private k今回返済数 As Integer   'このLoopで返済する株数
    'Dim 株数Text As String
    'Dim 価格Text As String
    'Dim 決済日付 As String

    Private Sub sfrmExcel返済_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txt返済ID.Text = getMaxId.ToString

        g返済株数 = Integer.Parse(txtg返済株数.Text)      'gmailから読み込んだ返済株数
        g返済後未返済株数 = g返済株数
        lblガイド.Text = "返済にあてる建玉をえらんで"
        Call 返済玉表示()

    End Sub
    Private Sub 返済玉表示()
        Dim cDB As New clsDB
        Dim msSQL As String
        Dim myTable As New DataTable

        msSQL = " select *"
        msSQL += " from MTD_取得 "
        msSQL += " where [銘柄コード]= "
        msSQL += "'" & txtg銘柄コード.Text & "'"
        msSQL += " and 残株数 > '0'"
        msSQL += " AND 現況 <> '現引'"

        mCommand = cDB.getsqlComand(msSQL)
        mSDA.SelectCommand = mCommand
        Call mSDA.Fill(myTable) ''データセット作成
        dgv返済玉.DataSource = myTable

        If myTable.Rows.Count = 0 Then
            MsgBox("返済'玉'がありません")
            'excelファイルにNGマーク入れてもらう
            Me.DialogResult = System.Windows.Forms.DialogResult.No
            Me.Close()
        End If
    End Sub
    Private Sub dgv返済玉_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv返済玉.CellClick

        If e.RowIndex < 0 Then Exit Sub
        If e.ColumnIndex < 0 Then Exit Sub

        'IDを取得
        ' colNam = dgv一覧.Columns(0).Name    '先頭の列名（ここでは”ID”）を取得

        Dim selID As String
        '  selID = dgv一覧.Rows(e.RowIndex).Cells(colNam).Value.ToString
        selID = dgv返済玉.Rows(e.RowIndex).Cells("ID").Value.ToString      'selected ID

        '取得したIDを持つレコードを取り出す
        Dim cDB As New clsDB
        Dim msSQL As String
        Dim dtblSelectedData As New DataTable
        Dim mCommand As SqlCommand
        Dim mSDA As New SqlDataAdapter
        msSQL = "select * FROM MTD_取得 "
        msSQL += "where ID =　" & "'" & selID & "'"
        mCommand = cDB.getsqlComand(msSQL)
        mSDA.SelectCommand = mCommand
        Call mSDA.Fill(dtblSelectedData) ''データセット作成

        s残株数 = dtblSelectedData.Rows(0).Item("残株数")
        s返済後残株数 = s残株数
        For Each getデータ As DataRow In dtblSelectedData.Rows
            txt返済玉ID.Text = getデータ("ID")
            txt返済玉入力ID.Text = getデータ("入力ID")
            txt返済玉銘柄コード.Text = getデータ("銘柄コード")
            txt返済玉銘柄名.Text = getデータ("銘柄名")

            'If txtg取引名称.Text = "現引" Then

            '    txt現況.Text = "現引"

            ' Else

            txt現況.Text = "返済済"
            ' End If
            txt返済株数.Text = getデータ("取得株数")
            txt返済玉価格.Text = getデータ("取得単価")
            txt返済玉取得日.Text = getデータ("取得日付")
        Next

        If s残株数 >= g返済後未返済株数 Then
            '選択された建玉の(s残株数)の一部または全部を使って
            'g返済後未返済株数の全部を返済する
            k今回返済数 = g返済後未返済株数
            s返済後残株数 -= k今回返済数        'このLoopで何株残るか？
            g返済後未返済株数 = 0

            msSQL = "INSERT INTO [dbo].[MTD_返済]"
            msSQL += "([入力ID]"
            msSQL += " ,[返済日付]"
            msSQL += " ,[返済元ID]"
            msSQL += " ,[取引名称]"
            msSQL += " ,[返済株数]"
            msSQL += " ,[返済単価])"

            msSQL += " VALUES ( "
            msSQL += "'" + txt返済ID.Text + "'"          ' ,<入力ID, nvarchar(9),>
            '  Dim dt As Date = DateTime.Parse(txt返済日付.Text)
            '  mssql += ",'" + txt返済日付.Text + "'"          ' ,<返済日付, date,>
            msSQL += ",'" + txtg日付.Text + "'"
            msSQL += ",'" + txt返済玉入力ID.Text + "'"          ' ,<返済元ID, nvarchar(9),>
            msSQL += ",'" + txtg取引名称.Text + "'"          ' ,<取引名称, nvarchar(5),>
            msSQL += ",'" + k今回返済数.ToString + "'"          ' ,<返済株数, int,>
            msSQL += ",'" + txtg価格.Text + "'"          ' ,<返済単価, int,>)
            msSQL += ") "

            msSQL += "update MTD_取得 "
            Select Case txtg取引名称.Text
                Case "現引"
                    msSQL += "set 現況 = '" & txtg取引名称.Text & "'"
                Case "現物売"  '
                    msSQL += "set 残株数= "
                    msSQL += "'" + s返済後残株数.ToString + "'"

                    msSQL += ", 現況 = "
                    If s返済後残株数 <= 0 Then
                        msSQL += "'現物売'"
                    Else
                        msSQL += "'一部返済'"
                    End If

                Case Else   '"信用返済売"
                    msSQL += "set 残株数= "
                    msSQL += "'" + s返済後残株数.ToString + "'"

                    msSQL += ", 現況 = "
                    If s返済後残株数 <= 0 Then
                        msSQL += "'返済済'"
                    Else
                        msSQL += "'一部返済'"
                    End If
            End Select

            msSQL += " where ID = "
            msSQL += "'" + txt返済玉ID.Text + "'"

            mCommand = cDB.getsqlComand(msSQL)
            Call mCommand.ExecuteNonQuery()

            MsgBox("返済手続きは、完了しました")
            Me.DialogResult = System.Windows.Forms.DialogResult.OK
            Me.Close()
            Exit Sub
            '/************** 一回で返済できないときの処理 ***************/
        Else        '
            k今回返済数 = s残株数
            msSQL = "INSERT INTO [dbo].[MTD_返済]"
            msSQL += "([入力ID]"
            msSQL += " ,[返済日付]"
            msSQL += " ,[返済元ID]"
            msSQL += " ,[取引名称]"
            msSQL += " ,[返済株数]"
            msSQL += " ,[返済単価])"

            msSQL += " VALUES ( "
            msSQL += "'" + txt返済ID.Text + "'"          ' ,<入力ID, nvarchar(9),>
            '  Dim dt As Date = DateTime.Parse(txt返済日付.Text)
            '  mssql += ",'" + txt返済日付.Text + "'"          ' ,<返済日付, date,>
            msSQL += ",'" + txtg日付.Text + "'"
            msSQL += ",'" + txt返済玉入力ID.Text + "'"          ' ,<返済元ID, nvarchar(9),>
            msSQL += ",'" & txtg取引名称.Text & "'"         ' ,<取引名称, nvarchar(5),>
            msSQL += ",'" + k今回返済数.ToString + "'"          ' ,<返済株数, int,>
            msSQL += ",'" + txtg価格.Text + "'"          ' ,<返済単価, int,>)
            msSQL += ") "

            msSQL += "update MTD_取得 "
            Select Case txtg取引名称.Text
                Case "現引"
                    msSQL += "set 現況 = '" & txtg取引名称.Text & "'"
                Case "現物売"  '
                    msSQL += "set 残株数= '0'"

                    msSQL += ", 現況 = '現物売'"

                Case Else   '"信用返済売"
                    msSQL += "set 残株数= '0'"      '当建玉は全返済するので残は必ず '0’
                    msSQL += ", 現況 = '返済済' "
            End Select


            msSQL += " where ID = "
            msSQL += "'" + txt返済玉ID.Text + "'"

            mCommand = cDB.getsqlComand(msSQL)
            Call mCommand.ExecuteNonQuery()

            g返済後未返済株数 -= k今回返済数
            Call 返済玉表示()

            If g返済後未返済株数 > 0 Then
                ' MsgBox("建玉別の返済を続けます")
                lblガイド.Text = "目標に達していないので返済を続けます、建玉を選んで(⋈◍＞◡＜◍)。✧♡マーク"
                txt返済ID.Text = getMaxId.ToString

            Else
                lblガイド.Text = "返済手続きは、完了しました"
                '  MsgBox("返済手続きは、完了しました")
                Me.DialogResult = System.Windows.Forms.DialogResult.OK
                Me.Close()
            End If

        End If

        'ほんとうに登録しますか？
        ''    Select Case MessageBox.Show("" & txt返済玉銘柄コード.Text & txt返済玉銘柄名.Text & "を" _
        '            & txt返済玉取引種別.Text & " " & txt返済玉価格.Text & "'返済売'で、登録しますか？",
        '           "確認", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        '        Case Windows.Forms.DialogResult.Yes
        ''仮の売買差額を表示
        'Dim int返済株数 As Integer
        'Dim int残株数 As Integer = Integer.Parse(txtg返済株数.Text)

        'int返済株数 = Integer.Parse(txt返済株数.Text)

        'Dim d取得単価 As Single = Double.Parse(txt返済玉価格.Text)

        'Dim d返済単価 As Single = Double.Parse(txtg価格.Text)
        's返済後残株数 = (int残株数 - int返済株数)
        ''   txt返済後残株数.Text = s返済後残株数.ToString

        '' txtg返済株数.Text = 返済後残株数.ToString
        'txt概算損益.Text = (int返済株数 * (d返済単価 - d取得単価)).ToString("C")

        ''Case Else

        ''Exit Sub
        ''End Select

        ''   Dim toInt As Integer






    End Sub

End Class