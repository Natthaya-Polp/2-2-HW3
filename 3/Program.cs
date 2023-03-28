using System;

class Program
{
    static void Main(string[] args)
    {
        double x1 = double.Parse(Console.ReadLine());
        double y1 = double.Parse(Console.ReadLine());
        double x2 = double.Parse(Console.ReadLine());
        double y2 = double.Parse(Console.ReadLine());
        double r1 = double.Parse(Console.ReadLine());
        double r2 = double.Parse(Console.ReadLine());

        double d = Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1));

        if (d > r1 + r2 || d < Math.Abs(r1 - r2))
        {
            Console.WriteLine("");
        }
        else if (d == r1 + r2)
        {
            Console.WriteLine(r1);
            Console.WriteLine(r2);
        }
        else
        {
            double a = (r1 * r1 - r2 * r2 + d * d) / (2 * d);
            double h = Math.Sqrt(r1 * r1 - a * a);
            double x3 = x1 + a * (x2 - x1) / d;
            double y3 = y1 + a * (y2 - y1) / d;
            double x4 = x3 + h * (y2 - y1) / d;
            double y4 = y3 - h * (x2 - x1) / d;
            double x5 = x3 - h * (y2 - y1) / d;
            double y5 = y3 + h * (x2 - x1) / d;

            Console.WriteLine(x5);
            Console.WriteLine(y5);
            Console.WriteLine(x4);
            Console.WriteLine(y4);
        }
    }
}