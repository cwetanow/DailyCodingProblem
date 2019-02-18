using System.Collections.Generic;

namespace DailyCodingProblem.Solutions.Problem06
{
	public class InMemoryLinkedList<T>
	{
		private readonly IDictionary<int, Node> memory = new Dictionary<int, Node>();
		private int memoryAddress = 1;

		private class Node
		{
			public int Address { get; set; }

			public int Both { get; set; }

			public T Value { get; set; }
		}

		private Node Head;

		public void Add(T element)
		{
			if (this.Head == null)
			{
				this.Head = new Node {
					Value = element,
					Both = 0 ^ 0,
					Address = memoryAddress
				};

				this.memory.Add(this.Head.Address, this.Head);
			}
			else
			{
				var current = this.Head;
				var previous = (Node)null;

				while (true)
				{
					var currentAddress = (current.Both ^ (previous == null ? 0 : previous.Address));

					if (currentAddress == 0)
					{
						break;
					}

					previous = current;
					current = this.memory[currentAddress];
				}

				var node = new Node {
					Value = element,
					Both = 0 ^ current.Address,
					Address = memoryAddress
				};

				current.Both = (node.Address ^ (previous == null ? 0 : previous.Address));

				this.memory.Add(node.Address, node);
			}

			memoryAddress++;
		}

		public T Get(int index)
		{
			var current = this.Head;
			var previous = (Node)null;

			for (int i = 0; i < index; i++)
			{
				var nextAddress = (current.Both ^ (previous == null ? 0 : previous.Address));

				previous = current;

				if (!this.memory.ContainsKey(nextAddress))
				{
					return default(T);
				}

				current = this.memory[nextAddress];
			}

			return current.Value;
		}
	}
}
