namespace Problem08
{
	public class Node
	{
		public Node(int value, Node left = null, Node right = null)
		{
			this.Value = value;
			this.Left = left;
			this.Right = right;
		}

		public int Value { get; set; }

		public Node Left { get; set; }

		public Node Right { get; set; }
	}

	public class BinaryTree
	{
		private Node root;

		public BinaryTree(Node root)
		{
			this.root = root;
		}

		public int GetUnivalTreesCount()
		{
			return this.GetUnivalTreesCount(this.root);
		}

		private int GetUnivalTreesCount(Node node)
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

		private bool IsUnival(Node node)
		{
			var isUnival = true;

			if (node.Left != null)
			{
				var isLeftChildUnival = this.IsUnival(node.Left);

				isUnival = isLeftChildUnival && (node.Value == node.Left.Value);
			}

			if (isUnival && node.Right != null)
			{
				var isRightChildUnival = this.IsUnival(node.Right);

				isUnival = isRightChildUnival && (node.Value == node.Right.Value);
			}

			return isUnival;
		}
	}

	public class Program
	{
		public static void Main(string[] args)
		{
			var root = new Node(0, new Node(1), new Node(0, new Node(1, new Node(1), new Node(1)), new Node(0)));

			var tree = new BinaryTree(root);

			var univalCount = tree.GetUnivalTreesCount();

			System.Console.WriteLine(univalCount);
		}
	}
}
