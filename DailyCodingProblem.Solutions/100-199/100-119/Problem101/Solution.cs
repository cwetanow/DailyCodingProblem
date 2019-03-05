using System;
using System.Collections.Generic;
using System.Linq;

namespace DailyCodingProblem.Solutions.Problem101
{
	public class Solution
	{
		public static (int left, int right) GetPrimeNumbersWithSum(int sum)
		{
			var left = 2;
			var right = sum - left;

			var solutions = new List<(int left, int right)>();

			while (left <= right)
			{
				if (IsPrime(left) && IsPrime(right))
				{
					solutions.Add((left, right));
				}

				left++;
				right--;
			}

			var solution = solutions.FirstOrDefault();

			for (var i = 1; i < solutions.Count; i++)
			{
				solution = CompareSolutions(solution, solutions[i]);
			}

			return solution;
		}

		private static (int left, int right) CompareSolutions((int left, int right) first,
			(int left, int right) second)
		{
			if (first.left <= second.left && first.right < second.right)
			{
				return first;
			}

			return second;
		}

		private static bool IsPrime(int number)
		{
			var sqrt = Math.Sqrt(number);

			for (var i = 2; i < sqrt; i++)
			{
				if (number % i == 0)
				{
					return false;
				}
			}

			return true;
		}
	}
}
