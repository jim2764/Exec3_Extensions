using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Q1
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int number = 56;
			if (number.IsOdd()) Console.WriteLine("56 is Odd");
			if (number.IsEven()) Console.WriteLine("56 is Even");
		}
	}

	public static class IntExtensions
	{
		public static bool IsOdd(this int number)
		{
			return number % 2 == 1;
		}

		public static bool IsEven(this int number)
		{
			return number % 2 == 0;
		}
	}
}
