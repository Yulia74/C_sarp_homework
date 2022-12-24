// Напишите программу, которая выводит третью цифру заданного числа или сообщает, 
//что третьей цифры нет. Не использовать string[]
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.Write("Enter a number ");
int number = int.Parse(Console.ReadLine());

    while (number > 999)
    number = number / 10;
    { 
       if(number < 100)
       {
        Console.Write("there is no third digit");
        return;
       }
       else
       {
        int result = number % 10;
        Console.WriteLine($"{result}");
       }
    }

