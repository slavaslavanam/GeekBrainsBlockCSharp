using System.Net.Http.Headers;
using System.Reflection;
using System.Threading.Tasks.Sources;

int n = 0;
int m = 0;
int position = 0;
int count = 0;
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

validation = false;
while (!validation)
{
    Console.WriteLine("Введите позицию i в массиве:");

    validation = Int32.TryParse(Console.ReadLine(), out position);
    if (validation)
    {
        validation = true;
    }
    else
    {
        Console.WriteLine("Некорректный ввод. Попробуйте снова.");
    }
}


for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        if(count == position - 1)
        {
            Console.WriteLine("Такой элемент найден: " + array[i, j]);
            Console.Read();

            return;
        }
        count++;

    }
}
Console.WriteLine("Такого числа в массиве нет:");
Console.Read();

