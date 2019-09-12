using System.Collections.Generic;
using System.Linq;

namespace DailyCodingProblem.Solutions.Problem292
{
	public class Solution
	{
		public static IEnumerable<IEnumerable<int>> FindSatisfactoryPairOfTeams(IList<IList<int>> input)
		{
			var firstTeam = new List<int>();
			var secondTeam = new List<int>();

			for (var i = 0; i < input.Count; i++)
			{
				var studentEnemies = input[i];

				if (!firstTeam.Any(student => studentEnemies.Contains(student)))
				{
					firstTeam.Add(i);
				}
				else if (!secondTeam.Any(student => studentEnemies.Contains(student)))
				{
					secondTeam.Add(i);
				}
				else
				{
					return null;
				}
			}

			return new List<IList<int>> { firstTeam, secondTeam };
		}
	}
}
