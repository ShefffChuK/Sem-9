// Задача 66: Выполнить с помощью рекурсии.Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.Write("Введите число M: ");
int m = int.Parse(Console.ReadLine()!);



Console.Write("Введите число N: ");
int n = int.Parse(Console.ReadLine()!);


///Метод 
int summa(int m, int n)
{
if (m==n)
return n;
return m + summa(m + 1, n);
}
Console.Write($"Сумма натуральных элементов в промежутке от M до N равно {summa(m,n)}");