using System.Linq;

namespace DailyCodingProblem.Solutions.Problem263
{
	public class Solution
	{
		private static readonly char[] Separators = { ',', ';', ':' };
		private static readonly char[] TerminalMarks = { '.', '!', '?' };

		private const char Space = ' ';

		public static bool IsValidSentence(string sentence)
		{
			if (sentence.Length < 2)
			{
				return false;
			}

			// The sentence must start with a capital letter,
			if (!char.IsUpper(sentence.First()))
			{
				return false;
			}

			// followed by a lowercase letter or a space.
			if (sentence[1] != Space && !char.IsLower(sentence[1]))
			{
				return false;
			}

			// All other characters must be lowercase letters, separators (,,;,:) or terminal marks (.,?,!,‽).
			if (sentence.Skip(1).Any(c => !char.IsLower(c) && !Separators.Contains(c) && !TerminalMarks.Contains(c) && c != Space))
			{
				return false;
			}

			// There must be a single space between each word.
			if (sentence.Skip(1).Where((c, index) => c == Space && sentence[index] == Space).Any())
			{
				return false;
			}


			//	The sentence must end with a terminal mark immediately following a word.
			if (!TerminalMarks.Contains(sentence.Last()) || !char.IsLetter(sentence[sentence.Length - 2]) || !char.IsLower(sentence[sentence.Length - 2]))
			{
				return false;
			}

			return true;
		}
	}
}
