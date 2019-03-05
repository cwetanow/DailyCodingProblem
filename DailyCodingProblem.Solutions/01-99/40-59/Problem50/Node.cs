namespace DailyCodingProblem.Solutions.Problem50
{
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
