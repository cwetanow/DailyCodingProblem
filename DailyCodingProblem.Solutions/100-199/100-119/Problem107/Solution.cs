using System.Collections.Generic;
using System.Linq;
using System.Text;
using DailyCodingProblem.Solutions.Common;

namespace DailyCodingProblem.Solutions.Problem107
{
	public class Solution
	{
		public static string PrintTreeLevelWise(Common.Node<int> root)
		{
			var queue = new Queue<Node<int>>();

			queue.Enqueue(root);

			var builder = new StringBuilder();

			while (queue.Any())
			{
				var current = queue.Dequeue();

				builder.Append($"{current.Value} ");

				if (current.Left != null)
				{
					queue.Enqueue(current.Left);
				}

				if (current.Right != null)
				{
					queue.Enqueue(current.Right);
				}
			}

			return builder.ToString().Trim();
		}
	}
}
