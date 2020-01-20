namespace DailyCodingProblem.Solutions.Problem339
{
	public class Solution
	{
		public static bool AreThereThreeEntriesWhichAddUpToK(int k, int[] numbers)
		{
			return AreThereThreeEntriesWhichAddUpToK(k, numbers, 0, 0, 0);
		}

		private static bool AreThereThreeEntriesWhichAddUpToK(int k, int[] numbers, int currentIndex, int currentSum,
			int summedNumbers)
		{
			if (currentIndex == numbers.Length || currentSum > k || summedNumbers > 3)
			{
				return false;
			}

			if (summedNumbers == 2 && (currentSum + numbers[currentIndex] == k))
			{
				return true;
			}

			return AreThereThreeEntriesWhichAddUpToK(k, numbers, currentIndex + 1, currentSum, summedNumbers) ||
				   AreThereThreeEntriesWhichAddUpToK(k, numbers, currentIndex + 1, currentSum + numbers[currentIndex],
					   summedNumbers + 1);
		}
	}
}
