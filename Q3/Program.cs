using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q3
{
	internal class Program
	{
		static void Main(string[] args)
		{
			string value = "abcde";
			// 無法轉換的INT
			Console.WriteLine("無法轉換的INT");
			Console.WriteLine(value.ToInt(-1));
			Console.WriteLine();

			// 可以轉換的INT
			value = "2022";
			Console.WriteLine("可以轉換的INT");
			Console.WriteLine(value.ToInt(-1));
		}
	}

	public static class StringExtensions
	{
		public static int ToInt(this string value, int defaultValue)
		{
			bool isValue = int.TryParse(value, out int result);
			return isValue ? result : defaultValue;
		}
	}
}
