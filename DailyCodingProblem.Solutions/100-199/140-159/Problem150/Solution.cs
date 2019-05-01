using System;
using System.Collections.Generic;
using System.Linq;

namespace DailyCodingProblem.Solutions.Problem150
{
	public class Solution
	{
		public static IEnumerable<(int x, int y)> FindNearestKPoints(IEnumerable<(int x, int y)> points,
			(int x, int y) center, int k)
		{
			return points
				.OrderBy(p => GetDistance(p, center))
				.Take(k)
				.ToList();
		}

		private static double GetDistance((int x, int y) point, (int x, int y) otherPoint)
		{
			var distance = Math.Pow(point.x - otherPoint.x, 2) + Math.Pow(point.y - otherPoint.y, 2);

			distance = Math.Sqrt(distance);

			return distance;
		}
	}
}
