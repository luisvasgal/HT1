Imports System

Module Program
    Sub Main(args As String())
        Dim notaUno, notaDos, notaTres, prom As Integer

        Console.Write("Nota Matematica:")
        notaUno = Console.ReadLine()
        Console.Write("Nota Fisica:")
        notaDos = Console.ReadLine()
        Console.Write("Nota Programacion:")
        notaTres = Console.ReadLine()
        prom = ((notaUno + notaDos + notaTres) / 3)

        If prom < 61 Then
            Console.WriteLine("---------------------")
            Console.WriteLine("Resultado:")
            Console.WriteLine("Promedio: " & prom)
            Console.WriteLine("Reprobado")
        End If
        If prom >= 61 And prom < 81 Then
            Console.WriteLine("---------------------")
            Console.WriteLine("Resultado:")
            Console.WriteLine("Promedio: " & prom)
            Console.WriteLine("Regular")
        End If
        If prom > 80 Then
            Console.WriteLine("---------------------")
            Console.WriteLine("Resultado:")
            Console.WriteLine("Promedio: " & prom)
            Console.WriteLine("Excelente")
        End If

    End Sub
End Module
