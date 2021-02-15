using System;

namespace Task2
{
	class Program
	{
		static void Main(string[] args)
		{
			double x, y;
			Console.Write("x=");
			x = Convert.ToDouble(Console.ReadLine());
			Console.Write("y=");
			y = Convert.ToDouble(Console.ReadLine());

			if (x > y)
			{
				Math.Pow(x, 2);
				y = (x + y) / 2;
			}
			else
			{
				Math.Pow(y, 2);
				x = (x + y) / 2;
			}

			Console.WriteLine("max={0} min={1}", x, y);
		}
	}
}
