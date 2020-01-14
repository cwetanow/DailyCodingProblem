using System.Collections.Generic;
using DailyCodingProblem.Solutions.Common;

namespace DailyCodingProblem.Solutions.Problem326
{
	public class Solution
	{
		public static Node<int> BuildCartesianTree(IList<int> input)
		{
			var root = (Node<int>)null;
			var current = (Node<int>)null;

			foreach (var number in input)
			{
				if (root == null)
				{
					root = new Node<int>(number);
					current = root;
				}
				else if (current.Value > number)
				{
					current = new Node<int>(number, current);
					root = current;
				}
				else if (current.Value < number)
				{
					current.Right = new Node<int>(number);
				}
			}

			return root;
		}
	}
}
