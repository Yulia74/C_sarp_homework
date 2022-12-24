// Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел.
// Напишите программу, которая будет построчно выводить массив, 
// добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

int[,,] threeDArray = Create3DArray(2, 2, 2, 10, 100);

Print3DArray(threeDArray);



int[,,] Create3DArray(int x, int y, int z, int min, int max)
{
    int[,,] matr = new int[x, y, z];
    Random rnd = new Random();

    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            for (int k = 0; k < matr.GetLength(2); k++)
            {
                int next = 0;
                while (true)
                {
                    next = rnd.Next(min, max);
                    if (!Contains(matr, next))
                    break;
                }
                matr[i, j, k] = next;
            }
        }
    }
    return matr;
}

bool Contains(int[,,] matr, int value)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            for (int k = 0; k < matr.GetLength(2); k++)
            {
                if (matr[i, j, k] == value) return true;
            }
        }
    }
    return false;
}

void Print3DArray(int[,,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            for (int k = 0; k < matr.GetLength(2); k++)
            {
                Console.WriteLine($"{matr[i, j, k]} ({i}, {j}, {k})");
            }
        }
    }
}

