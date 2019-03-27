using DailyCodingProblem.Solutions.Common;

namespace DailyCodingProblem.Solutions.Problem127
{
	public class Solution
	{
		public static LinkedList<int> SumNumbers(LinkedList<int> left, LinkedList<int> right)
		{
			var leftNumber = GetNumber(left);
			var rightNumber = GetNumber(right);

			var resultNumber = leftNumber + rightNumber;

			return GetList(resultNumber);
		}

		private static LinkedList<int> GetList(int number)
		{
			var result = new LinkedList<int>();

			while (number > 0)
			{
				result.Add(number % 10);

				number /= 10;
			}

			return result;
		}

		private static int GetNumber(LinkedList<int> linkedList)
		{
			var multiplyer = 1;
			var result = 0;

			var current = linkedList.Root;
			while (current != null)
			{
				result += current.Value * multiplyer;

				multiplyer *= 10;

				current = current.Next;
			}

			return result;
		}
	}
}
