namespace DailyCodingProblem.Solutions.Common
{
	public class LinkedList<T>
	{
		protected class LinkedListNode
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

		protected LinkedListNode root;
		protected int count;

		public void Add(T element)
		{
			if (this.root == null)
			{
				this.count = 0;
				this.root = new LinkedListNode(element);
			}
			else
			{
				var currentNode = this.root;
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
	}
}
