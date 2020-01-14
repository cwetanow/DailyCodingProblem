using System.Collections.Generic;
using System.Linq;

namespace DailyCodingProblem.Solutions.Problem270
{
	public class Solution
	{
		public static int GetMessagePropagationTime(IEnumerable<(int start, int finish, int time)> edges, int n)
		{
			var shortestPaths = Enumerable.Range(0, n + 1)
				.Select(_ => int.MaxValue)
				.ToList();

			var visited = shortestPaths
				.Select(_ => false)
				.ToList();

			GetShortestPaths(edges, n, shortestPaths, visited, 0, 0);

			return shortestPaths.Max();
		}

		private static void GetShortestPaths(IEnumerable<(int start, int finish, int time)> edges, int n, IList<int> shortestPaths, IList<bool> visited, int currentNode, int currentPath)
		{
			if (shortestPaths[currentNode] > currentPath)
			{
				shortestPaths[currentNode] = currentPath;
			}

			if (visited.All(isVisited => isVisited))
			{
				return;
			}

			var nextMoves = edges
				.Where(edge => edge.start == currentNode && !visited[edge.finish])
				.ToList();

			var newVisited = visited
				.Select(v => v)
				.ToList();

			newVisited[currentNode] = true;

			foreach (var (_, finish, time) in nextMoves)
			{
				GetShortestPaths(edges, n, shortestPaths, newVisited, finish, time + currentPath);
			}
		}
	}
}
