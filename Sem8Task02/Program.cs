﻿// **Задача 65:** Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.

// M = 1; N = 5. -> "1, 2, 3, 4, 5"
// M = 4; N = 8. -> "4, 5, 6, 7, 8"
Console.Write("Введите число: ");
int M = int.Parse(Console.ReadLine()!);



Console.Write("Введите число: ");
int N = int.Parse(Console.ReadLine()!);

Console.WriteLine(PrintNumbers(M, N));


string PrintNumbers (int M, int N)
{
    if(M == N ) return M.ToString();
    return (M + " " + PrintNumbers(M + 1, N));

}
