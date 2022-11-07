using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q2
{
	internal class Program
	{
		static void Main(string[] args)
		{
			string value = string.Empty;
			// 空字串
			Console.WriteLine("<<空字串>>");
			Console.WriteLine("這是空字串" + value.Left(10));
			Console.WriteLine();

			// 輸入長度 <= 0
			Console.WriteLine("<<輸入長度 <= 0>>");
			Console.WriteLine("這是空字串" + value.Left(-1));
			Console.WriteLine();

			// 輸入字串小於輸入長度
			value = "abcdefg";
			Console.WriteLine("<<輸入字串小於輸入長度>>");
			Console.WriteLine(value.Left(20));
			Console.WriteLine();

			// 一般擷取
			Console.WriteLine("<<一般擷取 ANS\"abcde\">>");
			Console.WriteLine(value.Left(5));
			Console.WriteLine();
		}
	}

	public static class StringExtensions
	{
		public static string Left(this string value, int length)
		{
			if (string.IsNullOrEmpty(value) || length <= 0) return string.Empty;
			if (value.Length < length) return value;
			return value.Substring(0, length);
		}
	}
}
