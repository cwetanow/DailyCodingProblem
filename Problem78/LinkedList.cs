using System;

namespace Problem78
{
	namespace Problem78
	{
		public class LinkedList<T> : IComparable<LinkedList<T>>
			where T : IComparable<T>
		{
			public class Node
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

			public Node Root { get; set; }

			public void Add(T element)
			{
				if (this.Root == null)
				{
					this.Root = new Node(element);
				}
				else
				{
					var currentNode = this.Root;
					var previousNode = (Node)null;

					while (currentNode != null)
					{
						previousNode = currentNode;
						currentNode = currentNode.Next;
					}

					currentNode = new Node(element, previousNode);
				}
			}

			public int CompareTo(LinkedList<T> other)
			{
				return this.Root.Value.CompareTo(other.Root.Value);
			}
		}
	}

}
