namespace DailyCodingProblem.Solutions.Problem61
{
	public class Solution
	{
		public static void Test()
		{
		}

		public static long Pow(int number, int power)
		{
			var pows = new int[power];
			pows[0] = 1;
			pows[1] = number;

			var currentPow = 1;
			var currentNumber = number;

			while (true)
			{
				if (currentPow == power)
				{
					return currentNumber;
				}


				if (currentPow * 2 < power)
				{
					currentNumber *= currentNumber;
					currentPow *= 2;
				}
				else
				{
					currentNumber *= number;
					currentPow++;
				}
			}
		}
	}
}
