namespace Problem50
{
	public class Program
	{
		private const char Add = '+';
		private const char Subtract = '-';
		private const char Multiply = '*';
		private const char Divide = '/';

		public static void Main()
		{
			var root = new Node('*', new Node('+', new Node(3), new Node(2)), new Node('+', new Node(4), new Node(5)));

			var result = Evaluate(root);

			System.Console.WriteLine(result);
		}

		public static int Evaluate(Node node)
		{
			if (node.Value.HasValue)
			{
				return node.Value.Value;
			}

			var left = Evaluate(node.Left);
			var right = Evaluate(node.Right);

			var result = Evaluate(left, right, node.Sign).Value;

			return result;
		}

		private static int? Evaluate(int left, int right, char sign)
		{
			if (sign == Add)
			{
				return left + right;
			}

			if (sign == Subtract)
			{
				return left - right;
			}

			if (sign == Multiply)
			{
				return left * right;
			}

			if (sign == Divide)
			{
				return left / right;
			}

			return null;
		}
	}

	public class Node
	{
		public Node(int? value)
		{
			Value = value;
		}

		public Node(char sign)
		{
			Sign = sign;
		}

		public Node(char sign, Node left, Node right)
			: this(sign)
		{
			Left = left;
			Right = right;
		}

		public int? Value { get; set; }

		public char Sign { get; set; }

		public Node Left { get; set; }

		public Node Right { get; set; }
	}
}
