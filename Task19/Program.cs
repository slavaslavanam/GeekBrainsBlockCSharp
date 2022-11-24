using System;
using System.Text.RegularExpressions;

string? a = "";
Console.WriteLine("Задача 19 \r\n");
Regex regex = new Regex(@"^\d{5}$");

do
{
    Console.WriteLine("Введите 5 значное число. Цифры от 0 - 9");
    a = Console.ReadLine();

} while (a == null || !regex.Match(a).Success);

Console.WriteLine(isPalindrome(a) ? "да" : "нет");
Console.ReadLine(); 


static bool isPalindrome(string word)
{
    int length = word.Length;
    // Двигаемся с обоих концов слова к середине
    for (int i = 0; i < (length / 2); i++)
    {
        // Сравниваем символы попарно
        if (word[i] != word[length - i - 1])
        {
            // Если найдено несоответствие - слово не палиндром
            return false;
        }
    }
    return true;
}