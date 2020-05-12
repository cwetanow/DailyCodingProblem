using System;
using System.Collections.Generic;
using System.Linq;

namespace DailyCodingProblem.Solutions.Problem314
{
	public class Solution
	{
		public static int GetMinimumBroadcastRange(IEnumerable<int> listeners, ICollection<int?> towers)
		{
			var minimumRange = int.MinValue;

			foreach (var listener in listeners)
			{
				var previousTower = towers.LastOrDefault(t => t.HasValue && t.Value <= listener);
				var nextTower = towers.FirstOrDefault(t => t.HasValue && t.Value > listener);

				if (previousTower.HasValue && nextTower.HasValue)
				{
					var previousDistance = listener - previousTower.Value;
					var nextDistance = nextTower.Value - listener;

					minimumRange = Math.Max(minimumRange, Math.Min(previousDistance, nextDistance));
				}
				else if (previousTower.HasValue)
				{
					var previousDistance = listener - previousTower.Value;

					minimumRange = Math.Max(minimumRange, previousDistance);
				}
				else if (nextTower.HasValue)
				{
					var nextDistance = nextTower.Value - listener;

					minimumRange = Math.Max(minimumRange, nextDistance);
				}
			}

			return minimumRange;
		}
	}
}
