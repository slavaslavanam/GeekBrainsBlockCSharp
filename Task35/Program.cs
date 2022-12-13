// See https://aka.ms/new-console-template for more information
int n;
List<int> list = new List<int>();
Console.WriteLine("Задача 35\r\nВведите размер массива:");
bool validation1 = int.TryParse(Console.ReadLine(), out n);

if (validation1)
{
    for (int i = 0; i < n; i++)
    {
        list.Add((new Random()).Next(0, 999));
    }
    int count = list.Where(x => x >= 10 && x <= 99).Count();

    Console.WriteLine($"[{string.Join<int>(",", list)}]" + " -> " + count);
    Console.ReadLine();
}
else
{
    Console.WriteLine("Некорректный ввод");
}