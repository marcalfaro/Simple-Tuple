Option Explicit On
Module Module1

    Sub Main()

        Dim rslt = Add_Subtract_Multiply_Divide(10, 20)
        With rslt
            Console.WriteLine($"OK: { .Item1}")
            Console.WriteLine($"Sum: { .Item2}")
            Console.WriteLine($"Diff: { .Item3}")
            Console.WriteLine($"Prod: { .Item4}")
            Console.WriteLine($"Quo: { .Item5}")
            Console.WriteLine($"Err: { .Item6}")
            Console.ReadLine()
        End With

    End Sub

    Private Function Add_Subtract_Multiply_Divide(ByVal num1 As Double, ByVal num2 As Double) As Tuple(Of Boolean, Double, Double, Double, Double, String)

        Dim ok As Boolean = False
        Dim sum As Double = 0.0
        Dim diff As Double = 0.0
        Dim prod As Double = 0.0
        Dim quo As Double = 0.0
        Dim err As String = String.Empty

        Try
            sum = num1 + num2
            diff = num1 - num2
            prod = num1 * num2
            quo = num1 / num2
            ok = True
        Catch ex As Exception
            err = ex.Message
        End Try
        Return New Tuple(Of Boolean, Double, Double, Double, Double, String)(ok, sum, diff, prod, quo, err)
    End Function

End Module
