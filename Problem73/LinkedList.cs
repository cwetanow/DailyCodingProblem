using System.Collections.Generic;

namespace Problem73
{
	public class LinkedList<T>
	{
		protected class Node
		{
			public Node(T value)
			{
				Value = value;
			}

			public Node(T value, Node previous)
				: this(value)
			{
				previous.Next = this;
			}

			public T Value { get; set; }

			public Node Next { get; set; }
		}

		protected Node root;
		protected int count;

		public void Add(T element)
		{
			if (this.root == null)
			{
				this.count = 0;
				this.root = new Node(element);
			}
			else
			{
				var currentNode = this.root;
				var previousNode = (Node)null;

				while (currentNode != null)
				{
					previousNode = currentNode;
					currentNode = currentNode.Next;
				}

				currentNode = new Node(element, previousNode);
			}

			this.count++;
		}

		public void Reverse()
		{
			var currentNode = this.root;
			var previousNode = (Node)null;

			while (currentNode != null)
			{
				var nextNode = currentNode.Next;

				currentNode.Next = previousNode;
				previousNode = currentNode;
				currentNode = nextNode;
			}

			this.root = previousNode;
		}

		public IList<T> ToList()
		{
			var list = new List<T>();

			if (this.root != null)
			{
				var currentNode = this.root;

				while (currentNode != null)
				{
					list.Add(currentNode.Value);
					currentNode = currentNode.Next;
				}
			}

			return list;
		}
	}
}
