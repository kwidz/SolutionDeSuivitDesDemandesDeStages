Imports System.Security.Cryptography

Module utilitaireMotsDePasse
    Public Function generateRandomPassword(Optional ByVal length As Integer = 10) As String
        Dim rand As New Random()
        Dim pass As String = ""

        For i As Integer = 1 To length Step 1
            Dim charNo As Integer = rand.Next(1, 62) ' Represents the 26 letters (lower and uppercase) and the 10 digits

            If charNo <= 10 Then ' Digits (1-10) : ASCII[48-57]
                charNo += 47
            ElseIf charNo <= 36 Then ' Uppercase letters (11-36) : ASCII[65-90]
                charNo += 54
            Else ' Lowercase letters (36-62) : ASCII[97-122]
                charNo += 60
            End If

            pass &= Chr(charNo)
        Next i

        Return pass
    End Function

    Public Function getSha1Hash(ByVal text As String) As String
        Dim hashAlg As SHA1 = SHA1.Create

        Dim hashvalue() As Byte = hashAlg.ComputeHash(System.Text.Encoding.Default.GetBytes(text))
        Dim hashstring As String = ""

        For Each b As Byte In hashvalue
            hashstring += b.ToString("x2")
        Next

        hashAlg = Nothing
        hashvalue = Nothing

        Return hashstring
    End Function

End Module
