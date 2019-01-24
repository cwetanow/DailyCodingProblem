
namespace Problem62
{
	public class Program
	{
		public static void Main(string[] args)
		{
		}

		public static int GetNumberOfWaysToCorner(int n, int m)
		{
			return GetNumberOfWaysToPosition(n, m, 1, 1);
		}

		private static int GetNumberOfWaysToPosition(int row, int col, int currentRow, int currentCol)
		{
			if (currentRow == row && currentCol == col)
			{
				return 1;
			}

			var result = 0;

			if (currentRow < row)
			{
				result += GetNumberOfWaysToPosition(row, col, currentRow + 1, currentCol);
			}

			if (currentCol < col)
			{
				result += GetNumberOfWaysToPosition(row, col, currentRow, currentCol + 1);
			}

			return result;
		}
	}
}
