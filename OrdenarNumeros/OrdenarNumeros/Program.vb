Imports System
Imports System.Console
Module Program
    Sub Main(args As String())
        Dim N1, N2, N3, P, S, T As Integer
        WriteLine("------------------------------")
        Write("Número a: ")
        N1 = ReadLine()
        Write("Número b: ")
        N2 = ReadLine()
        Write("Número c: ")
        N3 = ReadLine()
        WriteLine("")
        If ((N1 > N2) And (N1 > N3)) Then
            P = N1
            If (N2 > N3) Then
                S = N2
                T = N3
            Else
                S = N3
                T = N2
            End If
        Else
            If (N2 > N3) Then
                P = N2
                If (N1 > N3) Then
                    S = N1
                    T = N3
                Else
                    S = N3
                    T = N1
                End If
            Else
                P = N3
                If (N1 > N2) Then
                    S = N1
                    T = N2
                Else
                    S = N2
                    T = N1
                End If
            End If
        End If
        WriteLine("------------------------------")
        WriteLine("Resultado:")
        WriteLine(P)
        WriteLine(S)
        WriteLine(T)
        ReadLine()
    End Sub
End Module
