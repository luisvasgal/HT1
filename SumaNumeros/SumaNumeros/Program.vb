Imports System

Module Program
    Sub Main(args As String())
        Dim cont, num, suma, result
        cont = 0
        suma = 0
        Console.Write("Ingresa el numero:")
        num = Double.Parse(Console.ReadLine())
        While cont <= num
            suma = suma + cont
            cont = cont + 1
            Console.WriteLine("---------------------")
            Console.WriteLine(cont - 1)
        End While
        Console.WriteLine("---------------------")
        Console.WriteLine("Suma de los numeros:")
        Console.WriteLine(suma)
        If (suma Mod 2) <> 0 Then
            Console.WriteLine("---------------------")
            Console.WriteLine("La suma es impar")
        Else
            Console.WriteLine("---------------------")
            Console.WriteLine("La suma es par")
        End If

    End Sub
End Module
