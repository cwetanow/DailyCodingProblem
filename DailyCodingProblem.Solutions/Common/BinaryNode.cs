namespace DailyCodingProblem.Solutions.Common
{
		public class BinaryNode<T>
		{
			public BinaryNode(T value)
			{
				Value = value;
			}

			public BinaryNode(T value, BinaryNode<T> left, BinaryNode<T> right)
				: this(value)
			{
				this.Left = left;
				this.Right = right;
			}

			public BinaryNode<T> Right { get; set; }

			public BinaryNode<T> Left { get; set; }

			public T Value { get; set; }
		}
}
