// See https://aka.ms/new-console-template for more information
int n;
List<int> list = new List<int>();
Console.WriteLine("Задача 36\r\nВведите размер массива:");
bool validation1 = int.TryParse(Console.ReadLine(), out n);

if (validation1)
{
    for (int i = 0; i < n; i++)
    {
        list.Add((new Random()).Next(-999, 999));
    }
    //int count = list.Where(x => x.).Count();

    Console.WriteLine($"[{string.Join<int>(",", list)}]");

    var indexes = list.Select((item, index) => new { Item = item, Index = index })
         .Where(n => n.Index % 2 != 0)
         .Select(n => n.Item);

    list = indexes.ToList();
    Console.WriteLine($"[{string.Join<int>(",", list)}]" + " -> " + list.Sum());
    Console.ReadLine();
}
else
{
    Console.WriteLine("Некорректный ввод");
}