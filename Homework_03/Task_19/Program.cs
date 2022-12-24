// Напишите программу, которая принимает на вход пятизначное число и проверяет,
// является ли оно палиндромом. Задание должно быть выполнено в методе.
// В методе не должно быть вывода в консоль. Не использовать String!
// Например 14212 -> нет
//          12821 -> да
//          23432 -> да

Console.Write("Enter a five-digit number ");
int num = int.Parse(Console.ReadLine());
NumberCheck(num);

void NumberCheck(int num)
{
    int num1 = num / 10000;
    int num2 = num % 10000 / 1000;
    int num4 = num % 100 / 10;
    int num5 = num % 10;

    if(num >= 10000 && num < 100000)
    {
        if(num1 == num5 && num2 == num4)
        Console.WriteLine($"Number {num} is palindrome");
        else Console.WriteLine($"Number {num} is not palindrome");
    }
    else Console.WriteLine($"The entered number {num} is not five-digit number");
}
