Imports System.Data.SqlClient

Public Class sfrmExcel返済
    Private mCommand As SqlCommand
    Private mSDA As New SqlDataAdapter
    Private 返済後残株数 As Integer = 0
    'Dim 銘柄名Text As String
    'Dim 株数Text As String
    'Dim 価格Text As String
    'Dim 決済日付 As String

    Private Sub sfrmExcel返済_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txt返済ID.Text = getMaxId.ToString
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
        msSQL += " and 残株数 <> 0"
        msSQL += " AND 現況<>'現引'"
        mCommand = cDB.getsqlComand(msSQL)
        mSDA.SelectCommand = mCommand

        Call mSDA.Fill(myTable) ''データセット作成

        If myTable.Rows.Count = 0 Then
            MsgBox("返済'玉'がありません")

            'excelファイルにNGマーク
            Me.DialogResult = System.Windows.Forms.DialogResult.No
            Me.Close()
        Else
            dgv返済玉.DataSource = myTable
        End If


    End Sub
    Private Sub dgv返済玉_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgv返済玉.CellMouseClick

        If e.RowIndex < 0 Then Exit Sub
        If e.ColumnIndex < 0 Then Exit Sub

        'IDを取得
        ' colNam = dgv一覧.Columns(0).Name    '先頭の列名（ここでは”ID”）を取得

        Dim selID As String
        '  selID = dgv一覧.Rows(e.RowIndex).Cells(colNam).Value.ToString
        selID = dgv返済玉.Rows(e.RowIndex).Cells("入力ID").Value.ToString

        '取得したIDを持つレコードを取り出す
        Dim cDB As New clsDB
        Dim msSQL As String
        Dim dtblSelectData As New DataTable
        Dim mCommand As SqlCommand
        Dim mSDA As New SqlDataAdapter

        msSQL = "select * FROM MTD_取得 "
        msSQL += "where 入力ID =　" & "'" & selID & "'"

        mCommand = cDB.getsqlComand(msSQL)
        mSDA.SelectCommand = mCommand

        Call mSDA.Fill(dtblSelectData) ''データセット作成
        With dtblSelectData.Rows(0)
            txt返済玉ID.Text = Trim(dtblSelectData.Rows(0)("ID").ToString)
            '    txt返済玉ID.Text = Trim(.Item("ID").ToString)
            txt返済玉入力ID.Text = Trim(.Item("入力ID").ToString)
            txt返済玉銘柄コード.Text = Trim(.Item("銘柄コード").ToString)
            txt返済玉銘柄名.Text = Trim(.Item("銘柄名").ToString)
            If txtg取引名称.Text = "現引" Then

                txt現況.Text = "現引"

            Else

                txt現況.Text = "返済済"
            End If
            txt返済株数.Text = Trim(.Item("取得株数").ToString)
            txt返済玉価格.Text = Trim(.Item("取得単価").ToString)
            txt返済玉取得日.Text = Trim(.Item("取得日付").ToString)
        End With

        'ほんとうに登録しますか？
        ''    Select Case MessageBox.Show("" & txt返済玉銘柄コード.Text & txt返済玉銘柄名.Text & "を" _
        '            & txt返済玉取引種別.Text & " " & txt返済玉価格.Text & "'返済売'で、登録しますか？",
        '           "確認", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        '        Case Windows.Forms.DialogResult.Yes
        '仮の売買差額を表示
        Dim int返済株数 As Integer
        Dim int残株数 As Integer = Integer.Parse(txt決済総株数.Text)

        int返済株数 = Integer.Parse(txt返済株数.Text)

        Dim d取得単価 As Single = Double.Parse(txt返済玉価格.Text)

        Dim d返済単価 As Single = Double.Parse(txt価格.Text)
        返済後残株数 = (int残株数 - int返済株数)
        txt返済後残株数.Text = 返済後残株数.ToString

        txt決済総株数.Text = 返済後残株数.ToString
        txt概算損益.Text = (int返済株数 * (d返済単価 - d取得単価)).ToString("C")

        'Case Else

        'Exit Sub
        'End Select

        '   Dim toInt As Integer
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
        msSQL += ",'信用返済売'"          ' ,<取引名称, nvarchar(5),>
        msSQL += ",'" + txt返済株数.Text + "'"          ' ,<返済株数, int,>
        msSQL += ",'" + txt価格.Text + "'"          ' ,<返済単価, int,>)
        msSQL += ") "

        msSQL += "update MTD_取得 "
        If txt現況.Text = "現引" Then
            msSQL += "set 現況 = '現引'"

        Else
            msSQL += "set 残株数= "
            'toInt = Integer.Parse(txt残株数.Text)
            'mssql += "'" + toInt + "'"
            msSQL += "'0'"      '当建玉は全返済するので残は必ず '0’
        msSQL += ", 現況 = "
            msSQL += "'返済済'"
        End If

        msSQL += " where ID = "
        msSQL += "'" + txt返済玉ID.Text + "'"

        mCommand = cDB.getsqlComand(msSQL)
        Call mCommand.ExecuteNonQuery()

        ''複数回の返済を1回で通知された場合
        If 返済後残株数 > 0 Then
            '  MsgBox("建玉別の返済を続けます")
            txt返済ID.Text = getMaxId.ToString
            Call 返済玉表示()

        Else
            ' MsgBox("返済手続きは、完了しました")
            Me.DialogResult = System.Windows.Forms.DialogResult.OK
            Me.Close()
        End If
    End Sub

End Class