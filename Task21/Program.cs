
using System.Text.RegularExpressions;

string? pointStr1 = "";
string? pointStr2 = "";
Regex regex = new Regex(@"^-?\d+,-?\d+,-?\d+$");

do
{
    Console.WriteLine("Введите point1 в формате #,#,# ");
    pointStr1 = Console.ReadLine();

} while (pointStr1 == null || !regex.Match(pointStr1).Success);

do
{
    Console.WriteLine("Введите point2 в формате #,#,# ");
    pointStr2 = Console.ReadLine();

} while (pointStr2 == null || !regex.Match(pointStr2).Success);

List<double> pointList1 = pointStr1.Split(",").ToList().Select(s => Convert.ToDouble(s)).ToList();
List<double> pointList2 = pointStr2.Split(",").ToList().Select(s => Convert.ToDouble(s)).ToList();

MyPoint point1 = new MyPoint(pointList1[0], pointList1[1], pointList1[2]);
MyPoint point2 = new MyPoint(pointList2[0], pointList2[1], pointList2[2]);

double distance = point1.DistanceTo(point2);

Console.WriteLine("DISTANCE = " + distance);
Console.ReadLine();

class MyPoint
{
    private double x;
    private double y;
    private double z;

    public MyPoint(double x, double y, double z)
    {
        this.x = x;
        this.y = y;
        this.z = z;
    }

    public double X { get => x; set => x = value; }
    public double Y { get => y; set => y = value; }
    public double Z { get => z; set => z = value; }

    public double DistanceTo(MyPoint point)
    {
        var result = Math.Sqrt(Math.Pow((this.X - point.X), 2) + Math.Pow((this.Y - point.Y), 2) + Math.Pow((this.Z - point.Z), 2));
        return Math.Round(result,2);
    }
}