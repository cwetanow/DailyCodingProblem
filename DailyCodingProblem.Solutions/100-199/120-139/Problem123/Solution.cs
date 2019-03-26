using System.Globalization;

namespace DailyCodingProblem.Solutions.Problem123
{
	public class Solution
	{
		public static bool IsNumber(string input)
		{
			return double.TryParse(input, NumberStyles.Any, CultureInfo.InvariantCulture, out double result);
		}
	}
}
