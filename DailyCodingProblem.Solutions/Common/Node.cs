using System.Collections.Generic;

namespace DailyCodingProblem.Solutions.Common
{
	public class Node<T>
	{
		public Node(T value)
		{
			this.Value = value;
			this.Children = new List<Node<T>>();
		}

		public Node(T value, Node<T> parent = null, ICollection<Node<T>> children = null)
			: this(value)
		{
			this.Parent = parent;

			if (children != null)
			{
				this.Children = children;
			}
		}

		public T Value { get; set; }

		public ICollection<Node<T>> Children { get; private set; }

		public Node<T> Parent { get; set; }
	}
}
