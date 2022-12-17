Console.WriteLine("Задача 64");
Console.WriteLine("Введите целое число n:");
int n = 0;
Int32.TryParse(Console.ReadLine(), out n);
Recur(n);

 static void Recur(int n)
{
    if (n == 1) Console.Write(n + ", ");
    else
    {
        Console.Write(n + ", ");
        Recur(n - 1);
    }
}