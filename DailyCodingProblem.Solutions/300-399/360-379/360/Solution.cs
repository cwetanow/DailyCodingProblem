using System.Collections.Generic;
using System.Linq;

namespace DailyCodingProblem.Solutions.Problem360
{
	public class Solution
	{
		public static IEnumerable<int> GetPlaylist(List<List<int>> ranks)
		{
			var result = new List<int>();

			while (ranks.Any(ranking => ranking.Any()))
			{
				foreach (var rank in ranks)
				{
					if (rank.Any())
					{
						var next = rank.First();

						var containingRanks = ranks.Where(r => r.Contains(next)).ToList();

						if (containingRanks.Count(r => r.First() != next) == containingRanks.Count - 1 && containingRanks.Count > 1)
						{
							continue;
						}

						ranks
							.Where(r => r.Contains(next))
							.ToList()
							.ForEach(r => r.Remove(next));

						result.Add(next);

						break;
					}
				}
			}

			return result;
		}
	}
}
