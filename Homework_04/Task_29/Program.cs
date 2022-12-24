// Напишите программу, которая задаёт массив из 8 элементов и выводит
// их на экран.
// Например  1, 2, 5, 7, 19, 6, 1, 33 -> [1, 2, 5, 7, 19, 6, 1, 33]

Console.Write("Enter the number of elements in the array ");
bool isPower = int.TryParse(Console.ReadLine(), out int size);

if(!isPower)
{
    Console.WriteLine("Incorrect number");
    return;
}
if(size <= 0)
{
    Console.WriteLine("Enter a positive number");
    return;
}

Console.Write("Enter the minimum value of the array elements ");
int min = int.Parse(Console.ReadLine());

Console.Write("Enter the maximum value of the array elements ");
int max = int.Parse(Console.ReadLine());

int[] CreateArray(int size, int min, int max)
{
    int[] arr = new int[size];
    Random random = new Random();
    for (int i = 0; i < size; i++)
    {
        arr[i] = random.Next(min, max+1);
    }
    return arr;
}

void PrintArray(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length - 1; i++)
    {
        Console.Write(arr[i] + ", ");
    }
    Console.Write(arr[arr.Length - 1]);
    Console.Write("]");
}

int[] createArray = CreateArray(size, min, max);
PrintArray(createArray);