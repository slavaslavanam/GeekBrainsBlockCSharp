using System.Text.RegularExpressions;

Console.WriteLine("Задача 56.\r\n");
(int columns, int rows) = Get2arraySize();
int[][] mainArray = Create2Array(rows, columns);
int sum = Sum(mainArray[0]);
int row = 0;    
for (int i = 0; i < mainArray.Length; i++)
{
    if (sum > Sum(mainArray[i]))
    {
        sum = Sum(mainArray[i]);
        row = i;
    }
}

Console.WriteLine($"Строка с номером {row + 1} имеет наименьшую сумму равную {sum}");
#region Methods
int Sum(int[] array)
{
    int sum = 0;
    foreach (var item in array)
    {
        sum += item;
    }
    return sum;
}

(int m, int n) Get2arraySize()
{
    int columns = 0;
    int rows = 0;
    bool validation = false;
    List<double> list = new List<double>();
   
    while (!validation)
    {
        Console.WriteLine("Введите кол-во строк:");

        validation = Int32.TryParse(Console.ReadLine(), out rows);
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
        Console.WriteLine("Введите кол-во столбцов:");

        validation = Int32.TryParse(Console.ReadLine(), out columns);
        if (validation)
        {
            validation = true;
        }
        else
        {
            Console.WriteLine("Некорректный ввод. Попробуйте снова.");
        }
    }
    return (columns, rows);
}
int[][] Create2Array(int rows, int columns)
{
    int[][] array = new int[rows][];
    for (int i = 0; i < rows; i++)
    {
        array[i] = new int[columns];
        for (int j = 0; j < columns; j++)
        {
            array[i][j] = new Random().Next(0, 99);
        }
    }

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
            Console.Write(array[i][j] + " ");
        Console.WriteLine();
    }
    return array;
}

void ShowArray(int[][] array)
{
    foreach (var row in array)
    {
        foreach (var item in row)
        {
            Console.Write(item + " ");
        }
        Console.WriteLine();
    }
}
#endregion