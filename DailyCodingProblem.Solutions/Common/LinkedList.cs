using System;

namespace DailyCodingProblem.Solutions.Common
{
	public class LinkedList<T> : IComparable<LinkedList<T>>, IEquatable<LinkedList<T>>
		where T : IComparable<T>, IEquatable<T>
	{
		public class LinkedListNode
		{
			public LinkedListNode(T value)
			{
				Value = value;
			}

			public LinkedListNode(T value, LinkedListNode previous)
				: this(value)
			{
				previous.Next = this;
			}

			public T Value { get; set; }

			public LinkedListNode Next { get; set; }
		}

		protected int count;

		public LinkedListNode Root { get; set; }

		public void Add(T element)
		{
			if (this.Root == null)
			{
				this.count = 0;
				this.Root = new LinkedListNode(element);
			}
			else
			{
				var currentNode = this.Root;
				var previousNode = (LinkedListNode)null;

				while (currentNode != null)
				{
					previousNode = currentNode;
					currentNode = currentNode.Next;
				}

				currentNode = new LinkedListNode(element, previousNode);
			}

			this.count++;
		}

		public int CompareTo(LinkedList<T> other)
		{
			return this.Root.Value.CompareTo(other.Root.Value);
		}

		public bool Equals(LinkedList<T> other)
		{
			if (this.count != other.count)
			{
				return false;
			}

			var current = this.Root;
			var otherCurrent = other.Root;

			while (current != null)
			{
				if (!current.Value.Equals(otherCurrent.Value))
				{
					return false;
				}

				current = current.Next;
				otherCurrent = otherCurrent.Next;
			}

			return true;
		}
	}
}
