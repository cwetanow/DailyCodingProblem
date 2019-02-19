using DailyCodingProblem.Solutions.Common;

namespace DailyCodingProblem.Solutions.Problem08
{
	public class Solution
	{
		public static void Test()
		{
			var root = new BinaryNode<int>(0, new BinaryNode<int>(1), new BinaryNode<int>(0, new BinaryNode<int>(1, new BinaryNode<int>(1), new BinaryNode<int>(1)), new BinaryNode<int>(0)));

			var tree = new BinaryTree<int>(root);

			var univalCount = tree.GetUnivalTreesCount();

			System.Console.WriteLine(univalCount);
		}
	}
}
