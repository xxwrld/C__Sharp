using System;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            double x1, x2, y1, y2, z1, z2;
            Console.Write("x1=");
            x1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("y1=");
            y1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("z1=");
            z1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("x2=");            
            x2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("y2=");            
            y2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("z2=");
            z2 = Convert.ToDouble(Console.ReadLine());
            double ab = x1 * x2 + y1 * y2 + z1 * z2;
            double ma = Math.Sqrt(Math.Pow(x1, 2) + Math.Pow(y1, 2) + Math.Pow(z1, 2));
            double mb = Math.Sqrt(Math.Pow(x2, 2) + Math.Pow(y2, 2) + Math.Pow(z2, 2));
            double c = Math.Cos(ab / ma * mb);
            Console.WriteLine("Angle={0}", c);
            Console.ReadKey();
        }
    }
}
