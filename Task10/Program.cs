using System.Text.RegularExpressions;

string? a = "";
Console.WriteLine("Задача 10 \r\n");
Regex regex = new Regex(@"^\d{3}$");

do
{
    Console.WriteLine("Введите 3 значное число. Цифры от 0 - 9");
    a = Console.ReadLine();

} while (a == null || !regex.Match(a).Success);

Console.WriteLine(a[1]);
Console.ReadLine();