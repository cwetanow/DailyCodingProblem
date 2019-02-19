using DailyCodingProblem.Solutions.Common;

namespace DailyCodingProblem.Solutions.Problem08
{
	public class BinaryTree<T>
	{
		private readonly BinaryNode<T> root;

		public BinaryTree(BinaryNode<T> root)
		{
			this.root = root;
		}

		public int GetUnivalTreesCount()
		{
			return this.GetUnivalTreesCount(this.root);
		}

		private int GetUnivalTreesCount(BinaryNode<T> node)
		{
			var result = 0;

			if (this.IsUnival(node))
			{
				result++;
			}

			if (node.Left != null)
			{
				result += GetUnivalTreesCount(node.Left);
			}

			if (node.Right != null)
			{
				result += GetUnivalTreesCount(node.Right);
			}

			return result;
		}

		private bool IsUnival(BinaryNode<T> node)
		{
			var isUnival = true;

			if (node.Left != null)
			{
				var isLeftChildUnival = this.IsUnival(node.Left);

				isUnival = isLeftChildUnival && (node.Value.Equals(node.Left.Value));
			}

			if (isUnival && node.Right != null)
			{
				var isRightChildUnival = this.IsUnival(node.Right);

				isUnival = isRightChildUnival && (node.Value.Equals(node.Right.Value));
			}

			return isUnival;
		}
	}
}
