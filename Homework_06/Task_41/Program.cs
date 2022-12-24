// Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 4

Console.Write("Enter a number that determines the size of the array: ");

bool isParsed = int.TryParse(Console.ReadLine(), out int size);

int[] array = CreateArray(size);

PrintArray(array);

int count = GetQuantityOfPositiveNumbers(array);

Console.WriteLine($"The number of positive numbers in a given array {count}");



if (!isParsed)
{
    Console.WriteLine("Incorrect number");
    return;
}
if (size <= 0)
{
    Console.WriteLine("Enter a positive number greater than 0");
    return;
}


int[] CreateArray(int size)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        Console.Write($"Enter {i + 1} array element: ");
        array[i] = int.Parse(Console.ReadLine());
    }
    return array;
}


void PrintArray(int[] array)
{
    Console.WriteLine(@"[{0}]", string.Join("; ", array));
}

int GetQuantityOfPositiveNumbers(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
            count++;
    }
    return count;
}

