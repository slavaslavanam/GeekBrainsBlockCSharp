// See https://aka.ms/new-console-template for more information
using System.Linq;

int n, value;
List<int> list = new List<int>();
Console.WriteLine("Задача 4\r\nВведите размер массива:");
bool validation1 = int.TryParse(Console.ReadLine(), out n);

if (validation1)
{
    for (int i = 0; i < n; i++)
    {
        bool validation2 = false;
        while (!validation2)
        {
            Console.WriteLine($"Введите {i + 1} элемент массива");
            validation2 = int.TryParse(Console.ReadLine(), out value);
            if (validation2)
            {
                list.Add(value);
            }
            else
            {
                Console.WriteLine("Некорректный ввод. Попробуйте снова.");
            }
        }

    }
    Console.WriteLine(string.Join<int>(",", list));
    Console.WriteLine("Кол-во элементов >0 : " + list.Where(item => item > 0).Count());
    Console.ReadLine();

}
else
{
    Console.WriteLine("Некорректный ввод");
}