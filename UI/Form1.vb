Public Class Form1


    Private Sub txt_nome_TextChanged(sender As Object, e As EventArgs) Handles txt_nome.TextChanged


    End Sub

    Private Sub btn_click_Click(sender As Object, e As EventArgs) Handles btn_click.Click
        Dim nome As String = txt_nome.Text
        MsgBox("Olá " & nome)

    End Sub
End Class
