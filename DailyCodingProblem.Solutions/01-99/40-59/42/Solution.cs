using System.Collections.Generic;
using System.Linq;

namespace DailyCodingProblem.Solutions.Problem42
{
	public class Solution
	{
		public static IEnumerable<int> GetSubsetThatAddsToK(IList<int> numbers, int k)
		{
			return GetSubsetThatAddsToK(numbers, k, 0, 0, new List<int>());
		}

		private static IEnumerable<int> GetSubsetThatAddsToK(IList<int> numbers, int k, int currentIndex, int currentSum, IEnumerable<int> currentNumbers)
		{
			if (currentSum == k)
			{
				return currentNumbers;
			}

			if (currentSum > k || currentIndex == numbers.Count())
			{
				return null;
			}

			var withNumbers = new List<int>(currentNumbers) {numbers[currentIndex]};
			var with = GetSubsetThatAddsToK(numbers, k, currentIndex + 1, currentSum + numbers[currentIndex],
				withNumbers);

			var without = GetSubsetThatAddsToK(numbers, k, currentIndex + 1, currentSum, currentNumbers);

			return with ?? without;
		}
	}
}
