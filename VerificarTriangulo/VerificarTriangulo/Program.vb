Imports System

Module Program
    Sub Main(args As String())
        Dim LadoA, LadoB, LadoC As Double
        Console.Write("Lado a: ")
        LadoA = Double.Parse(Console.ReadLine())
        Console.Write("Lado b: ")
        LadoB = Double.Parse(Console.ReadLine())
        Console.Write("Lado c: ")
        LadoC = Double.Parse(Console.ReadLine())
        If LadoA = LadoB And LadoA = LadoC Then
            Console.WriteLine("---------------------")
            Console.WriteLine("Resultado")
            Console.WriteLine("Equilatero")
        End If
        If (LadoA = LadoB And LadoA <> LadoC) Or (LadoA = LadoC And LadoA <> LadoB) Or (LadoB = LadoC And LadoB <> LadoA) Then
            Console.WriteLine("---------------------")
            Console.WriteLine("Resultado")
            Console.WriteLine("Isosceles")
        End If
    End Sub
End Module
