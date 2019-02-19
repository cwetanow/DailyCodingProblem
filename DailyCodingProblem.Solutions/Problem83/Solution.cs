using System;
using DailyCodingProblem.Solutions.Common;

namespace DailyCodingProblem.Solutions.Problem83
{
	public class Solution
	{
		public static void Test()
		{
			var root = new BinaryNode<string>("a",
			  new BinaryNode<string>("b",
				new BinaryNode<string>("d"),
				new BinaryNode<string>("e")),
			  new BinaryNode<string>("c",
				new BinaryNode<string>("f"), null));

			PrintBinaryTree(root);
			Console.WriteLine();

			ReverseBinaryTree(root);
			PrintBinaryTree(root);
		}

		public static void ReverseBinaryTree<T>(BinaryNode<T> node)
		{
			if (node.Left == null || node.Right == null)
			{
				return;
			}

			var swapper = node.Left;
			node.Left = node.Right;
			node.Right = swapper;

			ReverseBinaryTree<T>(node.Left);
			ReverseBinaryTree<T>(node.Right);
		}

		public static void PrintBinaryTree<T>(BinaryNode<T> node)
		{
			if (node == null)
			{
				return;
			}

			Console.WriteLine(node.Value);

			PrintBinaryTree<T>(node.Left);
			PrintBinaryTree<T>(node.Right);
		}
	}
}
