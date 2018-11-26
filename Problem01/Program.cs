using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem01
{
	public class Program
	{
		public static void Main(string[] args)
		{
			var numbers = Console.ReadLine()
				.Split(' ')
				.Select(int.Parse)
				.ToList();

			var k = int.Parse(Console.ReadLine());

			var result = TwoNumbersEqual(numbers, k);
			Console.WriteLine(result);
		}

		public static bool TwoNumbersEqual(List<int> numbers, int k)
		{
			var set = new HashSet<int>();

			foreach (var number in numbers)
			{
				var remaining = k - number;

				if (set.Contains(remaining))
				{
					return true;
				}

				set.Add(number);
			}

			return false;
		}
	}
}
