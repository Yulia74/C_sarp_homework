//  Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

int[,] array = CreateRandom2DArray(3, 4);

Print2DArray(array);

Console.Write("Enter the row number, starting the countdown from zero:  ");
int row = Convert.ToInt32(Console.ReadLine()); ;

Console.Write("Enter the column number, starting the countdown from zero:  ");
int column = Convert.ToInt32(Console.ReadLine()); ;

bool result = GetElementsByIndexes(row, column, array);

Console.WriteLine(result);





int[,] CreateRandom2DArray(int rows, int columns)
{
    Random random = new Random();
    int[,] array = new int[rows, columns];

    for (var i = 0; i < array.GetLength(0); i++)
    {
        for (var j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = random.Next(1, 11);
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

bool GetElementsByIndexes(int row, int column, int[,] array)
{
    if (row < array.GetLength(0) || column < array.GetLength(1))
    {
        Console.WriteLine($"An array element with the specified index is equal to {array[row, column]}");
        return true;
    }
    else
    {
        Console.WriteLine("The specified index does not exist");
        return false;
    }
}