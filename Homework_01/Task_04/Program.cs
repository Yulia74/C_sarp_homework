// Напишите программу, которая принимает на вход три числа и выдаёт максимальное
// из этих чисел:
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

Console.WriteLine("Enter the first number");

int n1 = int.Parse(Console.ReadLine());

Console.WriteLine("Enter the second number");

int n2 = int.Parse(Console.ReadLine());

Console.WriteLine("Enter the third number");

int n3 = int.Parse(Console.ReadLine());

if (n1 > n2 & n1 > n3)
{
    Console.WriteLine($"max = {n1}");
}
else if (n2 > n1 & n2 > n3)
{
    Console.WriteLine($"max = {n2}");
}

else if (n3 > n1 & n3 > n2)
{
    Console.WriteLine($"max = {n3}");
}
else
{
Console.WriteLine("Numbers are equal");
}
