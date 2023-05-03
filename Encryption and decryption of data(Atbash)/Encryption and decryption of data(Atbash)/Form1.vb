Public Class Form1

    Private Function AtbashCipher(data As String) As String
        Dim result As String = ""
        For Each ch As Char In data
            If Char.IsLetter(ch) Then
                If Char.IsUpper(ch) Then
                    result += Chr(155 - Asc(ch)) ' Chr(155 - 65)  = Chr(90)
                Else
                    result += Chr(219 - Asc(ch))
                End If
            Else
                result += ch
            End If
        Next
        Return result
    End Function

    Private Sub btn_encrypt_Click(sender As Object, e As EventArgs) Handles btn_encrypt.Click
        Dim txtInputData As String = txt_inputData.Text
        If txtInputData <> "" Then
            txt_encrypt.Text = AtbashCipher(txtInputData)
        End If
    End Sub

    Private Sub btn_decrypt_Click(sender As Object, e As EventArgs) Handles btn_decrypt.Click
        Dim txtEncrypt As String = txt_encrypt.Text
        If txtEncrypt <> "" Then
            txt_decrypt.Text = AtbashCipher(txtEncrypt)
        End If
    End Sub

    Private Sub btn_new_Click(sender As Object, e As EventArgs) Handles btn_new.Click
        txt_inputData.Text = ""
        txt_encrypt.Text = ""
        txt_decrypt.Text = ""
    End Sub
End Class
