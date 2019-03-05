using System;
using System.Linq;

namespace DailyCodingProblem.Solutions.Problem02
{
	public class Solution
	{
		public static void Test()
		{
			var input = Console.ReadLine()
				.Split(' ')
				.Select(int.Parse)
				.ToArray();

			var result = GetArrayOfProducts(input);

			Console.WriteLine(string.Join(' ', result));
		}

		public static int[] GetArrayOfProducts(int[] input)
		{
			var result = new int[input.Length];

			for (var i = 0; i < result.Length; i++)
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

			return result;
		}
	}
}
