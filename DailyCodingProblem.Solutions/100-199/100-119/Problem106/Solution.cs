namespace DailyCodingProblem.Solutions.Problem106
{
	public class Solution
	{
		public static bool CanReachLastIndex(int[] list)
		{
			var index = 0;

			while (index < list.Length)
			{
				var current = list[index];

				index += current;

				if (index == list.Length - 1)
				{
					return true;
				}

				if (current == 0 && index < list.Length - 1)
				{
					return false;
				}
			}

			return false;
		}
	}
}
