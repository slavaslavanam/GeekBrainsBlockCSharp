int n = 0;
int m = 0;
bool validation = false;
List<double> list = new List<double>();
while (!validation)
{
    Console.WriteLine("Задача 52 \r\nВведите n:");

    validation = Int32.TryParse(Console.ReadLine(), out n);
    if (validation)
    {
        validation = true;
    }
    else
    {
        Console.WriteLine("Некорректный ввод. Попробуйте снова.");
    }
}
validation = false;
while (!validation)
{
    Console.WriteLine("Введите m:");

    validation = Int32.TryParse(Console.ReadLine(), out m);
    if (validation)
    {
        validation = true;
    }
    else
    {
        Console.WriteLine("Некорректный ввод. Попробуйте снова.");
    }
}

int[,] array = new int[m, n];
for (int i = 0; i < m; i++)
    for (int j = 0; j < n; j++)
        array[i, j] = new Random().Next(0, 99);

for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
        Console.Write(array[i, j] + " ");
    Console.WriteLine();
}

for (int j = 0; j < n; j++)
{
    List<int> currentSum = new List<int>();
    for (int i = 0; i < m; i++)
    {
        currentSum.Add(array[i, j]); 
    }
    list.Add(currentSum.Average());
}

IEnumerable<double> newCollection =  list.Select(item => Math.Round(item, 1));
Console.WriteLine();
Console.WriteLine(string.Join<double>(",", newCollection));
Console.ReadLine(); 