Module Module1

    Sub Main()
        Dim mat1 As Integer(,) = New Integer(2, 2) {}
        Dim mat2 As Integer(,) = New Integer(2, 2) {}
        Dim rnd As Random = New Random()

        For i As Integer = 0 To 3 - 1

            For j As Integer = 0 To 3 - 1
                mat1(i, j) = rnd.[Next](1, 1000)
                mat2(i, j) = rnd.[Next](1, 1000)
            Next
        Next

        For i As Integer = 0 To 3 - 1

            For j As Integer = 0 To 3 - 1
                Console.Write(mat1(i, j) & vbTab)
            Next

            Console.WriteLine()
        Next

        Console.WriteLine()

        For i As Integer = 0 To 3 - 1

            For j As Integer = 0 To 3 - 1
                Console.Write(mat2(i, j) & vbTab)
            Next
            Console.WriteLine()
        Next
        Console.WriteLine("THE SUM OF THE DATA OF THE MATRIXES IS: " & matricesRecursiveSum(mat1, mat2, 2, 2))
        Console.ReadKey()

    End Sub
    Private Function matricesRecursiveSum(ByVal mat1 As Integer(,), ByVal mat2 As Integer(,), ByVal nf As Integer, ByVal nc As Integer) As Integer
        If (nf = 0) AndAlso (nc = 0) Then
            Return mat1(nf, nc) + mat2(nf, nc)
        Else

            If nf > -1 Then
                nc -= 1

                If nc >= -1 Then
                    Return mat1(nf, nc + 1) + mat2(nf, nc + 1) + matricesRecursiveSum(mat1, mat2, nf, nc)
                Else
                    Return matricesRecursiveSum(mat1, mat2, nf - 1, 2)
                End If
            Else
                Return 0
            End If
        End If
    End Function

End Module
