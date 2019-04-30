namespace DailyCodingProblem.Solutions.Problem159
{
	public class Solution
	{
		public static char? FindFirstRecurringCharacter(string input)
		{
			if (input.Length < 2)
			{
				return null;
			}

			var previous = input[0];
			for (var i = 1; i < input.Length; i++)
			{
				var current = input[i];

				if (previous == current)
				{
					return current;
				}

				previous = current;
			}

			return null;
		}
	}
}
