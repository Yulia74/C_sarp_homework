// Задача 23. Напишите программу, которая принимает на вход число (N)
// и выдаёт таблицу кубов чисел от 1 до N. Задание должно быть выполнено
// в методе и метод должен вернуть массив чисел.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

int N = InputInt();

int[] cubesTable = GetTableOfCubes(N);

PrintArray(cubesTable);






int InputInt()
{
    Console.WriteLine("Введите целое число");
    bool isN = int.TryParse(Console.ReadLine(), out int N);
    if (isN)
    {
        return N;
    }
    else
    {
        Console.WriteLine("Вы ввели некорректное значение");
        return -1;
    }
}


int [] GetTableOfCubes(int N)
{
    int[] arr = new int[N];
    int i = 0;
    while (i < N)
    {
        arr[i] = (int)(Math.Pow(i+1, 3));
        i++;                         
    }
    return arr;
}


void PrintArray (int[] arr)
{
       int i = 0;
    while (i < N)
    {
        Console.Write($"{arr[i]} ");
        i++;
    }
}
