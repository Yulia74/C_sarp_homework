// Напишите программу вычисления функции Аккермана с помощью рекурсии.
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

Console.Write("Enter m:  ");

uint m = uint.Parse(Console.ReadLine());

Console.Write("Enter n:  ");

uint n = uint.Parse(Console.ReadLine());


uint res;

res = A(m, n);

Console.WriteLine($"The value of the Ackermann is {res}");

static uint A(uint m, uint n)
{
    if (m == 0)
        return n + 1;
    else
      if ((m != 0) && (n == 0))
        return A(m - 1, 1);
    else
        return A(m - 1, A(m, n - 1));
}