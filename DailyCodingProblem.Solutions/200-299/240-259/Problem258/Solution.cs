using System.Collections.Generic;
using System.Linq;
using DailyCodingProblem.Solutions.Common;
using Moq;

namespace DailyCodingProblem.Solutions.Problem258
{
	public class Solution
	{
		private static IDictionary<int, List<Node<int>>> levels;

		public static int[] GetBoustrophedonText(Node<int> root)
		{
			var result = new List<int>();

			levels = new Dictionary<int, List<Node<int>>>();

			PopulateLevels(root);

			TraverseBoustrophedon(result);

			return result.ToArray();
		}

		private static void PopulateLevels(Node<int> current, int level = 1)
		{
			if (current == null)
			{
				return;
			}

			if (!levels.ContainsKey(level))
			{
				levels.Add(level, new List<Node<int>>());
			}

			levels[level].Add(current);

			PopulateLevels(current.Left, level + 1);
			PopulateLevels(current.Right, level + 1);
		}

		private static void TraverseBoustrophedon(List<int> values, bool fromLeft = true)
		{
			var level = 1;
			while (level <= levels.Max(l => l.Key))
			{
				var toAdd = levels[level].Select(c => c.Value).ToList();

				if (!fromLeft)
				{
					toAdd.Reverse();
				}

				values.AddRange(toAdd);

				level++;
				fromLeft = !fromLeft;
			}
		}
	}
}
