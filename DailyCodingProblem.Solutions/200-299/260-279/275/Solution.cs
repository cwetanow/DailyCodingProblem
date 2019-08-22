using System.Text;

namespace DailyCodingProblem.Solutions.Problem275
{
	public class Solution
	{
		private const char InitalChar = '_';

		public static string GetNthTermOfSequence(int n)
		{
			var result = "1";

			for (var i = 0; i < n - 1; i++)
			{
				result = GetNextTerm(result);
			}

			return result;
		}

		private static string GetNextTerm(string term)
		{
			var counter = 0;

			var builder = new StringBuilder();

			var previous = InitalChar;
			var current = InitalChar;

			for (var i = 0; i < term.Length; i++)
			{
				current = term[i];

				if (current != previous && previous != InitalChar)
				{
					builder.Append(counter);
					builder.Append(term[i - 1]);

					counter = 1;
				}
				else
				{
					counter++;
				}

				previous = current;
			}

			builder.Append(counter);
			builder.Append(current);

			return builder.ToString();
		}
	}
}
