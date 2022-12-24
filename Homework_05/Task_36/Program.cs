// Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных индексах.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0


int[] array = GenerateArray(-10,10,10);              
                                                   
PrintArray(array);                                

int sum = SumElementsOddIndexes(array);

Console.WriteLine($"The sum of the elements standing on odd indexes is equal to {sum}.");




int[] GenerateArray(int min, int max, int length)   
{                                                   
    Random random = new Random();                   
    int[] array = new int [length];                  
                                                    
    for (var i = 0; i < array.Length; i++)          
    {
        array[i] = random.Next(min, max + 1);       
    }
    return array;                                  
} 


void PrintArray(int[] array)                       
{
     Console.WriteLine(@"[{0}]", string.Join(",", array)); 
}                                         


int SumElementsOddIndexes(int[] array)
{
    int sum = 0;
    for (var i = 0; i < array.Length; i++)
    {
        if(i % 2 != 0)
        {
            sum = array[i] + sum ;
        }
    }
    return sum;
}
