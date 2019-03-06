using System;
using System.Linq;

namespace DailyCodingProblem.Solutions.Problem102
{
	public class Solution
	{
		public static int[] GetContiguousElementsThatSumToK(int[] list, int k)
		{
			var result = new int[] { };

			for (var i = 0; i < list.Length; i++)
			{
				var currentSum = 0;

				for (var j = i; j < list.Length; j++)
				{
					currentSum += list[j];

					if (currentSum > k)
					{
						break;
					}

					if (currentSum == k)
					{
						result = list
							.Skip(i)
							.Take(j - i + 1)
							.ToArray();

						return result;
					}
				}
			}

			return result;
		}
	}
}
