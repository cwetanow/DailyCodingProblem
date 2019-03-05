namespace DailyCodingProblem.Solutions.Problem63
{
	public class Solution
	{
		public static void Test()
		{

		}

		public static bool CanWordBeFound(char[][] matrix, string word)
		{
			var rows = matrix.Length;

			// Assume that all rows have equal length
			var cols = matrix[0].Length;

			if (word.Length > rows && word.Length > cols)
			{
				return false;
			}

			if (word.Length <= cols)
			{
				for (int row = 0; row < rows; row++)
				{
					var currentLetterIndex = 0;

					for (int col = 0; col < cols; col++)
					{
						if (cols - col < word.Length - currentLetterIndex)
						{
							break;
						}

						if (currentLetterIndex == word.Length)
						{
							return true;
						}

						if (word[currentLetterIndex] == matrix[row][col])
						{
							currentLetterIndex++;
						}
					}

					if (currentLetterIndex == word.Length)
					{
						return true;
					}
				}
			}

			if (word.Length <= rows)
			{
				for (int col = 0; col < cols; col++)
				{
					var currentLetterIndex = 0;

					for (int row = 0; row < rows; row++)
					{
						if (rows - row < word.Length - currentLetterIndex)
						{
							break;
						}

						if (currentLetterIndex == word.Length)
						{
							return true;
						}

						if (word[currentLetterIndex] == matrix[row][col])
						{
							currentLetterIndex++;
						}
					}

					if (currentLetterIndex == word.Length)
					{
						return true;
					}
				}
			}

			return false;
		}
	}
}
