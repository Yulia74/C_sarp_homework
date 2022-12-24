// Напишите программу, которая принимает на вход число и выдаёт
// сумму цифр в числе.
// Например: 452 -> 11
//           82 -> 10
//           9012 -> 12

Console.Write("Еnter a number ");
bool isParsed = int.TryParse(Console.ReadLine(), out int num); 

if(!isParsed)
{
    Console.WriteLine("Incorrect number");
    return;
}
if(num < 0)
{
    Console.WriteLine("Enter a positive number");
    return;
}

int GetSumOfDigitsOfNumber(int num)
{
    int res = num % 10;

        for (int count = 0; num / 10 > 0; count++)
        {
            num = num / 10;
            res = res + num % 10;
        }
        return res;          
  }

int sum = GetSumOfDigitsOfNumber(num);

Console.WriteLine($"The sum of the digits {num} is equal to {sum}.");
