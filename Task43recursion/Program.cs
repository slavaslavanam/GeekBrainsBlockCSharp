using System.Collections.Generic;

int n;
Console.WriteLine("Задача 43 Рекурсия \r\nВведите число:");
bool validation1 = int.TryParse(Console.ReadLine(), out n);

if (validation1)
{
    int count = GetDigitsCount(n.ToString());
    Console.WriteLine("Кол-во = " + count);
    Console.ReadLine();
}
else
{
    Console.WriteLine("Некорректный ввод");
}




int GetDigitsCount(string str, int charIndex = 0)
{
    if (charIndex == str.Length)
        return 0;
    int digitsCount = 0;
    if (char.IsDigit(str[charIndex]))
        digitsCount = 1;
    digitsCount += GetDigitsCount(str, charIndex + 1);
    return digitsCount;
}