// See https://aka.ms/new-console-template for more information
int a;
Console.WriteLine("Задача 6 \r\nВведите число a:");
bool result = int.TryParse(Console.ReadLine(), out a);

if (result)
{
    Console.WriteLine(a % 2 == 0 ? "да" : "нет");
    Console.ReadLine();
}
else
{
    Console.WriteLine("Некорректный ввод");
}