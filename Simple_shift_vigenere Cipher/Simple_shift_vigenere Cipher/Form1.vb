Public Class Form1

    Private Function S_S_VigenereEncrypt(encryptionDataText As String, key As String) As String
        Dim ciphertext As String = ""
        Dim keyIndex As Integer = 0
        For Each ch As Char In encryptionDataText
            If Char.IsLetter(ch) Then
                Dim shift As Integer = Asc(Char.ToUpper(key(keyIndex))) - 65
                If Char.IsUpper(ch) Then
                    ciphertext += Chr(((Asc(ch) - 65 + shift) Mod 26) + 65)
                Else
                    ciphertext += Chr(((Asc(ch) - 97 + shift) Mod 26) + 97)
                End If
                keyIndex = (keyIndex + 1) Mod key.Length
            Else
                ciphertext += ch
            End If
        Next
        Return ciphertext
    End Function

    Private Function S_S_VigenereDecrypt(decryptionDataText As String, key As String) As String
        Dim plaintext As String = ""
        Dim keyIndex As Integer = 0
        For Each ch As Char In decryptionDataText
            If Char.IsLetter(ch) Then
                Dim shift As Integer = Asc(Char.ToUpper(key(keyIndex))) - 65
                If Char.IsUpper(ch) Then
                    plaintext += Chr(((Asc(ch) - 65 - shift + 26) Mod 26) + 65)
                Else
                    plaintext += Chr(((Asc(ch) - 97 - shift + 26) Mod 26) + 97)
                End If
                keyIndex = (keyIndex + 1) Mod key.Length
            Else
                plaintext += ch
            End If
        Next
        Return plaintext
    End Function

    Private Sub btn_new_Click(sender As Object, e As EventArgs) Handles btn_new.Click
        txt_inputData.Text = ""
        txt_key.Text = ""
        txt_encrypt.Text = ""
        txt_decrypt.Text = ""
    End Sub

    Private Sub btn_encrypt_Click(sender As Object, e As EventArgs) Handles btn_encrypt.Click
        Dim txtInputData As String = txt_inputData.Text
        Dim key As String = txt_key.Text
        If txtInputData <> "" And key <> "" Then
            txt_encrypt.Text = S_S_VigenereEncrypt(txtInputData, key)
        End If
    End Sub

    Private Sub btn_decrypt_Click(sender As Object, e As EventArgs) Handles btn_decrypt.Click
        Dim txtEncrypt As String = txt_encrypt.Text
        Dim key As String = txt_key.Text
        If txtEncrypt <> "" And key <> "" Then
            txt_decrypt.Text = S_S_VigenereDecrypt(txtEncrypt, key)
        End If
    End Sub
End Class
