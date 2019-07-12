namespace DailyCodingProblem.Solutions.Problem233
{
	public class Solution
	{
		public static int Fibonacci(int n)
		{
			if (n == 1 || n == 0)
			{
				return 1;
			}

			return Fibonacci(n - 1) + Fibonacci(n - 2);
		}

	}
}
