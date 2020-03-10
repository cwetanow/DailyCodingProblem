using System.Collections.Generic;
using System.Linq;

namespace DailyCodingProblem.Solutions.Problem237
{
	public class Solution
	{
		public class TreeNode
		{
			public TreeNode(int value, params TreeNode[] children)
			{
				Value = value;
				Children = children.ToList();
			}

			public int Value { get; set; }

			public IList<TreeNode> Children { get; set; }
		}

		public static bool IsTreeSymmetric(TreeNode root, int k) => IsTreeSymmetric(root.Children, k);

		public static bool IsTreeSymmetric(IList<TreeNode> levelNodes, int k)
		{
			if (!levelNodes.Any())
			{
				return true;
			}


			var isCurrentLevelSymmetric = true;

			for (var i = 0; i < k / 2; i++)
			{
				if (levelNodes[i].Value != levelNodes[levelNodes.Count - 1 - i].Value)
				{
					return false;
				}
			}

			var nextLevelNodes = new List<TreeNode>();
			foreach (var t in levelNodes)
			{
				nextLevelNodes.AddRange(t.Children);
			}

			return isCurrentLevelSymmetric && IsTreeSymmetric(nextLevelNodes, k);
		}
	}
}
