namespace Task03
{
	public class Node
	{
		public Node(string value = null, Node left = null, Node right = null)
		{
			this.Value = value;
			this.Left = left;
			this.Right = right;
		}

		public string Value { get; set; }

		public Node Left { get; set; }

		public Node Right { get; set; }
	}
}
