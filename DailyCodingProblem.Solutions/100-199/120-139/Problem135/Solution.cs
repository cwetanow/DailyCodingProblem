using System;
using DailyCodingProblem.Solutions.Common;
using Moq;

namespace DailyCodingProblem.Solutions.Problem135
{
	public class Solution
	{
		public static int GetMinimumPathSumToLeaf(Node<int> root)
		{
			return GetMinimumPathSumToLeaf(root, 0);
		}

		private static int GetMinimumPathSumToLeaf(Node<int> node, int currentSum)
		{
			// Node is leaf
			if (node == null)
			{
				return currentSum;
			}

			var leftMinSum = GetMinimumPathSumToLeaf(node.Left, currentSum + node.Value);
			var rightMinSum = GetMinimumPathSumToLeaf(node.Right, currentSum + node.Value);

			return Math.Min(leftMinSum, rightMinSum);
		}
	}
}
