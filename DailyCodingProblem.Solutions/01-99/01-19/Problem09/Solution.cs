using System;
using System.Linq;

namespace DailyCodingProblem.Solutions.Problem09
{
	public class Solution
	{
		public static void Test()
		{
			var numbers = GetInput();

			var maxSum = GetMaxSum(numbers);

			Console.WriteLine(maxSum);
		}

		public static int[] GetInput()
		{
			var input = Console.ReadLine()
				.Split(' ')
				.Select(int.Parse)
				.ToArray();

			return input;
		}

		public static int GetMaxSum(int[] numbers)
		{
			var maxSum = FindMaxSum(numbers, 0, 0, false);

			return maxSum;
		}

		private static int FindMaxSum(int[] numbers, int currentIndex, int currentSum, bool isPreviousAdded)
		{
			if (currentIndex == numbers.Length)
			{
				return currentSum;
			}

			var currentMaxSum = currentSum;

			if (!isPreviousAdded)
			{
				var maxIfAddCurrent = FindMaxSum(numbers, currentIndex + 1, currentSum + numbers[currentIndex], true);

				currentMaxSum = Math.Max(maxIfAddCurrent, currentMaxSum);
			}

			var maxIfDontAddCurrent = FindMaxSum(numbers, currentIndex + 1, currentSum, false);

			currentMaxSum = Math.Max(currentMaxSum, maxIfDontAddCurrent);

			return currentMaxSum;
		}
	}
}
