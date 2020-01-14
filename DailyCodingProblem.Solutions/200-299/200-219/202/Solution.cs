using System.Collections.Generic;
using System.Linq;

namespace DailyCodingProblem.Solutions.Problem202
{
	public class Solution
	{
		public static bool IsPalindrome(int number)
		{
			var queue = new Queue<int>();
			var stack = new Stack<int>();

			while (number > 0)
			{
				var nextDigit = number % 10;

				queue.Enqueue(nextDigit);
				stack.Push(nextDigit);

				number /= 10;
			}

			while (queue.Any() && stack.Any())
			{
				if (queue.Dequeue() != stack.Pop())
				{
					return false;
				}
			}

			return true;
		}
	}
}
