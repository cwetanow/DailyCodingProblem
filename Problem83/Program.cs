using System;

namespace Problem83
{
	public class Program
	{
		public static void Main(string[] args)
		{
			var root = new Node<string>("a",
				new Node<string>("b",
					new Node<string>("d"),
					new Node<string>("e")),
				new Node<string>("c",
					new Node<string>("f"), null));

			PrintBinaryTree(root);
			Console.WriteLine();

			ReverseBinaryTree(root);
			PrintBinaryTree(root);
		}

		public static void ReverseBinaryTree<T>(Node<T> node)
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

		public static void PrintBinaryTree<T>(Node<T> node)
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
