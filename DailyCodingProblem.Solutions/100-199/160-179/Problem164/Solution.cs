using System.Collections.Generic;

namespace DailyCodingProblem.Solutions.Problem164
{
	public class Solution
	{
		public static int FindDuplicate(int[] array)
		{
			var set = new HashSet<int>();

			foreach (var number in array)
			{
				if (set.Contains(number))
				{
					return number;
				}

				set.Add(number);
			}

			return 0;
		}
	}
}
