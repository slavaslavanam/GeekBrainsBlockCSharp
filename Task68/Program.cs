uint n = 0;
uint m = 0;
Console.WriteLine("Задача 66");
Console.WriteLine("Введите целое число m:");
UInt32.TryParse(Console.ReadLine(), out m);
Console.WriteLine("Введите целое число n:");
UInt32.TryParse(Console.ReadLine(), out n);
Console.WriteLine();
Console.WriteLine("F() = " + Akk(m, n));

static uint Akk(uint n, uint m)
{
    if (n == 0)
        return m + 1;
    else
      if ((n != 0) && (m == 0))
        return Akk(n - 1, 1);
    else
        return Akk(n - 1, Akk(n, m - 1));
}