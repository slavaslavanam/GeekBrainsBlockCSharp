// See https://aka.ms/new-console-template for more information
int n;
List<double> list = new List<double>();
Console.WriteLine("Задача 38\r\nВведите размер массива:");
bool validation1 = int.TryParse(Console.ReadLine(), out n);

if (validation1)
{
    for (int i = 0; i < n; i++)
    {
        list.Add((new Random()).Next(-999, 999));
    }

    Console.WriteLine($"[{string.Join<double>(",", list)}]" + " -> " + (list.Max() - list.Min()));
    Console.ReadLine();
}
else
{
    Console.WriteLine("Некорректный ввод");
}