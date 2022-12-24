// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить 
// произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

int[,] array1 = CreateRandom2DArray(2, 2, 1, 10);

Console.WriteLine("Matrix A");

Print2DArray(array1);

Console.WriteLine("Matrix B");

int[,] array2 = CreateRandom2DArray(2, 2, 1, 10);

Print2DArray(array2);

Console.WriteLine("Matrix C = Matrix A x Matrix B");

int[,] resultArray = MatrixMultiplication(array1, array2);

Print2DArray(resultArray);



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
    Console.WriteLine();
}

int[,] MatrixMultiplication(int[,] array1, int[,] array2)
{
    int[,] newArray = new int[array1.GetLength(0), array2.GetLength(1)];

    for (int i = 0; i < array1.GetLength(0); i++)
    {
        for (int j = 0; j < array2.GetLength(1); j++)
        {
            newArray[i, j] = 0;
            
            for (int k = 0; k < array2.GetLength(0); k++)
            {
                newArray[i, j] += array1[i, k] * array2[k, j];
            }
        }
    }
    return newArray;
}


