Public Class AmountInWords

    Public Shared Function AmountInWordsEn(ByVal nAmount As String, Optional ByVal wAmount As String = vbNullString, Optional ByVal nSet As Object = Nothing, Optional ByVal CurrencyID As String = "1") As String
        'Let's make sure entered value is numeric
        If Not IsNumeric(nAmount) Then Return "Please enter numeric values only."
        Dim CurrencyRow As DataRow = Currencydata.Select("CurrencyID = " & CurrencyID).First

        'I used this kind of approach using String instead of Double as datatype then I applied string manipulation
        'and remove the decimal value then store it in tempDecValue and re-attach it to nAmount upon entering the recursion
        'The reason is that I tried using the Double datatype but when it comes to quadrillion values and with decimal values
        'I noticed that the ones and tens values changed, or some errors encountered. I couldn't figure it out until I came up with this concept.

        'tempDecValue gets the decimal value from the original value nAmount 
        'tempDecValue is added to the nAmount every time it enters the recursion
        Dim tempDecValue As String = String.Empty : If InStr(nAmount, ".") Then tempDecValue = nAmount.Substring(nAmount.IndexOf("."))

        'Removing the decimal value from nAmount
        nAmount = Replace(nAmount, tempDecValue, String.Empty)

        Try
            'Assigning the nAmount to intAmount having the LONG datatype
            Dim intAmount As Long = nAmount

            'Let's trap the values entered into the recursion; if greater than 0 then let's evaluate the numbers in set, otherwise, 
            '(1) all numbers have already been evaluated and return the designated word values (for entered whole numbers); or
            '(2) evaluate last set, which is the decimal value
            'either which proceed to else statement and/or return the result
            If intAmount > 0 Then
                'Let's segregate the entered values into 3-digit sets of numbers and count it then store in the nSet
                'For example: 9223372036854775807 has 7 sets; start from right to left (807, 775, 854, 036...), until the last set which is 9 
                nSet = IIf((intAmount.ToString.Trim.Length / 3) > (CLng(intAmount.ToString.Trim.Length / 3)), CLng(intAmount.ToString.Trim.Length / 3) + 1, CLng(intAmount.ToString.Trim.Length / 3))

                'eAmount gets each 3-digit set entered into the recursion
                'Though I said sets start from right to left, we start evaluating each set from left to right of the entered values.
                'For example: 9223372036854775807 (actual: 9,223,372,036,854,775,807), 9 (1st set to be evaluated), 223 (next set), 372 (next set),... and so on
                'and so forth until all are evaluated, including the decimal values, in case there exists
                'NOTE: 9 is in Quintillion range, 223 is in Quadrillion, 372 in Trillion, and so on and so forth
                Dim eAmount As Long = Microsoft.VisualBasic.Left(intAmount.ToString.Trim, (intAmount.ToString.Trim.Length - ((nSet - 1) * 3)))

                'Multiplier gets the 10 to the power of the nSet
                'This is needed to remove the evaluated set from the original values
                'For example: 1st set is 9 (the 1st value of eAmount) and there are 7 sets so:
                '10 ^ (((7 - 1) * 3)) is 1000000000000000000
                '9 multiplied by 1000000000000000000 is 9000000000000000000
                'remove 9000000000000000000 from 9223372036854775807 which results in 223372036854775807, the next value of nAmount within which the decimal value .75 shall be attached
                'the flow goes on and on until nAmount reaches zero, or the decimal value
                'so multiplier has a vital function as we go on and we shall see later
                Dim multiplier As Long = 10 ^ (((nSet - 1) * 3))

                'These are the worded values
                Dim Ones() As String = {"", "One", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine"}
                Dim Teens() As String = {"", "Eleven", "Twelve", "Thirteen", "Fourteen", "Fifteen", "Sixteen", "Seventeen", "Eighteen", "Nineteen"}
                Dim Tens() As String = {"", "Ten", "Twenty", "Thirty", "Forty", "Fifty", "Sixty", "Seventy", "Eighty", "Ninety"}
                Dim HMBT() As String = {"", "", "Thousand", "Million", "Billion", "Trillion", "Quadrillion", "Quintillion"}

                'Let's reuse the intAmount object
                intAmount = eAmount

                'Remember, we have a 3-digit number in each set
                'from left to right is hundreds, tens, and ones
                'For example 9 is the ones in the first set for evaluation; the next set is 223 (1st 2 is hundreds, next 2 is tens, and 3 is ones)
                'These statements segregate the numbers in the set
                Dim nHundred As Integer = intAmount \ 100 : intAmount = intAmount Mod 100
                Dim nTen As Integer = intAmount \ 10 : intAmount = intAmount Mod 10
                Dim nOne As Integer = intAmount \ 1

                'After the segregation, we now have to evaluate the retrieved numbers and put the corresponding words for each number                
                If nHundred > 0 Then wAmount = wAmount & Ones(nHundred) & " Hundred " 'This is for hundreds                
                If nTen > 0 Then 'This is for tens and teens
                    'In case of teens, like 11 to 19, it will be trapped in here and proceed to the designated word                    
                    If nTen = 1 And nOne > 0 Then 'This is for teens (number ten plus ones succeeding it) Example:
                        wAmount = wAmount & Teens(nOne) & " " '11 is Eleven, 12 is Twelve, 15 is Fifteen, 17 is Seventeen, and so on
                    Else 'This is for tens, 10 to 90
                        wAmount = wAmount & Tens(nTen) & IIf(nOne > 0, "-", " ") 'If there is ones succeeding it, put a dash before the ones, example: Twenty-, Thirty-, Forty-, etc.
                        If nOne > 0 Then wAmount = wAmount & Ones(nOne) & " " 'This is for ones (1-9) with the tens (20-90) preceeding it. Example: 21 is Twenty-One, 34 is Thirty-Four, 48 is Forty-Eight
                    End If
                Else 'This is for ones, 1 to 9
                    If nOne > 0 Then wAmount = wAmount & Ones(nOne) & " "
                End If
                'Let's put in here the ranges (1st set(number 9) is Quintillion, next(number 223) is Quadrillion, next(372) is Trillion, ...so on and so forth)
                wAmount = wAmount & HMBT(nSet) & " "
                'Proceed to next set to evaluate by entering the same function we are in (recursion)
                wAmount = AmountInWordsEn(CStr(CLng(nAmount) - (eAmount * multiplier)).Trim & tempDecValue, wAmount, nSet - 1, CurrencyID:=CurrencyID)
            Else 'When nAmount reaches 0, we proceed to this statement
                'If there is no decimal value then proceed to display the result
                'But if there is a decimal value then let's evaluate each number of the decimal value
                'First we re-attach the decimal value to its original value, the nAmount
                If Val(nAmount) = 0 Then nAmount = nAmount & tempDecValue : tempDecValue = String.Empty
                'Now, if we have decimal value, let's convert it into whole numbers (not rounding it off, but actually converting to whole numbers), 
                'put it into the recursion for the last time, evaluate it, give the corresponding words and then finally, display the result
                If (Math.Round(Val(nAmount), 2) * 100) > 0 Then wAmount = Trim(AmountInWordsEn(CStr(Math.Round(Val(nAmount), 2) * 100), wAmount.Trim & " " & CurrencyRow("LatinName").ToString & " And ", 1, CurrencyID:=CurrencyID)) & " " & CurrencyRow("LatinPartName").ToString
            End If
        Catch ex As Exception
            'Should there be any error encountered, this will handle it.
            MessageBox.Show("Error Encountered: " & ex.Message, "Convert Numbers To Words", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return "!#ERROR_ENCOUNTERED"
        End Try

        'Trap null values
        If IsNothing(wAmount) = True Then wAmount = String.Empty Else wAmount = IIf(InStr(wAmount.Trim.ToLower, CurrencyRow("LatinName").ToString.ToLower), wAmount.Trim, wAmount.Trim & " " & CurrencyRow("LatinName").ToString)

        'Display the result
        Return wAmount
    End Function

    Public Shared Function AmountInWordsAr(ByVal givenNumber As Double, Optional ByVal CurrencyID As String = "1") As String
        Dim FinalOutput, NumberCurrency, FractionsCurrency As String
        'Dim Tafkeet = " فقط لا غير"
        Dim CurrencyRow As DataRow = Currencydata.Select("CurrencyID = " & CurrencyID).First

        Dim WholeNumber() As String = Split(givenNumber, ".")

        NumberCurrency = NumberAsCurrency(WholeNumber(0), CurrencyRow)
        FinalOutput = NumberCurrency

        If WholeNumber.Length >= 2 Then
            If WholeNumber(1).Length.Equals(1) Then
                WholeNumber(1) = WholeNumber(1) + "0"
            ElseIf WholeNumber(1).Length > 2 Then
                WholeNumber(1) = WholeNumber(1).Substring(0, 2)
            End If

            FractionsCurrency = FractionAsCurrency(WholeNumber(1), CurrencyRow)
            FinalOutput = FinalOutput + " و" + FractionsCurrency
        End If

        If FinalOutput <> Nothing And FinalOutput <> "" Then
            '  FinalOutput = FinalOutput + Tafkeet
            FinalOutput = FinalOutput
        End If

        AmountInWordsAr = FinalOutput
    End Function

    Public Shared Function SFormatNumber(ByVal X As Double) As String

        Dim Letter1 As String = ""
        Dim Letter2 As String = ""
        Dim Letter3 As String = ""
        Dim Letter4 As String = ""
        Dim Letter5 As String = ""
        Dim Letter6 As String = ""

        Dim c As String = Format(Math.Floor(X), "000000000000")
        Dim C1 As Double = Val(Mid(c, 12, 1))
        Select Case C1
            Case Is = 1 : Letter1 = "واحد"
            Case Is = 2 : Letter1 = "اثنان"
            Case Is = 3 : Letter1 = "ثلاثة"
            Case Is = 4 : Letter1 = "أربعة"
            Case Is = 5 : Letter1 = "خمسة"
            Case Is = 6 : Letter1 = "ستة"
            Case Is = 7 : Letter1 = "سبعة"
            Case Is = 8 : Letter1 = "ثمانية"
            Case Is = 9 : Letter1 = "تسعة"
        End Select


        Dim C2 As Double = Val(Mid(c, 11, 1))
        Select Case C2
            Case Is = 1 : Letter2 = "عشر"
            Case Is = 2 : Letter2 = "عشرون"
            Case Is = 3 : Letter2 = "ثلاثون"
            Case Is = 4 : Letter2 = "اربعون"
            Case Is = 5 : Letter2 = "خمسون"
            Case Is = 6 : Letter2 = "ستون"
            Case Is = 7 : Letter2 = "سبعون"
            Case Is = 8 : Letter2 = "ثمانون"
            Case Is = 9 : Letter2 = "تسعون"
        End Select


        If Letter1 <> "" And C2 > 1 Then Letter2 = Letter1 + " و" + Letter2
        If Letter2 = "" Or Letter2 Is Nothing Then
            Letter2 = Letter1
        End If
        If C1 = 0 And C2 = 1 Then Letter2 = Letter2 + "ة"
        If C1 = 1 And C2 = 1 Then Letter2 = "احدى عشر"
        If C1 = 2 And C2 = 1 Then Letter2 = "اثنى عشر"
        If C1 > 2 And C2 = 1 Then Letter2 = Letter1 + " " + Letter2
        Dim C3 As Double = Val(Mid(c, 10, 1))
        Select Case C3
            Case Is = 1 : Letter3 = "مائة"
            Case Is = 2 : Letter3 = "مائتان"
            Case Is > 2 : Letter3 = Microsoft.VisualBasic.Left(SFormatNumber(C3), Len(SFormatNumber(C3)) - 1) + "مائة"
        End Select
        If Letter3 <> "" And Letter2 <> "" Then Letter3 = Letter3 + " و" + Letter2
        If Letter3 = "" Then Letter3 = Letter2


        Dim C4 As Double = Val(Mid(c, 7, 3))
        Select Case C4
            Case Is = 1 : Letter4 = "الف"
            Case Is = 2 : Letter4 = "الفان"
            Case 3 To 10 : Letter4 = SFormatNumber(C4) + " آلاف"
            Case Is > 10 : Letter4 = SFormatNumber(C4) + " الف"
        End Select
        If Letter4 <> "" And Letter3 <> "" Then Letter4 = Letter4 + " و" + Letter3
        If Letter4 = "" Then Letter4 = Letter3
        Dim C5 As Double = Val(Mid(c, 4, 3))
        Select Case C5
            Case Is = 1 : Letter5 = "مليون"
            Case Is = 2 : Letter5 = "مليونان"
            Case 3 To 10 : Letter5 = SFormatNumber(C5) + " ملايين"
            Case Is > 10 : Letter5 = SFormatNumber(C5) + " مليون"
        End Select
        If Letter5 <> "" And Letter4 <> "" Then Letter5 = Letter5 + " و" + Letter4
        If Letter5 = "" Then Letter5 = Letter4


        Dim C6 As Double = Val(Mid(c, 1, 3))
        Select Case C6
            Case Is = 1 : Letter6 = "مليار"
            Case Is = 2 : Letter6 = "ملياران"
            Case Is > 2 : Letter6 = SFormatNumber(C6) + " مليار"
        End Select
        If Letter6 <> "" And Letter5 <> "" Then Letter6 = Letter6 + " و" + Letter5
        If Letter6 = "" Then Letter6 = Letter5

        SFormatNumber = Letter6

    End Function

    Public Shared Function NumberAsCurrency(ByVal givenNumber As Double, ByVal CurrencyRow As DataRow) As String
        Dim Number As String

        Number = SFormatNumber(givenNumber)

        If Number <> "" And Number <> Nothing And givenNumber <= 2 Then
            If Number.StartsWith("واحد") And CurrencyRow("CurrencyID").ToString = "1" Then
                Number = Number.Substring(4)
            ElseIf Number.StartsWith("اثنان") And CurrencyRow("CurrencyID").ToString = "1" Then
                Number = Number.Substring(5)
            End If
        End If

        'Select Case CDbl(givenNumber)
        '    Case Is = Nothing : Currency = ""
        '    Case Is = 2 : Currency = " جنيهان مصريان"
        '    Case 3 To 10 : Currency = " جنيهات مصرية"
        '    Case Else : Currency = " جنيه مصري"
        'End Select

        NumberAsCurrency = Number + " " + CurrencyRow("CurrName").ToString
    End Function

    Public Shared Function FractionAsCurrency(ByVal givenNumber As Double, ByVal CurrencyRow As DataRow) As String
        Dim Fractions As String

        Fractions = SFormatNumber(givenNumber)

        If Fractions <> "" And Fractions <> Nothing And givenNumber <= 2 Then
            If Fractions.StartsWith("واحد") Then
                Fractions = Fractions.Substring(4)
            ElseIf Fractions.StartsWith("اثنان") Then
                Fractions = Fractions.Substring(5)
            End If
        End If

        'Select Case CDbl(givenNumber)
        '    Case Is = Nothing : Currency = ""
        '    Case Is = 2 : Currency = " قرشان"
        '    Case 3 To 10 : Currency = " قروش"
        '    Case Else : Currency = " قرشا"
        'End Select

        FractionAsCurrency = Fractions + " " + CurrencyRow("PartName").ToString

    End Function
End Class
