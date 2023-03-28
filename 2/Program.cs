using System;

class Program
{
    static void Main(string[] args)
    {
        double[] xCoords = new double[100];
        double[] yCoords = new double[100];
        int n = 0;
        double x, y;
        do
        {
            x = double.Parse(Console.ReadLine());
            y = double.Parse(Console.ReadLine());
            xCoords[n] = x;
            yCoords[n] = y;
            n++;
        }
        while (x != 0 || y != 0);

        double kx = double.Parse(Console.ReadLine());
        double ky = double.Parse(Console.ReadLine());

        bool isInside = false;
        int i, j = n - 1;
        for (i = 0; i < n; i++)
        {
            if (((yCoords[i] < ky && yCoords[j] >= ky) || (yCoords[j] < ky && yCoords[i] >= ky))
                && (xCoords[i] + (ky - yCoords[i]) / (yCoords[j] - yCoords[i]) * (xCoords[j] - xCoords[i]) < kx))
            {
                isInside = !isInside;
            }
            j = i;
        }

        if (isInside)
        {
            Console.WriteLine("Inside");
        }
        else
        {
            Console.WriteLine("Outside");
        }
    }
}