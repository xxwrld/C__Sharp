using System;

namespace Task4
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.Write("x=");
			double x = Convert.ToDouble(Console.ReadLine());
			Console.Write("n=");
			double num = Convert.ToDouble(Console.ReadLine());
			switch(num)
			{
			    case 1:
					double c1 = Math.Pow(Math.Cos(x), num);
					Console.WriteLine("y={0}", c1);
					break;
				case 2:
					double c2 = Math.Pow(x, num);
					Console.WriteLine("y={0}",c2);
					break;
				case 3:
					double c3 = Math.Pow(num, x);
					Console.WriteLine("y={0}",c3);
					break;
				default:
					Console.WriteLine("y=0");
					break;

			}

		}
	}
}
