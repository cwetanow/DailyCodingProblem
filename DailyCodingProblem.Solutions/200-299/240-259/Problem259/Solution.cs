using System.Collections.Generic;
using System.Linq;
using DailyCodingProblem.Solutions.Common;
using Moq;

namespace DailyCodingProblem.Solutions.Problem259
{
	public class Solution
	{
		public static IEnumerable<char> GetStartLetters(ICollection<string> words)
		{
			var result = new List<char>();

			var startLetters = words
				.Where(w => w.Length % 2 == 0 && words.Where(word => word[0] == w[0]).ToList().Count == 1)
				.Select(w => w[0]);

			result.AddRange(startLetters);

			return result;
		}
	}
}
