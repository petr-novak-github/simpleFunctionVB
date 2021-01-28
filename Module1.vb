Module Module1
    'cz-Vytvoř funkci ktera secte dve cisla a pouzij ji v programu
    'en- Create a function which will sum two numbers and use it in program.
    Sub Main()
        Dim sumTwoNums As Byte
        Dim n1 As Integer
        Dim n2 As Integer
        Dim ret As String

        n1 = InputBox("Type first number.(Integer)")
        n2 = InputBox("Type second number.(Integer)")

        sumTwoNums = sumTwoNumsF(n1, n2)
        ret = "Sumation of these two numbers is: " + Str(sumTwoNums)
        MsgBox(ret)

    End Sub

    Function sumTwoNumsF(a As Integer, b As Integer) As Integer
        sumTwoNumsF = a + b
    End Function

End Module
