Imports System.Data
Imports System.Data.SqlClient

Public Class cls環境設定
    Private msSQL As String
    Private mCommand As SqlCommand
    Private mSDA As New SqlDataAdapter

    Dim myTable As New DataTable
    Dim getデフォルトプリンタ As String
    Dim getフリガナ As String
    Dim get会社名 As String
    Dim get代表者 As String
    Dim get郵便番号 As String
    Dim get住所 As String
    Dim get電話番号 As String
    Dim getFAX番号 As String
    Dim get銀行名 As String
    Dim get支店名 As String
    Dim get口座区分 As String
    Dim get口座番号 As String

    Dim get伝票左マージン As String

    Public ReadOnly Property フリガナ() As String
        Get
            Return getフリガナ
        End Get

    End Property

    Public ReadOnly Property 会社名() As String
        Get
            Return get会社名
        End Get

    End Property

    Public ReadOnly Property 代表者() As String
        Get
            Return get代表者
        End Get

    End Property

    Public ReadOnly Property 郵便番号() As String
        Get
            Return get郵便番号
        End Get

    End Property

    Public ReadOnly Property 住所() As String
        Get
            Return get住所
        End Get

    End Property

    Public ReadOnly Property 電話番号() As String
        Get
            Return get電話番号
        End Get

    End Property

    Public ReadOnly Property FAX番号() As String
        Get
            Return getFAX番号
        End Get

    End Property

    Public ReadOnly Property 銀行名() As String
        Get
            Return get銀行名
        End Get

    End Property

    Public ReadOnly Property 支店名() As String
        Get
            Return get支店名
        End Get

    End Property

    Public ReadOnly Property 口座区分() As String
        Get
            Return get口座区分
        End Get

    End Property

    Public ReadOnly Property 口座番号() As String
        Get
            Return get口座番号
        End Get

    End Property

    Public Sub New()
        Call 環境設定読込()
    End Sub

    Public Sub 環境設定読込()
        Dim pd As New System.Drawing.Printing.PrintDocument
        Dim cDB As New clsDB

        msSQL = "SELECT * FROM Mtd_環境設定"

        mCommand = cDB.getsqlComand(msSQL)
        mSDA.SelectCommand = mCommand
        Call mSDA.Fill(myTable) ''データセット作成

        ''デフォルトプリンタ情報の取得-----------------------------
        getデフォルトプリンタ = pd.PrinterSettings.PrinterName

        ''情報取得-------------------------------------------------
        For Each getRow As DataRow In myTable.Rows
            Select Case getRow("ID")
                Case 1 : getフリガナ = getRow("パラメータ")
                Case 2 : get会社名 = getRow("パラメータ")
                Case 3 : get代表者 = getRow("パラメータ")
                Case 4 : get郵便番号 = getRow("パラメータ")
                Case 5 : get住所 = getRow("パラメータ")
                Case 6 : get電話番号 = getRow("パラメータ")
                Case 7 : getFAX番号 = getRow("パラメータ")
                Case 8 : get銀行名 = getRow("パラメータ")
                Case 9 : get支店名 = getRow("パラメータ")
                Case 10 : get口座区分 = getRow("パラメータ")
                Case 11 : get口座番号 = getRow("パラメータ")

            End Select

        Next

    End Sub
End Class
