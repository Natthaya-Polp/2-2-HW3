using System;

class Program
{
    static void Main(string[] args)
    {
        double x1 = double.Parse(Console.ReadLine());
        double y1 = double.Parse(Console.ReadLine());
        double x2 = double.Parse(Console.ReadLine());
        double y2 = double.Parse(Console.ReadLine());
        double x3 = double.Parse(Console.ReadLine());
        double y3 = double.Parse(Console.ReadLine());
        Calculate(x1, y1, x2, y2, x3, y3);
    }

    static void Calculate(double x1, double y1, double x2, double y2, double x3, double y3)
    {
        double a = Math.Pow(x2, 2) - Math.Pow(x1, 2) + Math.Pow(y2, 2) - Math.Pow(y1, 2);
        double b = Math.Pow(x3, 2) - Math.Pow(x1, 2) + Math.Pow(y3, 2) - Math.Pow(y1, 2);

        double x = ((y3 - y1) * a - (y2 - y1) * b) / (2 * ((x2 - x1) * (y3 - y1) - (y2 - y1) * (x3 - x1)));
        double y = ((x2 - x1) * b - (x3 - x1) * a) / (2 * ((x2 - x1) * (y3 - y1) - (y2 - y1) * (x3 - x1)));
        double radius = Math.Sqrt((x1 - x) * (x1 - x) + (y1 - y) * (y1 - y));

        Console.WriteLine(x);
        Console.WriteLine(y);
        Console.WriteLine(radius);
    }
}