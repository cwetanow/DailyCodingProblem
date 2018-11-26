using System;
using System.Linq;

namespace Task04
{
	public class Program
	{
		public static void Main(string[] args)
		{
			var input = Console.ReadLine()
				.Split(' ')
				.Select(int.Parse)
				.ToHashSet();

			var minPositiveNumber = 1;
			while (true)
			{
				if (!input.Contains(minPositiveNumber))
				{
					break;
				}

				minPositiveNumber++;
			}

			Console.WriteLine(minPositiveNumber);
		}
	}
}
