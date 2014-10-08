Option Strict On

Module Module1

    Sub Main()
        Dim num As Integer = 1
        Dim password As String = ""

        Do While num <= 7
            num = 10
            Console.WriteLine(" " & num)
            num = num + 1
        Loop

        Do
            password = InputBox("What is the password?")
            password = password.ToUpper
        Loop Until password = "SHAZAM"

    End Sub

End Module
