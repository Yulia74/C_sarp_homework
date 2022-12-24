// Задача 56. Задайте прямоугольный двумерный массив. Напишите программу, которая
// будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки
// с наименьшей суммой элементов: 1 строка


int[,] array = CreateRandom2DArray(4, 3, 1, 10);

Print2DArray(array);

Console.WriteLine();

int[] rowSum = FindSumOfElementsInRow(array);

int result = GetMinSum(rowSum);

Console.WriteLine($"The number of the row with the smallest sum of elements {result}");




int[,] CreateRandom2DArray(int rows, int columns, int min, int max)
{
    Random random = new Random();
    int[,] array = new int[rows, columns];

    for (var i = 0; i < array.GetLength(0); i++)
    {
        for (var j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = random.Next(min, max + 1);
        }
    }
    return array;
}

void Print2DArray(int[,] array)
{
    for (var i = 0; i < array.GetLength(0); i++)
    {
        for (var j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + "\t");
        }
        Console.WriteLine();
    }
}

int[] FindSumOfElementsInRow(int[,] array)
{
    int[] rowSum = new int[array.GetLength(0)];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        int sumRow = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sumRow += array[i, j];
        }
        rowSum[i] = sumRow;
    }
    return rowSum;
}

int GetMinSum(int[] arr)
{
    int min = arr[0];
    int result = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] < min)
        {
            min = arr[i];
            result = i;
        }
    }
    return result = result + 1;
}