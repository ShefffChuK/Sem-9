// **Задача 67:** Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.

// 453 -> 12

// 45 -> 9
int SumNumber (int A)
{
    if (A==0) return 0;
    return (SumNumber(A/10)+A%10); 
}
Console.Write("Введите число A: ");
int A = int.Parse(Console.ReadLine()!);
Console.WriteLine(SumNumber(A));