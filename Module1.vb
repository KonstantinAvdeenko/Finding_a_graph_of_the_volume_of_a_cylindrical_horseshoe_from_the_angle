Module Module1
    Sub Main()
        Dim n, b, v, r, a, u As Double
        Randomize()
        Console.WriteLine("Введите значение a")
        a = Convert.ToInt32(Console.ReadLine())
        Console.WriteLine("Введите значение b")
        b = Convert.ToInt32(Console.ReadLine())
        Console.WriteLine("Введите значение r")
        r = Convert.ToInt32(Console.ReadLine())
        'построения графика зависимости объема V от угла u, если a, b и r известны, а и u изменяется 
        'в диапазоне от u(1) до u(2) с шагом погрешности u равным 0,125' 
        For n = 1 To 2 Step 0.125
            v = n / 3 * b * (a * (3 * (r ^ 2) - (a ^ 2)) + 3 * (r ^ 2) * (b - r) * u * n / 180)
            Console.Write("Значения n " & n) 'шаг графика зависимости объема 
            Console.WriteLine("     " & "Значения v " & v) 'значение объема на шаге
        Next n
        Console.ReadLine()
    End Sub
End Module

