int A, B;
Console.WriteLine("Задача 25 \r\nВведите число A и B:");
bool resultA = int.TryParse(Console.ReadLine(), out A);
bool resultB = int.TryParse(Console.ReadLine(), out B);


if (resultA && resultB)
{
    Console.WriteLine(Pow(A, B));
    Console.ReadLine();
}
else
{
    Console.WriteLine("Некорректный ввод");
}

static int Pow(int number, int power)
{
    if (power == 1)
        return number;
    return number * Pow(number, --power);
}