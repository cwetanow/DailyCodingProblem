namespace DailyCodingProblem.Solutions.Problem88
{
	public class Solution
	{
		public static int Divide(int divident, int divisor)
		{
			var quotient = 0;

			while (divident >= divisor)
			{
				quotient++;
				divident -= divisor;
			}

			return quotient;
		}
	}
}
