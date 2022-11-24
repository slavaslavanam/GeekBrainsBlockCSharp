using System.Text.RegularExpressions;

string? a = "";
Console.WriteLine("Задача 13 \r\n");
Regex regex = new Regex(@"^\d+$");

do
{
    Console.WriteLine("Введите число. Цифры от 0 - 9");
    a = Console.ReadLine();

} while (a == null || !regex.Match(a).Success);

if (a.Length > 3)
{
    Console.WriteLine(a[2]);
}
else
    Console.WriteLine("третьей цифры нет");
Console.ReadLine();