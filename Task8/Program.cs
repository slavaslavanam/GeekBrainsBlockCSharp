// See https://aka.ms/new-console-template for more information
int n;
List<int> list = new List<int>();
Console.WriteLine("Задача 8 \r\nВведите число N:");
bool result = int.TryParse(Console.ReadLine(), out n);

if (result)
{
    for (int i = 1; i < n + 1; i++)
    {
        if (i % 2 == 0)
        {
            list.Add(i);
        }
    }
    Console.WriteLine(string.Join(", ", list));
    Console.ReadLine();
}
else
{
    Console.WriteLine("Некорректный ввод");
}