using System.Collections.Generic;

namespace DailyCodingProblem.Solutions.Problem140
{
	public class Solution
	{
		public static IEnumerable<int> FindElementsThatAppearOnce(List<int> list)
		{
			var result = new HashSet<int>();

			foreach (var element in list)
			{
				if (result.Contains(element))
				{
					result.Remove(element);
				}
				else
				{
					result.Add(element);
				}
			}

			return result;
		}
	}
}
