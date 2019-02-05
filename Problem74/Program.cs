namespace Problem74
{
	public class Program
	{
		public static void Main(string[] args)
		{
		}

		public static int GetXOccurencesCount(int n, int x)
		{
			var count = 0;

			for (int i = 1; i <= n; i++)
			{
				if (x % i == 0 && x / i <= n)
				{
					count++;
				}
			}

			return count;
		}
	}
}
