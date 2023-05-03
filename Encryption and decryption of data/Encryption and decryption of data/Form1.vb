Imports System.Security.Cryptography
Imports System.Text

Public Class Form1

    Private Function GenerateKey(keySize As Integer) As Byte()
        Dim salt As Byte() = New Byte() {1, 2, 3, 4, 5, 6, 7, 8} ' Use a random salt
        Dim derivedBytes As New Rfc2898DeriveBytes("myPassword", salt, 1000) ' Use a password-based key derivation function
        Return derivedBytes.GetBytes(keySize / 8) ' Divide key size by 8 to get byte size
    End Function

    Private Function EncryptData(data As String, key As Byte()) As String
        Dim aesProvider As AesCryptoServiceProvider = New AesCryptoServiceProvider()
        aesProvider.Key = key
        aesProvider.GenerateIV()

        Dim transform As ICryptoTransform = aesProvider.CreateEncryptor()
        Dim dataBytes As Byte() = Encoding.Unicode.GetBytes(data)
        Dim encryptedBytes As Byte() = transform.TransformFinalBlock(dataBytes, 0, dataBytes.Length)

        Dim ivAndEncryptedData As Byte() = New Byte(aesProvider.IV.Length + encryptedBytes.Length - 1) {}
        Array.Copy(aesProvider.IV, ivAndEncryptedData, aesProvider.IV.Length)
        Array.Copy(encryptedBytes, 0, ivAndEncryptedData, aesProvider.IV.Length, encryptedBytes.Length)

        Return Convert.ToBase64String(ivAndEncryptedData)
    End Function


    Private Function DecryptData(data As String, key As Byte()) As String
        Dim aesProvider As AesCryptoServiceProvider = New AesCryptoServiceProvider()
        aesProvider.Key = key

        Dim ivAndEncryptedData As Byte() = Convert.FromBase64String(data)
        Dim iv As Byte() = New Byte(aesProvider.IV.Length - 1) {}
        Dim encryptedBytes As Byte() = New Byte(ivAndEncryptedData.Length - aesProvider.IV.Length - 1) {}
        Array.Copy(ivAndEncryptedData, iv, iv.Length)
        Array.Copy(ivAndEncryptedData, iv.Length, encryptedBytes, 0, encryptedBytes.Length)

        aesProvider.IV = iv
        Dim transform As ICryptoTransform = aesProvider.CreateDecryptor()
        Dim decryptedBytes As Byte() = transform.TransformFinalBlock(encryptedBytes, 0, encryptedBytes.Length)

        Return Encoding.Unicode.GetString(decryptedBytes)
    End Function



    Private Sub btn_encrypt_Click(sender As Object, e As EventArgs) Handles btn_encrypt.Click
        If txt_inputData.Text = "" Then
            Return
        Else
            Dim dataToEncrypt As String = txt_inputData.Text
            Dim encryptionKey As Byte() = {123, 45, 67, 89, 10, 32, 54, 76, 98, 43, 21, 34, 56, 78, 90, 32} ' Replace with your own key

            Dim encryptedData As String = EncryptData(dataToEncrypt, encryptionKey)

            txt_encrypt.Text = encryptedData
        End If
    End Sub

    Private Sub btn_decrypt_Click(sender As Object, e As EventArgs) Handles btn_decrypt.Click
        If txt_encrypt.Text = "" Then
            Exit Sub
        Else
            Dim encryptedData As String = txt_encrypt.Text
            Dim encryptionKey As Byte() = {123, 45, 67, 89, 10, 32, 54, 76, 98, 43, 21, 34, 56, 78, 90, 32} ' Replace with your own key

            Dim decryptedData As String = DecryptData(encryptedData, encryptionKey)
            txt_decrypt.Text = decryptedData
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        txt_inputData.Text = ""
        txt_encrypt.Text = ""
        txt_decrypt.Text = ""
    End Sub
End Class
