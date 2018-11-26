using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Task03
{
	public class Program
	{
		private const string Empty_Marker = "1";

		public static void Main(string[] args)
		{
			var node = new Node("root", new Node("left", new Node("left.left")), new Node("right"));

			var serialized = Serialize(node);

			Console.WriteLine(serialized);
			node = Deserialize(serialized);

			Console.WriteLine(node.Left.Left.Value);
		}

		public static string Serialize(Node node)
		{
			if (node == null)
			{
				return Empty_Marker + '-';
			}

			var builder = new StringBuilder();

			builder.Append($"{node.Value}-");

			builder.Append(Serialize(node.Left));
			builder.Append(Serialize(node.Right));

			return builder.ToString();
		}

		public static Node Deserialize(string serializedNode)
		{
			var nodes = serializedNode
				.Split('-', StringSplitOptions.RemoveEmptyEntries)
				.ToArray();

			var queue = new Queue<string>(nodes);

			var node = DeserializeNode(queue);

			return node;
		}

		private static Node DeserializeNode(Queue<string> nodes)
		{
			if (nodes.Peek() != null)
			{
				var nextNode = nodes.Dequeue();

				if (nextNode == Empty_Marker)
				{
					return null;
				}

				var node = new Node(nextNode);

				node.Left = DeserializeNode(nodes);

				node.Right = DeserializeNode(nodes);

				return node;
			}

			return null;
		}
	}
}
