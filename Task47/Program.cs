int n = 0;
int m = 0;
bool validation = false;
while (!validation)
{
    Console.WriteLine("Задача 47 \r\nВведите n:");

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

double[,] array = new double[m, n];
for (int i = 0; i < m; i++)
    for (int j = 0; j < n; j++)
        array[i, j] = new Random().Next(-99, 99);

for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
        Console.Write(array[i, j] + " ");
    Console.WriteLine();
}

Console.Read();
    
        