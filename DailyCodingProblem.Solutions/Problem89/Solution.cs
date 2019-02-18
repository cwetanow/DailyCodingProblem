using System;
using DailyCodingProblem.Solutions.Common;

namespace DailyCodingProblem.Solutions.Problem89
{
	public class Solution
	{
		public static bool IsBinaryTree<T>(Node<T> root)
			where T : IComparable<T>
		{
			if (root.Left == null && root.Right == null)
			{
				return true;
			}

			if (root.Left != null)
			{
				if (root.Left.Value.CompareTo(root.Value) >= 0)
				{
					return false;
				}

				if (!IsBinaryTree(root.Left))
				{
					return false;
				}
			}

			if (root.Right != null)
			{
				if (root.Right.Value.CompareTo(root.Value) <= 0)
				{
					return false;
				}

				if (!IsBinaryTree(root.Right))
				{
					return false;
				}
			}

			return true;
		}
	}
}
