// Задача 10: Напишите программу, которая принимает на вход трёхзначное число 
// и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.Write("Enter a three-digit number ");

int number = int.Parse(Console.ReadLine());

if(number >= 100 && number < 1000)
{
    Console.WriteLine($"The second digit of the number {((number % 100)/10)}");
}
else
{
    Console.WriteLine($"the entered number {number} is not three-digit");
}