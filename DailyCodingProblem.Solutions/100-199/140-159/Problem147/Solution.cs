using System.Collections.Generic;
using System.Linq;

namespace DailyCodingProblem.Solutions.Problem147
{
	public static class Solution
	{
		public static void SortListWithReverse(this List<int> list)
		{
			var sorted = false;

			while (!sorted)
			{
				sorted = true;

				for (var i = 0; i < list.Count - 1; i++)
				{
					if (list[i] > list[i + 1])
					{
						list.ReversePartial(i, i + 1);
						sorted = false;
					}
				}
			}
		}

		public static void ReversePartial(this List<int> list, int i, int j)
		{
			var copy = list.GetRange(i, j - i + 1);
			copy.Reverse();

			for (int k = i; k <= j; k++)
			{
				list[k] = copy[k - i];
			}
		}
	}
}
