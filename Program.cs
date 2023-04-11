using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LB5
{
	class Program
	{
		static void Main(string[] args)
		{
			int i, a, b, c, sum = 0;
			double srAr, srGr;
			Random rand = new Random();
			Console.WriteLine("");
			for (i = 0; i < 5; i++)
			{
				a = rand.Next(1, 101);
				b = rand.Next(1, 101);
				c = rand.Next(1, 101);
				Console.WriteLine(" {0} {1} {2}", a, b, c);
				srGr = Math.Pow(a * b * c, 1.0 / 3);
				Console.WriteLine("Среднее геометрическое: {0:F2}", srGr);
				srAr = (a + b + c) / 3.0;
				Console.WriteLine("Среднее арифметическое: {0:F2}", srAr);
			}
			
			Console.ReadKey();
		}
	}
}