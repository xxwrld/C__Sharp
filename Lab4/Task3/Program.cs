using System;

namespace Task3
{
	class Program
	{
		static void Main(string[] args)
		{
			/*A(x1,y1,z1)
			 *B(x2,y2,z2)
			 *C(x3,y3,z3)
			 *D(x4,y4,z4)
			 */
			double x1, x2, x3, x4, y1, y2, y3, y4, z1, z2, z3, z4;
			//-----------------A-Point---------------//
			Console.Write("x1=");
			x1 = Convert.ToDouble(Console.ReadLine());
			Console.Write("y1=");
			y1 = Convert.ToDouble(Console.ReadLine());
			Console.Write("z1=");
			z1 = Convert.ToDouble(Console.ReadLine());
			//-----------------B-Point---------------//
			Console.Write("x2=");
			x2 = Convert.ToDouble(Console.ReadLine());
			Console.Write("y2=");
			y2 = Convert.ToDouble(Console.ReadLine()); 
			Console.Write("z2=");
			z2 = Convert.ToDouble(Console.ReadLine());
			//-----------------C-Point---------------//
			Console.Write("x3=");
			x3 = Convert.ToDouble(Console.ReadLine()); 
			Console.Write("y3=");
			y3 = Convert.ToDouble(Console.ReadLine());
            Console.Write("z3=");
			z3 = Convert.ToDouble(Console.ReadLine());
			//------------------D-Point---------------//
			Console.Write("x4=");
			x4 = Convert.ToDouble(Console.ReadLine()); 
		    Console.Write("y4=");
			y4 = Convert.ToDouble(Console.ReadLine()); 
			Console.Write("z4=");
			z4 = Convert.ToDouble(Console.ReadLine());
            //---------------------------------------//
			double AB = Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2) + Math.Pow(z1 - z2, 2));
			double CD = Math.Sqrt(Math.Pow(x3 - x4, 2) + Math.Pow(y3 - y4, 2) + Math.Pow(z3 - z4, 2));
			double AD = Math.Sqrt(Math.Pow(x1 - x4, 2) + Math.Pow(y1 - y4, 2) + Math.Pow(z1 - z4, 2));
			double BC = Math.Sqrt(Math.Pow(x2 - x3, 2) + Math.Pow(y2 - y3, 2) + Math.Pow(z2 - z3, 2));

			if (AB == CD && AB == BC && AB == AD)
				Console.WriteLine("Rhomb");
			else
				Console.WriteLine("That`s not rhomb!!!");
		}
	}
}
