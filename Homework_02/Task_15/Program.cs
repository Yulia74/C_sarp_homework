// Задача 15: Напишите программу, которая принимает на вход цифру, 
// обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

Console.Write("Enter the number of the day of the week: ");

int day = int.Parse(Console.ReadLine());
if ( 1 <= day && day <= 7)
{
    if(6 == day || day == 7)
    {
        Console.WriteLine("Yes. It's a weekend!");
    }
    else
    {
        Console.WriteLine("No. It's a working day.");
    }
}
else
{
    Console.WriteLine("Sorry. There are seven days in a week.");
}
