Public Class Form1

    Private Function Rot13Caesar(plaintext As String) As String
        Dim ciphertext As String = ""
        For Each ch As Char In plaintext
            If Char.IsLetter(ch) Then
                If Char.IsUpper(ch) Then
                    ciphertext += Chr(((Asc(ch) - 65 + 13) Mod 26) + 65)
                Else
                    ciphertext += Chr(((Asc(ch) - 97 + 13) Mod 26) + 97)
                End If
            Else
                ciphertext += ch
            End If
        Next
        Return ciphertext
    End Function

    Private Sub btn_encrypt_Click(sender As Object, e As EventArgs) Handles btn_encrypt.Click
        If txt_inputData.Text <> "" Then
            Dim txtInputData As String = txt_inputData.Text
            txt_encrypt.Text = Rot13Caesar(txtInputData)
        End If
    End Sub

    Private Sub btn_new_Click(sender As Object, e As EventArgs) Handles btn_new.Click
        txt_inputData.Text = ""
        txt_encrypt.Text = ""
        txt_decrypt.Text = ""
    End Sub

    Private Sub btn_decrypt_Click(sender As Object, e As EventArgs) Handles btn_decrypt.Click
        If txt_encrypt.Text <> "" Then
            Dim txtEncrypt As String = txt_encrypt.Text
            txt_decrypt.Text = Rot13Caesar(txtEncrypt)
        End If
    End Sub
End Class
