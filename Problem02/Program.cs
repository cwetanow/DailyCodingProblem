using System;
using System.Linq;

namespace Task02
{
	public class Program
	{
		public static void Main(string[] args)
		{
			var input = Console.ReadLine()
				.Split(' ')
				.Select(int.Parse)
				.ToArray();

			var result = new int[input.Length];

			for (int i = 0; i < result.Length; i++)
			{
				result[i] = 1;

				for (int j = 0; j < result.Length; j++)
				{
					if (j != i)
					{
						result[i] *= input[j];
					}
				}
			}

			Console.WriteLine(string.Join(' ', result));
		}
	}
}
