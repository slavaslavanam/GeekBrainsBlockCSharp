// See https://aka.ms/new-console-template for more information
int n;
List<int> list = new List<int>();
Console.WriteLine("Задача 34\r\nВведите размер массива:");
bool validation1 = int.TryParse(Console.ReadLine(), out n);

if (validation1)
{
    for (int i = 0; i < n; i++)
    {
        list.Add((new Random()).Next(100, 1000));
    }
    int count = list.Where(x => x % 2 == 0 ).Count();
    
    Console.WriteLine($"[{string.Join<int>(",", list)}]" + " -> " + count);
    Console.ReadLine();
}
else
{
    Console.WriteLine("Некорректный ввод");
}