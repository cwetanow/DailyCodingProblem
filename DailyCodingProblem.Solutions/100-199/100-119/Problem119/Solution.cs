using System.Collections.Generic;
using System.Linq;

namespace DailyCodingProblem.Solutions.Problem119
{
	public class Solution
	{
		private static IList<(int start, int end)> Intervals;
		private static readonly IList<(int start, int end)> Solutions = new List<(int start, int end)>();

		public static (int start, int end) GetIntervalThatCoversOthers(IList<(int start, int end)> intervals)
		{
			Intervals = Sort(intervals);

			var start = intervals.First().start;
			var end = intervals.Max(interval => interval.end);

			CheckIntervals(start, end);

			var bestSolution = Solutions
				.OrderBy(interval => interval.end - interval.start)
				.First();

			return bestSolution;
		}

		private static void CheckIntervals(int start, int end)
		{
			if (AllNumbersAreInInterval(start, end))
			{
				Solutions.Add((start, end));
			}
			else
			{
				return;
			}

			CheckIntervals(start + 1, end);
			CheckIntervals(start, end - 1);
		}

		private static bool AllNumbersAreInInterval(int start, int end)
		{
			return Intervals.All(i => (i.start <= start && start <= i.end && i.end <= end) ||
									  (start <= i.start && i.start <= end && end <= i.end) ||
									  (start <= i.start && i.end <= end));
		}

		private static IList<(int start, int end)> Sort(IEnumerable<(int start, int end)> intervals)
		{
			return intervals
				.OrderBy(interval => interval.start)
				.ThenBy(interval => interval.end)
				.ToList();
		}
	}
}
