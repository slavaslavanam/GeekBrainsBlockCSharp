int n = 0;
int m = 0;
Console.WriteLine("Задача 66");
Console.WriteLine("Введите целое число m:");
Int32.TryParse(Console.ReadLine(), out m);
Console.WriteLine("Введите целое число n:");
Int32.TryParse(Console.ReadLine(), out n);
Console.WriteLine($"sum = {SummN(m, n)}");

static int SummN(int m, int n)
{
    if (m == n)
        return n;
    else
        return m + SummN(m + 1,n);
}