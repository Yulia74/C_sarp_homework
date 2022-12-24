// Задача 47. Задайте двумерный массив размером m × n, заполненный случайными 
// вещественными числами: m = 3, n = 4.
// 0,5    7    -2   -0,2
// 1   -3,3     8   -9,9
// 8    7,8  -7,1      9

double[,] array = CreateRandom2DArray(3, 4);

Print2DArray(array);



double[,] CreateRandom2DArray(int countOfRows, int countOfColumns)
{
    Random random = new Random();
    double[,] array = new double[countOfRows, countOfColumns];

    for (var i = 0; i < array.GetLength(0); i++)
    {
        for (var j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = Math.Round(random.NextDouble() * random.Next(-10, 10), 1);
        }
    }
    return array;
}

void Print2DArray(double[,] array)
{
    for (var i = 0; i < array.GetLength(0); i++)
    {
        for (var j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"    {array[i, j]} ");
        }
        Console.WriteLine();                      
    }
}
