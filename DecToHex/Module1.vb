Module Module1

    Sub Main()
        Const MAX_INT = UInteger.MaxValue
        Dim uNumber As UInteger
        Console.WriteLine("Input an unsigned integer number")
        Dim bIsRightNumber = (UInteger.TryParse(Console.ReadLine(), uNumber)) AndAlso
                     (uNumber <= MAX_INT)
        If (Not bIsRightNumber) Then
            Console.WriteLine("Invalid number format or number too big")
            Console.Read()
            Return
        End If
        Console.WriteLine("Lower case ? (y/n)")
        Dim chAnswer = Console.Read()
        Dim bLowerCase = (chAnswer = Asc("y"c))
        Dim strHexNum = ""
        Dim uTempVal = uNumber
        Do While (uTempVal > 0)
            Dim chHexDigit = ""
            Dim nHexDigit = uTempVal Mod 16
            If (nHexDigit >= 0 And nHexDigit <= 9) Then
                chHexDigit = Chr(nHexDigit + Asc("0"))
            ElseIf (nHexDigit >= 10 And nHexDigit <= 15 And bLowerCase) Then
                chHexDigit = Chr(nHexDigit - 10 + Asc("a"))
            ElseIf (nHexDigit >= 10 And nHexDigit <= 15) Then
                chHexDigit = Chr(nHexDigit - 10 + Asc("A"))
            End If
            strHexNum = chHexDigit + strHexNum
            uTempVal \= 16
        Loop
        If (strHexNum.Length = 0) Then
            strHexNum = "0"
        End If
        Console.WriteLine _
        (
            "The hexadecimal equivalent of the decimal number {0} is: {1}",
            uNumber, strHexNum
        )
        Console.Read()
    End Sub

End Module
