// **Задача 69:** Напишите программу, которая на вход принимает два числа A и B, и возводит число А в целую степень B с помощью рекурсии.

// A = 3; B = 5 -> 243 (3⁵)

// A = 2; B = 3 -> 8

int Power(int a, int b)
{
    if (b == 0) return 1;
    if (b == 1) return a;
    return (Power(a, b - 1) * a);
}
Console.Write("Введите число A: ");
int A = int.Parse(Console.ReadLine()!);
Console.Write("Введите число B: ");
int B = int.Parse(Console.ReadLine()!);
Console.WriteLine(Power(A,B));