Imports System
Module Program
    Sub Main(args As String())
        Dim cont As Double
        Dim num As Double
        Console.Write("Ingresa el numero:")
        num = Console.ReadLine()
        If num >= 0 Then
            Console.WriteLine("---------------------")
            Console.WriteLine("El numero es positivo")
            While cont <= num
                cont = cont + 2
                Console.WriteLine(cont - 2)
            End While
        End If
        If num < 0 Then
            Console.WriteLine("---------------------")
            Console.WriteLine("El numero es negativo")
            For i = 0 To num Step -0.5
                Console.WriteLine(i)
            Next
        End If
    End Sub
End Module
