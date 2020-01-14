namespace DailyCodingProblem.Solutions.Common
{
	public class Node<T>
	{
		public Node(T value)
		{
			Value = value;
		}

		public Node(T value, Node<T> left, Node<T> right)
			: this(value)
		{
			this.Left = left;
			this.Right = right;
		}

		public Node(T value, Node<T> left = null, Node<T> right = null, Node<T> parent = null)
			: this(value,left,right)
		{
			this.Parent = parent;
		}

		public Node<T> Right { get; set; }

		public Node<T> Left { get; set; }

		public Node<T> Parent { get; set; }

		public T Value { get; set; }
	}
}
