// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт,
// какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

Console.WriteLine("Enter the first number");

int a = int.Parse(Console.ReadLine());

Console.WriteLine("Enter the second number");

int b = int.Parse(Console.ReadLine());

if (a > b) 
{
     Console.WriteLine($"max = {a}");
}
if (a < b)
{
    Console.WriteLine($"max = {b}");
}
else Console.WriteLine("two numbers are equal");
