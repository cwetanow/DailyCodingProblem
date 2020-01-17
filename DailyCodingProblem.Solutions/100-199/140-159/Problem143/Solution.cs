using System.Collections.Generic;
using System.Linq;

namespace DailyCodingProblem.Solutions.Problem143
{
	public class Solution
	{
		public static IEnumerable<int> PartitionList(List<int> input, int x)
		{
			var smaller = new LinkedList<int>();
			var bigger = new LinkedList<int>();
			var same = new LinkedList<int>();

			foreach (var element in input)
			{
				if (element < x)
				{
					smaller.AddLast(element);
				}
				else if (element > x)
				{
					bigger.AddLast(element);
				}
				else
				{
					same.AddLast(element);
				}
			}

			foreach (var i in bigger)
			{
				same.AddLast(i);
			}

			foreach (var i in same)
			{
				smaller.AddLast(i);
			}

			return smaller.ToList();
		}
	}
}
