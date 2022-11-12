// See https://aka.ms/new-console-template for more information
int n,value;
List<int> list = new List<int>();
Console.WriteLine("Задача 4\r\nВведите число размер массива:");
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
    Console.WriteLine("Максимальный элемент = " + list.Max());
    Console.ReadLine();

}
else
{
    Console.WriteLine("Некорректный ввод");
}