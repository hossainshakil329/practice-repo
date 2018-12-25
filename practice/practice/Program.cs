using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice
{
	class Program
	{
		static void Main(string[] args)
		{
			int num1, num2, sum;
			Console.WriteLine("Hello world");
			Console.Write("number 1: ");
			num1 = Convert.ToInt32(Console.ReadLine());
			Console.Write("number2: ");
			num2= Convert.ToInt32(Console.ReadLine());
			sum = num1 + num2;
			Console.Write("result:" + sum);
			Console.ReadKey();
		}
	}
}
