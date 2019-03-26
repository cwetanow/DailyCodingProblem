using DailyCodingProblem.Solutions.Common;
using System.Collections.Generic;

namespace DailyCodingProblem.Solutions.Problem125
{
	public class Solution
	{
		private static readonly Dictionary<int, Node<int>> nodes = new Dictionary<int, Node<int>>();

		public static int[] GetNodesWithSumK(Node<int> node, int k)
		{
			if (node == null)
			{
				return null;
			}

			var remaining = k - node.Value;

			if (nodes.ContainsKey(remaining))
			{
				return new int[] { nodes[remaining].Value, node.Value };
			}

			nodes.Add(node.Value, node);

			return GetNodesWithSumK(node.Left, k) ?? GetNodesWithSumK(node.Right, k);
		}
	}
}
