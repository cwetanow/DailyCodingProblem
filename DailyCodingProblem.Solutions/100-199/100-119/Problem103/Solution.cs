using System.Linq;

namespace DailyCodingProblem.Solutions.Problem103
{
	public class Solution
	{
		public static string GetShortestSubstringContainingAllCharacters(string input, char[] characters)
		{
			if (!characters.All(input.Contains))
			{
				return null;
			}

			var withoutLeft = GetShortestSubstringContainingAllCharacters(input.Substring(1, input.Length - 1), characters);

			var withoutRight = GetShortestSubstringContainingAllCharacters(input.Substring(0, input.Length - 1), characters);

			if (withoutLeft == null && withoutRight == null)
			{
				return input;
			}

			if (withoutLeft == null)
			{
				return withoutRight;
			}

			if (withoutRight == null)
			{
				return withoutLeft;
			}

			return withoutRight.Length < withoutLeft.Length ? withoutRight : withoutLeft;
		}
	}
}
