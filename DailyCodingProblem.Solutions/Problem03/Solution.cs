using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DailyCodingProblem.Solutions.Common;

namespace DailyCodingProblem.Solutions.Problem03
{
	public class Solution
	{
		private const string EmptyMarker = "1";

		public static void Test()
		{
			var node = new BinaryNode<string>("root", new BinaryNode<string>("left", new BinaryNode<string>("left.left"), null), new BinaryNode<string>("right"));

			var serialized = Serialize(node);

			Console.WriteLine(serialized);
			node = Deserialize(serialized);

			Console.WriteLine(node.Left.Left.Value);
		}

		public static string Serialize(BinaryNode<string> node)
		{
			if (node == null)
			{
				return EmptyMarker + '-';
			}

			var builder = new StringBuilder();

			builder.Append($"{node.Value}-");

			builder.Append(Serialize(node.Left));
			builder.Append(Serialize(node.Right));

			return builder.ToString();
		}

		public static BinaryNode<string> Deserialize(string serializedNode)
		{
			var nodes = serializedNode
				.Split('-', StringSplitOptions.RemoveEmptyEntries)
				.ToArray();

			var queue = new Queue<string>(nodes);

			var node = DeserializeNode(queue);

			return node;
		}

		private static BinaryNode<string> DeserializeNode(Queue<string> nodes)
		{
			if (nodes.Peek() != null)
			{
				var nextNode = nodes.Dequeue();

				if (nextNode == EmptyMarker)
				{
					return null;
				}

				var node = new BinaryNode<string>(nextNode) {
					Left = DeserializeNode(nodes),
					Right = DeserializeNode(nodes)
				};

				return node;
			}

			return null;
		}
	}
}
