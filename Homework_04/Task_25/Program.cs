// Напишите программу, которая принимает на вход два числа (A и B)
// и метод, который возводит число A в натуральную степень B.
// Задание должно быть выполнено в методе. В методе не должно 
//быть вывода в консоль. Не использовать Math.Pow()

Console.Write("Еnter a number - the base of the degree ");
bool isParsed = int.TryParse(Console.ReadLine(), out int num); 

if(!isParsed)
{
    Console.WriteLine("Incorrect number");
    return;
}
if(num==0)
{
    Console.WriteLine("Raising zero to a power does not make sense");
    return;
}

Console.Write("Еnter a number - degree indicator ");
bool isPower = int.TryParse(Console.ReadLine(), out int power);

if(!isPower)
{
    Console.WriteLine("Incorrect number");
    return;
}

double res = GetDegreeOfNumber(num, power);

Console.WriteLine($"The entered number {num} to the power of {power} is {res}");

double GetDegreeOfNumber(int num, int power)
{      
    double res = 1;
    for (int count = 1; count <= power; count++)
    {
     res = res * num;
    }               
    return res;
}   
                             
    
    

