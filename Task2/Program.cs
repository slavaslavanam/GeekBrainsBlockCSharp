// See https://aka.ms/new-console-template for more information
int a, b;
Console.WriteLine("Задача 2 \r\nВведите число a:");
bool result = int.TryParse( Console.ReadLine(), out a);
Console.WriteLine("Введите b:");
result = int.TryParse( Console.ReadLine(), out b);
if (result)
{
    Console.WriteLine( a > b ? $"max = {a}" : $"max = {b}");
    Console.ReadLine();
}
else
{
    Console.WriteLine("Некорректный ввод");
}