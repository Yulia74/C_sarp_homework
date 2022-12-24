// Задайте значения M и N. Напишите программу, которая найдёт сумму
// натуральных элементов в промежутке от M до N. Выполнить с помощью рекурсии.
// M = 1; N = 15 -> 120
// M = 4; N = 8 -> 30


Console.Write("Enter the first number M:  ");

int m = int.Parse(Console.ReadLine());

Console.Write("Enter the second number N: ");

int n = int.Parse(Console.ReadLine());

Console.WriteLine($"The sum of natural numbers in the range from M to N is equal to {SumRec(m, n)}");



int SumRec(int m, int n)
{
    if (m <= n)
        return m + SumRec(m + 1, n);
    else
        return 0;
}
