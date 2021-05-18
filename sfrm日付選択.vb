Imports System.Windows.Forms

Public Class sfrm日付選択
    '選択日付
    Private get日付 As String
    Public Property 日付() As String
        Get
            Return get日付
        End Get
        Set(ByVal value As String)
            get日付 = value
        End Set
    End Property

    'Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
    '    Me.DialogResult = System.Windows.Forms.DialogResult.OK
    '    Me.Close()
    'End Sub

    'Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
    '    get日付 = ""

    '    Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
    '    Me.Close()
    'End Sub

    Private Sub mcd日付_DateSelected(sender As Object, e As DateRangeEventArgs) Handles mcd日付選択.DateSelected
        get日付 = mcd日付選択.SelectionStart.ToString("yyyy/MM/dd")
        Call Me.Close()
    End Sub

    Private Sub btn取消_Click(sender As Object, e As EventArgs) Handles btn取消.Click
        get日付 = ""
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub
End Class
