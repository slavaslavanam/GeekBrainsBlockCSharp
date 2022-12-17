Console.WriteLine("Задача 60");
(int n1, int n2, int n3) = GetSize();
CreateArray(n1, n2, n3);

(int n1, int n2, int n3) GetSize()
{
    int n1 = 0;
    int n2 = 0;
    int n3 = 0;
    bool validation = false;
    List<double> list = new List<double>();

    while (!validation)
    {
        Console.WriteLine("Введите n1:");

        validation = Int32.TryParse(Console.ReadLine(), out n1);
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
        Console.WriteLine("Введите n2:");

        validation = Int32.TryParse(Console.ReadLine(), out n2);
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
        Console.WriteLine("Введите n3:");

        validation = Int32.TryParse(Console.ReadLine(), out n3);
        if (validation)
        {
            validation = true;
        }
        else
        {
            Console.WriteLine("Некорректный ввод. Попробуйте снова.");
        }
    }
    return (n1, n2, n3);
}

int[,,] CreateArray(int n1, int n2, int n3)
{
    int[,,] array = new int[n1, n2, n3];
    for (int i = 0; i < n1; i++)
        for (int i2 = 0; i2 < n2; i2++)
            for (int i3 = 0; i3 < n3; i3++)
            {
                array[i, i2, i3] = new Random().Next(0, 99);

            }
    for (int i = 0; i < n1; i++)
    {
        for (int i2 = 0; i2 < n2; i2++)
            for (int i3 = 0; i3 < n3; i3++)
            {
                Console.Write(array[i, i2, i3] + $"({i},{i2},{i3}) ");

            }
        Console.WriteLine();
    }
    return array;
}
