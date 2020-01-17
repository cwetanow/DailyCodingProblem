using System.Collections.Generic;
using System.Linq;

namespace DailyCodingProblem.Solutions.Problem149
{
	public class Solution
	{
		private readonly List<int> list;

		public Solution(List<int> list)
		{
			this.list = list;
		}

		public int GetSublistSum(int start, int end) => list
				.Where((_, index) => index >= start && index < end)
				.Sum();
	}
}
