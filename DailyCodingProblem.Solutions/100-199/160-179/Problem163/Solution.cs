using System.Collections.Generic;

namespace DailyCodingProblem.Solutions.Problem163
{
	public class Solution
	{
		public static int EvaluateReversePolishNotation(object[] items)
		{
			var stack = new Stack<int>();

			foreach (var item in items)
			{
				if (item is int number)
				{
					stack.Push(number);
				}

				if (item is char @operator)
				{
					var b = stack.Pop();
					var a = stack.Pop();

					var result = DoOperation(a, b, @operator);

					stack.Push(result);
				}
			}

			return stack.Pop();
		}

		private static int DoOperation(int a, int b, char @operator)
		{
			if (@operator == '+')
			{
				return a + b;
			}

			if (@operator == '-')
			{
				return a - b;
			}

			if (@operator == '*')
			{
				return a * b;
			}

			if (@operator == '/')
			{
				return a / b;
			}

			return 0;
		}
	}
}
