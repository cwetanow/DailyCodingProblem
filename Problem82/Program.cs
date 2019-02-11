using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem82
{
	public class Program
	{
		public static string TestCase = "Hello world";
		public static int Index = 0;

		public static void Main(string[] args)
		{
			var n = 5;

			var result = Read(n, Read7);
			Console.WriteLine(result);

			result = Read(n, Read7);
			Console.WriteLine(result);

			result = Read(n, Read7);
			Console.WriteLine(result);
		}

		public static char[] Leftover = new char[0];

		public static char[] Read(int n, Func<char[]> read7)
		{
			var result = new List<char>();

			if (Leftover.Length > n)
			{
				result = Leftover.Take(n).ToList();
			}
			else
			{
				if (Leftover.Length > 0)
				{
					result.AddRange(Leftover);
					n -= Leftover.Length;
					Leftover = new char[0];
				}

				const int seven = 7;

				while (n > seven)
				{
					var next7 = read7.Invoke();

					result.AddRange(next7);

					n -= seven;
				}

				var last7 = read7.Invoke();

				result.AddRange(last7.Take(n));
				Leftover = last7.Skip(n).ToArray();
			}

			return result.ToArray();
		}

		public static char[] Read7()
		{
			var result = TestCase
				.Skip(Index * 7)
				.Take(7)
				.ToArray();

			Index++;

			return result;
		}
	}
}
