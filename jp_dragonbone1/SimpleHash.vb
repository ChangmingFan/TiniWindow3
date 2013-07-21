'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
' SAMPLE: Hashing data with salt using MD5 and several SHA algorithms.
'
' To run this sample, create a new Visual Basic.NET project using the Console
' Application template and replace the contents of the Module1.vb file with
' the code below.
'
' THIS CODE AND INFORMATION IS PROVIDED "AS IS" WITHOUT WARRANTY OF ANY KIND,
' EITHER EXPRESSED OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE IMPLIED
' WARRANTIES OF MERCHANTABILITY AND/OR FITNESS FOR A PARTICULAR PURPOSE.
' 
' Copyright (C) 2002 Obviex(TM). All rights reserved.
'
Imports System
Imports System.Text
Imports System.Security.Cryptography


' <summary>
' This class generates and compares hashes using MD5, SHA1, SHA256, SHA384, 
' and SHA512 hashing algorithms. Before computing a hash, it appends a
' randomly generated salt to the plain text, and stores this salt appended
' to the result. To verify another plain text value against the given hash,
' this class will retrieve the salt value from the hash string and use it
' when computing a new hash of the plain text. Appending a salt value to
' the hash may not be the most efficient approach, so when using hashes in
' a real-life application, you may choose to store them separately. You may
' also opt to keep results as byte arrays instead of converting them into
' base64-encoded strings.
' </summary>
Public Class SimpleHash

    ' <summary>
    ' Generates a hash for the given plain text value and returns a
    ' base64-encoded result. Before the hash is computed, a random salt
    ' is generated and appended to the plain text. This salt is stored at
    ' the end of the hash value, so it can be used later for hash
    ' verification.
    ' </summary>
    ' <param name="plainText">
    ' Plaintext value to be hashed. The function does not check whether
    ' this parameter is null.
    ' </param>
    ' < name="hashAlgorithm">
    ' Name of the hash algorithm. Allowed values are: "MD5", "SHA1",
    ' "SHA256", "SHA384", and "SHA512" (if any other value is specified
    ' MD5 hashing algorithm will be used). This value is case-insensitive.
    ' </param>
    ' < name="saltBytes">
    ' Salt bytes. This parameter can be null, in which case a random salt
    ' value will be generated.
    ' </param>
    ' <returns>
    ' Hash value formatted as a base64-encoded string.
    ' </returns>
    Public Shared Function ComputeHash(ByVal plainText As String, _
                                       ByVal hashAlgorithm As String, _
                                      Optional ByVal saltBytes() As Byte = Nothing) _
                           As String
        'jp april,1,2011 commnet out section.
        'if no salt bytes passed none will be used

        '' If salt is not specified, generate it on the fly.
        'If (saltBytes Is Nothing) Then

        '    ' Define min and max salt sizes.
        '    Dim minSaltSize As Integer
        '    Dim maxSaltSize As Integer

        '    minSaltSize = 4
        '    maxSaltSize = 8

        '    ' Generate a random number for the size of the salt.
        '    Dim random As Random
        '    random = New Random()

        '    Dim saltSize As Integer
        '    saltSize = random.Next(minSaltSize, maxSaltSize)

        '    ' Allocate a byte array, which will hold the salt.
        '    saltBytes = New Byte(saltSize - 1) {}

        '    ' Initialize a random number generator.
        '    Dim rng As RNGCryptoServiceProvider
        '    rng = New RNGCryptoServiceProvider()

        '    ' Fill the salt with cryptographically strong byte values.
        '    rng.GetNonZeroBytes(saltBytes)
        'End If

        ' Convert plain text into a byte array.
        Dim plainTextBytes As Byte()
        plainTextBytes = Encoding.UTF8.GetBytes(plainText)


        Dim plainTextWithSaltBytes() As Byte
        Dim I As Integer
        If saltBytes Is Nothing Then

            'we are not using any salt bytes so simply copy plaintext 
            plainTextWithSaltBytes = plainTextBytes
        Else

            ' Allocate array, which will hold plain text and salt.
            plainTextWithSaltBytes = _
                New Byte(plainTextBytes.Length + saltBytes.Length - 1) {}

            ' Copy plain text bytes into resulting array.

            For I = 0 To plainTextBytes.Length - 1
                plainTextWithSaltBytes(I) = plainTextBytes(I)
            Next I


            ' Append salt bytes to the resulting array.
            For I = 0 To saltBytes.Length - 1
                plainTextWithSaltBytes(plainTextBytes.Length + I) = saltBytes(I)
            Next I
        End If
        

        ' Because we support multiple hashing algorithms, we must define
        ' hash object as a common (abstract) base class. We will specify the
        ' actual hashing algorithm class later during object creation.
        Dim hash As HashAlgorithm

        ' Make sure hashing algorithm name is specified.
        If (hashAlgorithm Is Nothing) Then
            hashAlgorithm = ""
        End If

        ' Initialize appropriate hashing algorithm class.
        Select Case hashAlgorithm.ToUpper()

            Case "SHA1"
                hash = New SHA1Managed()

            Case "SHA256"
                hash = New SHA256Managed()

            Case "SHA384"
                hash = New SHA384Managed()

            Case "SHA512"
                hash = New SHA512Managed()

            Case Else
                hash = New MD5CryptoServiceProvider()

        End Select

        ' Compute hash value of our plain text with appended salt.
        Dim hashBytes As Byte()
        hashBytes = hash.ComputeHash(plainTextWithSaltBytes)

        Dim hashWithSaltBytes() As Byte

        If saltBytes Is Nothing Then
            hashWithSaltBytes = hashBytes
        Else
            ' Create array which will hold hash and original salt bytes.
            hashWithSaltBytes = _
                                       New Byte(hashBytes.Length + _
                                                saltBytes.Length - 1) {}

            ' Copy hash bytes into resulting array.
            For I = 0 To hashBytes.Length - 1
                hashWithSaltBytes(I) = hashBytes(I)
            Next I

            ' Append salt bytes to the result.
            For I = 0 To saltBytes.Length - 1
                hashWithSaltBytes(hashBytes.Length + I) = saltBytes(I)
            Next I

        End If
        
        ' Convert result into a string hex value
        Dim hashValue As String = ""
        For Each ch As Byte In hashWithSaltBytes
            Dim thishex As String = Hex(ch)
            If thishex.Length = 1 Then
                thishex = "0" & thishex
            End If
            hashValue &= thishex


        Next

        ' Return the result.
        ComputeHash = hashValue
    End Function

    ' <summary>
    ' Compares a hash of the specified plain text value to a given hash
    ' value. Plain text is hashed with the same salt value as the original
    ' hash.
    ' </summary>
    ' <param name="plainText">
    ' Plain text to be verified against the specified hash. The function
    ' does not check whether this parameter is null.
    ' </param>
    ' < name="hashAlgorithm">
    ' Name of the hash algorithm. Allowed values are: "MD5", "SHA1",
    ' "SHA256", "SHA384", and "SHA512" (if any other value is specified
    ' MD5 hashing algorithm will be used). This value is case-insensitive.
    ' </param>
    ' < name="hashValue">
    ' Base64-encoded hash value produced by ComputeHash function. This value
    ' includes the original salt appended to it.
    ' </param>
    ' <returns>
    ' If computed hash mathes the specified hash the function the return
    ' value is true; otherwise, the function returns false.
    ' </returns>
    Public Shared Function VerifyHash(ByVal plainText As String, _
                                      ByVal hashAlgorithm As String, _
                                      ByVal hashValue As String) _
                           As Boolean

        ' Convert base64-encoded hash value into a byte array.
        Dim hashWithSaltBytes As Byte()
        hashWithSaltBytes = Convert.FromBase64String(hashValue)

        ' We must know size of hash (without salt).
        Dim hashSizeInBits As Integer
        Dim hashSizeInBytes As Integer

        ' Make sure that hashing algorithm name is specified.
        If (hashAlgorithm Is Nothing) Then
            hashAlgorithm = ""
        End If

        ' Size of hash is based on the specified algorithm.
        Select Case hashAlgorithm.ToUpper()

            Case "SHA1"
                hashSizeInBits = 160

            Case "SHA256"
                hashSizeInBits = 256

            Case "SHA384"
                hashSizeInBits = 384

            Case "SHA512"
                hashSizeInBits = 512

            Case Else ' Must be MD5
                hashSizeInBits = 128

        End Select

        ' Convert size of hash from bits to bytes.
        hashSizeInBytes = hashSizeInBits / 8

        ' Make sure that the specified hash value is long enough.
        If (hashWithSaltBytes.Length < hashSizeInBytes) Then
            VerifyHash = False
        End If

        ' Allocate array to hold original salt bytes retrieved from hash.
        Dim saltBytes() As Byte = New Byte(hashWithSaltBytes.Length - _
                                           hashSizeInBytes - 1) {}

        ' Copy salt from the end of the hash to the new array.
        Dim I As Integer
        For I = 0 To saltBytes.Length - 1
            saltBytes(I) = hashWithSaltBytes(hashSizeInBytes + I)
        Next I

        ' Compute a new hash string.
        Dim expectedHashString As String
        expectedHashString = ComputeHash(plainText, hashAlgorithm, saltBytes)

        ' If the computed hash matches the specified hash,
        ' the plain text value must be correct.
        VerifyHash = (hashValue = expectedHashString)
    End Function
End Class
