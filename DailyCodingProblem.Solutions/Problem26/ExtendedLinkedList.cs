namespace DailyCodingProblem.Solutions.Problem26
{
	public class ExtendedLinkedList<T> : Common.LinkedList<T>
	{
		public T RemoveKthLastElement(int k)
		{
			var iterations = this.count - k;

			var currentNode = this.root;
			var previousNode = (LinkedListNode)null;

			while (iterations > 0)
			{
				previousNode = currentNode;
				currentNode = currentNode.Next;
				iterations--;
			}

			previousNode.Next = currentNode.Next;
			this.count--;

			return currentNode.Value;
		}
	}
}
