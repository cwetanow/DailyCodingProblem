using System.Collections.Generic;
using System.Linq;

namespace DailyCodingProblem.Solutions.Problem126
{
	public class Solution
	{
		public static IList<int> RotateList(IList<int> list, int k)
		{
			for (int i = 0; i < k; i++)
			{
				var element = list.First();

				list.RemoveAt(0);

				list.Add(element);
			}

			return list;
		}
	}
}
