// See https://aka.ms/new-console-template for more information
using System.Data;
using System.Linq;

int n = 4;
double value;
Dictionary<string, double> dict = new Dictionary<string, double>() 
{
    {"b1", 0 },
    {"k1", 0 },
    {"b2", 0 },
    {"k2", 0 }
};

foreach (var item in dict)
{
    bool validation2 = false;
    while (!validation2)
    {
        Console.WriteLine($"Введите {item.Key} элемент");
        validation2 = Double.TryParse(Console.ReadLine(), out value);
        if (validation2)
        {
           dict[item.Key] = value;
        }
        else
        {
            Console.WriteLine("Некорректный ввод. Попробуйте снова.");
        }
    }
}

if (dict["k1"] == dict["k2"] && (dict["b1"] == dict["b2"]))
{
    Console.WriteLine("Прямые совпадают");
    return;
}
if (dict["k1"] == dict["k2"])
{
    Console.WriteLine("Прямые параллельны");
    return;
}
else
{
    double x = (dict["b2"] - dict["b1"]) / (dict["k1"] - dict["k2"]);
    double y = (dict["k1"] * (dict["b2"] - dict["b1"])) / (dict["k1"] - dict["k2"]) + dict["b1"];
    Console.WriteLine($"Точка пересечения ({Math.Round(x,1)}, {Math.Round(y, 1)}) ");
    Console.ReadLine();

}


