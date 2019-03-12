using System;
using System.Collections.Generic;
using System.Linq;
using DailyCodingProblem.Solutions.Common;

namespace DailyCodingProblem.Solutions.Problem110
{
	public class Solution
	{
		private static readonly List<List<int>> paths = new List<List<int>>();

		public static List<List<int>> GetPathsToLeaves(Node<int> root)
		{
			GetPathsToLeaves(root, new List<int>());

			return paths;
		}

		private static void GetPathsToLeaves(Node<int> node, List<int> currentPath)
		{
			currentPath.Add(node.Value);

			if (node.Left == null && node.Right == null)
			{
				paths.Add(currentPath);
			}

			if (node.Left != null)
			{
				var copy = currentPath
					.Select(x => x)
					.ToList();

				GetPathsToLeaves(node.Left, copy);
			}

			if (node.Right != null)
			{
				var copy = currentPath
					.Select(x => x)
					.ToList();

				GetPathsToLeaves(node.Right, copy);
			}
		}
	}
}
