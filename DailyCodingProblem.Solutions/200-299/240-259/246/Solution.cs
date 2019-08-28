using System.Collections.Generic;
using System.Linq;

namespace DailyCodingProblem.Solutions.Problem246
{
	public class Solution
	{
		public static bool CanWordsBeChained(IList<string> words)
		{
			return words
				.Any(word => CanWordsBeChained(words.Where(w => w != word).ToList(), word, word));
		}

		private static bool CanWordsBeChained(IList<string> remainingWords, string currentWord, string firstWord)
		{
			if (!remainingWords.Any() && currentWord.Last() == firstWord.First())
			{
				return true;
			}

			var nextPossibleWords = remainingWords
				.Where(word => word.StartsWith(currentWord.Last()))
				.ToList();

			return nextPossibleWords
				.Any(word => CanWordsBeChained(remainingWords.Where(w => w != word).ToList(), word, firstWord));
		}
	}
}
