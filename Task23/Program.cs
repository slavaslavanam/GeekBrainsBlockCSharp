int n;
List<int> list = new List<int>();
Console.WriteLine("Задача 8 \r\nВведите число N:");
bool result = int.TryParse(Console.ReadLine(), out n);
if (result)
{
    for (int i = 1; i < n + 1; i++)
    {
        list.Add(Pow(i, 3));
    }
    Console.WriteLine(string.Join(", ", list));
    Console.ReadLine();
}
else
{
    Console.WriteLine("Некорректный ввод");
}

static int Pow(int number, int power)
{
    if (power == 1)
        return number;
    return number * Pow(number, --power);
}