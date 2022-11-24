int value;
bool res;
string? input;
List<int> list = new List<int>();
Console.WriteLine("Введите целочисленные значения подряд. Для завершение набрать 'stop'");

do
{
    input = Console.ReadLine();
    res = int.TryParse(input, out value);
    if (res)
    {
        list.Add(value);
    }   
    
} while (input != "stop" && input != null);

Console.WriteLine(string.Join(", ", list));
Console.ReadLine();