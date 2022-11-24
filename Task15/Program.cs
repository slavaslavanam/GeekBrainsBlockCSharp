using System.Text.RegularExpressions;

string? a = "";
Console.WriteLine("Задача 15 \r\n");
Regex regex = new Regex(@"^[1-7]{1}$");

do
{
    Console.WriteLine("Введите число. Цифра от 0 - 9");
    a = Console.ReadLine();

} while (a == null || !regex.Match(a).Success);

if (Convert.ToDouble(a) > 5)
{
    Console.WriteLine("да");
}
else
    Console.WriteLine("нет");
Console.ReadLine();