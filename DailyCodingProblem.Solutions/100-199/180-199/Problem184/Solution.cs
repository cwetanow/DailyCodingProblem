using System.Linq;

namespace DailyCodingProblem.Solutions.Problem184
{
	public class Solution
	{
		public static int FindGreatestCommonDenominator(int[] numbers)
		{
			var greatestDenominator = numbers.Min();

			while (greatestDenominator > 0)
			{
				if (IsDenominator(numbers, greatestDenominator))
				{
					return greatestDenominator;
				}
			}

			return greatestDenominator;
		}

		private static bool IsDenominator(int[] numbers, int number)
		{
			return numbers
				.All(n => n % number == 0);
		}
	}
}
