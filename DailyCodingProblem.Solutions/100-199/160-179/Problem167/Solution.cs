using System.Collections.Generic;
using System.Linq;

namespace DailyCodingProblem.Solutions.Problem167
{
	public class Solution
	{
		public static IEnumerable<(int first, int second)> GetPairsOfUniqueIndicesWithConcatenationOfWordsIsPalindrome(IList<string> words)
		{
			var result = new List<(int first, int second)>();
			var visited = Enumerable.Range(0, words.Count)
				.Select(_ => Enumerable.Range(0, words.Count).Select(__ => false).ToArray())
				.ToArray();

			for (var i = 0; i < words.Count; i++)
			{
				for (var j = 0; j < words.Count; j++)
				{
					if (i == j || visited[i][j])
					{
						continue;
					}

					if (IsPalindrome(words[i] + words[j]))
					{
						result.Add((i, j));
					}

					if (IsPalindrome(words[j] + words[i]))
					{
						result.Add((j, i));
					}

					visited[i][j] = true;
					visited[j][i] = true;
				}
			}
			return result;
		}

		private static bool IsPalindrome(string input)
		{
			var middle = input.Length / 2;

			for (var i = 0; i <= middle; i++)
			{
				if (input[i] != input[input.Length - i - 1])
				{
					return false;
				}
			}

			return true;
		}
	}
}
