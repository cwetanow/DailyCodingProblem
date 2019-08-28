using System.Linq;

namespace DailyCodingProblem.Solutions.Problem241
{
	public class Solution
	{
		public static int GetHIndex(int[] paperCitations)
		{
			var n = paperCitations.Length;
			var index = 0;

			for (var i = 1; i <= n; i++)
			{
				if (HasIndex(i, paperCitations, n))
				{
					index = i;
				}
			}

			return index;
		}

		public static bool HasIndex(int index, int[] citations, int n)
		{
			return citations
					   .Where(paperCitations => paperCitations >= index)
					   .ToList()
					   .Count >= index;
		}
	}
}
