using System;
using System.Collections.Generic;
using System.Linq;

namespace DailyCodingProblem.Solutions.Problem355
{
	public class Solution
	{
		public static IEnumerable<int> RoundArrayToSmallestDifferenceWithEqualSums(IList<double> input)
		{
			return RoundArrayToSmallestDifferenceWithEqualSums(input, 0, (int)Math.Round(input.Sum()), 0, new List<int>(input.Count)).result;
		}

		private static (IEnumerable<int> result, double differencesSum) RoundArrayToSmallestDifferenceWithEqualSums(IList<double> input,
			int currentIndex,
			int inputSum,
			double differencesSum,
			IList<int> currentResult)
		{
			if (currentIndex == input.Count)
			{
				if (currentResult.Sum() != inputSum)
				{
					return (null, -1);
				}

				return (currentResult, differencesSum);
			}

			var roundedUpList = currentResult.Select(r => r).ToList();
			roundedUpList.Add((int)Math.Ceiling(input[currentIndex]));

			var (roundedUpResult, roundedUpDifferencesSum) = RoundArrayToSmallestDifferenceWithEqualSums(input, currentIndex + 1, inputSum,
				differencesSum + Math.Abs(roundedUpList[currentIndex] - input[currentIndex]), roundedUpList);

			var roundedDownList = currentResult.Select(r => r).ToList();
			roundedDownList.Add((int)Math.Floor(input[currentIndex]));

			var (roundedDownResult, roundedDownDifferencesSum) = RoundArrayToSmallestDifferenceWithEqualSums(input, currentIndex + 1, inputSum,
				differencesSum + Math.Abs(roundedDownList[currentIndex] - input[currentIndex]), roundedDownList);

			if (roundedUpResult != null && roundedDownResult != null)
			{
				return roundedUpDifferencesSum > roundedDownDifferencesSum
					? (roundedDownResult, roundedDownDifferencesSum)
					: (roundedUpResult, roundedUpDifferencesSum);
			}

			return roundedDownResult != null ?
				(roundedDownResult, roundedDownDifferencesSum)
				: (roundedUpResult, roundedUpDifferencesSum); 
		}
	}
}
