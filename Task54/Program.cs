using System;

Console.WriteLine("");
(int n, int m) = Get2arraySize();
int[][] mainArray = Create2Array(m, n);

foreach (var row in mainArray)
{
    Sort(row);
}
Console.WriteLine();
Console.WriteLine("Отсортированный массив:\r\n");
ShowArray(mainArray);
Console.ReadLine();

#region Methods
void Sort(int[] nums)
{
    int temp = 0;
    for (int i = 0; i < nums.Length - 1; i++)
    {
        for (int j = i + 1; j < nums.Length; j++)
        {
            if (nums[i] < nums[j])
            {
                temp = nums[i];
                nums[i] = nums[j];
                nums[j] = temp;
            }
        }
    }
}

(int m, int n) Get2arraySize()
{
    int n = 0;
    int m = 0;
    bool validation = false;
    List<double> list = new List<double>();
    while (!validation)
    {
        Console.WriteLine("Введите n:");

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
    return (n, m);
}
int[][] Create2Array(int m, int n)
{
    int[][] array = new int[m][];
    for (int i = 0; i < m; i++)
    {
        array[i] = new int[n];
        for (int j = 0; j < n; j++)
        {
            array[i][j] = new Random().Next(0, 99);
        }
    }

    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
            Console.Write(array[i][j] + " ");
        Console.WriteLine();
    }
    return array;
}

void ShowArray(int[][] array)
{
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
            Console.Write(array[i][j] + " ");
        Console.WriteLine();
    }
}
#endregion