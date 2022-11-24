int A;
Console.WriteLine("Задача 27 \r\nВведите число");
bool resultA = int.TryParse(Console.ReadLine(), out A);



if (resultA)
{
    Console.WriteLine(Sum(A));
    Console.ReadLine();
}
else
{
    Console.WriteLine("Некорректный ввод");
}

static int Sum(int number)
{
    return number.ToString().Select(c => c.ToString()).Sum(x => Convert.ToInt32(x));
}
    